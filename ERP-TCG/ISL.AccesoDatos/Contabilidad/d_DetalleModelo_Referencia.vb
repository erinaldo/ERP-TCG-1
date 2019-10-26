'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_DetalleModelo_Referencia

    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_DetalleModelo_Referencia
        Try
            Dim oeDetalleModelo_Referencia = New e_DetalleModelo_Referencia( _
                             o_fila("Id").ToString _
                             , o_fila("IdDetalleAsientoModelo").ToString _
                             , o_fila("TipoReferencia") _
                             , o_fila("Referencia").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("Formula").ToString _
                             , o_fila("Observacion").ToString _
                             , o_fila("IdConfiguracionColumna").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("Activo") _
                             , o_fila("Fila") _
            )
            Return oeDetalleModelo_Referencia
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As e_DetalleModelo_Referencia

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleModelo_Referencia_Listar", "", oeDetalleModelo_Referencia.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeDetalleModelo_Referencia = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeDetalleModelo_Referencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As List(Of e_DetalleModelo_Referencia)
        Try
            Dim ldDetalleModelo_Referencia As New List(Of e_DetalleModelo_Referencia)
            Dim ds As DataSet
            With oeDetalleModelo_Referencia
                ds = sqlhelper.ExecuteDataset("CON.Isp_DetalleModelo_Referencia_Listar", .TipoOperacion _
                        , .Id _
                        , .IdDetalleAsientoModelo _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .Formula _
                        , .Observacion _
                        , .IdConfiguracionColumna _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo _
                        )
            End With
            oeDetalleModelo_Referencia = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeDetalleModelo_Referencia = Cargar(o_Fila)
                ldDetalleModelo_Referencia.Add(oeDetalleModelo_Referencia)
            Next
            Return ldDetalleModelo_Referencia
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As Boolean
        Try
            With oeDetalleModelo_Referencia
                sqlhelper.ExecuteNonQuery("CON.Isp_DetalleModelo_Referencia_IAE", .TipoOperacion, .PrefijoID,
                        .Id _
                        , .IdDetalleAsientoModelo _
                        , .TipoReferencia _
                        , .IdReferencia _
                        , .Formula _
                        , .Observacion _
                        , .IdConfiguracionColumna _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeDetalleModelo_Referencia As e_DetalleModelo_Referencia) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_DetalleModelo_Referencia_IAE", "E", _
             "", oeDetalleModelo_Referencia.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
