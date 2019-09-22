Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_LimiteCredito
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_LimiteCredito
        Try
            Dim oeLimiteCredito = New e_LimiteCredito( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdEmpresaBanco").ToString _
                             , o_Fila("IdTipoDocumento").ToString _
                             , o_Fila("MontoCreditoMN").ToString _
                             , o_Fila("FechaInicial").ToString _
                             , o_Fila("FechaFinal").ToString _
                             , o_Fila("Activo").ToString _
                             , o_Fila("TipoCambio").ToString _
                             , o_Fila("MontoCreditoME").ToString _
                             , o_Fila("IdMoneda").ToString _
            )
            Return oeLimiteCredito
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeLimiteCredito As e_LimiteCredito) As e_LimiteCredito

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("FIN.Isp_LimiteCredito_Listar", "",
            Left(oeLimiteCredito.PrefijoID, 1), "", oeLimiteCredito.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeLimiteCredito = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeLimiteCredito
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeLimiteCredito As e_LimiteCredito) As List(Of e_LimiteCredito)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldLimiteCredito As New List(Of e_LimiteCredito)
            Dim ds As DataSet
            With oeLimiteCredito
                ds = sqlhelper.ExecuteDataset("FIN.Isp_LimiteCredito_Listar", "" _
        , Left(.PrefijoID, 1), "" _
                        , .Id _
                        , .IdEmpresaBanco _
                        , .IdTipoDocumento _
                        , .MontoCreditoMN _
                        , .FechaInicial _
                        , .FechaFinal _
                        , .Activo _
                        , .TipoCambio _
                        , .MontoCreditoME _
                        , .IdMoneda _
                        )
            End With
            oeLimiteCredito = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeLimiteCredito = Cargar(o_Fila)
                    ldLimiteCredito.Add(oeLimiteCredito)
                Next
            End If
            Return ldLimiteCredito
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeLimiteCredito
                sqlhelper.ExecuteNonQuery("FIN.Isp_LimiteCredito_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdEmpresaBanco _
                        , .IdTipoDocumento _
                        , .MontoCreditoMN _
                        , .FechaInicial _
                        , .FechaFinal _
                        , .Activo _
                        , .TipoCambio _
                        , .MontoCreditoME _
                        , .IdMoneda _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeLimiteCredito As e_LimiteCredito) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("FIN.Isp_LimiteCredito_IAE", "E", _
             "", oeLimiteCredito.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
