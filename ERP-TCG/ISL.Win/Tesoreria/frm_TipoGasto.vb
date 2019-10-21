'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports ISL.Controles
Public Class frm_TipoGasto
    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Private Shared Instancia As frm_TipoGasto = Nothing
    Private Shared Operacion As String
    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_TipoGasto()
        End If
        Instancia.Activate()
        Return Instancia
    End Function

#Region "Declaración de variables"
    Dim oeTipoGasto As New e_TipoGasto
    Dim olTipoGasto As New l_TipoGasto
    Dim oeFlujoGasto As New e_FlujoCaja
    Dim olFlujoGasto As New l_FlujoCaja
    Dim oeTipoGastoDetalle As New e_TipoGastoDetalle
    Dim olTipoGastoDetalle As New l_TipoGastoDetalle
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griListaTipoGasto.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        LimpiaGrid(griFlujoGasto, orgDetalleFlujo)
        verActivo.Visible = False
        oeTipoGasto.TipoOperacion = "I"
        'oeTipoGasto.Id = ""
        MostrarTabs(1, tcTipoGasto, 1)
        Inicializar()
        txtCodigo.Focus()
        InicializarGrilla()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        MostrarTipoGasto()
        oeTipoGasto.TipoOperacion = "I"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarTipoGasto() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcTipoGasto, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoGasto.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarTipoGasto() Then
                            MostrarTabs(0, tcTipoGasto, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcTipoGasto, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcTipoGasto, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, tcTipoGasto, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griListaTipoGasto
                If ValidarGrilla(griListaTipoGasto, "Tipo Gasto") Then
                    oeTipoGasto.Id = .ActiveRow.Cells("ID").Value
                    oeTipoGasto = olTipoGasto.Obtener(oeTipoGasto)
                    If oeTipoGasto.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Tipo de Gasto: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTipoGasto.TipoOperacion = "E"
                            olTipoGasto.Eliminar(oeTipoGasto)
                            Inicializar()
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If tcTipoGasto.Tabs(0).Selected AndAlso griListaTipoGasto.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If tcTipoGasto.Tabs(0).Selected Then Exportar_Excel(griListaTipoGasto)

            If tcTipoGasto.Tabs(1).Selected AndAlso griFlujoGasto.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            If tcTipoGasto.Tabs(1).Selected Then Exportar_Excel(griFlujoGasto)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
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

    Private Sub frm_TipoGasto_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_TipoGasto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub frm_TipoGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, tcTipoGasto)
        griListaTipoGasto.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griListaTipoGasto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        LlenaCombos()
        oeTipoGasto.Usuario = gUsuarioSGI.Id
    End Sub

    Private Sub LlenaCombos()
        'oeFlujoGasto.TipoOperacion = ""
        'oeFlujoGasto.Activo = True
        'LlenarComboMaestro(cboFlujoGasto, olFlujoGasto.Listar(oeFlujoGasto), -1)
        oeFlujoGasto.TipoOperacion = "P"
        oeFlujoGasto.NombProceso = "Tesoreria"
        LlenarComboMaestro(cboFlujoGasto, olFlujoGasto.Listar(oeFlujoGasto), -1)
    End Sub

    Private Sub griListaTipoGasto_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griListaTipoGasto.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griListaTipoGasto_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griListaTipoGasto.DoubleClick
        If griListaTipoGasto.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeTipoGasto.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeTipoGasto.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeTipoGasto.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoGasto.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeTipoGasto.Modificado = True
    End Sub

    Private Sub griListaTipoGasto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griListaTipoGasto.KeyDown
        TeclaPulsada(e)
    End Sub


    Private Sub InicializarGrilla()
        With griFlujoGasto
            .DisplayLayout.Bands(0).Columns("Id").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdTipoGasto").Hidden = True
            .DisplayLayout.Bands(0).Columns("IdFlujoCaja").Hidden = True
            .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
        End With
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        AgregaDetalle()
        InicializarDetalle()
    End Sub

    Private Sub InicializarDetalle()
        cboFlujoGasto.SelectedIndex = -1
    End Sub

    Private Sub griFlujoGasto_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griFlujoGasto.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NuevoContext()
        If MenuContextual1.SourceControl Is griListaTipoGasto Then
            Nuevo()
        End If
    End Sub

    Private Sub EliminarContext()
        If MenuContextual1.SourceControl Is griListaTipoGasto Then
            Eliminar()
        ElseIf MenuContextual1.SourceControl Is griFlujoGasto Then
            Quitar(griFlujoGasto)
        End If
    End Sub

    'Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
    '    MenuContextual1.Items(0).Visible = True
    '    MenuContextual1.Items(1).Visible = True
    '    If MenuContextual1.SourceControl Is griListaTipoGasto Then
    '        If griListaTipoGasto.Rows.Count = 0 Then
    '            MenuContextual1.Items(1).Visible = False
    '        End If
    '    ElseIf MenuContextual1.SourceControl Is griFlujoGasto Then
    '        If griFlujoGasto.Rows.Count > 0 Then
    '            MenuContextual1.Items(0).Visible = False
    '        Else
    '            MenuContextual1.Items(0).Visible = False
    '            MenuContextual1.Items(1).Visible = False
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Métodos"

    Private Sub Quitar(ByVal Migrilla As Grilla)
        Try
            If Migrilla.Rows.Count > 0 Then
                Migrilla.ActiveRow.Delete()
                Migrilla.Select()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Agregas the detalle.
    ''' </summary>
    Private Sub AgregaDetalle()
        Try
            If ValidarCombo(cboFlujoGasto, "Flujo Caja") Then
                Select Case _Operacion
                    Case "Nuevo"
                        Dim Fila As Integer
                        griFlujoGasto.DisplayLayout.Bands(0).AddNew()
                        Fila = griFlujoGasto.Rows.Count - 1
                        With griFlujoGasto.Rows(Fila)
                            .Cells("Id").Value = ""
                            .Cells("IdFlujoCaja").Value = cboFlujoGasto.Value
                            .Cells("FlujoCaja").Value = cboFlujoGasto.Text.ToString
                            .Cells("IdTipoGasto").Value = ""
                            .Cells("Activo").Value = True
                        End With
                    Case "Editar"
                        oeTipoGastoDetalle = New e_TipoGastoDetalle
                        oeTipoGasto.oeTipoGastoDetalle = griFlujoGasto.DataSource
                        oeTipoGastoDetalle.Id = ""
                        oeTipoGastoDetalle.IdTipoGasto = ""
                        oeTipoGastoDetalle.IdFlujoCaja = cboFlujoGasto.Value
                        oeTipoGastoDetalle.FlujoCaja = cboFlujoGasto.Text.ToString
                        oeTipoGastoDetalle.Activo = True
                        oeTipoGasto.oeTipoGastoDetalle.Add(oeTipoGastoDetalle)
                        griFlujoGasto.DataBind()
                End Select
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeTipoGasto = New e_TipoGasto
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            oeTipoGasto.Activo = Activo
            Dim ds As DataSet = olTipoGasto.Listar(oeTipoGasto)
            ' If ds.Tables(0).Rows.Count > 0 And ds.Tables(1).Rows.Count > 0 Then
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdTipoGasto")
            Dim relation As DataRelation = New DataRelation("FK_RelacionTipoGasto", parentCol, childCol, True)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            griListaTipoGasto.DataSource = ds
            Me.Cursor = Cursors.WaitCursor

            With griListaTipoGasto
                ' oeTipoGasto.Activo = Activo
                '.DataSource = olTipoGasto.Listar(oeTipoGasto)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                '.DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True
                .DisplayLayout.Bands(1).Columns("Id").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdTipoGasto").Hidden = True
                .DisplayLayout.Bands(1).Columns("IdFlujoCaja").Hidden = True
                .DisplayLayout.Bands(1).Columns("Activo").Hidden = True
                .DisplayLayout.Bands(1).Columns("FlujoCaja").Width = 250
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griListaTipoGasto.Focus()
    End Sub

    Private Function GuardarTipoGasto() As Boolean
        Try
            oeTipoGasto.Activo = True
            oeTipoGasto.Usuario = gUsuarioSGI.Id
            oeTipoGasto.oeTipoGastoDetalle = New List(Of e_TipoGastoDetalle)
            For I As Integer = 0 To griFlujoGasto.Rows.Count - 1
                Dim oeTipoGastoDetalle As New e_TipoGastoDetalle
                oeTipoGastoDetalle.IdFlujoCaja = griFlujoGasto.Rows(I).Cells("IdFlujoCaja").Value
                oeTipoGastoDetalle.FlujoCaja = griFlujoGasto.Rows(I).Cells("FlujoCaja").Value
                oeTipoGastoDetalle.Id = griFlujoGasto.Rows(I).Cells("Id").Value
                oeTipoGastoDetalle.IdTipoGasto = griFlujoGasto.Rows(I).Cells("IdTipoGasto").Value
                oeTipoGastoDetalle.Activo = True
                oeTipoGastoDetalle.PrefijoID = gs_PrefijoIdSucursal '@0001
                oeTipoGasto.oeTipoGastoDetalle.Add(oeTipoGastoDetalle)
                oeTipoGastoDetalle = Nothing
            Next
            oeTipoGasto.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olTipoGasto.Guardar(oeTipoGasto) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, tcTipoGasto, 2)
            Inicializar()
            Consultar(True)
            griListaTipoGasto.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
        If excepcion.Contains("abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

    Private Sub Inicializar()
        oeTipoGasto.Id = String.Empty
        oeTipoGasto.Codigo = String.Empty
        oeTipoGasto.Nombre = String.Empty
        oeTipoGasto.Abreviatura = String.Empty
        oeTipoGasto.Activo = _Activo
        txtCodigo.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        With oeTipoGasto
            .oeTipoGastoDetalle.Clear()
        End With
    End Sub

    Private Sub MostrarTipoGasto()
        LimpiaGrid(griFlujoGasto, orgDetalleFlujo)
        LlenaCombos()
        Try
            If griListaTipoGasto.ActiveRow.Cells("ID").Value.ToString.Length > 0 Then
                verActivo.Visible = True
                Inicializar()
                oeTipoGasto.Id = griListaTipoGasto.ActiveRow.Cells("Id").Value.ToString
                oeTipoGasto = olTipoGasto.Obtener(oeTipoGasto)
                txtCodigo.Text = oeTipoGasto.Codigo
                txtNombre.Text = oeTipoGasto.Nombre
                txtAbreviatura.Text = oeTipoGasto.Abreviatura
                verActivo.Checked = oeTipoGasto.Activo
                oeTipoGastoDetalle.IdTipoGasto = oeTipoGasto.Id
                oeTipoGastoDetalle.Activo = True
                griFlujoGasto.DataSource = olTipoGasto.ListarDetalle(oeTipoGastoDetalle)
                InicializarGrilla()
                MostrarTabs(1, tcTipoGasto, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griListaTipoGasto_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griListaTipoGasto.InitializeLayout
        agrTotalTipoGasto.Text = "Total Tipo Gasto: " & e.Layout.Rows.Count & Estado
    End Sub


#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoGasto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griListaTipoGasto_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griListaTipoGasto.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de flujo de gastos"

    Private Sub AsociarMenu()
        griListaTipoGasto.ContextMenuStrip = MenuContextual1
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
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griListaTipoGasto.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#Region "Menú contextual del detalle Flujo de gastos"

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        'Listar()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        AgregaDetalle()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        MostrarTipoGasto()
    End Sub

    Private Sub QuitarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarToolStripMenuItem.Click

    End Sub

    Private Sub mcFlujoGasto_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcFlujoGasto.Opening
        mcFlujoGasto.Items(0).Visible = True
        mcFlujoGasto.Items(1).Visible = True
        If griFlujoGasto.Selected.Rows.Count > 0 Then
            mcFlujoGasto.Items(2).Visible = True
            mcFlujoGasto.Items(3).Visible = True
        Else
            mcFlujoGasto.Items(2).Visible = False
            mcFlujoGasto.Items(3).Visible = False
        End If
    End Sub

#End Region

#End Region

End Class