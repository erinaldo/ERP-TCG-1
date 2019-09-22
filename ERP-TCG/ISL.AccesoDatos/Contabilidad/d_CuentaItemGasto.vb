Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient
Public Class d_CuentaItemGasto

    Private sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_CuentaItemGasto
        Try
            Dim oeCuentaItemGasto = New e_CuentaItemGasto( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("IdItemGasto").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("Activo").ToString)
            Return oeCuentaItemGasto
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As e_CuentaItemGasto

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.ISP_CuentaItemGasto_Listar", "", oeCuentaItemGasto.Id)
            If ds.Tables(0).Rows.Count > 0 Then
                oeCuentaItemGasto = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeCuentaItemGasto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As List(Of e_CuentaItemGasto)
        Try
            Dim ldCuentaItemGasto As New List(Of e_CuentaItemGasto)
            Dim ds As DataSet
            With oeCuentaItemGasto
                ds = sqlhelper.ExecuteDataset("CON.ISP_CuentaItemGasto_Listar", .TipoOperacion _
                        , .Id _
                        , .IdCuentaContable _
                        , .IdItemGasto _
                        , .Ejercicio _
                        , .Activo)
            End With
            oeCuentaItemGasto = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeCuentaItemGasto = Cargar(o_Fila)
                ldCuentaItemGasto.Add(oeCuentaItemGasto)
            Next
            Return ldCuentaItemGasto
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeCuentaItemGasto
                sqlhelper.ExecuteNonQuery("CON.ISP_CuentaItemGasto_IAE", "I", _
                                          .PrefijoID, _
                                        .Id _
                                        , .IdCuentaContable _
                                        , .IdItemGasto _
                                        , .Ejercicio _
                                        , .Activo)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeCuentaItemGasto As e_CuentaItemGasto) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.ISP_CuentaItemGasto_IAE", "E", _
             "", oeCuentaItemGasto.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class
