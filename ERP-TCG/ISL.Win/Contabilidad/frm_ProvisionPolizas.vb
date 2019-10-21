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

Public Class frm_ProvisionPolizas
    Inherits frm_MenuPadre

#Region "Instancia"

    Private Shared instancia As frm_ProvisionPolizas = Nothing
    Private Shared Operacion As String

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ProvisionPolizas
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim olDocumentoVehicular As New l_DocumentoVehicular
    Dim olFuncionesGen As New l_FuncionesGenerales
    Private oeReferencia As New e_AsientoModelo_Referencia, olReferencia As New l_AsientoModelo_Referencia, leReferencia As New List(Of e_AsientoModelo_Referencia)
    Private oeAsientoModel As New e_AsientoModelo, olAsientoModel As New l_AsientoModelo, leAsientoModel As New List(Of e_AsientoModelo)
    'Private oeContratoFin As New e_ContratoFinanciero, olContratoFin As New l_ContratoFinanciero
    Private oeDocumentoVehicular As New e_DocumentoVehicular, leDocumentoVehicular As New List(Of e_DocumentoVehicular)
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

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            ListarPolizaInicial()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

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
            mt_CargarDatos(New List(Of e_DocumentoVehicular))
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
        'fecEmision.Focus()
    End Sub

    'Private Sub btnInteresReversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim _IdAsientoRef As String = "", _FechaAux As Date = #1/1/1901#
    '        ls_Mensaje = String.Empty
    '        '_acl = gAccionSistema.NUEVO.ToString
    '        'If ValidarAcl(_acl, pIdActividadNegocio) Then

    '        If True Then
    '            leAsientoModel = New List(Of e_AsientoModelo)
    '            Me.Cursor = Cursors.WaitCursor
    '            olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
    '            'BarraProgreso6.Minimum = 0 : BarraProgreso6.Maximum = 15
    '            'BarraProgreso6.Visible = True
    '            'BarraProgreso6.Value = 5
    '            'BarraProgreso6.Refresh()
    '            'Cargar Contrato
    '            'oeContratoFin = New e_ContratoFinanciero
    '            'oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
    '            'Obtener Periodo
    '            oePeriodo = New e_Periodo
    '            oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
    '            'oeContratoFin.IdPeriodo = oePeriodo.Id
    '            'Validar si ya se Genero Asiento
    '            'oeAsiento = New e_Asiento
    '            'oeAsiento.TipoOperacion = "I"
    '            'oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
    '            'oeAsiento.IdentificaAsiento = "LEASINGINTERES%"
    '            'oeAsiento.Activo = True
    '            'leAsiento = olAsiento.Listar(oeAsiento)
    '            'If leAsiento.Count > 0 Then
    '            '    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESSOLES").ToList
    '            '    If _leAuxSol.Count > 0 Then
    '            '        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
    '            '    End If
    '            '    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESDOLARES").ToList
    '            '    If _leAuxDol.Count > 0 Then
    '            '        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
    '            '    End If
    '            '    If ls_Mensaje.Trim.Length > 0 Then
    '            '        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
    '            '    End If
    '            'End If
    '            'Filtra DtReferencia
    '            dtAux = New Data.DataTable
    '            Dim _rwAux() As Data.DataRow
    '            Dim cadSQL As String = String.Empty
    '            'cadSQL = "TipoRef1 = 5 AND Ref1 = '" & gTDOtro & "'"
    '            cadSQL = "TipoRef1 = 10"
    '            _rwAux = DTReferencia.Select(cadSQL, "")
    '            If _rwAux.Count = 0 Then Throw New Exception("No tiene configuracion contable")
    '            dtAux = _rwAux.CopyToDataTable
    '            'Obtiene Asiento Modelo por Referencia
    '            _IdAsientoRef = String.Empty
    '            oeAsientoModel = New e_AsientoModelo
    '            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(0).Item("IdAsientoModelo").ToString
    '            oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
    '            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
    '            If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
    '            _IdAsientoRef = oeAsientoModel.IdVinculado
    '            leAsientoModel.Add(oeAsientoModel)

    '            'Obtener Datos a Procesar Diferencia de Interes Tesoreria - Contable
    '            oeDocumentoVehicular = New e_DocumentoVehicular
    '            oeDocumentoVehicular.TipoOperacion = "P"
    '            'oeDocumentoVehicular.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
    '            leDocumentoVehicular = olDocumentoVehicular.Listar(oeDocumentoVehicular)
    '            If leDocumentoVehicular.Count > 0 Then
    '                'For Each oeAux In leDocumentoVehicular
    '                '    oeAux.IndFec = False : oeAux.MontoInteresContable = oeAux.MontoInteres - oeAux.MontoInteresContable  ' Para Diferenciar por Reversion
    '                'Next
    '                'oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
    '                mt_CargarDatos(leDocumentoVehicular)
    '                ln_Operacion = 5
    '                btnProvisionar.Enabled = True
    '                'ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
    '            Else
    '                Throw New Exception("No hay Datos para Procesar")
    '            End If
    '            ''Obtener Datos a Procesar Mes Anterior
    '            'oeObligacionFin = New e_ObligacionFin
    '            'oeObligacionFin.TipoOperacion = "R"
    '            'oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
    '            'leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
    '            'If leObligacionFin.Count > 0 Then
    '            '    For Each oeAux In leObligacionFin
    '            '        oeAux.IndFec = True  ' Para Diferenciar por Reversion
    '            '    Next
    '            '    oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
    '            '    mt_CargarDatos(leObligacionFin.Where(Function(it) it.IndFec).ToList)
    '            '    ln_Operacion = 5
    '            '    btnProvisionar.Enabled = True
    '            '    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
    '            'Else
    '            '    Throw New Exception("No hay Datos para Procesar")
    '            'End If
    '            'BarraProgreso6.Value = 10 : BarraProgreso6.Refresh()
    '        Else
    '            Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '        'BarraProgreso6.Visible = False
    '    End Try
    'End Sub

    'Private Sub fecEmision_Validated(sender As Object, e As EventArgs) Handles fecEmision.Validated
    '    Try
    '        DatoInteres = Date.Parse(gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month))
    '        If DecTC.Value = 0 Then
    '            DecTC.Value = TipoCambio(DatoInteres)(0)
    '        Else
    '            If MessageBox.Show("Desea Cambiar al Tipo de Cambio del dia?", "Mensaje del sistema", _
    '               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) _
    '               = Windows.Forms.DialogResult.Yes Then
    '                DecTC.Value = TipoCambio(fecEmision.Value)(0)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        mensajeEmergente.Problema(ex.Message, True)
    '    End Try
    'End Sub

    Private Sub griDatos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles griDatos.BeforeRowsDeleted
        e.DisplayPromptMsg = False
        e.Cancel = True
    End Sub

    Private Sub btnProvisionar_Click(sender As Object, e As EventArgs) Handles btnProvisionar.Click
        Try
            For Each drFila In griDatos.Selected.Rows
                If drFila.Cells("NroResolucion").Value.ToString.Trim <> "" Then Throw New Exception("Documento: " + drFila.Cells("Numero").Value + ", ya fue provisiondo.")
                If drFila.Cells("Bonificacion").Value = 0 Then Throw New Exception("No existe registro tipo cambio en la fecha: " + drFila.Cells("FechaAdquisicion").Value)


                oeDocumentoVehicular = New e_DocumentoVehicular
                oeDocumentoVehicular = leDocumentoVehicular.Where(Function(x) x.Id = drFila.Cells("Id").Value).ToList(0)

                oeDocumentoVehicular.UsuarioCreacion = gUsuarioSGI.Id
                oeDocumentoVehicular.IdVehiculo = oePeriodo.Id
                oeDocumentoVehicular.PrefijoID = gs_PrefijoIdSucursal '@0001
                If olDocumentoVehicular.GuardarProvisionPoliza(oeDocumentoVehicular, leAsientoModel) Then
                    btnProvisionar.Enabled = False
                End If
            Next

            If Not btnProvisionar.Enabled Then
                mensajeEmergente.Confirmacion("El Asiento se Genero correctamente", True)
                oeDocumentoVehicular = New e_DocumentoVehicular
                oeDocumentoVehicular.TipoOperacion = "P"
                leDocumentoVehicular = olDocumentoVehicular.Listar(oeDocumentoVehicular)
                If leDocumentoVehicular.Count > 0 Then
                    mt_CargarDatos(leDocumentoVehicular)
                End If
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub ListarPolizaInicial()
        Try
            Dim _IdAsientoRef As String = "", _FechaAux As Date = #1/1/1901#
            ls_Mensaje = String.Empty
            'If True Then
            leAsientoModel = New List(Of e_AsientoModelo)
            Me.Cursor = Cursors.WaitCursor
            'olFuncionesGen.ValidarNumero(DecTC.Value, "Tipo de Cambio")
            'BarraProgreso6.Minimum = 0 : BarraProgreso6.Maximum = 15
            'BarraProgreso6.Visible = True
            'BarraProgreso6.Value = 5
            'BarraProgreso6.Refresh()
            'Cargar Contrato
            'oeContratoFin = New e_ContratoFinanciero
            'oeContratoFin.FechaEmision = DatoInteres : oeContratoFin.TipoCambio = DecTC.Value : oeContratoFin.Usuario = gUsuarioSGI.Id
            'Obtener Periodo
            oePeriodo = New e_Periodo
            oePeriodo = ObtenerPeriodo(CDate(fecEmision.Value))
            'oeContratoFin.IdPeriodo = oePeriodo.Id
            'Validar si ya se Genero Asiento
            'oeAsiento = New e_Asiento
            'oeAsiento.TipoOperacion = "I"
            'oeAsiento.IdPeriodo = oeContratoFin.IdPeriodo
            'oeAsiento.IdentificaAsiento = "LEASINGINTERES%"
            'oeAsiento.Activo = True
            'leAsiento = olAsiento.Listar(oeAsiento)
            'If leAsiento.Count > 0 Then
            '    Dim _leAuxSol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESSOLES").ToList
            '    If _leAuxSol.Count > 0 Then
            '        ls_Mensaje = " * Nro Asiento: " & _leAuxSol(0).NroAsiento & " Moneda: SOLES" & " Monto: " & _leAuxSol(0).TotalDebe & Environment.NewLine
            '    End If
            '    Dim _leAuxDol = leAsiento.Where(Function(it) it.IdentificaAsiento = "LEASINGINTERESDOLARES").ToList
            '    If _leAuxDol.Count > 0 Then
            '        ls_Mensaje = ls_Mensaje & " * Nro Asiento: " & _leAuxDol(0).NroAsiento & " Moneda: DOLARES" & " Monto: " & _leAuxDol(0).TotalDebe & Environment.NewLine
            '    End If
            '    If ls_Mensaje.Trim.Length > 0 Then
            '        Throw New Exception("No se puede Realizar la Operacion. Ya se generaron los Asientos: " & Environment.NewLine & ls_Mensaje)
            '    End If
            'End If
            'Filtra DtReferencia
            dtAux = New Data.DataTable
            Dim _rwAux() As Data.DataRow
            Dim cadSQL As String = String.Empty
            'cadSQL = "TipoRef1 = 5 AND Ref1 = '" & gTDOtro & "'"
            cadSQL = "TipoRef1 = 10"
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
            _IdAsientoRef = String.Empty
            oeAsientoModel = New e_AsientoModelo
            oeAsientoModel.TipoOperacion = "" : oeAsientoModel.Activo = True : oeAsientoModel.Id = dtAux.Rows(1).Item("IdAsientoModelo").ToString
            oeAsientoModel.Ejercicio = CDate(fecEmision.Value).Year
            oeAsientoModel = olAsientoModel.Obtener(oeAsientoModel)
            If oeAsientoModel.leDetalle.Count = 0 Then Throw New Exception("No Existe Configuracion Contable")
            _IdAsientoRef = oeAsientoModel.IdVinculado
            leAsientoModel.Add(oeAsientoModel)

            'Obtener Datos a Procesar Diferencia de Interes Tesoreria - Contable
            oeDocumentoVehicular = New e_DocumentoVehicular
            oeDocumentoVehicular.TipoOperacion = "P"
            'oeDocumentoVehicular.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
            leDocumentoVehicular = olDocumentoVehicular.Listar(oeDocumentoVehicular)
            If leDocumentoVehicular.Count > 0 Then
                'For Each oeAux In leDocumentoVehicular
                '    oeAux.IndFec = False : oeAux.MontoInteresContable = oeAux.MontoInteres - oeAux.MontoInteresContable  ' Para Diferenciar por Reversion
                'Next
                'oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
                mt_CargarDatos(leDocumentoVehicular)
                ln_Operacion = 5
                btnProvisionar.Enabled = True
                'ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
            Else
                Throw New Exception("No hay Datos para Procesar")
            End If
            ''Obtener Datos a Procesar Mes Anterior
            'oeObligacionFin = New e_ObligacionFin
            'oeObligacionFin.TipoOperacion = "R"
            'oeObligacionFin.FechaInicio = gf_InicioFinMes("F", fecEmision.Value.Year, fecEmision.Value.Month)
            'leObligacionFin = olObligFinan.Listar2(oeObligacionFin)
            'If leObligacionFin.Count > 0 Then
            '    For Each oeAux In leObligacionFin
            '        oeAux.IndFec = True  ' Para Diferenciar por Reversion
            '    Next
            '    oeContratoFin.lstObligacionesFin.AddRange(leObligacionFin)
            '    mt_CargarDatos(leObligacionFin.Where(Function(it) it.IndFec).ToList)
            '    ln_Operacion = 5
            '    btnProvisionar.Enabled = True
            '    ficDatos.Tabs(0).Enabled = True : ficDatos.Tabs(1).Enabled = True : ficDatos.Tabs(0).Selected = True
            'Else
            '    Throw New Exception("No hay Datos para Procesar")
            'End If
            'BarraProgreso6.Value = 10 : BarraProgreso6.Refresh()
            'Else
            '    Throw New Exception("Usted no Tiene Permiso de: " & _acl & " en " & Me.Text)
            'End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            'BarraProgreso6.Visible = False
        End Try

    End Sub


    Private Sub mt_CargarDatos(ByVal leDatos As List(Of e_DocumentoVehicular))
        Try
            With griDatos
                If lb_load Then .ResetDisplayLayout()
                .DataSource = leDatos
                .Text = "LISTADO DE POLIZAS"
                If lb_load Then
                    ConfiguraGrilla(griDatos, "Tahoma", True, UIElementBorderStyle.Default)
                    OcultarColumna2(griDatos, True, "Id", "IdTipoDocumento", "IdEmpresaEmisora", "IdEmpresaPropietaria", "EmpresaPropietaria", _
                                    "Activo", "Resultado", "IdVehiculo", "Tipo")
                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Header.VisiblePosition = 0
                    .DisplayLayout.Bands(0).Columns("Numero").Header.VisiblePosition = 1
                    .DisplayLayout.Bands(0).Columns("FechaAdquisicion").Header.VisiblePosition = 2
                    .DisplayLayout.Bands(0).Columns("EmpresaEmisora").Header.VisiblePosition = 3
                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.VisiblePosition = 4
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 5
                    .DisplayLayout.Bands(0).Columns("Bonificacion").Header.VisiblePosition = 6
                    .DisplayLayout.Bands(0).Columns("Importe").Header.VisiblePosition = 7
                    .DisplayLayout.Bands(0).Columns("Peso").Header.VisiblePosition = 8
                    .DisplayLayout.Bands(0).Columns("Porcentaje").Header.VisiblePosition = 9
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Header.VisiblePosition = 10
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 11
                    .DisplayLayout.Bands(0).Columns("NroResolucion").Header.VisiblePosition = 12

                    .DisplayLayout.Bands(0).Columns("TipoDocumento").Width = 60
                    .DisplayLayout.Bands(0).Columns("Numero").Width = 160
                    .DisplayLayout.Bands(0).Columns("FechaAdquisicion").Width = 80
                    .DisplayLayout.Bands(0).Columns("EmpresaEmisora").Width = 220
                    .DisplayLayout.Bands(0).Columns("Descripcion").Width = 160
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 80
                    .DisplayLayout.Bands(0).Columns("Bonificacion").Width = 70
                    .DisplayLayout.Bands(0).Columns("Importe").Width = 70
                    .DisplayLayout.Bands(0).Columns("Peso").Width = 70
                    .DisplayLayout.Bands(0).Columns("Porcentaje").Width = 70
                    .DisplayLayout.Bands(0).Columns("FechaEmision").Width = 80
                    .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 80
                    .DisplayLayout.Bands(0).Columns("NroResolucion").Width = 80

                    .DisplayLayout.Bands(0).Columns("Descripcion").Header.Caption = "Tipo"
                    .DisplayLayout.Bands(0).Columns("FechaAdquisicion").Header.Caption = "Fecha"
                    .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
                    .DisplayLayout.Bands(0).Columns("Bonificacion").Header.Caption = "IGV"
                    .DisplayLayout.Bands(0).Columns("Importe").Header.Caption = "Prima"
                    .DisplayLayout.Bands(0).Columns("Peso").Header.Caption = "IGV"
                    .DisplayLayout.Bands(0).Columns("Porcentaje").Header.Caption = "Total"
                    .DisplayLayout.Bands(0).Columns("NroResolucion").Header.Caption = "Nro. Asiento"
                    FormatoColumna(griDatos, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Peso", "Porcentaje", "Importe")
                End If
            End With
            'If leDatos.Count > 0 Then
            '    ndSoles.Value = leDatos.Where(Function(it) it.IdMoneda = "SOLES").Sum(Function(it) it.Importe)
            '    ndDolares.Value = leDatos.Where(Function(it) it.IdMoneda <> "SOLES").Sum(Function(it) it.MontoInteresContable)
            'Else
            '    ndSoles.Value = 0 : ndDolares.Value = 0
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub mt_CargarDatos2(ByVal leDatos2 As List(Of e_ObligacionFin))
    '    Try
    '        With griReversion
    '            If lb_load Then .ResetDisplayLayout()
    '            .DataSource = leDatos2
    '            .Text = "LISTADO DE OBLIGACIONES A PROVISIONAR"
    '            If lb_load Then
    '                ConfiguraGrilla(griReversion, "Tahoma", True, UIElementBorderStyle.Default)
    '                OcultarColumna2(griReversion, False, "FechaVencimiento", "Banco", "NroContrato", "IdMoneda", "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
    '                                "DiasFinMes", "MontoInteresContable", "Glosa")
    '                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.VisiblePosition = 0
    '                .DisplayLayout.Bands(0).Columns("Banco").Header.VisiblePosition = 1
    '                .DisplayLayout.Bands(0).Columns("NroContrato").Header.VisiblePosition = 2
    '                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.VisiblePosition = 3
    '                .DisplayLayout.Bands(0).Columns("MontoMN").Header.VisiblePosition = 4
    '                .DisplayLayout.Bands(0).Columns("MontoME").Header.VisiblePosition = 5
    '                .DisplayLayout.Bands(0).Columns("MontoInteres").Header.VisiblePosition = 6
    '                .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.VisiblePosition = 7
    '                .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.VisiblePosition = 8
    '                .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.VisiblePosition = 9
    '                .DisplayLayout.Bands(0).Columns("Glosa").Header.VisiblePosition = 10
    '                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Width = 65
    '                .DisplayLayout.Bands(0).Columns("IdMoneda").Width = 65
    '                .DisplayLayout.Bands(0).Columns("Banco").Width = 160
    '                .DisplayLayout.Bands(0).Columns("NroContrato").Width = 140
    '                .DisplayLayout.Bands(0).Columns("Glosa").Width = 200
    '                .DisplayLayout.Bands(0).Columns("FechaVencimiento").Header.Caption = "Fec. Venc."
    '                .DisplayLayout.Bands(0).Columns("DiasProximaCuota").Header.Caption = "Total Dias"
    '                .DisplayLayout.Bands(0).Columns("DiasFinMes").Header.Caption = "Dias Mes"
    '                .DisplayLayout.Bands(0).Columns("MontoInteresContable").Header.Caption = "Prov. Interes"
    '                .DisplayLayout.Bands(0).Columns("IdMoneda").Header.Caption = "Moneda"
    '                FormatoColumna(griReversion, "#,##0.00", ColumnStyle.Double, HAlign.Right, "MontoMN", "MontoME", "MontoInteres", "DiasProximaCuota", _
    '                               "DiasFinMes", "MontoInteresContable")
    '            End If
    '        End With
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

#End Region

    
End Class
