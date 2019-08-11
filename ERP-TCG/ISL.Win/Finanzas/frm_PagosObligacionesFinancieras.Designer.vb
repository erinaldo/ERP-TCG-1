<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PagosObligacionesFinancieras
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoObligacion")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ITF")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoObligacion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ITF")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoObligacion")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ITF")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoObligacion")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ITF")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PagosObligacionesFinancieras))
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gridPagoAgregado = New ISL.Controles.Grilla(Me.components)
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.odObliFinPagar = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro = New ISL.Controles.Filtro(Me.components)
        Me.gridObligacion = New ISL.Controles.Grilla(Me.components)
        Me.odObliFinPend = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.btn_Consultar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedor = New ISL.Controles.Combo(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiITFDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiITFSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiComisionSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGastosDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiComisionDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGastosSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDsctoInteresDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDsctoInteresSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiInteresObligacionSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.etiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiIntMoratorioDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalObliFinPagarDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiInteresObligacionDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalObliFinPagarSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.etiIntMoratorioSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalmasInteresDol = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTotalMasInteresSol = New ISL.Controles.Etiqueta(Me.components)
        Me.chkExcluyeInteresPagare = New ISL.Controles.Chequear(Me.components)
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraCalculatorDropDown1 = New Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown()
        Me.chkCalculadora = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMedio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha = New ISL.Controles.Fecha(Me.components)
        Me.cboFlujoGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.txtVoucher = New ISL.Controles.Texto(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregados.SuspendLayout()
        CType(Me.odObliFinPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odObliFinPend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.chkExcluyeInteresPagare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 176)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridPagoAgregado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridObligacion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion4)
        Me.SplitContainer1.Size = New System.Drawing.Size(1147, 483)
        Me.SplitContainer1.SplitterDistance = 211
        Me.SplitContainer1.TabIndex = 8
        '
        'gridPagoAgregado
        '
        Me.gridPagoAgregado.ContextMenuStrip = Me.MenuAgregados
        Me.gridPagoAgregado.DataSource = Me.odObliFinPagar
        UltraGridColumn17.Header.VisiblePosition = 19
        UltraGridColumn17.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.Caption = "Nro Cuota"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.Caption = "Fec. Venc."
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance1
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.Caption = "Interes"
        UltraGridColumn9.Header.VisiblePosition = 11
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance2
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn10.Format = ""
        UltraGridColumn10.Header.Caption = "Mora"
        UltraGridColumn10.Header.VisiblePosition = 12
        UltraGridColumn10.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn10.NullText = ""
        UltraGridColumn10.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn10.Width = 90
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance3
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn11.Format = ""
        UltraGridColumn11.Header.Caption = "Dscto."
        UltraGridColumn11.Header.VisiblePosition = 13
        UltraGridColumn11.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn11.NullText = ""
        UltraGridColumn11.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn11.Width = 88
        UltraGridColumn12.Header.VisiblePosition = 14
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 17
        UltraGridColumn15.Hidden = True
        Appearance4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance4
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn16.Format = ""
        UltraGridColumn16.Header.VisiblePosition = 18
        UltraGridColumn16.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn16.NullText = ""
        UltraGridColumn16.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn16.Width = 84
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance5
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn18.Format = ""
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn18.NullText = ""
        UltraGridColumn18.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn18.Width = 86
        UltraGridColumn19.Header.VisiblePosition = 21
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 22
        UltraGridColumn20.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance6
        UltraGridColumn21.Format = "#,##0.00"
        UltraGridColumn21.Header.VisiblePosition = 25
        UltraGridColumn22.Header.VisiblePosition = 26
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 27
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 28
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 29
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 30
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 31
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 32
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 33
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 34
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 35
        UltraGridColumn31.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance7
        UltraGridColumn32.Format = "#,##0.00"
        UltraGridColumn32.Header.Caption = "Capital"
        UltraGridColumn32.Header.VisiblePosition = 10
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance8
        UltraGridColumn33.Format = "#,##0.00"
        UltraGridColumn33.Header.VisiblePosition = 23
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 36
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn36.Header.Caption = "Tipo Oblig."
        UltraGridColumn36.Header.VisiblePosition = 1
        UltraGridColumn37.Header.Caption = "Moneda"
        UltraGridColumn37.Header.VisiblePosition = 9
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn74.CellAppearance = Appearance9
        UltraGridColumn74.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn74.Format = ""
        UltraGridColumn74.Header.VisiblePosition = 37
        UltraGridColumn74.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn74.NullText = ""
        UltraGridColumn74.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn74.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridColumn74.Width = 90
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance10
        UltraGridColumn76.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn76.Format = ""
        UltraGridColumn76.Header.VisiblePosition = 24
        UltraGridColumn76.MaskInput = "{LOC}nnnnnnnnn.nnnn"
        UltraGridColumn76.NullText = ""
        UltraGridColumn76.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        UltraGridColumn76.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Edit
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn74, UltraGridColumn76})
        Me.gridPagoAgregado.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance11.TextHAlignAsString = "Left"
        Me.gridPagoAgregado.DisplayLayout.CaptionAppearance = Appearance11
        Me.gridPagoAgregado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPagoAgregado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPagoAgregado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridPagoAgregado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPagoAgregado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPagoAgregado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPagoAgregado.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPagoAgregado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPagoAgregado.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPagoAgregado.Location = New System.Drawing.Point(0, 0)
        Me.gridPagoAgregado.Name = "gridPagoAgregado"
        Me.gridPagoAgregado.Size = New System.Drawing.Size(1147, 211)
        Me.gridPagoAgregado.TabIndex = 10
        Me.gridPagoAgregado.Text = "Obligaciones Financieras a Pagar:"
        '
        'MenuAgregados
        '
        Me.MenuAgregados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarDocumento})
        Me.MenuAgregados.Name = "mnu_Transferencias"
        Me.MenuAgregados.Size = New System.Drawing.Size(112, 30)
        '
        'QuitarDocumento
        '
        Me.QuitarDocumento.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.QuitarDocumento.Name = "QuitarDocumento"
        Me.QuitarDocumento.Size = New System.Drawing.Size(111, 26)
        Me.QuitarDocumento.Text = "Quitar"
        '
        'odObliFinPagar
        '
        UltraDataColumn4.DataType = GetType(Integer)
        UltraDataColumn5.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn10.DefaultValue = 0.0R
        UltraDataColumn11.AllowDBNull = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn11.DefaultValue = 0.0R
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn16.AllowDBNull = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn16.DataType = GetType(Double)
        UltraDataColumn16.DefaultValue = 0.0R
        UltraDataColumn17.AllowDBNull = Infragistics.Win.DefaultableBoolean.[True]
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn17.DefaultValue = 0.0R
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn27.DataType = GetType(Date)
        UltraDataColumn29.DataType = GetType(Boolean)
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        Me.odObliFinPagar.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38})
        '
        'Filtro
        '
        Me.Filtro.MenuSettings.RightAlignedMenus = True
        Me.Filtro.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'gridObligacion
        '
        Me.gridObligacion.DataSource = Me.odObliFinPend
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.Caption = "Nro Cuota"
        UltraGridColumn39.Header.VisiblePosition = 4
        UltraGridColumn40.Header.VisiblePosition = 5
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.Caption = "Fec. Vec."
        UltraGridColumn41.Header.VisiblePosition = 6
        UltraGridColumn42.Header.VisiblePosition = 8
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 9
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 10
        UltraGridColumn44.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance12
        UltraGridColumn45.Format = "#,##0.00"
        UltraGridColumn45.Header.Caption = "Interes"
        UltraGridColumn45.Header.VisiblePosition = 12
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance13
        UltraGridColumn46.Format = "#,##0.00"
        UltraGridColumn46.Header.Caption = "Mora"
        UltraGridColumn46.Header.VisiblePosition = 13
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance14
        UltraGridColumn47.Format = "#,##0.00"
        UltraGridColumn47.Header.Caption = "Dscto."
        UltraGridColumn47.Header.VisiblePosition = 14
        UltraGridColumn48.Header.VisiblePosition = 15
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 16
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 17
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 18
        UltraGridColumn51.Hidden = True
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance15
        UltraGridColumn52.Format = "#,##0.00"
        UltraGridColumn52.Header.VisiblePosition = 19
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn53.CellAppearance = Appearance16
        UltraGridColumn53.Format = "#,##0.00"
        UltraGridColumn53.Header.VisiblePosition = 20
        UltraGridColumn54.Header.VisiblePosition = 22
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 23
        UltraGridColumn55.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn56.CellAppearance = Appearance17
        UltraGridColumn56.Format = "#,##0.00"
        UltraGridColumn56.Header.VisiblePosition = 25
        UltraGridColumn57.Header.VisiblePosition = 26
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 27
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 28
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 29
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 30
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 31
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 32
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 33
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 34
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 35
        UltraGridColumn66.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn67.CellAppearance = Appearance18
        UltraGridColumn67.Format = "#,##0.00"
        UltraGridColumn67.Header.Caption = "Capital"
        UltraGridColumn67.Header.VisiblePosition = 11
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn68.CellAppearance = Appearance19
        UltraGridColumn68.Format = "#,##0.00"
        UltraGridColumn68.Header.VisiblePosition = 24
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 36
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 3
        UltraGridColumn71.Header.Caption = "Tipo Oblig."
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn72.Header.Caption = "Moneda"
        UltraGridColumn72.Header.VisiblePosition = 7
        UltraGridColumn73.Header.VisiblePosition = 37
        UltraGridColumn73.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance20
        UltraGridColumn75.Format = "#,##0.00"
        UltraGridColumn75.Header.VisiblePosition = 21
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn75})
        Me.gridObligacion.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance21.TextHAlignAsString = "Left"
        Me.gridObligacion.DisplayLayout.CaptionAppearance = Appearance21
        Me.gridObligacion.DisplayLayout.MaxColScrollRegions = 1
        Me.gridObligacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridObligacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridObligacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridObligacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridObligacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro
        Me.gridObligacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridObligacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridObligacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridObligacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridObligacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridObligacion.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridObligacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridObligacion.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridObligacion.Location = New System.Drawing.Point(0, 53)
        Me.gridObligacion.Name = "gridObligacion"
        Me.gridObligacion.Size = New System.Drawing.Size(1147, 215)
        Me.gridObligacion.TabIndex = 9
        Me.gridObligacion.Text = "Obligaciones Financieras Pendientes:"
        '
        'odObliFinPend
        '
        UltraDataColumn42.DataType = GetType(Integer)
        UltraDataColumn43.DataType = GetType(Date)
        UltraDataColumn44.DataType = GetType(Double)
        UltraDataColumn45.DataType = GetType(Double)
        UltraDataColumn46.DataType = GetType(Double)
        UltraDataColumn47.DataType = GetType(Double)
        UltraDataColumn48.DataType = GetType(Double)
        UltraDataColumn49.DataType = GetType(Double)
        UltraDataColumn50.DataType = GetType(Double)
        UltraDataColumn51.DataType = GetType(Integer)
        UltraDataColumn52.DataType = GetType(Integer)
        UltraDataColumn53.DataType = GetType(Integer)
        UltraDataColumn54.DataType = GetType(Double)
        UltraDataColumn55.DataType = GetType(Double)
        UltraDataColumn56.DataType = GetType(Double)
        UltraDataColumn57.DataType = GetType(Double)
        UltraDataColumn58.DataType = GetType(Double)
        UltraDataColumn63.DataType = GetType(Date)
        UltraDataColumn65.DataType = GetType(Date)
        UltraDataColumn67.DataType = GetType(Boolean)
        UltraDataColumn68.DataType = GetType(Date)
        UltraDataColumn69.DataType = GetType(Double)
        UltraDataColumn70.DataType = GetType(Double)
        UltraDataColumn75.DataType = GetType(Double)
        UltraDataColumn76.DataType = GetType(Double)
        Me.odObliFinPend.Band.Columns.AddRange(New Object() {UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76})
        '
        'Agrupacion4
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion4.ContentAreaAppearance = Appearance22
        Me.Agrupacion4.Controls.Add(Me.cboMoneda)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion4.Controls.Add(Me.btn_Consultar)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion4.Controls.Add(Me.cboProveedor)
        Me.Agrupacion4.Controls.Add(Me.txtRuc)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1147, 53)
        Me.Agrupacion4.TabIndex = 334
        Me.Agrupacion4.Text = "Entidad Financiera"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboMoneda
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance23
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMoneda.DropDownListWidth = 600
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(635, 23)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(123, 22)
        Me.cboMoneda.TabIndex = 271
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta16
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Appearance = Appearance24
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(562, 24)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta16.TabIndex = 270
        Me.Etiqueta16.Text = "Tipo Moneda"
        '
        'btn_Consultar
        '
        Appearance25.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btn_Consultar.Appearance = Appearance25
        Me.btn_Consultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_Consultar.Location = New System.Drawing.Point(783, 21)
        Me.btn_Consultar.Name = "btn_Consultar"
        Me.btn_Consultar.Size = New System.Drawing.Size(30, 26)
        Me.btn_Consultar.TabIndex = 269
        '
        'Etiqueta2
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Appearance = Appearance26
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(24, 24)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(29, 15)
        Me.Etiqueta2.TabIndex = 268
        Me.Etiqueta2.Text = "RUC:"
        '
        'cboProveedor
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProveedor.Appearance = Appearance27
        Me.cboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboProveedor.DropDownListWidth = 400
        Me.cboProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProveedor.Location = New System.Drawing.Point(212, 23)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(343, 22)
        Me.cboProveedor.TabIndex = 9
        Me.cboProveedor.ValueMember = "Id"
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(61, 23)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(91, 22)
        Me.txtRuc.TabIndex = 267
        Me.txtRuc.TabStop = False
        '
        'Etiqueta31
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Appearance = Appearance28
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(164, 24)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(46, 15)
        Me.Etiqueta31.TabIndex = 261
        Me.Etiqueta31.Text = "Nombre:"
        '
        'Agrupacion1
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion1.Appearance = Appearance29
        Appearance30.BackColor = System.Drawing.Color.MintCream
        Me.Agrupacion1.ContentAreaAppearance = Appearance30
        Me.Agrupacion1.Controls.Add(Me.UltraPanel3)
        Me.Agrupacion1.Controls.Add(Me.chkExcluyeInteresPagare)
        Me.Agrupacion1.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Controls.Add(Me.cboMedio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion1.Controls.Add(Me.DecTC)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion1.Controls.Add(Me.Fecha)
        Me.Agrupacion1.Controls.Add(Me.cboFlujoGasto)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion1.Controls.Add(Me.cboCuentaContable)
        Me.Agrupacion1.Controls.Add(Me.txtVoucher)
        Me.Agrupacion1.Controls.Add(Me.cboCuentaBancaria)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1147, 176)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos de Pago:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraPanel3
        '
        Appearance31.BackColor = System.Drawing.Color.AliceBlue
        Me.UltraPanel3.Appearance = Appearance31
        Me.UltraPanel3.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta14)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiITFDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiITFSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta22)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta23)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta24)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiComisionSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta28)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiGastosDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiComisionDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiGastosSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta35)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta5)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiDsctoInteresDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiDsctoInteresSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta19)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta7)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta15)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta3)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiInteresObligacionSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiImporteSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta10)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta9)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiIntMoratorioDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiTotalObliFinPagarDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiInteresObligacionDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiTotalObliFinPagarSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiIntMoratorioSoles)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiTotalmasInteresDol)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta20)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.EtiImporteDolares)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta12)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Etiqueta13)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.etiTotalMasInteresSol)
        Me.UltraPanel3.Location = New System.Drawing.Point(12, 75)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(1013, 95)
        Me.UltraPanel3.TabIndex = 333
        '
        'Etiqueta14
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.FontData.ItalicAsString = "True"
        Me.Etiqueta14.Appearance = Appearance32
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(657, 73)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta14.TabIndex = 305
        Me.Etiqueta14.Text = "ITF $."
        '
        'etiITFDolares
        '
        Appearance33.TextHAlignAsString = "Right"
        Me.etiITFDolares.Appearance = Appearance33
        Me.etiITFDolares.AutoSize = True
        Me.etiITFDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiITFDolares.ForeColor = System.Drawing.Color.Black
        Me.etiITFDolares.Location = New System.Drawing.Point(700, 73)
        Me.etiITFDolares.Name = "etiITFDolares"
        Me.etiITFDolares.Size = New System.Drawing.Size(22, 15)
        Me.etiITFDolares.TabIndex = 306
        Me.etiITFDolares.Text = "0.0"
        '
        'etiITFSoles
        '
        Appearance34.TextHAlignAsString = "Right"
        Me.etiITFSoles.Appearance = Appearance34
        Me.etiITFSoles.AutoSize = True
        Me.etiITFSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiITFSoles.ForeColor = System.Drawing.Color.Black
        Me.etiITFSoles.Location = New System.Drawing.Point(700, 50)
        Me.etiITFSoles.Name = "etiITFSoles"
        Me.etiITFSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiITFSoles.TabIndex = 304
        Me.etiITFSoles.Text = "0.0"
        '
        'Etiqueta22
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.FontData.ItalicAsString = "True"
        Me.Etiqueta22.Appearance = Appearance35
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(653, 50)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta22.TabIndex = 303
        Me.Etiqueta22.Text = "ITF S/."
        '
        'Etiqueta23
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.FontData.ItalicAsString = "True"
        Me.Etiqueta23.Appearance = Appearance36
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(405, 73)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta23.TabIndex = 297
        Me.Etiqueta23.Text = "Gastos $."
        '
        'Etiqueta24
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.FontData.ItalicAsString = "True"
        Me.Etiqueta24.Appearance = Appearance37
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(182, 50)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta24.TabIndex = 299
        Me.Etiqueta24.Text = "Comis. S/."
        '
        'etiComisionSoles
        '
        Appearance38.TextHAlignAsString = "Right"
        Me.etiComisionSoles.Appearance = Appearance38
        Me.etiComisionSoles.AutoSize = True
        Me.etiComisionSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiComisionSoles.ForeColor = System.Drawing.Color.Black
        Me.etiComisionSoles.Location = New System.Drawing.Point(247, 50)
        Me.etiComisionSoles.Name = "etiComisionSoles"
        Me.etiComisionSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiComisionSoles.TabIndex = 300
        Me.etiComisionSoles.Text = "0.0"
        '
        'Etiqueta28
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.FontData.ItalicAsString = "True"
        Me.Etiqueta28.Appearance = Appearance39
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(186, 73)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta28.TabIndex = 301
        Me.Etiqueta28.Text = "Comis. $."
        '
        'etiGastosDolares
        '
        Appearance40.TextHAlignAsString = "Right"
        Me.etiGastosDolares.Appearance = Appearance40
        Me.etiGastosDolares.AutoSize = True
        Me.etiGastosDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGastosDolares.ForeColor = System.Drawing.Color.Black
        Me.etiGastosDolares.Location = New System.Drawing.Point(467, 73)
        Me.etiGastosDolares.Name = "etiGastosDolares"
        Me.etiGastosDolares.Size = New System.Drawing.Size(22, 15)
        Me.etiGastosDolares.TabIndex = 298
        Me.etiGastosDolares.Text = "0.0"
        '
        'etiComisionDolares
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.TextHAlignAsString = "Right"
        Me.etiComisionDolares.Appearance = Appearance41
        Me.etiComisionDolares.AutoSize = True
        Me.etiComisionDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiComisionDolares.ForeColor = System.Drawing.Color.Black
        Me.etiComisionDolares.Location = New System.Drawing.Point(247, 73)
        Me.etiComisionDolares.Name = "etiComisionDolares"
        Me.etiComisionDolares.Size = New System.Drawing.Size(22, 15)
        Me.etiComisionDolares.TabIndex = 302
        Me.etiComisionDolares.Text = "0.0"
        '
        'etiGastosSoles
        '
        Appearance42.TextHAlignAsString = "Right"
        Me.etiGastosSoles.Appearance = Appearance42
        Me.etiGastosSoles.AutoSize = True
        Me.etiGastosSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGastosSoles.ForeColor = System.Drawing.Color.Black
        Me.etiGastosSoles.Location = New System.Drawing.Point(467, 50)
        Me.etiGastosSoles.Name = "etiGastosSoles"
        Me.etiGastosSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiGastosSoles.TabIndex = 296
        Me.etiGastosSoles.Text = "0.0"
        '
        'Etiqueta35
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.FontData.ItalicAsString = "True"
        Me.Etiqueta35.Appearance = Appearance43
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta35.Location = New System.Drawing.Point(401, 50)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta35.TabIndex = 295
        Me.Etiqueta35.Text = "Gastos S/."
        '
        'Etiqueta5
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.FontData.ItalicAsString = "True"
        Me.Etiqueta5.Appearance = Appearance44
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(612, 27)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(84, 15)
        Me.Etiqueta5.TabIndex = 289
        Me.Etiqueta5.Text = "Dscto Interes $."
        '
        'etiDsctoInteresDolares
        '
        Appearance45.TextHAlignAsString = "Right"
        Me.etiDsctoInteresDolares.Appearance = Appearance45
        Me.etiDsctoInteresDolares.AutoSize = True
        Me.etiDsctoInteresDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDsctoInteresDolares.ForeColor = System.Drawing.Color.Black
        Me.etiDsctoInteresDolares.Location = New System.Drawing.Point(700, 27)
        Me.etiDsctoInteresDolares.Name = "etiDsctoInteresDolares"
        Me.etiDsctoInteresDolares.Size = New System.Drawing.Size(22, 15)
        Me.etiDsctoInteresDolares.TabIndex = 290
        Me.etiDsctoInteresDolares.Text = "0.0"
        '
        'etiDsctoInteresSoles
        '
        Appearance46.TextHAlignAsString = "Right"
        Me.etiDsctoInteresSoles.Appearance = Appearance46
        Me.etiDsctoInteresSoles.AutoSize = True
        Me.etiDsctoInteresSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDsctoInteresSoles.ForeColor = System.Drawing.Color.Black
        Me.etiDsctoInteresSoles.Location = New System.Drawing.Point(700, 4)
        Me.etiDsctoInteresSoles.Name = "etiDsctoInteresSoles"
        Me.etiDsctoInteresSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiDsctoInteresSoles.TabIndex = 288
        Me.etiDsctoInteresSoles.Text = "0.0"
        '
        'Etiqueta19
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.FontData.ItalicAsString = "True"
        Me.Etiqueta19.Appearance = Appearance47
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(611, 4)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(89, 15)
        Me.Etiqueta19.TabIndex = 287
        Me.Etiqueta19.Text = "Dscto Interes S/."
        '
        'Etiqueta7
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.FontData.ItalicAsString = "True"
        Me.Etiqueta7.Appearance = Appearance48
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(379, 27)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta7.TabIndex = 273
        Me.Etiqueta7.Text = "Int. Moratorio $."
        '
        'Etiqueta15
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.FontData.ItalicAsString = "True"
        Me.Etiqueta15.Appearance = Appearance49
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(186, 4)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta15.TabIndex = 279
        Me.Etiqueta15.Text = "Interes S/."
        '
        'Etiqueta3
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.FontData.ItalicAsString = "True"
        Appearance50.FontData.Name = "Tahoma"
        Me.Etiqueta3.Appearance = Appearance50
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(6, 27)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta3.TabIndex = 20
        Me.Etiqueta3.Text = "Importe S/."
        '
        'etiInteresObligacionSoles
        '
        Appearance51.TextHAlignAsString = "Right"
        Me.etiInteresObligacionSoles.Appearance = Appearance51
        Me.etiInteresObligacionSoles.AutoSize = True
        Me.etiInteresObligacionSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiInteresObligacionSoles.ForeColor = System.Drawing.Color.Black
        Me.etiInteresObligacionSoles.Location = New System.Drawing.Point(247, 4)
        Me.etiInteresObligacionSoles.Name = "etiInteresObligacionSoles"
        Me.etiInteresObligacionSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiInteresObligacionSoles.TabIndex = 280
        Me.etiInteresObligacionSoles.Text = "0.0"
        '
        'etiImporteSoles
        '
        Appearance52.TextHAlignAsString = "Right"
        Me.etiImporteSoles.Appearance = Appearance52
        Me.etiImporteSoles.AutoSize = True
        Me.etiImporteSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.etiImporteSoles.Location = New System.Drawing.Point(70, 27)
        Me.etiImporteSoles.Name = "etiImporteSoles"
        Me.etiImporteSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiImporteSoles.TabIndex = 35
        Me.etiImporteSoles.Text = "0.0"
        '
        'Etiqueta10
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.FontData.ItalicAsString = "True"
        Me.Etiqueta10.Appearance = Appearance53
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(187, 27)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(53, 15)
        Me.Etiqueta10.TabIndex = 281
        Me.Etiqueta10.Text = "Interes $."
        '
        'Etiqueta9
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.FontData.ItalicAsString = "True"
        Me.Etiqueta9.Appearance = Appearance54
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(6, 50)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta9.TabIndex = 36
        Me.Etiqueta9.Text = "Importe $."
        '
        'etiIntMoratorioDolares
        '
        Appearance55.TextHAlignAsString = "Right"
        Me.etiIntMoratorioDolares.Appearance = Appearance55
        Me.etiIntMoratorioDolares.AutoSize = True
        Me.etiIntMoratorioDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIntMoratorioDolares.ForeColor = System.Drawing.Color.Black
        Me.etiIntMoratorioDolares.Location = New System.Drawing.Point(467, 27)
        Me.etiIntMoratorioDolares.Name = "etiIntMoratorioDolares"
        Me.etiIntMoratorioDolares.Size = New System.Drawing.Size(22, 15)
        Me.etiIntMoratorioDolares.TabIndex = 274
        Me.etiIntMoratorioDolares.Text = "0.0"
        '
        'etiTotalObliFinPagarDolares
        '
        Me.etiTotalObliFinPagarDolares.AutoSize = True
        Me.etiTotalObliFinPagarDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalObliFinPagarDolares.ForeColor = System.Drawing.Color.Black
        Me.etiTotalObliFinPagarDolares.Location = New System.Drawing.Point(991, 50)
        Me.etiTotalObliFinPagarDolares.Name = "etiTotalObliFinPagarDolares"
        Me.etiTotalObliFinPagarDolares.Size = New System.Drawing.Size(11, 15)
        Me.etiTotalObliFinPagarDolares.TabIndex = 278
        Me.etiTotalObliFinPagarDolares.Text = "0"
        Me.etiTotalObliFinPagarDolares.Visible = False
        '
        'EtiInteresObligacionDolares
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.TextHAlignAsString = "Right"
        Me.EtiInteresObligacionDolares.Appearance = Appearance56
        Me.EtiInteresObligacionDolares.AutoSize = True
        Me.EtiInteresObligacionDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiInteresObligacionDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiInteresObligacionDolares.Location = New System.Drawing.Point(247, 27)
        Me.EtiInteresObligacionDolares.Name = "EtiInteresObligacionDolares"
        Me.EtiInteresObligacionDolares.Size = New System.Drawing.Size(22, 15)
        Me.EtiInteresObligacionDolares.TabIndex = 282
        Me.EtiInteresObligacionDolares.Text = "0.0"
        '
        'etiTotalObliFinPagarSoles
        '
        Me.etiTotalObliFinPagarSoles.AutoSize = True
        Me.etiTotalObliFinPagarSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalObliFinPagarSoles.ForeColor = System.Drawing.Color.Black
        Me.etiTotalObliFinPagarSoles.Location = New System.Drawing.Point(991, 27)
        Me.etiTotalObliFinPagarSoles.Name = "etiTotalObliFinPagarSoles"
        Me.etiTotalObliFinPagarSoles.Size = New System.Drawing.Size(11, 15)
        Me.etiTotalObliFinPagarSoles.TabIndex = 276
        Me.etiTotalObliFinPagarSoles.Text = "0"
        Me.etiTotalObliFinPagarSoles.Visible = False
        '
        'etiIntMoratorioSoles
        '
        Appearance57.TextHAlignAsString = "Right"
        Me.etiIntMoratorioSoles.Appearance = Appearance57
        Me.etiIntMoratorioSoles.AutoSize = True
        Me.etiIntMoratorioSoles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiIntMoratorioSoles.ForeColor = System.Drawing.Color.Black
        Me.etiIntMoratorioSoles.Location = New System.Drawing.Point(467, 4)
        Me.etiIntMoratorioSoles.Name = "etiIntMoratorioSoles"
        Me.etiIntMoratorioSoles.Size = New System.Drawing.Size(22, 15)
        Me.etiIntMoratorioSoles.TabIndex = 272
        Me.etiIntMoratorioSoles.Text = "0.0"
        '
        'etiTotalmasInteresDol
        '
        Appearance58.TextHAlignAsString = "Right"
        Me.etiTotalmasInteresDol.Appearance = Appearance58
        Me.etiTotalmasInteresDol.AutoSize = True
        Me.etiTotalmasInteresDol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalmasInteresDol.ForeColor = System.Drawing.Color.Black
        Me.etiTotalmasInteresDol.Location = New System.Drawing.Point(879, 50)
        Me.etiTotalmasInteresDol.Name = "etiTotalmasInteresDol"
        Me.etiTotalmasInteresDol.Size = New System.Drawing.Size(22, 15)
        Me.etiTotalmasInteresDol.TabIndex = 286
        Me.etiTotalmasInteresDol.Text = "0.0"
        '
        'Etiqueta20
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.FontData.ItalicAsString = "True"
        Me.Etiqueta20.Appearance = Appearance59
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(829, 27)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta20.TabIndex = 283
        Me.Etiqueta20.Text = "Total S/."
        '
        'EtiImporteDolares
        '
        Appearance60.TextHAlignAsString = "Right"
        Me.EtiImporteDolares.Appearance = Appearance60
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(70, 50)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(22, 15)
        Me.EtiImporteDolares.TabIndex = 37
        Me.EtiImporteDolares.Text = "0.0"
        '
        'Etiqueta12
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.FontData.ItalicAsString = "True"
        Me.Etiqueta12.Appearance = Appearance61
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(378, 4)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(87, 15)
        Me.Etiqueta12.TabIndex = 271
        Me.Etiqueta12.Text = "Int. MoratorioS/."
        '
        'Etiqueta13
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.FontData.ItalicAsString = "True"
        Me.Etiqueta13.Appearance = Appearance62
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(829, 50)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta13.TabIndex = 285
        Me.Etiqueta13.Text = "Total $."
        '
        'etiTotalMasInteresSol
        '
        Appearance63.TextHAlignAsString = "Right"
        Me.etiTotalMasInteresSol.Appearance = Appearance63
        Me.etiTotalMasInteresSol.AutoSize = True
        Me.etiTotalMasInteresSol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTotalMasInteresSol.ForeColor = System.Drawing.Color.Black
        Me.etiTotalMasInteresSol.Location = New System.Drawing.Point(879, 27)
        Me.etiTotalMasInteresSol.Name = "etiTotalMasInteresSol"
        Me.etiTotalMasInteresSol.Size = New System.Drawing.Size(22, 15)
        Me.etiTotalMasInteresSol.TabIndex = 284
        Me.etiTotalMasInteresSol.Text = "0.0"
        '
        'chkExcluyeInteresPagare
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.FontData.BoldAsString = "True"
        Appearance64.FontData.Name = "Tahoma"
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.chkExcluyeInteresPagare.Appearance = Appearance64
        Me.chkExcluyeInteresPagare.AutoSize = True
        Me.chkExcluyeInteresPagare.BackColor = System.Drawing.Color.Transparent
        Me.chkExcluyeInteresPagare.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkExcluyeInteresPagare.BorderStyle = Infragistics.Win.UIElementBorderStyle.[Default]
        Me.chkExcluyeInteresPagare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExcluyeInteresPagare.ForeColor = System.Drawing.Color.Black
        Me.chkExcluyeInteresPagare.Location = New System.Drawing.Point(892, 49)
        Me.chkExcluyeInteresPagare.Name = "chkExcluyeInteresPagare"
        Me.chkExcluyeInteresPagare.Size = New System.Drawing.Size(107, 18)
        Me.chkExcluyeInteresPagare.TabIndex = 287
        Me.chkExcluyeInteresPagare.Text = "Excluye Interes"
        Me.chkExcluyeInteresPagare.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance65.BackColor = System.Drawing.Color.White
        Appearance65.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance65
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.Expanded = False
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(111, 156)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOutsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(1121, 17)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(23, 156)
        Me.UltraExpandableGroupBox2.TabIndex = 328
        Me.UltraExpandableGroupBox2.Text = "Calculadora"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraPanel1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.chkCalculadora)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(132, 111)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'UltraPanel1
        '
        Appearance66.ImageBackground = CType(resources.GetObject("Appearance66.ImageBackground"), System.Drawing.Image)
        Me.UltraPanel1.Appearance = Appearance66
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraCalculatorDropDown1)
        Me.UltraPanel1.Location = New System.Drawing.Point(8, 13)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(63, 72)
        Me.UltraPanel1.TabIndex = 276
        '
        'UltraCalculatorDropDown1
        '
        Me.UltraCalculatorDropDown1.Location = New System.Drawing.Point(62, -10)
        Me.UltraCalculatorDropDown1.Name = "UltraCalculatorDropDown1"
        Me.UltraCalculatorDropDown1.Size = New System.Drawing.Size(13, 22)
        Me.UltraCalculatorDropDown1.TabIndex = 269
        Me.UltraCalculatorDropDown1.Text = "UltraCalculatorDropDown1"
        Me.UltraCalculatorDropDown1.Visible = False
        '
        'chkCalculadora
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Me.chkCalculadora.Appearance = Appearance67
        Me.chkCalculadora.BackColor = System.Drawing.Color.Transparent
        Me.chkCalculadora.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalculadora.ForeColor = System.Drawing.Color.Black
        Me.chkCalculadora.Location = New System.Drawing.Point(0, 94)
        Me.chkCalculadora.Name = "chkCalculadora"
        Me.chkCalculadora.Size = New System.Drawing.Size(80, 19)
        Me.chkCalculadora.TabIndex = 270
        Me.chkCalculadora.Text = "Calculadora"
        '
        'Etiqueta6
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.FontData.BoldAsString = "True"
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance68
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(7, 50)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta6.TabIndex = 7
        Me.Etiqueta6.Text = "Flujo de Caja :"
        '
        'cboMedio
        '
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Appearance = Appearance69
        Me.cboMedio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Location = New System.Drawing.Point(96, 24)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(242, 22)
        Me.cboMedio.TabIndex = 10
        Me.cboMedio.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.FontData.BoldAsString = "True"
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance70
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(703, 26)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Cta Bancaria:"
        '
        'DecTC
        '
        Appearance71.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance71
        Appearance72.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance72
        Me.DecTC.ButtonsRight.Add(EditorButton1)
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(604, 48)
        Me.DecTC.MaskInput = "{double:2.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.ReadOnly = True
        Me.DecTC.Size = New System.Drawing.Size(92, 22)
        Me.DecTC.TabIndex = 16
        '
        'Etiqueta17
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.FontData.BoldAsString = "True"
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance73
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(707, 50)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta17.TabIndex = 10
        Me.Etiqueta17.Text = "Voucher :"
        '
        'Etiqueta4
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance74
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(520, 51)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(79, 15)
        Me.Etiqueta4.TabIndex = 29
        Me.Etiqueta4.Text = "Tipo Cambio:"
        '
        'Etiqueta1
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.FontData.BoldAsString = "True"
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance75
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(21, 26)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(74, 15)
        Me.Etiqueta1.TabIndex = 45
        Me.Etiqueta1.Text = "Medio Pago:"
        '
        'Etiqueta18
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.FontData.BoldAsString = "True"
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance76
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(345, 50)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta18.TabIndex = 11
        Me.Etiqueta18.Text = "Fecha:"
        '
        'Fecha
        '
        Appearance77.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Appearance = Appearance77
        Me.Fecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Fecha.Location = New System.Drawing.Point(390, 47)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(96, 22)
        Me.Fecha.TabIndex = 15
        '
        'cboFlujoGasto
        '
        Appearance78.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Appearance = Appearance78
        Me.cboFlujoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboFlujoGasto.DropDownListWidth = 400
        Me.cboFlujoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoGasto.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoGasto.Location = New System.Drawing.Point(96, 48)
        Me.cboFlujoGasto.Name = "cboFlujoGasto"
        Me.cboFlujoGasto.Size = New System.Drawing.Size(242, 22)
        Me.cboFlujoGasto.TabIndex = 14
        Me.cboFlujoGasto.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.FontData.BoldAsString = "True"
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance79
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(345, 26)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(95, 15)
        Me.Etiqueta8.TabIndex = 43
        Me.Etiqueta8.Text = "Cta Ctble Pago :"
        '
        'cboCuentaContable
        '
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance80
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCuentaContable.DropDownListWidth = 400
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(440, 24)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.Size = New System.Drawing.Size(256, 22)
        Me.cboCuentaContable.TabIndex = 11
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(783, 48)
        Me.txtVoucher.MaxLength = 20
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(102, 22)
        Me.txtVoucher.TabIndex = 17
        '
        'cboCuentaBancaria
        '
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance81
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(783, 24)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(242, 22)
        Me.cboCuentaBancaria.TabIndex = 13
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'frm_PagosObligacionesFinancieras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1147, 659)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Agrupacion1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PagosObligacionesFinancieras"
        Me.Text = "Pagos Obligaciones Financieras"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridPagoAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.odObliFinPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridObligacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odObliFinPend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.chkExcluyeInteresPagare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraCalculatorDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents chkCalculadora As ISL.Controles.Chequear
    Friend WithEvents UltraCalculatorDropDown1 As Infragistics.Win.UltraWinEditors.UltraWinCalc.UltraCalculatorDropDown
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents cboProveedor As ISL.Controles.Combo
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents cboMedio As ISL.Controles.Combo
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha As ISL.Controles.Fecha
    Friend WithEvents txtVoucher As ISL.Controles.Texto
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents cboFlujoGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents gridObligacion As ISL.Controles.Grilla
    Friend WithEvents gridPagoAgregado As ISL.Controles.Grilla
    Friend WithEvents odObliFinPagar As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odObliFinPend As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents chkExcluyeInteresPagare As ISL.Controles.Chequear
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents etiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalObliFinPagarDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalObliFinPagarSoles As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalmasInteresDol As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalMasInteresSol As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents etiIntMoratorioSoles As ISL.Controles.Etiqueta
    Friend WithEvents EtiInteresObligacionDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiIntMoratorioDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents etiInteresObligacionSoles As ISL.Controles.Etiqueta
    Friend WithEvents Filtro As ISL.Controles.Filtro
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents etiDsctoInteresDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiDsctoInteresSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents btn_Consultar As ISL.Controles.Boton
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents etiITFDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiITFSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents etiComisionSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents etiGastosDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiComisionDolares As ISL.Controles.Etiqueta
    Friend WithEvents etiGastosSoles As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta

End Class
