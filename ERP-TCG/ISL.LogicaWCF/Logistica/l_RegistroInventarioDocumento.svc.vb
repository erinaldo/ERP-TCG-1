Imports ISL.AccesoDatos
Imports ISL.EntidadesWCF
Imports System.Runtime.Serialization

<DataContract(), Serializable()> _
Public Class l_RegistroInventarioDocumento
    Implements Il_RegistroInventarioDocumento

    Dim odRegistroInventarioDocumento As New d_RegistroInventarioDocumento
    Dim lstRID As New List(Of e_RegistroInventarioDocumento)
    Dim oeRID As New e_RegistroInventarioDocumento

    'Manejador de OI
    Dim odOrden As New d_Orden
    Dim lb_rectifica As Boolean = 0
    Dim ls_IdRegistroInventario As String = ""
    Dim ls_IdMaterial As String = ""

    'Maneja lista de OI que estan asociadas a la OC
    Dim oeOrdenIngreso As New e_Orden
    Dim idMovimientoInventario As String = "1CH000000002" 'ORDEN DE INGRESO POR COMPRA
    Dim idTipoOrden As String = "1CH000000001" 'Tipo de orden: De Ingreso.
    Dim lstOrdenIngreso As New List(Of e_Orden)

    'Manejador de Detalles de Orden
    Dim odOrdenMaterial As New d_OrdenMaterial
    Dim lstOrdenMaterial As New List(Of e_OrdenMaterial)
    Dim oeOM As New e_OrdenMaterial

    'Manejador de Registro Inventario
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim lstRegistroInventario As New List(Of e_RegistroInventario)
    Dim odRegistroInventario As New d_RegistroInventario

    'Manejador TipoCambio
    Dim ln_TipoCambio As Double = 0

    'Manejador Para Afectar Precios - NC / 
    Dim oePrimerDocumento As New e_MovimientoDocumento
    Dim oeDocAsoc As New e_DocumentoAsociado


    Dim odMovimientoDocumento As New d_MovimientoDocumento
    Dim odDocumentosAsoc As New d_DocumentoAsociado
    Dim odDetalleDocumento As New d_DetalleDocumento
    Dim odDocAsoc As New d_DocumentoAsociado

    Public Function Afectar_RegistroInv_Documento(ByRef oeMovimientoDoc As EntidadesWCF.e_MovimientoDocumento, Optional ByVal lsIdDocumento As String = "") As Boolean Implements Il_RegistroInventarioDocumento.Afectar_RegistroInv_Documento
        Try
            'Asociado a OI
            oeMovimientoDoc.LstOrden.Clear()
            CargarOrdenAsociada(oeMovimientoDoc)
            If lsIdDocumento <> "" Then
                oeMovimientoDoc.Id = lsIdDocumento
            Else
                CargarDetallesDocumento(oeMovimientoDoc)
            End If
            lstRID.Clear()
            If oeMovimientoDoc.Moneda.Equals("SOLES") Then
                ln_TipoCambio = 1
            Else
                ln_TipoCambio = oeMovimientoDoc.TipoCambio
            End If
            'Recorrer y Editar
            For Each oeOrdenM As e_Orden In oeMovimientoDoc.LstOrden
                If oeOrdenM.TipoOrden.Equals("ORDEN DE INGRESO") Then
                    For Each oeOI As e_Orden In oeMovimientoDoc.LstOrden
                        oeOI.lstOrdenMaterial = f_LlenarOrden_Detalles(oeOI)
                        s_RectificaOI(oeOI, oeMovimientoDoc)
                    Next
                Else
                    oeOrdenIngreso.IdEstadoOrden = ""
                    oeOrdenIngreso.NroOrden = ""
                    oeOrdenIngreso.Id = ""
                    oeOrdenIngreso.Referencia = oeOrdenM.Id
                    oeOrdenIngreso.TipoOperacion = "2"
                    oeOrdenIngreso.Activo = 1
                    oeOrdenIngreso.IdMovimientoInventario = idMovimientoInventario
                    oeOrdenIngreso.IdTipoOrden = idTipoOrden
                    lstOrdenIngreso = odOrden.Listar(oeOrdenIngreso)
                    For Each _oeOrdenIngreso As e_Orden In lstOrdenIngreso
                        _oeOrdenIngreso.lstOrdenMaterial = f_LlenarOrden_Detalles(_oeOrdenIngreso)
                        s_RectificaOI(_oeOrdenIngreso, oeMovimientoDoc)
                    Next
                End If
            Next
            If lstRID.Count > 0 Then Return Guardar(lstRID)
            Return True
        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Afectar_RegistroInv_NotaCredito(ByVal oeNotaCredito As EntidadesWCF.e_MovimientoDocumento) As Boolean Implements Il_RegistroInventarioDocumento.Afectar_RegistroInv_NotaCredito
        Try
            'Obtener Primer Documento Factura/Boleta
            oeDocAsoc = New e_DocumentoAsociado
            oePrimerDocumento = New e_MovimientoDocumento
            CargarDocumentoAsociado(oeNotaCredito)
            oeDocAsoc = oeNotaCredito.DocAsoc.Item(0)
            If oeNotaCredito.Compra.IdMotivoDocumento = "1SI000000003" Then 'Si es por Motivo:Descuentos
                oePrimerDocumento.Id = oeDocAsoc.IdMovimientoDocumentoAsoc
                oePrimerDocumento.IndServicioMaterial = "M"
                oePrimerDocumento.IndCompraVenta = 1
                ModificaDetallesDocumento(oePrimerDocumento, oeNotaCredito)
                'Recorrer y Editar
                If Afectar_RegistroInv_Documento(oePrimerDocumento, oeDocAsoc.IdMovimientoDocumento) Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub CargarDetallesDocumento(ByVal oeMovimientoDocumento As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.CargarDetallesDocumento
        Try
            Dim oeDetalleDocumento As New e_DetalleDocumento
            oeDetalleDocumento.TipoOperacion = "COM"
            oeDetalleDocumento.Activo = 1
            oeDetalleDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
            oeDetalleDocumento.IndServicioMaterial = "M"
            oeMovimientoDocumento.lstDetalleDocumento = odDetalleDocumento.Listar(oeDetalleDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarDocumento(ByRef oeMovDocumento As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.CargarDocumento
        Try
            oeMovDocumento.TipoOperacion = "COM"
            oeMovDocumento.IndCompraVenta = 1
            oeMovDocumento.IndServicioMaterial = "M"
            oeMovDocumento = odMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarDocumentoAsociado(ByVal oeMovimientoDocumento As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.CargarDocumentoAsociado
        Try
            Dim oeDoc_Asoc = New e_DocumentoAsociado
            oeDoc_Asoc.TipoOperacion = ""
            oeDoc_Asoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
            oeDoc_Asoc.Activo = 1
            oeDoc_Asoc = odDocAsoc.Obtener(oeDoc_Asoc)
            If oeMovimientoDocumento.DocAsoc.Count = 0 Then
                oeMovimientoDocumento.DocAsoc.Add(oeDoc_Asoc)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarOrdenAsociada(ByVal oeMovimientoDocumento As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.CargarOrdenAsociada
        Try
            Dim oeOrden = New e_Orden
            oeOrden.TipoOperacion = "3"
            oeOrden.Referencia = oeMovimientoDocumento.Id
            oeOrden.IdTipoOrden = oeMovimientoDocumento.IdTipoDocumento
            oeMovimientoDocumento.LstOrden = odOrden.Listar(oeOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function f_LlenarOrden_Detalles(ByVal oe_Orden_Ingreso As EntidadesWCF.e_Orden) As System.Collections.Generic.List(Of EntidadesWCF.e_OrdenMaterial) Implements Il_RegistroInventarioDocumento.f_LlenarOrden_Detalles
        oe_Orden_Ingreso = odOrden.Obtener(oe_Orden_Ingreso)
        lstOrdenMaterial.Clear()
        odOrdenMaterial = New d_OrdenMaterial
        oeOM = New e_OrdenMaterial
        oeOM.TipoOperacion = "L"
        oeOM.Activo = 1
        oeOM.IdOrden = oe_Orden_Ingreso.Id
        lstOrdenMaterial = odOrdenMaterial.Listar(oeOM)
        Return lstOrdenMaterial
    End Function

    Public Function f_Valida(ByVal oeOrdenMaterial As EntidadesWCF.e_OrdenMaterial, ByVal oeDetalle As EntidadesWCF.e_DetalleDocumento, ByVal ln_TC As Double) As Object Implements Il_RegistroInventarioDocumento.f_Valida
        If ln_TC = 1 AndAlso oeOrdenMaterial.PrecioUnitario <> oeDetalle.Precio Then
            Return True
        ElseIf ln_TC <> 1 AndAlso oeDetalle.Precio <> oeOrdenMaterial.PrecioUnitario / ln_TipoCambio Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Guardar(ByVal lstRegistroInventarioDocumento As System.Collections.Generic.List(Of EntidadesWCF.e_RegistroInventarioDocumento)) As Boolean Implements Il_RegistroInventarioDocumento.Guardar
        Try
            Return odRegistroInventarioDocumento.Guardar(lstRegistroInventarioDocumento)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub ModificaDetallesDocumento(ByRef oeMovDocAsoc As EntidadesWCF.e_MovimientoDocumento, ByRef oeMovDoc As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.ModificaDetallesDocumento
        Dim IdMaterial As String = ""
        CargarDocumento(oeMovDocAsoc) : CargarDetallesDocumento(oeMovDocAsoc)
        CargarDocumento(oeMovDoc) : CargarDetallesDocumento(oeMovDoc)
        If oeMovDoc.lstDetalleDocumento.Count > 0 Then
            For Each oeDetalle As e_DetalleDocumento In oeMovDocAsoc.lstDetalleDocumento
                IdMaterial = oeDetalle.IdMaterialServicio
                'Descuenta Precios
                For Each oeDetalle2 As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento.Where(Function(item) item.IdMaterialServicio = IdMaterial)
                    oeDetalle.Precio = oeDetalle.Precio - oeDetalle2.Precio
                    oeDetalle.PrecioUnitarioSinImp = oeDetalle.PrecioUnitarioSinImp - oeDetalle2.PrecioUnitarioSinImp
                Next
            Next
        Else
            'Prorrateo
            Dim ln_Total_NC As Double = oeMovDoc.Total
            Dim ln_SubTotal_NC As Double = oeMovDoc.SubTotal

            Dim ln_Total_Doc As Double = oeMovDocAsoc.Total
            Dim ln_SubTotal_Doc As Double = oeMovDocAsoc.SubTotal

            Dim ln_Precio As Double = 0
            Dim ln_PrecioSinImp As Double = 0

            For Each oeDetalle As e_DetalleDocumento In oeMovDocAsoc.lstDetalleDocumento
                ln_Precio = ((oeDetalle.Precio / ln_Total_Doc) * ln_Total_NC) / oeDetalle.Cantidad
                ln_PrecioSinImp = ((oeDetalle.PrecioUnitarioSinImp / ln_SubTotal_Doc) * ln_SubTotal_NC) / oeDetalle.Cantidad
                oeDetalle.Precio = oeDetalle.Precio - ln_Precio
                oeDetalle.PrecioUnitarioSinImp = oeDetalle.PrecioUnitarioSinImp - ln_PrecioSinImp
            Next

        End If
    End Sub

    Public Sub s_BuscaRegistroInv(ByVal ls_IdOrden As String) Implements Il_RegistroInventarioDocumento.s_BuscaRegistroInv
        lstRegistroInventario.Clear()
        oeRegistroInventario = New e_RegistroInventario
        oeRegistroInventario.IdOrden = ls_IdOrden
        lstRegistroInventario = odRegistroInventario.Listar(oeRegistroInventario)
    End Sub

    Public Sub s_RectificaOI(ByVal oeOrden As EntidadesWCF.e_Orden, ByVal oeMovimientoDoc As EntidadesWCF.e_MovimientoDocumento) Implements Il_RegistroInventarioDocumento.s_RectificaOI
        lb_rectifica = 0
        ls_IdMaterial = ""
        s_BuscaRegistroInv(oeOrden.Id)
        oeOrden.Total = 0
        Dim Total As Double = 0
        For Each oeDetalle As e_DetalleDocumento In oeMovimientoDoc.lstDetalleDocumento
            ls_IdMaterial = oeDetalle.IdMaterialServicio
            For Each oeOrdenMaterial As e_OrdenMaterial In oeOrden.lstOrdenMaterial.Where(Function(item) item.IdMaterial = ls_IdMaterial)
                If f_Valida(oeOrdenMaterial, oeDetalle, ln_TipoCambio) Then
                    oeRID = New e_RegistroInventarioDocumento
                    oeOrdenMaterial.PrecioUnitario = oeDetalle.Precio * ln_TipoCambio
                    oeOrdenMaterial.IdUnidadMedida = oeDetalle.IdUnidadMedida
                    oeOrdenMaterial.CantidadMaterial = oeDetalle.Cantidad
                    oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                    lb_rectifica = 1
                    For Each oeRI As e_RegistroInventario In lstRegistroInventario.Where(Function(item) item.IdMaterial = ls_IdMaterial)
                        ls_IdRegistroInventario = oeRI.Id
                        oeRID.Id = ""
                        oeRID.Codigo = ""
                        oeRID.IdMovimientoDocumento = oeMovimientoDoc.Id
                        oeRID.IdRegistroInventario = ls_IdRegistroInventario
                        oeRID.Activo = 1
                        lstRID.Add(oeRID)
                    Next
                End If
                oeOrden.Total = oeOrden.Total + Math.Round(oeOrdenMaterial.ValorVenta, 4)
            Next
        Next
        If lb_rectifica Then oeOrden.TipoOperacion = "A" : odOrden.Guardar(oeOrden)
    End Sub

    Public Function RegenerarRegistroInv(oeNotaCredito As e_MovimientoDocumento) As Boolean Implements Il_RegistroInventarioDocumento.RegenerarRegistroInv
        Try
            Dim IdMaterial As String = ""
            Dim oeDocAsic As New e_DocumentoAsociado
            Dim olDocAsoc As New l_DocumentoAsociado
            Dim oeMovDoc As New e_MovimientoDocumento
            Dim olMovDoc As New l_MovimientoDocumento
            Dim oeOrden As New e_Orden
            Dim olOrden As New l_Orden
            Dim loOrden As New List(Of e_Orden)
            Dim oeDetDoc As New e_DetalleDocumento
            Dim olDetalleDocumento As New l_DetalleDocumento
            Dim loDetalleDocumento As New List(Of e_DetalleDocumento)
            oeDetDoc.TipoOperacion = "COM"
            oeDetDoc.Activo = 1
            oeDetDoc.IndServicioMaterial = "M"
            'obtenemos detalle de nota de credito
            oeDetDoc.IdMovimientoDocumento = oeNotaCredito.Id
            oeNotaCredito.lstDetalleDocumento = olDetalleDocumento.Listar(oeDetDoc)
            'obtenemos detalle de factura
            oeDetDoc.IdMovimientoDocumento = ""
            oeDocAsic.IdMovimientoDocumento = oeNotaCredito.Id
            oeDocAsic = olDocAsoc.Obtener(oeDocAsic)
            oeMovDoc.Id = oeDocAsic.IdMovimientoDocumentoAsoc
            oeMovDoc = olMovDoc.Obtener(oeMovDoc)
            oeDetDoc.IdMovimientoDocumento = oeMovDoc.Id
            oeMovDoc.lstDetalleDocumento = olDetalleDocumento.Listar(oeDetDoc)
            If oeDocAsic.IndAfectaDocumento Then
                'prorrateo de precios
                For Each detdoc As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento
                    oeDetDoc = New e_DetalleDocumento
                    With oeDetDoc
                        Dim TotalSinImp As Double = detdoc.PrecioUnitarioSinImp * detdoc.Cantidad
                        Dim Total As Double = detdoc.Precio * detdoc.Cantidad
                        .PrecioUnitarioSinImp = Math.Round(TotalSinImp - ((TotalSinImp * oeNotaCredito.SubTotal) / oeMovDoc.SubTotal), 4)
                        .Precio = Math.Round(Total - ((Total * oeNotaCredito.Total) / oeMovDoc.Total), 4)
                        .IdMaterialServicio = detdoc.IdMaterialServicio
                    End With
                    loDetalleDocumento.Add(oeDetDoc)
                Next
            Else
                For Each detdocnota As e_DetalleDocumento In oeNotaCredito.lstDetalleDocumento
                    IdMaterial = detdocnota.IdMaterialServicio
                    'Descuenta Precios
                    For Each detdoc As e_DetalleDocumento In oeMovDoc.lstDetalleDocumento.Where(Function(item) item.IdMaterialServicio = IdMaterial)
                        oeDetDoc = New e_DetalleDocumento
                        With oeDetDoc
                            .PrecioUnitarioSinImp = Math.Round(detdoc.PrecioUnitarioSinImp - detdocnota.PrecioUnitarioSinImp, 4)
                            .Precio = Math.Round(detdoc.Precio - detdocnota.Precio, 4)
                            .IdMaterialServicio = detdoc.IdMaterialServicio
                        End With
                        loDetalleDocumento.Add(oeDetDoc)
                    Next
                Next
            End If
            'obtenemos ordenes ingreso asociadas al documento afectado

            oeOrden.TipoOperacion = "N"
            oeOrden.Referencia = oeMovDoc.Id
            loOrden = olOrden.Listar(oeOrden)
            If loOrden.Count > 0 Then
                For Each ord As e_Orden In loOrden
                    olOrden.RectificarOrden(ord, loDetalleDocumento, oeNotaCredito.IdMoneda, oeNotaCredito.TipoCambio)
                Next
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
