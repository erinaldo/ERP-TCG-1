Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frm_PlanillaPiloto
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializacion"

    Public Sub New()
        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        'Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared Instancia As frm_PlanillaPiloto = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        Operacion = "Inicializa"
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            Instancia = New frm_PlanillaPiloto()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de variables"

    Private WithEvents oePlanillaPiloto As New e_PlanillaPiloto
    Private olPlanillaPiloto As New l_PlanillaPiloto
    Private loPlanillaPiloto As New List(Of e_PlanillaPiloto)

    Private oePlanillaViaje As New e_PlanillaViaje
    Private olPlanillaViaje As New l_PlanillaViaje
    Private loPlanillaViaje As New List(Of e_PlanillaViaje)

    Private oePlanillaPilotoDet As New e_PlanillaPilotoDet
    Private olPlanillaPilotoDet As New l_PlanillaPilotoDet
    Private loPlanillaPilotoDetalle As New List(Of e_PlanillaPilotoDet)
    Private loPlanillaPilotoDetNacional As New List(Of e_PlanillaPilotoDet)
    Private loPlanillaPilotoDetPacasmayo As New List(Of e_PlanillaPilotoDet)
    Private loPlanillaPilotoDetLima As New List(Of e_PlanillaPilotoDet)

    Private oePlanilla As New e_Planilla
    Private olPlanilla As New l_Planilla

    Private loPlanillaViajeNacional As New List(Of e_PlanillaViaje)
    Private loPlanillaViajePacasmayo As New List(Of e_PlanillaViaje)
    Private loPlanillaViajeLima As New List(Of e_PlanillaViaje)

    Private oeTrabajador As e_Trabajador
    Private olTrabajador As l_Trabajador
    Private leTrabajador As List(Of e_Trabajador)

    Private olTraSeg As New l_TrabajadorSeguridad
    Dim _ingresando_datos As Boolean = False

#End Region

#Region "Botones"

    Public Overrides Sub Nuevo()
        Try
            ObtenerPlanilla()
            MostrarTabs(1, ficPlanillaPiloto, 1)
            MostrarTabs(0, ficMantenimiento, 0)
            oePlanillaPiloto.Modificado = False
            Inicializar()
            Operacion = "Nuevo"
            Etiqueta8.Text = "POR GENERAR"
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            btnConsolidar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            Tiempo1.Enabled = True
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Operacion = "Editar"
            Inicializar()
            Mostrar()
            ugb_Espera.Visible = False
            MostrarTabs(1, ficPlanillaPiloto, 1)
            MostrarTabs(1, ficMantenimiento, 0)
            ControlBotoneria()
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
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If GuardarPlanillaPiloto() Then
                MostrarTabs(0, ficPlanillaPiloto)
                mensajeEmergente.Confirmacion("La Informacion ha sido Guardada Correctamente")
                Listar()
            End If
        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If oePlanillaPiloto.Modificado Then
                Select Case MessageBox.Show("Desea guardar los cambios efectuados?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Case Windows.Forms.DialogResult.Yes
                        If GuardarPlanillaPiloto() Then
                            MostrarTabs(0, ficPlanillaPiloto, 2)
                            _ingresando_datos = False
                            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                        Else
                            _ingresando_datos = True
                            MostrarTabs(1, ficPlanillaPiloto, 1)
                        End If
                    Case Windows.Forms.DialogResult.No
                        MostrarTabs(0, ficPlanillaPiloto, 2)
                        _ingresando_datos = False
                        ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End Select
            Else
                MostrarTabs(0, ficPlanillaPiloto)
                _ingresando_datos = False
            End If
            Listar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select ficPlanillaPiloto.SelectedTab.Index
                Case 0
                    If griPlanillaPilotos.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                    Exportar_Excel(griPlanillaPilotos)
                Case 1
                    Select Case ficMantenimiento.SelectedTab.Index
                        Case 0
                            Select Case ficPlanillaViaje.SelectedTab.Index
                                Case 0
                                    If griPlanillaViajesN.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaViajesN)
                                Case 1
                                    If griPlanillaViajesP.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaViajesP)
                                Case 2
                                    If griPlanillaViajesL.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaViajesL)
                            End Select
                        Case 1
                            Select Case ficPlanillaPilotoDet.SelectedTab.Index
                                Case 0
                                    If griPlanillaPilotosDetN.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaPilotosDetN)
                                Case 1
                                    If griPlanillaPilotosDetP.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaPilotosDetP)
                                Case 2
                                    If griPlanillaPilotosDetL.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                                    Exportar_Excel(griPlanillaPilotosDetL)
                            End Select
                    End Select
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            Select Case MessageBox.Show("Desea Eliminar la Informacion?", "Mensaje del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                Case Windows.Forms.DialogResult.Yes
                    EliminarPlanillaPiloto()
                    Listar()
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Metodos"

    Public Sub ObtenerPlanilla()
        Try
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.IdEstado = "1CH00014"
            oePlanilla = olPlanilla.ObtenerUltimaPlanilla(oePlanilla)
            If oePlanilla.Id = "" Then
                Throw New Exception("No Existe Planilla Generada. Verificar")
            Else
                fecViajeInicio.Value = oePlanilla.FechaInicio
                fecViajeTermino.Value = oePlanilla.FechaFin
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Inicializar()
        oePlanillaPiloto = New e_PlanillaPiloto
        loPlanillaViaje = New List(Of e_PlanillaViaje)
        loPlanillaPilotoDetNacional = New List(Of e_PlanillaPilotoDet)
        griPlanillaPilotosDetN.DataSource = loPlanillaPilotoDetNacional
        loPlanillaPilotoDetPacasmayo = New List(Of e_PlanillaPilotoDet)
        griPlanillaPilotosDetP.DataSource = loPlanillaPilotoDetPacasmayo
        loPlanillaPilotoDetLima = New List(Of e_PlanillaPilotoDet)
        loPlanillaViajeNacional = New List(Of e_PlanillaViaje)
        griPlanillaViajesN.DataSource = loPlanillaViajeNacional
        loPlanillaViajePacasmayo = New List(Of e_PlanillaViaje)
        griPlanillaViajesP.DataSource = loPlanillaViajePacasmayo
        loPlanillaViajeLima = New List(Of e_PlanillaViaje)
        griPlanillaViajesL.DataSource = loPlanillaViajeLima
        txtPlanilla.Text = oePlanilla.Codigo
        numMontoTotal.Value = 0.0
        btnConsolidar.Enabled = True
        btnConsultar.Enabled = True
        btnActualizar.Enabled = True
    End Sub

    Public Sub Listar()
        Try
            oePlanillaPiloto = New e_PlanillaPiloto
            loPlanillaPiloto = New List(Of e_PlanillaPiloto)
            oePlanillaPiloto.TipoOperacion = ""
            loPlanillaPiloto.AddRange(olPlanillaPiloto.Listar(oePlanillaPiloto))
            griPlanillaPilotos.DataSource = loPlanillaPiloto.OrderByDescending(Function(i) i.Codigo).ToList
            If griPlanillaPilotos.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1)
            End If
            For Each fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griPlanillaPilotos.Rows
                If fila.Cells("Estado").Value = "ENVIADO" Then
                    fila.CellAppearance.BackColor = Me.Colores3.Color
                ElseIf fila.Cells("Estado").Value = "CONSOLIDADO" Then
                    fila.CellAppearance.BackColor = Me.Colores2.Color
                Else
                    fila.CellAppearance.BackColor = Me.Colores1.Color
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Mostrar()
        Try
            oePlanillaPiloto.Id = griPlanillaPilotos.ActiveRow.Cells("Id").Value
            oePlanillaPiloto.TipoOperacion = ""
            oePlanillaPiloto = olPlanillaPiloto.Obtener(oePlanillaPiloto)
            With oePlanillaPiloto
                txtPlanilla.Text = .Planilla
                fecViajeInicio.Value = .FechaInicio
                fecViajeTermino.Value = .FechaFin
                numMontoTotal.Value = .Total
            End With
            Etiqueta8.Text = oePlanillaPiloto.Estado
            loPlanillaViaje = New List(Of e_PlanillaViaje)
            oePlanillaViaje = New e_PlanillaViaje
            oePlanillaViaje.IdPlanillaPiloto = oePlanillaPiloto.Id
            oePlanillaViaje.TipoOperacion = "1"
            loPlanillaViaje.AddRange(olPlanillaViaje.Listar(oePlanillaViaje))
            griPlanillaViajesN.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 0).ToList
            griPlanillaViajesP.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 1).ToList
            griPlanillaViajesL.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 2).ToList
            CalcularTotales(griPlanillaViajesN, "MontoPiloto", "MontoCopiloto", "BonoSolo", "BonoCruceroPiloto", "BonoCruceroCopiloto")
            CalcularTotales(griPlanillaViajesP, "MontoPiloto", "MontoCopiloto", "Cuenta")
            CalcularTotales(griPlanillaViajesL, "MontoPiloto", "MontoCopiloto", "Cuenta")
            loPlanillaPilotoDetNacional = New List(Of e_PlanillaPilotoDet)
            loPlanillaPilotoDetPacasmayo = New List(Of e_PlanillaPilotoDet)
            loPlanillaPilotoDetLima = New List(Of e_PlanillaPilotoDet)
            loPlanillaPilotoDetalle = New List(Of e_PlanillaPilotoDet)
            oePlanillaPilotoDet = New e_PlanillaPilotoDet
            oePlanillaPilotoDet.IdPlanillaPiloto = oePlanillaPiloto.Id
            loPlanillaPilotoDetalle.AddRange(olPlanillaPilotoDet.Listar(oePlanillaPilotoDet))
            griPlanillaPilotosDetN.DataSource = loPlanillaPilotoDetalle.OrderBy(Function(ITEM) ITEM.Trabajador).Where(Function(item) item.Tipo = 0).ToList
            griPlanillaPilotosDetP.DataSource = loPlanillaPilotoDetalle.OrderBy(Function(ITEM) ITEM.Trabajador).Where(Function(item) item.Tipo = 1).ToList
            griPlanillaPilotosDetL.DataSource = loPlanillaPilotoDetalle.OrderBy(Function(ITEM) ITEM.Trabajador).Where(Function(item) item.Tipo = 2).ToList
            CalcularTotales(griPlanillaPilotosDetN, "MontoTotal")
            CalcularTotales(griPlanillaPilotosDetP, "MontoTotal", "Cuenta")
            CalcularTotales(griPlanillaPilotosDetL, "MontoTotal", "Cuenta")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EliminarPlanillaPiloto()
        Try
            oePlanillaPiloto = New e_PlanillaPiloto
            oePlanillaPiloto.Id = griPlanillaPilotos.ActiveRow.Cells("Id").Value
            If olPlanillaPiloto.Eliminar(oePlanillaPiloto) Then
                mensajeEmergente.Confirmacion("El Dato ha Sido Eliminado Correctamente")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function GuardarPlanillaPiloto() As Boolean
        Try
            LlenarObjeto()
            If olPlanillaPiloto.Guardar(oePlanillaPiloto) Then
                If Operacion <> "Enviar" Then
                    If loPlanillaViaje.Count > 0 Then
                        For Each plavia In loPlanillaViaje
                            plavia.IdPlanillaPiloto = oePlanillaPiloto.Id
                        Next
                        olPlanillaViaje.GuardarMasivo(loPlanillaViaje)
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub LlenarObjeto()
        oePlanillaPiloto.FechaInicio = fecViajeInicio.Value
        oePlanillaPiloto.FechaFin = fecViajeTermino.Value
        oePlanillaPiloto.IdPlanilla = oePlanilla.Id
        oePlanillaPiloto.Descripcion = "PLANILLA DE PILOTOS DE LOS VIAJES DESDE EL: " & fecViajeInicio.Value.Date & " AL: " & fecViajeTermino.Value.Date
        If Operacion = "Nuevo" Then
            oePlanillaPiloto.TipoOperacion = "I"
            oePlanillaPiloto.IdEstado = "1CH00014"
        ElseIf Operacion = "Editar" Then
            oePlanillaPiloto.TipoOperacion = "A"
            oePlanillaPiloto.IdEstado = "1CH00014"
        ElseIf Operacion = "Consolidar" Then
            oePlanillaPiloto.TipoOperacion = "C"
            oePlanilla.IdEstado = "1CH00034"
        ElseIf Operacion = "Enviar" Then
            oePlanillaPiloto.TipoOperacion = "S"
        End If
        oePlanillaPiloto.IdPlanilla = oePlanilla.Id
        oePlanillaPiloto.Total = numMontoTotal.Value
        oePlanillaPiloto.Fecha = Date.Now
        oePlanillaPiloto.FechaCreacion = ObtenerFechaServidor()
        oePlanillaPiloto.UsuarioCreacion = gUsuarioSGI.Id
        If loPlanillaPilotoDetalle.Count > 0 And Operacion <> "Enviar" Then
            oePlanillaPiloto.listaPlanillaPiloto.AddRange(loPlanillaPilotoDetalle)
            oePlanillaPiloto.IdEstado = "1CH00034"
        End If
    End Sub

    Private Sub ListarViajes()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Dim loPlanillaViajeAux As New List(Of e_PlanillaViaje)
            loPlanillaViajeNacional = New List(Of e_PlanillaViaje)
            loPlanillaViajePacasmayo = New List(Of e_PlanillaViaje)
            loPlanillaViajeAux.AddRange(loPlanillaViaje)
            loPlanillaViaje = New List(Of e_PlanillaViaje)
            griPlanillaViajesN.DataSource = loPlanillaViaje
            oePlanillaViaje = New e_PlanillaViaje
            oePlanillaViaje.TipoOperacion = ""
            oePlanillaViaje.FechaInicio = fecViajeInicio.Value
            oePlanillaViaje.FechaFin = fecViajeTermino.Value
            If oePlanillaPiloto.Id <> "" Then
                oePlanillaViaje.IdPlanillaPiloto = oePlanillaPiloto.Id
                loPlanillaViaje.AddRange(loPlanillaViajeAux)
            End If
            loPlanillaViaje.AddRange(olPlanillaViaje.Listar(oePlanillaViaje))
            loPlanillaViajeNacional.AddRange(loPlanillaViaje.Where(Function(item) item.Tipo = 0).ToList)
            loPlanillaViajePacasmayo.AddRange(loPlanillaViaje.Where(Function(item) item.Tipo = 1).ToList)
            loPlanillaViajeLima.AddRange(loPlanillaViaje.Where(Function(item) item.Tipo = 2).ToList)
            griPlanillaViajesN.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 0).ToList
            griPlanillaViajesP.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 1).ToList
            griPlanillaViajesL.DataSource = loPlanillaViaje.Where(Function(item) item.Tipo = 2).ToList
            CalcularTotales(griPlanillaViajesN, "MontoPiloto", "MontoCopiloto", "BonoSolo", "BonoCruceroPiloto", "BonoCruceroCopiloto")
            CalcularTotales(griPlanillaViajesP, "MontoPiloto", "MontoCopiloto", "Cuenta")
            CalcularTotales(griPlanillaViajesL, "MontoPiloto", "MontoCopiloto", "Cuenta")
            With griPlanillaViajesN
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("CuentaPiloto").Value.ToString = -1 Then
                            Fila.CellAppearance.BackColor = Colores4.Color
                        End If
                    Next
                End If
            End With
            With griPlanillaViajesP
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("CuentaPiloto").Value.ToString = -1 Then
                            Fila.CellAppearance.BackColor = Colores4.Color
                        End If
                    Next
                End If
            End With
            With griPlanillaViajesL
                If .Rows.Count > 0 Then
                    For Each Fila In .Rows
                        If Fila.Cells("CuentaPiloto").Value.ToString = -1 Then
                            Fila.CellAppearance.BackColor = Colores4.Color
                        End If
                    Next
                End If
            End With
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Consolidar()
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            loPlanillaPilotoDetalle = New List(Of e_PlanillaPilotoDet)
            For Each plavia As e_PlanillaViaje In loPlanillaViaje
                If plavia.IndPago = True And plavia.CuentaPiloto = -1 And plavia.Tipo = 0 Then
                    Throw New Exception("Existe Ruta sin Monto. Verificar. " & plavia.Origen & " - " & plavia.Destino)
                End If
                If plavia.CuentaPiloto = -1 And plavia.IndPago = True And plavia.Tipo <> 0 Then
                    Throw New Exception("Existe Ruta sin Cuenta. Verificar. " & plavia.Origen & " - " & plavia.Destino)
                End If
            Next
            Dim fechaservidor As Date = ObtenerFechaServidor()
            'consolidado ruta nacionalf
            ConsolidarNacional(fechaservidor)
            'consolidado ruta pacasmayo
            ConsolidarPacasmayo(fechaservidor)
            'consolidado ruta lima
            'ConsolidarLima(fechaservidor)

            loPlanillaPilotoDetalle.AddRange(loPlanillaPilotoDetNacional)
            loPlanillaPilotoDetalle.AddRange(loPlanillaPilotoDetPacasmayo)
            'loPlanillaPilotoDetalle.AddRange(loPlanillaPilotoDetLima)

            numMontoTotal.Value = loPlanillaPilotoDetNacional.Sum(Function(item) item.MontoTotal) + loPlanillaPilotoDetPacasmayo.Sum(Function(item) item.MontoTotal) '+ loPlanillaPilotoDetLima.Sum(Function(item) item.MontoTotal)
            MostrarTabs(1, ficMantenimiento, 0)
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Sub ConsolidarNacional(ByVal FechaServidor As Date)
        Try
            Dim loPlaViaAuxNacional As New List(Of e_PlanillaViaje)
            Dim IdTrabajadorPiloto As String = ""
            Dim IdTrabajadorCopiloto As String = ""
            loPlaViaAuxNacional.AddRange(loPlanillaViajeNacional.OrderBy(Function(item) item.IdPiloto).ToList.Where(Function(item) item.IndPago = True))
            loPlanillaPilotoDetNacional = New List(Of e_PlanillaPilotoDet)
            griPlanillaPilotosDetN.DataSource = loPlanillaPilotoDetNacional
            For Each plavia As e_PlanillaViaje In loPlaViaAuxNacional
                oePlanillaPilotoDet = New e_PlanillaPilotoDet
                With oePlanillaPilotoDet
                    If IdTrabajadorPiloto <> plavia.IdPiloto Then
                        IdTrabajadorPiloto = plavia.IdPiloto
                        .TipoOperacion = "I"
                        .IdTrabajador = plavia.IdPiloto.Trim
                        .Trabajador = plavia.Piloto
                        ' Obtener Dni
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = .IdTrabajador.Trim
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                            .Dni = oeTrabajador.oePersona.Dni
                        End If
                        .MontoTotal = loPlaViaAuxNacional.Where(Function(item) item.IdPiloto = IdTrabajadorPiloto).Sum(Function(item) item.MontoPiloto) + _
                            loPlaViaAuxNacional.Where(Function(item) item.IdCopiloto = IdTrabajadorPiloto).Sum(Function(item) item.MontoCopiloto)
                        .FechaCreacion = FechaServidor
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Tipo = 0
                        .TipoTrabajador = 0
                        loPlanillaPilotoDetNacional.Add(oePlanillaPilotoDet)
                    End If
                End With
            Next
            Dim flag As Boolean = False
            Dim loPlaViaAux1Nacional As New List(Of e_PlanillaViaje)
            loPlaViaAux1Nacional.AddRange(loPlaViaAuxNacional.OrderBy(Function(item) item.IdCopiloto).ToList.Where(Function(item) item.IdCopiloto.Trim <> "").Where(Function(item) item.IndPago = True))
            For Each plaviacop As e_PlanillaViaje In loPlaViaAux1Nacional
                oePlanillaPilotoDet = New e_PlanillaPilotoDet
                If IdTrabajadorCopiloto <> plaviacop.IdCopiloto Then
                    IdTrabajadorCopiloto = plaviacop.IdCopiloto
                    For Each plapildet As e_PlanillaPilotoDet In loPlanillaPilotoDetNacional
                        If plaviacop.IdCopiloto = plapildet.IdTrabajador Then
                            flag = False
                            Exit For
                        Else
                            flag = True
                        End If
                    Next
                    If flag = True Then
                        With oePlanillaPilotoDet
                            .IdTrabajador = plaviacop.IdCopiloto
                            .Trabajador = plaviacop.Copiloto
                            ' Obtener Dni
                            oeTrabajador = New e_Trabajador
                            oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = .IdTrabajador.Trim
                            If leTrabajador.Contains(oeTrabajador) Then
                                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                .Dni = oeTrabajador.oePersona.Dni
                            End If
                            .MontoTotal = loPlaViaAux1Nacional.Where(Function(item) item.IdCopiloto = IdTrabajadorCopiloto).Sum(Function(item) item.MontoCopiloto)
                            .FechaCreacion = fechaservidor
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .TipoOperacion = "I"
                            .Tipo = 0
                            .TipoTrabajador = 1
                            loPlanillaPilotoDetNacional.Add(oePlanillaPilotoDet)
                        End With
                    End If
                End If
            Next
            griPlanillaPilotosDetN.DataSource = loPlanillaPilotoDetNacional.OrderBy(Function(item) item.Trabajador).ToList
            CalcularTotales(griPlanillaPilotosDetN, "MontoTotal")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ConsolidarPacasmayo(ByVal FechaServidor As Date)
        Try
            Dim loPlaViaAuxPacasmayo As New List(Of e_PlanillaViaje)
            Dim IdTrabajadorPilotoP As String = ""
            Dim IdTrabajadorCopilotoP As String = ""
            loPlaViaAuxPacasmayo.AddRange(loPlanillaViajePacasmayo.OrderBy(Function(item) item.IdPiloto).ToList.Where(Function(item) item.IndPago = True))
            loPlanillaPilotoDetPacasmayo = New List(Of e_PlanillaPilotoDet)
            griPlanillaPilotosDetP.DataSource = loPlanillaPilotoDetPacasmayo
            For Each plavia As e_PlanillaViaje In loPlaViaAuxPacasmayo
                oePlanillaPilotoDet = New e_PlanillaPilotoDet
                With oePlanillaPilotoDet
                    If IdTrabajadorPilotoP <> plavia.IdPiloto Then
                        IdTrabajadorPilotoP = plavia.IdPiloto
                        .TipoOperacion = "I"
                        .IdTrabajador = plavia.IdPiloto
                        .Trabajador = plavia.Piloto
                        ' Obtener Dni
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = .IdTrabajador.Trim
                        If leTrabajador.Contains(oeTrabajador) Then
                            oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                            .Dni = oeTrabajador.oePersona.Dni
                        End If
                        .MontoTotal = loPlaViaAuxPacasmayo.Where(Function(item) item.IdPiloto = IdTrabajadorPilotoP).Sum(Function(item) item.MontoPiloto) + _
                            loPlaViaAuxPacasmayo.Where(Function(item) item.IdCopiloto = IdTrabajadorPilotoP).Sum(Function(item) item.MontoCopiloto)
                        .FechaCreacion = FechaServidor
                        .UsuarioCreacion = gUsuarioSGI.Id
                        .Cuenta = loPlaViaAuxPacasmayo.Where(Function(item) item.IdPiloto = IdTrabajadorPilotoP).Sum(Function(item) item.CuentaPiloto) + _
                            loPlaViaAuxPacasmayo.Where(Function(item) item.IdCopiloto = IdTrabajadorPilotoP).Sum(Function(item) item.CuentaCoPiloto)
                        .Tipo = 1
                        .TipoTrabajador = 0
                        loPlanillaPilotoDetPacasmayo.Add(oePlanillaPilotoDet)
                    End If
                End With
            Next
            Dim flag As Boolean = False
            Dim loPlaViaAux1Pacasmayo As New List(Of e_PlanillaViaje)
            loPlaViaAux1Pacasmayo.AddRange(loPlaViaAuxPacasmayo.OrderBy(Function(item) item.IdCopiloto).ToList.Where(Function(item) item.IdCopiloto.Trim <> "").Where(Function(item) item.IndPago = True))
            For Each plaviacop As e_PlanillaViaje In loPlaViaAux1Pacasmayo
                oePlanillaPilotoDet = New e_PlanillaPilotoDet
                If IdTrabajadorCopilotoP <> plaviacop.IdCopiloto Then
                    IdTrabajadorCopilotoP = plaviacop.IdCopiloto
                    For Each plapildet As e_PlanillaPilotoDet In loPlanillaPilotoDetPacasmayo
                        If plaviacop.IdCopiloto = plapildet.IdTrabajador Then
                            flag = False
                            Exit For
                        Else
                            flag = True
                        End If
                    Next
                    If flag = True Then
                        With oePlanillaPilotoDet
                            .IdTrabajador = plaviacop.IdCopiloto
                            .Trabajador = plaviacop.Copiloto
                            ' Obtener Dni
                            oeTrabajador = New e_Trabajador
                            oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = .IdTrabajador.Trim
                            If leTrabajador.Contains(oeTrabajador) Then
                                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                .Dni = oeTrabajador.oePersona.Dni
                            End If
                            .MontoTotal = loPlaViaAux1Pacasmayo.Where(Function(item) item.IdCopiloto = IdTrabajadorCopilotoP).Sum(Function(item) item.MontoCopiloto) + _
                                loPlaViaAux1Pacasmayo.Where(Function(item) item.IdCopiloto = IdTrabajadorCopilotoP).Sum(Function(item) item.CuentaCoPiloto)
                            .FechaCreacion = FechaServidor
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .TipoOperacion = "I"
                            .Tipo = 1
                            .TipoTrabajador = 1
                            loPlanillaPilotoDetPacasmayo.Add(oePlanillaPilotoDet)
                        End With
                    End If
                End If
            Next
            For Each plapildetp As e_PlanillaPilotoDet In loPlanillaPilotoDetPacasmayo
                With plapildetp
                    If .Cuenta > 44 Then
                        Dim nuevacuenta As Integer = 0
                        nuevacuenta = .Cuenta - 44
                        .MontoTotal = .MontoTotal + nuevacuenta * 30
                    End If
                End With
            Next
            griPlanillaPilotosDetP.DataSource = loPlanillaPilotoDetPacasmayo.OrderBy(Function(item) item.Trabajador).ToList
            CalcularTotales(griPlanillaPilotosDetP, "MontoTotal", "Cuenta")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ConsolidarLima(ByVal FechaServidor As Date)
        '    Try
        '        Dim loPlaViaAuxLima As New List(Of e_PlanillaViaje)
        '        Dim IdTrabajadorPilotoL As String = ""
        '        Dim IdTrabajadorCopilotoL As String = ""
        '        Dim IdTrabajadorAyudanteL As String = ""
        '        loPlaViaAuxLima.AddRange(loPlanillaViajeLima.OrderBy(Function(item) item.IdPiloto).ToList.Where(Function(item) item.IndPago = True))
        '        loPlanillaPilotoDetLima = New List(Of e_PlanillaPilotoDet)
        '        griPlanillaPilotosDetL.DataSource = loPlanillaPilotoDetLima
        '        For Each plavia As e_PlanillaViaje In loPlaViaAuxLima
        '            oePlanillaPilotoDet = New e_PlanillaPilotoDet
        '            With oePlanillaPilotoDet
        '                If IdTrabajadorPilotoL <> plavia.IdPiloto Then
        '                    IdTrabajadorPilotoL = plavia.IdPiloto
        '                    .TipoOperacion = "I"
        '                    .IdTrabajador = plavia.IdPiloto
        '                    .Trabajador = plavia.Piloto
        '                    .MontoTotal = loPlaViaAuxLima.Where(Function(item) item.IdPiloto = IdTrabajadorPilotoL).Sum(Function(item) item.MontoPiloto) + _
        '                        loPlaViaAuxLima.Where(Function(item) item.IdCopiloto = IdTrabajadorPilotoL).Sum(Function(item) item.MontoCopiloto) + _
        '                        loPlaViaAuxLima.Where(Function(item) item.IdAyudante = IdTrabajadorPilotoL).Sum(Function(item) item.MontoAyudante)
        '                    .FechaCreacion = FechaServidor
        '                    .UsuarioCreacion = gUsuarioSGI.Id
        '                    .Cuenta = loPlaViaAuxLima.Where(Function(item) item.IdPiloto = IdTrabajadorPilotoL).Sum(Function(item) item.Cuenta) + _
        '                        loPlaViaAuxLima.Where(Function(item) item.IdCopiloto = IdTrabajadorPilotoL).Sum(Function(item) item.Cuenta) + _
        '                        loPlaViaAuxLima.Where(Function(item) item.IdAyudante = IdTrabajadorPilotoL).Sum(Function(item) item.Cuenta)
        '                    .Tipo = 2
        '                    .TipoTrabajador = 2
        '                    loPlanillaPilotoDetLima.Add(oePlanillaPilotoDet)
        '                End If
        '            End With
        '        Next
        '        Dim flag As Boolean = False
        '        Dim loPlaViaAux1Lima As New List(Of e_PlanillaViaje)
        '        loPlaViaAux1Lima.AddRange(loPlaViaAuxLima.OrderBy(Function(item) item.IdCopiloto).ToList.Where(Function(item) item.IndPago = True))
        '        For Each plaviacop As e_PlanillaViaje In loPlaViaAux1Lima
        '            oePlanillaPilotoDet = New e_PlanillaPilotoDet
        '            If IdTrabajadorCopilotoL <> plaviacop.IdCopiloto Then
        '                IdTrabajadorCopilotoL = plaviacop.IdCopiloto
        '                For Each plapildet As e_PlanillaPilotoDet In loPlanillaPilotoDetLima
        '                    If plaviacop.IdCopiloto = plapildet.IdTrabajador Then
        '                        flag = False
        '                        Exit For
        '                    Else
        '                        flag = True
        '                    End If
        '                Next
        '                If flag = True Then
        '                    With oePlanillaPilotoDet
        '                        .IdTrabajador = plaviacop.IdCopiloto
        '                        .Trabajador = plaviacop.Copiloto
        '                        .MontoTotal = loPlaViaAux1Lima.Where(Function(item) item.IdCopiloto = IdTrabajadorCopilotoL).Sum(Function(item) item.MontoCopiloto) + _
        '                            loPlaViaAux1Lima.Where(Function(item) item.IdAyudante = IdTrabajadorCopilotoL).Sum(Function(item) item.MontoAyudante)
        '                        .Cuenta = loPlaViaAux1Lima.Where(Function(item) item.IdCopiloto = IdTrabajadorCopilotoL).Sum(Function(item) item.Cuenta) + _
        '                            loPlaViaAux1Lima.Where(Function(item) item.IdAyudante = IdTrabajadorCopilotoL).Sum(Function(item) item.Cuenta)
        '                        .FechaCreacion = FechaServidor
        '                        .UsuarioCreacion = gUsuarioSGI.Id
        '                        .TipoOperacion = "I"
        '                        .Tipo = 2
        '                        .TipoTrabajador = 3
        '                        loPlanillaPilotoDetLima.Add(oePlanillaPilotoDet)
        '                    End With
        '                End If
        '            End If
        '        Next
        '        flag = False
        '        Dim loPlaViaAux2Lima As New List(Of e_PlanillaViaje)
        '        loPlaViaAux2Lima.AddRange(loPlaViaAuxLima.OrderBy(Function(item) item.IdAyudante).ToList.Where(Function(item) item.IdAyudante.Trim <> "").Where(Function(item) item.IndPago = True))
        '        For Each plaviacop As e_PlanillaViaje In loPlaViaAux2Lima
        '            oePlanillaPilotoDet = New e_PlanillaPilotoDet
        '            If IdTrabajadorAyudanteL <> plaviacop.IdAyudante Then
        '                IdTrabajadorAyudanteL = plaviacop.IdAyudante
        '                For Each plapildet As e_PlanillaPilotoDet In loPlanillaPilotoDetLima
        '                    If plaviacop.IdAyudante = plapildet.IdTrabajador Then
        '                        flag = False
        '                        Exit For
        '                    Else
        '                        flag = True
        '                    End If
        '                Next
        '                If flag = True Then
        '                    With oePlanillaPilotoDet
        '                        .IdTrabajador = plaviacop.IdAyudante
        '                        .Trabajador = plaviacop.Ayudante
        '                        .MontoTotal = loPlaViaAux2Lima.Where(Function(item) item.IdAyudante = IdTrabajadorAyudanteL).Sum(Function(item) item.MontoAyudante)
        '                        .Cuenta = loPlaViaAux2Lima.Where(Function(item) item.IdAyudante = IdTrabajadorAyudanteL).Sum(Function(item) item.Cuenta)
        '                        .FechaCreacion = FechaServidor
        '                        .UsuarioCreacion = gUsuarioSGI.Id
        '                        .TipoOperacion = "I"
        '                        .Tipo = 2
        '                        .TipoTrabajador = 3
        '                        loPlanillaPilotoDetLima.Add(oePlanillaPilotoDet)
        '                    End With
        '                End If
        '            End If
        '        Next
        '        For Each plapildetl As e_PlanillaPilotoDet In loPlanillaPilotoDetLima
        '            With plapildetl
        '                If .Cuenta > 40 Then
        '                    Dim nuevacuenta As Integer = 0
        '                    nuevacuenta = .Cuenta - 40
        '                    .MontoTotal = .MontoTotal + IIf(.TipoTrabajador = 2, nuevacuenta * 40, nuevacuenta * 25)
        '                End If
        '            End With
        '        Next
        '        griPlanillaPilotosDetL.DataSource = loPlanillaPilotoDetLima.OrderBy(Function(item) item.Trabajador).ToList
        '        CalcularTotales(griPlanillaPilotosDetL, "MontoTotal", "Cuenta")
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
    End Sub

    Private Sub ActualizarPagos()
        Try
            If MessageBox.Show("Desea Actualizar el Indicador de Pago de Todos los Viajes de la Lista Activa?", _
                                     "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Select Case ficPlanillaViaje.SelectedTab.Index
                    Case 0
                        If griPlanillaViajesN.Rows.Count > 0 Then
                            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griPlanillaViajesN.Rows.Where(Function(item) item.IsFilteredOut = False)
                                If Fila.Cells("IndPago").Value = False Then
                                    Fila.Cells("IndPago").Value = True
                                Else
                                    Fila.Cells("IndPago").Value = False
                                End If
                            Next
                        End If
                    Case 1
                        If griPlanillaViajesP.Rows.Count > 0 Then
                            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griPlanillaViajesP.Rows.Where(Function(item) item.IsFilteredOut = False)
                                If Fila.Cells("IndPago").Value = False Then
                                    Fila.Cells("IndPago").Value = True
                                Else
                                    Fila.Cells("IndPago").Value = False
                                End If
                            Next
                        End If
                    Case 2
                        If griPlanillaViajesL.Rows.Count > 0 Then
                            For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griPlanillaViajesL.Rows.Where(Function(item) item.IsFilteredOut = False)
                                If Fila.Cells("IndPago").Value = False Then
                                    Fila.Cells("IndPago").Value = True
                                Else
                                    Fila.Cells("IndPago").Value = False
                                End If
                            Next
                        End If
                End Select
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ControlBotoneria()
        If oePlanillaPiloto.Estado = "CONSOLIDADO" Then
            If Operacion = "Enviar" Then
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            Else
                ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
            End If
            btnConsultar.Enabled = False
            btnConsolidar.Enabled = False
            btnActualizar.Enabled = False
        ElseIf oePlanillaPiloto.Estado = "ENVIADO" Then
            ControlBoton(0, 0, 0, 0, 1, 0, 0, 1, 1)
            btnConsultar.Enabled = False
            btnConsolidar.Enabled = False
            btnActualizar.Enabled = False
        Else
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 1)
            btnConsultar.Enabled = True
            btnActualizar.Enabled = True
        End If
    End Sub

    Private Sub CrearMontoRuta()
        Try
            Dim frm As New frm_MontoRuta
            frm = frm.getInstancia()
            frm.MdiParent = frm_Menu
            frm.Show()
            Select Case ficPlanillaViaje.SelectedTab.Index
                Case 0
                    frm.GeneraMonto(griPlanillaViajesN.ActiveRow.Cells("Origen").Value, griPlanillaViajesN.ActiveRow.Cells("Destino").Value)
                Case 1
                    frm.GeneraMonto(griPlanillaViajesP.ActiveRow.Cells("Origen").Value, griPlanillaViajesP.ActiveRow.Cells("Destino").Value)
                Case 2
                    frm.GeneraMonto(griPlanillaViajesL.ActiveRow.Cells("Origen").Value, griPlanillaViajesL.ActiveRow.Cells("Destino").Value)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MostrarDetalle(Id As String, IdTrabajador As String)
        Try
            Dim frm As New frm_DetallePlanillaViaje
            frm.CargarDetalle(Id, IdTrabajador)
            frm.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub VerificarDuplicados()
        Try
            Dim ViajeDup As String = ""
            Dim loAux As New List(Of e_PlanillaViaje)
            'Nacional
            For Each item In loPlanillaViajeNacional.OrderBy(Function(i) i.Viaje).ToList
                If item.Viaje = ViajeDup Then
                    loAux.Add(item)
                End If
                ViajeDup = item.Viaje
            Next
            'Dim loAux2 = From objeto In loAux Group By objeto.IdRuta, objeto.Destino, objeto.Origen
            '            Into Cuenta = Count()
            If loAux.Count > 0 Then
                btnConsolidar.Enabled = False
                'UltraGrid1.DataSource = loAux2
                'UltraGrid1.DataBind()
                'Throw New Exception("Rutas Duplicadas Verificar")
                Throw New Exception("El Viaje: " & loAux(0).Viaje & " con Ruta: " & loAux(0).Origen + " - " + loAux(0).Destino + " Se Encuentra Duplicado")
            Else
                btnConsolidar.Enabled = True
            End If
            'Pacasmayo
            ViajeDup = ""
            For Each item In loPlanillaViajePacasmayo.OrderBy(Function(i) i.Viaje).ToList
                If item.Viaje = ViajeDup Then
                    loAux.Add(item)
                End If
                ViajeDup = item.Viaje
            Next
            If loAux.Count > 0 Then
                btnConsolidar.Enabled = False
                'Throw New Exception("Rutas Duplicadas Verificar")
                Throw New Exception("El Viaje: " & loAux(0).Viaje & " con Ruta: " & loAux(0).Origen + " - " + loAux(0).Destino + " Se Encuentra Duplicado")
            Else
                mensajeEmergente.Confirmacion("Verificacion Exitosa. Consolidar", True)
                btnConsolidar.Enabled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PlanillaPiloto_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficPlanillaPiloto.SelectedTab.Index
            Case 0
                If griPlanillaPilotos.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1)
                End If
            Case 1
                ControlBotoneria()
        End Select
    End Sub

    Private Sub frm_PlanillaPiloto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Instancia = Nothing
    End Sub

    Private Sub frm_PlanillaPiloto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = _ingresando_datos
        If Not e.Cancel Then
            ControlBoton(0, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_PlanillaPiloto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            fecDesde.Value = Date.Now.AddDays(-15)
            oeTrabajador = New e_Trabajador : olTrabajador = New l_Trabajador : leTrabajador = New List(Of e_Trabajador)
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            ListarViajes()
            btnConsolidar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click
        Try
            Consolidar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPlanillaPilotos_DoubleClick(sender As Object, e As EventArgs) Handles griPlanillaPilotos.DoubleClick
        Editar()
    End Sub

    Private Sub griPlanillaPilotosDetN_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaPilotosDetN.CellChange
        griPlanillaPilotosDetN.UpdateData()
    End Sub

    Private Sub griPlanillaPilotosDetP_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaPilotosDetP.CellChange
        griPlanillaPilotosDetP.UpdateData()
    End Sub

    Private Sub griPlanillaPilotosDetL_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaPilotosDetL.CellChange
        griPlanillaPilotosDetL.UpdateData()
    End Sub

    Private Sub griPlanillaViajesN_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaViajesN.CellChange
        griPlanillaViajesN.UpdateData()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            ActualizarPagos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub mnuPlanillaViaje_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuPlanillaViaje.Opening
        mnuPlanillaViaje.Items("ToolStripMenuItem1").Visible = False
        Select Case ficPlanillaViaje.SelectedTab.Index
            Case 0
                If griPlanillaViajesN.Rows.Count > 0 Then
                    mnuPlanillaViaje.Items("ToolStripMenuItem1").Visible = True
                End If
            Case 1
                If griPlanillaViajesP.Rows.Count > 0 Then
                    mnuPlanillaViaje.Items("ToolStripMenuItem1").Visible = True
                End If
            Case 2
                If griPlanillaViajesL.Rows.Count > 0 Then
                    mnuPlanillaViaje.Items("ToolStripMenuItem1").Visible = True
                End If
        End Select
    End Sub

    Private Sub griPlanillaViajesP_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaViajesP.CellChange
        griPlanillaViajesP.UpdateData()
    End Sub

    Private Sub griPlanillaViajesL_CellChange(sender As Object, e As CellEventArgs) Handles griPlanillaViajesL.CellChange
        griPlanillaViajesL.UpdateData()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If olTraSeg.Permisos(gUsuarioSGI.IdTrabajador, "MODIFICA/ELIMINA MONTO RUTA") Then CrearMontoRuta()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_PlanillaPiloto_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub griPlanillaPilotosDetN_DoubleClick(sender As Object, e As EventArgs) Handles griPlanillaPilotosDetN.DoubleClick
        Try
            With griPlanillaPilotosDetN
                MostrarDetalle(.ActiveRow.Cells("IdPlanillaPiloto").Value, .ActiveRow.Cells("IdTrabajador").Value)
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPlanillaPilotosDetP_DoubleClick(sender As Object, e As EventArgs) Handles griPlanillaPilotosDetP.DoubleClick
        Try
            With griPlanillaPilotosDetP
                MostrarDetalle(.ActiveRow.Cells("IdPlanillaPiloto").Value, .ActiveRow.Cells("IdTrabajador").Value)
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            VerificarDuplicados()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mnuPlanillaPiloto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mnuPlanillaPiloto.Opening
        mnuPlanillaPiloto.Items("ToolStripMenuNuevo").Visible = True
        mnuPlanillaPiloto.Items("ToolStripMenuEditar").Visible = False
        mnuPlanillaPiloto.Items("ToolStripMenuEliminar").Visible = False
        mnuPlanillaPiloto.Items("ToolStripEnviar").Visible = False
        If griPlanillaPilotos.Rows.Count > 0 Then
            mnuPlanillaPiloto.Items("ToolStripMenuEditar").Visible = True
            mnuPlanillaPiloto.Items("ToolStripMenuEliminar").Visible = True
            mnuPlanillaPiloto.Items("ToolStripEnviar").Visible = True
            If griPlanillaPilotos.ActiveRow.Cells("Estado").Value = "ENVIADO" Then
                mnuPlanillaPiloto.Items("ToolStripMenuEliminar").Visible = False
                mnuPlanillaPiloto.Items("ToolStripEnviar").Visible = False
                mnuPlanillaPiloto.Items("ToolStripMenuEditar").Visible = False
            End If
        End If
    End Sub

    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        Nuevo()
    End Sub

    Private Sub ToolStripMenuEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEditar.Click
        Editar()
        ControlBotoneria()
    End Sub

    Private Sub ToolStripMenuEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuEliminar.Click
        Eliminar()
    End Sub

    Private Sub ToolStripEnviar_Click(sender As Object, e As EventArgs) Handles ToolStripEnviar.Click
        Editar()
        Operacion = "Enviar"
        ControlBotoneria()
    End Sub

#End Region

End Class