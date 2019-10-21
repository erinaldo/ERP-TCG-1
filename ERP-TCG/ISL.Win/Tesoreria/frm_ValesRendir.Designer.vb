<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ValesRendir
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
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRendido")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Autoriza")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAutoriza")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVale")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Referencia")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroVale")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndRendido")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Autoriza")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajadorAutoriza")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVale")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCentro")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Centro")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Referencia")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndRendido")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Autoriza")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajadorAutoriza")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVale")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCentro")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Centro")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griValesRendir = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RendirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarMailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odValesRendir = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkPorRendir = New ISL.Controles.Chequear(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.decSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboCentroL = New ISL.Controles.Combo(Me.components)
        Me.etiCentro = New ISL.Controles.Etiqueta(Me.components)
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresPorRendir = New ISL.Controles.Colores(Me.components)
        Me.ColoresRendido = New ISL.Controles.Colores(Me.components)
        Me.R = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecValeHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecValeDesde = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDetalleVale = New ISL.Controles.Grilla(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.fecVale = New System.Windows.Forms.DateTimePicker()
        Me.agrDatosBasicos = New ISL.Controles.Agrupacion(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.fecFechaIngreso = New ISL.Controles.Fecha(Me.components)
        Me.chkDisponible = New ISL.Controles.Chequear(Me.components)
        Me.txtCargo = New ISL.Controles.Texto(Me.components)
        Me.etiFechaIngreso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCargo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.etiArea = New ISL.Controles.Etiqueta(Me.components)
        Me.FotoTrabajador = New System.Windows.Forms.PictureBox()
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.txtVoucher = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboAutorizaVale = New ISL.Controles.Combo(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ficValesRendir = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griValesRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odValesRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.chkPorRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.ColoresPorRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresRendido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.griDetalleVale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAutorizaVale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficValesRendir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficValesRendir.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1248, 378)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Agrupacion1)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1248, 378)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.Tag = ""
        Me.UltraGroupBox1.Text = "Busqueda"
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griValesRendir)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(3, 17)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1242, 358)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griValesRendir
        '
        Me.griValesRendir.ContextMenuStrip = Me.MenuContextual1
        Me.griValesRendir.DataSource = Me.odValesRendir
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn58.Header.VisiblePosition = 1
        UltraGridColumn39.Header.VisiblePosition = 0
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 19
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 4
        UltraGridColumn42.Width = 263
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn44.Format = "#,###,###,##0.00"
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn44.Header.Appearance = Appearance1
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn44.Width = 76
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.Width = 224
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn47.Header.VisiblePosition = 2
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn47.Width = 95
        UltraGridColumn48.Header.VisiblePosition = 11
        UltraGridColumn48.Width = 227
        UltraGridColumn49.Header.VisiblePosition = 12
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 13
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 15
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 16
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 17
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 18
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn56.CellAppearance = Appearance2
        UltraGridColumn56.Header.VisiblePosition = 6
        UltraGridColumn56.Hidden = True
        UltraGridColumn56.MaskInput = ""
        UltraGridColumn56.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn57.CellAppearance = Appearance3
        UltraGridColumn57.Format = "#,###,###,##0.00"
        UltraGridColumn57.Header.Caption = "Monto"
        UltraGridColumn57.Header.VisiblePosition = 7
        UltraGridColumn57.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn57.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn58, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57})
        Me.griValesRendir.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griValesRendir.DisplayLayout.MaxColScrollRegions = 1
        Me.griValesRendir.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griValesRendir.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griValesRendir.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griValesRendir.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griValesRendir.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griValesRendir.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griValesRendir.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griValesRendir.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griValesRendir.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griValesRendir.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griValesRendir.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griValesRendir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griValesRendir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griValesRendir.Location = New System.Drawing.Point(2, 73)
        Me.griValesRendir.Name = "griValesRendir"
        Me.griValesRendir.Size = New System.Drawing.Size(1238, 283)
        Me.griValesRendir.TabIndex = 1
        Me.griValesRendir.Tag = ""
        Me.griValesRendir.Text = "Vales"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.RendirToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.EnviarMailToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(130, 92)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Marca"
        '
        'RendirToolStripMenuItem
        '
        Me.RendirToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.RendirToolStripMenuItem.Name = "RendirToolStripMenuItem"
        Me.RendirToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.RendirToolStripMenuItem.Text = "Rendir Vale"
        Me.RendirToolStripMenuItem.ToolTipText = "Rendir Vale"
        Me.RendirToolStripMenuItem.Visible = False
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EnviarMailToolStripMenuItem
        '
        Me.EnviarMailToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.accounting_mail
        Me.EnviarMailToolStripMenuItem.Name = "EnviarMailToolStripMenuItem"
        Me.EnviarMailToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.EnviarMailToolStripMenuItem.Text = "Enviar Mail"
        '
        'odValesRendir
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn9.DataType = GetType(Boolean)
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        Me.odValesRendir.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.chkPorRendir)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion3.Controls.Add(Me.decSaldo)
        Me.Agrupacion3.Controls.Add(Me.cboCentroL)
        Me.Agrupacion3.Controls.Add(Me.etiCentro)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Controls.Add(Me.Label2)
        Me.Agrupacion3.Controls.Add(Me.Label1)
        Me.Agrupacion3.Controls.Add(Me.fecValeHasta)
        Me.Agrupacion3.Controls.Add(Me.fecValeDesde)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(2, 2)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1238, 71)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkPorRendir
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.chkPorRendir.Appearance = Appearance4
        Me.chkPorRendir.AutoSize = True
        Me.chkPorRendir.BackColor = System.Drawing.Color.Transparent
        Me.chkPorRendir.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkPorRendir.Checked = True
        Me.chkPorRendir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPorRendir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPorRendir.ForeColor = System.Drawing.Color.Black
        Me.chkPorRendir.Location = New System.Drawing.Point(337, 37)
        Me.chkPorRendir.Name = "chkPorRendir"
        Me.chkPorRendir.Size = New System.Drawing.Size(71, 17)
        Me.chkPorRendir.TabIndex = 8
        Me.chkPorRendir.TabStop = False
        Me.chkPorRendir.Text = "PorRendir"
        '
        'Etiqueta6
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance5
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(195, 40)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta6.TabIndex = 6
        Me.Etiqueta6.Text = "Saldo:"
        '
        'decSaldo
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Appearance = Appearance6
        Me.decSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decSaldo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.decSaldo.Location = New System.Drawing.Point(235, 35)
        Me.decSaldo.Name = "decSaldo"
        Me.decSaldo.NullText = "0.00"
        Me.decSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decSaldo.ReadOnly = True
        Me.decSaldo.Size = New System.Drawing.Size(84, 21)
        Me.decSaldo.TabIndex = 7
        '
        'cboCentroL
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Appearance = Appearance7
        Me.cboCentroL.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCentroL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCentroL.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCentroL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCentroL.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCentroL.Location = New System.Drawing.Point(235, 10)
        Me.cboCentroL.Name = "cboCentroL"
        Me.cboCentroL.Size = New System.Drawing.Size(144, 21)
        Me.cboCentroL.TabIndex = 5
        Me.cboCentroL.ValueMember = "Id"
        '
        'etiCentro
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.etiCentro.Appearance = Appearance8
        Me.etiCentro.AutoSize = True
        Me.etiCentro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCentro.ForeColor = System.Drawing.Color.Black
        Me.etiCentro.Location = New System.Drawing.Point(190, 14)
        Me.etiCentro.Name = "etiCentro"
        Me.etiCentro.Size = New System.Drawing.Size(40, 14)
        Me.etiCentro.TabIndex = 4
        Me.etiCentro.Text = "Centro:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.ColoresPorRendir)
        Me.Agrupacion5.Controls.Add(Me.ColoresRendido)
        Me.Agrupacion5.Controls.Add(Me.R)
        Me.Agrupacion5.Controls.Add(Me.etiGenerada)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion5.Location = New System.Drawing.Point(486, 8)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(237, 54)
        Me.Agrupacion5.TabIndex = 9
        Me.Agrupacion5.Text = "Estado Vale"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresPorRendir
        '
        Me.ColoresPorRendir.Color = System.Drawing.Color.White
        Me.ColoresPorRendir.Location = New System.Drawing.Point(68, 25)
        Me.ColoresPorRendir.Name = "ColoresPorRendir"
        Me.ColoresPorRendir.Size = New System.Drawing.Size(46, 21)
        Me.ColoresPorRendir.TabIndex = 1
        Me.ColoresPorRendir.Text = "White"
        '
        'ColoresRendido
        '
        Me.ColoresRendido.Color = System.Drawing.Color.YellowGreen
        Me.ColoresRendido.Location = New System.Drawing.Point(181, 25)
        Me.ColoresRendido.Name = "ColoresRendido"
        Me.ColoresRendido.Size = New System.Drawing.Size(43, 21)
        Me.ColoresRendido.TabIndex = 3
        Me.ColoresRendido.Text = "YellowGreen"
        '
        'R
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.R.Appearance = Appearance9
        Me.R.AutoSize = True
        Me.R.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R.ForeColor = System.Drawing.Color.Black
        Me.R.Location = New System.Drawing.Point(132, 27)
        Me.R.Name = "R"
        Me.R.Size = New System.Drawing.Size(43, 15)
        Me.R.TabIndex = 2
        Me.R.Text = "Rendido"
        '
        'etiGenerada
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance10
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 27)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(55, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Por Rendir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(22, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'fecValeHasta
        '
        Me.fecValeHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecValeHasta.Location = New System.Drawing.Point(65, 40)
        Me.fecValeHasta.Name = "fecValeHasta"
        Me.fecValeHasta.Size = New System.Drawing.Size(103, 20)
        Me.fecValeHasta.TabIndex = 3
        '
        'fecValeDesde
        '
        Me.fecValeDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecValeDesde.Location = New System.Drawing.Point(65, 11)
        Me.fecValeDesde.Name = "fecValeDesde"
        Me.fecValeDesde.Size = New System.Drawing.Size(103, 20)
        Me.fecValeDesde.TabIndex = 1
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.griDetalleVale)
        Me.UltraTabPageControl9.Controls.Add(Me.agrProcesoNegocio)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1248, 378)
        '
        'griDetalleVale
        '
        Me.griDetalleVale.ContextMenuStrip = Me.MenuContextual1
        Me.griDetalleVale.DataSource = Me.odValesRendir
        UltraGridColumn59.Header.VisiblePosition = 19
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.Header.VisiblePosition = 18
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 263
        UltraGridColumn5.Header.VisiblePosition = 4
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn6.Header.Appearance = Appearance11
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn6.Width = 76
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.Width = 224
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn9.Width = 95
        UltraGridColumn10.Header.VisiblePosition = 10
        UltraGridColumn10.Width = 227
        UltraGridColumn11.Header.VisiblePosition = 11
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 17
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance12
        UltraGridColumn18.Header.VisiblePosition = 5
        UltraGridColumn18.MaskInput = ""
        UltraGridColumn18.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance13
        UltraGridColumn19.Header.VisiblePosition = 6
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn59, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19})
        Me.griDetalleVale.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griDetalleVale.DisplayLayout.MaxColScrollRegions = 1
        Me.griDetalleVale.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griDetalleVale.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDetalleVale.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDetalleVale.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDetalleVale.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDetalleVale.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDetalleVale.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDetalleVale.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDetalleVale.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDetalleVale.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griDetalleVale.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDetalleVale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDetalleVale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDetalleVale.Location = New System.Drawing.Point(0, 273)
        Me.griDetalleVale.Name = "griDetalleVale"
        Me.griDetalleVale.Size = New System.Drawing.Size(1248, 105)
        Me.griDetalleVale.TabIndex = 11
        Me.griDetalleVale.Tag = ""
        Me.griDetalleVale.Text = "Vales"
        Me.griDetalleVale.Visible = False
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.fecVale)
        Me.agrProcesoNegocio.Controls.Add(Me.ugb_Espera)
        Me.agrProcesoNegocio.Controls.Add(Me.agrDatosBasicos)
        Me.agrProcesoNegocio.Controls.Add(Me.FotoTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta5)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Controls.Add(Me.txtVoucher)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta4)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboAutorizaVale)
        Me.agrProcesoNegocio.Controls.Add(Me.txtGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.txtImporte)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1248, 273)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecVale
        '
        Me.fecVale.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecVale.Location = New System.Drawing.Point(90, 187)
        Me.fecVale.Name = "fecVale"
        Me.fecVale.Size = New System.Drawing.Size(100, 21)
        Me.fecVale.TabIndex = 9
        '
        'agrDatosBasicos
        '
        Me.agrDatosBasicos.Controls.Add(Me.verActivo)
        Me.agrDatosBasicos.Controls.Add(Me.fecFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.chkDisponible)
        Me.agrDatosBasicos.Controls.Add(Me.txtCargo)
        Me.agrDatosBasicos.Controls.Add(Me.etiFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.etiCargo)
        Me.agrDatosBasicos.Controls.Add(Me.txtArea)
        Me.agrDatosBasicos.Controls.Add(Me.etiArea)
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.Location = New System.Drawing.Point(677, 32)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(280, 141)
        Me.agrDatosBasicos.TabIndex = 12
        Me.agrDatosBasicos.Text = "Datos Básicos del Trabajador"
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'verActivo
        '
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.verActivo.Appearance = Appearance14
        Me.verActivo.AutoSize = True
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(110, 106)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 7
        Me.verActivo.TabStop = False
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'fecFechaIngreso
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Appearance = Appearance15
        Me.fecFechaIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Location = New System.Drawing.Point(109, 81)
        Me.fecFechaIngreso.Name = "fecFechaIngreso"
        Me.fecFechaIngreso.ReadOnly = True
        Me.fecFechaIngreso.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaIngreso.TabIndex = 5
        Me.fecFechaIngreso.TabStop = False
        '
        'chkDisponible
        '
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.chkDisponible.Appearance = Appearance16
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.BackColor = System.Drawing.Color.Transparent
        Me.chkDisponible.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisponible.ForeColor = System.Drawing.Color.Black
        Me.chkDisponible.Location = New System.Drawing.Point(7, 106)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(73, 17)
        Me.chkDisponible.TabIndex = 6
        Me.chkDisponible.TabStop = False
        Me.chkDisponible.Text = "Disponible"
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(45, 52)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(222, 21)
        Me.txtCargo.TabIndex = 3
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiFechaIngreso
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaIngreso.Appearance = Appearance17
        Me.etiFechaIngreso.AutoSize = True
        Me.etiFechaIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.etiFechaIngreso.Location = New System.Drawing.Point(7, 83)
        Me.etiFechaIngreso.Name = "etiFechaIngreso"
        Me.etiFechaIngreso.Size = New System.Drawing.Size(98, 15)
        Me.etiFechaIngreso.TabIndex = 4
        Me.etiFechaIngreso.Text = "Fecha de Ingreso :"
        '
        'etiCargo
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.etiCargo.Appearance = Appearance18
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(7, 56)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(41, 15)
        Me.etiCargo.TabIndex = 2
        Me.etiCargo.Text = "Cargo :"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(45, 25)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(222, 21)
        Me.txtArea.TabIndex = 1
        Me.txtArea.TabStop = False
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Appearance19.BackColor = System.Drawing.Color.Transparent
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.etiArea.Appearance = Appearance19
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(7, 29)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(34, 15)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area :"
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(481, 32)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(180, 219)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 251
        Me.FotoTrabajador.TabStop = False
        Me.FotoTrabajador.Visible = False
        '
        'Etiqueta5
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance20
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(22, 34)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(63, 15)
        Me.Etiqueta5.TabIndex = 0
        Me.Etiqueta5.Text = "Trabajador:"
        '
        'cboTrabajadores
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance21
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(90, 32)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 22)
        Me.cboTrabajadores.TabIndex = 1
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'txtVoucher
        '
        Me.txtVoucher.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVoucher.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVoucher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucher.Location = New System.Drawing.Point(90, 159)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.ReadOnly = True
        Me.txtVoucher.Size = New System.Drawing.Size(100, 22)
        Me.txtVoucher.TabIndex = 7
        Me.txtVoucher.TabStop = False
        '
        'Etiqueta4
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance22
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(29, 161)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Nro. Vale:"
        '
        'etiTrabajador
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance23
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(35, 215)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(49, 15)
        Me.etiTrabajador.TabIndex = 10
        Me.etiTrabajador.Text = "Autoriza:"
        '
        'cboAutorizaVale
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboAutorizaVale.Appearance = Appearance24
        Me.cboAutorizaVale.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAutorizaVale.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAutorizaVale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAutorizaVale.ForeColor = System.Drawing.Color.Black
        Me.cboAutorizaVale.Location = New System.Drawing.Point(90, 213)
        Me.cboAutorizaVale.Name = "cboAutorizaVale"
        Me.cboAutorizaVale.Size = New System.Drawing.Size(352, 22)
        Me.cboAutorizaVale.TabIndex = 11
        Me.cboAutorizaVale.ValueMember = "Id"
        '
        'txtGlosa
        '
        Appearance25.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Appearance = Appearance25
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(90, 94)
        Me.txtGlosa.MaxLength = 3000
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(352, 60)
        Me.txtGlosa.TabIndex = 5
        '
        'Etiqueta3
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance26
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(44, 188)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta3.TabIndex = 8
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Etiqueta2
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance27
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(46, 96)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta1
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance28
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(38, 65)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Importe:"
        '
        'txtImporte
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Appearance = Appearance29
        Me.txtImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtImporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Location = New System.Drawing.Point(90, 63)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullText = "0.00"
        Me.txtImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtImporte.Size = New System.Drawing.Size(86, 22)
        Me.txtImporte.TabIndex = 3
        '
        'ficValesRendir
        '
        Me.ficValesRendir.Controls.Add(Me.UltraTabSharedControlsPage5)
        Me.ficValesRendir.Controls.Add(Me.UltraTabPageControl3)
        Me.ficValesRendir.Controls.Add(Me.UltraTabPageControl9)
        Me.ficValesRendir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficValesRendir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficValesRendir.Location = New System.Drawing.Point(0, 0)
        Me.ficValesRendir.Name = "ficValesRendir"
        Me.ficValesRendir.SharedControlsPage = Me.UltraTabSharedControlsPage5
        Me.ficValesRendir.Size = New System.Drawing.Size(1250, 401)
        Me.ficValesRendir.TabIndex = 0
        UltraTab9.TabPage = Me.UltraTabPageControl3
        UltraTab9.Text = "Lista"
        UltraTab8.TabPage = Me.UltraTabPageControl9
        UltraTab8.Text = "Mantenimiento"
        Me.ficValesRendir.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab9, UltraTab8})
        Me.ficValesRendir.TabStop = False
        Me.ficValesRendir.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1248, 378)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(707, 183)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 11
        Me.ugb_Espera.Visible = False
        '
        'frm_ValesRendir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 401)
        Me.Controls.Add(Me.ficValesRendir)
        Me.Name = "frm_ValesRendir"
        Me.Text = "Vales Por Rendir"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griValesRendir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odValesRendir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.chkPorRendir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCentroL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.ColoresPorRendir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresRendido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.griDetalleVale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBasicos.ResumeLayout(False)
        Me.agrDatosBasicos.PerformLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAutorizaVale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficValesRendir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficValesRendir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficValesRendir As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griValesRendir As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecValeHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecValeDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents txtVoucher As ISL.Controles.Texto
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboAutorizaVale As ISL.Controles.Combo
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents agrDatosBasicos As ISL.Controles.Agrupacion
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents fecFechaIngreso As ISL.Controles.Fecha
    Friend WithEvents chkDisponible As ISL.Controles.Chequear
    Friend WithEvents txtCargo As ISL.Controles.Texto
    Friend WithEvents etiFechaIngreso As ISL.Controles.Etiqueta
    Friend WithEvents etiCargo As ISL.Controles.Etiqueta
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents etiArea As ISL.Controles.Etiqueta
    Friend WithEvents FotoTrabajador As System.Windows.Forms.PictureBox
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RendirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odValesRendir As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresPorRendir As ISL.Controles.Colores
    Friend WithEvents ColoresRendido As ISL.Controles.Colores
    Friend WithEvents R As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents cboCentroL As ISL.Controles.Combo
    Friend WithEvents etiCentro As ISL.Controles.Etiqueta
    Friend WithEvents decSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents fecVale As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkPorRendir As ISL.Controles.Chequear
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarMailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griDetalleVale As ISL.Controles.Grilla
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
