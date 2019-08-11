<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Trabajo
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
        Me.components = New System.ComponentModel.Container
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Paso")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comando")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Habilitado")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Paso")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Comando")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Habilitado")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPersona")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.agrTrabajoSQL = New ISL.Controles.Agrupacion(Me.components)
        Me.griTrabajoSQL = New ISL.Controles.Grilla(Me.components)
        Me.ordTrabajoSQL = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griParametros = New ISL.Controles.Grilla(Me.components)
        Me.agrListaEmail = New Infragistics.Win.Misc.UltraExpandableGroupBox
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
        Me.griEmail = New ISL.Controles.Grilla(Me.components)
        Me.ordEmail = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrManTrabajo = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCargar = New ISL.Controles.Boton(Me.components)
        Me.verHabilitado = New ISL.Controles.Chequear(Me.components)
        Me.btnVer = New ISL.Controles.Boton(Me.components)
        Me.txtComando = New ISL.Controles.Texto(Me.components)
        Me.txtPaso = New ISL.Controles.Texto(Me.components)
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.etiComando = New ISL.Controles.Etiqueta(Me.components)
        Me.etiPaso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDescripcion = New ISL.Controles.Etiqueta(Me.components)
        Me.etiNombre = New ISL.Controles.Etiqueta(Me.components)
        Me.ficTrabajoSQL = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrTrabajoSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrTrabajoSQL.SuspendLayout()
        CType(Me.griTrabajoSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordTrabajoSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griParametros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrListaEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrListaEmail.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.griEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrManTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrManTrabajo.SuspendLayout()
        CType(Me.verHabilitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficTrabajoSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficTrabajoSQL.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrTrabajoSQL)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(819, 494)
        '
        'agrTrabajoSQL
        '
        Me.agrTrabajoSQL.Controls.Add(Me.griTrabajoSQL)
        Me.agrTrabajoSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrTrabajoSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrTrabajoSQL.ForeColor = System.Drawing.Color.Black
        Me.agrTrabajoSQL.Location = New System.Drawing.Point(0, 0)
        Me.agrTrabajoSQL.Name = "agrTrabajoSQL"
        Me.agrTrabajoSQL.Size = New System.Drawing.Size(819, 494)
        Me.agrTrabajoSQL.TabIndex = 0
        Me.agrTrabajoSQL.Text = "Lista de Trabajo SQL"
        Me.agrTrabajoSQL.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griTrabajoSQL
        '
        Me.griTrabajoSQL.DataSource = Me.ordTrabajoSQL
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 186
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 258
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 230
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 212
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        UltraGridBand1.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTrabajoSQL.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griTrabajoSQL.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTrabajoSQL.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTrabajoSQL.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTrabajoSQL.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTrabajoSQL.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTrabajoSQL.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended
        Me.griTrabajoSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTrabajoSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTrabajoSQL.Location = New System.Drawing.Point(2, 18)
        Me.griTrabajoSQL.Name = "griTrabajoSQL"
        Me.griTrabajoSQL.Size = New System.Drawing.Size(815, 474)
        Me.griTrabajoSQL.TabIndex = 0
        '
        'ordTrabajoSQL
        '
        UltraDataColumn6.DataType = GetType(Boolean)
        Me.ordTrabajoSQL.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl2.Controls.Add(Me.agrManTrabajo)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(819, 494)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Controls.Add(Me.agrListaEmail)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 260)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(819, 234)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Parametros:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griParametros)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(540, 18)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(277, 214)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griParametros
        '
        Me.griParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griParametros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griParametros.Location = New System.Drawing.Point(2, 0)
        Me.griParametros.Name = "griParametros"
        Me.griParametros.Size = New System.Drawing.Size(273, 212)
        Me.griParametros.TabIndex = 0
        '
        'agrListaEmail
        '
        Me.agrListaEmail.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.agrListaEmail.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.agrListaEmail.Dock = System.Windows.Forms.DockStyle.Left
        Me.agrListaEmail.ExpandedSize = New System.Drawing.Size(538, 214)
        Me.agrListaEmail.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.agrListaEmail.Location = New System.Drawing.Point(2, 18)
        Me.agrListaEmail.Name = "agrListaEmail"
        Me.agrListaEmail.Size = New System.Drawing.Size(538, 214)
        Me.agrListaEmail.TabIndex = 0
        Me.agrListaEmail.Text = "<< Lista de Email >>"
        Me.agrListaEmail.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.griEmail)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(22, 2)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(514, 210)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'griEmail
        '
        Me.griEmail.DataSource = Me.ordEmail
        UltraGridColumn7.Header.VisiblePosition = 0
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 1
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 2
        UltraGridColumn9.Width = 295
        UltraGridColumn10.Header.VisiblePosition = 3
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 4
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 5
        UltraGridColumn12.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12})
        Me.griEmail.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEmail.Location = New System.Drawing.Point(0, 0)
        Me.griEmail.Name = "griEmail"
        Me.griEmail.Size = New System.Drawing.Size(514, 210)
        Me.griEmail.TabIndex = 0
        '
        'ordEmail
        '
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn11.DataType = GetType(Date)
        Me.ordEmail.Band.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        '
        'agrManTrabajo
        '
        Me.agrManTrabajo.Controls.Add(Me.btnCargar)
        Me.agrManTrabajo.Controls.Add(Me.verHabilitado)
        Me.agrManTrabajo.Controls.Add(Me.btnVer)
        Me.agrManTrabajo.Controls.Add(Me.txtComando)
        Me.agrManTrabajo.Controls.Add(Me.txtPaso)
        Me.agrManTrabajo.Controls.Add(Me.txtDescripcion)
        Me.agrManTrabajo.Controls.Add(Me.txtNombre)
        Me.agrManTrabajo.Controls.Add(Me.etiComando)
        Me.agrManTrabajo.Controls.Add(Me.etiPaso)
        Me.agrManTrabajo.Controls.Add(Me.etiDescripcion)
        Me.agrManTrabajo.Controls.Add(Me.etiNombre)
        Me.agrManTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrManTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrManTrabajo.ForeColor = System.Drawing.Color.Black
        Me.agrManTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.agrManTrabajo.Name = "agrManTrabajo"
        Me.agrManTrabajo.Size = New System.Drawing.Size(819, 260)
        Me.agrManTrabajo.TabIndex = 0
        Me.agrManTrabajo.Text = "Datos:"
        Me.agrManTrabajo.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'btnCargar
        '
        Me.btnCargar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.Black
        Me.btnCargar.Location = New System.Drawing.Point(470, 154)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(90, 25)
        Me.btnCargar.TabIndex = 10
        Me.btnCargar.Text = ":: Cargar ::"
        '
        'verHabilitado
        '
        Me.verHabilitado.AutoSize = True
        Me.verHabilitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verHabilitado.ForeColor = System.Drawing.Color.Black
        Me.verHabilitado.Location = New System.Drawing.Point(470, 222)
        Me.verHabilitado.Name = "verHabilitado"
        Me.verHabilitado.Size = New System.Drawing.Size(70, 17)
        Me.verHabilitado.TabIndex = 9
        Me.verHabilitado.Text = "Habilitado"
        '
        'btnVer
        '
        Me.btnVer.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.ForeColor = System.Drawing.Color.Black
        Me.btnVer.Location = New System.Drawing.Point(470, 123)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(90, 25)
        Me.btnVer.TabIndex = 8
        Me.btnVer.Text = ":: Ver ::"
        '
        'txtComando
        '
        Me.txtComando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComando.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtComando.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComando.Location = New System.Drawing.Point(91, 119)
        Me.txtComando.Multiline = True
        Me.txtComando.Name = "txtComando"
        Me.txtComando.ReadOnly = True
        Me.txtComando.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComando.Size = New System.Drawing.Size(361, 120)
        Me.txtComando.TabIndex = 7
        '
        'txtPaso
        '
        Me.txtPaso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaso.Location = New System.Drawing.Point(91, 92)
        Me.txtPaso.Name = "txtPaso"
        Me.txtPaso.ReadOnly = True
        Me.txtPaso.Size = New System.Drawing.Size(361, 21)
        Me.txtPaso.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(91, 65)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(361, 21)
        Me.txtDescripcion.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(91, 38)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(361, 21)
        Me.txtNombre.TabIndex = 4
        '
        'etiComando
        '
        Me.etiComando.AutoSize = True
        Me.etiComando.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiComando.ForeColor = System.Drawing.Color.Black
        Me.etiComando.Location = New System.Drawing.Point(30, 123)
        Me.etiComando.Name = "etiComando"
        Me.etiComando.Size = New System.Drawing.Size(55, 14)
        Me.etiComando.TabIndex = 3
        Me.etiComando.Text = "Comando:"
        '
        'etiPaso
        '
        Me.etiPaso.AutoSize = True
        Me.etiPaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiPaso.ForeColor = System.Drawing.Color.Black
        Me.etiPaso.Location = New System.Drawing.Point(53, 99)
        Me.etiPaso.Name = "etiPaso"
        Me.etiPaso.Size = New System.Drawing.Size(32, 14)
        Me.etiPaso.TabIndex = 2
        Me.etiPaso.Text = "Paso:"
        '
        'etiDescripcion
        '
        Me.etiDescripcion.AutoSize = True
        Me.etiDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDescripcion.ForeColor = System.Drawing.Color.Black
        Me.etiDescripcion.Location = New System.Drawing.Point(20, 69)
        Me.etiDescripcion.Name = "etiDescripcion"
        Me.etiDescripcion.Size = New System.Drawing.Size(65, 14)
        Me.etiDescripcion.TabIndex = 1
        Me.etiDescripcion.Text = "Descripción:"
        '
        'etiNombre
        '
        Me.etiNombre.AutoSize = True
        Me.etiNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiNombre.ForeColor = System.Drawing.Color.Black
        Me.etiNombre.Location = New System.Drawing.Point(39, 42)
        Me.etiNombre.Name = "etiNombre"
        Me.etiNombre.Size = New System.Drawing.Size(46, 14)
        Me.etiNombre.TabIndex = 0
        Me.etiNombre.Text = "Nombre:"
        '
        'ficTrabajoSQL
        '
        Me.ficTrabajoSQL.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficTrabajoSQL.Controls.Add(Me.UltraTabPageControl1)
        Me.ficTrabajoSQL.Controls.Add(Me.UltraTabPageControl2)
        Me.ficTrabajoSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficTrabajoSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficTrabajoSQL.Location = New System.Drawing.Point(0, 0)
        Me.ficTrabajoSQL.Name = "ficTrabajoSQL"
        Me.ficTrabajoSQL.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficTrabajoSQL.Size = New System.Drawing.Size(821, 517)
        Me.ficTrabajoSQL.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficTrabajoSQL.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficTrabajoSQL.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(819, 494)
        '
        'frm_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 517)
        Me.Controls.Add(Me.ficTrabajoSQL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Trabajo"
        Me.Text = "Trabajo SQL"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrTrabajoSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrTrabajoSQL.ResumeLayout(False)
        CType(Me.griTrabajoSQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordTrabajoSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griParametros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrListaEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrListaEmail.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.griEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrManTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrManTrabajo.ResumeLayout(False)
        Me.agrManTrabajo.PerformLayout()
        CType(Me.verHabilitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficTrabajoSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficTrabajoSQL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficTrabajoSQL As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrTrabajoSQL As ISL.Controles.Agrupacion
    Friend WithEvents griTrabajoSQL As ISL.Controles.Grilla
    Friend WithEvents ordTrabajoSQL As ISL.Controles.OrigenDatos
    Friend WithEvents agrManTrabajo As ISL.Controles.Agrupacion
    Friend WithEvents txtComando As ISL.Controles.Texto
    Friend WithEvents txtPaso As ISL.Controles.Texto
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents etiComando As ISL.Controles.Etiqueta
    Friend WithEvents etiPaso As ISL.Controles.Etiqueta
    Friend WithEvents etiDescripcion As ISL.Controles.Etiqueta
    Friend WithEvents etiNombre As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents griParametros As ISL.Controles.Grilla
    Friend WithEvents btnVer As ISL.Controles.Boton
    Friend WithEvents griEmail As ISL.Controles.Grilla
    Friend WithEvents ordEmail As ISL.Controles.OrigenDatos
    Friend WithEvents verHabilitado As ISL.Controles.Chequear
    Friend WithEvents btnCargar As ISL.Controles.Boton
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents agrListaEmail As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
End Class
