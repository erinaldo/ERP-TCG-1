Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ProcesoServicio
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ProcesoServicio
        Try
            Dim oeProcesoServicio = New e_ProcesoServicio( _
                             o_fila("Id").ToString _
                             , o_fila("IdServicio").ToString _
                             , o_fila("IdProcesoNegocio").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("Proceso").ToString _
                             , o_fila("Servicio").ToString _
            )
            Return oeProcesoServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerUnico(ByVal oeProcesoServicio As e_ProcesoServicio) As e_ProcesoServicio
        Try
            Dim ds As New DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoServicio_Listar", "L", "", oeProcesoServicio.IdServicio, oeProcesoServicio.IdProcesoNegocio)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoServicio = Cargar(ds.Tables(0).Rows(0))
                Return oeProcesoServicio
            Else
                oeProcesoServicio = New e_ProcesoServicio
                Return oeProcesoServicio
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Obtener(ByVal oeProcesoServicio As e_ProcesoServicio) As e_ProcesoServicio

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoServicio_Listar", oeProcesoServicio.TipoOperacion _
                                          , oeProcesoServicio.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeProcesoServicio = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeProcesoServicio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeProcesoServicio As e_ProcesoServicio) As List(Of e_ProcesoServicio)
        Try
            Dim ldProcesoServicio As New List(Of e_ProcesoServicio)
            Dim ds As DataSet
            With oeProcesoServicio
                ds = sqlhelper.ExecuteDataset("STD.Isp_ProcesoServicio_Listar", .TipoOperacion _
                        , .Id _
                        , .IdServicio _
                        , .IdProcesoNegocio _
                        , .Activo _
                        )
            End With
            oeProcesoServicio = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeProcesoServicio = Cargar(o_Fila)
                ldProcesoServicio.Add(oeProcesoServicio)
            Next
            Return ldProcesoServicio
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeProcesoServicio
                sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoServicio_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdServicio _
                        , .IdProcesoNegocio _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeProcesoServicio As e_ProcesoServicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ProcesoServicio_IAE", "E", _
             "", oeProcesoServicio.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
