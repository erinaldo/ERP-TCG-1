'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_MotivoCese
    Inherits frm_MenuPadre

#Region "Inicializacion Form"

    Private Shared instancia As frm_MotivoCese = Nothing
    Private Shared Operacion As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_MotivoCese
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Private WithEvents oeMotivoCese As New e_MotivoCese
    Private olMotivoCese As New l_MotivoCese
    Dim _ingresando_datos As Boolean = False
    Dim Estado As String

#End Region

#Region "Botones"
    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grimotivocese.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oemotivocese.TipoOperacion = "I"
        MostrarTabs(1, ficMotivoCese, 1)
        Inicializar()
        txtNombre.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oemotivocese.TipoOperacion = "A"
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficMotivoCese, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oemotivocese.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficMotivoCese, 2)
                            _ingresando_datos = False
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficMotivoCese, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMotivoCese, 2)
                        _ingresando_datos = False
                        Operacion = "Inicializa"
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficMotivoCese, 2)
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
            With grimotivocese
                oemotivocese = New e_MotivoCese
                If ValidarGrilla(grimotivocese, "TipoMaterial") Then
                    oemotivocese.Id = .ActiveRow.Cells("ID").Value
                    oeMotivoCese = olMotivoCese.Obtener(oeMotivoCese)
                    If oemotivocese.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Tipo de Material: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oemotivocese.TipoOperacion = "E"
                            olMotivoCese.Eliminar(oemotivocese)
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
            If grimotivocese.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grimotivocese)
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

    Private Sub frm_MotivoCese_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficMotivoCese.SelectedTab.Index
            Case 0
                If griMotivoCese.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1)
        End Select
    End Sub

    Private Sub frm_MotivoCese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficMotivoCese)
        griMotivoCese.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griMotivoCese.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        InicializaTiempo()
    End Sub

    Private Sub frm_MotivoCese_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_MotivoCese_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub txtNombre_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.SelectAll()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeMotivoCese.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        oeMotivoCese.Modificado = True
    End Sub

    Private Sub grimotivocese_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griMotivoCese.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub grimotivocese_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griMotivoCese.DoubleClick
        If griMotivoCese.Selected.Rows.Count > 0 Then Editar()
    End Sub


#End Region

#Region "Métodos"

    Private Sub Inicializar()
        txtNombre.Text = String.Empty
        AsociarMenu()
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            LlenarObjeto()
            oeMotivoCese.UsuarioCreacion = gUsuarioSGI.Id
            oeMotivoCese.PrefijoID = gs_PrefijoIdSucursal '@0001
            If oeMotivoCese.TipoOperacion = "I" Then oeMotivoCese.FechaCreacion = ObtenerFechaServidor()
            If Not olMotivoCese.Guardar(oeMotivoCese) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficMotivoCese, 2)
            Consultar(True)
            griMotivoCese.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Function

    Public Sub LlenarObjeto()
        oeMotivoCese.Nombre = txtNombre.Text
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                Estado = " Activo"
            Else
                Estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeMotivoCese = New e_MotivoCese
            oeMotivoCese.Activo = Activo
            griMotivoCese.DataSource = olMotivoCese.Listar(oeMotivoCese)

            With griMotivoCese
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Activo").Hidden = True
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
    End Sub

    Private Sub Mostrar()
        Try
            If griMotivoCese.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMotivoCese.Id = griMotivoCese.ActiveRow.Cells("Id").Value.ToString
                oeMotivoCese = olMotivoCese.Obtener(oeMotivoCese)
                txtNombre.Text = oeMotivoCese.Nombre
                MostrarTabs(1, ficMotivoCese, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoMaterial_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        InicializaTiempo()
    End Sub

    Private Sub griTipoMaterial_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Tipo de Material"

    Private Sub AsociarMenu()
        grimotivocese.ContextMenuStrip = MenuContextual1
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
        If griMotivoCese.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class