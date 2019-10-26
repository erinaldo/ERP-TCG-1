'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_Distrito
    Inherits frm_MenuPadre

    Private Shared instancia As frm_Distrito = Nothing
    ''' Instancia unica de Formulario: frm_Distrito
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Distrito
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"
    Dim olDistrito As New l_Distrito

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeDistrito As New e_Distrito

    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Eventos"

    Private Sub frm_Distrito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficDistrito)
        griDistrito.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griDistrito.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True

        Departamento1.Id = "010000"
        Departamento1.Nombre = "AMAZONAS"
        Departamento1.Seleccionar("010000")
        Departamento1.Refresh()

        Tiempo1.Enabled = False
        InicializaTiempo()

    End Sub

    Private Sub oeDistrito_DatoCambiado() Handles oeDistrito.DatoCambiado
        oeDistrito.Modificado = True
    End Sub

    ''' <summary>
    ''' Cuenta el total de registros y los muestra
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub griDistrito_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs)
        agrDistritos.Text = "Total de Distritos: " & e.Layout.Rows.Count
    End Sub

    Private Sub frm_Distrito_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Distrito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
        oeDistrito.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeDistrito.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeDistrito.Activo = verActivo.Checked
    End Sub

    Private Sub griDistrito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles griDistrito.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub griDistrito_BeforeRowsDeleted(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griDistrito.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griDistrito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griDistrito.DoubleClick
        If griDistrito.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub Departamento1_DatosCambiados(ByVal idDepartamento As String, ByVal NombreDepartamento As String) Handles Departamento1.DatosCambiados
        Provincia1.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
        Provincia1.Listar()
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griDistrito.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeDistrito.TipoOperacion = "I"
        MostrarTabs(1, ficDistrito, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
        oeDistrito.Modificado = False
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeDistrito.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeDistrito.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarRegistro() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficDistrito, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeDistrito.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficDistrito, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficDistrito, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficDistrito, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficDistrito, 2)
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
            With griDistrito
                If ValidarGrilla(griDistrito, "Distrito") Then
                    oeDistrito.Id = .ActiveRow.Cells("ID").Value
                    oeDistrito = olDistrito.Obtener(oeDistrito)
                    If oeDistrito.Activo Then
                        If MessageBox.Show("Desea eliminar el Distrito: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeDistrito.TipoOperacion = "E"
                            olDistrito.Eliminar(oeDistrito)
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

            If griDistrito.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griDistrito)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
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
            If griDistrito.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeDistrito.Id = griDistrito.ActiveRow.Cells("Id").Value.ToString
                oeDistrito = olDistrito.Obtener(oeDistrito)
                txtId.Text = oeDistrito.Id
                txtCodigo.Text = oeDistrito.Codigo
                txtNombre.Text = oeDistrito.Nombre
                verActivo.Checked = oeDistrito.Activo
                MostrarTabs(1, ficDistrito, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeDistrito.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olDistrito.Guardar(oeDistrito) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficDistrito, 2)
                Consultar(True)
                griDistrito.Focus()
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
            oeDistrito = New e_Distrito
            With griDistrito
                oeDistrito.CodigoDepartamento = Departamento1.Id.Substring(0, 2)
                oeDistrito.CodigoProvincia = Provincia1.Id.Substring(2, 2)
                oeDistrito.Activo = Activo
                .DataSource = olDistrito.Listar(oeDistrito)
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

    Private Sub frm_Distrito_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griDistrito_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griDistrito.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de Distritos"

    Private Sub AsociarMenu()
        griDistrito.ContextMenuStrip = MenuContextual1
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
        If griDistrito.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
