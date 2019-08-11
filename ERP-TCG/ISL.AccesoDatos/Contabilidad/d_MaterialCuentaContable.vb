Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_MaterialCuentaContable
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_MaterialCuentaContable
        Try
            Dim oeMaterialCuentaContable = New e_MaterialCuentaContable( _
                             o_fila("Id").ToString _
                             , o_fila("IdMaterial").ToString _
                             , o_fila("IdCuentaContable").ToString _
                             , o_fila("Cuenta").ToString _
                             , o_fila("NroCuenta").ToString _
                             , o_fila("Ejercicio").ToString _
                             , o_fila("Activo").ToString _
                              , o_fila("IdCuentaContableActivo").ToString _
            )
            Return oeMaterialCuentaContable
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As e_MaterialCuentaContable

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_MaterialCuentaContable_Listar", "", oeMaterialCuentaContable.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeMaterialCuentaContable = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeMaterialCuentaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As List(Of e_MaterialCuentaContable)
        Try
            Dim ldMaterialCuentaContable As New List(Of e_MaterialCuentaContable)
            Dim ds As DataSet
            With oeMaterialCuentaContable
                ds = sqlhelper.ExecuteDataset("CON.Isp_MaterialCuentaContable_Listar", .TipoOperacion _
                        , .Id _
                        , .IdMaterial _
                        , .IdCuentaContable _
                        , .Ejercicio _
                        , .Activo _
                        )
            End With
            oeMaterialCuentaContable = Nothing
            For Each o_Fila As DataRow In ds.Tables(0).Rows
                oeMaterialCuentaContable = Cargar(o_Fila)
                ldMaterialCuentaContable.Add(oeMaterialCuentaContable)
            Next
            Return ldMaterialCuentaContable
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeMaterialCuentaContable
                sqlhelper.ExecuteNonQuery("CON.Isp_MaterialCuentaContable_IAE", "I", d_DatosConfiguracion.PrefijoID, _
                        .Id _
                        , .IdMaterial _
                        , .IdCuentaContable _
                        , .Ejercicio _
                        , .Activo _
                        , .IdCuentaContableActivo _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeMaterialCuentaContable As e_MaterialCuentaContable) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_MaterialCuentaContable_IAE", "E", _
             "", oeMaterialCuentaContable.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function

End Class