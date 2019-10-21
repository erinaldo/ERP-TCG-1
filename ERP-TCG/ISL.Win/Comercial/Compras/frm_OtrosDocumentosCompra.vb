'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_OtrosDocumentosCompra

#Region "Inicializacion de Formulario"

    Private Shared instancia As frm_OtrosDocumentosCompra = Nothing
    Private Shared Operacion As String
    Dim _ingresando_datos As Boolean = False

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OtrosDocumentosCompra()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeMovimientoDocumento As New e_MovimientoDocumento, olMovimientoDocumento As New l_MovimientoDocumento
    Dim lstMovimientoDocumento As New List(Of e_MovimientoDocumento)

    Dim oeDetalleDocumento As New e_DetalleDocumento, olDetalleDocumento As New l_DetalleDocumento
    Dim lstDetalleDocumento As New List(Of e_DetalleDocumento)
    Dim leActivo As New List(Of e_DetalleDocumento)

    Dim olArea As New l_Area, oeArea As New e_Area
    Dim olUsuario As New l_Usuario, oeUsuario As New e_Usuario

    Dim oeIGV As New e_Impuesto, olIGV As New l_Impuesto

    Dim totalSinIgv As Double = 0.0
    Dim totalIgv As Double = 0.0
    Dim totalConIgv As Double = 0.0
    Dim cambioMon As Double = 0.0

    Dim oeMoneda As New e_Moneda, olMoneda As New l_Moneda
    Dim llMoneda As New List(Of e_Moneda)

    Dim oeTipoPago As New e_TipoPago, olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Dim oeProveedor As New e_Proveedor, olProveedor As New l_Proveedor
    Dim llProveedores As New List(Of e_Proveedor)

    'Manejador de Estados
    Dim oeEstado As New e_Estado, olEstado As New l_Estado
    Dim llEstado As New List(Of e_Estado)
    Dim lstEstado As New List(Of e_Estado)


    Dim oeTipoDocumento As New e_TipoDocumento, olTipoDocumento As New l_TipoDocumento
    'Manejador de Tipo de Documento
    Dim oeProDoc As New e_ProcesoTipoDocumento, olProDoc As New l_ProcesoTipoDocumento
    Dim listaProDoc As New List(Of e_ProcesoTipoDocumento)

    'Manejador de Proceso
    Dim oeProceso As New e_ProcesoNegocio, olProceso As New l_ProcesoNegocio

    Dim oeMaterial As New e_Material, olMaterial As New l_Material
    Dim llMaterial As New List(Of e_Material)

    Dim oeServicio As New e_Servicio, olServicio As New l_Servicio
    Dim llServicio As New List(Of e_Servicio)

    Dim oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa

    Dim oeCategoriaServicio As New e_CategoriaServicio, olCategoriaServicio As New l_CategoriaServicio
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)

    Dim cantmat As Double = 0
    Dim cont As Integer
    Dim posGrilla As Integer
    Dim swIgv As Boolean

    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida

    'para decimal permitido entre la suma de los detalles con el total
    Private oeConcepto As New e_Concepto
    Private olConcepto As New l_Concepto
    Private loConcepto As New List(Of e_Concepto)
    Private listaTipoDoc As New List(Of e_Concepto)

    'Controla si viene de una orden
    Dim sOrden As Boolean = 1
    'Manejador TipoOrden
    Dim oeTipoOrden As New e_TipoOrden
    Dim olTipoOrden As New l_TipoOrden

    'Para Buscar Ordenes Asociadas
    Dim oeOrden As New e_Orden
    Dim lstOrden As New List(Of e_Orden)

    'Lista Ordenes q no stan asociadas
    Dim listaO As New List(Of e_Orden)
    Dim olOrden As New l_Orden
    Dim _ref_orden As Integer = 0

    'Afectar Inventario
    Dim olRegistroInvDoc As New l_RegistroInventarioDocumento
    Dim IndMaterialServicio As String


    'Documentos sin Asociacion
    Dim oeDocumentoSinAsociacion As New e_DocumentoSinAsociacion
    Dim oeDocumentoSinAsoc As New e_DocumentoSinAsociacion
    Dim olDocumentoSinAsociacion As New l_DocumentoSinAsociacion

    'Manejador TrabajadorSeguridad
    Dim oeTrabajadorSeguridad As New e_TrabajadorSeguridad, olTrabajadorSeguridad As New l_TrabajadorSeguridad
    Dim oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio

    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As List(Of e_Periodo)

    Dim oeOrdDoc As New e_Orden_Documento, olOrdDoc As New l_Orden_Documento
    Dim oeCtactble As New e_CuentaContable, olCtactble As New l_CuentaContable

    Private oeAsientoModelo, oeAsientoModeloFacturaGuia As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable
    Private oeCtaCtbleSFam As New e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As New l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam, loCtaCtbleSFamFct As New List(Of e_CtaCtbleSubFamiliaMat)
    Private oeCtaCtbleCSer As New e_CtaCtbleCatServicio
    Private olCtaCtbleCSer As New l_CtaCtbleCatServicio
    Private loCtaCtbleCSer As New List(Of e_CtaCtbleCatServicio)
    Private oeCtaContable As e_CuentaContable, leCtaContable As List(Of e_CuentaContable)
    Private lb_EmisionPerAnt As Boolean = False
    Private lo_SubFamCtaCtble_25 As New List(Of e_CtaCtbleSubFamiliaMat)
    Private lo_SubFamCtaCtble_28 As New List(Of e_CtaCtbleSubFamiliaMat)
    Private total_debe As Decimal = 0.0
    Private total_haber As Decimal = 0.0
    Private lb_debe As Boolean = False
    Private lb_soles As Boolean = False

    Private lenSerie As Integer = 0, lenNumero As Integer = 0

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            oeMovimientoDocumento.TipoOperacion = "I"
            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            IndMaterialServicio = cboMaterialServicio.Value
            MostrarTabs(1, ficFacturaCompra, 1)
            Operacion = "Nuevo"
            MostrarTabs(1, ficDetalleOCMateriales, 1)
            Me.txtEstado.Text = "POR GENERAR"
            cboEstadoFacturaM.SelectedIndex = 0 'Ubica estado para Generar
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Operacion = "Inicializa"
            If oeMovimientoDocumento.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarDocumentoCompra() Then
                            MostrarTabs(0, ficFacturaCompra, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFacturaCompra, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFacturaCompra, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficFacturaCompra, 2)
                _ingresando_datos = False
                Consultar(True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarDocumentoCompra() Then
                MostrarTabs(0, ficFacturaCompra, 2)
                Consultar(True)
                ListarDocSinAsoc()
            Else
                MostrarTabs(1, ficFacturaCompra, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaFacturaCompra.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
            Else
                ControlBoton(1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If CargarDocumentoCompra() Then
                oeMovimientoDocumento.TipoOperacion = "A"
                If txtEstado.Text = "GENERADA" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
                End If
                MostrarTabs(1, ficFacturaCompra, 1)
                gbeListadoMatSer.Expanded = False
                Operacion = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaFacturaCompra
                If .ActiveRow.Cells("EstadoDocumento").Value <> "GENERADA" Then Throw New Exception("Solo se Elimina Facturas Generadas")
                If ValidarGrilla(griListaFacturaCompra, "Facturas") Then
                    Dim oeOrdDoc As New e_Orden_Documento
                    Dim olOrdDoc As New l_Orden_Documento
                    oeOrdDoc.IdDocumento = .ActiveRow.Cells("Id").Value
                    oeOrdDoc.TipoOperacion = "S"
                    oeOrdDoc.IdTipoDocumento = .ActiveRow.Cells("IdTipoDocumento").Value
                    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                    If oeOrdDoc.IdOrden <> "" Then Throw New Exception("Documento Asociado a una Orden Ejecutada. No se puede Eliminar")
                    oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento.TipoOperacion = "COM"
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                    If oeMovimientoDocumento.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Factura : " & .ActiveRow.Cells("NombreDocumento").Value.ToString & " ?", _
                                           "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMovimientoDocumento.TipoOperacion = "E"
                            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olMovimientoDocumento.Eliminar(oeMovimientoDocumento)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficFacturaCompra.Tabs(0).Selected AndAlso griListaFacturaCompra.Rows.Count = 0 Then Throw New Exception("No hay ninguna factura de compra para exportar al Excel")
            If ficFacturaCompra.Tabs(0).Selected Then Exportar_Excel(griListaFacturaCompra)

            If ficFacturaCompra.Tabs(1).Selected Then
                If ficDetalleOCMateriales.Tabs(0).Selected() AndAlso griListaDetalleFactura.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle de la factura de compra para exportar al Excel")
                If ficDetalleOCMateriales.Tabs(0).Selected() Then Exportar_Excel(griListaDetalleFactura)

                If ficDetalleOCMateriales.Tabs(1).Selected() AndAlso griListaOrdenIngreso.Rows.Count = 0 Then Throw New Exception("No hay ningún detalle de la factura de compra para exportar al Excel")
                If ficDetalleOCMateriales.Tabs(1).Selected() Then Exportar_Excel(griListaOrdenIngreso)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Sub IniciarFormulario()
        Try
            'Para las cabezeras
            ColoresGenerado.Color = Blanco
            ColoresEmitido.Color = VerdeClaro
            ColoresAnulado.Color = Ciruela
            rfFechaDocDesde.Value = Date.Now.AddDays(-14)
            rfFechaDocHasta.Value = Date.Now
            fecFechaActual.Value = Date.Now
            'Obtener la información del área del usuario        
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeArea = olUsuario.Area(oeUsuario)
            cambioMon = TipoCambio(fecFechaActual.Value)(0)
            decTc.Value = cambioMon
            oeIGV = olIGV.IGV(fecFechaActual.Value)
            decPorcenIGV.Value = oeIGV.Porcentaje
            oeEmpresa = New e_Empresa
            oeEmpresa.Id = ISL_IdEmpresa
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            txtEmpresa.Value = oeEmpresa.Nombre
            LlenaCombos()
            'Fechas para listar Ordenes 
            rFechasDesde.Value = Date.Now.AddDays(-7)
            rFechasHasta.Value = Date.Now
            btnAnular.Enabled = 0 : cmdEnviaTesoreria.Enabled = 0

            AsientosContablesCompraDocN()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCombos()
        Try
            'Cargar decimal permitido entre detalle y total
            loConcepto = New List(Of e_Concepto)
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "37"
            loConcepto = olConcepto.Listar(oeConcepto)

            'Cargar Lista de los tipo de documentos que deben mostrarse
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "40"
            listaTipoDoc = olConcepto.Listar(oeConcepto)

            cboMaterialServicio.SelectedIndex = 0
            oeTipoPago.Activo = True
            LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)
            oeProveedor.Id = "0"
            oeProveedor.Nombre = "NINGUNO"
            llProveedores.Add(oeProveedor)
            oeProveedor = New e_Proveedor
            oeProveedor.Activo = True
            llProveedores.AddRange(olProveedor.Listar(oeProveedor))
            LlenarComboMaestro(cboProveedor, llProveedores, 0)
            LlenarComboMaestro(cboProveedor2, llProveedores, 0)
            cboProveedor.DropDownStyle = DropDownStyle.DropDown
            cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            cboProveedor2.DropDownStyle = DropDownStyle.DropDown
            cboProveedor2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            llMoneda.AddRange(olMoneda.Listar(oeMoneda))
            LlenarComboMaestro(cboMoneda, llMoneda, 0)
            oeEstado.Activo = True
            oeEstado.Nombre = "COMPRAS"
            lstEstado = olEstado.Listar(oeEstado)
            LlenarComboMaestro(cboEstadoFacturaM, lstEstado, 0)
            oeEstado.Id = "CERO"
            oeEstado.Nombre = "TODOS"
            llEstado.Add(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Activo = True
            llEstado.AddRange(lstEstado)
            LlenarComboMaestro(cboEstadoFactura, llEstado, 0)
            '
            oeProDoc = New e_ProcesoTipoDocumento
            oeProDoc.TipoOperacion = 1
            oeProDoc.IdTipoDocumento = oeTipoDocumento.Id
            oeProDoc.IdProceso = r_ObtenerProceso("OC SERVICIO")
            listaProDoc = olProDoc.Listar(oeProDoc)

            Dim listaIdsTipoDoc As List(Of String)
            listaIdsTipoDoc = listaTipoDoc.Select(Function(x) x.Valor1).ToList
            listaProDoc = listaProDoc.Where(Function(x) listaIdsTipoDoc.Contains(x.Id)).ToList
            LlenarCombo(cboTipoDocBus, "TipoDocumento", listaProDoc, 0)
            'Proceso Tipo Documento            
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.Id = cboTipoDocBus.Value
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
            'oeProDoc = New e_ProcesoTipoDocumento
            'oeProDoc.TipoOperacion = 1
            'oeProDoc.IdTipoDocumento = oeTipoDocumento.Id
            'oeProDoc.IdProceso = ObtenerProceso("COMPRAS")
            'LlenarCombo(cboTipoDocumento, "TipoDocumento", olProDoc.Listar(oeProDoc), 0)
            'cboTipoDocumento.Enabled = False
            'Llena Combo Tipo de Orden
            oeTipoOrden = New e_TipoOrden
            oeTipoOrden.TipOoperacion = "D"
            oeTipoOrden.Activo = 1
            cbTipoOrden.ValueMember = "Id"
            cbTipoOrden.DisplayMember = "Nombre"
            cbTipoOrden.DataSource = olTipoOrden.Listar(oeTipoOrden)
            cbTipoOrden.SelectedIndex = 1
            mt_CargarCtaContable(ObtenerFechaServidor().Year)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(rfFechaDocDesde, rfFechaDocHasta)
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .IdTipoDocumento = oeTipoDocumento.Id
                If rbDatosAdicionales.Checked Then
                    .Activo = Activo
                    .FechaInicio = rfFechaDocDesde.Value
                    .FechaFinal = rfFechaDocHasta.Value
                    .IndServicioMaterial = cboMaterialServicio.Value
                    .IdEstadoDocumento = cboEstadoFactura.Value
                    .IdClienteProveedor = cboProveedor2.Value
                    'If Not String.IsNullOrEmpty(txtSerieD.Value) Then .Serie = FormatoDocumento(txtSerieD.Value.ToString.Trim, 4)
                
                End If
                .TipoOperacion = "COM"
            End With
            With griListaFacturaCompra
                .DataSource = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            End With
            'Colorea la grilla de acuerdo a los estados
            For Each fila As UltraGridRow In griListaFacturaCompra.Rows
                Select Case fila.Cells("EstadoDocumento").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "ENVIADO"
                        fila.CellAppearance.BackColor = Me.ColoresEmitido.Color
                    Case "ANULADO"
                        fila.CellAppearance.BackColor = Me.ColoresAnulado.Color
                End Select
            Next
            With griListaFacturaCompra
                agrFactura.Text = "Listado : " & .Rows.Count & " Facturas."
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try

    End Sub

    Private Sub Inicializar()
        Try
            oeMovimientoDocumento = New e_MovimientoDocumento
            gbeListadoMatSer.Visible = 0 : UEGB_Ordenes.Visible = 1
            fecFechaActual.Value = Date.Now : cambioMon = TipoCambio(ObtenerFechaServidor, 1)(0) : decTc.Value = cambioMon
            txtSerieM.Value = String.Empty : txtNumeroM.Value = String.Empty : txtBuscarMateriales.Value = String.Empty
            cboMoneda.SelectedIndex = 0 : cboTipoPago.SelectedIndex = 0 : cboProveedor.Text = String.Empty : cboProveedor.DataSource = Nothing
            cboCategoriaServicios.SelectedIndex = 0
            Me.gbeListadoMatSer.Enabled = 1 : Me.MenuDetalle.Enabled = 1
            UEGB_Ordenes.Expanded = 0 : UEGB_Ordenes.Enabled = 1 : cbTipoOrden.Enabled = 1
            MostrarTabs(0, ficDetalleOCMateriales, 1) : gbeListadoMatSer.Expanded = 0
            cbTipoOrden.Enabled = 1
            If IndicadorMaterialServicio(cboMaterialServicio.Value) Then
                utcListadoMatSer.Tabs(0).Visible = True
                utcListadoMatSer.Tabs(1).Visible = False
                gbeListadoMatSer.Text = "Materiales"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Hidden = 0
            Else
                utcListadoMatSer.Tabs(0).Visible = False
                utcListadoMatSer.Tabs(1).Visible = True
                gbeListadoMatSer.Text = "Servicios"
                cbTipoOrden.Enabled = 0
                cbTipoOrden.Text = "ORDEN DE COMPRA"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("IdUnidadMedida").Hidden = 1
            End If
            If Not IndicadorMaterialServicio(cboMaterialServicio.Value) Then LlenaComboCategoriaServicios()
            MostrarTabs(0, ficDetalleOCMateriales, 1)
            _ref_orden = 0
            Me.txtSubTotal.Value = 0
            Me.txtIGV.Value = 0
            Me.txtTotal.Value = 0
            Me.cheActivoPercepcion.Checked = False
            Me.DecDetraer.Value = 0
            chk_CajaChica.Checked = 0
            cboMes.SelectedIndex = -1
            lbl_etiqueta.Visible = 0
            etiConsigna.Visible = False
            llMaterial.Clear() : llServicio.Clear() : lstDetalleDocumento.Clear() : lstOrden.Clear() : listaO.Clear()
            griListaOrdenIngreso.DataSource = lstOrden : griListaServicios.DataSource = llServicio
            griListaDetalleFactura.DataSource = lstDetalleDocumento : griOrdenes.DataSource = listaO
            griListaMateriales.DataSource = llMaterial
            griListaMateriales.DisplayLayout.Bands(0).SortedColumns.Clear()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaComboCategoriaServicios()
        Try
            cboCategoriaServicios.DropDownStyle = DropDownStyle.DropDown
            cboCategoriaServicios.AutoCompleteMode = AutoCompleteMode.SuggestAppend

            oeCategoriaServicio.Id = "CERO" : oeCategoriaServicio.Nombre = "TODOS"
            lstCategoriasServicio.Add(oeCategoriaServicio)
            oeCategoriaServicio = New e_CategoriaServicio
            oeCategoriaServicio.Activo = True
            lstCategoriasServicio.AddRange(olCategoriaServicio.Listar(oeCategoriaServicio))
            LlenarComboMaestro(cboCategoriaServicios, lstCategoriasServicio, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CargarDocumentoCompra() As Boolean
        Dim id As String
        Try
            With griListaFacturaCompra
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeMovimientoDocumento.Id = id
                    oeMovimientoDocumento.TipoOperacion = "COM"
                    oeMovimientoDocumento = olMovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
                    If oeMovimientoDocumento.Activo Then
                        fecFechaActual.Value = oeMovimientoDocumento.FechaEmision
                        ListarProveedores(cboProveedor, oeMovimientoDocumento.IdClienteProveedor, 0)
                        cboProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
                        cboEstadoFacturaM.Value = oeMovimientoDocumento.IdEstadoDocumento.Trim
                        txtEstado.Text = cboEstadoFacturaM.Text
                        txtNumeroM.Value = oeMovimientoDocumento.Numero
                        txtSerieM.Value = oeMovimientoDocumento.Serie
                        cboTipoPago.Value = oeMovimientoDocumento.IdTipoPago
                        cboMoneda.Value = oeMovimientoDocumento.IdMoneda
                        IndMaterialServicio = oeMovimientoDocumento.IndServicioMaterial
                        CargarDetalleDocumento(oeMovimientoDocumento.IndServicioMaterial)
                        CargarAsociacion(id)
                        txtSubTotal.Value = oeMovimientoDocumento.SubTotal
                        txtIGV.Value = oeMovimientoDocumento.IGV
                        txtTotal.Value = txtSubTotal.Value + txtIGV.Value
                        decTc.Value = oeMovimientoDocumento.TipoCambio
                        totalSinIgv = oeMovimientoDocumento.SubTotal
                        totalIgv = oeMovimientoDocumento.IGV
                        totalConIgv = oeMovimientoDocumento.Total
                        If oeMovimientoDocumento.Percepcion > 0 Then
                            Me.cheActivoPercepcion.Checked = 1
                            DecPorcentajePercepcion.Value = oeMovimientoDocumento.PercepcionPorc
                        End If
                        DecDetraer.Value = oeMovimientoDocumento.DetraccionPorc
                        chk_CajaChica.Checked = oeMovimientoDocumento.CobraCajaChica
                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub CargarDetalleDocumento(ByVal IndMaterialServicio As String)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeDetalleDocumento = New e_DetalleDocumento
            oeDetalleDocumento.TipoOperacion = "COM"
            oeDetalleDocumento.Activo = 1
            oeDetalleDocumento.IdMovimientoDocumento = oeMovimientoDocumento.Id
            If IndMaterialServicio.Equals("M") Then
                oeDetalleDocumento.IndServicioMaterial = "M"
                lstDetalleDocumento = olDetalleDocumento.Listar(oeDetalleDocumento)
            Else
                oeDetalleDocumento.IndServicioMaterial = "S"
                lstDetalleDocumento = olDetalleDocumento.Listar(oeDetalleDocumento)
            End If
            LLenarDetalleDocumento(lstDetalleDocumento)
            LlenaCombosGrillaMaterial()
            If griListaDetalleFactura.Rows.Count > 0 Then griListaDetalleFactura.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LLenarDetalleDocumento(ByVal leDetalleDoc As List(Of e_DetalleDocumento))
        With griListaDetalleFactura
            leActivo = New List(Of e_DetalleDocumento)
            For Each obj As e_DetalleDocumento In leDetalleDoc.Where(Function(item) item.TipoOperacion Is Nothing).ToList
                obj.TipoOperacion = "A"
            Next
            For Each obj As e_DetalleDocumento In leDetalleDoc.Where(Function(item) item.TipoOperacion = "E").ToList
                If obj.Id = "" Then leDetalleDoc.Remove(obj)
            Next
            leActivo = leDetalleDoc.Where(Function(item) item.TipoOperacion <> "E").ToList
            .DataSource = leActivo
            LlenaCombosGrillaMaterial()
            CalcularTotales()
        End With
    End Sub

    Private Function GuardarDocumentoCompra() As Boolean
        Try
            Dim fechaactual As Date = ObtenerFechaServidor()
            'If Me.chk_CajaChica.Checked And Me.cboMes.SelectedIndex = -1 Then Throw New Exception("Seleccione periodo,por favor.")
            If Me.fecFechaActual.Value.Date > ObtenerFechaServidor() Then Throw New Exception("No puede guardar un documento mayor a la fecha actual.")
            If CInt(Me.txtNumeroM.Text) = 0 Then Throw New Exception("Numero de Documento Incorrecto. Verificar")
            CargarObjects()
            If oeMovimientoDocumento.TipoOperacion = "I" Then Validar_ExistenciaComprobante()
            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olMovimientoDocumento.Guardar(oeMovimientoDocumento) Then
                'If Me.chk_CajaChica.Checked Then
                '    oePeriodo = New e_Periodo
                '    oePeriodo.Ejercicio = fechaactual.Year
                '    oePeriodo = olPeriodo.ObtenerPeriodoVigente(oePeriodo, 3)
                '    oeMovimientoDocumento.FechaCreacion = fechaactual
                '    If oeMovimientoDocumento.FechaEmision.Year <> Año1.Año Then Throw New Exception("Los años no son iguales, no se puede enviar la Compra")
                '    If oeMovimientoDocumento.FechaEmision.Month > CInt(cboMes.Text) Then Throw New Exception("El mes de emision es Mayor al Periodo,No se puede Enviar la Compra")
                '    If oePeriodo.Mes <> CInt(cboMes.Text) Then
                '        If oeMovimientoDocumento.FechaEmision.Month = oePeriodo.Mes Then
                '            Throw New Exception("Periodo " & oePeriodo.Codigo & " Abierto para Tesoreria.")
                '        End If
                '    End If
                '    oeMovimientoDocumento.IdPeriodo = cboMes.Value
                '    oeMovimientoDocumento.Ejercicio = Año1.Año
                '    oeMovimientoDocumento.Compra.TipoDoc = oeTipoDocumento
                '    GuardarCmpAsiento(oeMovimientoDocumento.IdPeriodo, oeMovimientoDocumento.Ejercicio, False)
                'End If
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub Validar_ExistenciaComprobante()
        Try
            Dim oeMovDocAUx As New e_MovimientoDocumento
            Dim lst_MovDocAUx As New List(Of e_MovimientoDocumento)
            oeMovDocAUx.IdTipoDocumento = oeTipoDocumento.Id
            oeMovDocAUx.Serie = oeMovimientoDocumento.Serie
            oeMovDocAUx.Numero = CStr(CInt(oeMovimientoDocumento.Numero))
            oeMovDocAUx.IdClienteProveedor = oeMovimientoDocumento.IdClienteProveedor
            oeMovDocAUx.TipoOperacion = "VDC"
            oeMovDocAUx.IndCompraVenta = 1
            lst_MovDocAUx = olMovimientoDocumento.Listar(oeMovDocAUx)
            If lst_MovDocAUx.Count > 0 Then Throw New Exception("El comprobante " & txtSerieM.Value & "-" & txtNumeroM.Value & " de " & cboProveedor.Text & " ya ha sido registrado.")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarObjects()
        Try
            'If CInt(Me.txtSerieM.Text) = 0 Then Throw New Exception("Serie no Puede ser '0000'")
            'If CInt(Me.txtNumeroM.Text) = 0 Then Throw New Exception("Numero no Puede ser '0000000000'")
            gfc_ValidarSerieDoc(txtSerieM.Text, "01")
            gfc_ValidarNumeroDoc(txtNumeroM.Text, "01")
            If cboMoneda.Value <> "1CH01" And (decTc.Value = 0) Then
                Throw New Exception("Ingresar Tipo de Cambio")
            End If
            With oeMovimientoDocumento
                .Tipo = "FACTURACOMPRA"
                .IdTipoDocumento = oeTipoDocumento.Id


                If Not String.IsNullOrEmpty(txtSerieM.Value) Then .Serie = FormatoDocumento(txtSerieM.Value.ToString.Trim, 4)
                If Not String.IsNullOrEmpty(txtNumeroM.Value) Then .Numero = FormatoDocumento(txtNumeroM.Value.ToString.Trim, 10)
                .TipoCambio = decTc.Value
                .Activo = True
                .IdUsuarioCrea = gUsuarioSGI.Id
                .IdClienteProveedor = cboProveedor.Value
                .IdTipoPago = cboTipoPago.Value
                .FechaEmision = fecFechaActual.Value

                Dim oe As New e_TipoPago
                oe = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
                .FechaVencimiento = .FechaEmision.AddDays(oe.Dias)
                .IdEstadoDocumento = cboEstadoFacturaM.Value
                .IndCompraVenta = 1 '1:Factura por compras
                .IdMoneda = cboMoneda.Value
                .Moneda = cboMoneda.Text
                .SubTotal = txtSubTotal.Value
                .Total = IIf(DecTPagar.Value > 0, DecTPagar.Value, txtTotal.Value)
                .Saldo = .Total
                .IGV = txtIGV.Value
                ._Operador = 1
                .Mac_PC_Local = MacPCLocal()
                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
                .lstDetalleDocumento = lstDetalleDocumento
                .LstOrden = lstOrden
                .Compra.PercepcionPorc = DecPorcentajePercepcion.Value
                .Compra.Percepcion = DecPercepcion.Value
                .Compra.Detraccion = DecMontoDetraccion.Value
                .Compra.DetraccionPorc = DecDetraer.Value
                .Compra.Igv1 = IIf(cboMoneda.Value = "1CH01", txtIGV.Value, txtIGV.Value * decTc.Value)
                .Compra.Base1 = IIf(cboMoneda.Value = "1CH01", IIf(txtIGV.Value = 0, 0, txtSubTotal.Value), IIf(txtIGV.Value = 0, 0, txtSubTotal.Value) * decTc.Value) 'Monto total de la factura sin IGV.
                .Compra.TipoOperacion = .TipoOperacion
                .Compra.IdTipoPago = cboTipoPago.Value
                .Compra.OtrosTributos = IIf(cboMoneda.Value = "1CH01", DecPercepcion.Value + DecMontoDetraccion.Value, (DecPercepcion.Value + DecMontoDetraccion.Value) * decTc.Value)
                .Compra.NoGravadas = IIf(cboMoneda.Value = "1CH01", IIf(txtIGV.Value <> 0, 0, txtSubTotal.Value), IIf(txtIGV.Value <> 0, 0, txtSubTotal.Value) * decTc.Value)
                .Compra.CobraCajaChica = IIf(chk_CajaChica.Checked, 1, 0)
                .IndServicioMaterial = IndMaterialServicio
                '-- Algunas Restricciones
                If .lstDetalleDocumento.Where(Function(item) item.TipoOperacion <> "E").Count = 0 Then Throw New Exception("Ingrese Detalles !!")
                If .lstDetalleDocumento.Where(Function(item) (item.TipoOperacion <> "E" And item.Subtotal = 0)).Count > 0 Then Throw New Exception("Verificar Cantidad y Precios en Detalles !!")
                '----
                .DocSinAsoc = oeDocumentoSinAsoc
            End With
            If oeMovimientoDocumento.IdMoneda = "1CH02" Then If oeMovimientoDocumento.Compra.CobraCajaChica = 1 Then Throw New Exception("Caja Chica Solo Paga en Soles")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarMateriales(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Activo = Activo
                llMaterial = olMaterial.Listar_(oeMaterial)
                '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
                'If llRequerimientoMaterial.Count > 0 Then
                '    llMaterial.RemoveAll(AddressOf VerificaListaMateriales)
                '    griListaMateriales.DataBind()
                'End If
                '--------------------------------------------------------------------------------------------------------------            
                With griListaMateriales
                    .DataSource = llMaterial
                    .Rows.ExpandAll(True)
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                    'agrMateriales.Text = "Materiales : " & .Rows.Count
                End With

                'llenaCombosGrillaMaterial()
                'spcRequerimientos.Panel2Collapsed = False
                'utcListados.SelectedTab.Key = ""
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub ListarServicios(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            oeServicio.TipoOperacion = "S"
            oeServicio.Activo = Activo
            oeServicio.IdCategoriaServicio = IIf(cboCategoriaServicios.Value = "CERO", "", cboCategoriaServicios.Value)
            llServicio = olServicio.Listar(oeServicio)
            '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
            'If llRequerimientoMaterial.Count > 0 Then
            '    llMaterial.RemoveAll(AddressOf VerificaListaMateriales)
            '    griListaMateriales.DataBind()
            'End If
            '--------------------------------------------------------------------------------------------------------------            
            With griListaServicios
                .DataSource = llServicio
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                'agrMateriales.Text = "Materiales : " & .Rows.Count
            End With
            'llenaCombosGrillaMaterial()
            'spcRequerimientos.Panel2Collapsed = False
            'utcListados.SelectedTab.Key = ""

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub AgregarDetalle()
        Try
            If IndicadorMaterialServicio(cboMaterialServicio.Value) Then
                For Each oeMat As e_Material In llMaterial.Where(Function(detalle) detalle.Seleccion)
                    oeMat.Seleccion = 0
                    If BuscaMaterialServicio(oeMat.Id) Then griListaDetalleFactura.DataBind() : Throw New Exception("Material ya esta Agregado")
                    oeDetalleDocumento = New e_DetalleDocumento()
                    With oeDetalleDocumento
                        .Id = ""
                        .TipoOperacion = "I"
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Seleccion = 0
                        .IndGravado = 1
                        .Activo = 1
                        .IdMaterialServicio = oeMat.Id
                        .CodigoMaterialServicio = oeMat.Codigo
                        .IndServicioMaterial = "M"
                        .NombreMaterialServicio = oeMat.Nombre
                        .IdUnidadMedida = oeMat.IdUnidadMedida
                        .IdTipoUnidadMedida = oeMat.IdTipoUnidadMedida
                        .Cantidad = 1
                        .PrecioUnitarioSinImp = oeMat.Precio
                        .Precio = Math.Round(oeMat.Precio * (1 + oeIGV.Porcentaje), 4)
                        .Pos = lstDetalleDocumento.Count
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    lstDetalleDocumento.Add(oeDetalleDocumento)
                Next
            Else
                For Each oeServicio As e_Servicio In llServicio.Where(Function(detalle) detalle.Seleccion)
                    oeServicio.Seleccion = 0
                    If BuscaMaterialServicio(oeServicio.Id) Then griListaDetalleFactura.DataBind() : Throw New Exception("Servicio se encuentra Agregado")
                    oeDetalleDocumento = New e_DetalleDocumento()
                    With oeDetalleDocumento
                        .Id = ""
                        .TipoOperacion = "I"
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Seleccion = False
                        .IndGravado = True
                        .Activo = True
                        .IdMaterialServicio = oeServicio.Id
                        .CodigoMaterialServicio = oeServicio.Codigo
                        .IndServicioMaterial = "S"
                        .NombreMaterialServicio = oeServicio.Nombre
                        .IdUnidadMedida = oeServicio.IdUnidadMedida
                        .IdTipoUnidadMedida = oeServicio.IdTipoUnidadMedida
                        .Cantidad = 1
                        .PrecioUnitarioSinImp = oeServicio.Precio
                        .Precio = Math.Round(oeServicio.Precio * (1 + oeIGV.Porcentaje), 4)
                        .Pos = lstDetalleDocumento.Count
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    lstDetalleDocumento.Add(oeDetalleDocumento)
                Next
            End If
            LLenarDetalleDocumento(lstDetalleDocumento)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub QuitarDetalle()
        Try
            Select Case ficDetalleOCMateriales.SelectedTab.Index
                Case 0
                    Dim sw As Boolean = False
                    For Each oeDD As e_DetalleDocumento In lstDetalleDocumento.Where(Function(item) item.Seleccion)
                        sw = True
                        Dim Referencia As String = oeDD.Pos.ToString
                        For Each oeO As e_Orden In lstOrden.Where(Function(item2) item2.Referencia = Referencia)
                            Throw New Exception("Los Materiales se encuentran Asociados a una Orden")
                        Next
                    Next
                    If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")
                    If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        For Each oeDD As e_DetalleDocumento In lstDetalleDocumento.Where(Function(item) item.Seleccion)
                            oeDD.TipoOperacion = "E"
                            oeDD.PrefijoID = gs_PrefijoIdSucursal '@0001
                        Next
                        LLenarDetalleDocumento(lstDetalleDocumento)
                    End If
                Case 1
                    If griListaOrdenIngreso.Selected.Rows.Count > 0 Then
                        If MessageBox.Show("¿Esta seguro eliminar la Orden Asociada? ", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Dim IdOrden As String = griListaOrdenIngreso.ActiveRow.Cells("Id").Value.ToString
                            Dim _ref As String = griListaOrdenIngreso.ActiveRow.Cells("Referencia").Value.ToString
                            lstOrden.RemoveAll(Function(item) item.Id = IdOrden)
                            lstDetalleDocumento.RemoveAll(Function(item) item.Pos.ToString = _ref)
                            LLenarDetalleDocumento(lstDetalleDocumento)
                            MostrarListaOrdenes("")
                        End If
                    Else
                        mensajeEmergente.Confirmacion("Seleccione Orden.", True)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenaCombosGrillaMaterial()
        Try
            Dim Cuenta As String = ""
            For i As Integer = 0 To griListaDetalleFactura.Rows.Count - 1
                Cuenta = ""
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = griListaDetalleFactura.Rows(i).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", i, griListaDetalleFactura, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
                Cuenta = griListaDetalleFactura.Rows(i).Cells("IdCuentaContableCompra").Value.ToString
                If Cuenta.Trim <> "" Then
                    CtaCtbleValueList(Cuenta)
                    griListaDetalleFactura.Rows(i).Cells("IdCuentaContableCompra").ValueList = griListaDetalleFactura.DisplayLayout.ValueLists("CtaCtbles")
                End If
            Next
            griListaDetalleFactura.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CtaCtbleValueList(ByVal ls_IdCtaCtble As String)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.griListaDetalleFactura.DisplayLayout.ValueLists.Clear()
            objValueList = Me.griListaDetalleFactura.DisplayLayout.ValueLists.Add("CtaCtbles")

            oeCtactble = New e_CuentaContable
            oeCtactble.TipoOperacion = "N"
            oeCtactble.Activo = True
            oeCtactble.Id = ls_IdCtaCtble
            Dim dt As DataTable = olCtactble.ComboGrilla(oeCtactble)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function BuscaMaterialServicio(ByVal lsId As String) As Boolean
        With griListaDetalleFactura
            For Each fila As UltraGridRow In griListaDetalleFactura.Rows
                If fila.Cells("IdMaterialServicio").Value = lsId Then
                    Return True
                End If
            Next
            Return False
        End With
    End Function

    Private Sub AnularDocumentoCompra()
        Try
            Editar()
            lbl_etiqueta.Text = "Anulando Factura"
            lbl_etiqueta.Visible = 1
            oeMovimientoDocumento.TipoOperacion = "1"

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub TrasponerOrdenDocumento(ByVal oeOrden As e_Orden, oeOrdenCompra As e_OrdenCompra)
        Try
            Me.Cursor = Cursors.WaitCursor
            IniciarFormulario()
            Me.Nuevo()
            Me.gbeListadoMatSer.Enabled = 0
            Me.gbeListadoMatSer.Expanded = 0
            Me.MenuDetalle.Enabled = 0
            CargarOrdenAsociada(oeOrden, 0, oeOrdenCompra.Id)
            cboMoneda.Value = oeOrden.IdMoneda

            MostrarListaOrdenes("")
            sOrden = 0
            MostrarTabs(0, ficDetalleOCMateriales, 1)
            CalcularTotales()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CalcularTotales()
        Dim Total As Double = 0
        Dim flag As Boolean = False
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        For Each oeDetalleOC As e_DetalleDocumento In leActivo
            Total += oeDetalleOC.Cantidad * oeDetalleOC.Precio
            If oeDetalleOC.IndGravado Then flag = True
        Next
        txtTotal.Value = Math.Round(Total, 4)
        If flag Then
            txtSubTotal.Value = Math.Round(Total / (oeIGV.Porcentaje + 1), 4)
            txtIGV.Value = Math.Round(txtTotal.Value - txtSubTotal.Value, 4)
        Else
            txtIGV.Value = 0
            txtSubTotal.Value = txtTotal.Value
        End If
    End Sub

    Private Sub TrasponerDetalleOrden(ByVal lstDetalleOrden As List(Of e_OrdenMaterial), Optional ByVal _ref As String = "0")
        Try
            'Transpone el Detalle de la Orden al Detalle del Documento
            For Each oeDetOrden As e_OrdenMaterial In lstDetalleOrden
                oeDetalleDocumento = New e_DetalleDocumento()
                With oeDetalleDocumento
                    .TipoOperacion = oeMovimientoDocumento.TipoOperacion
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Seleccion = False
                    .IndGravado = oeDetOrden.IndicadorIgv
                    .Activo = True
                    .IdMaterialServicio = oeDetOrden.IdMaterial
                    .CodigoMaterialServicio = oeDetOrden.CodigoMaterial
                    If cboMaterialServicio.SelectedIndex = 0 Then
                        .IndServicioMaterial = "M"
                    Else
                        .IndServicioMaterial = "S"
                    End If
                    .NombreMaterialServicio = oeDetOrden.Material
                    .IdUnidadMedida = oeDetOrden.IdUnidadMedida
                    .IdTipoUnidadMedida = oeDetOrden.IdTipoUnidadMedida
                    .Cantidad = oeDetOrden.CantidadMaterial
                    If oeDetOrden.IndicadorIgv Then
                        .PrecioUnitarioSinImp = (oeDetOrden.ValorVenta / (1 + oeIGV.Porcentaje)) / oeDetOrden.CantidadMaterial
                        .Precio = Math.Round(.PrecioUnitarioSinImp * (1 + oeIGV.Porcentaje), 6)
                        .Subtotal = Math.Round(.PrecioUnitarioSinImp * .Cantidad, 4)
                        .Igv = Math.Round((.Precio * .Cantidad) - .Subtotal, 4)
                    Else
                        .PrecioUnitarioSinImp = oeDetOrden.ValorVenta / oeDetOrden.CantidadMaterial
                        .Precio = oeDetOrden.PrecioUnitario
                        .Subtotal = Math.Round(.Precio * .Cantidad, 4)

                        .Igv = 0
                    End If
                    .Total = Math.Round(.Precio * .Cantidad, 4)
                    .Pos = _ref
                    .IdCuentaContableCompra = ""
                End With
                lstDetalleDocumento.Add(oeDetalleDocumento)
            Next
            LLenarDetalleDocumento(lstDetalleDocumento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsociarOrden()
        Try
            oeOrden = New e_Orden
            oeOrden = griOrdenes.ActiveRow.ListObject
            If oeOrden.TipoReferencia = "1" Then
                If lstOrden.Count > 0 And oeMovimientoDocumento.IndConsignacion = False Then
                    Throw New Exception("No Puede Agregar Ordenes de Compra de Consignacion")
                End If
                oeMovimientoDocumento.IndConsignacion = True
                etiConsigna.Visible = True
            Else
                oeMovimientoDocumento.IndConsignacion = False
                etiConsigna.Visible = False
            End If
            For Each oeO As e_Orden In lstOrden.Where(Function(item) item.Id = oeOrden.Id)
                Throw New Exception("La Orden ya esta Asociada")
            Next
            For Each oeOrdenItem As e_Orden In lstOrden.Where(Function(item) item.NombreProveedor <> oeOrden.NombreProveedor)
                Throw New Exception("Escoja Orden del mismo Proveedor")
            Next
            For Each oeOrdCsg As e_Orden In lstOrden.Where(Function(item) item.TipoReferencia = "1")
                Throw New Exception("Solo Puede Crear una Factura x Cada Orden de Compra Consignacion")
            Next
            oeOrden = olOrden.Obtener(oeOrden)
            _ref_orden = _ref_orden + 1
            CargarOrdenAsociada(oeOrden, _ref_orden)
            MostrarListaOrdenes(oeOrden.TipoOrden)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MostrarListaOrdenes(ByVal tipo As String)
        If lstOrden.Count > 0 Then
            Me.UEGB_Ordenes.Enabled = 1
            Me.UEGB_Ordenes.Expanded = 0
            cbTipoOrden.Enabled = 0
        Else
            cbTipoOrden.Enabled = 1
            Me.UEGB_Ordenes.Enabled = 1
            Me.UEGB_Ordenes.Expanded = 0
        End If
        If Not String.IsNullOrEmpty(tipo) Then
            cbTipoOrden.Text = tipo
        End If
    End Sub

    Private Sub ListarOrdenes()
        Try
            oeOrden = New e_Orden
            oeOrden.fechaInicio = rFechasDesde.Value
            oeOrden.fechaFin = rFechasHasta.Value
            oeOrden.TipoOperacion = "4"
            oeOrden.IdTipoOrden = cbTipoOrden.Value
            oeOrden.IndMaterialServicio = cboMaterialServicio.Text
            listaO = olOrden.Listar(oeOrden)
            griOrdenes.DataSource = listaO
            griOrdenes.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarOrdenAsociada(ByVal oeOrden As e_Orden, Optional ByRef _ref As Integer = 0, Optional ByVal IdOrdenCompra As String = "")
        Try
            ListarProveedores(cboProveedor, oeOrden.IdProveedor)
            Dim oeOrdCom As New e_OrdenCompra
            Dim olOrdCom As New l_OrdenCompra
            Me.cboProveedor.Value = oeOrden.IdProveedor

            oeOrdCom.TipoOperacion = "1"
            oeOrdCom.Activo = 1
            oeOrdCom.TipoOperacion = "1"
            oeOrdCom.IdMoneda = "CERO"
            oeOrdCom.IdProveedor = "CERO"
            oeOrdCom.IdEstadoOrden = "CERO"
            oeOrdCom.IdTipoPago = "CERO"
            If oeOrden.TipoOrden = "ORDEN DE INGRESO" Then
                Dim oeOrdIng As New e_Orden
                oeOrdIng.Id = oeOrden.Id
                oeOrdIng = olOrden.Obtener(oeOrden)
                fecFechaActual.Value = oeOrdIng.FechaOrden
                cboMoneda.Value = oeOrdIng.IdMoneda
                cboTipoPago.SelectedIndex = 0
                If IdOrdenCompra <> "" Then
                    oeOrdCom.Id = IdOrdenCompra
                    oeOrdCom = olOrdCom.Obtener(oeOrdCom)
                    cboTipoPago.Value = oeOrdCom.IdTipoPago
                    fecFechaActual.Value = oeOrdCom.FechaOrden
                    cboMoneda.Value = oeOrdCom.IdMoneda
                End If
            Else
                oeOrdCom.Id = oeOrden.Id
                oeOrdCom = olOrdCom.Obtener(oeOrdCom)
                cboTipoPago.Value = oeOrdCom.IdTipoPago
                fecFechaActual.Value = oeOrdCom.FechaOrden
                cboMoneda.Value = oeOrdCom.IdMoneda
            End If

            oeOrden.Referencia = _ref.ToString
            'Llena la Asociacion
            lstOrden.Add(oeOrden)
            griListaOrdenIngreso.DataSource = lstOrden
            griListaOrdenIngreso.DataBind()
            'Carga el Detalle de la Orden
            Dim llDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
            Dim olDetalleOrdenIngreso As New l_OrdenMaterial
            Dim oeDetalleOrdenIngreso As New e_OrdenMaterial
            If oeOrden.TipoOrden.Equals("ORDEN DE COMPRA") Then
                oeDetalleOrdenIngreso.TipoOperacion = IIf(IndMaterialServicio.Equals("M"), "C", "S")
            Else
                oeDetalleOrdenIngreso.TipoOperacion = "L"
            End If
            oeDetalleOrdenIngreso.Activo = 1
            oeDetalleOrdenIngreso.IdOrden = oeOrden.Id
            llDetalleOrdenIngreso = olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso)
            'Transpone el Detalle de la Orden al Detalle del Documento
            TrasponerDetalleOrden(llDetalleOrdenIngreso, _ref.ToString)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Private Sub CargarAsociacion(ByVal IdDocumento As String)
        Try
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = "3"
            oeOrden.Referencia = IdDocumento
            oeOrden.IdTipoOrden = oeTipoDocumento.Id
            lstOrden = olOrden.Listar(oeOrden)
            MostrarListaOrdenes("")
            If lstOrden.Count > 0 Then
                griListaOrdenIngreso.DataSource = lstOrden : griListaOrdenIngreso.DataBind() : MostrarListaOrdenes(lstOrden.Item(0).TipoOrden)
                If lstOrden.Where(Function(item) item.TipoReferencia = "1").ToList.Count > 0 Then
                    etiConsigna.Visible = True
                Else
                    etiConsigna.Visible = False
                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EnviaTesoreria()
        Try
            If Not griListaFacturaCompra.ActiveRow Is Nothing AndAlso griListaFacturaCompra.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "CMP")
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim periodo_act As Integer = ObtenerPeriodo(Date.Now).Mes
                    Dim periodo_reg As Integer = frm.cboMes.Text
                    Dim FechaPeriodo As Date = CDate("01/" & frm.cboMes.Text & "/" & frm.Año1.Año)
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = griListaFacturaCompra.ActiveRow.Cells("Id").Value
                    oeMovimientoDocumento = olMovimientoDocumento.Obtener(oeMovimientoDocumento)
                    If oeMovimientoDocumento.IndServicioMaterial = "M" Then
                        If oePeriodo.Mes = periodo_act Then ValidaFechaIngreso(FechaPeriodo, oeMovimientoDocumento.Id)
                    End If
                    Dim oeTipDoc As New e_TipoDocumento
                    olTipoDocumento = New l_TipoDocumento
                    oeTipDoc.Id = oeMovimientoDocumento.IdTipoDocumento
                    oeTipDoc = olTipoDocumento.Obtener(oeTipDoc)
                    oeMovimientoDocumento.Compra.TipoDoc = oeTipDoc
                    If oeMovimientoDocumento.EstadoDocumento = gNombreEstadoEnviado Then Throw New Exception("El Documento ya ha Sido Enviado. Verificar")
                    If ValidarFechasPeriodo(oeMovimientoDocumento.FechaEmision, FechaPeriodo) Then
                        If oePeriodo.Mes <> CInt(frm.cboMes.Text) Then
                            If oeMovimientoDocumento.FechaEmision.Year <= oePeriodo.Ejercicio Then
                                If oeMovimientoDocumento.FechaEmision.Month <= oePeriodo.Mes Then
                                    Throw New Exception("Periodo " & oePeriodo.Codigo & " Abierto para Logistica.")
                                End If
                            End If
                        End If
                        If (periodo_act - IIf(periodo_reg = 12, 0, periodo_reg)) = 1 Then
                            Dim oeOrdenDoc As New e_Orden_Documento
                            Dim olOrdenDoc As New l_Orden_Documento
                            Dim lstOrdenDoc As New List(Of e_Orden_Documento)
                            oeOrdenDoc.IdDocumento = griListaFacturaCompra.ActiveRow.Cells("Id").Value
                            oeOrdenDoc.TipoOperacion = "E"
                            lstOrdenDoc = olOrdenDoc.Listar(oeOrdenDoc)
                            If lstOrdenDoc.Count > 0 Then
                                If Month(lstOrdenDoc.Item(0).FechaCreacion) = periodo_act Then
                                    lb_EmisionPerAnt = True
                                Else
                                    lb_EmisionPerAnt = False
                                End If
                                oeOrdenDoc.TipoOperacion = "T"
                                oeOrdenDoc.IdOrden = lstOrdenDoc.Item(0).IdOrden
                                olOrdenDoc = New l_Orden_Documento
                                lstOrdenDoc = New List(Of e_Orden_Documento)
                                lstOrdenDoc = olOrdenDoc.Listar(oeOrdenDoc)
                                If lstOrdenDoc.Count > 0 Then
                                    lb_EmisionPerAnt = False
                                End If
                            End If
                        Else
                            lb_EmisionPerAnt = False
                        End If
                        ' Obtiene Fecha Fin Periodo
                        Dim _oePerAux As New e_Periodo
                        _oePerAux.Id = frm.cboMes.Value : _oePerAux.Ejercicio = frm.Año1.Año
                        _oePerAux.TipoOperacion = String.Empty : _oePerAux.Activo = True
                        _oePerAux = olPeriodo.Obtener(_oePerAux)
                        oeMovimientoDocumento.FechaFinal = _oePerAux.FechaFin
                        ' ----------------------------
                        GuardarCmpAsiento(frm.cboMes.Value, frm.Año1.Año, True)
                        mensajeEmergente.Confirmacion("Se Envió Correctamente", True)
                        Listar(True)
                    End If
                End If
            Else
                Throw New Exception("Seleccione un Documento")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarDocSinAsoc()
        Try
            oeDocumentoSinAsociacion = New e_DocumentoSinAsociacion
            oeDocumentoSinAsociacion.TipoOperacion = "L"
            oeDocumentoSinAsociacion.FechaInicio = rfFechaDocDesde.Value
            oeDocumentoSinAsociacion.FechaFin = rfFechaDocHasta.Value
            oeDocumentoSinAsociacion.IdTipoDocumento = oeTipoDocumento.Id
            gridSinAsociacion.DataSource = olDocumentoSinAsociacion.Listar(oeDocumentoSinAsociacion)
            With gridSinAsociacion
                For Each fila As UltraGridRow In .Rows
                    Select Case fila.Cells("Evaluado").Value
                        Case 0
                            fila.CellAppearance.BackColor = Me.ColorSolicitado.Color
                        Case 1
                            fila.CellAppearance.BackColor = Me.ColorAprobado.Color
                        Case 2
                            fila.CellAppearance.BackColor = Me.ColorRechazado.Color
                    End Select
                Next
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub r_Solicitar_Doc()
        Try
            Dim frmEvaluar As frm_DocumentoSinAsociacion
            frmEvaluar = New frm_DocumentoSinAsociacion("Solicitar", "", oeTipoDocumento.Id)
            frmEvaluar.StartPosition = FormStartPosition.CenterScreen
            If frmEvaluar.ShowDialog = Windows.Forms.DialogResult.OK Then
                mensajeEmergente.Confirmacion("Se Registro Satisfactoriamente", True)
                ListarDocSinAsoc()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub r_Evaluar_Doc()
        Try
            '------- CONTROLAR AUTENTICACIÓN DEL TRABAJADOR------------
            oeTrabajadorSeguridad = New e_TrabajadorSeguridad
            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.TipoOperacion = ""
            oeProcesoNegocio.Nombre = "APROBAR DOCUMENTOS SIN ASOCIACION"
            oeProcesoNegocio = olProcesoNegocio.Obtener(oeProcesoNegocio)
            oeTrabajadorSeguridad.TipoOperacion = ""
            oeTrabajadorSeguridad.IdTrabajador = gUsuarioSGI.IdTrabajador
            oeTrabajadorSeguridad.IdProcesoNegocio = oeProcesoNegocio.Id
            oeTrabajadorSeguridad = olTrabajadorSeguridad.Obtener(oeTrabajadorSeguridad)
            l_FuncionesGenerales.ValidarCampoNoNulo(oeTrabajadorSeguridad.Id, "Trabajador No Autorizado")
            Dim frmEvaluar As frm_DocumentoSinAsociacion
            Dim Id As String = ""
            Id = gridSinAsociacion.ActiveRow.Cells("Id").Value.ToString
            frmEvaluar = New frm_DocumentoSinAsociacion("Evaluar", Id, oeTipoDocumento.Id)
            frmEvaluar.StartPosition = FormStartPosition.CenterScreen
            If frmEvaluar.ShowDialog = Windows.Forms.DialogResult.OK Then
                mensajeEmergente.Confirmacion("Se Registro Satisfactoriamente", True)
                ListarDocSinAsoc()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub r_NuevoDoc()
        Me.Nuevo()
        Dim Id As String
        Id = gridSinAsociacion.ActiveRow.Cells("Id").Value.ToString
        gbeListadoMatSer.Visible = 1 : UEGB_Ordenes.Visible = 0
        oeDocumentoSinAsoc = New e_DocumentoSinAsociacion
        oeDocumentoSinAsoc.TipoOperacion = "T"
        oeDocumentoSinAsoc.Id = Id
        oeDocumentoSinAsoc.Fecha = Date.Now
    End Sub

    Private Sub ComboPerido()
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            'Dim lePeriodo As New List(Of e_Periodo)
            lePeriodo = New List(Of e_Periodo)
            oePeriodo.Ejercicio = Año1.Año
            oePeriodo.Activo = True
            lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))
            With cboMes
                .DisplayMember = "Mes"
                .ValueMember = "Id"
                .DataSource = lePeriodo.Where(Function(item) item.CierreCompras = 0).ToList
                If .Items.Count > 0 Then
                    .Text = Date.Now.Month
                End If
                .SelectedIndex = -1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarComboMaestro(ByVal combo As Infragistics.Win.UltraWinGrid.UltraCombo)
        combo.ValueMember = "Id"
        combo.DisplayMember = "Nombre"
        With combo.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub



    Private Sub GuardarCmpAsiento(IdPeriodo As String, Periodo As Integer, IndNuevo As Boolean)
        Try
            oeMovimientoDocumento.IdPeriodo = IdPeriodo
            oeMovimientoDocumento.Ejercicio = Periodo
            oeMovimientoDocumento.Compra.TipoDoc = oeTipoDocumento
            oeMovimientoDocumento.IndOrigenContable = 2 ' Doc. Logístico.
            oeMovimientoDocumento.IndAsientoGuia = True

            If oeMovimientoDocumento.IndServicioMaterial = "M" Then
                Dim oeOrdDoc As New e_Orden_Documento
                Dim olOrdDoc As New l_Orden_Documento
                oeOrdDoc.IdDocumento = oeMovimientoDocumento.Id
                oeOrdDoc.TipoOperacion = "V"
                oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                oeMovimientoDocumento.loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
                Select Case oeOrdDoc.IndConsignacion
                    Case 1
                        oeMovimientoDocumento.loCtaCtbleSFam = LlenaCuenta(oeMovimientoDocumento, loCtaCtbleSFam, Periodo)

                        ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeOrdDoc.IdTipoDocumento, Periodo, oeOrdDoc.IndConsignacion)
                    Case 2
                        ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeOrdDoc.IdTipoDocumento, Periodo, "")
                    Case 3
                        oeMovimientoDocumento.loCtaCtbleSFam = LlenaCuenta(oeMovimientoDocumento, loCtaCtbleSFam, Periodo)
                        If lb_EmisionPerAnt = True Then
                            lo_SubFamCtaCtble_25 = New List(Of e_CtaCtbleSubFamiliaMat)
                            lo_SubFamCtaCtble_28 = New List(Of e_CtaCtbleSubFamiliaMat)
                            lo_SubFamCtaCtble_25 = LlenaCuenta(oeMovimientoDocumento, loCtaCtbleSFam, Periodo)
                            lo_SubFamCtaCtble_28 = LlenaCuenta(oeMovimientoDocumento, loCtaCtbleSFam, Periodo)
                        End If
                        ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMovimientoDocumento.IdTipoDocumento, Periodo, "")
                        If lb_EmisionPerAnt = True Then
                            Cuentas25x28(Periodo)
                            oeMovimientoDocumento.loCtaCtbleSFam = lo_SubFamCtaCtble_28
                        End If
                        oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    Case 4
                        oeMovimientoDocumento.IndTipoFactura = "1"
                        Dim oeDetDoc As New e_DetalleDocumento
                        Dim olDetalleDocumento As New l_DetalleDocumento
                        oeDetDoc.TipoOperacion = "COM"
                        oeDetDoc.Activo = 1
                        oeDetDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
                        oeDetDoc.IndServicioMaterial = "M"
                        oeMovimientoDocumento.lstDetalleDocumento = New List(Of e_DetalleDocumento)
                        oeMovimientoDocumento.lstDetalleDocumento.AddRange(olDetalleDocumento.Listar(oeDetDoc))
                        ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMovimientoDocumento.IdTipoDocumento, Periodo, "2")
                End Select
                If IndNuevo Then
                    oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olMovimientoDocumento.GuardarCompraMaterial(oeMovimientoDocumento)
                    If lb_EmisionPerAnt = True Then
                        Guardar_AsientoxExistencia()
                    End If
                End If
            Else
                oeMovimientoDocumento.loCtaCtbleCSer = New List(Of e_CtaCtbleCatServicio)
                oeMovimientoDocumento.loCtaCtbleCSer = LlenaCuentaCatServicio(oeMovimientoDocumento, loCtaCtbleCSer, Periodo)
                ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMovimientoDocumento.IdTipoDocumento, Periodo, "3")
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                olMovimientoDocumento.GuardarCmpServicio(oeMovimientoDocumento)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cuentas25x28(periodo As Integer)
        Dim oe_CtaCtbleAux As e_CuentaContable
        Dim ol_CtaCtbleAux As l_CuentaContable
        Dim lst_CtaCTble As List(Of e_CuentaContable)
        Dim oe_TablaCTble As e_TablaContableDet
        Dim ol_TablaCTble As l_TablaContableDet
        Dim lst_TablaCTble As List(Of e_TablaContableDet)

        For Each l_ctactble28 In lo_SubFamCtaCtble_28.Where(Function(g) g.NroCtaCtbleExistencias.StartsWith("25")).ToList
            oe_CtaCtbleAux = New e_CuentaContable
            ol_CtaCtbleAux = New l_CuentaContable
            oe_TablaCTble = New e_TablaContableDet
            ol_TablaCTble = New l_TablaContableDet
            With oe_TablaCTble
                .TipoOperacion = "1"
                .Texto2 = l_ctactble28.NroCtaCtbleCompra
                .Texto3 = l_ctactble28.NroCtaCtbleConsumo
                .Nombre = l_ctactble28.CtaCtbleExistencias
            End With
            lst_TablaCTble = ol_TablaCTble.Listar(oe_TablaCTble)
            If lst_TablaCTble.Count > 0 Then oe_TablaCTble = lst_TablaCTble.Where(Function(g) g.Texto1.StartsWith("28")).ToList.Item(0)
            l_ctactble28.NroCtaCtbleExistencias = oe_TablaCTble.Texto1
            With oe_CtaCtbleAux
                .Ejercicio = periodo
                .Cuenta = oe_TablaCTble.Texto1
                .Nombre = oe_TablaCTble.Nombre
            End With
            lst_CtaCTble = ol_CtaCtbleAux.Listar(oe_CtaCtbleAux)
            If lst_CtaCTble.Count > 0 Then oe_CtaCtbleAux = lst_CtaCTble.Item(0)
            l_ctactble28.IdCtaCtbleExistencias = oe_CtaCtbleAux.Id
            total_debe += l_ctactble28.TotalCuentas
            total_haber += l_ctactble28.TotalCuentas
        Next
        Dim oe_CtaAsoc As e_CuentaAsociada
        Dim ol_CtaAsoc As l_CuentaAsociada
        Dim lst_CtaAsoc As List(Of e_CuentaAsociada)
        For Each Asiento In oeMovimientoDocumento.loAsientoModelo
            lb_soles = IIf(Asiento.Moneda = "SOLES", True, False)
            For Each AsientoDet In Asiento.leDetalle.Where(Function(g) g.Cuenta = "25").ToList
                oe_CtaAsoc = New e_CuentaAsociada
                oe_CtaAsoc.IdCuentaContable = AsientoDet.IdCuentaContable
                If AsientoDet.Debe = "25" And AsientoDet.Haber = "" Then oe_CtaAsoc.DebeHaber = "D" : lb_debe = True
                If AsientoDet.Debe = "" And AsientoDet.Haber = "25" Then oe_CtaAsoc.DebeHaber = "H" : lb_debe = False
                oe_CtaAsoc.Activo = True
                ol_CtaAsoc = New l_CuentaAsociada
                lst_CtaAsoc = New List(Of e_CuentaAsociada)
                lst_CtaAsoc = ol_CtaAsoc.Listar(oe_CtaAsoc)
                If lst_CtaAsoc.Count > 0 Then oe_CtaAsoc = lst_CtaAsoc.Item(0)
                AsientoDet.Cuenta = "28"
                If AsientoDet.Debe = "25" Then AsientoDet.Debe = "28"
                If AsientoDet.Haber = "25" Then AsientoDet.Haber = "28"
                AsientoDet.IdCuentaContable = oe_CtaAsoc.IdCuentaAsociada
                AsientoDet.PrefijoID = gs_PrefijoIdSucursal '@0001
            Next
            Asiento.PrefijoID = gs_PrefijoIdSucursal '@0001
        Next
    End Sub

    Private Sub Guardar_AsientoxExistencia()
        Dim oeAsiento As New e_Asiento
        Dim oeAsientoMovimiento As New e_AsientoMovimiento
        Dim olAsiento As New l_Asiento
        Dim lst_AsientoMovimiento As New List(Of e_AsientoMovimiento)
        Dim glosa As String = "INGRESO A ALMACEN DE EXISTENCIAS POR RECIBIR " & oeMovimientoDocumento._AbrevTipoDoc & " " & oeMovimientoDocumento.Serie & "-" & oeMovimientoDocumento.Numero & ", " & oeMovimientoDocumento.NombreProveedor
        With oeAsiento
            .TipoOperacion = "I"
            .Glosa = glosa
            .GlosaImprime = glosa
            .Fecha = Date.Now
            .TotalDebe = total_debe
            .TotalHaber = total_haber
            .IdTipoAsiento = "1CH000020"
            .IdMoneda = oeMovimientoDocumento.IdMoneda
            .TipoCambio = oeMovimientoDocumento.TipoCambio
            .IdEstado = "CUADRADO" : .IdUsuarioCrea = oeMovimientoDocumento.IdUsuarioCrea : oeAsiento.Activo = True
            .IndOrigen = oeMovimientoDocumento.IndOrigenContable
            .IdPeriodo = ObtenerPeriodo(Date.Now).Id
            .IdUsuarioCrea = gUsuarioSGI.Id
            .PrefijoID = gs_PrefijoIdSucursal '@0001
        End With
        Dim linea_c As Integer = 0
        For Each l_ctactble28 In lo_SubFamCtaCtble_28.Where(Function(g) g.NroCtaCtbleExistencias.StartsWith("28")).ToList
            linea_c += 1
            oeAsientoMovimiento = New e_AsientoMovimiento
            With oeAsientoMovimiento
                .IdUsuarioCrea = gUsuarioSGI.Id
                .Glosa = glosa
                .NroLinea = linea_c
                .IdCuentaContable = l_ctactble28.IdCtaCtbleExistencias
                If lb_debe = True Then
                    If lb_soles = True Then
                        .HaberMN = Math.Round(l_ctactble28.TotalCuentas, 2)
                        .HaberME = Math.Round(l_ctactble28.TotalCuentas / oeAsiento.TipoCambio, 2)
                    Else
                        .HaberME = Math.Round(l_ctactble28.TotalCuentas, 2)
                        .HaberMN = Math.Round(l_ctactble28.TotalCuentas * oeAsiento.TipoCambio, 2)
                    End If
                Else
                    If lb_soles = True Then
                        .DebeMN = Math.Round(l_ctactble28.TotalCuentas, 2)
                        .DebeME = Math.Round(l_ctactble28.TotalCuentas / oeAsiento.TipoCambio, 2)
                    Else
                        .DebeME = Math.Round(l_ctactble28.TotalCuentas, 2)
                        .DebeMN = Math.Round(l_ctactble28.TotalCuentas * oeAsiento.TipoCambio, 2)
                    End If
                End If
                .BandGuardMasivo = False
                .TipoOperacion = "I"
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            lst_AsientoMovimiento.Add(oeAsientoMovimiento)
        Next
        For Each l_ctactble25 In lo_SubFamCtaCtble_25.Where(Function(g) g.NroCtaCtbleExistencias.StartsWith("25")).ToList
            linea_c += 1
            oeAsientoMovimiento = New e_AsientoMovimiento
            With oeAsientoMovimiento
                .IdUsuarioCrea = gUsuarioSGI.Id
                .Glosa = glosa
                .NroLinea = linea_c
                .IdCuentaContable = l_ctactble25.IdCtaCtbleExistencias
                If lb_debe = True Then
                    If lb_soles = True Then
                        .DebeMN = Math.Round(l_ctactble25.TotalCuentas, 2)
                        .DebeME = Math.Round(l_ctactble25.TotalCuentas / oeAsiento.TipoCambio, 2)
                    Else
                        .DebeME = Math.Round(l_ctactble25.TotalCuentas, 2)
                        .DebeMN = Math.Round(l_ctactble25.TotalCuentas * oeAsiento.TipoCambio, 2)
                    End If
                Else
                    If lb_soles = True Then
                        .HaberMN = Math.Round(l_ctactble25.TotalCuentas, 2)
                        .HaberME = Math.Round(l_ctactble25.TotalCuentas / oeAsiento.TipoCambio, 2)
                    Else
                        .HaberME = Math.Round(l_ctactble25.TotalCuentas, 2)
                        .HaberMN = Math.Round(l_ctactble25.TotalCuentas * oeAsiento.TipoCambio, 2)
                    End If
                End If
                .BandGuardMasivo = False
                .TipoOperacion = "I"
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            lst_AsientoMovimiento.Add(oeAsientoMovimiento)
        Next
        Dim oeAsiento_MovDoc As New e_Asiento_MovDoc
        Dim olAsiento_MovDoc As New l_Asiento_MovDoc
        oeAsiento_MovDoc.Activo = 1
        oeAsiento_MovDoc.IdMovimientoDocumento = oeMovimientoDocumento.Id
        oeAsiento_MovDoc = olAsiento_MovDoc.Listar(oeAsiento_MovDoc).Item(0)
        oeAsiento.AsientoMovimiento = lst_AsientoMovimiento
        oeAsiento.PrefijoID = gs_PrefijoIdSucursal '@0001
        oeAsiento_MovDoc.PrefijoID = gs_PrefijoIdSucursal '@0001
        If olAsiento.Guardar(oeAsiento, oeAsiento_MovDoc.IdAsiento) Then
            total_debe = 0.0
            total_haber = 0.0
            lb_debe = False
            lb_soles = False
        End If
    End Sub


    Private Sub EnvioTesoreria()
        Try
            oePeriodo = New e_Periodo
            oePeriodo.Ejercicio = ObtenerFechaServidor.Year
            oePeriodo = olPeriodo.ObtenerPeriodoVigente(oePeriodo, 3)
            EnviaTesoreria()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarCtaContable(ByVal Ejercicio As Integer)
        Try
            oeCtaContable = New e_CuentaContable : leCtaContable = New List(Of e_CuentaContable)
            oeCtaContable.Activo = True : oeCtaContable.Ejercicio = Ejercicio
            leCtaContable = olCtactble.Listar(oeCtaContable)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_FacturaCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me, cboProveedor2.Name, cboProveedor.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            InicializaTiempo()
            If sOrden Then
                IniciarFormulario()
            End If
            sOrden = 1
            ComboPerido()
            ListaDeVehiculo(griListaDetalleFactura, "IdVehiculo")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FacturaCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_FacturaCompra_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case Operacion
            Case "Nuevo"
                Me.Activate()
                Me.Cancelar()
            Case "Editar"
                Me.Activate()
                Me.Cancelar()

        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_FacturaCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Select Case Operacion
                Case "Nuevo"
                    MyBase.Nuevo()
                Case "Editar"
                    MyBase.Editar()
                    If txtEstado.Value <> "GENERADA" Then
                        ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 0)
                    Else
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
                    End If
                Case "Inicializa"
                    MostrarTabs(0, ficFacturaCompra)
                    ControlBoton(1, 1)
                    If griListaFacturaCompra.Rows.Count > 0 Then ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales(True)
    End Sub

    Private Sub txtBuscarMateriales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.Click
        If Not String.IsNullOrEmpty(txtBuscarMateriales.Text) Then
            txtBuscarMateriales.SelectAll()
        End If
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales(True)
        End If
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        oeMaterial.Nombre = txtBuscarMateriales.Value
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        Try
            griListaMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub griListaMateriales_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaMateriales.InitializeLayout
        With griListaMateriales
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", True, True)
            .DisplayLayout.GroupByBox.Hidden = True
        End With
    End Sub

    Private Sub btnListarServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarServicios.Click
        ListarServicios(True)
    End Sub

    Private Sub cboCategoriaServicios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ListarServicios(True)
        End If
    End Sub

    Private Sub griListaServicios_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServicios.CellChange
        Try
            griListaServicios.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleFactura.CellChange
        Try
            griListaDetalleFactura.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleFactura.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaDetalleFactura.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If
                    End With
                Case "IndGravado"
                    With griListaDetalleFactura.Rows(e.Cell.Row.Index)
                        swIgv = .Cells("IndGravado").Value
                        posGrilla = .Cells("Pos").Value
                        If swIgv Then
                            .Cells("Precio").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value * (1 + oeIGV.Porcentaje), 4)
                        Else
                            .Cells("Precio").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value, 4)
                        End If
                        griListaDetalleFactura.DataBind()
                    End With
                    CalcularTotales()
                Case "Cantidad"
                    With griListaDetalleFactura.ActiveRow
                        swIgv = .Cells("IndGravado").Value
                        If .Cells("Cantidad").Value < 0 Then
                            .Cells("Cantidad").Value = cantmat
                            Throw New Exception("La cantidad ingresada no puede ser menor o igual a 0. ")
                        End If
                        If .Cells("Cantidad").Value.Equals("") Then
                            .Cells("Cantidad").Value = 1
                        End If
                        .Cells("Total").Value = .Cells("Precio").Value * .Cells("Cantidad").Value
                        .Cells("SubTotal").Value = .Cells("Total").Value
                        .Cells("IGV").Value = Math.Round(.Cells("Total").Value - .Cells("SubTotal").Value, 4)
                    End With
                    CalcularTotales()
                Case "Precio"
                    Dim PrecioUnitarioConImp As Double
                    Dim PrecioUnitarioSinImp As Double
                    With griListaDetalleFactura.ActiveRow
                        swIgv = .Cells("IndGravado").Value
                        If .Index > -1 Then
                            PrecioUnitarioConImp = Convert.ToDouble(.Cells("Precio").Value)
                            If PrecioUnitarioConImp < 0 Then
                                .Cells("Precio").Value = cantmat
                                Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                            End If
                            PrecioUnitarioSinImp = IIf(swIgv, Math.Round(PrecioUnitarioConImp / (oeIGV.Porcentaje + 1), 4), Math.Round(PrecioUnitarioConImp, 4))
                            .Cells("PrecioUnitarioSinImp").Value = PrecioUnitarioSinImp
                            .Cells("Total").Value = .Cells("Precio").Value * .Cells("Cantidad").Value
                            .Cells("SubTotal").Value = IIf(swIgv, Math.Round(.Cells("Total").Value / (oeIGV.Porcentaje + 1), 4), Math.Round(.Cells("Total").Value, 4))
                            .Cells("IGV").Value = Math.Round(.Cells("Total").Value - .Cells("SubTotal").Value, 4)
                        End If
                    End With
                    CalcularTotales()
                Case "PrecioUnitarioSinImp"
                    Dim PrecioUnitario As Double = 0
                    Dim CostoUnitario As Double = 0
                    With griListaDetalleFactura.ActiveRow
                        swIgv = .Cells("IndGravado").Value
                        CostoUnitario = .Cells("PrecioUnitarioSinImp").Value
                        If CostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                        If CostoUnitario > 0 Then
                            PrecioUnitario = IIf(swIgv, CostoUnitario * (oeIGV.Porcentaje + 1), CostoUnitario)
                            .Cells("Precio").Value = Math.Round(PrecioUnitario, 4)
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleFactura_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListaDetalleFactura.BeforeCellUpdate
        With griListaDetalleFactura
            Select Case e.Cell.Column.Key
                Case "Cantidad", "Precio", "PrecioUnitarioSinImp"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    cantmat = e.Cell.Value

            End Select
        End With
    End Sub

    Private Sub griListaFacturaCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaFacturaCompra.DoubleClick
        If griListaFacturaCompra.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        AnularDocumentoCompra()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
    End Sub



    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        Try
            If Operacion <> "Inicializa" AndAlso ficFacturaCompra.SelectedTab.Index = 1 Then
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                ElseIf oeMovimientoDocumento.TipoOperacion = "A" Then
                    If decTc.Value = 0 Then
                        decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                    Else
                        If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                        MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                        End If
                    End If
                End If
            End If
            oeIGV = New e_Impuesto
            Dim olImp As New l_Impuesto
            oeIGV = olImp.IGV(fecFechaActual.Value)
            If cboMoneda.Text = "DOLARES" Then
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Header.Caption = "Costo $"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("Precio").Header.Caption = "Precio $"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("Total").Header.Caption = "Total $"
            Else
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("PrecioUnitarioSinImp").Header.Caption = "Costo S/"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("Precio").Header.Caption = "Precio S/"
                griListaDetalleFactura.DisplayLayout.Bands(0).Columns("Total").Header.Caption = "Total S/"
            End If
            griListaDetalleFactura.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaFacturaCompra_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaFacturaCompra.AfterRowActivate
        btnAnular.Enabled = 0
        cmdEnviaTesoreria.Enabled = 0
        If griListaFacturaCompra.ActiveRow.Index > -1 Then
            If griListaFacturaCompra.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                btnAnular.Enabled = 1 : cmdEnviaTesoreria.Enabled = 1
            End If
        End If
    End Sub

    Private Sub btnBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrdenes.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            ValidarFechaDesde_Hasta(rFechasDesde, rFechasHasta)
            ListarOrdenes()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub griOrdenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griOrdenes.DoubleClick
        If griOrdenes.Rows.Count > 0 Then
            AsociarOrden()
            CalcularTotales()
        End If
    End Sub





    Private Sub txtSerieM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieM.Validated
        If Not String.IsNullOrEmpty(txtSerieM.Text) Then txtSerieM.Text = gfc_ConcatenarCeros(txtSerieM.Text, lenSerie)
        'If Not String.IsNullOrEmpty(txtSerieM.Text) Then txtSerieM.Text = FormatoDocumento(txtSerieM.Text, 4)
    End Sub

    Private Sub txtNumeroM_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroM.Validated
        If Not String.IsNullOrEmpty(txtNumeroM.Text) Then txtNumeroM.Text = gfc_ConcatenarCeros(txtNumeroM.Text, lenNumero)
        'If Not String.IsNullOrEmpty(txtNumeroM.Text) Then txtNumeroM.Text = FormatoDocumento(txtNumeroM.Text, 8)
    End Sub

    Private Sub cmdEnviaTesoreria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnviaTesoreria.Click
        Try
            Dim MatSer As String = griListaFacturaCompra.ActiveRow.Cells("IndServicioMaterial").Value
            If MatSer = "M" Then
                oeOrdDoc = New e_Orden_Documento
                oeOrdDoc.IdDocumento = griListaFacturaCompra.ActiveRow.Cells("Id").Value
                oeOrdDoc.TipoOperacion = "I"
                If olOrdDoc.ValidaOIEjecutada(oeOrdDoc) Then
                    EnvioTesoreria()
                Else
                    Throw New Exception("Debe Ejecutar la OI antes de Enviar el Documento")
                End If
            Else
                EnvioTesoreria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cheActivoPercepcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheActivoPercepcion.CheckedChanged
        If cheActivoPercepcion.Checked Then
            Dim DecPorPer As Double = 2
            If txtTotal.Value > 0 Then
                Me.DecPorcentajePercepcion.Value = DecPorPer
            Else
                mensajeEmergente.Confirmacion("La Percepción es 0", True)
                cheActivoPercepcion.Checked = 0
            End If
        Else
            Me.DecPorcentajePercepcion.Value = 0
        End If
    End Sub

    Private Sub DecPorcentajePercepcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecPorcentajePercepcion.ValueChanged
        If DecPorcentajePercepcion.Value > 0 Then
            Me.DecPercepcion.Value = txtTotal.Value * (Me.DecPorcentajePercepcion.Value / 100)
        Else
            Me.DecPercepcion.Value = 0
        End If
    End Sub

    Private Sub DecPercepcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecPercepcion.ValueChanged
        If DecPercepcion.Value > 0 Then
            Me.DecTPagar.Value = txtTotal.Value + Me.DecPercepcion.Value
        Else
            Me.DecTPagar.Value = 0
        End If
    End Sub

    Private Sub DecDetraer_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecDetraer.ValueChanged

        If DecDetraer.Value > 0 Then
            DecMontoDetraccion.Value = Me.txtTotal.Value * (DecDetraer.Value / 100)
        Else
            DecMontoDetraccion.Value = 0
        End If
    End Sub

    Private Sub DecMontoDetraccion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecMontoDetraccion.ValueChanged
        If DecMontoDetraccion.Value > 0 Then
            Me.txtNetoPagar.Value = txtTotal.Value - Me.DecMontoDetraccion.Value
        Else
            txtNetoPagar.Value = 0
        End If
    End Sub

    Private Sub txtTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.ValueChanged
        If txtTotal.Value > 0 Then
            DecDetraer.Value = DecDetraer.Value
            DecPercepcion.Value = DecPercepcion.Value
        Else
            DecDetraer.Value = 0
            DecPercepcion.Value = 0
        End If
    End Sub

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ListarDocSinAsoc()
    End Sub

    Private Sub cboProveedor_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.DisplayMember = "Nombre"
        With cboProveedor.DisplayLayout.Bands(0)
            .Columns("Id").Hidden = True
            .Columns("Email").Hidden = True
            .Columns("Seleccion").Hidden = True
            .Columns("Contacto").Hidden = True
            .Columns("Codigo").Hidden = True
            .Columns("TipoPersonaEmpresa").Hidden = True
            .Columns("IdPersona").Hidden = True
            .Columns("IdEmpresa").Hidden = True
            .Columns("FechaActividad").Hidden = True
            .Columns("UsuarioCreacion").Hidden = True
            .Columns("Activo").Hidden = True
            .Columns("NroDocumento").Header.Caption = "N° RUC"
            .Columns("NroDocumento").Width = 50
            .Columns("Nombre").Width = 150
        End With
    End Sub

    Private Sub cboProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor, "0", chkRuc.Checked)
        End If
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub fecFechaActual_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaActual.Validated
        Try
            If Operacion <> "Inicializa" And ficFacturaCompra.SelectedTab.Index = 1 Then
                If oeMovimientoDocumento.TipoOperacion = "I" Then
                    decTc.Value = TipoCambio(fecFechaActual.Value, True)(0)
                ElseIf oeMovimientoDocumento.TipoOperacion = "A" Then
                    If decTc.Value = 0 Then
                        decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                    Else
                        If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                        = Windows.Forms.DialogResult.Yes Then
                            decTc.Value = TipoCambio(fecFechaActual.Value)(0)
                        End If
                    End If
                End If
            End If
            oeIGV = New e_Impuesto
            Dim olImp As New l_Impuesto
            oeIGV = olImp.IGV(fecFechaActual.Value)
        Catch ex As Exception
            decTc.Value = 0.0
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chk_CajaChica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_CajaChica.CheckedChanged
        'If Me.chk_CajaChica.Checked Then
        '    Me.EnviarTesoreria.Visible = True
        '    If oeMovimientoDocumento.Mes = "" Then cboMes.SelectedIndex = -1
        'Else
        '    Me.EnviarTesoreria.Visible = False
        'End If
    End Sub

    Private Sub griListaFacturaCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaFacturaCompra.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaDetalleFactura_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaDetalleFactura.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaOrdenIngreso_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaOrdenIngreso.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenes_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griOrdenes.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        ComboPerido()
    End Sub

    Private Sub cboProveedor2_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles cboProveedor2.InitializeLayout
        InicializarComboMaestro(cboProveedor2)
    End Sub

    Private Sub cboProveedor2_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProveedor2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor2, "0", False)
        End If
    End Sub

    Private Sub cboProveedor2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboProveedor2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor2.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub frm_FacturaCompra_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

#End Region

#Region "Menu y tabs"

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Select Case e.Tool.Key
            Case "Agregar"
                AgregarDetalle()
            Case "Eliminar"
                QuitarDetalle()
        End Select
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem2.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem3.Click
        Eliminar()
    End Sub

    Private Sub AnularToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem4.Click
        AnularDocumentoCompra()
    End Sub

    Private Sub EnviarTesoreriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarTesoreriaToolStripMenuItem.Click
        Try
            oeOrdDoc = New e_Orden_Documento
            oeOrdDoc.IdDocumento = griListaFacturaCompra.ActiveRow.Cells("Id").Value
            oeOrdDoc.TipoOperacion = "I"
            If olOrdDoc.ValidaOIEjecutada(oeOrdDoc) Then
                oePeriodo = New e_Periodo
                oePeriodo.Ejercicio = ObtenerFechaServidor.Year
                oePeriodo = olPeriodo.ObtenerPeriodoVigente(oePeriodo, 3)
                EnviaTesoreria()
            Else
                Throw New Exception("Debe Ejecutar la OI antes de Enviar el Documento")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'MenuContextual1

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitarToolStripMenuItem.Click
        r_Solicitar_Doc()
    End Sub

    Private Sub EvaluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluarToolStripMenuItem.Click
        r_Evaluar_Doc()
    End Sub

    Private Sub GenerarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarToolStripMenuItem.Click
        r_NuevoDoc()
    End Sub

    Private Sub MenuContextual2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual2.Opening
        MenuContextual2.Items("NuevoToolStripMenuItem1").Visible = 1
        MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 0
        MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 0
        MenuContextual2.Items("AnularToolStripMenuItem4").Visible = 0
        MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 0
        If griListaFacturaCompra.Selected.Rows.Count > 0 Then
            MenuContextual2.Items("ActualizarToolStripMenuItem2").Visible = 1
            MenuContextual2.Items("EliminarToolStripMenuItem3").Visible = 1
            If griListaFacturaCompra.ActiveRow.Cells("EstadoDocumento").Value = "GENERADA" Then
                MenuContextual2.Items("EnviarTesoreriaToolStripMenuItem").Visible = 1
            End If
        End If
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("SolicitarToolStripMenuItem").Visible = 1
        MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("GenerarToolStripMenuItem").Visible = 0
        If gridSinAsociacion.Selected.Rows.Count > 0 Then
            If gridSinAsociacion.ActiveRow.Cells("Evaluado").Value = 0 Then
                MenuContextual1.Items("EvaluarToolStripMenuItem").Visible = 1
            ElseIf gridSinAsociacion.ActiveRow.Cells("Evaluado").Value = 1 Then
                MenuContextual1.Items("GenerarToolStripMenuItem").Visible = 1
            End If
        End If
    End Sub

#End Region

#Region "Valida Solo Ingrese Numeros"

    Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Consultar(True)
        End If
    End Sub

    Private Sub txtSerieD_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Private Sub txtSerieM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerieM.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub txtNumeroM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumeroM.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



#End Region

#Region "Asiento Modelo"

    Private Sub AsientosContablesCompraDocN()
        AsientoModelo()
        CtaCtbleSubFamilia()
        CtaCtbleCatServicio()
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = "1CH000000299" ' pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = "1CH000000299" ' pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = olCtaCtbleSFam.Listar(oeCtaCtbleSFam)
    End Sub

    Private Sub CtaCtbleCatServicio()
        oeCtaCtbleCSer = New e_CtaCtbleCatServicio
        loCtaCtbleCSer = olCtaCtbleCSer.Listar(oeCtaCtbleCSer)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, IdTipoDocumento As String, Ejercicio As Integer, IndConsignacion As String)
        Try
            oeMovimientoDocumento.loAsientoModelo = New List(Of e_AsientoModelo)
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            If IndConsignacion = "" Then
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 5 AND IdRef2 = '" & IdTipoDocumento & "'"
            ElseIf IndConsignacion = "1" Then
                cadSQL = "TipoRef2 = 4 AND IdRef2 = '" & IdMoneda & "' AND TipoRef1 = 3 AND IdRef1 = '1CH000000037'"
            ElseIf IndConsignacion = "2" Then
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 7 AND IdRef2 = '1CH000000002' "
            Else
                cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 10 AND IdRef2 = '1PK000000003' "
            End If
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloFacturaGuia = New e_AsientoModelo
            oeAsientoModeloFacturaGuia.TipoOperacion = "" : oeAsientoModeloFacturaGuia.Activo = True
            oeAsientoModeloFacturaGuia.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloFacturaGuia.Ejercicio = Ejercicio
            oeAsientoModeloFacturaGuia = olAsientoModelo.Obtener(oeAsientoModeloFacturaGuia)
            ' Actualizar Cuenta para Empresas Relacionada
            Dim _oeEmpr As New e_Proveedor
            _oeEmpr.Tipo = 0
            _oeEmpr.Id = oeMovimientoDocumento.IdClienteProveedor
            If llProveedores.Contains(_oeEmpr) Then
                _oeEmpr = llProveedores.Item(llProveedores.IndexOf(_oeEmpr))
                If _oeEmpr.IndRelacionada = 1 Then
                    For Each _oeDet In oeAsientoModeloFacturaGuia.leDetalle
                        If Microsoft.VisualBasic.Left(_oeDet.Cuenta.Trim, 2) = "42" Then
                            Dim strCuenta As String = Replace(_oeDet.Cuenta, "2", "3", 1, 1)
                            Dim strNuevaCuenta As String = Microsoft.VisualBasic.Left(strCuenta, 4) & "3" & Microsoft.VisualBasic.Right(strCuenta, 1)
                            _oeDet.Cuenta = strNuevaCuenta
                            oeCtaContable = New e_CuentaContable
                            oeCtaContable.Cuenta = strNuevaCuenta : oeCtaContable.Equivale = 0
                            If leCtaContable.Contains(oeCtaContable) Then
                                oeCtaContable = leCtaContable.Item(leCtaContable.IndexOf(oeCtaContable))
                                _oeDet.IdCuentaContable = oeCtaContable.Id
                            End If
                        End If
                    Next
                End If
            End If
            oeMovimientoDocumento.loAsientoModelo.Add(oeAsientoModeloFacturaGuia)
            For Each oe As e_DetalleAsientoModelo In oeAsientoModeloFacturaGuia.leDetalle
                If oe.IndDocumento Then
                    oeMovimientoDocumento.IdCuentaContable = oe.IdCuentaContable.Trim
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    Private Sub txtTotal_Validated(sender As Object, e As EventArgs) Handles txtTotal.Validated
        Try
            Dim Total As Double = 0
            Dim flag As Boolean = False
            Dim DecimalPermitido As Double = 0
            'txtSubTotal.Value = 0
            'txtIGV.Value = 0
            'txtTotal.Value = 0

            If loConcepto.Count = 1 Then DecimalPermitido = loConcepto(0).Valor1

            For Each oeDetalleOC As e_DetalleDocumento In leActivo
                Total += oeDetalleOC.Cantidad * oeDetalleOC.Precio
                If oeDetalleOC.IndGravado Then flag = True
            Next

            If Total - txtTotal.Value = 0 Then Exit Sub


            If IIf(Total - txtTotal.Value >= 0, Total - txtTotal.Value, (Total - txtTotal.Value) * -1) > DecimalPermitido Then
                If flag Then
                    txtSubTotal.Value = Math.Round(Total / (oeIGV.Porcentaje + 1), 4)
                    txtIGV.Value = Math.Round(Total - txtSubTotal.Value, 4)
                Else
                    txtIGV.Value = 0
                    txtSubTotal.Value = txtTotal.Value
                End If
                txtTotal.Value = Math.Round(Total, 4)
                Throw New Exception("La diferencia entre la suma de los detalle con el total no debe superar " & DecimalPermitido)
            Else
                If flag Then
                    txtSubTotal.Value = Math.Round(txtTotal.Value / (oeIGV.Porcentaje + 1), 2)
                    txtIGV.Value = Math.Round(txtTotal.Value - txtSubTotal.Value, 2)
                Else
                    txtIGV.Value = 0
                    txtSubTotal.Value = txtTotal.Value
                End If
            End If


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDocBus_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDocBus.ValueChanged
        Try
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.Id = cboTipoDocBus.Value
            oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)

            lenSerie = gfc_ObtieneLongitudSerie(oeTipoDocumento.Codigo)
            txtSerieM.MaxLength = lenSerie
            lenNumero = gfc_ObtieneLongitudNumero(oeTipoDocumento.Codigo)
            txtNumeroM.MaxLength = lenNumero
        Catch ex As Exception
            Throw New Exception("Inconvenientes en obtener Tipo Documento")
        End Try

    End Sub
    Private Function r_ObtenerProceso(ByVal ls_Proceso As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            oeProceso.Nombre = ls_Proceso.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw New Exception("Inconvenientes en obtener Proceso de negocio " + ls_Proceso)
        End Try
    End Function
End Class