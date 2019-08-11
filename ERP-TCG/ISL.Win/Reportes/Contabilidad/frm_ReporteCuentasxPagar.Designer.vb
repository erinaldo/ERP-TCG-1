<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteCuentasxPagar
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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCte")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tipoDoc")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencido")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_S")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_D")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_S")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_D")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_AL_TCV")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaCtaxCyP")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CobraCajaChica")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCte")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tipoDoc")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencido")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_S")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_D")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_S")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_D")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_AL_TCV")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoPago")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaCtaxCyP")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CobraCajaChica")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCte")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOrden")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tipoDoc")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencido")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_S")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_D")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_S")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_D")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_AL_TCV")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaCtaxCyP")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CobraCajaChica")
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCte")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipoDoc")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencido")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FACT_S")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FACT_D")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_S")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_D")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_AL_TCV")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaCtaxCyP")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CobraCajaChica")
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstadoPago", 0)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoPago", 1)
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 2)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPago", 3)
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Afectacion", 4)
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcAfect", 5)
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoAfectado", 6)
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersonaEmpresa")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPersona")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaActividad")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Email")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Contacto")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresa")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Comisionista")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oePersona")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("oeEmpresa")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource3 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gridDocumentos = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.decTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.cbMoneda = New System.Windows.Forms.CheckBox()
        Me.cboMoneda = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbMonto = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.decDetracción = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoOriginal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiSubtotal = New ISL.Controles.Etiqueta(Me.components)
        Me.etiImpuesto = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.decRetencion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoPago = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cbSoloDeudas = New System.Windows.Forms.CheckBox()
        Me.cbExcluirBancos = New System.Windows.Forms.CheckBox()
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.cboProveedor = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtRuc = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMonto.SuspendLayout()
        CType(Me.decDetracción, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraDataSource2
        '
        UltraDataColumn33.DataType = GetType(Decimal)
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37})
        '
        'UltraDataSource3
        '
        Me.UltraDataSource3.Band.Columns.AddRange(New Object() {UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56})
        '
        'gridDocumentos
        '
        UltraGridColumn35.Header.VisiblePosition = 24
        UltraGridColumn35.Hidden = True
        UltraGridColumn35.MaskInput = "{double:9.4}"
        UltraGridColumn35.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn36.Header.Caption = "Cliente"
        UltraGridColumn36.Header.VisiblePosition = 0
        UltraGridColumn36.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn36.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn36.Width = 200
        UltraGridColumn37.Header.Caption = "RUC/DNI"
        UltraGridColumn37.Header.VisiblePosition = 1
        UltraGridColumn37.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn37.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn37.Width = 97
        UltraGridColumn22.Header.Caption = "Tipo Orden"
        UltraGridColumn22.Header.VisiblePosition = 2
        UltraGridColumn22.MaxLength = 25
        UltraGridColumn22.MinWidth = 15
        UltraGridColumn22.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn38.Header.Caption = "Tipo"
        UltraGridColumn38.Header.VisiblePosition = 17
        UltraGridColumn38.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn38.Width = 52
        UltraGridColumn39.Header.VisiblePosition = 18
        UltraGridColumn39.Width = 47
        UltraGridColumn40.Header.VisiblePosition = 19
        UltraGridColumn40.Width = 90
        UltraGridColumn41.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn41.Header.Caption = "Fec Emision"
        UltraGridColumn41.Header.VisiblePosition = 14
        UltraGridColumn41.Width = 78
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn42.Header.Caption = "Fec Venc."
        UltraGridColumn42.Header.VisiblePosition = 15
        UltraGridColumn42.Width = 80
        UltraGridColumn43.Header.VisiblePosition = 16
        UltraGridColumn43.Width = 40
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance1
        UltraGridColumn44.Format = "#,##0.00"
        UltraGridColumn44.Header.Caption = "Fact S/."
        UltraGridColumn44.Header.VisiblePosition = 9
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn44.Width = 96
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance2
        UltraGridColumn45.Format = "#,##0.00"
        UltraGridColumn45.Header.Caption = "Fact $"
        UltraGridColumn45.Header.VisiblePosition = 10
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn45.Width = 80
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance3
        UltraGridColumn46.Format = "#,##0.00"
        UltraGridColumn46.Header.Caption = "Saldo S/."
        UltraGridColumn46.Header.VisiblePosition = 11
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn46.Width = 89
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance4
        UltraGridColumn47.Format = "#,##0.00"
        UltraGridColumn47.Header.Caption = "Saldo $"
        UltraGridColumn47.Header.VisiblePosition = 12
        UltraGridColumn47.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn47.Width = 89
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn48.CellAppearance = Appearance5
        UltraGridColumn48.Format = "#,##0.00"
        UltraGridColumn48.Header.Caption = "Saldo al TCV"
        UltraGridColumn48.Header.VisiblePosition = 13
        UltraGridColumn48.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn48.Width = 94
        UltraGridColumn49.Header.VisiblePosition = 20
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn50.Header.Caption = "Glosa"
        UltraGridColumn50.Header.VisiblePosition = 21
        UltraGridColumn50.Width = 250
        UltraGridColumn51.Header.VisiblePosition = 22
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 23
        UltraGridColumn52.Hidden = True
        UltraGridColumn1.Header.VisiblePosition = 25
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 8
        UltraGridColumn3.DataType = GetType(Boolean)
        UltraGridColumn3.Header.Caption = "Selección"
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance6
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn20.DefaultCellValue = "0.00"
        UltraGridColumn20.Format = "#,##0.00"
        UltraGridColumn20.Header.Caption = "Monto a Pagar"
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.MaskInput = "{double:9.4}"
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn19.DataType = GetType(Boolean)
        UltraGridColumn19.Format = "#,##0.00"
        UltraGridColumn19.Header.Caption = "Ret./Det."
        UltraGridColumn19.Header.VisiblePosition = 5
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance7
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn21.DefaultCellValue = "0.00"
        UltraGridColumn21.Format = "#,##0.00"
        UltraGridColumn21.Header.Caption = "% Afect"
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.MaskInput = "{double:9.4}"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn21.Width = 93
        UltraGridColumn23.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance8
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn23.Format = "#,##0.00"
        UltraGridColumn23.Header.Caption = "Monto Afect."
        UltraGridColumn23.Header.VisiblePosition = 7
        UltraGridColumn23.MaskInput = "{double:9.4}"
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn22, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn20, UltraGridColumn19, UltraGridColumn21, UltraGridColumn23})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.gridDocumentos.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentos.Location = New System.Drawing.Point(0, 85)
        Me.gridDocumentos.Name = "gridDocumentos"
        Me.gridDocumentos.Size = New System.Drawing.Size(1356, 376)
        Me.gridDocumentos.TabIndex = 18
        Me.gridDocumentos.Text = "Documentos"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.decTipoCambio)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion3.Controls.Add(Me.cbMoneda)
        Me.Agrupacion3.Controls.Add(Me.cboMoneda)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion3.Controls.Add(Me.gbMonto)
        Me.Agrupacion3.Controls.Add(Me.cboEstado)
        Me.Agrupacion3.Controls.Add(Me.cbSoloDeudas)
        Me.Agrupacion3.Controls.Add(Me.cbExcluirBancos)
        Me.Agrupacion3.Controls.Add(Me.Colores1)
        Me.Agrupacion3.Controls.Add(Me.cboProveedor)
        Me.Agrupacion3.Controls.Add(Me.txtRuc)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1356, 85)
        Me.Agrupacion3.TabIndex = 19
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'decTipoCambio
        '
        Appearance9.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Appearance = Appearance9
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Location = New System.Drawing.Point(391, 54)
        Me.decTipoCambio.MaskInput = "{double:4.2}"
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.Nullable = True
        Me.decTipoCambio.NullText = "0.00"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTipoCambio.Size = New System.Drawing.Size(55, 21)
        Me.decTipoCambio.TabIndex = 347
        '
        'Etiqueta15
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance10
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(368, 59)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta15.TabIndex = 346
        Me.Etiqueta15.Text = "TC:"
        '
        'cbMoneda
        '
        Me.cbMoneda.AutoSize = True
        Me.cbMoneda.BackColor = System.Drawing.Color.Transparent
        Me.cbMoneda.Checked = True
        Me.cbMoneda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMoneda.ForeColor = System.Drawing.Color.Navy
        Me.cbMoneda.Location = New System.Drawing.Point(60, 57)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(15, 14)
        Me.cbMoneda.TabIndex = 345
        Me.cbMoneda.UseVisualStyleBackColor = False
        '
        'cboMoneda
        '
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Enabled = False
        Me.cboMoneda.Location = New System.Drawing.Point(74, 54)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(140, 21)
        Me.cboMoneda.TabIndex = 332
        '
        'Etiqueta3
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance11
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(13, 58)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta3.TabIndex = 331
        Me.Etiqueta3.Text = "Moneda:"
        '
        'gbMonto
        '
        Me.gbMonto.Controls.Add(Me.Etiqueta4)
        Me.gbMonto.Controls.Add(Me.decDetracción)
        Me.gbMonto.Controls.Add(Me.decMontoOriginal)
        Me.gbMonto.Controls.Add(Me.etiSubtotal)
        Me.gbMonto.Controls.Add(Me.etiImpuesto)
        Me.gbMonto.Controls.Add(Me.Etiqueta27)
        Me.gbMonto.Controls.Add(Me.decRetencion)
        Me.gbMonto.Controls.Add(Me.decMontoPago)
        Me.gbMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMonto.ForeColor = System.Drawing.Color.Black
        Me.gbMonto.Location = New System.Drawing.Point(466, 30)
        Me.gbMonto.Name = "gbMonto"
        Me.gbMonto.Size = New System.Drawing.Size(511, 49)
        Me.gbMonto.TabIndex = 330
        Me.gbMonto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance12
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(383, 5)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Monto a Pagar"
        '
        'decDetracción
        '
        Appearance13.ForeColor = System.Drawing.Color.Black
        Me.decDetracción.Appearance = Appearance13
        Me.decDetracción.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decDetracción.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decDetracción.ForeColor = System.Drawing.Color.Black
        Me.decDetracción.FormatString = ""
        Me.decDetracción.Location = New System.Drawing.Point(258, 22)
        Me.decDetracción.MaskInput = "{double:9.4}"
        Me.decDetracción.Name = "decDetracción"
        Me.decDetracción.Nullable = True
        Me.decDetracción.NullText = "0.00"
        Me.decDetracción.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decDetracción.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decDetracción.ReadOnly = True
        Me.decDetracción.Size = New System.Drawing.Size(110, 21)
        Me.decDetracción.TabIndex = 7
        '
        'decMontoOriginal
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.decMontoOriginal.Appearance = Appearance14
        Me.decMontoOriginal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoOriginal.ForeColor = System.Drawing.Color.Black
        Me.decMontoOriginal.FormatString = ""
        Me.decMontoOriginal.Location = New System.Drawing.Point(6, 22)
        Me.decMontoOriginal.MaskInput = "{double:9.4}"
        Me.decMontoOriginal.Name = "decMontoOriginal"
        Me.decMontoOriginal.NullText = "0.00"
        Me.decMontoOriginal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoOriginal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoOriginal.ReadOnly = True
        Me.decMontoOriginal.Size = New System.Drawing.Size(110, 21)
        Me.decMontoOriginal.TabIndex = 1
        '
        'etiSubtotal
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.etiSubtotal.Appearance = Appearance15
        Me.etiSubtotal.AutoSize = True
        Me.etiSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSubtotal.ForeColor = System.Drawing.Color.Black
        Me.etiSubtotal.Location = New System.Drawing.Point(4, 5)
        Me.etiSubtotal.Name = "etiSubtotal"
        Me.etiSubtotal.Size = New System.Drawing.Size(76, 14)
        Me.etiSubtotal.TabIndex = 0
        Me.etiSubtotal.Text = "Monto Original"
        '
        'etiImpuesto
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.etiImpuesto.Appearance = Appearance16
        Me.etiImpuesto.AutoSize = True
        Me.etiImpuesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImpuesto.ForeColor = System.Drawing.Color.Black
        Me.etiImpuesto.Location = New System.Drawing.Point(131, 5)
        Me.etiImpuesto.Name = "etiImpuesto"
        Me.etiImpuesto.Size = New System.Drawing.Size(54, 14)
        Me.etiImpuesto.TabIndex = 2
        Me.etiImpuesto.Text = "Retención"
        '
        'Etiqueta27
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance17
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(258, 5)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta27.TabIndex = 4
        Me.Etiqueta27.Text = "Detracción"
        '
        'decRetencion
        '
        Appearance18.ForeColor = System.Drawing.Color.Black
        Me.decRetencion.Appearance = Appearance18
        Me.decRetencion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decRetencion.ForeColor = System.Drawing.Color.Black
        Me.decRetencion.FormatString = ""
        Me.decRetencion.Location = New System.Drawing.Point(132, 22)
        Me.decRetencion.MaskInput = "{double:9.4}"
        Me.decRetencion.Name = "decRetencion"
        Me.decRetencion.Nullable = True
        Me.decRetencion.NullText = "0.00"
        Me.decRetencion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decRetencion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decRetencion.ReadOnly = True
        Me.decRetencion.Size = New System.Drawing.Size(110, 21)
        Me.decRetencion.TabIndex = 3
        '
        'decMontoPago
        '
        Appearance19.ForeColor = System.Drawing.Color.Black
        Me.decMontoPago.Appearance = Appearance19
        Me.decMontoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoPago.ForeColor = System.Drawing.Color.Black
        Me.decMontoPago.FormatString = ""
        Me.decMontoPago.Location = New System.Drawing.Point(383, 22)
        Me.decMontoPago.MaskInput = "{double:9.4}"
        Me.decMontoPago.Name = "decMontoPago"
        Me.decMontoPago.Nullable = True
        Me.decMontoPago.NullText = "0.00"
        Me.decMontoPago.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoPago.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoPago.ReadOnly = True
        Me.decMontoPago.Size = New System.Drawing.Size(110, 21)
        Me.decMontoPago.TabIndex = 5
        '
        'cboEstado
        '
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstado.Location = New System.Drawing.Point(294, 5)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(152, 21)
        Me.cboEstado.TabIndex = 329
        '
        'cbSoloDeudas
        '
        Me.cbSoloDeudas.AutoSize = True
        Me.cbSoloDeudas.BackColor = System.Drawing.Color.Transparent
        Me.cbSoloDeudas.Checked = True
        Me.cbSoloDeudas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSoloDeudas.ForeColor = System.Drawing.Color.Navy
        Me.cbSoloDeudas.Location = New System.Drawing.Point(232, 57)
        Me.cbSoloDeudas.Name = "cbSoloDeudas"
        Me.cbSoloDeudas.Size = New System.Drawing.Size(87, 17)
        Me.cbSoloDeudas.TabIndex = 327
        Me.cbSoloDeudas.Text = "Solo Deudas"
        Me.cbSoloDeudas.UseVisualStyleBackColor = False
        '
        'cbExcluirBancos
        '
        Me.cbExcluirBancos.AutoSize = True
        Me.cbExcluirBancos.BackColor = System.Drawing.Color.Transparent
        Me.cbExcluirBancos.Checked = True
        Me.cbExcluirBancos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbExcluirBancos.ForeColor = System.Drawing.Color.Navy
        Me.cbExcluirBancos.Location = New System.Drawing.Point(466, 9)
        Me.cbExcluirBancos.Name = "cbExcluirBancos"
        Me.cbExcluirBancos.Size = New System.Drawing.Size(96, 17)
        Me.cbExcluirBancos.TabIndex = 326
        Me.cbExcluirBancos.Text = "Excluir Bancos"
        Me.cbExcluirBancos.UseVisualStyleBackColor = False
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.SkyBlue
        Me.Colores1.Location = New System.Drawing.Point(568, 5)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(44, 21)
        Me.Colores1.TabIndex = 18
        Me.Colores1.Text = "SkyBlue"
        '
        'cboProveedor
        '
        Me.cboProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedor.CheckedListSettings.ListSeparator = ","
        Me.cboProveedor.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Hidden = True
        UltraGridColumn4.Width = 19
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.Width = 18
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Hidden = True
        UltraGridColumn6.Width = 31
        UltraGridColumn7.Header.VisiblePosition = 3
        UltraGridColumn7.Hidden = True
        UltraGridColumn7.Width = 28
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.Hidden = True
        UltraGridColumn8.Width = 25
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.Hidden = True
        UltraGridColumn9.Width = 17
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Hidden = True
        UltraGridColumn10.Width = 25
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn11.Width = 25
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Width = 25
        UltraGridColumn13.Header.VisiblePosition = 9
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Width = 54
        UltraGridColumn14.Header.VisiblePosition = 10
        UltraGridColumn14.Width = 200
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 54
        UltraGridColumn16.Header.VisiblePosition = 12
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 55
        UltraGridColumn17.Header.VisiblePosition = 13
        UltraGridColumn17.Width = 198
        UltraGridColumn18.Header.VisiblePosition = 14
        UltraGridColumn18.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 15
        UltraGridColumn53.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn53})
        Me.cboProveedor.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cboProveedor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedor.DropDownWidth = 400
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(12, 29)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(434, 22)
        Me.cboProveedor.TabIndex = 325
        '
        'txtRuc
        '
        Me.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRuc.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtRuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuc.Location = New System.Drawing.Point(97, 5)
        Me.txtRuc.MaxLength = 11
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.Size = New System.Drawing.Size(117, 21)
        Me.txtRuc.TabIndex = 324
        Me.txtRuc.TabStop = False
        '
        'Etiqueta2
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance20
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(223, 9)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(70, 14)
        Me.Etiqueta2.TabIndex = 323
        Me.Etiqueta2.Text = "Estado Pago:"
        '
        'Etiqueta1
        '
        Appearance21.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance21
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(9, 10)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta1.TabIndex = 323
        Me.Etiqueta1.Text = "Proveedor(Ruc):"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(294, 196)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 27
        Me.ugb_Espera.Visible = False
        '
        'frm_ReporteCuentasxPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 461)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.gridDocumentos)
        Me.Controls.Add(Me.Agrupacion3)
        Me.Name = "frm_ReporteCuentasxPagar"
        Me.Text = "Reporte Cuentas x Pagar"
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMonto.ResumeLayout(False)
        Me.gbMonto.PerformLayout()
        CType(Me.decDetracción, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridDocumentos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Private WithEvents cboProveedor As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents txtRuc As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents cbExcluirBancos As System.Windows.Forms.CheckBox
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents cbSoloDeudas As System.Windows.Forms.CheckBox
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents gbMonto As ISL.Controles.Agrupacion
    Friend WithEvents decMontoOriginal As ISL.Controles.NumeroDecimal
    Friend WithEvents etiSubtotal As ISL.Controles.Etiqueta
    Friend WithEvents etiImpuesto As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents decRetencion As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoPago As ISL.Controles.NumeroDecimal
    Friend WithEvents cboMoneda As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents cbMoneda As System.Windows.Forms.CheckBox
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents decDetracción As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraDataSource3 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents decTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
End Class
