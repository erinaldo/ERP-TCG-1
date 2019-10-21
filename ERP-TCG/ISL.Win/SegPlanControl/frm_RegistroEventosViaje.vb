'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Configuration
Imports Infragistics.Win.CalcEngine
Imports Infragistics.Win.UltraWinDataSource
Imports System.Threading
Imports System.Data.OleDb

Public Class frm_RegistroEventosViaje
    Inherits frm_MenuPadre

#Region "Inicializar el formulario"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_RegistroEventosViaje = Nothing
    Private Shared Operacion As String

    ''' <summary>
    ''' Instancia unica de Formulario: frm_DemandaRapida
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides Function getInstancia() As frm_MenuPadre

        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RegistroEventosViaje()
        End If
        instancia.Activate()
        Return instancia
    End Function

    Public Sub CargarNuevoEvento(ByVal IdViaje As String)
        Try
            If IdViaje <> "" Then
                Inicializar()
                Operacion = "Nuevo"
                fichaDetalle.Tabs(0).Selected = True
                btnBuscar.Enabled = False
                MostrarTabs(1, tcIncidencia, 1)
                MyBase.Nuevo()
                Dim objViaje As New e_Viaje
                objViaje.Id = IdViaje
                oeIncidenciaMaestro.IdViaje = IdViaje
                oeIncidenciaMaestro.TipoOperacion = "I"
                oeIncidenciaMaestro.UsuarioCreacion = gUsuarioSGI.Id.Trim
                objViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(objViaje)
                LlenarDatosViaje(oeViaje)
                CargarGrillasDetalle("", oeViaje.Id, "0")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Definicion de Variables"
    Dim _ingresando_datos As Boolean = False

    Dim TiempoMaximoViaje As Long = 0

    Dim olOperacion As New l_Operacion
    Dim oeViaje As New e_Viaje

    Dim oeVehiculo As New e_Vehiculo
    Dim olVehiculo As New l_Vehiculo

    Dim loConcepto As New l_Concepto
    Dim oeConcepto As New e_Concepto
    Dim ListaConcepto As New List(Of e_Concepto)

    Dim olIncidenciaMaestro As New l_IncidenciaMaestro
    Dim oeIncidenciaMaestro As New e_IncidenciaMaestro

    Dim olAlarma As New l_Alarma
    Dim oeAlarma As New e_Alarma
    Dim listaAlarma As New List(Of e_Alarma)
    Dim listaAreaAlarma As New List(Of e_AreaResponsableEvento)
    Dim NuevoAlarma As Boolean = True

    Dim olAccidente As New l_AccidenteIncidencia
    Dim oeAccidente As New e_AccidenteIncidencia
    Dim listaAccidente As New List(Of e_AccidenteIncidencia)
    Dim listaAreaAccidente As New List(Of e_AreaResponsableEvento)
    Dim NuevoAccidente As Boolean = True

    Dim olIncidente As New l_Incidente
    Dim oeIncidente As New e_Incidente
    Dim listaIncidente As New List(Of e_Incidente)
    Dim listaAreaIncidente As New List(Of e_AreaResponsableEvento)
    Dim NuevoIncidente As Boolean = True

    Dim olRobo As New l_Robo
    Dim oeRobo As New e_Robo
    Dim listaRobo As New List(Of e_Robo)
    Dim listaAreaRobo As New List(Of e_AreaResponsableEvento)
    Dim NuevoRobo As Boolean = True

    Dim olAreaTipoEvento As New l_AreaTipoEvento
    Dim oeAreaTipoEvento As New e_AreaTipoEvento
    Dim listaAreaTipoEvento As New List(Of e_AreaTipoEvento)
    Dim olAreaResponsableEvento As New l_AreaResponsableEvento

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            If ValidarFechaInicioFin(fecDesde, fecHasta) Then
                Listar(Activo)
                Tiempo1.Enabled = True
                If griListaIncidencia.Rows.Count > 0 Then
                    MyBase.Consultar(Activo)
                Else
                    MyBase.Consultar()
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            Operacion = "Nuevo"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            oeViaje = New e_Viaje
            oeIncidenciaMaestro = New e_IncidenciaMaestro
            oeIncidenciaMaestro.TipoOperacion = "I"
            oeIncidenciaMaestro.UsuarioCreacion = gUsuarioSGI.Id.Trim
            oeIncidenciaMaestro.IdViaje = ""

            oeAlarma = New e_Alarma
            listaAlarma = New List(Of e_Alarma)
            listaAreaAlarma = New List(Of e_AreaResponsableEvento)
            oeAlarma.TipoOperacion = "I"

            oeAccidente = New e_AccidenteIncidencia
            listaAccidente = New List(Of e_AccidenteIncidencia)
            listaAreaAccidente = New List(Of e_AreaResponsableEvento)
            oeAccidente.TipoOperacion = "I"

            oeIncidente = New e_Incidente
            listaIncidente = New List(Of e_Incidente)
            listaAreaIncidente = New List(Of e_AreaResponsableEvento)
            oeIncidente.TipoOperacion = "I"

            oeRobo = New e_Robo
            listaRobo = New List(Of e_Robo)
            listaAreaRobo = New List(Of e_AreaResponsableEvento)
            oeRobo.TipoOperacion = "I"

            Inicializar()
            Operacion = "Nuevo"
            fichaDetalle.Tabs(0).Selected = True
            btnBuscar.Enabled = True
            MostrarTabs(1, tcIncidencia, 1)
            MyBase.Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                ugb_Espera.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                MostrarTabs(1, tcIncidencia, 1)
                Inicializar()
                Operacion = "Editar"
                oeIncidenciaMaestro.TipoOperacion = "I"
                oeIncidenciaMaestro.UsuarioCreacion = gUsuarioSGI.Id.Trim
                CargarEditar()
                btnBuscar.Enabled = False
                MyBase.Editar()
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado Cerrar Incidencia por area
                mensajeEmergente.Problema("Seleccionar registro del Listado General.", True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If GuardarIncidencia() Then
                MyBase.Guardar()
            Else
                MostrarTabs(1, tcIncidencia, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case MessageBox.Show("¿Desea guardar los cambios efectuados?", "Mensaje del sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                Case Windows.Forms.DialogResult.Yes
                    Guardar()
                Case Windows.Forms.DialogResult.No
                    MostrarTabs(0, tcIncidencia)
                    MyBase.Cancelar()
                    Consultar(True)
                Case Windows.Forms.DialogResult.Cancel
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                If ValidarGrilla(griListaIncidencia, "Evento Viaje") Then

                    If griListaIncidencia.ActiveRow.Cells("Estado").Value <> "1" Then
                        mensajeEmergente.Problema("Solo se Pueden Eliminar Eventos con estado PENDIENTE", True)
                        Return
                    End If

                    Dim idTipoEvento As String = griListaIncidencia.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
                    If MessageBox.Show("Esta seguro de eliminar: " & _
                                 griListaIncidencia.ActiveRow.Cells("Codigo").Value.ToString & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        If idTipoEvento = "2" Then
                            oeAlarma = New e_Alarma
                            oeAlarma.IdTipoEvento = idTipoEvento.Trim
                            oeAlarma.TipoOperacion = "E"
                            oeAlarma.Id = griListaIncidencia.ActiveRow.Cells("ID").Value.ToString.Trim
                            oeAlarma.UsuarioCreacion = gUsuarioSGI.Id.Trim
                            olAlarma.Eliminar(oeAlarma)
                        ElseIf idTipoEvento = "3" Then
                            oeAccidente = New e_AccidenteIncidencia
                            oeAccidente.IdTipoEvento = idTipoEvento.Trim
                            oeAccidente.TipoOperacion = "E"
                            oeAccidente.Id = griListaIncidencia.ActiveRow.Cells("ID").Value.ToString.Trim
                            oeAccidente.UsuarioCreacion = gUsuarioSGI.Id.Trim
                            olAccidente.Eliminar(oeAccidente)
                        ElseIf idTipoEvento = "7" Then
                            oeIncidente = New e_Incidente
                            oeIncidente.IdTipoEvento = idTipoEvento.Trim
                            oeIncidente.TipoOperacion = "E"
                            oeIncidente.Id = griListaIncidencia.ActiveRow.Cells("ID").Value.ToString.Trim
                            oeIncidente.UsuarioCreacion = gUsuarioSGI.Id.Trim
                            olIncidente.Eliminar(oeIncidente)
                        ElseIf idTipoEvento = "6" Then
                            oeRobo = New e_Robo
                            oeRobo.IdTipoEvento = idTipoEvento.Trim
                            oeRobo.TipoOperacion = "E"
                            oeRobo.Id = griListaIncidencia.ActiveRow.Cells("ID").Value.ToString.Trim
                            oeRobo.UsuarioCreacion = gUsuarioSGI.Id.Trim
                            olRobo.Eliminar(oeRobo)
                        End If
                        Consultar(True)
                    End If

                End If
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado Cerrar Incidencia por area
                If ValidarGrilla(griListaCerrarIncidencia, "Incidencia asignada al Área") Then
                    If griListaCerrarIncidencia.ActiveRow.Cells("IdEstado").Value.ToString.Trim = "2" Then
                        mensajeEmergente.Problema("No se puede eliminar registro con estado Finalizado", True)
                        Return
                    End If
                    Dim CodigoAreaIncidencia As String = griListaCerrarIncidencia.ActiveRow.Cells("Codigo").Value.ToString.Trim
                    If MessageBox.Show("Esta seguro de eliminar: " & _
                                 CodigoAreaIncidencia & " ?", _
                                 "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Dim oeAreaResponsableEvento As New e_AreaResponsableEvento
                        oeAreaResponsableEvento.TipoOperacion = "E"
                        oeAreaResponsableEvento.Id = griListaCerrarIncidencia.ActiveRow.Cells("ID").Value.ToString.Trim
                        oeAreaResponsableEvento.UsuarioCreacion = gUsuarioSGI.Id.Trim
                        olAreaResponsableEvento.Eliminar(oeAreaResponsableEvento)
                        Consultar(True)
                    End If
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Imprimir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Imprimir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                ExportarGrillaAExcel(griListaIncidencia)
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado Cerrar Incidencia por area
                ExportarGrillaAExcel(griListaCerrarIncidencia)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Salir()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            MyBase.Salir()
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub frm_RegistroEventosViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            gmt_ConfigurarEventoKeyEnter_Tab(Me)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            Tiempo1.Enabled = False
            MostrarTabs(0, tcIncidencia)
            InicializaTiempo()
            LlenaCombos()
            fecDesde.Value = Now.Date.AddDays(-5)
            fecHasta.Value = Now.Date.AddDays(+1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim Formulario As New frm_BuscarViajes
            Formulario.CodigoViaje = String.Empty
            Formulario.ShowDialog()
            If Formulario.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim objViaje As New e_Viaje
                objViaje.Id = Formulario.CodigoViaje.Trim
                oeIncidenciaMaestro.IdViaje = Formulario.CodigoViaje.Trim
                objViaje.TipoOperacion = "G"
                oeViaje = olOperacion.ObtenerViaje(objViaje)
                LlenarDatosViaje(oeViaje)
                CargarGrillasDetalle("", oeViaje.Id, "0")
            End If
            Formulario.Dispose()
            Formulario.Close()
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarAlarma_Click(sender As Object, e As EventArgs) Handles btnAgregarAlarma.Click
        Try
            AgregarAlarma()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub btnAgregarAccidente_Click_1(sender As Object, e As EventArgs) Handles btnAgregarAccidente.Click
        Try
            AgregarAccidente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub btnAgregarIncidente_Click_1(sender As Object, e As EventArgs) Handles btnAgregarIncidente.Click
        Try
            AgregarIncidente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub btnAgregarRobo_Click_1(sender As Object, e As EventArgs) Handles btnAgregarRobo.Click
        Try
            AgregarRobo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnLimpiarAlarma_Click(sender As Object, e As EventArgs) Handles btnLimpiarAlarma.Click
        LimpiarAlarma()
        CargarAreasConfiguradasAlarma("2", cboTipoAlarma.Value)
    End Sub
    Private Sub btnLimpiarAccidente_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarAccidente.Click
        LimpiarAccidente()
        CargarAreasConfiguradasAccidente("3", cboTipoAccidente.Value)
    End Sub
    Private Sub btnLimpiarIncidente_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarIncidente.Click
        LimpiarIncidente()
        CargarAreasConfiguradasIncidente("7", cboTipoIncidente.Value)
    End Sub
    Private Sub btnLimpiarRobo_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarRobo.Click
        LimpiarRobo()
        CargarAreasConfiguradasRobo("6", cboTipoRobo.Value)
    End Sub

    Private Sub cboTipoAlarma_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoAlarma.ValueChanged
        Try
            CargarAreas()
            CargarAreasConfiguradasAlarma("2", cboTipoAlarma.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoAccidente_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoAccidente.ValueChanged
        Try
            CargarAreasAccidente()
            CargarAreasConfiguradasAccidente("3", cboTipoAccidente.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoIncidente_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoIncidente.ValueChanged
        Try
            CargarAreasIncidente()
            CargarAreasConfiguradasIncidente("7", cboTipoIncidente.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoRobo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoRobo.ValueChanged
        Try
            CargarAreasRobo()
            CargarAreasConfiguradasRobo("6", cboTipoRobo.Value)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoAlarma_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTipoAlarma.EditorButtonClick
        Try
            CargarTipoAlarma()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoAccidente_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTipoAccidente.EditorButtonClick
        Try
            CargarTipoAccidente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoIncidente_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTipoIncidente.EditorButtonClick
        Try
            CargarTipoIncidente()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub cboTipoRobo_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles cboTipoRobo.EditorButtonClick
        Try
            CargarTipoRobo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaIncidencia_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaIncidencia.DoubleClickRow
        If griListaIncidencia.Selected.Rows.Count > 0 Then Editar()
    End Sub
    Private Sub griListaIncidencia_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaIncidencia.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaAlarmas_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles griListaAlarmas.DoubleClickRow
        Try
            If griListaAlarmas.Selected.Rows.Count = 1 Then
                oeAlarma = New e_Alarma
                oeAlarma = griListaAlarmas.ActiveRow.ListObject
                LlenarDatosAlarma(oeAlarma)
                NuevoAlarma = False
                btnAgregarAlarma.Text = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaAccidentes_DoubleClickRow_1(sender As Object, e As DoubleClickRowEventArgs) Handles griListaAccidentes.DoubleClickRow
        Try
            If griListaAccidentes.Selected.Rows.Count = 1 Then
                oeAccidente = New e_AccidenteIncidencia
                oeAccidente = griListaAccidentes.ActiveRow.ListObject
                LlenarDatosAccidente(oeAccidente)
                NuevoAccidente = False
                btnAgregarAccidente.Text = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaIncidentes_DoubleClickRow_1(sender As Object, e As DoubleClickRowEventArgs) Handles griListaIncidentes.DoubleClickRow
        Try
            If griListaIncidentes.Selected.Rows.Count = 1 Then
                oeIncidente = New e_Incidente
                oeIncidente = griListaIncidentes.ActiveRow.ListObject
                LlenarDatosIncidente(oeIncidente)
                NuevoIncidente = False
                btnAgregarIncidente.Text = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaRobos_DoubleClickRow_1(sender As Object, e As DoubleClickRowEventArgs) Handles griListaRobos.DoubleClickRow
        Try
            If griListaRobos.Selected.Rows.Count = 1 Then
                oeRobo = New e_Robo
                oeRobo = griListaRobos.ActiveRow.ListObject
                LlenarDatosRobo(oeRobo)
                NuevoRobo = False
                btnAgregarRobo.Text = "Editar"
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAreas_CellChange_1(sender As Object, e As CellEventArgs) Handles griAreas.CellChange
        Try
            With griAreas
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then
                        If .ActiveRow.Cells("Selec").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If

                        oeAlarma.Modificado = True

                        Dim oeAreaAlarma As New e_AreaResponsableEvento
                        listaAreaAlarma = griAreasAlarma.DataSource

                        oeAreaAlarma.IdArea = .ActiveRow.Cells("Id").Value
                        oeAreaAlarma.Codigo = .ActiveRow.Cells("Codigo").Value

                        If Not listaAreaAlarma.Contains(oeAreaAlarma) Then
                            If .ActiveRow.Cells("Selec").Value Then

                                oeAreaAlarma.Id = String.Empty
                                oeAreaAlarma.TipoOperacion = "I"
                                oeAreaAlarma.IdEvento = oeAlarma.Id
                                oeAreaAlarma.IdTipoEvento = "1"
                                oeAreaAlarma.IdArea = .ActiveRow.Cells("Id").Value
                                oeAreaAlarma.Area = .ActiveRow.Cells("Nombre").Value
                                oeAreaAlarma.UsuarioCreacion = gUsuarioSGI.Id

                                listaAreaAlarma.Add(oeAreaAlarma)
                                If griAreasAlarma.Rows.Count < 1 Then
                                    LlenarAreaAlarma()
                                End If

                            End If
                        Else
                            oeAreaAlarma = listaAreaAlarma.Item(listaAreaAlarma.IndexOf(oeAreaAlarma))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeAreaAlarma.TipoOperacion = "E" Then
                                    oeAreaAlarma.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griAreasAlarma.Rows
                                        If fila.Cells("IdArea").Value = oeAreaAlarma.IdArea Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Area: " & .ActiveRow.Cells("Area").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeAreaAlarma.Id <> "" Then
                                    listaAreaAlarma.Remove(oeAreaAlarma)
                                Else
                                    listaAreaAlarma.Remove(oeAreaAlarma)
                                End If

                            End If

                        End If

                    End If
                End If
            End With

            griAreasAlarma.DataSource = listaAreaAlarma
            griAreasAlarma.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griAreasAccidente_CellChange(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles griAreasAccidente.CellChange
        Try
            With griAreasAccidente
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then
                        If .ActiveRow.Cells("Selec").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If

                        oeAccidente.Modificado = True
                        Dim oeAreaAccidente As New e_AreaResponsableEvento
                        listaAreaAccidente = griAreasAccidenteAsignado.DataSource

                        oeAreaAccidente.IdArea = .ActiveRow.Cells("Id").Value
                        oeAreaAccidente.Codigo = .ActiveRow.Cells("Codigo").Value

                        If Not listaAreaAccidente.Contains(oeAreaAccidente) Then
                            If .ActiveRow.Cells("Selec").Value Then
                                oeAreaAccidente.Id = String.Empty
                                oeAreaAccidente.TipoOperacion = "I"
                                oeAreaAccidente.IdEvento = oeAlarma.Id
                                oeAreaAccidente.IdTipoEvento = "1"
                                oeAreaAccidente.IdArea = .ActiveRow.Cells("Id").Value
                                oeAreaAccidente.Area = .ActiveRow.Cells("Nombre").Value
                                oeAreaAccidente.UsuarioCreacion = gUsuarioSGI.Id

                                listaAreaAccidente.Add(oeAreaAccidente)
                                If griAreasAccidenteAsignado.Rows.Count < 1 Then
                                    LlenarAreaAccidente()
                                End If

                            End If
                        Else
                            oeAreaAccidente = listaAreaAccidente.Item(listaAreaAccidente.IndexOf(oeAreaAccidente))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeAreaAccidente.TipoOperacion = "E" Then
                                    oeAreaAccidente.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griAreasAccidenteAsignado.Rows
                                        If fila.Cells("IdArea").Value = oeAreaAccidente.IdArea Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Area: " & .ActiveRow.Cells("Area").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeAreaAccidente.Id <> "" Then
                                    listaAreaAccidente.Remove(oeAreaAccidente)
                                Else
                                    listaAreaAccidente.Remove(oeAreaAccidente)
                                End If

                            End If

                        End If

                    End If
                End If
            End With
            griAreasAccidenteAsignado.DataSource = listaAreaAccidente
            griAreasAccidenteAsignado.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griAreasIncidentes_CellChange(sender As Object, e As CellEventArgs) Handles griAreasIncidentes.CellChange
        Try
            With griAreasIncidentes
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then
                        If .ActiveRow.Cells("Selec").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If
                        oeIncidente.Modificado = True
                        Dim oeAreaIncidente As New e_AreaResponsableEvento
                        listaAreaIncidente = griAreasIncidentesAsignados.DataSource
                        oeAreaIncidente.IdArea = .ActiveRow.Cells("Id").Value
                        oeAreaIncidente.Codigo = .ActiveRow.Cells("Codigo").Value

                        If Not listaAreaIncidente.Contains(oeAreaIncidente) Then
                            If .ActiveRow.Cells("Selec").Value Then
                                oeAreaIncidente.Id = String.Empty
                                oeAreaIncidente.TipoOperacion = "I"
                                oeAreaIncidente.IdEvento = oeAlarma.Id
                                oeAreaIncidente.IdTipoEvento = "1"
                                oeAreaIncidente.IdArea = .ActiveRow.Cells("Id").Value
                                oeAreaIncidente.Area = .ActiveRow.Cells("Nombre").Value
                                oeAreaIncidente.UsuarioCreacion = gUsuarioSGI.Id

                                listaAreaIncidente.Add(oeAreaIncidente)
                                If griAreasIncidentesAsignados.Rows.Count < 1 Then
                                    LlenarAreaIncidente()
                                End If
                            End If
                        Else
                            oeAreaIncidente = listaAreaIncidente.Item(listaAreaIncidente.IndexOf(oeAreaIncidente))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeAreaIncidente.TipoOperacion = "E" Then
                                    oeAreaIncidente.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griAreasIncidentesAsignados.Rows
                                        If fila.Cells("IdArea").Value = oeAreaIncidente.IdArea Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Area: " & .ActiveRow.Cells("Area").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeAreaIncidente.Id <> "" Then
                                    listaAreaIncidente.Remove(oeAreaIncidente)
                                Else
                                    listaAreaIncidente.Remove(oeAreaIncidente)
                                End If

                            End If

                        End If

                    End If
                End If
            End With
            griAreasIncidentesAsignados.DataSource = listaAreaIncidente
            griAreasIncidentesAsignados.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griAreasRobo_CellChange(sender As Object, e As CellEventArgs) Handles griAreasRobo.CellChange
        Try
            With griAreasRobo
                If e.Cell.Row.Index > -1 Then
                    .UpdateData()
                    If .ActiveRow.Cells("Selec").Activated Then
                        If .ActiveRow.Cells("Selec").Value Then
                            .ActiveRow.Fixed = True
                        Else
                            .ActiveRow.Fixed = False
                        End If

                        oeRobo.Modificado = True
                        Dim oeAreaRobo As New e_AreaResponsableEvento
                        listaAreaRobo = griAreaRoboAsignada.DataSource

                        oeAreaRobo.IdArea = .ActiveRow.Cells("Id").Value
                        oeAreaRobo.Codigo = .ActiveRow.Cells("Codigo").Value

                        If Not listaAreaRobo.Contains(oeAreaRobo) Then
                            If .ActiveRow.Cells("Selec").Value Then
                                oeAreaRobo.Id = String.Empty
                                oeAreaRobo.TipoOperacion = "I"
                                oeAreaRobo.IdEvento = oeAlarma.Id
                                oeAreaRobo.IdTipoEvento = "1"
                                oeAreaRobo.IdArea = .ActiveRow.Cells("Id").Value
                                oeAreaRobo.Area = .ActiveRow.Cells("Nombre").Value
                                oeAreaRobo.UsuarioCreacion = gUsuarioSGI.Id

                                listaAreaRobo.Add(oeAreaRobo)
                                If griAreaRoboAsignada.Rows.Count < 1 Then
                                    LlenarAreaRobo()
                                End If

                            End If
                        Else
                            oeAreaRobo = listaAreaRobo.Item(listaAreaRobo.IndexOf(oeAreaRobo))
                            If .ActiveRow.Cells("Selec").Value Then
                                If oeAreaRobo.TipoOperacion = "E" Then
                                    oeAreaRobo.TipoOperacion = ""
                                    For Each fila As UltraWinGrid.UltraGridRow In griAreaRoboAsignada.Rows
                                        If fila.Cells("IdArea").Value = oeAreaRobo.IdArea Then
                                            fila.Hidden = False
                                            Exit For
                                        End If
                                    Next
                                Else
                                    Throw New Exception("El Area: " & .ActiveRow.Cells("Area").Value & " ya esta Asignado")
                                End If

                            Else
                                If oeAreaRobo.Id <> "" Then
                                    listaAreaRobo.Remove(oeAreaRobo)
                                Else
                                    listaAreaRobo.Remove(oeAreaRobo)
                                End If

                            End If

                        End If

                    End If
                End If
            End With
            griAreaRoboAsignada.DataSource = listaAreaRobo
            griAreaRoboAsignada.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griListaAlarmas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaAlarmas.BeforeRowsDeleted
        Try
            If griListaAlarmas.ActiveRow.Cells("Estado").Value <> "1" Then
                mensajeEmergente.Problema("Solo se Pueden Eliminar Eventos con estado PENDIENTE", True)
                e.Cancel = True
                Return
            End If

            e.DisplayPromptMsg = False

            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaAccidentes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaAccidentes.BeforeRowsDeleted
        Try
            If griListaAlarmas.ActiveRow.Cells("Estado").Value <> "1" Then
                mensajeEmergente.Problema("Solo se Pueden Eliminar Eventos con estado PENDIENTE", True)
                e.Cancel = True
                Return
            End If

            e.DisplayPromptMsg = False

            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaIncidentes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaIncidentes.BeforeRowsDeleted
        Try
            If griListaAlarmas.ActiveRow.Cells("Estado").Value <> "1" Then
                mensajeEmergente.Problema("Solo se Pueden Eliminar Eventos con estado PENDIENTE", True)
                e.Cancel = True
                Return
            End If

            e.DisplayPromptMsg = False

            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub griListaRobos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaRobos.BeforeRowsDeleted
        Try
            If griListaAlarmas.ActiveRow.Cells("Estado").Value <> "1" Then
                mensajeEmergente.Problema("Solo se Pueden Eliminar Eventos con estado PENDIENTE", True)
                e.Cancel = True
                Return
            End If

            e.DisplayPromptMsg = False

            If MessageBox.Show(Me.Text & ": ¿Desea Eliminar el Registro?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
                Return
            End If

        Catch ex As Exception
            e.Cancel = True
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griAreas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreas.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasAlarma_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasAlarma.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasAccidente_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasAccidente.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasAccidenteAsignado_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasAccidenteAsignado.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasIncidentes_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasIncidentes.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasIncidentesAsignados_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasIncidentesAsignados.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreasRobo_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreasRobo.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub
    Private Sub griAreaRoboAsignada_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griAreaRoboAsignada.BeforeRowsDeleted
        e.Cancel = True
        e.DisplayPromptMsg = False
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        Try
            If griListaIncidencia.Selected.Rows.Count = 1 Then
                Dim formulario As frm_EnvioEmail
                formulario = New frm_EnvioEmail
                formulario.Modulo = "EventoViaje"
                formulario.asunto = "Evento de Viaje: " & griListaIncidencia.ActiveRow.Cells("TipoEvento").Value.ToString.Trim & _
                    " Tipo: " & griListaIncidencia.ActiveRow.Cells("Tipo").Value.ToString.Trim
                formulario.cadenaMensajeHtml = getBodyEmail()
                formulario.ShowDialog()
            Else
                mensajeEmergente.Confirmacion("Debe seleccionar un registro.", True)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_RegistroEventosViaje_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub
    Private Sub frm_RegistroEventosViaje_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

#End Region

#Region "Metodos"
    Private Sub Inicializar()
        Dim ListAlarma As New List(Of e_Alarma)
        Dim ListAccidente As New List(Of e_AccidenteIncidencia)
        Dim ListIncidente As New List(Of e_Incidente)
        Dim ListRobo As New List(Of e_Robo)

        griListaAlarmas.DataSource = ListAlarma
        griListaAccidentes.DataSource = ListAccidente
        griListaIncidentes.DataSource = ListIncidente
        griListaRobos.DataSource = ListRobo

        LimpiarViaje()
        LimpiarAlarma()
        LimpiarAccidente()
        LimpiarIncidente()
        LimpiarRobo()
        'LimpiarEncargado()

        CargarAreasConfiguradasAlarma("2", cboTipoAlarma.Value)
        CargarAreasConfiguradasAccidente("3", cboTipoAccidente.Value)
        CargarAreasConfiguradasIncidente("7", cboTipoIncidente.Value)
        CargarAreasConfiguradasRobo("6", cboTipoRobo.Value)
    End Sub

    Private Sub LimpiarAlarma()
        NuevoAlarma = True
        oeAlarma = New e_Alarma
        fecAlarma.Value = Date.Now
        hAlarma.Value = Date.Now
        cboTipoAlarma.SelectedIndex = 0
        cboLugarAlarma.SelectedIndex = 0
        'cboOperador.SelectedIndex = 0

        cboOperador.Value = IIf(oeVehiculo.IdEmpresaGPS = Nothing, "", oeVehiculo.IdEmpresaGPS.Trim)

        cboEstadoAlarma.SelectedIndex = 0
        txtReferenciaLugarAlarma.Text = String.Empty
        txtDetalleAlarma.Text = String.Empty
        txtObservacionAlarma.Text = String.Empty
        btnAgregarAlarma.Text = "Agregar"
        CargarAreas()
    End Sub
    Private Sub LimpiarAccidente()
        NuevoAccidente = True
        oeAccidente = New e_AccidenteIncidencia
        fecAccidente.Value = Date.Now
        hAccidente.Value = Date.Now
        cboTipoAccidente.SelectedIndex = 0
        cboLugarAccidente.SelectedIndex = 0
        cboEstadoAccidente.SelectedIndex = 0
        cboOperadorAccidente.SelectedIndex = 0
        txtReferenciaLugarAccidente.Text = String.Empty
        txtDetalleAccidente.Text = String.Empty
        chkDenunciaAccidente.Checked = False
        fecDenunciaAccidente.Value = Date.Now
        hDenunciaAccidente.Value = Date.Now
        chkDosajeAccidente.Checked = False
        fecDosajeAccidente.Value = Date.Now
        hDosajeAccidente.Value = Date.Now
        txtObservacionAccidente.Text = String.Empty
        btnAgregarAccidente.Text = "Agregar"
        CargarAreasAccidente()
    End Sub
    Private Sub LimpiarIncidente()
        NuevoIncidente = True
        oeIncidente = New e_Incidente
        fecIncidente.Value = Date.Now
        hIncidente.Value = Date.Now
        cboTipoIncidente.SelectedIndex = 0
        cboLugarIncidente.SelectedIndex = 0
        cboOperadorIncidente.SelectedIndex = 0
        cboEstadoIncidente.SelectedIndex = 0
        txtReferenciaLugarIncidente.Text = String.Empty
        txtDetalleIncidente.Text = String.Empty
        txtObservacionIncidente.Text = String.Empty
        btnAgregarIncidente.Text = "Agregar"
        CargarAreasIncidente()
    End Sub
    Private Sub LimpiarRobo()
        NuevoRobo = True
        oeRobo = New e_Robo
        fecRobo.Value = Date.Now
        hRobo.Value = Date.Now
        cboTipoRobo.SelectedIndex = 0
        cboLugarRobo.SelectedIndex = 0
        cboEstadoRobo.SelectedIndex = 0
        cboOperadorRobo.SelectedIndex = 0
        txtReferenciaLugarRobo.Text = String.Empty
        txtDetalleRobo.Text = String.Empty
        chkDenunciaRobo.Checked = False
        fecDenunciaRobo.Value = Date.Now
        hDenunciaRobo.Value = Date.Now
        txtObservacionRobo.Text = String.Empty
        btnAgregarRobo.Text = "Agregar"
        CargarAreasRobo()
    End Sub

    Private Sub LlenarDatosViaje(ByVal objViaje As e_Viaje)
        Try
            LimpiarViaje()
            If objViaje Is Nothing Then Return
            With objViaje
                txtIdSeguimiento.Text = .Id
                txtCodigoOperacion.Text = .Operacion
                txtCodigoViaje.Text = .Codigo
                txtViajeTracto.Text = .Tracto
                txtViajeCarreta.Text = .Carreta
                fecViaje.Value = .Fecha
                txtViajeOrigen.Text = .Origen
                txtViajeDestino.Text = .Destino
                txtViajePiloto.Text = .Piloto
                txtViajeCopiloto.Text = .Copiloto
                txtViajeEscala.Text = .Escala
                cboActividadNegocio.Value = .Tesoreria

                oeVehiculo = New e_Vehiculo
                oeVehiculo.Id = objViaje.IdTracto
                oeVehiculo = olVehiculo.Obtener(oeVehiculo)
                cboOperador.Value = oeVehiculo.IdEmpresaGPS.Trim
                cboOperadorAccidente.Value = oeVehiculo.IdEmpresaGPS.Trim
                cboOperadorIncidente.Value = oeVehiculo.IdEmpresaGPS.Trim
                cboOperadorRobo.Value = oeVehiculo.IdEmpresaGPS.Trim
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarAreasConfiguradasAlarma(ByVal IdTipoEvento As String, ByVal IdTipo As String)
        Try
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = IdTipoEvento
            oeAreaTipoEvento.IdTipo = IdTipo
            listaAreaTipoEvento = olAreaTipoEvento.Listar(oeAreaTipoEvento)
            listaAreaAlarma = New List(Of e_AreaResponsableEvento)
            For Each Fila As e_AreaTipoEvento In listaAreaTipoEvento
                Dim oeAreaResponsable As New e_AreaResponsableEvento
                oeAreaResponsable.IdArea = Fila.IdArea
                oeAreaResponsable.Area = Fila.Area
                oeAreaResponsable.Glosa = Fila.Glosa
                oeAreaResponsable.Activo = True
                listaAreaAlarma.Add(oeAreaResponsable)
            Next
            griAreasAlarma.DataSource = listaAreaAlarma
            griAreasAlarma.DataBind()
            For Each oe As e_AreaResponsableEvento In listaAreaAlarma
                For Each Fila As UltraWinGrid.UltraGridRow In griAreas.Rows
                    If Fila.Cells("Id").Value.trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub CargarAreasConfiguradasAccidente(ByVal IdTipoEvento As String, ByVal IdTipo As String)
        Try
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = IdTipoEvento
            oeAreaTipoEvento.IdTipo = IdTipo
            listaAreaTipoEvento = olAreaTipoEvento.Listar(oeAreaTipoEvento)
            listaAreaAccidente = New List(Of e_AreaResponsableEvento)
            For Each Fila As e_AreaTipoEvento In listaAreaTipoEvento
                Dim oeAreaResponsable As New e_AreaResponsableEvento
                oeAreaResponsable.IdArea = Fila.IdArea
                oeAreaResponsable.Area = Fila.Area
                oeAreaResponsable.Glosa = Fila.Glosa
                oeAreaResponsable.Activo = True
                listaAreaAccidente.Add(oeAreaResponsable)
            Next
            griAreasAccidenteAsignado.DataSource = listaAreaAccidente
            griAreasAccidenteAsignado.DataBind()
            For Each oe As e_AreaResponsableEvento In listaAreaAccidente
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasAccidente.Rows
                    If Fila.Cells("Id").Value.trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub CargarAreasConfiguradasIncidente(ByVal IdTipoEvento As String, ByVal IdTipo As String)
        Try
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = IdTipoEvento
            oeAreaTipoEvento.IdTipo = IdTipo
            listaAreaTipoEvento = olAreaTipoEvento.Listar(oeAreaTipoEvento)
            listaAreaIncidente = New List(Of e_AreaResponsableEvento)
            For Each Fila As e_AreaTipoEvento In listaAreaTipoEvento
                Dim oeAreaResponsable As New e_AreaResponsableEvento
                oeAreaResponsable.IdArea = Fila.IdArea
                oeAreaResponsable.Area = Fila.Area
                oeAreaResponsable.Glosa = Fila.Glosa
                oeAreaResponsable.Activo = True
                listaAreaIncidente.Add(oeAreaResponsable)
            Next
            griAreasIncidentesAsignados.DataSource = listaAreaIncidente
            griAreasIncidentesAsignados.DataBind()
            For Each oe As e_AreaResponsableEvento In listaAreaIncidente
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasIncidentes.Rows
                    If Fila.Cells("Id").Value.trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub CargarAreasConfiguradasRobo(ByVal IdTipoEvento As String, ByVal IdTipo As String)
        Try
            oeAreaTipoEvento = New e_AreaTipoEvento
            oeAreaTipoEvento.IdTipoEvento = IdTipoEvento
            oeAreaTipoEvento.IdTipo = IdTipo
            listaAreaTipoEvento = olAreaTipoEvento.Listar(oeAreaTipoEvento)
            listaAreaRobo = New List(Of e_AreaResponsableEvento)
            For Each Fila As e_AreaTipoEvento In listaAreaTipoEvento
                Dim oeAreaResponsable As New e_AreaResponsableEvento
                oeAreaResponsable.IdArea = Fila.IdArea
                oeAreaResponsable.Area = Fila.Area
                oeAreaResponsable.Glosa = Fila.Glosa
                oeAreaResponsable.Activo = True
                listaAreaRobo.Add(oeAreaResponsable)
            Next
            griAreaRoboAsignada.DataSource = listaAreaRobo
            griAreaRoboAsignada.DataBind()
            For Each oe As e_AreaResponsableEvento In listaAreaRobo
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasRobo.Rows
                    If Fila.Cells("Id").Value.trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LlenarDatosAlarma(ByVal objAlarma As e_Alarma)
        Try
            LimpiarAlarma()
            If objAlarma Is Nothing Then Return
            With objAlarma
                cboTipoAlarma.Value = .IdTipo.Trim
                cboOperador.Value = .IdOperador.Trim
                cboLugarAlarma.Value = .IdUbicacion.Trim
                cboEstadoAlarma.Value = .Estado.Trim
                txtReferenciaLugarAlarma.Text = .ReferenciaLugar.Trim
                txtDetalleAlarma.Text = .Descripcion.Trim
                txtObservacionAlarma.Text = .Observacion.Trim
                fecAlarma.Value = .FechaHora
                hAlarma.Value = .FechaHora
                griAreasAlarma.DataSource = objAlarma.leAreaAlarma
                griAreasAlarma.DataBind()
            End With
            For Each oe As e_AreaResponsableEvento In objAlarma.leAreaAlarma
                For Each Fila As UltraWinGrid.UltraGridRow In griAreas.Rows
                    If Fila.Cells("Id").Value.Trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
            oeAlarma = objAlarma
            NuevoAlarma = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub LlenarDatosAccidente(ByVal objAccidente As e_AccidenteIncidencia)
        Try
            LimpiarAccidente()
            If objAccidente Is Nothing Then Return
            With objAccidente
                fecAccidente.Value = .FechaHora
                hAccidente.Value = .FechaHora
                cboTipoAccidente.Value = .IdTipo.Trim
                cboOperadorAccidente.Value = .IdOperador.Trim
                cboLugarAccidente.Value = .IdUbicacion.Trim
                cboEstadoAccidente.Value = .Estado.Trim
                txtReferenciaLugarAccidente.Text = .ReferenciaLugar.Trim
                txtDetalleAccidente.Text = .Descripcion.Trim
                chkDenunciaAccidente.Checked = .Denuncia
                chkDosajeAccidente.Checked = .Dosaje
                fecDenunciaAccidente.Value = .FechaHoraDenuncia
                hDenunciaAccidente.Value = .FechaHoraDenuncia
                fecDosajeAccidente.Value = .FechaHoraDosaje
                hDosajeAccidente.Value = .FechaHoraDosaje
                txtObservacionAccidente.Text = .Observacion.Trim
                griAreasAccidenteAsignado.DataSource = objAccidente.leAreaAccidente
                griAreasAccidenteAsignado.DataBind()
            End With
            For Each oe As e_AreaResponsableEvento In objAccidente.leAreaAccidente
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasAccidente.Rows
                    If Fila.Cells("Id").Value.Trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
            oeAccidente = objAccidente
            NuevoAccidente = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub LlenarDatosIncidente(ByVal objIncidente As e_Incidente)
        Try
            LimpiarIncidente()
            If objIncidente Is Nothing Then Return
            With objIncidente
                cboTipoIncidente.Value = .IdTipo.Trim
                cboOperadorIncidente.Value = .IdOperador.Trim
                cboLugarIncidente.Value = .IdUbicacion.Trim
                cboEstadoIncidente.Value = .Estado.Trim
                txtReferenciaLugarIncidente.Text = .ReferenciaLugar.Trim
                txtDetalleIncidente.Text = .Descripcion.Trim
                fecIncidente.Value = .FechaHora
                hIncidente.Value = .FechaHora
                txtObservacionIncidente.Text = .Observacion.Trim
                griAreasIncidentesAsignados.DataSource = objIncidente.leAreaIncidente
                griAreasIncidentesAsignados.DataBind()
            End With
            For Each oe As e_AreaResponsableEvento In objIncidente.leAreaIncidente
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasIncidentes.Rows
                    If Fila.Cells("Id").Value.Trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
            oeIncidente = objIncidente
            NuevoAccidente = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
    Private Sub LlenarDatosRobo(ByVal objRobo As e_Robo)
        Try
            LimpiarRobo()
            If objRobo Is Nothing Then Return
            With objRobo
                fecRobo.Value = .FechaHora
                hRobo.Value = .FechaHora
                cboTipoRobo.Value = .IdTipo.Trim
                cboOperadorRobo.Value = .IdOperador.Trim
                cboLugarRobo.Value = .IdUbicacion.Trim
                cboEstadoRobo.Value = .Estado.Trim
                txtReferenciaLugarRobo.Text = .ReferenciaLugar.Trim
                txtDetalleRobo.Text = .Descripcion.Trim
                chkDenunciaRobo.Checked = .Denuncia
                fecDenunciaRobo.Value = .FechaHoraDenuncia
                hDenunciaRobo.Value = .FechaHoraDenuncia
                txtObservacionRobo.Text = .Observacion.Trim
                griAreaRoboAsignada.DataSource = objRobo.leAreaRobo
                griAreaRoboAsignada.DataBind()
            End With
            For Each oe As e_AreaResponsableEvento In objRobo.leAreaRobo
                For Each Fila As UltraWinGrid.UltraGridRow In griAreasRobo.Rows
                    If Fila.Cells("Id").Value.Trim = oe.IdArea.Trim And oe.Activo Then
                        Fila.Cells("Selec").Value = True
                        Fila.Fixed = True
                        Exit For
                    End If
                Next
            Next
            oeRobo = objRobo
            NuevoRobo = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub LimpiarViaje()
        txtIdSeguimiento.Text = String.Empty
        txtCodigoOperacion.Text = String.Empty
        txtCodigoViaje.Text = String.Empty
        txtViajeTracto.Text = String.Empty
        txtViajeCarreta.Text = String.Empty
        fecViaje.Value = Date.Now
        txtViajeOrigen.Text = String.Empty
        txtViajeDestino.Text = String.Empty
        txtViajePiloto.Text = String.Empty
        txtViajeCopiloto.Text = String.Empty
        txtViajeEscala.Text = String.Empty
        cboActividadNegocio.Value = 0
    End Sub

    Private Sub LlenaCombos()
        ComboNormal(cboLugarAlarma, LugaresPublic, 0)
        ComboNormal(cboLugarAccidente, LugaresPublic, 0)
        ComboNormal(cboLugarIncidente, LugaresPublic, 0)
        ComboNormal(cboLugarRobo, LugaresPublic, 0)

        CargarTipoAlarma()
        CargarTipoAccidente()
        CargarTipoIncidente()
        CargarTipoRobo()

        'llenamos combo de tipo de eventos
        oeConcepto.Valor1 = ""
        oeConcepto.Nombre = "TODOS"
        ListaConcepto = New List(Of e_Concepto)
        ListaConcepto.Add(oeConcepto)
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "1"
        ListaConcepto.AddRange(loConcepto.Listar(oeConcepto))
        cboEventoBusqueda.DataSource = ListaConcepto
        cboEventoBusqueda.DisplayMember = "Nombre"
        cboEventoBusqueda.ValueMember = "Valor1"
        cboEventoBusqueda.SelectedIndex = 0
        'llenamos combo de estados de alarmas
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "4"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEstadoAlarma.DataSource = ListaConcepto
        cboEstadoAlarma.DisplayMember = "Nombre"
        cboEstadoAlarma.ValueMember = "Valor1"
        cboEstadoAlarma.SelectedIndex = 0
        'llenamos combo de estados de accidente
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "4"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEstadoAccidente.DataSource = ListaConcepto
        cboEstadoAccidente.DisplayMember = "Nombre"
        cboEstadoAccidente.ValueMember = "Valor1"
        cboEstadoAccidente.SelectedIndex = 0
        'llenamos combo de estados de incidente
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "4"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEstadoIncidente.DataSource = ListaConcepto
        cboEstadoIncidente.DisplayMember = "Nombre"
        cboEstadoIncidente.ValueMember = "Valor1"
        cboEstadoIncidente.SelectedIndex = 0
        'llenamos combo de estados de incidente
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "4"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        cboEstadoRobo.DataSource = ListaConcepto
        cboEstadoRobo.DisplayMember = "Nombre"
        cboEstadoRobo.ValueMember = "Valor1"
        cboEstadoRobo.SelectedIndex = 0

        'definir tiempo maximo de viaje
        oeConcepto = New e_Concepto
        oeConcepto.Activo = True
        oeConcepto.Prefijo = "9"
        ListaConcepto = loConcepto.Listar(oeConcepto)
        TiempoMaximoViaje = Long.Parse(ListaConcepto(0).Valor1.Trim)

        'ComboNormal(cboTipoAlarma, TipoAlarmaPublic, 0)
        Dim oeCombo As e_Combo = New e_Combo
        Dim olCombo As l_Combo = New l_Combo

        oeCombo = New e_Combo
        olCombo = New l_Combo
        Dim ListCombo As List(Of e_Combo) = New List(Of e_Combo)
        oeCombo.Nombre = "EMPRESAINDICADOR"
        oeCombo.Descripcion = "GPS"
        ListCombo.AddRange(olCombo.Listar(oeCombo))
        ComboNormal(cboOperador, ListCombo, 0)
        ComboNormal(cboOperadorAccidente, ListCombo, 0)
        ComboNormal(cboOperadorIncidente, ListCombo, 0)
        ComboNormal(cboOperadorRobo, ListCombo, 0)

        OperacionesPublic = New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = ""
        OperacionesPublic.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "VENTAS"
        OperacionesPublic.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        LlenarComboMaestro(cboActividadNegocio, OperacionesPublic, 0)
        ''''''''''''''
        Dim Areas As New List(Of e_Combo)
        oeCombo = New e_Combo
        oeCombo.Id = ""
        oeCombo.Nombre = "TODOS"
        Areas.Add(oeCombo)
        oeCombo = New e_Combo
        oeCombo.Nombre = "Areas"
        Areas.AddRange(olCombo.Listar(oeCombo).OrderBy(Function(Item) Item.Nombre).ToList)
        ComboNormal(cboAreaBuscar, Areas, 0)
        ''''''''''''''
        ColorPendiente.Color = Color.GreenYellow
        ColorFinalizado.Color = Color.LightBlue
        '''''
        CargarAreas()
    End Sub

    Private Sub CargarAreas()
        Try
            Dim leArea As l_Area = New l_Area
            Dim oeArea As e_Area = New e_Area
            Dim listaArea As List(Of e_Area)
            listaArea = leArea.Listar(oeArea)
            With griAreas
                .ResetDisplayLayout()
                Dim lista = From la In listaArea Select la.Id, la.Codigo, la.Nombre
                .DataSource = lista.ToList
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Selec")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 145
            End With
            listaAreaAlarma = New List(Of e_AreaResponsableEvento)
            griAreasAlarma.DataSource = listaAreaAlarma
            griAreasAlarma.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarAreasAccidente()
        Try
            Dim leArea As l_Area = New l_Area
            Dim oeArea As e_Area = New e_Area
            Dim listaArea As List(Of e_Area)
            listaArea = leArea.Listar(oeArea)
            With griAreasAccidente
                .ResetDisplayLayout()
                Dim lista = From la In listaArea Select la.Id, la.Codigo, la.Nombre
                .DataSource = lista.ToList
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Selec")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 145
            End With
            listaAreaAccidente = New List(Of e_AreaResponsableEvento)
            griAreasAccidenteAsignado.DataSource = listaAreaAccidente
            griAreasAccidenteAsignado.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarAreasIncidente()
        Try
            Dim leArea As l_Area = New l_Area
            Dim oeArea As e_Area = New e_Area
            Dim listaArea As List(Of e_Area)
            listaArea = leArea.Listar(oeArea)
            With griAreasIncidentes
                .ResetDisplayLayout()
                Dim lista = From la In listaArea Select la.Id, la.Codigo, la.Nombre
                .DataSource = lista.ToList
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Selec")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 145
            End With
            listaAreaIncidente = New List(Of e_AreaResponsableEvento)
            griAreasIncidentesAsignados.DataSource = listaAreaIncidente
            griAreasIncidentesAsignados.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarAreasRobo()
        Try
            Dim leArea As l_Area = New l_Area
            Dim oeArea As e_Area = New e_Area
            Dim listaArea As List(Of e_Area)
            listaArea = leArea.Listar(oeArea)
            With griAreasRobo
                .ResetDisplayLayout()
                Dim lista = From la In listaArea Select la.Id, la.Codigo, la.Nombre
                .DataSource = lista.ToList
                .DisplayLayout.Bands(0).Columns.Add("Selec", "Selec")
                .DisplayLayout.Bands(0).Columns("Selec").DataType = System.Type.GetType("System.Boolean")
                .DisplayLayout.Bands(0).Columns("Selec").DefaultCellValue = False
                .DisplayLayout.Bands(0).Columns("Selec").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Selec").Width = 30
                .DisplayLayout.Bands(0).Columns("Id").Hidden = True
                .DisplayLayout.Bands(0).Columns("Codigo").Hidden = True
                .DisplayLayout.Bands(0).Columns("Nombre").Header.Caption = "Area"
                .DisplayLayout.Bands(0).Columns("Nombre").Width = 145
            End With
            listaAreaRobo = New List(Of e_AreaResponsableEvento)
            griAreaRoboAsignada.DataSource = listaAreaRobo
            griAreaRoboAsignada.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarAreaAlarma()
        With griAreasAlarma
            .DataSource = listaAreaAlarma
        End With
    End Sub
    Private Sub LlenarAreaAccidente()
        With griAreasAccidenteAsignado
            .DataSource = listaAreaAccidente
        End With
    End Sub
    Private Sub LlenarAreaIncidente()
        With griAreasIncidentesAsignados
            .DataSource = listaAreaIncidente
        End With
    End Sub
    Private Sub LlenarAreaRobo()
        With griAreaRoboAsignada
            .DataSource = listaAreaRobo
        End With
    End Sub

    Private Sub AgregarAlarma()
        Try
            If txtCodigoViaje.Text = "" Then
                Me.btnBuscar.Focus()
                mensajeEmergente.Problema("Debe Seleccionar un Viaje.", True)
                Return
            End If
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaViaje As Date = Date.Parse(Me.fecViaje.Value)
            Dim fechaEvento As Date = Date.Parse(Me.fecAlarma.Value.ToShortDateString & " " & Me.hAlarma.Value.ToShortTimeString)
            Dim TiempoEvento As Long = DateDiff(DateInterval.Minute, fechaViaje, fechaEvento)
            If TiempoEvento > TiempoMaximoViaje Or TiempoEvento < 0 Then
                Me.fecAlarma.Focus()
                mensajeEmergente.Problema("Fecha Evento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje.", True)
                Return
            End If
            Dim lisAreaAlarma As New List(Of e_AreaResponsableEvento)
            lisAreaAlarma = griAreasAlarma.DataSource
            oeIncidenciaMaestro.lstAlarma = griListaAlarmas.DataSource
            If NuevoAlarma Or oeIncidenciaMaestro.lstAlarma.Count = 0 Then
                With oeAlarma
                    .Id = ""
                    .TipoOperacion = "I"
                    .IdTipoEvento = "2"
                    .IdViaje = oeIncidenciaMaestro.IdViaje
                    .IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                    .Operador = cboOperador.Text
                    .IdTipo = cboTipoAlarma.Value
                    .Tipo = cboTipoAlarma.Text
                    .IdUbicacion = cboLugarAlarma.Value
                    .Ubicacion = cboLugarAlarma.Text
                    .ReferenciaLugar = txtReferenciaLugarAlarma.Text
                    .FechaHora = Date.Parse(Me.fecAlarma.Value.ToShortDateString & " " & Me.hAlarma.Value.ToShortTimeString)
                    .Observacion = txtObservacionAlarma.Text
                    .Estado = cboEstadoAlarma.Value
                    .NombreEstado = cboEstadoAlarma.Text
                    .Descripcion = txtDetalleAlarma.Text
                    .Observacion = txtObservacionAlarma.Text
                    .Codigo = ""
                    .FechaCreacion = DateTime.Now
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                    .FechaModifica = DateTime.Now
                    .UsuarioModifica = gUsuarioSGI.Id
                    .Identificador = DateTime.Now.Ticks
                End With
                oeAlarma.leAreaAlarma = lisAreaAlarma
                oeIncidenciaMaestro.lstAlarma.Add(oeAlarma)
            Else
                If oeIncidenciaMaestro.lstAlarma.Contains(oeAlarma) Then
                    With oeIncidenciaMaestro.lstAlarma.Item(oeIncidenciaMaestro.lstAlarma.IndexOf(oeAlarma))
                        .IdOperador = IIf(cboOperador.Value = Nothing, "", cboOperador.Value)
                        .Operador = cboOperador.Text
                        .IdTipo = cboTipoAlarma.Value
                        .Tipo = cboTipoAlarma.Text
                        .IdUbicacion = cboLugarAlarma.Value
                        .Ubicacion = cboLugarAlarma.Text
                        .ReferenciaLugar = txtReferenciaLugarAlarma.Text
                        .FechaHora = Date.Parse(Me.fecAlarma.Value.ToShortDateString & " " & Me.hAlarma.Value.ToShortTimeString)
                        .Observacion = txtObservacionAlarma.Text
                        .Estado = cboEstadoAlarma.Value
                        .NombreEstado = cboEstadoAlarma.Text
                        .Descripcion = txtDetalleAlarma.Text
                        .Observacion = txtObservacionAlarma.Text
                        .Activo = True
                        .FechaModifica = DateTime.Now
                        .UsuarioModifica = gUsuarioSGI.Id
                        .leAreaAlarma = lisAreaAlarma
                    End With
                End If
            End If
            btnBuscar.Enabled = False
            griListaAlarmas.DataSource = oeIncidenciaMaestro.lstAlarma
            'griListaAlarmas.Update()
            griListaAlarmas.DataBind()
            oeAlarma = New e_Alarma()
            LimpiarAlarma()
            CargarAreasConfiguradasAlarma("2", cboTipoAlarma.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AgregarAccidente()
        Try
            If txtCodigoViaje.Text = "" Then
                Me.btnBuscar.Focus()
                mensajeEmergente.Problema("Debe Seleccionar un Viaje.", True)
                Return
            End If
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaViaje As Date = Date.Parse(Me.fecViaje.Value)
            Dim fechaEvento As Date = Date.Parse(Me.fecAccidente.Value.ToShortDateString & " " & Me.hAccidente.Value.ToShortTimeString)
            Dim TiempoEvento As Long = DateDiff(DateInterval.Minute, fechaViaje, fechaEvento)
            If TiempoEvento > 10080 Or TiempoEvento < 0 Then
                Me.fecAccidente.Focus()
                mensajeEmergente.Problema("Fecha Evento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje.", True)
                Return
            End If
            Dim lisAreaAccidenteAsignada As New List(Of e_AreaResponsableEvento)
            lisAreaAccidenteAsignada = griAreasAccidenteAsignado.DataSource
            oeIncidenciaMaestro.lstAccidente = griListaAccidentes.DataSource
            If NuevoAccidente Or oeIncidenciaMaestro.lstAccidente.Count = 0 Then
                With oeAccidente
                    .Id = ""
                    .TipoOperacion = "I"
                    .IdTipoEvento = "3"
                    .IdViaje = oeIncidenciaMaestro.IdViaje
                    '.IdOperador = cboOperadorAccidente.Value
                    .IdOperador = IIf(cboOperadorAccidente.Value = Nothing, "", cboOperadorAccidente.Value)
                    .Operador = cboOperadorAccidente.Text
                    .IdTipo = cboTipoAccidente.Value
                    .Tipo = cboTipoAccidente.Text
                    .IdUbicacion = cboLugarAccidente.Value
                    .Ubicacion = cboLugarAccidente.Text
                    .ReferenciaLugar = txtReferenciaLugarAccidente.Text
                    .Descripcion = txtDetalleAccidente.Text
                    .Observacion = txtObservacionAccidente.Text
                    .FechaHora = Date.Parse(Me.fecAccidente.Value.ToShortDateString & " " & Me.hAccidente.Value.ToShortTimeString)
                    .Estado = cboEstadoAccidente.Value
                    .NombreEstado = cboEstadoAccidente.Text
                    .Denuncia = chkDenunciaAccidente.Checked
                    .FechaHoraDenuncia = Date.Parse(Me.fecDenunciaAccidente.Value.ToShortDateString & " " & Me.hDenunciaAccidente.Value.ToShortTimeString)
                    .Dosaje = chkDosajeAccidente.Checked
                    .FechaHoraDosaje = Date.Parse(Me.fecDosajeAccidente.Value.ToShortDateString & " " & Me.hDosajeAccidente.Value.ToShortTimeString)
                    .Codigo = ""
                    .FechaCreacion = DateTime.Now
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                    .FechaModifica = DateTime.Now
                    .UsuarioModifica = gUsuarioSGI.Id
                    .Identificador = DateTime.Now.Ticks
                End With
                oeAccidente.leAreaAccidente = lisAreaAccidenteAsignada
                oeIncidenciaMaestro.lstAccidente.Add(oeAccidente)
            Else
                If oeIncidenciaMaestro.lstAccidente.Contains(oeAccidente) Then
                    With oeIncidenciaMaestro.lstAccidente.Item(oeIncidenciaMaestro.lstAccidente.IndexOf(oeAccidente))
                        '.IdOperador = cboOperadorAccidente.Value
                        .IdOperador = IIf(cboOperadorAccidente.Value = Nothing, "", cboOperadorAccidente.Value)
                        .Operador = cboOperadorAccidente.Text
                        .IdTipo = cboTipoAccidente.Value
                        .Tipo = cboTipoAccidente.Text
                        .IdUbicacion = cboLugarAccidente.Value
                        .Ubicacion = cboLugarAccidente.Text
                        .ReferenciaLugar = txtReferenciaLugarAccidente.Text
                        .Descripcion = txtDetalleAccidente.Text
                        .Observacion = txtObservacionAccidente.Text
                        .FechaHora = Date.Parse(Me.fecAccidente.Value.ToShortDateString & " " & Me.hAccidente.Value.ToShortTimeString)
                        .Estado = cboEstadoAccidente.Value
                        .Denuncia = chkDenunciaAccidente.Checked
                        .FechaHoraDenuncia = Date.Parse(Me.fecDenunciaAccidente.Value.ToShortDateString & " " & Me.hDenunciaAccidente.Value.ToShortTimeString)
                        .Dosaje = chkDosajeAccidente.Checked
                        .FechaHoraDosaje = Date.Parse(Me.fecDosajeAccidente.Value.ToShortDateString & " " & Me.hDosajeAccidente.Value.ToShortTimeString)
                        .FechaModifica = DateTime.Now
                        .UsuarioModifica = gUsuarioSGI.Id
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .leAreaAccidente = lisAreaAccidenteAsignada
                    End With
                End If
            End If
            btnBuscar.Enabled = False
            griListaAccidentes.DataSource = oeIncidenciaMaestro.lstAccidente
            griListaAccidentes.DataBind()
            oeAccidente = New e_AccidenteIncidencia()
            LimpiarAccidente()
            CargarAreasConfiguradasAccidente("3", cboTipoAccidente.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AgregarIncidente()
        Try
            If txtCodigoViaje.Text = "" Then
                Me.btnBuscar.Focus()
                mensajeEmergente.Problema("Debe Seleccionar un Viaje.", True)
                Return
            End If
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaViaje As Date = Date.Parse(Me.fecViaje.Value)
            Dim fechaEvento As Date = Date.Parse(Me.fecIncidente.Value.ToShortDateString & " " & Me.hIncidente.Value.ToShortTimeString)
            Dim TiempoEvento As Long = DateDiff(DateInterval.Minute, fechaViaje, fechaEvento)
            If TiempoEvento > 10080 Or TiempoEvento < 0 Then
                Me.fecIncidente.Focus()
                mensajeEmergente.Problema("Fecha Evento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje.", True)
                Return
            End If
            Dim lisAreaIncidente As New List(Of e_AreaResponsableEvento)
            lisAreaIncidente = griAreasIncidentesAsignados.DataSource
            oeIncidenciaMaestro.lstIncidente = griListaIncidentes.DataSource
            If NuevoIncidente Or oeIncidenciaMaestro.lstIncidente.Count = 0 Then
                With oeIncidente
                    .Id = ""
                    .TipoOperacion = "I"
                    .IdTipoEvento = "7"
                    .IdViaje = oeIncidenciaMaestro.IdViaje
                    '.IdOperador = cboOperadorIncidente.Value
                    .IdOperador = IIf(cboOperadorIncidente.Value = Nothing, "", cboOperadorIncidente.Value)
                    .Operador = cboOperadorIncidente.Text
                    .IdTipo = cboTipoIncidente.Value
                    .Tipo = cboTipoIncidente.Text
                    .IdUbicacion = cboLugarIncidente.Value
                    .Ubicacion = cboLugarIncidente.Text
                    .ReferenciaLugar = txtReferenciaLugarIncidente.Text
                    .FechaHora = Date.Parse(Me.fecIncidente.Value.ToShortDateString & " " & Me.hIncidente.Value.ToShortTimeString)
                    .Estado = cboEstadoIncidente.Value
                    .NombreEstado = cboEstadoIncidente.Text
                    .Descripcion = txtDetalleIncidente.Text
                    .Observacion = txtObservacionIncidente.Text
                    .Codigo = ""
                    .FechaCreacion = DateTime.Now
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                    .FechaModifica = DateTime.Now
                    .UsuarioModifica = gUsuarioSGI.Id
                    .Identificador = DateTime.Now.Ticks
                End With
                oeIncidente.leAreaIncidente = lisAreaIncidente
                oeIncidenciaMaestro.lstIncidente.Add(oeIncidente)
            Else
                If oeIncidenciaMaestro.lstIncidente.Contains(oeIncidente) Then
                    With oeIncidenciaMaestro.lstIncidente.Item(oeIncidenciaMaestro.lstIncidente.IndexOf(oeIncidente))
                        '.IdOperador = cboOperadorIncidente.Value
                        .IdOperador = IIf(cboOperadorIncidente.Value = Nothing, "", cboOperadorIncidente.Value)
                        .Operador = cboOperadorIncidente.Text
                        .IdTipo = cboTipoIncidente.Value
                        .Tipo = cboTipoIncidente.Text
                        .IdUbicacion = cboLugarIncidente.Value
                        .Ubicacion = cboLugarIncidente.Text
                        .ReferenciaLugar = txtReferenciaLugarIncidente.Text
                        .FechaHora = Date.Parse(Me.fecIncidente.Value.ToShortDateString & " " & Me.hIncidente.Value.ToShortTimeString)
                        .Estado = cboEstadoIncidente.Value
                        .NombreEstado = cboEstadoIncidente.Text
                        .Descripcion = txtDetalleIncidente.Text
                        .Observacion = txtObservacionIncidente.Text
                        .Activo = True
                        .FechaModifica = DateTime.Now
                        .UsuarioModifica = gUsuarioSGI.Id
                        .leAreaIncidente = lisAreaIncidente
                    End With
                End If
            End If
            btnBuscar.Enabled = False
            griListaIncidentes.DataSource = oeIncidenciaMaestro.lstIncidente
            griListaIncidentes.DataBind()
            oeIncidente = New e_Incidente()
            LimpiarIncidente()
            CargarAreasConfiguradasIncidente("7", cboTipoIncidente.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub AgregarRobo()
        Try
            If txtCodigoViaje.Text = "" Then
                Me.btnBuscar.Focus()
                mensajeEmergente.Problema("Debe Seleccionar un Viaje.", True)
                Return
            End If
            Dim DiasLimiteViaje As Integer = TiempoMaximoViaje / 1440
            Dim fechaViaje As Date = Date.Parse(Me.fecViaje.Value)
            Dim fechaEvento As Date = Date.Parse(Me.fecRobo.Value.ToShortDateString & " " & Me.hRobo.Value.ToShortTimeString)
            Dim TiempoEvento As Long = DateDiff(DateInterval.Minute, fechaViaje, fechaEvento)
            If TiempoEvento > 10080 Or TiempoEvento < 0 Then
                Me.fecRobo.Focus()
                mensajeEmergente.Problema("Fecha Evento debe estar entre los primeros " & DiasLimiteViaje & " días del viaje.", True)
                Return
            End If
            Dim lisAreaRoboAsignada As New List(Of e_AreaResponsableEvento)
            lisAreaRoboAsignada = griAreaRoboAsignada.DataSource
            oeIncidenciaMaestro.lstRobo = griListaRobos.DataSource
            If NuevoRobo Or oeIncidenciaMaestro.lstRobo.Count = 0 Then
                With oeRobo
                    .Id = ""
                    .TipoOperacion = "I"
                    .IdTipoEvento = "6"
                    .IdViaje = oeIncidenciaMaestro.IdViaje
                    '.IdOperador = cboOperadorRobo.Value
                    .IdOperador = IIf(cboOperadorRobo.Value = Nothing, "", cboOperadorRobo.Value)
                    .Operador = cboOperadorRobo.Text
                    .IdTipo = cboTipoRobo.Value
                    .Tipo = cboTipoRobo.Text
                    .IdUbicacion = cboLugarRobo.Value
                    .Ubicacion = cboLugarRobo.Text
                    .ReferenciaLugar = txtReferenciaLugarRobo.Text
                    .Descripcion = txtDetalleRobo.Text
                    .Observacion = txtObservacionRobo.Text
                    .FechaHora = Date.Parse(Me.fecRobo.Value.ToShortDateString & " " & Me.hRobo.Value.ToShortTimeString)
                    .Estado = cboEstadoRobo.Value
                    .NombreEstado = cboEstadoRobo.Text
                    .Denuncia = chkDenunciaRobo.Checked
                    .FechaHoraDenuncia = Date.Parse(Me.fecDenunciaRobo.Value.ToShortDateString & " " & Me.hDenunciaRobo.Value.ToShortTimeString)
                    .Codigo = ""
                    .FechaCreacion = DateTime.Now
                    .UsuarioCreacion = gUsuarioSGI.Id
                    .Activo = True
                    .FechaModifica = DateTime.Now
                    .UsuarioModifica = gUsuarioSGI.Id
                    .Identificador = DateTime.Now.Ticks
                End With
                oeRobo.leAreaRobo = lisAreaRoboAsignada
                oeIncidenciaMaestro.lstRobo.Add(oeRobo)
            Else
                If oeIncidenciaMaestro.lstRobo.Contains(oeRobo) Then
                    With oeIncidenciaMaestro.lstRobo.Item(oeIncidenciaMaestro.lstRobo.IndexOf(oeRobo))
                        '.IdOperador = cboOperadorRobo.Value
                        .IdOperador = IIf(cboOperadorRobo.Value = Nothing, "", cboOperadorRobo.Value)
                        .Operador = cboOperadorRobo.Text
                        .IdTipo = cboTipoRobo.Value
                        .Tipo = cboTipoRobo.Text
                        .IdUbicacion = cboLugarRobo.Value
                        .Ubicacion = cboLugarRobo.Text
                        .ReferenciaLugar = txtReferenciaLugarRobo.Text
                        .Descripcion = txtDetalleRobo.Text
                        .Observacion = txtObservacionRobo.Text
                        .FechaHora = Date.Parse(Me.fecRobo.Value.ToShortDateString & " " & Me.hRobo.Value.ToShortTimeString)
                        .Estado = cboEstadoRobo.Value
                        .Denuncia = chkDenunciaRobo.Checked
                        .FechaHoraDenuncia = Date.Parse(Me.fecDenunciaRobo.Value.ToShortDateString & " " & Me.hDenunciaRobo.Value.ToShortTimeString)
                        .FechaModifica = DateTime.Now
                        .UsuarioModifica = gUsuarioSGI.Id
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .leAreaRobo = lisAreaRoboAsignada
                    End With
                End If
            End If
            btnBuscar.Enabled = False
            griListaRobos.DataSource = oeIncidenciaMaestro.lstRobo
            griListaRobos.DataBind()
            oeRobo = New e_Robo()
            LimpiarRobo()
            CargarAreasConfiguradasRobo("6", cboTipoRobo.Value)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarIncidencia() As Boolean
        Try
            If oeIncidenciaMaestro.IdViaje <> "" Then
                Dim numeroRegistros As Integer = 0
                numeroRegistros = griListaAlarmas.Rows.Count + griListaAccidentes.Rows.Count + griListaIncidentes.Rows.Count + griListaRobos.Rows.Count
                If numeroRegistros > 0 Then
                    oeIncidenciaMaestro.Id = String.Empty
                    oeIncidenciaMaestro.lstAlarma = griListaAlarmas.DataSource
                    oeIncidenciaMaestro.lstAccidente = griListaAccidentes.DataSource
                    oeIncidenciaMaestro.lstIncidente = griListaIncidentes.DataSource
                    oeIncidenciaMaestro.lstRobo = griListaRobos.DataSource
                    oeIncidenciaMaestro.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olIncidenciaMaestro.Guardar(oeIncidenciaMaestro) Then
                        mensajeEmergente.Confirmacion("La informacion ha sido grabada satisfactoriamente en " & Me.Text, True)
                        MostrarTabs(0, tcIncidencia, 2)
                        Consultar(True)
                        griListaIncidencia.Focus()
                        Return True
                    End If
                Else
                    mensajeEmergente.Problema("Debe Realizar Mínimo Un Registro...", True)
                End If
            Else
                mensajeEmergente.Problema("Debe Seleccionar un Viaje...", True)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            If tabListado.Tabs(0).Selected = True Then ' tab Listado General
                Dim listaAlarma As New List(Of e_Alarma)
                If cboEventoBusqueda.Value = "" Or cboEventoBusqueda.Value = "2" Then
                    oeAlarma = New e_Alarma
                    oeAlarma.FechaDesde = fecDesde.DateTime.ToString("dd/MM/yyyy")
                    oeAlarma.FechaHasta = fecHasta.DateTime.ToString("dd/MM/yyyy")
                    listaAlarma = olAlarma.Listar(oeAlarma)
                End If

                Dim listaAccidente As New List(Of e_AccidenteIncidencia)
                If cboEventoBusqueda.Value = "" Or cboEventoBusqueda.Value = "3" Then
                    oeAccidente = New e_AccidenteIncidencia
                    oeAccidente.FechaDesde = fecDesde.DateTime.ToString("dd/MM/yyyy")
                    oeAccidente.FechaHasta = fecHasta.DateTime.ToString("dd/MM/yyyy")
                    listaAccidente = olAccidente.Listar(oeAccidente)
                End If

                Dim listaIncidente As New List(Of e_Incidente)
                If cboEventoBusqueda.Value = "" Or cboEventoBusqueda.Value = "7" Then
                    oeIncidente = New e_Incidente
                    oeIncidente.FechaDesde = fecDesde.DateTime.ToString("dd/MM/yyyy")
                    oeIncidente.FechaHasta = fecHasta.DateTime.ToString("dd/MM/yyyy")
                    listaIncidente = olIncidente.Listar(oeIncidente)
                End If

                Dim listaRobo As New List(Of e_Robo)
                If cboEventoBusqueda.Value = "" Or cboEventoBusqueda.Value = "6" Then
                    oeRobo = New e_Robo
                    oeRobo.FechaDesde = fecDesde.DateTime.ToString("dd/MM/yyyy")
                    oeRobo.FechaHasta = fecHasta.DateTime.ToString("dd/MM/yyyy")
                    listaRobo = olRobo.Listar(oeRobo)
                End If

                Dim ListaEventos = (From la In listaAlarma _
                                    Select la.Id, la.Codigo, la.IdViaje, la.FechaHora, la.IdUbicacion, la.ReferenciaLugar, _
                                    la.Descripcion, la.IdTipoEvento, la.TipoEvento, la.IdTipo, la.Tipo, la.Ubicacion, _
                                    la.Estado, la.NombreEstado, la.CodigoViaje, la.Origen, la.Destino, la.Escala, _
                                    la.Piloto, la.Copiloto, la.Tracto, la.TipoVehiculo, la.Carreta, la.Fecha, la.Cliente, _
                                    la.PesoToneladas, la.CargaMaterial, la.Observacion, la.FechaCreacion, la.FechaModifica, _
                                    la.IdOperador, la.Operador) _
                                    .Union _
                                    (From lac In listaAccidente _
                                    Select lac.Id, lac.Codigo, lac.IdViaje, lac.FechaHora, lac.IdUbicacion, lac.ReferenciaLugar, _
                                    lac.Descripcion, lac.IdTipoEvento, lac.TipoEvento, lac.IdTipo, lac.Tipo, lac.Ubicacion, _
                                    lac.Estado, lac.NombreEstado, lac.CodigoViaje, lac.Origen, lac.Destino, lac.Escala, _
                                    lac.Piloto, lac.Copiloto, lac.Tracto, lac.TipoVehiculo, lac.Carreta, lac.Fecha, lac.Cliente, _
                                    lac.PesoToneladas, lac.CargaMaterial, lac.Observacion, lac.FechaCreacion, lac.FechaModifica, _
                                    lac.IdOperador, lac.Operador) _
                                    .Union _
                                    (From li In listaIncidente _
                                    Select li.Id, li.Codigo, li.IdViaje, li.FechaHora, li.IdUbicacion, li.ReferenciaLugar, _
                                    li.Descripcion, li.IdTipoEvento, li.TipoEvento, li.IdTipo, li.Tipo, li.Ubicacion, _
                                    li.Estado, li.NombreEstado, li.CodigoViaje, li.Origen, li.Destino, li.Escala, _
                                    li.Piloto, li.Copiloto, li.Tracto, li.TipoVehiculo, li.Carreta, li.Fecha, li.Cliente, _
                                    li.PesoToneladas, li.CargaMaterial, li.Observacion, li.FechaCreacion, li.FechaModifica, _
                                    li.IdOperador, li.Operador) _
                                    .Union _
                                    (From lr In listaRobo _
                                    Select lr.Id, lr.Codigo, lr.IdViaje, lr.FechaHora, lr.IdUbicacion, lr.ReferenciaLugar, _
                                    lr.Descripcion, lr.IdTipoEvento, lr.TipoEvento, lr.IdTipo, lr.Tipo, lr.Ubicacion, _
                                    lr.Estado, lr.NombreEstado, lr.CodigoViaje, lr.Origen, lr.Destino, lr.Escala, _
                                    lr.Piloto, lr.Copiloto, lr.Tracto, lr.TipoVehiculo, lr.Carreta, lr.Fecha, lr.Cliente, _
                                    lr.PesoToneladas, lr.CargaMaterial, lr.Observacion, lr.FechaCreacion, lr.FechaModifica, _
                                    lr.IdOperador, lr.Operador)

                griListaIncidencia.DataSource = ListaEventos.ToList
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaIncidencia.Rows
                    Select Case fila.Cells("Estado").Value
                        Case "1"
                            fila.CellAppearance.BackColor = Me.ColorPendiente.Color
                        Case "2"
                            fila.CellAppearance.BackColor = Me.ColorFinalizado.Color
                    End Select
                Next
                griListaIncidencia.DataBind()
            ElseIf tabListado.Tabs(1).Selected = True Then ' tab Listado Area Responsable
                Dim listaAreaResponsabeEvento As New List(Of e_AreaResponsableEvento)
                Dim oeAreaResponsableEvento As New e_AreaResponsableEvento
                listaAreaResponsabeEvento = olAreaResponsableEvento.Listar(oeAreaResponsableEvento)

                Dim fechaDesde As DateTime = fecDesde.DateTime.Date & " 00:00:00"
                Dim fechaHasta As DateTime = fecHasta.DateTime.Date & " 23:59:59"

                Dim lista = From l In listaAreaResponsabeEvento Where l.FechaIncidencia >= fechaDesde And l.FechaIncidencia <= fechaHasta _
                     And l.IdTipoEvento.Trim = IIf(cboEventoBusqueda.Value = "", l.IdTipoEvento.Trim, cboEventoBusqueda.Value.ToString.Trim) _
                     And l.IdArea.Trim = IIf(cboAreaBuscar.Value = "", l.IdArea.Trim, cboAreaBuscar.Value.ToString.Trim)

                'listaAreaResponsabeEvento = lista.ToList
                griListaCerrarIncidencia.DataSource = lista.ToList
                llenaCombosGrilla()
                For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griListaCerrarIncidencia.Rows
                    Select Case fila.Cells("IdEstado").Value
                        Case "1"
                            fila.CellAppearance.BackColor = Me.ColorGenerado.Color
                        Case "2"
                            fila.CellAppearance.BackColor = Me.ColorFinalizadoArea.Color
                    End Select
                Next
                griListaCerrarIncidencia.DataBind()

            End If
            

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub llenaCombosGrilla()
        For j As Integer = 0 To griListaCerrarIncidencia.Rows.Count - 1
            'llenamos combo de estados de alarmas
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "5"
            Dim dt As New DataTable
            dt = loConcepto.ComboGrilla(oeConcepto)
            CrearComboGridPorCelda("IdEstado", "Valor1", "Nombre", j, griListaCerrarIncidencia, dt, True)
        Next
    End Sub

    Private Sub CargarEditar()
        Try
            Dim Id As String = griListaIncidencia.ActiveRow.Cells("Id").Value.ToString.Trim
            Dim IdViaje As String = griListaIncidencia.ActiveRow.Cells("IdViaje").Value.ToString.Trim
            Dim IdTipoEvento As String = griListaIncidencia.ActiveRow.Cells("IdTipoEvento").Value.ToString.Trim
            CargarGrillasDetalle(Id, IdViaje, IdTipoEvento)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub CargarTipoAlarma()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "2"
            ListaConcepto = loConcepto.Listar(oeConcepto)
            cboTipoAlarma.DataSource = ListaConcepto
            cboTipoAlarma.DisplayMember = "Nombre"
            cboTipoAlarma.ValueMember = "Valor1"
            cboTipoAlarma.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarTipoAccidente()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "3"
            ListaConcepto = loConcepto.Listar(oeConcepto)
            cboTipoAccidente.DataSource = ListaConcepto
            cboTipoAccidente.DisplayMember = "Nombre"
            cboTipoAccidente.ValueMember = "Valor1"
            cboTipoAccidente.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarTipoIncidente()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "7"
            ListaConcepto = loConcepto.Listar(oeConcepto)
            cboTipoIncidente.DataSource = ListaConcepto
            cboTipoIncidente.DisplayMember = "Nombre"
            cboTipoIncidente.ValueMember = "Valor1"
            cboTipoIncidente.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CargarTipoRobo()
        Try
            oeConcepto = New e_Concepto
            oeConcepto.Activo = True
            oeConcepto.Prefijo = "6"
            ListaConcepto = loConcepto.Listar(oeConcepto)
            cboTipoRobo.DataSource = ListaConcepto
            cboTipoRobo.DisplayMember = "Nombre"
            cboTipoRobo.ValueMember = "Valor1"
            cboTipoRobo.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGrillasDetalle(ByVal Id As String, ByVal IdViaje As String, ByVal IdTipoEvento As String)
        Try
            oeIncidenciaMaestro.IdViaje = IdViaje

            Dim objViaje As New e_Viaje
            objViaje.Id = IdViaje
            objViaje.TipoOperacion = "G"
            oeViaje = olOperacion.ObtenerViaje(objViaje)
            LlenarDatosViaje(oeViaje)
            'alarma
            Dim listaAlarma As List(Of e_Alarma)
            oeAlarma = New e_Alarma
            oeAlarma.IdViaje = IdViaje
            listaAlarma = olAlarma.Listar(oeAlarma)

            For Each a As e_Alarma In listaAlarma
                Dim objAreaResponsableEvento As New e_AreaResponsableEvento
                objAreaResponsableEvento.IdEvento = a.Id
                objAreaResponsableEvento.IdTipoEvento = a.IdTipoEvento
                objAreaResponsableEvento.Activo = True
                Dim listaAreaResponsableEvento As New List(Of e_AreaResponsableEvento)
                a.leAreaAlarma = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
            Next
            listaAlarma.AddRange(griListaAlarmas.DataSource)
            griListaAlarmas.DataSource = listaAlarma
            griListaAlarmas.DataSource = listaAlarma
            griListaAlarmas.DataBind()
            'accidente
            Dim listaAccidente As List(Of e_AccidenteIncidencia)
            oeAccidente = New e_AccidenteIncidencia
            oeAccidente.IdViaje = IdViaje
            listaAccidente = olAccidente.Listar(oeAccidente)

            For Each a As e_AccidenteIncidencia In listaAccidente
                Dim objAreaResponsableEvento As New e_AreaResponsableEvento
                objAreaResponsableEvento.IdEvento = a.Id
                objAreaResponsableEvento.IdTipoEvento = a.IdTipoEvento
                objAreaResponsableEvento.Activo = True
                Dim listaAreaResponsableEvento As New List(Of e_AreaResponsableEvento)
                a.leAreaAccidente = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
            Next
            listaAccidente.AddRange(griListaAccidentes.DataSource)
            griListaAccidentes.DataSource = listaAccidente
            griListaAccidentes.DataBind()
            'incidente
            Dim listaIncidente As List(Of e_Incidente)
            oeIncidente = New e_Incidente
            oeIncidente.IdViaje = IdViaje
            listaIncidente = olIncidente.Listar(oeIncidente)

            For Each a As e_Incidente In listaIncidente
                Dim objAreaResponsableEvento As New e_AreaResponsableEvento
                objAreaResponsableEvento.IdEvento = a.Id
                objAreaResponsableEvento.IdTipoEvento = a.IdTipoEvento
                objAreaResponsableEvento.Activo = True
                Dim listaAreaResponsableEvento As New List(Of e_AreaResponsableEvento)
                a.leAreaIncidente = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
            Next
            listaIncidente.AddRange(griListaIncidentes.DataSource)
            griListaIncidentes.DataSource = listaIncidente
            griListaIncidentes.DataBind()
            'robo
            Dim listaRobo As List(Of e_Robo)
            oeRobo = New e_Robo
            oeRobo.IdViaje = IdViaje
            listaRobo = olRobo.Listar(oeRobo)

            For Each a As e_Robo In listaRobo
                Dim objAreaResponsableEvento As New e_AreaResponsableEvento
                objAreaResponsableEvento.IdEvento = a.Id
                objAreaResponsableEvento.IdTipoEvento = a.IdTipoEvento
                objAreaResponsableEvento.Activo = True
                Dim listaAreaResponsableEvento As New List(Of e_AreaResponsableEvento)
                a.leAreaRobo = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
            Next
            listaRobo.AddRange(griListaRobos.DataSource)
            griListaRobos.DataSource = listaRobo
            griListaRobos.DataBind()
            ''''''''
            If Id <> "" Then
                If IdTipoEvento = "2" Then
                    fichaDetalle.Tabs(0).Selected = True
                    oeAlarma = ObtenerAlarma(Id)
                    Dim objAreaResponsableEvento = New e_AreaResponsableEvento
                    objAreaResponsableEvento.IdEvento = Id
                    objAreaResponsableEvento.IdTipoEvento = IdTipoEvento
                    objAreaResponsableEvento.Activo = True
                    listaAreaAlarma = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
                    oeAlarma.leAreaAlarma = listaAreaAlarma
                    LlenarDatosAlarma(oeAlarma)
                    btnAgregarAlarma.Text = "Editar"
                ElseIf IdTipoEvento = "3" Then
                    fichaDetalle.Tabs(1).Selected = True
                    oeAccidente = ObtenerAccidente(Id)
                    Dim objAreaResponsableEvento = New e_AreaResponsableEvento
                    objAreaResponsableEvento.IdEvento = Id
                    objAreaResponsableEvento.IdTipoEvento = IdTipoEvento
                    objAreaResponsableEvento.Activo = True
                    listaAreaAccidente = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
                    oeAccidente.leAreaAccidente = listaAreaAccidente
                    LlenarDatosAccidente(oeAccidente)
                    btnAgregarAccidente.Text = "Editar"
                ElseIf IdTipoEvento = "7" Then
                    fichaDetalle.Tabs(2).Selected = True
                    oeIncidente = ObtenerIncidente(Id)
                    Dim objAreaResponsableEvento = New e_AreaResponsableEvento
                    objAreaResponsableEvento.IdEvento = Id
                    objAreaResponsableEvento.IdTipoEvento = IdTipoEvento
                    objAreaResponsableEvento.Activo = True
                    listaAreaIncidente = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
                    oeIncidente.leAreaIncidente = listaAreaIncidente
                    LlenarDatosIncidente(oeIncidente)
                    btnAgregarIncidente.Text = "Editar"
                ElseIf IdTipoEvento = "6" Then
                    fichaDetalle.Tabs(3).Selected = True
                    oeRobo = ObtenerRobo(Id)
                    Dim objAreaResponsableEvento = New e_AreaResponsableEvento
                    objAreaResponsableEvento.IdEvento = Id
                    objAreaResponsableEvento.IdTipoEvento = IdTipoEvento
                    objAreaResponsableEvento.Activo = True
                    listaAreaRobo = olAreaResponsableEvento.Listar(objAreaResponsableEvento)
                    oeRobo.leAreaRobo = listaAreaRobo
                    LlenarDatosRobo(oeRobo)
                    btnAgregarRobo.Text = "Editar"
                End If
            Else
                fichaDetalle.Tabs(0).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Function ObtenerAlarma(ByVal Id As String) As e_Alarma
        Try
            Dim alarma As e_Alarma = New e_Alarma
            alarma.Id = Id
            alarma.TipoOperacion = "O"
            alarma = olAlarma.Obtener(alarma)
            Return alarma
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ObtenerAccidente(ByVal Id As String) As e_AccidenteIncidencia
        Try
            Dim accidente As e_AccidenteIncidencia = New e_AccidenteIncidencia
            accidente.Id = Id
            accidente.TipoOperacion = "O"
            accidente = olAccidente.Obtener(accidente)
            Return accidente
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ObtenerIncidente(ByVal Id As String) As e_Incidente
        Try
            Dim indicente As New e_Incidente
            indicente.Id = Id
            indicente.TipoOperacion = "O"
            indicente = olIncidente.Obtener(indicente)
            Return indicente
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function ObtenerRobo(ByVal Id As String) As e_Robo
        Try
            Dim robo As New e_Robo
            robo.Id = Id
            robo.TipoOperacion = "O"
            robo = olRobo.Obtener(robo)
            Return robo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getBodyEmail() As String
        Try

            Dim estiloTh As String = "<th style='white-space: nowrap' text-align: left;vertical-align: top;border: 1px solid #000;border-collapse: collapse;padding: 0.3em;caption-side: bottom;>"
            Dim estiloTd As String = "<td style='white-space: nowrap' align='left' valign='top'>"
            Dim estiloLetra As String = "<tr valign='top'><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1.5px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
            Dim estiloLetraB As String = "<tr><td style='border-right-color:#000099; border-right-style:solid; border-right-width:1px;" +
                " border-top-color:#000099; border-top-style:solid; border-top-width:1px;' align='right'><font size='1.8' style='font-style: oblique; font-family:arial; color:#000000'>"
            Dim estiloLetraDetalle As String = "<th style='white-space: nowrap' bgcolor='#045FB4'><FONT FACE='raro, arial' SIZE=1.3 COLOR='#ffffff'>"
            Dim estiloLetraSC As String = "<td align='left'><FONT FACE='raro, arial' SIZE=1.5>"
            Dim estiloLetraSCB As String = "<td align='left' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
            Dim estiloLetraSCBD As String = "<td align='right' size='1.8' style='border-bottom-color:#000099; border-bottom-style:solid; border-bottom-width:1.5px;'><font size='2' style='font-style: oblique; font-family:arial; color:#045FB4'>"
            Dim estiloLetraDetalleSC As String = "<td style='white-space: nowrap'><FONT FACE='raro, arial' SIZE=1>"
            Dim cadena As String = ""

            cadena += "<table cellpadding='0' cellspacing='0'>" & estiloLetraSCBD & "DATOS DE EVENTO DE VIAJE </font></td></tr>"
            cadena += estiloLetra + "CODIGO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Codigo").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "EVENTO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("TipoEvento").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "TIPO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Tipo").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("FechaHora").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "OPERADOR:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Operador").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "UBICACIÓN:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Ubicacion").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "REFERENCIA LUGAR:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("ReferenciaLugar").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "DESCRIPCIÓN:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Descripcion").Value.ToString.Trim & "</font></td></tr>"
            cadena += "</table>"

            cadena += "<br><br>"

            cadena += "<table cellpadding='0' cellspacing='0'>" & estiloLetraSCBD & "DATOS DE VIAJE </font></td></tr>"
            cadena += estiloLetra + "CODIGO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("CodigoViaje").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "FECHA:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Fecha").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CLIENTE:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Cliente").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "ORIGEN:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Origen").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "DESTINO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Destino").Value.ToString.Trim & "</font></td></tr>"
            'cadena += estiloLetra + "ESCALA:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Escala").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "PILOTO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Piloto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "COPILOTO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Copiloto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "TRATO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Tracto").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "TIPO VEHÍCULO:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("TipoVehiculo").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CARRETA:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("Carreta").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "CARGA MATERIAL:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("CargaMaterial").Value.ToString.Trim & "</font></td></tr>"
            cadena += estiloLetra + "PESO TONELADAS:</font></td>" & estiloLetraSC & griListaIncidencia.ActiveRow.Cells("PesoToneladas").Value.ToString.Trim & "</font></td></tr>"
            cadena += "</table>"
            Return cadena
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

    
    Private Sub griListaCerrarIncidencia_ClickCellButton(sender As Object, e As CellEventArgs) Handles griListaCerrarIncidencia.ClickCellButton
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If e.Cell.Column.Key = "Glosa" Then
                Dim oeAreaResponsableEvento As New e_AreaResponsableEvento
                oeAreaResponsableEvento.Glosa = e.Cell.Text
                oeAreaResponsableEvento.UsuarioCreacion = gUsuarioSGI.Id
                oeAreaResponsableEvento.TipoOperacion = "G"
                oeAreaResponsableEvento.Id = griListaCerrarIncidencia.Rows(e.Cell.Row.Index).Cells("Id").Value
                oeAreaResponsableEvento.PrefijoID = gs_PrefijoIdSucursal '@0001
                olAreaResponsableEvento.GuardarGlosa(oeAreaResponsableEvento)
                mensajeEmergente.Confirmacion("La Informacion ha sido grabada Satisfactoriamente", True)
            End If
            If e.Cell.Column.Key = "GuardarEstado" Then
                Dim oeAreaResponsableEvento As New e_AreaResponsableEvento
                oeAreaResponsableEvento.UsuarioCreacion = gUsuarioSGI.Id
                oeAreaResponsableEvento.TipoOperacion = "S"
                oeAreaResponsableEvento.Id = griListaCerrarIncidencia.Rows(e.Cell.Row.Index).Cells("Id").Value
                oeAreaResponsableEvento.IdEstado = griListaCerrarIncidencia.Rows(e.Cell.Row.Index).Cells("IdEstado").Value
                oeAreaResponsableEvento.PrefijoID = gs_PrefijoIdSucursal '@0001
                olAreaResponsableEvento.GuardarEstado(oeAreaResponsableEvento)
                mensajeEmergente.Confirmacion("La Informacion ha sido grabada Satisfactoriamente", True)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(Me.Text & ": " & ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub griListaCerrarIncidencia_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griListaCerrarIncidencia.BeforeRowsDeleted
        Try
            e.DisplayPromptMsg = False
            e.Cancel = True
            Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

End Class