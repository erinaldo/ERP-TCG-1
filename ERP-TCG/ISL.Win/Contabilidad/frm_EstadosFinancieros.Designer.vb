<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EstadosFinancieros
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeAn")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberAn")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeMo")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberMo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeSa")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberSa")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeSaAc")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberSaAc")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup0", 182514946)
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 182514947)
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup2", 182514948)
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup3", 182514949)
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup5 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup4", 182514950)
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_DebeAn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeAn", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeAn", 3, True)
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_HaberAn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberAn", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberAn", 4, True)
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_DebeMo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeMo", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeMo", 5, True)
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_HaberMo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberMo", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberMo", 6, True)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_DebeSa", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeSa", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeSa", 7, True)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings6 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_HaberSa", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberSa", 8, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberSa", 8, True)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings7 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_DebeSaAc", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeSaAc", 9, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeSaAc", 9, True)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings8 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("Suma_HaberSaAc", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberSaAc", 10, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberSaAc", 10, True)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeAn")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberAn")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeMo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberMo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeSa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberSa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeSaAc")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberSaAc")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Texto1", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeAn")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberAn")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeMo")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberMo")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeSa")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberSa")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeSaAc")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberSaAc")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup6 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup0", 182419395)
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup7 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup1", 182419396)
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup8 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup2", 182419397)
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup9 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup3", 182419398)
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup10 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("NewGroup4", 182419399)
        Dim SummarySettings9 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumDebeAn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeAn", 3, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeAn", 3, True)
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings10 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumHaberAn", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberAn", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberAn", 4, True)
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings11 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumDebeMo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeMo", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeMo", 5, True)
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings12 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumHaberMo", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberMo", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberMo", 6, True)
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings13 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumDebeSa", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeSa", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeSa", 7, True)
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings14 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumHaberSa", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberSa", 8, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberSa", 8, True)
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings15 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumDebeSaAc", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeSaAc", 9, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeSaAc", 9, True)
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings16 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("sumHaberSaAc", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberSaAc", 10, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberSaAc", 10, True)
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Texto1")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeAn")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberAn")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeMo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberMo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeSa")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberSa")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeSaAc")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberSaAc")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDebe")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalHaber")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Movimiento", 0)
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDebe")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalHaber")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeMN")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberMN")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Movimiento", 0)
        Dim SummarySettings17 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeMN", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeMN", 6, True)
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings18 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberMN", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberMN", 7, True)
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings19 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Saldo", 8, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Saldo", 8, True)
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeMN")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberMN")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.dtEstadosFinancierosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsEstadosFinancieros = New ISL.Win.dsEstadosFinancieros()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.rpEstadosFinancieros = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_BalanceComprobacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_BalanceCompDestino = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odBalComprobacionDestino = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_AsientoDescuadrado = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odAsientosDescuadrados = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_DetalleMovimientos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odDetalleMovimientos = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.btn_Retornar = New ISL.Controles.Boton(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tcEstadosFinancieros = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.BarraProgreso1 = New ISL.Controles.BarraProgreso(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.dtEstadosFinancierosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsEstadosFinancieros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.grid_BalanceComprobacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.grid_BalanceCompDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odBalComprobacionDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.grid_AsientoDescuadrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odAsientosDescuadrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.grid_DetalleMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odDetalleMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.tcEstadosFinancieros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEstadosFinancieros.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtEstadosFinancierosBindingSource
        '
        Me.dtEstadosFinancierosBindingSource.DataMember = "dtEstadosFinancieros"
        Me.dtEstadosFinancierosBindingSource.DataSource = Me.dsEstadosFinancieros
        '
        'dsEstadosFinancieros
        '
        Me.dsEstadosFinancieros.DataSetName = "dsEstadosFinancieros"
        Me.dsEstadosFinancieros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.rpEstadosFinancieros)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1171, 434)
        '
        'rpEstadosFinancieros
        '
        Me.rpEstadosFinancieros.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsEstadosFinancieros_dtEstadosFinancieros"
        ReportDataSource1.Value = Me.dtEstadosFinancierosBindingSource
        Me.rpEstadosFinancieros.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpEstadosFinancieros.LocalReport.ReportEmbeddedResource = "ISL.Win.EstadosFinancieros.rdlc"
        Me.rpEstadosFinancieros.Location = New System.Drawing.Point(0, 0)
        Me.rpEstadosFinancieros.Name = "rpEstadosFinancieros"
        Me.rpEstadosFinancieros.Size = New System.Drawing.Size(1171, 434)
        Me.rpEstadosFinancieros.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.grid_BalanceComprobacion)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1171, 434)
        '
        'grid_BalanceComprobacion
        '
        Me.grid_BalanceComprobacion.DataSource = Me.UltraDataSource1
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn11.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.VisiblePosition = 1
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(74, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.VisiblePosition = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(238, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance1
        UltraGridColumn14.Format = "#,##0.00"
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.MaskInput = ""
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(120, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance2
        UltraGridColumn15.Format = "#,##0.00"
        UltraGridColumn15.Header.VisiblePosition = 4
        UltraGridColumn15.MaskInput = ""
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(118, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance3
        UltraGridColumn16.Format = "#,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 5
        UltraGridColumn16.MaskInput = ""
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(117, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance4
        UltraGridColumn17.Format = "#,##0.00"
        UltraGridColumn17.Header.VisiblePosition = 6
        UltraGridColumn17.MaskInput = ""
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn17.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(117, 0)
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance5
        UltraGridColumn18.Format = "#,##0.00"
        UltraGridColumn18.Header.VisiblePosition = 7
        UltraGridColumn18.MaskInput = ""
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn18.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(119, 0)
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance6
        UltraGridColumn19.Format = "#,##0.00"
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.MaskInput = ""
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn19.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(123, 0)
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance7
        UltraGridColumn20.Format = "#,##0.00"
        UltraGridColumn20.Header.VisiblePosition = 9
        UltraGridColumn20.MaskInput = ""
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn20.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(114, 0)
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance8
        UltraGridColumn21.Format = "#,##0.00"
        UltraGridColumn21.Header.VisiblePosition = 10
        UltraGridColumn21.MaskInput = ""
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        Appearance9.FontData.BoldAsString = "True"
        UltraGridGroup1.Header.Appearance = Appearance9
        UltraGridGroup1.Header.Caption = "Acumulado Anterior"
        UltraGridGroup1.Key = "NewGroup0"
        UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 6
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 4
        Appearance10.FontData.BoldAsString = "True"
        UltraGridGroup2.Header.Appearance = Appearance10
        UltraGridGroup2.Header.Caption = "Movimientos del Mes"
        UltraGridGroup2.Key = "NewGroup1"
        UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 10
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 4
        Appearance11.FontData.BoldAsString = "True"
        UltraGridGroup3.Header.Appearance = Appearance11
        UltraGridGroup3.Header.Caption = "Acumulado Actual"
        UltraGridGroup3.Key = "NewGroup2"
        UltraGridGroup3.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup3.RowLayoutGroupInfo.OriginX = 14
        UltraGridGroup3.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup3.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup3.RowLayoutGroupInfo.SpanY = 4
        Appearance12.FontData.BoldAsString = "True"
        UltraGridGroup4.Header.Appearance = Appearance12
        UltraGridGroup4.Header.Caption = "Saldos Acumulados"
        UltraGridGroup4.Key = "NewGroup3"
        UltraGridGroup4.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup4.RowLayoutGroupInfo.OriginX = 18
        UltraGridGroup4.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup4.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup4.RowLayoutGroupInfo.SpanY = 4
        UltraGridGroup5.Header.Caption = ""
        UltraGridGroup5.Key = "NewGroup4"
        UltraGridGroup5.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup5.RowLayoutGroupInfo.OriginX = 0
        UltraGridGroup5.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup5.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup5.RowLayoutGroupInfo.SpanY = 4
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4, UltraGridGroup5})
        UltraGridBand1.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        UltraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Appearance13.FontData.BoldAsString = "True"
        Appearance13.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance13
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance14
        Appearance15.FontData.BoldAsString = "True"
        Appearance15.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance15
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance16
        Appearance17.FontData.BoldAsString = "True"
        Appearance17.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance17
        SummarySettings3.DisplayFormat = "{0:#,##0.00}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance18
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance19
        SummarySettings4.DisplayFormat = "{0:#,##0.00}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance20
        Appearance21.FontData.BoldAsString = "True"
        Appearance21.TextHAlignAsString = "Right"
        SummarySettings5.Appearance = Appearance21
        SummarySettings5.DisplayFormat = "{0:#,##0.00}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance22
        Appearance23.FontData.BoldAsString = "True"
        Appearance23.TextHAlignAsString = "Right"
        SummarySettings6.Appearance = Appearance23
        SummarySettings6.DisplayFormat = "{0:#,##0.00}"
        SummarySettings6.GroupBySummaryValueAppearance = Appearance24
        Appearance25.FontData.BoldAsString = "True"
        Appearance25.TextHAlignAsString = "Right"
        SummarySettings7.Appearance = Appearance25
        SummarySettings7.DisplayFormat = "{0:#,##0.00}"
        SummarySettings7.GroupBySummaryValueAppearance = Appearance26
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.TextHAlignAsString = "Right"
        SummarySettings8.Appearance = Appearance27
        SummarySettings8.DisplayFormat = "{0:#,##0.00}"
        SummarySettings8.GroupBySummaryValueAppearance = Appearance28
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4, SummarySettings5, SummarySettings6, SummarySettings7, SummarySettings8})
        UltraGridBand1.SummaryFooterCaption = "Totales"
        Me.grid_BalanceComprobacion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_BalanceComprobacion.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_BalanceComprobacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_BalanceComprobacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_BalanceComprobacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_BalanceComprobacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_BalanceComprobacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.StartsWith
        Me.grid_BalanceComprobacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_BalanceComprobacion.DisplayLayout.Override.FormulaRowIndexSource = Infragistics.Win.UltraWinGrid.FormulaRowIndexSource.ListIndex
        Me.grid_BalanceComprobacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_BalanceComprobacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_BalanceComprobacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_BalanceComprobacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_BalanceComprobacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_BalanceComprobacion.Location = New System.Drawing.Point(0, 0)
        Me.grid_BalanceComprobacion.Name = "grid_BalanceComprobacion"
        Me.grid_BalanceComprobacion.Size = New System.Drawing.Size(1171, 434)
        Me.grid_BalanceComprobacion.TabIndex = 5
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.grid_BalanceCompDestino)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1171, 434)
        '
        'grid_BalanceCompDestino
        '
        Me.grid_BalanceCompDestino.DataSource = Me.odBalComprobacionDestino
        UltraGridColumn22.Header.VisiblePosition = 0
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.VisiblePosition = 1
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn23.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(51, 0)
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.VisiblePosition = 2
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupKey = "NewGroup4"
        UltraGridColumn24.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(224, 0)
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance29
        UltraGridColumn25.Format = "#,##0.00"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.MaskInput = ""
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn25.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance30
        UltraGridColumn26.Format = "#,##0.00"
        UltraGridColumn26.Header.VisiblePosition = 4
        UltraGridColumn26.MaskInput = ""
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn26.RowLayoutColumnInfo.ParentGroupKey = "NewGroup0"
        UltraGridColumn26.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance31
        UltraGridColumn27.Format = "#,##0.00"
        UltraGridColumn27.Header.VisiblePosition = 5
        UltraGridColumn27.MaskInput = ""
        UltraGridColumn27.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn27.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn27.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn27.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn27.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(112, 0)
        UltraGridColumn27.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn27.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance32
        UltraGridColumn28.Format = "#,##0.00"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.MaskInput = ""
        UltraGridColumn28.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn28.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn28.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn28.RowLayoutColumnInfo.ParentGroupKey = "NewGroup1"
        UltraGridColumn28.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn28.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn28.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance33
        UltraGridColumn29.Format = "#,##0.00"
        UltraGridColumn29.Header.VisiblePosition = 7
        UltraGridColumn29.MaskInput = ""
        UltraGridColumn29.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn29.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn29.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn29.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn29.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(113, 0)
        UltraGridColumn29.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn29.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance34
        UltraGridColumn30.Format = "#,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn30.MaskInput = ""
        UltraGridColumn30.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn30.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn30.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn30.RowLayoutColumnInfo.ParentGroupKey = "NewGroup2"
        UltraGridColumn30.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(119, 0)
        UltraGridColumn30.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn30.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn30.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance35
        UltraGridColumn31.Format = "#,##0.00"
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridColumn31.MaskInput = ""
        UltraGridColumn31.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn31.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn31.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn31.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn31.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(108, 0)
        UltraGridColumn31.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn31.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance36
        UltraGridColumn32.Format = "#,##0.00"
        UltraGridColumn32.Header.VisiblePosition = 10
        UltraGridColumn32.MaskInput = ""
        UltraGridColumn32.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn32.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn32.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn32.RowLayoutColumnInfo.ParentGroupKey = "NewGroup3"
        UltraGridColumn32.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn32.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn32.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        Appearance37.FontData.BoldAsString = "True"
        UltraGridGroup6.Header.Appearance = Appearance37
        UltraGridGroup6.Header.Caption = "Acumulado Anterior"
        UltraGridGroup6.Key = "NewGroup0"
        UltraGridGroup6.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup6.RowLayoutGroupInfo.OriginX = 6
        UltraGridGroup6.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup6.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup6.RowLayoutGroupInfo.SpanY = 3
        Appearance38.FontData.BoldAsString = "True"
        UltraGridGroup7.Header.Appearance = Appearance38
        UltraGridGroup7.Header.Caption = "Movimientos del Mes"
        UltraGridGroup7.Key = "NewGroup1"
        UltraGridGroup7.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup7.RowLayoutGroupInfo.OriginX = 10
        UltraGridGroup7.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup7.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup7.RowLayoutGroupInfo.SpanY = 3
        Appearance39.FontData.BoldAsString = "True"
        UltraGridGroup8.Header.Appearance = Appearance39
        UltraGridGroup8.Header.Caption = "Acumulado Actual"
        UltraGridGroup8.Key = "NewGroup2"
        UltraGridGroup8.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup8.RowLayoutGroupInfo.OriginX = 14
        UltraGridGroup8.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup8.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup8.RowLayoutGroupInfo.SpanY = 3
        Appearance40.FontData.BoldAsString = "True"
        UltraGridGroup9.Header.Appearance = Appearance40
        UltraGridGroup9.Header.Caption = "Saldos Acumulados"
        UltraGridGroup9.Key = "NewGroup3"
        UltraGridGroup9.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup9.RowLayoutGroupInfo.OriginX = 18
        UltraGridGroup9.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup9.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup9.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup10.Header.Caption = ""
        UltraGridGroup10.Key = "NewGroup4"
        UltraGridGroup10.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup10.RowLayoutGroupInfo.OriginX = 0
        UltraGridGroup10.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup10.RowLayoutGroupInfo.SpanX = 6
        UltraGridGroup10.RowLayoutGroupInfo.SpanY = 3
        UltraGridBand2.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup6, UltraGridGroup7, UltraGridGroup8, UltraGridGroup9, UltraGridGroup10})
        UltraGridBand2.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        UltraGridBand2.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Appearance41.FontData.BoldAsString = "True"
        Appearance41.TextHAlignAsString = "Right"
        SummarySettings9.Appearance = Appearance41
        SummarySettings9.DisplayFormat = "{0:#,##0.00}"
        SummarySettings9.GroupBySummaryValueAppearance = Appearance42
        Appearance43.FontData.BoldAsString = "True"
        Appearance43.TextHAlignAsString = "Right"
        SummarySettings10.Appearance = Appearance43
        SummarySettings10.DisplayFormat = "{0:#,##0.00}"
        SummarySettings10.GroupBySummaryValueAppearance = Appearance44
        Appearance45.FontData.BoldAsString = "True"
        Appearance45.TextHAlignAsString = "Right"
        SummarySettings11.Appearance = Appearance45
        SummarySettings11.DisplayFormat = "{0:#,##0.00}"
        SummarySettings11.GroupBySummaryValueAppearance = Appearance46
        Appearance47.FontData.BoldAsString = "True"
        Appearance47.TextHAlignAsString = "Right"
        SummarySettings12.Appearance = Appearance47
        SummarySettings12.DisplayFormat = "{0:#,##0.00}"
        SummarySettings12.GroupBySummaryValueAppearance = Appearance48
        Appearance49.FontData.BoldAsString = "True"
        Appearance49.TextHAlignAsString = "Right"
        SummarySettings13.Appearance = Appearance49
        SummarySettings13.DisplayFormat = "{0:#,##0.00}"
        SummarySettings13.GroupBySummaryValueAppearance = Appearance50
        Appearance51.FontData.BoldAsString = "True"
        Appearance51.TextHAlignAsString = "Right"
        SummarySettings14.Appearance = Appearance51
        SummarySettings14.DisplayFormat = "{0:#,##0.00}"
        SummarySettings14.GroupBySummaryValueAppearance = Appearance52
        Appearance53.FontData.BoldAsString = "True"
        Appearance53.TextHAlignAsString = "Right"
        SummarySettings15.Appearance = Appearance53
        SummarySettings15.DisplayFormat = "{0:#,##0.00}"
        SummarySettings15.GroupBySummaryValueAppearance = Appearance54
        Appearance55.FontData.BoldAsString = "True"
        Appearance55.TextHAlignAsString = "Right"
        SummarySettings16.Appearance = Appearance55
        SummarySettings16.DisplayFormat = "{0:#,##0.00}"
        SummarySettings16.GroupBySummaryValueAppearance = Appearance56
        UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings9, SummarySettings10, SummarySettings11, SummarySettings12, SummarySettings13, SummarySettings14, SummarySettings15, SummarySettings16})
        UltraGridBand2.SummaryFooterCaption = "Totales"
        Me.grid_BalanceCompDestino.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_BalanceCompDestino.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_BalanceCompDestino.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_BalanceCompDestino.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_BalanceCompDestino.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_BalanceCompDestino.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_BalanceCompDestino.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_BalanceCompDestino.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_BalanceCompDestino.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_BalanceCompDestino.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_BalanceCompDestino.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_BalanceCompDestino.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grid_BalanceCompDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_BalanceCompDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_BalanceCompDestino.Location = New System.Drawing.Point(0, 0)
        Me.grid_BalanceCompDestino.Name = "grid_BalanceCompDestino"
        Me.grid_BalanceCompDestino.Size = New System.Drawing.Size(1171, 434)
        Me.grid_BalanceCompDestino.TabIndex = 7
        '
        'odBalComprobacionDestino
        '
        Me.odBalComprobacionDestino.Band.Columns.AddRange(New Object() {UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.grid_AsientoDescuadrado)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1171, 434)
        '
        'grid_AsientoDescuadrado
        '
        Me.grid_AsientoDescuadrado.DataSource = Me.odAsientosDescuadrados
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn3.Header.Caption = "Tipo Asiento"
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 96
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn4.Header.Caption = "Nro Asiento"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 96
        Appearance57.TextHAlignAsString = "Center"
        UltraGridColumn5.CellAppearance = Appearance57
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 90
        UltraGridColumn6.Header.VisiblePosition = 4
        UltraGridColumn6.Width = 375
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance58
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.Caption = "Total Debe"
        UltraGridColumn7.Header.VisiblePosition = 6
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance59
        UltraGridColumn8.Format = "#,##0.00"
        UltraGridColumn8.Header.Caption = "Total Haber"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 5
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 92
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10})
        Me.grid_AsientoDescuadrado.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_AsientoDescuadrado.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_AsientoDescuadrado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_AsientoDescuadrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_AsientoDescuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_AsientoDescuadrado.Location = New System.Drawing.Point(0, 0)
        Me.grid_AsientoDescuadrado.Name = "grid_AsientoDescuadrado"
        Me.grid_AsientoDescuadrado.Size = New System.Drawing.Size(1171, 434)
        Me.grid_AsientoDescuadrado.TabIndex = 4
        Me.grid_AsientoDescuadrado.Text = "AsientosDescuadrados"
        '
        'odAsientosDescuadrados
        '
        UltraDataColumn26.DataType = GetType(Date)
        UltraDataColumn28.DataType = GetType(Double)
        UltraDataColumn28.DefaultValue = 0.0R
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn29.DefaultValue = 0.0R
        Me.odAsientosDescuadrados.Band.Columns.AddRange(New Object() {UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.grid_DetalleMovimientos)
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1171, 434)
        '
        'grid_DetalleMovimientos
        '
        Me.grid_DetalleMovimientos.DataSource = Me.odDetalleMovimientos
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 76
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Width = 78
        UltraGridColumn35.Header.Caption = "Tipo Asiento"
        UltraGridColumn35.Header.VisiblePosition = 1
        UltraGridColumn35.Width = 78
        UltraGridColumn36.Header.VisiblePosition = 2
        UltraGridColumn36.Width = 92
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.Width = 75
        UltraGridColumn38.Header.VisiblePosition = 5
        UltraGridColumn38.Width = 226
        Appearance60.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance60
        UltraGridColumn39.Format = "#,##0.00"
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance61
        UltraGridColumn40.Format = "#,##0.00"
        UltraGridColumn40.Header.VisiblePosition = 8
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance62
        UltraGridColumn41.Format = "#,##0.00"
        UltraGridColumn41.Header.VisiblePosition = 9
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn41.Width = 97
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn42.Width = 216
        UltraGridColumn85.Header.VisiblePosition = 11
        UltraGridColumn86.Header.VisiblePosition = 6
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Width = 92
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn85, UltraGridColumn86})
        Appearance63.TextHAlignAsString = "Right"
        SummarySettings17.Appearance = Appearance63
        SummarySettings17.DisplayFormat = "{0:#,##0.00}"
        SummarySettings17.GroupBySummaryValueAppearance = Appearance64
        Appearance65.TextHAlignAsString = "Right"
        SummarySettings18.Appearance = Appearance65
        SummarySettings18.DisplayFormat = "{0:#,##0.00}"
        SummarySettings18.GroupBySummaryValueAppearance = Appearance66
        Appearance67.TextHAlignAsString = "Right"
        SummarySettings19.Appearance = Appearance67
        SummarySettings19.DisplayFormat = "{0:#,##0.00}"
        SummarySettings19.GroupBySummaryValueAppearance = Appearance68
        UltraGridBand4.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings17, SummarySettings18, SummarySettings19})
        UltraGridBand4.SummaryFooterCaption = "Totales"
        Me.grid_DetalleMovimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_DetalleMovimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_DetalleMovimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DetalleMovimientos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_DetalleMovimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_DetalleMovimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_DetalleMovimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_DetalleMovimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_DetalleMovimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_DetalleMovimientos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DetalleMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_DetalleMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_DetalleMovimientos.Location = New System.Drawing.Point(0, 37)
        Me.grid_DetalleMovimientos.Name = "grid_DetalleMovimientos"
        Me.grid_DetalleMovimientos.Size = New System.Drawing.Size(1171, 397)
        Me.grid_DetalleMovimientos.TabIndex = 5
        Me.grid_DetalleMovimientos.Text = "Detalles de Movimientos"
        '
        'odDetalleMovimientos
        '
        Me.odDetalleMovimientos.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.btn_Retornar)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1171, 37)
        Me.Agrupacion2.TabIndex = 6
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btn_Retornar
        '
        Me.btn_Retornar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Retornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Retornar.ForeColor = System.Drawing.Color.Black
        Me.btn_Retornar.Location = New System.Drawing.Point(5, 3)
        Me.btn_Retornar.Name = "btn_Retornar"
        Me.btn_Retornar.Size = New System.Drawing.Size(134, 29)
        Me.btn_Retornar.TabIndex = 0
        Me.btn_Retornar.Text = "Retornar"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tcEstadosFinancieros
        '
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabPageControl1)
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabPageControl2)
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabPageControl3)
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabPageControl4)
        Me.tcEstadosFinancieros.Controls.Add(Me.UltraTabPageControl5)
        Me.tcEstadosFinancieros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcEstadosFinancieros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcEstadosFinancieros.Location = New System.Drawing.Point(0, 49)
        Me.tcEstadosFinancieros.Name = "tcEstadosFinancieros"
        Me.tcEstadosFinancieros.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcEstadosFinancieros.Size = New System.Drawing.Size(1173, 457)
        Me.tcEstadosFinancieros.TabIndex = 6
        UltraTab1.Key = "Balance General"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Balance General"
        UltraTab2.Key = "Balance Comprobacion"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Balance Comprobacion"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Balance Comprobacion Destino"
        UltraTab4.Key = "AsientosDescuadrados"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Asientos Descuadrados"
        UltraTab5.Key = "DetallesMovimientos"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Detalles de Movimientos"
        Me.tcEstadosFinancieros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5})
        Me.tcEstadosFinancieros.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1171, 434)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.BarraProgreso1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1173, 49)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Estados Financieros"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'BarraProgreso1
        '
        Me.BarraProgreso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarraProgreso1.ForeColor = System.Drawing.Color.Black
        Me.BarraProgreso1.Location = New System.Drawing.Point(544, 22)
        Me.BarraProgreso1.Name = "BarraProgreso1"
        Me.BarraProgreso1.Size = New System.Drawing.Size(419, 21)
        Me.BarraProgreso1.Style = Infragistics.Win.UltraWinProgressBar.ProgressBarStyle.Office2007Continuous
        Me.BarraProgreso1.TabIndex = 7
        Me.BarraProgreso1.Text = "[Formatted]"
        Me.BarraProgreso1.Visible = False
        '
        'Etiqueta7
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance69
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(121, 25)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Mes:"
        '
        'Año1
        '
        Me.Año1.Año = 2015
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Controls.Add(Me.NumeroEntero2)
        Me.Año1.Location = New System.Drawing.Point(61, 21)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 4
        '
        'numAño
        '
        Appearance70.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance70
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2012
        '
        'NumeroEntero1
        '
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance71
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2011
        '
        'NumeroEntero2
        '
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance72
        Me.NumeroEntero2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero2.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.FormatString = ""
        Me.NumeroEntero2.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero2.MaskInput = "nnnn"
        Me.NumeroEntero2.MaxValue = 2020
        Me.NumeroEntero2.MinValue = 2000
        Me.NumeroEntero2.Name = "NumeroEntero2"
        Me.NumeroEntero2.NullText = "0"
        Me.NumeroEntero2.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero2.TabIndex = 0
        Me.NumeroEntero2.Value = 2011
        '
        'cboMes
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance73
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(157, 21)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(121, 21)
        Me.cboMes.TabIndex = 5
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance74
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(6, 25)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'frm_EstadosFinancieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 506)
        Me.Controls.Add(Me.tcEstadosFinancieros)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_EstadosFinancieros"
        Me.Text = "Estados Financieros"
        CType(Me.dtEstadosFinancierosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsEstadosFinancieros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.grid_BalanceComprobacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.grid_BalanceCompDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odBalComprobacionDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.grid_AsientoDescuadrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odAsientosDescuadrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.grid_DetalleMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odDetalleMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.tcEstadosFinancieros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEstadosFinancieros.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents tcEstadosFinancieros As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents BarraProgreso1 As ISL.Controles.BarraProgreso
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odBalComprobacionDestino As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents grid_AsientoDescuadrado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odAsientosDescuadrados As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents grid_BalanceComprobacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents grid_BalanceCompDestino As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents rpEstadosFinancieros As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtEstadosFinancierosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsEstadosFinancieros As ISL.Win.dsEstadosFinancieros
    Friend WithEvents grid_DetalleMovimientos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odDetalleMovimientos As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents btn_Retornar As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro

End Class
