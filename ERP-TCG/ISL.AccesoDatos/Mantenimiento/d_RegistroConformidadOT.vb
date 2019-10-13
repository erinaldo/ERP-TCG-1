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

Public Class d_RegistroConformidadOT

    Private sqlhelper As New SqlHelper
    Dim odDetalleRegConformidadOT As New d_DetalleRegConformidadOT

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegistroConformidadOT
        Try
            Dim oeRegistroConformidadOT = New e_RegistroConformidadOT( _
                             o_fila("Id").ToString _
                             , o_fila("Indicador").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("FechaConfirmo").ToString _
                             , o_fila("UsuarioConfirmo").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeRegistroConformidadOT
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As e_RegistroConformidadOT

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("MAN.Isp_RegistroConformidadOT_Listar", "",
            Left(oeRegistroConformidadOT.PrefijoID, 1), "", oeRegistroConformidadOT.Id)

            If ds.Tables(0).Rows.Count > 0 Then
                oeRegistroConformidadOT = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRegistroConformidadOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As List(Of e_RegistroConformidadOT)
        Try
            Dim ldRegistroConformidadOT As New List(Of e_RegistroConformidadOT)
            Dim ds As DataSet
            With oeRegistroConformidadOT
                ds = sqlhelper.ExecuteDataset("MAN.Isp_RegistroConformidadOT_Listar", .TipoOperacion _
                        , .Id _
                        , .Glosa _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Activo _
                        , .UsuarioConfirmo
                        )
            End With
            oeRegistroConformidadOT = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeRegistroConformidadOT = Cargar(o_Fila)
                    ldRegistroConformidadOT.Add(oeRegistroConformidadOT)
                Next
            End If
            Return ldRegistroConformidadOT
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean
        Try
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeRegistroConformidadOT
                    stResultado = sqlhelper.ExecuteScalar("MAN.Isp_RegistroConformidadOT_IAE", .TipoOperacion, .PrefijoID,
                            .Id _
                            , .Indicador _
                            , .Glosa _
                            , .FechaConfirmo _
                            , .UsuarioConfirmo _
                            , .Activo
                        ).ToString.Split("_")

                    For Each Detalle As e_DetalleRegConformidadOT In .lstDetalleRegConformidadOT
                        Detalle.IdRegConformidadOT = stResultado(0)
                        Detalle.UsuarioCreacion = .UsuarioConfirmo
                        Detalle.TipoOperacion = .TipoOperacion
                        Detalle.PrefijoID = oeRegistroConformidadOT.PrefijoID '@0001
                        odDetalleRegConformidadOT.Guardar(Detalle)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeRegistroConformidadOT As e_RegistroConformidadOT) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("MAN.Isp_RegistroConformidadOT_IAE", "E", _
             "", oeRegistroConformidadOT.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
