Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win.UltraWinGrid

Public Class frm_MenuGrupo
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"
    Dim oeMenuGrupo As New e_MenuGrupo
    Dim olMenuGrupo As New l_MenuGrupo
    Dim oeMenuProceso As New e_MenuProceso
    Dim olMenuProceso As New l_MenuProceso
    Dim _ingresando_datos As Boolean
#End Region

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_MenuGrupo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_MenuGrupo()
            Operacion = "Inicializa"
        End If
        instancia.Activate()
        Return instancia
    End Function


#End Region

#Region "Eventos"

    Private Sub frm_Proceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCodigo.CharacterCasing = CharacterCasing.Normal
        txtAbreviatura.CharacterCasing = CharacterCasing.Normal
        txtNombre.CharacterCasing = CharacterCasing.Normal
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        Tiempo1.Enabled = False
        MostrarTabs(0, ficMenuGrupo)
        InicializaTiempo()
    End Sub

    Private Sub frm_Proceso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Proceso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        oeMenuGrupo.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeMenuGrupo.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeMenuGrupo.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeMenuGrupo.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeMenuGrupo.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeMenuGrupo.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeMenuGrupo.Activo = verActivo.Checked
    End Sub

    Private Sub griMenuGrupo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griMenuGrupo.DoubleClick
        If griMenuGrupo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verProtegido_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verProtegido.CheckedChanged
        oeMenuGrupo.Protegido = IIf(verProtegido.Checked, 1, 0)
    End Sub

    Private Sub nroOrden_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nroOrden.ValueChanged
        If nroOrden.Text.Trim.Length > 0 Then oeMenuGrupo.Orden = CInt(nroOrden.Text.Trim)
    End Sub

    Private Sub btnDialogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'OpenFileDialog1.InitialDirectory = l_Configuracion.RutaImagen
        'OpenFileDialog1.Filter = "Icono (*.ico)|*.ico|Portable Network Graphics (*.png)|*.png"
        'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtImagen.Text = "\" & OpenFileDialog1.SafeFileName
        'End If
    End Sub

    Private Sub griMenuGrupo_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griMenuGrupo.InitializeLayout
        agrMenuGrupo.Text = "Total de grupos: " & griMenuGrupo.Rows.Count
    End Sub

    Private Sub cboMenuProceso_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMenuProceso.ValueChanged
        If cboMenuProceso.SelectedIndex > -1 Then oeMenuGrupo.IdMenuProceso = cboMenuProceso.Value.ToString.Trim
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeMenuGrupo = New e_MenuGrupo
            With griMenuGrupo
                oeMenuGrupo.Activo = Activo
                .DataSource = olMenuGrupo.Listar(oeMenuGrupo)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Protegido").Style = ColumnStyle.CheckBox
                .DisplayLayout.Bands(0).Columns("MenuProceso").CellClickAction = CellClickAction.RowSelect

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
        griMenuGrupo.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        LlenarCombo(cboMenuProceso, "Abreviatura", olMenuProceso.Listar(oeMenuProceso), -1)
        verProtegido.Checked = False
        oeMenuGrupo.Protegido = 0
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griMenuGrupo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeMenuGrupo.Id = griMenuGrupo.ActiveRow.Cells("Id").Value.ToString
                oeMenuGrupo = olMenuGrupo.Obtener(oeMenuGrupo)
                cboMenuProceso.Value = oeMenuGrupo.IdMenuProceso
                txtCodigo.Text = oeMenuGrupo.Codigo
                txtNombre.Text = oeMenuGrupo.Nombre
                txtAbreviatura.Text = oeMenuGrupo.Abreviatura
                nroOrden.Value = oeMenuGrupo.Orden
                verProtegido.Checked = IIf(oeMenuGrupo.Protegido = 1, True, False)
                verActivo.Checked = oeMenuGrupo.Activo
                MostrarTabs(1, ficMenuGrupo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeMenuGrupo.UsuarioCreacion = gUsuarioSGI.Id
            If olMenuGrupo.Guardar(oeMenuGrupo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
                MostrarTabs(0, ficMenuGrupo, 2)
                Consultar(_Activo)
                griMenuGrupo.Focus()
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
        If excepcion.Contains("Abreviatura") Then
            txtAbreviatura.Focus()
        End If
    End Sub

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griMenuGrupo.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeMenuGrupo.TipoOperacion = "I"
        MostrarTabs(1, ficMenuGrupo, 1)
        Inicializar()
        txtCodigo.Focus()
        nroOrden.Text = frm_Menu.utm_ISLSGI.Ribbon.Tabs.Count
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeMenuGrupo.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficMenuGrupo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeMenuGrupo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", _
                                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficMenuGrupo, 2) : _ingresando_datos = False : Consultar(_Activo)
                        Else
                            _ingresando_datos = True : MostrarTabs(1, ficMenuGrupo, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficMenuGrupo, 2) : _ingresando_datos = False : Consultar(_Activo)
                End Select
            Else
                MostrarTabs(0, ficMenuGrupo, 2) : _ingresando_datos = False : Consultar(_Activo)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griMenuGrupo
                If ValidarGrilla(griMenuGrupo, "Proceso") Then
                    oeMenuGrupo.Id = .ActiveRow.Cells("Id").Value
                    oeMenuGrupo = olMenuGrupo.Obtener(oeMenuGrupo)
                    If oeMenuGrupo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar Menu Grupo: " & .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                 MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeMenuGrupo.TipoOperacion = "E"
                            olMenuGrupo.Eliminar(oeMenuGrupo)
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
            If griMenuGrupo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griMenuGrupo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griMenuGrupo.ContextMenuStrip = MenuContextual1
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
        If griMenuGrupo.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class