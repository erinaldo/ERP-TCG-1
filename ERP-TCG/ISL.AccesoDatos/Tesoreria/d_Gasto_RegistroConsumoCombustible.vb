Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_Gasto_RegistroConsumoCombustible
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_Gasto_RegistroConsumoCombustible
        Try
            Dim oeGasto_RegistroConsumoCombustible = New e_Gasto_RegistroConsumoCombustible( _
                             o_Fila("Id").ToString _
                             , o_Fila("IdGastoOperacion").ToString _
                             , o_Fila("IdRegistroConsumoCombustible").ToString _
            )
            Return oeGasto_RegistroConsumoCombustible
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As e_Gasto_RegistroConsumoCombustible

        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("TES.Isp_Gasto_RegistroConsumoCombustible_Listar", "", oeGasto_RegistroConsumoCombustible.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeGasto_RegistroConsumoCombustible = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeGasto_RegistroConsumoCombustible
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As List(Of e_Gasto_RegistroConsumoCombustible)
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim ldGasto_RegistroConsumoCombustible As New List(Of e_Gasto_RegistroConsumoCombustible)
            Dim ds As DataSet
            With oeGasto_RegistroConsumoCombustible
                ds = sqlhelper.ExecuteDataset("TES.Isp_Gasto_RegistroConsumoCombustible_Listar", "" _
                        , d_DatosConfiguracion.PrefijoID _
                        , .Id _
                        , .IdGastoOperacion _
                        , .IdRegistroConsumoCombustible _
                        )
            End With
            oeGasto_RegistroConsumoCombustible = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeGasto_RegistroConsumoCombustible = Cargar(o_Fila)
                    ldGasto_RegistroConsumoCombustible.Add(oeGasto_RegistroConsumoCombustible)
                Next
            End If
            Return ldGasto_RegistroConsumoCombustible
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeGasto_RegistroConsumoCombustible
                sqlhelper.ExecuteNonQuery("TES.Isp_Gasto_RegistroConsumoCombustible_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdGastoOperacion _
                        , .IdRegistroConsumoCombustible _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeGasto_RegistroConsumoCombustible As e_Gasto_RegistroConsumoCombustible) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("TES.Isp_Gasto_RegistroConsumoCombustible_IAE", "E", _
             "", oeGasto_RegistroConsumoCombustible.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class