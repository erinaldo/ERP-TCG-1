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
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports Infragistics.Win.UltraWinGrid.UltraGridAction

Public Class frm_OrdenCompra
    Inherits frm_MenuPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OrdenCompra = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_OrdenCompra()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Dim oeFecha As New e_Fechas

    Dim lfuncionas As New l_MovimientoDocumento

    Dim oeOrdenCompra As New e_OrdenCompra
    Dim olOrdenCompra As New l_OrdenCompra

    Dim oeOrdenCompraMaterial As New e_OrdenCompraMaterial
    Dim olOrdenCompraMaterial As New l_OrdenCompraMaterial
    Dim llOrdenCompraMaterial As New List(Of e_OrdenCompraMaterial)

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

    Dim oeCotizacionDetalle As New e_CotizacionDetalleMat
    Dim olCotizacionDetalle As New l_CotizacionDetalleMat
    Dim llCotizacionDetalle As New List(Of e_CotizacionDetalleMat)

    'Dim oeServicio As New e_Servicio
    'Dim olServicio As New l_Servicio
    'Dim llServicio As New List(Of e_Servicio)
    'Dim olRequerimientoServicio As New l_RequerimientoServicio
    'Dim llRequerimientoServicio As New List(Of e_RequerimientoServicio)
    'Dim oeRequerimientoServicio As New e_RequerimientoServicio()

    'Dim oeCategoriaServicio As New e_CategoriaServicio
    'Dim olCategoriaServicio As New l_CategoriaServicio
    'Dim lstCategoriasServicio As New List(Of e_CategoriaServicio)

    Dim oeTrabSeg As New e_TrabajadorSeguridad
    Dim olTrabSeg As New l_TrabajadorSeguridad

    Dim olArea As New l_Area
    Dim oeArea As New e_Area
    Dim olUsuario As New l_Usuario
    Dim oeUsuario As New e_Usuario
    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto
    Private datoCambiado As Boolean = False

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

    '---------------Datos para atención de OC------------------
    Dim cantTotalAtender As Double
    Dim TotalAtender As Double

    Dim idMovimientoInventario As String = "1CH000000002" 'ORDEN DE INGRESO POR COMPRA
    Dim idTipoOrden As String = "1CH000000001" 'Tipo de orden: De ingreso.

    'Dim idMoneda As String = "1CH01" 'Moneda en soles
    Dim oeOrdenIngreso As New e_Orden, olOrdenIngreso As New l_Orden
    Dim olDetalleOrdenIngreso As New l_OrdenMaterial, oeDetalleOrdenIngreso As New e_OrdenMaterial
    Dim llDetalleOrdenIngreso As New List(Of e_OrdenMaterial)
    Dim llOrdenIngreso As New List(Of e_Orden)
    '----------------------------------------------------------------------

    '----------------Variables para la ejecución de ordnes de ingresos por compras
    'Manejador de Registro de Inventario
    Dim oeRegistroInventario As New e_RegistroInventario, olRegistroInventario As New l_RegistroInventario
    Dim listaRegistroInventario As New List(Of e_RegistroInventario)

    'Manejador de Inventario
    Dim oeInventario As New e_Inventario, olInventario As New l_Inventario
    Dim listaInventario As New List(Of e_Inventario)

    Dim llHistorialRechazo As New List(Of e_HistorialRechazoOC)

    Dim cantmat As Double = 0
    Dim cont As Integer
    Dim posGrilla As Integer

    'Dim tipoBien As String = "MATERIAL"
    'Dim tipoBien As String = "SERVICIO"
    'Dim columnaHidden As Boolean
    Dim _ingresando_datos As Boolean = False

    Dim rutaDocumento As String

    Dim oeSubAlmacen As New e_SubAlmacen, olSubAlmacen As New l_SubAlmacen

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

    'Manejador de Bloqueo
    Dim ls_IdOrdenAprobacion As String = ""

    'Validacion para que solo 1 usuario acceda a la orden
    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Dim olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Dim ds_OI_DE As New DataSet
    Dim relation As DataRelation

    ''' <summary>
    ''' Variables para Asiento Contable
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

    Private oeAsientoModelo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)

    Private oeAsientoModeloGuia As New e_AsientoModelo

    Private oeCtaCtbleSFam As New e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As New l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam, loCtaCtbleSFamOrden As New List(Of e_CtaCtbleSubFamiliaMat)

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
                mensajeEmergente.Confirmacion("No existe tipo de cambio para esta fecha.", True)
            End If
            ConsultarDetalle(True)
            Operacion = "Nuevo"
            MostrarTabs(1, ficOrdenCompra, 2)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
            cboProveedor.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
            Operacion = "Editar"
            btnTerminarOC.Enabled = False
            If VerificarRegistroEditado() Then
                If EditarOrdenCompra() Then
                    GuardarRegistroEditado()
                    If oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenGenerada Or oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenPreEvaluada Or oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenRechazada Then
                        Me.btnEnviarCorreo.Enabled = False
                        ConsultarDetalle(False)
                        ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0) 'Habilito el boton Guardar 
                    Else
                        Control_Bloqueo()
                    End If
                    If oeOrdenCompra.IndicadorConsignacion Then
                        ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
                        ficDetalleOCMateriales.Tabs(1).Enabled = 0
                    End If
                    If txtTC.Value = 0 Then
                        mensajeEmergente.Confirmacion("No existe tipo de cambio para esta fecha.", True)
                    End If
                    cboProveedor.Focus()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrdenCompra() Then
                If oeOrdenCompra.TipoOperacion = "3" Then 'Si se genera una atención de ordenes de compra,mostramos las ordenes de ingreso generado.
                    MostrarTabs(1, ficOrdenCompra, 2)
                    ficDetalleOCMateriales.Tabs(1).Selected = True
                    listarOrdenIngreso(True)
                    ConsultarDetalleOrdenCompra()
                Else
                    Consultar(True)
                    MostrarTabs(0, ficOrdenCompra, 2)
                End If
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
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
            ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaOrdenCompra

                If ValidarGrilla(griListaOrdenCompra, "Orden de compra") Then

                    If .ActiveRow.Cells("EstadoOrden").Value <> gNombreEstadoOrdenGenerada Then Throw New Exception("Solo podrá eliminar OC que esten Generada")
                    oeOrdenCompra = New e_OrdenCompra
                    oeOrdenCompra.Id = griListaOrdenCompra.ActiveRow.Cells("Id").Value.ToString
                    If oeOrdenCompra.Activo Then 'y verificamos si esta activo(Sin eliminación lógica)
                        If MessageBox.Show("Esta seguro de eliminar la orden de compra N°: " & _
                                 Trim(.ActiveRow.Cells("NroOrden").Value.ToString) & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oeOrdenCompra.TipoOperacion = "E"
                            olOrdenCompra.Eliminar(oeOrdenCompra)
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

    Public Overrides Sub Imprimir()

        ImprimirOrdenesCompra(False)

    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficOrdenCompra.SelectedTab.Index
                Case 0
                    If griListaOrdenCompra.Rows.Count > 0 Then Exportar_Excel(griListaOrdenCompra)
                Case 1
                    Select Case ficDetalleOCMateriales.SelectedTab.Index
                        Case 0
                            If gridDetalleOCMaterial.Rows.Count > 0 Then Exportar_Excel(gridDetalleOCMaterial)
                        Case 1
                            If griListaOrdenIngreso.Rows.Count > 0 Then Exportar_Excel(griListaOrdenIngreso)
                            If griDetalleOrdenIngreso.Rows.Count > 0 Then Exportar_Excel(griDetalleOrdenIngreso)
                    End Select
            End Select
            ControlBotonesOC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub IniciarFormulario()
        Try
            'Para las cabezeras
            ColoresGenerado.Color = Blanco
            ColoresEvaluado.Color = Kaki
            ColoresAtendidoParcialmente.Color = Azulino
            ColoresTerminada.Color = VerdeClaro
            ColoresAtendido.Color = MarronClaro
            ColoresRechazada.Color = Rojo
            ColoresPreEvaluada.Color = Plata
            'Obtener la información del área del usuario        
            oeUsuario.Id = gUsuarioSGI.Id
            oeUsuario = olUsuario.Obtener(oeUsuario)
            oeArea = olUsuario.Area(oeUsuario)
            LlenaCombos()
            FechaDesde.Value = Date.Now.AddDays(-7)
            FechaHasta.Value = Date.Now
            fecFechaEntrega.Value = Date.Now
            fecFechaPago.Value = Date.Now
            fecFechaActual.Value = Date.Now
            rfFechaCotDesde.Value = Date.Now.AddDays(-15)
            btnAtenderOC.Enabled = False
            btnAprobar.Enabled = False
            btnRechazar.Enabled = False
            oeIGV = olIGV.IGV(fecFechaActual.Value)
            txtPorcenIGV.Value = oeIGV.Porcentaje
            'ControlaBarraOperacionesOI(0, 0, 0, 0)
            ValidaFichaDetalleOrden()
            cboTipoOrdenCompra.Enabled = False
            AsociarMenu()
            AsociarMenuRequerimiento()
            'Generar comprobante en orden compra servicios-----------------------
            'chkGenComprobante.Visible = 0 'IIf(ValidarTipoOrdenCompra(), 0, 1)
            'agrGenerarComprabante.Visible = 0 'IIf(ValidarTipoOrdenCompra(), 0, 1)
            'btnEnviar.Visible = 0 'IIf(ValidarTipoOrdenCompra(), 0, 1)
            '--------------------------------------------------------------------
            lbl_etiqueta.Visible = False
            AsientosContablesCompraDocN()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            ficDetalleOCMateriales.Tabs(1).Enabled = 1
            llRequerimientoMaterial.Clear()
            llOrdenCompraMaterial.Clear()
            llOrdenCompraServicio.Clear()
            llMaterial.Clear()
            llCotizacionDetalle.Clear()
            llHistorialRechazo.Clear()
            datoCambiado = False
            griListaRequerimientos.DataSource = llRequerimientoMaterial
            gridDetalleOCMaterial.DataSource = llOrdenCompraMaterial
            griHistorialRechazo.DataSource = llHistorialRechazo
            griListadoCotizacionDetalle.DataSource = llCotizacionDetalle
            With griListaMateriales
                .DataSource = llMaterial
                .DisplayLayout.Bands(0).SortedColumns.Clear()
            End With
            InicializarListasOrdenIngreso()
            ficDetalleOCMateriales.Tabs(0).Selected = True
            controlaColumnasGriDetOC(4, True, True, True, 4)
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICAR OC CERRADA") Then
                btnModificarPrecios.Enabled = True
            Else
                btnModificarPrecios.Enabled = False
            End If
            lbl_etiqueta.Text = String.Empty
            lbl_etiqueta.Visible = 0
            cont = 0
            cambioMon = TipoCambio(ObtenerFechaServidor, 1)(0)
            txtTC.Value = cambioMon
            'Me.chkGenComprobante.Visible = 0 'IIf(ValidarTipoOrdenCompra(), 0, 1)
            'chkGenComprobante.Checked = 0 : cbCentro.Checked = 0
            'r_LimpiaComprobante()
            MostrarTabs(0, FichaTop, 1)
            ficDetalleOCMateriales.Tabs(0).Selected = True
            utcListadosMateriales.Tabs(0).Selected = 1
            Me.cheActivoPercepcion.Checked = False
            Me.DecDetraer.Value = 0
            Me.rdbUrgente.Checked = False
            Me.rdbNormal.Checked = False
            fecNotaCD.Value = Date.Now
            txtSreNotaCD.Text = String.Empty
            txtNroNotaCD.Text = String.Empty
            txtCodBarras.ReadOnly = False
            txtCodBarras.Value = String.Empty
            decSubTotalNCD.Value = 0.0
            decIGVNCD.Value = 0.0
            decTotalIGVNCD.Value = 0.0
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.AllowEdit
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = CellClickAction.EditAndSelectText
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CostoUnitario").CellClickAction = CellClickAction.EditAndSelectText
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = CellClickAction.EditAndSelectText
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioTotal").CellClickAction = CellClickAction.EditAndSelectText
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
        txtNotas.Value = String.Empty
        oeOrdenCompra.TipoOperacion = "I"
        cboProveedor.Text = String.Empty
        cboProveedor.DataSource = Nothing
        btnTerminarOC.Enabled = False
        chkRuc.Checked = False
        cboMoneda.SelectedIndex = 0
        cboTipoPago.SelectedIndex = 0
        cboTipoOrdenCompra.SelectedIndex = 0 'IIf(ValidarTipoOrdenCompra(), 0, 1)
        fecFechaEntrega.Value = Date.Now
        fecFechaPago.Value = Date.Now
        fecFechaActual.Value = Date.Now
        rfFechaCotDesde.Value = Date.Now.AddDays(-15)
        rfFechaCotHasta.Value = Date.Now
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        totalSinIgv = 0.0
        totalConIgv = 0.0
        chkRuc.Checked = 0
        cheAutoAprobar.Checked = 1
        gbeListadoMateriales.Expanded = 0
        'gbeListadoServicios.Expanded = 0
        oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
    End Sub

    Private Sub Control_Bloqueo()
        Try
            gbeListadoMateriales.Visible = 0
            Me.btnEnviarCorreo.Enabled = 1
            If _Estado.Equals(gNombreEstadoOrdenTerminada) Or _Estado.Contains(gNombreEstadoOrdenAtendido) Then
                ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
                ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 0)
                Exit Sub
            End If
            Select Case oeOrdenCompra.EstadoOrden
                Case gNombreEstadoOrdenGenerada, gNombreEstadoOrdenRechazada
                    gbeListadoMateriales.Visible = 1
                    ControlaBarraOperacionesDetalle("Enable", 1, 1, 0, 0, 0, 0, 1)
                    ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)

                Case Else
                    ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 1, 0) 'Inhabilito el boton Guardar
            End Select
            'If gUsuarioSGI.IdTrabajador = oeOrdenCompra.IdTrabajadorAprobacion Then ControlBoton(0, 0, 0, 1, 1, 0, 1, 1, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaOrdenMaterial()
        For j As Integer = 0 To gridDetalleOCMaterial.Rows.Count - 1
            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Factor = 0
            'Dim ol As New l_Combo
            'ol.ComboGrilla()
            oeUnidadMedida.IdTipoUnidadMedida = gridDetalleOCMaterial.Rows(j).Cells("IdTipoUnidadMedida").Value.ToString
            CrearComboGridPorCelda("IdUnidadMedida", "Nombre", j, gridDetalleOCMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
            oeMaterialAlmacen = New e_MaterialAlmacen
            oeMaterialAlmacen.TipoOperacion = "4"
            oeMaterialAlmacen.Activo = True
            oeMaterialAlmacen.IdMaterial = gridDetalleOCMaterial.Rows(j).Cells("IdMaterial").Value.ToString
            oeMaterialAlmacen.IdAlmacen = IIf(oeOrdenCompra.IndicadorConsignacion, "1", "0")
            CrearComboGridPorCelda("IdAlmacen", "Nombre", j, gridDetalleOCMaterial, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.TipoOperacion = "S"
            oeSubAlmacen.Activo = True
            oeSubAlmacen.IdAlmacen = gridDetalleOCMaterial.Rows(j).Cells("IdAlmacen").Value.ToString
            CrearComboGridPorCelda("IdSubAlmacen", "Nombre", j, gridDetalleOCMaterial, olSubAlmacen.ComboGrilla(oeSubAlmacen), True)
        Next
        gridDetalleOCMaterial.DataBind()
    End Sub

    Public Sub listarDetalleOrdenCompraMaterial(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial
            oeOrdenCompraMaterial.TipoOperacion = "1"
            oeOrdenCompraMaterial.Activo = Activo
            oeOrdenCompraMaterial.IdOrden = oeOrdenCompra.Id
            llOrdenCompraMaterial = olOrdenCompraMaterial.Listar(oeOrdenCompraMaterial)
            gridDetalleOCMaterial.DataSource = llOrdenCompraMaterial
            llenaCombosGrillaOrdenMaterial()
        Catch ex As Exception
            Throw ex
        End Try
        If gridDetalleOCMaterial.Rows.Count > 0 Then gridDetalleOCMaterial.Focus()
    End Sub

    Public Sub ConsultarDetalleOrdenCompra()
        Try
            ValidaFichaDetalleOrden()
            gbeListadoMateriales.Expanded = False
            listarDetalleOrdenCompraMaterial(True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EditarOrdenCompra() As Boolean
        Dim id As String
        Dim oeHisRec As New e_HistorialRechazoOC
        Dim olHisRec As New l_HistorialRechazoOC
        Try
            With griListaOrdenCompra
                _Estado = .ActiveRow.Cells("EstadoOrden").Value
                If _Estado = gNombreEstadoOrdenEvaluada Then
                    Me.txtCodBarras.ReadOnly = True
                ElseIf _Estado = gNombreEstadoOrdenPreEvaluada Then
                    Me.txtCodBarras.ReadOnly = True
                ElseIf _Estado = gNombreEstadoOrdenTerminada Then
                    Me.txtCodBarras.ReadOnly = True
                ElseIf _Estado = gNombreEstadoOrdenAtendido Then
                    Me.txtCodBarras.ReadOnly = True
                ElseIf _Estado = gNombreEstadoOrdenAtendidoParcialmente Then
                    Me.txtCodBarras.ReadOnly = False
                End If
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
                    oeHisRec.IdOrdenCompra = oeOrdenCompra.Id
                    llHistorialRechazo = olHisRec.Listar(oeHisRec)
                    griHistorialRechazo.DataSource = llHistorialRechazo
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
                        oeIGV = olIGV.IGV(fecFechaActual.Value)
                        txtPorcenIGV.Value = oeIGV.Porcentaje
                        cboCentro.Value = oeOrdenCompra.IdCentro
                        rdbNormal.Checked = IIf(oeOrdenCompra.IndTipoCompra = 0, True, False)
                        rdbUrgente.Checked = IIf(oeOrdenCompra.IndTipoCompra = 1, True, False)
                        '----
                        cambioMon = TipoCambio(fecFechaActual.Value, 1)(0)
                        txtTC.Value = cambioMon
                        '-----
                        MostrarTabs(1, ficOrdenCompra, 1)
                        oeOrdenCompra.TipoOperacion = "A"
                        cheAutoAprobar.Checked = oeOrdenCompra.IndicadorAprobacion
                        ls_IdOrdenAprobacion = oeOrdenCompra.IdAprobacion
                        ConsultarDetalleOrdenCompra()
                        If oeOrdenCompra.Consignacion = "CONSIGNA" Then
                            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.NoEdit
                        Else
                            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.AllowEdit
                        End If
                        'If oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenTerminada Then
                        '    Dim oeOrdDoc As New e_Orden_Documento
                        '    Dim olOrdDoc As New l_Orden_Documento
                        '    Dim oeDocAsc As New e_DocumentoAsociado
                        '    Dim olDocAsc As New l_DocumentoAsociado
                        '    Dim oeMovDoc As New e_MovimientoDocumento
                        '    Dim olMovDoc As New l_MovimientoDocumento
                        '    oeOrdDoc.IdOrden = id
                        '    oeOrdDoc.IdTipoOrden = "1CH000000006"
                        '    oeOrdDoc.TipoOperacion = "O"
                        '    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                        '    If oeOrdDoc.IdDocumento <> "" Then
                        '        oeDocAsc.TipoOperacion = "A"
                        '        oeDocAsc.IdMovimientoDocumentoAsoc = oeOrdDoc.IdDocumento
                        '        oeDocAsc.Activo = True
                        '        oeDocAsc = olDocAsc.Obtener(oeDocAsc)
                        '        If oeDocAsc.IdMovimientoDocumento <> "" Then
                        '            oeMovDoc.Id = oeDocAsc.IdMovimientoDocumento
                        '            oeMovDoc.TipoOperacion = ""
                        '            oeMovDoc = olMovDoc.Obtener(oeMovDoc)
                        '            If oeMovDoc.Id <> "" Then
                        '                fecNotaCD.Value = oeMovDoc.FechaEmision
                        '                txtSreNotaCD.Text = oeMovDoc.Serie
                        '                txtNroNotaCD.Text = oeMovDoc.Numero
                        '                decSubTotalNCD.Value = oeMovDoc.SubTotal
                        '                decIGVNCD.Value = oeMovDoc.IGV
                        '                decTotalIGVNCD.Value = oeMovDoc.Total
                        '            End If
                        '        End If
                        '    End If
                        'End If
                        listarOrdenIngreso(True)
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
            Throw ex
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
            objWorkSheet.Cells(2, 7) = "ORDEN DE COMPRA"
            'Else
            'objWorkSheet.Cells(2, 7) = "ORDEN DE SERVICIOS"
            'End If
            'objWorkSheet.Cells(7, 2) = "20479729141"
            objWorkSheet.Cells(4, 9) = oeOrdenCompra.NroOrden
            objWorkSheet.Cells(10, 15) = Date.Parse(oeOrdenCompra.FechaOrden).Date.Day & "/" & Date.Parse(oeOrdenCompra.FechaOrden).Date.Month & "/" & Date.Parse(oeOrdenCompra.FechaOrden).Date.Year
            'DATOS DE EMPRESA GENERADORA            
            oeEmpresa = New e_Empresa
            oeEmpresa.Id = gs_IdEmpresaSistema.Trim
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

            objWorkSheet.Cells(15, 10) = lfuncionas.CompletaConCeros(oeOrdenCompra.FechaOrden.Day, 2) & "/" & lfuncionas.CompletaConCeros(oeOrdenCompra.FechaOrden.Month, 2) & "/" & oeOrdenCompra.FechaOrden.Year
            objWorkSheet.Cells(18, 9) = oeTipoPago.Nombre   'oeTipoPago.Nombre
            objWorkSheet.Cells(22, 9) = lfuncionas.CompletaConCeros(oeOrdenCompra.FechaEntrega.Day, 2) & "/" & lfuncionas.CompletaConCeros(oeOrdenCompra.FechaEntrega.Month, 2) & "/" & oeOrdenCompra.FechaEntrega.Year
            objWorkSheet.Cells(24, 9) = lfuncionas.CompletaConCeros(oeOrdenCompra.FechaPago.Day, 2) & "/" & lfuncionas.CompletaConCeros(oeOrdenCompra.FechaPago.Month, 2) & "/" & oeOrdenCompra.FechaPago.Year
            objWorkSheet.Cells(26, 9) = oeMoneda.Nombre
            objWorkSheet.Cells(28, 9) = "" 'cbo_Banco.Text
            objWorkSheet.Cells(30, 9) = "" 'txt_NroCtaBanco.Text

            'If ValidarTipoOrdenCompra() Then 'Si es material
            Dim ln_Fila As Integer = 1
            For Each obj As e_OrdenCompraMaterial In llOrdenCompraMaterial
                Dim ln_PrecioIGV As Double = Math.Round(obj.PrecioUnitario, 4)
                Dim ln_Importe As Double = Math.Round(obj.PrecioTotal, 4)
                objWorkSheet.Cells(ln_Fila + 33, 1) = ln_Fila
                objWorkSheet.Cells(ln_Fila + 33, 2) = obj.CodigoMaterial
                objWorkSheet.Cells(ln_Fila + 33, 4) = obj.CantidadMaterial
                objWorkSheet.Cells(ln_Fila + 33, 5) = obj.Material
                objWorkSheet.Cells(ln_Fila + 33, 13) = obj.UnidadMedida
                objWorkSheet.Cells(ln_Fila + 33, 15) = ln_PrecioIGV
                objWorkSheet.Cells(ln_Fila + 33, 16) = ln_Importe
                ln_Fila = ln_Fila + 1
            Next

            'Else 'Sino es servicios
            '    Dim ln_Fila As Integer = 1
            '    For Each obj As e_OrdenCompraServicio In llOrdenCompraServicio
            '        Dim ln_PrecioIGV As Double = Math.Round(obj.PrecioUnitario, 4)
            '        Dim ln_Importe As Double = Math.Round(obj.Importe, 4)
            '        objWorkSheet.Cells(ln_Fila + 33, 1) = ln_Fila
            '        objWorkSheet.Cells(ln_Fila + 33, 2) = obj.CodigoServicio
            '        objWorkSheet.Cells(ln_Fila + 33, 4) = obj.Cantidad
            '        objWorkSheet.Cells(ln_Fila + 33, 5) = obj.Servicio
            '        objWorkSheet.Cells(ln_Fila + 33, 13) = ""
            '        objWorkSheet.Cells(ln_Fila + 33, 15) = ln_PrecioIGV
            '        objWorkSheet.Cells(ln_Fila + 33, 16) = ln_Importe
            '        ln_Fila = ln_Fila + 1
            '    Next

            'End If

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
            'If Not enviarCorreo Then
            objXls.Visible = True 'Permite visualizar el excel.
            'Else

            '    'C:\Documents and Settings\Administrator\Mis documentos\               
            '    Dim rutaExtOf2003 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xls"
            '    Dim rutaExtOf2007 As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & objWorkbook.Name & ".xlsx"
            '    If System.IO.File.Exists(rutaExtOf2003) Then
            '        System.IO.File.Delete(rutaExtOf2003)
            '    End If
            '    If System.IO.File.Exists(rutaExtOf2007) Then
            '        System.IO.File.Delete(rutaExtOf2007)
            '    End If
            '    objWorkbook.Save()
            '    rutaDocumento = objWorkbook.Path & "\" & objWorkbook.Name
            '    objXls.ActiveWorkbook.Close(SaveChanges:=False)
            '    objXls.Workbooks.Close()
            '    objXls.DisplayAlerts = False
            '    objXls.Quit()

            '    Dim ms_CodEmpres As String = "" '"1234562"
            '    Dim correoTrabajador As String = ""
            '    Dim correoProveedor As String = ""
            '    If goeUsuario.leEmail.Count > 0 Then correoTrabajador = goeUsuario.leEmail.Item(0).Nombre '"weezer@hotmail.com" 'Quiem lo envia                
            '    If oeProveedor.leEmail.Count > 0 Then correoProveedor = oeProveedor.leEmail.Item(0).Nombre 'Para quien va dirigido                
            '    Dim formulario As frm_EnvioCorreo
            '    formulario = frm_EnvioCorreo
            '    If formulario.ObtenerDatos(ms_CodEmpres, rutaDocumento, correoTrabajador, True, True, True, True, _
            '         correoProveedor.Trim, "Por favor atender la orden de compra en los tiempos establecidos") Then

            '        formulario.ShowDialog()
            '        ControlBoton(0, 0, 0, 1, 1, 0, 1, 0, 1)

            '    End If
            'objXls.ActiveSheet.PrintOut(Copies:=1, Collate:=True)
            'End If
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
            Throw ex
        End Try
    End Sub

    Public Sub ValidaFichaDetalleOrden()
        'If ValidarTipoOrdenCompra() Then
        'ficDetalle.Tabs(0).Selected = 1
        'ficDetalle.Tabs(1).Visible = 0
        btnAtenderOC.Visible = 1
        MenuContextual1.Items("AtenderToolStripMenuItem").Visible = 1
        'Else
        'ficDetalle.Tabs(1).Selected = 1
        'ficDetalle.Tabs(0).Visible = 0
        'btnAtenderOC.Visible = 0
        'MenuContextual1.Items("AtenderToolStripMenuItem").Visible = 0
        'End If
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeOrdenCompra = New e_OrdenCompra
            ValidarFechaDesde_Hasta(FechaDesde, FechaHasta)
            oeOrdenCompra.Activo = Activo
            oeOrdenCompra.IdMoneda = cboMonedaL.Value
            oeOrdenCompra.IdProveedor = cboProveedorL.Value
            oeOrdenCompra.IdEstadoOrden = cboEstadoOrden.Value
            oeOrdenCompra.IdTipoOrdenCompra = "1PK000000001"
            If rdbDatosAdicionales.Checked Then
                oeFecha.OpcionFecha = "FO"
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
                    Case gNombreEstadoOrdenGenerada
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case gNombreEstadoOrdenEvaluada
                        fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                    Case gNombreEstadoOrdenAtendidoParcialmente
                        fila.CellAppearance.BackColor = Me.ColoresAtendidoParcialmente.Color
                    Case gNombreEstadoOrdenAtendido
                        fila.CellAppearance.BackColor = Me.ColoresAtendido.Color
                    Case gNombreEstadoOrdenTerminada
                        fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                    Case gNombreEstadoOrdenRechazada
                        fila.CellAppearance.BackColor = Me.ColoresRechazada.Color
                    Case gNombreEstadoOrdenPreEvaluada
                        fila.CellAppearance.BackColor = Me.ColoresPreEvaluada.Color
                    Case Else
                        fila.CellAppearance.BackColor = Color.White
                End Select
                If fila.Cells("IndTipoCompra").Value = 1 Then
                    fila.Cells("TipoCompra").Appearance.BackColor = Color.Violet
                End If
            Next
            With griListaOrdenCompra
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub obtenerCantidadTotalAtender(ByVal oeReqMat As e_OrdenCompraMaterial)
        cantTotalAtender += oeReqMat.CantidadMaterialAAtender
    End Sub

    Private Sub AgregarDetalleOrdenIngreso()
        Try
            TotalAtender = 0
            For Each obj As e_OrdenCompraMaterial In llOrdenCompraMaterial
                If obj.CantidadMaterialAAtender > 0 Then
                    oeDetalleOrdenIngreso = New e_OrdenMaterial
                    oeDetalleOrdenIngreso.Activo = True
                    oeDetalleOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                    oeDetalleOrdenIngreso.IdMaterial = obj.IdMaterial
                    oeDetalleOrdenIngreso.CodigoMaterial = obj.CodigoMaterial
                    oeDetalleOrdenIngreso.Material = obj.Material
                    oeDetalleOrdenIngreso.CantidadMaterial = obj.CantidadMaterialAAtender
                    oeDetalleOrdenIngreso.IndicadorIgv = obj.IndicadorIgv
                    oeDetalleOrdenIngreso.CostoAdm = obj.CostoAdm
                    If cboMoneda.Text = "DOLARES" Then If txtTC.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                    oeDetalleOrdenIngreso.PrecioUnitario = obj.PrecioUnitario
                    oeDetalleOrdenIngreso.IdSubAlmacen = obj.IdSubAlmacen
                    oeDetalleOrdenIngreso.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    oeDetalleOrdenIngreso.IdUnidadMedida = obj.IdUnidadMedida
                    oeDetalleOrdenIngreso.UnidadMedida = obj.UnidadMedida
                    oeDetalleOrdenIngreso.ValorVenta = oeDetalleOrdenIngreso.PrecioUnitario * oeDetalleOrdenIngreso.CantidadMaterial
                    TotalAtender += oeDetalleOrdenIngreso.ValorVenta
                    oeDetalleOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                    llDetalleOrdenIngreso.Add(oeDetalleOrdenIngreso)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub listarOrdenIngreso(ByVal Activo As Boolean)
        Try
            Dim oeOrdIng As New e_Orden
            oeOrdIng.IdEstadoOrden = ""
            oeOrdIng.NroOrden = ""
            oeOrdIng.Id = ""
            oeOrdIng.Referencia = oeOrdenCompra.Id
            oeOrdIng.TipoOperacion = "2"
            oeOrdIng.Activo = Activo
            oeOrdIng.IdMovimientoInventario = idMovimientoInventario
            oeOrdIng.IdTipoOrden = idTipoOrden
            If Not String.IsNullOrEmpty(oeOrdenCompra.Id) Then
                llOrdenIngreso = olOrdenIngreso.Listar(oeOrdIng)
                griListaOrdenIngreso.DataSource = llOrdenIngreso
                For Each fila As UltraGridRow In griListaOrdenIngreso.Rows
                    Select Case fila.Cells("EstadoOrden").Value
                        Case gNombreEstadoOrdenGenerada
                            fila.CellAppearance.BackColor = Blanco
                        Case gNombreEstadoOrdenRecepcionado
                            fila.CellAppearance.BackColor = Kaki
                        Case gNombreEstadoOrdenTerminada
                            fila.CellAppearance.BackColor = VerdeClaro
                    End Select
                Next
                For Each ording As e_Orden In llOrdenIngreso
                    If ording.EstadoOrden = gNombreEstadoOrdenTerminada And ording.TipoDocumento = "FACTURA" Then
                        If oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenTerminada Then
                            Dim oeOrdDoc As New e_Orden_Documento
                            Dim olOrdDoc As New l_Orden_Documento
                            Dim oeDocAsc As New e_DocumentoAsociado
                            Dim olDocAsc As New l_DocumentoAsociado
                            Dim oeMovDoc As New e_MovimientoDocumento
                            Dim olMovDoc As New l_MovimientoDocumento
                            oeOrdDoc.IdOrden = ording.Id
                            oeOrdDoc.IdTipoOrden = "1CH000000001"
                            oeOrdDoc.TipoOperacion = "O"
                            oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                            oeDocAsc.TipoOperacion = "A"
                            oeDocAsc.IdMovimientoDocumentoAsoc = oeOrdDoc.IdDocumento
                            oeDocAsc.Activo = True
                            oeDocAsc = olDocAsc.Obtener(oeDocAsc)
                            If oeDocAsc.IdMovimientoDocumento <> "" Then
                                oeMovDoc.Id = oeDocAsc.IdMovimientoDocumento
                                oeMovDoc.TipoOperacion = ""
                                oeMovDoc = olMovDoc.Obtener(oeMovDoc)
                                If oeMovDoc.Id <> "" Then
                                    fecNotaCD.Value = oeMovDoc.FechaEmision
                                    txtSreNotaCD.Text = oeMovDoc.Serie
                                    txtNroNotaCD.Text = oeMovDoc.Numero
                                    decSubTotalNCD.Value = oeMovDoc.SubTotal
                                    decIGVNCD.Value = oeMovDoc.IGV
                                    decTotalIGVNCD.Value = oeMovDoc.Total
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarDetalleOrdenIngreso()
        Try
            oeDetalleOrdenIngreso = New e_OrdenMaterial
            oeDetalleOrdenIngreso.TipoOperacion = "L"
            oeDetalleOrdenIngreso.Activo = True
            oeDetalleOrdenIngreso.IdOrden = griListaOrdenIngreso.ActiveRow.Cells("Id").Value.ToString
            llDetalleOrdenIngreso = olDetalleOrdenIngreso.Listar(oeDetalleOrdenIngreso)
            griDetalleOrdenIngreso.DataSource = llDetalleOrdenIngreso
            With griDetalleOrdenIngreso
                For j As Integer = 0 To .Rows.Count - 1
                    SubAlmacenValueList(.Rows(j).Cells("IdAlmacen").Value.ToString, griDetalleOrdenIngreso)
                    .Rows(j).Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                Next
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaOrdenIngreso.Focus()
    End Sub

    Public Sub ListarOI_Detalle()
        Try
            oeDetalleOrdenIngreso = New e_OrdenMaterial
            oeDetalleOrdenIngreso.TipoOperacion = "L"
            oeDetalleOrdenIngreso.Activo = True
            oeDetalleOrdenIngreso.IdOrden = griListaOrdenIngreso.ActiveRow.Cells("Id").Value.ToString
            ds_OI_DE = olDetalleOrdenIngreso.ListarDS(oeDetalleOrdenIngreso)

            Dim parentCol As DataColumn = ds_OI_DE.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds_OI_DE.Tables(1).Columns("Id")
            relation = New DataRelation("FK_Relacion", parentCol, childCol, False)
            ds_OI_DE.Relations.Add(relation)

            ds_OI_DE.AcceptChanges()
            griDetalleOrdenIngreso.DataSource = ds_OI_DE
            'llenaCombosGrillaMaterialRequerido(grilla_OA_Material)

            With griDetalleOrdenIngreso.DisplayLayout
                .Bands(1).Columns("Serie").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("Serie").CellClickAction = CellClickAction.Edit
                .Bands(1).Columns("Especificaciones").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("Especificaciones").CellClickAction = CellClickAction.Edit
                '.Bands(1).Columns("IdMarca").Header.Appearance.TextHAlign = HAlign.Center
                '.Bands(1).Columns("IdMarca").Header.Caption = "Marca"
                .Bands(1).Columns("IdModelo").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("IdModelo").Header.Caption = "Modelo"
                .Bands(1).Columns("IdEstado").Header.Appearance.TextHAlign = HAlign.Center
                .Bands(1).Columns("IdEstado").Header.Caption = "Estado"
                .Override.FilterUIType = FilterUIType.HeaderIcons
                .Override.AllowRowFiltering = DefaultableBoolean.False
                .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
                .Override.CellPadding = 1
            End With

            Me.griDetalleOrdenIngreso.Rows.CollapseAll(True)
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
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
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

    Public Function GuardarOrdenCompra() As Boolean
        Try
            ObtenerDatosControles()
            If oeOrdenCompra.TipoOperacion = "3" Then 'Si se genera una atención de ordenes de compra.
                llOrdenCompraMaterial.ForEach(AddressOf obtenerCantidadTotalAtender)
                If cantTotalAtender = 0 Then
                    Throw New Exception("Debe ingresar cantidad para atender las ordenes de compra.")
                End If
                '----------------------- GENERANDO UNA ORDEN DE INGRESO ---------------------------
                InicializarListasOrdenIngreso()
                AgregarDetalleOrdenIngreso()
                oeOrdenIngreso.lstOrdenMaterial = llDetalleOrdenIngreso
                oeOrdenIngreso.Activo = True
                oeOrdenIngreso.Total = TotalAtender
                oeOrdenIngreso.IdTipoOrden = idTipoOrden
                oeOrdenIngreso.IdMovimientoInventario = idMovimientoInventario
                oeMoneda = New e_Moneda
                oeMoneda.TipoOperacion = ""
                oeMoneda.Nombre = Me.cboMoneda.Text
                oeMoneda = olMoneda.Obtener(oeMoneda)
                oeOrdenIngreso.IdMoneda = oeMoneda.Id 'idMoneda 'Definir: Soles                 
                oeOrdenIngreso.IdProveedor = oeOrdenCompra.IdProveedor 'idProveedor   
                oeOrdenIngreso.Glosa = oeOrdenCompra.Glosa
                oeOrdenIngreso.FechaOrden = Date.Now
                oeOrdenIngreso.TipoOperacion = "I"
                oeOrdenIngreso.IdSubAlmacenDestino = ""
                oeOrdenIngreso.IdSubAlmacenOrigen = ""
                oeOrdenIngreso.TipoReferencia = ""
                oeOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                oeOrdenIngreso.TipoReferencia = "COMPRA" 'Enviamos el Id de la Orden de compra para guardarlo a la Tabla Orden_Orden y asi asociarla a la Orden de Ingreso.
                oeOrdenIngreso.Referencia = oeOrdenCompra.NroOrden
                llDetalleOrdenIngreso = New List(Of e_OrdenMaterial)
                cantTotalAtender = 0
                TotalAtender = 0
                oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                If Not olOrdenIngreso.Guardar(oeOrdenIngreso, New List(Of e_RegistroInventario)) Then
                    Return False
                End If
                '--------------------------------------------------------------------------------                   
            End If
            oeOrdenCompra.TipoBien = "MATERIAL"
            If oeOrdenCompra.TipoOperacion = "1" Then
                Dim oeMatNeg As New e_MaterialesNegociados
                Dim olMatNeg As New l_MaterialesNegociados
                Dim oeMatNegDet As New e_MaterialesNegociadosDet
                Dim olMatNegDet As New l_MaterialesNegociadosDet
                Dim loMatNegDet As New List(Of e_MaterialesNegociadosDet)
                oeMatNeg.TipoOperacion = "1"
                oeMatNeg.IdProveedor = oeOrdenCompra.IdProveedor
                oeMatNeg = olMatNeg.Obtener(oeMatNeg)
                oeMatNegDet.IdMaterialesNegociados = oeMatNeg.Id
                oeMatNegDet.TipoOperacion = "1"
                oeMatNegDet.FechaCreacion = Date.Parse("01/01/1901")
                loMatNegDet = olMatNegDet.Listar(oeMatNegDet)
                'If loMatNegDet.Count = 0 Then
                '    oeMatNeg = New e_MaterialesNegociados
                '    oeMatNeg.TipoOperacion = "1"
                '    oeMatNeg.IdProveedor = "1CH000004444"
                '    oeMatNeg = olMatNeg.Obtener(oeMatNeg)
                '    oeMatNegDet.IdMaterialesNegociados = oeMatNeg.Id
                '    loMatNegDet = olMatNegDet.Listar(oeMatNegDet)
                'End If
                For Each material As e_OrdenCompraMaterial In oeOrdenCompra.lstOrdenMaterial
                    For Each matnegdet As e_MaterialesNegociadosDet In loMatNegDet
                        If material.IdMaterial = matnegdet.IdMaterial Then
                            If cboMoneda.Value <> matnegdet.IdMoneda Then
                                Dim preciomat As Double = 0
                                If cboMoneda.Value <> "1CH01" Then
                                    preciomat = material.PrecioUnitario * TipoCambio(fecFechaActual.Value, 1)(0)
                                Else
                                    preciomat = material.PrecioUnitario / TipoCambio(fecFechaActual.Value, 1)(0)
                                End If
                                If preciomat > matnegdet.Precio Then
                                    mensajeEmergente.Problema("Precio no Coincide con Precio Negociado y/o Precio Maximo Permitido. " & material.Material & ", Pactado a: S/" & matnegdet.Precio, True)
                                    Return False
                                End If
                            Else
                                If material.PrecioUnitario > matnegdet.Precio Then
                                    Dim oemon As New e_Moneda
                                    oemon.Id = matnegdet.IdMoneda
                                    oemon = llMoneda.Item(llMoneda.IndexOf(oemon))
                                    mensajeEmergente.Problema("Precio no Coincide con Precio Negociado y/o Precio Maximo Permitido. " _
                                                              & material.Material & ", Pactado a: " & oemon.Abreviatura & " " & matnegdet.Precio, True)
                                    Return False
                                End If
                            End If
                        End If
                    Next
                Next
            End If
            If oeOrdenCompra.EstadoOrden = "RECHAZADA" And datoCambiado = True Then oeOrdenCompra.IdEstadoOrden = "1CH000000001"
            If oeOrdenCompra.TipoOperacion = "I" Then oeOrdenCompra.IdEstadoOrden = "1CH000000001"
            If oeOrdenCompra.TipoOperacion = "I" Or oeOrdenCompra.TipoOperacion = "A" Then
                If oeOrdenCompra.lstOrdenMaterial.Count = 1 Then
                    Dim oe As New e_OrdenCompraMaterial
                    oeOrdenCompra.OrdenAprobacion = New e_OrdenAprobacion
                    For Each material As e_OrdenCompraMaterial In oeOrdenCompra.lstOrdenMaterial
                        If material.Material = "DIESEL D2" Then
                            oe.Id = oeOrdenCompra.IdProveedor
                            oe.TipoOperacion = "D"
                            oe = olOrdenCompraMaterial.Obtener(oe)
                            If oe.CostoUnitario = material.CostoUnitario Then
                                oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                                oeOrdenCompra.OrdenAprobacion.TipoOperacion = "I"
                                oeOrdenCompra.OrdenAprobacion.IndBloqueo = True
                                oeOrdenCompra.OrdenAprobacion.FechaAprobacion = ObtenerFechaServidor()
                                oeOrdenCompra.OrdenAprobacion.IdTrabajador = oe.IdAlmacen
                                oeOrdenCompra.OrdenAprobacion.UsuarioCreacion = gUsuarioSGI.Id
                            End If

                        End If
                    Next
                End If
            End If
            If Me.lbl_etiqueta.Text = "Aprobando OC" Then
                Dim montototal As Double = 0
                If oeOrdenCompra.IdMoneda = "1CH01" Then
                    montototal = oeOrdenCompra.Total
                Else
                    montototal = oeOrdenCompra.Total * txtTC.Value
                End If
                If oeOrdenCompra.lstOrdenMaterial.Count = 1 Then
                    For Each material As e_OrdenCompraMaterial In oeOrdenCompra.lstOrdenMaterial
                        If material.Material = "DIESEL D2" Then
                            If PermisoCombustible() = False Then
                                Throw New Exception("No tiene Permiso para Aprobar el Monto para OC de Combustible")
                            Else
                                If oeTrabSeg.CantidadLimite <= montototal Then
                                    Throw New Exception("No tiene Permiso para Aprobar el Monto para OC de Combustible")
                                Else
                                    oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                                End If
                            End If
                        Else
                            If montototal >= 5000 Then
                                If PermisoPreAprobado() = True Then
                                    oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                                Else
                                    oeOrdenCompra.IdEstadoOrden = "1CH000000002"
                                End If
                            Else
                                oeTrabSeg = New e_TrabajadorSeguridad
                                oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
                                oeTrabSeg.NombreProceso = "APROBAR ORDENES DE COMPRA"
                                oeTrabSeg.Activo = True
                                oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
                                If montototal > oeTrabSeg.CantidadLimite Then
                                    Throw New Exception("El Monto de la Orden Supera su Monto Permitido. " & CStr(oeTrabSeg.CantidadLimite))
                                End If
                                oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                            End If
                        End If
                    Next
                Else
                    If montototal >= 5000 Then
                        If PermisoPreAprobado() = True Then
                            oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                        Else
                            oeOrdenCompra.IdEstadoOrden = "1CH000000002"
                        End If
                    Else
                        oeTrabSeg = New e_TrabajadorSeguridad
                        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
                        oeTrabSeg.NombreProceso = "APROBAR ORDENES DE COMPRA"
                        oeTrabSeg.Activo = True
                        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
                        If montototal > oeTrabSeg.CantidadLimite Then
                            Throw New Exception("El Monto de la Orden Supera su Monto Permitido. " & CStr(oeTrabSeg.CantidadLimite))
                        End If
                        oeOrdenCompra.IdEstadoOrden = "1CH000000011"
                    End If
                End If
            End If
            oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olOrdenCompra.Guardar(oeOrdenCompra) Then
                Return False
            End If
            If oeOrdenCompra.TipoOperacion <> "3" Then mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function PermisoCombustible() As Boolean
        oeTrabSeg = New e_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
        oeTrabSeg.TipoOperacion = "H"
        oeTrabSeg.NombreProceso = "APROBAR ORDENES DE DIESEL"
        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function PermisoPreAprobado() As Boolean
        oeTrabSeg = New e_TrabajadorSeguridad
        oeTrabSeg.IdTrabajador = gUsuarioSGI.IdTrabajador
        oeTrabSeg.TipoOperacion = "H"
        oeTrabSeg.NombreProceso = "APROBACION DEL PRE-APROBADO"
        oeTrabSeg = olTrabSeg.Obtener(oeTrabSeg)
        If oeTrabSeg.IdTrabajador = "" Then
            Return False
        Else
            Return True
        End If
    End Function

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
                .IndTipoCompra = -1
                If rdbNormal.Checked Then .IndTipoCompra = 0
                If rdbUrgente.Checked Then .IndTipoCompra = 1
                If .IndTipoCompra = -1 Then Throw New Exception("Seleccione Tipo De Compra")
                .lstOrdenMaterial = llOrdenCompraMaterial
                .OrdenAprobacion.Id = ls_IdOrdenAprobacion
                .OrdenAprobacion.IdOrden = ""
                .OrdenAprobacion.FechaAprobacion = Date.Now
                .OrdenAprobacion.IndAprobacion = 1
                .OrdenAprobacion.Activo = 1
                .OrdenAprobacion.IdTrabajador = gUsuarioSGI.IdTrabajador
                .OrdenAprobacion.UsuarioCreacion = gUsuarioSGI.Id
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlenaCombos()
        Try
            oeMoneda.Activo = True
            oeMoneda.TipoOperacion = "1"
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            oeTipoOrdenCompra.Activo = True
            LlenarComboMaestro(cboTipoOrdenCompra, olTipoOrdenCompra.Listar(oeTipoOrdenCompra), 0)

            oeTipoOrdenCompra.Activo = True

            oeTipoPago.Id = "CERO"
            oeTipoPago.Nombre = "TODOS"
            llTipoPago.Add(oeTipoPago)
            oeTipoPago = New e_TipoPago
            oeTipoPago.Activo = True
            llTipoPago.AddRange(olTipoPago.Listar(oeTipoPago))

            oeTipoPago.Activo = True
            LlenarComboMaestro(cboTipoPago, olTipoPago.Listar(oeTipoPago), 0)

            oeCentro = New e_Centro
            oeCentro.Activo = True
            LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
            cboCentro.Value = ObtenerCentro(gs_PrefijoIdSucursal).Id
            cboCentro.Enabled = False

            Dim lstProveedor As New List(Of e_Proveedor)
            oeProveedor.Activo = True
            lstProveedor = olProveedor.Listar(oeProveedor)

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
            LlenarComboMaestro(cboProveedorCot, llProveedores, 0)

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
            _IdEstadoOrden = cboEstadoOrden.Value
            cboEstadoOrden.SelectedIndex = 0
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

    Private Function VerificaListaReqMat(ByVal oeRequerimientoMaterial As e_RequerimientoMaterial) As Boolean
        For Each filaOrdenMaterial As e_OrdenCompraMaterial In llOrdenCompraMaterial
            If (oeRequerimientoMaterial.Id = filaOrdenMaterial.IdRequerimientoMaterial) Then 'And oeMat.IdAlmacen = filaReqMat.IdAlmacen
                Return True
            End If
        Next
    End Function

    Private Function VerificaListaReqSer(ByVal oeRequerimientoServicio As e_RequerimientoServicio) As Boolean
        For Each filaOrdenMaterial As e_OrdenCompraMaterial In llOrdenCompraMaterial
            If (oeRequerimientoServicio.Id = filaOrdenMaterial.IdRequerimientoMaterial) Then 'And oeMat.IdAlmacen = filaReqMat.IdAlmacen
                Return True
            End If
        Next
    End Function

    Public Sub llenaGrillaReqMat(ByVal Activo As Boolean)
        Try
            oeRequerimientoMaterial = New e_RequerimientoMaterial
            oeRequerimientoMaterial.FechaInicio = Date.Now.AddMonths(-6)
            oeRequerimientoMaterial.FechaFinal = Date.Now
            oeRequerimientoMaterial.Tipooperacion = "3"
            oeRequerimientoMaterial.Activo = Activo
            llRequerimientoMaterial = olRequerimientoMaterial.Listar(oeRequerimientoMaterial)
            '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
            If llOrdenCompraMaterial.Count > 0 Then
                llRequerimientoMaterial.RemoveAll(AddressOf VerificaListaReqMat)
                griListaRequerimientos.DataBind()
            End If
            '--------------------------------------------------------------------------------------------------------------            
            With griListaRequerimientos
                .DataSource = llRequerimientoMaterial
                .DisplayLayout.Bands(0).Columns("IdMantenimiento").Hidden = True
                .DisplayLayout.Bands(0).Columns("Mantenimiento").Hidden = True
                'agrOrdenCompra.Text = "Materiales requeridos : " & llRequerimientoMaterial.Count
            End With
            'spcDetalleOrdenCompra.Panel2Collapsed = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub InicializarListasOrdenIngreso()
        Try
            oeOrdenIngreso = New e_Orden
            llOrdenIngreso = New List(Of e_Orden)
            llDetalleOrdenIngreso = New List(Of e_OrdenMaterial)
            griListaOrdenIngreso.DataSource = llOrdenIngreso
            griDetalleOrdenIngreso.DataSource = llDetalleOrdenIngreso
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub controlaColumnasGriDetOC(ByVal cellClickActionCant As Integer, ByVal valorCantAtenderHidden As Boolean, ByVal valorCantPendienteHidden As Boolean, _
                                         ByVal valorVisLis As Boolean, ByVal cellClickAction As Integer, Optional ByVal pendienteEditable As Integer = 0)

        With gridDetalleOCMaterial
            .DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = cellClickActionCant
            .DisplayLayout.Bands(0).Columns("CantidadMaterialAAtender").Hidden = valorCantAtenderHidden
            .DisplayLayout.Bands(0).Columns("CantidadMaterialPendiente").Hidden = valorCantPendienteHidden
            .DisplayLayout.Bands(0).Columns("IndicadorIgv").CellClickAction = cellClickAction
            .DisplayLayout.Bands(0).Columns("CantidadMaterialPendiente").CellClickAction = UltraWinGrid.CellClickAction.RowSelect

            .DisplayLayout.Bands(0).Columns("CostoUnitario").CellClickAction = cellClickActionCant
            .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = cellClickActionCant
            .DisplayLayout.Bands(0).Columns("PrecioTotal").CellClickAction = cellClickActionCant
            
        End With
        gbeListadoMateriales.Visible = valorVisLis
        'gbeListadoServicios.Visible = valorVisLis
    End Sub

    Sub QuitarDetalle()
        gbeListadoMateriales.Expanded = True
        llOrdenCompraMaterial.RemoveAll(AddressOf verificarSeleccionadoMaterial)
        griListaRequerimientos.DataBind()
        griListaMateriales.DataBind()
        gridDetalleOCMaterial.DataBind()
        griListadoCotizacionDetalle.DataBind()
        griListaMateriales.Rows.ExpandAll(True)
        CalcularSubtotalesTotalesMaterial()
    End Sub

    Private Function verificarSeleccionadoMaterial(ByVal oeOrdComp As e_OrdenCompraMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(oeOrdComp.IdRequerimientoMaterial) Or _
               Not String.IsNullOrEmpty(oeOrdComp.IdMaterial) Then
                If oeOrdComp.Seleccion Then
                    Select Case oeOrdComp.TipoOrdenCompra
                        Case "RM"
                            Dim oeRequerimientoMaterial As New e_RequerimientoMaterial
                            oeRequerimientoMaterial.Id = oeOrdComp.IdRequerimientoMaterial
                            oeRequerimientoMaterial.Tipooperacion = "2"
                            oeRequerimientoMaterial.Activo = True
                            oeRequerimientoMaterial = olRequerimientoMaterial.Obtener(oeRequerimientoMaterial)
                            llRequerimientoMaterial.Add(oeRequerimientoMaterial)
                            utcListadosMateriales.Tabs(0).Selected = True
                        Case "M"
                            Dim oeMaterial As New e_Material
                            oeMaterial.Id = oeOrdComp.IdMaterial
                            oeMaterial.IdAlmacen = oeOrdComp.IdAlmacen
                            oeMaterial.TipoOperacion = "5"
                            oeMaterial.Activo = True
                            oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                            oeMaterial.IdSubAlmacen = oeOrdComp.IdSubAlmacen
                            llMaterial.Add(oeMaterial)
                            utcListadosMateriales.Tabs(1).Selected = True
                        Case "C"
                            oeCotizacionDetalle = New e_CotizacionDetalleMat
                            oeCotizacionDetalle.TipoOperacion = ""
                            oeCotizacionDetalle.Id = oeOrdComp.IdCotizacionDetalle
                            oeCotizacionDetalle = olCotizacionDetalle.Obtener(oeCotizacionDetalle)
                            llCotizacionDetalle.Add(oeCotizacionDetalle)
                            utcListadosMateriales.Tabs(2).Selected = True
                    End Select
                End If
            End If
            Return oeOrdComp.Seleccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AsignarRequerimientoOrdenCompra()
        'recalcularIgvETotales()
        For Each oeReqMat As e_RequerimientoMaterial In llRequerimientoMaterial.Where(Function(item) item.Seleccion)
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial()
            With oeOrdenCompraMaterial
                .IdRequerimientoMaterial = oeReqMat.Id
                .CodigoRequerimiento = oeReqMat.CodigoRequerimiento
                .Seleccion = False 'llMaterial.Item(i).Seleccion
                .IndicadorIgv = True
                .Activo = True
                .IdMaterial = oeReqMat.IdMaterial
                .CodigoMaterial = oeReqMat.CodigoMaterial
                .CantidadMaterial = oeReqMat.Cantidad
                .CantidadMaterial = oeReqMat.CantidadPorAtender - oeReqMat.StockActual
                .IdTipoUnidadMedida = oeReqMat.IdTipoUnidadMedida
                .IdUnidadMedida = oeReqMat.IdUnidadMedida
                .UnidadMedida = oeReqMat.UnidadMedida
                .Material = oeReqMat.Material
                .IdAlmacen = oeReqMat.IdAlmacen
                .IdSubAlmacen = oeReqMat.IdSubAlmacen
                .Almacen = oeReqMat.Almacen
                .IdArea = oeReqMat.IdArea
                .Area = oeReqMat.Area
                .Glosa = oeReqMat.Glosa
                .IdCentroCosto = oeReqMat.IdCentroCosto
                .CantidadMaterialPendiente = .CantidadMaterial - .CantidadMaterialAAtender
                .PrecioUnitario = oeReqMat.Precio
                .CostoUnitario = Math.Round(oeReqMat.Precio / (1 + oeIGV.Porcentaje), 4)
                .PrecioUnitarioSolesSinImp = .CostoUnitario
                .PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                .TipoOrdenCompra = "RM"
                cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)

        Next
        EjecutarCalculosComunes()
        llRequerimientoMaterial.RemoveAll(AddressOf eliminaRequerimientoMaterial)
        griListaRequerimientos.DataBind()
    End Sub

    Public Sub CalcularSubtotalesTotalesMaterial()
        'Dim Igv As Double = 0
        totalConIgv = 0
        txtSubTotal.Value = 0
        txtIGV.Value = 0
        txtTotal.Value = 0
        Dim flag As Boolean = False
        If llOrdenCompraMaterial.Count > 0 Then
            For Each oeDetalleOC As e_OrdenCompraMaterial In llOrdenCompraMaterial
                If cboMoneda.Text = "DOLARES" Then
                    oeDetalleOC.CostoUnitario = oeDetalleOC.PrecioUnitarioDolaresSinImp
                Else
                    oeDetalleOC.CostoUnitario = oeDetalleOC.PrecioUnitarioSolesSinImp
                End If
                If oeDetalleOC.IndicadorIgv Then
                    flag = True
                    oeDetalleOC.PrecioTotal = Math.Round(oeDetalleOC.CantidadMaterial * Math.Round(oeDetalleOC.PrecioUnitario, 5), 4)
                Else
                    oeDetalleOC.PrecioTotal = Math.Round(oeDetalleOC.CantidadMaterial * oeDetalleOC.PrecioUnitario, 4)
                End If
                totalConIgv += oeDetalleOC.PrecioTotal
            Next
            txtTotal.Value = Math.Round(totalConIgv, 4)
            If flag Then
                txtSubTotal.Value = Math.Round(totalConIgv / (oeIGV.Porcentaje + 1), 4)
                txtIGV.Value = Math.Round(txtTotal.Value - txtSubTotal.Value, 4)
            Else
                txtIGV.Value = 0
                txtSubTotal.Value = txtTotal.Value
            End If
        End If
    End Sub

    Private Sub AsignarMaterialOrdenCompra()
        For Each oeMat As e_Material In llMaterial.Where(Function(item) item.Seleccion)
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial()
            With oeOrdenCompraMaterial
                .TipoOperacion = "I"
                .IdRequerimientoMaterial = "" 'oeReqMat.Id
                .CodigoRequerimiento = "" 'oeReqMat.CodigoRequerimiento
                .Seleccion = False 'llMaterial.Item(i).Seleccion
                .IndicadorIgv = True
                .Activo = True
                .IdMaterial = oeMat.Id
                .CodigoMaterial = oeMat.Codigo
                .CantidadMaterial = 1
                .IdUnidadMedida = oeMat.IdUnidadMedida
                .IdTipoUnidadMedida = oeMat.IdTipoUnidadMedida
                .UnidadMedida = oeMat.UnidadMedida
                .Material = oeMat.Nombre
                .IdAlmacen = oeMat.IdAlmacen
                .IdSubAlmacen = oeMat.IdSubAlmacen
                .Almacen = oeMat.Almacen
                .IdArea = oeArea.Id
                .Area = oeArea.Nombre
                .Glosa = oeMat.Glosa
                .IdCentroCosto = "" 'oeMat.IdCentroCosto
                .CantidadMaterialPendiente = .CantidadMaterial - .CantidadMaterialAAtender
                .CostoUnitario = oeMat.Precio
                .PrecioUnitario = Math.Round(oeMat.Precio * (1 + oeIGV.Porcentaje), 4)
                .PrecioUnitarioSolesSinImp = oeMat.Precio
                .PrecioUnitarioDolaresSinImp = Math.Round(oeMat.Precio / cambioMon, 4)
                '.CodigoNombre = oeMat.CodigoNombre
                .TipoOrdenCompra = "M"
                cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)
        Next
        EjecutarCalculosComunes()
        llMaterial.RemoveAll(AddressOf eliminaMaterial)
        griListaMateriales.DataBind()
        griListaMateriales.Rows.ExpandAll(True)
    End Sub

    Private Sub AsignarCotizacionesOrdenCompra()
        For Each oeCotDet As e_CotizacionDetalleMat In llCotizacionDetalle.Where(Function(item) item.Seleccion)
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial()
            With oeOrdenCompraMaterial
                .IdRequerimientoMaterial = "" 'oeReqMat.Id
                .CodigoRequerimiento = "" 'oeReqMat.CodigoRequerimiento
                .Seleccion = False 'llMaterial.Item(i).Seleccion
                .IndicadorIgv = True
                .Activo = True
                .IdMaterial = oeCotDet.IdMaterial
                .CodigoMaterial = oeCotDet.CodigoMaterial
                .CantidadMaterial = oeCotDet.Cantidad
                .IdTipoUnidadMedida = oeCotDet.IdTipoUnidadMedida
                .IdUnidadMedida = oeCotDet.IdUnidadMedida
                .UnidadMedida = oeCotDet.UnidadMedida
                .Material = oeCotDet.Material
                .IdSubAlmacen = oeCotDet.IdSubAlmacen
                .IdAlmacen = oeCotDet.IdAlmacen
                .Almacen = oeCotDet.Almacen
                .IdArea = oeArea.Id
                .Area = oeArea.Nombre
                .Glosa = "" 'oeCotDet.Glosa
                .IdCentroCosto = "" 'oeMat.IdCentroCosto
                .CantidadMaterialPendiente = .CantidadMaterial
                .PrecioUnitario = oeCotDet.Precio
                .CostoUnitario = Math.Round(oeCotDet.Precio / (1 + oeIGV.Porcentaje), 4)
                .PrecioUnitarioSolesSinImp = .CostoUnitario
                .PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                .IdCotizacionDetalle = oeCotDet.Id
                .TipoOrdenCompra = "C"
                cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)
        Next
        EjecutarCalculosComunes()
        llCotizacionDetalle.RemoveAll(AddressOf eliminaCotizaciones)
        griListadoCotizacionDetalle.DataBind()
    End Sub

    Private Sub EjecutarCalculosComunes()
        CalcularSubtotalesTotalesMaterial()
        gridDetalleOCMaterial.DataBind()
        llenaCombosGrillaOrdenMaterial()
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

    Public Sub ListarMateriales(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not String.IsNullOrEmpty(Trim(txtBuscarMateriales.Text)) Then
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Tipo = 1
                txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
                If Not chkBuscaCodigo.Checked Then
                    oeMaterial.Nombre = txtBuscarMateriales.Text
                    oeMaterial.Codigo = String.Empty
                Else
                    oeMaterial.Nombre = String.Empty
                    oeMaterial.Codigo = txtBuscarMateriales.Text
                End If
                llMaterial = olMaterial.Listar_(oeMaterial)
                '-----

                With griListaMateriales
                    .DataSource = llMaterial
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                End With
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Throw ex
        End Try
    End Sub

    Public Sub AprobarOrdenesCompra()
        Try
            Editar()
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
            lbl_etiqueta.Text = "Aprobando OC"
            lbl_etiqueta.Visible = 1
            controlaColumnasGriDetOC(0, True, True, False, 0, 3)
            oeOrdenCompra.TipoOperacion = "1"
            oeOrdenCompra.IdTrabajador = gUsuarioSGI.IdTrabajador
            txtCodBarras.ReadOnly = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AtenderOrdenesCompra()
        Try
            lbl_etiqueta.Text = "Atendiendo OC"
            lbl_etiqueta.Visible = 1
            InicializarListasOrdenIngreso()
            controlaColumnasGriDetOC(0, False, False, False, 0)
            ficDetalleOCMateriales.Tabs(0).Selected = True
            ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 1, 0, 0, 1)
            MostrarTabs(0, FichaTop, 1)
            Operacion = "Editar"
            btnTerminarOC.Enabled = True
            If VerificarRegistroEditado() Then
                If EditarOrdenCompra() Then
                    GuardarRegistroEditado()
                    oeOrdenCompra.TipoOperacion = "3"
                    ControlBoton(0, 0, 0, 0, 1, 0, 1, 0, 0)
                    Me.txtCodBarras.ReadOnly = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub RechazarOrdenCompra()
        Dim formulario As New frm_RechazarOrdenCompra
        Dim idOrdCom As String = griListaOrdenCompra.ActiveRow.Cells("Id").Value.ToString
        Dim NroOrden As String = griListaOrdenCompra.ActiveRow.Cells("NroOrden").Value.ToString
        formulario.Listar(idOrdCom, NroOrden)
        formulario.ShowDialog()
    End Sub

    Public Sub ControlarEstadoOrden()
        btnAtenderOC.Enabled = 0 : btnAprobar.Enabled = 0 : btnHistorial.Enabled = 0 : btnBloquear.Enabled = 0 : btnRechazar.Enabled = 0 : btnCambiarEstado.Enabled = 0 : btnEliminarOrden.Enabled = 0
        If griListaOrdenCompra.ActiveRow.Index > -1 Then
            Select Case griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value
                Case gNombreEstadoOrdenGenerada
                    btnAprobar.Enabled = 1
                    btnRechazar.Enabled = 1
                    btnEliminarOrden.Enabled = 1
                Case gNombreEstadoOrdenPreEvaluada
                    btnAprobar.Enabled = 1
                    btnRechazar.Enabled = 1
                    btnCambiarEstado.Enabled = 1
                Case gNombreEstadoOrdenRechazada
                    btnAprobar.Enabled = 1
                Case gNombreEstadoOrdenEvaluada, gNombreEstadoOrdenAtendidoParcialmente
                    If griListaOrdenCompra.ActiveRow.Cells("NombreSubEstado").Value = "APROBADA" Then
                        btnAtenderOC.Enabled = IIf(griListaOrdenCompra.ActiveRow.Cells("IndicadorConsignacion").Value, 0, 1)
                    End If
                    If griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoOrdenEvaluada Then
                        btnCambiarEstado.Enabled = 1
                    End If
            End Select
        End If
    End Sub

    Public Sub ControlarEstadoOrdenIngreso()
        Try
            Dim swGenerarOI As Boolean = 0
            Dim swGenerarDoc As Boolean = 0
            If llDetalleOrdenIngreso.Count > 0 Then swGenerarDoc = 1
            'griListaOrdenCompra.Rows.Count
            If llOrdenIngreso.Count > 0 AndAlso ficDetalleOCMateriales.SelectedTab.Index = 1 Then
                If griListaOrdenCompra.ActiveRow.Index > -1 And griListaOrdenIngreso.ActiveRow.Index > -1 Then
                    If IsDBNull(griListaOrdenIngreso.ActiveRow.Cells("EstadoOrden").Value) Then
                        ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, 0, 0, 0, 0)
                    Else
                        Select Case griListaOrdenIngreso.ActiveRow.Cells("EstadoOrden").Value
                            Case gNombreEstadoOrdenGenerada
                                ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, swGenerarOI, 0, swGenerarDoc, 0)
                                If Not String.IsNullOrEmpty(griListaOrdenIngreso.ActiveRow.Cells("IdDocumento").Value.ToString.Trim) Then
                                    ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, swGenerarOI, 1, 0, 0)
                                End If
                            Case gNombreEstadoOrdenRecepcionado
                                ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, swGenerarOI, 0, 0, 0)
                            Case gNombreEstadoOrdenTerminada
                                ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, swGenerarOI, 0, 0, 0)
                        End Select
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InicializaOrdenesOCporOS()
        oeOrdenCompra.TipoOperacion = "I"
        oeOrdenCompra.PrefijoID = gs_PrefijoIdSucursal '@0001
        TipoOC = "MATERIAL"
        Operacion = "RegistrarOCporOS"
        oeOrdenCompra.IndicadorConsignacion = True
        controlaColumnasGriDetOC(4, True, True, False, 4)
        MostrarTabs(1, ficOrdenCompra, 1)
        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)

        'Obtener la información del área del usuario        
        oeUsuario.Id = gUsuarioSGI.Id
        oeUsuario = olUsuario.Obtener(oeUsuario)
        oeArea = olUsuario.Area(oeUsuario)

        ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
    End Sub

    Public Sub GenerarOCporOS(ByVal llDetalleOS As List(Of e_OrdenMaterial), ByVal IdProveedor As String)
        Try
            Inicializar()
            InicializaOrdenesOCporOS()
            Dim idmat As String = ""
            Dim oeOCMaterial_OSMaterial As New e_OCMaterial_OSMaterial
            Dim lstAux As New List(Of e_OrdenMaterial)
            txtEstado.Value = _Estado
            txtObservaciones.Value = String.Empty
            txtNumeroOrden.Value = String.Empty
            oeIGV = olIGV.IGV(fecFechaActual.Value)
            ListarProveedores(cboProveedor, IdProveedor, 0)
            cboProveedor.Value = IdProveedor
            lstAux = llDetalleOS.OrderBy(Function(item) item.IdMaterial).ToList
            For Each obj As e_OrdenMaterial In lstAux
                oeOrdenCompraMaterial = New e_OrdenCompraMaterial
                With oeOrdenCompraMaterial
                    If idmat <> obj.IdMaterial Then
                        idmat = obj.IdMaterial
                        .IndicadorIgv = True
                        .CodigoMaterial = obj.CodigoMaterial
                        .IdMaterial = obj.IdMaterial
                        .Material = obj.Material
                        .CantidadMaterial = lstAux.Where(Function(item) item.IdMaterial = idmat).Sum(Function(item) item.CantidadMaterial)
                        .CantidadMaterialPendiente = .CantidadMaterial
                        '.PrecioUnitario = obj.PrecioUnitario
                        .CostoUnitario = .CostoUnitario
                        .PrecioUnitarioSolesSinImp = .CostoUnitario
                        .PrecioUnitarioDolaresSinImp = Math.Round(.PrecioUnitarioSolesSinImp / cambioMon, 4)
                        .IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                        .PrecioTotal = .CantidadMaterial * .CostoUnitario
                        .IdUnidadMedida = obj.IdUnidadMedida
                        .UnidadMedida = obj.UnidadMedida
                        .IdAlmacen = obj.IdAlmacen
                        .Almacen = obj.Almacen
                        .IdSubAlmacen = obj.IdSubAlmacen
                        .IdArea = oeArea.Id 'goeUsuario.IdArea 
                        .Area = oeArea.Nombre 'goeUsuario.Area
                        .IdOrdenSalidaMaterial = obj.Id
                        cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                        llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)
                    End If
                End With
            Next
            For Each ordmat As e_OrdenMaterial In lstAux
                For Each ordcommat As e_OrdenCompraMaterial In llOrdenCompraMaterial
                    If ordmat.IdMaterial = ordcommat.IdMaterial Then
                        oeOCMaterial_OSMaterial = New e_OCMaterial_OSMaterial
                        oeOCMaterial_OSMaterial.IdOrdenAsociada = ordmat.Id
                        oeOCMaterial_OSMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                        ordcommat.ListaOCMaterial_OSMaterial.Add(oeOCMaterial_OSMaterial)
                    End If
                Next
            Next
            gridDetalleOCMaterial.DataSource = llOrdenCompraMaterial
            gridDetalleOCMaterial.DataBind()
            llenaCombosGrillaOrdenMaterial()
            CalcularSubtotalesTotalesMaterial()
            gridDetalleOCMaterial.DataBind()
            gridDetalleOCMaterial.Rows.ExpandAll(True)
            ficDetalleOCMateriales.Tabs(1).Enabled = 0
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.NoEdit
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = CellClickAction.RowSelect
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioTotal").CellClickAction = CellClickAction.RowSelect
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarCotizaciones()
        Try
            oeCotizacionDetalle = New e_CotizacionDetalleMat
            oeCotizacionDetalle.FechaInicio = rfFechaCotDesde.Value
            oeCotizacionDetalle.FechaFinal = rfFechaCotHasta.Value
            'oeCotizacionDetalle.IdProveedor = cboProveedorCot.Value
            oeCotizacionDetalle.TipoOperacion = "A"
            ValidarFechaDesde_Hasta(rfFechaCotDesde, rfFechaCotHasta)
            llCotizacionDetalle = olCotizacionDetalle.Listar(oeCotizacionDetalle)
            '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
            If llOrdenCompraMaterial.Count > 0 Then
                llCotizacionDetalle.RemoveAll(AddressOf eliminaCotDet)
                griListadoCotizacionDetalle.DataBind()
            End If
            '--------------------------------------------------------------------------------------------------------------                 
            griListadoCotizacionDetalle.DataSource = llCotizacionDetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function eliminaCotDet(ByVal oeCot As e_CotizacionDetalleMat) As Boolean
        For Each filaOrdenMaterial As e_OrdenCompraMaterial In llOrdenCompraMaterial
            If (oeCot.Id = filaOrdenMaterial.IdCotizacionDetalle) Then
                Return True
            End If
        Next
    End Function

    Public Function MaximaPosicionMaterial() As Integer
        Dim mayor As Integer = 0
        Dim list As New List(Of Integer)()
        For Each detalle As e_OrdenCompraMaterial In llOrdenCompraMaterial
            If detalle.Pos > mayor Then mayor = detalle.Pos
        Next
        Return mayor 'llOrdenCompraMaterial.Max().Pos
    End Function

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

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String, ByVal ind As Boolean) As String
        Try
            Dim oeCombo As New e_Combo
            oeCombo.Id = idMaterial
            oeCombo.Nombre = idAlmacen
            oeCombo.Tipo = 3
            If MatPreSubAlmPublic.Contains(oeCombo) Then
                oeCombo = MatPreSubAlmPublic.Item(MatPreSubAlmPublic.IndexOf(oeCombo))
            Else
                Return 0
            End If
            If ind Then
                Return CDbl(oeCombo.Descripcion) * (1 + oeIGV.Porcentaje)
            Else
                Return CDbl(oeCombo.Descripcion)
            End If
        Catch ex As Exception
            Throw ex
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
            CalcularSubtotalesTotalesMaterial()
            gridDetalleOCMaterial.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarOI()
        Try
            If oeOrdenCompra.TipoOperacion <> "3" Then
                Throw New Exception("La orden de compra no esta lista para ser atendida.")
            End If
            Guardar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EjecutarOI()
        Try
            Dim oePeriodo As New e_Periodo
            Dim olPeriodo As New l_Periodo
            Dim fechaactual As Date = ObtenerFechaServidor.Date
            oePeriodo.Ejercicio = fechaactual.Year
            oePeriodo.Mes = fechaactual.Month
            oePeriodo = olPeriodo.Obtener(oePeriodo)
            oeOrdenIngreso = New e_Orden
            Dim idTipoDocumento As String = ""
            Dim referencia As String = ""
            oeOrdenIngreso.Id = griListaOrdenIngreso.ActiveRow.Cells("Id").Value.ToString
            idTipoDocumento = griListaOrdenIngreso.ActiveRow.Cells("IdSubAlmacenOrigen").Value.ToString
            referencia = griListaOrdenIngreso.ActiveRow.Cells("IdSubAlmacenDestino").Value.ToString & "/" & griListaOrdenIngreso.ActiveRow.Cells("SerieNumero").Value.ToString
            oeOrdenIngreso = olOrdenIngreso.Obtener(oeOrdenIngreso)
            oeOrdenIngreso.TipoOperacion = "T"
            oeOrdenIngreso.lstOrdenMaterial = llDetalleOrdenIngreso
            oeOrdenIngreso.IdUsuarioEjecucion = gUsuarioSGI.Id
            oeOrdenIngreso.loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
            If idTipoDocumento = "1CH000000027" Then
                oeOrdenIngreso.IndAsiento = True
                oeOrdenIngreso.NombreProveedor = oeOrdenCompra.NombreProveedor
                oeOrdenIngreso.loAsientoModelo = New List(Of e_AsientoModelo)
                ObtenerAsientoModelo(idTipoDocumento, oePeriodo.Ejercicio)
                LlenaCuenta(oePeriodo.Ejercicio)
                oeOrdenIngreso.IdPeriodo = oePeriodo.Id
                oeOrdenIngreso.TipoCambio = TipoCambio(fechaactual, True)(0)
                oeOrdenIngreso.Glosa = referencia
            End If
            oeOrdenIngreso.lstInventario = New List(Of e_Inventario)
            oeOrdenIngreso.lstInventario.AddRange(Inventario(oeOrdenIngreso.lstOrdenMaterial))
            oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOrdenIngreso.Guardar(oeOrdenIngreso, New List(Of e_RegistroInventario)) 'Cambiamos el estado de la orden de ingreso de GENERADA a TERMINADA
            Dim IdOrdIngreso As String = oeOrdenIngreso.Id
            'listaRegistroInventario = New List(Of e_RegistroInventario)
            'listaInventario = New List(Of e_Inventario)
            'TransponerRegistroInv()
            'olRegistroInventario.Guardar(listaRegistroInventario) 'Registramos los movimientos generados por el ingreso de material
            InicializarListasOrdenIngreso() 'Limpio las grillas de ordenes de ingreso(Cabezera y detalle)
            listarOrdenIngreso(True) 'Listo nuevamente en mi formulario las ordenes de ingreso y verifico que una orden de ingreso debería haber pasado de estado GENERADA a TERMINADA.
            'If MessageBox.Show("Desea Imprimir el Registro de Ingreso?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
            '    ImprimirOI(IdOrdIngreso)
            'End If
            mensajeEmergente.Confirmacion("La orden de ingreso se ha ejecutado correctamente.", True)
            ControlBoton(0, 0, 0, 0, 1, 0, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GenerarDocumento(ByVal ls_TipoDocumento As String)
        Try
            Select Case ls_TipoDocumento
                Case "FACTURA"
                    oeOrdenIngreso = New e_Orden
                    With griListaOrdenIngreso
                        oeOrdenIngreso.Id = .ActiveRow.Cells("Id").Value
                    End With
                    oeOrdenIngreso = olOrdenIngreso.Obtener(oeOrdenIngreso)
                    oeOrdenIngreso.IdOrdenCompra = oeOrdenCompra.Id
                    Dim frm As New frm_FacturaCompra
                    frm = frm.getInstancia()
                    With frm
                        .MdiParent = frm_Menu
                        .TrasponerOrdenDocumento(oeOrdenIngreso, oeOrdenCompra)
                        .Show()
                    End With
                Case "GUIA"
                    oeOrdenIngreso = New e_Orden
                    With griListaOrdenIngreso
                        oeOrdenIngreso.Id = .ActiveRow.Cells("Id").Value
                    End With
                    oeOrdenIngreso = olOrdenIngreso.Obtener(oeOrdenIngreso)
                    oeOrdenIngreso.IdOrdenCompra = oeOrdenCompra.Id
                    Dim frm As New frm_GuiaRemisionRemitente
                    frm = frm.getInstancia()
                    With frm
                        .MdiParent = frm_Menu
                        .Show()
                        .TrasponerOrdenGuia(oeOrdenIngreso)
                    End With
                Case "BOLETA"
                    oeOrdenIngreso = New e_Orden
                    With griListaOrdenIngreso
                        oeOrdenIngreso.Id = .ActiveRow.Cells("Id").Value
                    End With
                    oeOrdenIngreso = olOrdenIngreso.Obtener(oeOrdenIngreso)
                    oeOrdenIngreso.IdOrdenCompra = oeOrdenCompra.Id
                    Dim frm As New frm_BoletaCompra
                    frm = frm.getInstancia()
                    With frm
                        .MdiParent = frm_Menu
                        .TrasponerOrdenDocumento(oeOrdenIngreso)
                        .Show()
                    End With
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImprimirOI(IdOrdenIngreso As String)
        Dim id As String = ""
        Try
            Dim formulario As New frm_ImprimirOrden
            id = IdOrdenIngreso
            formulario.CargarDatos(id)
            formulario.ShowDialog()
            ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Inventario(lo As List(Of e_OrdenMaterial)) As List(Of e_Inventario)
        Try
            Dim loInventario As New List(Of e_Inventario)
            Dim FechaActual As Date = ObtenerFechaServidor()
            For Each oe As e_OrdenMaterial In lo
                oeInventario = New e_Inventario
                With oeInventario
                    .FechaCreacion = FechaActual
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .CantidadIngreso = oe.CantidadMaterial
                    If oe.IndicadorIgv Then
                        .ValorUnitario = Math.Round(oe.PrecioUnitario / (1 + oeIGV.Porcentaje), 4)
                    Else
                        .ValorUnitario = oe.PrecioUnitario
                    End If
                    .ValorAdm = oe.CostoAdm
                    If oeOrdenCompra.IdMoneda = "1CH02" Then
                        If txtTC.Value = 0 Then Throw New Exception("Verificar Tipo de Cambio")
                        .ValorUnitario = Math.Round(.ValorUnitario * txtTC.Value, 4)
                    End If
                    .Usuario = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeRegistroInventario = New e_RegistroInventario
                With oeRegistroInventario
                    .TipoOperacion = "I"
                    .IdMaterial = oe.IdMaterial
                    .IdSubAlmacen = oe.IdSubAlmacen
                    .IdMovimientoInventario = oeOrdenIngreso.IdMovimientoInventario
                    .IdUnidadMedida = oe.IdUnidadMedida
                    .Cantidad = oe.CantidadMaterial
                    .ValorAdm = oe.CostoAdm
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .PrefijoID = gs_PrefijoIdSucursal '@0001
                End With
                oeInventario.oeRegistroInventario = New e_RegistroInventario
                oeInventario.oeRegistroInventario = oeRegistroInventario
                loInventario.Add(oeInventario)
            Next
            Return loInventario
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ConsultarDetalle(ByVal estadoPanel As Boolean)
        gbeListadoMateriales.Expanded = estadoPanel
        llenaGrillaReqMat(True)
        txtBuscarMateriales.Value = String.Empty
    End Sub

    Sub AgregarDetalle()
        Try
            gbeListadoMateriales.Expanded = False
            Select Case utcListadosMateriales.SelectedTab.Key
                Case 0
                    AsignarRequerimientoOrdenCompra()
                Case 1
                    AsignarMaterialOrdenCompra()
                Case 2
                    AsignarCotizacionesOrdenCompra()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImportarArchivoExcel()
        Try
            Dim oeComboMaterial As e_Combo
            Dim oeComboAlmacen As e_Combo
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""

                'objXls = New Excel.Application
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)

                For ln_Fila As Integer = 1 To 100
                    If Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing Then

                        oeComboMaterial = New e_Combo
                        oeComboMaterial.Tipo = 1
                        oeComboMaterial.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                        If MatGeneralPublic.Contains(oeComboMaterial) Then
                            oeComboMaterial = MatGeneralPublic.Item(MatGeneralPublic.IndexOf(oeComboMaterial))
                        End If

                        oeComboAlmacen = New e_Combo
                        oeComboAlmacen.Tipo = 2
                        oeComboAlmacen.Descripcion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value)
                        If AlmNombrePublic.Contains(oeComboAlmacen) Then
                            oeComboAlmacen = AlmNombrePublic.Item(AlmNombrePublic.IndexOf(oeComboAlmacen))
                        End If
                        oeOrdenCompraMaterial = New e_OrdenCompraMaterial()
                        With oeOrdenCompraMaterial
                            .TipoOperacion = "I"
                            .IdRequerimientoMaterial = "" 'oeReqMat.Id
                            .CodigoRequerimiento = "" 'oeReqMat.CodigoRequerimiento
                            .Seleccion = False 'llMaterial.Item(i).Seleccion
                            .Activo = True
                            .IdMaterial = oeComboMaterial.Id
                            .CodigoMaterial = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value)
                            .Material = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                            If oeComboMaterial.Descripcion.Length > 0 Then
                                .IdUnidadMedida = oeComboMaterial.Descripcion.Substring(12)
                                .IdTipoUnidadMedida = oeComboMaterial.Descripcion.Substring(0, 12)
                            End If
                            .UnidadMedida = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                            .CantidadMaterial = Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                            .IndicadorIgv = Convert.ToBoolean(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                            .CostoUnitario = Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 1, 7).Value)
                            .PrecioUnitario = Convert.ToDouble(objWorkSheet.Cells(ln_Fila + 1, 8).Value)
                            .IdAlmacen = oeComboAlmacen.Id.Trim
                            .IdSubAlmacen = oeComboAlmacen.Nombre.Trim
                            .Almacen = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 10).Value)
                            .IdArea = gUsuarioSGI.oeArea.Id
                            .Area = gUsuarioSGI.oeArea.Nombre
                            .Glosa = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 12).Value)
                            .IdCentroCosto = "" 'oeMat.IdCentroCosto
                            .CantidadMaterialPendiente = .CantidadMaterial
                            .PrecioUnitarioSolesSinImp = .CostoUnitario
                            .PrecioUnitarioDolaresSinImp = Math.Round(.CostoUnitario / cambioMon, 4)
                            .TipoOrdenCompra = "M"
                            cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                        End With
                        llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)

                    Else
                        Exit For
                    End If
                Next
                EjecutarCalculosComunes()
                gridDetalleOCMaterial.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing
                objWorkSheet = Nothing
                objWorkbook = Nothing
                objXls = Nothing
            Else
                OpenFileDialog1.Dispose()
            End If
            gbeListadoMateriales.Expanded = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TerminarOC()
        Try
            Dim oeOrdCom As New e_OrdenCompra
            Dim olOrdCom As New l_OrdenCompra
            Dim loOrdComMat As New List(Of e_OrdenCompraMaterial)
            loOrdComMat = gridDetalleOCMaterial.DataSource
            For Each material As e_OrdenCompraMaterial In loOrdComMat
                If material.CantidadMaterialPendiente <> 0 Then Throw New Exception("Tiene Materiales Pendientes x Atender")
            Next
            If griListaOrdenIngreso.Rows.Count > 0 Then
                Dim oeOrdDoc As New e_Orden_Documento
                Dim olOrdDoc As New l_Orden_Documento
                For Each fila As UltraGridRow In griListaOrdenIngreso.Rows
                    If fila.Cells("EstadoOrden").Value = gNombreEstadoOrdenGenerada Then Throw New Exception("No Puede Terminar Orden sin Ejecutar OI")
                Next
                For Each fila As UltraGridRow In griListaOrdenIngreso.Rows
                    oeOrdDoc = New e_Orden_Documento
                    oeOrdDoc.IdOrden = fila.Cells("Id").Value
                    oeOrdDoc.TipoOperacion = "X"
                    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                    If oeOrdDoc.IdTipoDocumento = "" Then Throw New Exception("No Puede Terminar Orden sin Documento Contable Asociado")
                Next
            Else
                Throw New Exception("No Puede Terminar Ordenes de Compra sin Documentos Asociados")
            End If
            oeOrdCom.Id = oeOrdenCompra.Id
            oeOrdCom.TipoOperacion = "O"
            oeOrdCom.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olOrdCom.Guardar1(oeOrdCom) Then
                mensajeEmergente.Confirmacion("Se Termino la Orden: " & txtNumeroOrden.Text & " Correctamente", True)
                btnTerminarOC.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeOrdCom As New e_OrdenCompra
            oeOrdCom.Id = griListaOrdenCompra.ActiveRow.Cells("Id").Value
            oeOrdCom.TipoOperacion = "3"
            oeOrdCom = olOrdenCompra.Obtener(oeOrdCom)
            If oeOrdCom.IdTipoOrdenCompra <> "" Then
                If oeOrdCom.IdTrabajadorAprobacion <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información de la Orden de Compra no es accesible pues esta siendo editado por el Usuario: " & Environment.NewLine & _
                                                  oeOrdCom.IdTrabajadorAprobacion & Environment.NewLine & _
                                        "desde: " & oeOrdCom.FechaOrden & Environment.NewLine & _
                                        "en la Sucursal: " & oeOrdCom.IdCentro, True)
                    Return False
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeOrdCom.IdTipoOrdenCompra
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeOrdCom.FechaOrden)
                        .PrefijoID = gs_PrefijoIdSucursal '@0001
                    End With
                    olRegistroEditado.Guardar(oeRegistroEditado)
                    RegistroEditado = 1
                End If
            Else
                RegistroEditado = 1
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub GuardarRegistroEditado()
        If RegistroEditado = 1 Then
            oeRegistroEditado = New e_RegistrosEditados
            With oeRegistroEditado
                .IdRegistro = griListaOrdenCompra.ActiveRow.Cells("Id").Value()
                .Referencia = "OrdenCompra"
                .UsuarioEdita = gUsuarioSGI.Id
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
        End If
    End Sub

    Public Sub VerificarPermiso()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "APROBAR ORDENES DE COMPRA") Then
                AprobarOrdenesCompra()
            Else
                Throw New Exception("No Tiene Permiso para Aprobar Ordenes de Compra")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsignarMaterialCodigo(IdMaterial As String)
        Try
            Dim oeMat As New e_Material
            oeOrdenCompraMaterial = New e_OrdenCompraMaterial()
            oeMat.Id = IdMaterial
            oeMat.TipoOperacion = "5"
            oeMat.Tipo = 1
            oeMat.IdCentro = ObtenerCentro(gs_PrefijoIdSucursal).Abreviatura
            oeMat = olMaterial.Obtener_(oeMat)
            With oeOrdenCompraMaterial
                .TipoOperacion = "I"
                .IdRequerimientoMaterial = ""
                .CodigoRequerimiento = ""
                .Seleccion = False
                .IndicadorIgv = True
                .Activo = True
                .IdMaterial = oeMat.Id
                .CodigoMaterial = oeMat.Codigo
                .CantidadMaterial = 1
                .IdUnidadMedida = oeMat.IdUnidadMedida
                .IdTipoUnidadMedida = oeMat.IdTipoUnidadMedida
                .UnidadMedida = oeMat.UnidadMedida
                .Material = oeMat.Nombre
                .IdAlmacen = oeMat.IdAlmacen
                .IdSubAlmacen = oeMat.IdSubAlmacen
                .Almacen = oeMat.Almacen
                .IdArea = oeArea.Id
                .Area = oeArea.Nombre
                .Glosa = oeMat.Glosa
                .IdCentroCosto = ""
                .CantidadMaterialPendiente = .CantidadMaterial - .CantidadMaterialAAtender
                .CostoUnitario = oeMat.Precio
                .PrecioUnitario = Math.Round(oeMat.Precio * (1 + oeIGV.Porcentaje), 4)
                .PrecioUnitarioSolesSinImp = oeMat.Precio
                .PrecioUnitarioDolaresSinImp = Math.Round(oeMat.Precio / cambioMon, 4)
                .TipoOrdenCompra = "M"
                cont = MaximaPosicionMaterial() : cont += 1 : .Pos = cont
                .PrefijoID = gs_PrefijoIdSucursal '@0001
            End With
            llOrdenCompraMaterial.Add(oeOrdenCompraMaterial)
            EjecutarCalculosComunes()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AtenderMateriales(IdMaterial As String)
        Try
            Dim flag As Boolean = False
            For Each ord_mat As e_OrdenCompraMaterial In llOrdenCompraMaterial
                If ord_mat.IdMaterial = IdMaterial Then
                    flag = True
                End If
            Next
            If Not flag Then
                Throw New Exception("Material no Encontrado en la Orden de Compra")
            End If
            With gridDetalleOCMaterial
                If .Rows.Count > 0 Then
                    For i = 0 To .Rows.Count - 1
                        If Trim(.Rows(i).Cells("IdMaterial").Value) = IdMaterial And .Rows(i).Cells("CantidadMaterialPendiente").Value > 0 Then
                            .DisplayLayout.Rows(i).Cells("Material").Appearance.BackColor = Color.Khaki
                            .DisplayLayout.Rows(i).Cells("CodigoMaterial").Appearance.BackColor = Color.Khaki
                            .Rows(i).Cells("CantidadMaterialAAtender").Value = .Rows(i).Cells("CantidadMaterialPendiente").Value
                        End If
                    Next
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

    Private Sub ControlBotonesOC()
        Try
            Select Case Operacion
                Case "Nuevo"
                    MyBase.Nuevo()
                    listarOrdenIngreso(1)
                Case "Editar"
                    MyBase.Editar()
                    If txtEstado.Text.Equals(gNombreEstadoOrdenEvaluada) Then
                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 1)
                        'If chkBloquea.Checked = 0 Then ControlBoton(0, 0, 0, 1, 1, 0, 1)
                        If gUsuarioSGI.IdTrabajador = oeOrdenCompra.IdTrabajadorAprobacion Then ControlBoton(0, 0, 0, 1, 1, 0, 1, 1)
                        If lbl_etiqueta.Visible And lbl_etiqueta.Text = "Atendiendo OC" Then
                            ControlBoton(0, 0, 0, 0, 1, 0, 1, 1)
                        End If
                    ElseIf txtEstado.Text.Contains("ATENDIDO") Or txtEstado.Text.Equals(gNombreEstadoOrdenTerminada) Then
                        ControlBoton(0, 0, 0, 0, 1, 0, 1, 1)
                    End If
                    listarOrdenIngreso(1)
                Case "Inicializa"
                    If (griListaOrdenCompra.Rows.Count > 0) Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 1)
                    End If
                Case "RegistrarOCporOS" 'Registro de ordenes de compra por consignación
                    InicializaOrdenesOCporOS()
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ModificarPrecios()
        Try
            With oeOrdenCompra
                .TipoBien = "MATERIAL"
                .lstOrdenMaterial = llOrdenCompraMaterial
                .SubTotal = txtSubTotal.Value
                .Impuesto = txtIGV.Value
                .Total = txtTotal.Value
                .UsuarioCreacion = gUsuarioSGI.Id
            End With
            If olOrdenCompra.ModificarPrecios(oeOrdenCompra) Then
                mensajeEmergente.Confirmacion("Los Precios Han Sido Modificados Correctamente", True)
                Consultar(True)
                MostrarTabs(0, ficOrdenCompra, 2)
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
            End If
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
                    .Tools("Generar").SharedProps.Visible = oeBoton.Generar
                    .Tools("Ejecutar").SharedProps.Visible = oeBoton.Ejecutar
                    .Tools("GenerarD").SharedProps.Visible = oeBoton.GenerarDoc
                    .Tools("Guardar").SharedProps.Visible = oeBoton.Exportar
                Else
                    .Tools("Agregar").SharedProps.Enabled = oeBoton.Guardar
                    .Tools("Eliminar").SharedProps.Enabled = oeBoton.Eliminar
                    .Tools("Generar").SharedProps.Enabled = oeBoton.Generar
                    .Tools("Ejecutar").SharedProps.Enabled = oeBoton.Ejecutar
                    .Tools("GenerarD").SharedProps.Enabled = oeBoton.GenerarDoc
                    .Tools("Guardar").SharedProps.Enabled = oeBoton.Exportar
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDetalle()
                Case "Eliminar"
                    QuitarDetalle()
                Case "Generar"
                    GenerarOI()
                Case "Ejecutar"
                    EjecutarOI()
                Case "Guardar"
                    ImportarArchivoExcel()
                Case "Generar Factura"
                    GenerarDocumento("FACTURA")
                Case "Generar Boleta"
                    GenerarDocumento("BOLETA")
                Case "Generar Guía"
                    GenerarDocumento("GUIA")
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OrdenCompra_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenCompra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_OrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'gmt_ConfigurarEventoKeyEnter_Tab(Me, cboProveedor.Name, txtBuscarMateriales.Name, btnListarMateriales.Name, txtNroOrdenCompra.Name, cboProveedorL.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            InicializaTiempo()
            IniciarFormulario()
            MostrarTabs(0, ficOrdenCompra)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_OrdenCompra_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griListaDetalleOrdenCompraMaterial_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridDetalleOCMaterial.CellChange
        Try
            gridDetalleOCMaterial.UpdateData()
            datoCambiado = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnModificarPrecios_Click(sender As Object, e As EventArgs) Handles btnModificarPrecios.Click
        Try
            If oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenAtendido Or oeOrdenCompra.EstadoOrden = gNombreEstadoOrdenTerminada Then
                ModificarPrecios()
            Else
                Throw New Exception("Solo Puede Modificar Ordenes en Estado Terminada o Atendido")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleOrdenCompraMaterial_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridDetalleOCMaterial.AfterCellUpdate
        Try
            If gridDetalleOCMaterial.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        With gridDetalleOCMaterial.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value Then
                                .Appearance.BackColor = Color.LightYellow
                                .Appearance.ForeColor = Color.Red
                            Else
                                .Appearance.BackColor = Color.White
                                .Appearance.ForeColor = Color.Black
                            End If
                        End With
                    Case "IndicadorIgv"
                        With gridDetalleOCMaterial.Rows(e.Cell.Row.Index)
                            swIgv = .Cells("IndicadorIgv").Value
                            codigoMaterial = .Cells("CodigoMaterial").Value
                            codigoRequerimiento = .Cells("CodigoRequerimiento").Value
                            posGrilla = .Cells("Pos").Value
                            If swIgv Then
                                .Cells("PrecioUnitario").Value = Math.Round(.Cells("CostoUnitario").Value * (1 + oeIGV.Porcentaje), 4, MidpointRounding.ToEven)
                            Else
                                .Cells("PrecioUnitario").Value = Math.Round(.Cells("CostoUnitario").Value, 4, MidpointRounding.ToEven)
                            End If
                            gridDetalleOCMaterial.DataBind()
                        End With
                        CalcularSubtotalesTotalesMaterial()
                    Case "CantidadMaterial"
                        With gridDetalleOCMaterial.ActiveRow
                            If .Cells("CantidadMaterial").Value < 0 Then
                                .Cells("CantidadMaterial").Value = cantmat
                                Throw New Exception("El cantidad ingresada no puede ser menor o igual a 0. ")
                            End If
                            If .Cells("CantidadMaterial").Value.Equals("") Then
                                .Cells("CantidadMaterial").Value = 1
                            End If
                            .Cells("CantidadMaterialPendiente").Value = .Cells("CantidadMaterial").Value
                        End With
                        CalcularSubtotalesTotalesMaterial()
                    Case "CantidadMaterialAAtender"
                        Dim cantPorAtender As Double
                        Dim cantAAtender As Double
                        With gridDetalleOCMaterial.ActiveRow
                            If .Index > -1 Then
                                cantAAtender = Convert.ToDouble(.Cells("CantidadMaterialAAtender").Value)
                                cantPorAtender = Convert.ToDouble(.Cells("CantidadMaterialPendiente").Value)
                                If cantAAtender > cantPorAtender Then
                                    .Cells("CantidadMaterialAAtender").Value = cantPorAtender
                                    Throw New Exception("La cantidad ingresada excede a la cantidad pendiente.")
                                End If
                            End If
                        End With
                    Case "IdAlmacen"
                        With gridDetalleOCMaterial
                            If .ActiveRow.Index > -1 Then
                                SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString, gridDetalleOCMaterial)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                oeSubAlmacen = New e_SubAlmacen
                                oeSubAlmacen.TipoOperacion = "S"
                                oeSubAlmacen.Activo = True
                                oeSubAlmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                oeSubAlmacen = olSubAlmacen.Obtener(oeSubAlmacen)
                                .ActiveRow.Cells("IdSubAlmacen").Value = oeSubAlmacen.Id
                                .ActiveRow.Cells("PrecioUnitario").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value, .ActiveRow.Cells("IndicadorIgv").Value)
                            End If
                        End With
                    Case "CostoUnitario"
                        Dim PrecioUnitario As Double = 0
                        Dim CostoUnitario As Double = 0
                        With gridDetalleOCMaterial.ActiveRow
                            swIgv = .Cells("IndicadorIgv").Value
                            CostoUnitario = .Cells("CostoUnitario").Value
                            If CostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                            If CostoUnitario > 0 Then
                                PrecioUnitario = IIf(swIgv, CostoUnitario * (oeIGV.Porcentaje + 1), CostoUnitario)
                                .Cells("PrecioUnitario").Value = PrecioUnitario
                            End If
                            If cboMoneda.Text = "DOLARES" Then
                                .Cells("PrecioUnitarioDolaresSinImp").Value = CostoUnitario
                                .Cells("PrecioUnitarioSolesSinImp").Value = CostoUnitario * cambioMon
                            Else
                                .Cells("PrecioUnitarioSolesSinImp").Value = CostoUnitario
                                .Cells("PrecioUnitarioDolaresSinImp").Value = CostoUnitario / cambioMon
                            End If
                        End With
                    Case "PrecioUnitario"
                        Dim PrecioUnitario As Double
                        Dim CostoUnitario As Double
                        With gridDetalleOCMaterial.ActiveRow
                            swIgv = .Cells("IndicadorIgv").Value
                            If .Index > -1 Then
                                PrecioUnitario = Convert.ToDouble(.Cells("PrecioUnitario").Value)
                                If PrecioUnitario < 0 Then
                                    .Cells("PrecioUnitario").Value = cantmat
                                    Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                                End If
                                CostoUnitario = Math.Round(IIf(swIgv, PrecioUnitario / (oeIGV.Porcentaje + 1), PrecioUnitario), 4)
                                If cboMoneda.Text = "DOLARES" Then
                                    .Cells("PrecioUnitarioDolaresSinImp").Value = CostoUnitario
                                    .Cells("PrecioUnitarioSolesSinImp").Value = CostoUnitario * cambioMon
                                Else
                                    .Cells("PrecioUnitarioSolesSinImp").Value = CostoUnitario
                                    .Cells("PrecioUnitarioDolaresSinImp").Value = CostoUnitario / cambioMon
                                End If
                            End If
                        End With
                        CalcularSubtotalesTotalesMaterial()
                    Case "Glosa"
                        If IsDBNull(e.Cell.Value) Then
                            e.Cell.Value = " "
                        End If
                    Case "PrecioTotal"
                        Dim PrecioTotal As Double = 0
                        With gridDetalleOCMaterial.ActiveRow
                            swIgv = .Cells("IndicadorIgv").Value
                            If .Index > -1 Then
                                PrecioTotal = Convert.ToDouble(.Cells("PrecioTotal").Value)
                                If PrecioTotal < 0 Then
                                    .Cells("PrecioTotal").Value = 1
                                    Throw New Exception("El precio total con impuesto no puede ser menor o igual a 0.")
                                End If
                                .Cells("PrecioUnitario").Value = PrecioTotal / .Cells("CantidadMaterial").Value
                            End If
                        End With
                        CalcularSubtotalesTotalesMaterial()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleOrdenCompraMaterial_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles gridDetalleOCMaterial.BeforeCellUpdate
        Try
            With gridDetalleOCMaterial
                Select Case e.Cell.Column.Key
                    Case "CantidadMaterial", "PrecioUnitario", "CostoUnitario", "CantidadMaterialPendiente", "CantidadMaterialAAtender"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                        cantmat = e.Cell.Value
                    Case "Glosa"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaRequerimientos_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaRequerimientos.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaRequerimientos.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaRequerimientos_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaRequerimientos.CellChange
        Try
            griListaRequerimientos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaDetalleOrdenCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridDetalleOCMaterial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListadoCotizacionDetalle_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoCotizacionDetalle.CellChange
        Try
            griListadoCotizacionDetalle.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListadoCotizacionDetalle_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griListadoCotizacionDetalle.BeforeCellUpdate
        With griListadoCotizacionDetalle
            Select Case e.Cell.Column.Key
                Case "Cantidad", "Precio"
                    If IsDBNull(e.NewValue) Then
                        e.Cancel = True
                        Exit Sub
                    End If
            End Select
        End With
    End Sub

    Private Sub griListadoCotizacionDetalle_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListadoCotizacionDetalle.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListadoCotizacionDetalle.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaOrdenCompra_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaOrdenCompra.DoubleClickRow
        If griListaOrdenCompra.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griListaOrdenIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenIngreso.Click
        If griListaOrdenIngreso.Selected.Rows.Count > 0 Then ListarDetalleOrdenIngreso() 'ListarOI_Detalle()
        ControlarEstadoOrdenIngreso()
    End Sub

    Private Sub griListaOrdenIngreso_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenIngreso.AfterRowActivate
        ControlarEstadoOrdenIngreso()
    End Sub

    Private Sub griListaOrdenCompra_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaOrdenCompra.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Eliminar()
        e.Cancel = True
    End Sub

    Private Sub griListaMateriales_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griListaMateriales.DisplayLayout.Bands(0).Layout.ActiveRow
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = VerdeClaro
                            .Appearance.ForeColor = Rojo
                        Else
                            .Appearance.BackColor = Blanco
                            .Appearance.ForeColor = Negro
                        End If
                    End With
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
            .DisplayLayout.GroupByBox.Style = GroupByBoxStyle.Compact
        End With
    End Sub

    Private Sub ficDetalleOCMateriales_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalleOCMateriales.SelectedTabChanged
        Try
            Dim btnAgregar As Boolean = 0
            Dim btnQuitar As Boolean = 0
            If gbeListadoMateriales.Visible Then btnAgregar = 1 : btnQuitar = 1
            Select Case ficDetalleOCMateriales.SelectedTab.Index
                Case 0
                    If oeOrdenCompra.TipoOperacion = "3" Then
                        ControlaBarraOperacionesDetalle("Enable", 0, 0, 1, 1, 0, 0, 1)
                    Else
                        ControlaBarraOperacionesDetalle("Enable", btnAgregar, btnQuitar, 0, 0, 0, 0, 1)
                    End If
                Case 1
                    ControlaBarraOperacionesDetalle("Enable", 0, 0, 0, 0, 0, 0, 0)
                    griListaOrdenIngreso.DataBind()
                    llDetalleOrdenIngreso.Clear()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaOrdenCompra_AfterRowActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaOrdenCompra.AfterRowActivate
        ControlarEstadoOrden()
    End Sub

    Private Sub btnAtenderOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtenderOC.Click
        AtenderOrdenesCompra()
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        Try
            VerificarPermiso()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales(True)
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales(True)
        End If
    End Sub

    Private Sub frm_OrdenCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            ControlBotonesOC()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub UltraTextEditor1_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs)
        gridDetalleOCMaterial.ActiveRow.Cells("CantidadMaterialAAtender").Value = gridDetalleOCMaterial.ActiveCell.Value
    End Sub

    Private Sub btnEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarCorreo.Click
        ImprimirOrdenesCompra(True)
    End Sub

    Private Sub btnBuscarCot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCot.Click
        ListarCotizaciones()
    End Sub

    Private Sub cboProveedorCot_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedorCot.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarCotizaciones()
        End If
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        ImprimirOrdenesCompra(True)
    End Sub

    Private Sub cbProveedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarProveedores(cboProveedor, "0", chkRuc.Checked)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
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

    Private Sub cbCentro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cboCentro.Enabled = IIf(cbCentro.Checked, 1, 0)
    End Sub

    Private Sub griListaDetalleOrdenCompraMaterial_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridDetalleOCMaterial.ClickCellButton
        gridDetalleOCMaterial.ActiveRow.Cells("CantidadMaterialAAtender").Value = gridDetalleOCMaterial.ActiveCell.Value
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
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CostoUnitario").Header.Caption = "Costo $"
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "Precio $"
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioTotal").Header.Caption = "Total $"
        Else
            cmdSolesDolares.Enabled = 1
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("CostoUnitario").Header.Caption = "Costo S/"
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "Precio S/"
            gridDetalleOCMaterial.DisplayLayout.Bands(0).Columns("PrecioTotal").Header.Caption = "Total S/"
        End If
        gridDetalleOCMaterial.DataBind()
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
            oeIGV = New e_Impuesto
            Dim olImp As New l_Impuesto
            oeIGV = olImp.IGV(fecFechaActual.Value)
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

    Private Sub Boton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        RechazarOrdenCompra()
        Listar(True)
    End Sub

    Private Sub griListaDetalleOrdenCompraMaterial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridDetalleOCMaterial.KeyDown
        Try
            With gridDetalleOCMaterial
                Dim int As Integer = .ActiveRow.Index
                If e.KeyCode = Keys.Down Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Or _
                    .Rows(int).Cells("CantidadMaterial").IsActiveCell Or _
                    .Rows(int).Cells("IndicadorIgv").IsActiveCell Then
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(EnterEditMode, False, False)
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Or _
                    .Rows(int).Cells("CantidadMaterial").IsActiveCell Or _
                    .Rows(int).Cells("IndicadorIgv").IsActiveCell Then
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(EnterEditMode, False, False)
                    End If
                End If
                If e.KeyValue = Keys.Space Then
                    .PerformAction(UltraGridAction.ExitEditMode, 0, 0)
                    .PerformAction(UltraGridAction.EnterEditMode, 0, 0)
                End If
                If e.KeyValue = Keys.Subtract Then
                    If gbeListadoMateriales.Visible Then
                        QuitarDetalle()
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnTerminarOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminarOC.Click
        TerminarOC()
    End Sub

    Private Sub griDetalleOrdenIngreso_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griDetalleOrdenIngreso.DoubleClick
        'Try
        '    If griDetalleOrdenIngreso.Rows.Count > 0 Then
        '        If griDetalleOrdenIngreso.ActiveRow.Cells("IdAlmacen").Value = "1CH000000002" Then
        '            oeMaterial = New e_Material
        '            oeMaterial.TipoOperacion = "G"
        '            oeMaterial.Id = griDetalleOrdenIngreso.ActiveRow.Cells("IdMaterial").Value.ToString
        '            oeMaterial = olMaterial.Obtener(oeMaterial)
        '            oeMaterial.Precio = griDetalleOrdenIngreso.ActiveRow.Cells("PrecioUnitario").Value
        '            If oeMaterial.oeMaterial_DisenoNeu IsNot Nothing AndAlso oeMaterial.oeMaterial_DisenoNeu.Id <> "" Then
        '                oeDetOrdenNeu = New e_DetalleOrdenNeumatico
        '                Dim _idOM As String = griDetalleOrdenIngreso.ActiveRow.Cells("Id").Value
        '                oeDetOrdenNeu.IdOrdenMaterial = _idOM
        '                oeDetOrdenNeu.CantMat = griDetalleOrdenIngreso.ActiveRow.Cells("CantidadMaterial").Value
        '                Dim oeOrdenIngresoAux As New e_Orden
        '                Dim _idOrdenIngreso = griDetalleOrdenIngreso.ActiveRow.Cells("IdOrden").Value
        '                Dim _leOrdenI = llOrdenIngreso.Where(Function(it) it.Id = _idOrdenIngreso).ToList
        '                If _leOrdenI.Count > 0 Then
        '                    oeOrdenIngresoAux = _leOrdenI(0)
        '                    oeOrdenIngresoAux.NombreProveedor = cboProveedor.Text
        '                    oeOrdenIngresoAux.Total = leDetOrdenNeu.Count
        '                End If
        '                If oeOrdenIngresoAux.IdDocumento.Trim <> "" Then
        '                    Dim _leDONAux = leDetOrdenNeu.Where(Function(it) it.IdOrdenMaterial = _idOM).ToList
        '                    Dim ofrm As frm_DetalleOrdenNeumatico
        '                    ofrm = New frm_DetalleOrdenNeumatico(oeDetOrdenNeu, oeMaterial, oeOrdenIngresoAux, _leDONAux, 1)
        '                    If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
        '                        LlenarDetalleOrdenNeu(leNOD)
        '                    End If
        '                Else
        '                    Throw New Exception("Ingrese algun Documento a la Orden Nº: " & oeOrdenIngresoAux.NroOrden)
        '                End If
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

    Private Sub griListaRequerimientos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaRequerimientos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaMateriales_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaMateriales.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListadoCotizacionDetalle_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListadoCotizacionDetalle.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaOrdenIngreso_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaOrdenIngreso.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griDetalleOrdenIngreso_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDetalleOrdenIngreso.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griHistorialRechazo_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griHistorialRechazo.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub txtNroOrdenCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOrdenCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub txtNroOrdenCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroOrdenCompra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rdbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNroOrden.CheckedChanged
        Try
            If rdbNroOrden.Checked Then
                rdbDatosAdicionales.Checked = False
                Agrupacion20.Enabled = False
                Me.txtNroOrdenCompra.Focus()
            Else
                rdbDatosAdicionales.Checked = True
                Agrupacion20.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub rdbDatosAdicionales_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatosAdicionales.CheckedChanged
        Try
            If rdbDatosAdicionales.Checked Then
                Agrupacion19.Enabled = False
                rdbNroOrden.Checked = False
            Else
                rdbNroOrden.Checked = True
                Agrupacion19.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CambiarEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarEstadoToolStripMenuItem.Click
        Try
            CambiarEstado()
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

    Private Sub btnEliminarOrden_Click(sender As Object, e As EventArgs) Handles btnEliminarOrden.Click
        Eliminar()
    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim oeCom As New e_Combo
                oeCom.Nombre = txtCodBarras.Text.Trim
                oeCom.Tipo = 1
                If CodigoBarrasPublic.Contains(oeCom) Then
                    oeCom = CodigoBarrasPublic.Item(CodigoBarrasPublic.IndexOf(oeCom))
                Else
                    Throw New Exception("Codigo de Barras no Asociado a Ningun Material")
                End If
                Select Case oeOrdenCompra.TipoOperacion
                    Case "I", "A"
                        AsignarMaterialCodigo(oeCom.Id.Trim)
                    Case "3"
                        AtenderMateriales(oeCom.Id.Trim)
                End Select
                txtCodBarras.Focus()
                txtCodBarras.Value = String.Empty
            End If
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

    Private Sub fecFechaEntrega_ValueChanged(sender As Object, e As EventArgs) Handles fecFechaEntrega.ValueChanged
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFechaEntrega_Validated(sender As Object, e As EventArgs) Handles fecFechaEntrega.Validated
        Try
            ActualizarTipoPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menú contextual Requerimientos"

    Private Sub AsociarMenuRequerimiento()
        griListaRequerimientos.ContextMenuStrip = MenuContextualReq
    End Sub

    Private Sub RechazarStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechazarStripMenuItem1.Click
        Try
            rechazarRequerimientoMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Sub rechazarRequerimientoMaterial()
        Try
            With griListaRequerimientos
                If .Selected.Rows.Count = 0 Then
                    Throw New Exception("Seleccione un requerimiento para rechazar.")
                End If
                oeRequerimientoMaterial = New e_RequerimientoMaterial
                oeRequerimientoMaterial.Tipooperacion = "C"
                oeRequerimientoMaterial.Activo = True
                oeRequerimientoMaterial.Id = .ActiveRow.Cells("Id").Value.ToString()
                oeRequerimientoMaterial.IndicadorAprobacion = 0
                oeRequerimientoMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRequerimientoMaterial.Guardar(oeRequerimientoMaterial)
                llenaGrillaReqMat(True)
            End With
        Catch ex As Exception
            Throw ex
        End Try
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
        Try
            VerificarPermiso()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AtenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtenderToolStripMenuItem.Click
        AtenderOrdenesCompra()
    End Sub

    Private Sub RechazarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechazarToolStripMenuItem.Click
        RechazarOrdenCompra()
        Listar(True)
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("InsertarToolStripMenuItem").Visible = 1
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = 0
            MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
            MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = 0
            MenuContextual1.Items("CambiarEstadoToolStripMenuItem").Enabled = 0
            MenuContextual1.Items("EnviarCorreoToolStripMenuItem").Visible = 0
            If griListaOrdenCompra.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("EditarToolStripMenuItem").Visible = 1
                Select Case griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value
                    Case gNombreEstadoOrdenGenerada
                        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
                        MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = 1
                        MenuContextual1.Items("RechazarToolStripMenuItem").Enabled = 1
                    Case gNombreEstadoOrdenPreEvaluada
                        MenuContextual1.Items("CambiarEstadoToolStripMenuItem").Enabled = 1
                    Case gNombreEstadoOrdenRechazada
                        MenuContextual1.Items("AprobarToolStripMenuItem").Enabled = 1
                    Case gNombreEstadoOrdenEvaluada, gNombreEstadoOrdenAtendidoParcialmente
                        If griListaOrdenCompra.ActiveRow.Cells("NombreSubEstado").Value = gNombreEstadoOrdenAprobada Then
                            MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 1
                        End If
                        If griListaOrdenCompra.ActiveRow.Cells("IndicadorConsignacion").Value Then
                            MenuContextual1.Items("AtenderToolStripMenuItem").Enabled = 0
                        End If
                        If griListaOrdenCompra.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoOrdenEvaluada Then
                            MenuContextual1.Items("CambiarEstadoToolStripMenuItem").Enabled = 1
                        End If
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub MenuContextualOI_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextualOI.Opening
        Try
            MenuContextualOI.Items("TSM_Factura").Visible = False
            MenuContextualOI.Items("TSM_Boleta").Visible = False
            MenuContextualOI.Items("TSM_Guia").Visible = False
            If griListaOrdenIngreso.Selected.Rows.Count > 0 Then
                If griListaOrdenIngreso.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoOrdenGenerada And String.IsNullOrEmpty(griListaOrdenIngreso.ActiveRow.Cells("IdDocumento").Value.ToString.Trim) Then
                    MenuContextualOI.Items("TSM_Factura").Visible = True
                    MenuContextualOI.Items("TSM_Boleta").Visible = True
                    MenuContextualOI.Items("TSM_Guia").Visible = True
                End If
                If oeOrdenCompra.EstadoOrden <> gNombreEstadoOrdenTerminada Then
                    Dim oeOrdDoc As New e_Orden_Documento
                    Dim olOrdDoc As New l_Orden_Documento
                    oeOrdDoc.IdOrden = griListaOrdenIngreso.ActiveRow.Cells("Id").Value
                    oeOrdDoc.TipoOperacion = "X"
                    oeOrdDoc = olOrdDoc.Obtener(oeOrdDoc)
                    If griListaOrdenIngreso.ActiveRow.Cells("TipoDocumento").Value.ToString = "GUÍA DE REMISIÓN - REMITENTE" And oeOrdDoc.IdTipoDocumento = "" Then
                        MenuContextualOI.Items("TSM_Factura").Visible = True
                        MenuContextualOI.Items("TSM_Boleta").Visible = True
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub TSM_Factura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Factura.Click
        GenerarDocumento("FACTURA")
        btnTerminarOC.Enabled = True
    End Sub

    Private Sub TSM_Guia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Guia.Click
        GenerarDocumento("GUIA")
    End Sub

    Private Sub TSM_Boleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSM_Boleta.Click
        GenerarDocumento("BOLETA")
    End Sub

#End Region

#Region "Asiento Modelo"

    Private Sub AsientosContablesCompraDocN()
        AsientoModelo()
        CtaCtbleSubFamilia()
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = olCtaCtbleSFam.Listar(oeCtaCtbleSFam)
    End Sub

    Public Sub LlenaCuenta(Ejercicio As Integer)
        Try
            For Each oemat As e_OrdenMaterial In oeOrdenIngreso.lstOrdenMaterial
                oemat.IdSubFamiliaMaterial = BuscarSubFamilia(oemat.IdMaterial)
                If oemat.IdSubFamiliaMaterial = "" Then Throw New Exception("Material: " & oemat.Material & " con SubFamilia Sin Cuenta Contable. Verificar")
            Next
            Dim loAuxCtaCtble, loAuxCtaCtble1, loAuxCtaCtble2 As New List(Of e_CtaCtbleSubFamiliaMat)
            Dim oeCtaCtbleSFM As New e_CtaCtbleSubFamiliaMat
            For Each ordmat As e_OrdenMaterial In oeOrdenIngreso.lstOrdenMaterial
                oeCtaCtbleSFM = New e_CtaCtbleSubFamiliaMat
                oeCtaCtbleSFM.IdSubFamilia = ordmat.IdSubFamiliaMaterial
                For Each oe As e_CtaCtbleSubFamiliaMat In loCtaCtbleSFam.Where(Function(i) i.Ejercicio = Ejercicio).ToList
                    With oeCtaCtbleSFM
                        If .IdSubFamilia = oe.IdSubFamilia Then
                            .IdCtaCtbleExistencias = oe.IdCtaCtbleExistencias
                            .NroCtaCtbleExistencias = oe.NroCtaCtbleExistencias
                            .CtaCtbleExistencias = oe.CtaCtbleExistencias
                            .IdCtaCtbleCompras = oe.IdCtaCtbleCompras
                            .CtaCtbleCompra = oe.CtaCtbleCompra
                            .NroCtaCtbleCompra = oe.NroCtaCtbleCompra
                            .IdCtaCtbleConsumo = oe.IdCtaCtbleConsumo
                            .CtaCtbleConsumo = oe.CtaCtbleConsumo
                            .NroCtaCtbleConsumo = oe.NroCtaCtbleConsumo
                            .IdItemGasto = oe.IdItemGasto
                            .TotalCuentas = (ordmat.CantidadMaterial * ordmat.PrecioUnitario) / (1 + oeIGV.Porcentaje)
                            loAuxCtaCtble1.Add(oeCtaCtbleSFM)
                        End If
                    End With
                Next
            Next
            Dim IdSubFamilia As String = ""
            Dim ctactbleaux As New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble.AddRange(loAuxCtaCtble1.OrderBy(Function(item) item.IdSubFamilia).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdSubFamilia <> ctactblesfm.IdSubFamilia Then
                    IdSubFamilia = ctactblesfm.IdSubFamilia
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = Math.Round(loAuxCtaCtble.Where(Function(item) item.IdSubFamilia = IdSubFamilia).Sum(Function(item) item.TotalCuentas), 2)
                    End With
                    loAuxCtaCtble2.Add(ctactbleaux)
                End If
            Next
            Dim IdCuenta As String = ""
            loCtaCtbleSFamOrden = New List(Of e_CtaCtbleSubFamiliaMat)
            ctactbleaux = New e_CtaCtbleSubFamiliaMat
            loAuxCtaCtble = New List(Of e_CtaCtbleSubFamiliaMat)
            loAuxCtaCtble.AddRange(loAuxCtaCtble2.OrderBy(Function(item) item.IdCtaCtbleExistencias).ToList)
            For Each ctactblesfm As e_CtaCtbleSubFamiliaMat In loAuxCtaCtble
                ctactbleaux = New e_CtaCtbleSubFamiliaMat
                If IdCuenta <> ctactblesfm.IdCtaCtbleExistencias Then
                    IdCuenta = ctactblesfm.IdCtaCtbleExistencias
                    With ctactbleaux
                        .IdCtaCtbleExistencias = ctactblesfm.IdCtaCtbleExistencias
                        .NroCtaCtbleExistencias = ctactblesfm.NroCtaCtbleExistencias
                        .CtaCtbleExistencias = ctactblesfm.CtaCtbleExistencias
                        .IdCtaCtbleCompras = ctactblesfm.IdCtaCtbleCompras
                        .CtaCtbleCompra = ctactblesfm.CtaCtbleCompra
                        .NroCtaCtbleCompra = ctactblesfm.NroCtaCtbleCompra
                        .IdCtaCtbleConsumo = ctactblesfm.IdCtaCtbleConsumo
                        .CtaCtbleConsumo = ctactblesfm.CtaCtbleConsumo
                        .NroCtaCtbleConsumo = ctactblesfm.NroCtaCtbleConsumo
                        .IdItemGasto = ctactblesfm.IdItemGasto
                        .TotalCuentas = Math.Round(loAuxCtaCtble.Where(Function(item) item.IdCtaCtbleExistencias = IdCuenta).Sum(Function(item) item.TotalCuentas), 2)
                    End With
                    loCtaCtbleSFamOrden.Add(ctactbleaux)
                End If
            Next
            oeOrdenIngreso.loCtaCtbleSFam.AddRange(loCtaCtbleSFamOrden)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ObtenerAsientoModelo(IdTipoDocumento As String, Ejercicio As Integer)
        Try
            Dim lstReferencia = loReferencia.Where(Function(item) item.TipoReferencia = 5 And item.IdReferencia = IdTipoDocumento).ToList
            If lstReferencia.Count > 0 Then
                For Each oeref As e_AsientoModelo_Referencia In lstReferencia
                    oeAsientoModeloGuia = New e_AsientoModelo
                    With oeAsientoModeloGuia
                        .Equivale = 2
                        .Id = oeref.IdActividad
                        .IdMoneda = oeOrdenCompra.IdMoneda
                        If loAsientoModelo.Contains(oeAsientoModeloGuia) Then
                            oeAsientoModeloGuia = loAsientoModelo.Item(loAsientoModelo.IndexOf(oeAsientoModeloGuia))
                            oeAsientoModeloGuia.TipoOperacion = ""
                            oeAsientoModeloGuia.Ejercicio = Ejercicio
                            oeAsientoModeloGuia = olAsientoModelo.Obtener(oeAsientoModeloGuia)
                            Exit For
                        End If
                    End With
                Next
            End If
            oeOrdenIngreso.loAsientoModelo.Add(oeAsientoModeloGuia)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
