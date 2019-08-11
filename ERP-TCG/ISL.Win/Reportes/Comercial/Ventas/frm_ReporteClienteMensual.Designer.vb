<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteClienteMensual
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
        Dim PaintElement1 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ene_Monto")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ene_Porc")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Feb_Monto")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Feb_Porc")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mar_Monto")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mar_Porc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abr_Monto")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abr_Porc")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("May_Monto")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("May_Porc")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jun_Monto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jun_Porc")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jul_Monto")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jul_Porc")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ago_Monto")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ago_Porc")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sep_Monto")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sep_Porc")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oct_Monto")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oct_Porc")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nov_Monto")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nov_Porc")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dic_Monto")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dic_Porc")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridGroup1 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruEnero", 848372626)
        Dim UltraGridGroup2 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruFebrero", 848372627)
        Dim UltraGridGroup3 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruMarzo", 848372628)
        Dim UltraGridGroup4 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruAbril", 848372629)
        Dim UltraGridGroup5 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruMayo", 848372630)
        Dim UltraGridGroup6 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruJunio", 848372631)
        Dim UltraGridGroup7 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruJulio", 848372632)
        Dim UltraGridGroup8 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruAgosto", 848372633)
        Dim UltraGridGroup9 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruSetiembre", 848372634)
        Dim UltraGridGroup10 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruOctubre", 848372635)
        Dim UltraGridGroup11 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruNoviembre", 848372636)
        Dim UltraGridGroup12 As Infragistics.Win.UltraWinGrid.UltraGridGroup = New Infragistics.Win.UltraWinGrid.UltraGridGroup("gruDiciembre", 848372637)
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ene_Monto")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ene_Porc")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Feb_Monto")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Feb_Porc")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mar_Monto")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mar_Porc")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abr_Monto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abr_Porc")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("May_Monto")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("May_Porc")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jun_Monto")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jun_Porc")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jul_Monto")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jul_Porc")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ago_Monto")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ago_Porc")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sep_Monto")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sep_Porc")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Oct_Monto")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Oct_Porc")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nov_Monto")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nov_Porc")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dic_Monto")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dic_Porc")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim PaintElement2 As Infragistics.UltraChart.Resources.Appearance.PaintElement = New Infragistics.UltraChart.Resources.Appearance.PaintElement()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tipo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ene_Importe")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Feb_Importe")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mar_Importe")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abr_Importe")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("May_Importe")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jun_Importe")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jul_Importe")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ago_Importe")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sep_Importe")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Oct_Importe")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nov_Importe")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dic_Importe")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tot_Importe")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tipo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ene_Importe")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Feb_Importe")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mar_Importe")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abr_Importe")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("May_Importe")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jun_Importe")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jul_Importe")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ago_Importe")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sep_Importe")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Oct_Importe")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nov_Importe")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dic_Importe")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tot_Importe")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griClienteMensual = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.graEvolucionCliente = New ISL.Controles.Grafico(Me.components)
        Me.agrDatos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griEvolucionCliente = New ISL.Controles.Grilla(Me.components)
        Me.odEvolucionCliente = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.graProdFact = New ISL.Controles.Grafico(Me.components)
        Me.agrDatosProdFac = New ISL.Controles.Agrupacion(Me.components)
        Me.griProdFact = New ISL.Controles.Grilla(Me.components)
        Me.odProduccionFacturado = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrBusqueda = New ISL.Controles.Agrupacion(Me.components)
        Me.btnProduccion = New ISL.Controles.Boton(Me.components)
        Me.decTotalNC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalND = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTotalFac = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnPareto = New ISL.Controles.Boton(Me.components)
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficClienteMensual = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griClienteMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.graEvolucionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griEvolucionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEvolucionCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.graProdFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosProdFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosProdFac.SuspendLayout()
        CType(Me.griProdFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odProduccionFacturado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.decTotalNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTotalFac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficClienteMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficClienteMensual.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griClienteMensual)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1013, 446)
        '
        'griClienteMensual
        '
        Me.griClienteMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griClienteMensual.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griClienteMensual.Location = New System.Drawing.Point(0, 0)
        Me.griClienteMensual.Name = "griClienteMensual"
        Me.griClienteMensual.Size = New System.Drawing.Size(1013, 446)
        Me.griClienteMensual.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.graEvolucionCliente)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatos)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1013, 446)
        '
        'graEvolucionCliente
        '
        Me.graEvolucionCliente.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement1.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement1.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graEvolucionCliente.Axis.PE = PaintElement1
        Me.graEvolucionCliente.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEvolucionCliente.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graEvolucionCliente.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEvolucionCliente.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.X.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.X.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.X.Visible = True
        Me.graEvolucionCliente.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graEvolucionCliente.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graEvolucionCliente.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEvolucionCliente.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.X2.Labels.Visible = False
        Me.graEvolucionCliente.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.X2.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.X2.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.X2.Visible = False
        Me.graEvolucionCliente.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graEvolucionCliente.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graEvolucionCliente.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEvolucionCliente.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Y.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Y.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.Y.Visible = True
        Me.graEvolucionCliente.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEvolucionCliente.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graEvolucionCliente.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graEvolucionCliente.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Y2.Labels.Visible = False
        Me.graEvolucionCliente.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Y2.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Y2.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.Y2.Visible = False
        Me.graEvolucionCliente.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEvolucionCliente.Axis.Z.Labels.ItemFormatString = ""
        Me.graEvolucionCliente.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Z.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Z.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.Z.Visible = False
        Me.graEvolucionCliente.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graEvolucionCliente.Axis.Z2.Labels.ItemFormatString = ""
        Me.graEvolucionCliente.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graEvolucionCliente.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graEvolucionCliente.Axis.Z2.Labels.Visible = False
        Me.graEvolucionCliente.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graEvolucionCliente.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Z2.MajorGridLines.Visible = True
        Me.graEvolucionCliente.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graEvolucionCliente.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graEvolucionCliente.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graEvolucionCliente.Axis.Z2.MinorGridLines.Visible = False
        Me.graEvolucionCliente.Axis.Z2.Visible = False
        Me.graEvolucionCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graEvolucionCliente.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graEvolucionCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graEvolucionCliente.Location = New System.Drawing.Point(0, 286)
        Me.graEvolucionCliente.Name = "graEvolucionCliente"
        Me.graEvolucionCliente.Size = New System.Drawing.Size(1013, 160)
        Me.graEvolucionCliente.TabIndex = 1
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatos.ExpandedSize = New System.Drawing.Size(1013, 286)
        Me.agrDatos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.Location = New System.Drawing.Point(0, 0)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(1013, 286)
        Me.agrDatos.TabIndex = 0
        Me.agrDatos.Text = "Datos de Evolucion"
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griEvolucionCliente)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(2, 22)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1009, 262)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griEvolucionCliente
        '
        Me.griEvolucionCliente.DataSource = Me.odEvolucionCliente
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(253, 0)
        UltraGridColumn1.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn2.Header.Caption = "Importe (S/.)"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn2.RowLayoutColumnInfo.ParentGroupKey = "gruEnero"
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Header.Caption = "Porcentaje"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.ParentGroupIndex = 0
        UltraGridColumn3.RowLayoutColumnInfo.ParentGroupKey = "gruEnero"
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Header.Caption = "Importe (S/.)"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn4.RowLayoutColumnInfo.ParentGroupKey = "gruFebrero"
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn5.Header.Caption = "Porcentaje"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.ParentGroupIndex = 1
        UltraGridColumn5.RowLayoutColumnInfo.ParentGroupKey = "gruFebrero"
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Importe (S/.)"
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn6.RowLayoutColumnInfo.ParentGroupKey = "gruMarzo"
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Header.Caption = "Porcentaje"
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.ParentGroupIndex = 2
        UltraGridColumn7.RowLayoutColumnInfo.ParentGroupKey = "gruMarzo"
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Header.Caption = "Importe (S/.)"
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn8.RowLayoutColumnInfo.ParentGroupKey = "gruAbril"
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Header.Caption = "Porcentaje"
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.ParentGroupIndex = 3
        UltraGridColumn9.RowLayoutColumnInfo.ParentGroupKey = "gruAbril"
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn10.Header.Caption = "Importe (S/.)"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn10.RowLayoutColumnInfo.ParentGroupKey = "gruMayo"
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Header.Caption = "Porcentaje"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.ParentGroupIndex = 4
        UltraGridColumn11.RowLayoutColumnInfo.ParentGroupKey = "gruMayo"
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Header.Caption = "Importe (S/.)"
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupIndex = 5
        UltraGridColumn12.RowLayoutColumnInfo.ParentGroupKey = "gruJunio"
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Header.Caption = "Porcentaje"
        UltraGridColumn13.Header.VisiblePosition = 12
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupIndex = 5
        UltraGridColumn13.RowLayoutColumnInfo.ParentGroupKey = "gruJunio"
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Header.Caption = "Importe (S/.)"
        UltraGridColumn14.Header.VisiblePosition = 13
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupIndex = 6
        UltraGridColumn14.RowLayoutColumnInfo.ParentGroupKey = "gruJulio"
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Header.Caption = "Porcentaje"
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupIndex = 6
        UltraGridColumn15.RowLayoutColumnInfo.ParentGroupKey = "gruJulio"
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Header.Caption = "Importe (S/.)"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupIndex = 7
        UltraGridColumn16.RowLayoutColumnInfo.ParentGroupKey = "gruAgosto"
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn17.Header.Caption = "Porcentaje"
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn17.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupIndex = 7
        UltraGridColumn17.RowLayoutColumnInfo.ParentGroupKey = "gruAgosto"
        UltraGridColumn17.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn17.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn18.Header.Caption = "Importe (S/.)"
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn18.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupIndex = 8
        UltraGridColumn18.RowLayoutColumnInfo.ParentGroupKey = "gruSetiembre"
        UltraGridColumn18.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn18.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn19.Header.Caption = "Porcentaje"
        UltraGridColumn19.Header.VisiblePosition = 18
        UltraGridColumn19.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn19.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupIndex = 8
        UltraGridColumn19.RowLayoutColumnInfo.ParentGroupKey = "gruSetiembre"
        UltraGridColumn19.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn19.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn20.Header.Caption = "Importe (S/.)"
        UltraGridColumn20.Header.VisiblePosition = 19
        UltraGridColumn20.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn20.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupIndex = 9
        UltraGridColumn20.RowLayoutColumnInfo.ParentGroupKey = "gruOctubre"
        UltraGridColumn20.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn20.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn21.Header.Caption = "Porcentaje"
        UltraGridColumn21.Header.VisiblePosition = 20
        UltraGridColumn21.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn21.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupIndex = 9
        UltraGridColumn21.RowLayoutColumnInfo.ParentGroupKey = "gruOctubre"
        UltraGridColumn21.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn21.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn22.Header.Caption = "Importe (S/.)"
        UltraGridColumn22.Header.VisiblePosition = 21
        UltraGridColumn22.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn22.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupIndex = 10
        UltraGridColumn22.RowLayoutColumnInfo.ParentGroupKey = "gruNoviembre"
        UltraGridColumn22.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn22.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn23.Header.Caption = "Porcentaje"
        UltraGridColumn23.Header.VisiblePosition = 22
        UltraGridColumn23.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn23.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupIndex = 10
        UltraGridColumn23.RowLayoutColumnInfo.ParentGroupKey = "gruNoviembre"
        UltraGridColumn23.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn23.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn24.Header.Caption = "Importe (S/.)"
        UltraGridColumn24.Header.VisiblePosition = 23
        UltraGridColumn24.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn24.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupIndex = 11
        UltraGridColumn24.RowLayoutColumnInfo.ParentGroupKey = "gruDiciembre"
        UltraGridColumn24.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn24.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn25.Header.Caption = "Porcentaje"
        UltraGridColumn25.Header.VisiblePosition = 24
        UltraGridColumn25.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn25.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupIndex = 11
        UltraGridColumn25.RowLayoutColumnInfo.ParentGroupKey = "gruDiciembre"
        UltraGridColumn25.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn25.RowLayoutColumnInfo.SpanY = 2
        Appearance1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn26.CellAppearance = Appearance1
        UltraGridColumn26.Header.Caption = "Total (S/.)"
        UltraGridColumn26.Header.VisiblePosition = 25
        UltraGridColumn26.RowLayoutColumnInfo.OriginX = 50
        UltraGridColumn26.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn26.RowLayoutColumnInfo.PreferredLabelSize = New System.Drawing.Size(0, 40)
        UltraGridColumn26.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn26.RowLayoutColumnInfo.SpanY = 3
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26})
        UltraGridGroup1.Header.Caption = "Enero"
        UltraGridGroup1.Key = "gruEnero"
        UltraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup1.RowLayoutGroupInfo.OriginX = 2
        UltraGridGroup1.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup1.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup1.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup2.Header.Caption = "Febrero"
        UltraGridGroup2.Key = "gruFebrero"
        UltraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup2.RowLayoutGroupInfo.OriginX = 6
        UltraGridGroup2.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup2.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup2.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup3.Header.Caption = "Marzo"
        UltraGridGroup3.Key = "gruMarzo"
        UltraGridGroup3.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup3.RowLayoutGroupInfo.OriginX = 10
        UltraGridGroup3.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup3.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup3.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup4.Header.Caption = "Abril"
        UltraGridGroup4.Key = "gruAbril"
        UltraGridGroup4.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup4.RowLayoutGroupInfo.OriginX = 14
        UltraGridGroup4.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup4.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup4.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup5.Header.Caption = "Mayo"
        UltraGridGroup5.Key = "gruMayo"
        UltraGridGroup5.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup5.RowLayoutGroupInfo.OriginX = 18
        UltraGridGroup5.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup5.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup5.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup6.Header.Caption = "Junio"
        UltraGridGroup6.Key = "gruJunio"
        UltraGridGroup6.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup6.RowLayoutGroupInfo.OriginX = 22
        UltraGridGroup6.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup6.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup6.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup7.Header.Caption = "Julio"
        UltraGridGroup7.Key = "gruJulio"
        UltraGridGroup7.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup7.RowLayoutGroupInfo.OriginX = 26
        UltraGridGroup7.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup7.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup7.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup8.Header.Caption = "Agosto"
        UltraGridGroup8.Key = "gruAgosto"
        UltraGridGroup8.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup8.RowLayoutGroupInfo.OriginX = 30
        UltraGridGroup8.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup8.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup8.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup9.Header.Caption = "Setiembre"
        UltraGridGroup9.Key = "gruSetiembre"
        UltraGridGroup9.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup9.RowLayoutGroupInfo.OriginX = 34
        UltraGridGroup9.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup9.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup9.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup10.Header.Caption = "Octubre"
        UltraGridGroup10.Key = "gruOctubre"
        UltraGridGroup10.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup10.RowLayoutGroupInfo.OriginX = 38
        UltraGridGroup10.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup10.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup10.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup11.Header.Caption = "Noviembre"
        UltraGridGroup11.Key = "gruNoviembre"
        UltraGridGroup11.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup11.RowLayoutGroupInfo.OriginX = 42
        UltraGridGroup11.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup11.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup11.RowLayoutGroupInfo.SpanY = 3
        UltraGridGroup12.Header.Caption = "Diciembre"
        UltraGridGroup12.Key = "gruDiciembre"
        UltraGridGroup12.RowLayoutGroupInfo.LabelSpan = 1
        UltraGridGroup12.RowLayoutGroupInfo.OriginX = 46
        UltraGridGroup12.RowLayoutGroupInfo.OriginY = 0
        UltraGridGroup12.RowLayoutGroupInfo.SpanX = 4
        UltraGridGroup12.RowLayoutGroupInfo.SpanY = 3
        UltraGridBand1.Groups.AddRange(New Infragistics.Win.UltraWinGrid.UltraGridGroup() {UltraGridGroup1, UltraGridGroup2, UltraGridGroup3, UltraGridGroup4, UltraGridGroup5, UltraGridGroup6, UltraGridGroup7, UltraGridGroup8, UltraGridGroup9, UltraGridGroup10, UltraGridGroup11, UltraGridGroup12})
        UltraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        Me.griEvolucionCliente.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griEvolucionCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEvolucionCliente.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEvolucionCliente.Location = New System.Drawing.Point(0, 0)
        Me.griEvolucionCliente.Name = "griEvolucionCliente"
        Me.griEvolucionCliente.Size = New System.Drawing.Size(1009, 262)
        Me.griEvolucionCliente.TabIndex = 0
        '
        'odEvolucionCliente
        '
        UltraDataColumn2.DataType = GetType(Double)
        UltraDataColumn3.DataType = GetType(Double)
        UltraDataColumn4.DataType = GetType(Double)
        UltraDataColumn5.DataType = GetType(Double)
        UltraDataColumn6.DataType = GetType(Double)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn8.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Double)
        UltraDataColumn10.DataType = GetType(Double)
        UltraDataColumn11.DataType = GetType(Double)
        UltraDataColumn12.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Double)
        UltraDataColumn14.DataType = GetType(Double)
        UltraDataColumn15.DataType = GetType(Double)
        UltraDataColumn16.DataType = GetType(Double)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Double)
        UltraDataColumn26.DataType = GetType(Double)
        Me.odEvolucionCliente.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.graProdFact)
        Me.UltraTabPageControl3.Controls.Add(Me.agrDatosProdFac)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1013, 446)
        '
        'graProdFact
        '
        Me.graProdFact.Axis.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        PaintElement2.ElementType = Infragistics.UltraChart.[Shared].Styles.PaintElementType.None
        PaintElement2.Fill = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.graProdFact.Axis.PE = PaintElement2
        Me.graProdFact.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graProdFact.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graProdFact.Axis.X.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graProdFact.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.X.MajorGridLines.Visible = True
        Me.graProdFact.Axis.X.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.X.MinorGridLines.Visible = False
        Me.graProdFact.Axis.X.Visible = True
        Me.graProdFact.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graProdFact.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>"
        Me.graProdFact.Axis.X2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graProdFact.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.X2.Labels.Visible = False
        Me.graProdFact.Axis.X2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.X2.MajorGridLines.Visible = True
        Me.graProdFact.Axis.X2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.X2.MinorGridLines.Visible = False
        Me.graProdFact.Axis.X2.Visible = False
        Me.graProdFact.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far
        Me.graProdFact.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graProdFact.Axis.Y.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graProdFact.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Y.MajorGridLines.Visible = True
        Me.graProdFact.Axis.Y.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Y.MinorGridLines.Visible = False
        Me.graProdFact.Axis.Y.Visible = True
        Me.graProdFact.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graProdFact.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>"
        Me.graProdFact.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.VerticalLeftFacing
        Me.graProdFact.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Y2.Labels.Visible = False
        Me.graProdFact.Axis.Y2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Y2.MajorGridLines.Visible = True
        Me.graProdFact.Axis.Y2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Y2.MinorGridLines.Visible = False
        Me.graProdFact.Axis.Y2.Visible = False
        Me.graProdFact.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graProdFact.Axis.Z.Labels.ItemFormatString = ""
        Me.graProdFact.Axis.Z.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Z.MajorGridLines.Visible = True
        Me.graProdFact.Axis.Z.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Z.MinorGridLines.Visible = False
        Me.graProdFact.Axis.Z.Visible = False
        Me.graProdFact.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near
        Me.graProdFact.Axis.Z2.Labels.ItemFormatString = ""
        Me.graProdFact.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.[Shared].Styles.TextOrientation.Horizontal
        Me.graProdFact.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center
        Me.graProdFact.Axis.Z2.Labels.Visible = False
        Me.graProdFact.Axis.Z2.MajorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro
        Me.graProdFact.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Z2.MajorGridLines.Visible = True
        Me.graProdFact.Axis.Z2.MinorGridLines.AlphaLevel = CType(255, Byte)
        Me.graProdFact.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray
        Me.graProdFact.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.[Shared].Styles.LineDrawStyle.Dot
        Me.graProdFact.Axis.Z2.MinorGridLines.Visible = False
        Me.graProdFact.Axis.Z2.Visible = False
        Me.graProdFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.graProdFact.ColorModel.AlphaLevel = CType(150, Byte)
        Me.graProdFact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.graProdFact.Location = New System.Drawing.Point(0, 163)
        Me.graProdFact.Name = "graProdFact"
        Me.graProdFact.Size = New System.Drawing.Size(1013, 283)
        Me.graProdFact.TabIndex = 1
        '
        'agrDatosProdFac
        '
        Me.agrDatosProdFac.Controls.Add(Me.griProdFact)
        Me.agrDatosProdFac.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosProdFac.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosProdFac.ForeColor = System.Drawing.Color.Black
        Me.agrDatosProdFac.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosProdFac.Name = "agrDatosProdFac"
        Me.agrDatosProdFac.Size = New System.Drawing.Size(1013, 163)
        Me.agrDatosProdFac.TabIndex = 0
        Me.agrDatosProdFac.Text = "Datos de Produccion y Facturacion"
        Me.agrDatosProdFac.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griProdFact
        '
        Me.griProdFact.DataSource = Me.odProduccionFacturado
        UltraGridColumn27.Header.Caption = "Tipo \ Mes"
        UltraGridColumn27.Header.VisiblePosition = 0
        UltraGridColumn28.Header.Caption = "Enero"
        UltraGridColumn28.Header.VisiblePosition = 1
        UltraGridColumn29.Header.Caption = "Febrero"
        UltraGridColumn29.Header.VisiblePosition = 2
        UltraGridColumn30.Header.Caption = "Marzo"
        UltraGridColumn30.Header.VisiblePosition = 3
        UltraGridColumn31.Header.Caption = "Abril"
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn32.Header.Caption = "Mayo"
        UltraGridColumn32.Header.VisiblePosition = 5
        UltraGridColumn33.Header.Caption = "Junio"
        UltraGridColumn33.Header.VisiblePosition = 6
        UltraGridColumn34.Header.Caption = "Julio"
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridColumn35.Header.Caption = "Agosto"
        UltraGridColumn35.Header.VisiblePosition = 8
        UltraGridColumn36.Header.Caption = "Septiembre"
        UltraGridColumn36.Header.VisiblePosition = 9
        UltraGridColumn37.Header.Caption = "Octubre"
        UltraGridColumn37.Header.VisiblePosition = 10
        UltraGridColumn38.Header.Caption = "Noviembre"
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn39.Header.Caption = "Diciembre"
        UltraGridColumn39.Header.VisiblePosition = 12
        Appearance2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn40.CellAppearance = Appearance2
        UltraGridColumn40.Header.Caption = "Total"
        UltraGridColumn40.Header.VisiblePosition = 13
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40})
        Me.griProdFact.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griProdFact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProdFact.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProdFact.Location = New System.Drawing.Point(2, 19)
        Me.griProdFact.Name = "griProdFact"
        Me.griProdFact.Size = New System.Drawing.Size(1009, 142)
        Me.griProdFact.TabIndex = 0
        '
        'odProduccionFacturado
        '
        UltraDataColumn28.DataType = GetType(Double)
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn34.DataType = GetType(Double)
        UltraDataColumn35.DataType = GetType(Double)
        UltraDataColumn36.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Double)
        Me.odProduccionFacturado.Band.Columns.AddRange(New Object() {UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.btnProduccion)
        Me.agrBusqueda.Controls.Add(Me.decTotalNC)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta4)
        Me.agrBusqueda.Controls.Add(Me.decTotalND)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Controls.Add(Me.decTotalFac)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta2)
        Me.agrBusqueda.Controls.Add(Me.btnPareto)
        Me.agrBusqueda.Controls.Add(Me.fecPeriodo)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrBusqueda.ForeColor = System.Drawing.Color.Black
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1015, 84)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Text = "Datos de Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnProduccion
        '
        Appearance3.FontData.Name = "Tahoma"
        Me.btnProduccion.Appearance = Appearance3
        Me.btnProduccion.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnProduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduccion.ForeColor = System.Drawing.Color.Black
        Me.btnProduccion.Location = New System.Drawing.Point(203, 52)
        Me.btnProduccion.Name = "btnProduccion"
        Me.btnProduccion.Size = New System.Drawing.Size(150, 25)
        Me.btnProduccion.TabIndex = 9
        Me.btnProduccion.Text = "::: Ver Produccion :::"
        '
        'decTotalNC
        '
        Appearance4.FontData.Name = "Tahoma"
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.decTotalNC.Appearance = Appearance4
        Me.decTotalNC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalNC.ForeColor = System.Drawing.Color.Black
        Me.decTotalNC.Location = New System.Drawing.Point(748, 26)
        Me.decTotalNC.MaskInput = "{double:-9.2}"
        Me.decTotalNC.Name = "decTotalNC"
        Me.decTotalNC.NullText = "0.00"
        Me.decTotalNC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalNC.ReadOnly = True
        Me.decTotalNC.Size = New System.Drawing.Size(143, 22)
        Me.decTotalNC.TabIndex = 8
        '
        'Etiqueta4
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance5
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(647, 28)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(96, 15)
        Me.Etiqueta4.TabIndex = 7
        Me.Etiqueta4.Text = "Total Nota Crédito:"
        '
        'decTotalND
        '
        Appearance6.FontData.Name = "Tahoma"
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.decTotalND.Appearance = Appearance6
        Me.decTotalND.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalND.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalND.ForeColor = System.Drawing.Color.Black
        Me.decTotalND.Location = New System.Drawing.Point(497, 54)
        Me.decTotalND.MaskInput = "{double:-9.2}"
        Me.decTotalND.Name = "decTotalND"
        Me.decTotalND.NullText = "0.00"
        Me.decTotalND.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalND.ReadOnly = True
        Me.decTotalND.Size = New System.Drawing.Size(143, 22)
        Me.decTotalND.TabIndex = 6
        '
        'Etiqueta3
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance7
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(400, 56)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(93, 15)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Total Nota Débito:"
        '
        'decTotalFac
        '
        Appearance8.FontData.Name = "Tahoma"
        Appearance8.ForeColor = System.Drawing.Color.Black
        Me.decTotalFac.Appearance = Appearance8
        Me.decTotalFac.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTotalFac.ForeColor = System.Drawing.Color.Black
        Me.decTotalFac.Location = New System.Drawing.Point(497, 27)
        Me.decTotalFac.MaskInput = "{double:-9.2}"
        Me.decTotalFac.Name = "decTotalFac"
        Me.decTotalFac.NullText = "0.00"
        Me.decTotalFac.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTotalFac.ReadOnly = True
        Me.decTotalFac.Size = New System.Drawing.Size(143, 22)
        Me.decTotalFac.TabIndex = 4
        '
        'Etiqueta2
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance9
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(386, 29)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(106, 15)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Total Factura/Boleta:"
        '
        'btnPareto
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.FontData.Name = "Tahoma"
        Me.btnPareto.Appearance = Appearance10
        Me.btnPareto.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnPareto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPareto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPareto.ForeColor = System.Drawing.Color.Black
        Me.btnPareto.Location = New System.Drawing.Point(203, 24)
        Me.btnPareto.Name = "btnPareto"
        Me.btnPareto.Size = New System.Drawing.Size(150, 25)
        Me.btnPareto.TabIndex = 2
        Me.btnPareto.Text = "::: Ver Evolucion :::"
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(71, 26)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.ShowUpDown = True
        Me.fecPeriodo.Size = New System.Drawing.Size(126, 20)
        Me.fecPeriodo.TabIndex = 1
        '
        'Etiqueta1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance11
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(13, 27)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(53, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Mes / Año"
        '
        'ficClienteMensual
        '
        Appearance12.FontData.Name = "Tahoma"
        Me.ficClienteMensual.Appearance = Appearance12
        Me.ficClienteMensual.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficClienteMensual.Controls.Add(Me.UltraTabPageControl1)
        Me.ficClienteMensual.Controls.Add(Me.UltraTabPageControl2)
        Me.ficClienteMensual.Controls.Add(Me.UltraTabPageControl3)
        Me.ficClienteMensual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficClienteMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficClienteMensual.Location = New System.Drawing.Point(0, 84)
        Me.ficClienteMensual.Name = "ficClienteMensual"
        Me.ficClienteMensual.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficClienteMensual.Size = New System.Drawing.Size(1015, 469)
        Me.ficClienteMensual.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "PARETO"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "EVOLUCION POR CLIENTE"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "PRODUCCION Y FACTURADO"
        Me.ficClienteMensual.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficClienteMensual.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1013, 446)
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'frm_ReporteClienteMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 553)
        Me.Controls.Add(Me.ficClienteMensual)
        Me.Controls.Add(Me.agrBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ReporteClienteMensual"
        Me.Text = "Reporte Cliente Mensual"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griClienteMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.graEvolucionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griEvolucionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEvolucionCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.graProdFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosProdFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosProdFac.ResumeLayout(False)
        CType(Me.griProdFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odProduccionFacturado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.decTotalNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTotalFac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficClienteMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficClienteMensual.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrBusqueda As ISL.Controles.Agrupacion
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ficClienteMensual As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griClienteMensual As ISL.Controles.Grilla
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents btnPareto As ISL.Controles.Boton
    Friend WithEvents agrDatos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griEvolucionCliente As ISL.Controles.Grilla
    Friend WithEvents odEvolucionCliente As ISL.Controles.OrigenDatos
    Friend WithEvents graEvolucionCliente As ISL.Controles.Grafico
    Friend WithEvents decTotalFac As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalNC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decTotalND As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrDatosProdFac As ISL.Controles.Agrupacion
    Friend WithEvents graProdFact As ISL.Controles.Grafico
    Friend WithEvents griProdFact As ISL.Controles.Grilla
    Friend WithEvents odProduccionFacturado As ISL.Controles.OrigenDatos
    Friend WithEvents btnProduccion As ISL.Controles.Boton
End Class
