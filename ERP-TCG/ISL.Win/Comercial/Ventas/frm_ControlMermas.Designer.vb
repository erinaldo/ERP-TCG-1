<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ControlMermas
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
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoMermas")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoSalida")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClientePersona", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadCantidad")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ControlMermas))
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioFactura")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCobro")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClientePersona")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mod", 0)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoMermas")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresoSalida")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClientePersona")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadCantidad")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FactorConversion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioFactura")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCobro")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClientePersona")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoMermas")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoSalida")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClientePersona")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadCantidad")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioFactura")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCobro")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClientePersona")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdIngresoSalidaMermas")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioVenta")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdIngresoSalidaMermas")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FactorConversion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioVenta")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoSalida")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeDescuento")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCobro")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSancion")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mod", 0)
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresoSalida")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeDescuento")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCobro")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoPago")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSancion")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoMermas")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoSalida")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClientePersona")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadCantidad")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioFactura")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCobro")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClientePersona")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
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
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdIngresoSalidaMermas")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioVenta")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo39 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo40 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo41 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo42 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo43 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo44 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo45 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo46 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo47 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo48 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo49 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo50 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo51 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo52 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo53 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo54 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo55 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo56 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo57 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo58 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo59 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo60 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo61 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo62 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo63 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo64 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo65 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo66 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo67 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo68 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo69 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo70 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo71 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
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
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoMermas")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoSalida")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClientePersona")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadCantidad")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioFactura")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCobro")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClientePersona")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdIngresoSalidaMermas")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FactorConversion")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioVenta")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab(True)
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Numero de GRT", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Serie de GRT", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem20 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem21 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaIngresos = New ISL.Controles.Grilla(Me.components)
        Me.ogdIngSal = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaSalidas = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAlmacenMermas = New ISL.Controles.Grilla(Me.components)
        Me.ogdAlmMer = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMovimiento = New ISL.Controles.Grilla(Me.components)
        Me.MenuTesoreria = New ISL.Controles.MenuContextual(Me.components)
        Me.Cobrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdMovMer = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleMermasI = New ISL.Controles.Grilla(Me.components)
        Me.mnuQuitDetI = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListaMermasI = New Infragistics.Win.Misc.UltraButton()
        Me.cboMaterialI = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtPrecioAlmacenI = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdViajeI = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCantidadI = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnAgregarI = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboClienteI = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtFactorCovI = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtNumeroI = New ISL.Controles.Texto(Me.components)
        Me.txtPrecioFacturaI = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtSerieI = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UnidadMedida = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoI = New ISL.Controles.Combo(Me.components)
        Me.cboUnidadI = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroViajeI = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uebAlmacenMermas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griAlmacenMermasI = New ISL.Controles.Grilla(Me.components)
        Me.expViaje = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griViajes = New ISL.Controles.Grilla(Me.components)
        Me.ogdViajes = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHastaViaje = New System.Windows.Forms.DateTimePicker()
        Me.fecDesdeViaje = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.verTracto = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.cboTractoLista = New ISL.Controles.Combo(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnListarViajes = New Infragistics.Win.Misc.UltraButton()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtTotalI = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel20 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtIdMovimientoI = New ISL.Controles.Texto(Me.components)
        Me.fecFechaI = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtGlosaI = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleMermasS = New ISL.Controles.Grilla(Me.components)
        Me.mnuQuitDetS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.griAlmacenMermasS = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtTotalS = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtDescuentoS = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtSubTotalS = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.fecFechaS = New System.Windows.Forms.DateTimePicker()
        Me.txtIdSancion = New ISL.Controles.Texto(Me.components)
        Me.txtIdMovimientoS = New ISL.Controles.Texto(Me.components)
        Me.btnListaMermasS = New Infragistics.Win.Misc.UltraButton()
        Me.txtPorcentajeDescuentoS = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.lblPorcentajeDescuentoS = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel18 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel29 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSaldoS = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtGlosaS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMontoAmortizadoS = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel27 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoPagoS = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboPersonaS = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficListar = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboCentroL = New ISL.Controles.Combo(Me.components)
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorAlGasto = New ISL.Controles.Colores(Me.components)
        Me.ColorAmortizado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiAsignada = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCobrado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCancelada = New ISL.Controles.Etiqueta(Me.components)
        Me.colorCredito = New ISL.Controles.Colores(Me.components)
        Me.colorPorCobrar = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorContado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel21 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.ColorAltualizar = New ISL.Controles.Colores(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficIngresoSalida = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.utp1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraMaskedEdit5 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraMaskedEdit6 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.ficCtrlMerma = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.Combo4 = New ISL.Controles.Combo(Me.components)
        Me.UltraMaskedEdit4 = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnBuscarMaterial = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtMateriales = New ISL.Controles.Texto(Me.components)
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griListaIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdIngSal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griListaSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griAlmacenMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAlmMer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTesoreria.SuspendLayout()
        CType(Me.ogdMovMer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griDetalleMermasI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuQuitDetI.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cboMaterialI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdViajeI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.txtNumeroI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboUnidadI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroViajeI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uebAlmacenMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uebAlmacenMermas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griAlmacenMermasI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expViaje.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtIdMovimientoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.griDetalleMermasS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuQuitDetS.SuspendLayout()
        CType(Me.griAlmacenMermasS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.txtTotalS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuentoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubTotalS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdMovimientoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosaS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPagoS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPersonaS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaRegistro.SuspendLayout()
        CType(Me.ficListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficListar.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.colorAlGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAmortizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorPorCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorContado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAltualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.ficIngresoSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficIngresoSalida.SuspendLayout()
        CType(Me.ficCtrlMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCtrlMerma.SuspendLayout()
        CType(Me.Combo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griListaIngresos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1149, 364)
        '
        'griListaIngresos
        '
        Me.griListaIngresos.DataSource = Me.ogdIngSal
        UltraGridColumn23.Header.VisiblePosition = 0
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 110
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Width = 110
        UltraGridColumn25.Header.VisiblePosition = 2
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.Width = 25
        UltraGridColumn26.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn26.Header.Caption = "OrigenViaje"
        UltraGridColumn26.Header.VisiblePosition = 20
        UltraGridColumn26.Width = 220
        UltraGridColumn27.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn27.Header.VisiblePosition = 4
        UltraGridColumn27.MaskInput = "{date}"
        UltraGridColumn27.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn27.Width = 70
        UltraGridColumn28.Header.Caption = "DestinoViaje"
        UltraGridColumn28.Header.VisiblePosition = 21
        UltraGridColumn28.Width = 220
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.Caption = "Tracto"
        UltraGridColumn29.Header.VisiblePosition = 18
        UltraGridColumn29.Width = 70
        UltraGridColumn30.Header.Caption = "Unidad"
        UltraGridColumn30.Header.VisiblePosition = 6
        UltraGridColumn30.Hidden = True
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance1
        UltraGridColumn31.Header.VisiblePosition = 8
        UltraGridColumn31.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn31.Width = 66
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance2
        UltraGridColumn32.Header.VisiblePosition = 9
        UltraGridColumn32.MaskInput = "{LOC}nnnnn.nn"
        UltraGridColumn32.Width = 86
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance3
        UltraGridColumn33.Header.VisiblePosition = 10
        UltraGridColumn33.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn33.Width = 83
        UltraGridColumn34.Header.VisiblePosition = 11
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 12
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.Caption = "Viaje"
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn36.Width = 110
        UltraGridColumn37.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn37.Header.Caption = "Piloto"
        UltraGridColumn37.Header.VisiblePosition = 19
        UltraGridColumn37.Width = 220
        Appearance4.Image = CType(resources.GetObject("Appearance4.Image"), Object)
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance4
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn38.Header.VisiblePosition = 13
        UltraGridColumn38.MaxLength = 4
        UltraGridColumn38.Width = 70
        Appearance5.Image = CType(resources.GetObject("Appearance5.Image"), Object)
        UltraGridColumn39.CellAppearance = Appearance5
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn39.Header.VisiblePosition = 14
        UltraGridColumn39.MaxLength = 10
        UltraGridColumn39.Width = 70
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance6
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn40.Header.VisiblePosition = 15
        UltraGridColumn40.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn40.Width = 93
        UltraGridColumn41.Header.VisiblePosition = 22
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.Header.VisiblePosition = 23
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 24
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 220
        UltraGridColumn44.Header.VisiblePosition = 25
        UltraGridColumn44.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 5
        UltraGridColumn205.Width = 220
        UltraGridColumn209.Header.VisiblePosition = 7
        UltraGridColumn209.Width = 115
        UltraGridColumn213.Header.VisiblePosition = 17
        UltraGridColumn213.Width = 220
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.CellAppearance = Appearance7
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn94.CellButtonAppearance = Appearance8
        UltraGridColumn94.Header.VisiblePosition = 16
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn94.Width = 48
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn205, UltraGridColumn209, UltraGridColumn213, UltraGridColumn94})
        UltraGridBand1.GroupHeadersVisible = False
        UltraGridBand1.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaIngresos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griListaIngresos.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaIngresos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaIngresos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaIngresos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaIngresos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaIngresos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaIngresos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaIngresos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaIngresos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaIngresos.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaIngresos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaIngresos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaIngresos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaIngresos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaIngresos.DisplayLayout.UseFixedHeaders = True
        Me.griListaIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaIngresos.Location = New System.Drawing.Point(0, 0)
        Me.griListaIngresos.Name = "griListaIngresos"
        Me.griListaIngresos.Size = New System.Drawing.Size(1149, 364)
        Me.griListaIngresos.TabIndex = 0
        Me.griListaIngresos.Tag = ""
        '
        'ogdIngSal
        '
        Me.ogdIngSal.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griListaSalidas)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1149, 365)
        '
        'griListaSalidas
        '
        Me.griListaSalidas.DataSource = Me.ogdIngSal
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.Caption = "Persona / Trabajador"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 200
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.MaskInput = "{date}"
        UltraGridColumn5.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn5.Width = 70
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn6.CellAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn6.FilterCellAppearance = Appearance10
        UltraGridColumn6.Header.Caption = "Desc(%)"
        UltraGridColumn6.Header.VisiblePosition = 10
        UltraGridColumn6.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn6.Width = 60
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn7.CellAppearance = Appearance11
        UltraGridColumn7.Header.Caption = "PrecioIngreso"
        UltraGridColumn7.Header.VisiblePosition = 19
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn7.Width = 60
        UltraGridColumn8.Header.Caption = "Unidad"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 100
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance12
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn9.Width = 64
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance13
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.MaskInput = "{LOC}nnnnn.nn"
        UltraGridColumn10.Width = 79
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance14
        UltraGridColumn11.Header.Caption = "Total"
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn11.Width = 89
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn12.CellAppearance = Appearance15
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn12.FilterCellAppearance = Appearance16
        UltraGridColumn12.Header.Caption = "CostoPromedio"
        UltraGridColumn12.Header.VisiblePosition = 18
        UltraGridColumn12.MaskInput = "{LOC}nnnnn.nn"
        UltraGridColumn12.Width = 60
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 16
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Width = 200
        UltraGridColumn15.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn15.Header.Caption = "Tipo Pago"
        UltraGridColumn15.Header.VisiblePosition = 13
        UltraGridColumn15.Width = 132
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn16.CellAppearance = Appearance17
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 30
        UltraGridColumn17.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn17.Header.Caption = "Estado"
        UltraGridColumn17.Header.VisiblePosition = 15
        UltraGridColumn17.Hidden = True
        UltraGridColumn17.Width = 70
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance18
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn18.Width = 60
        UltraGridColumn19.Header.VisiblePosition = 20
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.Caption = "IdUsuarioCreacion"
        UltraGridColumn21.Header.VisiblePosition = 22
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 23
        UltraGridColumn22.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 6
        UltraGridColumn206.Width = 345
        UltraGridColumn210.Header.Caption = "UsuarioCreacion"
        UltraGridColumn210.Header.VisiblePosition = 24
        UltraGridColumn210.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 5
        UltraGridColumn214.Width = 308
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn206, UltraGridColumn210, UltraGridColumn214})
        UltraGridBand2.GroupHeadersVisible = False
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaSalidas.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griListaSalidas.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaSalidas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaSalidas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSalidas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSalidas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaSalidas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSalidas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSalidas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaSalidas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSalidas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaSalidas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSalidas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSalidas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaSalidas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaSalidas.DisplayLayout.UseFixedHeaders = True
        Me.griListaSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaSalidas.Location = New System.Drawing.Point(0, 0)
        Me.griListaSalidas.Name = "griListaSalidas"
        Me.griListaSalidas.Size = New System.Drawing.Size(1149, 365)
        Me.griListaSalidas.TabIndex = 0
        Me.griListaSalidas.Tag = ""
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griAlmacenMermas)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1149, 365)
        '
        'griAlmacenMermas
        '
        Me.griAlmacenMermas.DataSource = Me.ogdAlmMer
        UltraGridColumn45.Header.VisiblePosition = 0
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.Caption = "IdMaterial"
        UltraGridColumn46.Header.VisiblePosition = 1
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.Caption = "Material"
        UltraGridColumn47.Header.VisiblePosition = 3
        UltraGridColumn47.Hidden = True
        UltraGridColumn47.Width = 225
        UltraGridColumn48.Header.Caption = "UnidadMedida"
        UltraGridColumn48.Header.VisiblePosition = 5
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.Width = 70
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance19
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn49.Header.Caption = "Cantidad"
        UltraGridColumn49.Header.VisiblePosition = 8
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.MaskInput = "{LOC}nnnnnnn.nnn"
        UltraGridColumn49.Width = 40
        Appearance20.Image = CType(resources.GetObject("Appearance20.Image"), Object)
        Appearance20.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.CellAppearance = Appearance20
        Appearance21.Image = 8
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn50.CellButtonAppearance = Appearance21
        UltraGridColumn50.Header.Caption = "Actualizar"
        UltraGridColumn50.Header.VisiblePosition = 9
        UltraGridColumn50.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn50.Width = 50
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance22
        UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn51.Header.VisiblePosition = 6
        UltraGridColumn51.MaskInput = "{double:9.4}"
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn51.Width = 104
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance23
        UltraGridColumn52.Header.VisiblePosition = 7
        UltraGridColumn52.MaskInput = "{double:9.4}"
        UltraGridColumn52.Width = 93
        UltraGridColumn53.Header.Caption = "Select"
        UltraGridColumn53.Header.VisiblePosition = 2
        UltraGridColumn53.Hidden = True
        UltraGridColumn53.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn53.Width = 30
        UltraGridColumn217.Header.VisiblePosition = 4
        UltraGridColumn217.Width = 387
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn217})
        UltraGridBand3.GroupHeadersVisible = False
        UltraGridBand3.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMermas.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griAlmacenMermas.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMermas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAlmacenMermas.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMermas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMermas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAlmacenMermas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMermas.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griAlmacenMermas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAlmacenMermas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlmacenMermas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMermas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMermas.DisplayLayout.UseFixedHeaders = True
        Me.griAlmacenMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAlmacenMermas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMermas.ImageList = Me.imagenes
        Me.griAlmacenMermas.Location = New System.Drawing.Point(0, 0)
        Me.griAlmacenMermas.Name = "griAlmacenMermas"
        Me.griAlmacenMermas.Size = New System.Drawing.Size(1149, 365)
        Me.griAlmacenMermas.TabIndex = 0
        Me.griAlmacenMermas.Tag = ""
        '
        'ogdAlmMer
        '
        Me.ogdAlmMer.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griMovimiento)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1149, 365)
        '
        'griMovimiento
        '
        Me.griMovimiento.ContextMenuStrip = Me.MenuTesoreria
        Me.griMovimiento.DataSource = Me.ogdMovMer
        UltraGridColumn54.Header.VisiblePosition = 0
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 1
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn56.Header.Caption = "Persona / Trabajador"
        UltraGridColumn56.Header.VisiblePosition = 5
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.Width = 200
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn57.Header.VisiblePosition = 4
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn57.Width = 60
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance24
        UltraGridColumn58.Header.Caption = "%Desct"
        UltraGridColumn58.Header.VisiblePosition = 7
        UltraGridColumn58.MaskInput = "nnn"
        UltraGridColumn58.Width = 45
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn59.CellAppearance = Appearance25
        UltraGridColumn59.Header.VisiblePosition = 8
        UltraGridColumn59.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn59.Width = 67
        Appearance26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn60.CellAppearance = Appearance26
        UltraGridColumn60.Header.VisiblePosition = 11
        UltraGridColumn60.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn60.Width = 91
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn61.CellAppearance = Appearance27
        UltraGridColumn61.Header.VisiblePosition = 9
        UltraGridColumn61.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn61.Width = 68
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn62.CellAppearance = Appearance28
        UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn62.Header.VisiblePosition = 10
        UltraGridColumn62.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn62.Width = 73
        UltraGridColumn63.Header.VisiblePosition = 14
        UltraGridColumn63.Width = 200
        UltraGridColumn64.Header.Caption = "Tipo Pago"
        UltraGridColumn64.Header.VisiblePosition = 12
        UltraGridColumn64.Width = 100
        UltraGridColumn65.Header.Caption = "Estado"
        UltraGridColumn65.Header.VisiblePosition = 13
        UltraGridColumn65.Width = 100
        UltraGridColumn66.Header.Caption = "Cobrador"
        UltraGridColumn66.Header.VisiblePosition = 15
        UltraGridColumn66.Width = 200
        UltraGridColumn67.Header.VisiblePosition = 18
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 19
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.Caption = "Vendedor"
        UltraGridColumn69.Header.VisiblePosition = 16
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Width = 200
        UltraGridColumn70.Header.VisiblePosition = 17
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 20
        UltraGridColumn71.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 6
        UltraGridColumn95.Width = 254
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn96.Header.VisiblePosition = 2
        UltraGridColumn96.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn96.Width = 34
        UltraGridColumn97.Header.VisiblePosition = 21
        UltraGridColumn97.Hidden = True
        Appearance29.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance29.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.CellAppearance = Appearance29
        Appearance30.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Appearance30.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn98.CellButtonAppearance = Appearance30
        UltraGridColumn98.Header.VisiblePosition = 3
        UltraGridColumn98.Width = 48
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98})
        UltraGridBand4.GroupHeadersVisible = False
        UltraGridBand4.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMovimiento.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griMovimiento.DisplayLayout.MaxColScrollRegions = 1
        Me.griMovimiento.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griMovimiento.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimiento.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimiento.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMovimiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMovimiento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMovimiento.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMovimiento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMovimiento.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griMovimiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMovimiento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMovimiento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMovimiento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMovimiento.DisplayLayout.UseFixedHeaders = True
        Me.griMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMovimiento.Location = New System.Drawing.Point(0, 0)
        Me.griMovimiento.Name = "griMovimiento"
        Me.griMovimiento.Size = New System.Drawing.Size(1149, 365)
        Me.griMovimiento.TabIndex = 0
        Me.griMovimiento.Tag = ""
        '
        'MenuTesoreria
        '
        Me.MenuTesoreria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuTesoreria.ForeColor = System.Drawing.Color.Black
        Me.MenuTesoreria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cobrar, Me.VerVenta})
        Me.MenuTesoreria.Name = "MenuContextual1"
        Me.MenuTesoreria.Size = New System.Drawing.Size(119, 48)
        '
        'Cobrar
        '
        Me.Cobrar.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.Cobrar.Name = "Cobrar"
        Me.Cobrar.Size = New System.Drawing.Size(118, 22)
        Me.Cobrar.Text = "Cobrar"
        '
        'VerVenta
        '
        Me.VerVenta.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.VerVenta.Name = "VerVenta"
        Me.VerVenta.Size = New System.Drawing.Size(118, 22)
        Me.VerVenta.Text = "VerVenta"
        '
        'ogdMovMer
        '
        UltraDataColumn39.DataType = GetType(Date)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn49.DataType = GetType(Boolean)
        UltraDataColumn52.DataType = GetType(Boolean)
        UltraDataColumn55.DataType = GetType(Boolean)
        Me.ogdMovMer.Band.Columns.AddRange(New Object() {UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1155, 474)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance31
        Me.Agrupacion1.Controls.Add(Me.griDetalleMermasI)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion4)
        Me.Agrupacion1.Controls.Add(Me.expViaje)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 60)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1155, 414)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Detalle del Materiales"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleMermasI
        '
        Me.griDetalleMermasI.ContextMenuStrip = Me.mnuQuitDetI
        Me.griDetalleMermasI.DataSource = Me.ogdIngSal
        UltraGridColumn72.Header.VisiblePosition = 0
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 1
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 2
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 5
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Width = 150
        UltraGridColumn76.Header.VisiblePosition = 7
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 8
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 9
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.Width = 200
        UltraGridColumn79.Header.Caption = "Unidad"
        UltraGridColumn79.Header.VisiblePosition = 10
        UltraGridColumn79.Hidden = True
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn80.CellAppearance = Appearance32
        UltraGridColumn80.Header.VisiblePosition = 11
        UltraGridColumn80.MaskInput = "{double:9.4}"
        UltraGridColumn80.Width = 95
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn81.CellAppearance = Appearance33
        UltraGridColumn81.Header.VisiblePosition = 12
        UltraGridColumn81.MaskInput = "{double:9.4}"
        UltraGridColumn81.Width = 110
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn82.CellAppearance = Appearance34
        UltraGridColumn82.Header.VisiblePosition = 13
        UltraGridColumn82.MaskInput = "{double:9.4}"
        UltraGridColumn82.Width = 111
        UltraGridColumn83.Header.VisiblePosition = 14
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.MaskInput = "{double:9.4}"
        UltraGridColumn84.Header.VisiblePosition = 15
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.Caption = "Nro Viaje"
        UltraGridColumn85.Header.VisiblePosition = 3
        UltraGridColumn85.Width = 118
        UltraGridColumn86.Header.VisiblePosition = 16
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Width = 100
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn87.CellAppearance = Appearance35
        UltraGridColumn87.Header.VisiblePosition = 17
        UltraGridColumn87.Width = 64
        UltraGridColumn88.Header.VisiblePosition = 18
        UltraGridColumn88.Width = 70
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance36
        UltraGridColumn89.Header.VisiblePosition = 19
        UltraGridColumn89.MaskInput = "{double:9.4}"
        UltraGridColumn89.Width = 109
        UltraGridColumn90.Header.VisiblePosition = 20
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 21
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 22
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 23
        UltraGridColumn93.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 6
        UltraGridColumn207.Width = 242
        UltraGridColumn211.Header.VisiblePosition = 24
        UltraGridColumn215.Header.VisiblePosition = 4
        UltraGridColumn215.Width = 197
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn207, UltraGridColumn211, UltraGridColumn215})
        UltraGridBand5.GroupHeadersVisible = False
        UltraGridBand5.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleMermasI.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griDetalleMermasI.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleMermasI.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleMermasI.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasI.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleMermasI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleMermasI.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleMermasI.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleMermasI.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griDetalleMermasI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleMermasI.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleMermasI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleMermasI.DisplayLayout.UseFixedHeaders = True
        Me.griDetalleMermasI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleMermasI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleMermasI.Location = New System.Drawing.Point(31, 266)
        Me.griDetalleMermasI.Name = "griDetalleMermasI"
        Me.griDetalleMermasI.Size = New System.Drawing.Size(1121, 145)
        Me.griDetalleMermasI.TabIndex = 1
        Me.griDetalleMermasI.Tag = ""
        '
        'mnuQuitDetI
        '
        Me.mnuQuitDetI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.mnuQuitDetI.Name = "mnuQuitarDetalle"
        Me.mnuQuitDetI.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem2.Text = "Quitar"
        '
        'Agrupacion4
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion4.ContentAreaAppearance = Appearance37
        Me.Agrupacion4.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion4.Controls.Add(Me.uebAlmacenMermas)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion4.Location = New System.Drawing.Point(31, 16)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1121, 250)
        Me.Agrupacion4.TabIndex = 321
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion2
        '
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion2.Appearance = Appearance38
        Me.Agrupacion2.Controls.Add(Me.btnListaMermasI)
        Me.Agrupacion2.Controls.Add(Me.cboMaterialI)
        Me.Agrupacion2.Controls.Add(Me.txtPrecioAlmacenI)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel5)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel17)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel6)
        Me.Agrupacion2.Controls.Add(Me.txtIdViajeI)
        Me.Agrupacion2.Controls.Add(Me.txtCantidadI)
        Me.Agrupacion2.Controls.Add(Me.btnAgregarI)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel4)
        Me.Agrupacion2.Controls.Add(Me.cboClienteI)
        Me.Agrupacion2.Controls.Add(Me.txtFactorCovI)
        Me.Agrupacion2.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel25)
        Me.Agrupacion2.Controls.Add(Me.UnidadMedida)
        Me.Agrupacion2.Controls.Add(Me.cboEstadoI)
        Me.Agrupacion2.Controls.Add(Me.cboUnidadI)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.txtNroViajeI)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(608, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(510, 244)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.Text = "Detalle"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListaMermasI
        '
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.Image = "266.png"
        Appearance39.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance39.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnListaMermasI.Appearance = Appearance39
        Me.btnListaMermasI.ImageList = Me.imagenes
        Me.btnListaMermasI.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnListaMermasI.Location = New System.Drawing.Point(67, 32)
        Me.btnListaMermasI.Name = "btnListaMermasI"
        Me.btnListaMermasI.Size = New System.Drawing.Size(90, 40)
        Me.btnListaMermasI.TabIndex = 0
        Me.btnListaMermasI.Text = "Almacen Mermas"
        '
        'cboMaterialI
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialI.Appearance = Appearance40
        Me.cboMaterialI.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance41.Image = 4
        EditorButton1.Appearance = Appearance41
        Me.cboMaterialI.ButtonsRight.Add(EditorButton1)
        Me.cboMaterialI.DisplayMember = "Nombre"
        Me.cboMaterialI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMaterialI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaterialI.ForeColor = System.Drawing.Color.Black
        Me.cboMaterialI.ImageList = Me.imagenes
        Me.cboMaterialI.Location = New System.Drawing.Point(67, 156)
        Me.cboMaterialI.Name = "cboMaterialI"
        Me.cboMaterialI.Size = New System.Drawing.Size(350, 21)
        Me.cboMaterialI.TabIndex = 10
        Me.cboMaterialI.ValueMember = "Id"
        '
        'txtPrecioAlmacenI
        '
        Appearance42.TextHAlignAsString = "Right"
        Me.txtPrecioAlmacenI.Appearance = Appearance42
        Me.txtPrecioAlmacenI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPrecioAlmacenI.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtPrecioAlmacenI.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtPrecioAlmacenI.InputMask = "{double:9.4}"
        Me.txtPrecioAlmacenI.Location = New System.Drawing.Point(347, 111)
        Me.txtPrecioAlmacenI.Name = "txtPrecioAlmacenI"
        Me.txtPrecioAlmacenI.NonAutoSizeHeight = 20
        Me.txtPrecioAlmacenI.NullText = "0.00"
        Me.txtPrecioAlmacenI.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecioAlmacenI.TabIndex = 6
        '
        'UltraLabel5
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Appearance43.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance43
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(258, 205)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel5.TabIndex = 17
        Me.UltraLabel5.Text = "Factor Cov.:"
        '
        'UltraLabel17
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance44
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(257, 112)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel17.TabIndex = 5
        Me.UltraLabel17.Text = "Precio Almacen:"
        '
        'UltraLabel2
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance45
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(18, 137)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel2.TabIndex = 7
        Me.UltraLabel2.Text = "Cliente:"
        '
        'UltraLabel6
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance46
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(18, 205)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel6.TabIndex = 13
        Me.UltraLabel6.Text = "Estado:"
        '
        'txtIdViajeI
        '
        Me.txtIdViajeI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdViajeI.Enabled = False
        Me.txtIdViajeI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdViajeI.Location = New System.Drawing.Point(67, 87)
        Me.txtIdViajeI.Name = "txtIdViajeI"
        Me.txtIdViajeI.ReadOnly = True
        Me.txtIdViajeI.Size = New System.Drawing.Size(81, 21)
        Me.txtIdViajeI.TabIndex = 2
        Me.txtIdViajeI.Visible = False
        '
        'txtCantidadI
        '
        Appearance47.TextHAlignAsString = "Right"
        Me.txtCantidadI.Appearance = Appearance47
        Me.txtCantidadI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCantidadI.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCantidadI.InputMask = "{LOC}nnnnn.nnnn"
        Me.txtCantidadI.Location = New System.Drawing.Point(67, 179)
        Me.txtCantidadI.Name = "txtCantidadI"
        Me.txtCantidadI.NonAutoSizeHeight = 20
        Me.txtCantidadI.NullText = "1.0000"
        Me.txtCantidadI.Size = New System.Drawing.Size(81, 20)
        Me.txtCantidadI.TabIndex = 12
        '
        'btnAgregarI
        '
        Appearance48.Image = "add.ico"
        Appearance48.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance48.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnAgregarI.Appearance = Appearance48
        Me.btnAgregarI.ImageList = Me.imagenes
        Me.btnAgregarI.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnAgregarI.Location = New System.Drawing.Point(382, 192)
        Me.btnAgregarI.Name = "btnAgregarI"
        Me.btnAgregarI.Size = New System.Drawing.Size(35, 30)
        Me.btnAgregarI.TabIndex = 19
        '
        'UltraLabel4
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Appearance49.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance49
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(7, 114)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(54, 14)
        Me.UltraLabel4.TabIndex = 3
        Me.UltraLabel4.Text = "Nro Viaje:"
        '
        'cboClienteI
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.cboClienteI.Appearance = Appearance50
        Me.cboClienteI.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboClienteI.DisplayMember = "Nombre"
        Me.cboClienteI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteI.ForeColor = System.Drawing.Color.Black
        Me.cboClienteI.Location = New System.Drawing.Point(67, 133)
        Me.cboClienteI.Name = "cboClienteI"
        Me.cboClienteI.Size = New System.Drawing.Size(350, 21)
        Me.cboClienteI.TabIndex = 8
        Me.cboClienteI.ValueMember = "Id"
        '
        'txtFactorCovI
        '
        Appearance51.TextHAlignAsString = "Right"
        Me.txtFactorCovI.Appearance = Appearance51
        Me.txtFactorCovI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFactorCovI.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtFactorCovI.InputMask = "{LOC}nnn.nn"
        Me.txtFactorCovI.Location = New System.Drawing.Point(330, 202)
        Me.txtFactorCovI.Name = "txtFactorCovI"
        Me.txtFactorCovI.NonAutoSizeHeight = 20
        Me.txtFactorCovI.NullText = "1.00"
        Me.txtFactorCovI.Size = New System.Drawing.Size(45, 20)
        Me.txtFactorCovI.TabIndex = 18
        Me.txtFactorCovI.Text = "1.00"
        '
        'Agrupacion5
        '
        Appearance52.BackColor = System.Drawing.Color.White
        Appearance52.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion5.ContentAreaAppearance = Appearance52
        Me.Agrupacion5.Controls.Add(Me.txtNumeroI)
        Me.Agrupacion5.Controls.Add(Me.txtPrecioFacturaI)
        Me.Agrupacion5.Controls.Add(Me.txtSerieI)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel10)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel8)
        Me.Agrupacion5.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(183, 32)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(234, 72)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.Text = "Documento de Referencia"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtNumeroI
        '
        Me.txtNumeroI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroI.Location = New System.Drawing.Point(105, 21)
        Me.txtNumeroI.MaxLength = 10
        Me.txtNumeroI.Name = "txtNumeroI"
        Me.txtNumeroI.Size = New System.Drawing.Size(100, 21)
        Me.txtNumeroI.TabIndex = 2
        '
        'txtPrecioFacturaI
        '
        Appearance53.TextHAlignAsString = "Right"
        Me.txtPrecioFacturaI.Appearance = Appearance53
        Me.txtPrecioFacturaI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPrecioFacturaI.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtPrecioFacturaI.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtPrecioFacturaI.InputMask = "{double:9.4}"
        Me.txtPrecioFacturaI.Location = New System.Drawing.Point(53, 44)
        Me.txtPrecioFacturaI.Name = "txtPrecioFacturaI"
        Me.txtPrecioFacturaI.NonAutoSizeHeight = 20
        Me.txtPrecioFacturaI.NullText = "0"
        Me.txtPrecioFacturaI.Size = New System.Drawing.Size(70, 20)
        Me.txtPrecioFacturaI.TabIndex = 5
        '
        'txtSerieI
        '
        Me.txtSerieI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieI.Location = New System.Drawing.Point(53, 21)
        Me.txtSerieI.MaxLength = 4
        Me.txtSerieI.Name = "txtSerieI"
        Me.txtSerieI.Size = New System.Drawing.Size(40, 21)
        Me.txtSerieI.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Appearance54.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance54
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(10, 48)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Precio:"
        '
        'UltraLabel8
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance55
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(5, 25)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel8.TabIndex = 0
        Me.UltraLabel8.Text = "Numero:"
        '
        'UltraLabel1
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance56
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(95, 25)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(8, 14)
        Me.UltraLabel1.TabIndex = 3
        Me.UltraLabel1.Text = "-"
        '
        'UltraLabel25
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance57
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(8, 183)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(53, 14)
        Me.UltraLabel25.TabIndex = 11
        Me.UltraLabel25.Text = "Cantidad:"
        '
        'UnidadMedida
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UnidadMedida.Appearance = Appearance58
        Me.UnidadMedida.AutoSize = True
        Me.UnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnidadMedida.Location = New System.Drawing.Point(188, 183)
        Me.UnidadMedida.Name = "UnidadMedida"
        Me.UnidadMedida.Size = New System.Drawing.Size(81, 14)
        Me.UnidadMedida.TabIndex = 15
        Me.UnidadMedida.Text = "UnidadMedida:"
        '
        'cboEstadoI
        '
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoI.Appearance = Appearance59
        Me.cboEstadoI.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoI.DisplayMember = ""
        Me.cboEstadoI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoI.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoI.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoI.Location = New System.Drawing.Point(67, 201)
        Me.cboEstadoI.Name = "cboEstadoI"
        Me.cboEstadoI.Size = New System.Drawing.Size(110, 21)
        Me.cboEstadoI.TabIndex = 14
        Me.cboEstadoI.ValueMember = "Id"
        '
        'cboUnidadI
        '
        Appearance60.ForeColor = System.Drawing.Color.Black
        Me.cboUnidadI.Appearance = Appearance60
        Me.cboUnidadI.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboUnidadI.DisplayMember = ""
        Me.cboUnidadI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboUnidadI.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboUnidadI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadI.ForeColor = System.Drawing.Color.Black
        ValueListItem8.DataValue = "ValueListItem0"
        ValueListItem8.DisplayText = "UNIDAD"
        ValueListItem9.DataValue = "ValueListItem2"
        ValueListItem9.DisplayText = "BOLSA"
        ValueListItem10.DataValue = "ValueListItem1"
        ValueListItem10.DisplayText = "CAJA"
        Me.cboUnidadI.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem8, ValueListItem9, ValueListItem10})
        Me.cboUnidadI.Location = New System.Drawing.Point(275, 179)
        Me.cboUnidadI.Name = "cboUnidadI"
        Me.cboUnidadI.Size = New System.Drawing.Size(100, 21)
        Me.cboUnidadI.TabIndex = 16
        Me.cboUnidadI.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance61
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(13, 159)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel3.TabIndex = 9
        Me.UltraLabel3.Text = "Material:"
        '
        'txtNroViajeI
        '
        Me.txtNroViajeI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroViajeI.Enabled = False
        Me.txtNroViajeI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroViajeI.Location = New System.Drawing.Point(67, 110)
        Me.txtNroViajeI.Name = "txtNroViajeI"
        Me.txtNroViajeI.ReadOnly = True
        Me.txtNroViajeI.Size = New System.Drawing.Size(110, 21)
        Me.txtNroViajeI.TabIndex = 4
        '
        'uebAlmacenMermas
        '
        Me.uebAlmacenMermas.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.uebAlmacenMermas.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.uebAlmacenMermas.Dock = System.Windows.Forms.DockStyle.Left
        Me.uebAlmacenMermas.ExpandedSize = New System.Drawing.Size(605, 244)
        Me.uebAlmacenMermas.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.uebAlmacenMermas.Location = New System.Drawing.Point(3, 3)
        Me.uebAlmacenMermas.Name = "uebAlmacenMermas"
        Me.uebAlmacenMermas.Size = New System.Drawing.Size(605, 244)
        Me.uebAlmacenMermas.TabIndex = 0
        Me.uebAlmacenMermas.Text = "Almacen Mermas"
        Me.uebAlmacenMermas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griAlmacenMermasI)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(582, 238)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griAlmacenMermasI
        '
        Me.griAlmacenMermasI.DataSource = Me.ogdAlmMer
        UltraGridColumn220.Header.VisiblePosition = 0
        UltraGridColumn220.Hidden = True
        UltraGridColumn221.Header.VisiblePosition = 1
        UltraGridColumn221.Hidden = True
        UltraGridColumn222.Header.VisiblePosition = 3
        UltraGridColumn222.Hidden = True
        UltraGridColumn222.Width = 227
        UltraGridColumn223.Header.VisiblePosition = 4
        UltraGridColumn223.Hidden = True
        UltraGridColumn223.Width = 70
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn224.CellAppearance = Appearance62
        UltraGridColumn224.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn224.Header.Caption = "Cantidad"
        UltraGridColumn224.Header.VisiblePosition = 8
        UltraGridColumn224.MaskInput = "{double:9.4}"
        UltraGridColumn224.Width = 50
        Appearance63.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Appearance63.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn225.CellAppearance = Appearance63
        Appearance64.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Appearance64.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn225.CellButtonAppearance = Appearance64
        UltraGridColumn225.Header.Caption = "Agregar"
        UltraGridColumn225.Header.VisiblePosition = 9
        UltraGridColumn225.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn225.Width = 40
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn226.CellAppearance = Appearance65
        UltraGridColumn226.Header.VisiblePosition = 6
        UltraGridColumn226.MaskInput = "{double:9.4}"
        UltraGridColumn226.Width = 67
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn227.CellAppearance = Appearance66
        UltraGridColumn227.Header.VisiblePosition = 7
        UltraGridColumn227.MaskInput = "{double:9.4}"
        UltraGridColumn227.Width = 40
        UltraGridColumn228.Header.Caption = "Select"
        UltraGridColumn228.Header.VisiblePosition = 2
        UltraGridColumn228.Hidden = True
        UltraGridColumn228.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn228.Width = 30
        UltraGridColumn229.Header.VisiblePosition = 5
        UltraGridColumn229.Width = 330
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229})
        UltraGridBand6.GroupHeadersVisible = False
        UltraGridBand6.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMermasI.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griAlmacenMermasI.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMermasI.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAlmacenMermasI.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasI.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMermasI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMermasI.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAlmacenMermasI.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMermasI.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griAlmacenMermasI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAlmacenMermasI.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlmacenMermasI.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMermasI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMermasI.DisplayLayout.UseFixedHeaders = True
        Me.griAlmacenMermasI.Dock = System.Windows.Forms.DockStyle.Left
        Me.griAlmacenMermasI.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMermasI.ImageList = Me.imagenes
        Me.griAlmacenMermasI.Location = New System.Drawing.Point(0, 0)
        Me.griAlmacenMermasI.Name = "griAlmacenMermasI"
        Me.griAlmacenMermasI.Size = New System.Drawing.Size(592, 238)
        Me.griAlmacenMermasI.TabIndex = 0
        Me.griAlmacenMermasI.Tag = ""
        '
        'expViaje
        '
        Me.expViaje.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Far
        Appearance67.BackColor = System.Drawing.Color.White
        Appearance67.BackColor2 = System.Drawing.Color.White
        Me.expViaje.ContentAreaAppearance = Appearance67
        Me.expViaje.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.expViaje.Dock = System.Windows.Forms.DockStyle.Left
        Me.expViaje.Expanded = False
        Me.expViaje.ExpandedSize = New System.Drawing.Size(788, 395)
        Me.expViaje.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.expViaje.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.expViaje.Location = New System.Drawing.Point(3, 16)
        Me.expViaje.Name = "expViaje"
        Me.expViaje.Size = New System.Drawing.Size(28, 395)
        Me.expViaje.TabIndex = 0
        Me.expViaje.TabStop = False
        Me.expViaje.Text = "Viajes"
        Me.expViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griViajes)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(916, 602)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'griViajes
        '
        Me.griViajes.DataSource = Me.ogdViajes
        UltraGridColumn103.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn103.Header.VisiblePosition = 17
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn104.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance68.TextHAlignAsString = "Center"
        Appearance68.TextVAlignAsString = "Middle"
        UltraGridColumn104.CellAppearance = Appearance68
        Appearance69.TextHAlignAsString = "Center"
        UltraGridColumn104.Header.Appearance = Appearance69
        UltraGridColumn104.Header.Fixed = True
        UltraGridColumn104.Header.VisiblePosition = 0
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn104.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn104.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn104.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn104.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn104.Width = 95
        UltraGridColumn105.Header.VisiblePosition = 18
        UltraGridColumn105.Hidden = True
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn106.CellAppearance = Appearance70
        UltraGridColumn106.Header.Caption = "Viaje"
        UltraGridColumn106.Header.Fixed = True
        UltraGridColumn106.Header.VisiblePosition = 1
        UltraGridColumn106.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn106.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn106.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn106.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn106.Width = 95
        UltraGridColumn107.Header.VisiblePosition = 19
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.Fixed = True
        UltraGridColumn108.Header.VisiblePosition = 4
        UltraGridColumn108.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn108.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn108.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn108.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn108.Width = 123
        UltraGridColumn109.Header.VisiblePosition = 20
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.Fixed = True
        UltraGridColumn110.Header.VisiblePosition = 5
        UltraGridColumn110.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn110.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn110.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn110.Width = 111
        UltraGridColumn111.Header.VisiblePosition = 21
        UltraGridColumn111.Hidden = True
        Appearance71.TextVAlignAsString = "Middle"
        UltraGridColumn112.CellAppearance = Appearance71
        UltraGridColumn112.Header.VisiblePosition = 22
        UltraGridColumn112.Hidden = True
        UltraGridColumn112.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn112.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn112.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn112.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn112.Width = 124
        Appearance72.TextVAlignAsString = "Middle"
        UltraGridColumn113.CellAppearance = Appearance72
        UltraGridColumn113.Header.Caption = "Vacio"
        UltraGridColumn113.Header.VisiblePosition = 33
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn113.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn113.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn113.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn113.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn113.Width = 40
        UltraGridColumn114.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn114.Header.VisiblePosition = 23
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 8
        UltraGridColumn115.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn115.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn115.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn115.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn115.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn115.Width = 215
        UltraGridColumn116.Header.VisiblePosition = 24
        UltraGridColumn116.Hidden = True
        Appearance73.Image = 7
        UltraGridColumn117.CellButtonAppearance = Appearance73
        UltraGridColumn117.Header.VisiblePosition = 9
        UltraGridColumn117.Hidden = True
        UltraGridColumn117.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn117.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn117.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn117.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn117.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn117.Width = 150
        UltraGridColumn118.Header.VisiblePosition = 16
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 15
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn120.Header.VisiblePosition = 14
        UltraGridColumn120.Hidden = True
        Appearance74.TextHAlignAsString = "Left"
        Appearance74.TextVAlignAsString = "Middle"
        UltraGridColumn121.CellAppearance = Appearance74
        UltraGridColumn121.Header.Fixed = True
        UltraGridColumn121.Header.VisiblePosition = 6
        UltraGridColumn121.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn121.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn121.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn121.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn121.Width = 107
        UltraGridColumn122.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn122.Header.VisiblePosition = 13
        UltraGridColumn122.Hidden = True
        Appearance75.TextHAlignAsString = "Left"
        Appearance75.TextVAlignAsString = "Middle"
        UltraGridColumn123.CellAppearance = Appearance75
        UltraGridColumn123.Header.VisiblePosition = 7
        UltraGridColumn123.Hidden = True
        UltraGridColumn123.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn123.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn123.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn123.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn123.VertScrollBar = True
        UltraGridColumn123.Width = 40
        Appearance76.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance76.TextHAlignAsString = "Right"
        Appearance76.TextVAlignAsString = "Middle"
        UltraGridColumn124.CellAppearance = Appearance76
        UltraGridColumn124.Format = "#,###,###,##0.00"
        UltraGridColumn124.Header.VisiblePosition = 28
        UltraGridColumn124.Hidden = True
        UltraGridColumn124.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn124.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn124.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn124.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn124.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn124.Width = 100
        UltraGridColumn125.Header.VisiblePosition = 25
        UltraGridColumn125.Hidden = True
        Appearance77.TextVAlignAsString = "Middle"
        UltraGridColumn126.CellAppearance = Appearance77
        UltraGridColumn126.Header.VisiblePosition = 34
        UltraGridColumn126.Hidden = True
        UltraGridColumn126.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn126.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn126.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn126.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn126.Width = 100
        UltraGridColumn127.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn127.Header.Fixed = True
        UltraGridColumn127.Header.VisiblePosition = 3
        UltraGridColumn127.MaskInput = "{LOC}mm/dd/yyyy"
        UltraGridColumn127.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn127.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn127.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn127.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn127.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn127.Width = 72
        UltraGridColumn128.Header.Caption = "UsuarioCrea"
        UltraGridColumn128.Header.VisiblePosition = 51
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.Width = 150
        UltraGridColumn129.Header.VisiblePosition = 29
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn130.Header.Fixed = True
        UltraGridColumn130.Header.VisiblePosition = 2
        UltraGridColumn130.Hidden = True
        UltraGridColumn130.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn130.Width = 30
        UltraGridColumn131.Header.VisiblePosition = 30
        UltraGridColumn131.Hidden = True
        Appearance78.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn132.CellAppearance = Appearance78
        UltraGridColumn132.Header.VisiblePosition = 48
        UltraGridColumn132.Hidden = True
        UltraGridColumn132.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn132.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn132.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn132.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn132.Width = 100
        UltraGridColumn133.Header.VisiblePosition = 35
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 36
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 37
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 10
        UltraGridColumn136.Width = 136
        UltraGridColumn137.Header.VisiblePosition = 38
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 39
        UltraGridColumn138.Hidden = True
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn139.CellAppearance = Appearance79
        UltraGridColumn139.Header.VisiblePosition = 11
        UltraGridColumn139.Width = 104
        UltraGridColumn140.Header.VisiblePosition = 52
        UltraGridColumn140.Hidden = True
        UltraGridColumn140.Width = 150
        UltraGridColumn141.Header.VisiblePosition = 53
        UltraGridColumn141.Hidden = True
        UltraGridColumn141.Width = 150
        UltraGridColumn142.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn142.Header.VisiblePosition = 40
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn142.Width = 100
        UltraGridColumn143.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn143.Header.VisiblePosition = 41
        UltraGridColumn143.Hidden = True
        UltraGridColumn143.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn143.Width = 100
        UltraGridColumn144.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn144.Header.VisiblePosition = 42
        UltraGridColumn144.Hidden = True
        UltraGridColumn144.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn144.Width = 100
        UltraGridColumn145.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn145.Header.VisiblePosition = 43
        UltraGridColumn145.Hidden = True
        UltraGridColumn145.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn145.Width = 100
        UltraGridColumn146.Header.VisiblePosition = 49
        UltraGridColumn146.Hidden = True
        UltraGridColumn146.Width = 100
        Appearance80.Image = 3
        Appearance80.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn147.CellAppearance = Appearance80
        Appearance81.Image = 1
        UltraGridColumn147.CellButtonAppearance = Appearance81
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn147.Header.VisiblePosition = 54
        UltraGridColumn147.Hidden = True
        UltraGridColumn147.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn147.Width = 250
        UltraGridColumn148.Header.VisiblePosition = 55
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.Width = 250
        UltraGridColumn149.Header.Caption = "Bloque"
        UltraGridColumn149.Header.VisiblePosition = 56
        UltraGridColumn149.Hidden = True
        UltraGridColumn149.Width = 40
        UltraGridColumn150.Header.Caption = "D/N"
        UltraGridColumn150.Header.VisiblePosition = 57
        UltraGridColumn150.Hidden = True
        UltraGridColumn150.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn150.Width = 40
        UltraGridColumn151.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance82.TextHAlignAsString = "Right"
        Appearance82.TextVAlignAsString = "Middle"
        UltraGridColumn151.CellAppearance = Appearance82
        UltraGridColumn151.Header.Caption = "TN"
        UltraGridColumn151.Header.VisiblePosition = 12
        UltraGridColumn151.Hidden = True
        UltraGridColumn151.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn151.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn151.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn151.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn151.Width = 40
        UltraGridColumn152.Header.VisiblePosition = 50
        UltraGridColumn152.Hidden = True
        UltraGridColumn152.Width = 100
        Appearance83.TextHAlignAsString = "Right"
        Appearance83.TextVAlignAsString = "Middle"
        UltraGridColumn153.CellAppearance = Appearance83
        UltraGridColumn153.Format = ""
        UltraGridColumn153.Header.Caption = "Produccion"
        UltraGridColumn153.Header.VisiblePosition = 32
        UltraGridColumn153.Hidden = True
        UltraGridColumn153.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn153.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn153.Width = 100
        UltraGridColumn154.Header.VisiblePosition = 58
        UltraGridColumn154.Hidden = True
        UltraGridColumn154.Width = 40
        UltraGridColumn155.Header.Caption = "Ind"
        UltraGridColumn155.Header.VisiblePosition = 59
        UltraGridColumn155.Hidden = True
        UltraGridColumn155.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn155.Width = 40
        UltraGridColumn156.Header.Caption = "%Flete"
        UltraGridColumn156.Header.VisiblePosition = 31
        UltraGridColumn156.Hidden = True
        UltraGridColumn156.Width = 40
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn157.CellAppearance = Appearance84
        UltraGridColumn157.Header.Caption = "KmTracto O"
        UltraGridColumn157.Header.VisiblePosition = 44
        UltraGridColumn157.Hidden = True
        UltraGridColumn157.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn157.Width = 70
        Appearance85.TextHAlignAsString = "Right"
        UltraGridColumn158.CellAppearance = Appearance85
        UltraGridColumn158.Header.Caption = "KmTracto D"
        UltraGridColumn158.Header.VisiblePosition = 45
        UltraGridColumn158.Hidden = True
        UltraGridColumn158.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn158.Width = 70
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn159.CellAppearance = Appearance86
        UltraGridColumn159.Header.Caption = "KmCarreta O"
        UltraGridColumn159.Header.VisiblePosition = 46
        UltraGridColumn159.Hidden = True
        UltraGridColumn159.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn159.Width = 70
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn160.CellAppearance = Appearance87
        UltraGridColumn160.Header.Caption = "KmCarreta D"
        UltraGridColumn160.Header.VisiblePosition = 47
        UltraGridColumn160.Hidden = True
        UltraGridColumn160.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn160.Width = 70
        UltraGridColumn161.Header.VisiblePosition = 60
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 61
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 62
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 63
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 65
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.VisiblePosition = 64
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 66
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 67
        UltraGridColumn168.Hidden = True
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn169.CellAppearance = Appearance88
        UltraGridColumn169.Header.Caption = "Cant."
        UltraGridColumn169.Header.VisiblePosition = 26
        UltraGridColumn169.Hidden = True
        UltraGridColumn169.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn169.Width = 40
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn170.CellAppearance = Appearance89
        UltraGridColumn170.Header.VisiblePosition = 27
        UltraGridColumn170.Hidden = True
        UltraGridColumn170.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn170.Width = 60
        UltraGridColumn171.Header.VisiblePosition = 68
        UltraGridColumn171.Hidden = True
        UltraGridColumn171.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn171.Width = 40
        UltraGridColumn172.Header.VisiblePosition = 69
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 70
        UltraGridColumn173.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173})
        UltraGridBand7.GroupHeadersVisible = False
        UltraGridBand7.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38, RowLayoutColumnInfo39, RowLayoutColumnInfo40, RowLayoutColumnInfo41, RowLayoutColumnInfo42, RowLayoutColumnInfo43, RowLayoutColumnInfo44, RowLayoutColumnInfo45, RowLayoutColumnInfo46, RowLayoutColumnInfo47, RowLayoutColumnInfo48, RowLayoutColumnInfo49, RowLayoutColumnInfo50, RowLayoutColumnInfo51, RowLayoutColumnInfo52, RowLayoutColumnInfo53, RowLayoutColumnInfo54, RowLayoutColumnInfo55, RowLayoutColumnInfo56, RowLayoutColumnInfo57, RowLayoutColumnInfo58, RowLayoutColumnInfo59, RowLayoutColumnInfo60, RowLayoutColumnInfo61, RowLayoutColumnInfo62, RowLayoutColumnInfo63, RowLayoutColumnInfo64, RowLayoutColumnInfo65, RowLayoutColumnInfo66, RowLayoutColumnInfo67, RowLayoutColumnInfo68, RowLayoutColumnInfo69, RowLayoutColumnInfo70, RowLayoutColumnInfo71})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand7.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand7.SummaryFooterCaption = "Totales:"
        Me.griViajes.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griViajes.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajes.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajes.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griViajes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajes.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajes.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griViajes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajes.DisplayLayout.UseFixedHeaders = True
        Me.griViajes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajes.ImageList = Me.imagenes
        Me.griViajes.Location = New System.Drawing.Point(0, 60)
        Me.griViajes.Name = "griViajes"
        Me.griViajes.Size = New System.Drawing.Size(916, 542)
        Me.griViajes.TabIndex = 1
        Me.griViajes.Tag = ""
        '
        'ogdViajes
        '
        UltraDataColumn67.DataType = GetType(Boolean)
        UltraDataColumn81.DataType = GetType(Date)
        UltraDataColumn96.DataType = GetType(Date)
        UltraDataColumn97.DataType = GetType(Date)
        UltraDataColumn98.DataType = GetType(Date)
        UltraDataColumn99.DataType = GetType(Date)
        UltraDataColumn101.DefaultValue = ""
        UltraDataColumn105.DataType = GetType(Decimal)
        Me.ogdViajes.Band.Columns.AddRange(New Object() {UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127})
        '
        'UltraGroupBox1
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Appearance = Appearance90
        Appearance91.BackColor = System.Drawing.Color.White
        Appearance91.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance91
        Me.UltraGroupBox1.Controls.Add(Me.fecHastaViaje)
        Me.UltraGroupBox1.Controls.Add(Me.fecDesdeViaje)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel39)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel41)
        Me.UltraGroupBox1.Controls.Add(Me.verTracto)
        Me.UltraGroupBox1.Controls.Add(Me.cboTractoLista)
        Me.UltraGroupBox1.Controls.Add(Me.cboCentro)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox1.Controls.Add(Me.btnListarViajes)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(916, 60)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHastaViaje
        '
        Me.fecHastaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHastaViaje.Location = New System.Drawing.Point(53, 35)
        Me.fecHastaViaje.Name = "fecHastaViaje"
        Me.fecHastaViaje.Size = New System.Drawing.Size(103, 20)
        Me.fecHastaViaje.TabIndex = 3
        '
        'fecDesdeViaje
        '
        Me.fecDesdeViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesdeViaje.Location = New System.Drawing.Point(53, 11)
        Me.fecDesdeViaje.Name = "fecDesdeViaje"
        Me.fecDesdeViaje.Size = New System.Drawing.Size(103, 20)
        Me.fecDesdeViaje.TabIndex = 1
        '
        'UltraLabel39
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Appearance92.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance92
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(10, 37)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel39.TabIndex = 2
        Me.UltraLabel39.Text = "Hasta:"
        '
        'UltraLabel41
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Appearance93.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance93
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(7, 14)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'verTracto
        '
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.verTracto.Appearance = Appearance94
        Me.verTracto.AutoSize = True
        Me.verTracto.Location = New System.Drawing.Point(182, 35)
        Me.verTracto.Name = "verTracto"
        Me.verTracto.Size = New System.Drawing.Size(56, 17)
        Me.verTracto.TabIndex = 6
        Me.verTracto.Text = "Tracto:"
        '
        'cboTractoLista
        '
        Appearance95.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Appearance = Appearance95
        Me.cboTractoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoLista.DisplayMember = "Nombre"
        Me.cboTractoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoLista.Enabled = False
        Me.cboTractoLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoLista.ForeColor = System.Drawing.Color.Black
        Me.cboTractoLista.Location = New System.Drawing.Point(240, 34)
        Me.cboTractoLista.Name = "cboTractoLista"
        Me.cboTractoLista.Size = New System.Drawing.Size(100, 21)
        Me.cboTractoLista.TabIndex = 7
        Me.cboTractoLista.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance96
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(240, 11)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(100, 21)
        Me.cboCentro.TabIndex = 5
        Me.cboCentro.ValueMember = "Id"
        '
        'UltraLabel7
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Appearance97.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance97
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(197, 13)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel7.TabIndex = 4
        Me.UltraLabel7.Text = "Centro:"
        '
        'btnListarViajes
        '
        Appearance98.Image = "266.png"
        Appearance98.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance98.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnListarViajes.Appearance = Appearance98
        Me.btnListarViajes.ImageList = Me.imagenes
        Me.btnListarViajes.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnListarViajes.Location = New System.Drawing.Point(346, 24)
        Me.btnListarViajes.Name = "btnListarViajes"
        Me.btnListarViajes.Size = New System.Drawing.Size(45, 30)
        Me.btnListarViajes.TabIndex = 8
        Me.btnListarViajes.TabStop = False
        '
        'Agrupacion3
        '
        Appearance99.BackColor = System.Drawing.Color.White
        Appearance99.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion3.ContentAreaAppearance = Appearance99
        Me.Agrupacion3.Controls.Add(Me.txtTotalI)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel20)
        Me.Agrupacion3.Controls.Add(Me.txtIdMovimientoI)
        Me.Agrupacion3.Controls.Add(Me.fecFechaI)
        Me.Agrupacion3.Controls.Add(Me.txtGlosaI)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel9)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1155, 60)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Datos Generales"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotalI
        '
        Appearance100.TextHAlignAsString = "Right"
        Me.txtTotalI.Appearance = Appearance100
        Me.txtTotalI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotalI.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtTotalI.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtTotalI.InputMask = "{double:9.4}"
        Me.txtTotalI.Location = New System.Drawing.Point(656, 28)
        Me.txtTotalI.Name = "txtTotalI"
        Me.txtTotalI.NonAutoSizeHeight = 20
        Me.txtTotalI.NullText = "0.00"
        Me.txtTotalI.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalI.TabIndex = 4
        '
        'UltraLabel20
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Appearance101.TextVAlignAsString = "Middle"
        Me.UltraLabel20.Appearance = Appearance101
        Me.UltraLabel20.AutoSize = True
        Me.UltraLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel20.Location = New System.Drawing.Point(562, 32)
        Me.UltraLabel20.Name = "UltraLabel20"
        Me.UltraLabel20.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel20.TabIndex = 3
        Me.UltraLabel20.Text = "Total Ingreso S/.:"
        '
        'txtIdMovimientoI
        '
        Me.txtIdMovimientoI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMovimientoI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdMovimientoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovimientoI.Location = New System.Drawing.Point(779, 28)
        Me.txtIdMovimientoI.MaxLength = 4
        Me.txtIdMovimientoI.Name = "txtIdMovimientoI"
        Me.txtIdMovimientoI.Size = New System.Drawing.Size(75, 21)
        Me.txtIdMovimientoI.TabIndex = 5
        Me.txtIdMovimientoI.Visible = False
        '
        'fecFechaI
        '
        Me.fecFechaI.DateTime = New Date(2015, 4, 21, 0, 0, 0, 0)
        Me.fecFechaI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaI.Location = New System.Drawing.Point(54, 25)
        Me.fecFechaI.MaskInput = ""
        Me.fecFechaI.Name = "fecFechaI"
        Me.fecFechaI.Size = New System.Drawing.Size(91, 21)
        Me.fecFechaI.TabIndex = 1
        Me.fecFechaI.Value = New Date(2015, 4, 21, 0, 0, 0, 0)
        '
        'txtGlosaI
        '
        Me.txtGlosaI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaI.Location = New System.Drawing.Point(151, 25)
        Me.txtGlosaI.MaxLength = 500
        Me.txtGlosaI.Multiline = True
        Me.txtGlosaI.Name = "txtGlosaI"
        Me.txtGlosaI.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaI.Size = New System.Drawing.Size(400, 21)
        Me.txtGlosaI.TabIndex = 2
        '
        'UltraLabel9
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Appearance102.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance102
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(11, 28)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel9.TabIndex = 0
        Me.UltraLabel9.Text = "Fecha:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1155, 474)
        '
        'Agrupacion6
        '
        Appearance103.BackColor = System.Drawing.Color.White
        Appearance103.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance103
        Me.Agrupacion6.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion6.Controls.Add(Me.Agrupacion9)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1155, 474)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion7
        '
        Me.Agrupacion7.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance104.BackColor = System.Drawing.Color.White
        Appearance104.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion7.ContentAreaAppearance = Appearance104
        Me.Agrupacion7.Controls.Add(Me.griDetalleMermasS)
        Me.Agrupacion7.Controls.Add(Me.griAlmacenMermasS)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(3, 103)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(1149, 368)
        Me.Agrupacion7.TabIndex = 1
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleMermasS
        '
        Me.griDetalleMermasS.ContextMenuStrip = Me.mnuQuitDetS
        Me.griDetalleMermasS.DataSource = Me.ogdIngSal
        UltraGridColumn174.Header.VisiblePosition = 0
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 1
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 2
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.Caption = "Cliente"
        UltraGridColumn177.Header.VisiblePosition = 3
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.Width = 150
        UltraGridColumn178.Header.VisiblePosition = 4
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 5
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.Caption = "Material"
        UltraGridColumn180.Header.VisiblePosition = 7
        UltraGridColumn180.Hidden = True
        UltraGridColumn180.Width = 200
        UltraGridColumn181.Header.Caption = "Unidad"
        UltraGridColumn181.Header.VisiblePosition = 8
        UltraGridColumn181.Hidden = True
        Appearance105.TextHAlignAsString = "Right"
        UltraGridColumn182.CellAppearance = Appearance105
        UltraGridColumn182.Header.VisiblePosition = 9
        UltraGridColumn182.MaskInput = "{double:9.4}"
        UltraGridColumn182.Width = 82
        Appearance106.TextHAlignAsString = "Right"
        UltraGridColumn183.CellAppearance = Appearance106
        UltraGridColumn183.Header.VisiblePosition = 10
        UltraGridColumn183.MaskInput = "{double:9.4}"
        UltraGridColumn183.Width = 87
        Appearance107.TextHAlignAsString = "Right"
        UltraGridColumn184.CellAppearance = Appearance107
        UltraGridColumn184.Header.VisiblePosition = 11
        UltraGridColumn184.MaskInput = "{double:9.4}"
        UltraGridColumn184.Width = 85
        UltraGridColumn185.Header.VisiblePosition = 12
        UltraGridColumn185.Hidden = True
        UltraGridColumn185.MaskInput = "{double:9.4}"
        UltraGridColumn186.Header.VisiblePosition = 13
        UltraGridColumn186.Hidden = True
        UltraGridColumn187.Header.Caption = "Nro Viaje"
        UltraGridColumn187.Header.VisiblePosition = 14
        UltraGridColumn187.Hidden = True
        UltraGridColumn187.Width = 100
        UltraGridColumn188.Header.Caption = "Estado"
        UltraGridColumn188.Header.VisiblePosition = 15
        UltraGridColumn188.Hidden = True
        UltraGridColumn188.Width = 100
        Appearance108.TextHAlignAsString = "Right"
        UltraGridColumn189.CellAppearance = Appearance108
        UltraGridColumn189.Header.VisiblePosition = 16
        UltraGridColumn189.Hidden = True
        UltraGridColumn189.Width = 30
        UltraGridColumn190.Header.VisiblePosition = 17
        UltraGridColumn190.Hidden = True
        UltraGridColumn190.Width = 70
        Appearance109.TextHAlignAsString = "Right"
        UltraGridColumn191.CellAppearance = Appearance109
        UltraGridColumn191.Header.VisiblePosition = 18
        UltraGridColumn191.Hidden = True
        UltraGridColumn191.MaskInput = "{double:9.4}"
        UltraGridColumn191.Width = 60
        UltraGridColumn192.Header.VisiblePosition = 19
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 20
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 21
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 22
        UltraGridColumn195.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 6
        UltraGridColumn208.Width = 286
        UltraGridColumn212.Header.VisiblePosition = 23
        UltraGridColumn212.Hidden = True
        UltraGridColumn212.Width = 100
        UltraGridColumn216.Header.VisiblePosition = 24
        UltraGridColumn216.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn208, UltraGridColumn212, UltraGridColumn216})
        UltraGridBand8.GroupHeadersVisible = False
        UltraGridBand8.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleMermasS.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griDetalleMermasS.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleMermasS.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleMermasS.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasS.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasS.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMermasS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleMermasS.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleMermasS.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleMermasS.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleMermasS.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griDetalleMermasS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleMermasS.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleMermasS.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleMermasS.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleMermasS.DisplayLayout.UseFixedHeaders = True
        Me.griDetalleMermasS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleMermasS.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleMermasS.Location = New System.Drawing.Point(565, 3)
        Me.griDetalleMermasS.Name = "griDetalleMermasS"
        Me.griDetalleMermasS.Size = New System.Drawing.Size(581, 362)
        Me.griDetalleMermasS.TabIndex = 1
        Me.griDetalleMermasS.Tag = ""
        '
        'mnuQuitDetS
        '
        Me.mnuQuitDetS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnuQuitDetS.Name = "mnuQuitarDetalle"
        Me.mnuQuitDetS.Size = New System.Drawing.Size(108, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ToolStripMenuItem1.Text = "Quitar"
        '
        'griAlmacenMermasS
        '
        Me.griAlmacenMermasS.DataSource = Me.ogdAlmMer
        UltraGridColumn196.Header.VisiblePosition = 0
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.Caption = "IdMaterial"
        UltraGridColumn197.Header.VisiblePosition = 1
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.Caption = "Material"
        UltraGridColumn198.Header.VisiblePosition = 3
        UltraGridColumn198.Hidden = True
        UltraGridColumn198.Width = 200
        UltraGridColumn199.Header.Caption = "UnidadMedida"
        UltraGridColumn199.Header.VisiblePosition = 4
        UltraGridColumn199.Hidden = True
        UltraGridColumn199.Width = 70
        Appearance110.TextHAlignAsString = "Right"
        UltraGridColumn200.CellAppearance = Appearance110
        UltraGridColumn200.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn200.Header.Caption = "Cantidad"
        UltraGridColumn200.Header.VisiblePosition = 8
        UltraGridColumn200.MaskInput = "{double:9.4}"
        UltraGridColumn200.Width = 48
        Appearance111.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Appearance111.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn201.CellAppearance = Appearance111
        Appearance112.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Appearance112.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn201.CellButtonAppearance = Appearance112
        UltraGridColumn201.Header.Caption = "Agregar"
        UltraGridColumn201.Header.VisiblePosition = 9
        UltraGridColumn201.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn201.Width = 49
        Appearance113.TextHAlignAsString = "Right"
        UltraGridColumn202.CellAppearance = Appearance113
        UltraGridColumn202.Header.VisiblePosition = 6
        UltraGridColumn202.MaskInput = "{double:9.4}"
        UltraGridColumn202.Width = 66
        Appearance114.TextHAlignAsString = "Right"
        UltraGridColumn203.CellAppearance = Appearance114
        UltraGridColumn203.Header.VisiblePosition = 7
        UltraGridColumn203.MaskInput = "{double:9.4}"
        UltraGridColumn203.Width = 50
        UltraGridColumn204.Header.Caption = "Select"
        UltraGridColumn204.Header.VisiblePosition = 2
        UltraGridColumn204.Hidden = True
        UltraGridColumn204.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn204.Width = 30
        UltraGridColumn219.Header.VisiblePosition = 5
        UltraGridColumn219.Width = 298
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn219})
        UltraGridBand9.GroupHeadersVisible = False
        UltraGridBand9.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAlmacenMermasS.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griAlmacenMermasS.DisplayLayout.MaxColScrollRegions = 1
        Me.griAlmacenMermasS.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAlmacenMermasS.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasS.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasS.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAlmacenMermasS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAlmacenMermasS.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAlmacenMermasS.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAlmacenMermasS.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAlmacenMermasS.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griAlmacenMermasS.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAlmacenMermasS.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAlmacenMermasS.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAlmacenMermasS.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAlmacenMermasS.DisplayLayout.UseFixedHeaders = True
        Me.griAlmacenMermasS.Dock = System.Windows.Forms.DockStyle.Left
        Me.griAlmacenMermasS.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAlmacenMermasS.ImageList = Me.imagenes
        Me.griAlmacenMermasS.Location = New System.Drawing.Point(3, 3)
        Me.griAlmacenMermasS.Name = "griAlmacenMermasS"
        Me.griAlmacenMermasS.Size = New System.Drawing.Size(562, 362)
        Me.griAlmacenMermasS.TabIndex = 0
        Me.griAlmacenMermasS.Tag = ""
        '
        'Agrupacion9
        '
        Appearance115.BackColor = System.Drawing.Color.White
        Appearance115.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion9.ContentAreaAppearance = Appearance115
        Me.Agrupacion9.Controls.Add(Me.txtTotalS)
        Me.Agrupacion9.Controls.Add(Me.txtDescuentoS)
        Me.Agrupacion9.Controls.Add(Me.txtSubTotalS)
        Me.Agrupacion9.Controls.Add(Me.fecFechaS)
        Me.Agrupacion9.Controls.Add(Me.txtIdSancion)
        Me.Agrupacion9.Controls.Add(Me.txtIdMovimientoS)
        Me.Agrupacion9.Controls.Add(Me.btnListaMermasS)
        Me.Agrupacion9.Controls.Add(Me.txtPorcentajeDescuentoS)
        Me.Agrupacion9.Controls.Add(Me.lblPorcentajeDescuentoS)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel18)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel19)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel29)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel11)
        Me.Agrupacion9.Controls.Add(Me.txtSaldoS)
        Me.Agrupacion9.Controls.Add(Me.txtGlosaS)
        Me.Agrupacion9.Controls.Add(Me.lblMontoAmortizadoS)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel27)
        Me.Agrupacion9.Controls.Add(Me.cboTipoPagoS)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel16)
        Me.Agrupacion9.Controls.Add(Me.cboPersonaS)
        Me.Agrupacion9.Controls.Add(Me.UltraLabel26)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(1149, 100)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.Text = "Datos Generales"
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtTotalS
        '
        Me.txtTotalS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtTotalS.Location = New System.Drawing.Point(740, 70)
        Me.txtTotalS.MaskInput = "{double:9.2}"
        Me.txtTotalS.Name = "txtTotalS"
        Me.txtTotalS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotalS.ReadOnly = True
        Me.txtTotalS.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalS.TabIndex = 19
        '
        'txtDescuentoS
        '
        Me.txtDescuentoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtDescuentoS.Location = New System.Drawing.Point(740, 47)
        Me.txtDescuentoS.MaskInput = "{double:9.2}"
        Me.txtDescuentoS.Name = "txtDescuentoS"
        Me.txtDescuentoS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtDescuentoS.ReadOnly = True
        Me.txtDescuentoS.Size = New System.Drawing.Size(100, 21)
        Me.txtDescuentoS.TabIndex = 17
        '
        'txtSubTotalS
        '
        Me.txtSubTotalS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtSubTotalS.Location = New System.Drawing.Point(740, 24)
        Me.txtSubTotalS.MaskInput = "{double:9.2}"
        Me.txtSubTotalS.Name = "txtSubTotalS"
        Me.txtSubTotalS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtSubTotalS.ReadOnly = True
        Me.txtSubTotalS.Size = New System.Drawing.Size(100, 21)
        Me.txtSubTotalS.TabIndex = 15
        '
        'fecFechaS
        '
        Me.fecFechaS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaS.Location = New System.Drawing.Point(74, 22)
        Me.fecFechaS.Name = "fecFechaS"
        Me.fecFechaS.Size = New System.Drawing.Size(105, 20)
        Me.fecFechaS.TabIndex = 1
        '
        'txtIdSancion
        '
        Me.txtIdSancion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdSancion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdSancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSancion.Location = New System.Drawing.Point(250, 23)
        Me.txtIdSancion.MaxLength = 4
        Me.txtIdSancion.Name = "txtIdSancion"
        Me.txtIdSancion.Size = New System.Drawing.Size(21, 21)
        Me.txtIdSancion.TabIndex = 3
        Me.txtIdSancion.Visible = False
        '
        'txtIdMovimientoS
        '
        Me.txtIdMovimientoS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdMovimientoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdMovimientoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMovimientoS.Location = New System.Drawing.Point(223, 23)
        Me.txtIdMovimientoS.MaxLength = 4
        Me.txtIdMovimientoS.Name = "txtIdMovimientoS"
        Me.txtIdMovimientoS.Size = New System.Drawing.Size(21, 21)
        Me.txtIdMovimientoS.TabIndex = 2
        Me.txtIdMovimientoS.Visible = False
        '
        'btnListaMermasS
        '
        Appearance116.Image = "266.png"
        Appearance116.ImageHAlign = Infragistics.Win.HAlign.Left
        Appearance116.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.btnListaMermasS.Appearance = Appearance116
        Me.btnListaMermasS.ImageList = Me.imagenes
        Me.btnListaMermasS.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnListaMermasS.Location = New System.Drawing.Point(846, 43)
        Me.btnListaMermasS.Name = "btnListaMermasS"
        Me.btnListaMermasS.Size = New System.Drawing.Size(90, 40)
        Me.btnListaMermasS.TabIndex = 20
        Me.btnListaMermasS.Text = "Almacen Mermas"
        '
        'txtPorcentajeDescuentoS
        '
        Appearance117.TextHAlignAsString = "Right"
        Me.txtPorcentajeDescuentoS.Appearance = Appearance117
        Me.txtPorcentajeDescuentoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPorcentajeDescuentoS.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtPorcentajeDescuentoS.InputMask = "{LOC}nn"
        Me.txtPorcentajeDescuentoS.Location = New System.Drawing.Point(634, 47)
        Me.txtPorcentajeDescuentoS.Name = "txtPorcentajeDescuentoS"
        Me.txtPorcentajeDescuentoS.NonAutoSizeHeight = 20
        Me.txtPorcentajeDescuentoS.NullText = "1.00"
        Me.txtPorcentajeDescuentoS.Size = New System.Drawing.Size(30, 20)
        Me.txtPorcentajeDescuentoS.TabIndex = 13
        Me.txtPorcentajeDescuentoS.Text = "0"
        '
        'lblPorcentajeDescuentoS
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Appearance118.TextVAlignAsString = "Middle"
        Me.lblPorcentajeDescuentoS.Appearance = Appearance118
        Me.lblPorcentajeDescuentoS.AutoSize = True
        Me.lblPorcentajeDescuentoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorcentajeDescuentoS.Location = New System.Drawing.Point(615, 50)
        Me.lblPorcentajeDescuentoS.Name = "lblPorcentajeDescuentoS"
        Me.lblPorcentajeDescuentoS.Size = New System.Drawing.Size(17, 14)
        Me.lblPorcentajeDescuentoS.TabIndex = 12
        Me.lblPorcentajeDescuentoS.Text = "%:"
        '
        'UltraLabel18
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Appearance119.TextVAlignAsString = "Middle"
        Me.UltraLabel18.Appearance = Appearance119
        Me.UltraLabel18.AutoSize = True
        Me.UltraLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel18.Location = New System.Drawing.Point(679, 28)
        Me.UltraLabel18.Name = "UltraLabel18"
        Me.UltraLabel18.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel18.TabIndex = 14
        Me.UltraLabel18.Text = "SubTotal:"
        '
        'UltraLabel19
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance120
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(670, 50)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(64, 14)
        Me.UltraLabel19.TabIndex = 16
        Me.UltraLabel19.Text = "Descuento:"
        '
        'UltraLabel29
        '
        Appearance121.BackColor = System.Drawing.Color.Transparent
        Appearance121.ForeColor = System.Drawing.Color.Navy
        Appearance121.TextVAlignAsString = "Middle"
        Me.UltraLabel29.Appearance = Appearance121
        Me.UltraLabel29.AutoSize = True
        Me.UltraLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel29.Location = New System.Drawing.Point(700, 74)
        Me.UltraLabel29.Name = "UltraLabel29"
        Me.UltraLabel29.Size = New System.Drawing.Size(34, 14)
        Me.UltraLabel29.TabIndex = 18
        Me.UltraLabel29.Text = "Total:"
        '
        'UltraLabel11
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance122
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(23, 76)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel11.TabIndex = 6
        Me.UltraLabel11.Text = "Glosa:"
        '
        'txtSaldoS
        '
        Appearance123.TextHAlignAsString = "Right"
        Me.txtSaldoS.Appearance = Appearance123
        Me.txtSaldoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSaldoS.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSaldoS.InputMask = "{LOC}nnn.nn"
        Me.txtSaldoS.Location = New System.Drawing.Point(528, 48)
        Me.txtSaldoS.Name = "txtSaldoS"
        Me.txtSaldoS.NonAutoSizeHeight = 20
        Me.txtSaldoS.NullText = "1.00"
        Me.txtSaldoS.Size = New System.Drawing.Size(70, 20)
        Me.txtSaldoS.TabIndex = 11
        Me.txtSaldoS.Text = "0.00"
        Me.txtSaldoS.Visible = False
        '
        'txtGlosaS
        '
        Me.txtGlosaS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosaS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosaS.Location = New System.Drawing.Point(74, 72)
        Me.txtGlosaS.MaxLength = 500
        Me.txtGlosaS.Multiline = True
        Me.txtGlosaS.Name = "txtGlosaS"
        Me.txtGlosaS.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosaS.Size = New System.Drawing.Size(590, 21)
        Me.txtGlosaS.TabIndex = 7
        '
        'lblMontoAmortizadoS
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Appearance124.TextVAlignAsString = "Middle"
        Me.lblMontoAmortizadoS.Appearance = Appearance124
        Me.lblMontoAmortizadoS.AutoSize = True
        Me.lblMontoAmortizadoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoAmortizadoS.Location = New System.Drawing.Point(426, 51)
        Me.lblMontoAmortizadoS.Name = "lblMontoAmortizadoS"
        Me.lblMontoAmortizadoS.Size = New System.Drawing.Size(99, 14)
        Me.lblMontoAmortizadoS.TabIndex = 10
        Me.lblMontoAmortizadoS.Text = "Monto Amortizado:"
        Me.lblMontoAmortizadoS.Visible = False
        '
        'UltraLabel27
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Appearance125.TextVAlignAsString = "Middle"
        Me.UltraLabel27.Appearance = Appearance125
        Me.UltraLabel27.AutoSize = True
        Me.UltraLabel27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel27.Location = New System.Drawing.Point(21, 28)
        Me.UltraLabel27.Name = "UltraLabel27"
        Me.UltraLabel27.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel27.TabIndex = 0
        Me.UltraLabel27.Text = "Fecha:"
        '
        'cboTipoPagoS
        '
        Appearance126.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPagoS.Appearance = Appearance126
        Me.cboTipoPagoS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoPagoS.DisplayMember = ""
        Me.cboTipoPagoS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPagoS.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPagoS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPagoS.ForeColor = System.Drawing.Color.Black
        ValueListItem4.DataValue = "ValueListItem0"
        ValueListItem4.DisplayText = "CONTADO"
        ValueListItem5.DataValue = "ValueListItem2"
        ValueListItem5.DisplayText = "CREDITO"
        ValueListItem6.DataValue = "ValueListItem1"
        ValueListItem6.DisplayText = "AMORTIZADO"
        ValueListItem7.DataValue = "ValueListItem3"
        ValueListItem7.DisplayText = "AL GASTO"
        Me.cboTipoPagoS.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7})
        Me.cboTipoPagoS.Location = New System.Drawing.Point(528, 24)
        Me.cboTipoPagoS.Name = "cboTipoPagoS"
        Me.cboTipoPagoS.Size = New System.Drawing.Size(136, 21)
        Me.cboTipoPagoS.TabIndex = 9
        Me.cboTipoPagoS.ValueMember = "Id"
        '
        'UltraLabel16
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Appearance127.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance127
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(451, 28)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(74, 14)
        Me.UltraLabel16.TabIndex = 8
        Me.UltraLabel16.Text = "Tipo de Pago:"
        '
        'cboPersonaS
        '
        Appearance128.ForeColor = System.Drawing.Color.Black
        Me.cboPersonaS.Appearance = Appearance128
        Me.cboPersonaS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPersonaS.DisplayMember = "Nombre"
        Me.cboPersonaS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPersonaS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonaS.ForeColor = System.Drawing.Color.Black
        Me.cboPersonaS.ImageList = Me.imagenes
        Me.cboPersonaS.Location = New System.Drawing.Point(74, 48)
        Me.cboPersonaS.Name = "cboPersonaS"
        Me.cboPersonaS.Size = New System.Drawing.Size(340, 21)
        Me.cboPersonaS.TabIndex = 5
        Me.cboPersonaS.ValueMember = "Id"
        '
        'UltraLabel26
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance129
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(8, 52)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel26.TabIndex = 4
        Me.UltraLabel26.Text = "Trabajador:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1157, 497)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.ficListar)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 90)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1157, 407)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficListar
        '
        Appearance130.BackColor = System.Drawing.Color.White
        Appearance130.BackColor2 = System.Drawing.Color.White
        Me.ficListar.ClientAreaAppearance = Appearance130
        Me.ficListar.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficListar.Controls.Add(Me.UltraTabPageControl3)
        Me.ficListar.Controls.Add(Me.UltraTabPageControl4)
        Me.ficListar.Controls.Add(Me.UltraTabPageControl5)
        Me.ficListar.Controls.Add(Me.UltraTabPageControl6)
        Me.ficListar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficListar.Location = New System.Drawing.Point(3, 17)
        Me.ficListar.Name = "ficListar"
        Me.ficListar.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficListar.Size = New System.Drawing.Size(1151, 387)
        Me.ficListar.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Ingreso"
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Salida"
        UltraTab3.TabPage = Me.UltraTabPageControl5
        UltraTab3.Text = "Almacen Mermas"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Tesoreria"
        Me.ficListar.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab6})
        Me.ficListar.TabStop = False
        Me.ficListar.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1149, 364)
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.cboCentroL)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel22)
        Me.agrBusqueda.Controls.Add(Me.Agrupacion8)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta45)
        Me.agrBusqueda.Controls.Add(Me.UltraGroupBox13)
        Me.agrBusqueda.Controls.Add(Me.ColorAltualizar)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1157, 90)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCentroL
        '
        Appearance131.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Appearance = Appearance131
        Me.cboCentroL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Location = New System.Drawing.Point(590, 33)
        Me.cboCentroL.Name = "cboCentroL"
        Me.cboCentroL.Size = New System.Drawing.Size(117, 21)
        Me.cboCentroL.TabIndex = 5
        Me.cboCentroL.ValueMember = "Id"
        '
        'UltraLabel22
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Appearance132.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance132
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(543, 37)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel22.TabIndex = 4
        Me.UltraLabel22.Text = "Centro:"
        '
        'Agrupacion8
        '
        Appearance133.BackColor = System.Drawing.Color.White
        Appearance133.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion8.ContentAreaAppearance = Appearance133
        Me.Agrupacion8.Controls.Add(Me.colorAlGasto)
        Me.Agrupacion8.Controls.Add(Me.ColorAmortizado)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion8.Controls.Add(Me.etiAsignada)
        Me.Agrupacion8.Controls.Add(Me.colorCobrado)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion8.Controls.Add(Me.etiCancelada)
        Me.Agrupacion8.Controls.Add(Me.colorCredito)
        Me.Agrupacion8.Controls.Add(Me.colorPorCobrar)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion8.Controls.Add(Me.colorContado)
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(161, 22)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(358, 61)
        Me.Agrupacion8.TabIndex = 1
        Me.Agrupacion8.Text = "Estado"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorAlGasto
        '
        Me.colorAlGasto.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colorAlGasto.Location = New System.Drawing.Point(299, 36)
        Me.colorAlGasto.Name = "colorAlGasto"
        Me.colorAlGasto.Size = New System.Drawing.Size(43, 21)
        Me.colorAlGasto.TabIndex = 11
        Me.colorAlGasto.Text = "192, 192, 255"
        '
        'ColorAmortizado
        '
        Me.ColorAmortizado.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ColorAmortizado.Location = New System.Drawing.Point(299, 13)
        Me.ColorAmortizado.Name = "ColorAmortizado"
        Me.ColorAmortizado.Size = New System.Drawing.Size(43, 21)
        Me.ColorAmortizado.TabIndex = 5
        Me.ColorAmortizado.Text = "255, 255, 192"
        '
        'Etiqueta3
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance134
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(246, 40)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta3.TabIndex = 10
        Me.Etiqueta3.Text = "Al Gasto:"
        '
        'etiAsignada
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Me.etiAsignada.Appearance = Appearance135
        Me.etiAsignada.AutoSize = True
        Me.etiAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAsignada.ForeColor = System.Drawing.Color.Black
        Me.etiAsignada.Location = New System.Drawing.Point(28, 17)
        Me.etiAsignada.Name = "etiAsignada"
        Me.etiAsignada.Size = New System.Drawing.Size(49, 14)
        Me.etiAsignada.TabIndex = 0
        Me.etiAsignada.Text = "Cobrado:"
        '
        'colorCobrado
        '
        Me.colorCobrado.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colorCobrado.Location = New System.Drawing.Point(81, 13)
        Me.colorCobrado.Name = "colorCobrado"
        Me.colorCobrado.Size = New System.Drawing.Size(43, 21)
        Me.colorCobrado.TabIndex = 1
        Me.colorCobrado.Text = "255, 192, 192"
        '
        'Etiqueta4
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance136
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(232, 17)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta4.TabIndex = 4
        Me.Etiqueta4.Text = "Amortizado:"
        '
        'etiCancelada
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.etiCancelada.Appearance = Appearance137
        Me.etiCancelada.AutoSize = True
        Me.etiCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCancelada.ForeColor = System.Drawing.Color.Black
        Me.etiCancelada.Location = New System.Drawing.Point(16, 40)
        Me.etiCancelada.Name = "etiCancelada"
        Me.etiCancelada.Size = New System.Drawing.Size(61, 14)
        Me.etiCancelada.TabIndex = 6
        Me.etiCancelada.Text = "Por Cobrar:"
        '
        'colorCredito
        '
        Me.colorCredito.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colorCredito.Location = New System.Drawing.Point(183, 36)
        Me.colorCredito.Name = "colorCredito"
        Me.colorCredito.Size = New System.Drawing.Size(43, 21)
        Me.colorCredito.TabIndex = 9
        Me.colorCredito.Text = "192, 255, 255"
        '
        'colorPorCobrar
        '
        Me.colorPorCobrar.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colorPorCobrar.Location = New System.Drawing.Point(81, 36)
        Me.colorPorCobrar.Name = "colorPorCobrar"
        Me.colorPorCobrar.Size = New System.Drawing.Size(43, 21)
        Me.colorPorCobrar.TabIndex = 7
        Me.colorPorCobrar.Text = "192, 255, 192"
        '
        'Etiqueta1
        '
        Appearance138.BackColor = System.Drawing.Color.Transparent
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance138
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(136, 40)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta1.TabIndex = 8
        Me.Etiqueta1.Text = "Credito:"
        '
        'Etiqueta2
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance139
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(130, 17)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Contado:"
        '
        'colorContado
        '
        Me.colorContado.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colorContado.Location = New System.Drawing.Point(183, 13)
        Me.colorContado.Name = "colorContado"
        Me.colorContado.Size = New System.Drawing.Size(43, 21)
        Me.colorContado.TabIndex = 3
        Me.colorContado.Text = "255, 224, 192"
        '
        'Etiqueta45
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance140
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(523, 62)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta45.TabIndex = 2
        Me.Etiqueta45.Text = "Actualizado:"
        '
        'UltraGroupBox13
        '
        Appearance141.BackColor = System.Drawing.Color.White
        Appearance141.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox13.ContentAreaAppearance = Appearance141
        Me.UltraGroupBox13.Controls.Add(Me.fecHasta)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel21)
        Me.UltraGroupBox13.Controls.Add(Me.fecDesde)
        Me.UltraGroupBox13.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(5, 23)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(150, 60)
        Me.UltraGroupBox13.TabIndex = 0
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2015, 4, 21, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 32)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 22)
        Me.fecHasta.TabIndex = 3
        Me.fecHasta.Value = New Date(2015, 4, 21, 0, 0, 0, 0)
        '
        'UltraLabel21
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Appearance142.TextVAlignAsString = "Middle"
        Me.UltraLabel21.Appearance = Appearance142
        Me.UltraLabel21.AutoSize = True
        Me.UltraLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel21.Location = New System.Drawing.Point(10, 36)
        Me.UltraLabel21.Name = "UltraLabel21"
        Me.UltraLabel21.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel21.TabIndex = 2
        Me.UltraLabel21.Text = "Hasta:"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2015, 4, 21, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 9)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 22)
        Me.fecDesde.TabIndex = 1
        Me.fecDesde.Value = New Date(2015, 4, 21, 0, 0, 0, 0)
        '
        'UltraLabel23
        '
        Appearance143.BackColor = System.Drawing.Color.Transparent
        Appearance143.ForeColor = System.Drawing.Color.Navy
        Appearance143.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance143
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(7, 13)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel23.TabIndex = 0
        Me.UltraLabel23.Text = "Desde:"
        '
        'ColorAltualizar
        '
        Me.ColorAltualizar.Color = System.Drawing.Color.Aqua
        Me.ColorAltualizar.Location = New System.Drawing.Point(590, 60)
        Me.ColorAltualizar.Name = "ColorAltualizar"
        Me.ColorAltualizar.Size = New System.Drawing.Size(44, 22)
        Me.ColorAltualizar.TabIndex = 3
        Me.ColorAltualizar.Text = "Aqua"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.ficIngresoSalida)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1157, 497)
        '
        'ficIngresoSalida
        '
        Appearance144.BackColor = System.Drawing.Color.White
        Appearance144.BackColor2 = System.Drawing.Color.White
        Me.ficIngresoSalida.ClientAreaAppearance = Appearance144
        Me.ficIngresoSalida.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficIngresoSalida.Controls.Add(Me.UltraTabPageControl1)
        Me.ficIngresoSalida.Controls.Add(Me.UltraTabPageControl2)
        Me.ficIngresoSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficIngresoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficIngresoSalida.Location = New System.Drawing.Point(0, 0)
        Me.ficIngresoSalida.Name = "ficIngresoSalida"
        Me.ficIngresoSalida.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficIngresoSalida.Size = New System.Drawing.Size(1157, 497)
        Me.ficIngresoSalida.TabIndex = 0
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Ingreso"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Salida"
        Me.ficIngresoSalida.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.ficIngresoSalida.TabStop = False
        Me.ficIngresoSalida.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1155, 474)
        '
        'utp1
        '
        Me.utp1.ContainingControl = Me
        Me.utp1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.utp1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.utp1.ToolTipTitle = "Mensaje del Sistema"
        '
        'UltraMaskedEdit5
        '
        Appearance145.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit5.Appearance = Appearance145
        Me.UltraMaskedEdit5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit5.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.UltraMaskedEdit5.InputMask = "nnnnnnnnnn"
        Me.UltraMaskedEdit5.Location = New System.Drawing.Point(103, 22)
        Me.UltraMaskedEdit5.Name = "UltraMaskedEdit5"
        Me.UltraMaskedEdit5.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit5.NullText = ""
        Me.UltraMaskedEdit5.Size = New System.Drawing.Size(70, 20)
        Me.UltraMaskedEdit5.TabIndex = 6
        UltraToolTipInfo1.ToolTipText = "Numero de GRT"
        Me.utp1.SetUltraToolTip(Me.UltraMaskedEdit5, UltraToolTipInfo1)
        '
        'UltraMaskedEdit6
        '
        Appearance146.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit6.Appearance = Appearance146
        Me.UltraMaskedEdit6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit6.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.UltraMaskedEdit6.InputMask = "nnnn"
        Me.UltraMaskedEdit6.Location = New System.Drawing.Point(62, 22)
        Me.UltraMaskedEdit6.Name = "UltraMaskedEdit6"
        Me.UltraMaskedEdit6.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit6.NullText = ""
        Me.UltraMaskedEdit6.Size = New System.Drawing.Size(35, 20)
        Me.UltraMaskedEdit6.TabIndex = 4
        UltraToolTipInfo2.ToolTipText = "Serie de GRT"
        Me.utp1.SetUltraToolTip(Me.UltraMaskedEdit6, UltraToolTipInfo2)
        '
        'ficCtrlMerma
        '
        Me.ficCtrlMerma.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficCtrlMerma.Controls.Add(Me.UltraTabPageControl7)
        Me.ficCtrlMerma.Controls.Add(Me.utpDetalle)
        Me.ficCtrlMerma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCtrlMerma.Location = New System.Drawing.Point(0, 0)
        Me.ficCtrlMerma.Name = "ficCtrlMerma"
        Me.ficCtrlMerma.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficCtrlMerma.Size = New System.Drawing.Size(1159, 520)
        Me.ficCtrlMerma.TabIndex = 0
        UltraTab8.Key = "Lista"
        UltraTab8.TabPage = Me.UltraTabPageControl7
        UltraTab8.Text = "Lista"
        UltraTab9.Key = "Mantenimiento"
        UltraTab9.TabPage = Me.utpDetalle
        UltraTab9.Text = "Mantenimiento"
        Me.ficCtrlMerma.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab8, UltraTab9})
        Me.ficCtrlMerma.TabStop = False
        Me.ficCtrlMerma.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1157, 497)
        '
        'UltraLabel12
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Appearance147.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance147
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(306, 26)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel12.TabIndex = 302
        Me.UltraLabel12.Text = "Unidad:"
        '
        'Combo4
        '
        Appearance148.ForeColor = System.Drawing.Color.Black
        Me.Combo4.Appearance = Appearance148
        Me.Combo4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.Combo4.DisplayMember = ""
        Me.Combo4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Combo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo4.ForeColor = System.Drawing.Color.Black
        ValueListItem19.DataValue = "ValueListItem2"
        ValueListItem19.DisplayText = "Bolsa"
        ValueListItem20.DataValue = "ValueListItem1"
        ValueListItem20.DisplayText = "Caja"
        ValueListItem21.DataValue = "ValueListItem0"
        ValueListItem21.DisplayText = "Unidad"
        Me.Combo4.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem19, ValueListItem20, ValueListItem21})
        Me.Combo4.Location = New System.Drawing.Point(352, 22)
        Me.Combo4.Name = "Combo4"
        Me.Combo4.Size = New System.Drawing.Size(89, 21)
        Me.Combo4.TabIndex = 301
        Me.Combo4.ValueMember = "Id"
        '
        'UltraMaskedEdit4
        '
        Appearance149.TextHAlignAsString = "Right"
        Me.UltraMaskedEdit4.Appearance = Appearance149
        Me.UltraMaskedEdit4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraMaskedEdit4.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.UltraMaskedEdit4.InputMask = "{LOC}nnn.nn"
        Me.UltraMaskedEdit4.Location = New System.Drawing.Point(236, 22)
        Me.UltraMaskedEdit4.Name = "UltraMaskedEdit4"
        Me.UltraMaskedEdit4.NonAutoSizeHeight = 20
        Me.UltraMaskedEdit4.NullText = "1.00"
        Me.UltraMaskedEdit4.Size = New System.Drawing.Size(50, 20)
        Me.UltraMaskedEdit4.TabIndex = 300
        Me.UltraMaskedEdit4.Text = "1.00"
        '
        'UltraLabel13
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Appearance150.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance150
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(194, 25)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel13.TabIndex = 299
        Me.UltraLabel13.Text = "Precio:"
        '
        'UltraLabel14
        '
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Appearance151.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance151
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(12, 25)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel14.TabIndex = 298
        Me.UltraLabel14.Text = "Numero:"
        '
        'UltraLabel15
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Appearance152.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance152
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(96, 26)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(8, 14)
        Me.UltraLabel15.TabIndex = 5
        Me.UltraLabel15.Text = "-"
        '
        'btnBuscarMaterial
        '
        Appearance153.Image = "266.png"
        Appearance153.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance153.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnBuscarMaterial.Appearance = Appearance153
        Me.btnBuscarMaterial.ImageList = Me.imagenes
        Me.btnBuscarMaterial.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnBuscarMaterial.Location = New System.Drawing.Point(219, 3)
        Me.btnBuscarMaterial.Name = "btnBuscarMaterial"
        Me.btnBuscarMaterial.Size = New System.Drawing.Size(45, 30)
        Me.btnBuscarMaterial.TabIndex = 307
        Me.btnBuscarMaterial.TabStop = False
        '
        'UltraLabel24
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Appearance154.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance154
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(2, 13)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel24.TabIndex = 306
        Me.UltraLabel24.Text = "Material:"
        '
        'txtMateriales
        '
        Appearance155.TextHAlignAsString = "Left"
        Me.txtMateriales.Appearance = Appearance155
        Me.txtMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMateriales.Location = New System.Drawing.Point(56, 9)
        Me.txtMateriales.MaxLength = 10
        Me.txtMateriales.Name = "txtMateriales"
        Me.txtMateriales.Size = New System.Drawing.Size(157, 21)
        Me.txtMateriales.TabIndex = 308
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.txtMateriales)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.btnBuscarMaterial)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraLabel24)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(991, 37)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(382, 228)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_ControlMermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 520)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficCtrlMerma)
        Me.Name = "frm_ControlMermas"
        Me.Text = "Control Mermas"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griListaIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdIngSal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griListaSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griAlmacenMermas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAlmMer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTesoreria.ResumeLayout(False)
        CType(Me.ogdMovMer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griDetalleMermasI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuQuitDetI.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cboMaterialI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdViajeI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.txtNumeroI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboUnidadI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroViajeI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uebAlmacenMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uebAlmacenMermas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griAlmacenMermasI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expViaje.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.verTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTractoLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtIdMovimientoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        CType(Me.griDetalleMermasS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuQuitDetS.ResumeLayout(False)
        CType(Me.griAlmacenMermasS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.txtTotalS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuentoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubTotalS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSancion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdMovimientoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosaS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPagoS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPersonaS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaRegistro.ResumeLayout(False)
        CType(Me.ficListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficListar.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.colorAlGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAmortizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorPorCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorContado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        Me.UltraGroupBox13.PerformLayout()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAltualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.ficIngresoSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficIngresoSalida.ResumeLayout(False)
        CType(Me.ficCtrlMerma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCtrlMerma.ResumeLayout(False)
        CType(Me.Combo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents utp1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ficCtrlMerma As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents etiCancelada As ISL.Controles.Etiqueta
    Friend WithEvents colorCobrado As ISL.Controles.Colores
    Friend WithEvents etiAsignada As ISL.Controles.Etiqueta
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Combo4 As ISL.Controles.Combo
    Friend WithEvents UltraMaskedEdit4 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraMaskedEdit5 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraMaskedEdit6 As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ogdIngSal As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficListar As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents colorPorCobrar As ISL.Controles.Colores
    Friend WithEvents ficIngresoSalida As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleMermasI As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btnAgregarI As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboClienteI As ISL.Controles.ComboMaestros
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents txtNumeroI As ISL.Controles.Texto
    Friend WithEvents txtPrecioFacturaI As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSerieI As ISL.Controles.Texto
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UnidadMedida As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboUnidadI As ISL.Controles.Combo
    Friend WithEvents txtNroViajeI As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoI As ISL.Controles.Combo
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtFactorCovI As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCantidadI As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMaterialI As ISL.Controles.ComboMaestros
    Friend WithEvents expViaje As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griViajes As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents verTracto As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents cboTractoLista As ISL.Controles.Combo
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Public WithEvents btnListarViajes As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents fecFechaI As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtGlosaI As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents txtSaldoS As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblMontoAmortizadoS As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTipoPagoS As ISL.Controles.Combo
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboPersonaS As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel27 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosaS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Private WithEvents btnBuscarMaterial As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtMateriales As ISL.Controles.Texto
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel18 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel29 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPorcentajeDescuentoS As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents lblPorcentajeDescuentoS As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnListaMermasS As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ogdViajes As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMovimiento As ISL.Controles.Grilla
    Friend WithEvents ogdMovMer As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdAlmMer As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtIdMovimientoI As ISL.Controles.Texto
    Friend WithEvents txtIdMovimientoS As ISL.Controles.Texto
    Friend WithEvents txtIdViajeI As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnListaMermasI As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtPrecioAlmacenI As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtTotalI As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel20 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griDetalleMermasS As ISL.Controles.Grilla
    Friend WithEvents griAlmacenMermasS As ISL.Controles.Grilla
    Friend WithEvents griAlmacenMermas As ISL.Controles.Grilla
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAltualizar As ISL.Controles.Colores
    Friend WithEvents griListaIngresos As ISL.Controles.Grilla
    Friend WithEvents griListaSalidas As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel21 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents MenuTesoreria As ISL.Controles.MenuContextual
    Friend WithEvents Cobrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerVenta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorAlGasto As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAmortizado As ISL.Controles.Colores
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents colorCredito As ISL.Controles.Colores
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents colorContado As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtIdSancion As ISL.Controles.Texto
    Friend WithEvents fecHastaViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesdeViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents uebAlmacenMermas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griAlmacenMermasI As ISL.Controles.Grilla
    Friend WithEvents fecFechaS As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboCentroL As ISL.Controles.Combo
    Friend WithEvents txtTotalS As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtDescuentoS As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtSubTotalS As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents mnuQuitDetS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuitDetI As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
