<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FacturarCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FacturarCarga))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCarga")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadCarga")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NTransporte")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConfirmadoGrt")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Factor")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoViaje")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoSemana")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCarga")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadCarga")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NTransporte")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndConfirmadoGrt")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Factor")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoViaje")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoSemana")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFactura")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFormato")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SubTotal")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Igv")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFactura")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFormato")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccionar")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCompra")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Prorratear valor en flete unitario de viajes", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griFactura = New ISL.Controles.Grilla(Me.components)
        Me.mnuCargas = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiGeneraFac = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGeneraBol = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfirmaCargaGRT = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesProceso = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdViajesProceso = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnActualizarMasiva = New Infragistics.Win.Misc.UltraButton()
        Me.VerSeleccionProceso = New ISL.Controles.Chequear(Me.components)
        Me.txtCodigoOP = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaCarga = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.verIncluirViajeR = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHastaViaje = New System.Windows.Forms.DateTimePicker()
        Me.fecDesdeViaje = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBusca = New ISL.Controles.Boton(Me.components)
        Me.cboTracto3 = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLiquidacion = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdLiquidacion = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboClaseServicioTottus = New ISL.Controles.Combo(Me.components)
        Me.opcFormatoLiquidacion = New ISL.Controles.Opciones(Me.components)
        Me.ColorFormato5 = New ISL.Controles.Colores(Me.components)
        Me.ColorFormato3 = New ISL.Controles.Colores(Me.components)
        Me.fecHastaLiquidacion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.ColorFormato4 = New ISL.Controles.Colores(Me.components)
        Me.ColorFormato2 = New ISL.Controles.Colores(Me.components)
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.ColorFormato0 = New ISL.Controles.Colores(Me.components)
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.ColorFormato1 = New ISL.Controles.Colores(Me.components)
        Me.btnLiquidaciones = New Infragistics.Win.Misc.UltraButton()
        Me.fecDesdeLiquidacion = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrContCarga = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.ficCargas = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboActividadNegocioLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboClienteLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTipoCarga = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.verViajeRetorno = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnConsolidar = New ISL.Controles.Boton(Me.components)
        Me.ColorCambio = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.colorRestablecido = New ISL.Controles.Colores(Me.components)
        Me.etiRestablecido = New ISL.Controles.Etiqueta(Me.components)
        Me.colorConDocFac = New ISL.Controles.Colores(Me.components)
        Me.etiConDocFac = New ISL.Controles.Etiqueta(Me.components)
        Me.colorSinDocFac = New ISL.Controles.Colores(Me.components)
        Me.colorDocPerFac = New ISL.Controles.Colores(Me.components)
        Me.etiSinDoc = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDocPerFac = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.verSelecion = New ISL.Controles.Chequear(Me.components)
        Me.txtNroGuiaT = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCentro = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRecuperado = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFactura = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrRecuperados = New ISL.Controles.Agrupacion(Me.components)
        Me.colorConDocumentos = New ISL.Controles.Colores(Me.components)
        Me.etiConDocumentos = New ISL.Controles.Etiqueta(Me.components)
        Me.colorSinDocumentos = New ISL.Controles.Colores(Me.components)
        Me.colorConDocumentosPerdidos = New ISL.Controles.Colores(Me.components)
        Me.etiSinDocumentos = New ISL.Controles.Etiqueta(Me.components)
        Me.etiConDocumentosPerdidos = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRecuperados = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDocumentoVenta = New ISL.Controles.Grilla(Me.components)
        Me.mnuFacturar = New ISL.Controles.MenuContextual(Me.components)
        Me.tsmiNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiEmitir = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAnular = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDescargarPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDescargarXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrBusquedaDoc = New ISL.Controles.Agrupacion(Me.components)
        Me.fecHastaDoc = New System.Windows.Forms.DateTimePicker()
        Me.fecDesdeDoc = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDocB = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNumeroB = New ISL.Controles.Texto(Me.components)
        Me.txtSerieB = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrPorVencimiento = New ISL.Controles.Agrupacion(Me.components)
        Me.etiPorVencer2 = New ISL.Controles.Etiqueta(Me.components)
        Me.numFaltan = New ISL.Controles.Numero(Me.components)
        Me.colorPorVencer = New ISL.Controles.Colores(Me.components)
        Me.etiPorVencer1 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorVencidos = New ISL.Controles.Colores(Me.components)
        Me.etiVencidos = New ISL.Controles.Etiqueta(Me.components)
        Me.etiPorVencimiento = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrContenedor = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleDoc = New ISL.Controles.Grilla(Me.components)
        Me.MenuDetalle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAplicarValorU = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregarDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.agrListaCargas = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.tabViajesLiquidaciones = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.griGuiaTransportista = New ISL.Controles.Grilla(Me.components)
        Me.griGuiaRemisionR = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViaje = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl12 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAnticipos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficMaterial = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.decAnticipo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cbAnticipo = New System.Windows.Forms.CheckBox()
        Me.ChkOcultarProducto = New ISL.Controles.Chequear(Me.components)
        Me.agrTipoBien = New ISL.Controles.Agrupacion(Me.components)
        Me.cboTipoBien = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.ChkAnexo = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtOrdenCompra = New ISL.Controles.Texto(Me.components)
        Me.chkElectronico = New ISL.Controles.Chequear(Me.components)
        Me.cboDirec = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.verDosDec = New ISL.Controles.Chequear(Me.components)
        Me.verDetalleAdj = New ISL.Controles.Chequear(Me.components)
        Me.verUnDetalle = New ISL.Controles.Chequear(Me.components)
        Me.verIgv = New ISL.Controles.Chequear(Me.components)
        Me.verQuitarCant = New ISL.Controles.Chequear(Me.components)
        Me.decValorUni = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verCambiaVU = New ISL.Controles.Chequear(Me.components)
        Me.optCliente = New ISL.Controles.Opciones(Me.components)
        Me.cboOtroCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboDestinatario = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.verDetraccionCero = New ISL.Controles.Chequear(Me.components)
        Me.verObservaciones = New ISL.Controles.Chequear(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtObrservaciones = New ISL.Controles.Texto(Me.components)
        Me.decCantTn = New ISL.Controles.NumeroDecimal(Me.components)
        Me.verCantidadTn = New ISL.Controles.Chequear(Me.components)
        Me.verFactorRCero = New ISL.Controles.Chequear(Me.components)
        Me.cboCliente2 = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.agrDatosComplementarios = New ISL.Controles.Agrupacion(Me.components)
        Me.fecPeriodo = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMoneda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrDetraccion = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.decImporteDetraer = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecDetraer = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.decNetoPagar = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.decDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnActualizarFleteUnitario = New Infragistics.Win.Misc.UltraButton()
        Me.decSubTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiSubtotal = New ISL.Controles.Etiqueta(Me.components)
        Me.etiImpuesto = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.decImpuesto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoPago = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstado = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDoc = New ISL.Controles.Fecha(Me.components)
        Me.txtNumero = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtSerie = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficFactura = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraToolTipManager2 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Formato1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formato2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCargas.SuspendLayout()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.griViajesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdViajesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.VerSeleccionProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.griListaCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.verIncluirViajeR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTracto3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.griLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.cboClaseServicioTottus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcFormatoLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecHastaLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorFormato1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesdeLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.agrContCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrContCarga.SuspendLayout()
        CType(Me.ficCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficCargas.SuspendLayout()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboActividadNegocioLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.colorRestablecido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorConDocFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorSinDocFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorDocPerFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verSelecion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroGuiaT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRecuperado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrRecuperados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRecuperados.SuspendLayout()
        CType(Me.colorConDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorSinDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorConDocumentosPerdidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.griDocumentoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuFacturar.SuspendLayout()
        CType(Me.agrBusquedaDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusquedaDoc.SuspendLayout()
        CType(Me.cboTipoDocB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrPorVencimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrPorVencimiento.SuspendLayout()
        CType(Me.numFaltan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.agrContenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrContenedor.SuspendLayout()
        CType(Me.griDetalleDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuDetalle.SuspendLayout()
        CType(Me.agrListaCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaCargas.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.tabViajesLiquidaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabViajesLiquidaciones.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.griGuiaTransportista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griGuiaRemisionR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl12.SuspendLayout()
        CType(Me.griAnticipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ficMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMaterial.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDetalle.SuspendLayout()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.decAnticipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkOcultarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrTipoBien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTipoBien.SuspendLayout()
        CType(Me.cboTipoBien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAnexo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkElectronico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDirec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDosDec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDetalleAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verUnDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verQuitarCant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decValorUni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCambiaVU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOtroCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDestinatario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verDetraccionCero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.txtObrservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decCantTn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verCantidadTn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verFactorRCero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosComplementarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosComplementarios.SuspendLayout()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetraccion.SuspendLayout()
        CType(Me.decImporteDetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decNetoPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.griFactura)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1338, 338)
        '
        'griFactura
        '
        Me.griFactura.ContextMenuStrip = Me.mnuCargas
        Me.griFactura.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griFactura.Location = New System.Drawing.Point(0, 0)
        Me.griFactura.Name = "griFactura"
        Me.griFactura.Size = New System.Drawing.Size(1338, 338)
        Me.griFactura.TabIndex = 0
        '
        'mnuCargas
        '
        Me.mnuCargas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCargas.ForeColor = System.Drawing.Color.Black
        Me.mnuCargas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiGeneraFac, Me.tsmiGeneraBol, Me.ConfirmaCargaGRT})
        Me.mnuCargas.Name = "mnuCargas"
        Me.mnuCargas.Size = New System.Drawing.Size(186, 70)
        '
        'tsmiGeneraFac
        '
        Me.tsmiGeneraFac.Image = CType(resources.GetObject("tsmiGeneraFac.Image"), System.Drawing.Image)
        Me.tsmiGeneraFac.Name = "tsmiGeneraFac"
        Me.tsmiGeneraFac.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.tsmiGeneraFac.Size = New System.Drawing.Size(185, 22)
        Me.tsmiGeneraFac.Text = "Generar Factura"
        '
        'tsmiGeneraBol
        '
        Me.tsmiGeneraBol.Image = CType(resources.GetObject("tsmiGeneraBol.Image"), System.Drawing.Image)
        Me.tsmiGeneraBol.Name = "tsmiGeneraBol"
        Me.tsmiGeneraBol.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.tsmiGeneraBol.Size = New System.Drawing.Size(185, 22)
        Me.tsmiGeneraBol.Text = "Generar Boleta"
        '
        'ConfirmaCargaGRT
        '
        Me.ConfirmaCargaGRT.Image = CType(resources.GetObject("ConfirmaCargaGRT.Image"), System.Drawing.Image)
        Me.ConfirmaCargaGRT.Name = "ConfirmaCargaGRT"
        Me.ConfirmaCargaGRT.Size = New System.Drawing.Size(185, 22)
        Me.ConfirmaCargaGRT.Text = "Confirma Carga / GRT"
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.griViajesProceso)
        Me.UltraTabPageControl11.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1338, 338)
        '
        'griViajesProceso
        '
        Me.griViajesProceso.DataSource = Me.ogdViajesProceso
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griViajesProceso.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn1.Header.VisiblePosition = 1
        UltraGridColumn1.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn1.Width = 50
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn3.Header.Caption = "NªViaje"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 100
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn5.CellAppearance = Appearance2
        UltraGridColumn5.Header.VisiblePosition = 3
        UltraGridColumn5.Width = 30
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 50
        UltraGridColumn7.Header.VisiblePosition = 16
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.Width = 50
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 50
        UltraGridColumn10.Header.VisiblePosition = 8
        UltraGridColumn10.Width = 60
        UltraGridColumn11.Header.VisiblePosition = 9
        UltraGridColumn11.Width = 100
        UltraGridColumn12.Header.VisiblePosition = 10
        UltraGridColumn12.Width = 100
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Width = 50
        UltraGridColumn14.Header.VisiblePosition = 22
        UltraGridColumn14.Width = 100
        UltraGridColumn15.Header.Caption = "Carga"
        UltraGridColumn15.Header.VisiblePosition = 19
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn15.Width = 40
        UltraGridColumn16.Header.VisiblePosition = 14
        UltraGridColumn17.Header.VisiblePosition = 12
        UltraGridColumn17.Width = 100
        UltraGridColumn18.Header.VisiblePosition = 13
        UltraGridColumn18.Width = 64
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance3
        UltraGridColumn19.Header.VisiblePosition = 15
        UltraGridColumn19.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn19.Width = 50
        Appearance4.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn20.CellAppearance = Appearance4
        UltraGridColumn20.Header.Caption = "Retorno"
        UltraGridColumn20.Header.VisiblePosition = 20
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn20.Width = 35
        UltraGridColumn21.Header.Caption = "Vacio"
        UltraGridColumn21.Header.VisiblePosition = 21
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn21.Width = 35
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance5
        UltraGridColumn22.Header.Caption = "F.Unitario"
        UltraGridColumn22.Header.VisiblePosition = 17
        UltraGridColumn22.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Width = 40
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance6
        UltraGridColumn23.Header.VisiblePosition = 18
        UltraGridColumn23.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn23.Width = 60
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn24.Width = 50
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 26
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27})
        Me.griViajesProceso.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griViajesProceso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesProceso.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesProceso.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.griViajesProceso.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesProceso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.griViajesProceso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesProceso.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesProceso.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.griViajesProceso.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesProceso.DisplayLayout.MaxRowScrollRegions = 1
        Me.griViajesProceso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesProceso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesProceso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesProceso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesProceso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesProceso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesProceso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesProceso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesProceso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajesProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesProceso.ImageList = Me.imagenes
        Me.griViajesProceso.Location = New System.Drawing.Point(0, 75)
        Me.griViajesProceso.Name = "griViajesProceso"
        Me.griViajesProceso.Size = New System.Drawing.Size(1338, 263)
        Me.griViajesProceso.TabIndex = 1
        Me.griViajesProceso.Text = "RENTING"
        '
        'ogdViajesProceso
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Boolean)
        Me.ogdViajesProceso.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'UltraGroupBox1
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance10
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox1.Controls.Add(Me.btnActualizarMasiva)
        Me.UltraGroupBox1.Controls.Add(Me.VerSeleccionProceso)
        Me.UltraGroupBox1.Controls.Add(Me.txtCodigoOP)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1338, 75)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Tag = ""
        Me.UltraGroupBox1.Text = "Esquema de Viajes"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Appearance11.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance11
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(115, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel1.TabIndex = 1
        Me.UltraLabel1.Text = "Codigo Semana:"
        '
        'btnActualizarMasiva
        '
        Appearance12.Image = 3
        Appearance12.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnActualizarMasiva.Appearance = Appearance12
        Me.btnActualizarMasiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarMasiva.ImageList = Me.imagenes
        Me.btnActualizarMasiva.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnActualizarMasiva.Location = New System.Drawing.Point(211, 41)
        Me.btnActualizarMasiva.Name = "btnActualizarMasiva"
        Me.btnActualizarMasiva.Size = New System.Drawing.Size(120, 30)
        Me.btnActualizarMasiva.TabIndex = 3
        Me.btnActualizarMasiva.Text = "Viajes Proceso"
        '
        'VerSeleccionProceso
        '
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.VerSeleccionProceso.Appearance = Appearance13
        Me.VerSeleccionProceso.BackColor = System.Drawing.Color.Transparent
        Me.VerSeleccionProceso.BackColorInternal = System.Drawing.Color.Transparent
        Me.VerSeleccionProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerSeleccionProceso.ForeColor = System.Drawing.Color.Black
        Me.VerSeleccionProceso.Location = New System.Drawing.Point(5, 40)
        Me.VerSeleccionProceso.Name = "VerSeleccionProceso"
        Me.VerSeleccionProceso.Size = New System.Drawing.Size(80, 29)
        Me.VerSeleccionProceso.TabIndex = 0
        Me.VerSeleccionProceso.Text = "Seleccionar Todo Filtro"
        '
        'txtCodigoOP
        '
        Me.txtCodigoOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOP.Location = New System.Drawing.Point(115, 48)
        Me.txtCodigoOP.Name = "txtCodigoOP"
        Me.txtCodigoOP.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigoOP.TabIndex = 2
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.griListaCarga)
        Me.UltraTabPageControl8.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(575, 198)
        '
        'griListaCarga
        '
        Me.griListaCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaCarga.Location = New System.Drawing.Point(0, 70)
        Me.griListaCarga.Name = "griListaCarga"
        Me.griListaCarga.Size = New System.Drawing.Size(575, 128)
        Me.griListaCarga.TabIndex = 1
        '
        'Agrupacion3
        '
        Appearance14.BackColor = System.Drawing.Color.White
        Appearance14.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion3.ContentAreaAppearance = Appearance14
        Me.Agrupacion3.Controls.Add(Me.verIncluirViajeR)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta26)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion3.Controls.Add(Me.fecHastaViaje)
        Me.Agrupacion3.Controls.Add(Me.fecDesdeViaje)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Controls.Add(Me.btnBusca)
        Me.Agrupacion3.Controls.Add(Me.cboTracto3)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(575, 70)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Datos de Busqueda"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verIncluirViajeR
        '
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.verIncluirViajeR.Appearance = Appearance15
        Me.verIncluirViajeR.AutoSize = True
        Me.verIncluirViajeR.Location = New System.Drawing.Point(190, 46)
        Me.verIncluirViajeR.Name = "verIncluirViajeR"
        Me.verIncluirViajeR.Size = New System.Drawing.Size(109, 17)
        Me.verIncluirViajeR.TabIndex = 1
        Me.verIncluirViajeR.Text = "Incluir V. Retorno"
        '
        'Etiqueta26
        '
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance16
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(11, 46)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta26.TabIndex = 2
        Me.Etiqueta26.Text = "Fec. Hasta:"
        '
        'Etiqueta23
        '
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance17
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(8, 25)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta23.TabIndex = 0
        Me.Etiqueta23.Text = "Fec. Desde:"
        '
        'fecHastaViaje
        '
        Me.fecHastaViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHastaViaje.Location = New System.Drawing.Point(74, 43)
        Me.fecHastaViaje.Name = "fecHastaViaje"
        Me.fecHastaViaje.Size = New System.Drawing.Size(93, 20)
        Me.fecHastaViaje.TabIndex = 3
        '
        'fecDesdeViaje
        '
        Me.fecDesdeViaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesdeViaje.Location = New System.Drawing.Point(74, 22)
        Me.fecDesdeViaje.Name = "fecDesdeViaje"
        Me.fecDesdeViaje.Size = New System.Drawing.Size(93, 20)
        Me.fecDesdeViaje.TabIndex = 1
        '
        'Etiqueta2
        '
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance18
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(181, 26)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta2.TabIndex = 7
        Me.Etiqueta2.Text = "Tracto:"
        '
        'btnBusca
        '
        Appearance19.Image = CType(resources.GetObject("Appearance19.Image"), Object)
        Appearance19.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnBusca.Appearance = Appearance19
        Me.btnBusca.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBusca.ForeColor = System.Drawing.Color.Black
        Me.btnBusca.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnBusca.Location = New System.Drawing.Point(305, 34)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(45, 30)
        Me.btnBusca.TabIndex = 2
        '
        'cboTracto3
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.cboTracto3.Appearance = Appearance20
        Me.cboTracto3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto3.ForeColor = System.Drawing.Color.Black
        Me.cboTracto3.Location = New System.Drawing.Point(223, 22)
        Me.cboTracto3.Name = "cboTracto3"
        Me.cboTracto3.Size = New System.Drawing.Size(76, 21)
        Me.cboTracto3.TabIndex = 0
        Me.cboTracto3.ValueMember = "Id"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griLiquidacion)
        Me.UltraTabPageControl9.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(575, 198)
        '
        'griLiquidacion
        '
        Me.griLiquidacion.AllowDrop = True
        Me.griLiquidacion.DataSource = Me.ogdLiquidacion
        UltraGridColumn69.Header.VisiblePosition = 0
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 2
        UltraGridColumn70.Width = 90
        UltraGridColumn28.Header.Caption = "Cliente"
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn28.Hidden = True
        UltraGridColumn28.Width = 200
        UltraGridColumn29.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn29.Header.VisiblePosition = 3
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn29.Width = 60
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance21
        UltraGridColumn30.Format = "#,###,###,##0.00"
        UltraGridColumn30.Header.VisiblePosition = 5
        UltraGridColumn30.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn30.Width = 60
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance22
        UltraGridColumn31.Format = "#,###,###,##0.00"
        UltraGridColumn31.Header.VisiblePosition = 6
        UltraGridColumn31.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn31.Width = 50
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn32.CellAppearance = Appearance23
        UltraGridColumn32.Format = "#,###,###,##0.00"
        UltraGridColumn32.Header.VisiblePosition = 7
        UltraGridColumn32.MaskInput = "{LOC}nnn,nnn.nn"
        UltraGridColumn32.Width = 70
        UltraGridColumn33.Header.VisiblePosition = 8
        UltraGridColumn33.Width = 150
        UltraGridColumn34.Header.Caption = "Estado"
        UltraGridColumn34.Header.VisiblePosition = 9
        UltraGridColumn34.Hidden = True
        UltraGridColumn34.Width = 100
        UltraGridColumn35.Header.VisiblePosition = 10
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.Width = 150
        UltraGridColumn36.Header.VisiblePosition = 11
        UltraGridColumn36.Hidden = True
        UltraGridColumn36.Width = 150
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn37.Header.Caption = "Select"
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn37.Width = 35
        UltraGridColumn38.Header.VisiblePosition = 12
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 13
        UltraGridColumn39.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn69, UltraGridColumn70, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39})
        UltraGridBand2.SummaryFooterCaption = "Totales:"
        Me.griLiquidacion.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griLiquidacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLiquidacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griLiquidacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLiquidacion.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLiquidacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLiquidacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLiquidacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLiquidacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLiquidacion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLiquidacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLiquidacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLiquidacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLiquidacion.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griLiquidacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLiquidacion.Location = New System.Drawing.Point(0, 60)
        Me.griLiquidacion.Name = "griLiquidacion"
        Me.griLiquidacion.Size = New System.Drawing.Size(575, 138)
        Me.griLiquidacion.TabIndex = 1
        Me.griLiquidacion.Tag = ""
        '
        'ogdLiquidacion
        '
        UltraDataColumn39.DataType = GetType(Boolean)
        Me.ogdLiquidacion.Band.Columns.AddRange(New Object() {UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41})
        '
        'Agrupacion6
        '
        Appearance24.BackColor = System.Drawing.Color.White
        Appearance24.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance24
        Me.Agrupacion6.Controls.Add(Me.cboClaseServicioTottus)
        Me.Agrupacion6.Controls.Add(Me.opcFormatoLiquidacion)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato5)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato3)
        Me.Agrupacion6.Controls.Add(Me.fecHastaLiquidacion)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato4)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato2)
        Me.Agrupacion6.Controls.Add(Me.UltraLabel39)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato0)
        Me.Agrupacion6.Controls.Add(Me.UltraLabel41)
        Me.Agrupacion6.Controls.Add(Me.ColorFormato1)
        Me.Agrupacion6.Controls.Add(Me.btnLiquidaciones)
        Me.Agrupacion6.Controls.Add(Me.fecDesdeLiquidacion)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(575, 60)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboClaseServicioTottus
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.cboClaseServicioTottus.Appearance = Appearance25
        Me.cboClaseServicioTottus.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClaseServicioTottus.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClaseServicioTottus.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClaseServicioTottus.ForeColor = System.Drawing.Color.Black
        Me.cboClaseServicioTottus.Location = New System.Drawing.Point(143, 6)
        Me.cboClaseServicioTottus.Name = "cboClaseServicioTottus"
        Me.cboClaseServicioTottus.Size = New System.Drawing.Size(125, 21)
        Me.cboClaseServicioTottus.TabIndex = 2
        Me.cboClaseServicioTottus.ValueMember = "Id"
        Me.cboClaseServicioTottus.Visible = False
        '
        'opcFormatoLiquidacion
        '
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.opcFormatoLiquidacion.Appearance = Appearance26
        Me.opcFormatoLiquidacion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcFormatoLiquidacion.CheckedIndex = 0
        Me.opcFormatoLiquidacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.opcFormatoLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcFormatoLiquidacion.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance27.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        ValueListItem1.Appearance = Appearance27
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "SPSA LurinLocal"
        Appearance28.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        ValueListItem2.Appearance = Appearance28
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "SPSA LurinProv"
        Appearance29.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ValueListItem3.Appearance = Appearance29
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "SPSA Ransa"
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ValueListItem4.Appearance = Appearance30
        ValueListItem4.DataValue = "ValueListItem3"
        ValueListItem4.DisplayText = "SPSA SF_VES"
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ValueListItem5.Appearance = Appearance31
        ValueListItem5.DataValue = "ValueListItem4"
        ValueListItem5.DisplayText = "TOTTUS"
        Appearance32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        ValueListItem6.Appearance = Appearance32
        ValueListItem6.DataValue = "ValueListItem5"
        ValueListItem6.DisplayText = "MAESTRO"
        Appearance33.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        ValueListItem7.Appearance = Appearance33
        ValueListItem7.DataValue = "ValueListItem6"
        ValueListItem7.DisplayText = "FALABELLA"
        Appearance34.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ValueListItem8.Appearance = Appearance34
        ValueListItem8.DataValue = "ValueListItem7"
        ValueListItem8.DisplayText = "SODIMAC"
        ValueListItem9.DataValue = "ValueListItem8"
        ValueListItem9.DisplayText = "PARIHUELAS"
        Me.opcFormatoLiquidacion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9})
        Me.opcFormatoLiquidacion.Location = New System.Drawing.Point(276, 3)
        Me.opcFormatoLiquidacion.Name = "opcFormatoLiquidacion"
        Me.opcFormatoLiquidacion.Size = New System.Drawing.Size(296, 54)
        Me.opcFormatoLiquidacion.TabIndex = 3
        Me.opcFormatoLiquidacion.Text = "SPSA LurinLocal"
        '
        'ColorFormato5
        '
        Me.ColorFormato5.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato5.Location = New System.Drawing.Point(498, 25)
        Me.ColorFormato5.Name = "ColorFormato5"
        Me.ColorFormato5.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato5.TabIndex = 9
        Me.ColorFormato5.Text = "Control"
        '
        'ColorFormato3
        '
        Me.ColorFormato3.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato3.Location = New System.Drawing.Point(449, 25)
        Me.ColorFormato3.Name = "ColorFormato3"
        Me.ColorFormato3.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato3.TabIndex = 8
        Me.ColorFormato3.Text = "Control"
        '
        'fecHastaLiquidacion
        '
        Me.fecHastaLiquidacion.DateTime = New Date(2015, 11, 17, 0, 0, 0, 0)
        Me.fecHastaLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHastaLiquidacion.Location = New System.Drawing.Point(47, 33)
        Me.fecHastaLiquidacion.MaskInput = ""
        Me.fecHastaLiquidacion.Name = "fecHastaLiquidacion"
        Me.fecHastaLiquidacion.Size = New System.Drawing.Size(90, 21)
        Me.fecHastaLiquidacion.TabIndex = 11
        Me.fecHastaLiquidacion.Value = New Date(2015, 11, 17, 0, 0, 0, 0)
        '
        'ColorFormato4
        '
        Me.ColorFormato4.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato4.Location = New System.Drawing.Point(498, 5)
        Me.ColorFormato4.Name = "ColorFormato4"
        Me.ColorFormato4.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato4.TabIndex = 6
        Me.ColorFormato4.Text = "Control"
        '
        'ColorFormato2
        '
        Me.ColorFormato2.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato2.Location = New System.Drawing.Point(449, 5)
        Me.ColorFormato2.Name = "ColorFormato2"
        Me.ColorFormato2.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato2.TabIndex = 5
        Me.ColorFormato2.Text = "Control"
        '
        'UltraLabel39
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance35
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(7, 37)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel39.TabIndex = 10
        Me.UltraLabel39.Text = "Hasta:"
        '
        'ColorFormato0
        '
        Me.ColorFormato0.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato0.Location = New System.Drawing.Point(400, 5)
        Me.ColorFormato0.Name = "ColorFormato0"
        Me.ColorFormato0.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato0.TabIndex = 4
        Me.ColorFormato0.Text = "Control"
        '
        'UltraLabel41
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Appearance36.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance36
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(4, 13)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel41.TabIndex = 0
        Me.UltraLabel41.Text = "Desde:"
        '
        'ColorFormato1
        '
        Me.ColorFormato1.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorFormato1.Location = New System.Drawing.Point(400, 25)
        Me.ColorFormato1.Name = "ColorFormato1"
        Me.ColorFormato1.Size = New System.Drawing.Size(43, 19)
        Me.ColorFormato1.TabIndex = 7
        Me.ColorFormato1.Text = "Control"
        '
        'btnLiquidaciones
        '
        Appearance37.Image = "266.png"
        Appearance37.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance37.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnLiquidaciones.Appearance = Appearance37
        Me.btnLiquidaciones.ImageList = Me.imagenes
        Me.btnLiquidaciones.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnLiquidaciones.Location = New System.Drawing.Point(142, 28)
        Me.btnLiquidaciones.Name = "btnLiquidaciones"
        Me.btnLiquidaciones.Size = New System.Drawing.Size(45, 30)
        Me.btnLiquidaciones.TabIndex = 12
        '
        'fecDesdeLiquidacion
        '
        Me.fecDesdeLiquidacion.DateTime = New Date(2015, 11, 17, 0, 0, 0, 0)
        Me.fecDesdeLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesdeLiquidacion.Location = New System.Drawing.Point(47, 9)
        Me.fecDesdeLiquidacion.MaskInput = ""
        Me.fecDesdeLiquidacion.Name = "fecDesdeLiquidacion"
        Me.fecDesdeLiquidacion.Size = New System.Drawing.Size(90, 21)
        Me.fecDesdeLiquidacion.TabIndex = 1
        Me.fecDesdeLiquidacion.Value = New Date(2015, 11, 17, 0, 0, 0, 0)
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.agrContCarga)
        Me.UltraTabPageControl6.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1344, 465)
        '
        'agrContCarga
        '
        Me.agrContCarga.Controls.Add(Me.ugb_Espera)
        Me.agrContCarga.Controls.Add(Me.ficCargas)
        Me.agrContCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrContCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrContCarga.ForeColor = System.Drawing.Color.Black
        Me.agrContCarga.Location = New System.Drawing.Point(0, 100)
        Me.agrContCarga.Name = "agrContCarga"
        Me.agrContCarga.Size = New System.Drawing.Size(1344, 365)
        Me.agrContCarga.TabIndex = 0
        Me.agrContCarga.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(356, 150)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 5
        Me.ugb_Espera.Visible = False
        '
        'ficCargas
        '
        Me.ficCargas.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.ficCargas.Controls.Add(Me.UltraTabPageControl10)
        Me.ficCargas.Controls.Add(Me.UltraTabPageControl11)
        Me.ficCargas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficCargas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficCargas.Location = New System.Drawing.Point(2, 2)
        Me.ficCargas.Name = "ficCargas"
        Me.ficCargas.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.ficCargas.Size = New System.Drawing.Size(1340, 361)
        Me.ficCargas.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficCargas.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl10
        UltraTab1.Text = "Lista Cargas"
        UltraTab2.TabPage = Me.UltraTabPageControl11
        UltraTab2.Text = "Cargas Proceso"
        UltraTab2.Visible = False
        Me.ficCargas.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficCargas.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1338, 338)
        '
        'agrBusqueda
        '
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.BackColor2 = System.Drawing.Color.White
        Me.agrBusqueda.ContentAreaAppearance = Appearance38
        Me.agrBusqueda.Controls.Add(Me.UltraLabel2)
        Me.agrBusqueda.Controls.Add(Me.cboActividadNegocioLista)
        Me.agrBusqueda.Controls.Add(Me.cboClienteLista)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel4)
        Me.agrBusqueda.Controls.Add(Me.cboTipoCarga)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel15)
        Me.agrBusqueda.Controls.Add(Me.verViajeRetorno)
        Me.agrBusqueda.Controls.Add(Me.btnConsolidar)
        Me.agrBusqueda.Controls.Add(Me.ColorCambio)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta31)
        Me.agrBusqueda.Controls.Add(Me.Agrupacion5)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta25)
        Me.agrBusqueda.Controls.Add(Me.fecHasta)
        Me.agrBusqueda.Controls.Add(Me.fecDesde)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta18)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta8)
        Me.agrBusqueda.Controls.Add(Me.verSelecion)
        Me.agrBusqueda.Controls.Add(Me.txtNroGuiaT)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta20)
        Me.agrBusqueda.Controls.Add(Me.cboCentro)
        Me.agrBusqueda.Controls.Add(Me.etiCentro)
        Me.agrBusqueda.Controls.Add(Me.cboRecuperado)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta6)
        Me.agrBusqueda.Controls.Add(Me.cboFactura)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta5)
        Me.agrBusqueda.Controls.Add(Me.agrRecuperados)
        Me.agrBusqueda.Controls.Add(Me.etiRecuperados)
        Me.agrBusqueda.Controls.Add(Me.cboTracto)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1344, 100)
        Me.agrBusqueda.TabIndex = 1
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Appearance39.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance39
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(380, 55)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel2.TabIndex = 18
        Me.UltraLabel2.Text = "Proceso:"
        '
        'cboActividadNegocioLista
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocioLista.Appearance = Appearance40
        Me.cboActividadNegocioLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocioLista.DisplayMember = "Nombre"
        Me.cboActividadNegocioLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocioLista.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocioLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocioLista.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocioLista.ImageList = Me.imagenes
        Me.cboActividadNegocioLista.Location = New System.Drawing.Point(432, 51)
        Me.cboActividadNegocioLista.Name = "cboActividadNegocioLista"
        Me.cboActividadNegocioLista.Size = New System.Drawing.Size(150, 21)
        Me.cboActividadNegocioLista.TabIndex = 19
        Me.cboActividadNegocioLista.ValueMember = "Id"
        '
        'cboClienteLista
        '
        Appearance41.ForeColor = System.Drawing.Color.Black
        Me.cboClienteLista.Appearance = Appearance41
        Me.cboClienteLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClienteLista.DisplayMember = "Nombre"
        Me.cboClienteLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteLista.ForeColor = System.Drawing.Color.Black
        Me.cboClienteLista.ImageList = Me.imagenes
        Me.cboClienteLista.Location = New System.Drawing.Point(282, 74)
        Me.cboClienteLista.Name = "cboClienteLista"
        Me.cboClienteLista.Size = New System.Drawing.Size(300, 21)
        Me.cboClienteLista.TabIndex = 21
        Me.cboClienteLista.ValueMember = "Id"
        '
        'UltraLabel4
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Appearance42.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance42
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(238, 78)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel4.TabIndex = 20
        Me.UltraLabel4.Text = "Cliente:"
        '
        'cboTipoCarga
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboTipoCarga.Appearance = Appearance43
        Me.cboTipoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoCarga.DisplayMember = "Nombre"
        Me.cboTipoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarga.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCarga.ForeColor = System.Drawing.Color.Black
        Me.cboTipoCarga.ImageList = Me.imagenes
        Me.cboTipoCarga.Location = New System.Drawing.Point(79, 50)
        Me.cboTipoCarga.Name = "cboTipoCarga"
        Me.cboTipoCarga.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoCarga.TabIndex = 5
        Me.cboTipoCarga.ValueMember = "Id"
        '
        'UltraLabel15
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Appearance44.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance44
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel15.Location = New System.Drawing.Point(15, 54)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(62, 15)
        Me.UltraLabel15.TabIndex = 4
        Me.UltraLabel15.Text = "Tipo Carga:"
        '
        'verViajeRetorno
        '
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.verViajeRetorno.Appearance = Appearance45
        Me.verViajeRetorno.AutoSize = True
        Me.verViajeRetorno.BackColor = System.Drawing.Color.Transparent
        Me.verViajeRetorno.BackColorInternal = System.Drawing.Color.Transparent
        Me.verViajeRetorno.Location = New System.Drawing.Point(118, 78)
        Me.verViajeRetorno.Name = "verViajeRetorno"
        Me.verViajeRetorno.Size = New System.Drawing.Size(109, 17)
        Me.verViajeRetorno.TabIndex = 7
        Me.verViajeRetorno.Text = "Incluir V. Retorno"
        '
        'btnConsolidar
        '
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Me.btnConsolidar.Appearance = Appearance46
        Me.btnConsolidar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnConsolidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsolidar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsolidar.ForeColor = System.Drawing.Color.Black
        Me.btnConsolidar.Location = New System.Drawing.Point(593, 59)
        Me.btnConsolidar.Name = "btnConsolidar"
        Me.btnConsolidar.Size = New System.Drawing.Size(75, 25)
        Me.btnConsolidar.TabIndex = 25
        Me.btnConsolidar.Text = "&Consolidar"
        '
        'ColorCambio
        '
        Me.ColorCambio.Color = System.Drawing.Color.Cyan
        Me.ColorCambio.Location = New System.Drawing.Point(1028, 60)
        Me.ColorCambio.Name = "ColorCambio"
        Me.ColorCambio.Size = New System.Drawing.Size(44, 21)
        Me.ColorCambio.TabIndex = 28
        Me.ColorCambio.Text = "Cyan"
        '
        'Etiqueta31
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance47
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(1026, 44)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta31.TabIndex = 27
        Me.Etiqueta31.Text = "Cambio:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.colorRestablecido)
        Me.Agrupacion5.Controls.Add(Me.etiRestablecido)
        Me.Agrupacion5.Controls.Add(Me.colorConDocFac)
        Me.Agrupacion5.Controls.Add(Me.etiConDocFac)
        Me.Agrupacion5.Controls.Add(Me.colorSinDocFac)
        Me.Agrupacion5.Controls.Add(Me.colorDocPerFac)
        Me.Agrupacion5.Controls.Add(Me.etiSinDoc)
        Me.Agrupacion5.Controls.Add(Me.etiDocPerFac)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(674, 34)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(350, 50)
        Me.Agrupacion5.TabIndex = 26
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorRestablecido
        '
        Me.colorRestablecido.Location = New System.Drawing.Point(153, 27)
        Me.colorRestablecido.Name = "colorRestablecido"
        Me.colorRestablecido.Size = New System.Drawing.Size(43, 21)
        Me.colorRestablecido.TabIndex = 7
        Me.colorRestablecido.Text = "Control"
        '
        'etiRestablecido
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.etiRestablecido.Appearance = Appearance48
        Me.etiRestablecido.AutoSize = True
        Me.etiRestablecido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRestablecido.ForeColor = System.Drawing.Color.Black
        Me.etiRestablecido.Location = New System.Drawing.Point(5, 31)
        Me.etiRestablecido.Name = "etiRestablecido"
        Me.etiRestablecido.Size = New System.Drawing.Size(146, 15)
        Me.etiRestablecido.TabIndex = 6
        Me.etiRestablecido.Text = "Restablecidos a Por Factuar:"
        '
        'colorConDocFac
        '
        Me.colorConDocFac.Location = New System.Drawing.Point(56, 4)
        Me.colorConDocFac.Name = "colorConDocFac"
        Me.colorConDocFac.Size = New System.Drawing.Size(43, 21)
        Me.colorConDocFac.TabIndex = 1
        Me.colorConDocFac.Text = "Control"
        '
        'etiConDocFac
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.etiConDocFac.Appearance = Appearance49
        Me.etiConDocFac.AutoSize = True
        Me.etiConDocFac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiConDocFac.ForeColor = System.Drawing.Color.Black
        Me.etiConDocFac.Location = New System.Drawing.Point(4, 8)
        Me.etiConDocFac.Name = "etiConDocFac"
        Me.etiConDocFac.Size = New System.Drawing.Size(49, 15)
        Me.etiConDocFac.TabIndex = 0
        Me.etiConDocFac.Text = "Con Doc."
        '
        'colorSinDocFac
        '
        Me.colorSinDocFac.Location = New System.Drawing.Point(151, 4)
        Me.colorSinDocFac.Name = "colorSinDocFac"
        Me.colorSinDocFac.Size = New System.Drawing.Size(43, 21)
        Me.colorSinDocFac.TabIndex = 3
        Me.colorSinDocFac.Text = "Control"
        '
        'colorDocPerFac
        '
        Me.colorDocPerFac.Location = New System.Drawing.Point(301, 4)
        Me.colorDocPerFac.Name = "colorDocPerFac"
        Me.colorDocPerFac.Size = New System.Drawing.Size(44, 21)
        Me.colorDocPerFac.TabIndex = 5
        Me.colorDocPerFac.Text = "Control"
        '
        'etiSinDoc
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.etiSinDoc.Appearance = Appearance50
        Me.etiSinDoc.AutoSize = True
        Me.etiSinDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSinDoc.ForeColor = System.Drawing.Color.Black
        Me.etiSinDoc.Location = New System.Drawing.Point(104, 7)
        Me.etiSinDoc.Name = "etiSinDoc"
        Me.etiSinDoc.Size = New System.Drawing.Size(45, 15)
        Me.etiSinDoc.TabIndex = 2
        Me.etiSinDoc.Text = "Sin Doc."
        '
        'etiDocPerFac
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.etiDocPerFac.Appearance = Appearance51
        Me.etiDocPerFac.AutoSize = True
        Me.etiDocPerFac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDocPerFac.ForeColor = System.Drawing.Color.Black
        Me.etiDocPerFac.Location = New System.Drawing.Point(199, 8)
        Me.etiDocPerFac.Name = "etiDocPerFac"
        Me.etiDocPerFac.Size = New System.Drawing.Size(100, 15)
        Me.etiDocPerFac.TabIndex = 4
        Me.etiDocPerFac.Text = "Con Doc. Perdidos:"
        '
        'Etiqueta25
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance52
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(611, 40)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta25.TabIndex = 24
        Me.Etiqueta25.Text = "Facturados:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(482, 4)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(100, 20)
        Me.fecHasta.TabIndex = 11
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(282, 5)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(100, 20)
        Me.fecDesde.TabIndex = 9
        '
        'Etiqueta18
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance53
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(443, 7)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta18.TabIndex = 10
        Me.Etiqueta18.Text = "Hasta:"
        '
        'Etiqueta8
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance54
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(240, 8)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta8.TabIndex = 8
        Me.Etiqueta8.Text = "Desde:"
        '
        'verSelecion
        '
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.verSelecion.Appearance = Appearance55
        Me.verSelecion.BackColor = System.Drawing.Color.Transparent
        Me.verSelecion.BackColorInternal = System.Drawing.Color.Transparent
        Me.verSelecion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verSelecion.ForeColor = System.Drawing.Color.Black
        Me.verSelecion.Location = New System.Drawing.Point(5, 73)
        Me.verSelecion.Name = "verSelecion"
        Me.verSelecion.Size = New System.Drawing.Size(80, 29)
        Me.verSelecion.TabIndex = 6
        Me.verSelecion.Text = "Seleccionar Todo"
        '
        'txtNroGuiaT
        '
        Me.txtNroGuiaT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroGuiaT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroGuiaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuiaT.Location = New System.Drawing.Point(482, 26)
        Me.txtNroGuiaT.Name = "txtNroGuiaT"
        Me.txtNroGuiaT.Size = New System.Drawing.Size(100, 21)
        Me.txtNroGuiaT.TabIndex = 15
        '
        'Etiqueta20
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance56
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(435, 30)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(44, 15)
        Me.Etiqueta20.TabIndex = 14
        Me.Etiqueta20.Text = "Nro GT:"
        '
        'cboCentro
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance57
        Me.cboCentro.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(282, 51)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(90, 21)
        Me.cboCentro.TabIndex = 17
        Me.cboCentro.ValueMember = "Abreviatura"
        '
        'etiCentro
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.etiCentro.Appearance = Appearance58
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentro.ForeColor = System.Drawing.Color.Black
        Me.etiCentro.Location = New System.Drawing.Point(239, 55)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(41, 15)
        Me.etiCentro.TabIndex = 16
        Me.etiCentro.Text = "Centro:"
        '
        'cboRecuperado
        '
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.cboRecuperado.Appearance = Appearance59
        Me.cboRecuperado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboRecuperado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRecuperado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboRecuperado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecuperado.ForeColor = System.Drawing.Color.Black
        Me.cboRecuperado.Location = New System.Drawing.Point(79, 27)
        Me.cboRecuperado.Name = "cboRecuperado"
        Me.cboRecuperado.Size = New System.Drawing.Size(150, 21)
        Me.cboRecuperado.TabIndex = 3
        Me.cboRecuperado.ValueMember = "Id"
        '
        'Etiqueta6
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance60
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(4, 31)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Recuperados:"
        '
        'cboFactura
        '
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.cboFactura.Appearance = Appearance61
        Me.cboFactura.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFactura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFactura.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFactura.ForeColor = System.Drawing.Color.Black
        Me.cboFactura.Location = New System.Drawing.Point(79, 4)
        Me.cboFactura.Name = "cboFactura"
        Me.cboFactura.Size = New System.Drawing.Size(150, 21)
        Me.cboFactura.TabIndex = 1
        Me.cboFactura.ValueMember = "Id"
        '
        'Etiqueta5
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance62
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(33, 8)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Cargas:"
        '
        'agrRecuperados
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.agrRecuperados.Appearance = Appearance63
        Me.agrRecuperados.Controls.Add(Me.colorConDocumentos)
        Me.agrRecuperados.Controls.Add(Me.etiConDocumentos)
        Me.agrRecuperados.Controls.Add(Me.colorSinDocumentos)
        Me.agrRecuperados.Controls.Add(Me.colorConDocumentosPerdidos)
        Me.agrRecuperados.Controls.Add(Me.etiSinDocumentos)
        Me.agrRecuperados.Controls.Add(Me.etiConDocumentosPerdidos)
        Me.agrRecuperados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRecuperados.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRecuperados.Location = New System.Drawing.Point(674, 3)
        Me.agrRecuperados.Name = "agrRecuperados"
        Me.agrRecuperados.Size = New System.Drawing.Size(350, 30)
        Me.agrRecuperados.TabIndex = 23
        Me.agrRecuperados.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorConDocumentos
        '
        Me.colorConDocumentos.Location = New System.Drawing.Point(56, 5)
        Me.colorConDocumentos.Name = "colorConDocumentos"
        Me.colorConDocumentos.Size = New System.Drawing.Size(43, 21)
        Me.colorConDocumentos.TabIndex = 1
        Me.colorConDocumentos.Text = "Control"
        '
        'etiConDocumentos
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Me.etiConDocumentos.Appearance = Appearance64
        Me.etiConDocumentos.AutoSize = True
        Me.etiConDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiConDocumentos.ForeColor = System.Drawing.Color.Black
        Me.etiConDocumentos.Location = New System.Drawing.Point(4, 9)
        Me.etiConDocumentos.Name = "etiConDocumentos"
        Me.etiConDocumentos.Size = New System.Drawing.Size(49, 15)
        Me.etiConDocumentos.TabIndex = 0
        Me.etiConDocumentos.Text = "Con Doc."
        '
        'colorSinDocumentos
        '
        Me.colorSinDocumentos.Location = New System.Drawing.Point(151, 5)
        Me.colorSinDocumentos.Name = "colorSinDocumentos"
        Me.colorSinDocumentos.Size = New System.Drawing.Size(43, 21)
        Me.colorSinDocumentos.TabIndex = 3
        Me.colorSinDocumentos.Text = "Control"
        '
        'colorConDocumentosPerdidos
        '
        Me.colorConDocumentosPerdidos.Location = New System.Drawing.Point(301, 5)
        Me.colorConDocumentosPerdidos.Name = "colorConDocumentosPerdidos"
        Me.colorConDocumentosPerdidos.Size = New System.Drawing.Size(44, 21)
        Me.colorConDocumentosPerdidos.TabIndex = 5
        Me.colorConDocumentosPerdidos.Text = "Control"
        '
        'etiSinDocumentos
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.etiSinDocumentos.Appearance = Appearance65
        Me.etiSinDocumentos.AutoSize = True
        Me.etiSinDocumentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSinDocumentos.ForeColor = System.Drawing.Color.Black
        Me.etiSinDocumentos.Location = New System.Drawing.Point(103, 9)
        Me.etiSinDocumentos.Name = "etiSinDocumentos"
        Me.etiSinDocumentos.Size = New System.Drawing.Size(45, 15)
        Me.etiSinDocumentos.TabIndex = 2
        Me.etiSinDocumentos.Text = "Sin Doc."
        '
        'etiConDocumentosPerdidos
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.etiConDocumentosPerdidos.Appearance = Appearance66
        Me.etiConDocumentosPerdidos.AutoSize = True
        Me.etiConDocumentosPerdidos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiConDocumentosPerdidos.ForeColor = System.Drawing.Color.Black
        Me.etiConDocumentosPerdidos.Location = New System.Drawing.Point(199, 9)
        Me.etiConDocumentosPerdidos.Name = "etiConDocumentosPerdidos"
        Me.etiConDocumentosPerdidos.Size = New System.Drawing.Size(100, 15)
        Me.etiConDocumentosPerdidos.TabIndex = 4
        Me.etiConDocumentosPerdidos.Text = "Con Doc. Perdidos:"
        '
        'etiRecuperados
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Me.etiRecuperados.Appearance = Appearance67
        Me.etiRecuperados.AutoSize = True
        Me.etiRecuperados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRecuperados.ForeColor = System.Drawing.Color.Black
        Me.etiRecuperados.Location = New System.Drawing.Point(601, 13)
        Me.etiRecuperados.Name = "etiRecuperados"
        Me.etiRecuperados.Size = New System.Drawing.Size(72, 15)
        Me.etiRecuperados.TabIndex = 22
        Me.etiRecuperados.Text = "Recuperados:"
        '
        'cboTracto
        '
        Appearance68.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance68
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Location = New System.Drawing.Point(282, 28)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(90, 21)
        Me.cboTracto.TabIndex = 13
        Me.cboTracto.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance69
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(240, 32)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(40, 15)
        Me.Etiqueta1.TabIndex = 12
        Me.Etiqueta1.Text = "Tracto:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.griDocumentoVenta)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusquedaDoc)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1344, 465)
        '
        'griDocumentoVenta
        '
        Me.griDocumentoVenta.ContextMenuStrip = Me.mnuFacturar
        Me.griDocumentoVenta.DisplayLayout.ColumnChooserEnabled = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDocumentoVenta.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDocumentoVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumentoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumentoVenta.Location = New System.Drawing.Point(0, 79)
        Me.griDocumentoVenta.Name = "griDocumentoVenta"
        Me.griDocumentoVenta.Size = New System.Drawing.Size(1344, 386)
        Me.griDocumentoVenta.TabIndex = 1
        '
        'mnuFacturar
        '
        Me.mnuFacturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFacturar.ForeColor = System.Drawing.Color.Black
        Me.mnuFacturar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNuevo, Me.tsmiEditar, Me.tsmiEliminar, Me.tsmiEmitir, Me.tsmiAnular, Me.tsmiDescargarPDF, Me.tsmiDescargarXML})
        Me.mnuFacturar.Name = "mnuFacturar"
        Me.mnuFacturar.Size = New System.Drawing.Size(181, 180)
        '
        'tsmiNuevo
        '
        Me.tsmiNuevo.Image = CType(resources.GetObject("tsmiNuevo.Image"), System.Drawing.Image)
        Me.tsmiNuevo.Name = "tsmiNuevo"
        Me.tsmiNuevo.Size = New System.Drawing.Size(180, 22)
        Me.tsmiNuevo.Text = "Nuevo"
        '
        'tsmiEditar
        '
        Me.tsmiEditar.Image = CType(resources.GetObject("tsmiEditar.Image"), System.Drawing.Image)
        Me.tsmiEditar.Name = "tsmiEditar"
        Me.tsmiEditar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEditar.Text = "Editar"
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = CType(resources.GetObject("tsmiEliminar.Image"), System.Drawing.Image)
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEliminar.Text = "Eliminar"
        '
        'tsmiEmitir
        '
        Me.tsmiEmitir.Image = CType(resources.GetObject("tsmiEmitir.Image"), System.Drawing.Image)
        Me.tsmiEmitir.Name = "tsmiEmitir"
        Me.tsmiEmitir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmiEmitir.Size = New System.Drawing.Size(180, 22)
        Me.tsmiEmitir.Text = "Emitir"
        '
        'tsmiAnular
        '
        Me.tsmiAnular.Image = CType(resources.GetObject("tsmiAnular.Image"), System.Drawing.Image)
        Me.tsmiAnular.Name = "tsmiAnular"
        Me.tsmiAnular.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.tsmiAnular.Size = New System.Drawing.Size(180, 22)
        Me.tsmiAnular.Text = "Anular"
        '
        'tsmiDescargarPDF
        '
        Me.tsmiDescargarPDF.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Formato1ToolStripMenuItem, Me.Formato2ToolStripMenuItem})
        Me.tsmiDescargarPDF.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.tsmiDescargarPDF.Name = "tsmiDescargarPDF"
        Me.tsmiDescargarPDF.Size = New System.Drawing.Size(180, 22)
        Me.tsmiDescargarPDF.Text = "Ver PDF"
        '
        'tsmiDescargarXML
        '
        Me.tsmiDescargarXML.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.tsmiDescargarXML.Name = "tsmiDescargarXML"
        Me.tsmiDescargarXML.Size = New System.Drawing.Size(180, 22)
        Me.tsmiDescargarXML.Text = "Descargar XML"
        '
        'agrBusquedaDoc
        '
        Appearance70.BackColor = System.Drawing.Color.White
        Appearance70.BackColor2 = System.Drawing.Color.White
        Me.agrBusquedaDoc.ContentAreaAppearance = Appearance70
        Me.agrBusquedaDoc.Controls.Add(Me.fecHastaDoc)
        Me.agrBusquedaDoc.Controls.Add(Me.fecDesdeDoc)
        Me.agrBusquedaDoc.Controls.Add(Me.Etiqueta21)
        Me.agrBusquedaDoc.Controls.Add(Me.Etiqueta22)
        Me.agrBusquedaDoc.Controls.Add(Me.cboTipoDocB)
        Me.agrBusquedaDoc.Controls.Add(Me.Etiqueta7)
        Me.agrBusquedaDoc.Controls.Add(Me.txtNumeroB)
        Me.agrBusquedaDoc.Controls.Add(Me.txtSerieB)
        Me.agrBusquedaDoc.Controls.Add(Me.Etiqueta4)
        Me.agrBusquedaDoc.Controls.Add(Me.Etiqueta3)
        Me.agrBusquedaDoc.Controls.Add(Me.agrPorVencimiento)
        Me.agrBusquedaDoc.Controls.Add(Me.etiPorVencimiento)
        Me.agrBusquedaDoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusquedaDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusquedaDoc.ForeColor = System.Drawing.Color.Black
        Me.agrBusquedaDoc.Location = New System.Drawing.Point(0, 0)
        Me.agrBusquedaDoc.Name = "agrBusquedaDoc"
        Me.agrBusquedaDoc.Size = New System.Drawing.Size(1344, 79)
        Me.agrBusquedaDoc.TabIndex = 0
        Me.agrBusquedaDoc.Text = "Datos de Busqueda:"
        Me.agrBusquedaDoc.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecHastaDoc
        '
        Me.fecHastaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHastaDoc.Location = New System.Drawing.Point(60, 51)
        Me.fecHastaDoc.Name = "fecHastaDoc"
        Me.fecHastaDoc.Size = New System.Drawing.Size(98, 20)
        Me.fecHastaDoc.TabIndex = 3
        '
        'fecDesdeDoc
        '
        Me.fecDesdeDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesdeDoc.Location = New System.Drawing.Point(60, 25)
        Me.fecDesdeDoc.Name = "fecDesdeDoc"
        Me.fecDesdeDoc.Size = New System.Drawing.Size(98, 20)
        Me.fecDesdeDoc.TabIndex = 1
        '
        'Etiqueta21
        '
        Appearance71.BackColor = System.Drawing.Color.Transparent
        Appearance71.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance71
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(15, 54)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta22
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance72
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(15, 30)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta22.TabIndex = 0
        Me.Etiqueta22.Text = "Desde:"
        '
        'cboTipoDocB
        '
        Appearance73.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocB.Appearance = Appearance73
        Me.cboTipoDocB.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocB.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocB.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocB.Location = New System.Drawing.Point(224, 23)
        Me.cboTipoDocB.Name = "cboTipoDocB"
        Me.cboTipoDocB.Size = New System.Drawing.Size(141, 21)
        Me.cboTipoDocB.TabIndex = 5
        Me.cboTipoDocB.ValueMember = "Id"
        '
        'Etiqueta7
        '
        Appearance74.BackColor = System.Drawing.Color.Transparent
        Appearance74.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance74
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(167, 27)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(51, 14)
        Me.Etiqueta7.TabIndex = 4
        Me.Etiqueta7.Text = "Tipo Doc:"
        '
        'txtNumeroB
        '
        Appearance75.TextHAlignAsString = "Right"
        Me.txtNumeroB.Appearance = Appearance75
        Me.txtNumeroB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumeroB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumeroB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroB.Location = New System.Drawing.Point(279, 50)
        Me.txtNumeroB.MaxLength = 10
        Me.txtNumeroB.Name = "txtNumeroB"
        Me.txtNumeroB.Size = New System.Drawing.Size(86, 21)
        Me.txtNumeroB.TabIndex = 9
        '
        'txtSerieB
        '
        Appearance76.TextHAlignAsString = "Right"
        Me.txtSerieB.Appearance = Appearance76
        Me.txtSerieB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieB.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieB.Location = New System.Drawing.Point(211, 50)
        Me.txtSerieB.MaxLength = 4
        Me.txtSerieB.Name = "txtSerieB"
        Me.txtSerieB.Size = New System.Drawing.Size(37, 21)
        Me.txtSerieB.TabIndex = 7
        '
        'Etiqueta4
        '
        Appearance77.BackColor = System.Drawing.Color.Transparent
        Appearance77.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance77
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(254, 54)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(19, 14)
        Me.Etiqueta4.TabIndex = 8
        Me.Etiqueta4.Text = "Nº:"
        '
        'Etiqueta3
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance78
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(172, 54)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta3.TabIndex = 6
        Me.Etiqueta3.Text = "Serie:"
        '
        'agrPorVencimiento
        '
        Me.agrPorVencimiento.Controls.Add(Me.etiPorVencer2)
        Me.agrPorVencimiento.Controls.Add(Me.numFaltan)
        Me.agrPorVencimiento.Controls.Add(Me.colorPorVencer)
        Me.agrPorVencimiento.Controls.Add(Me.etiPorVencer1)
        Me.agrPorVencimiento.Controls.Add(Me.colorVencidos)
        Me.agrPorVencimiento.Controls.Add(Me.etiVencidos)
        Me.agrPorVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrPorVencimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrPorVencimiento.Location = New System.Drawing.Point(373, 42)
        Me.agrPorVencimiento.Name = "agrPorVencimiento"
        Me.agrPorVencimiento.Size = New System.Drawing.Size(349, 30)
        Me.agrPorVencimiento.TabIndex = 11
        Me.agrPorVencimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiPorVencer2
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Me.etiPorVencer2.Appearance = Appearance79
        Me.etiPorVencer2.AutoSize = True
        Me.etiPorVencer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPorVencer2.ForeColor = System.Drawing.Color.Black
        Me.etiPorVencer2.Location = New System.Drawing.Point(101, 9)
        Me.etiPorVencer2.Name = "etiPorVencer2"
        Me.etiPorVencer2.Size = New System.Drawing.Size(89, 14)
        Me.etiPorVencer2.TabIndex = 2
        Me.etiPorVencer2.Text = "dia(s) Por Vencer"
        '
        'numFaltan
        '
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.numFaltan.Appearance = Appearance80
        Me.numFaltan.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numFaltan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFaltan.ForeColor = System.Drawing.Color.Black
        Me.numFaltan.Location = New System.Drawing.Point(53, 4)
        Me.numFaltan.MaskInput = "nn"
        Me.numFaltan.MinValue = 1
        Me.numFaltan.Name = "numFaltan"
        Me.numFaltan.Size = New System.Drawing.Size(42, 21)
        Me.numFaltan.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numFaltan.TabIndex = 1
        '
        'colorPorVencer
        '
        Me.colorPorVencer.Location = New System.Drawing.Point(193, 4)
        Me.colorPorVencer.Name = "colorPorVencer"
        Me.colorPorVencer.Size = New System.Drawing.Size(43, 21)
        Me.colorPorVencer.TabIndex = 3
        Me.colorPorVencer.Text = "Control"
        '
        'etiPorVencer1
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.etiPorVencer1.Appearance = Appearance81
        Me.etiPorVencer1.AutoSize = True
        Me.etiPorVencer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPorVencer1.ForeColor = System.Drawing.Color.Black
        Me.etiPorVencer1.Location = New System.Drawing.Point(13, 9)
        Me.etiPorVencer1.Name = "etiPorVencer1"
        Me.etiPorVencer1.Size = New System.Drawing.Size(35, 14)
        Me.etiPorVencer1.TabIndex = 0
        Me.etiPorVencer1.Text = "Faltan"
        '
        'colorVencidos
        '
        Me.colorVencidos.Location = New System.Drawing.Point(300, 4)
        Me.colorVencidos.Name = "colorVencidos"
        Me.colorVencidos.Size = New System.Drawing.Size(43, 21)
        Me.colorVencidos.TabIndex = 5
        Me.colorVencidos.Text = "Control"
        '
        'etiVencidos
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Me.etiVencidos.Appearance = Appearance82
        Me.etiVencidos.AutoSize = True
        Me.etiVencidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiVencidos.ForeColor = System.Drawing.Color.Black
        Me.etiVencidos.Location = New System.Drawing.Point(242, 8)
        Me.etiVencidos.Name = "etiVencidos"
        Me.etiVencidos.Size = New System.Drawing.Size(52, 14)
        Me.etiVencidos.TabIndex = 4
        Me.etiVencidos.Text = "Vencidos:"
        '
        'etiPorVencimiento
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Appearance83.ForeColor = System.Drawing.Color.Navy
        Me.etiPorVencimiento.Appearance = Appearance83
        Me.etiPorVencimiento.AutoSize = True
        Me.etiPorVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPorVencimiento.ForeColor = System.Drawing.Color.Black
        Me.etiPorVencimiento.Location = New System.Drawing.Point(374, 20)
        Me.etiPorVencimiento.Name = "etiPorVencimiento"
        Me.etiPorVencimiento.Size = New System.Drawing.Size(88, 14)
        Me.etiPorVencimiento.TabIndex = 10
        Me.etiPorVencimiento.Text = "Por Vencimiento:"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.AutoScroll = True
        Me.UltraTabPageControl3.Controls.Add(Me.agrContenedor)
        Me.UltraTabPageControl3.Controls.Add(Me.agrListaCargas)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1344, 227)
        '
        'agrContenedor
        '
        Me.agrContenedor.Controls.Add(Me.griDetalleDoc)
        Me.agrContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrContenedor.ForeColor = System.Drawing.Color.Black
        Me.agrContenedor.Location = New System.Drawing.Point(22, 0)
        Me.agrContenedor.Name = "agrContenedor"
        Me.agrContenedor.Size = New System.Drawing.Size(1322, 227)
        Me.agrContenedor.TabIndex = 1
        Me.agrContenedor.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griDetalleDoc
        '
        Me.griDetalleDoc.ContextMenuStrip = Me.MenuDetalle
        Me.griDetalleDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleDoc.Location = New System.Drawing.Point(2, 2)
        Me.griDetalleDoc.Name = "griDetalleDoc"
        Me.griDetalleDoc.Size = New System.Drawing.Size(1318, 223)
        Me.griDetalleDoc.TabIndex = 0
        '
        'MenuDetalle
        '
        Me.MenuDetalle.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAplicarValorU, Me.mnuAgregarDetalle})
        Me.MenuDetalle.Name = "mnu_Transferencias"
        Me.MenuDetalle.Size = New System.Drawing.Size(223, 56)
        '
        'mnuAplicarValorU
        '
        Me.mnuAplicarValorU.Image = Global.ISL.Win.My.Resources.Resources.document_properties
        Me.mnuAplicarValorU.Name = "mnuAplicarValorU"
        Me.mnuAplicarValorU.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuAplicarValorU.ShowShortcutKeys = False
        Me.mnuAplicarValorU.Size = New System.Drawing.Size(222, 26)
        Me.mnuAplicarValorU.Text = "Aplicar a Valor Unit"
        '
        'mnuAgregarDetalle
        '
        Me.mnuAgregarDetalle.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.mnuAgregarDetalle.Name = "mnuAgregarDetalle"
        Me.mnuAgregarDetalle.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuAgregarDetalle.ShowShortcutKeys = False
        Me.mnuAgregarDetalle.Size = New System.Drawing.Size(222, 26)
        Me.mnuAgregarDetalle.Text = "Agregar Detalle Consolidado"
        '
        'agrListaCargas
        '
        Me.agrListaCargas.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance84.BackColor = System.Drawing.Color.White
        Appearance84.BackColor2 = System.Drawing.Color.White
        Me.agrListaCargas.ContentAreaAppearance = Appearance84
        Me.agrListaCargas.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrListaCargas.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrListaCargas.Expanded = False
        Me.agrListaCargas.ExpandedSize = New System.Drawing.Size(600, 227)
        Me.agrListaCargas.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrListaCargas.Location = New System.Drawing.Point(0, 0)
        Me.agrListaCargas.Name = "agrListaCargas"
        Me.agrListaCargas.Size = New System.Drawing.Size(22, 227)
        Me.agrListaCargas.TabIndex = 0
        Me.agrListaCargas.Text = "<< Lista de Cargas >>"
        Me.agrListaCargas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.tabViajesLiquidaciones)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(577, 221)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'tabViajesLiquidaciones
        '
        Me.tabViajesLiquidaciones.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabViajesLiquidaciones.Controls.Add(Me.UltraTabPageControl8)
        Me.tabViajesLiquidaciones.Controls.Add(Me.UltraTabPageControl9)
        Me.tabViajesLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabViajesLiquidaciones.Location = New System.Drawing.Point(0, 0)
        Me.tabViajesLiquidaciones.Name = "tabViajesLiquidaciones"
        Me.tabViajesLiquidaciones.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabViajesLiquidaciones.Size = New System.Drawing.Size(577, 221)
        Me.tabViajesLiquidaciones.TabIndex = 0
        UltraTab10.TabPage = Me.UltraTabPageControl8
        UltraTab10.Text = "Viajes"
        UltraTab11.TabPage = Me.UltraTabPageControl9
        UltraTab11.Text = "Liquidaciones"
        UltraTab11.Visible = False
        Me.tabViajesLiquidaciones.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11})
        Me.tabViajesLiquidaciones.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(575, 198)
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl4.Controls.Add(Me.griGuiaRemisionR)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1344, 227)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.griGuiaTransportista)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(794, 227)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griGuiaTransportista
        '
        Me.griGuiaTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griGuiaTransportista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGuiaTransportista.Location = New System.Drawing.Point(2, 2)
        Me.griGuiaTransportista.Name = "griGuiaTransportista"
        Me.griGuiaTransportista.Size = New System.Drawing.Size(790, 223)
        Me.griGuiaTransportista.TabIndex = 0
        Me.griGuiaTransportista.Text = "GUIA TRANSPORTISTA"
        '
        'griGuiaRemisionR
        '
        Me.griGuiaRemisionR.Dock = System.Windows.Forms.DockStyle.Right
        Me.griGuiaRemisionR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griGuiaRemisionR.Location = New System.Drawing.Point(794, 0)
        Me.griGuiaRemisionR.Name = "griGuiaRemisionR"
        Me.griGuiaRemisionR.Size = New System.Drawing.Size(550, 227)
        Me.griGuiaRemisionR.TabIndex = 1
        Me.griGuiaRemisionR.Text = "GUIA REMISION REMITENTE"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griViaje)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1344, 227)
        '
        'griViaje
        '
        Me.griViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViaje.Location = New System.Drawing.Point(0, 0)
        Me.griViaje.Name = "griViaje"
        Me.griViaje.Size = New System.Drawing.Size(1344, 227)
        Me.griViaje.TabIndex = 0
        '
        'UltraTabPageControl12
        '
        Me.UltraTabPageControl12.Controls.Add(Me.griAnticipos)
        Me.UltraTabPageControl12.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl12.Name = "UltraTabPageControl12"
        Me.UltraTabPageControl12.Size = New System.Drawing.Size(1344, 227)
        '
        'griAnticipos
        '
        Appearance85.BackColor = System.Drawing.SystemColors.Window
        Appearance85.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griAnticipos.DisplayLayout.Appearance = Appearance85
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn147.Header.CheckBoxAlignment = Infragistics.Win.UltraWinGrid.HeaderCheckBoxAlignment.Center
        UltraGridColumn147.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn147.Header.VisiblePosition = 0
        UltraGridColumn147.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn71.Header.VisiblePosition = 1
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 2
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 3
        UltraGridColumn74.Header.VisiblePosition = 4
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn75.CellAppearance = Appearance86
        UltraGridColumn75.Header.VisiblePosition = 10
        UltraGridColumn75.Hidden = True
        UltraGridColumn75.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance87.TextHAlignAsString = "Right"
        UltraGridColumn76.CellAppearance = Appearance87
        UltraGridColumn76.Header.VisiblePosition = 11
        UltraGridColumn76.Hidden = True
        UltraGridColumn76.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn77.CellAppearance = Appearance88
        UltraGridColumn77.Header.VisiblePosition = 12
        UltraGridColumn77.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn78.Header.VisiblePosition = 9
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 14
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 15
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.Header.VisiblePosition = 16
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 8
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 17
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 18
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 19
        UltraGridColumn85.Hidden = True
        UltraGridColumn86.Header.VisiblePosition = 6
        UltraGridColumn86.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn87.Header.VisiblePosition = 7
        UltraGridColumn87.Hidden = True
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance89
        UltraGridColumn88.Header.VisiblePosition = 13
        UltraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance90
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn89.Header.VisiblePosition = 20
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn90.Header.VisiblePosition = 21
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 22
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 23
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 24
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 25
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 27
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.Header.VisiblePosition = 28
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.Header.VisiblePosition = 29
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.Header.Caption = "Cliente"
        UltraGridColumn99.Header.VisiblePosition = 5
        UltraGridColumn99.Width = 270
        UltraGridColumn100.Header.VisiblePosition = 30
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 31
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 32
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 33
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 34
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 35
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 36
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 37
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 38
        UltraGridColumn108.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn147, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108})
        Me.griAnticipos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griAnticipos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAnticipos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAnticipos.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griAnticipos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAnticipos.DisplayLayout.GroupByBox.Hidden = True
        Me.griAnticipos.DisplayLayout.GroupByBox.Prompt = " Drag a column header here to group by that column."
        Me.griAnticipos.DisplayLayout.MaxColScrollRegions = 1
        Me.griAnticipos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griAnticipos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAnticipos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAnticipos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAnticipos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAnticipos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAnticipos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griAnticipos.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griAnticipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAnticipos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griAnticipos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griAnticipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAnticipos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griAnticipos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAnticipos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAnticipos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griAnticipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAnticipos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAnticipos.Location = New System.Drawing.Point(0, 0)
        Me.griAnticipos.Name = "griAnticipos"
        Me.griAnticipos.Size = New System.Drawing.Size(1344, 227)
        Me.griAnticipos.TabIndex = 7
        Me.griAnticipos.TabStop = False
        Me.griAnticipos.Text = "Lista de Anticipos"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ficMaterial)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1346, 488)
        '
        'ficMaterial
        '
        Me.ficMaterial.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficMaterial.Controls.Add(Me.UltraTabPageControl6)
        Me.ficMaterial.Controls.Add(Me.UltraTabPageControl7)
        Me.ficMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMaterial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMaterial.Location = New System.Drawing.Point(0, 0)
        Me.ficMaterial.Name = "ficMaterial"
        Me.ficMaterial.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficMaterial.Size = New System.Drawing.Size(1346, 488)
        Me.ficMaterial.TabIndex = 0
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Cargas"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Documentos"
        Me.ficMaterial.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.ficMaterial.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1344, 465)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.AutoScroll = True
        Me.UltraTabPageControl2.Controls.Add(Me.ficDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1346, 488)
        '
        'ficDetalle
        '
        Me.ficDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficDetalle.Controls.Add(Me.UltraTabPageControl12)
        Me.ficDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDetalle.Location = New System.Drawing.Point(0, 238)
        Me.ficDetalle.Name = "ficDetalle"
        Me.ficDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficDetalle.Size = New System.Drawing.Size(1346, 250)
        Me.ficDetalle.TabIndex = 1
        UltraTab12.TabPage = Me.UltraTabPageControl3
        UltraTab12.Text = "Detalle Documento"
        UltraTab13.TabPage = Me.UltraTabPageControl4
        UltraTab13.Text = "GRT - GRR"
        UltraTab14.TabPage = Me.UltraTabPageControl5
        UltraTab14.Text = "Viajes Asociados"
        UltraTab3.TabPage = Me.UltraTabPageControl12
        UltraTab3.Text = "Anticipos"
        Me.ficDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab12, UltraTab13, UltraTab14, UltraTab3})
        Me.ficDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1344, 227)
        '
        'agrDatos
        '
        Appearance91.BackColor = System.Drawing.Color.White
        Appearance91.BackColor2 = System.Drawing.Color.White
        Me.agrDatos.ContentAreaAppearance = Appearance91
        Me.agrDatos.Controls.Add(Me.decAnticipo)
        Me.agrDatos.Controls.Add(Me.cbAnticipo)
        Me.agrDatos.Controls.Add(Me.ChkOcultarProducto)
        Me.agrDatos.Controls.Add(Me.agrTipoBien)
        Me.agrDatos.Controls.Add(Me.ChkAnexo)
        Me.agrDatos.Controls.Add(Me.Etiqueta32)
        Me.agrDatos.Controls.Add(Me.txtOrdenCompra)
        Me.agrDatos.Controls.Add(Me.chkElectronico)
        Me.agrDatos.Controls.Add(Me.cboDirec)
        Me.agrDatos.Controls.Add(Me.verDosDec)
        Me.agrDatos.Controls.Add(Me.verDetalleAdj)
        Me.agrDatos.Controls.Add(Me.verUnDetalle)
        Me.agrDatos.Controls.Add(Me.verIgv)
        Me.agrDatos.Controls.Add(Me.verQuitarCant)
        Me.agrDatos.Controls.Add(Me.decValorUni)
        Me.agrDatos.Controls.Add(Me.verCambiaVU)
        Me.agrDatos.Controls.Add(Me.optCliente)
        Me.agrDatos.Controls.Add(Me.cboOtroCliente)
        Me.agrDatos.Controls.Add(Me.cboDestinatario)
        Me.agrDatos.Controls.Add(Me.verDetraccionCero)
        Me.agrDatos.Controls.Add(Me.verObservaciones)
        Me.agrDatos.Controls.Add(Me.Agrupacion1)
        Me.agrDatos.Controls.Add(Me.decCantTn)
        Me.agrDatos.Controls.Add(Me.verCantidadTn)
        Me.agrDatos.Controls.Add(Me.verFactorRCero)
        Me.agrDatos.Controls.Add(Me.cboCliente2)
        Me.agrDatos.Controls.Add(Me.agrDatosComplementarios)
        Me.agrDatos.Controls.Add(Me.agrDetraccion)
        Me.agrDatos.Controls.Add(Me.cboTipoDocumento)
        Me.agrDatos.Controls.Add(Me.Agrupacion2)
        Me.agrDatos.Controls.Add(Me.txtGlosa)
        Me.agrDatos.Controls.Add(Me.Etiqueta24)
        Me.agrDatos.Controls.Add(Me.Etiqueta19)
        Me.agrDatos.Controls.Add(Me.cboTipoPago)
        Me.agrDatos.Controls.Add(Me.Etiqueta17)
        Me.agrDatos.Controls.Add(Me.cboEstado)
        Me.agrDatos.Controls.Add(Me.Etiqueta13)
        Me.agrDatos.Controls.Add(Me.Etiqueta12)
        Me.agrDatos.Controls.Add(Me.fecDoc)
        Me.agrDatos.Controls.Add(Me.txtNumero)
        Me.agrDatos.Controls.Add(Me.Etiqueta11)
        Me.agrDatos.Controls.Add(Me.txtSerie)
        Me.agrDatos.Controls.Add(Me.Etiqueta10)
        Me.agrDatos.Controls.Add(Me.Etiqueta9)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(1346, 238)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos de Documentos:"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decAnticipo
        '
        Appearance92.ForeColor = System.Drawing.Color.Black
        Me.decAnticipo.Appearance = Appearance92
        Me.decAnticipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decAnticipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decAnticipo.ForeColor = System.Drawing.Color.Black
        Me.decAnticipo.Location = New System.Drawing.Point(1130, 211)
        Me.decAnticipo.MaskInput = "{double:9.2}"
        Me.decAnticipo.Name = "decAnticipo"
        Me.decAnticipo.Nullable = True
        Me.decAnticipo.NullText = "0.00"
        Me.decAnticipo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decAnticipo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decAnticipo.ReadOnly = True
        Me.decAnticipo.Size = New System.Drawing.Size(93, 21)
        Me.decAnticipo.TabIndex = 48
        '
        'cbAnticipo
        '
        Me.cbAnticipo.AutoSize = True
        Me.cbAnticipo.BackColor = System.Drawing.Color.Transparent
        Me.cbAnticipo.ForeColor = System.Drawing.Color.Navy
        Me.cbAnticipo.Location = New System.Drawing.Point(997, 215)
        Me.cbAnticipo.Name = "cbAnticipo"
        Me.cbAnticipo.Size = New System.Drawing.Size(127, 17)
        Me.cbAnticipo.TabIndex = 47
        Me.cbAnticipo.Text = "Facturar con Anticipo"
        Me.cbAnticipo.UseVisualStyleBackColor = False
        '
        'ChkOcultarProducto
        '
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Me.ChkOcultarProducto.Appearance = Appearance93
        Me.ChkOcultarProducto.BackColor = System.Drawing.Color.Transparent
        Me.ChkOcultarProducto.BackColorInternal = System.Drawing.Color.Transparent
        Me.ChkOcultarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOcultarProducto.ForeColor = System.Drawing.Color.Black
        Me.ChkOcultarProducto.Location = New System.Drawing.Point(997, 190)
        Me.ChkOcultarProducto.Name = "ChkOcultarProducto"
        Me.ChkOcultarProducto.Size = New System.Drawing.Size(144, 19)
        Me.ChkOcultarProducto.TabIndex = 43
        Me.ChkOcultarProducto.Text = "Omitir Desc. Producto"
        '
        'agrTipoBien
        '
        Me.agrTipoBien.Controls.Add(Me.cboTipoBien)
        Me.agrTipoBien.Controls.Add(Me.Etiqueta33)
        Me.agrTipoBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTipoBien.ForeColor = System.Drawing.Color.Black
        Me.agrTipoBien.Location = New System.Drawing.Point(997, 91)
        Me.agrTipoBien.Name = "agrTipoBien"
        Me.agrTipoBien.Size = New System.Drawing.Size(253, 70)
        Me.agrTipoBien.TabIndex = 42
        Me.agrTipoBien.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboTipoBien
        '
        Appearance94.ForeColor = System.Drawing.Color.Black
        Me.cboTipoBien.Appearance = Appearance94
        Me.cboTipoBien.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoBien.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoBien.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoBien.ForeColor = System.Drawing.Color.Black
        Me.cboTipoBien.Location = New System.Drawing.Point(18, 28)
        Me.cboTipoBien.Name = "cboTipoBien"
        Me.cboTipoBien.Size = New System.Drawing.Size(220, 21)
        Me.cboTipoBien.TabIndex = 39
        Me.cboTipoBien.ValueMember = "Abreviatura"
        '
        'Etiqueta33
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance95
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(16, 13)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(54, 14)
        Me.Etiqueta33.TabIndex = 40
        Me.Etiqueta33.Text = "Tipo Bien:"
        '
        'ChkAnexo
        '
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.ChkAnexo.Appearance = Appearance96
        Me.ChkAnexo.BackColor = System.Drawing.Color.Transparent
        Me.ChkAnexo.BackColorInternal = System.Drawing.Color.Transparent
        Me.ChkAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAnexo.ForeColor = System.Drawing.Color.Black
        Me.ChkAnexo.Location = New System.Drawing.Point(997, 167)
        Me.ChkAnexo.Name = "ChkAnexo"
        Me.ChkAnexo.Size = New System.Drawing.Size(102, 19)
        Me.ChkAnexo.TabIndex = 41
        Me.ChkAnexo.Text = "Anexo"
        '
        'Etiqueta32
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance97
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(995, 21)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(122, 14)
        Me.Etiqueta32.TabIndex = 38
        Me.Etiqueta32.Text = "Orden Compra/Servicio:"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenCompra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Location = New System.Drawing.Point(995, 39)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(110, 21)
        Me.txtOrdenCompra.TabIndex = 37
        '
        'chkElectronico
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.FontData.BoldAsString = "True"
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.chkElectronico.Appearance = Appearance98
        Me.chkElectronico.AutoSize = True
        Me.chkElectronico.BackColor = System.Drawing.Color.Transparent
        Me.chkElectronico.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkElectronico.Checked = True
        Me.chkElectronico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkElectronico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkElectronico.ForeColor = System.Drawing.Color.Black
        Me.chkElectronico.Location = New System.Drawing.Point(331, 181)
        Me.chkElectronico.Name = "chkElectronico"
        Me.chkElectronico.Size = New System.Drawing.Size(78, 17)
        Me.chkElectronico.TabIndex = 36
        Me.chkElectronico.Text = "Electronico"
        '
        'cboDirec
        '
        Me.cboDirec.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboDirec.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Appearance99.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        EditorButton1.Appearance = Appearance99
        Me.cboDirec.ButtonsRight.Add(EditorButton1)
        Me.cboDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDirec.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboDirec.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDirec.DropDownWidth = 600
        Me.cboDirec.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDirec.Location = New System.Drawing.Point(74, 152)
        Me.cboDirec.Name = "cboDirec"
        Me.cboDirec.Size = New System.Drawing.Size(335, 23)
        Me.cboDirec.TabIndex = 15
        '
        'verDosDec
        '
        Appearance100.FontData.BoldAsString = "True"
        Appearance100.ForeColor = System.Drawing.Color.Navy
        Me.verDosDec.Appearance = Appearance100
        Me.verDosDec.AutoSize = True
        Me.verDosDec.BackColor = System.Drawing.Color.Transparent
        Me.verDosDec.BackColorInternal = System.Drawing.Color.Transparent
        Me.verDosDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verDosDec.ForeColor = System.Drawing.Color.Black
        Me.verDosDec.Location = New System.Drawing.Point(696, 123)
        Me.verDosDec.Name = "verDosDec"
        Me.verDosDec.Size = New System.Drawing.Size(50, 17)
        Me.verDosDec.TabIndex = 23
        Me.verDosDec.Text = "2 Dec"
        '
        'verDetalleAdj
        '
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Me.verDetalleAdj.Appearance = Appearance101
        Me.verDetalleAdj.BackColor = System.Drawing.Color.Transparent
        Me.verDetalleAdj.BackColorInternal = System.Drawing.Color.Transparent
        Me.verDetalleAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verDetalleAdj.ForeColor = System.Drawing.Color.Black
        Me.verDetalleAdj.Location = New System.Drawing.Point(839, 201)
        Me.verDetalleAdj.Name = "verDetalleAdj"
        Me.verDetalleAdj.Size = New System.Drawing.Size(102, 31)
        Me.verDetalleAdj.TabIndex = 33
        Me.verDetalleAdj.Text = "Omitir Detalle Adjunto"
        '
        'verUnDetalle
        '
        Appearance102.ForeColor = System.Drawing.Color.Navy
        Me.verUnDetalle.Appearance = Appearance102
        Me.verUnDetalle.BackColor = System.Drawing.Color.Transparent
        Me.verUnDetalle.BackColorInternal = System.Drawing.Color.Transparent
        Me.verUnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verUnDetalle.ForeColor = System.Drawing.Color.Black
        Me.verUnDetalle.Location = New System.Drawing.Point(772, 202)
        Me.verUnDetalle.Name = "verUnDetalle"
        Me.verUnDetalle.Size = New System.Drawing.Size(61, 31)
        Me.verUnDetalle.TabIndex = 32
        Me.verUnDetalle.Text = "Un Solo Detalle"
        '
        'verIgv
        '
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.verIgv.Appearance = Appearance103
        Me.verIgv.BackColor = System.Drawing.Color.Transparent
        Me.verIgv.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIgv.Checked = True
        Me.verIgv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verIgv.ForeColor = System.Drawing.Color.Black
        Me.verIgv.Location = New System.Drawing.Point(705, 201)
        Me.verIgv.Name = "verIgv"
        Me.verIgv.Size = New System.Drawing.Size(61, 31)
        Me.verIgv.TabIndex = 31
        Me.verIgv.Text = "Imprime IGV"
        '
        'verQuitarCant
        '
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Me.verQuitarCant.Appearance = Appearance104
        Me.verQuitarCant.BackColor = System.Drawing.Color.Transparent
        Me.verQuitarCant.BackColorInternal = System.Drawing.Color.Transparent
        Me.verQuitarCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verQuitarCant.ForeColor = System.Drawing.Color.Black
        Me.verQuitarCant.Location = New System.Drawing.Point(601, 200)
        Me.verQuitarCant.Name = "verQuitarCant"
        Me.verQuitarCant.Size = New System.Drawing.Size(101, 33)
        Me.verQuitarCant.TabIndex = 30
        Me.verQuitarCant.Text = "Omitir Cantidad y Tipo Carga"
        '
        'decValorUni
        '
        Appearance105.ForeColor = System.Drawing.Color.Black
        Me.decValorUni.Appearance = Appearance105
        Me.decValorUni.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decValorUni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decValorUni.ForeColor = System.Drawing.Color.Black
        Me.decValorUni.Location = New System.Drawing.Point(508, 215)
        Me.decValorUni.MaskInput = "{double:4.4}"
        Me.decValorUni.Name = "decValorUni"
        Me.decValorUni.Nullable = True
        Me.decValorUni.NullText = "0.00"
        Me.decValorUni.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decValorUni.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decValorUni.Size = New System.Drawing.Size(87, 21)
        Me.decValorUni.TabIndex = 29
        '
        'verCambiaVU
        '
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Me.verCambiaVU.Appearance = Appearance106
        Me.verCambiaVU.AutoSize = True
        Me.verCambiaVU.BackColor = System.Drawing.Color.Transparent
        Me.verCambiaVU.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCambiaVU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCambiaVU.ForeColor = System.Drawing.Color.Black
        Me.verCambiaVU.Location = New System.Drawing.Point(509, 195)
        Me.verCambiaVU.Name = "verCambiaVU"
        Me.verCambiaVU.Size = New System.Drawing.Size(87, 17)
        Me.verCambiaVU.TabIndex = 28
        Me.verCambiaVU.Text = "Cambiar V.U."
        '
        'optCliente
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.optCliente.Appearance = Appearance107
        Me.optCliente.BackColor = System.Drawing.Color.Transparent
        Me.optCliente.BackColorInternal = System.Drawing.Color.Transparent
        Me.optCliente.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCliente.ForeColor = System.Drawing.Color.Black
        ValueListItem10.DataValue = "Default Item"
        ValueListItem10.DisplayText = "Remitente"
        ValueListItem11.DataValue = "ValueListItem1"
        ValueListItem11.DisplayText = "Destinat"
        ValueListItem12.DataValue = "ValueListItem2"
        ValueListItem12.DisplayText = "Otro"
        Me.optCliente.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem10, ValueListItem11, ValueListItem12})
        Me.optCliente.ItemSpacingVertical = 10
        Me.optCliente.Location = New System.Drawing.Point(5, 78)
        Me.optCliente.Name = "optCliente"
        Me.optCliente.Size = New System.Drawing.Size(69, 71)
        Me.optCliente.TabIndex = 10
        '
        'cboOtroCliente
        '
        Me.cboOtroCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboOtroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboOtroCliente.CheckedListSettings.ListSeparator = ","
        Me.cboOtroCliente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboOtroCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboOtroCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboOtroCliente.DropDownWidth = 400
        Me.cboOtroCliente.Location = New System.Drawing.Point(74, 125)
        Me.cboOtroCliente.Name = "cboOtroCliente"
        Me.cboOtroCliente.Size = New System.Drawing.Size(335, 22)
        Me.cboOtroCliente.TabIndex = 13
        '
        'cboDestinatario
        '
        Me.cboDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboDestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboDestinatario.CheckedListSettings.ListSeparator = ","
        Me.cboDestinatario.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboDestinatario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboDestinatario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboDestinatario.DropDownWidth = 400
        Me.cboDestinatario.Location = New System.Drawing.Point(75, 100)
        Me.cboDestinatario.Name = "cboDestinatario"
        Me.cboDestinatario.Size = New System.Drawing.Size(334, 22)
        Me.cboDestinatario.TabIndex = 12
        '
        'verDetraccionCero
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.FontData.BoldAsString = "True"
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Me.verDetraccionCero.Appearance = Appearance108
        Me.verDetraccionCero.AutoSize = True
        Me.verDetraccionCero.BackColor = System.Drawing.Color.Transparent
        Me.verDetraccionCero.BackColorInternal = System.Drawing.Color.Transparent
        Me.verDetraccionCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verDetraccionCero.ForeColor = System.Drawing.Color.Black
        Me.verDetraccionCero.Location = New System.Drawing.Point(432, 60)
        Me.verDetraccionCero.Name = "verDetraccionCero"
        Me.verDetraccionCero.Size = New System.Drawing.Size(120, 17)
        Me.verDetraccionCero.TabIndex = 21
        Me.verDetraccionCero.Text = "Importe Detraer = 0"
        '
        'verObservaciones
        '
        Appearance109.FontData.BoldAsString = "True"
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.verObservaciones.Appearance = Appearance109
        Me.verObservaciones.AutoSize = True
        Me.verObservaciones.BackColor = System.Drawing.Color.Transparent
        Me.verObservaciones.BackColorInternal = System.Drawing.Color.Transparent
        Me.verObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verObservaciones.ForeColor = System.Drawing.Color.Black
        Me.verObservaciones.Location = New System.Drawing.Point(748, 80)
        Me.verObservaciones.Name = "verObservaciones"
        Me.verObservaciones.Size = New System.Drawing.Size(97, 17)
        Me.verObservaciones.TabIndex = 34
        Me.verObservaciones.Text = "Observaciones"
        '
        'Agrupacion1
        '
        Appearance110.BackColor = System.Drawing.Color.White
        Appearance110.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance110
        Me.Agrupacion1.Controls.Add(Me.txtObrservaciones)
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(746, 91)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(245, 86)
        Me.Agrupacion1.TabIndex = 35
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtObrservaciones
        '
        Me.txtObrservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObrservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObrservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObrservaciones.Location = New System.Drawing.Point(6, 10)
        Me.txtObrservaciones.Multiline = True
        Me.txtObrservaciones.Name = "txtObrservaciones"
        Me.txtObrservaciones.Size = New System.Drawing.Size(230, 65)
        Me.txtObrservaciones.TabIndex = 0
        '
        'decCantTn
        '
        Appearance111.ForeColor = System.Drawing.Color.Black
        Me.decCantTn.Appearance = Appearance111
        Me.decCantTn.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCantTn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decCantTn.ForeColor = System.Drawing.Color.Black
        Me.decCantTn.Location = New System.Drawing.Point(422, 215)
        Me.decCantTn.MaskInput = "{double:4.4}"
        Me.decCantTn.Name = "decCantTn"
        Me.decCantTn.Nullable = True
        Me.decCantTn.NullText = "0.00"
        Me.decCantTn.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decCantTn.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decCantTn.Size = New System.Drawing.Size(80, 21)
        Me.decCantTn.TabIndex = 27
        '
        'verCantidadTn
        '
        Appearance112.ForeColor = System.Drawing.Color.Navy
        Me.verCantidadTn.Appearance = Appearance112
        Me.verCantidadTn.AutoSize = True
        Me.verCantidadTn.BackColor = System.Drawing.Color.Transparent
        Me.verCantidadTn.BackColorInternal = System.Drawing.Color.Transparent
        Me.verCantidadTn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verCantidadTn.ForeColor = System.Drawing.Color.Black
        Me.verCantidadTn.Location = New System.Drawing.Point(423, 195)
        Me.verCantidadTn.Name = "verCantidadTn"
        Me.verCantidadTn.Size = New System.Drawing.Size(80, 17)
        Me.verCantidadTn.TabIndex = 26
        Me.verCantidadTn.Text = "Cambiar TN"
        '
        'verFactorRCero
        '
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Me.verFactorRCero.Appearance = Appearance113
        Me.verFactorRCero.AutoSize = True
        Me.verFactorRCero.BackColor = System.Drawing.Color.Transparent
        Me.verFactorRCero.BackColorInternal = System.Drawing.Color.Transparent
        Me.verFactorRCero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verFactorRCero.ForeColor = System.Drawing.Color.Black
        Me.verFactorRCero.Location = New System.Drawing.Point(350, 204)
        Me.verFactorRCero.Name = "verFactorRCero"
        Me.verFactorRCero.Size = New System.Drawing.Size(62, 17)
        Me.verFactorRCero.TabIndex = 25
        Me.verFactorRCero.Text = "FRU = 0"
        '
        'cboCliente2
        '
        Me.cboCliente2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCliente2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente2.CheckedListSettings.ListSeparator = ","
        Me.cboCliente2.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboCliente2.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboCliente2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente2.DropDownWidth = 400
        Me.cboCliente2.Location = New System.Drawing.Point(75, 76)
        Me.cboCliente2.Name = "cboCliente2"
        Me.cboCliente2.Size = New System.Drawing.Size(334, 22)
        Me.cboCliente2.TabIndex = 11
        '
        'agrDatosComplementarios
        '
        Me.agrDatosComplementarios.Controls.Add(Me.fecPeriodo)
        Me.agrDatosComplementarios.Controls.Add(Me.Etiqueta16)
        Me.agrDatosComplementarios.Controls.Add(Me.cboMoneda)
        Me.agrDatosComplementarios.Controls.Add(Me.Etiqueta14)
        Me.agrDatosComplementarios.Controls.Add(Me.decTipoCambio)
        Me.agrDatosComplementarios.Controls.Add(Me.Etiqueta15)
        Me.agrDatosComplementarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosComplementarios.ForeColor = System.Drawing.Color.Black
        Me.agrDatosComplementarios.Location = New System.Drawing.Point(423, 21)
        Me.agrDatosComplementarios.Name = "agrDatosComplementarios"
        Me.agrDatosComplementarios.Size = New System.Drawing.Size(316, 35)
        Me.agrDatosComplementarios.TabIndex = 18
        Me.agrDatosComplementarios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecPeriodo
        '
        Appearance114.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Appearance = Appearance114
        Me.fecPeriodo.DateTime = New Date(2015, 11, 17, 0, 0, 0, 0)
        Me.fecPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecPeriodo.DropDownButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Never
        Me.fecPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecPeriodo.ForeColor = System.Drawing.Color.Black
        Me.fecPeriodo.Location = New System.Drawing.Point(55, 8)
        Me.fecPeriodo.MaskInput = "mm/yy"
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.Size = New System.Drawing.Size(56, 21)
        Me.fecPeriodo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.fecPeriodo.TabIndex = 1
        Me.fecPeriodo.Value = New Date(2015, 11, 17, 0, 0, 0, 0)
        '
        'Etiqueta16
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance115
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(9, 12)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta16.TabIndex = 0
        Me.Etiqueta16.Text = "Periodo:"
        '
        'cboMoneda
        '
        Appearance116.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance116
        Me.cboMoneda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(167, 7)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(55, 21)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance117
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(117, 12)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta14.TabIndex = 2
        Me.Etiqueta14.Text = "Moneda:"
        '
        'decTipoCambio
        '
        Appearance118.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Appearance = Appearance118
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Location = New System.Drawing.Point(252, 6)
        Me.decTipoCambio.MaskInput = "{double:4.2}"
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.Nullable = True
        Me.decTipoCambio.NullText = "0.00"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTipoCambio.Size = New System.Drawing.Size(55, 21)
        Me.decTipoCambio.TabIndex = 5
        '
        'Etiqueta15
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance119
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(229, 11)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta15.TabIndex = 4
        Me.Etiqueta15.Text = "TC:"
        '
        'agrDetraccion
        '
        Me.agrDetraccion.Controls.Add(Me.UltraLabel3)
        Me.agrDetraccion.Controls.Add(Me.decImporteDetraer)
        Me.agrDetraccion.Controls.Add(Me.UltraLabel5)
        Me.agrDetraccion.Controls.Add(Me.Etiqueta28)
        Me.agrDetraccion.Controls.Add(Me.DecDetraer)
        Me.agrDetraccion.Controls.Add(Me.Etiqueta29)
        Me.agrDetraccion.Controls.Add(Me.decNetoPagar)
        Me.agrDetraccion.Controls.Add(Me.Etiqueta30)
        Me.agrDetraccion.Controls.Add(Me.decDetraccion)
        Me.agrDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetraccion.ForeColor = System.Drawing.Color.Black
        Me.agrDetraccion.Location = New System.Drawing.Point(423, 67)
        Me.agrDetraccion.Name = "agrDetraccion"
        Me.agrDetraccion.Size = New System.Drawing.Size(270, 77)
        Me.agrDetraccion.TabIndex = 22
        Me.agrDetraccion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel3
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance120
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(161, 16)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(14, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "%"
        '
        'decImporteDetraer
        '
        Appearance121.ForeColor = System.Drawing.Color.Black
        Me.decImporteDetraer.Appearance = Appearance121
        Me.decImporteDetraer.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImporteDetraer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImporteDetraer.ForeColor = System.Drawing.Color.Black
        Me.decImporteDetraer.Location = New System.Drawing.Point(5, 52)
        Me.decImporteDetraer.MaskInput = "{double:9.2}"
        Me.decImporteDetraer.Name = "decImporteDetraer"
        Me.decImporteDetraer.Nullable = True
        Me.decImporteDetraer.NullText = "0.00"
        Me.decImporteDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImporteDetraer.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImporteDetraer.ReadOnly = True
        Me.decImporteDetraer.Size = New System.Drawing.Size(81, 21)
        Me.decImporteDetraer.TabIndex = 4
        '
        'UltraLabel5
        '
        Appearance122.BackColor = System.Drawing.Color.Transparent
        Appearance122.ForeColor = System.Drawing.Color.Navy
        Appearance122.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance122
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(22, 15)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(62, 14)
        Me.UltraLabel5.TabIndex = 0
        Me.UltraLabel5.Text = "Porcentaje:"
        '
        'Etiqueta28
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance123
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(3, 36)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta28.TabIndex = 3
        Me.Etiqueta28.Text = "Importe Detraer"
        '
        'DecDetraer
        '
        Me.DecDetraer.Location = New System.Drawing.Point(92, 12)
        Me.DecDetraer.MaskInput = "nnn.nn"
        Me.DecDetraer.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DecDetraer.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DecDetraer.Name = "DecDetraer"
        Me.DecDetraer.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.DecDetraer.Size = New System.Drawing.Size(63, 21)
        Me.DecDetraer.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.DecDetraer.TabIndex = 1
        '
        'Etiqueta29
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance124
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(90, 36)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta29.TabIndex = 5
        Me.Etiqueta29.Text = "Detraccion"
        '
        'decNetoPagar
        '
        Appearance125.ForeColor = System.Drawing.Color.Black
        Me.decNetoPagar.Appearance = Appearance125
        Me.decNetoPagar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decNetoPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decNetoPagar.ForeColor = System.Drawing.Color.Black
        Me.decNetoPagar.Location = New System.Drawing.Point(179, 53)
        Me.decNetoPagar.MaskInput = "{double:9.2}"
        Me.decNetoPagar.Name = "decNetoPagar"
        Me.decNetoPagar.Nullable = True
        Me.decNetoPagar.NullText = "0.00"
        Me.decNetoPagar.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decNetoPagar.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decNetoPagar.ReadOnly = True
        Me.decNetoPagar.Size = New System.Drawing.Size(81, 21)
        Me.decNetoPagar.TabIndex = 8
        '
        'Etiqueta30
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance126
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(177, 37)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta30.TabIndex = 7
        Me.Etiqueta30.Text = "Neto a Pagar"
        '
        'decDetraccion
        '
        Appearance127.ForeColor = System.Drawing.Color.Black
        Me.decDetraccion.Appearance = Appearance127
        Me.decDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDetraccion.ForeColor = System.Drawing.Color.Black
        Me.decDetraccion.Location = New System.Drawing.Point(92, 52)
        Me.decDetraccion.MaskInput = "{double:9.2}"
        Me.decDetraccion.Name = "decDetraccion"
        Me.decDetraccion.Nullable = True
        Me.decDetraccion.NullText = "0.00"
        Me.decDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDetraccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decDetraccion.ReadOnly = True
        Me.decDetraccion.Size = New System.Drawing.Size(81, 21)
        Me.decDetraccion.TabIndex = 6
        '
        'cboTipoDocumento
        '
        Appearance128.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance128
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(74, 23)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(137, 21)
        Me.cboTipoDocumento.TabIndex = 1
        Me.cboTipoDocumento.ValueMember = "Id"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.btnActualizarFleteUnitario)
        Me.Agrupacion2.Controls.Add(Me.decSubTotal)
        Me.Agrupacion2.Controls.Add(Me.etiSubtotal)
        Me.Agrupacion2.Controls.Add(Me.etiImpuesto)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion2.Controls.Add(Me.decImpuesto)
        Me.Agrupacion2.Controls.Add(Me.decTotal)
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(422, 146)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(324, 49)
        Me.Agrupacion2.TabIndex = 24
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnActualizarFleteUnitario
        '
        Appearance129.Image = "266.png"
        Appearance129.ImageHAlign = Infragistics.Win.HAlign.Center
        Appearance129.ImageVAlign = Infragistics.Win.VAlign.Bottom
        Me.btnActualizarFleteUnitario.Appearance = Appearance129
        Me.btnActualizarFleteUnitario.ImageList = Me.imagenes
        Me.btnActualizarFleteUnitario.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnActualizarFleteUnitario.Location = New System.Drawing.Point(288, 13)
        Me.btnActualizarFleteUnitario.Name = "btnActualizarFleteUnitario"
        Me.btnActualizarFleteUnitario.Size = New System.Drawing.Size(30, 30)
        Me.btnActualizarFleteUnitario.TabIndex = 6
        UltraToolTipInfo1.ToolTipText = "Prorratear valor en flete unitario de viajes"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.btnActualizarFleteUnitario, UltraToolTipInfo1)
        '
        'decSubTotal
        '
        Appearance130.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal.Appearance = Appearance130
        Me.decSubTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSubTotal.ForeColor = System.Drawing.Color.Black
        Me.decSubTotal.FormatString = ""
        Me.decSubTotal.Location = New System.Drawing.Point(6, 22)
        Me.decSubTotal.MaskInput = "{double:9.2}"
        Me.decSubTotal.Name = "decSubTotal"
        Me.decSubTotal.NullText = "0.00"
        Me.decSubTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSubTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decSubTotal.ReadOnly = True
        Me.decSubTotal.Size = New System.Drawing.Size(91, 21)
        Me.decSubTotal.TabIndex = 1
        '
        'etiSubtotal
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.etiSubtotal.Appearance = Appearance131
        Me.etiSubtotal.AutoSize = True
        Me.etiSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSubtotal.ForeColor = System.Drawing.Color.Black
        Me.etiSubtotal.Location = New System.Drawing.Point(4, 6)
        Me.etiSubtotal.Name = "etiSubtotal"
        Me.etiSubtotal.Size = New System.Drawing.Size(77, 14)
        Me.etiSubtotal.TabIndex = 0
        Me.etiSubtotal.Text = "Valor de Venta"
        '
        'etiImpuesto
        '
        Appearance132.BackColor = System.Drawing.Color.Transparent
        Appearance132.ForeColor = System.Drawing.Color.Navy
        Me.etiImpuesto.Appearance = Appearance132
        Me.etiImpuesto.AutoSize = True
        Me.etiImpuesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImpuesto.ForeColor = System.Drawing.Color.Black
        Me.etiImpuesto.Location = New System.Drawing.Point(103, 6)
        Me.etiImpuesto.Name = "etiImpuesto"
        Me.etiImpuesto.Size = New System.Drawing.Size(23, 14)
        Me.etiImpuesto.TabIndex = 2
        Me.etiImpuesto.Text = "IGV"
        '
        'Etiqueta27
        '
        Appearance133.BackColor = System.Drawing.Color.Transparent
        Appearance133.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance133
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(191, 6)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(82, 14)
        Me.Etiqueta27.TabIndex = 4
        Me.Etiqueta27.Text = "Precio de Venta"
        '
        'decImpuesto
        '
        Appearance134.ForeColor = System.Drawing.Color.Black
        Me.decImpuesto.Appearance = Appearance134
        Me.decImpuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decImpuesto.ForeColor = System.Drawing.Color.Black
        Me.decImpuesto.FormatString = ""
        Me.decImpuesto.Location = New System.Drawing.Point(103, 22)
        Me.decImpuesto.MaskInput = "{double:9.2}"
        Me.decImpuesto.Name = "decImpuesto"
        Me.decImpuesto.Nullable = True
        Me.decImpuesto.NullText = "0.00"
        Me.decImpuesto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decImpuesto.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decImpuesto.ReadOnly = True
        Me.decImpuesto.Size = New System.Drawing.Size(82, 21)
        Me.decImpuesto.TabIndex = 3
        '
        'decTotal
        '
        Appearance135.ForeColor = System.Drawing.Color.Black
        Me.decTotal.Appearance = Appearance135
        Me.decTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotal.ForeColor = System.Drawing.Color.Black
        Me.decTotal.FormatString = ""
        Me.decTotal.Location = New System.Drawing.Point(191, 22)
        Me.decTotal.MaskInput = "{double:9.2}"
        Me.decTotal.Name = "decTotal"
        Me.decTotal.Nullable = True
        Me.decTotal.NullText = "0.00"
        Me.decTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTotal.ReadOnly = True
        Me.decTotal.Size = New System.Drawing.Size(91, 21)
        Me.decTotal.TabIndex = 5
        '
        'txtGlosa
        '
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.Location = New System.Drawing.Point(749, 39)
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(240, 40)
        Me.txtGlosa.TabIndex = 20
        '
        'Etiqueta24
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance136
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(748, 21)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta24.TabIndex = 19
        Me.Etiqueta24.Text = "Glosa:"
        '
        'Etiqueta19
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance137
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(14, 157)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(53, 14)
        Me.Etiqueta19.TabIndex = 14
        Me.Etiqueta19.Text = "Direccion:"
        '
        'cboTipoPago
        '
        Appearance138.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Appearance = Appearance138
        Me.cboTipoPago.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoPago.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.Location = New System.Drawing.Point(74, 182)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(248, 21)
        Me.cboTipoPago.TabIndex = 17
        Me.cboTipoPago.ValueMember = "Id"
        '
        'Etiqueta17
        '
        Appearance139.BackColor = System.Drawing.Color.Transparent
        Appearance139.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance139
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(12, 184)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta17.TabIndex = 16
        Me.Etiqueta17.Text = "Tipo Pago:"
        '
        'cboEstado
        '
        Appearance140.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Appearance = Appearance140
        Me.cboEstado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.ForeColor = System.Drawing.Color.Black
        Me.cboEstado.Location = New System.Drawing.Point(271, 23)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.ReadOnly = True
        Me.cboEstado.Size = New System.Drawing.Size(137, 21)
        Me.cboEstado.TabIndex = 3
        Me.cboEstado.ValueMember = "Id"
        '
        'Etiqueta13
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance141
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(224, 27)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta13.TabIndex = 2
        Me.Etiqueta13.Text = "Estado:"
        '
        'Etiqueta12
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance142
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(284, 53)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta12.TabIndex = 8
        Me.Etiqueta12.Text = "Fecha:"
        '
        'fecDoc
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.fecDoc.Appearance = Appearance143
        Me.fecDoc.DateTime = New Date(2015, 11, 17, 0, 0, 0, 0)
        Me.fecDoc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecDoc.ForeColor = System.Drawing.Color.Black
        Me.fecDoc.Location = New System.Drawing.Point(328, 51)
        Me.fecDoc.Name = "fecDoc"
        Me.fecDoc.Size = New System.Drawing.Size(80, 21)
        Me.fecDoc.TabIndex = 9
        Me.fecDoc.Value = New Date(2015, 11, 17, 0, 0, 0, 0)
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(177, 51)
        Me.txtNumero.MaxLength = 10
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 21)
        Me.txtNumero.TabIndex = 7
        '
        'Etiqueta11
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance144
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(125, 53)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta11.TabIndex = 6
        Me.Etiqueta11.Text = "Numero:"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Location = New System.Drawing.Point(74, 51)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(45, 21)
        Me.txtSerie.TabIndex = 5
        '
        'Etiqueta10
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance145
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(36, 53)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta10.TabIndex = 4
        Me.Etiqueta10.Text = "Serie:"
        '
        'Etiqueta9
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance146
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(40, 27)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta9.TabIndex = 0
        Me.Etiqueta9.Text = "Tipo:"
        '
        'ficFactura
        '
        Me.ficFactura.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficFactura.Controls.Add(Me.UltraTabPageControl1)
        Me.ficFactura.Controls.Add(Me.UltraTabPageControl2)
        Me.ficFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficFactura.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFactura.Location = New System.Drawing.Point(0, 0)
        Me.ficFactura.Name = "ficFactura"
        Me.ficFactura.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficFactura.Size = New System.Drawing.Size(1348, 511)
        Me.ficFactura.TabIndex = 0
        UltraTab15.TabPage = Me.UltraTabPageControl1
        UltraTab15.Text = "Lista"
        UltraTab16.TabPage = Me.UltraTabPageControl2
        UltraTab16.Text = "Mantenimiento"
        Me.ficFactura.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab15, UltraTab16})
        Me.ficFactura.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 488)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'UltraToolTipManager2
        '
        Me.UltraToolTipManager2.ContainingControl = Me
        '
        'Formato1ToolStripMenuItem
        '
        Me.Formato1ToolStripMenuItem.Name = "Formato1ToolStripMenuItem"
        Me.Formato1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formato1ToolStripMenuItem.Text = "Formato 1"
        '
        'Formato2ToolStripMenuItem
        '
        Me.Formato2ToolStripMenuItem.Name = "Formato2ToolStripMenuItem"
        Me.Formato2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Formato2ToolStripMenuItem.Text = "Formato 2"
        '
        'frm_FacturarCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 511)
        Me.Controls.Add(Me.ficFactura)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_FacturarCarga"
        Me.Text = "Facturación de Cargas"
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.griFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCargas.ResumeLayout(False)
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.griViajesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdViajesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.VerSeleccionProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.griListaCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.verIncluirViajeR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTracto3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.griLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.cboClaseServicioTottus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcFormatoLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecHastaLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorFormato1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesdeLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.agrContCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrContCarga.ResumeLayout(False)
        CType(Me.ficCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficCargas.ResumeLayout(False)
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboActividadNegocioLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verViajeRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.colorRestablecido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorConDocFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorSinDocFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorDocPerFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verSelecion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroGuiaT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRecuperado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrRecuperados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRecuperados.ResumeLayout(False)
        Me.agrRecuperados.PerformLayout()
        CType(Me.colorConDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorSinDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorConDocumentosPerdidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.griDocumentoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuFacturar.ResumeLayout(False)
        CType(Me.agrBusquedaDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusquedaDoc.ResumeLayout(False)
        Me.agrBusquedaDoc.PerformLayout()
        CType(Me.cboTipoDocB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrPorVencimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrPorVencimiento.ResumeLayout(False)
        Me.agrPorVencimiento.PerformLayout()
        CType(Me.numFaltan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.agrContenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrContenedor.ResumeLayout(False)
        CType(Me.griDetalleDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuDetalle.ResumeLayout(False)
        CType(Me.agrListaCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaCargas.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.tabViajesLiquidaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabViajesLiquidaciones.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.griGuiaTransportista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griGuiaRemisionR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl12.ResumeLayout(False)
        CType(Me.griAnticipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ficMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMaterial.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDetalle.ResumeLayout(False)
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.decAnticipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkOcultarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrTipoBien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTipoBien.ResumeLayout(False)
        Me.agrTipoBien.PerformLayout()
        CType(Me.cboTipoBien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAnexo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrdenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkElectronico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDirec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDosDec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDetalleAdj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verUnDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verQuitarCant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decValorUni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCambiaVU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOtroCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDestinatario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verDetraccionCero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.txtObrservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decCantTn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verCantidadTn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verFactorRCero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosComplementarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosComplementarios.ResumeLayout(False)
        Me.agrDatosComplementarios.PerformLayout()
        CType(Me.fecPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetraccion.ResumeLayout(False)
        Me.agrDetraccion.PerformLayout()
        CType(Me.decImporteDetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDetraer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decNetoPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.decSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decImpuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFactura.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficFactura As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents griFactura As ISL.Controles.Grilla
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents agrRecuperados As ISL.Controles.Agrupacion
    Friend WithEvents colorConDocumentos As ISL.Controles.Colores
    Friend WithEvents etiConDocumentos As ISL.Controles.Etiqueta
    Friend WithEvents colorSinDocumentos As ISL.Controles.Colores
    Friend WithEvents colorConDocumentosPerdidos As ISL.Controles.Colores
    Friend WithEvents etiSinDocumentos As ISL.Controles.Etiqueta
    Friend WithEvents etiConDocumentosPerdidos As ISL.Controles.Etiqueta
    Friend WithEvents etiRecuperados As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboRecuperado As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cboFactura As ISL.Controles.Combo
    Friend WithEvents ficDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleDoc As ISL.Controles.Grilla
    Friend WithEvents txtNumero As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtSerie As ISL.Controles.Texto
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents decTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents cboMoneda As ISL.Controles.Combo
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstado As ISL.Controles.Combo
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents fecDoc As ISL.Controles.Fecha
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoPago As ISL.Controles.Combo
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents fecPeriodo As ISL.Controles.Fecha
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents etiImpuesto As ISL.Controles.Etiqueta
    Friend WithEvents etiSubtotal As ISL.Controles.Etiqueta
    Friend WithEvents decNetoPagar As ISL.Controles.NumeroDecimal
    Friend WithEvents decDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents decImporteDetraer As ISL.Controles.NumeroDecimal
    Friend WithEvents decTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents decImpuesto As ISL.Controles.NumeroDecimal
    Friend WithEvents decSubTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents mnuFacturar As ISL.Controles.MenuContextual
    Friend WithEvents agrDetraccion As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griGuiaTransportista As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents griGuiaRemisionR As ISL.Controles.Grilla
    Friend WithEvents tsmiEmitir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAnular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents agrListaCargas As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents agrContenedor As ISL.Controles.Agrupacion
    Friend WithEvents griListaCarga As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents btnBusca As ISL.Controles.Boton
    Friend WithEvents cboTracto3 As ISL.Controles.Combo
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griViaje As ISL.Controles.Grilla
    Friend WithEvents tsmiNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents agrDatosComplementarios As ISL.Controles.Agrupacion
    Private WithEvents cboCliente2 As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents verFactorRCero As ISL.Controles.Chequear
    Friend WithEvents cboCentro As ISL.Controles.Combo
    Friend WithEvents etiCentro As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroGuiaT As ISL.Controles.Texto
    Friend WithEvents verSelecion As ISL.Controles.Chequear
    Friend WithEvents verCantidadTn As ISL.Controles.Chequear
    Friend WithEvents decCantTn As ISL.Controles.NumeroDecimal
    Friend WithEvents verObservaciones As ISL.Controles.Chequear
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents txtObrservaciones As ISL.Controles.Texto
    Friend WithEvents verDetraccionCero As ISL.Controles.Chequear
    Private WithEvents cboDestinatario As Infragistics.Win.UltraWinGrid.UltraCombo
    Private WithEvents cboOtroCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents optCliente As ISL.Controles.Opciones
    Friend WithEvents decValorUni As ISL.Controles.NumeroDecimal
    Friend WithEvents verCambiaVU As ISL.Controles.Chequear
    Friend WithEvents verQuitarCant As ISL.Controles.Chequear
    Friend WithEvents ficMaterial As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrContCarga As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusquedaDoc As ISL.Controles.Agrupacion
    Friend WithEvents cboTipoDocB As ISL.Controles.Combo
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents txtNumeroB As ISL.Controles.Texto
    Friend WithEvents txtSerieB As ISL.Controles.Texto
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents agrPorVencimiento As ISL.Controles.Agrupacion
    Friend WithEvents etiPorVencer2 As ISL.Controles.Etiqueta
    Friend WithEvents numFaltan As ISL.Controles.Numero
    Friend WithEvents colorPorVencer As ISL.Controles.Colores
    Friend WithEvents etiPorVencer1 As ISL.Controles.Etiqueta
    Friend WithEvents colorVencidos As ISL.Controles.Colores
    Friend WithEvents etiVencidos As ISL.Controles.Etiqueta
    Friend WithEvents etiPorVencimiento As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents colorConDocFac As ISL.Controles.Colores
    Friend WithEvents etiConDocFac As ISL.Controles.Etiqueta
    Friend WithEvents colorSinDocFac As ISL.Controles.Colores
    Friend WithEvents colorDocPerFac As ISL.Controles.Colores
    Friend WithEvents etiSinDoc As ISL.Controles.Etiqueta
    Friend WithEvents etiDocPerFac As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents fecHastaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesdeDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents griDocumentoVenta As ISL.Controles.Grilla
    Friend WithEvents mnuCargas As ISL.Controles.MenuContextual
    Friend WithEvents tsmiGeneraFac As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiGeneraBol As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colorRestablecido As ISL.Controles.Colores
    Friend WithEvents etiRestablecido As ISL.Controles.Etiqueta
    Friend WithEvents fecHastaViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesdeViaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents verIgv As ISL.Controles.Chequear
    Friend WithEvents btnConsolidar As ISL.Controles.Boton
    Friend WithEvents tabViajesLiquidaciones As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents griLiquidacion As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents btnLiquidaciones As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ogdLiquidacion As ISL.Controles.OrigenDatos
    Friend WithEvents btnActualizarFleteUnitario As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents fecHastaLiquidacion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesdeLiquidacion As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ColorFormato5 As ISL.Controles.Colores
    Friend WithEvents ColorFormato3 As ISL.Controles.Colores
    Friend WithEvents ColorFormato4 As ISL.Controles.Colores
    Friend WithEvents ColorFormato2 As ISL.Controles.Colores
    Friend WithEvents ColorFormato0 As ISL.Controles.Colores
    Friend WithEvents ColorFormato1 As ISL.Controles.Colores
    Friend WithEvents opcFormatoLiquidacion As ISL.Controles.Opciones
    Friend WithEvents cboClaseServicioTottus As ISL.Controles.Combo
    Friend WithEvents verUnDetalle As ISL.Controles.Chequear
    Friend WithEvents verDetalleAdj As ISL.Controles.Chequear
    Friend WithEvents ConfirmaCargaGRT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorCambio As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents verViajeRetorno As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIncluirViajeR As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verDosDec As ISL.Controles.Chequear
    Friend WithEvents ficCargas As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ogdViajesProceso As ISL.Controles.OrigenDatos
    Friend WithEvents cboTipoCarga As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboClienteLista As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboActividadNegocioLista As ISL.Controles.ComboMaestros
    Friend WithEvents griViajesProceso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCodigoOP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents VerSeleccionProceso As ISL.Controles.Chequear
    Friend WithEvents btnActualizarMasiva As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraToolTipManager2 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents MenuDetalle As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAplicarValorU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAgregarDetalle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DecDetraer As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents cboDirec As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkElectronico As ISL.Controles.Chequear
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents txtOrdenCompra As ISL.Controles.Texto
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoBien As ISL.Controles.Combo
    Friend WithEvents ChkAnexo As ISL.Controles.Chequear
    Friend WithEvents agrTipoBien As ISL.Controles.Agrupacion
    Friend WithEvents tsmiDescargarPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiDescargarXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ChkOcultarProducto As ISL.Controles.Chequear
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents cbAnticipo As System.Windows.Forms.CheckBox
    Friend WithEvents UltraTabPageControl12 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents decAnticipo As ISL.Controles.NumeroDecimal
    Friend WithEvents griAnticipos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Formato1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formato2ToolStripMenuItem As ToolStripMenuItem
End Class
