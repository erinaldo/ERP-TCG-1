<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CreditoHipotecario
    Inherits frm_MenuPadre

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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaBanco")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuotas")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoMN")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoME")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaInteres")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContratoFinanciero")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresCompensatorio")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDsctoInteres")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContratoFinanciero")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresCompensatorio")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoDsctoInteres")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaBanco")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCuotas")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMontoMN")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalMontoME")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TasaInteres")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GroupDetalleCreditos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.GridObligacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DsObligacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.GropBoxFiltro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.GropFechaFiltro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.DtpFechaEmisionFinalFiltro = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaEmisionFiltro = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.gridCuotas = New ISL.Controles.Grilla(Me.components)
        Me.MenuCuotas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dsCuota = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.GroupContendo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboFlujoGasto = New ISL.Controles.Combo(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnImportar = New Infragistics.Win.Misc.UltraButton()
        Me.BtnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.optGlosa = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ndTotalCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndInteresCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndCapitalCuota = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtGlosaObligacion = New ISL.Controles.Texto(Me.components)
        Me.dtpFechaVencimientoCuota = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNumeroCuota = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMedioPago = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaCtbleOrigen = New ISL.Controles.Combo(Me.components)
        Me.cboCuentaBancariaOrigen = New ISL.Controles.Combo(Me.components)
        Me.ndTotalBanco = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndTasaInteresBanco = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtGlosaBanco = New ISL.Controles.Texto(Me.components)
        Me.CboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.BancoFecha = New ISL.Controles.Fecha(Me.components)
        Me.TxtNumeroOperacionBanco = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecFecha = New ISL.Controles.Fecha(Me.components)
        Me.TabCredito = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ofdCreditoHipo = New System.Windows.Forms.OpenFileDialog()
        Me.ndComision = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.GroupDetalleCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDetalleCreditos.SuspendLayout()
        CType(Me.GridObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GropBoxFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GropBoxFiltro.SuspendLayout()
        CType(Me.GropFechaFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GropFechaFiltro.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.gridCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuCuotas.SuspendLayout()
        CType(Me.dsCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupContendo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupContendo.SuspendLayout()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.optGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndTotalCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndInteresCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCapitalCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGlosaObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaVencimientoCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaCtbleOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancariaOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndTotalBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndTasaInteresBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGlosaBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BancoFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumeroOperacionBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCredito.SuspendLayout()
        CType(Me.ndComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GroupDetalleCreditos)
        Me.UltraTabPageControl1.Controls.Add(Me.GropBoxFiltro)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1150, 493)
        '
        'GroupDetalleCreditos
        '
        Me.GroupDetalleCreditos.Controls.Add(Me.GridObligacion)
        Me.GroupDetalleCreditos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupDetalleCreditos.Location = New System.Drawing.Point(0, 93)
        Me.GroupDetalleCreditos.Name = "GroupDetalleCreditos"
        Me.GroupDetalleCreditos.Size = New System.Drawing.Size(1150, 400)
        Me.GroupDetalleCreditos.TabIndex = 3
        Me.GroupDetalleCreditos.Text = "Listado de Créditos Hipotecarios"
        Me.GroupDetalleCreditos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GridObligacion
        '
        Me.GridObligacion.DataSource = Me.DsObligacion
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GridObligacion.DisplayLayout.Appearance = Appearance1
        UltraGridColumn32.Header.VisiblePosition = 0
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 1
        UltraGridColumn34.Header.VisiblePosition = 2
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.Caption = "Banco"
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn37.Header.VisiblePosition = 5
        UltraGridColumn38.Header.VisiblePosition = 6
        UltraGridColumn39.Header.VisiblePosition = 7
        UltraGridColumn40.Header.Caption = "Moneda"
        UltraGridColumn40.Header.VisiblePosition = 8
        UltraGridColumn41.Header.Caption = "T.C."
        UltraGridColumn41.Header.VisiblePosition = 9
        UltraGridColumn42.Header.VisiblePosition = 10
        UltraGridColumn43.Header.VisiblePosition = 11
        UltraGridColumn44.Header.VisiblePosition = 12
        UltraGridColumn45.Header.VisiblePosition = 13
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 14
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 15
        UltraGridColumn48.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48})
        UltraGridColumn49.Header.VisiblePosition = 0
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 1
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 2
        UltraGridColumn52.Header.VisiblePosition = 3
        UltraGridColumn53.Header.VisiblePosition = 4
        UltraGridColumn54.Header.VisiblePosition = 5
        UltraGridColumn55.Header.VisiblePosition = 6
        UltraGridColumn56.Header.VisiblePosition = 7
        UltraGridColumn57.Header.VisiblePosition = 8
        UltraGridColumn58.Header.VisiblePosition = 9
        UltraGridColumn59.Header.VisiblePosition = 10
        UltraGridColumn60.Header.VisiblePosition = 11
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 12
        UltraGridColumn62.Header.VisiblePosition = 13
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62})
        Me.GridObligacion.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridObligacion.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GridObligacion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GridObligacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.GridObligacion.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridObligacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.GridObligacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridObligacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.GridObligacion.DisplayLayout.MaxColScrollRegions = 1
        Me.GridObligacion.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GridObligacion.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GridObligacion.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.GridObligacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GridObligacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridObligacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.GridObligacion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.GridObligacion.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.GridObligacion.DisplayLayout.Override.CellAppearance = Appearance8
        Me.GridObligacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.GridObligacion.DisplayLayout.Override.CellPadding = 0
        Me.GridObligacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridObligacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.GridObligacion.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.GridObligacion.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.GridObligacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.GridObligacion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.GridObligacion.DisplayLayout.Override.RowAppearance = Appearance11
        Me.GridObligacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridObligacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.GridObligacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridObligacion.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.GridObligacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.GridObligacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GridObligacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridObligacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridObligacion.Location = New System.Drawing.Point(2, 18)
        Me.GridObligacion.Name = "GridObligacion"
        Me.GridObligacion.Size = New System.Drawing.Size(1146, 380)
        Me.GridObligacion.TabIndex = 1
        Me.GridObligacion.Text = "UltraGrid1"
        '
        'DsObligacion
        '
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        Me.DsObligacion.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Integer)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn28.DataType = GetType(Boolean)
        UltraDataColumn30.DataType = GetType(Double)
        Me.DsObligacion.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'GropBoxFiltro
        '
        Me.GropBoxFiltro.Controls.Add(Me.GropFechaFiltro)
        Me.GropBoxFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.GropBoxFiltro.Location = New System.Drawing.Point(0, 0)
        Me.GropBoxFiltro.Name = "GropBoxFiltro"
        Me.GropBoxFiltro.Size = New System.Drawing.Size(1150, 93)
        Me.GropBoxFiltro.TabIndex = 2
        Me.GropBoxFiltro.Text = "Filtro de Búsqueda"
        Me.GropBoxFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GropFechaFiltro
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Me.GropFechaFiltro.Appearance = Appearance13
        Me.GropFechaFiltro.Controls.Add(Me.DtpFechaEmisionFinalFiltro)
        Me.GropFechaFiltro.Controls.Add(Me.DtpFechaEmisionFiltro)
        Me.GropFechaFiltro.Controls.Add(Me.UltraLabel10)
        Me.GropFechaFiltro.Controls.Add(Me.UltraLabel9)
        Me.GropFechaFiltro.Location = New System.Drawing.Point(11, 23)
        Me.GropFechaFiltro.Name = "GropFechaFiltro"
        Me.GropFechaFiltro.Size = New System.Drawing.Size(355, 59)
        Me.GropFechaFiltro.TabIndex = 0
        Me.GropFechaFiltro.Text = "Fecha de Emisión:"
        '
        'DtpFechaEmisionFinalFiltro
        '
        Me.DtpFechaEmisionFinalFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEmisionFinalFiltro.Location = New System.Drawing.Point(231, 25)
        Me.DtpFechaEmisionFinalFiltro.Name = "DtpFechaEmisionFinalFiltro"
        Me.DtpFechaEmisionFinalFiltro.Size = New System.Drawing.Size(97, 20)
        Me.DtpFechaEmisionFinalFiltro.TabIndex = 348
        '
        'DtpFechaEmisionFiltro
        '
        Me.DtpFechaEmisionFiltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEmisionFiltro.Location = New System.Drawing.Point(58, 25)
        Me.DtpFechaEmisionFiltro.Name = "DtpFechaEmisionFiltro"
        Me.DtpFechaEmisionFiltro.Size = New System.Drawing.Size(97, 20)
        Me.DtpFechaEmisionFiltro.TabIndex = 346
        '
        'UltraLabel10
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance14
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(188, 30)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel10.TabIndex = 349
        Me.UltraLabel10.Text = "Hasta:"
        '
        'UltraLabel9
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance15
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(13, 30)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel9.TabIndex = 347
        Me.UltraLabel9.Text = "Desde:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.GroupContendo)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1074, 493)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 187)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1074, 306)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Relación de Cuotas:"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.gridCuotas)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(2, 18)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1070, 286)
        Me.UltraGroupBox3.TabIndex = 1
        '
        'gridCuotas
        '
        Me.gridCuotas.ContextMenuStrip = Me.MenuCuotas
        Me.gridCuotas.DataSource = Me.dsCuota
        Appearance16.BackColor = System.Drawing.SystemColors.Window
        Appearance16.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridCuotas.DisplayLayout.Appearance = Appearance16
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance17
        UltraGridColumn6.Format = "#,##0.00"
        UltraGridColumn6.Header.VisiblePosition = 6
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance18
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance19
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 18
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 19
        UltraGridColumn19.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance20
        UltraGridColumn20.Format = "#,##0.00"
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 24
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 25
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 26
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 27
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 28
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 29
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 30
        UltraGridColumn29.Hidden = True
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance21
        UltraGridColumn30.Format = "#,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 5
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance22
        UltraGridColumn31.Format = "#,##0.00"
        UltraGridColumn31.Header.VisiblePosition = 20
        UltraGridColumn63.Header.VisiblePosition = 31
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 32
        UltraGridColumn64.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn63, UltraGridColumn64})
        Me.gridCuotas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridCuotas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridCuotas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance23.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance23.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance23.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance23.BorderColor = System.Drawing.SystemColors.Window
        Me.gridCuotas.DisplayLayout.GroupByBox.Appearance = Appearance23
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridCuotas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance24
        Me.gridCuotas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridCuotas.DisplayLayout.GroupByBox.Hidden = True
        Appearance25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance25.BackColor2 = System.Drawing.SystemColors.Control
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridCuotas.DisplayLayout.GroupByBox.PromptAppearance = Appearance25
        Me.gridCuotas.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCuotas.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridCuotas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCuotas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCuotas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCuotas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCuotas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCuotas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCuotas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCuotas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridCuotas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridCuotas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridCuotas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridCuotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCuotas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCuotas.Location = New System.Drawing.Point(3, 3)
        Me.gridCuotas.Name = "gridCuotas"
        Me.gridCuotas.Size = New System.Drawing.Size(1064, 280)
        Me.gridCuotas.TabIndex = 320
        Me.gridCuotas.Text = "Grilla2"
        '
        'MenuCuotas
        '
        Me.MenuCuotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarToolStripMenuItem})
        Me.MenuCuotas.Name = "MenuCuotas"
        Me.MenuCuotas.Size = New System.Drawing.Size(108, 26)
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'dsCuota
        '
        UltraDataColumn34.DataType = GetType(Integer)
        UltraDataColumn35.DataType = GetType(Date)
        UltraDataColumn36.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn43.DataType = GetType(Integer)
        UltraDataColumn44.DataType = GetType(Integer)
        UltraDataColumn45.DataType = GetType(Integer)
        UltraDataColumn46.DataType = GetType(Double)
        UltraDataColumn47.DataType = GetType(Double)
        UltraDataColumn48.DataType = GetType(Double)
        UltraDataColumn49.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Double)
        UltraDataColumn54.DataType = GetType(Date)
        UltraDataColumn56.DataType = GetType(Date)
        UltraDataColumn58.DataType = GetType(Boolean)
        UltraDataColumn59.DataType = GetType(Date)
        UltraDataColumn60.DataType = GetType(Decimal)
        UltraDataColumn61.DataType = GetType(Double)
        Me.dsCuota.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        '
        'GroupContendo
        '
        Me.GroupContendo.Controls.Add(Me.Etiqueta10)
        Me.GroupContendo.Controls.Add(Me.ndComision)
        Me.GroupContendo.Controls.Add(Me.cboFlujoGasto)
        Me.GroupContendo.Controls.Add(Me.UltraGroupBox2)
        Me.GroupContendo.Controls.Add(Me.Etiqueta9)
        Me.GroupContendo.Controls.Add(Me.UltraLabel8)
        Me.GroupContendo.Controls.Add(Me.cboBanco)
        Me.GroupContendo.Controls.Add(Me.Etiqueta8)
        Me.GroupContendo.Controls.Add(Me.cboMedioPago)
        Me.GroupContendo.Controls.Add(Me.Etiqueta7)
        Me.GroupContendo.Controls.Add(Me.cboCuentaCtbleOrigen)
        Me.GroupContendo.Controls.Add(Me.cboCuentaBancariaOrigen)
        Me.GroupContendo.Controls.Add(Me.ndTotalBanco)
        Me.GroupContendo.Controls.Add(Me.Etiqueta6)
        Me.GroupContendo.Controls.Add(Me.ndTasaInteresBanco)
        Me.GroupContendo.Controls.Add(Me.Etiqueta2)
        Me.GroupContendo.Controls.Add(Me.Etiqueta14)
        Me.GroupContendo.Controls.Add(Me.TxtGlosaBanco)
        Me.GroupContendo.Controls.Add(Me.CboMoneda)
        Me.GroupContendo.Controls.Add(Me.Etiqueta12)
        Me.GroupContendo.Controls.Add(Me.DecTC)
        Me.GroupContendo.Controls.Add(Me.Etiqueta13)
        Me.GroupContendo.Controls.Add(Me.BancoFecha)
        Me.GroupContendo.Controls.Add(Me.TxtNumeroOperacionBanco)
        Me.GroupContendo.Controls.Add(Me.Etiqueta21)
        Me.GroupContendo.Controls.Add(Me.Etiqueta18)
        Me.GroupContendo.Controls.Add(Me.Etiqueta11)
        Me.GroupContendo.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupContendo.Location = New System.Drawing.Point(0, 0)
        Me.GroupContendo.Name = "GroupContendo"
        Me.GroupContendo.Size = New System.Drawing.Size(1074, 187)
        Me.GroupContendo.TabIndex = 0
        Me.GroupContendo.Text = "Movimiento del Banco:"
        Me.GroupContendo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboFlujoGasto
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Appearance = Appearance28
        Me.cboFlujoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoGasto.DropDownListWidth = 400
        Me.cboFlujoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Location = New System.Drawing.Point(390, 77)
        Me.cboFlujoGasto.Name = "cboFlujoGasto"
        Me.cboFlujoGasto.Size = New System.Drawing.Size(212, 21)
        Me.cboFlujoGasto.TabIndex = 392
        Me.cboFlujoGasto.ValueMember = "Id"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnImportar)
        Me.UltraGroupBox2.Controls.Add(Me.BtnAgregar)
        Me.UltraGroupBox2.Controls.Add(Me.optGlosa)
        Me.UltraGroupBox2.Controls.Add(Me.ndTotalCuota)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox2.Controls.Add(Me.ndInteresCuota)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta3)
        Me.UltraGroupBox2.Controls.Add(Me.ndCapitalCuota)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox2.Controls.Add(Me.TxtGlosaObligacion)
        Me.UltraGroupBox2.Controls.Add(Me.dtpFechaVencimientoCuota)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.txtNumeroCuota)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox2.Location = New System.Drawing.Point(608, 23)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(450, 154)
        Me.UltraGroupBox2.TabIndex = 0
        Me.UltraGroupBox2.Text = "Registro de Cuota:"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnImportar
        '
        Appearance29.Image = Global.ISL.Win.My.Resources.Resources.kdvi
        Me.btnImportar.Appearance = Appearance29
        Me.btnImportar.AutoSize = True
        Me.btnImportar.Location = New System.Drawing.Point(58, 107)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(195, 26)
        Me.btnImportar.TabIndex = 355
        Me.btnImportar.Text = "Importar Cronograma de Pagos"
        '
        'BtnAgregar
        '
        Appearance30.Image = Global.ISL.Win.My.Resources.Resources.Confirmar
        Me.BtnAgregar.Appearance = Appearance30
        Me.BtnAgregar.ButtonStyle = Infragistics.Win.UIElementButtonStyle.ButtonSoftExtended
        Me.BtnAgregar.Location = New System.Drawing.Point(412, 78)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(26, 22)
        Me.BtnAgregar.TabIndex = 354
        '
        'optGlosa
        '
        Me.optGlosa.AutoSize = True
        Me.optGlosa.BackColor = System.Drawing.Color.Transparent
        Me.optGlosa.BackColorInternal = System.Drawing.Color.Transparent
        Me.optGlosa.Checked = True
        Me.optGlosa.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optGlosa.Location = New System.Drawing.Point(392, 85)
        Me.optGlosa.Name = "optGlosa"
        Me.optGlosa.Size = New System.Drawing.Size(14, 13)
        Me.optGlosa.TabIndex = 353
        Me.optGlosa.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ndTotalCuota
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.ndTotalCuota.Appearance = Appearance31
        Me.ndTotalCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTotalCuota.Enabled = False
        Me.ndTotalCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTotalCuota.ForeColor = System.Drawing.Color.Black
        Me.ndTotalCuota.Location = New System.Drawing.Point(330, 54)
        Me.ndTotalCuota.MaskInput = "{double:9.4}"
        Me.ndTotalCuota.Name = "ndTotalCuota"
        Me.ndTotalCuota.NullText = "0.00"
        Me.ndTotalCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTotalCuota.Size = New System.Drawing.Size(108, 21)
        Me.ndTotalCuota.TabIndex = 352
        '
        'Etiqueta5
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.FontData.BoldAsString = "True"
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance32
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(291, 58)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta5.TabIndex = 351
        Me.Etiqueta5.Text = "Total:"
        '
        'ndInteresCuota
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.ndInteresCuota.Appearance = Appearance33
        Me.ndInteresCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndInteresCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndInteresCuota.ForeColor = System.Drawing.Color.Black
        Me.ndInteresCuota.Location = New System.Drawing.Point(207, 54)
        Me.ndInteresCuota.MaskInput = "{double:6.4}"
        Me.ndInteresCuota.Name = "ndInteresCuota"
        Me.ndInteresCuota.NullText = "0.00"
        Me.ndInteresCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndInteresCuota.Size = New System.Drawing.Size(78, 21)
        Me.ndInteresCuota.TabIndex = 350
        '
        'Etiqueta4
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance34
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(159, 58)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta4.TabIndex = 349
        Me.Etiqueta4.Text = "Interes:"
        '
        'Etiqueta3
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.FontData.BoldAsString = "True"
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance35
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(11, 58)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta3.TabIndex = 347
        Me.Etiqueta3.Text = "Capital:"
        '
        'ndCapitalCuota
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.ndCapitalCuota.Appearance = Appearance36
        Me.ndCapitalCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndCapitalCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCapitalCuota.ForeColor = System.Drawing.Color.Black
        Me.ndCapitalCuota.Location = New System.Drawing.Point(59, 54)
        Me.ndCapitalCuota.MaskInput = "{double:9.4}"
        Me.ndCapitalCuota.Name = "ndCapitalCuota"
        Me.ndCapitalCuota.NullText = "0.00"
        Me.ndCapitalCuota.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCapitalCuota.Size = New System.Drawing.Size(94, 21)
        Me.ndCapitalCuota.TabIndex = 346
        '
        'Etiqueta1
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.FontData.BoldAsString = "True"
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance37
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(16, 85)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta1.TabIndex = 345
        Me.Etiqueta1.Text = "Glosa:"
        '
        'TxtGlosaObligacion
        '
        Me.TxtGlosaObligacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGlosaObligacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtGlosaObligacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGlosaObligacion.Location = New System.Drawing.Point(58, 81)
        Me.TxtGlosaObligacion.MaxLength = 200
        Me.TxtGlosaObligacion.Name = "TxtGlosaObligacion"
        Me.TxtGlosaObligacion.Size = New System.Drawing.Size(328, 21)
        Me.TxtGlosaObligacion.TabIndex = 344
        '
        'dtpFechaVencimientoCuota
        '
        Me.dtpFechaVencimientoCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.dtpFechaVencimientoCuota.Location = New System.Drawing.Point(281, 27)
        Me.dtpFechaVencimientoCuota.MaskInput = ""
        Me.dtpFechaVencimientoCuota.Name = "dtpFechaVencimientoCuota"
        Me.dtpFechaVencimientoCuota.Size = New System.Drawing.Size(87, 21)
        Me.dtpFechaVencimientoCuota.TabIndex = 343
        '
        'UltraLabel1
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.FontData.BoldAsString = "True"
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Appearance38.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance38
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(159, 31)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(116, 15)
        Me.UltraLabel1.TabIndex = 342
        Me.UltraLabel1.Text = "Fecha Vencimiento:"
        '
        'txtNumeroCuota
        '
        Me.txtNumeroCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroCuota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroCuota.Location = New System.Drawing.Point(58, 27)
        Me.txtNumeroCuota.MaxLength = 8
        Me.txtNumeroCuota.Name = "txtNumeroCuota"
        Me.txtNumeroCuota.Size = New System.Drawing.Size(95, 21)
        Me.txtNumeroCuota.TabIndex = 341
        '
        'UltraLabel2
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.FontData.BoldAsString = "True"
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance39
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(29, 31)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(23, 15)
        Me.UltraLabel2.TabIndex = 340
        Me.UltraLabel2.Text = "N°:"
        '
        'Etiqueta9
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.FontData.BoldAsString = "True"
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance40
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(310, 80)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(77, 14)
        Me.Etiqueta9.TabIndex = 391
        Me.Etiqueta9.Text = "Flujo de Caja:"
        '
        'UltraLabel8
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.FontData.BoldAsString = "True"
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Appearance41.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance41
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(48, 54)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel8.TabIndex = 390
        Me.UltraLabel8.Text = "Banco:"
        '
        'cboBanco
        '
        Appearance42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Appearance = Appearance42
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownListWidth = 400
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Location = New System.Drawing.Point(92, 50)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(210, 21)
        Me.cboBanco.TabIndex = 389
        Me.cboBanco.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.FontData.BoldAsString = "True"
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance43
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(48, 80)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta8.TabIndex = 255
        Me.Etiqueta8.Text = "Medio:"
        '
        'cboMedioPago
        '
        Appearance44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMedioPago.Appearance = Appearance44
        Me.cboMedioPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMedioPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedioPago.DropDownListWidth = 400
        Me.cboMedioPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedioPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedioPago.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMedioPago.Location = New System.Drawing.Point(92, 77)
        Me.cboMedioPago.Name = "cboMedioPago"
        Me.cboMedioPago.Size = New System.Drawing.Size(210, 21)
        Me.cboMedioPago.TabIndex = 254
        Me.cboMedioPago.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.FontData.BoldAsString = "True"
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance45
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(308, 54)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta7.TabIndex = 252
        Me.Etiqueta7.Text = "Cta. Bancaria:"
        '
        'cboCuentaCtbleOrigen
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleOrigen.Appearance = Appearance46
        Me.cboCuentaCtbleOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaCtbleOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaCtbleOrigen.DropDownListWidth = 300
        Me.cboCuentaCtbleOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaCtbleOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaCtbleOrigen.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaCtbleOrigen.Location = New System.Drawing.Point(101, 191)
        Me.cboCuentaCtbleOrigen.Name = "cboCuentaCtbleOrigen"
        Me.cboCuentaCtbleOrigen.Size = New System.Drawing.Size(273, 21)
        Me.cboCuentaCtbleOrigen.TabIndex = 251
        Me.cboCuentaCtbleOrigen.ValueMember = "Id"
        '
        'cboCuentaBancariaOrigen
        '
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaOrigen.Appearance = Appearance47
        Me.cboCuentaBancariaOrigen.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancariaOrigen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancariaOrigen.DropDownListWidth = 400
        Me.cboCuentaBancariaOrigen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancariaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancariaOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCuentaBancariaOrigen.Location = New System.Drawing.Point(390, 50)
        Me.cboCuentaBancariaOrigen.Name = "cboCuentaBancariaOrigen"
        Me.cboCuentaBancariaOrigen.Size = New System.Drawing.Size(212, 21)
        Me.cboCuentaBancariaOrigen.TabIndex = 250
        Me.cboCuentaBancariaOrigen.ValueMember = "Id"
        '
        'ndTotalBanco
        '
        Appearance48.ForeColor = System.Drawing.Color.Black
        Me.ndTotalBanco.Appearance = Appearance48
        Me.ndTotalBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTotalBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTotalBanco.ForeColor = System.Drawing.Color.Black
        Me.ndTotalBanco.Location = New System.Drawing.Point(390, 104)
        Me.ndTotalBanco.MaskInput = "{double:9.3}"
        Me.ndTotalBanco.Name = "ndTotalBanco"
        Me.ndTotalBanco.NullText = "0.00"
        Me.ndTotalBanco.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTotalBanco.Size = New System.Drawing.Size(114, 21)
        Me.ndTotalBanco.TabIndex = 80
        '
        'Etiqueta6
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.FontData.BoldAsString = "True"
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance49
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(344, 107)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta6.TabIndex = 79
        Me.Etiqueta6.Text = "Monto:"
        '
        'ndTasaInteresBanco
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.ndTasaInteresBanco.Appearance = Appearance50
        Me.ndTasaInteresBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTasaInteresBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTasaInteresBanco.ForeColor = System.Drawing.Color.Black
        Me.ndTasaInteresBanco.Location = New System.Drawing.Point(92, 131)
        Me.ndTasaInteresBanco.MaskInput = "{double:6.4}"
        Me.ndTasaInteresBanco.Name = "ndTasaInteresBanco"
        Me.ndTasaInteresBanco.NullText = "0.00"
        Me.ndTasaInteresBanco.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTasaInteresBanco.Size = New System.Drawing.Size(108, 21)
        Me.ndTasaInteresBanco.TabIndex = 78
        '
        'Etiqueta2
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.FontData.BoldAsString = "True"
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance51
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(38, 135)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta2.TabIndex = 77
        Me.Etiqueta2.Text = "Tasa Int:"
        '
        'Etiqueta14
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.FontData.BoldAsString = "True"
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance52
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(51, 160)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta14.TabIndex = 75
        Me.Etiqueta14.Text = "Glosa:"
        '
        'TxtGlosaBanco
        '
        Me.TxtGlosaBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGlosaBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtGlosaBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGlosaBanco.Location = New System.Drawing.Point(92, 156)
        Me.TxtGlosaBanco.MaxLength = 200
        Me.TxtGlosaBanco.Name = "TxtGlosaBanco"
        Me.TxtGlosaBanco.Size = New System.Drawing.Size(510, 21)
        Me.TxtGlosaBanco.TabIndex = 71
        '
        'CboMoneda
        '
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.CboMoneda.Appearance = Appearance53
        Me.CboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboMoneda.DropDownListWidth = 150
        Me.CboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMoneda.ForeColor = System.Drawing.Color.Black
        Me.CboMoneda.Location = New System.Drawing.Point(416, 23)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(134, 21)
        Me.CboMoneda.TabIndex = 68
        Me.CboMoneda.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.FontData.BoldAsString = "True"
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance54
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(364, 27)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta12.TabIndex = 74
        Me.Etiqueta12.Text = "Moneda:"
        '
        'DecTC
        '
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance55
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(277, 23)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(81, 21)
        Me.DecTC.TabIndex = 70
        '
        'Etiqueta13
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.FontData.BoldAsString = "True"
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance56
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(199, 27)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta13.TabIndex = 73
        Me.Etiqueta13.Text = "Tipo Cambio:"
        '
        'BancoFecha
        '
        Appearance57.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BancoFecha.Appearance = Appearance57
        Me.BancoFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.BancoFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BancoFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BancoFecha.Location = New System.Drawing.Point(92, 23)
        Me.BancoFecha.Name = "BancoFecha"
        Me.BancoFecha.Size = New System.Drawing.Size(90, 21)
        Me.BancoFecha.TabIndex = 66
        '
        'TxtNumeroOperacionBanco
        '
        Me.TxtNumeroOperacionBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumeroOperacionBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtNumeroOperacionBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroOperacionBanco.Location = New System.Drawing.Point(92, 104)
        Me.TxtNumeroOperacionBanco.MaxLength = 50
        Me.TxtNumeroOperacionBanco.Name = "TxtNumeroOperacionBanco"
        Me.TxtNumeroOperacionBanco.Size = New System.Drawing.Size(210, 21)
        Me.TxtNumeroOperacionBanco.TabIndex = 72
        '
        'Etiqueta21
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.FontData.BoldAsString = "True"
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance58
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(26, 108)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta21.TabIndex = 76
        Me.Etiqueta21.Text = "Operación:"
        '
        'Etiqueta18
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.FontData.BoldAsString = "True"
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance59
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(11, 27)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta18.TabIndex = 67
        Me.Etiqueta18.Text = "Fec. Emisión:"
        '
        'Etiqueta11
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance60
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(33, 195)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta11.TabIndex = 65
        Me.Etiqueta11.Text = "Cta. Origen:"
        '
        'FecFecha
        '
        Appearance61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Appearance = Appearance61
        Me.FecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Location = New System.Drawing.Point(73, 55)
        Me.FecFecha.Name = "FecFecha"
        Me.FecFecha.Size = New System.Drawing.Size(84, 21)
        Me.FecFecha.TabIndex = 66
        '
        'TabCredito
        '
        Me.TabCredito.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabCredito.Controls.Add(Me.UltraTabPageControl1)
        Me.TabCredito.Controls.Add(Me.UltraTabPageControl2)
        Me.TabCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCredito.Location = New System.Drawing.Point(0, 0)
        Me.TabCredito.Name = "TabCredito"
        Me.TabCredito.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabCredito.Size = New System.Drawing.Size(1076, 516)
        Me.TabCredito.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Listado"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Mantenimiento"
        Me.TabCredito.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.TabCredito.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1074, 493)
        '
        'ofdCreditoHipo
        '
        Me.ofdCreditoHipo.FileName = "OpenFileDialog1"
        '
        'ndComision
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.ndComision.Appearance = Appearance27
        Me.ndComision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndComision.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndComision.ForeColor = System.Drawing.Color.Black
        Me.ndComision.Location = New System.Drawing.Point(390, 131)
        Me.ndComision.MaskInput = "{double:9.3}"
        Me.ndComision.Name = "ndComision"
        Me.ndComision.NullText = "0.00"
        Me.ndComision.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndComision.Size = New System.Drawing.Size(114, 21)
        Me.ndComision.TabIndex = 393
        '
        'Etiqueta10
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance26
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(327, 136)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta10.TabIndex = 394
        Me.Etiqueta10.Text = "Comisión:"
        '
        'frm_CreditoHipotecario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 516)
        Me.Controls.Add(Me.TabCredito)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CreditoHipotecario"
        Me.Text = "Créditos Hipotecarios"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.GroupDetalleCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDetalleCreditos.ResumeLayout(False)
        CType(Me.GridObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GropBoxFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GropBoxFiltro.ResumeLayout(False)
        CType(Me.GropFechaFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GropFechaFiltro.ResumeLayout(False)
        Me.GropFechaFiltro.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.gridCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuCuotas.ResumeLayout(False)
        CType(Me.dsCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupContendo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupContendo.ResumeLayout(False)
        Me.GroupContendo.PerformLayout()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.optGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndTotalCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndInteresCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCapitalCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGlosaObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaVencimientoCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedioPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaCtbleOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancariaOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndTotalBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndTasaInteresBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGlosaBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BancoFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumeroOperacionBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCredito.ResumeLayout(False)
        CType(Me.ndComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents TabCredito As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GroupDetalleCreditos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GropBoxFiltro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents GropFechaFiltro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents DtpFechaEmisionFinalFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpFechaEmisionFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents GroupContendo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents TxtGlosaBanco As ISL.Controles.Texto
    Friend WithEvents CboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents BancoFecha As ISL.Controles.Fecha
    Friend WithEvents TxtNumeroOperacionBanco As ISL.Controles.Texto
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents BtnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents optGlosa As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents ndTotalCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents ndInteresCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ndCapitalCuota As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents TxtGlosaObligacion As ISL.Controles.Texto
    Friend WithEvents dtpFechaVencimientoCuota As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumeroCuota As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndTasaInteresBanco As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ndTotalBanco As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaCtbleOrigen As ISL.Controles.Combo
    Friend WithEvents cboCuentaBancariaOrigen As ISL.Controles.Combo
    Friend WithEvents gridCuotas As ISL.Controles.Grilla
    Friend WithEvents FecFecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cboMedioPago As ISL.Controles.Combo
    Friend WithEvents DsObligacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents GridObligacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dsCuota As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuCuotas As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboFlujoGasto As ISL.Controles.Combo
    Friend WithEvents btnImportar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ofdCreditoHipo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ndComision As ISL.Controles.NumeroDecimal
End Class
