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
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Left")
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("Right")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenComercial")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadPendiente")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadAtender")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoUnitario")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoInventario")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioTotal")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndImpuesto")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PDscto")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dscto")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadReal")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenComercial")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadPendiente")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadAtender")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoUnitario")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoInventario")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioTotal")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndImpuesto")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaSis")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSucursal")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PDscto")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dscto")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadReal")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.txtDireccionFiscal = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cbgCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cbRuc = New System.Windows.Forms.CheckBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grbCombustibles = New Infragistics.Win.Misc.UltraGroupBox()
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
        Me.btnContado = New Infragistics.Win.Misc.UltraButton()
        Me.btnCredito = New Infragistics.Win.Misc.UltraButton()
        Me.ugbTipoVenta = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnDocumento = New Infragistics.Win.Misc.UltraButton()
        Me.btnVarios = New Infragistics.Win.Misc.UltraButton()
        Me.btnVale = New Infragistics.Win.Misc.UltraButton()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.udg_Detalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odOrdenComMat = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decImpuesto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.decSubTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.ugbHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbHead.SuspendLayout()
        CType(Me.grb_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_Documento.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.grbCombustibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCombustibles.SuspendLayout()
        CType(Me.decDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPrecioTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ugbTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbTipoPago.SuspendLayout()
        CType(Me.ugbTipoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ugbTipoVenta.SuspendLayout()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.udg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenComMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnG95
        '
        Appearance52.BackColor = System.Drawing.Color.Blue
        Appearance52.BorderColor = System.Drawing.Color.Black
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.btnG95.Appearance = Appearance52
        Me.btnG95.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG95.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG95.Location = New System.Drawing.Point(95, 96)
        Me.btnG95.Name = "btnG95"
        Me.btnG95.Size = New System.Drawing.Size(84, 70)
        Me.btnG95.TabIndex = 3
        Me.btnG95.Text = "G95"
        Me.btnG95.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnG90
        '
        Appearance53.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance53.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Appearance53.FontData.BoldAsString = "False"
        Appearance53.ForeColor = System.Drawing.Color.Black
        Me.btnG90.Appearance = Appearance53
        Me.btnG90.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG90.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG90.Location = New System.Drawing.Point(6, 96)
        Me.btnG90.Name = "btnG90"
        Me.btnG90.Size = New System.Drawing.Size(83, 70)
        Me.btnG90.TabIndex = 2
        Me.btnG90.Text = "G90"
        Me.btnG90.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnG84
        '
        Appearance54.BackColor = System.Drawing.Color.Red
        Appearance54.BorderColor = System.Drawing.Color.Black
        Me.btnG84.Appearance = Appearance54
        Me.btnG84.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnG84.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG84.Location = New System.Drawing.Point(95, 24)
        Me.btnG84.Name = "btnG84"
        Me.btnG84.Size = New System.Drawing.Size(84, 70)
        Me.btnG84.TabIndex = 1
        Me.btnG84.Text = "G84"
        Me.btnG84.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnDB5
        '
        Appearance55.BackColor = System.Drawing.Color.Gray
        Me.btnDB5.Appearance = Appearance55
        Me.btnDB5.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnDB5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDB5.Location = New System.Drawing.Point(6, 24)
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
        Me.ugbHead.Controls.Add(Me.ugbTipoVenta)
        Me.ugbHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.ugbHead.Location = New System.Drawing.Point(0, 0)
        Me.ugbHead.Name = "ugbHead"
        Me.ugbHead.Size = New System.Drawing.Size(1339, 528)
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
        Me.grb_Documento.Location = New System.Drawing.Point(416, 137)
        Me.grb_Documento.Name = "grb_Documento"
        Me.grb_Documento.Size = New System.Drawing.Size(432, 164)
        Me.grb_Documento.TabIndex = 17
        Me.grb_Documento.Text = "       Emitir Documento:"
        Me.grb_Documento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.grb_Documento.Visible = False
        '
        'UltraLabel12
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance56
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel12.Location = New System.Drawing.Point(19, 106)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(91, 28)
        Me.UltraLabel12.TabIndex = 28
        Me.UltraLabel12.Text = "Numero:"
        '
        'UltraLabel11
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Appearance57.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance57
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(39, 68)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(71, 28)
        Me.UltraLabel11.TabIndex = 27
        Me.UltraLabel11.Text = "Fecha:"
        '
        'UltraLabel8
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance58
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(54, 31)
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
        Me.txtNumero.Location = New System.Drawing.Point(221, 104)
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
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(116, 29)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(275, 33)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'dtpFechaDoc
        '
        Me.dtpFechaDoc.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDoc.Location = New System.Drawing.Point(116, 68)
        Me.dtpFechaDoc.Name = "dtpFechaDoc"
        Me.dtpFechaDoc.Size = New System.Drawing.Size(120, 30)
        Me.dtpFechaDoc.TabIndex = 1
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(116, 104)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(99, 33)
        Me.txtSerie.TabIndex = 2
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.UltraButton1)
        Me.UltraGroupBox4.Controls.Add(Me.txtDireccionFiscal)
        Me.UltraGroupBox4.Controls.Add(Me.cbgCliente)
        Me.UltraGroupBox4.Controls.Add(Me.cbRuc)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(6, 12)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(842, 118)
        Me.UltraGroupBox4.TabIndex = 5
        Me.UltraGroupBox4.Text = "Cliente:"
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraButton1
        '
        Me.UltraButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.UltraButton1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraButton1.Location = New System.Drawing.Point(760, 25)
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
        Me.txtDireccionFiscal.Location = New System.Drawing.Point(10, 67)
        Me.txtDireccionFiscal.Name = "txtDireccionFiscal"
        Me.txtDireccionFiscal.Size = New System.Drawing.Size(791, 35)
        Me.txtDireccionFiscal.TabIndex = 3
        '
        'cbgCliente
        '
        EditorButton1.Key = "Left"
        Me.cbgCliente.ButtonsLeft.Add(EditorButton1)
        EditorButton2.Key = "Right"
        Me.cbgCliente.ButtonsRight.Add(EditorButton2)
        Me.cbgCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cbgCliente.DisplayLayout.Appearance = Appearance8
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
        Appearance9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.GroupByBox.Appearance = Appearance9
        Appearance10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance10
        Me.cbgCliente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance11.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance11.BackColor2 = System.Drawing.SystemColors.Control
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cbgCliente.DisplayLayout.GroupByBox.PromptAppearance = Appearance11
        Me.cbgCliente.DisplayLayout.MaxColScrollRegions = 1
        Me.cbgCliente.DisplayLayout.MaxRowScrollRegions = 1
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbgCliente.DisplayLayout.Override.ActiveCellAppearance = Appearance12
        Appearance13.BackColor = System.Drawing.SystemColors.Highlight
        Appearance13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbgCliente.DisplayLayout.Override.ActiveRowAppearance = Appearance13
        Me.cbgCliente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cbgCliente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.CardAreaAppearance = Appearance14
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Appearance15.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.cbgCliente.DisplayLayout.Override.CellAppearance = Appearance15
        Me.cbgCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cbgCliente.DisplayLayout.Override.CellPadding = 0
        Appearance16.BackColor = System.Drawing.SystemColors.Control
        Appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance16.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.BorderColor = System.Drawing.SystemColors.Window
        Me.cbgCliente.DisplayLayout.Override.GroupByRowAppearance = Appearance16
        Appearance17.TextHAlignAsString = "Left"
        Me.cbgCliente.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.cbgCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance18.BackColor = System.Drawing.SystemColors.Window
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.cbgCliente.DisplayLayout.Override.RowAppearance = Appearance18
        Me.cbgCliente.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbgCliente.DisplayLayout.Override.TemplateAddRowAppearance = Appearance19
        Me.cbgCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cbgCliente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cbgCliente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cbgCliente.DisplayMember = "Nombre"
        Me.cbgCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cbgCliente.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgCliente.Location = New System.Drawing.Point(10, 25)
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
        Me.cbRuc.Location = New System.Drawing.Point(683, 32)
        Me.cbRuc.Name = "cbRuc"
        Me.cbRuc.Size = New System.Drawing.Size(71, 29)
        Me.cbRuc.TabIndex = 1
        Me.cbRuc.Text = "RUC"
        Me.cbRuc.UseVisualStyleBackColor = False
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.grbCombustibles)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(6, 316)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(842, 206)
        Me.UltraGroupBox2.TabIndex = 6
        Me.UltraGroupBox2.Text = "Datos de la Venta:"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grbCombustibles
        '
        Me.grbCombustibles.Controls.Add(Me.btnAgregarDetalle)
        Me.grbCombustibles.Controls.Add(Me.btnDB5)
        Me.grbCombustibles.Controls.Add(Me.UltraLabel6)
        Me.grbCombustibles.Controls.Add(Me.decDescuento)
        Me.grbCombustibles.Controls.Add(Me.btnG95)
        Me.grbCombustibles.Controls.Add(Me.decPrecio)
        Me.grbCombustibles.Controls.Add(Me.UltraLabel3)
        Me.grbCombustibles.Controls.Add(Me.UltraLabel2)
        Me.grbCombustibles.Controls.Add(Me.decPrecioTotal)
        Me.grbCombustibles.Controls.Add(Me.decCantidad)
        Me.grbCombustibles.Controls.Add(Me.btnG90)
        Me.grbCombustibles.Controls.Add(Me.UltraLabel4)
        Me.grbCombustibles.Controls.Add(Me.btnG84)
        Me.grbCombustibles.Enabled = False
        Me.grbCombustibles.Location = New System.Drawing.Point(291, 20)
        Me.grbCombustibles.Name = "grbCombustibles"
        Me.grbCombustibles.Size = New System.Drawing.Size(540, 173)
        Me.grbCombustibles.TabIndex = 4
        Me.grbCombustibles.Text = "Combustibles:"
        Me.grbCombustibles.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnAgregarDetalle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(483, 24)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(48, 142)
        Me.btnAgregarDetalle.TabIndex = 5
        Me.btnAgregarDetalle.Text = "+"
        Me.btnAgregarDetalle.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel6
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Appearance59.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance59
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(223, 139)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(91, 28)
        Me.UltraLabel6.TabIndex = 25
        Me.UltraLabel6.Text = "Importe:"
        '
        'decDescuento
        '
        Me.decDescuento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDescuento.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDescuento.Location = New System.Drawing.Point(320, 96)
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
        Me.decPrecio.Location = New System.Drawing.Point(320, 59)
        Me.decPrecio.MaskInput = "{double:9.2}"
        Me.decPrecio.Name = "decPrecio"
        Me.decPrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPrecio.ReadOnly = True
        Me.decPrecio.Size = New System.Drawing.Size(157, 35)
        Me.decPrecio.TabIndex = 20
        '
        'UltraLabel3
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Appearance60.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance60
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(241, 66)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(73, 28)
        Me.UltraLabel3.TabIndex = 22
        Me.UltraLabel3.Text = "Precio:"
        '
        'UltraLabel2
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance61
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(215, 29)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(99, 28)
        Me.UltraLabel2.TabIndex = 18
        Me.UltraLabel2.Text = "Cantidad:"
        '
        'decPrecioTotal
        '
        Me.decPrecioTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPrecioTotal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPrecioTotal.Location = New System.Drawing.Point(320, 133)
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
        Me.decCantidad.Location = New System.Drawing.Point(320, 22)
        Me.decCantidad.MaskInput = "{double:9.2}"
        Me.decCantidad.Name = "decCantidad"
        Me.decCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCantidad.Size = New System.Drawing.Size(157, 35)
        Me.decCantidad.TabIndex = 4
        '
        'UltraLabel4
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Appearance62.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance62
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(199, 102)
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
        Appearance63.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLado6.Appearance = Appearance63
        Me.btnLado6.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado6.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado6.Location = New System.Drawing.Point(16, 58)
        Me.btnLado6.Name = "btnLado6"
        Me.btnLado6.Size = New System.Drawing.Size(121, 31)
        Me.btnLado6.TabIndex = 1
        Me.btnLado6.Text = "6"
        Me.btnLado6.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado5
        '
        Appearance64.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLado5.Appearance = Appearance64
        Me.btnLado5.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado5.Location = New System.Drawing.Point(16, 27)
        Me.btnLado5.Name = "btnLado5"
        Me.btnLado5.Size = New System.Drawing.Size(121, 31)
        Me.btnLado5.TabIndex = 0
        Me.btnLado5.Text = "5"
        Me.btnLado5.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado4
        '
        Appearance65.BackColor = System.Drawing.Color.Silver
        Me.btnLado4.Appearance = Appearance65
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
        Appearance66.BackColor = System.Drawing.Color.Silver
        Me.btnLado3.Appearance = Appearance66
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
        Appearance67.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.btnLado1.Appearance = Appearance67
        Me.btnLado1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado1.Location = New System.Drawing.Point(143, 100)
        Me.btnLado1.Name = "btnLado1"
        Me.btnLado1.Size = New System.Drawing.Size(121, 31)
        Me.btnLado1.TabIndex = 4
        Me.btnLado1.Text = "1"
        Me.btnLado1.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnLado2
        '
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLado2.Appearance = Appearance68
        Me.btnLado2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnLado2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLado2.Location = New System.Drawing.Point(143, 131)
        Me.btnLado2.Name = "btnLado2"
        Me.btnLado2.Size = New System.Drawing.Size(121, 31)
        Me.btnLado2.TabIndex = 5
        Me.btnLado2.Text = "2"
        Me.btnLado2.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugbTipoPago
        '
        Me.ugbTipoPago.Controls.Add(Me.btnContado)
        Me.ugbTipoPago.Controls.Add(Me.btnCredito)
        Me.ugbTipoPago.Location = New System.Drawing.Point(6, 137)
        Me.ugbTipoPago.Name = "ugbTipoPago"
        Me.ugbTipoPago.Size = New System.Drawing.Size(404, 79)
        Me.ugbTipoPago.TabIndex = 4
        Me.ugbTipoPago.Text = "Tipo de Pago:"
        Me.ugbTipoPago.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnContado
        '
        Me.btnContado.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnContado.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContado.Location = New System.Drawing.Point(15, 25)
        Me.btnContado.Name = "btnContado"
        Me.btnContado.Size = New System.Drawing.Size(121, 37)
        Me.btnContado.TabIndex = 0
        Me.btnContado.Text = "CONTADO"
        Me.btnContado.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnCredito
        '
        Me.btnCredito.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnCredito.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredito.Location = New System.Drawing.Point(142, 25)
        Me.btnCredito.Name = "btnCredito"
        Me.btnCredito.Size = New System.Drawing.Size(121, 37)
        Me.btnCredito.TabIndex = 1
        Me.btnCredito.Text = "CRÉDITO"
        Me.btnCredito.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugbTipoVenta
        '
        Me.ugbTipoVenta.Controls.Add(Me.btnDocumento)
        Me.ugbTipoVenta.Controls.Add(Me.btnVarios)
        Me.ugbTipoVenta.Controls.Add(Me.btnVale)
        Me.ugbTipoVenta.Location = New System.Drawing.Point(6, 222)
        Me.ugbTipoVenta.Name = "ugbTipoVenta"
        Me.ugbTipoVenta.Size = New System.Drawing.Size(404, 79)
        Me.ugbTipoVenta.TabIndex = 3
        Me.ugbTipoVenta.Text = "Tipo de Venta:"
        Me.ugbTipoVenta.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnDocumento
        '
        Appearance69.BackColor = System.Drawing.Color.White
        Me.btnDocumento.Appearance = Appearance69
        Me.btnDocumento.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnDocumento.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento.Location = New System.Drawing.Point(15, 25)
        Me.btnDocumento.Name = "btnDocumento"
        Me.btnDocumento.Size = New System.Drawing.Size(121, 37)
        Me.btnDocumento.TabIndex = 0
        Me.btnDocumento.Text = "DOCUMENTO"
        Me.btnDocumento.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVarios
        '
        Appearance70.BackColor = System.Drawing.Color.White
        Me.btnVarios.Appearance = Appearance70
        Me.btnVarios.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnVarios.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVarios.Location = New System.Drawing.Point(269, 25)
        Me.btnVarios.Name = "btnVarios"
        Me.btnVarios.Size = New System.Drawing.Size(121, 37)
        Me.btnVarios.TabIndex = 2
        Me.btnVarios.Text = "VARIOS"
        Me.btnVarios.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVale
        '
        Appearance71.BackColor = System.Drawing.Color.White
        Me.btnVale.Appearance = Appearance71
        Me.btnVale.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.btnVale.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVale.Location = New System.Drawing.Point(142, 25)
        Me.btnVale.Name = "btnVale"
        Me.btnVale.Size = New System.Drawing.Size(121, 37)
        Me.btnVale.TabIndex = 1
        Me.btnVale.Text = "VALE"
        Me.btnVale.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'txtGlosa
        '
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(306, 47)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.ReadOnly = True
        Me.txtGlosa.Size = New System.Drawing.Size(255, 76)
        Me.txtGlosa.TabIndex = 0
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 528)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1339, 200)
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
        Me.UltraGroupBox6.Size = New System.Drawing.Size(763, 180)
        Me.UltraGroupBox6.TabIndex = 25
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'udg_Detalle
        '
        Me.udg_Detalle.DataSource = Me.odOrdenComMat
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Appearance33.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Detalle.DisplayLayout.Appearance = Appearance33
        UltraGridColumn76.Header.VisiblePosition = 0
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 1
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.Caption = "SubAlmacen"
        UltraGridColumn78.Header.VisiblePosition = 16
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.Width = 161
        UltraGridColumn79.Header.VisiblePosition = 13
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Width = 311
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn81.Header.Caption = "UM"
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn81.Width = 42
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn82.CellAppearance = Appearance34
        UltraGridColumn82.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn82.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn82.Header.VisiblePosition = 17
        UltraGridColumn82.Hidden = True
        UltraGridColumn82.Width = 269
        Appearance35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance35
        UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn83.Format = "#,###,###,##0.000"
        UltraGridColumn83.Header.VisiblePosition = 5
        UltraGridColumn83.MaskInput = "{double:9.3}"
        UltraGridColumn83.Width = 72
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance36
        Appearance37.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance37.ImageVAlign = Infragistics.Win.VAlign.Middle
        UltraGridColumn84.CellButtonAppearance = Appearance37
        UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn84.Format = "#,###,###,##0.000"
        UltraGridColumn84.Header.Caption = "Pendiente"
        UltraGridColumn84.Header.VisiblePosition = 12
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.MaskInput = "{double:9.3}"
        UltraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn84.Width = 80
        Appearance38.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance38
        UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn85.Format = "#,###,###,##0.000"
        UltraGridColumn85.Header.Caption = "Atender"
        UltraGridColumn85.Header.VisiblePosition = 14
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.MaskInput = "{double:9.3}"
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn85.Width = 80
        Appearance39.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn86.CellAppearance = Appearance39
        UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn86.Format = "#,###,###,##0.000"
        UltraGridColumn86.Header.Caption = "CostoU."
        UltraGridColumn86.Header.VisiblePosition = 7
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.MaskInput = "{double:9.3}"
        UltraGridColumn86.Width = 80
        UltraGridColumn87.Header.VisiblePosition = 27
        UltraGridColumn87.Hidden = True
        Appearance40.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance40
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn88.Format = "#,###,###,##0.000"
        UltraGridColumn88.Header.Caption = "PrecioU."
        UltraGridColumn88.Header.VisiblePosition = 8
        UltraGridColumn88.MaskInput = "{double:9.3}"
        UltraGridColumn88.Width = 80
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance41
        UltraGridColumn89.Format = "#,###,###,##0.000"
        UltraGridColumn89.Header.VisiblePosition = 10
        UltraGridColumn89.MaskInput = "{double:9.3}"
        UltraGridColumn89.Width = 80
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn90.Header.Caption = "IGV"
        UltraGridColumn90.Header.VisiblePosition = 6
        UltraGridColumn90.Hidden = True
        UltraGridColumn90.Width = 47
        UltraGridColumn91.Header.VisiblePosition = 18
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 19
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 20
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 21
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 22
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 23
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 24
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 2
        UltraGridColumn98.Hidden = True
        UltraGridColumn98.Width = 76
        UltraGridColumn99.Header.Caption = "Almacen"
        UltraGridColumn99.Header.VisiblePosition = 15
        UltraGridColumn99.Hidden = True
        UltraGridColumn99.Width = 195
        UltraGridColumn100.Header.VisiblePosition = 25
        UltraGridColumn100.Hidden = True
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn101.CellAppearance = Appearance42
        UltraGridColumn101.Header.Caption = "%Dscto"
        UltraGridColumn101.Header.VisiblePosition = 11
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn102.CellAppearance = Appearance43
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn102.Header.VisiblePosition = 9
        UltraGridColumn102.MaskInput = "{double:4.2}"
        UltraGridColumn102.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn102.Width = 59
        UltraGridColumn103.Header.VisiblePosition = 26
        UltraGridColumn103.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103})
        Me.udg_Detalle.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_Detalle.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalle.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance44.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance44.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Detalle.DisplayLayout.GroupByBox.Appearance = Appearance44
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalle.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance45
        Me.udg_Detalle.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Detalle.DisplayLayout.GroupByBox.Hidden = True
        Appearance46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance46.BackColor2 = System.Drawing.SystemColors.Control
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Detalle.DisplayLayout.GroupByBox.PromptAppearance = Appearance46
        Me.udg_Detalle.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Detalle.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Detalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Detalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Detalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Detalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Detalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Detalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Detalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Detalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.udg_Detalle.DisplayLayout.Override.RowAppearance = Appearance47
        Me.udg_Detalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Detalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Detalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Detalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Detalle.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Detalle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Detalle.Location = New System.Drawing.Point(3, 3)
        Me.udg_Detalle.Name = "udg_Detalle"
        Me.udg_Detalle.Size = New System.Drawing.Size(757, 174)
        Me.udg_Detalle.TabIndex = 1
        Me.udg_Detalle.Text = "Grilla2"
        '
        'odOrdenComMat
        '
        UltraDataColumn36.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Double)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn43.DataType = GetType(Boolean)
        UltraDataColumn54.DataType = GetType(Double)
        UltraDataColumn55.DataType = GetType(Double)
        UltraDataColumn56.DataType = GetType(Double)
        Me.odOrdenComMat.Band.Columns.AddRange(New Object() {UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'UltraGroupBox9
        '
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
        Me.UltraGroupBox9.Size = New System.Drawing.Size(570, 180)
        Me.UltraGroupBox9.TabIndex = 24
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel1
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Appearance72.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance72
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
        Me.decTotal.Location = New System.Drawing.Point(133, 88)
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
        Me.decImpuesto.Location = New System.Drawing.Point(133, 47)
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
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Appearance73.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance73
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(64, 94)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(63, 28)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Total:"
        '
        'UltraLabel7
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance74
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
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance75
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(22, 53)
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
        CType(Me.txtDireccionFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.grbCombustibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCombustibles.ResumeLayout(False)
        Me.grbCombustibles.PerformLayout()
        CType(Me.decDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPrecioTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.ugbTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbTipoPago.ResumeLayout(False)
        CType(Me.ugbTipoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ugbTipoVenta.ResumeLayout(False)
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
    Friend WithEvents ugbTipoVenta As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnDocumento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVarios As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVale As Infragistics.Win.Misc.UltraButton
    Friend WithEvents decCantidad As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decDescuento As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents decPrecio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents odOrdenComMat As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtDireccionFiscal As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnAgregarDetalle As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decPrecioTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents grbCombustibles As Infragistics.Win.Misc.UltraGroupBox
End Class
