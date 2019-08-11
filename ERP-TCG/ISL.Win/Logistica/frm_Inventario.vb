Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Inventario

#Region "Inicialización del formulario"

    Private Shared Instancia As frm_Inventario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_Inventario
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#End Region

#Region "Definicion de Variables"

    Dim oeCentro As New e_Centro
    Dim oeAlmacen As New e_Almacen
    Dim oeSubAlmacen As New e_SubAlmacen
    Dim oeInventario As New e_Inventario
    Dim oeDetalleInv As New e_DetalleInventario
    Dim oeRegistroInv As New e_RegistroInventario
    Dim oeInventarioValorizado As New e_InventarioValorizado
    Dim oeHistorialInventario As New e_HistorialInventario
    Dim oeHistorial As New e_Historial
    Dim olCentro As New l_Centro
    Dim olAlmacen As New l_Almacen
    Dim olSubAlmacen As New l_SubAlmacen

    Dim olInventario As New l_Inventario
    Dim olDetalleInv As New l_DetalleInventario
    Dim olRegistroInv As New l_RegistroInventario
    Dim listaInventario As New List(Of e_Inventario)

    Dim oeDetalleAsignacion As New e_DetalleAsignacion
    Dim lstDetalleAsignacion As New List(Of e_DetalleAsignacion)
    Dim olDetalleAsignacion As New l_DetalleAsignacion

    Private oeOrden As e_Orden
    Private oeRegConDisel As e_RegistroConsumoCombustible
    Private olRegConDiesel As l_RegistroConsumoCombustible
    Private olTrabajadorSeguridad As New l_TrabajadorSeguridad

    Dim dsRegistroInv As New DataSet

    'asientos contables
    Private oeAsientoModelo As e_AsientoModelo
    Private olAsientoModelo As l_AsientoModelo
    Private loAsientoModelo As List(Of e_AsientoModelo)

    Private oeReferencia As e_AsientoModelo_Referencia
    Private olReferencia As l_AsientoModelo_Referencia
    Private loReferencia As List(Of e_AsientoModelo_Referencia)

    Private dtReferencia As New DataTable

#End Region

#Region "Metodos"

    Private Sub Iniciar()
        ComboCentro()
        Mostrar_Botones()
        Dim fecha_ini, fechafin As Date
        fecha_ini = Fecha.Value
        fechafin = MesAnterior(fecha_ini)
        Me.fecha_desde.Value = fechafin
    End Sub

    'Inventario
    Private Sub ComboCentro()
        oeCentro.TipoOperacion = ""
        oeCentro.Activo = True
        LlenarComboMaestro(cboCentro, olCentro.Listar(oeCentro), 0)
        cboCentro.Value = ObtenerCentro.Id
    End Sub

    Private Sub ComboAlmacen(ByVal idCentro As String)
        Try
            Dim loSubAlmacen As New List(Of e_SubAlmacen)
            oeAlmacen.TipoOperacion = ""
            oeAlmacen.Activo = True
            oeAlmacen.IdCentro = idCentro
            LlenarComboMaestro(cboAlmacen, olAlmacen.Listar(oeAlmacen), 0)
            If cboAlmacen.Items.Count = 0 Then
                gridSubAlmacenes.DataSource = loSubAlmacen
                LimpiarListas()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LimpiaCombo(ByVal cboCombo As ISL.Controles.Combo)
        If cboCombo.Items.Count > 0 Then
            cboCombo.Items.Clear()
        End If
    End Sub

    Private Sub LimpiarListas()
        Try
            UE_DetInventario.Expanded = False
            UE_RegistroInv.Expanded = False

            gb_DetalleAsignacion.Visible = False
            gb_DetalleAsignacion.Expanded = False

            btnInventariar.Visible = False

            UE_RegistroInv.Text = "Kardex"
            gridInventario.DataSource = odInventario
            grReg_Inv.DataSource = odRegistroInventario
            grDet_Inv.DataSource = odDetInv

            If Not listaInventario Is Nothing Then listaInventario.Clear()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub InicializarColores()
        Me.ColoresMinimo.Color = Color.LightCoral
    End Sub

    Public Sub Listar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            LimpiarListas()
            oeInventario.FechaCreacion = Fecha.Value
            oeInventario.IdSubAlmacen = gridSubAlmacenes.ActiveRow.Cells("Id").Value.ToString
            oeInventario.TipoOperacion = "S"
            listaInventario = olInventario.Listar(oeInventario)
            If CheckBox2.Checked Then
                gridInventario.DataSource = listaInventario.Where(Function(i) i.CantidadFinal > 0).OrderBy(Function(item) item.Material).ToList
            Else
                gridInventario.DataSource = listaInventario.OrderBy(Function(item) item.Material).ToList
            End If
            If gridInventario.Rows.Count > 0 Then
                gridInventario.Focus()
                gridInventario.Rows.Item(0).Selected = True
                btnInventariar.Visible = True
                agrInventario.Text = "Existencias: " & cboAlmacen.Text & " - " & gridSubAlmacenes.ActiveRow.Cells("Descripcion").Value.ToString
            Else
                btnInventariar.Visible = False
                agrInventario.Text = "Existencias: "
            End If
            If Not cboAlmacen.Text.Contains("ASIGNACION") Then
                For Each fila As UltraGridRow In gridInventario.Rows
                    If fila.Cells("CantidadFinal").Value < fila.Cells("StockMin").Value Then
                        fila.Cells("CantidadFinal").Appearance.BackColor = Me.ColoresMinimo.Color
                    End If
                Next
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub ListarSubAlmacen()
        Try
            LimpiarListas()
            Me.Cursor = Cursors.WaitCursor
            oeSubAlmacen = New e_SubAlmacen
            oeSubAlmacen.IdAlmacen = cboAlmacen.Value
            oeSubAlmacen.TipoOperacion = "A"
            With gridSubAlmacenes
                If Not String.IsNullOrEmpty(oeSubAlmacen.IdAlmacen) Then
                    .DataSource = olSubAlmacen.Listar_SubAlmacen(oeSubAlmacen)
                End If
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DetalleInventario()
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim lstDetalleInv As New List(Of e_DetalleInventario)
            Dim ln_Stock As Double = 0
            oeDetalleInv = New e_DetalleInventario
            oeDetalleInv.IdMaterial = gridInventario.ActiveRow.Cells("IdMaterial").Value
            ln_Stock = gridInventario.ActiveRow.Cells("CantidadFinal").Value
            oeDetalleInv.Fecha = gridInventario.ActiveRow.Cells("FechaCreacion").Value
            oeDetalleInv.TipoOperacion = "S"
            oeDetalleInv.IdSubAlmacen = gridInventario.ActiveRow.Cells("IdSubAlmacen").Value
            With grDet_Inv
                lstDetalleInv = olDetalleInv.Listar(oeDetalleInv)
                If ln_Stock = lstDetalleInv.Sum(Function(item As e_DetalleInventario) item.Cantidad) Then
                    .DataSource = lstDetalleInv
                    .Text = "Detalle de " & gridInventario.ActiveRow.Cells("Material").Value.ToString
                    If .Rows.Count > 0 Then
                        .Focus()
                        .Rows.Item(0).Selected = True
                        UE_DetInventario.Expanded = True
                    End If
                Else
                    lstDetalleInv.Clear()
                    .Text = "Detalle de " & gridInventario.ActiveRow.Cells("Material").Value.ToString
                    .DataSource = lstDetalleInv
                    UE_DetInventario.Expanded = False
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub DetalleRegistroInv()
        Try
            If Fecha.Value.Date < fecha_desde.Value.Date Then Throw New Exception("Fecha 'Desde' debe ser menor que Fecha 'Al'")
            Dim oeMaterial As New e_Material
            Dim olMaterial As New l_Material
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            oeRegistroInv = New e_RegistroInventario
            dsRegistroInv = New DataSet
            oeRegistroInv.TipoOperacion = "S"
            oeRegistroInv.Fecha = Fecha.Value
            oeRegistroInv.IdMaterial = gridInventario.ActiveRow.Cells("IdMaterial").Value
            oeRegistroInv.IdSubAlmacen = gridInventario.ActiveRow.Cells("IdSubAlmacen").Value
            oeRegistroInv.FechaInicio = fecha_desde.Value
            dsRegistroInv = olRegistroInv.ListarStock(oeRegistroInv)

            oeMaterial.TipoOperacion = "G"
            oeMaterial.Id = oeRegistroInv.IdMaterial
            oeMaterial = olMaterial.Obtener(oeMaterial)

            Dim saldo As Double = gridInventario.ActiveRow.Cells("CantidadFinal").Value
            Dim ingreso As Double = 0
            Dim salida As Double = 0

            If dsRegistroInv.Tables.Count > 0 AndAlso dsRegistroInv.Tables(0).Rows.Count > 0 Then
                Dim i As Integer = 0
                While i <= dsRegistroInv.Tables(0).Rows.Count - 1
                    dsRegistroInv.Tables(0).Rows(i).Item("Saldo") = saldo
                    ingreso = dsRegistroInv.Tables(0).Rows(i).Item("Ingreso")
                    salida = dsRegistroInv.Tables(0).Rows(i).Item("Salida")
                    saldo = saldo - ingreso + salida
                    i = i + 1
                End While
            End If
            With grReg_Inv
                .DataSource = dsRegistroInv
                If cboAlmacen.Value = "1CH000000011" Then ' Para Almacen de Combustible
                    .DisplayLayout.Bands(0).Columns("NroOrden").Hidden = 1
                    .DisplayLayout.Bands(0).Columns("Proveedor").Hidden = 1
                    .DisplayLayout.Bands(0).Columns("Fecha").Format = "dd/MM/yyyy hh:mm tt" ''"dd/MM/yyyy h:mm tt"
                Else
                    .DisplayLayout.Bands(0).Columns("NroOrden").Hidden = 0
                    .DisplayLayout.Bands(0).Columns("Proveedor").Hidden = 0
                    .DisplayLayout.Bands(0).Columns("Fecha").Format = "dd/MM/yyyy hh:mm tt"
                End If
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").Header.Caption = "Precio Unit."
                .DisplayLayout.Bands(0).Columns("PrecioTotal").Header.Caption = "Precio Total"
                .DisplayLayout.Bands(0).Columns("CostoUnitario").Header.Caption = "Costo Unitario"
                .DisplayLayout.Bands(0).Columns("CostoTotal").Header.Caption = "Costo Total"
                .DisplayLayout.Bands(0).Columns("CostoUnitario").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("CostoTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("PrecioUnitario").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("PrecioTotal").CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                .DisplayLayout.Bands(0).Columns("Saldo").MaskInput = "{double:-9.4:c}"
            End With
            UE_RegistroInv.Text = "Kardex : " & gridInventario.ActiveRow.Cells("Material").Value.ToString & ". Ubicacion : " & Trim(gridInventario.ActiveRow.Cells("Ubicacion").Value.ToString) & ". Familia: " & oeMaterial.Familia & ". SubFamilia: " & oeMaterial.SubFamilia
            UE_RegistroInv.Expanded = True
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub MostrarOrden()
        Try
            Select Case grReg_Inv.ActiveRow.Cells("TipoMovimiento").Value
                Case "INGRESO"
                    Dim formOI As New frm_OIngreso
                    formOI.MaximizeBox = False
                    formOI.MinimizeBox = False
                    If formOI.MostrarOrden(grReg_Inv.ActiveRow.Cells("IdOrden").Value) Then
                        formOI.Size = New Size(New Point(1250, 550))
                        formOI.StartPosition = FormStartPosition.CenterScreen
                        formOI.ShowDialog()
                    End If
                Case "SALIDA"
                    Dim formOS As New frm_OSalida
                    formOS.MaximizeBox = False
                    formOS.MinimizeBox = False
                    If formOS.MostrarOrden(grReg_Inv.ActiveRow.Cells("IdOrden").Value) Then
                        formOS.Size = New Size(New Point(1250, 550))
                        formOS.StartPosition = FormStartPosition.CenterScreen
                        formOS.ShowDialog()
                    End If
            End Select

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para mostar u ocultar botones del formulario de inventario
    ''' </summary>
    ''' <param name="indicador"></param>
    ''' <remarks></remarks>
    Private Sub Mostrar_Botones(Optional indicador As Integer = 1)
        Select Case indicador
            Case 1
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Case 2
                ControlBoton(1, 0, 0, 0, 1, 0, 0, 1, 1)
        End Select
    End Sub

    'Valorizado
    Private Sub CabeceraValorizado()
        MostrarTabs(1, ficInventario, 1)
        Mostrar_Botones(2)
        Me.txtCentro.Text = Me.cboCentro.Text
        Me.txtAlmacen.Text = Me.cboAlmacen.Text
        Me.FechaValorizado.Value = Me.Fecha.Value
        Me.txtMaterial.Text = gridInventario.ActiveRow.Cells("Material").Value
        Me.txtUniMed.Text = gridInventario.ActiveRow.Cells("UnidadMedida").Value
        Me.decMin.Value = gridInventario.ActiveRow.Cells("StockMin").Value
        Me.decMax.Value = gridInventario.ActiveRow.Cells("StockMax").Value
        Me.decActual.Value = gridInventario.ActiveRow.Cells("CantidadFinal").Value
    End Sub

    Private Sub M_Peps()
        Try
            Me.Cursor = Cursors.WaitCursor
            CabeceraValorizado()
            Me.eti_TituloValorizado.Text = "Método de Valorización : PEPS"
            'Listar PEPS
            oeInventarioValorizado.IdMaterial = gridInventario.ActiveRow.Cells("IdMaterial").Value
            oeInventarioValorizado.IdSubAlmacen = gridInventario.ActiveRow.Cells("IdSubAlmacen").Value
            oeInventarioValorizado.fechaFin = Fecha.Value
            oeInventarioValorizado.tipoOperacion = "2"
            With grilla_Valorizado
                .DataSource = olInventario.Listar_Valorizado(oeInventarioValorizado)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub M_PP()
        Try
            Me.Cursor = Cursors.WaitCursor
            CabeceraValorizado()
            Me.eti_TituloValorizado.Text = "Método de Valorización : Promedio Ponderado"
            'Listar Promedio
            oeInventarioValorizado.IdMaterial = gridInventario.ActiveRow.Cells("IdMaterial").Value
            oeInventarioValorizado.IdSubAlmacen = gridInventario.ActiveRow.Cells("IdSubAlmacen").Value
            oeInventarioValorizado.fechaFin = Fecha.Value
            oeInventarioValorizado.tipoOperacion = "3"
            With grilla_Valorizado
                .DataSource = olInventario.Listar_Valorizado(oeInventarioValorizado)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    ''' <summary>
    ''' Guardar el Inventario hasta una fecha determinada
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Inventariar()

        Dim frm As New frm_HistorialInventario
        frm = frm.getInstancia()
        frm.MdiParent = frm_Menu
        frm.Fecha.Value = Me.Fecha.Value
        frm.txtCentro.Text = Me.cboCentro.Text
        frm.txtAlmacen.Text = Me.cboAlmacen.Text
        frm.txtSubAlmacen.Text = Me.gridSubAlmacenes.ActiveRow.Cells("Codigo").Value

        'oeInventario.FechaCreacion = Fecha.Value
        'oeInventario.IdSubAlmacen = gridSubAlmacenes.ActiveRow.Cells("Id").Value.ToString
        'oeInventario.TipoOperacion = "S"
        'oeInventario.Activo = ver_Activos.Checked

        frm.Inventario_Datos(listaInventario, gridSubAlmacenes.ActiveRow.Cells("Id").Value.ToString)
        frm.Nuevo()
        frm.Show()
    End Sub

    Private Sub RegenerarInventario()
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "APROBAR ORDENES DE COMPRA") Then ''And gUsuarioSGI.oeArea.Nombre = gNombreAreaLogistica
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                Dim reginv As New e_RegistroInventario
                reginv.TipoOperacion = "X"
                reginv.IdSubAlmacen = gridInventario.ActiveRow.Cells("IdSubAlmacen").Value
                reginv.IdMaterial = gridInventario.ActiveRow.Cells("IdMaterial").Value
                reginv.Fecha = Date.Parse("01/01/1901")
                olRegistroInv.Rectificar(reginv)
                Consultar(True)
            Else
                Throw New Exception("No Tiene Permisos para Regenerar Material")
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            If gridSubAlmacenes.Rows.Count > 0 Then
                Listar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Mostrar_Botones()
            MostrarTabs(0, ficInventario, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            Select Case ficInventario.SelectedTab.Index
                Case 0
                    If gridInventario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(gridInventario)
                Case 1
                    If grilla_Valorizado.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(grilla_Valorizado)
            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub cboCentro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCentro.ValueChanged
        LimpiaCombo(cboAlmacen)
        ComboAlmacen(cboCentro.Value)
    End Sub

    Private Sub cboAlmacen_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.ValueChanged
        Try
            ListarSubAlmacen()
            Mostrar_Botones()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Inventario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Mostrar_Botones()
    End Sub

    Private Sub frm_Inventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_Inventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        Iniciar()
        InicializarColores()
        AsientoContable()
    End Sub

    Private Sub frm_Inventario_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griListaSubAlmacen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridSubAlmacenes.DoubleClick
        If gridSubAlmacenes.Selected.Rows.Count > 0 Then Listar()
    End Sub

    Private Sub griListaInventario_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles gridInventario.ClickCellButton
        Try
            Select Case e.Cell.Column.Key
                Case "Editar"
                    RegenerarInventario()
                Case "CantidadFinal"
                    DetalleInventario()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaInventario_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridInventario.DoubleClick
        Try
            If gridInventario.Selected.Rows.Count > 0 Then DetalleRegistroInv()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            If gridInventario.Selected.Rows.Count > 0 Then DetalleRegistroInv()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grReg_Inv_ClickCellButton(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grReg_Inv.ClickCellButton
        'Llama a Orden
        If Not String.IsNullOrEmpty(grReg_Inv.ActiveRow.Cells("IdOrden").Value.ToString) Then
            MostrarOrden()
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        End If
    End Sub

    Private Sub griListaSubAlmacen_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridSubAlmacenes.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaInventario_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridInventario.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grDet_Inv_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grDet_Inv.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grReg_Inv_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grReg_Inv.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Try
            If listaInventario.Count > 0 Then
                If CheckBox2.Checked Then
                    gridInventario.DataSource = listaInventario.Where(Function(i) i.CantidadFinal > 0).OrderBy(Function(i) i.Material).ToList
                Else
                    gridInventario.DataSource = listaInventario.OrderBy(Function(i) i.Material).ToList
                End If
            End If
            'gridInventario.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grilla_Valorizado_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grilla_Valorizado.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub PEPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEPSToolStripMenuItem.Click
        M_Peps()
    End Sub

    Private Sub PPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPToolStripMenuItem.Click
        M_PP()
    End Sub

    Private Sub btnInventariar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventariar.Click
        Inventariar()
    End Sub

    Private Sub InventariarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventariarToolStripMenuItem.Click
        Inventariar()
    End Sub

    Private Sub grReg_Inv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grReg_Inv.DoubleClick
        Try
            If grReg_Inv.Selected.Rows.Count > 0 Then
                If grReg_Inv.ActiveRow.Cells("Descripcion").Value.ToString.Trim = "INGRESO POR ASIGNACION" Then
                    oeDetalleAsignacion.TipoOperacion = ""
                    oeDetalleAsignacion.IdRegistroInventario = grReg_Inv.ActiveRow.Cells("Id").Value.ToString
                    lstDetalleAsignacion = olDetalleAsignacion.Listar(oeDetalleAsignacion)
                    gridDetalleAsignacion.DataSource = lstDetalleAsignacion
                    gridDetalleAsignacion.Text = "N° Movimiento : " & grReg_Inv.ActiveRow.Cells("NroMovimiento").Value.ToString
                    gb_DetalleAsignacion.Visible = True
                    gb_DetalleAsignacion.Expanded = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub gridDetalleAsignacion_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles gridDetalleAsignacion.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub
    Private Sub griListaSubAlmacen_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridSubAlmacenes.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub grReg_Inv_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grReg_Inv.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub gridDetalleAsignacion_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles gridDetalleAsignacion.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub grDet_Inv_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grDet_Inv.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub grilla_Valorizado_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grilla_Valorizado.InitializeLayout
        e.Layout.Grid.CalcManager = Nothing
    End Sub

    Private Sub Fecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha.ValueChanged
        If Fecha.Value > ObtenerFechaServidor() Then
            Fecha.Value = ObtenerFechaServidor()
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Try
            If grReg_Inv.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grReg_Inv)
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Inventario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaInventario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 'Handles griListaInventario.MouseMove
        If _tiempo <= 0 Then
            If MessageBox.Show("Desea Actualizar todos los Materiales del Inventario?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = Windows.Forms.DialogResult.Yes Then
                Listar()
                InicializaTiempo()
                Mostrar_Botones()
            Else
                InicializaTiempo()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub mcDetalle_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcDetalle.Opening
        'mcDetalle.Items("PEPSToolStripMenuItem").Visible = IIf(gridInventario.Selected.Rows.Count > 0, True, False)
        mcDetalle.Items("PPToolStripMenuItem").Visible = IIf(gridInventario.Selected.Rows.Count > 0, True, False)
        mcDetalle.Items("InventariarToolStripMenuItem").Visible = IIf(gridInventario.Selected.Rows.Count > 0, True, False)
    End Sub
#End Region

#Region "Extorno y Asiento"

    Private Sub mnuRegInv_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuRegInv.Opening
        Try
            mnuRegInv.Items("ExtornoToolStripMenuItem").Enabled = False
            mnuRegInv.Items("AsientoToolStripMenuItem").Enabled = False
            If grReg_Inv.Selected.Rows.Count > 0 Then
                If grReg_Inv.ActiveRow.Cells("Ingreso").Value > 0 Then
                    mnuRegInv.Items("ExtornoToolStripMenuItem").Enabled = True
                End If
                mnuRegInv.Items("AsientoToolStripMenuItem").Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExtornoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtornoToolStripMenuItem.Click
        Try
            ExtornarIngreso(grReg_Inv.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ExtornarIngreso(Id As String)
        Try
            Dim frm As New frm_ExtornoIngreso()
            frm.Show()
            frm.Metodos(Id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AsientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsientoToolStripMenuItem.Click
        Try
            If olTrabajadorSeguridad.Permisos(gUsuarioSGI.IdTrabajador, "EXTORNAR ASIENTO") Then GenerarAsiento(grReg_Inv.ActiveRow.Cells("Id").Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GenerarAsiento(IdRegInv As String)
        Try
            oeRegistroInv = New e_RegistroInventario
            oeRegistroInv.Id = IdRegInv
            oeRegistroInv.TipoOperacion = "H"
            oeRegistroInv = olRegistroInv.ObtenerRegInv(oeRegistroInv)

            oeOrden = New e_Orden
            olRegConDiesel = New l_RegistroConsumoCombustible
            AsientoConsumo()
            If oeRegistroInv.NombreMaterial.Trim <> "" Then
                olRegConDiesel.AsientoConsumoDiesel(oeOrden, oeRegistroInv.NombreMaterial)
            End If
            mensajeEmergente.Confirmacion("Asiento Generado Correctamente", True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub AsientoConsumo()
        Try
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
            oeOrden.Total = oeRegistroInv.Cantidad * oeRegistroInv.ValorUnitario
            oeOrden.IdPeriodo = oePeriodo.Id
            oeOrden.UsuarioCreacion = gUsuarioSGI.Id
            oeOrden.FechaOrden = fechaactual
            oeOrden.TipoCambio = TipoCambio(fechaactual, True)(0)
        Catch ex As Exception
            Throw ex
        End Try
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

    Private Sub AsientoContable()
        AsientoModelo()
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

#End Region

End Class