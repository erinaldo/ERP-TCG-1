'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office.Interop

Public Class frm_OrdenIngreso

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_OrdenIngreso = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_OrdenIngreso
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de variables"

    Dim muestra As Boolean = False
    'Manejador de Centro
    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    'Manejador de Almacen
    Dim oeAlmacen As New e_Almacen
    Dim olAlmacen As New l_Almacen
    'Manejador de Subalmacen
    Dim oeSubalmacen As New e_SubAlmacen
    Dim olSubalmacen As New l_SubAlmacen
    'Manejador de Material
    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim listaMaterial As New List(Of e_Material)
    'Manejador de Proveedor
    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    'Manejador de Tipo de Orden
    Dim oeTipoOrden As New e_TipoOrden
    Dim olTipoOrden As New l_TipoOrden
    'Manejador de Registro de Inventario
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim olRegistroInventario As New l_RegistroInventario
    Dim listaRegistroInventario As New List(Of e_RegistroInventario)
    'Manejador de Movimiento de Inventario
    Dim oeMovimientoInventario As New e_MovimientoInventario
    Dim olMovimientoInventario As New l_MovimientoInventario
    Dim listaMovimientoInventario As New List(Of e_MovimientoInventario)
    'Manejador de Inventario
    Dim oeInventario As New e_Inventario
    Dim olInventario As New l_Inventario
    Dim listaInventario As New List(Of e_Inventario)
    'Manejador de Estado Orden
    Dim oeEstadoOrden As New e_EstadoOrden
    Dim olEstadoOrden As New l_EstadoOrden
    Dim listaEstadoOrden As New List(Of e_EstadoOrden)
    'Manejador de Moneda
    Dim oeMoneda As New e_Moneda
    Dim olMoneda As New l_Moneda
    'Manejador de Orden
    Dim oeOrden As New e_Orden
    Dim olOrden As New l_Orden
    Dim listaOrden As New List(Of e_Orden)
    'Manejador de Unidad de Medida
    Dim oeUnidadMedida As New e_UnidadMedida
    Dim olUnidadMedida As New l_UnidadMedida
    'Manejador de Material - Almacen
    Dim oeMaterialAlmacen As New e_MaterialAlmacen
    Dim olMaterialAlmacen As New l_MaterialAlmacen
    'Manejador de Orden Material
    Dim oeOrdenMaterial As New e_OrdenMaterial
    Dim olOrdenMaterial As New l_OrdenMaterial
    Dim listaOrdenMaterial As New List(Of e_OrdenMaterial)
    'Manejador de Tipo Documento
    Dim oeTipoDocumento As New e_TipoDocumento
    Dim olTipoDocumento As New l_TipoDocumento
    Dim listaTipoDoc As New List(Of e_TipoDocumento)
    'Manejador de Movimiento Documento
    Dim oeMovimientoDocumento As New e_MovimientoDocumento
    Dim olMovimientoDocumento As New l_MovimientoDocumento
    Dim lstMovimientoDocumento As New List(Of e_MovimientoDocumento)
    Dim lstMovimientoDocumentoAsoc As New List(Of e_MovimientoDocumento)
    'Manejador de Orden Documento
    Dim oeOrdenDoc As New e_Orden_Documento
    Dim olOrdenDoc As New l_Orden_Documento
    'IGV
    Dim oeIGV As New e_Impuesto
    Dim olIGV As New l_Impuesto
    'Manejador de GuiaRemisionRemitente
    Dim oeGRRemitente As New e_GuiaRemisionRemitente, olGRRemitente As New l_GuiaRemisionRemitente
    Dim listaGRemision As New List(Of e_GuiaRemisionRemitente)

    'Manejador TrabajadorSeguridad
    Dim oeTrabajadorSeguridad As New e_TrabajadorSeguridad, olTrabajadorSeguridad As New l_TrabajadorSeguridad
    Dim oeProcesoNegocio As New e_ProcesoNegocio, olProcesoNegocio As New l_ProcesoNegocio
    Dim IndRectificar As Boolean = 0

    Dim _ingresando_datos As Boolean = False

    Dim oeOrdenAsignacion As New e_OrdenAsignacion
    'Private oeDetOrdenNeu As New e_DetalleOrdenNeumatico
    'Private olDetOrdenNeu As New l_DetalleOrdenNeumatico
    'Private leDetOrdenNeu As New List(Of e_DetalleOrdenNeumatico)

    'Control Material Devolucion
    Dim oeControlEntregaMaterial As New e_ControlEntregaMaterial

    'Validacion para que solo 1 usuario acceda a la orden
    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    Private loMaterialesNegociadosDet As New List(Of e_MaterialesNegociadosDet)

    Private oeAsientoModelo As New e_AsientoModelo
    Private olAsientoModelo As New l_AsientoModelo
    Private loAsientoModelo As New List(Of e_AsientoModelo)
    Private oeReferencia As New e_AsientoModelo_Referencia
    Private olReferencia As New l_AsientoModelo_Referencia
    Private loReferencia As New List(Of e_AsientoModelo_Referencia)

    Private oeCtaCtbleSFam As New e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As New l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam, loCtaCtbleSFamOrden As New List(Of e_CtaCtbleSubFamiliaMat)

    Private dtReferencia As New DataTable

#End Region

#Region "Botones Barra Detalle"

    Private Sub Botones(ByVal oeBoton As e_Boton)
        Try
            With MenuDetalle
                .Tools("Agregar").SharedProps.Enabled = oeBoton.Nuevo
                .Tools("Eliminar").SharedProps.Enabled = oeBoton.Eliminar
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AgregarDetalle()
        Try
            Dim sw As Boolean = False
            For i As Integer = 0 To listaMaterial.Count - 1
                If listaMaterial.Item(i).Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un Material para Agregar a la Lista de Materiales de la Orden.")
            loMaterialesNegociadosDet = New List(Of e_MaterialesNegociadosDet)
            AsignarOrdenMaterial(loMaterialesNegociadosDet)
            txtBuscarMateriales.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub QuitarDetalle()
        Try
            Select Case ficDetalle.SelectedTab.Index
                Case 0
                    QuitarOrdenMaterial()
                Case 1
                    QuitarAsociacionDocumento()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub ConsultaDetalle()
        Select Case ficDetalle.SelectedTab.Index
            Case 0
                ConsultarOrdenMaterial()
        End Select
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        QuitarDetalle()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        AgregarDetalle()
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub cboProveedor_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles cboProveedor.InitializeLayout
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

    Private Sub cboProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarProveedores(cboProveedor, "0", chkRuc.Checked)
        End If
    End Sub

    Private Sub txtNIngreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNIngreso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub frm_OrdenIngreso_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case ficOrden.SelectedTab.Index
            Case 0
                Consultar(True)
                If griListaOrden.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
                End If
            Case 1
                If oeOrden.TipoOperacion = "T" Or oeOrden.TipoOperacion = "I" Then
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
                Else
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub frm_OrdenIngreso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenIngreso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_OrdenIngreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not muestra Then
            gf_AsignarEventoSeleccionarTexto(Me)
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNIngreso.Name, cboProveedor.Name, txtBuscarMateriales.Name)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficOrden)
            llenarComboFiltroMovimiento()
            llenarComboFiltroEstadoOrden()
            llenarComboTipoDocumento()
            rfOrdenIngresoDesde.Value = Date.Now.AddDays(-7)
            rfOrdenIngresoHasta.Value = Date.Now
            rfechasDesde.Value = Date.Now.AddDays(-7)
            rfechasHasta.Value = Date.Now
            InicializarColores()
            AsientoContable()
        End If
        ComboGrillaTipoDocumento(GriAsocDoc, "COMPRAS")
    End Sub

    Private Sub griListaOrden_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaOrden.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Eliminar()
        e.Cancel = True
    End Sub

    Private Sub griListaOrden_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaOrden.CellChange
        griListaOrden.UpdateData()
    End Sub

    Private Sub griListaOrden_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaOrden.InitializeLayout
        agrOrdenesdeIngreso.Text = "Total de Ordenes de ingreso: " & griListaOrden.Rows.Count.ToString()
    End Sub

    Private Sub griOrdenMaterial_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griOrdenMaterial.BeforeCellUpdate
        With griOrdenMaterial
            Select Case e.Cell.Column.Key
                Case "CantidadMaterial"
                    If e.Cell.Column.Key = "CantidadMaterial" Then
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
                Case "PrecioUnitario"
                    If e.Cell.Column.Key = "PrecioUnitario" Then
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                    End If
            End Select
        End With
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        Try
            griListaMateriales.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrdenMaterial_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.AfterCellUpdate
        Try
            With griOrdenMaterial.Rows(e.Cell.Row.Index)
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.LightYellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    Case "IdAlmacen"
                        With griOrdenMaterial
                            If .ActiveRow.Index > -1 Then
                                SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")
                                oeSubalmacen = New e_SubAlmacen
                                oeSubalmacen.TipoOperacion = "S"
                                oeSubalmacen.Activo = True
                                oeSubalmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                .ActiveRow.Cells("IdSubAlmacen").Value = olSubalmacen.Obtener(oeSubalmacen).Id
                                .ActiveRow.Cells("PrecioUnitario").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdSubAlmacen").Value)
                            End If
                        End With
                    Case "CantidadMaterial"
                        If IsDBNull(e.Cell.Value) Then
                            .Cells("CantidadMaterial").Value = 0
                            Exit Sub
                        End If
                    Case "PrecioUnitario"
                        If IsDBNull(e.Cell.Value) Then
                            .Cells("PrecioUnitario").Value = 0
                            Exit Sub
                        End If
                End Select
                .Cells("ValorVenta").Value = .Cells("PrecioUnitario").Value * .Cells("CantidadMaterial").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griOrdenMaterial_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles griOrdenMaterial.AfterRowsDeleted
        CalcularTotalesDetalle()
    End Sub

    Private Sub griOrdenMaterial_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griOrdenMaterial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenMaterial_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.CellChange
        Try
            griOrdenMaterial.UpdateData()
            If oeOrden.EstadoOrden <> "TERMINADA" Then
                oeOrden.Modificado = True
            End If
            CalcularTotalesDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtNroOrden_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrden.ValueChanged
        oeOrden.NroOrden = txtNroOrden.Text
    End Sub

    Private Sub txtGlosa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGlosa.KeyDown
        oeOrden.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeOrden.Glosa = txtGlosa.Text
    End Sub

    Private Sub cboMovimientoInventario_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMovimientoInventario.ValueChanged
        CargaComboMovimientoInventario()
    End Sub

    Private Sub CargaComboMovimientoInventario()
        Select Case cboMovimientoInventario.Value
            Case "1CH000000021", "1SI000000002", "1CH000000039"
                ListarProveedores(cboProveedor, ISL_IdProveedor)
                oeOrden.IdProveedor = ISL_IdProveedor
                cboProveedor.Value = ISL_IdProveedor
                ActivarMateriales(True)
                LimpiarDocAsoc()
                cboMoneda.SelectedIndex = -1
                cboMoneda.ReadOnly = False
            Case "1CH000000037"
                cboMoneda.Value = "1CH02"
                cboMoneda.ReadOnly = True
                cboProveedor.Text = String.Empty
                cboProveedor.DataSource = Nothing
                ActivarMateriales(False)
                LimpiarDocAsoc()
            Case Else
                cboProveedor.Text = String.Empty
                cboProveedor.DataSource = Nothing
                ActivarMateriales(False)
                LimpiarDocAsoc()
                cboMoneda.SelectedIndex = -1
                cboMoneda.ReadOnly = False
        End Select
        oeOrden.IdMovimientoInventario = cboMovimientoInventario.Value
        oeOrden.Modificado = True
    End Sub

    Private Sub ActivarMateriales(ByVal Activo As Boolean)
        Try
            gbeMateriales.Visible = Activo
            If Activo = True Then
                Me.ficDetalle.Tabs(0).Selected = True
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = False
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.Edit
            Else
                Me.ficDetalle.Tabs(1).Selected = True
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("Seleccion").Hidden = True
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("Seleccion").CellClickAction = CellClickAction.RowSelect
            End If
            listaOrdenMaterial = New List(Of e_OrdenMaterial)
            listaMaterial = New List(Of e_Material)
            griListaMateriales.DataSource = listaMaterial
            griOrdenMaterial.DataSource = listaOrdenMaterial
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeOrden.IdMoneda = cboMoneda.Value
        oeOrden.Modificado = True
    End Sub

    Private Sub decTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotal.ValueChanged
        oeOrden.Total = decTotal.Value
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtNIngreso.Text = String.Empty
    End Sub

    Private Sub rbNroOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroOrden.CheckedChanged
        gbOI.Enabled = rbNroOrden.Checked
        txtNIngreso.Focus()
        InicializarLista()
    End Sub

    Private Sub cmdEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Try
            If PermisoEjecucion() Then
                Editar() : oeOrden.TipoOperacion = "T"
                cboMovimientoInventario.ReadOnly = True
                Me.lbl_etiqueta.Text = "Ejecutar OI"
                Me.lbl_etiqueta.Visible = True
                ControlBoton(0, 0, 0, 1, 1)
            Else
                Throw New Exception("No tiene Permiso para Ejecutar Orden de Ingreso")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaOrden_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaOrden.AfterRowActivate
        btnEjecutar.Enabled = 0
        If griListaOrden.ActiveRow.Index > -1 Then
            Select Case griListaOrden.ActiveRow.Cells("EstadoOrden").Value
                Case "GENERADA"
                    If griListaOrden.ActiveRow.Cells("TipoReferencia").Value <> "COMPRA" Then
                        btnEjecutar.Enabled = 1
                    End If
                Case "RECEPCIONADO", "TERMINADA"
                    btnEjecutar.Enabled = 0
                    btnRectificar.Enabled = 1
            End Select
        End If
    End Sub

    Private Sub griListaOrden_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaOrden.DoubleClick
        If griListaOrden.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        ListarMateriales()
    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListarMateriales()
        End If
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
        oeMaterial.Nombre = txtBuscarMateriales.Text
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDetalle.ToolClick
        Select Case e.Tool.Key
            Case "Consultar"
                ListarMateriales()
            Case "Agregar"
                AgregarDetalle()
            Case "Eliminar"
                QuitarDetalle()
            Case "Importar"
                ImportarArchivo()
        End Select
    End Sub

    Private Sub btnBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrdenes.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ValidarFechaDesde_Hasta(rfechasDesde, rfechasHasta)
            If cboTipoDoc.Value <> "1CH000000027" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                With oeMovimientoDocumento
                    .FechaInicio = rfechasDesde.Value
                    .FechaFinal = rfechasHasta.Value
                    .Activo = True
                    .IdTipoDocumento = cboTipoDoc.Value
                    .IndCompraVenta = 1
                    .IndServicioMaterial = "M"
                    .TipoOperacion = "DSA"
                End With
                lstMovimientoDocumento = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
                griListaDoc.DataSource = lstMovimientoDocumento
                griListaDoc.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Else
                oeGRRemitente.TipoOperacion = "3"
                oeGRRemitente.IdTipoGuia = cboTipoDoc.Value
                oeGRRemitente.fechaInicio = rfechasDesde.Value
                oeGRRemitente.fechaFin = rfechasHasta.Value
                oeGRRemitente.Id = ""
                listaGRemision = olGRRemitente.Listar(oeGRRemitente)
                lstMovimientoDocumento = New List(Of e_MovimientoDocumento)
                griListaDoc.DataSource = lstMovimientoDocumento
                For Each obj As e_GuiaRemisionRemitente In listaGRemision
                    oeMovimientoDocumento = New e_MovimientoDocumento
                    oeMovimientoDocumento.Id = obj.Id
                    oeMovimientoDocumento.NombreDocumento = obj.Serie & " - " & obj.Numero
                    oeMovimientoDocumento.IdTipoDocumento = obj.IdTipoGuia
                    oeMovimientoDocumento.FechaEmision = obj.Fecha
                    oeMovimientoDocumento.IdClienteProveedor = obj.IdEmpresaProveedor
                    oeMovimientoDocumento.NombreProveedor = obj.Nombre
                    oeMovimientoDocumento.Serie = obj.Serie
                    oeMovimientoDocumento.Numero = obj.Numero
                    oeMovimientoDocumento.IdEstadoDocumento = obj.IdEstado
                    oeMovimientoDocumento.EstadoDocumento = obj.Estado
                    oeMovimientoDocumento.Moneda = String.Empty
                    oeMovimientoDocumento.IdMoneda = String.Empty
                    oeMovimientoDocumento.SubTotal = 0.0
                    oeMovimientoDocumento.IGV = 0.0
                    oeMovimientoDocumento.Total = 0.0
                    oeMovimientoDocumento.TipoCambio = 0.0
                    oeMovimientoDocumento.TipoPago = String.Empty
                    oeMovimientoDocumento.IdTipoPago = String.Empty
                    lstMovimientoDocumento.Add(oeMovimientoDocumento)
                Next
                griListaDoc.DataBind()
            End If
            With griListaDoc
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaDoc_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDoc.CellChange
        griListaDoc.UpdateData()
    End Sub

    Private Sub griListaDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaDoc.DoubleClick
        If griListaDoc.Selected.Rows.Count > 0 Then AsociarDocumento()
    End Sub

    Private Sub cboProveedor_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProveedor.ValueChanged
        oeOrden.IdProveedor = cboProveedor.Value
        oeOrden.Modificado = True
    End Sub

    Private Sub cboProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cboProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub fecFechaOrden_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaOrden.Validated
        Try
            If Operacion = "Nuevo" Then
                Select Case fecFechaOrden.Value
                    Case Is > Date.Now
                        fecFechaOrden.Value = Date.Now
                        Throw New Exception("La Fecha no puede ser mayor al día actual")
                    Case Is < UltimoDiaMesAnterior()
                        fecFechaOrden.Value = Date.Now
                        Throw New Exception("La Fecha no puede ser anterior al mes pasado")
                End Select
            End If
            oeOrden.FechaOrden = fecFechaOrden.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnRectificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectificar.Click
        RectificarOI()
    End Sub

    Private Sub griListaMateriales_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            With griListaMateriales
                Select Case e.KeyValue
                    Case Keys.Space
                        .PerformAction(ExitEditMode, 0, 0)
                        .PerformAction(EnterEditMode, 0, 0)

                    Case Keys.Add
                        AgregarDetalle()
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griOrdenMaterial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griOrdenMaterial.KeyDown
        Try
            With griOrdenMaterial
                Dim int As Integer = .ActiveRow.Index
                If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(EnterEditMode, False, False)
                    End If
                    If .Rows(int).Cells("CantidadMaterial").IsActiveCell Then
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(BelowCell, False, False)
                        e.Handled = True
                        .PerformAction(EnterEditMode, False, False)
                    End If
                End If
                If e.KeyCode = Keys.Up Then
                    If .Rows(int).Cells("PrecioUnitario").IsActiveCell Then
                        .PerformAction(ExitEditMode, False, False)
                        .PerformAction(AboveCell, False, False)
                        e.Handled = True
                        .PerformAction(EnterEditMode, False, False)
                    End If
                    If .Rows(int).Cells("CantidadMaterial").IsActiveCell Then
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
                    If MenuDetalle.Enabled Then
                        QuitarDetalle()
                    End If
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub griOrdenMaterial_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griOrdenMaterial.DoubleClick
        Try
            'If griOrdenMaterial.Rows.Count > 0 Then
            '    If griOrdenMaterial.ActiveRow.Cells("IdAlmacen").Value = "1CH000000002" Then
            '        oeMaterial = New e_Material
            '        oeMaterial.TipoOperacion = "G"
            '        oeMaterial.Id = griOrdenMaterial.ActiveRow.Cells("IdMaterial").Value.ToString
            '        oeMaterial = olMaterial.Obtener(oeMaterial)
            '        oeMaterial.Precio = griOrdenMaterial.ActiveRow.Cells("PrecioUnitario").Value
            '        If oeMaterial.oeMaterial_DisenoNeu IsNot Nothing AndAlso oeMaterial.oeMaterial_DisenoNeu.Id <> "" Then
            '            oeDetOrdenNeu = New e_DetalleOrdenNeumatico
            '            Dim _idOM As String = griOrdenMaterial.ActiveRow.Cells("Id").Value
            '            oeDetOrdenNeu.IdOrdenMaterial = _idOM
            '            oeDetOrdenNeu.CantMat = griOrdenMaterial.ActiveRow.Cells("CantidadMaterial").Value
            '            'Dim oeOrdenIngresoAux As New e_Orden
            '            'Dim _idOrdenIngreso = griOrdenMaterial.ActiveRow.Cells("IdOrden").Value
            '            'Dim _leOrdenI = llOrdenIngreso.Where(Function(it) it.Id = _idOrdenIngreso).ToList
            '            'If _leOrdenI.Count > 0 Then
            '            ' oeOrdenIngresoAux.Id = oeOrden.Id
            '            oeOrden.NombreProveedor = cboProveedor.Text
            '            'End If
            '            'If oeOrdenIngresoAux.IdDocumento.Trim <> "" Then
            '            Dim _leDONAux = leDetOrdenNeu.Where(Function(it) it.IdOrdenMaterial = _idOM).ToList
            '            Dim ofrm As frm_DetalleOrdenNeumatico
            '            ofrm = New frm_DetalleOrdenNeumatico(oeDetOrdenNeu, oeMaterial, oeOrden, _leDONAux, 2)
            '            If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '                LlenarDetalleOrdenNeu(leNOD)
            '            End If
            '            'Else
            '            '    Throw New Exception("Ingrese algun Documento a la Orden Nº: " & oeOrdenIngresoAux.NroOrden)
            '            'End If
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GriAsocDoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles GriAsocDoc.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenMovimientos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griOrdenMovimientos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaDoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaDoc.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaMateriales_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griListaMateriales.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    'With griListaMateriales.Rows(e.Cell.Row.Index)
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

    Private Sub griListaMateriales_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles griListaMateriales.InitializeLayout
        With griListaMateriales
            .DisplayLayout.Bands(0).SortedColumns.Add("CodigoNombre", False, True)
            .DisplayLayout.GroupByBox.Hidden = True
            .DisplayLayout.GroupByBox.Style = GroupByBoxStyle.Compact
        End With
    End Sub

    Private Sub griListaMateriales_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaMateriales.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Procedimientos del Formulario"

    Private Sub llenarComboTipoDocumento()
        Try
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "A"
            oeTipoDocumento.Activo = True
            listaTipoDoc.AddRange(olTipoDocumento.Listar(oeTipoDocumento))
            LlenarComboMaestro(cboTipoDoc, listaTipoDoc, 0)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub InicializarLista()
        cboFiltroMovimiento.SelectedIndex = 0
        cboEstadoOrden.SelectedIndex = 0
        rfOrdenIngresoHasta.Value = Date.Now
    End Sub

    Private Sub CalcularTotalesDetalle()
        decTotal.Value = 0.0
        oeOrden.lstOrdenMaterial = griOrdenMaterial.DataSource
        For Each obj As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            decTotal.Value += obj.ValorVenta
        Next
    End Sub

    Public Sub Inhabilitar(ByVal sw As Boolean)
        agrDatoGeneral.Enabled = sw
        gbeMateriales.Enabled = sw
        MenuDetalle.Enabled = sw
        gbDocAsociar.Enabled = sw
        'MenuDetalle.Visible = 1
    End Sub

    Public Sub ValidarFicha()
        If oeOrden.EstadoOrden = "TERMINADA" Or oeOrden.EstadoOrden = "RECEPCIONADO" Then
            ficDetalle.Tabs(0).Enabled = True
            ficDetalle.Tabs(0).Selected = True
            ficDetalle.Tabs(1).Enabled = True
            ficDetalle.Tabs(2).Enabled = True
        Else
            ficDetalle.Tabs(2).Enabled = False
            'ficDetalle.Tabs(1).Enabled = False
            MostrarTabs(0, ficDetalle, 1)
        End If
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = ""
            oeOrden.Activo = Activo
            oeOrden.IdTipoOrden = ObtenerTipoOrden("ORDEN DE INGRESO")
            oeOrden.Id = ""
            If rbNroOrden.Checked Then
                If String.IsNullOrEmpty(txtNIngreso.Text.Trim) Then Throw New Exception("Ingrese N° de la Orden.")
                oeOrden.NroOrden = Me.txtNIngreso.Text.Trim
                oeOrden.fechaInicio = "01/01/1901"
                oeOrden.fechaFin = "01/01/1901"
            Else
                ValidarFechaDesde_Hasta(rfOrdenIngresoDesde, rfOrdenIngresoHasta)
                oeOrden.EstadoOrden = IIf(cboEstadoOrden.Value = "CERO", "", cboEstadoOrden.Value)
                oeOrden.IdMovimientoInventario = IIf(cboFiltroMovimiento.Value = "CERO", "", cboFiltroMovimiento.Value)
                oeOrden.fechaInicio = rfOrdenIngresoDesde.Value
                oeOrden.fechaFin = rfOrdenIngresoHasta.Value
            End If
            listaOrden = olOrden.Listar(oeOrden)
            griListaOrden.DataSource = listaOrden
            'Ubica el cursor el el primer registro de la grilla
            'grilistaorden.Rows
            If griListaOrden.Rows.Count > 0 Then
                griListaOrden.Focus()
                griListaOrden.Rows.Item(0).Selected = True
            End If
            For Each fila As UltraGridRow In griListaOrden.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "RECEPCIONADO"
                        fila.CellAppearance.BackColor = Me.ColoresEvaluado.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresTerminado.Color
                End Select
            Next

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LlenaCombos()
        Try
            oeMoneda.TipoOperacion = "1"
            oeMoneda.Activo = True
            oeMovimientoInventario.TipoOperacion = IIf(Operacion = "Nuevo", "6", "3")
            oeMovimientoInventario.Activo = True
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            'cboMoneda.ReadOnly = True
            LlenarComboMaestro(cboMovimientoInventario, olMovimientoInventario.Listar(oeMovimientoInventario), 0)
            CargaComboMovimientoInventario()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerTipoOrden(ByVal cad As String) As String
        Try
            oeTipoOrden = New e_TipoOrden
            oeTipoOrden.TipoOperacion = ""
            oeTipoOrden.Nombre = cad
            oeTipoOrden = olTipoOrden.Obtener(oeTipoOrden)
            Return oeTipoOrden.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Inicializar()
        Try
            IndRectificar = 0
            oeIGV = olIGV.IGV(fecFechaOrden.Value)
            Me.txtGlosa.Text = String.Empty
            txtNroOrden.Text = String.Empty
            fecFechaOrden.Value = Date.Now
            Me.lbl_etiqueta.Visible = False
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            oeOrden.FechaOrden = fecFechaOrden.Value
            oeOrden.IdMoneda = cboMoneda.Value
            oeOrden.IdTipoOrden = ObtenerTipoOrden("ORDEN DE INGRESO")
            griOrdenMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.AllowEdit
            griOrdenMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellActivation = Activation.AllowEdit
            Inhabilitar(True)
            ActivarControles(True)
            griOrdenMaterial.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
            cboMovimientoInventario.ReadOnly = False
            'Lleno combo movimientos y cliente
            LlenaCombos()
            gbeMateriales.Expanded = False
            gbDocAsociar.Expanded = False
            txtBuscarMateriales.Text = String.Empty
            'Limpio las listas
            LimpiarListas()
            limpiar()
            'habilito o inhabilito algunas cajas de texto
            HabInhVisualizacion(False)
            'controlo el sub menu
            ControlaBarraOperacionesDetalle(1, 1)
            InicializarColores()
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                MenuDetalle.Tools("Importar").SharedProps.Enabled = True
            Else
                MenuDetalle.Tools("Importar").SharedProps.Enabled = False
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Sub InicializarColores()
        Me.ColoresGenerado.Color = Color.White
        Me.ColoresEvaluado.Color = Color.Khaki
        Me.ColoresTerminado.Color = Color.LightGreen
    End Sub

    'Limpiar Listas y cajas de texto
    Private Sub LimpiarListas()
        Try
            listaMaterial = New List(Of e_Material)
            listaOrdenMaterial.Clear()
            listaRegistroInventario.Clear()
            listaInventario.Clear()
            lstMovimientoDocumentoAsoc.Clear()
            lstMovimientoDocumento.Clear()
            With griListaMateriales
                .DataSource = listaMaterial
                .DisplayLayout.Bands(0).SortedColumns.Clear()
            End With
            GriAsocDoc.DataSource = lstMovimientoDocumentoAsoc
            griListaDoc.DataSource = lstMovimientoDocumento
            griOrdenMaterial.DataSource = listaOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub limpiar()
        Me.txtGlosa.Text = String.Empty
        Me.decTotal.Value = 0
        chkRuc.Checked = False
    End Sub

    Public Sub ListarOrdenMaterial(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrdenMaterial = New e_OrdenMaterial
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = Activo
            oeOrdenMaterial.IdOrden = oeOrden.Id
            listaOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            griOrdenMaterial.DataSource = listaOrdenMaterial
            llenaCombosGrillaOrdenMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ficDetalle_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalle.SelectedTabChanged
        'ConsultaDetalle()
    End Sub

    Sub ModificarCantidadDevolucionOT()
        Dim oeOrdenTrabajoMat As New e_OrdenTrabajo_Material, olOrdenTrabajoMat As New l_OrdenTrabajo_Material
        Dim oeOrdenTrabajo As New e_OrdenTrabajo, olOrdenTrabajo As New l_OrdenTrabajo
        For Each filaMat As e_OrdenMaterial In listaOrdenMaterial
            oeOrdenTrabajoMat.TipoOperacion = "D"
            oeOrdenTrabajoMat.Activo = True
            '-------------------------------------
            oeOrdenTrabajo.Activo = True
            oeOrdenTrabajo.NroOT = oeOrden.Referencia
            oeOrdenTrabajo = olOrdenTrabajo.Obtener(oeOrdenTrabajo)
            oeOrdenTrabajoMat.IdOrdenTrabajo = oeOrdenTrabajo.Id 'oeOrden.Referencia
            '-------------------------------------
            oeOrdenTrabajoMat.IdMaterial = filaMat.IdMaterial
            oeOrdenTrabajoMat.CantidadMaterialDevuelto = filaMat.CantidadMaterial
            oeOrdenTrabajoMat.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOrdenTrabajoMat.Guardar(oeOrdenTrabajoMat)
        Next
    End Sub

    Sub ModificarCantidadDevolucionOA()
        Dim oeOrdenAsignacionMat As New e_OrdenAsignacion_Material, olOrdenAsignacionMat As New l_OrdenAsignacion_Material
        Dim olOrdenAsignacion As New l_OrdenAsignacion
        oeOrdenAsignacion = New e_OrdenAsignacion
        For Each filaMat As e_OrdenMaterial In listaOrdenMaterial
            oeOrdenAsignacionMat.TipoOperacion = "D"
            oeOrdenAsignacionMat.Activo = True
            '-------------------------------------
            oeOrdenAsignacion.Activo = True
            oeOrdenAsignacion.NroOA = oeOrden.Referencia
            oeOrdenAsignacion = olOrdenAsignacion.Obtener(oeOrdenAsignacion)
            oeOrdenAsignacionMat.IdOrdenAsignacion = oeOrdenAsignacion.Id
            '-------------------------------------
            oeOrdenAsignacionMat.IdMaterial = filaMat.IdMaterial
            oeOrdenAsignacionMat.CantidadMaterialDevuelto = filaMat.CantidadMaterial
            oeOrdenAsignacionMat.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOrdenAsignacionMat.Guardar(oeOrdenAsignacionMat)
        Next
    End Sub

    Private Sub GenerarSalidaDevolucion()
        Dim oeOrdenSalida As New e_Orden
        Dim oeDetalleOrdenSalida As New e_OrdenMaterial
        Dim loDetalleOrdenSalida As New List(Of e_OrdenMaterial)
        Dim oeRegInv As New e_RegistroInventario
        For Each obj As e_OrdenMaterial In listaOrdenMaterial
            oeDetalleOrdenSalida = New e_OrdenMaterial
            With oeDetalleOrdenSalida
                .Activo = True
                .IdMaterial = obj.IdMaterial
                .Material = obj.Material
                .CantidadMaterial = obj.CantidadMaterial
                .PrecioUnitario = obj.PrecioUnitario
                .IdSubAlmacen = BuscarSubAlmacen_Ingreso(oeOrdenAsignacion.Id)
                .IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                .IdUnidadMedida = obj.IdUnidadMedida
                .UnidadMedida = obj.UnidadMedida
                .ValorVenta = .PrecioUnitario * .CantidadMaterial
            End With
            loDetalleOrdenSalida.Add(oeDetalleOrdenSalida)
        Next
        With oeOrdenSalida
            oeOrdenSalida.lstOrdenMaterial = loDetalleOrdenSalida
            .Activo = True
            .IdMoneda = "1CH01" ' Soles 
            .IdTipoOrden = "1CH000000002" 'ORDEN DE SALIDA
            .IdProveedor = ISL_IdProveedor
            .IdMovimientoInventario = "1CH000000030" 'SALIDA POR DEVOLUCION
            .FechaOrden = ObtenerFechaServidor()
            .TipoOperacion = "D"
            .IdSubAlmacenDestino = ""
            .IdSubAlmacenOrigen = ""
            .TipoReferencia = "ORDEN INGRESO"
            .Referencia = oeOrden.NroOrden
            .UsuarioCreacion = gUsuarioSGI.Id
            .IdUsuarioEjecucion = gUsuarioSGI.Id
            loDetalleOrdenSalida = New List(Of e_OrdenMaterial)
        End With
        'oeOrdenSalida.lstRegistroInventario = New List(Of e_RegistroInventario)
        'For Each item As e_OrdenMaterial In listaOrdenMaterial
        '    oeRegInv = New e_RegistroInventario
        '    oeRegInv.Id = ""
        '    oeRegInv.IdUnidadMedida = item.IdUnidadMedida
        '    oeRegInv.Fecha = oeOrdenSalida.FechaOrden
        '    oeRegInv.IdMaterial = item.IdMaterial
        '    oeRegInv.Cantidad = item.CantidadMaterial
        '    oeRegInv.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
        '    oeRegInv.ValorUnitario = item.PrecioUnitario / (1 + oeIGVGlobal.Porcentaje)
        '    oeRegInv.ValorUnitarioReal = item.PrecioUnitario / (1 + oeIGVGlobal.Porcentaje)
        '    oeRegInv.ValorTotal = oeRegInv.ValorUnitarioReal * oeRegInv.CantidadReal
        '    oeRegInv.Activo = item.Activo
        '    oeRegInv.UsuarioCreacion = gUsuarioSGI.Id
        '    oeRegInv.IdSubAlmacen = BuscarSubAlmacen_Ingreso(oeOrdenAsignacion.Id)
        '    oeRegInv.IdMovimientoInventario = "1CH000000030" 'SALIDA POR DEVOLUCION
        '    oeRegInv.TipoOperacion = "I"
        '    oeOrdenSalida.lstRegistroInventario.Add(oeRegInv)
        'Next
        'olOrden.Guardar(oeOrdenSalida)
    End Sub

    Sub EjecutarOI()
        listaRegistroInventario = New List(Of e_RegistroInventario)
        listaInventario = New List(Of e_Inventario)
        TransponerRegistroInv()
        olRegistroInventario.Guardar(listaRegistroInventario)
        Select Case oeOrden.IdMovimientoInventario
            Case "1CH000000013" ' MANTENIMIENTO - DEVOLUCION
                ModificarCantidadDevolucionOT()
            Case "1CH000000018" ' DEVOLUCION
                ModificarCantidadDevolucionOA()
                GenerarSalidaDevolucion()
        End Select
    End Sub
    '
    Sub TransponerRegistroInv()
        For Each item As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            oeRegistroInventario = New e_RegistroInventario
            oeRegistroInventario.Id = ""
            oeRegistroInventario.IdMovimientoInventario = oeOrden.IdMovimientoInventario
            oeRegistroInventario.IdMaterial = item.IdMaterial
            oeRegistroInventario.IdUnidadMedida = item.IdUnidadMedida
            oeRegistroInventario.Cantidad = item.CantidadMaterial
            oeRegistroInventario.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
            oeRegistroInventario.ValorUnitario = Math.Round(item.PrecioUnitario / (1 + oeIGV.Porcentaje), 4)
            oeRegistroInventario.ValorUnitarioReal = oeRegistroInventario.ValorUnitario
            If oeOrden.IdMoneda = "1CH02" Then
                oeRegistroInventario.ValorUnitarioReal = Math.Round(oeRegistroInventario.ValorUnitarioReal * TipoCambio(oeOrden.FechaOrden, 1)(0), 4)
                oeRegistroInventario.ValorUnitario = Math.Round(oeRegistroInventario.ValorUnitario * TipoCambio(oeOrden.FechaOrden, 1)(0), 4)
            End If
            oeRegistroInventario.ValorTotal = Math.Round(oeRegistroInventario.CantidadReal * oeRegistroInventario.ValorUnitarioReal, 4)
            oeRegistroInventario.Activo = item.Activo
            oeRegistroInventario.UsuarioCreacion = oeOrden.UsuarioCreacion
            oeRegistroInventario.Fecha = oeOrden.FechaOrden
            oeRegistroInventario.IdSubAlmacen = item.IdSubAlmacen
            oeRegistroInventario.TipoOperacion = oeOrden.TipoOperacion
            oeRegistroInventario.IdOrden = oeOrden.Id
            oeRegistroInventario.PrefijoID = gs_PrefijoIdSucursal '@0001
            listaRegistroInventario.Add(oeRegistroInventario)
        Next
    End Sub

    Private Sub ImportarArchivo()
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
                        oeComboAlmacen.Descripcion = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                        If AlmNombrePublic.Contains(oeComboAlmacen) Then
                            oeComboAlmacen = AlmNombrePublic.Item(AlmNombrePublic.IndexOf(oeComboAlmacen))
                        End If
                        oeOrdenMaterial = New e_OrdenMaterial
                        oeOrdenMaterial.Seleccion = False
                        oeOrdenMaterial.TipoOperacion = "I"
                        oeOrdenMaterial.IdMaterial = oeComboMaterial.Id
                        oeOrdenMaterial.Material = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                        oeOrdenMaterial.CodigoMaterial = oeComboMaterial.Nombre
                        oeOrdenMaterial.CantidadMaterial = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                        oeOrdenMaterial.IdAlmacen = oeComboAlmacen.Id.Trim
                        oeOrdenMaterial.IdSubAlmacen = oeComboAlmacen.Nombre.Trim
                        oeOrdenMaterial.PrecioUnitario = ObtenerValorUnitario(oeOrdenMaterial.IdMaterial, oeOrdenMaterial.IdSubAlmacen)
                        oeOrdenMaterial.Almacen = ""
                        If oeComboMaterial.Descripcion.Length > 0 Then
                            oeOrdenMaterial.IdTipoUnidadMedida = oeComboMaterial.Descripcion.Substring(0, 12)
                            oeOrdenMaterial.IdUnidadMedida = oeComboMaterial.Descripcion.Substring(12)
                        End If                     
                        oeOrdenMaterial.UnidadMedida = ""
                        oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                        oeOrdenMaterial.Activo = True
                        listaOrdenMaterial.Add(oeOrdenMaterial)
                    Else
                        Exit For
                    End If
                Next
                griOrdenMaterial.DataSource = listaOrdenMaterial
                griOrdenMaterial.DataBind()
                llenaCombosGrillaOrdenMaterial()
                CalcularTotalesDetalle()
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
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function MostrarOrden(ByVal IdOrden As String) As Boolean
        Operacion = "Ayuda"
        Try
            Inicializar()
            oeOrden = New e_Orden
            oeOrden.Id = IdOrden
            oeOrden = olOrden.Obtener(oeOrden)
            CargarOrden()
            ValidarFicha()
            HabInhVisualizacion(True)
            MostrarTabs(1, ficOrden, 1)
            griOrdenMaterial.DisplayLayout.Bands(0).Columns("Stock").Hidden = True
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub CargarOrden()
        oeOrden.TipoOrden = ObtenerTipoOrden("ORDEN DE INGRESO")
        cboMovimientoInventario.Value = oeOrden.IdMovimientoInventario
        ListarProveedores(cboProveedor, oeOrden.IdProveedor)
        cboProveedor.Value = oeOrden.IdProveedor
        cboMoneda.Value = oeOrden.IdMoneda
        fecFechaOrden.Value = oeOrden.FechaOrden
        txtGlosa.Text = oeOrden.Glosa
        txtEstadoOrden.Text = oeOrden.EstadoOrden
        txtNroOrden.Text = oeOrden.NroOrden
        verActivo.Checked = oeOrden.Activo
        MostrarDocAsociado()
        If oeOrden.EstadoOrden = "TERMINADA" Then
            'Cargar los movimientos
            oeRegistroInventario = New e_RegistroInventario
            oeRegistroInventario.IdOrden = oeOrden.Id
            listaRegistroInventario = olRegistroInventario.ListarSOrden(oeRegistroInventario)
            griOrdenMovimientos.DataSource = listaRegistroInventario
            Inhabilitar(False)
        End If
        ConsultarOrdenMaterial()
        CalcularTotalesDetalle()
        decTotal.Value = oeOrden.Total

        'leDetOrdenNeu = New List(Of e_DetalleOrdenNeumatico)
        'oeDetOrdenNeu = New e_DetalleOrdenNeumatico
        'oeDetOrdenNeu.TipoOperacion = "O"
        'oeDetOrdenNeu.IdOrdenMaterial = oeOrden.Id
        'leDetOrdenNeu = olDetOrdenNeu.Listar(oeDetOrdenNeu)

        muestra = True
    End Sub

    Private Function GuardarOrden() As Boolean
        Try
            oeOrden.lstOrdenMaterial = listaOrdenMaterial
            oeOrden.IdSubAlmacenDestino = ""
            oeOrden.IdSubAlmacenOrigen = ""
            oeOrden.FechaOrden = fecFechaOrden.Value
            'Orden Asociada
            If GriAsocDoc.Rows.Count > 0 Then
                oeOrden.TipoDocumento = lstMovimientoDocumentoAsoc.Item(0).IdTipoDocumento
                oeOrden.IdDocumento = lstMovimientoDocumentoAsoc.Item(0).Id
            End If
            If oeOrden.IdMovimientoInventario = "1CH000000037" Or oeOrden.IdMovimientoInventario = "1CH000000035" Then
                If oeOrden.TipoDocumento = "" Then Throw New Exception("No Puede Ejecutar Ordenes sin Documentos Asociados")
            End If
            If oeOrden.IdMovimientoInventario = "1SI000000002" Then
                If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR AJUSTES INV") Then Throw New Exception("No Tiene Permisos para este Movimiento Inventario")
            ElseIf oeOrden.IdMovimientoInventario = "1CH000000018" Then
                If gUsuarioSGI.oeArea.Nombre <> gNombreAreaInformaticaSistemas And gUsuarioSGI.oeArea.Nombre <> gNombreAreaLogistica Then
                    If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR AJUSTES INV") Then Throw New Exception("No Tiene Permisos para este Movimiento Inventario")
                End If
            Else
                If gUsuarioSGI.oeArea.Nombre <> gNombreAreaInformaticaSistemas And gUsuarioSGI.oeArea.Nombre <> gNombreAreaLogistica Then
                    If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR AJUSTES INV") Then Throw New Exception("No Tiene Permisos para este Movimiento Inventario")
                End If
            End If
            If oeOrden.TipoOperacion = "T" Then
                oeOrden.IdUsuarioEjecucion = gUsuarioSGI.Id
                If oeOrden.IdMovimientoInventario = "1CH000000013" Or oeOrden.IdMovimientoInventario = "1CH000000018" Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                        Exit Function
                    Else
                        For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                            oeControlEntregaMaterial = New e_ControlEntregaMaterial
                            oeControlEntregaMaterial.TipoOperacion = "I"
                            oeControlEntregaMaterial.FechaCreacion = Date.Now
                            oeControlEntregaMaterial.CantidadEntregada = ordmat.CantidadMaterial
                            oeControlEntregaMaterial.IdTrabajador = formulario.idTrabajador
                            oeControlEntregaMaterial.UsuarioCreacion = gUsuarioSGI.Id
                            oeControlEntregaMaterial.IdUnidadMedida = ordmat.IdUnidadMedida
                            ordmat.oeControlEntregaMat = oeControlEntregaMaterial
                        Next
                    End If
                    formulario = Nothing
                End If
                If oeOrden.IdMovimientoInventario = "1CH000000039" Then
                    For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        If ordmat.IdAlmacen <> "1SI000000003" Then Throw New Exception("El Ingreso por Baja solo puede ser al Almacen de Baja de Repuestos")
                    Next
                End If
                oeOrden.loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
                If oeOrden.IdMovimientoInventario = "1CH000000013" Or oeOrden.IdMovimientoInventario = "1CH000000018" Then
                    'Dim IdAlmacenPrincipal As String = ""
                    Dim oeComboPropio As New e_Combo
                    oeComboPropio.Tipo = 3
                    oeComboPropio.Nombre = "0"
                    For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        oeComboPropio.Id = ordmat.IdAlmacen
                        If AlmacenesPublic.Contains(oeComboPropio) Then
                            ordmat.IndPropio = True
                        End If
                    Next
                    If oeOrden.lstOrdenMaterial.Where(Function(i) i.IndPropio).Count > 0 Then
                        Dim oePeriodo As New e_Periodo
                        Dim olPeriodo As New l_Periodo
                        Dim fechaactual As Date = ObtenerFechaServidor.Date
                        oePeriodo.Ejercicio = fechaactual.Year
                        oePeriodo.Mes = fechaactual.Month
                        oePeriodo = olPeriodo.Obtener(oePeriodo)
                        If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
                        oeOrden.IndAsiento = True
                        oeOrden.NombreProveedor = cboProveedor.Text
                        oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
                        ObtenerAsientoModelo(cboMoneda.Value, oePeriodo.Ejercicio)
                        LlenaCuentaOrden(oeOrden, oePeriodo.Ejercicio, loCtaCtbleSFam)
                        oeOrden.IdPeriodo = oePeriodo.Id
                        oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
                    End If
                End If
            Else
                If gUsuarioSGI.oeArea.Nombre = gNombreAreaMantenimiento Then
                    If oeOrden.IdMovimientoInventario <> "1CH000000039" Then
                        Throw New Exception("Mantenimiento solo Puede Crear Ordenes de Ingreso por Baja")
                    End If
                    For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        If ordmat.IdAlmacen <> "1SI000000003" Then Throw New Exception("Usuarios de Mantenimiento Solo pueden Generar Ordenes al Almacen de Baja")
                    Next
                ElseIf gUsuarioSGI.oeArea.Nombre <> gNombreAreaInformaticaSistemas Then
                    If oeOrden.IdMovimientoInventario = "1CH000000021" Then
                        Throw New Exception("No tiene Permisos para Crear Movimientos x Saldo de Inventario")
                    End If
                Else
                    For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        If ordmat.IdAlmacen = "1SI000000003" Then Throw New Exception("El Almacen de Baja de Repuestos solo puede ser Llenado por Mantenimiento")
                    Next
                End If
            End If
            oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olOrden.Guardar(oeOrden, New List(Of e_RegistroInventario)) Then Return False
            Select Case oeOrden.TipoOperacion
                Case "T"
                    EjecutarOI()
                    If oeOrden.IdMovimientoInventario = "1CH000000013" Or oeOrden.IdMovimientoInventario = "1CH000000018" Then
                        Dim frm As New frm_ImprimirMaterialEntregado
                        Dim id As String = ""
                        For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                            id = ordmat.Id
                        Next
                        frm.CargarDatos(id, "I")
                        frm.ShowDialog()
                    End If
                    mensajeEmergente.Confirmacion("Se ejecuto satisfactoriamente en " & Me.Text)
                Case Else
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            End Select
            Consultar(True)
            MostrarTabs(0, ficOrden)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Function

    Public Sub ControlaBarraOperacionesDetalle(ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean)
        o_Botonera.Nuevo = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar
        Botones(o_Botonera)
    End Sub

    Private Sub UnidadMedidaValueList(ByVal ls_IdTipoUnidadMedida As String, ByVal stGrilla As UltraWinGrid.UltraGrid)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            stGrilla.DisplayLayout.ValueLists.Clear()
            objValueList = stGrilla.DisplayLayout.ValueLists.Add("Medidas")

            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Nombre = ""
            oeUnidadMedida.IdTipoUnidadMedida = ls_IdTipoUnidadMedida
            Dim dt As DataTable = olUnidadMedida.ComboGrilla(oeUnidadMedida)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AlmacenValueList(ByVal ls_IdMaterial As String)
        Try
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.griListaMateriales.DisplayLayout.ValueLists.Clear()
            objValueList = Me.griListaMateriales.DisplayLayout.ValueLists.Add("Almacenes")

            oeMaterialAlmacen = New e_MaterialAlmacen
            oeMaterialAlmacen.TipoOperacion = "4"
            oeMaterialAlmacen.Activo = True
            oeMaterialAlmacen.IdMaterial = ls_IdMaterial
            Dim dt As DataTable = olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen)
            For i As Integer = 0 To dt.Rows.Count - 1
                objValueList.ValueListItems.Add(dt.Rows(i).Item("Id"), dt.Rows(i).Item("Nombre"))
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.griOrdenMaterial.DisplayLayout.ValueLists.Clear()
            objValueList = Me.griOrdenMaterial.DisplayLayout.ValueLists.Add("SubAlmacenes")
            oeSubalmacen = New e_SubAlmacen
            oeSubalmacen.TipoOperacion = "S"
            oeSubalmacen.Activo = True
            oeSubalmacen.IdAlmacen = ls_IdAlmacen
            lstSubAlmacen = olSubalmacen.Listar_SubAlmacen(oeSubalmacen)
            For Each item As e_SubAlmacen In lstSubAlmacen
                objValueList.ValueListItems.Add(item.Id, item.Descripcion)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarMateriales()
       Try
            Me.Cursor = Cursors.WaitCursor
            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Tipo = 1
                listaMaterial = olMaterial.Listar_(oeMaterial)
                '-----
                With griListaMateriales
                    .DataSource = listaMaterial
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                End With
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        For Each filaOrdMat As e_OrdenMaterial In listaOrdenMaterial
            If (oeMat.Id = filaOrdMat.IdMaterial) Then Return True
        Next
    End Function

    Public Sub llenaCombosGrillaOrdenMaterial()
        For j As Integer = 0 To griOrdenMaterial.Rows.Count - 1
            oeUnidadMedida = New e_UnidadMedida()
            oeUnidadMedida.Activo = True
            oeUnidadMedida.Factor = 0
            oeUnidadMedida.IdTipoUnidadMedida = griOrdenMaterial.Rows(j).Cells("IdTipoUnidadMedida").Value.ToString
            CrearComboGridPorCelda("IdUnidadMedida", "Nombre", j, griOrdenMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

            'oeMaterialAlmacen = New e_MaterialAlmacen
            'oeMaterialAlmacen.TipoOperacion = "4"
            'oeMaterialAlmacen.Activo = True
            'oeMaterialAlmacen.IdMaterial = griOrdenMaterial.Rows(j).Cells("IdMaterial").Value.ToString
            'CrearComboGridPorCelda("IdAlmacen", "Nombre", j, griOrdenMaterial, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)

            oeSubalmacen = New e_SubAlmacen
            oeSubalmacen.TipoOperacion = "S"
            oeSubalmacen.Activo = True
            oeSubalmacen.IdAlmacen = griOrdenMaterial.Rows(j).Cells("IdAlmacen").Value.ToString
            CrearComboGridPorCelda("IdSubAlmacen", "Nombre", j, griOrdenMaterial, olSubalmacen.ComboGrilla(oeSubalmacen), True)
        Next
        griOrdenMaterial.DataBind()
    End Sub

    Private Sub llenarComboFiltroMovimiento()
        Try
            oeMovimientoInventario.Id = "CERO"
            oeMovimientoInventario.Nombre = "TODOS"
            listaMovimientoInventario.Add(oeMovimientoInventario)
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.TipoOperacion = "1"
            oeMovimientoInventario.Activo = True
            listaMovimientoInventario.AddRange(olMovimientoInventario.Listar(oeMovimientoInventario))
            LlenarComboMaestro(cboFiltroMovimiento, listaMovimientoInventario, 0)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub llenarComboFiltroEstadoOrden()
        Try
            oeEstadoOrden.Id = "CERO"
            oeEstadoOrden.Nombre = "TODOS"
            listaEstadoOrden.Add(oeEstadoOrden)
            oeEstadoOrden = New e_EstadoOrden
            oeEstadoOrden.TipoOperacion = "1"
            oeEstadoOrden.Activo = True
            listaEstadoOrden.AddRange(olEstadoOrden.Listar(oeEstadoOrden))
            LlenarComboMaestro(cboEstadoOrden, listaEstadoOrden, 0)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub AsignarOrdenMaterial(ListaMatNegDet As List(Of e_MaterialesNegociadosDet), Optional ByVal IndCantidad As Boolean = 0)
        Try
            For Each obj As e_Material In listaMaterial.Where(Function(item) item.Seleccion)
                oeOrdenMaterial = New e_OrdenMaterial
                oeOrdenMaterial.Seleccion = False
                oeOrdenMaterial.IdMaterial = obj.Id
                oeOrdenMaterial.Material = obj.Nombre
                oeOrdenMaterial.CantidadMaterial = 1
                If IndCantidad Then oeOrdenMaterial.CantidadMaterial = obj.Peso 'Envia la cantidad q esta en el Documento
                oeOrdenMaterial.IdAlmacen = obj.IdAlmacen
                oeOrdenMaterial.IdSubAlmacen = obj.IdSubAlmacen
                If cboMovimientoInventario.Value = "1CH000000037" Then
                    Dim oeMatNegDet As New e_MaterialesNegociadosDet
                    oeMatNegDet.IdMaterial = obj.Id
                    If ListaMatNegDet.Contains(oeMatNegDet) Then
                        oeMatNegDet = ListaMatNegDet.Item(ListaMatNegDet.IndexOf(oeMatNegDet))
                        If oeMatNegDet.IdMoneda <> cboMoneda.Value Then
                            oeOrdenMaterial.PrecioUnitario = oeMatNegDet.Precio / TipoCambio(fecFechaOrden.Value, 1)(0)
                        Else
                            oeOrdenMaterial.PrecioUnitario = oeMatNegDet.Precio
                        End If
                    Else
                        Throw New Exception("Material sin Precio Negociado. Verificar")
                    End If
                Else
                    oeOrdenMaterial.PrecioUnitario = ObtenerValorUnitario(obj.Id, obj.IdSubAlmacen)
                End If
                oeOrdenMaterial.Almacen = obj.Almacen
                oeOrdenMaterial.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                oeOrdenMaterial.IdUnidadMedida = obj.IdUnidadMedida
                oeOrdenMaterial.UnidadMedida = obj.UnidadMedida
                oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                oeOrdenMaterial.Activo = True
                oeOrdenMaterial.CodigoMaterial = obj.Codigo
                listaOrdenMaterial.Add(oeOrdenMaterial)
            Next
            griOrdenMaterial.DataSource = listaOrdenMaterial
            griOrdenMaterial.DataBind()
            txtBuscarMateriales.Value = String.Empty
            llenaCombosGrillaOrdenMaterial()
            listaMaterial.RemoveAll(Function(item) item.Seleccion)
            griListaMateriales.DataBind()
            CalcularTotalesDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarSeleccionado(ByVal obj As e_OrdenMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(obj.IdMaterial) Then
                If obj.Seleccion Then
                    Dim oeMaterial As New e_Material
                    oeMaterial.Id = obj.IdMaterial
                    oeMaterial.IdAlmacen = obj.IdAlmacen
                    oeMaterial.IdSubAlmacen = obj.IdSubAlmacen
                    oeMaterial.TipoOperacion = "5"
                    oeMaterial.Activo = True
                    oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                    listaMaterial.Add(oeMaterial)
                End If
            End If
            Return obj.Seleccion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub QuitarOrdenMaterial()
        Try
            Dim sw As Boolean = False

            For Each lista As e_OrdenMaterial In listaOrdenMaterial
                If lista.Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")

            If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                listaOrdenMaterial.RemoveAll(AddressOf verificarSeleccionado)
                griListaMateriales.DataBind()
                griOrdenMaterial.DataBind()
                CalcularTotalesDetalle()
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub QuitarAsociacionDocumento()
        Try
            If GriAsocDoc.Selected.Rows.Count > 0 Then
                If MessageBox.Show("¿Esta seguro de quitar el documento asociado a la orden ", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    LimpiarDocAsoc()
                    If GriAsocDoc.Rows.Count > 0 Then
                        griOrdenMaterial.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    Else
                        griOrdenMaterial.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LimpiarDocAsoc()
        lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
        listaOrdenMaterial = New List(Of e_OrdenMaterial)
        griOrdenMaterial.DataSource = listaOrdenMaterial
        griOrdenMaterial.DataBind()
        GriAsocDoc.DataSource = lstMovimientoDocumentoAsoc
        GriAsocDoc.DataBind()
        CalcularTotalesDetalle()
    End Sub

    Public Function EditarOrden() As Boolean
        Try
            Inicializar()
            If griListaOrden.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                oeOrden.Id = griListaOrden.ActiveRow.Cells("Id").Value.ToString
                oeOrden = olOrden.Obtener(oeOrden)
                If oeOrden.TipoReferencia <> "" Then
                    ActivarControles(False)
                Else
                    ActivarControles(True)
                End If
                oeOrden.TipoOrden = ObtenerTipoOrden("ORDEN DE INGRESO")
                cboMovimientoInventario.Value = oeOrden.IdMovimientoInventario
                ListarProveedores(cboProveedor, oeOrden.IdProveedor)
                cboProveedor.Value = oeOrden.IdProveedor
                cboMoneda.Value = oeOrden.IdMoneda
                fecFechaOrden.Value = oeOrden.FechaOrden
                txtGlosa.Text = oeOrden.Glosa
                txtEstadoOrden.Text = oeOrden.EstadoOrden
                txtNroOrden.Text = oeOrden.NroOrden
                verActivo.Checked = oeOrden.Activo
                'VERIFICANDO DOCUMENTO ASOCIADO A LA ORDEN
                MostrarDocAsociado()
                If griListaOrden.ActiveRow.Cells("TipoReferencia").Value = "" Then
                    If GriAsocDoc.Rows.Count > 0 Then
                        griOrdenMaterial.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True

                        griOrdenMaterial.DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                        griOrdenMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellClickAction = CellClickAction.RowSelect
                        griOrdenMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellClickAction = CellClickAction.EditAndSelectText
                    Else
                        griOrdenMaterial.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    End If
                End If
                '--
                If (oeOrden.EstadoOrden = gNombreEstadoTerminada Or oeOrden.EstadoOrden = gNombreEstadoOrdenRecepcionado) Then
                    'Cargar los movimientos
                    oeRegistroInventario = New e_RegistroInventario
                    oeRegistroInventario.IdOrden = oeOrden.Id
                    listaRegistroInventario = olRegistroInventario.ListarSOrden(oeRegistroInventario)
                    griOrdenMovimientos.DataSource = listaRegistroInventario
                    'Inhabilito el formulario
                    ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                    Inhabilitar(False)
                End If
                ConsultarOrdenMaterial()
                CalcularTotalesDetalle()
                decTotal.Value = oeOrden.Total
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub ActivarControles(ByVal Activo As Boolean)
        cboMovimientoInventario.Enabled = Activo
        cboProveedor.Enabled = Activo
        cboMoneda.Enabled = Activo
        fecFechaOrden.Enabled = Activo
        If Activo = 0 Then
            Inhabilitar(False)
            If cboMovimientoInventario.Value = "1CH000000013" Or cboMovimientoInventario.Value = "1CH000000018" Then '1CH000000018 = DEVOLUCION O 1CH000000013 = MATENIMIENTO - DEVOLUCION
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            Else
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 1)
            End If
        Else
            Inhabilitar(True)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub MostrarDocAsociado()
        Try
            oeOrdenDoc = New e_Orden_Documento
            oeOrdenDoc.TipoOperacion = "D"
            oeOrdenDoc.IdOrden = oeOrden.Id
            oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
            lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
            oeMovimientoDocumento = olOrdenDoc.ObtenerDocumento(oeOrdenDoc)
            GriAsocDoc.DataSource = lstMovimientoDocumentoAsoc
            If oeMovimientoDocumento.Id.Length > 0 Then
                oeOrden.TipoOperDocAsoc = "A"
                lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
                GriAsocDoc.DataBind()
            Else
                oeOrden.TipoOperDocAsoc = "I"
            End If
            If oeMovimientoDocumento.Id.Length = 0 Then
                oeOrdenDoc = New e_Orden_Documento
                oeOrdenDoc.TipoOperacion = ""
                oeOrdenDoc.IdOrden = oeOrden.Id
                oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
                oeOrdenDoc.Activo = True
                oeOrdenDoc = olOrdenDoc.Obtener(oeOrdenDoc)
                'VERIFICANDO GR-REMITENTE ASOCIADO A LA ORDEN
                If Not String.IsNullOrEmpty(oeOrdenDoc.Id) Then
                    oeOrdenDoc.TipoOperacion = "G"
                    oeGRRemitente = New e_GuiaRemisionRemitente
                    oeGRRemitente = olOrdenDoc.ObtenerDocumentoGuiaRemision(oeOrdenDoc)
                    If oeGRRemitente.Id.Length > 0 Then
                        oeMovimientoDocumento = New e_MovimientoDocumento
                        oeMovimientoDocumento.Id = oeGRRemitente.Id
                        oeMovimientoDocumento.NombreDocumento = oeGRRemitente.Serie & " - " & oeGRRemitente.Numero
                        oeMovimientoDocumento.IdTipoDocumento = oeGRRemitente.IdTipoGuia
                        oeMovimientoDocumento.FechaEmision = oeGRRemitente.Fecha
                        oeMovimientoDocumento.IdClienteProveedor = oeGRRemitente.IdEmpresaProveedor
                        oeMovimientoDocumento.NombreProveedor = oeGRRemitente.Nombre
                        oeMovimientoDocumento.Serie = oeGRRemitente.Serie
                        oeMovimientoDocumento.Numero = oeGRRemitente.Numero
                        oeMovimientoDocumento.IdEstadoDocumento = oeGRRemitente.IdEstado
                        oeMovimientoDocumento.EstadoDocumento = oeGRRemitente.Estado
                        oeMovimientoDocumento.Moneda = String.Empty
                        oeMovimientoDocumento.IdMoneda = String.Empty
                        oeMovimientoDocumento.SubTotal = 0.0
                        oeMovimientoDocumento.IGV = 0.0
                        oeMovimientoDocumento.Total = 0.0
                        oeMovimientoDocumento.TipoCambio = 0.0
                        oeMovimientoDocumento.TipoPago = String.Empty
                        oeMovimientoDocumento.IdTipoPago = String.Empty
                        oeOrden.TipoOperDocAsoc = "A"
                        lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
                        GriAsocDoc.DataBind()
                    Else
                        oeOrden.TipoOperDocAsoc = "I"
                    End If
                End If
            End If
            If GriAsocDoc.Rows.Count > 0 Then
                GriAsocDoc.Focus()
                GriAsocDoc.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConsultarOrdenMaterial()
        Try
            ListarOrdenMaterial(True)
            If griOrdenMaterial.Rows.Count > 0 Then
                ControlaBarraOperacionesDetalle(True, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idSubAlmacen As String) As String
        Try
            Dim oeCombo As New e_Combo
            oeCombo.Id = idMaterial
            oeCombo.Nombre = idSubAlmacen
            oeCombo.Tipo = 3

            If MatPreSubAlmPublic.Contains(oeCombo) Then
                oeCombo = MatPreSubAlmPublic.Item(MatPreSubAlmPublic.IndexOf(oeCombo))
                Return CDbl(oeCombo.Descripcion) * (1 + oeIGVGlobal.Porcentaje)
            Else
                Return 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AsociarDocumento()
        Try
            If lstMovimientoDocumentoAsoc.Count = 1 Then
                Exit Sub
            End If
            oeMovimientoDocumento = New e_MovimientoDocumento
            oeMovimientoDocumento = griListaDoc.ActiveRow.ListObject
            lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
            GriAsocDoc.DataBind()
            ListarProveedores(cboProveedor, oeMovimientoDocumento.IdClienteProveedor)
            cboProveedor.Value = oeMovimientoDocumento.IdClienteProveedor
            loMaterialesNegociadosDet = New List(Of e_MaterialesNegociadosDet)
            loMaterialesNegociadosDet.AddRange(CargarPreciosNegociados(oeMovimientoDocumento.IdClienteProveedor))
            'Obtener los Detalles del Documento Asociado
            If cboTipoDoc.Value <> "1CH000000027" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.TipoOperacion = "CDO"
                oeMovimientoDocumento.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento.Activo = True
                listaMaterial = olMovimientoDocumento.ListarDetallesPorDocumentos(oeMovimientoDocumento)
                AsignarOrdenMaterial(loMaterialesNegociadosDet, 1)
                griOrdenMaterial.DataBind()
            Else
                oeGRRemitente = New e_GuiaRemisionRemitente
                oeGRRemitente.TipoOperacion = "G"
                oeGRRemitente.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeGRRemitente.Activo = True
                listaMaterial = olGRRemitente.ObtenerDetallesGr(oeGRRemitente)
                AsignarOrdenMaterial(loMaterialesNegociadosDet, 1)
                griOrdenMaterial.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub RectificarOI()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "") Then
                Editar()
                IndRectificar = 1
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.AllowEdit
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellActivation = Activation.AllowEdit
                griOrdenMaterial.DisplayLayout.Bands(0).Columns("IdAlmacen").CellActivation = Activation.NoEdit
                Inhabilitar(True)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                lbl_etiqueta.Text = "Rectifica OI" : lbl_etiqueta.Visible = 1
                oeOrden.TipoOperacion = "R"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function CargarPreciosNegociados(IdProveedor As String) As List(Of e_MaterialesNegociadosDet)
        Try
            Dim oeMatNeg As New e_MaterialesNegociados
            Dim olMatNeg As New l_MaterialesNegociados
            Dim oeMatNegDet As New e_MaterialesNegociadosDet
            Dim olMatNegDet As New l_MaterialesNegociadosDet
            Dim loMatNegDet As New List(Of e_MaterialesNegociadosDet)
            oeMatNeg.TipoOperacion = "1"
            oeMatNeg.IdProveedor = IdProveedor
            oeMatNeg = olMatNeg.Obtener(oeMatNeg)
            oeMatNegDet.TipoOperacion = "1"
            oeMatNegDet.IdMaterialesNegociados = oeMatNeg.Id
            loMatNegDet.AddRange(olMatNegDet.Listar(oeMatNegDet))
            Return loMatNegDet

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function PermisoEjecucion() As Boolean
        If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR ORDENES") Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeOrd As New e_Orden
            oeOrd.Id = griListaOrden.ActiveRow.Cells("Id").Value
            oeOrd.TipoOperacion = "R"
            oeOrd.TipoOrden = Nothing
            oeOrd = olOrden.Obtener(oeOrd)
            If oeOrd.IdMovimientoInventario <> "" Then
                If oeOrd.UsuarioCreacion <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información de la Orden no es accesible pues esta siendo editado por el Usuario: " & Environment.NewLine & _
                                         oeOrd.UsuarioCreacion & Environment.NewLine & _
                                        "desde: " & oeOrd.FechaOrden & Environment.NewLine & _
                                        "en la Sucursal: " & oeOrd.IdEstadoOrden, True)
                    Return False
                Else
                    oeRegistroEditado = New e_RegistrosEditados
                    With oeRegistroEditado
                        .TipoOperacion = "A"
                        .Id = oeOrd.IdMovimientoInventario
                        .FechaModificado = DateAdd(DateInterval.Minute, 5, oeOrd.FechaOrden)
                    End With
                    oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
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
                .IdRegistro = griListaOrden.ActiveRow.Cells("Id").Value()
                .Referencia = "Orden"
                .UsuarioEdita = gUsuarioSGI.Id
            End With
            oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
            IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
        End If
    End Sub

    Private Sub ImprimirOrden()
        Dim id As String = ""
        Try
            If griListaOrden.Selected.Rows.Count > 0 Then
                Dim formulario As New frm_ImprimirOrden
                id = griListaOrden.ActiveRow.Cells("Id").Value
                formulario.CargarDatos(id)
                formulario.ShowDialog()
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_OrdenIngreso_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        InicializaTiempo()
    End Sub

    Private Sub griListaOrden_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaOrden.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            If griListaOrden.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 1, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            oeOrden = New e_Orden
            Inicializar()
            oeOrden.TipoOperacion = "I"
            oeOrden.TipoOperDocAsoc = "I"
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            oeOrden.Activo = True
            MostrarTabs(1, ficOrden, 1)
            If gUsuarioSGI.oeArea.Nombre = gNombreAreaLogistica Or gUsuarioSGI.oeArea.Nombre = gNombreAreaInformaticaSistemas Then
                MostrarTabs(1, ficDetalle, 0)
                gbDocAsociar.Expanded = True
            Else
                MostrarTabs(0, ficDetalle, 0)
            End If
            ControlaBarraOperacionesDetalle(True, True)
            cboMovimientoInventario.Focus()
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub HabInhVisualizacion(ByVal sw As Boolean)
        Me.etiEstado.Visible = sw
        Me.etiNroOrden.Visible = sw
        Me.txtEstadoOrden.Visible = sw
        Me.txtNroOrden.Visible = sw
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            If VerificarRegistroEditado() Then
                EditarOrden()
                GuardarRegistroEditado()
                oeOrden.TipoOperacion = "A"
                MostrarTabs(1, ficOrden, 1)
                ValidarFicha()
                HabInhVisualizacion(True)
            End If
            cboMovimientoInventario.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrden() Then
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Inicializar()
            If oeOrden.EstadoOrden = "TERMINADA" Or oeOrden.EstadoOrden = "RECEPCIONADO" Then
                oeOrden.Modificado = False
                MostrarTabs(0, ficOrden, 2)
                _ingresando_datos = False
                Consultar(True)
                ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
                Exit Sub
            End If
            'If oeOrden.Modificado Then
            '    Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '        Case Windows.Forms.DialogResult.Yes
            '            If GuardarOrden() Then
            '                MostrarTabs(0, ficOrden, 2)
            '                Consultar(True)
            '            Else

            '            End If
            '        Case Windows.Forms.DialogResult.No
            '            MostrarTabs(0, ficOrden, 2)
            '            _ingresando_datos = False
            '            Consultar(True)
            '        Case Windows.Forms.DialogResult.Cancel

            '    End Select
            'Else
            _ingresando_datos = False
            MostrarTabs(0, ficOrden, 2)
            Consultar(True)
            'End If
            ActualizaRegistroEditado(RegistroEditado, IdRegistroEditado)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griListaOrden.ActiveRow.Cells("EstadoOrden").Value = gNombreEstadoGenerada Then
                If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "ELIMINAR ORDENES (I,S)") Then 'And gUsuarioSGI.oeArea.Nombre = gNombreAreaLogistica
                    oeOrden.Id = griListaOrden.ActiveRow.Cells("Id").Value
                    oeOrden = olOrden.Obtener(oeOrden)
                    If Not oeOrden.Activo Then
                        Consultar(True)
                        Throw New Exception("La Orden ya fue Eliminada. Actualizar")
                    Else
                        If Trim(oeOrden.IdOrdenDocumento) = "" Then
                            If MessageBox.Show("Desea Eliminar la OI Nro: " & griListaOrden.ActiveRow.Cells("NroOrden").Value & "?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                                oeOrden.TipoOperacion = "E"
                                olOrden.Eliminar(oeOrden)
                                Consultar(True)
                            End If
                        Else
                            Throw New Exception("No puede Eliminar Orden Asociada a un Documento Contable")
                        End If
                    End If
                Else
                    Throw New Exception("No Tiene Permiso para Eliminar Ordenes de Ingreso")
                End If
            Else
                Throw New Exception("La Orden de Ingreso ya fue Ejecutada. No Puede Eliminarla!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ImprimirOrden()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            If griListaOrden.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOrden.SelectedTab.Index = 0 Then Exportar_Excel(griListaOrden)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Menú contextual del maestro de Orden de Ingreso"

    Private Sub AsociarMenu()
        griListaOrden.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        Try
            MenuContextual1.Items("InsertarToolStripMenuItem").Visible = 1
            MenuContextual1.Items("EjecutarToolStripMenuItem").Visible = 0
            'MenuContextual1.Items("RectificarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
            If griListaOrden.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 1
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
                If griListaOrden.ActiveRow.Cells("EstadoOrden").Value.ToString = "GENERADA" And griListaOrden.ActiveRow.Cells("TipoReferencia").Value <> "COMPRA" Then
                    MenuContextual1.Items("EjecutarToolStripMenuItem").Visible = 1
                    'Else
                    '    MenuContextual1.Items("RectificarToolStripMenuItem").Visible = 1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarToolStripMenuItem.Click
        Editar() : oeOrden.TipoOperacion = "T"
        Me.lbl_etiqueta.Text = "Ejecutar OI"
        Me.lbl_etiqueta.Visible = True
        ControlBoton(0, 0, 0, 1, 1)
    End Sub

    Private Sub RectificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RectificarOI()
    End Sub

#End Region

#Region "Asiento Modelo"

    Private Sub AsientoContable()
        AsientoModelo()
        CtaCtbleSubFamilia()
        dtReferencia = GeneraDTRef(loReferencia)
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

    Public Sub ObtenerAsientoModelo(IdMoneda As String, Ejercicio As Integer)
        Try
            Dim dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            cadSQL = "TipoRef1 = 4 AND IdRef1 = '" & IdMoneda & "'"
            _rwAux = dtReferencia.Select(cadSQL, "")
            If _rwAux.Count = 0 Then Throw New Exception("Error en el Modelo de Asiento Contable. Verificar")
            dtAux = _rwAux.CopyToDataTable
            oeAsientoModelo = New e_AsientoModelo
            oeAsientoModelo.TipoOperacion = "" : oeAsientoModelo.Activo = True
            oeAsientoModelo.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
            oeAsientoModelo.Ejercicio = Ejercicio
            oeAsientoModelo = olAsientoModelo.Obtener(oeAsientoModelo)
            oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
            oeOrden.loAsientoModelo.Add(oeAsientoModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class

