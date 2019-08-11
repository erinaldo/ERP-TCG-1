<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mantenimiento
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMantenimiento")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMedida")
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Mantenimiento))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMantenimiento")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMedida")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMantenimiento")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMedida")
        Dim UltraGridColumn36 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMantenimiento")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMedida")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn41 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn42 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn43 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn44 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn45 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn46 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim UltraGridColumn47 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim UltraGridColumn48 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim UltraGridColumn49 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim UltraGridColumn50 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim UltraGridColumn51 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn53 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn54 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombreMaterial")
        Dim UltraGridColumn55 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn42 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn43 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn44 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn45 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn46 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn47 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn48 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn49 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn50 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn51 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn52 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn53 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn54 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombreMaterial")
        Dim UltraDataColumn55 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn56 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn57 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn58 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMaterial")
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Material")
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn63 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn64 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdFamilia")
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn65 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubFamilia")
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn66 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn67 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn68 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn69 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoUnidadMedida")
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn70 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdAlmacen")
        Dim UltraGridColumn71 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Precio")
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Stock")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CodigoNombreMaterial")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdSubAlmacen")
        Dim UltraDataColumn56 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn57 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn58 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn59 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMaterial")
        Dim UltraDataColumn60 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn61 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Material")
        Dim UltraDataColumn62 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn63 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn64 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdFamilia")
        Dim UltraDataColumn65 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubFamilia")
        Dim UltraDataColumn66 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn67 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn68 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn69 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoUnidadMedida")
        Dim UltraDataColumn70 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdAlmacen")
        Dim UltraDataColumn71 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Precio")
        Dim UltraDataColumn72 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Stock")
        Dim UltraDataColumn73 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CodigoNombreMaterial")
        Dim UltraDataColumn74 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdSubAlmacen")
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn75 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn76 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn77 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn78 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn79 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn80 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn81 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn82 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn83 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn84 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn85 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn86 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn87 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaServicio")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdServicio")
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Servicio")
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraDataColumn88 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn89 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn90 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn91 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn92 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaServicio")
        Dim UltraDataColumn93 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdServicio")
        Dim UltraDataColumn94 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn95 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Servicio")
        Dim UltraDataColumn96 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn97 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn98 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn99 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn100 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance86 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance87 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance88 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance89 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim Appearance90 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance91 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim Appearance92 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance93 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance94 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance95 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance96 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaOcupacion")
        Dim Appearance97 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn101 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn102 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn103 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn104 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOcupacion")
        Dim UltraDataColumn105 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn106 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocupacion")
        Dim UltraDataColumn107 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn108 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn109 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn110 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaOcupacion")
        Dim UltraGridBand8 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance98 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim Appearance99 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance100 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdOcupacion")
        Dim Appearance101 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance102 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Ocupacion")
        Dim Appearance103 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance104 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance105 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance106 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCategoriaOcupacion")
        Dim Appearance107 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn111 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn112 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn113 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn114 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdOcupacion")
        Dim UltraDataColumn115 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn116 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Ocupacion")
        Dim UltraDataColumn117 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn118 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn119 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn120 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdCategoriaOcupacion")
        Dim UltraGridBand9 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance108 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance109 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance110 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividad")
        Dim Appearance111 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance112 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actividad")
        Dim Appearance113 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadHoras")
        Dim Appearance114 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance115 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance116 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance117 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance118 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn121 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn122 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn123 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn124 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividad")
        Dim UltraDataColumn125 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn126 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actividad")
        Dim UltraDataColumn127 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadHoras")
        Dim UltraDataColumn128 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn129 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraGridBand10 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance119 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance120 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance121 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdActividad")
        Dim Appearance122 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance123 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Actividad")
        Dim Appearance124 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadHoras")
        Dim Appearance125 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance126 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance127 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn130 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn131 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn132 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn133 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdActividad")
        Dim UltraDataColumn134 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn135 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Actividad")
        Dim UltraDataColumn136 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadHoras")
        Dim UltraDataColumn137 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn138 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraGridBand11 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance128 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance129 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre")
        Dim Appearance130 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMantenimiento")
        Dim Appearance131 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim Appearance132 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance133 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cantidad")
        Dim Appearance134 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance135 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUnidadMedida")
        Dim Appearance136 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UnidadMedida")
        Dim Appearance137 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance138 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance139 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn149 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim Appearance140 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn150 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OrdenSecuencia")
        Dim Appearance141 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance142 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn151 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim UltraGridColumn152 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Costo")
        Dim Appearance143 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance144 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn153 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Externa")
        Dim UltraDataColumn139 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn140 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn141 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn142 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMantenimiento")
        Dim UltraDataColumn143 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn144 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn145 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cantidad")
        Dim UltraDataColumn146 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdUnidadMedida")
        Dim UltraDataColumn147 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UnidadMedida")
        Dim UltraDataColumn148 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn149 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn150 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("OrdenSecuencia")
        Dim UltraDataColumn151 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn152 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Costo")
        Dim UltraDataColumn153 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Externa")
        Dim UltraGridBand12 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn154 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim Appearance145 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn155 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMantenimiento")
        Dim Appearance146 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn156 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mantenimiento")
        Dim Appearance147 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn157 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdEquipo")
        Dim Appearance148 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn158 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Codigo")
        Dim Appearance149 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn159 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Equipo")
        Dim Appearance150 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn160 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMarca")
        Dim UltraGridColumn161 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Marca")
        Dim Appearance151 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn162 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdModelo")
        Dim UltraGridColumn163 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Modelo")
        Dim Appearance152 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn164 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim Appearance153 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn165 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim Appearance154 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn166 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Seleccion")
        Dim Appearance155 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn167 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoMantenimiento")
        Dim UltraGridColumn168 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn169 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoMantenimiento")
        Dim UltraGridColumn170 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoVehiculo")
        Dim Appearance156 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn171 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CantidadMedida")
        Dim UltraDataColumn154 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn155 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMantenimiento")
        Dim UltraDataColumn156 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mantenimiento")
        Dim UltraDataColumn157 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEquipo")
        Dim UltraDataColumn158 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Codigo")
        Dim UltraDataColumn159 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Equipo")
        Dim UltraDataColumn160 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMarca")
        Dim UltraDataColumn161 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Marca")
        Dim UltraDataColumn162 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdModelo")
        Dim UltraDataColumn163 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Modelo")
        Dim UltraDataColumn164 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn165 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn166 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Seleccion")
        Dim UltraDataColumn167 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoMantenimiento")
        Dim UltraDataColumn168 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn169 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoMantenimiento")
        Dim UltraDataColumn170 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoVehiculo")
        Dim UltraDataColumn171 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CantidadMedida")
        Dim Appearance157 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance158 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance159 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance160 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance161 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance162 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab9 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab10 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab11 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim Appearance163 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraToolbar1 As Infragistics.Win.UltraWinToolbars.UltraToolbar = New Infragistics.Win.UltraWinToolbars.UltraToolbar("utDetalle")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim ButtonTool20 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
        Dim ButtonTool21 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Consultar")
        Dim Appearance164 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool22 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Agregar")
        Dim Appearance165 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool23 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Guardar")
        Dim Appearance166 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim ButtonTool24 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Quitar")
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
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_MantenimientoEquipo = New ISL.Controles.Grilla(Me.components)
        Me.mcDetalle = New ISL.Controles.MenuContextual(Me.components)
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odMantenimientoEquipos = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.gbeEquipos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel1 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Equipos = New ISL.Controles.Grilla(Me.components)
        Me.odEquipo = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnListarEquipos = New ISL.Controles.Boton(Me.components)
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbModelo = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbMarca = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl6 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_MantenimientoMateriales = New ISL.Controles.Grilla(Me.components)
        Me.odMantenimientoMateriales = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeMateriales = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel2 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Materiales = New ISL.Controles.Grilla(Me.components)
        Me.odMateriales = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.cmbSubFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta9 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnListarMaterial = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbFamilia = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl9 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_MantenimientoServicios = New ISL.Controles.Grilla(Me.components)
        Me.odMantenimientoServicios = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeServicios = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel3 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Servicios = New ISL.Controles.Grilla(Me.components)
        Me.odServicios = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnCategoria = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbCategoriaServicios = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl10 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_MantenimientoOperarios = New ISL.Controles.Grilla(Me.components)
        Me.odMantenimientoOperarios = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeRecursos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel4 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Operarios = New ISL.Controles.Grilla(Me.components)
        Me.odOperarios = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl11 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_MantenimientoActividades = New ISL.Controles.Grilla(Me.components)
        Me.odMantenimientoActividades = New ISL.Controles.OrigenDatos(Me.components)
        Me.gbeActividades = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel5 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_Actividades = New ISL.Controles.Grilla(Me.components)
        Me.odActividades = New ISL.Controles.OrigenDatos(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.grid_Mantenimientos = New ISL.Controles.Grilla(Me.components)
        Me.mcMantenimiento = New ISL.Controles.MenuContextual(Me.components)
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.odMantenimientos = New ISL.Controles.OrigenDatos(Me.components)
        Me.uegbEquipos = New Infragistics.Win.Misc.UltraExpandableGroupBox()
        Me.UltraExpandableGroupBoxPanel6 = New Infragistics.Win.Misc.UltraExpandableGroupBoxPanel()
        Me.grid_EquipoAsig = New ISL.Controles.Grilla(Me.components)
        Me.odEquipoAsig = New ISL.Controles.OrigenDatos(Me.components)
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnAsignar = New ISL.Controles.Boton(Me.components)
        Me.btnListarAsig = New ISL.Controles.Boton(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbModeloAsig = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbMarcaAsig = New ISL.Controles.ComboMaestros(Me.components)
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.agrDetalle = New Infragistics.Win.Misc.UltraGroupBox()
        Me.tcDetalle = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.mnDetalle = New ISL.Controles.Menu(Me.components)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.agrDatoGeneral = New Infragistics.Win.Misc.UltraGroupBox()
        Me.verInterna = New ISL.Controles.Chequear(Me.components)
        Me.txtPatron = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.neOrdenSecuencia = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.verActivo = New ISL.Controles.Chequear(Me.components)
        Me.cmbUnidadMedida = New ISL.Controles.ComboMaestros(Me.components)
        Me.txtNombre = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.ndCantidad = New ISL.Controles.NumeroDecimal(Me.components)
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.cmbTipoMantenimiento = New ISL.Controles.ComboMaestros(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtCodigo = New ISL.Controles.Texto(Me.components)
        Me.tcMantenimiento = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UltraTabSharedControlsPage5 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.grid_MantenimientoEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcDetalle.SuspendLayout()
        CType(Me.odMantenimientoEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeEquipos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel1.SuspendLayout()
        CType(Me.grid_Equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.cmbModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl6.SuspendLayout()
        CType(Me.grid_MantenimientoMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMantenimientoMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeMateriales.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel2.SuspendLayout()
        CType(Me.grid_Materiales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.cmbSubFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl9.SuspendLayout()
        CType(Me.grid_MantenimientoServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMantenimientoServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeServicios.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel3.SuspendLayout()
        CType(Me.grid_Servicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.cmbCategoriaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl10.SuspendLayout()
        CType(Me.grid_MantenimientoOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMantenimientoOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeRecursos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel4.SuspendLayout()
        CType(Me.grid_Operarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl11.SuspendLayout()
        CType(Me.grid_MantenimientoActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odMantenimientoActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gbeActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbeActividades.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel5.SuspendLayout()
        CType(Me.grid_Actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.grid_Mantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mcMantenimiento.SuspendLayout()
        CType(Me.odMantenimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uegbEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uegbEquipos.SuspendLayout()
        Me.UltraExpandableGroupBoxPanel6.SuspendLayout()
        CType(Me.grid_EquipoAsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odEquipoAsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.cmbModeloAsig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMarcaAsig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDetalle.SuspendLayout()
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcDetalle.SuspendLayout()
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrDatoGeneral.SuspendLayout()
        CType(Me.verInterna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatron, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.neOrdenSecuencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnidadMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ndCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcMantenimiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.grid_MantenimientoEquipo)
        Me.UltraTabPageControl3.Controls.Add(Me.gbeEquipos)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1180, 345)
        '
        'grid_MantenimientoEquipo
        '
        Me.grid_MantenimientoEquipo.ContextMenuStrip = Me.mcDetalle
        Me.grid_MantenimientoEquipo.DataSource = Me.odMantenimientoEquipos
        UltraGridColumn1.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn1.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance1.TextHAlignAsString = "Center"
        UltraGridColumn1.Header.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn2.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance2.TextHAlignAsString = "Center"
        UltraGridColumn2.Header.Appearance = Appearance2
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Hidden = True
        UltraGridColumn3.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance3.TextHAlignAsString = "Center"
        UltraGridColumn3.Header.Appearance = Appearance3
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn4.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance4.TextHAlignAsString = "Center"
        UltraGridColumn4.Header.Appearance = Appearance4
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance5.TextHAlignAsString = "Center"
        UltraGridColumn5.Header.Appearance = Appearance5
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Width = 82
        UltraGridColumn6.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance6.TextHAlignAsString = "Center"
        UltraGridColumn6.Header.Appearance = Appearance6
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 162
        UltraGridColumn7.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn7.Header.VisiblePosition = 12
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance7.TextHAlignAsString = "Center"
        UltraGridColumn8.Header.Appearance = Appearance7
        UltraGridColumn8.Header.VisiblePosition = 10
        UltraGridColumn8.Width = 124
        UltraGridColumn9.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn9.Header.VisiblePosition = 13
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance8.TextHAlignAsString = "Center"
        UltraGridColumn10.Header.Appearance = Appearance8
        UltraGridColumn10.Header.VisiblePosition = 11
        UltraGridColumn11.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn11.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance9.TextHAlignAsString = "Center"
        UltraGridColumn11.Header.Appearance = Appearance9
        UltraGridColumn11.Header.VisiblePosition = 7
        UltraGridColumn11.Hidden = True
        UltraGridColumn12.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn12.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance10.TextHAlignAsString = "Center"
        UltraGridColumn12.Header.Appearance = Appearance10
        UltraGridColumn12.Header.VisiblePosition = 8
        UltraGridColumn12.Hidden = True
        UltraGridColumn13.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        UltraGridColumn13.Header.Caption = "Select"
        UltraGridColumn13.Header.VisiblePosition = 4
        UltraGridColumn13.Width = 34
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn15.Header.VisiblePosition = 15
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn16.Header.VisiblePosition = 16
        UltraGridColumn16.Hidden = True
        Appearance11.TextHAlignAsString = "Right"
        UltraGridColumn17.CellAppearance = Appearance11
        UltraGridColumn17.Format = "#,##0.00"
        UltraGridColumn17.Header.Caption = "Cant. Medicion Mant."
        UltraGridColumn17.Header.VisiblePosition = 17
        UltraGridColumn17.MaskInput = "{LOC}nn,nnn,nnn.nn"
        UltraGridColumn17.Width = 129
        Appearance12.TextHAlignAsString = "Center"
        UltraGridColumn18.Header.Appearance = Appearance12
        UltraGridColumn18.Header.VisiblePosition = 9
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18})
        Me.grid_MantenimientoEquipo.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.grid_MantenimientoEquipo.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoEquipo.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_MantenimientoEquipo.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoEquipo.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_MantenimientoEquipo.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_MantenimientoEquipo.DisplayLayout.MaxRowScrollRegions = 1
        Appearance13.BackColor = System.Drawing.SystemColors.Highlight
        Appearance13.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.ActiveRowAppearance = Appearance13
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.CellPadding = 0
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_MantenimientoEquipo.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoEquipo.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Both
        Me.grid_MantenimientoEquipo.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_MantenimientoEquipo.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_MantenimientoEquipo.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_MantenimientoEquipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_MantenimientoEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_MantenimientoEquipo.Location = New System.Drawing.Point(0, 0)
        Me.grid_MantenimientoEquipo.Name = "grid_MantenimientoEquipo"
        Me.grid_MantenimientoEquipo.Size = New System.Drawing.Size(642, 345)
        Me.grid_MantenimientoEquipo.TabIndex = 0
        Me.grid_MantenimientoEquipo.Text = "Grilla1"
        '
        'mcDetalle
        '
        Me.mcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcDetalle.ForeColor = System.Drawing.Color.Black
        Me.mcDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.QuitarToolStripMenuItem})
        Me.mcDetalle.Name = "MenuContextual1"
        Me.mcDetalle.Size = New System.Drawing.Size(112, 48)
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Image = CType(resources.GetObject("AgregarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        Me.AgregarToolStripMenuItem.ToolTipText = "Insertar un nuevo Detalle"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Quitar2
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        Me.QuitarToolStripMenuItem.ToolTipText = "Quitar detalle seleccionado"
        '
        'odMantenimientoEquipos
        '
        UltraDataColumn11.DataType = GetType(Boolean)
        UltraDataColumn13.DataType = GetType(Boolean)
        UltraDataColumn13.DefaultValue = False
        UltraDataColumn17.DataType = GetType(Double)
        Me.odMantenimientoEquipos.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'gbeEquipos
        '
        Me.gbeEquipos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeEquipos.Controls.Add(Me.UltraExpandableGroupBoxPanel1)
        Me.gbeEquipos.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeEquipos.ExpandedSize = New System.Drawing.Size(538, 345)
        Me.gbeEquipos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeEquipos.Location = New System.Drawing.Point(642, 0)
        Me.gbeEquipos.Name = "gbeEquipos"
        Me.gbeEquipos.Size = New System.Drawing.Size(538, 345)
        Me.gbeEquipos.TabIndex = 1
        Me.gbeEquipos.Text = "Equipos"
        Me.gbeEquipos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel1
        '
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.grid_Equipos)
        Me.UltraExpandableGroupBoxPanel1.Controls.Add(Me.Agrupacion1)
        Me.UltraExpandableGroupBoxPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel1.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel1.Name = "UltraExpandableGroupBoxPanel1"
        Me.UltraExpandableGroupBoxPanel1.Size = New System.Drawing.Size(515, 339)
        Me.UltraExpandableGroupBoxPanel1.TabIndex = 0
        '
        'grid_Equipos
        '
        Me.grid_Equipos.ContextMenuStrip = Me.mcDetalle
        Me.grid_Equipos.DataSource = Me.odEquipo
        UltraGridColumn19.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance14.TextHAlignAsString = "Center"
        UltraGridColumn19.Header.Appearance = Appearance14
        UltraGridColumn19.Header.VisiblePosition = 0
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Width = 33
        UltraGridColumn20.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance15.TextHAlignAsString = "Center"
        UltraGridColumn20.Header.Appearance = Appearance15
        UltraGridColumn20.Header.VisiblePosition = 1
        UltraGridColumn20.Hidden = True
        Appearance16.TextHAlignAsString = "Center"
        UltraGridColumn21.Header.Appearance = Appearance16
        UltraGridColumn21.Header.VisiblePosition = 2
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance17.TextHAlignAsString = "Center"
        UltraGridColumn22.Header.Appearance = Appearance17
        UltraGridColumn22.Header.VisiblePosition = 3
        UltraGridColumn22.Hidden = True
        Appearance18.TextHAlignAsString = "Center"
        UltraGridColumn23.Header.Appearance = Appearance18
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridColumn23.Width = 80
        Appearance19.TextHAlignAsString = "Center"
        UltraGridColumn24.Header.Appearance = Appearance19
        UltraGridColumn24.Header.VisiblePosition = 6
        UltraGridColumn24.Width = 153
        UltraGridColumn25.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn25.Header.VisiblePosition = 13
        UltraGridColumn25.Hidden = True
        Appearance20.TextHAlignAsString = "Center"
        UltraGridColumn26.Header.Appearance = Appearance20
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn27.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn27.Header.VisiblePosition = 14
        UltraGridColumn27.Hidden = True
        Appearance21.TextHAlignAsString = "Center"
        UltraGridColumn28.Header.Appearance = Appearance21
        UltraGridColumn28.Header.VisiblePosition = 10
        UltraGridColumn29.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance22.TextHAlignAsString = "Center"
        UltraGridColumn29.Header.Appearance = Appearance22
        UltraGridColumn29.Header.VisiblePosition = 11
        UltraGridColumn29.Hidden = True
        UltraGridColumn30.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance23.TextHAlignAsString = "Center"
        UltraGridColumn30.Header.Appearance = Appearance23
        UltraGridColumn30.Header.VisiblePosition = 12
        UltraGridColumn30.Hidden = True
        UltraGridColumn31.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance24.TextHAlignAsString = "Center"
        UltraGridColumn31.Header.Appearance = Appearance24
        UltraGridColumn31.Header.Caption = "Select"
        UltraGridColumn31.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn31.Header.VisiblePosition = 4
        UltraGridColumn31.Width = 40
        UltraGridColumn32.Header.VisiblePosition = 15
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance25.TextHAlignAsString = "Center"
        UltraGridColumn33.Header.Appearance = Appearance25
        UltraGridColumn33.Header.VisiblePosition = 7
        UltraGridColumn33.Hidden = True
        UltraGridColumn33.Width = 99
        UltraGridColumn34.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn34.Header.VisiblePosition = 16
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 17
        UltraGridColumn35.Hidden = True
        Appearance26.TextHAlignAsString = "Center"
        UltraGridColumn36.Header.Appearance = Appearance26
        UltraGridColumn36.Header.VisiblePosition = 8
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36})
        Me.grid_Equipos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.grid_Equipos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Equipos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Equipos.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Equipos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Equipos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Equipos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Equipos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Equipos.DisplayLayout.Override.CellPadding = 0
        Me.grid_Equipos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Equipos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Equipos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Equipos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Equipos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Equipos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Equipos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Equipos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Equipos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Equipos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Equipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Equipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Equipos.Location = New System.Drawing.Point(0, 62)
        Me.grid_Equipos.Name = "grid_Equipos"
        Me.grid_Equipos.Size = New System.Drawing.Size(515, 277)
        Me.grid_Equipos.TabIndex = 1
        Me.grid_Equipos.Text = "Grilla2"
        '
        'odEquipo
        '
        UltraDataColumn29.DataType = GetType(Boolean)
        UltraDataColumn31.DataType = GetType(Boolean)
        UltraDataColumn31.DefaultValue = False
        Me.odEquipo.Band.Columns.AddRange(New Object() {UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36})
        '
        'Agrupacion1
        '
        Me.Agrupacion1.Controls.Add(Me.btnListarEquipos)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta5)
        Me.Agrupacion1.Controls.Add(Me.cmbModelo)
        Me.Agrupacion1.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion1.Controls.Add(Me.cmbMarca)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(515, 62)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Agregar Equipos:"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnListarEquipos
        '
        Appearance27.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarEquipos.Appearance = Appearance27
        Me.btnListarEquipos.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarEquipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarEquipos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarEquipos.ImageList = Me.imagenes
        Me.btnListarEquipos.Location = New System.Drawing.Point(462, 21)
        Me.btnListarEquipos.Name = "btnListarEquipos"
        Me.btnListarEquipos.Size = New System.Drawing.Size(30, 32)
        Me.btnListarEquipos.TabIndex = 4
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
        Me.imagenes.Images.SetKeyName(6, "Actualizar")
        Me.imagenes.Images.SetKeyName(7, "")
        Me.imagenes.Images.SetKeyName(8, "")
        Me.imagenes.Images.SetKeyName(9, "")
        Me.imagenes.Images.SetKeyName(10, "")
        Me.imagenes.Images.SetKeyName(11, "add.ico")
        '
        'Etiqueta5
        '
        Appearance28.BackColor = System.Drawing.Color.Transparent
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance28
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta5.Location = New System.Drawing.Point(258, 31)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Modelo:"
        '
        'cmbModelo
        '
        Appearance29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModelo.Appearance = Appearance29
        Me.cmbModelo.DisplayMember = "Nombre"
        Me.cmbModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModelo.Location = New System.Drawing.Point(306, 29)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(131, 21)
        Me.cmbModelo.TabIndex = 3
        Me.cmbModelo.ValueMember = "Id"
        '
        'Etiqueta4
        '
        Appearance30.BackColor = System.Drawing.Color.Transparent
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance30
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta4.Location = New System.Drawing.Point(14, 31)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta4.TabIndex = 0
        Me.Etiqueta4.Text = "Marca:"
        '
        'cmbMarca
        '
        Appearance31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarca.Appearance = Appearance31
        Me.cmbMarca.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbMarca.DisplayMember = "Nombre"
        Me.cmbMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarca.Location = New System.Drawing.Point(57, 29)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(172, 21)
        Me.cmbMarca.TabIndex = 1
        Me.cmbMarca.ValueMember = "Id"
        '
        'UltraTabPageControl6
        '
        Me.UltraTabPageControl6.Controls.Add(Me.grid_MantenimientoMateriales)
        Me.UltraTabPageControl6.Controls.Add(Me.gbeMateriales)
        Me.UltraTabPageControl6.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl6.Name = "UltraTabPageControl6"
        Me.UltraTabPageControl6.Size = New System.Drawing.Size(1180, 345)
        '
        'grid_MantenimientoMateriales
        '
        Me.grid_MantenimientoMateriales.ContextMenuStrip = Me.mcDetalle
        Me.grid_MantenimientoMateriales.DataSource = Me.odMantenimientoMateriales
        UltraGridColumn37.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn37.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance32.TextHAlignAsString = "Center"
        UltraGridColumn37.Header.Appearance = Appearance32
        UltraGridColumn37.Header.VisiblePosition = 0
        UltraGridColumn37.Hidden = True
        UltraGridColumn38.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance33.TextHAlignAsString = "Center"
        UltraGridColumn38.Header.Appearance = Appearance33
        UltraGridColumn38.Header.VisiblePosition = 1
        UltraGridColumn38.Width = 30
        UltraGridColumn39.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn39.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance34.TextHAlignAsString = "Center"
        UltraGridColumn39.Header.Appearance = Appearance34
        UltraGridColumn39.Header.VisiblePosition = 2
        UltraGridColumn39.Hidden = True
        UltraGridColumn40.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn40.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance35.TextHAlignAsString = "Center"
        UltraGridColumn40.Header.Appearance = Appearance35
        UltraGridColumn40.Header.VisiblePosition = 3
        UltraGridColumn40.Hidden = True
        UltraGridColumn41.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance36.TextHAlignAsString = "Center"
        UltraGridColumn41.Header.Appearance = Appearance36
        UltraGridColumn41.Header.VisiblePosition = 4
        UltraGridColumn41.Width = 72
        UltraGridColumn42.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance37.TextHAlignAsString = "Center"
        UltraGridColumn42.Header.Appearance = Appearance37
        UltraGridColumn42.Header.VisiblePosition = 5
        UltraGridColumn42.Width = 322
        UltraGridColumn43.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn43.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance38.TextHAlignAsString = "Center"
        UltraGridColumn43.Header.Appearance = Appearance38
        UltraGridColumn43.Header.VisiblePosition = 6
        UltraGridColumn43.Hidden = True
        UltraGridColumn44.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn44.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance39.TextHAlignAsString = "Center"
        UltraGridColumn44.Header.Appearance = Appearance39
        UltraGridColumn44.Header.VisiblePosition = 7
        UltraGridColumn44.Hidden = True
        Appearance40.TextHAlignAsString = "Right"
        UltraGridColumn45.CellAppearance = Appearance40
        UltraGridColumn45.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn45.Format = "#,##0.00"
        Appearance41.TextHAlignAsString = "Center"
        UltraGridColumn45.Header.Appearance = Appearance41
        UltraGridColumn45.Header.VisiblePosition = 10
        UltraGridColumn45.Width = 62
        UltraGridColumn46.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn46.Header.VisiblePosition = 8
        UltraGridColumn47.Header.VisiblePosition = 9
        UltraGridColumn47.Hidden = True
        UltraGridColumn48.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn48.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn48.Header.VisiblePosition = 11
        UltraGridColumn48.Hidden = True
        UltraGridColumn49.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn49.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn49.Header.VisiblePosition = 12
        UltraGridColumn49.Hidden = True
        UltraGridColumn50.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn50.Header.VisiblePosition = 13
        UltraGridColumn50.Hidden = True
        UltraGridColumn51.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn51.Header.VisiblePosition = 14
        UltraGridColumn51.Hidden = True
        Appearance42.TextHAlignAsString = "Right"
        UltraGridColumn52.CellAppearance = Appearance42
        UltraGridColumn52.Format = "#,##0.00"
        UltraGridColumn52.Header.VisiblePosition = 15
        UltraGridColumn53.Header.VisiblePosition = 16
        UltraGridColumn53.Hidden = True
        UltraGridColumn54.Header.VisiblePosition = 17
        UltraGridColumn54.Hidden = True
        UltraGridColumn55.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn55.Header.VisiblePosition = 18
        UltraGridColumn55.Hidden = True
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55})
        Me.grid_MantenimientoMateriales.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.grid_MantenimientoMateriales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoMateriales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_MantenimientoMateriales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoMateriales.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_MantenimientoMateriales.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_MantenimientoMateriales.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.CellPadding = 0
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.HeaderCheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.WhenUsingCheckEditor
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_MantenimientoMateriales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoMateriales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_MantenimientoMateriales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_MantenimientoMateriales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_MantenimientoMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_MantenimientoMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_MantenimientoMateriales.Location = New System.Drawing.Point(0, 0)
        Me.grid_MantenimientoMateriales.Name = "grid_MantenimientoMateriales"
        Me.grid_MantenimientoMateriales.Size = New System.Drawing.Size(630, 345)
        Me.grid_MantenimientoMateriales.TabIndex = 0
        Me.grid_MantenimientoMateriales.Text = "Grilla1"
        '
        'odMantenimientoMateriales
        '
        UltraDataColumn38.DataType = GetType(Boolean)
        UltraDataColumn38.DefaultValue = False
        UltraDataColumn43.DataType = GetType(Boolean)
        UltraDataColumn45.DataType = GetType(Decimal)
        UltraDataColumn45.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        UltraDataColumn52.DataType = GetType(Double)
        Me.odMantenimientoMateriales.Band.Columns.AddRange(New Object() {UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46, UltraDataColumn47, UltraDataColumn48, UltraDataColumn49, UltraDataColumn50, UltraDataColumn51, UltraDataColumn52, UltraDataColumn53, UltraDataColumn54, UltraDataColumn55})
        '
        'gbeMateriales
        '
        Me.gbeMateriales.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeMateriales.Controls.Add(Me.UltraExpandableGroupBoxPanel2)
        Me.gbeMateriales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeMateriales.ExpandedSize = New System.Drawing.Size(550, 345)
        Me.gbeMateriales.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeMateriales.Location = New System.Drawing.Point(630, 0)
        Me.gbeMateriales.Name = "gbeMateriales"
        Me.gbeMateriales.Size = New System.Drawing.Size(550, 345)
        Me.gbeMateriales.TabIndex = 1
        Me.gbeMateriales.Text = "Materiales"
        Me.gbeMateriales.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel2
        '
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.grid_Materiales)
        Me.UltraExpandableGroupBoxPanel2.Controls.Add(Me.Agrupacion3)
        Me.UltraExpandableGroupBoxPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel2.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel2.Name = "UltraExpandableGroupBoxPanel2"
        Me.UltraExpandableGroupBoxPanel2.Size = New System.Drawing.Size(527, 339)
        Me.UltraExpandableGroupBoxPanel2.TabIndex = 0
        '
        'grid_Materiales
        '
        Me.grid_Materiales.ContextMenuStrip = Me.mcDetalle
        Me.grid_Materiales.DataSource = Me.odMateriales
        UltraGridColumn56.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn56.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance43.TextHAlignAsString = "Center"
        UltraGridColumn56.Header.Appearance = Appearance43
        UltraGridColumn56.Header.VisiblePosition = 0
        UltraGridColumn56.Hidden = True
        UltraGridColumn57.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance44.TextHAlignAsString = "Center"
        UltraGridColumn57.Header.Appearance = Appearance44
        UltraGridColumn57.Header.VisiblePosition = 1
        UltraGridColumn57.Width = 31
        UltraGridColumn58.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn58.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance45.TextHAlignAsString = "Center"
        UltraGridColumn58.Header.Appearance = Appearance45
        UltraGridColumn58.Header.VisiblePosition = 2
        UltraGridColumn58.Hidden = True
        UltraGridColumn59.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn59.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance46.TextHAlignAsString = "Center"
        UltraGridColumn59.Header.Appearance = Appearance46
        UltraGridColumn59.Header.VisiblePosition = 3
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance47.TextHAlignAsString = "Center"
        UltraGridColumn60.Header.Appearance = Appearance47
        UltraGridColumn60.Header.VisiblePosition = 4
        UltraGridColumn60.Width = 83
        UltraGridColumn61.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance48.TextHAlignAsString = "Center"
        UltraGridColumn61.Header.Appearance = Appearance48
        UltraGridColumn61.Header.VisiblePosition = 5
        UltraGridColumn61.Width = 401
        UltraGridColumn62.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn62.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance49.TextHAlignAsString = "Center"
        UltraGridColumn62.Header.Appearance = Appearance49
        UltraGridColumn62.Header.VisiblePosition = 6
        UltraGridColumn62.Hidden = True
        UltraGridColumn63.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn63.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance50.TextHAlignAsString = "Center"
        UltraGridColumn63.Header.Appearance = Appearance50
        UltraGridColumn63.Header.VisiblePosition = 7
        UltraGridColumn63.Hidden = True
        UltraGridColumn64.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance51.TextHAlignAsString = "Center"
        UltraGridColumn64.Header.Appearance = Appearance51
        UltraGridColumn64.Header.VisiblePosition = 8
        UltraGridColumn64.Hidden = True
        UltraGridColumn65.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance52.TextHAlignAsString = "Center"
        UltraGridColumn65.Header.Appearance = Appearance52
        UltraGridColumn65.Header.VisiblePosition = 9
        UltraGridColumn65.Hidden = True
        Appearance53.TextHAlignAsString = "Center"
        UltraGridColumn66.Header.Appearance = Appearance53
        UltraGridColumn66.Header.VisiblePosition = 10
        UltraGridColumn66.Hidden = True
        UltraGridColumn67.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance54.TextHAlignAsString = "Center"
        UltraGridColumn67.Header.Appearance = Appearance54
        UltraGridColumn67.Header.VisiblePosition = 11
        UltraGridColumn67.Hidden = True
        UltraGridColumn68.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance55.TextHAlignAsString = "Center"
        UltraGridColumn68.Header.Appearance = Appearance55
        UltraGridColumn68.Header.VisiblePosition = 12
        UltraGridColumn68.Hidden = True
        UltraGridColumn69.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance56.TextHAlignAsString = "Center"
        UltraGridColumn69.Header.Appearance = Appearance56
        UltraGridColumn69.Header.VisiblePosition = 13
        UltraGridColumn69.Hidden = True
        UltraGridColumn70.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn70.Header.VisiblePosition = 14
        UltraGridColumn70.Hidden = True
        UltraGridColumn71.Header.VisiblePosition = 15
        UltraGridColumn71.Hidden = True
        UltraGridColumn72.Header.VisiblePosition = 16
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.Header.VisiblePosition = 17
        UltraGridColumn73.Hidden = True
        UltraGridColumn74.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        UltraGridColumn74.Header.VisiblePosition = 18
        UltraGridColumn74.Hidden = True
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69, UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74})
        Me.grid_Materiales.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.grid_Materiales.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Materiales.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Materiales.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Materiales.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Materiales.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Materiales.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Materiales.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Materiales.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Materiales.DisplayLayout.Override.CellPadding = 0
        Me.grid_Materiales.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Materiales.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Materiales.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Materiales.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Materiales.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Materiales.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Materiales.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Materiales.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Materiales.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Materiales.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Materiales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Materiales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Materiales.Location = New System.Drawing.Point(0, 62)
        Me.grid_Materiales.Name = "grid_Materiales"
        Me.grid_Materiales.Size = New System.Drawing.Size(527, 277)
        Me.grid_Materiales.TabIndex = 1
        Me.grid_Materiales.Text = "Grilla2"
        '
        'odMateriales
        '
        UltraDataColumn57.DataType = GetType(Boolean)
        UltraDataColumn57.DefaultValue = False
        UltraDataColumn62.DataType = GetType(Boolean)
        Me.odMateriales.Band.Columns.AddRange(New Object() {UltraDataColumn56, UltraDataColumn57, UltraDataColumn58, UltraDataColumn59, UltraDataColumn60, UltraDataColumn61, UltraDataColumn62, UltraDataColumn63, UltraDataColumn64, UltraDataColumn65, UltraDataColumn66, UltraDataColumn67, UltraDataColumn68, UltraDataColumn69, UltraDataColumn70, UltraDataColumn71, UltraDataColumn72, UltraDataColumn73, UltraDataColumn74})
        '
        'Agrupacion3
        '
        Me.Agrupacion3.Controls.Add(Me.cmbSubFamilia)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta9)
        Me.Agrupacion3.Controls.Add(Me.btnListarMaterial)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion3.Controls.Add(Me.cmbFamilia)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(527, 62)
        Me.Agrupacion3.TabIndex = 0
        Me.Agrupacion3.Text = "Agregar Materiales:"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'cmbSubFamilia
        '
        Appearance57.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbSubFamilia.Appearance = Appearance57
        Me.cmbSubFamilia.DisplayMember = "Nombre"
        Me.cmbSubFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbSubFamilia.Location = New System.Drawing.Point(312, 29)
        Me.cmbSubFamilia.Name = "cmbSubFamilia"
        Me.cmbSubFamilia.Size = New System.Drawing.Size(162, 21)
        Me.cmbSubFamilia.TabIndex = 3
        Me.cmbSubFamilia.ValueMember = "Id"
        '
        'Etiqueta9
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta9.Appearance = Appearance58
        Me.Etiqueta9.AutoSize = True
        Me.Etiqueta9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta9.Location = New System.Drawing.Point(240, 33)
        Me.Etiqueta9.Name = "Etiqueta9"
        Me.Etiqueta9.Size = New System.Drawing.Size(66, 14)
        Me.Etiqueta9.TabIndex = 2
        Me.Etiqueta9.Text = "Sub-Familia:"
        '
        'btnListarMaterial
        '
        Appearance59.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarMaterial.Appearance = Appearance59
        Me.btnListarMaterial.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarMaterial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarMaterial.ImageList = Me.imagenes
        Me.btnListarMaterial.Location = New System.Drawing.Point(480, 24)
        Me.btnListarMaterial.Name = "btnListarMaterial"
        Me.btnListarMaterial.Size = New System.Drawing.Size(30, 32)
        Me.btnListarMaterial.TabIndex = 4
        '
        'Etiqueta7
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta7.Appearance = Appearance60
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta7.Location = New System.Drawing.Point(5, 33)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta7.TabIndex = 0
        Me.Etiqueta7.Text = "Familia:"
        '
        'cmbFamilia
        '
        Appearance61.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbFamilia.Appearance = Appearance61
        Me.cmbFamilia.DisplayMember = "Nombre"
        Me.cmbFamilia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbFamilia.Location = New System.Drawing.Point(54, 29)
        Me.cmbFamilia.Name = "cmbFamilia"
        Me.cmbFamilia.Size = New System.Drawing.Size(180, 21)
        Me.cmbFamilia.TabIndex = 1
        Me.cmbFamilia.ValueMember = "Id"
        '
        'UltraTabPageControl9
        '
        Me.UltraTabPageControl9.Controls.Add(Me.grid_MantenimientoServicios)
        Me.UltraTabPageControl9.Controls.Add(Me.gbeServicios)
        Me.UltraTabPageControl9.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl9.Name = "UltraTabPageControl9"
        Me.UltraTabPageControl9.Size = New System.Drawing.Size(1180, 345)
        '
        'grid_MantenimientoServicios
        '
        Me.grid_MantenimientoServicios.ContextMenuStrip = Me.mcDetalle
        Me.grid_MantenimientoServicios.DataSource = Me.odMantenimientoServicios
        UltraGridColumn75.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance62.TextHAlignAsString = "Center"
        UltraGridColumn75.Header.Appearance = Appearance62
        UltraGridColumn75.Header.VisiblePosition = 0
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance63.TextHAlignAsString = "Center"
        UltraGridColumn76.Header.Appearance = Appearance63
        UltraGridColumn76.Header.VisiblePosition = 1
        UltraGridColumn76.Width = 34
        UltraGridColumn77.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance64.TextHAlignAsString = "Center"
        UltraGridColumn77.Header.Appearance = Appearance64
        UltraGridColumn77.Header.VisiblePosition = 2
        UltraGridColumn77.Hidden = True
        UltraGridColumn78.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance65.TextHAlignAsString = "Center"
        UltraGridColumn78.Header.Appearance = Appearance65
        UltraGridColumn78.Header.VisiblePosition = 3
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance66.TextHAlignAsString = "Center"
        UltraGridColumn79.Header.Appearance = Appearance66
        UltraGridColumn79.Header.VisiblePosition = 4
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance67.TextHAlignAsString = "Center"
        UltraGridColumn80.Header.Appearance = Appearance67
        UltraGridColumn80.Header.VisiblePosition = 5
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance68.TextHAlignAsString = "Center"
        UltraGridColumn81.Header.Appearance = Appearance68
        UltraGridColumn81.Header.VisiblePosition = 6
        UltraGridColumn81.Width = 86
        UltraGridColumn82.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance69.TextHAlignAsString = "Center"
        UltraGridColumn82.Header.Appearance = Appearance69
        UltraGridColumn82.Header.VisiblePosition = 7
        UltraGridColumn82.Width = 308
        UltraGridColumn83.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance70.TextHAlignAsString = "Center"
        UltraGridColumn83.Header.Appearance = Appearance70
        UltraGridColumn83.Header.VisiblePosition = 8
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance71.TextHAlignAsString = "Center"
        UltraGridColumn84.Header.Appearance = Appearance71
        UltraGridColumn84.Header.VisiblePosition = 9
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance72.TextHAlignAsString = "Center"
        UltraGridColumn85.Header.Appearance = Appearance72
        UltraGridColumn85.Header.VisiblePosition = 10
        UltraGridColumn85.Hidden = True
        Appearance73.TextHAlignAsString = "Right"
        UltraGridColumn86.CellAppearance = Appearance73
        UltraGridColumn86.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance74.TextHAlignAsString = "Center"
        UltraGridColumn86.Header.Appearance = Appearance74
        UltraGridColumn86.Header.VisiblePosition = 11
        UltraGridColumn86.Width = 85
        UltraGridColumn87.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance75.TextHAlignAsString = "Center"
        UltraGridColumn87.Header.Appearance = Appearance75
        UltraGridColumn87.Header.VisiblePosition = 12
        UltraGridColumn87.Hidden = True
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87})
        Me.grid_MantenimientoServicios.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.grid_MantenimientoServicios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoServicios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_MantenimientoServicios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoServicios.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_MantenimientoServicios.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_MantenimientoServicios.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_MantenimientoServicios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoServicios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoServicios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_MantenimientoServicios.DisplayLayout.Override.CellPadding = 0
        Me.grid_MantenimientoServicios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_MantenimientoServicios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_MantenimientoServicios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_MantenimientoServicios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_MantenimientoServicios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_MantenimientoServicios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_MantenimientoServicios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoServicios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_MantenimientoServicios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_MantenimientoServicios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_MantenimientoServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_MantenimientoServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_MantenimientoServicios.Location = New System.Drawing.Point(0, 0)
        Me.grid_MantenimientoServicios.Name = "grid_MantenimientoServicios"
        Me.grid_MantenimientoServicios.Size = New System.Drawing.Size(647, 345)
        Me.grid_MantenimientoServicios.TabIndex = 0
        Me.grid_MantenimientoServicios.Text = "Grilla1"
        '
        'odMantenimientoServicios
        '
        UltraDataColumn76.DataType = GetType(Boolean)
        UltraDataColumn76.DefaultValue = False
        UltraDataColumn83.DataType = GetType(Boolean)
        UltraDataColumn86.DataType = GetType(Decimal)
        UltraDataColumn86.DefaultValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.odMantenimientoServicios.Band.Columns.AddRange(New Object() {UltraDataColumn75, UltraDataColumn76, UltraDataColumn77, UltraDataColumn78, UltraDataColumn79, UltraDataColumn80, UltraDataColumn81, UltraDataColumn82, UltraDataColumn83, UltraDataColumn84, UltraDataColumn85, UltraDataColumn86, UltraDataColumn87})
        '
        'gbeServicios
        '
        Me.gbeServicios.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeServicios.Controls.Add(Me.UltraExpandableGroupBoxPanel3)
        Me.gbeServicios.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeServicios.ExpandedSize = New System.Drawing.Size(533, 345)
        Me.gbeServicios.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeServicios.Location = New System.Drawing.Point(647, 0)
        Me.gbeServicios.Name = "gbeServicios"
        Me.gbeServicios.Size = New System.Drawing.Size(533, 345)
        Me.gbeServicios.TabIndex = 1
        Me.gbeServicios.Text = "Servicios"
        Me.gbeServicios.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel3
        '
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.grid_Servicios)
        Me.UltraExpandableGroupBoxPanel3.Controls.Add(Me.Agrupacion2)
        Me.UltraExpandableGroupBoxPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel3.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel3.Name = "UltraExpandableGroupBoxPanel3"
        Me.UltraExpandableGroupBoxPanel3.Size = New System.Drawing.Size(510, 339)
        Me.UltraExpandableGroupBoxPanel3.TabIndex = 0
        '
        'grid_Servicios
        '
        Me.grid_Servicios.ContextMenuStrip = Me.mcDetalle
        Me.grid_Servicios.DataSource = Me.odServicios
        UltraGridColumn88.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance76.TextHAlignAsString = "Center"
        UltraGridColumn88.Header.Appearance = Appearance76
        UltraGridColumn88.Header.VisiblePosition = 0
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance77.TextHAlignAsString = "Center"
        UltraGridColumn89.Header.Appearance = Appearance77
        UltraGridColumn89.Header.VisiblePosition = 1
        UltraGridColumn89.Width = 31
        UltraGridColumn90.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance78.TextHAlignAsString = "Center"
        UltraGridColumn90.Header.Appearance = Appearance78
        UltraGridColumn90.Header.VisiblePosition = 2
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 11
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 12
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance79.TextHAlignAsString = "Center"
        UltraGridColumn93.Header.Appearance = Appearance79
        UltraGridColumn93.Header.VisiblePosition = 3
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance80.TextHAlignAsString = "Center"
        UltraGridColumn94.Header.Appearance = Appearance80
        UltraGridColumn94.Header.VisiblePosition = 4
        UltraGridColumn94.Width = 83
        UltraGridColumn95.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance81.TextHAlignAsString = "Center"
        UltraGridColumn95.Header.Appearance = Appearance81
        UltraGridColumn95.Header.VisiblePosition = 5
        UltraGridColumn95.Width = 342
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance82.TextHAlignAsString = "Center"
        UltraGridColumn96.Header.Appearance = Appearance82
        UltraGridColumn96.Header.VisiblePosition = 6
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance83.TextHAlignAsString = "Center"
        UltraGridColumn97.Header.Appearance = Appearance83
        UltraGridColumn97.Header.VisiblePosition = 7
        UltraGridColumn97.Hidden = True
        UltraGridColumn98.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn98.Header.VisiblePosition = 8
        UltraGridColumn98.Hidden = True
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn99.Header.VisiblePosition = 9
        UltraGridColumn99.Hidden = True
        UltraGridColumn100.Header.VisiblePosition = 10
        UltraGridColumn100.Hidden = True
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100})
        Me.grid_Servicios.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.grid_Servicios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Servicios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Servicios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Servicios.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Servicios.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Servicios.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Servicios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Servicios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Servicios.DisplayLayout.Override.CellPadding = 0
        Me.grid_Servicios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Servicios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Servicios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Servicios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Servicios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Servicios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Servicios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Servicios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Servicios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Servicios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Servicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Servicios.Location = New System.Drawing.Point(0, 62)
        Me.grid_Servicios.Name = "grid_Servicios"
        Me.grid_Servicios.Size = New System.Drawing.Size(510, 277)
        Me.grid_Servicios.TabIndex = 1
        Me.grid_Servicios.Text = "Grilla2"
        '
        'odServicios
        '
        UltraDataColumn89.DataType = GetType(Boolean)
        UltraDataColumn89.DefaultValue = False
        UltraDataColumn96.DataType = GetType(Boolean)
        Me.odServicios.Band.Columns.AddRange(New Object() {UltraDataColumn88, UltraDataColumn89, UltraDataColumn90, UltraDataColumn91, UltraDataColumn92, UltraDataColumn93, UltraDataColumn94, UltraDataColumn95, UltraDataColumn96, UltraDataColumn97, UltraDataColumn98, UltraDataColumn99, UltraDataColumn100})
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.btnCategoria)
        Me.Agrupacion2.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion2.Controls.Add(Me.cmbCategoriaServicios)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(510, 62)
        Me.Agrupacion2.TabIndex = 0
        Me.Agrupacion2.Text = "Agregar Servicios:"
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnCategoria
        '
        Appearance84.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnCategoria.Appearance = Appearance84
        Me.btnCategoria.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCategoria.ImageList = Me.imagenes
        Me.btnCategoria.Location = New System.Drawing.Point(423, 21)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(30, 32)
        Me.btnCategoria.TabIndex = 2
        '
        'Etiqueta8
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta8.Appearance = Appearance85
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(24, 33)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(55, 14)
        Me.Etiqueta8.TabIndex = 0
        Me.Etiqueta8.Text = "Categoria:"
        '
        'cmbCategoriaServicios
        '
        Appearance86.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbCategoriaServicios.Appearance = Appearance86
        Me.cmbCategoriaServicios.DisplayMember = "Nombre"
        Me.cmbCategoriaServicios.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbCategoriaServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaServicios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbCategoriaServicios.Location = New System.Drawing.Point(85, 29)
        Me.cmbCategoriaServicios.Name = "cmbCategoriaServicios"
        Me.cmbCategoriaServicios.Size = New System.Drawing.Size(332, 21)
        Me.cmbCategoriaServicios.TabIndex = 1
        Me.cmbCategoriaServicios.ValueMember = "Id"
        '
        'UltraTabPageControl10
        '
        Me.UltraTabPageControl10.Controls.Add(Me.grid_MantenimientoOperarios)
        Me.UltraTabPageControl10.Controls.Add(Me.gbeRecursos)
        Me.UltraTabPageControl10.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl10.Name = "UltraTabPageControl10"
        Me.UltraTabPageControl10.Size = New System.Drawing.Size(1180, 345)
        '
        'grid_MantenimientoOperarios
        '
        Me.grid_MantenimientoOperarios.ContextMenuStrip = Me.mcDetalle
        Me.grid_MantenimientoOperarios.DataSource = Me.odMantenimientoOperarios
        UltraGridColumn101.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn101.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance87.TextHAlignAsString = "Center"
        UltraGridColumn101.Header.Appearance = Appearance87
        UltraGridColumn101.Header.VisiblePosition = 0
        UltraGridColumn101.Hidden = True
        UltraGridColumn102.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance88.TextHAlignAsString = "Center"
        UltraGridColumn102.Header.Appearance = Appearance88
        UltraGridColumn102.Header.VisiblePosition = 1
        UltraGridColumn102.Width = 34
        UltraGridColumn103.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn103.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance89.TextHAlignAsString = "Center"
        UltraGridColumn103.Header.Appearance = Appearance89
        UltraGridColumn103.Header.VisiblePosition = 3
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn104.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance90.TextHAlignAsString = "Center"
        UltraGridColumn104.Header.Appearance = Appearance90
        UltraGridColumn104.Header.VisiblePosition = 4
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance91.TextHAlignAsString = "Center"
        UltraGridColumn105.Header.Appearance = Appearance91
        UltraGridColumn105.Header.VisiblePosition = 2
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 81
        UltraGridColumn106.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance92.TextHAlignAsString = "Center"
        UltraGridColumn106.Header.Appearance = Appearance92
        UltraGridColumn106.Header.VisiblePosition = 5
        UltraGridColumn106.Width = 353
        Appearance93.TextHAlignAsString = "Right"
        UltraGridColumn107.CellAppearance = Appearance93
        UltraGridColumn107.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance94.TextHAlignAsString = "Center"
        UltraGridColumn107.Header.Appearance = Appearance94
        UltraGridColumn107.Header.VisiblePosition = 9
        UltraGridColumn107.Width = 75
        UltraGridColumn108.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn108.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance95.TextHAlignAsString = "Center"
        UltraGridColumn108.Header.Appearance = Appearance95
        UltraGridColumn108.Header.VisiblePosition = 6
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn109.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance96.TextHAlignAsString = "Center"
        UltraGridColumn109.Header.Appearance = Appearance96
        UltraGridColumn109.Header.VisiblePosition = 7
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn110.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance97.TextHAlignAsString = "Center"
        UltraGridColumn110.Header.Appearance = Appearance97
        UltraGridColumn110.Header.VisiblePosition = 8
        UltraGridColumn110.Hidden = True
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110})
        Me.grid_MantenimientoOperarios.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.grid_MantenimientoOperarios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoOperarios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_MantenimientoOperarios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoOperarios.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_MantenimientoOperarios.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_MantenimientoOperarios.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.CellPadding = 0
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_MantenimientoOperarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoOperarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_MantenimientoOperarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_MantenimientoOperarios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_MantenimientoOperarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_MantenimientoOperarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_MantenimientoOperarios.Location = New System.Drawing.Point(0, 0)
        Me.grid_MantenimientoOperarios.Name = "grid_MantenimientoOperarios"
        Me.grid_MantenimientoOperarios.Size = New System.Drawing.Size(679, 345)
        Me.grid_MantenimientoOperarios.TabIndex = 0
        Me.grid_MantenimientoOperarios.Text = "Grilla1"
        '
        'odMantenimientoOperarios
        '
        UltraDataColumn102.DataType = GetType(Boolean)
        UltraDataColumn102.DefaultValue = False
        UltraDataColumn107.DataType = GetType(Integer)
        UltraDataColumn107.DefaultValue = 0
        UltraDataColumn108.DataType = GetType(Boolean)
        Me.odMantenimientoOperarios.Band.Columns.AddRange(New Object() {UltraDataColumn101, UltraDataColumn102, UltraDataColumn103, UltraDataColumn104, UltraDataColumn105, UltraDataColumn106, UltraDataColumn107, UltraDataColumn108, UltraDataColumn109, UltraDataColumn110})
        '
        'gbeRecursos
        '
        Me.gbeRecursos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeRecursos.Controls.Add(Me.UltraExpandableGroupBoxPanel4)
        Me.gbeRecursos.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeRecursos.ExpandedSize = New System.Drawing.Size(501, 345)
        Me.gbeRecursos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeRecursos.Location = New System.Drawing.Point(679, 0)
        Me.gbeRecursos.Name = "gbeRecursos"
        Me.gbeRecursos.Size = New System.Drawing.Size(501, 345)
        Me.gbeRecursos.TabIndex = 1
        Me.gbeRecursos.Text = "Recursos"
        Me.gbeRecursos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel4
        '
        Me.UltraExpandableGroupBoxPanel4.Controls.Add(Me.grid_Operarios)
        Me.UltraExpandableGroupBoxPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel4.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel4.Name = "UltraExpandableGroupBoxPanel4"
        Me.UltraExpandableGroupBoxPanel4.Size = New System.Drawing.Size(478, 339)
        Me.UltraExpandableGroupBoxPanel4.TabIndex = 0
        '
        'grid_Operarios
        '
        Me.grid_Operarios.ContextMenuStrip = Me.mcDetalle
        Me.grid_Operarios.DataSource = Me.odOperarios
        UltraGridColumn111.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn111.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance98.TextHAlignAsString = "Center"
        UltraGridColumn111.Header.Appearance = Appearance98
        UltraGridColumn111.Header.VisiblePosition = 0
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance99.TextHAlignAsString = "Center"
        UltraGridColumn112.Header.Appearance = Appearance99
        UltraGridColumn112.Header.VisiblePosition = 1
        UltraGridColumn112.Width = 31
        UltraGridColumn113.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn113.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance100.TextHAlignAsString = "Center"
        UltraGridColumn113.Header.Appearance = Appearance100
        UltraGridColumn113.Header.VisiblePosition = 2
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn114.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance101.TextHAlignAsString = "Center"
        UltraGridColumn114.Header.Appearance = Appearance101
        UltraGridColumn114.Header.VisiblePosition = 3
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance102.TextHAlignAsString = "Center"
        UltraGridColumn115.Header.Appearance = Appearance102
        UltraGridColumn115.Header.VisiblePosition = 4
        UltraGridColumn115.Hidden = True
        UltraGridColumn115.Width = 72
        UltraGridColumn116.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance103.TextHAlignAsString = "Center"
        UltraGridColumn116.Header.Appearance = Appearance103
        UltraGridColumn116.Header.VisiblePosition = 5
        UltraGridColumn116.Width = 345
        UltraGridColumn117.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance104.TextHAlignAsString = "Center"
        UltraGridColumn117.Header.Appearance = Appearance104
        UltraGridColumn117.Header.VisiblePosition = 8
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn118.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance105.TextHAlignAsString = "Center"
        UltraGridColumn118.Header.Appearance = Appearance105
        UltraGridColumn118.Header.VisiblePosition = 6
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn119.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance106.TextHAlignAsString = "Center"
        UltraGridColumn119.Header.Appearance = Appearance106
        UltraGridColumn119.Header.VisiblePosition = 7
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn120.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance107.TextHAlignAsString = "Center"
        UltraGridColumn120.Header.Appearance = Appearance107
        UltraGridColumn120.Header.VisiblePosition = 9
        UltraGridColumn120.Hidden = True
        UltraGridBand8.Columns.AddRange(New Object() {UltraGridColumn111, UltraGridColumn112, UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120})
        Me.grid_Operarios.DisplayLayout.BandsSerializer.Add(UltraGridBand8)
        Me.grid_Operarios.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Operarios.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Operarios.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Operarios.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Operarios.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Operarios.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Operarios.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Operarios.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Operarios.DisplayLayout.Override.CellPadding = 0
        Me.grid_Operarios.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Operarios.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Operarios.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Operarios.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Operarios.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Operarios.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Operarios.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Operarios.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Operarios.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Operarios.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Operarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Operarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Operarios.Location = New System.Drawing.Point(0, 0)
        Me.grid_Operarios.Name = "grid_Operarios"
        Me.grid_Operarios.Size = New System.Drawing.Size(478, 339)
        Me.grid_Operarios.TabIndex = 0
        Me.grid_Operarios.Text = "Grilla2"
        '
        'odOperarios
        '
        UltraDataColumn112.DataType = GetType(Boolean)
        UltraDataColumn112.DefaultValue = False
        UltraDataColumn118.DataType = GetType(Boolean)
        Me.odOperarios.Band.Columns.AddRange(New Object() {UltraDataColumn111, UltraDataColumn112, UltraDataColumn113, UltraDataColumn114, UltraDataColumn115, UltraDataColumn116, UltraDataColumn117, UltraDataColumn118, UltraDataColumn119, UltraDataColumn120})
        '
        'UltraTabPageControl11
        '
        Me.UltraTabPageControl11.Controls.Add(Me.grid_MantenimientoActividades)
        Me.UltraTabPageControl11.Controls.Add(Me.gbeActividades)
        Me.UltraTabPageControl11.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl11.Name = "UltraTabPageControl11"
        Me.UltraTabPageControl11.Size = New System.Drawing.Size(1180, 345)
        '
        'grid_MantenimientoActividades
        '
        Me.grid_MantenimientoActividades.ContextMenuStrip = Me.mcDetalle
        Me.grid_MantenimientoActividades.DataSource = Me.odMantenimientoActividades
        UltraGridColumn121.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance108.TextHAlignAsString = "Center"
        UltraGridColumn121.Header.Appearance = Appearance108
        UltraGridColumn121.Header.VisiblePosition = 0
        UltraGridColumn121.Hidden = True
        UltraGridColumn122.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance109.TextHAlignAsString = "Center"
        UltraGridColumn122.Header.Appearance = Appearance109
        UltraGridColumn122.Header.VisiblePosition = 1
        UltraGridColumn122.Width = 33
        UltraGridColumn123.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance110.TextHAlignAsString = "Center"
        UltraGridColumn123.Header.Appearance = Appearance110
        UltraGridColumn123.Header.VisiblePosition = 2
        UltraGridColumn123.Hidden = True
        UltraGridColumn124.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance111.TextHAlignAsString = "Center"
        UltraGridColumn124.Header.Appearance = Appearance111
        UltraGridColumn124.Header.VisiblePosition = 3
        UltraGridColumn124.Hidden = True
        Appearance112.TextHAlignAsString = "Center"
        UltraGridColumn125.Header.Appearance = Appearance112
        UltraGridColumn125.Header.VisiblePosition = 4
        UltraGridColumn125.Width = 86
        Appearance113.TextHAlignAsString = "Center"
        UltraGridColumn126.Header.Appearance = Appearance113
        UltraGridColumn126.Header.VisiblePosition = 5
        UltraGridColumn126.Width = 259
        Appearance114.TextHAlignAsString = "Right"
        UltraGridColumn127.CellAppearance = Appearance114
        UltraGridColumn127.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Appearance115.TextHAlignAsString = "Center"
        UltraGridColumn127.Header.Appearance = Appearance115
        UltraGridColumn127.Header.Caption = "Horas"
        UltraGridColumn127.Header.VisiblePosition = 6
        UltraGridColumn127.MaskInput = "{LOC}hh:mm"
        UltraGridColumn127.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTimeWithSpin
        UltraGridColumn127.Width = 64
        UltraGridColumn128.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance116.TextHAlignAsString = "Center"
        UltraGridColumn128.Header.Appearance = Appearance116
        UltraGridColumn128.Header.VisiblePosition = 7
        UltraGridColumn128.Hidden = True
        UltraGridColumn129.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance117.TextHAlignAsString = "Center"
        UltraGridColumn129.Header.Appearance = Appearance117
        UltraGridColumn129.Header.VisiblePosition = 8
        UltraGridColumn129.Hidden = True
        UltraGridBand9.Columns.AddRange(New Object() {UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129})
        Me.grid_MantenimientoActividades.DisplayLayout.BandsSerializer.Add(UltraGridBand9)
        Me.grid_MantenimientoActividades.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoActividades.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance118.BorderColor = System.Drawing.SystemColors.Window
        Me.grid_MantenimientoActividades.DisplayLayout.GroupByBox.Appearance = Appearance118
        Me.grid_MantenimientoActividades.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_MantenimientoActividades.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_MantenimientoActividades.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_MantenimientoActividades.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_MantenimientoActividades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoActividades.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoActividades.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.grid_MantenimientoActividades.DisplayLayout.Override.CellPadding = 0
        Me.grid_MantenimientoActividades.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_MantenimientoActividades.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_MantenimientoActividades.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_MantenimientoActividades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_MantenimientoActividades.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_MantenimientoActividades.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_MantenimientoActividades.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_MantenimientoActividades.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_MantenimientoActividades.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_MantenimientoActividades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_MantenimientoActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_MantenimientoActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_MantenimientoActividades.Location = New System.Drawing.Point(0, 0)
        Me.grid_MantenimientoActividades.Name = "grid_MantenimientoActividades"
        Me.grid_MantenimientoActividades.Size = New System.Drawing.Size(672, 345)
        Me.grid_MantenimientoActividades.TabIndex = 0
        Me.grid_MantenimientoActividades.Text = "Grilla1"
        '
        'odMantenimientoActividades
        '
        UltraDataColumn122.DataType = GetType(Boolean)
        UltraDataColumn122.DefaultValue = False
        UltraDataColumn127.DataType = GetType(Date)
        UltraDataColumn127.DefaultValue = New Date(1901, 1, 1, 0, 0, 0, 0)
        UltraDataColumn128.DataType = GetType(Boolean)
        Me.odMantenimientoActividades.Band.Columns.AddRange(New Object() {UltraDataColumn121, UltraDataColumn122, UltraDataColumn123, UltraDataColumn124, UltraDataColumn125, UltraDataColumn126, UltraDataColumn127, UltraDataColumn128, UltraDataColumn129})
        '
        'gbeActividades
        '
        Me.gbeActividades.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.gbeActividades.Controls.Add(Me.UltraExpandableGroupBoxPanel5)
        Me.gbeActividades.Dock = System.Windows.Forms.DockStyle.Right
        Me.gbeActividades.ExpandedSize = New System.Drawing.Size(508, 345)
        Me.gbeActividades.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.gbeActividades.Location = New System.Drawing.Point(672, 0)
        Me.gbeActividades.Name = "gbeActividades"
        Me.gbeActividades.Size = New System.Drawing.Size(508, 345)
        Me.gbeActividades.TabIndex = 1
        Me.gbeActividades.Text = "Actividades"
        Me.gbeActividades.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel5
        '
        Me.UltraExpandableGroupBoxPanel5.Controls.Add(Me.grid_Actividades)
        Me.UltraExpandableGroupBoxPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel5.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel5.Name = "UltraExpandableGroupBoxPanel5"
        Me.UltraExpandableGroupBoxPanel5.Size = New System.Drawing.Size(485, 339)
        Me.UltraExpandableGroupBoxPanel5.TabIndex = 0
        '
        'grid_Actividades
        '
        Me.grid_Actividades.ContextMenuStrip = Me.mcDetalle
        Me.grid_Actividades.DataSource = Me.odActividades
        UltraGridColumn130.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance119.TextHAlignAsString = "Center"
        UltraGridColumn130.Header.Appearance = Appearance119
        UltraGridColumn130.Header.VisiblePosition = 0
        UltraGridColumn130.Hidden = True
        UltraGridColumn131.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance120.TextHAlignAsString = "Center"
        UltraGridColumn131.Header.Appearance = Appearance120
        UltraGridColumn131.Header.VisiblePosition = 1
        UltraGridColumn131.Width = 34
        UltraGridColumn132.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance121.TextHAlignAsString = "Center"
        UltraGridColumn132.Header.Appearance = Appearance121
        UltraGridColumn132.Header.VisiblePosition = 2
        UltraGridColumn132.Hidden = True
        UltraGridColumn133.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance122.TextHAlignAsString = "Center"
        UltraGridColumn133.Header.Appearance = Appearance122
        UltraGridColumn133.Header.VisiblePosition = 3
        UltraGridColumn133.Hidden = True
        Appearance123.TextHAlignAsString = "Center"
        UltraGridColumn134.Header.Appearance = Appearance123
        UltraGridColumn134.Header.VisiblePosition = 4
        UltraGridColumn134.Width = 88
        Appearance124.TextHAlignAsString = "Center"
        UltraGridColumn135.Header.Appearance = Appearance124
        UltraGridColumn135.Header.VisiblePosition = 5
        UltraGridColumn135.Width = 317
        Appearance125.TextHAlignAsString = "Center"
        UltraGridColumn136.Header.Appearance = Appearance125
        UltraGridColumn136.Header.VisiblePosition = 6
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance126.TextHAlignAsString = "Center"
        UltraGridColumn137.Header.Appearance = Appearance126
        UltraGridColumn137.Header.VisiblePosition = 7
        UltraGridColumn137.Hidden = True
        UltraGridColumn138.ExcludeFromColumnChooser = Infragistics.Win.UltraWinGrid.ExcludeFromColumnChooser.[True]
        Appearance127.TextHAlignAsString = "Center"
        UltraGridColumn138.Header.Appearance = Appearance127
        UltraGridColumn138.Header.VisiblePosition = 8
        UltraGridColumn138.Hidden = True
        UltraGridBand10.Columns.AddRange(New Object() {UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138})
        Me.grid_Actividades.DisplayLayout.BandsSerializer.Add(UltraGridBand10)
        Me.grid_Actividades.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Actividades.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Actividades.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Actividades.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Actividades.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Actividades.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Actividades.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Actividades.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_Actividades.DisplayLayout.Override.CellPadding = 0
        Me.grid_Actividades.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Actividades.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Actividades.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Actividades.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Actividades.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Actividades.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.RowIndex
        Me.grid_Actividades.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Actividades.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Actividades.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Actividades.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Actividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Actividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Actividades.Location = New System.Drawing.Point(0, 0)
        Me.grid_Actividades.Name = "grid_Actividades"
        Me.grid_Actividades.Size = New System.Drawing.Size(485, 339)
        Me.grid_Actividades.TabIndex = 0
        Me.grid_Actividades.Text = "Grilla2"
        '
        'odActividades
        '
        UltraDataColumn131.DataType = GetType(Boolean)
        UltraDataColumn131.DefaultValue = False
        UltraDataColumn137.DataType = GetType(Boolean)
        Me.odActividades.Band.Columns.AddRange(New Object() {UltraDataColumn130, UltraDataColumn131, UltraDataColumn132, UltraDataColumn133, UltraDataColumn134, UltraDataColumn135, UltraDataColumn136, UltraDataColumn137, UltraDataColumn138})
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.grid_Mantenimientos)
        Me.UltraTabPageControl1.Controls.Add(Me.uegbEquipos)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1188, 552)
        '
        'grid_Mantenimientos
        '
        Me.grid_Mantenimientos.ContextMenuStrip = Me.mcMantenimiento
        Me.grid_Mantenimientos.DataSource = Me.odMantenimientos
        UltraGridColumn139.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance128.TextHAlignAsString = "Center"
        UltraGridColumn139.Header.Appearance = Appearance128
        UltraGridColumn139.Header.VisiblePosition = 0
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance129.TextHAlignAsString = "Center"
        UltraGridColumn140.Header.Appearance = Appearance129
        UltraGridColumn140.Header.VisiblePosition = 2
        UltraGridColumn140.Width = 83
        UltraGridColumn141.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance130.TextHAlignAsString = "Center"
        UltraGridColumn141.Header.Appearance = Appearance130
        UltraGridColumn141.Header.VisiblePosition = 3
        UltraGridColumn141.Width = 251
        UltraGridColumn142.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance131.TextHAlignAsString = "Center"
        UltraGridColumn142.Header.Appearance = Appearance131
        UltraGridColumn142.Header.VisiblePosition = 4
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance132.TextHAlignAsString = "Center"
        UltraGridColumn143.Header.Appearance = Appearance132
        UltraGridColumn143.Header.Caption = "Tipo Mantenimiento"
        UltraGridColumn143.Header.VisiblePosition = 6
        UltraGridColumn143.Width = 144
        UltraGridColumn144.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance133.TextHAlignAsString = "Center"
        UltraGridColumn144.Header.Appearance = Appearance133
        UltraGridColumn144.Header.VisiblePosition = 7
        UltraGridColumn144.Hidden = True
        Appearance134.TextHAlignAsString = "Right"
        UltraGridColumn145.CellAppearance = Appearance134
        UltraGridColumn145.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance135.TextHAlignAsString = "Center"
        UltraGridColumn145.Header.Appearance = Appearance135
        UltraGridColumn145.Header.VisiblePosition = 9
        UltraGridColumn146.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance136.TextHAlignAsString = "Center"
        UltraGridColumn146.Header.Appearance = Appearance136
        UltraGridColumn146.Header.VisiblePosition = 10
        UltraGridColumn146.Hidden = True
        Appearance137.TextHAlignAsString = "Center"
        UltraGridColumn147.CellAppearance = Appearance137
        UltraGridColumn147.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance138.TextHAlignAsString = "Center"
        UltraGridColumn147.Header.Appearance = Appearance138
        UltraGridColumn147.Header.Caption = "Unidad Medida"
        UltraGridColumn147.Header.VisiblePosition = 11
        UltraGridColumn147.Width = 102
        UltraGridColumn148.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance139.TextHAlignAsString = "Center"
        UltraGridColumn148.Header.Appearance = Appearance139
        UltraGridColumn148.Header.VisiblePosition = 12
        UltraGridColumn148.Hidden = True
        UltraGridColumn149.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance140.TextHAlignAsString = "Center"
        UltraGridColumn149.Header.Appearance = Appearance140
        UltraGridColumn149.Header.Caption = "Patron"
        UltraGridColumn149.Header.VisiblePosition = 5
        Appearance141.TextHAlignAsString = "Center"
        UltraGridColumn150.CellAppearance = Appearance141
        UltraGridColumn150.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Appearance142.TextHAlignAsString = "Center"
        UltraGridColumn150.Header.Appearance = Appearance142
        UltraGridColumn150.Header.Caption = "N° Secuencia"
        UltraGridColumn150.Header.VisiblePosition = 13
        UltraGridColumn151.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        UltraGridColumn151.Header.VisiblePosition = 1
        UltraGridColumn151.Width = 44
        Appearance143.TextHAlignAsString = "Right"
        UltraGridColumn152.CellAppearance = Appearance143
        UltraGridColumn152.Format = "#,##0.00"
        Appearance144.TextHAlignAsString = "Center"
        UltraGridColumn152.Header.Appearance = Appearance144
        UltraGridColumn152.Header.VisiblePosition = 14
        UltraGridColumn153.Header.VisiblePosition = 8
        UltraGridColumn153.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox
        UltraGridBand11.Columns.AddRange(New Object() {UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152, UltraGridColumn153})
        Me.grid_Mantenimientos.DisplayLayout.BandsSerializer.Add(UltraGridBand11)
        Me.grid_Mantenimientos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Mantenimientos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_Mantenimientos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_Mantenimientos.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_Mantenimientos.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_Mantenimientos.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_Mantenimientos.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_Mantenimientos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_Mantenimientos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_Mantenimientos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_Mantenimientos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_Mantenimientos.DisplayLayout.Override.MaxSelectedRows = 1
        Me.grid_Mantenimientos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_Mantenimientos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_Mantenimientos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_Mantenimientos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_Mantenimientos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_Mantenimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Mantenimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_Mantenimientos.Location = New System.Drawing.Point(0, 0)
        Me.grid_Mantenimientos.Name = "grid_Mantenimientos"
        Me.grid_Mantenimientos.Size = New System.Drawing.Size(717, 552)
        Me.grid_Mantenimientos.TabIndex = 0
        Me.grid_Mantenimientos.Text = "Grilla1"
        '
        'mcMantenimiento
        '
        Me.mcMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcMantenimiento.ForeColor = System.Drawing.Color.Black
        Me.mcMantenimiento.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertarToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.mcMantenimiento.Name = "MenuContextual1"
        Me.mcMantenimiento.Size = New System.Drawing.Size(121, 70)
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.InsertarToolStripMenuItem.Text = "Nuevo"
        Me.InsertarToolStripMenuItem.ToolTipText = "Insertar un nuevo Mantenimiento"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.ToolTipText = "Eliminar el banco seleccionado"
        '
        'odMantenimientos
        '
        UltraDataColumn144.DataType = GetType(Boolean)
        UltraDataColumn145.DataType = GetType(Double)
        UltraDataColumn145.DefaultValue = 0.0R
        UltraDataColumn150.DataType = GetType(Integer)
        UltraDataColumn150.DefaultValue = 0
        UltraDataColumn151.DataType = GetType(Boolean)
        UltraDataColumn151.DefaultValue = False
        UltraDataColumn152.DataType = GetType(Double)
        UltraDataColumn153.DataType = GetType(Integer)
        Me.odMantenimientos.Band.Columns.AddRange(New Object() {UltraDataColumn139, UltraDataColumn140, UltraDataColumn141, UltraDataColumn142, UltraDataColumn143, UltraDataColumn144, UltraDataColumn145, UltraDataColumn146, UltraDataColumn147, UltraDataColumn148, UltraDataColumn149, UltraDataColumn150, UltraDataColumn151, UltraDataColumn152, UltraDataColumn153})
        '
        'uegbEquipos
        '
        Me.uegbEquipos.CaptionAlignment = Infragistics.Win.Misc.GroupBoxCaptionAlignment.Center
        Me.uegbEquipos.Controls.Add(Me.UltraExpandableGroupBoxPanel6)
        Me.uegbEquipos.Dock = System.Windows.Forms.DockStyle.Right
        Me.uegbEquipos.ExpandedSize = New System.Drawing.Size(471, 552)
        Me.uegbEquipos.HeaderPosition = Infragistics.Win.Misc.GroupBoxHeaderPosition.LeftOnBorder
        Me.uegbEquipos.Location = New System.Drawing.Point(717, 0)
        Me.uegbEquipos.Name = "uegbEquipos"
        Me.uegbEquipos.Size = New System.Drawing.Size(471, 552)
        Me.uegbEquipos.TabIndex = 1
        Me.uegbEquipos.Text = "Equipos"
        Me.uegbEquipos.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'UltraExpandableGroupBoxPanel6
        '
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.grid_EquipoAsig)
        Me.UltraExpandableGroupBoxPanel6.Controls.Add(Me.Agrupacion4)
        Me.UltraExpandableGroupBoxPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraExpandableGroupBoxPanel6.Location = New System.Drawing.Point(20, 3)
        Me.UltraExpandableGroupBoxPanel6.Name = "UltraExpandableGroupBoxPanel6"
        Me.UltraExpandableGroupBoxPanel6.Size = New System.Drawing.Size(448, 546)
        Me.UltraExpandableGroupBoxPanel6.TabIndex = 0
        '
        'grid_EquipoAsig
        '
        Me.grid_EquipoAsig.ContextMenuStrip = Me.mcDetalle
        Me.grid_EquipoAsig.DataSource = Me.odEquipoAsig
        Appearance145.TextHAlignAsString = "Center"
        UltraGridColumn154.Header.Appearance = Appearance145
        UltraGridColumn154.Header.VisiblePosition = 0
        UltraGridColumn154.Hidden = True
        UltraGridColumn154.Width = 33
        Appearance146.TextHAlignAsString = "Center"
        UltraGridColumn155.Header.Appearance = Appearance146
        UltraGridColumn155.Header.VisiblePosition = 1
        UltraGridColumn155.Hidden = True
        Appearance147.TextHAlignAsString = "Center"
        UltraGridColumn156.Header.Appearance = Appearance147
        UltraGridColumn156.Header.VisiblePosition = 2
        UltraGridColumn156.Hidden = True
        Appearance148.TextHAlignAsString = "Center"
        UltraGridColumn157.Header.Appearance = Appearance148
        UltraGridColumn157.Header.VisiblePosition = 3
        UltraGridColumn157.Hidden = True
        Appearance149.TextHAlignAsString = "Center"
        UltraGridColumn158.Header.Appearance = Appearance149
        UltraGridColumn158.Header.VisiblePosition = 5
        UltraGridColumn158.Hidden = True
        UltraGridColumn158.Width = 80
        Appearance150.TextHAlignAsString = "Center"
        UltraGridColumn159.Header.Appearance = Appearance150
        UltraGridColumn159.Header.VisiblePosition = 6
        UltraGridColumn159.Width = 132
        UltraGridColumn160.Header.VisiblePosition = 12
        UltraGridColumn160.Hidden = True
        Appearance151.TextHAlignAsString = "Center"
        UltraGridColumn161.Header.Appearance = Appearance151
        UltraGridColumn161.Header.VisiblePosition = 8
        UltraGridColumn162.Header.VisiblePosition = 13
        UltraGridColumn162.Hidden = True
        Appearance152.TextHAlignAsString = "Center"
        UltraGridColumn163.Header.Appearance = Appearance152
        UltraGridColumn163.Header.VisiblePosition = 9
        Appearance153.TextHAlignAsString = "Center"
        UltraGridColumn164.Header.Appearance = Appearance153
        UltraGridColumn164.Header.VisiblePosition = 10
        UltraGridColumn164.Hidden = True
        Appearance154.TextHAlignAsString = "Center"
        UltraGridColumn165.Header.Appearance = Appearance154
        UltraGridColumn165.Header.VisiblePosition = 11
        UltraGridColumn165.Hidden = True
        UltraGridColumn166.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.Edit
        Appearance155.TextHAlignAsString = "Center"
        UltraGridColumn166.Header.Appearance = Appearance155
        UltraGridColumn166.Header.Caption = "Select"
        UltraGridColumn166.Header.CheckBoxVisibility = Infragistics.Win.UltraWinGrid.HeaderCheckBoxVisibility.Always
        UltraGridColumn166.Header.VisiblePosition = 4
        UltraGridColumn166.Width = 47
        UltraGridColumn167.Header.VisiblePosition = 14
        UltraGridColumn167.Hidden = True
        UltraGridColumn168.Header.VisiblePosition = 15
        UltraGridColumn168.Hidden = True
        UltraGridColumn169.Header.VisiblePosition = 16
        UltraGridColumn169.Hidden = True
        Appearance156.TextHAlignAsString = "Center"
        UltraGridColumn170.Header.Appearance = Appearance156
        UltraGridColumn170.Header.VisiblePosition = 7
        UltraGridColumn171.Header.VisiblePosition = 17
        UltraGridColumn171.Hidden = True
        UltraGridBand12.Columns.AddRange(New Object() {UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159, UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164, UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168, UltraGridColumn169, UltraGridColumn170, UltraGridColumn171})
        Me.grid_EquipoAsig.DisplayLayout.BandsSerializer.Add(UltraGridBand12)
        Me.grid_EquipoAsig.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_EquipoAsig.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grid_EquipoAsig.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grid_EquipoAsig.DisplayLayout.GroupByBox.Hidden = True
        Me.grid_EquipoAsig.DisplayLayout.MaxColScrollRegions = 1
        Me.grid_EquipoAsig.DisplayLayout.MaxRowScrollRegions = 1
        Me.grid_EquipoAsig.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_EquipoAsig.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect
        Me.grid_EquipoAsig.DisplayLayout.Override.CellPadding = 0
        Me.grid_EquipoAsig.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.grid_EquipoAsig.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.grid_EquipoAsig.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.grid_EquipoAsig.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grid_EquipoAsig.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.grid_EquipoAsig.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.grid_EquipoAsig.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grid_EquipoAsig.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grid_EquipoAsig.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grid_EquipoAsig.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grid_EquipoAsig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_EquipoAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_EquipoAsig.Location = New System.Drawing.Point(0, 84)
        Me.grid_EquipoAsig.Name = "grid_EquipoAsig"
        Me.grid_EquipoAsig.Size = New System.Drawing.Size(448, 462)
        Me.grid_EquipoAsig.TabIndex = 1
        Me.grid_EquipoAsig.Text = "Grilla2"
        '
        'odEquipoAsig
        '
        UltraDataColumn164.DataType = GetType(Boolean)
        UltraDataColumn166.DataType = GetType(Boolean)
        UltraDataColumn166.DefaultValue = False
        UltraDataColumn171.DataType = GetType(Double)
        Me.odEquipoAsig.Band.Columns.AddRange(New Object() {UltraDataColumn154, UltraDataColumn155, UltraDataColumn156, UltraDataColumn157, UltraDataColumn158, UltraDataColumn159, UltraDataColumn160, UltraDataColumn161, UltraDataColumn162, UltraDataColumn163, UltraDataColumn164, UltraDataColumn165, UltraDataColumn166, UltraDataColumn167, UltraDataColumn168, UltraDataColumn169, UltraDataColumn170, UltraDataColumn171})
        '
        'Agrupacion4
        '
        Me.Agrupacion4.Controls.Add(Me.btnAsignar)
        Me.Agrupacion4.Controls.Add(Me.btnListarAsig)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion4.Controls.Add(Me.cmbModeloAsig)
        Me.Agrupacion4.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion4.Controls.Add(Me.cmbMarcaAsig)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Agrupacion4.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(448, 84)
        Me.Agrupacion4.TabIndex = 0
        Me.Agrupacion4.Text = "Asignar Equipos:"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnAsignar
        '
        Me.btnAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance157.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnAsignar.Appearance = Appearance157
        Me.btnAsignar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnAsignar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnAsignar.ImageList = Me.imagenes
        Me.btnAsignar.Location = New System.Drawing.Point(346, 40)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(92, 32)
        Me.btnAsignar.TabIndex = 5
        Me.btnAsignar.Text = "Asignar"
        '
        'btnListarAsig
        '
        Me.btnListarAsig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance158.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        Me.btnListarAsig.Appearance = Appearance158
        Me.btnListarAsig.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnListarAsig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnListarAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarAsig.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnListarAsig.ImageList = Me.imagenes
        Me.btnListarAsig.Location = New System.Drawing.Point(248, 40)
        Me.btnListarAsig.Name = "btnListarAsig"
        Me.btnListarAsig.Size = New System.Drawing.Size(92, 32)
        Me.btnListarAsig.TabIndex = 4
        Me.btnListarAsig.Text = "Listar"
        '
        'Etiqueta11
        '
        Appearance159.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta11.Appearance = Appearance159
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(9, 58)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(43, 14)
        Me.Etiqueta11.TabIndex = 2
        Me.Etiqueta11.Text = "Modelo:"
        '
        'cmbModeloAsig
        '
        Appearance160.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModeloAsig.Appearance = Appearance160
        Me.cmbModeloAsig.DisplayMember = "Nombre"
        Me.cmbModeloAsig.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbModeloAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModeloAsig.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbModeloAsig.Location = New System.Drawing.Point(57, 56)
        Me.cmbModeloAsig.Name = "cmbModeloAsig"
        Me.cmbModeloAsig.Size = New System.Drawing.Size(172, 21)
        Me.cmbModeloAsig.TabIndex = 3
        Me.cmbModeloAsig.ValueMember = "Id"
        '
        'Etiqueta12
        '
        Appearance161.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta12.Appearance = Appearance161
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(14, 31)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(38, 14)
        Me.Etiqueta12.TabIndex = 0
        Me.Etiqueta12.Text = "Marca:"
        '
        'cmbMarcaAsig
        '
        Appearance162.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarcaAsig.Appearance = Appearance162
        Me.cmbMarcaAsig.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbMarcaAsig.DisplayMember = "Nombre"
        Me.cmbMarcaAsig.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbMarcaAsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarcaAsig.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbMarcaAsig.Location = New System.Drawing.Point(57, 29)
        Me.cmbMarcaAsig.Name = "cmbMarcaAsig"
        Me.cmbMarcaAsig.Size = New System.Drawing.Size(172, 21)
        Me.cmbMarcaAsig.TabIndex = 1
        Me.cmbMarcaAsig.ValueMember = "Id"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.agrDetalle)
        Me.UltraTabPageControl2.Controls.Add(Me.agrDatoGeneral)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1188, 552)
        '
        'agrDetalle
        '
        Me.agrDetalle.Controls.Add(Me.tcDetalle)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left)
        Me.agrDetalle.Controls.Add(Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right)
        Me.agrDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.agrDetalle.Location = New System.Drawing.Point(0, 139)
        Me.agrDetalle.Name = "agrDetalle"
        Me.agrDetalle.Size = New System.Drawing.Size(1188, 413)
        Me.agrDetalle.TabIndex = 1
        Me.agrDetalle.Text = "Detalles"
        Me.agrDetalle.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'tcDetalle
        '
        Me.tcDetalle.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl3)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl6)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl9)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl10)
        Me.tcDetalle.Controls.Add(Me.UltraTabPageControl11)
        Me.tcDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDetalle.Location = New System.Drawing.Point(3, 42)
        Me.tcDetalle.Name = "tcDetalle"
        Me.tcDetalle.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tcDetalle.Size = New System.Drawing.Size(1182, 368)
        Me.tcDetalle.TabIndex = 0
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Equipos"
        UltraTab5.TabPage = Me.UltraTabPageControl6
        UltraTab5.Text = "Materiales"
        UltraTab9.TabPage = Me.UltraTabPageControl9
        UltraTab9.Text = "Servicios"
        UltraTab10.TabPage = Me.UltraTabPageControl10
        UltraTab10.Text = "Operarios"
        UltraTab11.TabPage = Me.UltraTabPageControl11
        UltraTab11.Text = "Actividades"
        Me.tcDetalle.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab5, UltraTab9, UltraTab10, UltraTab11})
        Me.tcDetalle.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1180, 345)
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_1_Top
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.Location = New System.Drawing.Point(3, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.Name = "_frm_MenuPadre_Toolbars_Dock_Area_1_Top"
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.Size = New System.Drawing.Size(1182, 26)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Top.ToolbarsManager = Me.mnDetalle
        '
        'mnDetalle
        '
        Appearance163.ForeColor = System.Drawing.Color.Black
        Me.mnDetalle.Appearance = Appearance163
        Me.mnDetalle.DesignerFlags = 1
        Me.mnDetalle.DockWithinContainer = Me
        Me.mnDetalle.DockWithinContainerBaseType = GetType(ISL.Win.frm_MenuPadre)
        Me.mnDetalle.MdiMergeable = False
        Me.mnDetalle.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2007
        UltraToolbar1.DockedColumn = 0
        UltraToolbar1.DockedRow = 0
        UltraToolbar1.IsMainMenuBar = True
        UltraToolbar1.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool8, ButtonTool20})
        UltraToolbar1.Text = "utDetalle"
        Me.mnDetalle.Toolbars.AddRange(New Infragistics.Win.UltraWinToolbars.UltraToolbar() {UltraToolbar1})
        Appearance164.Image = Global.ISL.Win.My.Resources.Resources.Consultar
        ButtonTool21.SharedPropsInternal.AppearancesSmall.Appearance = Appearance164
        ButtonTool21.SharedPropsInternal.Caption = "Consultar"
        ButtonTool21.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance165.Image = CType(resources.GetObject("Appearance165.Image"), Object)
        ButtonTool22.SharedPropsInternal.AppearancesSmall.Appearance = Appearance165
        ButtonTool22.SharedPropsInternal.Caption = "Agregar"
        ButtonTool22.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance166.Image = Global.ISL.Win.My.Resources.Resources.Grabar
        ButtonTool23.SharedPropsInternal.AppearancesSmall.Appearance = Appearance166
        ButtonTool23.SharedPropsInternal.Caption = "Guardar"
        ButtonTool23.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance167.Image = CType(resources.GetObject("Appearance167.Image"), Object)
        ButtonTool24.SharedPropsInternal.AppearancesSmall.Appearance = Appearance167
        ButtonTool24.SharedPropsInternal.Caption = "Quitar"
        ButtonTool24.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Me.mnDetalle.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool21, ButtonTool22, ButtonTool23, ButtonTool24})
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_1_Bottom
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.Location = New System.Drawing.Point(3, 410)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.Name = "_frm_MenuPadre_Toolbars_Dock_Area_1_Bottom"
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.Size = New System.Drawing.Size(1182, 0)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Bottom.ToolbarsManager = Me.mnDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_1_Left
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.Location = New System.Drawing.Point(3, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.Name = "_frm_MenuPadre_Toolbars_Dock_Area_1_Left"
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.Size = New System.Drawing.Size(0, 394)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Left.ToolbarsManager = Me.mnDetalle
        '
        '_frm_MenuPadre_Toolbars_Dock_Area_1_Right
        '
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.ForeColor = System.Drawing.Color.Black
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.Location = New System.Drawing.Point(1185, 16)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.Name = "_frm_MenuPadre_Toolbars_Dock_Area_1_Right"
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.Size = New System.Drawing.Size(0, 394)
        Me._frm_MenuPadre_Toolbars_Dock_Area_1_Right.ToolbarsManager = Me.mnDetalle
        '
        'agrDatoGeneral
        '
        Me.agrDatoGeneral.Controls.Add(Me.verInterna)
        Me.agrDatoGeneral.Controls.Add(Me.txtPatron)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta13)
        Me.agrDatoGeneral.Controls.Add(Me.neOrdenSecuencia)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta10)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta3)
        Me.agrDatoGeneral.Controls.Add(Me.verActivo)
        Me.agrDatoGeneral.Controls.Add(Me.cmbUnidadMedida)
        Me.agrDatoGeneral.Controls.Add(Me.txtNombre)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta2)
        Me.agrDatoGeneral.Controls.Add(Me.ndCantidad)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta6)
        Me.agrDatoGeneral.Controls.Add(Me.cmbTipoMantenimiento)
        Me.agrDatoGeneral.Controls.Add(Me.Etiqueta1)
        Me.agrDatoGeneral.Controls.Add(Me.txtCodigo)
        Me.agrDatoGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.agrDatoGeneral.Location = New System.Drawing.Point(0, 0)
        Me.agrDatoGeneral.Name = "agrDatoGeneral"
        Me.agrDatoGeneral.Size = New System.Drawing.Size(1188, 139)
        Me.agrDatoGeneral.TabIndex = 0
        Me.agrDatoGeneral.Text = "Datos Generales"
        Me.agrDatoGeneral.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'verInterna
        '
        Me.verInterna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance168.BackColor = System.Drawing.Color.Transparent
        Me.verInterna.Appearance = Appearance168
        Me.verInterna.AutoSize = True
        Me.verInterna.BackColor = System.Drawing.Color.Transparent
        Me.verInterna.BackColorInternal = System.Drawing.Color.Transparent
        Me.verInterna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verInterna.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verInterna.Location = New System.Drawing.Point(346, 56)
        Me.verInterna.Name = "verInterna"
        Me.verInterna.Size = New System.Drawing.Size(59, 17)
        Me.verInterna.TabIndex = 4
        Me.verInterna.Text = "Externa"
        '
        'txtPatron
        '
        Appearance169.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPatron.Appearance = Appearance169
        Me.txtPatron.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPatron.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtPatron.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatron.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPatron.Location = New System.Drawing.Point(503, 82)
        Me.txtPatron.MaxLength = 200
        Me.txtPatron.Name = "txtPatron"
        Me.txtPatron.Size = New System.Drawing.Size(237, 21)
        Me.txtPatron.TabIndex = 8
        '
        'Etiqueta13
        '
        Appearance170.BackColor = System.Drawing.Color.Transparent
        Appearance170.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance170
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta13.Location = New System.Drawing.Point(461, 86)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta13.TabIndex = 7
        Me.Etiqueta13.Text = "Patron"
        '
        'neOrdenSecuencia
        '
        Me.neOrdenSecuencia.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2000
        Me.neOrdenSecuencia.Location = New System.Drawing.Point(459, 109)
        Me.neOrdenSecuencia.Name = "neOrdenSecuencia"
        Me.neOrdenSecuencia.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.neOrdenSecuencia.Size = New System.Drawing.Size(64, 21)
        Me.neOrdenSecuencia.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.neOrdenSecuencia.SpinIncrement = 1
        Me.neOrdenSecuencia.TabIndex = 13
        '
        'Etiqueta10
        '
        Appearance171.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta10.Appearance = Appearance171
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(346, 113)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(107, 14)
        Me.Etiqueta10.TabIndex = 12
        Me.Etiqueta10.Text = "N° Orden Secuencia:"
        '
        'Etiqueta3
        '
        Appearance172.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta3.Appearance = Appearance172
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(87, 113)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(33, 14)
        Me.Etiqueta3.TabIndex = 9
        Me.Etiqueta3.Text = "Cada:"
        '
        'verActivo
        '
        Me.verActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.verActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.verActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.verActivo.Location = New System.Drawing.Point(1127, 108)
        Me.verActivo.Name = "verActivo"
        Me.verActivo.Size = New System.Drawing.Size(55, 20)
        Me.verActivo.TabIndex = 14
        Me.verActivo.Text = "Activo"
        Me.verActivo.Visible = False
        '
        'cmbUnidadMedida
        '
        Appearance173.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbUnidadMedida.Appearance = Appearance173
        Me.cmbUnidadMedida.DisplayMember = "Nombre"
        Me.cmbUnidadMedida.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnidadMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbUnidadMedida.Location = New System.Drawing.Point(232, 109)
        Me.cmbUnidadMedida.Name = "cmbUnidadMedida"
        Me.cmbUnidadMedida.Size = New System.Drawing.Size(108, 21)
        Me.cmbUnidadMedida.TabIndex = 11
        Me.cmbUnidadMedida.ValueMember = "Id"
        '
        'txtNombre
        '
        Appearance174.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Appearance = Appearance174
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtNombre.Location = New System.Drawing.Point(126, 82)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(329, 21)
        Me.txtNombre.TabIndex = 6
        '
        'Etiqueta2
        '
        Appearance175.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta2.Appearance = Appearance175
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(74, 86)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(46, 14)
        Me.Etiqueta2.TabIndex = 5
        Me.Etiqueta2.Text = "Nombre:"
        '
        'ndCantidad
        '
        Appearance176.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndCantidad.Appearance = Appearance176
        Me.ndCantidad.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.ndCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ndCantidad.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ndCantidad.Location = New System.Drawing.Point(126, 109)
        Me.ndCantidad.Name = "ndCantidad"
        Me.ndCantidad.NullText = "0.00"
        Me.ndCantidad.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.ndCantidad.Size = New System.Drawing.Size(100, 21)
        Me.ndCantidad.TabIndex = 10
        '
        'Etiqueta6
        '
        Appearance177.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta6.Appearance = Appearance177
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta6.Location = New System.Drawing.Point(16, 57)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(104, 14)
        Me.Etiqueta6.TabIndex = 2
        Me.Etiqueta6.Text = "Tipo Mantenimiento:"
        '
        'cmbTipoMantenimiento
        '
        Appearance178.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoMantenimiento.Appearance = Appearance178
        Me.cmbTipoMantenimiento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cmbTipoMantenimiento.DisplayMember = "Nombre"
        Me.cmbTipoMantenimiento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cmbTipoMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoMantenimiento.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbTipoMantenimiento.Location = New System.Drawing.Point(126, 55)
        Me.cmbTipoMantenimiento.Name = "cmbTipoMantenimiento"
        Me.cmbTipoMantenimiento.Size = New System.Drawing.Size(213, 21)
        Me.cmbTipoMantenimiento.TabIndex = 3
        Me.cmbTipoMantenimiento.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance179.BackColor = System.Drawing.Color.Transparent
        Me.Etiqueta1.Appearance = Appearance179
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(78, 32)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(42, 14)
        Me.Etiqueta1.TabIndex = 0
        Me.Etiqueta1.Text = "Codigo:"
        '
        'txtCodigo
        '
        Appearance180.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Appearance = Appearance180
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtCodigo.Location = New System.Drawing.Point(126, 28)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(84, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'tcMantenimiento
        '
        Me.tcMantenimiento.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.tcMantenimiento.Controls.Add(Me.UltraTabPageControl1)
        Me.tcMantenimiento.Controls.Add(Me.UltraTabPageControl2)
        Me.tcMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcMantenimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcMantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.tcMantenimiento.Name = "tcMantenimiento"
        Me.tcMantenimiento.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.tcMantenimiento.Size = New System.Drawing.Size(1190, 575)
        Me.tcMantenimiento.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.tcMantenimiento.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.tcMantenimiento.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1188, 552)
        '
        'UltraTabSharedControlsPage5
        '
        Me.UltraTabSharedControlsPage5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage5.Name = "UltraTabSharedControlsPage5"
        Me.UltraTabSharedControlsPage5.Size = New System.Drawing.Size(1025, 320)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.BackColor = System.Drawing.Color.Transparent
        Me.ugb_Espera.ForeColor = System.Drawing.Color.Navy
        Me.ugb_Espera.Location = New System.Drawing.Point(397, 253)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(397, 68)
        Me.ugb_Espera.TabIndex = 5
        Me.ugb_Espera.Visible = False
        '
        'frm_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 575)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.tcMantenimiento)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Mantenimiento"
        Me.Text = "Mantenimiento"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.grid_MantenimientoEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcDetalle.ResumeLayout(False)
        CType(Me.odMantenimientoEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeEquipos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel1.ResumeLayout(False)
        CType(Me.grid_Equipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.cmbModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl6.ResumeLayout(False)
        CType(Me.grid_MantenimientoMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMantenimientoMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeMateriales.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel2.ResumeLayout(False)
        CType(Me.grid_Materiales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.cmbSubFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl9.ResumeLayout(False)
        CType(Me.grid_MantenimientoServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMantenimientoServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeServicios.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel3.ResumeLayout(False)
        CType(Me.grid_Servicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        Me.Agrupacion2.PerformLayout()
        CType(Me.cmbCategoriaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl10.ResumeLayout(False)
        CType(Me.grid_MantenimientoOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMantenimientoOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeRecursos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel4.ResumeLayout(False)
        CType(Me.grid_Operarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl11.ResumeLayout(False)
        CType(Me.grid_MantenimientoActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odMantenimientoActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gbeActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbeActividades.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel5.ResumeLayout(False)
        CType(Me.grid_Actividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.grid_Mantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mcMantenimiento.ResumeLayout(False)
        CType(Me.odMantenimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uegbEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uegbEquipos.ResumeLayout(False)
        Me.UltraExpandableGroupBoxPanel6.ResumeLayout(False)
        CType(Me.grid_EquipoAsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odEquipoAsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        Me.Agrupacion4.PerformLayout()
        CType(Me.cmbModeloAsig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMarcaAsig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.agrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDetalle.ResumeLayout(False)
        CType(Me.tcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcDetalle.ResumeLayout(False)
        CType(Me.mnDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrDatoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrDatoGeneral.ResumeLayout(False)
        Me.agrDatoGeneral.PerformLayout()
        CType(Me.verInterna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatron, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.neOrdenSecuencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.verActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnidadMedida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ndCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcMantenimiento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcMantenimiento As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents odMantenimientos As ISL.Controles.OrigenDatos
    Friend WithEvents agrDatoGeneral As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents verActivo As ISL.Controles.Chequear
    Friend WithEvents cmbUnidadMedida As ISL.Controles.ComboMaestros
    Friend WithEvents txtNombre As ISL.Controles.Texto
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents ndCantidad As ISL.Controles.NumeroDecimal
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents cmbTipoMantenimiento As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents txtCodigo As ISL.Controles.Texto
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents UltraTabSharedControlsPage5 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents agrDetalle As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents odMantenimientoEquipos As ISL.Controles.OrigenDatos
    Friend WithEvents odEquipo As ISL.Controles.OrigenDatos
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents odServicios As ISL.Controles.OrigenDatos
    Friend WithEvents odMantenimientoServicios As ISL.Controles.OrigenDatos
    Friend WithEvents odMateriales As ISL.Controles.OrigenDatos
    Friend WithEvents odMantenimientoMateriales As ISL.Controles.OrigenDatos
    Friend WithEvents odOperarios As ISL.Controles.OrigenDatos
    Friend WithEvents odMantenimientoOperarios As ISL.Controles.OrigenDatos
    Friend WithEvents mcDetalle As ISL.Controles.MenuContextual
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mcMantenimiento As ISL.Controles.MenuContextual
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odActividades As ISL.Controles.OrigenDatos
    Friend WithEvents odMantenimientoActividades As ISL.Controles.OrigenDatos
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tcDetalle As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl6 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl9 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl10 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl11 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_1_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents mnDetalle As ISL.Controles.Menu
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_1_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_1_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _frm_MenuPadre_Toolbars_Dock_Area_1_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents gbeEquipos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel1 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Equipos As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarEquipos As ISL.Controles.Boton
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents cmbModelo As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents cmbMarca As ISL.Controles.ComboMaestros
    Friend WithEvents grid_MantenimientoEquipo As ISL.Controles.Grilla
    Friend WithEvents grid_MantenimientoMateriales As ISL.Controles.Grilla
    Friend WithEvents gbeMateriales As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel2 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Materiales As ISL.Controles.Grilla
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents cmbSubFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta9 As ISL.Controles.Etiqueta
    Friend WithEvents btnListarMaterial As ISL.Controles.Boton
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cmbFamilia As ISL.Controles.ComboMaestros
    Friend WithEvents grid_MantenimientoServicios As ISL.Controles.Grilla
    Friend WithEvents gbeServicios As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel3 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Servicios As ISL.Controles.Grilla
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents btnCategoria As ISL.Controles.Boton
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents cmbCategoriaServicios As ISL.Controles.ComboMaestros
    Friend WithEvents grid_MantenimientoOperarios As ISL.Controles.Grilla
    Friend WithEvents gbeRecursos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel4 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Operarios As ISL.Controles.Grilla
    Friend WithEvents grid_MantenimientoActividades As ISL.Controles.Grilla
    Friend WithEvents gbeActividades As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel5 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Actividades As ISL.Controles.Grilla
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents neOrdenSecuencia As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uegbEquipos As Infragistics.Win.Misc.UltraExpandableGroupBox
    Friend WithEvents UltraExpandableGroupBoxPanel6 As Infragistics.Win.Misc.UltraExpandableGroupBoxPanel
    Friend WithEvents grid_Mantenimientos As ISL.Controles.Grilla
    Friend WithEvents grid_EquipoAsig As ISL.Controles.Grilla
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents btnListarAsig As ISL.Controles.Boton
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents cmbModeloAsig As ISL.Controles.ComboMaestros
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents cmbMarcaAsig As ISL.Controles.ComboMaestros
    Friend WithEvents btnAsignar As ISL.Controles.Boton
    Friend WithEvents odEquipoAsig As ISL.Controles.OrigenDatos
    Friend WithEvents txtPatron As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents verInterna As ISL.Controles.Chequear
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Friend WithEvents ugb_Espera As ISL.Win.Espere
End Class
