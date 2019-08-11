<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Fec
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaBanco")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuotas")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoMN")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoME")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaInteres")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContratoFinanciero")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresCompensatorio")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDsctoInteres")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1370)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-271)
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
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim ColScrollRegion3 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1370)
        Dim ColScrollRegion4 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-271)
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grilla = New ISL.Controles.Agrupacion(Me.components)
        Me.GrDocumentos = New ISL.Controles.Grilla(Me.components)
        Me.OrgDocumentosFec = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.fecFin = New System.Windows.Forms.DateTimePicker()
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gridDocumentosAgregados = New ISL.Controles.Grilla(Me.components)
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gridDocumentosxPagar = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboProveedorFactura = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.btnConsultar = New ISL.Controles.Boton(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboProveedor = New ISL.Controles.Combo(Me.components)
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.NumCalc = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.txt_Glosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.decMontoDolar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoSoles = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteSoles = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.EtiImporteDolares = New ISL.Controles.Etiqueta(Me.components)
        Me.LblTotalPagar = New ISL.Controles.Etiqueta(Me.components)
        Me.DecInteresMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtUnico = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTasaInt = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecFecha = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tcFec = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grilla.SuspendLayout()
        CType(Me.GrDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.gridDocumentosAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregados.SuspendLayout()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDocumentosxPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboProveedorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.NumCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.decMontoDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoSoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecInteresMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTasaInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcFec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcFec.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Grilla)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1108, 504)
        '
        'Grilla
        '
        Me.Grilla.BorderStyle = Infragistics.Win.Misc.GroupBoxBorderStyle.None
        Me.Grilla.Controls.Add(Me.GrDocumentos)
        Me.Grilla.Controls.Add(Me.Agrupacion1)
        Me.Grilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla.ForeColor = System.Drawing.Color.Black
        Me.Grilla.Location = New System.Drawing.Point(0, 0)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(1108, 504)
        Me.Grilla.TabIndex = 3
        Me.Grilla.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GrDocumentos
        '
        Me.GrDocumentos.DataSource = Me.OrgDocumentosFec
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Empresa"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.Caption = "Moneda"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Width = 56
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance1
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.Caption = "TC"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 51
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance2
        UltraGridColumn11.Format = "#,##0.00"
        UltraGridColumn11.Header.VisiblePosition = 10
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance3
        UltraGridColumn12.Format = "#,##0.00"
        UltraGridColumn12.Header.VisiblePosition = 11
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn13.CellAppearance = Appearance4
        UltraGridColumn13.Format = "#,##0.00"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance5
        UltraGridColumn16.Format = "#,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridColumn27.Header.VisiblePosition = 9
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 12
        UltraGridColumn31.Header.VisiblePosition = 13
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31})
        Me.GrDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GrDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GrDocumentos.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.GrDocumentos.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.GrDocumentos.DisplayLayout.MaxColScrollRegions = 1
        Me.GrDocumentos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GrDocumentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GrDocumentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GrDocumentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GrDocumentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GrDocumentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GrDocumentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GrDocumentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GrDocumentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GrDocumentos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GrDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrDocumentos.Location = New System.Drawing.Point(0, 33)
        Me.GrDocumentos.Name = "GrDocumentos"
        Me.GrDocumentos.Size = New System.Drawing.Size(1108, 471)
        Me.GrDocumentos.TabIndex = 8
        Me.GrDocumentos.Text = "FEC"
        '
        'OrgDocumentosFec
        '
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        Me.OrgDocumentosFec.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Integer)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Double)
        Me.OrgDocumentosFec.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.fecFin)
        Me.Agrupacion1.Controls.Add(Me.fecInicio)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1108, 33)
        Me.Agrupacion1.TabIndex = 9
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fecFin
        '
        Me.fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFin.Location = New System.Drawing.Point(236, 7)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(94, 20)
        Me.fecFin.TabIndex = 3
        '
        'fecInicio
        '
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(82, 7)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(94, 20)
        Me.fecInicio.TabIndex = 2
        '
        'Etiqueta13
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance6
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(182, 10)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(48, 14)
        Me.Etiqueta13.TabIndex = 1
        Me.Etiqueta13.Text = "Fec. Fin:"
        '
        'Etiqueta11
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance7
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(14, 10)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta11.TabIndex = 0
        Me.Etiqueta11.Text = "Fec. Inicio:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl1.Enabled = False
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1108, 504)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 105)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gridDocumentosAgregados)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridDocumentosxPagar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1108, 399)
        Me.SplitContainer1.SplitterDistance = 199
        Me.SplitContainer1.TabIndex = 10
        '
        'gridDocumentosAgregados
        '
        Me.gridDocumentosAgregados.ContextMenuStrip = Me.MenuAgregados
        Me.gridDocumentosAgregados.DataSource = Me.UltraDataSource2
        UltraGridColumn129.Header.VisiblePosition = 0
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.Caption = "Periodo"
        UltraGridColumn130.Header.VisiblePosition = 1
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn131.Header.Caption = "TipoDoc"
        UltraGridColumn131.Header.VisiblePosition = 4
        UltraGridColumn131.Width = 70
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn132.Header.VisiblePosition = 5
        UltraGridColumn132.Width = 73
        UltraGridColumn133.Header.VisiblePosition = 6
        UltraGridColumn133.Width = 101
        UltraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn134.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn134.Header.VisiblePosition = 7
        UltraGridColumn134.Width = 99
        UltraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn135.Header.VisiblePosition = 8
        UltraGridColumn136.Header.VisiblePosition = 9
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 18
        UltraGridColumn137.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn138.CellAppearance = Appearance8
        UltraGridColumn138.Format = "#,##0.00"
        UltraGridColumn138.Header.VisiblePosition = 11
        UltraGridColumn138.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn139.CellAppearance = Appearance9
        UltraGridColumn139.Format = "#,##0.00"
        UltraGridColumn139.Header.VisiblePosition = 12
        UltraGridColumn139.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn140.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn140.Header.Caption = "Proveedor"
        UltraGridColumn140.Header.VisiblePosition = 3
        UltraGridColumn140.Width = 283
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn141.Header.VisiblePosition = 13
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 14
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn143.Header.Caption = "Tipo"
        UltraGridColumn143.Header.VisiblePosition = 2
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn144.Header.Caption = "Mon."
        UltraGridColumn144.Header.VisiblePosition = 10
        UltraGridColumn144.Width = 44
        UltraGridColumn145.Header.VisiblePosition = 15
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.Header.VisiblePosition = 16
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 17
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 19
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 25
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn150.Header.VisiblePosition = 20
        UltraGridColumn150.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn151.CellAppearance = Appearance10
        UltraGridColumn151.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn151.Format = "#,##0.00"
        UltraGridColumn151.Header.Caption = "Monto Aplicar"
        UltraGridColumn151.Header.VisiblePosition = 21
        UltraGridColumn151.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn152.Header.VisiblePosition = 22
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 23
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 24
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 26
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 27
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 28
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 29
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 30
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 31
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 32
        UltraGridColumn161.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161})
        UltraGridBand3.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosAgregados.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.gridDocumentosAgregados.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentosAgregados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosAgregados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentosAgregados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentosAgregados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentosAgregados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentosAgregados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentosAgregados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentosAgregados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentosAgregados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosAgregados.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentosAgregados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentosAgregados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentosAgregados.Location = New System.Drawing.Point(0, 0)
        Me.gridDocumentosAgregados.Name = "gridDocumentosAgregados"
        Me.gridDocumentosAgregados.Size = New System.Drawing.Size(1108, 199)
        Me.gridDocumentosAgregados.TabIndex = 9
        Me.gridDocumentosAgregados.Text = "Aplicacion"
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
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'gridDocumentosxPagar
        '
        Me.gridDocumentosxPagar.ContextMenuStrip = Me.MenuDetalle
        Me.gridDocumentosxPagar.DataSource = Me.UltraDataSource1
        UltraGridColumn162.Header.VisiblePosition = 0
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.Caption = "Periodo"
        UltraGridColumn163.Header.VisiblePosition = 1
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.Caption = "TipoDoc"
        UltraGridColumn164.Header.VisiblePosition = 4
        UltraGridColumn164.Width = 72
        UltraGridColumn165.Header.VisiblePosition = 5
        UltraGridColumn165.Width = 71
        UltraGridColumn166.Header.VisiblePosition = 6
        UltraGridColumn166.Width = 104
        UltraGridColumn167.Header.VisiblePosition = 7
        UltraGridColumn167.Width = 99
        UltraGridColumn168.Header.VisiblePosition = 8
        UltraGridColumn169.Header.VisiblePosition = 9
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 10
        UltraGridColumn170.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn171.CellAppearance = Appearance11
        UltraGridColumn171.Format = "#,##0.00"
        UltraGridColumn171.Header.VisiblePosition = 12
        UltraGridColumn171.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn172.CellAppearance = Appearance12
        UltraGridColumn172.Format = "#,##0.00"
        UltraGridColumn172.Header.VisiblePosition = 13
        UltraGridColumn172.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn173.Header.Caption = "Proveedor"
        UltraGridColumn173.Header.VisiblePosition = 3
        UltraGridColumn173.Width = 282
        UltraGridColumn174.Header.VisiblePosition = 14
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 15
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.Caption = "Tipo"
        UltraGridColumn176.Header.VisiblePosition = 2
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.Caption = "Mon."
        UltraGridColumn177.Header.VisiblePosition = 11
        UltraGridColumn177.Width = 40
        UltraGridColumn178.Header.VisiblePosition = 16
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 17
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 18
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 19
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 21
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 22
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 20
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.VisiblePosition = 23
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.Header.VisiblePosition = 24
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.VisiblePosition = 25
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 26
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 27
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 28
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 29
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 30
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 32
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 31
        UltraGridColumn194.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194})
        Me.gridDocumentosxPagar.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.gridDocumentosxPagar.DisplayLayout.ColScrollRegions.Add(ColScrollRegion3)
        Me.gridDocumentosxPagar.DisplayLayout.ColScrollRegions.Add(ColScrollRegion4)
        Me.gridDocumentosxPagar.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentosxPagar.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosxPagar.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentosxPagar.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentosxPagar.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentosxPagar.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentosxPagar.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentosxPagar.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentosxPagar.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentosxPagar.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentosxPagar.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentosxPagar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentosxPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentosxPagar.Location = New System.Drawing.Point(0, 37)
        Me.gridDocumentosxPagar.Name = "gridDocumentosxPagar"
        Me.gridDocumentosxPagar.Size = New System.Drawing.Size(1108, 159)
        Me.gridDocumentosxPagar.TabIndex = 8
        Me.gridDocumentosxPagar.Text = "Documentos x Pagar"
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarDocumento})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(121, 30)
        '
        'AgregarDocumento
        '
        Me.AgregarDocumento.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.AgregarDocumento.Name = "AgregarDocumento"
        Me.AgregarDocumento.Size = New System.Drawing.Size(120, 26)
        Me.AgregarDocumento.Text = "Agregar"
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProveedorFactura)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.Etiqueta31)
        Me.GroupBox1.Controls.Add(Me.cboProveedor)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1108, 37)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cboProveedorFactura
        '
        Me.cboProveedorFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedorFactura.DisplayMember = "Nombre"
        Me.cboProveedorFactura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedorFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorFactura.Location = New System.Drawing.Point(199, 10)
        Me.cboProveedorFactura.Name = "cboProveedorFactura"
        Me.cboProveedorFactura.Size = New System.Drawing.Size(295, 22)
        Me.cboProveedorFactura.TabIndex = 474
        Me.cboProveedorFactura.ValueMember = "Id"
        '
        'btnConsultar
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance13
        Me.btnConsultar.AutoSize = True
        Me.btnConsultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Location = New System.Drawing.Point(500, 8)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(26, 26)
        Me.btnConsultar.TabIndex = 271
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(64, 10)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(129, 21)
        Me.txtRuc.TabIndex = 270
        Me.txtRuc.TabStop = False
        '
        'Etiqueta31
        '
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(6, 13)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta31.TabIndex = 269
        Me.Etiqueta31.Text = "Proveedor:"
        '
        'cboProveedor
        '
        Appearance14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProveedor.Appearance = Appearance14
        Me.cboProveedor.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownListWidth = 400
        Me.cboProveedor.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboProveedor.Location = New System.Drawing.Point(532, 11)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(208, 21)
        Me.cboProveedor.TabIndex = 268
        Me.cboProveedor.ValueMember = "Id"
        Me.cboProveedor.Visible = False
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.NumCalc)
        Me.Agrupacion12.Controls.Add(Me.txt_Glosa)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion12.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion12.Controls.Add(Me.LblTotalPagar)
        Me.Agrupacion12.Controls.Add(Me.DecInteresMonto)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion12.Controls.Add(Me.CboBanco)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion12.Controls.Add(Me.DecSubTotal)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion12.Controls.Add(Me.TxtUnico)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion12.Controls.Add(Me.CboMoneda)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion12.Controls.Add(Me.DecTasaInt)
        Me.Agrupacion12.Controls.Add(Me.DecTC)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion12.Controls.Add(Me.FecVencimiento)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion12.Controls.Add(Me.FecFecha)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1108, 105)
        Me.Agrupacion12.TabIndex = 1
        Me.Agrupacion12.Text = "FEC"
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'NumCalc
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.NumCalc.Appearance = Appearance15
        Me.NumCalc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCalc.ForeColor = System.Drawing.Color.Black
        Me.NumCalc.Location = New System.Drawing.Point(745, 49)
        Me.NumCalc.Name = "NumCalc"
        Me.NumCalc.Size = New System.Drawing.Size(12, 21)
        Me.NumCalc.TabIndex = 54
        Me.NumCalc.Text = "0"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Glosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Glosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.Location = New System.Drawing.Point(70, 77)
        Me.txt_Glosa.MaxLength = 200
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(539, 21)
        Me.txt_Glosa.TabIndex = 16
        '
        'Etiqueta2
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.FontData.BoldAsString = "True"
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance16
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(27, 80)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta2.TabIndex = 53
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.decMontoDolar)
        Me.Agrupacion4.Controls.Add(Me.decMontoSoles)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion4.Controls.Add(Me.EtiImporteSoles)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion4.Controls.Add(Me.EtiImporteDolares)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(898, 18)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(208, 85)
        Me.Agrupacion4.TabIndex = 52
        Me.Agrupacion4.Text = "Total de Documentos"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decMontoDolar
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.decMontoDolar.Appearance = Appearance17
        Me.decMontoDolar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoDolar.Enabled = False
        Me.decMontoDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoDolar.ForeColor = System.Drawing.Color.Black
        Me.decMontoDolar.Location = New System.Drawing.Point(69, 55)
        Me.decMontoDolar.Name = "decMontoDolar"
        Me.decMontoDolar.NullText = "0.00"
        Me.decMontoDolar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoDolar.ReadOnly = True
        Me.decMontoDolar.Size = New System.Drawing.Size(100, 21)
        Me.decMontoDolar.TabIndex = 39
        '
        'decMontoSoles
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.decMontoSoles.Appearance = Appearance18
        Me.decMontoSoles.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoSoles.Enabled = False
        Me.decMontoSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoSoles.ForeColor = System.Drawing.Color.Black
        Me.decMontoSoles.Location = New System.Drawing.Point(69, 28)
        Me.decMontoSoles.Name = "decMontoSoles"
        Me.decMontoSoles.NullText = "0.00"
        Me.decMontoSoles.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoSoles.ReadOnly = True
        Me.decMontoSoles.Size = New System.Drawing.Size(100, 21)
        Me.decMontoSoles.TabIndex = 38
        '
        'Etiqueta3
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.FontData.BoldAsString = "True"
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance19
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(5, 33)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta3.TabIndex = 20
        Me.Etiqueta3.Text = "Importe S/"
        '
        'EtiImporteSoles
        '
        Me.EtiImporteSoles.AutoSize = True
        Me.EtiImporteSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteSoles.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteSoles.Location = New System.Drawing.Point(188, 36)
        Me.EtiImporteSoles.Name = "EtiImporteSoles"
        Me.EtiImporteSoles.Size = New System.Drawing.Size(11, 14)
        Me.EtiImporteSoles.TabIndex = 35
        Me.EtiImporteSoles.Text = "0"
        Me.EtiImporteSoles.Visible = False
        '
        'Etiqueta9
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.FontData.BoldAsString = "True"
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance20
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(4, 60)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta9.TabIndex = 36
        Me.Etiqueta9.Text = "Importe $"
        '
        'EtiImporteDolares
        '
        Me.EtiImporteDolares.AutoSize = True
        Me.EtiImporteDolares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiImporteDolares.ForeColor = System.Drawing.Color.Black
        Me.EtiImporteDolares.Location = New System.Drawing.Point(188, 59)
        Me.EtiImporteDolares.Name = "EtiImporteDolares"
        Me.EtiImporteDolares.Size = New System.Drawing.Size(11, 14)
        Me.EtiImporteDolares.TabIndex = 37
        Me.EtiImporteDolares.Text = "0"
        Me.EtiImporteDolares.Visible = False
        '
        'LblTotalPagar
        '
        Me.LblTotalPagar.AutoSize = True
        Me.LblTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPagar.ForeColor = System.Drawing.Color.Black
        Me.LblTotalPagar.Location = New System.Drawing.Point(796, 49)
        Me.LblTotalPagar.Name = "LblTotalPagar"
        Me.LblTotalPagar.Size = New System.Drawing.Size(27, 14)
        Me.LblTotalPagar.TabIndex = 5
        Me.LblTotalPagar.Text = "0.00"
        '
        'DecInteresMonto
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.DecInteresMonto.Appearance = Appearance21
        Me.DecInteresMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecInteresMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecInteresMonto.ForeColor = System.Drawing.Color.Black
        Me.DecInteresMonto.Location = New System.Drawing.Point(688, 76)
        Me.DecInteresMonto.Name = "DecInteresMonto"
        Me.DecInteresMonto.NullText = "0.00"
        Me.DecInteresMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecInteresMonto.Size = New System.Drawing.Size(100, 21)
        Me.DecInteresMonto.TabIndex = 19
        '
        'Etiqueta12
        '
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(796, 25)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta12.TabIndex = 47
        Me.Etiqueta12.Text = "Total A Pagar"
        '
        'Etiqueta15
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.FontData.BoldAsString = "True"
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance22
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(628, 81)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta15.TabIndex = 49
        Me.Etiqueta15.Text = "Monto Int.:"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(761, 53)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta6.TabIndex = 50
        Me.Etiqueta6.Text = "%"
        '
        'CboBanco
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.CboBanco.Appearance = Appearance23
        Me.CboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboBanco.DropDownListWidth = 600
        Me.CboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBanco.ForeColor = System.Drawing.Color.Black
        Me.CboBanco.Location = New System.Drawing.Point(216, 23)
        Me.CboBanco.Name = "CboBanco"
        Me.CboBanco.Size = New System.Drawing.Size(238, 21)
        Me.CboBanco.TabIndex = 11
        Me.CboBanco.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.FontData.BoldAsString = "True"
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance24
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(175, 27)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta14.TabIndex = 43
        Me.Etiqueta14.Text = "Banco:"
        '
        'DecSubTotal
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.DecSubTotal.Appearance = Appearance25
        Me.DecSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSubTotal.Enabled = False
        Me.DecSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSubTotal.ForeColor = System.Drawing.Color.Black
        Me.DecSubTotal.Location = New System.Drawing.Point(688, 23)
        Me.DecSubTotal.Name = "DecSubTotal"
        Me.DecSubTotal.NullText = "0.00"
        Me.DecSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSubTotal.Size = New System.Drawing.Size(100, 21)
        Me.DecSubTotal.TabIndex = 17
        '
        'Etiqueta10
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance26
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(629, 27)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta10.TabIndex = 14
        Me.Etiqueta10.Text = "SubTotal:"
        '
        'TxtUnico
        '
        Me.TxtUnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnico.Location = New System.Drawing.Point(70, 23)
        Me.TxtUnico.MaxLength = 50
        Me.TxtUnico.Name = "TxtUnico"
        Me.TxtUnico.Size = New System.Drawing.Size(101, 21)
        Me.TxtUnico.TabIndex = 10
        '
        'Etiqueta5
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance27
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(4, 27)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta5.TabIndex = 40
        Me.Etiqueta5.Text = "Nro Unico:"
        '
        'CboMoneda
        '
        Appearance28.ForeColor = System.Drawing.Color.Black
        Me.CboMoneda.Appearance = Appearance28
        Me.CboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboMoneda.DropDownListWidth = 150
        Me.CboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMoneda.ForeColor = System.Drawing.Color.Black
        Me.CboMoneda.Location = New System.Drawing.Point(514, 24)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(95, 21)
        Me.CboMoneda.TabIndex = 14
        Me.CboMoneda.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.FontData.BoldAsString = "True"
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance29
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(460, 27)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta1.TabIndex = 39
        Me.Etiqueta1.Text = "Moneda:"
        '
        'DecTasaInt
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInt.Appearance = Appearance30
        Me.DecTasaInt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTasaInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTasaInt.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInt.Location = New System.Drawing.Point(688, 49)
        Me.DecTasaInt.MaskInput = "{double:3.4}"
        Me.DecTasaInt.Name = "DecTasaInt"
        Me.DecTasaInt.NullText = "0.00"
        Me.DecTasaInt.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTasaInt.Size = New System.Drawing.Size(56, 21)
        Me.DecTasaInt.TabIndex = 18
        '
        'DecTC
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance31
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(368, 49)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(86, 21)
        Me.DecTC.TabIndex = 15
        Me.DecTC.Value = 3.5R
        '
        'Etiqueta8
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.FontData.BoldAsString = "True"
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance32
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(629, 55)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta8.TabIndex = 13
        Me.Etiqueta8.Text = "Tasa:"
        '
        'FecVencimiento
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Appearance = Appearance33
        Me.FecVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Location = New System.Drawing.Point(216, 50)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.Size = New System.Drawing.Size(82, 21)
        Me.FecVencimiento.TabIndex = 13
        '
        'Etiqueta4
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.FontData.BoldAsString = "True"
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance34
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(309, 52)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(59, 14)
        Me.Etiqueta4.TabIndex = 29
        Me.Etiqueta4.Text = "T. Camb. :"
        '
        'FecFecha
        '
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Appearance = Appearance35
        Me.FecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Location = New System.Drawing.Point(70, 50)
        Me.FecFecha.Name = "FecFecha"
        Me.FecFecha.Size = New System.Drawing.Size(87, 21)
        Me.FecFecha.TabIndex = 12
        '
        'Etiqueta7
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.FontData.BoldAsString = "True"
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance36
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(165, 54)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta7.TabIndex = 12
        Me.Etiqueta7.Text = "F. Venc.:"
        '
        'Etiqueta18
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.FontData.BoldAsString = "True"
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance37
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(24, 53)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta18.TabIndex = 11
        Me.Etiqueta18.Text = "Fecha:"
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tcFec
        '
        Me.tcFec.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcFec.Controls.Add(Me.UltraTabPageControl2)
        Me.tcFec.Controls.Add(Me.UltraTabPageControl1)
        Me.tcFec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcFec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFec.Location = New System.Drawing.Point(0, 0)
        Me.tcFec.Name = "tcFec"
        Me.tcFec.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcFec.Size = New System.Drawing.Size(1110, 527)
        Me.tcFec.TabIndex = 0
        UltraTab2.Key = "ListaFec"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Lista de Oblig. FEC"
        UltraTab1.Key = "Finanzas - FEC"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Finanzas - FEC"
        Me.tcFec.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1})
        Me.tcFec.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1108, 504)
        '
        'frm_Fec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 527)
        Me.Controls.Add(Me.tcFec)
        Me.Name = "frm_Fec"
        Me.Text = "FEC - PAGO DE DEUDAS"
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grilla.ResumeLayout(False)
        CType(Me.GrDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.gridDocumentosAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDocumentosxPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cboProveedorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        Me.Agrupacion12.PerformLayout()
        CType(Me.NumCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.decMontoDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoSoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecInteresMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTasaInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcFec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcFec.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcFec As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grilla As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents DecInteresMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents LblTotalPagar As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecTasaInt As ISL.Controles.NumeroDecimal
    Friend WithEvents DecSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents FecVencimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents CboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents TxtUnico As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents CboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteDolares As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents EtiImporteSoles As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents FecFecha As ISL.Controles.Fecha
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents OrgDocumentosFec As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents gridDocumentosxPagar As ISL.Controles.Grilla
    Friend WithEvents gridDocumentosAgregados As ISL.Controles.Grilla
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txt_Glosa As ISL.Controles.Texto
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents NumCalc As ISL.Controles.NumeroCalculadora
    Friend WithEvents GrDocumentos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents cboProveedor As ISL.Controles.Combo
    Friend WithEvents btnConsultar As ISL.Controles.Boton
    Friend WithEvents cboProveedorFactura As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents decMontoDolar As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoSoles As ISL.Controles.NumeroDecimal
    Friend WithEvents fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
End Class
