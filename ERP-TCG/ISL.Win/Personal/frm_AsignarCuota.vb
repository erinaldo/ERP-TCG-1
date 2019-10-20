'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win

Public Class frm_AsignarCuota
    Inherits ISL.Win.frm_MenuPadre

#Region "Declaracion de Variables"

    Private oeCuota As New e_Cuota
    Private olCuota As New l_Cuota
    Private oeTrabajador As New e_Trabajador
    Private olTrabajador As New l_Trabajador
    Private oePersona As New e_Persona
    Private olPersona As New l_Persona
    Private Shared Operacion As String
    Private _ingresando_datos As Boolean = False

#End Region

#Region "Inicializar formulario"


    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AsignarCuota = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AsignarCuota()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Combo Trabajador"

    Public Sub CargarCombo()

        'Dim oeTrabajador As New e_Trabajador
        'Dim olTrabajadores As New l_Trabajador
        'oeTrabajador.Activo = True
        'oeTrabajador.TipoOperacion = "X"
        'Dim _leTrab As New List(Of e_Trabajador)
        '_leTrab = olTrabajadores.Listar(oeTrabajador)
        '' _leTrab[Lista] (Id, NombreCompleto) {e_Trabajador}
        'Dim _leTrabAux = From le In _leTrab _
        '                 Select le.Id, le.oePersona.NombreCompleto
        LlenarCombo(cboTrabajadores, "Nombre", TrabajadorPublic, 0)
        Dim a As String = cboTrabajadores.Value


    End Sub

    Private Sub cboTrabajadores_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTrabajadores.ValueChanged

        Dim oeMovimientoPersonal As New e_MovimientoPersonal
        If cboTrabajadores.SelectedIndex > -1 Then
            oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
            Dim oeTrabajador As New e_Trabajador
            Dim olTrabajador As New l_Trabajador
            oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
            oeTrabajador = olTrabajador.Obtener(oeTrabajador)
            oeCuota.IdTrabajador = oeMovimientoPersonal.IdTrabajador
            oeCuota.NombreCompleto = cboTrabajadores.Text

            'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)

            FotoTrabajador.Visible = True
            agrDatosBasicos.Visible = True
            txtArea.Text = oeTrabajador.oeArea.Nombre
            txtCargo.Text = oeTrabajador.oeCargo.Nombre
            fecFechaIngreso.Value = oeTrabajador.FechaIngreso

            chkDisponible.Checked = oeTrabajador.Disponible
            If oeTrabajador.Disponible Then
                chkDisponible.BackColor = Color.Transparent
                chkDisponible.ForeColor = Color.Black
                chkDisponible.Text = "Disponible"
            Else
                chkDisponible.BackColor = Color.Red
                chkDisponible.ForeColor = Color.Yellow
                chkDisponible.Text = "Trabajador NO Disponible"
            End If
        End If
    End Sub


#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Listar(Activo)
            Tiempo1.Enabled = True
            If griTrabajadorCuota.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Public Overrides Sub Nuevo()
        Inicializar()
        oeCuota.TipoOperacion = "I"
        MostrarTabs(1, ficTrabajador, 1)
        Operacion = "Nuevo"
        oeCuota.Id = ""
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Inicializar()
        Mostrar()
        oeCuota.TipoOperacion = "A"
        MostrarTabs(1, ficTrabajador, 1)
        txtCodigo.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeCuota.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarCuota() Then
                            MostrarTabs(0, ficTrabajador, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTrabajador, 1)
                        End If

                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTrabajador, 2)
                        _ingresando_datos = False
                        If griTrabajadorCuota.Rows.Count > 0 Then
                            ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Else
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        End If
                End Select
            Else
                MostrarTabs(0, ficTrabajador, 2)
                _ingresando_datos = False
                If griTrabajadorCuota.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            End If
            '_ingresando_datos = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Public Overrides Sub Guardar()
        Try
            If GuardarCuota() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficTrabajador, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

    Public Overrides Sub Eliminar()
        Try
            With griTrabajadorCuota
                If ValidarGrilla(griTrabajadorCuota, "Cuotas") Then
                    oeCuota.Id = .ActiveRow.Cells("Id").Value
                    oeCuota.TipoOperacion = "4"
                    oeCuota = olCuota.Obtener(oeCuota)
                    If oeCuota.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Cuota de: " & _
                                 .ActiveRow.Cells("NombreCompleto").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            'oeCuota.Id
                            oeCuota.TipoOperacion = "E"
                            olCuota.Eliminar(oeCuota)
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

            If griTrabajadorCuota.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTrabajadorCuota)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Private Function GuardarCuota() As Boolean
        Try
            oeCuota.UsuarioCreacion = gUsuarioSGI.Id
            Dim var = 0
            oeCuota.Cuota = CDbl(Me.txtCuota.Value)
            oeCuota.IdTrabajador = cboTrabajadores.Value

            oeCuota.FechaInicio = CDate(Me.fecFechaInicio.Value)
            oeCuota.FechaFin = CDate(Me.fecFechaFin.Value)
            oeCuota.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olCuota.Guardar(oeCuota) Then Return False
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
            MostrarTabs(0, ficTrabajador, 2)
            Consultar(True)
            griTrabajadorCuota.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            'Enfocar(ex.Message)
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeCuota = New e_Cuota
            With griTrabajadorCuota
                oeCuota.Activo = Activo
                oeCuota.TipoOperacion = "3"
                .DataSource = olCuota.Listar(oeCuota)
            End With
            'Ubica el cursor el el primer registro de la grilla
            If griTrabajadorCuota.Rows.Count > 0 Then
                griTrabajadorCuota.Focus()
                griTrabajadorCuota.Rows.Item(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        griTrabajadorCuota.Focus()
    End Sub

    Private Sub Inicializar()
        Try
            txtCodigo.Text = String.Empty
            Me.cboTrabajadores.Enabled = True
            cboTrabajadores.SelectedIndex = -1
            txtCuota.Value = 0
            Me.agrDatosBasicos.Visible = False
            Me.FotoTrabajador.Visible = False
            Me.fecFechaInicio.Value = Date.Now
            Me.fecFechaFin.Value = Date.Now
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            ControlBoton(0, 0, 0, 0, 0, 0, 1, 0, 1)
            If griTrabajadorCuota.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeCuota.Id = griTrabajadorCuota.ActiveRow.Cells("Id").Value.ToString
                oeCuota.TipoOperacion = "4"
                oeCuota = olCuota.Obtener(oeCuota)
                cboTrabajadores.Enabled = False
                CargaDatosPersonales(oeCuota)

                If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then CargarFotoTrabajador(oeTrabajador)
                MostrarTabs(1, ficTrabajador, 1)

            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CargarFotoTrabajador(ByVal oeTrabajador As e_Trabajador)
        'FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
    End Sub

    Private Sub CargaDatosPersonales(ByVal oeCuota As e_Cuota)
        Try
            With oeCuota
                txtCodigo.Text = .Codigo
                cboTrabajadores.Value = .IdTrabajador
                fecFechaIngreso.Value = .FechaInicio
                fecFechaFin.Value = .FechaFin
                txtCuota.Value = .Cuota
                'cboTrabajadores.ReadOnly = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_AsignarCuota_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If ficTrabajador.SelectedTab.Index = 0 Then
            If griTrabajadorCuota.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_AsignarCuota_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_AsignarCuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombo()
            Me.cboTrabajadores.Enabled = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_AsignarCuota_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

#End Region

#Region "Menú contextual"

    Private Sub AsociarMenu()
        griTrabajadorCuota.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub griTrabajadorCuota_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles griTrabajadorCuota.DoubleClick
        If griTrabajadorCuota.Selected.Rows.Count > 0 Then Editar()
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
        If griTrabajadorCuota.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = True
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = True
        Else
            MenuContextual1.Items("ActualizarToolStripMenuItem").Visible = False
            MenuContextual1.Items("EliminarToolStripMenuItem").Visible = False
        End If
    End Sub

#End Region

#Region "Control de tiempo de respuesta y actualización"
    Private Sub frm_AsignarCuota_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTrabajadorCuota_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTrabajadorCuota.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub
#End Region

    Private Sub ficTrabajador_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles ficTrabajador.SelectedTabChanged

    End Sub
End Class