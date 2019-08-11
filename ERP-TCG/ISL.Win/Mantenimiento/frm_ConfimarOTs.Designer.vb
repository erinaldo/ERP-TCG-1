<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ConfimarOTs
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
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaConfirmo")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioConfirmo")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaConfirmo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioConfirmo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConformidad")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOT")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOT")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odomentro")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProgramacion")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngresoTaller")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioTrabajo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinTrabajo")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorTipo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jefe")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Supervisor")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odometro")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 3")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 3", 2)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialEntregada")
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataBand2 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 2")
        Dim UltraDataBand3 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 3")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajo")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMaterialEntregada")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrdenTrabajo")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Odometro")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horometro")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndConformidad")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOT")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroOT")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Odomentro")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horometro")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaProgramacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaIngresoTaller")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicioTrabajo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinTrabajo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndicadorTipo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Jefe")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Supervisor")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndConformidad")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOT")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroOT")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odomentro")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaProgramacion")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIngresoTaller")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicioTrabajo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinTrabajo")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndicadorTipo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Jefe")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Supervisor")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odometro")
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 2")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 2", 1)
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 3")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 3", 2)
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrdenTrabajo")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMaterialEntregada")
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
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.agr_Filtros = New ISL.Controles.Agrupacion(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rfHasta = New System.Windows.Forms.DateTimePicker()
        Me.rfDesde = New System.Windows.Forms.DateTimePicker()
        Me.agrupa_RC_OT = New ISL.Controles.Agrupacion(Me.components)
        Me.agr_RegConfirmadas = New ISL.Controles.Agrupacion(Me.components)
        Me.grilla_Confirmadas = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odRegConfirmadas = New ISL.Controles.OrigenDatos(Me.components)
        Me.filtro1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.gr_expande_OT = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grilla_OTs = New ISL.Controles.Grilla(Me.components)
        Me.odOrdenTrabajo = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.grid_OrdenTrabajo = New ISL.Controles.Grilla(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.rbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.gbDatosAdicionales = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_DesdeTer = New System.Windows.Forms.DateTimePicker()
        Me.dtp_DesdeProg = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optFechas = New ISL.Controles.Opciones(Me.components)
        Me.cmTipoMantenimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.dtp_HastaTer = New System.Windows.Forms.DateTimePicker()
        Me.cmMantenimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.cmEstadoOT = New ISL.Controles.ComboMaestros(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmEquipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtp_HastaProg = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbSupervisorMant = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbTipo = New ISL.Controles.ComboMaestros(Me.components)
        Me.gbNroOT = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtOT = New ISL.Controles.Texto(Me.components)
        Me.rbNroOT = New System.Windows.Forms.RadioButton()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresTerminada = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresEnProceso = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.tcOrdenTrabajo = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.agr_Filtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agr_Filtros.SuspendLayout()
        CType(Me.agrupa_RC_OT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrupa_RC_OT.SuspendLayout()
        CType(Me.agr_RegConfirmadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agr_RegConfirmadas.SuspendLayout()
        CType(Me.grilla_Confirmadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.odRegConfirmadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr_expande_OT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gr_expande_OT.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.grilla_OTs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.grid_OrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosAdicionales.SuspendLayout()
        CType(Me.optFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmTipoMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmEstadoOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupervisorMant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbNroOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNroOT.SuspendLayout()
        CType(Me.txtOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresEnProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcOrdenTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcOrdenTrabajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.SplitContainer1)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1327, 620)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.agr_Filtros)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.agrupa_RC_OT)
        Me.SplitContainer1.Size = New System.Drawing.Size(1327, 620)
        Me.SplitContainer1.SplitterDistance = 58
        Me.SplitContainer1.TabIndex = 0
        '
        'agr_Filtros
        '
        Me.agr_Filtros.Controls.Add(Me.Label2)
        Me.agr_Filtros.Controls.Add(Me.Label1)
        Me.agr_Filtros.Controls.Add(Me.rfHasta)
        Me.agr_Filtros.Controls.Add(Me.rfDesde)
        Me.agr_Filtros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agr_Filtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agr_Filtros.ForeColor = System.Drawing.Color.Black
        Me.agr_Filtros.Location = New System.Drawing.Point(0, 0)
        Me.agr_Filtros.Name = "agr_Filtros"
        Me.agr_Filtros.Size = New System.Drawing.Size(1325, 56)
        Me.agr_Filtros.TabIndex = 0
        Me.agr_Filtros.Text = "Filtros"
        Me.agr_Filtros.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(174, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'rfHasta
        '
        Me.rfHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfHasta.Location = New System.Drawing.Point(218, 26)
        Me.rfHasta.Name = "rfHasta"
        Me.rfHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfHasta.TabIndex = 3
        '
        'rfDesde
        '
        Me.rfDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfDesde.Location = New System.Drawing.Point(56, 25)
        Me.rfDesde.Name = "rfDesde"
        Me.rfDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfDesde.TabIndex = 1
        '
        'agrupa_RC_OT
        '
        Me.agrupa_RC_OT.Controls.Add(Me.agr_RegConfirmadas)
        Me.agrupa_RC_OT.Controls.Add(Me.gr_expande_OT)
        Me.agrupa_RC_OT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrupa_RC_OT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrupa_RC_OT.ForeColor = System.Drawing.Color.Black
        Me.agrupa_RC_OT.Location = New System.Drawing.Point(0, 0)
        Me.agrupa_RC_OT.Name = "agrupa_RC_OT"
        Me.agrupa_RC_OT.Size = New System.Drawing.Size(1325, 556)
        Me.agrupa_RC_OT.TabIndex = 0
        Me.agrupa_RC_OT.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'agr_RegConfirmadas
        '
        Me.agr_RegConfirmadas.Controls.Add(Me.grilla_Confirmadas)
        Me.agr_RegConfirmadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agr_RegConfirmadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agr_RegConfirmadas.ForeColor = System.Drawing.Color.Black
        Me.agr_RegConfirmadas.Location = New System.Drawing.Point(2, 2)
        Me.agr_RegConfirmadas.Name = "agr_RegConfirmadas"
        Me.agr_RegConfirmadas.Size = New System.Drawing.Size(1321, 526)
        Me.agr_RegConfirmadas.TabIndex = 0
        Me.agr_RegConfirmadas.Text = "Listado de Confirmaciones"
        Me.agr_RegConfirmadas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grilla_Confirmadas
        '
        Me.grilla_Confirmadas.ContextMenuStrip = Me.mcDetalle
        Me.grilla_Confirmadas.DataSource = Me.odRegConfirmadas
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn2.CellAppearance = Appearance1
        UltraGridColumn2.Header.Caption = "Fecha"
        UltraGridColumn2.Header.VisiblePosition = 2
        UltraGridColumn2.MaskInput = "{LOC}dd/mm/yy"
        UltraGridColumn2.Width = 83
        UltraGridColumn3.Header.VisiblePosition = 3
        UltraGridColumn3.Width = 325
        UltraGridColumn4.Header.Caption = "Confirmo"
        UltraGridColumn4.Header.VisiblePosition = 4
        UltraGridColumn4.Width = 286
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.grilla_Confirmadas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grilla_Confirmadas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Confirmadas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilla_Confirmadas.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilla_Confirmadas.DisplayLayout.Override.FilterUIProvider = Me.filtro1
        Me.grilla_Confirmadas.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grilla_Confirmadas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla_Confirmadas.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilla_Confirmadas.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grilla_Confirmadas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_Confirmadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla_Confirmadas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_Confirmadas.Location = New System.Drawing.Point(3, 16)
        Me.grilla_Confirmadas.Name = "grilla_Confirmadas"
        Me.grilla_Confirmadas.Size = New System.Drawing.Size(1315, 507)
        Me.grilla_Confirmadas.TabIndex = 0
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.RegistrarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(144, 48)
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.lupa
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.VerToolStripMenuItem.Text = "Mostrar OT's"
        Me.VerToolStripMenuItem.ToolTipText = "Insertar un nuevo Detalle"
        '
        'RegistrarToolStripMenuItem
        '
        Me.RegistrarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Insertar
        Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
        Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.RegistrarToolStripMenuItem.Text = "Confirmar OT's"
        '
        'odRegConfirmadas
        '
        Me.odRegConfirmadas.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        '
        'gr_expande_OT
        '
        Me.gr_expande_OT.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gr_expande_OT.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gr_expande_OT.Expanded = False
        Me.gr_expande_OT.ExpandedSize = New System.Drawing.Size(1321, 328)
        Me.gr_expande_OT.Location = New System.Drawing.Point(2, 528)
        Me.gr_expande_OT.Name = "gr_expande_OT"
        Me.gr_expande_OT.Size = New System.Drawing.Size(1321, 26)
        Me.gr_expande_OT.TabIndex = 1
        Me.gr_expande_OT.Text = "OT's Confirmadas"
        Me.gr_expande_OT.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grilla_OTs)
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(1254, 257)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        Me.UltraExpandableGroupBoxPanel1.Visible = False
        '
        'grilla_OTs
        '
        Me.grilla_OTs.DataSource = Me.odOrdenTrabajo
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.VisiblePosition = 13
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 0
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.Caption = "N°OT/ Equipo/ Mantenimiento/ Material"
        UltraGridColumn9.Header.VisiblePosition = 1
        UltraGridColumn9.Width = 283
        UltraGridColumn10.Header.Caption = "Tipo Mantenimiento/ Cant. Entregada"
        UltraGridColumn10.Header.VisiblePosition = 2
        UltraGridColumn11.Header.VisiblePosition = 3
        UltraGridColumn11.Width = 70
        UltraGridColumn12.Header.VisiblePosition = 4
        UltraGridColumn12.Width = 71
        UltraGridColumn13.Header.Caption = "Fecha Prog."
        UltraGridColumn13.Header.VisiblePosition = 5
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn13.Width = 131
        UltraGridColumn14.Header.Caption = "F. Ingr. Taller"
        UltraGridColumn14.Header.VisiblePosition = 6
        UltraGridColumn14.Hidden = True
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn15.Header.Caption = "F. Inicio Trabajo"
        UltraGridColumn15.Header.VisiblePosition = 7
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn16.Header.Caption = "F. Fin Trabajo"
        UltraGridColumn16.Header.VisiblePosition = 8
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn17.CellAppearance = Appearance2
        UltraGridColumn17.Header.Caption = "Tipo"
        UltraGridColumn17.Header.VisiblePosition = 10
        UltraGridColumn17.Width = 44
        UltraGridColumn18.Header.VisiblePosition = 9
        UltraGridColumn18.Width = 77
        UltraGridColumn19.Header.VisiblePosition = 12
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 11
        UltraGridColumn20.Width = 287
        UltraGridColumn21.Header.Caption = "Usuario"
        UltraGridColumn21.Header.VisiblePosition = 14
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 15
        UltraGridColumn23.Header.VisiblePosition = 16
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn26.Width = 264
        UltraGridColumn27.Header.VisiblePosition = 3
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn28.Width = 70
        UltraGridColumn29.Header.VisiblePosition = 5
        UltraGridColumn29.Width = 71
        UltraGridColumn30.Header.VisiblePosition = 6
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30})
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 1
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 2
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 3
        UltraGridColumn34.Width = 245
        UltraGridColumn35.Header.VisiblePosition = 4
        UltraGridColumn36.Header.VisiblePosition = 5
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.Width = 173
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Hidden = True
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 226
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Width = 204
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42})
        Me.grilla_OTs.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grilla_OTs.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grilla_OTs.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grilla_OTs.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grilla_OTs.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grilla_OTs.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grilla_OTs.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grilla_OTs.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grilla_OTs.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grilla_OTs.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grilla_OTs.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grilla_OTs.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grilla_OTs.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grilla_OTs.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grilla_OTs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grilla_OTs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grilla_OTs.Location = New System.Drawing.Point(0, 0)
        Me.grilla_OTs.Name = "grilla_OTs"
        Me.grilla_OTs.Size = New System.Drawing.Size(1254, 257)
        Me.grilla_OTs.TabIndex = 11
        '
        'odOrdenTrabajo
        '
        UltraDataBand3.Columns.AddRange(New Object() {UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12})
        UltraDataBand2.ChildBands.AddRange(New Object() {UltraDataBand3})
        UltraDataBand2.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17})
        UltraDataBand1.ChildBands.AddRange(New Object() {UltraDataBand2})
        UltraDataColumn22.DataType = GetType(Decimal)
        UltraDataColumn22.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn23.DataType = GetType(Decimal)
        UltraDataColumn23.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23})
        Me.odOrdenTrabajo.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn31.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Date)
        UltraDataColumn33.DataType = GetType(Date)
        UltraDataColumn39.DataType = GetType(Boolean)
        UltraDataColumn39.DefaultValue = False
        Me.odOrdenTrabajo.Band.Columns.AddRange(New Object() {UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1327, 620)
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.grid_OrdenTrabajo)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 180)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1327, 440)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "OT's:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'grid_OrdenTrabajo
        '
        Me.grid_OrdenTrabajo.DataSource = Me.odOrdenTrabajo
        Appearance3.BackColor = System.Drawing.SystemColors.Window
        Appearance3.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_OrdenTrabajo.DisplayLayout.Appearance = Appearance3
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn43.Format = ""
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn43.Header.Appearance = Appearance4
        UltraGridColumn43.Header.Caption = "Conformidad"
        UltraGridColumn43.Header.VisiblePosition = 5
        UltraGridColumn43.Hidden = True
        UltraGridColumn43.Width = 80
        UltraGridColumn44.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn44.Header.Appearance = Appearance5
        UltraGridColumn44.Header.VisiblePosition = 0
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn45.Header.Appearance = Appearance6
        UltraGridColumn45.Header.Caption = "NroOT/Equipo/Mantenimiento/Material"
        UltraGridColumn45.Header.VisiblePosition = 1
        UltraGridColumn45.Width = 310
        UltraGridColumn46.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn46.Header.Appearance = Appearance7
        UltraGridColumn46.Header.Caption = "Tipo Mant. / Cant. Entregada"
        UltraGridColumn46.Header.VisiblePosition = 2
        UltraGridColumn46.Width = 201
        UltraGridColumn47.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn47.Header.Appearance = Appearance8
        UltraGridColumn47.Header.VisiblePosition = 3
        UltraGridColumn47.Width = 81
        UltraGridColumn48.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn48.Header.Appearance = Appearance9
        UltraGridColumn48.Header.VisiblePosition = 4
        UltraGridColumn48.Width = 75
        UltraGridColumn49.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn49.Header.Appearance = Appearance10
        UltraGridColumn49.Header.Caption = "Fecha Prog."
        UltraGridColumn49.Header.VisiblePosition = 6
        UltraGridColumn49.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn49.Width = 135
        UltraGridColumn50.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance11.TextHAlignAsString = "Center"
        UltraGridColumn50.Header.Appearance = Appearance11
        UltraGridColumn50.Header.Caption = "F. IngresoTaller"
        UltraGridColumn50.Header.VisiblePosition = 7
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn51.Header.Appearance = Appearance12
        UltraGridColumn51.Header.Caption = "F. Inicio Trabajo"
        UltraGridColumn51.Header.VisiblePosition = 8
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn52.Header.Appearance = Appearance13
        UltraGridColumn52.Header.Caption = "F. Fin Trabajo"
        UltraGridColumn52.Header.VisiblePosition = 9
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn53.CellAppearance = Appearance14
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn53.Header.Appearance = Appearance15
        UltraGridColumn53.Header.Caption = "Tipo"
        UltraGridColumn53.Header.VisiblePosition = 11
        UltraGridColumn53.Width = 49
        UltraGridColumn54.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn54.Header.Appearance = Appearance16
        UltraGridColumn54.Header.VisiblePosition = 10
        UltraGridColumn54.Width = 81
        UltraGridColumn55.Header.VisiblePosition = 14
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 12
        UltraGridColumn56.Width = 224
        UltraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn57.Header.Appearance = Appearance17
        UltraGridColumn57.Header.Caption = "Usuario"
        UltraGridColumn57.Header.VisiblePosition = 13
        UltraGridColumn57.Width = 80
        UltraGridColumn58.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn58.Header.VisiblePosition = 15
        UltraGridColumn58.Width = 76
        UltraGridColumn59.Header.VisiblePosition = 16
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59})
        UltraGridBand6.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn60.Header.VisiblePosition = 0
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 1
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 2
        UltraGridColumn62.Width = 291
        UltraGridColumn63.Header.Caption = "Tipo Mantenimiento"
        UltraGridColumn63.Header.VisiblePosition = 3
        UltraGridColumn63.Width = 201
        UltraGridColumn64.Header.VisiblePosition = 4
        UltraGridColumn64.Width = 81
        UltraGridColumn65.Header.VisiblePosition = 5
        UltraGridColumn65.Width = 75
        UltraGridColumn66.Header.VisiblePosition = 6
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66})
        UltraGridColumn67.Header.VisiblePosition = 0
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.Header.VisiblePosition = 1
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.Header.VisiblePosition = 2
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.Header.VisiblePosition = 3
        UltraGridColumn70.Width = 272
        UltraGridColumn71.Header.Caption = "Tipo Mantenimiento"
        UltraGridColumn71.Header.VisiblePosition = 4
        UltraGridColumn71.Width = 201
        UltraGridColumn72.Header.VisiblePosition = 5
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72})
        UltraGridColumn73.Header.VisiblePosition = 0
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.Header.VisiblePosition = 1
        UltraGridColumn74.Hidden = True
        UltraGridColumn75.Header.VisiblePosition = 2
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.Header.VisiblePosition = 3
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.Header.VisiblePosition = 4
        UltraGridColumn77.Width = 253
        UltraGridColumn78.Header.Caption = "Cant. Entregada"
        UltraGridColumn78.Header.VisiblePosition = 5
        UltraGridColumn78.Width = 201
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78})
        Me.grid_OrdenTrabajo.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grid_OrdenTrabajo.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.grid_OrdenTrabajo.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.grid_OrdenTrabajo.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.grid_OrdenTrabajo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_OrdenTrabajo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance18.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance18.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance18.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance18.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_OrdenTrabajo.DisplayLayout.GroupByBox.Appearance = Appearance18
        Appearance19.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_OrdenTrabajo.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance19
        Me.grid_OrdenTrabajo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_OrdenTrabajo.DisplayLayout.GroupByBox.Hidden = True
        Appearance20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance20.BackColor2 = System.Drawing.SystemColors.Control
        Appearance20.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grid_OrdenTrabajo.DisplayLayout.GroupByBox.PromptAppearance = Appearance20
        Me.grid_OrdenTrabajo.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_OrdenTrabajo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance21.BackColor = System.Drawing.SystemColors.Window
        Appearance21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grid_OrdenTrabajo.DisplayLayout.Override.ActiveCellAppearance = Appearance21
        Appearance22.BackColor = System.Drawing.SystemColors.Highlight
        Appearance22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_OrdenTrabajo.DisplayLayout.Override.ActiveRowAppearance = Appearance22
        Me.grid_OrdenTrabajo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_OrdenTrabajo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_OrdenTrabajo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grid_OrdenTrabajo.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Me.grid_OrdenTrabajo.DisplayLayout.Override.CardAreaAppearance = Appearance23
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Appearance24.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grid_OrdenTrabajo.DisplayLayout.Override.CellAppearance = Appearance24
        Me.grid_OrdenTrabajo.DisplayLayout.Override.CellPadding = 0
        Appearance25.BackColor = System.Drawing.SystemColors.Control
        Appearance25.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance25.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance25.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance25.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_OrdenTrabajo.DisplayLayout.Override.GroupByRowAppearance = Appearance25
        Appearance26.TextHAlignAsString = "Left"
        Me.grid_OrdenTrabajo.DisplayLayout.Override.HeaderAppearance = Appearance26
        Me.grid_OrdenTrabajo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance27.BackColor = System.Drawing.SystemColors.Window
        Appearance27.BorderColor = System.Drawing.Color.Silver
        Me.grid_OrdenTrabajo.DisplayLayout.Override.RowAppearance = Appearance27
        Me.grid_OrdenTrabajo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_OrdenTrabajo.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grid_OrdenTrabajo.DisplayLayout.Override.TemplateAddRowAppearance = Appearance28
        Me.grid_OrdenTrabajo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_OrdenTrabajo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_OrdenTrabajo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_OrdenTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_OrdenTrabajo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_OrdenTrabajo.Location = New System.Drawing.Point(3, 16)
        Me.grid_OrdenTrabajo.Name = "grid_OrdenTrabajo"
        Me.grid_OrdenTrabajo.Size = New System.Drawing.Size(1321, 421)
        Me.grid_OrdenTrabajo.TabIndex = 0
        '
        'Agrupacion3
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Me.Agrupacion3.Appearance = Appearance29
        Me.Agrupacion3.Controls.Add(Me.rbDatosAdicionales)
        Me.Agrupacion3.Controls.Add(Me.gbDatosAdicionales)
        Me.Agrupacion3.Controls.Add(Me.gbNroOT)
        Me.Agrupacion3.Controls.Add(Me.rbNroOT)
        Me.Agrupacion3.Controls.Add(Me.Agrupacion5)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Navy
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1327, 180)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Filtros:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rbDatosAdicionales
        '
        Me.rbDatosAdicionales.AutoSize = True
        Me.rbDatosAdicionales.Checked = True
        Me.rbDatosAdicionales.Location = New System.Drawing.Point(6, 16)
        Me.rbDatosAdicionales.Name = "rbDatosAdicionales"
        Me.rbDatosAdicionales.Size = New System.Drawing.Size(113, 17)
        Me.rbDatosAdicionales.TabIndex = 0
        Me.rbDatosAdicionales.TabStop = True
        Me.rbDatosAdicionales.Text = "Datos Adicionales:"
        Me.rbDatosAdicionales.UseVisualStyleBackColor = True
        '
        'gbDatosAdicionales
        '
        Me.gbDatosAdicionales.Controls.Add(Me.Label6)
        Me.gbDatosAdicionales.Controls.Add(Me.Label4)
        Me.gbDatosAdicionales.Controls.Add(Me.dtp_DesdeTer)
        Me.gbDatosAdicionales.Controls.Add(Me.dtp_DesdeProg)
        Me.gbDatosAdicionales.Controls.Add(Me.Label5)
        Me.gbDatosAdicionales.Controls.Add(Me.optFechas)
        Me.gbDatosAdicionales.Controls.Add(Me.cmTipoMantenimiento)
        Me.gbDatosAdicionales.Controls.Add(Me.dtp_HastaTer)
        Me.gbDatosAdicionales.Controls.Add(Me.cmMantenimiento)
        Me.gbDatosAdicionales.Controls.Add(Me.cmEstadoOT)
        Me.gbDatosAdicionales.Controls.Add(Me.Label3)
        Me.gbDatosAdicionales.Controls.Add(Me.cmEquipo)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta5)
        Me.gbDatosAdicionales.Controls.Add(Me.dtp_HastaProg)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta7)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta9)
        Me.gbDatosAdicionales.Controls.Add(Me.cmbSupervisorMant)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta13)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta17)
        Me.gbDatosAdicionales.Controls.Add(Me.Etiqueta15)
        Me.gbDatosAdicionales.Controls.Add(Me.cmbTipo)
        Me.gbDatosAdicionales.Location = New System.Drawing.Point(6, 38)
        Me.gbDatosAdicionales.Name = "gbDatosAdicionales"
        Me.gbDatosAdicionales.Size = New System.Drawing.Size(668, 136)
        Me.gbDatosAdicionales.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Desde:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Desde:"
        '
        'dtp_DesdeTer
        '
        Me.dtp_DesdeTer.Enabled = False
        Me.dtp_DesdeTer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DesdeTer.Location = New System.Drawing.Point(91, 63)
        Me.dtp_DesdeTer.Name = "dtp_DesdeTer"
        Me.dtp_DesdeTer.Size = New System.Drawing.Size(98, 20)
        Me.dtp_DesdeTer.TabIndex = 10
        '
        'dtp_DesdeProg
        '
        Me.dtp_DesdeProg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_DesdeProg.Location = New System.Drawing.Point(91, 19)
        Me.dtp_DesdeProg.Name = "dtp_DesdeProg"
        Me.dtp_DesdeProg.Size = New System.Drawing.Size(98, 20)
        Me.dtp_DesdeProg.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Hasta:"
        '
        'optFechas
        '
        Appearance30.ForeColorDisabled = System.Drawing.Color.Navy
        Me.optFechas.Appearance = Appearance30
        Me.optFechas.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.optFechas.CheckedIndex = 0
        Me.optFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFechas.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "ValueListItem1"
        ValueListItem1.DisplayText = "F. Programacion:"
        ValueListItem4.DataValue = False
        ValueListItem4.DisplayText = "F. Termino:"
        Me.optFechas.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem4})
        Me.optFechas.ItemSpacingVertical = 25
        Me.optFechas.Location = New System.Drawing.Point(16, -8)
        Me.optFechas.Name = "optFechas"
        Me.optFechas.Size = New System.Drawing.Size(110, 69)
        Me.optFechas.TabIndex = 0
        Me.optFechas.Text = "F. Programacion:"
        '
        'cmTipoMantenimiento
        '
        Appearance31.ForeColor = System.Drawing.Color.Black
        Me.cmTipoMantenimiento.Appearance = Appearance31
        Me.cmTipoMantenimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmTipoMantenimiento.DisplayMember = "Nombre"
        Me.cmTipoMantenimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmTipoMantenimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmTipoMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmTipoMantenimiento.ForeColor = System.Drawing.Color.Black
        Me.cmTipoMantenimiento.Location = New System.Drawing.Point(343, 18)
        Me.cmTipoMantenimiento.Name = "cmTipoMantenimiento"
        Me.cmTipoMantenimiento.Size = New System.Drawing.Size(134, 21)
        Me.cmTipoMantenimiento.TabIndex = 6
        Me.cmTipoMantenimiento.ValueMember = "Id"
        '
        'dtp_HastaTer
        '
        Me.dtp_HastaTer.Enabled = False
        Me.dtp_HastaTer.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaTer.Location = New System.Drawing.Point(239, 63)
        Me.dtp_HastaTer.Name = "dtp_HastaTer"
        Me.dtp_HastaTer.Size = New System.Drawing.Size(98, 20)
        Me.dtp_HastaTer.TabIndex = 12
        '
        'cmMantenimiento
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cmMantenimiento.Appearance = Appearance32
        Me.cmMantenimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmMantenimiento.DisplayMember = "Nombre"
        Me.cmMantenimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmMantenimiento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmMantenimiento.ForeColor = System.Drawing.Color.Black
        Me.cmMantenimiento.Location = New System.Drawing.Point(496, 18)
        Me.cmMantenimiento.Name = "cmMantenimiento"
        Me.cmMantenimiento.Size = New System.Drawing.Size(165, 21)
        Me.cmMantenimiento.TabIndex = 8
        Me.cmMantenimiento.ValueMember = "Id"
        '
        'cmEstadoOT
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cmEstadoOT.Appearance = Appearance33
        Me.cmEstadoOT.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmEstadoOT.DisplayMember = "Nombre"
        Me.cmEstadoOT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmEstadoOT.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmEstadoOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmEstadoOT.ForeColor = System.Drawing.Color.Black
        Me.cmEstadoOT.Location = New System.Drawing.Point(496, 63)
        Me.cmEstadoOT.Name = "cmEstadoOT"
        Me.cmEstadoOT.Size = New System.Drawing.Size(165, 21)
        Me.cmEstadoOT.TabIndex = 16
        Me.cmEstadoOT.ValueMember = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta:"
        '
        'cmEquipo
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cmEquipo.Appearance = Appearance34
        Me.cmEquipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmEquipo.DisplayMember = "Nombre"
        Me.cmEquipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmEquipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmEquipo.ForeColor = System.Drawing.Color.Black
        Me.cmEquipo.Location = New System.Drawing.Point(496, 110)
        Me.cmEquipo.Name = "cmEquipo"
        Me.cmEquipo.Size = New System.Drawing.Size(165, 21)
        Me.cmEquipo.TabIndex = 20
        Me.cmEquipo.ValueMember = "Id"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(343, 4)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(104, 14)
        Me.Etiqueta5.TabIndex = 5
        Me.Etiqueta5.Text = "Tipo Mantenimiento:"
        '
        'dtp_HastaProg
        '
        Me.dtp_HastaProg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_HastaProg.Location = New System.Drawing.Point(239, 19)
        Me.dtp_HastaProg.Name = "dtp_HastaProg"
        Me.dtp_HastaProg.Size = New System.Drawing.Size(98, 20)
        Me.dtp_HastaProg.TabIndex = 4
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(496, 4)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta7.TabIndex = 7
        Me.Etiqueta7.Text = "Mantenimiento:"
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(496, 90)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta9.TabIndex = 19
        Me.Etiqueta9.Text = "Equipo:"
        '
        'cmbSupervisorMant
        '
        Appearance35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbSupervisorMant.Appearance = Appearance35
        Me.cmbSupervisorMant.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbSupervisorMant.DisplayMember = "NombreCompleto"
        Me.cmbSupervisorMant.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbSupervisorMant.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbSupervisorMant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupervisorMant.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbSupervisorMant.Location = New System.Drawing.Point(232, 109)
        Me.cmbSupervisorMant.Name = "cmbSupervisorMant"
        Me.cmbSupervisorMant.Size = New System.Drawing.Size(258, 21)
        Me.cmbSupervisorMant.TabIndex = 18
        Me.cmbSupervisorMant.ValueMember = "Id"
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(496, 47)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(41, 14)
        Me.Etiqueta13.TabIndex = 15
        Me.Etiqueta13.Text = "Estado:"
        '
        'Etiqueta17
        '
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(232, 89)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(93, 14)
        Me.Etiqueta17.TabIndex = 17
        Me.Etiqueta17.Text = "Supervisor Mant. :"
        '
        'Etiqueta15
        '
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(343, 47)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(47, 14)
        Me.Etiqueta15.TabIndex = 13
        Me.Etiqueta15.Text = "Tipo OT:"
        '
        'cmbTipo
        '
        Appearance36.ForeColor = System.Drawing.Color.Black
        Me.cmbTipo.Appearance = Appearance36
        Me.cmbTipo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cmbTipo.DisplayMember = "Nombre"
        Me.cmbTipo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.Black
        ValueListItem2.DataValue = "ValueListItem0"
        ValueListItem2.DisplayText = "TODOS"
        ValueListItem3.DataValue = "ValueListItem1"
        ValueListItem3.DisplayText = "INTERNA"
        ValueListItem7.DataValue = "ValueListItem2"
        ValueListItem7.DisplayText = "EXTERNA"
        Me.cmbTipo.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem2, ValueListItem3, ValueListItem7})
        Me.cmbTipo.Location = New System.Drawing.Point(343, 63)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(134, 21)
        Me.cmbTipo.TabIndex = 14
        Me.cmbTipo.ValueMember = "Id"
        '
        'gbNroOT
        '
        Me.gbNroOT.Controls.Add(Me.txtOT)
        Me.gbNroOT.Location = New System.Drawing.Point(687, 38)
        Me.gbNroOT.Name = "gbNroOT"
        Me.gbNroOT.Size = New System.Drawing.Size(200, 36)
        Me.gbNroOT.TabIndex = 3
        Me.gbNroOT.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtOT
        '
        Appearance37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOT.Appearance = Appearance37
        Me.txtOT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOT.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOT.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtOT.Location = New System.Drawing.Point(6, 6)
        Me.txtOT.MaxLength = 10
        Me.txtOT.Name = "txtOT"
        Me.txtOT.Size = New System.Drawing.Size(128, 21)
        Me.txtOT.TabIndex = 0
        '
        'rbNroOT
        '
        Me.rbNroOT.AutoSize = True
        Me.rbNroOT.BackColor = System.Drawing.Color.Transparent
        Me.rbNroOT.ForeColor = System.Drawing.Color.Navy
        Me.rbNroOT.Location = New System.Drawing.Point(691, 16)
        Me.rbNroOT.Name = "rbNroOT"
        Me.rbNroOT.Size = New System.Drawing.Size(58, 17)
        Me.rbNroOT.TabIndex = 2
        Me.rbNroOT.TabStop = True
        Me.rbNroOT.Text = "N° OT:"
        Me.rbNroOT.UseVisualStyleBackColor = False
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.ColoresTerminada)
        Me.Agrupacion5.Controls.Add(Me.etiTerminada)
        Me.Agrupacion5.Controls.Add(Me.ColoresEnProceso)
        Me.Agrupacion5.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion5.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion5.Controls.Add(Me.etiGenerada)
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(687, 80)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(214, 72)
        Me.Agrupacion5.TabIndex = 4
        Me.Agrupacion5.Text = "Estados"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresTerminada
        '
        Me.ColoresTerminada.Location = New System.Drawing.Point(139, 43)
        Me.ColoresTerminada.Name = "ColoresTerminada"
        Me.ColoresTerminada.Size = New System.Drawing.Size(46, 21)
        Me.ColoresTerminada.TabIndex = 5
        Me.ColoresTerminada.Text = "Control"
        '
        'etiTerminada
        '
        Appearance38.BackColor = System.Drawing.Color.Transparent
        Appearance38.ForeColor = System.Drawing.Color.Navy
        Me.etiTerminada.Appearance = Appearance38
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(140, 21)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(60, 14)
        Me.etiTerminada.TabIndex = 4
        Me.etiTerminada.Text = "Terminada:"
        '
        'ColoresEnProceso
        '
        Me.ColoresEnProceso.Location = New System.Drawing.Point(72, 43)
        Me.ColoresEnProceso.Name = "ColoresEnProceso"
        Me.ColoresEnProceso.Size = New System.Drawing.Size(43, 21)
        Me.ColoresEnProceso.TabIndex = 3
        Me.ColoresEnProceso.Text = "Control"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Location = New System.Drawing.Point(5, 43)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "Control"
        '
        'etiEnProceso
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.etiEnProceso.Appearance = Appearance39
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(69, 21)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(63, 14)
        Me.etiEnProceso.TabIndex = 2
        Me.etiEnProceso.Text = "En proceso:"
        '
        'etiGenerada
        '
        Appearance40.BackColor = System.Drawing.Color.Transparent
        Appearance40.ForeColor = System.Drawing.Color.Navy
        Me.etiGenerada.Appearance = Appearance40
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(6, 21)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(56, 14)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Generada:"
        '
        'tcOrdenTrabajo
        '
        Me.tcOrdenTrabajo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcOrdenTrabajo.Controls.Add(Me.UltraTabPageControl1)
        Me.tcOrdenTrabajo.Controls.Add(Me.UltraTabPageControl2)
        Me.tcOrdenTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcOrdenTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcOrdenTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.tcOrdenTrabajo.Name = "tcOrdenTrabajo"
        Me.tcOrdenTrabajo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcOrdenTrabajo.Size = New System.Drawing.Size(1329, 643)
        Me.tcOrdenTrabajo.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl2
        UltraTab3.Text = "Lista Confirmaciones"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Confirmar OT's"
        Me.tcOrdenTrabajo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab1})
        Me.tcOrdenTrabajo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1327, 620)
        '
        'frm_ConfimarOTs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 643)
        Me.Controls.Add(Me.tcOrdenTrabajo)
        Me.Name = "frm_ConfimarOTs"
        Me.Text = "Ordenes De Trabajo"
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.agr_Filtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agr_Filtros.ResumeLayout(False)
        Me.agr_Filtros.PerformLayout()
        CType(Me.agrupa_RC_OT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrupa_RC_OT.ResumeLayout(False)
        CType(Me.agr_RegConfirmadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agr_RegConfirmadas.ResumeLayout(False)
        CType(Me.grilla_Confirmadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.odRegConfirmadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gr_expande_OT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gr_expande_OT.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.grilla_OTs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.grid_OrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.gbDatosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosAdicionales.ResumeLayout(False)
        Me.gbDatosAdicionales.PerformLayout()
        CType(Me.optFechas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmTipoMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmEstadoOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupervisorMant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbNroOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNroOT.ResumeLayout(False)
        Me.gbNroOT.PerformLayout()
        CType(Me.txtOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.ColoresTerminada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresEnProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcOrdenTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcOrdenTrabajo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcOrdenTrabajo As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents txtOT As ISL.Controles.Texto
    Friend WithEvents rbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTipo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents optFechas As ISL.Controles.Opciones
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cmEquipo As ISL.Controles.ComboMaestros
    Friend WithEvents cmEstadoOT As ISL.Controles.ComboMaestros
    Friend WithEvents cmMantenimiento As ISL.Controles.ComboMaestros
    Friend WithEvents cmTipoMantenimiento As ISL.Controles.ComboMaestros
    Friend WithEvents odOrdenTrabajo As ISL.Controles.OrigenDatos
    Friend WithEvents grid_OrdenTrabajo As ISL.Controles.Grilla
    Friend WithEvents rbNroOT As System.Windows.Forms.RadioButton
    Friend WithEvents cmbSupervisorMant As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresTerminada As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresEnProceso As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents agr_Filtros As ISL.Controles.Agrupacion
    Friend WithEvents agrupa_RC_OT As ISL.Controles.Agrupacion
    Friend WithEvents agr_RegConfirmadas As ISL.Controles.Agrupacion
    Friend WithEvents grilla_Confirmadas As ISL.Controles.Grilla
    Friend WithEvents gr_expande_OT As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grilla_OTs As ISL.Controles.Grilla
    Friend WithEvents odRegConfirmadas As ISL.Controles.OrigenDatos
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rfHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rfDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_HastaTer As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DesdeTer As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_HastaProg As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_DesdeProg As System.Windows.Forms.DateTimePicker
    Friend WithEvents filtro1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents gbDatosAdicionales As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents gbNroOT As Infragistics.Win.Misc.UltraGroupBox
End Class
