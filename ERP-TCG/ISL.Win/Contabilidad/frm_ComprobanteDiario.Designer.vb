<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ComprobanteDiario
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsiento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeMN")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberMN")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DebeME")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HaberME")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLinea")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentroCosto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdItemGasto")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdRuta")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdBanco")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis1")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAnalisis2")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vehiculo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGastoFuncion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoAsiento")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ComprobanteDiario))
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuenta")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Naturaleza")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Movimiento")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCuentaCorriente")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocGeneral")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Conciliacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MonedaExtrangera")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocumento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Analisis01")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Analisis02")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CentroCosto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GastoFuncion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoAsiento")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsiento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaImprime")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDebe")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalHaber")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioBloquea")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoExtorno")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoAsiento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaImprime")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDebe")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalHaber")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioBloquea")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoExtorno")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Movimiento", 0)
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsiento")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeMN")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberMN")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DebeME")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HaberME")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("TotalDebeMN", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeMN", 4, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeMN", 4, True)
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings2 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("TotalHaberMN", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberMN", 5, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberMN", 5, True)
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings3 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("TotalDebeME", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "DebeME", 6, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "DebeME", 6, True)
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim SummarySettings4 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("TotalHaberME", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "HaberME", 7, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "HaberME", 7, True)
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentroCosto")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdItemGasto")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRuta")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdBanco")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis1")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAnalisis2")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdGastoFuncion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAsiento")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsiento")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim SummarySettings5 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Monto", 11, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Monto", 11, True)
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuenta")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Naturaleza")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Movimiento")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCuentaCorriente")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocGeneral")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Conciliacion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MonedaExtrangera")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Analisis01")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Analisis02")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CentroCosto")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GastoFuncion")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim ButtonTool11 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Exportar")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Modificar")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.MenuDetalleDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarDetalleDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.odAnalisis = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraDataSource4 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuCabecera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaCabecera = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuplicarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtornarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcComprobanteDiario = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_ComprobanteDiario = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoAsiento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.tcAsientoDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_AsientoDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DecHMN = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecDMN = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DecHME = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecDME = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.tp_Mant = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tp_Mant_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.btnBuscarDoc = New ISL.Controles.Boton(Me.components)
        Me.grid_DetalleAsientoAnalisis = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecMontoAn = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboGastonFuncion = New ISL.Controles.Combo(Me.components)
        Me.ChkVehiculoProper = New System.Windows.Forms.CheckBox()
        Me.cmbAgregarAnalisis = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAnalisis2 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAnalisis1 = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRuta = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboVehiculo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboItemGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentroCosto = New ISL.Controles.Combo(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNombreCta = New ISL.Controles.Texto(Me.components)
        Me.tabDocumentoDetalle = New System.Windows.Forms.TabControl()
        Me.Doct = New System.Windows.Forms.TabPage()
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbTipoDoc = New ISL.Controles.Combo(Me.components)
        Me.cboCtaCte = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroSerie = New ISL.Controles.Texto(Me.components)
        Me.FecVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDoc = New ISL.Controles.Texto(Me.components)
        Me.FecEmision = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Obli = New System.Windows.Forms.TabPage()
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboBancoObligacion = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoObligacion = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecVencimientoObligacion = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigoUnico = New ISL.Controles.Texto(Me.components)
        Me.fecEmisionObligacion = New ISL.Controles.Fecha(Me.components)
        Me.cboCuenta = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.FecCajaBanco = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumeroCajaBanco = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocCajaBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCtaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecDebe = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txt_GlosaDetalle = New ISL.Controles.Texto(Me.components)
        Me.DecHaber = New ISL.Controles.NumeroDecimal(Me.components)
        Me._tp_Mant_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnuDetalleAsiento = New ISL.Controles.Menu(Me.components)
        Me._tp_Mant_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._tp_Mant_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._tp_Mant_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrCabeceraAsiento = New ISL.Controles.Agrupacion(Me.components)
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoAsiento = New ISL.Controles.Combo(Me.components)
        Me.cmbPeriodo = New ISL.Controles.Combo(Me.components)
        Me.FecAsiento = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecHaberAsiento = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecDebeAsiento = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalleDetalle.SuspendLayout()
        CType(Me.odAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCabecera.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcComprobanteDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteDiario.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_ComprobanteDiario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.tcAsientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAsientoDetalle.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.grid_AsientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DecHMN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDMN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DecHME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDME, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_Mant.SuspendLayout()
        Me.tp_Mant_Fill_Panel.ClientArea.SuspendLayout()
        Me.tp_Mant_Fill_Panel.SuspendLayout()
        CType(Me.grid_DetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.DecMontoAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnalisis2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAnalisis1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.txtNombreCta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocumentoDetalle.SuspendLayout()
        Me.Doct.SuspendLayout()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaCte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Obli.SuspendLayout()
        CType(Me.cboBancoObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecVencimientoObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoUnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecEmisionObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.txtNumeroCajaBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocCajaBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDebe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GlosaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecHaber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrCabeceraAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrCabeceraAsiento.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecHaberAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDebeAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDetalle, Me.EditarDetalle, Me.EliminarDetalle, Me.ExportarToolStripMenuItem})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(130, 108)
        '
        'AgregarDetalle
        '
        Me.AgregarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarDetalle.Name = "AgregarDetalle"
        Me.AgregarDetalle.Size = New System.Drawing.Size(129, 26)
        Me.AgregarDetalle.Text = "Agregar"
        '
        'EditarDetalle
        '
        Me.EditarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarDetalle.Name = "EditarDetalle"
        Me.EditarDetalle.Size = New System.Drawing.Size(129, 26)
        Me.EditarDetalle.Text = "Modificar"
        '
        'EliminarDetalle
        '
        Me.EliminarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarDetalle.Name = "EliminarDetalle"
        Me.EliminarDetalle.Size = New System.Drawing.Size(129, 26)
        Me.EliminarDetalle.Text = "Eliminar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'UltraDataSource3
        '
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Double)
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'MenuDetalleDetalle
        '
        Me.MenuDetalleDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalleDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarDetalleDetalle})
        Me.MenuDetalleDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalleDetalle.Size = New System.Drawing.Size(122, 30)
        '
        'EliminarDetalleDetalle
        '
        Me.EliminarDetalleDetalle.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarDetalleDetalle.Name = "EliminarDetalleDetalle"
        Me.EliminarDetalleDetalle.Size = New System.Drawing.Size(121, 26)
        Me.EliminarDetalleDetalle.Text = "Eliminar"
        '
        'odAnalisis
        '
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn24.DefaultValue = 0.0R
        Me.odAnalisis.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39})
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
        'UltraDataSource4
        '
        Me.UltraDataSource4.Band.Columns.AddRange(New Object() {UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64})
        '
        'MenuCabecera
        '
        Me.MenuCabecera.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuCabecera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarCabecera, Me.EditarCabecera, Me.EliminaCabecera, Me.DuplicarToolStripMenuItem, Me.ExtornarToolStripMenuItem})
        Me.MenuCabecera.Name = "mnu_Transferencias"
        Me.MenuCabecera.Size = New System.Drawing.Size(123, 134)
        '
        'AgregarCabecera
        '
        Me.AgregarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarCabecera.Name = "AgregarCabecera"
        Me.AgregarCabecera.Size = New System.Drawing.Size(122, 26)
        Me.AgregarCabecera.Text = "Nuevo"
        '
        'EditarCabecera
        '
        Me.EditarCabecera.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarCabecera.Name = "EditarCabecera"
        Me.EditarCabecera.Size = New System.Drawing.Size(122, 26)
        Me.EditarCabecera.Text = "Editar"
        '
        'EliminaCabecera
        '
        Me.EliminaCabecera.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminaCabecera.Name = "EliminaCabecera"
        Me.EliminaCabecera.Size = New System.Drawing.Size(122, 26)
        Me.EliminaCabecera.Text = "Eliminar"
        '
        'DuplicarToolStripMenuItem
        '
        Me.DuplicarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.DuplicarToolStripMenuItem.Name = "DuplicarToolStripMenuItem"
        Me.DuplicarToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.DuplicarToolStripMenuItem.Text = "Duplicar"
        '
        'ExtornarToolStripMenuItem
        '
        Me.ExtornarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.ExtornarToolStripMenuItem.Name = "ExtornarToolStripMenuItem"
        Me.ExtornarToolStripMenuItem.Size = New System.Drawing.Size(122, 26)
        Me.ExtornarToolStripMenuItem.Text = "Extornar"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81})
        '
        'tcComprobanteDiario
        '
        Me.tcComprobanteDiario.Controls.Add(Me.UltraTabPageControl1)
        Me.tcComprobanteDiario.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcComprobanteDiario.Controls.Add(Me.UltraTabPageControl2)
        Me.tcComprobanteDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcComprobanteDiario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteDiario.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteDiario.Name = "tcComprobanteDiario"
        Me.tcComprobanteDiario.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcComprobanteDiario.Size = New System.Drawing.Size(1205, 599)
        Me.tcComprobanteDiario.TabIndex = 3
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcComprobanteDiario.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcComprobanteDiario.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_ComprobanteDiario)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1203, 576)
        '
        'grid_ComprobanteDiario
        '
        Me.grid_ComprobanteDiario.ContextMenuStrip = Me.MenuCabecera
        Me.grid_ComprobanteDiario.DataSource = Me.UltraDataSource1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.Caption = "Periodo"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 61
        UltraGridColumn3.Header.Caption = "Tipo Asiento"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 78
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 85
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 81
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 343
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn8.CellAppearance = Appearance1
        UltraGridColumn8.Header.Caption = "Mon."
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Width = 40
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance2
        UltraGridColumn9.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn9.Format = "#,##0.000"
        UltraGridColumn9.Header.Caption = "T.C"
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Width = 72
        UltraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance3
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn10.Width = 95
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance4
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 12
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn11.Width = 98
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Usuario"
        UltraGridColumn13.Header.VisiblePosition = 14
        UltraGridColumn13.Width = 197
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 16
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 17
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 7
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.Width = 92
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.grid_ComprobanteDiario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_ComprobanteDiario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ComprobanteDiario.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ComprobanteDiario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ComprobanteDiario.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_ComprobanteDiario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ComprobanteDiario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ComprobanteDiario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_ComprobanteDiario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_ComprobanteDiario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_ComprobanteDiario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ComprobanteDiario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_ComprobanteDiario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_ComprobanteDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ComprobanteDiario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ComprobanteDiario.Location = New System.Drawing.Point(0, 55)
        Me.grid_ComprobanteDiario.Name = "grid_ComprobanteDiario"
        Me.grid_ComprobanteDiario.Size = New System.Drawing.Size(1203, 521)
        Me.grid_ComprobanteDiario.TabIndex = 3
        Me.grid_ComprobanteDiario.Text = "Comprobante Diario"
        '
        'Agrupacion1
        '
        Appearance5.BackColor = System.Drawing.Color.White
        Appearance5.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance5
        Me.Agrupacion1.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion1.Controls.Add(Me.cboTipoAsiento)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1203, 55)
        Me.Agrupacion1.TabIndex = 4
        Me.Agrupacion1.Text = "Busqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta8
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance6
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(329, 28)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta8.TabIndex = 8
        Me.Etiqueta8.Text = "Tipo Asiento:"
        '
        'cboTipoAsiento
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAsiento.Appearance = Appearance7
        Me.cboTipoAsiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoAsiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoAsiento.Location = New System.Drawing.Point(408, 24)
        Me.cboTipoAsiento.Name = "cboTipoAsiento"
        Me.cboTipoAsiento.Size = New System.Drawing.Size(183, 22)
        Me.cboTipoAsiento.TabIndex = 7
        Me.cboTipoAsiento.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance8
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(141, 28)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMes
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance9
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(177, 24)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(135, 22)
        Me.cboMes.TabIndex = 5
        Me.cboMes.ValueMember = "Id"
        '
        'Año1
        '
        Me.Año1.Año = 2017
        Me.Año1.Location = New System.Drawing.Point(67, 24)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 4
        '
        'Etiqueta2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance10
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1203, 576)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl2.Controls.Add(Me.agrCabeceraAsiento)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1203, 576)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.tcAsientoDetalle)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 99)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1203, 477)
        Me.Agrupacion3.TabIndex = 33
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'tcAsientoDetalle
        '
        Me.tcAsientoDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcAsientoDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.tcAsientoDetalle.Controls.Add(Me.tp_Mant)
        Me.tcAsientoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcAsientoDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcAsientoDetalle.Location = New System.Drawing.Point(2, 2)
        Me.tcAsientoDetalle.Name = "tcAsientoDetalle"
        Me.tcAsientoDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcAsientoDetalle.Size = New System.Drawing.Size(1199, 473)
        Me.tcAsientoDetalle.TabIndex = 30
        UltraTab3.Key = "Tab1"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Detalle"
        UltraTab4.Key = "Tab2"
        UltraTab4.TabPage = Me.tp_Mant
        UltraTab4.Text = "Mantenimiento"
        Me.tcAsientoDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.tcAsientoDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1197, 450)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.grid_AsientoDetalle)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion11)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1197, 450)
        '
        'grid_AsientoDetalle
        '
        Me.grid_AsientoDetalle.ContextMenuStrip = Me.MenuDetalle
        Me.grid_AsientoDetalle.DataSource = Me.UltraDataSource3
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "Cuenta"
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Width = 74
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Width = 424
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance11
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Format = "#,##0.00"
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance12
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Format = "#,##0.00"
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance13
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Format = "#,##0.00"
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance14
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Format = "#,##0.00"
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn27.Header.Caption = "Usuario"
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn27.Width = 178
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.Hidden = True
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn30.CellAppearance = Appearance15
        UltraGridColumn30.Header.Caption = "N° Linea"
        UltraGridColumn30.Header.VisiblePosition = 2
        UltraGridColumn30.Width = 63
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        Appearance16.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance16
        SummarySettings1.DisplayFormat = "{0:#,##0.00}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Right"
        SummarySettings2.Appearance = Appearance18
        SummarySettings2.DisplayFormat = "{0:#,##0.00}"
        SummarySettings2.GroupBySummaryValueAppearance = Appearance19
        Appearance20.TextHAlignAsString = "Right"
        SummarySettings3.Appearance = Appearance20
        SummarySettings3.DisplayFormat = "{0:#,##0.00}"
        SummarySettings3.GroupBySummaryValueAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Right"
        SummarySettings4.Appearance = Appearance22
        SummarySettings4.DisplayFormat = "{0:#,##0.00}"
        SummarySettings4.GroupBySummaryValueAppearance = Appearance23
        UltraGridBand2.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1, SummarySettings2, SummarySettings3, SummarySettings4})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.grid_AsientoDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_AsientoDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_AsientoDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_AsientoDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_AsientoDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_AsientoDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_AsientoDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_AsientoDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_AsientoDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_AsientoDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_AsientoDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_AsientoDetalle.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_AsientoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_AsientoDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_AsientoDetalle.Location = New System.Drawing.Point(0, 0)
        Me.grid_AsientoDetalle.Name = "grid_AsientoDetalle"
        Me.grid_AsientoDetalle.Size = New System.Drawing.Size(1197, 398)
        Me.grid_AsientoDetalle.TabIndex = 25
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.GroupBox2)
        Me.Agrupacion11.Controls.Add(Me.GroupBox1)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 398)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(1197, 52)
        Me.Agrupacion11.TabIndex = 26
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DecHMN)
        Me.GroupBox2.Controls.Add(Me.Etiqueta33)
        Me.GroupBox2.Controls.Add(Me.DecDMN)
        Me.GroupBox2.Controls.Add(Me.Etiqueta34)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(582, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 40)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales MN:"
        '
        'DecHMN
        '
        Appearance24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHMN.Appearance = Appearance24
        Me.DecHMN.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecHMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecHMN.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHMN.Location = New System.Drawing.Point(121, 14)
        Me.DecHMN.Name = "DecHMN"
        Me.DecHMN.NullText = "0.00"
        Me.DecHMN.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecHMN.ReadOnly = True
        Me.DecHMN.Size = New System.Drawing.Size(79, 21)
        Me.DecHMN.TabIndex = 27
        '
        'Etiqueta33
        '
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta33.Location = New System.Drawing.Point(10, 18)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(15, 14)
        Me.Etiqueta33.TabIndex = 0
        Me.Etiqueta33.Text = "D:"
        '
        'DecDMN
        '
        Appearance25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDMN.Appearance = Appearance25
        Me.DecDMN.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDMN.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDMN.Location = New System.Drawing.Point(25, 14)
        Me.DecDMN.Name = "DecDMN"
        Me.DecDMN.NullText = "0.00"
        Me.DecDMN.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDMN.ReadOnly = True
        Me.DecDMN.Size = New System.Drawing.Size(79, 21)
        Me.DecDMN.TabIndex = 26
        '
        'Etiqueta34
        '
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(107, 18)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(15, 14)
        Me.Etiqueta34.TabIndex = 1
        Me.Etiqueta34.Text = "H:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DecHME)
        Me.GroupBox1.Controls.Add(Me.DecDME)
        Me.GroupBox1.Controls.Add(Me.Etiqueta35)
        Me.GroupBox1.Controls.Add(Me.Etiqueta36)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(792, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 40)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales ME:"
        '
        'DecHME
        '
        Appearance26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHME.Appearance = Appearance26
        Me.DecHME.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecHME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecHME.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHME.Location = New System.Drawing.Point(120, 15)
        Me.DecHME.Name = "DecHME"
        Me.DecHME.NullText = "0.00"
        Me.DecHME.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecHME.ReadOnly = True
        Me.DecHME.Size = New System.Drawing.Size(79, 21)
        Me.DecHME.TabIndex = 29
        '
        'DecDME
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDME.Appearance = Appearance27
        Me.DecDME.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDME.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDME.Location = New System.Drawing.Point(24, 15)
        Me.DecDME.Name = "DecDME"
        Me.DecDME.NullText = "0.00"
        Me.DecDME.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDME.ReadOnly = True
        Me.DecDME.Size = New System.Drawing.Size(78, 21)
        Me.DecDME.TabIndex = 28
        '
        'Etiqueta35
        '
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(105, 18)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(15, 14)
        Me.Etiqueta35.TabIndex = 3
        Me.Etiqueta35.Text = "H:"
        '
        'Etiqueta36
        '
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(9, 19)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(15, 14)
        Me.Etiqueta36.TabIndex = 2
        Me.Etiqueta36.Text = "D:"
        '
        'tp_Mant
        '
        Me.tp_Mant.Controls.Add(Me.tp_Mant_Fill_Panel)
        Me.tp_Mant.Location = New System.Drawing.Point(1, 22)
        Me.tp_Mant.Name = "tp_Mant"
        Me.tp_Mant.Size = New System.Drawing.Size(1197, 450)
        '
        'tp_Mant_Fill_Panel
        '
        '
        'tp_Mant_Fill_Panel.ClientArea
        '
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me.btnBuscarDoc)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me.grid_DetalleAsientoAnalisis)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me.Agrupacion2)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me.Agrupacion4)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me._tp_Mant_Toolbars_Dock_Area_Top)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me._tp_Mant_Toolbars_Dock_Area_Bottom)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me._tp_Mant_Toolbars_Dock_Area_Left)
        Me.tp_Mant_Fill_Panel.ClientArea.Controls.Add(Me._tp_Mant_Toolbars_Dock_Area_Right)
        Me.tp_Mant_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.tp_Mant_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tp_Mant_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.tp_Mant_Fill_Panel.Name = "tp_Mant_Fill_Panel"
        Me.tp_Mant_Fill_Panel.Size = New System.Drawing.Size(1197, 450)
        Me.tp_Mant_Fill_Panel.TabIndex = 0
        '
        'btnBuscarDoc
        '
        Me.btnBuscarDoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarDoc.Enabled = False
        Me.btnBuscarDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarDoc.Location = New System.Drawing.Point(864, 31)
        Me.btnBuscarDoc.Name = "btnBuscarDoc"
        Me.btnBuscarDoc.Size = New System.Drawing.Size(27, 19)
        Me.btnBuscarDoc.TabIndex = 290
        Me.btnBuscarDoc.Text = "..."
        '
        'grid_DetalleAsientoAnalisis
        '
        Me.grid_DetalleAsientoAnalisis.ContextMenuStrip = Me.MenuDetalleDetalle
        Me.grid_DetalleAsientoAnalisis.DataSource = Me.odAnalisis
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn32.Header.Caption = "Centro Costo"
        UltraGridColumn32.Header.VisiblePosition = 3
        UltraGridColumn32.Width = 152
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn33.Header.Caption = "Item Gasto"
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.Width = 190
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn34.Header.Caption = "Trabajador"
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Width = 178
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn35.Header.Caption = "Vehiculo"
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.Width = 79
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn36.Header.Caption = "Ruta"
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.Width = 151
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.Caption = "Banco"
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Width = 155
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn38.Header.Caption = "Analisis1"
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.Width = 80
        UltraGridColumn39.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn39.Header.Caption = "Analisis2"
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Width = 82
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 11
        UltraGridColumn41.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance28
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn42.Format = "#,##0.00"
        UltraGridColumn42.Header.VisiblePosition = 12
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn43.Header.VisiblePosition = 13
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 14
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 15
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn46.Header.VisiblePosition = 16
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.Header.VisiblePosition = 17
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn48.Header.VisiblePosition = 18
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 19
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 20
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn51.Header.Caption = "Gasto Funcion"
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridColumn52.Header.VisiblePosition = 21
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 22
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 23
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 24
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 25
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 26
        UltraGridColumn57.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57})
        Appearance29.TextHAlignAsString = "Right"
        SummarySettings5.Appearance = Appearance29
        SummarySettings5.DisplayFormat = "{0:#,##0.00}"
        SummarySettings5.GroupBySummaryValueAppearance = Appearance30
        SummarySettings5.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.TopFixed
        UltraGridBand3.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings5})
        UltraGridBand3.SummaryFooterCaption = "Total Analisis:"
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_DetalleAsientoAnalisis.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_DetalleAsientoAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_DetalleAsientoAnalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_DetalleAsientoAnalisis.Location = New System.Drawing.Point(0, 258)
        Me.grid_DetalleAsientoAnalisis.Name = "grid_DetalleAsientoAnalisis"
        Me.grid_DetalleAsientoAnalisis.Size = New System.Drawing.Size(1197, 192)
        Me.grid_DetalleAsientoAnalisis.TabIndex = 246
        '
        'Agrupacion2
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion2.ContentAreaAppearance = Appearance31
        Me.Agrupacion2.Controls.Add(Me.Etiqueta38)
        Me.Agrupacion2.Controls.Add(Me.DecMontoAn)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta37)
        Me.Agrupacion2.Controls.Add(Me.cboGastonFuncion)
        Me.Agrupacion2.Controls.Add(Me.ChkVehiculoProper)
        Me.Agrupacion2.Controls.Add(Me.cmbAgregarAnalisis)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion2.Controls.Add(Me.cboAnalisis2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion2.Controls.Add(Me.cboAnalisis1)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion2.Controls.Add(Me.cboBanco)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion2.Controls.Add(Me.cboRuta)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion2.Controls.Add(Me.cboVehiculo)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion2.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion2.Controls.Add(Me.cboItemGasto)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion2.Controls.Add(Me.cboCentroCosto)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 162)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1197, 96)
        Me.Agrupacion2.TabIndex = 6
        Me.Agrupacion2.Text = "Analisis"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta38
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta38.Appearance = Appearance32
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta38.Location = New System.Drawing.Point(854, 23)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta38.TabIndex = 289
        Me.Etiqueta38.Text = "Monto:"
        '
        'DecMontoAn
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecMontoAn.Appearance = Appearance33
        Me.DecMontoAn.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoAn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoAn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecMontoAn.Location = New System.Drawing.Point(895, 22)
        Me.DecMontoAn.MaskInput = "{double:8.2}"
        Me.DecMontoAn.Name = "DecMontoAn"
        Me.DecMontoAn.NullText = "0.00"
        Me.DecMontoAn.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoAn.Size = New System.Drawing.Size(103, 22)
        Me.DecMontoAn.TabIndex = 288
        '
        'Etiqueta37
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta37.Appearance = Appearance34
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta37.Location = New System.Drawing.Point(12, 26)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta37.TabIndex = 287
        Me.Etiqueta37.Text = "Distribucion:"
        '
        'cboGastonFuncion
        '
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.Appearance = Appearance35
        Me.cboGastonFuncion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboGastonFuncion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboGastonFuncion.DropDownListWidth = 400
        Me.cboGastonFuncion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboGastonFuncion.Enabled = False
        Me.cboGastonFuncion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGastonFuncion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboGastonFuncion.ImageList = Me.imagenes
        Me.cboGastonFuncion.Location = New System.Drawing.Point(78, 21)
        Me.cboGastonFuncion.Name = "cboGastonFuncion"
        Me.cboGastonFuncion.Size = New System.Drawing.Size(234, 22)
        Me.cboGastonFuncion.TabIndex = 31
        Me.cboGastonFuncion.ValueMember = "Id"
        '
        'ChkVehiculoProper
        '
        Me.ChkVehiculoProper.AutoSize = True
        Me.ChkVehiculoProper.BackColor = System.Drawing.Color.Transparent
        Me.ChkVehiculoProper.Location = New System.Drawing.Point(560, 46)
        Me.ChkVehiculoProper.Name = "ChkVehiculoProper"
        Me.ChkVehiculoProper.Size = New System.Drawing.Size(15, 14)
        Me.ChkVehiculoProper.TabIndex = 242
        Me.ChkVehiculoProper.UseVisualStyleBackColor = False
        '
        'cmbAgregarAnalisis
        '
        Me.cmbAgregarAnalisis.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmbAgregarAnalisis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmbAgregarAnalisis.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgregarAnalisis.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbAgregarAnalisis.Location = New System.Drawing.Point(1004, 19)
        Me.cmbAgregarAnalisis.Name = "cmbAgregarAnalisis"
        Me.cmbAgregarAnalisis.Size = New System.Drawing.Size(59, 26)
        Me.cmbAgregarAnalisis.TabIndex = 33
        Me.cmbAgregarAnalisis.Text = "Agregar"
        '
        'Etiqueta20
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta20.Appearance = Appearance36
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(584, 71)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta20.TabIndex = 241
        Me.Etiqueta20.Text = "Analisis2:"
        '
        'cboAnalisis2
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis2.Appearance = Appearance37
        Me.cboAnalisis2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAnalisis2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAnalisis2.DropDownListWidth = 400
        Me.cboAnalisis2.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAnalisis2.Enabled = False
        Me.cboAnalisis2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis2.ImageList = Me.imagenes
        Me.cboAnalisis2.Location = New System.Drawing.Point(638, 69)
        Me.cboAnalisis2.Name = "cboAnalisis2"
        Me.cboAnalisis2.Size = New System.Drawing.Size(214, 22)
        Me.cboAnalisis2.TabIndex = 59
        Me.cboAnalisis2.ValueMember = "Id"
        '
        'Etiqueta21
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance38
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(584, 47)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta21.TabIndex = 239
        Me.Etiqueta21.Text = "Empresa:"
        '
        'cboAnalisis1
        '
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis1.Appearance = Appearance39
        Me.cboAnalisis1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboAnalisis1.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboAnalisis1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAnalisis1.DropDownListWidth = 400
        Me.cboAnalisis1.Enabled = False
        Me.cboAnalisis1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalisis1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboAnalisis1.ImageList = Me.imagenes
        Me.cboAnalisis1.Location = New System.Drawing.Point(638, 45)
        Me.cboAnalisis1.Name = "cboAnalisis1"
        Me.cboAnalisis1.Size = New System.Drawing.Size(214, 22)
        Me.cboAnalisis1.TabIndex = 58
        Me.cboAnalisis1.ValueMember = "Id"
        '
        'Etiqueta19
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta19.Appearance = Appearance40
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(597, 26)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta19.TabIndex = 237
        Me.Etiqueta19.Text = "Banco:"
        '
        'cboBanco
        '
        Appearance41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Appearance = Appearance41
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownListWidth = 400
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Enabled = False
        Me.cboBanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.ImageList = Me.imagenes
        Me.cboBanco.Location = New System.Drawing.Point(638, 21)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(214, 22)
        Me.cboBanco.TabIndex = 57
        Me.cboBanco.ValueMember = "Id"
        '
        'Etiqueta18
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta18.Appearance = Appearance42
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(348, 71)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta18.TabIndex = 235
        Me.Etiqueta18.Text = "Ruta:"
        '
        'cboRuta
        '
        Appearance43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.Appearance = Appearance43
        Me.cboRuta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRuta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRuta.DropDownListWidth = 400
        Me.cboRuta.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRuta.Enabled = False
        Me.cboRuta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRuta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboRuta.ImageList = Me.imagenes
        Me.cboRuta.Location = New System.Drawing.Point(381, 69)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(194, 22)
        Me.cboRuta.TabIndex = 56
        Me.cboRuta.ValueMember = "Id"
        '
        'Etiqueta17
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta17.Appearance = Appearance44
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(329, 47)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta17.TabIndex = 233
        Me.Etiqueta17.Text = "Vehiculo:"
        '
        'cboVehiculo
        '
        Appearance45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboVehiculo.Appearance = Appearance45
        Me.cboVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboVehiculo.Enabled = False
        Me.cboVehiculo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboVehiculo.ImageList = Me.imagenes
        Me.cboVehiculo.Location = New System.Drawing.Point(381, 45)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(173, 22)
        Me.cboVehiculo.TabIndex = 32
        Me.cboVehiculo.ValueMember = "Id"
        '
        'Etiqueta16
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta16.Appearance = Appearance46
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(318, 26)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta16.TabIndex = 231
        Me.Etiqueta16.Text = "Trabajador:"
        '
        'cboTrabajador
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.Appearance = Appearance47
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.DropDownListWidth = 400
        Me.cboTrabajador.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTrabajador.Enabled = False
        Me.cboTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTrabajador.ImageList = Me.imagenes
        Me.cboTrabajador.Location = New System.Drawing.Point(381, 22)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(194, 22)
        Me.cboTrabajador.TabIndex = 54
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta15
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta15.Appearance = Appearance48
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(16, 47)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta15.TabIndex = 229
        Me.Etiqueta15.Text = "Item Gasto:"
        '
        'cboItemGasto
        '
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.Appearance = Appearance49
        Me.cboItemGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboItemGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboItemGasto.DropDownListWidth = 400
        Me.cboItemGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboItemGasto.Enabled = False
        Me.cboItemGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItemGasto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboItemGasto.ImageList = Me.imagenes
        Me.cboItemGasto.Location = New System.Drawing.Point(78, 45)
        Me.cboItemGasto.Name = "cboItemGasto"
        Me.cboItemGasto.Size = New System.Drawing.Size(234, 22)
        Me.cboItemGasto.TabIndex = 52
        Me.cboItemGasto.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance50
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(5, 71)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(72, 14)
        Me.Etiqueta14.TabIndex = 227
        Me.Etiqueta14.Text = "Centro Costo:"
        '
        'cboCentroCosto
        '
        Appearance51.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroCosto.Appearance = Appearance51
        Me.cboCentroCosto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroCosto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroCosto.DropDownListWidth = 400
        Me.cboCentroCosto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroCosto.Enabled = False
        Me.cboCentroCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroCosto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroCosto.ImageList = Me.imagenes
        Me.cboCentroCosto.Location = New System.Drawing.Point(78, 69)
        Me.cboCentroCosto.Name = "cboCentroCosto"
        Me.cboCentroCosto.Size = New System.Drawing.Size(234, 22)
        Me.cboCentroCosto.TabIndex = 53
        Me.cboCentroCosto.ValueMember = "Id"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.txtNombreCta)
        Me.Agrupacion4.Controls.Add(Me.tabDocumentoDetalle)
        Me.Agrupacion4.Controls.Add(Me.cboCuenta)
        Me.Agrupacion4.Controls.Add(Me.Agrupacion6)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion4.Controls.Add(Me.DecDebe)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion4.Controls.Add(Me.txt_GlosaDetalle)
        Me.Agrupacion4.Controls.Add(Me.DecHaber)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 26)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1197, 136)
        Me.Agrupacion4.TabIndex = 5
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNombreCta
        '
        Appearance52.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombreCta.Appearance = Appearance52
        Me.txtNombreCta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombreCta.Enabled = False
        Me.txtNombreCta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombreCta.Location = New System.Drawing.Point(154, 10)
        Me.txtNombreCta.MaxLength = 300
        Me.txtNombreCta.Name = "txtNombreCta"
        Me.txtNombreCta.Size = New System.Drawing.Size(287, 21)
        Me.txtNombreCta.TabIndex = 231
        '
        'tabDocumentoDetalle
        '
        Me.tabDocumentoDetalle.Controls.Add(Me.Doct)
        Me.tabDocumentoDetalle.Controls.Add(Me.Obli)
        Me.tabDocumentoDetalle.Location = New System.Drawing.Point(590, 5)
        Me.tabDocumentoDetalle.Name = "tabDocumentoDetalle"
        Me.tabDocumentoDetalle.SelectedIndex = 0
        Me.tabDocumentoDetalle.Size = New System.Drawing.Size(303, 128)
        Me.tabDocumentoDetalle.TabIndex = 5
        '
        'Doct
        '
        Me.Doct.Controls.Add(Me.Etiqueta31)
        Me.Doct.Controls.Add(Me.cmbTipoDoc)
        Me.Doct.Controls.Add(Me.cboCtaCte)
        Me.Doct.Controls.Add(Me.Etiqueta26)
        Me.Doct.Controls.Add(Me.Etiqueta30)
        Me.Doct.Controls.Add(Me.txtNroSerie)
        Me.Doct.Controls.Add(Me.FecVencimiento)
        Me.Doct.Controls.Add(Me.Etiqueta27)
        Me.Doct.Controls.Add(Me.Etiqueta29)
        Me.Doct.Controls.Add(Me.txtNroDoc)
        Me.Doct.Controls.Add(Me.FecEmision)
        Me.Doct.Controls.Add(Me.Etiqueta28)
        Me.Doct.Location = New System.Drawing.Point(4, 22)
        Me.Doct.Name = "Doct"
        Me.Doct.Padding = New System.Windows.Forms.Padding(3)
        Me.Doct.Size = New System.Drawing.Size(295, 102)
        Me.Doct.TabIndex = 0
        Me.Doct.Text = "Documento"
        Me.Doct.UseVisualStyleBackColor = True
        '
        'Etiqueta31
        '
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(9, 81)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta31.TabIndex = 259
        Me.Etiqueta31.Text = "Cta Cte:"
        '
        'cmbTipoDoc
        '
        Appearance53.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoDoc.Appearance = Appearance53
        Me.cmbTipoDoc.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbTipoDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDoc.DropDownListWidth = 400
        Me.cmbTipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDoc.Enabled = False
        Me.cmbTipoDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoDoc.ImageList = Me.imagenes
        Me.cmbTipoDoc.Location = New System.Drawing.Point(60, 3)
        Me.cmbTipoDoc.Name = "cmbTipoDoc"
        Me.cmbTipoDoc.ReadOnly = True
        Me.cmbTipoDoc.Size = New System.Drawing.Size(228, 22)
        Me.cmbTipoDoc.TabIndex = 36
        Me.cmbTipoDoc.ValueMember = "Id"
        '
        'cboCtaCte
        '
        Appearance54.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCte.Appearance = Appearance54
        Me.cboCtaCte.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaCte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaCte.DropDownListWidth = 400
        Me.cboCtaCte.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaCte.Enabled = False
        Me.cboCtaCte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaCte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaCte.ImageList = Me.imagenes
        Me.cboCtaCte.Location = New System.Drawing.Point(60, 77)
        Me.cboCtaCte.Name = "cboCtaCte"
        Me.cboCtaCte.ReadOnly = True
        Me.cboCtaCte.Size = New System.Drawing.Size(228, 22)
        Me.cboCtaCte.TabIndex = 50
        Me.cboCtaCte.ValueMember = "Id"
        '
        'Etiqueta26
        '
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(2, 7)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta26.TabIndex = 249
        Me.Etiqueta26.Text = "Tipo Doc:"
        '
        'Etiqueta30
        '
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(140, 55)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta30.TabIndex = 257
        Me.Etiqueta30.Text = "Vencimiento:"
        '
        'txtNroSerie
        '
        Appearance55.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Appearance = Appearance55
        Me.txtNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroSerie.Enabled = False
        Me.txtNroSerie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroSerie.Location = New System.Drawing.Point(60, 27)
        Me.txtNroSerie.MaxLength = 4
        Me.txtNroSerie.Name = "txtNroSerie"
        Me.txtNroSerie.ReadOnly = True
        Me.txtNroSerie.Size = New System.Drawing.Size(68, 22)
        Me.txtNroSerie.TabIndex = 37
        '
        'FecVencimiento
        '
        Appearance56.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecVencimiento.Appearance = Appearance56
        Me.FecVencimiento.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.FecVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimiento.Enabled = False
        Me.FecVencimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecVencimiento.Location = New System.Drawing.Point(209, 51)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.ReadOnly = True
        Me.FecVencimiento.Size = New System.Drawing.Size(79, 22)
        Me.FecVencimiento.TabIndex = 40
        Me.FecVencimiento.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta27
        '
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(21, 31)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta27.TabIndex = 250
        Me.Etiqueta27.Text = "Serie:"
        '
        'Etiqueta29
        '
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(7, 55)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta29.TabIndex = 255
        Me.Etiqueta29.Text = "Emision:"
        '
        'txtNroDoc
        '
        Appearance57.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDoc.Appearance = Appearance57
        Me.txtNroDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDoc.Enabled = False
        Me.txtNroDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDoc.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroDoc.Location = New System.Drawing.Point(180, 27)
        Me.txtNroDoc.MaxLength = 10
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.ReadOnly = True
        Me.txtNroDoc.Size = New System.Drawing.Size(108, 22)
        Me.txtNroDoc.TabIndex = 38
        '
        'FecEmision
        '
        Appearance58.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Appearance = Appearance58
        Me.FecEmision.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.FecEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecEmision.Enabled = False
        Me.FecEmision.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecEmision.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecEmision.Location = New System.Drawing.Point(60, 51)
        Me.FecEmision.Name = "FecEmision"
        Me.FecEmision.ReadOnly = True
        Me.FecEmision.Size = New System.Drawing.Size(77, 22)
        Me.FecEmision.TabIndex = 39
        Me.FecEmision.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta28
        '
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.Location = New System.Drawing.Point(131, 31)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta28.TabIndex = 252
        Me.Etiqueta28.Text = "Numero:"
        '
        'Obli
        '
        Me.Obli.Controls.Add(Me.Etiqueta44)
        Me.Obli.Controls.Add(Me.cboBancoObligacion)
        Me.Obli.Controls.Add(Me.Etiqueta43)
        Me.Obli.Controls.Add(Me.cboTipoObligacion)
        Me.Obli.Controls.Add(Me.Etiqueta40)
        Me.Obli.Controls.Add(Me.Etiqueta41)
        Me.Obli.Controls.Add(Me.fecVencimientoObligacion)
        Me.Obli.Controls.Add(Me.Etiqueta42)
        Me.Obli.Controls.Add(Me.txtCodigoUnico)
        Me.Obli.Controls.Add(Me.fecEmisionObligacion)
        Me.Obli.Location = New System.Drawing.Point(4, 22)
        Me.Obli.Name = "Obli"
        Me.Obli.Padding = New System.Windows.Forms.Padding(3)
        Me.Obli.Size = New System.Drawing.Size(295, 102)
        Me.Obli.TabIndex = 1
        Me.Obli.Text = "Obligacion"
        Me.Obli.UseVisualStyleBackColor = True
        '
        'Etiqueta44
        '
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta44.Location = New System.Drawing.Point(5, 82)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta44.TabIndex = 267
        Me.Etiqueta44.Text = "Banco:"
        '
        'cboBancoObligacion
        '
        Appearance59.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBancoObligacion.Appearance = Appearance59
        Me.cboBancoObligacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBancoObligacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBancoObligacion.DropDownListWidth = 400
        Me.cboBancoObligacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBancoObligacion.Enabled = False
        Me.cboBancoObligacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBancoObligacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBancoObligacion.ImageList = Me.imagenes
        Me.cboBancoObligacion.Location = New System.Drawing.Point(50, 78)
        Me.cboBancoObligacion.Name = "cboBancoObligacion"
        Me.cboBancoObligacion.ReadOnly = True
        Me.cboBancoObligacion.Size = New System.Drawing.Size(238, 22)
        Me.cboBancoObligacion.TabIndex = 266
        Me.cboBancoObligacion.ValueMember = "Id"
        '
        'Etiqueta43
        '
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta43.Location = New System.Drawing.Point(3, 33)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta43.TabIndex = 265
        Me.Etiqueta43.Text = "Codigo:"
        '
        'cboTipoObligacion
        '
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoObligacion.Appearance = Appearance60
        Me.cboTipoObligacion.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoObligacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoObligacion.DropDownListWidth = 400
        Me.cboTipoObligacion.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoObligacion.Enabled = False
        Me.cboTipoObligacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoObligacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoObligacion.ImageList = Me.imagenes
        Me.cboTipoObligacion.Location = New System.Drawing.Point(50, 5)
        Me.cboTipoObligacion.Name = "cboTipoObligacion"
        Me.cboTipoObligacion.ReadOnly = True
        Me.cboTipoObligacion.Size = New System.Drawing.Size(238, 22)
        Me.cboTipoObligacion.TabIndex = 258
        Me.cboTipoObligacion.ValueMember = "Id"
        '
        'Etiqueta40
        '
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta40.Location = New System.Drawing.Point(15, 9)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta40.TabIndex = 262
        Me.Etiqueta40.Text = "Tipo:"
        '
        'Etiqueta41
        '
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta41.Location = New System.Drawing.Point(140, 57)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta41.TabIndex = 264
        Me.Etiqueta41.Text = "Vencimiento:"
        '
        'fecVencimientoObligacion
        '
        Appearance61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecVencimientoObligacion.Appearance = Appearance61
        Me.fecVencimientoObligacion.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.fecVencimientoObligacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecVencimientoObligacion.Enabled = False
        Me.fecVencimientoObligacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecVencimientoObligacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecVencimientoObligacion.Location = New System.Drawing.Point(209, 54)
        Me.fecVencimientoObligacion.Name = "fecVencimientoObligacion"
        Me.fecVencimientoObligacion.ReadOnly = True
        Me.fecVencimientoObligacion.Size = New System.Drawing.Size(79, 22)
        Me.fecVencimientoObligacion.TabIndex = 261
        Me.fecVencimientoObligacion.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'Etiqueta42
        '
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta42.Location = New System.Drawing.Point(3, 58)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta42.TabIndex = 263
        Me.Etiqueta42.Text = "Emision:"
        '
        'txtCodigoUnico
        '
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoUnico.Appearance = Appearance62
        Me.txtCodigoUnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoUnico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoUnico.Enabled = False
        Me.txtCodigoUnico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoUnico.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigoUnico.Location = New System.Drawing.Point(50, 29)
        Me.txtCodigoUnico.MaxLength = 10
        Me.txtCodigoUnico.Name = "txtCodigoUnico"
        Me.txtCodigoUnico.ReadOnly = True
        Me.txtCodigoUnico.Size = New System.Drawing.Size(105, 22)
        Me.txtCodigoUnico.TabIndex = 259
        '
        'fecEmisionObligacion
        '
        Appearance63.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecEmisionObligacion.Appearance = Appearance63
        Me.fecEmisionObligacion.DateTime = New Date(2011, 11, 29, 0, 0, 0, 0)
        Me.fecEmisionObligacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecEmisionObligacion.Enabled = False
        Me.fecEmisionObligacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecEmisionObligacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecEmisionObligacion.Location = New System.Drawing.Point(50, 53)
        Me.fecEmisionObligacion.Name = "fecEmisionObligacion"
        Me.fecEmisionObligacion.ReadOnly = True
        Me.fecEmisionObligacion.Size = New System.Drawing.Size(77, 22)
        Me.fecEmisionObligacion.TabIndex = 260
        Me.fecEmisionObligacion.Value = New Date(2011, 11, 29, 0, 0, 0, 0)
        '
        'cboCuenta
        '
        Me.cboCuenta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuenta.DataSource = Me.UltraDataSource4
        UltraGridColumn58.Header.VisiblePosition = 0
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 1
        UltraGridColumn59.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(86, 0)
        UltraGridColumn60.Header.VisiblePosition = 2
        UltraGridColumn60.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(427, 0)
        UltraGridColumn61.Header.VisiblePosition = 3
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 4
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 5
        UltraGridColumn64.Header.VisiblePosition = 6
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 7
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 8
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 9
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 10
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 11
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 12
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 13
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 14
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 15
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 16
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 17
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 18
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 19
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 20
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 21
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 22
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 23
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 24
        UltraGridColumn82.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82})
        UltraGridBand4.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.cboCuenta.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.cboCuenta.DisplayLayout.MaxColScrollRegions = 1
        Me.cboCuenta.DisplayLayout.MaxRowScrollRegions = 1
        Me.cboCuenta.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboCuenta.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange
        Me.cboCuenta.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cboCuenta.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboCuenta.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboCuenta.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboCuenta.DisplayMember = "Cuenta"
        Me.cboCuenta.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cboCuenta.DropDownWidth = 600
        Me.cboCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuenta.Location = New System.Drawing.Point(56, 9)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(96, 22)
        Me.cboCuenta.TabIndex = 28
        Me.cboCuenta.ValueMember = "Id"
        '
        'Agrupacion6
        '
        Appearance64.BackColor = System.Drawing.Color.White
        Appearance64.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance64
        Me.Agrupacion6.Controls.Add(Me.FecCajaBanco)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta32)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion6.Controls.Add(Me.txtNumeroCajaBanco)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion6.Controls.Add(Me.cboTipoDocCajaBanco)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion6.Controls.Add(Me.cboCtaBancaria)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion6.Controls.Add(Me.cboFlujoCaja)
        Me.Agrupacion6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(7, 60)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(580, 73)
        Me.Agrupacion6.TabIndex = 3
        Me.Agrupacion6.Text = "Caja y Bancos"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'FecCajaBanco
        '
        Me.FecCajaBanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecCajaBanco.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecCajaBanco.Location = New System.Drawing.Point(483, 45)
        Me.FecCajaBanco.Name = "FecCajaBanco"
        Me.FecCajaBanco.Size = New System.Drawing.Size(92, 21)
        Me.FecCajaBanco.TabIndex = 287
        '
        'Etiqueta32
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta32.Appearance = Appearance65
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta32.Location = New System.Drawing.Point(439, 48)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta32.TabIndex = 257
        Me.Etiqueta32.Text = "Fecha:"
        '
        'Etiqueta25
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta25.Appearance = Appearance66
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta25.Location = New System.Drawing.Point(311, 49)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta25.TabIndex = 248
        Me.Etiqueta25.Text = "Numero:"
        '
        'txtNumeroCajaBanco
        '
        Appearance67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCajaBanco.Appearance = Appearance67
        Me.txtNumeroCajaBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCajaBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroCajaBanco.Enabled = False
        Me.txtNumeroCajaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCajaBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNumeroCajaBanco.Location = New System.Drawing.Point(359, 45)
        Me.txtNumeroCajaBanco.MaxLength = 20
        Me.txtNumeroCajaBanco.Name = "txtNumeroCajaBanco"
        Me.txtNumeroCajaBanco.Size = New System.Drawing.Size(75, 21)
        Me.txtNumeroCajaBanco.TabIndex = 34
        '
        'Etiqueta24
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta24.Appearance = Appearance68
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.Location = New System.Drawing.Point(306, 25)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta24.TabIndex = 247
        Me.Etiqueta24.Text = "Tipo Doc:"
        '
        'cboTipoDocCajaBanco
        '
        Appearance69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocCajaBanco.Appearance = Appearance69
        Me.cboTipoDocCajaBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocCajaBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocCajaBanco.DropDownListWidth = 400
        Me.cboTipoDocCajaBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocCajaBanco.Enabled = False
        Me.cboTipoDocCajaBanco.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocCajaBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDocCajaBanco.ImageList = Me.imagenes
        Me.cboTipoDocCajaBanco.Location = New System.Drawing.Point(359, 21)
        Me.cboTipoDocCajaBanco.Name = "cboTipoDocCajaBanco"
        Me.cboTipoDocCajaBanco.Size = New System.Drawing.Size(217, 22)
        Me.cboTipoDocCajaBanco.TabIndex = 33
        Me.cboTipoDocCajaBanco.ValueMember = "Id"
        '
        'Etiqueta23
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta23.Appearance = Appearance70
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(1, 48)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta23.TabIndex = 245
        Me.Etiqueta23.Text = "Cta Bancaria:"
        '
        'cboCtaBancaria
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.Appearance = Appearance71
        Me.cboCtaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancaria.DropDownListWidth = 400
        Me.cboCtaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancaria.Enabled = False
        Me.cboCtaBancaria.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancaria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCtaBancaria.ImageList = Me.imagenes
        Me.cboCtaBancaria.Location = New System.Drawing.Point(76, 45)
        Me.cboCtaBancaria.Name = "cboCtaBancaria"
        Me.cboCtaBancaria.Size = New System.Drawing.Size(229, 22)
        Me.cboCtaBancaria.TabIndex = 32
        Me.cboCtaBancaria.ValueMember = "Id"
        '
        'Etiqueta22
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta22.Appearance = Appearance72
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(13, 25)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta22.TabIndex = 243
        Me.Etiqueta22.Text = "Flujo Caja:"
        '
        'cboFlujoCaja
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFlujoCaja.Appearance = Appearance73
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownListWidth = 400
        Me.cboFlujoCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoCaja.Enabled = False
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboFlujoCaja.ImageList = Me.imagenes
        Me.cboFlujoCaja.Location = New System.Drawing.Point(76, 21)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(229, 22)
        Me.cboFlujoCaja.TabIndex = 31
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance74
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(443, 38)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta12.TabIndex = 229
        Me.Etiqueta12.Text = "Haber:"
        '
        'DecDebe
        '
        Appearance75.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDebe.Appearance = Appearance75
        Me.DecDebe.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDebe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDebe.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDebe.Location = New System.Drawing.Point(485, 9)
        Me.DecDebe.Name = "DecDebe"
        Me.DecDebe.NullText = "0.00"
        Me.DecDebe.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDebe.Size = New System.Drawing.Size(100, 21)
        Me.DecDebe.TabIndex = 29
        '
        'Etiqueta13
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance76
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(447, 14)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta13.TabIndex = 228
        Me.Etiqueta13.Text = "Debe:"
        '
        'Etiqueta10
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance77
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(7, 14)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta10.TabIndex = 225
        Me.Etiqueta10.Text = "Cuenta:"
        '
        'Etiqueta11
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance78
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(15, 38)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta11.TabIndex = 223
        Me.Etiqueta11.Text = "Glosa:"
        '
        'txt_GlosaDetalle
        '
        Appearance79.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_GlosaDetalle.Appearance = Appearance79
        Me.txt_GlosaDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GlosaDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_GlosaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GlosaDetalle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_GlosaDetalle.Location = New System.Drawing.Point(56, 35)
        Me.txt_GlosaDetalle.MaxLength = 300
        Me.txt_GlosaDetalle.Name = "txt_GlosaDetalle"
        Me.txt_GlosaDetalle.Size = New System.Drawing.Size(385, 21)
        Me.txt_GlosaDetalle.TabIndex = 28
        '
        'DecHaber
        '
        Appearance80.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHaber.Appearance = Appearance80
        Me.DecHaber.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecHaber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecHaber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHaber.Location = New System.Drawing.Point(485, 34)
        Me.DecHaber.Name = "DecHaber"
        Me.DecHaber.NullText = "0.00"
        Me.DecHaber.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecHaber.Size = New System.Drawing.Size(100, 21)
        Me.DecHaber.TabIndex = 30
        '
        '_tp_Mant_Toolbars_Dock_Area_Top
        '
        Me._tp_Mant_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._tp_Mant_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._tp_Mant_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._tp_Mant_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._tp_Mant_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._tp_Mant_Toolbars_Dock_Area_Top.Name = "_tp_Mant_Toolbars_Dock_Area_Top"
        Me._tp_Mant_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1197, 26)
        Me._tp_Mant_Toolbars_Dock_Area_Top.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'mnuDetalleAsiento
        '
        Appearance81.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mnuDetalleAsiento.Appearance = Appearance81
        Me.mnuDetalleAsiento.DesignerFlags = 1
        Me.mnuDetalleAsiento.DockWithinContainer = Me
        Me.mnuDetalleAsiento.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.mnuDetalleAsiento.MdiMergeable = False
        Me.mnuDetalleAsiento.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        Me.mnuDetalleAsiento.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(516, 281)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(239, 48)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool16, ButtonTool4, ButtonTool5})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.mnuDetalleAsiento.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance82.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance82
        ButtonTool6.SharedPropsInternal.Caption = "Agregar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool7.SharedPropsInternal.Caption = "Editar"
        ButtonTool7.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool8.SharedPropsInternal.Caption = "Eliminar"
        ButtonTool8.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance83.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance83
        ButtonTool9.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool10.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool11.SharedPropsInternal.Caption = "ButtonTool1"
        ButtonTool12.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool13.SharedPropsInternal.Caption = "ButtonTool3"
        ButtonTool14.SharedPropsInternal.Caption = "Consultar"
        ButtonTool14.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance84.Image = CType(resources.GetObject("Appearance84.Image"), Object)
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance84
        ButtonTool15.SharedPropsInternal.Caption = "Exportar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance85.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool17.SharedPropsInternal.AppearancesSmall.Appearance = Appearance85
        ButtonTool17.SharedPropsInternal.Caption = "Modificar"
        ButtonTool17.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnuDetalleAsiento.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool6, ButtonTool7, ButtonTool8, ButtonTool9, ButtonTool10, ButtonTool11, ButtonTool12, ButtonTool13, ButtonTool14, ButtonTool15, ButtonTool17})
        '
        '_tp_Mant_Toolbars_Dock_Area_Bottom
        '
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 450)
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.Name = "_tp_Mant_Toolbars_Dock_Area_Bottom"
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1197, 0)
        Me._tp_Mant_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.mnuDetalleAsiento
        '
        '_tp_Mant_Toolbars_Dock_Area_Left
        '
        Me._tp_Mant_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._tp_Mant_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._tp_Mant_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._tp_Mant_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._tp_Mant_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._tp_Mant_Toolbars_Dock_Area_Left.Name = "_tp_Mant_Toolbars_Dock_Area_Left"
        Me._tp_Mant_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 450)
        Me._tp_Mant_Toolbars_Dock_Area_Left.ToolbarsManager = Me.mnuDetalleAsiento
        '
        '_tp_Mant_Toolbars_Dock_Area_Right
        '
        Me._tp_Mant_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._tp_Mant_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._tp_Mant_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._tp_Mant_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._tp_Mant_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1197, 0)
        Me._tp_Mant_Toolbars_Dock_Area_Right.Name = "_tp_Mant_Toolbars_Dock_Area_Right"
        Me._tp_Mant_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 450)
        Me._tp_Mant_Toolbars_Dock_Area_Right.ToolbarsManager = Me.mnuDetalleAsiento
        '
        'agrCabeceraAsiento
        '
        Appearance86.BackColor = System.Drawing.Color.White
        Appearance86.BackColor2 = System.Drawing.Color.White
        Me.agrCabeceraAsiento.ContentAreaAppearance = Appearance86
        Me.agrCabeceraAsiento.Controls.Add(Me.numAño)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta45)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta39)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta46)
        Me.agrCabeceraAsiento.Controls.Add(Me.Label1)
        Me.agrCabeceraAsiento.Controls.Add(Me.cmbTipoAsiento)
        Me.agrCabeceraAsiento.Controls.Add(Me.cmbPeriodo)
        Me.agrCabeceraAsiento.Controls.Add(Me.FecAsiento)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta9)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta1)
        Me.agrCabeceraAsiento.Controls.Add(Me.DecHaberAsiento)
        Me.agrCabeceraAsiento.Controls.Add(Me.DecDebeAsiento)
        Me.agrCabeceraAsiento.Controls.Add(Me.txtGlosa)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta5)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta4)
        Me.agrCabeceraAsiento.Controls.Add(Me.decTC)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta3)
        Me.agrCabeceraAsiento.Controls.Add(Me.cboMoneda)
        Me.agrCabeceraAsiento.Controls.Add(Me.Etiqueta6)
        Me.agrCabeceraAsiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrCabeceraAsiento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrCabeceraAsiento.ForeColor = System.Drawing.Color.Black
        Me.agrCabeceraAsiento.Location = New System.Drawing.Point(0, 0)
        Me.agrCabeceraAsiento.Name = "agrCabeceraAsiento"
        Me.agrCabeceraAsiento.Size = New System.Drawing.Size(1203, 99)
        Me.agrCabeceraAsiento.TabIndex = 1
        Me.agrCabeceraAsiento.Text = "Nro Asiento:"
        Me.agrCabeceraAsiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'numAño
        '
        Appearance87.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance87
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(63, 25)
        Me.numAño.Margin = New System.Windows.Forms.Padding(207, 73, 207, 73)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2010
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.ReadOnly = True
        Me.numAño.Size = New System.Drawing.Size(98, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2014
        '
        'Etiqueta45
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta45.Appearance = Appearance88
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta45.Location = New System.Drawing.Point(357, 30)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(70, 15)
        Me.Etiqueta45.TabIndex = 296
        Me.Etiqueta45.Text = "Tipo Asiento:"
        '
        'Etiqueta39
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta39.Appearance = Appearance89
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta39.Location = New System.Drawing.Point(4, 30)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta39.TabIndex = 295
        Me.Etiqueta39.Text = "Ejercicio:"
        '
        'Etiqueta46
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta46.Appearance = Appearance90
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta46.Location = New System.Drawing.Point(179, 30)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(28, 15)
        Me.Etiqueta46.TabIndex = 294
        Me.Etiqueta46.Text = "Mes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(440, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 293
        Me.Label1.Text = "Asiento Descuadrado"
        Me.Label1.Visible = False
        '
        'cmbTipoAsiento
        '
        Appearance91.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoAsiento.Appearance = Appearance91
        Me.cmbTipoAsiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbTipoAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoAsiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoAsiento.Location = New System.Drawing.Point(433, 26)
        Me.cmbTipoAsiento.Name = "cmbTipoAsiento"
        Me.cmbTipoAsiento.ReadOnly = True
        Me.cmbTipoAsiento.Size = New System.Drawing.Size(164, 22)
        Me.cmbTipoAsiento.TabIndex = 291
        Me.cmbTipoAsiento.ValueMember = "Id"
        '
        'cmbPeriodo
        '
        Appearance92.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPeriodo.Appearance = Appearance92
        Me.cmbPeriodo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbPeriodo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPeriodo.Location = New System.Drawing.Point(213, 26)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.ReadOnly = True
        Me.cmbPeriodo.Size = New System.Drawing.Size(130, 21)
        Me.cmbPeriodo.TabIndex = 289
        Me.cmbPeriodo.ValueMember = "Id"
        '
        'FecAsiento
        '
        Me.FecAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecAsiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecAsiento.Location = New System.Drawing.Point(63, 49)
        Me.FecAsiento.Name = "FecAsiento"
        Me.FecAsiento.Size = New System.Drawing.Size(98, 21)
        Me.FecAsiento.TabIndex = 286
        '
        'Etiqueta9
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance93
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(705, 55)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(75, 15)
        Me.Etiqueta9.TabIndex = 25
        Me.Etiqueta9.Text = "Total Haber:"
        '
        'Etiqueta1
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance94
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(610, 55)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(70, 15)
        Me.Etiqueta1.TabIndex = 24
        Me.Etiqueta1.Text = "Total Debe:"
        '
        'DecHaberAsiento
        '
        Appearance95.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHaberAsiento.Appearance = Appearance95
        Me.DecHaberAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecHaberAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecHaberAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecHaberAsiento.Location = New System.Drawing.Point(704, 73)
        Me.DecHaberAsiento.Name = "DecHaberAsiento"
        Me.DecHaberAsiento.NullText = "0.00"
        Me.DecHaberAsiento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecHaberAsiento.ReadOnly = True
        Me.DecHaberAsiento.Size = New System.Drawing.Size(89, 22)
        Me.DecHaberAsiento.TabIndex = 15
        '
        'DecDebeAsiento
        '
        Appearance96.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDebeAsiento.Appearance = Appearance96
        Me.DecDebeAsiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDebeAsiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDebeAsiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DecDebeAsiento.Location = New System.Drawing.Point(609, 73)
        Me.DecDebeAsiento.Name = "DecDebeAsiento"
        Me.DecDebeAsiento.NullText = "0.00"
        Me.DecDebeAsiento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDebeAsiento.ReadOnly = True
        Me.DecDebeAsiento.Size = New System.Drawing.Size(89, 22)
        Me.DecDebeAsiento.TabIndex = 14
        '
        'txtGlosa
        '
        Appearance97.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance97
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(213, 73)
        Me.txtGlosa.MaxLength = 300
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(384, 22)
        Me.txtGlosa.TabIndex = 13
        '
        'Etiqueta5
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance98
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(172, 75)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta5.TabIndex = 20
        Me.Etiqueta5.Text = "Glosa:"
        '
        'Etiqueta4
        '
        Appearance99.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance99
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(172, 52)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(71, 15)
        Me.Etiqueta4.TabIndex = 19
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'decTC
        '
        Appearance100.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance100
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(246, 49)
        Me.decTC.MaskInput = "{double:6.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(97, 21)
        Me.decTC.TabIndex = 12
        '
        'Etiqueta3
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance101
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(6, 75)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta3.TabIndex = 16
        Me.Etiqueta3.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance102.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance102
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(63, 73)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda.TabIndex = 11
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance103
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(16, 52)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta6.TabIndex = 14
        Me.Etiqueta6.Text = "Fecha:"
        '
        'frm_ComprobanteDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1205, 599)
        Me.Controls.Add(Me.tcComprobanteDiario)
        Me.Name = "frm_ComprobanteDiario"
        Me.Text = "Comprobante Diario"
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalleDetalle.ResumeLayout(False)
        CType(Me.odAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCabecera.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcComprobanteDiario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteDiario.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_ComprobanteDiario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.tcAsientoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAsientoDetalle.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.grid_AsientoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DecHMN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDMN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DecHME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDME, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_Mant.ResumeLayout(False)
        Me.tp_Mant_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.tp_Mant_Fill_Panel.ResumeLayout(False)
        CType(Me.grid_DetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.DecMontoAn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGastonFuncion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnalisis2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAnalisis1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboItemGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.txtNombreCta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocumentoDetalle.ResumeLayout(False)
        Me.Doct.ResumeLayout(False)
        Me.Doct.PerformLayout()
        CType(Me.cmbTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaCte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecEmision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Obli.ResumeLayout(False)
        Me.Obli.PerformLayout()
        CType(Me.cboBancoObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecVencimientoObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoUnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecEmisionObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.txtNumeroCajaBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocCajaBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDebe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GlosaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecHaber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mnuDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrCabeceraAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrCabeceraAsiento.ResumeLayout(False)
        Me.agrCabeceraAsiento.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecHaberAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDebeAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcComprobanteDiario As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_ComprobanteDiario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuCabecera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminaCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoAsiento As ISL.Controles.Combo
    Friend WithEvents agrCabeceraAsiento As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents DecHaberAsiento As ISL.Controles.NumeroDecimal
    Friend WithEvents DecDebeAsiento As ISL.Controles.NumeroDecimal
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents tcAsientoDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tp_Mant As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents txt_GlosaDetalle As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents DecHaber As ISL.Controles.NumeroDecimal
    Friend WithEvents DecDebe As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroCosto As ISL.Controles.Combo
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents cboRuta As ISL.Controles.Combo
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents cboVehiculo As ISL.Controles.Combo
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents cboItemGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents cboAnalisis2 As ISL.Controles.Combo
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents cboAnalisis1 As ISL.Controles.Combo
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoDocCajaBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents txtNumeroCajaBanco As ISL.Controles.Texto
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDoc As ISL.Controles.Texto
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents cmbTipoDoc As ISL.Controles.Combo
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents FecVencimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents FecEmision As ISL.Controles.Fecha
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents cboCtaCte As ISL.Controles.Combo
    Friend WithEvents cmbAgregarAnalisis As ISL.Controles.Boton
    Friend WithEvents grid_DetalleAsientoAnalisis As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odAnalisis As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents AgregarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents AgregarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarCabecera As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grid_AsientoDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents DecHME As ISL.Controles.NumeroDecimal
    Friend WithEvents DecDME As ISL.Controles.NumeroDecimal
    Friend WithEvents DecHMN As ISL.Controles.NumeroDecimal
    Friend WithEvents DecDMN As ISL.Controles.NumeroDecimal
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChkVehiculoProper As System.Windows.Forms.CheckBox
    Friend WithEvents DuplicarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents cboGastonFuncion As ISL.Controles.Combo
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents DecMontoAn As ISL.Controles.NumeroDecimal
    Friend WithEvents cboCuenta As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraDataSource4 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtNombreCta As ISL.Controles.Texto
    Friend WithEvents tabDocumentoDetalle As System.Windows.Forms.TabControl
    Friend WithEvents Doct As System.Windows.Forms.TabPage
    Friend WithEvents Obli As System.Windows.Forms.TabPage
    Friend WithEvents cboTipoObligacion As ISL.Controles.Combo
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents fecVencimientoObligacion As ISL.Controles.Fecha
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigoUnico As ISL.Controles.Texto
    Friend WithEvents fecEmisionObligacion As ISL.Controles.Fecha
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents cboBancoObligacion As ISL.Controles.Combo
    Friend WithEvents FecAsiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents FecCajaBanco As System.Windows.Forms.DateTimePicker
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ExtornarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tp_Mant_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents cmbTipoAsiento As ISL.Controles.Combo
    Friend WithEvents cmbPeriodo As ISL.Controles.Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents _tp_Mant_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnuDetalleAsiento As ISL.Controles.Menu
    Friend WithEvents _tp_Mant_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _tp_Mant_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _tp_Mant_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents btnBuscarDoc As ISL.Controles.Boton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuDetalleDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarDetalleDetalle As System.Windows.Forms.ToolStripMenuItem


End Class
