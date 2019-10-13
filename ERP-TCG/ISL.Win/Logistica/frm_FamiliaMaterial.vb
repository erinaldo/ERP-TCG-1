'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF

Public Class frm_FamiliaMaterial

#Region "Inicializacion de Formulario"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared Instancia As frm_FamiliaMaterial = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If Instancia Is Nothing Then
            Instancia = New frm_FamiliaMaterial()
            Operacion = "Inicializa"
        End If
        Instancia.Activate()
        Return Instancia
    End Function
#End Region

#Region "Declaración de Variables"
    Dim olFamiliaMaterial As New l_FamiliaMaterial
    Dim oeFamiliaMaterial As New e_FamiliaMaterial
    Dim oeTipoMaterial As New e_TipoMaterial
    Dim olTipoMaterial As New l_TipoMaterial
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String
#End Region

#Region "Eventos"

    Private Sub frm_FamiliaMaterial_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficFamiliaMaterial)
        griFamiliaMaterial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griFamiliaMaterial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
        llenarTipoMaterial()
    End Sub

    Private Sub llenarTipoMaterial()
        oeTipoMaterial.TipoOperacion = ""
        oeTipoMaterial.Activo = True
        LlenarComboMaestro(cboTipoMaterial, olTipoMaterial.Listar(oeTipoMaterial), -1)
    End Sub

    Private Sub frm_FamiliaMaterial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_FamiliaMaterial_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    'Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
    '    txtCodigo.SelectAll()
    'End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        TeclaPulsada(e)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeFamiliaMaterial.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeFamiliaMaterial.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeFamiliaMaterial.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub verActivo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles verActivo.KeyPress
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub griFamiliaMaterial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griFamiliaMaterial.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griFamiliaMaterial_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griFamiliaMaterial.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griFamiliaMaterial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griFamiliaMaterial.DoubleClick
        If griFamiliaMaterial.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griFamiliaMaterial_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griFamiliaMaterial.InitializeLayout
        agrLista.Text = "Total de Familias de Material: " & e.Layout.Rows.Count & Estado
    End Sub

    Private Sub cboTipoMaterial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTipoMaterial.KeyDown
        TeclaPulsada(e)
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub cboTipoMaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipoMaterial.KeyPress
        oeFamiliaMaterial.Modificado = True
    End Sub

    Private Sub cboTipoMaterial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoMaterial.ValueChanged
        oeFamiliaMaterial.Modificado = True
        oeFamiliaMaterial.IdTipoMaterial = cboTipoMaterial.Value
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griFamiliaMaterial.Rows.Count > 0 Then
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
            oeFamiliaMaterial = New e_FamiliaMaterial
            oeFamiliaMaterial.TipoOperacion = "I"
            MostrarTabs(1, ficFamiliaMaterial, 1)
            Inicializar()
            txtCodigo.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeFamiliaMaterial.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficFamiliaMaterial, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeFamiliaMaterial.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficFamiliaMaterial, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFamiliaMaterial, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFamiliaMaterial, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficFamiliaMaterial, 2)
                _ingresando_datos = False
                Operacion = "Inicializa"
                MyBase.Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try

            oeFamiliaMaterial = New e_FamiliaMaterial
            If ValidarGrilla(griFamiliaMaterial, "FamiliaMaterial") Then
                oeFamiliaMaterial.Id = griFamiliaMaterial.ActiveRow.Cells("ID").Value
                oeFamiliaMaterial = olFamiliaMaterial.Obtener(oeFamiliaMaterial)
                If oeFamiliaMaterial.Activo Then
                    If MessageBox.Show("Desea eliminar la Familia de Material: " & _
                             griFamiliaMaterial.ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                             "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        oeFamiliaMaterial.TipoOperacion = "E"
                        olFamiliaMaterial.Eliminar(oeFamiliaMaterial)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                End If
            End If

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

            If griFamiliaMaterial.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griFamiliaMaterial)

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

#Region "Metodos"

    Private Sub Inicializar()
        txtId.Text = String.Empty
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        cboTipoMaterial.SelectedIndex = -1
        verActivo.Checked = True
        'AsociarMenu()
    End Sub

    Private Sub Enfocar(ByVal excepcion As String)
        'If excepcion.Contains("codigo") Then
        '    txtCodigo.Focus()
        'End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub Mostrar()
        Try
            If griFamiliaMaterial.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeFamiliaMaterial = New e_FamiliaMaterial
                oeFamiliaMaterial.Id = griFamiliaMaterial.ActiveRow.Cells("Id").Value.ToString
                oeFamiliaMaterial = olFamiliaMaterial.Obtener(oeFamiliaMaterial)
                txtId.Text = oeFamiliaMaterial.Id
                txtCodigo.Text = oeFamiliaMaterial.Codigo
                txtNombre.Text = oeFamiliaMaterial.Nombre
                verActivo.Checked = oeFamiliaMaterial.Activo
                cboTipoMaterial.Value = oeFamiliaMaterial.IdTipoMaterial
                MostrarTabs(1, ficFamiliaMaterial, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeFamiliaMaterial.UsuarioCreacion = gUsuarioSGI.Id
            oeFamiliaMaterial.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olFamiliaMaterial.Guardar(oeFamiliaMaterial) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficFamiliaMaterial, 2)
            Consultar(True)
            griFamiliaMaterial.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Estado = IIf(Activo, " Activo", " Inactivo")
            Me.Cursor = Cursors.WaitCursor
            oeFamiliaMaterial = New e_FamiliaMaterial
            With griFamiliaMaterial
                oeFamiliaMaterial.Activo = Activo
                .DataSource = olFamiliaMaterial.Listar(oeFamiliaMaterial)
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

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_FamiliaAlmacen_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griFamiliaMaterial_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griFamiliaMaterial.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Familia de Material"

    'Private Sub AsociarMenu()
    '    griFamiliaMaterial.ContextMenuStrip = MenuContextual1
    'End Sub

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
        If griFamiliaMaterial.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class

