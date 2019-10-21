'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF

Public Class frm_Turno

    Inherits frm_MenuPadre

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Turno = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Turno()
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Declaracion de Variables"

    Dim WithEvents oeTurno As New e_Turno
    Dim olTurno As New l_Turno
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Listar(Activo)
            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            If griTurno.Rows.Count > 0 Then
                MyBase.Consultar(Activo)
            Else
                MyBase.Consultar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        MostrarTabs(1, ficTurno, 1)
        Inicializar()
        oeTurno.TipoOperacion = "I"
        oeTurno.Modificado = False
        ' txtGlosa.Focus()
        Operacion = "Nuevo"
        MyBase.Nuevo()
    End Sub

    Public Overrides Sub Editar()
        Mostrar()
        oeTurno.TipoOperacion = "A"
        oeTurno.Modificado = False
        'txtGlosa.Focus()
        Operacion = "Editar"
        MyBase.Editar()
    End Sub

    Public Overrides Sub Guardar()
        Try
            'LlenarDatos()
            If Guardando() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, ficTurno, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeTurno.Modificado Then
                Select Case MessageBox.Show("¿Desea guardar los cambios efectuados en " & Me.Text & "?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                    Case Windows.Forms.DialogResult.Yes
                        If Guardando() Then
                            MostrarTabs(0, ficTurno, 2)
                            _ingresando_datos = False
                            Consultar(_Activo)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficTurno, 1)
                        End If
                        'Exit Sub
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficTurno, 2)
                        _ingresando_datos = False
                        Consultar(_Activo)
                        'Exit Sub
                End Select
            Else
                MostrarTabs(0, ficTurno, 2)
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
            With griTurno
                If ValidarGrilla(griTurno, "Turno") Then
                    oeTurno.Id = .ActiveRow.Cells("ID").Value
                    oeTurno = olTurno.Obtener(oeTurno)
                    If oeTurno.Activo Then
                        If MessageBox.Show("Esta seguro de eliminar la Turno: " & _
                                 .ActiveRow.Cells("Dia").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            oeTurno.TipoOperacion = "E"
                            olTurno.Eliminar(oeTurno)
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
            If griTurno.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Exportar_Excel(griTurno)

            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        MyBase.Imprimir()
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Turno_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Turno_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub frm_Turno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
        MostrarTabs(0, ficTurno)
        AsociarMenu()
    End Sub

    Private Sub cboDia_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDia.ValueChanged
        'If cboDia.SelectedIndex > -1 Then oeTurno.Dia = DevuelveDia(cboDia.SelectedIndex)
        If cboDia.SelectedIndex > -1 Then oeTurno.Dia = cboDia.Text
    End Sub

    Private Sub cboTurno_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTurno.ValueChanged
        If cboTurno.SelectedIndex > -1 Then oeTurno.Turno = DevuelveTurno(cboTurno.SelectedIndex)
    End Sub

    'Private Sub fecHoraInicio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecHoraInicio.ValueChanged
    '    Try
    '        oeTurno.HoraInicio = FormatDateTime(fecHoraInicio.Value.ToString, DateFormat.ShortTime)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub fecHorInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecHorInicio.ValueChanged
        Try
            oeTurno.HoraInicio = FormatDateTime(fecHorInicio.Value.ToString, DateFormat.ShortTime)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub fecHoraSalida_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fecHoraSalida.ValueChanged
    '    Try
    '        oeTurno.HoraSalida = FormatDateTime(fecHoraSalida.Value.ToString, DateFormat.ShortTime)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub fecHorSalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fecHorSalida.ValueChanged
        Try
            oeTurno.HoraSalida = FormatDateTime(fecHorSalida.Value.ToString, DateFormat.ShortTime)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub oeTurno_DatoCambiado() Handles oeTurno.DatoCambiado
        oeTurno.Modificado = True
    End Sub

    Private Sub griTurno_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griTurno.DoubleClick
        If griTurno.Rows.Count > 0 Then Editar()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeTurno = New e_Turno
            With griTurno
                oeTurno.Activo = Activo
                .DataSource = olTurno.Listar(oeTurno)
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("FechaCreacion").Hidden = True
                .DisplayLayout.Bands(0).Columns("UsuarioCreacion").Hidden = True

                .DisplayLayout.Bands(0).Columns("Activo").CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect


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
        griTurno.Focus()
    End Sub

    Private Sub Inicializar()
        Try
            'fecHoraInicio.Value = "00:00:00"
            fecHorInicio.Value = "01/01/1901 00:00 a.m."
            'fecHoraSalida.Value = "00:00:00"
            fecHorSalida.Value = "01/01/1901 00:00 a.m."
            CargarDias()
            CargarTurno()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Mostrar()
        Try
            If griTurno.ActiveRow.Cells("Id").Value.ToString.Length > 0 Then
                Inicializar()
                oeTurno.Id = griTurno.ActiveRow.Cells("Id").Value.ToString
                oeTurno = olTurno.Obtener(oeTurno)
                'fecHoraInicio.Value = oeTurno.HoraInicio
                fecHorInicio.Value = "01/01/1901 " & oeTurno.HoraInicio

                'fecHoraSalida.Value = oeTurno.HoraSalida
                fecHorSalida.Value = "01/01/1901 " & oeTurno.HoraSalida
                cboDia.SelectedIndex = ObtieneDia(oeTurno.Dia)
                cboTurno.SelectedIndex = ObtieneTurno(oeTurno.Turno)
                MostrarTabs(1, ficTurno, 1)
                MyBase.Editar()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Function Guardando() As Boolean
        Try
            oeTurno.UsuarioCreacion = gUsuarioSGI.Id
            oeTurno.PrefijoID = gs_PrefijoIdSucursal '@0001
            If Not olTurno.Guardar(oeTurno) Then
                Return False
            End If
            mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text)
            MostrarTabs(0, ficTurno, 2)
            Consultar(_Activo)
            griTurno.Focus()
            Return True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
            Enfocar(ex.Message)
        End Try
    End Function

    Private Sub Enfocar(ByVal excepcion As String)
        If excepcion.Contains("día") Then
            cboDia.Focus()
        End If
        If excepcion.Contains("turno") Then
            cboTurno.Focus()
        End If
    End Sub

    Private Sub CargarDias()
        cboDia.Items.Clear()
        cboDia.Items.Add("Lunes")
        cboDia.Items.Add("Martes")
        cboDia.Items.Add("Miércoles")
        cboDia.Items.Add("Jueves")
        cboDia.Items.Add("Viernes")
        cboDia.Items.Add("Sábado")
        cboDia.Items.Add("Domingo")
        cboDia.SelectedIndex = -1
    End Sub

    Private Sub CargarTurno()
        cboTurno.Items.Clear()
        cboTurno.Items.Add("Mañana")
        cboTurno.Items.Add("Tarde")
        cboTurno.Items.Add("Noche")
        cboTurno.SelectedIndex = -1
    End Sub

    Private Function DevuelveDia(ByVal OrdenDia As Integer) As String
        Dim Dia As String = ""
        Select Case OrdenDia
            Case 0
                Dia = "Lunes"
            Case 1
                Dia = "Martes"
            Case 2
                Dia = "Miércoles"
            Case 3
                Dia = "Jueves"
            Case 4
                Dia = "Viernes"
            Case 5
                Dia = "Sábado"
            Case 6
                Dia = "Domingo"
        End Select
        Return Dia
    End Function

    Private Function DevuelveTurno(ByVal OrdenTurno As Integer) As String
        Dim Turno As String = ""
        Select Case OrdenTurno
            Case 0
                Turno = "M"
            Case 1
                Turno = "T"
            Case 2
                Turno = "N"

        End Select
        Return Turno
    End Function

    Private Function ObtieneDia(ByVal Dia As String) As Integer
        Dim Indice As Integer = -1
        Select Case Dia
            Case "Lunes"
                Indice = 0
            Case "Martes"
                Indice = 1
            Case "Miércoles"
                Indice = 2
            Case "Jueves"
                Indice = 3
            Case "Viernes"
                Indice = 4
            Case "Sábado"
                Indice = 5
            Case "Domingo"
                Indice = 6
        End Select
        Return Indice
    End Function

    Private Function ObtieneTurno(ByVal Turno As String) As Integer
        Dim Indice As Integer = -1
        Select Case Turno
            Case "M"
                Indice = 0
            Case "T"
                Indice = 1
            Case "N"
                Indice = 2

        End Select
        Return Indice
    End Function

#End Region

#Region "Control de tiempo de respuesta y actualización"

    Private Sub frm_Turno_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        InicializaTiempo()
    End Sub

    Private Sub griTurno_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles griTurno.MouseMove
        If _tiempo <= 0 Then
            Listar(_Activo)
        End If
        InicializaTiempo()
    End Sub

#End Region

#Region "Menú contextual del maestro de areas"

    Private Sub AsociarMenu()
        griTurno.ContextMenuStrip = MenuContextual1
    End Sub

    Private Sub tsmiInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiInsertar.Click
        Nuevo()
    End Sub

    Private Sub tsmiActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiActualizar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub MenuContextual1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MenuContextual1.Opening
        MenuContextual1.Items("tsmiInsertar").Visible = True
        If griTurno.Selected.Rows.Count > 0 Then
            MenuContextual1.Items("tsmiActualizar").Visible = True
            MenuContextual1.Items("tsmiEliminar").Visible = True
        Else
            MenuContextual1.Items("tsmiActualizar").Visible = False
            MenuContextual1.Items("tsmiEliminar").Visible = False
        End If
    End Sub

#End Region


End Class