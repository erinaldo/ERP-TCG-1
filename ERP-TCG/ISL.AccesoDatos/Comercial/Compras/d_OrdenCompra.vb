'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports System.Transactions

Public Class d_OrdenCompra

    Private sqlhelper As New SqlHelper
    Dim odDetalleOrdenMaterial As New d_OrdenCompraMaterial
    Dim odDetalleOrdenServicio As New d_OrdenCompraServicio
    Dim odOrdenCmpCot As New d_OrdenCmpCotizacion
    Dim odOrdenAprobacion As New d_OrdenAprobacion

    Private Function Cargar(ByVal fila As DataRow) As e_OrdenCompra
        Try
            Dim oeOrden = New e_OrdenCompra(fila("Id"),
                                         fila("NroOrden"),
                                         fila("IdMoneda"),
                                         fila("Moneda"),
                                         fila("SubTotal"),
                                         fila("FechaOrden"),
                                         fila("FechaEntrega"),
                                         fila("FechaPago"),
                                         fila("Impuesto"),
                                         fila("Total"),
                                         fila("IndicadorAprobacion"),
                                         fila("IndicadorConsignacion"),
                                         fila("IdTrabajador"),
                                         fila("IdTipoOrdenCompra"),
                                         fila("Glosa"),
                                         fila("Notas"),
                                         fila("Activo"),
                                         fila("IdEstadoOrden"),
                                         fila("IdCentro"),
                                         fila("EstadoOrden"),
                                         fila("IdTipoPago"),
                                         fila("NombreProveedor"),
                                         fila("IdProveedor"),
                                         fila("NombreSubEstado"),
                                         fila("Percepcion"),
                                         fila("PercepcionPorc"),
                                         fila("Detraccion"),
                                         fila("DetraccionPorc"),
                                         fila("EstadoDocumento"),
                                         fila("IdAprobacion"),
                                         fila("IdTrabajadorAprobacion"),
                                         fila("IndBloqueo"),
                                         fila("FechaAprobacion"),
                                         fila("TrabajadorAprobacion"),
                                         fila("IndTipoCompra"),
                                         fila("TipoCompra"),
                                         fila("IndCotizacion"),
                                         fila("CodigoDT"),
                                         fila("IndFactServicio"),
                                         fila("IdEmpresaTransporte"),
                                         fila("IdOrigen"),
                                         fila("IdDestino"),
                                         fila("UsuarioCreacion"),
                                         fila("IdPiloto"),
                                         fila("IdTracto"),
                                         fila("IdClienteFinal"),
                                         fila("IdVentanaHoraria"),
                                         fila("IdViaje"))
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
                                                        , .IndCotizacion _
                                                        , .CodigoDT _
                                                        , .IndFactServicio _
                                                        , .IdTransportista _
                                                        , .IdOrigen _
                                                        , .IdDestino _
                                                        , .IdPiloto _
                                                        , .IdTracto _
                                                        , .IdClienteFinal _
                                                        , .IdVentanaHoraria).ToString.Split("_")
                    .Id = stResultado(0)
                    For Each Detalle As e_OrdenCompraMaterial In .lstOrdenMaterial
                        Detalle.IdOrden = stResultado(0)
                        If Detalle.TipoOperacion <> "I" Then Detalle.TipoOperacion = .TipoOperacion
                        If Detalle.CantidadMaterialAAtender > 0 Then : Detalle.CantidadMaterialPendiente = Detalle.CantidadMaterialPendiente - Detalle.CantidadMaterialAAtender : End If
                        Detalle.PrefijoID = oeOrden.PrefijoID '@0001
                        odDetalleOrdenMaterial.Guardar(Detalle)
                    Next
                    If Not .lstOrdenServicio Is Nothing Then
                        For Each Detalle As e_OrdenCompraServicio In .lstOrdenServicio
                            Detalle.IdOrden = stResultado(0)
                            Detalle.TipoOperacion = .TipoOperacion
                            Detalle.PrefijoID = oeOrden.PrefijoID '@0001
                            odDetalleOrdenServicio.Guardar(Detalle)
                        Next
                    End If
                    If .oeOrdCmpCot.IdCotizacion <> "" Then
                        .oeOrdCmpCot.IdOrdenCompra = .Id
                        .oeOrdCmpCot.TipoOperacion = .TipoOperacion
                        .oeOrdCmpCot.PrefijoID = oeOrden.PrefijoID '@0001
                        odOrdenCmpCot.Guardar(.oeOrdCmpCot)
                    End If
                    If .oeOrdenTrabajo.TipoOperacion = "I" Then
                        .oeOrdenTrabajo.oeOCOT.IdOrdenCompra = .Id
                        .oeOrdenTrabajo.PrefijoID = oeOrden.PrefijoID '@0001
                        odOrdenTrabajo.Guardar(.oeOrdenTrabajo)
                    End If
                    If .TipoOperacion = "1" Or .TipoOperacion = "A" Or .TipoOperacion = "I" Then
                        If .OrdenAprobacion.IdTrabajador <> "" Then
                            If .OrdenAprobacion.TipoOperacion <> "I" Then .OrdenAprobacion.TipoOperacion = IIf(.TipoOperacion = "1", "I", "A")
                            .OrdenAprobacion.IdOrden = stResultado(0)
                            .OrdenAprobacion.PrefijoID = oeOrden.PrefijoID '@0001
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
            Dim odOrdenTrabajo As New d_OrdenTrabajo
            Dim stResultado() As String
            Using transScope As New TransactionScope()
                With oeOrden
                    stResultado = sqlhelper.ExecuteScalar("CMP.Isp_OrdenCompra_IAE" _
                                                        , "M", .PrefijoID, .Id, .NroOrden, .IdMoneda, .IdTrabajador,
                                                        .IdProveedor, .SubTotal, .Impuesto, .Total, Date.Parse("01/01/1901"),
                                                        Date.Parse("01/01/1901"), Date.Parse("01/01/1901"),
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
