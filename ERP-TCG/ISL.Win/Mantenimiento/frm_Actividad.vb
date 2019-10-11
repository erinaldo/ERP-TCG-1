'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports ISL.Controles

Public Class frm_Actividad

#Region "Declaración de variables"
    Private Shared instancia As frm_Actividad = Nothing
    Private Shared Operacion As String
    Dim oeActividad As New e_Actividad
    Dim olActividad As New l_Actividad
    Dim _ingresando_datos As Boolean = False
#End Region

#Region "Instancia"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Actividad()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If grid_Actividades.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        oeActividad.TipoOperacion = "I"
        MostrarTabs(1, tcActividad, 1)
        Inicializar()
        txtNombre.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        MostrarActividad()
        oeActividad.TipoOperacion = "A"
        txtNombre.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarActividad() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcActividad, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeActividad.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarActividad() Then
                            MostrarTabs(0, tcActividad, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcActividad, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcActividad, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcActividad, 2)
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
            With grid_Actividades
                If ValidarGrilla(grid_Actividades, "Servicios") Then
                    oeActividad.Id = .ActiveRow.Cells("ID").Value
                    oeActividad = olActividad.Obtener(oeActividad)
                    If oeActividad.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la actividad: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeActividad.TipoOperacion = "E"
                            olActividad.Eliminar(oeActividad)
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

            If grid_Actividades.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Actividades)

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

    Private Sub frm_Actividad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Actividad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Actividad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcActividad)
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        TeclaPulsada(e)
        oeActividad.Modificado = True
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(txtNombre.Text)
        oeActividad.Nombre = txtNombre.Text
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        TeclaPulsada(e)
        oeActividad.Modificado = True
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        txtDescripcion.Text = LTrim(txtDescripcion.Text)
        oeActividad.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeActividad.Activo = verActivo.Checked
    End Sub

    Private Sub verActivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.Click
        oeActividad.Activo = verActivo.Checked
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        TeclaPulsada(e)
        oeActividad.Modificado = True
    End Sub

    Private Sub grid_Actividades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid_Actividades.KeyDown
        TeclaPulsada(e)
    End Sub

    Private Sub grid_Actividades_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Actividades.DoubleClick
        If grid_Actividades.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub grid_Actividades_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_Actividades.InitializeLayout
        agrTotalActividades.Text = "Total de Actividades: " & e.Layout.Rows.Count
    End Sub


#End Region

#Region "Metodos"

    Private Function GuardarActividad() As Boolean
        Try
            oeActividad.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olActividad.Guardar(oeActividad) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcActividad, 2)
                Consultar(True)
                grid_Actividades.Focus()
                Return True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            'Enfocar(ex.Message)
        End Try
    End Function

    Private Sub MostrarActividad()
        Try
            If grid_Actividades.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeActividad.Id = grid_Actividades.ActiveRow.Cells("Id").Value.ToString
                oeActividad = olActividad.Obtener(oeActividad)
                txtCodigo.Text = oeActividad.Codigo
                txtNombre.Text = oeActividad.Nombre
                txtDescripcion.Text = oeActividad.Descripcion
                verActivo.Checked = oeActividad.Activo
                MostrarTabs(1, tcActividad, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Inicializar()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        verActivo.Checked = True
        AsociarMenu()
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            oeActividad = New e_Actividad
            With grid_Actividades
                oeActividad.Activo = Activo
                .DataSource = olActividad.Listar(oeActividad)

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
        grid_Actividades.Focus()
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Actividad_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_Actividades_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_Actividades.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        grid_Actividades.ContextMenuStrip = mcActividad
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

    Private Sub mcActividad_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcActividad.Opening
        mcActividad.Items("InsertarToolStripMenuItem").Visible = True
        If grid_Actividades.Selected.Rows.Count > 0 Then
            mcActividad.Items("EditarToolStripMenuItem").Visible = True
            mcActividad.Items("EliminarToolStripMenuItem").Visible = True
        Else
            mcActividad.Items("EditarToolStripMenuItem").Visible = False
            mcActividad.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class
