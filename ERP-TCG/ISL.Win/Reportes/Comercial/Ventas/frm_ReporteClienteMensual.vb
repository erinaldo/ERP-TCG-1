'=================================================================================================================
' Historial de Cambios
'=================================================================================================================
' Nro   |   Fecha       |   User    |   Descripcion
'-----------------------------------------------------------------------------------------------------------------
' @0001 |   2019-09-01  |  CT2010   |   Combios generales Prefijo
'=================================================================================================================

Imports ERP.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles
Imports Infragistics.UltraChart.Resources.Appearance
Imports Infragistics.UltraChart.Core.Layers

Public Class frm_ReporteClienteMensual
    Inherits ISL.Win.frm_MenuPadre

#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteClienteMensual = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteClienteMensual()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaracion de Variables"

    Dim oeReporteCM As New e_ReporteClienteMensual
    Dim olReporteCM As New l_ReporteDocumento
    Dim leReporteCM As New List(Of e_ReporteClienteMensual)
    Dim lePareto As New List(Of e_ReporteClienteMensual)
    Dim leReporteCMAux As New List(Of e_ReporteClienteMensual)
    Dim leProduccion As New List(Of e_ReporteClienteMensual)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Cursor.Current = Cursors.WaitCursor
            oeReporteCM = New e_ReporteClienteMensual
            oeReporteCM.TipoOperacion = "1"
            oeReporteCM.Anio = fecPeriodo.Value.Date.Year
            oeReporteCM.Mes = fecPeriodo.Value.Date.Month
            'leReporteCM = olReporteCM.ListarRCM(oeReporteCM)
            leReporteCM = Crear_ListaMensual(olReporteCM.ListarRCM(oeReporteCM), 1)

            oeReporteCM = New e_ReporteClienteMensual
            oeReporteCM.TipoOperacion = "2"
            oeReporteCM.Anio = fecPeriodo.Value.Date.Year
            'leReporteCMAux = olReporteCM.ListarRCM(oeReporteCM)
            leReporteCMAux = Crear_ListaMensual(olReporteCM.ListarRCM(oeReporteCM), 2)

            oeReporteCM = New e_ReporteClienteMensual
            oeReporteCM.TipoOperacion = "3"
            oeReporteCM.Anio = fecPeriodo.Value.Date.Year
            leProduccion = olReporteCM.ListarRCM(oeReporteCM)

            Cargar_RCM(leReporteCM)

            If griClienteMensual.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If

            ficClienteMensual.Tabs(1).Enabled = False
            ficClienteMensual.Tabs(2).Enabled = False
            ficClienteMensual.SelectedTab = ficClienteMensual.Tabs(0)
            btnPareto.Enabled = True
            btnProduccion.Enabled = True

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Select Case ficClienteMensual.SelectedTab.Index
                Case 0
                    Exportar_Excel(griClienteMensual)
                Case 1
                    Exportar_Excel(griEvolucionCliente)
                Case 2
                    Exportar_Excel(griProdFact)
            End Select
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteClienteMensual_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If griClienteMensual.Rows.Count > 0 Then
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
        End If
    End Sub

    Private Sub frm_ReporteClienteMensual_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteClienteMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fecPeriodo.Value = Convert.ToDateTime("01/" & Date.Now.Month.ToString & "/" & Date.Now.Year.ToString)
            decTotalFac.Value = 0
            decTotalND.Value = 0
            decTotalNC.Value = 0
            MostrarTabs(0, ficClienteMensual)
            Cargar_RCM(New List(Of e_ReporteClienteMensual))
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            mt_CargarImagenes()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnPareto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPareto.Click
        Try
            If griClienteMensual.Rows.Count > 1 Then
                btnPareto.Enabled = False
                ficClienteMensual.Tabs(1).Enabled = True
                ficClienteMensual.SelectedTab = ficClienteMensual.Tabs(1)
                Dim leClieAux = lePareto.Where(Function(item) item.IndPareto = 1).ToList
                Dim dtPareto As Data.DataTable = Crear_DTPareto()

                For Each oeAux In leClieAux
                    Dim rw As Data.DataRow
                    Dim idclie = oeAux.IdCliente
                    rw = dtPareto.NewRow
                    rw("Cliente") = oeAux.Cliente
                    ' Dim leAux = leReporteCMAux.Where(Function(item) item.IdCliente = idclie And item.TipoDoc = "FACTURA").ToList
                    Dim leAux = leReporteCMAux.Where(Function(item) item.IdCliente = idclie).ToList
                    For Each oeEvoAux In leAux
                        Dim _nommes = MonthName(CInt(oeEvoAux.Mes), True)
                        rw(_nommes & "_Monto") = oeEvoAux.Total
                    Next
                    dtPareto.Rows.Add(rw)
                Next

                Dim rwo As Data.DataRow
                rwo = dtPareto.NewRow
                rwo("Cliente") = "OTROS"

                Dim i As Integer = 1
                For i = 1 To 12
                    'Dim leAuxOtro = leReporteCMAux.Where(Function(item) item.IndPareto <> 1 And item.TipoDoc = "FACTURA" And CInt(item.Mes) = i).ToList
                    Dim leAuxOtro = leReporteCMAux.Where(Function(item) item.IndPareto <> 1 And CInt(item.Mes) = i).ToList
                    If leAuxOtro.Count > 0 Then
                        Dim _mesotro = MonthName(CInt(i), True)
                        rwo(_mesotro & "_Monto") = leAuxOtro.Sum(Function(item) item.Total)
                    End If
                Next

                dtPareto.Rows.Add(rwo)
                Dim j As Integer = 1
                For j = 1 To 12
                    Dim _porcax As Double = 0
                    Dim _mesporc = MonthName(j, True)
                    'Dim leAuxPorc = leReporteCMAux.Where(Function(item) item.TipoDoc = "FACTURA" And CInt(item.Mes) = j).ToList
                    Dim leAuxPorc = leReporteCMAux.Where(Function(item) CInt(item.Mes) = j).ToList
                    If leAuxPorc.Count > 0 Then
                        _porcax = leAuxPorc.Sum(Function(item) item.Total)
                        For Each rwx In dtPareto.Rows
                            If (Not IsDBNull(rwx(_mesporc & "_Monto"))) AndAlso rwx(_mesporc & "_Monto") > 0 Then
                                rwx(_mesporc & "_Porc") = Math.Round((rwx(_mesporc & "_Monto") / _porcax) * 100, 4)
                            End If

                        Next
                    End If
                Next

                For Each _fil In dtPareto.Rows
                    Dim _subtcli As Double = 0
                    For xi = 1 To 12
                        Dim _xmes = MonthName(xi, True)
                        _subtcli = _subtcli + IIf(IsDBNull(_fil(_xmes & "_Monto")), 0, _fil(_xmes & "_Monto"))
                    Next
                    _fil("Total") = _subtcli
                Next

                With griEvolucionCliente
                    .DataSource = dtPareto
                    For Each col In .DisplayLayout.Bands(0).Columns
                        If col.Key.Contains("_Monto") Or col.Key.Contains("_Porc") Or col.Key = "Total" Then
                            col.Style = ColumnStyle.Double
                            col.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                            col.Format = "#,###,##0.00"
                        End If
                    Next

                    .DisplayLayout.UseFixedHeaders = True
                    .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    .DisplayLayout.Bands(0).Columns("Cliente").Header.Fixed = True
                    .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    '.DisplayLayout.Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1

                End With

                CalcularTotales(griEvolucionCliente, "Ene_Monto", "Feb_Monto", "Mar_Monto", "Abr_Monto", "May_Monto", "Jun_Monto" _
                                , "Jul_Monto", "Ago_Monto", "Sep_Monto", "Oct_Monto", "Nov_Monto", "Dic_Monto")

                Crear_GraficoEvolucion(dtPareto)

            Else
                Throw New Exception("No hay registros para poder ver la Evolucion por Cliente")
            End If

        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub btnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduccion.Click
        Try
            Dim _totprod As Double = 0
            Dim _totfac As Double = 0
            If griClienteMensual.Rows.Count > 1 Then
                btnProduccion.Enabled = False
                ficClienteMensual.Tabs(2).Enabled = True
                ficClienteMensual.SelectedTab = ficClienteMensual.Tabs(2)
                Dim dtProduccion As Data.DataTable = Crear_DTProduccion()
                Dim rw As Data.DataRow
                rw = dtProduccion.NewRow
                rw("Tipo") = "PRODUCCION"
                Dim i As Integer = 1
                For i = 1 To 12
                    Dim _mesprod = MonthName(i, True)
                    Dim _leprodmes = leProduccion.Where(Function(le) le.Mes = i).ToList
                    If _leprodmes.Count > 0 Then
                        _totprod = _totprod + _leprodmes.Sum(Function(it) it.Total)
                        rw(_mesprod & "_Importe") = _leprodmes.Sum(Function(it) it.Total)
                    End If
                Next
                rw("Tot_Importe") = _totprod
                dtProduccion.Rows.Add(rw)
                Dim rwx As Data.DataRow
                rwx = dtProduccion.NewRow
                rwx("Tipo") = "FACTURACION"
                Dim j As Integer = 1
                For j = 1 To 12
                    Dim _mesfact = MonthName(j, True)
                    Dim _lefactmes = leReporteCMAux.Where(Function(le) le.Mes = j).ToList
                    If _lefactmes.Count > 0 Then
                        _totfac = _totfac + _lefactmes.Sum(Function(it) it.Total)
                        rwx(_mesfact & "_Importe") = _lefactmes.Sum(Function(it) it.Total)
                    End If
                Next
                rwx("Tot_Importe") = _totfac
                dtProduccion.Rows.Add(rwx)
                With griProdFact
                    .DataSource = dtProduccion
                    For Each col In .DisplayLayout.Bands(0).Columns
                        If col.Key.Contains("_Importe") Then
                            col.Style = ColumnStyle.Double
                            col.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                            col.Format = "#,###,##0.00"
                        End If
                    Next
                    .DisplayLayout.UseFixedHeaders = True
                    .DisplayLayout.Override.FixedHeaderIndicator = FixedHeaderIndicator.None
                    .DisplayLayout.Bands(0).Columns("Tipo").Header.Fixed = True
                    .DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False
                    .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                    .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                    .DisplayLayout.MaxColScrollRegions = 1
                    .DisplayLayout.MaxRowScrollRegions = 1
                End With
                Crear_GraficoProduccion(dtProduccion)
            Else
                Throw New Exception("No hay registros para Produccion vs Facturado")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub mt_CargarImagenes()
        Try
            Try
                For Each Item In gLstIconos
                    If Item.Nombre = "Grafico" Then btnPareto.Appearance.Image = Item.Icono : btnProduccion.Appearance.Image = Item.Icono : Exit For
                Next
            Catch ex As Exception
                Throw ex
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Cargar_RCM(ByVal leRCM As List(Of e_ReporteClienteMensual))
        Try
            With griClienteMensual

                Dim _totacu As Double = 0
                Dim _poracu As Double = 0
                Dim bandp As Boolean = True
                Dim _idcliaux As String = ""

                ' Dim _totalRCM = leRCM.Where(Function(le) le.TipoDoc = "FACTURA").Sum(Function(it) it.Total)
                Dim _totalRCM = leRCM.Sum(Function(it) it.Total)
                ' lePareto = leRCM.Where(Function(le) le.TipoDoc = "FACTURA").ToList
                lePareto = leRCM
                For Each oe In lePareto
                    oe.PorcTotal = Math.Round((oe.Total / _totalRCM) * 100, 4)
                    _totacu = _totacu + oe.Total
                    _poracu = _poracu + oe.PorcTotal
                    oe.Acumulado = _totacu
                    oe.PorcAcumulado = _poracu
                    oe.IndPareto = IIf(bandp, 1, 0)
                    If bandp Then
                        _idcliaux = oe.IdCliente
                        For Each oeAux In leReporteCMAux.Where(Function(item) item.IdCliente = _idcliaux).ToList
                            oeAux.IndPareto = 1
                        Next
                    End If
                    If (oe.PorcAcumulado / 80) >= 1 Then bandp = False
                Next

                .DataSource = lePareto

                ConfiguraGrilla(griClienteMensual, "Tahoma", True, UIElementBorderStyle.Default)

                OcultarColumna2(griClienteMensual, False, "NroDoc", "Cliente", "Total", "PorcTotal", "Acumulado", "PorcAcumulado")

                .DisplayLayout.Bands(0).Columns("Cliente").Width = 300

                .DisplayLayout.Bands(0).Columns("NroDoc").Header.Caption = "RUC"
                .DisplayLayout.Bands(0).Columns("Total").Header.Caption = "Total (S/)"
                .DisplayLayout.Bands(0).Columns("PorcTotal").Header.Caption = "Total (%)"
                .DisplayLayout.Bands(0).Columns("Acumulado").Header.Caption = "Acumulado (S/)"
                .DisplayLayout.Bands(0).Columns("PorcAcumulado").Header.Caption = "Acumulado (%)"

                FormatoColumna(griClienteMensual, "#,##0.00", ColumnStyle.Double, HAlign.Right, "Total", "PorcTotal", "Acumulado", "PorcAcumulado")

                For Each Fila In .Rows
                    If Fila.Cells("IndPareto").Value = 1 Then
                        Fila.Appearance.BackColor = Color.LightGreen
                    Else
                        Exit For
                    End If
                Next

            End With

            CalcularTotales(griClienteMensual, "Total", "PorcTotal")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Crear_DTPareto() As Data.DataTable
        Dim dt As New Data.DataTable
        With dt
            .Columns.Add(New Data.DataColumn("Cliente", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ene_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Ene_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Feb_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Feb_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Mar_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Mar_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Abr_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Abr_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("May_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("May_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jun_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jun_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jul_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jul_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Ago_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Ago_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Sep_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Sep_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Oct_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Oct_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Nov_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Nov_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Dic_Monto", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Dic_Porc", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Total", Type.GetType("System.Double")))
        End With
        Return dt
    End Function

    Private Function Crear_DTProduccion() As Data.DataTable
        Dim dt As New Data.DataTable
        With dt
            .Columns.Add(New Data.DataColumn("Tipo", Type.GetType("System.String")))
            .Columns.Add(New Data.DataColumn("Ene_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Feb_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Mar_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Abr_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("May_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jun_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Jul_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Ago_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Sep_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Oct_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Nov_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Dic_Importe", Type.GetType("System.Double")))
            .Columns.Add(New Data.DataColumn("Tot_Importe", Type.GetType("System.Double")))
        End With
        Return dt
    End Function

    Private Sub Crear_GraficoEvolucion(ByVal dtgrafico As Data.DataTable)
        Try

            Me.graEvolucionCliente.ChartType = ChartType.Composite

            Me.graEvolucionCliente.CompositeChart.ChartLayers.Clear()
            Me.graEvolucionCliente.CompositeChart.Legends.Clear()

            Dim myChartArea As New ChartArea()
            Me.graEvolucionCliente.CompositeChart.ChartAreas.Add(myChartArea)

            Dim axisX As New AxisItem()
            axisX.OrientationType = AxisNumber.X_Axis
            axisX.DataType = AxisDataType.String
            axisX.SetLabelAxisType = SetLabelAxisType.GroupBySeries
            axisX.Labels.Visible = False
            Dim axisY As New AxisItem()
            axisY.OrientationType = AxisNumber.Y_Axis
            axisY.DataType = AxisDataType.Numeric
            axisY.Labels.ItemFormatString = "<DATA_VALUE:#,##0.00>" & "%"
            myChartArea.Axes.Add(axisX)
            myChartArea.Axes.Add(axisY)

            Dim myColumnLayer As New ChartLayerAppearance()
            myColumnLayer.ChartType = ChartType.ColumnChart
            myColumnLayer.ChartArea = myChartArea
            myColumnLayer.AxisX = axisX
            myColumnLayer.AxisY = axisY

            For x = 1 To 12
                Dim series As New NumericSeries()
                Dim _mesgra = MonthName(x, True)
                series.Label = MonthName(x, True).ToUpper
                For Each fila In dtgrafico.Rows
                    series.Points.Add(New NumericDataPoint(IIf(IsDBNull(fila(_mesgra & "_Porc")), 0, fila(_mesgra & "_Porc")), fila("Cliente"), False))
                Next
                Me.graEvolucionCliente.CompositeChart.Series.Add(series)
                myColumnLayer.Series.Add(series)
            Next

            Me.graEvolucionCliente.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            Me.graEvolucionCliente.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            Me.graEvolucionCliente.Tooltips.FormatString = "<ITEM_LABEL>: " & Environment.NewLine & "<DATA_VALUE:#,###,##0.00> %"

            'Me.graEvolucionCliente.TitleTop.Font = New Font("Arial", 10, FontStyle.Bold)
            'Me.graEvolucionCliente.TitleTop.HorizontalAlign = StringAlignment.Center
            'Me.graEvolucionCliente.TitleTop.Text = "EVOLUCIÓN DE CLIENTES " & fecPeriodo.Value.Year

            Me.graEvolucionCliente.CompositeChart.ChartLayers.Add(myColumnLayer)
            Me.graEvolucionCliente.ColorModel.ModelStyle = ColorModels.CustomLinear
            'CType(Me.graEvolucionCliente.Effects.Effects(2), Effect).Enabled = True
            'CType(Me.graEvolucionCliente.Effects.Effects(3), Effect).Enabled = True
            'Me.graEvolucionCliente.
            'Me.graEvolucionCliente.Effects(3)

            Dim myLegend As New CompositeLegend()
            myLegend.ChartLayers.Add(myColumnLayer)
            myLegend.Bounds = New Rectangle(0, 80, 50, 15)
            myLegend.BoundsMeasureType = MeasureType.Percentage
            myLegend.PE.ElementType = PaintElementType.Gradient
            myLegend.PE.FillGradientStyle = 5
            myLegend.PE.Fill = Color.Transparent
            myLegend.PE.FillStopColor = Color.Transparent
            myLegend.Border.CornerRadius = 10
            myLegend.Border.Thickness = 0
            Me.graEvolucionCliente.CompositeChart.Legends.Add(myLegend)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Crear_GraficoProduccion(ByVal dtgraf As Data.DataTable)
        Try
            Me.graProdFact.ChartType = ChartType.Composite

            Me.graProdFact.CompositeChart.ChartLayers.Clear()
            Me.graProdFact.CompositeChart.Legends.Clear()

            Dim myChartArea As New ChartArea()
            Me.graProdFact.CompositeChart.ChartAreas.Add(myChartArea)

            Dim axisX As New AxisItem()
            axisX.OrientationType = AxisNumber.X_Axis
            axisX.DataType = AxisDataType.String
            axisX.SetLabelAxisType = SetLabelAxisType.GroupBySeries
            axisX.Labels.Visible = False
            Dim axisY As New AxisItem()
            axisY.OrientationType = AxisNumber.Y_Axis
            axisY.DataType = AxisDataType.Numeric
            axisY.Labels.ItemFormatString = "S/" & "<DATA_VALUE:#,##0.00>"
            myChartArea.Axes.Add(axisX)
            myChartArea.Axes.Add(axisY)

            Dim myColumnLayer As New ChartLayerAppearance()
            myColumnLayer.ChartType = ChartType.ColumnChart
            myColumnLayer.ChartArea = myChartArea
            myColumnLayer.AxisX = axisX
            myColumnLayer.AxisY = axisY

            For x = 1 To 12
                Dim series As New NumericSeries()
                Dim _mesgra = MonthName(x, True)
                series.Label = MonthName(x, True).ToUpper
                For Each fila In dtgraf.Rows
                    series.Points.Add(New NumericDataPoint(IIf(IsDBNull(fila(_mesgra & "_Importe")), 0, fila(_mesgra & "_Importe")), fila("Tipo"), False))
                Next
                Me.graProdFact.CompositeChart.Series.Add(series)
                myColumnLayer.Series.Add(series)
            Next

            'Agregar Base Cero
            Dim serieszero As New NumericSeries()
            serieszero.Label = ""
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            serieszero.Points.Add(New NumericDataPoint(0, "", False))
            Me.graProdFact.CompositeChart.Series.Add(serieszero)
            myColumnLayer.Series.Add(serieszero)
            ''

            Me.graProdFact.Tooltips.Font = New Font("Arial", 10, FontStyle.Regular)
            Me.graProdFact.Tooltips.Format = TooltipStyle.LabelPlusDataValue
            Me.graProdFact.Tooltips.FormatString = "<ITEM_LABEL>: " & Environment.NewLine & "S/ <DATA_VALUE:#,###,##0.00>"

            'Me.graProdFact.TitleTop.Font = New Font("Arial", 10, FontStyle.Bold)
            'Me.graProdFact.TitleTop.HorizontalAlign = StringAlignment.Center
            'Me.graProdFact.TitleTop.Text = "PRODUCCIÓN Y FACTURACIÓN " & fecPeriodo.Value.Year

            Me.graProdFact.CompositeChart.ChartLayers.Add(myColumnLayer)
            Me.graProdFact.ColorModel.ModelStyle = ColorModels.CustomLinear
            ' Me.graProdFact.ColumnChart.ChartText(0).Visible = True

            Dim myLegend As New CompositeLegend()
            myLegend.ChartLayers.Add(myColumnLayer)
            myLegend.Bounds = New Rectangle(0, 90, 50, 15)
            myLegend.BoundsMeasureType = MeasureType.Percentage
            myLegend.PE.ElementType = PaintElementType.Gradient
            myLegend.PE.FillGradientStyle = 5
            myLegend.PE.Fill = Color.Transparent
            myLegend.PE.FillStopColor = Color.Transparent
            myLegend.Border.CornerRadius = 10
            myLegend.Border.Thickness = 0
            Me.graProdFact.CompositeChart.Legends.Add(myLegend)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function Crear_ListaMensual(ByVal leMes As List(Of e_ReporteClienteMensual), ByVal tipo As Integer) As List(Of e_ReporteClienteMensual)
        Try
            Dim _cliaux As String = ""
            Dim _maux As String = ""
            Dim _totpos As Double = 0
            Dim _totneg As Double = 0
            Dim _oecliaux As New e_ReporteClienteMensual
            Dim _leaux As New List(Of e_ReporteClienteMensual)
            Dim lereturn As New List(Of e_ReporteClienteMensual)

            If tipo = 1 Then

                decTotalFac.Value = leMes.Where(Function(x) x.TipoDoc = "FACTURA" Or x.TipoDoc = "BOLETA").Sum(Function(x) x.Total)
                decTotalND.Value = leMes.Where(Function(x) x.TipoDoc = "NOTA DE DÉBITO").Sum(Function(x) x.Total)
                decTotalNC.Value = leMes.Where(Function(x) x.TipoDoc = "NOTA DE CRÉDITO").Sum(Function(x) x.Total)

                For Each oeclm In leMes.OrderBy(Function(item) item.IdCliente).ToList
                    If _cliaux <> oeclm.IdCliente Then
                        _cliaux = oeclm.IdCliente
                        _oecliaux = New e_ReporteClienteMensual
                        _oecliaux.IdCliente = oeclm.IdCliente
                        _oecliaux.NroDoc = oeclm.NroDoc
                        _oecliaux.Cliente = oeclm.Cliente
                        _oecliaux.Mes = oeclm.Mes
                        _oecliaux.IndPareto = 0
                        _totpos = leMes.Where(Function(it) it.IdCliente = _cliaux And it.TipoDoc <> "NOTA DE CRÉDITO").Sum(Function(it) it.Total)
                        _totneg = leMes.Where(Function(it) it.IdCliente = _cliaux And it.TipoDoc = "NOTA DE CRÉDITO").Sum(Function(it) it.Total)
                        _oecliaux.Total = _totpos - _totneg
                        _oecliaux.Mes = oeclm.Mes
                        _leaux.Add(_oecliaux)
                    End If
                Next
                lereturn = _leaux.OrderByDescending(Function(it) it.Total).ToList
            Else
                For Each oeclm In leMes.OrderBy(Function(item) item.IdCliente & item.Mes).ToList
                    'If _cliaux <> oeclm.IdCliente Then
                    '    _maux = ""
                    '    _cliaux = oeclm.IdCliente
                    '    If _maux <> oeclm.Mes Then
                    '        _maux = oeclm.Mes
                    If _cliaux & _maux <> oeclm.IdCliente & oeclm.Mes Then
                        _cliaux = oeclm.IdCliente
                        _maux = oeclm.Mes
                        _oecliaux = New e_ReporteClienteMensual
                        _oecliaux.IdCliente = oeclm.IdCliente
                        _oecliaux.NroDoc = oeclm.NroDoc
                        _oecliaux.Cliente = oeclm.Cliente
                        _oecliaux.Mes = oeclm.Mes
                        _oecliaux.IndPareto = 0
                        _totpos = leMes.Where(Function(it) it.IdCliente = _cliaux And it.TipoDoc <> "NOTA DE CRÉDITO" And it.Mes = _maux).Sum(Function(it) it.Total)
                        _totneg = leMes.Where(Function(it) it.IdCliente = _cliaux And it.TipoDoc = "NOTA DE CRÉDITO" And it.Mes = _maux).Sum(Function(it) it.Total)
                        _oecliaux.Total = _totpos - _totneg
                        _oecliaux.Mes = oeclm.Mes
                        _leaux.Add(_oecliaux)

                    End If
                Next
                lereturn = _leaux
            End If

            Return lereturn
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class