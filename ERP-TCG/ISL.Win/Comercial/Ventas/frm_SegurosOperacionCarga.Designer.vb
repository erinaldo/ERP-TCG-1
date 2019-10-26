<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SegurosOperacionCarga
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
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAsegurado")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoAsegurado")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SegurosOperacionCarga))
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClienteViajePrima")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaViaje")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImporteSeguro")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Factor1")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrimaReal")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrimaMinima")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Factor")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrimaTotal")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClienteViajePrima")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaViaje")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImporteSeguro")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Factor1")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrimaReal")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrimaMinima")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Factor")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrimaTotal")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
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
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPeriodo")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Periodo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCambio")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalViajes")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PrimaTotal")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Periodo")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCambio")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalViajes")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PrimaTotal")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griClientePrima = New ISL.Controles.Grilla(Me.components)
        Me.odClientePrima = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.btnVigencia = New ISL.Controles.Boton(Me.components)
        Me.btnModificar = New ISL.Controles.Boton(Me.components)
        Me.btnNuevo = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.btnCancelar = New ISL.Controles.Boton(Me.components)
        Me.btnGuardar = New ISL.Controles.Boton(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cbVigencia = New System.Windows.Forms.CheckBox()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTextEditor1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel17 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griViajesCargas = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.btnConsultar = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.fecFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox7 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griPrimaSeguroCon = New ISL.Controles.Grilla(Me.components)
        Me.odPrimaSeguroCon = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFactor1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnConsolidar = New Infragistics.Win.Misc.UltraButton()
        Me.txtTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesCon = New ISL.Controles.Combo(Me.components)
        Me.Año1 = New ISL.Win.Año()
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero1 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero4 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero5 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero6 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficPrimaSeguro = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.griSegurosCarga = New ISL.Controles.Grilla(Me.components)
        Me.MenuContex = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Actualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimaSeguroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odClieViajePrima = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMesLista = New ISL.Controles.Combo(Me.components)
        Me.AñoLista = New ISL.Win.Año()
        Me.numAño = New ISL.Controles.NumeroEntero(Me.components)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero2 = New ISL.Controles.NumeroEntero(Me.components)
        Me.NumeroEntero3 = New ISL.Controles.NumeroEntero(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficSeguroDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ficSegurosCarga = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griClientePrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odClientePrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.griViajesCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox7.SuspendLayout()
        CType(Me.griPrimaSeguroCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odPrimaSeguroCon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFactor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMesCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Año1.SuspendLayout()
        CType(Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ficPrimaSeguro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficPrimaSeguro.SuspendLayout()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.griSegurosCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContex.SuspendLayout()
        CType(Me.odClieViajePrima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.cboMesLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AñoLista.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ficSeguroDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficSeguroDetalle.SuspendLayout()
        CType(Me.ficSegurosCarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficSegurosCarga.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griClientePrima)
        Me.UltraTabPageControl3.Controls.Add(Me.agrMenuLista)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1155, 492)
        '
        'griClientePrima
        '
        Me.griClientePrima.DataSource = Me.odClientePrima
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griClientePrima.DisplayLayout.Appearance = Appearance1
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 1
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn22.Width = 230
        UltraGridColumn1.Header.VisiblePosition = 3
        UltraGridColumn1.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 4
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn8.CellAppearance = Appearance2
        UltraGridColumn8.Format = "#,###,###,##0.0000"
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn8.Header.Appearance = Appearance3
        UltraGridColumn8.Header.VisiblePosition = 5
        UltraGridColumn8.MaskInput = "{double:9.4}"
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn8.Width = 112
        UltraGridColumn9.Header.VisiblePosition = 6
        UltraGridColumn9.Width = 208
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn11.Header.VisiblePosition = 8
        UltraGridColumn12.Header.VisiblePosition = 9
        UltraGridColumn31.Header.VisiblePosition = 11
        UltraGridColumn31.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 10
        UltraGridColumn30.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 12
        UltraGridColumn32.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn21, UltraGridColumn22, UltraGridColumn1, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn31, UltraGridColumn30, UltraGridColumn32})
        Me.griClientePrima.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griClientePrima.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griClientePrima.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.griClientePrima.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griClientePrima.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.griClientePrima.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griClientePrima.DisplayLayout.GroupByBox.Hidden = True
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griClientePrima.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.griClientePrima.DisplayLayout.MaxColScrollRegions = 1
        Me.griClientePrima.DisplayLayout.MaxRowScrollRegions = 1
        Me.griClientePrima.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griClientePrima.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griClientePrima.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griClientePrima.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griClientePrima.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griClientePrima.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griClientePrima.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griClientePrima.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance7.BorderColor = System.Drawing.Color.Silver
        Me.griClientePrima.DisplayLayout.Override.RowAppearance = Appearance7
        Me.griClientePrima.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griClientePrima.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griClientePrima.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griClientePrima.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griClientePrima.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griClientePrima.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griClientePrima.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griClientePrima.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griClientePrima.Location = New System.Drawing.Point(0, 30)
        Me.griClientePrima.Name = "griClientePrima"
        Me.griClientePrima.Size = New System.Drawing.Size(1155, 462)
        Me.griClientePrima.TabIndex = 34
        Me.griClientePrima.Text = "Grilla2"
        '
        'odClientePrima
        '
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn9.DataType = GetType(Date)
        UltraDataColumn10.DataType = GetType(Boolean)
        UltraDataColumn12.DataType = GetType(Date)
        UltraDataColumn13.DataType = GetType(Boolean)
        Me.odClientePrima.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13})
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEliminar)
        Me.agrMenuLista.Controls.Add(Me.btnVigencia)
        Me.agrMenuLista.Controls.Add(Me.btnModificar)
        Me.agrMenuLista.Controls.Add(Me.btnNuevo)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(0, 0)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1155, 30)
        Me.agrMenuLista.TabIndex = 33
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance8.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance8.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminar.Appearance = Appearance8
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(280, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 24)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnVigencia
        '
        Appearance9.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance9.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnVigencia.Appearance = Appearance9
        Me.btnVigencia.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnVigencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVigencia.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVigencia.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVigencia.ForeColor = System.Drawing.Color.Black
        Me.btnVigencia.Location = New System.Drawing.Point(160, 3)
        Me.btnVigencia.Name = "btnVigencia"
        Me.btnVigencia.Size = New System.Drawing.Size(120, 24)
        Me.btnVigencia.TabIndex = 2
        Me.btnVigencia.Text = "CambiarVigencia"
        Me.btnVigencia.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnModificar
        '
        Appearance10.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance10.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.btnModificar.Appearance = Appearance10
        Me.btnModificar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnModificar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.Location = New System.Drawing.Point(81, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(79, 24)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnNuevo
        '
        Appearance11.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance11.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.btnNuevo.Appearance = Appearance11
        Me.btnNuevo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.Black
        Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(78, 24)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl6.Enabled = False
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1155, 492)
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.btnCancelar)
        Me.UltraGroupBox3.Controls.Add(Me.btnGuardar)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox3.Controls.Add(Me.cbVigencia)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel10)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel9)
        Me.UltraGroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.UltraGroupBox3.Controls.Add(Me.dtpFechaIni)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox3.Controls.Add(Me.UltraTextEditor1)
        Me.UltraGroupBox3.Controls.Add(Me.txtTotal)
        Me.UltraGroupBox3.Controls.Add(Me.cboMoneda)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox3.Controls.Add(Me.cboCliente)
        Me.UltraGroupBox3.Controls.Add(Me.UltraLabel17)
        Me.UltraGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(1155, 492)
        Me.UltraGroupBox3.TabIndex = 12
        Me.UltraGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCancelar
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Appearance12.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        Me.btnCancelar.Appearance = Appearance12
        Me.btnCancelar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(248, 224)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 24)
        Me.btnCancelar.TabIndex = 343
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnGuardar
        '
        Appearance13.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance13.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        Me.btnGuardar.Appearance = Appearance13
        Me.btnGuardar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(118, 224)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(78, 24)
        Me.btnGuardar.TabIndex = 342
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'UltraLabel6
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Appearance14.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance14
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(66, 206)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(50, 15)
        Me.UltraLabel6.TabIndex = 341
        Me.UltraLabel6.Text = "Vigencia:"
        Me.UltraLabel6.Visible = False
        '
        'cbVigencia
        '
        Me.cbVigencia.AutoSize = True
        Me.cbVigencia.BackColor = System.Drawing.Color.Transparent
        Me.cbVigencia.Checked = True
        Me.cbVigencia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbVigencia.ForeColor = System.Drawing.Color.Navy
        Me.cbVigencia.Location = New System.Drawing.Point(122, 206)
        Me.cbVigencia.Name = "cbVigencia"
        Me.cbVigencia.Size = New System.Drawing.Size(15, 14)
        Me.cbVigencia.TabIndex = 340
        Me.cbVigencia.UseVisualStyleBackColor = False
        Me.cbVigencia.Visible = False
        '
        'UltraLabel11
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance15
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(77, 76)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel11.TabIndex = 339
        Me.UltraLabel11.Text = "Monto:"
        '
        'UltraLabel10
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance16
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel10.Location = New System.Drawing.Point(60, 183)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(56, 15)
        Me.UltraLabel10.TabIndex = 338
        Me.UltraLabel10.Text = "Fecha Fin:"
        Me.UltraLabel10.Visible = False
        '
        'UltraLabel9
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Appearance17.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance17
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel9.Location = New System.Drawing.Point(48, 153)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(68, 15)
        Me.UltraLabel9.TabIndex = 337
        Me.UltraLabel9.Text = "Fecha Inicio:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(122, 180)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(103, 21)
        Me.DateTimePicker2.TabIndex = 336
        Me.DateTimePicker2.Visible = False
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(122, 150)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(103, 21)
        Me.dtpFechaIni.TabIndex = 335
        '
        'UltraLabel8
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance18
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(47, 102)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel8.TabIndex = 334
        Me.UltraLabel8.Text = "Observacion:"
        '
        'UltraTextEditor1
        '
        Me.UltraTextEditor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UltraTextEditor1.Location = New System.Drawing.Point(122, 99)
        Me.UltraTextEditor1.Multiline = True
        Me.UltraTextEditor1.Name = "UltraTextEditor1"
        Me.UltraTextEditor1.Size = New System.Drawing.Size(323, 45)
        Me.UltraTextEditor1.TabIndex = 333
        '
        'txtTotal
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Appearance = Appearance19
        Me.txtTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(122, 72)
        Me.txtTotal.MaskInput = "{LOC}nn,nnn,nnn,nnn.nnnn"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.NullText = "0.00"
        Me.txtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTotal.Size = New System.Drawing.Size(119, 21)
        Me.txtTotal.TabIndex = 289
        '
        'cboMoneda
        '
        Appearance20.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance20
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownListWidth = 180
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(122, 45)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(119, 21)
        Me.cboMoneda.TabIndex = 9
        Me.cboMoneda.ValueMember = "Id"
        '
        'UltraLabel5
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Appearance21.ForeColor = System.Drawing.Color.Navy
        Appearance21.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance21
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(68, 49)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "Moneda:"
        '
        'cboCliente
        '
        Appearance22.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance22
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance23.Image = CType(resources.GetObject("Appearance23.Image"), Object)
        Appearance23.ImageHAlign = Infragistics.Win.HAlign.Center
        EditorButton1.Appearance = Appearance23
        Me.cboCliente.ButtonsRight.Add(EditorButton1)
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Location = New System.Drawing.Point(122, 18)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(323, 21)
        Me.cboCliente.TabIndex = 5
        Me.cboCliente.ValueMember = "Id"
        '
        'UltraLabel17
        '
        Appearance24.BackColor = System.Drawing.Color.Transparent
        Appearance24.ForeColor = System.Drawing.Color.Navy
        Appearance24.TextVAlignAsString = "Middle"
        Me.UltraLabel17.Appearance = Appearance24
        Me.UltraLabel17.AutoSize = True
        Me.UltraLabel17.Location = New System.Drawing.Point(73, 23)
        Me.UltraLabel17.Name = "UltraLabel17"
        Me.UltraLabel17.Size = New System.Drawing.Size(42, 15)
        Me.UltraLabel17.TabIndex = 4
        Me.UltraLabel17.Text = "Cliente:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1157, 515)
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Controls.Add(Me.griViajesCargas)
        Me.UltraGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 51)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(1157, 464)
        Me.UltraGroupBox5.TabIndex = 1
        Me.UltraGroupBox5.Text = "Cargas"
        Me.UltraGroupBox5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griViajesCargas
        '
        Me.griViajesCargas.ContextMenuStrip = Me.MenuContextual1
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griViajesCargas.DisplayLayout.Appearance = Appearance25
        Me.griViajesCargas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesCargas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.griViajesCargas.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesCargas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.griViajesCargas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesCargas.DisplayLayout.GroupByBox.Hidden = True
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesCargas.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.griViajesCargas.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesCargas.DisplayLayout.MaxRowScrollRegions = 1
        Me.griViajesCargas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesCargas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griViajesCargas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griViajesCargas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griViajesCargas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesCargas.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesCargas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesCargas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance29.BorderColor = System.Drawing.Color.Silver
        Me.griViajesCargas.DisplayLayout.Override.RowAppearance = Appearance29
        Me.griViajesCargas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesCargas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesCargas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajesCargas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griViajesCargas.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griViajesCargas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griViajesCargas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesCargas.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesCargas.Location = New System.Drawing.Point(3, 17)
        Me.griViajesCargas.Name = "griViajesCargas"
        Me.griViajesCargas.Size = New System.Drawing.Size(1151, 444)
        Me.griViajesCargas.TabIndex = 9
        Me.griViajesCargas.Text = "Grilla2"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(174, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItem1.Text = "Generar Cliente Ruta"
        Me.ToolStripMenuItem1.ToolTipText = "Crear Nuevo Cliente Ruta"
        Me.ToolStripMenuItem1.Visible = False
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Etiqueta2)
        Me.UltraGroupBox1.Controls.Add(Me.Colores4)
        Me.UltraGroupBox1.Controls.Add(Me.btnConsultar)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel3)
        Me.UltraGroupBox1.Controls.Add(Me.fecFechaInicio)
        Me.UltraGroupBox1.Controls.Add(Me.fecFechaFin)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1157, 51)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta2
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance30
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(458, 18)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(121, 14)
        Me.Etiqueta2.TabIndex = 41
        Me.Etiqueta2.Text = "Cargas No Registradas:"
        '
        'Colores4
        '
        Me.Colores4.Color = System.Drawing.Color.LightCoral
        Me.Colores4.Location = New System.Drawing.Point(585, 14)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(45, 22)
        Me.Colores4.TabIndex = 40
        Me.Colores4.Text = "LightCoral"
        '
        'btnConsultar
        '
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Appearance31.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnConsultar.Appearance = Appearance31
        Me.btnConsultar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultar.Location = New System.Drawing.Point(353, 10)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(96, 30)
        Me.btnConsultar.TabIndex = 22
        Me.btnConsultar.Text = "Consultar"
        '
        'UltraLabel4
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Appearance32.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance32
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(190, 18)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(37, 14)
        Me.UltraLabel4.TabIndex = 3
        Me.UltraLabel4.Text = "Hasta:"
        '
        'UltraLabel3
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Appearance33.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance33
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(21, 18)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(40, 14)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Desde:"
        '
        'fecFechaInicio
        '
        Me.fecFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaInicio.Location = New System.Drawing.Point(67, 15)
        Me.fecFechaInicio.Name = "fecFechaInicio"
        Me.fecFechaInicio.Size = New System.Drawing.Size(103, 21)
        Me.fecFechaInicio.TabIndex = 1
        '
        'fecFechaFin
        '
        Me.fecFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaFin.Location = New System.Drawing.Point(233, 15)
        Me.fecFechaFin.Name = "fecFechaFin"
        Me.fecFechaFin.Size = New System.Drawing.Size(103, 21)
        Me.fecFechaFin.TabIndex = 0
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox7)
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1157, 515)
        '
        'UltraGroupBox7
        '
        Me.UltraGroupBox7.Controls.Add(Me.griPrimaSeguroCon)
        Me.UltraGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox7.Location = New System.Drawing.Point(0, 66)
        Me.UltraGroupBox7.Name = "UltraGroupBox7"
        Me.UltraGroupBox7.Size = New System.Drawing.Size(1157, 449)
        Me.UltraGroupBox7.TabIndex = 1
        Me.UltraGroupBox7.Text = "Detalle"
        Me.UltraGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griPrimaSeguroCon
        '
        Me.griPrimaSeguroCon.DataSource = Me.odPrimaSeguroCon
        Appearance34.BackColor = System.Drawing.SystemColors.Window
        Appearance34.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griPrimaSeguroCon.DisplayLayout.Appearance = Appearance34
        UltraGridColumn15.Header.VisiblePosition = 0
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 1
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 2
        UltraGridColumn17.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Width = 230
        Appearance35.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance35
        Appearance36.TextHAlignAsString = "Right"
        UltraGridColumn34.Header.Appearance = Appearance36
        UltraGridColumn34.Header.VisiblePosition = 4
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance37
        UltraGridColumn35.Format = "#,###,###,##0.0000"
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn35.Header.Appearance = Appearance38
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridColumn35.MaskInput = "{double:9.4}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn35.Width = 114
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance39
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn36.Header.Appearance = Appearance40
        UltraGridColumn36.Header.VisiblePosition = 6
        UltraGridColumn36.MaskInput = "{double:9.4}"
        UltraGridColumn36.Width = 70
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance41
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn37.Header.Appearance = Appearance42
        UltraGridColumn37.Header.VisiblePosition = 7
        UltraGridColumn37.MaskInput = "{double:9.4}"
        UltraGridColumn37.Width = 96
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance43
        Appearance44.TextHAlignAsString = "Right"
        UltraGridColumn39.Header.Appearance = Appearance44
        UltraGridColumn39.Header.Caption = "DER EM"
        UltraGridColumn39.Header.VisiblePosition = 8
        UltraGridColumn39.MaskInput = "{double:9.4}"
        UltraGridColumn39.Width = 92
        Appearance45.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Right"
        UltraGridColumn40.Header.Appearance = Appearance46
        UltraGridColumn40.Header.Caption = "IGV"
        UltraGridColumn40.Header.VisiblePosition = 9
        UltraGridColumn40.MaskInput = "{double:9.4}"
        UltraGridColumn40.Width = 54
        Appearance47.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance47
        UltraGridColumn41.Format = "#,###,###,##0.0000"
        Appearance48.TextHAlignAsString = "Right"
        UltraGridColumn41.Header.Appearance = Appearance48
        UltraGridColumn41.Header.VisiblePosition = 10
        UltraGridColumn41.MaskInput = "{double:9.4}"
        UltraGridColumn41.Width = 108
        UltraGridColumn42.Header.VisiblePosition = 11
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 12
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 13
        UltraGridColumn44.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44})
        Me.griPrimaSeguroCon.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griPrimaSeguroCon.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPrimaSeguroCon.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance49.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance49.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance49.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance49.BorderColor = System.Drawing.SystemColors.Window
        Me.griPrimaSeguroCon.DisplayLayout.GroupByBox.Appearance = Appearance49
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPrimaSeguroCon.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance50
        Me.griPrimaSeguroCon.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griPrimaSeguroCon.DisplayLayout.GroupByBox.Hidden = True
        Appearance51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance51.BackColor2 = System.Drawing.SystemColors.Control
        Appearance51.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griPrimaSeguroCon.DisplayLayout.GroupByBox.PromptAppearance = Appearance51
        Me.griPrimaSeguroCon.DisplayLayout.MaxColScrollRegions = 1
        Me.griPrimaSeguroCon.DisplayLayout.MaxRowScrollRegions = 1
        Me.griPrimaSeguroCon.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griPrimaSeguroCon.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griPrimaSeguroCon.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPrimaSeguroCon.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griPrimaSeguroCon.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griPrimaSeguroCon.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griPrimaSeguroCon.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griPrimaSeguroCon.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griPrimaSeguroCon.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance52.BorderColor = System.Drawing.Color.Silver
        Me.griPrimaSeguroCon.DisplayLayout.Override.RowAppearance = Appearance52
        Me.griPrimaSeguroCon.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griPrimaSeguroCon.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griPrimaSeguroCon.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griPrimaSeguroCon.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griPrimaSeguroCon.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griPrimaSeguroCon.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griPrimaSeguroCon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griPrimaSeguroCon.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griPrimaSeguroCon.Location = New System.Drawing.Point(3, 17)
        Me.griPrimaSeguroCon.Name = "griPrimaSeguroCon"
        Me.griPrimaSeguroCon.Size = New System.Drawing.Size(1151, 429)
        Me.griPrimaSeguroCon.TabIndex = 10
        Me.griPrimaSeguroCon.Text = "Grilla2"
        '
        'odPrimaSeguroCon
        '
        UltraDataColumn18.DataType = GetType(Short)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Double)
        UltraDataColumn22.DataType = GetType(Double)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataColumn27.DataType = GetType(Boolean)
        Me.odPrimaSeguroCon.Band.Columns.AddRange(New Object() {UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27})
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox6.Controls.Add(Me.txtObservacion)
        Me.UltraGroupBox6.Controls.Add(Me.txtFactor1)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox6.Controls.Add(Me.btnConsolidar)
        Me.UltraGroupBox6.Controls.Add(Me.txtTC)
        Me.UltraGroupBox6.Controls.Add(Me.UltraLabel7)
        Me.UltraGroupBox6.Controls.Add(Me.Etiqueta4)
        Me.UltraGroupBox6.Controls.Add(Me.cboMesCon)
        Me.UltraGroupBox6.Controls.Add(Me.Año1)
        Me.UltraGroupBox6.Controls.Add(Me.Etiqueta5)
        Me.UltraGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(1157, 66)
        Me.UltraGroupBox6.TabIndex = 0
        Me.UltraGroupBox6.Text = "Datos"
        Me.UltraGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Appearance53.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance53
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(657, 30)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(69, 15)
        Me.UltraLabel2.TabIndex = 332
        Me.UltraLabel2.Text = "Observacion:"
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(732, 26)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(372, 22)
        Me.txtObservacion.TabIndex = 331
        '
        'txtFactor1
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.txtFactor1.Appearance = Appearance54
        Me.txtFactor1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFactor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactor1.ForeColor = System.Drawing.Color.Black
        Me.txtFactor1.Location = New System.Drawing.Point(469, 27)
        Me.txtFactor1.MaskInput = "{double:3.4}"
        Me.txtFactor1.Name = "txtFactor1"
        Me.txtFactor1.NullText = "0.00"
        Me.txtFactor1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtFactor1.Size = New System.Drawing.Size(65, 21)
        Me.txtFactor1.TabIndex = 330
        '
        'UltraLabel1
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Appearance55.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance55
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(424, 30)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(39, 15)
        Me.UltraLabel1.TabIndex = 329
        Me.UltraLabel1.Text = "Factor:"
        '
        'btnConsolidar
        '
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Appearance56.Image = Global.ISL.Win.My.Resources.Resources.Actualizar
        Me.btnConsolidar.Appearance = Appearance56
        Me.btnConsolidar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsolidar.Location = New System.Drawing.Point(540, 23)
        Me.btnConsolidar.Name = "btnConsolidar"
        Me.btnConsolidar.Size = New System.Drawing.Size(96, 30)
        Me.btnConsolidar.TabIndex = 328
        Me.btnConsolidar.Text = "Consolidar"
        '
        'txtTC
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Appearance = Appearance57
        Me.txtTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTC.ForeColor = System.Drawing.Color.Black
        Me.txtTC.Location = New System.Drawing.Point(353, 27)
        Me.txtTC.MaskInput = "{double:3.4}"
        Me.txtTC.Name = "txtTC"
        Me.txtTC.NullText = "0.00"
        Me.txtTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTC.Size = New System.Drawing.Size(65, 21)
        Me.txtTC.TabIndex = 327
        '
        'UltraLabel7
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Appearance58.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance58
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel7.Location = New System.Drawing.Point(327, 31)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(25, 15)
        Me.UltraLabel7.TabIndex = 326
        Me.UltraLabel7.Text = "T.C:"
        '
        'Etiqueta4
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance59
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(135, 31)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta4.TabIndex = 292
        Me.Etiqueta4.Text = "Mes:"
        '
        'cboMesCon
        '
        Appearance60.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesCon.Appearance = Appearance60
        Me.cboMesCon.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesCon.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesCon.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesCon.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesCon.Location = New System.Drawing.Point(172, 28)
        Me.cboMesCon.Name = "cboMesCon"
        Me.cboMesCon.Size = New System.Drawing.Size(149, 21)
        Me.cboMesCon.TabIndex = 291
        Me.cboMesCon.ValueMember = "Id"
        '
        'Año1
        '
        Me.Año1.Año = 2016
        Me.Año1.AutoSize = True
        Me.Año1.BackColor = System.Drawing.Color.Transparent
        Me.Año1.Controls.Add(Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6)
        Me.Año1.Controls.Add(Me.NumeroEntero1)
        Me.Año1.Controls.Add(Me.NumeroEntero4)
        Me.Año1.Controls.Add(Me.NumeroEntero5)
        Me.Año1.Controls.Add(Me.NumeroEntero6)
        Me.Año1.Location = New System.Drawing.Point(76, 28)
        Me.Año1.Name = "Año1"
        Me.Año1.Size = New System.Drawing.Size(56, 24)
        Me.Año1.TabIndex = 290
        '
        'object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6
        '
        Appearance61.ForeColor = System.Drawing.Color.Black
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Appearance = Appearance61
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.ForeColor = System.Drawing.Color.Black
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.FormatString = ""
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Location = New System.Drawing.Point(1, 0)
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.MaskInput = "nnnn"
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.MaxValue = 2020
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.MinValue = 2000
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Name = "object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6"
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.NullText = "0"
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Size = New System.Drawing.Size(52, 21)
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.TabIndex = 0
        Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6.Value = 2014
        '
        'NumeroEntero1
        '
        Appearance62.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.Appearance = Appearance62
        Me.NumeroEntero1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero1.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero1.FormatString = ""
        Me.NumeroEntero1.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero1.MaskInput = "nnnn"
        Me.NumeroEntero1.MaxValue = 2020
        Me.NumeroEntero1.MinValue = 2000
        Me.NumeroEntero1.Name = "NumeroEntero1"
        Me.NumeroEntero1.NullText = "0"
        Me.NumeroEntero1.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero1.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero1.TabIndex = 0
        Me.NumeroEntero1.Value = 2014
        '
        'NumeroEntero4
        '
        Appearance63.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.Appearance = Appearance63
        Me.NumeroEntero4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero4.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero4.FormatString = ""
        Me.NumeroEntero4.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero4.MaskInput = "nnnn"
        Me.NumeroEntero4.MaxValue = 2020
        Me.NumeroEntero4.MinValue = 2000
        Me.NumeroEntero4.Name = "NumeroEntero4"
        Me.NumeroEntero4.NullText = "0"
        Me.NumeroEntero4.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero4.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero4.TabIndex = 0
        Me.NumeroEntero4.Value = 2013
        '
        'NumeroEntero5
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.Appearance = Appearance64
        Me.NumeroEntero5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero5.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero5.FormatString = ""
        Me.NumeroEntero5.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero5.MaskInput = "nnnn"
        Me.NumeroEntero5.MaxValue = 2020
        Me.NumeroEntero5.MinValue = 2000
        Me.NumeroEntero5.Name = "NumeroEntero5"
        Me.NumeroEntero5.NullText = "0"
        Me.NumeroEntero5.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero5.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero5.TabIndex = 0
        Me.NumeroEntero5.Value = 2013
        '
        'NumeroEntero6
        '
        Appearance65.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero6.Appearance = Appearance65
        Me.NumeroEntero6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero6.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero6.FormatString = ""
        Me.NumeroEntero6.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero6.MaskInput = "nnnn"
        Me.NumeroEntero6.MaxValue = 2020
        Me.NumeroEntero6.MinValue = 2000
        Me.NumeroEntero6.Name = "NumeroEntero6"
        Me.NumeroEntero6.NullText = "0"
        Me.NumeroEntero6.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero6.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero6.TabIndex = 0
        Me.NumeroEntero6.Value = 2012
        '
        'Etiqueta5
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance66
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(21, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta5.TabIndex = 289
        Me.Etiqueta5.Text = "Ejercicio:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ficPrimaSeguro)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1157, 515)
        '
        'ficPrimaSeguro
        '
        Me.ficPrimaSeguro.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficPrimaSeguro.Controls.Add(Me.UltraTabPageControl3)
        Me.ficPrimaSeguro.Controls.Add(Me.UltraTabPageControl6)
        Me.ficPrimaSeguro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficPrimaSeguro.Location = New System.Drawing.Point(0, 0)
        Me.ficPrimaSeguro.Name = "ficPrimaSeguro"
        Me.ficPrimaSeguro.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficPrimaSeguro.Size = New System.Drawing.Size(1157, 515)
        Me.ficPrimaSeguro.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficPrimaSeguro.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Lista"
        UltraTab7.TabPage = Me.UltraTabPageControl6
        UltraTab7.Text = "Mantenimiento"
        Me.ficPrimaSeguro.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab7})
        Me.ficPrimaSeguro.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1155, 492)
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl7.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1159, 538)
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.griSegurosCarga)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 62)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1159, 476)
        Me.UltraGroupBox4.TabIndex = 1
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griSegurosCarga
        '
        Me.griSegurosCarga.ContextMenuStrip = Me.MenuContex
        Me.griSegurosCarga.DataSource = Me.odClieViajePrima
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Appearance67.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griSegurosCarga.DisplayLayout.Appearance = Appearance67
        UltraGridColumn38.Header.VisiblePosition = 0
        UltraGridColumn38.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 9
        UltraGridColumn58.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 105
        Appearance68.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance68
        Appearance69.TextHAlignAsString = "Right"
        UltraGridColumn45.Header.Appearance = Appearance69
        UltraGridColumn45.Header.Caption = "Tipo Cambio"
        UltraGridColumn45.Header.VisiblePosition = 2
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn45.Width = 108
        Appearance70.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance70
        Appearance71.TextHAlignAsString = "Right"
        UltraGridColumn3.Header.Appearance = Appearance71
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn3.Width = 107
        Appearance72.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance72
        UltraGridColumn4.Format = "#,###,###,##0.0000"
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn4.Header.Appearance = Appearance73
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.MaskInput = "{double:9.4}"
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn4.Width = 100
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 231
        UltraGridColumn50.Header.VisiblePosition = 6
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 132
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 8
        UltraGridColumn52.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn38, UltraGridColumn58, UltraGridColumn2, UltraGridColumn45, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn50, UltraGridColumn6, UltraGridColumn52})
        Me.griSegurosCarga.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griSegurosCarga.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griSegurosCarga.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance74.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance74.BorderColor = System.Drawing.SystemColors.Window
        Me.griSegurosCarga.DisplayLayout.GroupByBox.Appearance = Appearance74
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griSegurosCarga.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance75
        Me.griSegurosCarga.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griSegurosCarga.DisplayLayout.GroupByBox.Hidden = True
        Appearance76.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance76.BackColor2 = System.Drawing.SystemColors.Control
        Appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griSegurosCarga.DisplayLayout.GroupByBox.PromptAppearance = Appearance76
        Me.griSegurosCarga.DisplayLayout.MaxColScrollRegions = 1
        Me.griSegurosCarga.DisplayLayout.MaxRowScrollRegions = 1
        Me.griSegurosCarga.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griSegurosCarga.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griSegurosCarga.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSegurosCarga.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griSegurosCarga.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griSegurosCarga.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griSegurosCarga.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griSegurosCarga.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griSegurosCarga.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance77.BorderColor = System.Drawing.Color.Silver
        Me.griSegurosCarga.DisplayLayout.Override.RowAppearance = Appearance77
        Me.griSegurosCarga.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griSegurosCarga.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griSegurosCarga.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griSegurosCarga.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griSegurosCarga.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griSegurosCarga.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griSegurosCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griSegurosCarga.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griSegurosCarga.Location = New System.Drawing.Point(3, 3)
        Me.griSegurosCarga.Name = "griSegurosCarga"
        Me.griSegurosCarga.Size = New System.Drawing.Size(1153, 470)
        Me.griSegurosCarga.TabIndex = 9
        Me.griSegurosCarga.Text = "Grilla2"
        '
        'MenuContex
        '
        Me.MenuContex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContex.ForeColor = System.Drawing.Color.Black
        Me.MenuContex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Actualizar, Me.Delete, Me.PrimaSeguroToolStripMenuItem})
        Me.MenuContex.Name = "MenuContextual1"
        Me.MenuContex.Size = New System.Drawing.Size(138, 92)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(137, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Actualizar
        '
        Me.Actualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(137, 22)
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(137, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'PrimaSeguroToolStripMenuItem
        '
        Me.PrimaSeguroToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.clipboard
        Me.PrimaSeguroToolStripMenuItem.Name = "PrimaSeguroToolStripMenuItem"
        Me.PrimaSeguroToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.PrimaSeguroToolStripMenuItem.Text = "Prima Seguro"
        '
        'odClieViajePrima
        '
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Short)
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn35.DataType = GetType(Date)
        UltraDataColumn37.DataType = GetType(Byte)
        Me.odClieViajePrima.Band.Columns.AddRange(New Object() {UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37})
        '
        'agrBusqueda
        '
        Me.agrBusqueda.Controls.Add(Me.Etiqueta1)
        Me.agrBusqueda.Controls.Add(Me.cboMesLista)
        Me.agrBusqueda.Controls.Add(Me.AñoLista)
        Me.agrBusqueda.Controls.Add(Me.Etiqueta3)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1159, 62)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "Búsqueda"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta1
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance78
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(127, 27)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(29, 14)
        Me.Etiqueta1.TabIndex = 288
        Me.Etiqueta1.Text = "Mes:"
        '
        'cboMesLista
        '
        Appearance79.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesLista.Appearance = Appearance79
        Me.cboMesLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboMesLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMesLista.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMesLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMesLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMesLista.Location = New System.Drawing.Point(162, 24)
        Me.cboMesLista.Name = "cboMesLista"
        Me.cboMesLista.Size = New System.Drawing.Size(144, 21)
        Me.cboMesLista.TabIndex = 287
        Me.cboMesLista.ValueMember = "Id"
        '
        'AñoLista
        '
        Me.AñoLista.Año = 2016
        Me.AñoLista.AutoSize = True
        Me.AñoLista.BackColor = System.Drawing.Color.Transparent
        Me.AñoLista.Controls.Add(Me.numAño)
        Me.AñoLista.Controls.Add(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9)
        Me.AñoLista.Controls.Add(Me.NumeroEntero2)
        Me.AñoLista.Controls.Add(Me.NumeroEntero3)
        Me.AñoLista.Location = New System.Drawing.Point(66, 24)
        Me.AñoLista.Name = "AñoLista"
        Me.AñoLista.Size = New System.Drawing.Size(56, 24)
        Me.AñoLista.TabIndex = 286
        '
        'numAño
        '
        Appearance80.ForeColor = System.Drawing.Color.Black
        Me.numAño.Appearance = Appearance80
        Me.numAño.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAño.ForeColor = System.Drawing.Color.Black
        Me.numAño.FormatString = ""
        Me.numAño.Location = New System.Drawing.Point(1, 0)
        Me.numAño.MaskInput = "nnnn"
        Me.numAño.MaxValue = 2020
        Me.numAño.MinValue = 2000
        Me.numAño.Name = "numAño"
        Me.numAño.NullText = "0"
        Me.numAño.Size = New System.Drawing.Size(52, 21)
        Me.numAño.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAño.TabIndex = 0
        Me.numAño.Value = 2014
        '
        'object_affad419_86ca_48bd_b401_1f51c77e4ae9
        '
        Appearance81.ForeColor = System.Drawing.Color.Black
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Appearance = Appearance81
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.ForeColor = System.Drawing.Color.Black
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.FormatString = ""
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Location = New System.Drawing.Point(1, 0)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MaskInput = "nnnn"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MaxValue = 2020
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.MinValue = 2000
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Name = "object_affad419_86ca_48bd_b401_1f51c77e4ae9"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.NullText = "0"
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Size = New System.Drawing.Size(52, 21)
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.TabIndex = 0
        Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9.Value = 2013
        '
        'NumeroEntero2
        '
        Appearance82.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.Appearance = Appearance82
        Me.NumeroEntero2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero2.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero2.FormatString = ""
        Me.NumeroEntero2.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero2.MaskInput = "nnnn"
        Me.NumeroEntero2.MaxValue = 2020
        Me.NumeroEntero2.MinValue = 2000
        Me.NumeroEntero2.Name = "NumeroEntero2"
        Me.NumeroEntero2.NullText = "0"
        Me.NumeroEntero2.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero2.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero2.TabIndex = 0
        Me.NumeroEntero2.Value = 2013
        '
        'NumeroEntero3
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.Appearance = Appearance83
        Me.NumeroEntero3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroEntero3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroEntero3.ForeColor = System.Drawing.Color.Black
        Me.NumeroEntero3.FormatString = ""
        Me.NumeroEntero3.Location = New System.Drawing.Point(1, 0)
        Me.NumeroEntero3.MaskInput = "nnnn"
        Me.NumeroEntero3.MaxValue = 2020
        Me.NumeroEntero3.MinValue = 2000
        Me.NumeroEntero3.Name = "NumeroEntero3"
        Me.NumeroEntero3.NullText = "0"
        Me.NumeroEntero3.Size = New System.Drawing.Size(52, 21)
        Me.NumeroEntero3.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.NumeroEntero3.TabIndex = 0
        Me.NumeroEntero3.Value = 2012
        '
        'Etiqueta3
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance84
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(10, 27)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta3.TabIndex = 285
        Me.Etiqueta3.Text = "Ejercicio:"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ficSeguroDetalle)
        Me.UltraTabPageControl1.Enabled = False
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1159, 538)
        '
        'ficSeguroDetalle
        '
        Me.ficSeguroDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficSeguroDetalle.Controls.Add(Me.UltraTabPageControl2)
        Me.ficSeguroDetalle.Controls.Add(Me.UltraTabPageControl4)
        Me.ficSeguroDetalle.Controls.Add(Me.UltraTabPageControl5)
        Me.ficSeguroDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficSeguroDetalle.Location = New System.Drawing.Point(0, 0)
        Me.ficSeguroDetalle.Name = "ficSeguroDetalle"
        Me.ficSeguroDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficSeguroDetalle.Size = New System.Drawing.Size(1159, 538)
        Me.ficSeguroDetalle.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficSeguroDetalle.TabIndex = 0
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "ViajesCargas"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Consolidar"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Prima Seguro"
        Me.ficSeguroDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5, UltraTab2})
        Me.ficSeguroDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1157, 515)
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
        'ficSegurosCarga
        '
        Me.ficSegurosCarga.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficSegurosCarga.Controls.Add(Me.UltraTabPageControl7)
        Me.ficSegurosCarga.Controls.Add(Me.UltraTabPageControl1)
        Me.ficSegurosCarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficSegurosCarga.Location = New System.Drawing.Point(0, 0)
        Me.ficSegurosCarga.Name = "ficSegurosCarga"
        Me.ficSegurosCarga.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficSegurosCarga.Size = New System.Drawing.Size(1161, 561)
        Me.ficSegurosCarga.TabIndex = 1
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab1.Key = "Mantenimiento"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Mantenimiento"
        Me.ficSegurosCarga.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab1})
        Me.ficSegurosCarga.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1159, 538)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(382, 246)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 4
        Me.ugb_Espera.Visible = False
        '
        'frm_SegurosOperacionCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 561)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficSegurosCarga)
        Me.Name = "frm_SegurosOperacionCarga"
        Me.Text = "Seguros Carga"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griClientePrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odClientePrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraTextEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.griViajesCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox7.ResumeLayout(False)
        CType(Me.griPrimaSeguroCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odPrimaSeguroCon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        Me.UltraGroupBox6.PerformLayout()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFactor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMesCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Año1.ResumeLayout(False)
        Me.Año1.PerformLayout()
        CType(Me.object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ficPrimaSeguro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficPrimaSeguro.ResumeLayout(False)
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.griSegurosCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContex.ResumeLayout(False)
        CType(Me.odClieViajePrima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.cboMesLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AñoLista.ResumeLayout(False)
        Me.AñoLista.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.object_affad419_86ca_48bd_b401_1f51c77e4ae9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroEntero3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ficSeguroDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficSeguroDetalle.ResumeLayout(False)
        CType(Me.ficSegurosCarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficSegurosCarga.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficSegurosCarga As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesLista As ISL.Controles.Combo
    Friend WithEvents AñoLista As ISL.Win.Año
    Friend WithEvents numAño As ISL.Controles.NumeroEntero
    Friend WithEvents object_affad419_86ca_48bd_b401_1f51c77e4ae9 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero2 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero3 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents ficSeguroDetalle As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents griViajesCargas As ISL.Controles.Grilla
    Friend WithEvents odClieViajePrima As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnConsultar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griSegurosCarga As ISL.Controles.Grilla
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents UltraGroupBox7 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents griPrimaSeguroCon As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboMesCon As ISL.Controles.Combo
    Friend WithEvents Año1 As ISL.Win.Año
    Friend WithEvents object_0a761dd5_06f2_4aa8_8bf6_06dfc73905a6 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero1 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero4 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero5 As ISL.Controles.NumeroEntero
    Friend WithEvents NumeroEntero6 As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents btnConsolidar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtTC As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents odPrimaSeguroCon As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtFactor1 As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Private WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Actualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MenuContex As ISL.Controles.MenuContextual
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents odClientePrima As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ficPrimaSeguro As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents PrimaSeguroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griClientePrima As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents btnVigencia As ISL.Controles.Boton
    Friend WithEvents btnModificar As ISL.Controles.Boton
    Friend WithEvents btnNuevo As ISL.Controles.Boton
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel17 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents txtTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTextEditor1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cbVigencia As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As ISL.Controles.Boton
    Friend WithEvents btnGuardar As ISL.Controles.Boton
End Class
