'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF

Public Class frm_Equipo
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    'Declaración de instancia para el control de modificaciones de la entidad en el formulario
    Private WithEvents oeEquipo As New e_Equipo
    Dim olEquipo As New l_Equipo
    Dim oeTipoEquipo As New e_TipoEquipo, olTipoEquipo As New l_TipoEquipo
    Dim oeMarca As New e_Marca, olMarca As New l_Marca, leMarca As New List(Of e_Marca)
    Dim oeModelo As New e_Modelo, olModelo As New l_Modelo
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Instancia"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Shared instancia As frm_Equipo = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Equipo()
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
            If grid_Equipo.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            oeEquipo.TipoOperacion = "I"
            MostrarTabs(1, tcEquipo, 1)
            Inicializar()
            txtNombre.Focus()
            Operacion = "Nuevo"
            MyBase.Nuevo()
            oeEquipo.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            MostrarVehiculo()
            oeEquipo.TipoOperacion = "A"
            txtCodigo.Focus()
            Operacion = "Editar"
            MyBase.Editar()
            oeEquipo.Modificado = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarEquipo() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcEquipo, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeEquipo.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarEquipo() Then
                            MostrarTabs(0, tcEquipo, 2)
                            _ingresando_datos = False
                            MyBase.Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, tcEquipo, 1)
                        End If
                        'Exit Sub

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, tcEquipo, 2)
                        _ingresando_datos = False
                        MyBase.Consultar(True)
                        'Exit Sub

                End Select
            Else
                MostrarTabs(0, tcEquipo, 2)
                _ingresando_datos = False
                MyBase.Consultar(True)
                'Exit Sub
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With grid_Equipo
                If ValidarGrilla(grid_Equipo, "Equipo") Then
                    oeEquipo.Id = .ActiveRow.Cells("ID").Value
                    oeEquipo = olEquipo.Obtener(oeEquipo)
                    If oeEquipo.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar el Equipo: " & _
                                 .ActiveRow.Cells("Nombre").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeEquipo.TipoOperacion = "E"
                            olEquipo.Eliminar(oeEquipo)
                            Consultar(True)
                        End If
                    Else
                        Throw New Exception("La informacion  se encuentra eliminada en " & Me.Text)
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try

            If grid_Equipo.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(grid_Equipo)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Private Sub frm_Equipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gmt_ConfigurarEventoKeyEnter_Tab(Me)
        gf_AsignarEventoSeleccionarTexto(Me)
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, tcEquipo)
        Tiempo1.Enabled = False
        InicializaTiempo()
    End Sub

    Private Sub cmbMarca_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMarca.ValueChanged
        Try
            oeEquipo.IdMarca = cmbMarca.Value
            oeModelo = New e_Modelo
            oeModelo.IdMarca = cmbMarca.Value
            oeModelo.Activo = True
            LlenarComboMaestro(cmbModelo, olModelo.Listar(oeModelo), -1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub txtNombre_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.ValueChanged
        txtNombre.Text = LTrim(Me.txtNombre.Text)
        oeEquipo.Nombre = txtNombre.Text
    End Sub

    Private Sub txtDescripcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.ValueChanged
        txtDescripcion.Text = LTrim(Me.txtDescripcion.Text)
        oeEquipo.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub cmbModelo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModelo.ValueChanged
        oeEquipo.IdModelo = cmbModelo.Value
    End Sub

    Private Sub cmbTipoEquipo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoEquipo.ValueChanged
        oeEquipo.IdTipoEquipo = cmbTipoEquipo.Value
    End Sub

    Private Sub txtCodigo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.ValueChanged
        Me.txtCodigo.Text = LTrim(Me.txtCodigo.Text)
        oeEquipo.Codigo = txtCodigo.Text
    End Sub

    Private Sub verActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verActivo.CheckedChanged
        oeEquipo.Activo = verActivo.Checked
    End Sub

    Private Sub grid_Equipo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid_Equipo.DoubleClick
        If grid_Equipo.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub frm_Equipo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        instancia = Nothing
    End Sub

    Private Sub oeEquipo_DatoCambiado() Handles oeEquipo.DatoCambiado
        oeEquipo.Modificado = True
    End Sub

    Private Sub frm_Equipo_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case _Operacion
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

    Private Sub optEquipos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cache.ForzarActualizacion = True
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            With grid_Equipo
                oeEquipo = New e_Equipo
                oeEquipo.Activo = True
                .DataSource = olEquipo.Listar(oeEquipo)
                'Ubica el cursor el el primer registro de la grilla
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            grid_Equipo.Focus()
        End Try
    End Sub

    Public Sub LlenaCombos()
        Try
            ' Obtener Marcas Vehiculos
            oeMarca = New e_Marca
            oeMarca.Activo = True : oeMarca.TipoMarca = 0
            leMarca.AddRange(olMarca.Listar(oeMarca))
            ' Obtener Marcas Industriales
            oeMarca.Activo = True : oeMarca.TipoMarca = 2
            leMarca.AddRange(olMarca.Listar(oeMarca))
            LlenarComboMaestro(cmbMarca, leMarca, -1)
            ' Obtener Tipo Equipo
            oeTipoEquipo.Activo = True
            LlenarComboMaestro(cmbTipoEquipo, olTipoEquipo.Listar(oeTipoEquipo), 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        Try
            cmbTipoEquipo.SelectedIndex = -1
            txtCodigo.Text = String.Empty
            txtNombre.Text = String.Empty
            txtNombre.Enabled = True
            txtDescripcion.Text = String.Empty
            verActivo.Checked = True
            LlenaCombos()
            AsociarMenu()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarEquipo() As Boolean
        Try
            oeEquipo.PrefijoID = gs_PrefijoIdSucursal '@0001
            If olEquipo.Guardar(oeEquipo) Then
                mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                MostrarTabs(0, tcEquipo, 2)
                Consultar(True)
                grid_Equipo.Focus()
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub MostrarVehiculo()
        Try
            If grid_Equipo.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeEquipo = New e_Equipo
                oeEquipo.Id = grid_Equipo.ActiveRow.Cells("Id").Value.ToString
                oeEquipo = olEquipo.Obtener(oeEquipo)
                txtCodigo.Text = oeEquipo.Codigo
                txtNombre.Text = oeEquipo.Nombre
                verActivo.Checked = oeEquipo.Activo
                cmbMarca.Value = oeEquipo.IdMarca
                cmbModelo.Value = oeEquipo.IdModelo
                txtDescripcion.Text = oeEquipo.Descripcion
                cmbTipoEquipo.Value = oeEquipo.IdTipoEquipo
                If cmbTipoEquipo.Text = "VEHICULAR" Then txtNombre.Enabled = False
                MostrarTabs(1, tcEquipo, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Equipo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub grid_Equipo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grid_Equipo.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        grid_Equipo.ContextMenuStrip = mcEquipo
    End Sub

    Private Sub InsertarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertarToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Eliminar()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Editar()
    End Sub

    Private Sub mcEquipo_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mcEquipo.Opening
        mcEquipo.Items("InsertarToolStripMenuItem").Visible = True
        If grid_Equipo.Selected.Rows.Count > 0 Then
            mcEquipo.Items("EditarToolStripMenuItem").Visible = True
            mcEquipo.Items("EliminarToolStripMenuItem").Visible = True
        Else
            mcEquipo.Items("EditarToolStripMenuItem").Visible = False
            mcEquipo.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

End Class