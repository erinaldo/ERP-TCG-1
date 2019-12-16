Imports ERP.EntidadesWCF

Public Class d_EmpresaDescuento
    Private SQL As New SqlHelper
    Private Function Cargar(ByVal o_fila As DataRow) As e_EmpresaDescuento
        Try
            Dim oeEmpresaDescuento = New e_EmpresaDescuento(
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaSis").ToString _
                             , o_fila("IdSucursal").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("IdProducto").ToString _
                             , o_fila("Producto").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("DescuentoContado").ToString _
                             , o_fila("DescuentoCredito").ToString _
                             , o_fila("FechaInicio").ToString _
                             , o_fila("FechaFin").ToString _
                             , o_fila("IdVendedorTrabajador").ToString _
                             , o_fila("VendedorTrabajador").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("FechaCrea").ToString _
                             , o_fila("UsuarioModifica").ToString _
                             , o_fila("FechaModifica").ToString _
                             , o_fila("Activo").ToString
            )
            Return oeEmpresaDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function ExecuteLST(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As DataSet
        Try
            Dim ds As DataSet
            With oeEmpresaDescuento
                ds = SQL.ExecuteDataset("[CMP].[Sp_EmpresaDescuento_LST]" _
                        , .TipoOperacion _
                        , "" _
                        , "" _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdEmpresa _
                        , .Empresa _
                        , .IdProducto _
                        , .Producto _
                        , .IdMoneda _
                        , .Moneda _
                        , .DescuentoContado _
                        , .DescuentoCredito _
                        , .FechaInicio _
                        , .FechaFin _
                        , .IdVendedorTrabajador _
                        , .VendedorTrabajador _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
                        )
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As e_EmpresaDescuento
        Try
            Dim ds As DataSet = ExecuteLST(oeEmpresaDescuento)
            If ds.Tables(0).Rows.Count > 0 Then
                oeEmpresaDescuento = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeEmpresaDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As List(Of e_EmpresaDescuento)
        Try
            Dim ldEmpresaDescuento As New List(Of e_EmpresaDescuento)
            Dim ds As DataSet = ExecuteLST(oeEmpresaDescuento)
            oeEmpresaDescuento = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeEmpresaDescuento = Cargar(o_Fila)
                    ldEmpresaDescuento.Add(oeEmpresaDescuento)
                Next
            End If
            Return ldEmpresaDescuento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean
        Try
            'Using transScope As New TransactionScope()
            Dim stResultado() As String
            With oeEmpresaDescuento
                stResultado = SQL.ExecuteScalar("[CMP].[Sp_EmpresaDescuento_IAE]" _
                        , .TipoOperacion _
                        , .PrefijoID _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdEmpresa _
                        , .Empresa _
                        , .IdProducto _
                        , .Producto _
                        , .IdMoneda _
                        , .Moneda _
                        , .DescuentoContado _
                        , .DescuentoCredito _
                        , .FechaInicio _
                        , .FechaFin _
                        , .IdVendedorTrabajador _
                        , .VendedorTrabajador _
                        , .UsuarioCrea _
                        , .FechaCrea _
                        , .UsuarioModifica _
                        , .FechaModifica _
                        , .Activo
                    ).ToString.Split("_")
                .Id = stResultado(0)
            End With
            'transScope.Complete()
            'End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeEmpresaDescuento As e_EmpresaDescuento) As Boolean
        Try
            With oeEmpresaDescuento
                SQL.ExecuteNonQuery("[CMP].[Sp_EmpresaDescuento_IAE]" _
                       , "E" _
                       , "" _
                       , .Id _
                       , .IdEmpresaSis _
                       , .IdSucursal _
                       , .IdEmpresa _
                       , .Empresa _
                       , .IdProducto _
                       , .Producto _
                       , .IdMoneda _
                       , .Moneda _
                       , .DescuentoContado _
                       , .DescuentoCredito _
                       , .FechaInicio _
                       , .FechaFin _
                       , .IdVendedorTrabajador _
                       , .VendedorTrabajador _
                       , .UsuarioCrea _
                       , .FechaCrea _
                       , .UsuarioModifica _
                       , .FechaModifica _
                       , .Activo
                   )

            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class