<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DevengadoMensualSeguros
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaCertifica")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteBI")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Excluido")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dias")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Devengado")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalAsiento")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalxVehiculo")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("seleccion")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaCertifica")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImporteBI")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Excluido")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dias")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Devengado")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalAsiento")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalxVehiculo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("seleccion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaCertifica")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteBI")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Excluido")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dias")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Devengado")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalAsiento")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalxVehiculo")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("seleccion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaCertifica")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImporteBI")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Excluido")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dias")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Devengado")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalAsiento")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalxVehiculo")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("seleccion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDoc")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaExclusion")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndExcluido")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteBI")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dias")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDia")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalAsientoMes")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Empresa")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDoc")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaExclusion")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndExcluido")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImporteBI")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dias")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoDia")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalAsientoMes")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.GridSoat = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gridPolizas = New ISL.Controles.Grilla(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel
        Me.Grid_Soat = New ISL.Controles.Grilla(Me.components)
        Me.dsDevengados = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel
        Me.dtpFechaVenc = New System.Windows.Forms.DateTimePicker
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkCalculadora = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Año1 = New ISL.Win.Año
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.tcSeguros = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.tcComprobanteCompra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.gridComprobanteCompra = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.btn_Extornar = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Combo1 = New ISL.Controles.Combo(Me.components)
        Me.Año2 = New ISL.Win.Año
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gridDetalleAsientoAnalisis = New ISL.Controles.Grilla(Me.components)
        Me.tcComprobanteDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.GridSoat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPolizas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.Grid_Soat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDevengados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año1.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcSeguros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcSeguros.SuspendLayout()
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcComprobanteCompra.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.gridComprobanteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.Combo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año2.SuspendLayout()
        CType(Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridDetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GridSoat)
        Me.UltraTabPageControl2.Controls.Add(Me.gridPolizas)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1266, 467)
        '
        'GridSoat
        '
        Me.GridSoat.DataSource = Me.UltraDataSource1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 3
        UltraGridColumn2.Width = 88
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.Caption = "TipoDoc"
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 65
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.Caption = "Fec.Emision"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 85
        UltraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.Caption = "Fec.Venc."
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 81
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance34
        UltraGridColumn7.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.VisiblePosition = 7
        UltraGridColumn7.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance35
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn8.Format = "#,##0.00"
        UltraGridColumn8.Header.VisiblePosition = 8
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn9.Header.Caption = "Mon"
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Width = 34
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance36
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 50
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance37
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Width = 59
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance38
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn12.Format = ""
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.MaskInput = "nnn"
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn12.Width = 62
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance39
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn13.Header.VisiblePosition = 16
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 50
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance40
        UltraGridColumn14.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn14.Format = ""
        UltraGridColumn14.Header.VisiblePosition = 11
        UltraGridColumn14.Width = 59
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn15.CellAppearance = Appearance41
        UltraGridColumn15.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn15.Format = "#,##0.00"
        UltraGridColumn15.Header.VisiblePosition = 12
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn15.Width = 87
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance42
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn16.Format = "#,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn16.Width = 103
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance43
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Format = "#,##0.00"
        UltraGridColumn17.Header.VisiblePosition = 14
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn18.Width = 59
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridSoat.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridSoat.DisplayLayout.MaxColScrollRegions = 1
        Me.GridSoat.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridSoat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridSoat.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridSoat.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridSoat.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridSoat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridSoat.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridSoat.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridSoat.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridSoat.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridSoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSoat.Location = New System.Drawing.Point(215, 139)
        Me.GridSoat.Name = "GridSoat"
        Me.GridSoat.Size = New System.Drawing.Size(933, 175)
        Me.GridSoat.TabIndex = 9
        Me.GridSoat.Text = "Polizas"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'gridPolizas
        '
        Me.gridPolizas.DataSource = Me.UltraDataSource3
        UltraGridColumn20.Header.VisiblePosition = 0
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Width = 88
        UltraGridColumn22.Header.VisiblePosition = 1
        UltraGridColumn23.Header.Caption = "TipoDoc"
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn23.Width = 65
        UltraGridColumn24.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn24.Header.Caption = "Fec.Emision"
        UltraGridColumn24.Header.VisiblePosition = 4
        UltraGridColumn24.Width = 85
        UltraGridColumn25.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn25.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn25.Header.Caption = "Fec.Venc."
        UltraGridColumn25.Header.VisiblePosition = 5
        UltraGridColumn25.Width = 81
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance44
        UltraGridColumn26.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn26.Format = "#,##0.00"
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn26.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance45
        UltraGridColumn27.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn27.Format = "#,##0.00"
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn28.Header.Caption = "Mon"
        UltraGridColumn28.Header.VisiblePosition = 6
        UltraGridColumn28.Width = 34
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance46
        UltraGridColumn29.Header.VisiblePosition = 9
        UltraGridColumn29.Width = 50
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance47
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn30.Width = 59
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance48
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn31.Format = ""
        UltraGridColumn31.Header.VisiblePosition = 13
        UltraGridColumn31.MaskInput = "nnn"
        UltraGridColumn31.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn31.Width = 62
        UltraGridColumn32.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance49
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn32.Header.VisiblePosition = 16
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.Width = 50
        UltraGridColumn33.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance50
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn33.Format = ""
        UltraGridColumn33.Header.VisiblePosition = 11
        UltraGridColumn33.Width = 59
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance51
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn34.Format = "#,##0.00"
        UltraGridColumn34.Header.VisiblePosition = 12
        UltraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn34.Width = 87
        UltraGridColumn35.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance52
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn35.Format = "#,##0.00"
        UltraGridColumn35.Header.VisiblePosition = 15
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 103
        UltraGridColumn36.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance53
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn36.Format = "#,##0.00"
        UltraGridColumn36.Header.VisiblePosition = 14
        UltraGridColumn36.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn37.Header.VisiblePosition = 17
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn37.Width = 59
        UltraGridColumn38.Header.VisiblePosition = 18
        UltraGridColumn38.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPolizas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridPolizas.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPolizas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPolizas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPolizas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPolizas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPolizas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPolizas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridPolizas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPolizas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPolizas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPolizas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridPolizas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPolizas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPolizas.Location = New System.Drawing.Point(0, 0)
        Me.gridPolizas.Name = "gridPolizas"
        Me.gridPolizas.Size = New System.Drawing.Size(1266, 467)
        Me.gridPolizas.TabIndex = 8
        Me.gridPolizas.Text = "Polizas"
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38})
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1266, 467)
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Grid_Soat)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.UltraPanel2)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(1266, 467)
        Me.UltraPanel1.TabIndex = 0
        '
        'Grid_Soat
        '
        Me.Grid_Soat.DataSource = Me.dsDevengados
        UltraGridColumn39.Header.VisiblePosition = 0
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.Caption = "Empresa Certificadora"
        UltraGridColumn40.Header.VisiblePosition = 1
        UltraGridColumn41.Header.Caption = "Documento"
        UltraGridColumn41.Header.VisiblePosition = 2
        UltraGridColumn41.Width = 82
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Header.VisiblePosition = 3
        UltraGridColumn42.Width = 88
        UltraGridColumn43.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn43.Header.Caption = "F. Emision"
        UltraGridColumn43.Header.VisiblePosition = 4
        UltraGridColumn43.Width = 85
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn44.Header.Caption = "F. Vencimiento"
        UltraGridColumn44.Header.VisiblePosition = 5
        UltraGridColumn44.Width = 81
        UltraGridColumn45.Header.VisiblePosition = 6
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 7
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.ProportionalResize = True
        UltraGridColumn47.Header.VisiblePosition = 8
        UltraGridColumn47.Width = 71
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance54
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Format = "#,##0.00"
        UltraGridColumn48.Header.VisiblePosition = 9
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance55
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn49.Format = "#,##0.00"
        UltraGridColumn49.Header.Caption = "Importe BI"
        UltraGridColumn49.Header.VisiblePosition = 10
        UltraGridColumn49.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn50.Header.VisiblePosition = 11
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.Caption = "Tipo Vehiculo"
        UltraGridColumn51.Header.VisiblePosition = 13
        UltraGridColumn52.Header.VisiblePosition = 12
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn53.CellAppearance = Appearance56
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn53.Header.Caption = "Dias Soat"
        UltraGridColumn53.Header.VisiblePosition = 15
        UltraGridColumn53.Width = 60
        UltraGridColumn54.Header.Caption = "Monto x Dia"
        UltraGridColumn54.Header.VisiblePosition = 14
        UltraGridColumn55.Header.Caption = "Total de Asiento Mes"
        UltraGridColumn55.Header.VisiblePosition = 16
        UltraGridColumn56.Header.VisiblePosition = 17
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56})
        UltraGridBand3.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Soat.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Grid_Soat.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Soat.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Soat.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Soat.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Soat.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Soat.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Soat.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Soat.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Soat.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grid_Soat.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Soat.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Soat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Soat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Soat.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Soat.Name = "Grid_Soat"
        Me.Grid_Soat.Size = New System.Drawing.Size(1266, 366)
        Me.Grid_Soat.TabIndex = 13
        Me.Grid_Soat.Text = "Devengado Mensual para SOATS"
        '
        'dsDevengados
        '
        Me.dsDevengados.Band.Columns.AddRange(New Object() {UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'UltraPanel2
        '
        Me.UltraPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraPanel2.Location = New System.Drawing.Point(0, 366)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(1266, 101)
        Me.UltraPanel2.TabIndex = 0
        '
        'dtpFechaVenc
        '
        Me.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenc.Location = New System.Drawing.Point(679, 21)
        Me.dtpFechaVenc.Name = "dtpFechaVenc"
        Me.dtpFechaVenc.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaVenc.TabIndex = 7
        Me.dtpFechaVenc.Visible = False
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(557, 25)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(119, 14)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Fecha Venc. Mayor a:"
        Me.Etiqueta1.Visible = False
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion1.Controls.Add(Me.dtpFechaVenc)
        Me.Agrupacion1.Controls.Add(Me.chkCalculadora)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion1.Controls.Add(Me.decTC)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.cboMoneda)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion1.Controls.Add(Me.Año1)
        Me.Agrupacion1.Controls.Add(Me.cboMes)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1268, 49)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Seguro Mensual de Interes"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkCalculadora
        '
        Me.chkCalculadora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCalculadora.ForeColor = System.Drawing.Color.Black
        Me.chkCalculadora.Location = New System.Drawing.Point(783, 23)
        Me.chkCalculadora.Name = "chkCalculadora"
        Me.chkCalculadora.Size = New System.Drawing.Size(107, 19)
        Me.chkCalculadora.TabIndex = 271
        Me.chkCalculadora.Text = "Todos/Ninguno"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(372, 25)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta6.TabIndex = 21
        Me.Etiqueta6.Text = "T. Cambio:"
        '
        'decTC
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.decTC.Appearance = Appearance16
        Me.decTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTC.ForeColor = System.Drawing.Color.Black
        Me.decTC.FormatString = ""
        Me.decTC.Location = New System.Drawing.Point(442, 20)
        Me.decTC.MaskInput = "{double:6.4}"
        Me.decTC.Name = "decTC"
        Me.decTC.NullText = "0.00"
        Me.decTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTC.Size = New System.Drawing.Size(100, 21)
        Me.decTC.TabIndex = 20
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(216, 24)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta5.TabIndex = 18
        Me.Etiqueta5.Text = "Moneda:"
        '
        'cboMoneda
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance20
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(270, 20)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(79, 21)
        Me.cboMoneda.TabIndex = 17
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta7
        '
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
        Me.Año1.Año = 2013
        Me.Año1.Controls.Add(Me.numAño)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Controls.Add(Me.NumeroEntero2)
        Me.Año1.Controls.Add(Me.NumeroEntero3)
        Me.Año1.Location = New System.Drawing.Point(61, 21)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(54, 23)
        Me.Año1.TabIndex = 4
        '
        'numAño
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance63
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
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance64
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
        Me.NumeroEntero1.Value = 2012
        '
        'NumeroEntero2
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance67
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
        'NumeroEntero3
        '
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance69
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2011
        '
        'cboMes
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance71
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(154, 21)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(59, 21)
        Me.cboMes.TabIndex = 5
        Me.cboMes.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(7, 25)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'tcSeguros
        '
        Me.tcSeguros.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcSeguros.Controls.Add(Me.UltraTabPageControl2)
        Me.tcSeguros.Controls.Add(Me.UltraTabPageControl5)
        Me.tcSeguros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcSeguros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcSeguros.Location = New System.Drawing.Point(0, 49)
        Me.tcSeguros.Name = "tcSeguros"
        Me.tcSeguros.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcSeguros.Size = New System.Drawing.Size(1268, 490)
        Me.tcSeguros.TabIndex = 7
        UltraTab6.Key = "Polizas"
        UltraTab6.TabPage = Me.UltraTabPageControl2
        UltraTab6.Text = "Polizas"
        UltraTab5.Key = "Soat"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Soat"
        Me.tcSeguros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab5})
        Me.tcSeguros.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1266, 467)
        '
        'tcComprobanteCompra
        '
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabPageControl1)
        Me.tcComprobanteCompra.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcComprobanteCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteCompra.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteCompra.Name = "tcComprobanteCompra"
        Me.tcComprobanteCompra.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcComprobanteCompra.Size = New System.Drawing.Size(200, 100)
        Me.tcComprobanteCompra.TabIndex = 0
        Me.tcComprobanteCompra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridComprobanteCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1262, 6)
        '
        'gridComprobanteCompra
        '
        Me.gridComprobanteCompra.DisplayLayout.MaxColScrollRegions = 1
        Me.gridComprobanteCompra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridComprobanteCompra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridComprobanteCompra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridComprobanteCompra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridComprobanteCompra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridComprobanteCompra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridComprobanteCompra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridComprobanteCompra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridComprobanteCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridComprobanteCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridComprobanteCompra.Location = New System.Drawing.Point(0, 55)
        Me.gridComprobanteCompra.Name = "gridComprobanteCompra"
        Me.gridComprobanteCompra.Size = New System.Drawing.Size(1262, -49)
        Me.gridComprobanteCompra.TabIndex = 3
        Me.gridComprobanteCompra.Text = "Comprobante Compra"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.btn_Extornar)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion4.Controls.Add(Me.Combo1)
        Me.Agrupacion4.Controls.Add(Me.Año2)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1262, 55)
        Me.Agrupacion4.TabIndex = 4
        Me.Agrupacion4.Text = "Busca"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btn_Extornar
        '
        Appearance29.Image = 5
        Me.btn_Extornar.Appearance = Appearance29
        Me.btn_Extornar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_Extornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Extornar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Extornar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Extornar.ForeColor = System.Drawing.Color.Black
        Me.btn_Extornar.Location = New System.Drawing.Point(1145, 18)
        Me.btn_Extornar.Name = "btn_Extornar"
        Me.btn_Extornar.Size = New System.Drawing.Size(115, 35)
        Me.btn_Extornar.TabIndex = 8
        Me.btn_Extornar.Text = "Extornar Envio"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(121, 30)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Mes:"
        '
        'Combo1
        '
        Appearance1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Combo1.Appearance = Appearance1
        Me.Combo1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.Combo1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo1.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.Combo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Combo1.Location = New System.Drawing.Point(154, 26)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(71, 21)
        Me.Combo1.TabIndex = 5
        Me.Combo1.ValueMember = "Id"
        '
        'Año2
        '
        Me.Año2.Año = 2013
        Me.Año2.Controls.Add(Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2)
        Me.Año2.Controls.Add(Me.NumeroEntero4)
        Me.Año2.Controls.Add(Me.NumeroEntero5)
        Me.Año2.Location = New System.Drawing.Point(61, 26)
        Me.Año2.Name = "Año2"
        Me.Año2.Size = New System.Drawing.Size(54, 23)
        Me.Año2.TabIndex = 4
        '
        'object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Appearance = Appearance32
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.ForeColor = System.Drawing.Color.Black
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.FormatString = ""
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Location = New System.Drawing.Point(1, 0)
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.MaskInput = "nnnn"
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.MaxValue = 2020
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.MinValue = 2000
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Name = "object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2"
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.NullText = "0"
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Size = New System.Drawing.Size(52, 21)
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.TabIndex = 0
        Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2.Value = 2012
        '
        'NumeroEntero4
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance15
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2011
        '
        'NumeroEntero5
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance31
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2011
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(7, 30)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta4.TabIndex = 3
        Me.Etiqueta4.Text = "Ejercicio:"
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(198, 79)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(198, 79)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(200, 110)
        Me.Agrupacion5.TabIndex = 0
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 82)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridDetalleAsientoAnalisis)
        Me.SplitContainer1.Size = New System.Drawing.Size(150, 100)
        Me.SplitContainer1.TabIndex = 0
        '
        'gridDetalleAsientoAnalisis
        '
        Me.gridDetalleAsientoAnalisis.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDetalleAsientoAnalisis.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDetalleAsientoAnalisis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetalleAsientoAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDetalleAsientoAnalisis.Location = New System.Drawing.Point(0, 0)
        Me.gridDetalleAsientoAnalisis.Name = "gridDetalleAsientoAnalisis"
        Me.gridDetalleAsientoAnalisis.Size = New System.Drawing.Size(150, 50)
        Me.gridDetalleAsientoAnalisis.TabIndex = 45
        '
        'tcComprobanteDetalle
        '
        Me.tcComprobanteDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcComprobanteDetalle.Location = New System.Drawing.Point(0, 0)
        Me.tcComprobanteDetalle.Name = "tcComprobanteDetalle"
        Me.tcComprobanteDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tcComprobanteDetalle.Size = New System.Drawing.Size(200, 100)
        Me.tcComprobanteDetalle.TabIndex = 0
        Me.tcComprobanteDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(198, 79)
        '
        'frm_DevengadoMensualSeguros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1268, 539)
        Me.Controls.Add(Me.tcSeguros)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_DevengadoMensualSeguros"
        Me.Text = "Seguro Mensual de Interes"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.GridSoat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPolizas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.Grid_Soat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDevengados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel2.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.chkCalculadora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcSeguros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcSeguros.ResumeLayout(False)
        CType(Me.tcComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcComprobanteCompra.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.gridComprobanteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.Combo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año2.ResumeLayout(False)
        Me.Año2.PerformLayout()
        CType(Me.object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridDetalleAsientoAnalisis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcComprobanteDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents tcSeguros As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFechaVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents gridPolizas As ISL.Controles.Grilla
    Friend WithEvents tcComprobanteCompra As ISL.Controles.Ficha
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridComprobanteCompra As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btn_Extornar As ISL.Controles.Boton
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Combo1 As ISL.Controles.Combo
    Friend WithEvents Año2 As ISL.Win.Año
    Friend WithEvents object_57158d3d_d3b2_4f5d_9bd2_ecf08f0353b2 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gridDetalleAsientoAnalisis As ISL.Controles.Grilla
    Friend WithEvents tcComprobanteDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents decTC As ISL.Controles.NumeroDecimal
    Friend WithEvents GridSoat As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents chkCalculadora As ISL.Controles.Chequear
    Friend WithEvents dsDevengados As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Grid_Soat As ISL.Controles.Grilla
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel

End Class
