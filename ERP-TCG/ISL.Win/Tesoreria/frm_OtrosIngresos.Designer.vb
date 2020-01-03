<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OtrosIngresos
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
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaBancaria")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConceptoIngresos")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaBancaria")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Concepto")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdReferencia")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorriente")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndIngresoEgreso")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCerrado")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCierre")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaBancaria")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConceptoIngresos")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaBancaria")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Concepto")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdReferencia")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorriente")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndIngresoEgreso")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCerrado")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCierre")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Centro")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOrden")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenOrigen")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacenDestino")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoInventario")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MovimientoInventario")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoReferencia")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoOrden")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoOrden")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreUsuario")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenDocumento")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDocumento")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieNumero")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenOrigen")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubAlmacenDestino")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioEjecucion")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioEjecucion")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOrden")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenOrigen")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacenDestino")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoInventario")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MovimientoInventario")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoReferencia")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstadoOrden")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EstadoOrden")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreProveedor")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreUsuario")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenDocumento")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDocumento")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieNumero")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenOrigen")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubAlmacenDestino")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUsuarioEjecucion")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioEjecucion")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griOtrosIngresos = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EgresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odOtrosIngresos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEgresos = New ISL.Controles.Boton(Me.components)
        Me.btnIngresos = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboCentroL = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.verBuscarFecha = New ISL.Controles.Chequear(Me.components)
        Me.agrBuscarFecha = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.uebOrdenSalida = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridListaOrden = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrden = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnBuscarOrdenes = New ISL.Controles.Boton(Me.components)
        Me.txtNIngreso = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDifDepositada = New ISL.Controles.Etiqueta(Me.components)
        Me.decDifDepositada = New ISL.Controles.NumeroDecimal(Me.components)
        Me.DecTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.TxtVoucher = New System.Windows.Forms.TextBox()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.rdbEgresos = New System.Windows.Forms.RadioButton()
        Me.rdbIngresos = New System.Windows.Forms.RadioButton()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConcepto = New ISL.Controles.Combo(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.ficOtrosIngresos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griOtrosIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odOtrosIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBuscarFecha.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.uebOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uebOrdenSalida.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.gridListaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtNIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decDifDepositada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOtrosIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOtrosIngresos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl7.Controls.Add(Me.agrMenuLista)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1063, 354)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griOtrosIngresos)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 106)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1063, 248)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOtrosIngresos
        '
        Me.griOtrosIngresos.ContextMenuStrip = Me.MenuContextual1
        Me.griOtrosIngresos.DataSource = Me.odOtrosIngresos
        UltraGridColumn89.Header.VisiblePosition = 0
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 1
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 2
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.Caption = "CuentaBancaria/Trabajador"
        UltraGridColumn92.Header.VisiblePosition = 3
        UltraGridColumn92.Width = 339
        UltraGridColumn93.Header.VisiblePosition = 13
        UltraGridColumn93.Width = 151
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn94.CellAppearance = Appearance1
        UltraGridColumn94.Format = "#,###,###,##0.00"
        UltraGridColumn94.Header.VisiblePosition = 10
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn94.Width = 108
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn95.CellAppearance = Appearance2
        UltraGridColumn95.Format = "#,###,###,##0.00"
        UltraGridColumn95.Header.VisiblePosition = 12
        UltraGridColumn95.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn95.Width = 91
        UltraGridColumn96.Header.VisiblePosition = 21
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 5
        UltraGridColumn97.Width = 333
        UltraGridColumn98.Header.VisiblePosition = 19
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 7
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 8
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 9
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 16
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Format = "#,###,###,##0.00"
        UltraGridColumn103.Header.VisiblePosition = 6
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 11
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 14
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 15
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 17
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 18
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 20
        UltraGridColumn109.Width = 121
        UltraGridColumn110.Header.VisiblePosition = 4
        UltraGridColumn110.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn110.Width = 137
        UltraGridColumn111.Header.VisiblePosition = 22
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 23
        UltraGridColumn112.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112})
        Me.griOtrosIngresos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griOtrosIngresos.DisplayLayout.MaxColScrollRegions = 1
        Me.griOtrosIngresos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOtrosIngresos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOtrosIngresos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOtrosIngresos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOtrosIngresos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOtrosIngresos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOtrosIngresos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOtrosIngresos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOtrosIngresos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOtrosIngresos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOtrosIngresos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOtrosIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOtrosIngresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOtrosIngresos.Location = New System.Drawing.Point(3, 3)
        Me.griOtrosIngresos.Name = "griOtrosIngresos"
        Me.griOtrosIngresos.Size = New System.Drawing.Size(1057, 242)
        Me.griOtrosIngresos.TabIndex = 0
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.EgresosToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(115, 48)
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.IngresosToolStripMenuItem.Text = "Ingresos"
        '
        'EgresosToolStripMenuItem
        '
        Me.EgresosToolStripMenuItem.Enabled = False
        Me.EgresosToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.EgresosToolStripMenuItem.Name = "EgresosToolStripMenuItem"
        Me.EgresosToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.EgresosToolStripMenuItem.Text = "Egresos"
        '
        'odOtrosIngresos
        '
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Date)
        Me.odOtrosIngresos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEgresos)
        Me.agrMenuLista.Controls.Add(Me.btnIngresos)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(0, 76)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1063, 30)
        Me.agrMenuLista.TabIndex = 1
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEgresos
        '
        Appearance3.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance3.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.btnEgresos.Appearance = Appearance3
        Me.btnEgresos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEgresos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEgresos.Enabled = False
        Me.btnEgresos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgresos.ForeColor = System.Drawing.Color.Black
        Me.btnEgresos.Location = New System.Drawing.Point(75, 3)
        Me.btnEgresos.Name = "btnEgresos"
        Me.btnEgresos.Size = New System.Drawing.Size(72, 24)
        Me.btnEgresos.TabIndex = 1
        Me.btnEgresos.Text = "Egresos"
        Me.btnEgresos.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnIngresos
        '
        Appearance4.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance4.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.btnIngresos.Appearance = Appearance4
        Me.btnIngresos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIngresos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIngresos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresos.ForeColor = System.Drawing.Color.Black
        Me.btnIngresos.Location = New System.Drawing.Point(3, 3)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(72, 24)
        Me.btnIngresos.TabIndex = 0
        Me.btnIngresos.Text = "Ingresos"
        Me.btnIngresos.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.cboCentroL)
        Me.Agrupacion1.Controls.Add(Me.etiCentro)
        Me.Agrupacion1.Controls.Add(Me.decSaldo)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.verBuscarFecha)
        Me.Agrupacion1.Controls.Add(Me.agrBuscarFecha)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1063, 76)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Datos"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCentroL
        '
        Appearance5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Appearance = Appearance5
        Me.cboCentroL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Location = New System.Drawing.Point(366, 35)
        Me.cboCentroL.Name = "cboCentroL"
        Me.cboCentroL.Size = New System.Drawing.Size(144, 21)
        Me.cboCentroL.TabIndex = 3
        Me.cboCentroL.ValueMember = "Id"
        '
        'etiCentro
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.etiCentro.Appearance = Appearance6
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentro.ForeColor = System.Drawing.Color.Black
        Me.etiCentro.Location = New System.Drawing.Point(320, 38)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(40, 14)
        Me.etiCentro.TabIndex = 2
        Me.etiCentro.Text = "Centro:"
        '
        'decSaldo
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Appearance = Appearance7
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.Black
        Me.decSaldo.Location = New System.Drawing.Point(564, 34)
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.Size = New System.Drawing.Size(90, 21)
        Me.decSaldo.TabIndex = 5
        '
        'Etiqueta5
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance8
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(523, 38)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta5.TabIndex = 4
        Me.Etiqueta5.Text = "Saldo:"
        '
        'verBuscarFecha
        '
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.verBuscarFecha.Appearance = Appearance9
        Me.verBuscarFecha.BackColor = System.Drawing.Color.Transparent
        Me.verBuscarFecha.BackColorInternal = System.Drawing.Color.Transparent
        Me.verBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.verBuscarFecha.Location = New System.Drawing.Point(3, 19)
        Me.verBuscarFecha.Name = "verBuscarFecha"
        Me.verBuscarFecha.Size = New System.Drawing.Size(55, 20)
        Me.verBuscarFecha.TabIndex = 0
        Me.verBuscarFecha.Text = "Fecha:"
        '
        'agrBuscarFecha
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Me.agrBuscarFecha.Appearance = Appearance10
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta6)
        Me.agrBuscarFecha.Controls.Add(Me.fecHasta)
        Me.agrBuscarFecha.Controls.Add(Me.Etiqueta50)
        Me.agrBuscarFecha.Controls.Add(Me.fecDesde)
        Me.agrBuscarFecha.Enabled = False
        Me.agrBuscarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBuscarFecha.ForeColor = System.Drawing.Color.Black
        Me.agrBuscarFecha.Location = New System.Drawing.Point(12, 28)
        Me.agrBuscarFecha.Name = "agrBuscarFecha"
        Me.agrBuscarFecha.Size = New System.Drawing.Size(302, 40)
        Me.agrBuscarFecha.TabIndex = 1
        Me.agrBuscarFecha.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2000
        '
        'Etiqueta6
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance11
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(154, 13)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Hasta:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(196, 11)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(97, 20)
        Me.fecHasta.TabIndex = 3
        '
        'Etiqueta50
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance12
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(7, 13)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta50.TabIndex = 0
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(52, 11)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(96, 20)
        Me.fecDesde.TabIndex = 1
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Enabled = False
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1063, 354)
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.uebOrdenSalida)
        Me.agrProcesoNegocio.Controls.Add(Me.etiDifDepositada)
        Me.agrProcesoNegocio.Controls.Add(Me.decDifDepositada)
        Me.agrProcesoNegocio.Controls.Add(Me.DecTC)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta8)
        Me.agrProcesoNegocio.Controls.Add(Me.TxtVoucher)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta7)
        Me.agrProcesoNegocio.Controls.Add(Me.dtpFecha)
        Me.agrProcesoNegocio.Controls.Add(Me.rdbEgresos)
        Me.agrProcesoNegocio.Controls.Add(Me.rdbIngresos)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta4)
        Me.agrProcesoNegocio.Controls.Add(Me.cboCuentaBancaria)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta11)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta9)
        Me.agrProcesoNegocio.Controls.Add(Me.cboConcepto)
        Me.agrProcesoNegocio.Controls.Add(Me.txtGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.txtImporte)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1063, 260)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'uebOrdenSalida
        '
        Me.uebOrdenSalida.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.uebOrdenSalida.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.uebOrdenSalida.Dock = System.Windows.Forms.DockStyle.Right
        Me.uebOrdenSalida.Expanded = False
        Me.uebOrdenSalida.ExpandedSize = New System.Drawing.Size(557, 254)
        Me.uebOrdenSalida.ForeColor = System.Drawing.Color.Navy
        Me.uebOrdenSalida.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.uebOrdenSalida.Location = New System.Drawing.Point(1038, 3)
        Me.uebOrdenSalida.Name = "uebOrdenSalida"
        Me.uebOrdenSalida.Size = New System.Drawing.Size(22, 254)
        Me.uebOrdenSalida.TabIndex = 21
        Me.uebOrdenSalida.Text = "Orden Salida"
        Me.uebOrdenSalida.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.uebOrdenSalida.Visible = False
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion3)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(534, 248)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.gridListaOrden)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 53)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(534, 195)
        Me.Agrupacion4.TabIndex = 1
        Me.Agrupacion4.Text = "Lista"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridListaOrden
        '
        Me.gridListaOrden.ContextMenuStrip = Me.MenuContextual1
        Me.gridListaOrden.DataSource = Me.odOrden
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.Caption = "N° Orden"
        UltraGridColumn26.Header.VisiblePosition = 1
        UltraGridColumn26.Width = 118
        UltraGridColumn27.Header.VisiblePosition = 4
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 5
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.Caption = "Fecha"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn29.Width = 147
        UltraGridColumn30.Header.VisiblePosition = 8
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 9
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 10
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 11
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.Caption = "Movimiento Inventario"
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Width = 183
        UltraGridColumn35.Header.Caption = "Tipo Referencia"
        UltraGridColumn35.Header.VisiblePosition = 12
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.Width = 188
        UltraGridColumn36.Header.VisiblePosition = 13
        UltraGridColumn36.Hidden = True
        UltraGridColumn69.Header.Caption = "IdUsuario"
        UltraGridColumn69.Header.VisiblePosition = 16
        UltraGridColumn69.Hidden = True
        UltraGridColumn69.Width = 247
        UltraGridColumn70.Header.VisiblePosition = 20
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 17
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 18
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 19
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.Caption = "Tipo Orden"
        UltraGridColumn74.Header.VisiblePosition = 7
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.Width = 212
        UltraGridColumn75.Header.VisiblePosition = 6
        UltraGridColumn75.Width = 70
        UltraGridColumn76.Header.Caption = "Estado"
        UltraGridColumn76.Header.VisiblePosition = 15
        UltraGridColumn76.Width = 87
        UltraGridColumn77.Header.VisiblePosition = 21
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 22
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.Caption = "Usuario"
        UltraGridColumn79.Header.VisiblePosition = 23
        UltraGridColumn79.Width = 53
        UltraGridColumn80.Header.VisiblePosition = 14
        UltraGridColumn80.Hidden = True
        UltraGridColumn80.Width = 114
        UltraGridColumn81.Header.VisiblePosition = 24
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 25
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 26
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 27
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 28
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 29
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 30
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 31
        UltraGridColumn88.Width = 64
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88})
        Me.gridListaOrden.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.gridListaOrden.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridListaOrden.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridListaOrden.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridListaOrden.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridListaOrden.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridListaOrden.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridListaOrden.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridListaOrden.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.gridListaOrden.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridListaOrden.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridListaOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridListaOrden.Location = New System.Drawing.Point(3, 16)
        Me.gridListaOrden.Name = "gridListaOrden"
        Me.gridListaOrden.Size = New System.Drawing.Size(528, 176)
        Me.gridListaOrden.TabIndex = 0
        '
        'odOrden
        '
        UltraDataColumn29.DataType = GetType(Date)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Boolean)
        Me.odOrden.Band.Columns.AddRange(New Object() {UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.btnBuscarOrdenes)
        Me.Agrupacion3.Controls.Add(Me.txtNIngreso)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(534, 53)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Orden"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnBuscarOrdenes
        '
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Appearance13.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance13.ImageVAlign = Infragistics.Win.VAlign.Middle
        Me.btnBuscarOrdenes.Appearance = Appearance13
        Me.btnBuscarOrdenes.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarOrdenes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarOrdenes.Location = New System.Drawing.Point(204, 20)
        Me.btnBuscarOrdenes.Name = "btnBuscarOrdenes"
        Me.btnBuscarOrdenes.Size = New System.Drawing.Size(29, 27)
        Me.btnBuscarOrdenes.TabIndex = 2
        '
        'txtNIngreso
        '
        Me.txtNIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIngreso.Location = New System.Drawing.Point(66, 24)
        Me.txtNIngreso.MaxLength = 13
        Me.txtNIngreso.Name = "txtNIngreso"
        Me.txtNIngreso.Size = New System.Drawing.Size(132, 21)
        Me.txtNIngreso.TabIndex = 1
        '
        'Etiqueta10
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance14
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(6, 28)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta10.TabIndex = 0
        Me.Etiqueta10.Text = "Nº Orden:"
        '
        'etiDifDepositada
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.etiDifDepositada.Appearance = Appearance15
        Me.etiDifDepositada.AutoSize = True
        Me.etiDifDepositada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDifDepositada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiDifDepositada.Location = New System.Drawing.Point(196, 98)
        Me.etiDifDepositada.Name = "etiDifDepositada"
        Me.etiDifDepositada.Size = New System.Drawing.Size(85, 15)
        Me.etiDifDepositada.TabIndex = 9
        Me.etiDifDepositada.Text = "Dif. Depositada:"
        '
        'decDifDepositada
        '
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decDifDepositada.Appearance = Appearance16
        Me.decDifDepositada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDifDepositada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDifDepositada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decDifDepositada.Location = New System.Drawing.Point(283, 94)
        Me.decDifDepositada.Name = "decDifDepositada"
        Me.decDifDepositada.NullText = "0.00"
        Me.decDifDepositada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDifDepositada.Size = New System.Drawing.Size(86, 21)
        Me.decDifDepositada.TabIndex = 10
        '
        'DecTC
        '
        Appearance17.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Appearance = Appearance17
        Me.DecTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecTC.ForeColor = System.Drawing.Color.Black
        Me.DecTC.Location = New System.Drawing.Point(259, 231)
        Me.DecTC.MaskInput = "{double:6.4}"
        Me.DecTC.Name = "DecTC"
        Me.DecTC.NullText = "0.00"
        Me.DecTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecTC.Size = New System.Drawing.Size(73, 21)
        Me.DecTC.TabIndex = 20
        '
        'Etiqueta8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance18
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(221, 234)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta8.TabIndex = 19
        Me.Etiqueta8.Text = "T.C. :"
        '
        'TxtVoucher
        '
        Me.TxtVoucher.Location = New System.Drawing.Point(91, 203)
        Me.TxtVoucher.Name = "TxtVoucher"
        Me.TxtVoucher.Size = New System.Drawing.Size(100, 20)
        Me.TxtVoucher.TabIndex = 16
        '
        'Etiqueta7
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance19
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(27, 206)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta7.TabIndex = 15
        Me.Etiqueta7.Text = "Operacion:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarForeColor = System.Drawing.Color.Navy
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(91, 229)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(107, 20)
        Me.dtpFecha.TabIndex = 18
        '
        'rdbEgresos
        '
        Me.rdbEgresos.AutoSize = True
        Me.rdbEgresos.BackColor = System.Drawing.Color.Transparent
        Me.rdbEgresos.Enabled = False
        Me.rdbEgresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbEgresos.Location = New System.Drawing.Point(190, 10)
        Me.rdbEgresos.Name = "rdbEgresos"
        Me.rdbEgresos.Size = New System.Drawing.Size(63, 17)
        Me.rdbEgresos.TabIndex = 2
        Me.rdbEgresos.Text = "Egresos"
        Me.rdbEgresos.UseVisualStyleBackColor = False
        '
        'rdbIngresos
        '
        Me.rdbIngresos.AutoSize = True
        Me.rdbIngresos.BackColor = System.Drawing.Color.Transparent
        Me.rdbIngresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIngresos.Location = New System.Drawing.Point(94, 10)
        Me.rdbIngresos.Name = "rdbIngresos"
        Me.rdbIngresos.Size = New System.Drawing.Size(67, 17)
        Me.rdbIngresos.TabIndex = 1
        Me.rdbIngresos.Text = "Ingresos"
        Me.rdbIngresos.UseVisualStyleBackColor = False
        '
        'Etiqueta4
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance20
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(20, 12)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Movimiento:"
        '
        'cboCuentaBancaria
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance21
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(91, 38)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(352, 22)
        Me.cboCuentaBancaria.TabIndex = 4
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance22
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(31, 42)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta11.TabIndex = 3
        Me.Etiqueta11.Text = "Cta Banc:"
        '
        'Etiqueta9
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance23
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(31, 180)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta9.TabIndex = 13
        Me.Etiqueta9.Text = "Concepto:"
        '
        'cboConcepto
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Appearance = Appearance24
        Me.cboConcepto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConcepto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConcepto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConcepto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConcepto.ForeColor = System.Drawing.Color.Black
        Me.cboConcepto.Location = New System.Drawing.Point(91, 176)
        Me.cboConcepto.Name = "cboConcepto"
        Me.cboConcepto.Size = New System.Drawing.Size(352, 22)
        Me.cboConcepto.TabIndex = 14
        Me.cboConcepto.ValueMember = "Id"
        '
        'txtGlosa
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Appearance = Appearance25
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(91, 125)
        Me.txtGlosa.MaxLength = 3000
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(352, 44)
        Me.txtGlosa.TabIndex = 12
        '
        'Etiqueta3
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance26
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(47, 234)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta3.TabIndex = 17
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Etiqueta2
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance27
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(49, 129)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta2.TabIndex = 11
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta1
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance28
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(41, 98)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta1.TabIndex = 7
        Me.Etiqueta1.Text = "Importe:"
        '
        'txtImporte
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Appearance = Appearance29
        Me.txtImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Location = New System.Drawing.Point(91, 94)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullText = "0.00"
        Me.txtImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtImporte.Size = New System.Drawing.Size(86, 21)
        Me.txtImporte.TabIndex = 8
        '
        'etiTrabajador
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.BorderColor = System.Drawing.Color.Transparent
        Me.etiTrabajador.Appearance = Appearance30
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(25, 69)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajador.TabIndex = 5
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboTrabajadores
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance31
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(91, 65)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 22)
        Me.cboTrabajadores.TabIndex = 6
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'ficOtrosIngresos
        '
        Me.ficOtrosIngresos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOtrosIngresos.Controls.Add(Me.UltraTabPageControl7)
        Me.ficOtrosIngresos.Controls.Add(Me.utpDetalle)
        Me.ficOtrosIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOtrosIngresos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficOtrosIngresos.Location = New System.Drawing.Point(0, 0)
        Me.ficOtrosIngresos.Name = "ficOtrosIngresos"
        Me.ficOtrosIngresos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOtrosIngresos.Size = New System.Drawing.Size(1065, 377)
        Me.ficOtrosIngresos.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficOtrosIngresos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficOtrosIngresos.TabStop = False
        Me.ficOtrosIngresos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1063, 354)
        '
        'frm_OtrosIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 377)
        Me.Controls.Add(Me.ficOtrosIngresos)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Name = "frm_OtrosIngresos"
        Me.Text = "Otros Ingresos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griOtrosIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odOtrosIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBuscarFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBuscarFecha.ResumeLayout(False)
        Me.agrBuscarFecha.PerformLayout()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.uebOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uebOrdenSalida.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.gridListaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtNIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decDifDepositada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConcepto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOtrosIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOtrosIngresos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficOtrosIngresos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboConcepto As ISL.Controles.Combo
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griOtrosIngresos As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnEgresos As ISL.Controles.Boton
    Friend WithEvents btnIngresos As ISL.Controles.Boton
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents IngresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EgresosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboCentroL As ISL.Controles.Combo
    Friend WithEvents etiCentro As ISL.Controles.Etiqueta
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents verBuscarFecha As ISL.Controles.Chequear
    Friend WithEvents agrBuscarFecha As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents rdbEgresos As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIngresos As System.Windows.Forms.RadioButton
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents odOtrosIngresos As ISL.Controles.OrigenDatos
    Friend WithEvents TxtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents DecTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents etiTotalCheque As ISL.Controles.Etiqueta
    Friend WithEvents etiDifDepositada As ISL.Controles.Etiqueta
    Friend WithEvents decDifDepositada As ISL.Controles.NumeroDecimal
    Friend WithEvents uebOrdenSalida As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents gridListaOrden As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents odOrden As ISL.Controles.OrigenDatos
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents txtNIngreso As ISL.Controles.Texto
    Friend WithEvents btnBuscarOrdenes As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
End Class
