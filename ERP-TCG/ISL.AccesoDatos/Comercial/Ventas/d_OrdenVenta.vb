'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions
Imports System.Data.SqlClient

Public Class d_OrdenVenta

    Dim sqlhelper As New SqlHelper

    Private Function Cargar(ByVal o_fila As DataRow) As e_OrdenVenta
        Try
            Dim oeOrdenComercial = New e_OrdenVenta(
                             o_fila("Id").ToString _
                             , o_fila("IdEmpresaSis").ToString _
                             , o_fila("IdSucursal").ToString _
                             , o_fila("IdEmpresa").ToString _
                             , o_fila("Empresa").ToString _
                             , o_fila("IdEmpresaAlterna").ToString _
                             , o_fila("IdTipoPago").ToString _
                             , o_fila("IdEstado").ToString _
                             , o_fila("Estado").ToString _
                             , o_fila("IdMoneda").ToString _
                             , o_fila("Moneda").ToString _
                             , o_fila("IdTrabajadorAprobacion").ToString _
                             , o_fila("TrabajadorAprobacion").ToString _
                             , o_fila("Fecha").ToString _
                             , o_fila("OrdenComercial").ToString _
                             , o_fila("Glosa").ToString _
                             , o_fila("TipoExistencia").ToString _
                             , o_fila("TipoCompra").ToString _
                             , o_fila("NombreTipoCompra").ToString _
                             , o_fila("TipoCambio").ToString _
                             , o_fila("SubTotal").ToString _
                             , o_fila("Impuesto").ToString _
                             , o_fila("Total").ToString _
                             , o_fila("UsuarioCrea").ToString _
                             , o_fila("IndFactSer").ToString _
                             , o_fila("IndFacturado").ToString _
                             , o_fila("IndCantidadVariable").ToString _
                             , o_fila("IdOrden_Referencia").ToString _
                              , o_fila("IndFacturadoProducto").ToString _
                              , o_fila("IdVendedorTrabajador").ToString _
                              , o_fila("DocAsoc").ToString)
            Return oeOrdenComercial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ExecuteLST(ByVal oeOrdenComercial As e_OrdenVenta) As DataSet
        Try
            Dim ds As DataSet
            sqlhelper = New SqlHelper
            With oeOrdenComercial
                ds = sqlhelper.ExecuteDataset("[CMP].[Isp_OrdenVenta_Listar]" _
                        , .TipoOperacion _
                        , .Id _
                        , .IdEmpresaSis _
                        , .IdSucursal _
                        , .IdEmpresa _
                        , .IdEstado _
                        , .IdMoneda _
                        , .OrdenComercial _
                        , .TipoExistencia _
                        , .Fecha _
                        , .FechaCrea _
                        , .IndFacturadoProducto)
            End With
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrdenComercial As e_OrdenVenta) As e_OrdenVenta
        Try
            Dim ds As DataSet = ExecuteLST(oeOrdenComercial)
            If ds.Tables(0).Rows.Count > 0 Then
                oeOrdenComercial = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrdenComercial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Listar(ByVal oeOrdenComercial As e_OrdenVenta) As List(Of e_OrdenVenta)
        Try
            Dim ldOrdenComercial As New List(Of e_OrdenVenta)
            Dim ds As DataSet = ExecuteLST(oeOrdenComercial)
            oeOrdenComercial = Nothing
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrdenComercial = Cargar(o_Fila)
                    ldOrdenComercial.Add(oeOrdenComercial)
                Next
            End If
            Return ldOrdenComercial
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean
        Try
            Dim odOrdenComercialMaterial As New d_OrdenVentaMaterial
            'Dim odOrdenComercialServicio As New d_OrdenComercialServicio
            Dim odOrden As New d_Orden
            'Dim odOrdenComercialOrden As New 
            'Dim oeOrdenComercialOrden As New e_OrdenVentaOrden
            Dim odDocumento As New d_MovimientoDocumento
            Using transScope As New TransactionScope()
                Dim stResultado() As String
                With oeOrdenComercial
                    stResultado = sqlhelper.ExecuteScalar("[CMP].[Isp_OrdenVenta_IAE]" _
                            , .TipoOperacion _
                            , .PrefijoID _
                            , .Id _
                            , "" _
                            , "" _
                            , .IdEmpresa _
                            , .IdEmpresaAlterna _
                            , .IdTipoPago _
                            , .IdEstado _
                            , .IdMoneda _
                            , .IdTrabajadorAprobacion _
                            , .Fecha _
                            , .Glosa _
                            , .Tipo _
                            , .TipoExistencia _
                            , .TipoCompra _
                            , .TipoCambio _
                            , .SubTotal _
                            , .Impuesto _
                            , .Total _
                            , .IndFactSer _
                            , .IndFacturado _
                            , .IndCantidadVariable _
                            , .UsuarioCrea _
                            , .IdOrdenReferencia _
                            , .IndFacturadoProducto _
                            , .IdVendedorTrabajador).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each oe As e_OrdenVentaMaterial In .lstOrdenComercialMaterial
                        If oe.TipoOperacion = "" Then oe.TipoOperacion = "A"
                        oe.IdOrdenComercial = .Id
                        odOrdenComercialMaterial.Guardar(oe)
                    Next
                    'For Each oe As e_OrdenVentaServicio In .lstOrdenComercialServicio
                    '    If oe.TipoOperacion = "" Then oe.TipoOperacion = "A"
                    '    If .TipoOperacion = "T" Then oe.TipoOperacion = "T"
                    '    oe.IdOrdenComercial = .Id
                    '    odOrdenComercialServicio.Guardar(oe)
                    'Next
                    'If .oeOrdenIngreso.TipoOperacion <> "" Then
                    '    odOrden.Guardar(.oeOrdenIngreso)
                    '    oeOrdenComercialOrden.TipoOperacion = "I"
                    '    oeOrdenComercialOrden.IdOrdenComercial = .Id
                    '    oeOrdenComercialOrden.IdOrden = .oeOrdenIngreso.Id
                    '    oeOrdenComercialOrden.UsuarioCrea = .UsuarioCrea
                    '    odOrdenComercialOrden.Guardar(oeOrdenComercialOrden)
                    If .oeOrdenSalida.TipoOperacion <> "" Then
                        odOrden.Guardar(.oeOrdenSalida)
                        .TipoOperacion = "I"
                        'oeOrdenComercialOrden.IdOrdenComercial = .Id
                        'oeOrdenComercialOrden.IdOrden = .oeOrdenSalida.Id
                        'oeOrdenComercialOrden.UsuarioCrea = .UsuarioCrea
                        'odOrdenComercialOrden.Guardar(oeOrdenComercialOrden)
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal oeOrdenComercial As e_OrdenVenta) As Boolean
        Try
            sqlhelper = New SqlHelper
            With oeOrdenComercial
                sqlhelper.ExecuteNonQuery("[CMP].[Isp_OrdenVenta_IAE]", .TipoOperacion, "", .Id, "", "" _
                            , .IdEmpresa, .IdTipoPago, .IdEstado, .IdMoneda, .IdTrabajadorAprobacion, .Fecha, .Glosa _
                            , .Tipo, .TipoExistencia, .TipoCompra, .TipoCambio, .SubTotal, .Impuesto, .Total, .IndFactSer _
                            , .IndFacturado, .IndCantidadVariable, .UsuarioCrea, .IdOrdenReferencia, .IndFacturadoProducto _
                            , .IdVendedorTrabajador)
            End With
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
