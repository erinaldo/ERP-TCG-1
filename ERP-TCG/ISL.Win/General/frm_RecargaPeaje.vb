Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports System.Text

Public Class frm_RecargaPeaje
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_RecargaPeaje = Nothing
    'Instancia unica de Formulario: frm_OrdenProduccionLadrillo
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_RecargaPeaje
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private Operacion As String = ""
    Private Const IdEGenerada As String = "1CH00014"
    Private Const IdETerminada As String = "1CH00019"
    Private Const IdTDFactura As String = "1CH000000026"
    Private Const IdMSoles As String = "1CH01"
    Private Const IdMDolares As String = "1CH02"

    Private oeRecargaPeaje As e_RecargaPeaje
    Private loRecargaPeaje As New List(Of e_RecargaPeaje)
    Private olRecargaPeaje As New l_RecargaPeaje

    Private oeDetalle As e_RecargaPeaje
    Private loDetalle As New List(Of e_RecargaPeaje)

    Private oeVehTarjeta As e_VehiculoTarjeta
    Private loVehTarjeta As New List(Of e_VehiculoTarjeta)
    Private loVehTarjetaF As New List(Of e_VehiculoTarjeta)
    Private olVehTarjeta As New l_VehiculoTarjeta

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Operacion = "Listar"
            mt_Listar()
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            'Inicializo objeto principal
            oeRecargaPeaje = New e_RecargaPeaje
            'Ingreso el tipo de operacion
            oeRecargaPeaje.TipoOperacion = "I"
            Operacion = "Nuevo"
            mt_InicializarControles()
            'Agregar Todas las tarjetas a la grilla
            For Each _VehTarjeta As e_VehiculoTarjeta In olVehTarjeta.Listar(New e_VehiculoTarjeta With {.TipoOperacion = "GEN", _
                                                                                    .Actual = 1}).ToList
                mt_AgregarTarjeta(True, _VehTarjeta.Id, _VehTarjeta.Placa, False)
            Next
            'Cambio de Pestaña
            MostrarTabs(1, ficPrincipal, 1)
            'Control Botones generales
            mt_ControlBotoneria()
            'Foco primer control
            txtSerie.Focus()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If fc_ValidarFilaSeleccionada(griLista) Then
                Operacion = "Editar"
                mt_Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If fc_ValidarFilaSeleccionada(griLista) AndAlso fc_ValidarEliminar() AndAlso _
                MessageBox.Show("Desea eliminar el registro seleccionado?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes _
                AndAlso fc_Eliminar() Then
                MessageBox.Show("Registro eliminado con exito", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loRecargaPeaje.Remove(griLista.ActiveRow.ListObject)
                griLista.DataBind()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            txtSerie.Text = FormatoDocumento(txtSerie.Text.Trim(), 4)
            txtNumero.Text = FormatoDocumento(txtNumero.Text.Trim(), 10)
            If fc_ValidarGuardar() AndAlso fc_Guardar() Then
                MessageBox.Show("Operacion realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                MostrarTabs(0, ficPrincipal, 0)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("Desea cancelar la operacion?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficPrincipal, 0)
                mt_ControlBotoneria()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
            Try
                If griLista.Rows.Count > 0 Then
                    Exportar_Excel(griLista)
                Else
                    MessageBox.Show("No hay ningún dato para exportar al Excel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gf_AsignarEventoSeleccionarTexto(Me)
            mt_InicializarFormulario()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            mt_ControlBotoneria()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            instancia = Nothing
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControlBoton()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspTarjeta_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspTarjeta.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbAgregarTarjeta.Name
                    mt_AgregarTarjeta(False, "", "", True)
                Case tsbQuitarTarjeta.Name
                    mt_QuitarTarjeta()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalle_CellChange(sender As Object, e As CellEventArgs) Handles griDetalle.CellChange
        Try
            griDetalle.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalle_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griDetalle.BeforeCellUpdate
        Try
            If griDetalle.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "MontoTarjeta"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmbMoneda_ValueChanged(sender As Object, e As EventArgs) Handles cmbMoneda.ValueChanged
        Try
            If cmbMoneda.SelectedIndex <> -1 Then
                Select Case cmbMoneda.Value
                    Case IdMSoles
                        griDetalle.DisplayLayout.Bands(0).Columns("MontoTarjeta").Header.Caption = "Monto (S/)"
                        ugbMontoTotal.Text = "Monto Total (S/)"
                    Case IdMDolares
                        griDetalle.DisplayLayout.Bands(0).Columns("MontoTarjeta").Header.Caption = "Monto ($)"
                        ugbMontoTotal.Text = "Monto Total ($)"
                    Case Else
                        griDetalle.DisplayLayout.Bands(0).Columns("MontoTarjeta").Header.Caption = "Monto"
                        ugbMontoTotal.Text = "Monto Total"
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uneMontoTotal_EditorButtonClick(sender As Object, e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles uneMontoTotal.EditorButtonClick
        Try
            Select Case e.Button.Key
                Case "Prorratear"
                    mt_Prorratear()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griDetalle_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griDetalle.AfterCellUpdate
        Try
            If e.Cell.Row.Index <> -1 AndAlso griDetalle.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "IdVehiculoTarjeta"
                        With griDetalle.Rows(e.Cell.Row.Index)
                            If loVehTarjetaF.Where(Function(x) x.Id = e.Cell.Value).ToList.Count > 0 Then
                                Dim lo_VT As New e_VehiculoTarjeta
                                lo_VT = loVehTarjetaF.Where(Function(x) x.Id = e.Cell.Value).ToList(0)
                                .Cells("Placa").Value = lo_VT.Placa
                            Else
                                .Cells("Placa").Value = ""
                            End If
                        End With
                    Case "MontoTarjeta"
                        mt_CalcularMontoTotal()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_RecargaPeaje_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case tabLista.Tab.Index
                Case tabMantenimiento.Tab.Index
                    Select Case e.KeyCode
                        Case Keys.Enter
                            If Me.ActiveControl.Name <> uneMontoTotal.Name Then
                                SendKeys.Send("{TAB}")
                            End If
                        Case Keys.Insert
                            tsbAgregarTarjeta.PerformClick()
                        Case Keys.Delete
                            tsbQuitarTarjeta.PerformClick()
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        Try
            If txtSerie.Text.Trim().Length <> 0 Then
                txtSerie.Text = FormatoDocumento(txtSerie.Text, 4)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        Try
            If txtNumero.Text.Trim().Length <> 0 Then
                txtNumero.Text = FormatoDocumento(txtNumero.Text, 10)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tspLista_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tspLista.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case tsbEjecutar.Name
                    mt_Ejecutar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griLista_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griLista.DoubleClickRow
        Try
            If e.Row.Index <> -1 Then
                Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub uneMontoTotal_KeyDown(sender As Object, e As KeyEventArgs) Handles uneMontoTotal.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mt_Prorratear()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmsRecarga_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsRecarga.Opening
        Try
            cmsRecarga.Items("ItemEjecutar").Enabled = False
            cmsRecarga.Items("ItemBaseA").Enabled = False
            If griLista.ActiveRow IsNot Nothing AndAlso griLista.ActiveRow.Index >= 0 AndAlso griLista.Selected.Rows.Count > 0 Then
                If griLista.ActiveRow.Cells("Serie").Value.ToString().Trim <> "" OrElse griLista.ActiveRow.Cells("Numero").Value.ToString().Trim <> "" Then
                    cmsRecarga.Items("ItemBaseA").Enabled = True
                End If
                If griLista.ActiveRow.Cells("IdEstado").Value.ToString().Trim() = IdEGenerada Then
                    cmsRecarga.Items("ItemEjecutar").Enabled = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cmsRecarga_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsRecarga.ItemClicked
        Try
            Select Case e.ClickedItem.Name
                Case itemEjecutar.Name
                    mt_Ejecutar()
                Case itemBaseA.Name
                    mt_GenerarBaseSeleccion()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub


#End Region

#Region "Metodos"

    Private Sub mt_InicializarControles()
        Try
            If CType(cmbEstado.DataSource, List(Of e_Estado)).Where(Function(x) x.Id = IdEGenerada).Count > 0 Then
                cmbEstado.Value = IdEGenerada
            End If
            If CType(cmbMoneda.DataSource, List(Of e_Moneda)).Count > 0 Then
                cmbMoneda.SelectedIndex = 0
            End If
            dtpFechaDoc.Value = Date.Now.Date
            If CType(cmbTipoDocumento.DataSource, List(Of e_TipoDocumento)).Where(Function(x) x.Id = IdTDFactura).Count > 0 Then
                cmbTipoDocumento.Value = IdTDFactura
            End If
            txtSerie.Text = ""
            txtNumero.Text = ""
            uneMontoTotal.Value = 0
            loDetalle.Clear()
            griDetalle.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oeRecargaPeaje = New e_RecargaPeaje
            With oeRecargaPeaje
                .TipoOperacion = "AGR"
                .Fecha = dtpDesde.Value.Date
                .FechaHasta = dtpHasta.Value.Date
                .IdEstado = cmbEstadoFiltro.Value
            End With
            loRecargaPeaje.Clear()
            loRecargaPeaje.AddRange(olRecargaPeaje.Listar(oeRecargaPeaje).OrderBy(Function(x) x.Fecha).ToList)
            Dim oeDetalle As e_RecargaPeajeDetalle
            For Each _Peaje As e_RecargaPeaje In loRecargaPeaje
                oeRecargaPeaje = New e_RecargaPeaje
                With oeRecargaPeaje
                    .TipoDocumento = "GEN"
                    .Serie = _Peaje.Serie
                    .Numero = _Peaje.Numero
                End With
                Dim Lista As New List(Of e_RecargaPeaje)
                Lista.AddRange(olRecargaPeaje.Listar(oeRecargaPeaje))
                Dim ListaDetalle As New List(Of e_RecargaPeajeDetalle)
                For Each _Detalle As e_RecargaPeaje In Lista
                    oeDetalle = New e_RecargaPeajeDetalle
                    With oeDetalle
                        .NroTarjeta = _Detalle.NroTarjeta
                        .MontoTarjeta = _Detalle.MontoTarjeta
                        .Placa = _Detalle.Placa
                    End With
                    ListaDetalle.Add(oeDetalle)
                Next
                _Peaje.ListaDetalles.AddRange(ListaDetalle)
            Next
            griLista.DataBind()
            For Each _Fila As UltraGridRow In griLista.Rows
                Select Case _Fila.Cells("IdEstado").Value.ToString().Trim()
                    Case IdEGenerada
                        _Fila.CellAppearance.BackColor = colorGenerado.Color
                        If _Fila.HasChild = True AndAlso _Fila.ChildBands(0).Rows.Count > 0 Then
                            For Each _Child As UltraGridRow In _Fila.ChildBands(0).Rows
                                _Child.CellAppearance.BackColor = colorGenerado.Color
                            Next
                        End If
                    Case IdETerminada
                        _Fila.CellAppearance.BackColor = colorTerminado.Color
                        If _Fila.HasChild = True AndAlso _Fila.ChildBands(0).Rows.Count > 0 Then
                            For Each _Child As UltraGridRow In _Fila.ChildBands(0).Rows
                                _Child.CellAppearance.BackColor = colorTerminado.Color
                            Next
                        End If
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarFormulario()
        Try
            colorGenerado.Color = Color.White
            colorTerminado.Color = Color.LightGreen
            ficPrincipal.Tabs(tabMantenimiento.Tab.Index).Enabled = False
            dtpHasta.Value = Date.Now.Date
            dtpDesde.Value = dtpHasta.Value.Date.AddDays(-7)
            griLista.DataSource = loRecargaPeaje
            For Each _Fila As UltraGridColumn In griLista.DisplayLayout.Bands(0).Columns
                _Fila.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                _Fila.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            With griLista.DisplayLayout.Bands(0)
                .Columns("Fecha").Width = 115
            End With
            'Detalles
            For Each _Fila As UltraGridColumn In griLista.DisplayLayout.Bands(1).Columns
                _Fila.Hidden = True
                _Fila.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
                _Fila.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            Next
            With griLista.DisplayLayout.Bands(1)
                .Columns("NroTarjeta").Hidden = False
                .Columns("NroTarjeta").Width = 115
                .Columns("NroTarjeta").Header.VisiblePosition = 0
                .Columns("MontoTarjeta").Hidden = False
                .Columns("MontoTarjeta").Width = 60
                .Columns("MontoTarjeta").Header.VisiblePosition = 1
                .Columns("MontoTarjeta").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .Columns("MontoTarjeta").Format = "###,##0.00"
                .Columns("Placa").Hidden = False
                .Columns("Placa").Width = 100
                .Columns("Placa").Header.VisiblePosition = 2
            End With
            griLista.DisplayLayout.Bands(1).ColHeadersVisible = False
            griLista.DisplayLayout.Bands(1).HeaderVisible = False
            griLista.DisplayLayout.Bands(1).Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False
            griDetalle.DataSource = loDetalle
            For Each _Fila As UltraGridColumn In griLista.DisplayLayout.Bands(0).Columns
                _Fila.SortIndicator = SortIndicator.Disabled
            Next
            mt_LlenarCombos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlBotoneria()
        Try
            Select Case ficPrincipal.SelectedTab.Index
                Case 0
                    If griLista.Rows.Count > 0 Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                    Else
                        ControlBoton(1, 1)
                    End If
                Case 1
                    If loDetalle.Count > 0 AndAlso loDetalle(0).IdEstado = IdETerminada Then
                        ControlBoton(0, 0, 0, 0, 1, 0, 0, 0, 0)
                    Else
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_LlenarCombos()
        Try
            'Cargar Estado
            Dim loEstado As New List(Of e_Estado)
            Dim olEstado As New l_Estado
            Dim oeEstado As e_Estado
            oeEstado = New e_Estado
            oeEstado.Nombre = "CONFIGURACION"
            loEstado.AddRange(olEstado.Listar(oeEstado).OrderBy(Function(x) x.Nombre).ToList)
            oeEstado = New e_Estado With {.Id = "", .Nombre = "TODOS"}
            loEstado.Insert(0, oeEstado)
            ComboNormal(cmbEstado, loEstado.Where(Function(x) x.Id = IdEGenerada Or x.Id = IdETerminada).ToList, If(loEstado.Where(Function(x) x.Nombre = IdEGenerada Or x.Nombre = IdETerminada).Count > 0, 0, -1))
            ComboNormal(cmbEstadoFiltro, loEstado.Where(Function(x) x.Id = IdEGenerada Or x.Id = IdETerminada Or x.Id.Trim().Length = 0).ToList, 0)
            oeEstado = Nothing
            olEstado = Nothing
            'Cargar Moneda
            Dim loMoneda As New List(Of e_Moneda)
            Dim olMoneda As New l_Moneda
            Dim oeMoneda As New e_Moneda
            loMoneda.AddRange(olMoneda.Listar(oeMoneda).OrderBy(Function(x) x.Id).ToList)
            ComboNormal(cmbMoneda, loMoneda, If(loMoneda.Count > 0, 0, -1))
            oeMoneda = Nothing
            olMoneda = Nothing
            'Cargar Tipo Documento
            Dim loTipoDocumento As New List(Of e_TipoDocumento)
            Dim olTipoDocumento As New l_TipoDocumento
            Dim oeTipoDocumento As New e_TipoDocumento
            loTipoDocumento.AddRange(olTipoDocumento.Listar(oeTipoDocumento))
            ComboNormal(cmbTipoDocumento, loTipoDocumento, -1)
            If CType(cmbTipoDocumento.DataSource, List(Of e_TipoDocumento)).Where(Function(x) x.Id = IdTDFactura).Count > 0 Then
                cmbTipoDocumento.Value = IdTDFactura
            End If
            oeTipoDocumento = Nothing
            olTipoDocumento = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_AgregarTarjeta(bolTarjetaDefinida As Boolean, IdVehiculoTarjeta As String, strPlaca As String, bolBusquedaLista As Boolean)
        Try
            If bolTarjetaDefinida Then
                oeDetalle = New e_RecargaPeaje
                With oeDetalle
                    .IdVehiculoTarjeta = IdVehiculoTarjeta
                    .Placa = strPlaca
                End With
            Else
                oeDetalle = New e_RecargaPeaje
            End If
            loDetalle.Add(oeDetalle)
            griDetalle.DataBind()
            LlenarComboTarjeta(bolBusquedaLista)
            griDetalle.Rows(loDetalle.Count - 1).Cells("IdVehiculoTarjeta").Activate()
            griDetalle.Focus()
            griDetalle.PerformAction(UltraGridAction.EnterEditMode, False, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarComboTarjeta(bolBusquedaLista As Boolean)
        Try
            oeVehTarjeta = New e_VehiculoTarjeta
            With oeVehTarjeta
                .TipoOperacion = "GEN"
                .Actual = True
            End With
            loVehTarjeta.Clear()
            loVehTarjeta.AddRange(olVehTarjeta.Listar(oeVehTarjeta))
            loVehTarjetaF.Clear()
            loVehTarjetaF.AddRange(loVehTarjeta)
            If bolBusquedaLista Then
                If loDetalle.Count > 1 Then
                    For Each _Detalle As e_RecargaPeaje In loDetalle
                        For index = loVehTarjeta.Count - 1 To 0 Step -1
                            If loVehTarjeta(index).Id = _Detalle.IdVehiculoTarjeta Then
                                loVehTarjeta.RemoveAt(index)
                                Exit For
                            End If
                        Next
                    Next
                End If
            End If
            mt_ComboGrillaTarjeta(griDetalle)
            griDetalle.DisplayLayout.Bands(0).Columns("IdVehiculoTarjeta").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown
            griDetalle.DisplayLayout.Bands(0).Columns("IdVehiculoTarjeta").AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
            griDetalle.DisplayLayout.Bands(0).Columns("IdVehiculoTarjeta").AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ComboGrillaTarjeta(Grilla As Infragistics.Win.UltraWinGrid.UltraGrid)
        Try
            With Grilla
                CrearComboGridCelda("IdVehiculoTarjeta", "Nombre", loDetalle.Count - 1, Grilla, fc_DTTarjeta(loVehTarjeta), False)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_QuitarTarjeta()
        Try
            For index = loDetalle.Count - 1 To 0 Step -1
                If loDetalle(index).Seleccion Then
                    If String.IsNullOrWhiteSpace(loDetalle(index).Id) Then
                        loDetalle.Remove(loDetalle(index))
                    Else
                        loDetalle.Item(index).TipoOperacion = "E"
                        loDetalle.Item(index).UsuarioCreacion = gUsuarioSGI.Id
                        For Each _Fila In griDetalle.Rows.Where(Function(x) x.Hidden = False)
                            If _Fila.Cells("Id").Value = loDetalle(index).Id Then
                                _Fila.Hidden = True
                            End If
                        Next
                    End If
                End If
            Next
            griDetalle.DataBind()
            mt_CalcularMontoTotal()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Editar()
        Try
            mt_InicializarControles()
            oeRecargaPeaje = New e_RecargaPeaje
            With oeRecargaPeaje
                .Serie = griLista.ActiveRow.Cells("Serie").Value.ToString().Trim()
                .Numero = griLista.ActiveRow.Cells("Numero").Value.ToString().Trim()
            End With
            loDetalle.Clear()
            loDetalle.AddRange(olRecargaPeaje.Listar(oeRecargaPeaje))
            If loDetalle.Count > 0 Then
                With loDetalle(0)
                    cmbMoneda.Value = .IdMoneda
                    dtpFechaDoc.Value = .Fecha
                    cmbTipoDocumento.Value = .IdTipoDocumento
                    txtSerie.Text = .Serie
                    txtNumero.Text = .Numero
                    uneMontoTotal.Value = .MontoTotal
                End With
            End If
            griDetalle.DataBind()
            oeVehTarjeta = New e_VehiculoTarjeta
            oeVehTarjeta.TipoOperacion = "GEN"
            oeVehTarjeta.Actual = True
            loVehTarjeta.Clear()
            loVehTarjeta.AddRange(olVehTarjeta.Listar(oeVehTarjeta))
            For index = 0 To griDetalle.Rows.Count - 1
                CrearComboGridCelda("IdVehiculoTarjeta", "Nombre", index, griDetalle, fc_DTTarjeta(loVehTarjeta), False)
                griDetalle.Rows(index).Cells("IdVehiculoTarjeta").Activation = Activation.NoEdit
            Next
            If Operacion = "Ejecutar" AndAlso CType(cmbEstado.DataSource, List(Of e_Estado)).Where(Function(x) x.Id = IdETerminada).Count > 0 Then
                cmbEstado.Value = IdETerminada
            End If
            MostrarTabs(1, ficPrincipal, 1)
            mt_ControlBotoneria()
            txtSerie.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CalcularMontoTotal()
        Try
            uneMontoTotal.Value = loDetalle.Where(Function(x) x.TipoOperacion <> "E").Sum(Function(x) x.MontoTarjeta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Ejecutar()
        Try
            If fc_ValidarFilaSeleccionada(griLista) Then
                If griLista.ActiveRow.Cells("IdEstado").Value.ToString().Trim() = IdEGenerada Then
                    Operacion = "Ejecutar"
                    mt_Editar()
                Else
                    MessageBox.Show("Solo se puede ejecutar registros en estado Generado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Prorratear()
        Try
            If uneMontoTotal.Value > 0 AndAlso loDetalle.Where(Function(x) x.TipoOperacion <> "E").Count > 0 Then
                Dim decMontoTarjeta As Decimal = Math.Round(uneMontoTotal.Value / loDetalle.Where(Function(x) x.TipoOperacion <> "E").Count, 2, MidpointRounding.AwayFromZero)
                For Each _Detalle As e_RecargaPeaje In loDetalle.Where(Function(x) x.TipoOperacion <> "E").ToList
                    With _Detalle
                        _Detalle.MontoTarjeta = decMontoTarjeta
                    End With
                Next
                griDetalle.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GenerarBaseSeleccion()
        Try
            'Inicializo objeto principal
            oeRecargaPeaje = New e_RecargaPeaje
            'Ingreso el tipo de operacion
            oeRecargaPeaje.TipoOperacion = "I"
            Operacion = "Nuevo"
            mt_InicializarControles()
            'Agregar Todas las tarjetas a la grilla
            For Each _Detalle As e_RecargaPeaje In olRecargaPeaje.Listar(New e_RecargaPeaje With {.TipoOperacion = "GEN", _
                                                                          .Serie = griLista.ActiveRow.Cells("Serie").Value.ToString(), _
                                                                          .Numero = griLista.ActiveRow.Cells("Numero").Value.ToString()}).ToList()
                mt_AgregarTarjeta(True, _Detalle.IdVehiculoTarjeta, _Detalle.Placa, False)
            Next
            'Cambio de Pestaña
            MostrarTabs(1, ficPrincipal, 1)
            'Control Botones generales
            mt_ControlBotoneria()
            'Foco primer control
            txtSerie.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Funciones"

    Public Function fc_ValidarFilaSeleccionada(Grilla As Infragistics.Win.UltraWinGrid.UltraGrid) As Boolean
        Try
            If Not (Grilla.Selected.Rows.Count > 0 AndAlso Grilla.ActiveRow.Index >= 0) Then
                MessageBox.Show("Seleccione Fila", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_DTTarjeta(Lista As List(Of e_VehiculoTarjeta)) As Data.DataTable
        Try
            Dim ds = New DataTable
            ds.Columns.Add("Codigo")
            ds.Columns.Add("Nombre")
            For Each item In Lista
                Dim newRow As DataRow = ds.NewRow()
                newRow("Codigo") = item.Id
                newRow("Nombre") = item.NroTarjeta
                ds.Rows.Add(newRow)
            Next
            Return ds
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarGuardar() As Boolean
        Try
            If String.IsNullOrEmpty(txtSerie.Text) OrElse txtSerie.Text.Trim().Length = 0 Then
                MessageBox.Show("Ingrese Serie", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSerie.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(txtNumero.Text) OrElse txtNumero.Text.Trim().Length = 0 Then
                MessageBox.Show("Ingrese Numero", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNumero.Focus()
                Return False
            End If
            Dim bnd As Boolean = False
            Dim loRecargaDetalle As New List(Of e_RecargaPeaje)
            loRecargaDetalle.AddRange(olRecargaPeaje.Listar(New e_RecargaPeaje With {.TipoOperacion = "GEN", _
                                                              .Serie = txtSerie.Text.Trim(), _
                                                              .Numero = txtNumero.Text.Trim()}))
            For Each _Detalle In loRecargaDetalle
                If loDetalle.Where(Function(x) x.Id <> "" And x.Id = _Detalle.Id).Count = 0 Then
                    bnd = True
                    Exit For
                End If
            Next
            If bnd Then
                MessageBox.Show("El documento: " & txtSerie.Text.Trim() & "-" & txtNumero.Text.Trim() & Environment.NewLine & _
                                "Ya se encuentra registrado")
                txtSerie.Focus()
                Return False
            End If

            If loDetalle.Where(Function(x) x.TipoOperacion <> "E").Count <= 0 Then
                MessageBox.Show("Debe ingresar almenos una tarjeta", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                griDetalle.Focus()
                Return False
            End If
            If loDetalle.Where(Function(x) x.TipoOperacion <> "E").Select(Function(x) x.IdVehiculoTarjeta).Distinct.Count <> loDetalle.Where(Function(x) x.TipoOperacion <> "E").Count Then
                MessageBox.Show("Tarjetas repetidas ingrese tarjetas válidas", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                griDetalle.Focus()
                Return False
            End If
            If loDetalle.Where(Function(x) x.TipoOperacion <> "E" And x.IdVehiculoTarjeta = "").Count > 0 Then
                MessageBox.Show("Ingrese tarjeta válidas", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Dim Cadena As New StringBuilder
            For Each _Detalle As e_RecargaPeaje In loDetalle.Where(Function(x) x.TipoOperacion <> "E")
                If _Detalle.MontoTarjeta = 0 Then
                    Cadena.Append(_Detalle.IdVehiculoTarjeta).AppendLine()
                End If
            Next
            If Cadena.ToString.Trim().Length <> 0 Then
                MessageBox.Show("Ingrese monto válido para las siguientes tarjetas " & Environment.NewLine & _
                                Cadena.ToString, "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            If uneMontoTotal.Value <> loDetalle.Where(Function(x) x.TipoOperacion <> "E").Sum(Function(x) x.MontoTarjeta) Then
                MessageBox.Show("El monto total es diferente al monto sumado de las tarjetas")
                Return False
            End If
            If Operacion = "Ejecutar" AndAlso Convert.ToInt64(txtSerie.Text) = 0 AndAlso Convert.ToInt64(txtNumero.Text) = 0 Then
                MessageBox.Show("Ingrese Serie y numero válido", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Guardar() As Boolean
        Try
            For Each _Recarga As e_RecargaPeaje In loDetalle.Where(Function(x) x.TipoOperacion <> "E").ToList
                With _Recarga
                    .IdEstado = cmbEstado.Value
                    .IdMoneda = cmbMoneda.Value
                    .Fecha = dtpFechaDoc.Value
                    .IdTipoDocumento = cmbTipoDocumento.Value
                    .Serie = txtSerie.Text
                    .Numero = txtNumero.Text
                    .MontoTotal = Convert.ToDecimal(uneMontoTotal.Value)
                    .UsuarioCreacion = gUsuarioSGI.Id
                End With
            Next
            Select Case Operacion
                Case "Nuevo"
                    Return olRecargaPeaje.GuardarMasivo(loDetalle, PrefijoIdSucursal)
                Case "Editar", "Ejecutar"
                    Return olRecargaPeaje.EditarMasivo(loDetalle)
                Case Else
                    Return False
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_Eliminar() As Boolean
        Try
            oeRecargaPeaje = New e_RecargaPeaje
            With oeRecargaPeaje
                .Serie = griLista.ActiveRow.Cells("Serie").Value.ToString().Trim()
                .Numero = griLista.ActiveRow.Cells("Numero").Value.ToString().Trim()
            End With
            Dim ListaTarjetas As New List(Of e_RecargaPeaje)
            ListaTarjetas.AddRange(olRecargaPeaje.Listar(oeRecargaPeaje))
            If ListaTarjetas.Count > 0 Then
                For Each _Detalle As e_RecargaPeaje In ListaTarjetas
                    _Detalle.TipoOperacion = "E"
                Next
                Return olRecargaPeaje.EditarMasivo(ListaTarjetas)
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_ValidarEliminar() As Boolean
        Try
            If griLista.ActiveRow.Cells("IdEstado").Value.ToString().Trim() = IdETerminada Then
                MessageBox.Show("No se puede eliminar el registro porque se encuentra en estado terminado", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class