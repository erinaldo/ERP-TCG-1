'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ERP.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_Horarios
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Horarios = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Horarios()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeHorarios As New e_Horarios
    Private olHorarios As New l_Horarios
    Private loHorarios As New List(Of e_Horarios)

    Private oeTipoHorario As New e_TipoHorario
    Private olTipoHorario As New l_TipoHorario
    Private loTipoHorario As New List(Of e_TipoHorario)

    Private _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficHorarios, 1)
            Inicializar()
            cboTipoHorario.Focus()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
            If griHorarios.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            Operacion = "Editar"
            MostrarTabs(1, ficHorarios, 1)
            Mostrar()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficHorarios.SelectedTab.Index
                Case 1
                    If GuardarHorario() Then
                        mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                        MostrarTabs(0, ficHorarios, 0)
                        Consultar(True)
                    Else
                        MostrarTabs(1, ficHorarios, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeHorarios.Modificado Then
                    Select MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarHorario() Then
                            MostrarTabs(0, ficHorarios, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficHorarios, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficHorarios, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficHorarios)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griHorarios.Rows.Count > 0 Then
                Exportar_Excel(griHorarios)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griHorarios.Rows.Count > 0 Then
                EliminarHorario()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Public Sub CargarCombo()
        Try
            Dim oeTiHo As New e_TipoHorario
            Dim loTiHo As New List(Of e_TipoHorario)
            oeTipoHorario = New e_TipoHorario
            oeTipoHorario.TipoOperacion = "1"
            loTipoHorario = olTipoHorario.Listar(oeTipoHorario)
            LlenarCombo(cboTipoHorario, "Nombre", loTipoHorario, 0)
            oeTiHo.Id = ""
            oeTiHo.Nombre = " TODOS"
            loTiHo.Add(oeTiHo)
            loTiHo.AddRange(loTipoHorario)
            LlenarCombo(cboTipoHorario1, "Nombre", loTiHo, 0)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Listar()
        Try
            oeHorarios = New e_Horarios
            oeHorarios.TipoOperacion = "1"
            If cboTipoHorario1.Value <> "" Then oeHorarios.IdTipoHorario = cboTipoHorario1.Value
            griHorarios.DataSource = olHorarios.Listar(oeHorarios)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarHorario() As Boolean
        Try
            Dim flag As Boolean = False
            For Each hor As e_Horarios In loHorarios
                If Operacion = "Editar" Then
                    Dim fechaservidor As Date = ObtenerFechaServidor()
                    hor.HoraInicio = fechaservidor.Date & " " & hor.HoraInicio.Hour & " : " & hor.HoraInicio.Minute & " : " & "00"
                    hor.HoraFin = fechaservidor.Date & " " & hor.HoraFin.Hour & " : " & hor.HoraFin.Minute & " : " & "00"
                    If hor.TipoOperacion Is Nothing Then hor.TipoOperacion = "A"
                End If
                hor.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olHorarios.Guardar(hor) Then
                    flag = True
                Else
                    flag = False
                End If
            Next
            If flag = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Inicializar()
        oeHorarios = New e_Horarios
        loHorarios.Clear()
        griHorarioDetalle.DataSource = loHorarios
        cboTipoHorario.SelectedIndex = -1
        cboTipoHorario1.SelectedIndex = -1
    End Sub

    Public Sub Mostrar()
        Inicializar()
        oeHorarios.TipoOperacion = "1"
        oeHorarios.Id = griHorarios.ActiveRow.Cells("Id").Value
        oeHorarios = olHorarios.Obtener(oeHorarios)
        cboTipoHorario.Value = oeHorarios.IdTipoHorario
        loHorarios.Add(oeHorarios)
        griHorarioDetalle.DataSource = loHorarios
        'griHorarioDetalle.DataBind()
        LlenaCombosGrilla(griHorarioDetalle)
    End Sub

    Private Sub EliminarHorario()
        'Try
        '    Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        '        Case Windows.Forms.DialogResult.Yes
        '            oeHorarios = New e_Horarios
        '            oeHorarios.TipoOperacion = "E"
        '            oeHorarios.Id = griHorarios.ActiveRow.Cells("Id").Value
        '            oeHorarios.Activo = 0
        '            If olHorarios.Guardar(oeHorarios) Then
        '                Consultar()
        '            End If
        '        Case Windows.Forms.DialogResult.No
        '            Exit Sub
        '        Case Windows.Forms.DialogResult.Cancel
        '            Exit Sub
        '    End Select
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

    Private Sub AgregarHorario()
        Try
            If cboTipoHorario.SelectedIndex = -1 Then Throw New Exception("Seleccione Tipo Horario")
            Dim oeHor As New e_Horarios
            oeHor.TipoOperacion = "I"
            oeHor.IdTipoHorario = cboTipoHorario.Value
            oeHor.HoraInicio = fecHoraInicio.Value.Date & " " & fecHoraInicio.Value.Hour & " : " & fecHoraInicio.Value.Minute & " : " & "00"
            oeHor.HoraFin = fecHoraFin.Value.Date & " " & fecHoraFin.Value.Hour & " : " & fecHoraFin.Value.Minute & " : " & "00"
            oeHor.UsuarioCreacion = gUsuarioSGI.Id
            oeHor.FechaCreacion = ObtenerFechaServidor()
            loHorarios.Add(oeHor)
            griHorarioDetalle.DataBind()
            LlenaCombosGrilla(griHorarioDetalle)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenaCombosGrilla(ByVal Grilla As UltraWinGrid.UltraGrid)
        Try
            For i As Integer = 0 To Grilla.Rows.Count - 1
                CrearComboGridPorCelda("IdTipoHorario", "Nombre", i, Grilla, olTipoHorario.ComboGrilla(loTipoHorario), True)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarTipo()
        Try
            Dim formulario As New frm_TipoHorario
            formulario.ShowDialog()
            CargarCombo()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Horarios_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Select Case ficHorarios.SelectedTab.Index
            Case 0
                If griHorarios.Rows.Count Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_Horarios_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Horarios_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_Horarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            fecHoraFin.Value = Date.Now
            fecHoraInicio.Value = Date.Now
            CargarCombo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try

    End Sub

    Private Sub griHorarioDetalle_CellChange(sender As System.Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griHorarioDetalle.CellChange
        griHorarioDetalle.UpdateData()
        oeHorarios.Modificado = True
    End Sub

    Private Sub cboTipoHorario_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoHorario.ValueChanged
        oeHorarios.Modificado = True
    End Sub

    Private Sub fecHoraInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecHoraInicio.ValueChanged
        oeHorarios.Modificado = True
    End Sub

    Private Sub fecHoraFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecHoraFin.ValueChanged
        oeHorarios.Modificado = True
    End Sub

    Private Sub griHorarios_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griHorarios.DoubleClick
        Editar()
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        Try
            With griHorarioDetalle
                If .Rows.Count > 0 Then
                    If .ActiveRow.Selected Then
                        Dim oeHD As New e_Horarios
                        oeHD = .ActiveRow.ListObject
                        If oeHD.TipoOperacion = "I" Then
                            oeHD = loHorarios.Item(loHorarios.IndexOf(oeHD))
                            loHorarios.Remove(oeHD)
                        Else
                            oeHD = loHorarios.Item(loHorarios.IndexOf(oeHD))
                            oeHD.Activo = 0
                            .ActiveRow.Hidden = True
                        End If
                        .DataBind()
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevoTipo_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoTipo.Click
        Try
            AgregarTipo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            If griHorarioDetalle.Rows.Count = 0 Then
                AgregarHorario()
            Else
                If griHorarioDetalle.Rows(0).Hidden = True Then
                    AgregarHorario()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

End Class