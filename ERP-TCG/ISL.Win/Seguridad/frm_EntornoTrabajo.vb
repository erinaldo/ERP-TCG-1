Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_EntornoTrabajo

    Inherits ISL.Win.frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_EntornoTrabajo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_EntornoTrabajo()
        End If
        instancia.Activate()
        Return instancia

    End Function

#Region "Declaracion de Variables"
    Dim oeEntornoTrabajo As New e_EntornoTrabajo
    Dim olEntornoTrabajo As New l_EntornoTrabajo
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griEntornoTrabajo.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeEntornoTrabajo.TipoOperacion = "I"
        MostrarTabs(1, ficEntornoTrabajo, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeEntornoTrabajo.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficEntornoTrabajo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeEntornoTrabajo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficEntornoTrabajo, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficEntornoTrabajo, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficEntornoTrabajo, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficEntornoTrabajo, 2)
                _ingresando_datos = False
                Consultar(_Activo)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griEntornoTrabajo
                If ValidarGrilla(griEntornoTrabajo, "Entorno Trabajo") Then
                    oeEntornoTrabajo.Id = .ActiveRow.Cells("ID").Value
                    oeEntornoTrabajo = olEntornoTrabajo.Obtener(oeEntornoTrabajo)
                    If oeEntornoTrabajo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Entorno Trabajo: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeEntornoTrabajo.TipoOperacion = "E"
                            olEntornoTrabajo.Eliminar(oeEntornoTrabajo)
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
            If griEntornoTrabajo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griEntornoTrabajo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_EntornoTrabajo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EntornoTrabajo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_EntornoTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = True
        MostrarTabs(0, ficEntornoTrabajo)
        InicializaTiempo()
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oeEntornoTrabajo.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeEntornoTrabajo.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeEntornoTrabajo.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeEntornoTrabajo.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeEntornoTrabajo.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeEntornoTrabajo.Modificado = True
    End Sub

#End Region

#Region "Métodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeEntornoTrabajo = New e_EntornoTrabajo
            With griEntornoTrabajo
                oeEntornoTrabajo.Activo = Activo
                .DataSource = olEntornoTrabajo.Listar(oeEntornoTrabajo)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

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
        griEntornoTrabajo.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griEntornoTrabajo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeEntornoTrabajo.Id = griEntornoTrabajo.ActiveRow.Cells("Id").Value.ToString
                oeEntornoTrabajo = olEntornoTrabajo.Obtener(oeEntornoTrabajo)
                txtCodigo.Text = oeEntornoTrabajo.Codigo
                txtNombre.Text = oeEntornoTrabajo.Nombre
                verActivo.Checked = oeEntornoTrabajo.Activo
                MostrarTabs(1, ficEntornoTrabajo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeEntornoTrabajo.UsuarioCreacion = gUsuarioSGI.Id
            If olEntornoTrabajo.Guardar(oeEntornoTrabajo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficEntornoTrabajo, 2)
                Consultar(_Activo)
                griEntornoTrabajo.Focus()
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

#End Region

    Private Sub griEntornoTrabajo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griEntornoTrabajo.DoubleClick
        If griEntornoTrabajo.Selected.Rows.Count > 0 Then Editar()
    End Sub

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griEntornoTrabajo.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("InsertarToolStripMenuItem").Visible = True
        If griEntornoTrabajo.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class