'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports MSScriptControl
Imports Microsoft.Office.Interop
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Text

Public Class frm_RetencionImpuesto5ta
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_RetencionImpuesto5ta = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_RetencionImpuesto5ta()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oeRetencionQuinta As New e_RetencionQuinta, olRetencionQuinta As New l_RetencionQuinta
    Private leRetencionQuinta As New List(Of e_RetencionQuinta), leR5Historial As New List(Of e_RetencionQuinta)
    Private oeDetalleRentaQuinta As New e_DetalleRentaQuinta, olDetalleRentaQuinta As New l_DetalleRentaQuinta, leDetalleRentaQuinta As New List(Of e_DetalleRentaQuinta)
    Private leDetImportar As New List(Of e_DetalleRentaQuinta), leDetalleR5Historial As New List(Of e_DetalleRentaQuinta)
    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla, lePlanilla As New List(Of e_Planilla), lePlanillaGen As New List(Of e_Planilla)
    Private oeDetallePla As New e_DetallePlanilla, olDetallePla As New l_DetallePlanilla, leDetallePla As New List(Of e_DetallePlanilla)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador
    Private leTrabajador As New List(Of e_Trabajador), leTrabActivo As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeParametro As New e_AporteDescuento, olParametro As New l_AporteDescuento, leParametro As New List(Of e_AporteDescuento)
    Private oeDetParametro As New e_DetalleAporteDescuento, olDetParametro As New l_DetalleAporteDescuento, leDetParametro As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private oeBonoProd As New e_BonificacionProduccion, olBonoProd As New l_BonificacionProduccion, leBonoProd As New List(Of e_BonificacionProduccion)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oeRegSalud As New e_RegimenSalud, olRegSalud As New l_RegimenSalud, leRegSalud As New List(Of e_RegimenSalud)
    Private oeGratificacion As New e_Gratificacion, olGratificacion As New l_Gratificacion
    Private oeUtilidad As New e_Utilidad, olUtilidad As New l_Utilidad
    Private oeDetalleUtilidad As New e_ConsolidadoUtilidad
    Private dsDatosGen As New Data.DataTable
    Private _opeR5ta As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griRetencionImpuesto.Rows.Count > 0 Then
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
                _opeR5ta = "GENERADA"
                oeRetencionQuinta = New e_RetencionQuinta
                oeRetencionQuinta.TipoOperacion = "I"
                oeRetencionQuinta.Activo = True
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                LlenarCombo(cboPlanilla, "Codigo", lePlanillaGen, -1)
                cboPlanilla.ReadOnly = False
                cboEstado.Text = "GENERADA"
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
                _opeR5ta = "GENERADA"
                Inicializa()
                LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
                Mostrar()
                oeRetencionQuinta.TipoOperacion = "A"
                SeleccionaTab(1)
                cboPlanilla.ReadOnly = True
                If oeRetencionQuinta.leDetalle.Count = 0 Then btnCargarDatos.Enabled = True
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
            Select Case _opeR5ta
                Case "GENERADA"
                    RecolectaDatos()
                    oeRetencionQuinta.UsuarioCreacion = gUsuarioSGI.Id
                    oeRetencionQuinta.PrefijoID = gs_PrefijoIdSucursal '@0001
                    olRetencionQuinta.Guardar(oeRetencionQuinta)
                    mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                Case "ENVIAR"
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeRetencionQuinta.IdEstado = cboEstado.Value
                        oeRetencionQuinta.UsuarioModifica = gUsuarioSGI.Id
                        oeRetencionQuinta.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olRetencionQuinta.Guardar(oeRetencionQuinta)
                        mensajeEmergente.Confirmacion("¡El Registro de Retención de 5ta Categoria Nº: " & oeRetencionQuinta.Codigo & _
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
                        oeRetencionQuinta.IdEstado = cboEstado.Value
                        oeRetencionQuinta.UsuarioModifica = gUsuarioSGI.Id
                        oeRetencionQuinta.PrefijoID = gs_PrefijoIdSucursal '@0001
                        olRetencionQuinta.Guardar(oeRetencionQuinta)
                        mensajeEmergente.Confirmacion("¡El Registro de Retención de 5ta Categoria Nº: " & oeRetencionQuinta.Codigo & _
                                                      " se Termino correctamente!", True)
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
                            oeRetencionQuinta = New e_RetencionQuinta
                            oeRetencionQuinta.TipoOperacion = "I"
                            oeRetencionQuinta.IdPlanilla = cboPlanillaImportar.Value
                            oeRetencionQuinta.Codigo = fn_ObtenerCodigo()
                            Dim _leEst = leEstado.Where(Function(it) it.Nombre = "PERDIDOS").ToList
                            If _leEst.Count > 0 Then oeRetencionQuinta.IdEstado = _leEst(0).Id
                            oeRetencionQuinta.Activo = True
                            oeRetencionQuinta.Glosa = "RENTA DE 5TA CATEGORIA  MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                            oeRetencionQuinta.UsuarioCreacion = gUsuarioSGI.Id
                            oeRetencionQuinta.Importe = leDetImportar.Sum(Function(it) it.Monto)
                            oeRetencionQuinta.leDetalle = _leAux
                            olRetencionQuinta.ImportarDatos(oeRetencionQuinta)
                            mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
                        End If
                    Else
                        Throw New Exception("No hay Registros Validados para Importar")
                    End If
            End Select
            SeleccionaTab(0)
            Consultar(True)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficRetencionQuinta.SelectedTab.Index
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
                If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeRetencionQuinta = New e_RetencionQuinta
                        oeRetencionQuinta.TipoOperacion = ""
                        oeRetencionQuinta.Id = griRetencionImpuesto.ActiveRow.Cells("Id").Value
                        oeRetencionQuinta = olRetencionQuinta.Obtener(oeRetencionQuinta)
                        oeRetencionQuinta.UsuarioModifica = gUsuarioSGI.Id
                        olRetencionQuinta.Eliminar(oeRetencionQuinta)
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oeRetencionQuinta.Codigo & _
                                                             " se ha Eliminado correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Else
                    Throw New Exception("No puede en ELIMINAR el Registro de Retención de 5ta Categoria Nº: " & _
                                        griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por no esta GENERADA.")
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
                Select Case ficRetencionQuinta.SelectedTab.Index
                    Case 0
                        If griRetencionImpuesto.Rows.Count > 0 Then
                            Exportar_Excel(griRetencionImpuesto, "Retenciion de 5ta Categoria")
                        Else
                            Throw New Exception("No hay Registros para Exportar")
                        End If
                    Case 1
                        If griDetalleRenta5.Rows.Count > 0 Then
                            Exportar_Excel(griDetalleRenta5, "Retenciion de 5ta Categoria")
                        Else
                            Throw New Exception("No hay Registros para Exportar")
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

    Private Sub frm_RetencionImpuesto5ta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficRetencionQuinta.SelectedTab.Index
            Case 0
                If griRetencionImpuesto.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 0, 0)
        End Select
    End Sub

    Private Sub frm_RetencionImpuesto5ta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_RetencionImpuesto5ta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            colorPerdido.Color = Color.LightGray
            colorGenerada.Color = Color.White
            colorEnviado.Color = Color.LightYellow
            colorTerminada.Color = Color.LightGreen
            CargarRetencionQuinta(New List(Of e_RetencionQuinta))
            CargarDetalleRenta5(New List(Of e_DetalleRentaQuinta))
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            SeleccionaTab(0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicioPla.Value = _oeplaaux.FechaInicio
                fecFinPla.Value = _oeplaaux.FechaFin
                If oeRetencionQuinta.TipoOperacion = "I" Then
                    Dim oeRI5 As New e_RetencionQuinta
                    oeRI5.TipoOperacion = ""
                    oeRI5.IdPlanilla = _oeplaaux.id
                    oeRI5.Activo = True
                    oeRI5 = olRetencionQuinta.Obtener(oeRI5)
                    If oeRI5.Id <> "" Then
                        btnCargarDatos.Enabled = False
                        cboPlanilla.SelectedIndex = -1
                        Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & _
                                            ", ya se encuentra Registrada en Nº: " & oeRI5.Codigo)
                    Else
                        btnCargarDatos.Enabled = True
                    End If
                    oePeriodo = New e_Periodo
                    oePeriodo.Equivale = 1
                    oePeriodo.Id = _oeplaaux.IdPeriodo
                    If lePeriodo.Contains(oePeriodo) Then
                        oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                        txtGlosa.Text = "RENTA DE 5TA CATEGORIA  MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                    End If
                Else
                    btnCargarDatos.Enabled = False
                End If
            Else
                fecInicioPla.Value = Date.Now.Date
                fecFinPla.Value = Date.Now.Date
                btnCargarDatos.Enabled = False
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            If leTrabajador.Count > 0 Then
                leTrabActivo = New List(Of e_Trabajador)
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                Dim _dFin = Date.Parse(gf_InicioFinMes("F", _oeplaaux.FechaFin.Year, _oeplaaux.FechaFin.Month))
                Dim _leTrabAct = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 _
                                                         And it.FechaIngreso <= _dFin).ToList
                leTrabActivo.AddRange(_leTrabAct)
                Dim _leTrabLiq = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 2 And it.IndTipo = 0 _
                                                         And it.FechaCese <> #1/1/1901# And it.FechaCese > _oeplaaux.FechaFin).ToList
                leTrabActivo.AddRange(_leTrabLiq)
                If leTrabActivo.Count > 0 Then
                    Dim _oeTrabAux As New e_Trabajador
                    _oeTrabAux.TipoOperacion = String.Empty : _oeTrabAux.Id = cboPlanilla.Value
                    dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
                    btnAgregarDatos.Text = "Agregar " & leTrabActivo.Count & " Registros"
                    btnAgregarDatos.Enabled = True : btnCargarDatos.Enabled = False
                Else
                    Throw New Exception("No se Encontraron Registros")
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarDatos_Click(sender As Object, e As EventArgs) Handles btnAgregarDatos.Click
        Try
            If MessageBox.Show("¿Desea Agregar los Registros?", "Mensaje de Sistema", _
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim nroreg As Integer = 0
                Dim _af = EjecutaFormula(gFAsignacionFamiliar, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _UITR7 = EjecutaFormula(gFUITRentaQuinta7, False, Nothing, leFormula, leParametro, leDetParametro)
                'Dim _UITR21 = EjecutaFormula(gFUITRentaQuinta21, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _UITR1 = EjecutaFormula(gFRT5R1, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _UITR2 = EjecutaFormula(gFRT5R2, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _UITR3 = EjecutaFormula(gFRT5R3, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _UITR4 = EjecutaFormula(gFRT5R4, False, Nothing, leFormula, leParametro, leDetParametro)
                Dim _pR1 = ValorParametro(gPPorcRT5R1, leParametro, leDetParametro)
                Dim _pR2 = ValorParametro(gPPorcRT5R2, leParametro, leDetParametro)
                Dim _pR3 = ValorParametro(gPPorcRT5R3, leParametro, leDetParametro)
                Dim _pR4 = ValorParametro(gPPorcRT5R4, leParametro, leDetParametro)
                Dim _pR5 = ValorParametro(gPPorcRT5R5, leParametro, leDetParametro)
                'Dim _psser = ObtieneValorParametro(gPPorcentajeEsSaludER)
                'Dim _psseps = ObtieneValorParametro(gPPorcentajeEsSaludEPS)
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeTrab In leTrabActivo.OrderBy(Function(it) it.oePersona.NombreCompleto).ToList
                    nroreg = nroreg + 1
                    etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & leTrabActivo.Count : etiEjecuta2.Refresh()
                    upbLoad2.Value = Math.Round(nroreg / leTrabActivo.Count, 2) * 100 : upbLoad2.Refresh()
                    oeDetalleRentaQuinta = New e_DetalleRentaQuinta
                    With oeDetalleRentaQuinta
                        .Calcular = True
                        .IdTrabajador = oeTrab.Id : .Trabajador = oeTrab.oePersona.NombreCompleto : .Dni = oeTrab.oePersona.Dni
                        .NroMes = oePeriodo.Mes : .DeduccionIUT = _UITR7
                        'oeDetalleRentaQuinta.MontoUIT27 = _UITR21
                        .PorcRango1 = _pR1 : .PorcRango2 = _pR2 : .PorcRango3 = _pR3 : .PorcRango4 = _pR4 : .PorcRango5 = _pR5
                        .UITRango1 = _UITR1 : .UITRango2 = _UITR2 : .UITRango3 = _UITR3 : .UITRango4 = _UITR4
                        If oeTrab.oeArea.Nombre <> gNombreAreaOperaciones Then .Administrativo = 1
                        oeSueldo = New e_SueldoTrabajador
                        oeSueldo.IdTrabajador = oeTrab.Id : oeSueldo.Equivale = 1
                        If leSueldo.Contains(oeSueldo) Then
                            oeSueldo = leSueldo.Item(leSueldo.IndexOf(oeSueldo))
                            .SueldoContratado = IIf(oeTrab.IndHijo = 1, oeSueldo.Sueldo + _af, oeSueldo.Sueldo)
                        End If
                        '.PorcSeg = _psser
                        .PorcSeg = 0
                        oeRegSalud = New e_RegimenSalud
                        oeRegSalud.IdTrabajador = oeTrab.Id : oeRegSalud.Equivale = 2
                        If leRegSalud.Contains(oeRegSalud) Then
                            oeRegSalud = leRegSalud.Item(leRegSalud.IndexOf(oeRegSalud))
                            'If oeRegSalud.IdPlanEPS.Trim <> String.Empty Then .PorcSeg = _psser - _psseps
                            If oeRegSalud.IdPlanEPS.Trim <> String.Empty Then .PorcSeg = 0
                        End If
                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeTrab.Id & "'", "")
                        If _rwAux.Count > 0 Then
                            Dim _dsFila = _rwAux.CopyToDataTable
                            .Sueldo = EjecutaFormula(gFPIRenumBasico, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .AsignacionFamiliar = EjecutaFormula(gFPIAsigFam, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .BonoProduccion = EjecutaFormula(gFPIBonoProd, False, _dsFila, leFormula, leParametro, leDetParametro)
                            'Dim _vuelcali = EjecutaFormula(gFPIVueltaCaliza, False, _dsFila, leFormula, leParametro, leDetParametro)
                            '.BonoProduccion = oeDetalleRentaQuinta.BonoProduccion + _vuelcali
                            .RenumeracionVacacional = EjecutaFormula(gFPIRenumVaca, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .CompensacionVacacional = EjecutaFormula(gFPICompenVac, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .BonoResponsabilidad = EjecutaFormula(gFPIBonoResp, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .DescansoMedico = EjecutaFormula(gFPIDescMed, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .HoraExtra25 = EjecutaFormula(gFPIHoraExt25, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .HoraExtra35 = EjecutaFormula(gFPIHoraExt35, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .VueltaAdicionalPiura = EjecutaFormula(gFPIVueltaPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .BonoCombustiblePiura = EjecutaFormula(gFPIBonoPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .BonoJefeConvoy = EjecutaFormula(gFPIConvoyPiura, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .VueltaAdicionalLima = EjecutaFormula(gFPIVueltaLima, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .Otros = EjecutaFormula(gFPIOtros, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .VueltaCaliza = EjecutaFormula(gFPIVueltaCaliza, False, _dsFila, leFormula, leParametro, leDetParametro)
                            '.Subsidio = EjecutaFormula(gFPISubsidio, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .HorasNocturnas = EjecutaFormula(gFPIHoraExtNoc, False, _dsFila, leFormula, leParametro, leDetParametro)
                            '.SubsidioMaternidad = EjecutaFormula(gFPISubMaternidad, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .Semaforo = EjecutaFormula(gFPISemaforo, False, _dsFila, leFormula, leParametro, leDetParametro)
                            .OtroInafecto = EjecutaFormula(gFPIOtroInafecto, False, _dsFila, leFormula, leParametro, leDetParametro)
                            ' Cargar Monto de Utilidad
                            If oePeriodo.Mes >= 3 Then
                                If oeUtilidad.Id.Trim <> String.Empty Then
                                    oeDetalleUtilidad = New e_ConsolidadoUtilidad
                                    oeDetalleUtilidad.IdTrabajador = oeTrab.Id : oeDetalleUtilidad.Equivale = 2
                                    If oeUtilidad.leConsolidado.Contains(oeDetalleUtilidad) Then
                                        oeDetalleUtilidad = oeUtilidad.leConsolidado.Item(oeUtilidad.leConsolidado.IndexOf(oeDetalleUtilidad))
                                        .Utilidad = oeDetalleUtilidad.UtilidadTotal
                                    End If
                                End If
                            End If
                            .TipoOperacion = "I" : .Activo = True : .UsuarioCreacion = gUsuarioSGI.Id
                            leDetalleRentaQuinta.Add(oeDetalleRentaQuinta)
                        Else
                            Throw New Exception("No hay Datos del Trabajador: " & oeTrab.oePersona.NombreCompleto)
                        End If
                    End With
                Next
                CargarDetalleRenta5(leDetalleRentaQuinta) : griDetalleRenta5.DataBind()
                btnAgregarDatos.Enabled = False : btnCargarSueldo.Enabled = True
                CargarSueldoMesActual()
                mensajeEmergente.Confirmacion("Se Agregaron " & leTrabActivo.Count & " registros", True)
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    'Private Sub btnCargarBono_Click(sender As Object, e As EventArgs) Handles btnCargarBono.Click
    '    Try
    '        If griDetalleRenta5.Rows.Count > 0 Then

    '            Espere1.Visible = True
    '            Application.DoEvents()
    '            Cursor.Current = Cursors.WaitCursor
    '            Cursor.Show()

    '            Dim _idPla As String = ""
    '            Dim _ctn As Integer = 0
    '            Dim _nro As Integer = 0
    '            If oePeriodo.Id <> "" Then _nro = oePeriodo.Mes - 1
    '            Dim _lePlaAux = lePlanilla.Where(Function(it) it.Tipo = 0).OrderByDescending(Function(it) it.Codigo).ToList
    '            For Each oeAux In _lePlaAux
    '                If _ctn >= 1 And _ctn <= _nro Then
    '                    _idPla = _idPla & "'" & oeAux.Id & "',"
    '                    _ctn = _ctn + 1
    '                End If
    '                If _ctn = 0 AndAlso oeAux.Id = cboPlanilla.Value Then
    '                    _idPla = _idPla & "'" & oeAux.Id & "',"
    '                    _ctn = 1
    '                End If
    '                If _ctn > _nro Then Exit For
    '            Next
    '            If _idPla.Trim.Length > 0 Then
    '                _idPla = _idPla.Substring(0, _idPla.Length - 1)
    '                oeBonoProd = New e_BonificacionProduccion
    '                oeBonoProd.IdPlanilla = _idPla
    '                oeBonoProd.TipoOperacion = "R"
    '                leBonoProd = olBonoProd.Listar(oeBonoProd)
    '                If leBonoProd.Count > 0 Then
    '                    LlenarProduccion(leBonoProd, _idPla)
    '                    CalculaBonoProyectado()
    '                Else
    '                    Throw New Exception("No hay Registros de Bonificaciones")
    '                End If
    '            Else
    '                Throw New Exception("No hay Registros de Planillas anterior a la actual")
    '            End If
    '            btnCargarBono.Enabled = False
    '            btnGratificacion.Enabled = True

    '            Espere1.Visible = False

    '        Else
    '            Throw New Exception("No hay Registros de Trabajadores en Retenciones")
    '        End If
    '    Catch ex As Exception
    '        Espere1.Visible = False
    '        mensajeEmergente.Problema(ex.Message, True)
    '    Finally
    '        Windows.Forms.Cursor.Current = Cursors.Default
    '        Cursor.Show()
    '        Espere1.Visible = False
    '    End Try
    'End Sub

    'Private Sub btnCondicion1_Click(sender As Object, e As EventArgs) Handles btnCondicion1.Click
    'Try
    '    Dim _uitR5 = EjecutaFormula(gFUITRentaQuinta, False, Nothing, leFormula, leParametro, leDetParametro)
    '    Dim _montoR5 = _uitR5 / 14
    '    If MessageBox.Show("Los Trabajadores que su Sueldo Bruto es mayor o igual que " & _montoR5 & _
    '                       " se efectura la Retencion de Quinta Categoria" & Environment.NewLine & _
    '                       "¿Desea Continuar con la Operacion?", _
    '                       "Mensaje de Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        For Each Fila In griDetalleRenta5.Rows
    '            Dim _sueldobruto = Fila.Cells("Basico" & oePeriodo.Mes).Value + Fila.Cells("Bono" & oePeriodo.Mes).Value
    '            If _sueldobruto >= _montoR5 Then
    '                oeDetalleRentaQuinta = New e_DetalleRentaQuinta
    '                oeDetalleRentaQuinta.Equivale = 2
    '                oeDetalleRentaQuinta.IdTrabajador = Fila.Cells("IdTrabajador").Value
    '                If leDetalleRentaQuinta.Contains(oeDetalleRentaQuinta) Then
    '                    oeDetalleRentaQuinta = leDetalleRentaQuinta.Item(leDetalleRentaQuinta.IndexOf(oeDetalleRentaQuinta))
    '                    oeDetalleRentaQuinta.IndRenta = True
    '                End If
    '            End If
    '        Next
    '        CargarDetalleRenta5(leDetalleRentaQuinta)
    '        griDetalleRenta5.DataBind()
    '        btnCondicion1.Enabled = False
    '        verCondicion.Enabled = True
    '        verCondicion.Checked = False
    '    End If
    'Catch ex As Exception
    '    mensajeEmergente.Problema(ex.Message, True)
    'End Try
    'End Sub

    Private Sub verCondicion_CheckedChanged(sender As Object, e As EventArgs) Handles verCondicion.CheckedChanged
        Try
            If verCondicion.Checked Then
                For Each oeRta In leDetalleRentaQuinta
                    If oeRta.RentaNetaAnual > 0 Then oeRta.IndRenta = True
                Next
            End If
            CargarDetalleRenta5(leDetalleRentaQuinta)
            HabilitarColum()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : etiEjecuta.Refresh()
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
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeDetalleRentaQuinta = New e_DetalleRentaQuinta
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2 : oeTrabajador.oePersona.Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                        If leTrabajador.Contains(oeTrabajador) Then oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        With oeDetalleRentaQuinta
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .Sueldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value, 2)
                            .AsignacionFamiliar = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 4).Value, 2)
                            .Renumeracion = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 5).Value, 2)
                            .Basico1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 6).Value, 2)
                            .Basico2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 7).Value, 2)
                            .Basico3 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 8).Value, 2)
                            .Basico4 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 9).Value, 2)
                            .Basico5 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 10).Value, 2)
                            .Basico6 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 11).Value, 2)
                            .Basico7 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 12).Value, 2)
                            .Basico8 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 13).Value, 2)
                            .Basico9 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 14).Value, 2)
                            .Basico10 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 15).Value, 2)
                            .Basico11 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 16).Value, 2)
                            .Basico12 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 17).Value, 2)
                            .TotalBasico = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 18).Value, 2)
                            .Utilidad = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 19).Value, 2)
                            .BasicoG1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 20).Value, 2)
                            .BonoExtG1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 21).Value, 2)
                            .HoraExtra25 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 22).Value, 2)
                            .HoraExtra35 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 23).Value, 2)
                            .Movilidad = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 24).Value, 2)
                            .BonoProduccion = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 25).Value, 2)
                            .RenumeracionVacacional = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 26).Value, 2)
                            .CompensacionVacacional = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 27).Value, 2)
                            .BonoResponsabilidad = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 28).Value, 2)
                            .DescansoMedico = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 29).Value, 2)
                            .RentaNeta27IUT2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 30).Value, 2)
                            .Diferencia = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 31).Value, 2)
                            .RentaQuinta15 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 32).Value, 2)
                            .RentaQuinta21 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 33).Value, 2)
                            .SueldoContratado = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 34).Value, 2)
                            .BasicoPendiente = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 35).Value, 2)
                            .Adicional = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 36).Value, 2)
                            .BasicoG2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 37).Value, 2)
                            .BonoExtG2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 38).Value, 2)
                            .RentaBrutaAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 39).Value, 2)
                            .DeduccionIUT = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 40).Value, 2)
                            .RentaNetaAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 41).Value, 2)
                            .Administrativo = objWorkSheet.Cells(ln_Fila + 1, 42).Value
                            .ImpuestoAnual = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 43).Value, 2)
                            .Retencion1 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 44).Value, 2)
                            .Retencion2 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 45).Value, 2)
                            .Retencion3 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 46).Value, 2)
                            .Retencion4 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 47).Value, 2)
                            .Retencion5 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 48).Value, 2)
                            .Retencion6 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 49).Value, 2)
                            .Retencion7 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 50).Value, 2)
                            .Retencion8 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 51).Value, 2)
                            .Retencion9 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 52).Value, 2)
                            .Retencion10 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 53).Value, 2)
                            .Retencion11 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 54).Value, 2)
                            .Retencion12 = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 55).Value, 2)
                            .TotalRetencion = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 56).Value, 2)
                            .RentaSaldo = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 57).Value, 2)
                            .Monto = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 58).Value, 2)
                            .Operacion = objWorkSheet.Cells(ln_Fila + 1, 59).Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        leDetImportar.Add(oeDetalleRentaQuinta)
                    Else
                        Exit For
                    End If
                Next
                CargarDetImportar(leDetImportar)
                griImportar.DataBind()
                If Not objXls Is Nothing Then
                    objWorkbook.Saved = True : objWorkbook.Close() : objXls.Quit()
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

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0
            Dim ls_msg As String = String.Empty
            If leDetImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                For Each oeAux In leDetImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetImportar.Count : etiEjecuta.Refresh()
                    upbLoad.Value = Math.Round(nroreg / leDetImportar.Count, 2) * 100 : upbLoad.Refresh()
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    If oeAux.IdTrabajador = "" Then
                        oeAux.Activo = False
                        oeTrabajador = New e_Trabajador
                        oeTrabajador.TipoBusca = 2
                        oeTrabajador.oePersona.Dni = oeAux.Dni
                        If leTrabajador.Contains(oeTrabajador) Then
                            Dim _leAux = leTrabajador.Where(Function(it) it.oePersona.Dni = oeTrabajador.oePersona.Dni).ToList
                            If _leAux.Count > 0 Then
                                oeTrabajador = _leAux(0)
                                oeAux.IdTrabajador = oeTrabajador.Id
                                oeAux.Activo = True
                            End If
                        End If
                    Else
                        oeAux.Activo = True
                    End If
                    If oeAux.IdTrabajador.Trim = String.Empty Then nrotrab = nrotrab + 1
                Next
                CargarDetImportar(leDetImportar)
                griImportar.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados."
            If ls_msg.Trim.Length > 0 Then
                'btnDatosExcluidos.Enabled = True
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

    Private Sub cboPlanillaImportar_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaImportar.ValueChanged
        Try
            If cboPlanillaImportar.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanillaImportar.Items(cboPlanillaImportar.SelectedIndex).ListObject
                fecInicioPI.Value = _oeplaaux.FechaInicio
                fecFinPI.Value = _oeplaaux.FechaFin
                Dim oeRI5 As New e_RetencionQuinta
                oeRI5.TipoOperacion = ""
                oeRI5.IdPlanilla = _oeplaaux.id
                oeRI5.Activo = True
                oeRI5 = olRetencionQuinta.Obtener(oeRI5)
                If oeRI5.Id <> "" Then
                    btnBuscar.Enabled = False
                    Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & _
                                        ", ya se encuentra Registrada en Nº: " & oeRI5.Codigo)
                Else
                    btnBuscar.Enabled = True
                End If
                oePeriodo = New e_Periodo
                oePeriodo.Equivale = 1
                oePeriodo.Id = _oeplaaux.IdPeriodo
                If lePeriodo.Contains(oePeriodo) Then
                    oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                End If
                leDetImportar = New List(Of e_DetalleRentaQuinta)
                CargarDetImportar(leDetImportar)
            Else
                fecInicioPI.Value = Date.Now.Date
                fecFinPI.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griRetencionImpuesto_DoubleClick(sender As Object, e As EventArgs) Handles griRetencionImpuesto.DoubleClick
        If griRetencionImpuesto.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnCargarRenta_Click(sender As Object, e As EventArgs) Handles btnCargarRenta.Click
        Try
            If griDetalleRenta5.Rows.Count > 0 Then
                If oePeriodo.Mes > 1 Then
                    etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                    upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                    Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                    Dim oeRenta As New e_RetencionQuinta
                    oeRenta.TipoOperacion = "" : oeRenta.Activo = True
                    leR5Historial = olRetencionQuinta.Listar(oeRenta)
                    If leR5Historial.Count > 0 Then
                        Dim _leR5H = leR5Historial.OrderByDescending(Function(it) it.Codigo).ToList
                        Dim _var As Integer = 0
                        Dim _idr5 As String = ""
                        For i = 0 To oePeriodo.Mes - 2
                            If _leR5H.Count >= (i + 1) Then
                                _idr5 = _idr5 & "'" & _leR5H(i).Id & "',"
                            Else
                                Exit For
                            End If
                        Next
                        If _idr5.Trim.Length > 0 Then
                            _idr5 = _idr5.Substring(0, _idr5.Length - 1)
                            oeDetalleRentaQuinta = New e_DetalleRentaQuinta
                            oeDetalleRentaQuinta.TipoOperacion = "R" : oeDetalleRentaQuinta.IdRetencionQuinta = _idr5
                            etiEjecuta2.Text = "Obteniendo Datos" : etiEjecuta2.Refresh()
                            leDetalleR5Historial = olDetalleRentaQuinta.Listar(oeDetalleRentaQuinta)
                            LlenarRentas(leDetalleR5Historial, _idr5)
                        End If
                    End If
                End If
                mensajeEmergente.Confirmacion("Se Procesaron " & griDetalleRenta5.Rows.Count & " registros", True)
                btnCargarRenta.Enabled = False : verCondicion.Enabled = True
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub verRenumeracion_CheckedChanged(sender As Object, e As EventArgs) Handles verRenumeracion.CheckedChanged
       HabilitarColum()
    End Sub

    Private Sub verBasico_CheckedChanged(sender As Object, e As EventArgs) Handles verBasico.CheckedChanged
       HabilitarColum()
    End Sub

    Private Sub verBono_CheckedChanged(sender As Object, e As EventArgs) Handles verBono.CheckedChanged
        HabilitarColum()
    End Sub

    Private Sub verRetencion_CheckedChanged(sender As Object, e As EventArgs) Handles verRetencion.CheckedChanged
        HabilitarColum()
    End Sub

    Private Sub verImpAnual_CheckedChanged(sender As Object, e As EventArgs) Handles verImpAnual.CheckedChanged
        HabilitarColum()
    End Sub

    Private Sub btnGratificacion_Click(sender As Object, e As EventArgs) Handles btnGratificacion.Click
        Try
            If griDetalleRenta5.Rows.Count > 0 Then
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                If oePeriodo.Mes <= 7 Then
                    If oePeriodo.Mes < 7 Then
                        CalcularGrati(oePeriodo.Mes, "1")
                    Else
                        ObtieneGrat(7, "1")
                    End If
                    CalcularGrati(oePeriodo.Mes, "2")
                Else
                    ObtieneGrat(7, "1")
                    If oePeriodo.Mes < 12 Then
                        CalcularGrati(oePeriodo.Mes, "2")
                    Else
                        ObtieneGrat(12, "2")
                    End If
                End If
                mensajeEmergente.Confirmacion("Se Procesaron " & griDetalleRenta5.Rows.Count & " registros", True)
                btnGratificacion.Enabled = False : btnPrestAlim.Enabled = True
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
             Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub btnCargarSueldo_Click(sender As Object, e As EventArgs) Handles btnCargarSueldo.Click
        Try
            If griDetalleRenta5.Rows.Count > 0 Then
                etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh() : etiEjecuta2.Visible = True
                upbLoad2.Minimum = 0 : upbLoad2.Maximum = 100 : upbLoad2.Value = 0 : upbLoad2.Refresh() : upbLoad2.Visible = True
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                Dim _idPla As String = ""
                Dim _ctn As Integer = 0, _nro As Integer = 0
                If oePeriodo.Id <> "" Then _nro = oePeriodo.Mes - 1
                Dim _lePlaAux = lePlanilla.Where(Function(it) it.Tipo = 0 And it.Activo = True).OrderByDescending(Function(it) it.Codigo).ToList
                For Each oeAux In _lePlaAux
                    If _ctn >= 1 And _ctn <= _nro Then
                        _idPla = _idPla & "'" & oeAux.Id & "'," : _ctn = _ctn + 1
                        etiEjecuta2.Text = "Buscando Planilla " & oeAux.Codigo : etiEjecuta2.Refresh()
                    End If
                    If _ctn = 0 AndAlso oeAux.Id = cboPlanilla.Value Then
                        _idPla = _idPla & "'" & oeAux.Id & "'," : _ctn = 1
                    End If
                    If _ctn > _nro Then Exit For
                Next
                If _idPla.Trim.Length > 0 Then
                    _idPla = _idPla.Substring(0, _idPla.Length - 1)
                    oeDetallePla = New e_DetallePlanilla
                    oeDetallePla.IdPlanilla = _idPla : oeDetallePla.TipoOperacion = "R"
                    etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh()
                    etiEjecuta2.Text = "Obteniendo Datos" : etiEjecuta2.Refresh()
                    leDetallePla = olDetallePla.Listar(oeDetallePla)
                    If leDetallePla.Count > 0 Then
                        LlenarBasico(leDetallePla, _idPla)
                    Else
                        If oePeriodo.Mes = 1 Then
                            LlenarBasico(leDetallePla, _idPla)
                        Else
                            Throw New Exception("No hay Registros de Sueldos")
                        End If
                    End If
                Else
                    Throw New Exception("No hay Registros de Planillas anterior a la actual")
                End If
                mensajeEmergente.Confirmacion("Se Procesaron " & griDetalleRenta5.Rows.Count & " registros", True)
                btnCargarSueldo.Enabled = False : btnGratificacion.Enabled = True
            Else
                Throw New Exception("No hay Registros de Trabajadores en Retenciones")
            End If
        Catch ex As Exception
            etiEjecuta2.Visible = False : upbLoad2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False : upbLoad2.Visible = False
        End Try
    End Sub

    Private Sub griDetalleRenta5_ClickCell(sender As Object, e As ClickCellEventArgs) Handles griDetalleRenta5.ClickCell
        Try
            With griDetalleRenta5
                If .ActiveRow.Index > -1 Then
                    If cboEstado.Text = "GENERADA" Then
                        If .ActiveRow.Cells("Administrativo").Value = 1 Then
                            Select Case .ActiveCell.Column.Key
                                Case "SueldoContratado"
                                    Dim _sueldoc As String
                                    _sueldoc = InputBox("Ingrese Monto de Sueldo Contratado:", "Mensaje de Sistema", .ActiveRow.Cells("SueldoContratado").Value)
                                    If Not IsNumeric(_sueldoc) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _sueldoc < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    .ActiveRow.Cells("SueldoContratado").Value = _sueldoc
                                    .ActiveRow.Cells("BasicoG1").Value = _sueldoc
                                    .ActiveRow.Cells("BasicoG2").Value = _sueldoc
                                    .ActiveRow.Cells("BasicoPendiente").Value = _sueldoc * (12 - oePeriodo.Mes)
                                    If oePlanilla.NroMes < 12 Then .ActiveRow.Cells("BasicoG2").Value = _sueldoc
                                    .UpdateData() : e.Cell.Row.Selected = True
                                Case "Basico1", "Basico2", "Basico3", "Basico4", "Basico5", "Basico6", "Basico7", "Basico8", "Basico9", "Basico10", "Basico11", "Basico12"
                                    Dim _keycol = .ActiveCell.Column.Key
                                    Dim _basicon As String
                                    _basicon = InputBox("Ingrese Monto de Sueldo Contratado:", "Mensaje de Sistema", .ActiveRow.Cells(_keycol).Value)
                                    If Not IsNumeric(_basicon) Then Throw New Exception("Solo se Permite Ingresar Números")
                                    If _basicon < 0 Then Throw New Exception("Debe Ingresar un Monto mayor a Cero")
                                    .ActiveRow.Cells(_keycol).Value = _basicon
                                    .UpdateData() : e.Cell.Row.Selected = True
                            End Select
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
            e.Cell.CancelUpdate()
        End Try
    End Sub

    Private Sub btnPrestAlim_Click(sender As Object, e As EventArgs) Handles btnPrestAlim.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta2.Visible = True : etiEjecuta2.Text = String.Empty
                Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
                PathFilePTRA = OpenFileDialog1.FileName
                Dim objXls As Excel.Application
                Dim objWorkbook As Excel.Workbook
                Dim objWorkSheet As Excel.Worksheet
                Dim ObjExcel() As Object = Nothing
                Dim men As String = ""
                objXls = CreateObject("Excel.Application")
                objWorkbook = objXls.Workbooks.Open(PathFilePTRA)
                objXls.Visible = False
                objWorkSheet = objXls.Worksheets(1)
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 1).Value Is Nothing) Then
                        etiEjecuta2.Text = "Procesando " & ln_Fila & " registros ... "
                        For Each Fil In griDetalleRenta5.Rows
                            If Fil.Cells("Dni").Value = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value) Then
                                Fil.Cells("Adicional").Value = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 3).Value)
                                Exit For
                            End If
                        Next
                    Else
                        Exit For
                    End If
                Next
                griDetalleRenta5.UpdateData() : griDetalleRenta5.DataBind()
                'ndImporte.Value = leDetProdPiloto.Where(Function(it) it.Activo = True).Sum(Function(it) it.NetoBonoProduccion)
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
            mensajeEmergente.Confirmacion("Se han Procesado con exito registros", True)
            btnPrestAlim.Enabled = False : btnCargarRenta.Enabled = True
        Catch ex As Exception
            etiEjecuta2.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : etiEjecuta2.Visible = False
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try

            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = "" : oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)

            oeEstado = New e_Estado
            oeEstado.Nombre = "RETENCION 5TA"
            leEstado = olEstado.Listar(oeEstado)

            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            Dim _leEstaAux As New List(Of e_Estado)
            oeEstado = New e_Estado
            oeEstado.Id = "" : oeEstado.Nombre = " [TODOS] "
            _leEstaAux.Add(oeEstado)
            _leEstaAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstaAux, 0)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)

            lePlanillaGen = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList
            LlenarCombo(cboPlanillaImportar, "Codigo", lePlanilla, -1)

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

            oeUtilidad = New e_Utilidad
            oeUtilidad.TipoOperacion = "R" : oeUtilidad.Activo = True
            oeUtilidad = olUtilidad.Obtener(oeUtilidad)

            oeRegSalud = New e_RegimenSalud
            oeRegSalud.TipoOperacion = String.Empty : oeRegSalud.Vigente = 1
            leRegSalud = olRegSalud.Listar(oeRegSalud)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarRetencionQuinta(leRenta5 As List(Of e_RetencionQuinta))
        Try
            With griRetencionImpuesto
                .ResetDisplayLayout()
                .Text = "LISTADO DE RETENCIÓN DE QUINTA CATEGORIA"
                .DataSource = leRenta5.OrderByDescending(Function(it) it.Codigo).ToList
                OcultarColumna(griRetencionImpuesto, True, "Id", "IdPlanilla", "IdEstado", "FechaCreacion", "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griRetencionImpuesto, "Id", "Activo", "IdPlanilla", "IdEstado")
                FormatoColumna(griRetencionImpuesto, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Planilla").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Glosa").Width = 400
                '.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(griRetencionImpuesto, "Importe")
                If .Rows.Count > 0 Then
                    For Each Fila As UltraGridRow In .Rows
                        Select Case Fila.Cells("Estado").Value
                            Case "PERDIDOS" : Fila.Appearance.BackColor = colorPerdido.Color
                            Case "GENERADA" : Fila.Appearance.BackColor = colorGenerada.Color
                            Case "ENVIADO" : Fila.Appearance.BackColor = colorEnviado.Color
                            Case "TERMINADA" : Fila.Appearance.BackColor = colorTerminada.Color
                        End Select
                    Next
                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oeRetencionQuinta = New e_RetencionQuinta
            oeRetencionQuinta.TipoOperacion = ""
            oeRetencionQuinta.Activo = True
            'oeRentencionQuinta.IdPlanilla = cboPlanillaBus.Value
            oeRetencionQuinta.IdEstado = cboEstadoBus.Value
            leRetencionQuinta = olRetencionQuinta.Listar(oeRetencionQuinta)
            CargarRetencionQuinta(leRetencionQuinta)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        cboEstado.SelectedIndex = -1
        cboPlanilla.SelectedIndex = -1
        ndMonto.Value = 0
        ndMonto.ReadOnly = True
        txtGlosa.Text = String.Empty
        btnCargarDatos.Enabled = False
        btnAgregarDatos.Enabled = False
        btnCargarSueldo.Enabled = False
        btnGratificacion.Enabled = False
        btnPrestAlim.Enabled = False
        btnCargarRenta.Enabled = False
        verCondicion.Enabled = False
        verCondicion.Checked = False
        oePeriodo = New e_Periodo
        leTrabActivo = New List(Of e_Trabajador)
        leR5Historial = New List(Of e_RetencionQuinta)
        leDetalleR5Historial = New List(Of e_DetalleRentaQuinta)
        leDetalleRentaQuinta = New List(Of e_DetalleRentaQuinta)
        CargarDetalleRenta5(leDetalleRentaQuinta)
        verRenumeracion.Checked = True
        verBasico.Checked = True
        verBono.Checked = True
        verRetencion.Checked = True
        verImpAnual.Checked = True
    End Sub

    Private Sub Mostrar()
        Try
            oeRetencionQuinta = New e_RetencionQuinta
            oeRetencionQuinta.TipoOperacion = ""
            oeRetencionQuinta.Id = griRetencionImpuesto.ActiveRow.Cells("Id").Value
            oeRetencionQuinta = olRetencionQuinta.Obtener(oeRetencionQuinta)
            With oeRetencionQuinta
                txtCodigo.Text = .Codigo
                cboEstado.Value = .IdEstado
                cboPlanilla.Value = .IdPlanilla
                txtGlosa.Text = .Glosa
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicioPla.Value = _oeplaaux.FechaInicio
                fecFinPla.Value = _oeplaaux.FechaFin
                oePeriodo = New e_Periodo
                oePeriodo.Equivale = 1
                oePeriodo.Id = _oeplaaux.IdPeriodo
                If lePeriodo.Contains(oePeriodo) Then
                    oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                    For Each _oeaux In .leDetalle
                        _oeaux.NroMes = oePeriodo.Mes
                    Next
                End If
                leDetalleRentaQuinta = .leDetalle
                ndMonto.Value = .Importe
                CargarDetalleRenta5(leDetalleRentaQuinta)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim str As String = ""
            Dim oeRI5 As New e_RetencionQuinta
            oeRI5.TipoOperacion = "U"
            oeRI5 = olRetencionQuinta.Obtener(oeRI5)
            If oeRI5 IsNot Nothing AndAlso oeRI5.Codigo <> "" Then
                str = oeRI5.Codigo
            End If
            Return str
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarDetalleRenta5(leDetRenta5 As List(Of e_DetalleRentaQuinta))
        Try
            With griDetalleRenta5
                .ResetDisplayLayout()
                .Text = "LISTADO DEL PERIODO " & oePeriodo.Codigo
                If verCondicion.Checked Then
                    Dim _leDetC1 = leDetRenta5.Where(Function(it) it.IndRenta = True).ToList
                    .DataSource = _leDetC1
                    ndMonto.Value = _leDetC1.Sum(Function(it) it.Monto)
                Else
                    .DataSource = leDetRenta5
                    ndMonto.Value = leDetRenta5.Sum(Function(it) it.Monto)
                End If
                ConfiguraGrilla(griDetalleRenta5, 1)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarDetImportar(leImportar As List(Of e_DetalleRentaQuinta))
        Try
            With griImportar
                .ResetDisplayLayout()
                .DataSource = leImportar
                .Text = "REGISTROS PARA IMPORTAR (" & leImportar.Count & ")"
                ConfiguraGrilla(griImportar, 2)
                If leImportar.Count > 0 Then btnVerificar.Enabled = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ConfiguraGrilla(Grilla As UltraGrid, tipo As Integer)
        Try
            Dim i As Integer = 0, _limite As Integer = 0, _ncol As Integer = 0
            With Grilla
                OcultarColumna(Grilla, True, "Id", "IdRetencionQuinta", "IdTrabajador", "FechaCreacion", "UsuarioCreacion", _
                               "UsuarioModifica", "FechaModifica", "Activo", "Operacion", "RentaNeta27IUT2", "Diferencia", "RentaQuinta15", "RentaQuinta21")
                ExcluirColumna(Grilla, "Activo", "IdRetencionQuinta", "IdTrabajador")
                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 0 : .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("SueldoContratado").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Administrativo").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Sueldo").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("HoraExtra25").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("HoraExtra35").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("Movilidad").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("BonoProduccion").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("RenumeracionVacacional").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("CompensacionVacacional").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("BonoResponsabilidad").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("DescansoMedico").Header.VisiblePosition = 13

                .DisplayLayout.Bands(0).Columns("VueltaAdicionalPiura").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("BonoCombustiblePiura").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("BonoJefeConvoy").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("VueltaAdicionalLima").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("Otros").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("VueltaCaliza").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("HorasNocturnas").Header.VisiblePosition = 20
                .DisplayLayout.Bands(0).Columns("Semaforo").Header.VisiblePosition = 21
                .DisplayLayout.Bands(0).Columns("OtroInafecto").Header.VisiblePosition = 21

                .DisplayLayout.Bands(0).Columns("Renumeracion").Header.VisiblePosition = 22
                .DisplayLayout.Bands(0).Columns("Basico1").Header.VisiblePosition = 23 : .DisplayLayout.Bands(0).Columns("Basico2").Header.VisiblePosition = 24
                .DisplayLayout.Bands(0).Columns("Basico3").Header.VisiblePosition = 25 : .DisplayLayout.Bands(0).Columns("Basico4").Header.VisiblePosition = 26
                .DisplayLayout.Bands(0).Columns("Basico5").Header.VisiblePosition = 27 : .DisplayLayout.Bands(0).Columns("Basico6").Header.VisiblePosition = 28
                .DisplayLayout.Bands(0).Columns("Basico7").Header.VisiblePosition = 29 : .DisplayLayout.Bands(0).Columns("Basico8").Header.VisiblePosition = 30
                .DisplayLayout.Bands(0).Columns("Basico9").Header.VisiblePosition = 31 : .DisplayLayout.Bands(0).Columns("Basico10").Header.VisiblePosition = 32
                .DisplayLayout.Bands(0).Columns("Basico11").Header.VisiblePosition = 33 : .DisplayLayout.Bands(0).Columns("Basico12").Header.VisiblePosition = 34
                .DisplayLayout.Bands(0).Columns("TotalBasico").Header.VisiblePosition = 35
                .DisplayLayout.Bands(0).Columns("BasicoPendiente").Header.VisiblePosition = 36
                .DisplayLayout.Bands(0).Columns("Utilidad").Header.VisiblePosition = 37
                .DisplayLayout.Bands(0).Columns("BasicoG1").Header.VisiblePosition = 38 : .DisplayLayout.Bands(0).Columns("BonoExtG1").Header.VisiblePosition = 39
                .DisplayLayout.Bands(0).Columns("BasicoG2").Header.VisiblePosition = 40 : .DisplayLayout.Bands(0).Columns("BonoExtG2").Header.VisiblePosition = 41
                .DisplayLayout.Bands(0).Columns("Adicional").Header.VisiblePosition = 42
                .DisplayLayout.Bands(0).Columns("RentaBrutaAnual").Header.VisiblePosition = 43
                .DisplayLayout.Bands(0).Columns("DeduccionIUT").Header.VisiblePosition = 44
                .DisplayLayout.Bands(0).Columns("RentaNetaAnual").Header.VisiblePosition = 45
                .DisplayLayout.Bands(0).Columns("Rango1").Header.VisiblePosition = 46 : .DisplayLayout.Bands(0).Columns("Rango2").Header.VisiblePosition = 47
                .DisplayLayout.Bands(0).Columns("Rango3").Header.VisiblePosition = 48 : .DisplayLayout.Bands(0).Columns("Rango4").Header.VisiblePosition = 49
                .DisplayLayout.Bands(0).Columns("Rango5").Header.VisiblePosition = 50
                .DisplayLayout.Bands(0).Columns("ImpuestoAnual").Header.VisiblePosition = 51
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250 : .DisplayLayout.Bands(0).Columns("Dni").Width = 70
                .DisplayLayout.Bands(0).Columns("Administrativo").Width = 30 : .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Width = 70
                .DisplayLayout.Bands(0).Columns("SueldoContratado").Header.Caption = "Sueldo"
                .DisplayLayout.Bands(0).Columns("Administrativo").Header.Caption = "Adm."
                .DisplayLayout.Bands(0).Columns("Sueldo").Header.Caption = "Renum."
                .DisplayLayout.Bands(0).Columns("HoraExtra25").Header.Caption = "H.E.25%"
                .DisplayLayout.Bands(0).Columns("HoraExtra35").Header.Caption = "H.E.35%"
                .DisplayLayout.Bands(0).Columns("Movilidad").Header.Caption = "Movi."
                .DisplayLayout.Bands(0).Columns("BonoProduccion").Header.Caption = "Bono Prod."
                .DisplayLayout.Bands(0).Columns("RenumeracionVacacional").Header.Caption = "Ren. Vac."
                .DisplayLayout.Bands(0).Columns("CompensacionVacacional").Header.Caption = "Comp. Vac."
                .DisplayLayout.Bands(0).Columns("BonoResponsabilidad").Header.Caption = "Bono Resp."
                .DisplayLayout.Bands(0).Columns("DescansoMedico").Header.Caption = "Desc. Med."
                .DisplayLayout.Bands(0).Columns("Renumeracion").Header.Caption = "Ingreso Bruto"
                .DisplayLayout.Bands(0).Columns("AsignacionFamiliar").Header.Caption = "Asig. Fam."
                .DisplayLayout.Bands(0).Columns("Rango1").Header.Caption = "Tasa(8%)" : .DisplayLayout.Bands(0).Columns("Rango2").Header.Caption = "Tasa(14%)"
                .DisplayLayout.Bands(0).Columns("Rango3").Header.Caption = "Tasa(17%)" : .DisplayLayout.Bands(0).Columns("Rango4").Header.Caption = "Tasa(20%)"
                .DisplayLayout.Bands(0).Columns("Rango5").Header.Caption = "Tasa(30%)"
                ColorFondoColumna(Grilla, Color.Moccasin, "Trabajador", "Dni", "SueldoContratado", "Administrativo")
                ColorFondoColumna(Grilla, Color.LightCyan, "Sueldo", "AsignacionFamiliar", "Basico1", "Basico2", "Basico3" _
                                  , "Basico4", "Basico5", "Basico6", "Basico7", "Basico8", "Basico9", "Basico10", "Basico11", "Basico12" _
                                  , "HoraExtra25", "HoraExtra35", "Movilidad", "BonoProduccion", "RenumeracionVacacional", "CompensacionVacacional" _
                                  , "BonoResponsabilidad", "DescansoMedico", "VueltaAdicionalPiura", "BonoCombustiblePiura", "BonoJefeConvoy" _
                                  , "VueltaAdicionalLima", "Otros", "VueltaCaliza", "HorasNocturnas", "Semaforo", "RentaNeta27IUT2", "Diferencia" _
                                  , "RentaQuinta15", "OtroInafecto", "RentaQuinta21" _
                                  , "Retencion1", "Retencion2", "Retencion3", "Retencion4", "Retencion5", "Retencion6", "Retencion7" _
                                  , "Retencion8", "Retencion9", "Retencion10", "Retencion11", "Retencion12")
                ColorFondoColumna(Grilla, Color.LightSkyBlue, "Renumeracion", "TotalBasico", "TotalBono", "TotalRetencion", "Utilidad", "BasicoPendiente" _
                                  , "BasicoG1", "BonoExtG1", "BasicoG2", "BonoExtG2", "DeduccionIUT", "RentaNetaAnual", "RentaNeta27IUT2", "Diferencia" _
                                  , "RentaQuinta15", "RentaQuinta21", "Rango1", "Rango2", "Rango3", "Rango4", "Rango5")
                ColorFondoColumna(Grilla, Color.Navy, "Monto", "RentaBrutaAnual", "ImpuestoAnual")
                .DisplayLayout.Bands(0).Columns("Monto").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("RentaBrutaAnual").CellAppearance.ForeColor = Color.White
                .DisplayLayout.Bands(0).Columns("ImpuestoAnual").CellAppearance.ForeColor = Color.White
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Sueldo", "AsignacionFamiliar", "Renumeracion" _
                               , "Basico1", "Basico2", "Basico3", "Basico4", "Basico5", "Basico6", "Basico7", "Basico8", "Basico9", "Basico10" _
                               , "Basico11", "Basico12", "TotalBasico", "Utilidad", "BasicoG1", "BonoExtG1", "HoraExtra25", "HoraExtra35", "Movilidad" _
                               , "BonoProduccion", "RenumeracionVacacional", "CompensacionVacacional", "BonoResponsabilidad", "DescansoMedico" _
                               , "VueltaAdicionalPiura", "BonoCombustiblePiura", "BonoJefeConvoy", "VueltaAdicionalLima", "Otros", "VueltaCaliza" _
                               , "HorasNocturnas", "Semaforo", "OtroInafecto", "RentaNeta27IUT2" _
                               , "Diferencia", "RentaQuinta15", "RentaQuinta21", "SueldoContratado", "BasicoPendiente" _
                               , "BonoPendiente", "BasicoG2", "BonoExtG2", "RentaBrutaAnual", "DeduccionIUT", "RentaNetaAnual", "ImpuestoAnual" _
                               , "Retencion1", "Retencion2", "Retencion3", "Retencion4", "Retencion5", "Retencion6", "Retencion7", "Retencion8" _
                               , "Retencion9", "Retencion10", "Retencion11", "Retencion12", "TotalRetencion", "RentaSaldo", "Monto", "Adicional" _
                               , "Rango1", "Rango2", "Rango3", "Rango4", "Rango5")
                FormatoColumna(Grilla, "", ColumnStyle.CheckBox, HAlign.Center, "Administrativo")
                CongelaColumna(Grilla, "Dni", "Trabajador", "SueldoContratado", "Administrativo")
                _limite = 12 - oePeriodo.Mes
                For i = 0 To (_limite - 1)
                    _ncol = 12 - i
                    .DisplayLayout.Bands(0).Columns("Basico" & _ncol).Hidden = True : .DisplayLayout.Bands(0).Columns("Retencion" & _ncol).Hidden = True
                Next
                If i < 11 Then .DisplayLayout.Bands(0).Columns("Retencion" & (12 - i)).Hidden = True
                If tipo = 2 Then
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = False : .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                End If
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
                CalcularTotales(Grilla, "Monto")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RecolectaDatos()
        oeRetencionQuinta.Codigo = txtCodigo.Text
        oeRetencionQuinta.Importe = ndMonto.Value
        oeRetencionQuinta.IdEstado = cboEstado.Value
        oeRetencionQuinta.IdPlanilla = cboPlanilla.Value
        oeRetencionQuinta.Glosa = txtGlosa.Text
        oeRetencionQuinta.leDetalle = leDetalleRentaQuinta.Where(Function(it) it.IndRenta = True).ToList
    End Sub

    Private Sub LlenarBasico(leDPB As List(Of e_DetallePlanilla), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leDPBAux As New List(Of e_DetallePlanilla)
            Dim nroreg As Integer = 0, _mes As Integer = 0, i As Integer = 0, _div As Integer = 0
            Dim _sueldoaux As Double = 0
            For i = 0 To idpla.Count - 1
                Dim _le = leDPB.Where(Function(it) "'" & it.IdPlanilla & "'" = idpla(i)).ToList
                _mes = idpla.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh()
            For Each fil In griDetalleRenta5.Rows
                nroreg = nroreg + 1 : _div = 0 : _sueldoaux = 0
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & griDetalleRenta5.Rows.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / griDetalleRenta5.Rows.Count, 2) * 100 : upbLoad2.Refresh()
                _leDPBAux = leDPB.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                For Each _aux In _leDPBAux
                    If _aux.NroMes <> oePeriodo.Mes Then fil.Cells("Basico" & _aux.NroMes.ToString).Value = _aux.Ingresos ': _div = _div + 1
                    If (_aux.NroMes = oePeriodo.Mes - 1) Or (_aux.NroMes = oePeriodo.Mes - 2) Then _div = _div + 1
                Next
                If _div < 2 Then
                    'If _div = 0 Then
                    'If fil.Cells("Administrativo").Value = 0 Then
                    If fil.Cells("Dni").Value = "16677101" Then
                        _sueldoaux = fil.Cells("SueldoContratado").Value + 800
                    Else
                        _sueldoaux = fil.Cells("SueldoContratado").Value
                    End If
                    'Else
                    ' _sueldoaux = IIf(fil.Cells("SueldoContratado").Value > fil.Cells("Renumeracion").Value, fil.Cells("SueldoContratado").Value, fil.Cells("Renumeracion").Value)
                    'End If
                Else
                    If fil.Cells("Administrativo").Value = 1 Then
                        _sueldoaux = fil.Cells("SueldoContratado").Value '+ fil.Cells("SueldoContratado").Value
                    Else
                        '_sueldoaux = fil.Cells("TotalBasico").Value / (_div + 1)
                        If oePeriodo.Mes > 2 Then
                            _sueldoaux = (fil.Cells("Basico" & (oePeriodo.Mes - 2)).Value + fil.Cells("Basico" & (oePeriodo.Mes - 1)).Value + fil.Cells("Basico" & (oePeriodo.Mes)).Value) / 3
                        Else
                            _sueldoaux = fil.Cells("SueldoContratado").Value
                        End If
                    End If
                End If
                fil.Cells("BasicoPendiente").Value = _sueldoaux * (12 - oePeriodo.Mes)
            Next
            griDetalleRenta5.DataBind() : griDetalleRenta5.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarProduccion(leBPR As List(Of e_BonificacionProduccion), cad As String)
        Try
            Dim idpla() As String = cad.Split(",")
            Dim _leBPAux As New List(Of e_BonificacionProduccion)
            Dim _mes As Integer = 0
            Dim i As Integer = 0
            For i = 0 To idpla.Count - 1
                Dim _le = leBPR.Where(Function(it) "'" & it.IdPlanilla & "'" = idpla(i)).ToList
                _mes = idpla.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            For Each fil In griDetalleRenta5.Rows
                _leBPAux = leBPR.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                For Each _aux In _leBPAux
                    fil.Cells("Bono" & _aux.NroMes.ToString).Value = _aux.MontoPlanilla
                    If _aux.NroMes <> oePeriodo.Mes Then fil.Cells("Basico" & _aux.NroMes.ToString).Value = fil.Cells("Basico" & _aux.NroMes.ToString).Value - _aux.MontoPlanilla
                Next
            Next
            griDetalleRenta5.DataBind()
            griDetalleRenta5.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarRentas(leR5H As List(Of e_DetalleRentaQuinta), cad As String)
        Try
            Dim idr5() As String = cad.Split(",")
            Dim _leR5HAux As New List(Of e_DetalleRentaQuinta)
            Dim nroreg As Integer = 0, _mes As Integer = 0, i As Integer = 0
            For i = 0 To idr5.Count - 1
                Dim _le = leR5H.Where(Function(it) "'" & it.IdRetencionQuinta & "'" = idr5(i)).ToList
                _mes = idr5.Count - i
                For Each _oeaux In _le
                    _oeaux.NroMes = _mes
                Next
            Next
            etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh()
            For Each fil In griDetalleRenta5.Rows
                nroreg = nroreg + 1
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & griDetalleRenta5.Rows.Count : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / griDetalleRenta5.Rows.Count, 2) * 100 : upbLoad2.Refresh()
                _leR5HAux = leR5H.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                For Each _aux In _leR5HAux
                    fil.Cells("Retencion" & _aux.NroMes.ToString).Value = _aux.Monto
                Next
            Next
            griDetalleRenta5.DataBind() : griDetalleRenta5.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSueldoMesActual()
        Try
            If griDetalleRenta5.Rows.Count > 0 Then
                For Each Fila In griDetalleRenta5.Rows
                    Fila.Cells("Basico" & oePeriodo.Mes).Value = Fila.Cells("Renumeracion").Value
                Next
            End If
            griDetalleRenta5.UpdateData()
            griDetalleRenta5.DataBind()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SeleccionaTab(_index As Integer)
        ficRetencionQuinta.Tabs(0).Enabled = False
        ficRetencionQuinta.Tabs(1).Enabled = False
        ficRetencionQuinta.Tabs(2).Enabled = False
        ficRetencionQuinta.Tabs(_index).Enabled = True
        ficRetencionQuinta.Tabs(_index).Selected = True
    End Sub

    Private Sub CalculaBonoProyectado()
        Try
            If griDetalleRenta5.Rows.Count > 0 Then
                Dim _mesproy = oePeriodo.Mes
                Dim _subbono As Double
                For Each fil In griDetalleRenta5.Rows
                    _subbono = 0
                    _subbono = fil.Cells("Bono" & (_mesproy).ToString).Value + fil.Cells("Bono" & (_mesproy - 1).ToString).Value + fil.Cells("Bono" & (_mesproy - 2).ToString).Value
                    fil.Cells("BonoPendiente").Value = (_subbono / 3) * (12 - _mesproy)
                Next
                griDetalleRenta5.DataBind()
                griDetalleRenta5.UpdateData()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado AndAlso griRetencionImpuesto.ActiveRow.Cells("Importe").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opeR5ta = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Retencion de 5ta Categoria" & Environment.NewLine & _
                                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
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
                If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado Then
                    Dim formulario As frm_AutenticarTrabajador
                    formulario = New frm_AutenticarTrabajador
                    formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                        Throw New Exception("Ingrese un Clave Correcta")
                    Else
                        oeRetencionQuinta = New e_RetencionQuinta
                        oeRetencionQuinta.TipoOperacion = ""
                        oeRetencionQuinta.Id = griRetencionImpuesto.ActiveRow.Cells("Id").Value
                        oeRetencionQuinta = olRetencionQuinta.Obtener(oeRetencionQuinta)
                        oeRetencionQuinta.TipoOperacion = "A"
                        _estado = gNombreEstadoGenerada
                        Dim _leEst = leEstado.Where(Function(it) it.Nombre = _estado).ToList
                        If _leEst.Count > 0 Then
                            oeRetencionQuinta.IdEstado = _leEst(0).Id
                            oeRetencionQuinta.UsuarioModifica = gUsuarioSGI.Id
                            oeRetencionQuinta.PrefijoID = gs_PrefijoIdSucursal '@0001
                            olRetencionQuinta.Guardar(oeRetencionQuinta)
                            mensajeEmergente.Confirmacion("¡El Registro de Retención de 5ta Categoria Nº: " & oeRetencionQuinta.Codigo & _
                                                          " se Extornado correctamente!", True)
                            SeleccionaTab(0)
                            Consultar(True)
                        End If
                    End If
                Else
                    Throw New Exception("No se puede EXTORNAR el Registro de Renta de 5ta Categoria" & Environment.NewLine & _
                                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO")
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
                If griRetencionImpuesto.ActiveRow.Cells("Estado").Value = _estado Then
                    Editar()
                    _estado = gNombreEstadoTerminada.ToString
                    cboEstado.Text = _estado
                    _opeR5ta = "TERMINAR"
                Else
                    Throw New Exception("No puede TERMINAR el Registro de Retención de 5ta Categoria" & Environment.NewLine & _
                                        "Nº: " & griRetencionImpuesto.ActiveRow.Cells("Codigo").Value & " por que no esta ENVIADO.")
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Importar()
        Try
            _acl = gAccionSistema.IMPORTAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _opeR5ta = "IMPORTAR"
                SeleccionaTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                fecInicioPI.Value = Date.Now.Date
                fecFinPI.Value = Date.Now.Date
                cboPlanillaImportar.SelectedIndex = -1
                oePeriodo = New e_Periodo
                leDetImportar = New List(Of e_DetalleRentaQuinta)
                CargarDetImportar(leDetImportar)
                btnBuscar.Enabled = False
                btnVerificar.Enabled = False
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
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

    Private Sub CalcularGrati(_Mes As Integer, _ind As String)
        Try
            Dim nroreg As Integer = 0, _div As Integer = 0
            Dim _grati As Double = 0, _proc As Double = 0
            '_pext = ObtieneValorParametro("PORC_ESR")
            etiEjecuta2.Text = String.Empty : etiEjecuta2.Refresh()
            upbLoad2.Value = 0 : upbLoad2.Refresh()
            For Each fil In griDetalleRenta5.Rows
                nroreg = nroreg + 1 : _div = 0
                etiEjecuta2.Text = "Procesando Registro " & nroreg & " de " & griDetalleRenta5.Rows.Count & " ..." : etiEjecuta2.Refresh()
                upbLoad2.Value = Math.Round(nroreg / griDetalleRenta5.Rows.Count, 2) * 100 : upbLoad2.Refresh()
                For x = 1 To oePeriodo.Mes
                    If fil.Cells("Basico" & x).Value > 0 Then _div = _div + 1
                Next
                If _div = 1 Then
                    _grati = IIf(fil.Cells("SueldoContratado").Value > fil.Cells("Renumeracion").Value, fil.Cells("SueldoContratado").Value, fil.Cells("Renumeracion").Value)
                Else
                    If fil.Cells("Administrativo").Value = 1 Then
                        _grati = fil.Cells("SueldoContratado").Value '+ fil.Cells("SueldoContratado").Value
                    Else
                        If oePeriodo.Mes > 2 Then
                            _grati = (fil.Cells("Basico" & (oePeriodo.Mes - 2)).Value + fil.Cells("Basico" & (oePeriodo.Mes - 1)).Value + fil.Cells("Basico" & (oePeriodo.Mes)).Value) / 3
                        Else
                            _grati = fil.Cells("SueldoContratado").Value
                        End If
                    End If
                End If
                fil.Cells("BasicoG" & _ind).Value = _grati
                'fil.Cells("BonoExtG" & _ind).Value = _grati * (_pext / 100)
            Next
            griDetalleRenta5.DataBind() : griDetalleRenta5.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ObtieneGrat(_Mes As Integer, _ind As String)
        Try
            Dim _lePer = lePeriodo.Where(Function(it) it.Ejercicio = oePeriodo.Ejercicio And it.Mes = _Mes).ToList
            If _lePer.Count > 0 Then
                Dim _oePer = _lePer(0)
                oeGratificacion = New e_Gratificacion
                oeGratificacion.TipoOperacion = ""
                oeGratificacion.Activo = True
                oeGratificacion.IdPeriodo = _oePer.Id
                oeGratificacion = olGratificacion.Obtener(oeGratificacion)
                If oeGratificacion.Id.Trim <> String.Empty Then
                    If oeGratificacion.leDetalle.Count > 0 Then
                        For Each fil In griDetalleRenta5.Rows
                            Dim _leDG = oeGratificacion.leDetalle.Where(Function(it) it.IdTrabajador = fil.Cells("IdTrabajador").Value).ToList
                            If _leDG.Count > 0 Then fil.Cells("BasicoG" & _ind).Value = _leDG(0).Total
                        Next
                        griDetalleRenta5.DataBind()
                        griDetalleRenta5.UpdateData()
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub HabilitarColum()
        Try
            ' Renumeracion
            OcultarColumna(griDetalleRenta5, Not verRenumeracion.Checked, "Sueldo", "AsignacionFamiliar", "HoraExtra25", "HoraExtra35", "Movilidad" _
                      , "BonoProduccion", "RenumeracionVacacional", "CompensacionVacacional", "BonoResponsabilidad", "DescansoMedico")
            ' Total Basico
            For i = 1 To oePeriodo.Mes
                OcultarColumna(griDetalleRenta5, Not verBasico.Checked, "Basico" & i.ToString)
            Next
            ' Basico Anual
            OcultarColumna(griDetalleRenta5, Not verBono.Checked, "TotalBasico", "TotalBono", "Utilidad", "BasicoPendiente" _
                                 , "BasicoG1", "BonoExtG1", "BasicoG2", "BonoExtG2")
            ' Total Retencion
            For i = 1 To oePeriodo.Mes
                OcultarColumna(griDetalleRenta5, Not verRetencion.Checked, "Retencion" & i.ToString)
            Next
            ' Impuesto Anual
            OcultarColumna(griDetalleRenta5, Not verImpAnual.Checked, "DeduccionIUT", "RentaNetaAnual", "Rango1", "Rango2", "Rango3", "Rango4", "Rango5")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Structure stColumna
        Dim MargenDerecho As Single
        Dim MargenIzquierdo As Single
    End Structure

    Private Sub GenerarConstancia()
        Dim oDoc As New iTextSharp.text.Document(PageSize.A4, 0, 0, 0, 0)
        Dim pdfw As iTextSharp.text.pdf.PdfWriter
        Dim cb As PdfContentByte
        Dim sNombreArchivo As String
        Dim ct As ColumnText

        Try
            If griRetencionImpuesto.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar un Registro.")
            'Validar que estes en el registro de dic
            ''
            ''
            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim arrColumnas(1) As stColumna
            Dim iEstado As Integer = 0, iColumna As Integer = 0, sizeletra As Integer = 11

            Const INTERLINEADO As Single = 10
            Const MARGEN_SUPERIOR As Single = 40
            Const MARGEN_INFERIOR As Single = 40

            Dim imagepath As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaImagen") + "\"
            Dim RucISL As String = "20479729141"
            Dim IdPlanilla As String = griRetencionImpuesto.ActiveRow.Cells("IdPlanilla").Value
            'obtener periodo
            'verificar que este en el mes 12

            oeRetencionQuinta = New e_RetencionQuinta
            oeRetencionQuinta.TipoOperacion = ""
            oeRetencionQuinta.Id = griRetencionImpuesto.ActiveRow.Cells("Id").Value
            oeRetencionQuinta = olRetencionQuinta.Obtener(oeRetencionQuinta)

            oePlanilla = New e_Planilla
            oePlanilla.Id = griRetencionImpuesto.ActiveRow.Cells("IdPlanilla").Value
            oePlanilla.IndCargaCompleto = False
            oePlanilla.TipoOperacion = ""
            oePlanilla = olPlanilla.Obtener(oePlanilla)

            oePeriodo = New e_Periodo
            oePeriodo.Id = oePlanilla.IdPeriodo
            oePeriodo = olPeriodo.Obtener(oePeriodo)

            'sNombreArchivo = "D:\prueba.pdf"
            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath + "\Retencion5ta-" + oePeriodo.Ejercicio.ToString + "-" + oePeriodo.Mes.ToString + ".pdf"
            Else
                FolderBrowserDialog1.Dispose()
                Return
            End If

            Dim jpgFirma As Image = Image.GetInstance(imagepath + "FirmaRentaQuinta.jpg")
            Dim jpgEncabezado As Image = Image.GetInstance(imagepath + "LogoISL.jpg")

            pdfw = PdfWriter.GetInstance(oDoc, New FileStream(sNombreArchivo, _
                   FileMode.Create, FileAccess.Write, FileShare.None))

            oDoc.Open()
            oDoc.NewPage()

            Dim fuente As iTextSharp.text.pdf.BaseFont
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.NORMAL).BaseFont
            Dim fuenteBold As iTextSharp.text.pdf.BaseFont
            fuenteBold = FontFactory.GetFont(FontFactory.HELVETICA, 11, iTextSharp.text.Font.BOLD).BaseFont

            cb = pdfw.DirectContent

            arrColumnas(0).MargenIzquierdo = 60
            arrColumnas(0).MargenDerecho = (PageSize.A4.Width) - 60
            
            Dim boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim Font = FontFactory.GetFont(FontFactory.HELVETICA, 11)
            Dim parrafo As Paragraph

            For Each item In oeRetencionQuinta.leDetalle
                ct = New ColumnText(cb)
                ct.Alignment = 1

                Dim tableCabecera As PdfPTable = New PdfPTable(2)
                Dim widthsCabecera As Integer() = New Integer() {450.0F, 50.0F}
                tableCabecera.TotalWidth = 500.0F
                tableCabecera.LockedWidth = True
                tableCabecera.SetWidths(widthsCabecera)
                'fila
                Dim titulo As StringBuilder = New StringBuilder()
                titulo.AppendLine("CERTIFICADO DE REMUNERACIONES Y DE  RETENCIONES DE QUINTA CATEGORIA PERCIBIDAS POR EL TRABAJADOR")
                titulo.AppendLine("(Articulo 45° del D.S N° 122-94-EF. Reglamento de la Ley del IR)")
                Dim cellCabecera As PdfPCell = New PdfPCell(New Phrase(titulo.ToString, New Font(fuente, sizeletra)))
                cellCabecera.Colspan = 1
                cellCabecera.HorizontalAlignment = Element.ALIGN_CENTER
                cellCabecera.BorderColor = BaseColor.WHITE
                tableCabecera.AddCell(cellCabecera)

                'cellCabecera = New PdfPCell(New Phrase("Sueldos o salarios, asignaciones, primas, gratificaciones, bonificaciones, aguinaldos, comisiones, etc.", New Font(fuente, sizeletra)))
                cellCabecera = New PdfPCell()
                cellCabecera.AddElement(jpgEncabezado)
                cellCabecera.Colspan = 1
                cellCabecera.HorizontalAlignment = Element.ALIGN_LEFT
                cellCabecera.BorderColor = BaseColor.WHITE
                tableCabecera.AddCell(cellCabecera)
                ct.AddElement(tableCabecera)

                'ct = New ColumnText(cb)
                'ct.Alignment = 1
                'parrafo = New Paragraph("CERTIFICADO DE REMUNERACIONES Y DE  RETENCIONES DE QUINTA CATEGORIA PERCIBIDAS POR EL TRABAJADOR")
                'parrafo.Alignment = Element.ALIGN_CENTER
                'parrafo.Font = boldFont
                'ct.AddElement(parrafo)

                'parrafo = New Paragraph("(Articulo 45° del D.S N° 122-94-EF. Reglamento de la Ley del IR)")
                'parrafo.Alignment = Element.ALIGN_CENTER
                'parrafo.Font = boldFont
                'ct.AddElement(parrafo)
                ct.AddElement(New Paragraph(" "))

                parrafo = New Paragraph("EJERCICIO " & oePeriodo.Ejercicio)
                parrafo.Alignment = Element.ALIGN_CENTER
                parrafo.Font = boldFont
                ct.AddElement(parrafo)
                ct.AddElement(New Paragraph(" "))

                parrafo = New Paragraph("INDUAMERICA SERVICIOS LOGISTICOS SAC. con RUC N° 20479729141, domiciliado en Carretera Panamericana Norte KM 775 Lambayeque, debidamente representado por Sixto Perales Huancaruna DNI N° 16722570.")
                parrafo.Alignment = Element.ALIGN_JUSTIFIED
                parrafo.Font = Font
                ct.AddElement(parrafo)
                ct.AddElement(New Paragraph(" "))

                parrafo = New Paragraph("CERTIFICA")
                parrafo.Alignment = Element.ALIGN_CENTER
                parrafo.Font = boldFont
                ct.AddElement(parrafo)
                ct.AddElement(New Paragraph(" "))

                oeTrabajador = New e_Trabajador
                oeTrabajador.Id = item.IdTrabajador
                oeTrabajador.TipoBusca = 1

                oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))

                Dim textoTrabajador As String
                textoTrabajador = "Que a " & item.Trabajador & " identificado con DNI N° " & item.Dni & " en su calidad de " & oeTrabajador.oeOcupacion.Nombre _
                                                & " se le ha retenido el importe de S/. " & Format((item.TotalRetencion + item.Monto), "##,##0.00").ToString _
                                                & " como pago a cuenta del Impuesto a la Renta de quinta categoría, correspondiente al ejercicio gravable " _
                                                & oePeriodo.Ejercicio & "(Del 01/01/" & oePeriodo.Ejercicio & " al 31/12/" & oePeriodo.Ejercicio _
                                                & ") calculado en base a las siguientes rentas, deducciones y créditos: "

                parrafo = New Paragraph(textoTrabajador)
                parrafo.Alignment = Element.ALIGN_JUSTIFIED
                parrafo.Font = Font
                ct.AddElement(parrafo)
                ct.AddElement(New Paragraph(" "))

                Dim table As PdfPTable = New PdfPTable(4)
                Dim widths As Integer() = New Integer() {20.0F, 300.0F, 20.0F, 60.0F}
                table.TotalWidth = 400.0F
                table.LockedWidth = True
                table.SetWidths(widths)
                'fila
                Dim cell As PdfPCell = New PdfPCell(New Phrase("1. RENTAS BRUTAS", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase("-", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("Sueldos o salarios, asignaciones, primas, gratificaciones, bonificaciones, aguinaldos, comisiones, etc.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format((item.RentaBrutaAnual - item.Utilidad), "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase("-", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("Participación en las utilidades.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format(item.Utilidad, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase("-", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("Ingresos percibidos en forma independiente por prestación de servicios en forma simultánea bajo dependencia.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("0.00", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("RENTA BRUTA TOTAL", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format(item.RentaBrutaAnual, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase(" ", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase("2. DEDUCCIONES DE LA RENTA DE QUINTA CATEGORÍA", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase("-", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("7 U.I.T. (Sólo para trabajadores domiciliados)", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format(item.DeduccionIUT, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila
                cell = New PdfPCell(New Phrase(" ", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila                
                cell = New PdfPCell(New Phrase("3. RENTA NETA", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 2
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format(item.RentaNetaAnual, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila                
                cell = New PdfPCell(New Phrase("4. IMPUESTO A LA RENTA", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 2
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format(item.ImpuestoAnual, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila                
                cell = New PdfPCell(New Phrase("5. IMPUESTO TOTAL RETENIDO", New Font(fuenteBold, sizeletra)))
                cell.Colspan = 2
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase(Format((item.Monto + item.TotalRetencion), "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("SALDO A FAVOR (DEVOLUCIÓN PAGO EN EXCESO Art. 42° INCISO b) DECRETO SUPREMO N° 122-94-EF", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                cell = New PdfPCell(New Phrase("S/.", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                Dim saldo As Double = item.ImpuestoAnual - (item.Monto + item.TotalRetencion)
                cell = New PdfPCell(New Phrase(Format(saldo, "##,##0.00").ToString, New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.HorizontalAlignment = Element.ALIGN_RIGHT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase("OBSERVACIONES: ___________________________________________", New Font(fuente, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase("____________________________________________________________", New Font(fuente, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)
                'fila  
                cell = New PdfPCell(New Phrase("____________________________________________________________", New Font(fuente, sizeletra)))
                cell.Colspan = 4
                cell.HorizontalAlignment = Element.ALIGN_LEFT
                cell.BorderColor = BaseColor.WHITE
                table.AddCell(cell)

                ct.AddElement(table)

                ct.AddElement(jpgFirma)

                'ct.AddElement(New Paragraph(" "))
                'ct.AddElement(New Paragraph("31 de Diciembre del " & oePeriodo.Ejercicio))

                parrafo = New Paragraph("31 de Diciembre del " & oePeriodo.Ejercicio)
                parrafo.Alignment = Element.ALIGN_RIGHT
                parrafo.Font = Font
                ct.AddElement(parrafo)


                ct.SetSimpleColumn(arrColumnas(0).MargenDerecho, MARGEN_INFERIOR, arrColumnas(0).MargenIzquierdo, oDoc.PageSize.Height - MARGEN_SUPERIOR, INTERLINEADO, Element.ALIGN_JUSTIFIED)
                ct.Go()

                oDoc.NewPage()
            Next

            oDoc.Close()

            mensajeEmergente.Confirmacion("Archivos Generados Con Exito.", True)

        Catch ex As Exception
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

#End Region

#Region "Menu Contexual"

    Private Sub mcRentaQuinta_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcRentaQuinta.Opening
        mcRentaQuinta.Items("tsmiNuevo").Enabled = True
        mcRentaQuinta.Items("tsmiImportar").Enabled = True
        mcRentaQuinta.Items("tsmiExportar").Enabled = IIf(griRetencionImpuesto.Rows.Count > 0, True, False)
        If griRetencionImpuesto.Selected.Rows.Count > 0 Then
            mcRentaQuinta.Items("tsmiEditar").Enabled = True
            mcRentaQuinta.Items("tsmiEliminar").Enabled = True
            mcRentaQuinta.Items("tsmiEnviar").Enabled = True
            mcRentaQuinta.Items("tsmiExtornar").Enabled = True
            mcRentaQuinta.Items("tsmiTerminar").Enabled = True
        Else
            mcRentaQuinta.Items("tsmiEditar").Enabled = False
            mcRentaQuinta.Items("tsmiEliminar").Enabled = False
            mcRentaQuinta.Items("tsmiEnviar").Enabled = False
            mcRentaQuinta.Items("tsmiExtornar").Enabled = False
            mcRentaQuinta.Items("tsmiTerminar").Enabled = False
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
            If griRetencionImpuesto.Selected.Rows.Count > 0 Then Editar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        Try
            If griRetencionImpuesto.Selected.Rows.Count > 0 Then Eliminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        Try
            If griRetencionImpuesto.Rows.Count > 0 Then Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griRetencionImpuesto.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExtornar_Click(sender As Object, e As EventArgs) Handles tsmiExtornar.Click
        Try
            If griRetencionImpuesto.Selected.Rows.Count > 0 Then Extornar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiTerminar_Click(sender As Object, e As EventArgs) Handles tsmiTerminar.Click
        Try
            If griRetencionImpuesto.Selected.Rows.Count > 0 Then Terminar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

    Private Sub tsmiConstacia_Click(sender As Object, e As EventArgs) Handles tsmiConstacia.Click
        Try
            GenerarConstancia()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

End Class
