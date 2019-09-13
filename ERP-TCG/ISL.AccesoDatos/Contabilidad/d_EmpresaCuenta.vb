Imports ISL.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_EmpresaCuenta
    Private sqlhelper As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_EmpresaCuenta
        Try
            Dim oeEmpresaCuenta = New e_EmpresaCuenta( _
                             o_fila("Id").ToString _
                             , o_fila("IdCuentacontable").ToString _
                             , o_fila("IdProveedorCliente").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Activo").ToString _
                             , o_fila("IndCompraVenta").ToString _
                              , o_fila("ejercicio").ToString _
            )
            Return oeEmpresaCuenta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As e_EmpresaCuenta

        Try
            Dim ds As DataSet
            ds = sqlhelper.ExecuteDataset("CON.Isp_EmpresaCuenta_Listar", "", oeEmpresaCuenta.Id)
            If ds.Tables(0).rows.Count > 0 Then
                oeEmpresaCuenta = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmpresaCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As List(Of e_EmpresaCuenta)
        Try
            Dim ldEmpresaCuenta As New List(Of e_EmpresaCuenta)
            Dim ds As DataSet
            With oeEmpresaCuenta
                ds = sqlhelper.ExecuteDataset("CON.Isp_EmpresaCuenta_Listar", "" _
                        , .Id _
                        , .IdCuentaContable _
                        , .IdProveedorCliente _
                        , .IdMoneda _
                        , .Activo _
                        , .IndCompraVenta _
                        , .Ejercicio _
                        )
            End With
            oeEmpresaCuenta = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmpresaCuenta = Cargar(o_Fila)
                    ldEmpresaCuenta.Add(oeEmpresaCuenta)
                Next
            End If
            Return ldEmpresaCuenta
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            With oeEmpresaCuenta
                sqlhelper.ExecuteNonQuery("CON.Isp_EmpresaCuenta_IAE", .TipoOperacion, .PrefijoID, _
                        .Id _
                        , .IdCuentaContable _
                        , .IdProveedorCliente _
                        , .IdMoneda _
                        , .Activo _
                        , .IndCompraVenta _
                        , .Ejercicio _
                    )
            End With
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresaCuenta As e_EmpresaCuenta) As Boolean
        Try
            sqlhelper.ExecuteNonQuery("CON.Isp_EmpresaCuenta_IAE", "E", _
             "", oeEmpresaCuenta.Id)
            Return True
        Catch ex As Exception
            Throw
            Return False
        End Try
    End Function
End Class
