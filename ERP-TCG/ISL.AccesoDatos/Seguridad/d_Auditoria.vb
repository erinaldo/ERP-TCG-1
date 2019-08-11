Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Auditoria

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Auditoria
        Try
            Dim oeAuditoria = New e_Auditoria( _
                             o_fila("Id").ToString _
                             , o_fila("IdActividadNegocio").ToString _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaCreacion").ToString _
                             , o_fila("Operacion").ToString _
                             , o_fila("IdReferencia").ToString _
                             , o_fila("Codigo").ToString _
                             , o_fila("Referencia").ToString _
                             , o_fila("MacPc").ToString _
            )
            Return oeAuditoria
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeAuditoria As e_Auditoria) As e_Auditoria

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("SGD.Isp_Historial_Listar", oeAuditoria.TipoOperacion, oeAuditoria.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeAuditoria = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeAuditoria
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeAuditoria As e_Auditoria) As List(Of e_Auditoria)
        Try
            Dim ldAuditoria As New List(Of e_Auditoria)
            Dim ds As DataSet
            With oeAuditoria
                ds = sqlhelper.ExecuteDataset("SGD.Isp_Historial_Listar", .TipoOperacion _
                        , .Id _
                        , .IdActividadNegocio _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Operacion _
                        , .IdReferencia _
                        , .Codigo _
                        , .Referencia _
                        , .MacPc _
                        )
            End With
            oeAuditoria = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeAuditoria = Cargar(o_Fila)
                ldAuditoria.Add(oeAuditoria)
            Next
            Return ldAuditoria
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeAuditoria As e_Auditoria) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeAuditoria
                sqlhelper.ExecuteNonQuery("SGD.Isp_Historial_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdActividadNegocio _
                        , .UsuarioCreacion _
                        , .FechaCreacion _
                        , .Operacion _
                        , .IdReferencia _
                        , .Codigo _
                        , .Referencia _
                        , .MacPc _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
