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

Public Class frm_InteresMensual
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_InteresMensual = Nothing
    Private Shared Operacion As String

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_InteresMensual
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim olObligFinan As New l_ObligacionFinanciera
    Dim olFuncionesGen As New l_FuncionesGenerales
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeObligacionFin As New e_ObligacionFin, leObligacionFin As New List(Of e_ObligacionFin)
    Private oeMoneda As New e_Moneda, olMoneda As New l_Moneda, leMoneda As New List(Of e_Moneda)
    Private oeAsiento As New e_Asiento, olAsiento As New l_Asiento, leAsiento As New List(Of e_Asiento)
    Private oePeriodo As New e_Periodo
    Private _opeInteres As String = "", _acl As String = "", ls_Mensaje As String = ""
    Private DatoInteres As Date = #1/1/1901#
    Private DTReferencia As Data.DataTable, dtAux As Data.DataTable
    Private lb_load As Boolean
    Private ln_Operacion As Integer = -1

#End Region

#Region "Botonera"

    Public Overrides Sub Exportar()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_InteresMensual_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_InteresMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            fecEmision.Value = Date.Parse("01/" & fecEmision.Value.Month.ToString & "/" & fecEmision.Value.Year.ToString)
            DatoInteres = Date.Parse(gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month))
            fecEmision.Focus()
            'Cargar Moneda
            oeMoneda = New e_Moneda
            oeMoneda.Activo = True
            leMoneda.AddRange(olMoneda.Listar(oeMoneda))
            'Cargar Asiento Modelo Referencia
            oeReferencia = New e_AsientoModelo_Referencia
            oeReferencia.TipoOperacion = "N" : oeReferencia.Activo = True : oeReferencia.IdReferencia = pIdActividadNegocio
            leReferencia = olReferencia.Listar(oeReferencia)
            'Cargar DT Referencia
            If leReferencia.Count > 0 Then
                DTReferencia = GeneraDTRef(leReferencia)
            Else
                Throw New Exception("No se hay configuración contable")
            End If
            lb_load = True
            mt_CargarDatos(New List(Of e_ObligacionFin))
            lb_load = False
            ln_Operacion = -1
            btnProvisionar.Enabled = False
            ficDatos.Tabs(0).Selected = True
            ficDatos.Tabs(1).Enabled = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub frm_InteresMensual_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        fecEmision.Focus()
    End Sub

    Private Sub btnLeasing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeasing.Click
        Try
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                leAsientoModel = New List(Of e_AsientoModelo)
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso1.Minimum = 0 : BarraProgreso1.Maximum = 15 : BarraProgreso1.Visible = True
                BarraProgreso1.Value = 5 : BarraProgreso1.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I"
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
                oeAsiento.IdentificaAsiento = "LEASING%"
                oeAsiento.Activo = True
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGSOLES").ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGDOLARES").ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOLeasing & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtener Datos a Procesar
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "L"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.TipoOperacion = "T" : oeAux.IndInteresMensual = 1
                    Next
                    oeContratoFin.lstObligacionesFin = leObligacionFin
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 0
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso1.Value = 10 : BarraProgreso1.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso1.Visible = False
        End Try
    End Sub

    Private Sub btnPagare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagare.Click
        Try
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso2.Minimum = 0 : BarraProgreso2.Maximum = 15 : BarraProgreso2.Visible = True
                BarraProgreso2.Value = 5 : BarraProgreso2.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value
                oeContratoFin.Usuario = gUsuarioSGI.Id : oeContratoFin.leMoneda = leMoneda
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I" : oeAsiento.Activo = True
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo : oeAsiento.IdentificaAsiento = "PAGARE%"
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("SOLES")).ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("DOLARES")).ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOPagare & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                'Obtener Datos a Procesar
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "A"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.TipoOperacion = "T" : oeAux.IndInteresMensual = 1
                    Next
                    oeContratoFin.lstObligacionesFin = leObligacionFin
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 1
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso2.Value = 10 : BarraProgreso2.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default : BarraProgreso2.Visible = False
        End Try
    End Sub

    Private Sub btnFed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFed.Click
        Try
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso3.Minimum = 0 : BarraProgreso3.Maximum = 15 : BarraProgreso3.Visible = True
                BarraProgreso3.Value = 5 : BarraProgreso3.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value
                oeContratoFin.Usuario = gUsuarioSGI.Id : oeContratoFin.leMoneda = leMoneda
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I"
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
                oeAsiento.IdentificaAsiento = "FED%"
                oeAsiento.Activo = True
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("SOLES")).ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("DOLARES")).ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOFed & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                'Obtener Datos a Procesar
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "C"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.TipoOperacion = "T" : oeAux.IndInteresMensual = 1
                    Next
                    oeContratoFin.lstObligacionesFin = leObligacionFin
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 2
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso3.Value = 10
                BarraProgreso3.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso3.Visible = False
        End Try
    End Sub

    Private Sub btnFactoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactoring.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim olObligFinan As New l_ObligacionFinanciera
            Dim olFuncionesGen As New l_FuncionesGenerales
            olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            mt_CargarDatos(New List(Of e_ObligacionFin))
            BarraProgreso4.Maximum = 15
            BarraProgreso4.Minimum = 0
            BarraProgreso4.Visible = True
            BarraProgreso4.Value = 5
            BarraProgreso4.Refresh()
            Try
                Throw New Exception("Este Proceso de Encuentra en Mantenimiento")
                'olObligFinan.GuardarInteresMensualFactoringSoles(FecFecha.Value, DecTC.Value, gUsuarioSGI.Id, "", FecFecha.Value)
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            Finally
                Me.Cursor = Cursors.Default
                BarraProgreso4.Visible = False
            End Try

            BarraProgreso4.Value = 10
            BarraProgreso4.Refresh()
            Try
                Throw New Exception("Este Proceso de Encuentra en Mantenimiento")
                'olObligFinan.GuardarInteresMensualFactoringDolares(FecFecha.Value, DecTC.Value, gUsuarioSGI.Id, "", FecFecha.Value)
            Catch ex As Exception
                mensajeEmergente.Problema(ex.Message, True)
            Finally
                Me.Cursor = Cursors.Default
                BarraProgreso4.Visible = False
            End Try

            BarraProgreso4.Value = 15
            BarraProgreso4.Refresh()

            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            mensajeEmergente.Confirmacion("El Asiento se Genero correctamente")
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default : BarraProgreso4.Visible = False
        End Try
    End Sub

    Private Sub btnFec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFec.Click
        Try
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                leAsientoModel = New List(Of e_AsientoModelo)
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso5.Minimum = 0 : BarraProgreso5.Maximum = 15 : BarraProgreso5.Visible = True
                BarraProgreso5.Value = 5 : BarraProgreso5.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I" : oeAsiento.Activo = True
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo : oeAsiento.IdentificaAsiento = "FEC%"
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("SOLES")).ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento.Contains("DOLARES")).ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOFec & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtener Datos a Procesar
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "B"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.TipoOperacion = "T" : oeAux.IndInteresMensual = 1
                    Next
                    oeContratoFin.lstObligacionesFin = leObligacionFin
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 4
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso5.Value = 10
                BarraProgreso5.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso5.Visible = False
        End Try
    End Sub

    Private Sub btnInteresReversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInteresReversion.Click
        Try
            Dim _IdAsientoRef As String = "", _FechaAux As Date = #1/1/1901#
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                leAsientoModel = New List(Of e_AsientoModelo)
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso6.Minimum = 0 : BarraProgreso6.Maximum = 15
                BarraProgreso6.Visible = True
                BarraProgreso6.Value = 5
                BarraProgreso6.Refresh()
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I"
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
                oeAsiento.IdentificaAsiento = "LEASINGINTERES%"
                oeAsiento.Activo = True
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESSOLES").ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESDOLARES").ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTDOtro & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                _IdAsientoRef = String.Empty
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                _IdAsientoRef = oeAsientoModel.IdVinculado
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeAsientoModel.IndVinculado = True
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                _IdAsientoRef = String.Empty
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                _IdAsientoRef = oeAsientoModel.IdVinculado
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                oeAsientoModel.IndVinculado = True
                leAsientoModel.Add(oeAsientoModel)
                'Obtener Datos a Procesar Diferencia de Interes Tesoreria - Contable
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "E"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.IndFec = False : oeAux.MontoInteresContable = oeAux.MontoInteres - oeAux.MontoInteresContable  ' Para Diferenciar por Reversion
                    Next
                    oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
                    mt_CargarDatos(leObligacionFin.Where(Function(it) Not it.IndFec).ToList)
                    ln_Operacion = 5
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                'Obtener Datos a Procesar Mes Anterior
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "R"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.IndFec = True  ' Para Diferenciar por Reversion
                    Next
                    oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
                    mt_CargarDatos2(leObligacionFin.Where(Function(it) it.IndFec).ToList)
                    ln_Operacion = 5
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso6.Value = 10 : BarraProgreso6.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso6.Visible = False
        End Try
    End Sub

    Private Sub BtnInteresCredito_Click(sender As Object, e As EventArgs) Handles BtnInteresCredito.Click
        Try
            Dim _FechaAux As Date = #1/1/1901#
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                leAsientoModel = New List(Of e_AsientoModelo)
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso7.Minimum = 0 : BarraProgreso7.Maximum = 15 : BarraProgreso7.Visible = True
                BarraProgreso7.Value = 5 : BarraProgreso7.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I"
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
                oeAsiento.IdentificaAsiento = "CHP%"
                oeAsiento.Activo = True
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "CHPSOLES").ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "CHPDOLARES").ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOCreditoHipotecario & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True
                oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                leAsientoModel.Add(oeAsientoModel)
                'Obtener Datos a Procesar
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "G"
                '_FechaAux = Date.Parse("01/" & fecEmision.Value.Month.ToString & "/" & fecEmision.Value.Year.ToString)
                _FechaAux = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                oeObligacionFin.FechaInicio = _FechaAux
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    oeContratoFin.lstObligacionesFin = leObligacionFin
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 6
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso7.Value = 10
                BarraProgreso7.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso7.Visible = False
        End Try
    End Sub

    Private Sub BtnPagoInteresCredito_Click(sender As Object, e As EventArgs) Handles BtnPagoInteresCredito.Click
        Try
            Dim _IdAsientoRef As String = "", _FechaAux As Date = #1/1/1901#
            ls_Mensaje = String.Empty
            _acl = gAccionSistema.NUEVO.ToString
            If ValidarAcl(_acl, pIdActividadNegocio) Then
                leAsientoModel = New List(Of e_AsientoModelo)
                Me.Cursor = Cursors.WaitCursor
                olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
                BarraProgreso8.Minimum = 0 : BarraProgreso8.Maximum = 15 : BarraProgreso8.Visible = True
                BarraProgreso8.Value = 5 : BarraProgreso8.Refresh()
                mt_CargarDatos(New List(Of e_ObligacionFin))
                'Cargar Contrato
                oeContratoFin = New e_ContratoFinanciero
                oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
                'Obtener Periodo
                oePeriodo = New e_Periodo
                oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
                oeContratoFin.IdPeriodo = oePeriodo.Id
                'Validar si ya se Genero Asiento
                oeAsiento = New e_Asiento
                oeAsiento.TipoOperacion = "I"
                oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
                oeAsiento.IdentificaAsiento = "CHC%"
                oeAsiento.Activo = True
                leAsiento = olAsiento.Listar(oeAsiento)
                If leAsiento.Count > 0 Then
                    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "CHCSOLES").ToList
                    If _leAuxSol.Count > 0 Then
                        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
                    End If
                    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "CHCDOLARES").ToList
                    If _leAuxDol.Count > 0 Then
                        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
                    End If
                    If ls_Mensaje.Trim.Length > 0 Then
                        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
                    End If
                End If
                'Filtra DtReferencia
                dtAux = New Data.DataTable
                Dim _rwAux() As Data.DataRow
                Dim cadSQL As String = String.Empty
                cadSQL = "TipoRef2 = 5 AND Ref2 = '" & gTOCreditoHipotecario & "'"
                _rwAux = DTReferencia.Select(cadSQL, "")
                If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
                dtAux = _rwAux.CopyToDataTable
                'Obtiene Asiento Modelo por Referencia
                _IdAsientoRef = String.Empty
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                _IdAsientoRef = oeAsientoModel.IdVinculado
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                '_IdAsientoRef = String.Empty
                '_IdAsientoRef = oeAsientoModel.IdVinculado
                leAsientoModel.Add(oeAsientoModel)
                'oeAsientoModel = New e_AsientoModelo
                'oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                'oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                'oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                'If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                'oeAsientoModel.IndVinculado = True
                'leAsientoModel.Add(oeAsientoModel)
                'Obtiene Asiento Modelo por Referencia
                _IdAsientoRef = String.Empty
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                _IdAsientoRef = oeAsientoModel.IdVinculado
                oeAsientoModel = New e_AsientoModelo
                oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                '_IdAsientoRef = String.Empty
                '_IdAsientoRef = oeAsientoModel.IdVinculado
                leAsientoModel.Add(oeAsientoModel)
                'oeAsientoModel = New e_AsientoModelo
                'oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = _IdAsientoRef
                'oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
                'oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
                'If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
                'oeAsientoModel.IndVinculado = True
                'leAsientoModel.Add(oeAsientoModel)

                'Obtener Datos a Procesar Diferencia de Interes Tesoreria - Contable
                oeObligacionFin = New e_ObligacionFin
                oeObligacionFin.TipoOperacion = "K"
                oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
                leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
                If leObligacionFin.Count > 0 Then
                    For Each oeAux In leObligacionFin
                        oeAux.TipoOperacion = "T" : oeAux.IndInteresMensual = 1
                    Next
                    oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
                    mt_CargarDatos(leObligacionFin)
                    ln_Operacion = 7
                    btnProvisionar.Enabled = True
                    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = False : ficDatos.Tabs(0).Selected = True
                Else
                    Throw New Exception("No hay Datos para Procesar")
                End If
                BarraProgreso8.Value = 10 : BarraProgreso8.Refresh()
            Else
                Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso8.Visible = False
        End Try
    End Sub

    Private Sub fecEmision_Validated(sender As Object, e As EventArgs) Handles fecEmision.Validated
        Try
            DatoInteres = Date.Parse(gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month))
            If DecTC.Value = 0 Then
                DecTC.Value = TipoCambio(DatoInteres)(0)
            Else
                If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
                   = Windows.Forms.DialogResult.Yes Then
                    DecTC.Value = TipoCambio(fecEmision.Value)(0)
                End If
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnProvisionar_Click(sender As Object, e As EventArgs) Handles btnProvisionar.Click
        Try
            oeContratoFin.PrefijoID = gs_PrefijoIdSucursal '@0001
            Select Case ln_Operacion
                Case 0 ' Provision Interes Leasing
                    If olContratoFin.GuardarInteresMensualLeasing(oeContratoFin, leAsientoModel) Then
                        BarraProgreso1.Value = 15 : BarraProgreso1.Refresh()
                        btnProvisionar.Enabled = False
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 1 ' Provision de Interes Pagare
                    If olContratoFin.GuardarInteresMensualPagare(oeContratoFin, oeAsientoModel) Then
                        BarraProgreso2.Value = 15 : BarraProgreso2.Refresh()
                        btnProvisionar.Enabled = False
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 2 ' Provision de Interes Fedd
                    If olContratoFin.GuardarInteresMensualFed(oeContratoFin, oeAsientoModel) Then
                        BarraProgreso3.Value = 15 : BarraProgreso3.Refresh()
                        btnProvisionar.Enabled = False
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 4 ' Provision Interes Fec
                    If olContratoFin.GuardarInteresMensualFec(oeContratoFin, leAsientoModel) Then
                        BarraProgreso5.Value = 15 : BarraProgreso5.Refresh()
                        btnProvisionar.Enabled = False
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 5 ' Interes y Reversion Leasing
                    If olContratoFin.GuardarInteresMensualLeasingReversion(oeContratoFin, leAsientoModel) Then
                        BarraProgreso6.Value = 15 : BarraProgreso6.Refresh()
                        btnProvisionar.Enabled = False
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 6 ' Provision Interes Credito Hipotecario
                    If olContratoFin.GuardarInteresMensualCreditoHipotecario(oeContratoFin, leAsientoModel) Then
                        BarraProgreso7.Value = 15 : BarraProgreso7.Refresh()
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case 7 ' Pago Interes Credito Hipotecario
                    If olContratoFin.GuardarInteresMensualPuenteCreHip(oeContratoFin, leAsientoModel) Then
                        BarraProgreso8.Value = 15 : BarraProgreso8.Refresh()
                        mt_CargarDatos(New List(Of e_ObligacionFin))
                        mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                    End If
                Case Else
                    mensajeEmergente.Problema("Seleccione un Tipo de Obligacion Financiera para provisionar", True)
            End Select
            ln_Operacion = -1
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CargarDatos(ByVal leDatos As List(Of e_ObligacionFin))
        Try
            With griDatos
                If lb_Load Then .ResetDisplayLayout()
                .DataSource = leDatos
                .Text = "LISTADO DE OBLIGACIONES A PROVISIONAR"
                If lb_Load Then
                    ConfiguraGrilla(griDatos, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griDatos, False, "FechaVencimiento", "Banco", "NroContrato", "IdMoneda", "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
                                    "DiasFinMes", "MontoInteresContable", "Glosa")
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("NroContrato").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("MontoMN").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("MontoME").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("MontoInteres").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 65
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 65
                    .DisplayLayout.Bands(0).Columns("Banco").Width = 160
                    .DisplayLayout.Bands(0).Columns("NroContrato").Width = 140
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                    .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.Caption = "Total Dias"
                    .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.Caption = "Dias Mes"
                    .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.Caption = "Prov. Interes"
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                    FormatoColumna(griDatos, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
                                   "DiasFinMes", "MontoInteresContable")
                End If
            End With
            If leDatos.Count > 0 Then
                ndSoles.Value = leDatos.Where(Function(it) it.IdMoneda = "SOLES").Sum(Function(it) it.MontoInteresContable)
                ndDolares.Value = leDatos.Where(Function(it) it.IdMoneda <> "SOLES").Sum(Function(it) it.MontoInteresContable)
            Else
                ndSoles.Value = 0 : ndDolares.Value = 0
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub mt_CargarDatos2(ByVal leDatos2 As List(Of e_ObligacionFin))
        Try
            With griReversion
                If lb_load Then .ResetDisplayLayout()
                .DataSource = leDatos2
                .Text = "LISTADO DE OBLIGACIONES A PROVISIONAR"
                If lb_load Then
                    ConfiguraGrilla(griReversion, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griReversion, False, "FechaVencimiento", "Banco", "NroContrato", "IdMoneda", "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
                                    "DiasFinMes", "MontoInteresContable", "Glosa")
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("NroContrato").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("MontoMN").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("MontoME").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("MontoInteres").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 65
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 65
                    .DisplayLayout.Bands(0).Columns("Banco").Width = 160
                    .DisplayLayout.Bands(0).Columns("NroContrato").Width = 140
                    .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
                    .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.Caption = "Total Dias"
                    .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.Caption = "Dias Mes"
                    .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.Caption = "Prov. Interes"
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                    FormatoColumna(griReversion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
                                   "DiasFinMes", "MontoInteresContable")
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class
