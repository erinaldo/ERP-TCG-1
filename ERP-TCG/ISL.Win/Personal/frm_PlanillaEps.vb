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
Imports Microsoft.Office.Interop

Public Class frm_PlanillaEps
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_PlanillaEps = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PlanillaEps()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaraciones de Variables"

    Private oePlanillaEps As New e_PlanillaEps, olPlanillaEps As New l_PlanillaEps
    Private lePlanillaEps As New List(Of e_PlanillaEps), leCalculaEps As New List(Of e_PlanillaEps)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oePlanesEps As New e_PlanesEPS, olPlanesEps As New l_PlanesEPS, lePlanesEps As New List(Of e_PlanesEPS)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeRegSalud As New e_RegimenSalud, olRegSalud As New l_RegimenSalud, leRegSalud As New List(Of e_RegimenSalud)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private dsDatosGen As New Data.DataTable
    Private _acl As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griPlanillaEps.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
            Else
                ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
        Try
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Inicializa()
                Dim _lePlaAct = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList
                LlenarCombo(cboPlanilla, "Codigo", _lePlaAct, -1)
                SelecionarTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Editar()
        Try
            Inicializa()
            Mostrar()
            btnBuscar.Enabled = False
            SelecionarTab(1)
            ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            If leCalculaEps.Count > 0 Then
                olPlanillaEps.GuardarLista(leCalculaEps)
                mensajeEmergente.Confirmacion("Se ha Guardado los Datos Correctamente", True)
                SelecionarTab(0)
                Consultar(True)
            Else
                Throw New Exception("No hay Registros para Guardar")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                SelecionarTab(0)
                Consultar(True)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If cboPlanillaBus.SelectedIndex > 0 Then
                    Consultar(True)
                    If lePlanillaEps.Count > 0 Then
                        If lePlanillaEps(0).Estado = gNombreEstadoEnviado Then Throw New Exception("Para Eliminar los Registros deben estar en estado GENERADA")
                        If MessageBox.Show("¿Esta seguro de eliminar la PLanilla Eps Nº " & cboPlanillaBus.Text & " ?", _
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, _
                                    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Dim formulario As frm_AutenticarTrabajador
                            formulario = New frm_AutenticarTrabajador
                            formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                            If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
                                Throw New Exception("Ingrese un Clave Correcta")
                            Else
                                For Each oePEPS In lePlanillaEps
                                    oePEPS.PrefijoID = gs_PrefijoIdSucursal '@0001
                                    oePEPS.TipoOperacion = "E"
                                    oePEPS.UsuarioModifica = gUsuarioSGI.Id
                                Next
                                If olPlanillaEps.EliminarLista(lePlanillaEps) Then
                                    mensajeEmergente.Confirmacion("Se Eliminaron los Registros correctamente", True)
                                    Consultar(True)
                                End If

                            End If
                        End If
                    Else
                        Throw New Exception("No Hay Registros para Eliminar")
                    End If
                Else
                    Throw New Exception("Seleccione Planilla para Eliminar")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            _acl = gAccionSistema.EXPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Select Case ficPlanillaEps.SelectedTab.Index
                    Case 0
                        If griPlanillaEps.Rows.Count > 0 Then
                            Exportar_Excel(griPlanillaEps, "Planilla EPS")
                        Else
                            Throw New Exception("No hay Datos para Exportar")
                        End If
                    Case 1
                        If griCalculaEps.Rows.Count > 0 Then
                            Exportar_Excel(griCalculaEps, "Planilla EPS")
                        Else
                            Throw New Exception("No hay Datos para Exportar")
                        End If
                End Select
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_PlanillaEps_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficPlanillaEps.SelectedTab.Index
            Case 0
                If griPlanillaEps.Rows.Count > 0 Then
                    ControlBoton(1, 1, 0, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_PlanillaEps_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        instancia = Nothing
    End Sub

    Private Sub frm_PlanillaEps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            SelecionarTab(0)
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            lePlanillaEps = New List(Of e_PlanillaEps)
            CargarPlanillaEps(lePlanillaEps)
            btnEnviar.Enabled = False : btnExtornar.Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaBus_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaBus.ValueChanged
        If cboPlanillaBus.SelectedIndex > 0 Then
            oePlanilla = New e_Planilla
            oePlanilla = cboPlanillaBus.Items(cboPlanillaBus.SelectedIndex).ListObject
            fecInicioBus.Value = oePlanilla.FechaInicio
            fecFinBus.Value = oePlanilla.FechaFin
        Else
            fecInicioBus.Value = Date.Now.Date
            fecFinBus.Value = Date.Now.Date
        End If
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        If cboPlanilla.SelectedIndex > -1 Then
            oePlanilla = New e_Planilla
            oePlanilla = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
            fecInicio.Value = oePlanilla.FechaInicio
            fecFin.Value = oePlanilla.FechaFin
            oePlanillaEps = New e_PlanillaEps
            oePlanillaEps.TipoOperacion = ""
            oePlanillaEps.IdPlanilla = oePlanilla.Id : oePlanillaEps.Activo = True
            Dim _leAuxPEPS = olPlanillaEps.Listar(oePlanillaEps)
            If _leAuxPEPS.Count > 0 Then
                btnBuscar.Enabled = False
                MessageBox.Show("La Planilla EPS de Nª " & oePlanilla.Codigo & " esta " & _leAuxPEPS(0).Estado, "Mensaje de Sistema", _
                                MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                btnBuscar.Enabled = True
            End If
        Else
            fecInicio.Value = Date.Now.Date
            fecFin.Value = Date.Now.Date
            btnBuscar.Enabled = False
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If leRegSalud.Count > 0 Then
                leCalculaEps = New List(Of e_PlanillaEps)
                Dim _leTrabAct As New List(Of e_Trabajador), _leTrabLiq As New List(Of e_Trabajador)
                _leTrabAct = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 _
                                                         And it.FechaIngreso < oePlanilla.FechaFin).ToList
                _leTrabLiq = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 2 And it.IndTipo = 0 _
                                                         And it.FechaCese <> #1/1/1901# And it.FechaCese >= oePlanilla.FechaInicio).ToList
                _leTrabAct.AddRange(_leTrabLiq)

                oeTrabajador = New e_Trabajador
                oeTrabajador.TipoOperacion = String.Empty : oeTrabajador.Id = cboPlanilla.Value
                dsDatosGen = olTrabajador.CargarDatosGenerales(oeTrabajador).Tables(0)

                'Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _psrs = ValorParametro(gPPorcentajeEsSaludER, leParametro, leDetParametro)
                Dim _peps = ValorParametro(gPPorcentajeEsSaludEPS, leParametro, leDetParametro)
                Dim _idEst As String = ""
                Dim _leEst = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                If _leEst.Count > 0 Then _idEst = _leEst(0).Id
                For Each oeRS In leRegSalud
                    oeTrabajador = New e_Trabajador
                    oeTrabajador.Id = oeRS.IdTrabajador : oeTrabajador.TipoBusca = 1
                    If _leTrabAct.Contains(oeTrabajador) Then
                        oeTrabajador = _leTrabAct.Item(_leTrabAct.IndexOf(oeTrabajador))
                        oePlanillaEps = New e_PlanillaEps
                        oePlanillaEps.Calcula = True
                        oePlanillaEps.TipoOperacion = "I"
                        oePlanillaEps.Activo = True
                        oePlanillaEps.IdTrabajador = oeTrabajador.Id
                        oePlanillaEps.Dni = oeTrabajador.oePersona.Dni
                        oePlanillaEps.Trabajador = oeTrabajador.oePersona.NombreCompleto
                        oePlanillaEps.IdPlanilla = cboPlanilla.Value
                        oePlanillaEps.Planilla = cboPlanilla.Text
                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeTrabajador.Id & "'", "")
                        If _rwAux.Count > 0 Then
                            Dim _dsFila = _rwAux.CopyToDataTable
                            oePlanillaEps.Sueldo = EjecutaFormula(gFPIRenumBasico, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.AsignacionFamiliar = EjecutaFormula(gFPIAsigFam, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.HoraExtra25 = EjecutaFormula(gFPIHoraExt25, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.HoraExtra35 = EjecutaFormula(gFPIHoraExt35, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.HorasNocturnas = EjecutaFormula(gFPIHoraExtNoc, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.Movilidad = EjecutaFormula(gFPIMovilidad, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.BonoProduccion = EjecutaFormula(gFPIBonoProd, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.CompensacionVacacional = EjecutaFormula(gFPICompenVac, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.RenumeracionVacacional = EjecutaFormula(gFPIRenumVaca, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.BonoResponsabilidad = EjecutaFormula(gFPIBonoResp, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.DescansoMedico = EjecutaFormula(gFPIDescMed, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.VueltaAdicionalPiura = EjecutaFormula(gFPIVueltaPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.BonoCombustiblePiura = EjecutaFormula(gFPIBonoPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.BonoJefeConvoy = EjecutaFormula(gFPIConvoyPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.VueltaAdicionalLima = EjecutaFormula(gFPIVueltaLima, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.Otros = EjecutaFormula(gFPIOtros, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.VueltaCaliza = EjecutaFormula(gFPIVueltaCaliza, False, _dsFila, leFormula, leParametro, leDetParametro)
                            oePlanillaEps.Semaforo = EjecutaFormula(gFPISemaforo, False, _dsFila, leFormula, leParametro, leDetParametro)
                        End If
                        'If oeTrabajador.IndHijo = 1 Then oePlanillaEps.AsignacionFamiliar = _af
                        'oeSueldo = New e_SueldoTrabajador
                        'oeSueldo.IdTrabajador = oeTrabajador.Id : oeSueldo.Equivale = 1
                        'If leSueldo.Contains(oeSueldo) Then
                        '    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                        '    oePlanillaEps.Sueldo = oeSueldo.Sueldo
                        'End If
                        oePlanillaEps.PorcEss = _psrs
                        oePlanillaEps.PorcEps = _peps
                        oePlanesEps = New e_PlanesEPS
                        oePlanesEps.Id = oeRS.IdPlanEPS
                        oePlanesEps.Equivale = 1
                        If lePlanesEps.Contains(oePlanesEps) Then
                            oePlanesEps = lePlanesEps.Item(lePlanesEps.IndexOf(oePlanesEps))
                            oePlanillaEps.IdEpsContratada = oePlanesEps.Id
                            oePlanillaEps.EpsContratada = oePlanesEps.Precio
                            Select Case oeRS.Adicional
                                Case 0 : oePlanillaEps.Adicional = 0
                                Case 1 : oePlanillaEps.Adicional = oePlanesEps.Adicional1 - oePlanesEps.Precio
                                Case 2 : oePlanillaEps.Adicional = oePlanesEps.Adicional2 - oePlanesEps.Precio
                                Case 3 : oePlanillaEps.Adicional = oePlanesEps.Adicional3 - oePlanesEps.Precio
                                Case 4 : oePlanillaEps.Adicional = oePlanesEps.Adicional4 - oePlanesEps.Precio
                                Case 5 : oePlanillaEps.Adicional = oePlanesEps.Adicional5 - oePlanesEps.Precio
                            End Select
                            oePlanillaEps.Dependiente = oeRS.Adicional
                        End If
                        oePlanillaEps.UsuarioCreacion = gUsuarioSGI.Id
                        oePlanillaEps.IdEstado = _idEst
                        oePlanillaEps.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leCalculaEps.Add(oePlanillaEps)
                    End If
                Next
                btnAdicionar.Visible = True : btnAdicionar.Enabled = True
                btnAdicionar.Text = "Existen " & leCalculaEps.Count & " Registros"
            Else
                Throw New Exception("No hay Trabajadores con Regimen de Salud Privado")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            If MessageBox.Show("¿Desea Agregar los Registros Encontrados?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                CargarCalEps(leCalculaEps)
                griCalculaEps.DataBind()
                btnAdicionar.Enabled = False
                btnBuscar.Enabled = False
                btnCalcularDscto.Enabled = True
                cboPlanilla.ReadOnly = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCalcularDscto_Click(sender As Object, e As EventArgs) Handles btnCalcularDscto.Click
        Try
            For Each oePEPS In leCalculaEps
                oePEPS.Monto = oePEPS.TotalEps - (oePEPS.TitularDependiente * ndCreditoTD.Value)
            Next
            griCalculaEps.DataBind()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If lePlanillaEps.Count > 0 Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoEnviado).ToList
                        For Each oePEPS In lePlanillaEps
                            oePEPS.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oePEPS.TipoOperacion = "A"
                            oePEPS.UsuarioModifica = gUsuarioSGI.Id
                            If _leEstAux.Count > 0 Then oePEPS.IdEstado = _leEstAux(0).Id
                        Next
                        If olPlanillaEps.GuardarLista(lePlanillaEps) Then
                            mensajeEmergente.Confirmacion("Se la Planilla EPS se Envio correctamente", True)
                            btnEnviar.Enabled = False
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnExtornar_Click(sender As Object, e As EventArgs) Handles btnExtornar.Click
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                If lePlanillaEps.Count > 0 Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoGenerada).ToList
                        For Each oePEPS In lePlanillaEps
                            oePEPS.PrefijoID = gs_PrefijoIdSucursal '@0001
                            oePEPS.TipoOperacion = "A"
                            oePEPS.UsuarioModifica = gUsuarioSGI.Id
                            If _leEstAux.Count > 0 Then oePEPS.IdEstado = _leEstAux(0).Id
                        Next
                        If olPlanillaEps.GuardarLista(lePlanillaEps) Then
                            mensajeEmergente.Confirmacion("Se la Planilla EPS se Extorno correctamente", True)
                            btnExtornar.Enabled = False
                            Consultar(True)
                        End If
                    End If
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCalculaEps_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griCalculaEps.DoubleClickCell
        Try
            With griCalculaEps
                If .ActiveRow.Index > -1 Then
                    Select Case .ActiveCell.Column.Key
                        Case "Bonos"
                            Dim _Bonos As String
                            _Bonos = InputBox("Ingrese Bono:", "Mensaje de Sistema", .ActiveRow.Cells("Bonos").Value)
                            If Not IsNumeric(_Bonos) Then Throw New Exception("Solo se Permite Ingresar Números")
                            If _Bonos < 0 Then Throw New Exception("Debe Ingresar monto de Bonos mayor a Cero")
                            oePlanillaEps = New e_PlanillaEps
                            oePlanillaEps.Equivale = 1 : oePlanillaEps.Dni = .ActiveRow.Cells("Dni").Value
                            If leCalculaEps.Contains(oePlanillaEps) Then
                                oePlanillaEps = leCalculaEps.Item(leCalculaEps.IndexOf(oePlanillaEps))
                                oePlanillaEps.Bonos = _Bonos
                                CargarCalEps(leCalculaEps)
                            End If
                        Case "Sueldo" ' Optimizar Codigo
                            Dim _Sueldo As String
                            _Sueldo = InputBox("Ingrese Sueldo:", "Mensaje de Sistema", .ActiveRow.Cells("Sueldo").Value)
                            If Not IsNumeric(_Sueldo) Then Throw New Exception("Solo se Permite Ingresar Números")
                            If _Sueldo < 0 Then Throw New Exception("Debe Ingresar Sueldo mayor a Cero")
                            oePlanillaEps = New e_PlanillaEps
                            oePlanillaEps.Equivale = 1 : oePlanillaEps.Dni = .ActiveRow.Cells("Dni").Value
                            If leCalculaEps.Contains(oePlanillaEps) Then
                                oePlanillaEps = leCalculaEps.Item(leCalculaEps.IndexOf(oePlanillaEps))
                                oePlanillaEps.Sueldo = _Sueldo
                                CargarCalEps(leCalculaEps)
                            End If
                        Case "Regularizacion" ' Optimizar Codigo
                            Dim _Reg As String
                            _Reg = InputBox("Ingrese Regularizacion:", "Mensaje de Sistema", .ActiveRow.Cells("Regularizacion").Value)
                            If Not IsNumeric(_Reg) Then Throw New Exception("Solo se Permite Ingresar Números")
                            If _Reg < 0 Then Throw New Exception("Debe Ingresar Monto mayor a Cero")
                            oePlanillaEps = New e_PlanillaEps
                            oePlanillaEps.Equivale = 1 : oePlanillaEps.Dni = .ActiveRow.Cells("Dni").Value
                            If leCalculaEps.Contains(oePlanillaEps) Then
                                oePlanillaEps = leCalculaEps.Item(leCalculaEps.IndexOf(oePlanillaEps))
                                oePlanillaEps.Regularizacion = _Reg
                                CargarCalEps(leCalculaEps)
                            End If
                    End Select
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            Dim _lePlaAux As New List(Of e_Planilla)
            oePlanilla = New e_Planilla
            oePlanilla.Id = String.Empty : oePlanilla.Codigo = " [TODOS] "
            _lePlaAux.Add(oePlanilla)
            _lePlaAux.AddRange(lePlanilla.OrderByDescending(Function(it) it.Codigo))
            LlenarCombo(cboPlanillaBus, "Codigo", _lePlaAux, 0)

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA EPS"
            leEstado = olEstado.Listar(oeEstado)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = "" : oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oeRegSalud = New e_RegimenSalud
            oeRegSalud.TipoOperacion = "" : oeRegSalud.Regimen = "01" : oeRegSalud.Vigente = 1 : oeRegSalud.Activo = True
            leRegSalud = olRegSalud.Listar(oeRegSalud)

            oePlanesEps = New e_PlanesEPS
            oePlanesEps.TipoOperacion = "" : oePlanesEps.Vigente = 1 : oePlanesEps.Activo = True
            lePlanesEps = olPlanesEps.Listar(oePlanesEps)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oePlanillaEps = New e_PlanillaEps
            oePlanillaEps.TipoOperacion = ""
            oePlanillaEps.IdPlanilla = cboPlanillaBus.Value
            oePlanillaEps.Activo = True
            lePlanillaEps = olPlanillaEps.Listar(oePlanillaEps)
            CargarPlanillaEps(lePlanillaEps)
            btnEnviar.Enabled = False : btnExtornar.Enabled = False
            If oePlanillaEps.IdPlanilla.Trim <> String.Empty Then
                If lePlanillaEps.Count > 0 AndAlso lePlanillaEps(0).Estado = gNombreEstadoGenerada Then
                    btnEnviar.Enabled = True : btnExtornar.Enabled = False
                End If
                If lePlanillaEps.Count > 0 AndAlso lePlanillaEps(0).Estado = gNombreEstadoEnviado Then
                    btnEnviar.Enabled = False : btnExtornar.Enabled = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPlanillaEps(lePlaEps As List(Of e_PlanillaEps))
        Try
            With griPlanillaEps
                .ResetDisplayLayout()
                .Text = "REGISTROS DE DESCUENTO POR EPS"
                .DataSource = lePlaEps
                ConfiguraGrilla(griPlanillaEps, 1)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCalEps(leCalEps As List(Of e_PlanillaEps))
        Try
            With griCalculaEps
                .ResetDisplayLayout()
                .Text = "CALCULO DE DESCUENTO POR EPS"
                Dim _leAux = leCalEps.OrderBy(Function(it) it.Trabajador).ToList
                .DataSource = _leAux
                ConfiguraGrilla(griCalculaEps, 2)
                If leCalEps.Count > 0 Then
                    Dim _TotCred = leCalEps.Sum(Function(it) it.CreditoEps)
                    Dim _Afiliados = leCalEps.Sum(Function(it) it.TitularDependiente)
                    ndCreditoTD.Value = Math.Round(_TotCred / _Afiliados, 2)
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, _indtipo As Integer)
        Try
            With Grilla
                OcultarColumna(Grilla, True, "Id", "IdPlanilla", "IdTrabajador", "FechaCreacion", "UsuarioCreacion", "Activo", _
                               "IdEpsContratada", "IdEstado", "FechaModifica", "UsuarioModifica")
                If _indtipo = 2 Then OcultarColumna(Grilla, True, "Planilla", "Estado")
                ExcluirColumna(Grilla, "Id", "IdPlanilla", "IdTrabajador", "IdEpsContratada", "IdEstado", "Activo")
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Sueldo", "AsignacionFamiliar", "HoraExtra25", _
                               "HoraExtra35", "HorasNocturnas", "Movilidad", "BonoProduccion", "CompensacionVacacional", _
                               "RenumeracionVacacional", "BonoResponsabilidad", "DescansoMedico", "VueltaAdicionalPiura", _
                               "BonoCombustiblePiura", "BonoJefeConvoy", "VueltaAdicionalLima", "Otros", "VueltaCaliza", _
                               "Semaforo", "Dependiente", "TotalSueldo", "AporteEssalud", "CreditoEps", "EpsContratada", _
                               "Adicional", "TotalEps", "MontoPlanilla", "TitularDependiente", "Bonos", "Regularizacion", "Monto")
                ColorFondoColumna(Grilla, Color.Moccasin, "Dni", "Trabajador")
                ColorFondoColumna(Grilla, Color.LightCyan, "Sueldo", "AsignacionFamiliar", "HoraExtra25", _
                               "HoraExtra35", "HorasNocturnas", "Movilidad", "BonoProduccion", "CompensacionVacacional", _
                               "RenumeracionVacacional", "BonoResponsabilidad", "DescansoMedico", "VueltaAdicionalPiura", _
                               "BonoCombustiblePiura", "BonoJefeConvoy", "VueltaAdicionalLima", "Otros", "VueltaCaliza", _
                               "Semaforo", "EpsContratada", "Adicional", "Bonos")
                ColorFondoColumna(Grilla, Color.LightSkyBlue, "TotalSueldo", "TotalEps", "Monto")
                .DisplayLayout.Bands(0).Columns("MontoPlanilla").CellAppearance.BackColor = Color.Navy
                .DisplayLayout.Bands(0).Columns("MontoPlanilla").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Header.Caption = "Asig. Fam."
                .DisplayLayout.Bands(0).Columns("HoraExtra25").Header.Caption = "H. Extra25"
                .DisplayLayout.Bands(0).Columns("HoraExtra35").Header.Caption = "H. Extra35"
                .DisplayLayout.Bands(0).Columns("HorasNocturnas").Header.Caption = "H. Noct."
                .DisplayLayout.Bands(0).Columns("Movilidad").Header.Caption = "Movilid."
                .DisplayLayout.Bands(0).Columns("BonoProduccion").Header.Caption = "B. Prod."
                .DisplayLayout.Bands(0).Columns("CompensacionVacacional").Header.Caption = "C. Vac."
                .DisplayLayout.Bands(0).Columns("RenumeracionVacacional").Header.Caption = "R. Vac"
                .DisplayLayout.Bands(0).Columns("BonoResponsabilidad").Header.Caption = "B. Resp."
                .DisplayLayout.Bands(0).Columns("DescansoMedico").Header.Caption = "D. Med."
                .DisplayLayout.Bands(0).Columns("VueltaAdicionalPiura").Header.Caption = "V. A. Piu"
                .DisplayLayout.Bands(0).Columns("BonoCombustiblePiura").Header.Caption = "B. C. Piu"
                .DisplayLayout.Bands(0).Columns("BonoJefeConvoy").Header.Caption = "B. J. Conv."
                .DisplayLayout.Bands(0).Columns("VueltaAdicionalLima").Header.Caption = "V. A. Lima"
                .DisplayLayout.Bands(0).Columns("Otros").Header.Caption = "Otros Ing."
                .DisplayLayout.Bands(0).Columns("VueltaCaliza").Header.Caption = "V. Caliza"
                .DisplayLayout.Bands(0).Columns("Semaforo").Header.Caption = "Semaforo"
                .DisplayLayout.Bands(0).Columns("TitularDependiente").Header.Caption = "T + D"
                .DisplayLayout.Bands(0).Columns("Regularizacion").Header.Caption = "Reg."
                .DisplayLayout.Bands(0).Columns("AporteEssalud").Header.Caption = "EsSalud"
                .DisplayLayout.Bands(0).Columns("MontoPlanilla").Header.Caption = "Dscto."
                .DisplayLayout.Bands(0).Columns("EpsContratada").Header.Caption = "Eps. Cont."
                .DisplayLayout.Bands(0).Columns("Dependiente").Header.Caption = "Cant. Dep."
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(Grilla, "MontoPlanilla", "TotalSueldo", "TotalEps", "Dependiente", "TitularDependiente", "CreditoEps")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboPlanilla.ReadOnly = False
        cboPlanilla.SelectedIndex = -1
        btnBuscar.Enabled = False
        btnAdicionar.Visible = False
        btnCalcularDscto.Enabled = False
        ndCreditoTD.Value = 0
        leCalculaEps = New List(Of e_PlanillaEps)
        CargarCalEps(leCalculaEps)
    End Sub

    Private Sub SelecionarTab(_index As Integer)
        ficPlanillaEps.Tabs(0).Enabled = False
        ficPlanillaEps.Tabs(1).Enabled = False
        ficPlanillaEps.Tabs(_index).Enabled = True
        ficPlanillaEps.Tabs(_index).Selected = True
    End Sub

    Private Sub Mostrar()
        Try
           
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class