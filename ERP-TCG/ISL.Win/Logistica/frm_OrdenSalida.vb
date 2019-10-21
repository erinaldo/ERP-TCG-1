'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports Microsoft.Office.Interop

Public Class frm_OrdenSalida
    Inherits frm_MenuPadre

#Region "Declaración de variables"
    'Manejador de Centro
    Dim oeCentro As New e_Centro
    Dim olCentro As New l_Centro
    'Controla el Ingreso al load
    Dim muestra As Boolean = False
    'Manejador de Almacen
    Dim oeAlmacen As New e_Almacen
    Dim olAlmacen As New l_Almacen
    'Manejador de Subalmacen
    Dim oeSubalmacen As New e_SubAlmacen
    Dim olSubalmacen As New l_SubAlmacen
    'Manejador de Materiales
    Dim oeMaterial As New e_Material
    Dim olMaterial As New l_Material
    Dim listaMaterial As New List(Of e_Material)
    'Manejador de Inventario
    Dim oeRegistroInventario As New e_RegistroInventario
    Dim olRegistroInventario As New l_RegistroInventario
    Dim listaRegistroInventario As New List(Of e_RegistroInventario)
    'Manejador de Movimiento de Inventario
    Dim oeMovimientoInventario As New e_MovimientoInventario
    Dim olMovimientoInventario As New l_MovimientoInventario
    'Manejador de Tipo de Orden
    Dim oeTipoOrden As New e_TipoOrden
    Dim olTipoOrden As New l_TipoOrden
    'Manejador de estado orden
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
    'Manejador de Orden Material Almacen
    Dim oeMaterialAlmacen As New e_MaterialAlmacen
    Dim olMaterialAlmacen As New l_MaterialAlmacen
    'Manejador de Inventario
    Dim oeInventario As New e_Inventario
    Dim olInventario As New l_Inventario
    Dim listaInventario As New List(Of e_Inventario)
    Dim listaMovimientoInventario As New List(Of e_MovimientoInventario)
    'Manejador de Proveedores
    Dim oeProveedor As New e_Proveedor
    Dim olProveedor As New l_Proveedor
    'Manejador Orden Material
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

    'Validacion para que solo 1 usuario acceda a la orden
    Dim RegistroEditado As Integer = 0
    Dim IdRegistroEditado As String = ""
    Dim oeRegistroEditado As New e_RegistrosEditados
    Dim olRegistroEditado As New l_RegistrosEditados

    'asientos contables
    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Private oeCtaCtbleSFam As e_CtaCtbleSubFamiliaMat
    Private olCtaCtbleSFam As l_CtaCtbleSubFamiliaMat
    Private loCtaCtbleSFam, loCtaCtbleSFamOrden As List(Of e_CtaCtbleSubFamiliaMat)

    Private dtReferencia As New DataTable

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_OrdenSalida = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OrdenSalida
        End If
        instancia.Activate()
        Return instancia
    End Function
#End Region

#Region "Botones"

    Private Sub Botones(ByVal oeBoton As e_Boton)
        Try
            With MenuDet
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
            If Not sw Then Throw New Exception("Marque por lo menos un Material para Agregar a la Lista de Materiales de la Orden")
            AsignarOrdenMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub QuitarDetalle()
        Try
            If ficDetalle.SelectedTab.Index = 0 Then QuitarOrdenMaterial()
            If ficDetalle.SelectedTab.Index = 1 Then QuitarAsociacionDocumento()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Sub ConsultaDetalle()
        Try
            If ficDetalle.SelectedTab.Index = 0 Then ConsultarOrdenMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click
        QuitarDetalle()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        AgregarDetalle()
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub gridOrdenMaterial_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles gridOrdenMaterial.BeforeCellUpdate
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
    End Sub

    Private Sub txtNIngreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNSalida.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub frm_OrdenSalida_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Select Case Operacion
            Case "Editar"
                Select Case txtEstado.Text
                    Case "TERMINADA"
                        MyBase.Vista()
                        If IndRectificar Then MyBase.Editar()
                    Case Else
                        MyBase.Editar()
                End Select
            Case "Vista"
                MyBase.Vista()
            Case "Inicializa"
                Tiempo1.Enabled = False
                InicializaTiempo()
                MostrarTabs(0, ficDetalle)
                Consultar(True)
        End Select
        'If ficOrden.SelectedTab.Index = 0 Then
        '    Consultar(True)
        'End If
    End Sub

    Private Sub frm_OrdenSalida_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenSalida_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_OrdenSalida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not muestra Then
                gf_AsignarEventoSeleccionarTexto(Me)
                gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNSalida.Name, txtBuscarMateriales.Name, btnBuscarOrdenes.Name)
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                MostrarTabs(0, ficOrden)
                llenarComboFiltroMovimiento()
                llenarComboFiltroEstadoOrden()
                llenarComboMovimientos()
                rfOrdenSalidaDesde.Value = Date.Now.AddDays(-7)
                rfOrdenSalidaHasta.Value = Date.Now
                fecDesde.Value = Date.Now.AddDays(-30)
                InicializarColores()
                AsientoContable()
            End If
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

    Private Sub griListaMateriales_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaMateriales.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub gridListaOrden_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridListaOrden.AfterRowActivate
        btnEjecutar.Enabled = 0 : btnRectificar.Enabled = 0
        If gridListaOrden.ActiveRow.Index > -1 Then
            Select Case gridListaOrden.ActiveRow.Cells("EstadoOrden").Value
                Case "GENERADA"
                    btnEjecutar.Enabled = 1 : btnRectificar.Enabled = 0
                Case "TERMINADA"
                    btnEjecutar.Enabled = 0 : btnRectificar.Enabled = 1
            End Select
        End If
    End Sub

    Private Sub gridListaOrden_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridListaOrden.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        Eliminar()
        e.Cancel = True
    End Sub

    Private Sub gridListaOrden_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridListaOrden.CellChange
        gridListaOrden.UpdateData()
    End Sub

    Private Sub gridListaOrden_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridListaOrden.DoubleClick
        If gridListaOrden.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub ficDetalle_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficDetalle.SelectedTabChanged
        'ConsultaDetalle()
    End Sub

    Private Sub MenuDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles MenuDet.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Consultar"
                    ConsultarDetalle()
                Case "Agregar"
                    AgregarDetalle()
                Case "Eliminar"
                    QuitarDetalle()
                Case "Importar"
                    ImportarArchivo()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try        
    End Sub

    Private Sub txtNroOrden_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroOrden.ValueChanged
        oeOrden.NroOrden = txtNroOrden.Text
    End Sub

    Private Sub fecFechaOrden_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        oeOrden.Modificado = True
    End Sub

    Private Sub txtGlosa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGlosa.KeyDown
        oeOrden.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeOrden.Glosa = txtGlosa.Text
    End Sub

    Private Sub gridOrdenMaterial_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridOrdenMaterial.AfterCellUpdate
        Try
            With gridOrdenMaterial.Rows(e.Cell.Row.Index)

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
                        With gridOrdenMaterial
                            If .ActiveRow.Index > -1 Then
                                .ActiveRow.Cells("PrecioUnitario").Value = ObtenerValorUnitario(.ActiveRow.Cells("IdMaterial").Value, .ActiveRow.Cells("IdAlmacen").Value, 0)

                                SubAlmacenValueList(.ActiveRow.Cells("IdAlmacen").Value.ToString)
                                .ActiveRow.Cells("IdSubAlmacen").ValueList = .DisplayLayout.ValueLists("SubAlmacenes")

                                oeSubalmacen = New e_SubAlmacen
                                oeSubalmacen.TipoOperacion = "S"
                                oeSubalmacen.Activo = True
                                oeSubalmacen.IdAlmacen = .ActiveRow.Cells("IdAlmacen").Value.ToString
                                .ActiveRow.Cells("IdSubAlmacen").Value = olSubalmacen.Obtener(oeSubalmacen).Id
                            End If

                        End With
                    Case "CantidadMaterial"
                        Dim cantPorAtender As Integer
                        Dim stockActual As Double

                        With gridOrdenMaterial.ActiveRow
                            If .Index > -1 Then
                                cantPorAtender = Convert.ToInt32(.Cells("CantidadMaterial").Value)
                                stockActual = Convert.ToInt32(.Cells("Stock").Value)
                                If cantPorAtender > stockActual Then
                                    .Cells("CantidadMaterial").Value = 0
                                    Throw New Exception("No puede atender el material  '" & .Cells("Material").Value & "'  ya que la cantidad a atender es mayor que el stock actual.")
                                End If
                            End If
                            If IsDBNull(e.Cell.Value) Then
                                .Cells("CantidadMaterial").Value = 0
                                Exit Sub
                            End If
                        End With
                    Case "PrecioUnitario"
                        If IsDBNull(e.Cell.Value) Then
                            .Cells("PrecioUnitario").Value = 0
                            Exit Sub
                        End If

                End Select
                .Cells("ValorVenta").Value = Math.Round(.Cells("PrecioUnitario").Value, 4) * .Cells("CantidadMaterial").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub gridOrdenMaterial_AfterRowsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridOrdenMaterial.AfterRowsDeleted
        CalcularTotalesDetalle()
    End Sub

    Private Sub gridOrdenMaterial_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridOrdenMaterial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub gridOrdenMaterial_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridOrdenMaterial.CellChange
        Try
            gridOrdenMaterial.UpdateData()
            If oeOrden.EstadoOrden <> "TERMINADA" Then
                oeOrden.Modificado = True
            End If
            CalcularTotalesDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMoneda_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMoneda.ValueChanged
        oeOrden.IdMoneda = cboMoneda.Value
        oeOrden.Modificado = True
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        If verActivo.Checked Then
            oeOrden.Activo = True
        Else
            oeOrden.Activo = False
        End If
    End Sub

    Private Sub gridListaOrden_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridListaOrden.InitializeLayout
        agrOrdenesdeIngreso.Text = "Total de Ordenes de salida: " & gridListaOrden.Rows.Count.ToString()
    End Sub

    Private Sub rbNroOrden_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNroOrden.CheckedChanged
        Me.txtNSalida.Enabled = True
        gbOI.Enabled = rbNroOrden.Checked
        txtNSalida.Focus()
        InicializarLista()
    End Sub

    Private Sub rbDatosAdicionales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDatosAdicionales.CheckedChanged
        Me.txtNSalida.Enabled = False
        Me.txtNSalida.Text = String.Empty
        gbDatosAdicionales.Enabled = rbDatosAdicionales.Checked
        txtNSalida.Text = String.Empty
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        Try
            Editar() : oeOrden.TipoOperacion = "T"
            Me.lbl_etiqueta.Text = "Ejecutar OS"
            Me.lbl_etiqueta.Visible = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griListaMateriales_AfterCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.AfterCellUpdate
        Try
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With gridOrdenMaterial.Rows(e.Cell.Row.Index)

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
                Case "IdAlmacen"

                    With gridOrdenMaterial.ActiveRow
                        If .Index > -1 Then

                            .Cells("PrecioUnitario").Value = ObtenerValorUnitario(.Cells("IdMaterial").Value, .Cells("IdAlmacen").Value, 0)
                        End If
                    End With
            End Select
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub griListaMateriales_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaMateriales.CellChange
        griListaMateriales.UpdateData()
    End Sub

    Private Sub gbeMaterial_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If listaMaterial.Count = 0 Then
                ListarMaterial(True)
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnListarMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarMateriales.Click
        Try
            ListarMateriales()
        Catch ex As Exception
            mensajeEmergente.Confirmacion(ex.Message)
        End Try

    End Sub

    Private Sub txtBuscarMateriales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarMateriales.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ListarMateriales()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtBuscarMateriales_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscarMateriales.ValueChanged
        txtBuscarMateriales.Text = LTrim(txtBuscarMateriales.Text)
        oeMaterial.Nombre = txtBuscarMateriales.Text
    End Sub

    Private Sub griListaDoc_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griListaDoc.CellChange
        griListaDoc.UpdateData()
    End Sub

    Private Sub griListaDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaDoc.DoubleClick
        If griListaDoc.Rows.Count > 0 Then AsociarDocumento()
    End Sub

    Private Sub btnBuscarOrdenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrdenes.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If cboTipoDoc.Value <> "1CH000000027" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                With oeMovimientoDocumento
                    .FechaInicio = fecDesde.Value
                    .FechaFinal = fecHasta.Value
                    .Activo = True
                    .IdTipoDocumento = cboTipoDoc.Value
                    .IndCompraVenta = 2
                    .TipoOperacion = ""
                End With
                lstMovimientoDocumento = olMovimientoDocumento.ListarDocumentosPorCompras(oeMovimientoDocumento)
                griListaDoc.DataSource = lstMovimientoDocumento
                griListaDoc.DisplayLayout.Bands(0).Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
            Else
                oeGRRemitente.TipoOperacion = "3"
                oeGRRemitente.IdTipoGuia = cboTipoDoc.Value
                oeGRRemitente.fechaInicio = fecDesde.Value
                oeGRRemitente.fechaFin = fecHasta.Value
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
                    oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                    lstMovimientoDocumento.Add(oeMovimientoDocumento)
                Next
                griListaDoc.DataBind()
            End If

            With griListaDoc
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With


        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub fecFechaOrden_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecFechaOrden.Validated
        Try
            If fecFechaOrden.Value > Date.Now AndAlso Operacion = "Nuevo" Then
                fecFechaOrden.Value = Date.Now
                Throw New Exception("La Fecha no puede ser mayor al día actual")
            Else
                If fecFechaOrden.Value < UltimoDiaMesAnterior() AndAlso Operacion = "Nuevo" Then
                    fecFechaOrden.Value = Date.Now
                    Throw New Exception("La Fecha no puede ser tan antigua")
                Else
                    oeOrden.FechaOrden = fecFechaOrden.Value
                End If

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub decTotal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTotal.ValueChanged
        oeOrden.Total = decTotal.Value
    End Sub

    Private Sub btnRectificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectificar.Click
        RectificarOS()
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

    Private Sub gridOrdenMaterial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridOrdenMaterial.KeyDown
        Try
            With gridOrdenMaterial
                Dim int As Integer = .ActiveRow.Index
                If e.KeyCode = Keys.Down Then
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
                    If MenuDet.Enabled Then
                        QuitarDetalle()
                    End If
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GriAsocDoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles GriAsocDoc.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub gridOrdenMovimientos_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridOrdenMovimientos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griListaDoc_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaDoc.BeforeRowsDeleted
        e.Cancel = True
    End Sub

#End Region

#Region "Procedimientos del Formulario"

    Private Sub AsociarDocumento()
        Try
            If lstMovimientoDocumentoAsoc.Count > 0 And lstMovimientoDocumentoAsoc.Count < 2 Then
                Exit Sub
            End If
            oeMovimientoDocumento = New e_MovimientoDocumento
            With griListaDoc
                oeMovimientoDocumento.Id = .ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento.IdTipoDocumento = .ActiveRow.Cells("IdTipoDocumento").Value.ToString
                oeMovimientoDocumento.FechaEmision = .ActiveRow.Cells("FechaEmision").Value.ToString
                oeMovimientoDocumento.NombreProveedor = .ActiveRow.Cells("NombreProveedor").Value.ToString
                oeMovimientoDocumento.NombreDocumento = .ActiveRow.Cells("NombreDocumento").Value.ToString
                oeMovimientoDocumento.Serie = .ActiveRow.Cells("Serie").Value.ToString
                oeMovimientoDocumento.Numero = .ActiveRow.Cells("Numero").Value.ToString
                oeMovimientoDocumento.Moneda = .ActiveRow.Cells("Moneda").Value.ToString
                oeMovimientoDocumento.IdMoneda = .ActiveRow.Cells("IdMoneda").Value.ToString
                oeMovimientoDocumento.SubTotal = .ActiveRow.Cells("Subtotal").Value.ToString
                oeMovimientoDocumento.IGV = .ActiveRow.Cells("IGV").Value.ToString
                oeMovimientoDocumento.Total = .ActiveRow.Cells("Total").Value.ToString
                oeMovimientoDocumento.EstadoDocumento = .ActiveRow.Cells("EstadoDocumento").Value.ToString
                oeMovimientoDocumento.TipoCambio = .ActiveRow.Cells("TipoCambio").Value.ToString
                oeMovimientoDocumento.TipoPago = .ActiveRow.Cells("TipoPago").Value.ToString
                oeMovimientoDocumento.IdTipoPago = .ActiveRow.Cells("IdTipoPago").Value.ToString
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
            End With
            GriAsocDoc.DataBind()

            'Obtener los detalles del documento asociado
            If cboTipoDoc.Value <> "1CH000000027" Then
                oeMovimientoDocumento = New e_MovimientoDocumento
                oeMovimientoDocumento.TipoOperacion = "CDO"
                oeMovimientoDocumento.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeMovimientoDocumento.Activo = True
                listaMaterial = olMovimientoDocumento.ListarDetallesPorDocumentos(oeMovimientoDocumento)
                AsignarOrdenMaterial()
                gridOrdenMaterial.DataBind()
            Else
                oeGRRemitente = New e_GuiaRemisionRemitente
                oeGRRemitente.TipoOperacion = "G"
                oeGRRemitente.Id = griListaDoc.ActiveRow.Cells("Id").Value.ToString
                oeGRRemitente.Activo = True
                listaMaterial = olGRRemitente.ObtenerDetallesGr(oeGRRemitente)
                AsignarOrdenMaterial()
                gridOrdenMaterial.DataBind()
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub InicializarLista()
        cboFiltroMovimiento.SelectedIndex = 0
        cboEstadoOrden.SelectedIndex = 0
    End Sub

    Private Sub llenarCombos(Optional ByVal estado As String = "")
        Try
            oeMoneda.TipoOperacion = "1"
            oeMoneda.Activo = True
            LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            'cboMoneda.ReadOnly = True
            If oeOrden.TipoOperacion = "I" Then
                oeMovimientoInventario.TipoOperacion = "7"
            Else
                oeMovimientoInventario.TipoOperacion = IIf(estado.Equals("TERMINADA"), "5", "7")
                If estado.Equals("TRANSFERENCIA") Then oeMovimientoInventario.TipoOperacion = "8"
            End If
            oeMovimientoInventario.Activo = True
            LlenarComboMaestro(cboMovimientoInventario, olMovimientoInventario.Listar(oeMovimientoInventario), -1)
            oeTipoDocumento.Id = "CERO"
            oeTipoDocumento.Nombre = "PROVEEDOR"
            listaTipoDoc.Add(oeTipoDocumento)
            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "A"
            oeTipoDocumento.Activo = True
            listaTipoDoc.AddRange(olTipoDocumento.Listar(oeTipoDocumento))
            LlenarComboMaestro(cboTipoDoc, listaTipoDoc, 0)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub InicializarColores()
        Me.ColoresGenerado.Color = Color.White
        Me.ColoresTerminada.Color = Color.LightGreen
    End Sub

    Private Sub SubAlmacenValueList(ByVal ls_IdAlmacen As String)
        Try
            Dim lstSubAlmacen As New List(Of e_SubAlmacen)
            Dim objValueList As Infragistics.Win.ValueList = Nothing
            Me.gridOrdenMaterial.DisplayLayout.ValueLists.Clear()
            objValueList = Me.gridOrdenMaterial.DisplayLayout.ValueLists.Add("SubAlmacenes")
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

    Public Sub ValidarFicha()
        If oeOrden.EstadoOrden = "TERMINADA" Then
            ficDetalle.Tabs(0).Enabled = True
            ficDetalle.Tabs(0).Selected = True
            ficDetalle.Tabs(2).Enabled = True
        Else
            ficDetalle.Tabs(2).Enabled = False
            MostrarTabs(0, ficDetalle, 1)
        End If
    End Sub

    Public Function ObtenerMovInventario(ByVal cad As String) As String
        Try
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.TipoOperacion = ""
            oeMovimientoInventario.Nombre = cad
            oeMovimientoInventario.Activo = True
            oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)
            oeOrden.IdMovimientoInventario = oeMovimientoInventario.Id
            Return oeMovimientoInventario.Id
        Catch ex As Exception
            Throw
        End Try

    End Function

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

    Private Sub Inicializar(Optional ByVal estado As String = "")
        IndRectificar = 0
        oeIGV = olIGV.IGV(fecFechaOrden.Value)
        Me.txtGlosa.Text = String.Empty
        txtNroOrden.Text = String.Empty
        decTotal.Value = 0.0
        fecFechaOrden.Value = Date.Now
        gbeMateriales.Expanded = False
        gbDocAsociar.Expanded = False
        oeOrden.IdMoneda = cboMoneda.Value
        oeOrden.IdTipoOrden = ObtenerTipoOrden("ORDEN DE SALIDA")
        txtBuscarMateriales.Text = String.Empty
        Me.lbl_etiqueta.Visible = False
        Inhabilitar(True)
        llenarCombos(estado)
        'Obtengo el movimiento segun un nombre de un movimiento.
        cboMovimientoInventario.Value = "1CH000000030" 'ObtenerMovInventario("SALIDA POR DEVOLUCION")
        'obtengo el proveedor ISL
        oeOrden.IdProveedor = ISL_IdProveedor
        LimpiarListas()
        'limpiar()
        'ListarMaterial(True)
        listaRegistroInventario = New List(Of e_RegistroInventario)
        'habilito o inhabilito algunas cajas de texto
        HabInhVisualizacion(False)
        'controlo el sub menu
        ControlaBarraOperacionesDetalle(1, 1)
        InicializarColores()
    End Sub

    Public Sub HabInhVisualizacion(ByVal sw As Boolean)
        Me.etiEstado.Visible = sw
        Me.etiNroOrden.Visible = sw
        Me.txtEstado.Visible = sw
        Me.txtNroOrden.Visible = sw
    End Sub

    Private Sub llenarComboFiltroMovimiento()
        Try
            oeMovimientoInventario.Id = "CERO"
            oeMovimientoInventario.Nombre = "TODOS"
            listaMovimientoInventario.Add(oeMovimientoInventario)
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.TipoOperacion = "5"
            oeMovimientoInventario.Activo = True
            listaMovimientoInventario.AddRange(olMovimientoInventario.Listar(oeMovimientoInventario))
            LlenarComboMaestro(cboFiltroMovimiento, listaMovimientoInventario, 0)
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub llenarComboMovimientos()
        Try
            'oeTipoDocumento.Id = "CERO"
            'oeTipoDocumento.Nombre = "PROVEEDOR"
            'listaTipoDoc.Add(oeTipoDocumento)

            oeTipoDocumento = New e_TipoDocumento
            oeTipoDocumento.TipoOperacion = "A"
            oeTipoDocumento.Activo = True
            listaTipoDoc.AddRange(olTipoDocumento.Listar(oeTipoDocumento))
            LlenarComboMaestro(cboTipoDoc, listaTipoDoc, 0)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub llenarComboFiltroEstadoOrden()
        Try
            oeEstadoOrden.Id = "CERO"
            oeEstadoOrden.Nombre = "TODOS"
            listaEstadoOrden.Add(oeEstadoOrden)
            oeEstadoOrden = New e_EstadoOrden
            oeEstadoOrden.TipoOperacion = "3"
            oeEstadoOrden.Activo = True
            listaEstadoOrden.AddRange(olEstadoOrden.Listar(oeEstadoOrden))
            LlenarComboMaestro(cboEstadoOrden, listaEstadoOrden, 0)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = ""
            oeOrden.Activo = Activo
            oeOrden.IdTipoOrden = ObtenerTipoOrden("ORDEN DE SALIDA")
            oeOrden.Id = ""
            If rbNroOrden.Checked Then
                If String.IsNullOrEmpty(txtNSalida.Text.Trim) Then Throw New Exception("Ingrese N° de la Orden.")
                oeOrden.NroOrden = Me.txtNSalida.Text.Trim
                oeOrden.fechaInicio = "01/01/1901"
                oeOrden.fechaFin = "01/01/1901"
            Else
                ValidarFechaDesde_Hasta(rfOrdenSalidaDesde, rfOrdenSalidaHasta)
                oeOrden.EstadoOrden = IIf(cboEstadoOrden.Value = "CERO", "", cboEstadoOrden.Value)
                oeOrden.IdMovimientoInventario = IIf(cboFiltroMovimiento.Value = "CERO", "", cboFiltroMovimiento.Value)
                oeOrden.fechaInicio = rfOrdenSalidaDesde.Value
                oeOrden.fechaFin = rfOrdenSalidaHasta.Value
            End If
            listaOrden = olOrden.Listar(oeOrden)
            gridListaOrden.DataSource = listaOrden
            gridListaOrden.DisplayLayout.Bands(0).Columns("NombreSubEstado").Hidden = True
            'Ubica el cursor el el primer registro de la grilla
            If gridListaOrden.Rows.Count > 0 Then
                gridListaOrden.Focus()
                gridListaOrden.Rows.Item(0).Selected = True
            End If
            For Each fila As UltraGridRow In gridListaOrden.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                End Select
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LimpiarListas()
        listaMaterial = New List(Of e_Material)
        listaOrdenMaterial = New List(Of e_OrdenMaterial)
        lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
        lstMovimientoDocumento = New List(Of e_MovimientoDocumento)
        griListaMateriales.DataSource = listaMaterial
        gridOrdenMaterial.DataSource = listaOrdenMaterial
        griListaDoc.DataSource = lstMovimientoDocumento
        GriAsocDoc.DataSource = lstMovimientoDocumentoAsoc
        With griListaMateriales
            .DataSource = listaMaterial
            .DisplayLayout.Bands(0).SortedColumns.Clear()
        End With
    End Sub

    Public Sub ListarOrdenMaterial(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrdenMaterial = New e_OrdenMaterial
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = Activo
            oeOrdenMaterial.IdOrden = oeOrden.Id
            listaOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            gridOrdenMaterial.DataSource = listaOrdenMaterial
            llenaCombosGrillaOrdenMaterial()

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        'gridOrdenMaterial.Focus()
    End Sub

    Public Function ObtenerMoneda(ByVal nombreMoneda As String) As String
        Try
            oeMoneda = New e_Moneda
            oeMoneda.TipoOperacion = ""
            oeMoneda.Nombre = nombreMoneda
            oeMoneda.Activo = True
            oeMoneda = olMoneda.Obtener(oeMoneda)
            oeOrden.IdMoneda = oeMoneda.Id
            Return oeMoneda.Id
        Catch ex As Exception
            Throw
        End Try
    End Function

    Sub EjecutarOS()
        Try
            listaRegistroInventario.Clear()
            listaInventario.Clear()
            TransponerRegistroInv()
            If olRegistroInventario.Guardar(listaRegistroInventario) Then
                If oeOrden.IdMovimientoInventario = "1CH000000023" Then ' Si es Orden Salida por Transferencia entre almacenes
                    'REGISTRAR ORDEN DE INGRESO DE ORDEN DE TRANSFERENCIA
                    Dim oeOrdenIngreso As New e_Orden
                    oeOrdenIngreso.TipoOperacion = "I"
                    oeOrdenIngreso.IdTipoOrden = "1CH000000001" ' ORDEN DE INGRESO
                    oeOrdenIngreso.TipoReferencia = "ORDEN DE TRANSFERENCIA"
                    oeOrdenIngreso.Referencia = oeOrden.Referencia
                    oeOrdenIngreso.Id = ""
                    oeOrdenIngreso.NroOrden = ""
                    oeOrdenIngreso.IdProveedor = ISL_IdProveedor
                    oeOrdenIngreso.FechaOrden = Date.Now
                    oeOrdenIngreso.IdMoneda = ObtenerMoneda("SOLES")
                    oeOrdenIngreso.IdMovimientoInventario = "1CH000000022" 'INGRESO POR TRANSFERENCIA ENTRE ALMACENES
                    oeOrdenIngreso.IdEstadoOrden = ""
                    oeOrdenIngreso.UsuarioCreacion = gUsuarioSGI.Id
                    oeOrdenIngreso.IdSubAlmacenOrigen = ""
                    oeOrdenIngreso.IdSubAlmacenDestino = ""
                    listaOrdenMaterial = New List(Of e_OrdenMaterial)

                    Dim oeOrdenTransferencia As New e_Orden
                    oeOrdenTransferencia.Id = ""
                    oeOrdenTransferencia.NroOrden = oeOrden.Referencia
                    oeOrdenTransferencia = olOrden.Obtener(oeOrdenTransferencia)

                    For Each item As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                        item.TipoOperacion = "I"
                        item.UsuarioCreacion = gUsuarioSGI.Id
                        item.Activo = 1
                        item.IdSubAlmacen = oeOrdenTransferencia.IdSubAlmacenDestino
                        item.IdAlmacen = "" 'oeOrdenTransferencia.IdSubAlmacenOrigen
                        item.PrefijoID = gs_PrefijoIdSucursal '@0001
                        listaOrdenMaterial.Add(item)
                    Next
                    oeOrdenIngreso.lstOrdenMaterial = listaOrdenMaterial
                    oeOrdenIngreso.PrefijoID = gs_PrefijoIdSucursal '@0001
                    'olOrden.Guardar(oeOrdenIngreso)
                End If
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Sub TransponerRegistroInv()

        For Each item As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            oeRegistroInventario = New e_RegistroInventario
            oeRegistroInventario.Id = ""
            oeRegistroInventario.IdMovimientoInventario = oeOrden.IdMovimientoInventario
            oeRegistroInventario.IdMaterial = item.IdMaterial
            oeRegistroInventario.IdUnidadMedida = item.IdUnidadMedida
            oeRegistroInventario.Cantidad = item.CantidadMaterial
            oeRegistroInventario.CantidadReal = ConvertirUnidadBase(item.CantidadMaterial, item.IdUnidadMedida)
            oeRegistroInventario.ValorUnitarioReal = (item.ValorVenta / oeRegistroInventario.CantidadReal) / (1 + oeIGV.Porcentaje)
            oeRegistroInventario.ValorUnitario = item.PrecioUnitario / (1 + oeIGV.Porcentaje)
            If oeOrden.IdMoneda = "1CH02" Then
                oeRegistroInventario.ValorUnitarioReal = oeRegistroInventario.ValorUnitarioReal * TipoCambio(oeOrden.FechaOrden, 1)(0)
                oeRegistroInventario.ValorUnitario = oeRegistroInventario.ValorUnitario * TipoCambio(oeOrden.FechaOrden, 1)(0)
            End If
            oeRegistroInventario.ValorTotal = item.CantidadMaterial * oeRegistroInventario.ValorUnitario
            oeRegistroInventario.Activo = item.Activo
            oeRegistroInventario.UsuarioCreacion = oeOrden.UsuarioCreacion
            oeRegistroInventario.Fecha = oeOrden.FechaOrden
            oeRegistroInventario.IdAlmacen = item.IdAlmacen
            oeRegistroInventario.IdSubAlmacen = item.IdSubAlmacen
            oeRegistroInventario.TipoOperacion = oeOrden.TipoOperacion
            oeRegistroInventario.IdOrden = oeOrden.Id
            oeRegistroInventario.PrefijoID = gs_PrefijoIdSucursal '@0001
            listaRegistroInventario.Add(oeRegistroInventario)

            'oeInventario = New e_Inventario
            'oeInventario.TipoOperacion = "I"
            'oeInventario.IdMaterial = oeRegistroInventario.IdMaterial
            'oeInventario.IdSubAlmacen = oeRegistroInventario.IdSubAlmacen
            'oeInventario.ValorUnitario = oeRegistroInventario.ValorUnitario
            'oeInventario.FechaCreacion = Date.Now
            'oeInventario.CantidadIngreso = 0
            'oeInventario.CantidadSalida = oeRegistroInventario.Cantidad
            'oeInventario.ValorTotal = oeRegistroInventario.ValorTotal
            'oeInventario.Usuario = gUsuarioSGI.Id
            'oeRegistroInventario.oeInventario = oeInventario
        Next

    End Sub

    Public Function MostrarOrden(ByVal IdOrden As String) As Boolean
        Operacion = "Ayuda"
        Try
            Inicializar("TERMINADA")
            oeOrden = New e_Orden
            oeOrden.Id = IdOrden
            oeOrden = olOrden.Obtener(oeOrden)
            oeOrden.TipoOperacion = ""
            CargarOrden()
            ValidarFicha()
            HabInhVisualizacion(True)
            MostrarTabs(1, ficOrden, 1)
            gridOrdenMaterial.DisplayLayout.Bands(0).Columns("Stock").Hidden = True
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub CargarOrden()
        Try
            oeOrden.TipoOrden = ObtenerTipoOrden("ORDEN DE SALIDA")
            cboMoneda.Value = oeOrden.IdMoneda
            fecFechaOrden.Value = oeOrden.FechaOrden
            txtGlosa.Text = oeOrden.Glosa
            cboMovimientoInventario.Value = oeOrden.IdMovimientoInventario
            Me.txtEstado.Text = oeOrden.EstadoOrden
            Me.txtNroOrden.Text = oeOrden.NroOrden
            Me.verActivo.Checked = oeOrden.Activo
            If oeOrden.EstadoOrden = "TERMINADA" Then
                'Cargar los movimientos
                oeRegistroInventario = New e_RegistroInventario
                oeRegistroInventario.IdOrden = oeOrden.Id
                listaRegistroInventario = olRegistroInventario.ListarSOrden(oeRegistroInventario)
                gridOrdenMovimientos.DataSource = listaRegistroInventario
                Inhabilitar(False)
            End If
            ConsultarOrdenMaterial()
            CalcularTotalesDetalle()
            muestra = True
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Function GuardarOrden() As Boolean
        Try
            oeOrden.lstOrdenMaterial = listaOrdenMaterial
            oeOrden.IdSubAlmacenDestino = ""
            oeOrden.IdSubAlmacenOrigen = ""
            oeOrden.IdMovimientoInventario = cboMovimientoInventario.Value
            oeOrden.FechaOrden = fecFechaOrden.Value
            oeOrden.IdTipoOrden = Me.Tag
            'Orden Asociada
            If GriAsocDoc.Rows.Count > 0 Then
                oeOrden.TipoDocumento = lstMovimientoDocumentoAsoc.Item(0).IdTipoDocumento
                oeOrden.IdDocumento = lstMovimientoDocumentoAsoc.Item(0).Id
            End If
            If oeOrden.IdMovimientoInventario = "1CH000000030" Or oeOrden.IdMovimientoInventario = "1CH000000038" Then
                If oeOrden.TipoDocumento = "" Then Throw New Exception("No Puede Ejecutar Ordenes sin Documentos Asociados")
            End If
            If oeOrden.IdMovimientoInventario = "1SI000000001" Then
                If Not olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EJECUTAR AJUSTES INV") Then Throw New Exception("No Tiene Permisos para este Movimiento Inventario")
            End If
            If Operacion = "Nuevo" Then
                For Each ordmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                    If ordmat.Stock < ordmat.CantidadMaterial Then
                        Throw New Exception("La Cantidad del Material: " & ordmat.Material & ", es Mayor que el Stock. Verificar")
                    End If
                Next
            End If
            If oeOrden.TipoOperacion = "T" Then
                oeOrden.IdUsuarioEjecucion = gUsuarioSGI.Id
                If oeOrden.IdMovimientoInventario <> "1CH000000023" Then AsientoConsumo()
            End If
            oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olOrden.Guardar(oeOrden, New List(Of e_RegistroInventario)) Then Return False
            Select Case oeOrden.TipoOperacion
                Case "T"
                    EjecutarOS()
                    mensajeEmergente.Confirmacion("Se ejecuto satisfactoriamente en " & Me.Text)
                Case Else
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            End Select
            Consultar(True)
            MostrarTabs(0, ficOrden, 2)
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub AsientoConsumo()
        Try
            Dim oeComboPropio As e_Combo
            For Each ordsalmat As e_OrdenMaterial In oeOrden.lstOrdenMaterial
                oeComboPropio = New e_Combo
                oeComboPropio.Tipo = 3
                oeComboPropio.Nombre = "0"
                oeComboPropio.Id = ordsalmat.IdAlmacen
                If AlmacenesPublic.Contains(oeComboPropio) Then
                    ordsalmat.IndPropio = True
                End If
            Next
            If oeOrden.lstOrdenMaterial.Where(Function(i) i.IndPropio = True).Count > 0 Then
                Dim oePeriodo As New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim fechaactual As Date = ObtenerFechaServidor.Date
                oePeriodo.Ejercicio = fechaactual.Year
                oePeriodo.Mes = fechaactual.Month
                oePeriodo = olPeriodo.Obtener(oePeriodo)
                If oePeriodo.Id = "" Then Throw New Exception("No Existe el Periodo Contable de Este Periodo. Comunicar a Contabilidad")
                oeOrden.IndAsiento = True
                oeOrden.loAsientoModelo = New List(Of e_AsientoModelo)
                ObtenerAsientoModelo("1CH01", oePeriodo.Ejercicio)
                LlenaCuentaOrden(oeOrden, oePeriodo.Ejercicio, loCtaCtbleSFam)
                oeOrden.IdPeriodo = oePeriodo.Id
                oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlaBarraOperacionesDetalle(ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean)
        o_Botonera.Nuevo = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar
        Botones(o_Botonera)
    End Sub

    Public Sub ConsultarDetalle()
        Try
            ListarMaterial(True)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub ListarMaterial(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMaterial.TipoOperacion = "A"
            oeMaterial.Activo = Activo
            listaMaterial.AddRange(olMaterial.Listar(oeMaterial))
            If listaOrdenMaterial.Count > 0 Then
                listaMaterial.RemoveAll(AddressOf VerificaListaMateriales)
                griListaMateriales.DataBind()
            End If
            griListaMateriales.DataBind()
            llenaCombosGrillaMaterial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub llenaCombosGrillaMaterial()
        Try
            For i As Integer = 0 To griListaMateriales.Rows.Count - 1
                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "4"
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.IdMaterial = griListaMateriales.Rows(i).Cells("Id").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, griListaMateriales, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)
            Next
            griListaMateriales.DataBind()
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Sub llenaCombosGrillaOrdenMaterial()
        Try
            For j As Integer = 0 To gridOrdenMaterial.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = gridOrdenMaterial.Rows(j).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", j, gridOrdenMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)

                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "4"
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.IdMaterial = gridOrdenMaterial.Rows(j).Cells("IdMaterial").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", j, gridOrdenMaterial, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)

                oeSubalmacen = New e_SubAlmacen
                oeSubalmacen.TipoOperacion = "S"
                oeSubalmacen.Activo = True
                oeSubalmacen.IdAlmacen = gridOrdenMaterial.Rows(j).Cells("IdAlmacen").Value.ToString
                CrearComboGridPorCelda("IdSubAlmacen", "Nombre", j, gridOrdenMaterial, olSubalmacen.ComboGrilla(oeSubalmacen), True)
            Next
            gridOrdenMaterial.DataBind()
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub AsignarOrdenMaterial()
        Try
            For Each obj As e_Material In listaMaterial
                If obj.Seleccion Then
                    oeOrdenMaterial = New e_OrdenMaterial
                    oeOrdenMaterial.Seleccion = False
                    oeOrdenMaterial.IdMaterial = obj.Id
                    oeOrdenMaterial.Material = obj.Nombre
                    oeOrdenMaterial.CantidadMaterial = obj.Peso
                    oeOrdenMaterial.PrecioUnitario = ObtenerValorUnitario(obj.Id, obj.IdAlmacen, 0)
                    oeOrdenMaterial.IdAlmacen = obj.IdAlmacen
                    oeOrdenMaterial.IdSubAlmacen = obj.IdSubAlmacen
                    oeOrdenMaterial.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    oeOrdenMaterial.IdUnidadMedida = obj.IdUnidadMedida
                    oeOrdenMaterial.UnidadMedida = obj.UnidadMedida
                    oeOrdenMaterial.Almacen = obj.Almacen
                    oeOrdenMaterial.Stock = obj.Stock
                    oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                    oeOrdenMaterial.Activo = True
                    oeOrdenMaterial.CodigoMaterial = obj.Codigo
                    oeOrdenMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                    listaOrdenMaterial.Add(oeOrdenMaterial)
                End If
            Next
            gridOrdenMaterial.DataBind()
            txtBuscarMateriales.Value = String.Empty
            llenaCombosGrillaOrdenMaterial()
            listaMaterial.RemoveAll(AddressOf eliminaMateriales)
            griListaMateriales.DataBind()
            CalcularTotalesDetalle()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function eliminaMateriales(ByVal oeMaterial As e_Material) As Boolean
        Return oeMaterial.Seleccion
    End Function

    Private Function verificarSeleccionado(ByVal obj As e_OrdenMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(obj.IdMaterial) Then
                If obj.Seleccion Then
                    Dim oeMaterial As New e_Material
                    oeMaterial.Id = obj.IdMaterial
                    oeMaterial.IdAlmacen = obj.IdAlmacen
                    oeMaterial.IdSubAlmacen = obj.IdSubAlmacen
                    oeMaterial.Activo = True
                    oeMaterial.TipoOperacion = "5"
                    oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                    oeMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
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
            For i As Integer = 0 To listaOrdenMaterial.Count - 1
                If listaOrdenMaterial.Item(i).Seleccion Then
                    sw = True
                End If
            Next
            If Not sw Then
                Throw New Exception("Marque por lo menos un registro para quitar de lista")
            Else
                If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    listaOrdenMaterial.RemoveAll(AddressOf verificarSeleccionado)
                    griListaMateriales.DataBind()
                    gridOrdenMaterial.DataBind()
                    CalcularTotalesDetalle()
                End If
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
                    lstMovimientoDocumentoAsoc.Clear()
                    listaOrdenMaterial.Clear()
                    griListaMateriales.DataBind()
                    GriAsocDoc.DataBind()
                    CalcularTotalesDetalle()
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EditarOrden() As Boolean
        Try
            IndRectificar = 0
            If gridListaOrden.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Dim estado As String = gridListaOrden.ActiveRow.Cells("EstadoOrden").Value.ToString
                Dim MovInv As String = gridListaOrden.ActiveRow.Cells("MovimientoInventario").Value.ToString
                If MovInv.Equals("SALIDA POR TRANSFERENCIA ENTRE ALMACENES") Then estado = "TRANSFERENCIA"
                Inicializar(estado)
                gridOrdenMaterial.DisplayLayout.Bands(0).Columns("Stock").Hidden = True
                oeOrden.Id = gridListaOrden.ActiveRow.Cells("Id").Value.ToString
                oeOrden = olOrden.Obtener(oeOrden)
                cboMoneda.Value = oeOrden.IdMoneda
                fecFechaOrden.Value = oeOrden.FechaOrden
                txtGlosa.Text = oeOrden.Glosa
                cboMovimientoInventario.Value = oeOrden.IdMovimientoInventario
                Me.txtEstado.Text = oeOrden.EstadoOrden
                Me.txtNroOrden.Text = oeOrden.NroOrden
                Me.verActivo.Checked = oeOrden.Activo
                'CargaDocAsocOrden(oeOrdenDoc, oeOrden, oeMovimientoDocumento, lstMovimientoDocumentoAsoc, GriAsocDoc)
                'VERIFICANDO DOCUMENTO ASOCIADO A LA ORDEN
                oeOrdenDoc = New e_Orden_Documento
                oeOrdenDoc.TipoOperacion = "D"
                oeOrdenDoc.IdOrden = oeOrden.Id
                oeOrdenDoc.IdTipoOrden = oeOrden.IdTipoOrden
                lstMovimientoDocumentoAsoc = New List(Of e_MovimientoDocumento)
                oeMovimientoDocumento = olOrdenDoc.ObtenerDocumento(oeOrdenDoc)
                GriAsocDoc.DataSource = lstMovimientoDocumentoAsoc
                oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
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
                    'VERIFICANDO GRREMITENTE ASOCIADO A LA ORDEN
                    If Not String.IsNullOrEmpty(oeOrdenDoc.Id) Then
                        oeOrdenDoc.TipoOperacion = "GR"
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
                            oeMovimientoDocumento.PrefijoID = gs_PrefijoIdSucursal '@0001
                            lstMovimientoDocumentoAsoc.Add(oeMovimientoDocumento)
                            GriAsocDoc.DataBind()
                        Else
                            oeOrden.TipoOperDocAsoc = "I"
                        End If
                    End If
                End If

                If oeOrden.EstadoOrden = "TERMINADA" Then
                    'Cargar los movimientos
                    oeRegistroInventario = New e_RegistroInventario
                    oeRegistroInventario.IdOrden = oeOrden.Id
                    listaRegistroInventario = olRegistroInventario.ListarSOrden(oeRegistroInventario)
                    gridOrdenMovimientos.DataSource = listaRegistroInventario
                    'Inhabilitar la orden
                    MyBase.Vista()
                    Inhabilitar(False)
                Else
                    MyBase.Editar()
                End If
                ConsultarOrdenMaterial()
                CalcularTotalesDetalle()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Private Sub ConsultarOrdenMaterial()
        Try
            ListarOrdenMaterial(True)
            If gridOrdenMaterial.Rows.Count > 0 Then
                ControlaBarraOperacionesDetalle(True, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String, ByVal StockPrecio As Integer) As String
        Try
            oeInventario = New e_Inventario
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            If oeInventario.ValorUnitario = 0 Then
                oeInventario.TipoOperacion = "P"
                oeInventario = olInventario.Obtener(oeInventario)
            End If
            If StockPrecio = 0 Then
                Return oeInventario.ValorUnitario * (1 + oeIGV.Porcentaje)
            Else
                Return oeInventario.CantidadFinal
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Inhabilitar(ByVal sw As Boolean)
        agrDatoGeneral.Enabled = sw
        gbeMateriales.Enabled = sw
        MenuDet.Enabled = sw
    End Sub

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        For Each fila As e_OrdenMaterial In listaOrdenMaterial
            If (oeMat.Id = fila.IdMaterial) Then
                Return True
            End If
        Next
    End Function

    Private Sub CalcularTotalesDetalle()
        decTotal.Value = 0.0
        oeOrden.lstOrdenMaterial = gridOrdenMaterial.DataSource
        For Each obj As e_OrdenMaterial In oeOrden.lstOrdenMaterial
            decTotal.Value += obj.ValorVenta
        Next
    End Sub

    Public Sub ListarMateriales()
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not String.IsNullOrEmpty(Trim(oeMaterial.Nombre)) Then
                oeMaterial.TipoOperacion = "5"
                oeMaterial.Activo = True
                oeMaterial.Tipo = 1
                listaMaterial = olMaterial.Listar_(oeMaterial)
                '------Quitamos los registros de lista de materiales si es que estos ya estan en la lista requerimientos.------
                With griListaMateriales

                    .DataSource = listaMaterial
                    .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
                End With
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RectificarOS()
        Try
            '------- CONTROLAR AUTENTICACIÓN DEL TRABAJADOR------------
            Dim formulario As frm_AutenticarTrabajador
            formulario = New frm_AutenticarTrabajador
            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            '-------------------------------------------------------------------------------
            oeTrabajadorSeguridad = New e_TrabajadorSeguridad
            oeProcesoNegocio = New e_ProcesoNegocio
            oeProcesoNegocio.TipoOperacion = ""
            oeProcesoNegocio.Nombre = "RECTIFICAR OI,OS"
            oeProcesoNegocio = olProcesoNegocio.Obtener(oeProcesoNegocio)
            oeTrabajadorSeguridad.TipoOperacion = ""
            oeTrabajadorSeguridad.IdTrabajador = formulario.cboTrabajador.Value
            oeTrabajadorSeguridad.IdProcesoNegocio = oeProcesoNegocio.Id
            oeTrabajadorSeguridad = olTrabajadorSeguridad.Obtener(oeTrabajadorSeguridad)
            If String.IsNullOrEmpty(oeTrabajadorSeguridad.Id) Then Throw New Exception("Trabajador No Autorizado.")
            Editar()
            IndRectificar = 1
            gridOrdenMaterial.DisplayLayout.Bands(0).Columns("CantidadMaterial").CellActivation = Activation.AllowEdit
            gridOrdenMaterial.DisplayLayout.Bands(0).Columns("PrecioUnitario").CellActivation = Activation.AllowEdit
            Inhabilitar(True)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            lbl_etiqueta.Text = "Rectifica OS" : lbl_etiqueta.Visible = 1
            formulario = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Function VerificarRegistroEditado() As Boolean
        Try
            Dim oeOrd As New e_Orden
            oeOrd.Id = gridListaOrden.ActiveRow.Cells("Id").Value
            oeOrd.TipoOperacion = "R"
            oeOrd.TipoOrden = Nothing
            oeOrd = olOrden.Obtener(oeOrd)
            If oeOrd.IdMovimientoInventario <> "" Then
                If oeOrd.UsuarioCreacion <> gUsuarioSGI.oePersona.NombreCompleto Then
                    mensajeEmergente.Confirmacion("La información de la Orden no es accesible pues esta siendo editado por el Usuario" & Environment.NewLine & _
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
                .IdRegistro = gridListaOrden.ActiveRow.Cells("Id").Value()
                .Referencia = "Orden"
                .UsuarioEdita = gUsuarioSGI.Id
            End With
            oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
            IdRegistroEditado = olRegistroEditado.Guardar(oeRegistroEditado)
        End If
    End Sub

    Private Function ActualizaRegistroEditado() As Boolean
        Try
            If RegistroEditado = 1 Then
                oeRegistroEditado = New e_RegistrosEditados
                With oeRegistroEditado
                    .Id = IdRegistroEditado
                End With
                oeRegistroEditado.PrefijoID = gs_PrefijoIdSucursal '@0001
                olRegistroEditado.Guardar(oeRegistroEditado)
                RegistroEditado = 0
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ImprimirOrden()
        Dim id As String = ""
        Try
            If gridListaOrden.Selected.Rows.Count > 0 Then
                Dim formulario As New frm_ImprimirOrden
                id = gridListaOrden.ActiveRow.Cells("Id").Value
                formulario.CargarDatos(id)
                formulario.ShowDialog()
                ControlBoton(1, 1, 1, 0, 0, 1, 1, 1, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ImportarArchivo()
        Dim objXls As Excel.Application
        Dim objWorkbook As Excel.Workbook
        Dim objWorkSheet As Excel.Worksheet
        Dim ObjExcel() As Object = Nothing
        Try
            Dim oeComboMaterial As e_Combo
            Dim oeComboAlmacen As e_Combo
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                PathFilePTRA = OpenFileDialog1.FileName

                Dim men As String = ""
                'objXls = New Excel.Application
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                For ln_Fila As Integer = 1 To 300
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
                        oeOrdenMaterial.PrecioUnitario = ObtenerValorUnitario(oeOrdenMaterial.IdMaterial, oeOrdenMaterial.IdSubAlmacen, 0)
                        oeOrdenMaterial.Stock = ObtenerValorUnitario(oeOrdenMaterial.IdMaterial, oeOrdenMaterial.IdSubAlmacen, 1)
                        oeOrdenMaterial.Almacen = ""
                        If oeComboMaterial.Descripcion.Length > 0 Then
                            oeOrdenMaterial.IdTipoUnidadMedida = oeComboMaterial.Descripcion.Substring(0, 12)
                            oeOrdenMaterial.IdUnidadMedida = oeComboMaterial.Descripcion.Substring(12)
                        End If
                        oeOrdenMaterial.UnidadMedida = ""
                        oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                        oeOrdenMaterial.Activo = True
                        oeOrdenMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
                        listaOrdenMaterial.Add(oeOrdenMaterial)
                    Else
                        Exit For
                    End If
                Next
                gridOrdenMaterial.DataSource = listaOrdenMaterial
                gridOrdenMaterial.DataBind()
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
        Finally
            OpenFileDialog1.Dispose()
            ObjExcel = Nothing
            objWorkSheet = Nothing
            objWorkbook = Nothing
            objXls = Nothing
        End Try
    End Sub

    Private Sub AsientoContable()
        AsientoModelo()
        CtaCtbleSubFamilia()
        dtReferencia = New DataTable
        dtReferencia = GeneraDTRef(loReferencia)
    End Sub

    Private Sub AsientoModelo()
        oeAsientoModelo = New e_AsientoModelo
        olAsientoModelo = New l_AsientoModelo
        loAsientoModelo = New List(Of e_AsientoModelo)
        oeAsientoModelo.TipoOperacion = "A" : oeAsientoModelo.Activo = True : oeAsientoModelo.Nombre = pIdActividadNegocio
        loAsientoModelo = olAsientoModelo.Listar(oeAsientoModelo)

        oeReferencia = New e_AsientoModelo_Referencia
        olReferencia = New l_AsientoModelo_Referencia
        loReferencia = New List(Of e_AsientoModelo_Referencia)
        oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
        loReferencia = olReferencia.Listar(oeReferencia)
    End Sub

    Private Sub CtaCtbleSubFamilia()
        oeCtaCtbleSFam = New e_CtaCtbleSubFamiliaMat
        olCtaCtbleSFam = New l_CtaCtbleSubFamiliaMat
        loCtaCtbleSFam = New List(Of e_CtaCtbleSubFamiliaMat)
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

#Region "Botones Principales"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            If Not ValidarFechaDesde_Hasta(rfOrdenSalidaDesde, rfOrdenSalidaHasta) Then
                Exit Sub
            End If
            Listar(Activo)
            If gridListaOrden.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = "I"
            oeOrden.TipoOperDocAsoc = "I"
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            gridOrdenMaterial.DisplayLayout.Bands(0).Columns("Stock").Hidden = False
            oeOrden.Activo = True
            MostrarTabs(1, ficOrden, 1)
            MostrarTabs(1, ficDetalle, 0)
            'ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
            ControlaBarraOperacionesDetalle(True, True)
            Inicializar()
            Operacion = "Nuevo"
            HabInhVisualizacion(False)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If VerificarRegistroEditado() Then
                EditarOrden()
                GuardarRegistroEditado()
                oeOrden.TipoOperacion = "A"
                Operacion = "Editar"
                MostrarTabs(1, ficOrden, 1)
                ValidarFicha()
                HabInhVisualizacion(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrden() Then
                ActualizaRegistroEditado()
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOrden.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarOrden() Then
                            MostrarTabs(0, ficOrden, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOrden, 2)
                        _ingresando_datos = False
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                        _ingresando_datos = True
                End Select
            Else
                MostrarTabs(0, ficOrden, 2)
                _ingresando_datos = False
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            End If
            ActualizaRegistroEditado()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            'With 
            If gridListaOrden.ActiveRow.Cells("EstadoOrden").Value <> "TERMINADA" Then
                oeOrden.Id = gridListaOrden.ActiveRow.Cells("Id").Value
                'oeOrden = olOrden.Obtener(oeOrden)
                If oeOrden.Activo Then
                    If MessageBox.Show("Desea Eliminar la OS N° " & gridListaOrden.ActiveRow.Cells("NroOrden").Value & "?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeOrden.TipoOperacion = "E"
                        olOrden.Eliminar(oeOrden)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            Else
                mensajeEmergente.Confirmacion("La Orden de Salida ya fue Ejecutada. No Puede Eliminarla!", 1)
            End If
            'End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        ImprimirOrden()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If gridListaOrden.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOrden.SelectedTab.Index = 0 Then Exportar_Excel(gridListaOrden)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_OrdenSalida_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaOrden_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Orden de Salida"
    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarToolStripMenuItem.Click
        Try
            Editar() : oeOrden.TipoOperacion = "T"
            Me.lbl_etiqueta.Text = "Ejecutar OS"
            Me.lbl_etiqueta.Visible = True
        Catch ex As Exception
            Throw
        End Try
    End Sub
    Private Sub AsociarMenu()
        gridListaOrden.ContextMenuStrip = MenuContextual1
    End Sub
    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = 1
        MenuContextual1.Items("EjecutarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("RectificarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 0
        MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
        If gridListaOrden.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 1
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
            If gridListaOrden.ActiveRow.Cells("EstadoOrden").Value.ToString = "GENERADA" Then
                MenuContextual1.Items("EjecutarToolStripMenuItem").Visible = 1
            Else
                MenuContextual1.Items("RectificarToolStripMenuItem").Visible = 1
            End If
        End If
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
    
#End Region

End Class
