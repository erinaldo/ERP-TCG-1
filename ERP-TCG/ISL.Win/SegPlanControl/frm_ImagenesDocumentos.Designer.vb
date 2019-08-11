<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImagenesDocumentos
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.gridPendientes = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridPorEnviar = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridEnviados = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridEnviarBaja = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridBaja = New ISL.Controles.Grilla(Me.components)
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridTicket = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridConsultas = New ISL.Controles.Grilla(Me.components)
        Me.ficImgDocVeh = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.agrFechas = New ISL.Controles.Agrupacion(Me.components)
        Me.btnXml = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.colorGenerado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.ucpRechazado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.ucpProceso = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.ucpAceptado = New Infragistics.Win.UltraWinEditors.UltraColorPicker()
        Me.btnConsultar = New ISL.Controles.Boton(Me.components)
        Me.btnEnviar = New ISL.Controles.Boton(Me.components)
        Me.lblTipoDoc = New Infragistics.Win.Misc.UltraLabel()
        Me.lblDesde = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoDoc = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.gridPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.gridPorEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.gridEnviados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.gridEnviarBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.gridBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.gridTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficImgDocVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficImgDocVeh.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFechas.SuspendLayout()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpRechazado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucpAceptado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1346, 330)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ugb_Espera)
        Me.Agrupacion2.Controls.Add(Me.gridPendientes)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1346, 330)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(302, 105)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 14
        Me.ugb_Espera.Visible = False
        '
        'gridPendientes
        '
        Me.gridPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPendientes.Location = New System.Drawing.Point(3, 3)
        Me.gridPendientes.Name = "gridPendientes"
        Me.gridPendientes.Size = New System.Drawing.Size(1340, 324)
        Me.gridPendientes.TabIndex = 15
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.gridPorEnviar)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1346, 330)
        '
        'gridPorEnviar
        '
        Me.gridPorEnviar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridPorEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridPorEnviar.Location = New System.Drawing.Point(0, 0)
        Me.gridPorEnviar.Name = "gridPorEnviar"
        Me.gridPorEnviar.Size = New System.Drawing.Size(1346, 330)
        Me.gridPorEnviar.TabIndex = 16
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.gridEnviados)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1346, 330)
        '
        'gridEnviados
        '
        Me.gridEnviados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEnviados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEnviados.Location = New System.Drawing.Point(0, 0)
        Me.gridEnviados.Name = "gridEnviados"
        Me.gridEnviados.Size = New System.Drawing.Size(1346, 330)
        Me.gridEnviados.TabIndex = 16
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.gridEnviarBaja)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1346, 330)
        '
        'gridEnviarBaja
        '
        Me.gridEnviarBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEnviarBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridEnviarBaja.Location = New System.Drawing.Point(0, 0)
        Me.gridEnviarBaja.Name = "gridEnviarBaja"
        Me.gridEnviarBaja.Size = New System.Drawing.Size(1346, 330)
        Me.gridEnviarBaja.TabIndex = 16
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.gridBaja)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1346, 330)
        '
        'gridBaja
        '
        Me.gridBaja.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridBaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridBaja.Location = New System.Drawing.Point(0, 0)
        Me.gridBaja.Name = "gridBaja"
        Me.gridBaja.Size = New System.Drawing.Size(1346, 330)
        Me.gridBaja.TabIndex = 17
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.gridTicket)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1346, 330)
        '
        'gridTicket
        '
        Me.gridTicket.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridTicket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridTicket.Location = New System.Drawing.Point(0, 0)
        Me.gridTicket.Name = "gridTicket"
        Me.gridTicket.Size = New System.Drawing.Size(1346, 330)
        Me.gridTicket.TabIndex = 18
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.gridConsultas)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1346, 330)
        '
        'gridConsultas
        '
        Me.gridConsultas.DisplayLayout.Override.FilterUIProvider = Me.UltraGridFilterUIProvider1
        Me.gridConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridConsultas.Location = New System.Drawing.Point(0, 0)
        Me.gridConsultas.Name = "gridConsultas"
        Me.gridConsultas.Size = New System.Drawing.Size(1346, 330)
        Me.gridConsultas.TabIndex = 19
        '
        'ficImgDocVeh
        '
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl1)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl2)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl3)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl4)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl5)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl6)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl7)
        Me.ficImgDocVeh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficImgDocVeh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficImgDocVeh.Location = New System.Drawing.Point(0, 88)
        Me.ficImgDocVeh.Name = "ficImgDocVeh"
        Me.ficImgDocVeh.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficImgDocVeh.Size = New System.Drawing.Size(1348, 353)
        Me.ficImgDocVeh.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Doc. Pendientes"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Doc. a Enviar"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Doc. Enviados"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Doc. Enviar Baja"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Doc. Baja"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Ticket"
        UltraTab7.TabPage = Me.UltraTabPageControl7
        UltraTab7.Text = "Enviar Doc. a Portal"
        Me.ficImgDocVeh.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5, UltraTab6, UltraTab7})
        Me.ficImgDocVeh.TabStop = False
        Me.ficImgDocVeh.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 330)
        '
        'Agrupacion1
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance1
        Me.Agrupacion1.Controls.Add(Me.agrFechas)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1348, 88)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "Listar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrFechas
        '
        Me.agrFechas.Controls.Add(Me.btnXml)
        Me.agrFechas.Controls.Add(Me.UltraLabel3)
        Me.agrFechas.Controls.Add(Me.UltraLabel4)
        Me.agrFechas.Controls.Add(Me.UltraLabel1)
        Me.agrFechas.Controls.Add(Me.UltraLabel2)
        Me.agrFechas.Controls.Add(Me.colorGenerado)
        Me.agrFechas.Controls.Add(Me.ucpRechazado)
        Me.agrFechas.Controls.Add(Me.ucpProceso)
        Me.agrFechas.Controls.Add(Me.ucpAceptado)
        Me.agrFechas.Controls.Add(Me.btnConsultar)
        Me.agrFechas.Controls.Add(Me.btnEnviar)
        Me.agrFechas.Controls.Add(Me.lblTipoDoc)
        Me.agrFechas.Controls.Add(Me.lblDesde)
        Me.agrFechas.Controls.Add(Me.cboTipoDoc)
        Me.agrFechas.Controls.Add(Me.fecDesde)
        Me.agrFechas.Controls.Add(Me.fecHasta)
        Me.agrFechas.Controls.Add(Me.lblHasta)
        Me.agrFechas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFechas.ForeColor = System.Drawing.Color.Black
        Me.agrFechas.Location = New System.Drawing.Point(3, 16)
        Me.agrFechas.Name = "agrFechas"
        Me.agrFechas.Size = New System.Drawing.Size(1342, 69)
        Me.agrFechas.TabIndex = 381
        Me.agrFechas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnXml
        '
        Appearance2.ForeColor = System.Drawing.Color.Navy
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Appearance2.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btnXml.Appearance = Appearance2
        Me.btnXml.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnXml.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXml.ForeColor = System.Drawing.Color.Black
        Me.btnXml.Location = New System.Drawing.Point(531, 35)
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(111, 26)
        Me.btnXml.TabIndex = 407
        Me.btnXml.TabStop = False
        Me.btnXml.Text = "DESCARGAR XML"
        '
        'UltraLabel3
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel3.Appearance = Appearance3
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(678, 42)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(55, 14)
        Me.UltraLabel3.TabIndex = 403
        Me.UltraLabel3.Text = "Por Enviar"
        '
        'UltraLabel4
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel4.Appearance = Appearance4
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(792, 42)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(61, 14)
        Me.UltraLabel4.TabIndex = 404
        Me.UltraLabel4.Text = "En Proceso"
        '
        'UltraLabel1
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Appearance5.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(914, 42)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel1.TabIndex = 405
        Me.UltraLabel1.Text = "Aceptado"
        '
        'UltraLabel2
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.UltraLabel2.Appearance = Appearance6
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(1025, 42)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel2.TabIndex = 406
        Me.UltraLabel2.Text = "Rechazado"
        '
        'colorGenerado
        '
        Me.colorGenerado.Color = System.Drawing.Color.White
        Me.colorGenerado.Location = New System.Drawing.Point(738, 38)
        Me.colorGenerado.Name = "colorGenerado"
        Me.colorGenerado.ReadOnly = True
        Me.colorGenerado.Size = New System.Drawing.Size(44, 21)
        Me.colorGenerado.TabIndex = 400
        Me.colorGenerado.Text = "White"
        '
        'ucpRechazado
        '
        Me.ucpRechazado.Color = System.Drawing.Color.LightCoral
        Me.ucpRechazado.Location = New System.Drawing.Point(1091, 38)
        Me.ucpRechazado.Name = "ucpRechazado"
        Me.ucpRechazado.ReadOnly = True
        Me.ucpRechazado.Size = New System.Drawing.Size(46, 21)
        Me.ucpRechazado.TabIndex = 399
        Me.ucpRechazado.Text = "LightCoral"
        '
        'ucpProceso
        '
        Me.ucpProceso.Color = System.Drawing.Color.LightSteelBlue
        Me.ucpProceso.Location = New System.Drawing.Point(859, 38)
        Me.ucpProceso.Name = "ucpProceso"
        Me.ucpProceso.ReadOnly = True
        Me.ucpProceso.Size = New System.Drawing.Size(44, 21)
        Me.ucpProceso.TabIndex = 401
        Me.ucpProceso.Text = "LightSteelBlue"
        '
        'ucpAceptado
        '
        Me.ucpAceptado.Color = System.Drawing.Color.LightGreen
        Me.ucpAceptado.Location = New System.Drawing.Point(970, 38)
        Me.ucpAceptado.Name = "ucpAceptado"
        Me.ucpAceptado.ReadOnly = True
        Me.ucpAceptado.Size = New System.Drawing.Size(44, 21)
        Me.ucpAceptado.TabIndex = 402
        Me.ucpAceptado.Text = "LightGreen"
        '
        'btnConsultar
        '
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.consult
        Appearance7.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btnConsultar.Appearance = Appearance7
        Me.btnConsultar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.ForeColor = System.Drawing.Color.Black
        Me.btnConsultar.Location = New System.Drawing.Point(434, 35)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(91, 26)
        Me.btnConsultar.TabIndex = 398
        Me.btnConsultar.TabStop = False
        Me.btnConsultar.Text = "CONSULTAR"
        '
        'btnEnviar
        '
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Appearance8.ImageHAlign = Infragistics.Win.HAlign.Left
        Me.btnEnviar.Appearance = Appearance8
        Me.btnEnviar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Location = New System.Drawing.Point(359, 35)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(69, 26)
        Me.btnEnviar.TabIndex = 385
        Me.btnEnviar.TabStop = False
        Me.btnEnviar.Text = "ENVIAR"
        '
        'lblTipoDoc
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.lblTipoDoc.Appearance = Appearance9
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(10, 15)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(29, 14)
        Me.lblTipoDoc.TabIndex = 397
        Me.lblTipoDoc.Text = "Tipo:"
        '
        'lblDesde
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.lblDesde.Appearance = Appearance10
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.ForeColor = System.Drawing.Color.Black
        Me.lblDesde.Location = New System.Drawing.Point(10, 41)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(39, 14)
        Me.lblDesde.TabIndex = 2
        Me.lblDesde.Text = "Desde:"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDoc.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDoc.Location = New System.Drawing.Point(61, 9)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(282, 23)
        Me.cboTipoDoc.TabIndex = 396
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(61, 38)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(104, 20)
        Me.fecDesde.TabIndex = 0
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(239, 38)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(104, 20)
        Me.fecHasta.TabIndex = 1
        '
        'lblHasta
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.lblHasta.Appearance = Appearance11
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.Color.Black
        Me.lblHasta.Location = New System.Drawing.Point(197, 41)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(36, 14)
        Me.lblHasta.TabIndex = 3
        Me.lblHasta.Text = "Hasta:"
        '
        'frm_ImagenesDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 441)
        Me.Controls.Add(Me.ficImgDocVeh)
        Me.Controls.Add(Me.Agrupacion1)
        Me.Name = "frm_ImagenesDocumentos"
        Me.Text = "Enviar Facturación Electrónica"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.gridPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.gridPorEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.gridEnviados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.gridEnviarBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.gridBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.gridTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.gridConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficImgDocVeh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficImgDocVeh.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFechas.ResumeLayout(False)
        Me.agrFechas.PerformLayout()
        CType(Me.colorGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpRechazado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucpAceptado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficImgDocVeh As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents gridPendientes As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridPorEnviar As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridEnviados As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridEnviarBaja As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents agrFechas As ISL.Controles.Agrupacion
    Friend WithEvents lblDesde As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridBaja As ISL.Controles.Grilla
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridTicket As ISL.Controles.Grilla
    Friend WithEvents btnEnviar As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridConsultas As ISL.Controles.Grilla
    Friend WithEvents lblTipoDoc As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTipoDoc As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents colorGenerado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpRechazado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpProceso As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents ucpAceptado As Infragistics.Win.UltraWinEditors.UltraColorPicker
    Friend WithEvents btnConsultar As ISL.Controles.Boton
    Friend WithEvents btnXml As ISL.Controles.Boton
End Class
