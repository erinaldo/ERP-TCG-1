'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios Centro y Giro
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_OrdenCompraServicio

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OrdenCompraServicio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_OrdenCompraServicio()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeFecha As New e_Fechas

    Dim oeOrdenCompra As New e_OrdenCompra
    Dim olOrdenCompra As New l_OrdenCompra

    Dim oeOrdenCompraServicio As New e_OrdenCompraServicio
    Dim olOrdenCompraServicio As New l_OrdenCompraServicio
    Dim llOrdenCompraServicio As New List(Of e_OrdenCompraServicio)

    Dim oeEmpresa As New e_Empresa
    Dim olEmpresa As New l_Empresa

    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    Dim llProveedores As New List(Of e_Proveedor)

    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    Dim llMoneda As New List(Of e_Moneda)

    Dim oeTipoOrdenCompra As New e_TipoOrdenCompra
    Dim olTipoOrdenCompra As New l_TipoOrdenCompra

    Dim oeTipoPago As New e_TipoPago
    Dim olTipoPago As New l_TipoPago
    Dim llTipoPago As New List(Of e_TipoPago)

    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro

    Dim oeCuentaBancaria As New e_CuentaBancaria
    Dim olCuentaBancaria As New l_CuentaBancaria

    Dim oeRequerimientoMaterial As New e_RequerimientoMaterial
    Dim olRequerimientoMaterial As New l_RequerimientoMaterial
    Dim llRequerimientoMaterial As New List(Of e_RequerimientoMaterial)

    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim llMaterial As New List(Of e_Material)

    Dim oeCotizacionDetalleSer As New e_CotizacionDetalleSer
    Dim olCotizacionDetalleSer As New l_CotizacionDetalleSer
    Dim llCotizacionDetalleSer As New List(Of e_CotizacionDetalleSer)

    Dim oeServicio As New e_Servicio
    Dim olServicio As New l_Servicio
    Dim llServicio As New List(Of e_Servicio)
    Dim olRequerimientoServicio As New l_RequerimientoServicio
    Dim llRequerimientoServicio As New List(Of e_RequerimientoServicio)
    Dim oeRequerimientoServicio As New e_RequerimientoServicio()

    Dim oeCategoriaServicio As New e_CategoriaServicio
    Dim olCategoriaServicio As New l_CategoriaServicio
    Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)

    Dim _IdTipoOrden As String = "1CH000000006" 'Indica el tipo de orden Compra

    Dim _Estado As String = "POR GENERAR" 'Para cuando que registrar por primera vez el estado de la orden pasará a generado.        
    Dim _IdEstadoOrden As String  '"1CH000000001" :Estado Generado.             

    Dim totalSinIgv As Double = 0.0
    Dim totalConIgv As Double = 0.0
    Dim cambioMon As Double = 0.0

    '------------Variables para controlar si se incluye o no el IGV.------------------
    Dim swIgv As Boolean
    Dim codigoMaterial As String
    Dim codigoServicio As String
    Dim codigoRequerimiento As String
    '---------------------------------------------------------------------------------

    Dim oeEstado As New e_EstadoOrden
    Dim olEstado As New l_EstadoOrden
    Dim llEstado As New List(Of e_EstadoOrden)

    Dim lstProveedor As New List(Of e_Proveedor)

    '---------------Datos para atención de OC------------------
    Dim cantTotalAtender As Double
    Dim TotalAtender As Double

    Dim idMovimientoInventario As String = "1CH000000002" 'ORDEN DE INGRESO POR COMPRA
    Dim idTipoOrden As String = "1CH000000001" 'Tipo de orden: De ingreso.

    'Dim idMoneda As String = "1CH01" 'Moneda en soles
    Dim oeOrdenIngreso As New e_Orden
    Dim olOrdenIngreso As New l_Orden
    Dim olDetalleOrdenIngreso As New l_OrdenMaterial
    Dim oeDetalleOrdenIngreso As New e_OrdenMaterial
    Dim llDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
    Dim llOrdenIngreso As New List(Of e_Orden)
    '----------------------------------------------------------------------

    '----------------Variables para la ejecución de ordnes de ingresos por compras
    'Manejador de Registro de Inventario
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim olRegistroInventario As New l_RegistroInventario
    Dim listaRegistroInventario As New List(Of e_RegistroInventario)

    Dim cantmat As Double = 0
    Dim cont As Integer
    Dim posGrilla As Integer

    'Dim tipoBien As String = "MATERIAL"
    Dim tipoBien As String = "SERVICIO"
    'Dim columnaHidden As Boolean
    Dim _ingresando_datos As Boolean = False

    Dim rutaDocumento As String

    Dim oeSubAlmacen As New e_SubAlmacen
    Dim olSubAlmacen As New l_SubAlmacen


    'Manejador de Proceso
    Dim oeProceso As New e_ProcesoNegocio
    Dim olProceso As New l_ProcesoNegocio
    'Manejador de TipoDocumento
    Dim oeTipoDocumento As New e_TipoDocumento
    Dim olTipoDocumento As New l_TipoDocumento
    'Manejador de ProcesoDocumento
    Dim oeProDoc As New e_ProcesoTipoDocumento
    Dim olProDoc As New l_ProcesoTipoDocumento
    'Manejador MovimientoDocumento
    Dim oeMovimientoDocumento As New e_MovimientoDocumento
    Dim olmovimientoDocumento As New l_MovimientoDocumento
    Dim lstaDetalleDoc As New List(Of e_DetalleDocumento) : Dim oeDetalleDoc As New e_DetalleDocumento
    Dim lstaOrden As New List(Of e_Orden)
    '---------
    'Manejador de Unidad de Medida
    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida
    'Manejador de Material - Almacen
    Dim oeMaterialAlmacen As New e_MaterialAlmacen
    Dim olMaterialAlmacen As New l_MaterialAlmacen
    'Manejador de Inventario
    Dim oeInventario As New e_Inventario
    Dim olInventario As New l_Inventario
    'Manejador de Bloqueo
    Dim ls_IdOrdenAprobacion As String = ""

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto

    Dim oeCotizacion As New e_Cotizacion
    Dim olCotizacion As New l_Cotizacion
    Dim loCotizacion As New List(Of e_Cotizacion)

    Private oeOrdenTrabajo As New e_OrdenTrabajo

    Private oeAsientoModelo, oeAsientoModeloCmpServ As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)

    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)
    Private dtReferencia As New DataTable

    Private oeCtaCtbleCSer As New e_CtaCtbleCatServicio
    Private olCtaCtbleCSer As New l_CtaCtbleCatServicio
    Private loCtaCtbleCSer As New List(Of e_CtaCtbleCatServicio)

    'variables para retencion de rrhh
    Private oeEmpresaAporte As New e_EmpresaAportacion
    Private olEmpresaAporte As New l_EmpresaAportacion

    Private oeCtaContable As e_CuentaContable, leCtaContable As List(Of e_CuentaContable), olCtactble As New l_CuentaContable

    Private lenSerie As Integer = 0, lenNumero As Integer = 0

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            If griListaOrdenCompra.Rows.Count > 0 Then
                If Activo Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 0, 1)
                End If
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Inicializar()
            LimpiarControles()
            If txtTC.Value = 0 Then
                mensajeEmergente.Confirmacion("No existe tipo de cambio para esta fecha.")
            End If
            _IdEstadoOrden = "1CH000000001"
            ConsultarDetalle(True)
            Operacion = "Nuevo"
            MostrarTabs(1, ficOrdenCompra, 2)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            ConsultarDetalle(True)
            ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
            Operacion = "Editar"
            If EditarOrdenCompra() Then
                If oeOrdenCompra.EstadoOrden = "GENERADA" Then
                    Me.btnEnviarCorreo.Enabled = False
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0) 'Habilito el boton Guardar 
                Else
                    Control_Bloqueo()
                End If
                If oeOrdenCompra.IndicadorConsignacion Then
                    ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
                End If
                If txtTC.Value = 0 Then
                    mensajeEmergente.Confirmacion("No existe tipo de cambio para esta fecha.")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrdenCompra() Then
                Consultar(True)
                MostrarTabs(0, ficOrdenCompra, 2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOrdenCompra.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarOrdenCompra() Then
                            MostrarTabs(0, ficOrdenCompra, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOrdenCompra, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficOrdenCompra, 2)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaOrdenCompra
                If ValidarGrilla(griListaOrdenCompra, "Orden de compra") Then
                    If .ActiveRow.Cells("EstadoOrden").Value <> "GENERADA" Then Throw New Exception("Solo podrá eliminar OC que esten Generada")
                    oeOrdenCompra = New e_OrdenCompra
                    oeOrdenCompra.Id = griListaOrdenCompra.ActiveRow.Cells("Id").Value.ToString
                    If MessageBox.Show("Esta seguro de eliminar la orden de compra N°: " & _
                             Trim(.ActiveRow.Cells("NroOrden").Value.ToString) & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeOrdenCompra.TipoOperacion = "E"
                        oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olOrdenCompra.Eliminar(oeOrdenCompra)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        ImprimirOrdenesCompra(False)
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            If ficOrdenCompra.Tabs(0).Selected() AndAlso griListaOrdenCompra.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra para exportar al Excel")
            If ficOrdenCompra.Tabs(0).Selected() Then Exportar_Excel(griListaOrdenCompra)
            If ficOrdenCompra.Tabs(1).Selected() Then
                If ficDetalle.Tabs(0).Selected() Then
                    'If 'ficDetalleOCMateriales.Tabs(0).Selected() AndAlso griListaDetalleOrdenCompraMaterial.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra de Material para exportar al Excel")
                    'If 'ficDetalleOCMateriales.Tabs(0).Selected() Then Exportar_Excel(griListaDetalleOrdenCompraMaterial)

                    'If 'ficDetalleOCMateriales.Tabs(1).Selected() AndAlso griListaOrdenIngreso.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Ingresos para exportar al Excel")
                    'If 'ficDetalleOCMateriales.Tabs(1).Selected() Then Exportar_Excel(griListaOrdenIngreso)
                End If
                If ficDetalle.Tabs(1).Selected() AndAlso griListaDetalleOrdenCompraServicio.Rows.Count = 0 Then Throw New Exception("No hay ninguna Orden de Compra de Servicio para exportar al Excel")
                If ficDetalle.Tabs(1).Selected() Then Exportar_Excel(griListaDetalleOrdenCompraServicio)
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Métodos"

    Private Sub IniciarFormulario()
        Try
            ColoresGenerado.Color = Blanco
            ColoresEvaluado.Color = Kaki
            ColoresAtendidoParcialmente.Color = Azulino
            ColoresAtendido.Color = MarronClaro
            ColoresTerminado.Color = VerdeClaro

            cboFormaBusqueda.SelectedIndex = 0
            LlenaCombos()
            FechaDesde.Value = Date.Now.AddDays(-7)
            FechaHasta.Value = Date.Now
            fecFechaEntrega.Value = Date.Now
            fecFechaPago.Value = Date.Now
            fecFechaActual.Value = Date.Now
            btnAtenderOC.Enabled = False
            btnAprobar.Enabled = False
            oeIGV = New e_Impuesto
            oeIGV = olIGV.IGV(fecFechaActual.Value)

            txtPorcenIGV.Value = ObtenerIGV(fecFechaActual.Value)
            'ControlaBarraOperacionesOI(0, 0, 0, 0)
            ValidaFichaDetalleOrden()
            cboTipoOrdenCompra.Enabled = False

            AsociarMenu()
            'Generar comprobante en orden compra servicios-----------------------
            chkGenComprobante.Visible = True
            agrGenerarComprabante.Visible = True
            btnEnviar.Visible = True
            '--------------------------------------------------------------------
            lbl_etiqueta.Visible = False
            rfFechaCotDesde.Value = Date.Now.AddDays(-15)

            AsientosContablesServicio()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            'ficDetalleOCMateriales.Tabs(1).Enabled = 1
            llRequerimientoMaterial.Clear()
            llOrdenCompraServicio.Clear()
            llMaterial.Clear()
            llServicio.Clear()
            llCotizacionDetalleSer.Clear()
            loCotizacion.Clear()

            cboProveedor.DataSource = lstProveedor

            griListaServicios.DataSource = llServicio
            griListaDetalleOrdenCompraServicio.DataSource = llOrdenCompraServicio
            griCotizacion.DataSource = loCotizacion

            griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("PrecioUnitarioConImp").CellClickAction = 4
            griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("IndicadorIgv").CellClickAction = 4

            controlaColumnasGriDetOC(4, True, True, True, 4)
            lbl_etiqueta.Visible = 0
            cont = 0
            cambioMon = TipoCambio(Date.Now, 1)(0)
            txtTC.Value = cambioMon
            Me.chkGenComprobante.Visible = True
            chkGenComprobante.Checked = 0 : cbCentro.Checked = 0
            r_LimpiaComprobante()
            MostrarTabs(0, FichaTop, 1)
            Me.cheActivoPercepcion.Checked = False
            Me.DecDetraer.Value = 0
            Me.chkBloquea.Visible = 0
            Me.chkBloquea.Checked = 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarControles()
        _Estado = "POR GENERAR"
        ls_IdOrdenAprobacion = ""
        txtEstado.Value = _Estado
        txtNumeroOrden.Value = String.Empty
        txtNumeroOrden.ReadOnly = False
        txtNumeroOrden.Value = ""
        txtObservaciones.Value = String.Empty
        oeOrdenCompra.TipoOperacion = "I"
        oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
        txtNotas.Value = String.Empty
        'cboProveedor.Text = String.Empty
        cboProveedor.Value = Nothing
        chkRuc.Checked = False
        cboMoneda.SelectedIndex = 0
        cboTipoPago.SelectedIndex = 0
        cboTipoOrdenCompra.SelectedIndex = 1
        fecFechaEntrega.Value = Date.Now
        fecFechaPago.Value = Date.Now
        fecFechaActual.Value = Date.Now
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        totalSinIgv = 0.0
        totalConIgv = 0.0
        chkRuc.Checked = 0
        cheAutoAprobar.Checked = 1
        gbeListadoServicios.Expanded = 0
    End Sub

    Private Sub Control_Bloqueo()
        Me.btnEnviarCorreo.Enabled = 1 : Me.chkBloquea.Visible = 0

        griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("PrecioUnitarioConImp").CellClickAction = 0
        griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("IndicadorIgv").CellClickAction = 0

        If _Estado.Equals("TERMINADA") Then
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
            ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
            r_BuscarDocumento(oeOrdenCompra.Id, "1CH000000006")
            Exit Sub
        End If
        r_BuscarDocumento(oeOrdenCompra.Id, "1CH000000006")
        If oeOrdenCompra.EstadoOrden = "EVALUADA" Or oeOrdenCompra.EstadoOrden = "ATENDIDO" Then ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
        If oeOrdenCompra.IndBloqueo Then
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
        Else
            gbeListadoServicios.Visible = 1 : ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
        End If
        If gUsuarioSGI.IdTrabajador = oeOrdenCompra.IdTrabajadorAprobacion Then Me.chkBloquea.Visible = 1 : ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 0)
    End Sub

    Sub r_BuscarDocumento(ByVal lsIdOrden As String, ByVal lsTipoOrden As String)
        Try
            Dim olOrdenDoc As New l_Orden_Documento
            Dim oeOrdenDoc As New e_Orden_Documento
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeOrdenDoc.TipoOperacion = "D"
            oeOrdenDoc.Activo = 1
            oeOrdenDoc.IdOrden = lsIdOrden
            oeOrdenDoc.IdTipoOrden = lsTipoOrden
            oeMovimientoDocumento = olOrdenDoc.ObtenerDocumento(oeOrdenDoc)
            If Not oeMovimientoDocumento.Id Is Nothing And Not String.IsNullOrEmpty(oeMovimientoDocumento.Id.ToString) Then
                Me.cmbTipoDocumento.Value = oeMovimientoDocumento.IdTipoDocumento
                Me.txtSerie.Text = oeMovimientoDocumento.Serie
                Me.txtNroComprabante.Text = oeMovimientoDocumento.Numero
                Me.udtFechaEmision.Value = oeMovimientoDocumento.FechaEmision
                Me.txtEstadoDoc.Text = oeMovimientoDocumento.EstadoDocumento
                If Me.txtEstadoDoc.Text = "GENERADA" Then btnEnviar.Enabled = 1
                Me.chkGenComprobante.Visible = 0
                chkCajaChica.Checked = oeMovimientoDocumento.CobraCajaChica
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub listarDetalleOrdenCompraServicio(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompraServicio = New e_OrdenCompraServicio
            With griListaDetalleOrdenCompraServicio

                oeOrdenCompraServicio.Activo = Activo
                oeOrdenCompraServicio.IdOrden = oeOrdenCompra.Id
                llOrdenCompraServicio = olOrdenCompraServicio.Listar(oeOrdenCompraServicio)
                .DataSource = llOrdenCompraServicio

            End With

            If oeOrdenCompra.IndCotizacion Then
                griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("PrecioUnitarioConImp").CellClickAction = CellClickAction.RowSelect
                'griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("IndicadorIgv").CellClickAction = CellClickAction.RowSelect
            End If

        Catch ex As Exception
            Throw ex
        End Try

        If griListaDetalleOrdenCompraServicio.Rows.Count > 0 Then griListaDetalleOrdenCompraServicio.Focus()

    End Sub

    Public Sub ConsultarDetalleOrdenCompra()
        Try
            ValidaFichaDetalleOrden()
            gbeListadoServicios.Expanded = False
            listarDetalleOrdenCompraServicio(True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EditarOrdenCompra() As Boolean
        Dim id As String
        Try
            With griListaOrdenCompra
                _Estado = .ActiveRow.Cells("EstadoOrden").Value
                _IdEstadoOrden = .ActiveRow.Cells("IdEstadoOrden").Value
                id = .ActiveRow.Cells("Id").Value.ToString
                If id.Length > 0 Then
                    oeOrdenCompra = New e_OrdenCompra
                    oeOrdenCompra.Id = id
                    oeOrdenCompra.Activo = .ActiveRow.Cells("Activo").Value.ToString
                    oeOrdenCompra.Glosa = .ActiveRow.Cells("Glosa").Value.ToString
                    oeOrdenCompra.Notas = .ActiveRow.Cells("Notas").Value.ToString
                    oeOrdenCompra.TipoOperacion = "1"
                    oeOrdenCompra.IdMoneda = "CERO"
                    oeOrdenCompra.IdProveedor = "CERO"
                    oeOrdenCompra.IdEstadoOrden = "CERO"
                    oeOrdenCompra.IdTipoPago = "CERO"
                    oeOrdenCompra = olOrdenCompra.Obtener(oeOrdenCompra)
                    If oeOrdenCompra.Activo Then
                        lbNumeroOrden.Visible = True
                        txtNumeroOrden.Value = oeOrdenCompra.NroOrden
                        txtNumeroOrden.ReadOnly = True
                        txtNumeroOrden.Visible = True
                        fecFechaActual.Value = oeOrdenCompra.FechaOrden
                        txtEstado.Value = oeOrdenCompra.EstadoOrden
                        ListarProveedores(cboProveedor, oeOrdenCompra.IdProveedor, 0)
                        cboProveedor.Value = oeOrdenCompra.IdProveedor
                        fecFechaEntrega.Value = oeOrdenCompra.FechaEntrega
                        fecFechaPago.Value = oeOrdenCompra.FechaPago
                        cboTipoPago.Value = oeOrdenCompra.IdTipoPago
                        cboMoneda.Value = oeOrdenCompra.IdMoneda
                        cboTipoPago.Value = oeOrdenCompra.IdTipoPago
                        cboTipoOrdenCompra.Value = oeOrdenCompra.IdTipoOrdenCompra
                        txtObservaciones.Value = oeOrdenCompra.Glosa
                        txtNotas.Value = oeOrdenCompra.Notas
                        txtSubTotal.Value = oeOrdenCompra.SubTotal
                        txtIGV.Value = oeOrdenCompra.Impuesto
                        txtTotal.Value = oeOrdenCompra.Total
                        totalSinIgv = oeOrdenCompra.SubTotal
                        totalConIgv = oeOrdenCompra.Total
                        fecFechaActual.Value = oeOrdenCompra.FechaOrden
                        txtPorcenIGV.Value = ObtenerIGV(fecFechaActual.Value)
                        cboCentro.Value = oeOrdenCompra.IdCentro
                        '----
                        cambioMon = TipoCambio(fecFechaActual.Value, 1)(0)
                        txtTC.Value = cambioMon
                        '-----
                        MostrarTabs(1, ficOrdenCompra, 1)
                        oeOrdenCompra.TipoOperacion = "A"
                        cheAutoAprobar.Checked = oeOrdenCompra.IndicadorAprobacion
                        chkBloquea.Checked = oeOrdenCompra.IndBloqueo
                        ls_IdOrdenAprobacion = oeOrdenCompra.IdAprobacion
                        ConsultarDetalleOrdenCompra()
                        If oeOrdenCompra.Percepcion > 0 Then
                            Me.cheActivoPercepcion.Checked = 1
                            DecPorcentajePercepcion.Value = oeOrdenCompra.PercepcionPorc
                        End If
                        DecDetraer.Value = oeOrdenCompra.DetraccionPorc
                        Return True
                    Else
                        Throw New Exception(Me.Text & ": El Registro se encuentra eliminado y no se puede editar")
                    End If
                Else
                    Throw New Exception("Seleccione una Fila!")
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub ImprimirOrdenesCompra(ByVal enviarCorreo As Boolean)

        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        objXls = New Excel.Application
        Dim FileToCopy As String
        Dim PathFilePTRA As String
        Dim oeOrdApr As New e_OrdenAprobacion
        Dim olOrdApr As New l_OrdenAprobacion
        Try
            oeOrdApr.IdOrden = oeOrdenCompra.Id
            oeOrdApr.Activo = True
            oeOrdApr = olOrdApr.Obtener(oeOrdApr)
            If oeOrdApr.IdTrabajador = "1CH000000021" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraSuzzette_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraSuzzette.xls"
            ElseIf oeOrdApr.IdTrabajador = "1CH000000002" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraWilson_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraWilson.xls"
            ElseIf oeOrdApr.IdTrabajador = "1CH000000012" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraMabel_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraMabel.xls"
            ElseIf oeOrdApr.IdTrabajador = "1CH000000020" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraRamiro_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraRamiro.xls"
            ElseIf oeOrdApr.IdTrabajador = "1PY000000284" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraMiguel_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraMiguel.xls"
            ElseIf oeOrdApr.IdTrabajador = "1CH000000003" Then
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_CompraSixto_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compraSixto.xls"
            Else
                FileToCopy = Application.StartupPath & "\PLANTILLAS_SGI\Plantilla_Orden_Compra_SGI.xlt" 'gs_RutaPlantillas & "Plantilla_Orden_Compra_SGI.xlt"
                PathFilePTRA = Application.StartupPath & "\_orden_compra.xls"
            End If

            If System.IO.File.Exists(FileToCopy) Then
                If System.IO.File.Exists(PathFilePTRA) Then
                    System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
                End If
                System.IO.File.Copy(FileToCopy, PathFilePTRA, True)
                System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.Archive + IO.FileAttributes.Normal)
            Else
                Throw New Exception("No se encontró el archivo de Plantilla en el servidor, Consulte con Soporte")
            End If

            ' Creamos una variable para guardar la cultura actual
            Dim OldCultureInfo As System.Globalization.CultureInfo = _
            System.Threading.Thread.CurrentThread.CurrentCulture

            'Crear una cultura standard (en-US) inglés estados unidos
            System.Threading.Thread.CurrentThread.CurrentCulture = _
            New System.Globalization.CultureInfo("es-PE")

            'Abrimos la plantilla
            'objWorkbook = objXls.Workbooks.Open(Application.StartupPath & "\PTRA.xls")
            objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
            'objWorkbook = objXls.Workbooks.Add
            objWorkSheet = objXls.Worksheets(1)
            'objWorkSheet = objXls.ActiveSheet
            If oeOrdenCompra.NroOrden Is Nothing Then Throw New Exception("La Orden aun no se encuentra Registrada")
            objWorkSheet.Name = oeOrdenCompra.NroOrden   'Asignamos el nombre al archivo en excel.
            Dim lnVecesImp As Integer = 0 'consultar si se ha impreso previamente.
            If lnVecesImp > 0 Then
                objWorkSheet.Cells(2, 7) = "COPIA"
                objWorkSheet.Range(objWorkSheet.Cells(2, 7), objWorkSheet.Cells(2, 7)).Font.Size = 14
                objWorkSheet.Range(objWorkSheet.Cells(2, 7), objWorkSheet.Cells(2, 7)).Font.Bold = True
            End If
            '----------------------Enviando datos al excel-----------------------------------
            objWorkSheet.Cells(2, 7) = "ORDEN DE SERVICIOS"
            'objWorkSheet.Cells(7, 2) = "20479729141"
            objWorkSheet.Cells(4, 9) = oeOrdenCompra.NroOrden
            objWorkSheet.Cells(10, 15) = Date.Parse(oeOrdenCompra.FechaOrden).Date.Day & "/" & Date.Parse(oeOrdenCompra.FechaOrden).Date.Month & "/" & Date.Parse(oeOrdenCompra.FechaOrden).Date.Year

            'DATOS DE EMPRESA GENERADORA            
            oeEmpresa = New e_Empresa
            oeEmpresa.Id = ISL_IdEmpresa
            oeEmpresa = olEmpresa.Obtener(oeEmpresa)
            objWorkSheet.Cells(1, 3) = oeEmpresa.Abreviatura
            objWorkSheet.Cells(4, 3) = oeEmpresa.Nombre
            objWorkSheet.Cells(7, 2) = oeEmpresa.Ruc
            If oeEmpresa.leTelefono.Count > 0 Then objWorkSheet.Cells(7, 5) = oeEmpresa.leTelefono.Item(0).Nombre ' "233190" 'oeProveedor.oeEmpresa.Telefono            
            If oeEmpresa.leDireccionEP.Count > 0 Then objWorkSheet.Cells(9, 2) = oeEmpresa.leDireccionEP.Item(0).Nombre '"PANAMERICANA NORTE KM 775 - LAMBAYEQUE" 'SOLO POR EL MOMENTO
            If oeEmpresa.leEmail.Count > 0 Then objWorkSheet.Cells(12, 2) = oeEmpresa.leEmail.Item(0).Nombre ' "abc@gmail.com" 'oeProveedor.

            'DATOS DE EMPRESA PROVEEDORA
            oeProveedor = New e_Proveedor()
            oeProveedor.TipoOperacion = "2"
            oeProveedor.Id = oeOrdenCompra.IdProveedor
            oeProveedor = olProveedor.Obtener(oeProveedor)
            objWorkSheet.Cells(22, 2) = oeProveedor.NroDocumento
            objWorkSheet.Cells(18, 2) = oeProveedor.Nombre
            If oeProveedor.leDireccion.Count > 0 Then objWorkSheet.Cells(24, 2) = oeProveedor.leDireccion.Item(0).Nombre '"Villarreal" 'a_Empresa(0).DireccionFiscal
            If oeProveedor.leTelefono.Count > 0 Then objWorkSheet.Cells(28, 2) = oeProveedor.leTelefono.Item(0).Nombre '"21212212" 'a_Empresa(0).Telefono
            objWorkSheet.Cells(28, 5) = "" 'Fax
            If oeProveedor.leEmail.Count > 0 Then objWorkSheet.Cells(30, 2) = oeProveedor.leEmail.Item(0).Nombre 'oeProveedor.

            'CONDICIONES COMERCIALES
            oeTipoPago = New e_TipoPago
            oeTipoPago.Id = oeOrdenCompra.IdTipoPago
            oeTipoPago = olTipoPago.Obtener(oeTipoPago)

            oeMoneda = New e_Moneda
            oeMoneda.Id = oeOrdenCompra.IdMoneda
            oeMoneda = olMoneda.Obtener(oeMoneda)

            objWorkSheet.Cells(18, 9) = oeTipoPago.Nombre   'oeTipoPago.Nombre
            objWorkSheet.Cells(22, 9) = oeOrdenCompra.FechaEntrega.Day & "/" & oeOrdenCompra.FechaEntrega.Month & "/" & oeOrdenCompra.FechaEntrega.Year
            objWorkSheet.Cells(24, 9) = oeOrdenCompra.FechaPago.Day & "/" & oeOrdenCompra.FechaPago.Month & "/" & oeOrdenCompra.FechaPago.Year
            objWorkSheet.Cells(26, 9) = oeMoneda.Nombre
            objWorkSheet.Cells(28, 9) = "" 'cbo_Banco.Text
            objWorkSheet.Cells(30, 9) = "" 'txt_NroCtaBanco.Text
            Dim ln_Fila As Integer = 1
            For Each obj As e_OrdenCompraServicio In llOrdenCompraServicio
                Dim ln_PrecioIGV As Double = Math.Round(obj.PrecioUnitarioConImp, 4)
                Dim ln_Importe As Double = Math.Round(obj.Importe, 4)
                objWorkSheet.Cells(ln_Fila + 33, 1) = ln_Fila
                objWorkSheet.Cells(ln_Fila + 33, 2) = obj.CodigoServicio
                objWorkSheet.Cells(ln_Fila + 33, 4) = obj.Cantidad
                objWorkSheet.Cells(ln_Fila + 33, 5) = obj.Servicio
                objWorkSheet.Cells(ln_Fila + 33, 13) = ""
                objWorkSheet.Cells(ln_Fila + 33, 15) = ln_PrecioIGV
                objWorkSheet.Cells(ln_Fila + 33, 16) = ln_Importe
                ln_Fila = ln_Fila + 1
            Next
            'Abreviatura de moneda
            objWorkSheet.Cells(68, 14) = oeMoneda.Abreviatura
            objWorkSheet.Cells(69, 14) = oeMoneda.Abreviatura
            objWorkSheet.Cells(70, 14) = oeMoneda.Abreviatura

            objWorkSheet.Cells(68, 15) = Math.Round(oeOrdenCompra.SubTotal, 4)  'txt_SubTotal.Text 'SUB TOTAL
            objWorkSheet.Cells(69, 15) = Math.Round(oeOrdenCompra.SubTotal * txtPorcenIGV.Value, 4)  'txt_ImpuestoVta.Text 'IGV
            objWorkSheet.Cells(70, 15) = Math.Round(oeOrdenCompra.Total, 4) 'TOTAL
            objWorkSheet.Cells(69, 1) = oeOrdenCompra.Glosa.Trim.ToUpper
            '--------------------------------------------------------------------------------
            'Mostramos el documento en pantalla
            objXls.ActiveWindow.Zoom = 100
            objXls.ActiveWindow.DisplayGridlines = False
            objXls.Sheets.Item(1).Select()
            'objXls.Visible = True 'Permite visualizar el excel.

            '----------------------Envio de correo-------------------------------------------

            ' Proteger con password la hoja de calculo para que no se pueda editar. 
            'objWorkSheet.Protect(gs_claveExcel, True, True, True, True)
            'System.IO.File.SetAttributes(PathFilePTRA, IO.FileAttributes.ReadOnly)
            objXls.Visible = True
            ''If Not enviarCorreo Then
            ''    objXls.Visible = True 'Permite visualizar el excel.
            ''Else

            ''    'C:\Documents and Settings\Administrator\Mis documentos\               
            ''    Dim rutaExtOf2003 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xls"
            ''    Dim rutaExtOf2007 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xlsx"
            ''    If System.IO.File.Exists(rutaExtOf2003) Then
            ''        System.IO.File.Delete(rutaExtOf2003)
            ''    End If
            ''    If System.IO.File.Exists(rutaExtOf2007) Then
            ''        System.IO.File.Delete(rutaExtOf2007)
            ''    End If
            ''    objWorkbook.Save()
            ''    rutaDocumento = objWorkbook.Path & "\" & objWorkbook.Name
            ''    objXls.ActiveWorkbook.Close(SaveChanges:=False)
            ''    objXls.Workbooks.Close()
            ''    objXls.DisplayAlerts = False
            ''    objXls.Quit()

            ''    'Dim ms_CodEmpres As String = "" '"1234562"
            ''    'Dim correoTrabajador As String = ""
            ''    'Dim correoProveedor As String = ""
            ''    'If goeUsuario.leEmail.Count > 0 Then correoTrabajador = goeUsuario.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quiem lo envia                
            ''    'If oeProveedor.leEmail.Count > 0 Then correoProveedor = oeProveedor.leEmail.Item(0).Nombre 'Para quien va dirigido                
            ''    'Dim formulario As frm_EnvioCorreo
            ''    'formulario = frm_EnvioCorreo
            ''    'If formulario.ObtenerDatos(ms_CodEmpres, rutaDocumento, correoTrabajador, True, True, True, True, _
            ''    '     correoProveedor.Trim, "Por favor atender la orden de compra en los tiempos establecidos") Then

            ''    '    formulario.ShowDialog()
            ''    '    ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)

            ''    'End If
            ''    'objXls.ActiveSheet.PrintOut(Copies:=1, Collate:=True)
            ''End If
            '--------------------------------------------------------------------------------
            If Not (objWorkSheet Is Nothing) Then
                Marshal.ReleaseComObject(objWorkSheet)
            End If
            If Not (objWorkbook Is Nothing) Then
                Marshal.ReleaseComObject(objWorkbook)
            End If
            If Not (objXls Is Nothing) Then
                Marshal.ReleaseComObject(objXls)
            End If
            objWorkSheet = Nothing
            objWorkbook = Nothing
            objXls = Nothing
            System.Threading.Thread.CurrentThread.CurrentCulture = OldCultureInfo
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub ValidaFichaDetalleOrden()
        ficDetalle.Tabs(0).Selected = 1
        btnAtenderOC.Visible = 0
        MenuContextual1.Items("AtenderToolStripMenuItem").Visible = 0
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompra = New e_OrdenCompra
            ValidarFechaDesde_Hasta(FechaDesde, FechaHasta)
            oeOrdenCompra.Activo = Activo
            oeOrdenCompra.IdMoneda = cboMonedaL.Value
            oeOrdenCompra.IdProveedor = cboProveedorL.Value
            oeOrdenCompra.IdEstadoOrden = cboEstadoOrden.Value
            oeOrdenCompra.IdTipoOrdenCompra = "1PK000000003"
            oeFecha = New e_Fechas
            If rdbDatosAdicionales.Checked Then
                oeFecha.OpcionFecha = cboFormaBusqueda.Value
                oeFecha.FechaInicio = FechaDesde.Value  'PrimerDiaMes()  '"01" & "/" & Date.Now.Month & "/" & Date.Now.Year
                oeFecha.FechaFin = FechaHasta.Value
            Else
                If txtNroOrdenCompra.Text = String.Empty Then
                    Throw New Exception("Escriba el Nro de Orden.")
                End If
                oeOrdenCompra.NroOrden = txtNroOrdenCompra.Value
            End If

            oeOrdenCompra.TipoOperacion = "1"

            With griListaOrdenCompra
                .DataSource = olOrdenCompra.Listar(oeOrdenCompra, oeFecha)
                agrOrdenCompra.Text = "Ordenes de Compra : " & .Rows.Count
                'Ordena la grilla por el número de orden de la Orden de compra en forma descendente - última orden de compra al inicio 
                '.DisplayLayout.Bands(0).Columns("NroOrden").SortIndicator = SortOrder.Descending

                'Cofigura la grilla para que se seleccione la fila completa al hacer click en algun lado
                .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

            End With

            'Colorea la grilla de acuerdo a los estados
            For Each fila As UltraGridRow In griListaOrdenCompra.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "EVALUADA"
                        fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                    Case "ATENDIDO PARCIALMENTE"
                        fila.CellAppearance.BackColor = Me.ColoresAtendidoParcialmente.Color
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.ColoresAtendido.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresTerminado.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
            Next
            With griListaOrdenCompra
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub obtenerCantidadTotalAtender(ByVal oeReqMat As e_OrdenCompraMaterial)
        cantTotalAtender += oeReqMat.CantidadMaterialAAtender
    End Sub

    Public Function GuardarOrdenCompra() As Boolean
        Try
            ObtenerDatosControles()
            If chkGenComprobante.Checked Then
                'If oeMovimientoDocumento.IdTipoDocumento = "1CH000000043" Then
                '    If udtFechaEmision.Value.Date >= Date.Parse("01/08/2014") Then ObtenerAportes()
                'End If
                gfc_ValidarSerieDoc(txtSerie.Text, oeProDoc.CodigoTD)
                gfc_ValidarNumeroDoc(txtNroComprabante.Text, oeProDoc.CodigoTD)
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                olmovimientoDocumento.Guardar(oeMovimientoDocumento)

                If oeMovimientoDocumento.IdTipoDocumento = "1CH000000043" Then
                    MessageBox.Show("Para enviar RH debe hacerlo desde el modulo Recibo por honorario.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If MessageBox.Show("¿Desea Enviar a Tesoreria el Documento?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        EnviaATesoreria(False)
                    End If
                End If
                oeOrdenCompra.IdEstadoOrden = "1CH000000003" 'Estado Terminada
            End If
            If oeOrdenCompra.TipoOperacion = "1" Then
                Dim oeOrdCmpCot As New e_OrdenCmpCotizacion
                Dim olOrdCmpCot As New l_OrdenCmpCotizacion
                oeOrdCmpCot.IdOrdenCompra = oeOrdenCompra.Id
                oeOrdCmpCot = olOrdCmpCot.Obtener(oeOrdCmpCot)
                oeOrdenCompra.oeOrdCmpCot = New e_OrdenCmpCotizacion
                oeOrdenCompra.oeOrdCmpCot = oeOrdCmpCot
                If oeOrdenCompra.oeOrdCmpCot.IdCotizacion <> "" Then
                    CrearOTExterna()
                End If
            End If
            oeOrdenCompra.TipoBien = "SERVICIO"
            oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olOrdenCompra.Guardar(oeOrdenCompra) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Sub ObtenerAportes()
    '    Try
    '        oeEmpresaAporte = New e_EmpresaAportacion
    '        oeEmpresaAporte.IdEmpresa = oeOrdenCompra.IdProveedor
    '        oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        If oeEmpresaAporte.Id = "" Then
    '            Dim frm As New frm_EmpresaAportacion
    '            frm.IdEmpresa = oeOrdenCompra.IdProveedor
    '            frm.ShowDialog()
    '            ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)
    '            oeEmpresaAporte = New e_EmpresaAportacion
    '            oeEmpresaAporte.IdEmpresa = oeOrdenCompra.IdProveedor
    '            oeEmpresaAporte = olEmpresaAporte.Obtener(oeEmpresaAporte)
    '        End If
    '        If oeEmpresaAporte.Id = "" Then Throw New Exception("Tiene Que Registrar los Datos de AFP del Proveedor")
    '        Dim loHistorialRH As New List(Of e_Combo)
    '        loHistorialRH.AddRange(ListaRH(oeEmpresaAporte.IdEmpresa, udtFechaEmision.Value))
    '        If oeEmpresaAporte.FechaNacimiento.Date >= Date.Parse("01/08/1973") Then
    '            Dim Total As Double = 0
    '            Total = loHistorialRH.Sum(Function(i) i.Descripcion) + oeOrdenCompra.Total
    '            If Total >= 750 Then
    '                If loHistorialRH.Count > 0 Then
    '                    If MessageBox.Show("No Puede Ingresar el Documento, MontoSuperado. Desea ver el Detalle?", "Mensaje de Sistema", _
    '                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                        Dim frm As New frm_DetalleCajaExterna
    '                        frm.MostrarDetalle("3", Nothing, Nothing, Nothing, loHistorialRH)
    '                        frm.ShowDialog()
    '                    End If
    '                End If
    '                Throw New Exception("No puede Ingresar RH se ha Superado el Monto sin Retencion ")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub ObtenerDatosControles()
        Try
            With oeOrdenCompra
                .Activo = True
                .UsuarioCreacion = gUsuarioSGI.Id
                .IdTrabajador = gUsuarioSGI.IdTrabajador
                .IdEstadoOrden = _IdEstadoOrden
                .IdProveedor = cboProveedor.Value
                .SubTotal = txtSubTotal.Value
                .Impuesto = txtIGV.Value
                .Total = txtTotal.Value
                .IdTipoOrdenCompra = cboTipoOrdenCompra.Value
                .FechaOrden = fecFechaActual.Value
                .FechaEntrega = fecFechaEntrega.Value
                .FechaPago = fecFechaPago.Value
                .IndicadorAprobacion = 1
                .IdCentro = cboCentro.Value
                .IdTipoPago = cboTipoPago.Value
                .IdMoneda = cboMoneda.Value
                .Glosa = IIf(txtObservaciones.Value Is Nothing, "", txtObservaciones.Value).ToString
                .Notas = IIf(txtNotas.Value Is Nothing, "", txtNotas.Value).ToString
                .IndicadorConsignacion = IIf(Operacion = "RegistrarOCporOS", 1, 0)
                .PercepcionPorc = DecPorcentajePercepcion.Value
                .Percepcion = DecPercepcion.Value
                .Detraccion = DecMontoDetraccion.Value
                .DetraccionPorc = DecDetraer.Value
                .TipoBien = TipoOC
                .lstOrdenServicio = llOrdenCompraServicio
                If chkGenComprobante.Checked Then r_CargarDocumento()
                .OrdenAprobacion = New e_OrdenAprobacion
                If .TipoOperacion = "1" Then
                    .OrdenAprobacion.IndBloqueo = chkBloquea.Checked
                    .OrdenAprobacion.Id = ls_IdOrdenAprobacion
                    .OrdenAprobacion.IdOrden = ""
                    .OrdenAprobacion.FechaAprobacion = Date.Now
                    .OrdenAprobacion.IndAprobacion = 1
                    .OrdenAprobacion.Activo = 1
                    .OrdenAprobacion.IdTrabajador = gUsuarioSGI.IdTrabajador
                    .OrdenAprobacion.UsuarioCreacion = gUsuarioSGI.Id
                End If

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CrearOTExterna()
        Try
            Dim FechaOT As Date = ObtenerFechaServidor()
            oeOrdenTrabajo = New e_OrdenTrabajo
            With oeOrdenTrabajo
                .TipoOperacion = "I"
                .IdEstadoOT = "1CH000000001"
                .IndicadorTipo = "E"
                .FechaProgramacionIni = FechaOT
                .FechaIngresoTaller = FechaOT
                .FechaInicioTrabajo = FechaOT
                .FechaFinTrabajo = FechaOT
                .FechaTentativaSalida = FechaOT
                .Glosa = "OT GENERADA DESDE OC Nro: " & oeOrdenCompra.NroOrden
                .Auxilio = 0
                .IdJefeTaller = ""
                .IdSupervisorMant = ""
                .IdEmpresaExterna = oeOrdenCompra.IdProveedor
                .UsuarioCreacion = gUsuarioSGI.Id
                .Siniestro = 0
                .UsuarioTermina = ""
                .TipoOrden = "1"
                Dim oeMantenimientoEquipo As New e_MantenimientoEquipo
                oeMantenimientoEquipo = ValidarMantenimientoEquipo(oeOrdenCompra.oeOrdCmpCot.IdEquipo, "1CH000000048")
                If oeMantenimientoEquipo.Id <> "" Then
                    Dim oeDetalleManEqui As New e_OrdenTrabajo_MantenimientoEquipo
                    oeDetalleManEqui.IdMantenimientoEquipo = oeMantenimientoEquipo.Id
                    oeDetalleManEqui.Odometro = oeOrdenCompra.oeOrdCmpCot.Orometro
                    oeDetalleManEqui.IdTrabajadorResponsable = ""
                    oeDetalleManEqui.UsuarioCreacion = gUsuarioSGI.Id
                    oeDetalleManEqui.Activo = True
                    oeDetalleManEqui.PrefijoID = gs_PrefijoIdSucursal '@0001
                    .lstDetalleEquipoMantenimiento.Add(oeDetalleManEqui)
                Else
                    Throw New Exception("No existe el Mantenimiento del Equipo. Comunicarse con Mantenimiento.")
                End If
                Dim oeOrdenTrabajoServicio As New e_OrdenTrabajo_Servicio
                For Each ordser As e_OrdenCompraServicio In llOrdenCompraServicio
                    oeOrdenTrabajoServicio = New e_OrdenTrabajo_Servicio
                    With oeOrdenTrabajoServicio
                        .IdServicio = ordser.IdServicio
                        .IdMantenimientoEquipo = oeMantenimientoEquipo.Id
                        .Cantidad = 1
                        If oeOrdenCompra.IdMoneda = "1CH01" Then
                            .Costo = ordser.PrecioUnitarioSinImp
                            .CostoDolares = .Costo / txtTC.Value
                        Else
                            .Costo = ordser.PrecioUnitarioSinImp * txtTC.Value
                            .CostoDolares = ordser.PrecioUnitarioSinImp
                        End If
                        .Descripcion = ordser.Glosa
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    .lstDetalleServicio.Add(oeOrdenTrabajoServicio)
                Next
            End With
            oeOrdenTrabajo.PrefijoID = gs_PrefijoIdSucursal '@0001
            oeOrdenCompra.oeOrdenTrabajo = oeOrdenTrabajo
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub r_CargarDocumento()
        Try
            If cboMoneda.Value = "1CH01" And (txtTC.Value = 0) Then
                Throw New Exception("Ingresar Tipo de Cambio")
            End If
            'Carga Detalle Documento
            lstaDetalleDoc = New List(Of e_DetalleDocumento)

            Dim oeEquipo As New e_Equipo
            Dim olEquipo As New l_Equipo
            Dim LstEquipo As New List(Of e_Equipo)
            oeEquipo.Activo = True
            LstEquipo = olEquipo.Listar(oeEquipo)

            For Each oeDetalle As e_OrdenCompraServicio In llOrdenCompraServicio
                oeDetalleDoc = New e_DetalleDocumento
                With oeDetalleDoc
                    .TipoOperacion = "I"
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .IndGravado = True
                    .Activo = True
                    .IdUnidadMedida = "1PY000000011"
                    .IdMaterialServicio = oeDetalle.IdServicio
                    .CodigoMaterialServicio = oeDetalle.CodigoServicio
                    .IndServicioMaterial = "S"
                    .NombreMaterialServicio = oeDetalle.Servicio
                    .Cantidad = oeDetalle.Cantidad
                    .Precio = Math.Round(oeDetalle.PrecioUnitarioConImp, 4)
                    .PrecioUnitarioSinImp = Math.Round(oeDetalle.PrecioUnitarioSinImp, 4)
                    .IndGravado = oeDetalle.IndicadorIgv
                    .Igv = oeDetalle.PrecioUnitarioConImp - oeDetalle.PrecioUnitarioSinImp
                    .Subtotal = Math.Round(.PrecioUnitarioSinImp * .Cantidad, 4)
                    Dim IdEquipo As String = oeDetalle.IdEquipo
                    If LstEquipo.Where(Function(i) i.Id = IdEquipo).Count = 0 Then
                        .IdVehiculo = ""
                    Else
                        .IdVehiculo = LstEquipo.Where(Function(i) i.Id = IdEquipo)(0).IdVehiculo
                    End If
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                lstaDetalleDoc.Add(oeDetalleDoc)
            Next
            lstaOrden.Clear()
            Dim oOrden As New e_Orden
            With oOrden
                .Activo = True
                .Id = oeOrdenCompra.Id
                .IdTipoOrden = "1CH000000006"
                .NombreProveedor = oeOrdenCompra.NombreProveedor
            End With
            lstaOrden.Add(oOrden)
            'Carga MovimientoDocumento
            oeMovimientoDocumento = New e_MovimientoDocumento
            With oeMovimientoDocumento
                .TipoOperacion = "I"
                .IdTipoDocumento = cmbTipoDocumento.Value
                .NombreDocumento = cmbTipoDocumento.Text
                .IndServicioMaterial = "S"
                l_FuncionesGenerales.ValidarCampoNoNulo(txtSerie.Value, "Ingrese la Serie")
                l_FuncionesGenerales.ValidarCampoNoNulo(txtNroComprabante.Value, "Ingrese el Número")
                .Serie = FormatoDocumento(txtSerie.Value, 4)
                .Numero = FormatoDocumento(txtNroComprabante.Value, 10)
                .Activo = True
                .IdUsuarioCrea = gUsuarioSGI.Id
                .IdClienteProveedor = cboProveedor.Value
                .IdTipoPago = cboTipoPago.Value
                .FechaEmision = udtFechaEmision.Value
                .TipoCambio = TipoCambio(.FechaEmision, True)(0)
                Dim oe As New e_TipoPago
                oe = cboTipoPago.Items(cboTipoPago.SelectedIndex).ListObject
                .FechaVencimiento = .FechaEmision.AddDays(oe.Dias)
                .FechaCreacion = udtFechaEmision.Value
                .IdEstadoDocumento = "1CH00014" 'Generada
                .IndCompraVenta = 1 '1:Factura por compras
                .IdMoneda = cboMoneda.Value
                .SubTotal = txtSubTotal.Value
                .Total = txtTotal.Value
                .Saldo = .Total
                .IGV = txtIGV.Value
                ValidaTDoc(oeMovimientoDocumento)
                ._Operador = 1
                .Mac_PC_Local = MacPCLocal()
                .lstDetalleDocumento = lstaDetalleDoc
                .LstOrden = lstaOrden
                .CobraCajaChica = IIf(chkCajaChica.Checked, 1, 0)
                .Compra.PercepcionPorc = DecPorcentajePercepcion.Value
                .Compra.Percepcion = DecPercepcion.Value
                .Compra.Detraccion = DecMontoDetraccion.Value
                .Compra.DetraccionPorc = DecDetraer.Value
                .Compra.Igv1 = IIf(cboMoneda.Value = "1CH01", txtIGV.Value, txtIGV.Value * txtTC.Value)
                .Compra.Base1 = IIf(cboMoneda.Value = "1CH01", IIf(txtIGV.Value = 0, 0, txtSubTotal.Value), _
                IIf(txtIGV.Value = 0, 0, txtSubTotal.Value) * txtTC.Value) 'Monto total de la factura sin IGV.
                .Compra.TipoOperacion = .TipoOperacion
                .Compra.IdTipoPago = cboTipoPago.Value
                .Compra.OtrosTributos = IIf(cboMoneda.Value = "1CH01", DecTPagar.Value, DecTPagar.Value * txtTC.Value)
                .Compra.NoGravadas = IIf(cboMoneda.Value = "1CH01", IIf(txtIGV.Value <> 0, 0, txtSubTotal.Value), _
                                         IIf(txtIGV.Value <> 0, 0, txtSubTotal.Value) * txtTC.Value)
                .Compra.CobraCajaChica = IIf(chkCajaChica.Checked, 1, 0)
                .PrefijoID = gs_PrefijoIdSucursal '@0001
                .Compra.PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarMantenimientoEquipo(IdEquipo As String, IdMantenimiento As String) As e_MantenimientoEquipo
        Try
            Dim oeMantenimientoEquipo As New e_MantenimientoEquipo
            Dim olMantenimientoEquipo As New l_MantenimientoEquipo
            oeMantenimientoEquipo.IdEquipo = IdEquipo
            oeMantenimientoEquipo.IdMantenimiento = IdMantenimiento
            Return olMantenimientoEquipo.Obtener(oeMantenimientoEquipo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub LlenaCombos()
        Try
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            oeTipoOrdenCompra.Activo = True
            LlenarComboMaestro(cboTipoOrdenCompra, olTipoOrdenCompra.Listar(oeTipoOrdenCompra), 0)

            ControlaBarraOperacionesDetalle("Visibilidad", 1, 1, 0, 0, 0, 0, 0)

            'oeTipoPago.Id = "CERO"
            'oeTipoPago.Nombre = "TODOS"
            'llTipoPago.Add(oeTipoPago)
            'oeTipoPago = New e_TipoPago
            'oeTipoPago.Activo = True
            'llTipoPago.AddRange(olTipoPago.Listar(oeTipoPago))
            'LlenarComboMaestro(cboTipoPagoL, llTipoPago, 0)

            oeTipoPago.Activo = True
            LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)

            oeCentro = New e_Centro
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
            cboCentro.Value = ObtenerCentro.Id
            cboCentro.Enabled = False

            lstProveedor = New List(Of e_Proveedor)
            oeProveedor.Activo = True
            lstProveedor = olProveedor.Listar(oeProveedor)
            cboProveedor.DataSource = lstProveedor

            cboProveedorL.Text = String.Empty
            cboProveedorL.DataSource = Nothing

            oeProveedor = New e_Proveedor
            llProveedores = New List(Of e_Proveedor)
            oeProveedor.Id = "CERO"
            oeProveedor.Nombre = "TODOS"
            llProveedores.Add(oeProveedor)
            cboProveedor.DropDownStyle = DropDownStyle.DropDown
            cboProveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            llProveedores.AddRange(lstProveedor)

            oeMoneda.Id = "CERO"
            oeMoneda.Nombre = "TODOS"
            llMoneda.Add(oeMoneda)
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            llMoneda.AddRange(olMoneda.Listar(oeMoneda))
            LlenarComboMaestro(cboMonedaL, llMoneda, 0)

            oeEstado.Id = "CERO"
            oeEstado.Nombre = "TODOS"
            llEstado.Add(oeEstado)
            oeEstado = New e_EstadoOrden
            oeEstado.Activo = True
            oeEstado.TipoOperacion = "2"
            llEstado.AddRange(olEstado.Listar(oeEstado))
            LlenarComboMaestro(cboEstadoOrden, llEstado, 3)
            cboEstadoOrden.SelectedIndex = 0

            oeProDoc = New e_ProcesoTipoDocumento
            oeProDoc.TipoOperacion = 1
            oeProDoc.IdTipoDocumento = oeTipoDocumento.Id
            oeProDoc.IdProceso = r_ObtenerProceso("OC SERVICIO")
            LlenarCombo(cmbTipoDocumento, "TipoDocumento", olProDoc.Listar(oeProDoc), -1)
            '---
            LlenaComboCategoriaServicios()
            mt_CargarCtaContable(ObtenerFechaServidor().Year)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Function r_ObtenerProceso(ByVal ls_Proceso As String) As String
        Try
            oeProceso = New e_ProcesoNegocio
            oeProceso.Nombre = ls_Proceso.Trim
            oeProceso = olProceso.Obtener(oeProceso)
            Return oeProceso.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub llenaGrillaReqSer(ByVal Activo As Boolean)
        Try
            oeRequerimientoServicio = New e_RequerimientoServicio
            oeRequerimientoServicio.Tipooperacion = "2"
            oeRequerimientoServicio.Activo = Activo
            llRequerimientoServicio = olRequerimientoServicio.Listar(oeRequerimientoServicio)
            '--------------------------------------------------------------------------------------------------------------            
            With griListaServiciosRequeridos
                .DataSource = llRequerimientoServicio
                'agrOrdenCompra.Text = "Materiales requeridos : " & llRequerimientoMaterial.Count
                .DisplayLayout.Bands(0).Columns("IdMantenimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Mantenimiento").Hidden = True
            End With
            'spcDetalleOrdenCompra.Panel2Collapsed = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ConsultarDetalle(ByVal estadoPanel As Boolean)
        gbeListadoServicios.Expanded = estadoPanel
        cboCategoriaServicios.SelectedIndex = 0
        llenaGrillaReqSer(True)
        ficDetalle.Tabs(0).Visible = True
    End Sub

    Private Sub controlaColumnasGriDetOC(ByVal cellClickActionCant As Integer, ByVal valorCantAtenderHidden As Boolean, ByVal valorCantPendienteHidden As Boolean, _
                                         ByVal valorVisLis As Boolean, ByVal cellClickAction As Integer, Optional ByVal pendienteEditable As Integer = 0)
        gbeListadoServicios.Visible = valorVisLis
    End Sub

    Sub QuitarDetalle()
        gbeListadoServicios.Expanded = True
        llOrdenCompraServicio.RemoveAll(AddressOf verificarSeleccionadoServicio)
        griListaServiciosRequeridos.DataBind()
        griListaServicios.DataBind()
        griListaDetalleOrdenCompraServicio.DataBind()
        CalcularSubtotalesTotalesServicio()
    End Sub

    Private Function verificarSeleccionadoServicio(ByVal oeOrdComp As e_OrdenCompraServicio) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeOrdComp.IdRequerimientoServicio) Or _
               Not String.IsNullOrEmpty(oeOrdComp.IdServicio) Then
                If oeOrdComp.Seleccion Then
                    Select Case oeOrdComp.TipoOrdenCompra
                        Case "RS"
                            Dim oeRequerimientoServicio As New e_RequerimientoServicio
                            oeRequerimientoServicio.Id = oeOrdComp.IdRequerimientoServicio
                            oeRequerimientoServicio.Tipooperacion = "2"
                            oeRequerimientoServicio.Activo = True
                            oeRequerimientoServicio = olRequerimientoServicio.Obtener(oeRequerimientoServicio)
                            llRequerimientoServicio.Add(oeRequerimientoServicio)
                            utcListadosServicios.Tabs(0).Selected = True
                        Case "S"
                            Dim oeServicio As New e_Servicio
                            oeServicio.Id = oeOrdComp.IdServicio
                            oeServicio.TipoOperacion = "S"
                            oeServicio.Activo = True
                            oeServicio = olServicio.Obtener(oeServicio)
                            'llServicio.Add(oeServicio)
                            utcListadosServicios.Tabs(1).Selected = True
                        Case "C"

                    End Select
                End If
            End If
            Return oeOrdComp.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Private Sub AsignarRequerimientoServicioOrdenCompra()
        Dim oeOrdTra As New e_OrdenTrabajo
        Dim olOrdTra As New l_OrdenTrabajo
        For Each oeReqSer As e_RequerimientoServicio In llRequerimientoServicio.Where(Function(item) item.Seleccion)
            oeOrdenCompraServicio = New e_OrdenCompraServicio()
            With oeOrdenCompraServicio
                .CodigoRequerimiento = oeReqSer.CodigoRequerimiento
                .Seleccion = False 'llMaterial.Item(i).Seleccion
                .IndicadorIgv = True
                .Activo = True
                .IdRequerimientoServicio = oeReqSer.Id ' Asigno id de reqServicio en id de ReqMaterial
                .IdServicio = oeReqSer.IdServicio ' Asigno id de servicio en id de material
                .CodigoServicio = oeReqSer.CodigoServicio ' Asigno codigo de servicio en codigo de material
                .Cantidad = oeReqSer.Cantidad ' Asigno cantidad de servicio en cantidad de material 
                .Servicio = oeReqSer.Servicio ' Asigno nombre del servicio en nombre del material                
                .IdArea = oeReqSer.IdArea
                .Area = oeReqSer.Area
                .Glosa = oeReqSer.Glosa
                .IdCentroCosto = oeReqSer.IdCentroCosto
                .PrecioUnitarioConImp = oeReqSer.Precio
                .PrecioUnitarioSinImp = Math.Round(oeReqSer.Precio / (1 + oeIGVGlobal.Porcentaje), 4)
                '.PrecioUnitarioSolesSinImp = .PrecioUnitarioSinImp
                '.PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                .TipoOrdenCompra = "RS"
                .IdEquipo = oeReqSer.IdEquipo
                cont = MaximaPosicionServicio() : cont += 1 : .Pos = cont
                txtObservaciones.Text = oeReqSer.Glosa
                cboProveedor.Value = Nothing
                oeOrdTra.NroOT = oeReqSer.NroOT
                oeOrdTra = olOrdTra.Obtener(oeOrdTra)
                cboProveedor.Value = oeOrdTra.IdEmpresaExterna
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraServicio.Add(oeOrdenCompraServicio)
        Next
        CalcularSubtotalesTotalesServicio() 'CalcularSubtotalesTotalesMaterial
        griListaDetalleOrdenCompraServicio.DataBind()
        llRequerimientoServicio.RemoveAll(AddressOf eliminaRequerimientoServicio)
        griListaServiciosRequeridos.DataBind()
    End Sub

    Public Sub CalcularSubtotalesTotalesServicio()
        Dim Igv As Double = 0
        totalSinIgv = 0
        totalConIgv = 0
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        If llOrdenCompraServicio.Count > 0 Then
            For Each oeDetalleOC As e_OrdenCompraServicio In llOrdenCompraServicio
                If oeDetalleOC.IndicadorIgv Then
                    oeDetalleOC.Importe = Math.Round(oeDetalleOC.Cantidad * oeDetalleOC.PrecioUnitarioConImp, 4)
                    oeDetalleOC.ValorVenta = Math.Round(oeDetalleOC.Cantidad * oeDetalleOC.PrecioUnitarioSinImp, 4)
                    Igv = Math.Round(oeDetalleOC.ValorVenta * ObtenerIGV(fecFechaActual.Value), 4)
                Else
                    oeDetalleOC.Importe = Math.Round(oeDetalleOC.Cantidad * oeDetalleOC.PrecioUnitarioConImp, 4)
                    oeDetalleOC.ValorVenta = Math.Round(oeDetalleOC.Cantidad * oeDetalleOC.PrecioUnitarioSinImp, 4)
                    Igv = 0
                End If
                totalSinIgv += oeDetalleOC.ValorVenta
                totalConIgv += oeDetalleOC.Importe
            Next
            txtSubTotal.Value = totalSinIgv
            txtIGV.Value = totalConIgv - totalSinIgv
            txtTotal.Value = totalConIgv
        End If

    End Sub

    Private Sub AsignarServicio()
        'recalcularIgvETotales()
        For Each oeSer As e_Servicio In llServicio.Where(Function(item) item.Seleccion)
            oeOrdenCompraServicio = New e_OrdenCompraServicio()
            With oeOrdenCompraServicio
                .IdRequerimientoServicio = "" 'oeReqMat.Id
                .CodigoRequerimiento = "" 'oeReqMat.CodigoRequerimiento
                .Seleccion = False 'llMaterial.Item(i).Seleccion
                .IndicadorIgv = True
                .Activo = True
                .IdServicio = oeSer.Id
                .CodigoServicio = oeSer.Codigo
                .Cantidad = 1
                .Servicio = oeSer.Nombre
                .IdArea = gUsuarioSGI.oeArea.Id
                .Area = gUsuarioSGI.oeArea.Nombre
                .PrecioUnitarioConImp = oeSer.Precio
                .PrecioUnitarioSinImp = Math.Round(oeSer.Precio / (1 + ObtenerIGV(fecFechaActual.Value)), 4)
                '.PrecioUnitarioSolesSinImp = .PrecioUnitarioSinImp
                '.PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                .TipoOrdenCompra = "S"
                cont = MaximaPosicionServicio() : cont += 1 : .Pos = cont
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraServicio.Add(oeOrdenCompraServicio)
            oeSer.Seleccion = False
        Next

        CalcularSubtotalesTotalesServicio()
        griListaDetalleOrdenCompraServicio.DataBind()
        'llServicio.RemoveAll(AddressOf eliminaServicio)
        griListaServicios.DataBind()

    End Sub

    Private Function eliminaRequerimientoMaterial(ByVal oeReqMat As e_RequerimientoMaterial) As Boolean
        Return oeReqMat.Seleccion
    End Function

    Private Function eliminaRequerimientoServicio(ByVal oeReqSer As e_RequerimientoServicio) As Boolean
        Return oeReqSer.Seleccion
    End Function

    Private Function eliminaMaterial(ByVal oeMat As e_Material) As Boolean
        Return oeMat.Seleccion
    End Function

    Private Function eliminaServicio(ByVal oeSer As e_Servicio) As Boolean
        Return oeSer.Seleccion
    End Function

    Private Function eliminaCotizaciones(ByVal oeCot As e_CotizacionDetalleMat) As Boolean
        Return oeCot.Seleccion
    End Function

    Public Sub ListarServicios(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            oeServicio.TipoOperacion = "S"
            oeServicio.Activo = Activo
            oeServicio.IdCategoriaServicio = IIf(cboCategoriaServicios.Value = "CERO", "", cboCategoriaServicios.Value)
            llServicio = olServicio.Listar(oeServicio)
            '--------------------------------------------------------------------------------------------------------------            
            griListaServicios.DataSource = llServicio
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub LlenaComboCategoriaServicios()
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

    Public Sub VerificarPermiso()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "APROBAR ORDENES DE COMPRA") Then
                AprobarOrdenesCompra()
            Else
                Throw New Exception("No Tiene Permiso para Aprobar Ordenes de Compra")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub AprobarOrdenesCompra()
        Try
            Editar()
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
            lbl_etiqueta.Text = "Aprobando OC"
            lbl_etiqueta.Visible = 1
            Me.chkBloquea.Visible = 1
            Me.chkBloquea.Checked = 1
            controlaColumnasGriDetOC(0, True, True, False, 0, 3)
            oeOrdenCompra.TipoOperacion = "1"
            oeOrdenCompra.IdTrabajador = gUsuarioSGI.IdTrabajador
            _IdEstadoOrden = "1CH000000011"
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub AtenderOrdenesCompra()
        Try
            lbl_etiqueta.Text = "Atendiendo OC"
            lbl_etiqueta.Visible = 1
            'InicializarListasOrdenIngreso()
            controlaColumnasGriDetOC(0, False, False, False, 0)
            'MostrarTabs(0, 'ficDetalleOCMateriales, 1)
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 1, 0, 0, 1)
            MostrarTabs(0, FichaTop, 1)
            Operacion = "Editar"
            If EditarOrdenCompra() Then
                oeOrdenCompra.TipoOperacion = "3"
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub RechazarOrdenCompra()
        Dim formulario As New frm_RechazarOrdenCompra
        Dim idOrdCom As String = griListaOrdenCompra.ActiveRow.Cells("Id").Value.ToString
        'formulario.Listar(idOrdCom)
        formulario.ShowDialog()
    End Sub

    Public Sub ControlarEstadoOrden()
        btnAtenderOC.Enabled = 0 : btnAprobar.Enabled = 0 : btnHistorial.Enabled = 0 : btnBloquear.Enabled = 0 : btnCambiarEstado.Enabled = 0
        If griListaOrdenCompra.ActiveRow.Index > -1 Then
            Select Case griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value
                Case gNombreEstadoOrdenGenerada
                    btnAprobar.Enabled = 1
                Case "EVALUADA", "ATENDIDO PARCIALMENTE"
                    If griListaOrdenCompra.ActiveRow.Cells("NombreSubEstado").Value = "APROBADA" Then
                        btnAtenderOC.Enabled = IIf(griListaOrdenCompra.ActiveRow.Cells("IndicadorConsignacion").Value, 0, 1)
                    End If
                    If griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoOrdenEvaluada Then
                        btnCambiarEstado.Enabled = 1
                    End If
            End Select
        End If
    End Sub

    Public Sub InicializaOrdenesOCporOS()

        oeOrdenCompra.TipoOperacion = "I"
        TipoOC = "MATERIAL"
        Operacion = "RegistrarOCporOS"
        controlaColumnasGriDetOC(4, True, True, False, 4)
        MostrarTabs(1, ficOrdenCompra, 1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        ficDetalle.Tabs(0).Selected = True
        ficDetalle.Tabs(0).Enabled = True

        ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)

    End Sub

    Public Function MaximaPosicionServicio() As Integer
        Dim mayor As Integer = 0
        Dim list As New List(Of Integer)()
        For Each detalle As e_OrdenCompraServicio In llOrdenCompraServicio
            If detalle.Pos > mayor Then mayor = detalle.Pos
        Next
        Return mayor 'llOrdenCompraMaterial.Max().Pos
    End Function

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String, ByVal grilla As ISL.Controles.Grilla)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            grilla.DisplayLayout.ValueLists.Clear()
            objValueList = grilla.DisplayLayout.ValueLists.Add("SubAlmacenes")
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.TipoOperacion = "S"
            oeSubAlmacen.Activo = True
            oeSubAlmacen.IdAlmacen = ls_IdAlmacen
            lstSubAlmacen = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
            olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
            For Each item As e_SubAlmacen In lstSubAlmacen
                objValueList.ValueListItems.Add(item.Id, item.Descripcion)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_LimpiaComprobante()
        Me.cmbTipoDocumento.SelectedIndex = -1
        Me.udtFechaEmision.Value = Date.Now
        Me.txtSerie.Text = String.Empty
        Me.txtNroComprabante.Text = String.Empty
        Me.txtEstadoDoc.Text = String.Empty
        chkCajaChica.Checked = False
        btnEnviar.Enabled = 0
        lenSerie = 4
        txtSerie.MaxLength = lenSerie
        lenNumero = 10
        txtNroComprabante.MaxLength = lenNumero
    End Sub

    Private Sub EnviaATesoreria(Optional ByVal lb_Mostrar As Boolean = True)
        Try
            If oeMovimientoDocumento.IdTipoDocumento = "1CH000000043" Then
                MessageBox.Show("Para enviar RH debe hacerlo desde el modulo Recibo por honorario.", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            oeMovimientoDocumento.TipoOperacion = "COM"
            oeMovimientoDocumento = olmovimientoDocumento.ObtenerDocumentosPorCompras(oeMovimientoDocumento)
            Dim frm As New Frm_PeriodoTipoAsiento(True, False, False, "CMP")
            frm.ChkActivo.Visible = True
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim FechaPeriodo As Date = CDate("01/" & frm.cboMes.Text & "/" & frm.Año1.Año)
                If ValidarFechasPeriodo(oeMovimientoDocumento.FechaEmision, FechaPeriodo) Then
                    Dim oePeriodo As New e_Periodo
                    Dim olPeriodo As New l_Periodo
                    oePeriodo.Ejercicio = ObtenerFechaServidor.Year
                    oePeriodo = olPeriodo.ObtenerPeriodoVigente(oePeriodo, 3)
                    If oePeriodo.Mes <> CInt(frm.cboMes.Text) Then
                        If oeMovimientoDocumento.FechaEmision.Year <= oePeriodo.Ejercicio Then
                            If oeMovimientoDocumento.FechaEmision.Month <= oePeriodo.Mes Then
                                Throw New Exception("Periodo " & oePeriodo.Codigo & " Abierto para Logistica.")
                            End If
                        End If
                    End If
                    ' Obtiene Fecha periodo
                    Dim _oePerAux As New e_Periodo
                    _oePerAux.Id = frm.cboMes.Value : _oePerAux.Ejercicio = frm.Año1.Año
                    _oePerAux.TipoOperacion = String.Empty : _oePerAux.Activo = True
                    _oePerAux = olPeriodo.Obtener(_oePerAux)
                    oeMovimientoDocumento.FechaFinal = _oePerAux.FechaFin
                    ' ---------------------
                    oeMovimientoDocumento.IdPeriodo = frm.cboMes.Value
                    oeMovimientoDocumento.Ejercicio = frm.Año1.Año
                    oeMovimientoDocumento.IdUsuarioCrea = gUsuarioSGI.Id
                    oeTipoDocumento = New e_TipoDocumento
                    oeTipoDocumento.Id = cmbTipoDocumento.Value
                    oeTipoDocumento = olTipoDocumento.Obtener(oeTipoDocumento)
                    oeMovimientoDocumento.Compra.TipoDoc = oeTipoDocumento
                    oeMovimientoDocumento.IndOrigenContable = IIf(gUsuarioSGI.oeArea.Id = "1CH000000005", 3, IIf(gUsuarioSGI.oeArea.Id = "1CH000000016", 4, 5))
                    oeMovimientoDocumento.Tipo = IIf(frm.ChkActivo.Checked, "ACTIVO", "")
                    oeMovimientoDocumento.IndAsientoGuia = True
                    oeMovimientoDocumento.IndOrigenContable = 2
                    oeMovimientoDocumento.loCtaCtbleCSer = New List(Of e_CtaCtbleCatServicio)
                    oeMovimientoDocumento.loCtaCtbleCSer = LlenaCuentaCatServicio(oeMovimientoDocumento, loCtaCtbleCSer, oeMovimientoDocumento.Ejercicio)
                    ObtenerAsientoModelo(oeMovimientoDocumento.IdMoneda, oeMovimientoDocumento.Ejercicio)
                    oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olmovimientoDocumento.GuardarCmpServicio(oeMovimientoDocumento)
                    'olmovimientoDocumento.EnviarCompra(oeMovimientoDocumento)
                    If lb_Mostrar Then
                        mensajeEmergente.Confirmacion("Se Envió Correctamente", True)
                        Consultar(True)
                        MostrarTabs(0, ficOrdenCompra, 2)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String, ByVal ind As Boolean) As String
        Try
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            If ind Then
                Return oeInventario.ValorUnitario * (1 + ObtenerIGV(fecFechaActual.Value))
            Else
                Return oeInventario.ValorUnitario
            End If
        Catch ex As Exception
            Throw
        End Try
    End Function

    Sub r_SolesDolares()
        Try
            If txtTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
            oeMoneda = New e_Moneda
            oeMoneda.TipoOperacion = ""
            oeMoneda.Nombre = "DOLARES"
            oeMoneda = olMoneda.Obtener(oeMoneda)
            cboMoneda.Value = oeMoneda.Id
            CalcularSubtotalesTotalesServicio()
            griListaDetalleOrdenCompraServicio.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub GenerarOI()
        Try
            If oeOrdenCompra.TipoOperacion <> "3" Then
                Throw New Exception("La orden de compra no esta lista para ser atendida.")
            End If
            Guardar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Sub TransponerRegistroInv()
        For Each item As e_OrdenMaterial In oeOrdenIngreso.lstOrdenMaterial
            oeRegistroInventario = New e_RegistroInventario
            oeRegistroInventario.Id = ""
            oeRegistroInventario.IdMovimientoInventario = oeOrdenIngreso.IdMovimientoInventario 'Pendientes
            oeRegistroInventario.IdMaterial = item.IdMaterial
            oeRegistroInventario.IdUnidadMedida = item.IdUnidadMedida
            oeRegistroInventario.Cantidad = item.CantidadMaterial
            oeRegistroInventario.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
            If item.IndicadorIgv Then
                oeRegistroInventario.ValorUnitarioReal = (item.ValorVenta / (1 + ObtenerIGV(fecFechaActual.Value))) / oeRegistroInventario.CantidadReal
                oeRegistroInventario.ValorUnitario = (item.ValorVenta / (1 + ObtenerIGV(fecFechaActual.Value))) / oeRegistroInventario.CantidadReal
            Else
                oeRegistroInventario.ValorUnitarioReal = item.ValorVenta / oeRegistroInventario.CantidadReal
                oeRegistroInventario.ValorUnitario = item.ValorVenta / oeRegistroInventario.CantidadReal
            End If
            oeRegistroInventario.ValorTotal = oeRegistroInventario.CantidadReal * oeRegistroInventario.ValorUnitarioReal
            oeRegistroInventario.Activo = item.Activo
            oeRegistroInventario.UsuarioCreacion = oeOrdenIngreso.UsuarioCreacion
            oeRegistroInventario.Fecha = oeOrdenIngreso.FechaOrden
            oeRegistroInventario.IdSubAlmacen = item.IdSubAlmacen  'envia almacen
            oeRegistroInventario.TipoOperacion = oeOrdenIngreso.TipoOperacion
            oeRegistroInventario.IdOrden = oeOrdenIngreso.Id
            oeRegistroInventario.PrefijoID = gs_PrefijoIdSucursal '@0001
            listaRegistroInventario.Add(oeRegistroInventario)
        Next

    End Sub

    Sub AgregarDetalle()
        Try
            gbeListadoServicios.Expanded = False
            Select Case utcListadosServicios.SelectedTab.Key
                Case 0
                    AsignarRequerimientoServicioOrdenCompra()
                Case 1
                    AsignarServicio()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarOrdenServicio()
        Try
            If oeOrdenCompra.oeOrdCmpCot.IdCotizacion = "" Then
                oeOrdenCompra.oeOrdCmpCot = New e_OrdenCmpCotizacion
                oeOrdenCompra.oeOrdCmpCot.IdCotizacion = griCotizacion.ActiveRow.Cells("Id").Value
                oeOrdenCompra.IndCotizacion = True
                oeCotizacionDetalleSer.IdCotizacionProveedor = griCotizacion.ActiveRow.Cells("Id").Value
                cboProveedor.Value = griCotizacion.ActiveRow.Cells("IdProveedor").Value
                cboMoneda.Value = griCotizacion.ActiveRow.Cells("IdMoneda").Value
                oeCotizacionDetalleSer.TipoOperacion = "2"
                llCotizacionDetalleSer = olCotizacionDetalleSer.Listar(oeCotizacionDetalleSer)
                For Each cotdetser As e_CotizacionDetalleSer In llCotizacionDetalleSer
                    oeOrdenCompraServicio = New e_OrdenCompraServicio()
                    With oeOrdenCompraServicio
                        .IdRequerimientoServicio = cotdetser.IdRequerimientoServicio
                        .CodigoRequerimiento = "" 'oeReqMat.CodigoRequerimiento
                        .Seleccion = False 'llMaterial.Item(i).Seleccion
                        .IndicadorIgv = True
                        .Activo = True
                        .IdServicio = cotdetser.IdServicio
                        .CodigoServicio = cotdetser.CodigoServicio
                        .Cantidad = 1
                        .Servicio = cotdetser.Servicio
                        .IdArea = gUsuarioSGI.oeArea.Id
                        .Area = gUsuarioSGI.oeArea.Nombre
                        .PrecioUnitarioConImp = cotdetser.Precio
                        .PrecioUnitarioSinImp = Math.Round(cotdetser.Precio / (1 + ObtenerIGV(fecFechaActual.Value)), 4)
                        .CostoUnitario = .PrecioUnitarioSinImp
                        'If cboMoneda.Text = "DOLARES" Then
                        'Else
                        '    .PrecioUnitarioSolesSinImp = .PrecioUnitarioSinImp
                        'End If
                        '.PrecioUnitarioSolesSinImp = .PrecioUnitarioSinImp
                        ' .PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                        .TipoOrdenCompra = "S"
                        cont = MaximaPosicionServicio() : cont += 1 : .Pos = cont
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    llOrdenCompraServicio.Add(oeOrdenCompraServicio)
                Next
                CalcularSubtotalesTotalesServicio()
                griListaDetalleOrdenCompraServicio.DataBind()
                griListaServicios.DataBind()
                griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("PrecioUnitarioConImp").CellClickAction = CellClickAction.RowSelect
                'griListaDetalleOrdenCompraServicio.DisplayLayout.Bands(0).Columns("IndicadorIgv").CellClickAction = CellClickAction.RowSelect
            Else
                Throw New Exception("Ya Asigno una Cotizacion a esta OC.")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarCotizaciones()
        Try
            loCotizacion = New List(Of e_Cotizacion)
            griCotizacion.DataSource = loCotizacion
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(rfFechaCotDesde, rfFechaCotHasta)
            oeCotizacion.TipoOperacion = "1"
            oeCotizacion.FechaInicio = rfFechaCotDesde.Value
            oeCotizacion.FechaFinal = rfFechaCotHasta.Value
            oeCotizacion.Activo = True
            oeCotizacion.IndMaterialServicio = "S"
            loCotizacion.AddRange(olCotizacion.Listar(oeCotizacion).OrderByDescending(Function(item) item.FechaCreacion))
            With griCotizacion
                .DataSource = loCotizacion
                If .Rows.Count > 0 Then
                    .DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ActualizarTipoPago()
        Try
            Dim oe As New e_Combo
            oe.Id = cboTipoPago.Value
            oe.Tipo = 0
            If TipoPagoPublic.Contains(oe) Then
                oe = TipoPagoPublic.Item(TipoPagoPublic.IndexOf(oe))
                fecFechaPago.Value = fecFechaEntrega.Value.AddDays(CInt(oe.Descripcion))
            Else
                Throw New Exception("No se Encuentra el Tipo de Pago. Verificar")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CambiarEstado()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "APROBAR ORDENES DE COMPRA") Then
                If griListaOrdenCompra.Selected.Rows.Count > 0 Then
                    oeOrdenCompra = New e_OrdenCompra
                    oeOrdenCompra.Id = griListaOrdenCompra.ActiveRow.Cells("Id").Value
                    oeOrdenCompra.TipoOperacion = "G"
                    oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olOrdenCompra.Guardar(oeOrdenCompra) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        Consultar(True)
                    End If
                End If
            Else
                Throw New Exception("No tiene Permiso para Cambiar Estado a la Orden de Compra")
            End If
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

#Region "Menu y tabs"

    Public Sub ControlaBarraOperacionesDetalle(ByVal tipo As String, ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean, _
                                               ByVal lb_Listar As Boolean, ByVal lb_Generar As Boolean, ByVal lb_Ejecutar As Boolean, ByVal lb_GenerarDoc As Boolean, ByVal lb_Importar As Boolean)

        o_Botonera.Guardar = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar

        o_Botonera.Listar = lb_Listar
        o_Botonera.Generar = lb_Generar
        o_Botonera.Ejecutar = lb_Ejecutar
        o_Botonera.GenerarDoc = lb_GenerarDoc
        o_Botonera.Exportar = lb_Importar

        Botones(o_Botonera, tipo)

    End Sub

    Private Sub Botones(ByVal oeBoton As e_Boton, ByVal tipo As String)
        Try
            With MenuDetalle
                If tipo = "Visibilidad" Then
                    .Tools("Agregar").SharedProps.Visible = oeBoton.Guardar
                    .Tools("Eliminar").SharedProps.Visible = oeBoton.Eliminar
                    '.Tools("Listar").SharedProps.Visible = oeBoton.Listar
                    .Tools("Generar").SharedProps.Visible = oeBoton.Generar
                    .Tools("Ejecutar").SharedProps.Visible = oeBoton.Ejecutar
                    .Tools("GenerarD").SharedProps.Visible = oeBoton.GenerarDoc
                    .Tools("Guardar").SharedProps.Visible = oeBoton.Exportar
                Else
                    .Tools("Agregar").SharedProps.Enabled = oeBoton.Guardar
                    .Tools("Eliminar").SharedProps.Enabled = oeBoton.Eliminar
                    '.Tools("Listar").SharedProps.Enabled = oeBoton.Listar
                    .Tools("Generar").SharedProps.Enabled = oeBoton.Generar
                    .Tools("Ejecutar").SharedProps.Enabled = oeBoton.Ejecutar
                    .Tools("GenerarD").SharedProps.Enabled = oeBoton.GenerarDoc
                    .Tools("Guardar").SharedProps.Enabled = oeBoton.Exportar
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                'Case "Consultar"
                '    ConsultarDetalle(False)
                Case "Agregar"
                    AgregarDetalle()
                Case "Eliminar"
                    QuitarDetalle()
                Case "Generar"
                    GenerarOI()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OrdenCompraServicio_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenCompraServicio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_OrdenCompraServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gmt_ConfigurarEventoKeyEnter_Tab(Me, cboProveedor.Name, txtNroOrdenCompra.Name, cboProveedorL.Name)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        InicializaTiempo()
        IniciarFormulario()
        MostrarTabs(0, ficOrdenCompra)
    End Sub

    Private Sub griListaDetalleOrdenCompraServicio_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleOrdenCompraServicio.CellChange
        Try
            griListaDetalleOrdenCompraServicio.UpdateData()
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message)            
        End Try
    End Sub

    Private Sub griListaServiciosRequeridos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServiciosRequeridos.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaServiciosRequeridos.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                            '.Fixed = True
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                            '.Fixed = False
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaServicios_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaServicios.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key

                Case "Seleccion"
                    With griListaServicios.Rows(e.Cell.Row.Index)

                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                            '.Fixed = True
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                            '.Fixed = False
                        End If
                    End With

            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub griListaDetalleOrdenCompraServicio_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDetalleOrdenCompraServicio.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaDetalleOrdenCompraServicio.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                            '.Fixed = True
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                            '.Fixed = False
                        End If
                    End With
                Case "IndicadorIgv"
                    With griListaDetalleOrdenCompraServicio.Rows(e.Cell.Row.Index)
                        swIgv = .Cells("IndicadorIgv").Value
                        codigoServicio = .Cells("CodigoServicio").Value
                        codigoRequerimiento = .Cells("CodigoRequerimiento").Value
                        posGrilla = .Cells("Pos").Value
                        If swIgv Then
                            .Cells("PrecioUnitarioConImp").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value * (1 + ObtenerIGV(fecFechaActual.Value)), 4)
                        Else
                            .Cells("PrecioUnitarioConImp").Value = Math.Round(.Cells("PrecioUnitarioSinImp").Value, 4)
                        End If
                        griListaDetalleOrdenCompraServicio.DataBind()
                    End With
                    CalcularSubtotalesTotalesServicio()
                Case "PrecioUnitarioConImp"
                    Dim PrecioUnitarioConImp As Double = 0
                    Dim PrecioUnitarioSinImp As Double = 0
                    With griListaDetalleOrdenCompraServicio.ActiveRow
                        swIgv = .Cells("IndicadorIgv").Value
                        If .Index > -1 Then
                            PrecioUnitarioConImp = Convert.ToDouble(.Cells("PrecioUnitarioConImp").Value)
                            If PrecioUnitarioConImp < 0 Then
                                .Cells("PrecioUnitarioConImp").Value = cantmat
                                Throw New Exception("El Precio Unitario con Impuesto no Puede ser Menor o Igual a 0.")
                            End If
                            PrecioUnitarioSinImp = IIf(swIgv, Math.Round(PrecioUnitarioConImp / (ObtenerIGV(fecFechaActual.Value) + 1), 4), Math.Round(PrecioUnitarioConImp, 4))
                            .Cells("CostoUnitario").Value = PrecioUnitarioSinImp
                            .Cells("PrecioUnitarioSinImp").Value = PrecioUnitarioSinImp
                        End If
                    End With
                    CalcularSubtotalesTotalesServicio()
                Case "Glosa"
                    If IsDBNull(e.Cell.Value) Then
                        e.Cell.Value = " "
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleOrdenCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs)
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub griListaOrdenCompra_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenCompra.DoubleClick
        If griListaOrdenCompra.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaOrdenCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaOrdenCompra.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Eliminar()
        e.Cancel = True
    End Sub

    Private Sub griListaOrdenCompra_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenCompra.AfterRowActivate
        ControlarEstadoOrden()
    End Sub

    Private Sub btnAtenderOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderOC.Click
        AtenderOrdenesCompra()
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        VerificarPermiso()
    End Sub

    Private Sub btnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoria.Click
        ListarServicios(True)
    End Sub

    Private Sub cboCategoriaServicios_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCategoriaServicios.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarServicios(True)
        End If
    End Sub

    Private Sub frm_OrdenCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
                If txtEstado.Text.Equals("EVALUADA") Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 1)
                    If chkBloquea.Checked = 0 Then ControlBoton(0, 0, 0, 1, 1, 0, 1)
                    If gUsuarioSGI.IdTrabajador = oeOrdenCompra.IdTrabajadorAprobacion Then ControlBoton(0, 0, 0, 1, 1, 0, 1)
                    If lbl_etiqueta.Visible And lbl_etiqueta.Text = "Atendiendo OC" Then
                        ControlBoton(0, 0, 0, 0, 1, 0, 1)
                    End If

                ElseIf txtEstado.Text.Contains("ATENDIDO") Or txtEstado.Text.Equals("TERMINADA") Then
                    ControlBoton(0, 0, 0, 0, 1, 0, 1)
                End If
            Case "Inicializa"
                If (griListaOrdenCompra.Rows.Count > 0) Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1)
                End If

            Case "RegistrarOCporOS" 'Registro de ordenes de compra por consignación
                InicializaOrdenesOCporOS()

        End Select
    End Sub

    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCorreo.Click
        ImprimirOrdenesCompra(True)
    End Sub

    Private Sub griListaDetalleOrdenCompraServicio_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListaDetalleOrdenCompraServicio.BeforeCellUpdate
        With griListaDetalleOrdenCompraServicio
            Select Case e.Cell.Column.Key
                Case "PrecioUnitarioConImp"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
                    cantmat = e.Cell.Value
                Case "Glosa"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        ImprimirOrdenesCompra(True)
    End Sub

    Private Sub chkGenComprobante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGenComprobante.CheckedChanged
        Try
            If chkGenComprobante.Checked Then
                If Not oeOrdenCompra.IndCotizacion Then
                    If Not txtEstado.Text.Trim.Equals("EVALUADA") Then
                        chkGenComprobante.Checked = 0
                        Throw New Exception("La Orden debe de pasar por un proceso de Evaluacion")
                    End If
                Else
                    If Not txtEstado.Text.Trim.Equals("ATENDIDO") Then
                        chkGenComprobante.Checked = 0
                        Throw New Exception("La Orden de Cotizacion debe estar Atendida")
                    End If
                End If
            End If
            agrGenerarComprabante.Enabled = IIf(chkGenComprobante.Checked, 1, 0)
            If Not chkGenComprobante.Checked Then r_LimpiaComprobante()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Validated
        Try
            If txtSerie.Text.Trim.Length > 0 Then
                txtSerie.Text = gfc_ConcatenarCeros(txtSerie.Text, lenSerie)
                'gfc_ValidarSerieDoc(txtSerie.Text, oeProDoc.CodigoTD)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroComprabante_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroComprabante.Validated
        Try
            If txtNroComprabante.Text.Trim.Length > 0 Then
                txtNroComprabante.Text = gfc_ConcatenarCeros(txtNroComprabante.Text, lenNumero)
                'gfc_ValidarNumeroDoc(txtNroComprabante.Text, oeProDoc.CodigoTD)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor, "0", chkRuc.Checked)
        End If
    End Sub

    Private Sub cbProveedor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                cboProveedor.PerformAction(UltraComboAction.Dropdown)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cbProveedor_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
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

    Private Sub cbCentro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCentro.CheckedChanged
        cboCentro.Enabled = IIf(cbCentro.Checked, 1, 0)
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

    Private Sub cheActivoPercepcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cheActivoPercepcion.CheckedChanged
        If cheActivoPercepcion.Checked Then
            Dim DecPorPer As Double = 2
            If txtTotal.Value > 0 Then
                Me.DecPorcentajePercepcion.Value = DecPorPer
            Else
                mensajeEmergente.Confirmacion("La Percepción es 0", 1)
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

    Private Sub cboTipoPago_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoPago.Validated
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmdSolesDolares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSolesDolares.Click
        r_SolesDolares()
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        If cboMoneda.Text = "DOLARES" Then
            cmdSolesDolares.Enabled = 0
        Else
            cmdSolesDolares.Enabled = 1
        End If
    End Sub

    Private Sub fecFechaActual_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaActual.Validated
        Try
            If oeOrdenCompra.TipoOperacion = "I" Then
                txtTC.Value = TipoCambio(fecFechaActual.Value)(0)
            ElseIf oeOrdenCompra.TipoOperacion = "A" Then
                If txtTC.Value = 0 Then
                    txtTC.Value = TipoCambio(fecFechaActual.Value)(0)
                Else
                    If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                    = Windows.Forms.DialogResult.Yes Then
                        txtTC.Value = TipoCambio(fecFechaActual.Value)(0)
                    End If
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboProveedorL_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedorL.InitializeLayout
        Me.cboProveedorL.ValueMember = "Id"
        Me.cboProveedorL.DisplayMember = "Nombre"
        With cboProveedorL.DisplayLayout.Bands(0)
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

    Private Sub cboProveedorL_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedorL.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarProveedores(cboProveedorL, "0", chkRuc2.Checked)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub cboProveedorL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedorL.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedorL.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Try
            EnviaATesoreria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleOrdenCompraServicio_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaDetalleOrdenCompraServicio.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaServiciosRequeridos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaServiciosRequeridos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaServicios_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaServicios.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub btnListaCoti_Click(sender As Object, e As EventArgs) Handles btnListaCoti.Click
        Try
            ListarCotizaciones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griCotizacion_DoubleClick(sender As Object, e As EventArgs) Handles griCotizacion.DoubleClick
        Try
            If griCotizacion.Selected.Rows.Count > 0 Then
                AsignarOrdenServicio()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub rdbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatosAdicionales.CheckedChanged
        Try
            If rdbDatosAdicionales.Checked Then
                Agrupacion13.Enabled = False
                rdbNroOrden.Checked = False
            Else
                rdbNroOrden.Checked = True
                Agrupacion13.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub rdbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNroOrden.CheckedChanged
        Try
            If rdbNroOrden.Checked Then
                rdbDatosAdicionales.Checked = False
                Agrupacion6.Enabled = False
                Me.txtNroOrdenCompra.Focus()
            Else
                rdbDatosAdicionales.Checked = True
                Agrupacion6.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNroOrdenCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroOrdenCompra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNroOrdenCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOrdenCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub fecFechaEntrega_Validated(sender As Object, e As EventArgs) Handles fecFechaEntrega.Validated
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFechaEntrega_ValueChanged(sender As Object, e As EventArgs) Handles fecFechaEntrega.ValueChanged
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoPago.ValueChanged
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCambiarEstado_Click(sender As Object, e As EventArgs) Handles btnCambiarEstado.Click
        Try
            CambiarEstado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
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

    Private Sub cmbTipoDocumento_ValueChanged(sender As Object, e As EventArgs) Handles cmbTipoDocumento.ValueChanged
        If cmbTipoDocumento.SelectedIndex > -1 Then
            Dim i As Integer = cmbTipoDocumento.SelectedIndex
            oeProDoc = New e_ProcesoTipoDocumento
            oeProDoc = cmbTipoDocumento.Items(i).ListObject
            lenSerie = gfc_ObtieneLongitudSerie(oeProDoc.CodigoTD)
            txtSerie.MaxLength = lenSerie
            lenNumero = gfc_ObtieneLongitudNumero(oeProDoc.CodigoTD)
            txtNroComprabante.MaxLength = lenNumero
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Requerimiento_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griLista_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaOrdenCompra.MouseMove
        If _tiempo <= 0 Then
            Listar(True)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griListaOrdenCompra.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub AprobarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AprobarToolStripMenuItem.Click
        VerificarPermiso()
    End Sub

    Private Sub AtenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtenderToolStripMenuItem.Click
        AtenderOrdenesCompra()
    End Sub

    Private Sub RechazarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechazarToolStripMenuItem.Click
        RechazarOrdenCompra()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = 1
        MenuContextual1.Items("EditarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = 0
        MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
        MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = 0
        MenuContextual1.Items("EnviarCorreoToolStripMenuItem").Visible = 0
        If griListaOrdenCompra.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = 1
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
            Select Case griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value
                Case "GENERADA"
                    MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = 1
                    MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = 1
                Case "EVALUADA", "ATENDIDO PARCIALMENTE"
                    If griListaOrdenCompra.ActiveRow.Cells("NombreSubEstado").Value = "APROBADA" Then
                        MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 1
                    End If
                    If griListaOrdenCompra.ActiveRow.Cells("IndicadorConsignacion").Value Then
                        MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
                    End If
            End Select
        End If
    End Sub

#End Region

#Region "Asiento Contable"

    Public Sub AsientosContablesServicio()
        Try
            AsientoModelo()
            CtaCtbleCatServicio()
            dtReferencia = GeneraDTRef(loReferencia)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleCatServicio()
        oeCtaCtbleCSer = New e_CtaCtbleCatServicio
        loCtaCtbleCSer = olCtaCtbleCSer.Listar(oeCtaCtbleCSer)
    End Sub

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejericio As Integer)
        Try
            oeMovimientoDocumento.loAsientoModelo = New List(Of e_AsientoModelo)
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "' AND TipoRef2 = 10 AND IdRef2 = '1PK000000003' "
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModeloCmpServ = New e_AsientoModelo
            oeAsientoModeloCmpServ.TipoOperacion = "" : oeAsientoModeloCmpServ.Activo = True
            oeAsientoModeloCmpServ.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModeloCmpServ.Ejercicio = Ejericio
            oeAsientoModeloCmpServ = olAsientoModelo.Obtener(oeAsientoModeloCmpServ)
            ' Actualizar Cuenta para Empresas Relacionada
            Dim _oeEmpr As New e_Proveedor
            _oeEmpr.Tipo = 0
            _oeEmpr.Id = oeMovimientoDocumento.IdClienteProveedor
            If llProveedores.Contains(_oeEmpr) Then
                _oeEmpr = llProveedores.Item(llProveedores.IndexOf(_oeEmpr))
                If _oeEmpr.IndRelacionada = 1 Then
                    For Each _oeDet In oeAsientoModeloCmpServ.leDetalle
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
            oeMovimientoDocumento.loAsientoModelo.Add(oeAsientoModeloCmpServ)
            For Each oe As e_DetalleAsientoModelo In oeAsientoModeloCmpServ.leDetalle
                If oe.IndDocumento Then
                    oeMovimientoDocumento.IdCuentaContable = oe.IdCuentaContable.Trim
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
    
End Class

