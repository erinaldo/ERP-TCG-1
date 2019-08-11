<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VehiculoPilotoOperacion
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVP")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndHistorial")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividadNegocio")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVP")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndHistorial")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoAdicional")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCrea")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModifica")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividadNegocio")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoAdicional")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotal")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCrea")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModifica")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCrea")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VehiculoPilotoOperacion))
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo2 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Costo Fijo", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoFijo")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividadNegocio")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCliente")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Monto")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoFijo")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actual")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVP")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndHistorial")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCrea")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
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
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionProceso")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdViaje")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionDetalle")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Viaje")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Dia")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NTransporte")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCarga")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KM")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Factor")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoViaje")
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flete")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionProceso")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdViaje")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionDetalle")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Viaje")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Dia")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NTransporte")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoCarga")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KM")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Factor")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoViaje")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flete")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacionProceso")
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn233 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn234 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaNorte")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn235 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CuentaSur")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn236 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoFijo")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn237 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn238 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn239 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NViaje")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn240 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CFxViaje")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn241 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Norte")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn242 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Sur")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn243 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Total")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn244 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VariableXViaje")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn245 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoViaje")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn246 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoAdicional")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn256 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoTotal")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn257 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Adicional01")
        Dim UltraGridColumn258 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Adicional02")
        Dim UltraGridColumn259 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn260 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn261 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn262 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn263 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn278 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Guardar")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacionProceso")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaNorte")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CuentaSur")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoFijo")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Valor")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Semana")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NViaje")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CFxViaje")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Norte")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Sur")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Total")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("VariableXViaje")
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoViaje")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoAdicional")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostoTotal")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Adicional01")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Adicional02")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Observacion")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Guardar")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn279 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOperacion")
        Dim UltraGridColumn280 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn281 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn282 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOrigen")
        Dim UltraGridColumn283 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Origen")
        Dim UltraGridColumn284 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdDestino")
        Dim UltraGridColumn285 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Destino")
        Dim UltraGridColumn286 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEscala")
        Dim UltraGridColumn287 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeVacio")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn288 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdPiloto")
        Dim UltraGridColumn289 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Piloto")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn290 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCopiloto")
        Dim UltraGridColumn291 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Copiloto")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn292 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAyudante")
        Dim UltraGridColumn293 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTracto")
        Dim UltraGridColumn294 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tracto")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn295 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCarreta")
        Dim UltraGridColumn315 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carreta")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn316 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEstado")
        Dim UltraGridColumn318 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, False)
        Dim UltraGridColumn320 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn321 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn333 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn334 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Operacion")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn335 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Estado")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn336 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Escala")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn337 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ayudante")
        Dim UltraGridColumn338 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoVehiculo")
        Dim UltraGridColumn339 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn340 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cliente")
        Dim UltraGridColumn341 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndEscala")
        Dim UltraGridColumn342 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GlosaEscala")
        Dim UltraGridColumn343 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Carga")
        Dim UltraGridColumn344 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleP")
        Dim UltraGridColumn345 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleC")
        Dim UltraGridColumn346 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DisponibleA")
        Dim UltraGridColumn347 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModifica")
        Dim UltraGridColumn348 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioSeguimiento")
        Dim UltraGridColumn349 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaOrigen")
        Dim UltraGridColumn350 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaOrigen")
        Dim UltraGridColumn351 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaDestino")
        Dim UltraGridColumn352 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SalidaDestino")
        Dim UltraGridColumn353 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Flota")
        Dim UltraGridColumn354 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaOperaciones")
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn355 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncidenciaSeguimiento")
        Dim UltraGridColumn356 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Turno")
        Dim UltraGridColumn357 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DiaNoche")
        Dim UltraGridColumn358 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PesoToneladas")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn359 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TotalFlete")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn360 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona")
        Dim UltraGridColumn361 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoOrigen")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn362 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmTractoDestino")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn363 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaOrigen")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn364 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("KmCarretaDestino")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn365 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Tesoreria")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn366 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaMaterial")
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn367 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndFecha")
        Dim UltraGridColumn368 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PorcentajeFlete")
        Dim UltraGridColumn369 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoComplejoOrigen")
        Dim UltraGridColumn370 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CargaOrigen")
        Dim UltraGridColumn371 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoCargaOrigen")
        Dim UltraGridColumn372 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ImpresionGuiaOrigen")
        Dim UltraGridColumn373 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LlegadaAproximadaDestino")
        Dim UltraGridColumn374 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IngresoDestino")
        Dim UltraGridColumn375 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("DescargaDestino")
        Dim UltraGridColumn376 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TerminoDescargaDestino")
        Dim UltraGridColumn377 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn378 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FleteUnitario")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn379 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IncluyeIgv")
        Dim UltraGridColumn380 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Capacidad")
        Dim UltraGridColumn381 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndCarga")
        Dim UltraGridColumn382 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ViajeRetorno")
        Dim UltraGridColumn383 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Produccion")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("Operacion")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOperacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Id", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Codigo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdOrigen", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Origen", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdDestino", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Destino", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEscala", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeVacio", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdPiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Piloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCopiloto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Copiloto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdAyudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTracto", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tracto", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo17 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdCarreta", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo18 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carreta", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo19 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdEstado", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo20 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Fecha", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo21 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo22 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Seleccion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo23 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioCreacion", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo24 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Operacion", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo25 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Estado", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo26 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Escala", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo27 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Ayudante", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo28 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IdTipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo29 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TipoVehiculo", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo30 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cliente", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo31 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo32 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "GlosaEscala", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo33 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Carga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo34 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleP", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo35 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleC", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo36 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DisponibleA", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo37 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioModifica", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo38 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UsuarioSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo39 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo40 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo41 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo42 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "SalidaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo43 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Flota", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo44 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaOperaciones", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo45 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncidenciaSeguimiento", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo46 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Turno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo47 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DiaNoche", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo48 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PesoToneladas", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo49 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TotalFlete", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo50 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Zona", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo51 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo52 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmTractoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo53 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo54 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "KmCarretaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo55 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Tesoreria", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo56 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaMaterial", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo57 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndFecha", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo58 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PorcentajeFlete", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo59 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoComplejoOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo60 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo61 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoCargaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo62 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ImpresionGuiaOrigen", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo63 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "LlegadaAproximadaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo64 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IngresoDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo65 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "DescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo66 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "TerminoDescargaDestino", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo67 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Cantidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo68 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "FleteUnitario", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo69 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IncluyeIgv", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo70 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Capacidad", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo71 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "IndCarga", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo72 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ViajeRetorno", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim RowLayoutColumnInfo73 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Produccion", -1, Infragistics.Win.DefaultableBoolean.[Default])
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOperacion")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOrigen")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Origen")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdDestino")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Destino")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEscala")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeVacio")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPiloto")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Piloto")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCopiloto")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Copiloto")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAyudante")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTracto")
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tracto")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCarreta")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carreta")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEstado")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Operacion")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Estado")
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Escala")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ayudante")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cliente")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndEscala")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("GlosaEscala")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Carga")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleP")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleC")
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DisponibleA")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModifica")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioSeguimiento")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaOrigen")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaOrigen")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaDestino")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SalidaDestino")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Flota")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaOperaciones")
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncidenciaSeguimiento")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Turno")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DiaNoche")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PesoToneladas")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TotalFlete")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Zona")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoOrigen")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmTractoDestino")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaOrigen")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("KmCarretaDestino")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Tesoreria")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaMaterial")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndFecha")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PorcentajeFlete")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoComplejoOrigen")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CargaOrigen")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoCargaOrigen")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ImpresionGuiaOrigen")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("LlegadaAproximadaDestino")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IngresoDestino")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("DescargaDestino")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TerminoDescargaDestino")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FleteUnitario")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IncluyeIgv")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Capacidad")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndCarga")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ViajeRetorno")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Produccion")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn384 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn385 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividadNegocio")
        Dim UltraGridColumn386 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente")
        Dim UltraGridColumn387 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn388 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn389 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostoFijo")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn390 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Semana")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn391 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Observacion")
        Dim UltraGridColumn392 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn393 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim UltraGridColumn394 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn395 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actual")
        Dim UltraGridColumn396 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolTipInfo1 As Infragistics.Win.UltraWinToolTip.UltraToolTipInfo = New Infragistics.Win.UltraWinToolTip.UltraToolTipInfo("Costo Fijo", Infragistics.Win.ToolTipImage.[Default], Nothing, Infragistics.Win.DefaultableBoolean.[Default])
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.Menu = New ISL.Controles.MenuContextual(Me.components)
        Me.Insert = New System.Windows.Forms.ToolStripMenuItem()
        Me.Update = New System.Windows.Forms.ToolStripMenuItem()
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdVehiculoPiloto = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griOPLista = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuProceso = New ISL.Controles.MenuContextual(Me.components)
        Me.NuevoInforme = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarInforme = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarInforme = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarInforme = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdOperacionProceso = New ISL.Controles.OrigenDatos(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.agrBusqueda = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtCostoFijoLista = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtCodigoSemanaLista = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.fecSemana = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraExpandableGroupBox2 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griTarifasDetalles = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.MenuZona = New ISL.Controles.MenuContextual(Me.components)
        Me.MZnuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MZactualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MZeliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ogdTarifasDetalles = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griVehiculoPiloto = New ISL.Controles.Grilla(Me.components)
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.grupoZona = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtMonto = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel36 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtSemana = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txtCostoFijo = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboZona = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtId = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTracto = New ISL.Controles.Combo(Me.components)
        Me.cboPiloto = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel28 = New Infragistics.Win.Misc.UltraLabel()
        Me.opcVehiculoPiloto = New ISL.Controles.Opciones(Me.components)
        Me.txtIndHistorial = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.verActual = New ISL.Controles.Chequear(Me.components)
        Me.fecFin = New ISL.Controles.Fecha(Me.components)
        Me.fecInicio = New ISL.Controles.Fecha(Me.components)
        Me.Etiqueta50 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnAgregar = New Infragistics.Win.Misc.UltraButton()
        Me.txtObservacion = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cboCliente = New ISL.Controles.ComboMaestros(Me.components)
        Me.cboActividadNegocio = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel34 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel38 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griViajesProceso = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdViajesProceso = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox6 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griTarifasProceso = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ogdTarifasProceso = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraExpandableGroupBox7 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel7 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griCargaOperacion = New ISL.Controles.Grilla(Me.components)
        Me.ogdViaje = New ISL.Controles.OrigenDatos(Me.components)
        Me.grupoCabeceraInformeRenting = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.UltraExpandableGroupBox3 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.griVariables = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraExpandableGroupBox1 = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.txtIdOperacionProceso = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtCostoFijoOP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.txtCodigoOP = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtObservacionOP = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.colorCambio = New ISL.Controles.Colores(Me.components)
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.btnListarViajesOP = New Infragistics.Win.Misc.UltraButton()
        Me.fecHasta = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel39 = New Infragistics.Win.Misc.UltraLabel()
        Me.decCostoTotalOP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.decSemanaOP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.fecDesde = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel41 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.decCostoAdicionalOP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboClienteOP = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.decTotalOP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboActividadNegocioOP = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboTractoOP = New ISL.Controles.Combo(Me.components)
        Me.cboTipoCargaOP = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        Me.VerFiltro = New ISL.Controles.Chequear(Me.components)
        Me.UltraTabPageControl7 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficListaVOP = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.utpDetalle = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ficMantenimiento = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.ficDemanda = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolTipManager1 = New Infragistics.Win.UltraWinToolTip.UltraToolTipManager(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.ogdVehiculoPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.griOPLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuProceso.SuspendLayout()
        CType(Me.ogdOperacionProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrBusqueda.SuspendLayout()
        CType(Me.txtCodigoSemanaLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox2.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.griTarifasDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuZona.SuspendLayout()
        CType(Me.ogdTarifasDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griVehiculoPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.grupoZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoZona.SuspendLayout()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opcVehiculoPiloto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.griViajesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdViajesProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox6.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.griTarifasProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdTarifasProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox7.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel7.SuspendLayout()
        CType(Me.griCargaOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ogdViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grupoCabeceraInformeRenting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoCabeceraInformeRenting.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox3.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.griVariables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraExpandableGroupBox1.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.txtIdOperacionProceso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacionOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboClienteOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboActividadNegocioOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTractoOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCargaOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl7.SuspendLayout()
        CType(Me.ficListaVOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficListaVOP.SuspendLayout()
        Me.utpDetalle.SuspendLayout()
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMantenimiento.SuspendLayout()
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficDemanda.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.griLista)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1344, 515)
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.Menu
        Me.griLista.DataSource = Me.ogdVehiculoPiloto
        Appearance1.BackColor = System.Drawing.Color.White
        Me.griLista.DisplayLayout.Appearance = Appearance1
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn93.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn93.Header.VisiblePosition = 0
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn94.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn94.Header.Caption = "Vehiculo"
        UltraGridColumn94.Header.VisiblePosition = 3
        UltraGridColumn94.Width = 75
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn95.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn95.Header.Caption = "Piloto"
        UltraGridColumn95.Header.VisiblePosition = 2
        UltraGridColumn95.Width = 200
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn96.Header.Caption = "Operacion"
        UltraGridColumn96.Header.VisiblePosition = 4
        UltraGridColumn96.Width = 150
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn97.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn97.Header.Caption = "Cliente"
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn97.Width = 250
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridColumn98.Width = 250
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn99.Header.VisiblePosition = 5
        UltraGridColumn99.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn99.Width = 70
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn100.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn100.Header.VisiblePosition = 6
        UltraGridColumn100.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn100.Width = 70
        UltraGridColumn101.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn101.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn101.Header.VisiblePosition = 7
        UltraGridColumn101.Width = 35
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn102.Header.Caption = "Historial"
        UltraGridColumn102.Header.VisiblePosition = 9
        UltraGridColumn102.Width = 35
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn103.Header.VisiblePosition = 10
        UltraGridColumn103.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn103.Width = 35
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn104.Header.VisiblePosition = 11
        UltraGridColumn104.Hidden = True
        UltraGridColumn104.Width = 100
        UltraGridColumn105.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn105.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn105.Header.VisiblePosition = 12
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 100
        UltraGridColumn106.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn106.Header.VisiblePosition = 13
        UltraGridColumn106.Hidden = True
        UltraGridColumn106.Width = 100
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griLista.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griLista.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(0, 0)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1344, 515)
        Me.griLista.TabIndex = 6
        Me.griLista.Tag = ""
        '
        'Menu
        '
        Me.Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.ForeColor = System.Drawing.Color.Black
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Insert, Me.Update, Me.Delete})
        Me.Menu.Name = "MenuContextual1"
        Me.Menu.Size = New System.Drawing.Size(121, 70)
        '
        'Insert
        '
        Me.Insert.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(120, 22)
        Me.Insert.Text = "Nuevo"
        Me.Insert.ToolTipText = "Insertar una nueva Pre-Demanda"
        '
        'Update
        '
        Me.Update.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(120, 22)
        Me.Update.Text = "Actualizar"
        Me.Update.ToolTipText = "Actualizar o modificar la Pre-Demanda seleccionada"
        '
        'Delete
        '
        Me.Delete.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(120, 22)
        Me.Delete.Text = "Eliminar"
        Me.Delete.ToolTipText = "Eliminar la Pre-Demanda seleccionada"
        '
        'ogdVehiculoPiloto
        '
        Me.ogdVehiculoPiloto.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.griOPLista)
        Me.UltraTabPageControl2.Controls.Add(Me.agrBusqueda)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraExpandableGroupBox2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1358, 515)
        '
        'griOPLista
        '
        Me.griOPLista.ContextMenuStrip = Me.MenuProceso
        Me.griOPLista.DataSource = Me.ogdOperacionProceso
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griOPLista.DisplayLayout.Appearance = Appearance2
        UltraGridColumn107.Header.VisiblePosition = 0
        UltraGridColumn107.Hidden = True
        UltraGridColumn108.Header.VisiblePosition = 1
        UltraGridColumn108.Width = 75
        UltraGridColumn109.Header.VisiblePosition = 2
        UltraGridColumn109.Hidden = True
        UltraGridColumn109.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn110.Header.VisiblePosition = 3
        UltraGridColumn110.Hidden = True
        UltraGridColumn110.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn111.Header.VisiblePosition = 4
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 6
        UltraGridColumn112.Hidden = True
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn113.CellAppearance = Appearance3
        UltraGridColumn113.Header.VisiblePosition = 5
        UltraGridColumn113.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn113.Width = 75
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn114.CellAppearance = Appearance4
        UltraGridColumn114.Header.VisiblePosition = 7
        UltraGridColumn114.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn114.Width = 75
        Appearance5.TextHAlignAsString = "Right"
        UltraGridColumn115.CellAppearance = Appearance5
        UltraGridColumn115.Header.Caption = "C.Adicional"
        UltraGridColumn115.Header.VisiblePosition = 8
        UltraGridColumn115.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn115.Width = 75
        Appearance6.TextHAlignAsString = "Right"
        UltraGridColumn116.CellAppearance = Appearance6
        UltraGridColumn116.Header.VisiblePosition = 9
        UltraGridColumn116.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn116.Width = 75
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn117.Header.VisiblePosition = 13
        UltraGridColumn117.Width = 200
        UltraGridColumn118.Header.Caption = "Estado"
        UltraGridColumn118.Header.VisiblePosition = 10
        UltraGridColumn119.Header.VisiblePosition = 11
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 12
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 14
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 15
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.Header.VisiblePosition = 16
        UltraGridColumn123.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123})
        Me.griOPLista.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griOPLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOPLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOPLista.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.griOPLista.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOPLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.griOPLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griOPLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griOPLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.griOPLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griOPLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griOPLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griOPLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griOPLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griOPLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griOPLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griOPLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griOPLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griOPLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griOPLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griOPLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griOPLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griOPLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griOPLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griOPLista.ImageList = Me.imagenes
        Me.griOPLista.Location = New System.Drawing.Point(0, 50)
        Me.griOPLista.Name = "griOPLista"
        Me.griOPLista.Size = New System.Drawing.Size(1058, 465)
        Me.griOPLista.TabIndex = 286
        Me.griOPLista.Text = "OPERACIONES RENTING SEMANA"
        '
        'MenuProceso
        '
        Me.MenuProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuProceso.ForeColor = System.Drawing.Color.Black
        Me.MenuProceso.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoInforme, Me.EditarInforme, Me.EliminarInforme, Me.VerArchivo, Me.EnviarInforme})
        Me.MenuProceso.Name = "MenuContextual1"
        Me.MenuProceso.Size = New System.Drawing.Size(170, 114)
        '
        'NuevoInforme
        '
        Me.NuevoInforme.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.NuevoInforme.Name = "NuevoInforme"
        Me.NuevoInforme.Size = New System.Drawing.Size(169, 22)
        Me.NuevoInforme.Text = "Nuevo"
        Me.NuevoInforme.ToolTipText = "Crear nuevo informe"
        '
        'EditarInforme
        '
        Me.EditarInforme.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.EditarInforme.Name = "EditarInforme"
        Me.EditarInforme.Size = New System.Drawing.Size(169, 22)
        Me.EditarInforme.Text = "Actualizar"
        Me.EditarInforme.ToolTipText = "Editar informe reportado"
        '
        'EliminarInforme
        '
        Me.EliminarInforme.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarInforme.Name = "EliminarInforme"
        Me.EliminarInforme.Size = New System.Drawing.Size(169, 22)
        Me.EliminarInforme.Text = "Eliminar"
        Me.EliminarInforme.ToolTipText = "Eliminar informe"
        '
        'VerArchivo
        '
        Me.VerArchivo.Image = Global.ISL.Win.My.Resources.Resources.Excel
        Me.VerArchivo.Name = "VerArchivo"
        Me.VerArchivo.Size = New System.Drawing.Size(169, 22)
        Me.VerArchivo.Text = "VerArchivo"
        Me.VerArchivo.ToolTipText = "Ver informe generado Semano"
        '
        'EnviarInforme
        '
        Me.EnviarInforme.Image = Global.ISL.Win.My.Resources.Resources.formatindentmore
        Me.EnviarInforme.Name = "EnviarInforme"
        Me.EnviarInforme.Size = New System.Drawing.Size(169, 22)
        Me.EnviarInforme.Text = "Enviar (Facturacion)"
        Me.EnviarInforme.ToolTipText = "Enviar Facturacion"
        '
        'ogdOperacionProceso
        '
        Me.ogdOperacionProceso.Band.Columns.AddRange(New Object() {UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31})
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
        'agrBusqueda
        '
        Appearance10.BackColor = System.Drawing.Color.White
        Appearance10.BackColor2 = System.Drawing.Color.White
        Me.agrBusqueda.ContentAreaAppearance = Appearance10
        Me.agrBusqueda.Controls.Add(Me.txtCostoFijoLista)
        Me.agrBusqueda.Controls.Add(Me.txtCodigoSemanaLista)
        Me.agrBusqueda.Controls.Add(Me.fecSemana)
        Me.agrBusqueda.Controls.Add(Me.UltraLabel13)
        Me.agrBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.agrBusqueda.Name = "agrBusqueda"
        Me.agrBusqueda.Size = New System.Drawing.Size(1058, 50)
        Me.agrBusqueda.TabIndex = 4
        Me.agrBusqueda.Tag = ""
        Me.agrBusqueda.Text = "BUSQUEDA"
        Me.agrBusqueda.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtCostoFijoLista
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.txtCostoFijoLista.Appearance = Appearance11
        Me.txtCostoFijoLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoFijoLista.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoFijoLista.InputMask = "{LOC}nnnnnnn.nn"
        Me.txtCostoFijoLista.Location = New System.Drawing.Point(253, 24)
        Me.txtCostoFijoLista.Name = "txtCostoFijoLista"
        Me.txtCostoFijoLista.NonAutoSizeHeight = 20
        Me.txtCostoFijoLista.Size = New System.Drawing.Size(80, 20)
        Me.txtCostoFijoLista.TabIndex = 270
        Me.txtCostoFijoLista.Text = "767.00"
        UltraToolTipInfo2.ToolTipText = "Costo Fijo"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtCostoFijoLista, UltraToolTipInfo2)
        '
        'txtCodigoSemanaLista
        '
        Me.txtCodigoSemanaLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoSemanaLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoSemanaLista.Location = New System.Drawing.Point(157, 23)
        Me.txtCodigoSemanaLista.Name = "txtCodigoSemanaLista"
        Me.txtCodigoSemanaLista.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigoSemanaLista.TabIndex = 269
        '
        'fecSemana
        '
        Me.fecSemana.DateTime = New Date(2014, 1, 2, 0, 0, 0, 0)
        Me.fecSemana.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecSemana.Location = New System.Drawing.Point(61, 23)
        Me.fecSemana.MaskInput = ""
        Me.fecSemana.Name = "fecSemana"
        Me.fecSemana.Size = New System.Drawing.Size(90, 21)
        Me.fecSemana.TabIndex = 50
        Me.fecSemana.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'UltraLabel13
        '
        Appearance129.BackColor = System.Drawing.Color.Transparent
        Appearance129.ForeColor = System.Drawing.Color.Navy
        Appearance129.TextVAlignAsString = "Middle"
        Me.UltraLabel13.Appearance = Appearance129
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel13.Location = New System.Drawing.Point(7, 27)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel13.TabIndex = 49
        Me.UltraLabel13.Text = "Semana:"
        '
        'UltraExpandableGroupBox2
        '
        Appearance130.BackColor = System.Drawing.Color.White
        Appearance130.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox2.ContentAreaAppearance = Appearance130
        Me.UltraExpandableGroupBox2.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.UltraExpandableGroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox2.ExpandedSize = New System.Drawing.Size(300, 515)
        Me.UltraExpandableGroupBox2.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox2.Location = New System.Drawing.Point(1058, 0)
        Me.UltraExpandableGroupBox2.Name = "UltraExpandableGroupBox2"
        Me.UltraExpandableGroupBox2.Size = New System.Drawing.Size(300, 515)
        Me.UltraExpandableGroupBox2.TabIndex = 2
        Me.UltraExpandableGroupBox2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.griTarifasDetalles)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(18, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(279, 509)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'griTarifasDetalles
        '
        Me.griTarifasDetalles.ContextMenuStrip = Me.MenuZona
        Me.griTarifasDetalles.DataSource = Me.ogdTarifasDetalles
        Appearance131.BackColor = System.Drawing.SystemColors.Window
        Appearance131.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griTarifasDetalles.DisplayLayout.Appearance = Appearance131
        UltraGridColumn124.Header.VisiblePosition = 7
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 8
        UltraGridColumn125.Hidden = True
        UltraGridColumn126.Header.VisiblePosition = 9
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 0
        UltraGridColumn127.Width = 100
        Appearance132.TextHAlignAsString = "Right"
        UltraGridColumn128.CellAppearance = Appearance132
        UltraGridColumn128.Header.VisiblePosition = 3
        UltraGridColumn128.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn128.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn128.Width = 60
        Appearance133.TextHAlignAsString = "Right"
        UltraGridColumn129.CellAppearance = Appearance133
        UltraGridColumn129.Header.VisiblePosition = 1
        UltraGridColumn129.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn129.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn129.Width = 60
        Appearance134.TextHAlignAsString = "Right"
        UltraGridColumn130.CellAppearance = Appearance134
        UltraGridColumn130.Header.VisiblePosition = 2
        UltraGridColumn130.Hidden = True
        UltraGridColumn130.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn130.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn130.Width = 60
        UltraGridColumn131.Header.VisiblePosition = 4
        UltraGridColumn131.Hidden = True
        UltraGridColumn131.Width = 80
        UltraGridColumn132.Header.VisiblePosition = 5
        UltraGridColumn132.Hidden = True
        UltraGridColumn132.Width = 40
        UltraGridColumn133.Header.VisiblePosition = 6
        UltraGridColumn133.Hidden = True
        UltraGridColumn133.Width = 40
        UltraGridColumn134.Header.VisiblePosition = 10
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 11
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 12
        UltraGridColumn136.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136})
        Me.griTarifasDetalles.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.griTarifasDetalles.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasDetalles.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasDetalles.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance135.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance135.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance135.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance135.BorderColor = System.Drawing.SystemColors.Window
        Me.griTarifasDetalles.DisplayLayout.GroupByBox.Appearance = Appearance135
        Appearance136.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasDetalles.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance136
        Me.griTarifasDetalles.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasDetalles.DisplayLayout.GroupByBox.Hidden = True
        Appearance137.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance137.BackColor2 = System.Drawing.SystemColors.Control
        Appearance137.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance137.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasDetalles.DisplayLayout.GroupByBox.PromptAppearance = Appearance137
        Me.griTarifasDetalles.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasDetalles.DisplayLayout.MaxRowScrollRegions = 1
        Me.griTarifasDetalles.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griTarifasDetalles.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasDetalles.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifasDetalles.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTarifasDetalles.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasDetalles.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTarifasDetalles.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTarifasDetalles.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griTarifasDetalles.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifasDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasDetalles.Location = New System.Drawing.Point(0, 0)
        Me.griTarifasDetalles.Name = "griTarifasDetalles"
        Me.griTarifasDetalles.Size = New System.Drawing.Size(279, 509)
        Me.griTarifasDetalles.TabIndex = 2
        Me.griTarifasDetalles.Text = "DETALLES PARA PROCESO ZONA RENTING"
        '
        'MenuZona
        '
        Me.MenuZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuZona.ForeColor = System.Drawing.Color.Black
        Me.MenuZona.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MZnuevo, Me.MZactualizar, Me.MZeliminar})
        Me.MenuZona.Name = "MenuContextual1"
        Me.MenuZona.Size = New System.Drawing.Size(121, 70)
        '
        'MZnuevo
        '
        Me.MZnuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.MZnuevo.Name = "MZnuevo"
        Me.MZnuevo.Size = New System.Drawing.Size(120, 22)
        Me.MZnuevo.Text = "Nuevo"
        Me.MZnuevo.ToolTipText = "Insertar una nueva Zona"
        '
        'MZactualizar
        '
        Me.MZactualizar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.MZactualizar.Name = "MZactualizar"
        Me.MZactualizar.Size = New System.Drawing.Size(120, 22)
        Me.MZactualizar.Text = "Actualizar"
        Me.MZactualizar.ToolTipText = "Actualizar o modificar la Zona seccionada"
        '
        'MZeliminar
        '
        Me.MZeliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.MZeliminar.Name = "MZeliminar"
        Me.MZeliminar.Size = New System.Drawing.Size(120, 22)
        Me.MZeliminar.Text = "Eliminar"
        Me.MZeliminar.ToolTipText = "Eliminar la Zona seleccionada"
        '
        'ogdTarifasDetalles
        '
        Me.ogdTarifasDetalles.Band.Columns.AddRange(New Object() {UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171})
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griVehiculoPiloto)
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1358, 515)
        '
        'griVehiculoPiloto
        '
        Me.griVehiculoPiloto.DataSource = Me.ogdVehiculoPiloto
        Appearance12.BackColor = System.Drawing.Color.White
        Me.griVehiculoPiloto.DisplayLayout.Appearance = Appearance12
        UltraGridColumn137.Header.VisiblePosition = 0
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.Header.Caption = "Vehiculo"
        UltraGridColumn138.Header.VisiblePosition = 3
        UltraGridColumn138.Width = 75
        UltraGridColumn139.Header.Caption = "Piloto"
        UltraGridColumn139.Header.VisiblePosition = 2
        UltraGridColumn139.Width = 200
        UltraGridColumn140.Header.Caption = "Operacion"
        UltraGridColumn140.Header.VisiblePosition = 4
        UltraGridColumn140.Width = 150
        UltraGridColumn141.Header.Caption = "Cliente"
        UltraGridColumn141.Header.VisiblePosition = 1
        UltraGridColumn141.Width = 250
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn142.Header.VisiblePosition = 8
        UltraGridColumn142.Width = 250
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn143.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn143.Width = 70
        UltraGridColumn144.Header.VisiblePosition = 6
        UltraGridColumn144.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn144.Width = 70
        UltraGridColumn145.Header.VisiblePosition = 7
        UltraGridColumn145.Width = 35
        UltraGridColumn146.Header.Caption = "Historial"
        UltraGridColumn146.Header.VisiblePosition = 9
        UltraGridColumn146.Width = 35
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn147.Header.VisiblePosition = 10
        UltraGridColumn147.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn147.Width = 35
        UltraGridColumn148.Header.VisiblePosition = 11
        UltraGridColumn148.Hidden = True
        UltraGridColumn148.Width = 100
        UltraGridColumn149.Header.VisiblePosition = 12
        UltraGridColumn149.Hidden = True
        UltraGridColumn149.Width = 100
        UltraGridColumn150.Header.VisiblePosition = 13
        UltraGridColumn150.Hidden = True
        UltraGridColumn150.Width = 100
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150})
        Me.griVehiculoPiloto.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griVehiculoPiloto.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.griVehiculoPiloto.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griVehiculoPiloto.DisplayLayout.GroupByBox.Hidden = True
        Me.griVehiculoPiloto.DisplayLayout.MaxColScrollRegions = 1
        Me.griVehiculoPiloto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVehiculoPiloto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculoPiloto.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVehiculoPiloto.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griVehiculoPiloto.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVehiculoPiloto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculoPiloto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griVehiculoPiloto.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.griVehiculoPiloto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculoPiloto.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.None
        Me.griVehiculoPiloto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griVehiculoPiloto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griVehiculoPiloto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculoPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculoPiloto.Location = New System.Drawing.Point(0, 180)
        Me.griVehiculoPiloto.Name = "griVehiculoPiloto"
        Me.griVehiculoPiloto.Size = New System.Drawing.Size(1358, 335)
        Me.griVehiculoPiloto.TabIndex = 5
        Me.griVehiculoPiloto.Tag = ""
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Controls.Add(Me.grupoZona)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel11)
        Me.UltraGroupBox4.Controls.Add(Me.cboZona)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta1)
        Me.UltraGroupBox4.Controls.Add(Me.txtId)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel1)
        Me.UltraGroupBox4.Controls.Add(Me.cboTracto)
        Me.UltraGroupBox4.Controls.Add(Me.cboPiloto)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel28)
        Me.UltraGroupBox4.Controls.Add(Me.opcVehiculoPiloto)
        Me.UltraGroupBox4.Controls.Add(Me.txtIndHistorial)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel8)
        Me.UltraGroupBox4.Controls.Add(Me.verActual)
        Me.UltraGroupBox4.Controls.Add(Me.fecFin)
        Me.UltraGroupBox4.Controls.Add(Me.fecInicio)
        Me.UltraGroupBox4.Controls.Add(Me.Etiqueta50)
        Me.UltraGroupBox4.Controls.Add(Me.btnAgregar)
        Me.UltraGroupBox4.Controls.Add(Me.txtObservacion)
        Me.UltraGroupBox4.Controls.Add(Me.cboCliente)
        Me.UltraGroupBox4.Controls.Add(Me.cboActividadNegocio)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel34)
        Me.UltraGroupBox4.Controls.Add(Me.UltraLabel38)
        Me.UltraGroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(1358, 180)
        Me.UltraGroupBox4.TabIndex = 4
        Me.UltraGroupBox4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2003
        '
        'grupoZona
        '
        Appearance13.BackColor = System.Drawing.Color.White
        Appearance13.BackColor2 = System.Drawing.Color.White
        Me.grupoZona.ContentAreaAppearance = Appearance13
        Me.grupoZona.Controls.Add(Me.txtMonto)
        Me.grupoZona.Controls.Add(Me.UltraLabel36)
        Me.grupoZona.Controls.Add(Me.UltraLabel5)
        Me.grupoZona.Controls.Add(Me.txtSemana)
        Me.grupoZona.Controls.Add(Me.UltraLabel6)
        Me.grupoZona.Controls.Add(Me.txtCostoFijo)
        Me.grupoZona.Location = New System.Drawing.Point(375, 3)
        Me.grupoZona.Name = "grupoZona"
        Me.grupoZona.Size = New System.Drawing.Size(125, 90)
        Me.grupoZona.TabIndex = 268
        Me.grupoZona.Text = "Datos de Zona"
        Me.grupoZona.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'txtMonto
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.txtMonto.Appearance = Appearance14
        Me.txtMonto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMonto.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtMonto.InputMask = "{LOC}nn.nn"
        Me.txtMonto.Location = New System.Drawing.Point(69, 20)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.NonAutoSizeHeight = 20
        Me.txtMonto.Size = New System.Drawing.Size(50, 20)
        Me.txtMonto.TabIndex = 260
        Me.txtMonto.Text = "0.00"
        '
        'UltraLabel36
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Appearance15.TextVAlignAsString = "Middle"
        Me.UltraLabel36.Appearance = Appearance15
        Me.UltraLabel36.AutoSize = True
        Me.UltraLabel36.Location = New System.Drawing.Point(27, 23)
        Me.UltraLabel36.Name = "UltraLabel36"
        Me.UltraLabel36.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel36.TabIndex = 259
        Me.UltraLabel36.Text = "Monto:"
        '
        'UltraLabel5
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Appearance16.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance16
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(17, 68)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel5.TabIndex = 261
        Me.UltraLabel5.Text = "Semana:"
        '
        'txtSemana
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.txtSemana.Appearance = Appearance17
        Me.txtSemana.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtSemana.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtSemana.InputMask = "{LOC}nn"
        Me.txtSemana.Location = New System.Drawing.Point(69, 65)
        Me.txtSemana.Name = "txtSemana"
        Me.txtSemana.NonAutoSizeHeight = 20
        Me.txtSemana.Size = New System.Drawing.Size(50, 20)
        Me.txtSemana.TabIndex = 262
        Me.txtSemana.Text = "0"
        '
        'UltraLabel6
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Appearance18.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance18
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(6, 45)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel6.TabIndex = 263
        Me.UltraLabel6.Text = "Costo Fijo:"
        '
        'txtCostoFijo
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.txtCostoFijo.Appearance = Appearance19
        Me.txtCostoFijo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoFijo.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoFijo.InputMask = "{LOC}nnnn.nn"
        Me.txtCostoFijo.Location = New System.Drawing.Point(69, 42)
        Me.txtCostoFijo.Name = "txtCostoFijo"
        Me.txtCostoFijo.NonAutoSizeHeight = 20
        Me.txtCostoFijo.Size = New System.Drawing.Size(50, 20)
        Me.txtCostoFijo.TabIndex = 264
        Me.txtCostoFijo.Text = "0.00"
        '
        'UltraLabel11
        '
        Appearance20.BackColor = System.Drawing.Color.Transparent
        Appearance20.ForeColor = System.Drawing.Color.Navy
        Appearance20.TextVAlignAsString = "Middle"
        Me.UltraLabel11.Appearance = Appearance20
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(184, 28)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel11.TabIndex = 257
        Me.UltraLabel11.Text = "Zona:"
        '
        'cboZona
        '
        Appearance21.ForeColor = System.Drawing.Color.Black
        Me.cboZona.Appearance = Appearance21
        Me.cboZona.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboZona.DisplayMember = "Nombre"
        Me.cboZona.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboZona.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboZona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboZona.ForeColor = System.Drawing.Color.Black
        Me.cboZona.ImageList = Me.imagenes
        Me.cboZona.Location = New System.Drawing.Point(219, 24)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(150, 21)
        Me.cboZona.TabIndex = 258
        Me.cboZona.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(166, 120)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta1.TabIndex = 256
        Me.Etiqueta1.Text = "F. Fin:"
        '
        'txtId
        '
        Me.txtId.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(5, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(21, 21)
        Me.txtId.TabIndex = 255
        Me.txtId.Visible = False
        '
        'UltraLabel1
        '
        Appearance22.BackColor = System.Drawing.Color.Transparent
        Appearance22.ForeColor = System.Drawing.Color.Navy
        Appearance22.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance22
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(15, 28)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(51, 14)
        Me.UltraLabel1.TabIndex = 254
        Me.UltraLabel1.Text = "Vehiculo:"
        '
        'cboTracto
        '
        Appearance23.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Appearance = Appearance23
        Me.cboTracto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTracto.DisplayMember = ""
        Me.cboTracto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTracto.Enabled = False
        Me.cboTracto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTracto.ForeColor = System.Drawing.Color.Black
        Me.cboTracto.Location = New System.Drawing.Point(69, 24)
        Me.cboTracto.Name = "cboTracto"
        Me.cboTracto.Size = New System.Drawing.Size(90, 21)
        Me.cboTracto.TabIndex = 253
        Me.cboTracto.ValueMember = "Id"
        '
        'cboPiloto
        '
        Appearance24.ForeColor = System.Drawing.Color.Black
        Me.cboPiloto.Appearance = Appearance24
        Me.cboPiloto.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboPiloto.DisplayMember = "Nombre"
        Me.cboPiloto.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPiloto.ForeColor = System.Drawing.Color.Black
        Me.cboPiloto.ImageList = Me.imagenes
        Me.cboPiloto.Location = New System.Drawing.Point(69, 47)
        Me.cboPiloto.Name = "cboPiloto"
        Me.cboPiloto.Size = New System.Drawing.Size(300, 21)
        Me.cboPiloto.TabIndex = 251
        Me.cboPiloto.ValueMember = "Id"
        '
        'UltraLabel28
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel28.Appearance = Appearance25
        Me.UltraLabel28.AutoSize = True
        Me.UltraLabel28.Location = New System.Drawing.Point(30, 51)
        Me.UltraLabel28.Name = "UltraLabel28"
        Me.UltraLabel28.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel28.TabIndex = 252
        Me.UltraLabel28.Text = "Piloto:"
        '
        'opcVehiculoPiloto
        '
        Appearance26.ForeColor = System.Drawing.Color.Blue
        Me.opcVehiculoPiloto.Appearance = Appearance26
        Me.opcVehiculoPiloto.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.opcVehiculoPiloto.CheckedIndex = 0
        Me.opcVehiculoPiloto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opcVehiculoPiloto.ForeColor = System.Drawing.Color.Black
        ValueListItem1.DataValue = "Default Item"
        ValueListItem1.DisplayText = "VEHICULO (0)"
        ValueListItem2.DataValue = "ValueListItem1"
        ValueListItem2.DisplayText = "PILOTO (1)"
        ValueListItem3.DataValue = "ValueListItem2"
        ValueListItem3.DisplayText = "ZONA (2)"
        Me.opcVehiculoPiloto.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3})
        Me.opcVehiculoPiloto.Location = New System.Drawing.Point(69, 5)
        Me.opcVehiculoPiloto.Name = "opcVehiculoPiloto"
        Me.opcVehiculoPiloto.Size = New System.Drawing.Size(250, 19)
        Me.opcVehiculoPiloto.TabIndex = 250
        Me.opcVehiculoPiloto.Text = "VEHICULO (0)"
        '
        'txtIndHistorial
        '
        Appearance27.TextHAlignAsString = "Right"
        Me.txtIndHistorial.Appearance = Appearance27
        Me.txtIndHistorial.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIndHistorial.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtIndHistorial.InputMask = "{LOC}nn"
        Me.txtIndHistorial.Location = New System.Drawing.Point(349, 93)
        Me.txtIndHistorial.Name = "txtIndHistorial"
        Me.txtIndHistorial.NonAutoSizeHeight = 20
        Me.txtIndHistorial.Size = New System.Drawing.Size(20, 20)
        Me.txtIndHistorial.TabIndex = 249
        Me.txtIndHistorial.Text = "1"
        '
        'UltraLabel8
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel8.Appearance = Appearance28
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(298, 97)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 14)
        Me.UltraLabel8.TabIndex = 248
        Me.UltraLabel8.Text = "Historial: "
        '
        'verActual
        '
        Me.verActual.AutoSize = True
        Me.verActual.Checked = True
        Me.verActual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.verActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActual.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActual.Location = New System.Drawing.Point(315, 117)
        Me.verActual.Name = "verActual"
        Me.verActual.Size = New System.Drawing.Size(52, 17)
        Me.verActual.TabIndex = 247
        Me.verActual.Text = "Actual"
        '
        'fecFin
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFin.Appearance = Appearance29
        Me.fecFin.DateTime = New Date(2014, 1, 2, 0, 0, 0, 0)
        Me.fecFin.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecFin.Location = New System.Drawing.Point(204, 116)
        Me.fecFin.Name = "fecFin"
        Me.fecFin.Size = New System.Drawing.Size(90, 21)
        Me.fecFin.TabIndex = 246
        Me.fecFin.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'fecInicio
        '
        Appearance30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecInicio.Appearance = Appearance30
        Me.fecInicio.DateTime = New Date(2014, 1, 2, 0, 0, 0, 0)
        Me.fecInicio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecInicio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fecInicio.Location = New System.Drawing.Point(69, 116)
        Me.fecInicio.Name = "fecInicio"
        Me.fecInicio.Size = New System.Drawing.Size(90, 21)
        Me.fecInicio.TabIndex = 244
        Me.fecInicio.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'Etiqueta50
        '
        Me.Etiqueta50.AutoSize = True
        Me.Etiqueta50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta50.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta50.Location = New System.Drawing.Point(15, 120)
        Me.Etiqueta50.Name = "Etiqueta50"
        Me.Etiqueta50.Size = New System.Drawing.Size(50, 14)
        Me.Etiqueta50.TabIndex = 245
        Me.Etiqueta50.Text = "F. Enicio:"
        '
        'btnAgregar
        '
        Appearance31.Image = "add.ico"
        Me.btnAgregar.Appearance = Appearance31
        Me.btnAgregar.ImageList = Me.imagenes
        Me.btnAgregar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAgregar.Location = New System.Drawing.Point(339, 142)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregar.TabIndex = 16
        '
        'txtObservacion
        '
        Me.txtObservacion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacion.Location = New System.Drawing.Point(5, 140)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(325, 35)
        Me.txtObservacion.TabIndex = 8
        '
        'cboCliente
        '
        Appearance32.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.Appearance = Appearance32
        Me.cboCliente.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboCliente.DisplayMember = "Nombre"
        Me.cboCliente.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.ForeColor = System.Drawing.Color.Black
        Me.cboCliente.ImageList = Me.imagenes
        Me.cboCliente.Location = New System.Drawing.Point(69, 70)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(300, 21)
        Me.cboCliente.TabIndex = 1
        Me.cboCliente.ValueMember = "Id"
        '
        'cboActividadNegocio
        '
        Appearance33.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.Appearance = Appearance33
        Me.cboActividadNegocio.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocio.DisplayMember = "Nombre"
        Me.cboActividadNegocio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocio.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocio.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocio.ImageList = Me.imagenes
        Me.cboActividadNegocio.Location = New System.Drawing.Point(69, 93)
        Me.cboActividadNegocio.Name = "cboActividadNegocio"
        Me.cboActividadNegocio.Size = New System.Drawing.Size(225, 21)
        Me.cboActividadNegocio.TabIndex = 3
        Me.cboActividadNegocio.ValueMember = "Id"
        '
        'UltraLabel34
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Appearance34.TextVAlignAsString = "Middle"
        Me.UltraLabel34.Appearance = Appearance34
        Me.UltraLabel34.AutoSize = True
        Me.UltraLabel34.Location = New System.Drawing.Point(23, 74)
        Me.UltraLabel34.Name = "UltraLabel34"
        Me.UltraLabel34.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel34.TabIndex = 0
        Me.UltraLabel34.Text = "Cliente:"
        '
        'UltraLabel38
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Appearance35.TextVAlignAsString = "Middle"
        Me.UltraLabel38.Appearance = Appearance35
        Me.UltraLabel38.AutoSize = True
        Me.UltraLabel38.Location = New System.Drawing.Point(6, 97)
        Me.UltraLabel38.Name = "UltraLabel38"
        Me.UltraLabel38.Size = New System.Drawing.Size(60, 14)
        Me.UltraLabel38.TabIndex = 2
        Me.UltraLabel38.Text = "Operacion:"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.griViajesProceso)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraExpandableGroupBox6)
        Me.UltraTabPageControl4.Controls.Add(Me.grupoCabeceraInformeRenting)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1358, 515)
        '
        'griViajesProceso
        '
        Me.griViajesProceso.DataSource = Me.ogdViajesProceso
        Appearance36.BackColor = System.Drawing.SystemColors.Window
        Appearance36.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griViajesProceso.DisplayLayout.Appearance = Appearance36
        UltraGridColumn31.Header.VisiblePosition = 0
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 25
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 23
        UltraGridColumn33.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 24
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 1
        UltraGridColumn36.Width = 100
        UltraGridColumn37.Header.VisiblePosition = 2
        UltraGridColumn37.Hidden = True
        Appearance37.TextHAlignAsString = "Right"
        UltraGridColumn38.CellAppearance = Appearance37
        UltraGridColumn38.Header.VisiblePosition = 3
        UltraGridColumn38.Width = 30
        UltraGridColumn39.Header.VisiblePosition = 18
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn40.Header.VisiblePosition = 4
        UltraGridColumn40.Width = 50
        UltraGridColumn41.Header.VisiblePosition = 6
        UltraGridColumn41.Hidden = True
        UltraGridColumn41.Width = 50
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Width = 50
        UltraGridColumn43.Header.VisiblePosition = 7
        UltraGridColumn43.Width = 60
        UltraGridColumn44.Header.VisiblePosition = 8
        UltraGridColumn44.Width = 100
        UltraGridColumn45.Header.VisiblePosition = 9
        UltraGridColumn45.Width = 100
        UltraGridColumn46.Header.VisiblePosition = 10
        UltraGridColumn46.Width = 50
        UltraGridColumn47.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn47.Header.VisiblePosition = 11
        UltraGridColumn47.Width = 60
        UltraGridColumn48.Header.VisiblePosition = 12
        UltraGridColumn48.Width = 100
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn49.Header.VisiblePosition = 13
        Appearance38.TextHAlignAsString = "Right"
        UltraGridColumn50.CellAppearance = Appearance38
        UltraGridColumn50.Header.VisiblePosition = 14
        UltraGridColumn50.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn50.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn50.Width = 50
        Appearance39.TextHAlignAsString = "Right"
        UltraGridColumn51.CellAppearance = Appearance39
        UltraGridColumn51.Header.VisiblePosition = 15
        UltraGridColumn51.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn51.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn51.Width = 75
        Appearance40.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn52.CellAppearance = Appearance40
        UltraGridColumn52.Header.Caption = "Retorno"
        UltraGridColumn52.Header.VisiblePosition = 17
        UltraGridColumn52.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn52.Width = 35
        UltraGridColumn54.Header.VisiblePosition = 19
        UltraGridColumn54.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn54.Width = 35
        Appearance41.TextHAlignAsString = "Right"
        UltraGridColumn82.CellAppearance = Appearance41
        UltraGridColumn82.Header.VisiblePosition = 16
        UltraGridColumn82.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn82.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn82.Width = 75
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn89.CellAppearance = Appearance42
        UltraGridColumn89.Header.Caption = "F.Unitario"
        UltraGridColumn89.Header.VisiblePosition = 20
        UltraGridColumn89.MaskInput = "{LOC}nnnn.nnnn"
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn89.Width = 75
        Appearance43.TextHAlignAsString = "Right"
        UltraGridColumn90.CellAppearance = Appearance43
        UltraGridColumn90.Header.VisiblePosition = 21
        UltraGridColumn90.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn90.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn90.Width = 75
        UltraGridColumn91.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn91.Header.VisiblePosition = 22
        UltraGridColumn91.Width = 250
        UltraGridColumn92.Header.VisiblePosition = 26
        UltraGridColumn92.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn54, UltraGridColumn82, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92})
        Me.griViajesProceso.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griViajesProceso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesProceso.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance44.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance44.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance44.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance44.BorderColor = System.Drawing.SystemColors.Window
        Me.griViajesProceso.DisplayLayout.GroupByBox.Appearance = Appearance44
        Appearance45.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesProceso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance45
        Me.griViajesProceso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griViajesProceso.DisplayLayout.GroupByBox.Hidden = True
        Appearance46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance46.BackColor2 = System.Drawing.SystemColors.Control
        Appearance46.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance46.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griViajesProceso.DisplayLayout.GroupByBox.PromptAppearance = Appearance46
        Me.griViajesProceso.DisplayLayout.MaxColScrollRegions = 1
        Me.griViajesProceso.DisplayLayout.MaxRowScrollRegions = 1
        Me.griViajesProceso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griViajesProceso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griViajesProceso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griViajesProceso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griViajesProceso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griViajesProceso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griViajesProceso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griViajesProceso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griViajesProceso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griViajesProceso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griViajesProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griViajesProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griViajesProceso.ImageList = Me.imagenes
        Me.griViajesProceso.Location = New System.Drawing.Point(0, 350)
        Me.griViajesProceso.Name = "griViajesProceso"
        Me.griViajesProceso.Size = New System.Drawing.Size(1358, 165)
        Me.griViajesProceso.TabIndex = 285
        '
        'ogdViajesProceso
        '
        UltraDataColumn52.DataType = GetType(Boolean)
        Me.ogdViajesProceso.Band.Columns.AddRange(New Object() {UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55, UltraDataColumn56, UltraDataColumn57, UltraDataColumn58})
        '
        'UltraExpandableGroupBox6
        '
        Appearance47.BackColor = System.Drawing.Color.White
        Appearance47.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox6.ContentAreaAppearance = Appearance47
        Me.UltraExpandableGroupBox6.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.UltraExpandableGroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.UltraExpandableGroupBox6.ExpandedSize = New System.Drawing.Size(1358, 250)
        Me.UltraExpandableGroupBox6.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox6.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.UltraExpandableGroupBox6.Location = New System.Drawing.Point(0, 100)
        Me.UltraExpandableGroupBox6.Name = "UltraExpandableGroupBox6"
        Me.UltraExpandableGroupBox6.Size = New System.Drawing.Size(1358, 250)
        Me.UltraExpandableGroupBox6.TabIndex = 284
        Me.UltraExpandableGroupBox6.Text = "Detalle Costo Viajes"
        Me.UltraExpandableGroupBox6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.griTarifasProceso)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.UltraExpandableGroupBox7)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(1352, 227)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'griTarifasProceso
        '
        Me.griTarifasProceso.DataSource = Me.ogdTarifasProceso
        Appearance48.BackColor = System.Drawing.SystemColors.Window
        Appearance48.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griTarifasProceso.DisplayLayout.Appearance = Appearance48
        Appearance49.Image = 6
        Appearance49.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance49.TextHAlignAsString = "Left"
        UltraGridColumn151.CellAppearance = Appearance49
        Appearance50.Image = 8
        Appearance50.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn151.CellButtonAppearance = Appearance50
        UltraGridColumn151.Header.VisiblePosition = 0
        UltraGridColumn151.Hidden = True
        UltraGridColumn151.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn152.Header.VisiblePosition = 23
        UltraGridColumn152.Hidden = True
        UltraGridColumn153.Header.VisiblePosition = 18
        UltraGridColumn153.Hidden = True
        UltraGridColumn154.Header.VisiblePosition = 17
        UltraGridColumn154.Hidden = True
        Appearance51.Image = 6
        Appearance51.ImageHAlign = Infragistics.Win.HAlign.Right
        Appearance51.TextHAlignAsString = "Left"
        UltraGridColumn233.CellAppearance = Appearance51
        Appearance52.Image = 8
        Appearance52.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn233.CellButtonAppearance = Appearance52
        UltraGridColumn233.Header.VisiblePosition = 1
        UltraGridColumn233.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn233.Width = 75
        Appearance53.TextHAlignAsString = "Right"
        UltraGridColumn234.CellAppearance = Appearance53
        UltraGridColumn234.Header.VisiblePosition = 2
        UltraGridColumn234.Hidden = True
        UltraGridColumn234.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn234.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn234.Width = 70
        Appearance54.TextHAlignAsString = "Right"
        UltraGridColumn235.CellAppearance = Appearance54
        UltraGridColumn235.Header.VisiblePosition = 4
        UltraGridColumn235.Hidden = True
        UltraGridColumn235.MaskInput = "{LOC}nn"
        UltraGridColumn235.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn235.Width = 30
        Appearance55.TextHAlignAsString = "Right"
        UltraGridColumn236.CellAppearance = Appearance55
        UltraGridColumn236.Header.VisiblePosition = 3
        UltraGridColumn236.Hidden = True
        UltraGridColumn236.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn236.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn236.Width = 70
        Appearance56.TextHAlignAsString = "Right"
        UltraGridColumn237.CellAppearance = Appearance56
        UltraGridColumn237.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn237.Header.VisiblePosition = 5
        UltraGridColumn237.MaskInput = "nn"
        UltraGridColumn237.Width = 30
        Appearance57.TextHAlignAsString = "Right"
        UltraGridColumn238.CellAppearance = Appearance57
        UltraGridColumn238.Header.VisiblePosition = 6
        UltraGridColumn238.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn238.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn238.Width = 60
        Appearance58.TextHAlignAsString = "Right"
        UltraGridColumn239.CellAppearance = Appearance58
        UltraGridColumn239.Header.Caption = "NªViaje"
        UltraGridColumn239.Header.VisiblePosition = 7
        UltraGridColumn239.MaskInput = "{LOC}nnn.nn"
        UltraGridColumn239.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn239.Width = 50
        Appearance59.TextHAlignAsString = "Right"
        UltraGridColumn240.CellAppearance = Appearance59
        UltraGridColumn240.Header.VisiblePosition = 8
        UltraGridColumn240.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn240.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn240.Width = 60
        Appearance60.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance60.TextHAlignAsString = "Right"
        UltraGridColumn241.CellAppearance = Appearance60
        UltraGridColumn241.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn241.Header.VisiblePosition = 12
        UltraGridColumn241.Hidden = True
        UltraGridColumn241.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn241.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn241.Width = 50
        Appearance61.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance61.TextHAlignAsString = "Right"
        UltraGridColumn242.CellAppearance = Appearance61
        UltraGridColumn242.Header.Caption = "C.V.Adicional"
        UltraGridColumn242.Header.VisiblePosition = 14
        UltraGridColumn242.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn242.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn242.Width = 70
        Appearance62.TextHAlignAsString = "Right"
        UltraGridColumn243.CellAppearance = Appearance62
        UltraGridColumn243.Header.VisiblePosition = 9
        UltraGridColumn243.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn243.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn243.Width = 70
        Appearance63.TextHAlignAsString = "Right"
        UltraGridColumn244.CellAppearance = Appearance63
        UltraGridColumn244.Header.VisiblePosition = 10
        UltraGridColumn244.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn244.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn244.Width = 70
        Appearance64.TextHAlignAsString = "Right"
        UltraGridColumn245.CellAppearance = Appearance64
        UltraGridColumn245.Header.VisiblePosition = 11
        UltraGridColumn245.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn245.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn245.Width = 70
        Appearance65.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance65.TextHAlignAsString = "Right"
        UltraGridColumn246.CellAppearance = Appearance65
        UltraGridColumn246.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn246.Header.Caption = "C.Adicional"
        UltraGridColumn246.Header.VisiblePosition = 13
        UltraGridColumn246.MaskInput = "{LOC}nnnn.nn"
        UltraGridColumn246.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn246.Width = 50
        Appearance66.TextHAlignAsString = "Right"
        UltraGridColumn256.CellAppearance = Appearance66
        UltraGridColumn256.Header.VisiblePosition = 15
        UltraGridColumn256.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn256.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn256.Width = 70
        UltraGridColumn257.Header.VisiblePosition = 25
        UltraGridColumn257.Hidden = True
        UltraGridColumn258.Header.VisiblePosition = 26
        UltraGridColumn258.Hidden = True
        UltraGridColumn259.Header.VisiblePosition = 19
        UltraGridColumn259.Hidden = True
        UltraGridColumn260.Header.VisiblePosition = 20
        UltraGridColumn260.Hidden = True
        UltraGridColumn261.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn261.Header.VisiblePosition = 24
        UltraGridColumn261.Width = 150
        UltraGridColumn262.Header.VisiblePosition = 21
        UltraGridColumn262.Hidden = True
        UltraGridColumn263.Header.VisiblePosition = 22
        UltraGridColumn263.Hidden = True
        Appearance67.BackColor = System.Drawing.Color.Aqua
        Appearance67.Image = 3
        Appearance67.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn278.CellAppearance = Appearance67
        Appearance68.Image = 1
        Appearance68.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridColumn278.CellButtonAppearance = Appearance68
        UltraGridColumn278.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn278.Header.VisiblePosition = 16
        UltraGridColumn278.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn278.Width = 35
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn151, UltraGridColumn152, UltraGridColumn153, UltraGridColumn154, UltraGridColumn233, UltraGridColumn234, UltraGridColumn235, UltraGridColumn236, UltraGridColumn237, UltraGridColumn238, UltraGridColumn239, UltraGridColumn240, UltraGridColumn241, UltraGridColumn242, UltraGridColumn243, UltraGridColumn244, UltraGridColumn245, UltraGridColumn246, UltraGridColumn256, UltraGridColumn257, UltraGridColumn258, UltraGridColumn259, UltraGridColumn260, UltraGridColumn261, UltraGridColumn262, UltraGridColumn263, UltraGridColumn278})
        Me.griTarifasProceso.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griTarifasProceso.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasProceso.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance69.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.griTarifasProceso.DisplayLayout.GroupByBox.Appearance = Appearance69
        Appearance70.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasProceso.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance70
        Me.griTarifasProceso.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griTarifasProceso.DisplayLayout.GroupByBox.Hidden = True
        Appearance71.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance71.BackColor2 = System.Drawing.SystemColors.Control
        Appearance71.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance71.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griTarifasProceso.DisplayLayout.GroupByBox.PromptAppearance = Appearance71
        Me.griTarifasProceso.DisplayLayout.MaxColScrollRegions = 1
        Me.griTarifasProceso.DisplayLayout.MaxRowScrollRegions = 1
        Me.griTarifasProceso.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griTarifasProceso.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griTarifasProceso.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griTarifasProceso.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griTarifasProceso.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griTarifasProceso.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griTarifasProceso.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griTarifasProceso.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griTarifasProceso.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griTarifasProceso.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griTarifasProceso.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griTarifasProceso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griTarifasProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griTarifasProceso.ImageList = Me.imagenes
        Me.griTarifasProceso.Location = New System.Drawing.Point(0, 0)
        Me.griTarifasProceso.Name = "griTarifasProceso"
        Me.griTarifasProceso.Size = New System.Drawing.Size(917, 227)
        Me.griTarifasProceso.TabIndex = 285
        '
        'ogdTarifasProceso
        '
        Me.ogdTarifasProceso.Band.Columns.AddRange(New Object() {UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74, UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85})
        '
        'UltraExpandableGroupBox7
        '
        Appearance72.BackColor = System.Drawing.Color.White
        Appearance72.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox7.ContentAreaAppearance = Appearance72
        Me.UltraExpandableGroupBox7.Controls.Add(Me.UltraExpandableGroupBoxPanel7)
        Me.UltraExpandableGroupBox7.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox7.ExpandedSize = New System.Drawing.Size(435, 227)
        Me.UltraExpandableGroupBox7.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox7.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox7.Location = New System.Drawing.Point(917, 0)
        Me.UltraExpandableGroupBox7.Name = "UltraExpandableGroupBox7"
        Me.UltraExpandableGroupBox7.Size = New System.Drawing.Size(435, 227)
        Me.UltraExpandableGroupBox7.TabIndex = 284
        Me.UltraExpandableGroupBox7.Text = "Gastos de Estiba y Desestiba"
        Me.UltraExpandableGroupBox7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel7
        '
        Me.UltraExpandableGroupBoxPanel7.Controls.Add(Me.griCargaOperacion)
        Me.UltraExpandableGroupBoxPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel7.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel7.Name = "UltraExpandableGroupBoxPanel7"
        Me.UltraExpandableGroupBoxPanel7.Size = New System.Drawing.Size(412, 221)
        Me.UltraExpandableGroupBoxPanel7.TabIndex = 0
        '
        'griCargaOperacion
        '
        Me.griCargaOperacion.DataSource = Me.ogdViaje
        UltraGridColumn279.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn279.Header.VisiblePosition = 16
        UltraGridColumn279.Hidden = True
        UltraGridColumn280.Header.VisiblePosition = 17
        UltraGridColumn280.Hidden = True
        Appearance73.TextVAlignAsString = "Middle"
        UltraGridColumn281.CellAppearance = Appearance73
        UltraGridColumn281.Header.Caption = "Viaje"
        UltraGridColumn281.Header.Fixed = True
        UltraGridColumn281.Header.VisiblePosition = 1
        UltraGridColumn281.Hidden = True
        UltraGridColumn281.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn281.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn281.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn281.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn281.Width = 95
        UltraGridColumn282.Header.VisiblePosition = 18
        UltraGridColumn282.Hidden = True
        UltraGridColumn283.Header.Fixed = True
        UltraGridColumn283.Header.VisiblePosition = 3
        UltraGridColumn283.Hidden = True
        UltraGridColumn283.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn283.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn283.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn283.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn283.Width = 100
        UltraGridColumn284.Header.VisiblePosition = 19
        UltraGridColumn284.Hidden = True
        UltraGridColumn285.Header.Fixed = True
        UltraGridColumn285.Header.VisiblePosition = 4
        UltraGridColumn285.Hidden = True
        UltraGridColumn285.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn285.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn285.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn285.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn285.Width = 100
        UltraGridColumn286.Header.VisiblePosition = 20
        UltraGridColumn286.Hidden = True
        Appearance74.TextVAlignAsString = "Middle"
        UltraGridColumn287.CellAppearance = Appearance74
        UltraGridColumn287.Header.Caption = "Vacio"
        UltraGridColumn287.Header.VisiblePosition = 71
        UltraGridColumn287.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn287.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn287.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(61, 0)
        UltraGridColumn287.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn287.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn287.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn287.Width = 40
        UltraGridColumn288.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn288.Header.VisiblePosition = 22
        UltraGridColumn288.Hidden = True
        Appearance75.Image = 7
        UltraGridColumn289.CellAppearance = Appearance75
        Appearance76.Image = 3
        UltraGridColumn289.CellButtonAppearance = Appearance76
        UltraGridColumn289.Header.VisiblePosition = 7
        UltraGridColumn289.Hidden = True
        UltraGridColumn289.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn289.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn289.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn289.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn289.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn289.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        UltraGridColumn289.Width = 150
        UltraGridColumn290.Header.VisiblePosition = 23
        UltraGridColumn290.Hidden = True
        Appearance77.Image = 7
        UltraGridColumn291.CellButtonAppearance = Appearance77
        UltraGridColumn291.Header.VisiblePosition = 8
        UltraGridColumn291.Hidden = True
        UltraGridColumn291.RowLayoutColumnInfo.OriginX = 10
        UltraGridColumn291.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn291.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(254, 0)
        UltraGridColumn291.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn291.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn291.Width = 150
        UltraGridColumn292.Header.VisiblePosition = 15
        UltraGridColumn292.Hidden = True
        UltraGridColumn293.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn293.Header.VisiblePosition = 13
        UltraGridColumn293.Hidden = True
        Appearance78.TextHAlignAsString = "Left"
        Appearance78.TextVAlignAsString = "Middle"
        UltraGridColumn294.CellAppearance = Appearance78
        UltraGridColumn294.Header.Fixed = True
        UltraGridColumn294.Header.VisiblePosition = 5
        UltraGridColumn294.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn294.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn294.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn294.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn294.Width = 50
        UltraGridColumn295.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn295.Header.VisiblePosition = 12
        UltraGridColumn295.Hidden = True
        Appearance79.TextHAlignAsString = "Left"
        Appearance79.TextVAlignAsString = "Middle"
        UltraGridColumn315.CellAppearance = Appearance79
        UltraGridColumn315.Header.Fixed = True
        UltraGridColumn315.Header.VisiblePosition = 6
        UltraGridColumn315.Hidden = True
        UltraGridColumn315.RowLayoutColumnInfo.OriginX = 12
        UltraGridColumn315.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn315.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn315.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn315.VertScrollBar = True
        UltraGridColumn315.Width = 64
        UltraGridColumn316.Header.VisiblePosition = 24
        UltraGridColumn316.Hidden = True
        UltraGridColumn318.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn318.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn318.Header.Caption = "Fecha Atencion"
        UltraGridColumn318.Header.Fixed = True
        UltraGridColumn318.Header.VisiblePosition = 2
        UltraGridColumn318.Hidden = True
        UltraGridColumn318.MaskInput = "{date} {time}"
        UltraGridColumn318.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn318.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn318.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn318.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn318.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn318.Width = 100
        UltraGridColumn320.Header.VisiblePosition = 29
        UltraGridColumn320.Hidden = True
        UltraGridColumn321.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn321.Header.VisiblePosition = 27
        UltraGridColumn321.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn321.Width = 30
        UltraGridColumn333.Header.Caption = "UsuarioCrea"
        UltraGridColumn333.Header.VisiblePosition = 51
        UltraGridColumn333.Hidden = True
        UltraGridColumn333.Width = 150
        UltraGridColumn334.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridColumn334.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance80.TextHAlignAsString = "Center"
        Appearance80.TextVAlignAsString = "Middle"
        UltraGridColumn334.CellAppearance = Appearance80
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn334.Header.Appearance = Appearance81
        UltraGridColumn334.Header.Fixed = True
        UltraGridColumn334.Header.VisiblePosition = 0
        UltraGridColumn334.Hidden = True
        UltraGridColumn334.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn334.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn334.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn334.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn334.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn334.Width = 95
        Appearance82.TextVAlignAsString = "Middle"
        UltraGridColumn335.CellAppearance = Appearance82
        UltraGridColumn335.Header.VisiblePosition = 34
        UltraGridColumn335.Hidden = True
        UltraGridColumn335.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn335.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn335.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn335.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn335.Width = 100
        Appearance83.TextVAlignAsString = "Middle"
        UltraGridColumn336.CellAppearance = Appearance83
        UltraGridColumn336.Header.VisiblePosition = 21
        UltraGridColumn336.Hidden = True
        UltraGridColumn336.RowLayoutColumnInfo.OriginX = 8
        UltraGridColumn336.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn336.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn336.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn336.Width = 124
        UltraGridColumn337.Header.VisiblePosition = 14
        UltraGridColumn337.Hidden = True
        UltraGridColumn338.Header.VisiblePosition = 30
        UltraGridColumn338.Hidden = True
        Appearance84.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        UltraGridColumn339.CellAppearance = Appearance84
        UltraGridColumn339.Header.VisiblePosition = 48
        UltraGridColumn339.Hidden = True
        UltraGridColumn339.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn339.RowLayoutColumnInfo.OriginY = 2
        UltraGridColumn339.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn339.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn339.Width = 100
        UltraGridColumn340.Header.VisiblePosition = 9
        UltraGridColumn340.Hidden = True
        UltraGridColumn340.Width = 150
        UltraGridColumn341.Header.VisiblePosition = 38
        UltraGridColumn341.Hidden = True
        UltraGridColumn342.Header.VisiblePosition = 39
        UltraGridColumn342.Hidden = True
        UltraGridColumn343.Header.VisiblePosition = 58
        UltraGridColumn343.Hidden = True
        UltraGridColumn343.Width = 40
        UltraGridColumn344.Header.VisiblePosition = 35
        UltraGridColumn344.Hidden = True
        UltraGridColumn345.Header.VisiblePosition = 36
        UltraGridColumn345.Hidden = True
        UltraGridColumn346.Header.VisiblePosition = 37
        UltraGridColumn346.Hidden = True
        UltraGridColumn347.Header.VisiblePosition = 52
        UltraGridColumn347.Hidden = True
        UltraGridColumn347.Width = 150
        UltraGridColumn348.Header.VisiblePosition = 53
        UltraGridColumn348.Hidden = True
        UltraGridColumn348.Width = 150
        UltraGridColumn349.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn349.Header.VisiblePosition = 40
        UltraGridColumn349.Hidden = True
        UltraGridColumn349.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn349.Width = 100
        UltraGridColumn350.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn350.Header.VisiblePosition = 41
        UltraGridColumn350.Hidden = True
        UltraGridColumn350.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn350.Width = 100
        UltraGridColumn351.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn351.Header.VisiblePosition = 42
        UltraGridColumn351.Hidden = True
        UltraGridColumn351.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn351.Width = 100
        UltraGridColumn352.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn352.Header.VisiblePosition = 43
        UltraGridColumn352.Hidden = True
        UltraGridColumn352.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn352.Width = 100
        UltraGridColumn353.Header.Caption = "TipoCarga"
        UltraGridColumn353.Header.VisiblePosition = 49
        UltraGridColumn353.Width = 100
        Appearance85.Image = 3
        Appearance85.ImageHAlign = Infragistics.Win.HAlign.Right
        UltraGridColumn354.CellAppearance = Appearance85
        Appearance86.Image = 1
        UltraGridColumn354.CellButtonAppearance = Appearance86
        UltraGridColumn354.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn354.Header.VisiblePosition = 54
        UltraGridColumn354.Hidden = True
        UltraGridColumn354.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.EditButton
        UltraGridColumn354.Width = 250
        UltraGridColumn355.Header.VisiblePosition = 55
        UltraGridColumn355.Hidden = True
        UltraGridColumn355.Width = 250
        UltraGridColumn356.Header.Caption = "Bloque"
        UltraGridColumn356.Header.VisiblePosition = 56
        UltraGridColumn356.Hidden = True
        UltraGridColumn356.Width = 40
        UltraGridColumn357.Header.Caption = "D/N"
        UltraGridColumn357.Header.VisiblePosition = 57
        UltraGridColumn357.Hidden = True
        UltraGridColumn357.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn357.Width = 40
        UltraGridColumn358.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance87.TextHAlignAsString = "Right"
        Appearance87.TextVAlignAsString = "Middle"
        UltraGridColumn358.CellAppearance = Appearance87
        UltraGridColumn358.Format = "#,###,###,##0.00"
        UltraGridColumn358.Header.Caption = "TN"
        UltraGridColumn358.Header.VisiblePosition = 11
        UltraGridColumn358.Hidden = True
        UltraGridColumn358.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn358.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn358.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn358.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn358.Width = 40
        Appearance88.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Appearance88.TextHAlignAsString = "Right"
        UltraGridColumn359.CellAppearance = Appearance88
        UltraGridColumn359.Format = "#,###,###,##0.00"
        UltraGridColumn359.Header.Caption = "Consolidado"
        UltraGridColumn359.Header.VisiblePosition = 28
        UltraGridColumn359.MaskInput = "{LOC}n,nnn,nnn.nn"
        UltraGridColumn359.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn359.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn359.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn359.RowLayoutColumnInfo.SpanY = 4
        UltraGridColumn359.Width = 67
        UltraGridColumn360.Header.VisiblePosition = 50
        UltraGridColumn360.Hidden = True
        UltraGridColumn360.Width = 100
        Appearance89.TextHAlignAsString = "Right"
        UltraGridColumn361.CellAppearance = Appearance89
        UltraGridColumn361.Header.Caption = "KmTracto O"
        UltraGridColumn361.Header.VisiblePosition = 44
        UltraGridColumn361.Hidden = True
        UltraGridColumn361.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn361.Width = 70
        Appearance90.TextHAlignAsString = "Right"
        UltraGridColumn362.CellAppearance = Appearance90
        UltraGridColumn362.Header.Caption = "KmTracto D"
        UltraGridColumn362.Header.VisiblePosition = 45
        UltraGridColumn362.Hidden = True
        UltraGridColumn362.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn362.Width = 70
        Appearance91.TextHAlignAsString = "Right"
        UltraGridColumn363.CellAppearance = Appearance91
        UltraGridColumn363.Header.Caption = "KmCarreta O"
        UltraGridColumn363.Header.VisiblePosition = 46
        UltraGridColumn363.Hidden = True
        UltraGridColumn363.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn363.Width = 70
        Appearance92.TextHAlignAsString = "Right"
        UltraGridColumn364.CellAppearance = Appearance92
        UltraGridColumn364.Header.Caption = "KmCarreta D"
        UltraGridColumn364.Header.VisiblePosition = 47
        UltraGridColumn364.Hidden = True
        UltraGridColumn364.MaskInput = "{LOC}nnnnnnnnnn.nn"
        UltraGridColumn364.Width = 70
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn365.CellAppearance = Appearance93
        UltraGridColumn365.Format = "#,###,###,##0.00"
        UltraGridColumn365.Header.VisiblePosition = 33
        UltraGridColumn365.Hidden = True
        UltraGridColumn365.MaskInput = "{currency:9.2}"
        UltraGridColumn365.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn365.Width = 100
        Appearance94.TextHAlignAsString = "Right"
        UltraGridColumn366.CellAppearance = Appearance94
        UltraGridColumn366.Header.VisiblePosition = 10
        UltraGridColumn366.Hidden = True
        UltraGridColumn366.Width = 100
        UltraGridColumn367.Header.Caption = "Ind"
        UltraGridColumn367.Header.VisiblePosition = 59
        UltraGridColumn367.Hidden = True
        UltraGridColumn367.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn367.Width = 40
        UltraGridColumn368.Header.Caption = "%Flete"
        UltraGridColumn368.Header.VisiblePosition = 31
        UltraGridColumn368.Hidden = True
        UltraGridColumn368.Width = 40
        UltraGridColumn369.Header.VisiblePosition = 60
        UltraGridColumn369.Hidden = True
        UltraGridColumn370.Header.VisiblePosition = 61
        UltraGridColumn370.Hidden = True
        UltraGridColumn371.Header.VisiblePosition = 62
        UltraGridColumn371.Hidden = True
        UltraGridColumn372.Header.VisiblePosition = 63
        UltraGridColumn372.Hidden = True
        UltraGridColumn373.Header.VisiblePosition = 65
        UltraGridColumn373.Hidden = True
        UltraGridColumn374.Header.VisiblePosition = 64
        UltraGridColumn374.Hidden = True
        UltraGridColumn375.Header.VisiblePosition = 66
        UltraGridColumn375.Hidden = True
        UltraGridColumn376.Header.VisiblePosition = 67
        UltraGridColumn376.Hidden = True
        Appearance95.TextHAlignAsString = "Right"
        UltraGridColumn377.CellAppearance = Appearance95
        UltraGridColumn377.Format = "#,###,###,##0.00"
        UltraGridColumn377.Header.Caption = "Cant."
        UltraGridColumn377.Header.VisiblePosition = 25
        UltraGridColumn377.Hidden = True
        UltraGridColumn377.MaskInput = "{LOC}nnn.nnn"
        UltraGridColumn377.Width = 40
        Appearance96.TextHAlignAsString = "Right"
        UltraGridColumn378.CellAppearance = Appearance96
        UltraGridColumn378.Format = "#,###,###,##0.00"
        UltraGridColumn378.Header.VisiblePosition = 26
        UltraGridColumn378.Hidden = True
        UltraGridColumn378.MaskInput = "{LOC}nnn,nnn.nnnn"
        UltraGridColumn378.Width = 60
        UltraGridColumn379.Header.VisiblePosition = 68
        UltraGridColumn379.Hidden = True
        UltraGridColumn379.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn379.Width = 40
        UltraGridColumn380.Header.VisiblePosition = 69
        UltraGridColumn380.Hidden = True
        UltraGridColumn381.Header.VisiblePosition = 70
        UltraGridColumn381.Hidden = True
        UltraGridColumn382.Header.Caption = "Retorno"
        UltraGridColumn382.Header.VisiblePosition = 72
        UltraGridColumn382.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridColumn382.Width = 40
        Appearance97.TextHAlignAsString = "Right"
        UltraGridColumn383.CellAppearance = Appearance97
        UltraGridColumn383.Format = "#,###,###,##0.00"
        UltraGridColumn383.Header.VisiblePosition = 32
        UltraGridColumn383.Hidden = True
        UltraGridColumn383.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn383.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn383.Width = 100
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn279, UltraGridColumn280, UltraGridColumn281, UltraGridColumn282, UltraGridColumn283, UltraGridColumn284, UltraGridColumn285, UltraGridColumn286, UltraGridColumn287, UltraGridColumn288, UltraGridColumn289, UltraGridColumn290, UltraGridColumn291, UltraGridColumn292, UltraGridColumn293, UltraGridColumn294, UltraGridColumn295, UltraGridColumn315, UltraGridColumn316, UltraGridColumn318, UltraGridColumn320, UltraGridColumn321, UltraGridColumn333, UltraGridColumn334, UltraGridColumn335, UltraGridColumn336, UltraGridColumn337, UltraGridColumn338, UltraGridColumn339, UltraGridColumn340, UltraGridColumn341, UltraGridColumn342, UltraGridColumn343, UltraGridColumn344, UltraGridColumn345, UltraGridColumn346, UltraGridColumn347, UltraGridColumn348, UltraGridColumn349, UltraGridColumn350, UltraGridColumn351, UltraGridColumn352, UltraGridColumn353, UltraGridColumn354, UltraGridColumn355, UltraGridColumn356, UltraGridColumn357, UltraGridColumn358, UltraGridColumn359, UltraGridColumn360, UltraGridColumn361, UltraGridColumn362, UltraGridColumn363, UltraGridColumn364, UltraGridColumn365, UltraGridColumn366, UltraGridColumn367, UltraGridColumn368, UltraGridColumn369, UltraGridColumn370, UltraGridColumn371, UltraGridColumn372, UltraGridColumn373, UltraGridColumn374, UltraGridColumn375, UltraGridColumn376, UltraGridColumn377, UltraGridColumn378, UltraGridColumn379, UltraGridColumn380, UltraGridColumn381, UltraGridColumn382, UltraGridColumn383})
        UltraGridBand6.GroupHeadersVisible = False
        UltraGridBand6.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo3.OriginX = 2
        RowLayoutColumnInfo3.OriginY = 0
        RowLayoutColumnInfo3.SpanX = 2
        RowLayoutColumnInfo3.SpanY = 4
        RowLayoutColumnInfo5.OriginX = 6
        RowLayoutColumnInfo5.OriginY = 0
        RowLayoutColumnInfo5.SpanX = 2
        RowLayoutColumnInfo5.SpanY = 2
        RowLayoutColumnInfo7.OriginX = 6
        RowLayoutColumnInfo7.OriginY = 2
        RowLayoutColumnInfo7.SpanX = 2
        RowLayoutColumnInfo7.SpanY = 2
        RowLayoutColumnInfo9.OriginX = 16
        RowLayoutColumnInfo9.OriginY = 0
        RowLayoutColumnInfo9.PreferredCellSize = New System.Drawing.Size(61, 0)
        RowLayoutColumnInfo9.SpanX = 2
        RowLayoutColumnInfo9.SpanY = 2
        RowLayoutColumnInfo11.OriginX = 10
        RowLayoutColumnInfo11.OriginY = 0
        RowLayoutColumnInfo11.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo11.SpanX = 2
        RowLayoutColumnInfo11.SpanY = 2
        RowLayoutColumnInfo13.OriginX = 10
        RowLayoutColumnInfo13.OriginY = 2
        RowLayoutColumnInfo13.PreferredCellSize = New System.Drawing.Size(254, 0)
        RowLayoutColumnInfo13.SpanX = 2
        RowLayoutColumnInfo13.SpanY = 2
        RowLayoutColumnInfo16.OriginX = 12
        RowLayoutColumnInfo16.OriginY = 0
        RowLayoutColumnInfo16.SpanX = 2
        RowLayoutColumnInfo16.SpanY = 2
        RowLayoutColumnInfo18.OriginX = 12
        RowLayoutColumnInfo18.OriginY = 2
        RowLayoutColumnInfo18.SpanX = 2
        RowLayoutColumnInfo18.SpanY = 2
        RowLayoutColumnInfo20.OriginX = 4
        RowLayoutColumnInfo20.OriginY = 0
        RowLayoutColumnInfo20.SpanX = 2
        RowLayoutColumnInfo20.SpanY = 2
        RowLayoutColumnInfo24.OriginX = 0
        RowLayoutColumnInfo24.OriginY = 0
        RowLayoutColumnInfo24.SpanX = 2
        RowLayoutColumnInfo24.SpanY = 4
        RowLayoutColumnInfo25.OriginX = 14
        RowLayoutColumnInfo25.OriginY = 0
        RowLayoutColumnInfo25.SpanX = 2
        RowLayoutColumnInfo25.SpanY = 4
        RowLayoutColumnInfo26.OriginX = 8
        RowLayoutColumnInfo26.OriginY = 0
        RowLayoutColumnInfo26.SpanX = 2
        RowLayoutColumnInfo26.SpanY = 4
        RowLayoutColumnInfo29.OriginX = 4
        RowLayoutColumnInfo29.OriginY = 2
        RowLayoutColumnInfo29.SpanX = 2
        RowLayoutColumnInfo29.SpanY = 2
        RowLayoutColumnInfo49.OriginX = 16
        RowLayoutColumnInfo49.OriginY = 2
        RowLayoutColumnInfo49.SpanX = 2
        RowLayoutColumnInfo49.SpanY = 2
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16, RowLayoutColumnInfo17, RowLayoutColumnInfo18, RowLayoutColumnInfo19, RowLayoutColumnInfo20, RowLayoutColumnInfo21, RowLayoutColumnInfo22, RowLayoutColumnInfo23, RowLayoutColumnInfo24, RowLayoutColumnInfo25, RowLayoutColumnInfo26, RowLayoutColumnInfo27, RowLayoutColumnInfo28, RowLayoutColumnInfo29, RowLayoutColumnInfo30, RowLayoutColumnInfo31, RowLayoutColumnInfo32, RowLayoutColumnInfo33, RowLayoutColumnInfo34, RowLayoutColumnInfo35, RowLayoutColumnInfo36, RowLayoutColumnInfo37, RowLayoutColumnInfo38, RowLayoutColumnInfo39, RowLayoutColumnInfo40, RowLayoutColumnInfo41, RowLayoutColumnInfo42, RowLayoutColumnInfo43, RowLayoutColumnInfo44, RowLayoutColumnInfo45, RowLayoutColumnInfo46, RowLayoutColumnInfo47, RowLayoutColumnInfo48, RowLayoutColumnInfo49, RowLayoutColumnInfo50, RowLayoutColumnInfo51, RowLayoutColumnInfo52, RowLayoutColumnInfo53, RowLayoutColumnInfo54, RowLayoutColumnInfo55, RowLayoutColumnInfo56, RowLayoutColumnInfo57, RowLayoutColumnInfo58, RowLayoutColumnInfo59, RowLayoutColumnInfo60, RowLayoutColumnInfo61, RowLayoutColumnInfo62, RowLayoutColumnInfo63, RowLayoutColumnInfo64, RowLayoutColumnInfo65, RowLayoutColumnInfo66, RowLayoutColumnInfo67, RowLayoutColumnInfo68, RowLayoutColumnInfo69, RowLayoutColumnInfo70, RowLayoutColumnInfo71, RowLayoutColumnInfo72, RowLayoutColumnInfo73})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.GroupLayout
        UltraGridBand6.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        UltraGridBand6.SummaryFooterCaption = "Totales:"
        Me.griCargaOperacion.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griCargaOperacion.DisplayLayout.MaxColScrollRegions = 1
        Me.griCargaOperacion.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griCargaOperacion.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griCargaOperacion.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griCargaOperacion.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griCargaOperacion.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griCargaOperacion.DisplayLayout.Override.FixedHeaderIndicator = Infragistics.Win.UltraWinGrid.FixedHeaderIndicator.None
        Me.griCargaOperacion.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griCargaOperacion.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griCargaOperacion.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griCargaOperacion.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griCargaOperacion.DisplayLayout.Override.SummaryDisplayArea = Infragistics.Win.UltraWinGrid.SummaryDisplayAreas.BottomFixed
        Me.griCargaOperacion.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griCargaOperacion.DisplayLayout.UseFixedHeaders = True
        Me.griCargaOperacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griCargaOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griCargaOperacion.ImageList = Me.imagenes
        Me.griCargaOperacion.Location = New System.Drawing.Point(0, 0)
        Me.griCargaOperacion.Name = "griCargaOperacion"
        Me.griCargaOperacion.Size = New System.Drawing.Size(412, 221)
        Me.griCargaOperacion.TabIndex = 1
        Me.griCargaOperacion.Tag = ""
        '
        'ogdViaje
        '
        UltraDataColumn105.DataType = GetType(Date)
        UltraDataColumn153.DataType = GetType(Double)
        Me.ogdViaje.Band.Columns.AddRange(New Object() {UltraDataColumn86, UltraDataColumn87, UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100, UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110, UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120, UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129, UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138, UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153, UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158})
        '
        'grupoCabeceraInformeRenting
        '
        Appearance98.BackColor = System.Drawing.Color.White
        Appearance98.BackColor2 = System.Drawing.Color.White
        Me.grupoCabeceraInformeRenting.ContentAreaAppearance = Appearance98
        Me.grupoCabeceraInformeRenting.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.grupoCabeceraInformeRenting.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupoCabeceraInformeRenting.ExpandedSize = New System.Drawing.Size(1358, 100)
        Me.grupoCabeceraInformeRenting.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.grupoCabeceraInformeRenting.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.TopOnBorder
        Me.grupoCabeceraInformeRenting.Location = New System.Drawing.Point(0, 0)
        Me.grupoCabeceraInformeRenting.Name = "grupoCabeceraInformeRenting"
        Me.grupoCabeceraInformeRenting.Size = New System.Drawing.Size(1358, 100)
        Me.grupoCabeceraInformeRenting.TabIndex = 283
        Me.grupoCabeceraInformeRenting.Text = "Datos Generales Consulta Busqueda"
        Me.grupoCabeceraInformeRenting.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraExpandableGroupBox3)
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.UltraExpandableGroupBox1)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(3, 20)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(1352, 77)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'UltraExpandableGroupBox3
        '
        Appearance99.BackColor = System.Drawing.Color.White
        Appearance99.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox3.ContentAreaAppearance = Appearance99
        Me.UltraExpandableGroupBox3.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.UltraExpandableGroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.UltraExpandableGroupBox3.ExpandedSize = New System.Drawing.Size(280, 77)
        Me.UltraExpandableGroupBox3.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox3.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox3.Location = New System.Drawing.Point(1072, 0)
        Me.UltraExpandableGroupBox3.Name = "UltraExpandableGroupBox3"
        Me.UltraExpandableGroupBox3.Size = New System.Drawing.Size(280, 77)
        Me.UltraExpandableGroupBox3.TabIndex = 286
        Me.UltraExpandableGroupBox3.Text = "Variable"
        Me.UltraExpandableGroupBox3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.griVariables)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(257, 71)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'griVariables
        '
        Me.griVariables.ContextMenuStrip = Me.MenuZona
        Me.griVariables.DataSource = Me.ogdTarifasDetalles
        Appearance100.BackColor = System.Drawing.SystemColors.Window
        Appearance100.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griVariables.DisplayLayout.Appearance = Appearance100
        UltraGridColumn384.Header.VisiblePosition = 7
        UltraGridColumn384.Hidden = True
        UltraGridColumn385.Header.VisiblePosition = 8
        UltraGridColumn385.Hidden = True
        UltraGridColumn386.Header.VisiblePosition = 9
        UltraGridColumn386.Hidden = True
        UltraGridColumn387.Header.VisiblePosition = 0
        UltraGridColumn387.Width = 100
        Appearance101.TextHAlignAsString = "Right"
        UltraGridColumn388.CellAppearance = Appearance101
        UltraGridColumn388.Header.VisiblePosition = 3
        UltraGridColumn388.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn388.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn388.Width = 50
        Appearance102.TextHAlignAsString = "Right"
        UltraGridColumn389.CellAppearance = Appearance102
        UltraGridColumn389.Header.VisiblePosition = 1
        UltraGridColumn389.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn389.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn389.Width = 50
        Appearance103.TextHAlignAsString = "Right"
        UltraGridColumn390.CellAppearance = Appearance103
        UltraGridColumn390.Header.VisiblePosition = 2
        UltraGridColumn390.Hidden = True
        UltraGridColumn390.MaskInput = "{LOC}nnnnnnn.nn"
        UltraGridColumn390.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn390.Width = 60
        UltraGridColumn391.Header.VisiblePosition = 4
        UltraGridColumn391.Hidden = True
        UltraGridColumn391.Width = 80
        UltraGridColumn392.Header.VisiblePosition = 5
        UltraGridColumn392.Hidden = True
        UltraGridColumn392.Width = 40
        UltraGridColumn393.Header.VisiblePosition = 6
        UltraGridColumn393.Hidden = True
        UltraGridColumn393.Width = 40
        UltraGridColumn394.Header.VisiblePosition = 10
        UltraGridColumn394.Hidden = True
        UltraGridColumn395.Header.VisiblePosition = 11
        UltraGridColumn395.Hidden = True
        UltraGridColumn396.Header.VisiblePosition = 12
        UltraGridColumn396.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn384, UltraGridColumn385, UltraGridColumn386, UltraGridColumn387, UltraGridColumn388, UltraGridColumn389, UltraGridColumn390, UltraGridColumn391, UltraGridColumn392, UltraGridColumn393, UltraGridColumn394, UltraGridColumn395, UltraGridColumn396})
        Me.griVariables.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.griVariables.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVariables.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Appearance104.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance104.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance104.BorderColor = System.Drawing.SystemColors.Window
        Me.griVariables.DisplayLayout.GroupByBox.Appearance = Appearance104
        Appearance105.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVariables.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance105
        Me.griVariables.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVariables.DisplayLayout.GroupByBox.Hidden = True
        Appearance106.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance106.BackColor2 = System.Drawing.SystemColors.Control
        Appearance106.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance106.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVariables.DisplayLayout.GroupByBox.PromptAppearance = Appearance106
        Me.griVariables.DisplayLayout.MaxColScrollRegions = 1
        Me.griVariables.DisplayLayout.MaxRowScrollRegions = 1
        Me.griVariables.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griVariables.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVariables.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVariables.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVariables.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVariables.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVariables.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griVariables.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griVariables.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVariables.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVariables.Location = New System.Drawing.Point(0, 0)
        Me.griVariables.Name = "griVariables"
        Me.griVariables.Size = New System.Drawing.Size(257, 71)
        Me.griVariables.TabIndex = 3
        '
        'UltraExpandableGroupBox1
        '
        Appearance107.BackColor = System.Drawing.Color.White
        Appearance107.BackColor2 = System.Drawing.Color.White
        Me.UltraExpandableGroupBox1.ContentAreaAppearance = Appearance107
        Me.UltraExpandableGroupBox1.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.UltraExpandableGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UltraExpandableGroupBox1.ExpandedSize = New System.Drawing.Size(900, 77)
        Me.UltraExpandableGroupBox1.ExpansionIndicator = Infragistics.Win.Misc.GroupBoxExpansionIndicator.Near
        Me.UltraExpandableGroupBox1.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftInsideBorder
        Me.UltraExpandableGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraExpandableGroupBox1.Name = "UltraExpandableGroupBox1"
        Me.UltraExpandableGroupBox1.Size = New System.Drawing.Size(900, 77)
        Me.UltraExpandableGroupBox1.TabIndex = 285
        Me.UltraExpandableGroupBox1.Text = "Buscar"
        Me.UltraExpandableGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtIdOperacionProceso)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCostoFijoOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtCodigoOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.txtObservacionOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.colorCambio)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel12)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.btnListarViajesOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecHasta)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel39)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.decCostoTotalOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.decSemanaOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.fecDesde)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel7)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel41)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel9)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.decCostoAdicionalOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboClienteOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel10)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel2)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.decTotalOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboActividadNegocioOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel4)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboTractoOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.cboTipoCargaOP)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel3)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.UltraLabel15)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.VerFiltro)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(877, 71)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'txtIdOperacionProceso
        '
        Me.txtIdOperacionProceso.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIdOperacionProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdOperacionProceso.Location = New System.Drawing.Point(339, 48)
        Me.txtIdOperacionProceso.Name = "txtIdOperacionProceso"
        Me.txtIdOperacionProceso.ReadOnly = True
        Me.txtIdOperacionProceso.Size = New System.Drawing.Size(41, 21)
        Me.txtIdOperacionProceso.TabIndex = 287
        Me.txtIdOperacionProceso.Visible = False
        '
        'txtCostoFijoOP
        '
        Appearance108.TextHAlignAsString = "Right"
        Me.txtCostoFijoOP.Appearance = Appearance108
        Me.txtCostoFijoOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCostoFijoOP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.txtCostoFijoOP.InputMask = "{LOC}nnnnnnn.nn"
        Me.txtCostoFijoOP.Location = New System.Drawing.Point(428, 25)
        Me.txtCostoFijoOP.Name = "txtCostoFijoOP"
        Me.txtCostoFijoOP.NonAutoSizeHeight = 20
        Me.txtCostoFijoOP.Size = New System.Drawing.Size(80, 20)
        Me.txtCostoFijoOP.TabIndex = 269
        Me.txtCostoFijoOP.Text = "767.00"
        UltraToolTipInfo1.ToolTipText = "Costo Fijo"
        Me.UltraToolTipManager1.SetUltraToolTip(Me.txtCostoFijoOP, UltraToolTipInfo1)
        '
        'txtCodigoOP
        '
        Me.txtCodigoOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigoOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoOP.Location = New System.Drawing.Point(50, 48)
        Me.txtCodigoOP.Name = "txtCodigoOP"
        Me.txtCodigoOP.Size = New System.Drawing.Size(90, 21)
        Me.txtCodigoOP.TabIndex = 268
        '
        'txtObservacionOP
        '
        Me.txtObservacionOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtObservacionOP.Location = New System.Drawing.Point(773, 1)
        Me.txtObservacionOP.Multiline = True
        Me.txtObservacionOP.Name = "txtObservacionOP"
        Me.txtObservacionOP.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacionOP.Size = New System.Drawing.Size(100, 70)
        Me.txtObservacionOP.TabIndex = 267
        '
        'colorCambio
        '
        Me.colorCambio.Color = System.Drawing.Color.Cyan
        Me.colorCambio.Location = New System.Drawing.Point(560, 48)
        Me.colorCambio.Name = "colorCambio"
        Me.colorCambio.Size = New System.Drawing.Size(44, 21)
        Me.colorCambio.TabIndex = 54
        Me.colorCambio.Text = "Cyan"
        Me.colorCambio.Visible = False
        '
        'UltraLabel12
        '
        Appearance109.BackColor = System.Drawing.Color.Transparent
        Appearance109.ForeColor = System.Drawing.Color.Navy
        Appearance109.TextVAlignAsString = "Middle"
        Me.UltraLabel12.Appearance = Appearance109
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(616, 51)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel12.TabIndex = 265
        Me.UltraLabel12.Text = "Costo Total:"
        '
        'btnListarViajesOP
        '
        Appearance110.Image = 6
        Appearance110.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnListarViajesOP.Appearance = Appearance110
        Me.btnListarViajesOP.ImageList = Me.imagenes
        Me.btnListarViajesOP.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnListarViajesOP.Location = New System.Drawing.Point(514, 41)
        Me.btnListarViajesOP.Name = "btnListarViajesOP"
        Me.btnListarViajesOP.Size = New System.Drawing.Size(40, 30)
        Me.btnListarViajesOP.TabIndex = 261
        '
        'fecHasta
        '
        Me.fecHasta.DateTime = New Date(2014, 1, 2, 0, 0, 0, 0)
        Me.fecHasta.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecHasta.Location = New System.Drawing.Point(50, 25)
        Me.fecHasta.MaskInput = ""
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(90, 21)
        Me.fecHasta.TabIndex = 50
        Me.fecHasta.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'UltraLabel39
        '
        Appearance111.BackColor = System.Drawing.Color.Transparent
        Appearance111.ForeColor = System.Drawing.Color.Navy
        Appearance111.TextVAlignAsString = "Middle"
        Me.UltraLabel39.Appearance = Appearance111
        Me.UltraLabel39.AutoSize = True
        Me.UltraLabel39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel39.Location = New System.Drawing.Point(10, 29)
        Me.UltraLabel39.Name = "UltraLabel39"
        Me.UltraLabel39.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel39.TabIndex = 49
        Me.UltraLabel39.Text = "Hasta:"
        '
        'decCostoTotalOP
        '
        Appearance112.TextHAlignAsString = "Right"
        Me.decCostoTotalOP.Appearance = Appearance112
        Me.decCostoTotalOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCostoTotalOP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.decCostoTotalOP.InputMask = "{LOC}nnnnnnn.nn"
        Me.decCostoTotalOP.Location = New System.Drawing.Point(682, 48)
        Me.decCostoTotalOP.Name = "decCostoTotalOP"
        Me.decCostoTotalOP.NonAutoSizeHeight = 20
        Me.decCostoTotalOP.Size = New System.Drawing.Size(80, 20)
        Me.decCostoTotalOP.TabIndex = 266
        Me.decCostoTotalOP.Text = "0.00"
        '
        'decSemanaOP
        '
        Appearance113.TextHAlignAsString = "Right"
        Me.decSemanaOP.Appearance = Appearance113
        Me.decSemanaOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decSemanaOP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.decSemanaOP.InputMask = "{LOC}nnnnnnn.nn"
        Me.decSemanaOP.Location = New System.Drawing.Point(562, 3)
        Me.decSemanaOP.Name = "decSemanaOP"
        Me.decSemanaOP.NonAutoSizeHeight = 20
        Me.decSemanaOP.Size = New System.Drawing.Size(80, 20)
        Me.decSemanaOP.TabIndex = 260
        Me.decSemanaOP.Text = "0.00"
        '
        'fecDesde
        '
        Me.fecDesde.DateTime = New Date(2014, 1, 2, 0, 0, 0, 0)
        Me.fecDesde.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.fecDesde.Location = New System.Drawing.Point(50, 2)
        Me.fecDesde.MaskInput = ""
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(90, 21)
        Me.fecDesde.TabIndex = 48
        Me.fecDesde.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'UltraLabel7
        '
        Appearance114.BackColor = System.Drawing.Color.Transparent
        Appearance114.ForeColor = System.Drawing.Color.Navy
        Appearance114.TextVAlignAsString = "Middle"
        Me.UltraLabel7.Appearance = Appearance114
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(511, 6)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel7.TabIndex = 259
        Me.UltraLabel7.Text = "Semana:"
        '
        'UltraLabel41
        '
        Appearance115.BackColor = System.Drawing.Color.Transparent
        Appearance115.ForeColor = System.Drawing.Color.Navy
        Appearance115.TextVAlignAsString = "Middle"
        Me.UltraLabel41.Appearance = Appearance115
        Me.UltraLabel41.AutoSize = True
        Me.UltraLabel41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel41.Location = New System.Drawing.Point(7, 6)
        Me.UltraLabel41.Name = "UltraLabel41"
        Me.UltraLabel41.Size = New System.Drawing.Size(41, 14)
        Me.UltraLabel41.TabIndex = 47
        Me.UltraLabel41.Text = "Desde:"
        '
        'UltraLabel9
        '
        Appearance116.BackColor = System.Drawing.Color.Transparent
        Appearance116.ForeColor = System.Drawing.Color.Navy
        Appearance116.TextVAlignAsString = "Middle"
        Me.UltraLabel9.Appearance = Appearance116
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(595, 29)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(86, 14)
        Me.UltraLabel9.TabIndex = 261
        Me.UltraLabel9.Text = "Costo Adicional:"
        '
        'decCostoAdicionalOP
        '
        Appearance117.TextHAlignAsString = "Right"
        Me.decCostoAdicionalOP.Appearance = Appearance117
        Me.decCostoAdicionalOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decCostoAdicionalOP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.decCostoAdicionalOP.InputMask = "{LOC}nnnnnnn.nn"
        Me.decCostoAdicionalOP.Location = New System.Drawing.Point(682, 26)
        Me.decCostoAdicionalOP.Name = "decCostoAdicionalOP"
        Me.decCostoAdicionalOP.NonAutoSizeHeight = 20
        Me.decCostoAdicionalOP.Size = New System.Drawing.Size(80, 20)
        Me.decCostoAdicionalOP.TabIndex = 262
        Me.decCostoAdicionalOP.Text = "0.00"
        '
        'cboClienteOP
        '
        Appearance118.ForeColor = System.Drawing.Color.Black
        Me.cboClienteOP.Appearance = Appearance118
        Me.cboClienteOP.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboClienteOP.DisplayMember = "Nombre"
        Me.cboClienteOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboClienteOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteOP.ForeColor = System.Drawing.Color.Black
        Me.cboClienteOP.ImageList = Me.imagenes
        Me.cboClienteOP.Location = New System.Drawing.Point(208, 2)
        Me.cboClienteOP.Name = "cboClienteOP"
        Me.cboClienteOP.Size = New System.Drawing.Size(300, 21)
        Me.cboClienteOP.TabIndex = 260
        Me.cboClienteOP.ValueMember = "Id"
        '
        'UltraLabel10
        '
        Appearance119.BackColor = System.Drawing.Color.Transparent
        Appearance119.ForeColor = System.Drawing.Color.Navy
        Appearance119.TextVAlignAsString = "Middle"
        Me.UltraLabel10.Appearance = Appearance119
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(648, 7)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel10.TabIndex = 263
        Me.UltraLabel10.Text = "Total:"
        '
        'UltraLabel2
        '
        Appearance120.BackColor = System.Drawing.Color.Transparent
        Appearance120.ForeColor = System.Drawing.Color.Navy
        Appearance120.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance120
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(157, 29)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(49, 14)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Proceso:"
        '
        'decTotalOP
        '
        Appearance121.TextHAlignAsString = "Right"
        Me.decTotalOP.Appearance = Appearance121
        Me.decTotalOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.decTotalOP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.[Double]
        Me.decTotalOP.InputMask = "{LOC}nnnnnnn.nn"
        Me.decTotalOP.Location = New System.Drawing.Point(682, 4)
        Me.decTotalOP.Name = "decTotalOP"
        Me.decTotalOP.NonAutoSizeHeight = 20
        Me.decTotalOP.Size = New System.Drawing.Size(80, 20)
        Me.decTotalOP.TabIndex = 264
        Me.decTotalOP.Text = "0.00"
        '
        'cboActividadNegocioOP
        '
        Appearance122.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocioOP.Appearance = Appearance122
        Me.cboActividadNegocioOP.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Me.cboActividadNegocioOP.DisplayMember = "Nombre"
        Me.cboActividadNegocioOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboActividadNegocioOP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboActividadNegocioOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActividadNegocioOP.ForeColor = System.Drawing.Color.Black
        Me.cboActividadNegocioOP.ImageList = Me.imagenes
        Me.cboActividadNegocioOP.Location = New System.Drawing.Point(208, 25)
        Me.cboActividadNegocioOP.Name = "cboActividadNegocioOP"
        Me.cboActividadNegocioOP.Size = New System.Drawing.Size(175, 21)
        Me.cboActividadNegocioOP.TabIndex = 5
        Me.cboActividadNegocioOP.ValueMember = "Id"
        '
        'UltraLabel4
        '
        Appearance123.BackColor = System.Drawing.Color.Transparent
        Appearance123.ForeColor = System.Drawing.Color.Navy
        Appearance123.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance123
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(163, 6)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(43, 14)
        Me.UltraLabel4.TabIndex = 259
        Me.UltraLabel4.Text = "Cliente:"
        '
        'cboTractoOP
        '
        Appearance124.ForeColor = System.Drawing.Color.Black
        Me.cboTractoOP.Appearance = Appearance124
        Me.cboTractoOP.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTractoOP.DisplayMember = ""
        Me.cboTractoOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTractoOP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTractoOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTractoOP.ForeColor = System.Drawing.Color.Black
        Me.cboTractoOP.Location = New System.Drawing.Point(428, 48)
        Me.cboTractoOP.Name = "cboTractoOP"
        Me.cboTractoOP.Size = New System.Drawing.Size(80, 21)
        Me.cboTractoOP.TabIndex = 255
        Me.cboTractoOP.ValueMember = "Id"
        '
        'cboTipoCargaOP
        '
        Appearance125.ForeColor = System.Drawing.Color.Black
        Me.cboTipoCargaOP.Appearance = Appearance125
        Me.cboTipoCargaOP.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoCargaOP.DisplayMember = "Nombre"
        Me.cboTipoCargaOP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoCargaOP.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoCargaOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoCargaOP.ForeColor = System.Drawing.Color.Black
        Me.cboTipoCargaOP.ImageList = Me.imagenes
        Me.cboTipoCargaOP.Location = New System.Drawing.Point(208, 48)
        Me.cboTipoCargaOP.Name = "cboTipoCargaOP"
        Me.cboTipoCargaOP.Size = New System.Drawing.Size(125, 21)
        Me.cboTipoCargaOP.TabIndex = 258
        Me.cboTipoCargaOP.ValueMember = "Id"
        '
        'UltraLabel3
        '
        Appearance126.BackColor = System.Drawing.Color.Transparent
        Appearance126.ForeColor = System.Drawing.Color.Navy
        Appearance126.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance126
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(386, 52)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(39, 14)
        Me.UltraLabel3.TabIndex = 256
        Me.UltraLabel3.Text = "Tracto:"
        '
        'UltraLabel15
        '
        Appearance127.BackColor = System.Drawing.Color.Transparent
        Appearance127.ForeColor = System.Drawing.Color.Navy
        Appearance127.TextVAlignAsString = "Middle"
        Me.UltraLabel15.Appearance = Appearance127
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(144, 52)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel15.TabIndex = 257
        Me.UltraLabel15.Text = "Tipo Carga:"
        '
        'VerFiltro
        '
        Appearance128.ForeColor = System.Drawing.Color.Navy
        Me.VerFiltro.Appearance = Appearance128
        Me.VerFiltro.AutoSize = True
        Me.VerFiltro.BackColor = System.Drawing.Color.Transparent
        Me.VerFiltro.BackColorInternal = System.Drawing.Color.Transparent
        Me.VerFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerFiltro.ForeColor = System.Drawing.Color.Black
        Me.VerFiltro.Location = New System.Drawing.Point(3, 50)
        Me.VerFiltro.Name = "VerFiltro"
        Me.VerFiltro.Size = New System.Drawing.Size(46, 17)
        Me.VerFiltro.TabIndex = 271
        Me.VerFiltro.Text = "Filtro"
        '
        'UltraTabPageControl7
        '
        Me.UltraTabPageControl7.Controls.Add(Me.ficListaVOP)
        Me.UltraTabPageControl7.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl7.Name = "UltraTabPageControl7"
        Me.UltraTabPageControl7.Size = New System.Drawing.Size(1346, 538)
        '
        'ficListaVOP
        '
        Me.ficListaVOP.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficListaVOP.Controls.Add(Me.UltraTabPageControl1)
        Me.ficListaVOP.Controls.Add(Me.UltraTabPageControl2)
        Me.ficListaVOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficListaVOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficListaVOP.Location = New System.Drawing.Point(0, 0)
        Me.ficListaVOP.Name = "ficListaVOP"
        Me.ficListaVOP.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficListaVOP.Size = New System.Drawing.Size(1346, 538)
        Me.ficListaVOP.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficListaVOP.TabIndex = 2
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Vehiculo / Piloto (Proceso)"
        UltraTab5.TabPage = Me.UltraTabPageControl2
        UltraTab5.Text = "Operaciones (Proceso)"
        Me.ficListaVOP.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab5})
        Me.ficListaVOP.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1344, 515)
        '
        'utpDetalle
        '
        Me.utpDetalle.Controls.Add(Me.ficMantenimiento)
        Me.utpDetalle.Location = New System.Drawing.Point(-10000, -10000)
        Me.utpDetalle.Name = "utpDetalle"
        Me.utpDetalle.Size = New System.Drawing.Size(1360, 538)
        '
        'ficMantenimiento
        '
        Me.ficMantenimiento.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl3)
        Me.ficMantenimiento.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.ficMantenimiento.Name = "ficMantenimiento"
        Me.ficMantenimiento.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.ficMantenimiento.Size = New System.Drawing.Size(1360, 538)
        Me.ficMantenimiento.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Office2007Ribbon
        Me.ficMantenimiento.TabIndex = 5
        UltraTab2.TabPage = Me.UltraTabPageControl3
        UltraTab2.Text = "VEHICULO-PILOTO-ZONA"
        UltraTab3.TabPage = Me.UltraTabPageControl4
        UltraTab3.Text = "RENTING"
        Me.ficMantenimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab3})
        Me.ficMantenimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.VisualStudio2005
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(1358, 515)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(380, 236)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 6
        Me.ugb_Espera.Visible = False
        '
        'ficDemanda
        '
        Me.ficDemanda.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficDemanda.Controls.Add(Me.UltraTabPageControl7)
        Me.ficDemanda.Controls.Add(Me.utpDetalle)
        Me.ficDemanda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficDemanda.Location = New System.Drawing.Point(0, 0)
        Me.ficDemanda.Name = "ficDemanda"
        Me.ficDemanda.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficDemanda.Size = New System.Drawing.Size(1348, 561)
        Me.ficDemanda.TabIndex = 1
        UltraTab6.Key = "Lista"
        UltraTab6.TabPage = Me.UltraTabPageControl7
        UltraTab6.Text = "Lista"
        UltraTab4.Key = "Mantenimiento"
        UltraTab4.TabPage = Me.utpDetalle
        UltraTab4.Text = "Mantenimiento"
        Me.ficDemanda.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab6, UltraTab4})
        Me.ficDemanda.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1346, 538)
        '
        'UltraToolTipManager1
        '
        Me.UltraToolTipManager1.ContainingControl = Me
        Me.UltraToolTipManager1.DisplayStyle = Infragistics.Win.ToolTipDisplayStyle.BalloonTip
        Me.UltraToolTipManager1.ToolTipImage = Infragistics.Win.ToolTipImage.Info
        Me.UltraToolTipManager1.ToolTipTitle = "Mensaje del Sistema"
        '
        'frm_VehiculoPilotoOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 561)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficDemanda)
        Me.Name = "frm_VehiculoPilotoOperacion"
        Me.Text = "Vehiculo/Piloto(Proceso)"
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.ogdVehiculoPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.griOPLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuProceso.ResumeLayout(False)
        CType(Me.ogdOperacionProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrBusqueda.ResumeLayout(False)
        Me.agrBusqueda.PerformLayout()
        CType(Me.txtCodigoSemanaLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox2.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.griTarifasDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuZona.ResumeLayout(False)
        CType(Me.ogdTarifasDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griVehiculoPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        Me.UltraGroupBox4.PerformLayout()
        CType(Me.grupoZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoZona.ResumeLayout(False)
        Me.grupoZona.PerformLayout()
        CType(Me.cboZona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTracto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opcVehiculoPiloto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActividadNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.griViajesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdViajesProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox6.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.griTarifasProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdTarifasProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox7.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel7.ResumeLayout(False)
        CType(Me.griCargaOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ogdViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grupoCabeceraInformeRenting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoCabeceraInformeRenting.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.UltraExpandableGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox3.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.griVariables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraExpandableGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraExpandableGroupBox1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.PerformLayout()
        CType(Me.txtIdOperacionProceso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacionOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colorCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fecDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboClienteOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboActividadNegocioOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTractoOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCargaOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl7.ResumeLayout(False)
        CType(Me.ficListaVOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficListaVOP.ResumeLayout(False)
        Me.utpDetalle.ResumeLayout(False)
        CType(Me.ficMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMantenimiento.ResumeLayout(False)
        CType(Me.ficDemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficDemanda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficDemanda As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl7 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents utpDetalle As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents griVehiculoPiloto As ISL.Controles.Grilla
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verActual As ISL.Controles.Chequear
    Friend WithEvents btnAgregar As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txtObservacion As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cboCliente As ISL.Controles.ComboMaestros
    Friend WithEvents cboActividadNegocio As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel34 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel38 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents opcVehiculoPiloto As ISL.Controles.Opciones
    Friend WithEvents txtIndHistorial As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecFin As ISL.Controles.Fecha
    Friend WithEvents fecInicio As ISL.Controles.Fecha
    Friend WithEvents Etiqueta50 As ISL.Controles.Etiqueta
    Friend WithEvents cboPiloto As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel28 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTracto As ISL.Controles.Combo
    Friend WithEvents txtId As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents ogdVehiculoPiloto As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Private WithEvents Menu As ISL.Controles.MenuContextual
    Friend WithEvents Insert As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents Update As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents ficListaVOP As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraExpandableGroupBox2 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ogdViajesProceso As ISL.Controles.OrigenDatos
    Friend WithEvents griTarifasDetalles As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdTarifasProceso As ISL.Controles.OrigenDatos
    Friend WithEvents ogdTarifasDetalles As ISL.Controles.OrigenDatos
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboZona As ISL.Controles.ComboMaestros
    Private WithEvents MenuZona As ISL.Controles.MenuContextual
    Friend WithEvents MZnuevo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MZactualizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MZeliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMonto As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel36 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtSemana As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtCostoFijo As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents grupoZona As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ogdViaje As ISL.Controles.OrigenDatos
    Friend WithEvents ficMantenimiento As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents grupoCabeceraInformeRenting As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox6 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents UltraExpandableGroupBox7 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel7 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griVariables As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griViajesProceso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraExpandableGroupBox3 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents griCargaOperacion As ISL.Controles.Grilla
    Friend WithEvents UltraExpandableGroupBox1 As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents fecHasta As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel39 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents fecDesde As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel41 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboClienteOP As ISL.Controles.ComboMaestros
    Friend WithEvents colorCambio As ISL.Controles.Colores
    Friend WithEvents btnListarViajesOP As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboActividadNegocioOP As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboTractoOP As ISL.Controles.Combo
    Friend WithEvents cboTipoCargaOP As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txtCodigoOP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtObservacionOP As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decCostoTotalOP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents decSemanaOP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decCostoAdicionalOP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents decTotalOP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents UltraToolTipManager1 As Infragistics.Win.UltraWinToolTip.UltraToolTipManager
    Friend WithEvents griTarifasProceso As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents griOPLista As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ogdOperacionProceso As ISL.Controles.OrigenDatos
    Friend WithEvents agrBusqueda As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtCostoFijoOP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents VerFiltro As ISL.Controles.Chequear
    Friend WithEvents txtCodigoSemanaLista As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents fecSemana As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Private WithEvents MenuProceso As ISL.Controles.MenuContextual
    Friend WithEvents NuevoInforme As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents EditarInforme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarInforme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarInforme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCostoFijoLista As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
    Friend WithEvents txtIdOperacionProceso As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
