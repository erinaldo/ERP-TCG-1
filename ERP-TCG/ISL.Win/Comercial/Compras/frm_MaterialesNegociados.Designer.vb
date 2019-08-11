<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MaterialesNegociados
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
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialesNegociados")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialesNegociados")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialesNegociados")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaInicio")
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin")
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
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCotizacion")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Almacen")
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoMaterial")
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoCotizacion")
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdRequerimientoMaterial")
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PosMat")
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoCotizacion")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Proveedor")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Fecha")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vigente")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Band 1")
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 1", 0)
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterialesNegociados")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Moneda")
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Glosa")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMoneda")
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
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
        Dim UltraDataBand1 As Infragistics.Win.UltraWinDataSource.UltraDataBand = New Infragistics.Win.UltraWinDataSource.UltraDataBand("Band 1")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterialesNegociados")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Moneda")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMoneda")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Proveedor")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdProveedor")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Fecha")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vigente")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Glosa")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab6 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool13 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool14 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utMenuDetalle")
        Dim ButtonTool17 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Editar")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Eliminar")
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool10 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Cancelar")
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool12 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Nuevo")
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool15 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool1")
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool16 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool2")
        Dim ButtonTool18 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("ButtonTool3")
        Dim ButtonTool9 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool19 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griMatNegDet = New ISL.Controles.Grilla(Me.components)
        Me.odMatNegDet = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griHistorial = New ISL.Controles.Grilla(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.numPrecio = New ISL.Controles.NumeroDecimal(Me.components)
        Me.cboMoneda = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cboMateriales = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.griListadoCotizacionDetalle = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.rfFechaCotHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.rfFechaCotDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnBuscarCot = New ISL.Controles.Boton(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrRequerimientos = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuVigencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripClonarContrato = New System.Windows.Forms.ToolStripMenuItem()
        Me.odMatNeg = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.ColoresCaducado = New ISL.Controles.Colores(Me.components)
        Me.ColoresVigente = New ISL.Controles.Colores(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.rangoFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.rangoFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.agrMaterialNegocio = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage3 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.ficMatCot = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraToolbarsDockArea1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.MenuDetalle = New ISL.Controles.Menu(Me.components)
        Me.UltraToolbarsDockArea2 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea3 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraToolbarsDockArea4 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.chkRuc2 = New ISL.Controles.Chequear(Me.components)
        Me.cboProveedorL = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.fecFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ficMaterialesNegociables = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.griMatNegDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMatNegDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrRequerimientos.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu.SuspendLayout()
        CType(Me.odMatNeg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.ColoresCaducado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.agrMaterialNegocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrMaterialNegocio.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.ficMatCot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMatCot.SuspendLayout()
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficMaterialesNegociables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficMaterialesNegociables.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.griMatNegDet)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(454, 290)
        '
        'griMatNegDet
        '
        Me.griMatNegDet.DataSource = Me.odMatNegDet
        UltraGridColumn50.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn50.Header.VisiblePosition = 0
        UltraGridColumn50.Hidden = True
        UltraGridColumn50.Width = 38
        UltraGridColumn51.Header.VisiblePosition = 1
        UltraGridColumn51.Hidden = True
        UltraGridColumn52.Header.VisiblePosition = 2
        UltraGridColumn52.Hidden = True
        UltraGridColumn53.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn53.Header.VisiblePosition = 3
        UltraGridColumn54.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn54.Header.VisiblePosition = 4
        UltraGridColumn54.Width = 419
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn55.CellAppearance = Appearance1
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn55.Header.Appearance = Appearance2
        UltraGridColumn55.Header.Caption = "Moneda"
        UltraGridColumn55.Header.VisiblePosition = 5
        UltraGridColumn55.Width = 67
        UltraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        Appearance3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Appearance3.TextHAlignAsString = "Right"
        UltraGridColumn56.CellAppearance = Appearance3
        UltraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance4.TextHAlignAsString = "Right"
        UltraGridColumn56.Header.Appearance = Appearance4
        UltraGridColumn56.Header.VisiblePosition = 6
        UltraGridColumn56.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn56.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn56.Width = 89
        Appearance5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn57.CellAppearance = Appearance5
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn57.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn57.Header.VisiblePosition = 7
        UltraGridColumn57.Hidden = True
        UltraGridColumn57.Width = 300
        UltraGridColumn58.Header.VisiblePosition = 8
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.Header.VisiblePosition = 9
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 10
        UltraGridColumn60.Hidden = True
        UltraGridColumn61.Header.VisiblePosition = 11
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn62.Header.Appearance = Appearance6
        UltraGridColumn62.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn62.Header.VisiblePosition = 12
        UltraGridColumn62.Width = 61
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn84.Header.VisiblePosition = 13
        UltraGridColumn84.Width = 76
        UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn85.Header.VisiblePosition = 14
        UltraGridColumn85.Width = 74
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn84, UltraGridColumn85})
        Me.griMatNegDet.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griMatNegDet.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance7.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance7.BorderColor = System.Drawing.SystemColors.Window
        Me.griMatNegDet.DisplayLayout.GroupByBox.Appearance = Appearance7
        Appearance8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMatNegDet.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance8
        Me.griMatNegDet.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griMatNegDet.DisplayLayout.GroupByBox.Hidden = True
        Appearance9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance9.BackColor2 = System.Drawing.SystemColors.Control
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griMatNegDet.DisplayLayout.GroupByBox.PromptAppearance = Appearance9
        Me.griMatNegDet.DisplayLayout.MaxColScrollRegions = 1
        Me.griMatNegDet.DisplayLayout.MaxRowScrollRegions = 1
        Me.griMatNegDet.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMatNegDet.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMatNegDet.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griMatNegDet.DisplayLayout.Override.CellPadding = 0
        Me.griMatNegDet.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griMatNegDet.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griMatNegDet.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griMatNegDet.DisplayLayout.Override.GroupByRowAppearance = Appearance10
        Appearance11.TextHAlignAsString = "Left"
        Me.griMatNegDet.DisplayLayout.Override.HeaderAppearance = Appearance11
        Me.griMatNegDet.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griMatNegDet.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Appearance12.BorderColor = System.Drawing.Color.Silver
        Me.griMatNegDet.DisplayLayout.Override.RowAppearance = Appearance12
        Me.griMatNegDet.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griMatNegDet.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griMatNegDet.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griMatNegDet.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griMatNegDet.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griMatNegDet.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griMatNegDet.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griMatNegDet.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griMatNegDet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griMatNegDet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griMatNegDet.Location = New System.Drawing.Point(0, 0)
        Me.griMatNegDet.Name = "griMatNegDet"
        Me.griMatNegDet.Size = New System.Drawing.Size(454, 290)
        Me.griMatNegDet.TabIndex = 0
        Me.griMatNegDet.Text = "Grilla2"
        '
        'odMatNegDet
        '
        UltraDataColumn1.DataType = GetType(Boolean)
        UltraDataColumn1.DefaultValue = False
        UltraDataColumn7.DataType = GetType(Double)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn14.DataType = GetType(Date)
        UltraDataColumn15.DataType = GetType(Date)
        Me.odMatNegDet.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.griHistorial)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(987, 265)
        '
        'griHistorial
        '
        Me.griHistorial.DataSource = Me.odMatNegDet
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn137.Header.VisiblePosition = 0
        UltraGridColumn137.Hidden = True
        UltraGridColumn137.Width = 38
        UltraGridColumn138.Header.VisiblePosition = 1
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 2
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn140.Header.VisiblePosition = 3
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn141.Header.VisiblePosition = 4
        UltraGridColumn141.Width = 419
        Appearance13.TextHAlignAsString = "Center"
        UltraGridColumn142.CellAppearance = Appearance13
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn142.Header.Appearance = Appearance14
        UltraGridColumn142.Header.Caption = "Moneda"
        UltraGridColumn142.Header.VisiblePosition = 5
        UltraGridColumn142.Width = 67
        Appearance15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance15.TextHAlignAsString = "Right"
        UltraGridColumn143.CellAppearance = Appearance15
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance16.TextHAlignAsString = "Right"
        UltraGridColumn143.Header.Appearance = Appearance16
        UltraGridColumn143.Header.VisiblePosition = 6
        UltraGridColumn143.MaskInput = "{LOC}nnnnnnn.nnnn"
        UltraGridColumn143.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Double]
        UltraGridColumn143.Width = 89
        Appearance17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        UltraGridColumn144.CellAppearance = Appearance17
        UltraGridColumn144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn144.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        UltraGridColumn144.Header.VisiblePosition = 7
        UltraGridColumn144.Hidden = True
        UltraGridColumn144.Width = 300
        UltraGridColumn145.Header.VisiblePosition = 8
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.Header.VisiblePosition = 9
        UltraGridColumn146.Hidden = True
        UltraGridColumn147.Header.VisiblePosition = 10
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 11
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn149.Header.Appearance = Appearance18
        UltraGridColumn149.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Never
        UltraGridColumn149.Header.VisiblePosition = 12
        UltraGridColumn149.Width = 61
        UltraGridColumn150.Header.VisiblePosition = 13
        UltraGridColumn150.Width = 76
        UltraGridColumn151.Header.VisiblePosition = 14
        UltraGridColumn151.Width = 74
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151})
        Me.griHistorial.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.griHistorial.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance19.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance19.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance19.BorderColor = System.Drawing.SystemColors.Window
        Me.griHistorial.DisplayLayout.GroupByBox.Appearance = Appearance19
        Appearance20.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorial.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance20
        Me.griHistorial.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griHistorial.DisplayLayout.GroupByBox.Hidden = True
        Appearance21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance21.BackColor2 = System.Drawing.SystemColors.Control
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griHistorial.DisplayLayout.GroupByBox.PromptAppearance = Appearance21
        Me.griHistorial.DisplayLayout.MaxColScrollRegions = 1
        Me.griHistorial.DisplayLayout.MaxRowScrollRegions = 1
        Me.griHistorial.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorial.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griHistorial.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griHistorial.DisplayLayout.Override.CellPadding = 0
        Me.griHistorial.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griHistorial.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griHistorial.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griHistorial.DisplayLayout.Override.GroupByRowAppearance = Appearance22
        Appearance23.TextHAlignAsString = "Left"
        Me.griHistorial.DisplayLayout.Override.HeaderAppearance = Appearance23
        Me.griHistorial.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griHistorial.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance24.BackColor = System.Drawing.SystemColors.Window
        Appearance24.BorderColor = System.Drawing.Color.Silver
        Me.griHistorial.DisplayLayout.Override.RowAppearance = Appearance24
        Me.griHistorial.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griHistorial.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griHistorial.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griHistorial.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griHistorial.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griHistorial.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griHistorial.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.griHistorial.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griHistorial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griHistorial.Location = New System.Drawing.Point(0, 0)
        Me.griHistorial.Name = "griHistorial"
        Me.griHistorial.Size = New System.Drawing.Size(987, 265)
        Me.griHistorial.TabIndex = 1
        Me.griHistorial.Text = "Grilla2"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(530, 284)
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel5)
        Me.UltraGroupBox1.Controls.Add(Me.numPrecio)
        Me.UltraGroupBox1.Controls.Add(Me.cboMoneda)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel6)
        Me.UltraGroupBox1.Controls.Add(Me.UltraLabel4)
        Me.UltraGroupBox1.Controls.Add(Me.cboMateriales)
        Me.UltraGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(530, 284)
        Me.UltraGroupBox1.TabIndex = 0
        Me.UltraGroupBox1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel5
        '
        Appearance25.BackColor = System.Drawing.Color.Transparent
        Appearance25.ForeColor = System.Drawing.Color.Navy
        Appearance25.TextVAlignAsString = "Middle"
        Me.UltraLabel5.Appearance = Appearance25
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel5.Location = New System.Drawing.Point(158, 40)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel5.TabIndex = 4
        Me.UltraLabel5.Text = "Precio:"
        '
        'numPrecio
        '
        Appearance26.ForeColor = System.Drawing.Color.Black
        Me.numPrecio.Appearance = Appearance26
        Me.numPrecio.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.numPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrecio.ForeColor = System.Drawing.Color.Black
        Me.numPrecio.Location = New System.Drawing.Point(202, 36)
        Me.numPrecio.MaskInput = "{LOC}nn,nnn,nnn,nnn.nnnn"
        Me.numPrecio.Name = "numPrecio"
        Me.numPrecio.NullText = "0.00"
        Me.numPrecio.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.numPrecio.Size = New System.Drawing.Size(126, 21)
        Me.numPrecio.TabIndex = 5
        '
        'cboMoneda
        '
        Appearance27.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Appearance = Appearance27
        Me.cboMoneda.DisplayMember = "Nombre"
        Me.cboMoneda.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMoneda.DropDownListWidth = 180
        Me.cboMoneda.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.ForeColor = System.Drawing.Color.Black
        Me.cboMoneda.Location = New System.Drawing.Point(72, 36)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(80, 21)
        Me.cboMoneda.TabIndex = 3
        Me.cboMoneda.ValueMember = "Id"
        '
        'UltraLabel6
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Appearance28.TextVAlignAsString = "Middle"
        Me.UltraLabel6.Appearance = Appearance28
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel6.Location = New System.Drawing.Point(18, 40)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel6.TabIndex = 2
        Me.UltraLabel6.Text = "Moneda:"
        '
        'UltraLabel4
        '
        Appearance29.BackColor = System.Drawing.Color.Transparent
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Appearance29.TextVAlignAsString = "Middle"
        Me.UltraLabel4.Appearance = Appearance29
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel4.Location = New System.Drawing.Point(18, 12)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(48, 15)
        Me.UltraLabel4.TabIndex = 0
        Me.UltraLabel4.Text = "Material:"
        '
        'cboMateriales
        '
        Me.cboMateriales.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest
        Me.cboMateriales.AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains
        Me.cboMateriales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cboMateriales.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboMateriales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMateriales.Location = New System.Drawing.Point(72, 7)
        Me.cboMateriales.Name = "cboMateriales"
        Me.cboMateriales.Size = New System.Drawing.Size(415, 23)
        Me.cboMateriales.TabIndex = 1
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.griListadoCotizacionDetalle)
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl5.Enabled = False
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(530, 284)
        '
        'griListadoCotizacionDetalle
        '
        UltraGridColumn29.Header.VisiblePosition = 0
        UltraGridColumn29.Hidden = True
        UltraGridColumn29.Width = 85
        UltraGridColumn30.Header.VisiblePosition = 1
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 2
        UltraGridColumn31.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 6
        UltraGridColumn32.Width = 253
        Appearance30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance30.TextHAlignAsString = "Right"
        UltraGridColumn33.CellAppearance = Appearance30
        UltraGridColumn33.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn33.Header.VisiblePosition = 7
        UltraGridColumn33.MaskInput = "{double:9.4}"
        UltraGridColumn34.Header.VisiblePosition = 14
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 13
        UltraGridColumn35.Hidden = True
        UltraGridColumn36.Header.VisiblePosition = 15
        UltraGridColumn36.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 12
        UltraGridColumn37.Hidden = True
        UltraGridColumn37.Width = 180
        UltraGridColumn38.Header.Caption = "Unidad de medida"
        UltraGridColumn38.Header.VisiblePosition = 11
        UltraGridColumn39.Header.VisiblePosition = 9
        UltraGridColumn39.Hidden = True
        UltraGridColumn39.Width = 305
        UltraGridColumn40.Header.VisiblePosition = 10
        UltraGridColumn40.Width = 257
        UltraGridColumn41.Header.Caption = "Codigo"
        UltraGridColumn41.Header.VisiblePosition = 5
        UltraGridColumn42.Header.VisiblePosition = 16
        UltraGridColumn42.Hidden = True
        UltraGridColumn43.Header.VisiblePosition = 17
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.Header.VisiblePosition = 18
        UltraGridColumn44.Hidden = True
        UltraGridColumn45.Header.VisiblePosition = 19
        UltraGridColumn45.Hidden = True
        Appearance31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Appearance31.TextHAlignAsString = "Right"
        UltraGridColumn46.CellAppearance = Appearance31
        UltraGridColumn46.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn46.Hidden = True
        UltraGridColumn46.MaskInput = "{LOC}nnnnnnnnnnnnnn.nnnn"
        UltraGridColumn47.Header.Caption = "Cotización"
        UltraGridColumn47.Header.VisiblePosition = 4
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn48.Header.VisiblePosition = 3
        UltraGridColumn48.Width = 37
        UltraGridColumn49.Header.VisiblePosition = 20
        UltraGridColumn49.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49})
        Me.griListadoCotizacionDetalle.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griListadoCotizacionDetalle.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector
        Me.griListadoCotizacionDetalle.DisplayLayout.GroupByBox.Hidden = True
        Me.griListadoCotizacionDetalle.DisplayLayout.MaxColScrollRegions = 1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellAppearance = Appearance32
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance33.BorderColor = System.Drawing.Color.Silver
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowAppearance = Appearance33
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griListadoCotizacionDetalle.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griListadoCotizacionDetalle.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griListadoCotizacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griListadoCotizacionDetalle.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griListadoCotizacionDetalle.Location = New System.Drawing.Point(0, 33)
        Me.griListadoCotizacionDetalle.Name = "griListadoCotizacionDetalle"
        Me.griListadoCotizacionDetalle.Size = New System.Drawing.Size(530, 251)
        Me.griListadoCotizacionDetalle.TabIndex = 1
        Me.griListadoCotizacionDetalle.Tag = ""
        '
        'Agrupacion9
        '
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotHasta)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion9.Controls.Add(Me.rfFechaCotDesde)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion9.Controls.Add(Me.btnBuscarCot)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(530, 33)
        Me.Agrupacion9.TabIndex = 0
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rfFechaCotHasta
        '
        Me.rfFechaCotHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotHasta.Location = New System.Drawing.Point(155, 6)
        Me.rfFechaCotHasta.Name = "rfFechaCotHasta"
        Me.rfFechaCotHasta.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotHasta.TabIndex = 3
        '
        'Etiqueta3
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance34
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(136, 8)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(17, 15)
        Me.Etiqueta3.TabIndex = 2
        Me.Etiqueta3.Text = "Al:"
        '
        'rfFechaCotDesde
        '
        Me.rfFechaCotDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rfFechaCotDesde.Location = New System.Drawing.Point(33, 6)
        Me.rfFechaCotDesde.Name = "rfFechaCotDesde"
        Me.rfFechaCotDesde.Size = New System.Drawing.Size(98, 20)
        Me.rfFechaCotDesde.TabIndex = 1
        '
        'Etiqueta1
        '
        Appearance35.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance35
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(6, 9)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(24, 15)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Del:"
        '
        'btnBuscarCot
        '
        Appearance36.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnBuscarCot.Appearance = Appearance36
        Me.btnBuscarCot.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnBuscarCot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCot.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnBuscarCot.Location = New System.Drawing.Point(259, 3)
        Me.btnBuscarCot.Name = "btnBuscarCot"
        Me.btnBuscarCot.Size = New System.Drawing.Size(30, 27)
        Me.btnBuscarCot.TabIndex = 4
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.agrRequerimientos)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1023, 438)
        '
        'agrRequerimientos
        '
        Me.agrRequerimientos.Controls.Add(Me.griLista)
        Me.agrRequerimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrRequerimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrRequerimientos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrRequerimientos.Location = New System.Drawing.Point(0, 95)
        Me.agrRequerimientos.Name = "agrRequerimientos"
        Me.agrRequerimientos.Size = New System.Drawing.Size(1023, 343)
        Me.agrRequerimientos.TabIndex = 1
        Me.agrRequerimientos.Text = " Contratos"
        Me.agrRequerimientos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.ContextMenu
        Me.griLista.DataSource = Me.odMatNeg
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.griLista.DisplayLayout.Appearance = Appearance37
        Appearance38.TextHAlignAsString = "Center"
        UltraGridColumn116.Header.Appearance = Appearance38
        UltraGridColumn116.Header.VisiblePosition = 0
        UltraGridColumn116.Hidden = True
        UltraGridColumn117.Header.VisiblePosition = 1
        UltraGridColumn117.Width = 250
        UltraGridColumn118.Header.VisiblePosition = 2
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 3
        UltraGridColumn120.Header.VisiblePosition = 4
        UltraGridColumn121.Header.VisiblePosition = 8
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.Header.VisiblePosition = 6
        UltraGridColumn122.Hidden = True
        Appearance39.TextHAlignAsString = "Center"
        UltraGridColumn123.Header.Appearance = Appearance39
        UltraGridColumn123.Header.VisiblePosition = 5
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.Header.VisiblePosition = 7
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 9
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125})
        UltraGridColumn126.Header.VisiblePosition = 0
        UltraGridColumn126.Hidden = True
        UltraGridColumn126.Width = 231
        UltraGridColumn127.Header.VisiblePosition = 1
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 2
        UltraGridColumn129.Header.VisiblePosition = 3
        UltraGridColumn130.Header.VisiblePosition = 4
        UltraGridColumn131.Header.VisiblePosition = 5
        UltraGridColumn132.Header.VisiblePosition = 6
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.Header.VisiblePosition = 7
        UltraGridColumn133.Hidden = True
        UltraGridColumn134.Header.VisiblePosition = 8
        UltraGridColumn134.Hidden = True
        UltraGridColumn135.Header.VisiblePosition = 9
        UltraGridColumn135.Hidden = True
        UltraGridColumn136.Header.VisiblePosition = 10
        UltraGridColumn136.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136})
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.griLista.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance40.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance40.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance40.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance40
        Appearance41.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance41
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance42.BackColor2 = System.Drawing.SystemColors.Control
        Appearance42.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance42.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance42
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Appearance43.ForeColor = System.Drawing.SystemColors.ControlText
        Me.griLista.DisplayLayout.Override.ActiveCellAppearance = Appearance43
        Appearance44.BackColor = System.Drawing.SystemColors.Highlight
        Appearance44.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.griLista.DisplayLayout.Override.ActiveRowAppearance = Appearance44
        Me.griLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLista.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance45.BackColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.Override.CardAreaAppearance = Appearance45
        Appearance46.BorderColor = System.Drawing.Color.Silver
        Appearance46.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.griLista.DisplayLayout.Override.CellAppearance = Appearance46
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.griLista.DisplayLayout.Override.CellPadding = 0
        Appearance47.BackColor = System.Drawing.SystemColors.Control
        Appearance47.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance47.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance47.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance47.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.Override.GroupByRowAppearance = Appearance47
        Appearance48.TextHAlignAsString = "Left"
        Me.griLista.DisplayLayout.Override.HeaderAppearance = Appearance48
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griLista.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.Color.Silver
        Me.griLista.DisplayLayout.Override.RowAppearance = Appearance49
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.SeparateElement
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.griLista.DisplayLayout.Override.TemplateAddRowAppearance = Appearance50
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(3, 16)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1017, 324)
        Me.griLista.TabIndex = 0
        Me.griLista.Text = "Grilla2"
        '
        'ContextMenu
        '
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuNuevo, Me.ToolStripMenuEditar, Me.ToolStripMenuEliminar, Me.ToolStripMenuVigencia, Me.ToolStripClonarContrato})
        Me.ContextMenu.Name = "ContextMenuStrip1"
        Me.ContextMenu.Size = New System.Drawing.Size(165, 114)
        '
        'ToolStripMenuNuevo
        '
        Me.ToolStripMenuNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuNuevo.Name = "ToolStripMenuNuevo"
        Me.ToolStripMenuNuevo.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuNuevo.Text = "Nuevo"
        '
        'ToolStripMenuEditar
        '
        Me.ToolStripMenuEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        Me.ToolStripMenuEditar.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuEditar.Text = "Editar"
        '
        'ToolStripMenuEliminar
        '
        Me.ToolStripMenuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuEliminar.Name = "ToolStripMenuEliminar"
        Me.ToolStripMenuEliminar.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuEliminar.Text = "Eliminar"
        '
        'ToolStripMenuVigencia
        '
        Me.ToolStripMenuVigencia.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.ToolStripMenuVigencia.Name = "ToolStripMenuVigencia"
        Me.ToolStripMenuVigencia.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuVigencia.Text = "CambiarVigencia"
        '
        'ToolStripClonarContrato
        '
        Me.ToolStripClonarContrato.Image = Global.ISL.Win.My.Resources.Resources.Conectado
        Me.ToolStripClonarContrato.Name = "ToolStripClonarContrato"
        Me.ToolStripClonarContrato.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripClonarContrato.Text = "ClonarContrato"
        '
        'odMatNeg
        '
        UltraDataColumn19.DataType = GetType(Double)
        UltraDataColumn25.DataType = GetType(Date)
        UltraDataBand1.Columns.AddRange(New Object() {UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26})
        Me.odMatNeg.Band.ChildBands.AddRange(New Object() {UltraDataBand1})
        UltraDataColumn30.DataType = GetType(Date)
        UltraDataColumn31.DataType = GetType(Boolean)
        UltraDataColumn33.DataType = GetType(Date)
        UltraDataColumn34.DataType = GetType(Boolean)
        Me.odMatNeg.Band.Columns.AddRange(New Object() {UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion1.Controls.Add(Me.rangoFechaHasta)
        Me.Agrupacion1.Controls.Add(Me.rangoFechaDesde)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1023, 95)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Búsqueda:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.ColoresCaducado)
        Me.Agrupacion7.Controls.Add(Me.ColoresVigente)
        Me.Agrupacion7.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion7.Controls.Add(Me.etiGenerada)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion7.Location = New System.Drawing.Point(172, 22)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(142, 67)
        Me.Agrupacion7.TabIndex = 4
        Me.Agrupacion7.Text = "Estados"
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'ColoresCaducado
        '
        Me.ColoresCaducado.Location = New System.Drawing.Point(70, 38)
        Me.ColoresCaducado.Name = "ColoresCaducado"
        Me.ColoresCaducado.Size = New System.Drawing.Size(43, 21)
        Me.ColoresCaducado.TabIndex = 3
        Me.ColoresCaducado.Text = "Control"
        '
        'ColoresVigente
        '
        Me.ColoresVigente.Color = System.Drawing.Color.Empty
        Me.ColoresVigente.Location = New System.Drawing.Point(10, 38)
        Me.ColoresVigente.Name = "ColoresVigente"
        Me.ColoresVigente.Size = New System.Drawing.Size(46, 21)
        Me.ColoresVigente.TabIndex = 2
        '
        'etiEnProceso
        '
        Appearance51.BackColor = System.Drawing.Color.Transparent
        Appearance51.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance51
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(67, 21)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(51, 15)
        Me.etiEnProceso.TabIndex = 1
        Me.etiEnProceso.Text = "Caducado"
        '
        'etiGenerada
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance52
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(10, 21)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(41, 15)
        Me.etiGenerada.TabIndex = 0
        Me.etiGenerada.Text = "Vigente"
        '
        'rangoFechaHasta
        '
        Me.rangoFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangoFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rangoFechaHasta.Location = New System.Drawing.Point(52, 59)
        Me.rangoFechaHasta.Name = "rangoFechaHasta"
        Me.rangoFechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.rangoFechaHasta.TabIndex = 3
        '
        'rangoFechaDesde
        '
        Me.rangoFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rangoFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.rangoFechaDesde.Location = New System.Drawing.Point(52, 22)
        Me.rangoFechaDesde.Name = "rangoFechaDesde"
        Me.rangoFechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.rangoFechaDesde.TabIndex = 1
        '
        'Etiqueta21
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta21.Appearance = Appearance53
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(11, 64)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 15)
        Me.Etiqueta21.TabIndex = 2
        Me.Etiqueta21.Text = "Hasta:"
        '
        'Etiqueta2
        '
        Appearance54.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance54
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(8, 28)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(38, 15)
        Me.Etiqueta2.TabIndex = 0
        Me.Etiqueta2.Text = "Desde:"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl2.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl2.Enabled = False
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1023, 438)
        '
        'Agrupacion5
        '
        Me.Agrupacion5.Controls.Add(Me.agrMaterialNegocio)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea1)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea2)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea3)
        Me.Agrupacion5.Controls.Add(Me.UltraToolbarsDockArea4)
        Me.Agrupacion5.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom)
        Me.Agrupacion5.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Left)
        Me.Agrupacion5.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_Right)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 74)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(1023, 364)
        Me.Agrupacion5.TabIndex = 1
        Me.Agrupacion5.Text = "Detalle"
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'agrMaterialNegocio
        '
        Me.agrMaterialNegocio.Controls.Add(Me.UltraTabControl1)
        Me.agrMaterialNegocio.Controls.Add(Me.gbeMateriales)
        Me.agrMaterialNegocio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrMaterialNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrMaterialNegocio.ForeColor = System.Drawing.Color.MidnightBlue
        Me.agrMaterialNegocio.Location = New System.Drawing.Point(3, 42)
        Me.agrMaterialNegocio.Name = "agrMaterialNegocio"
        Me.agrMaterialNegocio.Size = New System.Drawing.Size(1017, 319)
        Me.agrMaterialNegocio.TabIndex = 0
        Me.agrMaterialNegocio.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl6)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage3
        Me.UltraTabControl1.Size = New System.Drawing.Size(456, 313)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Vigentes"
        UltraTab6.TabPage = Me.UltraTabPageControl6
        UltraTab6.Text = "Historial"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab6})
        Me.UltraTabControl1.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage3
        '
        Me.UltraTabSharedControlsPage3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage3.Name = "UltraTabSharedControlsPage3"
        Me.UltraTabSharedControlsPage3.Size = New System.Drawing.Size(454, 290)
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(555, 313)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(459, 3)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(555, 313)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.ficMatCot)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(532, 307)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'ficMatCot
        '
        Me.ficMatCot.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.ficMatCot.Controls.Add(Me.UltraTabPageControl4)
        Me.ficMatCot.Controls.Add(Me.UltraTabPageControl5)
        Me.ficMatCot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMatCot.Location = New System.Drawing.Point(0, 0)
        Me.ficMatCot.Name = "ficMatCot"
        Me.ficMatCot.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.ficMatCot.Size = New System.Drawing.Size(532, 307)
        Me.ficMatCot.TabIndex = 0
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Materiales"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Cotizaciones"
        Me.ficMatCot.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab4, UltraTab5})
        Me.ficMatCot.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(530, 284)
        '
        'UltraToolbarsDockArea1
        '
        Me.UltraToolbarsDockArea1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea1.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me.UltraToolbarsDockArea1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea1.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea1.Name = "UltraToolbarsDockArea1"
        Me.UltraToolbarsDockArea1.Size = New System.Drawing.Size(1017, 26)
        Me.UltraToolbarsDockArea1.ToolbarsManager = Me.MenuDetalle
        '
        'MenuDetalle
        '
        Appearance55.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MenuDetalle.Appearance = Appearance55
        Me.MenuDetalle.DesignerFlags = 1
        Me.MenuDetalle.DockWithinContainer = Me
        Me.MenuDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.MenuDetalle.MdiMergeable = False
        Me.MenuDetalle.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool13, ButtonTool14})
        Me.MenuDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.FloatingLocation = New System.Drawing.Point(263, 373)
        UltraToolbar1.FloatingSize = New System.Drawing.Size(419, 24)
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool17, ButtonTool3, ButtonTool1})
        UltraToolbar1.Text = "utMenuDetalle"
        Me.MenuDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance56.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool4.SharedPropsInternal.AppearancesSmall.Appearance = Appearance56
        ButtonTool4.SharedPropsInternal.Caption = "Guardar"
        ButtonTool4.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance57.Image = Global.ISL.Win.My.Resources.Resources.Editar
        ButtonTool5.SharedPropsInternal.AppearancesSmall.Appearance = Appearance57
        ButtonTool5.SharedPropsInternal.Caption = "Editar"
        ButtonTool5.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance58.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        ButtonTool6.SharedPropsInternal.AppearancesSmall.Appearance = Appearance58
        ButtonTool6.SharedPropsInternal.Caption = "Quitar"
        ButtonTool6.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance59.Image = Global.ISL.Win.My.Resources.Resources.Cancelar
        ButtonTool10.SharedPropsInternal.AppearancesSmall.Appearance = Appearance59
        ButtonTool10.SharedPropsInternal.Caption = "Cancelar"
        ButtonTool10.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance60.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        ButtonTool12.SharedPropsInternal.AppearancesSmall.Appearance = Appearance60
        ButtonTool12.SharedPropsInternal.Caption = "Nuevo"
        ButtonTool12.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance61.Image = Global.ISL.Win.My.Resources.Resources.Excel
        ButtonTool15.SharedPropsInternal.AppearancesSmall.Appearance = Appearance61
        ButtonTool15.SharedPropsInternal.Caption = "Importar"
        ButtonTool15.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        ButtonTool15.SharedPropsInternal.Enabled = False
        ButtonTool16.SharedPropsInternal.Caption = "ButtonTool2"
        ButtonTool18.SharedPropsInternal.Caption = "ButtonTool3"
        Appearance62.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool9.SharedPropsInternal.AppearancesSmall.Appearance = Appearance62
        ButtonTool9.SharedPropsInternal.Caption = "Consultar"
        ButtonTool9.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance63.Image = Global.ISL.Win.My.Resources.Resources.Agregar
        ButtonTool19.SharedPropsInternal.AppearancesSmall.Appearance = Appearance63
        ButtonTool19.SharedPropsInternal.Caption = "Agregar"
        ButtonTool19.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.MenuDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool10, ButtonTool12, ButtonTool15, ButtonTool16, ButtonTool18, ButtonTool9, ButtonTool19})
        '
        'UltraToolbarsDockArea2
        '
        Me.UltraToolbarsDockArea2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea2.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me.UltraToolbarsDockArea2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea2.Location = New System.Drawing.Point(3, 361)
        Me.UltraToolbarsDockArea2.Name = "UltraToolbarsDockArea2"
        Me.UltraToolbarsDockArea2.Size = New System.Drawing.Size(1017, 0)
        Me.UltraToolbarsDockArea2.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea3
        '
        Me.UltraToolbarsDockArea3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea3.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me.UltraToolbarsDockArea3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea3.Location = New System.Drawing.Point(3, 16)
        Me.UltraToolbarsDockArea3.Name = "UltraToolbarsDockArea3"
        Me.UltraToolbarsDockArea3.Size = New System.Drawing.Size(0, 345)
        Me.UltraToolbarsDockArea3.ToolbarsManager = Me.MenuDetalle
        '
        'UltraToolbarsDockArea4
        '
        Me.UltraToolbarsDockArea4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.UltraToolbarsDockArea4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UltraToolbarsDockArea4.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me.UltraToolbarsDockArea4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.UltraToolbarsDockArea4.Location = New System.Drawing.Point(1020, 16)
        Me.UltraToolbarsDockArea4.Name = "UltraToolbarsDockArea4"
        Me.UltraToolbarsDockArea4.Size = New System.Drawing.Size(0, 345)
        Me.UltraToolbarsDockArea4.ToolbarsManager = Me.MenuDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(3, 361)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1017, 0)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(3, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 345)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.Color.MidnightBlue
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1020, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 345)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.UltraLabel2)
        Me.Agrupacion2.Controls.Add(Me.chkRuc2)
        Me.Agrupacion2.Controls.Add(Me.cboProveedorL)
        Me.Agrupacion2.Controls.Add(Me.fecFecha)
        Me.Agrupacion2.Controls.Add(Me.txtDescripcion)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel3)
        Me.Agrupacion2.Controls.Add(Me.UltraLabel1)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1023, 74)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraLabel2
        '
        Appearance64.BackColor = System.Drawing.Color.Transparent
        Appearance64.ForeColor = System.Drawing.Color.Navy
        Appearance64.TextVAlignAsString = "Middle"
        Me.UltraLabel2.Appearance = Appearance64
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel2.Location = New System.Drawing.Point(15, 35)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(59, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Proveedor:"
        '
        'chkRuc2
        '
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.chkRuc2.Appearance = Appearance65
        Me.chkRuc2.BackColor = System.Drawing.Color.Transparent
        Me.chkRuc2.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkRuc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRuc2.ForeColor = System.Drawing.Color.Black
        Me.chkRuc2.Location = New System.Drawing.Point(372, 31)
        Me.chkRuc2.Name = "chkRuc2"
        Me.chkRuc2.Size = New System.Drawing.Size(44, 20)
        Me.chkRuc2.TabIndex = 4
        Me.chkRuc2.Text = "Ruc"
        '
        'cboProveedorL
        '
        Me.cboProveedorL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboProveedorL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cboProveedorL.CheckedListSettings.ListSeparator = ","
        Me.cboProveedorL.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.cboProveedorL.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.cboProveedorL.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboProveedorL.DropDownWidth = 400
        Me.cboProveedorL.Location = New System.Drawing.Point(80, 30)
        Me.cboProveedorL.Name = "cboProveedorL"
        Me.cboProveedorL.Size = New System.Drawing.Size(287, 22)
        Me.cboProveedorL.TabIndex = 3
        '
        'fecFecha
        '
        Me.fecFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFecha.Location = New System.Drawing.Point(79, 6)
        Me.fecFecha.Name = "fecFecha"
        Me.fecFecha.Size = New System.Drawing.Size(98, 20)
        Me.fecFecha.TabIndex = 1
        '
        'txtDescripcion
        '
        Appearance66.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Appearance = Appearance66
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtDescripcion.Location = New System.Drawing.Point(484, 6)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 54)
        Me.txtDescripcion.TabIndex = 6
        '
        'UltraLabel3
        '
        Appearance67.BackColor = System.Drawing.Color.Transparent
        Appearance67.ForeColor = System.Drawing.Color.Navy
        Appearance67.TextVAlignAsString = "Middle"
        Me.UltraLabel3.Appearance = Appearance67
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel3.Location = New System.Drawing.Point(443, 10)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(35, 15)
        Me.UltraLabel3.TabIndex = 5
        Me.UltraLabel3.Text = "Glosa:"
        '
        'UltraLabel1
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Appearance68.TextVAlignAsString = "Middle"
        Me.UltraLabel1.Appearance = Appearance68
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraLabel1.Location = New System.Drawing.Point(36, 10)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(38, 15)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Fecha:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ficMaterialesNegociables
        '
        Me.ficMaterialesNegociables.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficMaterialesNegociables.Controls.Add(Me.UltraTabPageControl1)
        Me.ficMaterialesNegociables.Controls.Add(Me.UltraTabPageControl2)
        Me.ficMaterialesNegociables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficMaterialesNegociables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficMaterialesNegociables.Location = New System.Drawing.Point(0, 0)
        Me.ficMaterialesNegociables.Name = "ficMaterialesNegociables"
        Me.ficMaterialesNegociables.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficMaterialesNegociables.Size = New System.Drawing.Size(1025, 461)
        Me.ficMaterialesNegociables.TabIndex = 0
        UltraTab1.Key = "Lista"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.Key = "Mantenimiento"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficMaterialesNegociables.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficMaterialesNegociables.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1023, 438)
        '
        'frm_MaterialesNegociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 461)
        Me.Controls.Add(Me.ficMaterialesNegociables)
        Me.Name = "frm_MaterialesNegociados"
        Me.Text = "Materiales Negociados"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.griMatNegDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMatNegDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.griHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.numPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.griListadoCotizacionDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.agrRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrRequerimientos.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu.ResumeLayout(False)
        CType(Me.odMatNeg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.ColoresCaducado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresVigente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        CType(Me.agrMaterialNegocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrMaterialNegocio.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.ficMatCot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMatCot.ResumeLayout(False)
        CType(Me.MenuDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.chkRuc2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProveedorL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficMaterialesNegociables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficMaterialesNegociables.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficMaterialesNegociables As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents agrRequerimientos As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents rangoFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents rangoFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents fecFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents chkRuc2 As ISL.Controles.Chequear
    Private WithEvents cboProveedorL As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents odMaterial As ISL.Controles.OrigenDatos
    Friend WithEvents odMatNegDet As ISL.Controles.OrigenDatos
    Friend WithEvents odMatNeg As ISL.Controles.OrigenDatos
    Friend WithEvents griLista As ISL.Controles.Grilla
    Shadows WithEvents ContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuVigencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents ColoresCaducado As ISL.Controles.Colores
    Friend WithEvents ColoresVigente As ISL.Controles.Colores
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents ToolStripClonarContrato As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents UltraToolbarsDockArea1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents MenuDetalle As ISL.Controles.Menu
    Friend WithEvents UltraToolbarsDockArea2 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea3 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsDockArea4 As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents agrMaterialNegocio As ISL.Controles.Agrupacion
    Friend WithEvents griMatNegDet As ISL.Controles.Grilla
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents ficMatCot As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griListadoCotizacionDetalle As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents rfFechaCotHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents rfFechaCotDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents btnBuscarCot As ISL.Controles.Boton
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage3 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents griHistorial As ISL.Controles.Grilla
    Friend WithEvents cboMateriales As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cboMoneda As ISL.Controles.ComboMaestros
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents numPrecio As ISL.Controles.NumeroDecimal
End Class
