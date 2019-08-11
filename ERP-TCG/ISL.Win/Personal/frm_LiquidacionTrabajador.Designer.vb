<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LiquidacionTrabajador
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
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngreso")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCese")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoCese")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("MotivoCese")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RemuneracionBasica")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PromGratificacion")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PromHorasExtras")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PromBoniProd")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AsigFamiliar")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CTSM")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CTSD")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CTSxM")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CTSxD")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTA")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTM")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTD")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTDGozadas")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTxA")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTxM")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTxD")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTGozadas")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VTxDescuentoAFP")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GTM")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GTD")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GTxM")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GTxD")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BoniExtra")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadGraciosa")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DT")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DTxD")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DTAsigFam")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DTEssaludVida")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DTDsctoAFP")
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dev5taCat")
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AdelantoSueldo")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalPagar")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioDT")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioGT")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioVT")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioCTS")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeAFP")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalPagarTexto")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DNI")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompletaDT")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompletaVT")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompletaCTS")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCompletaGT")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOcupacion")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocupacion")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngreso")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCese")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivoCese")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("MotivoCese")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RemuneracionBasica")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PromGratificacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PromHorasExtras")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PromBoniProd")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AsigFamiliar")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CTSM")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CTSD")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CTSxM")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CTSxD")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTA")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTM")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTD")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTDGozadas")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTxA")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTxM")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTxD")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTGozadas")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VTxDescuentoAFP")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GTM")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GTD")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GTxM")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GTxD")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("BoniExtra")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadGraciosa")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DT")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DTxD")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DTAsigFam")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DTEssaludVida")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DTDsctoAFP")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dev5taCat")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AdelantoSueldo")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalPagar")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioDT")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioGT")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioVT")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioCTS")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeAFP")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalPagarTexto")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DNI")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCompletaDT")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCompletaVT")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCompletaCTS")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCompletaGT")
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
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoContrato")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Trabajador")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoContrato")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTermino")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigencia")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sueldo")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaTruncamiento")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModalidadContrato")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModalidadContrato")
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMotivoCese")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOcupacion")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoContrato")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocupacion")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Trabajador")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoContrato")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTermino")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigencia")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sueldo")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaTruncamiento")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModalidadContrato")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModalidadContrato")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMotivoCese")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance167 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance168 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance169 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance170 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance171 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance172 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance173 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance174 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance175 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance176 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance177 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance178 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance179 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance180 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance181 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance182 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance183 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance184 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance185 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance186 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance187 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance188 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance189 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance190 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance191 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance192 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance193 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance194 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance195 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance196 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance197 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance198 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance199 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance200 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance201 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance202 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance203 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance204 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance205 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance206 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance207 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance208 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance209 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance210 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance211 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance212 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance213 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance214 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance215 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance216 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance217 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance218 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance219 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance220 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance221 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance222 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance223 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance224 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance225 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance226 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance227 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance228 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance229 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance230 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance231 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance232 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.griLiquidacionTrabajador = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdLiquidacionTrabajador = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.agrMenuLista = New ISL.Controles.Agrupacion(Me.components)
        Me.btnEliminar = New ISL.Controles.Boton(Me.components)
        Me.btnPagar = New ISL.Controles.Boton(Me.components)
        Me.btnFirmar = New ISL.Controles.Boton(Me.components)
        Me.btnEvaluar = New ISL.Controles.Boton(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.Colores5 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta64 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta65 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta66 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta67 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta68 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajadorBusqueda = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.utpMantenimiento = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Gb_DatoGeneralCuentaTrabajador = New Infragistics.Win.Misc.UltraGroupBox()
        Me.numPagoTotal = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta102 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaContable = New ISL.Controles.Combo(Me.components)
        Me.cboFlujoCaja = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta95 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboMedio = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta103 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta104 = New ISL.Controles.Etiqueta(Me.components)
        Me.lblId = New Infragistics.Win.Misc.UltraLabel()
        Me.lblOperacion = New ISL.Controles.Etiqueta(Me.components)
        Me.txtOperaciones = New ISL.Controles.Texto(Me.components)
        Me.etiVoucher = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCuentaBancaria = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta111 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecPago = New System.Windows.Forms.DateTimePicker()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.griContratos = New ISL.Controles.Grilla(Me.components)
        Me.ogdContratos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta72 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboPeriodo = New ISL.Controles.Combo(Me.components)
        Me.cboMotivoCese = New ISL.Controles.Combo(Me.components)
        Me.dtpFechaLiqui = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta63 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnCalcularLiquidacion = New ISL.Controles.Boton(Me.components)
        Me.agrDatosBasicos = New ISL.Controles.Agrupacion(Me.components)
        Me.txtCargo = New ISL.Controles.Texto(Me.components)
        Me.etiCargo = New ISL.Controles.Etiqueta(Me.components)
        Me.txtArea = New ISL.Controles.Texto(Me.components)
        Me.etiArea = New ISL.Controles.Etiqueta(Me.components)
        Me.FotoTrabajador = New System.Windows.Forms.PictureBox()
        Me.numTotalRemComp = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numGratificacion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numPromHorExt = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.numProBonProd = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numAsigFam = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numSueldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpFechaCese = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtTiempoServicios = New ISL.Controles.Texto(Me.components)
        Me.txtOcupacion = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me._utpMantenimiento_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantenimiento_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._utpMantenimiento_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.ND_AporteEsSalud = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta94 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnCalcular5ta = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta101 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta100 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta99 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta98 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta97 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta96 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimalDevolucion5ta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimalRetencion5ta = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta93 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtDTfaltas = New ISL.Controles.Texto(Me.components)
        Me.NumeroDecimalDTxFaltas = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimalDTRem = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta91 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta92 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta90 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta89 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta88 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtGTfaltas = New ISL.Controles.Texto(Me.components)
        Me.NumeroDecimalGTxF = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimalGTRem = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta86 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta87 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta85 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta84 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta83 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta82 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta81 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta80 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtVTfaltas = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta78 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimalVTxF = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimalVTRem = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta79 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta77 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta76 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta75 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCTSfaltas = New ISL.Controles.Texto(Me.components)
        Me.NumeroDecimalCTSxF = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimalCTSRem = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta73 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta74 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta71 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal3 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta70 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtVTDiasVacaciones = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta69 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta49 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.numAdelantoSueldo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCantGra = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiAFP1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiDsctAFP = New ISL.Controles.Etiqueta(Me.components)
        Me.numTotalLiquidacion = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtDiasdias = New ISL.Controles.Texto(Me.components)
        Me.txtGTdias = New ISL.Controles.Texto(Me.components)
        Me.txtGTmeses = New ISL.Controles.Texto(Me.components)
        Me.txtVTdias = New ISL.Controles.Texto(Me.components)
        Me.txtVTmeses = New ISL.Controles.Texto(Me.components)
        Me.txtVTaños = New ISL.Controles.Texto(Me.components)
        Me.txtCTSdias = New ISL.Controles.Texto(Me.components)
        Me.txtCTSmeses = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta62 = New ISL.Controles.Etiqueta(Me.components)
        Me.numDT = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal25 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta61 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal22 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal23 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal24 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal26 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtFechaTotalDT = New ISL.Controles.Texto(Me.components)
        Me.etiFFDT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFIDT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta57 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta58 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta59 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta60 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta56 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta54 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta55 = New ISL.Controles.Etiqueta(Me.components)
        Me.numBE = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.numTotalGT = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal16 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal17 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal18 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal19 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtFechaTotalGT = New ISL.Controles.Texto(Me.components)
        Me.etiFFGT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta48 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFIGT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta53 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.numTotalVT = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal13 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal14 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta43 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta42 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal11 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal6 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal7 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal8 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal9 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal10 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtFechaTotalVT = New ISL.Controles.Texto(Me.components)
        Me.etiFFVT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFIVT = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta38 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta39 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta40 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.numTotalCTS = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal4 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal5 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.NumeroDecimal2 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.NumeroDecimal1 = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtFechaTotalCTS = New ISL.Controles.Texto(Me.components)
        Me.etiFFCTS = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiFICTS = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.ficLiquidacionTrabajador = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.btnExtornar = New ISL.Controles.Boton(Me.components)
        Me.ExtornarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.griLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ogdLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMenuLista.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.Colores5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajadorBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utpMantenimiento.SuspendLayout()
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gb_DatoGeneralCuentaTrabajador.SuspendLayout()
        CType(Me.numPagoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.griContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotivoCese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatosBasicos.SuspendLayout()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalRemComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGratificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPromHorExt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProBonProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAsigFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTiempoServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOcupacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.ND_AporteEsSalud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalDevolucion5ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalRetencion5ta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDTfaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalDTxFaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalDTRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGTfaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalGTxF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalGTRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTfaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalVTxF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalVTRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCTSfaltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalCTSxF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimalCTSRem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTDiasVacaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAdelantoSueldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCantGra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGTdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGTmeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTmeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVTaños, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCTSdias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCTSmeses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaTotalDT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalGT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaTotalGT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaTotalVT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotalCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaTotalCTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficLiquidacionTrabajador.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1255, 562)
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion3)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1255, 562)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion3.Controls.Add(Me.agrMenuLista)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(3, 90)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1249, 469)
        Me.Agrupacion3.TabIndex = 1
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.griLiquidacionTrabajador)
        Me.Agrupacion7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(3, 33)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(1243, 433)
        Me.Agrupacion7.TabIndex = 15
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLiquidacionTrabajador
        '
        Me.griLiquidacionTrabajador.ContextMenuStrip = Me.MenuContextual1
        Me.griLiquidacionTrabajador.DataSource = Me.ogdLiquidacionTrabajador
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 2
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 3
        UltraGridColumn8.Width = 82
        UltraGridColumn9.Header.VisiblePosition = 7
        UltraGridColumn9.Width = 263
        UltraGridColumn10.Header.VisiblePosition = 6
        UltraGridColumn10.Width = 280
        UltraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn11.Width = 78
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Header.VisiblePosition = 13
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn12.Width = 77
        UltraGridColumn13.Header.VisiblePosition = 11
        UltraGridColumn13.Hidden = True
        UltraGridColumn14.Header.VisiblePosition = 12
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 14
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 16
        UltraGridColumn17.Width = 84
        UltraGridColumn18.Header.VisiblePosition = 17
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 8
        UltraGridColumn19.Width = 157
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance1
        UltraGridColumn20.Header.VisiblePosition = 18
        UltraGridColumn20.Hidden = True
        UltraGridColumn20.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance2.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance2
        UltraGridColumn21.Header.VisiblePosition = 19
        UltraGridColumn21.Hidden = True
        UltraGridColumn21.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance3
        UltraGridColumn22.Header.VisiblePosition = 20
        UltraGridColumn22.Hidden = True
        UltraGridColumn22.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance4
        UltraGridColumn23.Header.VisiblePosition = 21
        UltraGridColumn23.Hidden = True
        UltraGridColumn23.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn24.CellAppearance = Appearance5
        UltraGridColumn24.Header.VisiblePosition = 22
        UltraGridColumn24.Hidden = True
        UltraGridColumn24.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn24.Width = 88
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn25.CellAppearance = Appearance6
        UltraGridColumn25.Header.VisiblePosition = 23
        UltraGridColumn25.Hidden = True
        Appearance7.TextHAlignAsString = "Right"
        UltraGridColumn26.CellAppearance = Appearance7
        UltraGridColumn26.Header.VisiblePosition = 24
        UltraGridColumn26.Hidden = True
        Appearance8.TextHAlignAsString = "Right"
        UltraGridColumn27.CellAppearance = Appearance8
        UltraGridColumn27.Header.VisiblePosition = 25
        UltraGridColumn27.Hidden = True
        Appearance9.TextHAlignAsString = "Right"
        UltraGridColumn28.CellAppearance = Appearance9
        UltraGridColumn28.Header.VisiblePosition = 26
        UltraGridColumn28.Hidden = True
        Appearance10.TextHAlignAsString = "Right"
        UltraGridColumn29.CellAppearance = Appearance10
        UltraGridColumn29.Header.VisiblePosition = 27
        UltraGridColumn29.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn30.CellAppearance = Appearance11
        UltraGridColumn30.Header.VisiblePosition = 28
        UltraGridColumn30.Hidden = True
        Appearance12.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance12
        UltraGridColumn31.Header.VisiblePosition = 29
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 53
        UltraGridColumn32.Hidden = True
        Appearance13.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance13
        UltraGridColumn33.Header.VisiblePosition = 30
        UltraGridColumn33.Hidden = True
        Appearance14.TextHAlignAsString = "Right"
        UltraGridColumn34.CellAppearance = Appearance14
        UltraGridColumn34.Header.VisiblePosition = 31
        UltraGridColumn34.Hidden = True
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn35.CellAppearance = Appearance15
        UltraGridColumn35.Header.VisiblePosition = 32
        UltraGridColumn35.Hidden = True
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn36.CellAppearance = Appearance16
        UltraGridColumn36.Header.VisiblePosition = 33
        UltraGridColumn36.Hidden = True
        Appearance17.TextHAlignAsString = "Right"
        UltraGridColumn37.CellAppearance = Appearance17
        UltraGridColumn37.Header.VisiblePosition = 34
        UltraGridColumn37.Hidden = True
        Appearance18.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance18
        UltraGridColumn38.Header.VisiblePosition = 35
        UltraGridColumn38.Hidden = True
        Appearance19.TextHAlignAsString = "Right"
        UltraGridColumn39.CellAppearance = Appearance19
        UltraGridColumn39.Header.VisiblePosition = 36
        UltraGridColumn39.Hidden = True
        Appearance20.TextHAlignAsString = "Right"
        UltraGridColumn40.CellAppearance = Appearance20
        UltraGridColumn40.Header.VisiblePosition = 37
        UltraGridColumn40.Hidden = True
        Appearance21.TextHAlignAsString = "Right"
        UltraGridColumn41.CellAppearance = Appearance21
        UltraGridColumn41.Header.VisiblePosition = 38
        UltraGridColumn41.Hidden = True
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn42.CellAppearance = Appearance22
        UltraGridColumn42.Header.VisiblePosition = 39
        UltraGridColumn42.Hidden = True
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn43.CellAppearance = Appearance23
        UltraGridColumn43.Header.VisiblePosition = 40
        UltraGridColumn43.Hidden = True
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn44.CellAppearance = Appearance24
        UltraGridColumn44.Header.VisiblePosition = 41
        UltraGridColumn44.Hidden = True
        Appearance25.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance25
        UltraGridColumn45.Header.VisiblePosition = 42
        UltraGridColumn45.Hidden = True
        Appearance26.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance26
        UltraGridColumn46.Header.VisiblePosition = 43
        UltraGridColumn46.Hidden = True
        Appearance27.TextHAlignAsString = "Right"
        UltraGridColumn47.CellAppearance = Appearance27
        UltraGridColumn47.Header.VisiblePosition = 44
        UltraGridColumn47.Hidden = True
        Appearance28.TextHAlignAsString = "Right"
        UltraGridColumn49.CellAppearance = Appearance28
        UltraGridColumn49.Header.VisiblePosition = 45
        UltraGridColumn49.Hidden = True
        Appearance29.TextHAlignAsString = "Right"
        UltraGridColumn50.CellAppearance = Appearance29
        UltraGridColumn50.Header.VisiblePosition = 46
        UltraGridColumn50.Hidden = True
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance30
        UltraGridColumn51.Header.VisiblePosition = 47
        UltraGridColumn51.Hidden = True
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance31
        UltraGridColumn52.Header.VisiblePosition = 9
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn54.Header.VisiblePosition = 4
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn54.Width = 85
        UltraGridColumn58.Header.VisiblePosition = 48
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 49
        UltraGridColumn59.Hidden = True
        UltraGridColumn66.Header.VisiblePosition = 50
        UltraGridColumn66.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 51
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 52
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 54
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 5
        UltraGridColumn136.Width = 77
        UltraGridColumn137.Header.VisiblePosition = 55
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.VisiblePosition = 56
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 57
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 58
        UltraGridColumn140.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn54, UltraGridColumn58, UltraGridColumn59, UltraGridColumn66, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140})
        Me.griLiquidacionTrabajador.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLiquidacionTrabajador.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance32.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance32.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance32.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance32.BorderColor = System.Drawing.SystemColors.Window
        Me.griLiquidacionTrabajador.DisplayLayout.GroupByBox.Appearance = Appearance32
        Appearance33.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLiquidacionTrabajador.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance33
        Me.griLiquidacionTrabajador.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLiquidacionTrabajador.DisplayLayout.GroupByBox.Hidden = True
        Appearance34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance34.BackColor2 = System.Drawing.SystemColors.Control
        Appearance34.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance34.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLiquidacionTrabajador.DisplayLayout.GroupByBox.PromptAppearance = Appearance34
        Me.griLiquidacionTrabajador.DisplayLayout.MaxColScrollRegions = 1
        Me.griLiquidacionTrabajador.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLiquidacionTrabajador.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacionTrabajador.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLiquidacionTrabajador.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLiquidacionTrabajador.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.griLiquidacionTrabajador.DisplayLayout.Override.CellAppearance = Appearance35
        Me.griLiquidacionTrabajador.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLiquidacionTrabajador.DisplayLayout.Override.CellPadding = 0
        Me.griLiquidacionTrabajador.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLiquidacionTrabajador.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLiquidacionTrabajador.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance36.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griLiquidacionTrabajador.DisplayLayout.Override.GroupByRowAppearance = Appearance36
        Appearance37.TextHAlignAsString = "Left"
        Me.griLiquidacionTrabajador.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.griLiquidacionTrabajador.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance38.BorderColor = System.Drawing.Color.Silver
        Me.griLiquidacionTrabajador.DisplayLayout.Override.RowAppearance = Appearance38
        Me.griLiquidacionTrabajador.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLiquidacionTrabajador.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLiquidacionTrabajador.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLiquidacionTrabajador.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLiquidacionTrabajador.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLiquidacionTrabajador.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLiquidacionTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLiquidacionTrabajador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLiquidacionTrabajador.Location = New System.Drawing.Point(3, 3)
        Me.griLiquidacionTrabajador.Name = "griLiquidacionTrabajador"
        Me.griLiquidacionTrabajador.Size = New System.Drawing.Size(1237, 427)
        Me.griLiquidacionTrabajador.TabIndex = 14
        Me.griLiquidacionTrabajador.TabStop = False
        Me.griLiquidacionTrabajador.Text = "Grilla1"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.EvaluarToolStripMenuItem, Me.FirmarToolStripMenuItem, Me.PagarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ExtornarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(153, 180)
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        Me.NuevoToolStripMenuItem.ToolTipText = "Nueva liquidacion"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        Me.EditarToolStripMenuItem.ToolTipText = "Editar Liquidacion"
        '
        'EvaluarToolStripMenuItem
        '
        Me.EvaluarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.kdict
        Me.EvaluarToolStripMenuItem.Name = "EvaluarToolStripMenuItem"
        Me.EvaluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EvaluarToolStripMenuItem.Text = "Evaluar"
        Me.EvaluarToolStripMenuItem.ToolTipText = "Evaluar Liquidacion"
        '
        'FirmarToolStripMenuItem
        '
        Me.FirmarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.hire_me
        Me.FirmarToolStripMenuItem.Name = "FirmarToolStripMenuItem"
        Me.FirmarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FirmarToolStripMenuItem.Text = "Firmar"
        Me.FirmarToolStripMenuItem.ToolTipText = "Firmar Liquidacion"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PagarToolStripMenuItem.Text = "Pagar"
        Me.PagarToolStripMenuItem.ToolTipText = "Pagar Liquidacion"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ogdLiquidacionTrabajador
        '
        UltraDataColumn7.DataType = GetType(Date)
        UltraDataColumn8.DataType = GetType(Date)
        UltraDataColumn16.DataType = GetType(Double)
        UltraDataColumn17.DataType = GetType(Double)
        UltraDataColumn18.DataType = GetType(Double)
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn20.DataType = GetType(Double)
        UltraDataColumn21.DataType = GetType(Short)
        UltraDataColumn22.DataType = GetType(Short)
        UltraDataColumn23.DataType = GetType(Double)
        UltraDataColumn24.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Short)
        UltraDataColumn26.DataType = GetType(Short)
        UltraDataColumn27.DataType = GetType(Short)
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Double)
        UltraDataColumn31.DataType = GetType(Double)
        UltraDataColumn32.DataType = GetType(Double)
        UltraDataColumn33.DataType = GetType(Double)
        UltraDataColumn34.DataType = GetType(Short)
        UltraDataColumn35.DataType = GetType(Short)
        UltraDataColumn36.DataType = GetType(Double)
        UltraDataColumn37.DataType = GetType(Double)
        UltraDataColumn38.DataType = GetType(Double)
        UltraDataColumn39.DataType = GetType(Double)
        UltraDataColumn40.DataType = GetType(Short)
        UltraDataColumn41.DataType = GetType(Double)
        UltraDataColumn42.DataType = GetType(Double)
        UltraDataColumn43.DataType = GetType(Double)
        UltraDataColumn45.DataType = GetType(Double)
        UltraDataColumn46.DataType = GetType(Double)
        UltraDataColumn47.DataType = GetType(Double)
        UltraDataColumn48.DataType = GetType(Date)
        UltraDataColumn49.DataType = GetType(Date)
        UltraDataColumn50.DataType = GetType(Date)
        UltraDataColumn51.DataType = GetType(Date)
        UltraDataColumn52.DataType = GetType(Date)
        UltraDataColumn53.DataType = GetType(Double)
        Me.ogdLiquidacionTrabajador.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'agrMenuLista
        '
        Me.agrMenuLista.Controls.Add(Me.btnExtornar)
        Me.agrMenuLista.Controls.Add(Me.btnEliminar)
        Me.agrMenuLista.Controls.Add(Me.btnPagar)
        Me.agrMenuLista.Controls.Add(Me.btnFirmar)
        Me.agrMenuLista.Controls.Add(Me.btnEvaluar)
        Me.agrMenuLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrMenuLista.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMenuLista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMenuLista.Location = New System.Drawing.Point(3, 3)
        Me.agrMenuLista.Name = "agrMenuLista"
        Me.agrMenuLista.Size = New System.Drawing.Size(1243, 30)
        Me.agrMenuLista.TabIndex = 14
        Me.agrMenuLista.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnEliminar
        '
        Appearance40.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance40.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnEliminar.Appearance = Appearance40
        Me.btnEliminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Location = New System.Drawing.Point(228, 3)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 24)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnPagar
        '
        Appearance41.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance41.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Me.btnPagar.Appearance = Appearance41
        Me.btnPagar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPagar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPagar.Enabled = False
        Me.btnPagar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Black
        Me.btnPagar.Location = New System.Drawing.Point(152, 3)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(76, 24)
        Me.btnPagar.TabIndex = 2
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnFirmar
        '
        Appearance42.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance42.Image = Global.ISL.Win.My.Resources.Resources.hire_me
        Me.btnFirmar.Appearance = Appearance42
        Me.btnFirmar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnFirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFirmar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFirmar.Enabled = False
        Me.btnFirmar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirmar.ForeColor = System.Drawing.Color.Black
        Me.btnFirmar.Location = New System.Drawing.Point(81, 3)
        Me.btnFirmar.Name = "btnFirmar"
        Me.btnFirmar.Size = New System.Drawing.Size(71, 24)
        Me.btnFirmar.TabIndex = 1
        Me.btnFirmar.Text = "Firmar"
        Me.btnFirmar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'btnEvaluar
        '
        Appearance43.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance43.Image = Global.ISL.Win.My.Resources.Resources.kdvi
        Me.btnEvaluar.Appearance = Appearance43
        Me.btnEvaluar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnEvaluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEvaluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEvaluar.Enabled = False
        Me.btnEvaluar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluar.ForeColor = System.Drawing.Color.Black
        Me.btnEvaluar.Location = New System.Drawing.Point(3, 3)
        Me.btnEvaluar.Name = "btnEvaluar"
        Me.btnEvaluar.Size = New System.Drawing.Size(78, 24)
        Me.btnEvaluar.TabIndex = 0
        Me.btnEvaluar.Text = "Evaluar"
        Me.btnEvaluar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.Agrupacion8)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion2.Controls.Add(Me.cboTrabajadorBusqueda)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion2.Controls.Add(Me.fecHasta)
        Me.Agrupacion2.Controls.Add(Me.fecDesde)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(3, 3)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1249, 87)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Datos"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion8
        '
        Me.Agrupacion8.Controls.Add(Me.Colores5)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta64)
        Me.Agrupacion8.Controls.Add(Me.Colores4)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta65)
        Me.Agrupacion8.Controls.Add(Me.Colores3)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta66)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta67)
        Me.Agrupacion8.Controls.Add(Me.Etiqueta68)
        Me.Agrupacion8.Controls.Add(Me.Colores2)
        Me.Agrupacion8.Controls.Add(Me.Colores1)
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(160, 44)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(584, 34)
        Me.Agrupacion8.TabIndex = 40
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Colores5
        '
        Me.Colores5.Color = System.Drawing.Color.Wheat
        Me.Colores5.Location = New System.Drawing.Point(527, 6)
        Me.Colores5.Name = "Colores5"
        Me.Colores5.Size = New System.Drawing.Size(43, 21)
        Me.Colores5.TabIndex = 47
        Me.Colores5.Text = "Wheat"
        '
        'Etiqueta64
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta64.Appearance = Appearance44
        Me.Etiqueta64.AutoSize = True
        Me.Etiqueta64.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta64.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta64.Location = New System.Drawing.Point(472, 10)
        Me.Etiqueta64.Name = "Etiqueta64"
        Me.Etiqueta64.Size = New System.Drawing.Size(43, 15)
        Me.Etiqueta64.TabIndex = 45
        Me.Etiqueta64.Text = "Pagada:"
        '
        'Colores4
        '
        Me.Colores4.Color = System.Drawing.Color.DarkGray
        Me.Colores4.Location = New System.Drawing.Point(412, 6)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(43, 21)
        Me.Colores4.TabIndex = 46
        Me.Colores4.Text = "DarkGray"
        '
        'Etiqueta65
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta65.Appearance = Appearance45
        Me.Etiqueta65.AutoSize = True
        Me.Etiqueta65.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta65.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta65.Location = New System.Drawing.Point(359, 10)
        Me.Etiqueta65.Name = "Etiqueta65"
        Me.Etiqueta65.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta65.TabIndex = 44
        Me.Etiqueta65.Text = "Firmada:"
        '
        'Colores3
        '
        Me.Colores3.Color = System.Drawing.Color.SkyBlue
        Me.Colores3.Location = New System.Drawing.Point(301, 6)
        Me.Colores3.Name = "Colores3"
        Me.Colores3.Size = New System.Drawing.Size(43, 21)
        Me.Colores3.TabIndex = 44
        Me.Colores3.Text = "SkyBlue"
        '
        'Etiqueta66
        '
        Appearance46.BackColor = System.Drawing.Color.Transparent
        Appearance46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta66.Appearance = Appearance46
        Me.Etiqueta66.AutoSize = True
        Me.Etiqueta66.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta66.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta66.Location = New System.Drawing.Point(4, 9)
        Me.Etiqueta66.Name = "Etiqueta66"
        Me.Etiqueta66.Size = New System.Drawing.Size(55, 15)
        Me.Etiqueta66.TabIndex = 36
        Me.Etiqueta66.Text = "Generada:"
        '
        'Etiqueta67
        '
        Appearance47.BackColor = System.Drawing.Color.Transparent
        Appearance47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta67.Appearance = Appearance47
        Me.Etiqueta67.AutoSize = True
        Me.Etiqueta67.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta67.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta67.Location = New System.Drawing.Point(125, 10)
        Me.Etiqueta67.Name = "Etiqueta67"
        Me.Etiqueta67.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta67.TabIndex = 33
        Me.Etiqueta67.Text = "Calculada:"
        '
        'Etiqueta68
        '
        Appearance48.BackColor = System.Drawing.Color.Transparent
        Appearance48.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta68.Appearance = Appearance48
        Me.Etiqueta68.AutoSize = True
        Me.Etiqueta68.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta68.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta68.Location = New System.Drawing.Point(241, 10)
        Me.Etiqueta68.Name = "Etiqueta68"
        Me.Etiqueta68.Size = New System.Drawing.Size(54, 15)
        Me.Etiqueta68.TabIndex = 38
        Me.Etiqueta68.Text = "Aprobada:"
        '
        'Colores2
        '
        Me.Colores2.Color = System.Drawing.Color.LightGreen
        Me.Colores2.Location = New System.Drawing.Point(185, 6)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(43, 21)
        Me.Colores2.TabIndex = 32
        Me.Colores2.Text = "LightGreen"
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.White
        Me.Colores1.Location = New System.Drawing.Point(67, 6)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(43, 21)
        Me.Colores1.TabIndex = 35
        Me.Colores1.Text = "White"
        '
        'Etiqueta9
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta9.Appearance = Appearance49
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta9.Location = New System.Drawing.Point(160, 24)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta9.TabIndex = 5
        Me.Etiqueta9.Text = "Trabajador:"
        '
        'cboTrabajadorBusqueda
        '
        Appearance50.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorBusqueda.Appearance = Appearance50
        Me.cboTrabajadorBusqueda.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajadorBusqueda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajadorBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajadorBusqueda.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajadorBusqueda.Location = New System.Drawing.Point(226, 20)
        Me.cboTrabajadorBusqueda.Name = "cboTrabajadorBusqueda"
        Me.cboTrabajadorBusqueda.Size = New System.Drawing.Size(408, 21)
        Me.cboTrabajadorBusqueda.TabIndex = 4
        Me.cboTrabajadorBusqueda.ValueMember = "Id"
        '
        'Etiqueta2
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance51
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 54)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta2.TabIndex = 3
        Me.Etiqueta2.Text = "Hasta:"
        '
        'Etiqueta1
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance52
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 29)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta1.TabIndex = 2
        Me.Etiqueta1.Text = "Desde:"
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(50, 51)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(104, 20)
        Me.fecHasta.TabIndex = 1
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(50, 26)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(104, 20)
        Me.fecDesde.TabIndex = 0
        '
        'utpMantenimiento
        '
        Me.utpMantenimiento.Controls.Add(Me.Gb_DatoGeneralCuentaTrabajador)
        Me.utpMantenimiento.Controls.Add(Me.Agrupacion5)
        Me.utpMantenimiento.Controls.Add(Me.Agrupacion4)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Left)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Right)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Bottom)
        Me.utpMantenimiento.Controls.Add(Me._utpMantenimiento_Toolbars_Dock_Area_Top)
        Me.utpMantenimiento.Enabled = False
        Me.utpMantenimiento.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpMantenimiento.Name = "utpMantenimiento"
        Me.utpMantenimiento.Size = New System.Drawing.Size(1255, 562)
        '
        'Gb_DatoGeneralCuentaTrabajador
        '
        Appearance53.BackColor = System.Drawing.Color.White
        Appearance53.BackColor2 = System.Drawing.Color.White
        Me.Gb_DatoGeneralCuentaTrabajador.ContentAreaAppearance = Appearance53
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.numPagoTotal)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta102)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboCuentaContable)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboFlujoCaja)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta95)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboMedio)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta103)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta104)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblId)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.lblOperacion)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.txtOperaciones)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.etiVoucher)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.cboCuentaBancaria)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.Etiqueta111)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.fecPago)
        Me.Gb_DatoGeneralCuentaTrabajador.Controls.Add(Me.UltraLabel1)
        Me.Gb_DatoGeneralCuentaTrabajador.Location = New System.Drawing.Point(795, 26)
        Me.Gb_DatoGeneralCuentaTrabajador.Name = "Gb_DatoGeneralCuentaTrabajador"
        Me.Gb_DatoGeneralCuentaTrabajador.Size = New System.Drawing.Size(403, 177)
        Me.Gb_DatoGeneralCuentaTrabajador.TabIndex = 263
        Me.Gb_DatoGeneralCuentaTrabajador.Text = "Datos de Pago"
        Me.Gb_DatoGeneralCuentaTrabajador.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.Gb_DatoGeneralCuentaTrabajador.Visible = False
        '
        'numPagoTotal
        '
        Appearance54.ForeColor = System.Drawing.Color.Black
        Me.numPagoTotal.Appearance = Appearance54
        Me.numPagoTotal.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPagoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPagoTotal.ForeColor = System.Drawing.Color.Black
        Me.numPagoTotal.Location = New System.Drawing.Point(289, 147)
        Me.numPagoTotal.Name = "numPagoTotal"
        Me.numPagoTotal.NullText = "0.00"
        Me.numPagoTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPagoTotal.ReadOnly = True
        Me.numPagoTotal.Size = New System.Drawing.Size(95, 21)
        Me.numPagoTotal.TabIndex = 340
        Me.numPagoTotal.TabStop = False
        '
        'Etiqueta102
        '
        Appearance55.BackColor = System.Drawing.Color.Transparent
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta102.Appearance = Appearance55
        Me.Etiqueta102.AutoSize = True
        Me.Etiqueta102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta102.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta102.Location = New System.Drawing.Point(175, 151)
        Me.Etiqueta102.Name = "Etiqueta102"
        Me.Etiqueta102.Size = New System.Drawing.Size(100, 14)
        Me.Etiqueta102.TabIndex = 339
        Me.Etiqueta102.Text = "TOTAL A PAGAR:"
        '
        'cboCuentaContable
        '
        Appearance56.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Appearance = Appearance56
        Me.cboCuentaContable.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaContable.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaContable.DropDownListWidth = 400
        Me.cboCuentaContable.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaContable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaContable.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaContable.Location = New System.Drawing.Point(91, 22)
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.ReadOnly = True
        Me.cboCuentaContable.Size = New System.Drawing.Size(293, 22)
        Me.cboCuentaContable.TabIndex = 338
        Me.cboCuentaContable.ValueMember = "Id"
        '
        'cboFlujoCaja
        '
        Appearance57.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Appearance = Appearance57
        Me.cboFlujoCaja.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlujoCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlujoCaja.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlujoCaja.ForeColor = System.Drawing.Color.Black
        Me.cboFlujoCaja.Location = New System.Drawing.Point(91, 123)
        Me.cboFlujoCaja.Name = "cboFlujoCaja"
        Me.cboFlujoCaja.ReadOnly = True
        Me.cboFlujoCaja.Size = New System.Drawing.Size(293, 22)
        Me.cboFlujoCaja.TabIndex = 336
        Me.cboFlujoCaja.ValueMember = "Id"
        '
        'Etiqueta95
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta95.Appearance = Appearance58
        Me.Etiqueta95.AutoSize = True
        Me.Etiqueta95.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta95.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta95.Location = New System.Drawing.Point(15, 128)
        Me.Etiqueta95.Name = "Etiqueta95"
        Me.Etiqueta95.Size = New System.Drawing.Size(58, 15)
        Me.Etiqueta95.TabIndex = 335
        Me.Etiqueta95.Text = "Flujo Caja:"
        '
        'cboMedio
        '
        Appearance59.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Appearance = Appearance59
        Me.cboMedio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMedio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMedio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedio.ForeColor = System.Drawing.Color.Black
        Me.cboMedio.Location = New System.Drawing.Point(91, 95)
        Me.cboMedio.Name = "cboMedio"
        Me.cboMedio.Size = New System.Drawing.Size(293, 22)
        Me.cboMedio.TabIndex = 336
        Me.cboMedio.ValueMember = "Id"
        '
        'Etiqueta103
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta103.Appearance = Appearance60
        Me.Etiqueta103.AutoSize = True
        Me.Etiqueta103.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta103.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta103.Location = New System.Drawing.Point(15, 24)
        Me.Etiqueta103.Name = "Etiqueta103"
        Me.Etiqueta103.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta103.TabIndex = 337
        Me.Etiqueta103.Text = "Cta. Ctble.:"
        '
        'Etiqueta104
        '
        Appearance61.BackColor = System.Drawing.Color.Transparent
        Appearance61.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta104.Appearance = Appearance61
        Me.Etiqueta104.AutoSize = True
        Me.Etiqueta104.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta104.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta104.Location = New System.Drawing.Point(15, 99)
        Me.Etiqueta104.Name = "Etiqueta104"
        Me.Etiqueta104.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta104.TabIndex = 335
        Me.Etiqueta104.Text = "Medio Pago:"
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(133, 24)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(28, 16)
        Me.lblId.TabIndex = 334
        '
        'lblOperacion
        '
        Appearance62.BackColor = System.Drawing.Color.Transparent
        Appearance62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Appearance62.TextHAlignAsString = "Center"
        Appearance62.TextVAlignAsString = "Middle"
        Me.lblOperacion.Appearance = Appearance62
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperacion.ForeColor = System.Drawing.Color.Black
        Me.lblOperacion.Location = New System.Drawing.Point(815, 146)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 0)
        Me.lblOperacion.TabIndex = 332
        '
        'txtOperaciones
        '
        Me.txtOperaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOperaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperaciones.Location = New System.Drawing.Point(91, 71)
        Me.txtOperaciones.Name = "txtOperaciones"
        Me.txtOperaciones.Size = New System.Drawing.Size(100, 21)
        Me.txtOperaciones.TabIndex = 26
        '
        'etiVoucher
        '
        Appearance63.BackColor = System.Drawing.Color.Transparent
        Appearance63.ForeColor = System.Drawing.Color.Navy
        Me.etiVoucher.Appearance = Appearance63
        Me.etiVoucher.AutoSize = True
        Me.etiVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiVoucher.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiVoucher.Location = New System.Drawing.Point(15, 76)
        Me.etiVoucher.Name = "etiVoucher"
        Me.etiVoucher.Size = New System.Drawing.Size(58, 14)
        Me.etiVoucher.TabIndex = 25
        Me.etiVoucher.Text = "Operacion:"
        '
        'cboCuentaBancaria
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Appearance = Appearance64
        Me.cboCuentaBancaria.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCuentaBancaria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCuentaBancaria.DropDownListWidth = 600
        Me.cboCuentaBancaria.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCuentaBancaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCuentaBancaria.ForeColor = System.Drawing.Color.Black
        Me.cboCuentaBancaria.Location = New System.Drawing.Point(91, 47)
        Me.cboCuentaBancaria.Name = "cboCuentaBancaria"
        Me.cboCuentaBancaria.Size = New System.Drawing.Size(293, 21)
        Me.cboCuentaBancaria.TabIndex = 24
        Me.cboCuentaBancaria.ValueMember = "Id"
        '
        'Etiqueta111
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta111.Appearance = Appearance65
        Me.Etiqueta111.AutoSize = True
        Me.Etiqueta111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta111.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta111.Location = New System.Drawing.Point(15, 51)
        Me.Etiqueta111.Name = "Etiqueta111"
        Me.Etiqueta111.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta111.TabIndex = 23
        Me.Etiqueta111.Text = "Cta Banco:"
        '
        'fecPago
        '
        Me.fecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecPago.Location = New System.Drawing.Point(281, 70)
        Me.fecPago.Name = "fecPago"
        Me.fecPago.Size = New System.Drawing.Size(103, 20)
        Me.fecPago.TabIndex = 20
        '
        'UltraLabel1
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Appearance66.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance66
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(207, 74)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Fecha Pago:"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.griContratos)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 218)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1255, 344)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.Text = "Contratos a Liquidar"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griContratos
        '
        Me.griContratos.DataSource = Me.ogdContratos
        UltraGridColumn141.Header.VisiblePosition = 0
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 1
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 2
        UltraGridColumn143.Hidden = True
        UltraGridColumn144.Header.VisiblePosition = 3
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 4
        UltraGridColumn145.Width = 82
        UltraGridColumn146.Header.VisiblePosition = 5
        UltraGridColumn146.Width = 212
        UltraGridColumn147.Header.VisiblePosition = 6
        UltraGridColumn147.Width = 264
        UltraGridColumn148.Header.VisiblePosition = 7
        UltraGridColumn148.Width = 189
        UltraGridColumn149.Header.VisiblePosition = 10
        UltraGridColumn150.Header.VisiblePosition = 11
        UltraGridColumn151.Header.VisiblePosition = 12
        UltraGridColumn151.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn152.Header.VisiblePosition = 13
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 14
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 15
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 16
        UltraGridColumn155.Hidden = True
        Appearance67.TextHAlignAsString = "Right"
        UltraGridColumn156.CellAppearance = Appearance67
        UltraGridColumn156.Header.VisiblePosition = 9
        UltraGridColumn156.MaskInput = "{double:9.2}"
        UltraGridColumn156.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn157.Header.VisiblePosition = 17
        UltraGridColumn158.Header.VisiblePosition = 18
        UltraGridColumn158.Hidden = True
        UltraGridColumn159.Header.VisiblePosition = 19
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.Header.VisiblePosition = 20
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.Header.VisiblePosition = 8
        UltraGridColumn161.Width = 182
        UltraGridColumn162.Header.VisiblePosition = 21
        UltraGridColumn162.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162})
        Me.griContratos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griContratos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griContratos.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance68.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance68.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance68.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance68.BorderColor = System.Drawing.SystemColors.Window
        Me.griContratos.DisplayLayout.GroupByBox.Appearance = Appearance68
        Appearance69.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griContratos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance69
        Me.griContratos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griContratos.DisplayLayout.GroupByBox.Hidden = True
        Appearance70.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance70.BackColor2 = System.Drawing.SystemColors.Control
        Appearance70.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griContratos.DisplayLayout.GroupByBox.PromptAppearance = Appearance70
        Me.griContratos.DisplayLayout.MaxColScrollRegions = 1
        Me.griContratos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griContratos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.griContratos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griContratos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griContratos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.griContratos.DisplayLayout.Override.CellAppearance = Appearance71
        Me.griContratos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griContratos.DisplayLayout.Override.CellPadding = 0
        Me.griContratos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griContratos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance72.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griContratos.DisplayLayout.Override.GroupByRowAppearance = Appearance72
        Appearance73.TextHAlignAsString = "Left"
        Me.griContratos.DisplayLayout.Override.HeaderAppearance = Appearance73
        Me.griContratos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance74.BorderColor = System.Drawing.Color.Silver
        Me.griContratos.DisplayLayout.Override.RowAppearance = Appearance74
        Me.griContratos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griContratos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griContratos.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griContratos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griContratos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griContratos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griContratos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griContratos.Location = New System.Drawing.Point(3, 16)
        Me.griContratos.Name = "griContratos"
        Me.griContratos.Size = New System.Drawing.Size(1249, 325)
        Me.griContratos.TabIndex = 14
        Me.griContratos.TabStop = False
        Me.griContratos.Text = "Grilla1"
        '
        'ogdContratos
        '
        UltraDataColumn68.DataType = GetType(Date)
        UltraDataColumn69.DataType = GetType(Date)
        UltraDataColumn70.DataType = GetType(Byte)
        UltraDataColumn75.DataType = GetType(Double)
        UltraDataColumn78.DataType = GetType(Date)
        Me.ogdContratos.Band.Columns.AddRange(New Object() {UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81})
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.Etiqueta72)
        Me.Agrupacion4.Controls.Add(Me.cboPeriodo)
        Me.Agrupacion4.Controls.Add(Me.cboMotivoCese)
        Me.Agrupacion4.Controls.Add(Me.dtpFechaLiqui)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta63)
        Me.Agrupacion4.Controls.Add(Me.btnCalcularLiquidacion)
        Me.Agrupacion4.Controls.Add(Me.agrDatosBasicos)
        Me.Agrupacion4.Controls.Add(Me.FotoTrabajador)
        Me.Agrupacion4.Controls.Add(Me.numTotalRemComp)
        Me.Agrupacion4.Controls.Add(Me.numGratificacion)
        Me.Agrupacion4.Controls.Add(Me.numPromHorExt)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion4.Controls.Add(Me.numProBonProd)
        Me.Agrupacion4.Controls.Add(Me.numAsigFam)
        Me.Agrupacion4.Controls.Add(Me.numSueldo)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion4.Controls.Add(Me.dtpFechaCese)
        Me.Agrupacion4.Controls.Add(Me.dtpFechaIngreso)
        Me.Agrupacion4.Controls.Add(Me.txtTiempoServicios)
        Me.Agrupacion4.Controls.Add(Me.txtOcupacion)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta6)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion4.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1255, 218)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Datos"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta72
        '
        Appearance75.BackColor = System.Drawing.Color.Transparent
        Appearance75.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta72.Appearance = Appearance75
        Me.Etiqueta72.AutoSize = True
        Me.Etiqueta72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta72.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta72.Location = New System.Drawing.Point(272, 25)
        Me.Etiqueta72.Name = "Etiqueta72"
        Me.Etiqueta72.Size = New System.Drawing.Size(45, 14)
        Me.Etiqueta72.TabIndex = 262
        Me.Etiqueta72.Text = "Periodo:"
        '
        'cboPeriodo
        '
        Appearance76.ForeColor = System.Drawing.Color.Black
        Me.cboPeriodo.Appearance = Appearance76
        Me.cboPeriodo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPeriodo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodo.ForeColor = System.Drawing.Color.Black
        Me.cboPeriodo.Location = New System.Drawing.Point(323, 21)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(107, 22)
        Me.cboPeriodo.TabIndex = 261
        Me.cboPeriodo.ValueMember = "Id"
        '
        'cboMotivoCese
        '
        Appearance77.ForeColor = System.Drawing.Color.Black
        Me.cboMotivoCese.Appearance = Appearance77
        Me.cboMotivoCese.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMotivoCese.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMotivoCese.DropDownListWidth = 300
        Me.cboMotivoCese.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMotivoCese.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivoCese.ForeColor = System.Drawing.Color.Black
        Me.cboMotivoCese.Location = New System.Drawing.Point(126, 155)
        Me.cboMotivoCese.Name = "cboMotivoCese"
        Me.cboMotivoCese.Size = New System.Drawing.Size(304, 21)
        Me.cboMotivoCese.TabIndex = 11
        Me.cboMotivoCese.ValueMember = "Id"
        '
        'dtpFechaLiqui
        '
        Me.dtpFechaLiqui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLiqui.Location = New System.Drawing.Point(126, 23)
        Me.dtpFechaLiqui.Name = "dtpFechaLiqui"
        Me.dtpFechaLiqui.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaLiqui.TabIndex = 260
        '
        'Etiqueta63
        '
        Appearance78.BackColor = System.Drawing.Color.Transparent
        Appearance78.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta63.Appearance = Appearance78
        Me.Etiqueta63.AutoSize = True
        Me.Etiqueta63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta63.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta63.Location = New System.Drawing.Point(80, 25)
        Me.Etiqueta63.Name = "Etiqueta63"
        Me.Etiqueta63.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta63.TabIndex = 259
        Me.Etiqueta63.Text = "Fecha:"
        '
        'btnCalcularLiquidacion
        '
        Appearance79.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance79.BorderColor = System.Drawing.Color.Blue
        Appearance79.ForeColor = System.Drawing.Color.Navy
        Appearance79.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Appearance79.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance79.TextHAlignAsString = "Left"
        Me.btnCalcularLiquidacion.Appearance = Appearance79
        Me.btnCalcularLiquidacion.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCalcularLiquidacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcularLiquidacion.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007ScrollbarButton
        Me.btnCalcularLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcularLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.btnCalcularLiquidacion.Location = New System.Drawing.Point(254, 103)
        Me.btnCalcularLiquidacion.Name = "btnCalcularLiquidacion"
        Me.btnCalcularLiquidacion.Size = New System.Drawing.Size(107, 46)
        Me.btnCalcularLiquidacion.TabIndex = 256
        Me.btnCalcularLiquidacion.Text = "Calcular      Liquidacion"
        Me.btnCalcularLiquidacion.Visible = False
        '
        'agrDatosBasicos
        '
        Me.agrDatosBasicos.Controls.Add(Me.txtCargo)
        Me.agrDatosBasicos.Controls.Add(Me.etiCargo)
        Me.agrDatosBasicos.Controls.Add(Me.txtArea)
        Me.agrDatosBasicos.Controls.Add(Me.etiArea)
        Me.agrDatosBasicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrDatosBasicos.ForeColor = System.Drawing.Color.Black
        Me.agrDatosBasicos.Location = New System.Drawing.Point(932, 29)
        Me.agrDatosBasicos.Name = "agrDatosBasicos"
        Me.agrDatosBasicos.Size = New System.Drawing.Size(266, 93)
        Me.agrDatosBasicos.TabIndex = 255
        Me.agrDatosBasicos.Text = "Datos Básicos del Trabajador"
        Me.agrDatosBasicos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        Me.agrDatosBasicos.Visible = False
        '
        'txtCargo
        '
        Me.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(60, 52)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(185, 21)
        Me.txtCargo.TabIndex = 102
        Me.txtCargo.TabStop = False
        Me.txtCargo.Text = "[CARGO]"
        '
        'etiCargo
        '
        Appearance80.BackColor = System.Drawing.Color.Transparent
        Appearance80.ForeColor = System.Drawing.Color.Navy
        Me.etiCargo.Appearance = Appearance80
        Me.etiCargo.AutoSize = True
        Me.etiCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiCargo.ForeColor = System.Drawing.Color.Black
        Me.etiCargo.Location = New System.Drawing.Point(14, 57)
        Me.etiCargo.Name = "etiCargo"
        Me.etiCargo.Size = New System.Drawing.Size(37, 14)
        Me.etiCargo.TabIndex = 0
        Me.etiCargo.Text = "Cargo:"
        '
        'txtArea
        '
        Me.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArea.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(60, 25)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(185, 21)
        Me.txtArea.TabIndex = 100
        Me.txtArea.TabStop = False
        Me.txtArea.Text = "[AREA]"
        '
        'etiArea
        '
        Appearance81.BackColor = System.Drawing.Color.Transparent
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Me.etiArea.Appearance = Appearance81
        Me.etiArea.AutoSize = True
        Me.etiArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiArea.ForeColor = System.Drawing.Color.Black
        Me.etiArea.Location = New System.Drawing.Point(21, 29)
        Me.etiArea.Name = "etiArea"
        Me.etiArea.Size = New System.Drawing.Size(30, 14)
        Me.etiArea.TabIndex = 0
        Me.etiArea.Text = "Area:"
        '
        'FotoTrabajador
        '
        Me.FotoTrabajador.Location = New System.Drawing.Point(791, 25)
        Me.FotoTrabajador.Name = "FotoTrabajador"
        Me.FotoTrabajador.Size = New System.Drawing.Size(132, 156)
        Me.FotoTrabajador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoTrabajador.TabIndex = 254
        Me.FotoTrabajador.TabStop = False
        Me.FotoTrabajador.Visible = False
        '
        'numTotalRemComp
        '
        Appearance82.ForeColor = System.Drawing.Color.Black
        Me.numTotalRemComp.Appearance = Appearance82
        Me.numTotalRemComp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalRemComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalRemComp.ForeColor = System.Drawing.Color.Black
        Me.numTotalRemComp.Location = New System.Drawing.Point(682, 160)
        Me.numTotalRemComp.Name = "numTotalRemComp"
        Me.numTotalRemComp.NullText = "0.00"
        Me.numTotalRemComp.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalRemComp.ReadOnly = True
        Me.numTotalRemComp.Size = New System.Drawing.Size(95, 21)
        Me.numTotalRemComp.TabIndex = 253
        Me.numTotalRemComp.TabStop = False
        '
        'numGratificacion
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.numGratificacion.Appearance = Appearance83
        Me.numGratificacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numGratificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numGratificacion.ForeColor = System.Drawing.Color.Black
        Me.numGratificacion.Location = New System.Drawing.Point(682, 133)
        Me.numGratificacion.Name = "numGratificacion"
        Me.numGratificacion.NullText = "0.00"
        Me.numGratificacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numGratificacion.ReadOnly = True
        Me.numGratificacion.Size = New System.Drawing.Size(95, 21)
        Me.numGratificacion.TabIndex = 252
        Me.numGratificacion.TabStop = False
        '
        'numPromHorExt
        '
        Appearance84.ForeColor = System.Drawing.Color.Black
        Me.numPromHorExt.Appearance = Appearance84
        Me.numPromHorExt.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPromHorExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPromHorExt.ForeColor = System.Drawing.Color.Black
        Me.numPromHorExt.Location = New System.Drawing.Point(682, 106)
        Me.numPromHorExt.Name = "numPromHorExt"
        Me.numPromHorExt.NullText = "0.00"
        Me.numPromHorExt.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPromHorExt.ReadOnly = True
        Me.numPromHorExt.Size = New System.Drawing.Size(95, 21)
        Me.numPromHorExt.TabIndex = 251
        Me.numPromHorExt.TabStop = False
        '
        'Etiqueta12
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance85
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(449, 164)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(227, 14)
        Me.Etiqueta12.TabIndex = 250
        Me.Etiqueta12.Text = "TOTAL REMUNERACION COMPUTABLE:"
        '
        'Etiqueta11
        '
        Appearance86.BackColor = System.Drawing.Color.Transparent
        Appearance86.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance86
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta11.Location = New System.Drawing.Point(574, 137)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(102, 14)
        Me.Etiqueta11.TabIndex = 249
        Me.Etiqueta11.Text = "1/6 de Gratificacion:"
        '
        'Etiqueta10
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance87
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(556, 110)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(120, 14)
        Me.Etiqueta10.TabIndex = 248
        Me.Etiqueta10.Text = "Promedio Horas Extras:"
        '
        'numProBonProd
        '
        Appearance88.ForeColor = System.Drawing.Color.Black
        Me.numProBonProd.Appearance = Appearance88
        Me.numProBonProd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numProBonProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numProBonProd.ForeColor = System.Drawing.Color.Black
        Me.numProBonProd.Location = New System.Drawing.Point(682, 79)
        Me.numProBonProd.Name = "numProBonProd"
        Me.numProBonProd.NullText = "0.00"
        Me.numProBonProd.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numProBonProd.ReadOnly = True
        Me.numProBonProd.Size = New System.Drawing.Size(95, 21)
        Me.numProBonProd.TabIndex = 247
        Me.numProBonProd.TabStop = False
        '
        'numAsigFam
        '
        Appearance89.ForeColor = System.Drawing.Color.Black
        Me.numAsigFam.Appearance = Appearance89
        Me.numAsigFam.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAsigFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAsigFam.ForeColor = System.Drawing.Color.Black
        Me.numAsigFam.Location = New System.Drawing.Point(682, 52)
        Me.numAsigFam.Name = "numAsigFam"
        Me.numAsigFam.NullText = "0.00"
        Me.numAsigFam.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numAsigFam.ReadOnly = True
        Me.numAsigFam.Size = New System.Drawing.Size(95, 21)
        Me.numAsigFam.TabIndex = 246
        Me.numAsigFam.TabStop = False
        '
        'numSueldo
        '
        Appearance90.ForeColor = System.Drawing.Color.Black
        Me.numSueldo.Appearance = Appearance90
        Me.numSueldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSueldo.ForeColor = System.Drawing.Color.Black
        Me.numSueldo.Location = New System.Drawing.Point(682, 25)
        Me.numSueldo.Name = "numSueldo"
        Me.numSueldo.NullText = "0.00"
        Me.numSueldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numSueldo.ReadOnly = True
        Me.numSueldo.Size = New System.Drawing.Size(95, 21)
        Me.numSueldo.TabIndex = 245
        Me.numSueldo.TabStop = False
        '
        'Etiqueta19
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance91
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(493, 83)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(183, 14)
        Me.Etiqueta19.TabIndex = 244
        Me.Etiqueta19.Text = "Promedio Bonificacion x Produccion:"
        '
        'Etiqueta18
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance92
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta18.Location = New System.Drawing.Point(573, 56)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(103, 14)
        Me.Etiqueta18.TabIndex = 243
        Me.Etiqueta18.Text = "Asignacion Familiar:"
        '
        'Etiqueta17
        '
        Appearance93.BackColor = System.Drawing.Color.Transparent
        Appearance93.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance93
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta17.Location = New System.Drawing.Point(561, 29)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(115, 14)
        Me.Etiqueta17.TabIndex = 242
        Me.Etiqueta17.Text = "Remuneracion Basica:"
        '
        'dtpFechaCese
        '
        Me.dtpFechaCese.Enabled = False
        Me.dtpFechaCese.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCese.Location = New System.Drawing.Point(126, 129)
        Me.dtpFechaCese.Name = "dtpFechaCese"
        Me.dtpFechaCese.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaCese.TabIndex = 15
        Me.dtpFechaCese.TabStop = False
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Enabled = False
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(126, 103)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIngreso.TabIndex = 13
        Me.dtpFechaIngreso.TabStop = False
        '
        'txtTiempoServicios
        '
        Me.txtTiempoServicios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTiempoServicios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTiempoServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoServicios.Location = New System.Drawing.Point(126, 182)
        Me.txtTiempoServicios.Name = "txtTiempoServicios"
        Me.txtTiempoServicios.ReadOnly = True
        Me.txtTiempoServicios.Size = New System.Drawing.Size(371, 21)
        Me.txtTiempoServicios.TabIndex = 12
        Me.txtTiempoServicios.TabStop = False
        '
        'txtOcupacion
        '
        Me.txtOcupacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOcupacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOcupacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacion.Location = New System.Drawing.Point(126, 76)
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.ReadOnly = True
        Me.txtOcupacion.Size = New System.Drawing.Size(304, 21)
        Me.txtOcupacion.TabIndex = 11
        Me.txtOcupacion.TabStop = False
        '
        'Etiqueta8
        '
        Appearance94.BackColor = System.Drawing.Color.Transparent
        Appearance94.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance94
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta8.Location = New System.Drawing.Point(35, 159)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta8.TabIndex = 10
        Me.Etiqueta8.Text = "Motivo de Cese:"
        '
        'Etiqueta7
        '
        Appearance95.BackColor = System.Drawing.Color.Transparent
        Appearance95.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance95
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(11, 186)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(107, 14)
        Me.Etiqueta7.TabIndex = 9
        Me.Etiqueta7.Text = "Tiempo de Servicios:"
        '
        'Etiqueta6
        '
        Appearance96.BackColor = System.Drawing.Color.Transparent
        Appearance96.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance96
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(52, 132)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta6.TabIndex = 8
        Me.Etiqueta6.Text = "Fecha Cese:"
        '
        'Etiqueta5
        '
        Appearance97.BackColor = System.Drawing.Color.Transparent
        Appearance97.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance97
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(44, 107)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta5.TabIndex = 7
        Me.Etiqueta5.Text = "FechaIngreso:"
        '
        'Etiqueta4
        '
        Appearance98.BackColor = System.Drawing.Color.Transparent
        Appearance98.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance98
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(58, 80)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta4.TabIndex = 6
        Me.Etiqueta4.Text = "Ocupacion:"
        '
        'cboTrabajador
        '
        Appearance99.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance99
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance100.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        EditorButton1.Appearance = Appearance100
        Me.cboTrabajador.ButtonsRight.Add(EditorButton1)
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(126, 49)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(304, 21)
        Me.cboTrabajador.TabIndex = 4
        Me.cboTrabajador.ValueMember = "Id"
        '
        'Etiqueta3
        '
        Appearance101.BackColor = System.Drawing.Color.Transparent
        Appearance101.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance101
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(58, 53)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta3.TabIndex = 5
        Me.Etiqueta3.Text = "Trabajador:"
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Left
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Name = "_utpMantenimiento_Toolbars_Dock_Area_Left"
        Me._utpMantenimiento_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 562)
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Right
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1255, 0)
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Name = "_utpMantenimiento_Toolbars_Dock_Area_Right"
        Me._utpMantenimiento_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 562)
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Bottom
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 562)
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Name = "_utpMantenimiento_Toolbars_Dock_Area_Bottom"
        Me._utpMantenimiento_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1255, 0)
        '
        '_utpMantenimiento_Toolbars_Dock_Area_Top
        '
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.Color.Black
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Name = "_utpMantenimiento_Toolbars_Dock_Area_Top"
        Me._utpMantenimiento_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1255, 0)
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1255, 562)
        '
        'Agrupacion6
        '
        Me.Agrupacion6.Controls.Add(Me.ND_AporteEsSalud)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta94)
        Me.Agrupacion6.Controls.Add(Me.btnCalcular5ta)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta101)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta100)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta99)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta98)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta97)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta96)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalDevolucion5ta)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalRetencion5ta)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta93)
        Me.Agrupacion6.Controls.Add(Me.txtDTfaltas)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalDTxFaltas)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalDTRem)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta91)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta92)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta90)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta89)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta88)
        Me.Agrupacion6.Controls.Add(Me.txtGTfaltas)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalGTxF)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalGTRem)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta86)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta87)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta85)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta84)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta83)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta82)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta81)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta80)
        Me.Agrupacion6.Controls.Add(Me.txtVTfaltas)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta78)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalVTxF)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalVTRem)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta79)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta77)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta76)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta75)
        Me.Agrupacion6.Controls.Add(Me.txtCTSfaltas)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalCTSxF)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimalCTSRem)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta73)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta74)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta71)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal3)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta70)
        Me.Agrupacion6.Controls.Add(Me.txtVTDiasVacaciones)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta69)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta49)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta47)
        Me.Agrupacion6.Controls.Add(Me.numAdelantoSueldo)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta36)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta34)
        Me.Agrupacion6.Controls.Add(Me.numCantGra)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta26)
        Me.Agrupacion6.Controls.Add(Me.etiAFP1)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion6.Controls.Add(Me.etiDsctAFP)
        Me.Agrupacion6.Controls.Add(Me.numTotalLiquidacion)
        Me.Agrupacion6.Controls.Add(Me.txtDiasdias)
        Me.Agrupacion6.Controls.Add(Me.txtGTdias)
        Me.Agrupacion6.Controls.Add(Me.txtGTmeses)
        Me.Agrupacion6.Controls.Add(Me.txtVTdias)
        Me.Agrupacion6.Controls.Add(Me.txtVTmeses)
        Me.Agrupacion6.Controls.Add(Me.txtVTaños)
        Me.Agrupacion6.Controls.Add(Me.txtCTSdias)
        Me.Agrupacion6.Controls.Add(Me.txtCTSmeses)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta62)
        Me.Agrupacion6.Controls.Add(Me.numDT)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal25)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta61)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal22)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal23)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal24)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal26)
        Me.Agrupacion6.Controls.Add(Me.txtFechaTotalDT)
        Me.Agrupacion6.Controls.Add(Me.etiFFDT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion6.Controls.Add(Me.etiFIDT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta57)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta58)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta59)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta60)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta56)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta54)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta55)
        Me.Agrupacion6.Controls.Add(Me.numBE)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta32)
        Me.Agrupacion6.Controls.Add(Me.numTotalGT)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal16)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal17)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta45)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal18)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal19)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta46)
        Me.Agrupacion6.Controls.Add(Me.txtFechaTotalGT)
        Me.Agrupacion6.Controls.Add(Me.etiFFGT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta48)
        Me.Agrupacion6.Controls.Add(Me.etiFIGT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta50)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta51)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta52)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta53)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta44)
        Me.Agrupacion6.Controls.Add(Me.numTotalVT)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal13)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal14)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta43)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta42)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta41)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal11)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal6)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal7)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal8)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal9)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal10)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta33)
        Me.Agrupacion6.Controls.Add(Me.txtFechaTotalVT)
        Me.Agrupacion6.Controls.Add(Me.etiFFVT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta35)
        Me.Agrupacion6.Controls.Add(Me.etiFIVT)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta37)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta38)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta39)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta40)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion6.Controls.Add(Me.numTotalCTS)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal4)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal5)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta30)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal2)
        Me.Agrupacion6.Controls.Add(Me.NumeroDecimal1)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta29)
        Me.Agrupacion6.Controls.Add(Me.txtFechaTotalCTS)
        Me.Agrupacion6.Controls.Add(Me.etiFFCTS)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta28)
        Me.Agrupacion6.Controls.Add(Me.etiFICTS)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion6.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(1255, 562)
        Me.Agrupacion6.TabIndex = 0
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ND_AporteEsSalud
        '
        Appearance102.ForeColor = System.Drawing.Color.Black
        Me.ND_AporteEsSalud.Appearance = Appearance102
        Me.ND_AporteEsSalud.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ND_AporteEsSalud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ND_AporteEsSalud.ForeColor = System.Drawing.Color.Black
        Me.ND_AporteEsSalud.Location = New System.Drawing.Point(1064, 530)
        Me.ND_AporteEsSalud.Name = "ND_AporteEsSalud"
        Me.ND_AporteEsSalud.NullText = "0.00"
        Me.ND_AporteEsSalud.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ND_AporteEsSalud.ReadOnly = True
        Me.ND_AporteEsSalud.Size = New System.Drawing.Size(95, 21)
        Me.ND_AporteEsSalud.TabIndex = 418
        Me.ND_AporteEsSalud.TabStop = False
        '
        'Etiqueta94
        '
        Appearance103.BackColor = System.Drawing.Color.Transparent
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta94.Appearance = Appearance103
        Me.Etiqueta94.AutoSize = True
        Me.Etiqueta94.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta94.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta94.Location = New System.Drawing.Point(639, 537)
        Me.Etiqueta94.Name = "Etiqueta94"
        Me.Etiqueta94.Size = New System.Drawing.Size(83, 14)
        Me.Etiqueta94.TabIndex = 417
        Me.Etiqueta94.Text = "Aporte EsSalud:"
        '
        'btnCalcular5ta
        '
        Appearance104.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance104.BorderColor = System.Drawing.Color.Blue
        Appearance104.ForeColor = System.Drawing.Color.Navy
        Appearance104.Image = Global.ISL.Win.My.Resources.Resources.Purse
        Appearance104.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance104.TextHAlignAsString = "Left"
        Me.btnCalcular5ta.Appearance = Appearance104
        Me.btnCalcular5ta.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCalcular5ta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalcular5ta.ButtonStyle = Infragistics.Win.UIElementButtonStyle.Office2007ScrollbarButton
        Me.btnCalcular5ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular5ta.ForeColor = System.Drawing.Color.Black
        Me.btnCalcular5ta.Location = New System.Drawing.Point(794, 405)
        Me.btnCalcular5ta.Name = "btnCalcular5ta"
        Me.btnCalcular5ta.Size = New System.Drawing.Size(92, 28)
        Me.btnCalcular5ta.TabIndex = 416
        Me.btnCalcular5ta.Text = "Calcular 5ta."
        '
        'Etiqueta101
        '
        Appearance105.BackColor = System.Drawing.Color.Transparent
        Appearance105.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta101.Appearance = Appearance105
        Me.Etiqueta101.AutoSize = True
        Me.Etiqueta101.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta101.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta101.Location = New System.Drawing.Point(1051, 295)
        Me.Etiqueta101.Name = "Etiqueta101"
        Me.Etiqueta101.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta101.TabIndex = 415
        Me.Etiqueta101.Text = "-"
        '
        'Etiqueta100
        '
        Appearance106.BackColor = System.Drawing.Color.Transparent
        Appearance106.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta100.Appearance = Appearance106
        Me.Etiqueta100.AutoSize = True
        Me.Etiqueta100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta100.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta100.Location = New System.Drawing.Point(1051, 268)
        Me.Etiqueta100.Name = "Etiqueta100"
        Me.Etiqueta100.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta100.TabIndex = 414
        Me.Etiqueta100.Text = "-"
        '
        'Etiqueta99
        '
        Appearance107.BackColor = System.Drawing.Color.Transparent
        Appearance107.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta99.Appearance = Appearance107
        Me.Etiqueta99.AutoSize = True
        Me.Etiqueta99.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta99.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta99.Location = New System.Drawing.Point(1051, 241)
        Me.Etiqueta99.Name = "Etiqueta99"
        Me.Etiqueta99.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta99.TabIndex = 413
        Me.Etiqueta99.Text = "-"
        '
        'Etiqueta98
        '
        Appearance108.BackColor = System.Drawing.Color.Transparent
        Appearance108.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta98.Appearance = Appearance108
        Me.Etiqueta98.AutoSize = True
        Me.Etiqueta98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta98.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta98.Location = New System.Drawing.Point(1051, 214)
        Me.Etiqueta98.Name = "Etiqueta98"
        Me.Etiqueta98.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta98.TabIndex = 412
        Me.Etiqueta98.Text = "+"
        '
        'Etiqueta97
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta97.Appearance = Appearance109
        Me.Etiqueta97.AutoSize = True
        Me.Etiqueta97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta97.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta97.Location = New System.Drawing.Point(1053, 190)
        Me.Etiqueta97.Name = "Etiqueta97"
        Me.Etiqueta97.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta97.TabIndex = 411
        Me.Etiqueta97.Text = "-"
        '
        'Etiqueta96
        '
        Appearance110.BackColor = System.Drawing.Color.Transparent
        Appearance110.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta96.Appearance = Appearance110
        Me.Etiqueta96.AutoSize = True
        Me.Etiqueta96.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta96.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta96.Location = New System.Drawing.Point(1051, 164)
        Me.Etiqueta96.Name = "Etiqueta96"
        Me.Etiqueta96.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta96.TabIndex = 410
        Me.Etiqueta96.Text = "+"
        '
        'NumeroDecimalDevolucion5ta
        '
        Appearance111.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDevolucion5ta.Appearance = Appearance111
        Me.NumeroDecimalDevolucion5ta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalDevolucion5ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalDevolucion5ta.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDevolucion5ta.Location = New System.Drawing.Point(1064, 435)
        Me.NumeroDecimalDevolucion5ta.MaxValue = 50000.0R
        Me.NumeroDecimalDevolucion5ta.Name = "NumeroDecimalDevolucion5ta"
        Me.NumeroDecimalDevolucion5ta.Nullable = True
        Me.NumeroDecimalDevolucion5ta.NullText = "0.00"
        Me.NumeroDecimalDevolucion5ta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalDevolucion5ta.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalDevolucion5ta.TabIndex = 407
        '
        'NumeroDecimalRetencion5ta
        '
        Appearance112.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalRetencion5ta.Appearance = Appearance112
        Me.NumeroDecimalRetencion5ta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalRetencion5ta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalRetencion5ta.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalRetencion5ta.Location = New System.Drawing.Point(1064, 461)
        Me.NumeroDecimalRetencion5ta.MaxValue = 50000.0R
        Me.NumeroDecimalRetencion5ta.Name = "NumeroDecimalRetencion5ta"
        Me.NumeroDecimalRetencion5ta.Nullable = True
        Me.NumeroDecimalRetencion5ta.NullText = "0.00"
        Me.NumeroDecimalRetencion5ta.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalRetencion5ta.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalRetencion5ta.TabIndex = 406
        '
        'Etiqueta93
        '
        Appearance113.BackColor = System.Drawing.Color.Transparent
        Appearance113.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta93.Appearance = Appearance113
        Me.Etiqueta93.AutoSize = True
        Me.Etiqueta93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta93.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta93.Location = New System.Drawing.Point(639, 466)
        Me.Etiqueta93.Name = "Etiqueta93"
        Me.Etiqueta93.Size = New System.Drawing.Size(158, 14)
        Me.Etiqueta93.TabIndex = 405
        Me.Etiqueta93.Text = "Retencion Renta 5ta Categoria:"
        '
        'txtDTfaltas
        '
        Me.txtDTfaltas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDTfaltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDTfaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTfaltas.Location = New System.Drawing.Point(837, 186)
        Me.txtDTfaltas.Name = "txtDTfaltas"
        Me.txtDTfaltas.ReadOnly = True
        Me.txtDTfaltas.Size = New System.Drawing.Size(28, 21)
        Me.txtDTfaltas.TabIndex = 404
        '
        'NumeroDecimalDTxFaltas
        '
        Appearance114.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDTxFaltas.Appearance = Appearance114
        Me.NumeroDecimalDTxFaltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalDTxFaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalDTxFaltas.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDTxFaltas.Location = New System.Drawing.Point(1064, 186)
        Me.NumeroDecimalDTxFaltas.Name = "NumeroDecimalDTxFaltas"
        Me.NumeroDecimalDTxFaltas.NullText = "0.00"
        Me.NumeroDecimalDTxFaltas.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalDTxFaltas.ReadOnly = True
        Me.NumeroDecimalDTxFaltas.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalDTxFaltas.TabIndex = 403
        Me.NumeroDecimalDTxFaltas.TabStop = False
        '
        'NumeroDecimalDTRem
        '
        Appearance115.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDTRem.Appearance = Appearance115
        Me.NumeroDecimalDTRem.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalDTRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalDTRem.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalDTRem.Location = New System.Drawing.Point(708, 186)
        Me.NumeroDecimalDTRem.Name = "NumeroDecimalDTRem"
        Me.NumeroDecimalDTRem.NullText = "0.00"
        Me.NumeroDecimalDTRem.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalDTRem.ReadOnly = True
        Me.NumeroDecimalDTRem.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimalDTRem.TabIndex = 402
        Me.NumeroDecimalDTRem.TabStop = False
        '
        'Etiqueta91
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta91.Appearance = Appearance116
        Me.Etiqueta91.AutoSize = True
        Me.Etiqueta91.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta91.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta91.Location = New System.Drawing.Point(796, 190)
        Me.Etiqueta91.Name = "Etiqueta91"
        Me.Etiqueta91.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta91.TabIndex = 401
        Me.Etiqueta91.Text = "/  30  *"
        '
        'Etiqueta92
        '
        Appearance117.BackColor = System.Drawing.Color.Transparent
        Appearance117.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta92.Appearance = Appearance117
        Me.Etiqueta92.AutoSize = True
        Me.Etiqueta92.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta92.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta92.Location = New System.Drawing.Point(666, 190)
        Me.Etiqueta92.Name = "Etiqueta92"
        Me.Etiqueta92.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta92.TabIndex = 400
        Me.Etiqueta92.Text = "Faltas"
        '
        'Etiqueta90
        '
        Appearance118.BackColor = System.Drawing.Color.Transparent
        Appearance118.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta90.Appearance = Appearance118
        Me.Etiqueta90.AutoSize = True
        Me.Etiqueta90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta90.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta90.Location = New System.Drawing.Point(466, 470)
        Me.Etiqueta90.Name = "Etiqueta90"
        Me.Etiqueta90.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta90.TabIndex = 399
        Me.Etiqueta90.Text = "-"
        '
        'Etiqueta89
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta89.Appearance = Appearance119
        Me.Etiqueta89.AutoSize = True
        Me.Etiqueta89.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta89.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta89.Location = New System.Drawing.Point(464, 445)
        Me.Etiqueta89.Name = "Etiqueta89"
        Me.Etiqueta89.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta89.TabIndex = 398
        Me.Etiqueta89.Text = "+"
        '
        'Etiqueta88
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta88.Appearance = Appearance120
        Me.Etiqueta88.AutoSize = True
        Me.Etiqueta88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta88.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta88.Location = New System.Drawing.Point(464, 418)
        Me.Etiqueta88.Name = "Etiqueta88"
        Me.Etiqueta88.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta88.TabIndex = 397
        Me.Etiqueta88.Text = "+"
        '
        'txtGTfaltas
        '
        Me.txtGTfaltas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGTfaltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGTfaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTfaltas.Location = New System.Drawing.Point(297, 467)
        Me.txtGTfaltas.Name = "txtGTfaltas"
        Me.txtGTfaltas.ReadOnly = True
        Me.txtGTfaltas.Size = New System.Drawing.Size(28, 21)
        Me.txtGTfaltas.TabIndex = 396
        '
        'NumeroDecimalGTxF
        '
        Appearance121.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalGTxF.Appearance = Appearance121
        Me.NumeroDecimalGTxF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalGTxF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalGTxF.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalGTxF.Location = New System.Drawing.Point(477, 467)
        Me.NumeroDecimalGTxF.Name = "NumeroDecimalGTxF"
        Me.NumeroDecimalGTxF.NullText = "0.00"
        Me.NumeroDecimalGTxF.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalGTxF.ReadOnly = True
        Me.NumeroDecimalGTxF.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalGTxF.TabIndex = 395
        Me.NumeroDecimalGTxF.TabStop = False
        '
        'NumeroDecimalGTRem
        '
        Appearance122.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalGTRem.Appearance = Appearance122
        Me.NumeroDecimalGTRem.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalGTRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalGTRem.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalGTRem.Location = New System.Drawing.Point(141, 467)
        Me.NumeroDecimalGTRem.Name = "NumeroDecimalGTRem"
        Me.NumeroDecimalGTRem.NullText = "0.00"
        Me.NumeroDecimalGTRem.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalGTRem.ReadOnly = True
        Me.NumeroDecimalGTRem.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimalGTRem.TabIndex = 394
        Me.NumeroDecimalGTRem.TabStop = False
        '
        'Etiqueta86
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta86.Appearance = Appearance123
        Me.Etiqueta86.AutoSize = True
        Me.Etiqueta86.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta86.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta86.Location = New System.Drawing.Point(229, 471)
        Me.Etiqueta86.Name = "Etiqueta86"
        Me.Etiqueta86.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta86.TabIndex = 393
        Me.Etiqueta86.Text = "/  06  /  30  *"
        '
        'Etiqueta87
        '
        Appearance124.BackColor = System.Drawing.Color.Transparent
        Appearance124.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta87.Appearance = Appearance124
        Me.Etiqueta87.AutoSize = True
        Me.Etiqueta87.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta87.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta87.Location = New System.Drawing.Point(97, 471)
        Me.Etiqueta87.Name = "Etiqueta87"
        Me.Etiqueta87.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta87.TabIndex = 392
        Me.Etiqueta87.Text = "Faltas"
        '
        'Etiqueta85
        '
        Appearance125.BackColor = System.Drawing.Color.Transparent
        Appearance125.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta85.Appearance = Appearance125
        Me.Etiqueta85.AutoSize = True
        Me.Etiqueta85.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta85.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta85.Location = New System.Drawing.Point(466, 310)
        Me.Etiqueta85.Name = "Etiqueta85"
        Me.Etiqueta85.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta85.TabIndex = 391
        Me.Etiqueta85.Text = "-"
        '
        'Etiqueta84
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta84.Appearance = Appearance126
        Me.Etiqueta84.AutoSize = True
        Me.Etiqueta84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta84.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta84.Location = New System.Drawing.Point(466, 287)
        Me.Etiqueta84.Name = "Etiqueta84"
        Me.Etiqueta84.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta84.TabIndex = 390
        Me.Etiqueta84.Text = "-"
        '
        'Etiqueta83
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta83.Appearance = Appearance127
        Me.Etiqueta83.AutoSize = True
        Me.Etiqueta83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta83.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta83.Location = New System.Drawing.Point(466, 264)
        Me.Etiqueta83.Name = "Etiqueta83"
        Me.Etiqueta83.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta83.TabIndex = 389
        Me.Etiqueta83.Text = "-"
        '
        'Etiqueta82
        '
        Appearance128.BackColor = System.Drawing.Color.Transparent
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta82.Appearance = Appearance128
        Me.Etiqueta82.AutoSize = True
        Me.Etiqueta82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta82.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta82.Location = New System.Drawing.Point(464, 241)
        Me.Etiqueta82.Name = "Etiqueta82"
        Me.Etiqueta82.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta82.TabIndex = 388
        Me.Etiqueta82.Text = "+"
        '
        'Etiqueta81
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta81.Appearance = Appearance129
        Me.Etiqueta81.AutoSize = True
        Me.Etiqueta81.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta81.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta81.Location = New System.Drawing.Point(464, 218)
        Me.Etiqueta81.Name = "Etiqueta81"
        Me.Etiqueta81.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta81.TabIndex = 387
        Me.Etiqueta81.Text = "+"
        '
        'Etiqueta80
        '
        Appearance130.BackColor = System.Drawing.Color.Transparent
        Appearance130.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta80.Appearance = Appearance130
        Me.Etiqueta80.AutoSize = True
        Me.Etiqueta80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta80.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta80.Location = New System.Drawing.Point(464, 195)
        Me.Etiqueta80.Name = "Etiqueta80"
        Me.Etiqueta80.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta80.TabIndex = 386
        Me.Etiqueta80.Text = "+"
        '
        'txtVTfaltas
        '
        Me.txtVTfaltas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVTfaltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVTfaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTfaltas.Location = New System.Drawing.Point(297, 261)
        Me.txtVTfaltas.Name = "txtVTfaltas"
        Me.txtVTfaltas.ReadOnly = True
        Me.txtVTfaltas.Size = New System.Drawing.Size(28, 21)
        Me.txtVTfaltas.TabIndex = 385
        '
        'Etiqueta78
        '
        Appearance131.BackColor = System.Drawing.Color.Transparent
        Appearance131.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta78.Appearance = Appearance131
        Me.Etiqueta78.AutoSize = True
        Me.Etiqueta78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta78.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta78.Location = New System.Drawing.Point(97, 265)
        Me.Etiqueta78.Name = "Etiqueta78"
        Me.Etiqueta78.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta78.TabIndex = 384
        Me.Etiqueta78.Text = "Faltas"
        '
        'NumeroDecimalVTxF
        '
        Appearance132.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalVTxF.Appearance = Appearance132
        Me.NumeroDecimalVTxF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalVTxF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalVTxF.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalVTxF.Location = New System.Drawing.Point(477, 261)
        Me.NumeroDecimalVTxF.Name = "NumeroDecimalVTxF"
        Me.NumeroDecimalVTxF.NullText = "0.00"
        Me.NumeroDecimalVTxF.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalVTxF.ReadOnly = True
        Me.NumeroDecimalVTxF.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalVTxF.TabIndex = 383
        Me.NumeroDecimalVTxF.TabStop = False
        '
        'NumeroDecimalVTRem
        '
        Appearance133.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalVTRem.Appearance = Appearance133
        Me.NumeroDecimalVTRem.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalVTRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalVTRem.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalVTRem.Location = New System.Drawing.Point(141, 261)
        Me.NumeroDecimalVTRem.Name = "NumeroDecimalVTRem"
        Me.NumeroDecimalVTRem.NullText = "0.00"
        Me.NumeroDecimalVTRem.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalVTRem.ReadOnly = True
        Me.NumeroDecimalVTRem.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimalVTRem.TabIndex = 382
        Me.NumeroDecimalVTRem.TabStop = False
        '
        'Etiqueta79
        '
        Appearance134.BackColor = System.Drawing.Color.Transparent
        Appearance134.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta79.Appearance = Appearance134
        Me.Etiqueta79.AutoSize = True
        Me.Etiqueta79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta79.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta79.Location = New System.Drawing.Point(229, 265)
        Me.Etiqueta79.Name = "Etiqueta79"
        Me.Etiqueta79.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta79.TabIndex = 381
        Me.Etiqueta79.Text = "/  12  /  30  *"
        '
        'Etiqueta77
        '
        Appearance135.BackColor = System.Drawing.Color.Transparent
        Appearance135.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta77.Appearance = Appearance135
        Me.Etiqueta77.AutoSize = True
        Me.Etiqueta77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta77.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta77.Location = New System.Drawing.Point(466, 94)
        Me.Etiqueta77.Name = "Etiqueta77"
        Me.Etiqueta77.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta77.TabIndex = 380
        Me.Etiqueta77.Text = "-"
        '
        'Etiqueta76
        '
        Appearance136.BackColor = System.Drawing.Color.Transparent
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta76.Appearance = Appearance136
        Me.Etiqueta76.AutoSize = True
        Me.Etiqueta76.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta76.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta76.Location = New System.Drawing.Point(464, 71)
        Me.Etiqueta76.Name = "Etiqueta76"
        Me.Etiqueta76.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta76.TabIndex = 379
        Me.Etiqueta76.Text = "+"
        '
        'Etiqueta75
        '
        Appearance137.BackColor = System.Drawing.Color.Transparent
        Appearance137.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta75.Appearance = Appearance137
        Me.Etiqueta75.AutoSize = True
        Me.Etiqueta75.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta75.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta75.Location = New System.Drawing.Point(463, 49)
        Me.Etiqueta75.Name = "Etiqueta75"
        Me.Etiqueta75.Size = New System.Drawing.Size(10, 14)
        Me.Etiqueta75.TabIndex = 378
        Me.Etiqueta75.Text = "+"
        '
        'txtCTSfaltas
        '
        Me.txtCTSfaltas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTSfaltas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCTSfaltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTSfaltas.Location = New System.Drawing.Point(297, 91)
        Me.txtCTSfaltas.Name = "txtCTSfaltas"
        Me.txtCTSfaltas.ReadOnly = True
        Me.txtCTSfaltas.Size = New System.Drawing.Size(28, 21)
        Me.txtCTSfaltas.TabIndex = 377
        '
        'NumeroDecimalCTSxF
        '
        Appearance138.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalCTSxF.Appearance = Appearance138
        Me.NumeroDecimalCTSxF.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalCTSxF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalCTSxF.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalCTSxF.Location = New System.Drawing.Point(477, 91)
        Me.NumeroDecimalCTSxF.Name = "NumeroDecimalCTSxF"
        Me.NumeroDecimalCTSxF.NullText = "0.00"
        Me.NumeroDecimalCTSxF.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalCTSxF.ReadOnly = True
        Me.NumeroDecimalCTSxF.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimalCTSxF.TabIndex = 376
        Me.NumeroDecimalCTSxF.TabStop = False
        '
        'NumeroDecimalCTSRem
        '
        Appearance139.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalCTSRem.Appearance = Appearance139
        Me.NumeroDecimalCTSRem.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimalCTSRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimalCTSRem.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimalCTSRem.Location = New System.Drawing.Point(141, 91)
        Me.NumeroDecimalCTSRem.Name = "NumeroDecimalCTSRem"
        Me.NumeroDecimalCTSRem.NullText = "0.00"
        Me.NumeroDecimalCTSRem.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimalCTSRem.ReadOnly = True
        Me.NumeroDecimalCTSRem.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimalCTSRem.TabIndex = 375
        Me.NumeroDecimalCTSRem.TabStop = False
        '
        'Etiqueta73
        '
        Appearance140.BackColor = System.Drawing.Color.Transparent
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta73.Appearance = Appearance140
        Me.Etiqueta73.AutoSize = True
        Me.Etiqueta73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta73.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta73.Location = New System.Drawing.Point(229, 95)
        Me.Etiqueta73.Name = "Etiqueta73"
        Me.Etiqueta73.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta73.TabIndex = 374
        Me.Etiqueta73.Text = "/  12  /  30  *"
        '
        'Etiqueta74
        '
        Appearance141.BackColor = System.Drawing.Color.Transparent
        Appearance141.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta74.Appearance = Appearance141
        Me.Etiqueta74.AutoSize = True
        Me.Etiqueta74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta74.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta74.Location = New System.Drawing.Point(97, 95)
        Me.Etiqueta74.Name = "Etiqueta74"
        Me.Etiqueta74.Size = New System.Drawing.Size(34, 14)
        Me.Etiqueta74.TabIndex = 373
        Me.Etiqueta74.Text = "Faltas"
        '
        'Etiqueta71
        '
        Appearance142.BackColor = System.Drawing.Color.Transparent
        Appearance142.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta71.Appearance = Appearance142
        Me.Etiqueta71.AutoSize = True
        Me.Etiqueta71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta71.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta71.Location = New System.Drawing.Point(708, 296)
        Me.Etiqueta71.Name = "Etiqueta71"
        Me.Etiqueta71.Size = New System.Drawing.Size(98, 14)
        Me.Etiqueta71.TabIndex = 372
        Me.Etiqueta71.Text = "DESCUENTO EPS"
        '
        'NumeroDecimal3
        '
        Appearance143.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal3.Appearance = Appearance143
        Me.NumeroDecimal3.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal3.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal3.Location = New System.Drawing.Point(1064, 292)
        Me.NumeroDecimal3.Name = "NumeroDecimal3"
        Me.NumeroDecimal3.NullText = "0.00"
        Me.NumeroDecimal3.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal3.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal3.TabIndex = 371
        Me.NumeroDecimal3.TabStop = False
        '
        'Etiqueta70
        '
        Appearance144.BackColor = System.Drawing.Color.Transparent
        Appearance144.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta70.Appearance = Appearance144
        Me.Etiqueta70.AutoSize = True
        Me.Etiqueta70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta70.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta70.Location = New System.Drawing.Point(297, 288)
        Me.Etiqueta70.Name = "Etiqueta70"
        Me.Etiqueta70.Size = New System.Drawing.Size(26, 14)
        Me.Etiqueta70.TabIndex = 370
        Me.Etiqueta70.Text = "Días"
        '
        'txtVTDiasVacaciones
        '
        Me.txtVTDiasVacaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVTDiasVacaciones.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVTDiasVacaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTDiasVacaciones.Location = New System.Drawing.Point(263, 284)
        Me.txtVTDiasVacaciones.Name = "txtVTDiasVacaciones"
        Me.txtVTDiasVacaciones.ReadOnly = True
        Me.txtVTDiasVacaciones.Size = New System.Drawing.Size(28, 21)
        Me.txtVTDiasVacaciones.TabIndex = 369
        '
        'Etiqueta69
        '
        Appearance145.BackColor = System.Drawing.Color.Transparent
        Appearance145.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta69.Appearance = Appearance145
        Me.Etiqueta69.AutoSize = True
        Me.Etiqueta69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta69.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta69.Location = New System.Drawing.Point(141, 288)
        Me.Etiqueta69.Name = "Etiqueta69"
        Me.Etiqueta69.Size = New System.Drawing.Size(108, 14)
        Me.Etiqueta69.TabIndex = 368
        Me.Etiqueta69.Text = "Vacaciones Gozadas"
        '
        'Etiqueta49
        '
        Appearance146.BackColor = System.Drawing.Color.Transparent
        Appearance146.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta49.Appearance = Appearance146
        Me.Etiqueta49.AutoSize = True
        Me.Etiqueta49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta49.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta49.Location = New System.Drawing.Point(639, 441)
        Me.Etiqueta49.Name = "Etiqueta49"
        Me.Etiqueta49.Size = New System.Drawing.Size(163, 14)
        Me.Etiqueta49.TabIndex = 366
        Me.Etiqueta49.Text = "Devolucion Renta 5ta Categoria:"
        '
        'Etiqueta47
        '
        Appearance147.BackColor = System.Drawing.Color.Transparent
        Appearance147.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta47.Appearance = Appearance147
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta47.Location = New System.Drawing.Point(619, 414)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(164, 14)
        Me.Etiqueta47.TabIndex = 365
        Me.Etiqueta47.Text = "VIII. RENTA 5TA CATEGORIA"
        '
        'numAdelantoSueldo
        '
        Appearance148.ForeColor = System.Drawing.Color.Black
        Me.numAdelantoSueldo.Appearance = Appearance148
        Me.numAdelantoSueldo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAdelantoSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAdelantoSueldo.ForeColor = System.Drawing.Color.Black
        Me.numAdelantoSueldo.Location = New System.Drawing.Point(1064, 383)
        Me.numAdelantoSueldo.Name = "numAdelantoSueldo"
        Me.numAdelantoSueldo.NullText = "0.00"
        Me.numAdelantoSueldo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numAdelantoSueldo.ReadOnly = True
        Me.numAdelantoSueldo.Size = New System.Drawing.Size(95, 21)
        Me.numAdelantoSueldo.TabIndex = 364
        Me.numAdelantoSueldo.TabStop = False
        '
        'Etiqueta36
        '
        Appearance149.BackColor = System.Drawing.Color.Transparent
        Appearance149.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance149
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta36.Location = New System.Drawing.Point(639, 387)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(108, 14)
        Me.Etiqueta36.TabIndex = 363
        Me.Etiqueta36.Text = "Adelantos de Sueldo:"
        '
        'Etiqueta34
        '
        Appearance150.BackColor = System.Drawing.Color.Transparent
        Appearance150.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance150
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta34.Location = New System.Drawing.Point(619, 359)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(96, 14)
        Me.Etiqueta34.TabIndex = 362
        Me.Etiqueta34.Text = "VII. ADELANTOS"
        '
        'numCantGra
        '
        Appearance151.ForeColor = System.Drawing.Color.Black
        Me.numCantGra.Appearance = Appearance151
        Me.numCantGra.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCantGra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCantGra.ForeColor = System.Drawing.Color.Black
        Me.numCantGra.Location = New System.Drawing.Point(1064, 81)
        Me.numCantGra.MaxValue = 50000.0R
        Me.numCantGra.Name = "numCantGra"
        Me.numCantGra.Nullable = True
        Me.numCantGra.NullText = "0.00"
        Me.numCantGra.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCantGra.Size = New System.Drawing.Size(95, 21)
        Me.numCantGra.TabIndex = 361
        '
        'Etiqueta26
        '
        Appearance152.BackColor = System.Drawing.Color.Transparent
        Appearance152.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance152
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(839, 269)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta26.TabIndex = 360
        Me.Etiqueta26.Text = "%"
        '
        'etiAFP1
        '
        Appearance153.BackColor = System.Drawing.Color.Transparent
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Me.etiAFP1.Appearance = Appearance153
        Me.etiAFP1.AutoSize = True
        Me.etiAFP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiAFP1.ForeColor = System.Drawing.Color.Black
        Me.etiAFP1.Location = New System.Drawing.Point(811, 269)
        Me.etiAFP1.Name = "etiAFP1"
        Me.etiAFP1.Size = New System.Drawing.Size(0, 0)
        Me.etiAFP1.TabIndex = 359
        '
        'Etiqueta22
        '
        Appearance154.BackColor = System.Drawing.Color.Transparent
        Appearance154.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance154
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta22.Location = New System.Drawing.Point(276, 311)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta22.TabIndex = 358
        Me.Etiqueta22.Text = "%"
        '
        'etiDsctAFP
        '
        Appearance155.BackColor = System.Drawing.Color.Transparent
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Me.etiDsctAFP.Appearance = Appearance155
        Me.etiDsctAFP.AutoSize = True
        Me.etiDsctAFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiDsctAFP.ForeColor = System.Drawing.Color.Black
        Me.etiDsctAFP.Location = New System.Drawing.Point(244, 311)
        Me.etiDsctAFP.Name = "etiDsctAFP"
        Me.etiDsctAFP.Size = New System.Drawing.Size(0, 0)
        Me.etiDsctAFP.TabIndex = 357
        '
        'numTotalLiquidacion
        '
        Appearance156.ForeColor = System.Drawing.Color.Black
        Me.numTotalLiquidacion.Appearance = Appearance156
        Me.numTotalLiquidacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalLiquidacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.numTotalLiquidacion.Location = New System.Drawing.Point(817, 495)
        Me.numTotalLiquidacion.Name = "numTotalLiquidacion"
        Me.numTotalLiquidacion.NullText = "0.00"
        Me.numTotalLiquidacion.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalLiquidacion.ReadOnly = True
        Me.numTotalLiquidacion.Size = New System.Drawing.Size(128, 28)
        Me.numTotalLiquidacion.TabIndex = 356
        Me.numTotalLiquidacion.TabStop = False
        '
        'txtDiasdias
        '
        Me.txtDiasdias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasdias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDiasdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasdias.Location = New System.Drawing.Point(837, 161)
        Me.txtDiasdias.Name = "txtDiasdias"
        Me.txtDiasdias.ReadOnly = True
        Me.txtDiasdias.Size = New System.Drawing.Size(28, 21)
        Me.txtDiasdias.TabIndex = 355
        '
        'txtGTdias
        '
        Me.txtGTdias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGTdias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGTdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTdias.Location = New System.Drawing.Point(297, 442)
        Me.txtGTdias.Name = "txtGTdias"
        Me.txtGTdias.ReadOnly = True
        Me.txtGTdias.Size = New System.Drawing.Size(28, 21)
        Me.txtGTdias.TabIndex = 354
        '
        'txtGTmeses
        '
        Me.txtGTmeses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGTmeses.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtGTmeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTmeses.Location = New System.Drawing.Point(270, 415)
        Me.txtGTmeses.Name = "txtGTmeses"
        Me.txtGTmeses.ReadOnly = True
        Me.txtGTmeses.Size = New System.Drawing.Size(28, 21)
        Me.txtGTmeses.TabIndex = 353
        '
        'txtVTdias
        '
        Me.txtVTdias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVTdias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVTdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTdias.Location = New System.Drawing.Point(297, 238)
        Me.txtVTdias.Name = "txtVTdias"
        Me.txtVTdias.ReadOnly = True
        Me.txtVTdias.Size = New System.Drawing.Size(28, 21)
        Me.txtVTdias.TabIndex = 352
        '
        'txtVTmeses
        '
        Me.txtVTmeses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVTmeses.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVTmeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTmeses.Location = New System.Drawing.Point(270, 215)
        Me.txtVTmeses.Name = "txtVTmeses"
        Me.txtVTmeses.ReadOnly = True
        Me.txtVTmeses.Size = New System.Drawing.Size(28, 21)
        Me.txtVTmeses.TabIndex = 351
        '
        'txtVTaños
        '
        Me.txtVTaños.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVTaños.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVTaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVTaños.Location = New System.Drawing.Point(243, 192)
        Me.txtVTaños.Name = "txtVTaños"
        Me.txtVTaños.ReadOnly = True
        Me.txtVTaños.Size = New System.Drawing.Size(28, 21)
        Me.txtVTaños.TabIndex = 350
        '
        'txtCTSdias
        '
        Me.txtCTSdias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTSdias.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCTSdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTSdias.Location = New System.Drawing.Point(297, 68)
        Me.txtCTSdias.Name = "txtCTSdias"
        Me.txtCTSdias.ReadOnly = True
        Me.txtCTSdias.Size = New System.Drawing.Size(28, 21)
        Me.txtCTSdias.TabIndex = 349
        '
        'txtCTSmeses
        '
        Me.txtCTSmeses.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCTSmeses.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCTSmeses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTSmeses.Location = New System.Drawing.Point(270, 45)
        Me.txtCTSmeses.Name = "txtCTSmeses"
        Me.txtCTSmeses.ReadOnly = True
        Me.txtCTSmeses.Size = New System.Drawing.Size(28, 21)
        Me.txtCTSmeses.TabIndex = 348
        '
        'Etiqueta62
        '
        Appearance157.BackColor = System.Drawing.Color.Transparent
        Appearance157.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta62.Appearance = Appearance157
        Me.Etiqueta62.AutoSize = True
        Me.Etiqueta62.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta62.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta62.Location = New System.Drawing.Point(639, 497)
        Me.Etiqueta62.Name = "Etiqueta62"
        Me.Etiqueta62.Size = New System.Drawing.Size(172, 24)
        Me.Etiqueta62.TabIndex = 347
        Me.Etiqueta62.Text = "TOTAL A PAGAR:"
        '
        'numDT
        '
        Appearance158.ForeColor = System.Drawing.Color.Black
        Me.numDT.Appearance = Appearance158
        Me.numDT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDT.ForeColor = System.Drawing.Color.Black
        Me.numDT.Location = New System.Drawing.Point(1064, 319)
        Me.numDT.Name = "numDT"
        Me.numDT.NullText = "0.00"
        Me.numDT.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numDT.ReadOnly = True
        Me.numDT.Size = New System.Drawing.Size(95, 21)
        Me.numDT.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left
        Me.numDT.TabIndex = 346
        Me.numDT.TabStop = False
        '
        'NumeroDecimal25
        '
        Appearance159.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal25.Appearance = Appearance159
        Me.NumeroDecimal25.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal25.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal25.Location = New System.Drawing.Point(1064, 265)
        Me.NumeroDecimal25.Name = "NumeroDecimal25"
        Me.NumeroDecimal25.NullText = "0.00"
        Me.NumeroDecimal25.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal25.ReadOnly = True
        Me.NumeroDecimal25.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal25.TabIndex = 345
        Me.NumeroDecimal25.TabStop = False
        '
        'Etiqueta61
        '
        Appearance160.BackColor = System.Drawing.Color.Transparent
        Appearance160.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta61.Appearance = Appearance160
        Me.Etiqueta61.AutoSize = True
        Me.Etiqueta61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta61.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta61.Location = New System.Drawing.Point(708, 269)
        Me.Etiqueta61.Name = "Etiqueta61"
        Me.Etiqueta61.Size = New System.Drawing.Size(97, 14)
        Me.Etiqueta61.TabIndex = 344
        Me.Etiqueta61.Text = "DESCUENTO AFP"
        '
        'Etiqueta15
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Appearance161.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance161
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta15.Location = New System.Drawing.Point(708, 242)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(129, 14)
        Me.Etiqueta15.TabIndex = 343
        Me.Etiqueta15.Text = "ESSALUD + VIDA        05"
        '
        'NumeroDecimal22
        '
        Appearance162.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal22.Appearance = Appearance162
        Me.NumeroDecimal22.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal22.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal22.Location = New System.Drawing.Point(1064, 238)
        Me.NumeroDecimal22.Name = "NumeroDecimal22"
        Me.NumeroDecimal22.NullText = "0.00"
        Me.NumeroDecimal22.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal22.ReadOnly = True
        Me.NumeroDecimal22.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal22.TabIndex = 342
        Me.NumeroDecimal22.TabStop = False
        '
        'NumeroDecimal23
        '
        Appearance163.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal23.Appearance = Appearance163
        Me.NumeroDecimal23.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal23.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal23.Location = New System.Drawing.Point(1064, 211)
        Me.NumeroDecimal23.Name = "NumeroDecimal23"
        Me.NumeroDecimal23.NullText = "0.00"
        Me.NumeroDecimal23.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal23.ReadOnly = True
        Me.NumeroDecimal23.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal23.TabIndex = 341
        Me.NumeroDecimal23.TabStop = False
        '
        'NumeroDecimal24
        '
        Appearance164.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal24.Appearance = Appearance164
        Me.NumeroDecimal24.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal24.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal24.Location = New System.Drawing.Point(1064, 161)
        Me.NumeroDecimal24.Name = "NumeroDecimal24"
        Me.NumeroDecimal24.NullText = "0.00"
        Me.NumeroDecimal24.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal24.ReadOnly = True
        Me.NumeroDecimal24.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal24.TabIndex = 340
        Me.NumeroDecimal24.TabStop = False
        '
        'Etiqueta14
        '
        Appearance165.BackColor = System.Drawing.Color.Transparent
        Appearance165.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance165
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta14.Location = New System.Drawing.Point(924, 326)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(134, 14)
        Me.Etiqueta14.TabIndex = 339
        Me.Etiqueta14.Text = "REMUNERACION NETA"
        '
        'NumeroDecimal26
        '
        Appearance166.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal26.Appearance = Appearance166
        Me.NumeroDecimal26.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal26.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal26.Location = New System.Drawing.Point(708, 161)
        Me.NumeroDecimal26.Name = "NumeroDecimal26"
        Me.NumeroDecimal26.NullText = "0.00"
        Me.NumeroDecimal26.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal26.ReadOnly = True
        Me.NumeroDecimal26.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal26.TabIndex = 335
        Me.NumeroDecimal26.TabStop = False
        '
        'txtFechaTotalDT
        '
        Me.txtFechaTotalDT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaTotalDT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFechaTotalDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaTotalDT.Location = New System.Drawing.Point(866, 129)
        Me.txtFechaTotalDT.Name = "txtFechaTotalDT"
        Me.txtFechaTotalDT.ReadOnly = True
        Me.txtFechaTotalDT.Size = New System.Drawing.Size(293, 21)
        Me.txtFechaTotalDT.TabIndex = 333
        '
        'etiFFDT
        '
        Appearance167.BackColor = System.Drawing.Color.Transparent
        Appearance167.ForeColor = System.Drawing.Color.Navy
        Me.etiFFDT.Appearance = Appearance167
        Me.etiFFDT.AutoSize = True
        Me.etiFFDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFFDT.ForeColor = System.Drawing.Color.Black
        Me.etiFFDT.Location = New System.Drawing.Point(798, 133)
        Me.etiFFDT.Name = "etiFFDT"
        Me.etiFFDT.Size = New System.Drawing.Size(62, 14)
        Me.etiFFDT.TabIndex = 332
        Me.etiFFDT.Text = "01/01/1901:"
        '
        'Etiqueta23
        '
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Appearance168.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance168
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta23.Location = New System.Drawing.Point(708, 215)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(127, 14)
        Me.Etiqueta23.TabIndex = 331
        Me.Etiqueta23.Text = "ASIGNACION FAMILIAR"
        '
        'etiFIDT
        '
        Appearance169.BackColor = System.Drawing.Color.Transparent
        Appearance169.ForeColor = System.Drawing.Color.Navy
        Me.etiFIDT.Appearance = Appearance169
        Me.etiFIDT.AutoSize = True
        Me.etiFIDT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFIDT.ForeColor = System.Drawing.Color.Black
        Me.etiFIDT.Location = New System.Drawing.Point(708, 133)
        Me.etiFIDT.Name = "etiFIDT"
        Me.etiFIDT.Size = New System.Drawing.Size(62, 14)
        Me.etiFIDT.TabIndex = 330
        Me.etiFIDT.Text = "01/01/1901:"
        '
        'Etiqueta57
        '
        Appearance170.BackColor = System.Drawing.Color.Transparent
        Appearance170.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta57.Appearance = Appearance170
        Me.Etiqueta57.AutoSize = True
        Me.Etiqueta57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta57.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta57.Location = New System.Drawing.Point(796, 165)
        Me.Etiqueta57.Name = "Etiqueta57"
        Me.Etiqueta57.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta57.TabIndex = 329
        Me.Etiqueta57.Text = "/  30  *"
        '
        'Etiqueta58
        '
        Appearance171.BackColor = System.Drawing.Color.Transparent
        Appearance171.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta58.Appearance = Appearance171
        Me.Etiqueta58.AutoSize = True
        Me.Etiqueta58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta58.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta58.Location = New System.Drawing.Point(776, 133)
        Me.Etiqueta58.Name = "Etiqueta58"
        Me.Etiqueta58.Size = New System.Drawing.Size(16, 14)
        Me.Etiqueta58.TabIndex = 328
        Me.Etiqueta58.Text = "al:"
        '
        'Etiqueta59
        '
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Appearance172.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta59.Appearance = Appearance172
        Me.Etiqueta59.AutoSize = True
        Me.Etiqueta59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta59.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta59.Location = New System.Drawing.Point(688, 165)
        Me.Etiqueta59.Name = "Etiqueta59"
        Me.Etiqueta59.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta59.TabIndex = 327
        Me.Etiqueta59.Text = "a)"
        '
        'Etiqueta60
        '
        Appearance173.BackColor = System.Drawing.Color.Transparent
        Appearance173.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta60.Appearance = Appearance173
        Me.Etiqueta60.AutoSize = True
        Me.Etiqueta60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta60.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta60.Location = New System.Drawing.Point(639, 133)
        Me.Etiqueta60.Name = "Etiqueta60"
        Me.Etiqueta60.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta60.TabIndex = 326
        Me.Etiqueta60.Text = "Periodo del:"
        '
        'Etiqueta56
        '
        Appearance174.BackColor = System.Drawing.Color.Transparent
        Appearance174.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta56.Appearance = Appearance174
        Me.Etiqueta56.AutoSize = True
        Me.Etiqueta56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta56.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta56.Location = New System.Drawing.Point(619, 111)
        Me.Etiqueta56.Name = "Etiqueta56"
        Me.Etiqueta56.Size = New System.Drawing.Size(130, 14)
        Me.Etiqueta56.TabIndex = 325
        Me.Etiqueta56.Text = "VI. DIAS TRABAJADOS"
        '
        'Etiqueta54
        '
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Appearance175.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta54.Appearance = Appearance175
        Me.Etiqueta54.AutoSize = True
        Me.Etiqueta54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta54.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta54.Location = New System.Drawing.Point(619, 63)
        Me.Etiqueta54.Name = "Etiqueta54"
        Me.Etiqueta54.Size = New System.Drawing.Size(143, 14)
        Me.Etiqueta54.TabIndex = 323
        Me.Etiqueta54.Text = "V. CANTIDAD GRACIOSA"
        '
        'Etiqueta55
        '
        Appearance176.BackColor = System.Drawing.Color.Transparent
        Appearance176.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta55.Appearance = Appearance176
        Me.Etiqueta55.AutoSize = True
        Me.Etiqueta55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta55.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta55.Location = New System.Drawing.Point(639, 85)
        Me.Etiqueta55.Name = "Etiqueta55"
        Me.Etiqueta55.Size = New System.Drawing.Size(92, 14)
        Me.Etiqueta55.TabIndex = 322
        Me.Etiqueta55.Text = "Art. 60° - D.L. 650"
        '
        'numBE
        '
        Appearance177.ForeColor = System.Drawing.Color.Black
        Me.numBE.Appearance = Appearance177
        Me.numBE.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBE.ForeColor = System.Drawing.Color.Black
        Me.numBE.Location = New System.Drawing.Point(1064, 28)
        Me.numBE.Name = "numBE"
        Me.numBE.NullText = "0.00"
        Me.numBE.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numBE.ReadOnly = True
        Me.numBE.Size = New System.Drawing.Size(95, 21)
        Me.numBE.TabIndex = 321
        Me.numBE.TabStop = False
        '
        'Etiqueta32
        '
        Appearance178.BackColor = System.Drawing.Color.Transparent
        Appearance178.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance178
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(619, 7)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(213, 14)
        Me.Etiqueta32.TabIndex = 320
        Me.Etiqueta32.Text = "IV. BONIFICACION EXTRAORDINARIA"
        '
        'numTotalGT
        '
        Appearance179.ForeColor = System.Drawing.Color.Black
        Me.numTotalGT.Appearance = Appearance179
        Me.numTotalGT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalGT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalGT.ForeColor = System.Drawing.Color.Black
        Me.numTotalGT.Location = New System.Drawing.Point(477, 492)
        Me.numTotalGT.Name = "numTotalGT"
        Me.numTotalGT.NullText = "0.00"
        Me.numTotalGT.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalGT.ReadOnly = True
        Me.numTotalGT.Size = New System.Drawing.Size(95, 21)
        Me.numTotalGT.TabIndex = 319
        Me.numTotalGT.TabStop = False
        '
        'NumeroDecimal16
        '
        Appearance180.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal16.Appearance = Appearance180
        Me.NumeroDecimal16.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal16.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal16.Location = New System.Drawing.Point(477, 442)
        Me.NumeroDecimal16.Name = "NumeroDecimal16"
        Me.NumeroDecimal16.NullText = "0.00"
        Me.NumeroDecimal16.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal16.ReadOnly = True
        Me.NumeroDecimal16.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal16.TabIndex = 318
        Me.NumeroDecimal16.TabStop = False
        '
        'NumeroDecimal17
        '
        Appearance181.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal17.Appearance = Appearance181
        Me.NumeroDecimal17.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal17.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal17.Location = New System.Drawing.Point(477, 415)
        Me.NumeroDecimal17.Name = "NumeroDecimal17"
        Me.NumeroDecimal17.NullText = "0.00"
        Me.NumeroDecimal17.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal17.ReadOnly = True
        Me.NumeroDecimal17.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal17.TabIndex = 317
        Me.NumeroDecimal17.TabStop = False
        '
        'Etiqueta45
        '
        Appearance182.BackColor = System.Drawing.Color.Transparent
        Appearance182.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta45.Appearance = Appearance182
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta45.Location = New System.Drawing.Point(341, 499)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(130, 14)
        Me.Etiqueta45.TabIndex = 316
        Me.Etiqueta45.Text = "GRATIFICACION NETA"
        '
        'NumeroDecimal18
        '
        Appearance183.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal18.Appearance = Appearance183
        Me.NumeroDecimal18.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal18.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal18.Location = New System.Drawing.Point(141, 442)
        Me.NumeroDecimal18.Name = "NumeroDecimal18"
        Me.NumeroDecimal18.NullText = "0.00"
        Me.NumeroDecimal18.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal18.ReadOnly = True
        Me.NumeroDecimal18.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal18.TabIndex = 313
        Me.NumeroDecimal18.TabStop = False
        '
        'NumeroDecimal19
        '
        Appearance184.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal19.Appearance = Appearance184
        Me.NumeroDecimal19.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal19.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal19.Location = New System.Drawing.Point(141, 415)
        Me.NumeroDecimal19.Name = "NumeroDecimal19"
        Me.NumeroDecimal19.NullText = "0.00"
        Me.NumeroDecimal19.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal19.ReadOnly = True
        Me.NumeroDecimal19.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal19.TabIndex = 312
        Me.NumeroDecimal19.TabStop = False
        '
        'Etiqueta46
        '
        Appearance185.BackColor = System.Drawing.Color.Transparent
        Appearance185.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta46.Appearance = Appearance185
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta46.Location = New System.Drawing.Point(229, 446)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta46.TabIndex = 311
        Me.Etiqueta46.Text = "/  06  /  30  *"
        '
        'txtFechaTotalGT
        '
        Me.txtFechaTotalGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaTotalGT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFechaTotalGT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaTotalGT.Location = New System.Drawing.Point(279, 391)
        Me.txtFechaTotalGT.Name = "txtFechaTotalGT"
        Me.txtFechaTotalGT.ReadOnly = True
        Me.txtFechaTotalGT.Size = New System.Drawing.Size(293, 21)
        Me.txtFechaTotalGT.TabIndex = 310
        '
        'etiFFGT
        '
        Appearance186.BackColor = System.Drawing.Color.Transparent
        Appearance186.ForeColor = System.Drawing.Color.Navy
        Me.etiFFGT.Appearance = Appearance186
        Me.etiFFGT.AutoSize = True
        Me.etiFFGT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFFGT.ForeColor = System.Drawing.Color.Black
        Me.etiFFGT.Location = New System.Drawing.Point(211, 395)
        Me.etiFFGT.Name = "etiFFGT"
        Me.etiFFGT.Size = New System.Drawing.Size(62, 14)
        Me.etiFFGT.TabIndex = 309
        Me.etiFFGT.Text = "01/01/1901:"
        '
        'Etiqueta48
        '
        Appearance187.BackColor = System.Drawing.Color.Transparent
        Appearance187.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta48.Appearance = Appearance187
        Me.Etiqueta48.AutoSize = True
        Me.Etiqueta48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta48.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta48.Location = New System.Drawing.Point(121, 446)
        Me.Etiqueta48.Name = "Etiqueta48"
        Me.Etiqueta48.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta48.TabIndex = 308
        Me.Etiqueta48.Text = "b)"
        '
        'etiFIGT
        '
        Appearance188.BackColor = System.Drawing.Color.Transparent
        Appearance188.ForeColor = System.Drawing.Color.Navy
        Me.etiFIGT.Appearance = Appearance188
        Me.etiFIGT.AutoSize = True
        Me.etiFIGT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFIGT.ForeColor = System.Drawing.Color.Black
        Me.etiFIGT.Location = New System.Drawing.Point(121, 395)
        Me.etiFIGT.Name = "etiFIGT"
        Me.etiFIGT.Size = New System.Drawing.Size(62, 14)
        Me.etiFIGT.TabIndex = 307
        Me.etiFIGT.Text = "01/01/1901:"
        '
        'Etiqueta50
        '
        Appearance189.BackColor = System.Drawing.Color.Transparent
        Appearance189.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta50.Appearance = Appearance189
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta50.Location = New System.Drawing.Point(229, 419)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta50.TabIndex = 306
        Me.Etiqueta50.Text = "/  06  *"
        '
        'Etiqueta51
        '
        Appearance190.BackColor = System.Drawing.Color.Transparent
        Appearance190.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta51.Appearance = Appearance190
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(189, 395)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(16, 14)
        Me.Etiqueta51.TabIndex = 305
        Me.Etiqueta51.Text = "al:"
        '
        'Etiqueta52
        '
        Appearance191.BackColor = System.Drawing.Color.Transparent
        Appearance191.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta52.Appearance = Appearance191
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(121, 419)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta52.TabIndex = 304
        Me.Etiqueta52.Text = "a)"
        '
        'Etiqueta53
        '
        Appearance192.BackColor = System.Drawing.Color.Transparent
        Appearance192.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta53.Appearance = Appearance192
        Me.Etiqueta53.AutoSize = True
        Me.Etiqueta53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta53.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta53.Location = New System.Drawing.Point(52, 395)
        Me.Etiqueta53.Name = "Etiqueta53"
        Me.Etiqueta53.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta53.TabIndex = 303
        Me.Etiqueta53.Text = "Periodo del:"
        '
        'Etiqueta44
        '
        Appearance193.BackColor = System.Drawing.Color.Transparent
        Appearance193.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta44.Appearance = Appearance193
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta44.Location = New System.Drawing.Point(38, 366)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(187, 14)
        Me.Etiqueta44.TabIndex = 302
        Me.Etiqueta44.Text = "III. GRATIFICACIONES TRUNCAS"
        '
        'numTotalVT
        '
        Appearance194.ForeColor = System.Drawing.Color.Black
        Me.numTotalVT.Appearance = Appearance194
        Me.numTotalVT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalVT.ForeColor = System.Drawing.Color.Black
        Me.numTotalVT.Location = New System.Drawing.Point(477, 330)
        Me.numTotalVT.Name = "numTotalVT"
        Me.numTotalVT.NullText = "0.00"
        Me.numTotalVT.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalVT.ReadOnly = True
        Me.numTotalVT.Size = New System.Drawing.Size(95, 21)
        Me.numTotalVT.TabIndex = 301
        Me.numTotalVT.TabStop = False
        '
        'NumeroDecimal13
        '
        Appearance195.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal13.Appearance = Appearance195
        Me.NumeroDecimal13.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal13.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal13.Location = New System.Drawing.Point(477, 307)
        Me.NumeroDecimal13.Name = "NumeroDecimal13"
        Me.NumeroDecimal13.NullText = "0.00"
        Me.NumeroDecimal13.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal13.ReadOnly = True
        Me.NumeroDecimal13.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal13.TabIndex = 300
        Me.NumeroDecimal13.TabStop = False
        '
        'NumeroDecimal14
        '
        Appearance196.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal14.Appearance = Appearance196
        Me.NumeroDecimal14.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal14.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal14.Location = New System.Drawing.Point(477, 284)
        Me.NumeroDecimal14.Name = "NumeroDecimal14"
        Me.NumeroDecimal14.NullText = "0.00"
        Me.NumeroDecimal14.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal14.ReadOnly = True
        Me.NumeroDecimal14.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal14.TabIndex = 299
        Me.NumeroDecimal14.TabStop = False
        '
        'Etiqueta43
        '
        Appearance197.BackColor = System.Drawing.Color.Transparent
        Appearance197.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta43.Appearance = Appearance197
        Me.Etiqueta43.AutoSize = True
        Me.Etiqueta43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta43.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta43.Location = New System.Drawing.Point(258, 334)
        Me.Etiqueta43.Name = "Etiqueta43"
        Me.Etiqueta43.Size = New System.Drawing.Size(213, 14)
        Me.Etiqueta43.TabIndex = 298
        Me.Etiqueta43.Text = "REMUNERACION VACACIONAL NETA"
        '
        'Etiqueta42
        '
        Appearance198.BackColor = System.Drawing.Color.Transparent
        Appearance198.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta42.Appearance = Appearance198
        Me.Etiqueta42.AutoSize = True
        Me.Etiqueta42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta42.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta42.Location = New System.Drawing.Point(121, 242)
        Me.Etiqueta42.Name = "Etiqueta42"
        Me.Etiqueta42.Size = New System.Drawing.Size(13, 14)
        Me.Etiqueta42.TabIndex = 297
        Me.Etiqueta42.Text = "c)"
        '
        'Etiqueta41
        '
        Appearance199.BackColor = System.Drawing.Color.Transparent
        Appearance199.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta41.Appearance = Appearance199
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta41.Location = New System.Drawing.Point(229, 196)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(8, 14)
        Me.Etiqueta41.TabIndex = 295
        Me.Etiqueta41.Text = "*"
        '
        'NumeroDecimal11
        '
        Appearance200.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal11.Appearance = Appearance200
        Me.NumeroDecimal11.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal11.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal11.Location = New System.Drawing.Point(141, 192)
        Me.NumeroDecimal11.Name = "NumeroDecimal11"
        Me.NumeroDecimal11.NullText = "0.00"
        Me.NumeroDecimal11.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal11.ReadOnly = True
        Me.NumeroDecimal11.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal11.TabIndex = 294
        Me.NumeroDecimal11.TabStop = False
        '
        'NumeroDecimal6
        '
        Appearance201.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal6.Appearance = Appearance201
        Me.NumeroDecimal6.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal6.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal6.Location = New System.Drawing.Point(477, 238)
        Me.NumeroDecimal6.Name = "NumeroDecimal6"
        Me.NumeroDecimal6.NullText = "0.00"
        Me.NumeroDecimal6.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal6.ReadOnly = True
        Me.NumeroDecimal6.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal6.TabIndex = 293
        Me.NumeroDecimal6.TabStop = False
        '
        'NumeroDecimal7
        '
        Appearance202.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal7.Appearance = Appearance202
        Me.NumeroDecimal7.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal7.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal7.Location = New System.Drawing.Point(477, 215)
        Me.NumeroDecimal7.Name = "NumeroDecimal7"
        Me.NumeroDecimal7.NullText = "0.00"
        Me.NumeroDecimal7.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal7.ReadOnly = True
        Me.NumeroDecimal7.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal7.TabIndex = 292
        Me.NumeroDecimal7.TabStop = False
        '
        'NumeroDecimal8
        '
        Appearance203.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal8.Appearance = Appearance203
        Me.NumeroDecimal8.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal8.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal8.Location = New System.Drawing.Point(477, 192)
        Me.NumeroDecimal8.Name = "NumeroDecimal8"
        Me.NumeroDecimal8.NullText = "0.00"
        Me.NumeroDecimal8.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal8.ReadOnly = True
        Me.NumeroDecimal8.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal8.TabIndex = 291
        Me.NumeroDecimal8.TabStop = False
        '
        'NumeroDecimal9
        '
        Appearance204.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal9.Appearance = Appearance204
        Me.NumeroDecimal9.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal9.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal9.Location = New System.Drawing.Point(141, 238)
        Me.NumeroDecimal9.Name = "NumeroDecimal9"
        Me.NumeroDecimal9.NullText = "0.00"
        Me.NumeroDecimal9.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal9.ReadOnly = True
        Me.NumeroDecimal9.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal9.TabIndex = 287
        Me.NumeroDecimal9.TabStop = False
        '
        'NumeroDecimal10
        '
        Appearance205.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal10.Appearance = Appearance205
        Me.NumeroDecimal10.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal10.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal10.Location = New System.Drawing.Point(141, 215)
        Me.NumeroDecimal10.Name = "NumeroDecimal10"
        Me.NumeroDecimal10.NullText = "0.00"
        Me.NumeroDecimal10.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal10.ReadOnly = True
        Me.NumeroDecimal10.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal10.TabIndex = 286
        Me.NumeroDecimal10.TabStop = False
        '
        'Etiqueta33
        '
        Appearance206.BackColor = System.Drawing.Color.Transparent
        Appearance206.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance206
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(229, 242)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta33.TabIndex = 285
        Me.Etiqueta33.Text = "/  12  /  30  *"
        '
        'txtFechaTotalVT
        '
        Appearance207.TextVAlignAsString = "Middle"
        Me.txtFechaTotalVT.Appearance = Appearance207
        Me.txtFechaTotalVT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaTotalVT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFechaTotalVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaTotalVT.Location = New System.Drawing.Point(279, 156)
        Me.txtFechaTotalVT.Multiline = True
        Me.txtFechaTotalVT.Name = "txtFechaTotalVT"
        Me.txtFechaTotalVT.ReadOnly = True
        Me.txtFechaTotalVT.Size = New System.Drawing.Size(293, 34)
        Me.txtFechaTotalVT.TabIndex = 284
        '
        'etiFFVT
        '
        Appearance208.BackColor = System.Drawing.Color.Transparent
        Appearance208.ForeColor = System.Drawing.Color.Navy
        Me.etiFFVT.Appearance = Appearance208
        Me.etiFFVT.AutoSize = True
        Me.etiFFVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFFVT.ForeColor = System.Drawing.Color.Black
        Me.etiFFVT.Location = New System.Drawing.Point(211, 160)
        Me.etiFFVT.Name = "etiFFVT"
        Me.etiFFVT.Size = New System.Drawing.Size(62, 14)
        Me.etiFFVT.TabIndex = 283
        Me.etiFFVT.Text = "01/01/1901:"
        '
        'Etiqueta35
        '
        Appearance209.BackColor = System.Drawing.Color.Transparent
        Appearance209.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance209
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta35.Location = New System.Drawing.Point(121, 219)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta35.TabIndex = 282
        Me.Etiqueta35.Text = "b)"
        '
        'etiFIVT
        '
        Appearance210.BackColor = System.Drawing.Color.Transparent
        Appearance210.ForeColor = System.Drawing.Color.Navy
        Me.etiFIVT.Appearance = Appearance210
        Me.etiFIVT.AutoSize = True
        Me.etiFIVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFIVT.ForeColor = System.Drawing.Color.Black
        Me.etiFIVT.Location = New System.Drawing.Point(121, 160)
        Me.etiFIVT.Name = "etiFIVT"
        Me.etiFIVT.Size = New System.Drawing.Size(62, 14)
        Me.etiFIVT.TabIndex = 281
        Me.etiFIVT.Text = "01/01/1901:"
        '
        'Etiqueta37
        '
        Appearance211.BackColor = System.Drawing.Color.Transparent
        Appearance211.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta37.Appearance = Appearance211
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta37.Location = New System.Drawing.Point(229, 219)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta37.TabIndex = 280
        Me.Etiqueta37.Text = "/  12  *"
        '
        'Etiqueta38
        '
        Appearance212.BackColor = System.Drawing.Color.Transparent
        Appearance212.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta38.Appearance = Appearance212
        Me.Etiqueta38.AutoSize = True
        Me.Etiqueta38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta38.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta38.Location = New System.Drawing.Point(189, 160)
        Me.Etiqueta38.Name = "Etiqueta38"
        Me.Etiqueta38.Size = New System.Drawing.Size(16, 14)
        Me.Etiqueta38.TabIndex = 279
        Me.Etiqueta38.Text = "al:"
        '
        'Etiqueta39
        '
        Appearance213.BackColor = System.Drawing.Color.Transparent
        Appearance213.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta39.Appearance = Appearance213
        Me.Etiqueta39.AutoSize = True
        Me.Etiqueta39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta39.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta39.Location = New System.Drawing.Point(121, 196)
        Me.Etiqueta39.Name = "Etiqueta39"
        Me.Etiqueta39.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta39.TabIndex = 278
        Me.Etiqueta39.Text = "a)"
        '
        'Etiqueta40
        '
        Appearance214.BackColor = System.Drawing.Color.Transparent
        Appearance214.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta40.Appearance = Appearance214
        Me.Etiqueta40.AutoSize = True
        Me.Etiqueta40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta40.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta40.Location = New System.Drawing.Point(52, 160)
        Me.Etiqueta40.Name = "Etiqueta40"
        Me.Etiqueta40.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta40.TabIndex = 277
        Me.Etiqueta40.Text = "Periodo del:"
        '
        'Etiqueta31
        '
        Appearance215.BackColor = System.Drawing.Color.Transparent
        Appearance215.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance215
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(38, 139)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(153, 14)
        Me.Etiqueta31.TabIndex = 276
        Me.Etiqueta31.Text = "II. VACACIONES TRUNCAS"
        '
        'numTotalCTS
        '
        Appearance216.ForeColor = System.Drawing.Color.Black
        Me.numTotalCTS.Appearance = Appearance216
        Me.numTotalCTS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTotalCTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotalCTS.ForeColor = System.Drawing.Color.Black
        Me.numTotalCTS.Location = New System.Drawing.Point(477, 114)
        Me.numTotalCTS.Name = "numTotalCTS"
        Me.numTotalCTS.NullText = "0.00"
        Me.numTotalCTS.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTotalCTS.ReadOnly = True
        Me.numTotalCTS.Size = New System.Drawing.Size(95, 21)
        Me.numTotalCTS.TabIndex = 275
        Me.numTotalCTS.TabStop = False
        '
        'NumeroDecimal4
        '
        Appearance217.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal4.Appearance = Appearance217
        Me.NumeroDecimal4.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal4.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal4.Location = New System.Drawing.Point(477, 68)
        Me.NumeroDecimal4.Name = "NumeroDecimal4"
        Me.NumeroDecimal4.NullText = "0.00"
        Me.NumeroDecimal4.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal4.ReadOnly = True
        Me.NumeroDecimal4.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal4.TabIndex = 274
        Me.NumeroDecimal4.TabStop = False
        '
        'NumeroDecimal5
        '
        Appearance218.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal5.Appearance = Appearance218
        Me.NumeroDecimal5.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal5.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal5.Location = New System.Drawing.Point(477, 45)
        Me.NumeroDecimal5.Name = "NumeroDecimal5"
        Me.NumeroDecimal5.NullText = "0.00"
        Me.NumeroDecimal5.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal5.ReadOnly = True
        Me.NumeroDecimal5.Size = New System.Drawing.Size(95, 21)
        Me.NumeroDecimal5.TabIndex = 273
        Me.NumeroDecimal5.TabStop = False
        '
        'Etiqueta30
        '
        Appearance219.BackColor = System.Drawing.Color.Transparent
        Appearance219.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance219
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(403, 121)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta30.TabIndex = 272
        Me.Etiqueta30.Text = "TOTAL CTS"
        '
        'NumeroDecimal2
        '
        Appearance220.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal2.Appearance = Appearance220
        Me.NumeroDecimal2.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal2.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal2.Location = New System.Drawing.Point(141, 68)
        Me.NumeroDecimal2.Name = "NumeroDecimal2"
        Me.NumeroDecimal2.NullText = "0.00"
        Me.NumeroDecimal2.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal2.ReadOnly = True
        Me.NumeroDecimal2.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal2.TabIndex = 269
        Me.NumeroDecimal2.TabStop = False
        '
        'NumeroDecimal1
        '
        Appearance221.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Appearance = Appearance221
        Me.NumeroDecimal1.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.NumeroDecimal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroDecimal1.ForeColor = System.Drawing.Color.Black
        Me.NumeroDecimal1.Location = New System.Drawing.Point(141, 45)
        Me.NumeroDecimal1.Name = "NumeroDecimal1"
        Me.NumeroDecimal1.NullText = "0.00"
        Me.NumeroDecimal1.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.NumeroDecimal1.ReadOnly = True
        Me.NumeroDecimal1.Size = New System.Drawing.Size(82, 21)
        Me.NumeroDecimal1.TabIndex = 268
        Me.NumeroDecimal1.TabStop = False
        '
        'Etiqueta29
        '
        Appearance222.BackColor = System.Drawing.Color.Transparent
        Appearance222.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance222
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(229, 72)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta29.TabIndex = 267
        Me.Etiqueta29.Text = "/  12  /  30  *"
        '
        'txtFechaTotalCTS
        '
        Me.txtFechaTotalCTS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFechaTotalCTS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFechaTotalCTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaTotalCTS.Location = New System.Drawing.Point(279, 21)
        Me.txtFechaTotalCTS.Name = "txtFechaTotalCTS"
        Me.txtFechaTotalCTS.ReadOnly = True
        Me.txtFechaTotalCTS.Size = New System.Drawing.Size(293, 21)
        Me.txtFechaTotalCTS.TabIndex = 266
        '
        'etiFFCTS
        '
        Appearance223.BackColor = System.Drawing.Color.Transparent
        Appearance223.ForeColor = System.Drawing.Color.Navy
        Me.etiFFCTS.Appearance = Appearance223
        Me.etiFFCTS.AutoSize = True
        Me.etiFFCTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFFCTS.ForeColor = System.Drawing.Color.Black
        Me.etiFFCTS.Location = New System.Drawing.Point(211, 25)
        Me.etiFFCTS.Name = "etiFFCTS"
        Me.etiFFCTS.Size = New System.Drawing.Size(62, 14)
        Me.etiFFCTS.TabIndex = 265
        Me.etiFFCTS.Text = "01/01/1901:"
        '
        'Etiqueta27
        '
        Appearance224.BackColor = System.Drawing.Color.Transparent
        Appearance224.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance224
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(639, 31)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(134, 14)
        Me.Etiqueta27.TabIndex = 263
        Me.Etiqueta27.Text = "Art. 3° de la LEY N° 29351"
        '
        'Etiqueta28
        '
        Appearance225.BackColor = System.Drawing.Color.Transparent
        Appearance225.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance225
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(121, 72)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta28.TabIndex = 262
        Me.Etiqueta28.Text = "b)"
        '
        'etiFICTS
        '
        Appearance226.BackColor = System.Drawing.Color.Transparent
        Appearance226.ForeColor = System.Drawing.Color.Navy
        Me.etiFICTS.Appearance = Appearance226
        Me.etiFICTS.AutoSize = True
        Me.etiFICTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiFICTS.ForeColor = System.Drawing.Color.Black
        Me.etiFICTS.Location = New System.Drawing.Point(121, 25)
        Me.etiFICTS.Name = "etiFICTS"
        Me.etiFICTS.Size = New System.Drawing.Size(62, 14)
        Me.etiFICTS.TabIndex = 261
        Me.etiFICTS.Text = "01/01/1901:"
        '
        'Etiqueta24
        '
        Appearance227.BackColor = System.Drawing.Color.Transparent
        Appearance227.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance227
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(229, 49)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta24.TabIndex = 258
        Me.Etiqueta24.Text = "/  12  *"
        '
        'Etiqueta25
        '
        Appearance228.BackColor = System.Drawing.Color.Transparent
        Appearance228.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance228
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(189, 25)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(16, 14)
        Me.Etiqueta25.TabIndex = 257
        Me.Etiqueta25.Text = "al:"
        '
        'Etiqueta13
        '
        Appearance229.BackColor = System.Drawing.Color.Transparent
        Appearance229.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance229
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(38, 7)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(272, 14)
        Me.Etiqueta13.TabIndex = 256
        Me.Etiqueta13.Text = "I. COMPENSACION POR TIEMPO DE SERVICIOS"
        '
        'Etiqueta16
        '
        Appearance230.BackColor = System.Drawing.Color.Transparent
        Appearance230.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance230
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta16.Location = New System.Drawing.Point(141, 311)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(97, 14)
        Me.Etiqueta16.TabIndex = 253
        Me.Etiqueta16.Text = "DESCUENTO AFP"
        '
        'Etiqueta20
        '
        Appearance231.BackColor = System.Drawing.Color.Transparent
        Appearance231.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance231
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(121, 49)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(14, 14)
        Me.Etiqueta20.TabIndex = 252
        Me.Etiqueta20.Text = "a)"
        '
        'Etiqueta21
        '
        Appearance232.BackColor = System.Drawing.Color.Transparent
        Appearance232.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance232
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta21.Location = New System.Drawing.Point(52, 25)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(63, 14)
        Me.Etiqueta21.TabIndex = 251
        Me.Etiqueta21.Text = "Periodo del:"
        '
        'ficLiquidacionTrabajador
        '
        Me.ficLiquidacionTrabajador.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficLiquidacionTrabajador.Controls.Add(Me.UltraTabPageControl1)
        Me.ficLiquidacionTrabajador.Controls.Add(Me.utpMantenimiento)
        Me.ficLiquidacionTrabajador.Controls.Add(Me.UltraTabPageControl2)
        Me.ficLiquidacionTrabajador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficLiquidacionTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficLiquidacionTrabajador.Location = New System.Drawing.Point(0, 0)
        Me.ficLiquidacionTrabajador.Name = "ficLiquidacionTrabajador"
        Me.ficLiquidacionTrabajador.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficLiquidacionTrabajador.Size = New System.Drawing.Size(1257, 585)
        Me.ficLiquidacionTrabajador.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.utpMantenimiento
        UltraTab2.Text = "Mantenimiento"
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Liquidacion"
        Me.ficLiquidacionTrabajador.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        Me.ficLiquidacionTrabajador.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1255, 562)
        '
        'btnExtornar
        '
        Appearance39.ForeColor = System.Drawing.Color.MidnightBlue
        Appearance39.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.btnExtornar.Appearance = Appearance39
        Me.btnExtornar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExtornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExtornar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExtornar.Enabled = False
        Me.btnExtornar.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtornar.ForeColor = System.Drawing.Color.Black
        Me.btnExtornar.Location = New System.Drawing.Point(308, 3)
        Me.btnExtornar.Name = "btnExtornar"
        Me.btnExtornar.Size = New System.Drawing.Size(80, 24)
        Me.btnExtornar.TabIndex = 5
        Me.btnExtornar.Text = "Extornar"
        Me.btnExtornar.UseOsThemes = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ExtornarToolStripMenuItem
        '
        Me.ExtornarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ExtornarToolStripMenuItem.Name = "ExtornarToolStripMenuItem"
        Me.ExtornarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExtornarToolStripMenuItem.Text = "Extornar"
        '
        'frm_LiquidacionTrabajador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 585)
        Me.Controls.Add(Me.ficLiquidacionTrabajador)
        Me.Name = "frm_LiquidacionTrabajador"
        Me.Text = "Liquidacion Trabajador"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        CType(Me.griLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ogdLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrMenuLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMenuLista.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        Me.Agrupacion8.PerformLayout()
        CType(Me.Colores5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajadorBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utpMantenimiento.ResumeLayout(False)
        CType(Me.Gb_DatoGeneralCuentaTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gb_DatoGeneralCuentaTrabajador.ResumeLayout(False)
        Me.Gb_DatoGeneralCuentaTrabajador.PerformLayout()
        CType(Me.numPagoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlujoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMedio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaBancaria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.griContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdContratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotivoCese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatosBasicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatosBasicos.ResumeLayout(False)
        Me.agrDatosBasicos.PerformLayout()
        CType(Me.txtCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalRemComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGratificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPromHorExt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProBonProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAsigFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSueldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTiempoServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOcupacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        Me.Agrupacion6.PerformLayout()
        CType(Me.ND_AporteEsSalud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalDevolucion5ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalRetencion5ta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDTfaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalDTxFaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalDTRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGTfaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalGTxF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalGTRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTfaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalVTxF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalVTRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCTSfaltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalCTSxF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimalCTSRem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTDiasVacaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAdelantoSueldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCantGra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGTdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGTmeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTmeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVTaños, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCTSdias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCTSmeses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaTotalDT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalGT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaTotalGT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaTotalVT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotalCTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeroDecimal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaTotalCTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficLiquidacionTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficLiquidacionTrabajador.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficLiquidacionTrabajador As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents cboTrabajadorBusqueda As ISL.Controles.Combo
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents utpMantenimiento As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _utpMantenimiento_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents ogdContratos As ISL.Controles.OrigenDatos
    Friend WithEvents griContratos As ISL.Controles.Grilla
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFechaCese As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTiempoServicios As ISL.Controles.Texto
    Friend WithEvents txtOcupacion As ISL.Controles.Texto
    Friend WithEvents numTotalRemComp As ISL.Controles.NumeroDecimal
    Friend WithEvents numGratificacion As ISL.Controles.NumeroDecimal
    Friend WithEvents numPromHorExt As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents numProBonProd As ISL.Controles.NumeroDecimal
    Friend WithEvents numAsigFam As ISL.Controles.NumeroDecimal
    Friend WithEvents numSueldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents agrDatosBasicos As ISL.Controles.Agrupacion
    Friend WithEvents txtCargo As ISL.Controles.Texto
    Friend WithEvents etiCargo As ISL.Controles.Etiqueta
    Friend WithEvents txtArea As ISL.Controles.Texto
    Friend WithEvents etiArea As ISL.Controles.Etiqueta
    Friend WithEvents FotoTrabajador As System.Windows.Forms.PictureBox
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents btnCalcularLiquidacion As ISL.Controles.Boton
    Friend WithEvents txtFechaTotalCTS As ISL.Controles.Texto
    Friend WithEvents etiFFCTS As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents etiFICTS As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal2 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal1 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents numTotalVT As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal13 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal14 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta43 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta42 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal11 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal6 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal7 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal8 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal9 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal10 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents txtFechaTotalVT As ISL.Controles.Texto
    Friend WithEvents etiFFVT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents etiFIVT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta38 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta39 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta40 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents numTotalCTS As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal4 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal5 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal22 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal23 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal24 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal26 As ISL.Controles.NumeroDecimal
    Friend WithEvents txtFechaTotalDT As ISL.Controles.Texto
    Friend WithEvents etiFFDT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents etiFIDT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta57 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta58 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta59 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta60 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta56 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta54 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta55 As ISL.Controles.Etiqueta
    Friend WithEvents numBE As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents numTotalGT As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal16 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal17 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal18 As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal19 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents txtFechaTotalGT As ISL.Controles.Texto
    Friend WithEvents etiFFGT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta48 As ISL.Controles.Etiqueta
    Friend WithEvents etiFIGT As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta53 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta62 As ISL.Controles.Etiqueta
    Friend WithEvents numDT As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimal25 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta61 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents txtDiasdias As ISL.Controles.Texto
    Friend WithEvents txtGTdias As ISL.Controles.Texto
    Friend WithEvents txtGTmeses As ISL.Controles.Texto
    Friend WithEvents txtVTdias As ISL.Controles.Texto
    Friend WithEvents txtVTmeses As ISL.Controles.Texto
    Friend WithEvents txtVTaños As ISL.Controles.Texto
    Friend WithEvents txtCTSdias As ISL.Controles.Texto
    Friend WithEvents txtCTSmeses As ISL.Controles.Texto
    Friend WithEvents numTotalLiquidacion As ISL.Controles.NumeroDecimal
    Friend WithEvents etiDsctAFP As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents etiAFP1 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents numCantGra As ISL.Controles.NumeroDecimal
    Friend WithEvents numAdelantoSueldo As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta49 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents dtpFechaLiqui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta63 As ISL.Controles.Etiqueta
    Friend WithEvents ogdLiquidacionTrabajador As ISL.Controles.OrigenDatos
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvaluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents cboMotivoCese As ISL.Controles.Combo
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents Colores5 As ISL.Controles.Colores
    Friend WithEvents Etiqueta64 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents Etiqueta65 As ISL.Controles.Etiqueta
    Friend WithEvents Colores3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta66 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta67 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta68 As ISL.Controles.Etiqueta
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtVTDiasVacaciones As ISL.Controles.Texto
    Friend WithEvents Etiqueta69 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta70 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents griLiquidacionTrabajador As ISL.Controles.Grilla
    Friend WithEvents agrMenuLista As ISL.Controles.Agrupacion
    Friend WithEvents btnEliminar As ISL.Controles.Boton
    Friend WithEvents btnPagar As ISL.Controles.Boton
    Friend WithEvents btnFirmar As ISL.Controles.Boton
    Friend WithEvents btnEvaluar As ISL.Controles.Boton
    Friend WithEvents Etiqueta71 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimal3 As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta72 As ISL.Controles.Etiqueta
    Friend WithEvents cboPeriodo As ISL.Controles.Combo
    Friend WithEvents NumeroDecimalDevolucion5ta As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimalRetencion5ta As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta93 As ISL.Controles.Etiqueta
    Friend WithEvents txtDTfaltas As ISL.Controles.Texto
    Friend WithEvents NumeroDecimalDTxFaltas As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimalDTRem As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta91 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta92 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta90 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta89 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta88 As ISL.Controles.Etiqueta
    Friend WithEvents txtGTfaltas As ISL.Controles.Texto
    Friend WithEvents NumeroDecimalGTxF As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimalGTRem As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta86 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta87 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta85 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta84 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta83 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta82 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta81 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta80 As ISL.Controles.Etiqueta
    Friend WithEvents txtVTfaltas As ISL.Controles.Texto
    Friend WithEvents Etiqueta78 As ISL.Controles.Etiqueta
    Friend WithEvents NumeroDecimalVTxF As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimalVTRem As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta79 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta77 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta76 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta75 As ISL.Controles.Etiqueta
    Friend WithEvents txtCTSfaltas As ISL.Controles.Texto
    Friend WithEvents NumeroDecimalCTSxF As ISL.Controles.NumeroDecimal
    Friend WithEvents NumeroDecimalCTSRem As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta73 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta74 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta101 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta100 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta99 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta98 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta97 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta96 As ISL.Controles.Etiqueta
    Friend WithEvents btnCalcular5ta As ISL.Controles.Boton
    Friend WithEvents ND_AporteEsSalud As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta94 As ISL.Controles.Etiqueta
    Friend WithEvents Gb_DatoGeneralCuentaTrabajador As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboCuentaContable As ISL.Controles.Combo
    Friend WithEvents cboFlujoCaja As ISL.Controles.Combo
    Friend WithEvents Etiqueta95 As ISL.Controles.Etiqueta
    Friend WithEvents cboMedio As ISL.Controles.Combo
    Friend WithEvents Etiqueta103 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta104 As ISL.Controles.Etiqueta
    Friend WithEvents lblId As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents lblOperacion As ISL.Controles.Etiqueta
    Friend WithEvents txtOperaciones As ISL.Controles.Texto
    Friend WithEvents etiVoucher As ISL.Controles.Etiqueta
    Friend WithEvents cboCuentaBancaria As ISL.Controles.Combo
    Friend WithEvents Etiqueta111 As ISL.Controles.Etiqueta
    Friend WithEvents fecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numPagoTotal As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta102 As ISL.Controles.Etiqueta
    Friend WithEvents btnExtornar As ISL.Controles.Boton
    Friend WithEvents ExtornarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
