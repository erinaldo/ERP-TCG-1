Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_ConfiguracionSisDet
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_ConfiguracionSisDet
        Try
            Dim oeConfiguracionSisDet = New e_ConfiguracionSisDet( _
                             o_fila("Id").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("IdConfiguracionSis").ToString _
                             , o_fila("Activo").ToString _
            )
            Return oeConfiguracionSisDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As e_ConfiguracionSisDet

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionSisDet_Listar", "", oeConfiguracionSisDet.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeConfiguracionSisDet = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeConfiguracionSisDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As List(Of e_ConfiguracionSisDet)
        Try
            Dim ldConfiguracionSisDet As New List(Of e_ConfiguracionSisDet)
            Dim ds As DataSet
            With oeConfiguracionSisDet
                ds = sqlhelper.ExecuteDataset("STD.Isp_ConfiguracionSisDet_Listar", "" _
                        , .Id _
                        , .Ejercicio _
                        , .IdConfiguracionSis _
                        , .Activo _
                        )
            End With
            oeConfiguracionSisDet = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeConfiguracionSisDet = Cargar(o_Fila)
                ldConfiguracionSisDet.Add(oeConfiguracionSisDet)
            Next
            Return ldConfiguracionSisDet
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As Boolean
        Try
            With oeConfiguracionSisDet
                sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionSisDet_IAE", "I", .PrefijoID,
                        .Id _
                        , .Ejercicio _
                        , .IdConfiguracionSis _
                        , .Activo
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeConfiguracionSisDet As e_ConfiguracionSisDet) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("STD.Isp_ConfiguracionSisDet_IAE", "E", _
             "", oeConfiguracionSisDet.Id)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

End Class
