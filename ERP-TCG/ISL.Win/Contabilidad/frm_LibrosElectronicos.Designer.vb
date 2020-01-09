<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LibrosElectronicos
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
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdLibroElectronico")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoDocumento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroCorrelativo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieDoc")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnioEmisionDUA")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDoc")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDoc2")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocIdentidad")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDocIdentidad")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Denominacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal1")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV1")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal2")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV2")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal3")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IGV3")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NoGravada")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ISC")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OtrosTributos")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmisionAso")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumentoAso")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SerieAso")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDocAso")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NumeroDocAso2")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmisionDetraccion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroConstanciaDetraccion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Retencion")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoUnicoOperacion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoDuaDsiFob")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCorrelativoVenta")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCorrelativoCompra")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroCorrelativoConsignacion")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMoneda")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClasificacionBienServicio")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdentificacionContratoProy")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ErrorTipo1")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ErrorTipo2")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ErrorTipo3")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ErrorTipo4")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCancelaComprobPago")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DsctoBaseImp")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DsctoIGV")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodPais")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodConvenio")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodTipoRenta")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn674 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn675 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn676 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn677 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn678 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn679 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn680 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn681 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn682 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn683 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn684 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn685 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn686 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn687 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn688 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn689 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn690 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn691 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn692 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn693 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn694 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn695 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn696 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn697 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn698 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn699 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn700 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn701 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn702 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn703 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn704 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn705 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn706 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn707 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn708 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn709 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn710 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn711 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn712 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn713 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn714 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn715 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn716 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn717 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn718 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn719 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn720 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn721 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn722 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn723 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn724 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn725 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn726 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn727 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn728 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn729 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn730 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn731 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn732 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn733 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn734 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn735 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn736 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn737 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn738 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn739 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn740 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn741 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn742 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn743 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn744 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn745 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn746 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn747 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn748 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn749 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn750 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn751 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn752 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn753 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn754 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn755 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn756 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn757 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn758 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn759 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn760 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn761 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn762 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn763 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn764 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn765 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn766 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn767 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn768 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn769 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn770 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn771 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn772 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn773 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn774 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn775 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn776 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn777 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn778 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn779 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn780 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn781 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn782 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn783 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn784 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn785 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn786 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn787 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn788 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn789 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn790 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn791 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn792 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn793 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn794 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn795 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn796 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn797 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn798 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn799 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn800 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn801 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn802 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn803 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn804 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn805 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn806 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn807 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn808 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn809 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn810 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn811 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn812 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn813 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn814 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn815 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn816 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn817 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn818 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn819 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn820 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn821 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn822 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn823 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn824 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn825 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn826 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn827 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn828 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn829 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn830 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn831 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn832 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn833 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn834 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn835 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn836 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn837 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn838 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn839 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn840 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn841 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn842 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn843 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn844 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn845 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn846 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn847 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn848 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn849 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn850 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn851 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn852 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn853 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn854 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn855 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn856 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn857 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn858 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn859 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn860 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn861 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn862 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn863 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn864 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn865 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn866 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn867 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn868 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn869 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn870 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn871 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn872 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn873 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn874 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn875 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false)
        Dim UltraGridColumn876 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn877 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn878 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn879 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn880 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn881 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn882 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn883 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn884 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn885 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn886 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn887 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn888 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn889 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn890 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn891 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn892 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn893 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn894 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn895 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn896 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn897 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn898 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn899 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn900 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn901 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn902 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn903 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn904 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn905 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn906 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn907 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn908 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn909 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn910 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn911 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn912 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn913 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn914 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn915 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn916 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn917 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn918 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn919 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn920 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn921 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn922 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn923 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn924 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn925 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn926 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn927 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn928 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn929 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn930 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn931 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand13 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn932 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn933 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn934 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn935 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn936 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn937 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn938 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn939 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn940 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn941 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn942 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn943 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn944 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn945 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn946 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn947 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn948 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn949 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn950 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn951 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn952 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn953 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn954 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn955 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn956 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn957 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn958 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn959 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn960 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn961 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn962 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn963 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn964 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn965 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn966 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn967 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn968 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn969 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn970 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn971 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn972 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn973 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn974 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn975 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn976 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn977 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn978 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn979 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn980 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn981 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn982 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn983 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn984 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn985 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand14 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn986 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn987 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn988 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn989 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn990 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn991 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn992 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn993 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn994 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn995 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn996 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn997 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn998 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn999 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1000 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1001 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1002 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1003 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1004 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1005 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1006 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1007 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1008 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1009 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1010 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn1011 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1012 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1013 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1014 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1015 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1016 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1017 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1018 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1019 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1020 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1021 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1022 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1023 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1024 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1025 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1026 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1027 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1028 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1029 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1030 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1031 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1032 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1033 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1034 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1035 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1036 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1037 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1038 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1039 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand15 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1040 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1041 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1042 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1043 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1044 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1045 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1046 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1047 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1048 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1049 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1050 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1051 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1052 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1053 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1054 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1055 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1056 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1057 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1058 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1059 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1060 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1061 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1062 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1063 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1064 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1065 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1066 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1067 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1068 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1069 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1070 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1071 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1072 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1073 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1074 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1075 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1076 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1077 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1078 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1079 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1080 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1081 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1082 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1083 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1084 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1085 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1086 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1087 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1088 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1089 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1090 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1091 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1092 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1093 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand16 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1094 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1095 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1096 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1097 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn1098 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1099 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn1119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand17 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand18 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn1218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn1220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand19 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1296 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1297 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1298 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1299 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1300 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1301 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1302 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1303 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1304 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1305 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1306 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1307 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1308 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1309 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand20 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1310 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1311 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1312 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1313 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1314 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1317 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn1326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn1328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn1360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand21 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn1380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn1382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn1410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand22 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn1434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn1436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand23 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn217 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn218 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn219 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn220 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn221 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn222 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn223 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn224 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn225 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn226 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn227 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn228 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn229 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn230 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn231 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn232 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn247 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn248 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn249 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn250 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn251 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn252 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn253 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn254 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn255 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn264 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn265 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn266 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn267 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn268 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn269 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn270 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand24 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1636 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1637 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1638 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1639 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1640 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1641 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1642 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1643 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1644 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1645 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1646 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1647 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1648 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1649 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1650 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1651 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn1652 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn1653 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn1654 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn1655 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn1656 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn1657 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn1658 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn1659 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn1660 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim UltraGridColumn1661 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn1662 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1663 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1664 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1665 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1666 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1667 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1668 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1669 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1670 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1671 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1672 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1673 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3319 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3322 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3323 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3324 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3325 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3326 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3327 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3328 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3329 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3330 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3331 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3332 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand25 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn206 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn207 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn208 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn209 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn210 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn211 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn212 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn213 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn214 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn215 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn216 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand26 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn3338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn3340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn3341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn3342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn3343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn3344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn3345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn3346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn3347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn3348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn3349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn3350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn3362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn3363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn3364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn3365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn3366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn3367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn3368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn3369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn3370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn3372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand27 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn3392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn3394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn3395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn3396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn3397 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn3398 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn3399 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn3400 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn3401 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn3402 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn3403 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn3404 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3405 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3406 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3407 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3408 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3409 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3410 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3411 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3412 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3413 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3414 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3415 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn3416 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn3417 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn3418 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn3419 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn3420 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn3421 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn3422 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn3423 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn3424 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3425 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn3426 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3427 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3428 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3429 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3430 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3431 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3432 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3433 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3434 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3435 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3436 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3437 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3438 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3439 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3440 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3441 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3442 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridColumn3443 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn1", 0)
        Dim UltraGridColumn3444 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn2", 1)
        Dim UltraGridColumn3445 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn3", 2)
        Dim UltraGridColumn3446 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn4", 3)
        Dim UltraGridColumn3447 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn5", 4)
        Dim UltraGridColumn3448 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn6", 5)
        Dim UltraGridColumn3449 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn7", 6)
        Dim UltraGridColumn3450 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn8", 7)
        Dim UltraGridColumn3451 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn9", 8)
        Dim UltraGridColumn3452 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn10", 9)
        Dim UltraGridColumn3453 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn11", 10)
        Dim UltraGridColumn3454 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn12", 11)
        Dim UltraGridBand28 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3455 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3456 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3457 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn3458 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3459 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn3460 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn3461 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn3462 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn3463 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn3464 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn3465 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn3466 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn3467 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn3468 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn3469 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn3470 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3471 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn3482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn3483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn3484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn3485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn3486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn3487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn3488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn3489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn3490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn3492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand29 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn3512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn3514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn3515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn3516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn3517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn3518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn3519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn3520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn3521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn3522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn3523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn3524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn3536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn3537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn3538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn3539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn3540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn3541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn3542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn3543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn3544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn3546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand30 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn3565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn3566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn3567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn3568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn3569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn3570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn3571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn3572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn3573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn3574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn3575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn3576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn3577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn3578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn3590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn3591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn3592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn3593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn3594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn3595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn3596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn3597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn3598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn3599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn3600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn3601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn3602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn3603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn3604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn3605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn3606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn3607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn3608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn3609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn3610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn3611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn3612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn3613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn3614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn3615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn3616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab45 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab46 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab47 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab48 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab49 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab50 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab51 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand31 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1472 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1473 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1474 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1475 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1476 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1477 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1478 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1479 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1480 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1481 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1482 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1483 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1484 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1485 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1486 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1487 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1488 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1489 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1490 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1491 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1492 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1493 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1494 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1495 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1496 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1497 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1498 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1499 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1500 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1501 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1502 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1503 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1504 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1505 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1506 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1507 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1508 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1509 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1510 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1511 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1512 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1513 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1514 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1515 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1516 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1517 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1518 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1519 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1520 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1521 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1522 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1523 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1524 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1525 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridBand32 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1526 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1527 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1528 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1529 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1530 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1531 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1532 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1533 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1534 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1535 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1536 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1537 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1538 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1539 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1540 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1541 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1542 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1543 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1544 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1545 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1546 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1547 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1548 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1549 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1550 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1551 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1552 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1553 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1554 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1555 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1556 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1557 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1558 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1559 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1560 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1561 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1562 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1563 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1564 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1565 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1566 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1567 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1568 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1569 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1570 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1571 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1572 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1573 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1574 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1575 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1576 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1577 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1578 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1579 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraGridColumn1580 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn1", 0)
        Dim UltraGridColumn1581 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnboundColumn2", 1)
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand33 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1582 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn1583 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdLibroElectronico")
        Dim UltraGridColumn1584 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento")
        Dim UltraGridColumn1585 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn1586 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroCorrelativo")
        Dim UltraGridColumn1587 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn1588 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn1589 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn1590 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieDoc")
        Dim UltraGridColumn1591 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioEmisionDUA")
        Dim UltraGridColumn1592 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc")
        Dim UltraGridColumn1593 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDoc2")
        Dim UltraGridColumn1594 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocIdentidad")
        Dim UltraGridColumn1595 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocIdentidad")
        Dim UltraGridColumn1596 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Denominacion")
        Dim UltraGridColumn1597 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1598 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV1")
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1599 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1600 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV2")
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1601 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1602 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV3")
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1603 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NoGravada")
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1604 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ISC")
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1605 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OtrosTributos")
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1606 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1607 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn1608 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionAso")
        Dim UltraGridColumn1609 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumentoAso")
        Dim UltraGridColumn1610 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SerieAso")
        Dim UltraGridColumn1611 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso")
        Dim UltraGridColumn1612 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NumeroDocAso2")
        Dim UltraGridColumn1613 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmisionDetraccion")
        Dim UltraGridColumn1614 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroConstanciaDetraccion")
        Dim UltraGridColumn1615 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn1616 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn1617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn1618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoUnicoOperacion")
        Dim UltraGridColumn1619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoDuaDsiFob")
        Dim UltraGridColumn1620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoVenta")
        Dim UltraGridColumn1621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoCompra")
        Dim UltraGridColumn1622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroCorrelativoConsignacion")
        Dim UltraGridColumn1623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMoneda")
        Dim UltraGridColumn1624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionBienServicio")
        Dim UltraGridColumn1625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdentificacionContratoProy")
        Dim UltraGridColumn1626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo1")
        Dim UltraGridColumn1627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo2")
        Dim UltraGridColumn1628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo3")
        Dim UltraGridColumn1629 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ErrorTipo4")
        Dim UltraGridColumn1630 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCancelaComprobPago")
        Dim UltraGridColumn1631 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoBaseImp")
        Dim UltraGridColumn1632 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DsctoIGV")
        Dim UltraGridColumn1633 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodPais")
        Dim UltraGridColumn1634 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodConvenio")
        Dim UltraGridColumn1635 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodTipoRenta")
        Dim UltraTab21 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab22 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab23 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab52 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab53 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab54 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab20 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab55 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab56 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand34 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn3617 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 1")
        Dim UltraGridColumn3618 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 2")
        Dim UltraGridColumn3619 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 3")
        Dim UltraGridColumn3620 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 4")
        Dim UltraGridColumn3621 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 5")
        Dim UltraGridColumn3622 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 6")
        Dim UltraGridColumn3623 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 7")
        Dim UltraGridColumn3624 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 8")
        Dim UltraGridColumn3625 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 9")
        Dim UltraGridColumn3626 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 10")
        Dim UltraGridColumn3627 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 11")
        Dim UltraGridColumn3628 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Campo 12")
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 1")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 2")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 3")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 4")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 5")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 6")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 7")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 8")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 9")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 10")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 11")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Campo 12")
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_LibrosElectronicos))
        Dim UltraGridBand35 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn271 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn272 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn273 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTablaContableDet")
        Dim UltraGridColumn274 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn275 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn276 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal1")
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn277 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal2")
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal3")
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal4")
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal5")
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTablaContableDet")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal1")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal2")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal3")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal4")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal5")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab57 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab58 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab59 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab60 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab61 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab62 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab63 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab64 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab65 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab66 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab67 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab68 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab69 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab70 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance233 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab71 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab72 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl21 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridInventario = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdDetalleLibroElectronico = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl22 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv10 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl23 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv12 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl24 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv14 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl25 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv16 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl26 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv19 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl27 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv20 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl28 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv30 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl29 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv34 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl30 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv41 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl31 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv42 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl32 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv46 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl33 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv47 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl34 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv37 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl35 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInv50 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl36 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvParticionaria = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl37 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvBC = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl38 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvEFEMD = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl39 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvECPN = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl40 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvER = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl41 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.pnlNavegador = New Infragistics.Win.Misc.UltraPanel()
        Me.webNotas = New System.Windows.Forms.WebBrowser()
        Me.agrNotas = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtNombreArchivo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAbrir = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl42 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvERI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl43 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griInvEFEMI = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl48 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridActivoFijo = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl49 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAct73 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl50 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAct74 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl16 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleCompras = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl17 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCompras2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl18 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griCompras3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl44 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridCostos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl45 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl46 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl47 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl19 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleVentas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl20 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griVentas2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridCajaBancos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficInventarioBalance = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridRentenciones = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleDiario = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.griDetalleDiarioPlanContable = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridDiarioSimplificado = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl13 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleMayor = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl14 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficActivoFijo = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage7 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl15 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.utcCompras = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridConsignacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficRegistrosCostos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage6 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridPermanenteUF = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griPermanenteValorizado = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridArchivoTexto = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdImportar = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrListaRegistro = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Enviar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLista = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.dtpEjercicioLista = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesLista = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLibroLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabDetalleLibros = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.dtp_FechaGuarda = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaFinal = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaInicial = New ISL.Controles.ComboMaestros(Me.components)
        Me.decSubTotal4 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSubTotal3 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decSubTotal2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decSubTotal1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtObservacion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnGenerarCUO = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.cboImportarArchivo = New ISL.Controles.Boton(Me.components)
        Me.btnGenerar = New ISL.Controles.Boton(Me.components)
        Me.btnValidacion = New ISL.Controles.Boton(Me.components)
        Me.btnDetalleLibro = New Infragistics.Win.Misc.UltraButton()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesGuarda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboLibroGuarda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.ficLibroElectronico = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl21.SuspendLayout
        CType(Me.gridInventario, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdDetalleLibroElectronico, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl22.SuspendLayout
        CType(Me.griInv10, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl23.SuspendLayout
        CType(Me.griInv12, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl24.SuspendLayout
        CType(Me.griInv14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl25.SuspendLayout
        CType(Me.griInv16, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl26.SuspendLayout
        CType(Me.griInv19, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl27.SuspendLayout
        CType(Me.griInv20, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl28.SuspendLayout
        CType(Me.griInv30, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl29.SuspendLayout
        CType(Me.griInv34, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl30.SuspendLayout
        CType(Me.griInv41, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl31.SuspendLayout
        CType(Me.griInv42, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl32.SuspendLayout
        CType(Me.griInv46, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl33.SuspendLayout
        CType(Me.griInv47, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl34.SuspendLayout
        CType(Me.griInv37, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl35.SuspendLayout
        CType(Me.griInv50, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl36.SuspendLayout
        CType(Me.griInvParticionaria, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl37.SuspendLayout
        CType(Me.griInvBC, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl38.SuspendLayout
        CType(Me.griInvEFEMD, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl39.SuspendLayout
        CType(Me.griInvECPN, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl40.SuspendLayout
        CType(Me.griInvER, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl41.SuspendLayout
        Me.pnlNavegador.ClientArea.SuspendLayout
        Me.pnlNavegador.SuspendLayout
        CType(Me.agrNotas, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrNotas.SuspendLayout
        CType(Me.txtNombreArchivo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl42.SuspendLayout
        CType(Me.griInvERI, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl43.SuspendLayout
        CType(Me.griInvEFEMI, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl48.SuspendLayout
        CType(Me.gridActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl49.SuspendLayout
        CType(Me.griAct73, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl50.SuspendLayout
        CType(Me.griAct74, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl16.SuspendLayout
        CType(Me.griDetalleCompras, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl17.SuspendLayout
        CType(Me.griCompras2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl18.SuspendLayout
        CType(Me.griCompras3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl44.SuspendLayout
        CType(Me.gridCostos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl19.SuspendLayout
        CType(Me.griDetalleVentas, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl20.SuspendLayout
        CType(Me.griVentas2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl3.SuspendLayout
        CType(Me.gridCajaBancos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl5.SuspendLayout
        CType(Me.ficInventarioBalance, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficInventarioBalance.SuspendLayout
        Me.UltraTabPageControl10.SuspendLayout
        CType(Me.gridRentenciones, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl11.SuspendLayout
        CType(Me.griDetalleDiario, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.griDetalleDiarioPlanContable, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl12.SuspendLayout
        CType(Me.gridDiarioSimplificado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl13.SuspendLayout
        CType(Me.griDetalleMayor, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl14.SuspendLayout
        CType(Me.ficActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficActivoFijo.SuspendLayout
        Me.UltraTabPageControl15.SuspendLayout
        CType(Me.utcCompras, System.ComponentModel.ISupportInitialize).BeginInit
        Me.utcCompras.SuspendLayout
        Me.UltraTabPageControl1.SuspendLayout
        CType(Me.gridConsignacion, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl2.SuspendLayout
        CType(Me.ficRegistrosCostos, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficRegistrosCostos.SuspendLayout
        Me.UltraTabPageControl4.SuspendLayout
        CType(Me.gridPermanenteUF, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl6.SuspendLayout
        CType(Me.griPermanenteValorizado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl8.SuspendLayout
        CType(Me.UltraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabControl2.SuspendLayout
        Me.UltraTabPageControl9.SuspendLayout
        CType(Me.gridArchivoTexto, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ogdImportar, System.ComponentModel.ISupportInitialize).BeginInit
        Me.UltraTabPageControl7.SuspendLayout
        CType(Me.agrListaRegistro, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrListaRegistro.SuspendLayout
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Menu.SuspendLayout
        CType(Me.ogdLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrBusqueda.SuspendLayout
        CType(Me.cboMesLista, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboLibroLista, System.ComponentModel.ISupportInitialize).BeginInit
        Me.utpDetalle.SuspendLayout
        CType(Me.tabDetalleLibros, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabDetalleLibros.SuspendLayout
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit
        Me.agrDatoGeneral.SuspendLayout
        CType(Me.cboCuentaFinal, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboCuentaInicial, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decSubTotal4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decSubTotal3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decSubTotal2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.decSubTotal1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Agrupacion1.SuspendLayout
        CType(Me.cboMesGuarda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cboLibroGuarda, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ficLibroElectronico, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ficLibroElectronico.SuspendLayout
        Me.SuspendLayout
        '
        'UltraTabPageControl21
        '
        Me.UltraTabPageControl21.Controls.Add(Me.gridInventario)
        Me.UltraTabPageControl21.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl21.Name = "UltraTabPageControl21"
        Me.UltraTabPageControl21.Size = New System.Drawing.Size(1256, 251)
        '
        'gridInventario
        '
        Me.gridInventario.AllowDrop = True
        Me.gridInventario.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn284.Header.VisiblePosition = 0
        UltraGridColumn284.Hidden = True
        UltraGridColumn284.Width = 8
        UltraGridColumn285.Header.VisiblePosition = 1
        UltraGridColumn285.Hidden = True
        UltraGridColumn285.Width = 13
        UltraGridColumn286.Header.VisiblePosition = 2
        UltraGridColumn286.Hidden = True
        UltraGridColumn286.Width = 39
        UltraGridColumn287.Header.Caption = "Periodo (1)"
        UltraGridColumn287.Header.VisiblePosition = 3
        UltraGridColumn287.Width = 78
        UltraGridColumn288.Header.Caption = "Codigo de Catálogo (2)"
        UltraGridColumn288.Header.VisiblePosition = 4
        UltraGridColumn288.Width = 129
        UltraGridColumn289.Header.VisiblePosition = 5
        UltraGridColumn289.Hidden = True
        UltraGridColumn289.Width = 8
        UltraGridColumn290.Header.VisiblePosition = 6
        UltraGridColumn290.Hidden = True
        UltraGridColumn290.Width = 24
        UltraGridColumn291.Header.VisiblePosition = 7
        UltraGridColumn291.Hidden = True
        UltraGridColumn291.Width = 21
        UltraGridColumn292.Header.VisiblePosition = 8
        UltraGridColumn292.Hidden = True
        UltraGridColumn292.Width = 41
        UltraGridColumn293.Header.VisiblePosition = 9
        UltraGridColumn293.Hidden = True
        UltraGridColumn293.Width = 24
        UltraGridColumn294.Header.Caption = "Codigo Rubro (3)"
        UltraGridColumn294.Header.VisiblePosition = 10
        UltraGridColumn294.Width = 133
        UltraGridColumn295.Header.VisiblePosition = 11
        UltraGridColumn295.Hidden = True
        UltraGridColumn295.Width = 73
        UltraGridColumn296.Header.VisiblePosition = 12
        UltraGridColumn296.Hidden = True
        UltraGridColumn296.Width = 24
        UltraGridColumn297.Header.VisiblePosition = 13
        UltraGridColumn297.Hidden = True
        UltraGridColumn297.Width = 22
        UltraGridColumn298.Header.VisiblePosition = 14
        UltraGridColumn298.Hidden = True
        UltraGridColumn298.Width = 40
        UltraGridColumn299.Header.VisiblePosition = 15
        UltraGridColumn299.Hidden = True
        UltraGridColumn299.Width = 8
        UltraGridColumn300.Header.VisiblePosition = 16
        UltraGridColumn300.Hidden = True
        UltraGridColumn300.Width = 21
        UltraGridColumn301.Header.VisiblePosition = 17
        UltraGridColumn301.Hidden = True
        UltraGridColumn301.Width = 46
        UltraGridColumn302.Header.VisiblePosition = 18
        UltraGridColumn302.Hidden = True
        UltraGridColumn302.Width = 45
        UltraGridColumn303.Header.VisiblePosition = 19
        UltraGridColumn303.Hidden = True
        UltraGridColumn303.Width = 50
        UltraGridColumn304.Header.VisiblePosition = 20
        UltraGridColumn304.Hidden = True
        UltraGridColumn304.Width = 33
        UltraGridColumn305.Header.VisiblePosition = 21
        UltraGridColumn305.Hidden = True
        UltraGridColumn305.Width = 46
        UltraGridColumn306.Header.VisiblePosition = 22
        UltraGridColumn306.Hidden = True
        UltraGridColumn306.Width = 55
        UltraGridColumn307.Header.VisiblePosition = 23
        UltraGridColumn307.Hidden = True
        UltraGridColumn307.Width = 55
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn308.CellAppearance = Appearance1
        UltraGridColumn308.Header.Caption = "Saldo del Rubro (4)"
        UltraGridColumn308.Header.VisiblePosition = 24
        UltraGridColumn308.MaskInput = "{double:-9.2}"
        UltraGridColumn308.Width = 149
        UltraGridColumn309.Header.VisiblePosition = 25
        UltraGridColumn309.Hidden = True
        UltraGridColumn309.Width = 45
        UltraGridColumn310.Header.VisiblePosition = 26
        UltraGridColumn310.Hidden = True
        UltraGridColumn310.Width = 51
        UltraGridColumn311.Header.VisiblePosition = 27
        UltraGridColumn311.Hidden = True
        UltraGridColumn311.Width = 48
        UltraGridColumn312.Header.VisiblePosition = 28
        UltraGridColumn312.Hidden = True
        UltraGridColumn312.Width = 39
        UltraGridColumn313.Header.VisiblePosition = 29
        UltraGridColumn313.Hidden = True
        UltraGridColumn313.Width = 50
        UltraGridColumn314.Header.VisiblePosition = 30
        UltraGridColumn314.Hidden = True
        UltraGridColumn314.Width = 43
        UltraGridColumn315.Header.VisiblePosition = 31
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.Width = 59
        UltraGridColumn316.Header.VisiblePosition = 32
        UltraGridColumn316.Hidden = True
        UltraGridColumn316.Width = 72
        UltraGridColumn317.Header.VisiblePosition = 33
        UltraGridColumn317.Hidden = True
        UltraGridColumn317.Width = 42
        UltraGridColumn318.Header.Caption = "Indicador (5)"
        UltraGridColumn318.Header.VisiblePosition = 34
        UltraGridColumn318.Width = 87
        UltraGridColumn319.Header.VisiblePosition = 35
        UltraGridColumn319.Hidden = True
        UltraGridColumn319.Width = 44
        UltraGridColumn320.Header.VisiblePosition = 36
        UltraGridColumn320.Hidden = True
        UltraGridColumn320.Width = 67
        UltraGridColumn321.Header.VisiblePosition = 37
        UltraGridColumn321.Hidden = True
        UltraGridColumn321.Width = 52
        UltraGridColumn322.Header.VisiblePosition = 38
        UltraGridColumn322.Hidden = True
        UltraGridColumn322.Width = 59
        UltraGridColumn323.Header.VisiblePosition = 39
        UltraGridColumn323.Hidden = True
        UltraGridColumn323.Width = 68
        UltraGridColumn324.Header.VisiblePosition = 40
        UltraGridColumn324.Hidden = True
        UltraGridColumn324.Width = 92
        UltraGridColumn325.Header.VisiblePosition = 41
        UltraGridColumn325.Hidden = True
        UltraGridColumn325.Width = 49
        UltraGridColumn326.Header.VisiblePosition = 42
        UltraGridColumn326.Hidden = True
        UltraGridColumn326.Width = 84
        UltraGridColumn327.Header.VisiblePosition = 43
        UltraGridColumn327.Hidden = True
        UltraGridColumn327.Width = 108
        UltraGridColumn328.Header.VisiblePosition = 44
        UltraGridColumn328.Hidden = True
        UltraGridColumn328.Width = 55
        UltraGridColumn329.Header.VisiblePosition = 45
        UltraGridColumn329.Hidden = True
        UltraGridColumn329.Width = 57
        UltraGridColumn330.Header.VisiblePosition = 46
        UltraGridColumn330.Hidden = True
        UltraGridColumn330.Width = 58
        UltraGridColumn331.Header.VisiblePosition = 47
        UltraGridColumn331.Hidden = True
        UltraGridColumn331.Width = 54
        UltraGridColumn332.Header.VisiblePosition = 48
        UltraGridColumn332.Hidden = True
        UltraGridColumn332.Width = 114
        UltraGridColumn333.Header.VisiblePosition = 49
        UltraGridColumn333.Hidden = True
        UltraGridColumn333.Width = 48
        UltraGridColumn334.Header.VisiblePosition = 50
        UltraGridColumn334.Hidden = True
        UltraGridColumn334.Width = 39
        UltraGridColumn335.Header.VisiblePosition = 51
        UltraGridColumn335.Hidden = True
        UltraGridColumn335.Width = 65
        UltraGridColumn336.Header.VisiblePosition = 52
        UltraGridColumn336.Hidden = True
        UltraGridColumn336.Width = 69
        UltraGridColumn337.Header.VisiblePosition = 53
        UltraGridColumn337.Hidden = True
        UltraGridColumn337.Width = 71
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn296, UltraGridColumn297, UltraGridColumn298, UltraGridColumn299, UltraGridColumn300, UltraGridColumn301, UltraGridColumn302, UltraGridColumn303, UltraGridColumn304, UltraGridColumn305, UltraGridColumn306, UltraGridColumn307, UltraGridColumn308, UltraGridColumn309, UltraGridColumn310, UltraGridColumn311, UltraGridColumn312, UltraGridColumn313, UltraGridColumn314, UltraGridColumn315, UltraGridColumn316, UltraGridColumn317, UltraGridColumn318, UltraGridColumn319, UltraGridColumn320, UltraGridColumn321, UltraGridColumn322, UltraGridColumn323, UltraGridColumn324, UltraGridColumn325, UltraGridColumn326, UltraGridColumn327, UltraGridColumn328, UltraGridColumn329, UltraGridColumn330, UltraGridColumn331, UltraGridColumn332, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337})
        Me.gridInventario.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridInventario.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridInventario.DisplayLayout.MaxColScrollRegions = 1
        Me.gridInventario.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridInventario.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridInventario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridInventario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridInventario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridInventario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridInventario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridInventario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridInventario.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.gridInventario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridInventario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridInventario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridInventario.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Bottom
        Me.gridInventario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridInventario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridInventario.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridInventario.Location = New System.Drawing.Point(0, 0)
        Me.gridInventario.Name = "gridInventario"
        Me.gridInventario.Size = New System.Drawing.Size(1256, 251)
        Me.gridInventario.TabIndex = 2
        Me.gridInventario.Text = "3.1 ESTADO DE SITUACION FINANCIERA"
        '
        'ogdDetalleLibroElectronico
        '
        UltraDataColumn50.DataType = GetType(Double)
        UltraDataColumn51.DataType = GetType(Double)
        Me.ogdDetalleLibroElectronico.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl22
        '
        Me.UltraTabPageControl22.Controls.Add(Me.griInv10)
        Me.UltraTabPageControl22.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl22.Name = "UltraTabPageControl22"
        Me.UltraTabPageControl22.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv10
        '
        Me.griInv10.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn338.Header.VisiblePosition = 0
        UltraGridColumn338.Hidden = True
        UltraGridColumn339.Header.VisiblePosition = 1
        UltraGridColumn339.Hidden = True
        UltraGridColumn340.Header.VisiblePosition = 2
        UltraGridColumn340.Hidden = True
        UltraGridColumn341.Header.Caption = "Periodo (1)"
        UltraGridColumn341.Header.VisiblePosition = 3
        UltraGridColumn342.Header.Caption = "Cuenta Contable (2)"
        UltraGridColumn342.Header.VisiblePosition = 4
        UltraGridColumn343.Header.VisiblePosition = 5
        UltraGridColumn343.Hidden = True
        UltraGridColumn344.Header.VisiblePosition = 6
        UltraGridColumn344.Hidden = True
        UltraGridColumn345.Header.VisiblePosition = 7
        UltraGridColumn345.Hidden = True
        UltraGridColumn346.Header.VisiblePosition = 8
        UltraGridColumn346.Hidden = True
        UltraGridColumn347.Header.VisiblePosition = 9
        UltraGridColumn347.Hidden = True
        UltraGridColumn348.Header.Caption = "Codigo Entidad Bancaria (3)"
        UltraGridColumn348.Header.VisiblePosition = 10
        UltraGridColumn349.Header.Caption = "Numero Cuenta (4)"
        UltraGridColumn349.Header.VisiblePosition = 11
        UltraGridColumn350.Header.VisiblePosition = 12
        UltraGridColumn350.Hidden = True
        UltraGridColumn351.Header.VisiblePosition = 13
        UltraGridColumn351.Hidden = True
        UltraGridColumn352.Header.VisiblePosition = 14
        UltraGridColumn352.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn353.CellAppearance = Appearance2
        UltraGridColumn353.Header.Caption = "Saldo Deudor (6)"
        UltraGridColumn353.Header.VisiblePosition = 16
        UltraGridColumn353.MaskInput = "{double:-9.2}"
        UltraGridColumn354.Header.VisiblePosition = 17
        UltraGridColumn354.Hidden = True
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn355.CellAppearance = Appearance3
        UltraGridColumn355.Header.Caption = "Saldo Acreedor (7)"
        UltraGridColumn355.Header.VisiblePosition = 18
        UltraGridColumn355.MaskInput = "{double:-9.2}"
        UltraGridColumn356.Header.VisiblePosition = 19
        UltraGridColumn356.Hidden = True
        UltraGridColumn357.Header.VisiblePosition = 20
        UltraGridColumn357.Hidden = True
        UltraGridColumn358.Header.VisiblePosition = 21
        UltraGridColumn358.Hidden = True
        UltraGridColumn359.Header.VisiblePosition = 22
        UltraGridColumn359.Hidden = True
        UltraGridColumn360.Header.VisiblePosition = 23
        UltraGridColumn360.Hidden = True
        UltraGridColumn361.Header.VisiblePosition = 24
        UltraGridColumn361.Hidden = True
        UltraGridColumn362.Header.VisiblePosition = 25
        UltraGridColumn362.Hidden = True
        UltraGridColumn363.Header.VisiblePosition = 26
        UltraGridColumn363.Hidden = True
        UltraGridColumn364.Header.VisiblePosition = 27
        UltraGridColumn364.Hidden = True
        UltraGridColumn365.Header.VisiblePosition = 28
        UltraGridColumn365.Hidden = True
        UltraGridColumn366.Header.VisiblePosition = 29
        UltraGridColumn366.Hidden = True
        UltraGridColumn367.Header.VisiblePosition = 30
        UltraGridColumn367.Hidden = True
        UltraGridColumn368.Header.VisiblePosition = 31
        UltraGridColumn368.Hidden = True
        UltraGridColumn369.Header.VisiblePosition = 32
        UltraGridColumn369.Hidden = True
        UltraGridColumn370.Header.VisiblePosition = 33
        UltraGridColumn370.Hidden = True
        UltraGridColumn371.Header.VisiblePosition = 34
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.Header.Caption = "Indicador (8)"
        UltraGridColumn372.Header.VisiblePosition = 35
        UltraGridColumn373.Header.VisiblePosition = 36
        UltraGridColumn373.Hidden = True
        UltraGridColumn374.Header.VisiblePosition = 37
        UltraGridColumn374.Hidden = True
        UltraGridColumn375.Header.VisiblePosition = 38
        UltraGridColumn375.Hidden = True
        UltraGridColumn376.Header.VisiblePosition = 39
        UltraGridColumn376.Hidden = True
        UltraGridColumn377.Header.VisiblePosition = 40
        UltraGridColumn377.Hidden = True
        UltraGridColumn378.Header.VisiblePosition = 41
        UltraGridColumn378.Hidden = True
        UltraGridColumn379.Header.Caption = "Moneda (5)"
        UltraGridColumn379.Header.VisiblePosition = 15
        UltraGridColumn380.Header.VisiblePosition = 42
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 43
        UltraGridColumn381.Hidden = True
        UltraGridColumn382.Header.VisiblePosition = 44
        UltraGridColumn382.Hidden = True
        UltraGridColumn383.Header.VisiblePosition = 45
        UltraGridColumn383.Hidden = True
        UltraGridColumn384.Header.VisiblePosition = 46
        UltraGridColumn384.Hidden = True
        UltraGridColumn385.Header.VisiblePosition = 47
        UltraGridColumn385.Hidden = True
        UltraGridColumn386.Header.VisiblePosition = 48
        UltraGridColumn386.Hidden = True
        UltraGridColumn387.Header.VisiblePosition = 49
        UltraGridColumn387.Hidden = True
        UltraGridColumn388.Header.VisiblePosition = 50
        UltraGridColumn388.Hidden = True
        UltraGridColumn389.Header.VisiblePosition = 51
        UltraGridColumn389.Hidden = True
        UltraGridColumn390.Header.VisiblePosition = 52
        UltraGridColumn390.Hidden = True
        UltraGridColumn391.Header.VisiblePosition = 53
        UltraGridColumn391.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381, UltraGridColumn382, UltraGridColumn383, UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391})
        Me.griInv10.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griInv10.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv10.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv10.DisplayLayout.DefaultSelectedBackColor = System.Drawing.Color.Empty
        Me.griInv10.DisplayLayout.DefaultSelectedForeColor = System.Drawing.Color.Empty
        Me.griInv10.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv10.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv10.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv10.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv10.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv10.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv10.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv10.DisplayLayout.Override.CellPadding = 0
        Me.griInv10.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv10.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv10.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv10.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv10.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv10.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButtonFixedSize
        Me.griInv10.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv10.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv10.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv10.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv10.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv10.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv10.Location = New System.Drawing.Point(0, 0)
        Me.griInv10.Name = "griInv10"
        Me.griInv10.Size = New System.Drawing.Size(1256, 251)
        Me.griInv10.TabIndex = 0
        Me.griInv10.Text = "3.2 Cuenta 10"
        '
        'UltraTabPageControl23
        '
        Me.UltraTabPageControl23.Controls.Add(Me.griInv12)
        Me.UltraTabPageControl23.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl23.Name = "UltraTabPageControl23"
        Me.UltraTabPageControl23.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv12
        '
        Me.griInv12.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn392.Header.VisiblePosition = 0
        UltraGridColumn392.Hidden = True
        UltraGridColumn393.Header.VisiblePosition = 1
        UltraGridColumn393.Hidden = True
        UltraGridColumn394.Header.VisiblePosition = 2
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.Caption = "Periodo (1)"
        UltraGridColumn395.Header.VisiblePosition = 3
        UltraGridColumn396.Header.Caption = "Codigo Unico Operacion (2)"
        UltraGridColumn396.Header.VisiblePosition = 4
        UltraGridColumn397.Header.Caption = "Fecha Inicio (7)"
        UltraGridColumn397.Header.VisiblePosition = 13
        UltraGridColumn397.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn398.Header.VisiblePosition = 5
        UltraGridColumn398.Hidden = True
        UltraGridColumn399.Header.VisiblePosition = 6
        UltraGridColumn399.Hidden = True
        UltraGridColumn400.Header.VisiblePosition = 7
        UltraGridColumn400.Hidden = True
        UltraGridColumn401.Header.VisiblePosition = 8
        UltraGridColumn401.Hidden = True
        UltraGridColumn402.Header.Caption = "Numero Correlativo (3)"
        UltraGridColumn402.Header.VisiblePosition = 9
        UltraGridColumn403.Header.Caption = "Razon Social (6)"
        UltraGridColumn403.Header.VisiblePosition = 12
        UltraGridColumn404.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn404.Header.VisiblePosition = 10
        UltraGridColumn405.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn405.Header.VisiblePosition = 11
        UltraGridColumn406.Header.VisiblePosition = 14
        UltraGridColumn406.Hidden = True
        UltraGridColumn407.Header.VisiblePosition = 15
        UltraGridColumn407.Hidden = True
        UltraGridColumn408.Header.VisiblePosition = 16
        UltraGridColumn408.Hidden = True
        UltraGridColumn409.Header.VisiblePosition = 17
        UltraGridColumn409.Hidden = True
        UltraGridColumn410.Header.VisiblePosition = 18
        UltraGridColumn410.Hidden = True
        UltraGridColumn411.Header.VisiblePosition = 19
        UltraGridColumn411.Hidden = True
        UltraGridColumn412.Header.VisiblePosition = 20
        UltraGridColumn412.Hidden = True
        UltraGridColumn413.Header.VisiblePosition = 21
        UltraGridColumn413.Hidden = True
        UltraGridColumn414.Header.VisiblePosition = 22
        UltraGridColumn414.Hidden = True
        UltraGridColumn415.Header.VisiblePosition = 23
        UltraGridColumn415.Hidden = True
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn416.CellAppearance = Appearance4
        UltraGridColumn416.Header.Caption = "Monto (8)"
        UltraGridColumn416.Header.VisiblePosition = 24
        UltraGridColumn416.MaskInput = "{double:-9.2}"
        UltraGridColumn417.Header.VisiblePosition = 25
        UltraGridColumn417.Hidden = True
        UltraGridColumn418.Header.VisiblePosition = 26
        UltraGridColumn418.Hidden = True
        UltraGridColumn419.Header.VisiblePosition = 27
        UltraGridColumn419.Hidden = True
        UltraGridColumn420.Header.VisiblePosition = 28
        UltraGridColumn420.Hidden = True
        UltraGridColumn421.Header.VisiblePosition = 29
        UltraGridColumn421.Hidden = True
        UltraGridColumn422.Header.VisiblePosition = 30
        UltraGridColumn422.Hidden = True
        UltraGridColumn423.Header.VisiblePosition = 31
        UltraGridColumn423.Hidden = True
        UltraGridColumn424.Header.VisiblePosition = 32
        UltraGridColumn424.Hidden = True
        UltraGridColumn425.Header.VisiblePosition = 33
        UltraGridColumn425.Hidden = True
        UltraGridColumn426.Header.Caption = "Indicador (9)"
        UltraGridColumn426.Header.VisiblePosition = 34
        UltraGridColumn427.Header.VisiblePosition = 35
        UltraGridColumn427.Hidden = True
        UltraGridColumn428.Header.VisiblePosition = 36
        UltraGridColumn428.Hidden = True
        UltraGridColumn429.Header.VisiblePosition = 37
        UltraGridColumn429.Hidden = True
        UltraGridColumn430.Header.VisiblePosition = 38
        UltraGridColumn430.Hidden = True
        UltraGridColumn431.Header.VisiblePosition = 39
        UltraGridColumn431.Hidden = True
        UltraGridColumn432.Header.VisiblePosition = 40
        UltraGridColumn432.Hidden = True
        UltraGridColumn433.Header.VisiblePosition = 41
        UltraGridColumn433.Hidden = True
        UltraGridColumn434.Header.VisiblePosition = 42
        UltraGridColumn434.Hidden = True
        UltraGridColumn435.Header.VisiblePosition = 43
        UltraGridColumn435.Hidden = True
        UltraGridColumn436.Header.VisiblePosition = 44
        UltraGridColumn436.Hidden = True
        UltraGridColumn437.Header.VisiblePosition = 45
        UltraGridColumn437.Hidden = True
        UltraGridColumn438.Header.VisiblePosition = 46
        UltraGridColumn438.Hidden = True
        UltraGridColumn439.Header.VisiblePosition = 47
        UltraGridColumn439.Hidden = True
        UltraGridColumn440.Header.VisiblePosition = 48
        UltraGridColumn440.Hidden = True
        UltraGridColumn441.Header.VisiblePosition = 49
        UltraGridColumn441.Hidden = True
        UltraGridColumn442.Header.VisiblePosition = 50
        UltraGridColumn442.Hidden = True
        UltraGridColumn443.Header.VisiblePosition = 51
        UltraGridColumn443.Hidden = True
        UltraGridColumn444.Header.VisiblePosition = 52
        UltraGridColumn444.Hidden = True
        UltraGridColumn445.Header.VisiblePosition = 53
        UltraGridColumn445.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396, UltraGridColumn397, UltraGridColumn398, UltraGridColumn399, UltraGridColumn400, UltraGridColumn401, UltraGridColumn402, UltraGridColumn403, UltraGridColumn404, UltraGridColumn405, UltraGridColumn406, UltraGridColumn407, UltraGridColumn408, UltraGridColumn409, UltraGridColumn410, UltraGridColumn411, UltraGridColumn412, UltraGridColumn413, UltraGridColumn414, UltraGridColumn415, UltraGridColumn416, UltraGridColumn417, UltraGridColumn418, UltraGridColumn419, UltraGridColumn420, UltraGridColumn421, UltraGridColumn422, UltraGridColumn423, UltraGridColumn424, UltraGridColumn425, UltraGridColumn426, UltraGridColumn427, UltraGridColumn428, UltraGridColumn429, UltraGridColumn430, UltraGridColumn431, UltraGridColumn432, UltraGridColumn433, UltraGridColumn434, UltraGridColumn435, UltraGridColumn436, UltraGridColumn437, UltraGridColumn438, UltraGridColumn439, UltraGridColumn440, UltraGridColumn441, UltraGridColumn442, UltraGridColumn443, UltraGridColumn444, UltraGridColumn445})
        Me.griInv12.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griInv12.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv12.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv12.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv12.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv12.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv12.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv12.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv12.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv12.DisplayLayout.Override.CellPadding = 0
        Me.griInv12.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv12.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv12.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv12.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv12.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv12.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv12.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv12.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv12.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv12.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv12.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv12.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv12.Location = New System.Drawing.Point(0, 0)
        Me.griInv12.Name = "griInv12"
        Me.griInv12.Size = New System.Drawing.Size(1256, 251)
        Me.griInv12.TabIndex = 0
        Me.griInv12.Text = "3.3 Cuenta 12"
        '
        'UltraTabPageControl24
        '
        Me.UltraTabPageControl24.Controls.Add(Me.griInv14)
        Me.UltraTabPageControl24.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl24.Name = "UltraTabPageControl24"
        Me.UltraTabPageControl24.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv14
        '
        Me.griInv14.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn446.Header.VisiblePosition = 0
        UltraGridColumn446.Hidden = True
        UltraGridColumn447.Header.VisiblePosition = 1
        UltraGridColumn447.Hidden = True
        UltraGridColumn448.Header.VisiblePosition = 2
        UltraGridColumn448.Hidden = True
        UltraGridColumn449.Header.Caption = "Periodo (1)"
        UltraGridColumn449.Header.VisiblePosition = 3
        UltraGridColumn450.Header.Caption = "Codigo Unico Operacion (2)"
        UltraGridColumn450.Header.VisiblePosition = 4
        UltraGridColumn451.Header.Caption = "Fecha Inicio (7)"
        UltraGridColumn451.Header.VisiblePosition = 13
        UltraGridColumn451.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn452.Header.VisiblePosition = 5
        UltraGridColumn452.Hidden = True
        UltraGridColumn453.Header.VisiblePosition = 6
        UltraGridColumn453.Hidden = True
        UltraGridColumn454.Header.VisiblePosition = 7
        UltraGridColumn454.Hidden = True
        UltraGridColumn455.Header.VisiblePosition = 8
        UltraGridColumn455.Hidden = True
        UltraGridColumn456.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn456.Header.VisiblePosition = 9
        UltraGridColumn457.Header.Caption = "Apellido y Nombres (6)"
        UltraGridColumn457.Header.VisiblePosition = 12
        UltraGridColumn458.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn458.Header.VisiblePosition = 10
        UltraGridColumn459.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn459.Header.VisiblePosition = 11
        UltraGridColumn460.Header.VisiblePosition = 14
        UltraGridColumn460.Hidden = True
        UltraGridColumn461.Header.VisiblePosition = 15
        UltraGridColumn461.Hidden = True
        UltraGridColumn462.Header.VisiblePosition = 16
        UltraGridColumn462.Hidden = True
        UltraGridColumn463.Header.VisiblePosition = 17
        UltraGridColumn463.Hidden = True
        UltraGridColumn464.Header.VisiblePosition = 18
        UltraGridColumn464.Hidden = True
        UltraGridColumn465.Header.VisiblePosition = 19
        UltraGridColumn465.Hidden = True
        UltraGridColumn466.Header.VisiblePosition = 20
        UltraGridColumn466.Hidden = True
        UltraGridColumn467.Header.VisiblePosition = 21
        UltraGridColumn467.Hidden = True
        UltraGridColumn468.Header.VisiblePosition = 22
        UltraGridColumn468.Hidden = True
        UltraGridColumn469.Header.VisiblePosition = 23
        UltraGridColumn469.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn470.CellAppearance = Appearance5
        UltraGridColumn470.Header.Caption = "Monto (8)"
        UltraGridColumn470.Header.VisiblePosition = 24
        UltraGridColumn470.MaskInput = "{double:-9.2}"
        UltraGridColumn471.Header.VisiblePosition = 25
        UltraGridColumn471.Hidden = True
        UltraGridColumn472.Header.VisiblePosition = 26
        UltraGridColumn472.Hidden = True
        UltraGridColumn473.Header.VisiblePosition = 27
        UltraGridColumn473.Hidden = True
        UltraGridColumn474.Header.VisiblePosition = 28
        UltraGridColumn474.Hidden = True
        UltraGridColumn475.Header.VisiblePosition = 29
        UltraGridColumn475.Hidden = True
        UltraGridColumn476.Header.VisiblePosition = 30
        UltraGridColumn476.Hidden = True
        UltraGridColumn477.Header.VisiblePosition = 31
        UltraGridColumn477.Hidden = True
        UltraGridColumn478.Header.VisiblePosition = 32
        UltraGridColumn478.Hidden = True
        UltraGridColumn479.Header.VisiblePosition = 33
        UltraGridColumn479.Hidden = True
        UltraGridColumn480.Header.Caption = "Indicador (9)"
        UltraGridColumn480.Header.VisiblePosition = 34
        UltraGridColumn481.Header.VisiblePosition = 35
        UltraGridColumn481.Hidden = True
        UltraGridColumn482.Header.VisiblePosition = 36
        UltraGridColumn482.Hidden = True
        UltraGridColumn483.Header.VisiblePosition = 37
        UltraGridColumn483.Hidden = True
        UltraGridColumn484.Header.VisiblePosition = 38
        UltraGridColumn484.Hidden = True
        UltraGridColumn485.Header.VisiblePosition = 39
        UltraGridColumn485.Hidden = True
        UltraGridColumn486.Header.VisiblePosition = 40
        UltraGridColumn486.Hidden = True
        UltraGridColumn487.Header.VisiblePosition = 41
        UltraGridColumn487.Hidden = True
        UltraGridColumn488.Header.VisiblePosition = 42
        UltraGridColumn488.Hidden = True
        UltraGridColumn489.Header.VisiblePosition = 43
        UltraGridColumn489.Hidden = True
        UltraGridColumn490.Header.VisiblePosition = 44
        UltraGridColumn490.Hidden = True
        UltraGridColumn491.Header.VisiblePosition = 45
        UltraGridColumn491.Hidden = True
        UltraGridColumn492.Header.VisiblePosition = 46
        UltraGridColumn492.Hidden = True
        UltraGridColumn493.Header.VisiblePosition = 47
        UltraGridColumn493.Hidden = True
        UltraGridColumn494.Header.VisiblePosition = 48
        UltraGridColumn494.Hidden = True
        UltraGridColumn495.Header.VisiblePosition = 49
        UltraGridColumn495.Hidden = True
        UltraGridColumn496.Header.VisiblePosition = 50
        UltraGridColumn496.Hidden = True
        UltraGridColumn497.Header.VisiblePosition = 51
        UltraGridColumn497.Hidden = True
        UltraGridColumn498.Header.VisiblePosition = 52
        UltraGridColumn498.Hidden = True
        UltraGridColumn499.Header.VisiblePosition = 53
        UltraGridColumn499.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn446, UltraGridColumn447, UltraGridColumn448, UltraGridColumn449, UltraGridColumn450, UltraGridColumn451, UltraGridColumn452, UltraGridColumn453, UltraGridColumn454, UltraGridColumn455, UltraGridColumn456, UltraGridColumn457, UltraGridColumn458, UltraGridColumn459, UltraGridColumn460, UltraGridColumn461, UltraGridColumn462, UltraGridColumn463, UltraGridColumn464, UltraGridColumn465, UltraGridColumn466, UltraGridColumn467, UltraGridColumn468, UltraGridColumn469, UltraGridColumn470, UltraGridColumn471, UltraGridColumn472, UltraGridColumn473, UltraGridColumn474, UltraGridColumn475, UltraGridColumn476, UltraGridColumn477, UltraGridColumn478, UltraGridColumn479, UltraGridColumn480, UltraGridColumn481, UltraGridColumn482, UltraGridColumn483, UltraGridColumn484, UltraGridColumn485, UltraGridColumn486, UltraGridColumn487, UltraGridColumn488, UltraGridColumn489, UltraGridColumn490, UltraGridColumn491, UltraGridColumn492, UltraGridColumn493, UltraGridColumn494, UltraGridColumn495, UltraGridColumn496, UltraGridColumn497, UltraGridColumn498, UltraGridColumn499})
        Me.griInv14.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griInv14.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv14.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv14.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv14.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv14.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv14.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv14.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv14.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv14.DisplayLayout.Override.CellPadding = 0
        Me.griInv14.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv14.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv14.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv14.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv14.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv14.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv14.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv14.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv14.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv14.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv14.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv14.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv14.Location = New System.Drawing.Point(0, 0)
        Me.griInv14.Name = "griInv14"
        Me.griInv14.Size = New System.Drawing.Size(1256, 251)
        Me.griInv14.TabIndex = 0
        Me.griInv14.Text = "3.4 Cuenta 14"
        '
        'UltraTabPageControl25
        '
        Me.UltraTabPageControl25.Controls.Add(Me.griInv16)
        Me.UltraTabPageControl25.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl25.Name = "UltraTabPageControl25"
        Me.UltraTabPageControl25.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv16
        '
        Me.griInv16.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn500.Header.VisiblePosition = 0
        UltraGridColumn500.Hidden = True
        UltraGridColumn501.Header.VisiblePosition = 1
        UltraGridColumn501.Hidden = True
        UltraGridColumn502.Header.VisiblePosition = 2
        UltraGridColumn502.Hidden = True
        UltraGridColumn503.Header.Caption = "Periodo (1)"
        UltraGridColumn503.Header.VisiblePosition = 3
        UltraGridColumn504.Header.Caption = "Codigo Unico Operacion (2)"
        UltraGridColumn504.Header.VisiblePosition = 4
        UltraGridColumn505.Header.Caption = "Fecha Emision (7)"
        UltraGridColumn505.Header.VisiblePosition = 23
        UltraGridColumn505.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn505.Width = 135
        UltraGridColumn506.Header.VisiblePosition = 5
        UltraGridColumn506.Hidden = True
        UltraGridColumn507.Header.VisiblePosition = 6
        UltraGridColumn507.Hidden = True
        UltraGridColumn508.Header.VisiblePosition = 7
        UltraGridColumn508.Hidden = True
        UltraGridColumn509.Header.VisiblePosition = 8
        UltraGridColumn509.Hidden = True
        UltraGridColumn510.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn510.Header.VisiblePosition = 9
        UltraGridColumn511.Header.Caption = "Razon Social (6)"
        UltraGridColumn511.Header.VisiblePosition = 12
        UltraGridColumn512.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn512.Header.VisiblePosition = 10
        UltraGridColumn513.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn513.Header.VisiblePosition = 11
        UltraGridColumn514.Header.VisiblePosition = 13
        UltraGridColumn514.Hidden = True
        UltraGridColumn515.Header.VisiblePosition = 14
        UltraGridColumn515.Hidden = True
        UltraGridColumn516.Header.VisiblePosition = 15
        UltraGridColumn516.Hidden = True
        UltraGridColumn517.Header.VisiblePosition = 16
        UltraGridColumn517.Hidden = True
        UltraGridColumn518.Header.VisiblePosition = 17
        UltraGridColumn518.Hidden = True
        UltraGridColumn519.Header.VisiblePosition = 18
        UltraGridColumn519.Hidden = True
        UltraGridColumn520.Header.VisiblePosition = 19
        UltraGridColumn520.Hidden = True
        UltraGridColumn521.Header.VisiblePosition = 20
        UltraGridColumn521.Hidden = True
        UltraGridColumn522.Header.VisiblePosition = 21
        UltraGridColumn522.Hidden = True
        UltraGridColumn523.Header.VisiblePosition = 22
        UltraGridColumn523.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn524.CellAppearance = Appearance6
        UltraGridColumn524.Header.Caption = "Monto (8)"
        UltraGridColumn524.Header.VisiblePosition = 24
        UltraGridColumn524.MaskInput = "{double:-9.2}"
        UltraGridColumn525.Header.VisiblePosition = 25
        UltraGridColumn525.Hidden = True
        UltraGridColumn526.Header.VisiblePosition = 26
        UltraGridColumn526.Hidden = True
        UltraGridColumn527.Header.VisiblePosition = 27
        UltraGridColumn527.Hidden = True
        UltraGridColumn528.Header.VisiblePosition = 28
        UltraGridColumn528.Hidden = True
        UltraGridColumn529.Header.VisiblePosition = 29
        UltraGridColumn529.Hidden = True
        UltraGridColumn530.Header.Caption = "Razon Social (6)"
        UltraGridColumn530.Header.VisiblePosition = 30
        UltraGridColumn530.Hidden = True
        UltraGridColumn531.Header.VisiblePosition = 31
        UltraGridColumn531.Hidden = True
        UltraGridColumn532.Header.VisiblePosition = 32
        UltraGridColumn532.Hidden = True
        UltraGridColumn533.Header.VisiblePosition = 33
        UltraGridColumn533.Hidden = True
        UltraGridColumn534.Header.Caption = "Indicador (9)"
        UltraGridColumn534.Header.VisiblePosition = 34
        UltraGridColumn535.Header.VisiblePosition = 35
        UltraGridColumn535.Hidden = True
        UltraGridColumn536.Header.VisiblePosition = 36
        UltraGridColumn536.Hidden = True
        UltraGridColumn537.Header.VisiblePosition = 37
        UltraGridColumn537.Hidden = True
        UltraGridColumn538.Header.VisiblePosition = 38
        UltraGridColumn538.Hidden = True
        UltraGridColumn539.Header.VisiblePosition = 39
        UltraGridColumn539.Hidden = True
        UltraGridColumn540.Header.VisiblePosition = 40
        UltraGridColumn540.Hidden = True
        UltraGridColumn541.Header.VisiblePosition = 41
        UltraGridColumn541.Hidden = True
        UltraGridColumn542.Header.VisiblePosition = 42
        UltraGridColumn542.Hidden = True
        UltraGridColumn543.Header.VisiblePosition = 43
        UltraGridColumn543.Hidden = True
        UltraGridColumn544.Header.VisiblePosition = 44
        UltraGridColumn544.Hidden = True
        UltraGridColumn545.Header.VisiblePosition = 45
        UltraGridColumn545.Hidden = True
        UltraGridColumn546.Header.VisiblePosition = 46
        UltraGridColumn546.Hidden = True
        UltraGridColumn547.Header.VisiblePosition = 47
        UltraGridColumn547.Hidden = True
        UltraGridColumn548.Header.VisiblePosition = 48
        UltraGridColumn548.Hidden = True
        UltraGridColumn549.Header.VisiblePosition = 49
        UltraGridColumn549.Hidden = True
        UltraGridColumn550.Header.VisiblePosition = 50
        UltraGridColumn550.Hidden = True
        UltraGridColumn551.Header.VisiblePosition = 51
        UltraGridColumn551.Hidden = True
        UltraGridColumn552.Header.VisiblePosition = 52
        UltraGridColumn552.Hidden = True
        UltraGridColumn553.Header.VisiblePosition = 53
        UltraGridColumn553.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn500, UltraGridColumn501, UltraGridColumn502, UltraGridColumn503, UltraGridColumn504, UltraGridColumn505, UltraGridColumn506, UltraGridColumn507, UltraGridColumn508, UltraGridColumn509, UltraGridColumn510, UltraGridColumn511, UltraGridColumn512, UltraGridColumn513, UltraGridColumn514, UltraGridColumn515, UltraGridColumn516, UltraGridColumn517, UltraGridColumn518, UltraGridColumn519, UltraGridColumn520, UltraGridColumn521, UltraGridColumn522, UltraGridColumn523, UltraGridColumn524, UltraGridColumn525, UltraGridColumn526, UltraGridColumn527, UltraGridColumn528, UltraGridColumn529, UltraGridColumn530, UltraGridColumn531, UltraGridColumn532, UltraGridColumn533, UltraGridColumn534, UltraGridColumn535, UltraGridColumn536, UltraGridColumn537, UltraGridColumn538, UltraGridColumn539, UltraGridColumn540, UltraGridColumn541, UltraGridColumn542, UltraGridColumn543, UltraGridColumn544, UltraGridColumn545, UltraGridColumn546, UltraGridColumn547, UltraGridColumn548, UltraGridColumn549, UltraGridColumn550, UltraGridColumn551, UltraGridColumn552, UltraGridColumn553})
        Me.griInv16.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griInv16.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv16.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv16.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv16.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv16.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv16.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv16.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv16.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv16.DisplayLayout.Override.CellPadding = 0
        Me.griInv16.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv16.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv16.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv16.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv16.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv16.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv16.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv16.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv16.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv16.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv16.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv16.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv16.Location = New System.Drawing.Point(0, 0)
        Me.griInv16.Name = "griInv16"
        Me.griInv16.Size = New System.Drawing.Size(1256, 251)
        Me.griInv16.TabIndex = 0
        Me.griInv16.Text = "3.5 Detalle Cuenta 16"
        '
        'UltraTabPageControl26
        '
        Me.UltraTabPageControl26.Controls.Add(Me.griInv19)
        Me.UltraTabPageControl26.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl26.Name = "UltraTabPageControl26"
        Me.UltraTabPageControl26.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv19
        '
        Me.griInv19.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn554.Header.VisiblePosition = 0
        UltraGridColumn554.Hidden = True
        UltraGridColumn555.Header.VisiblePosition = 1
        UltraGridColumn555.Hidden = True
        UltraGridColumn556.Header.VisiblePosition = 2
        UltraGridColumn556.Hidden = True
        UltraGridColumn557.Header.Caption = "Periodo (1)"
        UltraGridColumn557.Header.VisiblePosition = 3
        UltraGridColumn557.Width = 77
        UltraGridColumn558.Header.Caption = "CUO (2)"
        UltraGridColumn558.Header.VisiblePosition = 4
        UltraGridColumn558.Width = 89
        UltraGridColumn559.Header.Caption = "Fec Emision (10)"
        UltraGridColumn559.Header.VisiblePosition = 12
        UltraGridColumn559.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn560.Header.VisiblePosition = 13
        UltraGridColumn560.Hidden = True
        UltraGridColumn561.Header.Caption = "Tipo Doc (7)"
        UltraGridColumn561.Header.VisiblePosition = 9
        UltraGridColumn562.Header.Caption = "Serie Doc (8)"
        UltraGridColumn562.Header.VisiblePosition = 10
        UltraGridColumn563.Header.VisiblePosition = 14
        UltraGridColumn563.Hidden = True
        UltraGridColumn564.Header.Caption = "Numero Doc (9)"
        UltraGridColumn564.Header.VisiblePosition = 11
        UltraGridColumn565.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn565.Header.VisiblePosition = 5
        UltraGridColumn566.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn566.Header.VisiblePosition = 6
        UltraGridColumn567.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn567.Header.VisiblePosition = 7
        UltraGridColumn568.Header.VisiblePosition = 15
        UltraGridColumn568.Hidden = True
        UltraGridColumn569.Header.VisiblePosition = 16
        UltraGridColumn569.Hidden = True
        UltraGridColumn570.Header.VisiblePosition = 17
        UltraGridColumn570.Hidden = True
        UltraGridColumn571.Header.VisiblePosition = 18
        UltraGridColumn571.Hidden = True
        UltraGridColumn572.Header.VisiblePosition = 19
        UltraGridColumn572.Hidden = True
        UltraGridColumn573.Header.VisiblePosition = 20
        UltraGridColumn573.Hidden = True
        UltraGridColumn574.Header.VisiblePosition = 21
        UltraGridColumn574.Hidden = True
        UltraGridColumn575.Header.VisiblePosition = 22
        UltraGridColumn575.Hidden = True
        UltraGridColumn576.Header.VisiblePosition = 23
        UltraGridColumn576.Hidden = True
        UltraGridColumn577.Header.VisiblePosition = 24
        UltraGridColumn577.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn578.CellAppearance = Appearance7
        UltraGridColumn578.Header.Caption = "Monto (11)"
        UltraGridColumn578.Header.VisiblePosition = 25
        UltraGridColumn578.MaskInput = "{double:-9.2}"
        UltraGridColumn579.Header.VisiblePosition = 26
        UltraGridColumn579.Hidden = True
        UltraGridColumn580.Header.VisiblePosition = 27
        UltraGridColumn580.Hidden = True
        UltraGridColumn581.Header.VisiblePosition = 28
        UltraGridColumn581.Hidden = True
        UltraGridColumn582.Header.VisiblePosition = 29
        UltraGridColumn582.Hidden = True
        UltraGridColumn583.Header.Caption = "Razon Social (6)"
        UltraGridColumn583.Header.VisiblePosition = 8
        UltraGridColumn584.Header.VisiblePosition = 30
        UltraGridColumn584.Hidden = True
        UltraGridColumn585.Header.VisiblePosition = 31
        UltraGridColumn585.Hidden = True
        UltraGridColumn586.Header.VisiblePosition = 32
        UltraGridColumn586.Hidden = True
        UltraGridColumn587.Header.VisiblePosition = 33
        UltraGridColumn587.Hidden = True
        UltraGridColumn588.Header.Caption = "Indicador (12)"
        UltraGridColumn588.Header.VisiblePosition = 34
        UltraGridColumn589.Header.VisiblePosition = 35
        UltraGridColumn589.Hidden = True
        UltraGridColumn590.Header.VisiblePosition = 36
        UltraGridColumn590.Hidden = True
        UltraGridColumn591.Header.VisiblePosition = 37
        UltraGridColumn591.Hidden = True
        UltraGridColumn592.Header.VisiblePosition = 38
        UltraGridColumn592.Hidden = True
        UltraGridColumn593.Header.VisiblePosition = 39
        UltraGridColumn593.Hidden = True
        UltraGridColumn594.Header.VisiblePosition = 40
        UltraGridColumn594.Hidden = True
        UltraGridColumn595.Header.VisiblePosition = 41
        UltraGridColumn595.Hidden = True
        UltraGridColumn596.Header.VisiblePosition = 42
        UltraGridColumn596.Hidden = True
        UltraGridColumn597.Header.VisiblePosition = 43
        UltraGridColumn597.Hidden = True
        UltraGridColumn598.Header.VisiblePosition = 44
        UltraGridColumn598.Hidden = True
        UltraGridColumn599.Header.VisiblePosition = 45
        UltraGridColumn599.Hidden = True
        UltraGridColumn600.Header.VisiblePosition = 46
        UltraGridColumn600.Hidden = True
        UltraGridColumn601.Header.VisiblePosition = 47
        UltraGridColumn601.Hidden = True
        UltraGridColumn602.Header.VisiblePosition = 48
        UltraGridColumn602.Hidden = True
        UltraGridColumn603.Header.VisiblePosition = 49
        UltraGridColumn603.Hidden = True
        UltraGridColumn604.Header.VisiblePosition = 50
        UltraGridColumn604.Hidden = True
        UltraGridColumn605.Header.VisiblePosition = 51
        UltraGridColumn605.Hidden = True
        UltraGridColumn606.Header.VisiblePosition = 52
        UltraGridColumn606.Hidden = True
        UltraGridColumn607.Header.VisiblePosition = 53
        UltraGridColumn607.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn554, UltraGridColumn555, UltraGridColumn556, UltraGridColumn557, UltraGridColumn558, UltraGridColumn559, UltraGridColumn560, UltraGridColumn561, UltraGridColumn562, UltraGridColumn563, UltraGridColumn564, UltraGridColumn565, UltraGridColumn566, UltraGridColumn567, UltraGridColumn568, UltraGridColumn569, UltraGridColumn570, UltraGridColumn571, UltraGridColumn572, UltraGridColumn573, UltraGridColumn574, UltraGridColumn575, UltraGridColumn576, UltraGridColumn577, UltraGridColumn578, UltraGridColumn579, UltraGridColumn580, UltraGridColumn581, UltraGridColumn582, UltraGridColumn583, UltraGridColumn584, UltraGridColumn585, UltraGridColumn586, UltraGridColumn587, UltraGridColumn588, UltraGridColumn589, UltraGridColumn590, UltraGridColumn591, UltraGridColumn592, UltraGridColumn593, UltraGridColumn594, UltraGridColumn595, UltraGridColumn596, UltraGridColumn597, UltraGridColumn598, UltraGridColumn599, UltraGridColumn600, UltraGridColumn601, UltraGridColumn602, UltraGridColumn603, UltraGridColumn604, UltraGridColumn605, UltraGridColumn606, UltraGridColumn607})
        Me.griInv19.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griInv19.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv19.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv19.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv19.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv19.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv19.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv19.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv19.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv19.DisplayLayout.Override.CellPadding = 0
        Me.griInv19.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv19.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv19.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv19.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv19.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv19.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv19.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv19.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv19.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv19.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv19.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv19.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv19.Location = New System.Drawing.Point(0, 0)
        Me.griInv19.Name = "griInv19"
        Me.griInv19.Size = New System.Drawing.Size(1256, 251)
        Me.griInv19.TabIndex = 0
        Me.griInv19.Text = "3.6 Detalle Cuenta 19"
        '
        'UltraTabPageControl27
        '
        Me.UltraTabPageControl27.Controls.Add(Me.griInv20)
        Me.UltraTabPageControl27.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl27.Name = "UltraTabPageControl27"
        Me.UltraTabPageControl27.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv20
        '
        Me.griInv20.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn608.Header.VisiblePosition = 0
        UltraGridColumn608.Hidden = True
        UltraGridColumn609.Header.VisiblePosition = 1
        UltraGridColumn609.Hidden = True
        UltraGridColumn610.Header.VisiblePosition = 2
        UltraGridColumn610.Hidden = True
        UltraGridColumn611.Header.Caption = "Periodo (1)"
        UltraGridColumn611.Header.VisiblePosition = 3
        UltraGridColumn612.Header.Caption = "Cod Catalago (2)"
        UltraGridColumn612.Header.VisiblePosition = 4
        UltraGridColumn613.Header.VisiblePosition = 5
        UltraGridColumn613.Hidden = True
        UltraGridColumn614.Header.VisiblePosition = 6
        UltraGridColumn614.Hidden = True
        UltraGridColumn615.Header.Caption = "Tipo Existencia (3)"
        UltraGridColumn615.Header.VisiblePosition = 7
        UltraGridColumn616.Header.Caption = "Cod Existencia Propio (4)"
        UltraGridColumn616.Header.VisiblePosition = 8
        UltraGridColumn617.Header.Caption = "Cod Unidad Medida (7)"
        UltraGridColumn617.Header.VisiblePosition = 11
        UltraGridColumn618.Header.Caption = "Cod Existencia (5)"
        UltraGridColumn618.Header.VisiblePosition = 9
        UltraGridColumn619.Header.Caption = "Descripcion (6)"
        UltraGridColumn619.Header.VisiblePosition = 10
        UltraGridColumn620.Header.VisiblePosition = 12
        UltraGridColumn620.Hidden = True
        UltraGridColumn621.Header.VisiblePosition = 13
        UltraGridColumn621.Hidden = True
        UltraGridColumn622.Header.VisiblePosition = 14
        UltraGridColumn622.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn623.CellAppearance = Appearance8
        UltraGridColumn623.Header.Caption = "Cantidad Existencia (9)"
        UltraGridColumn623.Header.VisiblePosition = 17
        UltraGridColumn623.MaskInput = "{double:-9.2}"
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn624.CellAppearance = Appearance9
        UltraGridColumn624.Header.VisiblePosition = 18
        UltraGridColumn624.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn625.CellAppearance = Appearance10
        UltraGridColumn625.Header.Caption = "Costo Unitario (10)"
        UltraGridColumn625.Header.VisiblePosition = 19
        UltraGridColumn625.MaskInput = "{double:-9.2}"
        UltraGridColumn626.Header.VisiblePosition = 20
        UltraGridColumn626.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn627.CellAppearance = Appearance11
        UltraGridColumn627.Header.Caption = "Costo Total (11)"
        UltraGridColumn627.Header.VisiblePosition = 21
        UltraGridColumn627.MaskInput = "{double:-9.2}"
        UltraGridColumn628.Header.VisiblePosition = 22
        UltraGridColumn628.Hidden = True
        UltraGridColumn629.Header.VisiblePosition = 23
        UltraGridColumn629.Hidden = True
        UltraGridColumn630.Header.VisiblePosition = 24
        UltraGridColumn630.Hidden = True
        UltraGridColumn631.Header.VisiblePosition = 25
        UltraGridColumn631.Hidden = True
        UltraGridColumn632.Header.VisiblePosition = 26
        UltraGridColumn632.Hidden = True
        UltraGridColumn633.Header.VisiblePosition = 27
        UltraGridColumn633.Hidden = True
        UltraGridColumn634.Header.VisiblePosition = 28
        UltraGridColumn634.Hidden = True
        UltraGridColumn635.Header.VisiblePosition = 15
        UltraGridColumn635.Hidden = True
        UltraGridColumn636.Header.VisiblePosition = 29
        UltraGridColumn636.Hidden = True
        UltraGridColumn637.Header.VisiblePosition = 30
        UltraGridColumn637.Hidden = True
        UltraGridColumn638.Header.VisiblePosition = 31
        UltraGridColumn638.Hidden = True
        UltraGridColumn639.Header.VisiblePosition = 32
        UltraGridColumn639.Hidden = True
        UltraGridColumn640.Header.Caption = "Cod Metodo Evaluacion (8)"
        UltraGridColumn640.Header.VisiblePosition = 16
        UltraGridColumn641.Header.VisiblePosition = 33
        UltraGridColumn641.Hidden = True
        UltraGridColumn642.Header.Caption = "Indicador (12)"
        UltraGridColumn642.Header.VisiblePosition = 34
        UltraGridColumn643.Header.VisiblePosition = 35
        UltraGridColumn643.Hidden = True
        UltraGridColumn644.Header.VisiblePosition = 36
        UltraGridColumn644.Hidden = True
        UltraGridColumn645.Header.VisiblePosition = 37
        UltraGridColumn645.Hidden = True
        UltraGridColumn646.Header.VisiblePosition = 38
        UltraGridColumn646.Hidden = True
        UltraGridColumn647.Header.VisiblePosition = 39
        UltraGridColumn647.Hidden = True
        UltraGridColumn648.Header.VisiblePosition = 40
        UltraGridColumn648.Hidden = True
        UltraGridColumn649.Header.VisiblePosition = 41
        UltraGridColumn649.Hidden = True
        UltraGridColumn650.Header.VisiblePosition = 42
        UltraGridColumn650.Hidden = True
        UltraGridColumn651.Header.VisiblePosition = 43
        UltraGridColumn651.Hidden = True
        UltraGridColumn652.Header.VisiblePosition = 44
        UltraGridColumn652.Hidden = True
        UltraGridColumn653.Header.VisiblePosition = 45
        UltraGridColumn653.Hidden = True
        UltraGridColumn654.Header.VisiblePosition = 46
        UltraGridColumn654.Hidden = True
        UltraGridColumn655.Header.VisiblePosition = 47
        UltraGridColumn655.Hidden = True
        UltraGridColumn656.Header.VisiblePosition = 48
        UltraGridColumn656.Hidden = True
        UltraGridColumn657.Header.VisiblePosition = 49
        UltraGridColumn657.Hidden = True
        UltraGridColumn658.Header.VisiblePosition = 50
        UltraGridColumn658.Hidden = True
        UltraGridColumn659.Header.VisiblePosition = 51
        UltraGridColumn659.Hidden = True
        UltraGridColumn660.Header.VisiblePosition = 52
        UltraGridColumn660.Hidden = True
        UltraGridColumn661.Header.VisiblePosition = 53
        UltraGridColumn661.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn608, UltraGridColumn609, UltraGridColumn610, UltraGridColumn611, UltraGridColumn612, UltraGridColumn613, UltraGridColumn614, UltraGridColumn615, UltraGridColumn616, UltraGridColumn617, UltraGridColumn618, UltraGridColumn619, UltraGridColumn620, UltraGridColumn621, UltraGridColumn622, UltraGridColumn623, UltraGridColumn624, UltraGridColumn625, UltraGridColumn626, UltraGridColumn627, UltraGridColumn628, UltraGridColumn629, UltraGridColumn630, UltraGridColumn631, UltraGridColumn632, UltraGridColumn633, UltraGridColumn634, UltraGridColumn635, UltraGridColumn636, UltraGridColumn637, UltraGridColumn638, UltraGridColumn639, UltraGridColumn640, UltraGridColumn641, UltraGridColumn642, UltraGridColumn643, UltraGridColumn644, UltraGridColumn645, UltraGridColumn646, UltraGridColumn647, UltraGridColumn648, UltraGridColumn649, UltraGridColumn650, UltraGridColumn651, UltraGridColumn652, UltraGridColumn653, UltraGridColumn654, UltraGridColumn655, UltraGridColumn656, UltraGridColumn657, UltraGridColumn658, UltraGridColumn659, UltraGridColumn660, UltraGridColumn661})
        Me.griInv20.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griInv20.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv20.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv20.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv20.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv20.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv20.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv20.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv20.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv20.DisplayLayout.Override.CellPadding = 0
        Me.griInv20.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv20.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv20.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv20.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv20.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv20.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv20.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv20.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv20.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv20.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv20.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv20.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv20.Location = New System.Drawing.Point(0, 0)
        Me.griInv20.Name = "griInv20"
        Me.griInv20.Size = New System.Drawing.Size(1256, 251)
        Me.griInv20.TabIndex = 0
        Me.griInv20.Text = "3.7 Detalle Cuenta 20"
        '
        'UltraTabPageControl28
        '
        Me.UltraTabPageControl28.Controls.Add(Me.griInv30)
        Me.UltraTabPageControl28.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl28.Name = "UltraTabPageControl28"
        Me.UltraTabPageControl28.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv30
        '
        Me.griInv30.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn662.Header.VisiblePosition = 0
        UltraGridColumn662.Hidden = True
        UltraGridColumn663.Header.VisiblePosition = 1
        UltraGridColumn663.Hidden = True
        UltraGridColumn664.Header.VisiblePosition = 2
        UltraGridColumn664.Hidden = True
        UltraGridColumn665.Header.Caption = "Periodo (1)"
        UltraGridColumn665.Header.VisiblePosition = 3
        UltraGridColumn666.Header.Caption = "CUO (2)"
        UltraGridColumn666.Header.VisiblePosition = 4
        UltraGridColumn667.Header.VisiblePosition = 5
        UltraGridColumn667.Hidden = True
        UltraGridColumn668.Header.VisiblePosition = 6
        UltraGridColumn668.Hidden = True
        UltraGridColumn669.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn669.Header.VisiblePosition = 8
        UltraGridColumn670.Header.Caption = "Cod Titulo (7)"
        UltraGridColumn670.Header.VisiblePosition = 13
        UltraGridColumn671.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn671.Header.VisiblePosition = 11
        UltraGridColumn672.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn672.Header.VisiblePosition = 7
        UltraGridColumn673.Header.Caption = "Razon Social (6)"
        UltraGridColumn673.Header.VisiblePosition = 12
        UltraGridColumn674.Header.VisiblePosition = 9
        UltraGridColumn674.Hidden = True
        UltraGridColumn675.Header.Caption = "NroDocIdentidad"
        UltraGridColumn675.Header.VisiblePosition = 10
        UltraGridColumn675.Hidden = True
        UltraGridColumn676.Header.VisiblePosition = 14
        UltraGridColumn676.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn677.CellAppearance = Appearance12
        UltraGridColumn677.Header.Caption = "Valor Unit (8)"
        UltraGridColumn677.Header.VisiblePosition = 15
        UltraGridColumn677.MaskInput = "{double:-9.2}"
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn678.CellAppearance = Appearance13
        UltraGridColumn678.Header.Caption = "Cantidad Titulos (9)"
        UltraGridColumn678.Header.VisiblePosition = 16
        UltraGridColumn678.MaskInput = "nnnnnnnnn"
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn679.CellAppearance = Appearance14
        UltraGridColumn679.Header.Caption = "Costo Total (10)"
        UltraGridColumn679.Header.VisiblePosition = 17
        UltraGridColumn679.MaskInput = "{double:-9.2}"
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn680.CellAppearance = Appearance15
        UltraGridColumn680.Header.Caption = "Provision Total (11)"
        UltraGridColumn680.Header.VisiblePosition = 18
        UltraGridColumn680.MaskInput = "{double:-9.2}"
        UltraGridColumn681.Header.VisiblePosition = 19
        UltraGridColumn681.Hidden = True
        UltraGridColumn682.Header.VisiblePosition = 20
        UltraGridColumn682.Hidden = True
        UltraGridColumn683.Header.VisiblePosition = 21
        UltraGridColumn683.Hidden = True
        UltraGridColumn684.Header.VisiblePosition = 22
        UltraGridColumn684.Hidden = True
        UltraGridColumn685.Header.VisiblePosition = 23
        UltraGridColumn685.Hidden = True
        UltraGridColumn686.Header.VisiblePosition = 24
        UltraGridColumn686.Hidden = True
        UltraGridColumn687.Header.VisiblePosition = 25
        UltraGridColumn687.Hidden = True
        UltraGridColumn688.Header.VisiblePosition = 26
        UltraGridColumn688.Hidden = True
        UltraGridColumn689.Header.VisiblePosition = 27
        UltraGridColumn689.Hidden = True
        UltraGridColumn690.Header.VisiblePosition = 28
        UltraGridColumn690.Hidden = True
        UltraGridColumn691.Header.VisiblePosition = 29
        UltraGridColumn691.Hidden = True
        UltraGridColumn692.Header.VisiblePosition = 30
        UltraGridColumn692.Hidden = True
        UltraGridColumn693.Header.VisiblePosition = 31
        UltraGridColumn693.Hidden = True
        UltraGridColumn694.Header.VisiblePosition = 32
        UltraGridColumn694.Hidden = True
        UltraGridColumn695.Header.VisiblePosition = 33
        UltraGridColumn695.Hidden = True
        UltraGridColumn696.Header.Caption = "Indicador (12)"
        UltraGridColumn696.Header.VisiblePosition = 34
        UltraGridColumn697.Header.VisiblePosition = 35
        UltraGridColumn697.Hidden = True
        UltraGridColumn698.Header.VisiblePosition = 36
        UltraGridColumn698.Hidden = True
        UltraGridColumn699.Header.VisiblePosition = 37
        UltraGridColumn699.Hidden = True
        UltraGridColumn700.Header.VisiblePosition = 38
        UltraGridColumn700.Hidden = True
        UltraGridColumn701.Header.VisiblePosition = 39
        UltraGridColumn701.Hidden = True
        UltraGridColumn702.Header.VisiblePosition = 40
        UltraGridColumn702.Hidden = True
        UltraGridColumn703.Header.VisiblePosition = 41
        UltraGridColumn703.Hidden = True
        UltraGridColumn704.Header.VisiblePosition = 42
        UltraGridColumn704.Hidden = True
        UltraGridColumn705.Header.VisiblePosition = 43
        UltraGridColumn705.Hidden = True
        UltraGridColumn706.Header.VisiblePosition = 44
        UltraGridColumn706.Hidden = True
        UltraGridColumn707.Header.VisiblePosition = 45
        UltraGridColumn707.Hidden = True
        UltraGridColumn708.Header.VisiblePosition = 46
        UltraGridColumn708.Hidden = True
        UltraGridColumn709.Header.VisiblePosition = 47
        UltraGridColumn709.Hidden = True
        UltraGridColumn710.Header.VisiblePosition = 48
        UltraGridColumn710.Hidden = True
        UltraGridColumn711.Header.VisiblePosition = 49
        UltraGridColumn711.Hidden = True
        UltraGridColumn712.Header.VisiblePosition = 50
        UltraGridColumn712.Hidden = True
        UltraGridColumn713.Header.VisiblePosition = 51
        UltraGridColumn713.Hidden = True
        UltraGridColumn714.Header.VisiblePosition = 52
        UltraGridColumn714.Hidden = True
        UltraGridColumn715.Header.VisiblePosition = 53
        UltraGridColumn715.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn662, UltraGridColumn663, UltraGridColumn664, UltraGridColumn665, UltraGridColumn666, UltraGridColumn667, UltraGridColumn668, UltraGridColumn669, UltraGridColumn670, UltraGridColumn671, UltraGridColumn672, UltraGridColumn673, UltraGridColumn674, UltraGridColumn675, UltraGridColumn676, UltraGridColumn677, UltraGridColumn678, UltraGridColumn679, UltraGridColumn680, UltraGridColumn681, UltraGridColumn682, UltraGridColumn683, UltraGridColumn684, UltraGridColumn685, UltraGridColumn686, UltraGridColumn687, UltraGridColumn688, UltraGridColumn689, UltraGridColumn690, UltraGridColumn691, UltraGridColumn692, UltraGridColumn693, UltraGridColumn694, UltraGridColumn695, UltraGridColumn696, UltraGridColumn697, UltraGridColumn698, UltraGridColumn699, UltraGridColumn700, UltraGridColumn701, UltraGridColumn702, UltraGridColumn703, UltraGridColumn704, UltraGridColumn705, UltraGridColumn706, UltraGridColumn707, UltraGridColumn708, UltraGridColumn709, UltraGridColumn710, UltraGridColumn711, UltraGridColumn712, UltraGridColumn713, UltraGridColumn714, UltraGridColumn715})
        Me.griInv30.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griInv30.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv30.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv30.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv30.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv30.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv30.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv30.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv30.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv30.DisplayLayout.Override.CellPadding = 0
        Me.griInv30.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv30.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv30.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv30.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv30.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv30.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv30.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griInv30.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv30.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv30.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv30.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv30.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv30.Location = New System.Drawing.Point(0, 0)
        Me.griInv30.Name = "griInv30"
        Me.griInv30.Size = New System.Drawing.Size(1256, 251)
        Me.griInv30.TabIndex = 0
        Me.griInv30.Text = "3.8 Detalle Cuenta 30"
        '
        'UltraTabPageControl29
        '
        Me.UltraTabPageControl29.Controls.Add(Me.griInv34)
        Me.UltraTabPageControl29.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl29.Name = "UltraTabPageControl29"
        Me.UltraTabPageControl29.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv34
        '
        Me.griInv34.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn716.Header.VisiblePosition = 0
        UltraGridColumn716.Hidden = True
        UltraGridColumn717.Header.VisiblePosition = 1
        UltraGridColumn717.Hidden = True
        UltraGridColumn718.Header.VisiblePosition = 2
        UltraGridColumn718.Hidden = True
        UltraGridColumn719.Header.Caption = "Periodo (1)"
        UltraGridColumn719.Header.VisiblePosition = 3
        UltraGridColumn720.Header.Caption = "CUO (2)"
        UltraGridColumn720.Header.VisiblePosition = 4
        UltraGridColumn721.Header.Caption = "Fec Inicio (4)"
        UltraGridColumn721.Header.VisiblePosition = 6
        UltraGridColumn721.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn722.Header.VisiblePosition = 7
        UltraGridColumn722.Hidden = True
        UltraGridColumn723.Header.Caption = "Descripcion (6)"
        UltraGridColumn723.Header.VisiblePosition = 11
        UltraGridColumn723.Width = 182
        UltraGridColumn724.Header.VisiblePosition = 8
        UltraGridColumn724.Hidden = True
        UltraGridColumn725.Header.VisiblePosition = 9
        UltraGridColumn725.Hidden = True
        UltraGridColumn726.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn726.Header.VisiblePosition = 5
        UltraGridColumn727.Header.Caption = "Cuenta Contable (5)"
        UltraGridColumn727.Header.VisiblePosition = 10
        UltraGridColumn728.Header.VisiblePosition = 12
        UltraGridColumn728.Hidden = True
        UltraGridColumn729.Header.VisiblePosition = 13
        UltraGridColumn729.Hidden = True
        UltraGridColumn730.Header.VisiblePosition = 14
        UltraGridColumn730.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn731.CellAppearance = Appearance16
        UltraGridColumn731.Header.Caption = "Valor Contable (7)"
        UltraGridColumn731.Header.VisiblePosition = 15
        UltraGridColumn731.MaskInput = "{double:-9.2}"
        UltraGridColumn732.Header.VisiblePosition = 16
        UltraGridColumn732.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn733.CellAppearance = Appearance17
        UltraGridColumn733.Header.Caption = "Amortizacion (8)"
        UltraGridColumn733.Header.VisiblePosition = 17
        UltraGridColumn733.MaskInput = "{double:-9.2}"
        UltraGridColumn734.Header.VisiblePosition = 18
        UltraGridColumn734.Hidden = True
        UltraGridColumn735.Header.VisiblePosition = 19
        UltraGridColumn735.Hidden = True
        UltraGridColumn736.Header.VisiblePosition = 20
        UltraGridColumn736.Hidden = True
        UltraGridColumn737.Header.VisiblePosition = 21
        UltraGridColumn737.Hidden = True
        UltraGridColumn738.Header.VisiblePosition = 22
        UltraGridColumn738.Hidden = True
        UltraGridColumn739.Header.VisiblePosition = 23
        UltraGridColumn739.Hidden = True
        UltraGridColumn740.Header.VisiblePosition = 24
        UltraGridColumn740.Hidden = True
        UltraGridColumn741.Header.VisiblePosition = 25
        UltraGridColumn741.Hidden = True
        UltraGridColumn742.Header.VisiblePosition = 26
        UltraGridColumn742.Hidden = True
        UltraGridColumn743.Header.VisiblePosition = 27
        UltraGridColumn743.Hidden = True
        UltraGridColumn744.Header.VisiblePosition = 28
        UltraGridColumn744.Hidden = True
        UltraGridColumn745.Header.VisiblePosition = 29
        UltraGridColumn745.Hidden = True
        UltraGridColumn746.Header.VisiblePosition = 30
        UltraGridColumn746.Hidden = True
        UltraGridColumn747.Header.VisiblePosition = 31
        UltraGridColumn747.Hidden = True
        UltraGridColumn748.Header.VisiblePosition = 32
        UltraGridColumn748.Hidden = True
        UltraGridColumn749.Header.VisiblePosition = 33
        UltraGridColumn749.Hidden = True
        UltraGridColumn750.Header.Caption = "Indicador (9)"
        UltraGridColumn750.Header.VisiblePosition = 34
        UltraGridColumn751.Header.VisiblePosition = 35
        UltraGridColumn751.Hidden = True
        UltraGridColumn752.Header.VisiblePosition = 36
        UltraGridColumn752.Hidden = True
        UltraGridColumn753.Header.VisiblePosition = 37
        UltraGridColumn753.Hidden = True
        UltraGridColumn754.Header.VisiblePosition = 38
        UltraGridColumn754.Hidden = True
        UltraGridColumn755.Header.VisiblePosition = 39
        UltraGridColumn755.Hidden = True
        UltraGridColumn756.Header.VisiblePosition = 40
        UltraGridColumn756.Hidden = True
        UltraGridColumn757.Header.VisiblePosition = 41
        UltraGridColumn757.Hidden = True
        UltraGridColumn758.Header.VisiblePosition = 42
        UltraGridColumn758.Hidden = True
        UltraGridColumn759.Header.VisiblePosition = 43
        UltraGridColumn759.Hidden = True
        UltraGridColumn760.Header.VisiblePosition = 44
        UltraGridColumn760.Hidden = True
        UltraGridColumn761.Header.VisiblePosition = 45
        UltraGridColumn761.Hidden = True
        UltraGridColumn762.Header.VisiblePosition = 46
        UltraGridColumn762.Hidden = True
        UltraGridColumn763.Header.VisiblePosition = 47
        UltraGridColumn763.Hidden = True
        UltraGridColumn764.Header.VisiblePosition = 48
        UltraGridColumn764.Hidden = True
        UltraGridColumn765.Header.VisiblePosition = 49
        UltraGridColumn765.Hidden = True
        UltraGridColumn766.Header.VisiblePosition = 50
        UltraGridColumn766.Hidden = True
        UltraGridColumn767.Header.VisiblePosition = 51
        UltraGridColumn767.Hidden = True
        UltraGridColumn768.Header.VisiblePosition = 52
        UltraGridColumn768.Hidden = True
        UltraGridColumn769.Header.VisiblePosition = 53
        UltraGridColumn769.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn716, UltraGridColumn717, UltraGridColumn718, UltraGridColumn719, UltraGridColumn720, UltraGridColumn721, UltraGridColumn722, UltraGridColumn723, UltraGridColumn724, UltraGridColumn725, UltraGridColumn726, UltraGridColumn727, UltraGridColumn728, UltraGridColumn729, UltraGridColumn730, UltraGridColumn731, UltraGridColumn732, UltraGridColumn733, UltraGridColumn734, UltraGridColumn735, UltraGridColumn736, UltraGridColumn737, UltraGridColumn738, UltraGridColumn739, UltraGridColumn740, UltraGridColumn741, UltraGridColumn742, UltraGridColumn743, UltraGridColumn744, UltraGridColumn745, UltraGridColumn746, UltraGridColumn747, UltraGridColumn748, UltraGridColumn749, UltraGridColumn750, UltraGridColumn751, UltraGridColumn752, UltraGridColumn753, UltraGridColumn754, UltraGridColumn755, UltraGridColumn756, UltraGridColumn757, UltraGridColumn758, UltraGridColumn759, UltraGridColumn760, UltraGridColumn761, UltraGridColumn762, UltraGridColumn763, UltraGridColumn764, UltraGridColumn765, UltraGridColumn766, UltraGridColumn767, UltraGridColumn768, UltraGridColumn769})
        Me.griInv34.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griInv34.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv34.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv34.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv34.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv34.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv34.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv34.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv34.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv34.DisplayLayout.Override.CellPadding = 0
        Me.griInv34.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv34.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv34.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv34.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv34.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv34.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv34.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv34.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv34.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv34.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv34.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv34.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv34.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv34.Location = New System.Drawing.Point(0, 0)
        Me.griInv34.Name = "griInv34"
        Me.griInv34.Size = New System.Drawing.Size(1256, 251)
        Me.griInv34.TabIndex = 0
        Me.griInv34.Text = "3.9 Detalle Cuenta 34"
        '
        'UltraTabPageControl30
        '
        Me.UltraTabPageControl30.Controls.Add(Me.griInv41)
        Me.UltraTabPageControl30.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl30.Name = "UltraTabPageControl30"
        Me.UltraTabPageControl30.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv41
        '
        Me.griInv41.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn770.Header.VisiblePosition = 0
        UltraGridColumn770.Hidden = True
        UltraGridColumn771.Header.VisiblePosition = 1
        UltraGridColumn771.Hidden = True
        UltraGridColumn772.Header.VisiblePosition = 2
        UltraGridColumn772.Hidden = True
        UltraGridColumn773.Header.Caption = "Periodo (1)"
        UltraGridColumn773.Header.VisiblePosition = 3
        UltraGridColumn774.Header.Caption = "CUO (2)"
        UltraGridColumn774.Header.VisiblePosition = 4
        UltraGridColumn775.Header.VisiblePosition = 5
        UltraGridColumn775.Hidden = True
        UltraGridColumn776.Header.VisiblePosition = 6
        UltraGridColumn776.Hidden = True
        UltraGridColumn777.Header.Caption = "Codigo Trabajador (7)"
        UltraGridColumn777.Header.VisiblePosition = 11
        UltraGridColumn778.Header.Caption = "Apellidos y Nombres (9)"
        UltraGridColumn778.Header.VisiblePosition = 12
        UltraGridColumn779.Header.VisiblePosition = 13
        UltraGridColumn779.Hidden = True
        UltraGridColumn780.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn780.Header.VisiblePosition = 7
        UltraGridColumn781.Header.Caption = "Cuenta Contable (4)"
        UltraGridColumn781.Header.VisiblePosition = 8
        UltraGridColumn782.Header.Caption = "Tipo Doc Identidad (5)"
        UltraGridColumn782.Header.VisiblePosition = 9
        UltraGridColumn783.Header.Caption = "Nro Doc Identidad (6)"
        UltraGridColumn783.Header.VisiblePosition = 10
        UltraGridColumn784.Header.VisiblePosition = 14
        UltraGridColumn784.Hidden = True
        UltraGridColumn785.Header.VisiblePosition = 15
        UltraGridColumn785.Hidden = True
        UltraGridColumn786.Header.VisiblePosition = 16
        UltraGridColumn786.Hidden = True
        UltraGridColumn787.Header.VisiblePosition = 17
        UltraGridColumn787.Hidden = True
        UltraGridColumn788.Header.VisiblePosition = 18
        UltraGridColumn788.Hidden = True
        UltraGridColumn789.Header.VisiblePosition = 19
        UltraGridColumn789.Hidden = True
        UltraGridColumn790.Header.VisiblePosition = 20
        UltraGridColumn790.Hidden = True
        UltraGridColumn791.Header.VisiblePosition = 21
        UltraGridColumn791.Hidden = True
        UltraGridColumn792.Header.VisiblePosition = 22
        UltraGridColumn792.Hidden = True
        UltraGridColumn793.Header.VisiblePosition = 23
        UltraGridColumn793.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn794.CellAppearance = Appearance18
        UltraGridColumn794.Header.Caption = "Monto (10)"
        UltraGridColumn794.Header.VisiblePosition = 24
        UltraGridColumn794.MaskInput = "{double:-9.2}"
        UltraGridColumn795.Header.VisiblePosition = 25
        UltraGridColumn795.Hidden = True
        UltraGridColumn796.Header.VisiblePosition = 26
        UltraGridColumn796.Hidden = True
        UltraGridColumn797.Header.VisiblePosition = 27
        UltraGridColumn797.Hidden = True
        UltraGridColumn798.Header.VisiblePosition = 28
        UltraGridColumn798.Hidden = True
        UltraGridColumn799.Header.VisiblePosition = 29
        UltraGridColumn799.Hidden = True
        UltraGridColumn800.Header.VisiblePosition = 30
        UltraGridColumn800.Hidden = True
        UltraGridColumn801.Header.VisiblePosition = 31
        UltraGridColumn801.Hidden = True
        UltraGridColumn802.Header.VisiblePosition = 32
        UltraGridColumn802.Hidden = True
        UltraGridColumn803.Header.VisiblePosition = 33
        UltraGridColumn803.Hidden = True
        UltraGridColumn804.Header.Caption = "Indicador (11)"
        UltraGridColumn804.Header.VisiblePosition = 34
        UltraGridColumn805.Header.VisiblePosition = 35
        UltraGridColumn805.Hidden = True
        UltraGridColumn806.Header.VisiblePosition = 36
        UltraGridColumn806.Hidden = True
        UltraGridColumn807.Header.VisiblePosition = 37
        UltraGridColumn807.Hidden = True
        UltraGridColumn808.Header.VisiblePosition = 38
        UltraGridColumn808.Hidden = True
        UltraGridColumn809.Header.VisiblePosition = 39
        UltraGridColumn809.Hidden = True
        UltraGridColumn810.Header.VisiblePosition = 40
        UltraGridColumn810.Hidden = True
        UltraGridColumn811.Header.VisiblePosition = 41
        UltraGridColumn811.Hidden = True
        UltraGridColumn812.Header.VisiblePosition = 42
        UltraGridColumn812.Hidden = True
        UltraGridColumn813.Header.VisiblePosition = 43
        UltraGridColumn813.Hidden = True
        UltraGridColumn814.Header.VisiblePosition = 44
        UltraGridColumn814.Hidden = True
        UltraGridColumn815.Header.VisiblePosition = 45
        UltraGridColumn815.Hidden = True
        UltraGridColumn816.Header.VisiblePosition = 46
        UltraGridColumn816.Hidden = True
        UltraGridColumn817.Header.VisiblePosition = 47
        UltraGridColumn817.Hidden = True
        UltraGridColumn818.Header.VisiblePosition = 48
        UltraGridColumn818.Hidden = True
        UltraGridColumn819.Header.VisiblePosition = 49
        UltraGridColumn819.Hidden = True
        UltraGridColumn820.Header.VisiblePosition = 50
        UltraGridColumn820.Hidden = True
        UltraGridColumn821.Header.VisiblePosition = 51
        UltraGridColumn821.Hidden = True
        UltraGridColumn822.Header.VisiblePosition = 52
        UltraGridColumn822.Hidden = True
        UltraGridColumn823.Header.VisiblePosition = 53
        UltraGridColumn823.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn770, UltraGridColumn771, UltraGridColumn772, UltraGridColumn773, UltraGridColumn774, UltraGridColumn775, UltraGridColumn776, UltraGridColumn777, UltraGridColumn778, UltraGridColumn779, UltraGridColumn780, UltraGridColumn781, UltraGridColumn782, UltraGridColumn783, UltraGridColumn784, UltraGridColumn785, UltraGridColumn786, UltraGridColumn787, UltraGridColumn788, UltraGridColumn789, UltraGridColumn790, UltraGridColumn791, UltraGridColumn792, UltraGridColumn793, UltraGridColumn794, UltraGridColumn795, UltraGridColumn796, UltraGridColumn797, UltraGridColumn798, UltraGridColumn799, UltraGridColumn800, UltraGridColumn801, UltraGridColumn802, UltraGridColumn803, UltraGridColumn804, UltraGridColumn805, UltraGridColumn806, UltraGridColumn807, UltraGridColumn808, UltraGridColumn809, UltraGridColumn810, UltraGridColumn811, UltraGridColumn812, UltraGridColumn813, UltraGridColumn814, UltraGridColumn815, UltraGridColumn816, UltraGridColumn817, UltraGridColumn818, UltraGridColumn819, UltraGridColumn820, UltraGridColumn821, UltraGridColumn822, UltraGridColumn823})
        Me.griInv41.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griInv41.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv41.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv41.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv41.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv41.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv41.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv41.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv41.DisplayLayout.Override.CellPadding = 0
        Me.griInv41.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv41.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv41.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv41.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv41.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv41.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv41.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv41.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv41.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv41.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv41.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv41.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv41.Location = New System.Drawing.Point(0, 0)
        Me.griInv41.Name = "griInv41"
        Me.griInv41.Size = New System.Drawing.Size(1256, 251)
        Me.griInv41.TabIndex = 0
        Me.griInv41.Text = "3.11 Detalle Cuenta 41"
        '
        'UltraTabPageControl31
        '
        Me.UltraTabPageControl31.Controls.Add(Me.griInv42)
        Me.UltraTabPageControl31.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl31.Name = "UltraTabPageControl31"
        Me.UltraTabPageControl31.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv42
        '
        Me.griInv42.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn824.Header.VisiblePosition = 0
        UltraGridColumn824.Hidden = True
        UltraGridColumn825.Header.VisiblePosition = 1
        UltraGridColumn825.Hidden = True
        UltraGridColumn826.Header.VisiblePosition = 2
        UltraGridColumn826.Hidden = True
        UltraGridColumn827.Header.Caption = "Periodo (1)"
        UltraGridColumn827.Header.VisiblePosition = 3
        UltraGridColumn828.Header.Caption = "CUO (2)"
        UltraGridColumn828.Header.VisiblePosition = 4
        UltraGridColumn829.Header.Caption = "Fec Emision (6)"
        UltraGridColumn829.Header.VisiblePosition = 13
        UltraGridColumn829.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn830.Header.VisiblePosition = 5
        UltraGridColumn830.Hidden = True
        UltraGridColumn831.Header.VisiblePosition = 6
        UltraGridColumn831.Hidden = True
        UltraGridColumn832.Header.VisiblePosition = 7
        UltraGridColumn832.Hidden = True
        UltraGridColumn833.Header.VisiblePosition = 8
        UltraGridColumn833.Hidden = True
        UltraGridColumn834.Header.VisiblePosition = 9
        UltraGridColumn834.Hidden = True
        UltraGridColumn835.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn835.Header.VisiblePosition = 10
        UltraGridColumn836.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn836.Header.VisiblePosition = 11
        UltraGridColumn837.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn837.Header.VisiblePosition = 12
        UltraGridColumn838.Header.Caption = "Razon Social (7)"
        UltraGridColumn838.Header.VisiblePosition = 14
        UltraGridColumn839.Header.VisiblePosition = 15
        UltraGridColumn839.Hidden = True
        UltraGridColumn840.Header.VisiblePosition = 16
        UltraGridColumn840.Hidden = True
        UltraGridColumn841.Header.VisiblePosition = 17
        UltraGridColumn841.Hidden = True
        UltraGridColumn842.Header.VisiblePosition = 18
        UltraGridColumn842.Hidden = True
        UltraGridColumn843.Header.VisiblePosition = 19
        UltraGridColumn843.Hidden = True
        UltraGridColumn844.Header.VisiblePosition = 20
        UltraGridColumn844.Hidden = True
        UltraGridColumn845.Header.VisiblePosition = 21
        UltraGridColumn845.Hidden = True
        UltraGridColumn846.Header.VisiblePosition = 22
        UltraGridColumn846.Hidden = True
        UltraGridColumn847.Header.VisiblePosition = 23
        UltraGridColumn847.Hidden = True
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn848.CellAppearance = Appearance19
        UltraGridColumn848.Header.Caption = "Monto (8)"
        UltraGridColumn848.Header.VisiblePosition = 24
        UltraGridColumn848.MaskInput = "{double:-9.2}"
        UltraGridColumn849.Header.VisiblePosition = 25
        UltraGridColumn849.Hidden = True
        UltraGridColumn850.Header.VisiblePosition = 26
        UltraGridColumn850.Hidden = True
        UltraGridColumn851.Header.VisiblePosition = 27
        UltraGridColumn851.Hidden = True
        UltraGridColumn852.Header.VisiblePosition = 28
        UltraGridColumn852.Hidden = True
        UltraGridColumn853.Header.VisiblePosition = 29
        UltraGridColumn853.Hidden = True
        UltraGridColumn854.Header.VisiblePosition = 30
        UltraGridColumn854.Hidden = True
        UltraGridColumn855.Header.VisiblePosition = 31
        UltraGridColumn855.Hidden = True
        UltraGridColumn856.Header.VisiblePosition = 32
        UltraGridColumn856.Hidden = True
        UltraGridColumn857.Header.VisiblePosition = 33
        UltraGridColumn857.Hidden = True
        UltraGridColumn858.Header.Caption = "Indicador (9)"
        UltraGridColumn858.Header.VisiblePosition = 34
        UltraGridColumn859.Header.VisiblePosition = 35
        UltraGridColumn859.Hidden = True
        UltraGridColumn860.Header.VisiblePosition = 36
        UltraGridColumn860.Hidden = True
        UltraGridColumn861.Header.VisiblePosition = 37
        UltraGridColumn861.Hidden = True
        UltraGridColumn862.Header.VisiblePosition = 38
        UltraGridColumn862.Hidden = True
        UltraGridColumn863.Header.VisiblePosition = 39
        UltraGridColumn863.Hidden = True
        UltraGridColumn864.Header.VisiblePosition = 40
        UltraGridColumn864.Hidden = True
        UltraGridColumn865.Header.VisiblePosition = 41
        UltraGridColumn865.Hidden = True
        UltraGridColumn866.Header.VisiblePosition = 42
        UltraGridColumn866.Hidden = True
        UltraGridColumn867.Header.VisiblePosition = 43
        UltraGridColumn867.Hidden = True
        UltraGridColumn868.Header.VisiblePosition = 44
        UltraGridColumn868.Hidden = True
        UltraGridColumn869.Header.VisiblePosition = 45
        UltraGridColumn869.Hidden = True
        UltraGridColumn870.Header.VisiblePosition = 46
        UltraGridColumn870.Hidden = True
        UltraGridColumn871.Header.VisiblePosition = 47
        UltraGridColumn871.Hidden = True
        UltraGridColumn872.Header.VisiblePosition = 48
        UltraGridColumn872.Hidden = True
        UltraGridColumn873.Header.VisiblePosition = 49
        UltraGridColumn873.Hidden = True
        UltraGridColumn874.Header.VisiblePosition = 50
        UltraGridColumn874.Hidden = True
        UltraGridColumn875.Header.VisiblePosition = 51
        UltraGridColumn875.Hidden = True
        UltraGridColumn876.Header.VisiblePosition = 52
        UltraGridColumn876.Hidden = True
        UltraGridColumn877.Header.VisiblePosition = 53
        UltraGridColumn877.Hidden = True
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn824, UltraGridColumn825, UltraGridColumn826, UltraGridColumn827, UltraGridColumn828, UltraGridColumn829, UltraGridColumn830, UltraGridColumn831, UltraGridColumn832, UltraGridColumn833, UltraGridColumn834, UltraGridColumn835, UltraGridColumn836, UltraGridColumn837, UltraGridColumn838, UltraGridColumn839, UltraGridColumn840, UltraGridColumn841, UltraGridColumn842, UltraGridColumn843, UltraGridColumn844, UltraGridColumn845, UltraGridColumn846, UltraGridColumn847, UltraGridColumn848, UltraGridColumn849, UltraGridColumn850, UltraGridColumn851, UltraGridColumn852, UltraGridColumn853, UltraGridColumn854, UltraGridColumn855, UltraGridColumn856, UltraGridColumn857, UltraGridColumn858, UltraGridColumn859, UltraGridColumn860, UltraGridColumn861, UltraGridColumn862, UltraGridColumn863, UltraGridColumn864, UltraGridColumn865, UltraGridColumn866, UltraGridColumn867, UltraGridColumn868, UltraGridColumn869, UltraGridColumn870, UltraGridColumn871, UltraGridColumn872, UltraGridColumn873, UltraGridColumn874, UltraGridColumn875, UltraGridColumn876, UltraGridColumn877})
        Me.griInv42.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griInv42.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv42.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv42.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv42.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv42.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv42.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv42.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv42.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv42.DisplayLayout.Override.CellPadding = 0
        Me.griInv42.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv42.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv42.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv42.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv42.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv42.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv42.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griInv42.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv42.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv42.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv42.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv42.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv42.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv42.Location = New System.Drawing.Point(0, 0)
        Me.griInv42.Name = "griInv42"
        Me.griInv42.Size = New System.Drawing.Size(1256, 251)
        Me.griInv42.TabIndex = 0
        Me.griInv42.Text = "3.12 Detalle Cuenta 42 y 43"
        '
        'UltraTabPageControl32
        '
        Me.UltraTabPageControl32.Controls.Add(Me.griInv46)
        Me.UltraTabPageControl32.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl32.Name = "UltraTabPageControl32"
        Me.UltraTabPageControl32.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv46
        '
        Me.griInv46.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn878.Header.VisiblePosition = 0
        UltraGridColumn878.Hidden = True
        UltraGridColumn879.Header.VisiblePosition = 1
        UltraGridColumn879.Hidden = True
        UltraGridColumn880.Header.VisiblePosition = 2
        UltraGridColumn880.Hidden = True
        UltraGridColumn881.Header.Caption = "Periodo (1)"
        UltraGridColumn881.Header.VisiblePosition = 3
        UltraGridColumn882.Header.Caption = "CUO (2)"
        UltraGridColumn882.Header.VisiblePosition = 4
        UltraGridColumn883.Header.Caption = "Fec Emision (6)"
        UltraGridColumn883.Header.VisiblePosition = 8
        UltraGridColumn883.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn884.Header.VisiblePosition = 9
        UltraGridColumn884.Hidden = True
        UltraGridColumn885.Header.VisiblePosition = 10
        UltraGridColumn885.Hidden = True
        UltraGridColumn886.Header.VisiblePosition = 11
        UltraGridColumn886.Hidden = True
        UltraGridColumn887.Header.VisiblePosition = 12
        UltraGridColumn887.Hidden = True
        UltraGridColumn888.Header.Caption = "Cuenta Contable (8)"
        UltraGridColumn888.Header.VisiblePosition = 14
        UltraGridColumn889.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn889.Header.VisiblePosition = 5
        UltraGridColumn890.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn890.Header.VisiblePosition = 6
        UltraGridColumn891.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn891.Header.VisiblePosition = 7
        UltraGridColumn892.Header.Caption = "Razon Social (7)"
        UltraGridColumn892.Header.VisiblePosition = 13
        UltraGridColumn893.Header.VisiblePosition = 15
        UltraGridColumn893.Hidden = True
        UltraGridColumn894.Header.VisiblePosition = 16
        UltraGridColumn894.Hidden = True
        UltraGridColumn895.Header.VisiblePosition = 17
        UltraGridColumn895.Hidden = True
        UltraGridColumn896.Header.VisiblePosition = 18
        UltraGridColumn896.Hidden = True
        UltraGridColumn897.Header.VisiblePosition = 19
        UltraGridColumn897.Hidden = True
        UltraGridColumn898.Header.VisiblePosition = 20
        UltraGridColumn898.Hidden = True
        UltraGridColumn899.Header.VisiblePosition = 21
        UltraGridColumn899.Hidden = True
        UltraGridColumn900.Header.VisiblePosition = 22
        UltraGridColumn900.Hidden = True
        UltraGridColumn901.Header.VisiblePosition = 23
        UltraGridColumn901.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn902.CellAppearance = Appearance20
        UltraGridColumn902.Header.Caption = "Total (9) Saldo"
        UltraGridColumn902.Header.VisiblePosition = 24
        UltraGridColumn902.MaskInput = "{double:-9.2}"
        UltraGridColumn903.Header.VisiblePosition = 25
        UltraGridColumn903.Hidden = True
        UltraGridColumn904.Header.VisiblePosition = 26
        UltraGridColumn904.Hidden = True
        UltraGridColumn905.Header.VisiblePosition = 27
        UltraGridColumn905.Hidden = True
        UltraGridColumn906.Header.VisiblePosition = 28
        UltraGridColumn906.Hidden = True
        UltraGridColumn907.Header.VisiblePosition = 29
        UltraGridColumn907.Hidden = True
        UltraGridColumn908.Header.VisiblePosition = 30
        UltraGridColumn908.Hidden = True
        UltraGridColumn909.Header.VisiblePosition = 31
        UltraGridColumn909.Hidden = True
        UltraGridColumn910.Header.VisiblePosition = 32
        UltraGridColumn910.Hidden = True
        UltraGridColumn911.Header.VisiblePosition = 33
        UltraGridColumn911.Hidden = True
        UltraGridColumn912.Header.Caption = "Indicador (10)"
        UltraGridColumn912.Header.VisiblePosition = 34
        UltraGridColumn913.Header.VisiblePosition = 35
        UltraGridColumn913.Hidden = True
        UltraGridColumn914.Header.VisiblePosition = 36
        UltraGridColumn914.Hidden = True
        UltraGridColumn915.Header.VisiblePosition = 37
        UltraGridColumn915.Hidden = True
        UltraGridColumn916.Header.VisiblePosition = 38
        UltraGridColumn916.Hidden = True
        UltraGridColumn917.Header.VisiblePosition = 39
        UltraGridColumn917.Hidden = True
        UltraGridColumn918.Header.VisiblePosition = 40
        UltraGridColumn918.Hidden = True
        UltraGridColumn919.Header.VisiblePosition = 41
        UltraGridColumn919.Hidden = True
        UltraGridColumn920.Header.VisiblePosition = 42
        UltraGridColumn920.Hidden = True
        UltraGridColumn921.Header.VisiblePosition = 43
        UltraGridColumn921.Hidden = True
        UltraGridColumn922.Header.VisiblePosition = 44
        UltraGridColumn922.Hidden = True
        UltraGridColumn923.Header.VisiblePosition = 45
        UltraGridColumn923.Hidden = True
        UltraGridColumn924.Header.VisiblePosition = 46
        UltraGridColumn924.Hidden = True
        UltraGridColumn925.Header.VisiblePosition = 47
        UltraGridColumn925.Hidden = True
        UltraGridColumn926.Header.VisiblePosition = 48
        UltraGridColumn926.Hidden = True
        UltraGridColumn927.Header.VisiblePosition = 49
        UltraGridColumn927.Hidden = True
        UltraGridColumn928.Header.VisiblePosition = 50
        UltraGridColumn928.Hidden = True
        UltraGridColumn929.Header.VisiblePosition = 51
        UltraGridColumn929.Hidden = True
        UltraGridColumn930.Header.VisiblePosition = 52
        UltraGridColumn930.Hidden = True
        UltraGridColumn931.Header.VisiblePosition = 53
        UltraGridColumn931.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn878, UltraGridColumn879, UltraGridColumn880, UltraGridColumn881, UltraGridColumn882, UltraGridColumn883, UltraGridColumn884, UltraGridColumn885, UltraGridColumn886, UltraGridColumn887, UltraGridColumn888, UltraGridColumn889, UltraGridColumn890, UltraGridColumn891, UltraGridColumn892, UltraGridColumn893, UltraGridColumn894, UltraGridColumn895, UltraGridColumn896, UltraGridColumn897, UltraGridColumn898, UltraGridColumn899, UltraGridColumn900, UltraGridColumn901, UltraGridColumn902, UltraGridColumn903, UltraGridColumn904, UltraGridColumn905, UltraGridColumn906, UltraGridColumn907, UltraGridColumn908, UltraGridColumn909, UltraGridColumn910, UltraGridColumn911, UltraGridColumn912, UltraGridColumn913, UltraGridColumn914, UltraGridColumn915, UltraGridColumn916, UltraGridColumn917, UltraGridColumn918, UltraGridColumn919, UltraGridColumn920, UltraGridColumn921, UltraGridColumn922, UltraGridColumn923, UltraGridColumn924, UltraGridColumn925, UltraGridColumn926, UltraGridColumn927, UltraGridColumn928, UltraGridColumn929, UltraGridColumn930, UltraGridColumn931})
        Me.griInv46.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griInv46.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv46.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv46.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv46.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv46.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv46.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv46.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv46.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv46.DisplayLayout.Override.CellPadding = 0
        Me.griInv46.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv46.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv46.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv46.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv46.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv46.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv46.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv46.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv46.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv46.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv46.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv46.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv46.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv46.Location = New System.Drawing.Point(0, 0)
        Me.griInv46.Name = "griInv46"
        Me.griInv46.Size = New System.Drawing.Size(1256, 251)
        Me.griInv46.TabIndex = 0
        Me.griInv46.Text = "3.13 Detalle Cuenta 46 y 47"
        '
        'UltraTabPageControl33
        '
        Me.UltraTabPageControl33.Controls.Add(Me.griInv47)
        Me.UltraTabPageControl33.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl33.Name = "UltraTabPageControl33"
        Me.UltraTabPageControl33.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv47
        '
        Me.griInv47.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn932.Header.VisiblePosition = 0
        UltraGridColumn932.Hidden = True
        UltraGridColumn933.Header.VisiblePosition = 1
        UltraGridColumn933.Hidden = True
        UltraGridColumn934.Header.VisiblePosition = 2
        UltraGridColumn934.Hidden = True
        UltraGridColumn935.Header.Caption = "Periodo (1)"
        UltraGridColumn935.Header.VisiblePosition = 3
        UltraGridColumn936.Header.Caption = "CUO (2)"
        UltraGridColumn936.Header.VisiblePosition = 4
        UltraGridColumn937.Header.VisiblePosition = 5
        UltraGridColumn937.Hidden = True
        UltraGridColumn938.Header.VisiblePosition = 6
        UltraGridColumn938.Hidden = True
        UltraGridColumn939.Header.Caption = "Tipo Doc Identidad (4)"
        UltraGridColumn939.Header.VisiblePosition = 8
        UltraGridColumn940.Header.Caption = "Nro Doc Identidad (5)"
        UltraGridColumn940.Header.VisiblePosition = 9
        UltraGridColumn941.Header.VisiblePosition = 10
        UltraGridColumn941.Hidden = True
        UltraGridColumn942.Header.Caption = "Apellidos y Nombres (6)"
        UltraGridColumn942.Header.VisiblePosition = 11
        UltraGridColumn943.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn943.Header.VisiblePosition = 7
        UltraGridColumn944.Header.VisiblePosition = 12
        UltraGridColumn944.Hidden = True
        UltraGridColumn945.Header.VisiblePosition = 13
        UltraGridColumn945.Hidden = True
        UltraGridColumn946.Header.VisiblePosition = 14
        UltraGridColumn946.Hidden = True
        UltraGridColumn947.Header.VisiblePosition = 15
        UltraGridColumn947.Hidden = True
        UltraGridColumn948.Header.VisiblePosition = 16
        UltraGridColumn948.Hidden = True
        UltraGridColumn949.Header.VisiblePosition = 17
        UltraGridColumn949.Hidden = True
        UltraGridColumn950.Header.VisiblePosition = 18
        UltraGridColumn950.Hidden = True
        UltraGridColumn951.Header.VisiblePosition = 19
        UltraGridColumn951.Hidden = True
        UltraGridColumn952.Header.VisiblePosition = 20
        UltraGridColumn952.Hidden = True
        UltraGridColumn953.Header.VisiblePosition = 21
        UltraGridColumn953.Hidden = True
        UltraGridColumn954.Header.VisiblePosition = 22
        UltraGridColumn954.Hidden = True
        UltraGridColumn955.Header.VisiblePosition = 23
        UltraGridColumn955.Hidden = True
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn956.CellAppearance = Appearance21
        UltraGridColumn956.Header.Caption = "Monto (7)"
        UltraGridColumn956.Header.VisiblePosition = 24
        UltraGridColumn956.MaskInput = "{double:-9.2}"
        UltraGridColumn957.Header.VisiblePosition = 25
        UltraGridColumn957.Hidden = True
        UltraGridColumn958.Header.VisiblePosition = 26
        UltraGridColumn958.Hidden = True
        UltraGridColumn959.Header.VisiblePosition = 27
        UltraGridColumn959.Hidden = True
        UltraGridColumn960.Header.VisiblePosition = 28
        UltraGridColumn960.Hidden = True
        UltraGridColumn961.Header.VisiblePosition = 29
        UltraGridColumn961.Hidden = True
        UltraGridColumn962.Header.VisiblePosition = 30
        UltraGridColumn962.Hidden = True
        UltraGridColumn963.Header.VisiblePosition = 31
        UltraGridColumn963.Hidden = True
        UltraGridColumn964.Header.VisiblePosition = 32
        UltraGridColumn964.Hidden = True
        UltraGridColumn965.Header.VisiblePosition = 33
        UltraGridColumn965.Hidden = True
        UltraGridColumn966.Header.Caption = "Indicador (8)"
        UltraGridColumn966.Header.VisiblePosition = 34
        UltraGridColumn967.Header.VisiblePosition = 35
        UltraGridColumn967.Hidden = True
        UltraGridColumn968.Header.VisiblePosition = 36
        UltraGridColumn968.Hidden = True
        UltraGridColumn969.Header.VisiblePosition = 37
        UltraGridColumn969.Hidden = True
        UltraGridColumn970.Header.VisiblePosition = 38
        UltraGridColumn970.Hidden = True
        UltraGridColumn971.Header.VisiblePosition = 39
        UltraGridColumn971.Hidden = True
        UltraGridColumn972.Header.VisiblePosition = 40
        UltraGridColumn972.Hidden = True
        UltraGridColumn973.Header.VisiblePosition = 41
        UltraGridColumn973.Hidden = True
        UltraGridColumn974.Header.VisiblePosition = 42
        UltraGridColumn974.Hidden = True
        UltraGridColumn975.Header.VisiblePosition = 43
        UltraGridColumn975.Hidden = True
        UltraGridColumn976.Header.VisiblePosition = 44
        UltraGridColumn976.Hidden = True
        UltraGridColumn977.Header.VisiblePosition = 45
        UltraGridColumn977.Hidden = True
        UltraGridColumn978.Header.VisiblePosition = 46
        UltraGridColumn978.Hidden = True
        UltraGridColumn979.Header.VisiblePosition = 47
        UltraGridColumn979.Hidden = True
        UltraGridColumn980.Header.VisiblePosition = 48
        UltraGridColumn980.Hidden = True
        UltraGridColumn981.Header.VisiblePosition = 49
        UltraGridColumn981.Hidden = True
        UltraGridColumn982.Header.VisiblePosition = 50
        UltraGridColumn982.Hidden = True
        UltraGridColumn983.Header.VisiblePosition = 51
        UltraGridColumn983.Hidden = True
        UltraGridColumn984.Header.VisiblePosition = 52
        UltraGridColumn984.Hidden = True
        UltraGridColumn985.Header.VisiblePosition = 53
        UltraGridColumn985.Hidden = True
        UltraGridBand13.Columns.AddRange(New Object() {UltraGridColumn932, UltraGridColumn933, UltraGridColumn934, UltraGridColumn935, UltraGridColumn936, UltraGridColumn937, UltraGridColumn938, UltraGridColumn939, UltraGridColumn940, UltraGridColumn941, UltraGridColumn942, UltraGridColumn943, UltraGridColumn944, UltraGridColumn945, UltraGridColumn946, UltraGridColumn947, UltraGridColumn948, UltraGridColumn949, UltraGridColumn950, UltraGridColumn951, UltraGridColumn952, UltraGridColumn953, UltraGridColumn954, UltraGridColumn955, UltraGridColumn956, UltraGridColumn957, UltraGridColumn958, UltraGridColumn959, UltraGridColumn960, UltraGridColumn961, UltraGridColumn962, UltraGridColumn963, UltraGridColumn964, UltraGridColumn965, UltraGridColumn966, UltraGridColumn967, UltraGridColumn968, UltraGridColumn969, UltraGridColumn970, UltraGridColumn971, UltraGridColumn972, UltraGridColumn973, UltraGridColumn974, UltraGridColumn975, UltraGridColumn976, UltraGridColumn977, UltraGridColumn978, UltraGridColumn979, UltraGridColumn980, UltraGridColumn981, UltraGridColumn982, UltraGridColumn983, UltraGridColumn984, UltraGridColumn985})
        Me.griInv47.DisplayLayout.BandsSerializer.Add(UltraGridBand13)
        Me.griInv47.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv47.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv47.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv47.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv47.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv47.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv47.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv47.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv47.DisplayLayout.Override.CellPadding = 0
        Me.griInv47.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv47.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv47.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv47.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv47.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv47.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv47.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv47.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv47.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv47.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv47.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv47.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv47.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv47.Location = New System.Drawing.Point(0, 0)
        Me.griInv47.Name = "griInv47"
        Me.griInv47.Size = New System.Drawing.Size(1256, 251)
        Me.griInv47.TabIndex = 0
        Me.griInv47.Text = "3.14 Detalle Cuenta 47"
        '
        'UltraTabPageControl34
        '
        Me.UltraTabPageControl34.Controls.Add(Me.griInv37)
        Me.UltraTabPageControl34.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl34.Name = "UltraTabPageControl34"
        Me.UltraTabPageControl34.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv37
        '
        Me.griInv37.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn986.Header.VisiblePosition = 0
        UltraGridColumn986.Hidden = True
        UltraGridColumn987.Header.VisiblePosition = 1
        UltraGridColumn987.Hidden = True
        UltraGridColumn988.Header.VisiblePosition = 2
        UltraGridColumn988.Hidden = True
        UltraGridColumn989.Header.Caption = "Periodo (1)"
        UltraGridColumn989.Header.VisiblePosition = 3
        UltraGridColumn990.Header.Caption = "CUO (2)"
        UltraGridColumn990.Header.VisiblePosition = 4
        UltraGridColumn991.Header.VisiblePosition = 5
        UltraGridColumn991.Hidden = True
        UltraGridColumn992.Header.VisiblePosition = 6
        UltraGridColumn992.Hidden = True
        UltraGridColumn993.Header.Caption = "Tipo Doc (4)"
        UltraGridColumn993.Header.VisiblePosition = 8
        UltraGridColumn994.Header.Caption = "Serie Doc (5)"
        UltraGridColumn994.Header.VisiblePosition = 9
        UltraGridColumn995.Header.Caption = "Cuenta Contable (7)"
        UltraGridColumn995.Header.VisiblePosition = 11
        UltraGridColumn996.Header.Caption = "Numero Doc (6)"
        UltraGridColumn996.Header.VisiblePosition = 10
        UltraGridColumn997.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn997.Header.VisiblePosition = 7
        UltraGridColumn998.Header.VisiblePosition = 12
        UltraGridColumn998.Hidden = True
        UltraGridColumn999.Header.VisiblePosition = 13
        UltraGridColumn999.Hidden = True
        UltraGridColumn1000.Header.VisiblePosition = 14
        UltraGridColumn1000.Hidden = True
        UltraGridColumn1000.Width = 76
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn1001.CellAppearance = Appearance22
        UltraGridColumn1001.Header.Caption = "Saldo (9)"
        UltraGridColumn1001.Header.VisiblePosition = 16
        UltraGridColumn1001.MaskInput = "{double:-9.2}"
        UltraGridColumn1002.Header.VisiblePosition = 17
        UltraGridColumn1002.Hidden = True
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn1003.CellAppearance = Appearance23
        UltraGridColumn1003.Header.Caption = "Adiciones (10)"
        UltraGridColumn1003.Header.VisiblePosition = 18
        UltraGridColumn1003.MaskInput = "{double:-9.2}"
        UltraGridColumn1004.Header.VisiblePosition = 19
        UltraGridColumn1004.Hidden = True
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn1005.CellAppearance = Appearance24
        UltraGridColumn1005.Header.Caption = "Deducciones (11)"
        UltraGridColumn1005.Header.VisiblePosition = 20
        UltraGridColumn1005.MaskInput = "{double:-9.2}"
        UltraGridColumn1006.Header.VisiblePosition = 21
        UltraGridColumn1006.Hidden = True
        UltraGridColumn1007.Header.VisiblePosition = 22
        UltraGridColumn1007.Hidden = True
        UltraGridColumn1008.Header.VisiblePosition = 23
        UltraGridColumn1008.Hidden = True
        UltraGridColumn1009.Header.VisiblePosition = 24
        UltraGridColumn1009.Hidden = True
        UltraGridColumn1010.Header.VisiblePosition = 25
        UltraGridColumn1010.Hidden = True
        UltraGridColumn1011.Header.VisiblePosition = 26
        UltraGridColumn1011.Hidden = True
        UltraGridColumn1012.Header.VisiblePosition = 27
        UltraGridColumn1012.Hidden = True
        UltraGridColumn1013.Header.VisiblePosition = 28
        UltraGridColumn1013.Hidden = True
        UltraGridColumn1014.Header.VisiblePosition = 29
        UltraGridColumn1014.Hidden = True
        UltraGridColumn1015.Header.VisiblePosition = 30
        UltraGridColumn1015.Hidden = True
        UltraGridColumn1016.Header.VisiblePosition = 31
        UltraGridColumn1016.Hidden = True
        UltraGridColumn1017.Header.VisiblePosition = 32
        UltraGridColumn1017.Hidden = True
        UltraGridColumn1018.Header.Caption = "Concepto (8)"
        UltraGridColumn1018.Header.VisiblePosition = 15
        UltraGridColumn1019.Header.VisiblePosition = 33
        UltraGridColumn1019.Hidden = True
        UltraGridColumn1020.Header.Caption = "Indicador (12)"
        UltraGridColumn1020.Header.VisiblePosition = 34
        UltraGridColumn1021.Header.VisiblePosition = 35
        UltraGridColumn1021.Hidden = True
        UltraGridColumn1022.Header.VisiblePosition = 36
        UltraGridColumn1022.Hidden = True
        UltraGridColumn1023.Header.VisiblePosition = 37
        UltraGridColumn1023.Hidden = True
        UltraGridColumn1024.Header.VisiblePosition = 38
        UltraGridColumn1024.Hidden = True
        UltraGridColumn1025.Header.VisiblePosition = 39
        UltraGridColumn1025.Hidden = True
        UltraGridColumn1026.Header.VisiblePosition = 40
        UltraGridColumn1026.Hidden = True
        UltraGridColumn1027.Header.VisiblePosition = 41
        UltraGridColumn1027.Hidden = True
        UltraGridColumn1028.Header.VisiblePosition = 42
        UltraGridColumn1028.Hidden = True
        UltraGridColumn1029.Header.VisiblePosition = 43
        UltraGridColumn1029.Hidden = True
        UltraGridColumn1030.Header.VisiblePosition = 44
        UltraGridColumn1030.Hidden = True
        UltraGridColumn1031.Header.VisiblePosition = 45
        UltraGridColumn1031.Hidden = True
        UltraGridColumn1032.Header.VisiblePosition = 46
        UltraGridColumn1032.Hidden = True
        UltraGridColumn1033.Header.VisiblePosition = 47
        UltraGridColumn1033.Hidden = True
        UltraGridColumn1034.Header.VisiblePosition = 48
        UltraGridColumn1034.Hidden = True
        UltraGridColumn1035.Header.VisiblePosition = 49
        UltraGridColumn1035.Hidden = True
        UltraGridColumn1036.Header.VisiblePosition = 50
        UltraGridColumn1036.Hidden = True
        UltraGridColumn1037.Header.VisiblePosition = 51
        UltraGridColumn1037.Hidden = True
        UltraGridColumn1038.Header.VisiblePosition = 52
        UltraGridColumn1038.Hidden = True
        UltraGridColumn1039.Header.VisiblePosition = 53
        UltraGridColumn1039.Hidden = True
        UltraGridBand14.Columns.AddRange(New Object() {UltraGridColumn986, UltraGridColumn987, UltraGridColumn988, UltraGridColumn989, UltraGridColumn990, UltraGridColumn991, UltraGridColumn992, UltraGridColumn993, UltraGridColumn994, UltraGridColumn995, UltraGridColumn996, UltraGridColumn997, UltraGridColumn998, UltraGridColumn999, UltraGridColumn1000, UltraGridColumn1001, UltraGridColumn1002, UltraGridColumn1003, UltraGridColumn1004, UltraGridColumn1005, UltraGridColumn1006, UltraGridColumn1007, UltraGridColumn1008, UltraGridColumn1009, UltraGridColumn1010, UltraGridColumn1011, UltraGridColumn1012, UltraGridColumn1013, UltraGridColumn1014, UltraGridColumn1015, UltraGridColumn1016, UltraGridColumn1017, UltraGridColumn1018, UltraGridColumn1019, UltraGridColumn1020, UltraGridColumn1021, UltraGridColumn1022, UltraGridColumn1023, UltraGridColumn1024, UltraGridColumn1025, UltraGridColumn1026, UltraGridColumn1027, UltraGridColumn1028, UltraGridColumn1029, UltraGridColumn1030, UltraGridColumn1031, UltraGridColumn1032, UltraGridColumn1033, UltraGridColumn1034, UltraGridColumn1035, UltraGridColumn1036, UltraGridColumn1037, UltraGridColumn1038, UltraGridColumn1039})
        Me.griInv37.DisplayLayout.BandsSerializer.Add(UltraGridBand14)
        Me.griInv37.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv37.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv37.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv37.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv37.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv37.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv37.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv37.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInv37.DisplayLayout.Override.CellPadding = 0
        Me.griInv37.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv37.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv37.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv37.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv37.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv37.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv37.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv37.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv37.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv37.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv37.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv37.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv37.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv37.Location = New System.Drawing.Point(0, 0)
        Me.griInv37.Name = "griInv37"
        Me.griInv37.Size = New System.Drawing.Size(1256, 251)
        Me.griInv37.TabIndex = 0
        Me.griInv37.Text = "3.15 Detalle Cuenta 37"
        '
        'UltraTabPageControl35
        '
        Me.UltraTabPageControl35.Controls.Add(Me.griInv50)
        Me.UltraTabPageControl35.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl35.Name = "UltraTabPageControl35"
        Me.UltraTabPageControl35.Size = New System.Drawing.Size(1256, 251)
        '
        'griInv50
        '
        Me.griInv50.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1040.Header.VisiblePosition = 0
        UltraGridColumn1040.Hidden = True
        UltraGridColumn1041.Header.VisiblePosition = 1
        UltraGridColumn1041.Hidden = True
        UltraGridColumn1042.Header.VisiblePosition = 2
        UltraGridColumn1042.Hidden = True
        UltraGridColumn1043.Header.Caption = "Periodo (1)"
        UltraGridColumn1043.Header.VisiblePosition = 3
        UltraGridColumn1044.Header.VisiblePosition = 4
        UltraGridColumn1044.Hidden = True
        UltraGridColumn1045.Header.VisiblePosition = 5
        UltraGridColumn1045.Hidden = True
        UltraGridColumn1046.Header.VisiblePosition = 6
        UltraGridColumn1046.Hidden = True
        UltraGridColumn1047.Header.VisiblePosition = 7
        UltraGridColumn1047.Hidden = True
        UltraGridColumn1048.Header.VisiblePosition = 8
        UltraGridColumn1048.Hidden = True
        UltraGridColumn1049.Header.VisiblePosition = 9
        UltraGridColumn1049.Hidden = True
        UltraGridColumn1050.Header.VisiblePosition = 10
        UltraGridColumn1050.Hidden = True
        UltraGridColumn1051.Header.VisiblePosition = 11
        UltraGridColumn1051.Hidden = True
        UltraGridColumn1052.Header.VisiblePosition = 12
        UltraGridColumn1052.Hidden = True
        UltraGridColumn1053.Header.VisiblePosition = 13
        UltraGridColumn1053.Hidden = True
        UltraGridColumn1054.Header.VisiblePosition = 14
        UltraGridColumn1054.Hidden = True
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn1055.CellAppearance = Appearance25
        UltraGridColumn1055.Header.Caption = "Capital Social (2)"
        UltraGridColumn1055.Header.VisiblePosition = 15
        UltraGridColumn1055.MaskInput = "{double:-9.2}"
        UltraGridColumn1056.Header.VisiblePosition = 16
        UltraGridColumn1056.Hidden = True
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn1057.CellAppearance = Appearance26
        UltraGridColumn1057.Header.Caption = "Valor Nominal Accion (2)"
        UltraGridColumn1057.Header.VisiblePosition = 17
        UltraGridColumn1057.MaskInput = "{double:-9.2}"
        UltraGridColumn1058.Header.VisiblePosition = 18
        UltraGridColumn1058.Hidden = True
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn1059.CellAppearance = Appearance27
        UltraGridColumn1059.Header.Caption = "Nro Acciones Suscritas"
        UltraGridColumn1059.Header.VisiblePosition = 19
        UltraGridColumn1059.MaskInput = "{double:-9.2}"
        UltraGridColumn1060.Header.VisiblePosition = 20
        UltraGridColumn1060.Hidden = True
        UltraGridColumn1061.Header.VisiblePosition = 21
        UltraGridColumn1061.Hidden = True
        UltraGridColumn1062.Header.VisiblePosition = 22
        UltraGridColumn1062.Hidden = True
        UltraGridColumn1063.Header.VisiblePosition = 23
        UltraGridColumn1063.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn1064.CellAppearance = Appearance28
        UltraGridColumn1064.Header.Caption = "Nro Acciones Pagadas (5)"
        UltraGridColumn1064.Header.VisiblePosition = 24
        UltraGridColumn1064.MaskInput = "{double:-9.2}"
        UltraGridColumn1065.Header.VisiblePosition = 25
        UltraGridColumn1065.Hidden = True
        UltraGridColumn1066.Header.VisiblePosition = 26
        UltraGridColumn1066.Hidden = True
        UltraGridColumn1067.Header.VisiblePosition = 27
        UltraGridColumn1067.Hidden = True
        UltraGridColumn1068.Header.VisiblePosition = 28
        UltraGridColumn1068.Hidden = True
        UltraGridColumn1069.Header.VisiblePosition = 29
        UltraGridColumn1069.Hidden = True
        UltraGridColumn1070.Header.VisiblePosition = 30
        UltraGridColumn1070.Hidden = True
        UltraGridColumn1071.Header.VisiblePosition = 31
        UltraGridColumn1071.Hidden = True
        UltraGridColumn1072.Header.VisiblePosition = 32
        UltraGridColumn1072.Hidden = True
        UltraGridColumn1073.Header.VisiblePosition = 33
        UltraGridColumn1073.Hidden = True
        UltraGridColumn1074.Header.Caption = "Indicador (6)"
        UltraGridColumn1074.Header.VisiblePosition = 34
        UltraGridColumn1075.Header.VisiblePosition = 35
        UltraGridColumn1075.Hidden = True
        UltraGridColumn1076.Header.VisiblePosition = 36
        UltraGridColumn1076.Hidden = True
        UltraGridColumn1077.Header.VisiblePosition = 37
        UltraGridColumn1077.Hidden = True
        UltraGridColumn1078.Header.VisiblePosition = 38
        UltraGridColumn1078.Hidden = True
        UltraGridColumn1079.Header.VisiblePosition = 39
        UltraGridColumn1079.Hidden = True
        UltraGridColumn1080.Header.VisiblePosition = 40
        UltraGridColumn1080.Hidden = True
        UltraGridColumn1081.Header.VisiblePosition = 41
        UltraGridColumn1081.Hidden = True
        UltraGridColumn1082.Header.VisiblePosition = 42
        UltraGridColumn1082.Hidden = True
        UltraGridColumn1083.Header.VisiblePosition = 43
        UltraGridColumn1083.Hidden = True
        UltraGridColumn1084.Header.VisiblePosition = 44
        UltraGridColumn1084.Hidden = True
        UltraGridColumn1084.Width = 79
        UltraGridColumn1085.Header.VisiblePosition = 45
        UltraGridColumn1085.Hidden = True
        UltraGridColumn1086.Header.VisiblePosition = 46
        UltraGridColumn1086.Hidden = True
        UltraGridColumn1087.Header.VisiblePosition = 47
        UltraGridColumn1087.Hidden = True
        UltraGridColumn1088.Header.VisiblePosition = 48
        UltraGridColumn1088.Hidden = True
        UltraGridColumn1089.Header.VisiblePosition = 49
        UltraGridColumn1089.Hidden = True
        UltraGridColumn1090.Header.VisiblePosition = 50
        UltraGridColumn1090.Hidden = True
        UltraGridColumn1091.Header.VisiblePosition = 51
        UltraGridColumn1091.Hidden = True
        UltraGridColumn1092.Header.VisiblePosition = 52
        UltraGridColumn1092.Hidden = True
        UltraGridColumn1093.Header.VisiblePosition = 53
        UltraGridColumn1093.Hidden = True
        UltraGridBand15.Columns.AddRange(New Object() {UltraGridColumn1040, UltraGridColumn1041, UltraGridColumn1042, UltraGridColumn1043, UltraGridColumn1044, UltraGridColumn1045, UltraGridColumn1046, UltraGridColumn1047, UltraGridColumn1048, UltraGridColumn1049, UltraGridColumn1050, UltraGridColumn1051, UltraGridColumn1052, UltraGridColumn1053, UltraGridColumn1054, UltraGridColumn1055, UltraGridColumn1056, UltraGridColumn1057, UltraGridColumn1058, UltraGridColumn1059, UltraGridColumn1060, UltraGridColumn1061, UltraGridColumn1062, UltraGridColumn1063, UltraGridColumn1064, UltraGridColumn1065, UltraGridColumn1066, UltraGridColumn1067, UltraGridColumn1068, UltraGridColumn1069, UltraGridColumn1070, UltraGridColumn1071, UltraGridColumn1072, UltraGridColumn1073, UltraGridColumn1074, UltraGridColumn1075, UltraGridColumn1076, UltraGridColumn1077, UltraGridColumn1078, UltraGridColumn1079, UltraGridColumn1080, UltraGridColumn1081, UltraGridColumn1082, UltraGridColumn1083, UltraGridColumn1084, UltraGridColumn1085, UltraGridColumn1086, UltraGridColumn1087, UltraGridColumn1088, UltraGridColumn1089, UltraGridColumn1090, UltraGridColumn1091, UltraGridColumn1092, UltraGridColumn1093})
        Me.griInv50.DisplayLayout.BandsSerializer.Add(UltraGridBand15)
        Me.griInv50.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv50.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInv50.DisplayLayout.MaxColScrollRegions = 1
        Me.griInv50.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInv50.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInv50.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv50.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInv50.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griInv50.DisplayLayout.Override.CellPadding = 0
        Me.griInv50.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInv50.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInv50.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInv50.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInv50.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInv50.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInv50.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInv50.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInv50.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInv50.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInv50.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInv50.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInv50.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInv50.Location = New System.Drawing.Point(0, 0)
        Me.griInv50.Name = "griInv50"
        Me.griInv50.Size = New System.Drawing.Size(1256, 251)
        Me.griInv50.TabIndex = 0
        Me.griInv50.Text = "3.16.1 Detalle Cuenta 50"
        '
        'UltraTabPageControl36
        '
        Me.UltraTabPageControl36.Controls.Add(Me.griInvParticionaria)
        Me.UltraTabPageControl36.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl36.Name = "UltraTabPageControl36"
        Me.UltraTabPageControl36.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvParticionaria
        '
        Me.griInvParticionaria.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1094.Header.VisiblePosition = 0
        UltraGridColumn1094.Hidden = True
        UltraGridColumn1095.Header.VisiblePosition = 1
        UltraGridColumn1095.Hidden = True
        UltraGridColumn1096.Header.VisiblePosition = 2
        UltraGridColumn1096.Hidden = True
        UltraGridColumn1097.Header.Caption = "Periodo (1)"
        UltraGridColumn1097.Header.VisiblePosition = 3
        UltraGridColumn1098.Header.Caption = "Cod Tipo (5)"
        UltraGridColumn1098.Header.VisiblePosition = 9
        UltraGridColumn1099.Header.VisiblePosition = 11
        UltraGridColumn1099.Hidden = True
        UltraGridColumn1100.Header.VisiblePosition = 12
        UltraGridColumn1100.Hidden = True
        UltraGridColumn1101.Header.Caption = "Tipo Doc Identidad (2)"
        UltraGridColumn1101.Header.VisiblePosition = 7
        UltraGridColumn1102.Header.Caption = "Nro Doc Identidad (3)"
        UltraGridColumn1102.Header.VisiblePosition = 8
        UltraGridColumn1103.Header.Caption = "Apellidos y Nombres (4)"
        UltraGridColumn1103.Header.VisiblePosition = 10
        UltraGridColumn1104.Header.VisiblePosition = 13
        UltraGridColumn1104.Hidden = True
        UltraGridColumn1105.Header.VisiblePosition = 14
        UltraGridColumn1105.Hidden = True
        UltraGridColumn1106.Header.VisiblePosition = 4
        UltraGridColumn1106.Hidden = True
        UltraGridColumn1107.Header.Caption = "NroDocIdentidad"
        UltraGridColumn1107.Header.VisiblePosition = 5
        UltraGridColumn1107.Hidden = True
        UltraGridColumn1108.Header.VisiblePosition = 6
        UltraGridColumn1108.Hidden = True
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn1109.CellAppearance = Appearance29
        UltraGridColumn1109.Header.Caption = "Nro Accion (6)"
        UltraGridColumn1109.Header.VisiblePosition = 15
        UltraGridColumn1109.MaskInput = "{double:-9.2}"
        UltraGridColumn1110.Header.VisiblePosition = 16
        UltraGridColumn1110.Hidden = True
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn1111.CellAppearance = Appearance30
        UltraGridColumn1111.Header.Caption = "% Total (7)"
        UltraGridColumn1111.Header.VisiblePosition = 17
        UltraGridColumn1111.MaskInput = "{double:-9.2}"
        UltraGridColumn1112.Header.VisiblePosition = 18
        UltraGridColumn1112.Hidden = True
        UltraGridColumn1113.Header.VisiblePosition = 19
        UltraGridColumn1113.Hidden = True
        UltraGridColumn1114.Header.VisiblePosition = 20
        UltraGridColumn1114.Hidden = True
        UltraGridColumn1115.Header.VisiblePosition = 21
        UltraGridColumn1115.Hidden = True
        UltraGridColumn1116.Header.VisiblePosition = 22
        UltraGridColumn1116.Hidden = True
        UltraGridColumn1117.Header.VisiblePosition = 23
        UltraGridColumn1117.Hidden = True
        UltraGridColumn1118.Header.VisiblePosition = 24
        UltraGridColumn1118.Hidden = True
        UltraGridColumn1119.Header.VisiblePosition = 25
        UltraGridColumn1119.Hidden = True
        UltraGridColumn1120.Header.VisiblePosition = 26
        UltraGridColumn1120.Hidden = True
        UltraGridColumn1121.Header.VisiblePosition = 27
        UltraGridColumn1121.Hidden = True
        UltraGridColumn1122.Header.VisiblePosition = 28
        UltraGridColumn1122.Hidden = True
        UltraGridColumn1123.Header.VisiblePosition = 29
        UltraGridColumn1123.Hidden = True
        UltraGridColumn1124.Header.VisiblePosition = 30
        UltraGridColumn1124.Hidden = True
        UltraGridColumn1125.Header.VisiblePosition = 31
        UltraGridColumn1125.Hidden = True
        UltraGridColumn1126.Header.VisiblePosition = 32
        UltraGridColumn1126.Hidden = True
        UltraGridColumn1127.Header.VisiblePosition = 33
        UltraGridColumn1127.Hidden = True
        UltraGridColumn1128.Header.Caption = "Indicador (8)"
        UltraGridColumn1128.Header.VisiblePosition = 34
        UltraGridColumn1129.Header.VisiblePosition = 35
        UltraGridColumn1129.Hidden = True
        UltraGridColumn1130.Header.VisiblePosition = 36
        UltraGridColumn1130.Hidden = True
        UltraGridColumn1131.Header.VisiblePosition = 37
        UltraGridColumn1131.Hidden = True
        UltraGridColumn1132.Header.VisiblePosition = 38
        UltraGridColumn1132.Hidden = True
        UltraGridColumn1133.Header.VisiblePosition = 39
        UltraGridColumn1133.Hidden = True
        UltraGridColumn1134.Header.VisiblePosition = 40
        UltraGridColumn1134.Hidden = True
        UltraGridColumn1135.Header.VisiblePosition = 41
        UltraGridColumn1135.Hidden = True
        UltraGridColumn1136.Header.VisiblePosition = 42
        UltraGridColumn1136.Hidden = True
        UltraGridColumn1137.Header.VisiblePosition = 43
        UltraGridColumn1137.Hidden = True
        UltraGridColumn1138.Header.VisiblePosition = 44
        UltraGridColumn1138.Hidden = True
        UltraGridColumn1139.Header.VisiblePosition = 45
        UltraGridColumn1139.Hidden = True
        UltraGridColumn1140.Header.VisiblePosition = 46
        UltraGridColumn1140.Hidden = True
        UltraGridColumn1141.Header.VisiblePosition = 47
        UltraGridColumn1141.Hidden = True
        UltraGridColumn1142.Header.VisiblePosition = 48
        UltraGridColumn1142.Hidden = True
        UltraGridColumn1143.Header.VisiblePosition = 49
        UltraGridColumn1143.Hidden = True
        UltraGridColumn1144.Header.VisiblePosition = 50
        UltraGridColumn1144.Hidden = True
        UltraGridColumn1145.Header.VisiblePosition = 51
        UltraGridColumn1145.Hidden = True
        UltraGridColumn1146.Header.VisiblePosition = 52
        UltraGridColumn1146.Hidden = True
        UltraGridColumn1147.Header.VisiblePosition = 53
        UltraGridColumn1147.Hidden = True
        UltraGridBand16.Columns.AddRange(New Object() {UltraGridColumn1094, UltraGridColumn1095, UltraGridColumn1096, UltraGridColumn1097, UltraGridColumn1098, UltraGridColumn1099, UltraGridColumn1100, UltraGridColumn1101, UltraGridColumn1102, UltraGridColumn1103, UltraGridColumn1104, UltraGridColumn1105, UltraGridColumn1106, UltraGridColumn1107, UltraGridColumn1108, UltraGridColumn1109, UltraGridColumn1110, UltraGridColumn1111, UltraGridColumn1112, UltraGridColumn1113, UltraGridColumn1114, UltraGridColumn1115, UltraGridColumn1116, UltraGridColumn1117, UltraGridColumn1118, UltraGridColumn1119, UltraGridColumn1120, UltraGridColumn1121, UltraGridColumn1122, UltraGridColumn1123, UltraGridColumn1124, UltraGridColumn1125, UltraGridColumn1126, UltraGridColumn1127, UltraGridColumn1128, UltraGridColumn1129, UltraGridColumn1130, UltraGridColumn1131, UltraGridColumn1132, UltraGridColumn1133, UltraGridColumn1134, UltraGridColumn1135, UltraGridColumn1136, UltraGridColumn1137, UltraGridColumn1138, UltraGridColumn1139, UltraGridColumn1140, UltraGridColumn1141, UltraGridColumn1142, UltraGridColumn1143, UltraGridColumn1144, UltraGridColumn1145, UltraGridColumn1146, UltraGridColumn1147})
        Me.griInvParticionaria.DisplayLayout.BandsSerializer.Add(UltraGridBand16)
        Me.griInvParticionaria.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvParticionaria.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvParticionaria.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvParticionaria.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvParticionaria.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvParticionaria.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvParticionaria.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvParticionaria.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griInvParticionaria.DisplayLayout.Override.CellPadding = 0
        Me.griInvParticionaria.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInvParticionaria.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvParticionaria.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvParticionaria.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvParticionaria.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvParticionaria.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvParticionaria.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griInvParticionaria.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvParticionaria.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvParticionaria.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvParticionaria.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvParticionaria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvParticionaria.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvParticionaria.Location = New System.Drawing.Point(0, 0)
        Me.griInvParticionaria.Name = "griInvParticionaria"
        Me.griInvParticionaria.Size = New System.Drawing.Size(1256, 251)
        Me.griInvParticionaria.TabIndex = 0
        Me.griInvParticionaria.Text = "3.16.2 Detalle de Participacion"
        '
        'UltraTabPageControl37
        '
        Me.UltraTabPageControl37.Controls.Add(Me.griInvBC)
        Me.UltraTabPageControl37.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl37.Name = "UltraTabPageControl37"
        Me.UltraTabPageControl37.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvBC
        '
        Me.griInvBC.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1148.Header.VisiblePosition = 0
        UltraGridColumn1148.Hidden = True
        UltraGridColumn1149.Header.VisiblePosition = 1
        UltraGridColumn1149.Hidden = True
        UltraGridColumn1150.Header.VisiblePosition = 2
        UltraGridColumn1150.Hidden = True
        UltraGridColumn1151.Header.Caption = "Periodo (1)"
        UltraGridColumn1151.Header.VisiblePosition = 3
        UltraGridColumn1152.Header.Caption = "Cta Ctble (2)"
        UltraGridColumn1152.Header.VisiblePosition = 4
        UltraGridColumn1153.Header.VisiblePosition = 5
        UltraGridColumn1153.Hidden = True
        UltraGridColumn1154.Header.VisiblePosition = 6
        UltraGridColumn1154.Hidden = True
        UltraGridColumn1155.Header.VisiblePosition = 7
        UltraGridColumn1155.Hidden = True
        UltraGridColumn1156.Header.VisiblePosition = 8
        UltraGridColumn1156.Hidden = True
        UltraGridColumn1157.Header.VisiblePosition = 9
        UltraGridColumn1157.Hidden = True
        UltraGridColumn1158.Header.VisiblePosition = 10
        UltraGridColumn1158.Hidden = True
        UltraGridColumn1159.Header.VisiblePosition = 11
        UltraGridColumn1159.Hidden = True
        UltraGridColumn1160.Header.VisiblePosition = 12
        UltraGridColumn1160.Hidden = True
        UltraGridColumn1161.Header.VisiblePosition = 13
        UltraGridColumn1161.Hidden = True
        UltraGridColumn1162.Header.VisiblePosition = 14
        UltraGridColumn1162.Hidden = True
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn1163.CellAppearance = Appearance31
        UltraGridColumn1163.Header.Caption = "Saldo Ini D (3)"
        UltraGridColumn1163.Header.VisiblePosition = 15
        UltraGridColumn1163.MaskInput = "{double:-9.2}"
        Appearance32.TextHAlignAsString = "Right"
        UltraGridColumn1164.CellAppearance = Appearance32
        UltraGridColumn1164.Header.Caption = "Saldo Ini H (4)"
        UltraGridColumn1164.Header.VisiblePosition = 16
        UltraGridColumn1164.MaskInput = "{double:-9.2}"
        Appearance33.TextHAlignAsString = "Right"
        UltraGridColumn1165.CellAppearance = Appearance33
        UltraGridColumn1165.Header.Caption = "Mov. Ejercicio D (5)"
        UltraGridColumn1165.Header.VisiblePosition = 17
        UltraGridColumn1165.MaskInput = "{double:-9.2}"
        Appearance34.TextHAlignAsString = "Right"
        UltraGridColumn1166.CellAppearance = Appearance34
        UltraGridColumn1166.Header.Caption = "Mov. Ejercicio H (6)"
        UltraGridColumn1166.Header.VisiblePosition = 18
        UltraGridColumn1166.MaskInput = "{double:-9.2}"
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn1167.CellAppearance = Appearance35
        UltraGridColumn1167.Header.Caption = "Sum Mayor D (7)"
        UltraGridColumn1167.Header.VisiblePosition = 19
        UltraGridColumn1167.MaskInput = "{double:-9.2}"
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn1168.CellAppearance = Appearance36
        UltraGridColumn1168.Header.Caption = "Sum Mayor H (8)"
        UltraGridColumn1168.Header.VisiblePosition = 20
        UltraGridColumn1168.MaskInput = "{double:-9.2}"
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn1169.CellAppearance = Appearance37
        UltraGridColumn1169.Header.Caption = "Saldo 31 Dic D (10)"
        UltraGridColumn1169.Header.VisiblePosition = 21
        UltraGridColumn1169.MaskInput = "{double:-9.2}"
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn1170.CellAppearance = Appearance38
        UltraGridColumn1170.Header.Caption = "Saldo 31 Dic A (11)"
        UltraGridColumn1170.Header.VisiblePosition = 22
        UltraGridColumn1170.MaskInput = "{double:-9.2}"
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn1171.CellAppearance = Appearance39
        UltraGridColumn1171.Header.Caption = "Trans. Canc D (12)"
        UltraGridColumn1171.Header.VisiblePosition = 23
        UltraGridColumn1171.MaskInput = "{double:-9.2}"
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn1172.CellAppearance = Appearance40
        UltraGridColumn1172.Header.Caption = "Trans. Canc H (13)"
        UltraGridColumn1172.Header.VisiblePosition = 24
        UltraGridColumn1172.MaskInput = "{double:-9.2}"
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn1173.CellAppearance = Appearance41
        UltraGridColumn1173.Header.Caption = "Cta. Balance Act (14)"
        UltraGridColumn1173.Header.VisiblePosition = 25
        UltraGridColumn1173.MaskInput = "{double:-9.2}"
        UltraGridColumn1174.Header.VisiblePosition = 26
        UltraGridColumn1174.Hidden = True
        UltraGridColumn1175.Header.VisiblePosition = 27
        UltraGridColumn1175.Hidden = True
        UltraGridColumn1176.Header.VisiblePosition = 28
        UltraGridColumn1176.Hidden = True
        UltraGridColumn1177.Header.VisiblePosition = 29
        UltraGridColumn1177.Hidden = True
        UltraGridColumn1178.Header.VisiblePosition = 30
        UltraGridColumn1178.Hidden = True
        UltraGridColumn1179.Header.VisiblePosition = 31
        UltraGridColumn1179.Hidden = True
        UltraGridColumn1180.Header.VisiblePosition = 32
        UltraGridColumn1180.Hidden = True
        UltraGridColumn1181.Header.VisiblePosition = 33
        UltraGridColumn1181.Hidden = True
        UltraGridColumn1182.Header.Caption = "Indicador (20)"
        UltraGridColumn1182.Header.VisiblePosition = 50
        UltraGridColumn1183.Header.VisiblePosition = 34
        UltraGridColumn1183.Hidden = True
        UltraGridColumn1184.Header.VisiblePosition = 35
        UltraGridColumn1184.Hidden = True
        UltraGridColumn1185.Header.VisiblePosition = 36
        UltraGridColumn1185.Hidden = True
        UltraGridColumn1186.Header.VisiblePosition = 37
        UltraGridColumn1186.Hidden = True
        UltraGridColumn1187.Header.VisiblePosition = 38
        UltraGridColumn1187.Hidden = True
        UltraGridColumn1188.Header.VisiblePosition = 39
        UltraGridColumn1188.Hidden = True
        UltraGridColumn1189.Header.VisiblePosition = 40
        UltraGridColumn1189.Hidden = True
        UltraGridColumn1190.Header.VisiblePosition = 41
        UltraGridColumn1190.Hidden = True
        UltraGridColumn1191.Header.VisiblePosition = 42
        UltraGridColumn1191.Hidden = True
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn1192.CellAppearance = Appearance42
        UltraGridColumn1192.Header.Caption = "Res. Nat. Gan (17)"
        UltraGridColumn1192.Header.VisiblePosition = 45
        UltraGridColumn1192.MaskInput = "{double:-9.2}"
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn1193.CellAppearance = Appearance43
        UltraGridColumn1193.Header.Caption = "Adicionales (18)"
        UltraGridColumn1193.Header.VisiblePosition = 46
        UltraGridColumn1193.MaskInput = "{double:-9.2}"
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn1194.CellAppearance = Appearance44
        UltraGridColumn1194.Header.Caption = "Deduciones (19)"
        UltraGridColumn1194.Header.VisiblePosition = 47
        UltraGridColumn1194.MaskInput = "{double:-9.2}"
        UltraGridColumn1195.Header.VisiblePosition = 48
        UltraGridColumn1195.Hidden = True
        UltraGridColumn1196.Header.VisiblePosition = 49
        UltraGridColumn1196.Hidden = True
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn1197.CellAppearance = Appearance45
        UltraGridColumn1197.Header.Caption = "Cta. Balance Pas (15)"
        UltraGridColumn1197.Header.VisiblePosition = 43
        UltraGridColumn1197.MaskInput = "{double:-9.2}"
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn1198.CellAppearance = Appearance46
        UltraGridColumn1198.Header.Caption = "Res. Nat. Perd (16)"
        UltraGridColumn1198.Header.VisiblePosition = 44
        UltraGridColumn1198.MaskInput = "{double:-9.2}"
        UltraGridColumn1199.Header.VisiblePosition = 51
        UltraGridColumn1199.Hidden = True
        UltraGridColumn1200.Header.VisiblePosition = 52
        UltraGridColumn1200.Hidden = True
        UltraGridColumn1201.Header.VisiblePosition = 53
        UltraGridColumn1201.Hidden = True
        UltraGridBand17.Columns.AddRange(New Object() {UltraGridColumn1148, UltraGridColumn1149, UltraGridColumn1150, UltraGridColumn1151, UltraGridColumn1152, UltraGridColumn1153, UltraGridColumn1154, UltraGridColumn1155, UltraGridColumn1156, UltraGridColumn1157, UltraGridColumn1158, UltraGridColumn1159, UltraGridColumn1160, UltraGridColumn1161, UltraGridColumn1162, UltraGridColumn1163, UltraGridColumn1164, UltraGridColumn1165, UltraGridColumn1166, UltraGridColumn1167, UltraGridColumn1168, UltraGridColumn1169, UltraGridColumn1170, UltraGridColumn1171, UltraGridColumn1172, UltraGridColumn1173, UltraGridColumn1174, UltraGridColumn1175, UltraGridColumn1176, UltraGridColumn1177, UltraGridColumn1178, UltraGridColumn1179, UltraGridColumn1180, UltraGridColumn1181, UltraGridColumn1182, UltraGridColumn1183, UltraGridColumn1184, UltraGridColumn1185, UltraGridColumn1186, UltraGridColumn1187, UltraGridColumn1188, UltraGridColumn1189, UltraGridColumn1190, UltraGridColumn1191, UltraGridColumn1192, UltraGridColumn1193, UltraGridColumn1194, UltraGridColumn1195, UltraGridColumn1196, UltraGridColumn1197, UltraGridColumn1198, UltraGridColumn1199, UltraGridColumn1200, UltraGridColumn1201})
        Me.griInvBC.DisplayLayout.BandsSerializer.Add(UltraGridBand17)
        Me.griInvBC.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvBC.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvBC.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvBC.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvBC.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvBC.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvBC.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvBC.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvBC.DisplayLayout.Override.CellPadding = 0
        Me.griInvBC.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInvBC.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvBC.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvBC.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvBC.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvBC.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvBC.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvBC.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvBC.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvBC.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvBC.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvBC.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvBC.Location = New System.Drawing.Point(0, 0)
        Me.griInvBC.Name = "griInvBC"
        Me.griInvBC.Size = New System.Drawing.Size(1256, 251)
        Me.griInvBC.TabIndex = 0
        Me.griInvBC.Text = "3.17 Balance de Comprobacion"
        '
        'UltraTabPageControl38
        '
        Me.UltraTabPageControl38.Controls.Add(Me.griInvEFEMD)
        Me.UltraTabPageControl38.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl38.Name = "UltraTabPageControl38"
        Me.UltraTabPageControl38.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvEFEMD
        '
        Me.griInvEFEMD.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1202.Header.VisiblePosition = 0
        UltraGridColumn1202.Hidden = True
        UltraGridColumn1203.Header.VisiblePosition = 1
        UltraGridColumn1203.Hidden = True
        UltraGridColumn1204.Header.VisiblePosition = 2
        UltraGridColumn1204.Hidden = True
        UltraGridColumn1205.Header.Caption = "Periodo (1)"
        UltraGridColumn1205.Header.VisiblePosition = 3
        UltraGridColumn1206.Header.Caption = "Cod. Catalago (2)"
        UltraGridColumn1206.Header.VisiblePosition = 4
        UltraGridColumn1207.Header.VisiblePosition = 5
        UltraGridColumn1207.Hidden = True
        UltraGridColumn1208.Header.VisiblePosition = 6
        UltraGridColumn1208.Hidden = True
        UltraGridColumn1209.Header.Caption = "Cod Rubro (3)"
        UltraGridColumn1209.Header.VisiblePosition = 7
        UltraGridColumn1210.Header.VisiblePosition = 8
        UltraGridColumn1210.Hidden = True
        UltraGridColumn1211.Header.VisiblePosition = 9
        UltraGridColumn1211.Hidden = True
        UltraGridColumn1212.Header.VisiblePosition = 10
        UltraGridColumn1212.Hidden = True
        UltraGridColumn1213.Header.VisiblePosition = 11
        UltraGridColumn1213.Hidden = True
        UltraGridColumn1214.Header.VisiblePosition = 12
        UltraGridColumn1214.Hidden = True
        UltraGridColumn1215.Header.VisiblePosition = 13
        UltraGridColumn1215.Hidden = True
        UltraGridColumn1216.Header.VisiblePosition = 14
        UltraGridColumn1216.Hidden = True
        UltraGridColumn1217.Header.VisiblePosition = 15
        UltraGridColumn1217.Hidden = True
        UltraGridColumn1218.Header.VisiblePosition = 16
        UltraGridColumn1218.Hidden = True
        UltraGridColumn1219.Header.VisiblePosition = 17
        UltraGridColumn1219.Hidden = True
        UltraGridColumn1220.Header.VisiblePosition = 18
        UltraGridColumn1220.Hidden = True
        UltraGridColumn1221.Header.VisiblePosition = 19
        UltraGridColumn1221.Hidden = True
        UltraGridColumn1222.Header.VisiblePosition = 20
        UltraGridColumn1222.Hidden = True
        UltraGridColumn1223.Header.VisiblePosition = 21
        UltraGridColumn1223.Hidden = True
        UltraGridColumn1224.Header.VisiblePosition = 22
        UltraGridColumn1224.Hidden = True
        UltraGridColumn1225.Header.VisiblePosition = 23
        UltraGridColumn1225.Hidden = True
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn1226.CellAppearance = Appearance47
        UltraGridColumn1226.Header.Caption = "Saldo (4)"
        UltraGridColumn1226.Header.VisiblePosition = 24
        UltraGridColumn1226.MaskInput = "{double:-9.2}"
        UltraGridColumn1227.Header.VisiblePosition = 25
        UltraGridColumn1227.Hidden = True
        UltraGridColumn1228.Header.VisiblePosition = 26
        UltraGridColumn1228.Hidden = True
        UltraGridColumn1229.Header.VisiblePosition = 27
        UltraGridColumn1229.Hidden = True
        UltraGridColumn1230.Header.VisiblePosition = 28
        UltraGridColumn1230.Hidden = True
        UltraGridColumn1231.Header.VisiblePosition = 29
        UltraGridColumn1231.Hidden = True
        UltraGridColumn1232.Header.VisiblePosition = 30
        UltraGridColumn1232.Hidden = True
        UltraGridColumn1233.Header.VisiblePosition = 31
        UltraGridColumn1233.Hidden = True
        UltraGridColumn1234.Header.VisiblePosition = 32
        UltraGridColumn1234.Hidden = True
        UltraGridColumn1235.Header.VisiblePosition = 33
        UltraGridColumn1235.Hidden = True
        UltraGridColumn1236.Header.Caption = "Indicador (5)"
        UltraGridColumn1236.Header.VisiblePosition = 34
        UltraGridColumn1237.Header.VisiblePosition = 35
        UltraGridColumn1237.Hidden = True
        UltraGridColumn1238.Header.VisiblePosition = 36
        UltraGridColumn1238.Hidden = True
        UltraGridColumn1239.Header.VisiblePosition = 37
        UltraGridColumn1239.Hidden = True
        UltraGridColumn1240.Header.VisiblePosition = 38
        UltraGridColumn1240.Hidden = True
        UltraGridColumn1241.Header.VisiblePosition = 39
        UltraGridColumn1241.Hidden = True
        UltraGridColumn1242.Header.VisiblePosition = 40
        UltraGridColumn1242.Hidden = True
        UltraGridColumn1243.Header.VisiblePosition = 41
        UltraGridColumn1243.Hidden = True
        UltraGridColumn1244.Header.VisiblePosition = 42
        UltraGridColumn1244.Hidden = True
        UltraGridColumn1245.Header.VisiblePosition = 43
        UltraGridColumn1245.Hidden = True
        UltraGridColumn1246.Header.VisiblePosition = 44
        UltraGridColumn1246.Hidden = True
        UltraGridColumn1247.Header.VisiblePosition = 45
        UltraGridColumn1247.Hidden = True
        UltraGridColumn1248.Header.VisiblePosition = 46
        UltraGridColumn1248.Hidden = True
        UltraGridColumn1249.Header.VisiblePosition = 47
        UltraGridColumn1249.Hidden = True
        UltraGridColumn1250.Header.VisiblePosition = 48
        UltraGridColumn1250.Hidden = True
        UltraGridColumn1251.Header.VisiblePosition = 49
        UltraGridColumn1251.Hidden = True
        UltraGridColumn1252.Header.VisiblePosition = 50
        UltraGridColumn1252.Hidden = True
        UltraGridColumn1253.Header.VisiblePosition = 51
        UltraGridColumn1253.Hidden = True
        UltraGridColumn1254.Header.VisiblePosition = 52
        UltraGridColumn1254.Hidden = True
        UltraGridColumn1255.Header.VisiblePosition = 53
        UltraGridColumn1255.Hidden = True
        UltraGridBand18.Columns.AddRange(New Object() {UltraGridColumn1202, UltraGridColumn1203, UltraGridColumn1204, UltraGridColumn1205, UltraGridColumn1206, UltraGridColumn1207, UltraGridColumn1208, UltraGridColumn1209, UltraGridColumn1210, UltraGridColumn1211, UltraGridColumn1212, UltraGridColumn1213, UltraGridColumn1214, UltraGridColumn1215, UltraGridColumn1216, UltraGridColumn1217, UltraGridColumn1218, UltraGridColumn1219, UltraGridColumn1220, UltraGridColumn1221, UltraGridColumn1222, UltraGridColumn1223, UltraGridColumn1224, UltraGridColumn1225, UltraGridColumn1226, UltraGridColumn1227, UltraGridColumn1228, UltraGridColumn1229, UltraGridColumn1230, UltraGridColumn1231, UltraGridColumn1232, UltraGridColumn1233, UltraGridColumn1234, UltraGridColumn1235, UltraGridColumn1236, UltraGridColumn1237, UltraGridColumn1238, UltraGridColumn1239, UltraGridColumn1240, UltraGridColumn1241, UltraGridColumn1242, UltraGridColumn1243, UltraGridColumn1244, UltraGridColumn1245, UltraGridColumn1246, UltraGridColumn1247, UltraGridColumn1248, UltraGridColumn1249, UltraGridColumn1250, UltraGridColumn1251, UltraGridColumn1252, UltraGridColumn1253, UltraGridColumn1254, UltraGridColumn1255})
        Me.griInvEFEMD.DisplayLayout.BandsSerializer.Add(UltraGridBand18)
        Me.griInvEFEMD.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvEFEMD.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvEFEMD.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvEFEMD.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvEFEMD.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvEFEMD.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvEFEMD.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvEFEMD.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvEFEMD.DisplayLayout.Override.CellPadding = 0
        Me.griInvEFEMD.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvEFEMD.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvEFEMD.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvEFEMD.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvEFEMD.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvEFEMD.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvEFEMD.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvEFEMD.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvEFEMD.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvEFEMD.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvEFEMD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvEFEMD.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvEFEMD.Location = New System.Drawing.Point(0, 0)
        Me.griInvEFEMD.Name = "griInvEFEMD"
        Me.griInvEFEMD.Size = New System.Drawing.Size(1256, 251)
        Me.griInvEFEMD.TabIndex = 0
        Me.griInvEFEMD.Text = "3.18 Estado de Flujo de Efectivo"
        '
        'UltraTabPageControl39
        '
        Me.UltraTabPageControl39.Controls.Add(Me.griInvECPN)
        Me.UltraTabPageControl39.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl39.Name = "UltraTabPageControl39"
        Me.UltraTabPageControl39.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvECPN
        '
        Me.griInvECPN.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1256.Header.VisiblePosition = 0
        UltraGridColumn1256.Hidden = True
        UltraGridColumn1257.Header.VisiblePosition = 1
        UltraGridColumn1257.Hidden = True
        UltraGridColumn1258.Header.VisiblePosition = 2
        UltraGridColumn1258.Hidden = True
        UltraGridColumn1259.Header.Caption = "Periodo (1)"
        UltraGridColumn1259.Header.VisiblePosition = 3
        UltraGridColumn1260.Header.Caption = "Cod. Catalago (2)"
        UltraGridColumn1260.Header.VisiblePosition = 4
        UltraGridColumn1261.Header.VisiblePosition = 5
        UltraGridColumn1261.Hidden = True
        UltraGridColumn1262.Header.VisiblePosition = 6
        UltraGridColumn1262.Hidden = True
        UltraGridColumn1263.Header.Caption = "Cod. Rubro (3)"
        UltraGridColumn1263.Header.VisiblePosition = 7
        UltraGridColumn1264.Header.VisiblePosition = 8
        UltraGridColumn1264.Hidden = True
        UltraGridColumn1265.Header.VisiblePosition = 9
        UltraGridColumn1265.Hidden = True
        UltraGridColumn1266.Header.VisiblePosition = 10
        UltraGridColumn1266.Hidden = True
        UltraGridColumn1267.Header.VisiblePosition = 11
        UltraGridColumn1267.Hidden = True
        UltraGridColumn1268.Header.VisiblePosition = 12
        UltraGridColumn1268.Hidden = True
        UltraGridColumn1269.Header.VisiblePosition = 13
        UltraGridColumn1269.Hidden = True
        UltraGridColumn1270.Header.VisiblePosition = 14
        UltraGridColumn1270.Hidden = True
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn1271.CellAppearance = Appearance48
        UltraGridColumn1271.Header.Caption = "Capital (4)"
        UltraGridColumn1271.Header.VisiblePosition = 15
        UltraGridColumn1271.MaskInput = "{double:-9.2}"
        Appearance49.TextHAlignAsString = "Right"
        UltraGridColumn1272.CellAppearance = Appearance49
        UltraGridColumn1272.Header.Caption = "Accion Inv. (5)"
        UltraGridColumn1272.Header.VisiblePosition = 16
        UltraGridColumn1272.MaskInput = "{double:-9.2}"
        Appearance50.TextHAlignAsString = "Right"
        UltraGridColumn1273.CellAppearance = Appearance50
        UltraGridColumn1273.Header.Caption = "Cap. Adicional (6)"
        UltraGridColumn1273.Header.VisiblePosition = 17
        UltraGridColumn1273.MaskInput = "{double:-9.2}"
        Appearance51.TextHAlignAsString = "Right"
        UltraGridColumn1274.CellAppearance = Appearance51
        UltraGridColumn1274.Header.Caption = "Result. No Realizados (7)"
        UltraGridColumn1274.Header.VisiblePosition = 18
        UltraGridColumn1274.MaskInput = "{double:-9.2}"
        Appearance52.TextHAlignAsString = "Right"
        UltraGridColumn1275.CellAppearance = Appearance52
        UltraGridColumn1275.Header.Caption = "Resev. Legal (8)"
        UltraGridColumn1275.Header.VisiblePosition = 19
        UltraGridColumn1275.MaskInput = "{double:-9.2}"
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn1276.CellAppearance = Appearance53
        UltraGridColumn1276.Header.Caption = "Otras Reserva (9)"
        UltraGridColumn1276.Header.VisiblePosition = 20
        UltraGridColumn1276.MaskInput = "{double:-9.2}"
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn1277.CellAppearance = Appearance54
        UltraGridColumn1277.Header.Caption = "Result. Acumulado (10)"
        UltraGridColumn1277.Header.VisiblePosition = 21
        UltraGridColumn1277.MaskInput = "{double:-9.2}"
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn1278.CellAppearance = Appearance55
        UltraGridColumn1278.Header.Caption = "Dif. Conversion (11)"
        UltraGridColumn1278.Header.VisiblePosition = 22
        UltraGridColumn1278.MaskInput = "{double:-9.2}"
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn1279.CellAppearance = Appearance56
        UltraGridColumn1279.Header.Caption = "Ajustes Patri. (12)"
        UltraGridColumn1279.Header.VisiblePosition = 23
        UltraGridColumn1279.MaskInput = "{double:-9.2}"
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn1280.CellAppearance = Appearance57
        UltraGridColumn1280.Header.Caption = "Result. Neto (13)"
        UltraGridColumn1280.Header.VisiblePosition = 24
        UltraGridColumn1280.MaskInput = "{double:-9.2}"
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn1281.CellAppearance = Appearance58
        UltraGridColumn1281.Header.Caption = "Excedente Eva. (14)"
        UltraGridColumn1281.Header.VisiblePosition = 25
        UltraGridColumn1281.MaskInput = "{double:-9.2}"
        UltraGridColumn1282.Header.VisiblePosition = 26
        UltraGridColumn1282.Hidden = True
        UltraGridColumn1283.Header.VisiblePosition = 27
        UltraGridColumn1283.Hidden = True
        UltraGridColumn1284.Header.VisiblePosition = 28
        UltraGridColumn1284.Hidden = True
        UltraGridColumn1285.Header.VisiblePosition = 29
        UltraGridColumn1285.Hidden = True
        UltraGridColumn1286.Header.VisiblePosition = 30
        UltraGridColumn1286.Hidden = True
        UltraGridColumn1287.Header.VisiblePosition = 31
        UltraGridColumn1287.Hidden = True
        UltraGridColumn1288.Header.VisiblePosition = 32
        UltraGridColumn1288.Hidden = True
        UltraGridColumn1289.Header.VisiblePosition = 33
        UltraGridColumn1289.Hidden = True
        UltraGridColumn1290.Header.Caption = "Indicador (16)"
        UltraGridColumn1290.Header.VisiblePosition = 49
        UltraGridColumn1291.Header.VisiblePosition = 34
        UltraGridColumn1291.Hidden = True
        UltraGridColumn1292.Header.VisiblePosition = 35
        UltraGridColumn1292.Hidden = True
        UltraGridColumn1293.Header.VisiblePosition = 36
        UltraGridColumn1293.Hidden = True
        UltraGridColumn1294.Header.VisiblePosition = 37
        UltraGridColumn1294.Hidden = True
        UltraGridColumn1295.Header.VisiblePosition = 38
        UltraGridColumn1295.Hidden = True
        UltraGridColumn1296.Header.VisiblePosition = 39
        UltraGridColumn1296.Hidden = True
        UltraGridColumn1297.Header.VisiblePosition = 40
        UltraGridColumn1297.Hidden = True
        UltraGridColumn1298.Header.VisiblePosition = 41
        UltraGridColumn1298.Hidden = True
        UltraGridColumn1299.Header.VisiblePosition = 42
        UltraGridColumn1299.Hidden = True
        UltraGridColumn1300.Header.VisiblePosition = 43
        UltraGridColumn1300.Hidden = True
        UltraGridColumn1301.Header.VisiblePosition = 44
        UltraGridColumn1301.Hidden = True
        UltraGridColumn1302.Header.VisiblePosition = 45
        UltraGridColumn1302.Hidden = True
        UltraGridColumn1303.Header.VisiblePosition = 46
        UltraGridColumn1303.Hidden = True
        UltraGridColumn1304.Header.VisiblePosition = 47
        UltraGridColumn1304.Hidden = True
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn1305.CellAppearance = Appearance59
        UltraGridColumn1305.Header.Caption = "Result. Ejercicio (15)"
        UltraGridColumn1305.Header.VisiblePosition = 48
        UltraGridColumn1305.MaskInput = "{double:-9.2}"
        UltraGridColumn1306.Header.VisiblePosition = 50
        UltraGridColumn1306.Hidden = True
        UltraGridColumn1307.Header.VisiblePosition = 51
        UltraGridColumn1307.Hidden = True
        UltraGridColumn1308.Header.VisiblePosition = 52
        UltraGridColumn1308.Hidden = True
        UltraGridColumn1309.Header.VisiblePosition = 53
        UltraGridColumn1309.Hidden = True
        UltraGridBand19.Columns.AddRange(New Object() {UltraGridColumn1256, UltraGridColumn1257, UltraGridColumn1258, UltraGridColumn1259, UltraGridColumn1260, UltraGridColumn1261, UltraGridColumn1262, UltraGridColumn1263, UltraGridColumn1264, UltraGridColumn1265, UltraGridColumn1266, UltraGridColumn1267, UltraGridColumn1268, UltraGridColumn1269, UltraGridColumn1270, UltraGridColumn1271, UltraGridColumn1272, UltraGridColumn1273, UltraGridColumn1274, UltraGridColumn1275, UltraGridColumn1276, UltraGridColumn1277, UltraGridColumn1278, UltraGridColumn1279, UltraGridColumn1280, UltraGridColumn1281, UltraGridColumn1282, UltraGridColumn1283, UltraGridColumn1284, UltraGridColumn1285, UltraGridColumn1286, UltraGridColumn1287, UltraGridColumn1288, UltraGridColumn1289, UltraGridColumn1290, UltraGridColumn1291, UltraGridColumn1292, UltraGridColumn1293, UltraGridColumn1294, UltraGridColumn1295, UltraGridColumn1296, UltraGridColumn1297, UltraGridColumn1298, UltraGridColumn1299, UltraGridColumn1300, UltraGridColumn1301, UltraGridColumn1302, UltraGridColumn1303, UltraGridColumn1304, UltraGridColumn1305, UltraGridColumn1306, UltraGridColumn1307, UltraGridColumn1308, UltraGridColumn1309})
        Me.griInvECPN.DisplayLayout.BandsSerializer.Add(UltraGridBand19)
        Me.griInvECPN.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvECPN.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvECPN.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvECPN.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvECPN.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvECPN.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvECPN.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvECPN.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvECPN.DisplayLayout.Override.CellPadding = 0
        Me.griInvECPN.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInvECPN.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvECPN.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvECPN.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvECPN.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvECPN.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvECPN.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvECPN.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvECPN.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvECPN.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvECPN.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvECPN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvECPN.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvECPN.Location = New System.Drawing.Point(0, 0)
        Me.griInvECPN.Name = "griInvECPN"
        Me.griInvECPN.Size = New System.Drawing.Size(1256, 251)
        Me.griInvECPN.TabIndex = 0
        Me.griInvECPN.Text = "3.19 Estado de Cambio Patrimonio Neto"
        '
        'UltraTabPageControl40
        '
        Me.UltraTabPageControl40.Controls.Add(Me.griInvER)
        Me.UltraTabPageControl40.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl40.Name = "UltraTabPageControl40"
        Me.UltraTabPageControl40.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvER
        '
        Me.griInvER.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1310.Header.VisiblePosition = 0
        UltraGridColumn1310.Hidden = True
        UltraGridColumn1311.Header.VisiblePosition = 1
        UltraGridColumn1311.Hidden = True
        UltraGridColumn1312.Header.VisiblePosition = 2
        UltraGridColumn1312.Hidden = True
        UltraGridColumn1313.Header.Caption = "Periodo (1)"
        UltraGridColumn1313.Header.VisiblePosition = 3
        UltraGridColumn1314.Header.Caption = "Codigo Catalogo (2)"
        UltraGridColumn1314.Header.VisiblePosition = 4
        UltraGridColumn1315.Header.VisiblePosition = 5
        UltraGridColumn1315.Hidden = True
        UltraGridColumn1316.Header.VisiblePosition = 6
        UltraGridColumn1316.Hidden = True
        UltraGridColumn1317.Header.Caption = "Codigo Rubro (3)"
        UltraGridColumn1317.Header.VisiblePosition = 7
        UltraGridColumn1318.Header.VisiblePosition = 8
        UltraGridColumn1318.Hidden = True
        UltraGridColumn1319.Header.VisiblePosition = 9
        UltraGridColumn1319.Hidden = True
        UltraGridColumn1320.Header.VisiblePosition = 10
        UltraGridColumn1320.Hidden = True
        UltraGridColumn1321.Header.VisiblePosition = 11
        UltraGridColumn1321.Hidden = True
        UltraGridColumn1322.Header.VisiblePosition = 12
        UltraGridColumn1322.Hidden = True
        UltraGridColumn1323.Header.VisiblePosition = 13
        UltraGridColumn1323.Hidden = True
        UltraGridColumn1324.Header.VisiblePosition = 14
        UltraGridColumn1324.Hidden = True
        UltraGridColumn1325.Header.VisiblePosition = 15
        UltraGridColumn1325.Hidden = True
        UltraGridColumn1326.Header.VisiblePosition = 16
        UltraGridColumn1326.Hidden = True
        UltraGridColumn1327.Header.VisiblePosition = 17
        UltraGridColumn1327.Hidden = True
        UltraGridColumn1328.Header.VisiblePosition = 18
        UltraGridColumn1328.Hidden = True
        UltraGridColumn1329.Header.VisiblePosition = 19
        UltraGridColumn1329.Hidden = True
        UltraGridColumn1330.Header.VisiblePosition = 20
        UltraGridColumn1330.Hidden = True
        UltraGridColumn1331.Header.VisiblePosition = 21
        UltraGridColumn1331.Hidden = True
        UltraGridColumn1332.Header.VisiblePosition = 22
        UltraGridColumn1332.Hidden = True
        UltraGridColumn1333.Header.VisiblePosition = 23
        UltraGridColumn1333.Hidden = True
        Appearance60.TextHAlignAsString = "Center"
        UltraGridColumn1334.CellAppearance = Appearance60
        UltraGridColumn1334.Header.Caption = "Saldo (4)"
        UltraGridColumn1334.Header.VisiblePosition = 24
        UltraGridColumn1334.MaskInput = "{double:-9.2}"
        UltraGridColumn1335.Header.VisiblePosition = 25
        UltraGridColumn1335.Hidden = True
        UltraGridColumn1336.Header.VisiblePosition = 26
        UltraGridColumn1336.Hidden = True
        UltraGridColumn1337.Header.VisiblePosition = 27
        UltraGridColumn1337.Hidden = True
        UltraGridColumn1338.Header.VisiblePosition = 28
        UltraGridColumn1338.Hidden = True
        UltraGridColumn1339.Header.VisiblePosition = 29
        UltraGridColumn1339.Hidden = True
        UltraGridColumn1340.Header.VisiblePosition = 30
        UltraGridColumn1340.Hidden = True
        UltraGridColumn1341.Header.VisiblePosition = 31
        UltraGridColumn1341.Hidden = True
        UltraGridColumn1342.Header.VisiblePosition = 32
        UltraGridColumn1342.Hidden = True
        UltraGridColumn1343.Header.VisiblePosition = 33
        UltraGridColumn1343.Hidden = True
        UltraGridColumn1344.Header.Caption = "Indicador (5)"
        UltraGridColumn1344.Header.VisiblePosition = 34
        UltraGridColumn1345.Header.VisiblePosition = 35
        UltraGridColumn1345.Hidden = True
        UltraGridColumn1346.Header.VisiblePosition = 36
        UltraGridColumn1346.Hidden = True
        UltraGridColumn1347.Header.VisiblePosition = 37
        UltraGridColumn1347.Hidden = True
        UltraGridColumn1348.Header.VisiblePosition = 38
        UltraGridColumn1348.Hidden = True
        UltraGridColumn1349.Header.VisiblePosition = 39
        UltraGridColumn1349.Hidden = True
        UltraGridColumn1350.Header.VisiblePosition = 40
        UltraGridColumn1350.Hidden = True
        UltraGridColumn1351.Header.VisiblePosition = 41
        UltraGridColumn1351.Hidden = True
        UltraGridColumn1352.Header.VisiblePosition = 42
        UltraGridColumn1352.Hidden = True
        UltraGridColumn1353.Header.VisiblePosition = 43
        UltraGridColumn1353.Hidden = True
        UltraGridColumn1354.Header.VisiblePosition = 44
        UltraGridColumn1354.Hidden = True
        UltraGridColumn1355.Header.VisiblePosition = 45
        UltraGridColumn1355.Hidden = True
        UltraGridColumn1356.Header.VisiblePosition = 46
        UltraGridColumn1356.Hidden = True
        UltraGridColumn1357.Header.VisiblePosition = 47
        UltraGridColumn1357.Hidden = True
        UltraGridColumn1358.Header.VisiblePosition = 48
        UltraGridColumn1358.Hidden = True
        UltraGridColumn1359.Header.VisiblePosition = 49
        UltraGridColumn1359.Hidden = True
        UltraGridColumn1360.Header.VisiblePosition = 50
        UltraGridColumn1360.Hidden = True
        UltraGridColumn1361.Header.VisiblePosition = 51
        UltraGridColumn1361.Hidden = True
        UltraGridColumn1362.Header.VisiblePosition = 52
        UltraGridColumn1362.Hidden = True
        UltraGridColumn1363.Header.VisiblePosition = 53
        UltraGridColumn1363.Hidden = True
        UltraGridBand20.Columns.AddRange(New Object() {UltraGridColumn1310, UltraGridColumn1311, UltraGridColumn1312, UltraGridColumn1313, UltraGridColumn1314, UltraGridColumn1315, UltraGridColumn1316, UltraGridColumn1317, UltraGridColumn1318, UltraGridColumn1319, UltraGridColumn1320, UltraGridColumn1321, UltraGridColumn1322, UltraGridColumn1323, UltraGridColumn1324, UltraGridColumn1325, UltraGridColumn1326, UltraGridColumn1327, UltraGridColumn1328, UltraGridColumn1329, UltraGridColumn1330, UltraGridColumn1331, UltraGridColumn1332, UltraGridColumn1333, UltraGridColumn1334, UltraGridColumn1335, UltraGridColumn1336, UltraGridColumn1337, UltraGridColumn1338, UltraGridColumn1339, UltraGridColumn1340, UltraGridColumn1341, UltraGridColumn1342, UltraGridColumn1343, UltraGridColumn1344, UltraGridColumn1345, UltraGridColumn1346, UltraGridColumn1347, UltraGridColumn1348, UltraGridColumn1349, UltraGridColumn1350, UltraGridColumn1351, UltraGridColumn1352, UltraGridColumn1353, UltraGridColumn1354, UltraGridColumn1355, UltraGridColumn1356, UltraGridColumn1357, UltraGridColumn1358, UltraGridColumn1359, UltraGridColumn1360, UltraGridColumn1361, UltraGridColumn1362, UltraGridColumn1363})
        Me.griInvER.DisplayLayout.BandsSerializer.Add(UltraGridBand20)
        Me.griInvER.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvER.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvER.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvER.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvER.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvER.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvER.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvER.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvER.DisplayLayout.Override.CellPadding = 0
        Me.griInvER.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvER.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvER.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvER.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvER.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvER.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvER.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvER.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvER.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvER.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvER.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvER.Location = New System.Drawing.Point(0, 0)
        Me.griInvER.Name = "griInvER"
        Me.griInvER.Size = New System.Drawing.Size(1256, 251)
        Me.griInvER.TabIndex = 0
        Me.griInvER.Text = "3.20 Estado de Resultados"
        '
        'UltraTabPageControl41
        '
        Me.UltraTabPageControl41.Controls.Add(Me.pnlNavegador)
        Me.UltraTabPageControl41.Controls.Add(Me.agrNotas)
        Me.UltraTabPageControl41.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl41.Name = "UltraTabPageControl41"
        Me.UltraTabPageControl41.Size = New System.Drawing.Size(1256, 251)
        '
        'pnlNavegador
        '
        '
        'pnlNavegador.ClientArea
        '
        Me.pnlNavegador.ClientArea.Controls.Add(Me.webNotas)
        Me.pnlNavegador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavegador.Location = New System.Drawing.Point(0, 55)
        Me.pnlNavegador.Name = "pnlNavegador"
        Me.pnlNavegador.Size = New System.Drawing.Size(1256, 196)
        Me.pnlNavegador.TabIndex = 2
        '
        'webNotas
        '
        Me.webNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webNotas.Location = New System.Drawing.Point(0, 0)
        Me.webNotas.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webNotas.Name = "webNotas"
        Me.webNotas.Size = New System.Drawing.Size(1256, 196)
        Me.webNotas.TabIndex = 0
        '
        'agrNotas
        '
        Me.agrNotas.Controls.Add(Me.txtNombreArchivo)
        Me.agrNotas.Controls.Add(Me.btnAbrir)
        Me.agrNotas.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrNotas.Location = New System.Drawing.Point(0, 0)
        Me.agrNotas.Name = "agrNotas"
        Me.agrNotas.Size = New System.Drawing.Size(1256, 55)
        Me.agrNotas.TabIndex = 1
        Me.agrNotas.Text = "Datos de Archivo:"
        Me.agrNotas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'txtNombreArchivo
        '
        Me.txtNombreArchivo.Location = New System.Drawing.Point(91, 26)
        Me.txtNombreArchivo.Name = "txtNombreArchivo"
        Me.txtNombreArchivo.Size = New System.Drawing.Size(347, 19)
        Me.txtNombreArchivo.TabIndex = 1
        '
        'btnAbrir
        '
        Appearance61.BorderColor = System.Drawing.Color.Transparent
        Me.btnAbrir.Appearance = Appearance61
        Me.btnAbrir.Location = New System.Drawing.Point(10, 22)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrir.TabIndex = 0
        Me.btnAbrir.Text = "UltraButton1"
        '
        'UltraTabPageControl42
        '
        Me.UltraTabPageControl42.Controls.Add(Me.griInvERI)
        Me.UltraTabPageControl42.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl42.Name = "UltraTabPageControl42"
        Me.UltraTabPageControl42.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvERI
        '
        Me.griInvERI.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1364.Header.VisiblePosition = 0
        UltraGridColumn1364.Hidden = True
        UltraGridColumn1365.Header.VisiblePosition = 1
        UltraGridColumn1365.Hidden = True
        UltraGridColumn1366.Header.VisiblePosition = 2
        UltraGridColumn1366.Hidden = True
        UltraGridColumn1367.Header.Caption = "Periodo (1)"
        UltraGridColumn1367.Header.VisiblePosition = 3
        UltraGridColumn1368.Header.Caption = "Codigo Catalago (2)"
        UltraGridColumn1368.Header.VisiblePosition = 4
        UltraGridColumn1369.Header.VisiblePosition = 5
        UltraGridColumn1369.Hidden = True
        UltraGridColumn1370.Header.VisiblePosition = 6
        UltraGridColumn1370.Hidden = True
        UltraGridColumn1371.Header.Caption = "Codigo Rubro (3)"
        UltraGridColumn1371.Header.VisiblePosition = 7
        UltraGridColumn1372.Header.VisiblePosition = 8
        UltraGridColumn1372.Hidden = True
        UltraGridColumn1373.Header.VisiblePosition = 9
        UltraGridColumn1373.Hidden = True
        UltraGridColumn1374.Header.VisiblePosition = 10
        UltraGridColumn1374.Hidden = True
        UltraGridColumn1375.Header.VisiblePosition = 11
        UltraGridColumn1375.Hidden = True
        UltraGridColumn1376.Header.VisiblePosition = 12
        UltraGridColumn1376.Hidden = True
        UltraGridColumn1377.Header.VisiblePosition = 13
        UltraGridColumn1377.Hidden = True
        UltraGridColumn1378.Header.VisiblePosition = 14
        UltraGridColumn1378.Hidden = True
        UltraGridColumn1379.Header.VisiblePosition = 15
        UltraGridColumn1379.Hidden = True
        UltraGridColumn1380.Header.VisiblePosition = 16
        UltraGridColumn1380.Hidden = True
        UltraGridColumn1381.Header.VisiblePosition = 17
        UltraGridColumn1381.Hidden = True
        UltraGridColumn1382.Header.VisiblePosition = 18
        UltraGridColumn1382.Hidden = True
        UltraGridColumn1383.Header.VisiblePosition = 19
        UltraGridColumn1383.Hidden = True
        UltraGridColumn1384.Header.VisiblePosition = 20
        UltraGridColumn1384.Hidden = True
        UltraGridColumn1385.Header.VisiblePosition = 21
        UltraGridColumn1385.Hidden = True
        UltraGridColumn1386.Header.VisiblePosition = 22
        UltraGridColumn1386.Hidden = True
        UltraGridColumn1387.Header.VisiblePosition = 23
        UltraGridColumn1387.Hidden = True
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn1388.CellAppearance = Appearance62
        UltraGridColumn1388.Header.Caption = "Saldo (4)"
        UltraGridColumn1388.Header.VisiblePosition = 24
        UltraGridColumn1388.MaskInput = "{double:-9.2}"
        UltraGridColumn1389.Header.VisiblePosition = 25
        UltraGridColumn1389.Hidden = True
        UltraGridColumn1390.Header.VisiblePosition = 26
        UltraGridColumn1390.Hidden = True
        UltraGridColumn1391.Header.VisiblePosition = 27
        UltraGridColumn1391.Hidden = True
        UltraGridColumn1392.Header.VisiblePosition = 28
        UltraGridColumn1392.Hidden = True
        UltraGridColumn1393.Header.VisiblePosition = 29
        UltraGridColumn1393.Hidden = True
        UltraGridColumn1394.Header.VisiblePosition = 30
        UltraGridColumn1394.Hidden = True
        UltraGridColumn1395.Header.VisiblePosition = 31
        UltraGridColumn1395.Hidden = True
        UltraGridColumn1396.Header.VisiblePosition = 32
        UltraGridColumn1396.Hidden = True
        UltraGridColumn1397.Header.VisiblePosition = 33
        UltraGridColumn1397.Hidden = True
        UltraGridColumn1398.Header.Caption = "Indicador (5)"
        UltraGridColumn1398.Header.VisiblePosition = 34
        UltraGridColumn1399.Header.VisiblePosition = 35
        UltraGridColumn1399.Hidden = True
        UltraGridColumn1400.Header.VisiblePosition = 36
        UltraGridColumn1400.Hidden = True
        UltraGridColumn1401.Header.VisiblePosition = 37
        UltraGridColumn1401.Hidden = True
        UltraGridColumn1402.Header.VisiblePosition = 38
        UltraGridColumn1402.Hidden = True
        UltraGridColumn1403.Header.VisiblePosition = 39
        UltraGridColumn1403.Hidden = True
        UltraGridColumn1404.Header.VisiblePosition = 40
        UltraGridColumn1404.Hidden = True
        UltraGridColumn1405.Header.VisiblePosition = 41
        UltraGridColumn1405.Hidden = True
        UltraGridColumn1406.Header.VisiblePosition = 42
        UltraGridColumn1406.Hidden = True
        UltraGridColumn1407.Header.VisiblePosition = 43
        UltraGridColumn1407.Hidden = True
        UltraGridColumn1408.Header.VisiblePosition = 44
        UltraGridColumn1408.Hidden = True
        UltraGridColumn1409.Header.VisiblePosition = 45
        UltraGridColumn1409.Hidden = True
        UltraGridColumn1410.Header.VisiblePosition = 46
        UltraGridColumn1410.Hidden = True
        UltraGridColumn1411.Header.VisiblePosition = 47
        UltraGridColumn1411.Hidden = True
        UltraGridColumn1412.Header.VisiblePosition = 48
        UltraGridColumn1412.Hidden = True
        UltraGridColumn1413.Header.VisiblePosition = 49
        UltraGridColumn1413.Hidden = True
        UltraGridColumn1414.Header.VisiblePosition = 50
        UltraGridColumn1414.Hidden = True
        UltraGridColumn1415.Header.VisiblePosition = 51
        UltraGridColumn1415.Hidden = True
        UltraGridColumn1416.Header.VisiblePosition = 52
        UltraGridColumn1416.Hidden = True
        UltraGridColumn1417.Header.VisiblePosition = 53
        UltraGridColumn1417.Hidden = True
        UltraGridBand21.Columns.AddRange(New Object() {UltraGridColumn1364, UltraGridColumn1365, UltraGridColumn1366, UltraGridColumn1367, UltraGridColumn1368, UltraGridColumn1369, UltraGridColumn1370, UltraGridColumn1371, UltraGridColumn1372, UltraGridColumn1373, UltraGridColumn1374, UltraGridColumn1375, UltraGridColumn1376, UltraGridColumn1377, UltraGridColumn1378, UltraGridColumn1379, UltraGridColumn1380, UltraGridColumn1381, UltraGridColumn1382, UltraGridColumn1383, UltraGridColumn1384, UltraGridColumn1385, UltraGridColumn1386, UltraGridColumn1387, UltraGridColumn1388, UltraGridColumn1389, UltraGridColumn1390, UltraGridColumn1391, UltraGridColumn1392, UltraGridColumn1393, UltraGridColumn1394, UltraGridColumn1395, UltraGridColumn1396, UltraGridColumn1397, UltraGridColumn1398, UltraGridColumn1399, UltraGridColumn1400, UltraGridColumn1401, UltraGridColumn1402, UltraGridColumn1403, UltraGridColumn1404, UltraGridColumn1405, UltraGridColumn1406, UltraGridColumn1407, UltraGridColumn1408, UltraGridColumn1409, UltraGridColumn1410, UltraGridColumn1411, UltraGridColumn1412, UltraGridColumn1413, UltraGridColumn1414, UltraGridColumn1415, UltraGridColumn1416, UltraGridColumn1417})
        Me.griInvERI.DisplayLayout.BandsSerializer.Add(UltraGridBand21)
        Me.griInvERI.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvERI.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvERI.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvERI.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvERI.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvERI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvERI.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvERI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvERI.DisplayLayout.Override.CellPadding = 0
        Me.griInvERI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInvERI.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvERI.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvERI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvERI.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvERI.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvERI.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvERI.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvERI.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvERI.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvERI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvERI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvERI.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvERI.Location = New System.Drawing.Point(0, 0)
        Me.griInvERI.Name = "griInvERI"
        Me.griInvERI.Size = New System.Drawing.Size(1256, 251)
        Me.griInvERI.TabIndex = 0
        Me.griInvERI.Text = "3.24 Estado de Resultados Integral"
        '
        'UltraTabPageControl43
        '
        Me.UltraTabPageControl43.Controls.Add(Me.griInvEFEMI)
        Me.UltraTabPageControl43.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl43.Name = "UltraTabPageControl43"
        Me.UltraTabPageControl43.Size = New System.Drawing.Size(1256, 251)
        '
        'griInvEFEMI
        '
        Me.griInvEFEMI.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1418.Header.VisiblePosition = 0
        UltraGridColumn1418.Hidden = True
        UltraGridColumn1419.Header.VisiblePosition = 1
        UltraGridColumn1419.Hidden = True
        UltraGridColumn1420.Header.VisiblePosition = 2
        UltraGridColumn1420.Hidden = True
        UltraGridColumn1421.Header.Caption = "Periodo (1)"
        UltraGridColumn1421.Header.VisiblePosition = 3
        UltraGridColumn1422.Header.Caption = "Codigo Catalogo (2)"
        UltraGridColumn1422.Header.VisiblePosition = 4
        UltraGridColumn1423.Header.VisiblePosition = 5
        UltraGridColumn1423.Hidden = True
        UltraGridColumn1424.Header.VisiblePosition = 6
        UltraGridColumn1424.Hidden = True
        UltraGridColumn1425.Header.Caption = "Codigo Rubro (3)"
        UltraGridColumn1425.Header.VisiblePosition = 7
        UltraGridColumn1426.Header.VisiblePosition = 8
        UltraGridColumn1426.Hidden = True
        UltraGridColumn1427.Header.VisiblePosition = 9
        UltraGridColumn1427.Hidden = True
        UltraGridColumn1428.Header.VisiblePosition = 10
        UltraGridColumn1428.Hidden = True
        UltraGridColumn1429.Header.VisiblePosition = 11
        UltraGridColumn1429.Hidden = True
        UltraGridColumn1430.Header.VisiblePosition = 12
        UltraGridColumn1430.Hidden = True
        UltraGridColumn1431.Header.VisiblePosition = 13
        UltraGridColumn1431.Hidden = True
        UltraGridColumn1432.Header.VisiblePosition = 14
        UltraGridColumn1432.Hidden = True
        UltraGridColumn1433.Header.VisiblePosition = 15
        UltraGridColumn1433.Hidden = True
        UltraGridColumn1434.Header.VisiblePosition = 16
        UltraGridColumn1434.Hidden = True
        UltraGridColumn1435.Header.VisiblePosition = 17
        UltraGridColumn1435.Hidden = True
        UltraGridColumn1436.Header.VisiblePosition = 18
        UltraGridColumn1436.Hidden = True
        UltraGridColumn1437.Header.VisiblePosition = 19
        UltraGridColumn1437.Hidden = True
        UltraGridColumn1438.Header.VisiblePosition = 20
        UltraGridColumn1438.Hidden = True
        UltraGridColumn1439.Header.VisiblePosition = 21
        UltraGridColumn1439.Hidden = True
        UltraGridColumn1440.Header.VisiblePosition = 22
        UltraGridColumn1440.Hidden = True
        UltraGridColumn1441.Header.VisiblePosition = 23
        UltraGridColumn1441.Hidden = True
        Appearance63.TextHAlignAsString = "Right"
        UltraGridColumn1442.CellAppearance = Appearance63
        UltraGridColumn1442.Header.Caption = "Saldo (4)"
        UltraGridColumn1442.Header.VisiblePosition = 24
        UltraGridColumn1442.MaskInput = "{double:-9.2}"
        UltraGridColumn1443.Header.VisiblePosition = 25
        UltraGridColumn1443.Hidden = True
        UltraGridColumn1444.Header.VisiblePosition = 26
        UltraGridColumn1444.Hidden = True
        UltraGridColumn1445.Header.VisiblePosition = 27
        UltraGridColumn1445.Hidden = True
        UltraGridColumn1446.Header.VisiblePosition = 28
        UltraGridColumn1446.Hidden = True
        UltraGridColumn1447.Header.VisiblePosition = 29
        UltraGridColumn1447.Hidden = True
        UltraGridColumn1448.Header.VisiblePosition = 30
        UltraGridColumn1448.Hidden = True
        UltraGridColumn1449.Header.VisiblePosition = 31
        UltraGridColumn1449.Hidden = True
        UltraGridColumn1450.Header.VisiblePosition = 32
        UltraGridColumn1450.Hidden = True
        UltraGridColumn1451.Header.VisiblePosition = 33
        UltraGridColumn1451.Hidden = True
        UltraGridColumn1452.Header.Caption = "Indicador (5)"
        UltraGridColumn1452.Header.VisiblePosition = 34
        UltraGridColumn1453.Header.VisiblePosition = 35
        UltraGridColumn1453.Hidden = True
        UltraGridColumn1454.Header.VisiblePosition = 36
        UltraGridColumn1454.Hidden = True
        UltraGridColumn1455.Header.VisiblePosition = 37
        UltraGridColumn1455.Hidden = True
        UltraGridColumn1456.Header.VisiblePosition = 38
        UltraGridColumn1456.Hidden = True
        UltraGridColumn1457.Header.VisiblePosition = 39
        UltraGridColumn1457.Hidden = True
        UltraGridColumn1458.Header.VisiblePosition = 40
        UltraGridColumn1458.Hidden = True
        UltraGridColumn1459.Header.VisiblePosition = 41
        UltraGridColumn1459.Hidden = True
        UltraGridColumn1460.Header.VisiblePosition = 42
        UltraGridColumn1460.Hidden = True
        UltraGridColumn1461.Header.VisiblePosition = 43
        UltraGridColumn1461.Hidden = True
        UltraGridColumn1462.Header.VisiblePosition = 44
        UltraGridColumn1462.Hidden = True
        UltraGridColumn1463.Header.VisiblePosition = 45
        UltraGridColumn1463.Hidden = True
        UltraGridColumn1464.Header.VisiblePosition = 46
        UltraGridColumn1464.Hidden = True
        UltraGridColumn1465.Header.VisiblePosition = 47
        UltraGridColumn1465.Hidden = True
        UltraGridColumn1466.Header.VisiblePosition = 48
        UltraGridColumn1466.Hidden = True
        UltraGridColumn1467.Header.VisiblePosition = 49
        UltraGridColumn1467.Hidden = True
        UltraGridColumn1468.Header.VisiblePosition = 50
        UltraGridColumn1468.Hidden = True
        UltraGridColumn1469.Header.VisiblePosition = 51
        UltraGridColumn1469.Hidden = True
        UltraGridColumn1470.Header.VisiblePosition = 52
        UltraGridColumn1470.Hidden = True
        UltraGridColumn1471.Header.VisiblePosition = 53
        UltraGridColumn1471.Hidden = True
        UltraGridBand22.Columns.AddRange(New Object() {UltraGridColumn1418, UltraGridColumn1419, UltraGridColumn1420, UltraGridColumn1421, UltraGridColumn1422, UltraGridColumn1423, UltraGridColumn1424, UltraGridColumn1425, UltraGridColumn1426, UltraGridColumn1427, UltraGridColumn1428, UltraGridColumn1429, UltraGridColumn1430, UltraGridColumn1431, UltraGridColumn1432, UltraGridColumn1433, UltraGridColumn1434, UltraGridColumn1435, UltraGridColumn1436, UltraGridColumn1437, UltraGridColumn1438, UltraGridColumn1439, UltraGridColumn1440, UltraGridColumn1441, UltraGridColumn1442, UltraGridColumn1443, UltraGridColumn1444, UltraGridColumn1445, UltraGridColumn1446, UltraGridColumn1447, UltraGridColumn1448, UltraGridColumn1449, UltraGridColumn1450, UltraGridColumn1451, UltraGridColumn1452, UltraGridColumn1453, UltraGridColumn1454, UltraGridColumn1455, UltraGridColumn1456, UltraGridColumn1457, UltraGridColumn1458, UltraGridColumn1459, UltraGridColumn1460, UltraGridColumn1461, UltraGridColumn1462, UltraGridColumn1463, UltraGridColumn1464, UltraGridColumn1465, UltraGridColumn1466, UltraGridColumn1467, UltraGridColumn1468, UltraGridColumn1469, UltraGridColumn1470, UltraGridColumn1471})
        Me.griInvEFEMI.DisplayLayout.BandsSerializer.Add(UltraGridBand22)
        Me.griInvEFEMI.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvEFEMI.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griInvEFEMI.DisplayLayout.MaxColScrollRegions = 1
        Me.griInvEFEMI.DisplayLayout.MaxRowScrollRegions = 1
        Me.griInvEFEMI.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griInvEFEMI.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvEFEMI.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griInvEFEMI.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griInvEFEMI.DisplayLayout.Override.CellPadding = 0
        Me.griInvEFEMI.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griInvEFEMI.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griInvEFEMI.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griInvEFEMI.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griInvEFEMI.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griInvEFEMI.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griInvEFEMI.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griInvEFEMI.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griInvEFEMI.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griInvEFEMI.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griInvEFEMI.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griInvEFEMI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griInvEFEMI.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griInvEFEMI.Location = New System.Drawing.Point(0, 0)
        Me.griInvEFEMI.Name = "griInvEFEMI"
        Me.griInvEFEMI.Size = New System.Drawing.Size(1256, 251)
        Me.griInvEFEMI.TabIndex = 0
        Me.griInvEFEMI.Text = "3.25 Estado de Flujo Efectivo - Metodo Directo"
        '
        'UltraTabPageControl48
        '
        Me.UltraTabPageControl48.Controls.Add(Me.gridActivoFijo)
        Me.UltraTabPageControl48.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl48.Name = "UltraTabPageControl48"
        Me.UltraTabPageControl48.Size = New System.Drawing.Size(1256, 251)
        '
        'gridActivoFijo
        '
        Me.gridActivoFijo.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn217.Header.VisiblePosition = 0
        UltraGridColumn217.Hidden = True
        UltraGridColumn218.Header.VisiblePosition = 1
        UltraGridColumn218.Hidden = True
        UltraGridColumn219.Header.VisiblePosition = 2
        UltraGridColumn219.Hidden = True
        UltraGridColumn220.Header.Caption = "Periodo (1)"
        UltraGridColumn220.Header.VisiblePosition = 3
        UltraGridColumn221.Header.Caption = "Nro Correlativa (3)"
        UltraGridColumn221.Header.VisiblePosition = 5
        UltraGridColumn222.Header.Caption = "Fec. Adquisicion (23)"
        UltraGridColumn222.Header.VisiblePosition = 25
        UltraGridColumn222.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn223.Header.Caption = "Fec. Inicio Uso (24)"
        UltraGridColumn223.Header.VisiblePosition = 26
        UltraGridColumn223.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn224.Header.Caption = "Cod. Catalogo (4)"
        UltraGridColumn224.Header.VisiblePosition = 6
        UltraGridColumn225.Header.Caption = "Cod. Activo (5)"
        UltraGridColumn225.Header.VisiblePosition = 7
        UltraGridColumn226.Header.Caption = "Cod. Exist. (6)"
        UltraGridColumn226.Header.VisiblePosition = 8
        UltraGridColumn227.Header.Caption = "Tipo Activo (7)"
        UltraGridColumn227.Header.VisiblePosition = 9
        UltraGridColumn228.Header.Caption = "Cta Ctable (8)"
        UltraGridColumn228.Header.VisiblePosition = 10
        UltraGridColumn229.Header.Caption = "Estado (9)"
        UltraGridColumn229.Header.VisiblePosition = 11
        UltraGridColumn230.Header.Caption = "Descripcion (10)"
        UltraGridColumn230.Header.VisiblePosition = 12
        UltraGridColumn231.Header.Caption = "Marca (11)"
        UltraGridColumn231.Header.VisiblePosition = 13
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn232.CellAppearance = Appearance64
        UltraGridColumn232.Header.Caption = "Saldo (14)"
        UltraGridColumn232.Header.VisiblePosition = 16
        UltraGridColumn232.MaskInput = "{double:9.2}"
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn233.CellAppearance = Appearance65
        UltraGridColumn233.Header.Caption = "Importe Adquis. (15)"
        UltraGridColumn233.Header.VisiblePosition = 17
        UltraGridColumn233.MaskInput = "{double:9.2}"
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn234.CellAppearance = Appearance66
        UltraGridColumn234.Header.Caption = "Importe Mejora (16)"
        UltraGridColumn234.Header.VisiblePosition = 18
        UltraGridColumn234.MaskInput = "{double:9.2}"
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn235.CellAppearance = Appearance67
        UltraGridColumn235.Header.Caption = "Importe Retiro (17)"
        UltraGridColumn235.Header.VisiblePosition = 19
        UltraGridColumn235.MaskInput = "{double:9.2}"
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn236.CellAppearance = Appearance68
        UltraGridColumn236.Header.Caption = "Importe Otro Ajuste (18)"
        UltraGridColumn236.Header.VisiblePosition = 20
        UltraGridColumn236.MaskInput = "{double:9.2}"
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn237.CellAppearance = Appearance69
        UltraGridColumn237.Header.Caption = "Valor Rev. (19)"
        UltraGridColumn237.Header.VisiblePosition = 21
        UltraGridColumn237.MaskInput = "{double:9.2}"
        Appearance70.TextHAlignAsString = "Right"
        UltraGridColumn238.CellAppearance = Appearance70
        UltraGridColumn238.Header.Caption = "Valor Rev. Efectuada (20)"
        UltraGridColumn238.Header.VisiblePosition = 22
        UltraGridColumn238.MaskInput = "{double:9.2}"
        Appearance71.TextHAlignAsString = "Right"
        UltraGridColumn239.CellAppearance = Appearance71
        UltraGridColumn239.Header.Caption = "Valor Otras Rev. (21)"
        UltraGridColumn239.Header.VisiblePosition = 23
        UltraGridColumn239.MaskInput = "{double:9.2}"
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn240.CellAppearance = Appearance72
        UltraGridColumn240.Header.Caption = "Importe Ajuste (22)"
        UltraGridColumn240.Header.VisiblePosition = 24
        UltraGridColumn240.MaskInput = "{double:9.2}"
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn241.CellAppearance = Appearance73
        UltraGridColumn241.Header.Caption = "Porc. Dep. (27)"
        UltraGridColumn241.Header.VisiblePosition = 33
        UltraGridColumn241.MaskInput = "{double:9.4}"
        Appearance74.TextHAlignAsString = "Right"
        UltraGridColumn242.CellAppearance = Appearance74
        UltraGridColumn242.Header.Caption = "Dep. Acumulada (28)"
        UltraGridColumn242.Header.VisiblePosition = 34
        UltraGridColumn242.MaskInput = "{double:9.4}"
        UltraGridColumn243.Header.VisiblePosition = 27
        UltraGridColumn243.Hidden = True
        UltraGridColumn244.Header.Caption = "Modelo (12)"
        UltraGridColumn244.Header.VisiblePosition = 14
        UltraGridColumn245.Header.Caption = "Serie (13)"
        UltraGridColumn245.Header.VisiblePosition = 15
        UltraGridColumn246.Header.Caption = "Cod. Metodo Dep (25)"
        UltraGridColumn246.Header.VisiblePosition = 28
        UltraGridColumn247.Header.Caption = "Nro. Doc. Aut. (26)"
        UltraGridColumn247.Header.VisiblePosition = 29
        UltraGridColumn248.Header.VisiblePosition = 30
        UltraGridColumn248.Hidden = True
        UltraGridColumn249.Header.VisiblePosition = 31
        UltraGridColumn249.Hidden = True
        UltraGridColumn250.Header.VisiblePosition = 32
        UltraGridColumn250.Hidden = True
        UltraGridColumn251.Header.Caption = "Indicador (36)"
        UltraGridColumn251.Header.VisiblePosition = 50
        UltraGridColumn252.Header.VisiblePosition = 38
        UltraGridColumn252.Hidden = True
        UltraGridColumn253.Header.Caption = "CUO (2)"
        UltraGridColumn253.Header.VisiblePosition = 4
        UltraGridColumn254.Header.VisiblePosition = 39
        UltraGridColumn254.Hidden = True
        UltraGridColumn255.Header.VisiblePosition = 40
        UltraGridColumn255.Hidden = True
        UltraGridColumn256.Header.VisiblePosition = 41
        UltraGridColumn256.Hidden = True
        UltraGridColumn257.Header.VisiblePosition = 42
        UltraGridColumn257.Hidden = True
        UltraGridColumn258.Header.VisiblePosition = 43
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 44
        UltraGridColumn259.Hidden = True
        UltraGridColumn260.Header.VisiblePosition = 45
        UltraGridColumn260.Hidden = True
        Appearance75.TextHAlignAsString = "Right"
        UltraGridColumn261.CellAppearance = Appearance75
        UltraGridColumn261.Header.Caption = "Valor Dep. Ajustes (31)"
        UltraGridColumn261.Header.VisiblePosition = 37
        UltraGridColumn261.MaskInput = "{double:9.2}"
        Appearance76.TextHAlignAsString = "Right"
        UltraGridColumn262.CellAppearance = Appearance76
        UltraGridColumn262.Header.Caption = "Valor Dep. R.V. (32)"
        UltraGridColumn262.Header.VisiblePosition = 46
        UltraGridColumn262.MaskInput = "{double:9.2}"
        Appearance77.TextHAlignAsString = "Right"
        UltraGridColumn263.CellAppearance = Appearance77
        UltraGridColumn263.Header.Caption = "Valor Dep. R.E. (33)"
        UltraGridColumn263.Header.VisiblePosition = 47
        UltraGridColumn263.MaskInput = "{double:9.2}"
        Appearance78.TextHAlignAsString = "Right"
        UltraGridColumn264.CellAppearance = Appearance78
        UltraGridColumn264.Header.Caption = "Valor Dep. O. R. (34)"
        UltraGridColumn264.Header.VisiblePosition = 48
        UltraGridColumn264.MaskInput = "{double:9.2}"
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn265.CellAppearance = Appearance79
        UltraGridColumn265.Header.Caption = "Valor Ajuste (35)"
        UltraGridColumn265.Header.VisiblePosition = 49
        UltraGridColumn265.MaskInput = "{double:9.2}"
        Appearance80.TextHAlignAsString = "Right"
        UltraGridColumn266.CellAppearance = Appearance80
        UltraGridColumn266.Header.Caption = "Valor Dep. (29)"
        UltraGridColumn266.Header.VisiblePosition = 35
        UltraGridColumn266.MaskInput = "{double:9.2}"
        Appearance81.TextHAlignAsString = "Right"
        UltraGridColumn267.CellAppearance = Appearance81
        UltraGridColumn267.Header.Caption = "Valor Dep. Baja (30)"
        UltraGridColumn267.Header.VisiblePosition = 36
        UltraGridColumn267.MaskInput = "{double:9.2}"
        UltraGridColumn268.Header.VisiblePosition = 51
        UltraGridColumn268.Hidden = True
        UltraGridColumn269.Header.VisiblePosition = 52
        UltraGridColumn269.Hidden = True
        UltraGridColumn270.Header.VisiblePosition = 53
        UltraGridColumn270.Hidden = True
        UltraGridBand23.Columns.AddRange(New Object() {UltraGridColumn217, UltraGridColumn218, UltraGridColumn219, UltraGridColumn220, UltraGridColumn221, UltraGridColumn222, UltraGridColumn223, UltraGridColumn224, UltraGridColumn225, UltraGridColumn226, UltraGridColumn227, UltraGridColumn228, UltraGridColumn229, UltraGridColumn230, UltraGridColumn231, UltraGridColumn232, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn247, UltraGridColumn248, UltraGridColumn249, UltraGridColumn250, UltraGridColumn251, UltraGridColumn252, UltraGridColumn253, UltraGridColumn254, UltraGridColumn255, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn264, UltraGridColumn265, UltraGridColumn266, UltraGridColumn267, UltraGridColumn268, UltraGridColumn269, UltraGridColumn270})
        Me.gridActivoFijo.DisplayLayout.BandsSerializer.Add(UltraGridBand23)
        Me.gridActivoFijo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridActivoFijo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridActivoFijo.DisplayLayout.GroupByBox.Hidden = True
        Me.gridActivoFijo.DisplayLayout.MaxColScrollRegions = 1
        Me.gridActivoFijo.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridActivoFijo.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridActivoFijo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridActivoFijo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridActivoFijo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridActivoFijo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridActivoFijo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridActivoFijo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridActivoFijo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridActivoFijo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.gridActivoFijo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridActivoFijo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridActivoFijo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridActivoFijo.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.gridActivoFijo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridActivoFijo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridActivoFijo.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridActivoFijo.Location = New System.Drawing.Point(0, 0)
        Me.gridActivoFijo.Name = "gridActivoFijo"
        Me.gridActivoFijo.Size = New System.Drawing.Size(1256, 251)
        Me.gridActivoFijo.TabIndex = 0
        Me.gridActivoFijo.Text = "7.1 ACTIVOS FIJOS REVALUADOS Y NO REVALUADOS"
        '
        'UltraTabPageControl49
        '
        Me.UltraTabPageControl49.Controls.Add(Me.griAct73)
        Me.UltraTabPageControl49.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl49.Name = "UltraTabPageControl49"
        Me.UltraTabPageControl49.Size = New System.Drawing.Size(1256, 251)
        '
        'griAct73
        '
        Me.griAct73.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1636.Header.VisiblePosition = 0
        UltraGridColumn1636.Hidden = True
        UltraGridColumn1637.Header.VisiblePosition = 1
        UltraGridColumn1637.Hidden = True
        UltraGridColumn1638.Header.VisiblePosition = 2
        UltraGridColumn1638.Hidden = True
        UltraGridColumn1639.Header.Caption = "Periodo (1)"
        UltraGridColumn1639.Header.VisiblePosition = 3
        UltraGridColumn1640.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn1640.Header.VisiblePosition = 5
        UltraGridColumn1641.Header.Caption = "Fec Adquisicion (6)"
        UltraGridColumn1641.Header.VisiblePosition = 8
        UltraGridColumn1642.Header.VisiblePosition = 9
        UltraGridColumn1642.Hidden = True
        UltraGridColumn1643.Header.Caption = "Cod. Catalogo (4)"
        UltraGridColumn1643.Header.VisiblePosition = 6
        UltraGridColumn1644.Header.Caption = "Codigo Propio (5)"
        UltraGridColumn1644.Header.VisiblePosition = 7
        UltraGridColumn1645.Header.VisiblePosition = 10
        UltraGridColumn1645.Hidden = True
        UltraGridColumn1646.Header.VisiblePosition = 11
        UltraGridColumn1646.Hidden = True
        UltraGridColumn1647.Header.VisiblePosition = 12
        UltraGridColumn1647.Hidden = True
        UltraGridColumn1648.Header.VisiblePosition = 13
        UltraGridColumn1648.Hidden = True
        UltraGridColumn1649.Header.VisiblePosition = 14
        UltraGridColumn1649.Hidden = True
        UltraGridColumn1650.Header.VisiblePosition = 15
        UltraGridColumn1650.Hidden = True
        UltraGridColumn1651.Header.Caption = "Valor Adq. ME (7)"
        UltraGridColumn1651.Header.VisiblePosition = 16
        UltraGridColumn1652.Header.Caption = "Valor Adq M.N. (9)"
        UltraGridColumn1652.Header.VisiblePosition = 18
        UltraGridColumn1653.Header.Caption = "T.C. Cierre (10)"
        UltraGridColumn1653.Header.VisiblePosition = 19
        UltraGridColumn1654.Header.Caption = "Ajuste T.C. (11)"
        UltraGridColumn1654.Header.VisiblePosition = 20
        UltraGridColumn1655.Header.Caption = "Dep. Ejercicio (12)"
        UltraGridColumn1655.Header.VisiblePosition = 21
        UltraGridColumn1656.Header.Caption = "Dep. Retiro (13)"
        UltraGridColumn1656.Header.VisiblePosition = 22
        UltraGridColumn1657.Header.Caption = "Dep. Otros Ajustes (14)"
        UltraGridColumn1657.Header.VisiblePosition = 23
        UltraGridColumn1658.Header.VisiblePosition = 24
        UltraGridColumn1658.Hidden = True
        UltraGridColumn1659.Header.VisiblePosition = 25
        UltraGridColumn1659.Hidden = True
        UltraGridColumn1660.Header.VisiblePosition = 26
        UltraGridColumn1660.Hidden = True
        UltraGridColumn1661.Header.VisiblePosition = 17
        UltraGridColumn1662.Header.VisiblePosition = 27
        UltraGridColumn1662.Hidden = True
        UltraGridColumn1663.Header.VisiblePosition = 28
        UltraGridColumn1663.Hidden = True
        UltraGridColumn1664.Header.VisiblePosition = 29
        UltraGridColumn1664.Hidden = True
        UltraGridColumn1665.Header.VisiblePosition = 30
        UltraGridColumn1665.Hidden = True
        UltraGridColumn1666.Header.VisiblePosition = 31
        UltraGridColumn1666.Hidden = True
        UltraGridColumn1667.Header.VisiblePosition = 32
        UltraGridColumn1667.Hidden = True
        UltraGridColumn1668.Header.VisiblePosition = 33
        UltraGridColumn1668.Hidden = True
        UltraGridColumn1669.Header.VisiblePosition = 34
        UltraGridColumn1669.Hidden = True
        UltraGridColumn1670.Header.Caption = "Indicador (15)"
        UltraGridColumn1670.Header.VisiblePosition = 35
        UltraGridColumn1671.Header.VisiblePosition = 36
        UltraGridColumn1671.Hidden = True
        UltraGridColumn1672.Header.Caption = "CUO (2)"
        UltraGridColumn1672.Header.VisiblePosition = 4
        UltraGridColumn1673.Header.VisiblePosition = 37
        UltraGridColumn1673.Hidden = True
        UltraGridColumn3319.Header.VisiblePosition = 38
        UltraGridColumn3319.Hidden = True
        UltraGridColumn3320.Header.VisiblePosition = 39
        UltraGridColumn3320.Hidden = True
        UltraGridColumn3321.Header.VisiblePosition = 40
        UltraGridColumn3321.Hidden = True
        UltraGridColumn3322.Header.VisiblePosition = 41
        UltraGridColumn3322.Hidden = True
        UltraGridColumn3323.Header.VisiblePosition = 42
        UltraGridColumn3323.Hidden = True
        UltraGridColumn3324.Header.VisiblePosition = 43
        UltraGridColumn3324.Hidden = True
        UltraGridColumn3325.Header.VisiblePosition = 44
        UltraGridColumn3325.Hidden = True
        UltraGridColumn3326.Header.VisiblePosition = 45
        UltraGridColumn3326.Hidden = True
        UltraGridColumn3327.Header.VisiblePosition = 46
        UltraGridColumn3327.Hidden = True
        UltraGridColumn3328.Header.VisiblePosition = 47
        UltraGridColumn3328.Hidden = True
        UltraGridColumn3329.Header.VisiblePosition = 48
        UltraGridColumn3329.Hidden = True
        UltraGridColumn3330.Header.VisiblePosition = 49
        UltraGridColumn3330.Hidden = True
        UltraGridColumn3331.Header.VisiblePosition = 50
        UltraGridColumn3331.Hidden = True
        UltraGridColumn3332.Header.VisiblePosition = 51
        UltraGridColumn3332.Hidden = True
        UltraGridColumn3333.Header.VisiblePosition = 52
        UltraGridColumn3333.Hidden = True
        UltraGridColumn3334.Header.VisiblePosition = 53
        UltraGridColumn3334.Hidden = True
        UltraGridBand24.Columns.AddRange(New Object() {UltraGridColumn1636, UltraGridColumn1637, UltraGridColumn1638, UltraGridColumn1639, UltraGridColumn1640, UltraGridColumn1641, UltraGridColumn1642, UltraGridColumn1643, UltraGridColumn1644, UltraGridColumn1645, UltraGridColumn1646, UltraGridColumn1647, UltraGridColumn1648, UltraGridColumn1649, UltraGridColumn1650, UltraGridColumn1651, UltraGridColumn1652, UltraGridColumn1653, UltraGridColumn1654, UltraGridColumn1655, UltraGridColumn1656, UltraGridColumn1657, UltraGridColumn1658, UltraGridColumn1659, UltraGridColumn1660, UltraGridColumn1661, UltraGridColumn1662, UltraGridColumn1663, UltraGridColumn1664, UltraGridColumn1665, UltraGridColumn1666, UltraGridColumn1667, UltraGridColumn1668, UltraGridColumn1669, UltraGridColumn1670, UltraGridColumn1671, UltraGridColumn1672, UltraGridColumn1673, UltraGridColumn3319, UltraGridColumn3320, UltraGridColumn3321, UltraGridColumn3322, UltraGridColumn3323, UltraGridColumn3324, UltraGridColumn3325, UltraGridColumn3326, UltraGridColumn3327, UltraGridColumn3328, UltraGridColumn3329, UltraGridColumn3330, UltraGridColumn3331, UltraGridColumn3332, UltraGridColumn3333, UltraGridColumn3334})
        Me.griAct73.DisplayLayout.BandsSerializer.Add(UltraGridBand24)
        Me.griAct73.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAct73.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAct73.DisplayLayout.MaxColScrollRegions = 1
        Me.griAct73.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAct73.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAct73.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAct73.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAct73.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAct73.DisplayLayout.Override.CellPadding = 0
        Me.griAct73.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAct73.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAct73.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAct73.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAct73.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griAct73.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAct73.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAct73.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAct73.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griAct73.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAct73.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAct73.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griAct73.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAct73.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAct73.Location = New System.Drawing.Point(0, 0)
        Me.griAct73.Name = "griAct73"
        Me.griAct73.Size = New System.Drawing.Size(1256, 251)
        Me.griAct73.TabIndex = 0
        Me.griAct73.Text = "7.3 DIFERENCIA TIPO CAMBIO"
        '
        'UltraTabPageControl50
        '
        Me.UltraTabPageControl50.Controls.Add(Me.griAct74)
        Me.UltraTabPageControl50.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl50.Name = "UltraTabPageControl50"
        Me.UltraTabPageControl50.Size = New System.Drawing.Size(1256, 251)
        '
        'griAct74
        '
        Me.griAct74.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn163.Header.VisiblePosition = 0
        UltraGridColumn163.Hidden = True
        UltraGridColumn164.Header.VisiblePosition = 1
        UltraGridColumn164.Hidden = True
        UltraGridColumn165.Header.VisiblePosition = 2
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.Header.Caption = "Periodo (1)"
        UltraGridColumn166.Header.VisiblePosition = 3
        UltraGridColumn167.Header.Caption = "Nro Correlativo (3)"
        UltraGridColumn167.Header.VisiblePosition = 5
        UltraGridColumn168.Header.Caption = "Fec. Contrato (6)"
        UltraGridColumn168.Header.VisiblePosition = 8
        UltraGridColumn168.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn169.Header.Caption = "Fec. Inicio (8)"
        UltraGridColumn169.Header.VisiblePosition = 10
        UltraGridColumn169.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn170.Header.Caption = "Cod. Catalogo (4)"
        UltraGridColumn170.Header.VisiblePosition = 6
        UltraGridColumn171.Header.Caption = "Nro Contrato (5)"
        UltraGridColumn171.Header.VisiblePosition = 7
        UltraGridColumn172.Header.Caption = "Cod. Propio (7)"
        UltraGridColumn172.Header.VisiblePosition = 9
        UltraGridColumn173.Header.VisiblePosition = 11
        UltraGridColumn173.Hidden = True
        UltraGridColumn174.Header.VisiblePosition = 12
        UltraGridColumn174.Hidden = True
        UltraGridColumn175.Header.VisiblePosition = 13
        UltraGridColumn175.Hidden = True
        UltraGridColumn176.Header.VisiblePosition = 14
        UltraGridColumn176.Hidden = True
        UltraGridColumn177.Header.VisiblePosition = 15
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.Caption = "Nro Cuotas(9)"
        UltraGridColumn178.Header.VisiblePosition = 16
        UltraGridColumn179.Header.VisiblePosition = 17
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 18
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 19
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.Header.VisiblePosition = 20
        UltraGridColumn182.Hidden = True
        UltraGridColumn183.Header.VisiblePosition = 21
        UltraGridColumn183.Hidden = True
        UltraGridColumn184.Header.VisiblePosition = 22
        UltraGridColumn184.Hidden = True
        UltraGridColumn185.Header.VisiblePosition = 23
        UltraGridColumn185.Hidden = True
        UltraGridColumn186.Header.VisiblePosition = 24
        UltraGridColumn186.Hidden = True
        Appearance82.TextHAlignAsString = "Right"
        UltraGridColumn187.CellAppearance = Appearance82
        UltraGridColumn187.Header.Caption = "Monto (10)"
        UltraGridColumn187.Header.VisiblePosition = 25
        UltraGridColumn187.MaskInput = "{double:9.2}"
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
        UltraGridColumn193.Header.VisiblePosition = 31
        UltraGridColumn193.Hidden = True
        UltraGridColumn194.Header.VisiblePosition = 32
        UltraGridColumn194.Hidden = True
        UltraGridColumn195.Header.VisiblePosition = 33
        UltraGridColumn195.Hidden = True
        UltraGridColumn196.Header.VisiblePosition = 34
        UltraGridColumn196.Hidden = True
        UltraGridColumn197.Header.Caption = "Indicador (11)"
        UltraGridColumn197.Header.VisiblePosition = 35
        UltraGridColumn198.Header.VisiblePosition = 36
        UltraGridColumn198.Hidden = True
        UltraGridColumn199.Header.Caption = "CUO (2)"
        UltraGridColumn199.Header.VisiblePosition = 4
        UltraGridColumn200.Header.VisiblePosition = 37
        UltraGridColumn200.Hidden = True
        UltraGridColumn201.Header.VisiblePosition = 38
        UltraGridColumn201.Hidden = True
        UltraGridColumn202.Header.VisiblePosition = 39
        UltraGridColumn202.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 40
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 41
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.VisiblePosition = 42
        UltraGridColumn205.Hidden = True
        UltraGridColumn206.Header.VisiblePosition = 43
        UltraGridColumn206.Hidden = True
        UltraGridColumn207.Header.VisiblePosition = 44
        UltraGridColumn207.Hidden = True
        UltraGridColumn208.Header.VisiblePosition = 45
        UltraGridColumn208.Hidden = True
        UltraGridColumn209.Header.VisiblePosition = 46
        UltraGridColumn209.Hidden = True
        UltraGridColumn210.Header.VisiblePosition = 47
        UltraGridColumn210.Hidden = True
        UltraGridColumn211.Header.VisiblePosition = 48
        UltraGridColumn211.Hidden = True
        UltraGridColumn212.Header.VisiblePosition = 49
        UltraGridColumn212.Hidden = True
        UltraGridColumn213.Header.VisiblePosition = 50
        UltraGridColumn213.Hidden = True
        UltraGridColumn214.Header.VisiblePosition = 51
        UltraGridColumn214.Hidden = True
        UltraGridColumn215.Header.VisiblePosition = 52
        UltraGridColumn215.Hidden = True
        UltraGridColumn216.Header.VisiblePosition = 53
        UltraGridColumn216.Hidden = True
        UltraGridBand25.Columns.AddRange(New Object() {UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183, UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205, UltraGridColumn206, UltraGridColumn207, UltraGridColumn208, UltraGridColumn209, UltraGridColumn210, UltraGridColumn211, UltraGridColumn212, UltraGridColumn213, UltraGridColumn214, UltraGridColumn215, UltraGridColumn216})
        Me.griAct74.DisplayLayout.BandsSerializer.Add(UltraGridBand25)
        Me.griAct74.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAct74.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAct74.DisplayLayout.MaxColScrollRegions = 1
        Me.griAct74.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAct74.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griAct74.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAct74.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAct74.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griAct74.DisplayLayout.Override.CellPadding = 0
        Me.griAct74.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAct74.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAct74.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAct74.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAct74.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griAct74.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAct74.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAct74.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAct74.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griAct74.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAct74.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAct74.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAct74.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAct74.Location = New System.Drawing.Point(0, 0)
        Me.griAct74.Name = "griAct74"
        Me.griAct74.Size = New System.Drawing.Size(1256, 251)
        Me.griAct74.TabIndex = 0
        Me.griAct74.Text = "7.4 ACTIVOS FIJOS BAJO LA MODALIDAD DE ARRENDAMIENTO FINANCIERO"
        '
        'UltraTabPageControl16
        '
        Me.UltraTabPageControl16.Controls.Add(Me.griDetalleCompras)
        Me.UltraTabPageControl16.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl16.Name = "UltraTabPageControl16"
        Me.UltraTabPageControl16.Size = New System.Drawing.Size(1254, 249)
        '
        'griDetalleCompras
        '
        Me.griDetalleCompras.AllowDrop = True
        Me.griDetalleCompras.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn3335.Header.VisiblePosition = 0
        UltraGridColumn3335.Hidden = True
        UltraGridColumn3336.Header.VisiblePosition = 1
        UltraGridColumn3336.Hidden = True
        UltraGridColumn3337.Header.VisiblePosition = 2
        UltraGridColumn3337.Hidden = True
        UltraGridColumn3338.Header.Caption = "Periodo(1)"
        UltraGridColumn3338.Header.VisiblePosition = 3
        UltraGridColumn3338.Width = 60
        UltraGridColumn3339.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn3339.Header.VisiblePosition = 5
        UltraGridColumn3339.Width = 74
        UltraGridColumn3340.Header.Caption = "F.Emision(4)"
        UltraGridColumn3340.Header.VisiblePosition = 6
        UltraGridColumn3340.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3340.Width = 60
        UltraGridColumn3341.Header.Caption = "F.Vencimiento(5)"
        UltraGridColumn3341.Header.VisiblePosition = 7
        UltraGridColumn3341.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3341.Width = 79
        UltraGridColumn3342.Header.Caption = "T.D(6)"
        UltraGridColumn3342.Header.VisiblePosition = 8
        UltraGridColumn3342.Width = 36
        UltraGridColumn3343.Header.Caption = "Serie(7)"
        UltraGridColumn3343.Header.VisiblePosition = 9
        UltraGridColumn3343.Width = 40
        UltraGridColumn3344.Header.Caption = "A.DUA(8)"
        UltraGridColumn3344.Header.VisiblePosition = 10
        UltraGridColumn3344.Width = 48
        UltraGridColumn3345.Header.Caption = "N°Doc.I.(9)"
        UltraGridColumn3345.Header.VisiblePosition = 11
        UltraGridColumn3345.Width = 70
        UltraGridColumn3346.Header.Caption = "N°Doc.F.(10)"
        UltraGridColumn3346.Header.VisiblePosition = 12
        UltraGridColumn3346.Width = 70
        UltraGridColumn3347.Header.Caption = "T.D.I(11)"
        UltraGridColumn3347.Header.VisiblePosition = 13
        UltraGridColumn3347.Width = 43
        UltraGridColumn3348.Header.Caption = "N°Doc.I(12)"
        UltraGridColumn3348.Header.VisiblePosition = 14
        UltraGridColumn3348.Width = 70
        UltraGridColumn3349.Header.Caption = "Razon Social(13)"
        UltraGridColumn3349.Header.VisiblePosition = 15
        Appearance83.TextHAlignAsString = "Right"
        UltraGridColumn3350.CellAppearance = Appearance83
        UltraGridColumn3350.Header.Caption = "G. y/o E. B.I(14)"
        UltraGridColumn3350.Header.VisiblePosition = 16
        UltraGridColumn3350.MaskInput = "{double:-9.2}"
        UltraGridColumn3350.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3350.Width = 75
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn3351.CellAppearance = Appearance84
        UltraGridColumn3351.Header.Caption = "G. y/o E. IGV(15)"
        UltraGridColumn3351.Header.VisiblePosition = 17
        UltraGridColumn3351.MaskInput = "{double:-7.2}"
        UltraGridColumn3351.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3351.Width = 78
        Appearance85.TextHAlignAsString = "Right"
        UltraGridColumn3352.CellAppearance = Appearance85
        UltraGridColumn3352.Header.Caption = "G. y No G. B.I(16)"
        UltraGridColumn3352.Header.VisiblePosition = 18
        UltraGridColumn3352.MaskInput = "{double:-9.2}"
        UltraGridColumn3352.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3352.Width = 79
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn3353.CellAppearance = Appearance86
        UltraGridColumn3353.Header.Caption = "G. No G. IGV(17)"
        UltraGridColumn3353.Header.VisiblePosition = 19
        UltraGridColumn3353.MaskInput = "{double:-7.2}"
        UltraGridColumn3353.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3353.Width = 80
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn3354.CellAppearance = Appearance87
        UltraGridColumn3354.Header.Caption = "No G. B.I(18)"
        UltraGridColumn3354.Header.VisiblePosition = 20
        UltraGridColumn3354.MaskInput = "{double:-9.2}"
        UltraGridColumn3354.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3354.Width = 70
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn3355.CellAppearance = Appearance88
        UltraGridColumn3355.Header.Caption = "No G. IGV(19)"
        UltraGridColumn3355.Header.VisiblePosition = 21
        UltraGridColumn3355.MaskInput = "{double:-7.2}"
        UltraGridColumn3355.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3355.Width = 69
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn3356.CellAppearance = Appearance89
        UltraGridColumn3356.Header.Caption = "Valor No G.(20)"
        UltraGridColumn3356.Header.VisiblePosition = 22
        UltraGridColumn3356.MaskInput = "{double:-7.2}"
        UltraGridColumn3356.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3356.Width = 74
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn3357.CellAppearance = Appearance90
        UltraGridColumn3357.Header.Caption = "ISC(21)"
        UltraGridColumn3357.Header.VisiblePosition = 23
        UltraGridColumn3357.MaskInput = "{double:-7.2}"
        UltraGridColumn3357.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3357.Width = 60
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn3358.CellAppearance = Appearance91
        UltraGridColumn3358.Header.Caption = "O.Tributos(22)"
        UltraGridColumn3358.Header.VisiblePosition = 24
        UltraGridColumn3358.MaskInput = "{double:-7.2}"
        UltraGridColumn3358.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3358.Width = 69
        Appearance92.TextHAlignAsString = "Right"
        UltraGridColumn3359.CellAppearance = Appearance92
        UltraGridColumn3359.Header.Caption = "Importe Total(23)"
        UltraGridColumn3359.Header.VisiblePosition = 25
        UltraGridColumn3359.MaskInput = "{double:-9.2}"
        UltraGridColumn3359.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3359.Width = 79
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn3360.CellAppearance = Appearance93
        UltraGridColumn3360.Header.Caption = "T.C.(25)"
        UltraGridColumn3360.Header.VisiblePosition = 27
        UltraGridColumn3360.MaskInput = "{double:1.3}"
        UltraGridColumn3360.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3360.Width = 40
        UltraGridColumn3361.Header.Caption = "F.E. C.M(26)"
        UltraGridColumn3361.Header.VisiblePosition = 28
        UltraGridColumn3361.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3361.Width = 60
        UltraGridColumn3362.Header.Caption = "TDM(27)"
        UltraGridColumn3362.Header.VisiblePosition = 29
        UltraGridColumn3362.Width = 42
        UltraGridColumn3363.Header.Caption = "Serie M(28)"
        UltraGridColumn3363.Header.VisiblePosition = 30
        UltraGridColumn3363.Width = 56
        UltraGridColumn3364.Header.Caption = "N° D.M(30)"
        UltraGridColumn3364.Header.VisiblePosition = 32
        UltraGridColumn3364.Width = 60
        UltraGridColumn3365.Header.Caption = "N° D. E.D"
        UltraGridColumn3365.Header.VisiblePosition = 33
        UltraGridColumn3365.Hidden = True
        UltraGridColumn3365.Width = 60
        UltraGridColumn3366.Header.Caption = "F.E.Detrac.(31)"
        UltraGridColumn3366.Header.VisiblePosition = 34
        UltraGridColumn3366.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3366.Width = 71
        UltraGridColumn3367.Header.Caption = "N°Const.Detrac(32)"
        UltraGridColumn3367.Header.VisiblePosition = 35
        UltraGridColumn3367.Width = 89
        UltraGridColumn3368.Header.Caption = "R(33)"
        UltraGridColumn3368.Header.VisiblePosition = 36
        UltraGridColumn3368.Width = 30
        UltraGridColumn3369.Header.Caption = "I(41)"
        UltraGridColumn3369.Header.VisiblePosition = 44
        UltraGridColumn3369.Width = 35
        UltraGridColumn3370.Header.VisiblePosition = 45
        UltraGridColumn3370.Hidden = True
        UltraGridColumn3371.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn3371.Header.VisiblePosition = 4
        UltraGridColumn3371.Width = 150
        UltraGridColumn3372.Header.Caption = "DUA DSI(29)"
        UltraGridColumn3372.Header.VisiblePosition = 31
        UltraGridColumn3372.Width = 64
        UltraGridColumn3373.Header.VisiblePosition = 46
        UltraGridColumn3373.Hidden = True
        UltraGridColumn3374.Header.VisiblePosition = 47
        UltraGridColumn3374.Hidden = True
        UltraGridColumn3375.Header.VisiblePosition = 48
        UltraGridColumn3375.Hidden = True
        UltraGridColumn3376.Header.Caption = "CodigoMoneda(24)"
        UltraGridColumn3376.Header.VisiblePosition = 26
        UltraGridColumn3376.Width = 89
        UltraGridColumn3377.Header.Caption = "B/S(34)"
        UltraGridColumn3377.Header.VisiblePosition = 37
        UltraGridColumn3377.Width = 42
        UltraGridColumn3378.Header.Caption = "IdentificacionContratoProy(35)"
        UltraGridColumn3378.Header.VisiblePosition = 38
        UltraGridColumn3379.Header.Caption = "ErrorTipo1(36)"
        UltraGridColumn3379.Header.VisiblePosition = 39
        UltraGridColumn3379.Width = 68
        UltraGridColumn3380.Header.Caption = "ErrorTipo2(37)"
        UltraGridColumn3380.Header.VisiblePosition = 40
        UltraGridColumn3380.Width = 66
        UltraGridColumn3381.Header.Caption = "ErrorTipo3(38)"
        UltraGridColumn3381.Header.VisiblePosition = 41
        UltraGridColumn3381.Width = 66
        UltraGridColumn3382.Header.Caption = "ErrorTipo4(39)"
        UltraGridColumn3382.Header.VisiblePosition = 42
        UltraGridColumn3382.Width = 66
        UltraGridColumn3383.Header.Caption = "IndCancelaComprobPago(40)"
        UltraGridColumn3383.Header.VisiblePosition = 43
        UltraGridColumn3383.Width = 133
        UltraGridColumn3384.Header.VisiblePosition = 49
        UltraGridColumn3384.Hidden = True
        UltraGridColumn3385.Header.VisiblePosition = 50
        UltraGridColumn3385.Hidden = True
        UltraGridColumn3386.Header.VisiblePosition = 51
        UltraGridColumn3386.Hidden = True
        UltraGridColumn3387.Header.VisiblePosition = 52
        UltraGridColumn3387.Hidden = True
        UltraGridColumn3388.Header.VisiblePosition = 53
        UltraGridColumn3388.Hidden = True
        UltraGridBand26.Columns.AddRange(New Object() {UltraGridColumn3335, UltraGridColumn3336, UltraGridColumn3337, UltraGridColumn3338, UltraGridColumn3339, UltraGridColumn3340, UltraGridColumn3341, UltraGridColumn3342, UltraGridColumn3343, UltraGridColumn3344, UltraGridColumn3345, UltraGridColumn3346, UltraGridColumn3347, UltraGridColumn3348, UltraGridColumn3349, UltraGridColumn3350, UltraGridColumn3351, UltraGridColumn3352, UltraGridColumn3353, UltraGridColumn3354, UltraGridColumn3355, UltraGridColumn3356, UltraGridColumn3357, UltraGridColumn3358, UltraGridColumn3359, UltraGridColumn3360, UltraGridColumn3361, UltraGridColumn3362, UltraGridColumn3363, UltraGridColumn3364, UltraGridColumn3365, UltraGridColumn3366, UltraGridColumn3367, UltraGridColumn3368, UltraGridColumn3369, UltraGridColumn3370, UltraGridColumn3371, UltraGridColumn3372, UltraGridColumn3373, UltraGridColumn3374, UltraGridColumn3375, UltraGridColumn3376, UltraGridColumn3377, UltraGridColumn3378, UltraGridColumn3379, UltraGridColumn3380, UltraGridColumn3381, UltraGridColumn3382, UltraGridColumn3383, UltraGridColumn3384, UltraGridColumn3385, UltraGridColumn3386, UltraGridColumn3387, UltraGridColumn3388})
        UltraGridBand26.SummaryFooterCaption = "Totales:"
        Me.griDetalleCompras.DisplayLayout.BandsSerializer.Add(UltraGridBand26)
        Me.griDetalleCompras.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleCompras.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleCompras.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleCompras.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleCompras.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleCompras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleCompras.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleCompras.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleCompras.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleCompras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleCompras.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDetalleCompras.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleCompras.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleCompras.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleCompras.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleCompras.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleCompras.Location = New System.Drawing.Point(0, 0)
        Me.griDetalleCompras.Name = "griDetalleCompras"
        Me.griDetalleCompras.Size = New System.Drawing.Size(1254, 249)
        Me.griDetalleCompras.TabIndex = 0
        Me.griDetalleCompras.Tag = ""
        Me.griDetalleCompras.Text = "8.1 REGISTRO DE COMPRAS"
        '
        'UltraTabPageControl17
        '
        Me.UltraTabPageControl17.Controls.Add(Me.griCompras2)
        Me.UltraTabPageControl17.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl17.Name = "UltraTabPageControl17"
        Me.UltraTabPageControl17.Size = New System.Drawing.Size(1254, 249)
        '
        'griCompras2
        '
        Me.griCompras2.AllowDrop = True
        Me.griCompras2.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn3389.Header.VisiblePosition = 0
        UltraGridColumn3389.Hidden = True
        UltraGridColumn3390.Header.VisiblePosition = 1
        UltraGridColumn3390.Hidden = True
        UltraGridColumn3391.Header.VisiblePosition = 2
        UltraGridColumn3391.Hidden = True
        UltraGridColumn3392.Header.Caption = "Periodo(1)"
        UltraGridColumn3392.Header.VisiblePosition = 3
        UltraGridColumn3392.Width = 60
        UltraGridColumn3393.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn3393.Header.VisiblePosition = 5
        UltraGridColumn3393.Width = 74
        UltraGridColumn3394.Header.Caption = "F.Emision(4)"
        UltraGridColumn3394.Header.VisiblePosition = 6
        UltraGridColumn3394.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3394.Width = 60
        UltraGridColumn3395.Header.Caption = "F.Vencimiento(5)"
        UltraGridColumn3395.Header.VisiblePosition = 38
        UltraGridColumn3395.Hidden = True
        UltraGridColumn3395.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3395.Width = 79
        UltraGridColumn3396.Header.Caption = "T.D(5)"
        UltraGridColumn3396.Header.VisiblePosition = 7
        UltraGridColumn3396.Width = 36
        UltraGridColumn3397.Header.Caption = "Serie(6)"
        UltraGridColumn3397.Header.VisiblePosition = 8
        UltraGridColumn3397.Width = 40
        UltraGridColumn3398.Header.Caption = "A.DUA(8)"
        UltraGridColumn3398.Header.VisiblePosition = 39
        UltraGridColumn3398.Hidden = True
        UltraGridColumn3398.Width = 48
        UltraGridColumn3399.Header.Caption = "Numero(7)"
        UltraGridColumn3399.Header.VisiblePosition = 9
        UltraGridColumn3399.Width = 70
        UltraGridColumn3400.Header.Caption = "N°Doc.F.(10)"
        UltraGridColumn3400.Header.VisiblePosition = 40
        UltraGridColumn3400.Hidden = True
        UltraGridColumn3400.Width = 70
        UltraGridColumn3401.Header.Caption = "T.D.I(11)"
        UltraGridColumn3401.Header.VisiblePosition = 41
        UltraGridColumn3401.Hidden = True
        UltraGridColumn3401.Width = 43
        UltraGridColumn3402.Header.Caption = "N°Identif. NoDomiciliado(21)"
        UltraGridColumn3402.Header.VisiblePosition = 24
        UltraGridColumn3402.Width = 127
        UltraGridColumn3403.Header.Caption = "Razon Social NoDocimiliado(19)"
        UltraGridColumn3403.Header.VisiblePosition = 22
        Appearance94.TextHAlignAsString = "Right"
        UltraGridColumn3404.CellAppearance = Appearance94
        UltraGridColumn3404.Header.Caption = "ValorAdquisiciones(8)"
        UltraGridColumn3404.Header.VisiblePosition = 10
        UltraGridColumn3404.MaskInput = "{double:-9.2}"
        UltraGridColumn3404.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3404.Width = 96
        Appearance95.TextHAlignAsString = "Right"
        UltraGridColumn3405.CellAppearance = Appearance95
        UltraGridColumn3405.Header.Caption = "Retención IGV(15)"
        UltraGridColumn3405.Header.VisiblePosition = 17
        UltraGridColumn3405.MaskInput = "{double:-7.2}"
        UltraGridColumn3405.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3405.Width = 83
        Appearance96.TextHAlignAsString = "Right"
        UltraGridColumn3406.CellAppearance = Appearance96
        UltraGridColumn3406.Header.Caption = "G. y No G. B.I(16)"
        UltraGridColumn3406.Header.VisiblePosition = 42
        UltraGridColumn3406.Hidden = True
        UltraGridColumn3406.MaskInput = "{double:-9.2}"
        UltraGridColumn3406.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3406.Width = 79
        Appearance97.TextHAlignAsString = "Right"
        UltraGridColumn3407.CellAppearance = Appearance97
        UltraGridColumn3407.Header.Caption = "G. No G. IGV(17)"
        UltraGridColumn3407.Header.VisiblePosition = 43
        UltraGridColumn3407.Hidden = True
        UltraGridColumn3407.MaskInput = "{double:-7.2}"
        UltraGridColumn3407.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3407.Width = 80
        Appearance98.TextHAlignAsString = "Right"
        UltraGridColumn3408.CellAppearance = Appearance98
        UltraGridColumn3408.Header.Caption = "No G. B.I(18)"
        UltraGridColumn3408.Header.VisiblePosition = 44
        UltraGridColumn3408.Hidden = True
        UltraGridColumn3408.MaskInput = "{double:-9.2}"
        UltraGridColumn3408.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3408.Width = 70
        Appearance99.TextHAlignAsString = "Right"
        UltraGridColumn3409.CellAppearance = Appearance99
        UltraGridColumn3409.Header.Caption = "No G. IGV(19)"
        UltraGridColumn3409.Header.VisiblePosition = 45
        UltraGridColumn3409.Hidden = True
        UltraGridColumn3409.MaskInput = "{double:-7.2}"
        UltraGridColumn3409.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3409.Width = 69
        Appearance100.TextHAlignAsString = "Right"
        UltraGridColumn3410.CellAppearance = Appearance100
        UltraGridColumn3410.Header.Caption = "Valor No G.(20)"
        UltraGridColumn3410.Header.VisiblePosition = 46
        UltraGridColumn3410.Hidden = True
        UltraGridColumn3410.MaskInput = "{double:-7.2}"
        UltraGridColumn3410.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3410.Width = 74
        Appearance101.TextHAlignAsString = "Right"
        UltraGridColumn3411.CellAppearance = Appearance101
        UltraGridColumn3411.Header.Caption = "ISC(21)"
        UltraGridColumn3411.Header.VisiblePosition = 47
        UltraGridColumn3411.Hidden = True
        UltraGridColumn3411.MaskInput = "{double:-7.2}"
        UltraGridColumn3411.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3411.Width = 60
        Appearance102.TextHAlignAsString = "Right"
        UltraGridColumn3412.CellAppearance = Appearance102
        UltraGridColumn3412.Header.Caption = "O.Conceptos(9)"
        UltraGridColumn3412.Header.VisiblePosition = 11
        UltraGridColumn3412.MaskInput = "{double:-7.2}"
        UltraGridColumn3412.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3412.Width = 76
        Appearance103.TextHAlignAsString = "Right"
        UltraGridColumn3413.CellAppearance = Appearance103
        UltraGridColumn3413.Header.Caption = "Importe Total(10)"
        UltraGridColumn3413.Header.VisiblePosition = 12
        UltraGridColumn3413.MaskInput = "{double:-9.2}"
        UltraGridColumn3413.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3413.Width = 79
        Appearance104.TextHAlignAsString = "Right"
        UltraGridColumn3414.CellAppearance = Appearance104
        UltraGridColumn3414.Header.Caption = "T.C.(17)"
        UltraGridColumn3414.Header.VisiblePosition = 19
        UltraGridColumn3414.MaskInput = "{double:1.3}"
        UltraGridColumn3414.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3414.Width = 40
        UltraGridColumn3415.Header.Caption = "AñoDUA/DSI(13)"
        UltraGridColumn3415.Header.VisiblePosition = 15
        UltraGridColumn3415.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3415.Width = 81
        UltraGridColumn3416.Header.Caption = "TD Cred. Fiscal(11)"
        UltraGridColumn3416.Header.VisiblePosition = 13
        UltraGridColumn3416.Width = 87
        UltraGridColumn3417.Header.Caption = "Serie Cred. Fiscal(12)"
        UltraGridColumn3417.Header.VisiblePosition = 14
        UltraGridColumn3417.Width = 98
        UltraGridColumn3418.Header.Caption = "N° Doc. Cred. Fiscal(14)"
        UltraGridColumn3418.Header.VisiblePosition = 16
        UltraGridColumn3418.Width = 109
        UltraGridColumn3419.Header.Caption = "N° D. E.D"
        UltraGridColumn3419.Header.VisiblePosition = 49
        UltraGridColumn3419.Hidden = True
        UltraGridColumn3419.Width = 60
        UltraGridColumn3420.Header.Caption = "F.E.Detrac.(31)"
        UltraGridColumn3420.Header.VisiblePosition = 50
        UltraGridColumn3420.Hidden = True
        UltraGridColumn3420.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3420.Width = 71
        UltraGridColumn3421.Header.Caption = "N°Const.Detrac(32)"
        UltraGridColumn3421.Header.VisiblePosition = 51
        UltraGridColumn3421.Hidden = True
        UltraGridColumn3421.Width = 89
        UltraGridColumn3422.Header.Caption = "R(33)"
        UltraGridColumn3422.Header.VisiblePosition = 52
        UltraGridColumn3422.Hidden = True
        UltraGridColumn3422.Width = 30
        UltraGridColumn3423.Header.Caption = "I(36)"
        UltraGridColumn3423.Header.VisiblePosition = 65
        UltraGridColumn3423.Width = 35
        UltraGridColumn3424.Header.VisiblePosition = 57
        UltraGridColumn3424.Hidden = True
        UltraGridColumn3425.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn3425.Header.VisiblePosition = 4
        UltraGridColumn3425.Width = 150
        UltraGridColumn3426.Header.Caption = "DUA DSI(29)"
        UltraGridColumn3426.Header.VisiblePosition = 48
        UltraGridColumn3426.Hidden = True
        UltraGridColumn3426.Width = 64
        UltraGridColumn3427.Header.VisiblePosition = 58
        UltraGridColumn3427.Hidden = True
        UltraGridColumn3428.Header.VisiblePosition = 59
        UltraGridColumn3428.Hidden = True
        UltraGridColumn3429.Header.VisiblePosition = 60
        UltraGridColumn3429.Hidden = True
        UltraGridColumn3430.Header.Caption = "CodigoMoneda(16)"
        UltraGridColumn3430.Header.VisiblePosition = 18
        UltraGridColumn3430.Width = 89
        UltraGridColumn3431.Header.Caption = "ClasificacionBienServicio(34)"
        UltraGridColumn3431.Header.VisiblePosition = 53
        UltraGridColumn3431.Hidden = True
        UltraGridColumn3432.Header.Caption = "PaisNoDomiciliado(18)"
        UltraGridColumn3432.Header.VisiblePosition = 20
        UltraGridColumn3432.Hidden = True
        UltraGridColumn3433.Header.Caption = "DomicilioExtranjero(20)"
        UltraGridColumn3433.Header.VisiblePosition = 23
        UltraGridColumn3433.Width = 104
        UltraGridColumn3434.Header.Caption = "Convenio(31)"
        UltraGridColumn3434.Header.VisiblePosition = 34
        UltraGridColumn3434.Hidden = True
        UltraGridColumn3434.Width = 66
        UltraGridColumn3435.Header.Caption = "TipoRenta(33)"
        UltraGridColumn3435.Header.VisiblePosition = 37
        UltraGridColumn3435.Hidden = True
        UltraGridColumn3435.Width = 66
        UltraGridColumn3436.Header.Caption = "ErrorTipo4(39)"
        UltraGridColumn3436.Header.VisiblePosition = 55
        UltraGridColumn3436.Hidden = True
        UltraGridColumn3436.Width = 66
        UltraGridColumn3437.Header.Caption = "IndCancelaComprobPago(40)"
        UltraGridColumn3437.Header.VisiblePosition = 56
        UltraGridColumn3437.Hidden = True
        UltraGridColumn3438.Header.VisiblePosition = 61
        UltraGridColumn3438.Hidden = True
        UltraGridColumn3439.Header.VisiblePosition = 62
        UltraGridColumn3439.Hidden = True
        UltraGridColumn3440.Header.Caption = "CodPais(18)"
        UltraGridColumn3440.Header.VisiblePosition = 21
        UltraGridColumn3441.Header.Caption = "CodConvenio(31)"
        UltraGridColumn3441.Header.VisiblePosition = 35
        UltraGridColumn3442.Header.Caption = "CodTipoRenta(33)"
        UltraGridColumn3442.Header.VisiblePosition = 54
        UltraGridColumn3443.Header.Caption = "IdBeneficiario(22)"
        UltraGridColumn3443.Header.VisiblePosition = 25
        UltraGridColumn3443.Width = 80
        UltraGridColumn3444.Header.Caption = "Beneficiario(23)"
        UltraGridColumn3444.Header.VisiblePosition = 26
        UltraGridColumn3444.Width = 71
        UltraGridColumn3445.Header.Caption = "ResidenciaBeneficiario(24)"
        UltraGridColumn3445.Header.VisiblePosition = 27
        UltraGridColumn3445.Width = 119
        UltraGridColumn3446.Header.Caption = "Vínculo(25)"
        UltraGridColumn3446.Header.VisiblePosition = 28
        UltraGridColumn3446.Width = 55
        UltraGridColumn3447.Header.Caption = "RentaBruta(26)"
        UltraGridColumn3447.Header.VisiblePosition = 29
        UltraGridColumn3447.Width = 72
        UltraGridColumn3448.Header.Caption = "CostoEnajenacion(27)"
        UltraGridColumn3448.Header.VisiblePosition = 30
        UltraGridColumn3448.Width = 100
        UltraGridColumn3449.Header.Caption = "RentaNeta(28)"
        UltraGridColumn3449.Header.VisiblePosition = 31
        UltraGridColumn3449.Width = 66
        UltraGridColumn3450.Header.Caption = "TasaRetención(29)"
        UltraGridColumn3450.Header.VisiblePosition = 32
        UltraGridColumn3450.Width = 90
        UltraGridColumn3451.Header.Caption = "ImpuestoRetenido(30)"
        UltraGridColumn3451.Header.VisiblePosition = 33
        UltraGridColumn3451.Width = 102
        UltraGridColumn3452.Header.Caption = "Exoneración(32)"
        UltraGridColumn3452.Header.VisiblePosition = 36
        UltraGridColumn3452.Width = 74
        UltraGridColumn3453.Header.Caption = "ModalidadServicio(34)"
        UltraGridColumn3453.Header.VisiblePosition = 63
        UltraGridColumn3453.Width = 101
        UltraGridColumn3454.Header.Caption = "Art76(35)"
        UltraGridColumn3454.Header.VisiblePosition = 64
        UltraGridColumn3454.Width = 47
        UltraGridBand27.Columns.AddRange(New Object() {UltraGridColumn3389, UltraGridColumn3390, UltraGridColumn3391, UltraGridColumn3392, UltraGridColumn3393, UltraGridColumn3394, UltraGridColumn3395, UltraGridColumn3396, UltraGridColumn3397, UltraGridColumn3398, UltraGridColumn3399, UltraGridColumn3400, UltraGridColumn3401, UltraGridColumn3402, UltraGridColumn3403, UltraGridColumn3404, UltraGridColumn3405, UltraGridColumn3406, UltraGridColumn3407, UltraGridColumn3408, UltraGridColumn3409, UltraGridColumn3410, UltraGridColumn3411, UltraGridColumn3412, UltraGridColumn3413, UltraGridColumn3414, UltraGridColumn3415, UltraGridColumn3416, UltraGridColumn3417, UltraGridColumn3418, UltraGridColumn3419, UltraGridColumn3420, UltraGridColumn3421, UltraGridColumn3422, UltraGridColumn3423, UltraGridColumn3424, UltraGridColumn3425, UltraGridColumn3426, UltraGridColumn3427, UltraGridColumn3428, UltraGridColumn3429, UltraGridColumn3430, UltraGridColumn3431, UltraGridColumn3432, UltraGridColumn3433, UltraGridColumn3434, UltraGridColumn3435, UltraGridColumn3436, UltraGridColumn3437, UltraGridColumn3438, UltraGridColumn3439, UltraGridColumn3440, UltraGridColumn3441, UltraGridColumn3442, UltraGridColumn3443, UltraGridColumn3444, UltraGridColumn3445, UltraGridColumn3446, UltraGridColumn3447, UltraGridColumn3448, UltraGridColumn3449, UltraGridColumn3450, UltraGridColumn3451, UltraGridColumn3452, UltraGridColumn3453, UltraGridColumn3454})
        UltraGridBand27.SummaryFooterCaption = "Totales:"
        Me.griCompras2.DisplayLayout.BandsSerializer.Add(UltraGridBand27)
        Me.griCompras2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras2.DisplayLayout.MaxColScrollRegions = 1
        Me.griCompras2.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griCompras2.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griCompras2.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCompras2.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCompras2.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCompras2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCompras2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griCompras2.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCompras2.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCompras2.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCompras2.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griCompras2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCompras2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCompras2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCompras2.Location = New System.Drawing.Point(0, 0)
        Me.griCompras2.Name = "griCompras2"
        Me.griCompras2.Size = New System.Drawing.Size(1254, 249)
        Me.griCompras2.TabIndex = 6
        Me.griCompras2.Tag = ""
        Me.griCompras2.Text = "8.2 REGISTRO DE COMPRAS - INFORMACIÓN DE OPERACIONES CON SUJETOS NO DOMICILIADOS"
        '
        'UltraTabPageControl18
        '
        Me.UltraTabPageControl18.Controls.Add(Me.griCompras3)
        Me.UltraTabPageControl18.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl18.Name = "UltraTabPageControl18"
        Me.UltraTabPageControl18.Size = New System.Drawing.Size(1254, 249)
        '
        'griCompras3
        '
        Me.griCompras3.AllowDrop = True
        Me.griCompras3.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn3455.Header.VisiblePosition = 0
        UltraGridColumn3455.Hidden = True
        UltraGridColumn3456.Header.VisiblePosition = 1
        UltraGridColumn3456.Hidden = True
        UltraGridColumn3457.Header.VisiblePosition = 2
        UltraGridColumn3457.Hidden = True
        UltraGridColumn3458.Header.Caption = "Periodo(1)"
        UltraGridColumn3458.Header.VisiblePosition = 3
        UltraGridColumn3458.Width = 60
        UltraGridColumn3459.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn3459.Header.VisiblePosition = 5
        UltraGridColumn3459.Width = 74
        UltraGridColumn3460.Header.Caption = "F.Emision(4)"
        UltraGridColumn3460.Header.VisiblePosition = 6
        UltraGridColumn3460.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3460.Width = 60
        UltraGridColumn3461.Header.Caption = "F.Vencimiento(5)"
        UltraGridColumn3461.Header.VisiblePosition = 7
        UltraGridColumn3461.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3461.Width = 79
        UltraGridColumn3462.Header.Caption = "T.D(6)"
        UltraGridColumn3462.Header.VisiblePosition = 8
        UltraGridColumn3462.Width = 36
        UltraGridColumn3463.Header.Caption = "Serie(7)"
        UltraGridColumn3463.Header.VisiblePosition = 9
        UltraGridColumn3463.Width = 40
        UltraGridColumn3464.Header.Caption = "A.DUA"
        UltraGridColumn3464.Header.VisiblePosition = 10
        UltraGridColumn3464.Hidden = True
        UltraGridColumn3464.Width = 48
        UltraGridColumn3465.Header.Caption = "N°Doc.I.(8)"
        UltraGridColumn3465.Header.VisiblePosition = 11
        UltraGridColumn3465.Width = 70
        UltraGridColumn3466.Header.Caption = "N°Doc.F.(9)"
        UltraGridColumn3466.Header.VisiblePosition = 12
        UltraGridColumn3466.Width = 70
        UltraGridColumn3467.Header.Caption = "T.D.I(10)"
        UltraGridColumn3467.Header.VisiblePosition = 13
        UltraGridColumn3467.Width = 43
        UltraGridColumn3468.Header.Caption = "N°Doc.I(11)"
        UltraGridColumn3468.Header.VisiblePosition = 14
        UltraGridColumn3468.Width = 70
        UltraGridColumn3469.Header.Caption = "Razon Social(12)"
        UltraGridColumn3469.Header.VisiblePosition = 15
        Appearance105.TextHAlignAsString = "Right"
        UltraGridColumn3470.CellAppearance = Appearance105
        UltraGridColumn3470.Header.Caption = "G. y/o E. B.I(13)"
        UltraGridColumn3470.Header.VisiblePosition = 16
        UltraGridColumn3470.MaskInput = "{double:-9.2}"
        UltraGridColumn3470.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3470.Width = 75
        Appearance106.TextHAlignAsString = "Right"
        UltraGridColumn3471.CellAppearance = Appearance106
        UltraGridColumn3471.Header.Caption = "G. y/o E. IGV(14)"
        UltraGridColumn3471.Header.VisiblePosition = 17
        UltraGridColumn3471.MaskInput = "{double:-7.2}"
        UltraGridColumn3471.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3471.Width = 78
        Appearance107.TextHAlignAsString = "Right"
        UltraGridColumn3472.CellAppearance = Appearance107
        UltraGridColumn3472.Header.Caption = "G. y No G. B.I(16)"
        UltraGridColumn3472.Header.VisiblePosition = 18
        UltraGridColumn3472.Hidden = True
        UltraGridColumn3472.MaskInput = "{double:-9.2}"
        UltraGridColumn3472.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3472.Width = 79
        Appearance108.TextHAlignAsString = "Right"
        UltraGridColumn3473.CellAppearance = Appearance108
        UltraGridColumn3473.Header.Caption = "G. No G. IGV(15)"
        UltraGridColumn3473.Header.VisiblePosition = 19
        UltraGridColumn3473.MaskInput = "{double:-7.2}"
        UltraGridColumn3473.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3473.Width = 80
        Appearance109.TextHAlignAsString = "Right"
        UltraGridColumn3474.CellAppearance = Appearance109
        UltraGridColumn3474.Header.Caption = "No G. B.I(18)"
        UltraGridColumn3474.Header.VisiblePosition = 20
        UltraGridColumn3474.Hidden = True
        UltraGridColumn3474.MaskInput = "{double:-9.2}"
        UltraGridColumn3474.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3474.Width = 70
        Appearance110.TextHAlignAsString = "Right"
        UltraGridColumn3475.CellAppearance = Appearance110
        UltraGridColumn3475.Header.Caption = "No G. IGV(19)"
        UltraGridColumn3475.Header.VisiblePosition = 21
        UltraGridColumn3475.Hidden = True
        UltraGridColumn3475.MaskInput = "{double:-7.2}"
        UltraGridColumn3475.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3475.Width = 69
        Appearance111.TextHAlignAsString = "Right"
        UltraGridColumn3476.CellAppearance = Appearance111
        UltraGridColumn3476.Header.Caption = "Valor No G.(20)"
        UltraGridColumn3476.Header.VisiblePosition = 22
        UltraGridColumn3476.Hidden = True
        UltraGridColumn3476.MaskInput = "{double:-7.2}"
        UltraGridColumn3476.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3476.Width = 74
        Appearance112.TextHAlignAsString = "Right"
        UltraGridColumn3477.CellAppearance = Appearance112
        UltraGridColumn3477.Header.Caption = "ISC(21)"
        UltraGridColumn3477.Header.VisiblePosition = 23
        UltraGridColumn3477.Hidden = True
        UltraGridColumn3477.MaskInput = "{double:-7.2}"
        UltraGridColumn3477.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3477.Width = 60
        Appearance113.TextHAlignAsString = "Right"
        UltraGridColumn3478.CellAppearance = Appearance113
        UltraGridColumn3478.Header.Caption = "O.Tributos(22)"
        UltraGridColumn3478.Header.VisiblePosition = 24
        UltraGridColumn3478.Hidden = True
        UltraGridColumn3478.MaskInput = "{double:-7.2}"
        UltraGridColumn3478.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3478.Width = 69
        Appearance114.TextHAlignAsString = "Right"
        UltraGridColumn3479.CellAppearance = Appearance114
        UltraGridColumn3479.Header.Caption = "Importe Total(16)"
        UltraGridColumn3479.Header.VisiblePosition = 25
        UltraGridColumn3479.MaskInput = "{double:-9.2}"
        UltraGridColumn3479.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3479.Width = 79
        Appearance115.TextHAlignAsString = "Right"
        UltraGridColumn3480.CellAppearance = Appearance115
        UltraGridColumn3480.Header.Caption = "T.C.(18)"
        UltraGridColumn3480.Header.VisiblePosition = 27
        UltraGridColumn3480.MaskInput = "{double:1.3}"
        UltraGridColumn3480.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3480.Width = 40
        UltraGridColumn3481.Header.Caption = "F.E. C.M(19)"
        UltraGridColumn3481.Header.VisiblePosition = 28
        UltraGridColumn3481.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3481.Width = 60
        UltraGridColumn3482.Header.Caption = "TDM(20)"
        UltraGridColumn3482.Header.VisiblePosition = 29
        UltraGridColumn3482.Width = 42
        UltraGridColumn3483.Header.Caption = "Serie M(21)"
        UltraGridColumn3483.Header.VisiblePosition = 30
        UltraGridColumn3483.Width = 56
        UltraGridColumn3484.Header.Caption = "N° D.M(22)"
        UltraGridColumn3484.Header.VisiblePosition = 32
        UltraGridColumn3484.Width = 60
        UltraGridColumn3485.Header.Caption = "N° D. E.D"
        UltraGridColumn3485.Header.VisiblePosition = 33
        UltraGridColumn3485.Hidden = True
        UltraGridColumn3485.Width = 60
        UltraGridColumn3486.Header.Caption = "F.E.Detrac.(23)"
        UltraGridColumn3486.Header.VisiblePosition = 34
        UltraGridColumn3486.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3486.Width = 71
        UltraGridColumn3487.Header.Caption = "N°Const.Detrac(24)"
        UltraGridColumn3487.Header.VisiblePosition = 35
        UltraGridColumn3487.Width = 89
        UltraGridColumn3488.Header.Caption = "R(25)"
        UltraGridColumn3488.Header.VisiblePosition = 36
        UltraGridColumn3488.Width = 30
        UltraGridColumn3489.Header.Caption = "I(31)"
        UltraGridColumn3489.Header.VisiblePosition = 44
        UltraGridColumn3489.Width = 35
        UltraGridColumn3490.Header.VisiblePosition = 45
        UltraGridColumn3490.Hidden = True
        UltraGridColumn3491.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn3491.Header.VisiblePosition = 4
        UltraGridColumn3491.Width = 150
        UltraGridColumn3492.Header.Caption = "DUA DSI(29)"
        UltraGridColumn3492.Header.VisiblePosition = 31
        UltraGridColumn3492.Hidden = True
        UltraGridColumn3492.Width = 64
        UltraGridColumn3493.Header.VisiblePosition = 46
        UltraGridColumn3493.Hidden = True
        UltraGridColumn3494.Header.VisiblePosition = 47
        UltraGridColumn3494.Hidden = True
        UltraGridColumn3495.Header.VisiblePosition = 48
        UltraGridColumn3495.Hidden = True
        UltraGridColumn3496.Header.Caption = "CodigoMoneda(17)"
        UltraGridColumn3496.Header.VisiblePosition = 26
        UltraGridColumn3496.Width = 89
        UltraGridColumn3497.Header.Caption = "B/S(26)"
        UltraGridColumn3497.Header.VisiblePosition = 37
        UltraGridColumn3497.Width = 47
        UltraGridColumn3498.Header.Caption = "IdentificacionContratoProy(35)"
        UltraGridColumn3498.Header.VisiblePosition = 38
        UltraGridColumn3498.Hidden = True
        UltraGridColumn3499.Header.Caption = "ErrorTipo1(27)"
        UltraGridColumn3499.Header.VisiblePosition = 39
        UltraGridColumn3499.Width = 68
        UltraGridColumn3500.Header.Caption = "ErrorTipo2(28)"
        UltraGridColumn3500.Header.VisiblePosition = 40
        UltraGridColumn3500.Width = 66
        UltraGridColumn3501.Header.Caption = "ErrorTipo3(29)"
        UltraGridColumn3501.Header.VisiblePosition = 41
        UltraGridColumn3501.Width = 66
        UltraGridColumn3502.Header.Caption = "ErrorTipo4(39)"
        UltraGridColumn3502.Header.VisiblePosition = 42
        UltraGridColumn3502.Hidden = True
        UltraGridColumn3502.Width = 66
        UltraGridColumn3503.Header.Caption = "IndCancelaComprobPago(30)"
        UltraGridColumn3503.Header.VisiblePosition = 43
        UltraGridColumn3503.Width = 131
        UltraGridColumn3504.Header.VisiblePosition = 49
        UltraGridColumn3504.Hidden = True
        UltraGridColumn3505.Header.VisiblePosition = 50
        UltraGridColumn3505.Hidden = True
        UltraGridColumn3506.Header.VisiblePosition = 51
        UltraGridColumn3506.Hidden = True
        UltraGridColumn3507.Header.VisiblePosition = 52
        UltraGridColumn3507.Hidden = True
        UltraGridColumn3508.Header.VisiblePosition = 53
        UltraGridColumn3508.Hidden = True
        UltraGridBand28.Columns.AddRange(New Object() {UltraGridColumn3455, UltraGridColumn3456, UltraGridColumn3457, UltraGridColumn3458, UltraGridColumn3459, UltraGridColumn3460, UltraGridColumn3461, UltraGridColumn3462, UltraGridColumn3463, UltraGridColumn3464, UltraGridColumn3465, UltraGridColumn3466, UltraGridColumn3467, UltraGridColumn3468, UltraGridColumn3469, UltraGridColumn3470, UltraGridColumn3471, UltraGridColumn3472, UltraGridColumn3473, UltraGridColumn3474, UltraGridColumn3475, UltraGridColumn3476, UltraGridColumn3477, UltraGridColumn3478, UltraGridColumn3479, UltraGridColumn3480, UltraGridColumn3481, UltraGridColumn3482, UltraGridColumn3483, UltraGridColumn3484, UltraGridColumn3485, UltraGridColumn3486, UltraGridColumn3487, UltraGridColumn3488, UltraGridColumn3489, UltraGridColumn3490, UltraGridColumn3491, UltraGridColumn3492, UltraGridColumn3493, UltraGridColumn3494, UltraGridColumn3495, UltraGridColumn3496, UltraGridColumn3497, UltraGridColumn3498, UltraGridColumn3499, UltraGridColumn3500, UltraGridColumn3501, UltraGridColumn3502, UltraGridColumn3503, UltraGridColumn3504, UltraGridColumn3505, UltraGridColumn3506, UltraGridColumn3507, UltraGridColumn3508})
        UltraGridBand28.SummaryFooterCaption = "Totales:"
        Me.griCompras3.DisplayLayout.BandsSerializer.Add(UltraGridBand28)
        Me.griCompras3.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras3.DisplayLayout.MaxColScrollRegions = 1
        Me.griCompras3.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griCompras3.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras3.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCompras3.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griCompras3.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griCompras3.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCompras3.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCompras3.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCompras3.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griCompras3.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCompras3.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCompras3.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCompras3.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griCompras3.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCompras3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCompras3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCompras3.Location = New System.Drawing.Point(0, 0)
        Me.griCompras3.Name = "griCompras3"
        Me.griCompras3.Size = New System.Drawing.Size(1254, 249)
        Me.griCompras3.TabIndex = 6
        Me.griCompras3.Tag = ""
        Me.griCompras3.Text = "8.3 REGISTRO DE COMPRAS SIMPLIFICADO"
        '
        'UltraTabPageControl44
        '
        Me.UltraTabPageControl44.Controls.Add(Me.gridCostos)
        Me.UltraTabPageControl44.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl44.Name = "UltraTabPageControl44"
        Me.UltraTabPageControl44.Size = New System.Drawing.Size(1256, 251)
        '
        'gridCostos
        '
        Me.gridCostos.AllowDrop = True
        Me.gridCostos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridCostos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCostos.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridCostos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridCostos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCostos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCostos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.gridCostos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCostos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridCostos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCostos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridCostos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.gridCostos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCostos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridCostos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridCostos.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.gridCostos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridCostos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCostos.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridCostos.Location = New System.Drawing.Point(0, 0)
        Me.gridCostos.Name = "gridCostos"
        Me.gridCostos.Size = New System.Drawing.Size(1256, 251)
        Me.gridCostos.TabIndex = 2
        Me.gridCostos.Text = "10.1 Estado de Costos Mensual"
        '
        'UltraTabPageControl45
        '
        Me.UltraTabPageControl45.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl45.Name = "UltraTabPageControl45"
        Me.UltraTabPageControl45.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl46
        '
        Me.UltraTabPageControl46.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl46.Name = "UltraTabPageControl46"
        Me.UltraTabPageControl46.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl47
        '
        Me.UltraTabPageControl47.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl47.Name = "UltraTabPageControl47"
        Me.UltraTabPageControl47.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl19
        '
        Me.UltraTabPageControl19.Controls.Add(Me.griDetalleVentas)
        Me.UltraTabPageControl19.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl19.Name = "UltraTabPageControl19"
        Me.UltraTabPageControl19.Size = New System.Drawing.Size(1254, 249)
        '
        'griDetalleVentas
        '
        Me.griDetalleVentas.AllowDrop = True
        Me.griDetalleVentas.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn3509.Header.VisiblePosition = 0
        UltraGridColumn3509.Hidden = True
        UltraGridColumn3510.Header.VisiblePosition = 1
        UltraGridColumn3510.Hidden = True
        UltraGridColumn3511.Header.VisiblePosition = 2
        UltraGridColumn3511.Hidden = True
        UltraGridColumn3512.Header.Caption = "Periodo(1)"
        UltraGridColumn3512.Header.VisiblePosition = 3
        UltraGridColumn3512.Width = 60
        UltraGridColumn3513.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn3513.Header.VisiblePosition = 5
        UltraGridColumn3513.Width = 73
        UltraGridColumn3514.Header.Caption = "F.Emision(4)"
        UltraGridColumn3514.Header.VisiblePosition = 6
        UltraGridColumn3514.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3514.Width = 60
        UltraGridColumn3515.Header.Caption = "F.Vencimiento(5)"
        UltraGridColumn3515.Header.VisiblePosition = 7
        UltraGridColumn3515.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3515.Width = 80
        UltraGridColumn3516.Header.Caption = "T.D(6)"
        UltraGridColumn3516.Header.VisiblePosition = 8
        UltraGridColumn3516.Width = 34
        UltraGridColumn3517.Header.Caption = "Serie(7)"
        UltraGridColumn3517.Header.VisiblePosition = 9
        UltraGridColumn3517.Width = 40
        UltraGridColumn3518.Header.Caption = "A.DUA"
        UltraGridColumn3518.Header.VisiblePosition = 10
        UltraGridColumn3518.Hidden = True
        UltraGridColumn3518.Width = 40
        UltraGridColumn3519.Header.Caption = "N°Doc.I.(8)"
        UltraGridColumn3519.Header.VisiblePosition = 11
        UltraGridColumn3519.Width = 70
        UltraGridColumn3520.Header.Caption = "N°Doc.F.(9)"
        UltraGridColumn3520.Header.VisiblePosition = 12
        UltraGridColumn3520.Width = 70
        UltraGridColumn3521.Header.Caption = "T.D.I(10)"
        UltraGridColumn3521.Header.VisiblePosition = 13
        UltraGridColumn3521.Width = 44
        UltraGridColumn3522.Header.Caption = "N°Doc.I(11)"
        UltraGridColumn3522.Header.VisiblePosition = 14
        UltraGridColumn3522.Width = 70
        UltraGridColumn3523.Header.Caption = "Razon Social(12)"
        UltraGridColumn3523.Header.VisiblePosition = 15
        Appearance116.TextHAlignAsString = "Right"
        UltraGridColumn3524.CellAppearance = Appearance116
        UltraGridColumn3524.Header.Caption = "Valor Exp(13)"
        UltraGridColumn3524.Header.VisiblePosition = 16
        UltraGridColumn3524.MaskInput = "{double:-9.2}"
        UltraGridColumn3524.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3524.Width = 70
        Appearance117.TextHAlignAsString = "Right"
        UltraGridColumn3525.CellAppearance = Appearance117
        UltraGridColumn3525.Header.Caption = "B.I Ope.G(14)"
        UltraGridColumn3525.Header.VisiblePosition = 17
        UltraGridColumn3525.MaskInput = "{double:-9.2}"
        UltraGridColumn3525.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3525.Width = 70
        Appearance118.TextHAlignAsString = "Right"
        UltraGridColumn3526.CellAppearance = Appearance118
        UltraGridColumn3526.Header.Caption = "I.Total O.E(18)"
        UltraGridColumn3526.Header.VisiblePosition = 21
        UltraGridColumn3526.MaskInput = "{double:-9.2}"
        UltraGridColumn3526.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3526.Width = 70
        Appearance119.TextHAlignAsString = "Right"
        UltraGridColumn3527.CellAppearance = Appearance119
        UltraGridColumn3527.Header.Caption = "I.Total O.I(19)"
        UltraGridColumn3527.Header.VisiblePosition = 22
        UltraGridColumn3527.MaskInput = "{double:-7.2}"
        UltraGridColumn3527.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3527.Width = 70
        Appearance120.TextHAlignAsString = "Right"
        UltraGridColumn3528.CellAppearance = Appearance120
        UltraGridColumn3528.Header.Caption = "Impuesto S(20)"
        UltraGridColumn3528.Header.VisiblePosition = 23
        UltraGridColumn3528.MaskInput = "{double:-9.2}"
        UltraGridColumn3528.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3528.Width = 70
        Appearance121.TextHAlignAsString = "Right"
        UltraGridColumn3529.CellAppearance = Appearance121
        UltraGridColumn3529.Header.Caption = "Impuesto G(16)"
        UltraGridColumn3529.Header.VisiblePosition = 19
        UltraGridColumn3529.MaskInput = "{double:-9.2}"
        UltraGridColumn3529.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3529.Width = 70
        Appearance122.TextHAlignAsString = "Right"
        UltraGridColumn3530.CellAppearance = Appearance122
        UltraGridColumn3530.Header.Caption = "Base I. Arroz(21)"
        UltraGridColumn3530.Header.VisiblePosition = 24
        UltraGridColumn3530.MaskInput = "{double:-7.2}"
        UltraGridColumn3530.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3530.Width = 77
        Appearance123.TextHAlignAsString = "Right"
        UltraGridColumn3531.CellAppearance = Appearance123
        UltraGridColumn3531.Header.Caption = "Impuesto Arroz(22)"
        UltraGridColumn3531.Header.VisiblePosition = 25
        UltraGridColumn3531.MaskInput = "{double:-9.2}"
        UltraGridColumn3531.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3531.Width = 86
        Appearance124.TextHAlignAsString = "Right"
        UltraGridColumn3532.CellAppearance = Appearance124
        UltraGridColumn3532.Header.Caption = "O.Tributos(23)"
        UltraGridColumn3532.Header.VisiblePosition = 26
        UltraGridColumn3532.MaskInput = "{double:-7.2}"
        UltraGridColumn3532.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3532.Width = 66
        Appearance125.TextHAlignAsString = "Right"
        UltraGridColumn3533.CellAppearance = Appearance125
        UltraGridColumn3533.Header.Caption = "Importe Total(24)"
        UltraGridColumn3533.Header.VisiblePosition = 27
        UltraGridColumn3533.MaskInput = "{double:-9.2}"
        UltraGridColumn3533.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3533.Width = 77
        Appearance126.TextHAlignAsString = "Right"
        UltraGridColumn3534.CellAppearance = Appearance126
        UltraGridColumn3534.Header.Caption = "T.C.(26)"
        UltraGridColumn3534.Header.VisiblePosition = 29
        UltraGridColumn3534.MaskInput = "{double:1.3}"
        UltraGridColumn3534.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3534.Width = 40
        UltraGridColumn3535.Header.Caption = "F.E. C.M(27)"
        UltraGridColumn3535.Header.VisiblePosition = 30
        UltraGridColumn3535.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3535.Width = 60
        UltraGridColumn3536.Header.Caption = "TDM(28)"
        UltraGridColumn3536.Header.VisiblePosition = 31
        UltraGridColumn3536.Width = 43
        UltraGridColumn3537.Header.Caption = "Serie M(29)"
        UltraGridColumn3537.Header.VisiblePosition = 32
        UltraGridColumn3537.Width = 55
        UltraGridColumn3538.Header.Caption = "N° D.M(30)"
        UltraGridColumn3538.Header.VisiblePosition = 33
        UltraGridColumn3538.Width = 60
        UltraGridColumn3539.Header.Caption = "N° D. E.D"
        UltraGridColumn3539.Header.VisiblePosition = 34
        UltraGridColumn3539.Hidden = True
        UltraGridColumn3539.Width = 60
        UltraGridColumn3540.Header.Caption = "F.E.Detrac."
        UltraGridColumn3540.Header.VisiblePosition = 35
        UltraGridColumn3540.Hidden = True
        UltraGridColumn3540.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3540.Width = 60
        UltraGridColumn3541.Header.Caption = "N°Const.Detrac"
        UltraGridColumn3541.Header.VisiblePosition = 36
        UltraGridColumn3541.Hidden = True
        UltraGridColumn3541.Width = 70
        UltraGridColumn3542.Header.Caption = "R"
        UltraGridColumn3542.Header.VisiblePosition = 37
        UltraGridColumn3542.Hidden = True
        UltraGridColumn3542.Width = 20
        UltraGridColumn3543.Header.Caption = "I(34)"
        UltraGridColumn3543.Header.VisiblePosition = 42
        UltraGridColumn3543.Width = 29
        UltraGridColumn3544.Header.VisiblePosition = 43
        UltraGridColumn3544.Hidden = True
        UltraGridColumn3545.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn3545.Header.VisiblePosition = 4
        UltraGridColumn3545.Width = 150
        UltraGridColumn3546.Header.Caption = "FOB"
        UltraGridColumn3546.Header.VisiblePosition = 41
        UltraGridColumn3546.Hidden = True
        UltraGridColumn3546.Width = 50
        UltraGridColumn3547.Header.VisiblePosition = 44
        UltraGridColumn3547.Hidden = True
        UltraGridColumn3548.Header.VisiblePosition = 45
        UltraGridColumn3548.Hidden = True
        UltraGridColumn3549.Header.VisiblePosition = 46
        UltraGridColumn3549.Hidden = True
        UltraGridColumn3550.Header.Caption = "CodigoMoneda(25)"
        UltraGridColumn3550.Header.VisiblePosition = 28
        UltraGridColumn3550.Width = 87
        UltraGridColumn3551.Header.VisiblePosition = 47
        UltraGridColumn3551.Hidden = True
        UltraGridColumn3552.Header.Caption = "IdentificacionContratoProy(31)"
        UltraGridColumn3552.Header.VisiblePosition = 38
        UltraGridColumn3552.Width = 133
        UltraGridColumn3553.Header.Caption = "ErrorTipo1(32)"
        UltraGridColumn3553.Header.VisiblePosition = 39
        UltraGridColumn3553.Width = 69
        UltraGridColumn3554.Header.VisiblePosition = 48
        UltraGridColumn3554.Hidden = True
        UltraGridColumn3555.Header.VisiblePosition = 49
        UltraGridColumn3555.Hidden = True
        UltraGridColumn3556.Header.VisiblePosition = 50
        UltraGridColumn3556.Hidden = True
        UltraGridColumn3557.Header.Caption = "IndCancelaComprobPago(33)"
        UltraGridColumn3557.Header.VisiblePosition = 40
        UltraGridColumn3557.Width = 129
        UltraGridColumn3558.Header.Caption = "DsctoBaseImp(15)"
        UltraGridColumn3558.Header.VisiblePosition = 18
        UltraGridColumn3559.Header.Caption = "DsctoIGV(17)"
        UltraGridColumn3559.Header.VisiblePosition = 20
        UltraGridColumn3560.Header.VisiblePosition = 51
        UltraGridColumn3560.Hidden = True
        UltraGridColumn3561.Header.VisiblePosition = 52
        UltraGridColumn3561.Hidden = True
        UltraGridColumn3562.Header.VisiblePosition = 53
        UltraGridColumn3562.Hidden = True
        UltraGridBand29.Columns.AddRange(New Object() {UltraGridColumn3509, UltraGridColumn3510, UltraGridColumn3511, UltraGridColumn3512, UltraGridColumn3513, UltraGridColumn3514, UltraGridColumn3515, UltraGridColumn3516, UltraGridColumn3517, UltraGridColumn3518, UltraGridColumn3519, UltraGridColumn3520, UltraGridColumn3521, UltraGridColumn3522, UltraGridColumn3523, UltraGridColumn3524, UltraGridColumn3525, UltraGridColumn3526, UltraGridColumn3527, UltraGridColumn3528, UltraGridColumn3529, UltraGridColumn3530, UltraGridColumn3531, UltraGridColumn3532, UltraGridColumn3533, UltraGridColumn3534, UltraGridColumn3535, UltraGridColumn3536, UltraGridColumn3537, UltraGridColumn3538, UltraGridColumn3539, UltraGridColumn3540, UltraGridColumn3541, UltraGridColumn3542, UltraGridColumn3543, UltraGridColumn3544, UltraGridColumn3545, UltraGridColumn3546, UltraGridColumn3547, UltraGridColumn3548, UltraGridColumn3549, UltraGridColumn3550, UltraGridColumn3551, UltraGridColumn3552, UltraGridColumn3553, UltraGridColumn3554, UltraGridColumn3555, UltraGridColumn3556, UltraGridColumn3557, UltraGridColumn3558, UltraGridColumn3559, UltraGridColumn3560, UltraGridColumn3561, UltraGridColumn3562})
        UltraGridBand29.SummaryFooterCaption = "Totales:"
        Me.griDetalleVentas.DisplayLayout.BandsSerializer.Add(UltraGridBand29)
        Me.griDetalleVentas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleVentas.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleVentas.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleVentas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleVentas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleVentas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleVentas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleVentas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleVentas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleVentas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleVentas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDetalleVentas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleVentas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleVentas.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleVentas.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleVentas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleVentas.Location = New System.Drawing.Point(0, 0)
        Me.griDetalleVentas.Name = "griDetalleVentas"
        Me.griDetalleVentas.Size = New System.Drawing.Size(1254, 249)
        Me.griDetalleVentas.TabIndex = 0
        Me.griDetalleVentas.Tag = ""
        Me.griDetalleVentas.Text = "14.1 REGISTRO DE VENTAS E INGRESOS"
        '
        'UltraTabPageControl20
        '
        Me.UltraTabPageControl20.Controls.Add(Me.griVentas2)
        Me.UltraTabPageControl20.Location = New System.Drawing.Point(2, 21)
        Me.UltraTabPageControl20.Name = "UltraTabPageControl20"
        Me.UltraTabPageControl20.Size = New System.Drawing.Size(1254, 249)
        '
        'griVentas2
        '
        Me.griVentas2.AllowDrop = True
        Me.griVentas2.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn3563.Header.VisiblePosition = 0
        UltraGridColumn3563.Hidden = True
        UltraGridColumn3564.Header.VisiblePosition = 1
        UltraGridColumn3564.Hidden = True
        UltraGridColumn3565.Header.VisiblePosition = 2
        UltraGridColumn3565.Hidden = True
        UltraGridColumn3566.Header.Caption = "Periodo(1)"
        UltraGridColumn3566.Header.VisiblePosition = 3
        UltraGridColumn3566.Width = 60
        UltraGridColumn3567.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn3567.Header.VisiblePosition = 5
        UltraGridColumn3567.Width = 73
        UltraGridColumn3568.Header.Caption = "F.Emision(4)"
        UltraGridColumn3568.Header.VisiblePosition = 6
        UltraGridColumn3568.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3568.Width = 60
        UltraGridColumn3569.Header.Caption = "F.Vencimiento(5)"
        UltraGridColumn3569.Header.VisiblePosition = 7
        UltraGridColumn3569.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3569.Width = 80
        UltraGridColumn3570.Header.Caption = "T.D(6)"
        UltraGridColumn3570.Header.VisiblePosition = 8
        UltraGridColumn3570.Width = 34
        UltraGridColumn3571.Header.Caption = "Serie(7)"
        UltraGridColumn3571.Header.VisiblePosition = 9
        UltraGridColumn3571.Width = 40
        UltraGridColumn3572.Header.Caption = "A.DUA"
        UltraGridColumn3572.Header.VisiblePosition = 10
        UltraGridColumn3572.Hidden = True
        UltraGridColumn3572.Width = 40
        UltraGridColumn3573.Header.Caption = "N°Doc.I.(8)"
        UltraGridColumn3573.Header.VisiblePosition = 11
        UltraGridColumn3573.Width = 70
        UltraGridColumn3574.Header.Caption = "N°Doc.F.(9)"
        UltraGridColumn3574.Header.VisiblePosition = 12
        UltraGridColumn3574.Width = 70
        UltraGridColumn3575.Header.Caption = "T.D.I(10)"
        UltraGridColumn3575.Header.VisiblePosition = 13
        UltraGridColumn3575.Width = 44
        UltraGridColumn3576.Header.Caption = "N°Doc.I(11)"
        UltraGridColumn3576.Header.VisiblePosition = 14
        UltraGridColumn3576.Width = 70
        UltraGridColumn3577.Header.Caption = "Razon Social(12)"
        UltraGridColumn3577.Header.VisiblePosition = 15
        Appearance127.TextHAlignAsString = "Right"
        UltraGridColumn3578.CellAppearance = Appearance127
        UltraGridColumn3578.Header.Caption = "Valor Exp(13)"
        UltraGridColumn3578.Header.VisiblePosition = 16
        UltraGridColumn3578.Hidden = True
        UltraGridColumn3578.MaskInput = "{double:-9.2}"
        UltraGridColumn3578.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3578.Width = 70
        Appearance128.TextHAlignAsString = "Right"
        UltraGridColumn3579.CellAppearance = Appearance128
        UltraGridColumn3579.Header.Caption = "B.I Ope.G(13)"
        UltraGridColumn3579.Header.VisiblePosition = 17
        UltraGridColumn3579.MaskInput = "{double:-9.2}"
        UltraGridColumn3579.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3579.Width = 70
        Appearance129.TextHAlignAsString = "Right"
        UltraGridColumn3580.CellAppearance = Appearance129
        UltraGridColumn3580.Header.Caption = "I.Total O.E(18)"
        UltraGridColumn3580.Header.VisiblePosition = 21
        UltraGridColumn3580.Hidden = True
        UltraGridColumn3580.MaskInput = "{double:-9.2}"
        UltraGridColumn3580.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3580.Width = 70
        Appearance130.TextHAlignAsString = "Right"
        UltraGridColumn3581.CellAppearance = Appearance130
        UltraGridColumn3581.Header.Caption = "I.Total O.I(19)"
        UltraGridColumn3581.Header.VisiblePosition = 22
        UltraGridColumn3581.Hidden = True
        UltraGridColumn3581.MaskInput = "{double:-7.2}"
        UltraGridColumn3581.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3581.Width = 70
        Appearance131.TextHAlignAsString = "Right"
        UltraGridColumn3582.CellAppearance = Appearance131
        UltraGridColumn3582.Header.Caption = "Impuesto S(20)"
        UltraGridColumn3582.Header.VisiblePosition = 23
        UltraGridColumn3582.Hidden = True
        UltraGridColumn3582.MaskInput = "{double:-9.2}"
        UltraGridColumn3582.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3582.Width = 70
        Appearance132.TextHAlignAsString = "Right"
        UltraGridColumn3583.CellAppearance = Appearance132
        UltraGridColumn3583.Header.Caption = "Impuesto G(14)"
        UltraGridColumn3583.Header.VisiblePosition = 19
        UltraGridColumn3583.MaskInput = "{double:-9.2}"
        UltraGridColumn3583.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3583.Width = 70
        Appearance133.TextHAlignAsString = "Right"
        UltraGridColumn3584.CellAppearance = Appearance133
        UltraGridColumn3584.Header.Caption = "Base I. Arroz(21)"
        UltraGridColumn3584.Header.VisiblePosition = 24
        UltraGridColumn3584.Hidden = True
        UltraGridColumn3584.MaskInput = "{double:-7.2}"
        UltraGridColumn3584.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3584.Width = 77
        Appearance134.TextHAlignAsString = "Right"
        UltraGridColumn3585.CellAppearance = Appearance134
        UltraGridColumn3585.Header.Caption = "Impuesto Arroz(22)"
        UltraGridColumn3585.Header.VisiblePosition = 25
        UltraGridColumn3585.Hidden = True
        UltraGridColumn3585.MaskInput = "{double:-9.2}"
        UltraGridColumn3585.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3585.Width = 86
        Appearance135.TextHAlignAsString = "Right"
        UltraGridColumn3586.CellAppearance = Appearance135
        UltraGridColumn3586.Header.Caption = "O.Tributos(15)"
        UltraGridColumn3586.Header.VisiblePosition = 26
        UltraGridColumn3586.MaskInput = "{double:-7.2}"
        UltraGridColumn3586.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3586.Width = 66
        Appearance136.TextHAlignAsString = "Right"
        UltraGridColumn3587.CellAppearance = Appearance136
        UltraGridColumn3587.Header.Caption = "Importe Total(16)"
        UltraGridColumn3587.Header.VisiblePosition = 27
        UltraGridColumn3587.MaskInput = "{double:-9.2}"
        UltraGridColumn3587.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3587.Width = 77
        Appearance137.TextHAlignAsString = "Right"
        UltraGridColumn3588.CellAppearance = Appearance137
        UltraGridColumn3588.Header.Caption = "T.C.(18)"
        UltraGridColumn3588.Header.VisiblePosition = 29
        UltraGridColumn3588.MaskInput = "{double:1.3}"
        UltraGridColumn3588.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn3588.Width = 40
        UltraGridColumn3589.Header.Caption = "F.E. C.M(19)"
        UltraGridColumn3589.Header.VisiblePosition = 30
        UltraGridColumn3589.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3589.Width = 60
        UltraGridColumn3590.Header.Caption = "TDM(20)"
        UltraGridColumn3590.Header.VisiblePosition = 31
        UltraGridColumn3590.Width = 43
        UltraGridColumn3591.Header.Caption = "Serie M(21)"
        UltraGridColumn3591.Header.VisiblePosition = 32
        UltraGridColumn3591.Width = 55
        UltraGridColumn3592.Header.Caption = "N° D.M(22)"
        UltraGridColumn3592.Header.VisiblePosition = 33
        UltraGridColumn3592.Width = 60
        UltraGridColumn3593.Header.Caption = "N° D. E.D"
        UltraGridColumn3593.Header.VisiblePosition = 34
        UltraGridColumn3593.Hidden = True
        UltraGridColumn3593.Width = 60
        UltraGridColumn3594.Header.Caption = "F.E.Detrac."
        UltraGridColumn3594.Header.VisiblePosition = 35
        UltraGridColumn3594.Hidden = True
        UltraGridColumn3594.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn3594.Width = 60
        UltraGridColumn3595.Header.Caption = "N°Const.Detrac"
        UltraGridColumn3595.Header.VisiblePosition = 36
        UltraGridColumn3595.Hidden = True
        UltraGridColumn3595.Width = 70
        UltraGridColumn3596.Header.Caption = "R"
        UltraGridColumn3596.Header.VisiblePosition = 37
        UltraGridColumn3596.Hidden = True
        UltraGridColumn3596.Width = 20
        UltraGridColumn3597.Header.Caption = "I(25)"
        UltraGridColumn3597.Header.VisiblePosition = 42
        UltraGridColumn3597.Width = 29
        UltraGridColumn3598.Header.VisiblePosition = 43
        UltraGridColumn3598.Hidden = True
        UltraGridColumn3599.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn3599.Header.VisiblePosition = 4
        UltraGridColumn3599.Width = 150
        UltraGridColumn3600.Header.Caption = "FOB"
        UltraGridColumn3600.Header.VisiblePosition = 41
        UltraGridColumn3600.Hidden = True
        UltraGridColumn3600.Width = 50
        UltraGridColumn3601.Header.VisiblePosition = 44
        UltraGridColumn3601.Hidden = True
        UltraGridColumn3602.Header.VisiblePosition = 45
        UltraGridColumn3602.Hidden = True
        UltraGridColumn3603.Header.VisiblePosition = 46
        UltraGridColumn3603.Hidden = True
        UltraGridColumn3604.Header.Caption = "CodigoMoneda(17)"
        UltraGridColumn3604.Header.VisiblePosition = 28
        UltraGridColumn3604.Width = 87
        UltraGridColumn3605.Header.VisiblePosition = 47
        UltraGridColumn3605.Hidden = True
        UltraGridColumn3606.Header.Caption = "IdentificacionContratoProy(31)"
        UltraGridColumn3606.Header.VisiblePosition = 38
        UltraGridColumn3606.Hidden = True
        UltraGridColumn3606.Width = 133
        UltraGridColumn3607.Header.Caption = "ErrorTipo1(23)"
        UltraGridColumn3607.Header.VisiblePosition = 39
        UltraGridColumn3607.Width = 69
        UltraGridColumn3608.Header.VisiblePosition = 48
        UltraGridColumn3608.Hidden = True
        UltraGridColumn3609.Header.VisiblePosition = 49
        UltraGridColumn3609.Hidden = True
        UltraGridColumn3610.Header.VisiblePosition = 50
        UltraGridColumn3610.Hidden = True
        UltraGridColumn3611.Header.Caption = "IndCancelaComprobPago(24)"
        UltraGridColumn3611.Header.VisiblePosition = 40
        UltraGridColumn3611.Width = 129
        UltraGridColumn3612.Header.Caption = "DsctoBaseImp(15)"
        UltraGridColumn3612.Header.VisiblePosition = 18
        UltraGridColumn3612.Hidden = True
        UltraGridColumn3613.Header.Caption = "DsctoIGV(17)"
        UltraGridColumn3613.Header.VisiblePosition = 20
        UltraGridColumn3613.Hidden = True
        UltraGridColumn3614.Header.VisiblePosition = 51
        UltraGridColumn3614.Hidden = True
        UltraGridColumn3615.Header.VisiblePosition = 52
        UltraGridColumn3615.Hidden = True
        UltraGridColumn3616.Header.VisiblePosition = 53
        UltraGridColumn3616.Hidden = True
        UltraGridBand30.Columns.AddRange(New Object() {UltraGridColumn3563, UltraGridColumn3564, UltraGridColumn3565, UltraGridColumn3566, UltraGridColumn3567, UltraGridColumn3568, UltraGridColumn3569, UltraGridColumn3570, UltraGridColumn3571, UltraGridColumn3572, UltraGridColumn3573, UltraGridColumn3574, UltraGridColumn3575, UltraGridColumn3576, UltraGridColumn3577, UltraGridColumn3578, UltraGridColumn3579, UltraGridColumn3580, UltraGridColumn3581, UltraGridColumn3582, UltraGridColumn3583, UltraGridColumn3584, UltraGridColumn3585, UltraGridColumn3586, UltraGridColumn3587, UltraGridColumn3588, UltraGridColumn3589, UltraGridColumn3590, UltraGridColumn3591, UltraGridColumn3592, UltraGridColumn3593, UltraGridColumn3594, UltraGridColumn3595, UltraGridColumn3596, UltraGridColumn3597, UltraGridColumn3598, UltraGridColumn3599, UltraGridColumn3600, UltraGridColumn3601, UltraGridColumn3602, UltraGridColumn3603, UltraGridColumn3604, UltraGridColumn3605, UltraGridColumn3606, UltraGridColumn3607, UltraGridColumn3608, UltraGridColumn3609, UltraGridColumn3610, UltraGridColumn3611, UltraGridColumn3612, UltraGridColumn3613, UltraGridColumn3614, UltraGridColumn3615, UltraGridColumn3616})
        UltraGridBand30.SummaryFooterCaption = "Totales:"
        Me.griVentas2.DisplayLayout.BandsSerializer.Add(UltraGridBand30)
        Me.griVentas2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVentas2.DisplayLayout.MaxColScrollRegions = 1
        Me.griVentas2.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griVentas2.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVentas2.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVentas2.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griVentas2.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVentas2.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griVentas2.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVentas2.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVentas2.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griVentas2.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVentas2.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griVentas2.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griVentas2.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griVentas2.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griVentas2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVentas2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVentas2.Location = New System.Drawing.Point(0, 0)
        Me.griVentas2.Name = "griVentas2"
        Me.griVentas2.Size = New System.Drawing.Size(1254, 249)
        Me.griVentas2.TabIndex = 7
        Me.griVentas2.Tag = ""
        Me.griVentas2.Text = "14.2 REGISTRO DE VENTAS E INGRESOS SIMPLIFICADO"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.gridCajaBancos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1258, 272)
        '
        'gridCajaBancos
        '
        Appearance138.BackColor = System.Drawing.SystemColors.Window
        Appearance138.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridCajaBancos.DisplayLayout.Appearance = Appearance138
        Me.gridCajaBancos.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.gridCajaBancos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridCajaBancos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridCajaBancos.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.gridCajaBancos.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance139.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance139.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance139.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance139.BorderColor = System.Drawing.SystemColors.Window
        Me.gridCajaBancos.DisplayLayout.GroupByBox.Appearance = Appearance139
        Appearance140.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridCajaBancos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance140
        Me.gridCajaBancos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridCajaBancos.DisplayLayout.GroupByBox.Hidden = True
        Appearance141.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance141.BackColor2 = System.Drawing.SystemColors.Control
        Appearance141.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance141.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridCajaBancos.DisplayLayout.GroupByBox.PromptAppearance = Appearance141
        Me.gridCajaBancos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridCajaBancos.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridCajaBancos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridCajaBancos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridCajaBancos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridCajaBancos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridCajaBancos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridCajaBancos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridCajaBancos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridCajaBancos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridCajaBancos.Location = New System.Drawing.Point(0, 0)
        Me.gridCajaBancos.Name = "gridCajaBancos"
        Me.gridCajaBancos.Size = New System.Drawing.Size(1258, 272)
        Me.gridCajaBancos.TabIndex = 0
        Me.gridCajaBancos.Text = "UltraGrid1"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.ficInventarioBalance)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1258, 272)
        '
        'ficInventarioBalance
        '
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl21)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl22)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl23)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl24)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl25)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl26)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl27)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl28)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl29)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl30)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl31)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl32)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl33)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl34)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl35)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl36)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl37)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl38)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl39)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl40)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl41)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl42)
        Me.ficInventarioBalance.Controls.Add(Me.UltraTabPageControl43)
        Me.ficInventarioBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficInventarioBalance.Location = New System.Drawing.Point(0, 0)
        Me.ficInventarioBalance.Name = "ficInventarioBalance"
        Me.ficInventarioBalance.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.ficInventarioBalance.Size = New System.Drawing.Size(1258, 272)
        Me.ficInventarioBalance.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.ficInventarioBalance.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl21
        UltraTab1.Text = "3.1"
        UltraTab2.TabPage = Me.UltraTabPageControl22
        UltraTab2.Text = "3.2"
        UltraTab2.ToolTipText = "Detalle del Saldo de la Cuenta 10 Efectivo y Equivalentes de Efectivo"
        UltraTab3.TabPage = Me.UltraTabPageControl23
        UltraTab3.Text = "3.3"
        UltraTab3.ToolTipText = "Detalle del Saldo Cuenta 12 Cuentas por Cobrar Comerciales - Terceros y 13 Cuenta" &
    "s por Cobrar Comerciales - Relacionadas"
        UltraTab4.TabPage = Me.UltraTabPageControl24
        UltraTab4.Text = "3.4"
        UltraTab5.TabPage = Me.UltraTabPageControl25
        UltraTab5.Text = "3.5"
        UltraTab6.TabPage = Me.UltraTabPageControl26
        UltraTab6.Text = "3.6"
        UltraTab7.TabPage = Me.UltraTabPageControl27
        UltraTab7.Text = "3.7"
        UltraTab8.TabPage = Me.UltraTabPageControl28
        UltraTab8.Text = "3.8"
        UltraTab9.TabPage = Me.UltraTabPageControl29
        UltraTab9.Text = "3.9"
        UltraTab10.TabPage = Me.UltraTabPageControl30
        UltraTab10.Text = "3.11"
        UltraTab10.ToolTipText = "DETALLE DEL SALDO DE LA CUENTA 41 REMUNERACIONES Y PARTICIPACIONES POR PAGAR"
        UltraTab11.TabPage = Me.UltraTabPageControl31
        UltraTab11.Text = "3.12"
        UltraTab12.TabPage = Me.UltraTabPageControl32
        UltraTab12.Text = "3.13"
        UltraTab13.TabPage = Me.UltraTabPageControl33
        UltraTab13.Text = "3.14"
        UltraTab14.TabPage = Me.UltraTabPageControl34
        UltraTab14.Text = "3.15"
        UltraTab15.TabPage = Me.UltraTabPageControl35
        UltraTab15.Text = "3.16.1"
        UltraTab16.TabPage = Me.UltraTabPageControl36
        UltraTab16.Text = "3.16.2"
        UltraTab45.TabPage = Me.UltraTabPageControl37
        UltraTab45.Text = "3.17"
        UltraTab46.TabPage = Me.UltraTabPageControl38
        UltraTab46.Text = "3.18"
        UltraTab47.TabPage = Me.UltraTabPageControl39
        UltraTab47.Text = "3.19"
        UltraTab48.TabPage = Me.UltraTabPageControl40
        UltraTab48.Text = "3.20"
        UltraTab49.TabPage = Me.UltraTabPageControl41
        UltraTab49.Text = "3.23"
        UltraTab50.TabPage = Me.UltraTabPageControl42
        UltraTab50.Text = "3.24"
        UltraTab51.TabPage = Me.UltraTabPageControl43
        UltraTab51.Text = "3.25"
        Me.ficInventarioBalance.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7, UltraTab8, UltraTab9, UltraTab10, UltraTab11, UltraTab12, UltraTab13, UltraTab14, UltraTab15, UltraTab16, UltraTab45, UltraTab46, UltraTab47, UltraTab48, UltraTab49, UltraTab50, UltraTab51})
        Me.ficInventarioBalance.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.gridRentenciones)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1258, 272)
        '
        'gridRentenciones
        '
        Appearance142.BackColor = System.Drawing.SystemColors.Window
        Appearance142.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridRentenciones.DisplayLayout.Appearance = Appearance142
        Me.gridRentenciones.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.gridRentenciones.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridRentenciones.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridRentenciones.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.gridRentenciones.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance143.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance143.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance143.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance143.BorderColor = System.Drawing.SystemColors.Window
        Me.gridRentenciones.DisplayLayout.GroupByBox.Appearance = Appearance143
        Appearance144.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridRentenciones.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance144
        Me.gridRentenciones.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridRentenciones.DisplayLayout.GroupByBox.Hidden = True
        Appearance145.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance145.BackColor2 = System.Drawing.SystemColors.Control
        Appearance145.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance145.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridRentenciones.DisplayLayout.GroupByBox.PromptAppearance = Appearance145
        Me.gridRentenciones.DisplayLayout.MaxColScrollRegions = 1
        Me.gridRentenciones.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridRentenciones.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridRentenciones.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridRentenciones.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridRentenciones.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridRentenciones.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridRentenciones.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridRentenciones.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridRentenciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRentenciones.Location = New System.Drawing.Point(0, 0)
        Me.gridRentenciones.Name = "gridRentenciones"
        Me.gridRentenciones.Size = New System.Drawing.Size(1258, 272)
        Me.gridRentenciones.TabIndex = 0
        Me.gridRentenciones.Text = "UltraGrid2"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.griDetalleDiario)
        Me.UltraTabPageControl11.Controls.Add(Me.griDetalleDiarioPlanContable)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(1, 20)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1258, 272)
        '
        'griDetalleDiario
        '
        Me.griDetalleDiario.AllowDrop = true
        Me.griDetalleDiario.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1472.Header.VisiblePosition = 0
        UltraGridColumn1472.Hidden = true
        UltraGridColumn1473.Header.VisiblePosition = 1
        UltraGridColumn1473.Hidden = true
        UltraGridColumn1474.Header.VisiblePosition = 2
        UltraGridColumn1474.Hidden = true
        UltraGridColumn1475.Header.Caption = "Periodo(1)"
        UltraGridColumn1475.Header.VisiblePosition = 3
        UltraGridColumn1475.Width = 69
        UltraGridColumn1476.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn1476.Header.VisiblePosition = 5
        UltraGridColumn1476.Width = 89
        UltraGridColumn1477.Header.Caption = "F.Operacion(15)"
        UltraGridColumn1477.Header.VisiblePosition = 18
        UltraGridColumn1477.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1477.Width = 92
        UltraGridColumn1478.Header.Caption = "F.Vencimiento(14)"
        UltraGridColumn1478.Header.VisiblePosition = 17
        UltraGridColumn1478.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1478.Width = 99
        UltraGridColumn1479.Header.Caption = "Tipo Doc(10)"
        UltraGridColumn1479.Header.VisiblePosition = 13
        UltraGridColumn1479.Width = 73
        UltraGridColumn1480.Header.Caption = "Serie"
        UltraGridColumn1480.Header.VisiblePosition = 19
        UltraGridColumn1480.Hidden = true
        UltraGridColumn1480.Width = 40
        UltraGridColumn1481.Header.Caption = "A.DUA"
        UltraGridColumn1481.Header.VisiblePosition = 20
        UltraGridColumn1481.Hidden = true
        UltraGridColumn1481.Width = 40
        UltraGridColumn1482.Header.Caption = "C.Cuenta.C(4)"
        UltraGridColumn1482.Header.VisiblePosition = 7
        UltraGridColumn1482.Width = 80
        UltraGridColumn1483.Header.Caption = "Dominacion"
        UltraGridColumn1483.Header.VisiblePosition = 6
        UltraGridColumn1483.Hidden = true
        UltraGridColumn1483.Width = 200
        UltraGridColumn1484.Header.Caption = "T.D.I"
        UltraGridColumn1484.Header.VisiblePosition = 21
        UltraGridColumn1484.Hidden = true
        UltraGridColumn1484.Width = 30
        UltraGridColumn1485.Header.Caption = "N°Doc.I"
        UltraGridColumn1485.Header.VisiblePosition = 22
        UltraGridColumn1485.Hidden = true
        UltraGridColumn1485.Width = 70
        UltraGridColumn1486.Header.VisiblePosition = 23
        UltraGridColumn1486.Hidden = true
        UltraGridColumn1486.Width = 300
        Appearance146.TextHAlignAsString = "Right"
        UltraGridColumn1487.CellAppearance = Appearance146
        UltraGridColumn1487.Header.Caption = "DEBE(18)"
        UltraGridColumn1487.Header.VisiblePosition = 26
        UltraGridColumn1487.MaskInput = "{double:-9.2}"
        UltraGridColumn1487.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1487.Width = 100
        Appearance147.TextHAlignAsString = "Right"
        UltraGridColumn1488.CellAppearance = Appearance147
        UltraGridColumn1488.Header.Caption = "G. y/o E. IGV"
        UltraGridColumn1488.Header.VisiblePosition = 27
        UltraGridColumn1488.Hidden = true
        UltraGridColumn1488.MaskInput = "{double:-7.2}"
        UltraGridColumn1488.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1488.Width = 60
        Appearance148.TextHAlignAsString = "Right"
        UltraGridColumn1489.CellAppearance = Appearance148
        UltraGridColumn1489.Header.Caption = "HABER(19)"
        UltraGridColumn1489.Header.VisiblePosition = 28
        UltraGridColumn1489.MaskInput = "{double:-9.2}"
        UltraGridColumn1489.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1489.Width = 100
        Appearance149.TextHAlignAsString = "Right"
        UltraGridColumn1490.CellAppearance = Appearance149
        UltraGridColumn1490.Header.Caption = "G. No G. IGV"
        UltraGridColumn1490.Header.VisiblePosition = 32
        UltraGridColumn1490.Hidden = true
        UltraGridColumn1490.MaskInput = "{double:-7.2}"
        UltraGridColumn1490.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1490.Width = 60
        Appearance150.TextHAlignAsString = "Right"
        UltraGridColumn1491.CellAppearance = Appearance150
        UltraGridColumn1491.Header.Caption = "No G. B.I"
        UltraGridColumn1491.Header.VisiblePosition = 33
        UltraGridColumn1491.Hidden = true
        UltraGridColumn1491.MaskInput = "{double:-9.2}"
        UltraGridColumn1491.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1491.Width = 70
        Appearance151.TextHAlignAsString = "Right"
        UltraGridColumn1492.CellAppearance = Appearance151
        UltraGridColumn1492.Header.Caption = "No G. IGV"
        UltraGridColumn1492.Header.VisiblePosition = 34
        UltraGridColumn1492.Hidden = true
        UltraGridColumn1492.MaskInput = "{double:-7.2}"
        UltraGridColumn1492.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1492.Width = 60
        Appearance152.TextHAlignAsString = "Right"
        UltraGridColumn1493.CellAppearance = Appearance152
        UltraGridColumn1493.Header.Caption = "Valor No G."
        UltraGridColumn1493.Header.VisiblePosition = 35
        UltraGridColumn1493.Hidden = true
        UltraGridColumn1493.MaskInput = "{double:-7.2}"
        UltraGridColumn1493.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1493.Width = 60
        Appearance153.TextHAlignAsString = "Right"
        UltraGridColumn1494.CellAppearance = Appearance153
        UltraGridColumn1494.Header.VisiblePosition = 36
        UltraGridColumn1494.Hidden = true
        UltraGridColumn1494.MaskInput = "{double:-7.2}"
        UltraGridColumn1494.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1494.Width = 60
        Appearance154.TextHAlignAsString = "Right"
        UltraGridColumn1495.CellAppearance = Appearance154
        UltraGridColumn1495.Header.Caption = "O.Tributos"
        UltraGridColumn1495.Header.VisiblePosition = 37
        UltraGridColumn1495.Hidden = true
        UltraGridColumn1495.MaskInput = "{double:-7.2}"
        UltraGridColumn1495.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1495.Width = 60
        Appearance155.TextHAlignAsString = "Right"
        UltraGridColumn1496.CellAppearance = Appearance155
        UltraGridColumn1496.Header.Caption = "Importe Total"
        UltraGridColumn1496.Header.VisiblePosition = 38
        UltraGridColumn1496.Hidden = true
        UltraGridColumn1496.MaskInput = "{double:-9.2}"
        UltraGridColumn1496.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1496.Width = 70
        Appearance156.TextHAlignAsString = "Right"
        UltraGridColumn1497.CellAppearance = Appearance156
        UltraGridColumn1497.Header.Caption = "T.C."
        UltraGridColumn1497.Header.VisiblePosition = 39
        UltraGridColumn1497.Hidden = true
        UltraGridColumn1497.MaskInput = "{double:1.3}"
        UltraGridColumn1497.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1497.Width = 40
        UltraGridColumn1498.Header.Caption = "F.E. C.M"
        UltraGridColumn1498.Header.VisiblePosition = 40
        UltraGridColumn1498.Hidden = true
        UltraGridColumn1498.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1498.Width = 60
        UltraGridColumn1499.Header.Caption = "TDM"
        UltraGridColumn1499.Header.VisiblePosition = 41
        UltraGridColumn1499.Hidden = true
        UltraGridColumn1499.Width = 30
        UltraGridColumn1500.Header.Caption = "Serie M"
        UltraGridColumn1500.Header.VisiblePosition = 42
        UltraGridColumn1500.Hidden = true
        UltraGridColumn1500.Width = 40
        UltraGridColumn1501.Header.Caption = "N° D.M"
        UltraGridColumn1501.Header.VisiblePosition = 43
        UltraGridColumn1501.Hidden = true
        UltraGridColumn1501.Width = 60
        UltraGridColumn1502.Header.Caption = "Glosa de la Naturaleza de la Operacion(16)"
        UltraGridColumn1502.Header.VisiblePosition = 24
        UltraGridColumn1502.Width = 337
        UltraGridColumn1503.Header.Caption = "F.Contable(13)"
        UltraGridColumn1503.Header.VisiblePosition = 16
        UltraGridColumn1503.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1503.Width = 97
        UltraGridColumn1504.Header.Caption = "N°Const.Detrac"
        UltraGridColumn1504.Header.VisiblePosition = 44
        UltraGridColumn1504.Hidden = true
        UltraGridColumn1504.Width = 70
        UltraGridColumn1505.Header.Caption = "R"
        UltraGridColumn1505.Header.VisiblePosition = 45
        UltraGridColumn1505.Hidden = true
        UltraGridColumn1505.Width = 20
        UltraGridColumn1506.Header.Caption = "I(21)"
        UltraGridColumn1506.Header.VisiblePosition = 47
        UltraGridColumn1506.Width = 30
        UltraGridColumn1507.Header.VisiblePosition = 48
        UltraGridColumn1507.Hidden = true
        UltraGridColumn1508.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn1508.Header.VisiblePosition = 4
        UltraGridColumn1508.Width = 150
        UltraGridColumn1509.Header.VisiblePosition = 46
        UltraGridColumn1509.Hidden = true
        UltraGridColumn1510.Header.Caption = "DatosEstructurados(20)"
        UltraGridColumn1510.Header.VisiblePosition = 29
        UltraGridColumn1510.Width = 128
        UltraGridColumn1511.Header.VisiblePosition = 30
        UltraGridColumn1511.Hidden = true
        UltraGridColumn1511.Width = 125
        UltraGridColumn1512.Header.VisiblePosition = 31
        UltraGridColumn1512.Hidden = true
        UltraGridColumn1512.Width = 125
        UltraGridColumn1513.Header.Caption = "CodigoMoneda(7)"
        UltraGridColumn1513.Header.VisiblePosition = 10
        UltraGridColumn1513.Width = 98
        UltraGridColumn1514.Header.VisiblePosition = 49
        UltraGridColumn1514.Hidden = true
        UltraGridColumn1515.Header.VisiblePosition = 50
        UltraGridColumn1515.Hidden = true
        UltraGridColumn1516.Header.Caption = "Serie(11)"
        UltraGridColumn1516.Header.VisiblePosition = 14
        UltraGridColumn1516.Width = 57
        UltraGridColumn1517.Header.Caption = "Numero(12)"
        UltraGridColumn1517.Header.VisiblePosition = 15
        UltraGridColumn1517.Width = 98
        UltraGridColumn1518.Header.Caption = "CodUnidad(5)"
        UltraGridColumn1518.Header.VisiblePosition = 8
        UltraGridColumn1518.Width = 80
        UltraGridColumn1519.Header.Caption = "CodCCosto(6)"
        UltraGridColumn1519.Header.VisiblePosition = 9
        UltraGridColumn1519.Width = 82
        UltraGridColumn1520.Header.Caption = "TD Emisor(8)"
        UltraGridColumn1520.Header.VisiblePosition = 11
        UltraGridColumn1520.Width = 76
        UltraGridColumn1521.Header.VisiblePosition = 51
        UltraGridColumn1521.Hidden = true
        UltraGridColumn1522.Header.VisiblePosition = 52
        UltraGridColumn1522.Hidden = true
        UltraGridColumn1523.Header.Caption = "N° Doc Emisor(9)"
        UltraGridColumn1523.Header.VisiblePosition = 12
        UltraGridColumn1523.Width = 97
        UltraGridColumn1524.Header.Caption = "Glosa Referencial(17)"
        UltraGridColumn1524.Header.VisiblePosition = 25
        UltraGridColumn1525.Header.VisiblePosition = 53
        UltraGridColumn1525.Hidden = true
        UltraGridBand31.Columns.AddRange(New Object() {UltraGridColumn1472, UltraGridColumn1473, UltraGridColumn1474, UltraGridColumn1475, UltraGridColumn1476, UltraGridColumn1477, UltraGridColumn1478, UltraGridColumn1479, UltraGridColumn1480, UltraGridColumn1481, UltraGridColumn1482, UltraGridColumn1483, UltraGridColumn1484, UltraGridColumn1485, UltraGridColumn1486, UltraGridColumn1487, UltraGridColumn1488, UltraGridColumn1489, UltraGridColumn1490, UltraGridColumn1491, UltraGridColumn1492, UltraGridColumn1493, UltraGridColumn1494, UltraGridColumn1495, UltraGridColumn1496, UltraGridColumn1497, UltraGridColumn1498, UltraGridColumn1499, UltraGridColumn1500, UltraGridColumn1501, UltraGridColumn1502, UltraGridColumn1503, UltraGridColumn1504, UltraGridColumn1505, UltraGridColumn1506, UltraGridColumn1507, UltraGridColumn1508, UltraGridColumn1509, UltraGridColumn1510, UltraGridColumn1511, UltraGridColumn1512, UltraGridColumn1513, UltraGridColumn1514, UltraGridColumn1515, UltraGridColumn1516, UltraGridColumn1517, UltraGridColumn1518, UltraGridColumn1519, UltraGridColumn1520, UltraGridColumn1521, UltraGridColumn1522, UltraGridColumn1523, UltraGridColumn1524, UltraGridColumn1525})
        UltraGridBand31.SummaryFooterCaption = "Totales:"
        Me.griDetalleDiario.DisplayLayout.BandsSerializer.Add(UltraGridBand31)
        Me.griDetalleDiario.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleDiario.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleDiario.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDiario.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDiario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleDiario.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleDiario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleDiario.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleDiario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleDiario.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDetalleDiario.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleDiario.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleDiario.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleDiario.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleDiario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleDiario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.griDetalleDiario.Location = New System.Drawing.Point(0, 0)
        Me.griDetalleDiario.Name = "griDetalleDiario"
        Me.griDetalleDiario.Size = New System.Drawing.Size(808, 272)
        Me.griDetalleDiario.TabIndex = 0
        Me.griDetalleDiario.Tag = ""
        Me.griDetalleDiario.Text = "5.1 LIBRO DIARIO"
        '
        'griDetalleDiarioPlanContable
        '
        Me.griDetalleDiarioPlanContable.AllowDrop = true
        Me.griDetalleDiarioPlanContable.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1526.Header.VisiblePosition = 0
        UltraGridColumn1526.Hidden = true
        UltraGridColumn1527.Header.VisiblePosition = 1
        UltraGridColumn1527.Hidden = true
        UltraGridColumn1528.Header.VisiblePosition = 2
        UltraGridColumn1528.Hidden = true
        UltraGridColumn1529.Header.Caption = "Periodo(1)"
        UltraGridColumn1529.Header.VisiblePosition = 3
        UltraGridColumn1529.Width = 60
        UltraGridColumn1530.Header.Caption = "N°Correlativo"
        UltraGridColumn1530.Header.VisiblePosition = 5
        UltraGridColumn1530.Hidden = true
        UltraGridColumn1530.Width = 80
        UltraGridColumn1531.Header.Caption = "F.Operacion"
        UltraGridColumn1531.Header.VisiblePosition = 9
        UltraGridColumn1531.Hidden = true
        UltraGridColumn1531.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1531.Width = 80
        UltraGridColumn1532.Header.Caption = "F.Vencimiento"
        UltraGridColumn1532.Header.VisiblePosition = 10
        UltraGridColumn1532.Hidden = true
        UltraGridColumn1532.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1532.Width = 60
        UltraGridColumn1533.Header.Caption = "C.P.C"
        UltraGridColumn1533.Header.VisiblePosition = 6
        UltraGridColumn1533.Hidden = true
        UltraGridColumn1533.Width = 40
        UltraGridColumn1534.Header.Caption = "Serie"
        UltraGridColumn1534.Header.VisiblePosition = 11
        UltraGridColumn1534.Hidden = true
        UltraGridColumn1534.Width = 40
        UltraGridColumn1535.Header.Caption = "A.DUA"
        UltraGridColumn1535.Header.VisiblePosition = 12
        UltraGridColumn1535.Hidden = true
        UltraGridColumn1535.Width = 40
        UltraGridColumn1536.Header.Caption = "Cuenta C.(2)"
        UltraGridColumn1536.Header.VisiblePosition = 7
        UltraGridColumn1536.Width = 73
        UltraGridColumn1537.Header.Caption = "Descripcion de la Cuenta Contable(3)"
        UltraGridColumn1537.Header.VisiblePosition = 8
        UltraGridColumn1537.Width = 204
        UltraGridColumn1538.Header.Caption = "PlanCuenta(4)"
        UltraGridColumn1538.Header.VisiblePosition = 13
        UltraGridColumn1538.Width = 80
        UltraGridColumn1539.Header.Caption = "Descripcion P.C.(5)"
        UltraGridColumn1539.Header.VisiblePosition = 14
        UltraGridColumn1539.Width = 107
        UltraGridColumn1540.Header.VisiblePosition = 15
        UltraGridColumn1540.Hidden = true
        UltraGridColumn1540.Width = 300
        Appearance157.TextHAlignAsString = "Right"
        UltraGridColumn1541.CellAppearance = Appearance157
        UltraGridColumn1541.Header.Caption = "DEBE"
        UltraGridColumn1541.Header.VisiblePosition = 17
        UltraGridColumn1541.Hidden = true
        UltraGridColumn1541.MaskInput = "{double:-9.2}"
        UltraGridColumn1541.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1541.Width = 100
        Appearance158.TextHAlignAsString = "Right"
        UltraGridColumn1542.CellAppearance = Appearance158
        UltraGridColumn1542.Header.Caption = "G. y/o E. IGV"
        UltraGridColumn1542.Header.VisiblePosition = 18
        UltraGridColumn1542.Hidden = true
        UltraGridColumn1542.MaskInput = "{double:-7.2}"
        UltraGridColumn1542.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1542.Width = 60
        Appearance159.TextHAlignAsString = "Right"
        UltraGridColumn1543.CellAppearance = Appearance159
        UltraGridColumn1543.Header.Caption = "HABER"
        UltraGridColumn1543.Header.VisiblePosition = 19
        UltraGridColumn1543.Hidden = true
        UltraGridColumn1543.MaskInput = "{double:-9.2}"
        UltraGridColumn1543.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1543.Width = 100
        Appearance160.TextHAlignAsString = "Right"
        UltraGridColumn1544.CellAppearance = Appearance160
        UltraGridColumn1544.Header.Caption = "G. No G. IGV"
        UltraGridColumn1544.Header.VisiblePosition = 23
        UltraGridColumn1544.Hidden = true
        UltraGridColumn1544.MaskInput = "{double:-7.2}"
        UltraGridColumn1544.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1544.Width = 60
        Appearance161.TextHAlignAsString = "Right"
        UltraGridColumn1545.CellAppearance = Appearance161
        UltraGridColumn1545.Header.Caption = "No G. B.I"
        UltraGridColumn1545.Header.VisiblePosition = 24
        UltraGridColumn1545.Hidden = true
        UltraGridColumn1545.MaskInput = "{double:-9.2}"
        UltraGridColumn1545.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1545.Width = 70
        Appearance162.TextHAlignAsString = "Right"
        UltraGridColumn1546.CellAppearance = Appearance162
        UltraGridColumn1546.Header.Caption = "No G. IGV"
        UltraGridColumn1546.Header.VisiblePosition = 25
        UltraGridColumn1546.Hidden = true
        UltraGridColumn1546.MaskInput = "{double:-7.2}"
        UltraGridColumn1546.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1546.Width = 60
        Appearance163.TextHAlignAsString = "Right"
        UltraGridColumn1547.CellAppearance = Appearance163
        UltraGridColumn1547.Header.Caption = "Valor No G."
        UltraGridColumn1547.Header.VisiblePosition = 26
        UltraGridColumn1547.Hidden = true
        UltraGridColumn1547.MaskInput = "{double:-7.2}"
        UltraGridColumn1547.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1547.Width = 60
        Appearance164.TextHAlignAsString = "Right"
        UltraGridColumn1548.CellAppearance = Appearance164
        UltraGridColumn1548.Header.VisiblePosition = 27
        UltraGridColumn1548.Hidden = true
        UltraGridColumn1548.MaskInput = "{double:-7.2}"
        UltraGridColumn1548.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1548.Width = 60
        Appearance165.TextHAlignAsString = "Right"
        UltraGridColumn1549.CellAppearance = Appearance165
        UltraGridColumn1549.Header.Caption = "O.Tributos"
        UltraGridColumn1549.Header.VisiblePosition = 28
        UltraGridColumn1549.Hidden = true
        UltraGridColumn1549.MaskInput = "{double:-7.2}"
        UltraGridColumn1549.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1549.Width = 60
        Appearance166.TextHAlignAsString = "Right"
        UltraGridColumn1550.CellAppearance = Appearance166
        UltraGridColumn1550.Header.Caption = "Importe Total"
        UltraGridColumn1550.Header.VisiblePosition = 29
        UltraGridColumn1550.Hidden = true
        UltraGridColumn1550.MaskInput = "{double:-9.2}"
        UltraGridColumn1550.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1550.Width = 70
        Appearance167.TextHAlignAsString = "Right"
        UltraGridColumn1551.CellAppearance = Appearance167
        UltraGridColumn1551.Header.Caption = "T.C."
        UltraGridColumn1551.Header.VisiblePosition = 30
        UltraGridColumn1551.Hidden = true
        UltraGridColumn1551.MaskInput = "{double:1.3}"
        UltraGridColumn1551.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1551.Width = 40
        UltraGridColumn1552.Header.Caption = "F.E. C.M"
        UltraGridColumn1552.Header.VisiblePosition = 31
        UltraGridColumn1552.Hidden = true
        UltraGridColumn1552.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1552.Width = 60
        UltraGridColumn1553.Header.Caption = "TDM"
        UltraGridColumn1553.Header.VisiblePosition = 32
        UltraGridColumn1553.Hidden = true
        UltraGridColumn1553.Width = 30
        UltraGridColumn1554.Header.Caption = "Serie M"
        UltraGridColumn1554.Header.VisiblePosition = 33
        UltraGridColumn1554.Hidden = true
        UltraGridColumn1554.Width = 40
        UltraGridColumn1555.Header.Caption = "N° D.M"
        UltraGridColumn1555.Header.VisiblePosition = 34
        UltraGridColumn1555.Hidden = true
        UltraGridColumn1555.Width = 60
        UltraGridColumn1556.Header.VisiblePosition = 16
        UltraGridColumn1556.Hidden = true
        UltraGridColumn1556.Width = 150
        UltraGridColumn1557.Header.Caption = "F.E.Detrac."
        UltraGridColumn1557.Header.VisiblePosition = 35
        UltraGridColumn1557.Hidden = true
        UltraGridColumn1557.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1557.Width = 60
        UltraGridColumn1558.Header.Caption = "N°Const.Detrac"
        UltraGridColumn1558.Header.VisiblePosition = 36
        UltraGridColumn1558.Hidden = true
        UltraGridColumn1558.Width = 70
        UltraGridColumn1559.Header.Caption = "R"
        UltraGridColumn1559.Header.VisiblePosition = 37
        UltraGridColumn1559.Hidden = true
        UltraGridColumn1559.Width = 20
        UltraGridColumn1560.Header.Caption = "I(8)"
        UltraGridColumn1560.Header.VisiblePosition = 41
        UltraGridColumn1560.Width = 30
        UltraGridColumn1561.Header.VisiblePosition = 42
        UltraGridColumn1561.Hidden = true
        UltraGridColumn1562.Header.VisiblePosition = 4
        UltraGridColumn1562.Hidden = true
        UltraGridColumn1562.Width = 150
        UltraGridColumn1563.Header.VisiblePosition = 38
        UltraGridColumn1563.Hidden = true
        UltraGridColumn1564.Header.VisiblePosition = 20
        UltraGridColumn1564.Hidden = true
        UltraGridColumn1564.Width = 30
        UltraGridColumn1565.Header.VisiblePosition = 21
        UltraGridColumn1565.Hidden = true
        UltraGridColumn1565.Width = 30
        UltraGridColumn1566.Header.VisiblePosition = 22
        UltraGridColumn1566.Hidden = true
        UltraGridColumn1566.Width = 125
        UltraGridColumn1567.Header.VisiblePosition = 43
        UltraGridColumn1567.Hidden = true
        UltraGridColumn1568.Header.VisiblePosition = 44
        UltraGridColumn1568.Hidden = true
        UltraGridColumn1569.Header.VisiblePosition = 45
        UltraGridColumn1569.Hidden = true
        UltraGridColumn1570.Header.VisiblePosition = 46
        UltraGridColumn1570.Hidden = true
        UltraGridColumn1571.Header.VisiblePosition = 47
        UltraGridColumn1571.Hidden = true
        UltraGridColumn1572.Header.VisiblePosition = 48
        UltraGridColumn1572.Hidden = true
        UltraGridColumn1573.Header.VisiblePosition = 49
        UltraGridColumn1573.Hidden = true
        UltraGridColumn1574.Header.VisiblePosition = 50
        UltraGridColumn1574.Hidden = true
        UltraGridColumn1575.Header.VisiblePosition = 51
        UltraGridColumn1575.Hidden = true
        UltraGridColumn1576.Header.VisiblePosition = 52
        UltraGridColumn1576.Hidden = true
        UltraGridColumn1577.Header.VisiblePosition = 53
        UltraGridColumn1577.Hidden = true
        UltraGridColumn1578.Header.VisiblePosition = 54
        UltraGridColumn1578.Hidden = true
        UltraGridColumn1579.Header.VisiblePosition = 55
        UltraGridColumn1579.Hidden = true
        UltraGridColumn1580.Header.Caption = "CodCtaCtbleDesagregada(6)"
        UltraGridColumn1580.Header.VisiblePosition = 39
        UltraGridColumn1580.Width = 156
        UltraGridColumn1581.Header.Caption = "CtaCtbleDesagregada(7)"
        UltraGridColumn1581.Header.VisiblePosition = 40
        UltraGridColumn1581.Width = 132
        UltraGridBand32.Columns.AddRange(New Object() {UltraGridColumn1526, UltraGridColumn1527, UltraGridColumn1528, UltraGridColumn1529, UltraGridColumn1530, UltraGridColumn1531, UltraGridColumn1532, UltraGridColumn1533, UltraGridColumn1534, UltraGridColumn1535, UltraGridColumn1536, UltraGridColumn1537, UltraGridColumn1538, UltraGridColumn1539, UltraGridColumn1540, UltraGridColumn1541, UltraGridColumn1542, UltraGridColumn1543, UltraGridColumn1544, UltraGridColumn1545, UltraGridColumn1546, UltraGridColumn1547, UltraGridColumn1548, UltraGridColumn1549, UltraGridColumn1550, UltraGridColumn1551, UltraGridColumn1552, UltraGridColumn1553, UltraGridColumn1554, UltraGridColumn1555, UltraGridColumn1556, UltraGridColumn1557, UltraGridColumn1558, UltraGridColumn1559, UltraGridColumn1560, UltraGridColumn1561, UltraGridColumn1562, UltraGridColumn1563, UltraGridColumn1564, UltraGridColumn1565, UltraGridColumn1566, UltraGridColumn1567, UltraGridColumn1568, UltraGridColumn1569, UltraGridColumn1570, UltraGridColumn1571, UltraGridColumn1572, UltraGridColumn1573, UltraGridColumn1574, UltraGridColumn1575, UltraGridColumn1576, UltraGridColumn1577, UltraGridColumn1578, UltraGridColumn1579, UltraGridColumn1580, UltraGridColumn1581})
        UltraGridBand32.SummaryFooterCaption = "Totales:"
        Me.griDetalleDiarioPlanContable.DisplayLayout.BandsSerializer.Add(UltraGridBand32)
        Me.griDetalleDiarioPlanContable.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleDiarioPlanContable.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleDiarioPlanContable.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleDiarioPlanContable.Dock = System.Windows.Forms.DockStyle.Right
        Me.griDetalleDiarioPlanContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.griDetalleDiarioPlanContable.Location = New System.Drawing.Point(808, 0)
        Me.griDetalleDiarioPlanContable.Name = "griDetalleDiarioPlanContable"
        Me.griDetalleDiarioPlanContable.Size = New System.Drawing.Size(450, 272)
        Me.griDetalleDiarioPlanContable.TabIndex = 1
        Me.griDetalleDiarioPlanContable.Tag = ""
        Me.griDetalleDiarioPlanContable.Text = "5.3 LIBRO DIARIO - DETALLE DEL PLAN CONTABLE UTILIZADO"
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.gridDiarioSimplificado)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1258, 272)
        '
        'gridDiarioSimplificado
        '
        Appearance168.BackColor = System.Drawing.SystemColors.Window
        Appearance168.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridDiarioSimplificado.DisplayLayout.Appearance = Appearance168
        Me.gridDiarioSimplificado.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.gridDiarioSimplificado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDiarioSimplificado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDiarioSimplificado.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true
        Me.gridDiarioSimplificado.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance169.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance169.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance169.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance169.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDiarioSimplificado.DisplayLayout.GroupByBox.Appearance = Appearance169
        Appearance170.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDiarioSimplificado.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance170
        Me.gridDiarioSimplificado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDiarioSimplificado.DisplayLayout.GroupByBox.Hidden = true
        Appearance171.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance171.BackColor2 = System.Drawing.SystemColors.Control
        Appearance171.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance171.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDiarioSimplificado.DisplayLayout.GroupByBox.PromptAppearance = Appearance171
        Me.gridDiarioSimplificado.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDiarioSimplificado.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridDiarioSimplificado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDiarioSimplificado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDiarioSimplificado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDiarioSimplificado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDiarioSimplificado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDiarioSimplificado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDiarioSimplificado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridDiarioSimplificado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDiarioSimplificado.Location = New System.Drawing.Point(0, 0)
        Me.gridDiarioSimplificado.Name = "gridDiarioSimplificado"
        Me.gridDiarioSimplificado.Size = New System.Drawing.Size(1258, 272)
        Me.gridDiarioSimplificado.TabIndex = 0
        Me.gridDiarioSimplificado.Text = "UltraGrid3"
        '
        'UltraTabPageControl13
        '
        Me.UltraTabPageControl13.Controls.Add(Me.griDetalleMayor)
        Me.UltraTabPageControl13.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl13.Name = "UltraTabPageControl13"
        Me.UltraTabPageControl13.Size = New System.Drawing.Size(1258, 272)
        '
        'griDetalleMayor
        '
        Me.griDetalleMayor.AllowDrop = true
        Me.griDetalleMayor.DataSource = Me.ogdDetalleLibroElectronico
        UltraGridColumn1582.Header.VisiblePosition = 0
        UltraGridColumn1582.Hidden = true
        UltraGridColumn1583.Header.VisiblePosition = 1
        UltraGridColumn1583.Hidden = true
        UltraGridColumn1584.Header.VisiblePosition = 2
        UltraGridColumn1584.Hidden = true
        UltraGridColumn1585.Header.Caption = "Periodo(1)"
        UltraGridColumn1585.Header.VisiblePosition = 3
        UltraGridColumn1585.Width = 70
        UltraGridColumn1586.Header.Caption = "N°Correlativo(3)"
        UltraGridColumn1586.Header.VisiblePosition = 5
        UltraGridColumn1586.Width = 93
        UltraGridColumn1587.Header.Caption = "F.Operacion(15)"
        UltraGridColumn1587.Header.VisiblePosition = 18
        UltraGridColumn1587.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1587.Width = 91
        UltraGridColumn1588.Header.Caption = "F.Vencimiento(14)"
        UltraGridColumn1588.Header.VisiblePosition = 17
        UltraGridColumn1588.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1588.Width = 99
        UltraGridColumn1589.Header.Caption = "Tipo Doc(10)"
        UltraGridColumn1589.Header.VisiblePosition = 12
        UltraGridColumn1589.Width = 74
        UltraGridColumn1590.Header.Caption = "Serie"
        UltraGridColumn1590.Header.VisiblePosition = 19
        UltraGridColumn1590.Hidden = true
        UltraGridColumn1590.Width = 40
        UltraGridColumn1591.Header.Caption = "A.DUA"
        UltraGridColumn1591.Header.VisiblePosition = 20
        UltraGridColumn1591.Hidden = true
        UltraGridColumn1591.Width = 40
        UltraGridColumn1592.Header.Caption = "C.Cuenta.C(4)"
        UltraGridColumn1592.Header.VisiblePosition = 6
        UltraGridColumn1592.Width = 84
        UltraGridColumn1593.Header.Caption = "Dominacion"
        UltraGridColumn1593.Header.VisiblePosition = 15
        UltraGridColumn1593.Hidden = true
        UltraGridColumn1593.Width = 200
        UltraGridColumn1594.Header.Caption = "T.D.I"
        UltraGridColumn1594.Header.VisiblePosition = 21
        UltraGridColumn1594.Hidden = true
        UltraGridColumn1594.Width = 30
        UltraGridColumn1595.Header.Caption = "N°Doc.I"
        UltraGridColumn1595.Header.VisiblePosition = 22
        UltraGridColumn1595.Hidden = true
        UltraGridColumn1595.Width = 70
        UltraGridColumn1596.Header.VisiblePosition = 23
        UltraGridColumn1596.Hidden = true
        UltraGridColumn1596.Width = 300
        Appearance172.TextHAlignAsString = "Right"
        UltraGridColumn1597.CellAppearance = Appearance172
        UltraGridColumn1597.Header.Caption = "DEBE(18)"
        UltraGridColumn1597.Header.VisiblePosition = 26
        UltraGridColumn1597.MaskInput = "{double:-9.2}"
        UltraGridColumn1597.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1597.Width = 100
        Appearance173.TextHAlignAsString = "Right"
        UltraGridColumn1598.CellAppearance = Appearance173
        UltraGridColumn1598.Header.Caption = "G. y/o E. IGV"
        UltraGridColumn1598.Header.VisiblePosition = 27
        UltraGridColumn1598.Hidden = true
        UltraGridColumn1598.MaskInput = "{double:-7.2}"
        UltraGridColumn1598.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1598.Width = 60
        Appearance174.TextHAlignAsString = "Right"
        UltraGridColumn1599.CellAppearance = Appearance174
        UltraGridColumn1599.Header.Caption = "HABER(19)"
        UltraGridColumn1599.Header.VisiblePosition = 28
        UltraGridColumn1599.MaskInput = "{double:-9.2}"
        UltraGridColumn1599.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1599.Width = 100
        Appearance175.TextHAlignAsString = "Right"
        UltraGridColumn1600.CellAppearance = Appearance175
        UltraGridColumn1600.Header.Caption = "G. No G. IGV"
        UltraGridColumn1600.Header.VisiblePosition = 29
        UltraGridColumn1600.Hidden = true
        UltraGridColumn1600.MaskInput = "{double:-7.2}"
        UltraGridColumn1600.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1600.Width = 60
        Appearance176.TextHAlignAsString = "Right"
        UltraGridColumn1601.CellAppearance = Appearance176
        UltraGridColumn1601.Header.Caption = "No G. B.I"
        UltraGridColumn1601.Header.VisiblePosition = 30
        UltraGridColumn1601.Hidden = true
        UltraGridColumn1601.MaskInput = "{double:-9.2}"
        UltraGridColumn1601.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1601.Width = 70
        Appearance177.TextHAlignAsString = "Right"
        UltraGridColumn1602.CellAppearance = Appearance177
        UltraGridColumn1602.Header.Caption = "No G. IGV"
        UltraGridColumn1602.Header.VisiblePosition = 31
        UltraGridColumn1602.Hidden = true
        UltraGridColumn1602.MaskInput = "{double:-7.2}"
        UltraGridColumn1602.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1602.Width = 60
        Appearance178.TextHAlignAsString = "Right"
        UltraGridColumn1603.CellAppearance = Appearance178
        UltraGridColumn1603.Header.Caption = "Valor No G."
        UltraGridColumn1603.Header.VisiblePosition = 32
        UltraGridColumn1603.Hidden = true
        UltraGridColumn1603.MaskInput = "{double:-7.2}"
        UltraGridColumn1603.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1603.Width = 60
        Appearance179.TextHAlignAsString = "Right"
        UltraGridColumn1604.CellAppearance = Appearance179
        UltraGridColumn1604.Header.VisiblePosition = 33
        UltraGridColumn1604.Hidden = true
        UltraGridColumn1604.MaskInput = "{double:-7.2}"
        UltraGridColumn1604.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1604.Width = 60
        Appearance180.TextHAlignAsString = "Right"
        UltraGridColumn1605.CellAppearance = Appearance180
        UltraGridColumn1605.Header.Caption = "O.Tributos"
        UltraGridColumn1605.Header.VisiblePosition = 34
        UltraGridColumn1605.Hidden = true
        UltraGridColumn1605.MaskInput = "{double:-7.2}"
        UltraGridColumn1605.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1605.Width = 60
        Appearance181.TextHAlignAsString = "Right"
        UltraGridColumn1606.CellAppearance = Appearance181
        UltraGridColumn1606.Header.Caption = "Importe Total"
        UltraGridColumn1606.Header.VisiblePosition = 35
        UltraGridColumn1606.Hidden = true
        UltraGridColumn1606.MaskInput = "{double:-9.2}"
        UltraGridColumn1606.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1606.Width = 70
        Appearance182.TextHAlignAsString = "Right"
        UltraGridColumn1607.CellAppearance = Appearance182
        UltraGridColumn1607.Header.Caption = "T.C."
        UltraGridColumn1607.Header.VisiblePosition = 36
        UltraGridColumn1607.Hidden = true
        UltraGridColumn1607.MaskInput = "{double:1.3}"
        UltraGridColumn1607.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn1607.Width = 40
        UltraGridColumn1608.Header.Caption = "F.E. C.M"
        UltraGridColumn1608.Header.VisiblePosition = 37
        UltraGridColumn1608.Hidden = true
        UltraGridColumn1608.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1608.Width = 60
        UltraGridColumn1609.Header.Caption = "TDM"
        UltraGridColumn1609.Header.VisiblePosition = 38
        UltraGridColumn1609.Hidden = true
        UltraGridColumn1609.Width = 30
        UltraGridColumn1610.Header.Caption = "Serie M"
        UltraGridColumn1610.Header.VisiblePosition = 39
        UltraGridColumn1610.Hidden = true
        UltraGridColumn1610.Width = 40
        UltraGridColumn1611.Header.Caption = "N° D.M"
        UltraGridColumn1611.Header.VisiblePosition = 40
        UltraGridColumn1611.Hidden = true
        UltraGridColumn1611.Width = 60
        UltraGridColumn1612.Header.Caption = "Glosa de la Naturaleza de la Operacion(16)"
        UltraGridColumn1612.Header.VisiblePosition = 24
        UltraGridColumn1612.Width = 344
        UltraGridColumn1613.Header.Caption = "F. Contable(13)"
        UltraGridColumn1613.Header.VisiblePosition = 16
        UltraGridColumn1613.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn1613.Width = 96
        UltraGridColumn1614.Header.Caption = "N°Const.Detrac"
        UltraGridColumn1614.Header.VisiblePosition = 41
        UltraGridColumn1614.Hidden = true
        UltraGridColumn1614.Width = 70
        UltraGridColumn1615.Header.Caption = "R"
        UltraGridColumn1615.Header.VisiblePosition = 42
        UltraGridColumn1615.Hidden = true
        UltraGridColumn1615.Width = 20
        UltraGridColumn1616.Header.Caption = "I(21)"
        UltraGridColumn1616.Header.VisiblePosition = 46
        UltraGridColumn1616.Width = 30
        UltraGridColumn1617.Header.VisiblePosition = 47
        UltraGridColumn1617.Hidden = true
        UltraGridColumn1618.Header.Caption = "CodigoUnicoOperacion(2)"
        UltraGridColumn1618.Header.VisiblePosition = 4
        UltraGridColumn1618.Width = 161
        UltraGridColumn1619.Header.VisiblePosition = 48
        UltraGridColumn1619.Hidden = true
        UltraGridColumn1620.Header.Caption = "DatoEstructurado(20)"
        UltraGridColumn1620.Header.VisiblePosition = 43
        UltraGridColumn1620.Width = 116
        UltraGridColumn1621.Header.VisiblePosition = 44
        UltraGridColumn1621.Hidden = true
        UltraGridColumn1621.Width = 125
        UltraGridColumn1622.Header.VisiblePosition = 45
        UltraGridColumn1622.Hidden = true
        UltraGridColumn1622.Width = 125
        UltraGridColumn1623.Header.Caption = "CodigoMoneda(7)"
        UltraGridColumn1623.Header.VisiblePosition = 9
        UltraGridColumn1623.Width = 99
        UltraGridColumn1624.Header.VisiblePosition = 49
        UltraGridColumn1624.Hidden = true
        UltraGridColumn1625.Header.VisiblePosition = 50
        UltraGridColumn1625.Hidden = true
        UltraGridColumn1626.Header.Caption = "Serie(11)"
        UltraGridColumn1626.Header.VisiblePosition = 13
        UltraGridColumn1626.Width = 68
        UltraGridColumn1627.Header.Caption = "Numero(12)"
        UltraGridColumn1627.Header.VisiblePosition = 14
        UltraGridColumn1627.Width = 97
        UltraGridColumn1628.Header.Caption = "CodUnidad(5)"
        UltraGridColumn1628.Header.VisiblePosition = 7
        UltraGridColumn1628.Width = 80
        UltraGridColumn1629.Header.Caption = "CodCCosto(6)"
        UltraGridColumn1629.Header.VisiblePosition = 8
        UltraGridColumn1629.Width = 84
        UltraGridColumn1630.Header.Caption = "TD Emisor(8)"
        UltraGridColumn1630.Header.VisiblePosition = 10
        UltraGridColumn1630.Width = 75
        UltraGridColumn1631.Header.VisiblePosition = 51
        UltraGridColumn1631.Hidden = true
        UltraGridColumn1632.Header.VisiblePosition = 52
        UltraGridColumn1632.Hidden = true
        UltraGridColumn1633.Header.Caption = "N° Doc Emisor(9)"
        UltraGridColumn1633.Header.VisiblePosition = 11
        UltraGridColumn1633.Width = 98
        UltraGridColumn1634.Header.Caption = "Glosa Referencial(17)"
        UltraGridColumn1634.Header.VisiblePosition = 25
        UltraGridColumn1635.Header.VisiblePosition = 53
        UltraGridColumn1635.Hidden = true
        UltraGridBand33.Columns.AddRange(New Object() {UltraGridColumn1582, UltraGridColumn1583, UltraGridColumn1584, UltraGridColumn1585, UltraGridColumn1586, UltraGridColumn1587, UltraGridColumn1588, UltraGridColumn1589, UltraGridColumn1590, UltraGridColumn1591, UltraGridColumn1592, UltraGridColumn1593, UltraGridColumn1594, UltraGridColumn1595, UltraGridColumn1596, UltraGridColumn1597, UltraGridColumn1598, UltraGridColumn1599, UltraGridColumn1600, UltraGridColumn1601, UltraGridColumn1602, UltraGridColumn1603, UltraGridColumn1604, UltraGridColumn1605, UltraGridColumn1606, UltraGridColumn1607, UltraGridColumn1608, UltraGridColumn1609, UltraGridColumn1610, UltraGridColumn1611, UltraGridColumn1612, UltraGridColumn1613, UltraGridColumn1614, UltraGridColumn1615, UltraGridColumn1616, UltraGridColumn1617, UltraGridColumn1618, UltraGridColumn1619, UltraGridColumn1620, UltraGridColumn1621, UltraGridColumn1622, UltraGridColumn1623, UltraGridColumn1624, UltraGridColumn1625, UltraGridColumn1626, UltraGridColumn1627, UltraGridColumn1628, UltraGridColumn1629, UltraGridColumn1630, UltraGridColumn1631, UltraGridColumn1632, UltraGridColumn1633, UltraGridColumn1634, UltraGridColumn1635})
        UltraGridBand33.SummaryFooterCaption = "Totales:"
        Me.griDetalleMayor.DisplayLayout.BandsSerializer.Add(UltraGridBand33)
        Me.griDetalleMayor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDetalleMayor.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleMayor.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleMayor.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMayor.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleMayor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.griDetalleMayor.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleMayor.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleMayor.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleMayor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleMayor.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griDetalleMayor.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleMayor.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleMayor.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleMayor.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griDetalleMayor.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleMayor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.griDetalleMayor.Location = New System.Drawing.Point(0, 0)
        Me.griDetalleMayor.Name = "griDetalleMayor"
        Me.griDetalleMayor.Size = New System.Drawing.Size(1258, 272)
        Me.griDetalleMayor.TabIndex = 0
        Me.griDetalleMayor.Tag = ""
        '
        'UltraTabPageControl14
        '
        Me.UltraTabPageControl14.Controls.Add(Me.ficActivoFijo)
        Me.UltraTabPageControl14.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl14.Name = "UltraTabPageControl14"
        Me.UltraTabPageControl14.Size = New System.Drawing.Size(1258, 272)
        '
        'ficActivoFijo
        '
        Me.ficActivoFijo.Controls.Add(Me.UltraTabSharedControlsPage7)
        Me.ficActivoFijo.Controls.Add(Me.UltraTabPageControl48)
        Me.ficActivoFijo.Controls.Add(Me.UltraTabPageControl49)
        Me.ficActivoFijo.Controls.Add(Me.UltraTabPageControl50)
        Me.ficActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficActivoFijo.Location = New System.Drawing.Point(0, 0)
        Me.ficActivoFijo.Name = "ficActivoFijo"
        Me.ficActivoFijo.SharedControlsPage = Me.UltraTabSharedControlsPage7
        Me.ficActivoFijo.Size = New System.Drawing.Size(1258, 272)
        Me.ficActivoFijo.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.ficActivoFijo.TabIndex = 1
        UltraTab21.TabPage = Me.UltraTabPageControl48
        UltraTab21.Text = "7.1"
        UltraTab22.TabPage = Me.UltraTabPageControl49
        UltraTab22.Text = "7.3"
        UltraTab23.TabPage = Me.UltraTabPageControl50
        UltraTab23.Text = "7.4"
        Me.ficActivoFijo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab21, UltraTab22, UltraTab23})
        Me.ficActivoFijo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage7
        '
        Me.UltraTabSharedControlsPage7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage7.Name = "UltraTabSharedControlsPage7"
        Me.UltraTabSharedControlsPage7.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl15
        '
        Me.UltraTabPageControl15.Controls.Add(Me.utcCompras)
        Me.UltraTabPageControl15.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl15.Name = "UltraTabPageControl15"
        Me.UltraTabPageControl15.Size = New System.Drawing.Size(1258, 272)
        '
        'utcCompras
        '
        Me.utcCompras.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.utcCompras.Controls.Add(Me.UltraTabPageControl16)
        Me.utcCompras.Controls.Add(Me.UltraTabPageControl17)
        Me.utcCompras.Controls.Add(Me.UltraTabPageControl18)
        Me.utcCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.utcCompras.Location = New System.Drawing.Point(0, 0)
        Me.utcCompras.Name = "utcCompras"
        Me.utcCompras.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.utcCompras.Size = New System.Drawing.Size(1258, 272)
        Me.utcCompras.TabIndex = 6
        UltraTab52.TabPage = Me.UltraTabPageControl16
        UltraTab52.Text = "8.1"
        UltraTab53.TabPage = Me.UltraTabPageControl17
        UltraTab53.Text = "8.2"
        UltraTab54.TabPage = Me.UltraTabPageControl18
        UltraTab54.Text = "8.3"
        Me.utcCompras.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab52, UltraTab53, UltraTab54})
        Me.utcCompras.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1254, 249)
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.gridConsignacion)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1258, 272)
        '
        'gridConsignacion
        '
        Appearance183.BackColor = System.Drawing.SystemColors.Window
        Appearance183.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridConsignacion.DisplayLayout.Appearance = Appearance183
        Me.gridConsignacion.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.gridConsignacion.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridConsignacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridConsignacion.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true
        Me.gridConsignacion.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance184.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance184.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance184.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance184.BorderColor = System.Drawing.SystemColors.Window
        Me.gridConsignacion.DisplayLayout.GroupByBox.Appearance = Appearance184
        Appearance185.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridConsignacion.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance185
        Me.gridConsignacion.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridConsignacion.DisplayLayout.GroupByBox.Hidden = true
        Appearance186.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance186.BackColor2 = System.Drawing.SystemColors.Control
        Appearance186.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance186.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridConsignacion.DisplayLayout.GroupByBox.PromptAppearance = Appearance186
        Me.gridConsignacion.DisplayLayout.MaxColScrollRegions = 1
        Me.gridConsignacion.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridConsignacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridConsignacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridConsignacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridConsignacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridConsignacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridConsignacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridConsignacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridConsignacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridConsignacion.Location = New System.Drawing.Point(0, 0)
        Me.gridConsignacion.Name = "gridConsignacion"
        Me.gridConsignacion.Size = New System.Drawing.Size(1258, 272)
        Me.gridConsignacion.TabIndex = 0
        Me.gridConsignacion.Text = "UltraGrid5"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficRegistrosCostos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1258, 272)
        '
        'ficRegistrosCostos
        '
        Me.ficRegistrosCostos.Controls.Add(Me.UltraTabSharedControlsPage6)
        Me.ficRegistrosCostos.Controls.Add(Me.UltraTabPageControl44)
        Me.ficRegistrosCostos.Controls.Add(Me.UltraTabPageControl45)
        Me.ficRegistrosCostos.Controls.Add(Me.UltraTabPageControl46)
        Me.ficRegistrosCostos.Controls.Add(Me.UltraTabPageControl47)
        Me.ficRegistrosCostos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficRegistrosCostos.Location = New System.Drawing.Point(0, 0)
        Me.ficRegistrosCostos.Name = "ficRegistrosCostos"
        Me.ficRegistrosCostos.SharedControlsPage = Me.UltraTabSharedControlsPage6
        Me.ficRegistrosCostos.Size = New System.Drawing.Size(1258, 272)
        Me.ficRegistrosCostos.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.ficRegistrosCostos.TabIndex = 1
        UltraTab17.TabPage = Me.UltraTabPageControl44
        UltraTab17.Text = "10.1"
        UltraTab18.TabPage = Me.UltraTabPageControl45
        UltraTab18.Text = "10.2"
        UltraTab19.TabPage = Me.UltraTabPageControl46
        UltraTab19.Text = "10.3"
        UltraTab20.TabPage = Me.UltraTabPageControl47
        UltraTab20.Text = "10.4"
        Me.ficRegistrosCostos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab17, UltraTab18, UltraTab19, UltraTab20})
        Me.ficRegistrosCostos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage6
        '
        Me.UltraTabSharedControlsPage6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage6.Name = "UltraTabSharedControlsPage6"
        Me.UltraTabSharedControlsPage6.Size = New System.Drawing.Size(1256, 251)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gridPermanenteUF)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1258, 272)
        '
        'gridPermanenteUF
        '
        Appearance187.BackColor = System.Drawing.SystemColors.Window
        Appearance187.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.gridPermanenteUF.DisplayLayout.Appearance = Appearance187
        Me.gridPermanenteUF.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.gridPermanenteUF.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridPermanenteUF.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPermanenteUF.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true
        Me.gridPermanenteUF.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance188.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance188.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance188.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance188.BorderColor = System.Drawing.SystemColors.Window
        Me.gridPermanenteUF.DisplayLayout.GroupByBox.Appearance = Appearance188
        Appearance189.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridPermanenteUF.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance189
        Me.gridPermanenteUF.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridPermanenteUF.DisplayLayout.GroupByBox.Hidden = true
        Appearance190.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance190.BackColor2 = System.Drawing.SystemColors.Control
        Appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance190.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridPermanenteUF.DisplayLayout.GroupByBox.PromptAppearance = Appearance190
        Me.gridPermanenteUF.DisplayLayout.MaxColScrollRegions = 1
        Me.gridPermanenteUF.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridPermanenteUF.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridPermanenteUF.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridPermanenteUF.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridPermanenteUF.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridPermanenteUF.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridPermanenteUF.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridPermanenteUF.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridPermanenteUF.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridPermanenteUF.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridPermanenteUF.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridPermanenteUF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPermanenteUF.Location = New System.Drawing.Point(0, 0)
        Me.gridPermanenteUF.Name = "gridPermanenteUF"
        Me.gridPermanenteUF.Size = New System.Drawing.Size(1258, 272)
        Me.gridPermanenteUF.TabIndex = 0
        Me.gridPermanenteUF.Text = "UltraGrid7"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griPermanenteValorizado)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1258, 272)
        '
        'griPermanenteValorizado
        '
        Appearance191.BackColor = System.Drawing.SystemColors.Window
        Appearance191.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griPermanenteValorizado.DisplayLayout.Appearance = Appearance191
        Me.griPermanenteValorizado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPermanenteValorizado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPermanenteValorizado.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true
        Me.griPermanenteValorizado.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance192.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance192.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance192.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance192.BorderColor = System.Drawing.SystemColors.Window
        Me.griPermanenteValorizado.DisplayLayout.GroupByBox.Appearance = Appearance192
        Appearance193.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPermanenteValorizado.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance193
        Me.griPermanenteValorizado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPermanenteValorizado.DisplayLayout.GroupByBox.Hidden = true
        Appearance194.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance194.BackColor2 = System.Drawing.SystemColors.Control
        Appearance194.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance194.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPermanenteValorizado.DisplayLayout.GroupByBox.PromptAppearance = Appearance194
        Me.griPermanenteValorizado.DisplayLayout.MaxColScrollRegions = 1
        Me.griPermanenteValorizado.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPermanenteValorizado.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPermanenteValorizado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPermanenteValorizado.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPermanenteValorizado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPermanenteValorizado.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPermanenteValorizado.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPermanenteValorizado.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPermanenteValorizado.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPermanenteValorizado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPermanenteValorizado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPermanenteValorizado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPermanenteValorizado.Location = New System.Drawing.Point(0, 0)
        Me.griPermanenteValorizado.Name = "griPermanenteValorizado"
        Me.griPermanenteValorizado.Size = New System.Drawing.Size(1258, 272)
        Me.griPermanenteValorizado.TabIndex = 0
        Me.griPermanenteValorizado.Text = "UltraGrid8"
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.UltraTabControl2)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(1258, 272)
        '
        'UltraTabControl2
        '
        Me.UltraTabControl2.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl19)
        Me.UltraTabControl2.Controls.Add(Me.UltraTabPageControl20)
        Me.UltraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl2.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl2.Name = "UltraTabControl2"
        Me.UltraTabControl2.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.UltraTabControl2.Size = New System.Drawing.Size(1258, 272)
        Me.UltraTabControl2.TabIndex = 0
        UltraTab55.TabPage = Me.UltraTabPageControl19
        UltraTab55.Text = "14.1"
        UltraTab56.TabPage = Me.UltraTabPageControl20
        UltraTab56.Text = "14.2"
        Me.UltraTabControl2.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab55, UltraTab56})
        Me.UltraTabControl2.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1254, 249)
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.gridArchivoTexto)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1258, 272)
        '
        'gridArchivoTexto
        '
        Me.gridArchivoTexto.DataSource = Me.ogdImportar
        UltraGridColumn3617.Header.VisiblePosition = 0
        UltraGridColumn3617.Width = 100
        UltraGridColumn3618.Header.VisiblePosition = 1
        UltraGridColumn3618.Width = 150
        UltraGridColumn3619.Header.VisiblePosition = 2
        UltraGridColumn3619.Width = 100
        UltraGridColumn3620.Header.VisiblePosition = 3
        UltraGridColumn3620.Width = 150
        UltraGridColumn3621.Header.VisiblePosition = 4
        UltraGridColumn3621.Width = 100
        UltraGridColumn3622.Header.VisiblePosition = 5
        UltraGridColumn3622.Width = 150
        UltraGridColumn3623.Header.VisiblePosition = 6
        UltraGridColumn3623.Width = 100
        UltraGridColumn3624.Header.VisiblePosition = 7
        UltraGridColumn3624.Width = 150
        UltraGridColumn3625.Header.VisiblePosition = 8
        UltraGridColumn3625.Width = 100
        UltraGridColumn3626.Header.VisiblePosition = 9
        UltraGridColumn3626.Width = 150
        UltraGridColumn3627.Header.VisiblePosition = 10
        UltraGridColumn3627.Width = 100
        UltraGridColumn3628.Header.VisiblePosition = 11
        UltraGridColumn3628.Width = 150
        UltraGridBand34.Columns.AddRange(New Object() {UltraGridColumn3617, UltraGridColumn3618, UltraGridColumn3619, UltraGridColumn3620, UltraGridColumn3621, UltraGridColumn3622, UltraGridColumn3623, UltraGridColumn3624, UltraGridColumn3625, UltraGridColumn3626, UltraGridColumn3627, UltraGridColumn3628})
        Me.gridArchivoTexto.DisplayLayout.BandsSerializer.Add(UltraGridBand34)
        Me.gridArchivoTexto.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true
        Me.gridArchivoTexto.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.AlignWithDataRows
        Appearance195.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance195.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance195.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance195.BorderColor = System.Drawing.SystemColors.Window
        Me.gridArchivoTexto.DisplayLayout.GroupByBox.Appearance = Appearance195
        Appearance196.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridArchivoTexto.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance196
        Me.gridArchivoTexto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridArchivoTexto.DisplayLayout.GroupByBox.Hidden = true
        Appearance197.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance197.BackColor2 = System.Drawing.SystemColors.Control
        Appearance197.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance197.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridArchivoTexto.DisplayLayout.GroupByBox.PromptAppearance = Appearance197
        Me.gridArchivoTexto.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridArchivoTexto.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridArchivoTexto.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridArchivoTexto.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridArchivoTexto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridArchivoTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridArchivoTexto.Location = New System.Drawing.Point(0, 0)
        Me.gridArchivoTexto.Name = "gridArchivoTexto"
        Me.gridArchivoTexto.Size = New System.Drawing.Size(1258, 272)
        Me.gridArchivoTexto.TabIndex = 0
        '
        'ogdImportar
        '
        Me.ogdImportar.Band.Columns.AddRange(New Object() {UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66})
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrListaRegistro)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1260, 417)
        '
        'agrListaRegistro
        '
        Me.agrListaRegistro.Controls.Add(Me.griLista)
        Me.agrListaRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrListaRegistro.Location = New System.Drawing.Point(0, 80)
        Me.agrListaRegistro.Name = "agrListaRegistro"
        Me.agrListaRegistro.Size = New System.Drawing.Size(1260, 337)
        Me.agrListaRegistro.TabIndex = 1
        Me.agrListaRegistro.Tag = ""
        Me.agrListaRegistro.Text = "Lista Registro"
        Me.agrListaRegistro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.AllowDrop = true
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdLista
        Appearance198.ImageBackground = CType(resources.GetObject("Appearance198.ImageBackground"),System.Drawing.Image)
        Appearance198.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance198.ImageVAlign = Infragistics.Win.VAlign.Top
        Me.griLista.DisplayLayout.Appearance = Appearance198
        UltraGridColumn271.Header.VisiblePosition = 0
        UltraGridColumn271.Hidden = true
        UltraGridColumn272.Header.Caption = "Periodo"
        UltraGridColumn272.Header.VisiblePosition = 1
        UltraGridColumn272.Width = 60
        UltraGridColumn273.Header.Caption = "Libro Contable Electronico"
        UltraGridColumn273.Header.VisiblePosition = 2
        UltraGridColumn273.Width = 170
        UltraGridColumn274.Header.Caption = "Estado"
        UltraGridColumn274.Header.VisiblePosition = 4
        UltraGridColumn274.Width = 100
        UltraGridColumn275.Header.VisiblePosition = 3
        UltraGridColumn275.Hidden = true
        UltraGridColumn275.Width = 200
        Appearance199.TextHAlignAsString = "Right"
        UltraGridColumn276.CellAppearance = Appearance199
        UltraGridColumn276.Header.Caption = "Base Imponible"
        UltraGridColumn276.Header.VisiblePosition = 7
        UltraGridColumn276.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn276.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn276.Width = 105
        Appearance200.TextHAlignAsString = "Right"
        UltraGridColumn277.CellAppearance = Appearance200
        UltraGridColumn277.Header.Caption = "IGV"
        UltraGridColumn277.Header.VisiblePosition = 8
        UltraGridColumn277.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn277.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn277.Width = 81
        Appearance201.TextHAlignAsString = "Right"
        UltraGridColumn278.CellAppearance = Appearance201
        UltraGridColumn278.Header.Caption = "Importe Total"
        UltraGridColumn278.Header.VisiblePosition = 10
        UltraGridColumn278.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn278.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn278.Width = 107
        Appearance202.TextHAlignAsString = "Right"
        UltraGridColumn279.CellAppearance = Appearance202
        UltraGridColumn279.Header.Caption = "Valor A. No G."
        UltraGridColumn279.Header.VisiblePosition = 9
        UltraGridColumn279.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn279.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn279.Width = 99
        Appearance203.TextHAlignAsString = "Right"
        UltraGridColumn280.CellAppearance = Appearance203
        UltraGridColumn280.Header.VisiblePosition = 12
        UltraGridColumn280.Hidden = true
        UltraGridColumn280.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn280.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn280.Width = 80
        UltraGridColumn281.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn281.Header.VisiblePosition = 5
        UltraGridColumn281.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn281.Width = 141
        UltraGridColumn282.Header.VisiblePosition = 11
        UltraGridColumn282.Width = 200
        UltraGridColumn283.Header.VisiblePosition = 6
        UltraGridColumn283.Hidden = true
        UltraGridBand35.Columns.AddRange(New Object() {UltraGridColumn271, UltraGridColumn272, UltraGridColumn273, UltraGridColumn274, UltraGridColumn275, UltraGridColumn276, UltraGridColumn277, UltraGridColumn278, UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283})
        UltraGridBand35.SummaryFooterCaption = "Totales:"
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand35)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.griLista.Location = New System.Drawing.Point(3, 17)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1254, 317)
        Me.griLista.TabIndex = 0
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete, Me.VerArchivo, Me.Enviar})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(192, 114)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(191, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(191, 22)
        Me.Update.Text = "Editar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(191, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'VerArchivo
        '
        Me.VerArchivo.Image = Global.ISL.Win.My.Resources.Resources.empView
        Me.VerArchivo.Name = "VerArchivo"
        Me.VerArchivo.Size = New System.Drawing.Size(191, 22)
        Me.VerArchivo.Text = "VerArchivo Txt"
        Me.VerArchivo.ToolTipText = "Ver Liquidacion archivo generado segun FORMATO"
        '
        'Enviar
        '
        Me.Enviar.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(191, 22)
        Me.Enviar.Text = "Estado (Libro Declarado)"
        Me.Enviar.ToolTipText = "Liquidacion pasara al area de facturacion"
        '
        'ogdLista
        '
        UltraDataColumn72.DataType = GetType(Double)
        UltraDataColumn73.DataType = GetType(Double)
        UltraDataColumn74.DataType = GetType(Double)
        UltraDataColumn75.DataType = GetType(Double)
        UltraDataColumn76.DataType = GetType(Double)
        Me.ogdLista.Band.Columns.AddRange(New Object() {UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79})
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.dtpEjercicioLista)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.cboMesLista)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.cboLibroLista)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1260, 80)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpEjercicioLista
        '
        Me.dtpEjercicioLista.CustomFormat = "yyyy"
        Me.dtpEjercicioLista.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEjercicioLista.Location = New System.Drawing.Point(95, 51)
        Me.dtpEjercicioLista.Name = "dtpEjercicioLista"
        Me.dtpEjercicioLista.ShowUpDown = true
        Me.dtpEjercicioLista.Size = New System.Drawing.Size(52, 21)
        Me.dtpEjercicioLista.TabIndex = 3
        '
        'Etiqueta1
        '
        Appearance204.BackColor = System.Drawing.Color.Transparent
        Appearance204.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance204
        Me.Etiqueta1.AutoSize = true
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(153, 55)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta1.TabIndex = 4
        Me.Etiqueta1.Text = "Mes:"
        '
        'cboMesLista
        '
        Appearance205.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesLista.Appearance = Appearance205
        Me.cboMesLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesLista.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboMesLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesLista.Location = New System.Drawing.Point(190, 51)
        Me.cboMesLista.Name = "cboMesLista"
        Me.cboMesLista.Size = New System.Drawing.Size(71, 22)
        Me.cboMesLista.TabIndex = 5
        Me.cboMesLista.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance206.BackColor = System.Drawing.Color.Transparent
        Appearance206.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance206
        Me.Etiqueta3.AutoSize = true
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(32, 55)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Ejercicio:"
        '
        'cboLibroLista
        '
        Appearance207.ForeColor = System.Drawing.Color.Black
        Me.cboLibroLista.Appearance = Appearance207
        Me.cboLibroLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLibroLista.DisplayMember = "Nombre"
        Me.cboLibroLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLibroLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboLibroLista.ForeColor = System.Drawing.Color.Black
        Me.cboLibroLista.Location = New System.Drawing.Point(95, 24)
        Me.cboLibroLista.Name = "cboLibroLista"
        Me.cboLibroLista.Size = New System.Drawing.Size(400, 22)
        Me.cboLibroLista.TabIndex = 1
        Me.cboLibroLista.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance208.BackColor = System.Drawing.Color.Transparent
        Appearance208.ForeColor = System.Drawing.Color.Navy
        Appearance208.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance208
        Me.UltraLabel1.AutoSize = true
        Me.UltraLabel1.Location = New System.Drawing.Point(9, 27)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(80, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Libro Contable:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.tabDetalleLibros)
        Me.utpDetalle.Controls.Add(Me.agrDatoGeneral)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1260, 417)
        '
        'tabDetalleLibros
        '
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl3)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl5)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl10)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl11)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl12)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl13)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl14)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl15)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl1)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl2)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl4)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl6)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl8)
        Me.tabDetalleLibros.Controls.Add(Me.UltraTabPageControl9)
        Me.tabDetalleLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalleLibros.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tabDetalleLibros.Location = New System.Drawing.Point(0, 124)
        Me.tabDetalleLibros.Name = "tabDetalleLibros"
        Me.tabDetalleLibros.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabDetalleLibros.Size = New System.Drawing.Size(1260, 293)
        Me.tabDetalleLibros.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.tabDetalleLibros.TabIndex = 1
        UltraTab57.TabPage = Me.UltraTabPageControl3
        UltraTab57.Text = "Caja/Bancos"
        UltraTab57.ToolTipText = "Viajes sin liquidar - SPSA CD_Lurin_Local"
        UltraTab58.TabPage = Me.UltraTabPageControl5
        UltraTab58.Text = "Inventario/Balances"
        UltraTab58.ToolTipText = "3 Libro de Inventarios y Balances"
        UltraTab59.TabPage = Me.UltraTabPageControl10
        UltraTab59.Text = "Retenciones"
        UltraTab59.ToolTipText = "Viajes sin Liquidar - Lurin_Prov - Ransa - SF_VES"
        UltraTab60.TabPage = Me.UltraTabPageControl11
        UltraTab60.Text = "Diario"
        UltraTab60.ToolTipText = "Liquidacion detalle - Lurin_Prov - Ransa - SF_VES"
        UltraTab61.TabPage = Me.UltraTabPageControl12
        UltraTab61.Text = "Diario Simplificado"
        UltraTab61.ToolTipText = "Viajes sin Liquidar - TOTTUS"
        UltraTab62.TabPage = Me.UltraTabPageControl13
        UltraTab62.Text = "Mayor"
        UltraTab62.ToolTipText = "Liquidacion detalle - TOTTUS"
        UltraTab63.TabPage = Me.UltraTabPageControl14
        UltraTab63.Text = "Activos Fijos"
        UltraTab63.ToolTipText = "Viajes sin liquidar - Maestro"
        UltraTab64.TabPage = Me.UltraTabPageControl15
        UltraTab64.Text = "Compras"
        UltraTab64.ToolTipText = "Liquidacion detalle - Maestro"
        UltraTab65.TabPage = Me.UltraTabPageControl1
        UltraTab65.Text = "Consignacion"
        UltraTab66.TabPage = Me.UltraTabPageControl2
        UltraTab66.Text = "Costos"
        UltraTab67.TabPage = Me.UltraTabPageControl4
        UltraTab67.Text = "Permanente U.F"
        UltraTab68.TabPage = Me.UltraTabPageControl6
        UltraTab68.Text = "Permanente Valorizado"
        UltraTab69.TabPage = Me.UltraTabPageControl8
        UltraTab69.Text = "Ventas"
        UltraTab70.TabPage = Me.UltraTabPageControl9
        UltraTab70.Text = "ImportarArchivo"
        Me.tabDetalleLibros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab57, UltraTab58, UltraTab59, UltraTab60, UltraTab61, UltraTab62, UltraTab63, UltraTab64, UltraTab65, UltraTab66, UltraTab67, UltraTab68, UltraTab69, UltraTab70})
        Me.tabDetalleLibros.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1258, 272)
        '
        'agrDatoGeneral
        '
        Appearance209.BackColor = System.Drawing.Color.Transparent
        Me.agrDatoGeneral.Appearance = Appearance209
        Me.agrDatoGeneral.Controls.Add(Me.dtp_FechaGuarda)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta11)
        Me.agrDatoGeneral.Controls.Add(Me.cboCuentaFinal)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta10)
        Me.agrDatoGeneral.Controls.Add(Me.cboCuentaInicial)
        Me.agrDatoGeneral.Controls.Add(Me.decSubTotal4)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta9)
        Me.agrDatoGeneral.Controls.Add(Me.decSubTotal3)
        Me.agrDatoGeneral.Controls.Add(Me.decSubTotal2)
        Me.agrDatoGeneral.Controls.Add(Me.decSubTotal1)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta8)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta6)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta5)
        Me.agrDatoGeneral.Controls.Add(Me.txtObservacion)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta4)
        Me.agrDatoGeneral.Controls.Add(Me.Agrupacion1)
        Me.agrDatoGeneral.Controls.Add(Me.btnDetalleLibro)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta7)
        Me.agrDatoGeneral.Controls.Add(Me.cboMesGuarda)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.cboLibroGuarda)
        Me.agrDatoGeneral.Controls.Add(Me.UltraLabel17)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1260, 124)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Dato General"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtp_FechaGuarda
        '
        Me.dtp_FechaGuarda.CustomFormat = "yyyy"
        Me.dtp_FechaGuarda.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_FechaGuarda.Location = New System.Drawing.Point(107, 48)
        Me.dtp_FechaGuarda.Name = "dtp_FechaGuarda"
        Me.dtp_FechaGuarda.ShowUpDown = true
        Me.dtp_FechaGuarda.Size = New System.Drawing.Size(52, 21)
        Me.dtp_FechaGuarda.TabIndex = 3
        '
        'Etiqueta11
        '
        Appearance210.BackColor = System.Drawing.Color.Transparent
        Appearance210.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance210
        Me.Etiqueta11.AutoSize = true
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(260, 74)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta11.TabIndex = 8
        Me.Etiqueta11.Text = "Cuenta Inicial:"
        '
        'cboCuentaFinal
        '
        Appearance211.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaFinal.Appearance = Appearance211
        Me.cboCuentaFinal.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCuentaFinal.DisplayMember = "Nombre"
        Me.cboCuentaFinal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaFinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboCuentaFinal.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaFinal.Location = New System.Drawing.Point(342, 72)
        Me.cboCuentaFinal.Name = "cboCuentaFinal"
        Me.cboCuentaFinal.Size = New System.Drawing.Size(100, 22)
        Me.cboCuentaFinal.TabIndex = 9
        Me.cboCuentaFinal.ValueMember = "Id"
        '
        'Etiqueta10
        '
        Appearance212.BackColor = System.Drawing.Color.Transparent
        Appearance212.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance212
        Me.Etiqueta10.AutoSize = true
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(13, 76)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(88, 15)
        Me.Etiqueta10.TabIndex = 6
        Me.Etiqueta10.Text = "Cuenta Inicial:"
        '
        'cboCuentaInicial
        '
        Appearance213.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaInicial.Appearance = Appearance213
        Me.cboCuentaInicial.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCuentaInicial.DisplayMember = "Nombre"
        Me.cboCuentaInicial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaInicial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboCuentaInicial.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaInicial.Location = New System.Drawing.Point(107, 72)
        Me.cboCuentaInicial.Name = "cboCuentaInicial"
        Me.cboCuentaInicial.Size = New System.Drawing.Size(100, 22)
        Me.cboCuentaInicial.TabIndex = 7
        Me.cboCuentaInicial.ValueMember = "Id"
        '
        'decSubTotal4
        '
        Appearance214.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal4.Appearance = Appearance214
        Me.decSubTotal4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.decSubTotal4.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal4.Location = New System.Drawing.Point(528, 72)
        Me.decSubTotal4.MaskInput = "{double:-9.4}"
        Me.decSubTotal4.Name = "decSubTotal4"
        Me.decSubTotal4.NullText = "0.00"
        Me.decSubTotal4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal4.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSubTotal4.ReadOnly = true
        Me.decSubTotal4.Size = New System.Drawing.Size(125, 22)
        Me.decSubTotal4.TabIndex = 17
        '
        'Etiqueta9
        '
        Appearance215.BackColor = System.Drawing.Color.Transparent
        Appearance215.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance215
        Me.Etiqueta9.AutoSize = true
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(659, 76)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta9.TabIndex = 18
        '
        'decSubTotal3
        '
        Appearance216.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal3.Appearance = Appearance216
        Me.decSubTotal3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.decSubTotal3.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal3.Location = New System.Drawing.Point(528, 97)
        Me.decSubTotal3.MaskInput = "{double:-9.4}"
        Me.decSubTotal3.Name = "decSubTotal3"
        Me.decSubTotal3.NullText = "0.00"
        Me.decSubTotal3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal3.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSubTotal3.ReadOnly = true
        Me.decSubTotal3.Size = New System.Drawing.Size(125, 22)
        Me.decSubTotal3.TabIndex = 19
        '
        'decSubTotal2
        '
        Appearance217.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal2.Appearance = Appearance217
        Me.decSubTotal2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.decSubTotal2.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal2.Location = New System.Drawing.Point(528, 48)
        Me.decSubTotal2.MaskInput = "{double:-9.4}"
        Me.decSubTotal2.Name = "decSubTotal2"
        Me.decSubTotal2.NullText = "0.00"
        Me.decSubTotal2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal2.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSubTotal2.ReadOnly = true
        Me.decSubTotal2.Size = New System.Drawing.Size(125, 22)
        Me.decSubTotal2.TabIndex = 15
        '
        'decSubTotal1
        '
        Appearance218.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal1.Appearance = Appearance218
        Me.decSubTotal1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.decSubTotal1.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal1.Location = New System.Drawing.Point(528, 24)
        Me.decSubTotal1.MaskInput = "{double:-9.4}"
        Me.decSubTotal1.Name = "decSubTotal1"
        Me.decSubTotal1.NullText = "0.00"
        Me.decSubTotal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSubTotal1.ReadOnly = true
        Me.decSubTotal1.Size = New System.Drawing.Size(125, 22)
        Me.decSubTotal1.TabIndex = 13
        '
        'Etiqueta8
        '
        Appearance219.BackColor = System.Drawing.Color.Transparent
        Appearance219.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance219
        Me.Etiqueta8.AutoSize = true
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(659, 101)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta8.TabIndex = 20
        '
        'Etiqueta6
        '
        Appearance220.BackColor = System.Drawing.Color.Transparent
        Appearance220.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance220
        Me.Etiqueta6.AutoSize = true
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(659, 52)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta6.TabIndex = 16
        '
        'Etiqueta5
        '
        Appearance221.BackColor = System.Drawing.Color.Transparent
        Appearance221.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance221
        Me.Etiqueta5.AutoSize = true
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(659, 28)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(0, 0)
        Me.Etiqueta5.TabIndex = 14
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(107, 95)
        Me.txtObservacion.Multiline = true
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(388, 22)
        Me.txtObservacion.TabIndex = 12
        '
        'Etiqueta4
        '
        Appearance222.BackColor = System.Drawing.Color.Transparent
        Appearance222.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance222
        Me.Etiqueta4.AutoSize = true
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(28, 99)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta4.TabIndex = 11
        Me.Etiqueta4.Text = "Obervacion:"
        '
        'Agrupacion1
        '
        Appearance223.BackColor = System.Drawing.Color.White
        Appearance223.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance223
        Me.Agrupacion1.Controls.Add(Me.btnGenerarCUO)
        Me.Agrupacion1.Controls.Add(Me.cboImportarArchivo)
        Me.Agrupacion1.Controls.Add(Me.btnGenerar)
        Me.Agrupacion1.Controls.Add(Me.btnValidacion)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(1007, 17)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(250, 104)
        Me.Agrupacion1.TabIndex = 21
        Me.Agrupacion1.Text = "Opciones:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnGenerarCUO
        '
        Appearance224.ForeColor = System.Drawing.Color.Navy
        Appearance224.Image = 10
        Me.btnGenerarCUO.Appearance = Appearance224
        Me.btnGenerarCUO.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGenerarCUO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerarCUO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGenerarCUO.ForeColor = System.Drawing.Color.Black
        Me.btnGenerarCUO.ImageList = Me.imagenes
        Me.btnGenerarCUO.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerarCUO.Location = New System.Drawing.Point(127, 22)
        Me.btnGenerarCUO.Name = "btnGenerarCUO"
        Me.btnGenerarCUO.Size = New System.Drawing.Size(115, 35)
        Me.btnGenerarCUO.TabIndex = 3
        Me.btnGenerarCUO.Text = "Generar CUO"
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"),System.Windows.Forms.ImageListStreamer)
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
        'cboImportarArchivo
        '
        Appearance225.ForeColor = System.Drawing.Color.Navy
        Appearance225.Image = 10
        Me.cboImportarArchivo.Appearance = Appearance225
        Me.cboImportarArchivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.cboImportarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cboImportarArchivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboImportarArchivo.ForeColor = System.Drawing.Color.Black
        Me.cboImportarArchivo.ImageList = Me.imagenes
        Me.cboImportarArchivo.ImageSize = New System.Drawing.Size(20, 20)
        Me.cboImportarArchivo.Location = New System.Drawing.Point(128, 63)
        Me.cboImportarArchivo.Name = "cboImportarArchivo"
        Me.cboImportarArchivo.Size = New System.Drawing.Size(115, 35)
        Me.cboImportarArchivo.TabIndex = 2
        Me.cboImportarArchivo.Text = "Importar Archivo"
        '
        'btnGenerar
        '
        Appearance226.ForeColor = System.Drawing.Color.Navy
        Appearance226.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.btnGenerar.Appearance = Appearance226
        Me.btnGenerar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGenerar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.Black
        Me.btnGenerar.ImageList = Me.imagenes
        Me.btnGenerar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerar.Location = New System.Drawing.Point(7, 63)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(115, 35)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "Generar Archivo"
        '
        'btnValidacion
        '
        Appearance227.ForeColor = System.Drawing.Color.Navy
        Appearance227.Image = Global.ISL.Win.My.Resources.Resources.wait
        Me.btnValidacion.Appearance = Appearance227
        Me.btnValidacion.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnValidacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnValidacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnValidacion.ForeColor = System.Drawing.Color.Black
        Me.btnValidacion.ImageList = Me.imagenes
        Me.btnValidacion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnValidacion.Location = New System.Drawing.Point(7, 22)
        Me.btnValidacion.Name = "btnValidacion"
        Me.btnValidacion.Size = New System.Drawing.Size(115, 35)
        Me.btnValidacion.TabIndex = 0
        Me.btnValidacion.Text = "Validar"
        '
        'btnDetalleLibro
        '
        Appearance228.Image = "266.png"
        Appearance228.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance228.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnDetalleLibro.Appearance = Appearance228
        Me.btnDetalleLibro.ImageList = Me.imagenes
        Me.btnDetalleLibro.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDetalleLibro.Location = New System.Drawing.Point(451, 63)
        Me.btnDetalleLibro.Name = "btnDetalleLibro"
        Me.btnDetalleLibro.Size = New System.Drawing.Size(45, 30)
        Me.btnDetalleLibro.TabIndex = 10
        '
        'Etiqueta7
        '
        Appearance229.BackColor = System.Drawing.Color.Transparent
        Appearance229.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance229
        Me.Etiqueta7.AutoSize = true
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(306, 53)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(30, 14)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Mes:"
        '
        'cboMesGuarda
        '
        Appearance230.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesGuarda.Appearance = Appearance230
        Me.cboMesGuarda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesGuarda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesGuarda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesGuarda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboMesGuarda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesGuarda.Location = New System.Drawing.Point(342, 48)
        Me.cboMesGuarda.Name = "cboMesGuarda"
        Me.cboMesGuarda.Size = New System.Drawing.Size(50, 22)
        Me.cboMesGuarda.TabIndex = 5
        Me.cboMesGuarda.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance231.BackColor = System.Drawing.Color.Transparent
        Appearance231.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance231
        Me.Etiqueta2.AutoSize = true
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(44, 53)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(57, 15)
        Me.Etiqueta2.TabIndex = 2
        Me.Etiqueta2.Text = "Ejercicio:"
        '
        'cboLibroGuarda
        '
        Appearance232.ForeColor = System.Drawing.Color.Black
        Me.cboLibroGuarda.Appearance = Appearance232
        Me.cboLibroGuarda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboLibroGuarda.DisplayMember = "Nombre"
        Me.cboLibroGuarda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboLibroGuarda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboLibroGuarda.ForeColor = System.Drawing.Color.Black
        Me.cboLibroGuarda.Location = New System.Drawing.Point(107, 24)
        Me.cboLibroGuarda.Name = "cboLibroGuarda"
        Me.cboLibroGuarda.Size = New System.Drawing.Size(388, 22)
        Me.cboLibroGuarda.TabIndex = 1
        Me.cboLibroGuarda.ValueMember = "Id"
        '
        'UltraLabel17
        '
        Appearance233.BackColor = System.Drawing.Color.Transparent
        Appearance233.ForeColor = System.Drawing.Color.Navy
        Appearance233.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance233
        Me.UltraLabel17.AutoSize = true
        Me.UltraLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UltraLabel17.Location = New System.Drawing.Point(10, 28)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(91, 15)
        Me.UltraLabel17.TabIndex = 0
        Me.UltraLabel17.Text = "Libro Contable:"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(424, 230)
        Me.ugb_Espera.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 1
        Me.ugb_Espera.Visible = false
        '
        'ficLibroElectronico
        '
        Me.ficLibroElectronico.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficLibroElectronico.Controls.Add(Me.UltraTabPageControl7)
        Me.ficLibroElectronico.Controls.Add(Me.utpDetalle)
        Me.ficLibroElectronico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLibroElectronico.Location = New System.Drawing.Point(0, 0)
        Me.ficLibroElectronico.Name = "ficLibroElectronico"
        Me.ficLibroElectronico.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficLibroElectronico.Size = New System.Drawing.Size(1262, 440)
        Me.ficLibroElectronico.TabIndex = 0
        UltraTab71.Key = "Lista"
        UltraTab71.TabPage = Me.UltraTabPageControl7
        UltraTab71.Text = "Lista"
        UltraTab72.Key = "Mantenimiento"
        UltraTab72.TabPage = Me.utpDetalle
        UltraTab72.Text = "Mantenimiento"
        Me.ficLibroElectronico.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab71, UltraTab72})
        Me.ficLibroElectronico.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1260, 417)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_LibrosElectronicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 440)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficLibroElectronico)
        Me.Name = "frm_LibrosElectronicos"
        Me.Text = "Libros Electronicos (PLE)"
        Me.UltraTabPageControl21.ResumeLayout(false)
        CType(Me.gridInventario,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdDetalleLibroElectronico,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl22.ResumeLayout(false)
        CType(Me.griInv10,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl23.ResumeLayout(false)
        CType(Me.griInv12,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl24.ResumeLayout(false)
        CType(Me.griInv14,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl25.ResumeLayout(false)
        CType(Me.griInv16,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl26.ResumeLayout(false)
        CType(Me.griInv19,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl27.ResumeLayout(false)
        CType(Me.griInv20,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl28.ResumeLayout(false)
        CType(Me.griInv30,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl29.ResumeLayout(false)
        CType(Me.griInv34,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl30.ResumeLayout(false)
        CType(Me.griInv41,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl31.ResumeLayout(false)
        CType(Me.griInv42,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl32.ResumeLayout(false)
        CType(Me.griInv46,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl33.ResumeLayout(false)
        CType(Me.griInv47,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl34.ResumeLayout(false)
        CType(Me.griInv37,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl35.ResumeLayout(false)
        CType(Me.griInv50,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl36.ResumeLayout(false)
        CType(Me.griInvParticionaria,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl37.ResumeLayout(false)
        CType(Me.griInvBC,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl38.ResumeLayout(false)
        CType(Me.griInvEFEMD,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl39.ResumeLayout(false)
        CType(Me.griInvECPN,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl40.ResumeLayout(false)
        CType(Me.griInvER,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl41.ResumeLayout(false)
        Me.pnlNavegador.ClientArea.ResumeLayout(false)
        Me.pnlNavegador.ResumeLayout(false)
        CType(Me.agrNotas,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrNotas.ResumeLayout(false)
        Me.agrNotas.PerformLayout
        CType(Me.txtNombreArchivo,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl42.ResumeLayout(false)
        CType(Me.griInvERI,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl43.ResumeLayout(false)
        CType(Me.griInvEFEMI,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl48.ResumeLayout(false)
        CType(Me.gridActivoFijo,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl49.ResumeLayout(false)
        CType(Me.griAct73,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl50.ResumeLayout(false)
        CType(Me.griAct74,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl16.ResumeLayout(false)
        CType(Me.griDetalleCompras,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl17.ResumeLayout(false)
        CType(Me.griCompras2,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl18.ResumeLayout(false)
        CType(Me.griCompras3,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl44.ResumeLayout(false)
        CType(Me.gridCostos,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl19.ResumeLayout(false)
        CType(Me.griDetalleVentas,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl20.ResumeLayout(false)
        CType(Me.griVentas2,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl3.ResumeLayout(false)
        CType(Me.gridCajaBancos,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl5.ResumeLayout(false)
        CType(Me.ficInventarioBalance,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficInventarioBalance.ResumeLayout(false)
        Me.UltraTabPageControl10.ResumeLayout(false)
        CType(Me.gridRentenciones,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl11.ResumeLayout(false)
        CType(Me.griDetalleDiario,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.griDetalleDiarioPlanContable,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl12.ResumeLayout(false)
        CType(Me.gridDiarioSimplificado,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl13.ResumeLayout(false)
        CType(Me.griDetalleMayor,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl14.ResumeLayout(false)
        CType(Me.ficActivoFijo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficActivoFijo.ResumeLayout(false)
        Me.UltraTabPageControl15.ResumeLayout(false)
        CType(Me.utcCompras,System.ComponentModel.ISupportInitialize).EndInit
        Me.utcCompras.ResumeLayout(false)
        Me.UltraTabPageControl1.ResumeLayout(false)
        CType(Me.gridConsignacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl2.ResumeLayout(false)
        CType(Me.ficRegistrosCostos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficRegistrosCostos.ResumeLayout(false)
        Me.UltraTabPageControl4.ResumeLayout(false)
        CType(Me.gridPermanenteUF,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl6.ResumeLayout(false)
        CType(Me.griPermanenteValorizado,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl8.ResumeLayout(false)
        CType(Me.UltraTabControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabControl2.ResumeLayout(false)
        Me.UltraTabPageControl9.ResumeLayout(false)
        CType(Me.gridArchivoTexto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ogdImportar,System.ComponentModel.ISupportInitialize).EndInit
        Me.UltraTabPageControl7.ResumeLayout(false)
        CType(Me.agrListaRegistro,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrListaRegistro.ResumeLayout(false)
        CType(Me.griLista,System.ComponentModel.ISupportInitialize).EndInit
        Me.Menu.ResumeLayout(false)
        CType(Me.ogdLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.agrBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrBusqueda.ResumeLayout(false)
        Me.agrBusqueda.PerformLayout
        CType(Me.cboMesLista,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboLibroLista,System.ComponentModel.ISupportInitialize).EndInit
        Me.utpDetalle.ResumeLayout(false)
        CType(Me.tabDetalleLibros,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabDetalleLibros.ResumeLayout(false)
        CType(Me.agrDatoGeneral,System.ComponentModel.ISupportInitialize).EndInit
        Me.agrDatoGeneral.ResumeLayout(false)
        Me.agrDatoGeneral.PerformLayout
        CType(Me.cboCuentaFinal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboCuentaInicial,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decSubTotal4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decSubTotal3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decSubTotal2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.decSubTotal1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtObservacion,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Agrupacion1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Agrupacion1.ResumeLayout(false)
        CType(Me.cboMesGuarda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cboLibroGuarda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ficLibroElectronico,System.ComponentModel.ISupportInitialize).EndInit
        Me.ficLibroElectronico.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents ogdLista As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficLibroElectronico As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrListaRegistro As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents tabDetalleLibros As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl13 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl14 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl15 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cboLibroGuarda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesGuarda As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdDetalleLibroElectronico As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDetalleCompras As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griDetalleVentas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesLista As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cboLibroLista As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnDetalleLibro As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnValidacion As ISL.Controles.Boton
    Friend WithEvents btnGenerar As ISL.Controles.Boton
    Friend WithEvents txtObservacion As ISL.Controles.Texto
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Shadows WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Shadows WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Enviar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents decSubTotal3 As ISL.Controles.NumeroDecimal
    Friend WithEvents decSubTotal2 As ISL.Controles.NumeroDecimal
    Friend WithEvents decSubTotal1 As ISL.Controles.NumeroDecimal
    Friend WithEvents decSubTotal4 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents griDetalleMayor As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaFinal As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaInicial As ISL.Controles.ComboMaestros
    Friend WithEvents cboImportarArchivo As ISL.Controles.Boton
    Friend WithEvents gridCajaBancos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridInventario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridRentenciones As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridDiarioSimplificado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridActivoFijo As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridConsignacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridCostos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents gridPermanenteUF As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griPermanenteValorizado As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridArchivoTexto As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdImportar As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDetalleDiario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griDetalleDiarioPlanContable As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents utcCompras As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl16 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl17 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griCompras2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl18 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griCompras3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabControl2 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl19 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl20 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griVentas2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ficInventarioBalance As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl21 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl22 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl23 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv10 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griInv12 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl24 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv14 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl25 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv16 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl26 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv19 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl27 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl28 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl29 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl30 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv20 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griInv30 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griInv34 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griInv41 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl31 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv42 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl32 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv46 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl33 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv47 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl34 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv37 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl35 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInv50 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl36 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInvParticionaria As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl37 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInvBC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl38 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInvEFEMD As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl39 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInvECPN As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl40 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griInvER As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl41 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl42 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl43 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents webNotas As System.Windows.Forms.WebBrowser
    Friend WithEvents pnlNavegador As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents agrNotas As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtNombreArchivo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnAbrir As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griInvERI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griInvEFEMI As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents dtpEjercicioLista As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaGuarda As System.Windows.Forms.DateTimePicker
    Friend WithEvents ficRegistrosCostos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage6 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl44 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl45 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl46 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl47 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficActivoFijo As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage7 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl48 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl49 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAct73 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl50 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griAct74 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnGenerarCUO As ISL.Controles.Boton
End Class
