<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FactoryFEDD
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
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetalleGlosa")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdContrato")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVencimiento")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPeriodoGracia")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoMN")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoME")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCuota")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteres")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresMoratorio")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresDscto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoInteresContable")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasFinMes")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasProximaCuota")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndInteresMensual")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Gastos")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Portes")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cuo")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Usuario")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MacLocal")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoCapital")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroContrato")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Banco")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoObligacion")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FactoryFEDD))
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAsientoMovimiento")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCompraVenta")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioCrea")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoDetraccion")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Neto")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOperar")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaContable")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreDocumento")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoDocumento")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoDocumento")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoPago")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AbreviaturaMoneda")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiasVen")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Percepcion")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndServicioMaterial")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetraccion")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndElectronico")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAnexo")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndDetalleGlosa")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodMotivo")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenCompra")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContrato")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVencimiento")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPeriodoGracia")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCuota")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteres")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresDscto")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresContable")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasFinMes")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasProximaCuota")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndInteresMensual")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Portes")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cuo")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MacLocal")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCapital")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Banco")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoObligacion")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1384)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-209)
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
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroContrato")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaBanco")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCuotas")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoMN")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalMontoME")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TasaInteres")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContratoFinanciero")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoMN")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoME")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresCompensatorio")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoInteresMoratorio")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Gastos")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoDsctoInteres")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.OrgDocumentosFec = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuAgregados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuitarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.odDocAgregado = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.MenuAgregadosFactory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarDocumento = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tcFactoringFedd = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Espere1 = New ISL.Win.Espere()
        Me.GridAgregados = New ISL.Controles.Grilla(Me.components)
        Me.GridFactoring = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.lblTotalFactoring = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecGastosFactoring = New ISL.Controles.NumeroDecimal(Me.components)
        Me.CalcFactoring = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTasaInteresFactoring = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecComisionFactoring = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecMontoInteresFactoring = New ISL.Controles.NumeroDecimal(Me.components)
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.txtCodigoBancoFactoring = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalFactoring = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecVencimientoFactoring = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.GridDocumentosVentas = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListaDoc = New ISL.Controles.Boton(Me.components)
        Me.cboClienteFac = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion12 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkFactoring = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.decImporteDol = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decImporteSol = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.txt_Glosa = New ISL.Controles.Texto(Me.components)
        Me.CboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.AgrDatosObligacionFin = New ISL.Controles.Agrupacion(Me.components)
        Me.DecSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumCalc = New ISL.Controles.NumeroCalculadora(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTasaInt = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecInteresMonto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecTotalPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecVencimiento = New ISL.Controles.Fecha(Me.components)
        Me.CboCtaBancaria = New ISL.Controles.Combo(Me.components)
        Me.CboTipo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtUnico = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.FecFecha = New ISL.Controles.Fecha(Me.components)
        Me.CboBanco = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GridFactoringFedd = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.FecHasta = New System.Windows.Forms.DateTimePicker()
        Me.FecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.CboTipoObligacionListar = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregados.SuspendLayout()
        CType(Me.odDocAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuAgregadosFactory.SuspendLayout()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcFactoringFedd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcFactoringFedd.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.GridAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.DecGastosFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTasaInteresFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecComisionFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecMontoInteresFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBancoFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimientoFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.GridDocumentosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cboClienteFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion12.SuspendLayout()
        CType(Me.chkFactoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.decImporteDol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImporteSol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgrDatosObligacionFin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AgrDatosObligacionFin.SuspendLayout()
        CType(Me.DecSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTasaInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecInteresMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboCtaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUnico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CboBanco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.GridFactoringFedd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.CboTipoObligacionListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'OrgDocumentosFec
        '
        UltraDataColumn4.DataType = GetType(Date)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(System.Drawing.Bitmap)
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
        UltraDataColumn27.DataType = GetType(System.Drawing.Bitmap)
        UltraDataColumn30.DataType = GetType(Double)
        Me.OrgDocumentosFec.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
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
        'odDocAgregado
        '
        Me.odDocAgregado.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72})
        Me.odDocAgregado.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'MenuAgregadosFactory
        '
        Me.MenuAgregadosFactory.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuAgregadosFactory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuAgregadosFactory.Name = "mnu_Transferencias"
        Me.MenuAgregadosFactory.Size = New System.Drawing.Size(112, 30)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 26)
        Me.ToolStripMenuItem1.Text = "Quitar"
        '
        'UltraDataSource3
        '
        UltraDataColumn76.DataType = GetType(Integer)
        UltraDataColumn77.DataType = GetType(Date)
        UltraDataColumn78.DataType = GetType(Double)
        UltraDataColumn79.DataType = GetType(Double)
        UltraDataColumn80.DataType = GetType(Double)
        UltraDataColumn81.DataType = GetType(Double)
        UltraDataColumn82.DataType = GetType(Double)
        UltraDataColumn83.DataType = GetType(Double)
        UltraDataColumn84.DataType = GetType(Double)
        UltraDataColumn85.DataType = GetType(Integer)
        UltraDataColumn86.DataType = GetType(Integer)
        UltraDataColumn87.DataType = GetType(Integer)
        UltraDataColumn88.DataType = GetType(Double)
        UltraDataColumn89.DataType = GetType(Double)
        UltraDataColumn90.DataType = GetType(Double)
        UltraDataColumn91.DataType = GetType(Double)
        UltraDataColumn92.DataType = GetType(Double)
        UltraDataColumn97.DataType = GetType(Date)
        UltraDataColumn99.DataType = GetType(Date)
        UltraDataColumn101.DataType = GetType(Boolean)
        UltraDataColumn102.DataType = GetType(Date)
        UltraDataColumn103.DataType = GetType(Double)
        UltraDataColumn104.DataType = GetType(Double)
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109})
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
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("Neto", Object), CType("1", Object)})})
        '
        'tcFactoringFedd
        '
        Me.tcFactoringFedd.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcFactoringFedd.Controls.Add(Me.UltraTabPageControl2)
        Me.tcFactoringFedd.Controls.Add(Me.UltraTabPageControl1)
        Me.tcFactoringFedd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcFactoringFedd.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcFactoringFedd.Location = New System.Drawing.Point(0, 0)
        Me.tcFactoringFedd.Name = "tcFactoringFedd"
        Me.tcFactoringFedd.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcFactoringFedd.Size = New System.Drawing.Size(1190, 485)
        Me.tcFactoringFedd.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista Factoring/FEDD"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Factoring/FEDD"
        Me.tcFactoringFedd.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcFactoringFedd.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1188, 462)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion12)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1188, 462)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.CausesValidation = False
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Agrupacion3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1188, 344)
        Me.SplitContainer1.SplitterDistance = 195
        Me.SplitContainer1.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.CausesValidation = False
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Espere1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GridAgregados)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GridFactoring)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Agrupacion2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1188, 195)
        Me.SplitContainer2.SplitterDistance = 677
        Me.SplitContainer2.TabIndex = 0
        '
        'Espere1
        '
        Me.Espere1.Location = New System.Drawing.Point(282, 63)
        Me.Espere1.Name = "Espere1"
        Me.Espere1.Size = New System.Drawing.Size(393, 67)
        Me.Espere1.TabIndex = 23
        Me.Espere1.Visible = False
        '
        'GridAgregados
        '
        Me.GridAgregados.ContextMenuStrip = Me.MenuAgregados
        Me.GridAgregados.DataSource = Me.odDocAgregado
        UltraGridColumn136.Header.VisiblePosition = 0
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.Caption = "Periodo"
        UltraGridColumn137.Header.VisiblePosition = 1
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn138.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn138.Header.Caption = "TipoDoc"
        UltraGridColumn138.Header.VisiblePosition = 4
        UltraGridColumn138.Width = 70
        UltraGridColumn139.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn139.Header.VisiblePosition = 5
        UltraGridColumn139.Width = 55
        UltraGridColumn140.Header.VisiblePosition = 6
        UltraGridColumn140.Width = 80
        UltraGridColumn141.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn141.Header.Caption = "Fec.Emision"
        UltraGridColumn141.Header.VisiblePosition = 7
        UltraGridColumn141.Width = 78
        UltraGridColumn142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn142.Header.Caption = "Fec.Venc."
        UltraGridColumn142.Header.VisiblePosition = 8
        UltraGridColumn142.Width = 73
        UltraGridColumn143.Header.VisiblePosition = 9
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 18
        UltraGridColumn144.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn145.CellAppearance = Appearance1
        UltraGridColumn145.Format = "#,##0.00"
        UltraGridColumn145.Header.VisiblePosition = 11
        UltraGridColumn145.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn145.Width = 102
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn146.CellAppearance = Appearance2
        UltraGridColumn146.Format = "#,##0.00"
        UltraGridColumn146.Header.VisiblePosition = 12
        UltraGridColumn146.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn147.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn147.Header.Caption = "Cliente"
        UltraGridColumn147.Header.VisiblePosition = 3
        UltraGridColumn147.Width = 177
        UltraGridColumn148.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn148.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn148.Header.VisiblePosition = 13
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 14
        UltraGridColumn149.Hidden = True
        UltraGridColumn150.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn150.Header.Caption = "Tipo"
        UltraGridColumn150.Header.VisiblePosition = 2
        UltraGridColumn150.Hidden = True
        UltraGridColumn151.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn151.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn151.Header.Caption = "Mon."
        UltraGridColumn151.Header.VisiblePosition = 10
        UltraGridColumn151.Width = 35
        UltraGridColumn152.Header.VisiblePosition = 15
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 16
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 17
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 19
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 25
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn157.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn157.Header.VisiblePosition = 20
        UltraGridColumn157.Hidden = True
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn158.CellAppearance = Appearance3
        UltraGridColumn158.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn158.Format = "#,##0.00"
        UltraGridColumn158.Header.Caption = "Monto Aplicar"
        UltraGridColumn158.Header.VisiblePosition = 21
        UltraGridColumn158.Hidden = True
        UltraGridColumn158.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn159.Header.VisiblePosition = 22
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 23
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 24
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 26
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 27
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 28
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 29
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 30
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 31
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 32
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 33
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 34
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 35
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 36
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 37
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 38
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 39
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 40
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 41
        UltraGridColumn177.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridAgregados.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.GridAgregados.DisplayLayout.MaxColScrollRegions = 1
        Me.GridAgregados.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridAgregados.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridAgregados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridAgregados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridAgregados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridAgregados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridAgregados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridAgregados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridAgregados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridAgregados.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridAgregados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAgregados.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridAgregados.Location = New System.Drawing.Point(0, 0)
        Me.GridAgregados.Name = "GridAgregados"
        Me.GridAgregados.Size = New System.Drawing.Size(677, 195)
        Me.GridAgregados.TabIndex = 22
        Me.GridAgregados.Text = "Ventas Agregadas"
        '
        'GridFactoring
        '
        Me.GridFactoring.ContextMenuStrip = Me.MenuAgregadosFactory
        Me.GridFactoring.DataSource = Me.UltraDataSource3
        UltraGridColumn178.Header.VisiblePosition = 0
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 1
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 2
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 3
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 4
        UltraGridColumn183.Header.VisiblePosition = 5
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 6
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.VisiblePosition = 29
        UltraGridColumn185.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn186.CellAppearance = Appearance4
        UltraGridColumn186.Format = "#,##0.00"
        UltraGridColumn186.Header.VisiblePosition = 8
        UltraGridColumn187.Header.VisiblePosition = 9
        UltraGridColumn187.Hidden = True
        UltraGridColumn188.Header.VisiblePosition = 10
        UltraGridColumn188.Hidden = True
        UltraGridColumn189.Header.VisiblePosition = 11
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 12
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 13
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 14
        UltraGridColumn192.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn193.CellAppearance = Appearance5
        UltraGridColumn193.Format = "#,##0.00"
        UltraGridColumn193.Header.VisiblePosition = 15
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn194.CellAppearance = Appearance6
        UltraGridColumn194.Format = "#,##0.00"
        UltraGridColumn194.Header.VisiblePosition = 16
        UltraGridColumn195.Header.VisiblePosition = 17
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 18
        UltraGridColumn196.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn197.CellAppearance = Appearance7
        UltraGridColumn197.Format = "#,##0.00"
        UltraGridColumn197.Header.VisiblePosition = 20
        UltraGridColumn198.Header.VisiblePosition = 21
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 22
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.Header.VisiblePosition = 31
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 23
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 24
        UltraGridColumn202.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 25
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 26
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 27
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 28
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 30
        UltraGridColumn207.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn208.CellAppearance = Appearance8
        UltraGridColumn208.Format = "#,##0.00"
        UltraGridColumn208.Header.VisiblePosition = 7
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn209.CellAppearance = Appearance9
        UltraGridColumn209.Format = "#,##0.00"
        UltraGridColumn209.Header.VisiblePosition = 19
        UltraGridColumn210.Header.VisiblePosition = 32
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 33
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 34
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 35
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 36
        UltraGridColumn214.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214})
        Me.GridFactoring.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.GridFactoring.DisplayLayout.MaxColScrollRegions = 1
        Me.GridFactoring.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridFactoring.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridFactoring.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.GridFactoring.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridFactoring.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridFactoring.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridFactoring.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridFactoring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFactoring.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFactoring.Location = New System.Drawing.Point(0, 83)
        Me.GridFactoring.Name = "GridFactoring"
        Me.GridFactoring.Size = New System.Drawing.Size(507, 112)
        Me.GridFactoring.TabIndex = 26
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.lblTotalFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion2.Controls.Add(Me.DecGastosFactoring)
        Me.Agrupacion2.Controls.Add(Me.CalcFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion2.Controls.Add(Me.DecTasaInteresFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion2.Controls.Add(Me.DecComisionFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion2.Controls.Add(Me.DecMontoInteresFactoring)
        Me.Agrupacion2.Controls.Add(Me.btnAgregar)
        Me.Agrupacion2.Controls.Add(Me.txtCodigoBancoFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion2.Controls.Add(Me.DecTotalFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion2.Controls.Add(Me.FecVencimientoFactoring)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(507, 83)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'lblTotalFactoring
        '
        Me.lblTotalFactoring.AutoSize = True
        Me.lblTotalFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFactoring.ForeColor = System.Drawing.Color.Black
        Me.lblTotalFactoring.Location = New System.Drawing.Point(352, 63)
        Me.lblTotalFactoring.Name = "lblTotalFactoring"
        Me.lblTotalFactoring.Size = New System.Drawing.Size(42, 14)
        Me.lblTotalFactoring.TabIndex = 75
        Me.lblTotalFactoring.Text = "TOTAL"
        '
        'Etiqueta25
        '
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(264, 41)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta25.TabIndex = 74
        Me.Etiqueta25.Text = "Gastos:"
        '
        'DecGastosFactoring
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.DecGastosFactoring.Appearance = Appearance10
        Me.DecGastosFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecGastosFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecGastosFactoring.ForeColor = System.Drawing.Color.Black
        Me.DecGastosFactoring.Location = New System.Drawing.Point(263, 57)
        Me.DecGastosFactoring.Name = "DecGastosFactoring"
        Me.DecGastosFactoring.NullText = "0.00"
        Me.DecGastosFactoring.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecGastosFactoring.Size = New System.Drawing.Size(83, 21)
        Me.DecGastosFactoring.TabIndex = 36
        '
        'CalcFactoring
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.CalcFactoring.Appearance = Appearance11
        Me.CalcFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CalcFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcFactoring.ForeColor = System.Drawing.Color.Black
        Me.CalcFactoring.Location = New System.Drawing.Point(65, 57)
        Me.CalcFactoring.Name = "CalcFactoring"
        Me.CalcFactoring.Size = New System.Drawing.Size(12, 21)
        Me.CalcFactoring.TabIndex = 72
        Me.CalcFactoring.Text = "0"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(80, 61)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta4.TabIndex = 71
        Me.Etiqueta4.Text = "%"
        '
        'DecTasaInteresFactoring
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInteresFactoring.Appearance = Appearance12
        Me.DecTasaInteresFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTasaInteresFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTasaInteresFactoring.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInteresFactoring.Location = New System.Drawing.Point(4, 57)
        Me.DecTasaInteresFactoring.MaskInput = "{double:3.4}"
        Me.DecTasaInteresFactoring.Name = "DecTasaInteresFactoring"
        Me.DecTasaInteresFactoring.NullText = "0.00"
        Me.DecTasaInteresFactoring.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTasaInteresFactoring.Size = New System.Drawing.Size(60, 21)
        Me.DecTasaInteresFactoring.TabIndex = 33
        '
        'Etiqueta24
        '
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(3, 42)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta24.TabIndex = 69
        Me.Etiqueta24.Text = "Tasa:"
        '
        'Etiqueta23
        '
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(180, 42)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta23.TabIndex = 68
        Me.Etiqueta23.Text = "Comision:"
        '
        'DecComisionFactoring
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.DecComisionFactoring.Appearance = Appearance13
        Me.DecComisionFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecComisionFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecComisionFactoring.ForeColor = System.Drawing.Color.Black
        Me.DecComisionFactoring.Location = New System.Drawing.Point(179, 58)
        Me.DecComisionFactoring.Name = "DecComisionFactoring"
        Me.DecComisionFactoring.NullText = "0.00"
        Me.DecComisionFactoring.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecComisionFactoring.Size = New System.Drawing.Size(81, 21)
        Me.DecComisionFactoring.TabIndex = 35
        '
        'Etiqueta22
        '
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(96, 42)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(67, 14)
        Me.Etiqueta22.TabIndex = 66
        Me.Etiqueta22.Text = "Monto Tasa:"
        '
        'DecMontoInteresFactoring
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.DecMontoInteresFactoring.Appearance = Appearance14
        Me.DecMontoInteresFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecMontoInteresFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecMontoInteresFactoring.ForeColor = System.Drawing.Color.Black
        Me.DecMontoInteresFactoring.Location = New System.Drawing.Point(96, 58)
        Me.DecMontoInteresFactoring.Name = "DecMontoInteresFactoring"
        Me.DecMontoInteresFactoring.NullText = "0.00"
        Me.DecMontoInteresFactoring.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecMontoInteresFactoring.Size = New System.Drawing.Size(80, 21)
        Me.DecMontoInteresFactoring.TabIndex = 34
        '
        'btnAgregar
        '
        Appearance15.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance15
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAgregar.Location = New System.Drawing.Point(310, 14)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(37, 29)
        Me.btnAgregar.TabIndex = 37
        '
        'txtCodigoBancoFactoring
        '
        Me.txtCodigoBancoFactoring.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoBancoFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoBancoFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBancoFactoring.Location = New System.Drawing.Point(3, 19)
        Me.txtCodigoBancoFactoring.MaxLength = 50
        Me.txtCodigoBancoFactoring.Name = "txtCodigoBancoFactoring"
        Me.txtCodigoBancoFactoring.Size = New System.Drawing.Size(111, 21)
        Me.txtCodigoBancoFactoring.TabIndex = 30
        '
        'Etiqueta21
        '
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(3, 4)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta21.TabIndex = 64
        Me.Etiqueta21.Text = "CodigoBanco:"
        '
        'DecTotalFactoring
        '
        Appearance16.ForeColor = System.Drawing.Color.Black
        Me.DecTotalFactoring.Appearance = Appearance16
        Me.DecTotalFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalFactoring.ForeColor = System.Drawing.Color.Black
        Me.DecTotalFactoring.Location = New System.Drawing.Point(116, 19)
        Me.DecTotalFactoring.Name = "DecTotalFactoring"
        Me.DecTotalFactoring.NullText = "0.00"
        Me.DecTotalFactoring.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalFactoring.Size = New System.Drawing.Size(103, 21)
        Me.DecTotalFactoring.TabIndex = 31
        '
        'Etiqueta19
        '
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(116, 4)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(80, 14)
        Me.Etiqueta19.TabIndex = 62
        Me.Etiqueta19.Text = "TotalFactoring:"
        '
        'FecVencimientoFactoring
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.FecVencimientoFactoring.Appearance = Appearance17
        Me.FecVencimientoFactoring.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimientoFactoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimientoFactoring.ForeColor = System.Drawing.Color.Black
        Me.FecVencimientoFactoring.Location = New System.Drawing.Point(221, 19)
        Me.FecVencimientoFactoring.Name = "FecVencimientoFactoring"
        Me.FecVencimientoFactoring.Size = New System.Drawing.Size(87, 21)
        Me.FecVencimientoFactoring.TabIndex = 32
        '
        'Etiqueta20
        '
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(221, 4)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta20.TabIndex = 59
        Me.Etiqueta20.Text = "F. Vencimiento:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.GridDocumentosVentas)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 28)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1188, 117)
        Me.Agrupacion5.TabIndex = 25
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'GridDocumentosVentas
        '
        Me.GridDocumentosVentas.ContextMenuStrip = Me.MenuDetalle
        Me.GridDocumentosVentas.DataSource = Me.UltraDataSource1
        UltraGridColumn215.Header.VisiblePosition = 0
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.Caption = "Periodo"
        UltraGridColumn216.Header.VisiblePosition = 1
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.Caption = "TipoDoc"
        UltraGridColumn217.Header.VisiblePosition = 4
        UltraGridColumn217.Width = 72
        UltraGridColumn218.Header.VisiblePosition = 5
        UltraGridColumn218.Width = 71
        UltraGridColumn219.Header.VisiblePosition = 6
        UltraGridColumn219.Width = 104
        UltraGridColumn220.Header.VisiblePosition = 7
        UltraGridColumn220.Width = 99
        UltraGridColumn221.Header.VisiblePosition = 8
        UltraGridColumn222.Header.VisiblePosition = 9
        UltraGridColumn222.Hidden = True
        UltraGridColumn223.Header.VisiblePosition = 10
        UltraGridColumn223.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn224.CellAppearance = Appearance18
        UltraGridColumn224.Format = "#,##0.00"
        UltraGridColumn224.Header.VisiblePosition = 12
        UltraGridColumn224.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn225.CellAppearance = Appearance19
        UltraGridColumn225.Format = "#,##0.00"
        UltraGridColumn225.Header.VisiblePosition = 13
        UltraGridColumn225.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn226.Header.Caption = "Cliente"
        UltraGridColumn226.Header.VisiblePosition = 3
        UltraGridColumn226.Width = 282
        UltraGridColumn227.Header.VisiblePosition = 14
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 15
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.Caption = "Tipo"
        UltraGridColumn229.Header.VisiblePosition = 2
        UltraGridColumn229.Hidden = True
        UltraGridColumn230.Header.Caption = "Mon."
        UltraGridColumn230.Header.VisiblePosition = 11
        UltraGridColumn230.Width = 40
        UltraGridColumn231.Header.VisiblePosition = 16
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 17
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 18
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 19
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 21
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.VisiblePosition = 22
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 20
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 23
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 24
        UltraGridColumn239.Hidden = True
        UltraGridColumn240.Header.VisiblePosition = 25
        UltraGridColumn240.Hidden = True
        UltraGridColumn241.Header.VisiblePosition = 26
        UltraGridColumn241.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 27
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 28
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.VisiblePosition = 29
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 30
        UltraGridColumn245.Hidden = True
        UltraGridColumn246.Header.VisiblePosition = 31
        UltraGridColumn246.Hidden = True
        UltraGridColumn247.Header.VisiblePosition = 32
        UltraGridColumn247.Hidden = True
        UltraGridColumn279.Header.VisiblePosition = 33
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 34
        UltraGridColumn280.Hidden = True
        UltraGridColumn281.Header.VisiblePosition = 35
        UltraGridColumn281.Hidden = True
        UltraGridColumn282.Header.VisiblePosition = 36
        UltraGridColumn282.Hidden = True
        UltraGridColumn283.Header.VisiblePosition = 37
        UltraGridColumn283.Hidden = True
        UltraGridColumn284.Header.VisiblePosition = 38
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.VisiblePosition = 39
        UltraGridColumn285.Hidden = True
        UltraGridColumn286.Header.VisiblePosition = 40
        UltraGridColumn286.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286})
        Me.GridDocumentosVentas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.GridDocumentosVentas.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.GridDocumentosVentas.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.GridDocumentosVentas.DisplayLayout.MaxColScrollRegions = 1
        Me.GridDocumentosVentas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridDocumentosVentas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridDocumentosVentas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridDocumentosVentas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridDocumentosVentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridDocumentosVentas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridDocumentosVentas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridDocumentosVentas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridDocumentosVentas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridDocumentosVentas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.GridDocumentosVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDocumentosVentas.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridDocumentosVentas.Location = New System.Drawing.Point(2, 2)
        Me.GridDocumentosVentas.Name = "GridDocumentosVentas"
        Me.GridDocumentosVentas.Size = New System.Drawing.Size(1184, 113)
        Me.GridDocumentosVentas.TabIndex = 23
        Me.GridDocumentosVentas.Text = "Ventas"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnListaDoc)
        Me.Agrupacion3.Controls.Add(Me.cboClienteFac)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta28)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1188, 28)
        Me.Agrupacion3.TabIndex = 24
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListaDoc
        '
        Appearance20.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListaDoc.Appearance = Appearance20
        Me.btnListaDoc.AutoSize = True
        Me.btnListaDoc.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListaDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListaDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaDoc.ForeColor = System.Drawing.Color.Black
        Me.btnListaDoc.Location = New System.Drawing.Point(359, 1)
        Me.btnListaDoc.Name = "btnListaDoc"
        Me.btnListaDoc.Size = New System.Drawing.Size(26, 26)
        Me.btnListaDoc.TabIndex = 476
        '
        'cboClienteFac
        '
        Me.cboClienteFac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboClienteFac.DisplayMember = "Nombre"
        Me.cboClienteFac.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteFac.Location = New System.Drawing.Point(57, 3)
        Me.cboClienteFac.Name = "cboClienteFac"
        Me.cboClienteFac.Size = New System.Drawing.Size(295, 22)
        Me.cboClienteFac.TabIndex = 475
        Me.cboClienteFac.ValueMember = "Id"
        '
        'Etiqueta28
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.FontData.BoldAsString = "True"
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance21
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(11, 7)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta28.TabIndex = 55
        Me.Etiqueta28.Text = "Cliente"
        '
        'Agrupacion12
        '
        Me.Agrupacion12.Controls.Add(Me.chkFactoring)
        Me.Agrupacion12.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion12.Controls.Add(Me.txt_Glosa)
        Me.Agrupacion12.Controls.Add(Me.CboMoneda)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion12.Controls.Add(Me.DecTC)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion12.Controls.Add(Me.AgrDatosObligacionFin)
        Me.Agrupacion12.Controls.Add(Me.FecVencimiento)
        Me.Agrupacion12.Controls.Add(Me.CboCtaBancaria)
        Me.Agrupacion12.Controls.Add(Me.CboTipo)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion12.Controls.Add(Me.TxtUnico)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion12.Controls.Add(Me.FecFecha)
        Me.Agrupacion12.Controls.Add(Me.CboBanco)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion12.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion12.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion12.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion12.Name = "Agrupacion12"
        Me.Agrupacion12.Size = New System.Drawing.Size(1188, 118)
        Me.Agrupacion12.TabIndex = 0
        Me.Agrupacion12.Text = "Factory/FEDD"
        Me.Agrupacion12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'chkFactoring
        '
        Appearance22.FontData.BoldAsString = "True"
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.chkFactoring.Appearance = Appearance22
        Me.chkFactoring.AutoSize = True
        Me.chkFactoring.BackColor = System.Drawing.Color.Transparent
        Me.chkFactoring.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkFactoring.Location = New System.Drawing.Point(540, 70)
        Me.chkFactoring.Name = "chkFactoring"
        Me.chkFactoring.Size = New System.Drawing.Size(142, 18)
        Me.chkFactoring.TabIndex = 76
        Me.chkFactoring.Text = "Factoring sin Cta Ban."
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.decImporteDol)
        Me.Agrupacion4.Controls.Add(Me.decImporteSol)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(987, 20)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(182, 94)
        Me.Agrupacion4.TabIndex = 55
        Me.Agrupacion4.Text = "Total de Documentos"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'decImporteDol
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.decImporteDol.Appearance = Appearance23
        Me.decImporteDol.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteDol.Enabled = False
        Me.decImporteDol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteDol.ForeColor = System.Drawing.Color.Black
        Me.decImporteDol.Location = New System.Drawing.Point(74, 55)
        Me.decImporteDol.Name = "decImporteDol"
        Me.decImporteDol.NullText = "0.00"
        Me.decImporteDol.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteDol.ReadOnly = True
        Me.decImporteDol.Size = New System.Drawing.Size(103, 21)
        Me.decImporteDol.TabIndex = 38
        '
        'decImporteSol
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.decImporteSol.Appearance = Appearance24
        Me.decImporteSol.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteSol.Enabled = False
        Me.decImporteSol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteSol.ForeColor = System.Drawing.Color.Black
        Me.decImporteSol.Location = New System.Drawing.Point(74, 28)
        Me.decImporteSol.Name = "decImporteSol"
        Me.decImporteSol.NullText = "0.00"
        Me.decImporteSol.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteSol.ReadOnly = True
        Me.decImporteSol.Size = New System.Drawing.Size(103, 21)
        Me.decImporteSol.TabIndex = 37
        '
        'Etiqueta15
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.FontData.BoldAsString = "True"
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance25
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(6, 32)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta15.TabIndex = 20
        Me.Etiqueta15.Text = "Importe S/."
        '
        'Etiqueta16
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance26
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(11, 59)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta16.TabIndex = 36
        Me.Etiqueta16.Text = "Importe $."
        '
        'Etiqueta14
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.FontData.BoldAsString = "True"
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance27
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(27, 94)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta14.TabIndex = 54
        Me.Etiqueta14.Text = "Glosa:"
        '
        'txt_Glosa
        '
        Me.txt_Glosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Glosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txt_Glosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Glosa.Location = New System.Drawing.Point(70, 92)
        Me.txt_Glosa.MaxLength = 200
        Me.txt_Glosa.Name = "txt_Glosa"
        Me.txt_Glosa.Size = New System.Drawing.Size(602, 21)
        Me.txt_Glosa.TabIndex = 17
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
        Me.CboMoneda.Location = New System.Drawing.Point(424, 46)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(113, 21)
        Me.CboMoneda.TabIndex = 12
        Me.CboMoneda.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.FontData.BoldAsString = "True"
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance29
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(367, 49)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta12.TabIndex = 48
        Me.Etiqueta12.Text = "Moneda:"
        '
        'DecTC
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance30
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(578, 21)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(94, 21)
        Me.DecTC.TabIndex = 14
        '
        'Etiqueta13
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.FontData.BoldAsString = "True"
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance31
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(543, 24)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta13.TabIndex = 47
        Me.Etiqueta13.Text = "T. C."
        '
        'AgrDatosObligacionFin
        '
        Me.AgrDatosObligacionFin.Controls.Add(Me.DecSubTotal)
        Me.AgrDatosObligacionFin.Controls.Add(Me.Etiqueta17)
        Me.AgrDatosObligacionFin.Controls.Add(Me.NumCalc)
        Me.AgrDatosObligacionFin.Controls.Add(Me.Etiqueta10)
        Me.AgrDatosObligacionFin.Controls.Add(Me.DecTasaInt)
        Me.AgrDatosObligacionFin.Controls.Add(Me.Etiqueta6)
        Me.AgrDatosObligacionFin.Controls.Add(Me.DecInteresMonto)
        Me.AgrDatosObligacionFin.Controls.Add(Me.Etiqueta3)
        Me.AgrDatosObligacionFin.Controls.Add(Me.DecTotalPagar)
        Me.AgrDatosObligacionFin.Controls.Add(Me.Etiqueta8)
        Me.AgrDatosObligacionFin.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgrDatosObligacionFin.ForeColor = System.Drawing.Color.Black
        Me.AgrDatosObligacionFin.Location = New System.Drawing.Point(678, 19)
        Me.AgrDatosObligacionFin.Name = "AgrDatosObligacionFin"
        Me.AgrDatosObligacionFin.Size = New System.Drawing.Size(307, 95)
        Me.AgrDatosObligacionFin.TabIndex = 18
        Me.AgrDatosObligacionFin.Text = "Datos - Obligaciones Financieras"
        Me.AgrDatosObligacionFin.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'DecSubTotal
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.DecSubTotal.Appearance = Appearance32
        Me.DecSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSubTotal.ForeColor = System.Drawing.Color.Black
        Me.DecSubTotal.Location = New System.Drawing.Point(63, 20)
        Me.DecSubTotal.Name = "DecSubTotal"
        Me.DecSubTotal.NullText = "0.00"
        Me.DecSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSubTotal.Size = New System.Drawing.Size(89, 21)
        Me.DecSubTotal.TabIndex = 18
        '
        'Etiqueta17
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance33
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(4, 25)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta17.TabIndex = 58
        Me.Etiqueta17.Text = "SubTotal:"
        '
        'NumCalc
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.NumCalc.Appearance = Appearance34
        Me.NumCalc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCalc.ForeColor = System.Drawing.Color.Black
        Me.NumCalc.Location = New System.Drawing.Point(140, 44)
        Me.NumCalc.Name = "NumCalc"
        Me.NumCalc.Size = New System.Drawing.Size(12, 21)
        Me.NumCalc.TabIndex = 57
        Me.NumCalc.Text = "0"
        '
        'Etiqueta10
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance35
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(158, 48)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta10.TabIndex = 56
        Me.Etiqueta10.Text = "%"
        '
        'DecTasaInt
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInt.Appearance = Appearance36
        Me.DecTasaInt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTasaInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTasaInt.ForeColor = System.Drawing.Color.Black
        Me.DecTasaInt.Location = New System.Drawing.Point(63, 44)
        Me.DecTasaInt.MaskInput = "{double:3.4}"
        Me.DecTasaInt.Name = "DecTasaInt"
        Me.DecTasaInt.NullText = "0.00"
        Me.DecTasaInt.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTasaInt.Size = New System.Drawing.Size(76, 21)
        Me.DecTasaInt.TabIndex = 19
        '
        'Etiqueta6
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance37
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(13, 72)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(44, 14)
        Me.Etiqueta6.TabIndex = 50
        Me.Etiqueta6.Text = "Interes:"
        '
        'DecInteresMonto
        '
        Appearance38.ForeColor = System.Drawing.Color.Black
        Me.DecInteresMonto.Appearance = Appearance38
        Me.DecInteresMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecInteresMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecInteresMonto.ForeColor = System.Drawing.Color.Black
        Me.DecInteresMonto.Location = New System.Drawing.Point(63, 68)
        Me.DecInteresMonto.Name = "DecInteresMonto"
        Me.DecInteresMonto.NullText = "0.00"
        Me.DecInteresMonto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecInteresMonto.Size = New System.Drawing.Size(89, 21)
        Me.DecInteresMonto.TabIndex = 20
        '
        'Etiqueta3
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance39
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(153, 72)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta3.TabIndex = 45
        Me.Etiqueta3.Text = "Total:"
        '
        'DecTotalPagar
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.DecTotalPagar.Appearance = Appearance40
        Me.DecTotalPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTotalPagar.Enabled = False
        Me.DecTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTotalPagar.ForeColor = System.Drawing.Color.Black
        Me.DecTotalPagar.Location = New System.Drawing.Point(190, 68)
        Me.DecTotalPagar.Name = "DecTotalPagar"
        Me.DecTotalPagar.NullText = "0.00"
        Me.DecTotalPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTotalPagar.Size = New System.Drawing.Size(103, 21)
        Me.DecTotalPagar.TabIndex = 23
        '
        'Etiqueta8
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance41
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(23, 48)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta8.TabIndex = 13
        Me.Etiqueta8.Text = "Tasa:"
        '
        'FecVencimiento
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Appearance = Appearance42
        Me.FecVencimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecVencimiento.ForeColor = System.Drawing.Color.Black
        Me.FecVencimiento.Location = New System.Drawing.Point(459, 21)
        Me.FecVencimiento.Name = "FecVencimiento"
        Me.FecVencimiento.Size = New System.Drawing.Size(78, 21)
        Me.FecVencimiento.TabIndex = 21
        '
        'CboCtaBancaria
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.CboCtaBancaria.Appearance = Appearance43
        Me.CboCtaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.CboCtaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboCtaBancaria.DropDownListWidth = 400
        Me.CboCtaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboCtaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCtaBancaria.ForeColor = System.Drawing.Color.Black
        Me.CboCtaBancaria.Location = New System.Drawing.Point(70, 68)
        Me.CboCtaBancaria.Name = "CboCtaBancaria"
        Me.CboCtaBancaria.Size = New System.Drawing.Size(279, 21)
        Me.CboCtaBancaria.TabIndex = 15
        Me.CboCtaBancaria.ValueMember = "Id"
        '
        'CboTipo
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.CboTipo.Appearance = Appearance44
        Me.CboTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboTipo.DropDownListWidth = 300
        Me.CboTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipo.ForeColor = System.Drawing.Color.Black
        Me.CboTipo.Location = New System.Drawing.Point(424, 69)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(113, 21)
        Me.CboTipo.TabIndex = 16
        Me.CboTipo.ValueMember = "Id"
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
        Me.Etiqueta7.Location = New System.Drawing.Point(355, 25)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(98, 14)
        Me.Etiqueta7.TabIndex = 12
        Me.Etiqueta7.Text = "Fec. Vencimiento:"
        '
        'Etiqueta2
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.FontData.BoldAsString = "True"
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance46
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(355, 73)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta2.TabIndex = 43
        Me.Etiqueta2.Text = "Tipo Oblig.:"
        '
        'TxtUnico
        '
        Me.TxtUnico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUnico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.TxtUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnico.Location = New System.Drawing.Point(70, 21)
        Me.TxtUnico.MaxLength = 50
        Me.TxtUnico.Name = "TxtUnico"
        Me.TxtUnico.Size = New System.Drawing.Size(111, 21)
        Me.TxtUnico.TabIndex = 10
        '
        'Etiqueta5
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.FontData.BoldAsString = "True"
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance47
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(4, 24)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta5.TabIndex = 40
        Me.Etiqueta5.Text = "Nro Unico:"
        '
        'Etiqueta1
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.FontData.BoldAsString = "True"
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance48
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 70)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(56, 14)
        Me.Etiqueta1.TabIndex = 39
        Me.Etiqueta1.Text = "Cta Banc."
        '
        'FecFecha
        '
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Appearance = Appearance49
        Me.FecFecha.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.FecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.FecFecha.Location = New System.Drawing.Point(268, 21)
        Me.FecFecha.Name = "FecFecha"
        Me.FecFecha.Size = New System.Drawing.Size(81, 21)
        Me.FecFecha.TabIndex = 11
        '
        'CboBanco
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.CboBanco.Appearance = Appearance50
        Me.CboBanco.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboBanco.DropDownListWidth = 400
        Me.CboBanco.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBanco.ForeColor = System.Drawing.Color.Black
        ValueListItem6.DataValue = "ValueListItem0"
        ValueListItem6.DisplayText = "BANCO DE LA NACION"
        ValueListItem7.DataValue = "ValueListItem1"
        ValueListItem7.DisplayText = "BANCO DE CREDITO"
        ValueListItem8.DataValue = "ValueListItem2"
        ValueListItem8.DisplayText = "CAJA PIURA"
        Me.CboBanco.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem6, ValueListItem7, ValueListItem8})
        Me.CboBanco.Location = New System.Drawing.Point(70, 45)
        Me.CboBanco.Name = "CboBanco"
        Me.CboBanco.Size = New System.Drawing.Size(279, 21)
        Me.CboBanco.TabIndex = 13
        Me.CboBanco.ValueMember = "Id"
        '
        'Etiqueta18
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.FontData.BoldAsString = "True"
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance51
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(187, 25)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(75, 14)
        Me.Etiqueta18.TabIndex = 11
        Me.Etiqueta18.Text = "Fec. Emision:"
        '
        'Etiqueta11
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.FontData.BoldAsString = "True"
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance52
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(23, 46)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Banco:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.GridFactoringFedd)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1188, 462)
        '
        'GridFactoringFedd
        '
        Me.GridFactoringFedd.DataSource = Me.OrgDocumentosFec
        UltraGridColumn248.Header.VisiblePosition = 0
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 1
        UltraGridColumn250.Header.Caption = "Tipo Obligacion"
        UltraGridColumn250.Header.VisiblePosition = 2
        UltraGridColumn251.Header.Caption = "Entidad Financiera"
        UltraGridColumn251.Header.VisiblePosition = 3
        UltraGridColumn252.Header.VisiblePosition = 4
        UltraGridColumn253.Header.VisiblePosition = 5
        UltraGridColumn254.Header.VisiblePosition = 6
        UltraGridColumn255.Header.VisiblePosition = 7
        UltraGridColumn256.Header.Caption = "Moneda"
        UltraGridColumn256.Header.VisiblePosition = 8
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn257.CellAppearance = Appearance53
        UltraGridColumn257.Format = "#,##0.00"
        UltraGridColumn257.Header.Caption = "T.C."
        UltraGridColumn257.Header.VisiblePosition = 9
        UltraGridColumn257.Width = 60
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn258.CellAppearance = Appearance54
        UltraGridColumn258.Format = "#,##0.00"
        UltraGridColumn258.Header.VisiblePosition = 10
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn259.CellAppearance = Appearance55
        UltraGridColumn259.Format = "#,##0.00"
        UltraGridColumn259.Header.VisiblePosition = 11
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn260.CellAppearance = Appearance56
        UltraGridColumn260.Format = "#,##0.00"
        UltraGridColumn260.Header.VisiblePosition = 12
        UltraGridColumn261.Header.VisiblePosition = 13
        UltraGridColumn261.Hidden = True
        UltraGridColumn262.Header.VisiblePosition = 14
        UltraGridColumn262.Hidden = True
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn263.CellAppearance = Appearance57
        UltraGridColumn263.Format = "#,##0.00"
        UltraGridColumn263.Header.VisiblePosition = 15
        UltraGridColumn264.Header.VisiblePosition = 16
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264})
        UltraGridBand4.Override.FilterUIProvider = Me.Filtro1
        UltraGridColumn265.Header.VisiblePosition = 0
        UltraGridColumn265.Hidden = True
        UltraGridColumn266.Header.VisiblePosition = 1
        UltraGridColumn266.Hidden = True
        UltraGridColumn267.Header.VisiblePosition = 2
        UltraGridColumn268.Header.VisiblePosition = 3
        UltraGridColumn269.Header.VisiblePosition = 4
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn270.CellAppearance = Appearance58
        UltraGridColumn270.Format = "#,##0.00"
        UltraGridColumn270.Header.VisiblePosition = 5
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn271.CellAppearance = Appearance59
        UltraGridColumn271.Format = "#,##0.00"
        UltraGridColumn271.Header.VisiblePosition = 6
        Appearance60.TextHAlignAsString = "Right"
        UltraGridColumn272.CellAppearance = Appearance60
        UltraGridColumn272.Format = "#,##0.00"
        UltraGridColumn272.Header.VisiblePosition = 7
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn273.CellAppearance = Appearance61
        UltraGridColumn273.Format = "#,##0.00"
        UltraGridColumn273.Header.VisiblePosition = 8
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn274.CellAppearance = Appearance62
        UltraGridColumn274.Format = "#,##0.00"
        UltraGridColumn274.Header.VisiblePosition = 9
        Appearance63.TextHAlignAsString = "Right"
        UltraGridColumn275.CellAppearance = Appearance63
        UltraGridColumn275.Format = "#,##0.00"
        UltraGridColumn275.Header.VisiblePosition = 10
        UltraGridColumn276.Header.VisiblePosition = 11
        UltraGridColumn276.Hidden = True
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn277.CellAppearance = Appearance64
        UltraGridColumn277.Format = "#,##0.00"
        UltraGridColumn277.Header.VisiblePosition = 12
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn278.CellAppearance = Appearance65
        UltraGridColumn278.Format = "#,##0.00"
        UltraGridColumn278.Header.VisiblePosition = 13
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278})
        UltraGridBand5.Override.FilterUIProvider = Me.Filtro1
        Me.GridFactoringFedd.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.GridFactoringFedd.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.GridFactoringFedd.DisplayLayout.MaxColScrollRegions = 1
        Me.GridFactoringFedd.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GridFactoringFedd.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridFactoringFedd.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.GridFactoringFedd.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridFactoringFedd.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridFactoringFedd.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridFactoringFedd.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridFactoringFedd.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridFactoringFedd.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridFactoringFedd.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridFactoringFedd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFactoringFedd.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFactoringFedd.Location = New System.Drawing.Point(0, 33)
        Me.GridFactoringFedd.Name = "GridFactoringFedd"
        Me.GridFactoringFedd.Size = New System.Drawing.Size(1188, 429)
        Me.GridFactoringFedd.TabIndex = 9
        Me.GridFactoringFedd.Text = "Factory/FEDD"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.FecHasta)
        Me.Agrupacion1.Controls.Add(Me.FecDesde)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta26)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion1.Controls.Add(Me.CboTipoObligacionListar)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1188, 33)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'FecHasta
        '
        Me.FecHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecHasta.Location = New System.Drawing.Point(188, 7)
        Me.FecHasta.Name = "FecHasta"
        Me.FecHasta.Size = New System.Drawing.Size(84, 20)
        Me.FecHasta.TabIndex = 257
        '
        'FecDesde
        '
        Me.FecDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FecDesde.Location = New System.Drawing.Point(58, 7)
        Me.FecDesde.Name = "FecDesde"
        Me.FecDesde.Size = New System.Drawing.Size(83, 20)
        Me.FecDesde.TabIndex = 256
        '
        'Etiqueta26
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta26.Appearance = Appearance66
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(147, 10)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta26.TabIndex = 255
        Me.Etiqueta26.Text = "Hasta:"
        '
        'Etiqueta27
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta27.Appearance = Appearance67
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(18, 10)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta27.TabIndex = 254
        Me.Etiqueta27.Text = "Desde:"
        '
        'CboTipoObligacionListar
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.CboTipoObligacionListar.Appearance = Appearance68
        Me.CboTipoObligacionListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CboTipoObligacionListar.DropDownListWidth = 300
        Me.CboTipoObligacionListar.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.CboTipoObligacionListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoObligacionListar.ForeColor = System.Drawing.Color.Black
        Me.CboTipoObligacionListar.Location = New System.Drawing.Point(343, 6)
        Me.CboTipoObligacionListar.Name = "CboTipoObligacionListar"
        Me.CboTipoObligacionListar.Size = New System.Drawing.Size(189, 21)
        Me.CboTipoObligacionListar.TabIndex = 44
        Me.CboTipoObligacionListar.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(308, 9)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta9.TabIndex = 45
        Me.Etiqueta9.Text = "Tipo:"
        '
        'frm_FactoryFEDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 485)
        Me.Controls.Add(Me.tcFactoringFedd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FactoryFEDD"
        Me.Text = "FACTORING - FEDD"
        CType(Me.OrgDocumentosFec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregados.ResumeLayout(False)
        CType(Me.odDocAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuAgregadosFactory.ResumeLayout(False)
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcFactoringFedd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcFactoringFedd.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.GridAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.DecGastosFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTasaInteresFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecComisionFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecMontoInteresFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBancoFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimientoFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.GridDocumentosVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cboClienteFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion12.ResumeLayout(False)
        Me.Agrupacion12.PerformLayout()
        CType(Me.chkFactoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.decImporteDol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImporteSol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Glosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgrDatosObligacionFin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AgrDatosObligacionFin.ResumeLayout(False)
        Me.AgrDatosObligacionFin.PerformLayout()
        CType(Me.DecSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTasaInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecInteresMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboCtaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUnico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FecFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CboBanco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.GridFactoringFedd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.CboTipoObligacionListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcFactoringFedd As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion12 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents FecFecha As ISL.Controles.Fecha
    Friend WithEvents CboBanco As ISL.Controles.Combo
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents CboTipo As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents CboCtaBancaria As ISL.Controles.Combo
    Friend WithEvents AgrDatosObligacionFin As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents DecInteresMonto As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalPagar As ISL.Controles.NumeroDecimal
    Friend WithEvents FecVencimiento As ISL.Controles.Fecha
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents GridFactoringFedd As ISL.Controles.Grilla
    Friend WithEvents OrgDocumentosFec As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents CboTipoObligacionListar As ISL.Controles.Combo
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents NumCalc As ISL.Controles.NumeroCalculadora
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents DecTasaInt As ISL.Controles.NumeroDecimal
    Friend WithEvents txt_Glosa As ISL.Controles.Texto
    Friend WithEvents CboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents MenuAgregados As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregarDocumento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridAgregados As ISL.Controles.Grilla
    Friend WithEvents odDocAgregado As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents GridDocumentosVentas As ISL.Controles.Grilla
    Friend WithEvents DecSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents txtCodigoBancoFactoring As ISL.Controles.Texto
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents DecTotalFactoring As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents FecVencimientoFactoring As ISL.Controles.Fecha
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GridFactoring As ISL.Controles.Grilla
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents MenuAgregadosFactory As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents DecComisionFactoring As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents DecMontoInteresFactoring As ISL.Controles.NumeroDecimal
    Friend WithEvents CalcFactoring As ISL.Controles.NumeroCalculadora
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents DecTasaInteresFactoring As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents DecGastosFactoring As ISL.Controles.NumeroDecimal
    Friend WithEvents lblTotalFactoring As ISL.Controles.Etiqueta
    Friend WithEvents TxtUnico As ISL.Controles.Texto
    Friend WithEvents chkFactoring As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents FecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents FecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents decImporteDol As ISL.Controles.NumeroDecimal
    Friend WithEvents decImporteSol As ISL.Controles.NumeroDecimal
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents btnListaDoc As ISL.Controles.Boton
    Friend WithEvents cboClienteFac As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Espere1 As ISL.Win.Espere
End Class
