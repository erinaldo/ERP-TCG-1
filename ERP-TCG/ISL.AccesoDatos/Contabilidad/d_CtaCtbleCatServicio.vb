Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_CtaCtbleCatServicio
    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CtaCtbleCatServicio
        Try
            Dim oeCtaCtble_CatServicio = New e_CtaCtbleCatServicio( _
                             o_fila("Id").ToString _
                             , o_fila("IdCategoriaServicio").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("CuentaContable").ToString _
                             , o_fila("NroCuenta").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("IdItemGasto").ToString _
                             , o_fila("ItemGasto").ToString)
            Return oeCtaCtble_CatServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCtaCtble_CatServicio As e_CtaCtbleCatServicio) As e_CtaCtbleCatServicio
        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_CatServicio_Listar", "", oeCtaCtble_CatServicio.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCtaCtble_CatServicio = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCtaCtble_CatServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeCtaCtble_CatServicio As e_CtaCtbleCatServicio) As List(Of e_CtaCtbleCatServicio)
        Try
            Dim ldCtaCtble_CatServicio As New List(Of e_CtaCtbleCatServicio)
            Dim ds As DataSet
            With oeCtaCtble_CatServicio
                ds = sqlhelper.ExecuteDataset("CON.Isp_CtaCtble_CatServicio_Listar", "" _
                        , .Id _
                        , .IdCategoriaServicio _
                        , .IdCuentaContable _
                        , .IdItemGasto)
            End With
            oeCtaCtble_CatServicio = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCtaCtble_CatServicio = Cargar(o_Fila)
                ldCtaCtble_CatServicio.Add(oeCtaCtble_CatServicio)
            Next
            Return ldCtaCtble_CatServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeCtaCtble_CatServicio As e_CtaCtbleCatServicio) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCtaCtble_CatServicio
                sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_CatServicio_IAE", .TipoOperacion, d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdCategoriaServicio _
                        , .IdCuentaContable _
                        , .IdItemGasto)
            End With
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function Eliminar(ByVal oeCtaCtble_CatServicio As e_CtaCtbleCatServicio) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_CtaCtble_CatServicio_IAE", "E", _
             "", oeCtaCtble_CatServicio.Id)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
