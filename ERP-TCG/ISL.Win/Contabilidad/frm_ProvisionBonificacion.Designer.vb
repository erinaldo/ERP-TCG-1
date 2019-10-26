<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProvisionBonificacion
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.agrDatosBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.decTipoCambio = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnCargarDatos = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnBuscar = New Infragistics.Win.Misc.UltraButton()
        Me.txtPlanilla = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.fecPeriodo = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecFin = New System.Windows.Forms.DateTimePicker()
        Me.fecInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoBono = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.griProvisionar = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBusqueda.SuspendLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoBono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griProvisionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agrDatosBusqueda
        '
        Me.agrDatosBusqueda.Controls.Add(Me.decTipoCambio)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel6)
        Me.agrDatosBusqueda.Controls.Add(Me.btnCargarDatos)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel5)
        Me.agrDatosBusqueda.Controls.Add(Me.btnBuscar)
        Me.agrDatosBusqueda.Controls.Add(Me.txtPlanilla)
        Me.agrDatosBusqueda.Controls.Add(Me.fecPeriodo)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel4)
        Me.agrDatosBusqueda.Controls.Add(Me.fecFin)
        Me.agrDatosBusqueda.Controls.Add(Me.fecInicio)
        Me.agrDatosBusqueda.Controls.Add(Me.cboTipoBono)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel3)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel2)
        Me.agrDatosBusqueda.Controls.Add(Me.UltraLabel1)
        Me.agrDatosBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatosBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrDatosBusqueda.Name = "agrDatosBusqueda"
        Me.agrDatosBusqueda.Size = New System.Drawing.Size(1182, 66)
        Me.agrDatosBusqueda.TabIndex = 0
        Me.agrDatosBusqueda.Text = "Datos de Busqueda"
        Me.agrDatosBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTipoCambio
        '
        Me.decTipoCambio.Location = New System.Drawing.Point(1086, 26)
        Me.decTipoCambio.MaskInput = "{double:4.4}"
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.Size = New System.Drawing.Size(86, 22)
        Me.decTipoCambio.TabIndex = 13
        '
        'UltraLabel6
        '
        Appearance1.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel6.Appearance = Appearance1
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(1056, 29)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(24, 15)
        Me.UltraLabel6.TabIndex = 12
        Me.UltraLabel6.Text = "T.C."
        '
        'btnCargarDatos
        '
        Appearance2.BackColor = System.Drawing.Color.Transparent
        Me.btnCargarDatos.Appearance = Appearance2
        Me.btnCargarDatos.AutoSize = True
        Me.btnCargarDatos.Location = New System.Drawing.Point(951, 24)
        Me.btnCargarDatos.Name = "btnCargarDatos"
        Me.btnCargarDatos.Size = New System.Drawing.Size(79, 25)
        Me.btnCargarDatos.TabIndex = 11
        Me.btnCargarDatos.Text = "Cargar Datos"
        '
        'UltraLabel5
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel5.Appearance = Appearance3
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(702, 30)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(93, 15)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Tipo Bonificacion:"
        '
        'btnBuscar
        '
        Appearance4.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.Appearance = Appearance4
        Me.btnBuscar.AutoSize = True
        Me.btnBuscar.Location = New System.Drawing.Point(233, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(10, 10)
        Me.btnBuscar.TabIndex = 9
        '
        'txtPlanilla
        '
        Me.txtPlanilla.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.txtPlanilla.Location = New System.Drawing.Point(310, 26)
        Me.txtPlanilla.Name = "txtPlanilla"
        Me.txtPlanilla.ReadOnly = True
        Me.txtPlanilla.Size = New System.Drawing.Size(100, 22)
        Me.txtPlanilla.TabIndex = 8
        '
        'fecPeriodo
        '
        Me.fecPeriodo.CustomFormat = "MMMM/yyyy"
        Me.fecPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fecPeriodo.Location = New System.Drawing.Point(68, 27)
        Me.fecPeriodo.Name = "fecPeriodo"
        Me.fecPeriodo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fecPeriodo.ShowUpDown = True
        Me.fecPeriodo.Size = New System.Drawing.Size(159, 21)
        Me.fecPeriodo.TabIndex = 7
        '
        'UltraLabel4
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel4.Appearance = Appearance5
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(12, 30)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(50, 15)
        Me.UltraLabel4.TabIndex = 6
        Me.UltraLabel4.Text = "Ejercicio:"
        '
        'fecFin
        '
        Me.fecFin.Enabled = False
        Me.fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFin.Location = New System.Drawing.Point(618, 27)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(78, 21)
        Me.fecFin.TabIndex = 5
        '
        'fecInicio
        '
        Me.fecInicio.Enabled = False
        Me.fecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicio.Location = New System.Drawing.Point(481, 27)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(78, 21)
        Me.fecInicio.TabIndex = 4
        '
        'cboTipoBono
        '
        Me.cboTipoBono.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboTipoBono.Location = New System.Drawing.Point(801, 26)
        Me.cboTipoBono.Name = "cboTipoBono"
        Me.cboTipoBono.Size = New System.Drawing.Size(144, 22)
        Me.cboTipoBono.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel3.Appearance = Appearance6
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(565, 30)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(47, 15)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Fec. Fin:"
        '
        'UltraLabel2
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(416, 30)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel2.TabIndex = 1
        Me.UltraLabel2.Text = "Fec. Inicio:"
        '
        'UltraLabel1
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Me.UltraLabel1.Appearance = Appearance8
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(261, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(43, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Planilla:"
        '
        'griProvisionar
        '
        Me.griProvisionar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProvisionar.Location = New System.Drawing.Point(0, 66)
        Me.griProvisionar.Name = "griProvisionar"
        Me.griProvisionar.Size = New System.Drawing.Size(1182, 263)
        Me.griProvisionar.TabIndex = 1
        Me.griProvisionar.Text = "UltraGrid1"
        '
        'frm_ProvisionBonificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 329)
        Me.Controls.Add(Me.griProvisionar)
        Me.Controls.Add(Me.agrDatosBusqueda)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ProvisionBonificacion"
        Me.Text = "Provision de Bonificaciones"
        CType(Me.agrDatosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBusqueda.ResumeLayout(False)
        Me.agrDatosBusqueda.PerformLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoBono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griProvisionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents agrDatosBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoBono As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtPlanilla As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents fecPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnCargarDatos As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griProvisionar As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents decTipoCambio As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
End Class
