<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_OrdenCompraConsignacion
    Inherits Win.frm_MenuPadre

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOrden")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Almacen")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Validado")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrden")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoMaterial")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterial")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrecioUnitario")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorVenta")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorIgv")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Atender")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaOrden")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrdenCompraConsignacion))
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Atender")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaOrden")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim SummarySettings1 As Infragistics.Win.UltraWinGrid.SummarySettings = New Infragistics.Win.UltraWinGrid.SummarySettings("", Infragistics.Win.UltraWinGrid.SummaryType.Sum, Nothing, "Importe", 16, True, "Band 0", 0, Infragistics.Win.UltraWinGrid.SummaryPosition.UseSummaryPositionColumn, "Importe", 16, True)
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrden")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOrden")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterial")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnitario")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorVenta")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorIgv")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Validado")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.MenuContextual = New ISL.Controles.MenuContextual(Me.components)
        Me.GenerarStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.odDetalleOrdenSalida = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.agrFiltro = New ISL.Controles.Agrupacion(Me.components)
        Me.rfOrdenCompraConsignacionHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfOrdenCompraConsignacionDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAlmacen = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboCentro = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.agrOrdenesdeIngreso = New ISL.Controles.Agrupacion(Me.components)
        Me.griDetalleOrdenSalida = New ISL.Controles.Grilla(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.cmdGenerarOrdenCompra = New ISL.Controles.Boton(Me.components)
        Me.MenuContextual.SuspendLayout()
        CType(Me.odDetalleOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFiltro.SuspendLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrOrdenesdeIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOrdenesdeIngreso.SuspendLayout()
        CType(Me.griDetalleOrdenSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuContextual
        '
        Me.MenuContextual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarStripMenuItem1})
        Me.MenuContextual.Name = "MenuContextual1"
        Me.MenuContextual.Size = New System.Drawing.Size(132, 26)
        '
        'GenerarStripMenuItem1
        '
        Me.GenerarStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.GenerarStripMenuItem1.Name = "GenerarStripMenuItem1"
        Me.GenerarStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.GenerarStripMenuItem1.Text = "Generar OC"
        Me.GenerarStripMenuItem1.ToolTipText = "Generar Orden de Compra"
        '
        'odDetalleOrdenSalida
        '
        UltraDataColumn17.DataType = GetType(Boolean)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        Me.odDetalleOrdenSalida.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn32.DataType = GetType(Boolean)
        UltraDataColumn32.DefaultValue = False
        Me.odDetalleOrdenSalida.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
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
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(699, 290)
        '
        'agrFiltro
        '
        Me.agrFiltro.Controls.Add(Me.rfOrdenCompraConsignacionHasta)
        Me.agrFiltro.Controls.Add(Me.rfOrdenCompraConsignacionDesde)
        Me.agrFiltro.Controls.Add(Me.Etiqueta21)
        Me.agrFiltro.Controls.Add(Me.Etiqueta2)
        Me.agrFiltro.Controls.Add(Me.cboAlmacen)
        Me.agrFiltro.Controls.Add(Me.cboCentro)
        Me.agrFiltro.Controls.Add(Me.Etiqueta3)
        Me.agrFiltro.Controls.Add(Me.Etiqueta9)
        Me.agrFiltro.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrFiltro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFiltro.ForeColor = System.Drawing.Color.Black
        Me.agrFiltro.Location = New System.Drawing.Point(0, 0)
        Me.agrFiltro.Name = "agrFiltro"
        Me.agrFiltro.Size = New System.Drawing.Size(1240, 53)
        Me.agrFiltro.TabIndex = 2
        Me.agrFiltro.Text = "Filtros:"
        Me.agrFiltro.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfOrdenCompraConsignacionHasta
        '
        Me.rfOrdenCompraConsignacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenCompraConsignacionHasta.Location = New System.Drawing.Point(198, 25)
        Me.rfOrdenCompraConsignacionHasta.Name = "rfOrdenCompraConsignacionHasta"
        Me.rfOrdenCompraConsignacionHasta.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenCompraConsignacionHasta.TabIndex = 3
        '
        'rfOrdenCompraConsignacionDesde
        '
        Me.rfOrdenCompraConsignacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfOrdenCompraConsignacionDesde.Location = New System.Drawing.Point(55, 25)
        Me.rfOrdenCompraConsignacionDesde.Name = "rfOrdenCompraConsignacionDesde"
        Me.rfOrdenCompraConsignacionDesde.Size = New System.Drawing.Size(98, 21)
        Me.rfOrdenCompraConsignacionDesde.TabIndex = 1
        '
        'Etiqueta21
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance1
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(159, 28)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta2
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance2
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(11, 27)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Desde:"
        '
        'cboAlmacen
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Appearance = Appearance3
        Me.cboAlmacen.DisplayMember = "Nombre"
        Me.cboAlmacen.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAlmacen.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAlmacen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAlmacen.ForeColor = System.Drawing.Color.Black
        Me.cboAlmacen.Location = New System.Drawing.Point(536, 23)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(240, 22)
        Me.cboAlmacen.TabIndex = 7
        Me.cboAlmacen.ValueMember = "Id"
        '
        'cboCentro
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Appearance = Appearance4
        Me.cboCentro.DisplayMember = "Nombre"
        Me.cboCentro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentro.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentro.ForeColor = System.Drawing.Color.Black
        Me.cboCentro.Location = New System.Drawing.Point(347, 23)
        Me.cboCentro.Name = "cboCentro"
        Me.cboCentro.Size = New System.Drawing.Size(126, 22)
        Me.cboCentro.TabIndex = 5
        Me.cboCentro.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance5
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(302, 27)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta3.TabIndex = 4
        Me.Etiqueta3.Text = "Centro:"
        '
        'Etiqueta9
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance6
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(479, 28)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta9.TabIndex = 6
        Me.Etiqueta9.Text = "Almacen:"
        '
        'agrOrdenesdeIngreso
        '
        Me.agrOrdenesdeIngreso.Controls.Add(Me.griDetalleOrdenSalida)
        Me.agrOrdenesdeIngreso.Controls.Add(Me.agrMenuLista)
        Me.agrOrdenesdeIngreso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOrdenesdeIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOrdenesdeIngreso.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrOrdenesdeIngreso.Location = New System.Drawing.Point(0, 53)
        Me.agrOrdenesdeIngreso.Name = "agrOrdenesdeIngreso"
        Me.agrOrdenesdeIngreso.Size = New System.Drawing.Size(1240, 398)
        Me.agrOrdenesdeIngreso.TabIndex = 3
        Me.agrOrdenesdeIngreso.Text = "Ordenes De Salida según Consumo"
        Me.agrOrdenesdeIngreso.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDetalleOrdenSalida
        '
        Me.griDetalleOrdenSalida.ContextMenuStrip = Me.MenuContextual
        Me.griDetalleOrdenSalida.DataSource = Me.odDetalleOrdenSalida
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griDetalleOrdenSalida.DisplayLayout.Appearance = Appearance7
        Appearance8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn37.CellAppearance = Appearance8
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.Hidden = True
        Appearance9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn38.CellAppearance = Appearance9
        UltraGridColumn38.Header.VisiblePosition = 8
        UltraGridColumn38.Hidden = True
        Appearance10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn39.CellAppearance = Appearance10
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Hidden = True
        Appearance11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn40.CellAppearance = Appearance11
        UltraGridColumn40.Header.Caption = "Codigo // N° Orden"
        UltraGridColumn40.Header.VisiblePosition = 0
        UltraGridColumn40.Width = 121
        Appearance12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn41.CellAppearance = Appearance12
        UltraGridColumn41.Header.Caption = "Material // Almacen"
        UltraGridColumn41.Header.VisiblePosition = 2
        UltraGridColumn41.Width = 341
        Appearance13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn42.CellAppearance = Appearance13
        UltraGridColumn42.Header.Caption = "Cant."
        UltraGridColumn42.Header.VisiblePosition = 3
        UltraGridColumn42.Width = 97
        Appearance14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn43.CellAppearance = Appearance14
        UltraGridColumn43.Header.Caption = "Precio Unit."
        UltraGridColumn43.Header.VisiblePosition = 4
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn44.CellAppearance = Appearance15
        UltraGridColumn44.Header.Caption = "Valor Venta"
        UltraGridColumn44.Header.VisiblePosition = 5
        Appearance16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn45.CellAppearance = Appearance16
        UltraGridColumn45.Header.VisiblePosition = 10
        UltraGridColumn45.Hidden = True
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn46.CellAppearance = Appearance17
        UltraGridColumn46.Header.VisiblePosition = 11
        UltraGridColumn46.Hidden = True
        Appearance18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn47.CellAppearance = Appearance18
        UltraGridColumn47.Header.VisiblePosition = 12
        UltraGridColumn47.Hidden = True
        Appearance19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn48.CellAppearance = Appearance19
        UltraGridColumn48.Header.VisiblePosition = 13
        UltraGridColumn48.Hidden = True
        Appearance20.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn49.CellAppearance = Appearance20
        UltraGridColumn49.Header.VisiblePosition = 14
        UltraGridColumn49.Hidden = True
        Appearance21.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn50.CellAppearance = Appearance21
        UltraGridColumn50.Header.VisiblePosition = 15
        UltraGridColumn50.Hidden = True
        Appearance22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn51.CellAppearance = Appearance22
        UltraGridColumn51.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn51.Header.CheckBoxAlignment = Infragistics.Win.UltraWinGrid.HeaderCheckBoxAlignment.Right
        UltraGridColumn51.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn51.Header.VisiblePosition = 6
        UltraGridColumn51.Width = 46
        Appearance23.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn52.CellAppearance = Appearance23
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn52.Header.Appearance = Appearance24
        UltraGridColumn52.Header.VisiblePosition = 16
        UltraGridColumn52.MaskInput = "{double:-9.4}"
        UltraGridColumn52.Width = 107
        Appearance25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn53.CellAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn53.Header.Appearance = Appearance26
        UltraGridColumn53.Header.VisiblePosition = 17
        UltraGridColumn53.MaskInput = "{double:-9.4}"
        UltraGridColumn53.Width = 113
        UltraGridColumn54.Header.VisiblePosition = 1
        UltraGridColumn54.Width = 102
        UltraGridColumn55.Header.VisiblePosition = 18
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55})
        UltraGridBand1.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand1.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        UltraGridBand1.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance27.TextHAlignAsString = "Right"
        SummarySettings1.Appearance = Appearance27
        SummarySettings1.DisplayFormat = "{0}"
        SummarySettings1.GroupBySummaryValueAppearance = Appearance28
        SummarySettings1.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.Top
        UltraGridBand1.Summaries.AddRange(New Infragistics.Win.UltraWinGrid.SummarySettings() {SummarySettings1})
        UltraGridBand1.SummaryFooterCaption = ""
        UltraGridBand2.ColHeadersVisible = False
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.Width = 166
        UltraGridColumn58.Header.VisiblePosition = 2
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.Caption = "N° Orden"
        UltraGridColumn59.Header.VisiblePosition = 3
        UltraGridColumn59.Width = 102
        UltraGridColumn60.Header.VisiblePosition = 4
        UltraGridColumn60.Width = 102
        UltraGridColumn61.Header.VisiblePosition = 5
        UltraGridColumn61.Width = 341
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn63.Header.VisiblePosition = 7
        UltraGridColumn63.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn63.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn64.Header.VisiblePosition = 8
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.Header.VisiblePosition = 10
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 11
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.Header.VisiblePosition = 12
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 13
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 14
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn70.Header.VisiblePosition = 9
        UltraGridColumn70.Width = 97
        UltraGridColumn71.Header.VisiblePosition = 15
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 16
        UltraGridColumn72.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72})
        Me.griDetalleOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDetalleOrdenSalida.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griDetalleOrdenSalida.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrdenSalida.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance29.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance29.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance29.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenSalida.DisplayLayout.GroupByBox.Appearance = Appearance29
        Appearance30.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrdenSalida.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance30
        Me.griDetalleOrdenSalida.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrdenSalida.DisplayLayout.GroupByBox.Hidden = True
        Appearance31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance31.BackColor2 = System.Drawing.SystemColors.Control
        Appearance31.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance31.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griDetalleOrdenSalida.DisplayLayout.GroupByBox.PromptAppearance = Appearance31
        Me.griDetalleOrdenSalida.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleOrdenSalida.DisplayLayout.MaxRowScrollRegions = 1
        Appearance32.BackColor = System.Drawing.SystemColors.Window
        Appearance32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griDetalleOrdenSalida.DisplayLayout.Override.ActiveCellAppearance = Appearance32
        Appearance33.BackColor = System.Drawing.SystemColors.Highlight
        Appearance33.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griDetalleOrdenSalida.DisplayLayout.Override.ActiveRowAppearance = Appearance33
        Me.griDetalleOrdenSalida.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDetalleOrdenSalida.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenSalida.DisplayLayout.Override.CardAreaAppearance = Appearance34
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Appearance35.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griDetalleOrdenSalida.DisplayLayout.Override.CellAppearance = Appearance35
        Me.griDetalleOrdenSalida.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griDetalleOrdenSalida.DisplayLayout.Override.CellPadding = 0
        Me.griDetalleOrdenSalida.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance36.BackColor = System.Drawing.SystemColors.Control
        Appearance36.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance36.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance36.BorderColor = System.Drawing.SystemColors.Window
        Me.griDetalleOrdenSalida.DisplayLayout.Override.GroupByRowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Center"
        Me.griDetalleOrdenSalida.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.griDetalleOrdenSalida.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleOrdenSalida.DisplayLayout.Override.HeaderPlacement = Infragistics.Win.UltraWinGrid.HeaderPlacement.FixedOnTop
        Appearance38.BackColor = System.Drawing.SystemColors.Window
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.griDetalleOrdenSalida.DisplayLayout.Override.RowAppearance = Appearance38
        Me.griDetalleOrdenSalida.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griDetalleOrdenSalida.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.None
        Appearance39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griDetalleOrdenSalida.DisplayLayout.Override.TemplateAddRowAppearance = Appearance39
        Me.griDetalleOrdenSalida.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDetalleOrdenSalida.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleOrdenSalida.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griDetalleOrdenSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleOrdenSalida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleOrdenSalida.Location = New System.Drawing.Point(3, 47)
        Me.griDetalleOrdenSalida.Name = "griDetalleOrdenSalida"
        Me.griDetalleOrdenSalida.Size = New System.Drawing.Size(1234, 348)
        Me.griDetalleOrdenSalida.TabIndex = 1
        Me.griDetalleOrdenSalida.Text = "Grilla2"
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.cmdGenerarOrdenCompra)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 17)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1234, 30)
        Me.agrMenuLista.TabIndex = 0
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmdGenerarOrdenCompra
        '
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance40.Image = CType(resources.GetObject("Appearance40.Image"), Object)
        Me.cmdGenerarOrdenCompra.Appearance = Appearance40
        Me.cmdGenerarOrdenCompra.BackColorInternal = System.Drawing.Color.Transparent
        Me.cmdGenerarOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGenerarOrdenCompra.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdGenerarOrdenCompra.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerarOrdenCompra.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerarOrdenCompra.Location = New System.Drawing.Point(3, 3)
        Me.cmdGenerarOrdenCompra.Name = "cmdGenerarOrdenCompra"
        Me.cmdGenerarOrdenCompra.Size = New System.Drawing.Size(95, 24)
        Me.cmdGenerarOrdenCompra.TabIndex = 0
        Me.cmdGenerarOrdenCompra.Text = "Generar OC"
        Me.cmdGenerarOrdenCompra.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'frm_OrdenCompraConsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1240, 451)
        Me.Controls.Add(Me.agrOrdenesdeIngreso)
        Me.Controls.Add(Me.agrFiltro)
        Me.Name = "frm_OrdenCompraConsignacion"
        Me.Text = "Orden de Compra por Consignación"
        Me.MenuContextual.ResumeLayout(False)
        CType(Me.odDetalleOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFiltro.ResumeLayout(False)
        Me.agrFiltro.PerformLayout()
        CType(Me.cboAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrOrdenesdeIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOrdenesdeIngreso.ResumeLayout(False)
        CType(Me.griDetalleOrdenSalida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents MenuContextual As ISL.Controles.MenuContextual
    Friend WithEvents GenerarStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents odDetalleOrdenSalida As ISL.Controles.OrigenDatos
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents agrFiltro As ISL.Controles.Agrupacion
    Friend WithEvents rfOrdenCompraConsignacionHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfOrdenCompraConsignacionDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboAlmacen As ISL.Controles.ComboMaestros
    Friend WithEvents cboCentro As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents agrOrdenesdeIngreso As ISL.Controles.Agrupacion
    Friend WithEvents griDetalleOrdenSalida As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents cmdGenerarOrdenCompra As ISL.Controles.Boton

End Class
