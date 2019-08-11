Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_RegimenSalud

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_RegimenSalud
        Try
            Dim oeRegimenSalud = New e_RegimenSalud( _
                             o_fila("Id").ToString _
                             , o_fila("IdTrabajador").ToString _
                             , o_fila("Regimen").ToString _
                             , o_fila("IdPlanEPS").ToString _
                             , o_fila("Adicional") _
                             , o_fila("FechaInicio") _
                             , o_fila("FechaFin") _
                             , o_fila("Vigente") _
                             , o_fila("FechaCreacion") _
                             , o_fila("UsuarioCreacion").ToString _
                             , o_fila("FechaModifica") _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("Activo") _
            )
            Return oeRegimenSalud
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeRegimenSalud As e_RegimenSalud) As e_RegimenSalud

        Try
            Dim ds As DataSet

            With oeRegimenSalud
                ds = sqlhelper.ExecuteDataset("PER.Isp_RegimenSalud_Listar", .TipoOperacion, .Id)
            End With

            If ds.Tables(0).Rows.Count > 0 Then
                oeRegimenSalud = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeRegimenSalud
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeRegimenSalud As e_RegimenSalud) As List(Of e_RegimenSalud)
        Try
            Dim ldRegimenSalud As New List(Of e_RegimenSalud)
            Dim ds As DataSet
            With oeRegimenSalud
                ds = sqlhelper.ExecuteDataset("PER.Isp_RegimenSalud_Listar", .TipoOperacion _
                        , .Id _
                        , .IdTrabajador _
                        , .Regimen _
                        , .IdPlanEPS _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigente _
                        , .FechaCreacion _
                        , .UsuarioCreacion _
                        , .FechaModifica _
                        , .UsuarioModifica _
                        , .Activo _
                        )
            End With
            oeRegimenSalud = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeRegimenSalud = Cargar(o_Fila)
                ldRegimenSalud.Add(oeRegimenSalud)
            Next
            Return ldRegimenSalud
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeRegimenSalud As e_RegimenSalud) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeRegimenSalud
                sqlhelper.ExecuteNonQuery("PER.Isp_RegimenSalud_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdTrabajador _
                        , .Regimen _
                        , .IdPlanEPS _
                        , .Adicional _
                        , .FechaInicio _
                        , .FechaFin _
                        , .Vigente _
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

    Public Function Eliminar(ByVal oeRegimenSalud As e_RegimenSalud) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("PER.Isp_RegimenSalud_IAE", "E", _
             "", oeRegimenSalud.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
