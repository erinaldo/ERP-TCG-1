Imports ISL.LogicaWCF
Imports ISL.EntidadesWCF
Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win.UltraWinGrid

Public Class frm_EstadosFinancieros
    Inherits ISL.Win.frm_MenuPadre
    Private Shared instancia As frm_EstadosFinancieros = Nothing
    Private Shared Operacion As String
    Private oeAsiento As New e_Asiento, olAsiento As New l_Asiento
    Private oePeriodo As New e_Periodo
    Private IdPeriodo As String
    Private AlmacenarTab As Integer = 0
    Private Grilla As UltraGrid

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Public Overrides Function getInstancia() As frm_MenuPadre
        If IndMultiInstancia = "NO" Then
            If instancia Is Nothing Then
                Operacion = "Inicializa"
                instancia = New frm_EstadosFinancieros
            End If
        Else
            Operacion = "Inicializa"
            instancia = New frm_EstadosFinancieros
        End If
        instancia.Activate()
        Return instancia
    End Function

#Region "Botones"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            BarraProgreso1.Maximum = 25
            BarraProgreso1.Minimum = 0
            BarraProgreso1.Visible = True
            BarraProgreso1.Value = 5
            BarraProgreso1.Refresh()

            CargaReporteEEFF()
            BarraProgreso1.Value = 10
            BarraProgreso1.Refresh()

            ListarComprobacion(Activo)
            BarraProgreso1.Value = 15
            BarraProgreso1.Refresh()

            ListarComprobacionDestino(Activo)
            BarraProgreso1.Value = 20
            BarraProgreso1.Refresh()

            ListarAsientoDescuadrados(Activo)
            BarraProgreso1.Value = 25
            BarraProgreso1.Refresh()

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

    ''' <summary>
    ''' Método para exportar el contenido del formulario hacia la hoja de cálculo Excel
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub Exportar()
        Try
            'If Grilla.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
            Select Case tcEstadosFinancieros.SelectedTab.Index
                Case 1
                    Exportar_Excel(grid_BalanceComprobacion)
                Case 2
                    Exportar_Excel(grid_BalanceCompDestino)
                Case 3
                    Exportar_Excel(grid_AsientoDescuadrado)
                Case 4
                    Exportar_Excel(grid_DetalleMovimientos)
            End Select
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Public Overrides Sub Salir()
        MyBase.Salir()
    End Sub

#End Region

#Region "Métodos"

    Private Sub ListarComprobacion(ByVal Activo As Boolean)
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim obj As New e_Periodo
            obj = cboMes.Items(cboMes.SelectedIndex).ListObject

            oeAsiento = New e_Asiento
            oeAsiento.IdPeriodo = cboMes.Value
            oeAsiento._Mes = obj.Mes
            oeAsiento._Ejercicio = Año1.Año
            LimpiaGrid(grid_BalanceComprobacion, UltraDataSource1)
            With grid_BalanceComprobacion
                .DataSource = olAsiento.ListarBalanceComprobacion(oeAsiento)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True

                    If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value > 0 Then
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeAn").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value)
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaAn").SetExternalSummaryValue("")
                    Else
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeAn").SetExternalSummaryValue("")
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaAn").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value)
                    End If

                    If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value >= 0 Then
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeMo").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value)
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaMo").SetExternalSummaryValue("")
                    Else
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeMo").SetExternalSummaryValue("")
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaMo").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value)
                    End If

                    If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value >= 0 Then
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeSa").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value)
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaSa").SetExternalSummaryValue("")
                    Else
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeSa").SetExternalSummaryValue("")
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaSa").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value)
                    End If

                    If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value >= 0 Then
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value)
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue("")
                    Else
                        grid_BalanceComprobacion.Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue("")
                        grid_BalanceComprobacion.Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value)
                    End If
                End If
            End With

        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub ListarComprobacionDestino(ByVal Activo As Boolean)
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim obj As New e_Periodo
            obj = cboMes.Items(cboMes.SelectedIndex).ListObject

            oeAsiento = New e_Asiento
            oeAsiento.IdPeriodo = cboMes.Value
            oeAsiento._Mes = obj.Mes
            LimpiaGrid(grid_BalanceCompDestino, odBalComprobacionDestino)
            With grid_BalanceCompDestino
                .DataSource = olAsiento.ListarBalanceComprobacionDestino(oeAsiento)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If

            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ListarAsientoDescuadrados(ByVal Activo As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim obj As New e_Periodo
            obj = cboMes.Items(cboMes.SelectedIndex).ListObject

            oeAsiento = New e_Asiento
            oeAsiento.IdPeriodo = cboMes.Value
            IdPeriodo = cboMes.Value
            oeAsiento._Mes = obj.Mes
            LimpiaGrid(grid_AsientoDescuadrado, odAsientosDescuadrados)
            With grid_AsientoDescuadrado
                .DataSource = olAsiento.ListarAsientosDescuadrados(oeAsiento)
                If .Rows.Count > 0 Then
                    .Focus()
                    .Rows.Item(0).Selected = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ComboPeriodo()
        Try
            If oePeriodo.Ejercicio <> Año1.Año Then
                oePeriodo = New e_Periodo
                Dim olPeriodo As New l_Periodo
                Dim lePeriodo As New List(Of e_Periodo)
                oePeriodo.Ejercicio = Año1.Año
                oePeriodo.Activo = True
                lePeriodo.AddRange(olPeriodo.Listar(oePeriodo))

                With cboMes
                    .DisplayMember = "NomMes"
                    .ValueMember = "Id"
                    .DataSource = lePeriodo
                    If .Items.Count > 0 Then
                        .SelectedIndex = -1
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaReporteEEFF()
        Try
            ValidarCombo(cboMes, "Mes")

            Dim objPeriodo As New e_Periodo
            objPeriodo = cboMes.Items(cboMes.SelectedIndex).ListObject

            Dim dt As DataTable = olAsiento.ListarEEFF(Año1.Año, objPeriodo.Mes)

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

            Me.rpEstadosFinancieros.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            Me.rpEstadosFinancieros.Visible = True
            Dim oReport As New ReportDataSource("dsEstadosFinancieros_dtEstadosFinancieros", dt)
            Dim oReport2 As New ReportDataSource("dsEstadosFinancieros_dtActivoCorriente", dtAC)
            Dim oReport3 As New ReportDataSource("dsEstadosFinancieros_dtActivoNoCorriente", dtANC)
            Dim oReport4 As New ReportDataSource("dsEstadosFinancieros_dtPasivoCorriente", dtPC)
            Dim oReport5 As New ReportDataSource("dsEstadosFinancieros_dtPasivoNoCorriente", dtPNC)
            Dim oReport6 As New ReportDataSource("dsEstadosFinancieros_dtPatrimonio", dtPAT)
            Dim oReport7 As New ReportDataSource("dsEstadosFinancieros_dtActivo", DtA)
            Dim oReport8 As New ReportDataSource("dsEstadosFinancieros_dtTotalPasivoPatrimonio", DtTPasPat)
            Dim oReport9 As New ReportDataSource("dsEstadosFinancieros_dtBG", dtBG)

            Me.Text = "Estados Financieros"
            Me.rpEstadosFinancieros.LocalReport.DataSources.Clear()
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport2)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport3)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport4)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport5)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport6)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport7)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport8)
            Me.rpEstadosFinancieros.LocalReport.DataSources.Add(oReport9)
            Me.rpEstadosFinancieros.LocalReport.Refresh()
            Me.rpEstadosFinancieros.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ListarDetalles(ByVal lsTipo As String, Optional ByVal lsCuentaContable As String = "", _
    Optional ByVal lsItemgGasto As String = "")
        Try
            Dim dt As New DataTable
            dt = olAsiento.ListarDetalles(lsTipo, IdPeriodo, lsCuentaContable, lsItemgGasto)
            Select Case lsTipo
                Case "DebeMoBC", "HaberMoBC"
                    AlmacenarTab = 1
                Case "DebeMoBD", "HaberMoBD"
                    AlmacenarTab = 2
            End Select
            grid_DetalleMovimientos.DataSource = dt
            grid_DetalleMovimientos.DataBind()
            tcEstadosFinancieros.Tabs(4).Selected = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_EstadosFinancieros_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_EstadosFinancieros_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_EstadosFinancieros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_EstadosFinancieros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid2BalanceComprobacion_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles grid_BalanceComprobacion.DoubleClickCell
        Try
            Select Case e.Cell.Column.Key
                Case "DebeMo"
                    ListarDetalles("DebeMoBC", grid_BalanceComprobacion.ActiveRow.Cells("IdCuentaContable").Value)
                Case "HaberMo"
                    ListarDetalles("HaberMoBC", grid_BalanceComprobacion.ActiveRow.Cells("IdCuentaContable").Value)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub GridBalanceCompDestino_DoubleClickCell(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickCellEventArgs) Handles grid_BalanceCompDestino.DoubleClickCell
        Try
            Select Case e.Cell.Column.Key
                Case "DebeMo"
                    ListarDetalles("DebeMoBD", "", grid_BalanceCompDestino.ActiveRow.Cells("IdGastoFuncion").Value)
                Case "HaberMo"
                    ListarDetalles("HaberMoBD", "", grid_BalanceCompDestino.ActiveRow.Cells("IdGastoFuncion").Value)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btn_Retornar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Retornar.Click
        tcEstadosFinancieros.Tabs(AlmacenarTab).Selected = True
    End Sub

    Private Sub GridDetalleMovimientos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_DetalleMovimientos.Click
        Grilla = grid_DetalleMovimientos
    End Sub

    Private Sub gridAsientoDescuadrado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_AsientoDescuadrado.Click
        Grilla = grid_AsientoDescuadrado
    End Sub

    Private Sub grid2BalanceComprobacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_BalanceComprobacion.Click
        Grilla = grid_BalanceComprobacion
    End Sub

    Private Sub GridBalanceCompDestino_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid_BalanceCompDestino.Click
        Grilla = grid_BalanceCompDestino
    End Sub

#End Region

    Private Sub Año1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Año1.Validated
        Try
            ComboPeriodo()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_BalanceComprobacion_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grid_BalanceComprobacion.InitializeLayout
        Try

            With e.Layout.Bands(0).Summaries
                If Not .Exists("DifDeAn") Then
                    .Add("DifDeAn", SummaryType.External, e.Layout.Bands(0).Columns("DebeAn"))
                    .Item("DifDeAn").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeAn").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaAn") Then
                    .Add("DifHaAn", SummaryType.External, e.Layout.Bands(0).Columns("HaberAn"))
                    .Item("DifHaAn").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaAn").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeMo") Then
                    .Add("DifDeMo", SummaryType.External, e.Layout.Bands(0).Columns("DebeMo"))
                    .Item("DifDeMo").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeMo").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaMo") Then
                    .Add("DifHaMo", SummaryType.External, e.Layout.Bands(0).Columns("HaberMo"))
                    .Item("DifHaMo").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaMo").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeSa") Then
                    .Add("DifDeSa", SummaryType.External, e.Layout.Bands(0).Columns("DebeSa"))
                    .Item("DifDeSa").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeSa").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaSa") Then
                    .Add("DifHaSa", SummaryType.External, e.Layout.Bands(0).Columns("HaberSa"))
                    .Item("DifHaSa").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaSa").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeSaAc") Then
                    .Add("DifDeSaAc", SummaryType.External, e.Layout.Bands(0).Columns("DebeSaAc"))
                    .Item("DifDeSaAc").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeSaAc").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaSaAc") Then
                    .Add("DifHaSaAc", SummaryType.External, e.Layout.Bands(0).Columns("HaberSaAc"))
                    .Item("DifHaSaAc").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaSaAc").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_BalanceComprobacion_SummaryValueChanged(sender As Object, e As SummaryValueChangedEventArgs) Handles grid_BalanceComprobacion.SummaryValueChanged
        Try
            If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value >= 0 Then
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeAn").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value)
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaAn").SetExternalSummaryValue("")
            Else
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeAn").SetExternalSummaryValue("")
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaAn").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberAn").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeAn").Value)
            End If

            If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value >= 0 Then
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeMo").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value)
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaMo").SetExternalSummaryValue("")
            Else
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeMo").SetExternalSummaryValue("")
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaMo").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberMo").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeMo").Value)
            End If

            If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value >= 0 Then
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeSa").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value)
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaSa").SetExternalSummaryValue("")
            Else
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeSa").SetExternalSummaryValue("")
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaSa").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSa").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSa").Value)
            End If

            If grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value >= 0 Then
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value)
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue("")
            Else
                grid_BalanceComprobacion.Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue("")
                grid_BalanceComprobacion.Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue(grid_BalanceComprobacion.Rows.SummaryValues("Suma_HaberSaAc").Value - grid_BalanceComprobacion.Rows.SummaryValues("Suma_DebeSaAc").Value)
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try

    End Sub

    Private Sub grid_BalanceCompDestino_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grid_BalanceCompDestino.InitializeLayout
        Try

            With e.Layout.Bands(0).Summaries
                If Not .Exists("DifDeAn") Then
                    .Add("DifDeAn", SummaryType.External, e.Layout.Bands(0).Columns("DebeAn"))
                    .Item("DifDeAn").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeAn").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaAn") Then
                    .Add("DifHaAn", SummaryType.External, e.Layout.Bands(0).Columns("HaberAn"))
                    .Item("DifHaAn").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaAn").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeMo") Then
                    .Add("DifDeMo", SummaryType.External, e.Layout.Bands(0).Columns("DebeMo"))
                    .Item("DifDeMo").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeMo").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaMo") Then
                    .Add("DifHaMo", SummaryType.External, e.Layout.Bands(0).Columns("HaberMo"))
                    .Item("DifHaMo").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaMo").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeSa") Then
                    .Add("DifDeSa", SummaryType.External, e.Layout.Bands(0).Columns("DebeSa"))
                    .Item("DifDeSa").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeSa").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaSa") Then
                    .Add("DifHaSa", SummaryType.External, e.Layout.Bands(0).Columns("HaberSa"))
                    .Item("DifHaSa").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaSa").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifDeSaAc") Then
                    .Add("DifDeSaAc", SummaryType.External, e.Layout.Bands(0).Columns("DebeSaAc"))
                    .Item("DifDeSaAc").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifDeSaAc").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

                If Not .Exists("DifHaSaAc") Then
                    .Add("DifHaSaAc", SummaryType.External, e.Layout.Bands(0).Columns("HaberSaAc"))
                    .Item("DifHaSaAc").DisplayFormat = "{0:#,##0.00}"
                    .Item("DifHaSaAc").Appearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If

            End With
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub grid_BalanceCompDestino_SummaryValueChanged(sender As Object, e As SummaryValueChangedEventArgs) Handles grid_BalanceCompDestino.SummaryValueChanged
        Try
            With grid_BalanceCompDestino
                If .Rows.SummaryValues("sumDebeAn").Value - .Rows.SummaryValues("sumHaberAn").Value >= 0 Then
                    .Rows.SummaryValues("DifDeAn").SetExternalSummaryValue(.Rows.SummaryValues("sumDebeAn").Value - .Rows.SummaryValues("sumHaberAn").Value)
                    .Rows.SummaryValues("DifHaAn").SetExternalSummaryValue("")
                Else
                    .Rows.SummaryValues("DifDeAn").SetExternalSummaryValue("")
                    .Rows.SummaryValues("DifHaAn").SetExternalSummaryValue(.Rows.SummaryValues("sumHaberAn").Value - .Rows.SummaryValues("SumDebeAn").Value)
                End If

                If .Rows.SummaryValues("sumDebeMo").Value - .Rows.SummaryValues("sumHaberMo").Value >= 0 Then
                    .Rows.SummaryValues("DifDeMo").SetExternalSummaryValue(.Rows.SummaryValues("sumDebeMo").Value - .Rows.SummaryValues("SumHaberMo").Value)
                    .Rows.SummaryValues("DifHaMo").SetExternalSummaryValue("")
                Else
                    .Rows.SummaryValues("DifDeMo").SetExternalSummaryValue("")
                    .Rows.SummaryValues("DifHaMo").SetExternalSummaryValue(.Rows.SummaryValues("sumHaberMo").Value - .Rows.SummaryValues("SumDebeMo").Value)
                End If

                If .Rows.SummaryValues("sumDebeSa").Value - .Rows.SummaryValues("sumHaberSa").Value >= 0 Then
                    .Rows.SummaryValues("DifDeSa").SetExternalSummaryValue(.Rows.SummaryValues("sumDebeSa").Value - .Rows.SummaryValues("sumHaberSa").Value)
                    .Rows.SummaryValues("DifHaSa").SetExternalSummaryValue("")
                Else
                    .Rows.SummaryValues("DifDeSa").SetExternalSummaryValue("")
                    .Rows.SummaryValues("DifHaSa").SetExternalSummaryValue(.Rows.SummaryValues("sumHaberSa").Value - .Rows.SummaryValues("sumDebeSa").Value)
                End If

                If .Rows.SummaryValues("SumDebeSaAc").Value - .Rows.SummaryValues("SumHaberSaAc").Value >= 0 Then
                    .Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue(.Rows.SummaryValues("SumDebeSaAc").Value - .Rows.SummaryValues("sumHaberSaAc").Value)
                    .Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue("")
                Else
                    .Rows.SummaryValues("DifDeSaAc").SetExternalSummaryValue("")
                    .Rows.SummaryValues("DifHaSaAc").SetExternalSummaryValue(.Rows.SummaryValues("SumHaberSaAc").Value - .Rows.SummaryValues("sumDebeSaAc").Value)
                End If
            End With

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub
End Class
