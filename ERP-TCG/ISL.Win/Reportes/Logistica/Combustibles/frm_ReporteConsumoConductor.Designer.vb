<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteConsumoConductor
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
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Año")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaViaje")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Conductor")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPiloto")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantConductores")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dist")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cons")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Metas")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Pesos")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Rend")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RendEsperado")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlsEsperado")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Desviacion")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Grifo")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LugTanqueo")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Año")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaViaje")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Conductor")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPiloto")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantConductores")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTanqueo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dist")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cons")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Metas")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Pesos")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Rend")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RendEsperado")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlsEsperado")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Desviacion")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Grifo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LugTanqueo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 0)
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab12 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griData = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odConsumosCombustibles = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel7 = New Infragistics.Win.Misc.UltraPanel()
        Me.GridVisualiza = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraPanel6 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraMonthViewMulti1 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.RbtConductor = New System.Windows.Forms.RadioButton()
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel2 = New Infragistics.Win.Misc.UltraPanel()
        Me.RbtCantidad = New System.Windows.Forms.RadioButton()
        Me.RbtDesviacion = New System.Windows.Forms.RadioButton()
        Me.RbtRendimiento = New System.Windows.Forms.RadioButton()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.rbTotal = New System.Windows.Forms.RadioButton()
        Me.rbPromedio = New System.Windows.Forms.RadioButton()
        Me.BtnVisualiza = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel4 = New Infragistics.Win.Misc.UltraPanel()
        Me.RbtSemanal = New System.Windows.Forms.RadioButton()
        Me.RbtMensual = New System.Windows.Forms.RadioButton()
        Me.RbtAño = New System.Windows.Forms.RadioButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.GraficoD2 = New ISL.Controles.Grafico(Me.components)
        Me.UltraPanel8 = New Infragistics.Win.Misc.UltraPanel()
        Me.UltraExpandableGroupBox12 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel13 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel5 = New Infragistics.Win.Misc.UltraPanel()
        Me.LblColumna = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox8 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraMonthViewMulti2 = New Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti()
        Me.UltraExpandableGroupBox9 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel10 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel9 = New Infragistics.Win.Misc.UltraPanel()
        Me.LblValor = New Infragistics.Win.Misc.UltraLabel()
        Me.BtnVerGrafico = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox10 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel11 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel10 = New Infragistics.Win.Misc.UltraPanel()
        Me.RbtGIndividual = New System.Windows.Forms.RadioButton()
        Me.RbtGTotal = New System.Windows.Forms.RadioButton()
        Me.UltraPanel11 = New Infragistics.Win.Misc.UltraPanel()
        Me.CmbTipoGrafico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraExpandableGroupBox11 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel12 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraPanel12 = New Infragistics.Win.Misc.UltraPanel()
        Me.LblFila = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Vehiculos = New ISL.Controles.Grilla(Me.components)
        Me.odCombo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl8 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Pilotos = New ISL.Controles.Grilla(Me.components)
        Me.utpMarcaModelo = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_TipoeVeh = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grid_Zona = New ISL.Controles.Grilla(Me.components)
        Me.TabReporteCombustible = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ndKmxVuelta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColorKmVuelta = New ISL.Controles.Colores(Me.components)
        Me.ColorRendMenor = New ISL.Controles.Colores(Me.components)
        Me.ColorRendMayor = New ISL.Controles.Colores(Me.components)
        Me.nd_RendMenor = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nd_RendMayor = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ColorSinRend = New ISL.Controles.Colores(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDistNegativo = New ISL.Controles.Colores(Me.components)
        Me.chkColores = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnActualizaRend = New ISL.Controles.Boton(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rfHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ficFiltros = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.dlGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odConsumosCombustibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        Me.UltraPanel7.ClientArea.SuspendLayout()
        Me.UltraPanel7.SuspendLayout()
        CType(Me.GridVisualiza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel6.ClientArea.SuspendLayout()
        Me.UltraPanel6.SuspendLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        Me.UltraPanel2.ClientArea.SuspendLayout()
        Me.UltraPanel2.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        Me.UltraPanel4.ClientArea.SuspendLayout()
        Me.UltraPanel4.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.GraficoD2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraPanel8.ClientArea.SuspendLayout()
        Me.UltraPanel8.SuspendLayout()
        CType(Me.UltraExpandableGroupBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox12.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel13.SuspendLayout()
        Me.UltraPanel5.ClientArea.SuspendLayout()
        Me.UltraPanel5.SuspendLayout()
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox8.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel9.SuspendLayout()
        CType(Me.UltraMonthViewMulti2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox9.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel10.SuspendLayout()
        Me.UltraPanel9.ClientArea.SuspendLayout()
        Me.UltraPanel9.SuspendLayout()
        CType(Me.UltraExpandableGroupBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox10.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel11.SuspendLayout()
        Me.UltraPanel10.ClientArea.SuspendLayout()
        Me.UltraPanel10.SuspendLayout()
        Me.UltraPanel11.ClientArea.SuspendLayout()
        Me.UltraPanel11.SuspendLayout()
        CType(Me.CmbTipoGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox11.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel12.SuspendLayout()
        Me.UltraPanel12.ClientArea.SuspendLayout()
        Me.UltraPanel12.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Grid_Vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl8.SuspendLayout()
        CType(Me.Grid_Pilotos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMarcaModelo.SuspendLayout()
        CType(Me.Grid_TipoeVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Grid_Zona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabReporteCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReporteCombustible.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.ndKmxVuelta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorKmVuelta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRendMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorRendMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_RendMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nd_RendMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSinRend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDistNegativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficFiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugb_Espera)
        Me.UltraTabPageControl1.Controls.Add(Me.griData)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1200, 355)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(252, 181)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 804
        Me.ugb_Espera.Visible = False
        '
        'griData
        '
        Me.griData.DataSource = Me.odConsumosCombustibles
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        Appearance1.TextVAlignAsString = "Middle"
        UltraGridColumn47.CellAppearance = Appearance1
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn47.Header.VisiblePosition = 0
        UltraGridColumn47.Width = 49
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance2.TextHAlignAsString = "Center"
        Appearance2.TextVAlignAsString = "Middle"
        UltraGridColumn48.CellAppearance = Appearance2
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn48.Header.VisiblePosition = 1
        UltraGridColumn48.Width = 50
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.TextHAlignAsString = "Center"
        Appearance3.TextVAlignAsString = "Middle"
        UltraGridColumn49.CellAppearance = Appearance3
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn49.Header.VisiblePosition = 2
        UltraGridColumn49.Width = 50
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance4.TextHAlignAsString = "Center"
        Appearance4.TextVAlignAsString = "Middle"
        UltraGridColumn50.CellAppearance = Appearance4
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn50.Header.VisiblePosition = 3
        UltraGridColumn50.Width = 53
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Center"
        Appearance5.TextVAlignAsString = "Middle"
        UltraGridColumn51.CellAppearance = Appearance5
        UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn51.Header.VisiblePosition = 4
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Center"
        Appearance6.TextVAlignAsString = "Middle"
        UltraGridColumn52.CellAppearance = Appearance6
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn52.Header.VisiblePosition = 5
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance7.TextHAlignAsString = "Center"
        Appearance7.TextVAlignAsString = "Middle"
        UltraGridColumn53.CellAppearance = Appearance7
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn53.Header.VisiblePosition = 6
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Center"
        Appearance8.TextVAlignAsString = "Middle"
        UltraGridColumn54.CellAppearance = Appearance8
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn54.Header.VisiblePosition = 7
        UltraGridColumn55.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextVAlignAsString = "Middle"
        UltraGridColumn55.CellAppearance = Appearance9
        UltraGridColumn55.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn55.Header.VisiblePosition = 8
        UltraGridColumn55.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextVAlignAsString = "Middle"
        UltraGridColumn56.CellAppearance = Appearance10
        UltraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn56.Header.VisiblePosition = 9
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        Appearance11.TextVAlignAsString = "Middle"
        UltraGridColumn57.CellAppearance = Appearance11
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn57.Header.VisiblePosition = 10
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Center"
        Appearance12.TextVAlignAsString = "Middle"
        UltraGridColumn58.CellAppearance = Appearance12
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn58.Header.VisiblePosition = 11
        UltraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextVAlignAsString = "Middle"
        UltraGridColumn59.CellAppearance = Appearance13
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn59.Header.VisiblePosition = 12
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Right"
        Appearance14.TextVAlignAsString = "Middle"
        UltraGridColumn60.CellAppearance = Appearance14
        UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn60.Format = "#,##0.000"
        UltraGridColumn60.Header.VisiblePosition = 13
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance15.TextHAlignAsString = "Right"
        Appearance15.TextVAlignAsString = "Middle"
        UltraGridColumn61.CellAppearance = Appearance15
        UltraGridColumn61.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn61.Format = "#,##0.000"
        UltraGridColumn61.Header.VisiblePosition = 14
        UltraGridColumn61.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Center"
        Appearance16.TextVAlignAsString = "Middle"
        UltraGridColumn62.CellAppearance = Appearance16
        UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn62.Header.VisiblePosition = 15
        UltraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance17.TextHAlignAsString = "Center"
        Appearance17.TextVAlignAsString = "Middle"
        UltraGridColumn63.CellAppearance = Appearance17
        UltraGridColumn63.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn63.Header.VisiblePosition = 16
        UltraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance18.TextHAlignAsString = "Right"
        Appearance18.TextVAlignAsString = "Middle"
        UltraGridColumn64.CellAppearance = Appearance18
        UltraGridColumn64.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn64.Format = "#,##0.000"
        UltraGridColumn64.Header.VisiblePosition = 17
        UltraGridColumn64.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance19.TextHAlignAsString = "Right"
        Appearance19.TextVAlignAsString = "Middle"
        UltraGridColumn65.CellAppearance = Appearance19
        UltraGridColumn65.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn65.Format = "#,##0.000"
        UltraGridColumn65.Header.VisiblePosition = 18
        UltraGridColumn65.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn66.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance20.TextHAlignAsString = "Right"
        Appearance20.TextVAlignAsString = "Middle"
        UltraGridColumn66.CellAppearance = Appearance20
        UltraGridColumn66.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn66.Format = "#,##0.000"
        UltraGridColumn66.Header.VisiblePosition = 19
        UltraGridColumn66.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn67.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance21.TextHAlignAsString = "Right"
        Appearance21.TextVAlignAsString = "Middle"
        UltraGridColumn67.CellAppearance = Appearance21
        UltraGridColumn67.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn67.Format = "#,##0.000"
        UltraGridColumn67.Header.VisiblePosition = 20
        UltraGridColumn67.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn68.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance22.TextVAlignAsString = "Middle"
        UltraGridColumn68.CellAppearance = Appearance22
        UltraGridColumn68.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn68.Header.VisiblePosition = 21
        UltraGridColumn69.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance23.TextVAlignAsString = "Middle"
        UltraGridColumn69.CellAppearance = Appearance23
        UltraGridColumn69.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn69.Header.VisiblePosition = 22
        UltraGridColumn70.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance24.TextVAlignAsString = "Middle"
        UltraGridColumn70.CellAppearance = Appearance24
        UltraGridColumn70.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn70.Header.VisiblePosition = 23
        UltraGridColumn71.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance25.TextVAlignAsString = "Middle"
        UltraGridColumn71.CellAppearance = Appearance25
        UltraGridColumn71.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn71.Header.VisiblePosition = 24
        UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance26.TextVAlignAsString = "Middle"
        UltraGridColumn72.CellAppearance = Appearance26
        UltraGridColumn72.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn72.Header.VisiblePosition = 25
        UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance27.TextVAlignAsString = "Middle"
        UltraGridColumn73.CellAppearance = Appearance27
        UltraGridColumn73.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn73.Header.VisiblePosition = 26
        UltraGridColumn74.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance28.TextVAlignAsString = "Middle"
        UltraGridColumn74.CellAppearance = Appearance28
        UltraGridColumn74.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn74.Header.VisiblePosition = 27
        UltraGridColumn75.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance29.TextVAlignAsString = "Middle"
        UltraGridColumn75.CellAppearance = Appearance29
        UltraGridColumn75.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn75.Header.VisiblePosition = 28
        UltraGridColumn76.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance30.TextHAlignAsString = "Center"
        Appearance30.TextVAlignAsString = "Middle"
        UltraGridColumn76.CellAppearance = Appearance30
        UltraGridColumn76.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn76.Header.VisiblePosition = 29
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76})
        UltraGridBand1.Override.FilterUIProvider = Me.Filtro1
        UltraGridBand1.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        UltraGridBand1.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.Button
        Me.griData.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griData.DisplayLayout.MaxColScrollRegions = 1
        Me.griData.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griData.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griData.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griData.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griData.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griData.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griData.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griData.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griData.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griData.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griData.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.griData.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griData.Location = New System.Drawing.Point(0, 0)
        Me.griData.Name = "griData"
        Me.griData.Size = New System.Drawing.Size(1200, 355)
        Me.griData.TabIndex = 803
        Me.griData.TabStop = False
        '
        'odConsumosCombustibles
        '
        Me.odConsumosCombustibles.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraPanel7)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraPanel6)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1200, 355)
        '
        'UltraPanel7
        '
        '
        'UltraPanel7.ClientArea
        '
        Me.UltraPanel7.ClientArea.Controls.Add(Me.GridVisualiza)
        Me.UltraPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel7.Location = New System.Drawing.Point(173, 0)
        Me.UltraPanel7.Name = "UltraPanel7"
        Me.UltraPanel7.Size = New System.Drawing.Size(1027, 355)
        Me.UltraPanel7.TabIndex = 37
        '
        'GridVisualiza
        '
        Me.GridVisualiza.DisplayLayout.MaxColScrollRegions = 1
        Me.GridVisualiza.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.GridVisualiza.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridVisualiza.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.GridVisualiza.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.GridVisualiza.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.GridVisualiza.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.GridVisualiza.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.GridVisualiza.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.GridVisualiza.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.GridVisualiza.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Me.GridVisualiza.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.GridVisualiza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVisualiza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridVisualiza.Location = New System.Drawing.Point(0, 0)
        Me.GridVisualiza.Name = "GridVisualiza"
        Me.GridVisualiza.Size = New System.Drawing.Size(1027, 355)
        Me.GridVisualiza.TabIndex = 816
        Me.GridVisualiza.TabStop = False
        '
        'UltraPanel6
        '
        '
        'UltraPanel6.ClientArea
        '
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.BtnVisualiza)
        Me.UltraPanel6.ClientArea.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraPanel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanel6.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel6.Name = "UltraPanel6"
        Me.UltraPanel6.Size = New System.Drawing.Size(173, 355)
        Me.UltraPanel6.TabIndex = 36
        '
        'UltraExpandableGroupBox6
        '
        Appearance31.BackColor = System.Drawing.Color.White
        Appearance31.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance31
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraExpandableGroupBox6.Expanded = False
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(173, 153)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.BottomOnBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 333)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(173, 22)
        Me.UltraExpandableGroupBox6.TabIndex = 806
        Me.UltraExpandableGroupBox6.Text = "Calendario de Ayuda"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.UltraMonthViewMulti1)
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(179, 0)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel7.Visible = False
        '
        'UltraMonthViewMulti1
        '
        Me.UltraMonthViewMulti1.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti1.Location = New System.Drawing.Point(3, 0)
        Me.UltraMonthViewMulti1.Name = "UltraMonthViewMulti1"
        Me.UltraMonthViewMulti1.Size = New System.Drawing.Size(146, 130)
        Me.UltraMonthViewMulti1.TabIndex = 0
        Me.UltraMonthViewMulti1.WeekNumbersVisible = True
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance32.BackColor = System.Drawing.Color.White
        Appearance32.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance32
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(157, 50)
        Me.UltraExpandableGroupBox3.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(8, 238)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(157, 50)
        Me.UltraExpandableGroupBox3.TabIndex = 32
        Me.UltraExpandableGroupBox3.Text = "Etiquetas de fila"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraPanel3)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(151, 31)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraPanel3
        '
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.RbtConductor)
        Me.UltraPanel3.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(145, 24)
        Me.UltraPanel3.TabIndex = 2
        '
        'RbtConductor
        '
        Me.RbtConductor.AutoSize = True
        Me.RbtConductor.Checked = True
        Me.RbtConductor.Location = New System.Drawing.Point(17, 4)
        Me.RbtConductor.Name = "RbtConductor"
        Me.RbtConductor.Size = New System.Drawing.Size(74, 17)
        Me.RbtConductor.TabIndex = 2
        Me.RbtConductor.TabStop = True
        Me.RbtConductor.Text = "Conductor"
        Me.RbtConductor.UseVisualStyleBackColor = True
        '
        'UltraExpandableGroupBox4
        '
        Me.UltraExpandableGroupBox4.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance33.BackColor = System.Drawing.Color.White
        Appearance33.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance33
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(157, 130)
        Me.UltraExpandableGroupBox4.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(8, 3)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(157, 130)
        Me.UltraExpandableGroupBox4.TabIndex = 33
        Me.UltraExpandableGroupBox4.Text = "Valores"
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraPanel2)
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.UltraPanel1)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(151, 111)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'UltraPanel2
        '
        '
        'UltraPanel2.ClientArea
        '
        Me.UltraPanel2.ClientArea.Controls.Add(Me.RbtCantidad)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.RbtDesviacion)
        Me.UltraPanel2.ClientArea.Controls.Add(Me.RbtRendimiento)
        Me.UltraPanel2.Location = New System.Drawing.Point(3, 33)
        Me.UltraPanel2.Name = "UltraPanel2"
        Me.UltraPanel2.Size = New System.Drawing.Size(145, 75)
        Me.UltraPanel2.TabIndex = 1
        '
        'RbtCantidad
        '
        Me.RbtCantidad.AutoSize = True
        Me.RbtCantidad.Checked = True
        Me.RbtCantidad.Location = New System.Drawing.Point(17, 4)
        Me.RbtCantidad.Name = "RbtCantidad"
        Me.RbtCantidad.Size = New System.Drawing.Size(68, 17)
        Me.RbtCantidad.TabIndex = 5
        Me.RbtCantidad.TabStop = True
        Me.RbtCantidad.Text = "Cant. Gls"
        Me.RbtCantidad.UseVisualStyleBackColor = True
        '
        'RbtDesviacion
        '
        Me.RbtDesviacion.AutoSize = True
        Me.RbtDesviacion.Location = New System.Drawing.Point(17, 50)
        Me.RbtDesviacion.Name = "RbtDesviacion"
        Me.RbtDesviacion.Size = New System.Drawing.Size(78, 17)
        Me.RbtDesviacion.TabIndex = 4
        Me.RbtDesviacion.Text = "Desviación"
        Me.RbtDesviacion.UseVisualStyleBackColor = True
        '
        'RbtRendimiento
        '
        Me.RbtRendimiento.AutoSize = True
        Me.RbtRendimiento.Location = New System.Drawing.Point(17, 27)
        Me.RbtRendimiento.Name = "RbtRendimiento"
        Me.RbtRendimiento.Size = New System.Drawing.Size(84, 17)
        Me.RbtRendimiento.TabIndex = 3
        Me.RbtRendimiento.Text = "Rendimiento"
        Me.RbtRendimiento.UseVisualStyleBackColor = True
        '
        'UltraPanel1
        '
        Appearance34.BackColor = System.Drawing.Color.SkyBlue
        Me.UltraPanel1.Appearance = Appearance34
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.rbTotal)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.rbPromedio)
        Me.UltraPanel1.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(145, 24)
        Me.UltraPanel1.TabIndex = 0
        '
        'rbTotal
        '
        Me.rbTotal.AutoSize = True
        Me.rbTotal.Location = New System.Drawing.Point(92, 4)
        Me.rbTotal.Name = "rbTotal"
        Me.rbTotal.Size = New System.Drawing.Size(49, 17)
        Me.rbTotal.TabIndex = 3
        Me.rbTotal.Text = "Total"
        Me.rbTotal.UseVisualStyleBackColor = True
        '
        'rbPromedio
        '
        Me.rbPromedio.AutoSize = True
        Me.rbPromedio.Checked = True
        Me.rbPromedio.Location = New System.Drawing.Point(17, 4)
        Me.rbPromedio.Name = "rbPromedio"
        Me.rbPromedio.Size = New System.Drawing.Size(69, 17)
        Me.rbPromedio.TabIndex = 2
        Me.rbPromedio.TabStop = True
        Me.rbPromedio.Text = "Promedio"
        Me.rbPromedio.UseVisualStyleBackColor = True
        '
        'BtnVisualiza
        '
        Me.BtnVisualiza.Location = New System.Drawing.Point(8, 291)
        Me.BtnVisualiza.Name = "BtnVisualiza"
        Me.BtnVisualiza.Size = New System.Drawing.Size(157, 23)
        Me.BtnVisualiza.TabIndex = 34
        Me.BtnVisualiza.Text = "Visualizar"
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance35.BackColor = System.Drawing.Color.White
        Appearance35.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance35
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(157, 99)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(8, 136)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(157, 99)
        Me.UltraExpandableGroupBox1.TabIndex = 31
        Me.UltraExpandableGroupBox1.Text = "Etiquetas de columna"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UltraPanel4)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(151, 80)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UltraPanel4
        '
        '
        'UltraPanel4.ClientArea
        '
        Me.UltraPanel4.ClientArea.Controls.Add(Me.RbtSemanal)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.RbtMensual)
        Me.UltraPanel4.ClientArea.Controls.Add(Me.RbtAño)
        Me.UltraPanel4.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel4.Name = "UltraPanel4"
        Me.UltraPanel4.Size = New System.Drawing.Size(145, 73)
        Me.UltraPanel4.TabIndex = 3
        '
        'RbtSemanal
        '
        Me.RbtSemanal.AutoSize = True
        Me.RbtSemanal.Location = New System.Drawing.Point(17, 49)
        Me.RbtSemanal.Name = "RbtSemanal"
        Me.RbtSemanal.Size = New System.Drawing.Size(90, 17)
        Me.RbtSemanal.TabIndex = 7
        Me.RbtSemanal.Text = "Vista semanal"
        Me.RbtSemanal.UseVisualStyleBackColor = True
        '
        'RbtMensual
        '
        Me.RbtMensual.AutoSize = True
        Me.RbtMensual.Location = New System.Drawing.Point(17, 26)
        Me.RbtMensual.Name = "RbtMensual"
        Me.RbtMensual.Size = New System.Drawing.Size(90, 17)
        Me.RbtMensual.TabIndex = 6
        Me.RbtMensual.Text = "Vista mensual"
        Me.RbtMensual.UseVisualStyleBackColor = True
        '
        'RbtAño
        '
        Me.RbtAño.AutoSize = True
        Me.RbtAño.Checked = True
        Me.RbtAño.Location = New System.Drawing.Point(17, 3)
        Me.RbtAño.Name = "RbtAño"
        Me.RbtAño.Size = New System.Drawing.Size(77, 17)
        Me.RbtAño.TabIndex = 5
        Me.RbtAño.TabStop = True
        Me.RbtAño.Text = "Vista anual"
        Me.RbtAño.UseVisualStyleBackColor = True
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.GraficoD2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraPanel8)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1200, 355)
        '
        'GraficoD2
        '
        Me.GraficoD2.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GraficoD2.Axis.PE = PaintElement1
        Me.GraficoD2.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.GraficoD2.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.GraficoD2.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.GraficoD2.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.X.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.X.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.X.Visible = True
        Me.GraficoD2.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.GraficoD2.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.GraficoD2.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.GraficoD2.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.X2.Labels.Visible = False
        Me.GraficoD2.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.X2.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.X2.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.X2.Visible = False
        Me.GraficoD2.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.GraficoD2.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.GraficoD2.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.GraficoD2.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Y.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Y.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.Y.Visible = True
        Me.GraficoD2.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.GraficoD2.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.GraficoD2.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.GraficoD2.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Y2.Labels.Visible = False
        Me.GraficoD2.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Y2.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Y2.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.Y2.Visible = False
        Me.GraficoD2.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.GraficoD2.Axis.Z.Labels.ItemFormatString = ""
        Me.GraficoD2.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Z.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Z.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.Z.Visible = False
        Me.GraficoD2.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.GraficoD2.Axis.Z2.Labels.ItemFormatString = ""
        Me.GraficoD2.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.GraficoD2.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.GraficoD2.Axis.Z2.Labels.Visible = False
        Me.GraficoD2.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.GraficoD2.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Z2.MajorGridLines.Visible = True
        Me.GraficoD2.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.GraficoD2.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.GraficoD2.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.GraficoD2.Axis.Z2.MinorGridLines.Visible = False
        Me.GraficoD2.Axis.Z2.Visible = False
        Me.GraficoD2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GraficoD2.ColorModel.AlphaLevel = CType(150, Byte)
        Me.GraficoD2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GraficoD2.EmptyChartText = ""
        Me.GraficoD2.Location = New System.Drawing.Point(173, 0)
        Me.GraficoD2.Name = "GraficoD2"
        Me.GraficoD2.Size = New System.Drawing.Size(1027, 355)
        Me.GraficoD2.TabIndex = 38
        '
        'UltraPanel8
        '
        '
        'UltraPanel8.ClientArea
        '
        Me.UltraPanel8.ClientArea.Controls.Add(Me.UltraExpandableGroupBox12)
        Me.UltraPanel8.ClientArea.Controls.Add(Me.UltraExpandableGroupBox8)
        Me.UltraPanel8.ClientArea.Controls.Add(Me.UltraExpandableGroupBox9)
        Me.UltraPanel8.ClientArea.Controls.Add(Me.BtnVerGrafico)
        Me.UltraPanel8.ClientArea.Controls.Add(Me.UltraExpandableGroupBox10)
        Me.UltraPanel8.ClientArea.Controls.Add(Me.UltraExpandableGroupBox11)
        Me.UltraPanel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraPanel8.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel8.Name = "UltraPanel8"
        Me.UltraPanel8.Size = New System.Drawing.Size(173, 355)
        Me.UltraPanel8.TabIndex = 37
        '
        'UltraExpandableGroupBox12
        '
        Me.UltraExpandableGroupBox12.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox12.ContentAreaAppearance = Appearance36
        Me.UltraExpandableGroupBox12.Controls.Add(Me.UltraExpandableGroupBoxPanel13)
        Me.UltraExpandableGroupBox12.ExpandedSize = New System.Drawing.Size(157, 55)
        Me.UltraExpandableGroupBox12.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox12.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox12.Location = New System.Drawing.Point(8, 104)
        Me.UltraExpandableGroupBox12.Name = "UltraExpandableGroupBox12"
        Me.UltraExpandableGroupBox12.Size = New System.Drawing.Size(157, 55)
        Me.UltraExpandableGroupBox12.TabIndex = 807
        Me.UltraExpandableGroupBox12.Text = "Vista de columna"
        Me.UltraExpandableGroupBox12.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel13
        '
        Me.UltraExpandableGroupBoxPanel13.Controls.Add(Me.UltraPanel5)
        Me.UltraExpandableGroupBoxPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel13.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel13.Name = "UltraExpandableGroupBoxPanel13"
        Me.UltraExpandableGroupBoxPanel13.Size = New System.Drawing.Size(151, 36)
        Me.UltraExpandableGroupBoxPanel13.TabIndex = 0
        '
        'UltraPanel5
        '
        '
        'UltraPanel5.ClientArea
        '
        Me.UltraPanel5.ClientArea.Controls.Add(Me.LblColumna)
        Me.UltraPanel5.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel5.Name = "UltraPanel5"
        Me.UltraPanel5.Size = New System.Drawing.Size(145, 29)
        Me.UltraPanel5.TabIndex = 3
        '
        'LblColumna
        '
        Me.LblColumna.Location = New System.Drawing.Point(7, 3)
        Me.LblColumna.Name = "LblColumna"
        Me.LblColumna.Size = New System.Drawing.Size(135, 23)
        Me.LblColumna.TabIndex = 0
        '
        'UltraExpandableGroupBox8
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox8.ContentAreaAppearance = Appearance37
        Me.UltraExpandableGroupBox8.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.UltraExpandableGroupBox8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UltraExpandableGroupBox8.Expanded = False
        Me.UltraExpandableGroupBox8.ExpandedSize = New System.Drawing.Size(173, 153)
        Me.UltraExpandableGroupBox8.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.BottomOnBorder
        Me.UltraExpandableGroupBox8.Location = New System.Drawing.Point(0, 333)
        Me.UltraExpandableGroupBox8.Name = "UltraExpandableGroupBox8"
        Me.UltraExpandableGroupBox8.Size = New System.Drawing.Size(173, 22)
        Me.UltraExpandableGroupBox8.TabIndex = 806
        Me.UltraExpandableGroupBox8.Text = "Calendario de Ayuda"
        Me.UltraExpandableGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.UltraMonthViewMulti2)
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(179, 0)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel9.Visible = False
        '
        'UltraMonthViewMulti2
        '
        Me.UltraMonthViewMulti2.BackColor = System.Drawing.SystemColors.Window
        Me.UltraMonthViewMulti2.Location = New System.Drawing.Point(3, 0)
        Me.UltraMonthViewMulti2.Name = "UltraMonthViewMulti2"
        Me.UltraMonthViewMulti2.Size = New System.Drawing.Size(146, 130)
        Me.UltraMonthViewMulti2.TabIndex = 0
        Me.UltraMonthViewMulti2.WeekNumbersVisible = True
        '
        'UltraExpandableGroupBox9
        '
        Me.UltraExpandableGroupBox9.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox9.ContentAreaAppearance = Appearance38
        Me.UltraExpandableGroupBox9.Controls.Add(Me.UltraExpandableGroupBoxPanel10)
        Me.UltraExpandableGroupBox9.ExpandedSize = New System.Drawing.Size(157, 50)
        Me.UltraExpandableGroupBox9.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox9.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox9.Location = New System.Drawing.Point(8, 226)
        Me.UltraExpandableGroupBox9.Name = "UltraExpandableGroupBox9"
        Me.UltraExpandableGroupBox9.Size = New System.Drawing.Size(157, 50)
        Me.UltraExpandableGroupBox9.TabIndex = 32
        Me.UltraExpandableGroupBox9.Text = "Campo valor"
        Me.UltraExpandableGroupBox9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel10
        '
        Me.UltraExpandableGroupBoxPanel10.Controls.Add(Me.UltraPanel9)
        Me.UltraExpandableGroupBoxPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel10.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel10.Name = "UltraExpandableGroupBoxPanel10"
        Me.UltraExpandableGroupBoxPanel10.Size = New System.Drawing.Size(151, 31)
        Me.UltraExpandableGroupBoxPanel10.TabIndex = 0
        '
        'UltraPanel9
        '
        '
        'UltraPanel9.ClientArea
        '
        Me.UltraPanel9.ClientArea.Controls.Add(Me.LblValor)
        Me.UltraPanel9.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel9.Name = "UltraPanel9"
        Me.UltraPanel9.Size = New System.Drawing.Size(145, 27)
        Me.UltraPanel9.TabIndex = 2
        '
        'LblValor
        '
        Me.LblValor.Location = New System.Drawing.Point(5, 2)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(135, 23)
        Me.LblValor.TabIndex = 2
        '
        'BtnVerGrafico
        '
        Me.BtnVerGrafico.Location = New System.Drawing.Point(8, 282)
        Me.BtnVerGrafico.Name = "BtnVerGrafico"
        Me.BtnVerGrafico.Size = New System.Drawing.Size(157, 23)
        Me.BtnVerGrafico.TabIndex = 0
        Me.BtnVerGrafico.Text = "Ver gráfico"
        '
        'UltraExpandableGroupBox10
        '
        Me.UltraExpandableGroupBox10.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance39.BackColor = System.Drawing.Color.White
        Appearance39.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox10.ContentAreaAppearance = Appearance39
        Me.UltraExpandableGroupBox10.Controls.Add(Me.UltraExpandableGroupBoxPanel11)
        Me.UltraExpandableGroupBox10.ExpandedSize = New System.Drawing.Size(157, 95)
        Me.UltraExpandableGroupBox10.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox10.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox10.Location = New System.Drawing.Point(8, 3)
        Me.UltraExpandableGroupBox10.Name = "UltraExpandableGroupBox10"
        Me.UltraExpandableGroupBox10.Size = New System.Drawing.Size(157, 95)
        Me.UltraExpandableGroupBox10.TabIndex = 33
        Me.UltraExpandableGroupBox10.Text = "Opciones Gráficas"
        Me.UltraExpandableGroupBox10.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel11
        '
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraPanel10)
        Me.UltraExpandableGroupBoxPanel11.Controls.Add(Me.UltraPanel11)
        Me.UltraExpandableGroupBoxPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel11.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel11.Name = "UltraExpandableGroupBoxPanel11"
        Me.UltraExpandableGroupBoxPanel11.Size = New System.Drawing.Size(151, 76)
        Me.UltraExpandableGroupBoxPanel11.TabIndex = 0
        '
        'UltraPanel10
        '
        '
        'UltraPanel10.ClientArea
        '
        Me.UltraPanel10.ClientArea.Controls.Add(Me.RbtGIndividual)
        Me.UltraPanel10.ClientArea.Controls.Add(Me.RbtGTotal)
        Me.UltraPanel10.Location = New System.Drawing.Point(3, 43)
        Me.UltraPanel10.Name = "UltraPanel10"
        Me.UltraPanel10.Size = New System.Drawing.Size(145, 29)
        Me.UltraPanel10.TabIndex = 1
        '
        'RbtGIndividual
        '
        Me.RbtGIndividual.AutoSize = True
        Me.RbtGIndividual.Checked = True
        Me.RbtGIndividual.Location = New System.Drawing.Point(7, 6)
        Me.RbtGIndividual.Name = "RbtGIndividual"
        Me.RbtGIndividual.Size = New System.Drawing.Size(70, 17)
        Me.RbtGIndividual.TabIndex = 5
        Me.RbtGIndividual.TabStop = True
        Me.RbtGIndividual.Text = "Individual"
        Me.RbtGIndividual.UseVisualStyleBackColor = True
        '
        'RbtGTotal
        '
        Me.RbtGTotal.AutoSize = True
        Me.RbtGTotal.Location = New System.Drawing.Point(91, 6)
        Me.RbtGTotal.Name = "RbtGTotal"
        Me.RbtGTotal.Size = New System.Drawing.Size(49, 17)
        Me.RbtGTotal.TabIndex = 4
        Me.RbtGTotal.Text = "Total"
        Me.RbtGTotal.UseVisualStyleBackColor = True
        '
        'UltraPanel11
        '
        Appearance40.BackColor = System.Drawing.Color.SkyBlue
        Me.UltraPanel11.Appearance = Appearance40
        '
        'UltraPanel11.ClientArea
        '
        Me.UltraPanel11.ClientArea.Controls.Add(Me.CmbTipoGrafico)
        Me.UltraPanel11.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel11.Name = "UltraPanel11"
        Me.UltraPanel11.Size = New System.Drawing.Size(145, 34)
        Me.UltraPanel11.TabIndex = 0
        '
        'CmbTipoGrafico
        '
        Me.CmbTipoGrafico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.CmbTipoGrafico.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem2.CheckState = System.Windows.Forms.CheckState.Checked
        ValueListItem2.DataValue = "1"
        ValueListItem2.DisplayText = "Gráfico de barras"
        ValueListItem4.DataValue = "2"
        ValueListItem4.DisplayText = "Gráfico de línea"
        ValueListItem1.DataValue = "3"
        ValueListItem1.DisplayText = "Gráfico Spline Área"
        ValueListItem5.DataValue = "4"
        ValueListItem5.DisplayText = "Gráfico Spline"
        Me.CmbTipoGrafico.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem4, ValueListItem1, ValueListItem5})
        Me.CmbTipoGrafico.Location = New System.Drawing.Point(5, 6)
        Me.CmbTipoGrafico.Name = "CmbTipoGrafico"
        Me.CmbTipoGrafico.Size = New System.Drawing.Size(137, 21)
        Me.CmbTipoGrafico.TabIndex = 39
        '
        'UltraExpandableGroupBox11
        '
        Me.UltraExpandableGroupBox11.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance41.BackColor = System.Drawing.Color.White
        Appearance41.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox11.ContentAreaAppearance = Appearance41
        Me.UltraExpandableGroupBox11.Controls.Add(Me.UltraExpandableGroupBoxPanel12)
        Me.UltraExpandableGroupBox11.ExpandedSize = New System.Drawing.Size(157, 55)
        Me.UltraExpandableGroupBox11.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox11.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopInsideBorder
        Me.UltraExpandableGroupBox11.Location = New System.Drawing.Point(8, 165)
        Me.UltraExpandableGroupBox11.Name = "UltraExpandableGroupBox11"
        Me.UltraExpandableGroupBox11.Size = New System.Drawing.Size(157, 55)
        Me.UltraExpandableGroupBox11.TabIndex = 31
        Me.UltraExpandableGroupBox11.Text = "Vista de fila"
        Me.UltraExpandableGroupBox11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel12
        '
        Me.UltraExpandableGroupBoxPanel12.Controls.Add(Me.UltraPanel12)
        Me.UltraExpandableGroupBoxPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel12.Location = New System.Drawing.Point(3, 16)
        Me.UltraExpandableGroupBoxPanel12.Name = "UltraExpandableGroupBoxPanel12"
        Me.UltraExpandableGroupBoxPanel12.Size = New System.Drawing.Size(151, 36)
        Me.UltraExpandableGroupBoxPanel12.TabIndex = 0
        '
        'UltraPanel12
        '
        '
        'UltraPanel12.ClientArea
        '
        Me.UltraPanel12.ClientArea.Controls.Add(Me.LblFila)
        Me.UltraPanel12.Location = New System.Drawing.Point(3, 3)
        Me.UltraPanel12.Name = "UltraPanel12"
        Me.UltraPanel12.Size = New System.Drawing.Size(145, 29)
        Me.UltraPanel12.TabIndex = 3
        '
        'LblFila
        '
        Me.LblFila.Location = New System.Drawing.Point(5, 3)
        Me.LblFila.Name = "LblFila"
        Me.LblFila.Size = New System.Drawing.Size(135, 23)
        Me.LblFila.TabIndex = 1
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Grid_Vehiculos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(355, 159)
        '
        'Grid_Vehiculos
        '
        Me.Grid_Vehiculos.DataSource = Me.odCombo
        Appearance42.TextHAlignAsString = "Left"
        Appearance42.TextVAlignAsString = "Middle"
        UltraGridColumn17.CellAppearance = Appearance42
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Hidden = True
        Appearance43.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance43.TextHAlignAsString = "Left"
        Appearance43.TextVAlignAsString = "Middle"
        UltraGridColumn18.CellAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Center"
        UltraGridColumn18.Header.Appearance = Appearance44
        UltraGridColumn18.Header.Caption = "Placa"
        UltraGridColumn18.Header.VisiblePosition = 3
        UltraGridColumn18.MaxWidth = 300
        UltraGridColumn18.Width = 232
        Appearance45.TextHAlignAsString = "Left"
        Appearance45.TextVAlignAsString = "Middle"
        UltraGridColumn19.CellAppearance = Appearance45
        UltraGridColumn19.Header.VisiblePosition = 2
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 195
        Appearance46.TextHAlignAsString = "Center"
        Appearance46.TextVAlignAsString = "Middle"
        UltraGridColumn20.CellAppearance = Appearance46
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn20.DataType = GetType(Boolean)
        UltraGridColumn20.DefaultCellValue = False
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn20.Header.Appearance = Appearance47
        UltraGridColumn20.Header.Caption = "Sel."
        UltraGridColumn20.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn20.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn20.Width = 52
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20})
        Me.Grid_Vehiculos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.Grid_Vehiculos.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Vehiculos.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Vehiculos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Vehiculos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Vehiculos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Vehiculos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Vehiculos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Vehiculos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Vehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Vehiculos.Name = "Grid_Vehiculos"
        Me.Grid_Vehiculos.Size = New System.Drawing.Size(355, 159)
        Me.Grid_Vehiculos.TabIndex = 21
        '
        'odCombo
        '
        Me.odCombo.Band.Columns.AddRange(New Object() {UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'UltraTabPageControl8
        '
        Me.UltraTabPageControl8.Controls.Add(Me.Grid_Pilotos)
        Me.UltraTabPageControl8.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl8.Name = "UltraTabPageControl8"
        Me.UltraTabPageControl8.Size = New System.Drawing.Size(355, 159)
        '
        'Grid_Pilotos
        '
        Me.Grid_Pilotos.DataSource = Me.odCombo
        Appearance48.TextHAlignAsString = "Left"
        Appearance48.TextVAlignAsString = "Middle"
        UltraGridColumn21.CellAppearance = Appearance48
        UltraGridColumn21.Header.VisiblePosition = 0
        UltraGridColumn21.Hidden = True
        Appearance49.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance49.TextHAlignAsString = "Left"
        Appearance49.TextVAlignAsString = "Middle"
        UltraGridColumn22.CellAppearance = Appearance49
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance50
        UltraGridColumn22.Header.Caption = "Piloto/Copiloto"
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.MaxWidth = 300
        UltraGridColumn22.Width = 232
        Appearance51.TextHAlignAsString = "Left"
        Appearance51.TextVAlignAsString = "Middle"
        UltraGridColumn23.CellAppearance = Appearance51
        UltraGridColumn23.Header.VisiblePosition = 2
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Width = 195
        Appearance52.TextHAlignAsString = "Center"
        Appearance52.TextVAlignAsString = "Middle"
        UltraGridColumn24.CellAppearance = Appearance52
        UltraGridColumn24.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn24.DataType = GetType(Boolean)
        UltraGridColumn24.DefaultCellValue = False
        Appearance53.TextHAlignAsString = "Center"
        UltraGridColumn24.Header.Appearance = Appearance53
        UltraGridColumn24.Header.Caption = "Sel."
        UltraGridColumn24.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn24.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn24.Header.VisiblePosition = 1
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn24.Width = 52
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24})
        Me.Grid_Pilotos.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.Grid_Pilotos.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Pilotos.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Pilotos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Pilotos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Pilotos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Pilotos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Pilotos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Pilotos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Pilotos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Pilotos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Pilotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Pilotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Pilotos.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Pilotos.Name = "Grid_Pilotos"
        Me.Grid_Pilotos.Size = New System.Drawing.Size(355, 159)
        Me.Grid_Pilotos.TabIndex = 20
        '
        'utpMarcaModelo
        '
        Me.utpMarcaModelo.Controls.Add(Me.Grid_TipoeVeh)
        Me.utpMarcaModelo.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpMarcaModelo.Name = "utpMarcaModelo"
        Me.utpMarcaModelo.Size = New System.Drawing.Size(355, 159)
        '
        'Grid_TipoeVeh
        '
        Me.Grid_TipoeVeh.DataSource = Me.odCombo
        Appearance54.TextHAlignAsString = "Left"
        Appearance54.TextVAlignAsString = "Middle"
        UltraGridColumn25.CellAppearance = Appearance54
        UltraGridColumn25.Header.VisiblePosition = 0
        UltraGridColumn25.Hidden = True
        Appearance55.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance55.TextHAlignAsString = "Left"
        Appearance55.TextVAlignAsString = "Middle"
        UltraGridColumn26.CellAppearance = Appearance55
        Appearance56.TextHAlignAsString = "Center"
        UltraGridColumn26.Header.Appearance = Appearance56
        UltraGridColumn26.Header.Caption = "Tipo Vehículo"
        UltraGridColumn26.Header.VisiblePosition = 3
        UltraGridColumn26.MaxWidth = 300
        UltraGridColumn26.Width = 232
        Appearance57.TextHAlignAsString = "Left"
        Appearance57.TextVAlignAsString = "Middle"
        UltraGridColumn27.CellAppearance = Appearance57
        UltraGridColumn27.Header.VisiblePosition = 2
        UltraGridColumn27.Hidden = True
        UltraGridColumn27.Width = 195
        Appearance58.TextHAlignAsString = "Center"
        Appearance58.TextVAlignAsString = "Middle"
        UltraGridColumn28.CellAppearance = Appearance58
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn28.DataType = GetType(Boolean)
        UltraGridColumn28.DefaultCellValue = False
        Appearance59.TextHAlignAsString = "Center"
        UltraGridColumn28.Header.Appearance = Appearance59
        UltraGridColumn28.Header.Caption = "Sel."
        UltraGridColumn28.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn28.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn28.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn28.Width = 52
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28})
        Me.Grid_TipoeVeh.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.Grid_TipoeVeh.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_TipoeVeh.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_TipoeVeh.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_TipoeVeh.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_TipoeVeh.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_TipoeVeh.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_TipoeVeh.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_TipoeVeh.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_TipoeVeh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_TipoeVeh.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_TipoeVeh.Location = New System.Drawing.Point(0, 0)
        Me.Grid_TipoeVeh.Name = "Grid_TipoeVeh"
        Me.Grid_TipoeVeh.Size = New System.Drawing.Size(355, 159)
        Me.Grid_TipoeVeh.TabIndex = 21
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Grid_Zona)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(355, 159)
        '
        'Grid_Zona
        '
        Me.Grid_Zona.DataSource = Me.odCombo
        Appearance60.TextHAlignAsString = "Left"
        Appearance60.TextVAlignAsString = "Middle"
        UltraGridColumn13.CellAppearance = Appearance60
        UltraGridColumn13.Header.VisiblePosition = 0
        UltraGridColumn13.Hidden = True
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance61.TextHAlignAsString = "Left"
        Appearance61.TextVAlignAsString = "Middle"
        UltraGridColumn14.CellAppearance = Appearance61
        Appearance62.TextHAlignAsString = "Center"
        UltraGridColumn14.Header.Appearance = Appearance62
        UltraGridColumn14.Header.Caption = "Flota"
        UltraGridColumn14.Header.VisiblePosition = 3
        UltraGridColumn14.MaxWidth = 300
        UltraGridColumn14.Width = 232
        Appearance63.TextHAlignAsString = "Left"
        Appearance63.TextVAlignAsString = "Middle"
        UltraGridColumn15.CellAppearance = Appearance63
        UltraGridColumn15.Header.VisiblePosition = 2
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 195
        Appearance64.TextHAlignAsString = "Center"
        Appearance64.TextVAlignAsString = "Middle"
        UltraGridColumn16.CellAppearance = Appearance64
        UltraGridColumn16.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn16.DataType = GetType(Boolean)
        UltraGridColumn16.DefaultCellValue = False
        Appearance65.TextHAlignAsString = "Center"
        UltraGridColumn16.Header.Appearance = Appearance65
        UltraGridColumn16.Header.Caption = "Sel."
        UltraGridColumn16.Header.CheckBoxSynchronization = Infragistics.Win.UltraWinGrid.HeaderCheckBoxSynchronization.None
        UltraGridColumn16.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn16.Width = 52
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        Me.Grid_Zona.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.Grid_Zona.DisplayLayout.MaxColScrollRegions = 1
        Me.Grid_Zona.DisplayLayout.MaxRowScrollRegions = 1
        Me.Grid_Zona.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Zona.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grid_Zona.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grid_Zona.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.Grid_Zona.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.Grid_Zona.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.Grid_Zona.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grid_Zona.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.Grid_Zona.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.Grid_Zona.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.Grid_Zona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_Zona.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_Zona.Location = New System.Drawing.Point(0, 0)
        Me.Grid_Zona.Name = "Grid_Zona"
        Me.Grid_Zona.Size = New System.Drawing.Size(355, 159)
        Me.Grid_Zona.TabIndex = 22
        '
        'TabReporteCombustible
        '
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabPageControl1)
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabPageControl3)
        Me.TabReporteCombustible.Controls.Add(Me.UltraTabPageControl2)
        Me.TabReporteCombustible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabReporteCombustible.Location = New System.Drawing.Point(0, 194)
        Me.TabReporteCombustible.Name = "TabReporteCombustible"
        Me.TabReporteCombustible.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.TabReporteCombustible.Size = New System.Drawing.Size(1202, 378)
        Me.TabReporteCombustible.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Información"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Reporte"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Gráfico"
        Me.TabReporteCombustible.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab3, UltraTab2})
        Me.TabReporteCombustible.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1200, 355)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1202, 194)
        Me.UltraGroupBox1.TabIndex = 2
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox3
        '
        Appearance66.TextHAlignAsString = "Left"
        Me.UltraGroupBox3.Appearance = Appearance66
        Me.UltraGroupBox3.Controls.Add(Me.UltraGroupBox6)
        Me.UltraGroupBox3.Controls.Add(Me.ficFiltros)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1196, 188)
        Me.UltraGroupBox3.TabIndex = 806
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox6
        '
        Appearance67.BackColor = System.Drawing.Color.White
        Appearance67.BackColor2 = System.Drawing.SystemColors.GradientActiveCaption
        Me.UltraGroupBox6.ContentAreaAppearance = Appearance67
        Me.UltraGroupBox6.Controls.Add(Me.UltraGroupBox2)
        Me.UltraGroupBox6.Controls.Add(Me.ndKmxVuelta)
        Me.UltraGroupBox6.Controls.Add(Me.Label7)
        Me.UltraGroupBox6.Controls.Add(Me.ColorKmVuelta)
        Me.UltraGroupBox6.Controls.Add(Me.ColorRendMenor)
        Me.UltraGroupBox6.Controls.Add(Me.ColorRendMayor)
        Me.UltraGroupBox6.Controls.Add(Me.nd_RendMenor)
        Me.UltraGroupBox6.Controls.Add(Me.Label5)
        Me.UltraGroupBox6.Controls.Add(Me.Label4)
        Me.UltraGroupBox6.Controls.Add(Me.nd_RendMayor)
        Me.UltraGroupBox6.Controls.Add(Me.ColorSinRend)
        Me.UltraGroupBox6.Controls.Add(Me.Label6)
        Me.UltraGroupBox6.Controls.Add(Me.Label3)
        Me.UltraGroupBox6.Controls.Add(Me.ColorDistNegativo)
        Me.UltraGroupBox6.Controls.Add(Me.chkColores)
        Me.UltraGroupBox6.Controls.Add(Me.btnActualizaRend)
        Me.UltraGroupBox6.Controls.Add(Me.Label1)
        Me.UltraGroupBox6.Controls.Add(Me.rfHasta)
        Me.UltraGroupBox6.Controls.Add(Me.rfDesde)
        Me.UltraGroupBox6.Controls.Add(Me.Label2)
        'Me.UltraGroupBox6.Controls.Add(Me.ShapeContainer1)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox6.Location = New System.Drawing.Point(360, 3)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(833, 182)
        Me.UltraGroupBox6.TabIndex = 812
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox2.Controls.Add(Me.Button1)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(665, 104)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(162, 72)
        Me.UltraGroupBox2.TabIndex = 805
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel1
        '
        Appearance68.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Appearance68.TextHAlignAsString = "Center"
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance68
        Me.UltraLabel1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!)
        Me.UltraLabel1.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaption
        Me.UltraLabel1.Location = New System.Drawing.Point(0, 6)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(162, 24)
        Me.UltraLabel1.TabIndex = 805
        Me.UltraLabel1.Text = "ANÁLISIS DINÁMICO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 27)
        Me.Button1.TabIndex = 804
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ndKmxVuelta
        '
        Appearance69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndKmxVuelta.Appearance = Appearance69
        Me.ndKmxVuelta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndKmxVuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndKmxVuelta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndKmxVuelta.Location = New System.Drawing.Point(330, 69)
        Me.ndKmxVuelta.MaskInput = "{double:3.2}"
        Me.ndKmxVuelta.Name = "ndKmxVuelta"
        Me.ndKmxVuelta.NullText = "0.00"
        Me.ndKmxVuelta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndKmxVuelta.Size = New System.Drawing.Size(38, 21)
        Me.ndKmxVuelta.TabIndex = 822
        Me.ndKmxVuelta.Value = 137.5R
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(214, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 821
        Me.Label7.Text = "Py - Tembladera - Py"
        '
        'ColorKmVuelta
        '
        Me.ColorKmVuelta.Color = System.Drawing.Color.Aqua
        Me.ColorKmVuelta.Location = New System.Drawing.Point(374, 69)
        Me.ColorKmVuelta.Name = "ColorKmVuelta"
        Me.ColorKmVuelta.Size = New System.Drawing.Size(45, 21)
        Me.ColorKmVuelta.TabIndex = 820
        Me.ColorKmVuelta.Text = "Aqua"
        '
        'ColorRendMenor
        '
        Me.ColorRendMenor.Color = System.Drawing.Color.LightCoral
        Me.ColorRendMenor.Location = New System.Drawing.Point(374, 123)
        Me.ColorRendMenor.Name = "ColorRendMenor"
        Me.ColorRendMenor.Size = New System.Drawing.Size(45, 21)
        Me.ColorRendMenor.TabIndex = 814
        Me.ColorRendMenor.Text = "LightCoral"
        '
        'ColorRendMayor
        '
        Me.ColorRendMayor.Color = System.Drawing.Color.LightCoral
        Me.ColorRendMayor.Location = New System.Drawing.Point(374, 150)
        Me.ColorRendMayor.Name = "ColorRendMayor"
        Me.ColorRendMayor.Size = New System.Drawing.Size(45, 21)
        Me.ColorRendMayor.TabIndex = 815
        Me.ColorRendMayor.Text = "LightCoral"
        '
        'nd_RendMenor
        '
        Appearance70.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMenor.Appearance = Appearance70
        Me.nd_RendMenor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_RendMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_RendMenor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMenor.Location = New System.Drawing.Point(330, 123)
        Me.nd_RendMenor.MaskInput = "{double:2.2}"
        Me.nd_RendMenor.Name = "nd_RendMenor"
        Me.nd_RendMenor.NullText = "0.00"
        Me.nd_RendMenor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_RendMenor.Size = New System.Drawing.Size(38, 21)
        Me.nd_RendMenor.TabIndex = 812
        Me.nd_RendMenor.Value = 5.0R
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(215, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 272
        Me.Label5.Text = "Rendimiento mayor a:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(214, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 271
        Me.Label4.Text = "Rendimiento menor a:"
        '
        'nd_RendMayor
        '
        Appearance71.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMayor.Appearance = Appearance71
        Me.nd_RendMayor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.nd_RendMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nd_RendMayor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nd_RendMayor.Location = New System.Drawing.Point(330, 150)
        Me.nd_RendMayor.MaskInput = "{double:2.2}"
        Me.nd_RendMayor.Name = "nd_RendMayor"
        Me.nd_RendMayor.NullText = "0.00"
        Me.nd_RendMayor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.nd_RendMayor.Size = New System.Drawing.Size(38, 21)
        Me.nd_RendMayor.TabIndex = 813
        Me.nd_RendMayor.Value = 17.0R
        '
        'ColorSinRend
        '
        Me.ColorSinRend.Color = System.Drawing.Color.Yellow
        Me.ColorSinRend.Location = New System.Drawing.Point(374, 96)
        Me.ColorSinRend.Name = "ColorSinRend"
        Me.ColorSinRend.Size = New System.Drawing.Size(45, 21)
        Me.ColorSinRend.TabIndex = 817
        Me.ColorSinRend.Text = "Yellow"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(214, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 816
        Me.Label6.Text = "Parametros para Rend.Esp:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(214, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "Distancias en negativo:"
        '
        'ColorDistNegativo
        '
        Me.ColorDistNegativo.Color = System.Drawing.Color.Red
        Me.ColorDistNegativo.Location = New System.Drawing.Point(374, 42)
        Me.ColorDistNegativo.Name = "ColorDistNegativo"
        Me.ColorDistNegativo.Size = New System.Drawing.Size(45, 21)
        Me.ColorDistNegativo.TabIndex = 40
        Me.ColorDistNegativo.Text = "Red"
        '
        'chkColores
        '
        Appearance72.BackColor = System.Drawing.Color.Transparent
        Appearance72.ForeColor = System.Drawing.Color.Navy
        Me.chkColores.Appearance = Appearance72
        Me.chkColores.BackColor = System.Drawing.Color.Transparent
        Me.chkColores.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkColores.Checked = True
        Me.chkColores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColores.Location = New System.Drawing.Point(193, 22)
        Me.chkColores.Name = "chkColores"
        Me.chkColores.Size = New System.Drawing.Size(192, 14)
        Me.chkColores.TabIndex = 819
        Me.chkColores.Text = "Visualizar colores:"
        '
        'btnActualizaRend
        '
        Appearance73.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance73.Image = "266.png"
        Me.btnActualizaRend.Appearance = Appearance73
        Me.btnActualizaRend.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnActualizaRend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizaRend.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizaRend.ForeColor = System.Drawing.Color.Black
        Me.btnActualizaRend.Location = New System.Drawing.Point(20, 146)
        Me.btnActualizaRend.Name = "btnActualizaRend"
        Me.btnActualizaRend.Size = New System.Drawing.Size(137, 23)
        Me.btnActualizaRend.TabIndex = 816
        Me.btnActualizaRend.Text = "Actualizar Metas"
        Me.btnActualizaRend.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 268
        Me.Label1.Text = "Desde:"
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(62, 54)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(95, 20)
        Me.rfHasta.TabIndex = 267
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(61, 22)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(96, 20)
        Me.rfDesde.TabIndex = 266
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(17, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "Hasta:"
        ' ''
        ' ''ShapeContainer1
        ' ''
        ''Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        ''Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        ''Me.ShapeContainer1.Name = "ShapeContainer1"
        ''Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        ''Me.ShapeContainer1.Size = New System.Drawing.Size(827, 176)
        ''Me.ShapeContainer1.TabIndex = 808
        ''Me.ShapeContainer1.TabStop = False
        ' ''
        ' ''LineShape1
        ' ''
        ''Me.LineShape1.BorderColor = System.Drawing.Color.SteelBlue
        ''Me.LineShape1.Name = "LineShape1"
        ''Me.LineShape1.X1 = 174
        ''Me.LineShape1.X2 = 174
        ''Me.LineShape1.Y1 = 11
        ''Me.LineShape1.Y2 = 172
        '
        'ficFiltros
        '
        Me.ficFiltros.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl4)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl8)
        Me.ficFiltros.Controls.Add(Me.utpMarcaModelo)
        Me.ficFiltros.Controls.Add(Me.UltraTabPageControl5)
        Me.ficFiltros.Dock = System.Windows.Forms.DockStyle.Left
        Me.ficFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficFiltros.Location = New System.Drawing.Point(3, 3)
        Me.ficFiltros.Name = "ficFiltros"
        Me.ficFiltros.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficFiltros.Size = New System.Drawing.Size(357, 182)
        Me.ficFiltros.TabIndex = 811
        UltraTab10.TabPage = Me.UltraTabPageControl4
        UltraTab10.Text = "Vehículos"
        UltraTab11.TabPage = Me.UltraTabPageControl8
        UltraTab11.Text = "Pilotos"
        UltraTab12.TabPage = Me.utpMarcaModelo
        UltraTab12.Text = "Tipo Vehículo"
        UltraTab13.TabPage = Me.UltraTabPageControl5
        UltraTab13.Text = "Flota"
        Me.ficFiltros.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab10, UltraTab11, UltraTab12, UltraTab13})
        Me.ficFiltros.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(355, 159)
        '
        'frm_ReporteConsumoConductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 572)
        Me.Controls.Add(Me.TabReporteCombustible)
        Me.Controls.Add(Me.UltraGroupBox1)
        Me.Name = "frm_ReporteConsumoConductor"
        Me.Text = "Conductor (Cons-Rend-Desv)"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odConsumosCombustibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraPanel7.ClientArea.ResumeLayout(False)
        Me.UltraPanel7.ResumeLayout(False)
        CType(Me.GridVisualiza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel6.ClientArea.ResumeLayout(False)
        Me.UltraPanel6.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.UltraMonthViewMulti1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.ResumeLayout(False)
        Me.UltraPanel2.ClientArea.PerformLayout()
        Me.UltraPanel2.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.ResumeLayout(False)
        Me.UltraPanel4.ClientArea.PerformLayout()
        Me.UltraPanel4.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.GraficoD2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraPanel8.ClientArea.ResumeLayout(False)
        Me.UltraPanel8.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox12.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel13.ResumeLayout(False)
        Me.UltraPanel5.ClientArea.ResumeLayout(False)
        Me.UltraPanel5.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox8.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.ResumeLayout(False)
        CType(Me.UltraMonthViewMulti2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel10.ResumeLayout(False)
        Me.UltraPanel9.ClientArea.ResumeLayout(False)
        Me.UltraPanel9.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox10.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel11.ResumeLayout(False)
        Me.UltraPanel10.ClientArea.ResumeLayout(False)
        Me.UltraPanel10.ClientArea.PerformLayout()
        Me.UltraPanel10.ResumeLayout(False)
        Me.UltraPanel11.ClientArea.ResumeLayout(False)
        Me.UltraPanel11.ClientArea.PerformLayout()
        Me.UltraPanel11.ResumeLayout(False)
        CType(Me.CmbTipoGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox11.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel12.ResumeLayout(False)
        Me.UltraPanel12.ClientArea.ResumeLayout(False)
        Me.UltraPanel12.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Grid_Vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odCombo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl8.ResumeLayout(False)
        CType(Me.Grid_Pilotos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMarcaModelo.ResumeLayout(False)
        CType(Me.Grid_TipoeVeh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Grid_Zona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabReporteCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReporteCombustible.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.ndKmxVuelta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorKmVuelta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRendMenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorRendMayor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_RendMenor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nd_RendMayor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSinRend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDistNegativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficFiltros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficFiltros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabReporteCombustible As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griData As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraPanel7 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents GridVisualiza As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraPanel6 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraMonthViewMulti1 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents RbtConductor As System.Windows.Forms.RadioButton
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel2 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents RbtCantidad As System.Windows.Forms.RadioButton
    Friend WithEvents RbtDesviacion As System.Windows.Forms.RadioButton
    Friend WithEvents RbtRendimiento As System.Windows.Forms.RadioButton
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents rbTotal As System.Windows.Forms.RadioButton
    Friend WithEvents rbPromedio As System.Windows.Forms.RadioButton
    Friend WithEvents BtnVisualiza As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel4 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents RbtSemanal As System.Windows.Forms.RadioButton
    Friend WithEvents RbtMensual As System.Windows.Forms.RadioButton
    Friend WithEvents RbtAño As System.Windows.Forms.RadioButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents GraficoD2 As ISL.Controles.Grafico
    Friend WithEvents UltraPanel8 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents UltraExpandableGroupBox12 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel13 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel5 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents LblColumna As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraExpandableGroupBox8 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraMonthViewMulti2 As Infragistics.Win.UltraWinSchedule.UltraMonthViewMulti
    Friend WithEvents UltraExpandableGroupBox9 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel10 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel9 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents LblValor As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents BtnVerGrafico As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraExpandableGroupBox10 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel11 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel10 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents RbtGIndividual As System.Windows.Forms.RadioButton
    Friend WithEvents RbtGTotal As System.Windows.Forms.RadioButton
    Friend WithEvents UltraPanel11 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents CmbTipoGrafico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraExpandableGroupBox11 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel12 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraPanel12 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents LblFila As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents dlGuardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents odConsumosCombustibles As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents odCombo As ISL.Controles.OrigenDatos
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ndKmxVuelta As ISL.Controles.NumeroDecimal
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColorKmVuelta As ISL.Controles.Colores
    Friend WithEvents ColorRendMenor As ISL.Controles.Colores
    Friend WithEvents ColorRendMayor As ISL.Controles.Colores
    Friend WithEvents nd_RendMenor As ISL.Controles.NumeroDecimal
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nd_RendMayor As ISL.Controles.NumeroDecimal
    Friend WithEvents ColorSinRend As ISL.Controles.Colores
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColorDistNegativo As ISL.Controles.Colores
    Friend WithEvents chkColores As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnActualizaRend As ISL.Controles.Boton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ficFiltros As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_Vehiculos As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl8 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_Pilotos As ISL.Controles.Grilla
    Friend WithEvents utpMarcaModelo As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_TipoeVeh As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Grid_Zona As ISL.Controles.Grilla
End Class
