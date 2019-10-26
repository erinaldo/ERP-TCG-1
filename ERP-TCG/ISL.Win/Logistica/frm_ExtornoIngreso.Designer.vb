<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ExtornoIngreso
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMovimiento")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Salida")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vehiculo")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ubicacion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_DetalleLibroElectronico", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_DetalleLibroElectronico", -1)
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grReg_Inv = New ISL.Controles.Grilla(Me.components)
        Me.filtro2 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLibroValorizado = New ISL.Controles.Grilla(Me.components)
        Me.EDetalleLibroElectronicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLibroUnidades = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.dtpFechaEjercicio = New System.Windows.Forms.DateTimePicker()
        Me.cboMes = New ISL.Controles.Combo(Me.components)
        Me.btnGenerarAsientos = New Infragistics.Win.Misc.UltraButton()
        Me.btnAjustar = New Infragistics.Win.Misc.UltraButton()
        Me.btnExtornar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griLibroValorizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EDetalleLibroElectronicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griLibroUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grReg_Inv)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1059, 288)
        '
        'grReg_Inv
        '
        UltraGridColumn127.Header.VisiblePosition = 0
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.Caption = "N° Movimiento"
        UltraGridColumn128.Header.VisiblePosition = 2
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn129.Header.VisiblePosition = 1
        UltraGridColumn129.Width = 136
        UltraGridColumn130.Header.Caption = "Tipo Mov."
        UltraGridColumn130.Header.VisiblePosition = 3
        UltraGridColumn130.Width = 85
        UltraGridColumn131.Header.VisiblePosition = 4
        UltraGridColumn131.Width = 248
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn132.CellAppearance = Appearance1
        UltraGridColumn132.Format = "#,##0.0000"
        UltraGridColumn132.Header.VisiblePosition = 5
        UltraGridColumn132.Width = 88
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn133.CellAppearance = Appearance2
        UltraGridColumn133.Format = "#,##0.0000"
        UltraGridColumn133.Header.VisiblePosition = 6
        UltraGridColumn133.Width = 87
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn134.CellAppearance = Appearance3
        UltraGridColumn134.Format = "#,##0.0000"
        UltraGridColumn134.Header.Caption = "Costo Unit."
        UltraGridColumn134.Header.VisiblePosition = 7
        UltraGridColumn134.Width = 82
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn135.CellAppearance = Appearance4
        UltraGridColumn135.Format = "#,##0.0000"
        UltraGridColumn135.Header.Caption = "Costo Total"
        UltraGridColumn135.Header.VisiblePosition = 8
        UltraGridColumn135.Width = 83
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn136.CellAppearance = Appearance5
        UltraGridColumn136.Format = "#,##0.0000"
        UltraGridColumn136.Header.Caption = "Precio Unit."
        UltraGridColumn136.Header.VisiblePosition = 9
        UltraGridColumn136.Hidden = True
        UltraGridColumn136.Width = 90
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn137.CellAppearance = Appearance6
        UltraGridColumn137.Format = "#,##0.0000"
        UltraGridColumn137.Header.Caption = "Precio Total"
        UltraGridColumn137.Header.VisiblePosition = 10
        UltraGridColumn137.Hidden = True
        Appearance7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn138.CellAppearance = Appearance7
        UltraGridColumn138.Header.Caption = "Orden"
        UltraGridColumn138.Header.VisiblePosition = 13
        UltraGridColumn138.Width = 94
        UltraGridColumn139.Header.VisiblePosition = 14
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 15
        UltraGridColumn140.Hidden = True
        UltraGridColumn140.Width = 214
        UltraGridColumn141.Header.VisiblePosition = 16
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 17
        UltraGridColumn142.Hidden = True
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn143.CellAppearance = Appearance8
        UltraGridColumn143.Header.VisiblePosition = 12
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.Caption = "Tipo Documento"
        UltraGridColumn144.Header.VisiblePosition = 18
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.Caption = "N° Documento"
        UltraGridColumn145.Header.VisiblePosition = 19
        UltraGridColumn145.Hidden = True
        UltraGridColumn145.Width = 113
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn146.CellAppearance = Appearance9
        UltraGridColumn146.Format = "#,##0.0000"
        UltraGridColumn146.Header.VisiblePosition = 11
        UltraGridColumn146.Hidden = True
        UltraGridColumn146.MaskInput = ""
        UltraGridColumn146.Width = 89
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146})
        Me.grReg_Inv.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grReg_Inv.DisplayLayout.MaxColScrollRegions = 1
        Me.grReg_Inv.DisplayLayout.MaxRowScrollRegions = 1
        Me.grReg_Inv.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grReg_Inv.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grReg_Inv.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grReg_Inv.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grReg_Inv.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grReg_Inv.DisplayLayout.Override.FilterUIProvider = Me.filtro2
        Me.grReg_Inv.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grReg_Inv.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grReg_Inv.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grReg_Inv.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grReg_Inv.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grReg_Inv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grReg_Inv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grReg_Inv.Location = New System.Drawing.Point(0, 0)
        Me.grReg_Inv.Name = "grReg_Inv"
        Me.grReg_Inv.Size = New System.Drawing.Size(1059, 288)
        Me.grReg_Inv.TabIndex = 3
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griLibroValorizado)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1059, 288)
        '
        'griLibroValorizado
        '
        Me.griLibroValorizado.DataSource = Me.EDetalleLibroElectronicoBindingSource
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridColumn28.Header.VisiblePosition = 27
        UltraGridColumn29.Header.VisiblePosition = 28
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn31.Header.VisiblePosition = 30
        UltraGridColumn32.Header.VisiblePosition = 31
        UltraGridColumn33.Header.VisiblePosition = 32
        UltraGridColumn34.Header.VisiblePosition = 33
        UltraGridColumn35.Header.VisiblePosition = 34
        UltraGridColumn36.Header.VisiblePosition = 35
        UltraGridColumn37.Header.VisiblePosition = 36
        UltraGridColumn38.Header.VisiblePosition = 37
        UltraGridColumn39.Header.VisiblePosition = 38
        UltraGridColumn40.Header.VisiblePosition = 39
        UltraGridColumn41.Header.VisiblePosition = 40
        UltraGridColumn42.Header.VisiblePosition = 41
        UltraGridColumn43.Header.VisiblePosition = 42
        UltraGridColumn44.Header.VisiblePosition = 43
        UltraGridColumn45.Header.VisiblePosition = 44
        UltraGridColumn46.Header.VisiblePosition = 45
        UltraGridColumn47.Header.VisiblePosition = 46
        UltraGridColumn48.Header.VisiblePosition = 47
        UltraGridColumn49.Header.VisiblePosition = 48
        UltraGridColumn50.Header.VisiblePosition = 49
        UltraGridColumn51.Header.VisiblePosition = 50
        UltraGridColumn52.Header.VisiblePosition = 51
        UltraGridColumn53.Header.VisiblePosition = 52
        UltraGridColumn54.Header.VisiblePosition = 53
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54})
        Me.griLibroValorizado.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griLibroValorizado.DisplayLayout.MaxColScrollRegions = 1
        Me.griLibroValorizado.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLibroValorizado.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLibroValorizado.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLibroValorizado.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLibroValorizado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLibroValorizado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLibroValorizado.DisplayLayout.Override.FilterUIProvider = Me.filtro2
        Me.griLibroValorizado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLibroValorizado.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLibroValorizado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLibroValorizado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griLibroValorizado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLibroValorizado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLibroValorizado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLibroValorizado.Location = New System.Drawing.Point(0, 0)
        Me.griLibroValorizado.Name = "griLibroValorizado"
        Me.griLibroValorizado.Size = New System.Drawing.Size(1059, 288)
        Me.griLibroValorizado.TabIndex = 3
        '
        'EDetalleLibroElectronicoBindingSource
        '
        Me.EDetalleLibroElectronicoBindingSource.DataSource = GetType(ERP.EntidadesWCF.e_DetalleLibroElectronico)
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griLibroUnidades)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1059, 288)
        '
        'griLibroUnidades
        '
        Me.griLibroUnidades.DataSource = Me.EDetalleLibroElectronicoBindingSource
        UltraGridColumn55.Header.VisiblePosition = 0
        UltraGridColumn56.Header.VisiblePosition = 1
        UltraGridColumn57.Header.VisiblePosition = 2
        UltraGridColumn58.Header.VisiblePosition = 3
        UltraGridColumn59.Header.VisiblePosition = 4
        UltraGridColumn60.Header.VisiblePosition = 5
        UltraGridColumn61.Header.VisiblePosition = 6
        UltraGridColumn62.Header.VisiblePosition = 7
        UltraGridColumn63.Header.VisiblePosition = 8
        UltraGridColumn64.Header.VisiblePosition = 9
        UltraGridColumn65.Header.VisiblePosition = 10
        UltraGridColumn66.Header.VisiblePosition = 11
        UltraGridColumn67.Header.VisiblePosition = 12
        UltraGridColumn68.Header.VisiblePosition = 13
        UltraGridColumn69.Header.VisiblePosition = 14
        UltraGridColumn70.Header.VisiblePosition = 15
        UltraGridColumn71.Header.VisiblePosition = 16
        UltraGridColumn72.Header.VisiblePosition = 17
        UltraGridColumn73.Header.VisiblePosition = 18
        UltraGridColumn74.Header.VisiblePosition = 19
        UltraGridColumn75.Header.VisiblePosition = 20
        UltraGridColumn76.Header.VisiblePosition = 21
        UltraGridColumn77.Header.VisiblePosition = 22
        UltraGridColumn78.Header.VisiblePosition = 23
        UltraGridColumn79.Header.VisiblePosition = 24
        UltraGridColumn80.Header.VisiblePosition = 25
        UltraGridColumn81.Header.VisiblePosition = 26
        UltraGridColumn82.Header.VisiblePosition = 27
        UltraGridColumn83.Header.VisiblePosition = 28
        UltraGridColumn84.Header.VisiblePosition = 29
        UltraGridColumn85.Header.VisiblePosition = 30
        UltraGridColumn86.Header.VisiblePosition = 31
        UltraGridColumn87.Header.VisiblePosition = 32
        UltraGridColumn88.Header.VisiblePosition = 33
        UltraGridColumn89.Header.VisiblePosition = 34
        UltraGridColumn90.Header.VisiblePosition = 35
        UltraGridColumn91.Header.VisiblePosition = 36
        UltraGridColumn92.Header.VisiblePosition = 37
        UltraGridColumn93.Header.VisiblePosition = 38
        UltraGridColumn94.Header.VisiblePosition = 39
        UltraGridColumn95.Header.VisiblePosition = 40
        UltraGridColumn96.Header.VisiblePosition = 41
        UltraGridColumn97.Header.VisiblePosition = 42
        UltraGridColumn98.Header.VisiblePosition = 43
        UltraGridColumn99.Header.VisiblePosition = 44
        UltraGridColumn100.Header.VisiblePosition = 45
        UltraGridColumn101.Header.VisiblePosition = 46
        UltraGridColumn102.Header.VisiblePosition = 47
        UltraGridColumn103.Header.VisiblePosition = 48
        UltraGridColumn104.Header.VisiblePosition = 49
        UltraGridColumn105.Header.VisiblePosition = 50
        UltraGridColumn106.Header.VisiblePosition = 51
        UltraGridColumn107.Header.VisiblePosition = 52
        UltraGridColumn108.Header.VisiblePosition = 53
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108})
        Me.griLibroUnidades.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griLibroUnidades.DisplayLayout.MaxColScrollRegions = 1
        Me.griLibroUnidades.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLibroUnidades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLibroUnidades.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLibroUnidades.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLibroUnidades.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLibroUnidades.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLibroUnidades.DisplayLayout.Override.FilterUIProvider = Me.filtro2
        Me.griLibroUnidades.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLibroUnidades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLibroUnidades.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLibroUnidades.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griLibroUnidades.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLibroUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLibroUnidades.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLibroUnidades.Location = New System.Drawing.Point(0, 0)
        Me.griLibroUnidades.Name = "griLibroUnidades"
        Me.griLibroUnidades.Size = New System.Drawing.Size(1059, 288)
        Me.griLibroUnidades.TabIndex = 4
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox1.Controls.Add(Me.dtpFechaEjercicio)
        Me.UltraGroupBox1.Controls.Add(Me.cboMes)
        Me.UltraGroupBox1.Controls.Add(Me.btnGenerarAsientos)
        Me.UltraGroupBox1.Controls.Add(Me.btnAjustar)
        Me.UltraGroupBox1.Controls.Add(Me.btnExtornar)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1061, 58)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Text = "Controles"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton1
        '
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.UltraButton1.Appearance = Appearance10
        Me.UltraButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraButton1.Location = New System.Drawing.Point(312, 17)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(103, 38)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Regenerar"
        '
        'dtpFechaEjercicio
        '
        Me.dtpFechaEjercicio.CustomFormat = "yyyy"
        Me.dtpFechaEjercicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaEjercicio.Location = New System.Drawing.Point(421, 22)
        Me.dtpFechaEjercicio.Name = "dtpFechaEjercicio"
        Me.dtpFechaEjercicio.ShowUpDown = True
        Me.dtpFechaEjercicio.Size = New System.Drawing.Size(52, 21)
        Me.dtpFechaEjercicio.TabIndex = 4
        '
        'cboMes
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Appearance = Appearance11
        Me.cboMes.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMes.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMes.Location = New System.Drawing.Point(479, 22)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(49, 22)
        Me.cboMes.TabIndex = 5
        Me.cboMes.ValueMember = "Id"
        '
        'btnGenerarAsientos
        '
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.btnGenerarAsientos.Appearance = Appearance12
        Me.btnGenerarAsientos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnGenerarAsientos.Location = New System.Drawing.Point(209, 17)
        Me.btnGenerarAsientos.Name = "btnGenerarAsientos"
        Me.btnGenerarAsientos.Size = New System.Drawing.Size(103, 38)
        Me.btnGenerarAsientos.TabIndex = 2
        Me.btnGenerarAsientos.Text = "Regenerar"
        '
        'btnAjustar
        '
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.document_properties
        Me.btnAjustar.Appearance = Appearance13
        Me.btnAjustar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAjustar.Location = New System.Drawing.Point(107, 17)
        Me.btnAjustar.Name = "btnAjustar"
        Me.btnAjustar.Size = New System.Drawing.Size(102, 38)
        Me.btnAjustar.TabIndex = 1
        Me.btnAjustar.Text = "Ajustar"
        '
        'btnExtornar
        '
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.Image = Global.ISL.Win.My.Resources.Resources.back
        Me.btnExtornar.Appearance = Appearance14
        Me.btnExtornar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExtornar.Enabled = False
        Me.btnExtornar.Location = New System.Drawing.Point(3, 17)
        Me.btnExtornar.Name = "btnExtornar"
        Me.btnExtornar.Size = New System.Drawing.Size(104, 38)
        Me.btnExtornar.TabIndex = 0
        Me.btnExtornar.Text = "Extornar"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 58)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(1061, 311)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.UltraTabControl1.TabIndex = 1
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "tab1"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "tab2"
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "tab3"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab1})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1059, 288)
        '
        'frm_ExtornoIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 369)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.MinimizeBox = False
        Me.Name = "frm_ExtornoIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extorno Ingreso"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grReg_Inv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griLibroValorizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EDetalleLibroElectronicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griLibroUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cboMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnGenerarAsientos As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAjustar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnExtornar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents filtro2 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grReg_Inv As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griLibroValorizado As ISL.Controles.Grilla
    Friend WithEvents EDetalleLibroElectronicoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtpFechaEjercicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboMes As ISL.Controles.Combo
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griLibroUnidades As ISL.Controles.Grilla
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
End Class
