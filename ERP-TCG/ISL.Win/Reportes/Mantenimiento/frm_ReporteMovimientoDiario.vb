Imports ISL.EntidadesWCF
Imports ISL.LogicaWCF
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.UltraChart.Shared.Styles

Public Class frm_ReporteMovimientoDiario
    Inherits ISL.Win.frm_MenuPadre

#Region "Inicializar formulario"

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'CargarDatos()
    End Sub

    Private Shared instancia As frm_ReporteMovimientoDiario = Nothing

    Public Overrides Function getInstancia() As frm_MenuPadre
        If instancia Is Nothing Then
            instancia = New frm_ReporteMovimientoDiario()
        End If
        instancia.Activate()
        Return instancia
    End Function

#End Region

#Region "clase"
    Class CustomMergedCellEvaluator
        Implements Infragistics.Win.UltraWinGrid.IMergedCellEvaluator

        Function ShouldCellsBeMerged(ByVal row1 As UltraGridRow, ByVal row2 As UltraGridRow, ByVal column As UltraGridColumn) As Boolean Implements IMergedCellEvaluator.ShouldCellsBeMerged
            Dim band As Boolean = False
            Dim IdOT1, IdOT2 As String
            Dim Id1, Id2 As String
            Dim n1, n2 As Double
            Dim d1, d2 As Date
            IdOT1 = DirectCast(row1.GetCellValue("Equipo"), String)
            IdOT2 = DirectCast(row2.GetCellValue("Equipo"), String)
            If IdOT1 = IdOT2 Then
                Select Case column.Key
                    Case "Marca"
                        Id1 = DirectCast(row1.GetCellValue("Marca"), String)
                        Id2 = DirectCast(row2.GetCellValue("Marca"), String)
                        If Id1 = Id2 Then band = True
                    Case "Modelo"
                        Id1 = DirectCast(row1.GetCellValue("Modelo"), String)
                        Id2 = DirectCast(row2.GetCellValue("Modelo"), String)
                        If Id1 = Id2 Then band = True
                    Case "TipoVehiculo"
                        Id1 = DirectCast(row1.GetCellValue("TipoVehiculo"), String)
                        Id2 = DirectCast(row2.GetCellValue("TipoVehiculo"), String)
                        If Id1 = Id2 Then band = True
                    Case "FechaINT"
                        d1 = DirectCast(row1.GetCellValue("FechaINT"), Date)
                        d2 = DirectCast(row2.GetCellValue("FechaINT"), Date)
                        If d1 = d2 Then band = True
                    Case "FechaIT"
                        d1 = DirectCast(row1.GetCellValue("FechaIT"), Date)
                        d2 = DirectCast(row2.GetCellValue("FechaIT"), Date)
                        If d1 = d2 Then band = True
                    Case "FechaFT"
                        d1 = DirectCast(row1.GetCellValue("FechaFT"), Date)
                        d2 = DirectCast(row2.GetCellValue("FechaFT"), Date)
                        If d1 = d2 Then band = True
                    Case "Kilometraje"
                        n1 = DirectCast(row1.GetCellValue("Kilometraje"), Double)
                        n2 = DirectCast(row2.GetCellValue("Kilometraje"), Double)
                        If n1 = n2 Then band = True
                    Case "Diferencia"
                        Id1 = DirectCast(row1.GetCellValue("Diferencia"), String)
                        Id2 = DirectCast(row2.GetCellValue("Diferencia"), String)
                        If Id1 = Id2 Then band = True
                    Case Else
                        band = True
                End Select
            End If
            Return band
            'End If
        End Function
    End Class
#End Region

#Region "Declaracion de Variables"

    Dim oeRepeorteMDOT As New e_MovimientoDiarioOT
    Dim olReporteMDOT As New l_OrdenTrabajo
    Dim leReporteMDOT As New List(Of e_MovimientoDiarioOT)

#End Region

#Region "Botonera"

    Public Overrides Sub Consultar(ByVal Activo As Boolean)
        'MyBase.Consultar(Activo)
        Try
            oeRepeorteMDOT = New e_MovimientoDiarioOT
            oeRepeorteMDOT.Anio = fecPeriodo.Value.Year
            oeRepeorteMDOT.Mes = fecPeriodo.Value.Month
            leReporteMDOT = olReporteMDOT.ListarRMDOT(oeRepeorteMDOT)
            CargarRMVOT(leReporteMDOT)
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overrides Sub Exportar()
        Try
            If griMovDiarioOT.Rows.Count > 0 Then
                Exportar_Excel(griMovDiarioOT)
            Else
                Throw New Exception("No hay Registros para Exportar!!!")
            End If
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

#End Region

#Region "Eventos"

    Private Sub frm_ReporteMovimientoDiario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
    End Sub

    Private Sub frm_ReporteMovimientoDiario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        instancia = Nothing
    End Sub

    Private Sub frm_ReporteMovimientoDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ControlBoton(1, 0, 0, 0, 0, 0, 0, 1, 1)
            CargarRMVOT(New List(Of e_MovimientoDiarioOT))
        Catch ex As Exception
            mensajeEmergente.Problema(ex.Message, True)
        End Try
    End Sub

    Private Sub griMovDiarioOT_InitializeLayout(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles griMovDiarioOT.InitializeLayout
        e.Layout.Bands(0).Columns("Equipo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Marca").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Modelo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaINT").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaIT").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("FechaFT").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Kilometraje").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("TipoVehiculo").MergedCellStyle = MergedCellStyle.Always
        e.Layout.Bands(0).Columns("Diferencia").MergedCellStyle = MergedCellStyle.Always
        For Each col As UltraGridColumn In griMovDiarioOT.DisplayLayout.Bands(0).Columns
            If col.Key <> "Equipo" Then e.Layout.Bands(0).Columns(col.Key).MergedCellEvaluator = New CustomMergedCellEvaluator()
        Next
    End Sub

#End Region

#Region "Metodos"

    Private Sub CargarRMVOT(ByVal leRMVOT As List(Of e_MovimientoDiarioOT))
        Try
            With griMovDiarioOT

                .DataSource = leRMVOT

                .Text = "UNIDADES ATENDIDAS MES " & MonthName(fecPeriodo.Value.Month).ToUpper & " " & fecPeriodo.Value.Year

                OcultarColumna(griMovDiarioOT, True, "IndicadorTipo", "HoraINT", "HoraIT", "HoraFT", "Descripcion")

                .DisplayLayout.Bands(0).Columns("Flota").Header.VisiblePosition = 0
                .DisplayLayout.Bands(0).Columns("Equipo").Header.VisiblePosition = 1
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").Header.VisiblePosition = 2
                .DisplayLayout.Bands(0).Columns("Marca").Header.VisiblePosition = 3
                .DisplayLayout.Bands(0).Columns("Modelo").Header.VisiblePosition = 4
                .DisplayLayout.Bands(0).Columns("NroOT").Header.VisiblePosition = 5
                .DisplayLayout.Bands(0).Columns("TipoOrden").Header.VisiblePosition = 6
                .DisplayLayout.Bands(0).Columns("FechaINT").Header.VisiblePosition = 7
                .DisplayLayout.Bands(0).Columns("FechaIT").Header.VisiblePosition = 8
                .DisplayLayout.Bands(0).Columns("Kilometraje").Header.VisiblePosition = 9
                .DisplayLayout.Bands(0).Columns("FechaFT").Header.VisiblePosition = 10
                .DisplayLayout.Bands(0).Columns("Diferencia").Header.VisiblePosition = 11

                .DisplayLayout.Bands(0).Columns("Equipo").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("TipoVehiculo").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Marca").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Modelo").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("FechaINT").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("FechaIT").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Kilometraje").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("FechaFT").CellAppearance.TextVAlign = VAlign.Middle
                .DisplayLayout.Bands(0).Columns("Diferencia").CellAppearance.TextVAlign = VAlign.Middle

                .DisplayLayout.Bands(0).Columns("FechaINT").Width = 110
                .DisplayLayout.Bands(0).Columns("FechaIT").Width = 110
                .DisplayLayout.Bands(0).Columns("FechaFT").Width = 110
                .DisplayLayout.Bands(0).Columns("Marca").Width = 120

                .DisplayLayout.Bands(0).Columns("FechaINT").Style = ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("FechaIT").Style = ColumnStyle.DateTime
                .DisplayLayout.Bands(0).Columns("FechaFT").Style = ColumnStyle.DateTime

                .DisplayLayout.Bands(0).Columns("Kilometraje").Format = "#,##0.00"
                ' .DisplayLayout.Bands(0).Columns("Diferencia").Format = "#,##0.00"

                .DisplayLayout.Bands(0).Columns("FechaFT").Header.Caption = "Fecha Salida"
                .DisplayLayout.Bands(0).Columns("FechaINT").Header.Caption = "Fecha Ingreso"
                .DisplayLayout.Bands(0).Columns("FechaIT").Header.Caption = "Inicio Trabajo"
                .DisplayLayout.Bands(0).Columns("Diferencia").Header.Caption = "Total Hora"

                .DisplayLayout.Bands(0).Columns("Kilometraje").CellAppearance.TextHAlign = HAlign.Right
                .DisplayLayout.Bands(0).Columns("Diferencia").CellAppearance.TextHAlign = HAlign.Right

                .Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
                .DisplayLayout.Override.FilterOperatorDefaultValue = FilterOperatorDefaultValue.Contains
                .DisplayLayout.Override.FilterUIType = FilterUIType.FilterRow
                .DisplayLayout.Override.FilterUIProvider = Filtro1
                .DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                .DisplayLayout.Override.CellClickAction = CellClickAction.RowSelect
                .DisplayLayout.Override.RowSelectorNumberStyle = RowSelectorNumberStyle.VisibleIndex
                .DisplayLayout.MaxColScrollRegions = 1
                .DisplayLayout.MaxRowScrollRegions = 1

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

End Class