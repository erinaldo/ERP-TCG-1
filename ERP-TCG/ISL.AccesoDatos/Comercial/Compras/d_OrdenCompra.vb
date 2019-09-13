Imports ISL.EntidadesWCF
Imports System.Transactions

Public Class d_OrdenCompra

    Private sqlhelper As New SqlHelper
    Dim odDetalleOrdenMaterial As New d_OrdenCompraMaterial
    Dim odDetalleOrdenServicio As New d_OrdenCompraServicio
    Dim odOrdenCmpCot As New d_OrdenCmpCotizacion
    Dim odOrdenAprobacion As New d_OrdenAprobacion

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenCompra
        Try
            Dim oeOrden = New e_OrdenCompra(fila("Id"), _
                                         fila("NroOrden"), _
                                         fila("IdMoneda"), _
                                         fila("Moneda"), _
                                         fila("SubTotal"), _
                                         fila("FechaOrden"), _
                                         fila("FechaEntrega"), _
                                         fila("FechaPago"), _
                                         fila("Impuesto"), _
                                         fila("Total"), _
                                         fila("IndicadorAprobacion"), _
                                         fila("IndicadorConsignacion"), _
                                         fila("IdTrabajador"), _
                                         fila("IdTipoOrdenCompra"), _
                                         fila("Glosa"), _
                                         fila("Notas"), _
                                         fila("Activo"), _
                                         fila("IdEstadoOrden"), _
                                         fila("IdCentro"), _
                                         fila("EstadoOrden"), _
                                         fila("IdTipoPago"), _
                                         fila("NombreProveedor"), _
                                         fila("IdProveedor"), _
                                         fila("NombreSubEstado"), _
                                         fila("Percepcion"), _
                                         fila("PercepcionPorc"), _
                                         fila("Detraccion"), _
                                         fila("DetraccionPorc"), _
                                         fila("EstadoDocumento"), _
                                         fila("IdAprobacion"), _
                                         fila("IdTrabajadorAprobacion"), _
                                         fila("IndBloqueo"), _
                                         fila("FechaAprobacion"), _
                                         fila("TrabajadorAprobacion"), _
                                         fila("IndTipoCompra"), _
                                         fila("TipoCompra"), _
                                         fila("IndCotizacion"), _
                                         fila("UsuarioCreacion"))
            Return oeOrden
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener(ByVal oeOrden As e_OrdenCompra) As e_OrdenCompra
        Try
            Dim ds As DataSet
            Dim oeOrd As New e_OrdenCompra
            With oeOrden
                ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompra_Listar" _
                                          , .TipoOperacion _
                                                , .Id _
                                                , .NroOrden _
                                                , .Activo _
                                                , .IdMoneda _
                                                , .IdProveedor _
                                                , .IdEstadoOrden _
                                                , .IdTipoPago _
                                                , "" _
                                                , #1/1/1901# _
                                                , #1/1/1901# _
                                                , .IdTipoOrdenCompra _
                                                , "" _
                                                , ._CantMax _
                                                , ._CantMin)
            End With
           
            If ds.Tables(0).Rows.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                oeOrd = Cargar(ds.Tables(0).Rows(0))
            End If
            Return oeOrd
        Catch ex As Exception
            Throw ex
        End Try
        Return Nothing
    End Function

    Public Function Listar(ByVal oeOrden As e_OrdenCompra, ByVal oeFecha As e_Fechas) As List(Of e_OrdenCompra)
        Try
            Dim lista As New List(Of e_OrdenCompra)
            Dim ds As DataSet

            With oeOrden
                ds = sqlhelper.ExecuteDataset("CMP.Isp_OrdenCompra_Listar" _
                                                , .TipoOperacion _
                                                , .Id _
                                                , .NroOrden _
                                                , .Activo _
                                                , .IdMoneda _
                                                , .IdProveedor _
                                                , .IdEstadoOrden _
                                                , .IdTipoPago _
                                                , oeFecha.OpcionFecha _
                                                , oeFecha.FechaInicio _
                                                , oeFecha.FechaFin _
                                                , .IdTipoOrdenCompra _
                                                , "" _
                                                , ._CantMax _
                                                , ._CantMin)
            End With
            If ds.Tables.Count > 0 Then
                For Each o_Fila As DataRow In ds.Tables(0).Rows
                    oeOrden = Cargar(o_Fila)
                    lista.Add(oeOrden)
                Next
            End If
            Return lista
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal oeOrden As e_OrdenCompra) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odOrdenTrabajo As New d_OrdenTrabajo
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrden
                    stResultado = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompra_IAE" _
                                                        , .TipoOperacion _
                                                        , .PrefijoID _
                                                        , .Id _
                                                        , .NroOrden _
                                                        , .IdMoneda _
                                                        , .IdTrabajador _
                                                        , .IdProveedor _
                                                        , .SubTotal _
                                                        , .Impuesto _
                                                        , .Total _
                                                        , .FechaOrden _
                                                        , .FechaEntrega _
                                                        , .FechaPago _
                                                        , .IndicadorAprobacion _
                                                        , .IdTipoOrdenCompra _
                                                        , .Glosa _
                                                        , .Notas _
                                                        , .Activo _
                                                        , .IdEstadoOrden _
                                                        , .IdCentro _
                                                        , .IdTipoPago _
                                                        , .IndicadorConsignacion _
                                                        , .UsuarioCreacion _
                                                        , .Percepcion _
                                                        , .PercepcionPorc _
                                                        , .Detraccion _
                                                        , .DetraccionPorc _
                                                        , .IndTipoCompra _
                                                        , .IndCotizacion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each Detalle As e_OrdenCompraMaterial In .lstOrdenMaterial
                        Detalle.IdOrden = stResultado(0)
                        If Detalle.TipoOperacion <> "I" Then Detalle.TipoOperacion = .TipoOperacion
                        If Detalle.CantidadMaterialAAtender > 0 Then : Detalle.CantidadMaterialPendiente = Detalle.CantidadMaterialPendiente - Detalle.CantidadMaterialAAtender : End If
                        odDetalleOrdenMaterial.Guardar(Detalle)
                    Next
                    If Not .lstOrdenServicio Is Nothing Then
                        For Each Detalle As e_OrdenCompraServicio In .lstOrdenServicio
                            Detalle.IdOrden = stResultado(0)
                            Detalle.TipoOperacion = .TipoOperacion
                            odDetalleOrdenServicio.Guardar(Detalle)
                        Next
                    End If
                    If .oeOrdCmpCot.IdCotizacion <> "" Then
                        .oeOrdCmpCot.IdOrdenCompra = .Id
                        .oeOrdCmpCot.TipoOperacion = .TipoOperacion
                        odOrdenCmpCot.Guardar(.oeOrdCmpCot)
                    End If
                    If .oeOrdenTrabajo.TipoOperacion = "I" Then
                        .oeOrdenTrabajo.oeOCOT.IdOrdenCompra = .Id
                        odOrdenTrabajo.Guardar(.oeOrdenTrabajo)
                    End If
                    If .TipoOperacion = "1" Or .TipoOperacion = "A" Or .TipoOperacion = "I" Then
                        If .OrdenAprobacion.IdTrabajador <> "" Then
                            If .OrdenAprobacion.TipoOperacion <> "I" Then .OrdenAprobacion.TipoOperacion = IIf(.TipoOperacion = "1", "I", "A")
                            .OrdenAprobacion.IdOrden = stResultado(0)
                            odOrdenAprobacion.Guardar(.OrdenAprobacion)
                        End If               
                    End If
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex 
        End Try
    End Function

    Public Function ModificarPrecios(ByVal oeOrden As e_OrdenCompra) As Boolean
        Try
            Dim d_DatosConfiguracion As New d_DatosConfiguracion
            Dim odOrdenTrabajo As New d_OrdenTrabajo
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrden
                    stResultado = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompra_IAE" _
                                                        , "M", .PrefijoID, .Id, .NroOrden, .IdMoneda, .IdTrabajador, _
                                                        .IdProveedor, .SubTotal, .Impuesto, .Total, Date.Parse("01/01/1901"), _
                                                        Date.Parse("01/01/1901"), Date.Parse("01/01/1901"), _
                                                        1, "", "", "", 1, "", "", "", 1, .UsuarioCreacion).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each Detalle As e_OrdenCompraMaterial In .lstOrdenMaterial
                        Detalle.IdOrden = stResultado(0)
                        If Detalle.TipoOperacion <> "I" Then Detalle.TipoOperacion = .TipoOperacion
                        odDetalleOrdenMaterial.Guardar(Detalle)
                    Next
                End With
                transScope.Complete()
            End Using
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
       
    Public Function Eliminar(ByVal oeOrden As e_OrdenCompra) As Boolean
        Try
            Dim stResultado() As String
            stResultado = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompra_IAE", _
                                      "E", "", oeOrden.Id).ToString.Split()

            Dim Detalle As New e_OrdenCompraMaterial
            Detalle.IdOrden = stResultado(0)
            Detalle.TipoOperacion = oeOrden.TipoOperacion
            odDetalleOrdenMaterial.Eliminar(Detalle)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
