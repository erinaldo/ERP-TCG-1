<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Control_Garita
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersonaVehiculoES")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculoES")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndISL")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCargaVehiculoES")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculoES")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndISL")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCargaVehiculoES")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculoES")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndISL")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersonaVehiculoES")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculoES")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndISL")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndISL")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tripulante")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculoES")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersonaES")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DNI")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndTrabajador")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Condicion")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CondicionNombre")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersonaES")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ControlES")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Confirmado")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand3 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersonaES")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ControlES")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Confirmado")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculoES")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersonaES")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DNI")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndTrabajador")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Condicion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CondicionNombre")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndISL")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tripulante")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
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
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griVehiculos = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odVehiculo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UEGB_Vehiculos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UGB_Vehiculos = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UGB_Motriz = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbPlacaMotriz = New ISL.Controles.ComboMaestros(Me.components)
        Me.btnMotriz = New ISL.Controles.Boton(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.opcIEMotriz = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.UGB_CargaVehiculo = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbPlacaCarreta = New ISL.Controles.ComboMaestros(Me.components)
        Me.btn_AgregarCarreta = New ISL.Controles.Boton(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opcIECarreta = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griOcupantes = New ISL.Controles.Grilla(Me.components)
        Me.odOcupantes = New ISL.Controles.OrigenDatos(Me.components)
        Me.UEGB_Ocupantes = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtObs = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCarga = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAddBienes = New ISL.Controles.Boton(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cmbNombreTripulante = New ISL.Controles.ComboMaestros(Me.components)
        Me.chk_Empleado = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDNI = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.btnAddTripulante = New ISL.Controles.Boton(Me.components)
        Me.opCondicion = New ISL.Controles.Opciones(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Grilla1 = New ISL.Controles.Grilla(Me.components)
        Me.UEGB_Personal = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UGB_Personal = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UGB_Bien = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Texto2 = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Boton4 = New ISL.Controles.Boton(Me.components)
        Me.UGB_Persona = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraTextEditor2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.chk_Trabajador = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Boton2 = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_ControlGarita = New ISL.Controles.Grilla(Me.components)
        Me.odControlGarita = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.cmbTipoLista = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New ISL.Controles.Agrupacion(Me.components)
        Me.fcDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.opMP = New ISL.Controles.Opciones(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbTipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.ficControlGarita = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.odVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_Vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_Vehiculos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.UGB_Vehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_Vehiculos.SuspendLayout()
        CType(Me.UGB_Motriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_Motriz.SuspendLayout()
        CType(Me.cmbPlacaMotriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.opcIEMotriz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGB_CargaVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_CargaVehiculo.SuspendLayout()
        CType(Me.cmbPlacaCarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.opcIECarreta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griOcupantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOcupantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_Ocupantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_Ocupantes.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.cmbNombreTripulante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opCondicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UEGB_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UEGB_Personal.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.UGB_Personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_Personal.SuspendLayout()
        CType(Me.UGB_Bien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_Bien.SuspendLayout()
        CType(Me.Texto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UGB_Persona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UGB_Persona.SuspendLayout()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_Trabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.grid_ControlGarita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odControlGarita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cmbTipoLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.fcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fcDetalle.SuspendLayout()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.opMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficControlGarita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficControlGarita.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griVehiculos)
        Me.UltraTabPageControl4.Controls.Add(Me.UEGB_Vehiculos)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(993, 419)
        '
        'griVehiculos
        '
        Me.griVehiculos.ContextMenuStrip = Me.mcDetalle
        Me.griVehiculos.DataSource = Me.odVehiculo
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griVehiculos.DisplayLayout.Appearance = Appearance1
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 4
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 110
        UltraGridColumn4.Header.Caption = "Pertenece a ISL"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Appearance3.BackColor = System.Drawing.Color.Khaki
        UltraGridBand1.Override.RowAppearance = Appearance3
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 3
        UltraGridColumn9.Width = 110
        UltraGridColumn10.Header.Caption = "Pertenece a ISL"
        UltraGridColumn10.Header.VisiblePosition = 4
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11})
        Appearance4.BackColor = System.Drawing.Color.LightCyan
        UltraGridBand2.Override.RowAppearance = Appearance4
        Me.griVehiculos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griVehiculos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griVehiculos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVehiculos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance5.BorderColor = System.Drawing.SystemColors.Window
        Me.griVehiculos.DisplayLayout.GroupByBox.Appearance = Appearance5
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVehiculos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance6
        Me.griVehiculos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVehiculos.DisplayLayout.GroupByBox.Hidden = True
        Appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance7.BackColor2 = System.Drawing.SystemColors.Control
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance7.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVehiculos.DisplayLayout.GroupByBox.PromptAppearance = Appearance7
        Me.griVehiculos.DisplayLayout.MaxColScrollRegions = 1
        Me.griVehiculos.DisplayLayout.MaxRowScrollRegions = 1
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Appearance8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griVehiculos.DisplayLayout.Override.ActiveCellAppearance = Appearance8
        Appearance9.BackColor = System.Drawing.SystemColors.Highlight
        Appearance9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griVehiculos.DisplayLayout.Override.ActiveRowAppearance = Appearance9
        Me.griVehiculos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griVehiculos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.griVehiculos.DisplayLayout.Override.CardAreaAppearance = Appearance10
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Appearance11.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griVehiculos.DisplayLayout.Override.CellAppearance = Appearance11
        Me.griVehiculos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculos.DisplayLayout.Override.CellPadding = 0
        Appearance12.BackColor = System.Drawing.SystemColors.Control
        Appearance12.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance12.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.BorderColor = System.Drawing.SystemColors.Window
        Me.griVehiculos.DisplayLayout.Override.GroupByRowAppearance = Appearance12
        Appearance13.TextHAlignAsString = "Left"
        Me.griVehiculos.DisplayLayout.Override.HeaderAppearance = Appearance13
        Me.griVehiculos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculos.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Appearance14.BorderColor = System.Drawing.Color.Silver
        Me.griVehiculos.DisplayLayout.Override.RowAppearance = Appearance14
        Me.griVehiculos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVehiculos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griVehiculos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griVehiculos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance15
        Me.griVehiculos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griVehiculos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griVehiculos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculos.Location = New System.Drawing.Point(233, 0)
        Me.griVehiculos.Name = "griVehiculos"
        Me.griVehiculos.Size = New System.Drawing.Size(760, 419)
        Me.griVehiculos.TabIndex = 11
        '
        'mcDetalle
        '
        Me.mcDetalle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(112, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        Me.AgregarToolStripMenuItem.ToolTipText = "Insertar un nuevo Detalle"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.SymbolDelete
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        Me.QuitarToolStripMenuItem.ToolTipText = "Quitar detalle seleccionado"
        '
        'odVehiculo
        '
        UltraDataColumn4.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5})
        Me.odVehiculo.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn9.DataType = GetType(Boolean)
        Me.odVehiculo.Band.Columns.AddRange(New Object() {UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10})
        '
        'UEGB_Vehiculos
        '
        Me.UEGB_Vehiculos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UEGB_Vehiculos.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UEGB_Vehiculos.Dock = System.Windows.Forms.DockStyle.Left
        Me.UEGB_Vehiculos.ExpandedSize = New System.Drawing.Size(233, 419)
        Me.UEGB_Vehiculos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UEGB_Vehiculos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UEGB_Vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.UEGB_Vehiculos.Name = "UEGB_Vehiculos"
        Me.UEGB_Vehiculos.Size = New System.Drawing.Size(233, 419)
        Me.UEGB_Vehiculos.TabIndex = 12
        Me.UEGB_Vehiculos.Text = "Vehículos"
        Me.UEGB_Vehiculos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.UGB_Vehiculos)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(19, 2)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(212, 415)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'UGB_Vehiculos
        '
        Me.UGB_Vehiculos.Controls.Add(Me.UGB_Motriz)
        Me.UGB_Vehiculos.Controls.Add(Me.UGB_CargaVehiculo)
        Me.UGB_Vehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGB_Vehiculos.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_Vehiculos.Location = New System.Drawing.Point(0, 0)
        Me.UGB_Vehiculos.Name = "UGB_Vehiculos"
        Me.UGB_Vehiculos.Size = New System.Drawing.Size(212, 415)
        Me.UGB_Vehiculos.TabIndex = 203
        Me.UGB_Vehiculos.Text = "Vehículos"
        Me.UGB_Vehiculos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UGB_Motriz
        '
        Me.UGB_Motriz.Controls.Add(Me.cmbPlacaMotriz)
        Me.UGB_Motriz.Controls.Add(Me.btnMotriz)
        Me.UGB_Motriz.Controls.Add(Me.GroupBox2)
        Me.UGB_Motriz.Controls.Add(Me.Etiqueta5)
        Me.UGB_Motriz.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_Motriz.Location = New System.Drawing.Point(5, 22)
        Me.UGB_Motriz.Name = "UGB_Motriz"
        Me.UGB_Motriz.Size = New System.Drawing.Size(193, 76)
        Me.UGB_Motriz.TabIndex = 1
        Me.UGB_Motriz.Text = "Motriz"
        Me.UGB_Motriz.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbPlacaMotriz
        '
        Appearance16.BackColor = System.Drawing.Color.Khaki
        Appearance16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPlacaMotriz.Appearance = Appearance16
        Me.cmbPlacaMotriz.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbPlacaMotriz.BackColor = System.Drawing.Color.Khaki
        Me.cmbPlacaMotriz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbPlacaMotriz.DisplayMember = "Placa"
        Me.cmbPlacaMotriz.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbPlacaMotriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlacaMotriz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPlacaMotriz.Location = New System.Drawing.Point(46, 49)
        Me.cmbPlacaMotriz.Name = "cmbPlacaMotriz"
        Me.cmbPlacaMotriz.Size = New System.Drawing.Size(111, 21)
        Me.cmbPlacaMotriz.TabIndex = 2
        Me.cmbPlacaMotriz.ValueMember = "Id"
        '
        'btnMotriz
        '
        Me.btnMotriz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMotriz.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnMotriz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMotriz.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btnMotriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMotriz.ForeColor = System.Drawing.Color.Black
        Me.btnMotriz.Location = New System.Drawing.Point(162, 33)
        Me.btnMotriz.Name = "btnMotriz"
        Me.btnMotriz.Size = New System.Drawing.Size(25, 24)
        Me.btnMotriz.TabIndex = 3
        Me.btnMotriz.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.opcIEMotriz)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 33)
        Me.GroupBox2.TabIndex = 255
        Me.GroupBox2.TabStop = False
        '
        'opcIEMotriz
        '
        Appearance17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.opcIEMotriz.Appearance = Appearance17
        Me.opcIEMotriz.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcIEMotriz.CheckedIndex = 0
        Me.opcIEMotriz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcIEMotriz.ForeColor = System.Drawing.Color.Black
        ValueListItem14.DataValue = "ValueListItem1"
        ValueListItem14.DisplayText = "Interna"
        ValueListItem15.DataValue = False
        ValueListItem15.DisplayText = "Externa"
        Me.opcIEMotriz.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem14, ValueListItem15})
        Me.opcIEMotriz.ItemSpacingHorizontal = 20
        Me.opcIEMotriz.Location = New System.Drawing.Point(18, 14)
        Me.opcIEMotriz.Name = "opcIEMotriz"
        Me.opcIEMotriz.Size = New System.Drawing.Size(133, 13)
        Me.opcIEMotriz.TabIndex = 1
        Me.opcIEMotriz.Text = "Interna"
        '
        'Etiqueta5
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta5.Appearance = Appearance18
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(6, 53)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta5.TabIndex = 253
        Me.Etiqueta5.Text = "Placa:"
        '
        'UGB_CargaVehiculo
        '
        Me.UGB_CargaVehiculo.Controls.Add(Me.cmbPlacaCarreta)
        Me.UGB_CargaVehiculo.Controls.Add(Me.btn_AgregarCarreta)
        Me.UGB_CargaVehiculo.Controls.Add(Me.GroupBox1)
        Me.UGB_CargaVehiculo.Controls.Add(Me.Etiqueta4)
        Me.UGB_CargaVehiculo.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_CargaVehiculo.Location = New System.Drawing.Point(6, 104)
        Me.UGB_CargaVehiculo.Name = "UGB_CargaVehiculo"
        Me.UGB_CargaVehiculo.Size = New System.Drawing.Size(193, 76)
        Me.UGB_CargaVehiculo.TabIndex = 2
        Me.UGB_CargaVehiculo.Text = "Carreta"
        Me.UGB_CargaVehiculo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbPlacaCarreta
        '
        Appearance19.BackColor = System.Drawing.Color.LightCyan
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPlacaCarreta.Appearance = Appearance19
        Me.cmbPlacaCarreta.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbPlacaCarreta.BackColor = System.Drawing.Color.LightCyan
        Me.cmbPlacaCarreta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbPlacaCarreta.DisplayMember = "Placa"
        Me.cmbPlacaCarreta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbPlacaCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlacaCarreta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbPlacaCarreta.Location = New System.Drawing.Point(45, 49)
        Me.cmbPlacaCarreta.Name = "cmbPlacaCarreta"
        Me.cmbPlacaCarreta.Size = New System.Drawing.Size(111, 21)
        Me.cmbPlacaCarreta.TabIndex = 2
        Me.cmbPlacaCarreta.ValueMember = "Id"
        '
        'btn_AgregarCarreta
        '
        Me.btn_AgregarCarreta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AgregarCarreta.BackColorInternal = System.Drawing.Color.Transparent
        Me.btn_AgregarCarreta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_AgregarCarreta.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btn_AgregarCarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarCarreta.ForeColor = System.Drawing.Color.Black
        Me.btn_AgregarCarreta.Location = New System.Drawing.Point(162, 33)
        Me.btn_AgregarCarreta.Name = "btn_AgregarCarreta"
        Me.btn_AgregarCarreta.Size = New System.Drawing.Size(25, 24)
        Me.btn_AgregarCarreta.TabIndex = 3
        Me.btn_AgregarCarreta.Text = "+"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.opcIECarreta)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 33)
        Me.GroupBox1.TabIndex = 255
        Me.GroupBox1.TabStop = False
        '
        'opcIECarreta
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.opcIECarreta.Appearance = Appearance20
        Me.opcIECarreta.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcIECarreta.CheckedIndex = 0
        Me.opcIECarreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcIECarreta.ForeColor = System.Drawing.Color.Black
        ValueListItem17.DataValue = "ValueListItem1"
        ValueListItem17.DisplayText = "Interna"
        ValueListItem18.DataValue = False
        ValueListItem18.DisplayText = "Externa"
        Me.opcIECarreta.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem17, ValueListItem18})
        Me.opcIECarreta.ItemSpacingHorizontal = 20
        Me.opcIECarreta.Location = New System.Drawing.Point(18, 14)
        Me.opcIECarreta.Name = "opcIECarreta"
        Me.opcIECarreta.Size = New System.Drawing.Size(133, 13)
        Me.opcIECarreta.TabIndex = 1
        Me.opcIECarreta.Text = "Interna"
        '
        'Etiqueta4
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance21
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(6, 53)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta4.TabIndex = 253
        Me.Etiqueta4.Text = "Placa:"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griOcupantes)
        Me.UltraTabPageControl5.Controls.Add(Me.UEGB_Ocupantes)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(993, 419)
        '
        'griOcupantes
        '
        Me.griOcupantes.ContextMenuStrip = Me.mcDetalle
        Me.griOcupantes.DataSource = Me.odOcupantes
        Appearance22.BackColor = System.Drawing.SystemColors.Window
        Appearance22.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOcupantes.DisplayLayout.Appearance = Appearance22
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.Caption = "Placa | DNI"
        UltraGridColumn13.Header.VisiblePosition = 3
        UltraGridColumn13.Width = 97
        UltraGridColumn14.Header.Caption = "De ISL"
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Width = 97
        UltraGridColumn15.Header.Caption = "Tipo | Condición"
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Width = 195
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Appearance23.BackColor = System.Drawing.Color.Khaki
        UltraGridBand3.Override.RowAppearance = Appearance23
        UltraGridBand4.ColHeadersVisible = False
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 5
        UltraGridColumn21.Width = 97
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.Width = 195
        UltraGridColumn23.Header.Caption = "De ISL"
        UltraGridColumn23.Header.VisiblePosition = 4
        UltraGridColumn23.Width = 97
        UltraGridColumn24.Header.VisiblePosition = 3
        UltraGridColumn25.Header.VisiblePosition = 7
        UltraGridColumn26.Header.VisiblePosition = 8
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridBand5.ColHeadersVisible = False
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32})
        Me.griOcupantes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griOcupantes.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griOcupantes.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griOcupantes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOcupantes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance24.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance24.BorderColor = System.Drawing.SystemColors.Window
        Me.griOcupantes.DisplayLayout.GroupByBox.Appearance = Appearance24
        Appearance25.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOcupantes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance25
        Me.griOcupantes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOcupantes.DisplayLayout.GroupByBox.Hidden = True
        Appearance26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance26.BackColor2 = System.Drawing.SystemColors.Control
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance26.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOcupantes.DisplayLayout.GroupByBox.PromptAppearance = Appearance26
        Me.griOcupantes.DisplayLayout.MaxColScrollRegions = 1
        Me.griOcupantes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griOcupantes.DisplayLayout.Override.ActiveCellAppearance = Appearance27
        Appearance28.BackColor = System.Drawing.SystemColors.Highlight
        Appearance28.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griOcupantes.DisplayLayout.Override.ActiveRowAppearance = Appearance28
        Me.griOcupantes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griOcupantes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Me.griOcupantes.DisplayLayout.Override.CardAreaAppearance = Appearance29
        Appearance30.BorderColor = System.Drawing.Color.Silver
        Appearance30.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griOcupantes.DisplayLayout.Override.CellAppearance = Appearance30
        Me.griOcupantes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOcupantes.DisplayLayout.Override.CellPadding = 0
        Appearance31.BackColor = System.Drawing.SystemColors.Control
        Appearance31.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance31.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.BorderColor = System.Drawing.SystemColors.Window
        Me.griOcupantes.DisplayLayout.Override.GroupByRowAppearance = Appearance31
        Appearance32.TextHAlignAsString = "Left"
        Me.griOcupantes.DisplayLayout.Override.HeaderAppearance = Appearance32
        Me.griOcupantes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOcupantes.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
        Appearance33.BackColor = System.Drawing.SystemColors.Window
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Me.griOcupantes.DisplayLayout.Override.RowAppearance = Appearance33
        Me.griOcupantes.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOcupantes.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOcupantes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griOcupantes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance34
        Me.griOcupantes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOcupantes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griOcupantes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griOcupantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOcupantes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOcupantes.Location = New System.Drawing.Point(21, 0)
        Me.griOcupantes.Name = "griOcupantes"
        Me.griOcupantes.Size = New System.Drawing.Size(972, 419)
        Me.griOcupantes.TabIndex = 345
        '
        'odOcupantes
        '
        UltraDataBand3.Columns.AddRange(New Object() {UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16})
        UltraDataBand2.ChildBands.AddRange(New Object() {UltraDataBand3})
        UltraDataColumn22.DataType = GetType(Boolean)
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        Me.odOcupantes.Band.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn27.DataType = GetType(Boolean)
        Me.odOcupantes.Band.Columns.AddRange(New Object() {UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        '
        'UEGB_Ocupantes
        '
        Me.UEGB_Ocupantes.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UEGB_Ocupantes.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UEGB_Ocupantes.Dock = System.Windows.Forms.DockStyle.Left
        Me.UEGB_Ocupantes.Expanded = False
        Me.UEGB_Ocupantes.ExpandedSize = New System.Drawing.Size(387, 419)
        Me.UEGB_Ocupantes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UEGB_Ocupantes.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UEGB_Ocupantes.Location = New System.Drawing.Point(0, 0)
        Me.UEGB_Ocupantes.Name = "UEGB_Ocupantes"
        Me.UEGB_Ocupantes.Size = New System.Drawing.Size(21, 419)
        Me.UEGB_Ocupantes.TabIndex = 344
        Me.UEGB_Ocupantes.Text = "Tripulantes"
        Me.UEGB_Ocupantes.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.UltraGroupBox2)
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(365, 443)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel3.Visible = False
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraGroupBox2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(365, 443)
        Me.UltraGroupBox2.TabIndex = 204
        Me.UltraGroupBox2.Text = "Tripulantes"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.txtObs)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta12)
        Me.UltraGroupBox3.Controls.Add(Me.txtCarga)
        Me.UltraGroupBox3.Controls.Add(Me.Etiqueta13)
        Me.UltraGroupBox3.Controls.Add(Me.btnAddBienes)
        Me.UltraGroupBox3.ForeColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox3.Location = New System.Drawing.Point(5, 145)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(350, 209)
        Me.UltraGroupBox3.TabIndex = 2
        Me.UltraGroupBox3.Text = "Bienes"
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtObs
        '
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObs.Appearance = Appearance35
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObs.Location = New System.Drawing.Point(11, 125)
        Me.txtObs.MaxLength = 200
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(302, 76)
        Me.txtObs.TabIndex = 2
        '
        'Etiqueta12
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance36
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(9, 110)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta12.TabIndex = 344
        Me.Etiqueta12.Text = "Observación:"
        '
        'txtCarga
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCarga.Appearance = Appearance37
        Me.txtCarga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarga.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarga.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCarga.Location = New System.Drawing.Point(11, 36)
        Me.txtCarga.MaxLength = 200
        Me.txtCarga.Multiline = True
        Me.txtCarga.Name = "txtCarga"
        Me.txtCarga.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCarga.Size = New System.Drawing.Size(302, 62)
        Me.txtCarga.TabIndex = 1
        '
        'Etiqueta13
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta13.Appearance = Appearance38
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(11, 20)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta13.TabIndex = 342
        Me.Etiqueta13.Text = "Carga:"
        '
        'btnAddBienes
        '
        Me.btnAddBienes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBienes.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAddBienes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddBienes.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btnAddBienes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBienes.ForeColor = System.Drawing.Color.Black
        Me.btnAddBienes.Location = New System.Drawing.Point(319, 177)
        Me.btnAddBienes.Name = "btnAddBienes"
        Me.btnAddBienes.Size = New System.Drawing.Size(25, 24)
        Me.btnAddBienes.TabIndex = 3
        Me.btnAddBienes.Text = "+"
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.cmbNombreTripulante)
        Me.UltraGroupBox1.Controls.Add(Me.chk_Empleado)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta9)
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta10)
        Me.UltraGroupBox1.Controls.Add(Me.txtDNI)
        Me.UltraGroupBox1.Controls.Add(Me.btnAddTripulante)
        Me.UltraGroupBox1.Controls.Add(Me.opCondicion)
        Me.UltraGroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox1.Location = New System.Drawing.Point(5, 22)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(348, 117)
        Me.UltraGroupBox1.TabIndex = 1
        Me.UltraGroupBox1.Text = "Tripulantes"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbNombreTripulante
        '
        Appearance39.BackColor = System.Drawing.Color.BlanchedAlmond
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbNombreTripulante.Appearance = Appearance39
        Me.cmbNombreTripulante.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbNombreTripulante.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.cmbNombreTripulante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbNombreTripulante.DisplayMember = "NombreCompleto"
        Me.cmbNombreTripulante.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbNombreTripulante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNombreTripulante.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbNombreTripulante.Location = New System.Drawing.Point(62, 81)
        Me.cmbNombreTripulante.Name = "cmbNombreTripulante"
        Me.cmbNombreTripulante.Size = New System.Drawing.Size(251, 21)
        Me.cmbNombreTripulante.TabIndex = 4
        Me.cmbNombreTripulante.ValueMember = "Id"
        '
        'chk_Empleado
        '
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.chk_Empleado.Appearance = Appearance40
        Me.chk_Empleado.AutoSize = True
        Me.chk_Empleado.BackColor = System.Drawing.Color.Transparent
        Me.chk_Empleado.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_Empleado.Checked = True
        Me.chk_Empleado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Empleado.Location = New System.Drawing.Point(58, 29)
        Me.chk_Empleado.Name = "chk_Empleado"
        Me.chk_Empleado.Size = New System.Drawing.Size(72, 18)
        Me.chk_Empleado.TabIndex = 1
        Me.chk_Empleado.Text = "Empleado"
        '
        'Etiqueta9
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance41
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(6, 84)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta9.TabIndex = 350
        Me.Etiqueta9.Text = "Nombre :"
        '
        'Etiqueta10
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance42
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(22, 59)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta10.TabIndex = 349
        Me.Etiqueta10.Text = "DNI :"
        '
        'txtDNI
        '
        Me.txtDNI.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(60, 53)
        Me.txtDNI.MaxLength = 15
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(100, 21)
        Me.txtDNI.TabIndex = 3
        '
        'btnAddTripulante
        '
        Me.btnAddTripulante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTripulante.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAddTripulante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTripulante.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.btnAddTripulante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTripulante.ForeColor = System.Drawing.Color.Black
        Me.btnAddTripulante.Location = New System.Drawing.Point(317, 78)
        Me.btnAddTripulante.Name = "btnAddTripulante"
        Me.btnAddTripulante.Size = New System.Drawing.Size(25, 24)
        Me.btnAddTripulante.TabIndex = 5
        Me.btnAddTripulante.Text = "+"
        '
        'opCondicion
        '
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.opCondicion.Appearance = Appearance43
        Me.opCondicion.BackColor = System.Drawing.Color.Transparent
        Me.opCondicion.BackColorInternal = System.Drawing.Color.Transparent
        Me.opCondicion.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opCondicion.CheckedIndex = 0
        Me.opCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opCondicion.ForeColor = System.Drawing.Color.MidnightBlue
        ValueListItem5.DataValue = "Default Item"
        ValueListItem5.DisplayText = "Piloto"
        ValueListItem6.DataValue = "ValueListItem1"
        ValueListItem6.DisplayText = "Copiloto"
        ValueListItem7.DataValue = "ValueListItem2"
        ValueListItem7.DisplayText = "Ayudante"
        ValueListItem8.DataValue = "ValueListItem3"
        ValueListItem8.DisplayText = "Ocupante"
        Me.opCondicion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8})
        Me.opCondicion.Location = New System.Drawing.Point(272, 18)
        Me.opCondicion.Name = "opCondicion"
        Me.opCondicion.Size = New System.Drawing.Size(70, 60)
        Me.opCondicion.TabIndex = 2
        Me.opCondicion.Text = "Piloto"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Grilla1)
        Me.UltraTabPageControl3.Controls.Add(Me.UEGB_Personal)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(993, 419)
        '
        'Grilla1
        '
        Appearance44.BackColor = System.Drawing.SystemColors.Window
        Appearance44.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.Grilla1.DisplayLayout.Appearance = Appearance44
        Me.Grilla1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grilla1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance45.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.Grilla1.DisplayLayout.GroupByBox.Appearance = Appearance45
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance46
        Me.Grilla1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.Grilla1.DisplayLayout.GroupByBox.Hidden = True
        Appearance47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance47.BackColor2 = System.Drawing.SystemColors.Control
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Grilla1.DisplayLayout.GroupByBox.PromptAppearance = Appearance47
        Me.Grilla1.DisplayLayout.MaxColScrollRegions = 1
        Me.Grilla1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Grilla1.DisplayLayout.Override.ActiveCellAppearance = Appearance48
        Appearance49.BackColor = System.Drawing.SystemColors.Highlight
        Appearance49.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Grilla1.DisplayLayout.Override.ActiveRowAppearance = Appearance49
        Me.Grilla1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.Grilla1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance50.BackColor = System.Drawing.SystemColors.Window
        Me.Grilla1.DisplayLayout.Override.CardAreaAppearance = Appearance50
        Appearance51.BorderColor = System.Drawing.Color.Silver
        Appearance51.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.Grilla1.DisplayLayout.Override.CellAppearance = Appearance51
        Me.Grilla1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.Grilla1.DisplayLayout.Override.CellPadding = 0
        Me.Grilla1.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.Grilla1.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance52.BackColor = System.Drawing.SystemColors.Control
        Appearance52.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance52.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.BorderColor = System.Drawing.SystemColors.Window
        Me.Grilla1.DisplayLayout.Override.GroupByRowAppearance = Appearance52
        Appearance53.TextHAlignAsString = "Left"
        Me.Grilla1.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.Grilla1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance54.BackColor = System.Drawing.SystemColors.Window
        Appearance54.BorderColor = System.Drawing.Color.Silver
        Me.Grilla1.DisplayLayout.Override.RowAppearance = Appearance54
        Me.Grilla1.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.Grilla1.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.Grilla1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance55.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Grilla1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance55
        Me.Grilla1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.Grilla1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.Grilla1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.Grilla1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grilla1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grilla1.Location = New System.Drawing.Point(21, 0)
        Me.Grilla1.Name = "Grilla1"
        Me.Grilla1.Size = New System.Drawing.Size(972, 419)
        Me.Grilla1.TabIndex = 10
        '
        'UEGB_Personal
        '
        Me.UEGB_Personal.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.UEGB_Personal.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UEGB_Personal.Dock = System.Windows.Forms.DockStyle.Left
        Me.UEGB_Personal.Expanded = False
        Me.UEGB_Personal.ExpandedSize = New System.Drawing.Size(390, 419)
        Me.UEGB_Personal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UEGB_Personal.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UEGB_Personal.Location = New System.Drawing.Point(0, 0)
        Me.UEGB_Personal.Name = "UEGB_Personal"
        Me.UEGB_Personal.Size = New System.Drawing.Size(21, 419)
        Me.UEGB_Personal.TabIndex = 9
        Me.UEGB_Personal.Text = "Personal"
        Me.UEGB_Personal.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.VisualStudio2005
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UGB_Personal)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(368, 443)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'UGB_Personal
        '
        Me.UGB_Personal.Controls.Add(Me.UGB_Bien)
        Me.UGB_Personal.Controls.Add(Me.UGB_Persona)
        Me.UGB_Personal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGB_Personal.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_Personal.Location = New System.Drawing.Point(0, 0)
        Me.UGB_Personal.Name = "UGB_Personal"
        Me.UGB_Personal.Size = New System.Drawing.Size(368, 443)
        Me.UGB_Personal.TabIndex = 204
        Me.UGB_Personal.Text = "Personal"
        Me.UGB_Personal.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UGB_Bien
        '
        Me.UGB_Bien.Controls.Add(Me.Texto2)
        Me.UGB_Bien.Controls.Add(Me.Etiqueta11)
        Me.UGB_Bien.Controls.Add(Me.txtGlosa)
        Me.UGB_Bien.Controls.Add(Me.Etiqueta6)
        Me.UGB_Bien.Controls.Add(Me.Boton4)
        Me.UGB_Bien.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_Bien.Location = New System.Drawing.Point(5, 108)
        Me.UGB_Bien.Name = "UGB_Bien"
        Me.UGB_Bien.Size = New System.Drawing.Size(350, 209)
        Me.UGB_Bien.TabIndex = 343
        Me.UGB_Bien.Text = "Bienes"
        Me.UGB_Bien.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Texto2
        '
        Appearance56.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Texto2.Appearance = Appearance56
        Me.Texto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Texto2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Texto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texto2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Texto2.Location = New System.Drawing.Point(11, 125)
        Me.Texto2.MaxLength = 200
        Me.Texto2.Multiline = True
        Me.Texto2.Name = "Texto2"
        Me.Texto2.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.Texto2.Size = New System.Drawing.Size(302, 76)
        Me.Texto2.TabIndex = 343
        '
        'Etiqueta11
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance57
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(9, 110)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(67, 15)
        Me.Etiqueta11.TabIndex = 344
        Me.Etiqueta11.Text = "Observación:"
        '
        'txtGlosa
        '
        Appearance58.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Appearance = Appearance58
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtGlosa.Location = New System.Drawing.Point(11, 36)
        Me.txtGlosa.MaxLength = 200
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGlosa.Size = New System.Drawing.Size(302, 62)
        Me.txtGlosa.TabIndex = 341
        '
        'Etiqueta6
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance59
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(11, 20)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta6.TabIndex = 342
        Me.Etiqueta6.Text = "Carga:"
        '
        'Boton4
        '
        Me.Boton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton4.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton4.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.Boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton4.ForeColor = System.Drawing.Color.Black
        Me.Boton4.Location = New System.Drawing.Point(319, 177)
        Me.Boton4.Name = "Boton4"
        Me.Boton4.Size = New System.Drawing.Size(25, 24)
        Me.Boton4.TabIndex = 340
        Me.Boton4.Text = "+"
        '
        'UGB_Persona
        '
        Me.UGB_Persona.Controls.Add(Me.UltraTextEditor2)
        Me.UGB_Persona.Controls.Add(Me.chk_Trabajador)
        Me.UGB_Persona.Controls.Add(Me.Etiqueta7)
        Me.UGB_Persona.Controls.Add(Me.Etiqueta1)
        Me.UGB_Persona.Controls.Add(Me.UltraTextEditor1)
        Me.UGB_Persona.Controls.Add(Me.Boton2)
        Me.UGB_Persona.ForeColor = System.Drawing.Color.Transparent
        Me.UGB_Persona.Location = New System.Drawing.Point(5, 22)
        Me.UGB_Persona.Name = "UGB_Persona"
        Me.UGB_Persona.Size = New System.Drawing.Size(350, 80)
        Me.UGB_Persona.TabIndex = 341
        Me.UGB_Persona.Text = "Personal"
        Me.UGB_Persona.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraTextEditor2
        '
        Me.UltraTextEditor2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraTextEditor2.Enabled = False
        Me.UltraTextEditor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTextEditor2.Location = New System.Drawing.Point(62, 46)
        Me.UltraTextEditor2.MaxLength = 15
        Me.UltraTextEditor2.Name = "UltraTextEditor2"
        Me.UltraTextEditor2.Size = New System.Drawing.Size(251, 21)
        Me.UltraTextEditor2.TabIndex = 347
        '
        'chk_Trabajador
        '
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.chk_Trabajador.Appearance = Appearance60
        Me.chk_Trabajador.AutoSize = True
        Me.chk_Trabajador.BackColor = System.Drawing.Color.Transparent
        Me.chk_Trabajador.BackColorInternal = System.Drawing.Color.Transparent
        Me.chk_Trabajador.Location = New System.Drawing.Point(168, 25)
        Me.chk_Trabajador.Name = "chk_Trabajador"
        Me.chk_Trabajador.Size = New System.Drawing.Size(72, 18)
        Me.chk_Trabajador.TabIndex = 346
        Me.chk_Trabajador.Text = "Empleado"
        '
        'Etiqueta7
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance61
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 50)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta7.TabIndex = 345
        Me.Etiqueta7.Text = "Nombre :"
        '
        'Etiqueta1
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance62
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(26, 24)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(30, 15)
        Me.Etiqueta1.TabIndex = 344
        Me.Etiqueta1.Text = "DNI :"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.UltraTextEditor1.Enabled = False
        Me.UltraTextEditor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraTextEditor1.Location = New System.Drawing.Point(62, 21)
        Me.UltraTextEditor1.MaxLength = 15
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(100, 21)
        Me.UltraTextEditor1.TabIndex = 343
        '
        'Boton2
        '
        Me.Boton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Boton2.BackColorInternal = System.Drawing.Color.Transparent
        Me.Boton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boton2.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Button
        Me.Boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.ForeColor = System.Drawing.Color.Black
        Me.Boton2.Location = New System.Drawing.Point(319, 37)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(25, 24)
        Me.Boton2.TabIndex = 340
        Me.Boton2.Text = "+"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(999, 572)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.grid_ControlGarita)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 81)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(999, 491)
        Me.Agrupacion4.TabIndex = 3
        Me.Agrupacion4.Text = "Listado de Control Garita"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grid_ControlGarita
        '
        Me.grid_ControlGarita.DataSource = Me.odControlGarita
        Appearance63.BackColor = System.Drawing.SystemColors.Window
        Appearance63.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_ControlGarita.DisplayLayout.Appearance = Appearance63
        Appearance64.TextHAlignAsString = "Center"
        UltraGridColumn33.Header.Appearance = Appearance64
        UltraGridColumn33.Header.VisiblePosition = 0
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance65.TextHAlignAsString = "Center"
        UltraGridColumn34.Header.Appearance = Appearance65
        UltraGridColumn34.Header.VisiblePosition = 1
        UltraGridColumn34.MaskInput = "{date} {time}"
        UltraGridColumn34.Width = 132
        UltraGridColumn35.Header.VisiblePosition = 2
        UltraGridColumn35.Width = 83
        UltraGridColumn36.Header.VisiblePosition = 3
        UltraGridColumn36.Width = 463
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.grid_ControlGarita.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grid_ControlGarita.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_ControlGarita.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance66.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance66.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance66.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance66.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_ControlGarita.DisplayLayout.GroupByBox.Appearance = Appearance66
        Appearance67.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_ControlGarita.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance67
        Me.grid_ControlGarita.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_ControlGarita.DisplayLayout.GroupByBox.Hidden = True
        Appearance68.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance68.BackColor2 = System.Drawing.SystemColors.Control
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance68.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_ControlGarita.DisplayLayout.GroupByBox.PromptAppearance = Appearance68
        Me.grid_ControlGarita.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_ControlGarita.DisplayLayout.MaxRowScrollRegions = 1
        Appearance69.BackColor = System.Drawing.SystemColors.Window
        Appearance69.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grid_ControlGarita.DisplayLayout.Override.ActiveCellAppearance = Appearance69
        Appearance70.BackColor = System.Drawing.SystemColors.Highlight
        Appearance70.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_ControlGarita.DisplayLayout.Override.ActiveRowAppearance = Appearance70
        Me.grid_ControlGarita.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_ControlGarita.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Me.grid_ControlGarita.DisplayLayout.Override.CardAreaAppearance = Appearance71
        Appearance72.BorderColor = System.Drawing.Color.Silver
        Appearance72.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid_ControlGarita.DisplayLayout.Override.CellAppearance = Appearance72
        Me.grid_ControlGarita.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_ControlGarita.DisplayLayout.Override.CellPadding = 0
        Me.grid_ControlGarita.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_ControlGarita.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance73.BackColor = System.Drawing.SystemColors.Control
        Appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance73.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance73.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_ControlGarita.DisplayLayout.Override.GroupByRowAppearance = Appearance73
        Appearance74.TextHAlignAsString = "Left"
        Me.grid_ControlGarita.DisplayLayout.Override.HeaderAppearance = Appearance74
        Me.grid_ControlGarita.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance75.BackColor = System.Drawing.SystemColors.Window
        Appearance75.BorderColor = System.Drawing.Color.Silver
        Me.grid_ControlGarita.DisplayLayout.Override.RowAppearance = Appearance75
        Me.grid_ControlGarita.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_ControlGarita.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_ControlGarita.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance76.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid_ControlGarita.DisplayLayout.Override.TemplateAddRowAppearance = Appearance76
        Me.grid_ControlGarita.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_ControlGarita.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_ControlGarita.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_ControlGarita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ControlGarita.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_ControlGarita.Location = New System.Drawing.Point(2, 19)
        Me.grid_ControlGarita.Name = "grid_ControlGarita"
        Me.grid_ControlGarita.Size = New System.Drawing.Size(995, 470)
        Me.grid_ControlGarita.TabIndex = 3
        '
        'odControlGarita
        '
        Me.odControlGarita.Band.Columns.AddRange(New Object() {UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.cmbTipoLista)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion3.Controls.Add(Me.rfFechaHasta)
        Me.Agrupacion3.Controls.Add(Me.rfFechaDesde)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(999, 81)
        Me.Agrupacion3.TabIndex = 2
        Me.Agrupacion3.Text = "Filtros:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cmbTipoLista
        '
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.cmbTipoLista.Appearance = Appearance77
        Me.cmbTipoLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbTipoLista.DisplayMember = "Nombre"
        Me.cmbTipoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoLista.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipoLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoLista.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "ValueListItem2"
        ValueListItem1.DisplayText = "TODOS"
        ValueListItem3.DataValue = "ValueListItem0"
        ValueListItem3.DisplayText = "INGRESO"
        ValueListItem4.DataValue = "ValueListItem1"
        ValueListItem4.DisplayText = "SALIDA"
        Me.cmbTipoLista.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem3, ValueListItem4})
        Me.cmbTipoLista.Location = New System.Drawing.Point(53, 52)
        Me.cmbTipoLista.Name = "cmbTipoLista"
        Me.cmbTipoLista.Size = New System.Drawing.Size(98, 22)
        Me.cmbTipoLista.TabIndex = 340
        Me.cmbTipoLista.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta14.Appearance = Appearance78
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(18, 55)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta14.TabIndex = 339
        Me.Etiqueta14.Text = "Tipo :"
        '
        'rfFechaHasta
        '
        Me.rfFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaHasta.Location = New System.Drawing.Point(196, 26)
        Me.rfFechaHasta.Name = "rfFechaHasta"
        Me.rfFechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaHasta.TabIndex = 338
        '
        'rfFechaDesde
        '
        Me.rfFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaDesde.Location = New System.Drawing.Point(53, 26)
        Me.rfFechaDesde.Name = "rfFechaDesde"
        Me.rfFechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaDesde.TabIndex = 337
        '
        'Etiqueta8
        '
        Appearance79.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance79
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(11, 28)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta8.TabIndex = 335
        Me.Etiqueta8.Text = "Desde:"
        '
        'Etiqueta21
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance80
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(159, 28)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 336
        Me.Etiqueta21.Text = "Hasta:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(999, 572)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.fcDetalle)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Top)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDetalle.ForeColor = System.Drawing.Color.Black
        Me.agrDetalle.Location = New System.Drawing.Point(0, 126)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(999, 446)
        Me.agrDetalle.TabIndex = 204
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'fcDetalle
        '
        Me.fcDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.fcDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.fcDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.fcDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.fcDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fcDetalle.Location = New System.Drawing.Point(2, 2)
        Me.fcDetalle.Name = "fcDetalle"
        Me.fcDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.fcDetalle.Size = New System.Drawing.Size(995, 442)
        Me.fcDetalle.TabIndex = 8
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Vehículos"
        UltraTab15.TabPage = Me.UltraTabPageControl5
        UltraTab15.Text = "Ocupantes"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Personal"
        Me.fcDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab15, UltraTab3})
        Me.fcDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(993, 419)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(995, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(2, 444)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(995, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(2, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 442)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(997, 2)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 442)
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.UltraGroupBox4)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.ForeColor = System.Drawing.Color.Transparent
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(999, 126)
        Me.agrDatoGeneral.TabIndex = 202
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta3)
        Me.UltraGroupBox4.Controls.Add(Me.opMP)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox4.Controls.Add(Me.cmbTipo)
        Me.UltraGroupBox4.Controls.Add(Me.dtpFecha)
        Me.UltraGroupBox4.ForeColor = System.Drawing.Color.Transparent
        Me.UltraGroupBox4.Location = New System.Drawing.Point(13, 21)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(181, 95)
        Me.UltraGroupBox4.TabIndex = 326
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta3
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance81
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(6, 15)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta3.TabIndex = 231
        Me.Etiqueta3.Text = "Fecha:"
        '
        'opMP
        '
        Appearance82.ForeColor = System.Drawing.Color.MidnightBlue
        Me.opMP.Appearance = Appearance82
        Me.opMP.BackColor = System.Drawing.Color.Transparent
        Me.opMP.BackColorInternal = System.Drawing.Color.Transparent
        Me.opMP.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opMP.CheckedIndex = 1
        Me.opMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opMP.ForeColor = System.Drawing.Color.Black
        ValueListItem9.DataValue = "ValueListItem1"
        ValueListItem9.DisplayText = "Movilidad"
        ValueListItem10.DataValue = False
        ValueListItem10.DisplayText = "Personal"
        Me.opMP.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem9, ValueListItem10})
        Me.opMP.ItemSpacingHorizontal = 20
        Me.opMP.Location = New System.Drawing.Point(10, 72)
        Me.opMP.Name = "opMP"
        Me.opMP.Size = New System.Drawing.Size(165, 17)
        Me.opMP.TabIndex = 325
        Me.opMP.Text = "Personal"
        '
        'Etiqueta2
        '
        Appearance83.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance83
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 45)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(32, 15)
        Me.Etiqueta2.TabIndex = 6
        Me.Etiqueta2.Text = "Tipo :"
        '
        'cmbTipo
        '
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.cmbTipo.Appearance = Appearance84
        Me.cmbTipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbTipo.DisplayMember = "Nombre"
        Me.cmbTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.Black
        ValueListItem2.DataValue = "ValueListItem0"
        ValueListItem2.DisplayText = "INGRESO"
        ValueListItem11.DataValue = "ValueListItem1"
        ValueListItem11.DisplayText = "SALIDA"
        Me.cmbTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem11})
        Me.cmbTipo.Location = New System.Drawing.Point(43, 40)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(105, 21)
        Me.cmbTipo.TabIndex = 324
        Me.cmbTipo.ValueMember = "Id"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(45, 13)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 323
        '
        'ficControlGarita
        '
        Me.ficControlGarita.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficControlGarita.Controls.Add(Me.UltraTabPageControl1)
        Me.ficControlGarita.Controls.Add(Me.UltraTabPageControl2)
        Me.ficControlGarita.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficControlGarita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficControlGarita.Location = New System.Drawing.Point(0, 0)
        Me.ficControlGarita.Name = "ficControlGarita"
        Me.ficControlGarita.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficControlGarita.Size = New System.Drawing.Size(1001, 595)
        Me.ficControlGarita.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Listar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficControlGarita.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficControlGarita.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(999, 572)
        '
        'frm_Control_Garita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 595)
        Me.Controls.Add(Me.ficControlGarita)
        Me.Name = "frm_Control_Garita"
        Me.Text = "Control Garita"
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.odVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_Vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_Vehiculos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.UGB_Vehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_Vehiculos.ResumeLayout(False)
        CType(Me.UGB_Motriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_Motriz.ResumeLayout(False)
        Me.UGB_Motriz.PerformLayout()
        CType(Me.cmbPlacaMotriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.opcIEMotriz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGB_CargaVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_CargaVehiculo.ResumeLayout(False)
        Me.UGB_CargaVehiculo.PerformLayout()
        CType(Me.cmbPlacaCarreta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.opcIECarreta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griOcupantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOcupantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_Ocupantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_Ocupantes.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.txtObs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.cmbNombreTripulante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Empleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opCondicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Grilla1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UEGB_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UEGB_Personal.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.UGB_Personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_Personal.ResumeLayout(False)
        CType(Me.UGB_Bien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_Bien.ResumeLayout(False)
        Me.UGB_Bien.PerformLayout()
        CType(Me.Texto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UGB_Persona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UGB_Persona.ResumeLayout(False)
        Me.UGB_Persona.PerformLayout()
        CType(Me.UltraTextEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_Trabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.grid_ControlGarita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odControlGarita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cmbTipoLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        CType(Me.fcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fcDetalle.ResumeLayout(False)
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.opMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficControlGarita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficControlGarita.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficControlGarita As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents grid_ControlGarita As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDetalle As ISL.Controles.Agrupacion
    Friend WithEvents fcDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UEGB_Personal As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents rfFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents odControlGarita As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmbTipo As ISL.Controles.ComboMaestros
    Friend WithEvents Grilla1 As ISL.Controles.Grilla
    Friend WithEvents UEGB_Vehiculos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griVehiculos As ISL.Controles.Grilla
    Friend WithEvents UGB_Vehiculos As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UGB_Personal As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odVehiculo As ISL.Controles.OrigenDatos
    Friend WithEvents UGB_CargaVehiculo As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_AgregarCarreta As ISL.Controles.Boton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents opcIECarreta As ISL.Controles.Opciones
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents UGB_Motriz As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnMotriz As ISL.Controles.Boton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents opcIEMotriz As ISL.Controles.Opciones
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents UGB_Bien As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Boton4 As ISL.Controles.Boton
    Friend WithEvents UGB_Persona As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Boton2 As ISL.Controles.Boton
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UEGB_Ocupantes As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btnAddTripulante As ISL.Controles.Boton
    Friend WithEvents opCondicion As ISL.Controles.Opciones
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTextEditor2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chk_Trabajador As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_Empleado As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents txtDNI As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents griOcupantes As ISL.Controles.Grilla
    Friend WithEvents Texto2 As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents odOcupantes As ISL.Controles.OrigenDatos
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtObs As ISL.Controles.Texto
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents txtCarga As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents btnAddBienes As ISL.Controles.Boton
    Friend WithEvents cmbTipoLista As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents cmbPlacaMotriz As ISL.Controles.ComboMaestros
    Friend WithEvents cmbPlacaCarreta As ISL.Controles.ComboMaestros
    Friend WithEvents cmbNombreTripulante As ISL.Controles.ComboMaestros
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opMP As ISL.Controles.Opciones
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
End Class
