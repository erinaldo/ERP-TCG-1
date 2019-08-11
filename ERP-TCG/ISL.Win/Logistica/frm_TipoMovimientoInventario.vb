Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_TipoMovimientoInventario
    Inherits ISL.Win.frm_MenuPadre

    Dim olTipoMovimientoInventario As New l_TipoMovimientoInventario
    Dim oeTipoMovimientoInventario As New e_TipoMovimientoInventario
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_TipoMovimientoInventario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoMovimientoInventario
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griTipoMovimientoInventario.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        verActivo.Visible = False
        oeTipoMovimientoInventario.TipoOperacion = "I"
        MostrarTabs(1, ficTipoMovimientoInventario, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        verActivo.Visible = True
        Mostrar()
        oeTipoMovimientoInventario.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficTipoMovimientoInventario, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoMovimientoInventario.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficTipoMovimientoInventario, 2)
                            _ingresando_datos = False
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTipoMovimientoInventario, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTipoMovimientoInventario, 2)
                        _ingresando_datos = False
                        Operacion = "Iniciliza"
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, ficTipoMovimientoInventario, 2)
                _ingresando_datos = False
                Operacion = "Iniciliza"
                MyBase.Consultar(True)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griTipoMovimientoInventario
                If ValidarGrilla(griTipoMovimientoInventario, "TipoMovimientoInventario") Then
                    oeTipoMovimientoInventario.Id = .ActiveRow.Cells("ID").Value
                    oeTipoMovimientoInventario = olTipoMovimientoInventario.Obtener(oeTipoMovimientoInventario)
                    If oeTipoMovimientoInventario.Activo Then
                        If MessageBox.Show("Desea eliminar el Tipo de Movimiento de Inventario: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTipoMovimientoInventario.TipoOperacion = "E"
                            olTipoMovimientoInventario.Eliminar(oeTipoMovimientoInventario)
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

            If griTipoMovimientoInventario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTipoMovimientoInventario)

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
    Private Sub frm_TipoMovimientoInventario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficTipoMovimientoInventario)
        griTipoMovimientoInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griTipoMovimientoInventario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub frm_TipoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TipoMovimientoInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

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

    Private Sub Mostrar()
        Try
            If griTipoMovimientoInventario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoMovimientoInventario.Id = griTipoMovimientoInventario.ActiveRow.Cells("Id").Value.ToString
                oeTipoMovimientoInventario = olTipoMovimientoInventario.Obtener(oeTipoMovimientoInventario)
                txtId.Text = oeTipoMovimientoInventario.Id
                txtCodigo.Text = oeTipoMovimientoInventario.Codigo
                txtNombre.Text = oeTipoMovimientoInventario.Nombre
                txtAbreviatura.Text = oeTipoMovimientoInventario.Abreviatura
                verActivo.Checked = oeTipoMovimientoInventario.Activo
                MostrarTabs(1, ficTipoMovimientoInventario, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            If Not olTipoMovimientoInventario.Guardar(oeTipoMovimientoInventario) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficTipoMovimientoInventario, 2)
            Consultar(True)
            griTipoMovimientoInventario.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeTipoMovimientoInventario = New e_TipoMovimientoInventario
            With griTipoMovimientoInventario
                oeTipoMovimientoInventario.Activo = Activo
                .DataSource = olTipoMovimientoInventario.Listar(oeTipoMovimientoInventario)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                .DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                .DisplayLayout.Bands(0).Columns("Abreviatura").Hidden = False
                .DisplayLayout.Bands(0).Columns("Modificado").Hidden = True
                .DisplayLayout.Bands(0).Columns("TipoOperacion").Hidden = True

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

    End Sub

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtAbreviatura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.GotFocus
        txtAbreviatura.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAbreviatura.KeyDown
        TeclaPulsada(e)
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeTipoMovimientoInventario.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeTipoMovimientoInventario.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        txtAbreviatura.Text = LTrim(txtAbreviatura.Text)
        oeTipoMovimientoInventario.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeTipoMovimientoInventario.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeTipoMovimientoInventario.Modificado = True
    End Sub

    Private Sub griTipoMovimientoInventario_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griTipoMovimientoInventario.InitializeLayout
        agrLista.Text = "Total de Tipos de Mov. de Inventario: " & e.Layout.Rows.Count
    End Sub

    Private Sub griTipoMovimientoInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griTipoMovimientoInventario.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griTipoMovimientoInventario_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTipoMovimientoInventario.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griTipoMovimientoInventario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTipoMovimientoInventario.DoubleClick
        If griTipoMovimientoInventario.Selected.Rows.Count > 0 Then Editar()
    End Sub

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoMovimientoInventario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTipoMovimientoInventario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTipoMovimientoInventario.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Tipo de Movimiento de Inventario"

    Private Sub AsociarMenu()
        griTipoMovimientoInventario.ContextMenuStrip = MenuContextual1
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
        If griTipoMovimientoInventario.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class

