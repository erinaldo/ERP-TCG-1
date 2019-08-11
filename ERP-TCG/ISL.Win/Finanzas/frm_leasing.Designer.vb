<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Leasing
    Inherits ISL.Win.frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaBanco", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoMN")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoME")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaInteres")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuotas")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresCompensatorio")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDsctoInteres")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresCompensatorio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoDsctoInteres")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaBanco")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMontoMN")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMontoME")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaInteres")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuotas")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoObligacion")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ITF")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MontoCapital", 29, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MontoCapital", 29, True)
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MontoInteres", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MontoInteres", 7, True)
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Total", 31, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Total", 31, True)
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "MontoCuota", 30, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "MontoCuota", 30, True)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoObligacion")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ITF")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Leasing))
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_Leasing = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odContratosLeasing = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.fecFin = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Espere1 = New ISL.Win.Espere()
        Me.grid_Cuotas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.mnAgregadosLeasing = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.odCuotas = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnGenerar = New Infragistics.Win.Misc.UltraButton()
        Me.decMontoInicial = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTasaMensual = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.txt_Glosa = New ISL.Controles.Texto(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTasaInteres = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecEmision = New ISL.Controles.Fecha(Me.components)
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.txtNroContrato = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.decComision = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroVencimiento = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.decMontoCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.decIGV = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecMontoInteres = New ISL.Controles.NumeroDecimal(Me.components)
        Me.lblTotalCuota = New ISL.Controles.Etiqueta(Me.components)
        Me.DecMontoAmortizacion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.decPortes = New ISL.Controles.NumeroDecimal(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.tcLeasing = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_Leasing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odContratosLeasing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.grid_Cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnAgregadosLeasing.SuspendLayout()
        CType(Me.odCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.decMontoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTasaMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTasaInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.decComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoAmortizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPortes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcLeasing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcLeasing.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_Leasing)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1140, 483)
        '
        'grid_Leasing
        '
        Me.grid_Leasing.DataSource = Me.odContratosLeasing
        UltraGridColumn49.Header.VisiblePosition = 0
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.Caption = "Tipo"
        UltraGridColumn50.Header.VisiblePosition = 1
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 69
        UltraGridColumn11.Header.Caption = "Nro. Contrato"
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.Width = 106
        UltraGridColumn52.Header.Caption = "Banco"
        UltraGridColumn52.Header.VisiblePosition = 4
        UltraGridColumn52.Width = 277
        UltraGridColumn53.Header.VisiblePosition = 5
        UltraGridColumn53.Width = 235
        UltraGridColumn54.Header.Caption = "Fec. Emision"
        UltraGridColumn54.Header.VisiblePosition = 2
        UltraGridColumn54.Width = 107
        UltraGridColumn55.Header.Caption = "Fec.Venc."
        UltraGridColumn55.Header.VisiblePosition = 7
        UltraGridColumn55.Hidden = True
        UltraGridColumn55.Width = 84
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn56.CellAppearance = Appearance1
        UltraGridColumn56.Header.Caption = "Moneda"
        UltraGridColumn56.Header.VisiblePosition = 6
        UltraGridColumn56.Width = 82
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn57.CellAppearance = Appearance2
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn57.Format = "#,##0.0000"
        UltraGridColumn57.Header.Caption = "T.C."
        UltraGridColumn57.Header.VisiblePosition = 8
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn57.Width = 62
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance3
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn58.Format = "#,##0.00"
        UltraGridColumn58.Header.VisiblePosition = 9
        UltraGridColumn58.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn58.Width = 86
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn59.CellAppearance = Appearance4
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn59.Format = "#,##0.00"
        UltraGridColumn59.Header.VisiblePosition = 10
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn59.Width = 91
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn60.CellAppearance = Appearance5
        UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn60.Format = "#,##0.00"
        UltraGridColumn60.Header.VisiblePosition = 12
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn60.Width = 103
        UltraGridColumn61.Header.VisiblePosition = 11
        UltraGridColumn61.Width = 86
        UltraGridColumn66.Header.VisiblePosition = 13
        UltraGridColumn66.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 14
        UltraGridColumn70.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 15
        UltraGridColumn7.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn49, UltraGridColumn50, UltraGridColumn11, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn66, UltraGridColumn70, UltraGridColumn7, UltraGridColumn5})
        Appearance6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridBand1.Override.CellAppearance = Appearance6
        UltraGridColumn15.Header.Caption = "Nro"
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Width = 63
        UltraGridColumn6.Header.Caption = "Fec Vencimiento"
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 112
        UltraGridColumn12.Header.VisiblePosition = 2
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn14.Header.VisiblePosition = 9
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn20.Header.Caption = "Interes Comp."
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn21.Header.Caption = "Interes Mor."
        UltraGridColumn21.Header.VisiblePosition = 7
        UltraGridColumn22.Header.VisiblePosition = 8
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn6, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Me.grid_Leasing.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_Leasing.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_Leasing.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Leasing.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grid_Leasing.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Leasing.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Leasing.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_Leasing.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Leasing.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Leasing.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Leasing.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Leasing.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Leasing.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Leasing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Leasing.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Leasing.Location = New System.Drawing.Point(0, 41)
        Me.grid_Leasing.Name = "grid_Leasing"
        Me.grid_Leasing.Size = New System.Drawing.Size(1140, 442)
        Me.grid_Leasing.TabIndex = 9
        '
        'odContratosLeasing
        '
        UltraDataColumn2.DataType = GetType(Date)
        UltraDataColumn2.DefaultValue = New Date(CType(0, Long))
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        Me.odContratosLeasing.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        Me.odContratosLeasing.Band.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.fecInicio)
        Me.Agrupacion1.Controls.Add(Me.fecFin)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1140, 41)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecInicio
        '
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(100, 12)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(90, 20)
        Me.fecInicio.TabIndex = 3
        '
        'fecFin
        '
        Me.fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFin.Location = New System.Drawing.Point(262, 12)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(90, 20)
        Me.fecFin.TabIndex = 2
        '
        'Etiqueta10
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance7
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(196, 16)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta10.TabIndex = 1
        Me.Etiqueta10.Text = "Fecha Fin:"
        '
        'Etiqueta9
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance8
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(19, 16)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(75, 15)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Fecha Inicio:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Espere1)
        Me.UltraTabPageControl2.Controls.Add(Me.grid_Cuotas)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1140, 483)
        '
        'Espere1
        '
        Me.Espere1.Location = New System.Drawing.Point(436, 297)
        Me.Espere1.Name = "Espere1"
        Me.Espere1.Size = New System.Drawing.Size(393, 67)
        Me.Espere1.TabIndex = 27
        Me.Espere1.Visible = False
        '
        'grid_Cuotas
        '
        Me.grid_Cuotas.ContextMenuStrip = Me.mnAgregadosLeasing
        Me.grid_Cuotas.DataSource = Me.odCuotas
        UltraGridColumn8.Header.VisiblePosition = 13
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 14
        UltraGridColumn9.Hidden = True
        UltraGridColumn24.Header.Caption = "Nro Cuota"
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Width = 58
        UltraGridColumn37.Header.VisiblePosition = 30
        UltraGridColumn37.Hidden = True
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn42.Header.Caption = "Fec.Venc."
        UltraGridColumn42.Header.VisiblePosition = 2
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn42.Width = 78
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance9
        UltraGridColumn25.Format = "#,##0.00"
        UltraGridColumn25.Header.VisiblePosition = 3
        UltraGridColumn25.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance10
        UltraGridColumn4.Format = "#,##0.00"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance11
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn44.Format = "#,##0.00"
        UltraGridColumn44.Header.Caption = "Interes"
        UltraGridColumn44.Header.VisiblePosition = 6
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn44.Width = 85
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn17.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 18
        UltraGridColumn26.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 29
        UltraGridColumn3.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 19
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 20
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 21
        UltraGridColumn29.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance12
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn46.Format = "#,##0.00"
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn47.Format = "#,##0.00"
        UltraGridColumn47.Header.VisiblePosition = 12
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance13
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Format = "#,##0.00"
        UltraGridColumn48.Header.VisiblePosition = 9
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn48.Width = 69
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn1.CellAppearance = Appearance14
        UltraGridColumn1.Format = "#,##0.00"
        UltraGridColumn1.Header.VisiblePosition = 10
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance15
        UltraGridColumn16.Format = "#,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn30.Header.VisiblePosition = 22
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 23
        UltraGridColumn31.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 31
        UltraGridColumn38.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 15
        UltraGridColumn10.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 24
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 25
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 26
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 27
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 28
        UltraGridColumn36.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance16
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Format = "#,##0.00"
        UltraGridColumn41.Header.Caption = "Monto Capital"
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn41.Width = 81
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance17
        UltraGridColumn2.Format = "#,##0.00"
        UltraGridColumn2.Header.Caption = "Monto Cuota"
        UltraGridColumn2.Header.VisiblePosition = 7
        UltraGridColumn2.Width = 89
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance18
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn45.Format = "#,##0.00"
        UltraGridColumn45.Header.Caption = "Total Cuota"
        UltraGridColumn45.Header.VisiblePosition = 11
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn45.Width = 108
        UltraGridColumn39.Header.VisiblePosition = 32
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 33
        UltraGridColumn40.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 34
        UltraGridColumn43.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 35
        UltraGridColumn51.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 36
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 37
        UltraGridColumn63.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn8, UltraGridColumn9, UltraGridColumn24, UltraGridColumn37, UltraGridColumn42, UltraGridColumn25, UltraGridColumn4, UltraGridColumn44, UltraGridColumn17, UltraGridColumn26, UltraGridColumn3, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn1, UltraGridColumn16, UltraGridColumn30, UltraGridColumn31, UltraGridColumn38, UltraGridColumn10, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn23, UltraGridColumn41, UltraGridColumn2, UltraGridColumn45, UltraGridColumn39, UltraGridColumn40, UltraGridColumn43, UltraGridColumn51, UltraGridColumn62, UltraGridColumn63})
        Appearance19.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance19
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance20
        Appearance21.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance21
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance23
        SummarySettings3.DisplayFormat = "{0:#,##0.00}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance24
        Appearance25.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance25
        SummarySettings4.DisplayFormat = "{0:#,##0.00}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance26
        UltraGridBand3.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4})
        UltraGridBand3.SummaryFooterCaption = "Totales"
        Me.grid_Cuotas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.TextHAlignAsString = "Left"
        Me.grid_Cuotas.DisplayLayout.CaptionAppearance = Appearance27
        Me.grid_Cuotas.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Cuotas.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Cuotas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Cuotas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Cuotas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_Cuotas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Cuotas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Cuotas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Cuotas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Cuotas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Cuotas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.grid_Cuotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Cuotas.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Cuotas.Location = New System.Drawing.Point(0, 214)
        Me.grid_Cuotas.Name = "grid_Cuotas"
        Me.grid_Cuotas.Size = New System.Drawing.Size(1140, 269)
        Me.grid_Cuotas.TabIndex = 26
        Me.grid_Cuotas.Text = "Cuotas:"
        '
        'mnAgregadosLeasing
        '
        Me.mnAgregadosLeasing.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnAgregadosLeasing.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnAgregadosLeasing.Name = "mnu_Transferencias"
        Me.mnAgregadosLeasing.Size = New System.Drawing.Size(112, 30)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 26)
        Me.ToolStripMenuItem1.Text = "Quitar"
        '
        'odCuotas
        '
        UltraDataColumn31.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn34.DataType = GetType(Double)
        UltraDataColumn34.DefaultValue = 0.0R
        UltraDataColumn35.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Integer)
        UltraDataColumn39.DataType = GetType(Integer)
        UltraDataColumn40.DataType = GetType(Integer)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn43.DataType = GetType(Double)
        UltraDataColumn44.DataType = GetType(Double)
        UltraDataColumn44.DefaultValue = 0.0R
        UltraDataColumn45.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Date)
        UltraDataColumn54.DataType = GetType(Boolean)
        UltraDataColumn55.DataType = GetType(Date)
        UltraDataColumn56.DataType = GetType(Double)
        UltraDataColumn56.DefaultValue = 0.0R
        UltraDataColumn57.DataType = GetType(Double)
        UltraDataColumn57.DefaultValue = 0.0R
        UltraDataColumn58.DataType = GetType(Double)
        UltraDataColumn64.DataType = GetType(Double)
        Me.odCuotas.Band.Columns.AddRange(New Object() {UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64})
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion12.Controls.Add(Me.decTasaMensual)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion12.Controls.Add(Me.txt_Glosa)
        Me.Agrupacion12.Controls.Add(Me.cboMoneda)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion12.Controls.Add(Me.DecTC)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion12.Controls.Add(Me.decTasaInteres)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion12.Controls.Add(Me.fecEmision)
        Me.Agrupacion12.Controls.Add(Me.cboBanco)
        Me.Agrupacion12.Controls.Add(Me.txtNroContrato)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion12.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1140, 214)
        Me.Agrupacion12.TabIndex = 0
        Me.Agrupacion12.Text = "Datos Contrato:"
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnGenerar)
        Me.Agrupacion3.Controls.Add(Me.decMontoInicial)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(835, 103)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(178, 70)
        Me.Agrupacion3.TabIndex = 81
        Me.Agrupacion3.Text = "AutoGenerar"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        Me.Agrupacion3.Visible = False
        '
        'btnGenerar
        '
        Appearance28.Image = "add.ico"
        Me.btnGenerar.Appearance = Appearance28
        Me.btnGenerar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGenerar.Location = New System.Drawing.Point(106, 32)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(66, 29)
        Me.btnGenerar.TabIndex = 80
        Me.btnGenerar.Text = "Generar"
        '
        'decMontoInicial
        '
        Appearance29.ForeColor = System.Drawing.Color.Black
        Me.decMontoInicial.Appearance = Appearance29
        Me.decMontoInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoInicial.ForeColor = System.Drawing.Color.Black
        Me.decMontoInicial.Location = New System.Drawing.Point(5, 38)
        Me.decMontoInicial.MaskInput = "{double:8.4}"
        Me.decMontoInicial.Name = "decMontoInicial"
        Me.decMontoInicial.NullText = "0.00"
        Me.decMontoInicial.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoInicial.Size = New System.Drawing.Size(95, 21)
        Me.decMontoInicial.TabIndex = 78
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(5, 21)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta2.TabIndex = 79
        Me.Etiqueta2.Text = "Monto Inicial:"
        '
        'Etiqueta5
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance30
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(500, 51)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(18, 15)
        Me.Etiqueta5.TabIndex = 83
        Me.Etiqueta5.Text = "%"
        '
        'decTasaMensual
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.decTasaMensual.Appearance = Appearance31
        Me.decTasaMensual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTasaMensual.Enabled = False
        Me.decTasaMensual.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTasaMensual.ForeColor = System.Drawing.Color.Black
        Me.decTasaMensual.Location = New System.Drawing.Point(436, 49)
        Me.decTasaMensual.MaskInput = "{double:3.4}"
        Me.decTasaMensual.Name = "decTasaMensual"
        Me.decTasaMensual.NullText = "0.00"
        Me.decTasaMensual.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTasaMensual.Size = New System.Drawing.Size(57, 22)
        Me.decTasaMensual.TabIndex = 81
        '
        'Etiqueta3
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance32
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(350, 50)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(85, 15)
        Me.Etiqueta3.TabIndex = 82
        Me.Etiqueta3.Text = "Tasa Mensual:"
        '
        'Etiqueta14
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance33
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(51, 78)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta14.TabIndex = 54
        Me.Etiqueta14.Text = "Glosa:"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Glosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Glosa.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.Location = New System.Drawing.Point(92, 76)
        Me.txt_Glosa.MaxLength = 200
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(737, 22)
        Me.txt_Glosa.TabIndex = 17
        '
        'cboMoneda
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance34
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMoneda.DropDownListWidth = 150
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(92, 49)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(95, 22)
        Me.cboMoneda.TabIndex = 12
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance35
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(39, 50)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(53, 15)
        Me.Etiqueta12.TabIndex = 48
        Me.Etiqueta12.Text = "Moneda:"
        '
        'DecTC
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance36
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(750, 22)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(78, 22)
        Me.DecTC.TabIndex = 14
        '
        'Etiqueta4
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance37
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(330, 51)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(18, 15)
        Me.Etiqueta4.TabIndex = 71
        Me.Etiqueta4.Text = "%"
        '
        'Etiqueta13
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance38
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(668, 23)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(82, 15)
        Me.Etiqueta13.TabIndex = 47
        Me.Etiqueta13.Text = "Tipo Cambio :"
        '
        'decTasaInteres
        '
        Appearance39.ForeColor = System.Drawing.Color.Black
        Me.decTasaInteres.Appearance = Appearance39
        Me.decTasaInteres.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTasaInteres.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTasaInteres.ForeColor = System.Drawing.Color.Black
        Me.decTasaInteres.Location = New System.Drawing.Point(266, 49)
        Me.decTasaInteres.MaskInput = "{double:3.4}"
        Me.decTasaInteres.Name = "decTasaInteres"
        Me.decTasaInteres.NullText = "0.00"
        Me.decTasaInteres.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTasaInteres.Size = New System.Drawing.Size(57, 22)
        Me.decTasaInteres.TabIndex = 33
        '
        'Etiqueta24
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance40
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(194, 50)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(70, 15)
        Me.Etiqueta24.TabIndex = 69
        Me.Etiqueta24.Text = "Tasa Anual:"
        '
        'fecEmision
        '
        Appearance41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecEmision.Appearance = Appearance41
        Me.fecEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEmision.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecEmision.Location = New System.Drawing.Point(577, 22)
        Me.fecEmision.Name = "fecEmision"
        Me.fecEmision.Size = New System.Drawing.Size(84, 22)
        Me.fecEmision.TabIndex = 11
        '
        'cboBanco
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.cboBanco.Appearance = Appearance42
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboBanco.DropDownListWidth = 400
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.Black
        ValueListItem6.DataValue = "ValueListItem0"
        ValueListItem6.DisplayText = "BANCO DE LA NACION"
        ValueListItem7.DataValue = "ValueListItem1"
        ValueListItem7.DisplayText = "BANCO DE CREDITO"
        ValueListItem8.DataValue = "ValueListItem2"
        ValueListItem8.DisplayText = "CAJA PIURA"
        Me.cboBanco.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7, ValueListItem8})
        Me.cboBanco.Location = New System.Drawing.Point(240, 22)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(257, 22)
        Me.cboBanco.TabIndex = 13
        Me.cboBanco.ValueMember = "Id"
        '
        'txtNroContrato
        '
        Me.txtNroContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroContrato.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroContrato.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroContrato.Location = New System.Drawing.Point(92, 22)
        Me.txtNroContrato.MaxLength = 50
        Me.txtNroContrato.Name = "txtNroContrato"
        Me.txtNroContrato.Size = New System.Drawing.Size(95, 22)
        Me.txtNroContrato.TabIndex = 30
        '
        'Etiqueta21
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance43
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(13, 24)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(82, 15)
        Me.Etiqueta21.TabIndex = 64
        Me.Etiqueta21.Text = "Nro Contrato:"
        '
        'Etiqueta18
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance44
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(504, 23)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(77, 15)
        Me.Etiqueta18.TabIndex = 11
        Me.Etiqueta18.Text = "Fecha Inicio:"
        '
        'Etiqueta11
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance45
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(194, 23)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Banco:"
        '
        'Agrupacion2
        '
        Appearance46.BackColor = System.Drawing.Color.Black
        Me.Agrupacion2.Appearance = Appearance46
        Me.Agrupacion2.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.RectangularDoubleSolid
        Me.Agrupacion2.Controls.Add(Me.decComision)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion2.Controls.Add(Me.txtNroVencimiento)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.decMontoCuota)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion2.Controls.Add(Me.decTotalCuota)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Controls.Add(Me.decIGV)
        Me.Agrupacion2.Controls.Add(Me.DecMontoInteres)
        Me.Agrupacion2.Controls.Add(Me.lblTotalCuota)
        Me.Agrupacion2.Controls.Add(Me.DecMontoAmortizacion)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion2.Controls.Add(Me.FecVencimiento)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.btnAgregar)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion2.Controls.Add(Me.decPortes)
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(11, 101)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(818, 105)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Agregar Cuota :"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decComision
        '
        Appearance47.ForeColor = System.Drawing.Color.Black
        Me.decComision.Appearance = Appearance47
        Me.decComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decComision.ForeColor = System.Drawing.Color.Black
        Me.decComision.Location = New System.Drawing.Point(405, 75)
        Me.decComision.MaskInput = "{double:4.2}"
        Me.decComision.Name = "decComision"
        Me.decComision.NullText = "0.00"
        Me.decComision.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decComision.Size = New System.Drawing.Size(81, 21)
        Me.decComision.TabIndex = 85
        '
        'Etiqueta15
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.FontData.BoldAsString = "True"
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance48
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(405, 61)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta15.TabIndex = 84
        Me.Etiqueta15.Text = "Comision:"
        '
        'txtNroVencimiento
        '
        Me.txtNroVencimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroVencimiento.Location = New System.Drawing.Point(72, 23)
        Me.txtNroVencimiento.MaxLength = 50
        Me.txtNroVencimiento.Name = "txtNroVencimiento"
        Me.txtNroVencimiento.Size = New System.Drawing.Size(95, 21)
        Me.txtNroVencimiento.TabIndex = 82
        '
        'Etiqueta8
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance49
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(5, 28)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta8.TabIndex = 83
        Me.Etiqueta8.Text = "Nro Cuota:"
        '
        'decMontoCuota
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.decMontoCuota.Appearance = Appearance50
        Me.decMontoCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoCuota.ForeColor = System.Drawing.Color.Black
        Me.decMontoCuota.Location = New System.Drawing.Point(195, 75)
        Me.decMontoCuota.Name = "decMontoCuota"
        Me.decMontoCuota.NullText = "0.00"
        Me.decMontoCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoCuota.ReadOnly = True
        Me.decMontoCuota.Size = New System.Drawing.Size(85, 21)
        Me.decMontoCuota.TabIndex = 68
        '
        'Etiqueta6
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.FontData.BoldAsString = "True"
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance51
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(504, 61)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(28, 14)
        Me.Etiqueta6.TabIndex = 80
        Me.Etiqueta6.Text = "IGV:"
        '
        'Etiqueta7
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance52
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(195, 59)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta7.TabIndex = 67
        Me.Etiqueta7.Text = "Neto Cuota:"
        '
        'decTotalCuota
        '
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.decTotalCuota.Appearance = Appearance53
        Me.decTotalCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalCuota.ForeColor = System.Drawing.Color.Black
        Me.decTotalCuota.Location = New System.Drawing.Point(648, 75)
        Me.decTotalCuota.Name = "decTotalCuota"
        Me.decTotalCuota.NullText = "0.00"
        Me.decTotalCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalCuota.ReadOnly = True
        Me.decTotalCuota.Size = New System.Drawing.Size(85, 21)
        Me.decTotalCuota.TabIndex = 78
        '
        'Etiqueta22
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance54
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(22, 80)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta22.TabIndex = 66
        Me.Etiqueta22.Text = "Interes:"
        '
        'decIGV
        '
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.decIGV.Appearance = Appearance55
        Me.decIGV.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decIGV.ForeColor = System.Drawing.Color.Black
        Me.decIGV.Location = New System.Drawing.Point(504, 75)
        Me.decIGV.Name = "decIGV"
        Me.decIGV.NullText = "0.00"
        Me.decIGV.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decIGV.ReadOnly = True
        Me.decIGV.Size = New System.Drawing.Size(85, 21)
        Me.decIGV.TabIndex = 79
        '
        'DecMontoInteres
        '
        Appearance56.ForeColor = System.Drawing.Color.Black
        Me.DecMontoInteres.Appearance = Appearance56
        Me.DecMontoInteres.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoInteres.ForeColor = System.Drawing.Color.Black
        Me.DecMontoInteres.Location = New System.Drawing.Point(72, 75)
        Me.DecMontoInteres.Name = "DecMontoInteres"
        Me.DecMontoInteres.NullText = "0.00"
        Me.DecMontoInteres.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoInteres.Size = New System.Drawing.Size(95, 21)
        Me.DecMontoInteres.TabIndex = 34
        '
        'lblTotalCuota
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.FontData.BoldAsString = "True"
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.lblTotalCuota.Appearance = Appearance57
        Me.lblTotalCuota.AutoSize = True
        Me.lblTotalCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCuota.ForeColor = System.Drawing.Color.Black
        Me.lblTotalCuota.Location = New System.Drawing.Point(606, 80)
        Me.lblTotalCuota.Name = "lblTotalCuota"
        Me.lblTotalCuota.Size = New System.Drawing.Size(34, 14)
        Me.lblTotalCuota.TabIndex = 75
        Me.lblTotalCuota.Text = "Total:"
        '
        'DecMontoAmortizacion
        '
        Appearance58.ForeColor = System.Drawing.Color.Black
        Me.DecMontoAmortizacion.Appearance = Appearance58
        Me.DecMontoAmortizacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoAmortizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoAmortizacion.ForeColor = System.Drawing.Color.Black
        Me.DecMontoAmortizacion.Location = New System.Drawing.Point(72, 49)
        Me.DecMontoAmortizacion.Name = "DecMontoAmortizacion"
        Me.DecMontoAmortizacion.NullText = "0.00"
        Me.DecMontoAmortizacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoAmortizacion.Size = New System.Drawing.Size(95, 21)
        Me.DecMontoAmortizacion.TabIndex = 31
        '
        'Etiqueta19
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance59
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(7, 54)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta19.TabIndex = 62
        Me.Etiqueta19.Text = "A. Capital:"
        '
        'FecVencimiento
        '
        Appearance60.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Appearance = Appearance60
        Me.FecVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Location = New System.Drawing.Point(287, 23)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.Size = New System.Drawing.Size(95, 21)
        Me.FecVencimiento.TabIndex = 32
        '
        'Etiqueta1
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.FontData.BoldAsString = "True"
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance61
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(304, 60)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta1.TabIndex = 77
        Me.Etiqueta1.Text = "Portes:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAgregar.Location = New System.Drawing.Point(739, 73)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(28, 25)
        Me.btnAgregar.TabIndex = 37
        Me.btnAgregar.Text = "+"
        '
        'Etiqueta20
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance62
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(195, 27)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(86, 14)
        Me.Etiqueta20.TabIndex = 59
        Me.Etiqueta20.Text = "F. Vencimiento:"
        '
        'decPortes
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.decPortes.Appearance = Appearance63
        Me.decPortes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPortes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPortes.ForeColor = System.Drawing.Color.Black
        Me.decPortes.Location = New System.Drawing.Point(304, 75)
        Me.decPortes.MaskInput = "{double:4.2}"
        Me.decPortes.Name = "decPortes"
        Me.decPortes.NullText = "0.00"
        Me.decPortes.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPortes.Size = New System.Drawing.Size(78, 21)
        Me.decPortes.TabIndex = 76
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "")
        Me.imagenes.Images.SetKeyName(1, "")
        Me.imagenes.Images.SetKeyName(2, "")
        Me.imagenes.Images.SetKeyName(3, "")
        Me.imagenes.Images.SetKeyName(4, "")
        Me.imagenes.Images.SetKeyName(5, "")
        Me.imagenes.Images.SetKeyName(6, "")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        '
        'tcLeasing
        '
        Me.tcLeasing.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcLeasing.Controls.Add(Me.UltraTabPageControl2)
        Me.tcLeasing.Controls.Add(Me.UltraTabPageControl1)
        Me.tcLeasing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcLeasing.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcLeasing.Location = New System.Drawing.Point(0, 0)
        Me.tcLeasing.Name = "tcLeasing"
        Me.tcLeasing.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcLeasing.Size = New System.Drawing.Size(1142, 506)
        Me.tcLeasing.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listado"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcLeasing.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcLeasing.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1140, 483)
        '
        'frm_Leasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 506)
        Me.Controls.Add(Me.tcLeasing)
        Me.Name = "frm_Leasing"
        Me.Text = "Leasing"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_Leasing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odContratosLeasing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.grid_Cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnAgregadosLeasing.ResumeLayout(False)
        CType(Me.odCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        Me.Agrupacion12.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.decMontoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTasaMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTasaInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.decComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decIGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoInteres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoAmortizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPortes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcLeasing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcLeasing.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odContratosLeasing As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odCuotas As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents mnAgregadosLeasing As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_Leasing As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_Cuotas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents lblTotalCuota As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decTasaInteres As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents DecMontoInteres As ISL.Controles.NumeroDecimal
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtNroContrato As ISL.Controles.Texto
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents DecMontoAmortizacion As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents FecVencimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents txt_Glosa As ISL.Controles.Texto
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents fecEmision As ISL.Controles.Fecha
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tcLeasing As ISL.Controles.Ficha
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents decPortes As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents decTasaMensual As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents decIGV As ISL.Controles.NumeroDecimal
    Friend WithEvents decTotalCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroVencimiento As ISL.Controles.Texto
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents btnGenerar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents decMontoInicial As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents decComision As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Espere1 As ISL.Win.Espere
End Class
