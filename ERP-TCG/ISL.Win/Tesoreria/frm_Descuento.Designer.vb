<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Descuento
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
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAdministrativo")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeId")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoViaje")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Importe")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioAutoriza")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCaja")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorrienteOrigen")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaCorrienteDestino")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ingreso")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Egreso")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Voucher")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descuento")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMovimiento")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoTransa")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AsignadoGrupo")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPrestamoHab")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Depositado")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoPorDepositar")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndAdministrativo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeId")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMovimientoViaje")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Importe")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioAutoriza")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCaja")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorrienteOrigen")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCuentaCorrienteDestino")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ingreso")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Egreso")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Saldo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Voucher")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descuento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMovimiento")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoTransa")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AsignadoGrupo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPrestamoHab")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Depositado")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SaldoPorDepositar")
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
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.griDescuentos = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtornarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odDescuentos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.expGlosa = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griListaGlosa = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.cbVerGlosa = New System.Windows.Forms.CheckBox()
        Me.numCuotas = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConceptos = New ISL.Controles.Combo(Me.components)
        Me.txtGlosa = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Fecha1 = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtImporte = New ISL.Controles.NumeroDecimal(Me.components)
        Me.agrDatosBasicos = New ISL.Controles.Agrupacion(Me.components)
        Me.ndRenumeracion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ndAsigFam = New ISL.Controles.NumeroDecimal(Me.components)
        Me.ndSueldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaIngreso = New ISL.Controles.Fecha(Me.components)
        Me.txtCargo = New ISL.Controles.Texto(Me.components)
        Me.etiFechaIngreso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiCargo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.etiArea = New ISL.Controles.Etiqueta(Me.components)
        Me.FotoTrabajador = New System.Windows.Forms.PictureBox()
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrViaje = New ISL.Controles.Agrupacion(Me.components)
        Me.etiEstadoAsociado = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFechaAsociada = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiRutaDetalle = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboPilotoViaje = New ISL.Controles.Combo(Me.components)
        Me.cboViaje = New ISL.Controles.Combo(Me.components)
        Me.ficDescuentos = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.chkDisponible = New System.Windows.Forms.CheckBox()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.griDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.odDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.expGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expGlosa.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.ndRenumeracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndAsigFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrViaje.SuspendLayout()
        CType(Me.cboPilotoViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDescuentos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrOperaciones)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1009, 388)
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.griDescuentos)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOperaciones.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(1009, 388)
        Me.agrOperaciones.TabIndex = 0
        Me.agrOperaciones.Text = "Descuentos"
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griDescuentos
        '
        Me.griDescuentos.ContextMenuStrip = Me.MenuContextual1
        Me.griDescuentos.DataSource = Me.odDescuentos
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        Appearance1.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance1
        UltraGridColumn34.Format = "#,###,###,##0.00"
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn34.Header.Appearance = Appearance2
        UltraGridColumn34.Header.VisiblePosition = 7
        UltraGridColumn34.MaskInput = "{double:9.2}"
        UltraGridColumn34.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Header.Caption = "UsuarioCreacion"
        UltraGridColumn35.Header.VisiblePosition = 8
        UltraGridColumn35.Width = 241
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridColumn36.Width = 128
        UltraGridColumn37.Header.VisiblePosition = 4
        UltraGridColumn37.Width = 298
        UltraGridColumn38.Header.VisiblePosition = 9
        UltraGridColumn38.Width = 113
        UltraGridColumn39.Header.VisiblePosition = 10
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 11
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 12
        UltraGridColumn41.Hidden = True
        UltraGridColumn42.Header.VisiblePosition = 13
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 14
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 15
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 16
        UltraGridColumn45.Hidden = True
        UltraGridColumn46.Header.VisiblePosition = 17
        UltraGridColumn46.Hidden = True
        UltraGridColumn47.Header.VisiblePosition = 6
        UltraGridColumn47.Width = 438
        UltraGridColumn48.Header.VisiblePosition = 18
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 19
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 20
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 21
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 22
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 23
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 24
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 25
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 26
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 27
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 28
        UltraGridColumn58.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58})
        Me.griDescuentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDescuentos.DisplayLayout.MaxColScrollRegions = 1
        Me.griDescuentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDescuentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDescuentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griDescuentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDescuentos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDescuentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griDescuentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDescuentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griDescuentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDescuentos.Location = New System.Drawing.Point(3, 17)
        Me.griDescuentos.Name = "griDescuentos"
        Me.griDescuentos.Size = New System.Drawing.Size(1003, 368)
        Me.griDescuentos.TabIndex = 0
        Me.griDescuentos.Text = "Información de Descuentos de Trabajadores"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ExtornarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(114, 48)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar una nueva Marca"
        '
        'ExtornarToolStripMenuItem
        '
        Me.ExtornarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.ExtornarToolStripMenuItem.Name = "ExtornarToolStripMenuItem"
        Me.ExtornarToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExtornarToolStripMenuItem.Text = "Extornar"
        Me.ExtornarToolStripMenuItem.ToolTipText = "Extornar Descuento"
        '
        'odDescuentos
        '
        Me.odDescuentos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.expGlosa)
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1009, 388)
        '
        'expGlosa
        '
        Me.expGlosa.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.expGlosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.expGlosa.ExpandedSize = New System.Drawing.Size(1009, 113)
        Me.expGlosa.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.expGlosa.Location = New System.Drawing.Point(0, 275)
        Me.expGlosa.Name = "expGlosa"
        Me.expGlosa.Size = New System.Drawing.Size(1009, 113)
        Me.expGlosa.TabIndex = 1
        Me.expGlosa.Text = "Glosa"
        Me.expGlosa.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.expGlosa.Visible = False
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.griListaGlosa)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(1003, 90)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'griListaGlosa
        '
        Me.griListaGlosa.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaGlosa.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListaGlosa.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griListaGlosa.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaGlosa.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaGlosa.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaGlosa.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaGlosa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaGlosa.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaGlosa.Location = New System.Drawing.Point(0, 0)
        Me.griListaGlosa.Name = "griListaGlosa"
        Me.griListaGlosa.Size = New System.Drawing.Size(1003, 90)
        Me.griListaGlosa.TabIndex = 0
        Me.griListaGlosa.Text = "Listado de Glosas"
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.cbVerGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.numCuotas)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta10)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta9)
        Me.agrProcesoNegocio.Controls.Add(Me.cboConceptos)
        Me.agrProcesoNegocio.Controls.Add(Me.txtGlosa)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.Fecha1)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta2)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta1)
        Me.agrProcesoNegocio.Controls.Add(Me.txtImporte)
        Me.agrProcesoNegocio.Controls.Add(Me.agrDatosBasicos)
        Me.agrProcesoNegocio.Controls.Add(Me.FotoTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1009, 275)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cbVerGlosa
        '
        Me.cbVerGlosa.AutoSize = True
        Me.cbVerGlosa.BackColor = System.Drawing.Color.Transparent
        Me.cbVerGlosa.Location = New System.Drawing.Point(94, 153)
        Me.cbVerGlosa.Name = "cbVerGlosa"
        Me.cbVerGlosa.Size = New System.Drawing.Size(71, 17)
        Me.cbVerGlosa.TabIndex = 237
        Me.cbVerGlosa.Text = "Ver Glosa"
        Me.cbVerGlosa.UseVisualStyleBackColor = False
        '
        'numCuotas
        '
        Appearance3.ForeColor = System.Drawing.Color.Black
        Me.numCuotas.Appearance = Appearance3
        Me.numCuotas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCuotas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuotas.ForeColor = System.Drawing.Color.Black
        Me.numCuotas.Location = New System.Drawing.Point(94, 235)
        Me.numCuotas.MaskInput = "nnnn"
        Me.numCuotas.MaxValue = 100
        Me.numCuotas.MinValue = 0
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.NullText = "0"
        Me.numCuotas.Size = New System.Drawing.Size(42, 22)
        Me.numCuotas.TabIndex = 12
        Me.numCuotas.Visible = False
        '
        'Etiqueta10
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance4
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(44, 239)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta10.TabIndex = 11
        Me.Etiqueta10.Text = "Cuotas:"
        Me.Etiqueta10.Visible = False
        '
        'Etiqueta9
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance5
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(32, 180)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta9.TabIndex = 7
        Me.Etiqueta9.Text = "Concepto:"
        '
        'cboConceptos
        '
        Appearance6.ForeColor = System.Drawing.Color.Black
        Me.cboConceptos.Appearance = Appearance6
        Me.cboConceptos.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConceptos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConceptos.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConceptos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptos.ForeColor = System.Drawing.Color.Black
        Me.cboConceptos.Location = New System.Drawing.Point(94, 178)
        Me.cboConceptos.Name = "cboConceptos"
        Me.cboConceptos.Size = New System.Drawing.Size(352, 22)
        Me.cboConceptos.TabIndex = 8
        Me.cboConceptos.ValueMember = "Id"
        '
        'txtGlosa
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Appearance = Appearance7
        Me.txtGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGlosa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGlosa.ForeColor = System.Drawing.Color.Black
        Me.txtGlosa.Location = New System.Drawing.Point(94, 103)
        Me.txtGlosa.MaxLength = 3000
        Me.txtGlosa.Multiline = True
        Me.txtGlosa.Name = "txtGlosa"
        Me.txtGlosa.Size = New System.Drawing.Size(301, 44)
        Me.txtGlosa.TabIndex = 5
        '
        'Etiqueta3
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance8
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(50, 207)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta3.TabIndex = 9
        Me.Etiqueta3.Text = "Fecha:"
        '
        'Fecha1
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.Fecha1.Appearance = Appearance9
        Me.Fecha1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.Fecha1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha1.ForeColor = System.Drawing.Color.Black
        Me.Fecha1.Location = New System.Drawing.Point(94, 205)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(90, 22)
        Me.Fecha1.TabIndex = 10
        '
        'Etiqueta2
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance10
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(50, 105)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta2.TabIndex = 4
        Me.Etiqueta2.Text = "Glosa:"
        '
        'Etiqueta1
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance11
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(42, 74)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(48, 15)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Importe:"
        '
        'txtImporte
        '
        Appearance12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Appearance = Appearance12
        Me.txtImporte.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtImporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtImporte.Location = New System.Drawing.Point(94, 72)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.NullText = "0.00"
        Me.txtImporte.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtImporte.Size = New System.Drawing.Size(86, 22)
        Me.txtImporte.TabIndex = 3
        '
        'agrDatosBasicos
        '
        Me.agrDatosBasicos.Controls.Add(Me.chkDisponible)
        Me.agrDatosBasicos.Controls.Add(Me.ndRenumeracion)
        Me.agrDatosBasicos.Controls.Add(Me.ndAsigFam)
        Me.agrDatosBasicos.Controls.Add(Me.ndSueldo)
        Me.agrDatosBasicos.Controls.Add(Me.Etiqueta19)
        Me.agrDatosBasicos.Controls.Add(Me.Etiqueta18)
        Me.agrDatosBasicos.Controls.Add(Me.Etiqueta17)
        Me.agrDatosBasicos.Controls.Add(Me.fecFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.txtCargo)
        Me.agrDatosBasicos.Controls.Add(Me.etiFechaIngreso)
        Me.agrDatosBasicos.Controls.Add(Me.etiCargo)
        Me.agrDatosBasicos.Controls.Add(Me.txtArea)
        Me.agrDatosBasicos.Controls.Add(Me.etiArea)
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.Location = New System.Drawing.Point(662, 22)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(310, 234)
        Me.agrDatosBasicos.TabIndex = 13
        Me.agrDatosBasicos.Text = "Datos Básicos del Trabajador"
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'ndRenumeracion
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.ndRenumeracion.Appearance = Appearance13
        Me.ndRenumeracion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndRenumeracion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndRenumeracion.ForeColor = System.Drawing.Color.Black
        Me.ndRenumeracion.Location = New System.Drawing.Point(112, 171)
        Me.ndRenumeracion.Name = "ndRenumeracion"
        Me.ndRenumeracion.NullText = "0.00"
        Me.ndRenumeracion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndRenumeracion.ReadOnly = True
        Me.ndRenumeracion.Size = New System.Drawing.Size(90, 22)
        Me.ndRenumeracion.TabIndex = 11
        Me.ndRenumeracion.TabStop = False
        '
        'ndAsigFam
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.ndAsigFam.Appearance = Appearance14
        Me.ndAsigFam.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndAsigFam.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndAsigFam.ForeColor = System.Drawing.Color.Black
        Me.ndAsigFam.Location = New System.Drawing.Point(112, 140)
        Me.ndAsigFam.Name = "ndAsigFam"
        Me.ndAsigFam.NullText = "0.00"
        Me.ndAsigFam.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndAsigFam.ReadOnly = True
        Me.ndAsigFam.Size = New System.Drawing.Size(90, 22)
        Me.ndAsigFam.TabIndex = 9
        Me.ndAsigFam.TabStop = False
        '
        'ndSueldo
        '
        Appearance15.ForeColor = System.Drawing.Color.Black
        Me.ndSueldo.Appearance = Appearance15
        Me.ndSueldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndSueldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndSueldo.ForeColor = System.Drawing.Color.Black
        Me.ndSueldo.Location = New System.Drawing.Point(112, 109)
        Me.ndSueldo.Name = "ndSueldo"
        Me.ndSueldo.NullText = "0.00"
        Me.ndSueldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndSueldo.ReadOnly = True
        Me.ndSueldo.Size = New System.Drawing.Size(90, 22)
        Me.ndSueldo.TabIndex = 7
        Me.ndSueldo.TabStop = False
        '
        'Etiqueta19
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance16
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(24, 175)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta19.TabIndex = 10
        Me.Etiqueta19.Text = "Renumeracion:"
        '
        'Etiqueta18
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance17
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(43, 144)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta18.TabIndex = 8
        Me.Etiqueta18.Text = "Asig. Fam.:"
        '
        'Etiqueta17
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance18
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(62, 113)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta17.TabIndex = 6
        Me.Etiqueta17.Text = "Sueldo:"
        '
        'fecFechaIngreso
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Appearance = Appearance19
        Me.fecFechaIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Location = New System.Drawing.Point(112, 79)
        Me.fecFechaIngreso.Name = "fecFechaIngreso"
        Me.fecFechaIngreso.ReadOnly = True
        Me.fecFechaIngreso.Size = New System.Drawing.Size(90, 22)
        Me.fecFechaIngreso.TabIndex = 5
        Me.fecFechaIngreso.TabStop = False
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(112, 52)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(185, 22)
        Me.txtCargo.TabIndex = 3
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiFechaIngreso
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaIngreso.Appearance = Appearance20
        Me.etiFechaIngreso.AutoSize = True
        Me.etiFechaIngreso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.etiFechaIngreso.Location = New System.Drawing.Point(11, 83)
        Me.etiFechaIngreso.Name = "etiFechaIngreso"
        Me.etiFechaIngreso.Size = New System.Drawing.Size(95, 15)
        Me.etiFechaIngreso.TabIndex = 4
        Me.etiFechaIngreso.Text = "Fecha de Ingreso:"
        '
        'etiCargo
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Me.etiCargo.Appearance = Appearance21
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(66, 57)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(37, 15)
        Me.etiCargo.TabIndex = 2
        Me.etiCargo.Text = "Cargo:"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(112, 25)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(185, 22)
        Me.txtArea.TabIndex = 1
        Me.txtArea.TabStop = False
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Me.etiArea.Appearance = Appearance22
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(73, 29)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(31, 15)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area:"
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(476, 22)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(180, 219)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 236
        Me.FotoTrabajador.TabStop = False
        Me.FotoTrabajador.Visible = False
        '
        'etiTrabajador
        '
        Appearance23.BackColor = System.Drawing.Color.Transparent
        Appearance23.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance23
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(26, 45)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(63, 15)
        Me.etiTrabajador.TabIndex = 0
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboTrabajadores
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance24
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Enabled = False
        Me.cboTrabajadores.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(94, 43)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 22)
        Me.cboTrabajadores.TabIndex = 1
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrViaje)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1009, 388)
        '
        'agrViaje
        '
        Me.agrViaje.Controls.Add(Me.etiEstadoAsociado)
        Me.agrViaje.Controls.Add(Me.etiFechaAsociada)
        Me.agrViaje.Controls.Add(Me.Etiqueta8)
        Me.agrViaje.Controls.Add(Me.Etiqueta7)
        Me.agrViaje.Controls.Add(Me.etiRutaDetalle)
        Me.agrViaje.Controls.Add(Me.Etiqueta6)
        Me.agrViaje.Controls.Add(Me.Etiqueta5)
        Me.agrViaje.Controls.Add(Me.Etiqueta4)
        Me.agrViaje.Controls.Add(Me.cboPilotoViaje)
        Me.agrViaje.Controls.Add(Me.cboViaje)
        Me.agrViaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrViaje.ForeColor = System.Drawing.Color.Black
        Me.agrViaje.Location = New System.Drawing.Point(0, 0)
        Me.agrViaje.Name = "agrViaje"
        Me.agrViaje.Size = New System.Drawing.Size(1009, 388)
        Me.agrViaje.TabIndex = 0
        Me.agrViaje.Text = "Viajes Asociados"
        Me.agrViaje.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'etiEstadoAsociado
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Me.etiEstadoAsociado.Appearance = Appearance25
        Me.etiEstadoAsociado.AutoSize = True
        Me.etiEstadoAsociado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEstadoAsociado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEstadoAsociado.Location = New System.Drawing.Point(96, 163)
        Me.etiEstadoAsociado.Name = "etiEstadoAsociado"
        Me.etiEstadoAsociado.Size = New System.Drawing.Size(4, 15)
        Me.etiEstadoAsociado.TabIndex = 9
        Me.etiEstadoAsociado.Text = " "
        '
        'etiFechaAsociada
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaAsociada.Appearance = Appearance26
        Me.etiFechaAsociada.AutoSize = True
        Me.etiFechaAsociada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaAsociada.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiFechaAsociada.Location = New System.Drawing.Point(96, 134)
        Me.etiFechaAsociada.Name = "etiFechaAsociada"
        Me.etiFechaAsociada.Size = New System.Drawing.Size(4, 15)
        Me.etiFechaAsociada.TabIndex = 7
        Me.etiFechaAsociada.Text = " "
        '
        'Etiqueta8
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance27
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(46, 163)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(42, 15)
        Me.Etiqueta8.TabIndex = 8
        Me.Etiqueta8.Text = "Estado:"
        '
        'Etiqueta7
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance28
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(51, 134)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta7.TabIndex = 6
        Me.Etiqueta7.Text = "Fecha:"
        '
        'etiRutaDetalle
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.etiRutaDetalle.Appearance = Appearance29
        Me.etiRutaDetalle.AutoSize = True
        Me.etiRutaDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiRutaDetalle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiRutaDetalle.Location = New System.Drawing.Point(96, 101)
        Me.etiRutaDetalle.Name = "etiRutaDetalle"
        Me.etiRutaDetalle.Size = New System.Drawing.Size(4, 15)
        Me.etiRutaDetalle.TabIndex = 5
        Me.etiRutaDetalle.Text = " "
        '
        'Etiqueta6
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance30
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(57, 101)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta6.TabIndex = 4
        Me.Etiqueta6.Text = "Ruta:"
        '
        'Etiqueta5
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance31
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(57, 63)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(33, 15)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Viaje:"
        '
        'Etiqueta4
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance32
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(54, 30)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Piloto:"
        '
        'cboPilotoViaje
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboPilotoViaje.Appearance = Appearance33
        Me.cboPilotoViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboPilotoViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPilotoViaje.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboPilotoViaje.Enabled = False
        Me.cboPilotoViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPilotoViaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboPilotoViaje.Location = New System.Drawing.Point(95, 28)
        Me.cboPilotoViaje.Name = "cboPilotoViaje"
        Me.cboPilotoViaje.ReadOnly = True
        Me.cboPilotoViaje.Size = New System.Drawing.Size(279, 22)
        Me.cboPilotoViaje.TabIndex = 1
        Me.cboPilotoViaje.ValueMember = "Id"
        '
        'cboViaje
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Appearance = Appearance34
        Me.cboViaje.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboViaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboViaje.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboViaje.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViaje.ForeColor = System.Drawing.Color.Black
        Me.cboViaje.Location = New System.Drawing.Point(95, 61)
        Me.cboViaje.Name = "cboViaje"
        Me.cboViaje.Size = New System.Drawing.Size(202, 22)
        Me.cboViaje.TabIndex = 3
        Me.cboViaje.ValueMember = "Id"
        '
        'ficDescuentos
        '
        Me.ficDescuentos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDescuentos.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDescuentos.Controls.Add(Me.utpDetalle)
        Me.ficDescuentos.Controls.Add(Me.UltraTabPageControl1)
        Me.ficDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDescuentos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficDescuentos.Location = New System.Drawing.Point(0, 0)
        Me.ficDescuentos.Name = "ficDescuentos"
        Me.ficDescuentos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDescuentos.Size = New System.Drawing.Size(1011, 411)
        Me.ficDescuentos.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Extorno"
        Me.ficDescuentos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficDescuentos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1009, 388)
        '
        'chkDisponible
        '
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.BackColor = System.Drawing.Color.Transparent
        Me.chkDisponible.ForeColor = System.Drawing.Color.Navy
        Me.chkDisponible.Location = New System.Drawing.Point(112, 202)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(71, 17)
        Me.chkDisponible.TabIndex = 238
        Me.chkDisponible.Text = "Ver Glosa"
        Me.chkDisponible.UseVisualStyleBackColor = False
        '
        'frm_Descuento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 411)
        Me.Controls.Add(Me.ficDescuentos)
        Me.Name = "frm_Descuento"
        Me.Text = "Descuentos"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        CType(Me.griDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.odDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.expGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expGlosa.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.griListaGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fecha1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBasicos.ResumeLayout(False)
        Me.agrDatosBasicos.PerformLayout()
        CType(Me.ndRenumeracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndAsigFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndSueldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrViaje.ResumeLayout(False)
        Me.agrViaje.PerformLayout()
        CType(Me.cboPilotoViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDescuentos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDescuentos As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents txtImporte As ISL.Controles.NumeroDecimal
    Friend WithEvents agrDatosBasicos As ISL.Controles.Agrupacion
    Friend WithEvents fecFechaIngreso As ISL.Controles.Fecha
    Friend WithEvents txtCargo As ISL.Controles.Texto
    Friend WithEvents etiFechaIngreso As ISL.Controles.Etiqueta
    Friend WithEvents etiCargo As ISL.Controles.Etiqueta
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents etiArea As ISL.Controles.Etiqueta
    Friend WithEvents FotoTrabajador As System.Windows.Forms.PictureBox
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Fecha1 As ISL.Controles.Fecha
    Friend WithEvents txtGlosa As ISL.Controles.Texto
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents griDescuentos As ISL.Controles.Grilla
    Friend WithEvents odDescuentos As ISL.Controles.OrigenDatos
    Friend WithEvents ExtornarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents expGlosa As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griListaGlosa As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrViaje As ISL.Controles.Agrupacion
    Friend WithEvents cboViaje As ISL.Controles.Combo
    Friend WithEvents cboPilotoViaje As ISL.Controles.Combo
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents etiEstadoAsociado As ISL.Controles.Etiqueta
    Friend WithEvents etiFechaAsociada As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents etiRutaDetalle As ISL.Controles.Etiqueta
    Friend WithEvents cboConceptos As ISL.Controles.Combo
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents numCuotas As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ndRenumeracion As ISL.Controles.NumeroDecimal
    Friend WithEvents ndAsigFam As ISL.Controles.NumeroDecimal
    Friend WithEvents ndSueldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents cbVerGlosa As System.Windows.Forms.CheckBox
    Friend WithEvents chkDisponible As System.Windows.Forms.CheckBox
End Class
