'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ISL.LogicaWCF
Imports ERP.EntidadesWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frm_LibroInventariosBalances

    Inherits ISL.Win.frm_MenuPadre
    Private Shared instancia As frm_LibroInventariosBalances = Nothing
    Private Shared Operacion As String
    Private oeAsiento As New e_Asiento, olAsiento As New l_Asiento
    Private olPeriodo As New l_Periodo, oePeriodo As New e_Periodo
    Private IdPeriodo As String
    Private AlmacenarTab As Integer = 0
    Private Grilla As UltraGrid

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_LibroInventariosBalances
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            BarraProgreso1.Maximum = 55
            BarraProgreso1.Minimum = 0
            BarraProgreso1.Visible = True
            BarraProgreso1.Value = 5
            BarraProgreso1.Refresh()

            ProcesarReportes()

            Tiempo1.Enabled = True
            Operacion = "Inicializa"
            MyBase.Consultar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
            BarraProgreso1.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"
    Public Sub ProcesarReportes()
        Try
            Dim num As Integer = 0
            Dim rpt As String = ""
            Dim checkedItemList As ICheckedItemList = DirectCast(cboReporte.Items.ValueList, ICheckedItemList)
            For i As Integer = 0 To cboReporte.Items.Count - 1
                Dim item As ValueListItem = cboReporte.Items(i)
                Dim chk_Estado As CheckState = checkedItemList.GetCheckState(i)
                If chk_Estado = CheckState.Checked Then
                    num += 1
                    rpt = item.DataValue.ToString
                    Select Case rpt
                        Case "BALGEN" ' BALANCE GENERAL
                            CargarBalanceGeneral()
                        Case "CTA10" ' CAJA Y BANCOS
                            CargarReporte(cboMes.Value, rv_DetSldCta10, rpt)
                        Case "CTA12" ' CLIENTES
                            CargarReporte(cboMes.Value, rv_DetSldCta12, rpt)
                        Case "CTA14"
                            CargarReporte(cboMes.Value, rv_DetSldCta14, rpt)
                        Case "CTA16"
                            CargarReporte(cboMes.Value, rv_DetSldCta16, rpt)
                        Case "CTA25"
                            CargarReporte(cboMes.Value, rv_DetSldCta25, rpt)
                        Case "CTA41"
                            CargarReporte(cboMes.Value, rv_DetSldCta41, rpt)
                        Case "CTA42"
                            CargarReporte(cboMes.Value, rv_DetSldCta42, rpt)
                        Case "CTA46"
                            CargarReporte(cboMes.Value, rv_DetSldCta46, rpt)
                        Case "CTA49"
                            CargarReporte(cboMes.Value, rv_DetSldCta49, rpt)
                        Case "BALCOMP" ' BALANCE DE COMPROBACION
                            CargarReporte(cboMes.Value, rv_BalanceComprobacion, rpt)
                        Case "EFE" ' ESTADO DE FLUJO EFECTIVO
                            CargarReporte(cboMes.Value, rv_HojaTrabajoEFE, rpt)
                        Case "ECPN" ' ESTADO DE COMPROBACION DE PATRIMONIO NETO
                            CargarReporte(cboMes.Value, rv_EstadoCambioPatrimonioNeto, rpt)
                        Case "EGPF" ' ESTADO DE GANANCIA Y PERDIDA POR FUNCION
                            CargarEstadoGanciasPerdidas(cboMes.Value, rv_EstadoCambioPatrimonioNeto, rpt)
                        Case "DPCU" ' DETALLE DE PLAN CONTABLE UTILIZADO
                            CargarReporte(cboMes.Value, rv_DetPlanCtbleUtil, rpt)
                        Case "DCPEF" ' DETALLE DE CUENTAS Y/O PARTIDAS DE LOS ESTADOS FINANCIEROS
                            CargarReporte(cboMes.Value, rv_DetCtasPartEstFin, rpt)
                    End Select
                    BarraProgreso1.Value = num * 5
                    BarraProgreso1.Refresh()
                End If
            Next
            If num = 1 Then
                tc_LibroInventarioyBalances.Tabs(rpt).Selected = True
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            If oePeriodo.Ejercicio <> Año1.Año Then

                oePeriodo = New e_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

                LlenaComboMes(cboMes, lePeriodo)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function CopyAnonymusToDataTable(Of T)(info As IEnumerable(Of T)) As DataTable
        Dim type = GetType(T)
        If type.Equals(GetType(DataRow)) Then
            Return TryCast(info, IEnumerable(Of DataRow)).CopyToDataTable()
        End If
        Dim dt As New DataTable
        Dim r As DataRow
        type.GetProperties().ToList().ForEach(Function(a) dt.Columns.Add(a.Name))
        For Each c In info
            r = dt.NewRow()
            c.[GetType]().GetProperties().ToList().ForEach(Function(a) InlineAssignHelper(r(a.Name), a.GetValue(c, Nothing)))
            dt.Rows.Add(r)
        Next
        Return dt
    End Function

    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub CargarEstadoGanciasPerdidas(ByVal ln_Mes As String, rv_rpt As Microsoft.Reporting.WinForms.ReportViewer, ByVal ls_CTA As String)
        Try
            ValidarCombo(cboMes, "Mes")

            Dim dt As New DataTable
            dt = olAsiento.ListarInventarioYBalances(ln_Mes, ls_CTA)
            For Each fila As DataRow In dt.Rows
                Select Case fila("Cuenta")
                    Case "00", "66", "92", "94", "95", "97", "98", "4017"
                        fila("Monto") = fila("Monto") * (-1)
                End Select
            Next
            dt.AcceptChanges()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim lstSelect1 As DataRow() = dt.Select("Cuenta in ('70')") ' Ventas
            Dim dtVentas As DataTable = lstSelect1.CopyToDataTable

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim lstSelect2 As DataRow() = dt.Select("Cuenta in ('92')") 'Costo de Ventas
            Dim dtCostoVentas As DataTable = lstSelect2.CopyToDataTable

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim lstSelect3 As DataRow() = dt.Select("Cuenta in ('94','95')") 'Gastos Operacionales
            Dim dtGastosOperacionales As DataTable = lstSelect3.CopyToDataTable

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim lstSelect4 As DataRow() = dt.Select("Cuenta in ('00','66','77','75','76','97','98')") ' Otros Ingresos
            For Each fila As DataRow In lstSelect4
                Select Case fila("Cuenta")
                    Case "66", "76"
                        fila("Descripcion") = "INGRESOS Y EGRESOS EXCEPCIONALES"
                    Case "75"
                        fila("Descripcion") = "OTROS INGRESOS DIVERSOS"
                    Case "00", "98"
                        fila("Descripcion") = "OTROS GASTOS OPERATIVOS"
                End Select
            Next

            Dim query = From p In lstSelect4.AsEnumerable() _
                           Group p By Key = p.Field(Of String)("Descripcion") Into Group _
                           Select Descripcion = Key, Monto = Group.Sum(Function(p) p.Field(Of Decimal)("Monto"))
            'Select New With {.Descripcion = Key, .Monto = Group.Sum(Function(p) p.Field(Of Decimal)("Monto"))}

            Dim dtOtrosIngresos As New DataTable
            dtOtrosIngresos.Columns.Add(New Data.DataColumn("Descripcion", Type.GetType("System.String")))
            dtOtrosIngresos.Columns.Add(New Data.DataColumn("Monto", Type.GetType("System.Decimal")))

            For Each a In query
                Dim dr As DataRow = dtOtrosIngresos.NewRow
                dr("Descripcion") = a.Descripcion
                dr("Monto") = a.Monto
                dtOtrosIngresos.Rows.Add(dr)
                dtOtrosIngresos.AcceptChanges()
            Next

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim lstSelect5 As DataRow() = dt.Select("Cuenta in ('4017')") ' Impuesto a la Renta
            Dim dtImpuestoRenta As DataTable = lstSelect5.CopyToDataTable

            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

            Me.rv_EstadosGanaciasPerdidasXFunc.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rv_EstadosGanaciasPerdidasXFunc.Visible = True

            Dim oReport1 As New ReportDataSource("dt_Ventas", dtVentas)
            Dim oReport2 As New ReportDataSource("dt_CostoVenta", dtCostoVentas)
            Dim oReport3 As New ReportDataSource("dt_GastosOperacionales", dtGastosOperacionales)
            Dim oReport4 As New ReportDataSource("dt_OtrosIngresos", dtOtrosIngresos)
            Dim oReport5 As New ReportDataSource("dt_ImpuestoRenta", dtImpuestoRenta)

            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Clear()
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.SetParameters(myParams)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Add(oReport1)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Add(oReport2)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Add(oReport3)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Add(oReport4)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.DataSources.Add(oReport5)
            Me.rv_EstadosGanaciasPerdidasXFunc.LocalReport.Refresh()
            Me.rv_EstadosGanaciasPerdidasXFunc.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarBalanceGeneral()
        Try
            ValidarCombo(cboMes, "Mes")
            Dim dt As DataTable = olAsiento.ListarBalanceGeneral(Año1.Año, CInt(cboMes.Text))
            Dim dtBG As DataTable
            Dim DtAC As DataTable
            Dim dtANC As DataTable
            Dim dtPC As DataTable
            Dim dtPNC As DataTable
            Dim dtPAT As DataTable
            Dim DtA As DataTable
            Dim DtTPasPat As DataTable

            Dim DtNinguno As DataRow() = dt.Select("PrimerClasificacion = 'NINGUNO'")

            Dim dtBGRows As DataRow() = dt.Select("PrimerClasificacion IN('ACTIVO CORRIENTE','ACTIVO NO CORRIENTE','PASIVO CORRIENTE','PASIVO NO CORRIENTE','PATRIMONIO')")
            If dtBGRows.Count > 1 Then
                dtBG = dtBGRows.CopyToDataTable
            Else
                dtBG = DtNinguno.CopyToDataTable
            End If

            Dim dtACRows As DataRow() = dt.Select("PrimerClasificacion = 'ACTIVO CORRIENTE'")
            If dtACRows.Count > 1 Then
                DtAC = dtACRows.CopyToDataTable
            Else
                DtAC = DtNinguno.CopyToDataTable
            End If
            Dim dtANCRows As DataRow() = dt.Select("PrimerClasificacion = 'ACTIVO NO CORRIENTE'")
            If dtANCRows.Count > 1 Then
                dtANC = dtANCRows.CopyToDataTable
            Else
                dtANC = DtNinguno.CopyToDataTable
            End If
            Dim dtPCRows As DataRow() = dt.Select("PrimerClasificacion = 'PASIVO CORRIENTE'")
            If dtPCRows.Count > 1 Then
                dtPC = dtPCRows.CopyToDataTable
            Else
                dtPC = DtNinguno.CopyToDataTable
            End If
            Dim dtPNCRows As DataRow() = dt.Select("PrimerClasificacion = 'PASIVO NO CORRIENTE'")
            If dtPNCRows.Count > 1 Then
                dtPNC = dtPNCRows.CopyToDataTable
            Else
                dtPNC = DtNinguno.CopyToDataTable
            End If
            Dim dtPATRows As DataRow() = dt.Select("PrimerClasificacion = 'PATRIMONIO'")
            If dtPATRows.Count > 1 Then
                dtPAT = dtPATRows.CopyToDataTable
            Else
                dtPAT = DtNinguno.CopyToDataTable
            End If
            Dim dtARows As DataRow() = dt.Select("PrimerClasificacion IN('ACTIVO CORRIENTE','ACTIVO NO CORRIENTE')")
            If dtARows.Count > 1 Then
                DtA = dtARows.CopyToDataTable
            Else
                DtA = DtNinguno.CopyToDataTable
            End If

            DtTPasPat = dtBG.Copy

            For Each obj As DataRow In DtTPasPat.Rows
                obj("TMN") = obj("TMN") * -1
            Next
            For Each ob As DataRow In dtPCRows
                DtTPasPat.ImportRow(ob)
            Next
            For Each ob As DataRow In dtPNCRows
                DtTPasPat.ImportRow(ob)
            Next
            For Each ob As DataRow In dtPATRows
                DtTPasPat.ImportRow(ob)
            Next

            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

            Me.rv_BalanceGeneral.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rv_BalanceGeneral.Visible = True

            Dim oReport As New ReportDataSource("dsEstadosFinancieros_dtEstadosFinancieros", dt)
            Dim oReport2 As New ReportDataSource("dsEstadosFinancieros_dtActivoCorriente", DtAC)
            Dim oReport3 As New ReportDataSource("dsEstadosFinancieros_dtActivoNoCorriente", dtANC)
            Dim oReport4 As New ReportDataSource("dsEstadosFinancieros_dtPasivoCorriente", dtPC)
            Dim oReport5 As New ReportDataSource("dsEstadosFinancieros_dtPasivoNoCorriente", dtPNC)
            Dim oReport6 As New ReportDataSource("dsEstadosFinancieros_dtPatrimonio", dtPAT)
            Dim oReport7 As New ReportDataSource("dsEstadosFinancieros_dtActivo", DtA)
            Dim oReport8 As New ReportDataSource("dsEstadosFinancieros_dtTotalPasivoPatrimonio", DtTPasPat)
            Dim oReport9 As New ReportDataSource("dsEstadosFinancieros_dtBG", dtBG)

            Me.rv_BalanceGeneral.LocalReport.DataSources.Clear()
            Me.rv_BalanceGeneral.LocalReport.SetParameters(myParams)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport2)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport3)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport4)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport5)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport6)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport7)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport8)
            Me.rv_BalanceGeneral.LocalReport.DataSources.Add(oReport9)
            Me.rv_BalanceGeneral.LocalReport.Refresh()
            Me.rv_BalanceGeneral.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarReporte(ByVal ln_Mes As String, rv_rpt As Microsoft.Reporting.WinForms.ReportViewer, ByVal ls_CTA As String)
        Try
            Dim dt As New DataTable
            dt = olAsiento.ListarInventarioYBalances(ln_Mes, ls_CTA)

            rv_rpt.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

            Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
            myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
            myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
            Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

            rv_rpt.LocalReport.DataSources.Clear()
            rv_rpt.LocalReport.SetParameters(myParams)
            rv_rpt.LocalReport.DataSources.Add(oReport)

            rv_rpt.LocalReport.Refresh()
            rv_rpt.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
        End Try
    End Sub

    'Private Sub CargarDetalleSaldoCuenta10()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA10") ' CAJA Y BANCOS

    '        rv_DetSaldCta10.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSaldCta10.LocalReport.DataSources.Clear()
    '        rv_DetSaldCta10.LocalReport.SetParameters(myParams)
    '        rv_DetSaldCta10.LocalReport.DataSources.Add(oReport)

    '        rv_DetSaldCta10.LocalReport.Refresh()
    '        rv_DetSaldCta10.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta12()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA12") ' CLIENTES

    '        rv_DetSldCta12.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
    '        'ReportViewer1.LocalReport.DataSources.Clear()


    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta12.LocalReport.DataSources.Clear()
    '        rv_DetSldCta12.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta12.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta12.LocalReport.Refresh()
    '        rv_DetSldCta12.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta14()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA14")

    '        rv_DetSldCta14.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
    '        'ReportViewer1.LocalReport.DataSources.Clear()

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta14.LocalReport.DataSources.Clear()
    '        rv_DetSldCta14.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta14.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta14.LocalReport.Refresh()
    '        rv_DetSldCta14.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta16()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA16")

    '        rv_DetSldCta16.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)
    '        'ReportViewer1.LocalReport.DataSources.Clear()

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta16.LocalReport.DataSources.Clear()
    '        rv_DetSldCta16.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta16.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta16.LocalReport.Refresh()
    '        rv_DetSldCta16.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta25()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA25")

    '        rv_DetSldCta25.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta25.LocalReport.DataSources.Clear()
    '        rv_DetSldCta25.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta25.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta25.LocalReport.Refresh()
    '        rv_DetSldCta25.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta41()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA41")

    '        rv_DetSldCta41.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta41.LocalReport.DataSources.Clear()
    '        rv_DetSldCta41.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta41.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta41.LocalReport.Refresh()
    '        rv_DetSldCta41.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta42()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA42")

    '        rv_DetSldCta42.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta42.LocalReport.DataSources.Clear()
    '        rv_DetSldCta42.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta42.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta42.LocalReport.Refresh()
    '        rv_DetSldCta42.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta46()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA46")

    '        rv_DetSldCta46.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta46.LocalReport.DataSources.Clear()
    '        rv_DetSldCta46.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta46.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta46.LocalReport.Refresh()
    '        rv_DetSldCta46.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub CargarDetalleSaldoCuenta49()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "CTA49")

    '        rv_DetSldCta49.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_DetSldCta49.LocalReport.DataSources.Clear()
    '        rv_DetSldCta49.LocalReport.SetParameters(myParams)
    '        rv_DetSldCta49.LocalReport.DataSources.Add(oReport)

    '        rv_DetSldCta49.LocalReport.Refresh()
    '        rv_DetSldCta49.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub BalanceComprobacion()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "BALCOMP")

    '        rv_BalanceComprobacion.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As Microsoft.Reporting.WinForms.ReportParameter
    '        myParams(0) = New Microsoft.Reporting.WinForms.ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New Microsoft.Reporting.WinForms.ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_BalanceComprobacion.LocalReport.DataSources.Clear()
    '        rv_BalanceComprobacion.LocalReport.SetParameters(myParams)
    '        rv_BalanceComprobacion.LocalReport.DataSources.Add(oReport)

    '        rv_BalanceComprobacion.LocalReport.Refresh()
    '        rv_BalanceComprobacion.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    'Private Sub HojaTrabajoEFE()
    '    Try
    '        Dim dt As New DataTable
    '        Dim olAsiento As New l_Asiento
    '        dt = olAsiento.ListarInventarioYBalances(cboMes.Value, "EFE")

    '        rv_HojaTrabajoEFE.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

    '        Dim myParams(1) As ReportParameter
    '        myParams(0) = New ReportParameter("Ejercicio", Año1.Año.ToString, True)
    '        myParams(1) = New ReportParameter("Mes", cboMes.Text, True)

    '        Dim oReport As New ReportDataSource("dsInventariosBalances_DtInventariosBalances", dt)

    '        rv_HojaTrabajoEFE.LocalReport.DataSources.Clear()
    '        rv_HojaTrabajoEFE.LocalReport.SetParameters(myParams)
    '        rv_HojaTrabajoEFE.LocalReport.DataSources.Add(oReport)

    '        'AddHandler rv_HojaTrabajoEFE.LocalReport.SubreportProcessing, AddressOf Me.SubreportProcessingEventHandler

    '        rv_HojaTrabajoEFE.LocalReport.Refresh()
    '        rv_HojaTrabajoEFE.RefreshReport()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensaje del sistema", MessageBoxButtons.OK)
    '    End Try
    'End Sub

    Private Sub rv_HojaTrabajoEFE_Drillthrough(sender As System.Object, e As DrillthroughEventArgs) Handles rv_HojaTrabajoEFE.Drillthrough
        Dim LR As LocalReport = DirectCast(e.Report, LocalReport)

        Dim tbl As DataTable = New DataTable("Datos")
        Dim Id As DataColumn = New DataColumn
        Id.DataType = System.Type.GetType("System.String")
        Id.ColumnName = "Id"
        tbl.Columns.Add(Id)
        Dim Codigo As DataColumn = New DataColumn
        Codigo.DataType = System.Type.GetType("System.String")
        Codigo.ColumnName = "Codigo"
        tbl.Columns.Add(Codigo)
        Dim Nombre As DataColumn = New DataColumn
        Nombre.DataType = System.Type.GetType("System.String")
        Nombre.ColumnName = "Nombre"
        tbl.Columns.Add(Nombre)
        Dim Abreviatura As DataColumn = New DataColumn
        Abreviatura.DataType = System.Type.GetType("System.String")
        Abreviatura.ColumnName = "Abreviatura"
        tbl.Columns.Add(Abreviatura)
        Dim rw As DataRow = tbl.NewRow()
        rw("Id") = "0001"
        rw("Codigo") = "COD01"
        rw("Nombre") = "Olmer"
        rw("Abreviatura") = "OJCM"
        tbl.Rows.Add(rw)

        LR.DataSources.Add(New ReportDataSource("DataSet1", tbl))
    End Sub

    'Public Sub SubreportProcessingEventHandler(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
    '    Select Case e.ReportPath
    '        Case "rpt_EstadoFlujoEfectivo"
    '            Dim tbl As DataTable = New DataTable("Datos")
    '            Dim Id As DataColumn = New DataColumn
    '            Id.DataType = System.Type.GetType("System.String")
    '            Id.ColumnName = "Id"
    '            tbl.Columns.Add(Id)
    '            Dim Codigo As DataColumn = New DataColumn
    '            Codigo.DataType = System.Type.GetType("System.String")
    '            Codigo.ColumnName = "Codigo"
    '            tbl.Columns.Add(Codigo)
    '            Dim Nombre As DataColumn = New DataColumn
    '            Nombre.DataType = System.Type.GetType("System.String")
    '            Nombre.ColumnName = "Nombre"
    '            tbl.Columns.Add(Nombre)
    '            Dim Abreviatura As DataColumn = New DataColumn
    '            Abreviatura.DataType = System.Type.GetType("System.String")
    '            Abreviatura.ColumnName = "Abreviatura"
    '            tbl.Columns.Add(Abreviatura)
    '            Dim rw As DataRow = tbl.NewRow()
    '            rw("Id") = "0001"
    '            rw("Codigo") = "COD01"
    '            rw("Nombre") = "Olmer"
    '            rw("Abreviatura") = "OJCM"
    '            tbl.Rows.Add(rw)
    '            e.DataSources.Add(New ReportDataSource("DataSet1", tbl))

    '    End Select
    'End Sub
#End Region

#Region "Eventos"

    Private Sub frm_LibroInventariosBalances_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_LibroInventariosBalances_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_EstadosFinancieros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_LibroInventariosBalances_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btn_Retornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tc_LibroInventarioyBalances.Tabs(AlmacenarTab).Selected = True
    End Sub

    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region


End Class
