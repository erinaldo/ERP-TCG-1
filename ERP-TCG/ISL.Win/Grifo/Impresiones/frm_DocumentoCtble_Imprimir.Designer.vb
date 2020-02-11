<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DocumentoCtble_Imprimir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("e_MovimientoDocumento", -1)
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaSis")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSucursal")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndServicioMaterial")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("lstDetalleDocumentoCombustible")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnulado")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrev_Empresa")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreDocumento")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiasVen")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IGV")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SubTotal")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetraccion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndElectronico")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnexo")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndDetalleGlosa")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOperar")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoCanje")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Letra")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion_Saldo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreProveedor", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Item")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteProveedor")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAsientoMovimiento")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCompraVenta")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuarioCrea")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AbreviaturaMoneda")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoDetraccion")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Neto")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCuentaContable")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoDocumento")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoDocumento")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoPago")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPago")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Percepcion")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoBien")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMotivo")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenCompra")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoSunat")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAnticipo")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndAfectaAnticipo")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto_Anticipo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("lstDetalleDocumentoCombustible", 0)
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SaldoReferencia")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRegConsumoCombustible")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTanqueo")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodViaje")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGrifo")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLinea")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioUnit")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDetalleDocumento")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Igv")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndGravado")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodMaterial")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrecioIGV")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroVale")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaVeh")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.VISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.udg_Documentos = New ISL.Controles.Grilla(Me.components)
        Me.bso_Documento = New System.Windows.Forms.BindingSource(Me.components)
        Me.grb_DocumentosAsociados = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.BSO1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSO2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.UltraTabPageControl1.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.udg_Documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grb_DocumentosAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb_DocumentosAsociados.SuspendLayout()
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.VISOR)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(982, 638)
        '
        'VISOR
        '
        Me.VISOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VISOR.LocalReport.ReportEmbeddedResource = "ISL.Win.rpt_DocumentoCtble_Termica.rdlc"
        Me.VISOR.Location = New System.Drawing.Point(0, 0)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(982, 638)
        Me.VISOR.TabIndex = 2
        Me.VISOR.ZoomPercent = 90
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.udg_Documentos)
        Me.UltraTabPageControl2.Controls.Add(Me.grb_DocumentosAsociados)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(982, 638)
        '
        'udg_Documentos
        '
        Me.udg_Documentos.DataSource = Me.bso_Documento
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.udg_Documentos.DisplayLayout.Appearance = Appearance1
        UltraGridColumn82.Header.VisiblePosition = 39
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 40
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 37
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 55
        UltraGridColumn86.Header.VisiblePosition = 41
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.Header.VisiblePosition = 42
        UltraGridColumn87.Hidden = True
        UltraGridColumn88.Header.VisiblePosition = 16
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 17
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn90.Header.Caption = "Nº Documento"
        UltraGridColumn90.Header.VisiblePosition = 4
        UltraGridColumn90.Width = 143
        UltraGridColumn91.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn91.Header.Caption = "Producto"
        UltraGridColumn91.Header.VisiblePosition = 11
        UltraGridColumn91.Width = 150
        UltraGridColumn92.Header.VisiblePosition = 19
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.Header.VisiblePosition = 20
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn94.Header.Caption = "Fecha"
        UltraGridColumn94.Header.VisiblePosition = 1
        UltraGridColumn94.Width = 77
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.Header.VisiblePosition = 35
        UltraGridColumn96.Hidden = True
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance2
        UltraGridColumn97.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn97.Format = "#,###,###,##0.00"
        UltraGridColumn97.Header.Caption = "Imp. Venta"
        UltraGridColumn97.Header.VisiblePosition = 9
        UltraGridColumn97.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn97.Width = 91
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance3
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn98.Format = "#,###,###,##0.00"
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridColumn98.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn98.Width = 109
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn99.CellAppearance = Appearance4
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn99.Format = "#,###,###,##0.00"
        UltraGridColumn99.Header.VisiblePosition = 10
        UltraGridColumn99.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn99.Width = 104
        UltraGridColumn100.Header.VisiblePosition = 27
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 38
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 48
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn103.Header.Caption = "Sel"
        UltraGridColumn103.Header.VisiblePosition = 0
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 49
        UltraGridColumn104.Hidden = True
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn105.CellAppearance = Appearance5
        UltraGridColumn105.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn105.Header.Caption = "Tipo Cambio"
        UltraGridColumn105.Header.VisiblePosition = 7
        UltraGridColumn105.Width = 71
        UltraGridColumn106.Header.VisiblePosition = 28
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 43
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 44
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 45
        UltraGridColumn109.Hidden = True
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn110.CellAppearance = Appearance6
        UltraGridColumn110.Format = "#,###,###,##0.00"
        UltraGridColumn110.Header.Caption = "Importe"
        UltraGridColumn110.Header.VisiblePosition = 15
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn111.Header.Caption = "Empresa"
        UltraGridColumn111.Header.VisiblePosition = 2
        UltraGridColumn111.Width = 281
        UltraGridColumn112.Header.VisiblePosition = 46
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.Header.VisiblePosition = 21
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 29
        UltraGridColumn114.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn115.CellAppearance = Appearance7
        UltraGridColumn115.Header.VisiblePosition = 22
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.MaskInput = ""
        UltraGridColumn116.Header.VisiblePosition = 30
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 24
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 18
        UltraGridColumn118.Hidden = True
        UltraGridColumn118.Width = 132
        UltraGridColumn119.Header.VisiblePosition = 23
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn120.Header.VisiblePosition = 6
        UltraGridColumn121.Header.VisiblePosition = 36
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 25
        UltraGridColumn122.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn123.CellAppearance = Appearance8
        UltraGridColumn123.Format = "#,###,###,##0.00"
        UltraGridColumn123.Header.Caption = "Precio Unit."
        UltraGridColumn123.Header.VisiblePosition = 14
        UltraGridColumn124.Header.VisiblePosition = 31
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 32
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 34
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn127.Header.Caption = "Estado"
        UltraGridColumn127.Header.VisiblePosition = 5
        UltraGridColumn127.Width = 80
        UltraGridColumn128.Header.VisiblePosition = 33
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.Caption = "Tipo Documento"
        UltraGridColumn129.Header.VisiblePosition = 3
        UltraGridColumn129.Width = 167
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn130.CellAppearance = Appearance9
        UltraGridColumn130.Format = "#,###,###,##0.00"
        UltraGridColumn130.Header.Caption = "Cantidad"
        UltraGridColumn130.Header.VisiblePosition = 13
        UltraGridColumn131.Header.VisiblePosition = 47
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.Header.VisiblePosition = 50
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.Caption = "Placa"
        UltraGridColumn133.Header.VisiblePosition = 12
        UltraGridColumn134.Header.VisiblePosition = 51
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 52
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 53
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.Header.VisiblePosition = 54
        UltraGridColumn137.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137})
        UltraGridColumn138.Header.VisiblePosition = 0
        UltraGridColumn139.Header.VisiblePosition = 1
        UltraGridColumn140.Header.VisiblePosition = 2
        UltraGridColumn141.Header.VisiblePosition = 3
        UltraGridColumn142.Header.VisiblePosition = 4
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn144.Header.VisiblePosition = 6
        UltraGridColumn145.Header.VisiblePosition = 7
        UltraGridColumn146.Header.VisiblePosition = 8
        UltraGridColumn147.Header.VisiblePosition = 9
        UltraGridColumn148.Header.VisiblePosition = 10
        UltraGridColumn149.Header.VisiblePosition = 11
        UltraGridColumn150.Header.VisiblePosition = 12
        UltraGridColumn151.Header.VisiblePosition = 13
        UltraGridColumn152.Header.VisiblePosition = 14
        UltraGridColumn153.Header.VisiblePosition = 15
        UltraGridColumn154.Header.VisiblePosition = 16
        UltraGridColumn155.Header.VisiblePosition = 17
        UltraGridColumn156.Header.VisiblePosition = 18
        UltraGridColumn157.Header.VisiblePosition = 19
        UltraGridColumn158.Header.VisiblePosition = 20
        UltraGridColumn159.Header.VisiblePosition = 21
        UltraGridColumn160.Header.VisiblePosition = 22
        UltraGridColumn161.Header.VisiblePosition = 23
        UltraGridColumn162.Header.VisiblePosition = 24
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162})
        Me.udg_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.udg_Documentos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.udg_Documentos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Documentos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance10.BorderColor = System.Drawing.SystemColors.Window
        Me.udg_Documentos.DisplayLayout.GroupByBox.Appearance = Appearance10
        Appearance11.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Documentos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance11
        Me.udg_Documentos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.udg_Documentos.DisplayLayout.GroupByBox.Hidden = True
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance12.BackColor2 = System.Drawing.SystemColors.Control
        Appearance12.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance12.ForeColor = System.Drawing.SystemColors.GrayText
        Me.udg_Documentos.DisplayLayout.GroupByBox.PromptAppearance = Appearance12
        Me.udg_Documentos.DisplayLayout.MaxColScrollRegions = 1
        Me.udg_Documentos.DisplayLayout.MaxRowScrollRegions = 1
        Me.udg_Documentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Documentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.udg_Documentos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Documentos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.udg_Documentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.udg_Documentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.udg_Documentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.udg_Documentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.udg_Documentos.DisplayLayout.Override.RowAppearance = Appearance13
        Me.udg_Documentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.udg_Documentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.udg_Documentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.udg_Documentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.udg_Documentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.udg_Documentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.udg_Documentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.udg_Documentos.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udg_Documentos.Location = New System.Drawing.Point(0, 47)
        Me.udg_Documentos.Name = "udg_Documentos"
        Me.udg_Documentos.Size = New System.Drawing.Size(982, 591)
        Me.udg_Documentos.TabIndex = 11
        Me.udg_Documentos.Text = "Grilla2"
        '
        'bso_Documento
        '
        Me.bso_Documento.DataSource = GetType(ERP.EntidadesWCF.e_MovimientoDocumento)
        '
        'grb_DocumentosAsociados
        '
        Me.grb_DocumentosAsociados.Controls.Add(Me.btn_Cerrar)
        Me.grb_DocumentosAsociados.Controls.Add(Me.btn_Exportar)
        Me.grb_DocumentosAsociados.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_DocumentosAsociados.Location = New System.Drawing.Point(0, 0)
        Me.grb_DocumentosAsociados.Name = "grb_DocumentosAsociados"
        Me.grb_DocumentosAsociados.Size = New System.Drawing.Size(982, 47)
        Me.grb_DocumentosAsociados.TabIndex = 12
        Me.grb_DocumentosAsociados.Text = "UltraGroupBox1"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Location = New System.Drawing.Point(11, 18)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(248, 23)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar a Hoja de Calculo (.XLS)"
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(984, 661)
        Me.UltraTabControl1.TabIndex = 3
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Documento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Complementos"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(982, 638)
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Location = New System.Drawing.Point(963, 17)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(10, 10)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_DocumentoCtble_Imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_DocumentoCtble_Imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_DocumentoCtble_Imprimir"
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.udg_Documentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bso_Documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grb_DocumentosAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb_DocumentosAsociados.ResumeLayout(False)
        CType(Me.BSO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BSO1 As BindingSource
    Friend WithEvents BSO2 As BindingSource
    Friend WithEvents VISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents bso_Documento As BindingSource
    Friend WithEvents udg_Documentos As Controles.Grilla
    Friend WithEvents grb_DocumentosAsociados As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents btn_Cerrar As Button
End Class
