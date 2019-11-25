<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vehiculo
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Documento")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Certificadora")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaEmision")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaEmisora")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Documento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Certificadora")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaEmision")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaEmisora")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Indicador")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Indicador")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDispositivo")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerie")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaUltimaAct")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDispositivo")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerie")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaUltimaAct")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Numero")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Porcentaje")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndBonificacion")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim ColScrollRegion1 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(1359)
        Dim ColScrollRegion2 As Infragistics.Win.UltraWinGrid.ColScrollRegion = New Infragistics.Win.UltraWinGrid.ColScrollRegion(-193)
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Numero")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Porcentaje")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndBonificacion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlota")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlota")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocumento")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RutaImagen")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencimiento")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVigente")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaPropietaria")
        Dim UltraGridColumn172 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroTarjeta")
        Dim UltraGridColumn173 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicial")
        Dim UltraGridColumn174 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFinal")
        Dim UltraGridColumn175 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn176 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn177 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn178 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn179 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn180 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn181 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn182 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim UltraGridColumn183 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaPropietaria")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroTarjeta")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicial")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFinal")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaPropietaria")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn184 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn185 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidad")
        Dim UltraGridColumn186 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motriz")
        Dim UltraGridColumn187 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim UltraGridColumn188 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim UltraGridColumn189 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn190 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim UltraGridColumn191 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmProyectado")
        Dim UltraGridColumn192 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmMantenimiento")
        Dim UltraGridColumn193 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UltimoMant")
        Dim UltraGridColumn194 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmUltimoServicio")
        Dim UltraGridColumn195 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn196 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaUltimoMant")
        Dim UltraGridColumn197 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroUltimoOT")
        Dim UltraGridColumn198 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProximoMant")
        Dim UltraGridColumn199 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn200 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn201 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadProx")
        Dim UltraGridColumn202 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Diferencia")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Unidad")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motriz")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmProyectado")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmMantenimiento")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UltimoMant")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmUltimoServicio")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horometro")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaUltimoMant")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroUltimoOT")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProximoMant")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadProx")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Diferencia")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Motriz")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloFuncional")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaPropietaria")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaPropietaria")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroEjes")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticos")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Color")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Largo")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ancho")
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Alto")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tara")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cubicaje")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialCombustible")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Odometro")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Horometro")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioFabricacion")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieMotor")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionVehicularMTC")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroNeumaticosRepuesto")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieChasis")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdConfiguracionNeumaticos")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEstado")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlacaAntigua")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ConfiguracionNeumaticos")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CapacidadTanque")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFlota")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndPropiedad")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndProrrateo")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndActivoFijo")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Foto")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioModelo")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModeloSunarp")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCarroceriaSunarp")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoNeumatico")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SuspensionNeumatica")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bonificacion")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TomaFuerza")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modalidad")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TarjetaCombustible")
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEmpresaGPS")
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaAsignada")
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ConductorAsignada")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoNeto")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroAsientos")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroPasajeros")
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroEquipoMovil")
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionDetalle")
        Dim UltraGridColumn203 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdClasificacionISL")
        Dim UltraGridColumn204 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoCarroceria")
        Dim UltraGridColumn205 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionISL")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Motriz")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModeloFuncional")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaPropietaria")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaPropietaria")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroEjes")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroNeumaticos")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Color")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Largo")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ancho")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Alto")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tara")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cubicaje")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialCombustible")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMTC")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Odometro")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Horometro")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnioFabricacion")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerieMotor")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConfiguracionVehicularMTC")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroNeumaticosRepuesto")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerieChasis")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdConfiguracionNeumaticos")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEstado")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlacaAntigua")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ConfiguracionNeumaticos")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CapacidadTanque")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFlota")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndPropiedad")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndProrrateo")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndActivoFijo")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Foto")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnioModelo")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModeloSunarp")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoCarroceriaSunarp")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoNeumatico")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SuspensionNeumatica")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Bonificacion")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TomaFuerza")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modalidad")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TarjetaCombustible")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEmpresaGPS")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RutaAsignada")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ConductorAsignada")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoNeto")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroAsientos")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroPasajeros")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroEquipoMovil")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescripcionDetalle")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdClasificacionISL")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoCarroceria")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClasificacionISL")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Vehiculo))
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("b1")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton("b1")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Unidades")
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroSerieChasis")
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCarroceriaISL")
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ClasificacionISL")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloSunarp")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CarroceriaSunarp")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnioFabricacion")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Color")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoNeumatico")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroEjes")
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SuspensionNeumatica")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Bonificacion")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Propietario")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modalidad")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroLeasing")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorCuota")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TarjetaCombustible")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EmpresaGPS")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaUtil")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoNeto")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoBruto")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ruta")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ResponsableUnidad")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Kilometraje")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroMTC")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CapacidadTanque")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ValorContabilidad")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("EstadoVehiculo", 0)
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn172 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Unidades")
        Dim UltraDataColumn173 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn174 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroSerieChasis")
        Dim UltraDataColumn175 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCarroceriaISL")
        Dim UltraDataColumn176 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ClasificacionISL")
        Dim UltraDataColumn177 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloSunarp")
        Dim UltraDataColumn178 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CarroceriaSunarp")
        Dim UltraDataColumn179 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn180 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnioFabricacion")
        Dim UltraDataColumn181 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Color")
        Dim UltraDataColumn182 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoNeumatico")
        Dim UltraDataColumn183 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroEjes")
        Dim UltraDataColumn184 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SuspensionNeumatica")
        Dim UltraDataColumn185 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Bonificacion")
        Dim UltraDataColumn186 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Propietario")
        Dim UltraDataColumn187 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modalidad")
        Dim UltraDataColumn188 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroLeasing")
        Dim UltraDataColumn189 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorCuota")
        Dim UltraDataColumn190 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn191 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TarjetaCombustible")
        Dim UltraDataColumn192 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("EmpresaGPS")
        Dim UltraDataColumn193 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaUtil")
        Dim UltraDataColumn194 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoNeto")
        Dim UltraDataColumn195 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoBruto")
        Dim UltraDataColumn196 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn197 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ruta")
        Dim UltraDataColumn198 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn199 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn200 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ResponsableUnidad")
        Dim UltraDataColumn201 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Kilometraje")
        Dim UltraDataColumn202 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroMTC")
        Dim UltraDataColumn203 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CapacidadTanque")
        Dim UltraDataColumn204 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ValorContabilidad")
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
        Dim UltraTab13 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab14 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab8 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab15 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab16 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab17 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab18 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab19 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
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
        Dim ValueListItem13 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem14 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem12 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem30 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem31 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem33 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem34 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem15 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem16 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem17 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem18 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem19 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab7 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.tabSeguros = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDocumentoVehicular = New ISL.Controles.Grilla(Me.components)
        Me.ogdDocumentoVehicular = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.tabPlacas = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorialPlaca = New ISL.Controles.Grilla(Me.components)
        Me.ogdPlaca = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspPlacas = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarPlaca = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarPlaca = New System.Windows.Forms.ToolStripButton()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.txtHisPlaca = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fecHisInicio = New System.Windows.Forms.DateTimePicker()
        Me.tabEstados = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griEstados = New ISL.Controles.Grilla(Me.components)
        Me.ogdEstados = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspEstados = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarEstado = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarEstado = New System.Windows.Forms.ToolStripButton()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.cboVehiculoEstado = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtObservacionEstado = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fecInicioEstado = New System.Windows.Forms.DateTimePicker()
        Me.tabDispositivos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griDispositivo = New ISL.Controles.Grilla(Me.components)
        Me.ogdDispositivo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspDispositivos = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarDispositivo = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarDispositivo = New System.Windows.Forms.ToolStripButton()
        Me.agDispositivos = New ISL.Controles.Agrupacion(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fecDispEnicio = New System.Windows.Forms.DateTimePicker()
        Me.txtDispCantidad = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtDispNroSerie = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDispositivo = New ISL.Controles.ComboMaestros(Me.components)
        Me.tabBonificacion = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griBonificacion = New ISL.Controles.Grilla(Me.components)
        Me.ogdBonificacion = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tsbBonificacion = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarBonificacion = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarBonificacion = New System.Windows.Forms.ToolStripButton()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.verBoniIndicador = New ISL.Controles.Chequear(Me.components)
        Me.txtBoniObservacion = New ISL.Controles.Texto(Me.components)
        Me.txtBoniPorcentaje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtBoniNumero = New ISL.Controles.NumeroDecimal(Me.components)
        Me.tabFlota = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAsignacionFlota = New ISL.Controles.Grilla(Me.components)
        Me.ogdAsignacionFlota = New ISL.Controles.OrigenDatos(Me.components)
        Me.tsbFlota = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarFlota = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarFlota = New System.Windows.Forms.ToolStripButton()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.fecInicioAsigFlota = New System.Windows.Forms.DateTimePicker()
        Me.txtObservacionAsigFlota = New ISL.Controles.Texto(Me.components)
        Me.cboAsignacionFlota = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.tabEquipos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griAsignacionEquipos = New ISL.Controles.Grilla(Me.components)
        Me.ogdAsignacionEquipos = New ISL.Controles.OrigenDatos(Me.components)
        Me.tabDocumentos = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.gridControlDoc = New ISL.Controles.Grilla(Me.components)
        Me.odImgDocVeh = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresVencido = New ISL.Controles.Colores(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresPorVencer = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.TabTarjetasCovisol = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griTarjetaCovisol = New ISL.Controles.Grilla(Me.components)
        Me.udsTarjetaCovisol = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tspTarjetasCovisol = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregarTarj = New System.Windows.Forms.ToolStripButton()
        Me.tsbQuitarTarj = New System.Windows.Forms.ToolStripButton()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.cmbCovEmpProp = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.txtCovGlosa = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCovTarjeta = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpCovFecha = New System.Windows.Forms.DateTimePicker()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMantenimiento = New ISL.Controles.Grilla(Me.components)
        Me.udsProyMantenimiento = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.tapVehiculo = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.MenuContextual1 = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdVehiculo = New ISL.Controles.OrigenDatos(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ColorBloque = New ISL.Controles.Colores(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar = New Infragistics.Win.Misc.UltraButton()
        Me.cboFlotaMasiva = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboModeloFuncionalMasivo = New ISL.Controles.ComboMaestros(Me.components)
        Me.expExcesoEnMantenimiento = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Color1Dia = New ISL.Controles.Colores(Me.components)
        Me.Color7DiasAMas = New ISL.Controles.Colores(Me.components)
        Me.Color4a7Dias = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Color2a3Dias = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta53 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnConsultarDisponibles = New Infragistics.Win.Misc.UltraButton()
        Me.UltraExpandableGroupBox4 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ColorDuplicado = New ISL.Controles.Colores(Me.components)
        Me.ColorPrestada = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorPerdida = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorOficina = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores8 = New ISL.Controles.Colores(Me.components)
        Me.Colores7 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores5 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta61 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores6 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta62 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorSiniestrado = New ISL.Controles.Colores(Me.components)
        Me.ColorOperativo = New ISL.Controles.Colores(Me.components)
        Me.ColorVendido = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta52 = New ISL.Controles.Etiqueta(Me.components)
        Me.ColorEnVenta = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta54 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta55 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta51 = New ISL.Controles.Etiqueta(Me.components)
        Me.tapSituacional = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListaSituacional = New ISL.Controles.Grilla(Me.components)
        Me.udsSituacional = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.cboFlotaSituacional = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.gruexEstado = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel9 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.OficinaSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.DuplicadoSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.PrestadaSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.PerdidaSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.PerdidaTotalSit = New ISL.Controles.Colores(Me.components)
        Me.DeBajaSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.OtrosSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta78 = New ISL.Controles.Etiqueta(Me.components)
        Me.AlquiladoSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta79 = New ISL.Controles.Etiqueta(Me.components)
        Me.SiniestradoSit = New ISL.Controles.Colores(Me.components)
        Me.OperativoSit = New ISL.Controles.Colores(Me.components)
        Me.VendidoSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta80 = New ISL.Controles.Etiqueta(Me.components)
        Me.EnVentaSit = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta82 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta83 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta84 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.upbFoto = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.verMotriz = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ndHorometro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.imagenGuardar = New System.Windows.Forms.PictureBox()
        Me.btnDescargarJpg = New ISL.Controles.Boton(Me.components)
        Me.ndOdometro = New ISL.Controles.NumeroDecimal(Me.components)
        Me.btnBorrar = New ISL.Controles.Boton(Me.components)
        Me.txtNroEquipoMovil = New ISL.Controles.Texto(Me.components)
        Me.btnExaminar = New ISL.Controles.Boton(Me.components)
        Me.txtObservacion = New ISL.Controles.Texto(Me.components)
        Me.numAñoModelo = New ISL.Controles.NumeroEntero(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.txtId = New ISL.Controles.Texto(Me.components)
        Me.cboTipoVehiculo = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboModelo = New ISL.Controles.ComboMaestros(Me.components)
        Me.numAñoFabricacion = New ISL.Controles.NumeroEntero(Me.components)
        Me.cboMarca = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboModeloFuncional = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.exgruConsultas = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboEstadoMan = New ISL.Controles.ComboMaestros(Me.components)
        Me.fecPropiedad = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta47 = New ISL.Controles.Etiqueta(Me.components)
        Me.verIndActivoFijo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtPlaca = New ISL.Controles.Texto(Me.components)
        Me.verIndProrrateo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.verIndPropiedad = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtPlacaAntigua = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta41 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboFlota = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.wbrConsultaVehicular = New System.Windows.Forms.WebBrowser()
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.btnObtenerDatos = New System.Windows.Forms.Button()
        Me.btnEnviarPlaca = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cboModeloSunarp = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboPropietario = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txtDescripcionDetalle = New ISL.Controles.Texto(Me.components)
        Me.cboTipoCarroceriaSunarp = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtSerieMotor = New ISL.Controles.Texto(Me.components)
        Me.txtSerieChasis = New ISL.Controles.Texto(Me.components)
        Me.txtColor = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraExpandableGroupBox8 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel8 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.tabs = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage4 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.cboTipoCarroceria = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboClasificacionISL = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta37 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboPilotoAsignado = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Etiqueta77 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboRutaAsignada = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta76 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboModalidad = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta75 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboEmpresaGPS = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cboTomaFuerza = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboBonificacion = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboSuspensionNeumatica = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cboTipoNeumatico = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.Etiqueta69 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta68 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTarjetaCombustible = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta67 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta66 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta65 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta64 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboCombustible = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboConfiguracionGrafica = New ISL.Controles.ComboMaestros(Me.components)
        Me.numNroAsientos = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta45 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.numNroPasajero = New ISL.Controles.Numero(Me.components)
        Me.numLlantasRepuesto = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta46 = New ISL.Controles.Etiqueta(Me.components)
        Me.numCapacidadTanque = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numEjes = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.numAncho = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numRuedas = New ISL.Controles.Numero(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.numLargo = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboConfiguracionMTC = New ISL.Controles.ComboMaestros(Me.components)
        Me.numCargaUtil = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numAltura = New ISL.Controles.NumeroDecimal(Me.components)
        Me.numCubicaje = New ISL.Controles.NumeroDecimal(Me.components)
        Me.txtNroMTC = New ISL.Controles.Texto(Me.components)
        Me.numPesoNeto = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.numTara = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta44 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabLista = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabDatosUnidades = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.Colores1 = New ISL.Controles.Colores(Me.components)
        Me.Colores2 = New ISL.Controles.Colores(Me.components)
        Me.Colores3 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.Colores4 = New ISL.Controles.Colores(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tcVehiculo = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.tabSeguros.SuspendLayout()
        CType(Me.griDocumentoVehicular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDocumentoVehicular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPlacas.SuspendLayout()
        CType(Me.griHistorialPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspPlacas.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.txtHisPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEstados.SuspendLayout()
        CType(Me.griEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspEstados.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cboVehiculoEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDispositivos.SuspendLayout()
        CType(Me.griDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspDispositivos.SuspendLayout()
        CType(Me.agDispositivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agDispositivos.SuspendLayout()
        CType(Me.txtDispCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDispNroSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBonificacion.SuspendLayout()
        CType(Me.griBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbBonificacion.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.verBoniIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoniObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoniPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoniNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFlota.SuspendLayout()
        CType(Me.griAsignacionFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAsignacionFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbFlota.SuspendLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.txtObservacionAsigFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAsignacionFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEquipos.SuspendLayout()
        CType(Me.griAsignacionEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdAsignacionEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDocumentos.SuspendLayout()
        CType(Me.gridControlDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odImgDocVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.ColoresVencido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTarjetasCovisol.SuspendLayout()
        CType(Me.griTarjetaCovisol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsTarjetaCovisol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspTarjetasCovisol.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.cmbCovEmpProp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCovGlosa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCovTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsProyMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapVehiculo.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContextual1.SuspendLayout()
        CType(Me.ogdVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlotaMasiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloFuncionalMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expExcesoEnMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expExcesoEnMantenimiento.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.Color1Dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color7DiasAMas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color4a7Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Color2a3Dias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox4.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.ColorDuplicado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPrestada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPerdida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorOficina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorSiniestrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorOperativo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorVendido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEnVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapSituacional.SuspendLayout()
        CType(Me.griListaSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.cboFlotaSituacional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gruexEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruexEstado.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel9.SuspendLayout()
        CType(Me.OficinaSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DuplicadoSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrestadaSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerdidaSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerdidaTotalSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeBajaSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtrosSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlquiladoSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiniestradoSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OperativoSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendidoSit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnVentaSit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.ndHorometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndOdometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroEquipoMovil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAñoModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAñoFabricacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModeloFuncional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.exgruConsultas.SuspendLayout()
        CType(Me.cboEstadoMan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndActivoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndProrrateo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verIndPropiedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlacaAntigua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFlota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.cboModeloSunarp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCarroceriaSunarp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieChasis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox8.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel8.SuspendLayout()
        CType(Me.tabs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabs.SuspendLayout()
        CType(Me.cboTipoCarroceria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClasificacionISL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPilotoAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRutaAsignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpresaGPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTomaFuerza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBonificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSuspensionNeumatica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoNeumatico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarjetaCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCombustible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConfiguracionGrafica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNroAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNroPasajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLlantasRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCapacidadTanque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEjes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRuedas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboConfiguracionMTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCargaUtil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCubicaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroMTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPesoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLista.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.tabDatosUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatosUnidades.SuspendLayout()
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcVehiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSeguros
        '
        Me.tabSeguros.Controls.Add(Me.griDocumentoVehicular)
        Me.tabSeguros.Location = New System.Drawing.Point(1, 20)
        Me.tabSeguros.Name = "tabSeguros"
        Me.tabSeguros.Size = New System.Drawing.Size(1175, 307)
        '
        'griDocumentoVehicular
        '
        Me.griDocumentoVehicular.DataSource = Me.ogdDocumentoVehicular
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griDocumentoVehicular.DisplayLayout.Appearance = Appearance1
        UltraGridColumn100.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn100.Header.VisiblePosition = 0
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.Header.VisiblePosition = 1
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.Header.VisiblePosition = 2
        UltraGridColumn102.Width = 177
        UltraGridColumn103.Header.VisiblePosition = 3
        UltraGridColumn103.Width = 296
        UltraGridColumn104.Header.VisiblePosition = 4
        UltraGridColumn105.Header.VisiblePosition = 5
        UltraGridColumn106.Header.VisiblePosition = 6
        UltraGridColumn106.Width = 338
        UltraGridColumn107.Header.VisiblePosition = 7
        UltraGridColumn107.Hidden = True
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107})
        Me.griDocumentoVehicular.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griDocumentoVehicular.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDocumentoVehicular.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDocumentoVehicular.DisplayLayout.GroupByBox.Hidden = True
        Me.griDocumentoVehicular.DisplayLayout.MaxColScrollRegions = 1
        Me.griDocumentoVehicular.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDocumentoVehicular.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDocumentoVehicular.DisplayLayout.Override.CellPadding = 0
        Me.griDocumentoVehicular.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDocumentoVehicular.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDocumentoVehicular.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance2.TextHAlignAsString = "Left"
        Me.griDocumentoVehicular.DisplayLayout.Override.HeaderAppearance = Appearance2
        Me.griDocumentoVehicular.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDocumentoVehicular.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance3.TextVAlignAsString = "Middle"
        Me.griDocumentoVehicular.DisplayLayout.Override.RowAppearance = Appearance3
        Me.griDocumentoVehicular.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griDocumentoVehicular.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDocumentoVehicular.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDocumentoVehicular.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDocumentoVehicular.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDocumentoVehicular.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDocumentoVehicular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDocumentoVehicular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDocumentoVehicular.Location = New System.Drawing.Point(0, 0)
        Me.griDocumentoVehicular.Name = "griDocumentoVehicular"
        Me.griDocumentoVehicular.Size = New System.Drawing.Size(1175, 307)
        Me.griDocumentoVehicular.TabIndex = 0
        Me.griDocumentoVehicular.Tag = ""
        Me.griDocumentoVehicular.Text = "GUIAS REMITENTE"
        '
        'ogdDocumentoVehicular
        '
        Me.ogdDocumentoVehicular.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'tabPlacas
        '
        Me.tabPlacas.Controls.Add(Me.griHistorialPlaca)
        Me.tabPlacas.Controls.Add(Me.tspPlacas)
        Me.tabPlacas.Controls.Add(Me.Agrupacion2)
        Me.tabPlacas.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabPlacas.Name = "tabPlacas"
        Me.tabPlacas.Size = New System.Drawing.Size(1175, 307)
        '
        'griHistorialPlaca
        '
        Me.griHistorialPlaca.DataSource = Me.ogdPlaca
        Appearance4.BackColor = System.Drawing.Color.White
        Me.griHistorialPlaca.DisplayLayout.Appearance = Appearance4
        UltraGridColumn108.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn108.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn108.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn108.Header.VisiblePosition = 0
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn109.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn109.Header.Appearance = Appearance5
        UltraGridColumn109.Header.VisiblePosition = 1
        UltraGridColumn109.Width = 90
        UltraGridColumn110.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn110.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn110.Header.VisiblePosition = 2
        UltraGridColumn110.Hidden = True
        UltraGridColumn111.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn111.Header.Caption = "F. Inicio"
        UltraGridColumn111.Header.VisiblePosition = 3
        UltraGridColumn111.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn111.Width = 80
        UltraGridColumn112.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn112.Header.VisiblePosition = 5
        UltraGridColumn112.Hidden = True
        UltraGridColumn113.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn113.Header.VisiblePosition = 4
        UltraGridColumn113.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn113.Width = 40
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113})
        Me.griHistorialPlaca.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griHistorialPlaca.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHistorialPlaca.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griHistorialPlaca.DisplayLayout.GroupByBox.Hidden = True
        Me.griHistorialPlaca.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorialPlaca.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorialPlaca.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griHistorialPlaca.DisplayLayout.Override.CellPadding = 0
        Me.griHistorialPlaca.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHistorialPlaca.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griHistorialPlaca.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance6.TextHAlignAsString = "Left"
        Me.griHistorialPlaca.DisplayLayout.Override.HeaderAppearance = Appearance6
        Me.griHistorialPlaca.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griHistorialPlaca.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance7.TextVAlignAsString = "Middle"
        Me.griHistorialPlaca.DisplayLayout.Override.RowAppearance = Appearance7
        Me.griHistorialPlaca.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griHistorialPlaca.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griHistorialPlaca.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorialPlaca.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griHistorialPlaca.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorialPlaca.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorialPlaca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorialPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorialPlaca.Location = New System.Drawing.Point(0, 64)
        Me.griHistorialPlaca.Name = "griHistorialPlaca"
        Me.griHistorialPlaca.Size = New System.Drawing.Size(1175, 243)
        Me.griHistorialPlaca.TabIndex = 4
        Me.griHistorialPlaca.Tag = ""
        Me.griHistorialPlaca.Text = "GUIAS REMITENTE"
        '
        'ogdPlaca
        '
        UltraDataColumn12.DataType = GetType(Date)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn14.DataType = GetType(Boolean)
        Me.ogdPlaca.Band.Columns.AddRange(New Object() {UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'tspPlacas
        '
        Me.tspPlacas.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspPlacas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarPlaca, Me.tsbQuitarPlaca})
        Me.tspPlacas.Location = New System.Drawing.Point(0, 39)
        Me.tspPlacas.Name = "tspPlacas"
        Me.tspPlacas.Size = New System.Drawing.Size(1175, 25)
        Me.tspPlacas.TabIndex = 7
        Me.tspPlacas.Text = "ToolStrip1"
        '
        'tsbAgregarPlaca
        '
        Me.tsbAgregarPlaca.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarPlaca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarPlaca.Name = "tsbAgregarPlaca"
        Me.tsbAgregarPlaca.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarPlaca.Text = "Agregar (Ins)"
        '
        'tsbQuitarPlaca
        '
        Me.tsbQuitarPlaca.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarPlaca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarPlaca.Name = "tsbQuitarPlaca"
        Me.tsbQuitarPlaca.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarPlaca.Text = "Quitar (Del)"
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.txtHisPlaca)
        Me.Agrupacion2.Controls.Add(Me.Label6)
        Me.Agrupacion2.Controls.Add(Me.Label5)
        Me.Agrupacion2.Controls.Add(Me.fecHisInicio)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1175, 39)
        Me.Agrupacion2.TabIndex = 2
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'txtHisPlaca
        '
        Me.txtHisPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHisPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtHisPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHisPlaca.Location = New System.Drawing.Point(43, 8)
        Me.txtHisPlaca.MaxLength = 9
        Me.txtHisPlaca.Name = "txtHisPlaca"
        Me.txtHisPlaca.Size = New System.Drawing.Size(113, 22)
        Me.txtHisPlaca.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(174, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Fecha Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Placa:"
        '
        'fecHisInicio
        '
        Me.fecHisInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHisInicio.Location = New System.Drawing.Point(242, 9)
        Me.fecHisInicio.Name = "fecHisInicio"
        Me.fecHisInicio.Size = New System.Drawing.Size(100, 21)
        Me.fecHisInicio.TabIndex = 2
        '
        'tabEstados
        '
        Me.tabEstados.Controls.Add(Me.griEstados)
        Me.tabEstados.Controls.Add(Me.tspEstados)
        Me.tabEstados.Controls.Add(Me.Agrupacion4)
        Me.tabEstados.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabEstados.Name = "tabEstados"
        Me.tabEstados.Size = New System.Drawing.Size(1175, 307)
        '
        'griEstados
        '
        Me.griEstados.DataSource = Me.ogdEstados
        Appearance8.BackColor = System.Drawing.Color.White
        Me.griEstados.DisplayLayout.Appearance = Appearance8
        UltraGridColumn159.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn159.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn159.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn159.Header.VisiblePosition = 0
        UltraGridColumn159.Hidden = True
        UltraGridColumn160.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn160.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn160.Header.VisiblePosition = 1
        UltraGridColumn160.Hidden = True
        UltraGridColumn161.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn161.CellAppearance = Appearance9
        UltraGridColumn161.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn161.Header.Caption = "Estado"
        UltraGridColumn161.Header.VisiblePosition = 2
        UltraGridColumn161.Width = 46
        UltraGridColumn162.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn162.Header.VisiblePosition = 7
        UltraGridColumn162.Width = 250
        UltraGridColumn163.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn163.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn163.Header.Caption = "Fecha Inicio"
        UltraGridColumn163.Header.VisiblePosition = 3
        UltraGridColumn163.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn163.Width = 90
        UltraGridColumn164.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn164.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn164.Header.Caption = "Fecha Fin"
        UltraGridColumn164.Header.VisiblePosition = 4
        UltraGridColumn164.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn164.Width = 90
        UltraGridColumn165.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn165.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn165.Header.VisiblePosition = 5
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn166.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn166.Header.VisiblePosition = 6
        UltraGridColumn166.Hidden = True
        UltraGridColumn167.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn167.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn167.Header.VisiblePosition = 8
        UltraGridColumn167.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn167.Width = 40
        UltraGridColumn168.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn168.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn168.Header.VisiblePosition = 9
        UltraGridColumn168.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168})
        Me.griEstados.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griEstados.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griEstados.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griEstados.DisplayLayout.GroupByBox.Hidden = True
        Me.griEstados.DisplayLayout.MaxColScrollRegions = 1
        Me.griEstados.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griEstados.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griEstados.DisplayLayout.Override.CellPadding = 0
        Me.griEstados.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griEstados.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griEstados.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.TextHAlignAsString = "Left"
        Me.griEstados.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.griEstados.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griEstados.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance11.TextVAlignAsString = "Middle"
        Me.griEstados.DisplayLayout.Override.RowAppearance = Appearance11
        Me.griEstados.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griEstados.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griEstados.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griEstados.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griEstados.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griEstados.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griEstados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griEstados.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griEstados.Location = New System.Drawing.Point(0, 86)
        Me.griEstados.Name = "griEstados"
        Me.griEstados.Size = New System.Drawing.Size(1175, 221)
        Me.griEstados.TabIndex = 5
        Me.griEstados.Tag = ""
        '
        'ogdEstados
        '
        UltraDataColumn17.DataType = GetType(UInteger)
        UltraDataColumn19.DataType = GetType(Date)
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn22.DataType = GetType(Date)
        UltraDataColumn23.DataType = GetType(Boolean)
        UltraDataColumn24.DataType = GetType(Boolean)
        Me.ogdEstados.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'tspEstados
        '
        Me.tspEstados.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspEstados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarEstado, Me.tsbQuitarEstado})
        Me.tspEstados.Location = New System.Drawing.Point(0, 61)
        Me.tspEstados.Name = "tspEstados"
        Me.tspEstados.Size = New System.Drawing.Size(1175, 25)
        Me.tspEstados.TabIndex = 7
        Me.tspEstados.Text = "ToolStrip1"
        '
        'tsbAgregarEstado
        '
        Me.tsbAgregarEstado.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarEstado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarEstado.Name = "tsbAgregarEstado"
        Me.tsbAgregarEstado.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarEstado.Text = "Agregar (Ins)"
        '
        'tsbQuitarEstado
        '
        Me.tsbQuitarEstado.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarEstado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarEstado.Name = "tsbQuitarEstado"
        Me.tsbQuitarEstado.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarEstado.Text = "Quitar (Del)"
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.cboVehiculoEstado)
        Me.Agrupacion4.Controls.Add(Me.txtObservacionEstado)
        Me.Agrupacion4.Controls.Add(Me.Label9)
        Me.Agrupacion4.Controls.Add(Me.Label8)
        Me.Agrupacion4.Controls.Add(Me.Label7)
        Me.Agrupacion4.Controls.Add(Me.fecInicioEstado)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(1175, 61)
        Me.Agrupacion4.TabIndex = 3
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboVehiculoEstado
        '
        Appearance12.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoEstado.Appearance = Appearance12
        Me.cboVehiculoEstado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboVehiculoEstado.DisplayMember = "Nombre"
        Me.cboVehiculoEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculoEstado.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboVehiculoEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculoEstado.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoEstado.Location = New System.Drawing.Point(84, 6)
        Me.cboVehiculoEstado.Name = "cboVehiculoEstado"
        Me.cboVehiculoEstado.Size = New System.Drawing.Size(247, 21)
        Me.cboVehiculoEstado.TabIndex = 345
        Me.cboVehiculoEstado.ValueMember = "Id"
        '
        'txtObservacionEstado
        '
        Me.txtObservacionEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionEstado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionEstado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionEstado.Location = New System.Drawing.Point(647, 8)
        Me.txtObservacionEstado.MaxLength = 300
        Me.txtObservacionEstado.Multiline = True
        Me.txtObservacionEstado.Name = "txtObservacionEstado"
        Me.txtObservacionEstado.Size = New System.Drawing.Size(331, 45)
        Me.txtObservacionEstado.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(10, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 344
        Me.Label9.Text = "Fecha Inicio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(577, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 343
        Me.Label8.Text = "Observación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(35, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 342
        Me.Label7.Text = "Estado:"
        '
        'fecInicioEstado
        '
        Me.fecInicioEstado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicioEstado.Location = New System.Drawing.Point(84, 34)
        Me.fecInicioEstado.Name = "fecInicioEstado"
        Me.fecInicioEstado.Size = New System.Drawing.Size(100, 20)
        Me.fecInicioEstado.TabIndex = 2
        '
        'tabDispositivos
        '
        Me.tabDispositivos.Controls.Add(Me.griDispositivo)
        Me.tabDispositivos.Controls.Add(Me.tspDispositivos)
        Me.tabDispositivos.Controls.Add(Me.agDispositivos)
        Me.tabDispositivos.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabDispositivos.Name = "tabDispositivos"
        Me.tabDispositivos.Size = New System.Drawing.Size(1175, 307)
        '
        'griDispositivo
        '
        Me.griDispositivo.DataSource = Me.ogdDispositivo
        Appearance13.BackColor = System.Drawing.Color.White
        Me.griDispositivo.DisplayLayout.Appearance = Appearance13
        UltraGridColumn114.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn114.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn114.Header.VisiblePosition = 0
        UltraGridColumn114.Hidden = True
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn115.Header.Appearance = Appearance14
        UltraGridColumn115.Header.Caption = "TipoDispositivo"
        UltraGridColumn115.Header.VisiblePosition = 1
        UltraGridColumn115.Width = 100
        UltraGridColumn116.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn116.Header.VisiblePosition = 2
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn117.Header.VisiblePosition = 3
        UltraGridColumn117.Width = 90
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn118.CellAppearance = Appearance15
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn118.Header.VisiblePosition = 6
        UltraGridColumn118.MaskInput = "{LOC}nnnnnnnnnnnn.nnn"
        UltraGridColumn118.Width = 110
        UltraGridColumn119.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn119.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn119.Header.Caption = "F. Inicio"
        UltraGridColumn119.Header.VisiblePosition = 4
        UltraGridColumn119.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn119.Width = 80
        UltraGridColumn120.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn120.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn120.Header.Caption = "F. UltimaAct"
        UltraGridColumn120.Header.VisiblePosition = 5
        UltraGridColumn120.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn120.Width = 80
        UltraGridColumn121.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn121.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn121.Header.VisiblePosition = 8
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn122.Header.VisiblePosition = 7
        UltraGridColumn122.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn122.Width = 40
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122})
        Me.griDispositivo.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griDispositivo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griDispositivo.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griDispositivo.DisplayLayout.GroupByBox.Hidden = True
        Me.griDispositivo.DisplayLayout.MaxColScrollRegions = 1
        Me.griDispositivo.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griDispositivo.DisplayLayout.Override.CellPadding = 0
        Me.griDispositivo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griDispositivo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griDispositivo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance16.TextHAlignAsString = "Left"
        Me.griDispositivo.DisplayLayout.Override.HeaderAppearance = Appearance16
        Me.griDispositivo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griDispositivo.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance17.TextVAlignAsString = "Middle"
        Me.griDispositivo.DisplayLayout.Override.RowAppearance = Appearance17
        Me.griDispositivo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griDispositivo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griDispositivo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griDispositivo.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griDispositivo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griDispositivo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griDispositivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griDispositivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griDispositivo.Location = New System.Drawing.Point(0, 65)
        Me.griDispositivo.Name = "griDispositivo"
        Me.griDispositivo.Size = New System.Drawing.Size(1175, 242)
        Me.griDispositivo.TabIndex = 8
        Me.griDispositivo.Tag = ""
        '
        'ogdDispositivo
        '
        UltraDataColumn29.DataType = GetType(Double)
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn31.DataType = GetType(Date)
        UltraDataColumn32.DataType = GetType(Boolean)
        UltraDataColumn33.DataType = GetType(Boolean)
        Me.ogdDispositivo.Band.Columns.AddRange(New Object() {UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33})
        '
        'tspDispositivos
        '
        Me.tspDispositivos.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspDispositivos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarDispositivo, Me.tsbQuitarDispositivo})
        Me.tspDispositivos.Location = New System.Drawing.Point(0, 40)
        Me.tspDispositivos.Name = "tspDispositivos"
        Me.tspDispositivos.Size = New System.Drawing.Size(1175, 25)
        Me.tspDispositivos.TabIndex = 9
        Me.tspDispositivos.Text = "ToolStrip1"
        '
        'tsbAgregarDispositivo
        '
        Me.tsbAgregarDispositivo.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarDispositivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarDispositivo.Name = "tsbAgregarDispositivo"
        Me.tsbAgregarDispositivo.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarDispositivo.Text = "Agregar (Ins)"
        '
        'tsbQuitarDispositivo
        '
        Me.tsbQuitarDispositivo.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarDispositivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarDispositivo.Name = "tsbQuitarDispositivo"
        Me.tsbQuitarDispositivo.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarDispositivo.Text = "Quitar (Del)"
        '
        'agDispositivos
        '
        Me.agDispositivos.Controls.Add(Me.Label14)
        Me.agDispositivos.Controls.Add(Me.Label13)
        Me.agDispositivos.Controls.Add(Me.Label12)
        Me.agDispositivos.Controls.Add(Me.Label11)
        Me.agDispositivos.Controls.Add(Me.fecDispEnicio)
        Me.agDispositivos.Controls.Add(Me.txtDispCantidad)
        Me.agDispositivos.Controls.Add(Me.txtDispNroSerie)
        Me.agDispositivos.Controls.Add(Me.cboTipoDispositivo)
        Me.agDispositivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.agDispositivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agDispositivos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agDispositivos.Location = New System.Drawing.Point(0, 0)
        Me.agDispositivos.Name = "agDispositivos"
        Me.agDispositivos.Size = New System.Drawing.Size(1175, 40)
        Me.agDispositivos.TabIndex = 0
        Me.agDispositivos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(213, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 248
        Me.Label14.Text = "N° Serie:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(379, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 247
        Me.Label13.Text = "Cantidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(537, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 246
        Me.Label12.Text = "Fecha Inicio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(3, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 245
        Me.Label11.Text = "Tipo:"
        '
        'fecDispEnicio
        '
        Me.fecDispEnicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDispEnicio.Location = New System.Drawing.Point(608, 9)
        Me.fecDispEnicio.Name = "fecDispEnicio"
        Me.fecDispEnicio.Size = New System.Drawing.Size(100, 20)
        Me.fecDispEnicio.TabIndex = 4
        '
        'txtDispCantidad
        '
        Appearance18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDispCantidad.Appearance = Appearance18
        Me.txtDispCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDispCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispCantidad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDispCantidad.Location = New System.Drawing.Point(433, 8)
        Me.txtDispCantidad.MaskInput = "{LOC}nnnnnnnn.nnn"
        Me.txtDispCantidad.Name = "txtDispCantidad"
        Me.txtDispCantidad.NullText = "0.00"
        Me.txtDispCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtDispCantidad.Size = New System.Drawing.Size(84, 21)
        Me.txtDispCantidad.TabIndex = 3
        '
        'txtDispNroSerie
        '
        Appearance19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDispNroSerie.Appearance = Appearance19
        Me.txtDispNroSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDispNroSerie.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDispNroSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispNroSerie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDispNroSerie.Location = New System.Drawing.Point(262, 8)
        Me.txtDispNroSerie.MaxLength = 10
        Me.txtDispNroSerie.Name = "txtDispNroSerie"
        Me.txtDispNroSerie.Size = New System.Drawing.Size(98, 21)
        Me.txtDispNroSerie.TabIndex = 2
        '
        'cboTipoDispositivo
        '
        Appearance20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDispositivo.Appearance = Appearance20
        Me.cboTipoDispositivo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoDispositivo.DisplayMember = "Nombre"
        Me.cboTipoDispositivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDispositivo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDispositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDispositivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoDispositivo.Location = New System.Drawing.Point(34, 8)
        Me.cboTipoDispositivo.Name = "cboTipoDispositivo"
        Me.cboTipoDispositivo.Size = New System.Drawing.Size(169, 21)
        Me.cboTipoDispositivo.TabIndex = 1
        Me.cboTipoDispositivo.ValueMember = "Id"
        '
        'tabBonificacion
        '
        Me.tabBonificacion.Controls.Add(Me.griBonificacion)
        Me.tabBonificacion.Controls.Add(Me.tsbBonificacion)
        Me.tabBonificacion.Controls.Add(Me.ugb_Espera)
        Me.tabBonificacion.Controls.Add(Me.Agrupacion1)
        Me.tabBonificacion.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabBonificacion.Name = "tabBonificacion"
        Me.tabBonificacion.Size = New System.Drawing.Size(1175, 307)
        '
        'griBonificacion
        '
        Me.griBonificacion.DataSource = Me.ogdBonificacion
        Appearance21.BackColor = System.Drawing.Color.White
        Me.griBonificacion.DisplayLayout.Appearance = Appearance21
        UltraGridColumn123.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn123.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn123.Header.VisiblePosition = 0
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn124.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn124.Header.VisiblePosition = 1
        UltraGridColumn124.Hidden = True
        Appearance22.TextHAlignAsString = "Right"
        UltraGridColumn125.CellAppearance = Appearance22
        UltraGridColumn125.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance23.TextHAlignAsString = "Right"
        UltraGridColumn125.Header.Appearance = Appearance23
        UltraGridColumn125.Header.VisiblePosition = 2
        UltraGridColumn125.MaskInput = "nnnnnnn"
        UltraGridColumn125.Width = 50
        Appearance24.TextHAlignAsString = "Right"
        UltraGridColumn126.CellAppearance = Appearance24
        UltraGridColumn126.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn126.Header.Caption = "%"
        UltraGridColumn126.Header.VisiblePosition = 3
        UltraGridColumn126.MaskInput = "nn"
        UltraGridColumn126.Width = 30
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn127.Header.Caption = "Bonif."
        UltraGridColumn127.Header.VisiblePosition = 4
        UltraGridColumn127.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn127.Width = 37
        UltraGridColumn128.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn128.Header.VisiblePosition = 5
        UltraGridColumn128.Width = 418
        UltraGridColumn129.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn129.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn129.Header.VisiblePosition = 6
        UltraGridColumn129.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129})
        Me.griBonificacion.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griBonificacion.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griBonificacion.DisplayLayout.ColScrollRegions.Add(ColScrollRegion1)
        Me.griBonificacion.DisplayLayout.ColScrollRegions.Add(ColScrollRegion2)
        Me.griBonificacion.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griBonificacion.DisplayLayout.GroupByBox.Hidden = True
        Me.griBonificacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griBonificacion.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griBonificacion.DisplayLayout.Override.CellPadding = 0
        Me.griBonificacion.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griBonificacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griBonificacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance25.TextHAlignAsString = "Left"
        Me.griBonificacion.DisplayLayout.Override.HeaderAppearance = Appearance25
        Me.griBonificacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griBonificacion.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance26.TextVAlignAsString = "Middle"
        Me.griBonificacion.DisplayLayout.Override.RowAppearance = Appearance26
        Me.griBonificacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griBonificacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griBonificacion.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griBonificacion.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griBonificacion.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griBonificacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griBonificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griBonificacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griBonificacion.Location = New System.Drawing.Point(0, 61)
        Me.griBonificacion.Name = "griBonificacion"
        Me.griBonificacion.Size = New System.Drawing.Size(1175, 246)
        Me.griBonificacion.TabIndex = 10
        Me.griBonificacion.Tag = ""
        '
        'ogdBonificacion
        '
        UltraDataColumn36.DataType = GetType(Long)
        UltraDataColumn37.DataType = GetType(Integer)
        UltraDataColumn38.DataType = GetType(Boolean)
        UltraDataColumn40.DataType = GetType(Boolean)
        Me.ogdBonificacion.Band.Columns.AddRange(New Object() {UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40})
        '
        'tsbBonificacion
        '
        Me.tsbBonificacion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tsbBonificacion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarBonificacion, Me.tsbQuitarBonificacion})
        Me.tsbBonificacion.Location = New System.Drawing.Point(0, 36)
        Me.tsbBonificacion.Name = "tsbBonificacion"
        Me.tsbBonificacion.Size = New System.Drawing.Size(1175, 25)
        Me.tsbBonificacion.TabIndex = 11
        Me.tsbBonificacion.Text = "ToolStrip1"
        '
        'tsbAgregarBonificacion
        '
        Me.tsbAgregarBonificacion.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarBonificacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarBonificacion.Name = "tsbAgregarBonificacion"
        Me.tsbAgregarBonificacion.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarBonificacion.Text = "Agregar (Ins)"
        '
        'tsbQuitarBonificacion
        '
        Me.tsbQuitarBonificacion.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarBonificacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarBonificacion.Name = "tsbQuitarBonificacion"
        Me.tsbQuitarBonificacion.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarBonificacion.Text = "Quitar (Del)"
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(447, 88)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(400, 70)
        Me.ugb_Espera.TabIndex = 1
        Me.ugb_Espera.Visible = False
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Label17)
        Me.Agrupacion1.Controls.Add(Me.Label16)
        Me.Agrupacion1.Controls.Add(Me.Label15)
        Me.Agrupacion1.Controls.Add(Me.verBoniIndicador)
        Me.Agrupacion1.Controls.Add(Me.txtBoniObservacion)
        Me.Agrupacion1.Controls.Add(Me.txtBoniPorcentaje)
        Me.Agrupacion1.Controls.Add(Me.txtBoniNumero)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1175, 36)
        Me.Agrupacion1.TabIndex = 9
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(381, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 250
        Me.Label17.Text = "Observación:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(153, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 249
        Me.Label16.Text = "Porcentaje:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(9, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 248
        Me.Label15.Text = "Numero:"
        '
        'verBoniIndicador
        '
        Me.verBoniIndicador.AutoSize = True
        Me.verBoniIndicador.BackColor = System.Drawing.Color.Transparent
        Me.verBoniIndicador.BackColorInternal = System.Drawing.Color.Transparent
        Me.verBoniIndicador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verBoniIndicador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verBoniIndicador.Location = New System.Drawing.Point(280, 9)
        Me.verBoniIndicador.Name = "verBoniIndicador"
        Me.verBoniIndicador.Size = New System.Drawing.Size(80, 17)
        Me.verBoniIndicador.TabIndex = 3
        Me.verBoniIndicador.Text = "Bonificacion"
        '
        'txtBoniObservacion
        '
        Appearance27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniObservacion.Appearance = Appearance27
        Me.txtBoniObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBoniObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBoniObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoniObservacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniObservacion.Location = New System.Drawing.Point(452, 6)
        Me.txtBoniObservacion.Name = "txtBoniObservacion"
        Me.txtBoniObservacion.Size = New System.Drawing.Size(460, 20)
        Me.txtBoniObservacion.TabIndex = 4
        '
        'txtBoniPorcentaje
        '
        Appearance28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniPorcentaje.Appearance = Appearance28
        Me.txtBoniPorcentaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBoniPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoniPorcentaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniPorcentaje.Location = New System.Drawing.Point(214, 5)
        Me.txtBoniPorcentaje.MaskInput = "nn"
        Me.txtBoniPorcentaje.Name = "txtBoniPorcentaje"
        Me.txtBoniPorcentaje.NullText = "0.00"
        Me.txtBoniPorcentaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtBoniPorcentaje.Size = New System.Drawing.Size(39, 21)
        Me.txtBoniPorcentaje.TabIndex = 2
        '
        'txtBoniNumero
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniNumero.Appearance = Appearance29
        Me.txtBoniNumero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtBoniNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoniNumero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtBoniNumero.Location = New System.Drawing.Point(56, 5)
        Me.txtBoniNumero.MaskInput = "nnnnnnn"
        Me.txtBoniNumero.Name = "txtBoniNumero"
        Me.txtBoniNumero.NullText = "0.00"
        Me.txtBoniNumero.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtBoniNumero.Size = New System.Drawing.Size(73, 21)
        Me.txtBoniNumero.TabIndex = 1
        '
        'tabFlota
        '
        Me.tabFlota.Controls.Add(Me.griAsignacionFlota)
        Me.tabFlota.Controls.Add(Me.tsbFlota)
        Me.tabFlota.Controls.Add(Me.Agrupacion3)
        Me.tabFlota.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabFlota.Name = "tabFlota"
        Me.tabFlota.Size = New System.Drawing.Size(1175, 307)
        '
        'griAsignacionFlota
        '
        Me.griAsignacionFlota.DataSource = Me.ogdAsignacionFlota
        Appearance30.BackColor = System.Drawing.Color.White
        Me.griAsignacionFlota.DisplayLayout.Appearance = Appearance30
        UltraGridColumn130.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn130.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn130.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn130.Header.VisiblePosition = 0
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn131.Header.VisiblePosition = 1
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn132.Header.Caption = "Flota Asignada"
        UltraGridColumn132.Header.VisiblePosition = 2
        UltraGridColumn132.Width = 120
        UltraGridColumn133.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn133.Header.VisiblePosition = 5
        UltraGridColumn133.Width = 300
        UltraGridColumn134.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn134.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn134.Header.Caption = "Fecha Inicio"
        UltraGridColumn134.Header.VisiblePosition = 3
        UltraGridColumn134.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn134.Width = 80
        UltraGridColumn135.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn135.Header.Caption = "Fecha Fin"
        UltraGridColumn135.Header.VisiblePosition = 4
        UltraGridColumn135.Width = 82
        UltraGridColumn136.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn136.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn136.Header.VisiblePosition = 6
        UltraGridColumn136.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn136.Width = 40
        UltraGridColumn137.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn137.Header.VisiblePosition = 7
        UltraGridColumn137.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137})
        Me.griAsignacionFlota.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griAsignacionFlota.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAsignacionFlota.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griAsignacionFlota.DisplayLayout.GroupByBox.Hidden = True
        Me.griAsignacionFlota.DisplayLayout.MaxColScrollRegions = 1
        Me.griAsignacionFlota.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAsignacionFlota.DisplayLayout.Override.CellPadding = 0
        Me.griAsignacionFlota.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAsignacionFlota.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAsignacionFlota.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance31.TextHAlignAsString = "Left"
        Me.griAsignacionFlota.DisplayLayout.Override.HeaderAppearance = Appearance31
        Me.griAsignacionFlota.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAsignacionFlota.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance32.TextVAlignAsString = "Middle"
        Me.griAsignacionFlota.DisplayLayout.Override.RowAppearance = Appearance32
        Me.griAsignacionFlota.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griAsignacionFlota.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griAsignacionFlota.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAsignacionFlota.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griAsignacionFlota.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAsignacionFlota.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAsignacionFlota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAsignacionFlota.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAsignacionFlota.Location = New System.Drawing.Point(0, 62)
        Me.griAsignacionFlota.Name = "griAsignacionFlota"
        Me.griAsignacionFlota.Size = New System.Drawing.Size(1175, 245)
        Me.griAsignacionFlota.TabIndex = 10
        Me.griAsignacionFlota.Tag = ""
        '
        'ogdAsignacionFlota
        '
        UltraDataColumn45.DataType = GetType(Date)
        UltraDataColumn46.DataType = GetType(Date)
        UltraDataColumn47.DataType = GetType(Boolean)
        UltraDataColumn48.DataType = GetType(Boolean)
        Me.ogdAsignacionFlota.Band.Columns.AddRange(New Object() {UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48})
        '
        'tsbFlota
        '
        Me.tsbFlota.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tsbFlota.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarFlota, Me.tsbQuitarFlota})
        Me.tsbFlota.Location = New System.Drawing.Point(0, 37)
        Me.tsbFlota.Name = "tsbFlota"
        Me.tsbFlota.Size = New System.Drawing.Size(1175, 25)
        Me.tsbFlota.TabIndex = 11
        Me.tsbFlota.Text = "ToolStrip1"
        '
        'tsbAgregarFlota
        '
        Me.tsbAgregarFlota.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarFlota.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarFlota.Name = "tsbAgregarFlota"
        Me.tsbAgregarFlota.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarFlota.Text = "Agregar (Ins)"
        '
        'tsbQuitarFlota
        '
        Me.tsbQuitarFlota.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarFlota.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarFlota.Name = "tsbQuitarFlota"
        Me.tsbQuitarFlota.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarFlota.Text = "Quitar (Del)"
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.Label37)
        Me.Agrupacion3.Controls.Add(Me.Label18)
        Me.Agrupacion3.Controls.Add(Me.fecInicioAsigFlota)
        Me.Agrupacion3.Controls.Add(Me.txtObservacionAsigFlota)
        Me.Agrupacion3.Controls.Add(Me.cboAsignacionFlota)
        Me.Agrupacion3.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(1175, 37)
        Me.Agrupacion3.TabIndex = 9
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(451, 11)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 13)
        Me.Label37.TabIndex = 251
        Me.Label37.Text = "Observación:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(269, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 250
        Me.Label18.Text = "Fecha Inicio:"
        '
        'fecInicioAsigFlota
        '
        Me.fecInicioAsigFlota.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecInicioAsigFlota.Location = New System.Drawing.Point(337, 8)
        Me.fecInicioAsigFlota.Name = "fecInicioAsigFlota"
        Me.fecInicioAsigFlota.Size = New System.Drawing.Size(100, 20)
        Me.fecInicioAsigFlota.TabIndex = 2
        '
        'txtObservacionAsigFlota
        '
        Appearance33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAsigFlota.Appearance = Appearance33
        Me.txtObservacionAsigFlota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacionAsigFlota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionAsigFlota.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionAsigFlota.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacionAsigFlota.Location = New System.Drawing.Point(521, 8)
        Me.txtObservacionAsigFlota.MaxLength = 500
        Me.txtObservacionAsigFlota.Name = "txtObservacionAsigFlota"
        Me.txtObservacionAsigFlota.Size = New System.Drawing.Size(422, 20)
        Me.txtObservacionAsigFlota.TabIndex = 3
        '
        'cboAsignacionFlota
        '
        Appearance34.ForeColor = System.Drawing.Color.Black
        Me.cboAsignacionFlota.Appearance = Appearance34
        Me.cboAsignacionFlota.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboAsignacionFlota.DisplayMember = "Nombre"
        Me.cboAsignacionFlota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboAsignacionFlota.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboAsignacionFlota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAsignacionFlota.ForeColor = System.Drawing.Color.Black
        Me.cboAsignacionFlota.Location = New System.Drawing.Point(44, 7)
        Me.cboAsignacionFlota.Name = "cboAsignacionFlota"
        Me.cboAsignacionFlota.Size = New System.Drawing.Size(200, 21)
        Me.cboAsignacionFlota.TabIndex = 1
        Me.cboAsignacionFlota.ValueMember = "Id"
        '
        'UltraLabel1
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance35
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(10, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(32, 14)
        Me.UltraLabel1.TabIndex = 244
        Me.UltraLabel1.Text = "Flota:"
        '
        'tabEquipos
        '
        Me.tabEquipos.Controls.Add(Me.griAsignacionEquipos)
        Me.tabEquipos.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabEquipos.Name = "tabEquipos"
        Me.tabEquipos.Size = New System.Drawing.Size(1175, 307)
        '
        'griAsignacionEquipos
        '
        Me.griAsignacionEquipos.DataSource = Me.ogdAsignacionEquipos
        Appearance36.BackColor = System.Drawing.Color.White
        Me.griAsignacionEquipos.DisplayLayout.Appearance = Appearance36
        UltraGridColumn138.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn138.Header.VisiblePosition = 0
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 1
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.Caption = "Material"
        UltraGridColumn140.Header.VisiblePosition = 2
        UltraGridColumn140.Width = 223
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn141.Header.VisiblePosition = 4
        UltraGridColumn141.Width = 300
        UltraGridColumn142.Header.VisiblePosition = 3
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn143.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn143.Width = 40
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143})
        Me.griAsignacionEquipos.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griAsignacionEquipos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAsignacionEquipos.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griAsignacionEquipos.DisplayLayout.GroupByBox.Hidden = True
        Me.griAsignacionEquipos.DisplayLayout.MaxColScrollRegions = 1
        Me.griAsignacionEquipos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griAsignacionEquipos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griAsignacionEquipos.DisplayLayout.Override.CellPadding = 0
        Me.griAsignacionEquipos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griAsignacionEquipos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griAsignacionEquipos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance37.TextHAlignAsString = "Left"
        Me.griAsignacionEquipos.DisplayLayout.Override.HeaderAppearance = Appearance37
        Me.griAsignacionEquipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griAsignacionEquipos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance38.TextVAlignAsString = "Middle"
        Me.griAsignacionEquipos.DisplayLayout.Override.RowAppearance = Appearance38
        Me.griAsignacionEquipos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griAsignacionEquipos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griAsignacionEquipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griAsignacionEquipos.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griAsignacionEquipos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griAsignacionEquipos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griAsignacionEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griAsignacionEquipos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griAsignacionEquipos.Location = New System.Drawing.Point(0, 0)
        Me.griAsignacionEquipos.Name = "griAsignacionEquipos"
        Me.griAsignacionEquipos.Size = New System.Drawing.Size(1175, 307)
        Me.griAsignacionEquipos.TabIndex = 12
        Me.griAsignacionEquipos.Tag = ""
        Me.griAsignacionEquipos.Text = "GUIAS REMITENTE"
        '
        'ogdAsignacionEquipos
        '
        UltraDataColumn53.DataType = GetType(Date)
        UltraDataColumn54.DataType = GetType(Boolean)
        Me.ogdAsignacionEquipos.Band.Columns.AddRange(New Object() {UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54})
        '
        'tabDocumentos
        '
        Me.tabDocumentos.Controls.Add(Me.gridControlDoc)
        Me.tabDocumentos.Controls.Add(Me.UltraGroupBox1)
        Me.tabDocumentos.Location = New System.Drawing.Point(-10000, -10000)
        Me.tabDocumentos.Name = "tabDocumentos"
        Me.tabDocumentos.Size = New System.Drawing.Size(1175, 307)
        '
        'gridControlDoc
        '
        Me.gridControlDoc.DataSource = Me.odImgDocVeh
        UltraGridColumn144.Header.VisiblePosition = 0
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 1
        UltraGridColumn145.Width = 100
        UltraGridColumn146.Header.VisiblePosition = 2
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance39.TextVAlignAsString = "Middle"
        UltraGridColumn147.CellAppearance = Appearance39
        UltraGridColumn147.Header.VisiblePosition = 3
        UltraGridColumn147.Hidden = True
        UltraGridColumn147.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn147.Width = 80
        UltraGridColumn148.Header.VisiblePosition = 4
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.Header.VisiblePosition = 5
        UltraGridColumn149.Width = 347
        UltraGridColumn150.Header.VisiblePosition = 6
        UltraGridColumn150.Width = 194
        UltraGridColumn151.Header.VisiblePosition = 9
        UltraGridColumn151.Hidden = True
        UltraGridColumn152.Header.VisiblePosition = 7
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 8
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 10
        UltraGridColumn154.Hidden = True
        UltraGridColumn155.Header.VisiblePosition = 11
        UltraGridColumn155.Hidden = True
        Appearance40.TextHAlignAsString = "Left"
        UltraGridColumn156.CellAppearance = Appearance40
        UltraGridColumn156.Header.VisiblePosition = 12
        UltraGridColumn156.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn157.CellAppearance = Appearance41
        UltraGridColumn157.Header.VisiblePosition = 13
        UltraGridColumn157.Width = 67
        UltraGridColumn158.Header.VisiblePosition = 14
        UltraGridColumn158.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158})
        Me.gridControlDoc.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.gridControlDoc.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance42.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance42.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance42.BorderColor = System.Drawing.SystemColors.Window
        Me.gridControlDoc.DisplayLayout.GroupByBox.Appearance = Appearance42
        Appearance43.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridControlDoc.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance43
        Me.gridControlDoc.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridControlDoc.DisplayLayout.GroupByBox.Hidden = True
        Appearance44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance44.BackColor2 = System.Drawing.SystemColors.Control
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance44.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridControlDoc.DisplayLayout.GroupByBox.PromptAppearance = Appearance44
        Me.gridControlDoc.DisplayLayout.MaxColScrollRegions = 1
        Me.gridControlDoc.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridControlDoc.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.gridControlDoc.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridControlDoc.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridControlDoc.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.gridControlDoc.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance45.BorderColor = System.Drawing.Color.Silver
        Me.gridControlDoc.DisplayLayout.Override.CellAppearance = Appearance45
        Me.gridControlDoc.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridControlDoc.DisplayLayout.Override.CellPadding = 0
        Me.gridControlDoc.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridControlDoc.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridControlDoc.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.gridControlDoc.DisplayLayout.Override.GroupByRowAppearance = Appearance46
        Appearance47.TextHAlignAsString = "Left"
        Me.gridControlDoc.DisplayLayout.Override.HeaderAppearance = Appearance47
        Me.gridControlDoc.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance48.BorderColor = System.Drawing.Color.Silver
        Me.gridControlDoc.DisplayLayout.Override.RowAppearance = Appearance48
        Me.gridControlDoc.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridControlDoc.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridControlDoc.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.gridControlDoc.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridControlDoc.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.gridControlDoc.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.gridControlDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControlDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridControlDoc.Location = New System.Drawing.Point(0, 39)
        Me.gridControlDoc.Name = "gridControlDoc"
        Me.gridControlDoc.Size = New System.Drawing.Size(1175, 268)
        Me.gridControlDoc.TabIndex = 14
        Me.gridControlDoc.TabStop = False
        Me.gridControlDoc.Text = "Grilla1"
        '
        'odImgDocVeh
        '
        UltraDataColumn67.DataType = GetType(Date)
        UltraDataColumn68.DataType = GetType(Short)
        UltraDataColumn69.DataType = GetType(Boolean)
        Me.odImgDocVeh.Band.Columns.AddRange(New Object() {UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69})
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.etiGenerada)
        Me.UltraGroupBox1.Controls.Add(Me.ColoresVencido)
        Me.UltraGroupBox1.Controls.Add(Me.etiTerminada)
        Me.UltraGroupBox1.Controls.Add(Me.etiEnProceso)
        Me.UltraGroupBox1.Controls.Add(Me.ColoresPorVencer)
        Me.UltraGroupBox1.Controls.Add(Me.ColoresGenerado)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(1175, 39)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'etiGenerada
        '
        Appearance49.BackColor = System.Drawing.Color.Transparent
        Appearance49.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance49
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(283, 12)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(52, 15)
        Me.etiGenerada.TabIndex = 9
        Me.etiGenerada.Text = "> 20 Dias"
        '
        'ColoresVencido
        '
        Me.ColoresVencido.DefaultColor = System.Drawing.Color.Red
        Me.ColoresVencido.Location = New System.Drawing.Point(63, 9)
        Me.ColoresVencido.Name = "ColoresVencido"
        Me.ColoresVencido.Size = New System.Drawing.Size(46, 22)
        Me.ColoresVencido.TabIndex = 3
        Me.ColoresVencido.Text = "Red"
        '
        'etiTerminada
        '
        Appearance50.BackColor = System.Drawing.Color.Transparent
        Appearance50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance50
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(11, 12)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(52, 15)
        Me.etiTerminada.TabIndex = 11
        Me.etiTerminada.Text = "< 10 Dias"
        '
        'etiEnProceso
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance51
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(137, 11)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(63, 15)
        Me.etiEnProceso.TabIndex = 10
        Me.etiEnProceso.Text = "10 - 20 Dias"
        '
        'ColoresPorVencer
        '
        Me.ColoresPorVencer.DefaultColor = System.Drawing.Color.LightGreen
        Me.ColoresPorVencer.Location = New System.Drawing.Point(200, 8)
        Me.ColoresPorVencer.Name = "ColoresPorVencer"
        Me.ColoresPorVencer.Size = New System.Drawing.Size(43, 22)
        Me.ColoresPorVencer.TabIndex = 2
        Me.ColoresPorVencer.Text = "LightGreen"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.DefaultColor = System.Drawing.Color.White
        Me.ColoresGenerado.Location = New System.Drawing.Point(335, 8)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 22)
        Me.ColoresGenerado.TabIndex = 1
        Me.ColoresGenerado.Text = "White"
        '
        'TabTarjetasCovisol
        '
        Me.TabTarjetasCovisol.Controls.Add(Me.griTarjetaCovisol)
        Me.TabTarjetasCovisol.Controls.Add(Me.tspTarjetasCovisol)
        Me.TabTarjetasCovisol.Controls.Add(Me.Agrupacion5)
        Me.TabTarjetasCovisol.Location = New System.Drawing.Point(-10000, -10000)
        Me.TabTarjetasCovisol.Name = "TabTarjetasCovisol"
        Me.TabTarjetasCovisol.Size = New System.Drawing.Size(1175, 307)
        '
        'griTarjetaCovisol
        '
        Me.griTarjetaCovisol.DataSource = Me.udsTarjetaCovisol
        Appearance52.BackColor = System.Drawing.Color.White
        Me.griTarjetaCovisol.DisplayLayout.Appearance = Appearance52
        UltraGridColumn169.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn169.Header.VisiblePosition = 0
        UltraGridColumn169.Hidden = True
        UltraGridColumn170.Header.VisiblePosition = 1
        UltraGridColumn170.Hidden = True
        UltraGridColumn171.Header.VisiblePosition = 3
        UltraGridColumn171.Hidden = True
        UltraGridColumn172.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn172.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn172.Header.VisiblePosition = 2
        UltraGridColumn172.Width = 121
        UltraGridColumn173.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn173.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn173.Header.Caption = "FechaInicio"
        UltraGridColumn173.Header.VisiblePosition = 5
        UltraGridColumn174.Header.VisiblePosition = 6
        UltraGridColumn175.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn175.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn175.Header.VisiblePosition = 8
        UltraGridColumn175.Width = 258
        UltraGridColumn176.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn176.Header.VisiblePosition = 9
        UltraGridColumn176.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn176.Width = 40
        UltraGridColumn177.Header.VisiblePosition = 10
        UltraGridColumn177.Hidden = True
        UltraGridColumn178.Header.VisiblePosition = 11
        UltraGridColumn178.Hidden = True
        UltraGridColumn179.Header.VisiblePosition = 12
        UltraGridColumn179.Hidden = True
        UltraGridColumn180.Header.VisiblePosition = 13
        UltraGridColumn180.Hidden = True
        UltraGridColumn181.Header.VisiblePosition = 7
        UltraGridColumn181.Hidden = True
        UltraGridColumn182.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn182.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn182.Header.Caption = "Empresa"
        UltraGridColumn182.Header.VisiblePosition = 4
        UltraGridColumn182.Width = 243
        UltraGridColumn183.Header.VisiblePosition = 14
        UltraGridColumn183.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn169, UltraGridColumn170, UltraGridColumn171, UltraGridColumn172, UltraGridColumn173, UltraGridColumn174, UltraGridColumn175, UltraGridColumn176, UltraGridColumn177, UltraGridColumn178, UltraGridColumn179, UltraGridColumn180, UltraGridColumn181, UltraGridColumn182, UltraGridColumn183})
        Me.griTarjetaCovisol.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.griTarjetaCovisol.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griTarjetaCovisol.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griTarjetaCovisol.DisplayLayout.GroupByBox.Hidden = True
        Me.griTarjetaCovisol.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarjetaCovisol.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarjetaCovisol.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griTarjetaCovisol.DisplayLayout.Override.CellPadding = 0
        Me.griTarjetaCovisol.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTarjetaCovisol.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTarjetaCovisol.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTarjetaCovisol.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance53.TextHAlignAsString = "Left"
        Me.griTarjetaCovisol.DisplayLayout.Override.HeaderAppearance = Appearance53
        Me.griTarjetaCovisol.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarjetaCovisol.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance54.TextVAlignAsString = "Middle"
        Me.griTarjetaCovisol.DisplayLayout.Override.RowAppearance = Appearance54
        Me.griTarjetaCovisol.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTarjetaCovisol.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griTarjetaCovisol.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griTarjetaCovisol.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarjetaCovisol.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griTarjetaCovisol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarjetaCovisol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarjetaCovisol.Location = New System.Drawing.Point(0, 86)
        Me.griTarjetaCovisol.Name = "griTarjetaCovisol"
        Me.griTarjetaCovisol.Size = New System.Drawing.Size(1175, 221)
        Me.griTarjetaCovisol.TabIndex = 5
        Me.griTarjetaCovisol.Tag = ""
        '
        'udsTarjetaCovisol
        '
        UltraDataColumn74.DataType = GetType(Date)
        UltraDataColumn75.DataType = GetType(Date)
        UltraDataColumn77.DataType = GetType(Boolean)
        UltraDataColumn79.DataType = GetType(Date)
        UltraDataColumn81.DataType = GetType(Date)
        UltraDataColumn82.DataType = GetType(Boolean)
        Me.udsTarjetaCovisol.Band.Columns.AddRange(New Object() {UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84})
        '
        'tspTarjetasCovisol
        '
        Me.tspTarjetasCovisol.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.tspTarjetasCovisol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregarTarj, Me.tsbQuitarTarj})
        Me.tspTarjetasCovisol.Location = New System.Drawing.Point(0, 61)
        Me.tspTarjetasCovisol.Name = "tspTarjetasCovisol"
        Me.tspTarjetasCovisol.Size = New System.Drawing.Size(1175, 25)
        Me.tspTarjetasCovisol.TabIndex = 6
        Me.tspTarjetasCovisol.Text = "ToolStrip1"
        '
        'tsbAgregarTarj
        '
        Me.tsbAgregarTarj.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        Me.tsbAgregarTarj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregarTarj.Name = "tsbAgregarTarj"
        Me.tsbAgregarTarj.Size = New System.Drawing.Size(95, 22)
        Me.tsbAgregarTarj.Text = "Agregar (Ins)"
        '
        'tsbQuitarTarj
        '
        Me.tsbQuitarTarj.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.tsbQuitarTarj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuitarTarj.Name = "tsbQuitarTarj"
        Me.tsbQuitarTarj.Size = New System.Drawing.Size(88, 22)
        Me.tsbQuitarTarj.Text = "Quitar (Del)"
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.cmbCovEmpProp)
        Me.Agrupacion5.Controls.Add(Me.txtCovGlosa)
        Me.Agrupacion5.Controls.Add(Me.txtCovTarjeta)
        Me.Agrupacion5.Controls.Add(Me.Label4)
        Me.Agrupacion5.Controls.Add(Me.Label3)
        Me.Agrupacion5.Controls.Add(Me.Label2)
        Me.Agrupacion5.Controls.Add(Me.Label1)
        Me.Agrupacion5.Controls.Add(Me.dtpCovFecha)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1175, 61)
        Me.Agrupacion5.TabIndex = 3
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cmbCovEmpProp
        '
        Me.cmbCovEmpProp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbCovEmpProp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbCovEmpProp.DropDownListWidth = -1
        Me.cmbCovEmpProp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cmbCovEmpProp.Location = New System.Drawing.Point(232, 7)
        Me.cmbCovEmpProp.Name = "cmbCovEmpProp"
        Me.cmbCovEmpProp.Size = New System.Drawing.Size(291, 22)
        Me.cmbCovEmpProp.TabIndex = 1
        '
        'txtCovGlosa
        '
        Me.txtCovGlosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCovGlosa.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCovGlosa.Location = New System.Drawing.Point(70, 33)
        Me.txtCovGlosa.MaxLength = 512
        Me.txtCovGlosa.Name = "txtCovGlosa"
        Me.txtCovGlosa.Size = New System.Drawing.Size(667, 22)
        Me.txtCovGlosa.TabIndex = 3
        '
        'txtCovTarjeta
        '
        Me.txtCovTarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCovTarjeta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCovTarjeta.Location = New System.Drawing.Point(598, 7)
        Me.txtCovTarjeta.Name = "txtCovTarjeta"
        Me.txtCovTarjeta.Size = New System.Drawing.Size(139, 22)
        Me.txtCovTarjeta.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(32, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 237
        Me.Label4.Text = "Glosa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(181, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 235
        Me.Label3.Text = "Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(1, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Fecha Inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(535, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 233
        Me.Label1.Text = "Nro Tarjeta:"
        '
        'dtpCovFecha
        '
        Me.dtpCovFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCovFecha.Location = New System.Drawing.Point(70, 8)
        Me.dtpCovFecha.Name = "dtpCovFecha"
        Me.dtpCovFecha.Size = New System.Drawing.Size(100, 21)
        Me.dtpCovFecha.TabIndex = 0
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griMantenimiento)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1175, 307)
        '
        'griMantenimiento
        '
        Me.griMantenimiento.DataSource = Me.udsProyMantenimiento
        Appearance55.BackColor = System.Drawing.Color.White
        Me.griMantenimiento.DisplayLayout.Appearance = Appearance55
        UltraGridColumn184.Header.VisiblePosition = 0
        UltraGridColumn185.Header.VisiblePosition = 1
        UltraGridColumn186.Header.VisiblePosition = 2
        UltraGridColumn187.Header.VisiblePosition = 3
        UltraGridColumn188.Header.VisiblePosition = 4
        UltraGridColumn189.Header.VisiblePosition = 5
        UltraGridColumn190.Header.VisiblePosition = 6
        UltraGridColumn191.Header.VisiblePosition = 7
        UltraGridColumn191.Hidden = True
        UltraGridColumn192.Header.VisiblePosition = 8
        UltraGridColumn193.Header.VisiblePosition = 9
        UltraGridColumn194.Header.VisiblePosition = 10
        UltraGridColumn195.Header.VisiblePosition = 11
        UltraGridColumn196.Header.VisiblePosition = 12
        UltraGridColumn197.Header.VisiblePosition = 13
        UltraGridColumn198.Header.VisiblePosition = 14
        UltraGridColumn199.Header.VisiblePosition = 15
        UltraGridColumn200.Header.VisiblePosition = 16
        UltraGridColumn201.Header.VisiblePosition = 17
        UltraGridColumn202.Header.VisiblePosition = 18
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn184, UltraGridColumn185, UltraGridColumn186, UltraGridColumn187, UltraGridColumn188, UltraGridColumn189, UltraGridColumn190, UltraGridColumn191, UltraGridColumn192, UltraGridColumn193, UltraGridColumn194, UltraGridColumn195, UltraGridColumn196, UltraGridColumn197, UltraGridColumn198, UltraGridColumn199, UltraGridColumn200, UltraGridColumn201, UltraGridColumn202})
        Me.griMantenimiento.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.griMantenimiento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.griMantenimiento.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griMantenimiento.DisplayLayout.GroupByBox.Hidden = True
        Me.griMantenimiento.DisplayLayout.MaxColScrollRegions = 1
        Me.griMantenimiento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMantenimiento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Me.griMantenimiento.DisplayLayout.Override.CellPadding = 0
        Me.griMantenimiento.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMantenimiento.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMantenimiento.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griMantenimiento.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Appearance56.TextHAlignAsString = "Left"
        Me.griMantenimiento.DisplayLayout.Override.HeaderAppearance = Appearance56
        Me.griMantenimiento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griMantenimiento.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Appearance57.TextVAlignAsString = "Middle"
        Me.griMantenimiento.DisplayLayout.Override.RowAppearance = Appearance57
        Me.griMantenimiento.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMantenimiento.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griMantenimiento.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griMantenimiento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMantenimiento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMantenimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.griMantenimiento.Name = "griMantenimiento"
        Me.griMantenimiento.Size = New System.Drawing.Size(1175, 307)
        Me.griMantenimiento.TabIndex = 6
        Me.griMantenimiento.Tag = ""
        '
        'udsProyMantenimiento
        '
        UltraDataColumn87.DataType = GetType(Integer)
        UltraDataColumn90.DataType = GetType(Date)
        UltraDataColumn91.DataType = GetType(Double)
        UltraDataColumn92.DataType = GetType(Double)
        UltraDataColumn93.DataType = GetType(Double)
        UltraDataColumn95.DataType = GetType(Double)
        UltraDataColumn96.DataType = GetType(Double)
        UltraDataColumn97.DataType = GetType(Date)
        UltraDataColumn101.DataType = GetType(Double)
        UltraDataColumn102.DataType = GetType(Double)
        UltraDataColumn103.DataType = GetType(Double)
        Me.udsProyMantenimiento.Band.Columns.AddRange(New Object() {UltraDataColumn85, UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103})
        '
        'tapVehiculo
        '
        Me.tapVehiculo.Controls.Add(Me.griLista)
        Me.tapVehiculo.Controls.Add(Me.agrBusqueda)
        Me.tapVehiculo.Location = New System.Drawing.Point(1, 22)
        Me.tapVehiculo.Name = "tapVehiculo"
        Me.tapVehiculo.Size = New System.Drawing.Size(1183, 565)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.MenuContextual1
        Me.griLista.DataSource = Me.ogdVehiculo
        Appearance58.BackColor = System.Drawing.SystemColors.Window
        Appearance58.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griLista.DisplayLayout.Appearance = Appearance58
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance59.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance59
        UltraGridColumn1.Header.VisiblePosition = 3
        UltraGridColumn1.Hidden = True
        Appearance60.TextHAlignAsString = "Left"
        UltraGridColumn2.CellAppearance = Appearance60
        Appearance61.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance61
        UltraGridColumn2.Header.VisiblePosition = 4
        UltraGridColumn2.Hidden = True
        UltraGridColumn2.Width = 73
        Appearance62.TextHAlignAsString = "Center"
        UltraGridColumn3.Header.Appearance = Appearance62
        UltraGridColumn3.Header.Caption = "PlacaActual"
        UltraGridColumn3.Header.Fixed = True
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 60
        Appearance63.TextHAlignAsString = "Center"
        UltraGridColumn4.Header.Appearance = Appearance63
        UltraGridColumn4.Header.VisiblePosition = 5
        UltraGridColumn4.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn4.Width = 40
        Appearance64.TextHAlignAsString = "Center"
        UltraGridColumn5.Header.Appearance = Appearance64
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        Appearance65.TextHAlignAsString = "Center"
        UltraGridColumn6.Header.Appearance = Appearance65
        UltraGridColumn6.Header.Caption = "Tipo Vehiculo"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.Width = 121
        Appearance66.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn7.CellAppearance = Appearance66
        Appearance67.TextHAlignAsString = "Center"
        UltraGridColumn7.Header.Appearance = Appearance67
        UltraGridColumn7.Header.Caption = "ModeloFuncional"
        UltraGridColumn7.Header.VisiblePosition = 12
        UltraGridColumn7.Width = 117
        Appearance68.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance68.Image = 3
        Appearance68.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.CellAppearance = Appearance68
        Appearance69.Image = 1
        Appearance69.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn8.CellButtonAppearance = Appearance69
        Appearance70.TextHAlignAsString = "Center"
        UltraGridColumn8.Header.Appearance = Appearance70
        UltraGridColumn8.Header.Caption = "Guardar"
        UltraGridColumn8.Header.VisiblePosition = 23
        UltraGridColumn8.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn8.Width = 40
        Appearance71.TextHAlignAsString = "Center"
        UltraGridColumn9.Header.Appearance = Appearance71
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn10.Header.Appearance = Appearance72
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.Width = 115
        Appearance73.TextHAlignAsString = "Center"
        UltraGridColumn11.Header.Appearance = Appearance73
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.Hidden = True
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn12.Header.Appearance = Appearance74
        UltraGridColumn12.Header.VisiblePosition = 11
        UltraGridColumn12.Width = 123
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn13.Header.Appearance = Appearance75
        UltraGridColumn13.Header.VisiblePosition = 24
        UltraGridColumn13.Hidden = True
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn14.Header.Appearance = Appearance76
        UltraGridColumn14.Header.Caption = "Empresa Propietaria"
        UltraGridColumn14.Header.VisiblePosition = 25
        UltraGridColumn14.Width = 200
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn15.Header.Appearance = Appearance77
        UltraGridColumn15.Header.VisiblePosition = 26
        UltraGridColumn15.Hidden = True
        UltraGridColumn15.Width = 45
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn16.Header.Appearance = Appearance78
        UltraGridColumn16.Header.VisiblePosition = 27
        UltraGridColumn16.Hidden = True
        UltraGridColumn16.Width = 200
        Appearance79.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance79.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance79
        UltraGridColumn17.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn17.Header.Appearance = Appearance80
        UltraGridColumn17.Header.Caption = "Ejes"
        UltraGridColumn17.Header.VisiblePosition = 18
        UltraGridColumn17.MaskInput = "n"
        UltraGridColumn17.Width = 25
        Appearance81.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance81.TextHAlignAsString = "Right"
        UltraGridColumn18.CellAppearance = Appearance81
        UltraGridColumn18.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn18.Header.Appearance = Appearance82
        UltraGridColumn18.Header.Caption = "Ruedas"
        UltraGridColumn18.Header.VisiblePosition = 19
        UltraGridColumn18.MaskInput = "nn"
        UltraGridColumn18.Width = 38
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn19.Header.Appearance = Appearance83
        UltraGridColumn19.Header.VisiblePosition = 28
        UltraGridColumn19.Width = 100
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance84.TextHAlignAsString = "Right"
        UltraGridColumn20.CellAppearance = Appearance84
        UltraGridColumn20.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance85.TextHAlignAsString = "Center"
        UltraGridColumn20.Header.Appearance = Appearance85
        UltraGridColumn20.Header.VisiblePosition = 14
        UltraGridColumn20.MaskInput = "{double:4.2}"
        UltraGridColumn20.Width = 40
        Appearance86.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance86.TextHAlignAsString = "Right"
        UltraGridColumn21.CellAppearance = Appearance86
        UltraGridColumn21.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn21.Header.Appearance = Appearance87
        UltraGridColumn21.Header.VisiblePosition = 15
        UltraGridColumn21.MaskInput = "{double:4.2}"
        UltraGridColumn21.Width = 40
        Appearance88.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn22.CellAppearance = Appearance88
        UltraGridColumn22.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance89
        UltraGridColumn22.Header.VisiblePosition = 16
        UltraGridColumn22.MaskInput = "{double:4.2}"
        UltraGridColumn22.Width = 40
        Appearance90.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn23.CellAppearance = Appearance90
        UltraGridColumn23.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn23.Header.Appearance = Appearance91
        UltraGridColumn23.Header.VisiblePosition = 17
        UltraGridColumn23.MaskInput = "{double:5.2}"
        UltraGridColumn23.Width = 50
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn24.Header.Appearance = Appearance92
        UltraGridColumn24.Header.VisiblePosition = 29
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 30
        UltraGridColumn25.Hidden = True
        UltraGridColumn26.Header.VisiblePosition = 31
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 32
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 33
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.Caption = "Año"
        UltraGridColumn29.Header.VisiblePosition = 34
        UltraGridColumn29.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn29.Width = 30
        UltraGridColumn30.Header.VisiblePosition = 35
        UltraGridColumn30.Hidden = True
        Appearance93.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn31.CellAppearance = Appearance93
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn31.Header.VisiblePosition = 22
        UltraGridColumn31.Width = 66
        UltraGridColumn32.Header.VisiblePosition = 36
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 37
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 38
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 39
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 40
        UltraGridColumn36.Hidden = True
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn37.CellAppearance = Appearance94
        UltraGridColumn37.Header.Caption = "Estado"
        UltraGridColumn37.Header.Fixed = True
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Integer]
        UltraGridColumn37.Width = 35
        UltraGridColumn38.Header.Fixed = True
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Width = 62
        UltraGridColumn39.Header.VisiblePosition = 41
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.Header.VisiblePosition = 42
        UltraGridColumn40.Hidden = True
        Appearance95.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn41.CellAppearance = Appearance95
        UltraGridColumn41.Header.Caption = "Flota"
        UltraGridColumn41.Header.VisiblePosition = 13
        UltraGridColumn41.Width = 96
        UltraGridColumn42.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn42.Header.Caption = "F.Tentativa Salida"
        UltraGridColumn42.Header.VisiblePosition = 43
        UltraGridColumn42.MaskInput = "{date} {time}"
        UltraGridColumn42.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn42.Width = 100
        Appearance96.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        UltraGridColumn43.CellAppearance = Appearance96
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn43.Header.Caption = "Propiedad"
        UltraGridColumn43.Header.VisiblePosition = 21
        UltraGridColumn43.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn43.Width = 35
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn44.Header.Caption = "Prorrateo"
        UltraGridColumn44.Header.VisiblePosition = 44
        UltraGridColumn44.Hidden = True
        UltraGridColumn44.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn44.Width = 35
        UltraGridColumn45.Header.Caption = "AF"
        UltraGridColumn45.Header.VisiblePosition = 45
        UltraGridColumn45.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn45.Width = 35
        UltraGridColumn46.Header.VisiblePosition = 46
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image
        UltraGridColumn46.Width = 75
        UltraGridColumn47.Header.VisiblePosition = 47
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.Header.VisiblePosition = 48
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.Header.VisiblePosition = 49
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.Header.VisiblePosition = 50
        UltraGridColumn51.Header.VisiblePosition = 51
        UltraGridColumn52.Header.VisiblePosition = 52
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.Header.VisiblePosition = 53
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 54
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.Header.VisiblePosition = 55
        UltraGridColumn55.Hidden = True
        UltraGridColumn56.Header.VisiblePosition = 56
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.Header.VisiblePosition = 57
        UltraGridColumn57.Hidden = True
        UltraGridColumn58.Header.VisiblePosition = 58
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 59
        UltraGridColumn59.Hidden = True
        Appearance97.TextHAlignAsString = "Right"
        UltraGridColumn60.CellAppearance = Appearance97
        UltraGridColumn60.Header.VisiblePosition = 20
        UltraGridColumn60.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn60.Width = 50
        UltraGridColumn61.Header.VisiblePosition = 60
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 61
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.Header.VisiblePosition = 62
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.Header.VisiblePosition = 63
        UltraGridColumn64.Hidden = True
        UltraGridColumn203.Header.VisiblePosition = 64
        UltraGridColumn203.Hidden = True
        UltraGridColumn204.Header.VisiblePosition = 65
        UltraGridColumn204.Hidden = True
        UltraGridColumn205.Header.Caption = "ClasificacionEMP"
        UltraGridColumn205.Header.VisiblePosition = 66
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn203, UltraGridColumn204, UltraGridColumn205})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance98.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance98.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance98.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance98.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance98
        Appearance99.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance99
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance100.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance100.BackColor2 = System.Drawing.SystemColors.Control
        Appearance100.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance100.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance100
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.UseFixedHeaders = True
        Me.griLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.ImageList = Me.imagenes
        Me.griLista.Location = New System.Drawing.Point(0, 115)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1183, 450)
        Me.griLista.TabIndex = 1
        Me.griLista.Text = "Información de vehículos"
        '
        'MenuContextual1
        '
        Me.MenuContextual1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuContextual1.ForeColor = System.Drawing.Color.Black
        Me.MenuContextual1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuContextual1.Name = "MenuContextual1"
        Me.MenuContextual1.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Vehículo"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        Me.ActualizarToolStripMenuItem.ToolTipText = "Actualizar o modificar el Vehículo seleccionado"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el Vehículo seleccionado"
        '
        'ogdVehiculo
        '
        UltraDataColumn107.DataType = GetType(Integer)
        UltraDataColumn107.DefaultValue = 0
        UltraDataColumn118.DataType = GetType(Boolean)
        UltraDataColumn147.DataType = GetType(Integer)
        UltraDataColumn147.DefaultValue = 0
        Me.ogdVehiculo.Band.Columns.AddRange(New Object() {UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170})
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
        Me.imagenes.Images.SetKeyName(12, "06_calculator.ico")
        Me.imagenes.Images.SetKeyName(13, "Consultar.ico")
        Me.imagenes.Images.SetKeyName(14, "266.png")
        '
        'agrBusqueda
        '
        Appearance101.BackColor = System.Drawing.Color.White
        Appearance101.BackColor2 = System.Drawing.Color.White
        Me.agrBusqueda.ContentAreaAppearance = Appearance101
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.agrBusqueda.Controls.Add(Me.expExcesoEnMantenimiento)
        Me.agrBusqueda.Controls.Add(Me.UltraExpandableGroupBox4)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1183, 115)
        Me.agrBusqueda.TabIndex = 0
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBox3
        '
        Me.UltraExpandableGroupBox3.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance102.BackColor = System.Drawing.Color.White
        Appearance102.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance102
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(413, 109)
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(695, 3)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(413, 109)
        Me.UltraExpandableGroupBox3.TabIndex = 340
        Me.UltraExpandableGroupBox3.Text = "Actualizar Masivo"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Etiqueta26)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label38)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.ColorBloque)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Label10)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.btnGuardar)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboFlotaMasiva)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.cboModeloFuncionalMasivo)
        Me.UltraExpandableGroupBoxPanel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(30, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(380, 103)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.UltraExpandableGroupBoxPanel2, "Exceso de días sin salir de Mantenimiento")
        '
        'Etiqueta26
        '
        Appearance103.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance103
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta26.Location = New System.Drawing.Point(5, 72)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(119, 14)
        Me.Etiqueta26.TabIndex = 2
        Me.Etiqueta26.Text = "Registros Actualizados:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label38.Location = New System.Drawing.Point(58, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 13)
        Me.Label38.TabIndex = 339
        Me.Label38.Text = "Flota:"
        '
        'ColorBloque
        '
        Me.ColorBloque.Color = System.Drawing.Color.Cyan
        Me.ColorBloque.Location = New System.Drawing.Point(130, 69)
        Me.ColorBloque.Name = "ColorBloque"
        Me.ColorBloque.Size = New System.Drawing.Size(44, 22)
        Me.ColorBloque.TabIndex = 3
        Me.ColorBloque.Text = "Cyan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(0, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 338
        Me.Label10.Text = "Modelo Funcional:"
        '
        'btnGuardar
        '
        Appearance104.Image = 1
        Appearance104.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnGuardar.Appearance = Appearance104
        Me.btnGuardar.ImageList = Me.imagenes
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(336, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 30)
        Me.btnGuardar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar Modificaciones en la Grilla")
        '
        'cboFlotaMasiva
        '
        Appearance105.ForeColor = System.Drawing.Color.Black
        Me.cboFlotaMasiva.Appearance = Appearance105
        Me.cboFlotaMasiva.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance106.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton1.Appearance = Appearance106
        EditorButton1.Key = "b1"
        Me.cboFlotaMasiva.ButtonsRight.Add(EditorButton1)
        Me.cboFlotaMasiva.DisplayMember = "Nombre"
        Me.cboFlotaMasiva.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlotaMasiva.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlotaMasiva.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlotaMasiva.ForeColor = System.Drawing.Color.Black
        Me.cboFlotaMasiva.ImageList = Me.imagenes
        Me.cboFlotaMasiva.Location = New System.Drawing.Point(93, 28)
        Me.cboFlotaMasiva.Name = "cboFlotaMasiva"
        Me.cboFlotaMasiva.Size = New System.Drawing.Size(237, 22)
        Me.cboFlotaMasiva.TabIndex = 8
        Me.cboFlotaMasiva.ValueMember = "Id"
        '
        'cboModeloFuncionalMasivo
        '
        Appearance107.ForeColor = System.Drawing.Color.Black
        Me.cboModeloFuncionalMasivo.Appearance = Appearance107
        Me.cboModeloFuncionalMasivo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance108.Image = Global.ISL.Win.My.Resources.Resources.Editar
        EditorButton2.Appearance = Appearance108
        EditorButton2.Key = "b1"
        Me.cboModeloFuncionalMasivo.ButtonsRight.Add(EditorButton2)
        Me.cboModeloFuncionalMasivo.DisplayMember = "Nombre"
        Me.cboModeloFuncionalMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModeloFuncionalMasivo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboModeloFuncionalMasivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModeloFuncionalMasivo.ForeColor = System.Drawing.Color.Black
        Me.cboModeloFuncionalMasivo.ImageList = Me.imagenes
        Me.cboModeloFuncionalMasivo.Location = New System.Drawing.Point(93, 4)
        Me.cboModeloFuncionalMasivo.Name = "cboModeloFuncionalMasivo"
        Me.cboModeloFuncionalMasivo.Size = New System.Drawing.Size(237, 22)
        Me.cboModeloFuncionalMasivo.TabIndex = 6
        Me.cboModeloFuncionalMasivo.ValueMember = "Id"
        '
        'expExcesoEnMantenimiento
        '
        Me.expExcesoEnMantenimiento.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance109.BackColor = System.Drawing.Color.White
        Appearance109.BackColor2 = System.Drawing.Color.White
        Me.expExcesoEnMantenimiento.ContentAreaAppearance = Appearance109
        Me.expExcesoEnMantenimiento.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.expExcesoEnMantenimiento.Dock = System.Windows.Forms.DockStyle.Left
        Me.expExcesoEnMantenimiento.ExpandedSize = New System.Drawing.Size(241, 109)
        Me.expExcesoEnMantenimiento.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.expExcesoEnMantenimiento.Location = New System.Drawing.Point(454, 3)
        Me.expExcesoEnMantenimiento.Name = "expExcesoEnMantenimiento"
        Me.expExcesoEnMantenimiento.Size = New System.Drawing.Size(241, 109)
        Me.expExcesoEnMantenimiento.TabIndex = 1
        Me.expExcesoEnMantenimiento.Text = "Mantenimiento"
        Me.expExcesoEnMantenimiento.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Color1Dia)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Color7DiasAMas)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Color4a7Dias)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta32)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Color2a3Dias)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta33)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta34)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.Etiqueta53)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.btnConsultarDisponibles)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(218, 103)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.UltraExpandableGroupBoxPanel4, "Exceso de días sin salir de Mantenimiento")
        '
        'Color1Dia
        '
        Me.Color1Dia.DefaultColor = System.Drawing.Color.Khaki
        Me.Color1Dia.Location = New System.Drawing.Point(50, 40)
        Me.Color1Dia.Name = "Color1Dia"
        Me.Color1Dia.Size = New System.Drawing.Size(43, 22)
        Me.Color1Dia.TabIndex = 1
        Me.Color1Dia.Text = "Khaki"
        '
        'Color7DiasAMas
        '
        Me.Color7DiasAMas.DefaultColor = System.Drawing.Color.LightCoral
        Me.Color7DiasAMas.Location = New System.Drawing.Point(159, 67)
        Me.Color7DiasAMas.Name = "Color7DiasAMas"
        Me.Color7DiasAMas.Size = New System.Drawing.Size(43, 22)
        Me.Color7DiasAMas.TabIndex = 7
        Me.Color7DiasAMas.Text = "LightCoral"
        '
        'Color4a7Dias
        '
        Me.Color4a7Dias.DefaultColor = System.Drawing.Color.DarkOrange
        Me.Color4a7Dias.Location = New System.Drawing.Point(50, 68)
        Me.Color4a7Dias.Name = "Color4a7Dias"
        Me.Color4a7Dias.Size = New System.Drawing.Size(43, 22)
        Me.Color4a7Dias.TabIndex = 5
        Me.Color4a7Dias.Text = "DarkOrange"
        '
        'Etiqueta32
        '
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(108, 43)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta32.TabIndex = 2
        Me.Etiqueta32.Text = "2-3 Días:"
        '
        'Color2a3Dias
        '
        Me.Color2a3Dias.DefaultColor = System.Drawing.Color.BurlyWood
        Me.Color2a3Dias.Location = New System.Drawing.Point(159, 39)
        Me.Color2a3Dias.Name = "Color2a3Dias"
        Me.Color2a3Dias.Size = New System.Drawing.Size(43, 22)
        Me.Color2a3Dias.TabIndex = 3
        Me.Color2a3Dias.Text = "BurlyWood"
        '
        'Etiqueta33
        '
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta33.Location = New System.Drawing.Point(1, 72)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(49, 15)
        Me.Etiqueta33.TabIndex = 4
        Me.Etiqueta33.Text = "4-7 Días:"
        '
        'Etiqueta34
        '
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta34.Location = New System.Drawing.Point(108, 71)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(51, 15)
        Me.Etiqueta34.TabIndex = 6
        Me.Etiqueta34.Text = "> 7 Días:"
        '
        'Etiqueta53
        '
        Me.Etiqueta53.AutoSize = True
        Me.Etiqueta53.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta53.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta53.Location = New System.Drawing.Point(16, 45)
        Me.Etiqueta53.Name = "Etiqueta53"
        Me.Etiqueta53.Size = New System.Drawing.Size(34, 15)
        Me.Etiqueta53.TabIndex = 0
        Me.Etiqueta53.Text = "1 Día:"
        '
        'btnConsultarDisponibles
        '
        Appearance110.Image = "266.png"
        Me.btnConsultarDisponibles.Appearance = Appearance110
        Me.btnConsultarDisponibles.ImageList = Me.imagenes
        Me.btnConsultarDisponibles.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConsultarDisponibles.Location = New System.Drawing.Point(47, 1)
        Me.btnConsultarDisponibles.Name = "btnConsultarDisponibles"
        Me.btnConsultarDisponibles.Size = New System.Drawing.Size(127, 37)
        Me.btnConsultarDisponibles.TabIndex = 4
        Me.btnConsultarDisponibles.Text = "Ver Vehículos en Mantenimiento"
        '
        'UltraExpandableGroupBox4
        '
        Me.UltraExpandableGroupBox4.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance111.BackColor = System.Drawing.Color.White
        Appearance111.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox4.ContentAreaAppearance = Appearance111
        Me.UltraExpandableGroupBox4.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox4.ExpandedSize = New System.Drawing.Size(451, 109)
        Me.UltraExpandableGroupBox4.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.UltraExpandableGroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBox4.Name = "UltraExpandableGroupBox4"
        Me.UltraExpandableGroupBox4.Size = New System.Drawing.Size(451, 109)
        Me.UltraExpandableGroupBox4.TabIndex = 0
        Me.UltraExpandableGroupBox4.Text = "Estados"
        Me.UltraExpandableGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorDuplicado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorPrestada)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta6)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta10)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorPerdida)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta12)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorOficina)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta19)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Colores8)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Colores7)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta3)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta1)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Colores5)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta61)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Colores6)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta62)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorSiniestrado)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorOperativo)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorVendido)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta52)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.ColorEnVenta)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta54)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta55)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Etiqueta51)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(428, 103)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'ColorDuplicado
        '
        Me.ColorDuplicado.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorDuplicado.Location = New System.Drawing.Point(376, 72)
        Me.ColorDuplicado.Name = "ColorDuplicado"
        Me.ColorDuplicado.Size = New System.Drawing.Size(43, 22)
        Me.ColorDuplicado.TabIndex = 23
        Me.ColorDuplicado.Text = "255; 128; 255"
        '
        'ColorPrestada
        '
        Me.ColorPrestada.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorPrestada.Location = New System.Drawing.Point(376, 49)
        Me.ColorPrestada.Name = "ColorPrestada"
        Me.ColorPrestada.Size = New System.Drawing.Size(43, 22)
        Me.ColorPrestada.TabIndex = 22
        Me.ColorPrestada.Text = "128; 255; 255"
        '
        'Etiqueta6
        '
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(273, 76)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(97, 14)
        Me.Etiqueta6.TabIndex = 21
        Me.Etiqueta6.Text = "Duplicado Act (11):"
        '
        'Etiqueta10
        '
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta10.Location = New System.Drawing.Point(296, 53)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta10.TabIndex = 20
        Me.Etiqueta10.Text = "Prestada (10):"
        '
        'ColorPerdida
        '
        Me.ColorPerdida.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ColorPerdida.Location = New System.Drawing.Point(376, 26)
        Me.ColorPerdida.Name = "ColorPerdida"
        Me.ColorPerdida.Size = New System.Drawing.Size(43, 22)
        Me.ColorPerdida.TabIndex = 19
        Me.ColorPerdida.Text = "255; 192; 128"
        '
        'Etiqueta12
        '
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta12.Location = New System.Drawing.Point(312, 8)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta12.TabIndex = 16
        Me.Etiqueta12.Text = "Oficina (8):"
        '
        'ColorOficina
        '
        Me.ColorOficina.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorOficina.Location = New System.Drawing.Point(376, 3)
        Me.ColorOficina.Name = "ColorOficina"
        Me.ColorOficina.Size = New System.Drawing.Size(43, 22)
        Me.ColorOficina.TabIndex = 18
        Me.ColorOficina.Text = "192; 192; 0"
        '
        'Etiqueta19
        '
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta19.Location = New System.Drawing.Point(309, 30)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta19.TabIndex = 17
        Me.Etiqueta19.Text = "Perdida (9):"
        '
        'Colores8
        '
        Me.Colores8.Color = System.Drawing.Color.Thistle
        Me.Colores8.DefaultColor = System.Drawing.Color.Silver
        Me.Colores8.Location = New System.Drawing.Point(225, 72)
        Me.Colores8.Name = "Colores8"
        Me.Colores8.Size = New System.Drawing.Size(43, 22)
        Me.Colores8.TabIndex = 15
        Me.Colores8.Text = "Thistle"
        '
        'Colores7
        '
        Me.Colores7.Color = System.Drawing.Color.LightSalmon
        Me.Colores7.DefaultColor = System.Drawing.Color.Silver
        Me.Colores7.Location = New System.Drawing.Point(225, 49)
        Me.Colores7.Name = "Colores7"
        Me.Colores7.Size = New System.Drawing.Size(43, 22)
        Me.Colores7.TabIndex = 14
        Me.Colores7.Text = "LightSalmon"
        '
        'Etiqueta3
        '
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta3.Location = New System.Drawing.Point(130, 76)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(89, 14)
        Me.Etiqueta3.TabIndex = 13
        Me.Etiqueta3.Text = "Perdida Total (7):"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta1.Location = New System.Drawing.Point(157, 53)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta1.TabIndex = 12
        Me.Etiqueta1.Text = "De Baja (6):"
        '
        'Colores5
        '
        Me.Colores5.DefaultColor = System.Drawing.Color.Silver
        Me.Colores5.Location = New System.Drawing.Point(225, 26)
        Me.Colores5.Name = "Colores5"
        Me.Colores5.Size = New System.Drawing.Size(43, 22)
        Me.Colores5.TabIndex = 11
        Me.Colores5.Text = "Silver"
        '
        'Etiqueta61
        '
        Me.Etiqueta61.AutoSize = True
        Me.Etiqueta61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta61.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta61.Location = New System.Drawing.Point(150, 8)
        Me.Etiqueta61.Name = "Etiqueta61"
        Me.Etiqueta61.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta61.TabIndex = 8
        Me.Etiqueta61.Text = "Alquilado (4):"
        '
        'Colores6
        '
        Me.Colores6.DefaultColor = System.Drawing.SystemColors.InactiveCaption
        Me.Colores6.Location = New System.Drawing.Point(225, 3)
        Me.Colores6.Name = "Colores6"
        Me.Colores6.Size = New System.Drawing.Size(43, 22)
        Me.Colores6.TabIndex = 10
        Me.Colores6.Text = "InactiveCaption"
        '
        'Etiqueta62
        '
        Me.Etiqueta62.AutoSize = True
        Me.Etiqueta62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta62.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta62.Location = New System.Drawing.Point(169, 30)
        Me.Etiqueta62.Name = "Etiqueta62"
        Me.Etiqueta62.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta62.TabIndex = 9
        Me.Etiqueta62.Text = "Otros (5):"
        '
        'ColorSiniestrado
        '
        Me.ColorSiniestrado.DefaultColor = System.Drawing.Color.OrangeRed
        Me.ColorSiniestrado.Location = New System.Drawing.Point(81, 3)
        Me.ColorSiniestrado.Name = "ColorSiniestrado"
        Me.ColorSiniestrado.Size = New System.Drawing.Size(43, 22)
        Me.ColorSiniestrado.TabIndex = 1
        Me.ColorSiniestrado.Text = "OrangeRed"
        '
        'ColorOperativo
        '
        Me.ColorOperativo.DefaultColor = System.Drawing.Color.White
        Me.ColorOperativo.Location = New System.Drawing.Point(81, 72)
        Me.ColorOperativo.Name = "ColorOperativo"
        Me.ColorOperativo.Size = New System.Drawing.Size(43, 22)
        Me.ColorOperativo.TabIndex = 7
        Me.ColorOperativo.Text = "White"
        '
        'ColorVendido
        '
        Me.ColorVendido.DefaultColor = System.Drawing.Color.Green
        Me.ColorVendido.Location = New System.Drawing.Point(81, 49)
        Me.ColorVendido.Name = "ColorVendido"
        Me.ColorVendido.Size = New System.Drawing.Size(43, 22)
        Me.ColorVendido.TabIndex = 5
        Me.ColorVendido.Text = "Green"
        '
        'Etiqueta52
        '
        Me.Etiqueta52.AutoSize = True
        Me.Etiqueta52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta52.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta52.Location = New System.Drawing.Point(11, 30)
        Me.Etiqueta52.Name = "Etiqueta52"
        Me.Etiqueta52.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta52.TabIndex = 2
        Me.Etiqueta52.Text = "En Venta (1):"
        '
        'ColorEnVenta
        '
        Me.ColorEnVenta.DefaultColor = System.Drawing.Color.LightGreen
        Me.ColorEnVenta.Location = New System.Drawing.Point(81, 26)
        Me.ColorEnVenta.Name = "ColorEnVenta"
        Me.ColorEnVenta.Size = New System.Drawing.Size(43, 22)
        Me.ColorEnVenta.TabIndex = 3
        Me.ColorEnVenta.Text = "LightGreen"
        '
        'Etiqueta54
        '
        Me.Etiqueta54.AutoSize = True
        Me.Etiqueta54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta54.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta54.Location = New System.Drawing.Point(15, 53)
        Me.Etiqueta54.Name = "Etiqueta54"
        Me.Etiqueta54.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta54.TabIndex = 4
        Me.Etiqueta54.Text = "Vendido (2):"
        '
        'Etiqueta55
        '
        Me.Etiqueta55.AutoSize = True
        Me.Etiqueta55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta55.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta55.Location = New System.Drawing.Point(7, 76)
        Me.Etiqueta55.Name = "Etiqueta55"
        Me.Etiqueta55.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta55.TabIndex = 6
        Me.Etiqueta55.Text = "Operativo (3):"
        '
        'Etiqueta51
        '
        Me.Etiqueta51.AutoSize = True
        Me.Etiqueta51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta51.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta51.Location = New System.Drawing.Point(-1, 8)
        Me.Etiqueta51.Name = "Etiqueta51"
        Me.Etiqueta51.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta51.TabIndex = 0
        Me.Etiqueta51.Text = "Siniestrado (0):"
        '
        'tapSituacional
        '
        Me.tapSituacional.Controls.Add(Me.griListaSituacional)
        Me.tapSituacional.Controls.Add(Me.UltraGroupBox2)
        Me.tapSituacional.Location = New System.Drawing.Point(-10000, -10000)
        Me.tapSituacional.Name = "tapSituacional"
        Me.tapSituacional.Size = New System.Drawing.Size(1183, 565)
        '
        'griListaSituacional
        '
        Me.griListaSituacional.ContextMenuStrip = Me.MenuContextual1
        Me.griListaSituacional.DataSource = Me.udsSituacional
        Appearance112.BackColor = System.Drawing.SystemColors.Window
        Appearance112.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griListaSituacional.DisplayLayout.Appearance = Appearance112
        UltraGridColumn65.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance113.TextHAlignAsString = "Center"
        UltraGridColumn65.Header.Appearance = Appearance113
        UltraGridColumn65.Header.VisiblePosition = 2
        UltraGridColumn65.Hidden = True
        UltraGridColumn66.Header.Fixed = True
        UltraGridColumn66.Header.VisiblePosition = 0
        UltraGridColumn66.Width = 89
        Appearance114.TextHAlignAsString = "Center"
        UltraGridColumn67.Header.Appearance = Appearance114
        UltraGridColumn67.Header.Caption = "PlacaActual"
        UltraGridColumn67.Header.Fixed = True
        UltraGridColumn67.Header.VisiblePosition = 1
        UltraGridColumn67.Width = 58
        UltraGridColumn68.Header.VisiblePosition = 3
        UltraGridColumn68.Width = 114
        UltraGridColumn69.Header.VisiblePosition = 4
        UltraGridColumn70.Header.VisiblePosition = 5
        UltraGridColumn70.Width = 96
        UltraGridColumn71.Header.VisiblePosition = 6
        UltraGridColumn71.Width = 93
        UltraGridColumn72.Header.VisiblePosition = 7
        Appearance115.TextHAlignAsString = "Center"
        UltraGridColumn73.Header.Appearance = Appearance115
        UltraGridColumn73.Header.VisiblePosition = 8
        UltraGridColumn73.Width = 100
        Appearance116.TextHAlignAsString = "Right"
        UltraGridColumn74.CellAppearance = Appearance116
        UltraGridColumn74.Header.Caption = "Año Fabricacion"
        UltraGridColumn74.Header.VisiblePosition = 9
        UltraGridColumn74.Width = 53
        Appearance117.TextHAlignAsString = "Center"
        UltraGridColumn75.Header.Appearance = Appearance117
        UltraGridColumn75.Header.VisiblePosition = 10
        UltraGridColumn75.Width = 84
        UltraGridColumn76.Header.Caption = "T.Neumatico"
        UltraGridColumn76.Header.VisiblePosition = 11
        UltraGridColumn76.Width = 79
        Appearance118.TextHAlignAsString = "Right"
        UltraGridColumn77.CellAppearance = Appearance118
        UltraGridColumn77.Format = "#,##0"
        Appearance119.TextHAlignAsString = "Center"
        UltraGridColumn77.Header.Appearance = Appearance119
        UltraGridColumn77.Header.Caption = "Ejes"
        UltraGridColumn77.Header.VisiblePosition = 12
        UltraGridColumn77.MaskInput = ""
        UltraGridColumn77.Width = 26
        UltraGridColumn78.Header.VisiblePosition = 13
        UltraGridColumn78.Width = 100
        UltraGridColumn79.Header.VisiblePosition = 14
        UltraGridColumn79.Width = 76
        UltraGridColumn80.Header.VisiblePosition = 15
        UltraGridColumn80.Width = 231
        UltraGridColumn81.Header.VisiblePosition = 16
        UltraGridColumn81.Width = 90
        UltraGridColumn82.Header.VisiblePosition = 17
        UltraGridColumn82.Width = 88
        Appearance120.TextHAlignAsString = "Right"
        UltraGridColumn83.CellAppearance = Appearance120
        UltraGridColumn83.Format = "#,##0.00"
        UltraGridColumn83.Header.VisiblePosition = 18
        UltraGridColumn83.Width = 71
        UltraGridColumn84.Header.VisiblePosition = 19
        UltraGridColumn85.Header.VisiblePosition = 20
        UltraGridColumn86.Header.VisiblePosition = 21
        UltraGridColumn86.Width = 195
        Appearance121.TextHAlignAsString = "Right"
        UltraGridColumn87.CellAppearance = Appearance121
        UltraGridColumn87.Format = "#,##0.00"
        UltraGridColumn87.Header.VisiblePosition = 22
        Appearance122.TextHAlignAsString = "Right"
        UltraGridColumn88.CellAppearance = Appearance122
        UltraGridColumn88.Format = "#,##0.00"
        UltraGridColumn88.Header.VisiblePosition = 23
        UltraGridColumn88.MaskInput = ""
        UltraGridColumn88.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn88.Width = 50
        Appearance123.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance123
        UltraGridColumn89.Format = "#,##0.00"
        UltraGridColumn89.Header.VisiblePosition = 24
        UltraGridColumn90.Header.VisiblePosition = 25
        UltraGridColumn90.Width = 104
        UltraGridColumn91.Header.VisiblePosition = 26
        UltraGridColumn91.Width = 104
        UltraGridColumn92.ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        Appearance124.Image = 1
        UltraGridColumn92.CellButtonAppearance = Appearance124
        UltraGridColumn92.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance125.TextHAlignAsString = "Center"
        UltraGridColumn92.Header.Appearance = Appearance125
        UltraGridColumn92.Header.VisiblePosition = 29
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn92.Width = 200
        UltraGridColumn93.Header.Caption = "IndEstado"
        UltraGridColumn93.Header.VisiblePosition = 30
        UltraGridColumn93.Hidden = True
        UltraGridColumn93.Width = 103
        UltraGridColumn94.Header.VisiblePosition = 27
        UltraGridColumn94.Width = 212
        Appearance126.TextHAlignAsString = "Right"
        UltraGridColumn95.CellAppearance = Appearance126
        UltraGridColumn95.Format = "#,##0.00"
        UltraGridColumn95.Header.VisiblePosition = 32
        UltraGridColumn95.Width = 78
        UltraGridColumn96.Header.VisiblePosition = 28
        UltraGridColumn96.Hidden = True
        Appearance127.TextHAlignAsString = "Right"
        UltraGridColumn97.CellAppearance = Appearance127
        UltraGridColumn97.Format = "#,##0.00"
        UltraGridColumn97.Header.VisiblePosition = 33
        UltraGridColumn97.Hidden = True
        UltraGridColumn97.MaskInput = ""
        UltraGridColumn97.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn97.Width = 50
        Appearance128.TextHAlignAsString = "Right"
        UltraGridColumn98.CellAppearance = Appearance128
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn98.Header.Caption = "Valor Actual (S/)"
        UltraGridColumn98.Header.VisiblePosition = 34
        UltraGridColumn99.Header.Caption = "Estado"
        UltraGridColumn99.Header.VisiblePosition = 31
        UltraGridColumn99.Width = 122
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99})
        Me.griListaSituacional.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.griListaSituacional.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaSituacional.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance129.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance129.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance129.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance129.BorderColor = System.Drawing.SystemColors.Window
        Me.griListaSituacional.DisplayLayout.GroupByBox.Appearance = Appearance129
        Appearance130.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaSituacional.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance130
        Me.griListaSituacional.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griListaSituacional.DisplayLayout.GroupByBox.Hidden = True
        Appearance131.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance131.BackColor2 = System.Drawing.SystemColors.Control
        Appearance131.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance131.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griListaSituacional.DisplayLayout.GroupByBox.PromptAppearance = Appearance131
        Me.griListaSituacional.DisplayLayout.MaxColScrollRegions = 1
        Me.griListaSituacional.DisplayLayout.MaxRowScrollRegions = 1
        Me.griListaSituacional.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griListaSituacional.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListaSituacional.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListaSituacional.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListaSituacional.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListaSituacional.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griListaSituacional.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griListaSituacional.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griListaSituacional.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListaSituacional.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListaSituacional.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListaSituacional.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListaSituacional.DisplayLayout.UseFixedHeaders = True
        Me.griListaSituacional.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griListaSituacional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListaSituacional.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListaSituacional.ImageList = Me.imagenes
        Me.griListaSituacional.Location = New System.Drawing.Point(0, 100)
        Me.griListaSituacional.Name = "griListaSituacional"
        Me.griListaSituacional.Size = New System.Drawing.Size(1183, 465)
        Me.griListaSituacional.TabIndex = 1
        Me.griListaSituacional.Text = "Información de vehículos"
        '
        'udsSituacional
        '
        UltraDataColumn183.DataType = GetType(Integer)
        UltraDataColumn189.DataType = GetType(Double)
        UltraDataColumn190.DataType = GetType(Date)
        UltraDataColumn193.DataType = GetType(Double)
        UltraDataColumn194.DataType = GetType(Double)
        UltraDataColumn195.DataType = GetType(Double)
        UltraDataColumn199.DataType = GetType(Integer)
        UltraDataColumn201.DataType = GetType(Double)
        UltraDataColumn203.DataType = GetType(Double)
        UltraDataColumn204.DataType = GetType(Double)
        Me.udsSituacional.Band.Columns.AddRange(New Object() {UltraDataColumn171, UltraDataColumn172, UltraDataColumn173, UltraDataColumn174, UltraDataColumn175, UltraDataColumn176, UltraDataColumn177, UltraDataColumn178, UltraDataColumn179, UltraDataColumn180, UltraDataColumn181, UltraDataColumn182, UltraDataColumn183, UltraDataColumn184, UltraDataColumn185, UltraDataColumn186, UltraDataColumn187, UltraDataColumn188, UltraDataColumn189, UltraDataColumn190, UltraDataColumn191, UltraDataColumn192, UltraDataColumn193, UltraDataColumn194, UltraDataColumn195, UltraDataColumn196, UltraDataColumn197, UltraDataColumn198, UltraDataColumn199, UltraDataColumn200, UltraDataColumn201, UltraDataColumn202, UltraDataColumn203, UltraDataColumn204})
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.cboFlotaSituacional)
        Me.UltraGroupBox2.Controls.Add(Me.UltraLabel2)
        Me.UltraGroupBox2.Controls.Add(Me.gruexEstado)
        Me.UltraGroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(1183, 100)
        Me.UltraGroupBox2.TabIndex = 2
        Me.UltraGroupBox2.Tag = ""
        Me.UltraGroupBox2.Text = "Busqueda"
        Me.UltraGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'cboFlotaSituacional
        '
        Me.cboFlotaSituacional.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboFlotaSituacional.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboFlotaSituacional.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboFlotaSituacional.Location = New System.Drawing.Point(650, 27)
        Me.cboFlotaSituacional.Name = "cboFlotaSituacional"
        Me.cboFlotaSituacional.Size = New System.Drawing.Size(174, 22)
        Me.cboFlotaSituacional.TabIndex = 3
        Me.cboFlotaSituacional.ValueMember = "Id"
        '
        'UltraLabel2
        '
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(611, 31)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(33, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Flota:"
        '
        'gruexEstado
        '
        Me.gruexEstado.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance132.BackColor = System.Drawing.Color.White
        Appearance132.BackColor2 = System.Drawing.Color.White
        Me.gruexEstado.ContentAreaAppearance = Appearance132
        Me.gruexEstado.Controls.Add(Me.UltraExpandableGroupBoxPanel9)
        Me.gruexEstado.Dock = System.Windows.Forms.DockStyle.Left
        Me.gruexEstado.ExpandedSize = New System.Drawing.Size(576, 79)
        Me.gruexEstado.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gruexEstado.Location = New System.Drawing.Point(2, 19)
        Me.gruexEstado.Name = "gruexEstado"
        Me.gruexEstado.Size = New System.Drawing.Size(576, 79)
        Me.gruexEstado.TabIndex = 1
        Me.gruexEstado.Text = "Estado"
        Me.gruexEstado.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel9
        '
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.OficinaSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta27)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.DuplicadoSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta20)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.PrestadaSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta24)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.PerdidaSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta25)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.PerdidaTotalSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.DeBajaSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta5)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta4)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.OtrosSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta78)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.AlquiladoSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta79)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.SiniestradoSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.OperativoSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.VendidoSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta80)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.EnVentaSit)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta82)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta83)
        Me.UltraExpandableGroupBoxPanel9.Controls.Add(Me.Etiqueta84)
        Me.UltraExpandableGroupBoxPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel9.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel9.Name = "UltraExpandableGroupBoxPanel9"
        Me.UltraExpandableGroupBoxPanel9.Size = New System.Drawing.Size(553, 73)
        Me.UltraExpandableGroupBoxPanel9.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.UltraExpandableGroupBoxPanel9, "Estado actual del vehículo")
        '
        'OficinaSit
        '
        Me.OficinaSit.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OficinaSit.Location = New System.Drawing.Point(351, 50)
        Me.OficinaSit.Name = "OficinaSit"
        Me.OficinaSit.Size = New System.Drawing.Size(43, 22)
        Me.OficinaSit.TabIndex = 23
        Me.OficinaSit.Text = "192; 255; 255"
        '
        'Etiqueta27
        '
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta27.Location = New System.Drawing.Point(287, 54)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(58, 14)
        Me.Etiqueta27.TabIndex = 22
        Me.Etiqueta27.Text = "Oficina (8):"
        '
        'DuplicadoSit
        '
        Me.DuplicadoSit.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DuplicadoSit.Location = New System.Drawing.Point(499, 49)
        Me.DuplicadoSit.Name = "DuplicadoSit"
        Me.DuplicadoSit.Size = New System.Drawing.Size(43, 22)
        Me.DuplicadoSit.TabIndex = 21
        Me.DuplicadoSit.Text = "192; 192; 0"
        '
        'Etiqueta20
        '
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta20.Location = New System.Drawing.Point(422, 30)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(74, 14)
        Me.Etiqueta20.TabIndex = 18
        Me.Etiqueta20.Text = "Prestada (10):"
        '
        'PrestadaSit
        '
        Me.PrestadaSit.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PrestadaSit.Location = New System.Drawing.Point(499, 26)
        Me.PrestadaSit.Name = "PrestadaSit"
        Me.PrestadaSit.Size = New System.Drawing.Size(43, 22)
        Me.PrestadaSit.TabIndex = 20
        Me.PrestadaSit.Text = "255; 192; 255"
        '
        'Etiqueta24
        '
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta24.Location = New System.Drawing.Point(399, 53)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(97, 14)
        Me.Etiqueta24.TabIndex = 19
        Me.Etiqueta24.Text = "Duplicado Act (11):"
        '
        'PerdidaSit
        '
        Me.PerdidaSit.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PerdidaSit.Location = New System.Drawing.Point(499, 4)
        Me.PerdidaSit.Name = "PerdidaSit"
        Me.PerdidaSit.Size = New System.Drawing.Size(43, 22)
        Me.PerdidaSit.TabIndex = 17
        Me.PerdidaSit.Text = "192; 192; 255"
        '
        'Etiqueta25
        '
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta25.Location = New System.Drawing.Point(435, 5)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(61, 14)
        Me.Etiqueta25.TabIndex = 16
        Me.Etiqueta25.Text = "Perdida (9):"
        '
        'PerdidaTotalSit
        '
        Me.PerdidaTotalSit.Color = System.Drawing.SystemColors.GradientActiveCaption
        Me.PerdidaTotalSit.Location = New System.Drawing.Point(351, 26)
        Me.PerdidaTotalSit.Name = "PerdidaTotalSit"
        Me.PerdidaTotalSit.Size = New System.Drawing.Size(43, 22)
        Me.PerdidaTotalSit.TabIndex = 15
        Me.PerdidaTotalSit.Text = "GradientActiveCaption"
        '
        'DeBajaSit
        '
        Me.DeBajaSit.Color = System.Drawing.Color.PeachPuff
        Me.DeBajaSit.Location = New System.Drawing.Point(351, 4)
        Me.DeBajaSit.Name = "DeBajaSit"
        Me.DeBajaSit.Size = New System.Drawing.Size(43, 22)
        Me.DeBajaSit.TabIndex = 14
        Me.DeBajaSit.Text = "PeachPuff"
        '
        'Etiqueta5
        '
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(256, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(89, 14)
        Me.Etiqueta5.TabIndex = 13
        Me.Etiqueta5.Text = "Perdida Total (7):"
        '
        'Etiqueta4
        '
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(283, 9)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta4.TabIndex = 12
        Me.Etiqueta4.Text = "De Baja (6):"
        '
        'OtrosSit
        '
        Me.OtrosSit.Color = System.Drawing.Color.Silver
        Me.OtrosSit.Location = New System.Drawing.Point(206, 49)
        Me.OtrosSit.Name = "OtrosSit"
        Me.OtrosSit.Size = New System.Drawing.Size(43, 22)
        Me.OtrosSit.TabIndex = 11
        Me.OtrosSit.Text = "Silver"
        '
        'Etiqueta78
        '
        Me.Etiqueta78.AutoSize = True
        Me.Etiqueta78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta78.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta78.Location = New System.Drawing.Point(135, 30)
        Me.Etiqueta78.Name = "Etiqueta78"
        Me.Etiqueta78.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta78.TabIndex = 8
        Me.Etiqueta78.Text = "Alquilado (4):"
        '
        'AlquiladoSit
        '
        Me.AlquiladoSit.Location = New System.Drawing.Point(206, 26)
        Me.AlquiladoSit.Name = "AlquiladoSit"
        Me.AlquiladoSit.Size = New System.Drawing.Size(43, 22)
        Me.AlquiladoSit.TabIndex = 10
        Me.AlquiladoSit.Text = "Control"
        '
        'Etiqueta79
        '
        Me.Etiqueta79.AutoSize = True
        Me.Etiqueta79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta79.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta79.Location = New System.Drawing.Point(153, 53)
        Me.Etiqueta79.Name = "Etiqueta79"
        Me.Etiqueta79.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta79.TabIndex = 9
        Me.Etiqueta79.Text = "Otros (5):"
        '
        'SiniestradoSit
        '
        Me.SiniestradoSit.Color = System.Drawing.Color.OrangeRed
        Me.SiniestradoSit.Location = New System.Drawing.Point(85, 4)
        Me.SiniestradoSit.Name = "SiniestradoSit"
        Me.SiniestradoSit.Size = New System.Drawing.Size(43, 22)
        Me.SiniestradoSit.TabIndex = 1
        Me.SiniestradoSit.Text = "OrangeRed"
        '
        'OperativoSit
        '
        Me.OperativoSit.Color = System.Drawing.Color.White
        Me.OperativoSit.Location = New System.Drawing.Point(206, 4)
        Me.OperativoSit.Name = "OperativoSit"
        Me.OperativoSit.Size = New System.Drawing.Size(43, 22)
        Me.OperativoSit.TabIndex = 7
        Me.OperativoSit.Text = "White"
        '
        'VendidoSit
        '
        Me.VendidoSit.Color = System.Drawing.Color.DarkSeaGreen
        Me.VendidoSit.Location = New System.Drawing.Point(85, 50)
        Me.VendidoSit.Name = "VendidoSit"
        Me.VendidoSit.Size = New System.Drawing.Size(43, 22)
        Me.VendidoSit.TabIndex = 5
        Me.VendidoSit.Text = "DarkSeaGreen"
        '
        'Etiqueta80
        '
        Me.Etiqueta80.AutoSize = True
        Me.Etiqueta80.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta80.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta80.Location = New System.Drawing.Point(15, 31)
        Me.Etiqueta80.Name = "Etiqueta80"
        Me.Etiqueta80.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta80.TabIndex = 2
        Me.Etiqueta80.Text = "En Venta (1):"
        '
        'EnVentaSit
        '
        Me.EnVentaSit.Color = System.Drawing.Color.YellowGreen
        Me.EnVentaSit.Location = New System.Drawing.Point(85, 27)
        Me.EnVentaSit.Name = "EnVentaSit"
        Me.EnVentaSit.Size = New System.Drawing.Size(43, 22)
        Me.EnVentaSit.TabIndex = 3
        Me.EnVentaSit.Text = "YellowGreen"
        '
        'Etiqueta82
        '
        Me.Etiqueta82.AutoSize = True
        Me.Etiqueta82.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta82.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta82.Location = New System.Drawing.Point(19, 54)
        Me.Etiqueta82.Name = "Etiqueta82"
        Me.Etiqueta82.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta82.TabIndex = 4
        Me.Etiqueta82.Text = "Vendido (2):"
        '
        'Etiqueta83
        '
        Me.Etiqueta83.AutoSize = True
        Me.Etiqueta83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta83.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta83.Location = New System.Drawing.Point(132, 8)
        Me.Etiqueta83.Name = "Etiqueta83"
        Me.Etiqueta83.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta83.TabIndex = 6
        Me.Etiqueta83.Text = "Operativo (3):"
        '
        'Etiqueta84
        '
        Me.Etiqueta84.AutoSize = True
        Me.Etiqueta84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta84.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta84.Location = New System.Drawing.Point(3, 9)
        Me.Etiqueta84.Name = "Etiqueta84"
        Me.Etiqueta84.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta84.TabIndex = 0
        Me.Etiqueta84.Text = "Siniestrado (0):"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl9.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1183, 565)
        '
        'UltraExpandableGroupBox6
        '
        Me.UltraExpandableGroupBox6.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance133.BackColor = System.Drawing.Color.White
        Appearance133.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance133
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(783, 468)
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(400, 97)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(783, 468)
        Me.UltraExpandableGroupBox6.TabIndex = 2
        Me.UltraExpandableGroupBox6.TabStop = False
        Me.UltraExpandableGroupBox6.Text = "Imagen Unidad"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.upbFoto)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(760, 462)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'upbFoto
        '
        Me.upbFoto.BorderShadowColor = System.Drawing.Color.Empty
        Me.upbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.upbFoto.Location = New System.Drawing.Point(0, 0)
        Me.upbFoto.Name = "upbFoto"
        Me.upbFoto.Size = New System.Drawing.Size(760, 462)
        Me.upbFoto.TabIndex = 0
        '
        'UltraExpandableGroupBox2
        '
        Me.UltraExpandableGroupBox2.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance134.BackColor = System.Drawing.Color.White
        Appearance134.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance134
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(400, 468)
        Me.UltraExpandableGroupBox2.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(0, 97)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(400, 468)
        Me.UltraExpandableGroupBox2.TabIndex = 1
        Me.UltraExpandableGroupBox2.TabStop = False
        Me.UltraExpandableGroupBox2.Text = "Datos Generales"
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label29)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.verMotriz)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label28)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label27)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label26)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label25)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label24)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label23)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label22)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label21)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label20)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndHorometro)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Label19)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.imagenGuardar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnDescargarJpg)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ndOdometro)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnBorrar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtNroEquipoMovil)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnExaminar)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtObservacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.numAñoModelo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCodigo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtId)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboTipoVehiculo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboModelo)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.numAñoFabricacion)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboMarca)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboModeloFuncional)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(377, 462)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label29.Location = New System.Drawing.Point(21, 186)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 340
        Me.Label29.Text = "Observación:"
        '
        'verMotriz
        '
        Me.verMotriz.AutoSize = True
        Me.verMotriz.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verMotriz.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verMotriz.Location = New System.Drawing.Point(180, 8)
        Me.verMotriz.Name = "verMotriz"
        Me.verMotriz.Size = New System.Drawing.Size(62, 17)
        Me.verMotriz.TabIndex = 2
        Me.verMotriz.Text = "Motriz"
        Me.verMotriz.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label28.Location = New System.Drawing.Point(46, 157)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(46, 13)
        Me.Label28.TabIndex = 339
        Me.Label28.Text = "Móviles:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label27.Location = New System.Drawing.Point(236, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 338
        Me.Label27.Text = "Año Modelo:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label26.Location = New System.Drawing.Point(5, 131)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 13)
        Me.Label26.TabIndex = 337
        Me.Label26.Text = "Año Fabricación:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label25.Location = New System.Drawing.Point(47, 107)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(45, 13)
        Me.Label25.TabIndex = 336
        Me.Label25.Text = "Modelo:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label24.Location = New System.Drawing.Point(52, 83)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 335
        Me.Label24.Text = "Marca:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label23.Location = New System.Drawing.Point(-1, 59)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 334
        Me.Label23.Text = "Modelo Funcional:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label22.Location = New System.Drawing.Point(19, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 333
        Me.Label22.Text = "Tipo Vehículo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Location = New System.Drawing.Point(48, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 13)
        Me.Label21.TabIndex = 332
        Me.Label21.Text = "Codigo:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label20.Location = New System.Drawing.Point(213, 212)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 250
        Me.Label20.Text = "Horómetro:"
        '
        'ndHorometro
        '
        Appearance135.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndHorometro.Appearance = Appearance135
        Me.ndHorometro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndHorometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndHorometro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndHorometro.Location = New System.Drawing.Point(277, 209)
        Me.ndHorometro.MaskInput = "{LOC}nnnnnnnn.nnn"
        Me.ndHorometro.Name = "ndHorometro"
        Me.ndHorometro.NullText = "0.00"
        Me.ndHorometro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndHorometro.ReadOnly = True
        Me.ndHorometro.Size = New System.Drawing.Size(97, 21)
        Me.ndHorometro.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label19.Location = New System.Drawing.Point(33, 212)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 251
        Me.Label19.Text = "Odómetro:"
        '
        'imagenGuardar
        '
        Me.imagenGuardar.Location = New System.Drawing.Point(41, 245)
        Me.imagenGuardar.Name = "imagenGuardar"
        Me.imagenGuardar.Size = New System.Drawing.Size(45, 24)
        Me.imagenGuardar.TabIndex = 331
        Me.imagenGuardar.TabStop = False
        Me.imagenGuardar.Visible = False
        '
        'btnDescargarJpg
        '
        Appearance136.ForeColor = System.Drawing.Color.Navy
        Appearance136.Image = 2
        Appearance136.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnDescargarJpg.Appearance = Appearance136
        Me.btnDescargarJpg.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnDescargarJpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDescargarJpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescargarJpg.ForeColor = System.Drawing.Color.Black
        Me.btnDescargarJpg.ImageList = Me.imagenes
        Me.btnDescargarJpg.Location = New System.Drawing.Point(284, 239)
        Me.btnDescargarJpg.Name = "btnDescargarJpg"
        Me.btnDescargarJpg.Size = New System.Drawing.Size(90, 30)
        Me.btnDescargarJpg.TabIndex = 13
        Me.btnDescargarJpg.TabStop = False
        Me.btnDescargarJpg.Text = "Descarga"
        '
        'ndOdometro
        '
        Appearance137.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndOdometro.Appearance = Appearance137
        Me.ndOdometro.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndOdometro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndOdometro.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndOdometro.Location = New System.Drawing.Point(92, 209)
        Me.ndOdometro.MaskInput = "{LOC}nnnnnnnn.nnn"
        Me.ndOdometro.Name = "ndOdometro"
        Me.ndOdometro.NullText = "0.00"
        Me.ndOdometro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndOdometro.ReadOnly = True
        Me.ndOdometro.Size = New System.Drawing.Size(90, 21)
        Me.ndOdometro.TabIndex = 11
        '
        'btnBorrar
        '
        Appearance138.ForeColor = System.Drawing.Color.Navy
        Appearance138.Image = 3
        Appearance138.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnBorrar.Appearance = Appearance138
        Me.btnBorrar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.Black
        Me.btnBorrar.ImageList = Me.imagenes
        Me.btnBorrar.Location = New System.Drawing.Point(188, 239)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(90, 30)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.TabStop = False
        Me.btnBorrar.Text = "Limpiar..."
        '
        'txtNroEquipoMovil
        '
        Appearance139.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroEquipoMovil.Appearance = Appearance139
        Me.txtNroEquipoMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroEquipoMovil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroEquipoMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroEquipoMovil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroEquipoMovil.Location = New System.Drawing.Point(92, 155)
        Me.txtNroEquipoMovil.MaxLength = 50
        Me.txtNroEquipoMovil.Name = "txtNroEquipoMovil"
        Me.txtNroEquipoMovil.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNroEquipoMovil.Size = New System.Drawing.Size(282, 21)
        Me.txtNroEquipoMovil.TabIndex = 9
        '
        'btnExaminar
        '
        Appearance140.ForeColor = System.Drawing.Color.Navy
        Appearance140.Image = 7
        Appearance140.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnExaminar.Appearance = Appearance140
        Me.btnExaminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.Black
        Me.btnExaminar.ImageList = Me.imagenes
        Me.btnExaminar.Location = New System.Drawing.Point(92, 239)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(90, 30)
        Me.btnExaminar.TabIndex = 11
        Me.btnExaminar.TabStop = False
        Me.btnExaminar.Text = "Imagen..."
        '
        'txtObservacion
        '
        Appearance141.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacion.Appearance = Appearance141
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtObservacion.Location = New System.Drawing.Point(92, 182)
        Me.txtObservacion.MaxLength = 200
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(282, 21)
        Me.txtObservacion.TabIndex = 10
        '
        'numAñoModelo
        '
        Appearance142.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAñoModelo.Appearance = Appearance142
        Me.numAñoModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAñoModelo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAñoModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAñoModelo.Location = New System.Drawing.Point(309, 127)
        Me.numAñoModelo.MaxValue = 9998
        Me.numAñoModelo.MinValue = 1753
        Me.numAñoModelo.Name = "numAñoModelo"
        Me.numAñoModelo.NullText = "0000"
        Me.numAñoModelo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numAñoModelo.Size = New System.Drawing.Size(65, 21)
        Me.numAñoModelo.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAñoModelo.SpinIncrement = 1
        Me.numAñoModelo.TabIndex = 8
        Me.numAñoModelo.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numAñoModelo.Value = 1753
        '
        'txtCodigo
        '
        Appearance143.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance143
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(92, 6)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(84, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'txtId
        '
        Appearance144.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Appearance = Appearance144
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtId.Location = New System.Drawing.Point(23, 6)
        Me.txtId.MaxLength = 8
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(21, 21)
        Me.txtId.TabIndex = 2
        Me.txtId.Visible = False
        '
        'cboTipoVehiculo
        '
        Appearance145.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVehiculo.Appearance = Appearance145
        Me.cboTipoVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboTipoVehiculo.DisplayMember = "Nombre"
        Me.cboTipoVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoVehiculo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoVehiculo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoVehiculo.Location = New System.Drawing.Point(92, 31)
        Me.cboTipoVehiculo.Name = "cboTipoVehiculo"
        Me.cboTipoVehiculo.Size = New System.Drawing.Size(200, 21)
        Me.cboTipoVehiculo.TabIndex = 3
        Me.cboTipoVehiculo.ValueMember = "Id"
        '
        'cboModelo
        '
        Appearance146.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModelo.Appearance = Appearance146
        Me.cboModelo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboModelo.DisplayMember = "Nombre"
        Me.cboModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModelo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModelo.Location = New System.Drawing.Point(92, 103)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Size = New System.Drawing.Size(282, 21)
        Me.cboModelo.TabIndex = 6
        Me.cboModelo.ValueMember = "Id"
        '
        'numAñoFabricacion
        '
        Appearance147.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAñoFabricacion.Appearance = Appearance147
        Me.numAñoFabricacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAñoFabricacion.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAñoFabricacion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAñoFabricacion.Location = New System.Drawing.Point(92, 127)
        Me.numAñoFabricacion.MaxValue = 9998
        Me.numAñoFabricacion.MinValue = 1753
        Me.numAñoFabricacion.Name = "numAñoFabricacion"
        Me.numAñoFabricacion.NullText = "0000"
        Me.numAñoFabricacion.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.numAñoFabricacion.Size = New System.Drawing.Size(65, 21)
        Me.numAñoFabricacion.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.numAñoFabricacion.SpinIncrement = 1
        Me.numAñoFabricacion.TabIndex = 7
        Me.numAñoFabricacion.TabNavigation = Infragistics.Win.UltraWinMaskedEdit.MaskedEditTabNavigation.NextControl
        Me.numAñoFabricacion.Value = 1753
        '
        'cboMarca
        '
        Appearance148.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMarca.Appearance = Appearance148
        Me.cboMarca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboMarca.DisplayMember = "Nombre"
        Me.cboMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMarca.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboMarca.Location = New System.Drawing.Point(92, 79)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(282, 21)
        Me.cboMarca.TabIndex = 5
        Me.cboMarca.ValueMember = "Id"
        '
        'cboModeloFuncional
        '
        Appearance149.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModeloFuncional.Appearance = Appearance149
        Me.cboModeloFuncional.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboModeloFuncional.DisplayMember = "Nombre"
        Me.cboModeloFuncional.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModeloFuncional.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboModeloFuncional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModeloFuncional.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModeloFuncional.Location = New System.Drawing.Point(92, 55)
        Me.cboModeloFuncional.Name = "cboModeloFuncional"
        Me.cboModeloFuncional.Size = New System.Drawing.Size(200, 21)
        Me.cboModeloFuncional.TabIndex = 4
        Me.cboModeloFuncional.ValueMember = "Id"
        '
        'UltraExpandableGroupBox1
        '
        Me.UltraExpandableGroupBox1.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Appearance150.BackColor = System.Drawing.Color.White
        Appearance150.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance150
        Me.UltraExpandableGroupBox1.Controls.Add(Me.exgruConsultas)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(1183, 97)
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(1183, 97)
        Me.UltraExpandableGroupBox1.TabIndex = 0
        Me.UltraExpandableGroupBox1.TabStop = False
        Me.UltraExpandableGroupBox1.Text = "Información Vehículo"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'exgruConsultas
        '
        Me.exgruConsultas.Controls.Add(Me.UltraLabel3)
        Me.exgruConsultas.Controls.Add(Me.cboEstadoMan)
        Me.exgruConsultas.Controls.Add(Me.fecPropiedad)
        Me.exgruConsultas.Controls.Add(Me.Etiqueta47)
        Me.exgruConsultas.Controls.Add(Me.verIndActivoFijo)
        Me.exgruConsultas.Controls.Add(Me.txtPlaca)
        Me.exgruConsultas.Controls.Add(Me.verIndProrrateo)
        Me.exgruConsultas.Controls.Add(Me.Etiqueta2)
        Me.exgruConsultas.Controls.Add(Me.verIndPropiedad)
        Me.exgruConsultas.Controls.Add(Me.txtPlacaAntigua)
        Me.exgruConsultas.Controls.Add(Me.Etiqueta41)
        Me.exgruConsultas.Controls.Add(Me.cboFlota)
        Me.exgruConsultas.Controls.Add(Me.UltraLabel8)
        Me.exgruConsultas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exgruConsultas.Location = New System.Drawing.Point(30, 3)
        Me.exgruConsultas.Name = "exgruConsultas"
        Me.exgruConsultas.Size = New System.Drawing.Size(1150, 91)
        Me.exgruConsultas.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance151.BackColor = System.Drawing.Color.Transparent
        Appearance151.ForeColor = System.Drawing.Color.Navy
        Appearance151.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance151
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(112, 62)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(55, 18)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Estado:"
        '
        'cboEstadoMan
        '
        Appearance152.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoMan.Appearance = Appearance152
        Me.cboEstadoMan.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboEstadoMan.DisplayMember = "Nombre"
        Me.cboEstadoMan.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboEstadoMan.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboEstadoMan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoMan.ForeColor = System.Drawing.Color.Black
        Me.cboEstadoMan.Location = New System.Drawing.Point(170, 60)
        Me.cboEstadoMan.Name = "cboEstadoMan"
        Me.cboEstadoMan.Size = New System.Drawing.Size(194, 21)
        Me.cboEstadoMan.TabIndex = 11
        Me.cboEstadoMan.ValueMember = "Id"
        '
        'fecPropiedad
        '
        Me.fecPropiedad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecPropiedad.Location = New System.Drawing.Point(456, 9)
        Me.fecPropiedad.Name = "fecPropiedad"
        Me.fecPropiedad.Size = New System.Drawing.Size(104, 21)
        Me.fecPropiedad.TabIndex = 4
        '
        'Etiqueta47
        '
        Me.Etiqueta47.AutoSize = True
        Me.Etiqueta47.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta47.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta47.Location = New System.Drawing.Point(370, 12)
        Me.Etiqueta47.Name = "Etiqueta47"
        Me.Etiqueta47.Size = New System.Drawing.Size(83, 16)
        Me.Etiqueta47.TabIndex = 5
        Me.Etiqueta47.Text = "F.Propiedad:"
        '
        'verIndActivoFijo
        '
        Appearance153.ForeColor = System.Drawing.Color.Navy
        Me.verIndActivoFijo.Appearance = Appearance153
        Me.verIndActivoFijo.AutoSize = True
        Me.verIndActivoFijo.BackColor = System.Drawing.Color.Transparent
        Me.verIndActivoFijo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndActivoFijo.Location = New System.Drawing.Point(487, 61)
        Me.verIndActivoFijo.Name = "verIndActivoFijo"
        Me.verIndActivoFijo.Size = New System.Drawing.Size(73, 18)
        Me.verIndActivoFijo.TabIndex = 7
        Me.verIndActivoFijo.Text = "Activo Fijo"
        '
        'txtPlaca
        '
        Appearance154.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlaca.Appearance = Appearance154
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlaca.Location = New System.Drawing.Point(170, 26)
        Me.txtPlaca.MaxLength = 9
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(115, 31)
        Me.txtPlaca.TabIndex = 1
        '
        'verIndProrrateo
        '
        Appearance155.ForeColor = System.Drawing.Color.Navy
        Me.verIndProrrateo.Appearance = Appearance155
        Me.verIndProrrateo.AutoSize = True
        Me.verIndProrrateo.BackColor = System.Drawing.Color.Transparent
        Me.verIndProrrateo.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndProrrateo.Location = New System.Drawing.Point(393, 61)
        Me.verIndProrrateo.Name = "verIndProrrateo"
        Me.verIndProrrateo.Size = New System.Drawing.Size(68, 18)
        Me.verIndProrrateo.TabIndex = 6
        Me.verIndProrrateo.Text = "Prorrateo"
        '
        'Etiqueta2
        '
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(181, 2)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(92, 22)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "N° PLACA:"
        '
        'verIndPropiedad
        '
        Appearance156.ForeColor = System.Drawing.Color.Navy
        Me.verIndPropiedad.Appearance = Appearance156
        Me.verIndPropiedad.AutoSize = True
        Me.verIndPropiedad.BackColor = System.Drawing.Color.Transparent
        Me.verIndPropiedad.BackColorInternal = System.Drawing.Color.Transparent
        Me.verIndPropiedad.Location = New System.Drawing.Point(393, 37)
        Me.verIndPropiedad.Name = "verIndPropiedad"
        Me.verIndPropiedad.Size = New System.Drawing.Size(167, 18)
        Me.verIndPropiedad.TabIndex = 5
        Me.verIndPropiedad.Text = "Propio Empresa / Situacional"
        '
        'txtPlacaAntigua
        '
        Appearance157.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlacaAntigua.Appearance = Appearance157
        Me.txtPlacaAntigua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaAntigua.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPlacaAntigua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlacaAntigua.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPlacaAntigua.Location = New System.Drawing.Point(11, 56)
        Me.txtPlacaAntigua.MaxLength = 9
        Me.txtPlacaAntigua.Name = "txtPlacaAntigua"
        Me.txtPlacaAntigua.Size = New System.Drawing.Size(90, 24)
        Me.txtPlacaAntigua.TabIndex = 2
        '
        'Etiqueta41
        '
        Me.Etiqueta41.AutoSize = True
        Me.Etiqueta41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta41.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta41.Location = New System.Drawing.Point(11, 36)
        Me.Etiqueta41.Name = "Etiqueta41"
        Me.Etiqueta41.Size = New System.Drawing.Size(91, 18)
        Me.Etiqueta41.TabIndex = 2
        Me.Etiqueta41.Text = "Placa Anterior:"
        '
        'cboFlota
        '
        Appearance158.ForeColor = System.Drawing.Color.Black
        Me.cboFlota.Appearance = Appearance158
        Me.cboFlota.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboFlota.DisplayMember = "Nombre"
        Me.cboFlota.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboFlota.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboFlota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlota.ForeColor = System.Drawing.Color.Black
        Me.cboFlota.Location = New System.Drawing.Point(568, 58)
        Me.cboFlota.Name = "cboFlota"
        Me.cboFlota.Size = New System.Drawing.Size(200, 21)
        Me.cboFlota.TabIndex = 8
        Me.cboFlota.ValueMember = "Id"
        '
        'UltraLabel8
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Appearance159.ForeColor = System.Drawing.Color.Navy
        Appearance159.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance159
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel8.Location = New System.Drawing.Point(571, 37)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(109, 18)
        Me.UltraLabel8.TabIndex = 10
        Me.UltraLabel8.Text = "Flota Asignada:"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.wbrConsultaVehicular)
        Me.UltraTabPageControl10.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1183, 565)
        '
        'wbrConsultaVehicular
        '
        Me.wbrConsultaVehicular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbrConsultaVehicular.Location = New System.Drawing.Point(0, 61)
        Me.wbrConsultaVehicular.MinimumSize = New System.Drawing.Size(10, 10)
        Me.wbrConsultaVehicular.Name = "wbrConsultaVehicular"
        Me.wbrConsultaVehicular.Size = New System.Drawing.Size(1183, 504)
        Me.wbrConsultaVehicular.TabIndex = 1
        '
        'UltraExpandableGroupBox7
        '
        Appearance160.BackColor = System.Drawing.Color.White
        Appearance160.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance160
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(1183, 61)
        Me.UltraExpandableGroupBox7.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(1183, 61)
        Me.UltraExpandableGroupBox7.TabIndex = 0
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.btnObtenerDatos)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.btnEnviarPlaca)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label35)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label34)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label33)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label32)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label31)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.Label30)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboModeloSunarp)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboPropietario)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtDescripcionDetalle)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.cboTipoCarroceriaSunarp)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtSerieMotor)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtSerieChasis)
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.txtColor)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(1177, 55)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'btnObtenerDatos
        '
        Me.btnObtenerDatos.Location = New System.Drawing.Point(1040, 30)
        Me.btnObtenerDatos.Name = "btnObtenerDatos"
        Me.btnObtenerDatos.Size = New System.Drawing.Size(90, 25)
        Me.btnObtenerDatos.TabIndex = 9
        Me.btnObtenerDatos.TabStop = False
        Me.btnObtenerDatos.Text = "Sunarp Web"
        Me.btnObtenerDatos.UseVisualStyleBackColor = True
        '
        'btnEnviarPlaca
        '
        Me.btnEnviarPlaca.Location = New System.Drawing.Point(1040, 2)
        Me.btnEnviarPlaca.Name = "btnEnviarPlaca"
        Me.btnEnviarPlaca.Size = New System.Drawing.Size(90, 25)
        Me.btnEnviarPlaca.TabIndex = 8
        Me.btnEnviarPlaca.TabStop = False
        Me.btnEnviarPlaca.Text = "Enviar Placa"
        Me.btnEnviarPlaca.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label35.Location = New System.Drawing.Point(479, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(59, 13)
        Me.Label35.TabIndex = 257
        Me.Label35.Text = "Propietario"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label34.Location = New System.Drawing.Point(239, 37)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(84, 13)
        Me.Label34.TabIndex = 256
        Me.Label34.Text = "Tipo Carrocería:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label33.Location = New System.Drawing.Point(278, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(45, 13)
        Me.Label33.TabIndex = 255
        Me.Label33.Text = "Modelo:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label32.Location = New System.Drawing.Point(587, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(36, 13)
        Me.Label32.TabIndex = 254
        Me.Label32.Text = "Color:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label31.Location = New System.Drawing.Point(6, 32)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(81, 13)
        Me.Label31.TabIndex = 253
        Me.Label31.Text = "N° Serie Motor:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label30.Location = New System.Drawing.Point(3, 8)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 13)
        Me.Label30.TabIndex = 252
        Me.Label30.Text = "N° Serie Chasis:"
        '
        'cboModeloSunarp
        '
        Appearance161.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModeloSunarp.Appearance = Appearance161
        Me.cboModeloSunarp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboModeloSunarp.DisplayMember = "Nombre"
        Me.cboModeloSunarp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModeloSunarp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboModeloSunarp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModeloSunarp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboModeloSunarp.Location = New System.Drawing.Point(323, 8)
        Me.cboModeloSunarp.Name = "cboModeloSunarp"
        Me.cboModeloSunarp.Size = New System.Drawing.Size(150, 21)
        Me.cboModeloSunarp.TabIndex = 4
        Me.cboModeloSunarp.ValueMember = "Id"
        '
        'cboPropietario
        '
        Me.cboPropietario.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance162.BackColor = System.Drawing.SystemColors.Window
        Appearance162.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPropietario.DisplayLayout.Appearance = Appearance162
        Me.cboPropietario.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPropietario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance163.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance163.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance163.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance163.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPropietario.DisplayLayout.GroupByBox.Appearance = Appearance163
        Appearance164.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPropietario.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance164
        Me.cboPropietario.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance165.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance165.BackColor2 = System.Drawing.SystemColors.Control
        Appearance165.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance165.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPropietario.DisplayLayout.GroupByBox.PromptAppearance = Appearance165
        Me.cboPropietario.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPropietario.DisplayLayout.MaxRowScrollRegions = 1
        Appearance166.BackColor = System.Drawing.SystemColors.Window
        Appearance166.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPropietario.DisplayLayout.Override.ActiveCellAppearance = Appearance166
        Appearance167.BackColor = System.Drawing.SystemColors.Window
        Me.cboPropietario.DisplayLayout.Override.CardAreaAppearance = Appearance167
        Me.cboPropietario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPropietario.DisplayLayout.Override.CellPadding = 0
        Me.cboPropietario.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance168.BackColor = System.Drawing.SystemColors.Control
        Appearance168.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance168.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance168.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance168.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPropietario.DisplayLayout.Override.GroupByRowAppearance = Appearance168
        Appearance169.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPropietario.DisplayLayout.Override.TemplateAddRowAppearance = Appearance169
        Me.cboPropietario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPropietario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPropietario.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPropietario.DisplayMember = "Nombre"
        Me.cboPropietario.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboPropietario.Location = New System.Drawing.Point(479, 32)
        Me.cboPropietario.Name = "cboPropietario"
        Me.cboPropietario.Size = New System.Drawing.Size(300, 23)
        Me.cboPropietario.TabIndex = 6
        Me.cboPropietario.ValueMember = "Id"
        '
        'txtDescripcionDetalle
        '
        Appearance170.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionDetalle.Appearance = Appearance170
        Me.txtDescripcionDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionDetalle.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcionDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionDetalle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcionDetalle.Location = New System.Drawing.Point(785, 5)
        Me.txtDescripcionDetalle.MaxLength = 500
        Me.txtDescripcionDetalle.Multiline = True
        Me.txtDescripcionDetalle.Name = "txtDescripcionDetalle"
        Me.txtDescripcionDetalle.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionDetalle.Size = New System.Drawing.Size(250, 50)
        Me.txtDescripcionDetalle.TabIndex = 7
        '
        'cboTipoCarroceriaSunarp
        '
        Appearance171.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCarroceriaSunarp.Appearance = Appearance171
        Me.cboTipoCarroceriaSunarp.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoCarroceriaSunarp.DisplayMember = "Nombre"
        Me.cboTipoCarroceriaSunarp.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarroceriaSunarp.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoCarroceriaSunarp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCarroceriaSunarp.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboTipoCarroceriaSunarp.Location = New System.Drawing.Point(323, 32)
        Me.cboTipoCarroceriaSunarp.Name = "cboTipoCarroceriaSunarp"
        Me.cboTipoCarroceriaSunarp.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoCarroceriaSunarp.TabIndex = 5
        Me.cboTipoCarroceriaSunarp.ValueMember = "Id"
        '
        'txtSerieMotor
        '
        Appearance172.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieMotor.Appearance = Appearance172
        Me.txtSerieMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieMotor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieMotor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieMotor.Location = New System.Drawing.Point(87, 32)
        Me.txtSerieMotor.Name = "txtSerieMotor"
        Me.txtSerieMotor.Size = New System.Drawing.Size(150, 20)
        Me.txtSerieMotor.TabIndex = 2
        '
        'txtSerieChasis
        '
        Appearance173.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieChasis.Appearance = Appearance173
        Me.txtSerieChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieChasis.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSerieChasis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerieChasis.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSerieChasis.Location = New System.Drawing.Point(87, 8)
        Me.txtSerieChasis.Name = "txtSerieChasis"
        Me.txtSerieChasis.Size = New System.Drawing.Size(150, 20)
        Me.txtSerieChasis.TabIndex = 1
        '
        'txtColor
        '
        Appearance174.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtColor.Appearance = Appearance174
        Me.txtColor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColor.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtColor.Location = New System.Drawing.Point(629, 5)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(150, 21)
        Me.txtColor.TabIndex = 3
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.UltraExpandableGroupBox8)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1183, 565)
        '
        'UltraExpandableGroupBox8
        '
        Appearance175.BackColor = System.Drawing.Color.White
        Appearance175.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox8.ContentAreaAppearance = Appearance175
        Me.UltraExpandableGroupBox8.Controls.Add(Me.UltraExpandableGroupBoxPanel8)
        Me.UltraExpandableGroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBox8.ExpandedSize = New System.Drawing.Size(1183, 565)
        Me.UltraExpandableGroupBox8.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.None
        Me.UltraExpandableGroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox8.Name = "UltraExpandableGroupBox8"
        Me.UltraExpandableGroupBox8.Size = New System.Drawing.Size(1183, 565)
        Me.UltraExpandableGroupBox8.TabIndex = 0
        Me.UltraExpandableGroupBox8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel8
        '
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.tabs)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboTipoCarroceria)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta35)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboClasificacionISL)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta37)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboPilotoAsignado)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta77)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboRutaAsignada)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta76)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboModalidad)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta75)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboEmpresaGPS)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboTomaFuerza)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboBonificacion)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboSuspensionNeumatica)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboTipoNeumatico)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta69)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta68)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.txtTarjetaCombustible)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta67)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta66)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta65)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta64)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboCombustible)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta8)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta7)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboConfiguracionGrafica)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numNroAsientos)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta9)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta45)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta23)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numNroPasajero)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numLlantasRepuesto)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta46)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numCapacidadTanque)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numEjes)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta22)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta14)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta17)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta36)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta16)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta15)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numAncho)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numRuedas)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta21)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numLargo)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.cboConfiguracionMTC)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numCargaUtil)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numAltura)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numCubicaje)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.txtNroMTC)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numPesoNeto)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta11)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.numTara)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta44)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta13)
        Me.UltraExpandableGroupBoxPanel8.Controls.Add(Me.Etiqueta18)
        Me.UltraExpandableGroupBoxPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel8.Location = New System.Drawing.Point(3, 3)
        Me.UltraExpandableGroupBoxPanel8.Name = "UltraExpandableGroupBoxPanel8"
        Me.UltraExpandableGroupBoxPanel8.Size = New System.Drawing.Size(1177, 559)
        Me.UltraExpandableGroupBoxPanel8.TabIndex = 0
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.UltraTabSharedControlsPage4)
        Me.tabs.Controls.Add(Me.tabSeguros)
        Me.tabs.Controls.Add(Me.tabPlacas)
        Me.tabs.Controls.Add(Me.tabDispositivos)
        Me.tabs.Controls.Add(Me.tabBonificacion)
        Me.tabs.Controls.Add(Me.tabFlota)
        Me.tabs.Controls.Add(Me.tabEquipos)
        Me.tabs.Controls.Add(Me.tabDocumentos)
        Me.tabs.Controls.Add(Me.tabEstados)
        Me.tabs.Controls.Add(Me.TabTarjetasCovisol)
        Me.tabs.Controls.Add(Me.UltraTabPageControl1)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabs.Location = New System.Drawing.Point(0, 231)
        Me.tabs.Name = "tabs"
        Me.tabs.SharedControlsPage = Me.UltraTabSharedControlsPage4
        Me.tabs.Size = New System.Drawing.Size(1177, 328)
        Me.tabs.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.VisualStudio2005
        Me.tabs.TabIndex = 0
        UltraTab13.TabPage = Me.tabSeguros
        UltraTab13.Text = "Seguros"
        UltraTab14.TabPage = Me.tabPlacas
        UltraTab14.Text = "Placas"
        UltraTab8.TabPage = Me.tabEstados
        UltraTab8.Text = "Estados"
        UltraTab15.TabPage = Me.tabDispositivos
        UltraTab15.Text = "Dispositivos"
        UltraTab16.TabPage = Me.tabBonificacion
        UltraTab16.Text = "Bonificacion"
        UltraTab17.TabPage = Me.tabFlota
        UltraTab17.Text = "Flota"
        UltraTab18.TabPage = Me.tabEquipos
        UltraTab18.Text = "Equipos"
        UltraTab19.TabPage = Me.tabDocumentos
        UltraTab19.Text = "Documentos"
        UltraTab9.TabPage = Me.TabTarjetasCovisol
        UltraTab9.Text = "Tarjetas Covisol"
        UltraTab9.Visible = False
        UltraTab10.TabPage = Me.UltraTabPageControl1
        UltraTab10.Text = "Mantenimiento"
        Me.tabs.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab13, UltraTab14, UltraTab8, UltraTab15, UltraTab16, UltraTab17, UltraTab18, UltraTab19, UltraTab9, UltraTab10})
        Me.tabs.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Standard
        '
        'UltraTabSharedControlsPage4
        '
        Me.UltraTabSharedControlsPage4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage4.Name = "UltraTabSharedControlsPage4"
        Me.UltraTabSharedControlsPage4.Size = New System.Drawing.Size(1175, 307)
        '
        'cboTipoCarroceria
        '
        Me.cboTipoCarroceria.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCarroceria.Location = New System.Drawing.Point(338, 194)
        Me.cboTipoCarroceria.Name = "cboTipoCarroceria"
        Me.cboTipoCarroceria.Size = New System.Drawing.Size(150, 22)
        Me.cboTipoCarroceria.TabIndex = 53
        '
        'Etiqueta35
        '
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(251, 198)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(84, 15)
        Me.Etiqueta35.TabIndex = 54
        Me.Etiqueta35.Text = "Tipo Carroceria:"
        '
        'cboClasificacionISL
        '
        Me.cboClasificacionISL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClasificacionISL.Location = New System.Drawing.Point(88, 194)
        Me.cboClasificacionISL.Name = "cboClasificacionISL"
        Me.cboClasificacionISL.Size = New System.Drawing.Size(150, 22)
        Me.cboClasificacionISL.TabIndex = 51
        '
        'Etiqueta37
        '
        Me.Etiqueta37.AutoSize = True
        Me.Etiqueta37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta37.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta37.Location = New System.Drawing.Point(25, 197)
        Me.Etiqueta37.Name = "Etiqueta37"
        Me.Etiqueta37.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta37.TabIndex = 52
        Me.Etiqueta37.Text = "Clasf. EMP:"
        '
        'cboPilotoAsignado
        '
        Me.cboPilotoAsignado.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance176.BackColor = System.Drawing.SystemColors.Window
        Appearance176.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboPilotoAsignado.DisplayLayout.Appearance = Appearance176
        Me.cboPilotoAsignado.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboPilotoAsignado.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance177.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance177.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance177.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance177.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPilotoAsignado.DisplayLayout.GroupByBox.Appearance = Appearance177
        Appearance178.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPilotoAsignado.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance178
        Me.cboPilotoAsignado.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance179.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance179.BackColor2 = System.Drawing.SystemColors.Control
        Appearance179.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance179.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboPilotoAsignado.DisplayLayout.GroupByBox.PromptAppearance = Appearance179
        Me.cboPilotoAsignado.DisplayLayout.MaxColScrollRegions = 1
        Me.cboPilotoAsignado.DisplayLayout.MaxRowScrollRegions = 1
        Appearance180.BackColor = System.Drawing.SystemColors.Window
        Appearance180.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboPilotoAsignado.DisplayLayout.Override.ActiveCellAppearance = Appearance180
        Appearance181.BackColor = System.Drawing.SystemColors.Window
        Me.cboPilotoAsignado.DisplayLayout.Override.CardAreaAppearance = Appearance181
        Me.cboPilotoAsignado.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboPilotoAsignado.DisplayLayout.Override.CellPadding = 0
        Me.cboPilotoAsignado.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance182.BackColor = System.Drawing.SystemColors.Control
        Appearance182.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance182.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance182.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance182.BorderColor = System.Drawing.SystemColors.Window
        Me.cboPilotoAsignado.DisplayLayout.Override.GroupByRowAppearance = Appearance182
        Appearance183.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboPilotoAsignado.DisplayLayout.Override.TemplateAddRowAppearance = Appearance183
        Me.cboPilotoAsignado.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboPilotoAsignado.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboPilotoAsignado.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboPilotoAsignado.DisplayMember = "Nombre"
        Me.cboPilotoAsignado.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboPilotoAsignado.Location = New System.Drawing.Point(88, 169)
        Me.cboPilotoAsignado.Name = "cboPilotoAsignado"
        Me.cboPilotoAsignado.Size = New System.Drawing.Size(400, 23)
        Me.cboPilotoAsignado.TabIndex = 14
        Me.cboPilotoAsignado.ValueMember = "Id"
        '
        'Etiqueta77
        '
        Me.Etiqueta77.AutoSize = True
        Me.Etiqueta77.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta77.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta77.Location = New System.Drawing.Point(-1, 173)
        Me.Etiqueta77.Name = "Etiqueta77"
        Me.Etiqueta77.Size = New System.Drawing.Size(84, 15)
        Me.Etiqueta77.TabIndex = 14
        Me.Etiqueta77.Text = "Responsable V.:"
        '
        'cboRutaAsignada
        '
        Me.cboRutaAsignada.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboRutaAsignada.Location = New System.Drawing.Point(338, 146)
        Me.cboRutaAsignada.Name = "cboRutaAsignada"
        Me.cboRutaAsignada.Size = New System.Drawing.Size(150, 22)
        Me.cboRutaAsignada.TabIndex = 13
        '
        'Etiqueta76
        '
        Me.Etiqueta76.AutoSize = True
        Me.Etiqueta76.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta76.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta76.Location = New System.Drawing.Point(256, 150)
        Me.Etiqueta76.Name = "Etiqueta76"
        Me.Etiqueta76.Size = New System.Drawing.Size(80, 15)
        Me.Etiqueta76.TabIndex = 25
        Me.Etiqueta76.Text = "Ruta Asignada:"
        '
        'cboModalidad
        '
        Me.cboModalidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboModalidad.Location = New System.Drawing.Point(88, 146)
        Me.cboModalidad.Name = "cboModalidad"
        Me.cboModalidad.Size = New System.Drawing.Size(150, 22)
        Me.cboModalidad.TabIndex = 12
        '
        'Etiqueta75
        '
        Me.Etiqueta75.AutoSize = True
        Me.Etiqueta75.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta75.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta75.Location = New System.Drawing.Point(25, 149)
        Me.Etiqueta75.Name = "Etiqueta75"
        Me.Etiqueta75.Size = New System.Drawing.Size(59, 15)
        Me.Etiqueta75.TabIndex = 12
        Me.Etiqueta75.Text = "Modalidad:"
        '
        'cboEmpresaGPS
        '
        Me.cboEmpresaGPS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Appearance184.BackColor = System.Drawing.SystemColors.Window
        Appearance184.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboEmpresaGPS.DisplayLayout.Appearance = Appearance184
        Me.cboEmpresaGPS.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cboEmpresaGPS.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance185.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance185.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance185.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance185.BorderColor = System.Drawing.SystemColors.Window
        Me.cboEmpresaGPS.DisplayLayout.GroupByBox.Appearance = Appearance185
        Appearance186.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboEmpresaGPS.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance186
        Me.cboEmpresaGPS.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance187.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance187.BackColor2 = System.Drawing.SystemColors.Control
        Appearance187.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance187.ForeColor = System.Drawing.SystemColors.GrayText
        Me.cboEmpresaGPS.DisplayLayout.GroupByBox.PromptAppearance = Appearance187
        Me.cboEmpresaGPS.DisplayLayout.MaxColScrollRegions = 1
        Me.cboEmpresaGPS.DisplayLayout.MaxRowScrollRegions = 1
        Appearance188.BackColor = System.Drawing.SystemColors.Window
        Appearance188.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboEmpresaGPS.DisplayLayout.Override.ActiveCellAppearance = Appearance188
        Appearance189.BackColor = System.Drawing.SystemColors.Window
        Me.cboEmpresaGPS.DisplayLayout.Override.CardAreaAppearance = Appearance189
        Me.cboEmpresaGPS.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cboEmpresaGPS.DisplayLayout.Override.CellPadding = 0
        Me.cboEmpresaGPS.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Appearance190.BackColor = System.Drawing.SystemColors.Control
        Appearance190.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance190.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance190.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance190.BorderColor = System.Drawing.SystemColors.Window
        Me.cboEmpresaGPS.DisplayLayout.Override.GroupByRowAppearance = Appearance190
        Appearance191.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboEmpresaGPS.DisplayLayout.Override.TemplateAddRowAppearance = Appearance191
        Me.cboEmpresaGPS.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cboEmpresaGPS.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboEmpresaGPS.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cboEmpresaGPS.DisplayMember = "Nombre"
        Me.cboEmpresaGPS.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2010
        Me.cboEmpresaGPS.Location = New System.Drawing.Point(88, 121)
        Me.cboEmpresaGPS.Name = "cboEmpresaGPS"
        Me.cboEmpresaGPS.Size = New System.Drawing.Size(400, 23)
        Me.cboEmpresaGPS.TabIndex = 11
        Me.cboEmpresaGPS.ValueMember = "Id"
        '
        'cboTomaFuerza
        '
        Me.cboTomaFuerza.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        ValueListItem13.DataValue = "ValueListItem0"
        ValueListItem13.DisplayText = "SI"
        ValueListItem14.DataValue = "ValueListItem1"
        ValueListItem14.DisplayText = "NO"
        Me.cboTomaFuerza.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem13, ValueListItem14})
        Me.cboTomaFuerza.Location = New System.Drawing.Point(337, 98)
        Me.cboTomaFuerza.Name = "cboTomaFuerza"
        Me.cboTomaFuerza.Size = New System.Drawing.Size(100, 22)
        Me.cboTomaFuerza.TabIndex = 10
        '
        'cboBonificacion
        '
        Me.cboBonificacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        ValueListItem11.DataValue = "ValueListItem0"
        ValueListItem11.DisplayText = "900"
        ValueListItem12.DataValue = "ValueListItem1"
        ValueListItem12.DisplayText = "1200"
        ValueListItem30.DataValue = "ValueListItem2"
        ValueListItem30.DisplayText = "1250"
        ValueListItem31.DataValue = "ValueListItem3"
        ValueListItem31.DisplayText = "1800"
        ValueListItem33.DataValue = "ValueListItem4"
        ValueListItem33.DisplayText = "2500"
        ValueListItem34.DataValue = "ValueListItem5"
        ValueListItem34.DisplayText = "NO APLICA"
        Me.cboBonificacion.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem11, ValueListItem12, ValueListItem30, ValueListItem31, ValueListItem33, ValueListItem34})
        Me.cboBonificacion.Location = New System.Drawing.Point(88, 98)
        Me.cboBonificacion.Name = "cboBonificacion"
        Me.cboBonificacion.Size = New System.Drawing.Size(100, 22)
        Me.cboBonificacion.TabIndex = 9
        '
        'cboSuspensionNeumatica
        '
        Me.cboSuspensionNeumatica.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        ValueListItem15.DataValue = "ValueListItem0"
        ValueListItem15.DisplayText = "BOLSAS"
        ValueListItem16.DataValue = "ValueListItem1"
        ValueListItem16.DisplayText = "MUELLES"
        ValueListItem17.DataValue = "ValueListItem2"
        ValueListItem17.DisplayText = "NO APLICA"
        Me.cboSuspensionNeumatica.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem15, ValueListItem16, ValueListItem17})
        Me.cboSuspensionNeumatica.Location = New System.Drawing.Point(337, 75)
        Me.cboSuspensionNeumatica.Name = "cboSuspensionNeumatica"
        Me.cboSuspensionNeumatica.Size = New System.Drawing.Size(150, 22)
        Me.cboSuspensionNeumatica.TabIndex = 8
        '
        'cboTipoNeumatico
        '
        Me.cboTipoNeumatico.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        ValueListItem18.DataValue = "ValueListItem0"
        ValueListItem18.DisplayText = "BALON"
        ValueListItem19.DataValue = "ValueListItem1"
        ValueListItem19.DisplayText = "DUAL"
        Me.cboTipoNeumatico.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem18, ValueListItem19})
        Me.cboTipoNeumatico.Location = New System.Drawing.Point(88, 74)
        Me.cboTipoNeumatico.Name = "cboTipoNeumatico"
        Me.cboTipoNeumatico.Size = New System.Drawing.Size(100, 22)
        Me.cboTipoNeumatico.TabIndex = 7
        '
        'Etiqueta69
        '
        Me.Etiqueta69.AutoSize = True
        Me.Etiqueta69.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta69.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta69.Location = New System.Drawing.Point(11, 124)
        Me.Etiqueta69.Name = "Etiqueta69"
        Me.Etiqueta69.Size = New System.Drawing.Size(75, 15)
        Me.Etiqueta69.TabIndex = 10
        Me.Etiqueta69.Text = "Empresa GPS:"
        '
        'Etiqueta68
        '
        Me.Etiqueta68.AutoSize = True
        Me.Etiqueta68.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta68.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta68.Location = New System.Drawing.Point(244, 10)
        Me.Etiqueta68.Name = "Etiqueta68"
        Me.Etiqueta68.Size = New System.Drawing.Size(92, 15)
        Me.Etiqueta68.TabIndex = 16
        Me.Etiqueta68.Text = "N° Tarjeta Comb:"
        '
        'txtTarjetaCombustible
        '
        Appearance192.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTarjetaCombustible.Appearance = Appearance192
        Me.txtTarjetaCombustible.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTarjetaCombustible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTarjetaCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTarjetaCombustible.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtTarjetaCombustible.Location = New System.Drawing.Point(337, 7)
        Me.txtTarjetaCombustible.Name = "txtTarjetaCombustible"
        Me.txtTarjetaCombustible.Size = New System.Drawing.Size(150, 20)
        Me.txtTarjetaCombustible.TabIndex = 2
        '
        'Etiqueta67
        '
        Me.Etiqueta67.AutoSize = True
        Me.Etiqueta67.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta67.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta67.Location = New System.Drawing.Point(212, 102)
        Me.Etiqueta67.Name = "Etiqueta67"
        Me.Etiqueta67.Size = New System.Drawing.Size(123, 15)
        Me.Etiqueta67.TabIndex = 23
        Me.Etiqueta67.Text = "Conexion Toma Fuerza:"
        '
        'Etiqueta66
        '
        Me.Etiqueta66.AutoSize = True
        Me.Etiqueta66.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta66.Location = New System.Drawing.Point(17, 101)
        Me.Etiqueta66.Name = "Etiqueta66"
        Me.Etiqueta66.Size = New System.Drawing.Size(68, 15)
        Me.Etiqueta66.TabIndex = 8
        Me.Etiqueta66.Text = "Bonificacion:"
        '
        'Etiqueta65
        '
        Me.Etiqueta65.AutoSize = True
        Me.Etiqueta65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta65.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta65.Location = New System.Drawing.Point(213, 79)
        Me.Etiqueta65.Name = "Etiqueta65"
        Me.Etiqueta65.Size = New System.Drawing.Size(121, 15)
        Me.Etiqueta65.TabIndex = 21
        Me.Etiqueta65.Text = "Suspension Neumatica:"
        '
        'Etiqueta64
        '
        Me.Etiqueta64.AutoSize = True
        Me.Etiqueta64.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta64.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta64.Location = New System.Drawing.Point(-2, 78)
        Me.Etiqueta64.Name = "Etiqueta64"
        Me.Etiqueta64.Size = New System.Drawing.Size(86, 15)
        Me.Etiqueta64.TabIndex = 6
        Me.Etiqueta64.Text = "Tipo Neumatico:"
        '
        'cboCombustible
        '
        Appearance193.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCombustible.Appearance = Appearance193
        Me.cboCombustible.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboCombustible.DisplayMember = "Nombre"
        Me.cboCombustible.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCombustible.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboCombustible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCombustible.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboCombustible.Location = New System.Drawing.Point(88, 5)
        Me.cboCombustible.Name = "cboCombustible"
        Me.cboCombustible.Size = New System.Drawing.Size(150, 21)
        Me.cboCombustible.TabIndex = 1
        Me.cboCombustible.ValueMember = "Id"
        '
        'Etiqueta8
        '
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(521, 9)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(39, 15)
        Me.Etiqueta8.TabIndex = 27
        Me.Etiqueta8.Text = "Ancho:"
        '
        'Etiqueta7
        '
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(523, 32)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta7.TabIndex = 29
        Me.Etiqueta7.Text = "Altura:"
        '
        'cboConfiguracionGrafica
        '
        Appearance194.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboConfiguracionGrafica.Appearance = Appearance194
        Me.cboConfiguracionGrafica.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConfiguracionGrafica.DisplayMember = "Nombre"
        Me.cboConfiguracionGrafica.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConfiguracionGrafica.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConfiguracionGrafica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConfiguracionGrafica.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboConfiguracionGrafica.Location = New System.Drawing.Point(88, 28)
        Me.cboConfiguracionGrafica.Name = "cboConfiguracionGrafica"
        Me.cboConfiguracionGrafica.Size = New System.Drawing.Size(150, 21)
        Me.cboConfiguracionGrafica.TabIndex = 3
        Me.cboConfiguracionGrafica.ValueMember = "Id"
        '
        'numNroAsientos
        '
        Appearance195.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numNroAsientos.Appearance = Appearance195
        Me.numNroAsientos.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numNroAsientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNroAsientos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numNroAsientos.Location = New System.Drawing.Point(562, 169)
        Me.numNroAsientos.MaskInput = "n"
        Me.numNroAsientos.Name = "numNroAsientos"
        Me.numNroAsientos.NullText = "0"
        Me.numNroAsientos.Size = New System.Drawing.Size(25, 21)
        Me.numNroAsientos.TabIndex = 25
        '
        'Etiqueta9
        '
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(675, 9)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(36, 15)
        Me.Etiqueta9.TabIndex = 36
        Me.Etiqueta9.Text = "Largo:"
        '
        'Etiqueta45
        '
        Me.Etiqueta45.AutoSize = True
        Me.Etiqueta45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta45.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta45.Location = New System.Drawing.Point(494, 173)
        Me.Etiqueta45.Name = "Etiqueta45"
        Me.Etiqueta45.Size = New System.Drawing.Size(66, 15)
        Me.Etiqueta45.TabIndex = 48
        Me.Etiqueta45.Text = "N° Asientos:"
        '
        'Etiqueta23
        '
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(274, 56)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(60, 15)
        Me.Etiqueta23.TabIndex = 18
        Me.Etiqueta23.Text = "Conf. MTC:"
        '
        'numNroPasajero
        '
        Appearance196.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numNroPasajero.Appearance = Appearance196
        Me.numNroPasajero.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numNroPasajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNroPasajero.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numNroPasajero.Location = New System.Drawing.Point(712, 169)
        Me.numNroPasajero.MaskInput = "nn"
        Me.numNroPasajero.Name = "numNroPasajero"
        Me.numNroPasajero.NullText = "0"
        Me.numNroPasajero.Size = New System.Drawing.Size(25, 21)
        Me.numNroPasajero.TabIndex = 26
        '
        'numLlantasRepuesto
        '
        Appearance197.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numLlantasRepuesto.Appearance = Appearance197
        Me.numLlantasRepuesto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numLlantasRepuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLlantasRepuesto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numLlantasRepuesto.Location = New System.Drawing.Point(712, 146)
        Me.numLlantasRepuesto.MaskInput = "n"
        Me.numLlantasRepuesto.Name = "numLlantasRepuesto"
        Me.numLlantasRepuesto.NullText = "0"
        Me.numLlantasRepuesto.Size = New System.Drawing.Size(25, 21)
        Me.numLlantasRepuesto.TabIndex = 24
        '
        'Etiqueta46
        '
        Me.Etiqueta46.AutoSize = True
        Me.Etiqueta46.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta46.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta46.Location = New System.Drawing.Point(638, 173)
        Me.Etiqueta46.Name = "Etiqueta46"
        Me.Etiqueta46.Size = New System.Drawing.Size(72, 15)
        Me.Etiqueta46.TabIndex = 50
        Me.Etiqueta46.Text = "N° Pasajeros:"
        '
        'numCapacidadTanque
        '
        Appearance198.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCapacidadTanque.Appearance = Appearance198
        Me.numCapacidadTanque.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCapacidadTanque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCapacidadTanque.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCapacidadTanque.Location = New System.Drawing.Point(713, 74)
        Me.numCapacidadTanque.MaskInput = "{LOC}nnnn.nn"
        Me.numCapacidadTanque.Name = "numCapacidadTanque"
        Me.numCapacidadTanque.NullText = "0.00"
        Me.numCapacidadTanque.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCapacidadTanque.Size = New System.Drawing.Size(50, 21)
        Me.numCapacidadTanque.TabIndex = 22
        '
        'numEjes
        '
        Appearance199.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numEjes.Appearance = Appearance199
        Me.numEjes.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numEjes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEjes.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numEjes.Location = New System.Drawing.Point(462, 52)
        Me.numEjes.MaskInput = "n"
        Me.numEjes.Name = "numEjes"
        Me.numEjes.NullText = "0"
        Me.numEjes.Size = New System.Drawing.Size(25, 21)
        Me.numEjes.TabIndex = 6
        '
        'Etiqueta22
        '
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(14, 9)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(69, 15)
        Me.Etiqueta22.TabIndex = 0
        Me.Etiqueta22.Text = "Combustible:"
        '
        'Etiqueta14
        '
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(415, 56)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(45, 15)
        Me.Etiqueta14.TabIndex = 20
        Me.Etiqueta14.Text = "N° Ejes:"
        '
        'Etiqueta17
        '
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(600, 150)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(111, 15)
        Me.Etiqueta17.TabIndex = 46
        Me.Etiqueta17.Text = "N° Ruedas Repuesto:"
        '
        'Etiqueta36
        '
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(655, 78)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(56, 15)
        Me.Etiqueta36.TabIndex = 42
        Me.Etiqueta36.Text = "C.Tanque:"
        '
        'Etiqueta16
        '
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(525, 55)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta16.TabIndex = 32
        Me.Etiqueta16.Text = "C.Util:"
        '
        'Etiqueta15
        '
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(499, 150)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(61, 15)
        Me.Etiqueta15.TabIndex = 44
        Me.Etiqueta15.Text = "N° Ruedas:"
        '
        'numAncho
        '
        Appearance200.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAncho.Appearance = Appearance200
        Me.numAncho.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAncho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAncho.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAncho.Location = New System.Drawing.Point(563, 5)
        Me.numAncho.MaskInput = "{LOC}nnnn.nn"
        Me.numAncho.Name = "numAncho"
        Me.numAncho.NullText = "0.00"
        Me.numAncho.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numAncho.Size = New System.Drawing.Size(50, 21)
        Me.numAncho.TabIndex = 15
        '
        'numRuedas
        '
        Appearance201.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numRuedas.Appearance = Appearance201
        Me.numRuedas.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numRuedas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numRuedas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numRuedas.Location = New System.Drawing.Point(562, 146)
        Me.numRuedas.MaskInput = "nn"
        Me.numRuedas.Name = "numRuedas"
        Me.numRuedas.NullText = "0"
        Me.numRuedas.Size = New System.Drawing.Size(25, 21)
        Me.numRuedas.TabIndex = 23
        '
        'Etiqueta21
        '
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(12, 32)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(73, 15)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Conf. Grafica:"
        '
        'numLargo
        '
        Appearance202.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numLargo.Appearance = Appearance202
        Me.numLargo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numLargo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numLargo.Location = New System.Drawing.Point(713, 5)
        Me.numLargo.MaskInput = "{LOC}nnnn.nn"
        Me.numLargo.Name = "numLargo"
        Me.numLargo.NullText = "0.00"
        Me.numLargo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numLargo.Size = New System.Drawing.Size(50, 21)
        Me.numLargo.TabIndex = 16
        '
        'cboConfiguracionMTC
        '
        Appearance203.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboConfiguracionMTC.Appearance = Appearance203
        Me.cboConfiguracionMTC.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboConfiguracionMTC.DisplayMember = "Nombre"
        Me.cboConfiguracionMTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboConfiguracionMTC.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboConfiguracionMTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConfiguracionMTC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cboConfiguracionMTC.Location = New System.Drawing.Point(337, 52)
        Me.cboConfiguracionMTC.Name = "cboConfiguracionMTC"
        Me.cboConfiguracionMTC.Size = New System.Drawing.Size(50, 21)
        Me.cboConfiguracionMTC.TabIndex = 5
        Me.cboConfiguracionMTC.ValueMember = "Id"
        '
        'numCargaUtil
        '
        Appearance204.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCargaUtil.Appearance = Appearance204
        Me.numCargaUtil.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCargaUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCargaUtil.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCargaUtil.Location = New System.Drawing.Point(563, 51)
        Me.numCargaUtil.MaskInput = "{LOC}nnnnn.nn"
        Me.numCargaUtil.Name = "numCargaUtil"
        Me.numCargaUtil.NullText = "0.00"
        Me.numCargaUtil.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCargaUtil.Size = New System.Drawing.Size(50, 21)
        Me.numCargaUtil.TabIndex = 19
        '
        'numAltura
        '
        Appearance205.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAltura.Appearance = Appearance205
        Me.numAltura.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAltura.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numAltura.Location = New System.Drawing.Point(563, 28)
        Me.numAltura.MaskInput = "{LOC}nnnn.nn"
        Me.numAltura.Name = "numAltura"
        Me.numAltura.NullText = "0.00"
        Me.numAltura.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numAltura.Size = New System.Drawing.Size(50, 21)
        Me.numAltura.TabIndex = 17
        '
        'numCubicaje
        '
        Appearance206.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCubicaje.Appearance = Appearance206
        Me.numCubicaje.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numCubicaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCubicaje.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numCubicaje.Location = New System.Drawing.Point(563, 74)
        Me.numCubicaje.MaskInput = "{LOC}nnnn.nn"
        Me.numCubicaje.Name = "numCubicaje"
        Me.numCubicaje.NullText = "0.00"
        Me.numCubicaje.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numCubicaje.Size = New System.Drawing.Size(50, 21)
        Me.numCubicaje.TabIndex = 21
        '
        'txtNroMTC
        '
        Appearance207.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroMTC.Appearance = Appearance207
        Me.txtNroMTC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroMTC.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroMTC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroMTC.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNroMTC.Location = New System.Drawing.Point(88, 51)
        Me.txtNroMTC.Name = "txtNroMTC"
        Me.txtNroMTC.Size = New System.Drawing.Size(150, 21)
        Me.txtNroMTC.TabIndex = 4
        '
        'numPesoNeto
        '
        Appearance208.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numPesoNeto.Appearance = Appearance208
        Me.numPesoNeto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPesoNeto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numPesoNeto.Location = New System.Drawing.Point(713, 51)
        Me.numPesoNeto.MaskInput = "{LOC}nnnnn.nn"
        Me.numPesoNeto.Name = "numPesoNeto"
        Me.numPesoNeto.NullText = "0.00"
        Me.numPesoNeto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPesoNeto.Size = New System.Drawing.Size(50, 21)
        Me.numPesoNeto.TabIndex = 20
        '
        'Etiqueta11
        '
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(40, 55)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(47, 15)
        Me.Etiqueta11.TabIndex = 4
        Me.Etiqueta11.Text = "N° MTC:"
        '
        'numTara
        '
        Appearance209.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numTara.Appearance = Appearance209
        Me.numTara.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTara.ForeColor = System.Drawing.Color.MidnightBlue
        Me.numTara.Location = New System.Drawing.Point(713, 28)
        Me.numTara.MaskInput = "{LOC}nnnnn.nn"
        Me.numTara.Name = "numTara"
        Me.numTara.NullText = "0.00"
        Me.numTara.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numTara.Size = New System.Drawing.Size(50, 21)
        Me.numTara.TabIndex = 18
        '
        'Etiqueta44
        '
        Me.Etiqueta44.AutoSize = True
        Me.Etiqueta44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta44.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta44.Location = New System.Drawing.Point(670, 55)
        Me.Etiqueta44.Name = "Etiqueta44"
        Me.Etiqueta44.Size = New System.Drawing.Size(41, 15)
        Me.Etiqueta44.TabIndex = 40
        Me.Etiqueta44.Text = "P.Neto:"
        '
        'Etiqueta13
        '
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(680, 32)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(31, 15)
        Me.Etiqueta13.TabIndex = 38
        Me.Etiqueta13.Text = "Tara:"
        '
        'Etiqueta18
        '
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(509, 78)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(50, 15)
        Me.Etiqueta18.TabIndex = 34
        Me.Etiqueta18.Text = "Cubicaje:"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.tabLista)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1185, 588)
        '
        'tabLista
        '
        Me.tabLista.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabLista.Controls.Add(Me.tapVehiculo)
        Me.tabLista.Controls.Add(Me.tapSituacional)
        Me.tabLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLista.Location = New System.Drawing.Point(0, 0)
        Me.tabLista.Name = "tabLista"
        Me.tabLista.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabLista.Size = New System.Drawing.Size(1185, 588)
        Me.tabLista.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabLista.TabIndex = 0
        UltraTab6.TabPage = Me.tapVehiculo
        UltraTab6.Text = "Unidades"
        UltraTab7.TabPage = Me.tapSituacional
        UltraTab7.Text = "Situacional"
        UltraTab7.Visible = False
        Me.tabLista.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab7})
        Me.tabLista.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1183, 565)
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.tabDatosUnidades)
        Me.utpDetalle.Location = New System.Drawing.Point(1, 22)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1185, 588)
        '
        'tabDatosUnidades
        '
        Me.tabDatosUnidades.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.tabDatosUnidades.Controls.Add(Me.UltraTabPageControl9)
        Me.tabDatosUnidades.Controls.Add(Me.UltraTabPageControl10)
        Me.tabDatosUnidades.Controls.Add(Me.UltraTabPageControl11)
        Me.tabDatosUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatosUnidades.Location = New System.Drawing.Point(0, 0)
        Me.tabDatosUnidades.Name = "tabDatosUnidades"
        Me.tabDatosUnidades.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.tabDatosUnidades.Size = New System.Drawing.Size(1185, 588)
        Me.tabDatosUnidades.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tabDatosUnidades.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl9
        UltraTab3.Text = "General"
        UltraTab4.TabPage = Me.UltraTabPageControl10
        UltraTab4.Text = "Sunarp"
        UltraTab5.TabPage = Me.UltraTabPageControl11
        UltraTab5.Text = "Datos"
        Me.tabDatosUnidades.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5})
        Me.tabDatosUnidades.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1183, 565)
        '
        'Colores1
        '
        Me.Colores1.Color = System.Drawing.Color.Red
        Me.Colores1.Location = New System.Drawing.Point(85, 7)
        Me.Colores1.Name = "Colores1"
        Me.Colores1.Size = New System.Drawing.Size(43, 21)
        Me.Colores1.TabIndex = 1
        Me.Colores1.Text = "Red"
        '
        'Colores2
        '
        Me.Colores2.Color = System.Drawing.Color.White
        Me.Colores2.Location = New System.Drawing.Point(210, 30)
        Me.Colores2.Name = "Colores2"
        Me.Colores2.Size = New System.Drawing.Size(44, 21)
        Me.Colores2.TabIndex = 7
        Me.Colores2.Text = "White"
        '
        'Colores3
        '
        Me.Colores3.Location = New System.Drawing.Point(210, 7)
        Me.Colores3.Name = "Colores3"
        Me.Colores3.Size = New System.Drawing.Size(43, 21)
        Me.Colores3.TabIndex = 5
        Me.Colores3.Text = "Control"
        '
        'Etiqueta28
        '
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta28.Location = New System.Drawing.Point(13, 34)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(69, 14)
        Me.Etiqueta28.TabIndex = 2
        Me.Etiqueta28.Text = "En Venta (1):"
        '
        'Colores4
        '
        Me.Colores4.Color = System.Drawing.Color.Khaki
        Me.Colores4.Location = New System.Drawing.Point(85, 30)
        Me.Colores4.Name = "Colores4"
        Me.Colores4.Size = New System.Drawing.Size(44, 21)
        Me.Colores4.TabIndex = 3
        Me.Colores4.Text = "Khaki"
        '
        'Etiqueta29
        '
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta29.Location = New System.Drawing.Point(142, 11)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(64, 14)
        Me.Etiqueta29.TabIndex = 4
        Me.Etiqueta29.Text = "Vendido (2):"
        '
        'Etiqueta30
        '
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta30.Location = New System.Drawing.Point(135, 34)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta30.TabIndex = 6
        Me.Etiqueta30.Text = "Operativo (3):"
        '
        'Etiqueta31
        '
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta31.Location = New System.Drawing.Point(2, 11)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(79, 14)
        Me.Etiqueta31.TabIndex = 0
        Me.Etiqueta31.Text = "Siniestrado (0):"
        '
        'tcVehiculo
        '
        Me.tcVehiculo.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcVehiculo.Controls.Add(Me.UltraTabPageControl7)
        Me.tcVehiculo.Controls.Add(Me.utpDetalle)
        Me.tcVehiculo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcVehiculo.Location = New System.Drawing.Point(0, 0)
        Me.tcVehiculo.Name = "tcVehiculo"
        Me.tcVehiculo.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcVehiculo.Size = New System.Drawing.Size(1187, 611)
        Me.tcVehiculo.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.tcVehiculo.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl7
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.utpDetalle
        UltraTab2.Text = "Mantenimiento"
        Me.tcVehiculo.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcVehiculo.TabStop = False
        Me.tcVehiculo.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1185, 588)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_Vehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1187, 611)
        Me.Controls.Add(Me.tcVehiculo)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Vehiculo"
        Me.Text = "Vehículo"
        Me.tabSeguros.ResumeLayout(False)
        CType(Me.griDocumentoVehicular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDocumentoVehicular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPlacas.ResumeLayout(False)
        Me.tabPlacas.PerformLayout()
        CType(Me.griHistorialPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspPlacas.ResumeLayout(False)
        Me.tspPlacas.PerformLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.txtHisPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEstados.ResumeLayout(False)
        Me.tabEstados.PerformLayout()
        CType(Me.griEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdEstados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspEstados.ResumeLayout(False)
        Me.tspEstados.PerformLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cboVehiculoEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDispositivos.ResumeLayout(False)
        Me.tabDispositivos.PerformLayout()
        CType(Me.griDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspDispositivos.ResumeLayout(False)
        Me.tspDispositivos.PerformLayout()
        CType(Me.agDispositivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agDispositivos.ResumeLayout(False)
        Me.agDispositivos.PerformLayout()
        CType(Me.txtDispCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDispNroSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBonificacion.ResumeLayout(False)
        Me.tabBonificacion.PerformLayout()
        CType(Me.griBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbBonificacion.ResumeLayout(False)
        Me.tsbBonificacion.PerformLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.verBoniIndicador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoniObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoniPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoniNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFlota.ResumeLayout(False)
        Me.tabFlota.PerformLayout()
        CType(Me.griAsignacionFlota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAsignacionFlota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbFlota.ResumeLayout(False)
        Me.tsbFlota.PerformLayout()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.txtObservacionAsigFlota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAsignacionFlota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEquipos.ResumeLayout(False)
        CType(Me.griAsignacionEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdAsignacionEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDocumentos.ResumeLayout(False)
        CType(Me.gridControlDoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odImgDocVeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.ColoresVencido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTarjetasCovisol.ResumeLayout(False)
        Me.TabTarjetasCovisol.PerformLayout()
        CType(Me.griTarjetaCovisol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsTarjetaCovisol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspTarjetasCovisol.ResumeLayout(False)
        Me.tspTarjetasCovisol.PerformLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.cmbCovEmpProp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCovGlosa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCovTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsProyMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapVehiculo.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContextual1.ResumeLayout(False)
        CType(Me.ogdVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.PerformLayout()
        CType(Me.ColorBloque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlotaMasiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloFuncionalMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expExcesoEnMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expExcesoEnMantenimiento.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.PerformLayout()
        CType(Me.Color1Dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color7DiasAMas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color4a7Dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Color2a3Dias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox4.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.PerformLayout()
        CType(Me.ColorDuplicado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPrestada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPerdida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorOficina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorSiniestrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorOperativo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorVendido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEnVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapSituacional.ResumeLayout(False)
        CType(Me.griListaSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.cboFlotaSituacional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gruexEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruexEstado.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel9.PerformLayout()
        CType(Me.OficinaSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DuplicadoSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrestadaSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerdidaSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerdidaTotalSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeBajaSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtrosSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlquiladoSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiniestradoSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OperativoSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendidoSit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnVentaSit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.ndHorometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndOdometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroEquipoMovil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAñoModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAñoFabricacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModeloFuncional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.exgruConsultas.ResumeLayout(False)
        Me.exgruConsultas.PerformLayout()
        CType(Me.cboEstadoMan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndActivoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndProrrateo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verIndPropiedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlacaAntigua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFlota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.PerformLayout()
        CType(Me.cboModeloSunarp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCarroceriaSunarp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieMotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieChasis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox8.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel8.PerformLayout()
        CType(Me.tabs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabs.ResumeLayout(False)
        CType(Me.cboTipoCarroceria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClasificacionISL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPilotoAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRutaAsignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpresaGPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTomaFuerza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBonificacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSuspensionNeumatica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoNeumatico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarjetaCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCombustible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConfiguracionGrafica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNroAsientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNroPasajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLlantasRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCapacidadTanque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEjes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAncho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRuedas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboConfiguracionMTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCargaUtil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAltura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCubicaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroMTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPesoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.tabLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLista.ResumeLayout(False)
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.tabDatosUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatosUnidades.ResumeLayout(False)
        CType(Me.Colores1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Colores4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcVehiculo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcVehiculo As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents txtSerieMotor As ISL.Controles.Texto
    Friend WithEvents txtPlaca As ISL.Controles.Texto
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents txtColor As ISL.Controles.Texto
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoVehiculo As ISL.Controles.ComboMaestros
    Friend WithEvents cboModelo As ISL.Controles.ComboMaestros
    Friend WithEvents txtNroMTC As ISL.Controles.Texto
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents numAltura As ISL.Controles.NumeroDecimal
    Friend WithEvents numLargo As ISL.Controles.NumeroDecimal
    Friend WithEvents numAncho As ISL.Controles.NumeroDecimal
    Friend WithEvents numAñoFabricacion As ISL.Controles.NumeroEntero
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents numLlantasRepuesto As ISL.Controles.Numero
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents numCargaUtil As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents numRuedas As ISL.Controles.Numero
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents numEjes As ISL.Controles.Numero
    Friend WithEvents numTara As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents numCubicaje As ISL.Controles.NumeroDecimal
    Friend WithEvents cboMarca As ISL.Controles.ComboMaestros
    Friend WithEvents cboModeloFuncional As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents cboConfiguracionMTC As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents cboCombustible As ISL.Controles.ComboMaestros
    Friend WithEvents cboConfiguracionGrafica As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents ogdVehiculo As ISL.Controles.OrigenDatos

    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents MenuContextual1 As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSerieChasis As ISL.Controles.Texto
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents numCapacidadTanque As ISL.Controles.NumeroDecimal
    Friend WithEvents txtPlacaAntigua As ISL.Controles.Texto
    Friend WithEvents Etiqueta41 As ISL.Controles.Etiqueta
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents agDispositivos As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents cboTipoDispositivo As ISL.Controles.ComboMaestros
    Friend WithEvents txtDispCantidad As ISL.Controles.NumeroDecimal
    Friend WithEvents txtDispNroSerie As ISL.Controles.Texto
    Friend WithEvents ogdDocumentoVehicular As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdDispositivo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ogdPlaca As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griDocumentoVehicular As ISL.Controles.Grilla
    Friend WithEvents griHistorialPlaca As ISL.Controles.Grilla
    Friend WithEvents griDispositivo As ISL.Controles.Grilla
    Friend WithEvents cboFlota As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtId As ISL.Controles.Texto
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ColorSiniestrado As ISL.Controles.Colores
    Friend WithEvents ColorVendido As ISL.Controles.Colores
    Friend WithEvents ColorEnVenta As ISL.Controles.Colores
    Friend WithEvents Etiqueta55 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta51 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta54 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta52 As ISL.Controles.Etiqueta
    Friend WithEvents ColorOperativo As ISL.Controles.Colores
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents exgruConsultas As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ndHorometro As ISL.Controles.NumeroDecimal
    Friend WithEvents ndOdometro As ISL.Controles.NumeroDecimal
    Friend WithEvents UltraExpandableGroupBox4 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents txtObservacion As ISL.Controles.Texto
    Friend WithEvents btnConsultarDisponibles As Infragistics.Win.Misc.UltraButton
    Friend WithEvents expExcesoEnMantenimiento As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents Color1Dia As ISL.Controles.Colores
    Friend WithEvents Color7DiasAMas As ISL.Controles.Colores
    Friend WithEvents Color4a7Dias As ISL.Controles.Colores
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents Color2a3Dias As ISL.Controles.Colores
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta53 As ISL.Controles.Etiqueta
    Friend WithEvents Colores1 As ISL.Controles.Colores
    Friend WithEvents Colores2 As ISL.Controles.Colores
    Friend WithEvents Colores3 As ISL.Controles.Colores
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents Colores4 As ISL.Controles.Colores
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents btnGuardar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents cboModeloFuncionalMasivo As ISL.Controles.ComboMaestros
    Friend WithEvents cboFlotaMasiva As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents ColorBloque As ISL.Controles.Colores
    Friend WithEvents griBonificacion As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents txtBoniNumero As ISL.Controles.NumeroDecimal
    Friend WithEvents ogdBonificacion As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtBoniObservacion As ISL.Controles.Texto
    Friend WithEvents txtBoniPorcentaje As ISL.Controles.NumeroDecimal
    Friend WithEvents verBoniIndicador As ISL.Controles.Chequear
    Friend WithEvents numAñoModelo As ISL.Controles.NumeroEntero
    Friend WithEvents numPesoNeto As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta44 As ISL.Controles.Etiqueta
    Friend WithEvents numNroAsientos As ISL.Controles.Numero
    Friend WithEvents Etiqueta45 As ISL.Controles.Etiqueta
    Friend WithEvents numNroPasajero As ISL.Controles.Numero
    Friend WithEvents Etiqueta46 As ISL.Controles.Etiqueta
    Friend WithEvents verIndPropiedad As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIndActivoFijo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents verIndProrrateo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents Etiqueta47 As ISL.Controles.Etiqueta
    Friend WithEvents griAsignacionFlota As ISL.Controles.Grilla
    Friend WithEvents ogdAsignacionFlota As ISL.Controles.OrigenDatos
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents txtObservacionAsigFlota As ISL.Controles.Texto
    Friend WithEvents cboAsignacionFlota As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents griAsignacionEquipos As ISL.Controles.Grilla
    Friend WithEvents ogdAsignacionEquipos As ISL.Controles.OrigenDatos
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents gridControlDoc As ISL.Controles.Grilla
    Friend WithEvents odImgDocVeh As ISL.Controles.OrigenDatos
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresVencido As ISL.Controles.Colores
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents ColoresPorVencer As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents tabDatosUnidades As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Colores5 As ISL.Controles.Colores
    Friend WithEvents Etiqueta61 As ISL.Controles.Etiqueta
    Friend WithEvents Colores6 As ISL.Controles.Colores
    Friend WithEvents Etiqueta62 As ISL.Controles.Etiqueta
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents tabs As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage4 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tabSeguros As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabPlacas As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabDispositivos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabBonificacion As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabFlota As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabEquipos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabDocumentos As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox8 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel8 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents upbFoto As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents btnExaminar As ISL.Controles.Boton
    Friend WithEvents Etiqueta69 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta68 As ISL.Controles.Etiqueta
    Friend WithEvents txtTarjetaCombustible As ISL.Controles.Texto
    Friend WithEvents Etiqueta67 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta66 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta65 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta64 As ISL.Controles.Etiqueta
    Friend WithEvents tabLista As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents tapVehiculo As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tapSituacional As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListaSituacional As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents cboTipoCarroceriaSunarp As ISL.Controles.ComboMaestros
    Friend WithEvents txtNroEquipoMovil As ISL.Controles.Texto
    Friend WithEvents txtDescripcionDetalle As ISL.Controles.Texto
    Friend WithEvents cboTomaFuerza As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboBonificacion As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboSuspensionNeumatica As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboTipoNeumatico As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cboPropietario As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cboEmpresaGPS As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents btnBorrar As ISL.Controles.Boton
    Friend WithEvents cboModeloSunarp As ISL.Controles.ComboMaestros
    Friend WithEvents tabEstados As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griEstados As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents ogdEstados As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents btnDescargarJpg As ISL.Controles.Boton
    Friend WithEvents imagenGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents cboRutaAsignada As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta76 As ISL.Controles.Etiqueta
    Friend WithEvents cboModalidad As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta75 As ISL.Controles.Etiqueta
    Friend WithEvents cboPilotoAsignado As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Etiqueta77 As ISL.Controles.Etiqueta
    Friend WithEvents gruexEstado As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel9 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents OtrosSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta78 As ISL.Controles.Etiqueta
    Friend WithEvents AlquiladoSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta79 As ISL.Controles.Etiqueta
    Friend WithEvents SiniestradoSit As ISL.Controles.Colores
    Friend WithEvents OperativoSit As ISL.Controles.Colores
    Friend WithEvents VendidoSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta80 As ISL.Controles.Etiqueta
    Friend WithEvents EnVentaSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta82 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta83 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta84 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents fecPropiedad As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHisInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecDispEnicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicioAsigFlota As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecInicioEstado As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabTarjetasCovisol As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpCovFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents griTarjetaCovisol As ISL.Controles.Grilla
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents udsTarjetaCovisol As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents txtCovGlosa As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtCovTarjeta As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmbCovEmpProp As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents tspTarjetasCovisol As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarTarj As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarTarj As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents verMotriz As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tspPlacas As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarPlaca As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarPlaca As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtHisPlaca As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtObservacionEstado As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents tspEstados As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarEstado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarEstado As System.Windows.Forms.ToolStripButton
    Friend WithEvents tspDispositivos As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarDispositivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarDispositivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbBonificacion As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarBonificacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarBonificacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents tsbFlota As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregarFlota As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbQuitarFlota As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griMantenimiento As ISL.Controles.Grilla
    Friend WithEvents udsProyMantenimiento As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents wbrConsultaVehicular As System.Windows.Forms.WebBrowser
    Friend WithEvents btnObtenerDatos As System.Windows.Forms.Button
    Friend WithEvents btnEnviarPlaca As System.Windows.Forms.Button
    Friend WithEvents udsSituacional As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents Colores8 As ISL.Controles.Colores
    Friend WithEvents Colores7 As ISL.Controles.Colores
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents PerdidaTotalSit As ISL.Controles.Colores
    Friend WithEvents DeBajaSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cboFlotaSituacional As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboEstadoMan As ISL.Controles.ComboMaestros
    Friend WithEvents cboVehiculoEstado As ISL.Controles.ComboMaestros
    Friend WithEvents ColorDuplicado As ISL.Controles.Colores
    Friend WithEvents ColorPrestada As ISL.Controles.Colores
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents ColorPerdida As ISL.Controles.Colores
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents ColorOficina As ISL.Controles.Colores
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents OficinaSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents DuplicadoSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents PrestadaSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents PerdidaSit As ISL.Controles.Colores
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents cboTipoCarroceria As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents cboClasificacionISL As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Etiqueta37 As ISL.Controles.Etiqueta

End Class
