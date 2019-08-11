Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Provincia
    Inherits ISL.Win.frm_MenuPadre

    Private Shared instancia As frm_Provincia = Nothing
    ''' Instancia unica de Formulario: frm_Provincia
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Provincia
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"
    Dim olProvincia As New l_Provincia

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeProvincia As New e_Provincia

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Eventos"

    Private Sub frm_Provincia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficProvincia)
        griProvincia.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griProvincia.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True

        Departamento1.Id = "010000"
        Departamento1.Nombre = "AMAZONAS"
        Departamento1.Seleccionar("010000")
        Departamento1.Refresh()

        Tiempo1.Enabled = False
        InicializaTiempo()

    End Sub

    Private Sub oeProvincia_DatoCambiado() Handles oeProvincia.DatoCambiado
        oeProvincia.Modificado = True
    End Sub

    ''' <summary>
    ''' Cuenta el total de registros y los muestra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griProvincia_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griProvincia.InitializeLayout
        agrProvincias.Text = "Total de Provincias: " & e.Layout.Rows.Count
    End Sub

    Private Sub frm_Provincia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Provincia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtCodigo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.GotFocus
        txtCodigo.SelectAll()
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub verActivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles verActivo.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        txtCodigo.Text = LTrim(txtCodigo.Text)
        oeProvincia.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeProvincia.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeProvincia.Activo = verActivo.Checked
    End Sub

    Private Sub griProvincia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griProvincia.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griProvincia_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griProvincia.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griProvincia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griProvincia.DoubleClick
        If griProvincia.Selected.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griProvincia.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeProvincia.TipoOperacion = "I"
        MostrarTabs(1, ficProvincia, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeProvincia.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeProvincia.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeProvincia.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficProvincia, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeProvincia.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficProvincia, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficProvincia, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficProvincia, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficProvincia, 2)
                _ingresando_datos = False
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
            With griProvincia
                If ValidarGrilla(griProvincia, "Provincia") Then
                    oeProvincia.Id = .ActiveRow.Cells("ID").Value
                    oeProvincia = olProvincia.Obtener(oeProvincia)
                    If oeProvincia.Activo Then
                        If MessageBox.Show("Desea eliminar el Provincia: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeProvincia.TipoOperacion = "E"
                            olProvincia.Eliminar(oeProvincia)
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

            If griProvincia.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griProvincia)

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
        verActivo.Checked = True
        'entTiempoActualizacionDatos.Value = 10
        'Departamento1.Id = "0100000"
        AsociarMenu()

    End Sub


    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("codigo") Then
            txtCodigo.Focus()
        End If
        If excepcion.Contains("nombre") Then
            txtNombre.Focus()
        End If
    End Sub

    Private Sub Mostrar()
        Try
            If griProvincia.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeProvincia.Id = griProvincia.ActiveRow.Cells("Id").Value.ToString
                oeProvincia = olProvincia.Obtener(oeProvincia)
                txtId.Text = oeProvincia.Id
                txtCodigo.Text = oeProvincia.Codigo
                txtNombre.Text = oeProvincia.Nombre
                verActivo.Checked = oeProvincia.Activo
                MostrarTabs(1, ficProvincia, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            If olProvincia.Guardar(oeProvincia) Then
                MostrarTabs(0, ficProvincia, 2)
                Consultar(True)
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                griProvincia.Focus()
                Return True
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeProvincia = New e_Provincia
            With griProvincia
                oeProvincia.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                oeProvincia.Activo = Activo
                .DataSource = olProvincia.Listar(oeProvincia)
                '.DisplayLayout.Bands(0).Columns("Id").Hidden = True
                '.DisplayLayout.Bands(0).Columns("Codigo").Hidden = False
                '.DisplayLayout.Bands(0).Columns("Nombre").Hidden = False
                '.DisplayLayout.Bands(0).Columns("IdUsuario").Hidden = True

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

    Private Sub frm_Provincia_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griProvincia_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griProvincia.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Provincia"

    Private Sub AsociarMenu()
        griProvincia.ContextMenuStrip = MenuContextual1
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
        If griProvincia.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
