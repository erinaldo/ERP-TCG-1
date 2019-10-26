<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_HorarioTrabajador
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
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdHorario")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horario")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdHorario")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horario")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraInicio")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraFin")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdHorario")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horario")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreCompleto")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cargo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Area")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NombreCompleto")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cargo")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Area")
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoHorario")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraInicio")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("HoraFin")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Lunes")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Martes")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Miercoles")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jueves")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viernes")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sabado")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Domingo")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoHorario")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndHoraExtra")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoHorario")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraInicio")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("HoraFin")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Lunes")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Martes")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Miercoles")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jueves")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viernes")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sabado")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Domingo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoHorario")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndHoraExtra")
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
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHorTraDet = New ISL.Controles.Grilla(Me.components)
        Me.ogdHorarioTrabajador = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorialHorTra = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrOperaciones = New ISL.Controles.Agrupacion(Me.components)
        Me.griHorarioTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.odListar = New ISL.Controles.OrigenDatos(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Ficha1 = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.griHorarioDetalle = New ISL.Controles.Grilla(Me.components)
        Me.ogdHorarios = New ISL.Controles.OrigenDatos(Me.components)
        Me.agrProcesoNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.btnQuitar = New Infragistics.Win.Misc.UltraButton()
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTipoHorario = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
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
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadores = New ISL.Controles.Combo(Me.components)
        Me.ficHorarioTrabajador = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griHorTraDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdHorarioTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griHistorialHorTra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrOperaciones.SuspendLayout()
        CType(Me.griHorarioTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ficha1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.griHorarioDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrProcesoNegocio.SuspendLayout()
        CType(Me.cboTipoHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficHorarioTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficHorarioTrabajador.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griHorTraDet)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1045, 155)
        '
        'griHorTraDet
        '
        Me.griHorTraDet.DataSource = Me.ogdHorarioTrabajador
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn18.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 1
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 2
        UltraGridColumn16.Hidden = True
        UltraGridColumn29.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn29.Width = 56
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn17.Header.VisiblePosition = 9
        UltraGridColumn17.Width = 278
        UltraGridColumn53.Header.VisiblePosition = 7
        UltraGridColumn54.Header.VisiblePosition = 8
        UltraGridColumn30.Header.VisiblePosition = 4
        UltraGridColumn30.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 6
        UltraGridColumn55.Width = 153
        UltraGridColumn31.Header.VisiblePosition = 11
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn32.Hidden = True
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.MaskInput = "{LOC}hh:mm"
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn21.Header.VisiblePosition = 5
        UltraGridColumn21.MaskInput = "{LOC}hh:mm"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn15, UltraGridColumn16, UltraGridColumn29, UltraGridColumn17, UltraGridColumn53, UltraGridColumn54, UltraGridColumn30, UltraGridColumn55, UltraGridColumn31, UltraGridColumn32, UltraGridColumn20, UltraGridColumn21})
        Me.griHorTraDet.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griHorTraDet.DisplayLayout.MaxColScrollRegions = 1
        Me.griHorTraDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorTraDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorTraDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHorTraDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHorTraDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHorTraDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHorTraDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHorTraDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHorTraDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHorTraDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHorTraDet.Location = New System.Drawing.Point(0, 0)
        Me.griHorTraDet.Name = "griHorTraDet"
        Me.griHorTraDet.Size = New System.Drawing.Size(1045, 155)
        Me.griHorTraDet.TabIndex = 12
        '
        'ogdHorarioTrabajador
        '
        UltraDataColumn4.DataType = GetType(Boolean)
        UltraDataColumn6.DataType = GetType(Date)
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Date)
        UltraDataColumn13.DataType = GetType(Date)
        Me.ogdHorarioTrabajador.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griHistorialHorTra)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1045, 155)
        '
        'griHistorialHorTra
        '
        Me.griHistorialHorTra.DataSource = Me.ogdHorarioTrabajador
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 2
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn59.Header.VisiblePosition = 9
        UltraGridColumn59.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn59.Width = 56
        UltraGridColumn60.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn60.Header.VisiblePosition = 8
        UltraGridColumn60.Width = 304
        UltraGridColumn61.Header.VisiblePosition = 6
        UltraGridColumn62.Header.VisiblePosition = 7
        UltraGridColumn63.Header.VisiblePosition = 10
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn64.Header.VisiblePosition = 5
        UltraGridColumn64.Width = 233
        UltraGridColumn65.Header.VisiblePosition = 11
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 12
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn67.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn67.Header.VisiblePosition = 3
        UltraGridColumn67.MaskInput = "{LOC}hh:mm"
        UltraGridColumn67.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn68.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn68.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn68.Header.VisiblePosition = 4
        UltraGridColumn68.MaskInput = "{LOC}hh:mm"
        UltraGridColumn68.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68})
        Me.griHistorialHorTra.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griHistorialHorTra.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorialHorTra.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHistorialHorTra.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHistorialHorTra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griHistorialHorTra.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHistorialHorTra.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHistorialHorTra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHistorialHorTra.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHistorialHorTra.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHistorialHorTra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorialHorTra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorialHorTra.Location = New System.Drawing.Point(0, 0)
        Me.griHistorialHorTra.Name = "griHistorialHorTra"
        Me.griHistorialHorTra.Size = New System.Drawing.Size(1045, 155)
        Me.griHistorialHorTra.TabIndex = 15
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.agrOperaciones)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1047, 457)
        '
        'agrOperaciones
        '
        Me.agrOperaciones.Controls.Add(Me.griHorarioTrabajador)
        Me.agrOperaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrOperaciones.ForeColor = System.Drawing.Color.Black
        Me.agrOperaciones.Location = New System.Drawing.Point(0, 0)
        Me.agrOperaciones.Name = "agrOperaciones"
        Me.agrOperaciones.Size = New System.Drawing.Size(1047, 457)
        Me.agrOperaciones.TabIndex = 3
        Me.agrOperaciones.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'griHorarioTrabajador
        '
        Me.griHorarioTrabajador.DataSource = Me.odListar
        UltraGridColumn36.Header.VisiblePosition = 4
        UltraGridColumn36.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 0
        UltraGridColumn70.Header.VisiblePosition = 1
        UltraGridColumn70.Width = 298
        UltraGridColumn71.Header.VisiblePosition = 2
        UltraGridColumn71.Width = 149
        UltraGridColumn35.Header.VisiblePosition = 3
        UltraGridColumn35.Width = 107
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn36, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn35})
        Me.griHorarioTrabajador.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griHorarioTrabajador.DisplayLayout.MaxColScrollRegions = 1
        Me.griHorarioTrabajador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHorarioTrabajador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHorarioTrabajador.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHorarioTrabajador.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHorarioTrabajador.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHorarioTrabajador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHorarioTrabajador.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHorarioTrabajador.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHorarioTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHorarioTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.griHorarioTrabajador.Location = New System.Drawing.Point(2, 2)
        Me.griHorarioTrabajador.Name = "griHorarioTrabajador"
        Me.griHorarioTrabajador.Size = New System.Drawing.Size(1043, 453)
        Me.griHorarioTrabajador.TabIndex = 7
        '
        'odListar
        '
        Me.odListar.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Ficha1)
        Me.utpDetalle.Controls.Add(Me.Agrupacion1)
        Me.utpDetalle.Controls.Add(Me.agrProcesoNegocio)
        Me.utpDetalle.Enabled = False
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1047, 457)
        '
        'Ficha1
        '
        Me.Ficha1.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl1)
        Me.Ficha1.Controls.Add(Me.UltraTabPageControl2)
        Me.Ficha1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ficha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ficha1.Location = New System.Drawing.Point(0, 279)
        Me.Ficha1.Name = "Ficha1"
        Me.Ficha1.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.Ficha1.Size = New System.Drawing.Size(1047, 178)
        Me.Ficha1.TabIndex = 2
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Vigente"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Historial"
        Me.Ficha1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4})
        Me.Ficha1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1045, 155)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.griHorarioDetalle)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 169)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1047, 110)
        Me.Agrupacion1.TabIndex = 1
        Me.Agrupacion1.Text = "DetalleHorario"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griHorarioDetalle
        '
        Me.griHorarioDetalle.DataSource = Me.ogdHorarios
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.Header.Caption = "TipoHorario"
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn38.Width = 306
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.MaskInput = "{LOC}hh:mm"
        UltraGridColumn39.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn40.MaskInput = "{LOC}hh:mm"
        UltraGridColumn40.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Time
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn41.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn41.Width = 64
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn42.Header.VisiblePosition = 6
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn42.Width = 52
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn43.Width = 65
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn44.Width = 57
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn45.Width = 58
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn46.Width = 64
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn47.Width = 63
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn48.Header.VisiblePosition = 12
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn48.Width = 56
        UltraGridColumn49.Header.VisiblePosition = 3
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 13
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 15
        UltraGridColumn52.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 16
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn1})
        Me.griHorarioDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griHorarioDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griHorarioDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHorarioDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHorarioDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griHorarioDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHorarioDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griHorarioDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHorarioDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHorarioDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHorarioDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHorarioDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHorarioDetalle.Location = New System.Drawing.Point(3, 16)
        Me.griHorarioDetalle.Name = "griHorarioDetalle"
        Me.griHorarioDetalle.Size = New System.Drawing.Size(1041, 91)
        Me.griHorarioDetalle.TabIndex = 12
        '
        'ogdHorarios
        '
        UltraDataColumn21.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Boolean)
        UltraDataColumn24.DataType = GetType(Boolean)
        UltraDataColumn25.DataType = GetType(Boolean)
        UltraDataColumn26.DataType = GetType(Boolean)
        UltraDataColumn27.DataType = GetType(Boolean)
        UltraDataColumn28.DataType = GetType(Boolean)
        UltraDataColumn29.DataType = GetType(Boolean)
        UltraDataColumn30.DataType = GetType(Boolean)
        UltraDataColumn31.DataType = GetType(Boolean)
        UltraDataColumn35.DataType = GetType(Boolean)
        Me.ogdHorarios.Band.Columns.AddRange(New Object() {UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
        '
        'agrProcesoNegocio
        '
        Me.agrProcesoNegocio.Controls.Add(Me.btnQuitar)
        Me.agrProcesoNegocio.Controls.Add(Me.btnAgregar)
        Me.agrProcesoNegocio.Controls.Add(Me.dtpFecha)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta9)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTipoHorario)
        Me.agrProcesoNegocio.Controls.Add(Me.Etiqueta3)
        Me.agrProcesoNegocio.Controls.Add(Me.agrDatosBasicos)
        Me.agrProcesoNegocio.Controls.Add(Me.FotoTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.etiTrabajador)
        Me.agrProcesoNegocio.Controls.Add(Me.cboTrabajadores)
        Me.agrProcesoNegocio.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrProcesoNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrProcesoNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrProcesoNegocio.Location = New System.Drawing.Point(0, 0)
        Me.agrProcesoNegocio.Name = "agrProcesoNegocio"
        Me.agrProcesoNegocio.Size = New System.Drawing.Size(1047, 169)
        Me.agrProcesoNegocio.TabIndex = 0
        Me.agrProcesoNegocio.Text = "Datos"
        Me.agrProcesoNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnQuitar
        '
        Appearance1.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnQuitar.Appearance = Appearance1
        Me.btnQuitar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnQuitar.Location = New System.Drawing.Point(252, 110)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(30, 30)
        Me.btnQuitar.TabIndex = 357
        '
        'btnAgregar
        '
        Appearance2.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.btnAgregar.Appearance = Appearance2
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(216, 110)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 356
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(94, 114)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(114, 20)
        Me.dtpFecha.TabIndex = 247
        '
        'Etiqueta9
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance3
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(24, 79)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta9.TabIndex = 246
        Me.Etiqueta9.Text = "TipoHorario:"
        '
        'cboTipoHorario
        '
        Appearance4.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario.Appearance = Appearance4
        Me.cboTipoHorario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoHorario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoHorario.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoHorario.ForeColor = System.Drawing.Color.Black
        Me.cboTipoHorario.Location = New System.Drawing.Point(94, 77)
        Me.cboTipoHorario.Name = "cboTipoHorario"
        Me.cboTipoHorario.Size = New System.Drawing.Size(317, 21)
        Me.cboTipoHorario.TabIndex = 4
        Me.cboTipoHorario.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance5.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance5
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(51, 114)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta3.TabIndex = 242
        Me.Etiqueta3.Text = "Fecha:"
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
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.Location = New System.Drawing.Point(672, 22)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(308, 129)
        Me.agrDatosBasicos.TabIndex = 237
        Me.agrDatosBasicos.Text = "Datos Básicos del Trabajador"
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'verActivo
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.verActivo.Appearance = Appearance6
        Me.verActivo.AutoSize = True
        Me.verActivo.BackColor = System.Drawing.Color.Transparent
        Me.verActivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.Black
        Me.verActivo.Location = New System.Drawing.Point(110, 106)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(51, 17)
        Me.verActivo.TabIndex = 235
        Me.verActivo.TabStop = False
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'fecFechaIngreso
        '
        Appearance7.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Appearance = Appearance7
        Me.fecFechaIngreso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.fecFechaIngreso.Location = New System.Drawing.Point(109, 81)
        Me.fecFechaIngreso.Name = "fecFechaIngreso"
        Me.fecFechaIngreso.ReadOnly = True
        Me.fecFechaIngreso.Size = New System.Drawing.Size(90, 21)
        Me.fecFechaIngreso.TabIndex = 103
        Me.fecFechaIngreso.TabStop = False
        '
        'chkDisponible
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.BackColor2 = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.chkDisponible.Appearance = Appearance8
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.BackColor = System.Drawing.Color.Transparent
        Me.chkDisponible.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkDisponible.Enabled = False
        Me.chkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisponible.ForeColor = System.Drawing.Color.Black
        Me.chkDisponible.Location = New System.Drawing.Point(7, 106)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(73, 17)
        Me.chkDisponible.TabIndex = 104
        Me.chkDisponible.TabStop = False
        Me.chkDisponible.Text = "Disponible"
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(60, 52)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(222, 21)
        Me.txtCargo.TabIndex = 102
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiFechaIngreso
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.etiFechaIngreso.Appearance = Appearance9
        Me.etiFechaIngreso.AutoSize = True
        Me.etiFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.etiFechaIngreso.Location = New System.Drawing.Point(7, 83)
        Me.etiFechaIngreso.Name = "etiFechaIngreso"
        Me.etiFechaIngreso.Size = New System.Drawing.Size(95, 14)
        Me.etiFechaIngreso.TabIndex = 0
        Me.etiFechaIngreso.Text = "Fecha de Ingreso :"
        '
        'etiCargo
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.etiCargo.Appearance = Appearance10
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(7, 56)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(40, 14)
        Me.etiCargo.TabIndex = 0
        Me.etiCargo.Text = "Cargo :"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(60, 25)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(222, 21)
        Me.txtArea.TabIndex = 100
        Me.txtArea.TabStop = False
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.etiArea.Appearance = Appearance11
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(7, 29)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(33, 14)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area :"
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(552, 22)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(104, 141)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 236
        Me.FotoTrabajador.TabStop = False
        Me.FotoTrabajador.Visible = False
        '
        'etiTrabajador
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.etiTrabajador.Appearance = Appearance12
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(29, 45)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(60, 14)
        Me.etiTrabajador.TabIndex = 235
        Me.etiTrabajador.Text = "Trabajador:"
        '
        'cboTrabajadores
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Appearance = Appearance13
        Me.cboTrabajadores.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTrabajadores.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadores.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadores.Location = New System.Drawing.Point(94, 43)
        Me.cboTrabajadores.Name = "cboTrabajadores"
        Me.cboTrabajadores.Size = New System.Drawing.Size(352, 21)
        Me.cboTrabajadores.TabIndex = 1
        Me.cboTrabajadores.ValueMember = "Id"
        '
        'ficHorarioTrabajador
        '
        Me.ficHorarioTrabajador.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficHorarioTrabajador.Controls.Add(Me.UltraTabPageControl7)
        Me.ficHorarioTrabajador.Controls.Add(Me.utpDetalle)
        Me.ficHorarioTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficHorarioTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficHorarioTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ficHorarioTrabajador.Name = "ficHorarioTrabajador"
        Me.ficHorarioTrabajador.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficHorarioTrabajador.Size = New System.Drawing.Size(1049, 480)
        Me.ficHorarioTrabajador.TabIndex = 9
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficHorarioTrabajador.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficHorarioTrabajador.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1047, 457)
        '
        'frm_HorarioTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 480)
        Me.Controls.Add(Me.ficHorarioTrabajador)
        Me.Name = "frm_HorarioTrabajador"
        Me.Text = "Horario Trabajador"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griHorTraDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdHorarioTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griHistorialHorTra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.agrOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrOperaciones.ResumeLayout(False)
        CType(Me.griHorarioTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Ficha1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ficha1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.griHorarioDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrProcesoNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrProcesoNegocio.ResumeLayout(False)
        Me.agrProcesoNegocio.PerformLayout()
        CType(Me.cboTipoHorario, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ficHorarioTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficHorarioTrabajador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficHorarioTrabajador As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrOperaciones As ISL.Controles.Agrupacion
    Friend WithEvents griHorarioTrabajador As ISL.Controles.Grilla
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrProcesoNegocio As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoHorario As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
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
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadores As ISL.Controles.Combo
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnQuitar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griHorarioDetalle As ISL.Controles.Grilla
    Friend WithEvents ogdHorarios As ISL.Controles.OrigenDatos
    Friend WithEvents ogdHorarioTrabajador As ISL.Controles.OrigenDatos
    Friend WithEvents Ficha1 As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griHistorialHorTra As ISL.Controles.Grilla
    Friend WithEvents odListar As ISL.Controles.OrigenDatos
    Friend WithEvents griHorTraDet As ISL.Controles.Grilla
End Class
