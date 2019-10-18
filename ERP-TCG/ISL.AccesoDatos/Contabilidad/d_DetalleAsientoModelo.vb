'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleAsientoModelo

    Private sqlhelper As New SqlHelper
    Private odReferencia As New d_DetalleModelo_Referencia

    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleAsientoModelo
        Try
            Dim oeDetalleAsientoModelo = New e_DetalleAsientoModelo( _
                             o_fila("Id").ToString _
                             , o_fila("IdAsientoModelo").ToString _
                             , o_fila("AsientoModelo").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Fila").ToString _
                             , o_fila("NivelCuenta").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("CuentaContable").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Partida").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("Formula").ToString _
                             , o_fila("Titulo").ToString _
                             , o_fila("Activo") _
                             , o_fila("Repetir") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModificacion").ToString _
                             , o_fila("FechaModificacion") _
                             , o_fila("IndDocumento"))
            Return oeDetalleAsientoModelo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As e_DetalleAsientoModelo

        Try
            Dim ds As DataSet
            With oeDetalleAsientoModelo
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleAsientoModelo_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).rows.Count > 0 Then
                oeDetalleAsientoModelo = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleAsientoModelo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As List(Of e_DetalleAsientoModelo)
        Try
            Dim ldDetalleAsientoModelo As New List(Of e_DetalleAsientoModelo)
            Dim ds As DataSet
            With oeDetalleAsientoModelo
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleAsientoModelo_Listar", .TipoOperacion _
                        , .Id _
                        , .IdAsientoModelo _
                        , .Codigo _
                        , .Fila _
                        , .IdCuentaContable _
                        , .Cuenta _
                        , .Partida _
                        , .IdMoneda _
                        , .Formula _
                        , .Titulo _
                        , .Activo _
                        , .Repetir _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModificacion _
                        , .FechaModificacion _
                        , .Ejercicio _
                        )
            End With
            oeDetalleAsientoModelo = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleAsientoModelo = Cargar(o_Fila)
                ldDetalleAsientoModelo.Add(oeDetalleAsientoModelo)
            Next
            Return ldDetalleAsientoModelo
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean
        Try
            Dim _idDMR() As String
            Using TransScope As New TransactionScope()
                With oeDetalleAsientoModelo
                    _idDMR = sqlhelper.ExecuteScalar("CON.Isp_DetalleAsientoModelo_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .IdAsientoModelo _
                            , .Codigo _
                            , .Fila _
                            , .NivelCuenta _
                            , .IdCuentaContable _
                            , .Cuenta _
                            , .Partida _
                            , .IdMoneda _
                            , .Formula _
                            , .Titulo _
                            , .Activo _
                            , .Repetir _
                            , .UsuarioCreacion _
                            , .FechaCreacion _
                            , .UsuarioModificacion _
                            , .FechaModificacion
                        ).ToString.Split("_")
                    'Guardar Referencia de Asiento Modelo por Actividad
                    For Each oeReferencia In .leDMReferencia
                        oeReferencia.IdDetalleAsientoModelo = _idDMR(0)
                        oeReferencia.PrefijoID = oeDetalleAsientoModelo.PrefijoID '@0001
                        Select Case oeReferencia.TipoOperacion
                            Case "I", "A" : odReferencia.Guardar(oeReferencia)
                            Case "E" : odReferencia.Eliminar(oeReferencia)
                        End Select
                    Next
                End With
                TransScope.Complete()
                Return True
            End Using
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleAsientoModelo As e_DetalleAsientoModelo) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DetalleAsientoModelo_IAE", "E", _
             "", oeDetalleAsientoModelo.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
