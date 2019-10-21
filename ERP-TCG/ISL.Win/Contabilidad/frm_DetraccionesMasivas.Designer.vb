<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DetraccionesMasivas
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
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetraccion")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCte_ProAdq")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProveedor")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroProforma")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOperacion")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDocumento")
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOpe")
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBien")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoGasto")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDetraccion")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoBien")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteProveedor")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCtaCte_ProAdq")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteProveedor")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroProforma")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoOperacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RUC")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalDocumento")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoOpe")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoBien")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoGasto")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetraccion")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCte_ProAdq")
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProveedor")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroProforma")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOperacion")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDocumento")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOpe")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBien")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoGasto")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetraccion")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCte_ProAdq")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProveedor")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroProforma")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOperacion")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDocumento")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOpe")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBien")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoGasto")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetraccion")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCtaCte_ProAdq")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteProveedor")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroProforma")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoOperacion")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalDocumento")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoOpe")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoBien")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoGasto")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
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
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAdquirienteProveedor")
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLote")
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdquirienteProveedor")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RUC")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreTipo")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPeriodo")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAdquirienteProveedor")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLote")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdquirienteProveedor")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RUC")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreTipo")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPeriodo")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAdquiriente = New ISL.Controles.Grilla(Me.components)
        Me.udsDetraccionDetalle = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griPagoAdq = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiPeriodo = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPeriodoAdq = New ISL.Controles.Fecha(Me.components)
        Me.cboCtaBancariaSolesAdq = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griProveedor = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox9 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griPagoPro = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox10 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPeriodoPro = New ISL.Controles.Fecha(Me.components)
        Me.cboCtaBancariaDolaresPro = New ISL.Controles.Combo(Me.components)
        Me.cboCtaBancariaSolesPro = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griDetraccion = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.udsDetraccion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraColorPicker3 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraColorPicker2 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraColorPicker1 = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetAdq = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnAsiento = New Infragistics.Win.Misc.UltraButton()
        Me.numTCAdq = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.btnGenArchivo = New Infragistics.Win.Misc.UltraButton()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.numImporteAdq = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtLoteAdq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRazonSocialAdq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRucAdq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox8 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ficDetPro = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnGenPagoPro = New Infragistics.Win.Misc.UltraButton()
        Me.numTCPro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnGuardarPro = New Infragistics.Win.Misc.UltraButton()
        Me.btnGenArchPro = New Infragistics.Win.Misc.UltraButton()
        Me.btnConsultarPro = New Infragistics.Win.Misc.UltraButton()
        Me.numImportePro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtNroLotePro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRazonSocialPro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtRucPro = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ficDetraccion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griAdquiriente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsDetraccionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.griPagoAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.fecPeriodoAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancariaSolesAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox9.SuspendLayout()
        CType(Me.griPagoPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox10.SuspendLayout()
        CType(Me.fecPeriodoPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancariaDolaresPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCtaBancariaSolesPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.griDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.udsDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraColorPicker3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraColorPicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ficDetAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetAdq.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.numTCAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImporteAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoteAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocialAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucAdq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox8.SuspendLayout()
        CType(Me.ficDetPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetPro.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.numTCPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numImportePro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroLotePro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocialPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRucPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetraccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griAdquiriente)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1112, 269)
        '
        'griAdquiriente
        '
        Me.griAdquiriente.DataSource = Me.udsDetraccionDetalle
        UltraGridColumn249.Header.VisiblePosition = 0
        UltraGridColumn249.Hidden = True
        UltraGridColumn250.Header.VisiblePosition = 18
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.Caption = "Bien"
        UltraGridColumn251.Header.VisiblePosition = 4
        UltraGridColumn251.Width = 189
        UltraGridColumn252.Header.VisiblePosition = 6
        UltraGridColumn252.Hidden = True
        UltraGridColumn253.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn253.Header.Caption = "Cta Corriente"
        UltraGridColumn253.Header.VisiblePosition = 5
        UltraGridColumn253.Width = 81
        UltraGridColumn254.Header.VisiblePosition = 2
        UltraGridColumn254.Width = 225
        UltraGridColumn255.Header.VisiblePosition = 3
        UltraGridColumn255.Width = 73
        UltraGridColumn256.Header.Caption = "Operacion"
        UltraGridColumn256.Header.VisiblePosition = 8
        UltraGridColumn256.Width = 177
        UltraGridColumn257.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn257.Header.Caption = "TipoDoc"
        UltraGridColumn257.Header.VisiblePosition = 10
        UltraGridColumn257.Width = 50
        UltraGridColumn258.Header.VisiblePosition = 11
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 12
        UltraGridColumn259.Width = 37
        UltraGridColumn260.Header.VisiblePosition = 13
        UltraGridColumn261.Header.VisiblePosition = 1
        UltraGridColumn261.Width = 86
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn262.CellAppearance = Appearance1
        UltraGridColumn262.Format = "#,###,###,##0.00"
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn262.Header.Appearance = Appearance2
        UltraGridColumn262.Header.VisiblePosition = 7
        UltraGridColumn262.MaskInput = "{double:9.2}"
        UltraGridColumn262.Width = 73
        UltraGridColumn263.Header.VisiblePosition = 14
        UltraGridColumn263.Hidden = True
        UltraGridColumn264.Header.VisiblePosition = 15
        UltraGridColumn264.Hidden = True
        UltraGridColumn265.Header.VisiblePosition = 16
        UltraGridColumn265.Hidden = True
        UltraGridColumn266.Header.VisiblePosition = 17
        UltraGridColumn266.Hidden = True
        UltraGridColumn267.Header.VisiblePosition = 19
        UltraGridColumn267.Hidden = True
        UltraGridColumn268.Header.VisiblePosition = 20
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 9
        UltraGridColumn269.Width = 48
        UltraGridColumn270.Header.VisiblePosition = 21
        UltraGridColumn270.Hidden = True
        UltraGridColumn271.Header.VisiblePosition = 22
        UltraGridColumn271.Hidden = True
        UltraGridColumn272.Header.VisiblePosition = 23
        UltraGridColumn272.Hidden = True
        UltraGridColumn273.Header.VisiblePosition = 24
        UltraGridColumn273.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270, UltraGridColumn271, UltraGridColumn272, UltraGridColumn273})
        Me.griAdquiriente.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griAdquiriente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.griAdquiriente.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAdquiriente.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.griAdquiriente.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAdquiriente.DisplayLayout.GroupByBox.Hidden = True
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griAdquiriente.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.griAdquiriente.DisplayLayout.MaxColScrollRegions = 1
        Me.griAdquiriente.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAdquiriente.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAdquiriente.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAdquiriente.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griAdquiriente.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance6.BorderColor = System.Drawing.Color.Silver
        Me.griAdquiriente.DisplayLayout.Override.CellAppearance = Appearance6
        Me.griAdquiriente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griAdquiriente.DisplayLayout.Override.CellPadding = 0
        Me.griAdquiriente.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAdquiriente.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griAdquiriente.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griAdquiriente.DisplayLayout.Override.GroupByRowAppearance = Appearance7
        Appearance8.TextHAlignAsString = "Left"
        Me.griAdquiriente.DisplayLayout.Override.HeaderAppearance = Appearance8
        Me.griAdquiriente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance9.BorderColor = System.Drawing.Color.Silver
        Me.griAdquiriente.DisplayLayout.Override.RowAppearance = Appearance9
        Me.griAdquiriente.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAdquiriente.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAdquiriente.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAdquiriente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAdquiriente.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAdquiriente.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAdquiriente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAdquiriente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAdquiriente.Location = New System.Drawing.Point(0, 0)
        Me.griAdquiriente.Name = "griAdquiriente"
        Me.griAdquiriente.Size = New System.Drawing.Size(1112, 269)
        Me.griAdquiriente.TabIndex = 2
        Me.griAdquiriente.TabStop = False
        Me.griAdquiriente.Text = "Grilla1"
        '
        'udsDetraccionDetalle
        '
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Date)
        Me.udsDetraccionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25})
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl4.Enabled = False
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1112, 269)
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.griPagoAdq)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 33)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1112, 236)
        Me.UltraGroupBox6.TabIndex = 5
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPagoAdq
        '
        Me.griPagoAdq.DataSource = Me.udsDetraccionDetalle
        UltraGridColumn274.Header.VisiblePosition = 0
        UltraGridColumn274.Hidden = True
        UltraGridColumn275.Header.VisiblePosition = 18
        UltraGridColumn275.Hidden = True
        UltraGridColumn276.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn276.Header.Caption = "Bien"
        UltraGridColumn276.Header.VisiblePosition = 4
        UltraGridColumn276.Width = 189
        UltraGridColumn277.Header.VisiblePosition = 6
        UltraGridColumn277.Hidden = True
        UltraGridColumn278.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn278.Header.Caption = "Cta Corriente"
        UltraGridColumn278.Header.VisiblePosition = 5
        UltraGridColumn278.Width = 81
        UltraGridColumn279.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn279.Header.VisiblePosition = 2
        UltraGridColumn279.Width = 225
        UltraGridColumn280.Header.VisiblePosition = 3
        UltraGridColumn280.Hidden = True
        UltraGridColumn280.Width = 73
        UltraGridColumn281.Header.Caption = "Operacion"
        UltraGridColumn281.Header.VisiblePosition = 8
        UltraGridColumn281.Hidden = True
        UltraGridColumn281.Width = 177
        UltraGridColumn282.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn282.Header.Caption = "TipoDoc"
        UltraGridColumn282.Header.VisiblePosition = 10
        UltraGridColumn282.Hidden = True
        UltraGridColumn282.Width = 50
        UltraGridColumn283.Header.VisiblePosition = 11
        UltraGridColumn283.Hidden = True
        UltraGridColumn284.Header.VisiblePosition = 12
        UltraGridColumn284.Hidden = True
        UltraGridColumn284.Width = 37
        UltraGridColumn285.Header.VisiblePosition = 13
        UltraGridColumn285.Hidden = True
        UltraGridColumn286.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn286.Header.VisiblePosition = 1
        UltraGridColumn286.Width = 86
        UltraGridColumn287.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn287.CellAppearance = Appearance10
        UltraGridColumn287.Format = "#,###,###,##0.00"
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn287.Header.Appearance = Appearance11
        UltraGridColumn287.Header.VisiblePosition = 7
        UltraGridColumn287.MaskInput = "{double:9.2}"
        UltraGridColumn287.Width = 73
        UltraGridColumn288.Header.VisiblePosition = 14
        UltraGridColumn288.Hidden = True
        UltraGridColumn289.Header.VisiblePosition = 15
        UltraGridColumn289.Hidden = True
        UltraGridColumn290.Header.VisiblePosition = 16
        UltraGridColumn290.Hidden = True
        UltraGridColumn291.Header.VisiblePosition = 17
        UltraGridColumn291.Hidden = True
        UltraGridColumn292.Header.VisiblePosition = 19
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.Header.VisiblePosition = 20
        UltraGridColumn293.Hidden = True
        UltraGridColumn294.Header.VisiblePosition = 9
        UltraGridColumn294.Hidden = True
        UltraGridColumn294.Width = 48
        UltraGridColumn295.Header.VisiblePosition = 21
        UltraGridColumn295.Hidden = True
        UltraGridColumn296.Header.Caption = "TipoGasto"
        UltraGridColumn296.Header.VisiblePosition = 22
        UltraGridColumn296.Width = 281
        UltraGridColumn297.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn297.Header.VisiblePosition = 23
        UltraGridColumn297.MaxLength = 8
        UltraGridColumn298.Header.VisiblePosition = 24
        UltraGridColumn298.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298})
        Me.griPagoAdq.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griPagoAdq.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griPagoAdq.DisplayLayout.GroupByBox.Appearance = Appearance12
        Appearance13.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPagoAdq.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance13
        Me.griPagoAdq.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPagoAdq.DisplayLayout.GroupByBox.Hidden = True
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance14.BackColor2 = System.Drawing.SystemColors.Control
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance14.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPagoAdq.DisplayLayout.GroupByBox.PromptAppearance = Appearance14
        Me.griPagoAdq.DisplayLayout.MaxColScrollRegions = 1
        Me.griPagoAdq.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPagoAdq.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPagoAdq.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPagoAdq.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPagoAdq.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance15.BorderColor = System.Drawing.Color.Silver
        Me.griPagoAdq.DisplayLayout.Override.CellAppearance = Appearance15
        Me.griPagoAdq.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPagoAdq.DisplayLayout.Override.CellPadding = 0
        Me.griPagoAdq.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPagoAdq.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griPagoAdq.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPagoAdq.DisplayLayout.Override.GroupByRowAppearance = Appearance16
        Appearance17.TextHAlignAsString = "Left"
        Me.griPagoAdq.DisplayLayout.Override.HeaderAppearance = Appearance17
        Me.griPagoAdq.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance18.BorderColor = System.Drawing.Color.Silver
        Me.griPagoAdq.DisplayLayout.Override.RowAppearance = Appearance18
        Me.griPagoAdq.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPagoAdq.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPagoAdq.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPagoAdq.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPagoAdq.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPagoAdq.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPagoAdq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPagoAdq.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPagoAdq.Location = New System.Drawing.Point(3, 3)
        Me.griPagoAdq.Name = "griPagoAdq"
        Me.griPagoAdq.Size = New System.Drawing.Size(1106, 230)
        Me.griPagoAdq.TabIndex = 3
        Me.griPagoAdq.TabStop = False
        Me.griPagoAdq.Text = "Grilla1"
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox5.Controls.Add(Me.etiPeriodo)
        Me.UltraGroupBox5.Controls.Add(Me.fecPeriodoAdq)
        Me.UltraGroupBox5.Controls.Add(Me.cboCtaBancariaSolesAdq)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1112, 33)
        Me.UltraGroupBox5.TabIndex = 4
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance19
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(130, 10)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta1.TabIndex = 14
        Me.Etiqueta1.Text = "Cta S/:"
        '
        'etiPeriodo
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.etiPeriodo.Appearance = Appearance20
        Me.etiPeriodo.AutoSize = True
        Me.etiPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPeriodo.ForeColor = System.Drawing.Color.Black
        Me.etiPeriodo.Location = New System.Drawing.Point(7, 9)
        Me.etiPeriodo.Name = "etiPeriodo"
        Me.etiPeriodo.Size = New System.Drawing.Size(45, 14)
        Me.etiPeriodo.TabIndex = 12
        Me.etiPeriodo.Text = "Periodo:"
        '
        'fecPeriodoAdq
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodoAdq.Appearance = Appearance21
        Me.fecPeriodoAdq.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fecPeriodoAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodoAdq.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodoAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecPeriodoAdq.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodoAdq.Location = New System.Drawing.Point(58, 6)
        Me.fecPeriodoAdq.MaskInput = "mm/yyyy"
        Me.fecPeriodoAdq.Name = "fecPeriodoAdq"
        Me.fecPeriodoAdq.Size = New System.Drawing.Size(66, 21)
        Me.fecPeriodoAdq.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodoAdq.TabIndex = 13
        Me.fecPeriodoAdq.TabStop = False
        Me.fecPeriodoAdq.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        '
        'cboCtaBancariaSolesAdq
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaSolesAdq.Appearance = Appearance22
        Me.cboCtaBancariaSolesAdq.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancariaSolesAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancariaSolesAdq.DropDownListWidth = 400
        Me.cboCtaBancariaSolesAdq.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancariaSolesAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancariaSolesAdq.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaSolesAdq.Location = New System.Drawing.Point(173, 6)
        Me.cboCtaBancariaSolesAdq.Name = "cboCtaBancariaSolesAdq"
        Me.cboCtaBancariaSolesAdq.Size = New System.Drawing.Size(352, 21)
        Me.cboCtaBancariaSolesAdq.TabIndex = 10
        Me.cboCtaBancariaSolesAdq.ValueMember = "Id"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griProveedor)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1112, 269)
        '
        'griProveedor
        '
        Me.griProveedor.DataSource = Me.udsDetraccionDetalle
        UltraGridColumn299.Header.VisiblePosition = 0
        UltraGridColumn299.Hidden = True
        UltraGridColumn300.Header.VisiblePosition = 18
        UltraGridColumn300.Hidden = True
        UltraGridColumn301.Header.Caption = "Bien"
        UltraGridColumn301.Header.VisiblePosition = 4
        UltraGridColumn301.Width = 189
        UltraGridColumn302.Header.VisiblePosition = 6
        UltraGridColumn302.Hidden = True
        UltraGridColumn303.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn303.Header.Caption = "Cta Corriente"
        UltraGridColumn303.Header.VisiblePosition = 5
        UltraGridColumn303.Width = 81
        UltraGridColumn304.Header.VisiblePosition = 2
        UltraGridColumn304.Width = 225
        UltraGridColumn305.Header.VisiblePosition = 3
        UltraGridColumn305.Width = 73
        UltraGridColumn306.Header.Caption = "Operacion"
        UltraGridColumn306.Header.VisiblePosition = 8
        UltraGridColumn306.Width = 177
        UltraGridColumn307.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn307.Header.Caption = "TipoDoc"
        UltraGridColumn307.Header.VisiblePosition = 10
        UltraGridColumn307.Width = 50
        UltraGridColumn308.Header.VisiblePosition = 11
        UltraGridColumn308.Hidden = True
        UltraGridColumn309.Header.VisiblePosition = 12
        UltraGridColumn309.Width = 37
        UltraGridColumn310.Header.VisiblePosition = 13
        UltraGridColumn311.Header.VisiblePosition = 1
        UltraGridColumn311.Width = 86
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn312.CellAppearance = Appearance23
        UltraGridColumn312.Format = "#,###,###,##0.00"
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn312.Header.Appearance = Appearance24
        UltraGridColumn312.Header.VisiblePosition = 7
        UltraGridColumn312.MaskInput = "{double:9.2}"
        UltraGridColumn312.Width = 73
        UltraGridColumn313.Header.VisiblePosition = 14
        UltraGridColumn313.Hidden = True
        UltraGridColumn314.Header.VisiblePosition = 15
        UltraGridColumn314.Hidden = True
        UltraGridColumn315.Header.VisiblePosition = 16
        UltraGridColumn315.Hidden = True
        UltraGridColumn316.Header.VisiblePosition = 17
        UltraGridColumn316.Hidden = True
        UltraGridColumn317.Header.VisiblePosition = 19
        UltraGridColumn317.Hidden = True
        UltraGridColumn318.Header.VisiblePosition = 20
        UltraGridColumn318.Hidden = True
        UltraGridColumn319.Header.VisiblePosition = 9
        UltraGridColumn319.Width = 48
        UltraGridColumn320.Header.VisiblePosition = 21
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.Header.VisiblePosition = 22
        UltraGridColumn321.Hidden = True
        UltraGridColumn322.Header.VisiblePosition = 23
        UltraGridColumn322.Hidden = True
        UltraGridColumn323.Header.VisiblePosition = 24
        UltraGridColumn323.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323})
        Me.griProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.griProveedor.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griProveedor.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.griProveedor.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griProveedor.DisplayLayout.GroupByBox.Hidden = True
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griProveedor.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.griProveedor.DisplayLayout.MaxColScrollRegions = 1
        Me.griProveedor.DisplayLayout.MaxRowScrollRegions = 1
        Me.griProveedor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProveedor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProveedor.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griProveedor.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance28.BorderColor = System.Drawing.Color.Silver
        Me.griProveedor.DisplayLayout.Override.CellAppearance = Appearance28
        Me.griProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griProveedor.DisplayLayout.Override.CellPadding = 0
        Me.griProveedor.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProveedor.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griProveedor.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griProveedor.DisplayLayout.Override.GroupByRowAppearance = Appearance29
        Appearance30.TextHAlignAsString = "Left"
        Me.griProveedor.DisplayLayout.Override.HeaderAppearance = Appearance30
        Me.griProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance31.BorderColor = System.Drawing.Color.Silver
        Me.griProveedor.DisplayLayout.Override.RowAppearance = Appearance31
        Me.griProveedor.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProveedor.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProveedor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griProveedor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griProveedor.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProveedor.Location = New System.Drawing.Point(0, 0)
        Me.griProveedor.Name = "griProveedor"
        Me.griProveedor.Size = New System.Drawing.Size(1112, 269)
        Me.griProveedor.TabIndex = 2
        Me.griProveedor.TabStop = False
        Me.griProveedor.Text = "Grilla1"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox9)
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox10)
        Me.UltraTabPageControl7.Enabled = False
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1112, 269)
        '
        'UltraGroupBox9
        '
        Me.UltraGroupBox9.Controls.Add(Me.griPagoPro)
        Me.UltraGroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox9.Location = New System.Drawing.Point(0, 33)
        Me.UltraGroupBox9.Name = "UltraGroupBox9"
        Me.UltraGroupBox9.Size = New System.Drawing.Size(1112, 236)
        Me.UltraGroupBox9.TabIndex = 5
        Me.UltraGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPagoPro
        '
        Me.griPagoPro.DataSource = Me.udsDetraccionDetalle
        UltraGridColumn324.Header.VisiblePosition = 0
        UltraGridColumn324.Hidden = True
        UltraGridColumn325.Header.VisiblePosition = 18
        UltraGridColumn325.Hidden = True
        UltraGridColumn326.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn326.Header.Caption = "Bien"
        UltraGridColumn326.Header.VisiblePosition = 4
        UltraGridColumn326.Width = 189
        UltraGridColumn327.Header.VisiblePosition = 6
        UltraGridColumn327.Hidden = True
        UltraGridColumn328.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn328.Header.Caption = "Cta Corriente"
        UltraGridColumn328.Header.VisiblePosition = 5
        UltraGridColumn328.Width = 81
        UltraGridColumn329.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn329.Header.VisiblePosition = 2
        UltraGridColumn329.Width = 225
        UltraGridColumn330.Header.VisiblePosition = 3
        UltraGridColumn330.Hidden = True
        UltraGridColumn330.Width = 73
        UltraGridColumn331.Header.Caption = "Operacion"
        UltraGridColumn331.Header.VisiblePosition = 8
        UltraGridColumn331.Hidden = True
        UltraGridColumn331.Width = 177
        UltraGridColumn332.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn332.Header.Caption = "TipoDoc"
        UltraGridColumn332.Header.VisiblePosition = 10
        UltraGridColumn332.Hidden = True
        UltraGridColumn332.Width = 50
        UltraGridColumn333.Header.VisiblePosition = 11
        UltraGridColumn333.Hidden = True
        UltraGridColumn334.Header.VisiblePosition = 12
        UltraGridColumn334.Hidden = True
        UltraGridColumn334.Width = 37
        UltraGridColumn335.Header.VisiblePosition = 13
        UltraGridColumn335.Hidden = True
        UltraGridColumn336.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn336.Header.VisiblePosition = 1
        UltraGridColumn336.Width = 86
        UltraGridColumn337.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn337.CellAppearance = Appearance32
        UltraGridColumn337.Format = "#,###,###,##0.00"
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn337.Header.Appearance = Appearance33
        UltraGridColumn337.Header.VisiblePosition = 7
        UltraGridColumn337.MaskInput = "{double:9.2}"
        UltraGridColumn337.Width = 73
        UltraGridColumn338.Header.VisiblePosition = 14
        UltraGridColumn338.Hidden = True
        UltraGridColumn339.Header.VisiblePosition = 15
        UltraGridColumn339.Hidden = True
        UltraGridColumn340.Header.VisiblePosition = 16
        UltraGridColumn340.Hidden = True
        UltraGridColumn341.Header.VisiblePosition = 17
        UltraGridColumn341.Hidden = True
        UltraGridColumn342.Header.VisiblePosition = 19
        UltraGridColumn342.Hidden = True
        UltraGridColumn343.Header.VisiblePosition = 20
        UltraGridColumn343.Hidden = True
        UltraGridColumn344.Header.VisiblePosition = 9
        UltraGridColumn344.Hidden = True
        UltraGridColumn344.Width = 48
        UltraGridColumn345.Header.VisiblePosition = 21
        UltraGridColumn345.Hidden = True
        UltraGridColumn346.Header.Caption = "TipoGasto"
        UltraGridColumn346.Header.VisiblePosition = 22
        UltraGridColumn346.Width = 281
        UltraGridColumn347.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn347.Header.VisiblePosition = 23
        UltraGridColumn347.MaxLength = 8
        UltraGridColumn348.Header.VisiblePosition = 24
        UltraGridColumn348.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348})
        Me.griPagoPro.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griPagoPro.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance34.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance34.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance34.BorderColor = System.Drawing.SystemColors.Window
        Me.griPagoPro.DisplayLayout.GroupByBox.Appearance = Appearance34
        Appearance35.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPagoPro.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance35
        Me.griPagoPro.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPagoPro.DisplayLayout.GroupByBox.Hidden = True
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance36.BackColor2 = System.Drawing.SystemColors.Control
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPagoPro.DisplayLayout.GroupByBox.PromptAppearance = Appearance36
        Me.griPagoPro.DisplayLayout.MaxColScrollRegions = 1
        Me.griPagoPro.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPagoPro.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPagoPro.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPagoPro.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPagoPro.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance37.BorderColor = System.Drawing.Color.Silver
        Me.griPagoPro.DisplayLayout.Override.CellAppearance = Appearance37
        Me.griPagoPro.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPagoPro.DisplayLayout.Override.CellPadding = 0
        Me.griPagoPro.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPagoPro.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griPagoPro.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griPagoPro.DisplayLayout.Override.GroupByRowAppearance = Appearance38
        Appearance39.TextHAlignAsString = "Left"
        Me.griPagoPro.DisplayLayout.Override.HeaderAppearance = Appearance39
        Me.griPagoPro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance40.BorderColor = System.Drawing.Color.Silver
        Me.griPagoPro.DisplayLayout.Override.RowAppearance = Appearance40
        Me.griPagoPro.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPagoPro.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPagoPro.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griPagoPro.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPagoPro.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPagoPro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPagoPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPagoPro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPagoPro.Location = New System.Drawing.Point(3, 3)
        Me.griPagoPro.Name = "griPagoPro"
        Me.griPagoPro.Size = New System.Drawing.Size(1106, 230)
        Me.griPagoPro.TabIndex = 3
        Me.griPagoPro.TabStop = False
        Me.griPagoPro.Text = "Grilla1"
        '
        'UltraGroupBox10
        '
        Me.UltraGroupBox10.Controls.Add(Me.Etiqueta3)
        Me.UltraGroupBox10.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox10.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox10.Controls.Add(Me.fecPeriodoPro)
        Me.UltraGroupBox10.Controls.Add(Me.cboCtaBancariaDolaresPro)
        Me.UltraGroupBox10.Controls.Add(Me.cboCtaBancariaSolesPro)
        Me.UltraGroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox10.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox10.Name = "UltraGroupBox10"
        Me.UltraGroupBox10.Size = New System.Drawing.Size(1112, 33)
        Me.UltraGroupBox10.TabIndex = 4
        Me.UltraGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance41
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(531, 10)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta3.TabIndex = 28
        Me.Etiqueta3.Text = "Cta $:"
        '
        'Etiqueta4
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance42
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(130, 10)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(37, 14)
        Me.Etiqueta4.TabIndex = 14
        Me.Etiqueta4.Text = "Cta S/:"
        '
        'Etiqueta5
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance43
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(7, 9)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta5.TabIndex = 12
        Me.Etiqueta5.Text = "Periodo:"
        '
        'fecPeriodoPro
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodoPro.Appearance = Appearance44
        Me.fecPeriodoPro.DateTime = New Date(2012, 3, 31, 0, 0, 0, 0)
        Me.fecPeriodoPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodoPro.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodoPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecPeriodoPro.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodoPro.Location = New System.Drawing.Point(58, 6)
        Me.fecPeriodoPro.MaskInput = "mm/yyyy"
        Me.fecPeriodoPro.Name = "fecPeriodoPro"
        Me.fecPeriodoPro.Size = New System.Drawing.Size(66, 21)
        Me.fecPeriodoPro.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodoPro.TabIndex = 13
        Me.fecPeriodoPro.TabStop = False
        Me.fecPeriodoPro.Value = New Date(2012, 3, 31, 0, 0, 0, 0)
        '
        'cboCtaBancariaDolaresPro
        '
        Appearance45.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaDolaresPro.Appearance = Appearance45
        Me.cboCtaBancariaDolaresPro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancariaDolaresPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancariaDolaresPro.DropDownListWidth = 400
        Me.cboCtaBancariaDolaresPro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancariaDolaresPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancariaDolaresPro.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaDolaresPro.Location = New System.Drawing.Point(570, 6)
        Me.cboCtaBancariaDolaresPro.Name = "cboCtaBancariaDolaresPro"
        Me.cboCtaBancariaDolaresPro.Size = New System.Drawing.Size(352, 21)
        Me.cboCtaBancariaDolaresPro.TabIndex = 11
        Me.cboCtaBancariaDolaresPro.ValueMember = "Id"
        '
        'cboCtaBancariaSolesPro
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaSolesPro.Appearance = Appearance46
        Me.cboCtaBancariaSolesPro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCtaBancariaSolesPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCtaBancariaSolesPro.DropDownListWidth = 400
        Me.cboCtaBancariaSolesPro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCtaBancariaSolesPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCtaBancariaSolesPro.ForeColor = System.Drawing.Color.Black
        Me.cboCtaBancariaSolesPro.Location = New System.Drawing.Point(173, 6)
        Me.cboCtaBancariaSolesPro.Name = "cboCtaBancariaSolesPro"
        Me.cboCtaBancariaSolesPro.Size = New System.Drawing.Size(352, 21)
        Me.cboCtaBancariaSolesPro.TabIndex = 10
        Me.cboCtaBancariaSolesPro.ValueMember = "Id"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1120, 400)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.griDetraccion)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 58)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1120, 342)
        Me.UltraGroupBox4.TabIndex = 3
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetraccion
        '
        Me.griDetraccion.ContextMenuStrip = Me.ContextMenuStrip1
        Me.griDetraccion.DataSource = Me.udsDetraccion
        UltraGridColumn233.Header.VisiblePosition = 0
        UltraGridColumn233.Hidden = True
        UltraGridColumn234.Header.VisiblePosition = 1
        UltraGridColumn234.Hidden = True
        UltraGridColumn235.Header.VisiblePosition = 2
        UltraGridColumn235.Hidden = True
        UltraGridColumn236.Header.VisiblePosition = 3
        UltraGridColumn236.Hidden = True
        UltraGridColumn237.Header.VisiblePosition = 7
        UltraGridColumn238.Header.VisiblePosition = 9
        UltraGridColumn239.Header.VisiblePosition = 8
        UltraGridColumn240.Header.VisiblePosition = 10
        UltraGridColumn240.Hidden = True
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn241.CellAppearance = Appearance47
        UltraGridColumn241.Format = "#,###,###,##0.00"
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn241.Header.Appearance = Appearance48
        UltraGridColumn241.Header.VisiblePosition = 11
        UltraGridColumn241.MaskInput = "{double:9.2}"
        UltraGridColumn241.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn242.Header.VisiblePosition = 12
        UltraGridColumn242.Hidden = True
        UltraGridColumn243.Header.VisiblePosition = 13
        UltraGridColumn244.Header.VisiblePosition = 14
        UltraGridColumn244.Hidden = True
        UltraGridColumn245.Header.VisiblePosition = 5
        UltraGridColumn245.Width = 265
        UltraGridColumn246.Header.VisiblePosition = 4
        UltraGridColumn247.Header.VisiblePosition = 6
        UltraGridColumn248.Header.VisiblePosition = 15
        UltraGridColumn248.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248})
        Me.griDetraccion.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griDetraccion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetraccion.DisplayLayout.GroupByBox.Appearance = Appearance49
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetraccion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance50
        Me.griDetraccion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetraccion.DisplayLayout.GroupByBox.Hidden = True
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance51.BackColor2 = System.Drawing.SystemColors.Control
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetraccion.DisplayLayout.GroupByBox.PromptAppearance = Appearance51
        Me.griDetraccion.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetraccion.DisplayLayout.MaxRowScrollRegions = 1
        Me.griDetraccion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetraccion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetraccion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griDetraccion.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance52.BorderColor = System.Drawing.Color.Silver
        Me.griDetraccion.DisplayLayout.Override.CellAppearance = Appearance52
        Me.griDetraccion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetraccion.DisplayLayout.Override.CellPadding = 0
        Me.griDetraccion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetraccion.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.griDetraccion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance53.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griDetraccion.DisplayLayout.Override.GroupByRowAppearance = Appearance53
        Appearance54.TextHAlignAsString = "Left"
        Me.griDetraccion.DisplayLayout.Override.HeaderAppearance = Appearance54
        Me.griDetraccion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance55.BorderColor = System.Drawing.Color.Silver
        Me.griDetraccion.DisplayLayout.Override.RowAppearance = Appearance55
        Me.griDetraccion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetraccion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetraccion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetraccion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetraccion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetraccion.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetraccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetraccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetraccion.Location = New System.Drawing.Point(3, 3)
        Me.griDetraccion.Name = "griDetraccion"
        Me.griDetraccion.Size = New System.Drawing.Size(1114, 336)
        Me.griDetraccion.TabIndex = 1
        Me.griDetraccion.TabStop = False
        Me.griDetraccion.Text = "Grilla1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem1.Text = "Nuevo Adquiriente"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem2.Text = "Nuevo Proveedor"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem3.Text = "GenerarArchivo"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem4.Text = "Pagar"
        '
        'udsDetraccion
        '
        UltraDataColumn34.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Date)
        UltraDataColumn41.DataType = GetType(Date)
        Me.udsDetraccion.Band.Columns.AddRange(New Object() {UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41})
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox3.Controls.Add(Me.UltraColorPicker3)
        Me.UltraGroupBox3.Controls.Add(Me.UltraColorPicker2)
        Me.UltraGroupBox3.Controls.Add(Me.UltraColorPicker1)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.UltraGroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1120, 58)
        Me.UltraGroupBox3.TabIndex = 2
        Me.UltraGroupBox3.Text = "Buscar:"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel9
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel9.Appearance = Appearance56
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(585, 27)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(41, 15)
        Me.UltraLabel9.TabIndex = 12
        Me.UltraLabel9.Text = "Pagado"
        '
        'UltraLabel8
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel8.Appearance = Appearance57
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(477, 27)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(52, 15)
        Me.UltraLabel8.TabIndex = 11
        Me.UltraLabel8.Text = "Generado"
        '
        'UltraLabel7
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel7.Appearance = Appearance58
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(367, 27)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(54, 15)
        Me.UltraLabel7.TabIndex = 10
        Me.UltraLabel7.Text = "Pendiente"
        '
        'UltraColorPicker3
        '
        Me.UltraColorPicker3.Location = New System.Drawing.Point(632, 23)
        Me.UltraColorPicker3.Name = "UltraColorPicker3"
        Me.UltraColorPicker3.Size = New System.Drawing.Size(44, 22)
        Me.UltraColorPicker3.TabIndex = 9
        Me.UltraColorPicker3.Text = "Control"
        '
        'UltraColorPicker2
        '
        Me.UltraColorPicker2.Location = New System.Drawing.Point(535, 23)
        Me.UltraColorPicker2.Name = "UltraColorPicker2"
        Me.UltraColorPicker2.Size = New System.Drawing.Size(44, 22)
        Me.UltraColorPicker2.TabIndex = 8
        Me.UltraColorPicker2.Text = "Control"
        '
        'UltraColorPicker1
        '
        Me.UltraColorPicker1.Location = New System.Drawing.Point(427, 23)
        Me.UltraColorPicker1.Name = "UltraColorPicker1"
        Me.UltraColorPicker1.Size = New System.Drawing.Size(44, 22)
        Me.UltraColorPicker1.TabIndex = 7
        Me.UltraColorPicker1.Text = "Control"
        '
        'UltraLabel6
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel6.Appearance = Appearance59
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(155, 27)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(37, 15)
        Me.UltraLabel6.TabIndex = 6
        Me.UltraLabel6.Text = "Hasta:"
        '
        'UltraLabel5
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel5.Appearance = Appearance60
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(11, 27)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel5.TabIndex = 5
        Me.UltraLabel5.Text = "Desde:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(198, 24)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(93, 21)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(93, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1120, 400)
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.ficDetAdq)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 102)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1120, 298)
        Me.UltraGroupBox2.TabIndex = 1
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetAdq
        '
        Me.ficDetAdq.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetAdq.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetAdq.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetAdq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetAdq.Location = New System.Drawing.Point(3, 3)
        Me.ficDetAdq.Name = "ficDetAdq"
        Me.ficDetAdq.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetAdq.Size = New System.Drawing.Size(1114, 292)
        Me.ficDetAdq.TabIndex = 3
        UltraTab6.TabPage = Me.UltraTabPageControl3
        UltraTab6.Text = "Detalle"
        UltraTab7.TabPage = Me.UltraTabPageControl4
        UltraTab7.Text = "AsientoContable"
        Me.ficDetAdq.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficDetAdq.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1112, 269)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.btnAsiento)
        Me.UltraGroupBox1.Controls.Add(Me.numTCAdq)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox1.Controls.Add(Me.btnGuardar)
        Me.UltraGroupBox1.Controls.Add(Me.btnGenArchivo)
        Me.UltraGroupBox1.Controls.Add(Me.btnConsultar)
        Me.UltraGroupBox1.Controls.Add(Me.numImporteAdq)
        Me.UltraGroupBox1.Controls.Add(Me.txtLoteAdq)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox1.Controls.Add(Me.txtRazonSocialAdq)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.txtRucAdq)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1120, 102)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAsiento
        '
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Appearance61.Image = Global.ISL.Win.My.Resources.Resources.situacionadm
        Me.btnAsiento.Appearance = Appearance61
        Me.btnAsiento.Enabled = False
        Me.btnAsiento.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAsiento.Location = New System.Drawing.Point(388, 69)
        Me.btnAsiento.Name = "btnAsiento"
        Me.btnAsiento.Size = New System.Drawing.Size(96, 26)
        Me.btnAsiento.TabIndex = 27
        Me.btnAsiento.Text = "Gen. Pago"
        '
        'numTCAdq
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.numTCAdq.Appearance = Appearance62
        Me.numTCAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTCAdq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTCAdq.ForeColor = System.Drawing.Color.Black
        Me.numTCAdq.Location = New System.Drawing.Point(286, 13)
        Me.numTCAdq.MaskInput = "{double:3.3}"
        Me.numTCAdq.Name = "numTCAdq"
        Me.numTCAdq.NullText = "0.00"
        Me.numTCAdq.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTCAdq.Size = New System.Drawing.Size(73, 21)
        Me.numTCAdq.TabIndex = 26
        '
        'UltraLabel10
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel10.Appearance = Appearance63
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(252, 17)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel10.TabIndex = 25
        Me.UltraLabel10.Text = "T.C.:"
        '
        'btnGuardar
        '
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance64
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(286, 69)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 26)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        '
        'btnGenArchivo
        '
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnGenArchivo.Appearance = Appearance65
        Me.btnGenArchivo.Enabled = False
        Me.btnGenArchivo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenArchivo.Location = New System.Drawing.Point(184, 69)
        Me.btnGenArchivo.Name = "btnGenArchivo"
        Me.btnGenArchivo.Size = New System.Drawing.Size(96, 26)
        Me.btnGenArchivo.TabIndex = 23
        Me.btnGenArchivo.Text = "Gen. Arch."
        '
        'btnConsultar
        '
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Appearance66.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance66
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(82, 69)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(96, 26)
        Me.btnConsultar.TabIndex = 22
        Me.btnConsultar.Text = "Consultar"
        '
        'numImporteAdq
        '
        Me.numImporteAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.numImporteAdq.Location = New System.Drawing.Point(463, 41)
        Me.numImporteAdq.MaskInput = "{double:9.2}"
        Me.numImporteAdq.Name = "numImporteAdq"
        Me.numImporteAdq.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImporteAdq.Size = New System.Drawing.Size(100, 22)
        Me.numImporteAdq.TabIndex = 7
        '
        'txtLoteAdq
        '
        Me.txtLoteAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtLoteAdq.Location = New System.Drawing.Point(463, 13)
        Me.txtLoteAdq.MaxLength = 6
        Me.txtLoteAdq.Name = "txtLoteAdq"
        Me.txtLoteAdq.ReadOnly = True
        Me.txtLoteAdq.Size = New System.Drawing.Size(58, 22)
        Me.txtLoteAdq.TabIndex = 6
        '
        'UltraLabel4
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance67
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(384, 45)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel4.TabIndex = 5
        Me.UltraLabel4.Text = "ImporteTotal:"
        '
        'UltraLabel3
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance68
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(409, 17)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "NroLote:"
        '
        'UltraLabel2
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance69
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(5, 45)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(71, 15)
        Me.UltraLabel2.TabIndex = 3
        Me.UltraLabel2.Text = "Razon Social:"
        '
        'txtRazonSocialAdq
        '
        Me.txtRazonSocialAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRazonSocialAdq.Location = New System.Drawing.Point(82, 41)
        Me.txtRazonSocialAdq.Name = "txtRazonSocialAdq"
        Me.txtRazonSocialAdq.ReadOnly = True
        Me.txtRazonSocialAdq.Size = New System.Drawing.Size(278, 22)
        Me.txtRazonSocialAdq.TabIndex = 2
        '
        'UltraLabel1
        '
        Appearance70.BackColor = System.Drawing.Color.Transparent
        Appearance70.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance70
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(47, 17)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(29, 15)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "RUC:"
        '
        'txtRucAdq
        '
        Me.txtRucAdq.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRucAdq.Location = New System.Drawing.Point(82, 13)
        Me.txtRucAdq.Name = "txtRucAdq"
        Me.txtRucAdq.ReadOnly = True
        Me.txtRucAdq.Size = New System.Drawing.Size(100, 22)
        Me.txtRucAdq.TabIndex = 0
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox8)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl5.Enabled = False
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1120, 400)
        '
        'UltraGroupBox8
        '
        Me.UltraGroupBox8.Controls.Add(Me.ficDetPro)
        Me.UltraGroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox8.Location = New System.Drawing.Point(0, 102)
        Me.UltraGroupBox8.Name = "UltraGroupBox8"
        Me.UltraGroupBox8.Size = New System.Drawing.Size(1120, 298)
        Me.UltraGroupBox8.TabIndex = 1
        Me.UltraGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ficDetPro
        '
        Me.ficDetPro.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficDetPro.Controls.Add(Me.UltraTabPageControl6)
        Me.ficDetPro.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDetPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetPro.Location = New System.Drawing.Point(3, 3)
        Me.ficDetPro.Name = "ficDetPro"
        Me.ficDetPro.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficDetPro.Size = New System.Drawing.Size(1114, 292)
        Me.ficDetPro.TabIndex = 4
        UltraTab3.TabPage = Me.UltraTabPageControl6
        UltraTab3.Text = "Detalle"
        UltraTab4.TabPage = Me.UltraTabPageControl7
        UltraTab4.Text = "AsientoContable"
        Me.ficDetPro.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.ficDetPro.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1112, 269)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.btnGenPagoPro)
        Me.UltraGroupBox7.Controls.Add(Me.numTCPro)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox7.Controls.Add(Me.btnGuardarPro)
        Me.UltraGroupBox7.Controls.Add(Me.btnGenArchPro)
        Me.UltraGroupBox7.Controls.Add(Me.btnConsultarPro)
        Me.UltraGroupBox7.Controls.Add(Me.numImportePro)
        Me.UltraGroupBox7.Controls.Add(Me.txtNroLotePro)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel12)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel13)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel14)
        Me.UltraGroupBox7.Controls.Add(Me.txtRazonSocialPro)
        Me.UltraGroupBox7.Controls.Add(Me.UltraLabel15)
        Me.UltraGroupBox7.Controls.Add(Me.txtRucPro)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1120, 102)
        Me.UltraGroupBox7.TabIndex = 0
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnGenPagoPro
        '
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Appearance71.Image = Global.ISL.Win.My.Resources.Resources.situacionadm
        Me.btnGenPagoPro.Appearance = Appearance71
        Me.btnGenPagoPro.Enabled = False
        Me.btnGenPagoPro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenPagoPro.Location = New System.Drawing.Point(388, 69)
        Me.btnGenPagoPro.Name = "btnGenPagoPro"
        Me.btnGenPagoPro.Size = New System.Drawing.Size(96, 26)
        Me.btnGenPagoPro.TabIndex = 41
        Me.btnGenPagoPro.Text = "Gen. Pago"
        '
        'numTCPro
        '
        Appearance72.ForeColor = System.Drawing.Color.Black
        Me.numTCPro.Appearance = Appearance72
        Me.numTCPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTCPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTCPro.ForeColor = System.Drawing.Color.Black
        Me.numTCPro.Location = New System.Drawing.Point(286, 13)
        Me.numTCPro.MaskInput = "{double:3.3}"
        Me.numTCPro.Name = "numTCPro"
        Me.numTCPro.NullText = "0.00"
        Me.numTCPro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTCPro.Size = New System.Drawing.Size(73, 21)
        Me.numTCPro.TabIndex = 40
        '
        'UltraLabel11
        '
        Appearance73.BackColor = System.Drawing.Color.Transparent
        Appearance73.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel11.Appearance = Appearance73
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(252, 17)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(28, 15)
        Me.UltraLabel11.TabIndex = 39
        Me.UltraLabel11.Text = "T.C.:"
        '
        'btnGuardarPro
        '
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Appearance74.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardarPro.Appearance = Appearance74
        Me.btnGuardarPro.Enabled = False
        Me.btnGuardarPro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardarPro.Location = New System.Drawing.Point(286, 69)
        Me.btnGuardarPro.Name = "btnGuardarPro"
        Me.btnGuardarPro.Size = New System.Drawing.Size(96, 26)
        Me.btnGuardarPro.TabIndex = 38
        Me.btnGuardarPro.Text = "Guardar"
        '
        'btnGenArchPro
        '
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Appearance75.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnGenArchPro.Appearance = Appearance75
        Me.btnGenArchPro.Enabled = False
        Me.btnGenArchPro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenArchPro.Location = New System.Drawing.Point(184, 69)
        Me.btnGenArchPro.Name = "btnGenArchPro"
        Me.btnGenArchPro.Size = New System.Drawing.Size(96, 26)
        Me.btnGenArchPro.TabIndex = 37
        Me.btnGenArchPro.Text = "Gen. Arch."
        '
        'btnConsultarPro
        '
        Appearance76.ForeColor = System.Drawing.Color.Navy
        Appearance76.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultarPro.Appearance = Appearance76
        Me.btnConsultarPro.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultarPro.Location = New System.Drawing.Point(82, 69)
        Me.btnConsultarPro.Name = "btnConsultarPro"
        Me.btnConsultarPro.Size = New System.Drawing.Size(96, 26)
        Me.btnConsultarPro.TabIndex = 36
        Me.btnConsultarPro.Text = "Consultar"
        '
        'numImportePro
        '
        Me.numImportePro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.numImportePro.Location = New System.Drawing.Point(463, 41)
        Me.numImportePro.MaskInput = "{double:9.2}"
        Me.numImportePro.Name = "numImportePro"
        Me.numImportePro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numImportePro.Size = New System.Drawing.Size(100, 22)
        Me.numImportePro.TabIndex = 35
        '
        'txtNroLotePro
        '
        Me.txtNroLotePro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtNroLotePro.Location = New System.Drawing.Point(463, 13)
        Me.txtNroLotePro.MaxLength = 6
        Me.txtNroLotePro.Name = "txtNroLotePro"
        Me.txtNroLotePro.ReadOnly = True
        Me.txtNroLotePro.Size = New System.Drawing.Size(58, 22)
        Me.txtNroLotePro.TabIndex = 34
        '
        'UltraLabel12
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel12.Appearance = Appearance77
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(384, 45)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(73, 15)
        Me.UltraLabel12.TabIndex = 33
        Me.UltraLabel12.Text = "ImporteTotal:"
        '
        'UltraLabel13
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel13.Appearance = Appearance78
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(409, 17)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel13.TabIndex = 32
        Me.UltraLabel13.Text = "NroLote:"
        '
        'UltraLabel14
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel14.Appearance = Appearance79
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(5, 45)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(71, 15)
        Me.UltraLabel14.TabIndex = 31
        Me.UltraLabel14.Text = "Razon Social:"
        '
        'txtRazonSocialPro
        '
        Me.txtRazonSocialPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRazonSocialPro.Location = New System.Drawing.Point(82, 41)
        Me.txtRazonSocialPro.Name = "txtRazonSocialPro"
        Me.txtRazonSocialPro.ReadOnly = True
        Me.txtRazonSocialPro.Size = New System.Drawing.Size(278, 22)
        Me.txtRazonSocialPro.TabIndex = 30
        '
        'UltraLabel15
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel15.Appearance = Appearance80
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(47, 17)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(29, 15)
        Me.UltraLabel15.TabIndex = 29
        Me.UltraLabel15.Text = "RUC:"
        '
        'txtRucPro
        '
        Me.txtRucPro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtRucPro.Location = New System.Drawing.Point(82, 13)
        Me.txtRucPro.Name = "txtRucPro"
        Me.txtRucPro.ReadOnly = True
        Me.txtRucPro.Size = New System.Drawing.Size(100, 22)
        Me.txtRucPro.TabIndex = 28
        '
        'ficDetraccion
        '
        Me.ficDetraccion.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDetraccion.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDetraccion.Controls.Add(Me.UltraTabPageControl2)
        Me.ficDetraccion.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetraccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetraccion.Location = New System.Drawing.Point(0, 0)
        Me.ficDetraccion.Name = "ficDetraccion"
        Me.ficDetraccion.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDetraccion.Size = New System.Drawing.Size(1122, 423)
        Me.ficDetraccion.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Det. Adquiriente"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Det. Proveedor"
        Me.ficDetraccion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab5})
        Me.ficDetraccion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1120, 400)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(363, 177)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 2
        Me.ugb_Espera.Visible = False
        '
        'frm_DetraccionesMasivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 423)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDetraccion)
        Me.Name = "frm_DetraccionesMasivas"
        Me.Text = "Detracciones Masivas"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griAdquiriente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsDetraccionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.griPagoAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        Me.UltraGroupBox5.PerformLayout()
        CType(Me.fecPeriodoAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancariaSolesAdq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox9.ResumeLayout(False)
        CType(Me.griPagoPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox10.ResumeLayout(False)
        Me.UltraGroupBox10.PerformLayout()
        CType(Me.fecPeriodoPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancariaDolaresPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCtaBancariaSolesPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.griDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.udsDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraColorPicker3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraColorPicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraColorPicker1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.ficDetAdq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetAdq.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.numTCAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImporteAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoteAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocialAdq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucAdq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox8.ResumeLayout(False)
        CType(Me.ficDetPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetPro.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        Me.UltraGroupBox7.PerformLayout()
        CType(Me.numTCPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numImportePro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroLotePro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocialPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRucPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetraccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDetraccion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griDetraccion As ISL.Controles.Grilla
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents udsDetraccionDetalle As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents udsDetraccion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griAdquiriente As ISL.Controles.Grilla
    Friend WithEvents numImporteAdq As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtLoteAdq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRazonSocialAdq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRucAdq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGenArchivo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraColorPicker3 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraColorPicker2 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraColorPicker1 As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numTCAdq As ISL.Controles.NumeroDecimal
    Friend WithEvents ficDetAdq As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griPagoAdq As ISL.Controles.Grilla
    Friend WithEvents btnAsiento As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboCtaBancariaSolesAdq As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents etiPeriodo As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodoAdq As ISL.Controles.Fecha
    Friend WithEvents UltraGroupBox8 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnGenPagoPro As Infragistics.Win.Misc.UltraButton
    Friend WithEvents numTCPro As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnGuardarPro As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnGenArchPro As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnConsultarPro As Infragistics.Win.Misc.UltraButton
    Friend WithEvents numImportePro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtNroLotePro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRazonSocialPro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtRucPro As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents ficDetPro As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griProveedor As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox9 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griPagoPro As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox10 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodoPro As ISL.Controles.Fecha
    Friend WithEvents cboCtaBancariaDolaresPro As ISL.Controles.Combo
    Friend WithEvents cboCtaBancariaSolesPro As ISL.Controles.Combo
End Class
