Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles
Imports Infragistics.UltraChart.Resources.Appearance
Imports Infragistics.UltraChart.Core.Layers

Public Class frm_ReporteConsumoConductor
    Inherits frm_MenuPadre


#Region "Instancia"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Shared instancia As frm_ReporteConsumoConductor = Nothing
    Private Shared Operacion As String

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            Operacion = "Inicializa"
            instancia = New frm_ReporteConsumoConductor()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "Declaración de Variables"

    Dim oeRegConsumoCombustible As New e_RegistroConsumoCombustible
    Dim olRegConsumoCombustible As New l_RegistroConsumoCombustible
    Dim lstMetasCombustible As New List(Of e_MetasCombustible)
    Dim TablaInforme As New DataTable
    Dim dstR As New DataSet
    Dim dstG As New DataSet
    Dim TablaResultado As New DataTable
    Dim ListaInforme As New List(Of e_ReporteTanqueoCombustible)
    Dim DatoInforme As New e_ReporteTanqueoCombustible
    Dim GraFila As String = ""
    Dim GraColumna As String = ""
    Dim GraValor As String = ""
    Dim MenorFecha As Date
    Dim MayorFecha As Date
    Dim oeComboAux As New e_Combo
    Dim oeCombo As New e_Combo
    Dim olCombo As New l_Combo
    Dim oeRuta As New e_Ruta
    Dim olRuta As New l_Ruta
    Dim leRuta As New List(Of e_ruta)
    Dim oeZonaD2 As New e_ZonaCombustible
    Dim olZonaD2 As New l_ZonaCombustible
    Dim leZonaD2 As New List(Of e_ZonaCombustible)
    Dim oeRendimientoCombustible As New e_RendimientoCombustible
    Dim olRendimientoCombustible As New l_RendimientoCombustible
    Dim leRendimientoCombustible As New List(Of e_RendimientoCombustible)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        Try
            Operacion = "Inicializa"
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Listar(Activo)
            If griData.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            If TabReporteCombustible.Tabs(0).Selected Then
                If griData.Rows.Count = 0 Then Throw New Exception("No hay ningún dato para exportar al Excel")
                Exportar_Excel(griData)
            ElseIf TabReporteCombustible.Tabs(1).Selected Then
                If GridVisualiza.Rows.Count = 0 Then Throw New Exception("No existe ninguna fila para exportar")
                Exportar_Excel(GridVisualiza)
            End If
            MyBase.Exportar()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteConsumoConductor_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ugb_Espera.Location = New System.Drawing.Point((Me.Width / 2) - (ugb_Espera.Width / 2), (Me.Height / 2) - ugb_Espera.Height)
    End Sub

    Private Sub frm_ReporteConsumoConductor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
    End Sub

    Private Sub frm_ReporteConsumoConductor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub rfDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If rfDesde.Value > rfHasta.Value Then
                rfDesde.Value = rfHasta.Value.AddDays(-30)
                Throw New Exception("La fecha desde no puede ser mayor que la fecha hasta")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub rfHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If rfHasta.Value < rfDesde.Value Then
                rfHasta.Value = Now
                Throw New Exception("La fecha hasta no puede ser menor que la fecha desde")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub BtnVisualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualiza.Click
        Try
            ugb_Espera.Visible = True
            Application.DoEvents()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            CrearLista()
            ArmarEstructura()
            If RbtAño.Checked Then
                CargaAnual()
            ElseIf RbtMensual.Checked Then
                CargaMensual()
            ElseIf RbtSemanal.Checked Then
                CargaSemanal()
            End If
            ArmarCamposGrafica()
            GridVisualiza.DataSource = dstR
            GridVisualiza.DataBind()
            CrearFormatoCeldas()
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ArmarExcellDinamico()
    End Sub

    Private Sub BtnVerGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerGrafico.Click
        Try
            If ListaInforme.Count > 1 Then
                If CmbTipoGrafico.Value <> Nothing Then
                    LblColumna.Text = GraColumna
                    LblFila.Text = GraFila
                    LblValor.Text = GraValor
                    CalcularDataGrafico()
                    GraficoD2.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:#,###,##0.000>"
                    GraficoD2.Axis.X.ScrollScale.Visible = True
                    GraficoD2.Axis.X.ScrollScale.Height = 20
                    Dim escala As Integer = 0
                    If RbtGIndividual.Checked = True Then
                        escala = dstR.Tables(0).Rows.Count() \ 4
                        GraficoD2.Axis.X.ScrollScale.Scale() = 1 / (escala + 1)
                    Else
                        GraficoD2.Axis.X.ScrollScale.Scale() = 1
                    End If
                    GraficoD2.Tooltips.Font = New Font("Arial", 9, FontStyle.Regular)
                    GraficoD2.Tooltips.Format = TooltipStyle.LabelPlusDataValue
                    GraficoD2.Tooltips.FormatString = "<ITEM_LABEL>:  <DATA_VALUE:#,###,##0.00>"
                    GraficoD2.Data.DataSource = dstG
                    If CmbTipoGrafico.Value = "1" Then GraficoD2.ChartType = ChartType.ColumnChart
                    If CmbTipoGrafico.Value = "2" Then GraficoD2.ChartType = ChartType.LineChart
                    If CmbTipoGrafico.Value = "3" Then GraficoD2.ChartType = ChartType.SplineAreaChart
                    If CmbTipoGrafico.Value = "4" Then GraficoD2.ChartType = ChartType.SplineChart
                    GraficoD2.Data.DataBind()

                Else
                    Throw New Exception("Seleccione un tipo de gráfico válido")
                End If
            Else
                Throw New Exception("Es necesario como mínimo una fila en la pestaña Reporte")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub frm_ReporteConsumoConductor_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If TabReporteCombustible.Tabs(0).Selected Then
            If griData.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        ElseIf TabReporteCombustible.Tabs(1).Selected Then
            If GridVisualiza.Rows.Count > 0 Then
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            Else
                ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)
            End If
        Else
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 0, 1)

        End If
    End Sub


    Private Sub Grid_Pilotos_CellChange(sender As Object, e As CellEventArgs) Handles Grid_Pilotos.CellChange
        Grid_Pilotos.UpdateData()
    End Sub

    Private Sub Grid_Vehiculos_CellChange_1(sender As Object, e As CellEventArgs) Handles Grid_Vehiculos.CellChange
        Grid_Vehiculos.UpdateData()
    End Sub

    Private Sub Grid_TipoeVeh_CellChange(sender As Object, e As CellEventArgs) Handles Grid_TipoeVeh.CellChange
        Grid_TipoeVeh.UpdateData()
    End Sub

    Private Sub Grid_Zona_CellChange(sender As Object, e As CellEventArgs) Handles Grid_Zona.CellChange
        Grid_Zona.UpdateData()
    End Sub

    Private Sub Grid_Vehiculos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Vehiculos.BeforeRowsDeleted
        e.Cancel = True
    End Sub

    Private Sub Grid_Pilotos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Pilotos.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_TipoeVeh_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_TipoeVeh.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_Zona_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles Grid_Zona.BeforeRowsDeleted
        e.cancel = True
    End Sub

    Private Sub Grid_Pilotos_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Pilotos.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Pilotos.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Pilotos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_TipoeVeh_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_TipoeVeh.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_TipoeVeh.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_TipoeVeh.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_Zona_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Zona.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Zona.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Zona.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub Grid_Vehiculos_AfterHeaderCheckStateChanged(sender As Object, e As AfterHeaderCheckStateChangedEventArgs) Handles Grid_Vehiculos.AfterHeaderCheckStateChanged
        Try
            Dim column As UltraGridColumn = e.Column
            Dim rows As RowsCollection = e.Rows
            Dim checkStateValue = column.GetHeaderCheckedState(rows)
            For Each row In Grid_Vehiculos.Rows.Where(Function(item) item.IsFilteredOut = False)
                row.Cells("Seleccion").Value = checkStateValue
            Next
            Grid_Vehiculos.UpdateData()
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizaRend_Click(sender As Object, e As EventArgs) Handles btnActualizaRend.Click
        Try
            ' Carga de Rutas
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "D"
            leRuta = olRuta.Listar(oeRuta)
            ' Carga de Zona D2
            oeZonaD2 = New e_ZonaCombustible
            leZonaD2 = New List(Of e_ZonaCombustible)
            oeZonaD2.TipoOperacion = "D"
            leZonaD2 = olZonaD2.Listar(oeZonaD2)
            ' Carga de Rendimientos
            oeRendimientoCombustible = New e_RendimientoCombustible
            leRendimientoCombustible = New List(Of e_RendimientoCombustible)
            oeRendimientoCombustible.Id = ""
            oeRendimientoCombustible.IdTipoVehiculo = ""
            oeRendimientoCombustible.IdFlota = ""
            leRendimientoCombustible = olRendimientoCombustible.Listar(oeRendimientoCombustible)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Metodos"

    Private Sub Inicializar()
        Try
            ' Carga de los vehículos
            Grid_Vehiculos.DataSource = VehiculosD2Public
            ' Carga de los Pilotos:
            Dim ListaPiloto = PilotoPublic
            For Each obj In CopilotoPublic
                If ListaPiloto.Where(Function(i) i.Id = obj.Id).Count = 0 Then
                    ListaPiloto.Add(obj)
                End If
            Next
            Grid_Pilotos.DataSource = ListaPiloto.Where(Function(i) i.Id <> "0").ToList
            ' Carga de los tipos de vehículo
            Grid_TipoeVeh.DataSource = TipoVehiculoPublic
            ' Carga de Zonas 
            Grid_Zona.DataSource = ZonaPublic.Where(Function(i) i.Id <> "").ToList
            ' Carga de Rutas
            oeRuta = New e_Ruta
            oeRuta.TipoOperacion = "D"
            leRuta = olRuta.Listar(oeRuta)
            ' Carga de Zona D2
            oeZonaD2 = New e_ZonaCombustible
            leZonaD2 = New List(Of e_ZonaCombustible)
            oeZonaD2.TipoOperacion = "D"
            leZonaD2 = olZonaD2.Listar(oeZonaD2)
            ' Carga de Rendimientos
            oeRendimientoCombustible = New e_RendimientoCombustible
            leRendimientoCombustible = New List(Of e_RendimientoCombustible)
            oeRendimientoCombustible.Id = ""
            oeRendimientoCombustible.IdTipoVehiculo = ""
            oeRendimientoCombustible.IdFlota = ""
            leRendimientoCombustible = olRendimientoCombustible.Listar(oeRendimientoCombustible)
            rfDesde.Value = Now.AddDays(-30)
            rfDesde.Value = Now.AddDays(-30)
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Public Sub Listar(ByVal Activo As Boolean)
        Try
            oeRegConsumoCombustible.Activo = Activo
            oeRegConsumoCombustible.TipoOperacion = "1"
            oeRegConsumoCombustible.fechaInicio = rfDesde.Value
            oeRegConsumoCombustible.fechaFin = rfHasta.Value
            oeRegConsumoCombustible.IdVehiculo = ObtenerTractosSeleccionados()
            oeRegConsumoCombustible.Pilotos = ObtenerPilotosSeleccionados()
            oeRegConsumoCombustible.TipoVehiculos = ObtenerTipoVehSeleccionadas()
            oeRegConsumoCombustible.Flotas = ObtenerFlotaSeleccionadas()
            oeRegConsumoCombustible.leRutas = leRuta
            oeRegConsumoCombustible.leZonaD2 = leZonaD2
            oeRegConsumoCombustible.leRendimiento = leRendimientoCombustible
            Dim ds As DataSet
            Dim dst As New DataSet
            ds = olRegConsumoCombustible.CalcularRendimiento(oeRegConsumoCombustible)

            'ARMAMOS LA TABLA
            TablaInforme = dst.Tables.Add("TablaInforme")
            TablaInforme.Columns.Add("Año", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Mes", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Semana", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Dia", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Placa", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Marca", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Modelo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Carreta", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaViaje", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Conductor", Type.GetType("System.String"))
            TablaInforme.Columns.Add("IndPiloto", Type.GetType("System.String"))
            TablaInforme.Columns.Add("CantConductores", Type.GetType("System.String"))
            TablaInforme.Columns.Add("FechaTanqueo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Dist", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("Cons", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("Metas", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Pesos", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Rend", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("RendEsperado", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("GlsEsperado", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("Desviacion", Type.GetType("System.Double"))
            TablaInforme.Columns.Add("Glosa", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Cliente", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Carga", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Grifo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("Referencia", Type.GetType("System.String"))
            TablaInforme.Columns.Add("LugTanqueo", Type.GetType("System.String"))
            TablaInforme.Columns.Add("UsuarioCrea", Type.GetType("System.String"))

            Dim dtTractos As DataTable = ds.Tables(0), dtViajes As DataTable = ds.Tables(1), dtTanqueos As DataTable = ds.Tables(2)
            For Each vehRow As DataRow In dtTractos.Rows
                Dim pvt As Boolean = False
                For Each viajeRow As DataRow In vehRow.GetChildRows("FK_RelacionRegConComb_1")
                    For Each tanqRow As DataRow In viajeRow.GetChildRows("FK_Relacion_VT")
                        If tanqRow("IndTanqueo") = True Then
                            If pvt = True Then
                                Dim oby() = Split(tanqRow("IdPiloto"), " / ")
                                Dim obj() = oby.Distinct().ToArray()
                                For i = 0 To obj.Length - 1
                                    If obj(i) = "NINGUNO" Then Continue For
                                    Dim row As DataRow = dst.Tables("TablaInforme").NewRow()
                                    row("Año") = Year((tanqRow("FechaTanqueo")))
                                    row("Mes") = Month((tanqRow("FechaTanqueo")))
                                    row("Semana") = DatePart(DateInterval.WeekOfYear, (tanqRow("FechaTanqueo")))
                                    row("Dia") = DateAndTime.Day((tanqRow("FechaTanqueo")))
                                    row("Placa") = vehRow("Placa")
                                    row("Marca") = vehRow("Marca")
                                    row("Modelo") = vehRow("Modelo")
                                    row("Carreta") = viajeRow("Carreta")
                                    row("FechaViaje") = viajeRow("FechaViaje")
                                    row("Conductor") = obj(i)
                                    row("IndPiloto") = 0
                                    row("CantConductores") = obj.Where(Function(Y) Y.ToString <> "NINGUNO").ToArray.Length.ToString + " Conductor(es)"
                                    row("FechaTanqueo") = tanqRow("FechaTanqueo")
                                    row("Dist") = tanqRow("Dist")
                                    row("Cons") = tanqRow("Cons")
                                    row("Metas") = tanqRow("Rutas")
                                    row("Pesos") = tanqRow("Pesos")
                                    row("Rend") = tanqRow("Rend")
                                    row("RendEsperado") = IIf(tanqRow("RendEsperado").ToString = "", 0, tanqRow("RendEsperado"))
                                    row("GlsEsperado") = IIf(tanqRow("GlsEsperado").ToString = "", 0, tanqRow("GlsEsperado"))
                                    row("Desviacion") = IIf(tanqRow("Desviacion").ToString = "", 0, tanqRow("Desviacion"))
                                    row("Glosa") = tanqRow("Glosa")
                                    row("Cliente") = tanqRow("IdEmpresaGrifo")
                                    row("Carga") = tanqRow("IdMaterial")
                                    row("Grifo") = tanqRow("Grifo")
                                    row("Referencia") = tanqRow("Referencia")
                                    row("LugTanqueo") = tanqRow("LugTanqueo")
                                    row("UsuarioCrea") = tanqRow("UsuarioCrea")
                                    dst.Tables("TablaInforme").Rows.Add(row)
                                Next
                            Else
                                pvt = True
                            End If
                        End If
                    Next
                Next
            Next

            griData.DataSource = dst
            griData.DataBind()

            If chkColores.Checked = True Then
                For Each row In griData.Rows
                    If row.Cells("Dist").Value < 0 Then
                        row.CellAppearance.BackColor = ColorDistNegativo.Color
                    ElseIf ObtenerNroVueltasTembladeraPacas(row.Cells("Metas").Value, CDbl(row.Cells("Dist").Value)) = True Then
                        row.CellAppearance.BackColor = ColorKmVuelta.Color
                    ElseIf row.Cells("RendEsperado").Value = 0.0 Then
                        row.CellAppearance.BackColor = ColorSinRend.Color
                    ElseIf row.Cells("Rend").Value > nd_RendMayor.Value Then
                        row.CellAppearance.BackColor = ColorRendMayor.Color
                    ElseIf row.Cells("Rend").Value < nd_RendMenor.Value Then
                        row.CellAppearance.BackColor = ColorRendMenor.Color
                    End If
                Next
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            mensajeEmergente.Problema(ex.Message)
        End Try
    End Sub

    Private Sub CrearLista()
        Try
            If griData.Rows.Count > 0 Then
                ListaInforme = New List(Of e_ReporteTanqueoCombustible)
                For Each fila As Data.DataRow In TablaInforme.Rows
                    DatoInforme = New e_ReporteTanqueoCombustible
                    DatoInforme.Año = fila.Item("Año")
                    DatoInforme.Mes = fila.Item("Mes")
                    DatoInforme.Semana = fila.Item("Semana")
                    DatoInforme.Dia = fila.Item("Dia")
                    DatoInforme.Placa = fila.Item("Placa")
                    DatoInforme.Marca = fila.Item("Marca")
                    DatoInforme.Modelo = fila.Item("Modelo")
                    DatoInforme.Carreta = fila.Item("Carreta")
                    DatoInforme.FechaViaje = fila.Item("FechaViaje")
                    DatoInforme.Piloto = fila.Item("Conductor")
                    DatoInforme.Copiloto = fila.Item("CantConductores")
                    DatoInforme.FechaTanqueo = fila.Item("FechaTanqueo")
                    DatoInforme.Dist = fila.Item("Dist")
                    DatoInforme.Cons = fila.Item("Cons")
                    DatoInforme.Metas = fila.Item("Metas")
                    DatoInforme.Pesos = fila.Item("Pesos")
                    DatoInforme.Rend = fila.Item("Rend")
                    DatoInforme.RendEsperado = fila.Item("RendEsperado")
                    DatoInforme.GlsEsperado = fila.Item("GlsEsperado")
                    DatoInforme.Desviacion = fila.Item("Desviacion")
                    ListaInforme.Add(DatoInforme)
                Next
            Else

                Throw New Exception("Debes existir filas en el Tab de Información para extraer datos al reporte ")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ArmarEstructura()
        Try
            dstR = New DataSet
            TablaResultado = dstR.Tables.Add("TablaResultado")

            MenorFecha = ListaInforme.Min(Function(ITEM) ITEM.FechaTanqueo)
            MayorFecha = ListaInforme.Max(Function(ITEM) ITEM.FechaTanqueo)

            Dim NombreColumna As String = ""
            Dim Desdeaño As Integer = Year(MenorFecha)
            Dim Desdemes As Integer = Month(MenorFecha)
            Dim DesdeSemana As Integer = DatePart(DateInterval.WeekOfYear, (MenorFecha))
            Dim Hastaaño As Integer = Year(MayorFecha)
            Dim Hastames As Integer = Month(MayorFecha)
            Dim HastaSemana As Integer = DatePart(DateInterval.WeekOfYear, (MayorFecha))

            If RbtAño.Checked Then

                If RbtConductor.Checked Then
                    TablaResultado.Columns.Add("Conductor", Type.GetType("System.String"))
                End If
                For i = Desdeaño To Hastaaño
                    NombreColumna = i.ToString
                    TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                Next

            ElseIf RbtMensual.Checked Then

                If RbtConductor.Checked Then
                    TablaResultado.Columns.Add("Conductor", Type.GetType("System.String"))
                End If
                If Desdeaño = Hastaaño Then
                    For y = Desdemes To Hastames
                        NombreColumna = y.ToString + " - " + Desdeaño.ToString
                        TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                    Next
                Else
                    For i = Desdeaño To Hastaaño
                        If i = Desdeaño Then
                            For y = Desdemes To 12
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        ElseIf i > Desdeaño And i < Hastaaño Then
                            For y = 1 To 12
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        ElseIf i = Hastaaño Then
                            For y = 1 To Hastames
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        End If
                    Next
                End If

            ElseIf RbtSemanal.Checked Then

                If RbtConductor.Checked Then
                    TablaResultado.Columns.Add("Conductor", Type.GetType("System.String"))
                End If
                If Desdeaño = Hastaaño Then
                    For y = DesdeSemana To HastaSemana
                        NombreColumna = y.ToString + " - " + Desdeaño.ToString
                        TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                    Next
                Else
                    For i = Desdeaño To Hastaaño
                        If i = Desdeaño Then
                            For y = DesdeSemana To 52
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        ElseIf i > Desdeaño And i < Hastaaño Then
                            For y = 1 To 52
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        ElseIf i = Hastaaño Then
                            For y = 1 To HastaSemana
                                NombreColumna = y.ToString + " - " + i.ToString
                                TablaResultado.Columns.Add(NombreColumna, Type.GetType("System.Double"))
                            Next
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ArmarExcellDinamico()
        Try
            Dim dtDatos As New DataTable()
            dtDatos = TablaInforme
            If dtDatos.Rows.Count > 1 Then
                Dim ruta As String = ""
                dlGuardar.CheckFileExists = False
                dlGuardar.OverwritePrompt = True
                dlGuardar.Title = "ISL => Seleccione el directorio para generar Reporte"
                dlGuardar.ShowDialog()
                If dlGuardar.FileName <> "" Then
                    ugb_Espera.Visible = True
                    Application.DoEvents()
                    Cursor.Current = Cursors.WaitCursor
                    Cursor.Show()
                    ruta = dlGuardar.FileName
                    Dim genExcel As New clsGenerarExcel()
                    Dim nomArchivo As String = ruta
                    Dim titCols As New ArrayList(New String() {"Año", "Mes", "Semana", "Dia", "Placa", "Marca", "Modelo", "Carreta", "FechaViaje", "Conductor", "CantConductores", "FechaTanqueo", _
                                                               "Dist", "Cons", "Metas", "Pesos", "Rend", "RendEsperado", "GlsEsperado", "Desviacion", "Glosa", "Cliente", "Carga"})
                    Dim datFilas As New ArrayList(New String() {"Conductor"})
                    Dim datCols As New ArrayList(New String() {"Año", "Mes", "Dia"})
                    Dim datFiltros As New ArrayList()
                    Dim datCalc As New ArrayList(New String() {"Desviacion"})

                    Dim dict As Dictionary(Of clsGenerarExcel.datoResp, Object) = genExcel.GenerarExcel(nomArchivo, TablaInforme, _
                                                                                                        titCols, datFilas, _
                                                                                                        datCols, datFiltros, _
                                                                                                        datCalc, clsGenerarExcel.VersionExcel.v12)

                    mensajeEmergente.Confirmacion("Se ha generado el archivo exitosamente")

                End If

            Else
                Throw New Exception("Se necesita como mínimo tener dos filas para poder realizar el análisis")
            End If
            ugb_Espera.Visible = False
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message)
        Finally
            Windows.Forms.Cursor.Current = Cursors.Default
            Cursor.Show()
            ugb_Espera.Visible = False
        End Try
    End Sub

    Private Sub CrearFormatoCeldas()
        Try
            For i = 0 To GridVisualiza.DisplayLayout.Bands(0).Columns.Count - 1
                If i = 0 Then
                    GridVisualiza.DisplayLayout.Bands(0).Columns(i).Width = 300
                    GridVisualiza.DisplayLayout.Bands(0).Columns(i).CellAppearance.BackColor = Color.Beige
                Else
                    GridVisualiza.DisplayLayout.Bands(0).Columns(i).Width = 90
                    GridVisualiza.DisplayLayout.Bands(0).Columns(i).Format = "##,###,###0.000"
                    GridVisualiza.DisplayLayout.Bands(0).Columns(i).CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ArmarCamposGrafica()
        Try
            ''Valor de fila
            GraFila = "Conductor"
            ''Valor de columna
            If RbtAño.Checked = True Then
                GraColumna = "Anual"
            ElseIf RbtMensual.Checked = True Then
                GraColumna = "Mensual"
            ElseIf RbtSemanal.Checked = True Then
                GraColumna = "Semanal"
            End If
            ''Valor calculado
            If RbtCantidad.Checked = True Then
                GraValor = "Consumo"
            ElseIf RbtRendimiento.Checked = True Then
                GraValor = "Rendimiento"
            ElseIf RbtRendimiento.Checked = True Then
                GraValor = "Desviación"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaAnual()

        Try
            Dim FILA As DataRow = Nothing
            Dim primerelemento As Boolean = True
            Dim valor As Double = 0
            Dim valorfila As String = ""
            Dim SemanaR As String = ""
            Dim MesR As String = ""
            Dim AñoR As String = ""

            If RbtCantidad.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Cons)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Cons)
                            End If
                            FILA(AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Cons)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Cons)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtRendimiento.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Rend)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Rend)
                            End If
                            FILA(AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Rend)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Rend)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtDesviacion.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Desviacion)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Desviacion)
                            End If
                            FILA(AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Sum(Function(ITEM) ITEM.Desviacion)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR).Average(Function(ITEM) ITEM.Desviacion)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaMensual()

        Try
            Dim FILA As DataRow = Nothing
            Dim primerelemento As Boolean = True
            Dim valor As Double = 0
            Dim valorfila As String = ""
            Dim SemanaR As String = ""
            Dim MesR As String = ""
            Dim AñoR As String = ""

            If RbtCantidad.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or MesR <> obj.Mes Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            MesR = obj.Mes
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Cons)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Cons)
                            End If
                            FILA(MesR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        MesR = obj.Mes.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Cons)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Cons)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(MesR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtRendimiento.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or MesR <> obj.Mes Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            MesR = obj.Mes
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Rend)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Rend)
                            End If
                            FILA(MesR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        MesR = obj.Mes.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Rend)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Rend)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(MesR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtDesviacion.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or MesR <> obj.Mes Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            MesR = obj.Mes
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Desviacion)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Desviacion)
                            End If
                            FILA(MesR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        MesR = obj.Mes.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Sum(Function(ITEM) ITEM.Desviacion)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Mes = MesR).Average(Function(ITEM) ITEM.Desviacion)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(MesR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaSemanal()
        Try
            Dim FILA As DataRow = Nothing
            Dim primerelemento As Boolean = True
            Dim valor As Double = 0
            Dim valorfila As String = ""
            Dim SemanaR As String = ""
            Dim MesR As String = ""
            Dim AñoR As String = ""
            If RbtCantidad.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or SemanaR <> obj.Semana Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            SemanaR = obj.Semana
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Sum(Function(ITEM) ITEM.Cons)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Cons)
                            End If
                            FILA(SemanaR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        SemanaR = obj.Semana.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana).Sum(Function(ITEM) ITEM.Cons)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Cons)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(SemanaR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtRendimiento.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or SemanaR <> obj.Semana Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            SemanaR = obj.Semana
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Sum(Function(ITEM) ITEM.Rend)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Rend)
                            End If
                            FILA(SemanaR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        SemanaR = obj.Semana.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Sum(Function(ITEM) ITEM.Rend)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Rend)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(SemanaR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            ElseIf RbtDesviacion.Checked Then
                For Each obj As e_ReporteTanqueoCombustible In ListaInforme.OrderByDescending(Function(item) item.Piloto & item.FechaViaje).ToList
                    If valorfila = obj.Piloto Then
                        If AñoR <> obj.Año Or SemanaR = obj.Semana Then
                            valorfila = obj.Piloto
                            AñoR = obj.Año
                            SemanaR = obj.Semana
                            If rbTotal.Checked Then
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Sum(Function(ITEM) ITEM.Desviacion)
                            Else
                                valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Desviacion)
                            End If
                            FILA(SemanaR + " - " + AñoR) = valor
                        End If
                    Else
                        FILA = dstR.Tables("TablaResultado").NewRow()
                        valorfila = obj.Piloto
                        AñoR = obj.Año.ToString
                        SemanaR = obj.Semana.ToString
                        If rbTotal.Checked Then
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Sum(Function(ITEM) ITEM.Desviacion)
                        Else
                            valor = ListaInforme.Where(Function(ITEM) ITEM.Piloto = valorfila And ITEM.Año = AñoR And ITEM.Semana = SemanaR).Average(Function(ITEM) ITEM.Desviacion)
                        End If
                        FILA("Conductor") = valorfila
                        FILA(SemanaR + " - " + AñoR) = valor
                        dstR.Tables("TablaResultado").Rows.Add(FILA)
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CalcularDataGrafico()
        Try
            If RbtGTotal.Checked = True Then
                Dim FilaTotal As DataRow
                dstG = dstR.Clone
                FilaTotal = dstG.Tables(0).NewRow()
                For i = 0 To TablaResultado.Columns.Count - 1
                    Dim total As Double = 0.0
                    If i <> 0 Then
                        For Each dr As DataRow In dstR.Tables(0).Rows
                            total = IIf(dr(i).ToString = "", 0, dr(i)) + total
                        Next
                        FilaTotal(i) = total
                    Else
                        FilaTotal(i) = "Total"
                    End If
                Next
                dstG.Tables(0).Rows.Add(FilaTotal)
            ElseIf RbtGIndividual.Checked = True Then
                dstG = dstR
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerAbreviaturaCliente(ByVal Cliente As String) As String
        Try
            Dim ListaClientes As New List(Of e_Combo)
            ListaClientes.AddRange(ClientesPublic)
            For Each obj In ListaClientes.Where(Function(item) item.Nombre = Cliente).ToList
                If Trim(obj.Descripcion) <> "" Then
                    Return obj.Descripcion
                Else
                    Return obj.Nombre
                End If
            Next
            Return Cliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Funciones"

    Public Function ObtenerTractosSeleccionados() As String
        Dim Tractos As String = ""
        For Each row In Grid_Vehiculos.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Tractos = "" Then
                Tractos &= "'" & row.Cells("Id").Value & "'"
            Else
                Tractos &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Tractos
    End Function

    Public Function ObtenerPilotosSeleccionados() As String
        Dim Pilotos As String = ""
        For Each row In Grid_Pilotos.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Pilotos = "" Then
                Pilotos &= "'" & row.Cells("Id").Value & "'"
            Else
                Pilotos &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Pilotos
    End Function

    Public Function ObtenerTipoVehSeleccionadas() As String
        Dim TipoVeh As String = ""
        For Each row In Grid_TipoeVeh.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If TipoVeh = "" Then
                TipoVeh &= "'" & row.Cells("Id").Value & "'"
            Else
                TipoVeh &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return TipoVeh
    End Function

    Public Function ObtenerFlotaSeleccionadas() As String
        Dim Zona As String = ""
        For Each row In Grid_Zona.Rows.Where(Function(i) i.Cells("Seleccion").Value = True).ToList
            If Zona = "" Then
                Zona &= "'" & row.Cells("Id").Value & "'"
            Else
                Zona &= ",'" & row.Cells("Id").Value & "'"
            End If
        Next
        Return Zona
    End Function

    Public Function ObtenerNroVueltasTembladeraPacas(cadena As String, distancia As Double) As Boolean
        Try
            If Not Cadena.StartsWith("PACASMAYO - TEMBLADERA - PACASMAYO") Then Return False
            Dim Ruta As String = "PACASMAYO"
            For i = 1 To 9
                Ruta = Ruta + " - TEMBLADERA - PACASMAYO"
                If Cadena = Ruta Then
                    If ndKmxVuelta.Value * i < distancia Then
                        Return True
                    End If
                    Exit For
                End If
            Next
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class