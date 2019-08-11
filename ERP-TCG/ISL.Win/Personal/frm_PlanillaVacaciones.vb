Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports MSScriptControl

Public Class frm_PlanillaVacaciones
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_PlanillaVacaciones = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_PlanillaVacaciones()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePlanillaVacaciones As New e_PlanillaVacaciones, olPlanillaVacaciones As New l_PlanillaVacaciones
    Private lePlanillaVacaciones As New List(Of e_PlanillaVacaciones)
    Private oeDetallePlaVac As New e_DetallePlanillaVacaciones, olDetallePlaVac As New l_DetallePLanillaVacaciones
    Private leDetallePlaVac As New List(Of e_DetallePlanillaVacaciones)
    Private oeResumenAsistencia As New e_ResumenAsistencia, olResumenAsistencia As New l_ResumenAsistencia
    Private leResumenAsistencia As New List(Of e_ResumenAsistencia), leResAsisAux As New List(Of e_ResumenAsistencia)
    Private oeBonoProd As New e_BonificacionProduccion, olBonoProd As New l_BonificacionProduccion, leBonoProd As New List(Of e_BonificacionProduccion)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private dsDatosGen As New Data.DataTable, _acl As String = "", _estado As String = ""
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opePlaVac As String = ""

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griPlanillaVacaciones.Rows.Count > 0 Then
                ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
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
                _opePlaVac = "GENERADA"
                oePlanillaVacaciones = New e_PlanillaVacaciones
                oePlanillaVacaciones.TipoOperacion = "I"
                oePlanillaVacaciones.Activo = True
                Inicializa()
                cboPlanilla.ReadOnly = False
                txtCodigo.Text = fn_ObtenerCodigo()
                _estado = gNombreEstadoGenerada
                cboEstado.Text = _estado
                MostrarTabs(1, ficPlanillaVacaciones)
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
            _acl = gAccionSistema.EDITAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opePlaVac = "GENERADA"
                Inicializa()
                cboPlanilla.ReadOnly = True
                Mostrar()
                oePlanillaVacaciones.TipoOperacion = "A"
                MostrarTabs(1, ficPlanillaVacaciones)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case _opePlaVac
                Case "GENERADA"
                    RecolectaDatos()
                    oePlanillaVacaciones.UsuarioCreacion = gUsuarioSGI.Id
                    olPlanillaVacaciones.Guardar(oePlanillaVacaciones)
                    mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanillaVacaciones.Codigo & _
                                                  " se Guardo correctamente!", True)
                Case "ENVIAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        'oePlanillaVacaciones.Monto = leDetallePlaVac.Sum(Function(it) it.Monto)
                        oePlanillaVacaciones.IdEstado = cboEstado.Value
                        oePlanillaVacaciones.UsuarioModifica = gUsuarioSGI.Id
                        olPlanillaVacaciones.Guardar(oePlanillaVacaciones)
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanillaVacaciones.Codigo & _
                                                      " se Envio correctamente!", True)
                    End If
                Case "TERMINAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oePlanillaVacaciones.IdEstado = cboEstado.Value
                        oePlanillaVacaciones.UsuarioModifica = gUsuarioSGI.Id
                        olPlanillaVacaciones.Guardar(oePlanillaVacaciones)
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanillaVacaciones.Codigo & _
                                                      " se Termino correctamente!", True)
                    End If
            End Select
            MostrarTabs(0, ficPlanillaVacaciones)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                MostrarTabs(0, ficPlanillaVacaciones)
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
                _estado = gNombreEstadoGenerada
                If griPlanillaVacaciones.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oePlanillaVacaciones = New e_PlanillaVacaciones
                        oePlanillaVacaciones.TipoOperacion = ""
                        oePlanillaVacaciones.Id = griPlanillaVacaciones.ActiveRow.Cells("Id").Value
                        oePlanillaVacaciones = olPlanillaVacaciones.Obtener(oePlanillaVacaciones)
                        oePlanillaVacaciones.UsuarioModifica = gUsuarioSGI.Id
                        olPlanillaVacaciones.Eliminar(oePlanillaVacaciones)
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanillaVacaciones.Codigo & _
                                                             " se ha Eliminado correctamente!", True)
                        MostrarTabs(0, ficPlanillaVacaciones)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("No puede en ELIMINAR el Registro de Planilla de Vacaciones Nº: " & _
                                        griPlanillaVacaciones.ActiveRow.Cells("Codigo").Value & " por no esta GENERADA.")
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
                Select Case ficPlanillaVacaciones.SelectedTab.Index
                    Case 0
                        If griPlanillaVacaciones.Rows.Count > 0 Then
                            Exportar_Excel(griPlanillaVacaciones, "Planilla Vacaciones")
                        Else
                            Throw New Exception("No hay Registros para Exportar")
                        End If
                    Case 1
                        Select Case ficDetalle.SelectedTab.Index
                            Case 0
                                If griDetallePlaVac.Rows.Count > 0 Then
                                    Exportar_Excel(griDetallePlaVac, "Detalle Planilla Vacaciones")
                                Else
                                    Throw New Exception("No hay Registros para Exportar")
                                End If
                            Case 1
                                If griCompraVac.Rows.Count > 0 Then
                                    Exportar_Excel(griCompraVac, "Compra Vacaciones")
                                Else
                                    Throw New Exception("No hay Registros para Exportar")
                                End If
                        End Select
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

    Private Sub frm_PlanillaVacaciones_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficPlanillaVacaciones.SelectedTab.Index
            Case 0
                If griPlanillaVacaciones.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_PlanillaVacaciones_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_PlanillaVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            CargarPlanillaVacaciones(New List(Of e_PlanillaVacaciones))
            CargarDetallePlaVac(New List(Of e_DetallePlanillaVacaciones))
            CargarDetalleCompra(New List(Of e_DetallePlanillaVacaciones))
            Año1.Año = Date.Now.Year
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            MostrarTabs(0, ficPlanillaVacaciones)
            btnCargarDatos.Visible = False
            colorGenerada.Color = Color.White
            colorEnviado.Color = Color.LightYellow
            colorTerminada.Color = Color.LightGreen
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Año1_DatoCambiado() Handles Año1.DatoCambiado
        Try
            Dim _lePeriodoAux As New List(Of e_Periodo)
            oePeriodo = New e_Periodo
            oePeriodo.Codigo = "[TODOS]"
            oePeriodo.Id = ""
            _lePeriodoAux.Add(oePeriodo)
            _lePeriodoAux.AddRange(lePeriodo.Where(Function(it) it.Ejercicio = Año1.Año).ToList)
            LlenarCombo(cboMes, "Codigo", _lePeriodoAux, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboMes_ValueChanged(sender As Object, e As EventArgs) Handles cboMes.ValueChanged
        Try
            Dim _lePlanillaAux As New List(Of e_Planilla)
            oePlanilla = New e_Planilla
            oePlanilla.Codigo = "[TODOS]"
            oePlanilla.Id = ""
            _lePlanillaAux.Add(oePlanilla)
            If cboMes.Text <> "[TODOS]" Then
                _lePlanillaAux.AddRange(lePlanilla.Where(Function(it) it.IdPeriodo = cboMes.Value).ToList)
            Else
                _lePlanillaAux.AddRange(lePlanilla.Where(Function(it) it.Periodo.Substring(0, 4) = Año1.Año).ToList)
            End If
            LlenarCombo(cboPlanillaBus, "Codigo", _lePlanillaAux, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanillaBus_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaBus.ValueChanged
        Try
            If cboPlanillaBus.Text <> "[TODOS]" Then
                oePlanilla = cboPlanillaBus.Items(cboPlanillaBus.SelectedIndex).ListObject
                fecInicio.Value = oePlanilla.FechaInicio
                fecFin.Value = oePlanilla.FechaFin
            Else
                fecInicio.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPlanillaVacaciones_DoubleClick(sender As Object, e As EventArgs) Handles griPlanillaVacaciones.DoubleClick
        If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try
            If leResumenAsistencia.Count > 0 Then
                If MessageBox.Show("¿Desar Agregar los Registros?", "Mensaje de Sistema", _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Dim _af = EjecutaFormula("AsignacionFamiliar", False, Nothing, leFormula, leParametro, leDetParametro)
                    Dim _IdTrab As String = ""
                    For Each oeAsiAux In leResumenAsistencia.Where(Function(it) it.IndTipoAux = 0).OrderBy(Function(it) it.Trabajador).ToList
                        If _IdTrab <> oeAsiAux.IdTrabajador Then
                            _IdTrab = oeAsiAux.IdTrabajador
                            oeDetallePlaVac = New e_DetallePlanillaVacaciones
                            oeDetallePlaVac.IdTrabajador = oeAsiAux.IdTrabajador
                            oeTrabajador = New e_Trabajador
                            oeTrabajador.Id = oeAsiAux.IdTrabajador : oeTrabajador.TipoBusca = 1
                            If leTrabajador.Contains(oeTrabajador) Then
                                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                oeDetallePlaVac.Trabajador = oeTrabajador.oePersona.NombreCompleto
                                oeDetallePlaVac.Dni = oeTrabajador.oePersona.Dni
                                If oeTrabajador.IndHijo = 1 Then oeDetallePlaVac.AsignacionFamiliar = _af
                                oeSueldo = New e_SueldoTrabajador
                                oeSueldo.IdTrabajador = oeAsiAux.IdTrabajador : oeSueldo.Equivale = 1
                                If leSueldo.Contains(oeSueldo) Then
                                    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                                    oeDetallePlaVac.Sueldo = oeSueldo.Sueldo
                                    oeDetallePlaVac.DiasVacaciones = leResumenAsistencia.Where(Function(it) it.IdTrabajador = _IdTrab And it.IndTipoAux = 0).Sum(Function(it) it.Cantidad)
                                    oeDetallePlaVac.TipoOperacion = "I"
                                    oeDetallePlaVac.Activo = IIf(oeTrabajador.IndEstado = 0, False, True)
                                    oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                    leDetallePlaVac.Add(oeDetallePlaVac)
                                End If
                            Else
                                oeDetallePlaVac.Activo = False
                            End If
                        End If
                    Next
                    ' Corregir Urgente
                    For Each oeAsiAux In leResumenAsistencia.Where(Function(it) it.IndTipoAux = 1).OrderBy(Function(it) it.Trabajador).ToList
                        If _IdTrab <> oeAsiAux.IdTrabajador Then
                            _IdTrab = oeAsiAux.IdTrabajador
                            oeDetallePlaVac = New e_DetallePlanillaVacaciones
                            oeDetallePlaVac.IdTrabajador = oeAsiAux.IdTrabajador
                            oeTrabajador = New e_Trabajador
                            oeTrabajador.Id = oeAsiAux.IdTrabajador
                            oeTrabajador.TipoBusca = 1
                            If leTrabajador.Contains(oeTrabajador) Then
                                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                                oeDetallePlaVac.Trabajador = oeTrabajador.oePersona.NombreCompleto
                                oeDetallePlaVac.Dni = oeTrabajador.oePersona.Dni
                                'If oeTrabajador.IndHijo = 1 Then
                                oeDetallePlaVac.AsignacionFamiliar = 0
                                'End If
                                oeSueldo = New e_SueldoTrabajador
                                oeSueldo.IdTrabajador = oeAsiAux.IdTrabajador
                                oeSueldo.Equivale = 1
                                If leSueldo.Contains(oeSueldo) Then
                                    oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                                    oeDetallePlaVac.Sueldo = oeSueldo.Sueldo
                                    oeDetallePlaVac.DiasComprados = leResumenAsistencia.Where(Function(it) it.IdTrabajador = _IdTrab And it.IndTipoAux = 1).Sum(Function(it) it.Cantidad)
                                    oeDetallePlaVac.TipoOperacion = "I"
                                    oeDetallePlaVac.Activo = True
                                    oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                    leDetallePlaVac.Add(oeDetallePlaVac)
                                End If
                            End If
                        End If
                    Next
                    CargarDetallePlaVac(leDetallePlaVac)
                    CargarDetalleCompra(leDetallePlaVac)
                    griDetallePlaVac.UpdateData()
                    griDetallePlaVac.DataBind()
                    ndTotal.Value = leDetallePlaVac.Where(Function(it) it.Activo = True).Sum(Function(it) it.TotalPagar)
                    ndTotal.Update()
                    btnAdicionar.Enabled = False
                    btnCargarBono.Visible = True
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                If oePlanillaVacaciones.TipoOperacion = "I" Then
                    Dim oePV As New e_PlanillaVacaciones
                    oePV.TipoOperacion = ""
                    oePV.IdPlanilla = _oeplaaux.id
                    oePV.Activo = True
                    oePV = olPlanillaVacaciones.Obtener(oePV)
                    If oePV.Id <> "" Then
                        fecInicio2.Value = Date.Now.Date : fecFin2.Value = Date.Now.Date
                        txtDescripcion.Text = String.Empty
                        btnCargarDatos.Visible = False
                        cboPlanilla.SelectedIndex = -1
                        Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & "," & Environment.NewLine & _
                                            "ya se encuentra en la Planilla de Vacaciones Nº: " & oePV.Codigo)
                    Else
                        fecInicio2.Value = _oeplaaux.FechaInicio : fecFin2.Value = _oeplaaux.FechaFin
                        txtDescripcion.Text = "PLANILLA DE VACACIONES Nº " & txtCodigo.Text & " MES " & MonthName(_oeplaaux.NroMes) & " AÑO " & _oeplaaux.Ejercicio
                        btnCargarDatos.Visible = True
                    End If
                Else
                    btnCargarDatos.Visible = False
                End If
            Else
                fecInicio2.Value = Date.Now.Date
                fecFin2.Value = Date.Now.Date
                btnCargarDatos.Visible = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            oeResumenAsistencia = New e_ResumenAsistencia
            oeResumenAsistencia.IdPlanilla = cboPlanilla.Value : oeResumenAsistencia.TipoOperacion = ""
            oeResumenAsistencia.Activo = True : oeResumenAsistencia.GozedeHaber = -1 : oeResumenAsistencia.IndTipo = 2
            Dim _leEstAux = leEstado.Where(Function(it) it.Nombre = gNombreEstadoEnviado).ToList
            If _leEstAux.Count > 0 Then oeResumenAsistencia.IdEstado = _leEstAux(0).Id
            leResumenAsistencia = olResumenAsistencia.Listar(oeResumenAsistencia)
            If leResumenAsistencia.Count > 0 Then
                Dim _oeTrabAux As New e_Trabajador
                _oeTrabAux.TipoOperacion = ""
                _oeTrabAux.Id = cboPlanilla.Value
                dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
                btnCargarDatos.Enabled = False
                btnAdicionar.Visible = True
                btnAdicionar.Enabled = True
                btnAdicionar.Text = "Existen " & leResumenAsistencia.Count & " Registros"
            Else
                btnAdicionar.Visible = False : btnAdicionar.Text = String.Empty
                Throw New Exception("No se Encontraron Registros de Vacaciones!!!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargarBono_Click(sender As Object, e As EventArgs) Handles btnCargarBono.Click
        Try
            If griDetallePlaVac.Rows.Count > 0 Then
                Dim _idPla As String = ""
                Dim _ctn As Integer = 0
                Dim _lePlaAux = lePlanilla.Where(Function(it) it.Tipo = 0).OrderByDescending(Function(it) it.Codigo).ToList
                For Each oeAux In _lePlaAux
                    If _ctn >= 1 And _ctn <= 6 Then
                        _idPla = _idPla & "'" & oeAux.Id & "'," : _ctn = _ctn + 1
                    End If
                    If _ctn = 0 AndAlso oeAux.Id = cboPlanilla.Value Then _ctn = 1
                    If _ctn > 6 Then Exit For
                Next
                If _idPla.Trim.Length > 0 Then
                    _idPla = _idPla.Substring(0, _idPla.Length - 1)
                    oeBonoProd = New e_BonificacionProduccion
                    oeBonoProd.IdPlanilla = _idPla
                    oeBonoProd.TipoOperacion = "R"
                    leBonoProd = olBonoProd.Listar(oeBonoProd)
                    If leBonoProd.Count > 0 Then
                        LlenarProduccion(leBonoProd, _idPla)
                        btnCargarBono.Enabled = False
                    Else
                        Throw New Exception("No hay Registros de Bonificaciones")
                    End If
                Else
                    Throw New Exception("No hay Registros de Planillas anterior a la actual")
                End If
            Else
                Throw New Exception("No hay Registros de Trabajadores en Vacaciones")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ndTotal_ValueChanged(sender As Object, e As EventArgs) Handles ndTotal.ValueChanged
        ndTotal.Update()
    End Sub

    Private Sub griDetallePlaVac_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griDetallePlaVac.DoubleClickCell
        Try
            With griDetallePlaVac
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "IndAdelanto"
                                If .ActiveRow.Cells("IndAdelanto").Value = False Then
                                    If MessageBox.Show("¿Desea Generar un Adelanto de Vacaciones al Trabajador: " & _
                                                  .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & .ActiveRow.Cells("IdTrabajador").Value & "'", "")
                                        If _rwAux.Count > 0 Then
                                            Dim _montoadelanto As String
                                            _montoadelanto = InputBox("Ingrese Monto de Adelanto:", "Mensaje de Sistema", .ActiveRow.Cells("MontoAdelanto").Value)
                                            If Not IsNumeric(_montoadelanto) Then Throw New Exception("Solo se Permite Ingresar Números")
                                            If _montoadelanto < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                            .ActiveRow.Cells("MontoAdelanto").Value = _montoadelanto
                                            .ActiveRow.Cells("MontoDescuento").Value = 0
                                            .ActiveRow.Cells("IndAdelanto").Value = True
                                            oeDetallePlaVac = New e_DetallePlanillaVacaciones
                                            oeDetallePlaVac.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                            oeDetallePlaVac.Id = .ActiveRow.Cells("Id").Value
                                            oeDetallePlaVac.Equivale = 2
                                            If leDetallePlaVac.Contains(oeDetallePlaVac) Then
                                                oeDetallePlaVac = leDetallePlaVac.Item(leDetallePlaVac.IndexOf(oeDetallePlaVac))
                                                If oeDetallePlaVac.Id.Trim <> "" Then
                                                    oeDetallePlaVac.UsuarioModifica = gUsuarioSGI.Id
                                                    oeDetallePlaVac.TipoOperacion = "A"
                                                Else
                                                    oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                                    oeDetallePlaVac.TipoOperacion = "I"
                                                End If
                                            End If
                                        Else
                                            Throw New Exception("No hay Datos del Trabajador: " & .ActiveRow.Cells("IdTrabajador").Value)
                                        End If                               
                                    End If
                                Else
                                    If MessageBox.Show("¿Desea quitar Adelanto de Vacaciones al Trabajador: " & _
                                                 .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("MontoAdelanto").Value = 0
                                        .ActiveRow.Cells("MontoDescuento").Value = 0
                                        .ActiveRow.Cells("IndAdelanto").Value = False
                                        oeDetallePlaVac = New e_DetallePlanillaVacaciones
                                        oeDetallePlaVac.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                        oeDetallePlaVac.Id = .ActiveRow.Cells("Id").Value
                                        oeDetallePlaVac.Equivale = 2
                                        If leDetallePlaVac.Contains(oeDetallePlaVac) Then
                                            oeDetallePlaVac = leDetallePlaVac.Item(leDetallePlaVac.IndexOf(oeDetallePlaVac))
                                            If oeDetallePlaVac.Id.Trim <> "" Then
                                                oeDetallePlaVac.UsuarioModifica = gUsuarioSGI.Id
                                                oeDetallePlaVac.TipoOperacion = "A"
                                            Else
                                                oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                                oeDetallePlaVac.TipoOperacion = "I"
                                            End If
                                        End If
                                    End If
                                End If
                                .UpdateData()
                                ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
                            Case "DiasComprados"
                                Dim _diascomp As String
                                If .ActiveRow.Cells("IndAdelanto").Value Then
                                    Throw New Exception("No puede Comprar Vacaciones porque ya se dio por Adelantado")
                                Else
                                    _diascomp = InputBox("Ingrese Dias a Comprar:", "Mensaje de Sistema", .ActiveRow.Cells("DiasComprados").Value)
                                    If Not IsNumeric(_diascomp) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _diascomp < 0 Then Throw New Exception("Debe Ingresar un Dias mayor a Cero")
                                    If .ActiveRow.Cells("DiasVacaciones").Value < _diascomp Then Throw New Exception("No puede vender mas de " & .ActiveRow.Cells("DiasVacaciones").Value & " dias.")
                                    .ActiveRow.Cells("DiasComprados").Value = _diascomp
                                    .UpdateData()
                                    ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
                                End If
                            Case "IndPromBono"
                                If .ActiveRow.Cells("IndPromBono").Value = False Then
                                    If MessageBox.Show("¿Desea Agregar el Promedio de Bonos al Trabajador: " & _
                                                  .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromBono").Value = 1
                                    End If
                                Else
                                    If MessageBox.Show("¿Desea quitar el Promedio de Bonos al Trabajador: " & _
                                                .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromBono").Value = 0
                                    End If
                                End If
                                .UpdateData()
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griCompraVac_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griCompraVac.DoubleClickCell
        Try
            With griCompraVac
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "IndAdelanto"
                                If .ActiveRow.Cells("IndAdelanto").Value = False Then
                                    If MessageBox.Show("¿Desea Generar un Adelanto de Vacaciones al Trabajador: " & _
                                                  .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & .ActiveRow.Cells("IdTrabajador").Value & "'", "")
                                        If _rwAux.Count > 0 Then
                                            Dim _montoadelanto As String
                                            _montoadelanto = InputBox("Ingrese Monto de Adelanto:", "Mensaje de Sistema", .ActiveRow.Cells("MontoAdelanto").Value)
                                            If Not IsNumeric(_montoadelanto) Then Throw New Exception("Solo se Permite Ingresar Números")
                                            If _montoadelanto < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                            .ActiveRow.Cells("MontoAdelanto").Value = _montoadelanto
                                            .ActiveRow.Cells("MontoDescuento").Value = 0
                                            .ActiveRow.Cells("IndAdelanto").Value = True
                                            oeDetallePlaVac = New e_DetallePlanillaVacaciones
                                            oeDetallePlaVac.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                            oeDetallePlaVac.Id = .ActiveRow.Cells("Id").Value
                                            oeDetallePlaVac.Equivale = 2
                                            If leDetallePlaVac.Contains(oeDetallePlaVac) Then
                                                oeDetallePlaVac = leDetallePlaVac.Item(leDetallePlaVac.IndexOf(oeDetallePlaVac))
                                                If oeDetallePlaVac.Id.Trim <> "" Then
                                                    oeDetallePlaVac.UsuarioModifica = gUsuarioSGI.Id
                                                    oeDetallePlaVac.TipoOperacion = "A"
                                                Else
                                                    oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                                    oeDetallePlaVac.TipoOperacion = "I"
                                                End If
                                            End If
                                        Else
                                            Throw New Exception("No hay Datos del Trabajador: " & .ActiveRow.Cells("IdTrabajador").Value)
                                        End If
                                    End If
                                Else
                                    If MessageBox.Show("¿Desea quitar Adelanto de Vacaciones al Trabajador: " & _
                                                 .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("MontoAdelanto").Value = 0
                                        .ActiveRow.Cells("MontoDescuento").Value = 0
                                        .ActiveRow.Cells("IndAdelanto").Value = False
                                        oeDetallePlaVac = New e_DetallePlanillaVacaciones
                                        oeDetallePlaVac.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                        oeDetallePlaVac.Id = .ActiveRow.Cells("Id").Value
                                        oeDetallePlaVac.Equivale = 2
                                        If leDetallePlaVac.Contains(oeDetallePlaVac) Then
                                            oeDetallePlaVac = leDetallePlaVac.Item(leDetallePlaVac.IndexOf(oeDetallePlaVac))
                                            If oeDetallePlaVac.Id.Trim <> "" Then
                                                oeDetallePlaVac.UsuarioModifica = gUsuarioSGI.Id
                                                oeDetallePlaVac.TipoOperacion = "A"
                                            Else
                                                oeDetallePlaVac.UsuarioCreacion = gUsuarioSGI.Id
                                                oeDetallePlaVac.TipoOperacion = "I"
                                            End If
                                        End If
                                    End If
                                End If
                                .UpdateData()
                                ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkDetalle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetalle.CheckedChanged
        OcultarColumna(griDetallePlaVac, Not chkDetalle.Checked, "Produccion1", "Produccion2", "Produccion3", "Produccion4", "Produccion5", "Produccion6")
        OcultarColumna(griCompraVac, Not chkDetalle.Checked, "Produccion1", "Produccion2", "Produccion3", "Produccion4", "Produccion5", "Produccion6")
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = ""
            oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            Dim _lePlanillaAux = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList
            LlenarCombo(cboPlanilla, "Codigo", _lePlanillaAux, -1)

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA EPS"
            leEstado = olEstado.Listar(oeEstado)

            oeEstado = New e_Estado
            oeEstado.Id = String.Empty
            oeEstado.Nombre = "[TODOS]"

            Dim _leEstadoAux As New List(Of e_Estado)
            _leEstadoAux.Add(oeEstado)
            _leEstadoAux.AddRange(leEstado)

            LlenarCombo(cboEstadoBus, "Nombre", _leEstadoAux, 0)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = ""
            oeSueldo.Activo = True
            oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = ""
            oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = ""
            oeDetParametro.Activo = True
            oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = ""
            oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oePlanillaVacaciones = New e_PlanillaVacaciones
            oePlanillaVacaciones.TipoOperacion = ""
            oePlanillaVacaciones.Activo = True
            oePlanillaVacaciones.IdPlanilla = cboPlanillaBus.Value
            oePlanillaVacaciones.IdEstado = cboEstadoBus.Value
            lePlanillaVacaciones = olPlanillaVacaciones.Listar(oePlanillaVacaciones)
            CargarPlanillaVacaciones(lePlanillaVacaciones)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPlanillaVacaciones(lePlaVac As List(Of e_PlanillaVacaciones))
        Try
            With griPlanillaVacaciones

                .ResetDisplayLayout()
                .Text = "REGISTRO DE PLANILLAS DE VACACIONES"
                .DataSource = lePlaVac

                OcultarColumna(griPlanillaVacaciones, True, "Id", "IdPlanilla", "IdEstado", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo")

                ExcluirColumna(griPlanillaVacaciones, "Id", "IdPlanilla", "IdEstado", "Activo")

                .DisplayLayout.Bands(0).Columns("Planilla").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 4

                FormatoColumna(griPlanillaVacaciones, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
                .DisplayLayout.Bands(0).Columns("Monto").CellAppearance.BackColor = Color.LightBlue

                .DisplayLayout.Bands(0).Columns("Descripcion").Width = 400

                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

                If .Rows.Count > 0 Then
                    For Each Fila As UltraGridRow In .Rows
                        Select Case Fila.Cells("Estado").Value
                            Case "GENERADA" : Fila.Appearance.BackColor = colorGenerada.Color
                            Case "ENVIADO" : Fila.Appearance.BackColor = colorEnviado.Color
                            Case "TERMINADA" : Fila.Appearance.BackColor = colorTerminada.Color
                        End Select
                    Next
                End If

            End With

            CalcularTotales(griPlanillaVacaciones, "Monto")
            ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
            ndTotal.Update()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        cboEstado.SelectedIndex = -1
        cboEstado.ReadOnly = True
        cboPlanilla.SelectedIndex = -1
        btnAdicionar.Visible = False
        btnCargarBono.Visible = False
        btnCargarDatos.Enabled = True
        btnCargarBono.Enabled = True
        ndTotal.ReadOnly = True
        chkDetalle.Checked = True
        leDetallePlaVac = New List(Of e_DetallePlanillaVacaciones)
        CargarDetallePlaVac(leDetallePlaVac)
        CargarDetalleCompra(leDetallePlaVac)
        ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
        dsDatosGen = Nothing
        ficDetalle.Tabs(0).Selected = True
    End Sub

    Private Sub Mostrar()
        Try
            oePlanillaVacaciones = New e_PlanillaVacaciones
            oePlanillaVacaciones.TipoOperacion = ""
            oePlanillaVacaciones.Id = griPlanillaVacaciones.ActiveRow.Cells("Id").Value
            oePlanillaVacaciones = olPlanillaVacaciones.Obtener(oePlanillaVacaciones)
            With oePlanillaVacaciones
                txtCodigo.Text = .Codigo
                txtDescripcion.Text = .Descripcion
                ndTotal.Value = .Monto
                cboEstado.Value = .IdEstado
                cboPlanilla.Value = .IdPlanilla
                leDetallePlaVac = .leDetalle
                CargarDetallePlaVac(leDetallePlaVac)
                CargarDetalleCompra(leDetallePlaVac)
                Dim _oeTrabAux As New e_Trabajador
                _oeTrabAux.TipoOperacion = ""
                _oeTrabAux.Id = oePlanillaVacaciones.IdPlanilla
                dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetallePlaVac(leDetPlaVac As List(Of e_DetallePlanillaVacaciones))
        Try
            With griDetallePlaVac
                .ResetDisplayLayout()
                Dim _leAux = leDetPlaVac.Where(Function(it) it.Activo = True And it.DiasComprados = 0).ToList
                .DataSource = _leAux
                .Text = "LISTADO DETALLADO DE CALCULO DE VACACIONES"
                ConfiguraGrillaDet(griDetallePlaVac, 1)
            End With
            CalcularTotales(griDetallePlaVac, "TotalPagar", "MontoAdelanto")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetalleCompra(leDetCompra As List(Of e_DetallePlanillaVacaciones))
        Try
            With griCompraVac
                .ResetDisplayLayout()
                Dim _leAux = leDetCompra.Where(Function(it) it.Activo = True And it.DiasComprados <> 0).ToList
                .DataSource = _leAux
                .Text = "LISTADO DETALLADO DE COMPRA DE VACACIONES"
                ConfiguraGrillaDet(griCompraVac, 2)
            End With
            CalcularTotales(griCompraVac, "MontoComprado", "MontoAdelanto")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrillaDet(Grilla As UltraGrid, Tipo As Integer)
        Try
            With Grilla
                .ResetDisplayLayout()
                OcultarColumna(Grilla, True, "Id", "IdTrabajador", "IdPlanillaVacaciones", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo")
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Sueldo", "AsignacionFamiliar", "Renumeracion", _
                               "TotalPagar", "Produccion1", "Produccion2", "Produccion3", "Produccion4", "Produccion5", "Produccion6", _
                               "PromedioProduccion", "Monto", "MontoAdelanto", "MontoDescuento", "DiasComprados", "MontoComprado")
                FormatoColumna(Grilla, "", ColumnStyle.CheckBox, HAlign.Center, "IndPromBono", "IndAdelanto")
                If Tipo = 1 Then
                    OcultarColumna(Grilla, True, "DiasComprados", "MontoComprado")
                Else
                    OcultarColumna(Grilla, True, "TotalPagar", "DiasVacaciones")
                    .DisplayLayout.Bands(0).Columns("DiasComprados").Header.VisiblePosition = 3
                End If
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Width = 70
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Header.Caption = "Asig. Fam."
                .DisplayLayout.Bands(0).Columns("DiasVacaciones").Header.Caption = "Dias Vac."
                .DisplayLayout.Bands(0).Columns("Produccion1").Header.Caption = "Prod 1"
                .DisplayLayout.Bands(0).Columns("Produccion2").Header.Caption = "Prod 2"
                .DisplayLayout.Bands(0).Columns("Produccion3").Header.Caption = "Prod 3"
                .DisplayLayout.Bands(0).Columns("Produccion4").Header.Caption = "Prod 4"
                .DisplayLayout.Bands(0).Columns("Produccion5").Header.Caption = "Prod 5"
                .DisplayLayout.Bands(0).Columns("Produccion6").Header.Caption = "Prod 6"
                .DisplayLayout.Bands(0).Columns("PromedioProduccion").Header.Caption = "Prom. Prod."
                .DisplayLayout.Bands(0).Columns("TotalPagar").Header.Caption = "Total a Pagar"
                .DisplayLayout.Bands(0).Columns("IndAdelanto").Header.Caption = "Adelanto"
                .DisplayLayout.Bands(0).Columns("MontoAdelanto").Header.Caption = "Monto Adel."
                .DisplayLayout.Bands(0).Columns("MontoDescuento").Header.Caption = "Monto Dscto"
                .DisplayLayout.Bands(0).Columns("DiasComprados").Header.Caption = "Dias Comp."
                .DisplayLayout.Bands(0).Columns("MontoComprado").Header.Caption = "Total a Comp."
                .DisplayLayout.Bands(0).Columns("IndPromBono").Header.Caption = "Bono"
                ColorFondoColumna(Grilla, Color.Moccasin, "Dni", "Trabajador", "DiasVacaciones", "Monto")
                ColorFondoColumna(Grilla, Color.LightCyan, "Sueldo", "AsignacionFamiliar", "Produccion1", "Produccion2", _
                                  "Produccion3", "Produccion4", "Produccion5", "Produccion6")
                ColorFondoColumna(Grilla, Color.LightSkyBlue, "Renumeracion", "PromedioProduccion")
                ColorFondoColumna(Grilla, Color.Navy, "TotalPagar", "MontoAdelanto", "MontoComprado")
                .DisplayLayout.Bands(0).Columns("TotalPagar").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("MontoAdelanto").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("MontoComprado").CellAppearance.ForeColor = Color.White
                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("Dni").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("DiasVacaciones").Header.Fixed = True
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

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oePlaVac As New e_PlanillaVacaciones
            oePlaVac.TipoOperacion = "U"
            oePlaVac = olPlanillaVacaciones.Obtener(oePlaVac)
            If oePlaVac IsNot Nothing AndAlso oePlaVac.Codigo <> "" Then
                str = oePlaVac.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RecolectaDatos()
        oePlanillaVacaciones.Codigo = txtCodigo.Text
        oePlanillaVacaciones.Monto = ndTotal.Value
        oePlanillaVacaciones.IdEstado = cboEstado.Value
        oePlanillaVacaciones.Descripcion = txtDescripcion.Text
        oePlanillaVacaciones.IdPlanilla = cboPlanilla.Value
        oePlanillaVacaciones.leDetalle = leDetallePlaVac
    End Sub

    Private Sub LlenarProduccion(leBPR As List(Of e_BonificacionProduccion), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leBPAux As New List(Of e_BonificacionProduccion)
            Dim _mes As Integer = 0
            Dim i As Integer = 0, _nroBono As Integer = 0
            For i = 0 To idpla.Count - 1
                Dim _le = leBPR.Where(Function(it) "'" & it.IdPlanilla & "'" = idpla(i)).ToList
                _mes = idpla.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            For Each fil1 In griDetallePlaVac.Rows
                _leBPAux = leBPR.Where(Function(it) it.IdTrabajador = fil1.Cells("IdTrabajador").Value).ToList
                fil1.Cells("IndPromBono").Value = 1
                For Each _aux In _leBPAux
                    fil1.Cells("Produccion" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla
                Next
                fil1.Cells("IndPromBono").Value = IIf(fil1.Cells("PromedioProduccion").Value > 0, 1, 0)
            Next
            For Each fil2 In griCompraVac.Rows
                _nroBono = 0
                _leBPAux = leBPR.Where(Function(it) it.IdTrabajador = fil2.Cells("IdTrabajador").Value).ToList
                fil2.Cells("IndPromBono").Value = 1
                For Each _aux In _leBPAux
                    fil2.Cells("Produccion" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla : _nroBono = _nroBono + 1
                Next
                fil2.Cells("IndPromBono").Value = IIf(_nroBono > 2, 1, 0)
            Next
            griDetallePlaVac.DataBind() : griDetallePlaVac.UpdateData()
            griCompraVac.DataBind() : griCompraVac.UpdateData()
            ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
            ndTotal.Update()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griPlanillaVacaciones.ActiveRow.Cells("Estado").Value = _estado AndAlso griPlanillaVacaciones.ActiveRow.Cells("Monto").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opePlaVac = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Planilla de Vacaciones" & Environment.NewLine & _
                                        "Nº: " & griPlanillaVacaciones.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Extornar()
        Try
            _acl = gAccionSistema.EXTORNAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griPlanillaVacaciones.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oePlanillaVacaciones = New e_PlanillaVacaciones
                        oePlanillaVacaciones.TipoOperacion = ""
                        oePlanillaVacaciones.Id = griPlanillaVacaciones.ActiveRow.Cells("Id").Value
                        oePlanillaVacaciones = olPlanillaVacaciones.Obtener(oePlanillaVacaciones)
                        oePlanillaVacaciones.TipoOperacion = "A"
                        _estado = gNombreEstadoGenerada
                        Dim _leEst = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                        If _leEst.Count > 0 Then
                            oePlanillaVacaciones.IdEstado = _leEst(0).Id
                            oePlanillaVacaciones.UsuarioModifica = gUsuarioSGI.Id
                            olPlanillaVacaciones.Guardar(oePlanillaVacaciones)
                            mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanillaVacaciones.Codigo & _
                                                          " se Extornado correctamente!", True)
                            MostrarTabs(0, ficPlanillaVacaciones)
                            Consultar(True)
                        End If
                    End If
                Else
                    Throw New Exception("No se puede EXTORNAR el Registro de Planilla de Vacaciones" & Environment.NewLine & _
                                        "Nº: " & griPlanillaVacaciones.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Terminar()
        Try
            _acl = gAccionSistema.TERMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griPlanillaVacaciones.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoTerminada.ToString
                    cboEstado.Text = _estado
                    _opePlaVac = "TERMINAR"
                Else
                    Throw New Exception("No puede TERMINAR el Registro de Planilla de Vacaciones" & Environment.NewLine & _
                                        "Nº: " & griPlanillaVacaciones.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcPlanillaVacaciones_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcPlanillaVacaciones.Opening
        mcPlanillaVacaciones.Items("tsmiNuevo").Enabled = True
        mcPlanillaVacaciones.Items("tsmiExportar").Enabled = IIf(griPlanillaVacaciones.Rows.Count > 0, True, False)
        If griPlanillaVacaciones.Selected.Rows.Count > 0 Then
            mcPlanillaVacaciones.Items("tsmiEditar").Enabled = True
            mcPlanillaVacaciones.Items("tsmiEliminar").Enabled = True
            mcPlanillaVacaciones.Items("tsmiEnviar").Enabled = True
            mcPlanillaVacaciones.Items("tsmiExtornar").Enabled = True
            mcPlanillaVacaciones.Items("tsmiTerminar").Enabled = True
        Else
            mcPlanillaVacaciones.Items("tsmiEditar").Enabled = False
            mcPlanillaVacaciones.Items("tsmiEliminar").Enabled = False
            mcPlanillaVacaciones.Items("tsmiEnviar").Enabled = False
            mcPlanillaVacaciones.Items("tsmiExtornar").Enabled = False
            mcPlanillaVacaciones.Items("tsmiTerminar").Enabled = False
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Try
            Nuevo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Try
            If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Try
            If griPlanillaVacaciones.Rows.Count > 0 Then Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExtornar_Click(sender As Object, e As EventArgs) Handles tsmiExtornar.Click
        Try
            If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Extornar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiTerminar_Click(sender As Object, e As EventArgs) Handles tsmiTerminar.Click
        Try
            If griPlanillaVacaciones.Selected.Rows.Count > 0 Then Terminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class