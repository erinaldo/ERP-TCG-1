<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EstacionServicio
    Inherits frm_MenuPadre

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton4 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_Empresa", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoEmpresa")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoEmpresa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abreviatura")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDireccionTanqueo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgentePercepcion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAgenteRetencion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBuenContribuyente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCanjeDocumento")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaLetras")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAceptaCheque")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Morosidad")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Credito")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndNivelComercial")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndClasificacion")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCategoriaEmpresaSGI")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRelacionada")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DireccionFiscal")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenComercial")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPendiente")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAtender")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoInventario")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndImpuesto")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PDscto")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dscto")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenComercial")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPendiente")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAtender")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoInventario")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndImpuesto")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PDscto")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dscto")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadReal")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.btnG95 = New Infragistics.Win.Misc.UltraButton()
        Me.btnG90 = New Infragistics.Win.Misc.UltraButton()
        Me.btnG84 = New Infragistics.Win.Misc.UltraButton()
        Me.btnDB5 = New Infragistics.Win.Misc.UltraButton()
        Me.ugbHead = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grb_Documento = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbDocumento = New System.Windows.Forms.CheckBox()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmbTipoDocumento = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.dtpFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.txtSerie = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbVehiculo = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.txtDireccionFiscal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cbgCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cbRuc = New System.Windows.Forms.CheckBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grbCombustible = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnAgregarDetalle = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.decDescuento = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decPrecio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.decPrecioTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decCantidad = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnLado6 = New Infragistics.Win.Misc.UltraButton()
        Me.btnLado5 = New Infragistics.Win.Misc.UltraButton()
        Me.btnLado4 = New Infragistics.Win.Misc.UltraButton()
        Me.btnLado3 = New Infragistics.Win.Misc.UltraButton()
        Me.btnLado1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnLado2 = New Infragistics.Win.Misc.UltraButton()
        Me.ugbTipoPago = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnDocumento = New Infragistics.Win.Misc.UltraButton()
        Me.btnVarios = New Infragistics.Win.Misc.UltraButton()
        Me.btnContado = New Infragistics.Win.Misc.UltraButton()
        Me.btnVale = New Infragistics.Win.Misc.UltraButton()
        Me.btnCredito = New Infragistics.Win.Misc.UltraButton()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComMat = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decDescuentoTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decImpuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decSubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        CType(Me.ugbHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbHead.SuspendLayout()
        CType(Me.grb_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Documento.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.grbCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCombustible.SuspendLayout()
        CType(Me.decDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPrecioTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ugbTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbTipoPago.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.udg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.decDescuentoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnG95
        '
        Appearance80.BackColor = System.Drawing.Color.Blue
        Appearance80.BorderColor = System.Drawing.Color.Black
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.btnG95.Appearance = Appearance80
        Me.btnG95.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG95.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG95.Location = New System.Drawing.Point(103, 94)
        Me.btnG95.Name = "btnG95"
        Me.btnG95.Size = New System.Drawing.Size(84, 70)
        Me.btnG95.TabIndex = 3
        Me.btnG95.Text = "G95"
        Me.btnG95.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnG90
        '
        Appearance81.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance81.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Appearance81.FontData.BoldAsString = "False"
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.btnG90.Appearance = Appearance81
        Me.btnG90.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG90.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG90.Location = New System.Drawing.Point(14, 94)
        Me.btnG90.Name = "btnG90"
        Me.btnG90.Size = New System.Drawing.Size(83, 70)
        Me.btnG90.TabIndex = 2
        Me.btnG90.Text = "G90"
        Me.btnG90.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnG84
        '
        Appearance82.BackColor = System.Drawing.Color.Red
        Appearance82.BorderColor = System.Drawing.Color.Black
        Me.btnG84.Appearance = Appearance82
        Me.btnG84.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG84.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG84.Location = New System.Drawing.Point(103, 20)
        Me.btnG84.Name = "btnG84"
        Me.btnG84.Size = New System.Drawing.Size(84, 70)
        Me.btnG84.TabIndex = 1
        Me.btnG84.Text = "G84"
        Me.btnG84.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnDB5
        '
        Appearance83.BackColor = System.Drawing.Color.Gray
        Me.btnDB5.Appearance = Appearance83
        Me.btnDB5.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnDB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDB5.Location = New System.Drawing.Point(14, 20)
        Me.btnDB5.Name = "btnDB5"
        Me.btnDB5.Size = New System.Drawing.Size(83, 70)
        Me.btnDB5.TabIndex = 0
        Me.btnDB5.Text = "DB5"
        Me.btnDB5.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugbHead
        '
        Me.ugbHead.Controls.Add(Me.grb_Documento)
        Me.ugbHead.Controls.Add(Me.UltraGroupBox4)
        Me.ugbHead.Controls.Add(Me.UltraGroupBox2)
        Me.ugbHead.Controls.Add(Me.ugbTipoPago)
        Me.ugbHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbHead.Location = New System.Drawing.Point(0, 0)
        Me.ugbHead.Name = "ugbHead"
        Me.ugbHead.Size = New System.Drawing.Size(1339, 479)
        Me.ugbHead.TabIndex = 0
        Me.ugbHead.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grb_Documento
        '
        Me.grb_Documento.Controls.Add(Me.UltraLabel12)
        Me.grb_Documento.Controls.Add(Me.UltraLabel11)
        Me.grb_Documento.Controls.Add(Me.UltraLabel8)
        Me.grb_Documento.Controls.Add(Me.cbDocumento)
        Me.grb_Documento.Controls.Add(Me.txtNumero)
        Me.grb_Documento.Controls.Add(Me.cmbTipoDocumento)
        Me.grb_Documento.Controls.Add(Me.dtpFechaDoc)
        Me.grb_Documento.Controls.Add(Me.txtSerie)
        Me.grb_Documento.Location = New System.Drawing.Point(453, 126)
        Me.grb_Documento.Name = "grb_Documento"
        Me.grb_Documento.Size = New System.Drawing.Size(395, 132)
        Me.grb_Documento.TabIndex = 17
        Me.grb_Documento.Text = "       Emitir Documento:"
        Me.grb_Documento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.grb_Documento.Visible = False
        '
        'UltraLabel12
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Appearance84.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance84
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(11, 94)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(91, 28)
        Me.UltraLabel12.TabIndex = 28
        Me.UltraLabel12.Text = "Numero:"
        '
        'UltraLabel11
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Appearance85.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance85
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(31, 59)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(71, 28)
        Me.UltraLabel11.TabIndex = 27
        Me.UltraLabel11.Text = "Fecha:"
        '
        'UltraLabel8
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance86
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(46, 26)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(56, 28)
        Me.UltraLabel8.TabIndex = 26
        Me.UltraLabel8.Text = "Tipo:"
        '
        'cbDocumento
        '
        Me.cbDocumento.AutoSize = True
        Me.cbDocumento.BackColor = System.Drawing.Color.Transparent
        Me.cbDocumento.ForeColor = System.Drawing.Color.Navy
        Me.cbDocumento.Location = New System.Drawing.Point(6, 1)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(15, 14)
        Me.cbDocumento.TabIndex = 14
        Me.cbDocumento.UseVisualStyleBackColor = False
        '
        'txtNumero
        '
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(213, 92)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(170, 33)
        Me.txtNumero.TabIndex = 3
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(108, 24)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(275, 33)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDoc.Location = New System.Drawing.Point(108, 59)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Size = New System.Drawing.Size(120, 30)
        Me.dtpFechaDoc.TabIndex = 1
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(108, 92)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(99, 33)
        Me.txtSerie.TabIndex = 2
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cmbVehiculo)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox4.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox4.Controls.Add(Me.txtDireccionFiscal)
        Me.UltraGroupBox4.Controls.Add(Me.cbgCliente)
        Me.UltraGroupBox4.Controls.Add(Me.cbRuc)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(6, 12)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(842, 108)
        Me.UltraGroupBox4.TabIndex = 5
        Me.UltraGroupBox4.Text = "Cliente:"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbVehiculo
        '
        Me.cmbVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        EditorButton1.Key = "Left"
        Me.cmbVehiculo.ButtonsLeft.Add(EditorButton1)
        EditorButton2.Key = "Right"
        Me.cmbVehiculo.ButtonsRight.Add(EditorButton2)
        Me.cmbVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cmbVehiculo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVehiculo.Location = New System.Drawing.Point(563, 64)
        Me.cmbVehiculo.Name = "cmbVehiculo"
        Me.cmbVehiculo.Size = New System.Drawing.Size(238, 35)
        Me.cmbVehiculo.TabIndex = 4
        '
        'UltraLabel13
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance87
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(462, 71)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(95, 28)
        Me.UltraLabel13.TabIndex = 27
        Me.UltraLabel13.Text = "Vehiculo:"
        '
        'UltraButton1
        '
        Me.UltraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.UltraButton1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(760, 23)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(41, 36)
        Me.UltraButton1.TabIndex = 2
        Me.UltraButton1.Text = "?"
        Me.UltraButton1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtDireccionFiscal
        '
        Me.txtDireccionFiscal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDireccionFiscal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionFiscal.Location = New System.Drawing.Point(10, 65)
        Me.txtDireccionFiscal.Name = "txtDireccionFiscal"
        Me.txtDireccionFiscal.Size = New System.Drawing.Size(431, 35)
        Me.txtDireccionFiscal.TabIndex = 3
        '
        'cbgCliente
        '
        EditorButton3.Key = "Left"
        Me.cbgCliente.ButtonsLeft.Add(EditorButton3)
        EditorButton4.Key = "Right"
        Me.cbgCliente.ButtonsRight.Add(EditorButton4)
        Me.cbgCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Appearance9.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgCliente.DisplayLayout.Appearance = Appearance9
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 5
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 300
        UltraGridColumn7.Header.VisiblePosition = 9
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 6
        UltraGridColumn9.Header.VisiblePosition = 24
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 22
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 20
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 12
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn19.Header.VisiblePosition = 16
        UltraGridColumn20.Header.VisiblePosition = 17
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn23.Header.VisiblePosition = 23
        UltraGridColumn24.Header.VisiblePosition = 18
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 10
        UltraGridColumn25.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25})
        Me.cbgCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.cbgCliente.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.cbgCliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.cbgCliente.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgCliente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgCliente.DisplayLayout.Override.ActiveCellAppearance = Appearance13
        Appearance14.BackColor = System.Drawing.SystemColors.Highlight
        Appearance14.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgCliente.DisplayLayout.Override.ActiveRowAppearance = Appearance14
        Me.cbgCliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.CardAreaAppearance = Appearance15
        Appearance16.BorderColor = System.Drawing.Color.Silver
        Appearance16.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgCliente.DisplayLayout.Override.CellAppearance = Appearance16
        Me.cbgCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgCliente.DisplayLayout.Override.CellPadding = 0
        Appearance17.BackColor = System.Drawing.SystemColors.Control
        Appearance17.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance17.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance17.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance17.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.GroupByRowAppearance = Appearance17
        Appearance18.TextHAlignAsString = "Left"
        Me.cbgCliente.DisplayLayout.Override.HeaderAppearance = Appearance18
        Me.cbgCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Appearance19.BorderColor = System.Drawing.Color.Silver
        Me.cbgCliente.DisplayLayout.Override.RowAppearance = Appearance19
        Me.cbgCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgCliente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance20
        Me.cbgCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgCliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgCliente.DisplayMember = "Nombre"
        Me.cbgCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgCliente.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgCliente.Location = New System.Drawing.Point(10, 23)
        Me.cbgCliente.Name = "cbgCliente"
        Me.cbgCliente.Size = New System.Drawing.Size(667, 36)
        Me.cbgCliente.TabIndex = 0
        Me.cbgCliente.ValueMember = "Id"
        '
        'cbRuc
        '
        Me.cbRuc.AutoSize = True
        Me.cbRuc.BackColor = System.Drawing.Color.Transparent
        Me.cbRuc.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRuc.ForeColor = System.Drawing.Color.Navy
        Me.cbRuc.Location = New System.Drawing.Point(683, 30)
        Me.cbRuc.Name = "cbRuc"
        Me.cbRuc.Size = New System.Drawing.Size(71, 29)
        Me.cbRuc.TabIndex = 1
        Me.cbRuc.Text = "RUC"
        Me.cbRuc.UseVisualStyleBackColor = False
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.grbCombustible)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(6, 264)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(842, 206)
        Me.UltraGroupBox2.TabIndex = 6
        Me.UltraGroupBox2.Text = "Datos de la Venta:"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grbCombustible
        '
        Me.grbCombustible.Controls.Add(Me.btnAgregarDetalle)
        Me.grbCombustible.Controls.Add(Me.btnDB5)
        Me.grbCombustible.Controls.Add(Me.UltraLabel6)
        Me.grbCombustible.Controls.Add(Me.decDescuento)
        Me.grbCombustible.Controls.Add(Me.btnG95)
        Me.grbCombustible.Controls.Add(Me.decPrecio)
        Me.grbCombustible.Controls.Add(Me.UltraLabel3)
        Me.grbCombustible.Controls.Add(Me.UltraLabel2)
        Me.grbCombustible.Controls.Add(Me.decPrecioTotal)
        Me.grbCombustible.Controls.Add(Me.decCantidad)
        Me.grbCombustible.Controls.Add(Me.btnG90)
        Me.grbCombustible.Controls.Add(Me.UltraLabel4)
        Me.grbCombustible.Controls.Add(Me.btnG84)
        Me.grbCombustible.Enabled = False
        Me.grbCombustible.Location = New System.Drawing.Point(291, 23)
        Me.grbCombustible.Name = "grbCombustible"
        Me.grbCombustible.Size = New System.Drawing.Size(540, 170)
        Me.grbCombustible.TabIndex = 18
        Me.grbCombustible.Text = "Combustible:"
        Me.grbCombustible.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnAgregarDetalle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(481, 22)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(48, 140)
        Me.btnAgregarDetalle.TabIndex = 5
        Me.btnAgregarDetalle.Text = "+"
        Me.btnAgregarDetalle.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel6
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance88
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(221, 134)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(91, 28)
        Me.UltraLabel6.TabIndex = 25
        Me.UltraLabel6.Text = "Importe:"
        '
        'decDescuento
        '
        Me.decDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDescuento.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDescuento.Location = New System.Drawing.Point(318, 92)
        Me.decDescuento.MaskInput = "{double:9.2}"
        Me.decDescuento.Name = "decDescuento"
        Me.decDescuento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDescuento.ReadOnly = True
        Me.decDescuento.Size = New System.Drawing.Size(157, 35)
        Me.decDescuento.TabIndex = 21
        '
        'decPrecio
        '
        Me.decPrecio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPrecio.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPrecio.Location = New System.Drawing.Point(318, 56)
        Me.decPrecio.MaskInput = "{double:9.2}"
        Me.decPrecio.Name = "decPrecio"
        Me.decPrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPrecio.ReadOnly = True
        Me.decPrecio.Size = New System.Drawing.Size(157, 35)
        Me.decPrecio.TabIndex = 20
        '
        'UltraLabel3
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.Navy
        Appearance89.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance89
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(239, 63)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(73, 28)
        Me.UltraLabel3.TabIndex = 22
        Me.UltraLabel3.Text = "Precio:"
        '
        'UltraLabel2
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.Navy
        Appearance90.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance90
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(213, 27)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(99, 28)
        Me.UltraLabel2.TabIndex = 18
        Me.UltraLabel2.Text = "Cantidad:"
        '
        'decPrecioTotal
        '
        Me.decPrecioTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPrecioTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPrecioTotal.Location = New System.Drawing.Point(318, 128)
        Me.decPrecioTotal.MaskInput = "{double:9.2}"
        Me.decPrecioTotal.Name = "decPrecioTotal"
        Me.decPrecioTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPrecioTotal.ReadOnly = True
        Me.decPrecioTotal.Size = New System.Drawing.Size(157, 35)
        Me.decPrecioTotal.TabIndex = 24
        '
        'decCantidad
        '
        Me.decCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCantidad.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decCantidad.Location = New System.Drawing.Point(318, 20)
        Me.decCantidad.MaskInput = "{double:9.2}"
        Me.decCantidad.Name = "decCantidad"
        Me.decCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCantidad.Size = New System.Drawing.Size(157, 35)
        Me.decCantidad.TabIndex = 4
        '
        'UltraLabel4
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Appearance91.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance91
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(197, 98)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(115, 28)
        Me.UltraLabel4.TabIndex = 23
        Me.UltraLabel4.Text = "Descuento:"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnLado6)
        Me.UltraGroupBox1.Controls.Add(Me.btnLado5)
        Me.UltraGroupBox1.Controls.Add(Me.btnLado4)
        Me.UltraGroupBox1.Controls.Add(Me.btnLado3)
        Me.UltraGroupBox1.Controls.Add(Me.btnLado1)
        Me.UltraGroupBox1.Controls.Add(Me.btnLado2)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(10, 20)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(275, 173)
        Me.UltraGroupBox1.TabIndex = 5
        Me.UltraGroupBox1.Text = "Seleccione Lado:"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnLado6
        '
        Appearance92.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLado6.Appearance = Appearance92
        Me.btnLado6.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado6.Location = New System.Drawing.Point(143, 61)
        Me.btnLado6.Name = "btnLado6"
        Me.btnLado6.Size = New System.Drawing.Size(121, 31)
        Me.btnLado6.TabIndex = 5
        Me.btnLado6.Text = "6"
        Me.btnLado6.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado5
        '
        Appearance93.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLado5.Appearance = Appearance93
        Me.btnLado5.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado5.Location = New System.Drawing.Point(143, 30)
        Me.btnLado5.Name = "btnLado5"
        Me.btnLado5.Size = New System.Drawing.Size(121, 31)
        Me.btnLado5.TabIndex = 4
        Me.btnLado5.Text = "5"
        Me.btnLado5.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado4
        '
        Appearance94.BackColor = System.Drawing.Color.Silver
        Me.btnLado4.Appearance = Appearance94
        Me.btnLado4.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado4.Location = New System.Drawing.Point(16, 131)
        Me.btnLado4.Name = "btnLado4"
        Me.btnLado4.Size = New System.Drawing.Size(121, 31)
        Me.btnLado4.TabIndex = 3
        Me.btnLado4.Text = "4"
        Me.btnLado4.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado3
        '
        Appearance95.BackColor = System.Drawing.Color.Silver
        Me.btnLado3.Appearance = Appearance95
        Me.btnLado3.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado3.Location = New System.Drawing.Point(16, 100)
        Me.btnLado3.Name = "btnLado3"
        Me.btnLado3.Size = New System.Drawing.Size(121, 31)
        Me.btnLado3.TabIndex = 2
        Me.btnLado3.Text = "3"
        Me.btnLado3.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado1
        '
        Appearance96.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance96.ForeColor = System.Drawing.Color.Black
        Me.btnLado1.Appearance = Appearance96
        Me.btnLado1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado1.Location = New System.Drawing.Point(16, 30)
        Me.btnLado1.Name = "btnLado1"
        Me.btnLado1.Size = New System.Drawing.Size(121, 31)
        Me.btnLado1.TabIndex = 0
        Me.btnLado1.Text = "1"
        Me.btnLado1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado2
        '
        Appearance97.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLado2.Appearance = Appearance97
        Me.btnLado2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado2.Location = New System.Drawing.Point(16, 61)
        Me.btnLado2.Name = "btnLado2"
        Me.btnLado2.Size = New System.Drawing.Size(121, 31)
        Me.btnLado2.TabIndex = 1
        Me.btnLado2.Text = "2"
        Me.btnLado2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugbTipoPago
        '
        Me.ugbTipoPago.Controls.Add(Me.btnDocumento)
        Me.ugbTipoPago.Controls.Add(Me.btnVarios)
        Me.ugbTipoPago.Controls.Add(Me.btnContado)
        Me.ugbTipoPago.Controls.Add(Me.btnVale)
        Me.ugbTipoPago.Controls.Add(Me.btnCredito)
        Me.ugbTipoPago.Location = New System.Drawing.Point(6, 126)
        Me.ugbTipoPago.Name = "ugbTipoPago"
        Me.ugbTipoPago.Size = New System.Drawing.Size(441, 132)
        Me.ugbTipoPago.TabIndex = 4
        Me.ugbTipoPago.Text = "Tipo de Venta:"
        Me.ugbTipoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnDocumento
        '
        Appearance98.BackColor = System.Drawing.Color.White
        Me.btnDocumento.Appearance = Appearance98
        Me.btnDocumento.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnDocumento.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento.Location = New System.Drawing.Point(15, 71)
        Me.btnDocumento.Name = "btnDocumento"
        Me.btnDocumento.Size = New System.Drawing.Size(148, 37)
        Me.btnDocumento.TabIndex = 2
        Me.btnDocumento.Text = "DOCUMENTO"
        Me.btnDocumento.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVarios
        '
        Appearance99.BackColor = System.Drawing.Color.White
        Me.btnVarios.Appearance = Appearance99
        Me.btnVarios.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnVarios.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVarios.Location = New System.Drawing.Point(296, 71)
        Me.btnVarios.Name = "btnVarios"
        Me.btnVarios.Size = New System.Drawing.Size(121, 37)
        Me.btnVarios.TabIndex = 4
        Me.btnVarios.Text = "VARIOS"
        Me.btnVarios.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnContado
        '
        Me.btnContado.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnContado.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContado.Location = New System.Drawing.Point(15, 27)
        Me.btnContado.Name = "btnContado"
        Me.btnContado.Size = New System.Drawing.Size(213, 37)
        Me.btnContado.TabIndex = 0
        Me.btnContado.Text = "CONTADO"
        Me.btnContado.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVale
        '
        Appearance100.BackColor = System.Drawing.Color.White
        Me.btnVale.Appearance = Appearance100
        Me.btnVale.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnVale.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVale.Location = New System.Drawing.Point(169, 71)
        Me.btnVale.Name = "btnVale"
        Me.btnVale.Size = New System.Drawing.Size(121, 37)
        Me.btnVale.TabIndex = 3
        Me.btnVale.Text = "VALE"
        Me.btnVale.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCredito
        '
        Me.btnCredito.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnCredito.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredito.Location = New System.Drawing.Point(234, 27)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(183, 37)
        Me.btnCredito.TabIndex = 1
        Me.btnCredito.Text = "CRÉDITO"
        Me.btnCredito.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtGlosa
        '
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(306, 47)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.ReadOnly = True
        Me.txtGlosa.Size = New System.Drawing.Size(255, 116)
        Me.txtGlosa.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 479)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1339, 249)
        Me.UltraGroupBox3.TabIndex = 7
        Me.UltraGroupBox3.Text = "Detalle de Venta"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.udg_Detalle)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox6.Location = New System.Drawing.Point(3, 17)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(763, 229)
        Me.UltraGroupBox6.TabIndex = 25
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Detalle
        '
        Me.udg_Detalle.DataSource = Me.odOrdenComMat
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Detalle.DisplayLayout.Appearance = Appearance34
        UltraGridColumn26.Header.VisiblePosition = 0
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 1
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.Caption = "SubAlmacen"
        UltraGridColumn28.Header.VisiblePosition = 16
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 161
        UltraGridColumn29.Header.VisiblePosition = 13
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn30.Width = 311
        UltraGridColumn31.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn31.Header.Caption = "UM"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 42
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn32.CellAppearance = Appearance35
        UltraGridColumn32.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn32.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn32.Header.VisiblePosition = 17
        UltraGridColumn32.Hidden = True
        UltraGridColumn32.Width = 269
        Appearance36.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance36
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn33.Format = "#,###,###,##0.000"
        UltraGridColumn33.Header.VisiblePosition = 5
        UltraGridColumn33.MaskInput = "{double:9.3}"
        UltraGridColumn33.Width = 72
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance37
        Appearance38.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance38.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn34.CellButtonAppearance = Appearance38
        UltraGridColumn34.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn34.Format = "#,###,###,##0.000"
        UltraGridColumn34.Header.Caption = "Pendiente"
        UltraGridColumn34.Header.VisiblePosition = 12
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.MaskInput = "{double:9.3}"
        UltraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn34.Width = 80
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance39
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn35.Format = "#,###,###,##0.000"
        UltraGridColumn35.Header.Caption = "Atender"
        UltraGridColumn35.Header.VisiblePosition = 14
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.MaskInput = "{double:9.3}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 80
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance40
        UltraGridColumn36.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn36.Format = "#,###,###,##0.000"
        UltraGridColumn36.Header.Caption = "CostoU."
        UltraGridColumn36.Header.VisiblePosition = 7
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.MaskInput = "{double:9.3}"
        UltraGridColumn36.Width = 80
        UltraGridColumn37.Header.VisiblePosition = 27
        UltraGridColumn37.Hidden = True
        Appearance41.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance41
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn38.Format = "#,###,###,##0.000"
        UltraGridColumn38.Header.Caption = "PrecioU."
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.MaskInput = "{double:9.3}"
        UltraGridColumn38.Width = 80
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance42
        UltraGridColumn39.Format = "#,###,###,##0.000"
        UltraGridColumn39.Header.VisiblePosition = 10
        UltraGridColumn39.MaskInput = "{double:9.3}"
        UltraGridColumn39.Width = 80
        UltraGridColumn40.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.Caption = "IGV"
        UltraGridColumn40.Header.VisiblePosition = 6
        UltraGridColumn40.Hidden = True
        UltraGridColumn40.Width = 47
        UltraGridColumn41.Header.VisiblePosition = 18
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 19
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 20
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 21
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 22
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 23
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 24
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 2
        UltraGridColumn48.Hidden = True
        UltraGridColumn48.Width = 76
        UltraGridColumn49.Header.Caption = "Almacen"
        UltraGridColumn49.Header.VisiblePosition = 15
        UltraGridColumn49.Hidden = True
        UltraGridColumn49.Width = 195
        UltraGridColumn50.Header.VisiblePosition = 25
        UltraGridColumn50.Hidden = True
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance43
        UltraGridColumn51.Header.Caption = "%Dscto"
        UltraGridColumn51.Header.VisiblePosition = 11
        UltraGridColumn51.Hidden = True
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance44.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance44
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn52.Header.VisiblePosition = 9
        UltraGridColumn52.MaskInput = "{double:4.2}"
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn52.Width = 59
        UltraGridColumn53.Header.VisiblePosition = 26
        UltraGridColumn53.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53})
        Me.udg_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_Detalle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Detalle.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.udg_Detalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalle.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.udg_Detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Detalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_Detalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Detalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Detalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Detalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Detalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Detalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Detalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.udg_Detalle.DisplayLayout.Override.RowAppearance = Appearance48
        Me.udg_Detalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Detalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Detalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Detalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Detalle.Location = New System.Drawing.Point(3, 3)
        Me.udg_Detalle.Name = "udg_Detalle"
        Me.udg_Detalle.Size = New System.Drawing.Size(757, 223)
        Me.udg_Detalle.TabIndex = 1
        Me.udg_Detalle.Text = "Grilla2"
        '
        'odOrdenComMat
        '
        UltraDataColumn64.DataType = GetType(Double)
        UltraDataColumn65.DataType = GetType(Double)
        UltraDataColumn66.DataType = GetType(Double)
        UltraDataColumn67.DataType = GetType(Double)
        UltraDataColumn68.DataType = GetType(Double)
        UltraDataColumn69.DataType = GetType(Double)
        UltraDataColumn70.DataType = GetType(Double)
        UltraDataColumn71.DataType = GetType(Boolean)
        UltraDataColumn82.DataType = GetType(Double)
        UltraDataColumn83.DataType = GetType(Double)
        UltraDataColumn84.DataType = GetType(Double)
        Me.odOrdenComMat.Band.Columns.AddRange(New Object() {UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84})
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.decDescuentoTotal)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox9.Controls.Add(Me.decTotal)
        Me.UltraGroupBox9.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox9.Controls.Add(Me.decImpuesto)
        Me.UltraGroupBox9.Controls.Add(Me.decSubTotal)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox9.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGroupBox9.Location = New System.Drawing.Point(766, 17)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(570, 229)
        Me.UltraGroupBox9.TabIndex = 24
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decDescuentoTotal
        '
        Me.decDescuentoTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDescuentoTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDescuentoTotal.Location = New System.Drawing.Point(133, 47)
        Me.decDescuentoTotal.MaskInput = "{double:9.2}"
        Me.decDescuentoTotal.Name = "decDescuentoTotal"
        Me.decDescuentoTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDescuentoTotal.ReadOnly = True
        Me.decDescuentoTotal.Size = New System.Drawing.Size(157, 35)
        Me.decDescuentoTotal.TabIndex = 8
        '
        'UltraLabel5
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Appearance101.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance101
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(12, 54)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(115, 28)
        Me.UltraLabel5.TabIndex = 7
        Me.UltraLabel5.Text = "Descuento:"
        '
        'UltraLabel1
        '
        Appearance102.BackColor = System.Drawing.Color.Transparent
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Appearance102.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance102
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(306, 13)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(67, 28)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Glosa:"
        '
        'decTotal
        '
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotal.Location = New System.Drawing.Point(133, 129)
        Me.decTotal.MaskInput = "{double:9.2}"
        Me.decTotal.Name = "decTotal"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(157, 35)
        Me.decTotal.TabIndex = 5
        '
        'decImpuesto
        '
        Me.decImpuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImpuesto.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImpuesto.Location = New System.Drawing.Point(133, 88)
        Me.decImpuesto.MaskInput = "{double:9.2}"
        Me.decImpuesto.Name = "decImpuesto"
        Me.decImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImpuesto.ReadOnly = True
        Me.decImpuesto.Size = New System.Drawing.Size(157, 35)
        Me.decImpuesto.TabIndex = 3
        '
        'decSubTotal
        '
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSubTotal.Location = New System.Drawing.Point(133, 6)
        Me.decSubTotal.MaskInput = "{double:9.2}"
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.ReadOnly = True
        Me.decSubTotal.Size = New System.Drawing.Size(157, 35)
        Me.decSubTotal.TabIndex = 1
        '
        'UltraLabel10
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Appearance103.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance103
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(64, 135)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(63, 28)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Total:"
        '
        'UltraLabel7
        '
        Appearance104.BackColor = System.Drawing.Color.Transparent
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Appearance104.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance104
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(28, 13)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(99, 28)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "SubTotal:"
        '
        'UltraLabel9
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Appearance105.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance105
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(22, 94)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(105, 28)
        Me.UltraLabel9.TabIndex = 2
        Me.UltraLabel9.Text = "Impuesto:"
        '
        'frm_EstacionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 728)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Controls.Add(Me.ugbHead)
        Me.Name = "frm_EstacionServicio"
        Me.Text = "frm_EstacionServicio"
        CType(Me.ugbHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbHead.ResumeLayout(False)
        CType(Me.grb_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_Documento.ResumeLayout(False)
        Me.grb_Documento.PerformLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cmbVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.grbCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCombustible.ResumeLayout(False)
        Me.grbCombustible.PerformLayout()
        CType(Me.decDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPrecioTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ugbTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbTipoPago.ResumeLayout(False)
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.udg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        Me.UltraGroupBox9.PerformLayout()
        CType(Me.decDescuentoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ugbHead As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugbTipoPago As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnContado As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCredito As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnG95 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnG90 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnG84 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDB5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnLado6 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLado5 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLado4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLado3 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLado1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnLado2 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbgCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cbRuc As CheckBox
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmbTipoDocumento As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents dtpFechaDoc As DateTimePicker
    Friend WithEvents grb_Documento As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cbDocumento As CheckBox
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents decTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decImpuesto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decSubTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents udg_Detalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnDocumento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVarios As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVale As Infragistics.Win.Misc.UltraButton
    Friend WithEvents decCantidad As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decDescuento As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decPrecio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decDescuentoTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odOrdenComMat As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtDireccionFiscal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnAgregarDetalle As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decPrecioTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents grbCombustible As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cmbVehiculo As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
End Class
