Imports EOS.Entidades
Imports EOS.LogicaWCF
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors

Public Class frm_OrdenVenServicio
    Inherits EOS.Win.frm_FormularioPadre

#Region "Inicializacion del Formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_OrdenVenServicio = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_FormularioPadre
        If instancia Is Nothing Then
            instancia = New frm_OrdenVenServicio()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Variables"

    Private oeOrdenComercial As e_OrdenComercial
    Private olOrdenComercial As l_OrdenComercial

    Private oeOrdenComercialServicio As e_OrdenComercialServicio
    Private olOrdenComercialServicio As l_OrdenComercialServicio
    Private loOrdenComercialServicio As List(Of e_OrdenComercialServicio)

    Private oeServicio As e_Servicio
    Private olServicio As l_Servicio
    Private loServicio As List(Of e_Servicio)

    Private oeReqServicio As e_RequerimientoServicio
    Private olReqServicio As l_RequerimientoServicio
    Private loReqServicio As List(Of e_RequerimientoServicio)

    Private oeCombo As e_Combo
    Private olCombo As l_Combo
    Private loEmpresa As List(Of e_Empresa)

    Private mdblIGV As Double = gfc_ParametroValor("IGV")
    Private mdblCantidadPrecio As Double = 0

    Private oeCompra As e_Compra
    Private olCompra As l_Compra
    Private oeDocumento As e_Documento
    Private olDocumento As l_Documento
    Private oeDetDocumento As e_DetalleDocumento
    Private loDetDocumento As List(Of e_DetalleDocumento)
    Private oeOrdDocumento As e_OrdenDocumento
    Private olOrdDocumento As l_OrdenDocumento
    Private loOrdDocumento As List(Of e_OrdenDocumento)

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            mt_Listar()
            Operacion = "Inicializa"
            mt_ControlBotoneria()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            gmt_MostrarTabs(1, ficOrdenComercial, 1)
            mt_Inicializar()
            Operacion = "Nuevo"
            mt_ControlBotoneria()
            mt_ControlColumnas()
            mt_ListarRequerimientos()
            'gbeServicios.Expanded = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If griOrdenComercial.Selected.Rows.Count > 0 Then
                mt_Inicializar()
                mt_Mostrar()
                gmt_MostrarTabs(1, ficOrdenComercial, 1)
                Operacion = "Editar"
                mt_ControlBotoneria()
                mt_ControlColumnas()
                'gbeServicios.Expanded = False
                Me.lblOperacion.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If fc_Guardar() Then
                gmt_MostrarTabs(0, ficOrdenComercial, 2)
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            'Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            '    Case Windows.Forms.DialogResult.Yes
            '        Guardar()
            '    Case Windows.Forms.DialogResult.No
            gmt_MostrarTabs(0, ficOrdenComercial, 2)
            Consultar(True)
            'End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griOrdenComercial
                oeOrdenComercial = New e_OrdenComercial
                If griOrdenComercial.Selected.Rows.Count > 0 Then
                    oeOrdenComercial.Id = .ActiveRow.Cells("Id").Value
                    oeOrdenComercial = olOrdenComercial.Obtener(oeOrdenComercial)
                    If oeOrdenComercial.IdEstado = "1CIX025" Then
                        If MessageBox.Show("Esta seguro de eliminar la Orden: " & _
                                 .ActiveRow.Cells("OrdenComercial").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeOrdenComercial.TipoOperacion = "E"
                            oeOrdenComercial.UsuarioCrea = gUsuarioEOS.Nombre
                            olOrdenComercial.Eliminar(oeOrdenComercial)
                            MsgBox("La Informacion ha Sido Eliminada Correctamente", MsgBoxStyle.Information, Me.Text)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("Solo Puede Eliminar Ordenes Generadas")
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griOrdenComercial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            gmt_Exportar_Excel(griOrdenComercial, Me.Text)
            MyBase.Exportar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_OrdenVenServicio_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Try
            mt_ControlBotoneria()
            If ficOrdenComercial.Tabs(0).Selected Then
                Consultar(True)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub frm_OrdenVenServicio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_OrdenVenServicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gmt_ControlBoton()
    End Sub

    Private Sub frm_OrdenVenServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogicas()
            mt_CargarCombos()
            dtpFechaInicio.Value = Date.Now.AddDays(-20)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub mnuDetalle_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles mnuDetalle.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Agregar"
                    mt_AsignarServicio()
                Case "Quitar"
                    mt_QuitarServicio()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griServicios_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griServicios.AfterCellUpdate
        Select Case e.Cell.Column.Key
            Case "Seleccion"
                With griServicios.DisplayLayout.Bands(0).Layout.ActiveRow
                    If .Cells("Seleccion").Value Then
                        .Appearance.BackColor = Color.Yellow
                        .Appearance.ForeColor = Color.Red
                    Else
                        .Appearance.BackColor = Color.White
                        .Appearance.ForeColor = Color.Black
                    End If
                End With
        End Select
    End Sub

    Private Sub griServicios_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griServicios.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griServicios_CellChange(sender As Object, e As CellEventArgs) Handles griServicios.CellChange
        griServicios.UpdateData()
    End Sub

    Private Sub btnBuscarSer_Click(sender As Object, e As EventArgs) Handles btnBuscarSer.Click
        Try
            mt_ListarServicios()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdComSer_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griOrdComSer.AfterCellUpdate
        Try
            Dim bolIgv As Boolean
            Dim dblPrecioUnitario As Double = 0
            Dim dblCostoUnitario As Double = 0
            Dim strGlosa As String = ""
            If griOrdComSer.Rows.Count > 0 Then
                Select Case e.Cell.Column.Key
                    Case "Seleccion"
                        With griOrdComSer.Rows(e.Cell.Row.Index)
                            If .Cells("Seleccion").Value Then
                                .Appearance.BackColor = Color.Yellow
                                .Appearance.ForeColor = Color.Red
                            Else
                                .Appearance.BackColor = Color.White
                                .Appearance.ForeColor = Color.Black
                            End If
                        End With
                    Case "IndImpuesto"
                        With griOrdComSer.Rows(e.Cell.Row.Index)
                            dblCostoUnitario = 0
                            bolIgv = .Cells("IndImpuesto").Value
                            dblCostoUnitario = .Cells("CostoUnitario").Value
                            If dblCostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                            If dblCostoUnitario > 0 Then
                                dblPrecioUnitario = IIf(bolIgv, dblCostoUnitario * (mdblIGV + 1), dblCostoUnitario)
                                .Cells("PrecioUnitario").Value = dblPrecioUnitario
                            End If
                        End With
                    Case "CostoUnitario"
                        dblPrecioUnitario = 0
                        dblCostoUnitario = 0
                        With griOrdComSer.ActiveRow
                            bolIgv = .Cells("IndImpuesto").Value
                            dblCostoUnitario = .Cells("CostoUnitario").Value
                            If dblCostoUnitario = 0 Then Throw New Exception("El precio unitario sin impuesto no puede ser menor o igual a 0.")
                            If dblCostoUnitario > 0 Then
                                dblPrecioUnitario = IIf(bolIgv, dblCostoUnitario * (mdblIGV + 1), dblCostoUnitario)
                                .Cells("PrecioUnitario").Value = dblPrecioUnitario
                            End If
                            If .Cells("CostoUnitario").Value.Equals("") Then
                                .Cells("CostoUnitario").Value = 1
                            End If
                        End With
                    Case "PrecioUnitario"
                        dblPrecioUnitario = 0
                        With griOrdComSer.Rows(e.Cell.Row.Index)
                            If .Index > -1 Then
                                dblPrecioUnitario = Convert.ToDouble(.Cells("PrecioUnitario").Value)
                                If dblPrecioUnitario < 0 Then
                                    .Cells("PrecioUnitario").Value = mdblCantidadPrecio
                                    Throw New Exception("El precio unitario con impuesto no puede ser menor o igual a 0.")
                                End If
                                .Cells("PrecioTotal").Value = Math.Round(.Cells("PrecioUnitario").Value * .Cells("Cantidad").Value, 4)
                            End If
                            If .Cells("PrecioUnitario").Value.Equals("") Then
                                .Cells("PrecioUnitario").Value = 1
                            End If
                        End With
                    Case "Glosa"
                        With griOrdComSer.Rows(e.Cell.Row.Index)
                            If .Index > -1 Then
                                If IsDBNull(e.Cell.Value) Then
                                    e.Cell.Value = strGlosa
                                End If
                            End If
                        End With
                End Select
            End If
            mt_CalcularTotalOrden()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub griOrdComSer_BeforeCellUpdate(sender As Object, e As BeforeCellUpdateEventArgs) Handles griOrdComSer.BeforeCellUpdate
        Try
            With griOrdComSer
                Select Case e.Cell.Column.Key
                    Case "Cantidad", "CostoUnitario", "PrecioUnitario"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                        If IsDBNull(e.Cell.Value) Then e.Cell.Value = 0.0
                        mdblCantidadPrecio = e.Cell.Value
                    Case "Glosa"
                        If IsDBNull(e.NewValue) Then
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griOrdComSer_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOrdComSer.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdComSer_CellChange(sender As Object, e As CellEventArgs) Handles griOrdComSer.CellChange
        griOrdComSer.UpdateData()
    End Sub

    Private Sub rdbNroOrden_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNroOrden.CheckedChanged
        If rdbNroOrden.Checked Then
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtNroOrden.Focus()
        Else
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        End If
    End Sub

    Private Sub rdbDatosBasicos_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDatosBasicos.CheckedChanged
        If rdbDatosBasicos.Checked Then
            grbDatosBasicos.Enabled = True
            grbNroOrden.Enabled = False
        Else
            grbDatosBasicos.Enabled = False
            grbNroOrden.Enabled = True
            txtNroOrden.Focus()
        End If
    End Sub

    Private Sub griOrdenComercial_AfterRowActivate(sender As Object, e As EventArgs) Handles griOrdenComercial.AfterRowActivate
        btnEvaluar.Enabled = 0 : btnAtender.Enabled = 0 : btnGenerar.Enabled = 0 : btnEliminar.Enabled = 0 : btnAnular.Enabled = 0
        If griOrdenComercial.ActiveRow.Index > -1 Then
            Select Case griOrdenComercial.ActiveRow.Cells("Estado").Value
                Case "GENERADO"
                    btnEvaluar.Enabled = 1
                    btnEliminar.Enabled = 1
                Case "EVALUADO"
                    btnAtender.Enabled = 1
                    btnGenerar.Enabled = 1
                    btnAnular.Enabled = 1
                Case "ATENDIDO PARCIALMENTE"
                    btnAtender.Enabled = 1
            End Select
        End If
    End Sub

    Private Sub griOrdenComercial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griOrdenComercial.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griOrdenComercial_DoubleClick(sender As Object, e As EventArgs) Handles griOrdenComercial.DoubleClick
        Editar()
    End Sub

    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Editar()
        Operacion = "Evaluar"
        mt_ControlColumnas()
    End Sub

    Private Sub btnAtender_Click(sender As Object, e As EventArgs) Handles btnAtender.Click
        Editar()
        Operacion = "Atender"
        mt_ControlColumnas()
        mt_MenuDetalle(0, 1, 0)
        mt_ControlBotoneria()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

    End Sub


    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub txtNroOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNroOrden.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar(True)
        End If
    End Sub

    Private Sub cmbTipoPago_ValueChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.ValueChanged
        Try
            oeCombo = New e_Combo
            oeCombo.Id = cmbTipoPago.Value
            If gloTipoPago.Contains(oeCombo) Then
                oeCombo = gloTipoPago.Item(gloTipoPago.IndexOf(oeCombo))
                dtpFechaPago.Value = dtpFecha.Value.AddDays(CInt(oeCombo.Descripcion))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Me.decTipoCambio.Value = gfc_TipoCambio(dtpFecha.Value, True)
    End Sub

    Private Sub griRequerimientos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles griRequerimientos.AfterCellUpdate
        If griRequerimientos.Rows.Count > 0 Then
            Select Case e.Cell.Column.Key
                Case "Seleccion"
                    With griRequerimientos.Rows(e.Cell.Row.Index)
                        If .Cells("Seleccion").Value Then
                            .Appearance.BackColor = Color.Yellow
                            .Appearance.ForeColor = Color.Red
                        Else
                            .Appearance.BackColor = Color.White
                            .Appearance.ForeColor = Color.Black
                        End If
                    End With
            End Select
        End If
    End Sub

    Private Sub griRequerimientos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griRequerimientos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub griRequerimientos_CellChange(sender As Object, e As CellEventArgs) Handles griRequerimientos.CellChange
        griRequerimientos.UpdateData()
    End Sub

    Private Sub cmbCategoriaServicio_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategoriaServicio.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mt_ListarServicios()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub


    Private Sub cbgProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cbgProveedor.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Not String.IsNullOrEmpty(cbgProveedor.Text.Trim) Then
                    gmt_ListarEmpresa("PRO", cbgProveedor, String.Empty, cbRuc.Checked)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cbgProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbgProveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cbgProveedor.PerformAction(UltraComboAction.Dropdown)
        End If
    End Sub

    Private Sub cbDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles cbDocumento.CheckedChanged
        If cbDocumento.Checked Then
            If oeOrdenComercial.Estado = "EVALUADO" And Operacion = "Atender" Then
                grbDocAsoc.Enabled = True
                cmbTipoDocumento.Focus()
            Else
                grbDocAsoc.Enabled = False
                cbDocumento.Checked = False
            End If
        End If
    End Sub

    Private Sub txtSerie_Enter(sender As Object, e As EventArgs) Handles txtSerie.Enter
        txtSerie.Select(0, 4)
        Me.txtSerie.SelectAll()
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSerie_Validated(sender As Object, e As EventArgs) Handles txtSerie.Validated
        txtSerie.Text = gmt_FormatoDocumento(txtSerie.Text, 4)
    End Sub

    Private Sub txtNumero_Enter(sender As Object, e As EventArgs) Handles txtNumero.Enter
        txtNumero.Select(0, 10)
        Me.txtNumero.SelectAll()
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumero_Validated(sender As Object, e As EventArgs) Handles txtNumero.Validated
        txtNumero.Text = gmt_FormatoDocumento(txtNumero.Text, 10)
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_Inicializar()
        oeOrdenComercial = New e_OrdenComercial
        oeOrdenComercialServicio = New e_OrdenComercialServicio
        loOrdenComercialServicio = New List(Of e_OrdenComercialServicio)
        griOrdComSer.DataSource = loOrdenComercialServicio
        oeServicio = New e_Servicio
        loServicio = New List(Of e_Servicio)
        griServicios.DataSource = loServicio
        loEmpresa = New List(Of e_Empresa)
        cbgProveedor.DataSource = loEmpresa
        cbgProveedor.Text = String.Empty

        loReqServicio = New List(Of e_RequerimientoServicio)
        griRequerimientos.DataSource = loReqServicio
        dtpFecha.Value = Date.Now
        dtpFechaPago.Value = Date.Now
        decSubTotal.Value = 0
        decImpuesto.Value = 0
        decTotal.Value = 0
        txtOrden.Text = String.Empty
        txtEstado.Text = "POR GENERAR"
        txtGlosa.Text = String.Empty
        cmbMoneda.SelectedIndex = 0
        gbeServicios.Expanded = True
        grbDocAsoc.Enabled = False
        cbDocumento.Checked = False
        ckbCajaChica.Checked = False
        cmbTipoPago.SelectedIndex = 0

        cmbTipoDocumento.Value = -1
        txtSerie.Text = String.Empty
        txtNumero.Text = String.Empty
        txtEstadoDoc.Text = String.Empty
        dtpFechaDoc.Value = Date.Now
        mt_MenuDetalle(1, 1, 1)
        Me.decTipoCambio.Value = gfc_TipoCambio(Me.dtpFecha.Value, True)
        ficServicios.Tabs(0).Selected = True
    End Sub

    Private Sub mt_ControlBotoneria()
        Select Case ficOrdenComercial.SelectedTab.Index
            Case 0
                If griOrdenComercial.Rows.Count > 0 Then
                    gmt_ControlBoton(1, 1, 1, 0, 0, 1, 0, 1)
                Else
                    gmt_ControlBoton(1, 1)
                End If
            Case 1
                If oeOrdenComercial.Estado = "GENERADO" Or oeOrdenComercial.Estado = "" Then
                    gmt_ControlBoton(0, 0, 0, 1, 1)
                ElseIf oeOrdenComercial.Estado = "EVALUADO" Then
                    If Operacion = "Editar" Then
                        gmt_ControlBoton(0, 0, 0, 0, 1)
                    Else
                        gmt_ControlBoton(0, 0, 0, 1, 1)
                    End If
                Else
                    gmt_ControlBoton(0, 0, 0, 0, 1)
                End If
        End Select
    End Sub

    Private Sub mt_InicializarLogicas()
        olOrdenComercial = New l_OrdenComercial
        olOrdenComercialServicio = New l_OrdenComercialServicio
        olCombo = New l_Combo
        olReqServicio = New l_RequerimientoServicio
        olServicio = New l_Servicio
        olDocumento = New l_Documento
        olOrdDocumento = New l_OrdenDocumento
        olCompra = New l_Compra
    End Sub

    Private Sub mt_CargarCombos()
        Try
            Dim oeMoneda As New e_TablaDinamica_Dato
            Dim olMoneda As New l_TablaDinamica_Dato
            Dim loMoneda, loMoneda1 As New List(Of e_TablaDinamica_Dato)
            oeMoneda.TipoOperacion = "G"
            oeMoneda.Activo = True
            oeMoneda.TipoReferencia = "TipoMoneda"
            oeMoneda.IdReferencia = "NOMBRE"
            loMoneda.AddRange(olMoneda.Listar(oeMoneda))
            gmt_ComboEspecifico(cmbMoneda, loMoneda, 0, "Descripcion")
            oeMoneda = New e_TablaDinamica_Dato
            oeMoneda.Id = ""
            oeMoneda.Descripcion = "TODOS"
            loMoneda1.Add(oeMoneda)
            loMoneda1.AddRange(loMoneda)
            gmt_ComboEspecifico(cmbMonedaB, loMoneda1, 0, "Descripcion")

            Dim oeTipoPago As New e_TipoPago
            Dim olTipoPago As New l_TipoPago
            gmt_ComboEspecifico(cmbTipoPago, olTipoPago.Listar(oeTipoPago), 0)

            Dim oeCatServicio As New e_CategoriaServicio
            Dim olCatServicio As New l_CategoriaServicio
            Dim loCatServicio As New List(Of e_CategoriaServicio)
            oeCatServicio.Nombre = "TODOS"
            loCatServicio.Add(oeCatServicio)
            oeCatServicio = New e_CategoriaServicio
            oeCatServicio.IdEmpresaSis = gstrIdEmpresaSis
            oeCatServicio.IdSucursal = gstrIdSucursal
            loCatServicio.AddRange(olCatServicio.Listar(oeCatServicio))
            gmt_ComboEspecifico(cmbCategoriaServicio, loCatServicio, 0)

            Dim oeTipoDoc As New e_TipoDocumento
            Dim olTipoDoc As New l_TipoDocumento
            Dim loTipoDoc As New List(Of e_TipoDocumento)
            oeTipoDoc.TipoOperacion = "C"
            loTipoDoc.AddRange(olTipoDoc.Listar(oeTipoDoc))
            gmt_ComboEspecifico(cmbTipoDocumento, loTipoDoc, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Listar()
        Try
            oeOrdenComercial = New e_OrdenComercial
            oeOrdenComercial.IdEmpresaSis = gstrIdEmpresaSis
            oeOrdenComercial.IdSucursal = gstrIdSucursal
            oeOrdenComercial.Tipo = 1
            oeOrdenComercial.TipoExistencia = 2
            If rdbDatosBasicos.Checked Then
                oeOrdenComercial.IdEmpresa = cbgProveedorB.Value
                oeOrdenComercial.IdEstado = cboEstado.Value
                oeOrdenComercial.Fecha = dtpFechaInicio.Value
                oeOrdenComercial.FechaCrea = dtpFechaFin.Value
            Else
                oeOrdenComercial.OrdenComercial = txtNroOrden.Text
            End If
            griOrdenComercial.DataSource = olOrdenComercial.Listar(oeOrdenComercial)
            For Each fila As UltraGridRow In griOrdenComercial.Rows
                Select Case fila.Cells("Estado").Value
                    Case "GENERADO"
                        fila.CellAppearance.BackColor = Me.colorGenerado.Color
                    Case "EVALUADO"
                        fila.CellAppearance.BackColor = Me.colorEvaluado.Color
                    Case "ATENDIDO PARCIALMENTE"
                        fila.CellAppearance.BackColor = Me.colorParcial.Color
                    Case "ATENDIDO"
                        fila.CellAppearance.BackColor = Me.colorAtendido.Color
                    Case "ANULADO"
                        fila.CellAppearance.BackColor = Me.colorAnulado.Color
                    Case "TERMINADO"
                        fila.CellAppearance.BackColor = Me.colorTerminado.Color
                End Select
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_Mostrar()
        Try
            oeOrdenComercial.Id = griOrdenComercial.ActiveRow.Cells("Id").Value
            oeOrdenComercial = olOrdenComercial.Obtener(oeOrdenComercial)
            With oeOrdenComercial
                gmt_ListarEmpresa("PRO", cbgProveedor, .IdEmpresa, False)
                cbgProveedor.Value = .IdEmpresa
                cmbMoneda.Value = .IdMoneda
                cmbTipoPago.Value = .IdTipoPago
                txtOrden.Text = .OrdenComercial
                txtEstado.Text = .Estado
                txtGlosa.Text = .Glosa
                decTipoCambio.Value = .TipoCambio
                decSubTotal.Value = .SubTotal
                decImpuesto.Value = .Impuesto
                decTotal.Value = .Total
            End With
            oeOrdenComercialServicio = New e_OrdenComercialServicio
            oeOrdenComercialServicio.IdOrdenComercial = oeOrdenComercial.Id
            loOrdenComercialServicio.AddRange(olOrdenComercialServicio.Listar(oeOrdenComercialServicio))
            griOrdComSer.DataSource = loOrdenComercialServicio

            oeOrdDocumento = New e_OrdenDocumento
            oeOrdDocumento.IdOrden = oeOrdenComercial.Id
            oeOrdDocumento.TipoOrden = 2
            oeOrdDocumento = olOrdDocumento.Obtener(oeOrdDocumento)

            If oeOrdDocumento.Id <> "" Then
                oeDocumento = New e_Documento
                oeDocumento.Id = oeOrdDocumento.IdDocumento
                oeDocumento = olDocumento.Obtener(oeDocumento)
                cmbTipoDocumento.Value = oeDocumento.IdTipoDocumento
                txtSerie.Text = oeDocumento.Serie
                txtNumero.Text = oeDocumento.Numero
                txtEstadoDoc.Text = oeDocumento.Estado

                oeCompra = New e_Compra
                oeCompra.IdDocumento = oeDocumento.Id
                oeCompra = olCompra.Obtener(oeCompra)
                ckbCajaChica.Checked = oeCompra.IndCajaChica
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_Guardar() As Boolean
        Try
            mt_LlenaObjeto()
            If olOrdenComercial.Guardar(oeOrdenComercial) Then
                MsgBox("La Informacion ha Sido Guardada Correctamente", MsgBoxStyle.Information, Me.Text)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub mt_LlenaObjeto()
        Try
            With oeOrdenComercial
                .IdEmpresaSis = gstrIdEmpresaSis
                .IdSucursal = gstrIdSucursal
                .UsuarioCrea = gUsuarioEOS.Nombre
                .Tipo = 1
                .TipoExistencia = 2
                .TipoCambio = decTipoCambio.Value
                Select Case Operacion
                    Case "Nuevo"
                        .TipoOperacion = "I"
                        .IdEstado = "1CIX025"
                    Case "Editar"
                        .TipoOperacion = "A"
                    Case "Evaluar"
                        .TipoOperacion = "P"
                        .IdEstado = "1CIX022"
                        .IdTrabajadorAprobacion = gUsuarioEOS.oePersona.Id
                    Case "Atender"
                        .TipoOperacion = "T"
                        If cbDocumento.Checked Then
                            mt_GeneraDocumento()
                            .oeDocumento = oeDocumento
                        Else
                            Throw New Exception("Debe Generar un Documento para Guardar la Orden")
                        End If
                End Select
                .lstOrdenComercialServicio = New List(Of e_OrdenComercialServicio)
                .lstOrdenComercialServicio.AddRange(loOrdenComercialServicio)
                .Fecha = dtpFecha.Value
                .IdMoneda = cmbMoneda.Value
                If cbgProveedor.Value <> "" Then .IdEmpresa = IIf(gfc_ValidarEmpresa(cbgProveedor.Value), cbgProveedor.Value, "")
                .IdTipoPago = cmbTipoPago.Value
                .Glosa = txtGlosa.Text
                .Total = decTotal.Value
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .TipoCompra = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_GeneraDocumento()
        Try
            oeDocumento = New e_Documento
            With oeDocumento
                .TipoOperacion = "I"
                .IdEmpresaSis = gstrIdEmpresaSis
                .IdSucursal = gstrIdSucursal
                .IdClienteProveedor = oeOrdenComercial.IdEmpresa
                .IdTipoDocumento = cmbTipoDocumento.Value

                .IdEstado = "1CIX020"
                .IdPeriodo = ""
                .CuentaContable = ""
                .IdMoneda = cmbMoneda.Value
                .Tipo = 1
                .TipoExistencia = 2
                If txtSerie.Text <> "" Then .Serie = gmt_FormatoDocumento(txtSerie.Text, 4)
                If txtNumero.Text <> "" Then .Numero = gmt_FormatoDocumento(txtNumero.Text, 10)
                If CInt(.Serie) = 0 Then Throw New Exception("Serie no Puede ser 0. Verificar")
                If CInt(.Numero) = 0 Then Throw New Exception("Numero no Puede ser 0. Verificar")
                .FechaEmision = dtpFechaDoc.Value
                .FechaVencimiento = dtpFechaPago.Value
                .NoGravadas = 0
                .SubTotal = decSubTotal.Value
                .Impuesto = decImpuesto.Value
                .Total = decTotal.Value
                .Saldo = .Total
                .UsuarioCrea = gUsuarioEOS.Nombre
                .lstDetalleDocumento = New List(Of e_DetalleDocumento)
                .lstDetalleDocumento = fc_DetalleDoc()
                .lstOrdenDocumento = New List(Of e_OrdenDocumento)
                .lstOrdenDocumento = fc_OrdDocumento()
                .oeCompra = New e_Compra
                .oeCompra = fc_LlenarCompra()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_DetalleDoc() As List(Of e_DetalleDocumento)
        Try
            loDetDocumento = New List(Of e_DetalleDocumento)
            For Each oe As e_OrdenComercialServicio In loOrdenComercialServicio
                oeDetDocumento = New e_DetalleDocumento
                With oeDetDocumento
                    .TipoOperacion = "I"
                    .IdEmpresaSis = gstrIdEmpresaSis
                    .IdSucursal = gstrIdSucursal
                    .IdMaterialServicio = oe.IdServicio
                    .Codigo = oe.Codigo
                    .Cantidad = oe.Cantidad
                    .IndImpuesto = oe.IndImpuesto
                    .Tipo = 2
                    .PrecioUnitario = oe.PrecioUnitario
                    .PrecioTotal = oe.PrecioTotal
                    .CostoUnitario = IIf(oe.IndImpuesto, Math.Round(oe.PrecioUnitario / (1 + mdblIGV), 4, MidpointRounding.AwayFromZero), oe.PrecioUnitario)
                    .UsuarioCrea = gUsuarioEOS.Nombre
                End With
                loDetDocumento.Add(oeDetDocumento)
            Next
            Return loDetDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_OrdDocumento() As List(Of e_OrdenDocumento)
        Try
            oeOrdDocumento = New e_OrdenDocumento
            loOrdDocumento = New List(Of e_OrdenDocumento)
            With oeOrdDocumento
                .IdOrden = oeOrdenComercial.Id
                .TipoOrden = 2
                .TipoOperacion = "I"
                .TipoExistencia = 2
                .UsuarioCrea = gUsuarioEOS.Nombre
                loOrdDocumento.Add(oeOrdDocumento)
            End With
            Return loOrdDocumento
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fc_LlenarCompra() As e_Compra
        Try
            oeCompra = New e_Compra
            With oeCompra
                .IdEmpresaSis = gstrIdEmpresaSis
                .IdSucursal = gstrIdSucursal
                .Base1 = decSubTotal.Value
                .Impuesto1 = decImpuesto.Value
                .IdTipoPago = cmbTipoPago.Value
                .IndCajaChica = ckbCajaChica.Checked
                '.Percepcion = decPercepcion.Value
                '.PorcPercepcion = decPorcPercp.Value
                '.Detraccion = decDetraccion.Value
                '.PorcDetraccion = decPorcDetra.Value
                .Glosa = txtGlosa.Text
                .UsuarioCrea = gUsuarioEOS.Nombre
                .TipoOperacion = "I"
            End With
            Return oeCompra
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Function fc_ValidarDetalles As 

    Private Sub mt_ListarServicios()
        Try
            oeServicio = New e_Servicio
            loServicio = New List(Of e_Servicio)
            oeServicio.IdCategoriaServicio = cmbCategoriaServicio.Value
            loServicio.AddRange(olServicio.Listar(oeServicio))
            griServicios.DataSource = loServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_AsignarServicio()
        Try
            Select Case ficServicios.SelectedTab.Index
                Case 0
                    For Each oe As e_RequerimientoServicio In loReqServicio.Where(Function(i) i.Seleccion = True).ToList
                        oeOrdenComercialServicio = New e_OrdenComercialServicio
                        With oeOrdenComercialServicio
                            oe.Seleccion = False
                            .TipoOperacion = "I"
                            .IdRequerimientoServicio = oe.Id
                            .IndImpuesto = True
                            .IdEmpresaSis = gstrIdEmpresaSis
                            .IdSucursal = gstrIdSucursal
                            .UsuarioCrea = gUsuarioEOS.Nombre
                            .IdServicio = oe.IdServicio
                            .Servicio = oe.Servicio
                            .Codigo = oe.Codigo
                            .Cantidad = 1
                            .CostoUnitario = 0
                            .PrecioUnitario = 0
                            .PrecioTotal = 0
                        End With
                        If loOrdenComercialServicio.Where(Function(i) i.IdServicio = oeOrdenComercialServicio.IdServicio And i.TipoOperacion <> "E").ToList.Count > 0 Then
                            griOrdComSer.DataBind()
                            mt_CalcularTotalOrden()
                            Throw New Exception("Servicio: " & oeOrdenComercialServicio.Servicio & " ya Asignado a la Orden")
                        End If
                        loOrdenComercialServicio.Add(oeOrdenComercialServicio)
                    Next
                    griRequerimientos.DataBind()
                Case 1
                    For Each oe As e_Servicio In loServicio.Where(Function(i) i.Seleccion = True).ToList
                        oeOrdenComercialServicio = New e_OrdenComercialServicio
                        With oeOrdenComercialServicio
                            oe.Seleccion = False
                            .TipoOperacion = "I"
                            .IndImpuesto = True
                            .IdEmpresaSis = gstrIdEmpresaSis
                            .IdSucursal = gstrIdSucursal
                            .UsuarioCrea = gUsuarioEOS.Nombre
                            .IdServicio = oe.Id
                            .Servicio = oe.Nombre
                            .Codigo = oe.Codigo
                            .Cantidad = 1
                            .CostoUnitario = 0
                            .PrecioUnitario = 0
                            .PrecioTotal = Math.Round(.PrecioUnitario * .Cantidad, 4)
                        End With
                        If loOrdenComercialServicio.Where(Function(i) i.IdServicio = oeOrdenComercialServicio.IdServicio And i.TipoOperacion <> "E").ToList.Count > 0 Then
                            griOrdComSer.DataBind()
                            mt_CalcularTotalOrden()
                            Throw New Exception("Material: " & oeOrdenComercialServicio.Servicio & " ya Asignado a la Orden")
                        End If
                        loOrdenComercialServicio.Add(oeOrdenComercialServicio)
                    Next
                    griServicios.DataBind()
            End Select
            griOrdComSer.DataBind()
            mt_CalcularTotalOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub mt_QuitarServicio()
        Try
            If griOrdComSer.Selected.Rows.Count > 0 Then
                oeOrdenComercialServicio = New e_OrdenComercialServicio
                oeOrdenComercialServicio = griOrdComSer.ActiveRow.ListObject
                If oeOrdenComercialServicio.TipoOperacion = "I" Then
                    loOrdenComercialServicio.Remove(oeOrdenComercialServicio)
                Else
                    oeOrdenComercialServicio.TipoOperacion = "E"
                    griOrdComSer.ActiveRow.Hidden = True
                End If
            End If
            griOrdComSer.DataBind()
            mt_CalcularTotalOrden()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CalcularTotalOrden()
        Try
            Dim bolIndicador As Boolean = False
            Dim dblTotalOrden As Double = 0
            For Each oe As e_OrdenComercialServicio In loOrdenComercialServicio.Where(Function(i) i.TipoOperacion <> "E").ToList
                dblTotalOrden += oe.PrecioTotal
                If oe.IndImpuesto Then
                    bolIndicador = True
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario / (1 + mdblIGV), 4)
                Else
                    oe.CostoUnitario = Math.Round(oe.PrecioUnitario, 4, MidpointRounding.AwayFromZero)
                End If
            Next
            decTotal.Value = Math.Round(dblTotalOrden, 4)
            If bolIndicador Then
                decSubTotal.Value = Math.Round(dblTotalOrden / (1 + mdblIGV), 4)
                decImpuesto.Value = decTotal.Value - decSubTotal.Value
            Else
                decImpuesto.Value = 0
                decSubTotal.Value = decTotal.Value
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fc_ValidarGenDoc() As Boolean
        Try

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub mt_MenuDetalle(AgregarQuitar As Boolean, Generar As Boolean, Servicio As Boolean)
        Try
            mnuDetalle.Tools("Agregar").SharedProps.Enabled = AgregarQuitar
            mnuDetalle.Tools("Quitar").SharedProps.Enabled = AgregarQuitar
            gbeServicios.Visible = Servicio
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ControlColumnas()
        With griOrdComSer.DisplayLayout.Bands(0)
            Select Case oeOrdenComercial.Estado
                Case "", "GENERADO"
                    If Operacion = "Evaluar" Then
                        Me.lblOperacion.Text = "EVALUANDO OC"
                        .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                        .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                        mt_MenuDetalle(0, 0, 0)
                    Else
                        Me.lblOperacion.Text = "GENERANDO OC"
                        .Columns("IndImpuesto").CellActivation = Activation.AllowEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.Edit
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Always
                        .Columns("CostoUnitario").CellActivation = Activation.AllowEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.EditAndSelectText
                        .Columns("PrecioUnitario").CellActivation = Activation.AllowEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.EditAndSelectText
                        mt_MenuDetalle(1, 0, 1)
                    End If
                Case "EVALUADO", "ATENDIDO PARCIALMENTE"
                    If Operacion = "Atender" Then
                        Me.lblOperacion.Text = "ATENDIENDO OC"
                        .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                        .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    Else
                        Me.lblOperacion.Text = ""
                        .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                        .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                        .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                        .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                        .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                        .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                        .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                        mt_MenuDetalle(0, 0, 0)
                    End If
                Case "ATENDIDO"
                    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                    .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                    .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    mt_MenuDetalle(0, 0, 0)
                Case "TERMINADO"
                    Me.lblOperacion.Text = ""
                    .Columns("IndImpuesto").CellActivation = Activation.NoEdit
                    .Columns("IndImpuesto").CellClickAction = CellClickAction.RowSelect
                    .Columns("IndImpuesto").Header.CheckBoxVisibility = HeaderCheckBoxVisibility.Never
                    .Columns("CostoUnitario").CellActivation = Activation.NoEdit
                    .Columns("CostoUnitario").CellClickAction = CellClickAction.RowSelect
                    .Columns("PrecioUnitario").CellActivation = Activation.NoEdit
                    .Columns("PrecioUnitario").CellClickAction = CellClickAction.RowSelect
                    mt_MenuDetalle(0, 0, 0)
            End Select
        End With
    End Sub

    Public Sub mt_ListarRequerimientos()
        Try
            oeReqServicio = New e_RequerimientoServicio
            loReqServicio = New List(Of e_RequerimientoServicio)
            oeReqServicio.TipoOperacion = "1"
            loReqServicio.AddRange(olReqServicio.Listar(oeReqServicio))
            griRequerimientos.DataSource = loReqServicio
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class