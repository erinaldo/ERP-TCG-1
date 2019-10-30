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

Public Class frm_OrdenTransferencia
    Inherits frm_MenuPadre

#Region "Declaracion de variables y/o objetos"

    Dim oeOrden As e_Orden, olOrden As l_Orden
    Dim oeMoneda As e_Moneda, olMoneda As l_Moneda

    Dim oeCentro As e_Centro, olCentro As l_Centro, loCentro As List(Of e_Centro)
    Dim oeMaterial As e_Material, olMaterial As l_Material
    Dim listaMaterial As List(Of e_Material)
    Dim oeAlmacen As e_Almacen, olAlmacen As l_Almacen

    Dim oeOrdenMaterial As e_OrdenMaterial, olOrdenMaterial As l_OrdenMaterial
    Dim listaOrdenMaterial As List(Of e_OrdenMaterial)
    Dim oeUnidadMedida As e_UnidadMedida, olUnidadMedida As l_UnidadMedida
    Dim oeEstadoOrden As e_EstadoOrden, olEstadoOrden As l_EstadoOrden
    Dim listaEstadoOrden As List(Of e_EstadoOrden)

    Dim oeMovimientoInventario As e_MovimientoInventario, olMovimientoInventario As l_MovimientoInventario
    Dim oeInventario As e_Inventario, olInventario As l_Inventario
    Dim oeMaterialAlmacen As e_MaterialAlmacen, olMaterialAlmacen As l_MaterialAlmacen
    Dim oeSubAlmacen As e_SubAlmacen, olSubAlmacen As l_SubAlmacen

#End Region

#Region "Inicializar"

    Dim _ingresando_datos As Boolean = False
    Private Shared instancia As frm_OrdenTransferencia = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_OrdenTransferencia()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Sub New()
        InitializeComponent()
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If ValidarFechaDesde_Hasta(rfOrdenTransferenciaDesde, rfOrdenTransferenciaHasta) Then
                ListarTranferencias(Activo)
                If griListaOrdenTransferencia.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 0)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficOrden, 1)
            r_BarraOperaciones(True, True)
            InicializarTransferencia()
            oeOrden.TipoOperacion = "I"
            oeOrden.Activo = True
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Operacion = "Editar"
            EditarOrden()
            MostrarTabs(1, ficOrden, 1)
            HabInhVisualizacion(True)
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeOrden.EstadoOrden = "TERMINADA" Then
                oeOrden.Modificado = False
                MostrarTabs(0, ficOrden, 2)
                If griListaOrdenTransferencia.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 0)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 0)
                End If
                _ingresando_datos = False
                Exit Sub
            End If        
            If oeOrden.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarOrden() Then
                            MostrarTabs(0, ficOrden, 2)
                            Consultar(True)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficOrden, 2)
                        Consultar(True)
                    Case Windows.Forms.DialogResult.Cancel
                End Select
            Else
                MostrarTabs(0, ficOrden, 2)
                If griListaOrdenTransferencia.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 0)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griListaOrdenTransferencia.ActiveRow.Cells("EstadoOrden").Value <> "TERMINADA" Then
                oeOrden.Id = griListaOrdenTransferencia.ActiveRow.Cells("Id").Value
                oeOrden = olOrden.Obtener(oeOrden)
                If oeOrden.Activo Then
                    If MessageBox.Show("Esta seguro de eliminar la Orden de Transferencia: ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeOrden.TipoOperacion = "E"
                        olOrden.Eliminar(oeOrden)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            Else
                Throw New Exception("La Orden de Transferencia no se puede Eliminar, debido al estado TERMINADA")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarOrden() Then
                MyBase.Guardar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

            If griListaOrdenTransferencia.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If ficOrden.SelectedTab.Index = 0 Then Exportar_Excel(griListaOrdenTransferencia)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menú contextual del maestro de Orden de Ingreso"

    Private Sub EjecutarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjecutarToolStripMenuItem.Click
        Try
            r_Ejecutar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub AsociarMenu()
        griListaOrdenTransferencia.ContextMenuStrip = MenuContextual1
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
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 0
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 0
            If griListaOrdenTransferencia.Selected.Rows.Count > 0 Then
                MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = 1
                MenuContextual1.Items("EliminarToolStripMenuItem").Visible = 1
                If griListaOrdenTransferencia.ActiveRow.Cells("EstadoOrden").Value.ToString = "GENERADA" Then
                    MenuContextual1.Items("EjecutarToolStripMenuItem").Visible = 1
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu y tabs"

    Private Sub Botones(ByVal oeBoton As e_Boton)
        Try
            With mnDetalle
                .Tools("Agregar").SharedProps.Enabled = oeBoton.Nuevo
                .Tools("Quitar").SharedProps.Enabled = oeBoton.Eliminar
            End With
        Catch ex As Exception
        End Try
    End Sub

    Public Sub r_BarraOperaciones(ByVal lb_Agregar As Boolean, ByVal lb_Quitar As Boolean)
        o_Botonera.Nuevo = lb_Agregar
        o_Botonera.Eliminar = lb_Quitar
        Botones(o_Botonera)
    End Sub

#End Region

#Region "Evento del formulario"

    Private Sub InicializarLogicas()
        Try
            olOrden = New l_Orden
            olOrdenMaterial = New l_OrdenMaterial
            olUnidadMedida = New l_UnidadMedida
            olCentro = New l_Centro
            olMaterial = New l_Material
            olAlmacen = New l_Almacen
            olSubAlmacen = New l_SubAlmacen
            olInventario = New l_Inventario
            olEstadoOrden = New l_EstadoOrden
            olMaterialAlmacen = New l_MaterialAlmacen
            olMoneda = New l_Moneda
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_OrdenTransferencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            oeOrden = New e_Orden
            gmt_ConfigurarEventoKeyEnter_Tab(Me, txtNIngreso.Name)
            gf_AsignarEventoSeleccionarTexto(Me)
            InicializarLogicas()
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficOrden)
            r_BarraOperaciones(True, True)
            llenarComboFiltroEstadoOrden()
            rfOrdenTransferenciaDesde.Value = Date.Now.AddDays(-7)
            rfOrdenTransferenciaHasta.Value = Date.Now
            InicializarColores()
            txtProveedor.Text = gs_TxtEmpresaSistema.Trim
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNIngreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNIngreso.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub frm_OrdenTransferencia_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Try
            Select Case ficOrden.SelectedTab.Index
                Case 0
                    If griListaOrdenTransferencia.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 0)
                    Else
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 0)
                    End If

                Case 1
                    ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCenDestino_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCenDestino.ValueChanged
        Try
            If Operacion = "Nuevo" Then oeOrden.IdSubAlmacenDestino = cboAlmDestino.Value
            oeOrden.Modificado = True
            If Not String.IsNullOrEmpty(cboCenOrigen.Value) Then
                ObtenerAlmacenSegunCentro(cboCenDestino.Value, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaOrdenTransferencia_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles griListaOrdenTransferencia.AfterRowActivate
        Try
            btnEjecutar.Enabled = 0
            If griListaOrdenTransferencia.ActiveRow.Index > -1 Then
                btnEjecutar.Enabled = IIf(griListaOrdenTransferencia.ActiveRow.Cells("EstadoOrden").Value = "GENERADA", True, False)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaOrdenTransferencia_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaOrdenTransferencia.DoubleClickRow
        If griListaOrdenTransferencia.Rows.Count > 0 Then Editar()
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

    Private Sub frm_OrdenTransferencia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenTransferencia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case _Operacion
            Case "Nuevo", "Editar"
                Me.Activate()
                Me.Cancelar()
        End Select

        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub mnDetalle_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    AgregarDetalle()
                Case "Quitar"
                    QuitarDetalle()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMaterial_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griMaterial.CellChange
        Try
            griMaterial.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrdenMaterial_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.AfterCellUpdate
        Try
            With griOrdenMaterial.Rows(e.Cell.Row.Index)
                Select Case e.Cell.Column.Key
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
                .Cells("ValorVenta").Value = griOrdenMaterial.Rows(e.Cell.Row.Index).Cells("PrecioUnitario").Value * griOrdenMaterial.Rows(e.Cell.Row.Index).Cells("CantidadMaterial").Value
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griOrdenMaterial_CellChange(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griOrdenMaterial.CellChange
        Try
            griOrdenMaterial.UpdateData()
            If oeOrden.EstadoOrden <> "TERMINADA" Then oeOrden.Modificado = True
            With griOrdenMaterial.Rows(e.Cell.Row.Index)
                Select Case e.Cell.Column.Key
                    Case "CantidadMaterial"
                        If griOrdenMaterial.Rows(e.Cell.Row.Index).Cells("CantidadMaterial").Value > griOrdenMaterial.Rows(e.Cell.Row.Index).Cells("Stock").Value Then
                            .Cells("CantidadMaterial").Value = 0
                            Throw New Exception("El Stock del Producto es menor a la cantidad Ingresada")
                        End If
                End Select
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboCenOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCenOrigen.ValueChanged
        Try
            oeOrden.IdCentro = cboCenOrigen.Value
            ObtenerAlmacenSegunCentro(cboCenOrigen.Value, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAlmDestino_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmDestino.GotFocus
        Try
            If cboAlmDestino.Items.Count = 0 Then
                cboCenDestino.Focus()
                Throw New Exception("Seleccione el almacén de destino de la transferencia")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAlmDestino_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmDestino.ValueChanged
        Try
            If Operacion = "Nuevo" Then
                If cboAlmDestino.SelectedIndex <> -1 Then
                    If cboAlmacenOrigen.SelectedIndex = -1 Then Throw New Exception("Seleccione un almacen de Origen,Por Favor")
                End If
            End If
            If cboAlmDestino.SelectedIndex <> -1 Then
                ListarSubAlmacen(cboAlmDestino.Value, 0)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtGlosa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGlosa.KeyDown
        oeOrden.Modificado = True
    End Sub

    Private Sub txtGlosa_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGlosa.ValueChanged
        oeOrden.Glosa = txtGlosa.Text
    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        r_Ejecutar()
    End Sub

    Private Sub griOrdenMaterial_BeforeCellUpdate(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeCellUpdateEventArgs) Handles griOrdenMaterial.BeforeCellUpdate
        Try
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecfechaOrden_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecOrden.Validated
        Try
            If Operacion = "Nuevo" Then
                Select Case fecOrden.Value
                    Case Is > Date.Now
                        fecOrden.Value = Date.Now
                        Throw New Exception("La fecha de transferencia no puede ser mayor al día actual")
                    Case Is < UltimoDiaMesAnterior()
                        fecOrden.Value = Date.Now
                        Throw New Exception("La fecha de transferencia no puede ser anterior al mes pasado")
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboSubAlmacenDestino_ValueChanged(sender As Object, e As EventArgs) Handles cboSubAlmacenDestino.ValueChanged
        If cboSubAlmacenDestino.SelectedIndex <> -1 Then
            oeOrden.IdSubAlmacenDestino = cboSubAlmacenDestino.Value
        End If
    End Sub

    Private Sub cboSubAlmacenOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubAlmacenOrigen.ValueChanged
        Try
            If cboSubAlmacenOrigen.SelectedIndex <> -1 Then
                Dim oeMatAlm As New e_MaterialAlmacen
                oeMatAlm.TipoOperacion = "7"
                oeMatAlm.Activo = True
                oeMatAlm.IdMaterial = ""
                oeMatAlm.Id = ""
                oeMatAlm.IdAlmacen = cboAlmacenOrigen.Value
                oeMatAlm.IdSubAlmacen = cboSubAlmacenOrigen.Value
                listaMaterial = New List(Of e_Material)
                griMaterial.DataSource = listaMaterial
                listaMaterial = olMaterialAlmacen.ListarMateriales(oeMatAlm)
                For Each OBJ In listaMaterial
                    OBJ.Seleccion = False
                Next
                griMaterial.DataSource = listaMaterial
                griMaterial.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAlmacenOrigen_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacenOrigen.GotFocus
        Try
            If cboAlmacenOrigen.Items.Count = 0 Then
                cboCenOrigen.Focus()
                Throw New Exception("Seleccione el almacén de origen de la transferencia")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboAlmacenOrigen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacenOrigen.ValueChanged
        Try
            If Operacion = "Nuevo" Then
                listaMaterial = New List(Of e_Material)
                griMaterial.DataSource = listaMaterial
                If cboAlmDestino.SelectedIndex <> -1 Then
                    If cboAlmacenOrigen.SelectedIndex <> -1 Then
                        If cboAlmacenOrigen.Value = cboAlmDestino.Value Then
                            cboAlmDestino.Focus()
                            cboAlmacenOrigen.SelectedIndex = -1
                            Throw New Exception("Verifique los almacenes, no puede transferir al mismo almacén")
                        End If
                    End If
                End If
            End If
            If cboAlmacenOrigen.SelectedIndex <> -1 Then
                ListarSubAlmacen(cboAlmacenOrigen.Value, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub InicializarLista()
        cboEstadoOrden.SelectedIndex = 0
    End Sub

    Public Sub Inhabilitar(ByVal sw As Boolean)
        agrDatoGeneral.Enabled = sw
        gbeMateriales.Enabled = sw
        mnDetalle.Visible = sw
        gbeMateriales.Expanded = sw
    End Sub

    Sub InicializarColores()
        Me.ColoresGenerado.Color = Color.White
        Me.ColoresRecepcionado.Color = Color.Khaki
        Me.ColoresTerminada.Color = Color.LightGreen
    End Sub

    Private Function ObtenerValorUnitario(ByVal idMaterial As String, ByVal idAlmacen As String) As String
        Try
            oeInventario = New e_Inventario
            oeInventario.ValorUnitario = 0.0
            oeInventario.TipoOperacion = 1
            oeInventario.IdMaterial = idMaterial
            oeInventario.IdSubAlmacen = idAlmacen
            oeInventario = olInventario.Obtener(oeInventario)
            Return oeInventario.ValorUnitario * (1 + oeIGVGlobal.Porcentaje)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CentroSAlmacen(ByVal idAlmacen As String) As String
        Dim cad As String = ""
        Try
            oeCentro = New e_Centro
            oeCentro.TipoOperacion = 1
            oeCentro.Activo = True
            oeCentro.Id = ""
            oeCentro.IdAlmacen = idAlmacen
            oeCentro = olCentro.ObtenerSAlmacen(oeCentro)
            cad = oeCentro.Id
        Catch ex As Exception
            Throw ex
        End Try
        Return cad
    End Function

    Public Function ObtenerAlmacen(ByVal ls_IdSubAlmacen As String) As String
        Dim cad As String = ""
        Try
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.TipoOperacion = ""
            oeSubAlmacen.Activo = True
            oeSubAlmacen.Id = ls_IdSubAlmacen
            oeSubAlmacen = olSubAlmacen.Obtener(oeSubAlmacen)
            cad = oeSubAlmacen.IdAlmacen
        Catch ex As Exception
            Throw ex
        End Try
        Return cad
    End Function

    Public Function EditarOrden() As Boolean
        Try
            If griListaOrdenTransferencia.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                InicializarTransferencia()
                oeOrden.Id = griListaOrdenTransferencia.ActiveRow.Cells("Id").Value.ToString
                oeOrden = olOrden.Obtener(oeOrden)
                cboCenOrigen.Value = CentroSAlmacen(ObtenerAlmacen(oeOrden.IdSubAlmacenOrigen))
                cboCenDestino.Value = CentroSAlmacen(ObtenerAlmacen(oeOrden.IdSubAlmacenDestino))
                cboAlmDestino.Value = ObtenerAlmacen(oeOrden.IdSubAlmacenDestino)
                cboAlmacenOrigen.Value = ObtenerAlmacen(oeOrden.IdSubAlmacenOrigen)
                cboSubAlmacenOrigen.Value = oeOrden.IdSubAlmacenOrigen
                cboSubAlmacenDestino.Value = oeOrden.IdSubAlmacenDestino
                'cboMoneda.Value = oeOrden.IdMoneda
                fecOrden.Value = oeOrden.FechaOrden
                txtGlosa.Text = oeOrden.Glosa
                txtEstadoOrden.Text = oeOrden.EstadoOrden
                Me.txtNroOrden.Text = oeOrden.NroOrden
                If oeOrden.EstadoOrden = "TERMINADA" Then
                    MyBase.Vista()
                    Inhabilitar(False)
                Else
                    MyBase.Editar()
                End If
                oeOrden.TipoOperacion = IIf(Operacion = "Ejecutar", "T", "A")
                ConsultarOrdenMaterial()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub ConsultarOrdenMaterial()
        Try
            ListarOrdenMaterial(True)
            If griOrdenMaterial.Rows.Count > 0 Then r_BarraOperaciones(True, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarOrdenMaterial(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrdenMaterial = New e_OrdenMaterial
            listaOrdenMaterial = New List(Of e_OrdenMaterial)
            oeOrdenMaterial.TipoOperacion = "L"
            oeOrdenMaterial.Activo = Activo
            oeOrdenMaterial.IdOrden = oeOrden.Id
            listaOrdenMaterial = olOrdenMaterial.Listar(oeOrdenMaterial)
            griOrdenMaterial.DataSource = listaOrdenMaterial
            llenaCombosGrillaOrdenMaterial()
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griOrdenMaterial.Focus()
    End Sub

    Private Sub ObtenerAlmacenSegunCentro(ByVal idCentro As String, ByVal cbo As Integer)
        Try
            oeAlmacen = New e_Almacen
            If Not String.IsNullOrEmpty(idCentro) Then
                oeAlmacen.TipoOperacion = ""
                oeAlmacen.Activo = True
                oeAlmacen.IdCentro = idCentro
                If cbo = 0 Then
                    LimpiaCombos(cboAlmacenOrigen)
                    LlenarCombo(cboAlmacenOrigen, "Nombre", olAlmacen.Listar(oeAlmacen), -1)
                Else
                    LimpiaCombos(cboAlmDestino)
                    LlenarComboMaestro(cboAlmDestino, olAlmacen.Listar(oeAlmacen), -1)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub llenarComboFiltroEstadoOrden()
        Try
            oeEstadoOrden = New e_EstadoOrden
            listaEstadoOrden = New List(Of e_EstadoOrden)
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

    Public Sub ListarTranferencias(ByVal activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeOrden = New e_Orden
            oeOrden.TipoOperacion = ""
            oeOrden.MovimientoInventario = ""
            oeOrden.Activo = activo      
            oeOrden.IdTipoOrden = "1CH000000003" 'ORDEN DE TRANSFERENCIA
            If rbNroOrden.Checked Then
                oeOrden.EstadoOrden = ""
                oeOrden.NroOrden = Me.txtNIngreso.Text.Trim
                oeOrden.IdMovimientoInventario = ""
                oeOrden.fechaInicio = Date.Parse("01/01/1901")
                oeOrden.fechaFin = Date.Parse("01/01/1901")
            Else
                oeOrden.fechaInicio = rfOrdenTransferenciaDesde.Value
                oeOrden.fechaFin = rfOrdenTransferenciaHasta.Value
                oeOrden.EstadoOrden = IIf(cboEstadoOrden.Value = "CERO", "", cboEstadoOrden.Value)
            End If
            griListaOrdenTransferencia.DataSource = olOrden.Listar(oeOrden)
            If griListaOrdenTransferencia.Rows.Count > 0 Then
                griListaOrdenTransferencia.Focus()
                griListaOrdenTransferencia.Rows.Item(0).Selected = True
            End If
            For Each fila As UltraGridRow In griListaOrdenTransferencia.Rows
                Select Case fila.Cells("EstadoOrden").Value
                    Case "GENERADA"
                        fila.CellAppearance.BackColor = Me.ColoresGenerado.Color
                    Case "RECEPCIONADA"
                        fila.CellAppearance.BackColor = Me.ColoresRecepcionado.Color
                    Case "TERMINADA"
                        fila.CellAppearance.BackColor = Me.ColoresTerminada.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaOrdenTransferencia.Focus()
    End Sub

    Public Sub HabInhVisualizacion(ByVal sw As Boolean)
        Me.etiEstado.Visible = sw
        Me.etiNroOrden.Visible = sw
        Me.txtEstadoOrden.Visible = sw
        Me.txtNroOrden.Visible = sw
    End Sub

    Public Sub InicializarTransferencia()
        Try
            oeOrden = New e_Orden
            Me.lbl_etiqueta.Visible = False
            Me.Agrupacion1.Enabled = 1
            Me.Agrupacion2.Enabled = 1
            Me.txtGlosa.Text = String.Empty
            Me.txtNroOrden.Text = String.Empty
            ''decTotal.Value = 0.0
            fecOrden.Value = Date.Now
            gbeMateriales.Expanded = True
            oeOrden.IdTipoOrden = "1CH000000003" 'ORDEN DE TRANSFERENCIA
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            Inhabilitar(True)
            LlenarCombos()
            'oeOrden.IdMoneda = cboMoneda.Value
            LimpiarListas()
            'habilito o inhabilito algunas cajas de texto
            HabInhVisualizacion(False)
            'controlo el sub menu
            r_BarraOperaciones(1, 1)
            InicializarColores()

            cboAlmacenOrigen.SelectedIndex = -1
            cboAlmDestino.SelectedIndex = -1
            cboSubAlmacenDestino.SelectedIndex = -1
            cboSubAlmacenOrigen.SelectedIndex = -1
            griOrdenMaterial.DisplayLayout.Bands(0).Columns("Stock").Hidden = Not (Operacion = "Nuevo")
            gbeMateriales.Expanded = True
            gbeMateriales.Enabled = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiarListas()
        Try
            listaMaterial = New List(Of e_Material)
            listaOrdenMaterial = New List(Of e_OrdenMaterial)
            griMaterial.DataSource = listaMaterial
            griOrdenMaterial.DataSource = listaOrdenMaterial
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            oeCentro = New e_Centro
            loCentro = New List(Of e_Centro)
            oeCentro.TipoOperacion = ""
            oeCentro.Id = ""
            oeCentro.Nombre = ""
            oeCentro.Activo = True
            loCentro.AddRange(olCentro.Listar(oeCentro))
            'LlenarComboMaestro(cboMoneda, olMoneda.Listar(oeMoneda), 0)
            LlenarComboMaestro(cboCenOrigen, loCentro, -1)
            LlenarComboMaestro(cboCenDestino, loCentro, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarMaterial(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeMaterial = New e_Material
            listaMaterial = New List(Of e_Material)
            oeMaterial.TipoOperacion = "A"
            oeMaterial.Activo = Activo
            listaMaterial.AddRange(olMaterial.Listar(oeMaterial))
            If listaOrdenMaterial.Count > 0 Then listaMaterial.RemoveAll(AddressOf VerificaListaMateriales)
            griMaterial.DataBind()
            llenaCombosGrillaMaterial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function VerificaListaMateriales(ByVal oeMat As e_Material) As Boolean
        Try
            For Each fila As e_OrdenMaterial In listaOrdenMaterial
                If (oeMat.Id = fila.IdMaterial) Then Return True
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function GuardarOrden() As Boolean
        Try
            oeOrden.lstOrdenMaterial = listaOrdenMaterial
            oeOrden.IdTipoOrden = "1CH000000003" 'ORDEN DE TRANSFERENCIA
            oeOrden.IdMovimientoInventario = ""
            oeOrden.IdProveedor = gs_IdClienteProveedorSistema.Trim
            oeOrden.FechaOrden = fecOrden.Value
            oeOrden.IdMoneda = "1CH01" 'ObtenerMoneda("SOLES")
            oeOrden.IdSubAlmacenOrigen = cboSubAlmacenOrigen.Value  'cboAlmacenOrigen.Value
            oeOrden.IdSubAlmacenDestino = cboSubAlmacenDestino.Value
            If Not ValidarTransferencia() Then Return False
            oeOrden.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olOrden.Guardar(oeOrden, New List(Of e_RegistroInventario)) Then
                If oeOrden.TipoOperacion = "T" Then
                    EjecutarOrdenes()
                    mensajeEmergente.Confirmacion("Se ejecuto satisfactoriamente la " & Me.Text)
                Else
                    mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                End If
                Consultar(True)
                MostrarTabs(0, ficOrden, 2)
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerMovInventario(ByVal nombreMovimientoInventario As String) As String
        Try
            oeMovimientoInventario = New e_MovimientoInventario
            oeMovimientoInventario.TipoOperacion = ""
            oeMovimientoInventario.Nombre = nombreMovimientoInventario
            oeMovimientoInventario.Activo = True
            oeMovimientoInventario = olMovimientoInventario.Obtener(oeMovimientoInventario)
            oeOrden.IdMovimientoInventario = oeMovimientoInventario.Id
            Return oeMovimientoInventario.Id
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
            Throw ex
        End Try
    End Function

    Private Sub EjecutarOrdenes()
        Try
            Dim oeOrdenSalida As New e_Orden
            'REGISTRAR ORDEN DE SALIDA DE ORDEN DE TRANSFERENCIA
            oeOrdenSalida.TipoOperacion = "I"
            oeOrdenSalida.IdTipoOrden = "1CH000000002" ' ORDEN DE SALIDA
            oeOrdenSalida.TipoReferencia = "ORDEN DE TRANSFERENCIA"
            oeOrdenSalida.Referencia = oeOrden.NroOrden
            oeOrdenSalida.Id = ""
            oeOrdenSalida.NroOrden = ""
            oeOrdenSalida.IdProveedor = gs_IdClienteProveedorSistema.Trim
            oeOrdenSalida.FechaOrden = Date.Now
            oeOrdenSalida.IdMoneda = ObtenerMoneda("SOLES")
            oeOrdenSalida.IdMovimientoInventario = "1CH000000023" 'SALIDA POR TRANSFERENCIA ENTRE ALMACENES
            oeOrdenSalida.IdEstadoOrden = ""
            oeOrdenSalida.UsuarioCreacion = gUsuarioSGI.Id
            oeOrdenSalida.IdSubAlmacenOrigen = ""
            oeOrdenSalida.IdSubAlmacenDestino = ""
            For i As Integer = 0 To listaOrdenMaterial.Count - 1
                listaOrdenMaterial.Item(i).IdAlmacen = oeOrden.IdSubAlmacenOrigen
                listaOrdenMaterial.Item(i).IdSubAlmacen = cboSubAlmacenOrigen.Value
            Next
            oeOrdenSalida.lstOrdenMaterial = listaOrdenMaterial
            oeOrdenSalida.PrefijoID = gs_PrefijoIdSucursal '@0001
            olOrden.Guardar(oeOrdenSalida, New List(Of e_RegistroInventario))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub r_Ejecutar()
        Operacion = "Ejecutar"
        EditarOrden()
        Me.lbl_etiqueta.Visible = True
        Me.Agrupacion1.Enabled = 0 : Me.Agrupacion2.Enabled = 0
        MostrarTabs(1, ficOrden, 1)
        HabInhVisualizacion(True)
        gbeMateriales.Expanded = False
        gbeMateriales.Enabled = False
    End Sub

    Private Sub ListarSubAlmacen(ByVal IdAlmacen As String, ByVal Tipo As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.IdAlmacen = IdAlmacen
            oeSubAlmacen.TipoOperacion = "A"
            If Tipo = 0 Then
                LlenarCombo(cboSubAlmacenDestino, "Descripcion", olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen), -1)
            Else
                LlenarCombo(cboSubAlmacenOrigen, "Descripcion", olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen), -1)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Function ValidarTransferencia() As Boolean
        Try
            Dim oe1, oe2 As New e_Almacen
            oe1.Id = ObtenerAlmacen(oeOrden.IdSubAlmacenOrigen) : oe2.Id = ObtenerAlmacen(oeOrden.IdSubAlmacenDestino)
            oe1.TipoOperacion = "T" : oe2.TipoOperacion = "T"
            oe1 = olAlmacen.Obtener(oe1) : oe2 = olAlmacen.Obtener(oe2)
            If oe1.Tipo <> oe2.Tipo Then Throw New Exception("No Puede hacer Transferencia entre Almacenes de Diferente Tipo")
            If oe1.Lotizable <> oe2.Lotizable Then Throw New Exception("No se Puede Realizar la Transferencia")
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Detalles de la orden de transferencia"

    Sub AgregarDetalle()
        Try
            Dim sw As Boolean = False
            For Each lista As e_Material In listaMaterial
                If lista.Seleccion Then sw = True
            Next

            If Not sw Then Throw New Exception("Marque por lo menos un Material para Agregar a la Lista de Materiales de la Orden.")

            AsignarOrdenMaterial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub QuitarDetalle()
        Try
            QuitarMaterialOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarMateriales() As Boolean
        Dim sw As Boolean = False
        For i As Integer = 0 To listaMaterial.Count - 1
            If listaMaterial.Item(i).Seleccion Then
                sw = True
            End If
        Next
        Return sw
    End Function

    Public Function ValidandoStockMateriales() As String
        Dim Materiales As String = String.Empty : Dim cont As Integer = 0
        If ValidarMateriales() Then
            For Each lista As e_Material In listaMaterial
                If lista.Seleccion And lista.Stock = 0 Then
                    cont += 1
                    If cont = 1 Then
                        Materiales &= "'" & lista.Nombre & "'"
                    ElseIf cont > 1 Then
                        Materiales &= ",'" & lista.Nombre & "'"
                    End If
                End If
            Next
        Else
            Materiales = "''"
        End If
        Return Materiales
    End Function

    Private Sub AsignarOrdenMaterial()
        Try
            Dim Material As String = String.Empty
            If String.IsNullOrEmpty(oeOrden.IdSubAlmacenDestino) Then Throw New Exception("Seleccione el Almacen de Destino,Por Favor")
            Dim IGV As Double = ObtenerIGV(ObtenerFechaServidor().Date)
            For Each obj As e_Material In listaMaterial
                If obj.Seleccion And obj.Stock > 0 Then
                    oeOrdenMaterial = New e_OrdenMaterial
                    oeOrdenMaterial.Seleccion = False
                    oeOrdenMaterial.IdMaterial = obj.Id
                    oeOrdenMaterial.Material = obj.Nombre
                    oeOrdenMaterial.CantidadMaterial = obj.Stock
                    oeOrdenMaterial.PrecioUnitario = Math.Round(obj.Precio * (1 + IGV), 3)
                    oeOrdenMaterial.IdAlmacen = obj.IdAlmacen
                    oeOrdenMaterial.IdTipoUnidadMedida = obj.IdTipoUnidadMedida
                    oeOrdenMaterial.IdUnidadMedida = obj.IdUnidadMedida
                    oeOrdenMaterial.UnidadMedida = obj.UnidadMedida
                    oeOrdenMaterial.ValorVenta = oeOrdenMaterial.PrecioUnitario * oeOrdenMaterial.CantidadMaterial
                    oeOrdenMaterial.Activo = True
                    oeOrdenMaterial.CodigoMaterial = obj.Codigo
                    oeOrdenMaterial.Stock = obj.Stock
                    oeOrdenMaterial.IdSubAlmacen = obj.IdSubAlmacen
                    listaOrdenMaterial.Add(oeOrdenMaterial)
                End If
            Next
            Dim MaterialStock As String = ValidandoStockMateriales()
            If MaterialStock.Length > 0 Then
                mensajeEmergente.Problema("Los sgtes Materiales No se agregaron debido al stock = 0 : " & MaterialStock)
            End If
            If Material <> String.Empty Then
                mensajeEmergente.Problema("Los sgtes Materialesa agregar no se encuentra asignado al almacen destino,no se agregara a la lista de materiales de la orden : " & Material)
            End If
            griOrdenMaterial.DataBind()
            llenaCombosGrillaOrdenMaterial()
            gbeMateriales.Expanded = False
            listaMaterial.RemoveAll(AddressOf eliminaMateriales)
            griMaterial.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub llenaCombosGrillaOrdenMaterial()
        Try
            For j As Integer = 0 To griOrdenMaterial.Rows.Count - 1
                oeUnidadMedida = New e_UnidadMedida()
                oeUnidadMedida.Activo = True
                oeUnidadMedida.Factor = 0
                oeUnidadMedida.IdTipoUnidadMedida = griOrdenMaterial.Rows(j).Cells("IdTipoUnidadMedida").Value.ToString
                CrearComboGridPorCelda("IdUnidadMedida", "Nombre", j, griOrdenMaterial, olUnidadMedida.ComboGrilla(oeUnidadMedida), True)
            Next
            griOrdenMaterial.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub llenaCombosGrillaMaterial()
        Try
            For i As Integer = 0 To griMaterial.Rows.Count - 1
                oeMaterialAlmacen = New e_MaterialAlmacen
                oeMaterialAlmacen.TipoOperacion = "4"
                oeMaterialAlmacen.Activo = True
                oeMaterialAlmacen.IdMaterial = griMaterial.Rows(i).Cells("Id").Value.ToString
                CrearComboGridPorCelda("IdAlmacen", "Nombre", i, griMaterial, olMaterialAlmacen.ComboGrilla(oeMaterialAlmacen), True)
            Next
            griMaterial.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function eliminaMateriales(ByVal oeMaterial As e_Material) As Boolean
        Return oeMaterial.Seleccion
    End Function


    Sub QuitarMaterialOrden()
        Try
            Dim sw As Boolean = False
            For Each lista As e_OrdenMaterial In listaOrdenMaterial
                If lista.Seleccion Then sw = True
            Next
            If Not sw Then Throw New Exception("Marque por lo menos un registro para quitar de lista")
            If MessageBox.Show("¿Esta seguro eliminar los registros marcados? ", _
                         "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                listaOrdenMaterial.RemoveAll(AddressOf verificarSeleccionado)
                griMaterial.DataBind()
                griOrdenMaterial.DataBind()
                'CalcularTotalesDetalle()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function verificarSeleccionado(ByVal obj As e_OrdenMaterial) As Boolean
        Try
            If Not String.IsNullOrEmpty(obj.IdMaterial) AndAlso obj.Seleccion Then
                Dim oeMaterial As New e_Material
                oeMaterial.Id = obj.IdMaterial
                oeMaterial.IdAlmacen = obj.IdAlmacen
                oeMaterial.Activo = True
                oeMaterial.TipoOperacion = "5"
                oeMaterial = olMaterial.ObtenerMaterialSegunAlmacen(oeMaterial)
                listaMaterial.Add(oeMaterial)
            End If
            Return obj.Seleccion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

