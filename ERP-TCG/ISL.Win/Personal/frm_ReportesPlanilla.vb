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
Imports Microsoft.Office.Interop
Imports MSScriptControl
Imports System.Text
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Configuration
Imports System.Collections.Specialized

Public Class frm_ReportesPlanilla
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReportesPlanilla = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReportesPlanilla()
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
    Dim dtReporteFinal As DataTable
    Private oeAccionUsuario As New e_ActividadRestringida_Usuario
    Private _opePlanilla As String = "", _acl As String = "", _estado As String = ""

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(Activo As Boolean)
        Try
            oePeriodo = New e_Periodo
            oePeriodo = cboPeriodo.SelectedItem.ListObject

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Activo = True
            oePlanilla.Tipo = 0
            oePlanilla.IdPeriodo = oePeriodo.Id
            lePlanilla = olPlanilla.Listar(oePlanilla)
            Dim IdPlanilla As String = lePlanilla(0).Id

            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = ""
            oePlanilla.Id = IdPlanilla
            oePlanilla.IndCargaCompleto = True
            oePlanilla = olPlanilla.Obtener(oePlanilla)

            Select Case ficPlanilla.SelectedTab.Index
                Case 0
                    ListarPlanillaGeneral()
                    ListarReporteBanco()
                    ListarReporteNuevosIngresos()
                    ListarReporteIngresosConceptos()
                Case 1
                    ListarPlanillaGeneral()
                Case 2
                    ListarPlanillaGeneral()
                Case 3
                    ListarPlanillaGeneral()
            End Select
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Nuevo()
    End Sub

    Public Overrides Sub Editar()
    End Sub

    Public Overrides Sub Guardar()
    End Sub

    Public Overrides Sub Cancelar()
    End Sub

    Public Overrides Sub Eliminar()
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficPlanilla.SelectedTab.Index
                Case 0
                    If gridReporteFinal.Rows.Count > 0 Then
                        Exportar_Excel(gridReporteFinal, "ReportePlanilla")
                    Else
                        Throw New Exception("No hay Registros para Exportar")
                    End If
                Case 1
                    If gridBanco.Rows.Count > 0 Then
                        Exportar_Excel(gridBanco, "ReporteBanco")
                    Else
                        Throw New Exception("No hay Registros para Exportar")
                    End If
                Case 2
                    If griResumen.Rows.Count > 0 Then
                        Exportar_Excel(griResumen, "ReportePlanillaResumen")
                    Else
                        Throw New Exception("No hay Registros para Exportar")
                    End If
            End Select
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)

            '_acl = gAccionSistema.EXPORTAR.ToString
            'If ValidarAcl(_acl, pIdActividadNegocio) Then
            '    Select Case ficPlanilla.SelectedTab.Index
            '        Case 0
            '            If griPlanilla.Rows.Count > 0 Then
            '                Exportar_Excel(griPlanilla, "Planillas")
            '            Else
            '                Throw New Exception("No hay Registros para Exportar")
            '            End If
            '        Case 1
            '            Select Case ficDetalle.SelectedTab.Index
            '                Case 0
            '                    If griDetallePlanilla.Rows.Count > 0 Then
            '                        Exportar_Excel(griDetallePlanilla, "DetallePlanilla")
            '                    Else
            '                        Throw New Exception("No hay Registros para Exportar")
            '                    End If
            '                Case 1
            '                    If griDetalleConcepto.Rows.Count > 0 And chkReporteFinal.Checked Then
            '                        If chkReporteFinal.Checked Then
            '                            'reporte final
            '                            'generear el datatable

            '                            'ExportToExcel(datatable,ruta,ind_cabecera)
            '                        Else
            '                            Exportar_Excel(griDetalleConcepto, "Planilla")
            '                        End If
            '                    Else
            '                        Throw New Exception("No hay Registros para Exportar")
            '                    End If
            '            End Select
            '        Case 2
            '            If griImportar.Rows.Count > 0 Then
            '                Exportar_Excel(griImportar, "Datos Faltantes")
            '            Else
            '                Throw New Exception("No hay Registros para Exportar")
            '            End If
            '    End Select
            'Else
            '    Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_Planilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            CargarCombos()
            CargarDatos()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_Planilla_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
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

            'oeEstado = New e_Estado
            'oeEstado.Nombre = "PLANILLA"
            'leEstado = olEstado.Listar(oeEstado)
            'oeEstado = New e_Estado
            'oeEstado.Id = String.Empty
            'oeEstado.Nombre = "[TODOS]"
            'Dim _leEstadoAux As New List(Of e_Estado)
            '_leEstadoAux.Add(oeEstado)
            '_leEstadoAux.AddRange(leEstado)
            'LlenarCombo(cboEstadoBus, "Nombre", _leEstadoAux, 0)
            'LlenarCombo(cboEstado, "Nombre", leEstado, -1)

            'oeConfiguracion = New e_ConfiguracionPlanilla
            'oeConfiguracion.TipoOperacion = ""
            'oeConfiguracion.Activo = True
            'leConfiguracion = olConfiguracion.Listar(oeConfiguracion)
            'LlenarCombo(cboConfiguracion, "Nombre", leConfiguracion, -1)

            'oePlanilla = New e_Planilla
            'oePlanilla.TipoOperacion = ""
            'oePlanilla.Tipo = 0
            'oePlanilla.Activo = True
            'lePlanillaAux = olPlanilla.Listar(oePlanilla)
            'Dim _lePlaAux = lePlanillaAux.Where(Function(it) it.Estado = gNombreEstadoGenerada).OrderByDescending(Function(it) it.Codigo).ToList
            'LlenarCombo(cboPlanillaImportar, "Codigo", _lePlaAux, -1)

            'CargarDatos()

            'oeAsientoModel = New e_AsientoModelo
            'oeAsientoModel.TipoOperacion = "A" : oeAsientoModel.Activo = True : oeAsientoModel.Nombre = pIdActividadNegocio
            'leAsientoModel = olAsientoModel.Listar(oeAsientoModel)

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
            leCtaCte = olCtaCte.Listar(oeCtaCte)

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

    Private Sub ListarPlanillaGeneral()
        Try
            Espere2.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()

            'Dim IdPeriodo As String = cboPeriodo.Value
            'oePlanilla = New e_Planilla
            'oePlanilla.TipoOperacion = ""
            'oePlanilla.Activo = True
            'oePlanilla.Tipo = 0
            'oePlanilla.IdPeriodo = cboPeriodo.Value
            ''oePlanilla.IdEstado = cboEstadoBus.Value
            'lePlanilla = olPlanilla.Listar(oePlanilla)
            'Dim IdPlanilla As String = lePlanilla(0).Id
            GenerarReporteFinal()

        Catch ex As Exception
            Espere2.Visible = False
            Throw ex
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            Espere2.Visible = False
        End Try
    End Sub

    Private Sub ListarReporteBanco()
        GenerarReporteBanco()
    End Sub

    Private Sub ListarReporteNuevosIngresos()
        Dim oeOcupacionTra As New e_OcupacionTrabajador
        Dim olOcupacionTra As New l_OcupacionTrabajador
        Dim listaOcupacionTra As New List(Of e_OcupacionTrabajador)
        Dim _leOT01 As New List(Of e_OcupacionTrabajador)
        Dim _leOT02 As New List(Of e_OcupacionTrabajador)

        oeOcupacionTra.Id = ""
        oeOcupacionTra.IdTrabajador = ""
        oeOcupacionTra.IdOcupacion = ""
        oeOcupacionTra.Principal = -1
        oeOcupacionTra.Activo = True


        listaOcupacionTra = olOcupacionTra.Listar(oeOcupacionTra)

        'Dim IdPeriodo As String = cboPeriodo.Value
        'oePlanilla = New e_Planilla
        'oePlanilla.TipoOperacion = ""
        'oePlanilla.Activo = True
        'oePlanilla.Tipo = 0
        'oePlanilla.IdPeriodo = cboPeriodo.Value
        ''oePlanilla.IdEstado = cboEstadoBus.Value
        'lePlanilla = olPlanilla.Listar(oePlanilla)
        'Dim IdPlanilla As String = lePlanilla(0).Id

        'Dim oePlanillaAux As New e_Planilla
        'oePlanillaAux.TipoOperacion = ""
        'oePlanillaAux.Id = IdPlanilla
        'oePlanillaAux.IndCargaCompleto = True
        'oePlanillaAux = olPlanilla.Obtener(oePlanillaAux)
        ''GenerarReporteFinal(IdPlanilla)

        Dim dtnuevosIngresos As DataTable = CrearDTEstructuraNuevosIngresos()
        'Dim query = From row In dtReporteFinal Group row By BANCO = row.Field(Of String)("BANCO") Into MonthGroup = Group
        '            Select New With {
        '                .BANCO = BANCO,
        '                .MONTO = MonthGroup.Sum(Function(r) r.Field(Of Double)("TOTAL_NETO"))
        '           }

        Dim dr As DataRow
        For Each r In oePlanilla.leDetalle
            _leOT01 = listaOcupacionTra.Where(Function(it) it.IdTrabajador = r.IdTrabajador And it.FechaIngreso <= oePeriodo.FechaFin And it.FechaIngreso >= oePeriodo.FechaInicio).ToList

            For Each i In _leOT01
                _leOT02 = listaOcupacionTra.Where(Function(it) it.IdTrabajador = i.IdTrabajador And it.FechaIngreso <= i.FechaIngreso).ToList()

                If _leOT02.Count = 1 Then
                    'OBTENER SECCION
                    dr = dtnuevosIngresos.NewRow
                    dr("ZONA") = r.Centro
                    dr("AREA") = r.Area
                    dr("SECCION") = r.Ocupacion
                    dr("CARGO") = r.Ocupacion
                    dr("NOMBRES") = r.Trabajador
                    dtnuevosIngresos.Rows.Add(dr)
                End If
            Next

            
        Next

        griNuevosIngresos.ResetDisplayLayout()
        griNuevosIngresos.DataSource = dtnuevosIngresos
        ConfiguraGrilla(griNuevosIngresos, "Tahoma", True, UIElementBorderStyle.Default)
        griNuevosIngresos.DisplayLayout.Bands(0).Columns("ZONA").Width = 250
        griNuevosIngresos.DisplayLayout.Bands(0).Columns("AREA").Width = 250
        griNuevosIngresos.DisplayLayout.Bands(0).Columns("SECCION").Width = 250
        griNuevosIngresos.DisplayLayout.Bands(0).Columns("CARGO").Width = 250
        griNuevosIngresos.DisplayLayout.Bands(0).Columns("NOMBRES").Width = 250
        griNuevosIngresos.DataBind()

    End Sub

    Private Sub ListarReporteIngresosConceptos()
        

        Dim dtIngresos As DataTable = CrearDTEstructuraIngresosConceptos()
        'Dim query = From row In dtReporteFinal Group row By BANCO = row.Field(Of String)("BANCO") Into MonthGroup = Group
        '            Select New With {
        '                .BANCO = BANCO,
        '                .MONTO = MonthGroup.Sum(Function(r) r.Field(Of Double)("TOTAL_NETO"))
        '           }

        Dim dr As DataRow
        For Each r In oePlanilla.leDetalle
            dr = dtIngresos.NewRow
            dr("NOMBRES") = r.Trabajador
            dr("AÑO") = oePeriodo.Ejercicio
            dr("MES") = oePeriodo.Mes
            dr("ZONA") = r.Centro
            dr("AREA") = r.Area
            dr("SECCION") = r.IdOcupacion
            dr("CARGO") = r.Ocupacion
            dr("CONCEPTO") = "Sueldo Bruto"
            dr("MONTO") = r.Ingresos
            dtIngresos.Rows.Add(dr)
        Next

        Dim oePagoCajaTrabajador As New e_PagoCajaTrabajador, olPagoCajaTrabajador As New l_PagoCajaTrabajador
        Dim lePagoCajaTrabajador As New List(Of e_PagoCajaTrabajador)
        Dim oeDetPagCajTrab As New e_DetallePagoCajaTrabajador
        Dim leDetPagCajTrab As New List(Of e_DetallePagoCajaTrabajador)
        Dim oeTrabajadorAux As New e_Trabajador
        Dim oeSueldoAux As New e_SueldoTrabajador
        Dim oeCtaCteAux As New e_CuentaCtePersonal

        oePagoCajaTrabajador.TipoOperacion = ""
        oePagoCajaTrabajador.IdPlanilla = oePlanilla.Id
        oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
        leDetPagCajTrab = oePagoCajaTrabajador.leDetalle

        Dim Directorio As Double = 0
        Dim ViaticoLima As Double = 0
        Dim AdmCaja As Double = 0
        Dim BonoCaliza As Double = 0
        Dim Otros As Double = 0

        For Each r In oePlanilla.leDetalle
            ViaticoLima = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = r.IdTrabajador And x.IndTipo = "2").Sum(Function(x) x.TotalPagar)
            BonoCaliza = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = r.IdTrabajador And x.IndTipo = "3").Sum(Function(x) x.TotalPagar)
            AdmCaja = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = r.IdTrabajador And x.IndTipo = "4").Sum(Function(x) x.TotalPagar)
            Directorio = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = r.IdTrabajador And x.IndTipo = "1").Sum(Function(x) x.TotalPagar)
            Otros = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = r.IdTrabajador And x.IndTipo = "8").Sum(Function(x) x.TotalPagar)

            If ViaticoLima > 0 Then
                dr = dtIngresos.NewRow
                dr("NOMBRES") = r.Trabajador
                dr("AÑO") = oePeriodo.Ejercicio
                dr("MES") = oePeriodo.Mes
                dr("ZONA") = r.Centro
                dr("AREA") = r.Area
                dr("SECCION") = r.IdOcupacion
                dr("CARGO") = r.Ocupacion
                dr("CONCEPTO") = "Viatico Lima"
                dr("MONTO") = ViaticoLima
                dtIngresos.Rows.Add(dr)
            End If
            If BonoCaliza > 0 Then
                dr = dtIngresos.NewRow
                dr("NOMBRES") = r.Trabajador
                dr("AÑO") = oePeriodo.Ejercicio
                dr("MES") = oePeriodo.Mes
                dr("ZONA") = r.Centro
                dr("AREA") = r.Area
                dr("SECCION") = r.IdOcupacion
                dr("CARGO") = r.Ocupacion
                dr("CONCEPTO") = "Caliza Sustento"
                dr("MONTO") = BonoCaliza
                dtIngresos.Rows.Add(dr)
            End If
            If AdmCaja > 0 Then
                dr = dtIngresos.NewRow
                dr("NOMBRES") = r.Trabajador
                dr("AÑO") = oePeriodo.Ejercicio
                dr("MES") = oePeriodo.Mes
                dr("ZONA") = r.Centro
                dr("AREA") = r.Area
                dr("SECCION") = r.IdOcupacion
                dr("CARGO") = r.Ocupacion
                dr("CONCEPTO") = "Administratico Caja"
                dr("MONTO") = AdmCaja
                dtIngresos.Rows.Add(dr)
            End If
            If Directorio > 0 Then
                dr = dtIngresos.NewRow
                dr("NOMBRES") = r.Trabajador
                dr("AÑO") = oePeriodo.Ejercicio
                dr("MES") = oePeriodo.Mes
                dr("ZONA") = r.Centro
                dr("AREA") = r.Area
                dr("SECCION") = r.IdOcupacion
                dr("CARGO") = r.Ocupacion
                dr("CONCEPTO") = "Directorio"
                dr("MONTO") = Directorio
                dtIngresos.Rows.Add(dr)
            End If
            If Otros > 0 Then
                dr = dtIngresos.NewRow
                dr("NOMBRES") = r.Trabajador
                dr("AÑO") = oePeriodo.Ejercicio
                dr("MES") = oePeriodo.Mes
                dr("ZONA") = r.Centro
                dr("AREA") = r.Area
                dr("SECCION") = r.IdOcupacion
                dr("CARGO") = r.Ocupacion
                dr("CONCEPTO") = "Otros"
                dr("MONTO") = Otros
                dtIngresos.Rows.Add(dr)
            End If
        Next

        griIngresosConceptos.ResetDisplayLayout()
        griIngresosConceptos.DataSource = dtIngresos
        ConfiguraGrilla(griIngresosConceptos, "Tahoma", True, UIElementBorderStyle.Default)
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("NOMBRES").Width = 250
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("AÑO").Width = 40
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("MES").Width = 30
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("ZONA").Width = 100
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("AREA").Width = 250
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("SECCION").Width = 250
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("CARGO").Width = 250
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("CONCEPTO").Width = 250
        griIngresosConceptos.DisplayLayout.Bands(0).Columns("MONTO").Width = 80
        FormatoColumna(gridReporteFinal, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Monto")
        griIngresosConceptos.DataBind()

    End Sub

    Private Function CrearDT(ls_IdConfiguracion As String) As System.Data.DataTable
        Dim DetCon As New Data.DataTable
        With DetCon

            .Columns.Add(New Data.DataColumn("IdDetallePlanilla", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("IdTrabajador", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("DNI", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Trabajador", Type.GetType("System.String")))

            leDetConPlaAux = New List(Of e_DetalleConfiguracionPlanilla)
            leDetConPlaAux = leDetalleConPla.Where(Function(it) it.IdConfiguracionPlanilla = ls_IdConfiguracion).OrderBy(Function(it) it.NroOrden).ToList
            For Each oeDetAux In leDetConPlaAux
                .Columns.Add(New Data.DataColumn(oeDetAux.IdAporteDescuento, Type.GetType("System.Double")))
                .Columns(oeDetAux.IdAporteDescuento).Caption = oeDetAux.Abreviatura
            Next
        End With
        Return DetCon
    End Function

    Private Sub GenerarReporteFinal()
        Try
            Dim oePagoCajaTrabajador As New e_PagoCajaTrabajador, olPagoCajaTrabajador As New l_PagoCajaTrabajador
            Dim lePagoCajaTrabajador As New List(Of e_PagoCajaTrabajador)
            Dim oeDetPagCajTrab As New e_DetallePagoCajaTrabajador
            Dim leDetPagCajTrab As New List(Of e_DetallePagoCajaTrabajador)
            Dim oeTrabajadorAux As New e_Trabajador
            Dim oeSueldoAux As New e_SueldoTrabajador
            Dim oeCtaCteAux As New e_CuentaCtePersonal
            'Dim oePlanillaAux As New e_Planilla
            'oePlanillaAux.TipoOperacion = ""
            'oePlanillaAux.Id = IdPlanilla
            'oePlanillaAux.IndCargaCompleto = True
            'oePlanillaAux = olPlanilla.Obtener(oePlanillaAux)

            oePagoCajaTrabajador.TipoOperacion = ""
            oePagoCajaTrabajador.IdPlanilla = oePlanilla.Id
            oePagoCajaTrabajador = olPagoCajaTrabajador.Obtener(oePagoCajaTrabajador)
            leDetPagCajTrab = oePagoCajaTrabajador.leDetalle

            Dim dsDetCon As Data.DataTable = CrearDT(oePlanilla.IdConfiguracion)
            'agregar columnas adicionales
            With dsDetCon
                .Columns.Add(New Data.DataColumn("GERENCIA", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("AREA", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("UNIDAD", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("CARGO", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("SECTOR", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("F. INGRESO", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("BASICO", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("BONO COMBUSTIBLE PIURA", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES PIURA", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("BONO JEFES CONVOY", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("VUELTAS ADICIONALES LIMA", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("BANCO", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("CUENTA", Type.GetType("System.String")))
                .Columns.Add(New Data.DataColumn("GRATIF. 18.17%", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("VACAC. 8.33%", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("CTS. 8.33%", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("TOTAL APORTACIONES", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("TOTAL COSTO", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("VIATICOS LIMA", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("CALIZA SUSTENTO", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("ADM CAJA", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("DIRECTORIO", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("OTROS", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("TOTAL CAJAS", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("NETO RECIBIDO", Type.GetType("System.Double")))
                .Columns.Add(New Data.DataColumn("HORAS EXTRAS", Type.GetType("System.Double")))
            End With

            Dim _leDC As New List(Of e_DetalleConcepto)
            Dim _idTrabAux As String = ""
            Dim IdAreaAux As String = ""
            Dim rwDC As Data.DataRow

            For Each oeAux In oePlanilla.leDetalle.OrderBy(Function(it) it.Trabajador).ToList
                If _idTrabAux <> oeAux.IdTrabajador Then
                    _idTrabAux = oeAux.IdTrabajador
                    rwDC = dsDetCon.NewRow
                    rwDC("IdDetallePlanilla") = oeAux.Id
                    rwDC("IdTrabajador") = oeAux.IdTrabajador
                    oeTrabajadorAux = New e_Trabajador
                    oeTrabajadorAux.TipoBusca = 1 : oeTrabajadorAux.Id = oeAux.IdTrabajador
                    If leTrabajador.Contains(oeTrabajadorAux) Then
                        oeTrabajadorAux = leTrabajador.Item(leTrabajador.IndexOf(oeTrabajadorAux))
                        oeSueldoAux = New e_SueldoTrabajador
                        oeSueldoAux.Equivale = 1 : oeSueldoAux.IdTrabajador = oeAux.IdTrabajador
                        If leSueldo.Contains(oeSueldoAux) Then oeSueldoAux = leSueldo.Item(leSueldo.IndexOf(oeSueldoAux))
                        oeCtaCteAux = New e_CuentaCtePersonal
                        oeCtaCteAux.Equivale = 3 : oeCtaCteAux.IdTrabajador = oeAux.IdTrabajador
                        If leCtaCte.Contains(oeCtaCteAux) Then oeCtaCteAux = leCtaCte.Item(leCtaCte.IndexOf(oeCtaCteAux))

                        rwDC("Trabajador") = oeTrabajadorAux.oePersona.NombreCompleto
                        rwDC("DNI") = oeTrabajadorAux.oePersona.Dni

                        For Each oeDCP In leDetConPlaAux
                            _leDC = oePlanilla.leDetalleConcepto.Where(Function(it) it.IdTrabajador = _idTrabAux And it.IdAporteDescuento = oeDCP.IdAporteDescuento).ToList
                            If _leDC.Count > 0 Then
                                rwDC(oeDCP.IdAporteDescuento) = _leDC(0).Importe
                            Else
                                rwDC(oeDCP.IdAporteDescuento) = 0
                            End If
                        Next

                        'agregar datos adicionales  

                        Dim oeAreaAux As New e_Area
                        oeAreaAux.Id = oeAux.IdArea
                        oeAreaAux.Equivale = 1
                        If leArea.Contains(oeAreaAux) Then oeAreaAux = leArea.Item(leArea.IndexOf(oeAreaAux))
                        rwDC("AREA") = oeAreaAux.Sector
                        IdAreaAux = oeAreaAux.IdSector
                        oeAreaAux = New e_Area
                        oeAreaAux.Id = IdAreaAux
                        oeAreaAux.Equivale = 1
                        If leArea.Contains(oeAreaAux) Then oeAreaAux = leArea.Item(leArea.IndexOf(oeAreaAux))
                        rwDC("GERENCIA") = oeAreaAux.Gerencia
                        rwDC("UNIDAD") = oeAux.Area
                        rwDC("CARGO") = oeAux.Ocupacion
                        rwDC("SECTOR") = oeAux.Centro
                        rwDC("F. INGRESO") = oeTrabajadorAux.FechaIngreso.ToShortDateString
                        rwDC("BASICO") = oeSueldoAux.Sueldo



                        Dim BonoCombustible As Double = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "9").Sum(Function(x) x.TotalPagar)
                        Dim VueltasPiura As Double = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "10").Sum(Function(x) x.TotalPagar)
                        Dim BonoJefe As Double = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "11").Sum(Function(x) x.TotalPagar)


                        'caliza
                        'bono produccion
                        If rwDC("1CH002") >= (BonoCombustible + VueltasPiura + BonoJefe) Then
                            rwDC("1CH002") = rwDC("1CH002") - (BonoCombustible + VueltasPiura + BonoJefe)
                        ElseIf rwDC("1SI006") >= (BonoCombustible + VueltasPiura + BonoJefe) Then
                            rwDC("1SI006") = rwDC("1SI006") - (BonoCombustible + VueltasPiura + BonoJefe)
                        End If

                        rwDC("BONO COMBUSTIBLE PIURA") = BonoCombustible
                        rwDC("VUELTAS ADICIONALES PIURA") = VueltasPiura
                        rwDC("BONO JEFES CONVOY") = BonoJefe

                        rwDC("HORAS EXTRAS") = rwDC("1CH012") + rwDC("1CH013") + rwDC("1CH014")
                        If oeAux.IdCentro = "1CH002" And oeAux.IdOcupacion = "1CH000000023" Then
                            rwDC("VUELTAS ADICIONALES LIMA") = rwDC("HORAS EXTRAS")
                            rwDC("HORAS EXTRAS") = 0
                        End If

                        rwDC("BANCO") = oeCtaCteAux.EntidadBancaria
                        rwDC("CUENTA") = oeCtaCteAux.NroCuenta
                        rwDC("GRATIF. 18.17%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 18.17 / 100
                        rwDC("VACAC. 8.33%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 8.33 / 100
                        rwDC("CTS. 8.33%") = (rwDC("1SI007") - rwDC("1CH016") - rwDC("1CH017")) * 8.33 / 100
                        rwDC("TOTAL APORTACIONES") = rwDC("GRATIF. 18.17%") + rwDC("VACAC. 8.33%") + rwDC("CTS. 8.33%") + rwDC("1SI032")
                        rwDC("TOTAL COSTO") = rwDC("TOTAL APORTACIONES") + rwDC("1SI007")
                        rwDC("VIATICOS LIMA") = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "2").Sum(Function(x) x.TotalPagar)
                        rwDC("CALIZA SUSTENTO") = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "3").Sum(Function(x) x.TotalPagar)
                        rwDC("ADM CAJA") = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "4").Sum(Function(x) x.TotalPagar)
                        rwDC("DIRECTORIO") = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "1").Sum(Function(x) x.TotalPagar)
                        rwDC("OTROS") = leDetPagCajTrab.Where(Function(x) x.IdTrabajador = oeAux.IdTrabajador And x.IndTipo = "8").Sum(Function(x) x.TotalPagar)
                        rwDC("TOTAL CAJAS") = rwDC("OTROS") + rwDC("DIRECTORIO") + rwDC("ADM CAJA") + rwDC("CALIZA SUSTENTO") + rwDC("VIATICOS LIMA")
                        rwDC("NETO RECIBIDO") = rwDC("TOTAL CAJAS") + rwDC("1SI022")

                    End If
                    dsDetCon.Rows.Add(rwDC)
                End If
            Next

            'ELIMINAR COLUMNAS 
            dsDetCon.Columns.Remove("IdDetallePlanilla")
            dsDetCon.Columns.Remove("IdTrabajador")
            dsDetCon.Columns.Remove("1CH012")
            dsDetCon.Columns.Remove("1CH013")
            dsDetCon.Columns.Remove("1CH014")

            dtReporteFinal = CrearDTReporteFinalPlanilla()
            Dim dr As DataRow
            For Each r In dsDetCon.Rows
                dr = dtReporteFinal.NewRow
                dr("DNI") = r("DNI")
                dr("TRABAJADOR") = r("Trabajador")
                dr("GERENCIA") = r("GERENCIA")
                dr("AREA") = r("AREA")
                dr("UNIDAD") = r("UNIDAD")
                dr("CARGO") = r("CARGO")
                dr("SECTOR") = r("SECTOR")
                dr("F. INGRESO") = r("F. INGRESO")
                dr("BASICO") = r("BASICO")
                dr("REMUNERACION") = r("1SI003")
                dr("ASIG_FAM") = r("1SI004")
                dr("REMUN_VAC") = r("1SI005")
                dr("CALIZA") = r("1CH002")
                dr("BONO_PROD") = r("1SI006")
                dr("SUBSIDIO") = r("1CH005")
                dr("HORAS_EXTRAS") = r("HORAS EXTRAS")
                dr("BONO COMBUSTIBLE PIURA") = r("BONO COMBUSTIBLE PIURA")
                dr("VUELTAS ADICIONALES PIURA") = r("VUELTAS ADICIONALES PIURA")
                dr("BONO JEFES CONVOY") = r("BONO JEFES CONVOY")
                dr("VUELTAS ADICIONALES LIMA") = r("VUELTAS ADICIONALES LIMA")
                dr("COMP_VAC") = r("1SI033")
                dr("BONO_RES") = r("1CH003")
                dr("DESC_MED") = r("1CH004")
                dr("SEMAFORO") = r("1CH016")
                dr("MOVILIDAD") = r("1CH017")
                dr("INGR_BRUTO") = r("1SI007")
                dr("APOR_OBLIG") = r("1SI008")
                dr("COMISI_AFP") = r("1SI009")
                dr("SEGURO_AFP") = r("1SI010")
                dr("ESSAL_VIDA") = r("1SI012")
                dr("RENTA5TA") = r("1SI016")
                dr("DSCTO_JUDI") = r("1SI019")
                dr("ADE_SUELDO") = r("1SI027")
                dr("ADEL_VAC") = r("1SI026")
                dr("DSCTO_EPS") = r("1SI025")
                dr("BIF") = r("1SI017")
                dr("SCOTIABANK") = r("1SI018")
                dr("DESC_FINAN") = r("1CH021")
                dr("PACIFICO") = r("1SI020")
                dr("RIMAC") = r("1SI021")
                dr("TOT_DSCTO") = r("1SI013")
                dr("TOTAL_NETO") = r("1SI022")
                dr("BANCO") = r("BANCO")
                dr("CUENTA") = r("CUENTA")
                dr("APORTE_SRS") = r("1SI024")
                dr("SCTR_SAL") = r("1SI030")
                dr("SENATI") = r("1CH020")
                dr("SCTR_PEN") = r("1SI031")
                dr("TOT_APORTE") = r("1SI032")
                dr("GRATIF. 18.17%") = r("GRATIF. 18.17%")
                dr("VACAC. 8.33%") = r("VACAC. 8.33%")
                dr("CTS. 8.33%") = r("CTS. 8.33%")
                dr("TOTAL APORTACIONES") = r("TOTAL APORTACIONES")
                dr("TOTAL COSTO") = r("TOTAL COSTO")
                dr("VIATICOS LIMA") = r("VIATICOS LIMA")
                dr("CALIZA SUSTENTO") = r("CALIZA SUSTENTO")
                dr("ADMINISTRAT. CAJA") = r("ADM CAJA")
                dr("DIRECTORIO") = r("DIRECTORIO")
                dr("OTROS") = r("OTROS")
                dr("TOTAL CAJAS") = r("TOTAL CAJAS")
                dr("NETO RECIBIDO") = r("NETO RECIBIDO")
                dtReporteFinal.Rows.Add(dr)
            Next
            gridReporteFinal.ResetDisplayLayout()
            gridReporteFinal.DataSource = dtReporteFinal
            ConfiguraGrilla(gridReporteFinal, "Tahoma", True, UIElementBorderStyle.Default)
            gridReporteFinal.DisplayLayout.Bands(0).Columns("TRABAJADOR").Width = 250
            gridReporteFinal.DisplayLayout.Bands(0).Columns("GERENCIA").Width = 150
            gridReporteFinal.DisplayLayout.Bands(0).Columns("AREA").Width = 150
            gridReporteFinal.DisplayLayout.Bands(0).Columns("UNIDAD").Width = 150
            gridReporteFinal.DisplayLayout.Bands(0).Columns("CARGO").Width = 150
            gridReporteFinal.DisplayLayout.Bands(0).Columns("BANCO").Width = 150
            gridReporteFinal.DisplayLayout.Bands(0).Columns("CUENTA").Width = 150
            FormatoColumna(gridReporteFinal, "#,##0.00", ColumnStyle.Double, HAlign.Right, "BASICO", "REMUNERACION", "ASIG_FAM", "REMUN_VAC", "CALIZA", "BONO_PROD", "SUBSIDIO" _
                           , "HORAS_EXTRAS", "BONO COMBUSTIBLE PIURA", "VUELTAS ADICIONALES PIURA", "BONO JEFES CONVOY", "VUELTAS ADICIONALES LIMA", "COMP_VAC", "BONO_RES", _
                           "DESC_MED", "SEMAFORO", "MOVILIDAD", "INGR_BRUTO", "APOR_OBLIG", "COMISI_AFP", "SEGURO_AFP", "ESSAL_VIDA", "RENTA5TA", "DSCTO_JUDI", "ADE_SUELDO" _
                           , "ADEL_VAC", "DSCTO_EPS", "BIF", "SCOTIABANK", "DESC_FINAN", "PACIFICO", "RIMAC", "TOT_DSCTO", "TOTAL_NETO", "APORTE_SRS", "SCTR_SAL", "SENATI" _
                           , "SCTR_PEN", "TOT_APORTE", "GRATIF. 18.17%", "VACAC. 8.33%", "CTS. 8.33%", "TOTAL APORTACIONES", "TOTAL COSTO", "VIATICOS LIMA", "CALIZA SUSTENTO" _
                           , "ADMINISTRAT. CAJA", "DIRECTORIO", "OTROS", "TOTAL CAJAS", "NETO RECIBIDO")
            ColorFondoColumna(gridReporteFinal, Color.Moccasin, "DNI", "TRABAJADOR", "GERENCIA", "AREA", "UNIDAD", "CARGO", "SECTOR", "F. INGRESO", "BASICO")
            ColorFondoColumna(gridReporteFinal, Color.LightCyan, "REMUNERACION", "ASIG_FAM", "REMUN_VAC", "CALIZA", "BONO_PROD", "SUBSIDIO" _
                           , "HORAS_EXTRAS", "BONO COMBUSTIBLE PIURA", "VUELTAS ADICIONALES PIURA", "BONO JEFES CONVOY", "VUELTAS ADICIONALES LIMA", "COMP_VAC", "BONO_RES", _
                           "DESC_MED", "SEMAFORO", "MOVILIDAD", "APOR_OBLIG", "COMISI_AFP", "SEGURO_AFP", "ESSAL_VIDA", "RENTA5TA", "DSCTO_JUDI", "ADE_SUELDO" _
                           , "ADEL_VAC", "DSCTO_EPS", "BIF", "SCOTIABANK", "DESC_FINAN", "PACIFICO", "RIMAC", "BANCO", "CUENTA", "APORTE_SRS", "SCTR_SAL", "SENATI" _
                           , "SCTR_PEN", "GRATIF. 18.17%", "VACAC. 8.33%", "CTS. 8.33%", "VIATICOS LIMA", "CALIZA SUSTENTO" _
                           , "ADMINISTRAT. CAJA", "DIRECTORIO", "OTROS", "TOTAL CAJAS")
            ColorFondoColumna(gridReporteFinal, Color.LightSkyBlue, "INGR_BRUTO", "TOT_DSCTO", "TOTAL_NETO", "TOT_APORTE", "TOTAL APORTACIONES", "TOTAL COSTO", "NETO RECIBIDO")
            CalcularTotales(gridReporteFinal, "INGR_BRUTO", "TOT_DSCTO", "TOTAL_NETO", "TOTAL APORTACIONES", "TOTAL COSTO", "NETO RECIBIDO")
            gridReporteFinal.DataBind()
            'ExportarGrillaAExcel(gridReporteFinal, "ReporteFinalPlanilla-" + oePlanillaAux.Periodo.Trim)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarReporteBanco()
        Try
            Dim dtBanco As DataTable = CrearDTEstructuraBanco()
            Dim query = From row In dtReporteFinal Group row By BANCO = row.Field(Of String)("BANCO") Into MonthGroup = Group
                        Select New With {
                            .BANCO = BANCO,
                            .MONTO = MonthGroup.Sum(Function(r) r.Field(Of Double)("TOTAL_NETO"))
                       }

            ' Dim query = From row In dtReporteFinal Group row By TipoDocumento = row, DNI = row.Dni, CodigoSunat = row.CodigoSunat Into PlameGroup = Group
            ' Select New With {
            '     .TipoDocumento = TipoDocumento,
            '     .DNI = DNI,
            '     .CodigoSunat = CodigoSunat,
            '     .Devengado = PlameGroup.Sum(Function(r) r.Devengado),
            '     .Pagado = PlameGroup.Sum(Function(r) r.Pagado)
            '}

            'Dim query = From row In dtReporteFinal Select row.Field(Of String)("BANCO") Distinct


            Dim dr As DataRow
            For Each r In query
                dr = dtBanco.NewRow
                dr("BANCO") = r.BANCO
                dr("MONTO") = r.MONTO
                dtBanco.Rows.Add(dr)
            Next
            gridBanco.ResetDisplayLayout()
            gridBanco.DataSource = dtBanco
            ConfiguraGrilla(gridBanco, "Tahoma", True, UIElementBorderStyle.Default)
            gridBanco.DisplayLayout.Bands(0).Columns("BANCO").Width = 250
            gridBanco.DisplayLayout.Bands(0).Columns("MONTO").Width = 150
            FormatoColumna(gridBanco, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MONTO")
            CalcularTotales(gridBanco, "MONTO")
            gridBanco.DataBind()
            'ExportarGrillaAExcel(gridReporteFinal, "ReporteFinalPlanilla-" + oePlanillaAux.Periodo.Trim)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function CrearDTEstructuraBanco() As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("BANCO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MONTO", Type.GetType("System.Double")))
        End With
        Return dtStruc
    End Function

    Public Function CrearDTEstructuraNuevosIngresos() As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("ZONA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AREA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SECCION", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CARGO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("NOMBRES", Type.GetType("System.String")))
        End With
        Return dtStruc
    End Function

    Public Function CrearDTEstructuraIngresosConceptos() As Data.DataTable
        Dim dtStruc As New Data.DataTable
        With dtStruc
            .Columns.Add(New Data.DataColumn("NOMBRES", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AÑO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MES", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("ZONA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("AREA", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("SECCION", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CARGO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("CONCEPTO", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("MONTO", Type.GetType("System.Double")))
        End With
        Return dtStruc
    End Function

#End Region

    

    


End Class
