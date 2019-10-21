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

Public Class frm_HorarioTrabajador
    Inherits frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_HorarioTrabajador = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_HorarioTrabajador()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private WithEvents oeHorarioTrabajador As New e_HorarioTrabajador
    Private olHorarioTrabajador As New l_HorarioTrabajador
    Private loHorarioTrabajador As New List(Of e_HorarioTrabajador)
    Private loHorarioTrabajadorVigente As New List(Of e_HorarioTrabajador)
    Private loHorarioTrabajadorNoVigente As New List(Of e_HorarioTrabajador)

    Private oeTipoHorario As New e_TipoHorario
    Private olTipoHorario As New l_TipoHorario
    Private loTipoHorario As New List(Of e_TipoHorario)

    Private oeHorarios As New e_Horarios
    Private olHorarios As New l_Horarios
    Private loHorarios As New List(Of e_Horarios)

    Private olPersona As New l_Persona

    Private _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            MostrarTabs(1, ficHorarioTrabajador, 1)
            Inicializar()
            cboTrabajadores.Focus()
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
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializar()
            If griHorarioTrabajador.ActiveRow.Band.Index = 0 Then
                Operacion = "Editar"
                MostrarTabs(1, ficHorarioTrabajador, 1)
                Mostrar(griHorarioTrabajador.ActiveRow.Cells("Id").Value)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case ficHorarioTrabajador.SelectedTab.Index
                Case 1
                    If GuardarHorarioTrabajador() Then
                        mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                        MostrarTabs(0, ficHorarioTrabajador, 0)
                        Consultar(True)
                    Else
                        MostrarTabs(1, ficHorarioTrabajador, 1)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oeHorarios.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarHorarioTrabajador() Then
                            MostrarTabs(0, ficHorarioTrabajador, 2)
                            _ingresando_datos = False
                            Consultar(True)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficHorarioTrabajador, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficHorarioTrabajador, 2)
                        _ingresando_datos = False
                        Consultar(True)
                End Select
            Else
                MostrarTabs(0, ficHorarioTrabajador)
                _ingresando_datos = False
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griHorarioTrabajador.Rows.Count > 0 Then
                Exportar_Excel(griHorarioTrabajador)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If griHorarioTrabajador.ActiveRow.Band.Index = 0 Then
                EliminarRegistro()
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_HorarioTrabajador_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficHorarioTrabajador.SelectedTab.Index
            Case 0
                If griHorarioTrabajador.Rows.Count Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        End Select
    End Sub

    Private Sub frm_HorarioTrabajador_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_HorarioTrabajador_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_HorarioTrabajador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboTrabajadores_Validated(sender As System.Object, e As System.EventArgs) Handles cboTrabajadores.Validated
        Try
            Dim oeMovimientoPersonal As New e_MovimientoPersonal
            If cboTrabajadores.SelectedIndex > -1 Then
                oeMovimientoPersonal.IdTrabajador = cboTrabajadores.Value
                Dim oeTrabajador As New e_Trabajador
                Dim olTrabajador As New l_Trabajador
                oeTrabajador.Id = oeMovimientoPersonal.IdTrabajador
                oeTrabajador = olTrabajador.ObtenerObjeto(oeTrabajador)
                'If Not String.IsNullOrEmpty(oeTrabajador.oePersona.Dni) Then FotoTrabajador.Image = olPersona.Foto(oeTrabajador.oePersona.Dni)
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
                Mostrar(oeMovimientoPersonal.IdTrabajador)
                FotoTrabajador.Visible = True
                agrDatosBasicos.Visible = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub cboTipoHorario_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoHorario.ValueChanged
        Try
            CargarDetalleTipoHorario()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Try
            AgregarHorarioTrabajador()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnQuitar_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitar.Click
        Try
            QuitarHorarioTrabajador()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub griHorarioTrabajador_DoubleClick(sender As System.Object, e As System.EventArgs) Handles griHorarioTrabajador.DoubleClick
        Editar()
    End Sub

    Private Sub griHorTraDet_CellChange(sender As Object, e As CellEventArgs) Handles griHorTraDet.CellChange
        griHorTraDet.UpdateData()
    End Sub

#End Region
    
#Region "Metodos"

    Public Sub CargarCombos()
        Try
            Dim oeTipoHorario As New e_TipoHorario
            Dim olTipoHorario As New l_TipoHorario
            oeTipoHorario.Activo = 1
            oeTipoHorario.TipoOperacion = "1"
            LlenarCombo(cboTrabajadores, "Nombre", TrabajadorPublic, -1)
            LlenarCombo(cboTipoHorario, "Nombre", olTipoHorario.Listar(oeTipoHorario), -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializar()
        oeHorarios = New e_Horarios
        oeHorarioTrabajador = New e_HorarioTrabajador
        cboTrabajadores.SelectedIndex = -1
        cboTipoHorario.SelectedIndex = -1
        FotoTrabajador.Visible = False
        agrDatosBasicos.Visible = False
        loHorarios = New List(Of e_Horarios)
        griHorarioDetalle.DataSource = loHorarios
        loHorarioTrabajador = New List(Of e_HorarioTrabajador)
        loHorarioTrabajadorNoVigente = New List(Of e_HorarioTrabajador)
        griHorTraDet.DataSource = loHorarioTrabajadorNoVigente
        loHorarioTrabajadorVigente = New List(Of e_HorarioTrabajador)
        griHistorialHorTra.DataSource = loHorarioTrabajadorVigente
    End Sub

    Private Function GuardarHorarioTrabajador() As Boolean
        Try
            For Each hortradet As e_HorarioTrabajador In loHorarioTrabajadorNoVigente
                hortradet.PrefijoID = gs_PrefijoIdSucursal '@0001
                If hortradet.TipoOperacion <> "I" Then
                    hortradet.TipoOperacion = "A"
                End If
            Next
            If olHorarioTrabajador.Guardar(loHorarioTrabajadorNoVigente) Then
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Mostrar(idTrabajador As String)
        Try
            Inicializar()
            MostrarTabs(1, ficHorarioTrabajador, 1)
            oeHorarioTrabajador.TipoOperacion = "1"
            oeHorarioTrabajador.IdTrabajador = idTrabajador
            cboTrabajadores.Value = oeHorarioTrabajador.IdTrabajador
            loHorarioTrabajador = olHorarioTrabajador.Listar(oeHorarioTrabajador)
            loHorarioTrabajadorNoVigente.AddRange(loHorarioTrabajador.Where(Function(item) item.Vigente = True).ToList)
            loHorarioTrabajadorVigente.AddRange(loHorarioTrabajador.Where(Function(item) item.Vigente = False).ToList)
            griHorTraDet.DataSource = loHorarioTrabajadorNoVigente
            griHistorialHorTra.DataSource = loHorarioTrabajadorVigente
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeHorarioTrabajador = New e_HorarioTrabajador
            oeHorarioTrabajador.TipoOperacion = ""
            Dim ds As DataSet = olHorarioTrabajador.ListarDS(oeHorarioTrabajador)
            Dim parentCol As DataColumn = ds.Tables(0).Columns("Id")
            Dim childCol As DataColumn = ds.Tables(1).Columns("IdTrabajador")
            Dim relation As DataRelation = New DataRelation("FKTrabajador", parentCol, childCol, True)
            ds.Relations.Add(relation)
            ds.AcceptChanges()
            griHorarioTrabajador.DataSource = ds
            With griHorarioTrabajador
                .DisplayLayout.Bands(1).Columns("IdTrabajador").Hidden = True
                .DisplayLayout.Bands(1).Columns("Vigente").Hidden = True

                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NombreCompleto").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Cargo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Cargo").Width = 140
                .DisplayLayout.Bands(0).Columns("Area").Width = 140

                .DisplayLayout.Bands(1).Columns("Fecha").Header.VisiblePosition = 1
                .DisplayLayout.Bands(1).Columns("TipoHorario").Header.VisiblePosition = 2
                .DisplayLayout.Bands(1).Columns("HoraInicio").Header.VisiblePosition = 3
                .DisplayLayout.Bands(1).Columns("HoraFin").Header.VisiblePosition = 4

                .DisplayLayout.Bands(1).Columns("Lunes").Width = 60
                .DisplayLayout.Bands(1).Columns("Martes").Width = 60
                .DisplayLayout.Bands(1).Columns("Miercoles").Width = 60
                .DisplayLayout.Bands(1).Columns("Jueves").Width = 60
                .DisplayLayout.Bands(1).Columns("Viernes").Width = 60
                .DisplayLayout.Bands(1).Columns("Sabado").Width = 60
                .DisplayLayout.Bands(1).Columns("Domingo").Width = 60
            End With
            If griHorarioTrabajador.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleTipoHorario()
        Try
            oeHorarios = New e_Horarios
            oeHorarios.IdTipoHorario = cboTipoHorario.Value
            oeHorarios.Activo = 1
            oeHorarios.TipoOperacion = "1"
            loHorarios = olHorarios.Listar(oeHorarios)
            griHorarioDetalle.DataSource = loHorarios
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarHorarioTrabajador()
        Try
            If griHorarioDetalle.Rows.Count > 0 And cboTrabajadores.SelectedIndex <> -1 Then
                For Each hordet As e_Horarios In loHorarios
                    If griHorTraDet.Rows.Count > 0 Then
                        For Each hortradet As e_HorarioTrabajador In loHorarioTrabajadorNoVigente
                            If hordet.Id = hortradet.IdHorario And cboTrabajadores.Value = hortradet.IdTrabajador Then
                                Throw New Exception("Horario ya Asignado a Este Trabajador")
                            End If
                        Next
                    End If
                    oeHorarioTrabajador = New e_HorarioTrabajador
                    With oeHorarioTrabajador
                        .TipoOperacion = "I"
                        .IdTrabajador = cboTrabajadores.Value
                        .IdHorario = hordet.Id
                        Dim fechaservidor As Date = ObtenerFechaServidor()
                        .FechaInicio = fechaservidor
                        .FechaFin = fechaservidor
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .FechaCreacion = fechaservidor
                        .Horario = cboTipoHorario.Text
                        .HoraInicio = hordet.HoraInicio
                        .HoraFin = hordet.HoraFin
                        loHorarioTrabajadorNoVigente.Add(oeHorarioTrabajador)
                    End With
                Next
                griHorTraDet.DataSource = loHorarioTrabajadorNoVigente
                griHorTraDet.DataBind()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub QuitarHorarioTrabajador()
        Try
            With griHorTraDet
                If .Rows.Count > 0 Then
                    If .ActiveRow.Selected Then
                        Dim oeHT As New e_HorarioTrabajador
                        oeHT = .ActiveRow.ListObject
                        If oeHT.TipoOperacion = "I" Then
                            oeHT = loHorarioTrabajador.Item(loHorarioTrabajadorNoVigente.IndexOf(oeHT))
                            loHorarioTrabajador.Remove(oeHT)
                        Else
                            oeHT = loHorarioTrabajador.Item(loHorarioTrabajadorNoVigente.IndexOf(oeHT))
                            oeHT.Activo = 0
                            .ActiveRow.Hidden = True
                        End If
                        .DataSource = loHorarioTrabajadorNoVigente
                        .DataBind()
                    End If
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EliminarRegistro()
        Try
            Select MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    oeHorarioTrabajador = New e_HorarioTrabajador
                    oeHorarioTrabajador.IdTrabajador = griHorarioTrabajador.ActiveRow.Cells("Id").Value
                    If olHorarioTrabajador.Eliminar(oeHorarioTrabajador) Then
                        mensajeEmergente.Confirmacion("La Informacion ha sido Eliminada Correctamente")
                        Listar()
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class