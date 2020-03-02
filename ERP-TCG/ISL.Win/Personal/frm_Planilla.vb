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
Imports MSScriptControl
Imports System.Text
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_Planilla
    Inherits frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_Planilla = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_Planilla()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variable"

    Private oePlanilla As New e_Planilla, olPlanilla As New l_Planilla
    Private lePlanilla As New List(Of e_Planilla), lePlanillaAux As New List(Of e_Planilla)
    Private oePeriodo As New e_Periodo, olPeriodo As New l_Periodo, lePeriodo As New List(Of e_Periodo)
    Private oeEstado As New e_Estado, olEstado As New l_Estado, leEstado As New List(Of e_Estado)
    Private oeConfiguracion As New e_ConfiguracionPlanilla, olConfiguracion As New l_ConfiguracionPlanilla
    Private leConfiguracion As New List(Of e_ConfiguracionPlanilla)
    Private oeDetalleConPla As New e_DetalleConfiguracionPlanilla, olDetalleConPla As New l_DetalleConfiguracionPlanilla
    Private leDetalleConPla As New List(Of e_DetalleConfiguracionPlanilla), leDetConPlaAux As New List(Of e_DetalleConfiguracionPlanilla)
    Private oeTrabajador As New e_Trabajador, olTrabajador As New l_Trabajador, leTrabajador As New List(Of e_Trabajador)
    Private leTrabAux As New List(Of e_Trabajador)
    Private oeSueldo As New e_SueldoTrabajador, olSueldo As New l_SueldoTrabajador, leSueldo As New List(Of e_SueldoTrabajador)
    Private oeDetallePla As New e_DetallePlanilla, olDetallePla As New l_DetallePlanilla, leDetallePla As New List(Of e_DetallePlanilla)
    Private leDetallePlaAux As New List(Of e_DetallePlanilla), leDetPlaImportar As New List(Of e_DetallePlanilla)
    Private oeDetalleCon As New e_DetalleConcepto, leDetalleCon As New List(Of e_DetalleConcepto)
    Private oeAporteDescuento As New e_AporteDescuento, olAporteDescuento As New l_AporteDescuento, leAporteDescuento As New List(Of e_AporteDescuento)
    Private oeDetalleAD As New e_DetalleAporteDescuento, olDetalleAD As New l_DetalleAporteDescuento, leDetalleAD As New List(Of e_DetalleAporteDescuento)
    Private oeFormula As New e_Formula, olFormula As New l_Formula, leFormula As New List(Of e_Formula)
    Private ColIngreso As String = "", ColDeduccion As String = "", ColAporte As String = "", ColTotal As String = ""
    Private oeCentro As New e_Centro, olCentro As New l_Centro, leCentro As List(Of e_Centro)
    Private oeArea As New e_Area, olArea As New l_Area, leArea As New List(Of e_Area)
    Private oeOcupacion As New e_Ocupacion, olOcupacion As New l_Ocupacion, leOcupacion As New List(Of e_Ocupacion)
    Private oeEmpresa As New e_Empresa, olEmpresa As New l_Empresa, leEmpresa As New List(Of e_Empresa)
    Private oeCtaCte As New e_CuentaCtePersonal, olCtaCte As New l_CuentaCtePersonal, leCtaCte As New List(Of e_CuentaCtePersonal)
    Private oeRPension As New e_FondoPensionTrabajador, olRPension As New l_FondoPensionTrabajador, leRPension As New List(Of e_FondoPensionTrabajador)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeDetModRef As New e_DetalleModelo_Referencia, olDetModRef As New l_DetalleModelo_Referencia, leDetModRef As New List(Of e_DetalleModelo_Referencia)
    Private sc As New ScriptControl
    Private dsDatosGen As New Data.DataTable
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opePlanilla As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            Listar()
            If griPlanilla.Rows.Count > 0 Then
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
                _opePlanilla = "GENERADA"
                oePlanilla = New e_Planilla
                oePlanilla.TipoOperacion = "I"
                oePlanilla.Activo = True
                oePlanilla.Tipo = 0
                Inicializa()
                txtCodigo.Text = fn_ObtenerCodigo()
                cboEstado.Text = "GENERADA"
                btnRecargar.Visible = True
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
                _opePlanilla = "GENERADA"
                Espere2.Visible = True
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()

                Inicializa()
                Mostrar()
                oePlanilla.TipoOperacion = "A"
                btnRecargar.Visible = False
                SeleccionaTab(1)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)

                Espere2.Visible = False
                'MyBase.Editar()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Espere2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere2.Visible = False
        End Try
    End Sub

    Public Overrides Sub Guardar()
        Try
            Select Case _opePlanilla
                Case "GENERADA"
                    RecolectaDatos()
                    If oePlanilla.TipoOperacion = "I" Then
                        oePlanilla.UsuarioCreacion = gUsuarioSGI.Id
                    Else
                        oePlanilla.UsuarioModifica = gUsuarioSGI.Id
                    End If
                    Dim _total = leDetallePla.Sum(Function(it) it.ImportePagar)
                    If leDetallePla.Count > 0 AndAlso _total = 0 Then Throw New Exception("Debe Consolidar los Datos Calculados")
                    oePlanilla.leDetalle = leDetallePla
                    oePlanilla.leDetalleConcepto = leDetalleCon
                    oePlanilla.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPlanilla.Guardar(oePlanilla) Then
                        mensajeEmergente.Confirmacion("El Registro se Guardo correctamente!!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                Case "ENVIAR"
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePlanilla.IdEstado = cboEstado.Value
                    oePlanilla.UsuarioModifica = gUsuarioSGI.Id
                    oePlanilla.PrefijoID = gs_PrefijoIdSucursal '@0001
                    If olPlanilla.Guardar(oePlanilla) Then
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla General Nº: " & oePlanilla.Codigo &
                                                  " se Envio correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    End If
                    'End If
                Case "IMPORTAR"
                    Dim _leAux = leDetPlaImportar.Where(Function(it) it.Activo = True).ToList
                    If _leAux.Count > 0 Then
                        'Dim formulario As frm_AutenticarTrabajador
                        'formulario = New frm_AutenticarTrabajador
                        'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                        'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                        '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                        '    Throw New Exception("Ingrese un Clave Correcta")
                        'Else
                        olDetallePla.GuardarMasivo(_leAux, gs_PrefijoIdSucursal)
                        mensajeEmergente.Confirmacion("Los Datos han sido Importados Correctamente!!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                        'End If
                    Else
                        Throw New Exception("No hay Registros Validados para Importar")
                    End If
                Case "PROVISIONAR"
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePeriodo = New e_Periodo
                    oePeriodo = cboPeriodo.SelectedItem.ListObject
                    If fecProvision.Value.Month <> oePeriodo.Mes Then Throw New Exception("La Fecha no pertenece al periodo")
                    If ndTipoCambio.Value = 0 Then Throw New Exception("Ingrese Tipo Cambio")
                    If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No se ha calculado la provision")
                    oePlanilla.IdEstado = cboEstado.Value
                    oePlanilla.UsuarioModifica = gUsuarioSGI.Id
                    oeAsientoModel.FechaMov = fecProvision.Value : oeAsientoModel.TipoCambio = ndTipoCambio.Value
                    oeAsientoModel.UsuarioCreacion = gUsuarioSGI.Id
                    If olPlanilla.Provisionar(oePlanilla, oeAsientoModel, oePeriodo) Then
                        mensajeEmergente.Confirmacion("¡El Registro de Planilla General Nº: " & oePlanilla.Codigo & " se Provisiono correctamente!", True)
                        SeleccionaTab(0)
                        Consultar(True)
                    Else
                        ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                    End If
                    'End If
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Cancelar()
        Try
            Select Case ficPlanilla.SelectedTab.Index
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
                If griPlanilla.ActiveRow.Cells("Estado").Value = _estado Then
                    'Dim formulario As frm_AutenticarTrabajador
                    'formulario = New frm_AutenticarTrabajador
                    'formulario._band = True : formulario._idtrab = gUsuarioSGI.IdTrabajador
                    'If formulario.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                    '    ControlBoton(1, 1, 1, 0, 0, 1, 0, 1, 1)
                    '    Throw New Exception("Ingrese un Clave Correcta")
                    'Else
                    oePlanilla = New e_Planilla
                    oePlanilla.TipoOperacion = ""
                    oePlanilla.Id = griPlanilla.ActiveRow.Cells("Id").Value
                    oePlanilla = olPlanilla.Obtener(oePlanilla)
                    oePlanilla.UsuarioModifica = gUsuarioSGI.Id
                    olPlanilla.Eliminar(oePlanilla)
                    mensajeEmergente.Confirmacion("¡El Registro de Planilla de Vacaciones Nº: " & oePlanilla.Codigo &
                                                         " se ha Eliminado correctamente!", True)
                    SeleccionaTab(0)
                    Consultar(True)
                    'End If
                Else
                    Throw New Exception("No puede en ELIMINAR el Registro de Retención de 5ta Categoria Nº: " & _
                                        griPlanilla.ActiveRow.Cells("Codigo").Value & " por no esta GENERADA.")
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
                Select Case ficPlanilla.SelectedTab.Index
                    Case 0
                        If griPlanilla.Rows.Count > 0 Then
                            Exportar_Excel(griPlanilla, "Planillas")
                        Else
                            Throw New Exception("No hay Registros para Exportar")
                        End If
                    Case 1
                        Select Case ficDetalle.SelectedTab.Index
                            Case 0
                                If griDetallePlanilla.Rows.Count > 0 Then
                                    Exportar_Excel(griDetallePlanilla, "DetallePlanilla")
                                Else
                                    Throw New Exception("No hay Registros para Exportar")
                                End If
                            Case 1
                                If griDetalleConcepto.Rows.Count > 0 Then
                                    Exportar_Excel(griDetalleConcepto, "Planilla")
                                Else
                                    Throw New Exception("No hay Registros para Exportar")
                                End If
                        End Select
                    Case 2
                        If griImportar.Rows.Count > 0 Then
                            Exportar_Excel(griImportar, "Datos Faltantes")
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

    Private Sub frm_Planilla_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case ficPlanilla.SelectedTab.Index
            Case 0
                If griPlanilla.Rows.Count > 0 Then
                    ControlBoton(1, 1, 1, 0, 0, 0, 0, 1, 1)
                Else
                    ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
                End If
            Case 1
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
            Case 2
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
        End Select
    End Sub

    Private Sub frm_Planilla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 1, 0, 0, 0, 0, 0, 0, 1)
            CargarCombos()
            Año1.Año = Date.Now.Year
            cboEstado.ReadOnly = True
            CargarPlanilla(New List(Of e_Planilla))
            txtCodigo.ReadOnly = True
            ndTotal.ReadOnly = True
            cboEstado.ReadOnly = True
            SeleccionaTab(0)
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
            LlenarCombo(cboPeriodoBus, "Codigo", _lePeriodoAux, 0)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griPlanilla_DoubleClick(sender As Object, e As EventArgs) Handles griPlanilla.DoubleClick
        If griPlanilla.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub btnBuscarTrab_Click(sender As Object, e As EventArgs) Handles btnBuscarTrab.Click
        Try
            If oePlanilla.FechaInicio <> #1/1/1901# AndAlso oePlanilla.FechaFin <> #1/1/1901# Then
                Dim _oeTrabAux As New e_Trabajador
                _oeTrabAux.TipoOperacion = IIf(Me.chkCaja.Checked, "1", "")
                _oeTrabAux.Id = IIf(Me.chkCaja.Checked, Me.cboPeriodo.Value, oePlanilla.Id)
                dsDatosGen = olTrabajador.CargarDatosGenerales(_oeTrabAux).Tables(0)
                leDetallePlaAux = New List(Of e_DetallePlanilla)
                leTrabAux = New List(Of e_Trabajador)
                Dim _dFin = Date.Parse(gf_InicioFinMes("F", oePlanilla.FechaFin.Year, oePlanilla.FechaFin.Month))
                Dim _leTrabAct = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 _
                                                         And it.FechaIngreso <= _dFin).ToList
                leTrabAux.AddRange(_leTrabAct)
                Dim _leTrabxLiq = leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 2 And it.IndTipo = 0 _
                                                         And it.FechaCese <> #1/1/1901# And it.FechaCese > oePlanilla.FechaFin).ToList
                leTrabAux.AddRange(_leTrabxLiq)
                For Each oeTra In leTrabAux
                    oeDetallePla = New e_DetallePlanilla
                    oeDetallePla.IdTrabajador = oeTra.Id : oeDetallePla.Equivale = 2
                    If Not leDetallePla.Contains(oeDetallePla) Then
                        Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeTra.Id & "'", "")
                        If _rwAux.Count > 0 Then
                            Dim _dsFila = _rwAux.CopyToDataTable
                            oeDetallePla.DiasFaltas = _dsFila.Rows(0).Item("DIAS_FALTA")
                            oeDetallePla.DiasVacaciones = _dsFila.Rows(0).Item("DIAS_VACAC")
                            oeDetallePla.DiasDescanso = _dsFila.Rows(0).Item("DIAS_DESC")
                            oeDetallePla.DiasCompra = _dsFila.Rows(0).Item("DIAS_COMP")
                        Else
                            Throw New Exception("No hay Datos del Trabajador: " & oeTra.oePersona.NombreCompleto)
                        End If
                        oeDetallePla.TipoOperacion = "I"
                        oeDetallePla.Dni = oeTra.oePersona.Dni
                        oeDetallePla.Trabajador = oeTra.oePersona.NombreCompleto
                        oeDetallePla.IdCentro = oeTra.IdCentro
                        oeDetallePla.IdOcupacion = oeTra.oeOcupacion.Id
                        oeDetallePla.Ocupacion = oeTra.oeOcupacion.Nombre
                        oeDetallePla.IdArea = oeTra.oeArea.Id
                        oeDetallePla.Area = oeTra.oeArea.Nombre
                        If oeDetallePla.Area = gNombreAreaOperaciones Or oeDetallePla.Area = gNombreAreaMantenimiento Then
                            oeDetallePla.IndTipoAux = 0
                        Else
                            oeDetallePla.IndTipoAux = 1
                        End If
                        oeDetallePla.IndHijo = oeTra.IndHijo
                        oeCentro = New e_Centro
                        oeCentro.Equivale = 1 : oeCentro.Id = oeTra.IdCentro
                        If leCentro.Contains(oeCentro) Then
                            oeCentro = leCentro.Item(leCentro.IndexOf(oeCentro))
                            oeDetallePla.Centro = oeCentro.Nombre
                        End If
                        oeDetallePla.Ingresos = 0
                        oeDetallePla.Deducciones = 0
                        oeDetallePla.Aportes = 0
                        oeDetallePla.Activo = True
                        leDetallePlaAux.Add(oeDetallePla)
                    End If
                Next
                If leDetallePlaAux.Count > 0 Then
                    btnAgregarDetPla.Visible = True
                    btnAgregarDetPla.Text = "Existen " & leDetallePlaAux.Count & " Registros Nuevos"
                Else
                    mensajeEmergente.Confirmacion("No se Encontraron Registros", True)
                End If
            Else
                Throw New Exception("¡Escoja Fecha de Inicio y Fin de la Planilla para Obtener los datos correctos!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnAgregarDetPla_Click(sender As Object, e As EventArgs) Handles btnAgregarDetPla.Click
        Try
            If oePlanilla.IdConfiguracion <> "" Then
                If MessageBox.Show("¿Desea Agregar los " & leDetallePlaAux.Count & " Registros?", "Mensaje de Sistema", _
                              MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    leDetallePla.AddRange(leDetallePlaAux)
                    CargarDetallePla(leDetallePla)
                    griDetallePlanilla.DataBind()
                    btnAgregarDetPla.Visible = False
                    leDetalleCon = New List(Of e_DetalleConcepto)
                    CargarDetCon(leDetalleCon)
                    griDetalleConcepto.DataBind()
                    ficDetalle.Tabs(1).Selected = True
                End If
            Else
                Throw New Exception("¡Seleccione una configuración para los clculos de la Planilla!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecInicio_ValueChanged(sender As Object, e As EventArgs) Handles fecInicio.ValueChanged
        Try
            ValidarFechaDesde_Hasta(fecInicio, fecFin)
            oePlanilla.FechaInicio = fecInicio.Value
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub fecFin_ValueChanged(sender As Object, e As EventArgs) Handles fecFin.ValueChanged
        ValidarFechaDesde_Hasta(fecInicio, fecFin)
        oePlanilla.FechaFin = fecFin.Value
    End Sub

    Private Sub cboConfiguracion_ValueChanged(sender As Object, e As EventArgs) Handles cboConfiguracion.ValueChanged
        If cboConfiguracion.SelectedIndex > -1 Then oePlanilla.IdConfiguracion = cboConfiguracion.Value
    End Sub

    Private Sub btnCalcularIngreso_Click(sender As Object, e As EventArgs) Handles btnCalcularIngreso.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            CalcularPlanilla(1)
            btnCalcularIngreso.Enabled = False
            HabCalculo(2)

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnCalcularDeduccion_Click(sender As Object, e As EventArgs) Handles btnCalcularDeduccion.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            CalcularPlanilla(2)
            btnCalcularDeduccion.Enabled = False
            HabCalculo(3)

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnCalcularAporte_Click(sender As Object, e As EventArgs) Handles btnCalcularAporte.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            CalcularPlanilla(3)
            btnCalcularAporte.Enabled = False
            HabCalculo(4)

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnCalcularNeto_Click(sender As Object, e As EventArgs) Handles btnCalcularNeto.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            CalcularPlanilla(4)
            btnCalcularNeto.Enabled = False
            btnConsolidar.Enabled = True
            btnReiniciar.Enabled = True

            ugb_Espera.Visible = False

        Catch ex As Exception
            ugb_Espera.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Try
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim PathFilePTRA As String = ""
            OpenFileDialog1 = CargaDatosOpenFileDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
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
                leDetPlaImportar.Clear()
                For ln_Fila As Integer = 1 To 100000
                    If (Not objWorkSheet.Cells(ln_Fila + 1, 2).Value Is Nothing) Then
                        etiEjecuta.Text = "Procesando " & ln_Fila & " registros ... "
                        oeDetallePla = New e_DetallePlanilla
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
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 2 : oeEmpresa.Abreviatura = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value)
                        If leEmpresa.Contains(oeEmpresa) Then oeEmpresa = leEmpresa.Item(leEmpresa.IndexOf(oeEmpresa))
                        oeCtaCte = New e_CuentaCtePersonal
                        oeCtaCte.Equivale = 2 : oeCtaCte.NroCuenta = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 13).Value)
                        If leCtaCte.Contains(oeCtaCte) Then oeCtaCte = leCtaCte.Item(leCtaCte.IndexOf(oeCtaCte))
                        With oeDetallePla
                            .Id = String.Empty
                            .IdTrabajador = oeTrabajador.Id
                            .Trabajador = IIf(oeTrabajador.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 2).Value), oeTrabajador.oePersona.NombreCompleto)
                            .Dni = Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 1).Value)
                            .IdCentro = oeCentro.Id
                            .Centro = IIf(oeCentro.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 3).Value), oeCentro.Nombre)
                            .IdArea = oeArea.Id
                            .Area = IIf(oeArea.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 4).Value), oeArea.Nombre)
                            .IdOcupacion = oeOcupacion.Id
                            .Ocupacion = IIf(oeOcupacion.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 5).Value), oeOcupacion.Nombre)
                            .IndHijo = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 6).Value) = "SI", 1, 0)
                            .IdEmpresaAFP = oeEmpresa.Id
                            .EmpresaAFP = IIf(oeEmpresa.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 7).Value), oeEmpresa.Abreviatura)
                            .IndTipoAFP = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 8).Value) = "SI", 1, 0)
                            .IndTipoAux = IIf(Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 9).Value) = "SI", 1, 0)
                            .DiasFaltas = objWorkSheet.Cells(ln_Fila + 1, 10).Value
                            .DiasDescanso = objWorkSheet.Cells(ln_Fila + 1, 11).Value
                            .DiasVacaciones = objWorkSheet.Cells(ln_Fila + 1, 12).Value
                            .DiasCompra = objWorkSheet.Cells(ln_Fila + 1, 13).Value
                            .IdCuentaCorriente = oeCtaCte.Id
                            .CuentaCorriente = IIf(oeCtaCte.Id.ToString.Trim = "", Convert.ToString(objWorkSheet.Cells(ln_Fila + 1, 14).Value), oeCtaCte.NroCuenta)
                            .Ingresos = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 15).Value, 2)
                            .Deducciones = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 16).Value, 2)
                            .ImportePagar = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 17).Value, 2)
                            .Aportes = Math.Round(objWorkSheet.Cells(ln_Fila + 1, 18).Value, 2)
                            .IndRuta = objWorkSheet.Cells(ln_Fila + 1, 19).Value
                            .IndEstado = objWorkSheet.Cells(ln_Fila + 1, 20).Value
                            .IdPlanilla = cboPlanillaImportar.Value
                            .UsuarioCreacion = gUsuarioSGI.Id
                            .Activo = False
                        End With
                        oeDetallePla.PrefijoID = gs_PrefijoIdSucursal '@0001
                        leDetPlaImportar.Add(oeDetallePla)
                    Else
                        Exit For
                    End If
                Next
                CargarDetPlaImportar(leDetPlaImportar)
                griImportar.DataBind()
                If leDetPlaImportar.Count > 0 Then btnValidar.Enabled = True
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
            mensajeEmergente.Confirmacion("Se han Procesado " & leDetPlaImportar.Count & " registros", True)
            etiEjecuta.Visible = False
        Catch ex As Exception
            etiEjecuta.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            etiEjecuta.Visible = False
        End Try
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        Try
            Dim nroreg As Integer = 0, nrotrab As Integer = 0, nrocentro As Integer = 0, nroarea As Integer = 0
            Dim nroocup As Integer = 0, nrocta As Integer = 0, nroafp As Integer = 0
            Dim ls_msg As String = String.Empty
            If leDetPlaImportar.Count > 0 Then
                etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty : upbLoad.Visible = True
                upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
                Application.DoEvents()
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                CargarDatos()
                For Each oeAux In leDetPlaImportar
                    nroreg = nroreg + 1
                    etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetPlaImportar.Count
                    upbLoad.Value = Math.Round(nroreg / leDetPlaImportar.Count, 2) * 100
                    ' Verifica si los Trabajadores entan registradas en el SGI
                    oeAux.Activo = True
                    If oeAux.IdTrabajador.Trim = "" Then
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
                    ' Verifica si las SNP/AFP entan registradas en el SGI
                    If oeAux.IdEmpresaAFP.Trim = "" Then
                        oeAux.Activo = False
                        oeEmpresa = New e_Empresa
                        oeEmpresa.TipoBusca = 2
                        oeEmpresa.Abreviatura = oeAux.EmpresaAFP
                        If leEmpresa.Contains(oeEmpresa) Then
                            Dim _leEmp = leEmpresa.Where(Function(it) it.Abreviatura = oeEmpresa.Abreviatura).ToList
                            If _leEmp.Count > 0 Then
                                oeEmpresa = _leEmp(0)
                                oeAux.IdEmpresaAFP = oeEmpresa.Id
                                oeAux.Activo = True
                            End If
                        End If
                    End If
                    If oeAux.IdEmpresaAFP.Trim = String.Empty Then nroafp = nroafp + 1
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
                CargarDetPlaImportar(leDetPlaImportar)
                griImportar.DataBind()
            Else
                Throw New Exception("No hay Datos para validar")
            End If
            If nrotrab > 0 Then ls_msg = " * " & nrotrab & " Trabajadores no registrados." & Environment.NewLine
            If nrocentro > 0 Then ls_msg = ls_msg & " * " & nrocentro & " Trabajadores con centros no registrados." & Environment.NewLine
            If nroarea > 0 Then ls_msg = ls_msg & " * " & nroarea & " Trabajadores con áreas no registrados." & Environment.NewLine
            If nroocup > 0 Then ls_msg = ls_msg & " * " & nroocup & " Trabajadores con ocupaciones no registrados." & Environment.NewLine
            If nroafp > 0 Then ls_msg = ls_msg & " * " & nroafp & " Trabajadores con ONP/AFP no registrados." & Environment.NewLine
            If nrocta > 0 Then ls_msg = ls_msg & " * " & nrocta & " Trabajadores con cuentas bancarias no registrados."
            If ls_msg.Trim.Length > 0 Then
                btnDatosExcluidos.Enabled = True
                ls_msg = "Se necesita solucionar lo siguente: " & Environment.NewLine & ls_msg
            Else
                ls_msg = "Todos los Datos estan Listos para Importar"
            End If
            mensajeEmergente.Confirmacion("Se Validaron " & leDetPlaImportar.Count & " Registros" & Environment.NewLine & ls_msg, True)
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

    Private Sub btnDatosExcluidos_Click(sender As Object, e As EventArgs) Handles btnDatosExcluidos.Click
        Try
            Dim nroreg As Integer = 0
            etiEjecuta.Visible = True : etiEjecuta.Text = String.Empty
            upbLoad.Visible = True : upbLoad.Minimum = 0 : upbLoad.Maximum = 100
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            For Each fil In griImportar.Rows
                nroreg = nroreg + 1
                etiEjecuta.Text = "Validando Registro " & nroreg & " de " & leDetPlaImportar.Count
                upbLoad.Value = Math.Round(nroreg / leDetPlaImportar.Count, 2) * 100
                If fil.Cells("IdTrabajador").Value = "" Then fil.Cells("Trabajador").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdCentro").Value = "" Then fil.Cells("Centro").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdArea").Value = "" Then fil.Cells("Area").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdOcupacion").Value = "" Then fil.Cells("Ocupacion").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdEmpresaAFP").Value = "" Then fil.Cells("EmpresaAFP").Appearance.BackColor = Color.LightCoral
                If fil.Cells("IdCuentaCorriente").Value = "" Then fil.Cells("CuentaCorriente").Appearance.BackColor = Color.LightCoral
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

    Private Sub cboPlanillaImportar_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanillaImportar.ValueChanged
        Try
            If cboPlanillaImportar.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanillaImportar.Items(cboPlanillaImportar.SelectedIndex).ListObject
                fecInicioPI.Value = _oeplaaux.FechaInicio
                fecFinPI.Value = _oeplaaux.FechaFin
                Dim oeDP As New e_DetallePlanilla
                Dim leDP As New List(Of e_DetallePlanilla)
                oeDP.TipoOperacion = ""
                oeDP.IdPlanilla = _oeplaaux.id
                oeDP.Activo = True
                leDP = olDetallePla.Listar(oeDP)
                If leDP.Count > 0 Then
                    btnBuscar.Enabled = False
                    Throw New Exception("No se puede importar datos a la Planilla Nª " & _oeplaaux.Codigo & " por que ya contiene datos")
                Else
                    btnBuscar.Enabled = True
                End If
                leDetPlaImportar = New List(Of e_DetallePlanilla)
                CargarDetPlaImportar(leDetPlaImportar)
            Else
                fecInicioPI.Value = Date.Now.Date
                fecFinPI.Value = Date.Now.Date
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkIngreso_CheckedChanged(sender As Object, e As EventArgs) Handles chkIngreso.CheckedChanged
        If chkIngreso.Enabled Then
            For Each oeDCP In leDetalleConPla.Where(Function(it) it.Activo = True And it.Tipo = 1 And it.IndTotal = 0).ToList
                OcultarColumna(griDetalleConcepto, Not chkIngreso.Checked, oeDCP.IdAporteDescuento)
            Next
        End If
    End Sub

    Private Sub chkDeduccion_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeduccion.CheckedChanged
        If chkDeduccion.Enabled Then
            For Each oeDCP In leDetalleConPla.Where(Function(it) it.Activo = True And it.Tipo = 2 And it.IndTotal = 0).ToList
                OcultarColumna(griDetalleConcepto, Not chkDeduccion.Checked, oeDCP.IdAporteDescuento)
            Next
        End If
    End Sub

    Private Sub chkAporte_CheckedChanged(sender As Object, e As EventArgs) Handles chkAporte.CheckedChanged
        If chkAporte.Enabled Then
            For Each oeDCP In leDetalleConPla.Where(Function(it) it.Activo = True And it.Tipo = 3 And it.IndTotal = 0).ToList
                OcultarColumna(griDetalleConcepto, Not chkAporte.Checked, oeDCP.IdAporteDescuento)
            Next
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        leDetalleCon = New List(Of e_DetalleConcepto)
        leDetalleCon = New List(Of e_DetalleConcepto)
        CargarDetCon(leDetalleCon)
        btnConsolidar.Enabled = False
        btnReiniciar.Enabled = False
    End Sub

    Private Sub btnConsolidar_Click(sender As Object, e As EventArgs) Handles btnConsolidar.Click
        Try
            leDetallePla = New List(Of e_DetallePlanilla)
            CargarDetallePla(leDetallePla)
            For Each fil In griDetalleConcepto.Rows
                oeDetallePla = New e_DetallePlanilla
                oeDetallePla.TipoOperacion = "I"
                oeDetallePla.Activo = True
                oeDetallePla.UsuarioCreacion = gUsuarioSGI.Id
                oeDetallePla.IdTrabajador = fil.Cells("IdTrabajador").Value
                oeDetallePla.Dni = fil.Cells("DNI").Value
                oeDetallePla.Trabajador = fil.Cells("Trabajador").Value
                If ColIngreso <> "" Then oeDetallePla.Ingresos = fil.Cells(ColIngreso).Value
                If ColDeduccion <> "" Then oeDetallePla.Deducciones = fil.Cells(ColDeduccion).Value
                If ColTotal <> "" Then oeDetallePla.ImportePagar = fil.Cells(ColTotal).Value
                If ColAporte <> "" Then oeDetallePla.Aportes = fil.Cells(ColAporte).Value
                Dim _rwAux = dsDatosGen.Select("IDTRAB = '" & oeDetallePla.IdTrabajador & "'", "")
                If _rwAux.Count > 0 Then
                    Dim _dsFila = _rwAux.CopyToDataTable
                    oeDetallePla.DiasFaltas = _dsFila.Rows(0).Item("DIAS_FALTA")
                    oeDetallePla.DiasVacaciones = _dsFila.Rows(0).Item("DIAS_VACAC")
                    oeDetallePla.DiasDescanso = _dsFila.Rows(0).Item("DIAS_DESC")
                    oeDetallePla.DiasCompra = _dsFila.Rows(0).Item("DIAS_COMP")
                End If
                oeTrabajador = New e_Trabajador
                oeTrabajador.Id = oeDetallePla.IdTrabajador : oeTrabajador.TipoBusca = 1
                If leTrabAux.Contains(oeTrabajador) Then
                    oeTrabajador = leTrabAux.Item(leTrabAux.IndexOf(oeTrabajador))
                    oeDetallePla.IdCentro = oeTrabajador.IdCentro
                    oeDetallePla.IdOcupacion = oeTrabajador.oeOcupacion.Id
                    oeDetallePla.Ocupacion = oeTrabajador.oeOcupacion.Nombre
                    oeDetallePla.IdArea = oeTrabajador.oeArea.Id
                    oeDetallePla.Area = oeTrabajador.oeArea.Nombre
                    oeDetallePla.IndTipoAux = IIf(oeDetallePla.Area = gNombreAreaOperaciones Or oeDetallePla.Area = gNombreAreaMantenimiento, 0, 1)
                    oeDetallePla.IndHijo = oeTrabajador.IndHijo
                    oeDetallePla.IndEstado = oeTrabajador.IndEstado
                    oeDetallePla.IndRuta = oeTrabajador.IndRuta
                    oeCentro = New e_Centro
                    oeCentro.Equivale = 1 : oeCentro.Id = oeTrabajador.IdCentro
                    If leCentro.Contains(oeCentro) Then
                        oeCentro = leCentro.Item(leCentro.IndexOf(oeCentro))
                        oeDetallePla.Centro = oeCentro.Nombre
                    End If
                    oeRPension = New e_FondoPensionTrabajador
                    oeRPension.Equivale = 1 : oeRPension.IdTrabajador = oeTrabajador.Id
                    If leRPension.Contains(oeRPension) Then
                        oeRPension = leRPension.Item(leRPension.IndexOf(oeRPension))
                        oeDetallePla.IdEmpresaAFP = oeRPension.IdEmpresa
                        oeDetallePla.EmpresaAFP = oeRPension.Empresa
                        oeDetallePla.IndTipoAFP = oeRPension.Mixta
                    End If
                    oeCtaCte = New e_CuentaCtePersonal
                    oeCtaCte.Equivale = 3 : oeCtaCte.IdTrabajador = oeTrabajador.Id
                    If leCtaCte.Contains(oeCtaCte) Then
                        oeCtaCte = leCtaCte.Item(leCtaCte.IndexOf(oeCtaCte))
                        oeDetallePla.IdCuentaCorriente = oeCtaCte.Id
                        oeDetallePla.CuentaCorriente = oeCtaCte.NroCuenta
                    End If
                End If
                leDetallePla.Add(oeDetallePla)
            Next
            CargarDetallePla(leDetallePla)
            griDetallePlanilla.DataBind()
            ficDetalle.Tabs(0).Selected = True
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub chkDetalle_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetalle.CheckedChanged
        OcultarColumna(griDetallePlanilla, Not chkDetalle.Checked, "Centro", "Area", "Ocupacion", "IndHijo", "EmpresaAFP", _
                       "IndTipoAFP", "IndTipoAux", "DiasFaltas", "DiasDescanso", "DiasVacaciones", "DiasCompra", "CuentaCorriente")
    End Sub

    Private Sub btnVerConceptos_Click(sender As Object, e As EventArgs) Handles btnVerConceptos.Click
        Try
            ficDetalle.Tabs(1).Enabled = True : ficDetalle.Tabs(1).Selected = True
            btnVerConceptos.Enabled = False
            ugb_Espera.Visible = True
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            CargarDetCon(oePlanilla.leDetalleConcepto)
            btnCalcularIngreso.Enabled = False
            ugb_Espera.Visible = False
        Catch ex As Exception
            ugb_Espera.Visible = False : mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show() : ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub btn_Imprimir_Click(sender As Object, e As EventArgs) Handles btn_Imprimir.Click
        Try
            GenerarBoletasPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnProcesarProv_Click(sender As Object, e As EventArgs) Handles btnProcesarProv.Click
        Try
            Application.DoEvents() : Cursor.Current = Cursors.WaitCursor : Cursor.Show()
            If oeAsientoModel.leDetalle.Count > 0 Then
                For Each oeDet In oeAsientoModel.leDetalle.OrderBy(Function(it) it.Fila).ToList
                    Dim _montoaux As Double = 0
                    ' Referencias Condicionales (Ver Tabla Tipo Referencia)
                    Dim _leDMR1 = oeAsientoModel.leDMReferencia.Where(Function(it) it.IdDetalleAsientoModelo = oeDet.Id And it.TipoReferencia <> 13).ToList
                    ' Referencias Afectadas a Condicionales (Ver Tabla Tipo Referencia)
                    Dim _leDMR2 = oeAsientoModel.leDMReferencia.Where(Function(it) it.IdDetalleAsientoModelo = oeDet.Id And it.TipoReferencia = 13).ToList
                    If _leDMR2.Count > 0 Then
                        For Each oeDMR In _leDMR2
                            If _leDMR1.Count > 0 Then
                                Select Case _leDMR1(0).TipoReferencia
                                    Case 14
                                        Dim _TipoTrab As Integer = 0
                                        If _leDMR1(0).Nombre = "ADMINISTRATIVO" Then _TipoTrab = 1
                                        Dim _leDet14 = oePlanilla.leDetalle.Where(Function(it) it.IndTipoAux = _TipoTrab).ToList
                                        If _leDet14.Count > 0 Then
                                            Dim aIdDet14 = From le In _leDet14 Select le.Id
                                            Dim _leCAUX14 = From le In oePlanilla.leDetalleConcepto Where aIdDet14.Contains(le.IdDetallePlanilla) And le.IdAporteDescuento = oeDMR.IdReferencia Select le
                                            If _leCAUX14.Count > 0 Then
                                                _montoaux = _montoaux + _leCAUX14.Sum(Function(it) it.Importe)
                                            End If
                                        End If
                                    Case 15
                                        Dim _leDet15 = oePlanilla.leDetalle.Where(Function(it) it.IdEmpresaAFP = _leDMR1(0).IdReferencia).ToList
                                        If _leDet15.Count > 0 Then
                                            Dim aIdDet15 = From le In _leDet15 Select le.Id
                                            Dim _leCAUX15 = From le In oePlanilla.leDetalleConcepto Where aIdDet15.Contains(le.IdDetallePlanilla) And le.IdAporteDescuento = oeDMR.IdReferencia Select le
                                            If _leCAUX15.Count > 0 Then
                                                _montoaux = _montoaux + _leCAUX15.Sum(Function(it) it.Importe)
                                            End If
                                        End If
                                End Select
                            Else
                                Dim _leDCAux = oePlanilla.leDetalleConcepto.Where(Function(it) it.IdAporteDescuento = oeDMR.IdReferencia).ToList
                                _montoaux = _montoaux + _leDCAux.Sum(Function(it) it.Importe)
                            End If
                        Next
                        'Else

                    End If
                    If oeDet.Formula.Trim.Length > 0 Then
                        'Dim CadFil() As String = oeDet.Formula.Split("+")
                        'If CadFil.Count > 0 Then
                        '    Dim _leDCFil = From le In oeAsientoModel.leDetalle Where CadFil.Contains(le.Fila) Select le
                        '    If _leDCFil.Count > 0 Then
                        '        _montoaux = _montoaux + _leDCFil.Sum(Function(it) it.MontoAux)
                        '    End If
                        'End If
                        Dim suma As Double = 0
                        Dim resta As Double = 0
                        Dim CadFil() As String = oeDet.Formula.Split("|")
                        If CadFil.Count > 0 Then
                            Dim CadFilSum() As String = CadFil(0).Split("+")
                            Dim _leDCFil = From le In oeAsientoModel.leDetalle Where CadFilSum.Contains(le.Fila) Select le
                            If _leDCFil.Count > 0 Then
                                _montoaux = _montoaux + _leDCFil.Sum(Function(it) it.MontoAux)
                            End If
                        End If
                        If CadFil.Count > 1 Then
                            Dim CadFilRes() As String = CadFil(1).Split("-")
                            Dim _leDCFil = From le In oeAsientoModel.leDetalle Where CadFilRes.Contains(le.Fila) Select le
                            If _leDCFil.Count > 0 Then
                                _montoaux = _montoaux - _leDCFil.Sum(Function(it) it.MontoAux)
                            End If
                        End If
                    End If
                    oeDet.MontoAux = _montoaux
                Next
                CargarProvision(oeAsientoModel.leDetalle, 1)
                CargarProvision(oeAsientoModel.leDetalle, 2)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default : Cursor.Show()
        End Try
    End Sub

    Private Sub fecProvision_ValueChanged(sender As Object, e As EventArgs) Handles fecProvision.ValueChanged
        ndTipoCambio.Value = TipoCambio(fecProvision.Value, False)(0)
    End Sub

    Private Sub cboPeriodo_ValueChanged(sender As Object, e As EventArgs) Handles cboPeriodo.ValueChanged
        If cboPeriodo.SelectedIndex > -1 Then
            oePeriodo = New e_Periodo
            oePeriodo = cboPeriodo.SelectedItem.ListObject
        End If
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarCombos()
        Try
            oePeriodo = New e_Periodo
            oePeriodo.TipoOperacion = ""
            oePeriodo.Activo = True
            lePeriodo = olPeriodo.Listar(oePeriodo)
            Dim _lePerAux = lePeriodo.OrderByDescending(Function(it) it.Codigo).ToList
            LlenarCombo(cboPeriodo, "Codigo", _lePerAux, -1)

            oeEstado = New e_Estado
            oeEstado.Nombre = "PLANILLA"
            leEstado = olEstado.Listar(oeEstado)
            oeEstado = New e_Estado
            oeEstado.Id = String.Empty
            oeEstado.Nombre = "[TODOS]"
            Dim _leEstadoAux As New List(Of e_Estado)
            _leEstadoAux.Add(oeEstado)
            _leEstadoAux.AddRange(leEstado)
            LlenarCombo(cboEstadoBus, "Nombre", _leEstadoAux, 0)
            LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            oeConfiguracion = New e_ConfiguracionPlanilla
            oeConfiguracion.TipoOperacion = ""
            oeConfiguracion.Activo = True
            'leConfiguracion = olConfiguracion.Listar(oeConfiguracion).Where(Function(x) x.Id = "1SI00001").ToList
            leConfiguracion = olConfiguracion.Listar(oeConfiguracion)
            LlenarCombo(cboConfiguracion, "Nombre", leConfiguracion, -1)

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Tipo = 0
            oePlanilla.Activo = True
            lePlanillaAux = olPlanilla.Listar(oePlanilla)
            Dim _lePlaAux = lePlanillaAux.Where(Function(it) it.Estado = gNombreEstadoGenerada).OrderByDescending(Function(it) it.Codigo).ToList
            LlenarCombo(cboPlanillaImportar, "Codigo", _lePlaAux, -1)

            CargarDatos()

            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            leAsientoModel = olAsientoModel.Listar(oeAsientoModel)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarDatos()
        Try

            oeDetalleConPla = New e_DetalleConfiguracionPlanilla
            oeDetalleConPla.TipoOperacion = "" : oeDetalleConPla.Activo = True
            leDetalleConPla = olDetalleConPla.Listar(oeDetalleConPla)

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            oeSueldo = New e_SueldoTrabajador
            oeSueldo.TipoOperacion = "" : oeSueldo.Activo = True : oeSueldo.Vigente = 1
            leSueldo = olSueldo.Listar(oeSueldo)

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
            oeCtaCte.TipoOperacion = "" : oeCtaCte.Vigente = 1 : oeCtaCte.Activo = True : oeCtaCte.TipoConcepto = "SUELDO"
            leCtaCte = olCtaCte.Listar(oeCtaCte).OrderByDescending(Function(x) x.FechaCreacion).ToList()

            oeRPension = New e_FondoPensionTrabajador
            oeRPension.TipoOperacion = String.Empty : oeRPension.Activo = True : oeRPension.Vigente = 1
            leRPension = olRPension.Listar(oeRPension)

            oeEmpresa = New e_Empresa
            oeEmpresa.TipoOperacion = "" : oeEmpresa.Activo = True
            leEmpresa = olEmpresa.Listar(oeEmpresa)

            oeAporteDescuento = New e_AporteDescuento
            oeAporteDescuento.TipoOperacion = "" : oeAporteDescuento.Activo = True
            leAporteDescuento = olAporteDescuento.Listar(oeAporteDescuento)

            oeDetalleAD = New e_DetalleAporteDescuento
            oeDetalleAD.TipoOperacion = "" : oeDetalleAD.Activo = True : oeDetalleAD.Vigencia = 1
            leDetalleAD = olDetalleAD.Listar(oeDetalleAD)

            oeFormula = New e_Formula
            oeFormula.TipoOperacion = "" : oeFormula.Activo = True
            leFormula = olFormula.Listar(oeFormula)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Listar()
        Try
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Activo = True
            oePlanilla.IdPeriodo = IIf(cboPeriodoBus.Text = "[TODOS]", Año1.Año, cboPeriodoBus.Value)
            oePlanilla.IdEstado = cboEstadoBus.Value
            'lePlanilla = olPlanilla.Listar(oePlanilla).Where(Function(x) x.IdConfiguracion = "1SI00001").OrderByDescending(Function(it) it.Codigo).ToList
            lePlanilla = olPlanilla.Listar(oePlanilla).OrderByDescending(Function(it) it.Codigo).ToList
            CargarPlanilla(lePlanilla)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPlanilla(lePla As List(Of e_Planilla))
        Try
            With griPlanilla
                .ResetDisplayLayout()
                .Text = String.Empty
                .DataSource = lePlanilla
                ConfiguraGrilla(griPlanilla, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(griPlanilla, True, "Id", "IdPeriodo", "IdConfiguracion", "IdEstado", "Tipo", "FechaCreacion", _
                               "UsuarioCreacion", "FechaModifica", "UsuarioModifica", "Activo")
                ExcluirColumna(griPlanilla, "Id", "IdPeriodo", "IdEstado", "IdConfiguracion")
                .DisplayLayout.Bands(0).Columns("Periodo").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Codigo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("NombreTipo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("FechaInicio").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("FechaFin").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Estado").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 6
                FormatoColumna(griPlanilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Importe")
                .DisplayLayout.Bands(0).Columns("Importe").CellAppearance.BackColor = Color.LightBlue
                .DisplayLayout.Bands(0).Columns("NombreTipo").Width = 200
            End With
            CalcularTotales(griPlanilla, "Importe")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Inicializa()
        txtCodigo.Text = String.Empty
        fecFin.Value = Date.Now.Date
        fecInicio.Value = Date.Now.Date
        ndTotal.Value = 0
        cboEstado.SelectedIndex = -1
        cboPeriodo.SelectedIndex = -1
        cboConfiguracion.SelectedIndex = -1
        leDetallePla = New List(Of e_DetallePlanilla)
        CargarDetallePla(leDetallePla)
        leDetalleCon = New List(Of e_DetalleConcepto)
        CargarDetCon(leDetalleCon)
        leTrabAux = New List(Of e_Trabajador)
        btnBuscarTrab.Enabled = True
        btnRecargar.Visible = True
        btnAgregarDetPla.Visible = False
        btnCalcularIngreso.Enabled = False
        btnCalcularDeduccion.Enabled = False
        btnCalcularAporte.Enabled = False
        btnCalcularNeto.Enabled = False
        btnConsolidar.Enabled = False
        btnReiniciar.Enabled = False
        dsDatosGen = New Data.DataTable
        chkIngreso.Checked = True
        chkDeduccion.Checked = True
        chkAporte.Checked = True
        chkIngreso.Enabled = False
        chkDeduccion.Enabled = False
        chkAporte.Enabled = False
        ficDetalle.Tabs(2).Visible = False
        ficDetalle.Tabs(0).Selected = True
        ndTipoCambio.Value = 0
        fecProvision.Value = Date.Now.Date
        Me.chkCaja.Checked = False
    End Sub

    Private Sub Mostrar()
        Try
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Id = griPlanilla.ActiveRow.Cells("Id").Value
            oePlanilla.IndCargaCompleto = True
            oePlanilla = olPlanilla.Obtener(oePlanilla)
            With oePlanilla
                txtCodigo.Text = .Codigo
                fecInicio.Value = .FechaInicio
                fecFin.Value = .FechaFin
                ndTotal.Value = .Importe
                cboEstado.Value = .IdEstado
                cboPeriodo.Value = .IdPeriodo
                cboConfiguracion.Value = .IdConfiguracion
                leDetallePla = .leDetalle
                CargarDetallePla(leDetallePla)
                If .leDetalleConcepto.Count = 0 Then
                    leDetalleCon = .leDetalleConcepto
                    CargarDetCon(leDetalleCon)
                End If
                _estado = gNombreEstadoGenerada
                'btnBuscarTrab.Enabled = IIf(cboEstado.Text = _estado, True, False)
                btnBuscarTrab.Enabled = IIf(.leDetalle.Count > 0, False, True)
                btnVerConceptos.Enabled = IIf(.leDetalleConcepto.Count > 0, True, False)
                ficDetalle.Tabs(1).Enabled = IIf(.leDetalleConcepto.Count > 0, False, True)
                chkCaja.Checked = IIf(.Tipo = 1, True, False)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_ObtenerCodigo() As String
        Try
            Dim oePla As New e_Planilla
            Dim strCodigo As String = ""
            oePla.TipoOperacion = "U"
            oePla = olPlanilla.Obtener(oePla)
            If oePla IsNot Nothing AndAlso oePla.Codigo <> "" Then
                strCodigo = oePla.Codigo
            End If
            Return strCodigo
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub RecolectaDatos()
        If ValidarFechaDesde_Hasta(fecInicio, fecFin) Then
            oePlanilla.Codigo = txtCodigo.Text.Trim
            oePlanilla.Importe = ndTotal.Value
            oePlanilla.FechaInicio = fecInicio.Value
            oePlanilla.FechaFin = fecFin.Value
            oePlanilla.IdEstado = cboEstado.Value
            oePlanilla.IdPeriodo = cboPeriodo.Value
            oePlanilla.IdConfiguracion = cboConfiguracion.Value
            oePlanilla.Tipo = IIf(Me.chkCaja.Checked, 1, 0)
        End If
    End Sub

    Private Sub CargarDetallePla(leDetPla As List(Of e_DetallePlanilla))
        Try
            With griDetallePlanilla
                .ResetDisplayLayout()
                .Text = String.Empty
                Dim _leAux = leDetPla.OrderBy(Function(it) it.Trabajador).ToList
                .DataSource = _leAux
                CargarConfigurarGrilla(griDetallePlanilla, 1)
                ndTotal.Value = leDetPla.Sum(Function(it) it.ImportePagar)
            End With
            CalcularTotales(griDetallePlanilla, "Ingresos", "Deducciones", "ImportePagar", "Aportes")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function CrearDT(ls_IdConfiguracion As String) As System.Data.DataTable
        Dim DetCon As New Data.DataTable
        With DetCon

            .Columns.Add(New Data.DataColumn("IdDetallePlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Trabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Gerencia", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Area", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Unidad", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ocupacion", Type.GetType("System.String")))
            leDetConPlaAux = New List(Of e_DetalleConfiguracionPlanilla)
            leDetConPlaAux = leDetalleConPla.Where(Function(it) it.IdConfiguracionPlanilla = ls_IdConfiguracion).OrderBy(Function(it) it.NroOrden).ToList
            For Each oeDetAux In leDetConPlaAux
                .Columns.Add(New Data.DataColumn(oeDetAux.IdAporteDescuento, Type.GetType("System.Double")))
                .Columns(oeDetAux.IdAporteDescuento).Caption = oeDetAux.Abreviatura
            Next
        End With
        Return DetCon
    End Function

    Private Sub CargarDetCon(leDetCon As List(Of e_DetalleConcepto))
        Try
            Dim dsDetCon As Data.DataTable = CrearDT(oePlanilla.IdConfiguracion)
            Dim _leDC As New List(Of e_DetalleConcepto)
            Dim _idTrabAux As String = ""
            Dim rwDC As Data.DataRow
            For Each oeAux In leDetallePla.OrderBy(Function(it) it.Trabajador).ToList
                If _idTrabAux <> oeAux.IdTrabajador Then
                    _idTrabAux = oeAux.IdTrabajador
                    rwDC = dsDetCon.NewRow
                    rwDC("IdDetallePlanilla") = oeAux.Id
                    rwDC("IdTrabajador") = oeAux.IdTrabajador
                    oeTrabajador = New e_Trabajador
                    oeTrabajador.TipoBusca = 1 : oeTrabajador.Id = oeAux.IdTrabajador
                    If leTrabajador.Contains(oeTrabajador) Then
                        oeTrabajador = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajador))
                        rwDC("Trabajador") = oeTrabajador.oePersona.NombreCompleto
                        rwDC("DNI") = oeTrabajador.oePersona.Dni
                        oeSueldo = New e_SueldoTrabajador
                        oeSueldo.Equivale = 1 : oeSueldo.IdTrabajador = _idTrabAux
                        For Each oeDCP In leDetConPlaAux
                            _leDC = leDetCon.Where(Function(it) it.IdTrabajador = _idTrabAux And it.IdAporteDescuento = oeDCP.IdAporteDescuento).ToList
                            If _leDC.Count > 0 Then
                                rwDC(oeDCP.IdAporteDescuento) = _leDC(0).Importe
                            Else
                                rwDC(oeDCP.IdAporteDescuento) = 0
                            End If
                        Next
                    End If
                    rwDC("Gerencia") = oeAux.Gerencia
                    rwDC("Area") = oeAux.Area
                    rwDC("Unidad") = oeAux.Unidad
                    rwDC("Ocupacion") = oeAux.Ocupacion
                    dsDetCon.Rows.Add(rwDC)
                End If
            Next
            With griDetalleConcepto
                .ResetDisplayLayout()
                .Text = String.Empty
                .DataSource = dsDetCon
                ConfiguraGrilla(griDetalleConcepto, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(griDetalleConcepto, True, "IdDetallePlanilla", "IdTrabajador")
                ExcluirColumna(griDetalleConcepto, "IdDetallePlanilla", "IdTrabajador")
                ColorFondoColumna(griDetalleConcepto, Color.Moccasin, "DNI", "Trabajador")
                For Each oeDCPAux In leDetConPlaAux
                    FormatoColumna(griDetalleConcepto, "#,##0.00", ColumnStyle.Double, HAlign.Right, oeDCPAux.IdAporteDescuento)
                    Select Case oeDCPAux.IndTotal
                        Case 0
                            .DisplayLayout.Bands(0).Columns(oeDCPAux.IdAporteDescuento).CellAppearance.BackColor = Color.LightCyan
                        Case 1
                            .DisplayLayout.Bands(0).Columns(oeDCPAux.IdAporteDescuento).CellAppearance.BackColor = Color.LightSkyBlue
                            Select Case oeDCPAux.Tipo
                                Case 1 : ColIngreso = oeDCPAux.IdAporteDescuento
                                Case 2 : ColDeduccion = oeDCPAux.IdAporteDescuento
                                Case 3 : ColAporte = oeDCPAux.IdAporteDescuento
                            End Select
                        Case 2
                            .DisplayLayout.Bands(0).Columns(oeDCPAux.IdAporteDescuento).CellAppearance.BackColor = Color.Navy
                            .DisplayLayout.Bands(0).Columns(oeDCPAux.IdAporteDescuento).CellAppearance.ForeColor = Color.White
                            ColTotal = oeDCPAux.IdAporteDescuento
                    End Select
                Next
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("DNI").Width = 70
                '.DisplayLayout.Bands(0).Columns("Gerencia").Width = 250
                .DisplayLayout.UseFixedHeaders = True
                .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                .DisplayLayout.Bands(0).Columns("DNI").Header.Fixed = True
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.Fixed = True
            End With
            HabCalculo(1)
            CalcularTotales(griDetalleConcepto, ColIngreso, ColDeduccion, ColAporte, ColTotal)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub HabControles(band As Boolean)
        cboConfiguracion.ReadOnly = band
        cboPeriodo.ReadOnly = band
    End Sub

    Private Sub HabCalculo(_ind As Integer)
        Try
            Dim _leConIng = leDetConPlaAux.Where(Function(it) it.Activo = True And it.Tipo = 1).ToList
            Dim _leConDed = leDetConPlaAux.Where(Function(it) it.Activo = True And it.Tipo = 2).ToList
            Dim _leConApo = leDetConPlaAux.Where(Function(it) it.Activo = True And it.Tipo = 3).ToList
            Dim _leConNeto = leDetConPlaAux.Where(Function(it) it.Activo = True And it.Tipo = 4).ToList
            If griDetalleConcepto.Rows.Count > 0 And cboEstado.Text = "GENERADA" Then
                Select Case _ind
                    Case 1
                        If leDetalleCon.Count = 0 Then btnCalcularIngreso.Enabled = IIf(_leConIng.Count > 0, True, False)
                    Case 2
                        btnCalcularDeduccion.Enabled = IIf(_leConDed.Count > 0, True, False)
                    Case 3
                        btnCalcularAporte.Enabled = IIf(_leConApo.Count > 0, True, False)
                    Case 4
                        btnCalcularNeto.Enabled = IIf(_leConNeto.Count > 0, True, False)
                End Select
            End If
            chkIngreso.Enabled = IIf(_leConIng.Count > 0, True, False)
            chkDeduccion.Enabled = IIf(_leConDed.Count > 0, True, False)
            chkAporte.Enabled = IIf(_leConApo.Count > 0, True, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_CalculaDatos(_oeFor As e_Formula, _fil As UltraGridRow) As Double
        Try
            Dim val As Double = 0
            Dim sCodigo As String
            Dim sDeclara As String
            sDeclara = fn_ObtieneConstantes(_fil, _oeFor)
            sCodigo = sDeclara & " " & Environment.NewLine & _
                        "Function " & _oeFor.Nombre & Environment.NewLine _
                            & _oeFor.Nombre & " = " & _oeFor.Instrucciones & Environment.NewLine _
                         & "End Function"
            sc = New ScriptControl
            With sc
                .Language = "VBScript"
                .AllowUI = True
                .AddCode(sCodigo)
                val = .Run(_oeFor.Nombre)
            End With
            'Ensamblado = New c_Ensamblado
            'If Ensamblado.PrecompilarEnsamblado(sCodigo) Then
            '    val = Ensamblado.Evaluar(_oeFor.Nombre)
            '    Ensamblado.Dispose()
            'Else
            '    Throw New Exception("No se ha generado el Ensamblado")
            'End If
            'val = Ensamblado.ObtieneResultado(_oeFor.Nombre, sCodigo)
            'Ensamblado.Dispose()
            Return val
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function fn_ObtieneConstantes(_filAux As UltraGridRow, _oeForAux As e_Formula) As String
        Try
            Dim aDatos As String = ""
            Dim sDT As String() = Nothing
            Dim sPar As String() = Nothing
            Dim sCon As String() = Nothing
            If _oeForAux.DatoTrabajador.Trim <> "" Then
                sDT = _oeForAux.DatoTrabajador.Split(",")
                For i = 0 To sDT.Length - 1
                    Dim rwAux = dsDatosGen.Select("IDTRAB = '" & _filAux.Cells("IdTrabajador").Value & "'", "").CopyToDataTable
                    aDatos = aDatos & "Dim " & sDT(i) & Environment.NewLine & _
                        sDT(i) & " = " & rwAux.Rows(0).Item(sDT(i)) & Environment.NewLine
                Next
            End If
            If _oeForAux.Parametros.Trim <> "" Then
                sPar = _oeForAux.Parametros.Split(",")
                For x = 0 To sPar.Length - 1
                    oeAporteDescuento = New e_AporteDescuento
                    oeAporteDescuento.Abreviatura = sPar(x)
                    oeAporteDescuento.Equivale = 4
                    If leAporteDescuento.Contains(oeAporteDescuento) Then
                        oeAporteDescuento = leAporteDescuento.Item(leAporteDescuento.IndexOf(oeAporteDescuento))
                        oeDetalleAD = New e_DetalleAporteDescuento
                        oeDetalleAD.IdAporteDescuento = oeAporteDescuento.Id
                        oeDetalleAD.Equivale = 2
                        If leDetalleAD.Contains(oeDetalleAD) Then
                            oeDetalleAD = leDetalleAD.Item(leDetalleAD.IndexOf(oeDetalleAD))
                            aDatos = aDatos & "Dim " & sPar(x) & Environment.NewLine & _
                                sPar(x) & " = " & oeDetalleAD.MontoCalculo & Environment.NewLine
                        End If
                        oeDetalleAD.Dispose()
                    End If
                    oeAporteDescuento.Dispose()
                Next
            End If
            If _oeForAux.Constantes.Trim <> "" Then
                sCon = _oeForAux.Constantes.Split(",")
                For j = 0 To sCon.Length - 1
                    oeAporteDescuento = New e_AporteDescuento
                    oeAporteDescuento.Abreviatura = sCon(j)
                    oeAporteDescuento.Equivale = 4
                    If leAporteDescuento.Contains(oeAporteDescuento) Then
                        oeAporteDescuento = leAporteDescuento.Item(leAporteDescuento.IndexOf(oeAporteDescuento))
                        aDatos = aDatos & "Dim " & sCon(j) & Environment.NewLine & _
                            sCon(j) & " = " & _filAux.Cells(oeAporteDescuento.Id).Value & Environment.NewLine
                    End If
                    oeAporteDescuento.Dispose()
                Next
            End If
            Return aDatos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CargarDetPlaImportar(leDPI As List(Of e_DetallePlanilla))
        Try
            With griImportar
                .ResetDisplayLayout()
                .Text = "Datos a Importar"
                .DataSource = leDPI
                .Text = "REGISTROS PARA IMPORTAR (" & leDPI.Count & ")"
                CargarConfigurarGrilla(griImportar, 2)
                If leDPI.Count > 0 Then btnValidar.Enabled = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarConfigurarGrilla(grilla As UltraGrid, tipo As Integer)
        Try
            With grilla
                ConfiguraGrilla(grilla, "Tahoma", True, UIElementBorderStyle.Default)
                OcultarColumna(grilla, True, "Id", "IdPlanilla", "IdTrabajador", "IdCentro", "IdArea", "IdOcupacion", "IdEmpresaAFP", _
                               "IdCuentaCorriente", "IndRuta", "IndEstado", "FechaCreacion", "UsuarioCreacion", "FechaModifica", _
                               "UsuarioModifica", "Activo", "IdBanco", "IsPagado", "IndTipo")
                ExcluirColumna(grilla, "Id", "IdPlanilla", "IdTrabajador", "IdCentro", "IdArea", "IdOcupacion", "IdEmpresaAFP", "IndRuta", _
                               "IdCuentaCorriente", "IndEstado", "IdBanco", "IsPagado", "IndTipo")
                CongelaColumna(grilla, "Dni", "Trabajador")
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                FormatoColumna(grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Ingresos", "Deducciones", "Aportes", "ImportePagar")
                FormatoColumna(grilla, "", ColumnStyle.CheckBox, HAlign.Default, "IndHijo", "IndTipoAFP", "IndTipoAux")
                .DisplayLayout.Bands(0).Columns("Dni").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Centro").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Gerencia").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("Area").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("Unidad").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("Ocupacion").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("IndHijo").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("EmpresaAFP").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("IndTipoAFP").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("IndTipoAux").Header.VisiblePosition = 11
                .DisplayLayout.Bands(0).Columns("DiasFaltas").Header.VisiblePosition = 12
                .DisplayLayout.Bands(0).Columns("DiasDescanso").Header.VisiblePosition = 13
                .DisplayLayout.Bands(0).Columns("DiasVacaciones").Header.VisiblePosition = 14
                .DisplayLayout.Bands(0).Columns("DiasCompra").Header.VisiblePosition = 15
                .DisplayLayout.Bands(0).Columns("CuentaCorriente").Header.VisiblePosition = 16
                .DisplayLayout.Bands(0).Columns("Ingresos").Header.VisiblePosition = 17
                .DisplayLayout.Bands(0).Columns("Deducciones").Header.VisiblePosition = 18
                .DisplayLayout.Bands(0).Columns("ImportePagar").Header.VisiblePosition = 19
                .DisplayLayout.Bands(0).Columns("Aportes").Header.VisiblePosition = 20
                .DisplayLayout.Bands(0).Columns("IndTipoAux").Header.Caption = "Admist."
                .DisplayLayout.Bands(0).Columns("IndHijo").Header.Caption = "Asig. Fam."
                .DisplayLayout.Bands(0).Columns("IndTipoAFP").Header.Caption = "Mixta"
                .DisplayLayout.Bands(0).Columns("EmpresaAFP").Header.Caption = "SNP / AFP"
                .DisplayLayout.Bands(0).Columns("CuentaCorriente").Header.Caption = "Nº Cuenta"
                If tipo = 2 Then
                    .DisplayLayout.Bands(0).Columns("Activo").Hidden = False
                    .DisplayLayout.Bands(0).Columns("Activo").Header.Caption = "OK"
                Else
                    OcultarColumna(grilla, Not chkDetalle.Checked, "Centro", "Area", "Ocupacion", "Gerencia", "Unidad", "IndHijo", "EmpresaAFP", _
                                   "IndTipoAFP", "IndTipoAux", "DiasFaltas", "DiasDescanso", "DiasVacaciones", "DiasCompra", "CuentaCorriente")
                    For Each _fil In grilla.Rows
                        Dim _descansos = _fil.Cells("DiasDescanso").Value
                        Dim _vacaciones = _fil.Cells("DiasVacaciones").Value
                        Dim _faltas = _fil.Cells("DiasFaltas").Value
                        If _descansos > 0 AndAlso _descansos > _vacaciones AndAlso _descansos > _faltas Then
                            _fil.Appearance.BackColor = colorDescanso.Color
                        End If
                        If _vacaciones > 0 AndAlso _vacaciones > _descansos And _vacaciones > _faltas Then
                            _fil.Appearance.BackColor = colorVacaciones.Color
                        End If
                        If _faltas > 0 AndAlso _faltas > _descansos And _faltas > _vacaciones Then
                            _fil.Appearance.ForeColor = colorCesado.Color
                        End If
                    Next
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularPlanilla(_indicador As Integer)
        Try
            Dim _leCon = leDetConPlaAux.Where(Function(it) it.Activo = True And it.Tipo = _indicador).ToList
            For Each oeCI In _leCon
                oeDetalleAD = New e_DetalleAporteDescuento
                oeDetalleAD.IdAporteDescuento = oeCI.IdAporteDescuento
                oeDetalleAD.Equivale = 2
                If leDetalleAD.Contains(oeDetalleAD) Then
                    oeDetalleAD = leDetalleAD.Item(leDetalleAD.IndexOf(oeDetalleAD))
                    oeFormula = New e_Formula
                    oeFormula.Id = oeDetalleAD.IdFormula
                    oeFormula.Equivale = 1
                    If leFormula.Contains(oeFormula) Then
                        oeFormula = leFormula.Item(leFormula.IndexOf(oeFormula))
                    End If
                End If
                If oeFormula.Id.Trim <> "" Then
                    For Each fil In griDetalleConcepto.Rows
                        fil.Cells(oeCI.IdAporteDescuento).Value = fn_CalculaDatos(oeFormula, fil)
                        oeDetalleCon = New e_DetalleConcepto
                        oeDetalleCon.TipoOperacion = "I"
                        oeDetalleCon.Activo = True
                        oeDetalleCon.IdTrabajador = fil.Cells("IdTrabajador").Value
                        oeDetalleCon.IdAporteDescuento = oeCI.IdAporteDescuento
                        oeDetalleCon.Importe = fil.Cells(oeCI.IdAporteDescuento).Value
                        oeDetalleCon.Tipo = _indicador
                        oeDetalleCon.UsuarioCreacion = gUsuarioSGI.Id
                        leDetalleCon.Add(oeDetalleCon)
                    Next
                End If
                oeFormula.Dispose()
                oeDetalleAD.Dispose()
            Next
            griDetalleConcepto.UpdateData()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SeleccionaTab(_index As Integer)
        ficPlanilla.Tabs(0).Enabled = False
        ficPlanilla.Tabs(1).Enabled = False
        ficPlanilla.Tabs(2).Enabled = False
        ficPlanilla.Tabs(_index).Enabled = True
        ficPlanilla.Tabs(_index).Selected = True
    End Sub

    Private Sub Enviar()
        Try
            _acl = gAccionSistema.ENVIAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoGenerada
                If griPlanilla.ActiveRow.Cells("Estado").Value = _estado AndAlso griPlanilla.ActiveRow.Cells("Importe").Value > 0 Then
                    Editar()
                    _estado = gNombreEstadoEnviado
                    cboEstado.Text = _estado
                    _opePlanilla = "ENVIAR"
                Else
                    Throw New Exception("No puede en ENVIAR el Registro de Planilla General " & Environment.NewLine & _
                                        "Nº: " & griPlanilla.ActiveRow.Cells("Codigo").Value & " por que no esta en GENERADA." & _
                                        Environment.NewLine & "O no tiene ni un solo registro de detalle.")
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
                _opePlanilla = "IMPORTAR"
                SeleccionaTab(2)
                ControlBoton(0, 0, 0, 1, 1, 0, 0, 1, 0)
                leDetPlaImportar = New List(Of e_DetallePlanilla)
                CargarDetPlaImportar(leDetPlaImportar)
                cboPlanillaImportar.SelectedIndex = -1
                fecInicioPI.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
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

    'Private Function VerificaAccion(_accion As String) As Boolean
    '    Try
    '        If gUsuarioSGI.leARUsuario.Count > 0 Then
    '            oeAccionUsuario = New e_ActividadRestringida_Usuario
    '            oeAccionUsuario.IdActividadNegocio = pIdActividadNegocio
    '            oeAccionUsuario.AccionSistema = _accion
    '            oeAccionUsuario.Equivale = 1
    '            If gUsuarioSGI.leARUsuario.Contains(oeAccionUsuario) Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Private Sub Provisionar()
        Try
            _acl = gAccionSistema.PROVISIONAR.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                _estado = gNombreEstadoEnviado
                If griPlanilla.ActiveRow.Cells("Estado").Value = _estado AndAlso griPlanilla.ActiveRow.Cells("Importe").Value > 0 Then
                    If leAsientoModel.Count > 0 Then
                        Editar()
                        oeAsientoModel = New e_AsientoModelo
                        oeAsientoModel.TipoOperacion = String.Empty : oeAsientoModel.Id = leAsientoModel(0).Id
                        oeAsientoModel.Ejercicio = oePeriodo.Ejercicio
                        oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                        CargarProvision(oeAsientoModel.leDetalle, 1)
                        CargarProvision(oeAsientoModel.leDetalle, 2)
                        ficDetalle.Tabs(2).Visible = True
                        ficDetalle.Tabs(2).Selected = True
                        _opePlanilla = "PROVISIONAR"
                        cboEstado.Text = gNombreEstadoTerminada
                    End If
                Else
                    Throw New Exception("No puede en PROVISIONAR el Registro de Planilla General " & Environment.NewLine & _
                                        "Nº: " & griPlanilla.ActiveRow.Cells("Codigo").Value & " por que no esta " & _estado)
                End If
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarProvision(leDet As List(Of e_DetalleAsientoModelo), IndPartida As Integer)
        Try
            Dim _leAux As New List(Of e_DetalleAsientoModelo)
            Dim Grilla As New UltraGrid
            _leAux = leDet.Where(Function(it) it.Partida = IndPartida).ToList
            Dim _lePar = From le In _leAux Select le.Fila, le.Cuenta, le.Titulo, le.MontoAux Order By Fila
            Grilla = IIf(IndPartida = 1, griDebePlanilla, griHaberPlanilla)
            With Grilla
                .ResetDisplayLayout()
                .DataSource = _lePar.ToList
                .Text = IIf(IndPartida = 1, "REGISTRO DEBE DE PROVISION DE PLANILLA", "REGISTRO HABER DE PROVISION DE PLANILLA")
                .DisplayLayout.Bands(0).Columns("Fila").Width = 40
                .DisplayLayout.Bands(0).Columns("Cuenta").Width = 80
                .DisplayLayout.Bands(0).Columns("Titulo").Width = 400
                FormatoColumna(Grilla, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoAux")
                ColorFondoColumna(Grilla, Color.LightBlue, "MontoAux")
                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1
                CalcularTotales(Grilla, "MontoAux")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Menu Contextual"

    Private Sub mcPlanilla_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mcPlanilla.Opening
        mcPlanilla.Items("tsmiNuevo").Enabled = True
        mcPlanilla.Items("tsmiImportar").Enabled = True
        mcPlanilla.Items("tsmiExportar").Enabled = IIf(griPlanilla.Rows.Count > 0, True, False)
        If griPlanilla.Selected.Rows.Count > 0 Then
            mcPlanilla.Items("tsmiEditar").Enabled = True
            mcPlanilla.Items("tsmiEliminar").Enabled = True
            mcPlanilla.Items("tsmiEnviar").Enabled = True
            mcPlanilla.Items("tsmiProvisionar").Enabled = True
        Else
            mcPlanilla.Items("tsmiEditar").Enabled = False
            mcPlanilla.Items("tsmiEliminar").Enabled = False
            mcPlanilla.Items("tsmiEnviar").Enabled = False
            mcPlanilla.Items("tsmiProvisionar").Enabled = False
        End If
    End Sub

    Private Sub tsmiNuevo_Click(sender As Object, e As EventArgs) Handles tsmiNuevo.Click
        Nuevo()
    End Sub

    Private Sub tsmiEditar_Click(sender As Object, e As EventArgs) Handles tsmiEditar.Click
        If griPlanilla.Selected.Rows.Count > 0 Then Editar()
    End Sub

    Private Sub tsmiEliminar_Click(sender As Object, e As EventArgs) Handles tsmiEliminar.Click
        If griPlanilla.Selected.Rows.Count > 0 Then Eliminar()
    End Sub

    Private Sub tsmiEnviar_Click(sender As Object, e As EventArgs) Handles tsmiEnviar.Click
        Try
            If griPlanilla.Selected.Rows.Count > 0 Then Enviar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiProvisionar_Click(sender As Object, e As EventArgs) Handles tsmiProvisionar.Click
        Try
            If griPlanilla.Selected.Rows.Count > 0 Then Provisionar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub tsmiExportar_Click(sender As Object, e As EventArgs) Handles tsmiExportar.Click
        If griPlanilla.Rows.Count > 0 Then Exportar()
    End Sub

    Private Sub tsmiImportar_Click(sender As Object, e As EventArgs) Handles tsmiImportar.Click
        Importar()
    End Sub

#End Region

    Private Sub PlameRem_Click(sender As Object, e As EventArgs) Handles PlameRem.Click
        Try
            If griPlanilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar un Registro.")
            'validar estados de periodo (planilla, utilidades, cts, liquidaciones)
            ''
            ''

            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim RucISL As String = "20479729141"
            Dim IdPlanilla As String = griPlanilla.ActiveRow.Cells("Id").Value
            Dim periodo As String = griPlanilla.ActiveRow.Cells("IdPeriodo").Value
            Dim AnioMes As String = griPlanilla.ActiveRow.Cells("Periodo").Value
            Dim Anio As String = AnioMes.Substring(0, 4)
            Dim Mes As String = AnioMes.Substring(5)
            If CInt(Mes) < 10 Then Mes = "0" + Mes.Trim
            AnioMes = Anio + Mes
            Dim olPlame As New l_Plame
            Dim ListaPlame As New List(Of e_PlameRem)
            Dim oePlame As New e_PlameRem
            oePlame.TipoOperacion = 1
            oePlame.IdPeriodo = periodo
            ListaPlame = olPlame.Listar(oePlame)
            'obtener dni de los trabajares de la planilla
            Dim listaDNI = From row In ListaPlame Select New With {Key row.Dni, row.TipoDocumento, row.IdTrabajador} Distinct.ToList
            'Agregar a cada trabajador el concepto 605 en cero si es que no tuviera.
            Dim listaAux1 = (From row In ListaPlame Where row.CodigoSunat = "605").ToList
            Dim listaAux2 = From row In ListaPlame Select New With {Key row.Dni, row.TipoDocumento} Distinct.ToList
            Dim indicador As Boolean = True
            For Each row2 In listaAux2
                indicador = True
                For Each row1 In listaAux1
                    If row2.Dni = row1.Dni Then indicador = False
                Next
                If indicador Then
                    oePlame = New e_PlameRem
                    oePlame.IdPeriodo = periodo
                    oePlame.TipoDocumento = row2.TipoDocumento
                    oePlame.Dni = row2.Dni
                    oePlame.CodigoSunat = "605"
                    oePlame.Devengado = 0
                    oePlame.Pagado = 0
                    ListaPlame.Add(oePlame)
                End If
            Next
            listaAux1.Clear()
            listaAux2.Clear()

            'aculumar montos de conceptos y trabajadores iguales.
            Dim query = From row In ListaPlame Group row By TipoDocumento = row.TipoDocumento, DNI = row.Dni, CodigoSunat = row.CodigoSunat Into PlameGroup = Group
            Select New With {
                .TipoDocumento = TipoDocumento,
                .DNI = DNI,
                .CodigoSunat = CodigoSunat,
                .Devengado = PlameGroup.Sum(Function(r) r.Devengado),
                .Pagado = PlameGroup.Sum(Function(r) r.Pagado)
           }

            'ordenar montos de menor a mayor
            Dim sbREM As StringBuilder = New StringBuilder()
            Dim queryaux = query.OrderBy(Function(x) x.Devengado)
            'Dim listaCodigoRem = New String() {"101", "105", "106", "107", "113", "114", "117", "118", "119", "121", "122", "123", "124", "201", "202", "210", "303", "306", "312", "313", "401", "403", "405", "406", "407", "601", "605", "606", "608", "609", "701", "702", "703", "704", "705", "706", "807", "810", "903", "904", "910", "915", "916", "1003"}

            'REM
            'generar contenido del archivo rem
            For Each fila In queryaux
                sbREM.AppendFormat("{0}|{1}|{2}|{3}|{4}|", fila.TipoDocumento, fila.DNI, fila.CodigoSunat, Math.Round(fila.Devengado, 2), Math.Round(fila.Pagado, 2))
                sbREM.AppendLine()
            Next

            'JOR
            Dim oePeriodoAux As New e_Periodo
            oePeriodoAux.Id = periodo
            oePeriodoAux = olPeriodo.Obtener(oePeriodoAux)
            Dim horasextras, minutosextras As Integer
            Dim oePagoAdicionalBoleta As New e_PagoAdicional
            Dim olPagoAdicional As New l_PagoAdicional
            oePagoAdicionalBoleta.TipoOperacion = ""
            oePagoAdicionalBoleta.Id = ""
            oePagoAdicionalBoleta.Activo = True
            oePagoAdicionalBoleta.IdPlanilla = IdPlanilla
            oePagoAdicionalBoleta = olPagoAdicional.Obtener(oePagoAdicionalBoleta)
            Dim horastrabajadas As Integer = CalcularHorasTrabajo(oePeriodoAux.FechaInicio, oePeriodoAux.FechaFin)
            'Dim horasferiado As Integer = CalcularHorasFeriados(oePeriodoAux.FechaInicio, oePeriodoAux.FechaFin)
            Dim horasnotrabajadas As Decimal = 0
            Dim sbJOR As StringBuilder = New StringBuilder()
            Dim listaResumenAsistencia As New List(Of e_ResumenAsistencia)
            Dim olResumenAsistencia As New l_ResumenAsistencia
            Dim oeResumenAsistencia As New e_ResumenAsistencia
            Dim IdTipoResumenAsistencia = New Integer() {0, 1, 2}
            oeResumenAsistencia.TipoOperacion = ""
            oeResumenAsistencia.IdPlanilla = IdPlanilla
            oeResumenAsistencia.Activo = True
            listaResumenAsistencia = olResumenAsistencia.Listar(oeResumenAsistencia)
            'Dim listaAsistencias = listaResumenAsistencia.Where(Function(x) x.IndTipo = 2 And x.IndTipoAux = 0)
            'generar contenido del archivo jor
            For Each fila In listaDNI
                horasnotrabajadas = 0
                horasextras = 0
                minutosextras = 0
                Dim lista = (From row In listaResumenAsistencia Where row.IdTrabajador = fila.IdTrabajador And IdTipoResumenAsistencia.Contains(row.IndTipo)).ToList
                For Each item In lista
                    If item.IndTipo = 2 And item.IndTipoAux = 1 Then Continue For
                    If item.IndTipo = 0 And item.IndTipoAux = 1 Then Continue For
                    horasnotrabajadas = horasnotrabajadas + CalcularHorasTrabajo(item.FechaInicio, item.FechaTermino)
                Next
                Dim oeDetallePagoAdicionalBoleta = (From row In oePagoAdicionalBoleta.leDetalle Where row.IdTrabajador = fila.IdTrabajador And row.IndTipo = 0).ToList
                If oeDetallePagoAdicionalBoleta.Count = 0 Then
                    horasextras = 0
                    minutosextras = 0
                Else
                    horasextras = oeDetallePagoAdicionalBoleta(0).HorasExtras
                    minutosextras = oeDetallePagoAdicionalBoleta(0).MinutosExtras
                End If
                sbJOR.AppendFormat("{0}|{1}|{2}|{3}|{4}|{5}|", fila.TipoDocumento, fila.Dni, horastrabajadas - Math.Truncate(horasnotrabajadas), 0, horasextras, minutosextras)
                sbJOR.AppendLine()
            Next

            'TOC
            Dim sbTOC As StringBuilder = New StringBuilder()
            'generar contenido del archivo TOC
            For Each fila In listaDNI
                sbTOC.AppendFormat("{0}|{1}|{2}|{3}|{4}|{5}|", fila.TipoDocumento, fila.Dni, 0, 1, "", 1)
                sbTOC.AppendLine()
            Next

            'SNL
            Dim listaResuAsis As New List(Of e_ResumenAsistencia)
            Dim listaResuAsisAux As New List(Of e_ResumenAsistencia)
            Dim oeResuAsis As New e_ResumenAsistencia
            Dim sbSNL As StringBuilder = New StringBuilder()
            oeResuAsis.IdPlanilla = IdPlanilla
            oeResuAsis.TipoOperacion = ""
            oeResuAsis.Activo = True
            listaResuAsis = olResumenAsistencia.Listar(oeResuAsis)
            For Each fila In listaResuAsis
                If fila.CodigoSuspension = "" Or fila.CodigoSuspension Is Nothing Then Continue For
                If fila.IndTipo = 0 Then listaResuAsisAux.Add(fila)
                If fila.IndTipo = 1 Then listaResuAsisAux.Add(fila)
                If fila.IndTipo = 2 And fila.IndTipoAux = 0 Then listaResuAsisAux.Add(fila)
            Next

            Dim listaCantidadSuspension = From row In listaResuAsisAux Group row By Dni = row.Dni, CodigoSuspension = row.CodigoSuspension Into PlameGroup = Group
            Select New With {
                .Dni = Dni,
                .CodigoSuspension = CodigoSuspension,
                .Cantidad = PlameGroup.Sum(Function(r) r.Cantidad)
           }

            'generar contenido del archivo SNL
            For Each fila In listaCantidadSuspension
                'If fila.IndTipo = 2 And fila.IndTipoAux = 1 Then Continue For
                'If fila.CodigoSuspension = "" Or fila.CodigoSuspension Is Nothing Then Continue For
                sbSNL.AppendFormat("{0}|{1}|{2}|{3}|", 1, fila.Dni, fila.CodigoSuspension, fila.Cantidad)
                sbSNL.AppendLine()
            Next

            ' 'AFP
            ' Dim sbAFP As StringBuilder = New StringBuilder()
            ' Dim contador As Integer = 1
            ' 'Dim listaTrabajador As New List(Of e_Trabajador)
            ' 'Dim listaPlameAux As New List(Of e_Trabajador)
            ' Dim oeTrabajadorAux As e_Trabajador
            ' Dim dtAFP As DataTable = DataTableAFP()
            ' Dim afp As DataRow = dtAFP.NewRow()
            ' Dim listaConceptos As New List(Of e_Concepto)
            ' Dim conceptos As New e_Concepto
            ' Dim lconceptos As New l_Concepto
            ' conceptos.TipoOperacion = "L"
            ' conceptos.Prefijo = "10"
            ' conceptos.Codigo = ""
            ' conceptos.Id = ""
            ' listaConceptos = lconceptos.Listar(conceptos)
            ' 'Dim listaCodigosIngresos = New String() {"121", "303", "916", "105", "106", "107", "915", "201", "118", "117"}
            ' Dim listaCodigosIngresos As List(Of String) = New List(Of String)
            ' For Each item In listaConceptos
            '     listaCodigosIngresos.Add(item.Valor1)
            ' Next

            ' 'aculumar montos de importe afecto afp.
            ' Dim listaImporteAfp = From row In ListaPlame Where listaCodigosIngresos.Contains(row.CodigoSunat) Group row By TipoDocumento = row.TipoDocumento, DNI = row.Dni Into PlameGroup = Group
            ' Select New With {
            '     .TipoDocumento = TipoDocumento,
            '     .DNI = DNI,
            '     .Importe = PlameGroup.Sum(Function(r) r.Devengado)
            '}

            ' 'listaTrabajador = olTrabajador.Listar(oeTrabajadorAux)
            ' 'generar contenido del archivo AFP
            ' Dim registro As String = ""
            ' For Each fila In listaDNI
            '     oeTrabajadorAux = New e_Trabajador
            '     oeTrabajadorAux.TipoOperacion = "N"
            '     oeTrabajadorAux.CargaCompleto = True
            '     oeTrabajadorAux.Id = fila.IdTrabajador
            '     oeTrabajadorAux = olTrabajador.Obtener(oeTrabajadorAux)
            '     'Dim ListaTrabajadorAux = listaTrabajador.Where(Function(x) x.oePersona.Dni = fila.Dni)
            '     'Dim listaPlameAux = ListaPlame.Where(Function(x) x.Dni = fila.Dni)
            '     Dim listaPlameAux = (From row In listaImporteAfp Where row.DNI = fila.Dni).ToList


            '     If oeTrabajadorAux.leFondoPension(0).CUSPP = "" Or oeTrabajadorAux.leFondoPension(0).CUSPP Is Nothing Then Continue For

            '     afp = dtAFP.NewRow()

            '     'secuencia
            '     afp("Secuencia") = contador
            '     registro = contador & "|"

            '     'CUSPP
            '     afp("CUSPP") = oeTrabajadorAux.leFondoPension(0).CUSPP
            '     registro = oeTrabajadorAux.leFondoPension(0).CUSPP & "|"

            '     'Tipo Documento - DNI => 0
            '     afp("TipoDocumento") = 0
            '     registro = 0 & "|"

            '     'Número de documento de indentidad
            '     afp("NumeroDocumento") = fila.Dni
            '     registro = fila.Dni & "|"

            '     'Apellido paterno
            '     afp("ApellidoPaterno") = oeTrabajadorAux.oePersona.ApellidoPaterno
            '     registro = oeTrabajadorAux.oePersona.ApellidoPaterno & "|"

            '     'Apellido materno
            '     afp("ApellidoMaterno") = oeTrabajadorAux.oePersona.ApellidoMaterno
            '     registro = oeTrabajadorAux.oePersona.ApellidoMaterno & "|"

            '     'Nombres
            '     afp("Nombres") = oeTrabajadorAux.oePersona.Nombre
            '     registro = oeTrabajadorAux.oePersona.Nombre & "|"

            '     'Relación Laboral
            '     If oeTrabajadorAux.FechaCese = "01/01/1901" Or (oeTrabajadorAux.FechaCese <= oePeriodoAux.FechaFin And oeTrabajadorAux.FechaCese >= oePeriodoAux.FechaInicio) Then
            '         afp("RelacionLaboral") = "S"
            '         registro = "S" & "|"
            '     Else
            '         afp("RelacionLaboral") = "N"
            '         registro = "N" & "|"
            '     End If

            '     'Inicio de RL
            '     If oePeriodoAux.FechaInicio <= oeTrabajadorAux.FechaIngreso And oePeriodoAux.FechaFin >= oeTrabajadorAux.FechaIngreso Then
            '         afp("InicioRL") = "S"
            '         registro = "S" & "|"
            '     Else
            '         afp("InicioRL") = "N"
            '         registro = "N" & "|"
            '     End If

            '     'Cese de RL
            '     If oePeriodoAux.FechaInicio <= oeTrabajadorAux.FechaCese And oePeriodoAux.FechaFin >= oeTrabajadorAux.FechaCese Then
            '         afp("CeseRL") = "S"
            '         registro = "S" & "|"
            '     Else
            '         afp("CeseRL") = "N"
            '         registro = "N" & "|"
            '     End If

            '     'Excepcion de Aportar
            '     afp("ExcepcionAportar") = ""
            '     registro = "" & "|"

            '     'Remuneración asegurable
            '     If listaPlameAux.Count = 0 Then
            '         afp("Remuneracion") = Math.Round(0.0, 2)
            '         registro = contador & "|"
            '     Else
            '         afp("Remuneracion") = Math.Round(listaPlameAux(0).Importe, 2)
            '         registro = contador & "|"
            '     End If

            '     'Aporte voluntario del afiliado con fin previsional
            '     afp("AVConFinPrevisional") = Math.Round(0.0, 2)
            '     registro = 0 & "|"

            '     'Aporte voluntario del afiliado sin fin previsional
            '     afp("AVSinFinPrevisional") = Math.Round(0.0, 2)
            '     registro = 0 & "|"

            '     'Aporte voluntario del empleador
            '     afp("AVEmpleador") = Math.Round(0.0, 2)
            '     registro = 0 & "|"

            '     'Tipo de trabajo
            '     afp("TipoTrabajo") = "N"
            '     registro = "N" & "|"

            '     'AFP
            '     afp("AFP") = ""
            '     registro = "" & "|"

            '     sbAFP.Append(registro)
            '     sbAFP.AppendLine()
            '     dtAFP.Rows.Add(afp)
            '     contador = contador + 1
            ' Next

            'Generar los archivos
            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim sw As New System.IO.StreamWriter(FolderBrowserDialog1.SelectedPath + "\0601" + AnioMes + RucISL + ".rem")
                sw.WriteLine(sbREM.ToString())
                sw.Flush()
                sw.Close()

                sw = New System.IO.StreamWriter(FolderBrowserDialog1.SelectedPath + "\0601" + AnioMes + RucISL + ".jor")
                sw.WriteLine(sbJOR.ToString())
                sw.Flush()
                sw.Close()

                sw = New System.IO.StreamWriter(FolderBrowserDialog1.SelectedPath + "\0601" + AnioMes + RucISL + ".snl")
                sw.WriteLine(sbSNL.ToString())
                sw.Flush()
                sw.Close()

                sw = New System.IO.StreamWriter(FolderBrowserDialog1.SelectedPath + "\0601" + AnioMes + RucISL + ".toc")
                sw.WriteLine(sbTOC.ToString())
                sw.Flush()
                sw.Close()

                'ExportToExcel(dtAFP, FolderBrowserDialog1.SelectedPath + "\" + AnioMes + ".xlsx")

                mensajeEmergente.Confirmacion("Archivos Generados Con Exito.", True)
            Else
                FolderBrowserDialog1.Dispose()
            End If
        Catch ex As Exception
            Espere2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere2.Visible = False
        End Try

    End Sub

    Private Function CalcularHorasTrabajo(ByVal FechaInicio As Date, ByVal FechaFin As Date) As Decimal
        Try
            Dim Dias As Integer = DateDiff(DateInterval.Day, FechaInicio, FechaFin) + 1
            Dim domingos As Integer = 0
            Dim horastrabajadas As Decimal = 0
            Dim horasFeriados As Decimal = CalcularHorasFeriados(FechaInicio, FechaFin)
            Dim sabados As Integer = 0
            Dim diasemana As Integer = 0
            For i As Integer = 0 To Dias - 1
                Select Case Weekday(FechaInicio, vbMonday)
                    Case 7
                        domingos = domingos + 1
                    Case 6
                        sabados = sabados + 1
                    Case Else
                        diasemana = diasemana + 1
                End Select
                FechaInicio = FechaInicio.AddDays(1)
            Next
            horastrabajadas = diasemana * 8.5 + sabados * 5.5
            Return horastrabajadas - horasFeriados
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CalcularHorasFeriados(ByVal FechaInicio As Date, ByVal FechaFin As Date) As Integer
        Try
            Dim oeFeriados As New e_Feriados
            Dim olFeriados As New l_Feriados
            Dim listaFeriados As New List(Of e_Feriados)
            oeFeriados.TipoOperacion = ""
            oeFeriados.IdTipoFeriado = ""
            listaFeriados = olFeriados.Listar(oeFeriados)
            Dim lista = (From row In listaFeriados Where row.Fecha >= FechaInicio And row.Fecha <= FechaFin).ToList
            Dim domingos As Integer = 0
            Dim horasferiado As Integer = 0
            Dim sabados As Integer = 0
            Dim diasemana As Integer = 0
            For Each item In lista
                Select Case Weekday(item.Fecha, vbMonday)
                    Case 7
                        domingos = domingos + 1
                    Case 6
                        sabados = sabados + 1
                    Case Else
                        diasemana = diasemana + 1
                End Select
            Next
            horasferiado = diasemana * 8.5 + sabados * 5.5
            Return horasferiado
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function DataTableAFP() As DataTable
        Try
            Dim dtAfp As DataTable = New DataTable("afp")
            dtAfp.Columns.Add(New DataColumn("Secuencia"))
            dtAfp.Columns.Add(New DataColumn("CUSPP"))
            dtAfp.Columns.Add(New DataColumn("TipoDocumento"))
            dtAfp.Columns.Add(New DataColumn("NumeroDocumento"))
            dtAfp.Columns.Add(New DataColumn("ApellidoPaterno"))
            dtAfp.Columns.Add(New DataColumn("ApellidoMaterno"))
            dtAfp.Columns.Add(New DataColumn("Nombres"))
            dtAfp.Columns.Add(New DataColumn("RelacionLaboral"))
            dtAfp.Columns.Add(New DataColumn("InicioRL"))
            dtAfp.Columns.Add(New DataColumn("CeseRL"))
            dtAfp.Columns.Add(New DataColumn("ExcepcionAportar"))
            dtAfp.Columns.Add(New DataColumn("Remuneracion"))
            dtAfp.Columns.Add(New DataColumn("AVConFinPrevisional"))
            dtAfp.Columns.Add(New DataColumn("AVSinFinPrevisional"))
            dtAfp.Columns.Add(New DataColumn("AVEmpleador"))
            dtAfp.Columns.Add(New DataColumn("TipoTrabajo"))
            dtAfp.Columns.Add(New DataColumn("AFP"))
            Return dtAfp
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub tsmiGenerarBoletas_Click(sender As Object, e As EventArgs) Handles tsmiGenerarBoletas.Click
        Try
            GenerarBoletasPago()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Structure stColumna
        Dim MargenDerecho As Single
        Dim MargenIzquierdo As Single
    End Structure

    Private Sub GenerarBoletasPago()
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

            Select Case ficPlanilla.SelectedTab.Index
                Case 0
                    If griPlanilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar un Registro.")
                    IdPlanilla = griPlanilla.ActiveRow.Cells("Id").Value
                    periodo = griPlanilla.ActiveRow.Cells("IdPeriodo").Value
                    AnioMes = griPlanilla.ActiveRow.Cells("Periodo").Value
                Case 1
                    IdPlanilla = oePlanilla.Id
                    periodo = cboPeriodo.Value
                    AnioMes = cboPeriodo.Text
                    For Each Fila As Infragistics.Win.UltraWinGrid.UltraGridRow In griDetallePlanilla.Rows.Where(Function(item) item.IsFilteredOut = False)
                        ListaDNI.Add(Fila.Cells("DNI").Value)
                    Next
            End Select



            'validar estados de periodo (planilla, utilidades, cts, liquidaciones)
            ''
            ''
            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim arrColumnas(1) As stColumna
            Dim iEstado As Integer = 0, iColumna As Integer = 0, sizeletra As Integer = 8
            Dim imagepath As String = DirectCast(ConfigurationManager.GetSection("VariablesDeConfiguracion"), NameValueCollection).Item("RutaImagen") + "\"
            Dim colorCeldas1 As New BaseColor(Color.LightBlue)
            Dim colorCeldas2 As New BaseColor(Color.LightCyan)

            Const INTERLINEADO As Single = 10
            Const MARGEN_SUPERIOR As Single = 20
            Const MARGEN_INFERIOR As Single = 20

            Dim RucISL As String = gs_RucEmpresaSistema
            'Dim IdPlanilla As String = griPlanilla.ActiveRow.Cells("Id").Value
            'Dim periodo As String = griPlanilla.ActiveRow.Cells("IdPeriodo").Value
            'Dim AnioMes As String = griPlanilla.ActiveRow.Cells("Periodo").Value
            Dim Anio As String = AnioMes.Substring(0, 4)
            Dim Mes As String = AnioMes.Substring(5)
            If CInt(Mes) < 10 Then Mes = "0" + Mes.Trim
            AnioMes = Anio + Mes

            'obtener detalle planilla
            Dim oePlanillaBoletas As New e_Planilla
            oePlanillaBoletas.TipoOperacion = ""
            oePlanillaBoletas.Id = griPlanilla.ActiveRow.Cells("Id").Value
            oePlanillaBoletas.IndCargaCompleto = True
            oePlanillaBoletas = olPlanilla.Obtener(oePlanillaBoletas)

            Dim listaDetallePLa As New List(Of e_DetallePlanilla)
            Select Case ficPlanilla.SelectedTab.Index
                Case 0
                    listaDetallePLa = oePlanillaBoletas.leDetalle
                Case 1
                    listaDetallePLa = oePlanillaBoletas.leDetalle.Where(Function(i) ListaDNI.Contains(i.Dni)).OrderBy(Function(j) j.Trabajador).ToList
            End Select


            Dim listaDetalleConcepto As New List(Of e_DetalleConcepto)
            listaDetalleConcepto = oePlanillaBoletas.leDetalleConcepto

            Dim oePeriodoAux As New e_Periodo
            oePeriodoAux.Id = periodo
            oePeriodoAux = olPeriodo.Obtener(oePeriodoAux)

            If oePeriodoAux.FechaFin < oePeriodoAux.FechaInicio Then Throw New Exception("Comunicarse con Contabilidad, la fecha fin del Periodo es: " & oePeriodoAux.FechaFin.Date)

            Dim listaResumenAsistencia As New List(Of e_ResumenAsistencia)
            Dim olResumenAsistencia As New l_ResumenAsistencia
            Dim oeResumenAsistencia As New e_ResumenAsistencia
            oeResumenAsistencia.TipoOperacion = ""
            oeResumenAsistencia.IdPlanilla = IdPlanilla
            listaResumenAsistencia = olResumenAsistencia.Listar(oeResumenAsistencia)

            Dim oeCTAux As New e_ConfiguracionTabla
            oeCTAux = CargarCTCD("T15_Situacion")
            Dim dtSituacion As New DataTable
            dtSituacion = FiltraDTable(GenerarDTConfigurable(oeCTAux), "", "")

            Dim olPlame As New l_Plame
            Dim ListaPlame As New List(Of e_PlameRem)
            Dim oePlame As New e_PlameRem
            oePlame.TipoOperacion = 2
            oePlame.IdPeriodo = periodo
            ListaPlame = olPlame.Listar(oePlame)

            Dim jpgEncabezado As Image = Image.GetInstance(imagepath + "CabeceraBoleta.jpg")
            Dim jpgFirma As Image = Image.GetInstance(imagepath + "Firma.jpg")
            '    jpg.ScaleToFit(300.0F, 300.0F)
            '    jpg.SpacingAfter = 12.0F
            '    jpg.SpacingBefore = 12.0F


            FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                sNombreArchivo = FolderBrowserDialog1.SelectedPath + "\Boletas-" + Anio + "-" + Mes + ".pdf"
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
            'Seteamos el tipo de letra y el tamaño.
            'cb.SetFontAndSize(fuente, 16)
            'Seteamos el color del texto a escribir.
            'cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)


            'arrColumnas(0).MargenIzquierdo = 60
            'arrColumnas(0).MargenDerecho = 280
            'arrColumnas(1).MargenIzquierdo = 320
            'arrColumnas(1).MargenDerecho = 530
            arrColumnas(0).MargenIzquierdo = 60
            arrColumnas(0).MargenDerecho = (PageSize.A4.Height / 2) - 30
            arrColumnas(1).MargenIzquierdo = (PageSize.A4.Height / 2) + 30
            arrColumnas(1).MargenDerecho = PageSize.A4.Height - 60

            Dim contador As Integer = 0
            For Each item In listaDetallePLa
                Dim table As PdfPTable
                contador = contador + 1
                table = BoletaPagoTrabajador(oePlanillaBoletas, ListaPlame, item.IdTrabajador, oePeriodoAux, listaResumenAsistencia, dtSituacion)
                ct = New ColumnText(cb)
                ct.Alignment = 1
                ct.AddElement(jpgEncabezado)
                ct.AddElement(table)
                ct.AddElement(New Paragraph(" "))
                ct.AddElement(jpgFirma)

                ct.SetSimpleColumn(arrColumnas(0).MargenDerecho, MARGEN_INFERIOR, arrColumnas(0).MargenIzquierdo, oDoc.PageSize.Height - MARGEN_SUPERIOR, INTERLINEADO, Element.ALIGN_JUSTIFIED)
                ct.Go()

                ct = New ColumnText(cb)
                ct.Alignment = 1
                ct.AddElement(jpgEncabezado)
                ct.AddElement(table)
                ct.AddElement(New Paragraph(" "))
                ct.AddElement(jpgFirma)

                ct.SetSimpleColumn(arrColumnas(1).MargenDerecho, MARGEN_INFERIOR, arrColumnas(1).MargenIzquierdo, oDoc.PageSize.Height - MARGEN_SUPERIOR, INTERLINEADO, Element.ALIGN_JUSTIFIED)
                ct.Go()

                oDoc.NewPage()

                'If contador = 100 Then Exit For '@0001
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

    Private Function BoletaPagoTrabajador(oePlanillaLocal As e_Planilla, listaPlame As List(Of e_PlameRem), IdTrabajado As String, oePeriodoBolera As e_Periodo, listaResumenAsistencia As List(Of e_ResumenAsistencia), dtSituacion As DataTable) As PdfPTable
        Try
            Dim sizeletra As Integer = 8
            Dim sizeletraMin As Integer = 6
            Dim colorCeldas1 As New BaseColor(Color.LightBlue)
            Dim colorCeldas2 As New BaseColor(Color.LightCyan)
            Dim fuente As iTextSharp.text.pdf.BaseFont
            fuente = FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL).BaseFont

            Dim listaDetallePLa As New List(Of e_DetallePlanilla)
            listaDetallePLa = oePlanillaLocal.leDetalle
            Dim listaDetallePLaAUX = listaDetallePLa.Where(Function(x) x.IdTrabajador = IdTrabajado)
            Dim listaDetalleConcepto As New List(Of e_DetalleConcepto)
            listaDetalleConcepto = oePlanillaLocal.leDetalleConcepto

            Dim oeTrabajadorBoleta As New e_Trabajador
            oeTrabajadorBoleta.TipoOperacion = "N"
            oeTrabajadorBoleta.Id = IdTrabajado
            oeTrabajadorBoleta.CargaCompleto = True
            oeTrabajadorBoleta = olTrabajador.Obtener(oeTrabajadorBoleta)

            'aculumar montos de conceptos y trabajadores iguales.
            Dim ListaPlameAgrupada = From row In listaPlame Where row.IdTrabajador = IdTrabajado Group row By TipoDocumento = row.TipoDocumento, IdTrabajador = row.IdTrabajador, DNI = row.Dni, CodigoSunat = row.CodigoSunat Into PlameGroup = Group
            Select New With {
                .TipoDocumento = TipoDocumento,
                .IdTrabajador = IdTrabajador,
                .DNI = DNI,
                .CodigoSunat = CodigoSunat,
                .Devengado = PlameGroup.Sum(Function(r) r.Devengado),
                .Pagado = PlameGroup.Sum(Function(r) r.Pagado)
           }

            Dim listaConceptos As New List(Of e_Concepto)
            Dim conceptos As e_Concepto
            Dim lconceptos As New l_Concepto

            Dim table As PdfPTable = New PdfPTable(8)
            'Dim widths As Integer() = New Integer() {1.0F, 1.0F, 1.0F}
            table.TotalWidth = 380.0F
            table.LockedWidth = True

            'table.SetWidths(widths)
            Dim cell As PdfPCell = New PdfPCell(New Phrase("BOLETA DE PAGO | PERIODO: " + oePlanillaLocal.Periodo, New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Documento Identidad", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Nombre y Apellidos", New Font(fuente, sizeletra)))
            cell.Colspan = 4
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Situación", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Tipo", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Número", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            'AQUI TIPO DOCUMENTO IDENTIDAD
            cell = New PdfPCell(New Phrase("DNI", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI NUMERO DNI
            cell = New PdfPCell(New Phrase(listaDetallePLaAUX(0).Dni, New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI NOMBRE DEL TRABAJADOR
            cell = New PdfPCell(New Phrase(listaDetallePLaAUX(0).Trabajador, New Font(fuente, sizeletra)))
            cell.Colspan = 4
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI SITUALICION LABORAL
            Dim fechaingreso As Date
            Dim fechacese As Date
            Dim isCesado As Boolean = False

            For Each item In oeTrabajadorBoleta.leOcupacionTrabajador
                If item.FechaCese = "01/01/1901" Then
                    If item.FechaIngreso <= oePeriodoBolera.FechaFin Then
                        fechaingreso = item.FechaIngreso
                        fechacese = Now.Date
                        Exit For
                    End If
                End If

                If item.FechaIngreso > oePeriodoBolera.FechaFin Then Continue For
                If item.FechaCese < oePeriodoBolera.FechaInicio Then Continue For

                If item.FechaCese <= oePeriodoBolera.FechaFin And item.FechaCese >= oePeriodoBolera.FechaInicio Then
                    fechaingreso = item.FechaIngreso
                    fechacese = item.FechaCese
                    Exit For
                End If

                If item.FechaIngreso >= oePeriodoBolera.FechaInicio And item.FechaIngreso <= oePeriodoBolera.FechaFin Then
                    fechaingreso = item.FechaIngreso
                    fechacese = item.FechaCese
                    Exit For
                End If

                If item.FechaIngreso <= oePeriodoBolera.FechaInicio And item.FechaCese >= oePeriodoBolera.FechaFin Then
                    fechaingreso = item.FechaIngreso
                    fechacese = item.FechaCese
                    Exit For
                End If
            Next

            If oePeriodoBolera.FechaInicio <= fechacese And oePeriodoBolera.FechaFin >= fechacese Then isCesado = True

            If isCesado Then
                cell = New PdfPCell(New Phrase("Cesado", New Font(fuente, sizeletra)))
            Else
                cell = New PdfPCell(New Phrase("Activo o Subsidiado", New Font(fuente, sizeletra)))
            End If
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Cargo", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            'AQUI CARGO LABORAL
            cell = New PdfPCell(New Phrase(oeTrabajadorBoleta.oeOcupacion.Nombre, New Font(fuente, sizeletra)))
            cell.Colspan = 6
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Fecha Ingreso", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Tipo Trabajador", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Regimen", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("CUSPP", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            'AQUI FECHA INGRESO
            'cell = New PdfPCell(New Phrase("01/01/2015", New Font(fuente, sizeletra)))
            cell = New PdfPCell(New Phrase(fechaingreso, New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI TIPO TRABAJADOR
            If listaDetallePLaAUX(0).IndTipoAux = 1 Then
                cell = New PdfPCell(New Phrase("EMPLEADO", New Font(fuente, sizeletraMin)))
            Else
                cell = New PdfPCell(New Phrase("OBRERO", New Font(fuente, sizeletraMin)))
            End If
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI REGIMEN
            'cell = New PdfPCell(New Phrase(listaDetallePLaAUX(0).EmpresaAFP, New Font(fuente, sizeletra)))
            If Not IsNothing(oeTrabajador.leFondoPension) And oeTrabajador.leFondoPension.Count > 0 Then
                cell = New PdfPCell(New Phrase(oeTrabajadorBoleta.leFondoPension(0).Empresa, New Font(fuente, sizeletraMin)))
            Else
                cell = New PdfPCell(New Phrase("ONP", New Font(fuente, sizeletraMin)))
            End If
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI CUSPP
            If Not IsNothing(oeTrabajador.leFondoPension) And oeTrabajador.leFondoPension.Count > 0 Then
                cell = New PdfPCell(New Phrase(oeTrabajadorBoleta.leFondoPension(0).CUSPP, New Font(fuente, sizeletra)))
            Else
                cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
            End If
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            Dim faltasFicticiasLaborado As Integer = 0
            Dim faltasFicticiasNoLaborado As Integer = 0
            Dim diasSubsidiados As Integer = 0
            Dim horastrabajadas As Integer = CalcularHorasTrabajo(oePeriodoBolera.FechaInicio, oePeriodoBolera.FechaFin)
            Dim horasferiado As Integer = CalcularHorasFeriados(oePeriodoBolera.FechaInicio, oePeriodoBolera.FechaFin)
            Dim IdTipoResumenAsistencia = New Integer() {0, 1, 2}
            Dim horasnotrabajadas As Decimal = 0
            Dim lista = (From row In listaResumenAsistencia Where row.IdTrabajador = IdTrabajado And IdTipoResumenAsistencia.Contains(row.IndTipo)).ToList
            For Each item In lista
                If item.IndTipo = 2 And item.IndTipoAux = 1 Then Continue For
                If item.IndTipo = 1 And item.IndTipoAux = 1 Then diasSubsidiados = diasSubsidiados + item.Cantidad
                If item.IndTipo = 0 And item.IndTipoAux = 1 Then faltasFicticiasLaborado = faltasFicticiasLaborado + item.Cantidad
                If item.IndTipo = 0 And item.CodigoSuspension = "" Then faltasFicticiasNoLaborado = faltasFicticiasNoLaborado + item.Cantidad
                If item.IndTipo = 0 And item.IndTipoAux = 1 Then Continue For
                horasnotrabajadas = horasnotrabajadas + CalcularHorasTrabajo(item.FechaInicio, item.FechaTermino)
            Next

            cell = New PdfPCell(New Phrase("Días Laborados", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Días No Laborados", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Días Subsidiado", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Condición", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Jornada Ordinaria", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Sobretiempo", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Horas", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Minutos", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Horas", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Minutos", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            'AQUI DIAS LABORADOS
            Dim Dias As Integer = DateDiff(DateInterval.Day, oePeriodoBolera.FechaInicio, oePeriodoBolera.FechaFin) + 1
            cell = New PdfPCell(New Phrase(Dias + faltasFicticiasLaborado - listaDetallePLaAUX(0).DiasFaltas - listaDetallePLaAUX(0).DiasDescanso - listaDetallePLaAUX(0).DiasVacaciones - diasSubsidiados, New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI DIAS NO LABORADOS
            cell = New PdfPCell(New Phrase(listaDetallePLaAUX(0).DiasFaltas + listaDetallePLaAUX(0).DiasDescanso + listaDetallePLaAUX(0).DiasVacaciones - faltasFicticiasNoLaborado, New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI DIAS SUBSIDIADOS
            cell = New PdfPCell(New Phrase(diasSubsidiados, New Font(fuente, sizeletra)))
            'cell = New PdfPCell(New Phrase(listaDetallePLaAUX(0).DiasDescanso, New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI CONDICION
            cell = New PdfPCell(New Phrase("Domiciliado", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI TOTAL DE HORAS TRABAJADAS            
            cell = New PdfPCell(New Phrase(horastrabajadas - Math.Truncate(horasnotrabajadas), New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI MINUTOS TRABAJADOS
            cell = New PdfPCell(New Phrase("0", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI TOTAL DE HORAS DE SOBRETIEMPO
            Dim oePagoAdicionalBoleta As New e_PagoAdicional
            Dim olPagoAdicional As New l_PagoAdicional
            oePagoAdicionalBoleta.TipoOperacion = ""
            oePagoAdicionalBoleta.Id = ""
            oePagoAdicionalBoleta.Activo = True
            oePagoAdicionalBoleta.IdPlanilla = oePlanillaLocal.Id
            oePagoAdicionalBoleta = olPagoAdicional.Obtener(oePagoAdicionalBoleta)
            Dim oeDetallePagoAdicionalBoleta = (From row In oePagoAdicionalBoleta.leDetalle Where row.IdTrabajador = IdTrabajado And row.IndTipo = 0).ToList
            If oeDetallePagoAdicionalBoleta.Count = 0 Then
                cell = New PdfPCell(New Phrase(0, New Font(fuente, sizeletra)))
            Else
                cell = New PdfPCell(New Phrase(oeDetallePagoAdicionalBoleta(0).HorasExtras, New Font(fuente, sizeletra)))
            End If
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            'AQUI MINUTOS DE SOBRETIEMPO
            If oeDetallePagoAdicionalBoleta.Count = 0 Then
                cell = New PdfPCell(New Phrase(0, New Font(fuente, sizeletra)))
            Else
                cell = New PdfPCell(New Phrase(IIf(oeDetallePagoAdicionalBoleta.Count = 0, 0, oeDetallePagoAdicionalBoleta(0).MinutosExtras), New Font(fuente, sizeletra)))
            End If
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Motivos de suspensión de labores", New Font(fuente, sizeletra)))
            cell.Colspan = 6
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Otros - Renta 5ta Categoria", New Font(fuente, sizeletra)))
            cell.Colspan = 2
            cell.Rowspan = 2
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Tipo", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Motivo", New Font(fuente, sizeletra)))
            cell.Colspan = 4
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("N° Días", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            'SUSPENSION     
            Dim listaSuspensionAux As New List(Of e_ResumenAsistencia)
            For Each fila In lista
                If fila.CodigoSuspension = "" Then Continue For
                If fila.IndTipo = 0 Then listaSuspensionAux.Add(fila)
                If fila.IndTipo = 1 And fila.IndTipoAux = 0 Then listaSuspensionAux.Add(fila)
                If fila.IndTipo = 2 And fila.IndTipoAux = 0 Then listaSuspensionAux.Add(fila)
            Next

            'Dim listaCantidadSuspension As New List(Of e_ResumenAsistencia)
            Dim listaCantidadSuspension = From row In listaSuspensionAux Group row By CodigoSuspension = row.CodigoSuspension Into PlameGroup = Group
            Select New With {
                .CodigoSuspension = CodigoSuspension,
                .Cantidad = PlameGroup.Sum(Function(r) r.Cantidad)
           }

            'listaCantidadSuspension.AddRange(lista.Where(Function(x) x.IndTipo = 0 And x.CodigoSuspension <> ""))
            'listaCantidadSuspension.AddRange(lista.Where(Function(x) x.IndTipo = 1 And x.CodigoSuspension <> ""))
            'listaCantidadSuspension.AddRange(lista.Where(Function(x) x.IndTipo = 2 And x.IndTipoAux = 0 And x.CodigoSuspension <> ""))

            If listaCantidadSuspension.Count = 0 Then
                'AQUI TIPO DE SUSPENSION
                cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.Rowspan = 1
                cell.HorizontalAlignment = 1
                table.AddCell(cell)

                'AQUI MOTIVO DE SUSPENSION
                cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletraMin)))
                cell.Colspan = 4
                cell.Rowspan = 1
                cell.HorizontalAlignment = 1
                table.AddCell(cell)

                'AQUI DIAS DE SUSPENSION
                cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                cell.Colspan = 1
                cell.Rowspan = 1
                cell.HorizontalAlignment = 1
                table.AddCell(cell)

                'AQUI TIENE RENTA DE 5TA 
                cell = New PdfPCell(New Phrase("No tiene", New Font(fuente, sizeletra)))
                cell.Colspan = 2
                cell.Rowspan = 1
                cell.HorizontalAlignment = 1
                table.AddCell(cell)
            Else
                Dim indicador As Boolean = True
                conceptos = New e_Concepto
                conceptos.TipoOperacion = "L"
                conceptos.Prefijo = "14"
                conceptos.Codigo = ""
                conceptos.Id = ""
                listaConceptos = lconceptos.Listar(conceptos)
                For Each fila In listaCantidadSuspension
                    'If fila.IndTipo = 2 And fila.IndTipoAux = 1 Then Continue For
                    'If fila.CodigoSuspension = "" Or fila.CodigoSuspension Is Nothing Then Continue For
                    Dim oeConAux = From row In listaConceptos Where row.Valor1 = fila.CodigoSuspension

                    'AQUI TIPO DE SUSPENSION
                    cell = New PdfPCell(New Phrase(fila.CodigoSuspension, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI MOTIVO DE SUSPENSION
                    cell = New PdfPCell(New Phrase(oeConAux(0).Nombre, New Font(fuente, sizeletraMin)))
                    cell.Colspan = 4
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI DIAS DE SUSPENSION
                    cell = New PdfPCell(New Phrase(fila.Cantidad, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    If indicador Then
                        indicador = False
                        'AQUI TIENE RENTA DE 5TA 
                        cell = New PdfPCell(New Phrase("No tiene", New Font(fuente, sizeletra)))
                        cell.Colspan = 2
                        cell.Rowspan = 1
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                    Else
                        'AQUI TIENE RENTA DE 5TA 
                        cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
                        cell.Colspan = 2
                        cell.Rowspan = 1
                        cell.HorizontalAlignment = 1
                        table.AddCell(cell)
                    End If
                Next
            End If

            cell = New PdfPCell(New Phrase(" ", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Código", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Conceptos", New Font(fuente, sizeletra)))
            cell.Colspan = 4
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Ingresos S/.", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Descuentos S/. ", New Font(fuente, sizeletraMin)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Netos S/.", New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 1
            cell.BackgroundColor = colorCeldas1
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Ingresos", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            cell.BackgroundColor = colorCeldas2
            table.AddCell(cell)

            Dim ingresos As Double = 0
            Dim descuentos As Double = 0
            'ingresos
            conceptos = New e_Concepto
            conceptos.TipoOperacion = "L"
            conceptos.Prefijo = "11"
            conceptos.Codigo = ""
            conceptos.Id = ""
            listaConceptos = lconceptos.Listar(conceptos)
            For Each i In listaConceptos
                For Each x In ListaPlameAgrupada
                    If i.Valor1 <> x.CodigoSunat Then Continue For
                    'AQUI CODIGO
                    cell = New PdfPCell(New Phrase(i.Valor1, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI Conceptos
                    cell = New PdfPCell(New Phrase(i.Nombre, New Font(fuente, sizeletraMin)))
                    cell.Colspan = 4
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 0
                    table.AddCell(cell)

                    'AQUI Ingresos
                    cell = New PdfPCell(New Phrase(Math.Round(x.Devengado, 2).ToString("#,##0.00"), New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Descuentos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Netos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    ingresos = ingresos + x.Devengado

                Next

            Next


            cell = New PdfPCell(New Phrase("Descuentos", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            cell.BackgroundColor = colorCeldas2
            table.AddCell(cell)

            'descuentos
            conceptos = New e_Concepto
            conceptos.TipoOperacion = "L"
            conceptos.Prefijo = "15"
            conceptos.Codigo = ""
            conceptos.Id = ""
            listaConceptos = lconceptos.Listar(conceptos)
            For Each i In listaConceptos
                For Each x In ListaPlameAgrupada
                    If i.Valor1 <> x.CodigoSunat Then Continue For
                    'AQUI CODIGO
                    cell = New PdfPCell(New Phrase(i.Valor1, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI Conceptos
                    cell = New PdfPCell(New Phrase(i.Nombre, New Font(fuente, sizeletraMin)))
                    cell.Colspan = 4
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 0
                    table.AddCell(cell)

                    'AQUI Ingresos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Descuentos
                    cell = New PdfPCell(New Phrase(Math.Round(x.Devengado, 2).ToString("#,##0.00"), New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Netos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    descuentos = descuentos + x.Devengado
                Next
            Next

            cell = New PdfPCell(New Phrase("Aportes de trabajador", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            cell.BackgroundColor = colorCeldas2
            table.AddCell(cell)

            'Aportes de trabajador
            conceptos = New e_Concepto
            conceptos.TipoOperacion = "L"
            conceptos.Prefijo = "12"
            conceptos.Codigo = ""
            conceptos.Id = ""
            listaConceptos = lconceptos.Listar(conceptos)
            For Each i In listaConceptos
                For Each x In ListaPlameAgrupada
                    If i.Valor1 <> x.CodigoSunat Then Continue For
                    'AQUI CODIGO
                    cell = New PdfPCell(New Phrase(i.Valor1, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI Conceptos
                    cell = New PdfPCell(New Phrase(i.Nombre, New Font(fuente, sizeletraMin)))
                    cell.Colspan = 4
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 0
                    table.AddCell(cell)

                    'AQUI Ingresos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Descuentos
                    cell = New PdfPCell(New Phrase(Math.Round(x.Devengado, 2).ToString("#,##0.00"), New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Netos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    descuentos = descuentos + x.Devengado
                Next
            Next

            cell = New PdfPCell(New Phrase("Neto a pagar", New Font(fuente, sizeletra)))
            cell.Colspan = 7
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            cell.BackgroundColor = colorCeldas2
            table.AddCell(cell)

            'AQUI Netos
            cell = New PdfPCell(New Phrase(Math.Round(ingresos - descuentos, 2).ToString("#,##0.00"), New Font(fuente, sizeletra)))
            cell.Colspan = 1
            cell.Rowspan = 1
            cell.HorizontalAlignment = 2
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            table.AddCell(cell)

            cell = New PdfPCell(New Phrase("Aportes de Empleador", New Font(fuente, sizeletra)))
            cell.Colspan = 8
            cell.Rowspan = 1
            cell.HorizontalAlignment = 0
            cell.BackgroundColor = colorCeldas2
            table.AddCell(cell)

            'descuentos
            conceptos = New e_Concepto
            conceptos.TipoOperacion = "L"
            conceptos.Prefijo = "13"
            conceptos.Codigo = ""
            conceptos.Id = ""
            listaConceptos = lconceptos.Listar(conceptos)
            For Each i In listaConceptos
                For Each x In ListaPlameAgrupada
                    If i.Valor1 <> x.CodigoSunat Then Continue For
                    'AQUI CODIGO
                    cell = New PdfPCell(New Phrase(i.Valor1, New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 1
                    table.AddCell(cell)

                    'AQUI Conceptos
                    cell = New PdfPCell(New Phrase(i.Nombre, New Font(fuente, sizeletraMin)))
                    cell.Colspan = 4
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 0
                    table.AddCell(cell)

                    'AQUI Ingresos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Descuentos
                    cell = New PdfPCell(New Phrase("", New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)

                    'AQUI Netos
                    cell = New PdfPCell(New Phrase(Math.Round(x.Devengado, 2).ToString("#,##0.00"), New Font(fuente, sizeletra)))
                    cell.Colspan = 1
                    cell.Rowspan = 1
                    cell.HorizontalAlignment = 2
                    table.AddCell(cell)
                Next
            Next



            Return table
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub tsmiGenerarAFPnet_Click(sender As Object, e As EventArgs) Handles tsmiGenerarAFPnet.Click
        Try
            If griPlanilla.Selected.Rows.Count <> 1 Then Throw New Exception("Debe Seleccionar un Registro.")
            'validar estados de periodo (planilla, utilidades, cts, liquidaciones)
            ''
            ''

            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            Dim RucISL As String = "20479729141"
            Dim IdPlanilla As String = griPlanilla.ActiveRow.Cells("Id").Value
            Dim periodo As String = griPlanilla.ActiveRow.Cells("IdPeriodo").Value
            Dim AnioMes As String = griPlanilla.ActiveRow.Cells("Periodo").Value
            Dim Anio As String = AnioMes.Substring(0, 4)
            Dim Mes As String = AnioMes.Substring(5)
            If CInt(Mes) < 10 Then Mes = "0" + Mes.Trim
            AnioMes = Anio + Mes
            Dim olPlame As New l_Plame
            Dim ListaPlame As New List(Of e_PlameRem)
            Dim oePlame As New e_PlameRem
            oePlame.TipoOperacion = 1
            oePlame.IdPeriodo = periodo
            ListaPlame = olPlame.Listar(oePlame)
            'obtener dni de los trabajares de la planilla
            Dim listaDNI = From row In ListaPlame Select New With {Key row.Dni, row.TipoDocumento, row.IdTrabajador} Distinct.ToList
            ''Agregar a cada trabajador el concepto 605 en cero si es que no tuviera.
            'Dim listaAux1 = (From row In ListaPlame Where row.CodigoSunat = "605").ToList
            'Dim listaAux2 = From row In ListaPlame Select New With {Key row.Dni, row.TipoDocumento} Distinct.ToList
            'Dim indicador As Boolean = True
            'For Each row2 In listaAux2
            '    indicador = True
            '    For Each row1 In listaAux1
            '        If row2.Dni = row1.Dni Then indicador = False
            '    Next
            '    If indicador Then
            '        oePlame = New e_PlameRem
            '        oePlame.IdPeriodo = periodo
            '        oePlame.TipoDocumento = row2.TipoDocumento
            '        oePlame.Dni = row2.Dni
            '        oePlame.CodigoSunat = "605"
            '        oePlame.Devengado = 0
            '        oePlame.Pagado = 0
            '        ListaPlame.Add(oePlame)
            '    End If
            'Next
            'listaAux1.Clear()
            'listaAux2.Clear()

            ''aculumar montos de conceptos y trabajadores iguales.
            ' Dim query = From row In ListaPlame Group row By TipoDocumento = row.TipoDocumento, DNI = row.Dni, CodigoSunat = row.CodigoSunat Into PlameGroup = Group
            ' Select New With {
            '     .TipoDocumento = TipoDocumento,
            '     .DNI = DNI,
            '     .CodigoSunat = CodigoSunat,
            '     .Devengado = PlameGroup.Sum(Function(r) r.Devengado),
            '     .Pagado = PlameGroup.Sum(Function(r) r.Pagado)
            '}

            ''ordenar montos de menor a mayor
            'Dim sbREM As StringBuilder = New StringBuilder()
            'Dim queryaux = query.OrderBy(Function(x) x.Devengado)

            ''generar contenido del archivo rem
            'For Each fila In queryaux
            '    sbREM.AppendFormat("{0}|{1}|{2}|{3}|{4}|", fila.TipoDocumento, fila.DNI, fila.CodigoSunat, Math.Round(fila.Devengado, 2), Math.Round(fila.Pagado, 2))
            '    sbREM.AppendLine()
            'Next

            ''JOR
            'Dim oePeriodoAux As New e_Periodo
            'oePeriodoAux.Id = periodo
            'oePeriodoAux = olPeriodo.Obtener(oePeriodoAux)
            'Dim horastrabajadas As Integer = CalcularHorasTrabajo(oePeriodoAux.FechaInicio, oePeriodoAux.FechaFin)
            'Dim horasferiado As Integer = CalcularHorasFeriados(oePeriodoAux.FechaInicio, oePeriodoAux.FechaFin)
            'Dim horasnotrabajadas As Decimal = 0
            'Dim sbJOR As StringBuilder = New StringBuilder()
            'Dim listaResumenAsistencia As New List(Of e_ResumenAsistencia)
            'Dim olResumenAsistencia As New l_ResumenAsistencia
            'Dim oeResumenAsistencia As New e_ResumenAsistencia
            'Dim IdTipoResumenAsistencia = New Integer() {0, 1, 2}
            'oeResumenAsistencia.TipoOperacion = ""
            'oeResumenAsistencia.IdPlanilla = IdPlanilla
            'oeResumenAsistencia.Activo = True
            'listaResumenAsistencia = olResumenAsistencia.Listar(oeResumenAsistencia)
            ''generar contenido del archivo jor
            'For Each fila In listaDNI
            '    horasnotrabajadas = 0
            '    Dim lista = (From row In listaResumenAsistencia Where row.IdTrabajador = fila.IdTrabajador And IdTipoResumenAsistencia.Contains(row.IndTipo)).ToList
            '    For Each item In lista
            '        horasnotrabajadas = horasnotrabajadas + CalcularHorasTrabajo(item.FechaInicio, item.FechaTermino)
            '    Next
            '    sbJOR.AppendFormat("{0}|{1}|{2}|{3}|{4}|{5}|", fila.TipoDocumento, fila.Dni, horastrabajadas - Math.Truncate(horasnotrabajadas) - horasferiado, 0, 0, 0)
            '    sbJOR.AppendLine()
            'Next

            ''TOC
            'Dim sbTOC As StringBuilder = New StringBuilder()
            ''generar contenido del archivo TOC
            'For Each fila In listaDNI
            '    sbTOC.AppendFormat("{0}|{1}|{2}|{3}|{4}|{5}|", fila.TipoDocumento, fila.Dni, 0, 1, "", 1)
            '    sbTOC.AppendLine()
            'Next

            ''SNL
            'Dim listaResuAsis As New List(Of e_ResumenAsistencia)
            'Dim oeResuAsis As New e_ResumenAsistencia
            'Dim sbSNL As StringBuilder = New StringBuilder()
            'oeResuAsis.IdPlanilla = IdPlanilla
            'oeResuAsis.TipoOperacion = ""
            'oeResuAsis.Activo = True
            'listaResuAsis = olResumenAsistencia.Listar(oeResuAsis)
            ''generar contenido del archivo jor
            'For Each fila In listaResuAsis
            '    If fila.IndTipo = 2 And fila.IndTipoAux = 1 Then Continue For
            '    If fila.CodigoSuspension = "" Or fila.CodigoSuspension Is Nothing Then Continue For
            '    sbSNL.AppendFormat("{0}|{1}|{2}|{3}|", 1, fila.Dni, fila.CodigoSuspension, fila.Cantidad)
            '    sbSNL.AppendLine()
            'Next

            'AFP
            Dim oePeriodoAux As New e_Periodo
            oePeriodoAux.Id = periodo
            oePeriodoAux = olPeriodo.Obtener(oePeriodoAux)
            Dim contador As Integer = 1
            'Dim listaTrabajador As New List(Of e_Trabajador)
            'Dim listaPlameAux As New List(Of e_Trabajador)
            Dim oeTrabajadorAux As e_Trabajador
            Dim dtAFP As DataTable = DataTableAFP()
            Dim afp As DataRow = dtAFP.NewRow()
            Dim listaConceptos As New List(Of e_Concepto)
            Dim conceptos As New e_Concepto
            Dim lconceptos As New l_Concepto
            conceptos.TipoOperacion = "L"
            conceptos.Prefijo = "10"
            conceptos.Codigo = ""
            conceptos.Id = ""
            listaConceptos = lconceptos.Listar(conceptos)
            Dim listaCodigosIngresos As List(Of String) = New List(Of String)
            For Each item In listaConceptos
                listaCodigosIngresos.Add(item.Valor1)
            Next

            'aculumar montos de importe afecto afp.
            Dim listaImporteAfp = From row In ListaPlame Where listaCodigosIngresos.Contains(row.CodigoSunat) Group row By TipoDocumento = row.TipoDocumento, DNI = row.Dni Into PlameGroup = Group
            Select New With {
                .TipoDocumento = TipoDocumento,
                .DNI = DNI,
                .Importe = PlameGroup.Sum(Function(r) r.Devengado)
           }

            'generar contenido del archivo AFP
            Dim registro As String = ""
            For Each fila In listaDNI
                oeTrabajadorAux = New e_Trabajador
                oeTrabajadorAux.TipoOperacion = "N"
                oeTrabajadorAux.CargaCompleto = True
                oeTrabajadorAux.Id = fila.IdTrabajador
                oeTrabajadorAux = olTrabajador.Obtener(oeTrabajadorAux)
                Dim listaPlameAux = (From row In listaImporteAfp Where row.DNI = fila.Dni).ToList

                If oeTrabajadorAux.leFondoPension(0).IdEmpresa = "1CH000010168" Then Continue For

                'If oeTrabajadorAux.leFondoPension(0).CUSPP = "" Or oeTrabajadorAux.leFondoPension(0).CUSPP Is Nothing Then Continue For

                afp = dtAFP.NewRow()

                'secuencia
                afp("Secuencia") = contador
                registro = contador & "|"

                'CUSPP
                afp("CUSPP") = oeTrabajadorAux.leFondoPension(0).CUSPP
                registro = oeTrabajadorAux.leFondoPension(0).CUSPP & "|"

                'Tipo Documento - DNI => 0
                afp("TipoDocumento") = 0
                registro = 0 & "|"

                'Número de documento de indentidad
                afp("NumeroDocumento") = fila.Dni
                registro = fila.Dni & "|"

                'Apellido paterno
                afp("ApellidoPaterno") = oeTrabajadorAux.oePersona.ApellidoPaterno
                registro = oeTrabajadorAux.oePersona.ApellidoPaterno & "|"

                'Apellido materno
                afp("ApellidoMaterno") = oeTrabajadorAux.oePersona.ApellidoMaterno
                registro = oeTrabajadorAux.oePersona.ApellidoMaterno & "|"

                'Nombres
                afp("Nombres") = oeTrabajadorAux.oePersona.Nombre
                registro = oeTrabajadorAux.oePersona.Nombre & "|"

                'Relación Laboral
                If oeTrabajadorAux.FechaCese = "01/01/1901" Or (oeTrabajadorAux.FechaCese <= oePeriodoAux.FechaFin And oeTrabajadorAux.FechaCese >= oePeriodoAux.FechaInicio) Then
                    afp("RelacionLaboral") = "S"
                    registro = "S" & "|"
                Else
                    afp("RelacionLaboral") = "N"
                    registro = "N" & "|"
                End If

                'Inicio de RL
                If oePeriodoAux.FechaInicio <= oeTrabajadorAux.FechaIngreso And oePeriodoAux.FechaFin >= oeTrabajadorAux.FechaIngreso Then
                    afp("InicioRL") = "S"
                    registro = "S" & "|"
                Else
                    afp("InicioRL") = "N"
                    registro = "N" & "|"
                End If

                'Cese de RL
                If oePeriodoAux.FechaInicio <= oeTrabajadorAux.FechaCese And oePeriodoAux.FechaFin >= oeTrabajadorAux.FechaCese Then
                    afp("CeseRL") = "S"
                    registro = "S" & "|"
                Else
                    afp("CeseRL") = "N"
                    registro = "N" & "|"
                End If

                'Excepcion de Aportar
                afp("ExcepcionAportar") = ""
                registro = "" & "|"

                'Remuneración asegurable
                If listaPlameAux.Count = 0 Then
                    afp("Remuneracion") = Math.Round(0.0, 2)
                    registro = contador & "|"
                Else
                    afp("Remuneracion") = Math.Round(listaPlameAux(0).Importe, 2)
                    registro = contador & "|"
                End If

                'Aporte voluntario del afiliado con fin previsional
                afp("AVConFinPrevisional") = Math.Round(0.0, 2)
                registro = 0 & "|"

                'Aporte voluntario del afiliado sin fin previsional
                afp("AVSinFinPrevisional") = Math.Round(0.0, 2)
                registro = 0 & "|"

                'Aporte voluntario del empleador
                afp("AVEmpleador") = Math.Round(0.0, 2)
                registro = 0 & "|"

                'Tipo de trabajo
                afp("TipoTrabajo") = "N"
                registro = "N" & "|"

                'AFP
                afp("AFP") = ""
                registro = "" & "|"

                dtAFP.Rows.Add(afp)
                contador = contador + 1
            Next

            gridAFP.ResetDisplayLayout()
            gridAFP.DataSource = dtAFP
            ConfiguraGrilla(gridAFP, "Tahoma", True, UIElementBorderStyle.Default)
            'gridAFP.DisplayLayout.Bands(0).Columns("TRABAJADOR").Width = 250
            'gridAFP.DisplayLayout.Bands(0).Columns("GERENCIA").Width = 150
            'gridAFP.DisplayLayout.Bands(0).Columns("AREA").Width = 150
            'gridAFP.DisplayLayout.Bands(0).Columns("UNIDAD").Width = 150
            'gridAFP.DisplayLayout.Bands(0).Columns("CARGO").Width = 150
            'gridAFP.DisplayLayout.Bands(0).Columns("BANCO").Width = 150
            'gridAFP.DisplayLayout.Bands(0).Columns("CUENTA").Width = 150
            FormatoColumna(gridAFP, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Remuneracion")
            gridAFP.DataBind()
            ExportarGrillaAExcel(gridAFP, "AFPNET-" + AnioMes)

            ''Generar los archivos
            'FolderBrowserDialog1.Description = "Seleccionar Carpeta..."
            'If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            '    ExportToExcel(dtAFP, FolderBrowserDialog1.SelectedPath + "\AFPNET-" + AnioMes + ".xlsx", True)
            '    mensajeEmergente.Confirmacion("Archivos Generados Con Exito.", True)
            'Else
            '    FolderBrowserDialog1.Dispose()
            'End If
        Catch ex As Exception
            Espere2.Visible = False
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere2.Visible = False
        End Try
    End Sub

    'Private Sub GenerarReporteFinal(ByVal IdPlanilla As String)
    '    Try
    '        Dim oePagoCajaTrabajador As New e_PagoCajaTrabajador, olPagoCajaTrabajador As New l_PagoCajaTrabajador
    '        Dim lePagoCajaTrabajador As New List(Of e_PagoCajaTrabajador)
    '        Dim oeDetPagCajTrab As New e_DetallePagoCajaTrabajador
    '        Dim leDetPagCajTrab As New List(Of e_DetallePagoCajaTrabajador)
    '        Dim oeTrabajadorAux As New e_Trabajador
    '        Dim oeSueldoAux As New e_SueldoTrabajador
    '        Dim oeCtaCteAux As New e_CuentaCtePersonal
    '        Dim oePlanillaAux As New e_Planilla
    '        oePlanillaAux.TipoOperacion = ""
    '        oePlanillaAux.Id = IdPlanilla
    '        oePlanillaAux.IndCargaCompleto = True
    '        oePlanillaAux = olPlanilla.Obtener(oePlanillaAux)

    '        oePagoCajaTrabajador.TipoOperacion = ""
    '        oePagoCajaTrabajador.IdPlanilla = IdPlanilla
    '        oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
    '        leDetPagCajTrab = oePagoCajaTrabajador.leDetalle

    '        Dim dsDetCon As Data.DataTable = CrearDT(oePlanillaAux.IdConfiguracion)
    '        'agregar columnas adicionales
    '        With dsDetCon
    '            .Columns.Add(New Data.DataColumn("GERENCIA", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("AREA", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("UNIDAD", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("CARGO", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("SECTOR", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("F. INGRESO", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("BASICO", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("BONO COMBUSTIBLE PIURA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES PIURA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("BONO JEFES CONVOY", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES LIMA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("BANCO", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("CUENTA", Type.GetType("System.String")))
    '            .Columns.Add(New Data.DataColumn("GRATIF. 18.17%", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("VACAC. 8.33%", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("CTS. 8.33%", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("TOTAL APORTACIONES", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("TOTAL COSTO", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("VIATICOS LIMA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("CALIZA SUSTENTO", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("ADM CAJA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("PIURA", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("OTROS", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("TOTAL CAJAS", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("NETO RECIBIDO", Type.GetType("System.Double")))
    '            .Columns.Add(New Data.DataColumn("HORAS EXTRAS", Type.GetType("System.Double")))
    '        End With

    '        Dim _leDC As New List(Of e_DetalleConcepto)
    '        Dim _idTrabAux As String = ""
    '        Dim IdAreaAux As String = ""
    '        Dim rwDC As Data.DataRow

    '        For Each oeAux In oePlanillaAux.leDetalle.OrderBy(Function(it) it.Trabajador).ToList
    '            If _idTrabAux <> oeAux.IdTrabajador Then
    '                _idTrabAux = oeAux.IdTrabajador
    '                rwDC = dsDetCon.NewRow
    '                rwDC("IdDetallePlanilla") = oeAux.Id
    '                rwDC("IdTrabajador") = oeAux.IdTrabajador
    '                oeTrabajadorAux = New e_Trabajador
    '                oeTrabajadorAux.TipoBusca = 1 : oeTrabajadorAux.Id = oeAux.IdTrabajador
    '                If leTrabajador.Contains(oeTrabajadorAux) Then
    '                    oeTrabajadorAux = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajadorAux))
    '                    oeSueldoAux = New e_SueldoTrabajador
    '                    oeSueldoAux.Equivale = 1 : oeSueldoAux.IdTrabajador = oeAux.IdTrabajador
    '                    If leSueldo.Contains(oeSueldoAux) Then oeSueldoAux = leSueldo.Item(leSueldo.IndexOf(oeSueldoAux))
    '                    oeCtaCteAux = New e_CuentaCtePersonal
    '                    oeCtaCteAux.Equivale = 3 : oeCtaCteAux.IdTrabajador = oeAux.IdTrabajador
    '                    If leCtaCte.Contains(oeCtaCteAux) Then oeCtaCteAux = leCtaCte.Item(leCtaCte.IndexOf(oeCtaCteAux))

    '                    rwDC("Trabajador") = oeTrabajadorAux.oePersona.NombreCompleto
    '                    rwDC("DNI") = oeTrabajadorAux.oePersona.Dni

    '                    For Each oeDCP In leDetConPlaAux
    '                        _leDC = oePlanillaAux.leDetalleConcepto.Where(Function(it) it.IdTrabajador = _idTrabAux And it.IdAporteDescuento = oeDCP.IdAporteDescuento).ToList
    '                        If _leDC.Count > 0 Then
    '                            rwDC(oeDCP.IdAporteDescuento) = _leDC(0).Importe
    '                        Else
    '                            rwDC(oeDCP.IdAporteDescuento) = 0
    '                        End If
    '                    Next

    '                    'agregar datos adicionales  

    '                    Dim oeAreaAux As New e_Area
    '                    oeAreaAux.Id = oeAux.IdArea
    '                    oeAreaAux.Equivale = 1
    '                    If leArea.Contains(oeAreaAux) Then oeAreaAux = leArea.Item(leArea.IndexOf(oeAreaAux))
    '                    rwDC("AREA") = oeAreaAux.Sector
    '                    IdAreaAux = oeAreaAux.IdSector
    '                    oeAreaAux = New e_Area
    '                    oeAreaAux.Id = IdAreaAux
    '                    oeAreaAux.Equivale = 1
    '                    If leArea.Contains(oeAreaAux) Then oeAreaAux = leArea.Item(leArea.IndexOf(oeAreaAux))
    '                    rwDC("GERENCIA") = oeAreaAux.Gerencia
    '                    rwDC("UNIDAD") = oeAux.Area
    '                    rwDC("CARGO") = oeAux.Ocupacion
    '                    rwDC("SECTOR") = oeAux.Centro
    '                    rwDC("F. INGRESO") = oeTrabajadorAux.FechaIngreso.ToShortDateString
    '                    rwDC("BASICO") = oeSueldoAux.Sueldo

    '                    rwDC("BONO COMBUSTIBLE PIURA") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "6").Sum(Function(x) x.TotalPagar)
    '                    rwDC("VUELTAS ADICIONALES PIURA") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "7").Sum(Function(x) x.TotalPagar)
    '                    rwDC("BONO JEFES CONVOY") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "8").Sum(Function(x) x.TotalPagar)

    '                    rwDC("HORAS EXTRAS") = rwDC("1CH012") + rwDC("1CH013") + rwDC("1CH014")
    '                    If oeAux.IdCentro = "1CH002" And oeAux.IdOcupacion = "1CH000000023" Then
    '                        rwDC("VUELTAS ADICIONALES LIMA") = rwDC("HORAS EXTRAS")
    '                        rwDC("HORAS EXTRAS") = 0
    '                    End If

    '                    rwDC("BANCO") = oeCtaCteAux.EntidadBancaria
    '                    rwDC("CUENTA") = oeCtaCteAux.NroCuenta
    '                    rwDC("GRATIF. 18.17%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 18.17 / 100
    '                    rwDC("VACAC. 8.33%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 8.33 / 100
    '                    rwDC("CTS. 8.33%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 8.33 / 100
    '                    rwDC("TOTAL APORTACIONES") = rwDC("GRATIF. 18.17%") + rwDC("VACAC. 8.33%") + rwDC("CTS. 8.33%") + rwDC("1SI032")
    '                    rwDC("TOTAL COSTO") = rwDC("TOTAL APORTACIONES") + rwDC("1SI007")
    '                    rwDC("VIATICOS LIMA") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "1").Sum(Function(x) x.TotalPagar)
    '                    rwDC("CALIZA SUSTENTO") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "2").Sum(Function(x) x.TotalPagar)
    '                    rwDC("ADM CAJA") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "3").Sum(Function(x) x.TotalPagar)
    '                    rwDC("PIURA") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "4").Sum(Function(x) x.TotalPagar)
    '                    rwDC("OTROS") = leDetPagCajTrab.Where(Function(x) x.Trabajador = oeAux.IdTrabajador And x.IndTipo = "5").Sum(Function(x) x.TotalPagar)
    '                    rwDC("TOTAL CAJAS") = rwDC("OTROS") + rwDC("PIURA") + rwDC("ADM CAJA") + rwDC("CALIZA SUSTENTO") + rwDC("VIATICOS LIMA")
    '                    rwDC("NETO RECIBIDO") = rwDC("TOTAL CAJAS") + rwDC("1SI022")

    '                End If
    '                dsDetCon.Rows.Add(rwDC)
    '            End If
    '        Next

    '        'ELIMINAR COLUMNAS 
    '        dsDetCon.Columns.Remove("IdDetallePlanilla")
    '        dsDetCon.Columns.Remove("IdTrabajador")
    '        dsDetCon.Columns.Remove("1CH012")
    '        dsDetCon.Columns.Remove("1CH013")
    '        dsDetCon.Columns.Remove("1CH014")

    '        Dim dtReporteFinal As DataTable = CrearDTReporteFinalPlanilla()
    '        Dim dr As DataRow
    '        For Each r In dsDetCon.Rows
    '            dr = dtReporteFinal.NewRow
    '            dr("DNI") = r("DNI")
    '            dr("TRABAJADOR") = r("Trabajador")
    '            dr("GERENCIA") = r("GERENCIA")
    '            dr("AREA") = r("AREA")
    '            dr("UNIDAD") = r("UNIDAD")
    '            dr("CARGO") = r("CARGO")
    '            dr("SECTOR") = r("SECTOR")
    '            dr("F. INGRESO") = r("F. INGRESO")
    '            dr("BASICO") = r("BASICO")
    '            dr("REMUNERACION") = r("1SI003")
    '            dr("ASIG_FAM") = r("1SI004")
    '            dr("REMUN_VAC") = r("1SI005")
    '            dr("CALIZA") = r("1CH002")
    '            dr("BONO_PROD") = r("1SI006")
    '            dr("SUBSIDIO") = r("1CH005")
    '            dr("HORAS_EXTRAS") = r("HORAS EXTRAS")
    '            dr("BONO COMBUSTIBLE PIURA") = r("BONO COMBUSTIBLE PIURA")
    '            dr("VUELTAS ADICIONALES PIURA") = r("VUELTAS ADICIONALES PIURA")
    '            dr("BONO JEFES CONVOY") = r("BONO JEFES CONVOY")
    '            dr("VUELTAS ADICIONALES LIMA") = r("VUELTAS ADICIONALES LIMA")
    '            dr("COMP_VAC") = r("1SI033")
    '            dr("BONO_RES") = r("1CH003")
    '            dr("DESC_MED") = r("1CH004")
    '            dr("SEMAFORO") = r("1CH016")
    '            dr("MOVILIDAD") = r("1CH017")
    '            dr("INGR_BRUTO") = r("1SI007")
    '            dr("APOR_OBLIG") = r("1SI008")
    '            dr("COMISI_AFP") = r("1SI009")
    '            dr("SEGURO_AFP") = r("1SI010")
    '            dr("ESSAL_VIDA") = r("1SI012")
    '            dr("RENTA5TA") = r("1SI016")
    '            dr("DSCTO_JUDI") = r("1SI019")
    '            dr("ADE_SUELDO") = r("1SI027")
    '            dr("ADEL_VAC") = r("1SI026")
    '            dr("DSCTO_EPS") = r("1SI025")
    '            dr("BIF") = r("1SI017")
    '            dr("SCOTIABANK") = r("1SI018")
    '            dr("DESC_FINAN") = r("1CH021")
    '            dr("PACIFICO") = r("1SI020")
    '            dr("RIMAC") = r("1SI021")
    '            dr("TOT_DSCTO") = r("1SI013")
    '            dr("TOTAL_NETO") = r("1SI022")
    '            dr("BANCO") = r("BANCO")
    '            dr("CUENTA") = r("CUENTA")
    '            dr("APORTE_SRS") = r("1SI024")
    '            dr("SCTR_SAL") = r("1SI030")
    '            dr("SENATI") = r("1CH020")
    '            dr("SCTR_PEN") = r("1SI031")
    '            dr("TOT_APORTE") = r("1SI032")
    '            dr("GRATIF. 18.17%") = r("GRATIF. 18.17%")
    '            dr("VACAC. 8.33%") = r("VACAC. 8.33%")
    '            dr("CTS. 8.33%") = r("CTS. 8.33%")
    '            dr("TOTAL APORTACIONES") = r("TOTAL APORTACIONES")
    '            dr("TOTAL COSTO") = r("TOTAL COSTO")
    '            dr("VIATICOS LIMA") = r("VIATICOS LIMA")
    '            dr("CALIZA SUSTENTO") = r("CALIZA SUSTENTO")
    '            dr("ADMINISTRAT. CAJA") = r("ADM CAJA")
    '            dr("PIURA") = r("PIURA")
    '            dr("OTROS") = r("OTROS")
    '            dr("TOTAL CAJAS") = r("TOTAL CAJAS")
    '            dr("NETO RECIBIDO") = r("NETO RECIBIDO")
    '            dtReporteFinal.Rows.Add(dr)
    '        Next
    '        gridReporteFinal.ResetDisplayLayout()
    '        gridReporteFinal.DataSource = dtReporteFinal
    '        ConfiguraGrilla(gridReporteFinal, "Tahoma", True, UIElementBorderStyle.Default)
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("TRABAJADOR").Width = 250
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("GERENCIA").Width = 150
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("AREA").Width = 150
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("UNIDAD").Width = 150
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("CARGO").Width = 150
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("BANCO").Width = 150
    '        gridReporteFinal.DisplayLayout.Bands(0).Columns("CUENTA").Width = 150
    '        FormatoColumna(gridReporteFinal, "#,##0.00", ColumnStyle.Double, HAlign.Right, "BASICO", "REMUNERACION", "ASIG_FAM", "REMUN_VAC", "CALIZA", "BONO_PROD", "SUBSIDIO" _
    '                       , "HORAS_EXTRAS", "BONO COMBUSTIBLE PIURA", "VUELTAS ADICIONALES PIURA", "BONO JEFES CONVOY", "VUELTAS ADICIONALES LIMA", "COMP_VAC", "BONO_RES", _
    '                       "DESC_MED", "SEMAFORO", "MOVILIDAD", "INGR_BRUTO", "APOR_OBLIG", "COMISI_AFP", "SEGURO_AFP", "ESSAL_VIDA", "RENTA5TA", "DSCTO_JUDI", "ADE_SUELDO" _
    '                       , "ADEL_VAC", "DSCTO_EPS", "BIF", "SCOTIABANK", "DESC_FINAN", "PACIFICO", "RIMAC", "TOT_DSCTO", "TOTAL_NETO", "APORTE_SRS", "SCTR_SAL", "SENATI" _
    '                       , "SCTR_PEN", "TOT_APORTE", "GRATIF. 18.17%", "VACAC. 8.33%", "CTS. 8.33%", "TOTAL APORTACIONES", "TOTAL COSTO", "VIATICOS LIMA", "CALIZA SUSTENTO" _
    '                       , "ADMINISTRAT. CAJA", "PIURA", "OTROS", "TOTAL CAJAS", "NETO RECIBIDO")
    '        ColorFondoColumna(gridReporteFinal, Color.Moccasin, "DNI", "TRABAJADOR", "GERENCIA", "AREA", "UNIDAD", "CARGO", "SECTOR", "F. INGRESO", "BASICO")
    '        ColorFondoColumna(gridReporteFinal, Color.LightCyan, "REMUNERACION", "ASIG_FAM", "REMUN_VAC", "CALIZA", "BONO_PROD", "SUBSIDIO" _
    '                       , "HORAS_EXTRAS", "BONO COMBUSTIBLE PIURA", "VUELTAS ADICIONALES PIURA", "BONO JEFES CONVOY", "VUELTAS ADICIONALES LIMA", "COMP_VAC", "BONO_RES", _
    '                       "DESC_MED", "SEMAFORO", "MOVILIDAD", "APOR_OBLIG", "COMISI_AFP", "SEGURO_AFP", "ESSAL_VIDA", "RENTA5TA", "DSCTO_JUDI", "ADE_SUELDO" _
    '                       , "ADEL_VAC", "DSCTO_EPS", "BIF", "SCOTIABANK", "DESC_FINAN", "PACIFICO", "RIMAC", "BANCO", "CUENTA", "APORTE_SRS", "SCTR_SAL", "SENATI" _
    '                       , "SCTR_PEN", "GRATIF. 18.17%", "VACAC. 8.33%", "CTS. 8.33%", "VIATICOS LIMA", "CALIZA SUSTENTO" _
    '                       , "ADMINISTRAT. CAJA", "PIURA", "OTROS", "TOTAL CAJAS")
    '        ColorFondoColumna(gridReporteFinal, Color.LightSkyBlue, "INGR_BRUTO", "TOT_DSCTO", "TOTAL_NETO", "TOT_APORTE", "TOTAL APORTACIONES", "TOTAL COSTO", "NETO RECIBIDO")
    '        CalcularTotales(gridReporteFinal, "INGR_BRUTO", "TOT_DSCTO", "TOTAL_NETO", "TOTAL APORTACIONES", "TOTAL COSTO", "NETO RECIBIDO")
    '        gridReporteFinal.DataBind()
    '        ExportarGrillaAExcel(gridReporteFinal, "ReporteFinalPlanilla-" + oePlanillaAux.Periodo.Trim)

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub tsmiReporteFinal_Click(sender As Object, e As EventArgs)
    '    Try
    '        Espere2.Visible = True
    '        Application.DoEvents()
    '        Cursor.Current = Cursors.WaitCursor
    '        Cursor.Show()

    '        Dim IdPlanilla As String = griPlanilla.ActiveRow.Cells("Id").Value

    '        GenerarReporteFinal(IdPlanilla)

    '    Catch ex As Exception
    '        Espere2.Visible = False
    '        mensajeEmergente.Problema(ex.Message, True)
    '    Finally
    '        Windows.Forms.Cursor.Current = Cursors.Default
    '        Cursor.Show()
    '        Espere2.Visible = False
    '    End Try

    'End Sub

   
End Class