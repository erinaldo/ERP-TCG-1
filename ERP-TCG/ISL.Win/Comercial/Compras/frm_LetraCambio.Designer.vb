<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LetraCambio
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaBanco")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuotas")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoMN")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoME")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaInteres")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContratoFinanciero")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresCompensatorio")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDsctoInteres")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LetraCambio))
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCanje")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RetencionMN")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RetencionME")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoObligacion")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1384)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-625)
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
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoObligacion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOrdenCompra = New ISL.Controles.Agrupacion(Me.components)
        Me.GridObligacionLetras = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.DsLetras = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.DtpFechaEmisionFinal = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaEmisionInicial = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.LblInfo = New Infragistics.Win.Misc.UltraLabel()
        Me.ChkMoratorio = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFacturas = New ISL.Controles.Grilla(Me.components)
        Me.odListadoDocumentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion16 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboProveedorFactura = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.DtpFacturaHasta = New System.Windows.Forms.DateTimePicker()
        Me.DtpFacturaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnListarMateriales = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraToolbarsDockArea29 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea30 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea31 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea32 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea33 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea34 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea35 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea36 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea37 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea38 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea39 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea40 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea41 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea42 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea43 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea44 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea45 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea46 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea47 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea48 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.Espere1 = New ISL.Win.Espere()
        Me.griFacturaAgregadas = New ISL.Controles.Grilla(Me.components)
        Me.UltraToolbarsDockArea13 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea14 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea17 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea18 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea25 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea26 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea27 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea28 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea19 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea22 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea23 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea24 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea5 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea6 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea7 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea8 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.AgrupLetras = New ISL.Controles.Agrupacion(Me.components)
        Me.GridLetras = New ISL.Controles.Grilla(Me.components)
        Me.AgrupInfLetra = New ISL.Controles.Agrupacion(Me.components)
        Me.ndTotalContratoME = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.ndTotalContratoMN = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkRetencion = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnQuitar = New ISL.Controles.Boton(Me.components)
        Me.fecFechaEmision = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.btnAgregar = New ISL.Controles.Boton(Me.components)
        Me.fecFechaVencimiento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.txtMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecContrato = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboBanco = New ISL.Controles.Combo(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.lbl_etiqueta = New ISL.Controles.Etiqueta(Me.components)
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.odListadoFacturaLetras = New ISL.Controles.OrigenDatos(Me.components)
        Me.OrgDocumentosFec = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.FiltroLetras = New ISL.Controles.Filtro(Me.components)
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ficLetra = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ToolTipAyudaActualizacion = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenCompra.SuspendLayout()
        CType(Me.GridObligacionLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.ChkMoratorio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion16.SuspendLayout()
        CType(Me.cboProveedorFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.griFacturaAgregadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.AgrupLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgrupLetras.SuspendLayout()
        CType(Me.GridLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgrupInfLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgrupInfLetra.SuspendLayout()
        CType(Me.ndTotalContratoME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndTotalContratoMN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.chkRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListadoFacturaLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregados.SuspendLayout()
        CType(Me.ficLetra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficLetra.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrOrdenCompra)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1346, 618)
        '
        'agrOrdenCompra
        '
        Me.agrOrdenCompra.Controls.Add(Me.GridObligacionLetras)
        Me.agrOrdenCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenCompra.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenCompra.Location = New System.Drawing.Point(0, 87)
        Me.agrOrdenCompra.Name = "agrOrdenCompra"
        Me.agrOrdenCompra.Size = New System.Drawing.Size(1346, 531)
        Me.agrOrdenCompra.TabIndex = 2
        Me.agrOrdenCompra.Text = "LISTADO DE LETRAS"
        Me.agrOrdenCompra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GridObligacionLetras
        '
        Me.GridObligacionLetras.DataSource = Me.DsLetras
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.GridObligacionLetras.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.Caption = "Entidad Bancaria"
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Width = 238
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Width = 117
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn24.Width = 122
        UltraGridColumn25.Header.VisiblePosition = 6
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 7
        UltraGridColumn27.Header.Caption = "Moneda"
        UltraGridColumn27.Header.VisiblePosition = 8
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance2
        UltraGridColumn28.Format = "#,##0.00"
        UltraGridColumn28.Header.VisiblePosition = 9
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance3
        UltraGridColumn29.Format = "#,##0.00"
        UltraGridColumn29.Header.VisiblePosition = 10
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance4
        UltraGridColumn30.Format = "#,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 11
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance5
        UltraGridColumn31.Format = "#,##0.00"
        UltraGridColumn31.Header.VisiblePosition = 12
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 13
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 14
        UltraGridColumn33.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance6
        UltraGridColumn34.Format = "#,##0.00"
        UltraGridColumn34.Header.VisiblePosition = 15
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 16
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.VisiblePosition = 2
        UltraGridColumn38.Width = 96
        UltraGridColumn39.Header.VisiblePosition = 3
        UltraGridColumn39.Width = 114
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn40.Width = 189
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance7
        UltraGridColumn41.Format = "#,##0.00"
        UltraGridColumn41.Header.VisiblePosition = 5
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance8
        UltraGridColumn42.Format = "#,##0.00"
        UltraGridColumn42.Header.VisiblePosition = 6
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance9
        UltraGridColumn43.Format = "#,##0.00"
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance10
        UltraGridColumn44.Format = "#,##0.00"
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance11
        UltraGridColumn45.Format = "#,##0.00"
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance12
        UltraGridColumn46.Format = "#,##0.00"
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.Hidden = True
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance13
        UltraGridColumn48.Format = "#,##0.00"
        UltraGridColumn48.Header.VisiblePosition = 12
        UltraGridColumn48.Hidden = True
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance14
        UltraGridColumn49.Format = "#,##0.00"
        UltraGridColumn49.Header.VisiblePosition = 13
        UltraGridColumn49.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        Me.GridObligacionLetras.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridObligacionLetras.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GridObligacionLetras.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.GridObligacionLetras.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance15.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance15.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance15.BorderColor = System.Drawing.SystemColors.Window
        Me.GridObligacionLetras.DisplayLayout.GroupByBox.Appearance = Appearance15
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridObligacionLetras.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance16
        Me.GridObligacionLetras.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance17.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance17.BackColor2 = System.Drawing.SystemColors.Control
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.ForeColor = System.Drawing.SystemColors.GrayText
        Me.GridObligacionLetras.DisplayLayout.GroupByBox.PromptAppearance = Appearance17
        Me.GridObligacionLetras.DisplayLayout.MaxColScrollRegions = 1
        Me.GridObligacionLetras.DisplayLayout.MaxRowScrollRegions = 1
        Me.GridObligacionLetras.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GridObligacionLetras.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridObligacionLetras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.GridObligacionLetras.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridObligacionLetras.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GridObligacionLetras.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.GridObligacionLetras.DisplayLayout.Override.RowAppearance = Appearance18
        Me.GridObligacionLetras.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridObligacionLetras.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.GridObligacionLetras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GridObligacionLetras.DisplayLayout.Override.TemplateAddRowAppearance = Appearance19
        Me.GridObligacionLetras.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.GridObligacionLetras.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GridObligacionLetras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridObligacionLetras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridObligacionLetras.ImageList = Me.imagenes
        Me.GridObligacionLetras.Location = New System.Drawing.Point(2, 19)
        Me.GridObligacionLetras.Name = "GridObligacionLetras"
        Me.GridObligacionLetras.Size = New System.Drawing.Size(1342, 510)
        Me.GridObligacionLetras.TabIndex = 0
        Me.GridObligacionLetras.Text = "UltraGrid1"
        '
        'DsLetras
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
        Me.DsLetras.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Integer)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Double)
        UltraDataColumn27.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Double)
        Me.DsLetras.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
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
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.UltraGroupBox1)
        Me.Agrupacion1.Controls.Add(Me.UltraPanel1)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1346, 87)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "FILTRO DE BUSQUEDA:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox1
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Appearance = Appearance20
        Me.UltraGroupBox1.Controls.Add(Me.DtpFechaEmisionFinal)
        Me.UltraGroupBox1.Controls.Add(Me.DtpFechaEmisionInicial)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(11, 28)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(343, 51)
        Me.UltraGroupBox1.TabIndex = 350
        Me.UltraGroupBox1.Text = "Fecha de Emisión"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.XP
        '
        'DtpFechaEmisionFinal
        '
        Me.DtpFechaEmisionFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEmisionFinal.Location = New System.Drawing.Point(231, 20)
        Me.DtpFechaEmisionFinal.Name = "DtpFechaEmisionFinal"
        Me.DtpFechaEmisionFinal.Size = New System.Drawing.Size(97, 21)
        Me.DtpFechaEmisionFinal.TabIndex = 344
        '
        'DtpFechaEmisionInicial
        '
        Me.DtpFechaEmisionInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEmisionInicial.Location = New System.Drawing.Point(58, 20)
        Me.DtpFechaEmisionInicial.Name = "DtpFechaEmisionInicial"
        Me.DtpFechaEmisionInicial.Size = New System.Drawing.Size(97, 21)
        Me.DtpFechaEmisionInicial.TabIndex = 342
        '
        'UltraLabel10
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance21
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(188, 26)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel10.TabIndex = 345
        Me.UltraLabel10.Text = "Hasta:"
        '
        'UltraLabel9
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance22
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(13, 26)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel9.TabIndex = 343
        Me.UltraLabel9.Text = "Desde:"
        '
        'UltraPanel1
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.UltraPanel1.Appearance = Appearance23
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.LblInfo)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.ChkMoratorio)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.ColorBloque)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.Etiqueta48)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraPanel1.Location = New System.Drawing.Point(1160, 19)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(184, 66)
        Me.UltraPanel1.TabIndex = 349
        '
        'LblInfo
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Red
        Me.LblInfo.Appearance = Appearance24
        Me.LblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblInfo.Location = New System.Drawing.Point(4, 40)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(19, 22)
        Me.LblInfo.TabIndex = 350
        Me.LblInfo.Text = "!"
        '
        'ChkMoratorio
        '
        Me.ChkMoratorio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkMoratorio.Location = New System.Drawing.Point(12, 8)
        Me.ChkMoratorio.Name = "ChkMoratorio"
        Me.ChkMoratorio.Size = New System.Drawing.Size(144, 20)
        Me.ChkMoratorio.TabIndex = 349
        Me.ChkMoratorio.Text = "Ver intereses moratios:"
        Me.ChkMoratorio.Visible = False
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.DarkKhaki
        Me.ColorBloque.Location = New System.Drawing.Point(120, 40)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 22)
        Me.ColorBloque.TabIndex = 347
        Me.ColorBloque.Text = "DarkKhaki"
        '
        'Etiqueta48
        '
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance25
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(27, 44)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(86, 14)
        Me.Etiqueta48.TabIndex = 348
        Me.Etiqueta48.Text = "ACTUALIZADO"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griFacturas)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion16)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Controls.Add(Me.txtRuc)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1354, 618)
        '
        'griFacturas
        '
        Me.griFacturas.DataSource = Me.odListadoDocumentos
        Appearance26.BackColor = System.Drawing.SystemColors.Window
        Appearance26.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griFacturas.DisplayLayout.Appearance = Appearance26
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn50.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 1
        UltraGridColumn65.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 8
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 9
        UltraGridColumn68.Hidden = True
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn69.CellAppearance = Appearance27
        UltraGridColumn69.Header.VisiblePosition = 10
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn69.Width = 98
        UltraGridColumn70.Header.Caption = "Imp. Venta"
        UltraGridColumn70.Header.VisiblePosition = 11
        UltraGridColumn70.Hidden = True
        UltraGridColumn70.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn71.CellAppearance = Appearance28
        UltraGridColumn71.Format = "#,##0.00"
        UltraGridColumn71.Header.VisiblePosition = 12
        UltraGridColumn71.MaskInput = ""
        UltraGridColumn71.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn72.CellAppearance = Appearance29
        UltraGridColumn72.Format = "#,##0.00"
        UltraGridColumn72.Header.Caption = "T.C."
        UltraGridColumn72.Header.VisiblePosition = 7
        UltraGridColumn72.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn72.Width = 65
        UltraGridColumn73.Header.VisiblePosition = 14
        UltraGridColumn73.Hidden = True
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn74.CellAppearance = Appearance30
        UltraGridColumn74.Header.VisiblePosition = 15
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.MaskInput = ""
        UltraGridColumn75.Header.VisiblePosition = 16
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 4
        UltraGridColumn76.Width = 62
        UltraGridColumn77.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn77.Header.Caption = "Fecha"
        UltraGridColumn77.Header.VisiblePosition = 5
        UltraGridColumn77.Hidden = True
        UltraGridColumn77.Width = 89
        UltraGridColumn78.Header.VisiblePosition = 17
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 18
        UltraGridColumn79.Hidden = True
        Appearance31.TextHAlignAsString = "Center"
        UltraGridColumn80.CellAppearance = Appearance31
        UltraGridColumn80.Header.VisiblePosition = 6
        UltraGridColumn80.Width = 91
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn81.CellAppearance = Appearance32
        UltraGridColumn81.Header.VisiblePosition = 19
        UltraGridColumn81.Hidden = True
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn82.CellAppearance = Appearance33
        UltraGridColumn82.Format = "#,##0.00"
        UltraGridColumn82.Header.VisiblePosition = 20
        UltraGridColumn82.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance34
        UltraGridColumn83.Format = "#,##0.00"
        UltraGridColumn83.Header.VisiblePosition = 21
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn84.Header.VisiblePosition = 22
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 23
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 24
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 25
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 26
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 27
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 28
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 29
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.Caption = "Estado"
        UltraGridColumn92.Header.VisiblePosition = 13
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.Caption = "Empresa"
        UltraGridColumn93.Header.VisiblePosition = 2
        UltraGridColumn93.Width = 304
        UltraGridColumn94.Header.Caption = "Nº Documento"
        UltraGridColumn94.Header.VisiblePosition = 3
        UltraGridColumn94.Width = 143
        UltraGridColumn95.Header.VisiblePosition = 30
        UltraGridColumn95.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 31
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 32
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 33
        UltraGridColumn99.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn50, UltraGridColumn65, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99})
        Me.griFacturas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griFacturas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFacturas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance35.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.griFacturas.DisplayLayout.GroupByBox.Appearance = Appearance35
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griFacturas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance36
        Me.griFacturas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFacturas.DisplayLayout.GroupByBox.Hidden = True
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance37.BackColor2 = System.Drawing.SystemColors.Control
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griFacturas.DisplayLayout.GroupByBox.PromptAppearance = Appearance37
        Me.griFacturas.DisplayLayout.MaxColScrollRegions = 1
        Me.griFacturas.DisplayLayout.MaxRowScrollRegions = 1
        Me.griFacturas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griFacturas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griFacturas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFacturas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griFacturas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griFacturas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFacturas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griFacturas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griFacturas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griFacturas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griFacturas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griFacturas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFacturas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFacturas.Location = New System.Drawing.Point(0, 445)
        Me.griFacturas.Name = "griFacturas"
        Me.griFacturas.Size = New System.Drawing.Size(1354, 173)
        Me.griFacturas.TabIndex = 319
        Me.griFacturas.Text = "Grilla2"
        '
        'odListadoDocumentos
        '
        Me.odListadoDocumentos.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64})
        '
        'Agrupacion16
        '
        Me.Agrupacion16.Controls.Add(Me.cboProveedorFactura)
        Me.Agrupacion16.Controls.Add(Me.UltraLabel12)
        Me.Agrupacion16.Controls.Add(Me.DtpFacturaHasta)
        Me.Agrupacion16.Controls.Add(Me.DtpFacturaDesde)
        Me.Agrupacion16.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion16.Controls.Add(Me.cboTipoDocumento)
        Me.Agrupacion16.Controls.Add(Me.btnListarMateriales)
        Me.Agrupacion16.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea29)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea30)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea31)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea32)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea33)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea34)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea35)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea36)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea37)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea38)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea39)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea40)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea41)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea42)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea43)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea44)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea45)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea46)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea47)
        Me.Agrupacion16.Controls.Add(Me.UltraToolbarsDockArea48)
        Me.Agrupacion16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion16.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion16.Location = New System.Drawing.Point(0, 412)
        Me.Agrupacion16.Name = "Agrupacion16"
        Me.Agrupacion16.Size = New System.Drawing.Size(1354, 33)
        Me.Agrupacion16.TabIndex = 302
        Me.Agrupacion16.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboProveedorFactura
        '
        Me.cboProveedorFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedorFactura.DisplayMember = "Nombre"
        Me.cboProveedorFactura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedorFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorFactura.Location = New System.Drawing.Point(636, 4)
        Me.cboProveedorFactura.Name = "cboProveedorFactura"
        Me.cboProveedorFactura.Size = New System.Drawing.Size(295, 22)
        Me.cboProveedorFactura.TabIndex = 473
        Me.cboProveedorFactura.ValueMember = "Id"
        '
        'UltraLabel12
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel12.Appearance = Appearance38
        Me.UltraLabel12.Location = New System.Drawing.Point(247, 9)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(19, 13)
        Me.UltraLabel12.TabIndex = 431
        Me.UltraLabel12.Text = "Al:"
        '
        'DtpFacturaHasta
        '
        Me.DtpFacturaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFacturaHasta.Location = New System.Drawing.Point(272, 6)
        Me.DtpFacturaHasta.Name = "DtpFacturaHasta"
        Me.DtpFacturaHasta.Size = New System.Drawing.Size(99, 20)
        Me.DtpFacturaHasta.TabIndex = 430
        '
        'DtpFacturaDesde
        '
        Me.DtpFacturaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFacturaDesde.Location = New System.Drawing.Point(137, 6)
        Me.DtpFacturaDesde.Name = "DtpFacturaDesde"
        Me.DtpFacturaDesde.Size = New System.Drawing.Size(104, 20)
        Me.DtpFacturaDesde.TabIndex = 409
        '
        'Etiqueta31
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta31.Appearance = Appearance39
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(555, 10)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta31.TabIndex = 387
        Me.Etiqueta31.Text = "Proveedor:"
        '
        'cboTipoDocumento
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance40
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayMember = "Nombre"
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(377, 4)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(161, 22)
        Me.cboTipoDocumento.TabIndex = 365
        Me.cboTipoDocumento.ValueMember = "IdTipoDocumento"
        '
        'btnListarMateriales
        '
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMateriales.Appearance = Appearance41
        Me.btnListarMateriales.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMateriales.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMateriales.Location = New System.Drawing.Point(937, 4)
        Me.btnListarMateriales.Name = "btnListarMateriales"
        Me.btnListarMateriales.Size = New System.Drawing.Size(30, 22)
        Me.btnListarMateriales.TabIndex = 344
        '
        'Etiqueta8
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance42
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(8, 9)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(123, 15)
        Me.Etiqueta8.TabIndex = 322
        Me.Etiqueta8.Text = "Fecha de Docs.; Desde:"
        '
        'UltraToolbarsDockArea29
        '
        Me.UltraToolbarsDockArea29.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea29.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea29.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea29.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea29.Name = "UltraToolbarsDockArea29"
        Me.UltraToolbarsDockArea29.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea30
        '
        Me.UltraToolbarsDockArea30.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea30.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea30.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea30.Location = New System.Drawing.Point(2, 31)
        Me.UltraToolbarsDockArea30.Name = "UltraToolbarsDockArea30"
        Me.UltraToolbarsDockArea30.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea31
        '
        Me.UltraToolbarsDockArea31.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea31.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea31.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea31.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea31.Name = "UltraToolbarsDockArea31"
        Me.UltraToolbarsDockArea31.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea32
        '
        Me.UltraToolbarsDockArea32.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea32.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea32.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea32.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea32.Name = "UltraToolbarsDockArea32"
        Me.UltraToolbarsDockArea32.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea33
        '
        Me.UltraToolbarsDockArea33.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea33.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea33.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea33.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea33.Name = "UltraToolbarsDockArea33"
        Me.UltraToolbarsDockArea33.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea34
        '
        Me.UltraToolbarsDockArea34.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea34.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea34.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea34.Location = New System.Drawing.Point(2, 31)
        Me.UltraToolbarsDockArea34.Name = "UltraToolbarsDockArea34"
        Me.UltraToolbarsDockArea34.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea35
        '
        Me.UltraToolbarsDockArea35.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea35.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea35.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea35.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea35.Name = "UltraToolbarsDockArea35"
        Me.UltraToolbarsDockArea35.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea36
        '
        Me.UltraToolbarsDockArea36.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea36.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea36.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea36.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea36.Name = "UltraToolbarsDockArea36"
        Me.UltraToolbarsDockArea36.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea37
        '
        Me.UltraToolbarsDockArea37.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea37.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea37.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea37.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea37.Name = "UltraToolbarsDockArea37"
        Me.UltraToolbarsDockArea37.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea38
        '
        Me.UltraToolbarsDockArea38.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea38.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea38.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea38.Location = New System.Drawing.Point(2, 31)
        Me.UltraToolbarsDockArea38.Name = "UltraToolbarsDockArea38"
        Me.UltraToolbarsDockArea38.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea39
        '
        Me.UltraToolbarsDockArea39.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea39.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea39.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea39.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea39.Name = "UltraToolbarsDockArea39"
        Me.UltraToolbarsDockArea39.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea40
        '
        Me.UltraToolbarsDockArea40.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea40.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea40.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea40.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea40.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea40.Name = "UltraToolbarsDockArea40"
        Me.UltraToolbarsDockArea40.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea41
        '
        Me.UltraToolbarsDockArea41.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea41.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea41.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea41.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea41.Name = "UltraToolbarsDockArea41"
        Me.UltraToolbarsDockArea41.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea42
        '
        Me.UltraToolbarsDockArea42.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea42.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea42.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea42.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea42.Location = New System.Drawing.Point(2, 31)
        Me.UltraToolbarsDockArea42.Name = "UltraToolbarsDockArea42"
        Me.UltraToolbarsDockArea42.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea43
        '
        Me.UltraToolbarsDockArea43.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea43.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea43.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea43.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea43.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea43.Name = "UltraToolbarsDockArea43"
        Me.UltraToolbarsDockArea43.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea44
        '
        Me.UltraToolbarsDockArea44.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea44.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea44.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea44.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea44.Name = "UltraToolbarsDockArea44"
        Me.UltraToolbarsDockArea44.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea45
        '
        Me.UltraToolbarsDockArea45.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea45.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea45.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea45.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea45.Name = "UltraToolbarsDockArea45"
        Me.UltraToolbarsDockArea45.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea46
        '
        Me.UltraToolbarsDockArea46.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea46.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea46.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea46.Location = New System.Drawing.Point(2, 31)
        Me.UltraToolbarsDockArea46.Name = "UltraToolbarsDockArea46"
        Me.UltraToolbarsDockArea46.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea47
        '
        Me.UltraToolbarsDockArea47.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea47.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea47.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea47.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea47.Name = "UltraToolbarsDockArea47"
        Me.UltraToolbarsDockArea47.Size = New System.Drawing.Size(0, 29)
        '
        'UltraToolbarsDockArea48
        '
        Me.UltraToolbarsDockArea48.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea48.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea48.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea48.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea48.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea48.Name = "UltraToolbarsDockArea48"
        Me.UltraToolbarsDockArea48.Size = New System.Drawing.Size(0, 29)
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.Espere1)
        Me.Agrupacion12.Controls.Add(Me.griFacturaAgregadas)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea13)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea14)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea17)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea18)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea25)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea26)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea27)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea28)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea19)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea22)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea23)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea24)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea5)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea6)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea7)
        Me.Agrupacion12.Controls.Add(Me.UltraToolbarsDockArea8)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 211)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1354, 201)
        Me.Agrupacion12.TabIndex = 300
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Espere1
        '
        Me.Espere1.Location = New System.Drawing.Point(421, 20)
        Me.Espere1.Name = "Espere1"
        Me.Espere1.Size = New System.Drawing.Size(393, 67)
        Me.Espere1.TabIndex = 41
        Me.Espere1.Visible = False
        '
        'griFacturaAgregadas
        '
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griFacturaAgregadas.DisplayLayout.Appearance = Appearance43
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn100.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 8
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 9
        UltraGridColumn103.Hidden = True
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn104.CellAppearance = Appearance44
        UltraGridColumn104.Header.VisiblePosition = 10
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn104.Width = 98
        UltraGridColumn105.Header.Caption = "Imp. Venta"
        UltraGridColumn105.Header.VisiblePosition = 11
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn106.CellAppearance = Appearance45
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn106.Format = "#,##0.00"
        UltraGridColumn106.Header.VisiblePosition = 12
        UltraGridColumn106.MaskInput = ""
        UltraGridColumn106.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn107.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn107.CellAppearance = Appearance46
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn107.Format = "#,##0.00"
        UltraGridColumn107.Header.Caption = "T.C."
        UltraGridColumn107.Header.VisiblePosition = 7
        UltraGridColumn107.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn107.Width = 66
        UltraGridColumn108.Header.VisiblePosition = 18
        UltraGridColumn108.Hidden = True
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn109.CellAppearance = Appearance47
        UltraGridColumn109.Header.VisiblePosition = 19
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.MaskInput = ""
        UltraGridColumn110.Header.VisiblePosition = 20
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn111.Header.VisiblePosition = 4
        UltraGridColumn111.Width = 70
        UltraGridColumn112.Header.Caption = "Fecha"
        UltraGridColumn112.Header.VisiblePosition = 5
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.Width = 94
        UltraGridColumn113.Header.VisiblePosition = 21
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 22
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn115.CellAppearance = Appearance48
        UltraGridColumn115.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn115.Header.VisiblePosition = 6
        UltraGridColumn115.Width = 91
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn116.CellAppearance = Appearance49
        UltraGridColumn116.Header.VisiblePosition = 23
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn117.CellAppearance = Appearance50
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn117.Format = "#,##0.00"
        UltraGridColumn117.Header.VisiblePosition = 13
        UltraGridColumn117.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn137.CellAppearance = Appearance51
        UltraGridColumn137.Format = "#,##0.00"
        UltraGridColumn137.Header.Caption = "Monto Canjear"
        UltraGridColumn137.Header.VisiblePosition = 14
        UltraGridColumn137.MaskInput = "{double:9.4}"
        UltraGridColumn137.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn118.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn118.CellAppearance = Appearance52
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn118.Format = "#,##0.00"
        UltraGridColumn118.Header.Caption = "Monto Operar"
        UltraGridColumn118.Header.VisiblePosition = 15
        UltraGridColumn118.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn138.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn138.CellAppearance = Appearance53
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn138.Format = "#,##0.00"
        UltraGridColumn138.Header.Caption = "Retención"
        UltraGridColumn138.Header.VisiblePosition = 16
        UltraGridColumn138.MaskInput = "{double:9.4}"
        UltraGridColumn138.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn119.Header.VisiblePosition = 24
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 25
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 26
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 27
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 28
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 29
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 30
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 31
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.Caption = "Estado"
        UltraGridColumn127.Header.VisiblePosition = 17
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn128.Header.Caption = "Empresa"
        UltraGridColumn128.Header.VisiblePosition = 2
        UltraGridColumn128.Width = 304
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.Caption = "Nº Documento"
        UltraGridColumn129.Header.VisiblePosition = 3
        UltraGridColumn129.Width = 143
        UltraGridColumn131.Header.VisiblePosition = 32
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn132.Header.VisiblePosition = 33
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 34
        UltraGridColumn133.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 35
        UltraGridColumn2.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn137, UltraGridColumn118, UltraGridColumn138, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn2})
        UltraGridBand4.SummaryFooterCaption = ""
        Me.griFacturaAgregadas.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griFacturaAgregadas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFacturaAgregadas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance54.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance54.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance54.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance54.BorderColor = System.Drawing.SystemColors.Window
        Me.griFacturaAgregadas.DisplayLayout.GroupByBox.Appearance = Appearance54
        Appearance55.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griFacturaAgregadas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance55
        Me.griFacturaAgregadas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griFacturaAgregadas.DisplayLayout.GroupByBox.Hidden = True
        Appearance56.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance56.BackColor2 = System.Drawing.SystemColors.Control
        Appearance56.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance56.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griFacturaAgregadas.DisplayLayout.GroupByBox.PromptAppearance = Appearance56
        Me.griFacturaAgregadas.DisplayLayout.MaxColScrollRegions = 1
        Me.griFacturaAgregadas.DisplayLayout.MaxRowScrollRegions = 1
        Me.griFacturaAgregadas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griFacturaAgregadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griFacturaAgregadas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griFacturaAgregadas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griFacturaAgregadas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griFacturaAgregadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griFacturaAgregadas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griFacturaAgregadas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griFacturaAgregadas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griFacturaAgregadas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griFacturaAgregadas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griFacturaAgregadas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griFacturaAgregadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFacturaAgregadas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFacturaAgregadas.Location = New System.Drawing.Point(2, 2)
        Me.griFacturaAgregadas.Name = "griFacturaAgregadas"
        Me.griFacturaAgregadas.Size = New System.Drawing.Size(1350, 197)
        Me.griFacturaAgregadas.TabIndex = 20
        Me.griFacturaAgregadas.Text = "Grilla2"
        '
        'UltraToolbarsDockArea13
        '
        Me.UltraToolbarsDockArea13.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea13.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea13.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea13.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea13.Name = "UltraToolbarsDockArea13"
        Me.UltraToolbarsDockArea13.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea14
        '
        Me.UltraToolbarsDockArea14.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea14.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea14.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea14.Location = New System.Drawing.Point(2, 199)
        Me.UltraToolbarsDockArea14.Name = "UltraToolbarsDockArea14"
        Me.UltraToolbarsDockArea14.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea17
        '
        Me.UltraToolbarsDockArea17.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea17.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea17.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea17.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea17.Name = "UltraToolbarsDockArea17"
        Me.UltraToolbarsDockArea17.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea18
        '
        Me.UltraToolbarsDockArea18.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea18.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea18.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea18.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea18.Name = "UltraToolbarsDockArea18"
        Me.UltraToolbarsDockArea18.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea25
        '
        Me.UltraToolbarsDockArea25.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea25.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea25.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea25.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea25.Name = "UltraToolbarsDockArea25"
        Me.UltraToolbarsDockArea25.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea26
        '
        Me.UltraToolbarsDockArea26.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea26.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea26.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea26.Location = New System.Drawing.Point(2, 199)
        Me.UltraToolbarsDockArea26.Name = "UltraToolbarsDockArea26"
        Me.UltraToolbarsDockArea26.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea27
        '
        Me.UltraToolbarsDockArea27.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea27.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea27.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea27.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea27.Name = "UltraToolbarsDockArea27"
        Me.UltraToolbarsDockArea27.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea28
        '
        Me.UltraToolbarsDockArea28.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea28.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea28.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea28.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea28.Name = "UltraToolbarsDockArea28"
        Me.UltraToolbarsDockArea28.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea19
        '
        Me.UltraToolbarsDockArea19.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea19.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea19.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea19.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea19.Name = "UltraToolbarsDockArea19"
        Me.UltraToolbarsDockArea19.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea22
        '
        Me.UltraToolbarsDockArea22.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea22.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea22.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea22.Location = New System.Drawing.Point(2, 199)
        Me.UltraToolbarsDockArea22.Name = "UltraToolbarsDockArea22"
        Me.UltraToolbarsDockArea22.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea23
        '
        Me.UltraToolbarsDockArea23.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea23.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea23.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea23.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea23.Name = "UltraToolbarsDockArea23"
        Me.UltraToolbarsDockArea23.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea24
        '
        Me.UltraToolbarsDockArea24.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea24.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea24.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea24.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea24.Name = "UltraToolbarsDockArea24"
        Me.UltraToolbarsDockArea24.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(2, 199)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea5
        '
        Me.UltraToolbarsDockArea5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea5.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea5.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea5.Name = "UltraToolbarsDockArea5"
        Me.UltraToolbarsDockArea5.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea6
        '
        Me.UltraToolbarsDockArea6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea6.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea6.Location = New System.Drawing.Point(2, 199)
        Me.UltraToolbarsDockArea6.Name = "UltraToolbarsDockArea6"
        Me.UltraToolbarsDockArea6.Size = New System.Drawing.Size(1350, 0)
        '
        'UltraToolbarsDockArea7
        '
        Me.UltraToolbarsDockArea7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea7.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea7.Location = New System.Drawing.Point(2, 2)
        Me.UltraToolbarsDockArea7.Name = "UltraToolbarsDockArea7"
        Me.UltraToolbarsDockArea7.Size = New System.Drawing.Size(0, 197)
        '
        'UltraToolbarsDockArea8
        '
        Me.UltraToolbarsDockArea8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea8.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea8.Location = New System.Drawing.Point(1352, 2)
        Me.UltraToolbarsDockArea8.Name = "UltraToolbarsDockArea8"
        Me.UltraToolbarsDockArea8.Size = New System.Drawing.Size(0, 197)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.AgrupLetras)
        Me.Agrupacion2.Controls.Add(Me.AgrupInfLetra)
        Me.Agrupacion2.Controls.Add(Me.lbl_etiqueta)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1354, 211)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.Text = "MANTENEDOR DE LETRAS"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'AgrupLetras
        '
        Me.AgrupLetras.Controls.Add(Me.GridLetras)
        Me.AgrupLetras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AgrupLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgrupLetras.ForeColor = System.Drawing.Color.Black
        Me.AgrupLetras.Location = New System.Drawing.Point(580, 19)
        Me.AgrupLetras.Name = "AgrupLetras"
        Me.AgrupLetras.Size = New System.Drawing.Size(772, 190)
        Me.AgrupLetras.TabIndex = 347
        Me.AgrupLetras.Text = "Letras"
        Me.AgrupLetras.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GridLetras
        '
        UltraGridColumn3.Header.VisiblePosition = 0
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 1
        UltraGridColumn4.Hidden = True
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance57
        UltraGridColumn5.Header.Caption = "N° Letra"
        UltraGridColumn5.Header.VisiblePosition = 2
        UltraGridColumn5.Width = 61
        Appearance58.TextHAlignAsString = "Center"
        UltraGridColumn6.CellAppearance = Appearance58
        UltraGridColumn6.Format = "dd/MM/yyyy"
        UltraGridColumn6.Header.Caption = "Fecha Venc."
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn6.MaskInput = "{LOC}mm/dd/yyyy"
        UltraGridColumn6.Width = 85
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance59
        UltraGridColumn7.Format = "#,##0.00"
        UltraGridColumn7.Header.Caption = "Monto"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn7.Width = 85
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 10
        UltraGridColumn13.Hidden = True
        Appearance60.TextHAlignAsString = "Right"
        UltraGridColumn14.CellAppearance = Appearance60
        UltraGridColumn14.Format = "#,##0.00"
        UltraGridColumn14.Header.VisiblePosition = 15
        UltraGridColumn14.Width = 90
        UltraGridColumn15.Format = "#,##0.00"
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Format = "#,##0.00"
        UltraGridColumn16.Header.VisiblePosition = 12
        UltraGridColumn16.Hidden = True
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance61
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn17.Format = "#,##0.00"
        UltraGridColumn17.Header.Caption = "Monto MN"
        UltraGridColumn17.Header.VisiblePosition = 13
        UltraGridColumn17.Width = 85
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance62
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn18.Format = "#,##0.00"
        UltraGridColumn18.Header.Caption = "Monto ME"
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn18.Width = 85
        UltraGridColumn139.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance63.TextHAlignAsString = "Right"
        UltraGridColumn139.CellAppearance = Appearance63
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn139.CellButtonAppearance = Appearance64
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn139.Format = "#,##0.00"
        UltraGridColumn139.Header.VisiblePosition = 37
        UltraGridColumn139.MaskInput = "{double:9.4}"
        UltraGridColumn139.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn139.Width = 85
        UltraGridColumn140.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn140.CellAppearance = Appearance65
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn140.CellButtonAppearance = Appearance66
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn140.Format = "#,##0.00"
        UltraGridColumn140.Header.VisiblePosition = 38
        UltraGridColumn140.MaskInput = "{double:9.4}"
        UltraGridColumn140.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn140.Width = 85
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn19.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 17
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 18
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 19
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 20
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 21
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 22
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 23
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 24
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 25
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 26
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 27
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 28
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 29
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 30
        UltraGridColumn64.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 31
        UltraGridColumn66.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 32
        UltraGridColumn96.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 33
        UltraGridColumn130.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 34
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 35
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 36
        UltraGridColumn136.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn139, UltraGridColumn140, UltraGridColumn19, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn66, UltraGridColumn96, UltraGridColumn130, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136})
        UltraGridBand5.SummaryFooterCaption = ""
        Me.GridLetras.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.GridLetras.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.GridLetras.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.GridLetras.DisplayLayout.MaxColScrollRegions = 1
        Me.GridLetras.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridLetras.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridLetras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridLetras.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridLetras.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.GridLetras.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridLetras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridLetras.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridLetras.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridLetras.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridLetras.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridLetras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLetras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridLetras.Location = New System.Drawing.Point(2, 18)
        Me.GridLetras.Name = "GridLetras"
        Me.GridLetras.Size = New System.Drawing.Size(768, 170)
        Me.GridLetras.TabIndex = 10
        '
        'AgrupInfLetra
        '
        Me.AgrupInfLetra.Controls.Add(Me.ndTotalContratoME)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel14)
        Me.AgrupInfLetra.Controls.Add(Me.ndTotalContratoMN)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel13)
        Me.AgrupInfLetra.Controls.Add(Me.Agrupacion3)
        Me.AgrupInfLetra.Controls.Add(Me.fecContrato)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel11)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel8)
        Me.AgrupInfLetra.Controls.Add(Me.cboBanco)
        Me.AgrupInfLetra.Controls.Add(Me.cboMoneda)
        Me.AgrupInfLetra.Controls.Add(Me.txtTipoCambio)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel7)
        Me.AgrupInfLetra.Controls.Add(Me.UltraLabel6)
        Me.AgrupInfLetra.Dock = System.Windows.Forms.DockStyle.Left
        Me.AgrupInfLetra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgrupInfLetra.ForeColor = System.Drawing.Color.Black
        Me.AgrupInfLetra.Location = New System.Drawing.Point(2, 19)
        Me.AgrupInfLetra.Name = "AgrupInfLetra"
        Me.AgrupInfLetra.Size = New System.Drawing.Size(578, 190)
        Me.AgrupInfLetra.TabIndex = 254
        Me.AgrupInfLetra.Text = "Informacion"
        Me.AgrupInfLetra.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ndTotalContratoME
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.ndTotalContratoME.Appearance = Appearance67
        Me.ndTotalContratoME.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTotalContratoME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTotalContratoME.ForeColor = System.Drawing.Color.Black
        Me.ndTotalContratoME.Location = New System.Drawing.Point(478, 51)
        Me.ndTotalContratoME.MaskInput = "{LOC}nnnnnnnnnn.nnnn"
        Me.ndTotalContratoME.Name = "ndTotalContratoME"
        Me.ndTotalContratoME.NullText = "0.00"
        Me.ndTotalContratoME.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTotalContratoME.ReadOnly = True
        Me.ndTotalContratoME.Size = New System.Drawing.Size(93, 21)
        Me.ndTotalContratoME.TabIndex = 395
        '
        'UltraLabel14
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance68
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(434, 54)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel14.TabIndex = 394
        Me.UltraLabel14.Text = "Total $"
        '
        'ndTotalContratoMN
        '
        Appearance69.ForeColor = System.Drawing.Color.Black
        Me.ndTotalContratoMN.Appearance = Appearance69
        Me.ndTotalContratoMN.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndTotalContratoMN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndTotalContratoMN.ForeColor = System.Drawing.Color.Black
        Me.ndTotalContratoMN.Location = New System.Drawing.Point(336, 51)
        Me.ndTotalContratoMN.MaskInput = "{LOC}nnnnnnnnnn.nnnn"
        Me.ndTotalContratoMN.Name = "ndTotalContratoMN"
        Me.ndTotalContratoMN.NullText = "0.00"
        Me.ndTotalContratoMN.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndTotalContratoMN.ReadOnly = True
        Me.ndTotalContratoMN.Size = New System.Drawing.Size(94, 21)
        Me.ndTotalContratoMN.TabIndex = 393
        '
        'UltraLabel13
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Appearance70.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance70
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(286, 54)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel13.TabIndex = 392
        Me.UltraLabel13.Text = "Total S/"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.chkRetencion)
        Me.Agrupacion3.Controls.Add(Me.txtNumero)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion3.Controls.Add(Me.btnQuitar)
        Me.Agrupacion3.Controls.Add(Me.fecFechaEmision)
        Me.Agrupacion3.Controls.Add(Me.btnAgregar)
        Me.Agrupacion3.Controls.Add(Me.fecFechaVencimiento)
        Me.Agrupacion3.Controls.Add(Me.txtGlosa)
        Me.Agrupacion3.Controls.Add(Me.txtMonto)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(7, 76)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(564, 109)
        Me.Agrupacion3.TabIndex = 391
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkRetencion
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkRetencion.Appearance = Appearance71
        Me.chkRetencion.AutoSize = True
        Me.chkRetencion.BackColor = System.Drawing.Color.Transparent
        Me.chkRetencion.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRetencion.Location = New System.Drawing.Point(414, 86)
        Me.chkRetencion.Name = "chkRetencion"
        Me.chkRetencion.Size = New System.Drawing.Size(109, 17)
        Me.chkRetencion.TabIndex = 348
        Me.chkRetencion.Text = "Aplica Retención:"
        '
        'txtNumero
        '
        Appearance72.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance72
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(44, 6)
        Me.txtNumero.MaxLength = 8
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(84, 21)
        Me.txtNumero.TabIndex = 333
        '
        'UltraLabel2
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance73
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(17, 10)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(21, 15)
        Me.UltraLabel2.TabIndex = 332
        Me.UltraLabel2.Text = "N°:"
        '
        'UltraLabel5
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance74
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(134, 10)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel5.TabIndex = 338
        Me.UltraLabel5.Text = "F. Emis.:"
        '
        'UltraLabel1
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance75
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(275, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(49, 15)
        Me.UltraLabel1.TabIndex = 334
        Me.UltraLabel1.Text = "F. Venc :"
        '
        'UltraLabel3
        '
        Appearance76.BackColor = System.Drawing.Color.Transparent
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance76
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(412, 10)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel3.TabIndex = 335
        Me.UltraLabel3.Text = "Monto:"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.Black
        Me.btnQuitar.Location = New System.Drawing.Point(412, 59)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(90, 25)
        Me.btnQuitar.TabIndex = 347
        Me.btnQuitar.Text = "<<Quitar"
        '
        'fecFechaEmision
        '
        Me.fecFechaEmision.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaEmision.Location = New System.Drawing.Point(184, 7)
        Me.fecFechaEmision.MaskInput = ""
        Me.fecFechaEmision.Name = "fecFechaEmision"
        Me.fecFechaEmision.Size = New System.Drawing.Size(84, 21)
        Me.fecFechaEmision.TabIndex = 337
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(412, 34)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(90, 25)
        Me.btnAgregar.TabIndex = 346
        Me.btnAgregar.Text = "Agregar >>"
        '
        'fecFechaVencimiento
        '
        Me.fecFechaVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaVencimiento.Location = New System.Drawing.Point(326, 7)
        Me.fecFechaVencimiento.MaskInput = ""
        Me.fecFechaVencimiento.Name = "fecFechaVencimiento"
        Me.fecFechaVencimiento.Size = New System.Drawing.Size(80, 21)
        Me.fecFechaVencimiento.TabIndex = 339
        '
        'txtGlosa
        '
        Appearance77.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance77
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(44, 33)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(362, 70)
        Me.txtGlosa.TabIndex = 345
        '
        'txtMonto
        '
        Appearance78.ForeColor = System.Drawing.Color.Black
        Me.txtMonto.Appearance = Appearance78
        Me.txtMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.Color.Black
        Me.txtMonto.Location = New System.Drawing.Point(454, 7)
        Me.txtMonto.MaskInput = "{LOC}nnnnnnnnnn.nnnn"
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.NullText = "0.00"
        Me.txtMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtMonto.Size = New System.Drawing.Size(102, 21)
        Me.txtMonto.TabIndex = 340
        '
        'UltraLabel4
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance79
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(3, 35)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel4.TabIndex = 336
        Me.UltraLabel4.Text = "Glosa :"
        '
        'fecContrato
        '
        Me.fecContrato.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecContrato.Location = New System.Drawing.Point(51, 50)
        Me.fecContrato.MaskInput = ""
        Me.fecContrato.Name = "fecContrato"
        Me.fecContrato.Size = New System.Drawing.Size(84, 22)
        Me.fecContrato.TabIndex = 390
        '
        'UltraLabel11
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Appearance80.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance80
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(7, 54)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel11.TabIndex = 389
        Me.UltraLabel11.Text = "Fecha:"
        '
        'UltraLabel8
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance81
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(7, 27)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel8.TabIndex = 388
        Me.UltraLabel8.Text = "Banco:"
        '
        'cboBanco
        '
        Appearance82.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Appearance = Appearance82
        Me.cboBanco.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboBanco.DropDownListWidth = 400
        Me.cboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBanco.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboBanco.Location = New System.Drawing.Point(51, 23)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(380, 21)
        Me.cboBanco.TabIndex = 387
        Me.cboBanco.ValueMember = "Id"
        '
        'cboMoneda
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance83
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(487, 24)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(84, 21)
        Me.cboMoneda.TabIndex = 344
        Me.cboMoneda.ValueMember = "Id"
        '
        'txtTipoCambio
        '
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.txtTipoCambio.Appearance = Appearance84
        Appearance85.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance85
        Appearance86.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.PressedAppearance = Appearance86
        Me.txtTipoCambio.ButtonsRight.Add(EditorButton1)
        Me.txtTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.txtTipoCambio.Location = New System.Drawing.Point(171, 50)
        Me.txtTipoCambio.MaskInput = "{LOC}nnnnnn.nnnn"
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.NullText = "0.00"
        Me.txtTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(93, 21)
        Me.txtTipoCambio.TabIndex = 343
        '
        'UltraLabel7
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance87
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(138, 53)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(32, 15)
        Me.UltraLabel7.TabIndex = 342
        Me.UltraLabel7.Text = "T. C.:"
        '
        'UltraLabel6
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance88
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(437, 27)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 341
        Me.UltraLabel6.Text = "Moneda:"
        '
        'lbl_etiqueta
        '
        Me.lbl_etiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance89.ForeColor = System.Drawing.Color.Red
        Me.lbl_etiqueta.Appearance = Appearance89
        Me.lbl_etiqueta.AutoSize = True
        Me.lbl_etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_etiqueta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbl_etiqueta.Location = New System.Drawing.Point(1244, 1)
        Me.lbl_etiqueta.Name = "lbl_etiqueta"
        Me.lbl_etiqueta.Size = New System.Drawing.Size(52, 16)
        Me.lbl_etiqueta.TabIndex = 251
        Me.lbl_etiqueta.Text = "Etiqueta"
        Me.lbl_etiqueta.Visible = False
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(636, 441)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(129, 21)
        Me.txtRuc.TabIndex = 388
        Me.txtRuc.TabStop = False
        '
        'odListadoFacturaLetras
        '
        Me.odListadoFacturaLetras.Band.Columns.AddRange(New Object() {UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98})
        '
        'OrgDocumentosFec
        '
        UltraDataColumn102.DataType = GetType(Date)
        UltraDataColumn103.DataType = GetType(Double)
        UltraDataColumn104.DataType = GetType(Double)
        UltraDataColumn105.DataType = GetType(Double)
        UltraDataColumn106.DataType = GetType(Double)
        UltraDataColumn107.DataType = GetType(Double)
        UltraDataColumn108.DataType = GetType(Double)
        UltraDataColumn109.DataType = GetType(Double)
        UltraDataColumn110.DataType = GetType(Double)
        UltraDataColumn111.DataType = GetType(Double)
        UltraDataColumn112.DataType = GetType(Double)
        UltraDataColumn113.DataType = GetType(Double)
        UltraDataColumn114.DataType = GetType(Double)
        Me.OrgDocumentosFec.Band.Columns.AddRange(New Object() {UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135})
        '
        'FiltroLetras
        '
        Me.FiltroLetras.MenuSettings.RightAlignedMenus = True
        Me.FiltroLetras.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2007
        '
        'MenuAgregados
        '
        Me.MenuAgregados.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitarDocumento})
        Me.MenuAgregados.Name = "mnu_Transferencias"
        Me.MenuAgregados.Size = New System.Drawing.Size(122, 30)
        '
        'QuitarDocumento
        '
        Me.QuitarDocumento.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.QuitarDocumento.Name = "QuitarDocumento"
        Me.QuitarDocumento.Size = New System.Drawing.Size(121, 26)
        Me.QuitarDocumento.Text = "Eliminar"
        '
        'ficLetra
        '
        Me.ficLetra.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficLetra.Controls.Add(Me.UltraTabPageControl1)
        Me.ficLetra.Controls.Add(Me.UltraTabPageControl2)
        Me.ficLetra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLetra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficLetra.Location = New System.Drawing.Point(0, 0)
        Me.ficLetra.Name = "ficLetra"
        Me.ficLetra.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficLetra.Size = New System.Drawing.Size(1348, 641)
        Me.ficLetra.TabIndex = 17
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficLetra.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficLetra.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 618)
        '
        'ToolTipAyudaActualizacion
        '
        Me.ToolTipAyudaActualizacion.ContainingControl = Me
        '
        'frm_LetraCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1348, 641)
        Me.Controls.Add(Me.ficLetra)
        Me.Name = "frm_LetraCambio"
        Me.Text = "Letra De Cambio"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenCompra.ResumeLayout(False)
        CType(Me.GridObligacionLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.ChkMoratorio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.griFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListadoDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion16.ResumeLayout(False)
        Me.Agrupacion16.PerformLayout()
        CType(Me.cboProveedorFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        CType(Me.griFacturaAgregadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.AgrupLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgrupLetras.ResumeLayout(False)
        CType(Me.GridLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgrupInfLetra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgrupInfLetra.ResumeLayout(False)
        Me.AgrupInfLetra.PerformLayout()
        CType(Me.ndTotalContratoME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndTotalContratoMN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.chkRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecContrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListadoFacturaLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.ficLetra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficLetra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficLetra As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOrdenCompra As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents griFacturaAgregadas As ISL.Controles.Grilla
    Friend WithEvents UltraToolbarsDockArea13 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea14 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea17 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea18 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea25 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea26 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea27 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea28 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea19 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea22 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea23 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea24 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea5 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea6 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea7 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea8 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion16 As ISL.Controles.Agrupacion
    Friend WithEvents cboTipoDocumento As ISL.Controles.ComboMaestros
    Friend WithEvents btnListarMateriales As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents UltraToolbarsDockArea29 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea30 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea31 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea32 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea33 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea34 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea35 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea36 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea37 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea38 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea39 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea40 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea41 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea42 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea43 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea44 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea45 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea46 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea47 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea48 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents griFacturas As ISL.Controles.Grilla
    Friend WithEvents odListadoDocumentos As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents AgrupInfLetra As ISL.Controles.Agrupacion
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents txtTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents fecFechaVencimiento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecFechaEmision As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lbl_etiqueta As ISL.Controles.Etiqueta
    Friend WithEvents AgrupLetras As ISL.Controles.Agrupacion
    Friend WithEvents btnQuitar As ISL.Controles.Boton
    Friend WithEvents btnAgregar As ISL.Controles.Boton
    Friend WithEvents odListadoFacturaLetras As ISL.Controles.OrigenDatos
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents GridLetras As ISL.Controles.Grilla
    Friend WithEvents OrgDocumentosFec As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cboBanco As ISL.Controles.Combo
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DsLetras As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltroLetras As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DtpFechaEmisionFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DtpFechaEmisionInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridObligacionLetras As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents ColorBloque As ISL.Controles.Colores
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents ChkMoratorio As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents LblInfo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ToolTipAyudaActualizacion As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents DtpFacturaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DtpFacturaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboProveedorFactura As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ndTotalContratoME As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ndTotalContratoMN As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents fecContrato As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Espere1 As ISL.Win.Espere
    Friend WithEvents chkRetencion As Infragistics.Win.UltraWinEditors.UltraCheckEditor

End Class
