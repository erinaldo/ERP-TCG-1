Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_TipoEmpresa
    Inherits ISL.Win.frm_MenuPadre

    Private Shared instancia As frm_TipoEmpresa = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_TipoEmpresa
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaración de Variables"
    Dim olTipoEmpresa As New l_TipoEmpresa
    Dim oeTipoEmpresa As New e_TipoEmpresa
    Dim _ingresando_datos As Boolean = False
    Dim estado As String
#End Region

#Region "Eventos"

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeTipoEmpresa.Codigo = txtCodigo.Value
        oeTipoEmpresa.Modificado = True
    End Sub
    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeTipoEmpresa.Nombre = txtNombre.Value
        oeTipoEmpresa.Modificado = True
    End Sub

    Private Sub frm_TipoEmpresa_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Select Case Operacion
            Case "Nuevo"
                MyBase.Nuevo()
            Case "Editar"
                MyBase.Editar()
            Case "Inicializa"
                Tiempo1.Enabled = False
                InicializaTiempo()
                MostrarTabs(0, ficTipoEmpresa)
                Consultar(True)
            Case "Ayuda"

        End Select
    End Sub
    Private Sub frm_TipoEmpresa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficTipoEmpresa)
        griTipoEmpresa.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        griTipoEmpresa.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.True
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub frm_TipoEmpresa_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_TipoEmpresa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub griTipoEmpresa_BeforeRowsDeleted(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles griTipoEmpresa.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub griTipoEmpresa_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griTipoEmpresa.DoubleClick
        Editar()
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
            If griTipoEmpresa.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTipoEmpresa.Id = griTipoEmpresa.ActiveRow.Cells("Id").Value.ToString
                oeTipoEmpresa = olTipoEmpresa.Obtener(oeTipoEmpresa)
                txtId.Text = oeTipoEmpresa.Id
                txtCodigo.Text = oeTipoEmpresa.Codigo
                txtNombre.Text = oeTipoEmpresa.Nombre
                verActivo.Checked = oeTipoEmpresa.Activo
                MostrarTabs(1, ficTipoEmpresa, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)

        End Try
    End Sub

    Private Function GuardarRegistro() As Boolean
        Try
            oeTipoEmpresa.UsuarioCreacion = gUsuarioSGI.Id
            If Not olTipoEmpresa.Guardar(oeTipoEmpresa) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficTipoEmpresa, 2)
            Consultar(True)
            griTipoEmpresa.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If Activo Then
                estado = " Activo"
            Else
                estado = " Inactivo"
            End If
            Me.Cursor = Cursors.WaitCursor
            oeTipoEmpresa = New e_TipoEmpresa
            With griTipoEmpresa
                oeTipoEmpresa.Activo = Activo
                .DataSource = olTipoEmpresa.Listar(oeTipoEmpresa)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                agrLista.Text = "Total de Tipos de Empresas: " & griTipoEmpresa.Rows.Count.ToString
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

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griTipoEmpresa.Rows.Count > 0 Then
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
        oeTipoEmpresa.TipoOperacion = "I"
        MostrarTabs(1, ficTipoEmpresa, 1)
        Inicializar()
        txtCodigo.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Try
            Mostrar()
            oeTipoEmpresa.TipoOperacion = "A"
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
                MostrarTabs(1, ficTipoEmpresa, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTipoEmpresa.Modificado And ficTipoEmpresa.SelectedTab.Index = 1 Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarRegistro() Then
                            MostrarTabs(0, ficTipoEmpresa, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTipoEmpresa, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTipoEmpresa, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficTipoEmpresa, 2)
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
            With griTipoEmpresa
                If ValidarGrilla(griTipoEmpresa, "TipoEmpresa") Then
                    oeTipoEmpresa.Id = .ActiveRow.Cells("ID").Value
                    oeTipoEmpresa = olTipoEmpresa.Obtener(oeTipoEmpresa)
                    If oeTipoEmpresa.Activo Then
                        If MessageBox.Show("Desea eliminar el Tipo de Empresa : " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTipoEmpresa.TipoOperacion = "E"
                            olTipoEmpresa.Eliminar(oeTipoEmpresa)
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

            If griTipoEmpresa.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTipoEmpresa)

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

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_TipoEmpresa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTipoEmpresa_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub


#End Region

#Region "Menú contextual del maestro de TipoEmpresa"
    Private Sub AsociarMenu()
        griTipoEmpresa.ContextMenuStrip = MenuContextual1
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
        If griTipoEmpresa.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class