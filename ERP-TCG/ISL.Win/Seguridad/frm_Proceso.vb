Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF

Public Class frm_Proceso
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"
    Dim oeProceso As New e_MenuProceso
    Dim olProceso As New l_MenuProceso
    Dim _ingresando_datos As Boolean
#End Region

#Region "Instancia"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Shared instancia As frm_Proceso = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_Proceso()
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
        MostrarTabs(0, ficProceso)
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
        oeProceso.Modificado = True
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        oeProceso.Modificado = True
    End Sub

    Private Sub txtAbreviatura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbreviatura.KeyPress
        oeProceso.Modificado = True
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        oeProceso.Codigo = txtCodigo.Text.Trim
    End Sub

    Private Sub txtAbreviatura_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAbreviatura.ValueChanged
        oeProceso.Abreviatura = txtAbreviatura.Text.Trim
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        oeProceso.Nombre = txtNombre.Text.Trim
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeProceso.Activo = verActivo.Checked
    End Sub

    Private Sub griProceso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griProceso.DoubleClick
        If griProceso.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub verProtegido_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verProtegido.CheckedChanged
        oeProceso.Protegido = verProtegido.Checked
    End Sub

    Private Sub nroOrden_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nroOrden.ValueChanged
        oeProceso.Orden = nroOrden.Text
    End Sub

    'Private Sub btnDialogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'OpenFileDialog1.InitialDirectory = l_Configuracion.RutaImagen
    '    'OpenFileDialog1.Filter = "Icono (*.ico)|*.ico|Portable Network Graphics (*.png)|*.png"
    '    'If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '    '    txtImagen.Text = "\" & OpenFileDialog1.SafeFileName
    '    'End If
    'End Sub

    Private Sub griProceso_InitializeLayout(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griProceso.InitializeLayout
        agrTotalProcesos.Text = "Total de procesos: " & griProceso.Rows.Count
    End Sub

    Private Sub verExplorador_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles verExplorador.CheckedChanged
        oeProceso.Explorador = verExplorador.Checked
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeProceso = New e_MenuProceso
            With griProceso
                oeProceso.Activo = Activo
                .DataSource = olProceso.Listar(oeProceso)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Explorador").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect

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
        griProceso.Focus()
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtAbreviatura.Text = String.Empty
        verExplorador.Checked = False
        verProtegido.Checked = False
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Private Sub Mostrar()
        Try
            If griProceso.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeProceso.Id = griProceso.ActiveRow.Cells("Id").Value.ToString
                oeProceso = olProceso.Obtener(oeProceso)
                txtCodigo.Text = oeProceso.Codigo
                txtNombre.Text = oeProceso.Nombre
                txtAbreviatura.Text = oeProceso.Abreviatura
                nroOrden.Value = oeProceso.Orden
                verExplorador.Checked = oeProceso.Explorador
                verProtegido.Checked = oeProceso.Protegido
                verActivo.Checked = oeProceso.Activo
                MostrarTabs(1, ficProceso, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeProceso.UsuarioCreacion = gUsuarioSGI.Id
            If Not olProceso.Guardar(oeProceso) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficProceso, 2)
            Consultar(_Activo)
            griProceso.Focus()
            Return True
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
            If griProceso.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeProceso.TipoOperacion = "I"
        MostrarTabs(1, ficProceso, 1)
        Inicializar()
        txtCodigo.Focus()
        nroOrden.Text = frm_Menu.utm_ISLSGI.Ribbon.Tabs.Count
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeProceso.TipoOperacion = "A"
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficProceso, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeProceso.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficProceso, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficProceso, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficProceso, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, ficProceso, 2)
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
            With griProceso
                If ValidarGrilla(griProceso, "Proceso") Then
                    oeProceso.Id = .ActiveRow.Cells("Id").Value
                    oeProceso = olProceso.Obtener(oeProceso)
                    If oeProceso.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar Proceso: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeProceso.TipoOperacion = "E"
                            olProceso.Eliminar(oeProceso)
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
            If griProceso.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griProceso)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griProceso.ContextMenuStrip = MenuContextual1
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
        If griProceso.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("EditarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class