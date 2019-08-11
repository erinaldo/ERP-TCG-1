Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Formulario
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Formulario = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Formulario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeFormulario As New e_Formulario
    Dim olFormulario As New l_Formulario
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griFormulario.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficFormulario, 1)
        Inicializar()
        oeFormulario.TipoOperacion = "I"
        oeFormulario.Modificado = False
        txtCodigo.Text = ObtieneCodigo()
        txtNombre.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeFormulario.TipoOperacion = "A"
        oeFormulario.Modificado = False
        txtNombre.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficFormulario, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeFormulario.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficFormulario, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficFormulario, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficFormulario, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficFormulario, 2)
                _ingresando_datos = False
                Consultar(_Activo)
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griFormulario
                If ValidarGrilla(griFormulario, "Formulario") Then
                    oeFormulario.Id = .ActiveRow.Cells("ID").Value
                    oeFormulario = olFormulario.Obtener(oeFormulario)
                    If oeFormulario.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Formulario: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeFormulario.TipoOperacion = "E"
                            olFormulario.Eliminar(oeFormulario)
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

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            If griFormulario.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griFormulario)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Formulario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Formulario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Formulario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficFormulario)
        txtNombre.CharacterCasing = CharacterCasing.Normal
        InicializaTiempo()
    End Sub

    Private Sub oeFormulario_DatoCambiado() Handles oeFormulario.DatoCambiado
        oeFormulario.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeFormulario.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        oeFormulario.Descripcion = txtDescripcion.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeFormulario.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub txtRuta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRuta.ValueChanged
        oeFormulario.Ruta = txtRuta.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeFormulario.Activo = verActivo.Checked
    End Sub

    Private Sub verPadre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verPadre.CheckedChanged
        cboFormPadre.Enabled = Not verPadre.Checked
        oeFormulario.Padre = verPadre.Checked
    End Sub

    Private Sub verMultiInstancia_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verMultiInstancia.CheckedChanged
        oeFormulario.Multiinstancia = verMultiInstancia.Checked
    End Sub

    Private Sub cboFormPadre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFormPadre.ValueChanged
        If cboFormPadre.SelectedIndex > -1 Then oeFormulario.IdPadre = cboFormPadre.Value
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeFormulario = New e_Formulario

            With griFormulario

                oeFormulario.Activo = Activo
                .DataSource = olFormulario.Listar(oeFormulario)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("IdPadre").Hidden = True

                .DisplayLayout.Override.FilterUIProvider = Filtro1

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
        griFormulario.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtRuta.Text = String.Empty
        verActivo.Checked = True
        verPadre.Checked = False
        verMultiInstancia.Checked = False
        Dim oe As New e_Formulario
        oe.Padre = True
        LlenarCombo(cboFormPadre, "Nombre", olFormulario.ListarPadre(oe), -1)
        AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griFormulario.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeFormulario.Id = griFormulario.ActiveRow.Cells("Id").Value.ToString
                oeFormulario = olFormulario.Obtener(oeFormulario)
                txtCodigo.Text = oeFormulario.Codigo
                txtNombre.Text = oeFormulario.Nombre
                txtDescripcion.Text = oeFormulario.Descripcion
                txtRuta.Text = oeFormulario.Ruta
                verActivo.Checked = oeFormulario.Activo
                verPadre.Checked = oeFormulario.Padre
                verMultiInstancia.Checked = oeFormulario.Multiinstancia
                cboFormPadre.Value = oeFormulario.IdPadre
                MostrarTabs(1, ficFormulario, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeFormulario.UsuarioCreacion = gUsuarioSGI.Id
            If olFormulario.Guardar(oeFormulario) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, ficFormulario, 2)
                Consultar(_Activo)
                griFormulario.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("Codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("Nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub TecladoTextos(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case (Keys.Escape)
                Cancelar()

            Case (Keys.Enter)
                SendKeys.Send("{TAB}")
        End Select

    End Sub

    Private Sub TecladoGrilla(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Insert
                Nuevo()
            Case Keys.Add
                Nuevo()

            Case Keys.Multiply
                Editar()

            Case Keys.Delete
                Eliminar()

            Case Keys.Subtract
                Eliminar()

            Case Keys.Escape
                Cancelar()
        End Select
    End Sub

    Private Function ObtieneCodigo() As String
        Try
            Dim oe As New e_Formulario
            oe.TipoOperacion = "C"
            Return olFormulario.Obtener(oe).Codigo
        Catch ex As Exception
            'mensajeEmergente.Problema(ex.Message, True)
            Return ""
        End Try
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Formulario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griFormulario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griFormulario.DoubleClick
        If griFormulario.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub griFormulario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griFormulario.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de SituacionAdministrativas"

    Private Sub AsociarMenu()
        griFormulario.ContextMenuStrip = MenuContextual1
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
        If griFormulario.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class