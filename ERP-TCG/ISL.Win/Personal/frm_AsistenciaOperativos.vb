'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Infragistics.Win

Public Class frm_AsistenciaOperativos
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_AsistenciaOperativos = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_AsistenciaOperativos()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Private oePeriodo As e_Periodo, olPeriodo As l_Periodo, leEjercicio As List(Of e_Periodo), lePeriodo As List(Of e_Periodo)
    Private oePlanilla As e_Planilla, olPlanilla As l_Planilla, lePlanilla As List(Of e_Planilla)
    Private oeAsistencia As e_ResumenAsistencia, olAsistencia As l_ResumenAsistencia, leAsistencia As List(Of e_ResumenAsistencia)
    Private oeTrabajador As e_Trabajador, olTrabajador As l_Trabajador, leTrabajador As List(Of e_Trabajador)
    Private oeOcupacion As e_OcupacionTrabajador, olOcupacion As l_OcupacionTrabajador, leOcupacion As List(Of e_OcupacionTrabajador)
    Private oeCentro As e_Centro, olCentro As l_Centro, leCentro As List(Of e_Centro)
    Private ldInicio As Date = #1/1/1901#, ldFin As Date = #1/1/1901#
    Private dsAsistencia As DataTable
    Private Prefijo As l_Configuracion

#End Region

#Region "Botones"

    Public Overrides Sub Consultar(Activo As Boolean)
        'Try
        '    Dim rwDC As Data.DataRow
        '    Dim _leTrab As New List(Of e_Trabajador)
        '    Dim ldFechaActual As Date = ObtenerFechaServidor()
        '    Dim ldLimite As Date = #1/1/1901#
        '    Dim lnFalta As Integer = 0, lnAsistencia As Integer = 0, lnDescanso As Integer = 0, lnVacaciones As Integer = 0, lnDomingo As Integer = 0
        '    _leTrab.AddRange(leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 And it.FechaIngreso <= ldFin And it.IdCentro = cboSede.Value).ToList)
        '    _leTrab.AddRange(leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado <> 1 And it.IndTipo = 0 And it.FechaIngreso <= ldFin And it.IdCentro = cboSede.Value _
        '                                            And it.FechaCese <> #1/1/1901# And it.FechaCese > ldInicio).ToList)
        '    dsAsistencia.Rows.Clear()
        '    For Each _oeTrab In _leTrab.OrderBy(Function(it) it.oePersona.NombreCompleto)
        '        rwDC = dsAsistencia.NewRow
        '        rwDC("Dni") = _oeTrab.oePersona.Dni
        '        rwDC("Trabajador") = _oeTrab.oePersona.NombreCompleto
        '        rwDC("Cargo") = _oeTrab.oeOcupacion.Nombre
        '        rwDC("FechaInicio") = _oeTrab.FechaIngreso
        '        rwDC("FechaCese") = _oeTrab.FechaCese
        '        If ldFin.Year = ldFechaActual.Year And ldFin.Month = ldFechaActual.Month Then
        '            ldLimite = ldFechaActual
        '        Else
        '            ldLimite = ldFin
        '        End If
        '        lnAsistencia = 0 : lnDomingo = 0
        '        For i = 1 To ldLimite.Day
        '            If Weekday(Date.Parse(i & "/" & ldLimite.Month & "/" & ldLimite.Year)) <> 1 Then
        '                rwDC("X" & i) = "A"
        '            Else
        '                rwDC("X" & i) = String.Empty : lnDomingo = lnDomingo + 1
        '            End If
        '        Next
        '        lnFalta = 0
        '        For Each _oeFalta In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 0 And it.CodigoSuspension <> "").ToList
        '            For i = _oeFalta.FechaInicio.Day To _oeFalta.FechaTermino.Day
        '                rwDC("X" & i) = "F" : lnFalta = lnFalta + 1
        '            Next
        '        Next
        '        For Each _oeOtros In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 0 And it.CodigoSuspension = "" And it.IndTipoAux = 0).ToList
        '            For i = _oeOtros.FechaInicio.Day To _oeOtros.FechaTermino.Day
        '                If _oeOtros.Observacion.ToUpper.Contains("INGRESO") Then
        '                    rwDC("X" & i) = "I"
        '                ElseIf _oeOtros.Observacion.ToUpper.Contains("CESE") Then
        '                    If _oeTrab.FechaCese = #1/1/1901# Then rwDC("X" & i) = "I" Else rwDC("X" & i) = "C"
        '                Else
        '                    rwDC("X" & i) = "F" : lnFalta = lnFalta + 1
        '                End If
        '            Next
        '        Next
        '        lnDescanso = 0
        '        For Each _oeDescanso In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 1 And it.CodigoSuspension <> "").ToList
        '            For i = _oeDescanso.FechaInicio.Day To _oeDescanso.FechaTermino.Day
        '                rwDC("X" & i) = "D" : lnDescanso = lnDescanso + 1
        '            Next
        '        Next
        '        lnVacaciones = 0
        '        For Each _oeVaciones In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 2 And it.IndTipoAux = 0).ToList
        '            For i = _oeVaciones.FechaInicio.Day To _oeVaciones.FechaTermino.Day
        '                rwDC("X" & i) = "V" : lnVacaciones = lnVacaciones + 1
        '            Next
        '        Next
        '        For i = 1 To ldLimite.Day
        '            If rwDC("X" & i) = "A" Then lnAsistencia = lnAsistencia + 1
        '        Next
        '        rwDC("Asistencia") = lnAsistencia
        '        rwDC("Inasistencia") = lnFalta
        '        dsAsistencia.Rows.Add(rwDC)
        '    Next
        '    OcultarColumna(griAsistencia, False, "X28", "X29", "X30", "X31")
        '    If ldFin.Day < 31 Then
        '        For i = 31 To (ldFin.Day + 1) Step -1
        '            OcultarColumna(griAsistencia, True, "X" & i)
        '        Next
        '    End If
        '    griAsistencia.DataBind()
        '    For Each fil In griAsistencia.Rows
        '        For Each cel In fil.Cells
        '            If cel.Column.Key.Contains("X") And Not IsDBNull(cel.Value) Then
        '                If cel.Value = "F" Then cel.Appearance.ForeColor = colorFalta.Color : cel.Appearance.BackColor = colorFalta.Color
        '                If cel.Value = "D" Then cel.Appearance.ForeColor = colorDescanso.Color : cel.Appearance.BackColor = colorDescanso.Color
        '                If cel.Value = "V" Then cel.Appearance.ForeColor = colorVacaciones.Color : cel.Appearance.BackColor = colorVacaciones.Color
        '                If cel.Value = "I" Then cel.Appearance.ForeColor = colorNuevo.Color : cel.Appearance.BackColor = colorNuevo.Color
        '                If cel.Value = "C" Then cel.Appearance.ForeColor = colorCese.Color : cel.Appearance.BackColor = colorCese.Color
        '            End If
        '        Next
        '    Next
        '    For i = 1 To ldFin.Day
        '        If Weekday(Date.Parse(i & "/" & ldFin.Month & "/" & ldFin.Year)) = 1 Then
        '            griAsistencia.DisplayLayout.Bands(0).Columns("X" & i).Header.Appearance.ForeColor = Color.Red
        '        Else
        '            griAsistencia.DisplayLayout.Bands(0).Columns("X" & i).Header.Appearance.ForeColor = Color.Black
        '        End If
        '    Next
        '    griAsistencia.CreationFilter = New c_CeldaColumnaUnion
        'Catch ex As Exception
        '    mensajeEmergente.Problema(ex.Message, True)
        'End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_TrabajadorAsistencia_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'ControlBoton(1, 0, 0, 0, 0, 0, 0, IIf(griAsistencia.Rows.Count > 0, 1, 0), 1)
    End Sub

    Private Sub frm_TrabajadorAsistencia_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_TrabajadorAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mt_InicializarLogicas()
            mt_CargarCombos()
            'mt_InicializarGrila()
            mt_InicializarGrillaDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    'Private Sub cboEjercicio_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        If cboEjercicio.SelectedIndex > -1 Then
    '            oePeriodo = cboEjercicio.SelectedItem.ListObject
    '            oePlanilla = New e_Planilla : lePlanilla = New List(Of e_Planilla)
    '            oePlanilla.TipoOperacion = "A" : oePlanilla.IdPeriodo = oePeriodo.Ejercicio
    '            lePlanilla = olPlanilla.Listar(oePlanilla)
    '            LlenarCombo(cboMes, "NomMes", lePeriodo.Where(Function(it) it.Ejercicio = oePeriodo.Ejercicio).OrderByDescending(Function(it) it.Mes).ToList, 0)
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    'Private Sub cboMes_ValueChanged(sender As Object, e As EventArgs)
    '    Try
    '        If cboMes.SelectedIndex > -1 Then
    '            leAsistencia = New List(Of e_ResumenAsistencia)
    '            oePeriodo = cboMes.SelectedItem.ListObject
    '            ldInicio = Date.Parse("01/" & oePeriodo.Mes.ToString & "/" & oePeriodo.Ejercicio.ToString)
    '            ldFin = Date.Parse(gf_InicioFinMes("F", ldInicio.Year, ldInicio.Month))
    '            Dim _lePla = lePlanilla.Where(Function(it) it.IdPeriodo = oePeriodo.Id).ToList
    '            If _lePla.Count > 0 Then
    '                txtPlanilla.Text = _lePla(0).Codigo
    '                txtPlanilla.Tag = _lePla(0).Id
    '                fecInicio.Value = _lePla(0).FechaInicio
    '                fecFin.Value = _lePla(0).FechaFin
    '                oeAsistencia = New e_ResumenAsistencia
    '                oeAsistencia.TipoOperacion = "" : oeAsistencia.Activo = True
    '                oeAsistencia.IndTipo = -1 : oeAsistencia.GozedeHaber = -1
    '                oeAsistencia.IdPlanilla = txtPlanilla.Tag.trim
    '                leAsistencia = olAsistencia.Listar(oeAsistencia)
    '            Else
    '                txtPlanilla.Text = String.Empty
    '                txtPlanilla.Tag = String.Empty
    '                fecInicio.Value = ldInicio
    '                fecFin.Value = ldFin
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

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

    Private Sub cboPlanilla_ValueChanged(sender As Object, e As EventArgs) Handles cboPlanilla.ValueChanged
        Try
            If cboPlanilla.SelectedIndex > -1 Then
                Dim _oeplaaux = cboPlanilla.Items(cboPlanilla.SelectedIndex).ListObject
                fecInicio.Value = _oeplaaux.FechaInicio
                fecFin.Value = _oeplaaux.FechaFin
                'If oeRetencionQuinta.TipoOperacion = "I" Then
                '    Dim oeRI5 As New e_RetencionQuinta
                '    oeRI5.TipoOperacion = ""
                '    oeRI5.IdPlanilla = _oeplaaux.id
                '    oeRI5.Activo = True
                '    oeRI5 = olRetencionQuinta.Obtener(oeRI5)
                '    If oeRI5.Id <> "" Then
                '        btnCargarDatos.Enabled = False
                '        cboPlanilla.SelectedIndex = -1
                '        Throw New Exception("No se puede Seleccionar la Planilla Nº " & _oeplaaux.Codigo & _
                '                            ", ya se encuentra Registrada en Nº: " & oeRI5.Codigo)
                '    Else
                '        btnCargarDatos.Enabled = True
                '    End If
                '    oePeriodo = New e_Periodo
                '    oePeriodo.Equivale = 1
                '    oePeriodo.Id = _oeplaaux.IdPeriodo
                '    If lePeriodo.Contains(oePeriodo) Then
                '        oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                '        txtGlosa.Text = "ASISTENCIA MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                '    End If
                'Else
                '    btnCargarDatos.Enabled = False
                'End If
                oePeriodo = New e_Periodo
                oePeriodo.Equivale = 1
                oePeriodo.Id = _oeplaaux.IdPeriodo
                If lePeriodo.Contains(oePeriodo) Then
                    oePeriodo = lePeriodo.Item(lePeriodo.IndexOf(oePeriodo))
                    txtGlosa.Text = "ASISTENCIA MES " & MonthName(oePeriodo.Mes).ToUpper & " AÑO " & oePeriodo.Ejercicio
                End If
            Else
                fecInicio.Value = Date.Now.Date
                fecFin.Value = Date.Now.Date
                'btnCargarDatos.Enabled = False
            End If
            mt_InicializarGrillaDetalle()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Try
            Dim dt As DataTable
            Dim rwDC As Data.DataRow
            Dim dias As Integer = 0
            Dim DiaMes As String = ""
            Dim _leTrab As New List(Of e_Trabajador)
            Dim ldFechaActual As Date = ObtenerFechaServidor()
            Dim ldLimite As Date = #1/1/1901#
            Dim lnFalta As Integer = 0, lnAsistencia As Integer = 0, lnDescanso As Integer = 0, lnVacaciones As Integer = 0, lnDomingo As Integer = 0

            oeTrabajador = New e_Trabajador
            oeTrabajador.TipoOperacion = "N"
            leTrabajador = olTrabajador.Listar(oeTrabajador)

            ldInicio = fecInicio.Value.Date
            ldFin = fecFin.Value.Date

            _leTrab.AddRange(leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado = 1 And it.IndTipo = 0 And it.FechaIngreso <= ldFin And it.IdCentro = cboSede.Value _
                                                    And (it.IndPiloto = 1 Or it.IndPiloto = 2 Or it.IndPiloto = 4)).ToList)
            _leTrab.AddRange(leTrabajador.Where(Function(it) it.Activo = True And it.IndEstado <> 1 And it.IndTipo = 0 And it.FechaIngreso <= ldFin And it.IdCentro = cboSede.Value _
                                                    And it.FechaCese <> #1/1/1901# And it.FechaCese > ldInicio And (it.IndPiloto = 1 Or it.IndPiloto = 2 Or it.IndPiloto = 4)).ToList)

            oeAsistencia = New e_ResumenAsistencia
            oeAsistencia.TipoOperacion = "O"
            oeAsistencia.IdPlanilla = cboPlanilla.Value
            dt = olAsistencia.AsistenciaOperativos(oeAsistencia)

            dias = DateDiff(DateInterval.Day, fecInicio.Value, fecFin.Value)

            

            dsAsistencia.Rows.Clear()
            For Each _oeTrab In _leTrab.OrderBy(Function(it) it.oePersona.NombreCompleto)
                rwDC = dsAsistencia.NewRow
                rwDC("Dni") = _oeTrab.oePersona.Dni
                rwDC("Trabajador") = _oeTrab.oePersona.NombreCompleto
                rwDC("Cargo") = _oeTrab.oeOcupacion.Nombre
                rwDC("FechaInicio") = _oeTrab.FechaIngreso
                rwDC("FechaCese") = _oeTrab.FechaCese
                'If ldFin.Year = ldFechaActual.Year And ldFin.Month = ldFechaActual.Month Then
                '    ldLimite = ldFechaActual
                'Else
                '    ldLimite = ldFin
                'End If
                ldLimite = ldFin
                lnAsistencia = 0 : lnDomingo = 0
                'Marcar todos Faltas excepto dia libre
                'domingo = 1
                'For i = 1 To ldLimite.Day
                '    If Weekday(Date.Parse(i & "/" & ldLimite.Month & "/" & ldLimite.Year)) <> 1 Then
                '        rwDC("X" & i) = "A"
                '    Else
                '        rwDC("X" & i) = String.Empty : lnDomingo = lnDomingo + 1
                '    End If
                'Next
                For i = 0 To dias
                    DiaMes = DateAdd(DateInterval.Day, i, fecInicio.Value.Date).ToString("dd/MM")

                    If Weekday(Date.Parse(DateAdd(DateInterval.Day, i, ldInicio))) <> 1 Then
                        rwDC(DiaMes) = "F"
                    Else
                        rwDC(DiaMes) = String.Empty : lnDomingo = lnDomingo + 1
                    End If
                Next

                Dim filas() As DataRow
                Dim FechaAux As Date
                Dim expresion As String = "IdTrabajador = '" & _oeTrab.Id & "'"
                filas = dt.Select(expresion)
                For i As Integer = 0 To filas.Length - 1
                    FechaAux = filas(i)("Fecha")
                    DiaMes = FechaAux.ToString("dd/MM")
                    rwDC(DiaMes) = "A"
                Next



                'lnFalta = 0
                ''For Each _oeFalta In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 0 And it.CodigoSuspension <> "").ToList
                ''    For i = _oeFalta.FechaInicio.Day To _oeFalta.FechaTermino.Day
                ''        rwDC("X" & i) = "F" : lnFalta = lnFalta + 1
                ''    Next
                ''Next
                'For Each _oeOtros In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 0 And it.CodigoSuspension = "" And it.IndTipoAux = 0).ToList
                '    For i = _oeOtros.FechaInicio.Day To _oeOtros.FechaTermino.Day
                '        If _oeOtros.Observacion.ToUpper.Contains("INGRESO") Then
                '            rwDC("X" & i) = "I"
                '        ElseIf _oeOtros.Observacion.ToUpper.Contains("CESE") Then
                '            If _oeTrab.FechaCese = #1/1/1901# Then rwDC("X" & i) = "I" Else rwDC("X" & i) = "C"
                '        Else
                '            rwDC("X" & i) = "F" : lnFalta = lnFalta + 1
                '        End If
                '    Next
                'Next
                'lnDescanso = 0
                'For Each _oeDescanso In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 1 And it.CodigoSuspension <> "").ToList
                '    For i = _oeDescanso.FechaInicio.Day To _oeDescanso.FechaTermino.Day
                '        rwDC("X" & i) = "D" : lnDescanso = lnDescanso + 1
                '    Next
                'Next
                'lnVacaciones = 0
                'For Each _oeVaciones In leAsistencia.Where(Function(it) it.IdTrabajador = _oeTrab.Id And it.IndTipo = 2 And it.IndTipoAux = 0).ToList
                '    For i = _oeVaciones.FechaInicio.Day To _oeVaciones.FechaTermino.Day
                '        rwDC("X" & i) = "V" : lnVacaciones = lnVacaciones + 1
                '    Next
                'Next
                'For i = 1 To ldLimite.Day
                '    If rwDC("X" & i) = "A" Then lnAsistencia = lnAsistencia + 1
                'Next
                rwDC("Asistencia") = lnAsistencia
                rwDC("Inasistencia") = lnFalta
                dsAsistencia.Rows.Add(rwDC)
            Next
            'OcultarColumna(griAsistencia, False, "X28", "X29", "X30", "X31")
            'If ldFin.Day < 31 Then
            '    For i = 31 To (ldFin.Day + 1) Step -1
            '        OcultarColumna(griAsistencia, True, "X" & i)
            '    Next
            'End If
            griAsistencia.DataBind()
            'For Each fil In griAsistencia.Rows
            '    For Each cel In fil.Cells
            '        If cel.Column.Key.Contains("X") And Not IsDBNull(cel.Value) Then
            '            If cel.Value = "F" Then cel.Appearance.ForeColor = colorFalta.Color : cel.Appearance.BackColor = colorFalta.Color
            '            If cel.Value = "D" Then cel.Appearance.ForeColor = colorDescanso.Color : cel.Appearance.BackColor = colorDescanso.Color
            '            If cel.Value = "V" Then cel.Appearance.ForeColor = colorVacaciones.Color : cel.Appearance.BackColor = colorVacaciones.Color
            '            If cel.Value = "I" Then cel.Appearance.ForeColor = colorNuevo.Color : cel.Appearance.BackColor = colorNuevo.Color
            '            If cel.Value = "C" Then cel.Appearance.ForeColor = colorCese.Color : cel.Appearance.BackColor = colorCese.Color
            '        End If
            '    Next
            'Next
            'For i = 1 To ldFin.Day
            '    If Weekday(Date.Parse(i & "/" & ldFin.Month & "/" & ldFin.Year)) = 1 Then
            '        griAsistencia.DisplayLayout.Bands(0).Columns("X" & i).Header.Appearance.ForeColor = Color.Red
            '    Else
            '        griAsistencia.DisplayLayout.Bands(0).Columns("X" & i).Header.Appearance.ForeColor = Color.Black
            '    End If
            'Next
            griAsistencia.CreationFilter = New c_CeldaColumnaUnion
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_InicializarLogicas()
        olPeriodo = New l_Periodo
        olPlanilla = New l_Planilla
        olAsistencia = New l_ResumenAsistencia
        olTrabajador = New l_Trabajador
        olOcupacion = New l_OcupacionTrabajador
        olCentro = New l_Centro
        Prefijo = New l_Configuracion
    End Sub

    Private Sub mt_CargarCombos()
        Try
            ' Cargar Periodo
            oePeriodo = New e_Periodo : lePeriodo = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "" : oePeriodo.Ejercicio = 0
            lePeriodo = olPeriodo.Listar(oePeriodo)
            oePeriodo = New e_Periodo : leEjercicio = New List(Of e_Periodo)
            oePeriodo.TipoOperacion = "E"
            leEjercicio = olPeriodo.Listar(oePeriodo)
            'LlenarCombo(cboEjercicio, "Ejercicio", leEjercicio, 0)
            ' Cargar Trabajador
            'oeTrabajador = New e_Trabajador
            'oeTrabajador.TipoOperacion = "N"
            'leTrabajador = olTrabajador.Listar(oeTrabajador)
            ' Cargar Centro Buscar
            oeCentro = New e_Centro : leCentro = New List(Of e_Centro)
            leCentro = olCentro.Listar(oeCentro)
            LlenarCombo(cboSede, "Nombre", leCentro, 0)
            cboSedeBus.Value = gs_PrefijoIdSucursal.ToString '@0001
            ' Cargar Centro            
            LlenarCombo(cboSede, "Nombre", leCentro, 0)
            cboSede.Value = gs_PrefijoIdSucursal.ToString '@0001
            ' Cargar Planilla  
            oePlanilla = New e_Planilla
            oePlanilla.TipoOperacion = "" : oePlanilla.Activo = True : oePlanilla.Tipo = 0
            lePlanilla = olPlanilla.Listar(oePlanilla)
            'lePlanillaGen = lePlanilla.Where(Function(it) it.Estado = "GENERADA").ToList
            LlenarCombo(cboPlanilla, "Codigo", lePlanilla, -1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarGrila()
        Try
            dsAsistencia = New DataTable
            With dsAsistencia
                .Columns.Add("Dni", System.Type.GetType("System.String"))
                .Columns.Add("Trabajador", System.Type.GetType("System.String"))
                .Columns.Add("Cargo", System.Type.GetType("System.String"))
                .Columns.Add("FechaInicio", System.Type.GetType("System.DateTime"))
                .Columns.Add("FechaCese", System.Type.GetType("System.DateTime"))
                For i = 1 To 31
                    .Columns.Add("X" & i, System.Type.GetType("System.String"))
                Next
                .Columns.Add("Asistencia", System.Type.GetType("System.Int64"))
                .Columns.Add("Inasistencia", System.Type.GetType("System.Int64"))
            End With
            With griAsistencia
                .ResetDisplayLayout()
                .DataSource = dsAsistencia
                ConfiguraGrilla(griAsistencia, "Tahoma", True, UIElementBorderStyle.Default)
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.Caption = "Apellidos, Nombre"
                .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                .DisplayLayout.Bands(0).Columns("Trabajador").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                .DisplayLayout.Bands(0).Columns("Cargo").Header.Caption = "Cargo"
                .DisplayLayout.Bands(0).Columns("Cargo").Width = 200
                .DisplayLayout.Bands(0).Columns("Cargo").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                For i = 1 To 31
                    .DisplayLayout.Bands(0).Columns("X" & i).Header.Caption = i
                    .DisplayLayout.Bands(0).Columns("X" & i).Width = 20
                    .DisplayLayout.Bands(0).Columns("X" & i).Header.Appearance.FontData.Bold = DefaultableBoolean.True
                Next
                .DisplayLayout.Bands(0).Columns("Asistencia").Width = 75
                .DisplayLayout.Bands(0).Columns("Inasistencia").Width = 75
                .DisplayLayout.Bands(0).Columns("Asistencia").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                .DisplayLayout.Bands(0).Columns("Inasistencia").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                OcultarColumna(griAsistencia, True, "Dni", "FechaInicio", "FechaCese")
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_InicializarGrillaDetalle()
        Try
            Dim dias As Integer = 0
            Dim DiaMes As String = ""
            dsAsistencia = New DataTable
            If cboPlanilla.SelectedIndex > -1 Then
                dsAsistencia = New DataTable
                With dsAsistencia
                    .Columns.Add("Dni", System.Type.GetType("System.String"))
                    .Columns.Add("Trabajador", System.Type.GetType("System.String"))
                    .Columns.Add("Cargo", System.Type.GetType("System.String"))
                    .Columns.Add("FechaInicio", System.Type.GetType("System.DateTime"))
                    .Columns.Add("FechaCese", System.Type.GetType("System.DateTime"))

                    dias = DateDiff(DateInterval.Day, fecInicio.Value, fecFin.Value)

                    For i = 0 To dias
                        DiaMes = DateAdd(DateInterval.Day, i, fecInicio.Value.Date).ToString("dd/MM")
                        .Columns.Add(DiaMes, System.Type.GetType("System.String"))
                    Next
                    .Columns.Add("Asistencia", System.Type.GetType("System.Int64"))
                    .Columns.Add("Inasistencia", System.Type.GetType("System.Int64"))
                End With
                With griAsistencia
                    .ResetDisplayLayout()
                    .DataSource = dsAsistencia
                    ConfiguraGrilla(griAsistencia, "Tahoma", True, UIElementBorderStyle.Default)
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.Caption = "Apellidos, Nombre"
                    .DisplayLayout.Bands(0).Columns("Trabajador").Width = 250
                    .DisplayLayout.Bands(0).Columns("Trabajador").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                    .DisplayLayout.Bands(0).Columns("Cargo").Header.Caption = "Cargo"
                    .DisplayLayout.Bands(0).Columns("Cargo").Width = 200
                    .DisplayLayout.Bands(0).Columns("Cargo").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                    For i = 0 To dias
                        DiaMes = DateAdd(DateInterval.Day, i, fecInicio.Value.Date).ToString("dd/MM")
                        '.DisplayLayout.Bands(0).Columns(DiaMes).Header.Caption = DiaMes
                        .DisplayLayout.Bands(0).Columns(DiaMes).Width = 45
                        .DisplayLayout.Bands(0).Columns(DiaMes).Header.Appearance.FontData.Bold = DefaultableBoolean.True
                    Next
                    .DisplayLayout.Bands(0).Columns("Asistencia").Width = 75
                    .DisplayLayout.Bands(0).Columns("Inasistencia").Width = 75
                    .DisplayLayout.Bands(0).Columns("Asistencia").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                    .DisplayLayout.Bands(0).Columns("Inasistencia").Header.Appearance.FontData.Bold = DefaultableBoolean.True
                    OcultarColumna(griAsistencia, True, "Dni", "FechaInicio", "FechaCese")
                End With
            Else
                griAsistencia.ResetDisplayLayout()
                griAsistencia.DataSource = dsAsistencia
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

    
    
End Class