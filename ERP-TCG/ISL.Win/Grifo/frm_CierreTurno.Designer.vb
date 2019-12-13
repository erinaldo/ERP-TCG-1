<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CierreTurno
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton3 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Empresa")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAprobacion")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TrabajadorAprobacion")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenComercial")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoExistencia")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCompra")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipoCompra")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Impuesto")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DocAsoc")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFactSer")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturado")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCantidadVariable")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenReferencia")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFacturadoProducto")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVendedorTrabajador")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griOrdenComercial = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnEliminar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAnular = New Infragistics.Win.Misc.UltraButton()
        Me.btnAtender = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox11 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorTerminado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel26 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel25 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel24 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel23 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorEvaluado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorParcial = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAtendido = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.colorAnulado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.grbNroOrden = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel19 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtNroOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.rdbNroOrden = New System.Windows.Forms.RadioButton()
        Me.rdbDatosBasicos = New System.Windows.Forms.RadioButton()
        Me.grbDatosBasicos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_TurnoBuscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel16 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_EstadoBuscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox13 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox12 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTrabajadorApertura = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnCrearCtaCte = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Turno = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtOrden = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbNumeroOrden = New Infragistics.Win.Misc.UltraLabel()
        Me.ficOrdenComercial = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_Estado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTrabajadorCierre = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.udg_Trabajadores = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_ContometroDigital = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_ContometroAnalogico = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_VentasxCombustible = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_VentasAnuladas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_Calibraciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.udg_Almacenes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cmb_TrabajadorApertura_Buscado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox11.SuspendLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNroOrden.SuspendLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatosBasicos.SuspendLayout()
        CType(Me.cmb_TurnoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_EstadoBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox13.SuspendLayout()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox12.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficOrdenComercial.SuspendLayout()
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_TrabajadorApertura_Buscado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1421, 737)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.griOrdenComercial)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 159)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1421, 578)
        Me.UltraGroupBox3.TabIndex = 5
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griOrdenComercial
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOrdenComercial.DisplayLayout.Appearance = Appearance1
        UltraGridColumn236.Header.VisiblePosition = 0
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 1
        UltraGridColumn237.Hidden = True
        UltraGridColumn238.Header.VisiblePosition = 2
        UltraGridColumn238.Hidden = True
        UltraGridColumn239.Header.VisiblePosition = 3
        UltraGridColumn239.Hidden = True
        UltraGridColumn240.Header.VisiblePosition = 6
        UltraGridColumn240.Width = 211
        UltraGridColumn241.Header.VisiblePosition = 7
        UltraGridColumn241.Hidden = True
        UltraGridColumn242.Header.VisiblePosition = 8
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 15
        UltraGridColumn243.Width = 149
        UltraGridColumn244.Header.VisiblePosition = 10
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 9
        UltraGridColumn245.Width = 65
        UltraGridColumn246.Header.VisiblePosition = 11
        UltraGridColumn246.Hidden = True
        UltraGridColumn247.Header.VisiblePosition = 18
        UltraGridColumn247.Hidden = True
        UltraGridColumn247.Width = 231
        UltraGridColumn248.Header.VisiblePosition = 5
        UltraGridColumn249.Header.VisiblePosition = 4
        UltraGridColumn249.Width = 109
        UltraGridColumn250.Header.VisiblePosition = 17
        UltraGridColumn250.Width = 75
        UltraGridColumn251.Header.VisiblePosition = 19
        UltraGridColumn251.Hidden = True
        UltraGridColumn252.Header.VisiblePosition = 27
        UltraGridColumn252.Hidden = True
        UltraGridColumn253.Header.VisiblePosition = 20
        UltraGridColumn253.Hidden = True
        UltraGridColumn253.MaskInput = "{double:9.3}"
        UltraGridColumn254.Header.VisiblePosition = 28
        UltraGridColumn254.Hidden = True
        UltraGridColumn254.MaskInput = "{double:9.3}"
        UltraGridColumn255.Header.Caption = "TipoCompra"
        UltraGridColumn255.Header.VisiblePosition = 21
        UltraGridColumn255.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn256.CellAppearance = Appearance2
        UltraGridColumn256.Format = "#,###,###,##0.00"
        UltraGridColumn256.Header.VisiblePosition = 12
        UltraGridColumn256.MaskInput = "{double:9.2}"
        UltraGridColumn256.Width = 73
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn257.CellAppearance = Appearance3
        UltraGridColumn257.Format = "#,###,###,##0.00"
        UltraGridColumn257.Header.VisiblePosition = 13
        UltraGridColumn257.MaskInput = "{double:9.2}"
        UltraGridColumn257.Width = 73
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn258.CellAppearance = Appearance4
        UltraGridColumn258.Format = "#,###,###,##0.00"
        UltraGridColumn258.Header.VisiblePosition = 14
        UltraGridColumn258.MaskInput = "{double:9.2}"
        UltraGridColumn258.Width = 74
        UltraGridColumn259.Header.VisiblePosition = 22
        UltraGridColumn259.Hidden = True
        UltraGridColumn260.Header.VisiblePosition = 23
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.Header.VisiblePosition = 24
        UltraGridColumn261.Hidden = True
        UltraGridColumn262.Header.VisiblePosition = 25
        UltraGridColumn262.Hidden = True
        UltraGridColumn263.Header.VisiblePosition = 26
        UltraGridColumn263.Hidden = True
        UltraGridColumn264.Header.VisiblePosition = 16
        UltraGridColumn264.Width = 89
        UltraGridColumn265.Header.VisiblePosition = 29
        UltraGridColumn265.Hidden = True
        UltraGridColumn266.Header.VisiblePosition = 30
        UltraGridColumn266.Hidden = True
        UltraGridColumn267.Header.VisiblePosition = 31
        UltraGridColumn267.Hidden = True
        UltraGridColumn268.Header.VisiblePosition = 32
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 33
        UltraGridColumn269.Hidden = True
        UltraGridColumn270.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn270.Header.Caption = "Vendedor"
        UltraGridColumn270.Header.VisiblePosition = 34
        UltraGridColumn270.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn270.Width = 258
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270})
        Me.griOrdenComercial.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griOrdenComercial.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.griOrdenComercial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOrdenComercial.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOrdenComercial.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.griOrdenComercial.DisplayLayout.MaxColScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOrdenComercial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOrdenComercial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOrdenComercial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOrdenComercial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOrdenComercial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOrdenComercial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Me.griOrdenComercial.DisplayLayout.Override.RowAppearance = Appearance8
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOrdenComercial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOrdenComercial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOrdenComercial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOrdenComercial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOrdenComercial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOrdenComercial.Location = New System.Drawing.Point(3, 3)
        Me.griOrdenComercial.Name = "griOrdenComercial"
        Me.griOrdenComercial.Size = New System.Drawing.Size(1415, 572)
        Me.griOrdenComercial.TabIndex = 1
        Me.griOrdenComercial.Text = "Grilla2"
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.btnEliminar)
        Me.UltraGroupBox2.Controls.Add(Me.btnAnular)
        Me.UltraGroupBox2.Controls.Add(Me.btnAtender)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 127)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1421, 32)
        Me.UltraGroupBox2.TabIndex = 4
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.btnEliminar.Appearance = Appearance9
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(177, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 26)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAnular
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.btnAnular.Appearance = Appearance10
        Me.btnAnular.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAnular.Enabled = False
        Me.btnAnular.Location = New System.Drawing.Point(90, 3)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(87, 26)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnAtender
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.btnAtender.Appearance = Appearance11
        Me.btnAtender.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAtender.Enabled = False
        Me.btnAtender.Location = New System.Drawing.Point(3, 3)
        Me.btnAtender.Name = "btnAtender"
        Me.btnAtender.Size = New System.Drawing.Size(87, 26)
        Me.btnAtender.TabIndex = 1
        Me.btnAtender.Text = "Atender"
        Me.btnAtender.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox11)
        Me.UltraGroupBox1.Controls.Add(Me.grbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbNroOrden)
        Me.UltraGroupBox1.Controls.Add(Me.rdbDatosBasicos)
        Me.UltraGroupBox1.Controls.Add(Me.grbDatosBasicos)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1421, 127)
        Me.UltraGroupBox1.TabIndex = 3
        Me.UltraGroupBox1.Text = "Buscar"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox11
        '
        Me.UltraGroupBox11.Controls.Add(Me.colorTerminado)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel26)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel25)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel24)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel23)
        Me.UltraGroupBox11.Controls.Add(Me.UltraLabel22)
        Me.UltraGroupBox11.Controls.Add(Me.colorEvaluado)
        Me.UltraGroupBox11.Controls.Add(Me.colorParcial)
        Me.UltraGroupBox11.Controls.Add(Me.colorAtendido)
        Me.UltraGroupBox11.Controls.Add(Me.colorAnulado)
        Me.UltraGroupBox11.Location = New System.Drawing.Point(413, 77)
        Me.UltraGroupBox11.Name = "UltraGroupBox11"
        Me.UltraGroupBox11.Size = New System.Drawing.Size(661, 42)
        Me.UltraGroupBox11.TabIndex = 344
        Me.UltraGroupBox11.Text = "Estados"
        Me.UltraGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorTerminado
        '
        Me.colorTerminado.Color = System.Drawing.Color.LightGreen
        Me.colorTerminado.Location = New System.Drawing.Point(602, 16)
        Me.colorTerminado.Name = "colorTerminado"
        Me.colorTerminado.Size = New System.Drawing.Size(46, 21)
        Me.colorTerminado.TabIndex = 356
        Me.colorTerminado.Text = "LightGreen"
        '
        'UltraLabel26
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.TextVAlignAsString = "Middle"
        Me.UltraLabel26.Appearance = Appearance12
        Me.UltraLabel26.AutoSize = True
        Me.UltraLabel26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel26.Location = New System.Drawing.Point(535, 20)
        Me.UltraLabel26.Name = "UltraLabel26"
        Me.UltraLabel26.Size = New System.Drawing.Size(61, 15)
        Me.UltraLabel26.TabIndex = 355
        Me.UltraLabel26.Text = "Terminada:"
        '
        'UltraLabel25
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Appearance13.TextVAlignAsString = "Middle"
        Me.UltraLabel25.Appearance = Appearance13
        Me.UltraLabel25.AutoSize = True
        Me.UltraLabel25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel25.Location = New System.Drawing.Point(429, 20)
        Me.UltraLabel25.Name = "UltraLabel25"
        Me.UltraLabel25.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel25.TabIndex = 354
        Me.UltraLabel25.Text = "Anulada:"
        '
        'UltraLabel24
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel24.Appearance = Appearance14
        Me.UltraLabel24.AutoSize = True
        Me.UltraLabel24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel24.Location = New System.Drawing.Point(319, 20)
        Me.UltraLabel24.Name = "UltraLabel24"
        Me.UltraLabel24.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel24.TabIndex = 353
        Me.UltraLabel24.Text = "Atendido:"
        '
        'UltraLabel23
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel23.Appearance = Appearance15
        Me.UltraLabel23.AutoSize = True
        Me.UltraLabel23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel23.Location = New System.Drawing.Point(141, 20)
        Me.UltraLabel23.Name = "UltraLabel23"
        Me.UltraLabel23.Size = New System.Drawing.Size(120, 15)
        Me.UltraLabel23.TabIndex = 352
        Me.UltraLabel23.Text = "Atendido Parcialmente:"
        '
        'UltraLabel22
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance16
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(27, 20)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(53, 15)
        Me.UltraLabel22.TabIndex = 351
        Me.UltraLabel22.Text = "Evaluado:"
        '
        'colorEvaluado
        '
        Me.colorEvaluado.Color = System.Drawing.Color.PaleGoldenrod
        Me.colorEvaluado.Location = New System.Drawing.Point(89, 16)
        Me.colorEvaluado.Name = "colorEvaluado"
        Me.colorEvaluado.Size = New System.Drawing.Size(46, 21)
        Me.colorEvaluado.TabIndex = 349
        Me.colorEvaluado.Text = "PaleGoldenrod"
        '
        'colorParcial
        '
        Me.colorParcial.Color = System.Drawing.Color.PaleTurquoise
        Me.colorParcial.Location = New System.Drawing.Point(267, 16)
        Me.colorParcial.Name = "colorParcial"
        Me.colorParcial.Size = New System.Drawing.Size(46, 21)
        Me.colorParcial.TabIndex = 348
        Me.colorParcial.Text = "PaleTurquoise"
        '
        'colorAtendido
        '
        Me.colorAtendido.Color = System.Drawing.Color.SandyBrown
        Me.colorAtendido.Location = New System.Drawing.Point(377, 16)
        Me.colorAtendido.Name = "colorAtendido"
        Me.colorAtendido.Size = New System.Drawing.Size(46, 21)
        Me.colorAtendido.TabIndex = 347
        Me.colorAtendido.Text = "SandyBrown"
        '
        'colorAnulado
        '
        Me.colorAnulado.Color = System.Drawing.Color.LightCoral
        Me.colorAnulado.Location = New System.Drawing.Point(483, 16)
        Me.colorAnulado.Name = "colorAnulado"
        Me.colorAnulado.Size = New System.Drawing.Size(46, 21)
        Me.colorAnulado.TabIndex = 346
        Me.colorAnulado.Text = "LightCoral"
        '
        'grbNroOrden
        '
        Me.grbNroOrden.Controls.Add(Me.UltraLabel19)
        Me.grbNroOrden.Controls.Add(Me.txtNroOrden)
        Me.grbNroOrden.Location = New System.Drawing.Point(413, 35)
        Me.grbNroOrden.Name = "grbNroOrden"
        Me.grbNroOrden.Size = New System.Drawing.Size(220, 39)
        Me.grbNroOrden.TabIndex = 343
        Me.grbNroOrden.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel19
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel19.Appearance = Appearance17
        Me.UltraLabel19.AutoSize = True
        Me.UltraLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel19.Location = New System.Drawing.Point(6, 13)
        Me.UltraLabel19.Name = "UltraLabel19"
        Me.UltraLabel19.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel19.TabIndex = 344
        Me.UltraLabel19.Text = "Orden:"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroOrden.Location = New System.Drawing.Point(51, 9)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(155, 21)
        Me.txtNroOrden.TabIndex = 0
        '
        'rdbNroOrden
        '
        Me.rdbNroOrden.AutoSize = True
        Me.rdbNroOrden.BackColor = System.Drawing.Color.Transparent
        Me.rdbNroOrden.ForeColor = System.Drawing.Color.Navy
        Me.rdbNroOrden.Location = New System.Drawing.Point(413, 18)
        Me.rdbNroOrden.Name = "rdbNroOrden"
        Me.rdbNroOrden.Size = New System.Drawing.Size(71, 17)
        Me.rdbNroOrden.TabIndex = 342
        Me.rdbNroOrden.Text = "NroOrden"
        Me.rdbNroOrden.UseVisualStyleBackColor = False
        '
        'rdbDatosBasicos
        '
        Me.rdbDatosBasicos.AutoSize = True
        Me.rdbDatosBasicos.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosBasicos.Checked = True
        Me.rdbDatosBasicos.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosBasicos.Location = New System.Drawing.Point(11, 18)
        Me.rdbDatosBasicos.Name = "rdbDatosBasicos"
        Me.rdbDatosBasicos.Size = New System.Drawing.Size(90, 17)
        Me.rdbDatosBasicos.TabIndex = 341
        Me.rdbDatosBasicos.TabStop = True
        Me.rdbDatosBasicos.Text = "DatosBasicos"
        Me.rdbDatosBasicos.UseVisualStyleBackColor = False
        '
        'grbDatosBasicos
        '
        Me.grbDatosBasicos.Controls.Add(Me.cmb_TrabajadorApertura_Buscado)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel8)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel15)
        Me.grbDatosBasicos.Controls.Add(Me.cmb_TurnoBuscado)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel16)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaInicio)
        Me.grbDatosBasicos.Controls.Add(Me.dtpFechaFin)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel14)
        Me.grbDatosBasicos.Controls.Add(Me.cmb_EstadoBuscado)
        Me.grbDatosBasicos.Controls.Add(Me.UltraLabel13)
        Me.grbDatosBasicos.Location = New System.Drawing.Point(11, 35)
        Me.grbDatosBasicos.Name = "grbDatosBasicos"
        Me.grbDatosBasicos.Size = New System.Drawing.Size(392, 84)
        Me.grbDatosBasicos.TabIndex = 340
        Me.grbDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel15
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Appearance19.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance19
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(6, 9)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel15.TabIndex = 337
        Me.UltraLabel15.Text = "Desde:"
        '
        'cmb_TurnoBuscado
        '
        Me.cmb_TurnoBuscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TurnoBuscado.Location = New System.Drawing.Point(210, 5)
        Me.cmb_TurnoBuscado.Name = "cmb_TurnoBuscado"
        Me.cmb_TurnoBuscado.Size = New System.Drawing.Size(173, 21)
        Me.cmb_TurnoBuscado.TabIndex = 0
        '
        'UltraLabel16
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel16.Appearance = Appearance20
        Me.UltraLabel16.AutoSize = True
        Me.UltraLabel16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel16.Location = New System.Drawing.Point(8, 35)
        Me.UltraLabel16.Name = "UltraLabel16"
        Me.UltraLabel16.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel16.TabIndex = 338
        Me.UltraLabel16.Text = "Hasta:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(51, 6)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(51, 32)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaFin.TabIndex = 2
        '
        'UltraLabel14
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel14.Appearance = Appearance21
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel14.Location = New System.Drawing.Point(162, 35)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel14.TabIndex = 336
        Me.UltraLabel14.Text = "Estado:"
        '
        'cmb_EstadoBuscado
        '
        Me.cmb_EstadoBuscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_EstadoBuscado.Location = New System.Drawing.Point(210, 31)
        Me.cmb_EstadoBuscado.Name = "cmb_EstadoBuscado"
        Me.cmb_EstadoBuscado.Size = New System.Drawing.Size(173, 21)
        Me.cmb_EstadoBuscado.TabIndex = 3
        Me.cmb_EstadoBuscado.ValueMember = "Id"
        '
        'UltraLabel13
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance22
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(156, 9)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel13.TabIndex = 335
        Me.UltraLabel13.Text = "Turno:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1421, 737)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox13)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox10)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox9)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox8)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox7)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox5.Controls.Add(Me.UltraGroupBox12)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 135)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1421, 602)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox13
        '
        Me.UltraGroupBox13.Controls.Add(Me.udg_Almacenes)
        Me.UltraGroupBox13.Location = New System.Drawing.Point(14, 390)
        Me.UltraGroupBox13.Name = "UltraGroupBox13"
        Me.UltraGroupBox13.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox13.TabIndex = 4
        Me.UltraGroupBox13.Text = "Almacenes"
        Me.UltraGroupBox13.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.udg_Calibraciones)
        Me.UltraGroupBox10.Location = New System.Drawing.Point(838, 198)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox10.TabIndex = 3
        Me.UltraGroupBox10.Text = "Calibraciones"
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.udg_VentasAnuladas)
        Me.UltraGroupBox9.Location = New System.Drawing.Point(423, 198)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox9.TabIndex = 2
        Me.UltraGroupBox9.Text = "Ventas Anuladas"
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.udg_VentasxCombustible)
        Me.UltraGroupBox8.Location = New System.Drawing.Point(11, 198)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox8.TabIndex = 1
        Me.UltraGroupBox8.Text = "Ventas x Combustible"
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.udg_ContometroAnalogico)
        Me.UltraGroupBox7.Location = New System.Drawing.Point(838, 6)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox7.TabIndex = 2
        Me.UltraGroupBox7.Text = "Contometro Analogico"
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.udg_ContometroDigital)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(423, 6)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox6.TabIndex = 1
        Me.UltraGroupBox6.Text = "Contometro Digital"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox12
        '
        Me.UltraGroupBox12.Controls.Add(Me.udg_Trabajadores)
        Me.UltraGroupBox12.Location = New System.Drawing.Point(11, 6)
        Me.UltraGroupBox12.Name = "UltraGroupBox12"
        Me.UltraGroupBox12.Size = New System.Drawing.Size(409, 186)
        Me.UltraGroupBox12.TabIndex = 0
        Me.UltraGroupBox12.Text = "Trabajadores"
        Me.UltraGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.cboTrabajadorCierre)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox4.Controls.Add(Me.cmb_Estado)
        Me.UltraGroupBox4.Controls.Add(Me.dtpHoraFin)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.cboTrabajadorApertura)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.btnCrearCtaCte)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox4.Controls.Add(Me.txtGlosa)
        Me.UltraGroupBox4.Controls.Add(Me.dtpHoraInicio)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox4.Controls.Add(Me.cmb_Turno)
        Me.UltraGroupBox4.Controls.Add(Me.txtOrden)
        Me.UltraGroupBox4.Controls.Add(Me.lbNumeroOrden)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1421, 135)
        Me.UltraGroupBox4.TabIndex = 0
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Enabled = False
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(459, 10)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.Size = New System.Drawing.Size(103, 20)
        Me.dtpHoraFin.TabIndex = 372
        '
        'UltraLabel1
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance81
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(430, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(23, 15)
        Me.UltraLabel1.TabIndex = 371
        Me.UltraLabel1.Text = "Fin:"
        '
        'cboTrabajadorApertura
        '
        Me.cboTrabajadorApertura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajadorApertura.ButtonsRight.Add(EditorButton3)
        Me.cboTrabajadorApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorApertura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorApertura.Location = New System.Drawing.Point(315, 36)
        Me.cboTrabajadorApertura.Name = "cboTrabajadorApertura"
        Me.cboTrabajadorApertura.Size = New System.Drawing.Size(247, 21)
        Me.cboTrabajadorApertura.TabIndex = 367
        Me.cboTrabajadorApertura.Visible = False
        '
        'UltraLabel11
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Appearance82.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance82
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(246, 41)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel11.TabIndex = 366
        Me.UltraLabel11.Text = "Trabajador:"
        Me.UltraLabel11.Visible = False
        '
        'btnCrearCtaCte
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Me.btnCrearCtaCte.Appearance = Appearance83
        Me.btnCrearCtaCte.AutoSize = True
        Me.btnCrearCtaCte.Enabled = False
        Me.btnCrearCtaCte.Location = New System.Drawing.Point(1191, 88)
        Me.btnCrearCtaCte.Name = "btnCrearCtaCte"
        Me.btnCrearCtaCte.Size = New System.Drawing.Size(10, 10)
        Me.btnCrearCtaCte.TabIndex = 28
        Me.btnCrearCtaCte.Visible = False
        '
        'UltraLabel6
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Appearance84.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance84
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(578, 10)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel6.TabIndex = 19
        Me.UltraLabel6.Text = "Glosa:"
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Location = New System.Drawing.Point(619, 6)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(258, 76)
        Me.txtGlosa.TabIndex = 20
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Enabled = False
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(315, 9)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.Size = New System.Drawing.Size(103, 20)
        Me.dtpHoraInicio.TabIndex = 16
        '
        'UltraLabel5
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Appearance85.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance85
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(274, 14)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel5.TabIndex = 15
        Me.UltraLabel5.Text = "Inicio:"
        '
        'UltraLabel3
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Appearance86.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance86
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(28, 62)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel3.TabIndex = 6
        Me.UltraLabel3.Text = "Turno:"
        '
        'UltraLabel2
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Appearance87.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance87
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(28, 36)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(72, 34)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'cmb_Turno
        '
        Me.cmb_Turno.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Turno.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmb_Turno.Location = New System.Drawing.Point(72, 59)
        Me.cmb_Turno.Name = "cmb_Turno"
        Me.cmb_Turno.Size = New System.Drawing.Size(134, 21)
        Me.cmb_Turno.TabIndex = 7
        Me.cmb_Turno.ValueMember = "Id"
        '
        'txtOrden
        '
        Me.txtOrden.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrden.Location = New System.Drawing.Point(72, 6)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.ReadOnly = True
        Me.txtOrden.Size = New System.Drawing.Size(159, 21)
        Me.txtOrden.TabIndex = 1
        '
        'lbNumeroOrden
        '
        Appearance88.BackColor = System.Drawing.Color.Transparent
        Appearance88.ForeColor = System.Drawing.Color.Navy
        Appearance88.TextVAlignAsString = "Middle"
        Me.lbNumeroOrden.Appearance = Appearance88
        Me.lbNumeroOrden.AutoSize = True
        Me.lbNumeroOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumeroOrden.Location = New System.Drawing.Point(27, 10)
        Me.lbNumeroOrden.Name = "lbNumeroOrden"
        Me.lbNumeroOrden.Size = New System.Drawing.Size(39, 15)
        Me.lbNumeroOrden.TabIndex = 0
        Me.lbNumeroOrden.Text = "Orden:"
        '
        'ficOrdenComercial
        '
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl1)
        Me.ficOrdenComercial.Controls.Add(Me.UltraTabPageControl2)
        Me.ficOrdenComercial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficOrdenComercial.Location = New System.Drawing.Point(0, 0)
        Me.ficOrdenComercial.Name = "ficOrdenComercial"
        Me.ficOrdenComercial.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficOrdenComercial.Size = New System.Drawing.Size(1423, 760)
        Me.ficOrdenComercial.TabIndex = 1
        UltraTab4.TabPage = Me.UltraTabPageControl1
        UltraTab4.Text = "Lista"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Mantenimiento"
        Me.ficOrdenComercial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.ficOrdenComercial.TabStop = False
        Me.ficOrdenComercial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1421, 737)
        '
        'UltraLabel4
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Appearance80.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance80
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(24, 90)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 374
        Me.UltraLabel4.Text = "Estado:"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_Estado.Location = New System.Drawing.Point(72, 86)
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Size = New System.Drawing.Size(134, 21)
        Me.cmb_Estado.TabIndex = 373
        Me.cmb_Estado.ValueMember = "Id"
        '
        'cboTrabajadorCierre
        '
        Me.cboTrabajadorCierre.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajadorCierre.ButtonsRight.Add(EditorButton2)
        Me.cboTrabajadorCierre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboTrabajadorCierre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorCierre.Location = New System.Drawing.Point(315, 63)
        Me.cboTrabajadorCierre.Name = "cboTrabajadorCierre"
        Me.cboTrabajadorCierre.Size = New System.Drawing.Size(247, 21)
        Me.cboTrabajadorCierre.TabIndex = 376
        Me.cboTrabajadorCierre.Visible = False
        '
        'UltraLabel7
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance79
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(246, 68)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel7.TabIndex = 375
        Me.UltraLabel7.Text = "Trabajador:"
        Me.UltraLabel7.Visible = False
        '
        'udg_Trabajadores
        '
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Appearance71.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Trabajadores.DisplayLayout.Appearance = Appearance71
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Width = 211
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 15
        UltraGridColumn8.Width = 149
        UltraGridColumn9.Header.VisiblePosition = 10
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 65
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 18
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 231
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn14.Header.VisiblePosition = 4
        UltraGridColumn14.Width = 109
        UltraGridColumn15.Header.VisiblePosition = 17
        UltraGridColumn15.Width = 75
        UltraGridColumn16.Header.VisiblePosition = 19
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 27
        UltraGridColumn17.Hidden = True
        UltraGridColumn18.Header.VisiblePosition = 20
        UltraGridColumn18.Hidden = True
        UltraGridColumn18.MaskInput = "{double:9.3}"
        UltraGridColumn19.Header.VisiblePosition = 28
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.MaskInput = "{double:9.3}"
        UltraGridColumn20.Header.Caption = "TipoCompra"
        UltraGridColumn20.Header.VisiblePosition = 21
        UltraGridColumn20.Hidden = True
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance72
        UltraGridColumn21.Format = "#,###,###,##0.00"
        UltraGridColumn21.Header.VisiblePosition = 12
        UltraGridColumn21.MaskInput = "{double:9.2}"
        UltraGridColumn21.Width = 73
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance73
        UltraGridColumn22.Format = "#,###,###,##0.00"
        UltraGridColumn22.Header.VisiblePosition = 13
        UltraGridColumn22.MaskInput = "{double:9.2}"
        UltraGridColumn22.Width = 73
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance74
        UltraGridColumn23.Format = "#,###,###,##0.00"
        UltraGridColumn23.Header.VisiblePosition = 14
        UltraGridColumn23.MaskInput = "{double:9.2}"
        UltraGridColumn23.Width = 74
        UltraGridColumn24.Header.VisiblePosition = 22
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 23
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 24
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 25
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 26
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 16
        UltraGridColumn29.Width = 89
        UltraGridColumn30.Header.VisiblePosition = 29
        UltraGridColumn30.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 30
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 31
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 32
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 33
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn60.Header.Caption = "Vendedor"
        UltraGridColumn60.Header.VisiblePosition = 34
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn60.Width = 258
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60})
        Me.udg_Trabajadores.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.udg_Trabajadores.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance75.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance75.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance75.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Appearance = Appearance75
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance76
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.Hidden = True
        Appearance77.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance77.BackColor2 = System.Drawing.SystemColors.Control
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance77.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Trabajadores.DisplayLayout.GroupByBox.PromptAppearance = Appearance77
        Me.udg_Trabajadores.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Trabajadores.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Trabajadores.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Trabajadores.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Trabajadores.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Trabajadores.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Trabajadores.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance78.BorderColor = System.Drawing.Color.Silver
        Me.udg_Trabajadores.DisplayLayout.Override.RowAppearance = Appearance78
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Trabajadores.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Trabajadores.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Trabajadores.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Trabajadores.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Trabajadores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Trabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Trabajadores.Location = New System.Drawing.Point(3, 16)
        Me.udg_Trabajadores.Name = "udg_Trabajadores"
        Me.udg_Trabajadores.Size = New System.Drawing.Size(403, 167)
        Me.udg_Trabajadores.TabIndex = 2
        Me.udg_Trabajadores.Text = "Grilla2"
        '
        'udg_ContometroDigital
        '
        Appearance63.BackColor = System.Drawing.SystemColors.Window
        Appearance63.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ContometroDigital.DisplayLayout.Appearance = Appearance63
        UltraGridColumn61.Header.VisiblePosition = 0
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 1
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 2
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 3
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 6
        UltraGridColumn65.Width = 211
        UltraGridColumn66.Header.VisiblePosition = 7
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 8
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 15
        UltraGridColumn68.Width = 149
        UltraGridColumn69.Header.VisiblePosition = 10
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 9
        UltraGridColumn70.Width = 65
        UltraGridColumn71.Header.VisiblePosition = 11
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 18
        UltraGridColumn72.Hidden = True
        UltraGridColumn72.Width = 231
        UltraGridColumn73.Header.VisiblePosition = 5
        UltraGridColumn74.Header.VisiblePosition = 4
        UltraGridColumn74.Width = 109
        UltraGridColumn75.Header.VisiblePosition = 17
        UltraGridColumn75.Width = 75
        UltraGridColumn76.Header.VisiblePosition = 19
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 27
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 20
        UltraGridColumn78.Hidden = True
        UltraGridColumn78.MaskInput = "{double:9.3}"
        UltraGridColumn79.Header.VisiblePosition = 28
        UltraGridColumn79.Hidden = True
        UltraGridColumn79.MaskInput = "{double:9.3}"
        UltraGridColumn80.Header.Caption = "TipoCompra"
        UltraGridColumn80.Header.VisiblePosition = 21
        UltraGridColumn80.Hidden = True
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn81.CellAppearance = Appearance64
        UltraGridColumn81.Format = "#,###,###,##0.00"
        UltraGridColumn81.Header.VisiblePosition = 12
        UltraGridColumn81.MaskInput = "{double:9.2}"
        UltraGridColumn81.Width = 73
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn82.CellAppearance = Appearance65
        UltraGridColumn82.Format = "#,###,###,##0.00"
        UltraGridColumn82.Header.VisiblePosition = 13
        UltraGridColumn82.MaskInput = "{double:9.2}"
        UltraGridColumn82.Width = 73
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance66
        UltraGridColumn83.Format = "#,###,###,##0.00"
        UltraGridColumn83.Header.VisiblePosition = 14
        UltraGridColumn83.MaskInput = "{double:9.2}"
        UltraGridColumn83.Width = 74
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
        UltraGridColumn89.Header.VisiblePosition = 16
        UltraGridColumn89.Width = 89
        UltraGridColumn90.Header.VisiblePosition = 29
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 30
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 31
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 32
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 33
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn95.Header.Caption = "Vendedor"
        UltraGridColumn95.Header.VisiblePosition = 34
        UltraGridColumn95.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn95.Width = 258
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95})
        Me.udg_ContometroDigital.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.udg_ContometroDigital.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance67.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance67.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance67.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance67.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Appearance = Appearance67
        Appearance68.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance68
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.Hidden = True
        Appearance69.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance69.BackColor2 = System.Drawing.SystemColors.Control
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance69.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroDigital.DisplayLayout.GroupByBox.PromptAppearance = Appearance69
        Me.udg_ContometroDigital.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroDigital.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroDigital.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroDigital.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ContometroDigital.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance70.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroDigital.DisplayLayout.Override.RowAppearance = Appearance70
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroDigital.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroDigital.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroDigital.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroDigital.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroDigital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroDigital.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroDigital.Location = New System.Drawing.Point(3, 16)
        Me.udg_ContometroDigital.Name = "udg_ContometroDigital"
        Me.udg_ContometroDigital.Size = New System.Drawing.Size(403, 167)
        Me.udg_ContometroDigital.TabIndex = 2
        Me.udg_ContometroDigital.Text = "Grilla2"
        '
        'udg_ContometroAnalogico
        '
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Appearance55.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_ContometroAnalogico.DisplayLayout.Appearance = Appearance55
        UltraGridColumn96.Header.VisiblePosition = 0
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 2
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.VisiblePosition = 3
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 6
        UltraGridColumn100.Width = 211
        UltraGridColumn101.Header.VisiblePosition = 7
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 8
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 15
        UltraGridColumn103.Width = 149
        UltraGridColumn104.Header.VisiblePosition = 10
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 9
        UltraGridColumn105.Width = 65
        UltraGridColumn106.Header.VisiblePosition = 11
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 18
        UltraGridColumn107.Hidden = True
        UltraGridColumn107.Width = 231
        UltraGridColumn108.Header.VisiblePosition = 5
        UltraGridColumn109.Header.VisiblePosition = 4
        UltraGridColumn109.Width = 109
        UltraGridColumn110.Header.VisiblePosition = 17
        UltraGridColumn110.Width = 75
        UltraGridColumn111.Header.VisiblePosition = 19
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 27
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 20
        UltraGridColumn113.Hidden = True
        UltraGridColumn113.MaskInput = "{double:9.3}"
        UltraGridColumn114.Header.VisiblePosition = 28
        UltraGridColumn114.Hidden = True
        UltraGridColumn114.MaskInput = "{double:9.3}"
        UltraGridColumn115.Header.Caption = "TipoCompra"
        UltraGridColumn115.Header.VisiblePosition = 21
        UltraGridColumn115.Hidden = True
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn116.CellAppearance = Appearance56
        UltraGridColumn116.Format = "#,###,###,##0.00"
        UltraGridColumn116.Header.VisiblePosition = 12
        UltraGridColumn116.MaskInput = "{double:9.2}"
        UltraGridColumn116.Width = 73
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn117.CellAppearance = Appearance57
        UltraGridColumn117.Format = "#,###,###,##0.00"
        UltraGridColumn117.Header.VisiblePosition = 13
        UltraGridColumn117.MaskInput = "{double:9.2}"
        UltraGridColumn117.Width = 73
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn118.CellAppearance = Appearance58
        UltraGridColumn118.Format = "#,###,###,##0.00"
        UltraGridColumn118.Header.VisiblePosition = 14
        UltraGridColumn118.MaskInput = "{double:9.2}"
        UltraGridColumn118.Width = 74
        UltraGridColumn119.Header.VisiblePosition = 22
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 23
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 24
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 25
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 26
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 16
        UltraGridColumn124.Width = 89
        UltraGridColumn125.Header.VisiblePosition = 29
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 30
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 31
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 32
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.Header.VisiblePosition = 33
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn130.Header.Caption = "Vendedor"
        UltraGridColumn130.Header.VisiblePosition = 34
        UltraGridColumn130.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn130.Width = 258
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130})
        Me.udg_ContometroAnalogico.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.udg_ContometroAnalogico.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance59.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance59.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance59.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance59.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Appearance = Appearance59
        Appearance60.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance60
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.Hidden = True
        Appearance61.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance61.BackColor2 = System.Drawing.SystemColors.Control
        Appearance61.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance61.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_ContometroAnalogico.DisplayLayout.GroupByBox.PromptAppearance = Appearance61
        Me.udg_ContometroAnalogico.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_ContometroAnalogico.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_ContometroAnalogico.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_ContometroAnalogico.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance62.BorderColor = System.Drawing.Color.Silver
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowAppearance = Appearance62
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_ContometroAnalogico.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_ContometroAnalogico.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_ContometroAnalogico.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_ContometroAnalogico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_ContometroAnalogico.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_ContometroAnalogico.Location = New System.Drawing.Point(3, 16)
        Me.udg_ContometroAnalogico.Name = "udg_ContometroAnalogico"
        Me.udg_ContometroAnalogico.Size = New System.Drawing.Size(403, 167)
        Me.udg_ContometroAnalogico.TabIndex = 2
        Me.udg_ContometroAnalogico.Text = "Grilla2"
        '
        'udg_VentasxCombustible
        '
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasxCombustible.DisplayLayout.Appearance = Appearance47
        UltraGridColumn131.Header.VisiblePosition = 0
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 1
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 2
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 3
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 6
        UltraGridColumn135.Width = 211
        UltraGridColumn136.Header.VisiblePosition = 7
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 8
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 15
        UltraGridColumn138.Width = 149
        UltraGridColumn139.Header.VisiblePosition = 10
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 9
        UltraGridColumn140.Width = 65
        UltraGridColumn141.Header.VisiblePosition = 11
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 18
        UltraGridColumn142.Hidden = True
        UltraGridColumn142.Width = 231
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn144.Header.VisiblePosition = 4
        UltraGridColumn144.Width = 109
        UltraGridColumn145.Header.VisiblePosition = 17
        UltraGridColumn145.Width = 75
        UltraGridColumn146.Header.VisiblePosition = 19
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 27
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 20
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.MaskInput = "{double:9.3}"
        UltraGridColumn149.Header.VisiblePosition = 28
        UltraGridColumn149.Hidden = True
        UltraGridColumn149.MaskInput = "{double:9.3}"
        UltraGridColumn150.Header.Caption = "TipoCompra"
        UltraGridColumn150.Header.VisiblePosition = 21
        UltraGridColumn150.Hidden = True
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn151.CellAppearance = Appearance48
        UltraGridColumn151.Format = "#,###,###,##0.00"
        UltraGridColumn151.Header.VisiblePosition = 12
        UltraGridColumn151.MaskInput = "{double:9.2}"
        UltraGridColumn151.Width = 73
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn152.CellAppearance = Appearance49
        UltraGridColumn152.Format = "#,###,###,##0.00"
        UltraGridColumn152.Header.VisiblePosition = 13
        UltraGridColumn152.MaskInput = "{double:9.2}"
        UltraGridColumn152.Width = 73
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn153.CellAppearance = Appearance50
        UltraGridColumn153.Format = "#,###,###,##0.00"
        UltraGridColumn153.Header.VisiblePosition = 14
        UltraGridColumn153.MaskInput = "{double:9.2}"
        UltraGridColumn153.Width = 74
        UltraGridColumn154.Header.VisiblePosition = 22
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 23
        UltraGridColumn155.Hidden = True
        UltraGridColumn156.Header.VisiblePosition = 24
        UltraGridColumn156.Hidden = True
        UltraGridColumn157.Header.VisiblePosition = 25
        UltraGridColumn157.Hidden = True
        UltraGridColumn158.Header.VisiblePosition = 26
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 16
        UltraGridColumn159.Width = 89
        UltraGridColumn160.Header.VisiblePosition = 29
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 30
        UltraGridColumn161.Hidden = True
        UltraGridColumn162.Header.VisiblePosition = 31
        UltraGridColumn162.Hidden = True
        UltraGridColumn163.Header.VisiblePosition = 32
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 33
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn165.Header.Caption = "Vendedor"
        UltraGridColumn165.Header.VisiblePosition = 34
        UltraGridColumn165.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn165.Width = 258
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165})
        Me.udg_VentasxCombustible.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.udg_VentasxCombustible.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance51.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance51.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance51.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Appearance = Appearance51
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance52
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.Hidden = True
        Appearance53.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance53.BackColor2 = System.Drawing.SystemColors.Control
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance53.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasxCombustible.DisplayLayout.GroupByBox.PromptAppearance = Appearance53
        Me.udg_VentasxCombustible.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasxCombustible.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasxCombustible.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasxCombustible.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_VentasxCombustible.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance54.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowAppearance = Appearance54
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasxCombustible.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasxCombustible.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasxCombustible.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasxCombustible.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasxCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasxCombustible.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasxCombustible.Location = New System.Drawing.Point(3, 16)
        Me.udg_VentasxCombustible.Name = "udg_VentasxCombustible"
        Me.udg_VentasxCombustible.Size = New System.Drawing.Size(403, 167)
        Me.udg_VentasxCombustible.TabIndex = 2
        Me.udg_VentasxCombustible.Text = "Grilla2"
        '
        'udg_VentasAnuladas
        '
        Appearance39.BackColor = System.Drawing.SystemColors.Window
        Appearance39.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_VentasAnuladas.DisplayLayout.Appearance = Appearance39
        UltraGridColumn166.Header.VisiblePosition = 0
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.Header.VisiblePosition = 1
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 2
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 3
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 6
        UltraGridColumn170.Width = 211
        UltraGridColumn171.Header.VisiblePosition = 7
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.Header.VisiblePosition = 8
        UltraGridColumn172.Hidden = True
        UltraGridColumn173.Header.VisiblePosition = 15
        UltraGridColumn173.Width = 149
        UltraGridColumn174.Header.VisiblePosition = 10
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 9
        UltraGridColumn175.Width = 65
        UltraGridColumn176.Header.VisiblePosition = 11
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 18
        UltraGridColumn177.Hidden = True
        UltraGridColumn177.Width = 231
        UltraGridColumn178.Header.VisiblePosition = 5
        UltraGridColumn179.Header.VisiblePosition = 4
        UltraGridColumn179.Width = 109
        UltraGridColumn180.Header.VisiblePosition = 17
        UltraGridColumn180.Width = 75
        UltraGridColumn181.Header.VisiblePosition = 19
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 27
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 20
        UltraGridColumn183.Hidden = True
        UltraGridColumn183.MaskInput = "{double:9.3}"
        UltraGridColumn184.Header.VisiblePosition = 28
        UltraGridColumn184.Hidden = True
        UltraGridColumn184.MaskInput = "{double:9.3}"
        UltraGridColumn185.Header.Caption = "TipoCompra"
        UltraGridColumn185.Header.VisiblePosition = 21
        UltraGridColumn185.Hidden = True
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn186.CellAppearance = Appearance40
        UltraGridColumn186.Format = "#,###,###,##0.00"
        UltraGridColumn186.Header.VisiblePosition = 12
        UltraGridColumn186.MaskInput = "{double:9.2}"
        UltraGridColumn186.Width = 73
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn187.CellAppearance = Appearance41
        UltraGridColumn187.Format = "#,###,###,##0.00"
        UltraGridColumn187.Header.VisiblePosition = 13
        UltraGridColumn187.MaskInput = "{double:9.2}"
        UltraGridColumn187.Width = 73
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn188.CellAppearance = Appearance42
        UltraGridColumn188.Format = "#,###,###,##0.00"
        UltraGridColumn188.Header.VisiblePosition = 14
        UltraGridColumn188.MaskInput = "{double:9.2}"
        UltraGridColumn188.Width = 74
        UltraGridColumn189.Header.VisiblePosition = 22
        UltraGridColumn189.Hidden = True
        UltraGridColumn190.Header.VisiblePosition = 23
        UltraGridColumn190.Hidden = True
        UltraGridColumn191.Header.VisiblePosition = 24
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 25
        UltraGridColumn192.Hidden = True
        UltraGridColumn193.Header.VisiblePosition = 26
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 16
        UltraGridColumn194.Width = 89
        UltraGridColumn195.Header.VisiblePosition = 29
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 30
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.VisiblePosition = 31
        UltraGridColumn197.Hidden = True
        UltraGridColumn198.Header.VisiblePosition = 32
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.VisiblePosition = 33
        UltraGridColumn199.Hidden = True
        UltraGridColumn200.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn200.Header.Caption = "Vendedor"
        UltraGridColumn200.Header.VisiblePosition = 34
        UltraGridColumn200.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn200.Width = 258
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200})
        Me.udg_VentasAnuladas.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.udg_VentasAnuladas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance43.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance43.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance43.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance43.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Appearance = Appearance43
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance44
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.Hidden = True
        Appearance45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance45.BackColor2 = System.Drawing.SystemColors.Control
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_VentasAnuladas.DisplayLayout.GroupByBox.PromptAppearance = Appearance45
        Me.udg_VentasAnuladas.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_VentasAnuladas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_VentasAnuladas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_VentasAnuladas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_VentasAnuladas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance46.BorderColor = System.Drawing.Color.Silver
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowAppearance = Appearance46
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_VentasAnuladas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_VentasAnuladas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_VentasAnuladas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_VentasAnuladas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_VentasAnuladas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_VentasAnuladas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_VentasAnuladas.Location = New System.Drawing.Point(3, 16)
        Me.udg_VentasAnuladas.Name = "udg_VentasAnuladas"
        Me.udg_VentasAnuladas.Size = New System.Drawing.Size(403, 167)
        Me.udg_VentasAnuladas.TabIndex = 2
        Me.udg_VentasAnuladas.Text = "Grilla2"
        '
        'udg_Calibraciones
        '
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Appearance31.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Calibraciones.DisplayLayout.Appearance = Appearance31
        UltraGridColumn201.Header.VisiblePosition = 0
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 1
        UltraGridColumn202.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 2
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 3
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 6
        UltraGridColumn205.Width = 211
        UltraGridColumn206.Header.VisiblePosition = 7
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 8
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 15
        UltraGridColumn208.Width = 149
        UltraGridColumn209.Header.VisiblePosition = 10
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 9
        UltraGridColumn210.Width = 65
        UltraGridColumn211.Header.VisiblePosition = 11
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 18
        UltraGridColumn212.Hidden = True
        UltraGridColumn212.Width = 231
        UltraGridColumn213.Header.VisiblePosition = 5
        UltraGridColumn214.Header.VisiblePosition = 4
        UltraGridColumn214.Width = 109
        UltraGridColumn215.Header.VisiblePosition = 17
        UltraGridColumn215.Width = 75
        UltraGridColumn216.Header.VisiblePosition = 19
        UltraGridColumn216.Hidden = True
        UltraGridColumn217.Header.VisiblePosition = 27
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 20
        UltraGridColumn218.Hidden = True
        UltraGridColumn218.MaskInput = "{double:9.3}"
        UltraGridColumn219.Header.VisiblePosition = 28
        UltraGridColumn219.Hidden = True
        UltraGridColumn219.MaskInput = "{double:9.3}"
        UltraGridColumn220.Header.Caption = "TipoCompra"
        UltraGridColumn220.Header.VisiblePosition = 21
        UltraGridColumn220.Hidden = True
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn221.CellAppearance = Appearance32
        UltraGridColumn221.Format = "#,###,###,##0.00"
        UltraGridColumn221.Header.VisiblePosition = 12
        UltraGridColumn221.MaskInput = "{double:9.2}"
        UltraGridColumn221.Width = 73
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn222.CellAppearance = Appearance33
        UltraGridColumn222.Format = "#,###,###,##0.00"
        UltraGridColumn222.Header.VisiblePosition = 13
        UltraGridColumn222.MaskInput = "{double:9.2}"
        UltraGridColumn222.Width = 73
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn223.CellAppearance = Appearance34
        UltraGridColumn223.Format = "#,###,###,##0.00"
        UltraGridColumn223.Header.VisiblePosition = 14
        UltraGridColumn223.MaskInput = "{double:9.2}"
        UltraGridColumn223.Width = 74
        UltraGridColumn224.Header.VisiblePosition = 22
        UltraGridColumn224.Hidden = True
        UltraGridColumn225.Header.VisiblePosition = 23
        UltraGridColumn225.Hidden = True
        UltraGridColumn226.Header.VisiblePosition = 24
        UltraGridColumn226.Hidden = True
        UltraGridColumn227.Header.VisiblePosition = 25
        UltraGridColumn227.Hidden = True
        UltraGridColumn228.Header.VisiblePosition = 26
        UltraGridColumn228.Hidden = True
        UltraGridColumn229.Header.VisiblePosition = 16
        UltraGridColumn229.Width = 89
        UltraGridColumn230.Header.VisiblePosition = 29
        UltraGridColumn230.Hidden = True
        UltraGridColumn231.Header.VisiblePosition = 30
        UltraGridColumn231.Hidden = True
        UltraGridColumn232.Header.VisiblePosition = 31
        UltraGridColumn232.Hidden = True
        UltraGridColumn233.Header.VisiblePosition = 32
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 33
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn235.Header.Caption = "Vendedor"
        UltraGridColumn235.Header.VisiblePosition = 34
        UltraGridColumn235.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn235.Width = 258
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216, UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235})
        Me.udg_Calibraciones.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.udg_Calibraciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance35.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance35.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance35.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance35.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Appearance = Appearance35
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance36
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.Hidden = True
        Appearance37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance37.BackColor2 = System.Drawing.SystemColors.Control
        Appearance37.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance37.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Calibraciones.DisplayLayout.GroupByBox.PromptAppearance = Appearance37
        Me.udg_Calibraciones.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Calibraciones.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Calibraciones.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Calibraciones.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Calibraciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Calibraciones.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Calibraciones.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.udg_Calibraciones.DisplayLayout.Override.RowAppearance = Appearance38
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Calibraciones.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Calibraciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Calibraciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Calibraciones.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Calibraciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Calibraciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Calibraciones.Location = New System.Drawing.Point(3, 16)
        Me.udg_Calibraciones.Name = "udg_Calibraciones"
        Me.udg_Calibraciones.Size = New System.Drawing.Size(403, 167)
        Me.udg_Calibraciones.TabIndex = 2
        Me.udg_Calibraciones.Text = "Grilla2"
        '
        'udg_Almacenes
        '
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Almacenes.DisplayLayout.Appearance = Appearance23
        UltraGridColumn297.Header.VisiblePosition = 0
        UltraGridColumn297.Hidden = True
        UltraGridColumn298.Header.VisiblePosition = 1
        UltraGridColumn298.Hidden = True
        UltraGridColumn299.Header.VisiblePosition = 2
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 3
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.Header.VisiblePosition = 6
        UltraGridColumn301.Width = 211
        UltraGridColumn302.Header.VisiblePosition = 7
        UltraGridColumn302.Hidden = True
        UltraGridColumn303.Header.VisiblePosition = 8
        UltraGridColumn303.Hidden = True
        UltraGridColumn304.Header.VisiblePosition = 15
        UltraGridColumn304.Width = 149
        UltraGridColumn305.Header.VisiblePosition = 10
        UltraGridColumn305.Hidden = True
        UltraGridColumn306.Header.VisiblePosition = 9
        UltraGridColumn306.Width = 65
        UltraGridColumn307.Header.VisiblePosition = 11
        UltraGridColumn307.Hidden = True
        UltraGridColumn308.Header.VisiblePosition = 18
        UltraGridColumn308.Hidden = True
        UltraGridColumn308.Width = 231
        UltraGridColumn309.Header.VisiblePosition = 5
        UltraGridColumn310.Header.VisiblePosition = 4
        UltraGridColumn310.Width = 109
        UltraGridColumn311.Header.VisiblePosition = 17
        UltraGridColumn311.Width = 75
        UltraGridColumn312.Header.VisiblePosition = 19
        UltraGridColumn312.Hidden = True
        UltraGridColumn313.Header.VisiblePosition = 27
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.Header.VisiblePosition = 20
        UltraGridColumn314.Hidden = True
        UltraGridColumn314.MaskInput = "{double:9.3}"
        UltraGridColumn315.Header.VisiblePosition = 28
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.MaskInput = "{double:9.3}"
        UltraGridColumn316.Header.Caption = "TipoCompra"
        UltraGridColumn316.Header.VisiblePosition = 21
        UltraGridColumn316.Hidden = True
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn317.CellAppearance = Appearance24
        UltraGridColumn317.Format = "#,###,###,##0.00"
        UltraGridColumn317.Header.VisiblePosition = 12
        UltraGridColumn317.MaskInput = "{double:9.2}"
        UltraGridColumn317.Width = 73
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn318.CellAppearance = Appearance25
        UltraGridColumn318.Format = "#,###,###,##0.00"
        UltraGridColumn318.Header.VisiblePosition = 13
        UltraGridColumn318.MaskInput = "{double:9.2}"
        UltraGridColumn318.Width = 73
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn319.CellAppearance = Appearance26
        UltraGridColumn319.Format = "#,###,###,##0.00"
        UltraGridColumn319.Header.VisiblePosition = 14
        UltraGridColumn319.MaskInput = "{double:9.2}"
        UltraGridColumn319.Width = 74
        UltraGridColumn320.Header.VisiblePosition = 22
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.Header.VisiblePosition = 23
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 24
        UltraGridColumn322.Hidden = True
        UltraGridColumn323.Header.VisiblePosition = 25
        UltraGridColumn323.Hidden = True
        UltraGridColumn324.Header.VisiblePosition = 26
        UltraGridColumn324.Hidden = True
        UltraGridColumn325.Header.VisiblePosition = 16
        UltraGridColumn325.Width = 89
        UltraGridColumn326.Header.VisiblePosition = 29
        UltraGridColumn326.Hidden = True
        UltraGridColumn327.Header.VisiblePosition = 30
        UltraGridColumn327.Hidden = True
        UltraGridColumn328.Header.VisiblePosition = 31
        UltraGridColumn328.Hidden = True
        UltraGridColumn329.Header.VisiblePosition = 32
        UltraGridColumn329.Hidden = True
        UltraGridColumn330.Header.VisiblePosition = 33
        UltraGridColumn330.Hidden = True
        UltraGridColumn331.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn331.Header.Caption = "Vendedor"
        UltraGridColumn331.Header.VisiblePosition = 34
        UltraGridColumn331.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList
        UltraGridColumn331.Width = 258
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331})
        Me.udg_Almacenes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_Almacenes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Almacenes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance27.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance27.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance27.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Appearance = Appearance27
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance28
        Me.udg_Almacenes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Almacenes.DisplayLayout.GroupByBox.Hidden = True
        Appearance29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance29.BackColor2 = System.Drawing.SystemColors.Control
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance29.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Almacenes.DisplayLayout.GroupByBox.PromptAppearance = Appearance29
        Me.udg_Almacenes.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Almacenes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Almacenes.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Almacenes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.udg_Almacenes.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Almacenes.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Almacenes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Me.udg_Almacenes.DisplayLayout.Override.RowAppearance = Appearance30
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Almacenes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Almacenes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Almacenes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Almacenes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Almacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Almacenes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Almacenes.Location = New System.Drawing.Point(3, 16)
        Me.udg_Almacenes.Name = "udg_Almacenes"
        Me.udg_Almacenes.Size = New System.Drawing.Size(403, 167)
        Me.udg_Almacenes.TabIndex = 2
        Me.udg_Almacenes.Text = "Grilla2"
        '
        'cmb_TrabajadorApertura_Buscado
        '
        Me.cmb_TrabajadorApertura_Buscado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmb_TrabajadorApertura_Buscado.ButtonsRight.Add(EditorButton1)
        Me.cmb_TrabajadorApertura_Buscado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmb_TrabajadorApertura_Buscado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmb_TrabajadorApertura_Buscado.Location = New System.Drawing.Point(79, 57)
        Me.cmb_TrabajadorApertura_Buscado.Name = "cmb_TrabajadorApertura_Buscado"
        Me.cmb_TrabajadorApertura_Buscado.Size = New System.Drawing.Size(247, 21)
        Me.cmb_TrabajadorApertura_Buscado.TabIndex = 369
        Me.cmb_TrabajadorApertura_Buscado.Visible = False
        '
        'UltraLabel8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance18
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(10, 62)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(63, 15)
        Me.UltraLabel8.TabIndex = 368
        Me.UltraLabel8.Text = "Trabajador:"
        Me.UltraLabel8.Visible = False
        '
        'frm_CierreTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1423, 760)
        Me.Controls.Add(Me.ficOrdenComercial)
        Me.Name = "frm_CierreTurno"
        Me.Text = "frm_CierreTurno"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.griOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox11.ResumeLayout(False)
        Me.UltraGroupBox11.PerformLayout()
        CType(Me.colorTerminado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorEvaluado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAtendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNroOrden.ResumeLayout(False)
        Me.grbNroOrden.PerformLayout()
        CType(Me.txtNroOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grbDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatosBasicos.ResumeLayout(False)
        Me.grbDatosBasicos.PerformLayout()
        CType(Me.cmb_TurnoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_EstadoBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.UltraGroupBox13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox13.ResumeLayout(False)
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.UltraGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox12.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.cboTrabajadorApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Turno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficOrdenComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficOrdenComercial.ResumeLayout(False)
        CType(Me.cmb_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorCierre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_Trabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_ContometroDigital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_ContometroAnalogico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_VentasxCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_VentasAnuladas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_Calibraciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udg_Almacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_TrabajadorApertura_Buscado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ficOrdenComercial As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griOrdenComercial As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnEliminar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAnular As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAtender As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox11 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents colorTerminado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel26 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel25 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel24 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel23 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorEvaluado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorParcial As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAtendido As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents colorAnulado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents grbNroOrden As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel19 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtNroOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents rdbNroOrden As RadioButton
    Friend WithEvents rdbDatosBasicos As RadioButton
    Friend WithEvents grbDatosBasicos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_TurnoBuscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel16 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_EstadoBuscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox12 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboTrabajadorApertura As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCrearCtaCte As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpHoraInicio As DateTimePicker
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmb_Turno As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents txtOrden As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbNumeroOrden As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox13 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpHoraFin As DateTimePicker
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Estado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTrabajadorCierre As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents udg_Almacenes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_Calibraciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_VentasAnuladas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_VentasxCombustible As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_ContometroAnalogico As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_ContometroDigital As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udg_Trabajadores As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmb_TrabajadorApertura_Buscado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
End Class
