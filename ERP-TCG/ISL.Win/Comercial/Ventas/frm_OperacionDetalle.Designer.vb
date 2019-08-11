<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OperacionDetalle
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
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 2)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado", 3)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 4)
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 5)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 6)
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemanda")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDemandaDetalle")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comisionista")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comision")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Facturado")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PagoContraEntrega")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasCarga")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladasDescarga")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargar")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descarga")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPesoTnDescarga")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Consolidado")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClienteFinal")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FalsoFlete")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OperacionDetalle))
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemanda")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDemandaDetalle")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comision")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Facturado")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoContraEntrega")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasCarga")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladasDescarga")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargar")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descarga")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPesoTnDescarga")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Consolidado")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClienteFinal")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FalsoFlete")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Subtotal", 0)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstiba", 1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoEstibaDescarga", 2)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoFlete", 3)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgvConsolidado", 4)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PagoEfectivoDeposito", 5)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoConsolidado", 6)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdOperacionDetalle = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griContratoTercero = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tabCargaOperacion = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.exgruOperacion = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboCliente = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.rbContratoTercero = New System.Windows.Forms.RadioButton()
        Me.rbOrdenTrabajo = New System.Windows.Forms.RadioButton()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.cboEstadoCarga = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel62 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSerie = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnGuardarMasiva = New Infragistics.Win.Misc.UltraButton()
        Me.txtNumero = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.btnActualizarMasiva = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.colorEnviada = New ISL.Controles.Colores(Me.components)
        Me.lblEnviada = New ISL.Controles.Etiqueta(Me.components)
        Me.colorHabilitada = New ISL.Controles.Colores(Me.components)
        Me.lblHabilitada = New ISL.Controles.Etiqueta(Me.components)
        Me.colorGenerada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.colorAsignada = New ISL.Controles.Colores(Me.components)
        Me.lblAsignada = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griContratoTercero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabCargaOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCargaOperacion.SuspendLayout()
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exgruOperacion.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstadoCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.colorEnviada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorHabilitada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griLista)
        Me.UltraTabPageControl3.Enabled = False
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1176, 327)
        '
        'griLista
        '
        Me.griLista.DataSource = Me.ogdOperacionDetalle
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn33.Header.Caption = "Sel"
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn33.Width = 30
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.Hidden = True
        UltraGridColumn61.Header.Caption = "Tracto"
        UltraGridColumn61.Header.VisiblePosition = 5
        UltraGridColumn61.Width = 60
        UltraGridColumn62.Header.Caption = "Carreta"
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.Width = 60
        UltraGridColumn63.Header.Caption = "Viaje"
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn63.Width = 90
        UltraGridColumn64.Header.VisiblePosition = 8
        UltraGridColumn64.Width = 150
        UltraGridColumn65.Header.Caption = "Proveedor"
        UltraGridColumn65.Header.VisiblePosition = 12
        UltraGridColumn65.Width = 150
        UltraGridColumn66.Header.Caption = "EstadoCarga"
        UltraGridColumn66.Header.VisiblePosition = 21
        UltraGridColumn66.Width = 70
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn67.CellAppearance = Appearance1
        UltraGridColumn67.Header.Caption = "Operacion"
        UltraGridColumn67.Header.VisiblePosition = 2
        UltraGridColumn67.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn67.Width = 90
        UltraGridColumn68.Header.Caption = "Ruta"
        UltraGridColumn68.Header.VisiblePosition = 7
        UltraGridColumn68.Width = 150
        UltraGridColumn69.Header.VisiblePosition = 13
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 22
        UltraGridColumn70.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn71.CellAppearance = Appearance2
        UltraGridColumn71.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn71.Header.Caption = "SubTotal"
        UltraGridColumn71.Header.VisiblePosition = 14
        UltraGridColumn71.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn71.Width = 50
        UltraGridColumn72.Header.VisiblePosition = 17
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 18
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 15
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.Width = 100
        UltraGridColumn75.Header.VisiblePosition = 16
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 19
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.Caption = "Orden Trabajo"
        UltraGridColumn77.Header.VisiblePosition = 10
        UltraGridColumn77.Width = 90
        UltraGridColumn78.Header.Caption = "Factura Prove."
        UltraGridColumn78.Header.VisiblePosition = 20
        UltraGridColumn78.Width = 90
        UltraGridColumn79.Header.VisiblePosition = 23
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.Caption = "Flujo Caja"
        UltraGridColumn80.Header.VisiblePosition = 9
        UltraGridColumn80.Width = 150
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
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn87.Header.Caption = "F.Viaje"
        UltraGridColumn87.Header.VisiblePosition = 4
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn87.Width = 60
        UltraGridColumn88.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn88.Header.Caption = "F.Orden T."
        UltraGridColumn88.Header.VisiblePosition = 11
        UltraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn88.Width = 60
        UltraGridColumn89.Header.VisiblePosition = 30
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.Header.VisiblePosition = 31
        UltraGridColumn90.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 32
        UltraGridColumn15.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 33
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 34
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 35
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 36
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 37
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 38
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 39
        UltraGridColumn7.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn15, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Appearance3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance3.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance3.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance3
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance4
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance5.BackColor2 = System.Drawing.SystemColors.Control
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance5
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1176, 327)
        Me.griLista.TabIndex = 5
        '
        'ogdOperacionDetalle
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Object)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Boolean)
        Me.ogdOperacionDetalle.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
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
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griContratoTercero)
        Me.UltraTabPageControl4.Enabled = False
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1176, 327)
        '
        'griContratoTercero
        '
        Me.griContratoTercero.DataSource = Me.ogdOperacionDetalle
        UltraGridColumn35.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn35.Header.Caption = "Sel"
        UltraGridColumn35.Header.VisiblePosition = 0
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn35.Width = 30
        UltraGridColumn36.Header.VisiblePosition = 9
        UltraGridColumn36.Hidden = True
        Appearance6.Image = 3
        Appearance6.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn37.CellAppearance = Appearance6
        Appearance7.Image = 1
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn37.CellButtonAppearance = Appearance7
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn37.Header.Caption = "Observacion"
        UltraGridColumn37.Header.VisiblePosition = 22
        UltraGridColumn37.MaskInput = ""
        UltraGridColumn37.NullText = ""
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn37.Width = 300
        UltraGridColumn38.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.Image = 3
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn38.CellAppearance = Appearance8
        Appearance9.Image = 1
        Appearance9.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn38.CellButtonAppearance = Appearance9
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn38.Header.Caption = "Nª Contrato"
        UltraGridColumn38.Header.VisiblePosition = 7
        UltraGridColumn38.NullText = " "
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn38.Width = 100
        UltraGridColumn39.Header.Caption = "Viaje"
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Width = 100
        UltraGridColumn40.Header.VisiblePosition = 20
        UltraGridColumn40.Width = 150
        UltraGridColumn41.Header.Caption = "Proveedor Tercero"
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 150
        UltraGridColumn42.Header.Caption = "Tipo Carga"
        UltraGridColumn42.Header.VisiblePosition = 16
        UltraGridColumn42.Width = 75
        UltraGridColumn43.Header.VisiblePosition = 23
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 100
        UltraGridColumn44.Header.Caption = "Serie"
        UltraGridColumn44.Header.VisiblePosition = 13
        UltraGridColumn44.Width = 35
        Appearance10.Image = 3
        Appearance10.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn45.CellAppearance = Appearance10
        Appearance11.Image = 1
        UltraGridColumn45.CellButtonAppearance = Appearance11
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn45.Header.VisiblePosition = 17
        UltraGridColumn45.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn45.NullText = "1.0"
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn45.Width = 65
        UltraGridColumn46.Header.VisiblePosition = 28
        UltraGridColumn46.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance12
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn47.Header.Caption = "F.Unitario"
        UltraGridColumn47.Header.VisiblePosition = 18
        UltraGridColumn47.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn47.Width = 60
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance13
        UltraGridColumn48.Header.Caption = "T.Flete"
        UltraGridColumn48.Header.VisiblePosition = 19
        UltraGridColumn48.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn48.Width = 65
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance14
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn49.Header.VisiblePosition = 5
        UltraGridColumn49.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn49.NullText = "0.0"
        UltraGridColumn49.Width = 40
        UltraGridColumn50.Header.VisiblePosition = 25
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 100
        UltraGridColumn51.Header.VisiblePosition = 26
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 27
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.Caption = "Ruta de Viaje"
        UltraGridColumn53.Header.VisiblePosition = 3
        UltraGridColumn53.Width = 150
        Appearance15.Image = 3
        Appearance15.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn54.CellAppearance = Appearance15
        Appearance16.Image = 1
        Appearance16.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn54.CellButtonAppearance = Appearance16
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn54.Header.Caption = "Referencia de Punto de Llegada"
        UltraGridColumn54.Header.VisiblePosition = 21
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn54.Width = 300
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn55.CellAppearance = Appearance17
        UltraGridColumn55.Header.Caption = "F.Unit. Terc."
        UltraGridColumn55.Header.VisiblePosition = 8
        UltraGridColumn55.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn55.Width = 60
        UltraGridColumn56.Header.Caption = "Numero"
        UltraGridColumn56.Header.VisiblePosition = 14
        UltraGridColumn56.Width = 65
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn57.CellAppearance = Appearance18
        UltraGridColumn57.Header.Caption = "IGV Terc."
        UltraGridColumn57.Header.VisiblePosition = 11
        UltraGridColumn57.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn57.Width = 50
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn58.CellAppearance = Appearance19
        UltraGridColumn58.Header.Caption = "T.Flete Terc."
        UltraGridColumn58.Header.VisiblePosition = 12
        UltraGridColumn58.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn58.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn58.Width = 65
        UltraGridColumn59.Header.VisiblePosition = 29
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 30
        UltraGridColumn60.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 31
        UltraGridColumn91.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn92.CellAppearance = Appearance20
        UltraGridColumn92.Header.Caption = "SubTotal Terc."
        UltraGridColumn92.Header.VisiblePosition = 10
        UltraGridColumn92.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn92.Width = 60
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn93.Header.Caption = "F.Viaje"
        UltraGridColumn93.Header.VisiblePosition = 1
        UltraGridColumn93.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn93.Width = 60
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn94.Header.VisiblePosition = 24
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn94.Width = 60
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance21.Image = 3
        Appearance21.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn95.CellAppearance = Appearance21
        Appearance22.Image = 1
        Appearance22.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn95.CellButtonAppearance = Appearance22
        UltraGridColumn95.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn95.Header.Caption = "Adelanto"
        UltraGridColumn95.Header.VisiblePosition = 6
        UltraGridColumn95.MaskInput = "{double:5.2}"
        UltraGridColumn95.ShowInkButton = Infragistics.Win.ShowInkButton.Always
        UltraGridColumn95.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn95.Width = 65
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.Image = 7
        Appearance23.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn96.CellAppearance = Appearance23
        Appearance24.Image = "266.png"
        Appearance24.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn96.CellButtonAppearance = Appearance24
        UltraGridColumn96.Header.Caption = "Estado"
        UltraGridColumn96.Header.VisiblePosition = 15
        UltraGridColumn96.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn96.Width = 80
        UltraGridColumn16.Header.VisiblePosition = 32
        UltraGridColumn16.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 33
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 34
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 35
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 36
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 37
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 38
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 39
        UltraGridColumn14.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn16, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14})
        Me.griContratoTercero.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance25.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.griContratoTercero.DisplayLayout.GroupByBox.Appearance = Appearance25
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griContratoTercero.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance26
        Me.griContratoTercero.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griContratoTercero.DisplayLayout.GroupByBox.Hidden = True
        Appearance27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance27.BackColor2 = System.Drawing.SystemColors.Control
        Appearance27.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griContratoTercero.DisplayLayout.GroupByBox.PromptAppearance = Appearance27
        Me.griContratoTercero.DisplayLayout.MaxColScrollRegions = 1
        Me.griContratoTercero.DisplayLayout.MaxRowScrollRegions = 1
        Me.griContratoTercero.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griContratoTercero.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griContratoTercero.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griContratoTercero.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.griContratoTercero.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griContratoTercero.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griContratoTercero.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griContratoTercero.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griContratoTercero.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griContratoTercero.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griContratoTercero.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griContratoTercero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griContratoTercero.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griContratoTercero.ImageList = Me.imagenes
        Me.griContratoTercero.Location = New System.Drawing.Point(0, 0)
        Me.griContratoTercero.Name = "griContratoTercero"
        Me.griContratoTercero.Size = New System.Drawing.Size(1176, 327)
        Me.griContratoTercero.TabIndex = 6
        '
        'tabCargaOperacion
        '
        Me.tabCargaOperacion.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabCargaOperacion.Controls.Add(Me.UltraTabPageControl3)
        Me.tabCargaOperacion.Controls.Add(Me.UltraTabPageControl4)
        Me.tabCargaOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCargaOperacion.ImageList = Me.imagenes
        Me.tabCargaOperacion.Location = New System.Drawing.Point(3, 108)
        Me.tabCargaOperacion.Name = "tabCargaOperacion"
        Me.tabCargaOperacion.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabCargaOperacion.Size = New System.Drawing.Size(1178, 350)
        Me.tabCargaOperacion.TabIndex = 5
        Appearance28.Image = 10
        UltraTab1.SelectedAppearance = Appearance28
        UltraTab1.TabPage = Me.UltraTabPageControl3
        UltraTab1.Text = "Orden Trabajo"
        Appearance29.Image = 9
        UltraTab2.SelectedAppearance = Appearance29
        UltraTab2.TabPage = Me.UltraTabPageControl4
        UltraTab2.Text = "Contrato Tercero"
        Me.tabCargaOperacion.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tabCargaOperacion.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1176, 327)
        '
        'exgruOperacion
        '
        Me.exgruOperacion.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance30.BackColor = System.Drawing.Color.White
        Appearance30.BackColor2 = System.Drawing.Color.White
        Me.exgruOperacion.ContentAreaAppearance = Appearance30
        Me.exgruOperacion.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.exgruOperacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.exgruOperacion.ExpandedSize = New System.Drawing.Size(1178, 105)
        Me.exgruOperacion.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.exgruOperacion.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.exgruOperacion.Location = New System.Drawing.Point(3, 3)
        Me.exgruOperacion.Name = "exgruOperacion"
        Me.exgruOperacion.Size = New System.Drawing.Size(1178, 105)
        Me.exgruOperacion.TabIndex = 4
        Me.exgruOperacion.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboProveedor)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboCliente)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecHasta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecDesde)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.rbContratoTercero)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.rbOrdenTrabajo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel1)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel17)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel39)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel41)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(3, 18)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1172, 84)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedor.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 400
        Me.cboProveedor.Location = New System.Drawing.Point(78, 56)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(278, 23)
        Me.cboProveedor.TabIndex = 290
        '
        'cboCliente
        '
        Me.cboCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboCliente.CheckedListSettings.ListSeparator = ","
        Me.cboCliente.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboCliente.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.DropDownWidth = 400
        Me.cboCliente.Location = New System.Drawing.Point(78, 30)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(278, 23)
        Me.cboCliente.TabIndex = 289
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(249, 5)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(107, 21)
        Me.fecHasta.TabIndex = 288
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(78, 5)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(107, 21)
        Me.fecDesde.TabIndex = 287
        '
        'rbContratoTercero
        '
        Me.rbContratoTercero.AutoSize = True
        Me.rbContratoTercero.BackColor = System.Drawing.Color.Transparent
        Me.rbContratoTercero.ForeColor = System.Drawing.Color.Navy
        Me.rbContratoTercero.Location = New System.Drawing.Point(369, 29)
        Me.rbContratoTercero.Name = "rbContratoTercero"
        Me.rbContratoTercero.Size = New System.Drawing.Size(113, 17)
        Me.rbContratoTercero.TabIndex = 286
        Me.rbContratoTercero.TabStop = True
        Me.rbContratoTercero.Text = "Contratos Tercero"
        Me.rbContratoTercero.UseVisualStyleBackColor = False
        '
        'rbOrdenTrabajo
        '
        Me.rbOrdenTrabajo.AutoSize = True
        Me.rbOrdenTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.rbOrdenTrabajo.ForeColor = System.Drawing.Color.Navy
        Me.rbOrdenTrabajo.Location = New System.Drawing.Point(369, 9)
        Me.rbOrdenTrabajo.Name = "rbOrdenTrabajo"
        Me.rbOrdenTrabajo.Size = New System.Drawing.Size(106, 17)
        Me.rbOrdenTrabajo.TabIndex = 71
        Me.rbOrdenTrabajo.TabStop = True
        Me.rbOrdenTrabajo.Text = "Ordenes Trabajo"
        Me.rbOrdenTrabajo.UseVisualStyleBackColor = False
        '
        'UltraGroupBox1
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox1.ContentAreaAppearance = Appearance31
        Me.UltraGroupBox1.Controls.Add(Me.colorCambio)
        Me.UltraGroupBox1.Controls.Add(Me.cboEstadoCarga)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel62)
        Me.UltraGroupBox1.Controls.Add(Me.btnConsultar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.txtSerie)
        Me.UltraGroupBox1.Controls.Add(Me.btnGuardarMasiva)
        Me.UltraGroupBox1.Controls.Add(Me.txtNumero)
        Me.UltraGroupBox1.Controls.Add(Me.btnActualizarMasiva)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox1.Location = New System.Drawing.Point(677, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(271, 84)
        Me.UltraGroupBox1.TabIndex = 285
        Me.UltraGroupBox1.Text = "Factura/Boleta del Provedor"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(223, 27)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 22)
        Me.colorCambio.TabIndex = 70
        Me.colorCambio.Text = "Cyan"
        '
        'cboEstadoCarga
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoCarga.Appearance = Appearance32
        Me.cboEstadoCarga.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboEstadoCarga.DisplayMember = "Login"
        Me.cboEstadoCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoCarga.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoCarga.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoCarga.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = ""
        ValueListItem1.DisplayText = "GENERADA"
        ValueListItem2.DataValue = ""
        ValueListItem2.DisplayText = "ASIGNADA"
        ValueListItem3.DataValue = ""
        ValueListItem3.DisplayText = "ENVIADA"
        Me.cboEstadoCarga.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.cboEstadoCarga.Location = New System.Drawing.Point(157, 55)
        Me.cboEstadoCarga.Name = "cboEstadoCarga"
        Me.cboEstadoCarga.Size = New System.Drawing.Size(110, 22)
        Me.cboEstadoCarga.TabIndex = 69
        Me.cboEstadoCarga.ValueMember = "Id"
        '
        'UltraLabel62
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel62.Appearance = Appearance33
        Me.UltraLabel62.Location = New System.Drawing.Point(132, 20)
        Me.UltraLabel62.Name = "UltraLabel62"
        Me.UltraLabel62.Size = New System.Drawing.Size(92, 31)
        Me.UltraLabel62.TabIndex = 68
        Me.UltraLabel62.Text = "Estado a cambiar masivo de carga:"
        '
        'btnConsultar
        '
        Appearance34.Image = "Consultar.ico"
        Appearance34.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnConsultar.Appearance = Appearance34
        Me.btnConsultar.ImageList = Me.imagenes
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(6, 47)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(40, 30)
        Me.btnConsultar.TabIndex = 67
        '
        'UltraLabel3
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance35
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(41, 24)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(8, 15)
        Me.UltraLabel3.TabIndex = 66
        Me.UltraLabel3.Text = "-"
        '
        'txtSerie
        '
        Appearance36.TextHAlignAsString = "Right"
        Me.txtSerie.Appearance = Appearance36
        Me.txtSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerie.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtSerie.InputMask = "nnnn"
        Me.txtSerie.Location = New System.Drawing.Point(6, 21)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.NonAutoSizeHeight = 20
        Me.txtSerie.NullText = ""
        Me.txtSerie.Size = New System.Drawing.Size(35, 21)
        Me.txtSerie.TabIndex = 59
        '
        'btnGuardarMasiva
        '
        Appearance37.Image = 1
        Appearance37.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnGuardarMasiva.Appearance = Appearance37
        Me.btnGuardarMasiva.ImageList = Me.imagenes
        Me.btnGuardarMasiva.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardarMasiva.Location = New System.Drawing.Point(95, 47)
        Me.btnGuardarMasiva.Name = "btnGuardarMasiva"
        Me.btnGuardarMasiva.Size = New System.Drawing.Size(40, 30)
        Me.btnGuardarMasiva.TabIndex = 64
        '
        'txtNumero
        '
        Appearance38.TextHAlignAsString = "Right"
        Me.txtNumero.Appearance = Appearance38
        Me.txtNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNumero.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[String]
        Me.txtNumero.InputMask = "nnnnnnnnnn"
        Me.txtNumero.Location = New System.Drawing.Point(49, 21)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.NonAutoSizeHeight = 20
        Me.txtNumero.NullText = ""
        Me.txtNumero.Size = New System.Drawing.Size(80, 21)
        Me.txtNumero.TabIndex = 60
        '
        'btnActualizarMasiva
        '
        Appearance39.Image = 3
        Appearance39.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnActualizarMasiva.Appearance = Appearance39
        Me.btnActualizarMasiva.ImageList = Me.imagenes
        Me.btnActualizarMasiva.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnActualizarMasiva.Location = New System.Drawing.Point(49, 47)
        Me.btnActualizarMasiva.Name = "btnActualizarMasiva"
        Me.btnActualizarMasiva.Size = New System.Drawing.Size(40, 30)
        Me.btnActualizarMasiva.TabIndex = 63
        '
        'UltraGroupBox2
        '
        Appearance40.BackColor = System.Drawing.Color.White
        Appearance40.BackColor2 = System.Drawing.Color.White
        Me.UltraGroupBox2.ContentAreaAppearance = Appearance40
        Me.UltraGroupBox2.Controls.Add(Me.colorEnviada)
        Me.UltraGroupBox2.Controls.Add(Me.lblEnviada)
        Me.UltraGroupBox2.Controls.Add(Me.colorHabilitada)
        Me.UltraGroupBox2.Controls.Add(Me.lblHabilitada)
        Me.UltraGroupBox2.Controls.Add(Me.colorGenerada)
        Me.UltraGroupBox2.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox2.Controls.Add(Me.colorAsignada)
        Me.UltraGroupBox2.Controls.Add(Me.lblAsignada)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraGroupBox2.Location = New System.Drawing.Point(948, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(224, 84)
        Me.UltraGroupBox2.TabIndex = 284
        Me.UltraGroupBox2.Text = "Estados Cargas"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'colorEnviada
        '
        Me.colorEnviada.Color = System.Drawing.Color.LimeGreen
        Me.colorEnviada.Location = New System.Drawing.Point(175, 23)
        Me.colorEnviada.Name = "colorEnviada"
        Me.colorEnviada.Size = New System.Drawing.Size(43, 22)
        Me.colorEnviada.TabIndex = 11
        Me.colorEnviada.Text = "LimeGreen"
        '
        'lblEnviada
        '
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.lblEnviada.Appearance = Appearance41
        Me.lblEnviada.AutoSize = True
        Me.lblEnviada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnviada.ForeColor = System.Drawing.Color.Black
        Me.lblEnviada.Location = New System.Drawing.Point(126, 28)
        Me.lblEnviada.Name = "lblEnviada"
        Me.lblEnviada.Size = New System.Drawing.Size(43, 15)
        Me.lblEnviada.TabIndex = 10
        Me.lblEnviada.Text = "Enviada"
        '
        'colorHabilitada
        '
        Me.colorHabilitada.Color = System.Drawing.Color.Orange
        Me.colorHabilitada.Location = New System.Drawing.Point(175, 46)
        Me.colorHabilitada.Name = "colorHabilitada"
        Me.colorHabilitada.Size = New System.Drawing.Size(43, 22)
        Me.colorHabilitada.TabIndex = 13
        Me.colorHabilitada.Text = "Orange"
        '
        'lblHabilitada
        '
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.lblHabilitada.Appearance = Appearance42
        Me.lblHabilitada.AutoSize = True
        Me.lblHabilitada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHabilitada.ForeColor = System.Drawing.Color.Black
        Me.lblHabilitada.Location = New System.Drawing.Point(115, 50)
        Me.lblHabilitada.Name = "lblHabilitada"
        Me.lblHabilitada.Size = New System.Drawing.Size(54, 15)
        Me.lblHabilitada.TabIndex = 12
        Me.lblHabilitada.Text = "Habilitada"
        '
        'colorGenerada
        '
        Me.colorGenerada.Color = System.Drawing.Color.White
        Me.colorGenerada.Location = New System.Drawing.Point(66, 24)
        Me.colorGenerada.Name = "colorGenerada"
        Me.colorGenerada.Size = New System.Drawing.Size(43, 22)
        Me.colorGenerada.TabIndex = 5
        Me.colorGenerada.Text = "White"
        '
        'Etiqueta2
        '
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance43
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(52, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Generada"
        '
        'colorAsignada
        '
        Me.colorAsignada.Color = System.Drawing.Color.Yellow
        Me.colorAsignada.Location = New System.Drawing.Point(66, 46)
        Me.colorAsignada.Name = "colorAsignada"
        Me.colorAsignada.Size = New System.Drawing.Size(43, 22)
        Me.colorAsignada.TabIndex = 7
        Me.colorAsignada.Text = "Yellow"
        '
        'lblAsignada
        '
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.lblAsignada.Appearance = Appearance44
        Me.lblAsignada.AutoSize = True
        Me.lblAsignada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignada.ForeColor = System.Drawing.Color.Black
        Me.lblAsignada.Location = New System.Drawing.Point(11, 50)
        Me.lblAsignada.Name = "lblAsignada"
        Me.lblAsignada.Size = New System.Drawing.Size(49, 15)
        Me.lblAsignada.TabIndex = 6
        Me.lblAsignada.Text = "Asignada"
        '
        'UltraLabel1
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Appearance45.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance45
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(13, 59)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel1.TabIndex = 57
        Me.UltraLabel1.Text = "Proveedor:"
        '
        'UltraLabel17
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.Navy
        Appearance46.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance46
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(30, 36)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 55
        Me.UltraLabel17.Text = "Cliente:"
        '
        'UltraLabel39
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.Navy
        Appearance47.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance47
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(206, 11)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel39.TabIndex = 53
        Me.UltraLabel39.Text = "Hasta:"
        '
        'UltraLabel41
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Appearance48.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance48
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(32, 11)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel41.TabIndex = 51
        Me.UltraLabel41.Text = "Desde:"
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.tabCargaOperacion)
        Me.UltraGroupBox3.Controls.Add(Me.exgruOperacion)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1184, 461)
        Me.UltraGroupBox3.TabIndex = 6
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(395, 198)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 7
        Me.ugb_Espera.Visible = False
        '
        'frm_OperacionDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 461)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.UltraGroupBox3)
        Me.Name = "frm_OperacionDetalle"
        Me.Text = "Cargas Operaciones"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdOperacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griContratoTercero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabCargaOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCargaOperacion.ResumeLayout(False)
        CType(Me.exgruOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exgruOperacion.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstadoCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.colorEnviada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorHabilitada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorGenerada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents exgruOperacion As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents ogdOperacionDetalle As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents txtNumero As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtSerie As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents btnGuardarMasiva As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnActualizarMasiva As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents colorEnviada As ISL.Controles.Colores
    Friend WithEvents lblEnviada As ISL.Controles.Etiqueta
    Friend WithEvents colorHabilitada As ISL.Controles.Colores
    Friend WithEvents lblHabilitada As ISL.Controles.Etiqueta
    Friend WithEvents colorGenerada As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents colorAsignada As ISL.Controles.Colores
    Friend WithEvents lblAsignada As ISL.Controles.Etiqueta
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboEstadoCarga As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel62 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents tabCargaOperacion As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griContratoTercero As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents rbContratoTercero As System.Windows.Forms.RadioButton
    Friend WithEvents rbOrdenTrabajo As System.Windows.Forms.RadioButton
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Private WithEvents cboCliente As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
