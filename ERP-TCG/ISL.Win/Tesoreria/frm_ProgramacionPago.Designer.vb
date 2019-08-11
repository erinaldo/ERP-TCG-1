<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProgramacionPago
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLote", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PersonaProgramo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProgramo")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PersonaPago")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaPago")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observaciones")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOriginal")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Retencion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Detraccion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPago")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo", 0)
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaCte")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dni")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("tipoDoc")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Serie")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencido")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FACT_S")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FACT_D")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_S")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_D")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SALDO_AL_TCV")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaCtaxCyP")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CobraCajaChica")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoOriginal")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Afectacion")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcAfect")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoPago")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Saldo")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoOrden")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoAfect")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IDetProgPag", 0)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", 1)
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoGasto", 2)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion", 3)
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FlujoCaja", 4)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaContable", 5)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CtaBancaria", 6)
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MedioPago", 7)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMovimientoDocumento", 8)
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha Pago", 9)
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLote")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PersonaProgramo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaProgramo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PersonaPago")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaPago")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaBancaria")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observaciones")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MedioPago")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaContable")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FlujoCaja")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOriginal")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Retencion")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoPago")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CtaCte")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dni")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("tipoDoc")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Serie")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencido")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_S")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FACT_D")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_S")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_D")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SALDO_AL_TCV")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaCtaxCyP")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CobraCajaChica")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoOriginal")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Retencion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MontoPago")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.griProgramacionPagos = New ISL.Controles.Grilla(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.btnPagar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion11 = New ISL.Controles.Agrupacion(Me.components)
        Me.grupoEstado = New ISL.Controles.Agrupacion(Me.components)
        Me.ColorGenerado = New ISL.Controles.Colores(Me.components)
        Me.ColorParcial = New ISL.Controles.Colores(Me.components)
        Me.ColorPagado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorAnulado = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.rbLote = New System.Windows.Forms.RadioButton()
        Me.agrDatos = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEstado = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.agrLote = New ISL.Controles.Agrupacion(Me.components)
        Me.txtLote = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.ugb_Guardar = New ISL.Win.Espere()
        Me.gridDocumentos = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.chkPagar = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtProveedor = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblEtProv = New ISL.Controles.Etiqueta(Me.components)
        Me.Gb_DatoGeneralCuentaTrabajador = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.cboTipoGasto = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMedio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroLote = New ISL.Controles.Texto(Me.components)
        Me.lblId = New Infragistics.Win.Misc.UltraLabel()
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.lblOperacion = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.gbMonto = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecSaldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.DecDetraccion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.decPagoTC = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoOriginal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.etiSubtotal = New ISL.Controles.Etiqueta(Me.components)
        Me.etiImpuesto = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.decRetencion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.decMontoPago = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtEstado = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtOperaciones = New ISL.Controles.Texto(Me.components)
        Me.etiVoucher = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.decTipoCambio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPago = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.fecProgramacion = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtTrabProg = New ISL.Controles.Texto(Me.components)
        Me.txtObservaciones = New ISL.Controles.Texto(Me.components)
        Me.lblcodigo = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel22 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ficAprobpagos = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griProgramacionPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion11.SuspendLayout()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoEstado.SuspendLayout()
        CType(Me.ColorGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatos.SuspendLayout()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrLote.SuspendLayout()
        CType(Me.txtLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpDetalle.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.chkPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralCuentaTrabajador.SuspendLayout()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroLote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMonto.SuspendLayout()
        CType(Me.DecSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DecDetraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decPagoTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decMontoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTrabProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficAprobpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficAprobpagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl7.Controls.Add(Me.agrMenuLista)
        Me.UltraTabPageControl7.Controls.Add(Me.Agrupacion11)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1346, 424)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.ugb_Espera)
        Me.Agrupacion2.Controls.Add(Me.griProgramacionPagos)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 137)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1346, 287)
        Me.Agrupacion2.TabIndex = 336
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(314, 65)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 331
        Me.ugb_Espera.Visible = False
        '
        'griProgramacionPagos
        '
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn25.Header.Caption = "Programación"
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn27.Header.Caption = "Trabajador Programó"
        UltraGridColumn27.Header.VisiblePosition = 8
        UltraGridColumn27.Width = 250
        UltraGridColumn28.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn28.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn28.Header.Caption = "Fecha Programó"
        UltraGridColumn28.Header.VisiblePosition = 9
        UltraGridColumn29.Header.Caption = "Trabajador Pago"
        UltraGridColumn29.Header.VisiblePosition = 10
        UltraGridColumn29.Width = 250
        UltraGridColumn30.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn30.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn30.Header.Caption = "Fecha Pago"
        UltraGridColumn30.Header.VisiblePosition = 11
        UltraGridColumn33.Header.VisiblePosition = 13
        UltraGridColumn34.Header.VisiblePosition = 12
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn19.CellAppearance = Appearance1
        UltraGridColumn19.Format = "#,##0.00"
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.MaskInput = "{double:9.4}"
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance2
        UltraGridColumn20.Format = "#,##0.00"
        UltraGridColumn20.Header.Caption = "Retención"
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.MaskInput = "{double:9.4}"
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn2.CellAppearance = Appearance3
        UltraGridColumn2.Format = "#,##0.00"
        UltraGridColumn2.Header.Caption = "Detracción"
        UltraGridColumn2.Header.VisiblePosition = 5
        UltraGridColumn2.MaskInput = "{double:9.4}"
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance4
        UltraGridColumn21.Format = "#,##0.00"
        UltraGridColumn21.Header.VisiblePosition = 6
        UltraGridColumn21.MaskInput = "{double:9.4}"
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn22.Header.VisiblePosition = 2
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn10.CellAppearance = Appearance5
        UltraGridColumn10.Format = "#,##0.00"
        UltraGridColumn10.Header.VisiblePosition = 7
        UltraGridColumn10.MaskInput = "{double:9.4}"
        UltraGridColumn10.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn25, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn33, UltraGridColumn34, UltraGridColumn19, UltraGridColumn20, UltraGridColumn2, UltraGridColumn21, UltraGridColumn22, UltraGridColumn10})
        Me.griProgramacionPagos.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griProgramacionPagos.DisplayLayout.MaxColScrollRegions = 1
        Me.griProgramacionPagos.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griProgramacionPagos.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.griProgramacionPagos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griProgramacionPagos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griProgramacionPagos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griProgramacionPagos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griProgramacionPagos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griProgramacionPagos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griProgramacionPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griProgramacionPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griProgramacionPagos.Location = New System.Drawing.Point(3, 3)
        Me.griProgramacionPagos.Name = "griProgramacionPagos"
        Me.griProgramacionPagos.Size = New System.Drawing.Size(1340, 281)
        Me.griProgramacionPagos.TabIndex = 1
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnEliminar)
        Me.agrMenuLista.Controls.Add(Me.btnPagar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(0, 107)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1346, 30)
        Me.agrMenuLista.TabIndex = 335
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance6.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance6.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminar.Appearance = Appearance6
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(74, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 24)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Anular"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnPagar
        '
        Appearance7.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance7.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.btnPagar.Appearance = Appearance7
        Me.btnPagar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPagar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Black
        Me.btnPagar.Location = New System.Drawing.Point(3, 3)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(71, 24)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion11
        '
        Me.Agrupacion11.Controls.Add(Me.grupoEstado)
        Me.Agrupacion11.Controls.Add(Me.rbDatosAdicionales)
        Me.Agrupacion11.Controls.Add(Me.rbLote)
        Me.Agrupacion11.Controls.Add(Me.agrDatos)
        Me.Agrupacion11.Controls.Add(Me.agrLote)
        Me.Agrupacion11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion11.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion11.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion11.Name = "Agrupacion11"
        Me.Agrupacion11.Size = New System.Drawing.Size(1346, 107)
        Me.Agrupacion11.TabIndex = 334
        Me.Agrupacion11.Text = "Búsquedas"
        Me.Agrupacion11.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grupoEstado
        '
        Me.grupoEstado.Controls.Add(Me.ColorGenerado)
        Me.grupoEstado.Controls.Add(Me.ColorParcial)
        Me.grupoEstado.Controls.Add(Me.ColorPagado)
        Me.grupoEstado.Controls.Add(Me.Etiqueta13)
        Me.grupoEstado.Controls.Add(Me.Etiqueta3)
        Me.grupoEstado.Controls.Add(Me.Etiqueta7)
        Me.grupoEstado.Controls.Add(Me.ColorAnulado)
        Me.grupoEstado.Controls.Add(Me.Etiqueta31)
        Me.grupoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoEstado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grupoEstado.Location = New System.Drawing.Point(546, 29)
        Me.grupoEstado.Name = "grupoEstado"
        Me.grupoEstado.Size = New System.Drawing.Size(523, 44)
        Me.grupoEstado.TabIndex = 332
        Me.grupoEstado.Text = "Estados"
        Me.grupoEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColorGenerado
        '
        Me.ColorGenerado.Color = System.Drawing.Color.White
        Me.ColorGenerado.Location = New System.Drawing.Point(71, 18)
        Me.ColorGenerado.Name = "ColorGenerado"
        Me.ColorGenerado.Size = New System.Drawing.Size(43, 21)
        Me.ColorGenerado.TabIndex = 1
        Me.ColorGenerado.TabStop = False
        Me.ColorGenerado.Text = "White"
        '
        'ColorParcial
        '
        Me.ColorParcial.Color = System.Drawing.Color.Yellow
        Me.ColorParcial.Location = New System.Drawing.Point(338, 18)
        Me.ColorParcial.Name = "ColorParcial"
        Me.ColorParcial.Size = New System.Drawing.Size(44, 21)
        Me.ColorParcial.TabIndex = 3
        Me.ColorParcial.TabStop = False
        Me.ColorParcial.Text = "Yellow"
        '
        'ColorPagado
        '
        Me.ColorPagado.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ColorPagado.Location = New System.Drawing.Point(196, 18)
        Me.ColorPagado.Name = "ColorPagado"
        Me.ColorPagado.Size = New System.Drawing.Size(44, 21)
        Me.ColorPagado.TabIndex = 3
        Me.ColorPagado.TabStop = False
        Me.ColorPagado.Text = "128, 255, 128"
        '
        'Etiqueta13
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance8
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(263, 22)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta13.TabIndex = 2
        Me.Etiqueta13.Text = "Pago Parcial:"
        '
        'Etiqueta3
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance9
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(8, 23)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta3.TabIndex = 0
        Me.Etiqueta3.Text = "Generado:"
        '
        'Etiqueta7
        '
        Appearance10.BackColor = System.Drawing.Color.Transparent
        Appearance10.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance10
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(134, 22)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta7.TabIndex = 2
        Me.Etiqueta7.Text = "Pagado:"
        '
        'ColorAnulado
        '
        Me.ColorAnulado.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ColorAnulado.Location = New System.Drawing.Point(459, 17)
        Me.ColorAnulado.Name = "ColorAnulado"
        Me.ColorAnulado.Size = New System.Drawing.Size(43, 21)
        Me.ColorAnulado.TabIndex = 5
        Me.ColorAnulado.TabStop = False
        Me.ColorAnulado.Text = "255, 128, 128"
        '
        'Etiqueta31
        '
        Appearance11.BackColor = System.Drawing.Color.Transparent
        Appearance11.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance11
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(405, 21)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta31.TabIndex = 4
        Me.Etiqueta31.Text = "Anulado:"
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(7, 19)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(109, 17)
        Me.rbDatosAdicionales.TabIndex = 335
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'rbLote
        '
        Me.rbLote.AutoSize = True
        Me.rbLote.BackColor = System.Drawing.Color.Transparent
        Me.rbLote.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLote.ForeColor = System.Drawing.Color.Navy
        Me.rbLote.Location = New System.Drawing.Point(344, 21)
        Me.rbLote.Name = "rbLote"
        Me.rbLote.Size = New System.Drawing.Size(115, 17)
        Me.rbLote.TabIndex = 336
        Me.rbLote.TabStop = True
        Me.rbLote.Text = "Búsqueda por Lote"
        Me.rbLote.UseVisualStyleBackColor = False
        '
        'agrDatos
        '
        Me.agrDatos.Controls.Add(Me.Etiqueta4)
        Me.agrDatos.Controls.Add(Me.cboEstado)
        Me.agrDatos.Controls.Add(Me.Etiqueta50)
        Me.agrDatos.Controls.Add(Me.fecDesde)
        Me.agrDatos.Controls.Add(Me.Etiqueta51)
        Me.agrDatos.Controls.Add(Me.fecHasta)
        Me.agrDatos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatos.ForeColor = System.Drawing.Color.Black
        Me.agrDatos.Location = New System.Drawing.Point(6, 37)
        Me.agrDatos.Name = "agrDatos"
        Me.agrDatos.Size = New System.Drawing.Size(320, 61)
        Me.agrDatos.TabIndex = 331
        Me.agrDatos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta4
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta4.Appearance = Appearance12
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(162, 19)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(128, 14)
        Me.Etiqueta4.TabIndex = 333
        Me.Etiqueta4.Text = "Estado de Programación:"
        '
        'cboEstado
        '
        Me.cboEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstado.Location = New System.Drawing.Point(162, 34)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(152, 22)
        Me.cboEstado.TabIndex = 334
        '
        'Etiqueta50
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance13
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(6, 12)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta50.TabIndex = 327
        Me.Etiqueta50.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(51, 7)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(98, 21)
        Me.fecDesde.TabIndex = 328
        '
        'Etiqueta51
        '
        Appearance14.BackColor = System.Drawing.Color.Transparent
        Appearance14.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance14
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(6, 39)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(37, 15)
        Me.Etiqueta51.TabIndex = 329
        Me.Etiqueta51.Text = "Hasta:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(51, 35)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(98, 21)
        Me.fecHasta.TabIndex = 330
        '
        'agrLote
        '
        Me.agrLote.Controls.Add(Me.txtLote)
        Me.agrLote.Controls.Add(Me.Etiqueta1)
        Me.agrLote.Enabled = False
        Me.agrLote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrLote.ForeColor = System.Drawing.Color.Black
        Me.agrLote.Location = New System.Drawing.Point(343, 38)
        Me.agrLote.Name = "agrLote"
        Me.agrLote.Size = New System.Drawing.Size(186, 30)
        Me.agrLote.TabIndex = 331
        Me.agrLote.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(59, 5)
        Me.txtLote.MaxLength = 11
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(117, 21)
        Me.txtLote.TabIndex = 326
        Me.txtLote.TabStop = False
        '
        'Etiqueta1
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance15
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(7, 9)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta1.TabIndex = 325
        Me.Etiqueta1.Text = "Número:"
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.Agrupacion3)
        Me.utpDetalle.Controls.Add(Me.Agrupacion1)
        Me.utpDetalle.Controls.Add(Me.Gb_DatoGeneralCuentaTrabajador)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1346, 424)
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.ugb_Guardar)
        Me.Agrupacion3.Controls.Add(Me.gridDocumentos)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 210)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1346, 214)
        Me.Agrupacion3.TabIndex = 337
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ugb_Guardar
        '
        Me.ugb_Guardar.Location = New System.Drawing.Point(479, 87)
        Me.ugb_Guardar.Name = "ugb_Guardar"
        Me.ugb_Guardar.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Guardar.TabIndex = 332
        Me.ugb_Guardar.Visible = False
        '
        'gridDocumentos
        '
        UltraGridColumn74.Header.VisiblePosition = 25
        UltraGridColumn74.Hidden = True
        UltraGridColumn74.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn75.Header.Caption = "Cliente"
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn75.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn75.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn75.Width = 200
        UltraGridColumn76.Header.Caption = "RUC/DNI"
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn76.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn76.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn76.Width = 97
        UltraGridColumn77.Header.Caption = "Tipo"
        UltraGridColumn77.Header.VisiblePosition = 13
        UltraGridColumn77.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn77.Width = 52
        UltraGridColumn78.Header.VisiblePosition = 14
        UltraGridColumn78.Width = 47
        UltraGridColumn79.Header.Caption = "Número"
        UltraGridColumn79.Header.VisiblePosition = 15
        UltraGridColumn79.Width = 90
        UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn80.Header.Caption = "Fec Emision"
        UltraGridColumn80.Header.VisiblePosition = 10
        UltraGridColumn80.Width = 78
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn81.Header.Caption = "Fec Venc."
        UltraGridColumn81.Header.VisiblePosition = 11
        UltraGridColumn81.Width = 80
        UltraGridColumn82.Header.VisiblePosition = 12
        UltraGridColumn82.Width = 40
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance16
        UltraGridColumn83.Format = "#,##0.00"
        UltraGridColumn83.Header.Caption = "Fact S/."
        UltraGridColumn83.Header.VisiblePosition = 16
        UltraGridColumn83.Hidden = True
        UltraGridColumn83.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn83.Width = 96
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn84.CellAppearance = Appearance17
        UltraGridColumn84.Format = "#,##0.00"
        UltraGridColumn84.Header.Caption = "Fact $"
        UltraGridColumn84.Header.VisiblePosition = 17
        UltraGridColumn84.Hidden = True
        UltraGridColumn84.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn84.Width = 80
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn85.CellAppearance = Appearance18
        UltraGridColumn85.Format = "#,##0.00"
        UltraGridColumn85.Header.Caption = "Saldo S/."
        UltraGridColumn85.Header.VisiblePosition = 18
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn85.Width = 89
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn86.CellAppearance = Appearance19
        UltraGridColumn86.Format = "#,##0.00"
        UltraGridColumn86.Header.Caption = "Saldo $"
        UltraGridColumn86.Header.VisiblePosition = 19
        UltraGridColumn86.Hidden = True
        UltraGridColumn86.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn86.Width = 89
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn87.CellAppearance = Appearance20
        UltraGridColumn87.Format = "#,##0.00"
        UltraGridColumn87.Header.Caption = "Saldo al TCV"
        UltraGridColumn87.Header.VisiblePosition = 20
        UltraGridColumn87.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn87.Width = 94
        UltraGridColumn88.Header.VisiblePosition = 22
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn89.Header.Caption = "Glosa"
        UltraGridColumn89.Header.VisiblePosition = 23
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.Width = 250
        UltraGridColumn90.Header.VisiblePosition = 24
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 21
        UltraGridColumn91.Hidden = True
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn92.CellAppearance = Appearance21
        UltraGridColumn92.Format = "#,##0.00"
        UltraGridColumn92.Header.Caption = "Monto Original"
        UltraGridColumn92.Header.VisiblePosition = 5
        UltraGridColumn92.MaskInput = "{double:9.4}"
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn3.CellAppearance = Appearance22
        UltraGridColumn3.Format = "#,##0.00"
        UltraGridColumn3.Header.Caption = "Monto Afect."
        UltraGridColumn3.Header.VisiblePosition = 7
        UltraGridColumn3.MaskInput = "{double:9.4}"
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn4.CellAppearance = Appearance23
        UltraGridColumn4.Format = "#,##0.00"
        UltraGridColumn4.Header.Caption = "% Afect."
        UltraGridColumn4.Header.VisiblePosition = 6
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn94.CellAppearance = Appearance24
        UltraGridColumn94.Format = "#,##0.00"
        UltraGridColumn94.Header.Caption = "Monto Pago"
        UltraGridColumn94.Header.VisiblePosition = 8
        UltraGridColumn94.MaskInput = "{double:9.4}"
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn9.CellAppearance = Appearance25
        UltraGridColumn9.Format = "#,##0.00"
        UltraGridColumn9.Header.VisiblePosition = 9
        UltraGridColumn9.MaskInput = "{double:9.4}"
        UltraGridColumn9.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn96.Header.VisiblePosition = 28
        UltraGridColumn96.Hidden = True
        UltraGridColumn6.Header.Caption = "Orden"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn7.Header.Caption = "Tipo Agente"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridColumn97.Header.VisiblePosition = 27
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn98.DataType = GetType(Boolean)
        UltraGridColumn98.Header.Caption = "Selección"
        UltraGridColumn98.Header.VisiblePosition = 2
        UltraGridColumn98.SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Disabled
        UltraGridColumn98.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn26.Header.Caption = "Tipo Gasto"
        UltraGridColumn26.Header.VisiblePosition = 34
        UltraGridColumn26.Width = 200
        UltraGridColumn5.Header.Caption = "Nro. Operación"
        UltraGridColumn5.Header.VisiblePosition = 32
        UltraGridColumn8.Header.Caption = "Flujo Caja"
        UltraGridColumn8.Header.VisiblePosition = 35
        UltraGridColumn8.Width = 200
        UltraGridColumn11.Header.Caption = "Cuenta Contable"
        UltraGridColumn11.Header.VisiblePosition = 30
        UltraGridColumn11.Width = 200
        UltraGridColumn12.Header.Caption = "Cuenta Bancaria"
        UltraGridColumn12.Header.VisiblePosition = 31
        UltraGridColumn12.Width = 200
        UltraGridColumn13.Header.Caption = "Medio Pago"
        UltraGridColumn13.Header.VisiblePosition = 33
        UltraGridColumn13.Width = 200
        UltraGridColumn14.Header.VisiblePosition = 36
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 29
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn3, UltraGridColumn4, UltraGridColumn94, UltraGridColumn9, UltraGridColumn95, UltraGridColumn96, UltraGridColumn6, UltraGridColumn7, UltraGridColumn97, UltraGridColumn98, UltraGridColumn26, UltraGridColumn5, UltraGridColumn8, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15})
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
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
        Me.gridDocumentos.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Appearance26.TextHAlignAsString = "Center"
        Appearance26.TextVAlignAsString = "Middle"
        Me.gridDocumentos.DisplayLayout.Override.SummaryFooterCaptionAppearance = Appearance26
        Appearance27.TextHAlignAsString = "Right"
        Appearance27.TextVAlignAsString = "Middle"
        Me.gridDocumentos.DisplayLayout.Override.SummaryValueAppearance = Appearance27
        Me.gridDocumentos.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.gridDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentos.Location = New System.Drawing.Point(3, 3)
        Me.gridDocumentos.Name = "gridDocumentos"
        Me.gridDocumentos.Size = New System.Drawing.Size(1340, 208)
        Me.gridDocumentos.TabIndex = 19
        Me.gridDocumentos.Text = "Cuentas Programadas"
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.chkPagar)
        Me.Agrupacion1.Controls.Add(Me.txtProveedor)
        Me.Agrupacion1.Controls.Add(Me.lblEtProv)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 180)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1346, 30)
        Me.Agrupacion1.TabIndex = 336
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'chkPagar
        '
        Me.chkPagar.BackColor = System.Drawing.Color.Transparent
        Me.chkPagar.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkPagar.Location = New System.Drawing.Point(548, 5)
        Me.chkPagar.Name = "chkPagar"
        Me.chkPagar.Size = New System.Drawing.Size(15, 20)
        Me.chkPagar.TabIndex = 336
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(113, 4)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(431, 22)
        Me.txtProveedor.TabIndex = 8
        '
        'lblEtProv
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.lblEtProv.Appearance = Appearance28
        Me.lblEtProv.AutoSize = True
        Me.lblEtProv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtProv.ForeColor = System.Drawing.Color.Black
        Me.lblEtProv.Location = New System.Drawing.Point(7, 8)
        Me.lblEtProv.Name = "lblEtProv"
        Me.lblEtProv.Size = New System.Drawing.Size(100, 15)
        Me.lblEtProv.TabIndex = 335
        Me.lblEtProv.Text = "Proveedor a Pagar:"
        '
        'Gb_DatoGeneralCuentaTrabajador
        '
        Appearance29.BackColor = System.Drawing.Color.White
        Appearance29.BackColor2 = System.Drawing.Color.White
        Me.Gb_DatoGeneralCuentaTrabajador.ContentAreaAppearance = Appearance29
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboCuentaContable)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboFlujoCaja)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboTipoGasto)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta16)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboMedio)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta14)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta8)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta9)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtNroLote)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblId)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Colores1)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblOperacion)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta2)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.gbMonto)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtEstado)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta5)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtOperaciones)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.etiVoucher)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboCuentaBancaria)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta11)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.decTipoCambio)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta15)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.fecPago)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.fecProgramacion)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel11)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboMoneda)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtTrabProg)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtObservaciones)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblcodigo)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel4)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel5)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel22)
        Me.Gb_DatoGeneralCuentaTrabajador.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb_DatoGeneralCuentaTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.Gb_DatoGeneralCuentaTrabajador.Name = "Gb_DatoGeneralCuentaTrabajador"
        Me.Gb_DatoGeneralCuentaTrabajador.Size = New System.Drawing.Size(1346, 180)
        Me.Gb_DatoGeneralCuentaTrabajador.TabIndex = 0
        Me.Gb_DatoGeneralCuentaTrabajador.Text = "Datos Generales"
        Me.Gb_DatoGeneralCuentaTrabajador.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cboCuentaContable
        '
        Appearance30.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance30
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaContable.DropDownListWidth = 400
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(506, 24)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.Size = New System.Drawing.Size(293, 22)
        Me.cboCuentaContable.TabIndex = 338
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'cboFlujoCaja
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Appearance = Appearance31
        Me.cboFlujoCaja.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Location = New System.Drawing.Point(506, 147)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.Size = New System.Drawing.Size(293, 22)
        Me.cboFlujoCaja.TabIndex = 336
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'cboTipoGasto
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Appearance = Appearance32
        Me.cboTipoGasto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoGasto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoGasto.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoGasto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoGasto.ForeColor = System.Drawing.Color.Black
        Me.cboTipoGasto.Location = New System.Drawing.Point(506, 122)
        Me.cboTipoGasto.Name = "cboTipoGasto"
        Me.cboTipoGasto.Size = New System.Drawing.Size(293, 22)
        Me.cboTipoGasto.TabIndex = 336
        Me.cboTipoGasto.ValueMember = "Id"
        '
        'Etiqueta16
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance33
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(430, 152)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta16.TabIndex = 335
        Me.Etiqueta16.Text = "Flujo Caja:"
        '
        'cboMedio
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Appearance = Appearance34
        Me.cboMedio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Location = New System.Drawing.Point(506, 97)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(293, 22)
        Me.cboMedio.TabIndex = 336
        Me.cboMedio.ValueMember = "Id"
        '
        'Etiqueta14
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance35
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(430, 126)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(62, 15)
        Me.Etiqueta14.TabIndex = 335
        Me.Etiqueta14.Text = "Tipo Gasto:"
        '
        'Etiqueta8
        '
        Appearance36.BackColor = System.Drawing.Color.Transparent
        Appearance36.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance36
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(430, 26)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta8.TabIndex = 337
        Me.Etiqueta8.Text = "Cta. Ctble.:"
        '
        'Etiqueta9
        '
        Appearance37.BackColor = System.Drawing.Color.Transparent
        Appearance37.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance37
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(430, 101)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta9.TabIndex = 335
        Me.Etiqueta9.Text = "Medio Pago:"
        '
        'txtNroLote
        '
        Appearance38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroLote.Appearance = Appearance38
        Me.txtNroLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroLote.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroLote.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroLote.Location = New System.Drawing.Point(90, 23)
        Me.txtNroLote.MaxLength = 10
        Me.txtNroLote.Name = "txtNroLote"
        Me.txtNroLote.ReadOnly = True
        Me.txtNroLote.Size = New System.Drawing.Size(100, 21)
        Me.txtNroLote.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(133, 24)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(28, 16)
        Me.lblId.TabIndex = 334
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Colores1.Location = New System.Drawing.Point(990, 121)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.ReadOnly = True
        Me.Colores1.Size = New System.Drawing.Size(43, 22)
        Me.Colores1.TabIndex = 333
        Me.Colores1.TabStop = False
        Me.Colores1.Text = "255, 128, 128"
        '
        'lblOperacion
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance39.TextHAlignAsString = "Center"
        Appearance39.TextVAlignAsString = "Middle"
        Me.lblOperacion.Appearance = Appearance39
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.ForeColor = System.Drawing.Color.Black
        Me.lblOperacion.Location = New System.Drawing.Point(815, 146)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 0)
        Me.lblOperacion.TabIndex = 332
        '
        'Etiqueta2
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance40
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(811, 126)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(173, 15)
        Me.Etiqueta2.TabIndex = 332
        Me.Etiqueta2.Text = "Documento Programado Anulado:"
        '
        'gbMonto
        '
        Me.gbMonto.Controls.Add(Me.Etiqueta12)
        Me.gbMonto.Controls.Add(Me.DecSaldo)
        Me.gbMonto.Controls.Add(Me.Etiqueta10)
        Me.gbMonto.Controls.Add(Me.DecDetraccion)
        Me.gbMonto.Controls.Add(Me.Etiqueta6)
        Me.gbMonto.Controls.Add(Me.decPagoTC)
        Me.gbMonto.Controls.Add(Me.decMontoOriginal)
        Me.gbMonto.Controls.Add(Me.etiSubtotal)
        Me.gbMonto.Controls.Add(Me.etiImpuesto)
        Me.gbMonto.Controls.Add(Me.Etiqueta27)
        Me.gbMonto.Controls.Add(Me.decRetencion)
        Me.gbMonto.Controls.Add(Me.decMontoPago)
        Me.gbMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMonto.ForeColor = System.Drawing.Color.Black
        Me.gbMonto.Location = New System.Drawing.Point(810, 23)
        Me.gbMonto.Name = "gbMonto"
        Me.gbMonto.Size = New System.Drawing.Size(424, 96)
        Me.gbMonto.TabIndex = 331
        Me.gbMonto.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta12
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance41
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(290, 49)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(32, 14)
        Me.Etiqueta12.TabIndex = 10
        Me.Etiqueta12.Text = "Saldo"
        '
        'DecSaldo
        '
        Appearance42.ForeColor = System.Drawing.Color.Black
        Me.DecSaldo.Appearance = Appearance42
        Me.DecSaldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecSaldo.ForeColor = System.Drawing.Color.Black
        Me.DecSaldo.FormatString = ""
        Me.DecSaldo.Location = New System.Drawing.Point(289, 65)
        Me.DecSaldo.MaskInput = "{double:9.2}"
        Me.DecSaldo.Name = "DecSaldo"
        Me.DecSaldo.Nullable = True
        Me.DecSaldo.NullText = "0.00"
        Me.DecSaldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecSaldo.ReadOnly = True
        Me.DecSaldo.Size = New System.Drawing.Size(120, 21)
        Me.DecSaldo.TabIndex = 11
        '
        'Etiqueta10
        '
        Appearance43.BackColor = System.Drawing.Color.Transparent
        Appearance43.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance43
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(147, 49)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(57, 14)
        Me.Etiqueta10.TabIndex = 8
        Me.Etiqueta10.Text = "Detracción"
        '
        'DecDetraccion
        '
        Appearance44.ForeColor = System.Drawing.Color.Black
        Me.DecDetraccion.Appearance = Appearance44
        Me.DecDetraccion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.DecDetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecDetraccion.ForeColor = System.Drawing.Color.Black
        Me.DecDetraccion.FormatString = ""
        Me.DecDetraccion.Location = New System.Drawing.Point(146, 65)
        Me.DecDetraccion.MaskInput = "{double:9.2}"
        Me.DecDetraccion.Name = "DecDetraccion"
        Me.DecDetraccion.Nullable = True
        Me.DecDetraccion.NullText = "0.00"
        Me.DecDetraccion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.DecDetraccion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.DecDetraccion.ReadOnly = True
        Me.DecDetraccion.Size = New System.Drawing.Size(120, 21)
        Me.DecDetraccion.TabIndex = 9
        '
        'Etiqueta6
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance45
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(289, 6)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(113, 14)
        Me.Etiqueta6.TabIndex = 6
        Me.Etiqueta6.Text = "Monto Pago a TC (S/.)"
        '
        'decPagoTC
        '
        Appearance46.ForeColor = System.Drawing.Color.Black
        Me.decPagoTC.Appearance = Appearance46
        Me.decPagoTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decPagoTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decPagoTC.ForeColor = System.Drawing.Color.Black
        Me.decPagoTC.FormatString = ""
        Me.decPagoTC.Location = New System.Drawing.Point(289, 22)
        Me.decPagoTC.MaskInput = "{double:9.2}"
        Me.decPagoTC.Name = "decPagoTC"
        Me.decPagoTC.Nullable = True
        Me.decPagoTC.NullText = "0.00"
        Me.decPagoTC.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decPagoTC.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decPagoTC.ReadOnly = True
        Me.decPagoTC.Size = New System.Drawing.Size(120, 21)
        Me.decPagoTC.TabIndex = 7
        '
        'decMontoOriginal
        '
        Appearance47.ForeColor = System.Drawing.Color.Black
        Me.decMontoOriginal.Appearance = Appearance47
        Me.decMontoOriginal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoOriginal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoOriginal.ForeColor = System.Drawing.Color.Black
        Me.decMontoOriginal.FormatString = ""
        Me.decMontoOriginal.Location = New System.Drawing.Point(6, 22)
        Me.decMontoOriginal.MaskInput = "{double:9.2}"
        Me.decMontoOriginal.Name = "decMontoOriginal"
        Me.decMontoOriginal.NullText = "0.00"
        Me.decMontoOriginal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoOriginal.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoOriginal.ReadOnly = True
        Me.decMontoOriginal.Size = New System.Drawing.Size(120, 21)
        Me.decMontoOriginal.TabIndex = 1
        '
        'etiSubtotal
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.Navy
        Me.etiSubtotal.Appearance = Appearance48
        Me.etiSubtotal.AutoSize = True
        Me.etiSubtotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiSubtotal.ForeColor = System.Drawing.Color.Black
        Me.etiSubtotal.Location = New System.Drawing.Point(4, 6)
        Me.etiSubtotal.Name = "etiSubtotal"
        Me.etiSubtotal.Size = New System.Drawing.Size(76, 14)
        Me.etiSubtotal.TabIndex = 0
        Me.etiSubtotal.Text = "Monto Original"
        '
        'etiImpuesto
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.etiImpuesto.Appearance = Appearance49
        Me.etiImpuesto.AutoSize = True
        Me.etiImpuesto.Cursor = System.Windows.Forms.Cursors.Default
        Me.etiImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiImpuesto.ForeColor = System.Drawing.Color.Black
        Me.etiImpuesto.Location = New System.Drawing.Point(6, 49)
        Me.etiImpuesto.Name = "etiImpuesto"
        Me.etiImpuesto.Size = New System.Drawing.Size(54, 14)
        Me.etiImpuesto.TabIndex = 2
        Me.etiImpuesto.Text = "Retención"
        '
        'Etiqueta27
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance50
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(147, 6)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(76, 14)
        Me.Etiqueta27.TabIndex = 4
        Me.Etiqueta27.Text = "Monto a Pagar"
        '
        'decRetencion
        '
        Appearance51.ForeColor = System.Drawing.Color.Black
        Me.decRetencion.Appearance = Appearance51
        Me.decRetencion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decRetencion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decRetencion.ForeColor = System.Drawing.Color.Black
        Me.decRetencion.FormatString = ""
        Me.decRetencion.Location = New System.Drawing.Point(5, 65)
        Me.decRetencion.MaskInput = "{double:9.2}"
        Me.decRetencion.Name = "decRetencion"
        Me.decRetencion.Nullable = True
        Me.decRetencion.NullText = "0.00"
        Me.decRetencion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decRetencion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decRetencion.ReadOnly = True
        Me.decRetencion.Size = New System.Drawing.Size(120, 21)
        Me.decRetencion.TabIndex = 3
        '
        'decMontoPago
        '
        Appearance52.ForeColor = System.Drawing.Color.Black
        Me.decMontoPago.Appearance = Appearance52
        Me.decMontoPago.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decMontoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decMontoPago.ForeColor = System.Drawing.Color.Black
        Me.decMontoPago.FormatString = ""
        Me.decMontoPago.Location = New System.Drawing.Point(146, 22)
        Me.decMontoPago.MaskInput = "{double:9.2}"
        Me.decMontoPago.Name = "decMontoPago"
        Me.decMontoPago.Nullable = True
        Me.decMontoPago.NullText = "0.00"
        Me.decMontoPago.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decMontoPago.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decMontoPago.ReadOnly = True
        Me.decMontoPago.Size = New System.Drawing.Size(120, 21)
        Me.decMontoPago.TabIndex = 5
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(90, 95)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(144, 21)
        Me.txtEstado.TabIndex = 26
        '
        'Etiqueta5
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance53
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(7, 99)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta5.TabIndex = 25
        Me.Etiqueta5.Text = "Estado:"
        '
        'txtOperaciones
        '
        Me.txtOperaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperaciones.Location = New System.Drawing.Point(506, 73)
        Me.txtOperaciones.Name = "txtOperaciones"
        Me.txtOperaciones.Size = New System.Drawing.Size(100, 21)
        Me.txtOperaciones.TabIndex = 26
        '
        'etiVoucher
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.etiVoucher.Appearance = Appearance54
        Me.etiVoucher.AutoSize = True
        Me.etiVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiVoucher.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiVoucher.Location = New System.Drawing.Point(430, 78)
        Me.etiVoucher.Name = "etiVoucher"
        Me.etiVoucher.Size = New System.Drawing.Size(58, 14)
        Me.etiVoucher.TabIndex = 25
        Me.etiVoucher.Text = "Operacion:"
        '
        'cboCuentaBancaria
        '
        Appearance55.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance55
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(506, 49)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(293, 21)
        Me.cboCuentaBancaria.TabIndex = 24
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance56.BackColor = System.Drawing.Color.Transparent
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance56
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(430, 53)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta11.TabIndex = 23
        Me.Etiqueta11.Text = "Cta Banco:"
        '
        'decTipoCambio
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Appearance = Appearance57
        Me.decTipoCambio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.decTipoCambio.Location = New System.Drawing.Point(367, 71)
        Me.decTipoCambio.MaskInput = "{double:4.2}"
        Me.decTipoCambio.Name = "decTipoCambio"
        Me.decTipoCambio.Nullable = True
        Me.decTipoCambio.NullText = "0.00"
        Me.decTipoCambio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.decTipoCambio.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.decTipoCambio.ReadOnly = True
        Me.decTipoCambio.Size = New System.Drawing.Size(55, 21)
        Me.decTipoCambio.TabIndex = 22
        '
        'Etiqueta15
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance58
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(344, 76)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(22, 14)
        Me.Etiqueta15.TabIndex = 21
        Me.Etiqueta15.Text = "TC:"
        '
        'fecPago
        '
        Me.fecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecPago.Location = New System.Drawing.Point(696, 72)
        Me.fecPago.Name = "fecPago"
        Me.fecPago.Size = New System.Drawing.Size(103, 21)
        Me.fecPago.TabIndex = 20
        '
        'UltraLabel1
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Appearance59.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance59
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(622, 76)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Fecha Pago:"
        '
        'fecProgramacion
        '
        Me.fecProgramacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecProgramacion.Location = New System.Drawing.Point(319, 24)
        Me.fecProgramacion.Name = "fecProgramacion"
        Me.fecProgramacion.Size = New System.Drawing.Size(103, 21)
        Me.fecProgramacion.TabIndex = 20
        '
        'UltraLabel11
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Appearance60.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance60
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel11.Location = New System.Drawing.Point(201, 27)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(112, 14)
        Me.UltraLabel11.TabIndex = 2
        Me.UltraLabel11.Text = "Fecha Programación:"
        '
        'cboMoneda
        '
        Appearance61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Appearance = Appearance61
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMoneda.Location = New System.Drawing.Point(90, 71)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.ReadOnly = True
        Me.cboMoneda.Size = New System.Drawing.Size(144, 21)
        Me.cboMoneda.TabIndex = 13
        Me.cboMoneda.ValueMember = "Id"
        '
        'txtTrabProg
        '
        Appearance62.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTrabProg.Appearance = Appearance62
        Me.txtTrabProg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTrabProg.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTrabProg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabProg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTrabProg.Location = New System.Drawing.Point(90, 47)
        Me.txtTrabProg.MaxLength = 10
        Me.txtTrabProg.Name = "txtTrabProg"
        Me.txtTrabProg.ReadOnly = True
        Me.txtTrabProg.Size = New System.Drawing.Size(332, 21)
        Me.txtTrabProg.TabIndex = 1
        '
        'txtObservaciones
        '
        Appearance63.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Appearance = Appearance63
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservaciones.Location = New System.Drawing.Point(90, 121)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(332, 48)
        Me.txtObservaciones.TabIndex = 11
        '
        'lblcodigo
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.lblcodigo.Appearance = Appearance64
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodigo.Location = New System.Drawing.Point(6, 27)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(82, 14)
        Me.lblcodigo.TabIndex = 0
        Me.lblcodigo.Text = "N° Programac.:"
        '
        'UltraLabel4
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Appearance65.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance65
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(6, 50)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(87, 14)
        Me.UltraLabel4.TabIndex = 4
        Me.UltraLabel4.Text = "Pers. Programo:"
        '
        'UltraLabel5
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Appearance66.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance66
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(6, 121)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(83, 14)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Observaciones:"
        '
        'UltraLabel22
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel22.Appearance = Appearance67
        Me.UltraLabel22.AutoSize = True
        Me.UltraLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel22.Location = New System.Drawing.Point(6, 74)
        Me.UltraLabel22.Name = "UltraLabel22"
        Me.UltraLabel22.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel22.TabIndex = 12
        Me.UltraLabel22.Text = "Moneda:"
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'ficAprobpagos
        '
        Me.ficAprobpagos.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficAprobpagos.Controls.Add(Me.UltraTabPageControl7)
        Me.ficAprobpagos.Controls.Add(Me.utpDetalle)
        Me.ficAprobpagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficAprobpagos.Location = New System.Drawing.Point(0, 0)
        Me.ficAprobpagos.Name = "ficAprobpagos"
        Me.ficAprobpagos.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficAprobpagos.Size = New System.Drawing.Size(1348, 447)
        Me.ficAprobpagos.TabIndex = 2
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.ficAprobpagos.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficAprobpagos.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 424)
        '
        'frm_ProgramacionPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1348, 447)
        Me.Controls.Add(Me.ficAprobpagos)
        Me.Name = "frm_ProgramacionPago"
        Me.Text = "Programación de Pago a Proveedores"
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griProgramacionPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion11.ResumeLayout(False)
        Me.Agrupacion11.PerformLayout()
        CType(Me.grupoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoEstado.ResumeLayout(False)
        Me.grupoEstado.PerformLayout()
        CType(Me.ColorGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorAnulado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatos.ResumeLayout(False)
        Me.agrDatos.PerformLayout()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrLote.ResumeLayout(False)
        Me.agrLote.PerformLayout()
        CType(Me.txtLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.gridDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.chkPagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralCuentaTrabajador.ResumeLayout(False)
        Me.Gb_DatoGeneralCuentaTrabajador.PerformLayout()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroLote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMonto.ResumeLayout(False)
        Me.gbMonto.PerformLayout()
        CType(Me.DecSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DecDetraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decPagoTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decRetencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decMontoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTrabProg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficAprobpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficAprobpagos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficAprobpagos As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grupoEstado As ISL.Controles.Agrupacion
    Friend WithEvents ColorGenerado As ISL.Controles.Colores
    Friend WithEvents ColorPagado As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents ColorAnulado As ISL.Controles.Colores
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents agrLote As ISL.Controles.Agrupacion
    Friend WithEvents txtLote As ISL.Controles.Texto
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents agrDatos As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents gridDocumentos As ISL.Controles.Grilla
    Friend WithEvents Gb_DatoGeneralCuentaTrabajador As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents gbMonto As ISL.Controles.Agrupacion
    Friend WithEvents decMontoOriginal As ISL.Controles.NumeroDecimal
    Friend WithEvents etiSubtotal As ISL.Controles.Etiqueta
    Friend WithEvents etiImpuesto As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents decRetencion As ISL.Controles.NumeroDecimal
    Friend WithEvents decMontoPago As ISL.Controles.NumeroDecimal
    Friend WithEvents txtOperaciones As ISL.Controles.Texto
    Friend WithEvents etiVoucher As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents decTipoCambio As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents fecProgramacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents txtTrabProg As ISL.Controles.Texto
    Friend WithEvents txtNroLote As ISL.Controles.Texto
    Friend WithEvents txtObservaciones As ISL.Controles.Texto
    Friend WithEvents lblcodigo As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel22 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboEstado As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents rbLote As System.Windows.Forms.RadioButton
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents Agrupacion11 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents griProgramacionPagos As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnPagar As ISL.Controles.Boton
    Friend WithEvents lblId As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblOperacion As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtEstado As ISL.Controles.Texto
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents cboMedio As ISL.Controles.Combo
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ugb_Guardar As ISL.Win.Espere
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents decPagoTC As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents DecDetraccion As ISL.Controles.NumeroDecimal
    Friend WithEvents txtProveedor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblEtProv As ISL.Controles.Etiqueta
    Friend WithEvents chkPagar As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents DecSaldo As ISL.Controles.NumeroDecimal
    Friend WithEvents ColorParcial As ISL.Controles.Colores
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents cboTipoGasto As ISL.Controles.Combo
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents fecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel

End Class
