Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_SeguroComplementrio

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_SeguroComplementario
        Try
            Dim oeSeguroComplementario = New e_SeguroComplementario( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("AportaSCTR") _
                             , o_fila("CoberturaPension") _
                             , o_fila("CoberturaSalud") _
                             , o_fila("IdEmpresaEPS").ToString _
                             , o_fila("FechaInicio") _
                             , o_fila("FechaFin") _
                             , o_fila("Vigencia") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeSeguroComplementario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeSeguroComplementario As e_SeguroComplementario) As e_SeguroComplementario

        Try
            Dim ds As DataSet
            With oeSeguroComplementario
                ds = sqlhelper.ExecuteDataset("PER.Isp_SeguroComplementario_Listar", .TipoOperacion, .Id)
            End With
            If ds.Tables(0).Rows.Count > 0 Then
                oeSeguroComplementario = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeSeguroComplementario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeSeguroComplementario As e_SeguroComplementario) As List(Of e_SeguroComplementario)
        Try
            Dim ldSeguroComplementario As New List(Of e_SeguroComplementario)
            Dim ds As DataSet
            With oeSeguroComplementario
                ds = sqlhelper.ExecuteDataset("PER.Isp_SeguroComplementario_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .AportaSCTR _
                        , .CoberturaPension _
                        , .CoberturaSalud _
                        , .IdEmpresaEPS _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeSeguroComplementario = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeSeguroComplementario = Cargar(o_Fila)
                ldSeguroComplementario.Add(oeSeguroComplementario)
            Next
            Return ldSeguroComplementario
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeSeguroComplementario As e_SeguroComplementario) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeSeguroComplementario
                sqlhelper.ExecuteNonQuery("PER.Isp_SeguroComplementario_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .AportaSCTR _
                        , .CoberturaPension _
                        , .CoberturaSalud _
                        , .IdEmpresaEPS _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigencia _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeSeguroComplementario As e_SeguroComplementario) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_SeguroComplementario_IAE", "E", _
             "", oeSeguroComplementario.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
