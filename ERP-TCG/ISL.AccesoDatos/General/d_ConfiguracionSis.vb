Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConfiguracionSis
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionSis
        Try
            Dim oeConfiguracionSis = New e_ConfiguracionSis( _
                             o_fila("Id").ToString _
                             , o_fila("Nombre").ToString _
                             , o_fila("NombreTabla").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeConfiguracionSis
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionSis As e_ConfiguracionSis) As e_ConfiguracionSis

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionSis_Listar", "", oeConfiguracionSis.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeConfiguracionSis = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConfiguracionSis
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As List(Of e_ConfiguracionSis)
        Try
            Dim ldConfiguracionSis As New List(Of e_ConfiguracionSis)
            Dim ds As DataSet
            With oeConfiguracionSis
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionSis_Listar", "" _
                        , .Id _
                        , .Nombre _
                        , .NombreTabla _
                        , .Activo _
                        )
            End With
            oeConfiguracionSis = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionSis = Cargar(o_Fila)
                ldConfiguracionSis.Add(oeConfiguracionSis)
            Next
            Return ldConfiguracionSis
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeConfiguracionSis
                sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .Nombre _
                        , .NombreTabla _
                        , .Activo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionSis As e_ConfiguracionSis) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("XXX.ISP_XXXXXXXXXXXXXXX_IAE", "E", _
             "", oeConfiguracionSis.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
