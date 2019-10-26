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
Imports MSScriptControl
Imports Microsoft.Office.Interop
Imports System.Text
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_Gratificacion
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Gratificacion = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Gratificacion()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeBonoComp As New e_Gratificacion, olBonoComp As New l_Gratificacion, leBonoComp As New List(Of e_Gratificacion)
    Private oeDetalle As New e_DetalleGratificacion, olDetalle As New l_DetalleGratificacion
    Private leDetalle As New List(Of e_DetalleGratificacion), leDetImportar As New List(Of e_DetalleGratificacion)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Private leTrabajador As New List(Of e_Trabajador), leTrabActivo As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeBonoProd As New e_BonificacionProduccion, olBonoProd As New l_BonificacionProduccion, leBonoProd As New List(Of e_BonificacionProduccion)
    Private oeFaltas As New e_ResumenAsistencia, olFaltas As New l_ResumenAsistencia, leFaltas As New List(Of e_ResumenAsistencia), leSubsidios As New List(Of e_ResumenAsistencia)
    Private oeHoraExtra As New e_DetallePagoAdicional, olHoraExtra As New l_DetallePagoAdicional, leHoraExtra As New List(Of e_DetallePagoAdicional)
    Private oeDsctoJud As New e_OtrosDescuentos, olDsctoJud As New l_OtrosDescuentos, leDsctoJud As New List(Of e_OtrosDescuentos)
    Private oeRegSalud As New e_RegimenSalud, olRegSalud As New l_RegimenSalud, leRegSalud As New List(Of e_RegimenSalud)
    Private oeCentro As New e_Centro, olCentro As New l_Centro, leCentro As List(Of e_Centro)
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area)
    Private oeOcupacion As New e_Ocupacion, olOcupacion As New l_Ocupacion, leOcupacion As New List(Of e_Ocupacion)
    Private oeCtaCte As New e_CuentaCtePersonal, olCtaCte As New l_CuentaCtePersonal, leCtaCte As New List(Of e_CuentaCtePersonal)
    Private oeDscto As New e_ReporteDescTrabajador, olDscto As New l_Prestamo, leDscto As New List(Of e_ReporteDescTrabajador)
    Private oeAsientoModel As e_AsientoModelo, olAsientoModel As l_AsientoModelo, leAsientoModel As List(Of e_AsientoModelo)
    Private oeReferencia As e_AsientoModelo_Referencia, olReferencia As l_AsientoModelo_Referencia, leReferencia As List(Of e_AsientoModelo_Referencia)
    Private _opeGrati As String = "", _acl As String = "", _estado As String = "", _bandload As Boolean = False
    Private _fecIni As Date = #1/1/1901#, _fecFin As Date = #1/1/1901#

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griGratificacion.Rows.Count > 0 Then
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
                _opeGrati = "GENERADA"
                oeBonoComp = New e_Gratificacion
                oeBonoComp.TipoOperacion = "I"
                oeBonoComp.Activo = True
                Inicializa()
                cboTipo.ReadOnly = False
                cboTipo.SelectedIndex = 0
                txtCodigo.Text = fn_ObtenerCodigo()
                Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio).ToList
                LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)
                nBono.Value = 6
                cboEstado.Text = "GENERADA"
                cboPeriodo.ReadOnly = False
                nBono.ReadOnly = False
                SeleccionaTab(1)
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
                _opeGrati = "GENERADA"
                Inicializa()
                Mostrar()
                oeBonoComp.TipoOperacion = "A"
                SeleccionaTab(1)
                cboTipo.ReadOnly = True
                cboPeriodo.ReadOnly = True
                nBono.ReadOnly = True
                btnCargar.Enabled = IIf(griDetalle.Rows.Count > 0, False, True)
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
            Select Case _opeGrati
                Case "GENERADA"
                    RecolectaDatos()
                    oeBonoComp.UsuarioCreacion = gUsuarioSGI.Id
                    oeBonoComp.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olBonoComp.Guardar(oeBonoComp) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case "ENVIAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeBonoComp.IdEstado = cboEstado.Value
                        oeBonoComp.UsuarioModifica = gUsuarioSGI.Id
                        oeBonoComp.PrefijoID = gs_PrefijoIdSucursal '@0001
                        If olBonoComp.Guardar(oeBonoComp) Then
                            mensajeEmergente.Confirmacion("¡El Registro de Gratificación Nº: " & oeBonoComp.Codigo & " se Envio correctamente!", True)
                            SeleccionaTab(0)
                            Consultar(True)
                        End If
                    End If
                Case "PROVISIONAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oePeriodo = New e_Periodo
                        oePeriodo = cboPeriodo.SelectedItem.ListObject
                        If fecProvision.Value.Month <> oePeriodo.Mes Then Throw New Exception("La Fecha no pertenece al periodo")
                        If decTipoCambio.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                        oeAsientoModel.FechaMov = fecProvision.Value
                        oeAsientoModel.TipoCambio = decTipoCambio.Value
                        oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id
                        oeBonoComp.IdEstado = cboEstado.Value
                        oeBonoComp.UsuarioModifica = gUsuarioSGI.Id
                        If olBonoComp.Provisionar(oeBonoComp, oeAsientoModel, oePeriodo) Then
                            mensajeEmergente.Confirmacion("¡El Registro de Gratificación Nº: " & oeBonoComp.Codigo & " se Termino correctamente!", True)
                            SeleccionaTab(0)
                            Consultar(True)
                        End If
                    End If
                Case "IMPORTAR"
                    Dim _leAux = leDetImportar.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        Dim formulario As frm_AutenticarTrabajador
                        formulario = New frm_AutenticarTrabajador
                        formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                            ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                            Throw New Exception("Ingrese un Clave Correcta")
                        Else
                            oeBonoComp = New e_Gratificacion
                            oeBonoComp.TipoOperacion = "I"
                            oeBonoComp.IdPeriodo = cboPeriodoDI.Value
                            oeBonoComp.Codigo = fn_ObtenerCodigo()
                            Dim _leEst = leEstado.Where(Function(it) it.Nombre = "PERDIDOS").ToList
                            If _leEst.Count > 0 Then
                                oeBonoComp.IdEstado = _leEst(0).Id
                            End If
                            oeBonoComp.Activo = True
                            oeBonoComp.Monto = leDetImportar.Sum(Function(it) it.NetoTotal)
                            oeBonoComp.leDetalle = _leAux
                            oeBonoComp.UsuarioCreacion = gUsuarioSGI.Id
                            oeBonoComp.PromBono = nPromBono.Value
                            oeBonoComp.IndTipo = cboTipoDI.SelectedIndex + 1
                            oeBonoComp.Glosa = "BONIFICACIÓN COMPESATORIA " & cboTipoDI.Text & " MES " & MonthName(oePeriodo.Mes) & " AÑO " & oePeriodo.Ejercicio
                            If olBonoComp.ImportarDatos(oeBonoComp) Then
                                mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
                                SeleccionaTab(0)
                                Consultar(True)
                            End If
                        End If
                    Else
                        Throw New Exception("No hay Registros Validados para Importar")
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficGratificacion.SelectedTab.Index
                Case 1
                    If MessageBox.Show("¿Desea Cancelar la Operacion?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case 2
                    If MessageBox.Show("¿Desea Cancelar la Importacion de Datos?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Eliminar()
        Try
            _acl = gAccionSistema.ELIMINAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griGratificacion.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeBonoComp = New e_Gratificacion
                        oeBonoComp.TipoOperacion = ""
                        oeBonoComp.Id = griGratificacion.ActiveRow.Cells("Id").Value
                        oeBonoComp = olBonoComp.Obtener(oeBonoComp)
                        oeBonoComp.UsuarioModifica = gUsuarioSGI.Id
                        olBonoComp.Eliminar(oeBonoComp)
                        mensajeEmergente.Confirmacion("¡El Registro de Gratificación Nº: " & oeBonoComp.Codigo & _
                                                             " se ha Eliminado correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("No puede en ELIMINAR el Registro de Gratificación Nº: " & _
                                        griGratificacion.ActiveRow.Cells("Codigo").Value & " por no esta GENERADA.")
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
            '_acl = gAccionSistema.EXPORTAR.ToString
            'If ValidarAcl(_acl, pIdActividadNegocio) Then
            Select Case ficGratificacion.SelectedTab.Index
                Case 0
                    If griGratificacion.Rows.Count > 0 Then
                        Exportar_Excel(griGratificacion, "Gratificacion")
                    Else
                        Throw New Exception("No hay Registros para Exportar")
                    End If
                Case 1
                    Select Case ficDetalle.SelectedTab.Index
                        Case 0
                            If griDetalle.Rows.Count > 0 Then
                                Exportar_Excel(griDetalle, "Detalle Gratificacion")
                            Else
                                Throw New Exception("No hay Registros para Exportar")
                            End If
                        Case 1
                            If griPendiente.Rows.Count > 0 Then
                                Exportar_Excel(griPendiente)
                            Else
                                Throw New Exception("No hay Registros para Exportar")
                            End If
                    End Select
                    
                Case 2
                    If griDatosImportar.Rows.Count > 0 Then
                        Exportar_Excel(griDatosImportar, "Datos Exportar Gratificacion")
                    Else
                        Throw New Exception("No hay Registros para Exportar")
                    End If
            End Select
            'Else
            'Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Gratificacion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficGratificacion.SelectedTab.Index
            Case 0
                If griGratificacion.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_Gratificacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Gratificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogicas()
            CargarCombos()
            leBonoComp = New List(Of e_Gratificacion)
            CargarGratificacion(leBonoComp)
            leDetalle = New List(Of e_DetalleGratificacion)
            _bandload = True
            CargarDetGrati(leDetalle)
            CargarDetPendiente(leDetalle)
            _bandload = False
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            SeleccionaTab(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            If leTrabajador.Count > 0 Then
                If cboTipo.SelectedIndex = 0 Then
                    If oePeriodo.Mes = 7 Then _fecIni = Date.Parse("01/01/" & oePeriodo.Ejercicio) : _fecFin = Date.Parse("30/06/" & oePeriodo.Ejercicio)
                    If oePeriodo.Mes = 12 Then _fecIni = Date.Parse("01/07/" & oePeriodo.Ejercicio) : _fecFin = Date.Parse("31/12/" & oePeriodo.Ejercicio)
                Else
                    If oePeriodo.Mes = 11 Then _fecIni = Date.Parse("01/05/" & oePeriodo.Ejercicio) : _fecFin = Date.Parse("31/10/" & oePeriodo.Ejercicio)
                    If oePeriodo.Mes = 5 Then _fecIni = Date.Parse("01/11/" & oePeriodo.Ejercicio - 1) : _fecFin = Date.Parse("30/04/" & oePeriodo.Ejercicio)
                End If
                leTrabActivo = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 And it.FechaIngreso <> #1/1/1901# _
                                                      And it.FechaIngreso <= _fecFin).OrderBy(Function(it) it.oePersona.NombreCompleto).ToList
                ' leTrabActivo = leTrabajador.Where(Function(it) it.oePersona.Dni = "42384731").ToList
                If leTrabActivo.Count > 0 Then
                    btnAgregar.Text = "Existen " & leTrabActivo.Count & " Registros"
                    btnAgregar.Enabled = True
                    btnCargar.Enabled = False
                Else
                    Throw New Exception("No se Encontraron Registros")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If MessageBox.Show("¿Desea Agregar los Registros?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim nroreg As Integer = 0
                Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _bonext = ObtieneValorParametro(gPPorcentajeEsSaludER)
                Dim _psseps = ObtieneValorParametro(gPPorcentajeEsSaludEPS)
                Dim _ini As Double = DateDiff(DateInterval.Day, #1/1/1900#, _fecIni)
                Dim _fin As Double = DateDiff(DateInterval.Day, #1/1/1900#, _fecFin)
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeTrab In leTrabActivo
                    nroreg = nroreg + 1
                    etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                    upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                    oeDetalle = New e_DetalleGratificacion
                    oeDetalle.Calcula = 1
                    oeDetalle.IndTipo = IIf(cboTipo.SelectedIndex = 0, 1, 2)
                    If cboTipo.SelectedIndex = 0 Then
                        If oeTrab.FechaIngreso.Month = 6 Or oeTrab.FechaIngreso.Month = 12 Then
                            If oeTrab.FechaIngreso.Year = _fecFin.Year Then oeDetalle.IndPendiente = 1
                        End If
                    Else
                        If oeTrab.FechaIngreso.Month = 10 Or oeTrab.FechaIngreso.Month = 4 Then
                            If oeTrab.FechaIngreso.Year = _fecFin.Year Then oeDetalle.IndPendiente = 1
                        End If
                    End If
                    oeDetalle.IdTrabajador = oeTrab.Id : oeDetalle.Trabajador = oeTrab.oePersona.NombreCompleto : oeDetalle.Dni = oeTrab.oePersona.Dni
                    oeDetalle.FechaIngreso = oeTrab.FechaIngreso : oeDetalle.TempInicio = _ini : oeDetalle.TempFin = _fin : oeDetalle.CantBono = nBono.Value
                    oeDetalle.PorExt = _bonext / 100 : oeDetalle.FecInicio = _fecIni : oeDetalle.FecFin = _fecFin : oeDetalle.Periodo = oePeriodo.Ejercicio
                    oeRegSalud = New e_RegimenSalud
                    oeRegSalud.IdTrabajador = oeTrab.Id : oeRegSalud.Equivale = 2
                    If leRegSalud.Contains(oeRegSalud) Then
                        oeRegSalud = leRegSalud.Item(leRegSalud.IndexOf(oeRegSalud))
                        If oeRegSalud.IdPlanEPS.Trim <> String.Empty Then oeDetalle.PorExt = (_bonext - _psseps) / 100
                    End If
                    If oeTrab.IndHijo = 1 Then oeDetalle.AsignacionFamiliar = _af
                    If oeTrab.oeArea.Nombre <> gNombreAreaOperaciones And oeTrab.oeArea.Nombre <> gNombreAreaMantenimiento Then oeDetalle.IndTipoAux = 1
                    oeDetalle.IdCentro = oeTrab.IdCentro
                    ' Cargar Centro
                    oeCentro = New e_Centro
                    oeCentro.Equivale = 1 : oeCentro.Id = oeTrab.IdCentro
                    If leCentro.Contains(oeCentro) Then
                        oeCentro = leCentro.Item(leCentro.IndexOf(oeCentro))
                        oeDetalle.Centro = oeCentro.Nombre
                    End If
                    oeDetalle.IdArea = oeTrab.oeArea.Id : oeDetalle.Area = oeTrab.oeArea.Nombre
                    oeDetalle.IdOcupacion = oeTrab.oeOcupacion.Id : oeDetalle.Ocupacion = oeTrab.oeOcupacion.Nombre
                    ' Cargar Cuenta Corriente GRATI / SUELDO
                    Dim _leCtaAux As List(Of e_CuentaCtePersonal)
                    If cboTipo.SelectedIndex = 0 Then
                        _leCtaAux = leCtaCte.Where(Function(it) it.IdTrabajador = oeTrab.Id And it.TipoConcepto = "SUELDO").ToList
                    Else
                        _leCtaAux = leCtaCte.Where(Function(it) it.IdTrabajador = oeTrab.Id And it.TipoConcepto = "CTS").ToList
                    End If
                    If _leCtaAux.Count > 0 Then oeDetalle.IdCuentaCorriente = _leCtaAux(0).Id : oeDetalle.CuentaCorriente = _leCtaAux(0).NroCuenta
                    ' Cargar Sueldo
                    oeSueldo = New e_SueldoTrabajador
                    oeSueldo.IdTrabajador = oeTrab.Id
                    oeSueldo.Equivale = 1
                    If leSueldo.Contains(oeSueldo) Then
                        oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                        oeDetalle.Sueldo = oeSueldo.Sueldo : oeDetalle.TipoOperacion = "I" : oeDetalle.Activo = True : oeDetalle.UsuarioCreacion = gUsuarioSGI.Id
                        leDetalle.Add(oeDetalle)
                    End If
                Next
                _bandload = True
                CargarDetGrati(leDetalle) : griDetalle.DataBind()
                CargarDetPendiente(leDetalle) : griPendiente.DataBind()
                _bandload = False
                btnAgregar.Enabled = False : btnCargarExtras.Enabled = True
                mensajeEmergente.Confirmacion("Se Agregaron " & leTrabActivo.Count & " registros", True)
                etiEjecuta.Visible = False : upbLoad.Visible = False
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub cboPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriodo.ValueChanged
        Try
            If cboPeriodo.SelectedIndex > -1 Then
                Dim _band As Boolean = False
                Dim oeGrati As New e_Gratificacion
                If oeBonoComp.TipoOperacion = "I" Then
                    oeGrati.TipoOperacion = ""
                    oeGrati.IdPeriodo = cboPeriodo.Value
                    oeGrati.Activo = True
                    oeGrati.IndTipo = cboTipo.SelectedIndex + 1
                    oeGrati = olBonoComp.Obtener(oeGrati)
                    If oeGrati IsNot Nothing AndAlso oeGrati.Id <> "" Then
                        If oeGrati.Activo Then _band = True
                    End If
                End If
                If Not _band Then
                    btnCargar.Enabled = True
                    oePeriodo = cboPeriodo.Items(cboPeriodo.SelectedIndex).ListObject
                    txtGlosa.Text = "BONIFICACIÓN COMPESATORIA " & cboTipo.Text & " MES " & MonthName(oePeriodo.Mes) & " AÑO " & oePeriodo.Ejercicio
                    'fecPago.Value = New Date(oePeriodo.Ejercicio, oePeriodo.Mes, 15)
                Else
                    btnCargar.Enabled = False
                    cboPeriodo.SelectedIndex = -1
                    txtGlosa.Text = String.Empty
                    Throw New Exception("No se puede Seleccionar el Periodo Nº " & cboPeriodo.Text & ", ya se encuentra Registrada en Nº: " & oeGrati.Codigo)
                End If
            Else
                btnCargar.Enabled = False
                oePeriodo = New e_Periodo
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargarExtras_Click(sender As Object, e As EventArgs) Handles btnCargarExtras.Click
        Try
            Dim _bandNext As Integer = 0
            If griDetalle.Rows.Count > 0 Then
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                Dim _idPla As String = ""
                Dim _ctn As Integer = 0, _min As Integer = 0, _max As Integer = 0
                Dim _lePlaAux As New List(Of e_Planilla)
                If oePeriodo.Id <> "" Then
                    If cboTipo.SelectedIndex = 0 Then
                        If oePeriodo.Mes = 7 Then _min = 0 : _max = 7
                        If oePeriodo.Mes = 12 Then _min = 5 : _max = 13
                        _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                    And it.NroMes > _min And it.NroMes < _max).OrderByDescending(Function(it) it.NroMes).ToList
                    Else
                        If oePeriodo.Mes = 11 Then
                            _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                             And it.NroMes > 4 And it.NroMes < 11).OrderByDescending(Function(it) it.NroMes).ToList
                        End If
                        If oePeriodo.Mes = 5 Then
                            _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio - 1 _
                                                             And it.NroMes > 10).OrderByDescending(Function(it) it.NroMes).ToList
                            _lePlaAux.AddRange(lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                                    And it.NroMes < 5).OrderByDescending(Function(it) it.NroMes).ToList)
                        End If
                    End If
                End If
                For Each oeAux In _lePlaAux
                    _idPla = _idPla & "'" & oeAux.Id & "',"
                Next
                If _idPla.Trim.Length > 0 Then
                    _idPla = _idPla.Substring(0, _idPla.Length - 1)
                    oeHoraExtra = New e_DetallePagoAdicional
                    oeHoraExtra.IdPagoAdicional = _idPla
                    oeHoraExtra.TipoOperacion = "R"
                    leHoraExtra = olHoraExtra.Listar(oeHoraExtra)
                    If leHoraExtra.Count > 0 Then
                        LlenarExtras(leHoraExtra, _idPla)
                        _bandNext = 1
                    Else
                        _bandNext = 2
                    End If
                Else
                    Throw New Exception("No hay Registros de Planillas anterior a la actual")
                End If
                If _bandNext > 1 Then
                    If MessageBox.Show("No hay Registros de Horas Extras" & Environment.NewLine & "¿Desea Continuar?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        btnCargarExtras.Enabled = False : btnCargarBono.Enabled = True
                    End If
                Else
                    btnCargarExtras.Enabled = False : btnCargarBono.Enabled = True
                End If
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub btnCargarBono_Click(sender As Object, e As EventArgs) Handles btnCargarBono.Click
        Try
            Dim _bandNext As Integer = 0
            If griDetalle.Rows.Count > 0 Then
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                Dim _idPla As String = ""
                Dim _ctn As Integer = 0, _min As Integer = 0, _max As Integer = 0
                Dim _lePlaAux As New List(Of e_Planilla)
                If oePeriodo.Id <> "" Then
                    If cboTipo.SelectedIndex = 0 Then
                        If oePeriodo.Mes = 7 Then _min = 0 : _max = 7
                        If oePeriodo.Mes = 12 Then _min = 5 : _max = 13
                        _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                    And it.NroMes > _min And it.NroMes < _max).OrderByDescending(Function(it) it.NroMes).ToList
                    Else
                        If oePeriodo.Mes = 11 Then
                            _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                             And it.NroMes > 4 And it.NroMes < 11).OrderByDescending(Function(it) it.NroMes).ToList
                        End If
                        If oePeriodo.Mes = 5 Then
                            _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio - 1 _
                                                             And it.NroMes > 10).OrderByDescending(Function(it) it.NroMes).ToList
                            _lePlaAux.AddRange(lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
                                                                    And it.NroMes < 5).OrderByDescending(Function(it) it.NroMes).ToList)
                        End If
                    End If
                End If
                For Each oeAux In _lePlaAux
                    _idPla = _idPla & "'" & oeAux.Id & "',"
                Next
                If _idPla.Trim.Length > 0 Then
                    _idPla = _idPla.Substring(0, _idPla.Length - 1)
                    oeBonoProd = New e_BonificacionProduccion
                    oeBonoProd.IdPlanilla = _idPla : oeBonoProd.TipoOperacion = "R"
                    leBonoProd = olBonoProd.Listar(oeBonoProd)
                    If leBonoProd.Count > 0 Then
                        LlenarProduccion(leBonoProd, _idPla)
                        _bandNext = 1
                    Else
                        _bandNext = 2
                    End If
                Else
                    Throw New Exception("No hay Registros de Planillas anterior a la actual")
                End If
                If _bandNext > 1 Then
                    If MessageBox.Show("No hay Registros de Horas Extras" & Environment.NewLine & "¿Desea Continuar?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        btnCargarBono.Enabled = False : btnFaltas.Enabled = True
                    End If
                Else
                    btnCargarBono.Enabled = False : btnFaltas.Enabled = True
                End If
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub chkDetalleExtra_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetalleExtra.CheckedChanged
        For i As Integer = 1 To 6
            OcultarColumna(griDetalle, Not chkDetalleExtra.Checked, "HoraExtra" & i)
            OcultarColumna(griPendiente, Not chkDetalleExtra.Checked, "HoraExtra" & i)
        Next
    End Sub

    Private Sub chkDetalleBono_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetalleBono.CheckedChanged
        For i As Integer = 1 To 6
            OcultarColumna(griDetalle, Not chkDetalleBono.Checked, "Bono" & i)
            OcultarColumna(griPendiente, Not chkDetalleBono.Checked, "Bono" & i)
        Next
    End Sub

    Private Sub btnFaltas_Click(sender As Object, e As EventArgs) Handles btnFaltas.Click
        'Try
        '    Dim _bandNext As Integer = 0
        '    If griDetalle.Rows.Count > 0 Then
        '        etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
        '        upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
        '        Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
        '        Dim _idPla As String = ""
        '        Dim _ctn As Integer = 0, _min As Integer = 0, _max As Integer = 0
        '        Dim _lePlaAux As New List(Of e_Planilla)
        '        If oePeriodo.Id <> "" Then
        '            If cboTipo.SelectedIndex = 0 Then
        '                If oePeriodo.Mes = 7 Then _min = 0 : _max = 7
        '                If oePeriodo.Mes = 12 Then _min = 6 : _max = 13
        '                _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
        '                                            And it.NroMes > _min And it.NroMes < _max).OrderByDescending(Function(it) it.NroMes).ToList
        '            Else
        '                If oePeriodo.Mes = 11 Then
        '                    _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
        '                                                     And it.NroMes > 4 And it.NroMes < 11).OrderByDescending(Function(it) it.NroMes).ToList
        '                End If
        '                If oePeriodo.Mes = 5 Then
        '                    _lePlaAux = lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = (oePeriodo.Ejercicio - 1) _
        '                                                     And it.NroMes > 10).OrderByDescending(Function(it) it.NroMes).ToList
        '                    _lePlaAux.AddRange(lePlanilla.Where(Function(it) it.Activo = True And it.Tipo = 0 And it.Ejercicio = oePeriodo.Ejercicio _
        '                                                            And it.NroMes < 5).OrderByDescending(Function(it) it.NroMes).ToList)
        '                End If
        '            End If
        '        End If
        '        For Each oeAux In _lePlaAux
        '            _idPla = _idPla & "'" & oeAux.Id & "',"
        '        Next
        '        If _idPla.Trim.Length > 0 Then
        '            _idPla = _idPla.Substring(0, _idPla.Length - 1)
        '            ' Cargar Dias Faltas
        '            oeFaltas = New e_ResumenAsistencia
        '            oeFaltas.IdPlanilla = _idPla : oeFaltas.IndTipo = 0 : oeFaltas.TipoOperacion = "R"
        '            leFaltas = olFaltas.Listar(oeFaltas)
        '            Dim _leFaltaAux = leFaltas.Where(Function(it) it.IndTipoAux = 1).ToList
        '            If _leFaltaAux.Count > 0 Then
        '                LlenarFaltas(_leFaltaAux, _idPla)
        '                _bandNext = 1
        '            Else
        '                _bandNext = 2
        '            End If
        '        Else
        '            Throw New Exception("No hay Registros de Planillas anterior a la actual")
        '        End If
        '        If _bandNext > 1 Then
        '            If MessageBox.Show("No hay Registros de Faltas" & Environment.NewLine & "¿Desea Continuar?", "Mensaje de Sistema", _
        '                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '                btnFaltas.Enabled = False
        '                btnCargarDscto.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
        '                btnGrati.Enabled = IIf(cboTipo.SelectedIndex = 0, False, True)
        '                btnBonoAnterior.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
        '            End If
        '        Else
        '            btnFaltas.Enabled = False
        '            btnCargarDscto.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
        '            btnGrati.Enabled = IIf(cboTipo.SelectedIndex = 0, False, True)
        '            btnBonoAnterior.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
        '        End If
        '    End If
        'Catch ex As Exception
        '  etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        'Finally
        '    Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        'End Try

        Try
            Dim _bandNext As Integer = 0
            If griDetalle.Rows.Count > 0 Then
                Dim _idPla As String = ""
                Dim objetoAux As e_ResumenAsistencia
                Dim listaAux As New List(Of e_ResumenAsistencia)
                Dim PathFilePTRA As String = ""
                OpenFileDialog1 = CargaDatosOpenFileDialog()
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                    Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                    PathFilePTRA = OpenFileDialog1.FileName
                    Dim objXls As Excel.Application
                    Dim objWorkbook As Excel.Workbook
                    Dim objWorkSheet As Excel.Worksheet
                    Dim ObjExcel() As Object = Nothing
                    objXls = CreateObject("Excel.Application")
                    objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                    objXls.Visible = False
                    objWorkSheet = objXls.Worksheets(1)
                    'leBPImportar.Clear()
                    For ln_Fila As Integer = 1 To 100000
                        If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                            etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                            upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                            etiEjecuta2.Text = "Procesando " & ln_Fila & " registros ... "
                            objetoAux = New e_ResumenAsistencia
                            objetoAux.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            objetoAux.Cantidad = objWorkSheet.Cells(ln_Fila + 1, 3).Value
                            listaAux.Add(objetoAux)
                        Else
                            Exit For
                        End If
                    Next

                    If Not objXls Is Nothing Then
                        objWorkbook.Saved = True : objWorkbook.Close()
                        objXls.Quit()
                    End If
                    OpenFileDialog1.Dispose()
                    ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                    Dim proceso() As Process
                    proceso = Process.GetProcessesByName("EXCEL")
                    If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
                Else
                    OpenFileDialog1.Dispose()
                End If

                ''''validar que todos los dni coincidan con la data sino alertar
                Dim dniExiste As Boolean = False
                For Each i In listaAux
                    dniExiste = False
                    For Each j In leDetalle
                        If i.Dni = j.Dni Then
                            dniExiste = True
                            Exit For
                        End If
                        If Not IsNumeric(i.Cantidad) Then Throw New Exception("El DNI: " & i.Dni & " tiene cantidad incorrecto.")
                    Next
                    If Not dniExiste Then Throw New Exception("El DNI: " & i.Dni & " no se encuentra en la lista.")
                Next

                ' ''''agregar reintegro a la data            
                'For Each i In listaAux
                '    For Each j In leDetalle
                '        If i.Dni = j.Dni Then
                '            j.DiasFaltas = i.Cantidad
                '        End If
                '    Next
                'Next

                If listaAux.Count > 0 Then
                    LlenarFaltas(listaAux, _idPla)
                    _bandNext = 1
                Else
                    _bandNext = 2
                End If
                If _bandNext > 1 Then
                    If MessageBox.Show("No hay Registros de Faltas" & Environment.NewLine & "¿Desea Continuar?", "Mensaje de Sistema", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        btnFaltas.Enabled = False
                        btnCargarDscto.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
                        btnGrati.Enabled = IIf(cboTipo.SelectedIndex = 0, False, True)
                        btnBonoAnterior.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
                    End If
                Else
                    btnFaltas.Enabled = False
                    btnCargarDscto.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
                    btnGrati.Enabled = IIf(cboTipo.SelectedIndex = 0, False, True)
                    btnBonoAnterior.Enabled = IIf(cboTipo.SelectedIndex = 0, True, False)
                End If
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub btnCargarDscto_Click(sender As Object, e As EventArgs) Handles btnCargarDscto.Click
        Try
            Dim nroreg As Integer = 0
            If griDetalle.Rows.Count > 0 Then
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                'oeDsctoJud = New e_OtrosDescuentos
                'oeDsctoJud.TipoOperacion = "I" : oeDsctoJud.Activo = True : oeDsctoJud.IndTipo = 1 : oeDsctoJud.IndReferencia = cboTipo.SelectedIndex + 1
                'leDsctoJud = olDsctoJud.Listar(oeDsctoJud)
                'If leDsctoJud.Count > 0 Then
                '    For Each fil In griDetalle.Rows
                '        nroreg = nroreg + 1
                '        etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                '        upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                '        Dim _leAux = leDsctoJud.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                '        If _leAux.Count > 0 Then fil.Cells("DescuentoJudicial").Value = _leAux(0).Monto
                '    Next
                '    For Each fil2 In griPendiente.Rows
                '        nroreg = nroreg + 1
                '        etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                '        upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                '        Dim _leAux2 = leDsctoJud.Where(Function(it) it.IdTrabajador = fil2.Cells("IdTrabajador").Value).ToList
                '        If _leAux2.Count > 0 Then fil2.Cells("DescuentoJudicial").Value = _leAux2(0).Monto
                '    Next
                'End If
                If oePeriodo.Mes = 7 Or oePeriodo.Mes = 12 Then
                    oeDscto = New e_ReporteDescTrabajador
                    oeDscto.TipoOperacion = "1" : oeDscto.Indicador = "1"
                    oeDscto.Anio = oePeriodo.Ejercicio : oeDscto.Mes = FormatoDocumento(oePeriodo.Mes, 2)
                    leDscto = olDscto.ListarRDT(oeDscto)
                    If leDscto.Count > 0 Then
                        For Each fil In griDetalle.Rows
                            nroreg = nroreg + 1
                            etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                            upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                            Dim _leAux = leDscto.Where(Function(it) it.oeTrabajador.Id = fil.Cells("IdTrabajador").Value).ToList
                            If _leAux.Count > 0 Then fil.Cells("AdelantoSueldo").Value = _leAux(0).Total
                        Next
                        For Each fil2 In griPendiente.Rows
                            nroreg = nroreg + 1
                            etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                            upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                            Dim _leAux2 = leDscto.Where(Function(it) it.oeTrabajador.Id = fil2.Cells("IdTrabajador").Value).ToList
                            If _leAux2.Count > 0 Then fil2.Cells("AdelantoSueldo").Value = _leAux2(0).Total
                        Next
                    End If
                End If
                btnCargarDscto.Enabled = False
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                leDetImportar.Clear()
                If oePeriodo.Mes = 7 Then _fecIni = Date.Parse("01/01/" & oePeriodo.Ejercicio) : _fecFin = Date.Parse("30/06/" & oePeriodo.Ejercicio)
                If oePeriodo.Mes = 12 Then _fecIni = Date.Parse("01/07/" & oePeriodo.Ejercicio) : _fecFin = Date.Parse("31/12/" & oePeriodo.Ejercicio)
                Dim _bonext = ObtieneValorParametro("PORC_ESR")
                Dim _ini As Double = DateDiff(DateInterval.Day, #1/1/1900#, _fecIni) + 2
                Dim _fin As Double = DateDiff(DateInterval.Day, #1/1/1900#, _fecFin) + 2
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeDetalle = New e_DetalleGratificacion
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        oeCentro = New e_Centro
                        oeCentro.Equivale = 2 : oeCentro.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                        If leCentro.Contains(oeCentro) Then oeCentro = leCentro.Item(leCentro.IndexOf(oeCentro))
                        oeArea = New e_Area
                        oeArea.Equivale = 2 : oeArea.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value)
                        If leArea.Contains(oeArea) Then oeArea = leArea.Item(leArea.IndexOf(oeArea))
                        oeOcupacion = New e_Ocupacion
                        oeOcupacion.Equivale = 2 : oeOcupacion.Nombre = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value)
                        If leOcupacion.Contains(oeOcupacion) Then oeOcupacion = leOcupacion.Item(leOcupacion.IndexOf(oeOcupacion))
                        oeCtaCte = New e_CuentaCtePersonal
                        oeCtaCte.Equivale = 2 : oeCtaCte.NroCuenta = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value)
                        If leCtaCte.Contains(oeCtaCte) Then oeCtaCte = leCtaCte.Item(leCtaCte.IndexOf(oeCtaCte))
                        With oeDetalle
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .TempInicio = _ini
                            .TempFin = _fin
                            .CantBono = nPromBono.Value
                            .PorExt = _bonext / 100
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IdCentro = oeCentro.Id
                            .Centro = IIf(oeCentro.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeCentro.Nombre)
                            .IdArea = oeArea.Id
                            .Area = IIf(oeArea.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value), oeArea.Nombre)
                            .IdOcupacion = oeOcupacion.Id
                            .Ocupacion = IIf(oeOcupacion.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value), oeOcupacion.Nombre)
                            .IdCuentaCorriente = oeCtaCte.Id
                            .CuentaCorriente = IIf(oeCtaCte.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value), oeCtaCte.NroCuenta)
                            .FechaIngreso = objWorkSheet.Cells(ln_Fila + 1, 7).Value
                            .TempIngreso = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 8).Value, 2)
                            .Sueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 9).Value, 2)
                            .AsignacionFamiliar = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 10).Value, 2)
                            .Renumeracion = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 11).Value, 2)
                            .HoraExtra1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 12).Value, 2)
                            .HoraExtra2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 13).Value, 2)
                            .HoraExtra3 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 14).Value, 2)
                            .HoraExtra4 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 15).Value, 2)
                            .HoraExtra5 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 16).Value, 2)
                            .HoraExtra6 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 17).Value, 2)
                            .IndPromExtra = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 18).Value) = "SI", 1, 0)
                            .PromedioHoraExtra = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 19).Value, 2)
                            .Bono1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 20).Value, 2)
                            .Bono2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 21).Value, 2)
                            .Bono3 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 22).Value, 2)
                            .Bono4 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 23).Value, 2)
                            .Bono5 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 24).Value, 2)
                            .Bono6 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 25).Value, 2)
                            .IndPromedio = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 26).Value) = "SI", 1, 0)
                            .PromedioBono = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 27).Value, 2)
                            .Gratificacion = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 28).Value, 2)
                            .FraccionGrati = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 29).Value, 2)
                            .RenumeracionComputable = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 30).Value, 2)
                            .TiempoLaborado = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 31).Value, 2)
                            .DiasFaltas = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 32).Value, 2)
                            .MesesFalta = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 33).Value, 2)
                            .PeriodoComputable = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 34).Value, 2)
                            .Importe = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 35).Value, 2)
                            .BonoExtra = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 36).Value, 2)
                            .Total = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 37).Value, 2)
                            .DescuentosJudiciales = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 38).Value, 2)
                            .AdelantoSueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 39).Value, 2)
                            .TotalDescuento = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 40).Value, 2)
                            .NetoTotal = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 41).Value, 2)
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        leDetImportar.Add(oeDetalle)
                    Else
                        Exit For
                    End If
                Next
                CargarDetImportar(leDetImportar)
                griDatosImportar.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close()
                    objXls.Quit()
                End If
                OpenFileDialog1.Dispose()
                ObjExcel = Nothing : objWorkSheet = Nothing : objWorkbook = Nothing : objXls = Nothing
                Dim proceso() As Process
                proceso = Process.GetProcessesByName("EXCEL")
                If proceso.Length > 0 Then proceso(proceso.Length - 1).Kill()
            Else
                OpenFileDialog1.Dispose()
            End If
            mensajeEmergente.Confirmacion("Se han Procesado " & leDetImportar.Count & " registros", True)
        Catch ex As Exception
            etiEjecuta.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0, nrocentro As Integer = 0, nroarea As Integer = 0, nroocup As Integer = 0, nrocta As Integer = 0
            Dim ls_msg As String = String.Empty
            If leDetImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeAux In leDetImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetImportar.Count
                    upbLoad.Value = Math.Round(nroreg / leDetImportar.Count, 2) * 100
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeAux.Activo = False
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id : oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                    If oeAux.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                    ' Verifica si los Centros entan registradas en el SGI
                    If oeAux.IdCentro.Trim = "" Then
                        oeAux.Activo = False
                        oeCentro = New e_Centro
                        oeCentro.Equivale = 2 : oeCentro.Nombre = oeAux.Centro
                        If leCentro.Contains(oeCentro) Then
                            Dim _leCent = leCentro.Where(Function(it) it.Nombre = oeCentro.Nombre).ToList
                            If _leCent.Count > 0 Then
                                oeCentro = _leCent(0)
                                oeAux.IdCentro = oeCentro.Id : oeAux.Activo = True
                            End If
                        End If
                    End If
                    If oeAux.IdCentro.Trim = String.Empty Then nrocentro = nrocentro + 1
                    ' Verifica si las Areas entan registradas en el SGI
                    If oeAux.IdArea.Trim = "" Then
                        oeAux.Activo = False
                        oeArea = New e_Area
                        oeArea.Equivale = 2 : oeArea.Nombre = oeAux.Area
                        If leArea.Contains(oeArea) Then
                            Dim _leAre = leArea.Where(Function(it) it.Nombre = oeArea.Nombre).ToList
                            If _leAre.Count > 0 Then
                                oeArea = _leAre(0)
                                oeAux.IdArea = oeArea.Id : oeAux.Activo = True
                            End If
                        End If
                    End If
                    If oeAux.IdArea.Trim = String.Empty Then nroarea = nroarea + 1
                    ' Verifica si las Ocupaciones entan registradas en el SGI
                    If oeAux.IdOcupacion.Trim = "" Then
                        oeAux.Activo = False
                        oeOcupacion = New e_Ocupacion
                        oeOcupacion.Equivale = 2 : oeOcupacion.Nombre = oeAux.Ocupacion
                        If leOcupacion.Contains(oeOcupacion) Then
                            Dim _leOcu = leOcupacion.Where(Function(it) it.Nombre = oeOcupacion.Nombre).ToList
                            If _leOcu.Count > 0 Then
                                oeOcupacion = _leOcu(0)
                                oeAux.IdOcupacion = oeOcupacion.Id : oeAux.Activo = True
                            End If
                        End If
                    End If
                    If oeAux.IdOcupacion.Trim = String.Empty Then nroocup = nroocup + 1
                    ' Verifica si las Cuenta Corriente entan registradas en el SGI
                    If oeAux.IdCuentaCorriente.Trim = "" Then
                        oeAux.Activo = False
                        oeCtaCte = New e_CuentaCtePersonal
                        oeCtaCte.Equivale = 2 : oeCtaCte.NroCuenta = oeAux.CuentaCorriente
                        If leCtaCte.Contains(oeCtaCte) Then
                            Dim _leCta = leCtaCte.Where(Function(it) it.NroCuenta = oeCtaCte.NroCuenta).ToList
                            If _leCta.Count > 0 Then
                                oeCtaCte = _leCta(0)
                                oeAux.IdCuentaCorriente = oeCtaCte.Id : oeAux.Activo = True
                            End If
                        End If
                    End If
                    If oeAux.IdCuentaCorriente.Trim = String.Empty Then nrocta = nrocta + 1
                Next
                CargarDetImportar(leDetImportar)
                griDatosImportar.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados." & Environment.NewLine
            If nrocentro > 0 Then ls_msg = ls_msg & " * " & nrocentro & " Trabajadores con centros no registrados." & Environment.NewLine
            If nroarea > 0 Then ls_msg = ls_msg & " * " & nroarea & " Trabajadores con áreas no registrados." & Environment.NewLine
            If nroocup > 0 Then ls_msg = ls_msg & " * " & nroocup & " Trabajadores con ocupaciones no registrados." & Environment.NewLine
            If nrocta > 0 Then ls_msg = ls_msg & " * " & nrocta & " Trabajadores con cuentas bancarias no registrados."
            If ls_msg.Trim.Length > 0 Then
                btnDatosExcluidos.Enabled = True
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leDetImportar.Count & " Registros" & Environment.NewLine & ls_msg, True)
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub btnDatosExcluidos_Click(sender As Object, e As EventArgs) Handles btnDatosExcluidos.Click
        Try
            Dim nroreg As Integer = 0
            etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
            upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            For Each fil In griDatosImportar.Rows
                nroreg = nroreg + 1
                etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetImportar.Count
                upbLoad.Value = Math.Round(nroreg / leDetImportar.Count, 2) * 100
                If fil.Cells("IdTrabajador").Value = String.Empty Then fil.Cells("Trabajador").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdCentro").Value = String.Empty Then fil.Cells("Centro").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdArea").Value = String.Empty Then fil.Cells("Area").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdOcupacion").Value = String.Empty Then fil.Cells("Ocupacion").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdCuentaCorriente").Value = String.Empty Then fil.Cells("CuentaCorriente").Appearance.BackColor = Color.LightCoral
            Next
            etiEjecuta.Visible = False : upbLoad.Visible = False
        Catch ex As Exception
            etiEjecuta.Visible = False : upbLoad.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            etiEjecuta.Visible = False : upbLoad.Visible = False
        End Try
    End Sub

    Private Sub cboPeriodoDI_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriodoDI.ValueChanged
        Try
            If cboPeriodoDI.SelectedIndex > -1 Then
                Dim _band As Boolean = False
                Dim oeGrati As New e_Gratificacion
                oeGrati.TipoOperacion = ""
                oeGrati.IdPeriodo = cboPeriodoDI.Value
                oeGrati.Activo = True
                oeGrati.IndTipo = cboTipoDI.SelectedIndex + 1
                oeGrati = olBonoComp.Obtener(oeGrati)
                If oeGrati IsNot Nothing AndAlso oeGrati.Id <> "" Then
                    If oeGrati.Activo Then _band = True
                End If
                If Not _band Then
                    btnBuscar.Enabled = True : nPromBono.ReadOnly = False
                    oePeriodo = cboPeriodoDI.Items(cboPeriodoDI.SelectedIndex).ListObject
                Else
                    btnBuscar.Enabled = False : nPromBono.ReadOnly = True : cboPeriodo.SelectedIndex = -1
                    Throw New Exception("No se puede Seleccionar el Periodo Nº " & cboPeriodoDI.Text & ", ya se encuentra Registrada en Nº: " & oeGrati.Codigo)
                End If
            Else
                oePeriodo = New e_Periodo
                btnBuscar.Enabled = False : nPromBono.ReadOnly = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griGratificacion_DoubleClick(sender As Object, e As EventArgs) Handles griGratificacion.DoubleClick
        If griGratificacion.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub cboTipo_ValueChanged(sender As Object, e As EventArgs) Handles cboTipo.ValueChanged
        Try
            Select Case cboTipo.SelectedIndex
                Case 0
                    If oeBonoComp.TipoOperacion = "I" Then txtCodigo.Text = fn_ObtenerCodigo()
                    Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio).ToList
                    If oeBonoComp.TipoOperacion = "I" Then LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)
                Case 1
                    If oeBonoComp.TipoOperacion = "I" Then txtCodigo.Text = fn_ObtenerCodigo()
                    Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 5 Or it.Mes = 11).OrderByDescending(Function(it) it.Ejercicio).ToList
                    If oeBonoComp.TipoOperacion = "I" Then LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboTipoDI_ValueChanged(sender As Object, e As EventArgs) Handles cboTipoDI.ValueChanged
        Try
            Select Case cboTipoDI.SelectedIndex
                Case 0
                    Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio).ToList
                    LlenarCombo(cboPeriodoDI, "Codigo", _lePerAux, -1)
                Case 1
                    Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 5 Or it.Mes = 11).OrderByDescending(Function(it) it.Ejercicio).ToList
                    LlenarCombo(cboPeriodoDI, "Codigo", _lePerAux, -1)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnGrati_Click(sender As Object, e As EventArgs) Handles btnGrati.Click
        Try
            If griDetalle.Rows.Count > 0 AndAlso cboTipo.SelectedIndex = 1 Then
                Dim _bandg As Boolean = True
                Dim _oePerAux As New e_Periodo
                Dim _nroMes As Integer = 0, _ejercicio As Integer = 0
                Dim _fecIng As Date = #1/1/1901#
                Dim oeGAux = New e_Gratificacion

                If oePeriodo.Mes = 11 Then _nroMes = 7 : _ejercicio = oePeriodo.Ejercicio
                If oePeriodo.Mes = 5 Then _nroMes = 12 : _ejercicio = oePeriodo.Ejercicio - 1
                Dim _lePAux = lePeriodo.Where(Function(it) it.Ejercicio = _ejercicio And it.Mes = _nroMes)
                If _lePAux.Count > 0 Then
                    _oePerAux = _lePAux(0)
                    oeGAux.TipoOperacion = "" : oeGAux.Activo = True : oeGAux.IndTipo = 1 : oeGAux.IdPeriodo = _oePerAux.Id
                    oeGAux = olBonoComp.Obtener(oeGAux)
                    If oeGAux IsNot Nothing AndAlso oeGAux.Id.Trim <> "" AndAlso oeGAux.leDetalle.Count > 0 Then
                        ' Cargar Detalle
                        For Each fil In griDetalle.Rows
                            _bandg = True
                            _fecIng = fil.Cells("FechaIngreso").Value
                            If oePeriodo.Mes = 11 Then
                                If Year(_fecIng) = _ejercicio AndAlso Month(_fecIng) >= _nroMes Then _bandg = False
                            End If
                            If oePeriodo.Mes = 5 Then
                                If Year(_fecIng) = (_ejercicio + 1) AndAlso (Month(_fecIng) >= 1 And Month(_fecIng) <= 5) Then _bandg = False
                            End If
                            If _bandg Then
                                Dim _leAux = oeGAux.leDetalle.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value)
                                If _leAux.Count > 0 Then fil.Cells("Gratificacion").Value = _leAux(0).Importe
                            End If
                        Next
                        griDetalle.DataBind() : griDetalle.UpdateData()
                        ' Cargar pendientes
                        For Each fil In griPendiente.Rows
                            _bandg = True
                            _fecIng = fil.Cells("FechaIngreso").Value
                            If oePeriodo.Mes = 11 Then
                                If Year(_fecIng) = _ejercicio AndAlso Month(_fecIng) >= _nroMes Then _bandg = False
                            End If
                            If oePeriodo.Mes = 5 Then
                                If Year(_fecIng) = (_ejercicio + 1) AndAlso (Month(_fecIng) >= 1 And Month(_fecIng) <= 5) Then _bandg = False
                            End If
                            If _bandg Then
                                Dim _leAux = oeGAux.leDetalle.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value)
                                If _leAux.Count > 0 Then fil.Cells("Gratificacion").Value = _leAux(0).Importe
                            End If
                        Next
                        griPendiente.DataBind() : griPendiente.UpdateData()
                    End If
                End If
                btnGrati.Enabled = False
                btnBonoAnterior.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkDatosTrab_CheckedChanged(sender As Object, e As EventArgs) Handles chkDatosTrab.CheckedChanged
        OcultarColumna(griDetalle, Not chkDatosTrab.Checked, "Centro", "Area", "Ocupacion", "CuentaCorriente")
        OcultarColumna(griPendiente, Not chkDatosTrab.Checked, "Centro", "Area", "Ocupacion", "CuentaCorriente")
    End Sub

    Private Sub griDetalle_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griDetalle.DoubleClickCell
        Try
            With griDetalle
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "IndPendiente"
                                If .ActiveRow.Cells("IndPendiente").Value = 0 Then
                                    Dim _FecAux As Date = .ActiveRow.Cells("FechaIngreso").Value
                                    If cboTipo.SelectedIndex = 0 Then
                                        If _FecAux.Month <> 6 And _FecAux.Month <> 12 Then
                                            Throw New Exception("La " & cboTipo.Text & " de: " & .ActiveRow.Cells("Trabajador").Value & " no se puede pasar en pendiente")
                                        End If
                                    Else
                                        If _FecAux.Month <> 10 And _FecAux.Month <> 4 Then
                                            Throw New Exception("La " & cboTipo.Text & " de: " & .ActiveRow.Cells("Trabajador").Value & " no se puede pasar en pendiente")
                                        End If
                                    End If
                                    If MessageBox.Show("¿Desea pasar a Pendiente la " & cboTipo.Text & " de: " & .ActiveRow.Cells("Trabajador").Value & "?", _
                                                       "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        oeDetalle = New e_DetalleGratificacion
                                        oeDetalle.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                        oeDetalle.Equivale = 1
                                        If leDetalle.Contains(oeDetalle) Then
                                            oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                                            oeDetalle.IndPendiente = 1
                                            oeDetalle.TipoOperacion = IIf(oeDetalle.Id.Trim <> String.Empty, "A", "I")
                                        End If
                                        CargarDetGrati(leDetalle) : CargarDetPendiente(leDetalle)
                                    End If
                                End If
                            Case "IndPromExtra"
                                If .ActiveRow.Cells("IndPromExtra").Value = False Then
                                    If MessageBox.Show("¿Desea Agregar el Promedio de Extras al Trabajador: " & _
                                                  .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromExtra").Value = 1
                                    End If
                                Else
                                    If MessageBox.Show("¿Desea quitar el Promedio de Extras al Trabajador: " & _
                                                .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromExtra").Value = 0
                                    End If
                                End If
                                .UpdateData()
                            Case "IndPromedio"
                                If .ActiveRow.Cells("IndPromedio").Value = False Then
                                    If MessageBox.Show("¿Desea Agregar el Promedio de Bonos al Trabajador: " & _
                                                  .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromedio").Value = 1
                                    End If
                                Else
                                    If MessageBox.Show("¿Desea quitar el Promedio de Bonos al Trabajador: " & _
                                                .ActiveRow.Cells("Trabajador").Value & "?", "Mensaje de Sistema", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        .ActiveRow.Cells("IndPromedio").Value = 0
                                    End If
                                End If
                                .UpdateData()
                            Case "Bono1", "Bono2", "Bono3", "Bono4", "Bono5", "Bono6"
                                If .ActiveRow.Cells("Dni").Value = "16677101" Or .ActiveRow.Cells("IndPromedio").Value = 1 Then
                                    Dim _keyaux = .ActiveCell.Column.Key
                                    Dim _bono As String
                                    _bono = InputBox("Ingrese de Falta:", "Mensaje de Sistema", .ActiveRow.Cells(_keyaux).Value)
                                    If Not IsNumeric(_bono) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _bono < 0 Then Throw New Exception("Debe Ingresar un Dias mayor a Cero")
                                    .ActiveRow.Cells(_keyaux).Value = _bono
                                    .UpdateData()
                                End If
                            Case "HoraExtra1", "HoraExtra2", "HoraExtra3", "HoraExtra4", "HoraExtra5", "HoraExtra6"
                                If .ActiveRow.Cells("IndPromExtra").Value = 1 Then
                                    Dim _keyaux = .ActiveCell.Column.Key
                                    Dim _phe As String
                                    _phe = InputBox("Ingrese de Monto:", "Mensaje de Sistema", .ActiveRow.Cells(_keyaux).Value)
                                    If Not IsNumeric(_phe) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _phe < 0 Then Throw New Exception("Debe Ingresar un Dias mayor a Cero")
                                    .ActiveRow.Cells(_keyaux).Value = _phe
                                    .UpdateData()
                                End If
                            Case "DiasFaltas"
                                Dim _diasfalta As String
                                _diasfalta = InputBox("Ingrese de Falta:", "Mensaje de Sistema", .ActiveRow.Cells("DiasFaltas").Value)
                                If Not IsNumeric(_diasfalta) Then Throw New Exception("Solo se Permite Ingresar Números")
                                If _diasfalta < 0 Then Throw New Exception("Debe Ingresar un Dias mayor a Cero")
                                .ActiveRow.Cells("DiasFaltas").Value = _diasfalta
                                .UpdateData()
                                'ndTotal.Value = leDetallePlaVac.Sum(Function(it) it.TotalPagar)
                            Case "DescuentosJudiciales"
                                Dim _dsctojud As String
                                _dsctojud = InputBox("Ingrese Descuento Judicial:", "Mensaje de Sistema", .ActiveRow.Cells("DescuentosJudiciales").Value)
                                If Not IsNumeric(_dsctojud) Then Throw New Exception("Solo se Permite Ingresar Números")
                                If _dsctojud < 0 Then Throw New Exception("Debe Ingresar Monto mayor a Cero")
                                .ActiveRow.Cells("DescuentosJudiciales").Value = _dsctojud
                                .UpdateData()
                            Case "DatoApoyo"
                                Dim _datohelp As String
                                _datohelp = InputBox("Ingrese Importe Pendiente:", "Mensaje de Sistema", .ActiveRow.Cells("DatoApoyo").Value)
                                If Not IsNumeric(_datohelp) Then Throw New Exception("Solo se Permite Ingresar Números")
                                If _datohelp < 0 Then Throw New Exception("Debe Ingresar Monto mayor a Cero")
                                .ActiveRow.Cells("DatoApoyo").Value = _datohelp
                                .UpdateData()
                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPendiente_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles griPendiente.DoubleClickCell
        Try
            With griPendiente
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        Select Case .ActiveCell.Column.Key
                            Case "IndPendiente"
                                If .ActiveRow.Cells("IndPendiente").Value = 1 Then
                                    If MessageBox.Show("¿Desea proceder la " & cboTipo.Text & " de: " & .ActiveRow.Cells("Trabajador").Value & "?", _
                                                       "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        oeDetalle = New e_DetalleGratificacion
                                        oeDetalle.IdTrabajador = .ActiveRow.Cells("IdTrabajador").Value
                                        oeDetalle.Equivale = 1
                                        If leDetalle.Contains(oeDetalle) Then
                                            oeDetalle = leDetalle.Item(leDetalle.IndexOf(oeDetalle))
                                            oeDetalle.IndPendiente = 0
                                            oeDetalle.TipoOperacion = IIf(oeDetalle.Id.Trim <> String.Empty, "A", "I")
                                        End If
                                        CargarDetGrati(leDetalle) : CargarDetPendiente(leDetalle)
                                    End If
                                End If
                            Case "IndPromedio"

                            Case "IndPromExtra"

                        End Select
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBonoAnterior_Click(sender As Object, e As EventArgs) Handles btnBonoAnterior.Click
        Try
            If griDetalle.Rows.Count > 0 Then
                Dim _nroMes As Integer = 0, _ejercicio As Integer = 0
                Dim _oePerAux As New e_Periodo
                Dim _oeCts As New e_Gratificacion
                If oePeriodo.Mes = 11 Then _nroMes = 5 : _ejercicio = oePeriodo.Ejercicio
                If oePeriodo.Mes = 5 Then _nroMes = 11 : _ejercicio = oePeriodo.Ejercicio - 1
                If oePeriodo.Mes = 12 Then _nroMes = 7 : _ejercicio = oePeriodo.Ejercicio
                If oePeriodo.Mes = 7 Then _nroMes = 12 : _ejercicio = oePeriodo.Ejercicio - 1
                Dim _lePAux = lePeriodo.Where(Function(it) it.Ejercicio = _ejercicio And it.Mes = _nroMes)
                If _lePAux.Count > 0 Then
                    _oePerAux = _lePAux(0)
                    _oeCts.TipoOperacion = "" : _oeCts.Activo = True : _oeCts.IdPeriodo = _oePerAux.Id
                    _oeCts.IndTipo = IIf(cboTipo.SelectedIndex = 1, 2, 1)
                    _oeCts = olBonoComp.Obtener(_oeCts)
                    If _oeCts IsNot Nothing AndAlso _oeCts.Id.Trim <> "" AndAlso _oeCts.leDetalle.Count > 0 Then
                        For Each fil In griDetalle.Rows
                            Dim _leAux = _oeCts.leDetalle.Where(Function(it) it.IndPendiente = 1 And it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                            If _leAux.Count > 0 Then
                                If cboTipo.SelectedIndex = 1 Then
                                    fil.Cells("Importe").Value = _leAux(0).NetoTotal
                                Else
                                    fil.Cells("DatoApoyo").Value = _leAux(0).NetoTotal
                                End If
                            Else
                                If cboTipo.SelectedIndex = 1 Then
                                    fil.Cells("Importe").Value = 0
                                Else
                                    fil.Cells("DatoApoyo").Value = 0
                                End If
                            End If
                        Next
                        griDetalle.DataBind() : griDetalle.UpdateData()
                    End If
                End If
                btnBonoAnterior.Enabled = False
                btnCargarDscto.Enabled = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            cboTipoBus.Items.Clear()
            cboTipoBus.Items.Add("GRATIFICACION")
            cboTipoBus.Items.Add("CTS")
            cboTipoBus.SelectedIndex = 0

            cboTipo.Items.Clear()
            cboTipo.Items.Add("GRATIFICACION")
            cboTipo.Items.Add("CTS")
            cboTipo.SelectedIndex = 0

            cboTipoDI.Items.Clear()
            cboTipoDI.Items.Add("GRATIFICACION")
            cboTipoDI.Items.Add("CTS")
            cboTipoDI.SelectedIndex = 0

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = "" : oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            oeEstado = New e_Estado
            oeEstado.Nombre = "GRATIFICACION"
            leEstado = olEstado.Listar(oeEstado)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = "" : oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 0)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = "" : oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oeParametro = New e_AporteDescuento
            oeParametro.TipoOperacion = "" : oeParametro.Activo = True
            leParametro = olParametro.Listar(oeParametro)

            oeDetParametro = New e_DetalleAporteDescuento
            oeDetParametro.TipoOperacion = "" : oeDetParametro.Activo = True : oeDetParametro.Vigencia = 1
            leDetParametro = olDetParametro.Listar(oeDetParametro)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

            oeCentro = New e_Centro
            oeCentro.TipoOperacion = "" : oeCentro.Activo = True
            leCentro = olCentro.Listar(oeCentro)

            oeArea = New e_Area
            oeArea.TipoOperacion = "" : oeArea.IndSector = -1 : oeArea.Activo = True
            leArea = olArea.Listar(oeArea)

            oeOcupacion = New e_Ocupacion
            oeOcupacion.TipoOperacion = "" : oeOcupacion.Activo = True
            leOcupacion = olOcupacion.Listar(oeOcupacion)

            oeCtaCte = New e_CuentaCtePersonal
            oeCtaCte.TipoOperacion = "" : oeCtaCte.Vigente = 1 : oeCtaCte.Activo = True
            leCtaCte = olCtaCte.Listar(oeCtaCte)

            oeRegSalud = New e_RegimenSalud
            oeRegSalud.TipoOperacion = String.Empty : oeRegSalud.Vigente = 1
            leRegSalud = olRegSalud.Listar(oeRegSalud)

            oeAsientoModel = New e_AsientoModelo : leAsientoModel = New List(Of e_AsientoModelo)
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)

            oeReferencia = New e_AsientoModelo_Referencia : leReferencia = New List(Of e_AsientoModelo_Referencia)
            oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
            leReferencia = olReferencia.Listar(oeReferencia)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarGratificacion(leGrati As List(Of e_Gratificacion))
        Try
            With griGratificacion
                .ResetDisplayLayout()
                .DataSource = leGrati
                .Text = "REGISTRO DE BONO COMPENSATORIO"
                ConfiguraGrilla(griGratificacion, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(griGratificacion, True, "Id", "IdPeriodo", "IdEstado", "FechaCreacion", "UsuarioCreacion", _
                               "FechaModifica", "UsuarioModifica", "Activo", "Pendiente", "IndTipo")
                ExcluirColumna(griGratificacion, "Id", "IdPeriodo", "IdEstado", "FechaCreacion", "UsuarioCreacion", _
                              "FechaModifica", "UsuarioModifica", "Activo")
                FormatoColumna(griGratificacion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 500
                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Monto").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("FechaPago").Header.VisiblePosition = 6
                CalcularTotales(griGratificacion, "Monto")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetGrati(leDetGrati As List(Of e_DetalleGratificacion))
        Try
            With griDetalle
                .ResetDisplayLayout()
                Dim _leDet = leDetGrati.Where(Function(it) it.IndPendiente = 0).ToList
                .DataSource = _leDet
                .Text = "REGISTRO DE BENEFICIADOS (" & _leDet.Count & ")"
                ndImporte.Value = _leDet.Sum(Function(it) it.NetoTotal)
            End With
            mt_ConfiguraGrilla(griDetalle, 1, cboTipo.SelectedIndex + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetPendiente(leDetGrati As List(Of e_DetalleGratificacion))
        Try
            With griPendiente
                If _bandload Then .ResetDisplayLayout()
                Dim _lePend = leDetGrati.Where(Function(it) it.IndPendiente = 1).ToList
                .DataSource = _lePend
                .Text = "REGISTRO DE PEDIENTES (" & _lePend.Count & ")"
                ndPendientes.Value = _lePend.Sum(Function(it) it.NetoTotal)
            End With
            If _bandload Then mt_ConfiguraGrilla(griPendiente, 1, cboTipo.SelectedIndex + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetImportar(leImportar As List(Of e_DetalleGratificacion))
        Try
            With griDatosImportar
                .ResetDisplayLayout()
                .DataSource = leImportar
                .Text = "REGISTROS PARA IMPORTAR (" & leImportar.Count & ")"
                mt_ConfiguraGrilla(griDatosImportar, 2, cboTipoDI.SelectedIndex + 1)
                If leImportar.Count > 0 Then btnValidar.Enabled = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_ConfiguraGrilla(Grilla As UltraGrid, Tipo As Integer, Ind As Integer)
        Try
            With Grilla
                ConfiguraGrilla(Grilla, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(Grilla, True, "Id", "IdGratificacion", "IdTrabajador", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", _
                               "IdCentro", "IdArea", "IdOcupacion", "IdCuentaBancaria", "IndTipoAux", "IdCuentaCorriente")
                ExcluirColumna(Grilla, "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", _
                               "IdCentro", "IdArea", "IdOcupacion", "IdCuentaBancaria", "IndTipoAux")
                If Tipo = 1 Then
                    OcultarColumna(Grilla, True, "Activo") : ExcluirColumna(Grilla, "Activo")
                    .DisplayLayout.Override.CellClickAction = CellClickAction.CellSelect
                Else
                    OcultarColumna(Grilla, True, "IndPendiente") : ExcluirColumna(Grilla, "IndPendiente")
                    .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                End If
                If Ind = 1 Then OcultarColumna(Grilla, True, "Gratificacion", "FraccionGrati")
                If Ind = 2 Then OcultarColumna(Grilla, True, "BonoExtra")
                .DisplayLayout.Bands(0).Columns("IndPendiente").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Width = 70
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Header.Caption = "Asig. Fam."
                .DisplayLayout.Bands(0).Columns("FechaIngreso").Header.Caption = "Fec. Ingreso"
                .DisplayLayout.Bands(0).Columns("IndPromedio").Header.Caption = "Act. Prom."
                .DisplayLayout.Bands(0).Columns("PromedioBono").Header.Caption = "Prom. Bono"
                .DisplayLayout.Bands(0).Columns("PromedioHoraExtra").Header.Caption = "Prom. H.E."
                .DisplayLayout.Bands(0).Columns("RenumeracionComputable").Header.Caption = "Ren. Comp."
                .DisplayLayout.Bands(0).Columns("TiempoLaborado").Header.Caption = "Tiempo Lab."
                .DisplayLayout.Bands(0).Columns("PeriodoComputable").Header.Caption = "P. Comp."
                .DisplayLayout.Bands(0).Columns("DescuentosJudiciales").Header.Caption = "Dscto. Jud."
                .DisplayLayout.Bands(0).Columns("AdelantoSueldo").Header.Caption = "Ade. Sueldo"
                .DisplayLayout.Bands(0).Columns("TotalDescuento").Header.Caption = "Total Dscto."
                .DisplayLayout.Bands(0).Columns("Gratificacion").Header.Caption = "Grati."
                .DisplayLayout.Bands(0).Columns("FraccionGrati").Header.Caption = "1/6 Grat."
                .DisplayLayout.Bands(0).Columns("IndPendiente").Header.Caption = "Sel."
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Sueldo", "AsignacionFamiliar", "Renumeracion", "TempIngreso", _
                               "HoraExtra1", "HoraExtra2", "HoraExtra3", "HoraExtra4", "HoraExtra5", "HoraExtra6", "PromedioHoraExtra", "Bono1", _
                               "Bono2", "Bono3", "Bono4", "Bono5", "Bono6", "PromedioBono", "RenumeracionComputable", "TiempoLaborado", "MesesFalta", _
                               "PeriodoComputable", "Importe", "BonoExtra", "Total", "DescuentosJudiciales", "AdelantoSueldo", "TotalDescuento", _
                               "NetoTotal", "Gratificacion", "FraccionGrati", "DatoApoyo")
                FormatoColumna(Grilla, "", ColumnStyle.CheckBox, HAlign.Default, "IndPromedio", "IndPromExtra", "IndPendiente")
                FormatoColumna(Grilla, "", ColumnStyle.Default, HAlign.Center, "DiasFaltas")
                ColorFondoColumna(Grilla, Color.Moccasin, "Trabajador", "Dni", "FechaIngreso")
                ColorFondoColumna(Grilla, Color.LightCyan, "Sueldo", "AsignacionFamiliar", "HoraExtra1", "HoraExtra2", "HoraExtra3", "HoraExtra4", _
                                  "HoraExtra5", "HoraExtra6", "Bono1", "Bono2", "Bono3", "Bono4", "Bono5", "Bono6", "DescuentosJudiciales", "AdelantoSueldo", _
                                  "Importe", "BonoExtra", "TiempoLaborado", "MesesFalta")
                ColorFondoColumna(Grilla, Color.LightSkyBlue, "Renumeracion", "PromedioHoraExtra", "PromedioBono", "TotalDescuento", "Total", "PeriodoComputable")
                .DisplayLayout.Bands(0).Columns("NetoTotal").CellAppearance.BackColor = Color.Navy
                .DisplayLayout.Bands(0).Columns("NetoTotal").CellAppearance.ForeColor = Color.White
                CongelaColumna(Grilla, "IndPendiente", "Dni", "Trabajador", "FechaIngreso")
                CalcularTotales(Grilla, "NetoTotal")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeBonoComp = New e_Gratificacion
            oeBonoComp.TipoOperacion = ""
            oeBonoComp.Activo = True
            oeBonoComp.IndTipo = cboTipoBus.SelectedIndex + 1
            oeBonoComp.IdEstado = cboEstadoBus.Value
            leBonoComp = olBonoComp.Listar(oeBonoComp)
            CargarGratificacion(leBonoComp)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        cboTipo.SelectedIndex = 0
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        cboPeriodo.SelectedIndex = -1
        nBono.Value = 6
        ndImporte.Value = 0
        ndImporte.ReadOnly = True
        cboEstado.ReadOnly = True
        txtCodigo.ReadOnly = True
        btnCargar.Enabled = False
        btnAgregar.Enabled = False
        btnCargarExtras.Enabled = False
        btnCargarBono.Enabled = False
        btnFaltas.Enabled = False
        btnGrati.Enabled = False
        btnBonoAnterior.Enabled = False
        btnCargarDscto.Enabled = False
        oePeriodo = New e_Periodo
        leTrabActivo = New List(Of e_Trabajador)
        leDetalle = New List(Of e_DetalleGratificacion)
        CargarDetGrati(leDetalle)
        CargarDetPendiente(leDetalle)
        chkDetalleExtra.Checked = True
        chkDetalleBono.Checked = True
        chkDatosTrab.Checked = True
        agrProvisionar.Visible = False
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeGrati As New e_Gratificacion
            oeGrati.TipoOperacion = "U"
            oeGrati.IndTipo = cboTipo.SelectedIndex + 1
            oeGrati = olBonoComp.Obtener(oeGrati)
            If oeGrati IsNot Nothing AndAlso oeGrati.Codigo <> "" Then
                str = oeGrati.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub SeleccionaTab(_index As Integer)
        ficGratificacion.Tabs(0).Enabled = False
        ficGratificacion.Tabs(1).Enabled = False
        ficGratificacion.Tabs(2).Enabled = False
        ficGratificacion.Tabs(_index).Enabled = True
        ficGratificacion.Tabs(_index).Selected = True
    End Sub

    Private Sub Mostrar()
        Try
            oeBonoComp = New e_Gratificacion
            oeBonoComp.TipoOperacion = ""
            oeBonoComp.Id = griGratificacion.ActiveRow.Cells("Id").Value
            oeBonoComp = olBonoComp.Obtener(oeBonoComp)
            With oeBonoComp
                cboTipo.SelectedIndex = .IndTipo - 1
                txtCodigo.Text = .Codigo
                cboEstado.Value = .IdEstado
                Select Case cboTipo.SelectedIndex
                    Case 0
                        Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio + it.Mes).ToList
                        LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)
                    Case 1
                        Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 5 Or it.Mes = 11).OrderByDescending(Function(it) it.Ejercicio + it.Mes).ToList
                        LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)
                End Select
                cboPeriodo.Value = .IdPeriodo
                ndImporte.Value = .Monto
                nBono.Value = .PromBono
                fecPago.Value = .FechaPago
                leDetalle = .leDetalle
                CargarDetGrati(leDetalle)
                CargarDetPendiente(leDetalle)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeBonoComp.IndTipo = cboTipo.SelectedIndex + 1
        oeBonoComp.Codigo = txtCodigo.Text
        oeBonoComp.Monto = Math.Round(ndImporte.Value, 2)
        oeBonoComp.Pendiente = Math.Round(ndPendientes.Value, 2)
        oeBonoComp.Glosa = txtGlosa.Text
        oeBonoComp.IdEstado = cboEstado.Value
        oeBonoComp.IdPeriodo = cboPeriodo.Value
        oeBonoComp.leDetalle = leDetalle
        oeBonoComp.FechaPago = fecPago.Value
        oeBonoComp.PromBono = nBono.Value
    End Sub

    Private Sub LlenarProduccion(leBPR As List(Of e_BonificacionProduccion), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leBPAux As New List(Of e_BonificacionProduccion)
            Dim i As Integer = 0, _mes As Integer = 0, nroreg As Integer = 0
            Dim _fecIng As Date = #1/1/1901#
            For i = 0 To idpla.Count - 1
                Dim _le = leBPR.Where(Function(it) "'" & it.IdPlanilla & "'" = idpla(i)).ToList
                _mes = idpla.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            Dim _band1 As Boolean
            For Each fil In griDetalle.Rows
                _fecIng = fil.Cells("FechaIngreso").Value
                If Year(_fecIng) = oePeriodo.Ejercicio And Month(_fecIng) >= (oePeriodo.Mes - 2) Then
                    fil.Cells("IndPromedio").Value = 0
                Else
                    nroreg = nroreg + 1
                    etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                    upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                    _leBPAux = leBPR.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                    fil.Cells("IndPromedio").Value = 1
                    'If _leBPAux.Count > 0 Then
                    Dim contador As Integer = 0
                    For Each _aux In _leBPAux
                        _band1 = True
                        If oePeriodo.Mes = 11 Or oePeriodo.Mes = 12 Then
                            If Year(_fecIng) = oePeriodo.Ejercicio And Month(_fecIng) > _aux.Mes Then _band1 = False
                        End If
                        If oePeriodo.Mes = 5 Then
                            If Year(_fecIng) = oePeriodo.Ejercicio Then
                                If Year(_fecIng) = _aux.Ejercicio And Month(_fecIng) > _aux.Mes Then _band1 = False
                                If Year(_fecIng) > _aux.Ejercicio And Month(_fecIng) < _aux.Mes Then _band1 = False
                            End If
                            If Year(_fecIng) = (oePeriodo.Ejercicio - 1) Then
                                If Year(_fecIng) = _aux.Ejercicio And Month(_fecIng) > _aux.Mes Then _band1 = False
                            End If
                        End If
                        If _band1 Then
                            If _fecIng.Year = oePeriodo.Ejercicio Then
                                If _fecIng.Date.Month <= _aux.Mes Then
                                    fil.Cells("Bono" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla
                                    If fil.Cells("Bono" & _aux.NroMes.ToString).Value > 0 Then contador = contador + 1
                                Else
                                    fil.Cells("Bono" & _aux.NroMes.ToString).Value = 0
                                End If
                            Else
                                fil.Cells("Bono" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla
                                If fil.Cells("Bono" & _aux.NroMes.ToString).Value > 0 Then contador = contador + 1
                            End If

                        End If
                    Next
                    'End If
                    'fil.Cells("IndPromedio").Value = IIf(fil.Cells("PromedioBono").Value > 0, 1, 0)
                    fil.Cells("IndPromedio").Value = IIf(contador > 2, 1, 0)
                End If
            Next
            griDetalle.DataBind() : griDetalle.UpdateData()
            Dim _band2 As Boolean
            For Each fil In griPendiente.Rows
                _fecIng = fil.Cells("FechaIngreso").Value
                If Year(_fecIng) = oePeriodo.Ejercicio And Month(_fecIng) >= (oePeriodo.Mes - 2) Then
                    fil.Cells("IndPromedio").Value = 0
                Else
                    nroreg = nroreg + 1
                    etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                    upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                    _leBPAux = leBPR.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                    fil.Cells("IndPromedio").Value = 1
                    Dim contador As Integer = 0
                    For Each _aux In _leBPAux
                        _band2 = True
                        If oePeriodo.Mes = 11 Or oePeriodo.Mes = 12 Then
                            If Year(_fecIng) = oePeriodo.Ejercicio And Month(_fecIng) > _aux.Mes Then _band2 = False
                        End If
                        If oePeriodo.Mes = 5 Then
                            If Year(_fecIng) = oePeriodo.Ejercicio Then
                                If Year(_fecIng) = _aux.Ejercicio And Month(_fecIng) > _aux.Mes Then _band2 = False
                                If Year(_fecIng) > _aux.Ejercicio And Month(_fecIng) < _aux.Mes Then _band2 = False
                            End If
                            If Year(_fecIng) = (oePeriodo.Ejercicio - 1) Then
                                If Year(_fecIng) = _aux.Ejercicio And Month(_fecIng) > _aux.Mes Then _band2 = False
                            End If
                        End If
                        If _band2 Then
                            fil.Cells("Bono" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla
                            If fil.Cells("Bono" & _aux.NroMes.ToString).Value > 0 Then contador = contador + 1
                        End If
                    Next
                    'fil.Cells("IndPromedio").Value = IIf(fil.Cells("PromedioBono").Value > 0, 1, 0)
                    fil.Cells("IndPromedio").Value = IIf(contador > 2, 1, 0)
                End If
            Next
            griPendiente.DataBind() : griPendiente.UpdateData()
            ndImporte.Value = leDetalle.Where(Function(it) it.IndPendiente = 0).Sum(Function(it) it.NetoTotal)
            ndPendientes.Value = leDetalle.Where(Function(it) it.IndPendiente = 1).Sum(Function(it) it.NetoTotal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarFaltas(leFalt As List(Of e_ResumenAsistencia), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leDF As New List(Of e_ResumenAsistencia)
            Dim nroreg As Integer = 0
            For Each fil In griDetalle.Rows
                nroreg = nroreg + 1
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                '_leDF = leFalt.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                _leDF = leFalt.Where(Function(it) it.Dni.Trim = fil.Cells("DNI").Value.ToString.Trim).ToList
                fil.Cells("DiasFaltas").Value = _leDF.Sum(Function(it) it.Cantidad)
            Next
            griDetalle.DataBind() : griDetalle.UpdateData()
            For Each fil In griPendiente.Rows
                nroreg = nroreg + 1
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                '_leDF = leFalt.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                _leDF = leFalt.Where(Function(it) it.Dni = fil.Cells("DNI").Value.ToString.Trim).ToList
                fil.Cells("DiasFaltas").Value = _leDF.Sum(Function(it) it.Cantidad)
            Next
            griPendiente.DataBind() : griPendiente.UpdateData()
            ndImporte.Value = leDetalle.Where(Function(it) it.IndPendiente = 0).Sum(Function(it) it.NetoTotal)
            ndPendientes.Value = leDetalle.Where(Function(it) it.IndPendiente = 1).Sum(Function(it) it.NetoTotal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarExtras(leExt As List(Of e_DetallePagoAdicional), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leHE As New List(Of e_DetallePagoAdicional)
            Dim i As Integer = 0, _mes As Integer = 0, nroreg As Integer = 0
            For i = 0 To idpla.Count - 1
                Dim _le = leExt.Where(Function(it) "'" & it.IdPlanilla & "'" = idpla(i)).ToList
                _mes = idpla.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            For Each fil In griDetalle.Rows
                nroreg = nroreg + 1
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                _leHE = leExt.Where(Function(it) it.IndTipo < 3 And it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                fil.Cells("IndPromExtra").Value = 1
                Dim contador As Integer = 0
                For Each _aux In _leHE
                    fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value = fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value + _aux.Monto
                    If fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value > 0 Then contador = contador + 1
                Next
                'fil.Cells("IndPromExtra").Value = IIf(fil.Cells("PromedioHoraExtra").Value > 0, 1, 0)
                fil.Cells("IndPromExtra").Value = IIf(contador > 2, 1, 0)
            Next
            griDetalle.DataBind() : griDetalle.UpdateData()
            For Each fil In griPendiente.Rows
                nroreg = nroreg + 1
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                _leHE = leExt.Where(Function(it) it.IndTipo < 3 And it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                fil.Cells("IndPromExtra").Value = 1
                Dim contador As Integer = 0
                For Each _aux In _leHE
                    fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value = fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value + _aux.Monto
                    If fil.Cells("HoraExtra" & _aux.NroMes.ToString).Value > 0 Then contador = contador + 1
                Next
                'fil.Cells("IndPromExtra").Value = IIf(fil.Cells("PromedioHoraExtra").Value > 0, 1, 0)
                fil.Cells("IndPromExtra").Value = IIf(contador > 2, 1, 0)
            Next
            griPendiente.DataBind() : griPendiente.UpdateData()
            ndImporte.Value = leDetalle.Where(Function(it) it.IndPendiente = 0).Sum(Function(it) it.NetoTotal)
            ndPendientes.Value = leDetalle.Where(Function(it) it.IndPendiente = 1).Sum(Function(it) it.NetoTotal)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ObtieneValorParametro(ls_Nombre_Parametro As String) As Double
        Try
            oeParametro = New e_AporteDescuento
            oeParametro.Abreviatura = ls_Nombre_Parametro
            oeParametro.Equivale = 4
            If leParametro.Contains(oeParametro) Then
                oeParametro = leParametro.Item(leParametro.IndexOf(oeParametro))
                oeDetParametro = New e_DetalleAporteDescuento
                oeDetParametro.IdAporteDescuento = oeParametro.Id
                oeDetParametro.Equivale = 2
                If leDetParametro.Contains(oeDetParametro) Then
                    oeDetParametro = leDetParametro.Item(leDetParametro.IndexOf(oeDetParametro))
                End If
            End If
            Return oeDetParametro.MontoCalculo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Importar()
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeGrati = "IMPORTAR"
                SeleccionaTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                cboTipoDI.SelectedIndex = 0
                Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio).ToList
                LlenarCombo(cboPeriodoDI, "Codigo", _lePerAux, -1)
                cboPeriodoDI.SelectedIndex = -1
                oePeriodo = New e_Periodo
                leDetImportar = New List(Of e_DetalleGratificacion)
                CargarDetImportar(leDetImportar)
                nPromBono.Value = 6
                btnBuscar.Enabled = False
                btnValidar.Enabled = False
                btnDatosExcluidos.Enabled = False
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griGratificacion.ActiveRow.Cells("Estado").Value = _estado AndAlso griGratificacion.ActiveRow.Cells("Monto").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opeGrati = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Planilla General " & Environment.NewLine & _
                                        "Nº: " & griGratificacion.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Provisionar()
        Try
            _acl = gAccionSistema.PROVISIONAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griGratificacion.ActiveRow.Cells("Estado").Value = _estado AndAlso griGratificacion.ActiveRow.Cells("Monto").Value > 0 Then
                    If leAsientoModel.Count > 0 Then
                        Editar()
                        oeAsientoModel = New e_AsientoModelo
                        oeReferencia = New e_AsientoModelo_Referencia
                        oeReferencia.Equivale = 3
                        oeReferencia.TipoReferencia = 16 : oeReferencia.Nombre = cboTipo.Text
                        If leReferencia.Contains(oeReferencia) Then
                            oeReferencia = leReferencia.Item(leReferencia.IndexOf(oeReferencia))
                            oeAsientoModel.Id = oeReferencia.IdActividad
                            oeAsientoModel.TipoOperacion = String.Empty
                            oeAsientoModel.Ejercicio = oePeriodo.Ejercicio
                            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                            _opeGrati = "PROVISIONAR"
                            cboEstado.Text = gNombreEstadoTerminada
                            agrProvisionar.Visible = True
                        End If
                    End If
                Else
                    Throw New Exception("No puede en PROVISIONAR el Registro de Gratificacion " & Environment.NewLine & _
                                        "Nº: " & griGratificacion.ActiveRow.Cells("Codigo").Value & " por que no esta " & _estado)
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarLogicas()
        olAsientoModel = New l_AsientoModelo
        olReferencia = New l_AsientoModelo_Referencia
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcGratificacion_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcGratificacion.Opening
        mcGratificacion.Items("tsmiNuevo").Enabled = True
        mcGratificacion.Items("tsmiEditar").Enabled = IIf(griGratificacion.Selected.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiEliminar").Enabled = IIf(griGratificacion.Selected.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiEnviar").Enabled = IIf(griGratificacion.Selected.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiExtornar").Enabled = IIf(griGratificacion.Selected.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiTerminar").Enabled = IIf(griGratificacion.Selected.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiExportar").Enabled = IIf(griGratificacion.Rows.Count > 0, True, False)
        mcGratificacion.Items("tsmiImportar").Enabled = True
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Eliminar()
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griGratificacion.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExtornar_Click(sender As Object, e As EventArgs) Handles tsmiExtornar.Click

    End Sub

    Private Sub tsmiTerminar_Click(sender As Object, e As EventArgs) Handles tsmiTerminar.Click
        Try
            If griGratificacion.Selected.Rows.Count > 0 Then Provisionar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click

    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

#End Region

    Private Sub tsmiGenerarCTS_Click(sender As Object, e As EventArgs) Handles tsmiGenerarCTS.Click
        'Dim oDoc As New iTextSharp.text.Document(PageSize.A4.Rotate(), 0, 0, 0, 0)
        'Dim pdfw As iTextSharp.text.pdf.PdfWriter
        'Dim cb As PdfContentByte
        'Dim sNombreArchivo As String = "D:\CTS.pdf"
        'Dim ct As ColumnText


        Dim oDoc As New iTextSharp.text.Document(PageSize.A4.Rotate(), 0, 0, 0, 0)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim cb As PdfContentByte
        Dim sNombreArchivo As String
        Dim ct As ColumnText
        Dim IdPlanilla As String = ""
        Dim periodo As String = ""
        Dim AnioMes As String = ""
        Dim ListaDNI As New List(Of String)

        

        Try
            If griGratificacion.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar un Registro.")
            'validar estados de periodo (planilla, utilidades, cts, liquidaciones)
            ''
            ''
            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim oeBonoCompG As New e_Gratificacion
            oeBonoCompG.TipoOperacion = ""
            oeBonoCompG.Id = griGratificacion.ActiveRow.Cells("Id").Value
            oeBonoCompG = olBonoComp.Obtener(oeBonoCompG)

            Dim oePeriodoAux As New e_Periodo
            oePeriodoAux.Id = oeBonoCompG.IdPeriodo
            oePeriodoAux = olPeriodo.Obtener(oePeriodoAux)
            Dim fechaPago As New Date(oePeriodoAux.Ejercicio, oePeriodoAux.Mes, 15)


            Dim oeMoneda As New e_Moneda
            Dim olMoneda As New l_Moneda
            oeMoneda.TipoOperacion = ""
            oeMoneda.Id = "1CH01"
            oeMoneda = olMoneda.Obtener(oeMoneda)


            Dim arrColumnas(1) As stColumna
            

            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath + "\CTS-" + oePeriodoAux.Ejercicio.ToString + "-" + oePeriodoAux.Mes.ToString + ".pdf"
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(sNombreArchivo, _
                   FileMode.Create, FileAccess.Write, FileShare.None))

            oDoc.Open()
            oDoc.NewPage()

            Dim fuente As iTextSharp.text.pdf.BaseFont
            'fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL).BaseFont

            cb = pdfw.DirectContent

            arrColumnas(0).MargenIzquierdo = 60
            arrColumnas(0).MargenDerecho = (PageSize.A4.Height / 2) - 30
            arrColumnas(1).MargenIzquierdo = (PageSize.A4.Height / 2) + 30
            arrColumnas(1).MargenDerecho = PageSize.A4.Height - 60



            


            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            


            'Dim arrColumnas(0) As stColumna
            'Dim iEstado As Integer = 0, iColumna As Integer = 0, sizeletra As Integer = 8
            ''Dim imagepath As String = "D:\"
            'Dim imagepath As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaImagen") + "\"
            'Dim colorCeldas1 As New BaseColor(Color.LightBlue)
            'Dim colorCeldas2 As New BaseColor(Color.LightCyan)

            'Const INTERLINEADO As Single = 20
            'Const MARGEN_SUPERIOR As Single = 40
            'Const MARGEN_INFERIOR As Single = 40
            Const INTERLINEADO As Single = 10
            Const MARGEN_SUPERIOR As Single = 20
            Const MARGEN_INFERIOR As Single = 20

            ''Dim RucISL As String = "20479729141"
            ''Dim IdPlanilla As String = griPlanilla.ActiveRow.Cells("Id").Value
            ''Dim periodo As String = oeBonoCompG.ActiveRow.Cells("IdPeriodo").Value
            ''Dim AnioMes As String = griPlanilla.ActiveRow.Cells("Periodo").Value
            ''Dim Anio As String = AnioMes.Substring(0, 4)
            ''Dim Mes As String = AnioMes.Substring(5)
            ''If CInt(Mes) < 10 Then Mes = "0" + Mes.Trim
            ''AnioMes = Anio + Mes

            'FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            'If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    sNombreArchivo = FolderBrowserDialog1.SelectedPath + "\CTS-" + oePeriodoAux.Ejercicio.ToString + "-" + oePeriodoAux.Mes.ToString + ".pdf"
            'Else
            '    FolderBrowserDialog1.Dispose()
            '    Return
            'End If

            'Dim jpg As Image = Image.GetInstance(imagepath + "Firma.jpg")
            ''    jpg.ScaleToFit(300.0F, 300.0F)
            ''    jpg.SpacingAfter = 12.0F
            ''    jpg.SpacingBefore = 12.0F

            'pdfw = PdfWriter.GetInstance(oDoc, New FileStream(sNombreArchivo, _
            '       FileMode.Create, FileAccess.Write, FileShare.None))

            'oDoc.Open()
            'oDoc.NewPage()

            


            'cb = pdfw.DirectContent
            ''Seteamos el tipo de letra y el tamaño.
            ''cb.SetFontAndSize(fuente, 16)
            ''Seteamos el color del texto a escribir.
            ''cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)


            ''arrColumnas(0).MargenIzquierdo = 60
            ''arrColumnas(0).MargenDerecho = 280
            ''arrColumnas(1).MargenIzquierdo = 320
            ''arrColumnas(1).MargenDerecho = 530
            'arrColumnas(0).MargenIzquierdo = 60
            ''arrColumnas(0).MargenDerecho = (PageSize.A4.Height / 2) - 30
            'arrColumnas(0).MargenDerecho = PageSize.A4.Width - 60
            ''arrColumnas(1).MargenIzquierdo = (PageSize.A4.Height / 2) + 30
            ''arrColumnas(1).MargenDerecho = PageSize.A4.Height - 60

            
            For Each item In oeBonoCompG.leDetalle
                ct = New ColumnText(cb)
                GenerarElementoPdfCTS(ct, arrColumnas, oeBonoCompG, item, oePeriodoAux, oeMoneda)
                ct.SetSimpleColumn(arrColumnas(0).MargenDerecho, MARGEN_INFERIOR, arrColumnas(0).MargenIzquierdo, oDoc.PageSize.Height - MARGEN_SUPERIOR, INTERLINEADO, Element.ALIGN_JUSTIFIED_ALL)
                ct.Go()

                ct = New ColumnText(cb)
                GenerarElementoPdfCTS(ct, arrColumnas, oeBonoCompG, item, oePeriodoAux, oeMoneda)
                ct.SetSimpleColumn(arrColumnas(1).MargenDerecho, MARGEN_INFERIOR, arrColumnas(1).MargenIzquierdo, oDoc.PageSize.Height - MARGEN_SUPERIOR, INTERLINEADO, Element.ALIGN_JUSTIFIED_ALL)
                ct.Go()

                oDoc.NewPage()
            Next

            oDoc.Close()
            mensajeEmergente.Confirmacion("Archivos Generados Con Exito.", True)

        Catch ex As Exception
            ''Si hubo un error y el archivo existe ...
            'If File.Exists(sNombreArchivo) Then
            '    'Chequeo si el Doc esta abierto y asi poder
            '    'desbloquear el archivo para su eliminacion.
            '    If oDoc.IsOpen Then oDoc.Close()

            '    '... lo elimino del disco.
            '    File.Delete(sNombreArchivo)
            'End If
            'Throw New Exception("Error al generar archivo PDF (" & ex.Message & ")")
            Espere2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            'Limpieza
            cb = Nothing
            pdfw = Nothing
            oDoc = Nothing
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere2.Visible = False
        End Try
    End Sub

    Private Structure stColumna
        Dim MargenDerecho As Single
        Dim MargenIzquierdo As Single
    End Structure

    Private Sub GenerarElementoPdfCTS(ByRef ct As ColumnText, arrColumnas() As stColumna, ByVal oeBonoCompG As e_Gratificacion, ByVal item As e_DetalleGratificacion, ByVal oePeriodoAux As e_Periodo, oeMoneda As e_Moneda)
        Dim oeCuentaCtePersonal As e_CuentaCtePersonal
        Dim olCuentaCtePersonal As New l_CuentaCtePersonal

        Dim iEstado As Integer = 0, iColumna As Integer = 0, sizeletra As Integer = 7
        Dim imagepath As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaImagen") + "\"
        Dim colorCeldas1 As New BaseColor(Color.LightBlue)
        Dim colorCeldas2 As New BaseColor(Color.LightCyan)

        Dim jpgEncabezado As Image = Image.GetInstance(imagepath + "CabeceraBoleta.jpg")
        Dim jpgFirma As Image = Image.GetInstance(imagepath + "FirmaSola.jpg")

        Dim fuenteTitulo As iTextSharp.text.pdf.BaseFont
        fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLDITALIC).BaseFont

        Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)
        Dim Font = FontFactory.GetFont(FontFactory.HELVETICA, 8)
        Dim Font_bold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)

        Dim fuenteTrabajador As iTextSharp.text.pdf.BaseFont
        fuenteTrabajador = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD).BaseFont

        Dim fuenteTexto As iTextSharp.text.pdf.BaseFont
        fuenteTexto = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL).BaseFont

        Dim fuenteTextoBlod As iTextSharp.text.pdf.BaseFont
        fuenteTextoBlod = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD).BaseFont

        'Dim lineaTexto As StringBuilder
        Dim meses As Integer
        Dim dias As Integer
        Dim parrafo As Paragraph

        meses = Math.Truncate(item.PeriodoComputable)
        dias = (30 * item.PeriodoComputable) - (30 * meses)

        ct.AddElement(jpgEncabezado)

        parrafo = New Paragraph("LIQUIDACIÓN DE COMPENSACIÓN POR TIEMPO DE SERVICIOS")
        parrafo.Alignment = Element.ALIGN_CENTER
        parrafo.Font = boldFont
        ct.AddElement(parrafo)
        ct.AddElement(New Paragraph(" "))

        parrafo = New Paragraph("INDUAMERICA SERVICIOS LOGISTICOS S.A.C. Ubicada en Psj. Real Número. 120 Mercado Productores Sta. Anita - Lima, representada por su Gerente General Sr. Sixto Perales Huancaruna, otorga al Sr(a)")
        parrafo.Alignment = Element.ALIGN_JUSTIFIED
        parrafo.Font = Font
        ct.AddElement(parrafo)

        parrafo = New Paragraph(item.Trabajador)
        parrafo.Alignment = Element.ALIGN_CENTER
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        Dim FechaInicioCts As Date
        Dim FechaFinCts As Date
        Dim FechaInicioCtsAux As Date
        If oePeriodoAux.Mes = 11 Then
            FechaInicioCts = "01/05/" & oePeriodoAux.Ejercicio.ToString
            FechaInicioCtsAux = "01/05/" & oePeriodoAux.Ejercicio.ToString
            If item.Importe > 0 Then FechaInicioCts = item.FechaIngreso
            'FechaFinCts = "31 Octubre del " + oePeriodoAux.Ejercicio.ToString
            FechaFinCts = "31/10/" & oePeriodoAux.Ejercicio.ToString
        End If

        If oePeriodoAux.Mes = 5 Then
            FechaInicioCts = "01/11/" & (oePeriodoAux.Ejercicio - 1).ToString
            FechaInicioCtsAux = "01/11/" & (oePeriodoAux.Ejercicio - 1).ToString
            If item.Importe > 0 Then FechaInicioCts = item.FechaIngreso
            'FechaFinCts = "30 Abril del " & oePeriodoAux.Ejercicio.ToString
            FechaFinCts = "30/04/" & oePeriodoAux.Ejercicio.ToString
        End If

        'If oePeriodoAux.Mes = 11 Then FechaFinCts = "31 Octubre del " + oePeriodoAux.Ejercicio.ToString
        'If oePeriodoAux.Mes = 5 Then FechaFinCts = "30 Abril del " + oePeriodoAux.Ejercicio.ToString

        'parrafo = New Paragraph("Constancia del depósito de su Compensación de Tiempo de Servicio realizado el día " + fechaPago.Day.ToString + " de " + MonthName(fechaPago.Month) + " del " + fechaPago.Year.ToString + ", por el siguiente monto y periodo.")
        parrafo = New Paragraph("la presente constancia de depósito de su Compensación por Tiempo de Servicios realizada al " + FechaFinCts + " por el siguiente monto y periodo:")
        'parrafo = New Paragraph("Constancia del depósito de su Compensación de Tiempo de Servicio realizado el día " + oeBonoCompG.FechaPago.Day.ToString + " de " + MonthName(oeBonoCompG.FechaPago.Month) + " del " + oeBonoCompG.FechaPago.Year.ToString + ", por el siguiente monto y periodo.")
        parrafo.Alignment = Element.ALIGN_JUSTIFIED
        parrafo.Font = Font
        ct.AddElement(parrafo)

        parrafo = New Paragraph("1.- Periodo que se liquida")
        parrafo.Alignment = Element.ALIGN_LEFT
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        Dim table As PdfPTable = New PdfPTable(2)
        table.TotalWidth = 280.0F
        table.LockedWidth = True
        Dim widths As Single() = New Single() {120.0F, 160.0F}
        table.SetWidths(widths)

        Dim cell As PdfPCell = New PdfPCell(New Phrase("Del: ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(FechaInicioCts, New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase("Al: ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(FechaFinCts, New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)

        ct.AddElement(table)

        parrafo = New Paragraph("2.- Remuneración Mensual")
        parrafo.Alignment = Element.ALIGN_LEFT
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        table = New PdfPTable(2)
        table.TotalWidth = 280.0F
        table.LockedWidth = True
        widths = New Single() {120.0F, 160.0F}
        table.SetWidths(widths)

        cell = New PdfPCell(New Phrase("Remuneración Básica ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.Sueldo.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Asignación Familiar ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.AsignacionFamiliar.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Horas Extras ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.PromedioHoraExtra.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Bonificación por Producción ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.PromedioBono.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("1/6 Gratificación ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.FraccionGrati.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Remuneración Computable ", New Font(fuenteTextoBlod, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.RenumeracionComputable.ToString("#,##0.0000"), New Font(fuenteTextoBlod, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        ct.AddElement(table)

        parrafo = New Paragraph("3.- Tiempo de Servicios Computable")
        parrafo.Alignment = Element.ALIGN_LEFT
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        table = New PdfPTable(2)
        table.TotalWidth = 280.0F
        table.LockedWidth = True
        widths = New Single() {120.0F, 160.0F}
        table.SetWidths(widths)

        cell = New PdfPCell(New Phrase("Tiempo efectivo laborado ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(item.TiempoLaborado.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Inasistencia ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(item.MesesFalta.ToString("#,##0.0000"), New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        cell = New PdfPCell(New Phrase("Total tiempo computable ", New Font(fuenteTextoBlod, sizeletra)))
        table.AddCell(cell)
        cell = New PdfPCell(New Phrase(item.PeriodoComputable.ToString("#,##0.0000"), New Font(fuenteTextoBlod, sizeletra)))
        cell.HorizontalAlignment = 2
        table.AddCell(cell)

        ct.AddElement(table)

        parrafo = New Paragraph("4.- Cálculo de la C.T.S.")
        parrafo.Alignment = Element.ALIGN_LEFT
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        parrafo = New Paragraph("Pagos Recibidos por la Remuneración de C.T.S del " & FechaInicioCts & " al " & FechaFinCts)
        parrafo.Alignment = Element.ALIGN_JUSTIFIED
        parrafo.Font = Font
        ct.AddElement(parrafo)

        If item.Importe > 0 Then
            Dim oeDetCtsAnterior As New e_DetalleGratificacion
            Dim ListaDetCtsAnterior As New List(Of e_DetalleGratificacion)
            oeDetCtsAnterior.TipoOperacion = "2"
            oeDetCtsAnterior.IndTipo = 2
            oeDetCtsAnterior.IdTrabajador = item.IdTrabajador
            oeDetCtsAnterior.Activo = True
            ListaDetCtsAnterior = olDetalle.Listar(oeDetCtsAnterior)
            oeDetCtsAnterior = ListaDetCtsAnterior.Where(Function(x) x.FechaIngreso.Date = item.FechaIngreso.Date And x.NetoTotal = item.Importe And x.FechaCreacion < item.FechaCreacion).ToList(0)
            'Dim _lePerAux = lePeriodo.Where(Function(it) it.Mes = 7 Or it.Mes = 12).OrderByDescending(Function(it) it.Ejercicio).ToList
            parrafo = New Paragraph("Periodo " & FechaInicioCts & "-" & FechaInicioCtsAux.AddDays(-1) & ": " & oeDetCtsAnterior.RenumeracionComputable.ToString("#,##0.0000") & " / 12 x " & oeDetCtsAnterior.PeriodoComputable.ToString("#,##0.0000") & " = " & oeDetCtsAnterior.Total.ToString("#,##0.0000"))
            parrafo.Alignment = Element.ALIGN_CENTER
            parrafo.Font = Font
            ct.AddElement(parrafo)

            parrafo = New Paragraph("Periodo " & FechaInicioCtsAux & "-" & FechaFinCts & ": " & item.RenumeracionComputable.ToString("#,##0.0000") & " / 12 x " & item.PeriodoComputable.ToString("#,##0.0000") & " = " & item.Total.ToString("#,##0.0000"))
            parrafo.Alignment = Element.ALIGN_CENTER
            parrafo.Font = Font
            ct.AddElement(parrafo)
        Else
            parrafo = New Paragraph(item.RenumeracionComputable.ToString("#,##0.0000") & " / 12 x " & item.PeriodoComputable.ToString("#,##0.0000") & " = " & item.NetoTotal.ToString("#,##0.0000"))
            parrafo.Alignment = Element.ALIGN_CENTER
            parrafo.Font = Font
            ct.AddElement(parrafo)
        End If

        parrafo = New Paragraph("Importe Depositado: " & item.NetoTotal.ToString("#,##0.0000"))
        parrafo.Alignment = Element.ALIGN_CENTER
        parrafo.Font = boldFont
        ct.AddElement(parrafo)

        ct.AddElement(New Paragraph(" "))

        oeCuentaCtePersonal = New e_CuentaCtePersonal
        oeCuentaCtePersonal.TipoOperacion = ""
        oeCuentaCtePersonal.Id = item.IdCuentaCorriente
        oeCuentaCtePersonal = olCuentaCtePersonal.Obtener(oeCuentaCtePersonal)

        parrafo = New Paragraph("El Importe de la presente liquidación de Compensación por Tiempo de Servicios ha sido depositado al " & oeBonoCompG.FechaPago & " en el " & oeCuentaCtePersonal.EntidadBancaria & " en la cuenta " & oeCuentaCtePersonal.NroCuenta & " en Moneda Nacional. En consecuencia todos mis derechos por CTS han sido cancelados con arreglo Ley no quedando nada pendiente, por reclamar por lo que quedo conforme")
        parrafo.Alignment = Element.ALIGN_JUSTIFIED
        parrafo.Font = Font
        ct.AddElement(parrafo)

        

        table = New PdfPTable(2)
        table.DefaultCell.Border = Rectangle.NO_BORDER
        table.TotalWidth = 280.0F
        table.LockedWidth = True
        widths = New Single() {100.0F, 180.0F}
        table.SetWidths(widths)

        'cell = New PdfPCell(New ima Phrase("Remuneración Básica ", New Font(fuenteTexto, sizeletra)))
        table.AddCell(jpgFirma)

        'cell = New PdfPCell(New Phrase(oeMoneda.Abreviatura + " " + item.Sueldo.ToString("#,##0.00"), New Font(fuenteTexto, sizeletra)))
        'cell.HorizontalAlignment = 2


        'parrafo.Alignment = Element.ALIGN_RIGHT
        'parrafo.Font = Font_bold
        'ct.AddElement(parrafo)

        'parrafo = New Paragraph(item.Dni & " - " & item.Trabajador)
        'parrafo.Alignment = Element.ALIGN_RIGHT
        'parrafo.Font = Font_bold
        ''ct.AddElement(parrafo)

        Dim lineas As New StringBuilder
        lineas.AppendLine(item.Trabajador)
        lineas.AppendLine("DNI: " & item.Dni)
        lineas.AppendLine("RECIBI CONFORME")

        cell = New PdfPCell(New Phrase(lineas.ToString, New Font(fuenteTexto, sizeletra)))
        cell.HorizontalAlignment = 1
        cell.VerticalAlignment = Element.ALIGN_BOTTOM
        cell.Border = 0
        table.AddCell(cell)

        'parrafo = New Paragraph("RECIBI CONFORME")
        'parrafo.Alignment = Element.ALIGN_RIGHT
        'parrafo.Font = Font
        'ct.AddElement(parrafo)
        'table.AddCell(parrafo)

        ct.AddElement(table)

    End Sub

End Class