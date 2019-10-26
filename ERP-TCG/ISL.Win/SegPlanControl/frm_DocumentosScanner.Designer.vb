<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentosScanner
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn52 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn59 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn60 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn61 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn62 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocumento")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ModeloFuncional")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn8 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn9 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn10 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn11 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn12 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RutaImagen")
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencimiento")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVigente")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaModificacion")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioModificacion")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVigencia")
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
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn106 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn107 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn108 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn109 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn110 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn111 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn112 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn113 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn114 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn115 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn116 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn117 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn118 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn119 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn120 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn121 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn122 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn123 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn124 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn125 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn126 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn127 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn128 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn129 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn130 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
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
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn131 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn132 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn133 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn134 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn135 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn136 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn137 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn138 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn139 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn140 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn143 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn144 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn145 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn146 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn147 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn148 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
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
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Id")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NroDocumento")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdVehiculo")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Placa")
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ModeloFuncional", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTipoDocumento")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoDocumento")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Descripcion")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activo")
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCreacion")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioCreacion")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("RutaImagen")
        Dim UltraGridColumn37 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdTrabajador")
        Dim UltraGridColumn38 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVencimiento")
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn39 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Vencimiento")
        Dim UltraGridColumn40 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IndVigente")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaModificacion")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsuarioModificacion")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaVigencia")
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Nombre")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Imagen")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Id")
        Dim UltraDataColumn25 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVencimiento")
        Dim UltraDataColumn26 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("NroDocumento")
        Dim UltraDataColumn27 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Descripcion")
        Dim UltraDataColumn28 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("RutaImagen")
        Dim UltraDataColumn29 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoDocumento")
        Dim UltraDataColumn30 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCreacion")
        Dim UltraDataColumn31 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdVehiculo")
        Dim UltraDataColumn32 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTrabajador")
        Dim UltraDataColumn33 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoOperacion")
        Dim UltraDataColumn34 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Vencimiento")
        Dim UltraDataColumn35 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("TipoDocumento")
        Dim UltraDataColumn36 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Placa")
        Dim UltraDataColumn37 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdTipoVehiculo")
        Dim UltraDataColumn38 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IndVigente")
        Dim UltraDataColumn39 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Activo")
        Dim UltraDataColumn40 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn41 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaVigencia")
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion4 = New ISL.Controles.Agrupacion(Me.components)
        Me.upbDocVeh = New System.Windows.Forms.PictureBox()
        Me.Agrupacion3 = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta24 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecFechaVigencia = New System.Windows.Forms.DateTimePicker()
        Me.griImagenesInd = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.odImgDocVeh = New ISL.Controles.OrigenDatos(Me.components)
        Me.Filtro1 = New ISL.Controles.Filtro(Me.components)
        Me.chkMotrizInd = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtModeloInd = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta20 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMarcaINd = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta21 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoVehInd = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta22 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtModeloFuncInd = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta23 = New ISL.Controles.Etiqueta(Me.components)
        Me.rbVehiculo = New System.Windows.Forms.RadioButton()
        Me.cboTrabajador = New ISL.Controles.Combo(Me.components)
        Me.cboVehiculo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta1 = New ISL.Controles.Etiqueta(Me.components)
        Me.etiTrabajador = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumento = New ISL.Controles.Texto(Me.components)
        Me.rbTrabajador = New System.Windows.Forms.RadioButton()
        Me.cboTipoDocumento = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta4 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta8 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta2 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta3 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnExaminar = New ISL.Controles.Boton(Me.components)
        Me.fecFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion6 = New ISL.Controles.Agrupacion(Me.components)
        Me.griVehiculos = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion5 = New ISL.Controles.Agrupacion(Me.components)
        Me.dtpVigencia = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta14 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta25 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnImportar = New ISL.Controles.Boton(Me.components)
        Me.btnImagenMasivo = New ISL.Controles.Boton(Me.components)
        Me.chkMotrizMasivo = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtModelo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta19 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMarca = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta18 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoVehMasivo = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta17 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtModeloFuncional = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta13 = New ISL.Controles.Etiqueta(Me.components)
        Me.chkVigente = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.btnVerGrande = New Infragistics.Win.Misc.UltraButton()
        Me.griImagenes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnAgregarMasivo = New Infragistics.Win.Misc.UltraButton()
        Me.upbImagenMasivo = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.Etiqueta10 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboVehiculoMasivo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta11 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtVencimientoMasivo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Etiqueta12 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumentoMasivo = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocMasivo = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta15 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta16 = New ISL.Controles.Etiqueta(Me.components)
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcionMasivo = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion8 = New ISL.Controles.Agrupacion(Me.components)
        Me.gridDocumentoVehiculoIgual = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Agrupacion9 = New ISL.Controles.Agrupacion(Me.components)
        Me.fecVigenciaIgual = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta26 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta27 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnImportarIgual = New ISL.Controles.Boton(Me.components)
        Me.btnImagenIgual = New ISL.Controles.Boton(Me.components)
        Me.chkMotrizIgual = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.txtModeloIgual = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta28 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtMarcaIgual = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta29 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtTipoVehiculoIgual = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta30 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtModeloFuncionalIgual = New ISL.Controles.Texto(Me.components)
        Me.Etiqueta31 = New ISL.Controles.Etiqueta(Me.components)
        Me.btnMostrarIgual = New Infragistics.Win.Misc.UltraButton()
        Me.gridImagenesIgual = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.btnAgregarIgual = New Infragistics.Win.Misc.UltraButton()
        Me.pixImagenIgual = New Infragistics.Win.UltraWinEditors.UltraPictureBox()
        Me.cboVehiculoIgual = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta33 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta34 = New ISL.Controles.Etiqueta(Me.components)
        Me.txtNroDocumentoIgual = New ISL.Controles.Texto(Me.components)
        Me.cboTipoDocumentoIgual = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta35 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta36 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecVencimientoIgual = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcionIgual = New ISL.Controles.Texto(Me.components)
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Agrupacion2 = New ISL.Controles.Agrupacion(Me.components)
        Me.griLista = New ISL.Controles.Grilla(Me.components)
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuVigencia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDescargarImg = New System.Windows.Forms.ToolStripMenuItem()
        Me.Agrupacion1 = New ISL.Controles.Agrupacion(Me.components)
        Me.rdbDatosAdicionales = New System.Windows.Forms.RadioButton()
        Me.Agrupacion7 = New ISL.Controles.Agrupacion(Me.components)
        Me.btnSincronizar = New ISL.Controles.Boton(Me.components)
        Me.Vigente = New ISL.Controles.Etiqueta(Me.components)
        Me.cboIndicadorListar = New ISL.Controles.Combo(Me.components)
        Me.Etiqueta32 = New ISL.Controles.Etiqueta(Me.components)
        Me.Etiqueta7 = New ISL.Controles.Etiqueta(Me.components)
        Me.cboVehiListar = New ISL.Controles.Combo(Me.components)
        Me.etiGenerada = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresVencido = New ISL.Controles.Colores(Me.components)
        Me.cboTipoDocLista = New ISL.Controles.Combo(Me.components)
        Me.etiTerminada = New ISL.Controles.Etiqueta(Me.components)
        Me.etiEnProceso = New ISL.Controles.Etiqueta(Me.components)
        Me.ColoresPorVencer = New ISL.Controles.Colores(Me.components)
        Me.ColoresGenerado = New ISL.Controles.Colores(Me.components)
        Me.agrFechas = New ISL.Controles.Agrupacion(Me.components)
        Me.Etiqueta5 = New ISL.Controles.Etiqueta(Me.components)
        Me.fecDesde = New System.Windows.Forms.DateTimePicker()
        Me.fecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Etiqueta6 = New ISL.Controles.Etiqueta(Me.components)
        Me.rdbFechas = New System.Windows.Forms.RadioButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.tabControl = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage2 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ogdCliente = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.odImagen = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.UltraPrintPreviewDialog1 = New Infragistics.Win.Printing.UltraPrintPreviewDialog(Me.components)
        Me.odVehiculos = New ISL.Controles.OrigenDatos(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ficImgDocVeh = New ISL.Controles.Ficha(Me.components)
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.ugb_Espera = New ISL.Win.Espere()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion4.SuspendLayout()
        CType(Me.upbDocVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion3.SuspendLayout()
        CType(Me.griImagenesInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odImgDocVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMotrizInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeloInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcaINd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoVehInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeloFuncInd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion6.SuspendLayout()
        CType(Me.griVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion5.SuspendLayout()
        CType(Me.chkMotrizMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoVehMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeloFuncional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVigente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculoMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVencimientoMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumentoMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionMasivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion8.SuspendLayout()
        CType(Me.gridDocumentoVehiculoIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion9.SuspendLayout()
        CType(Me.chkMotrizIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeloIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarcaIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoVehiculoIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeloFuncionalIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridImagenesIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiculoIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNroDocumentoIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocumentoIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionIgual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion2.SuspendLayout()
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu1.SuspendLayout()
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion1.SuspendLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Agrupacion7.SuspendLayout()
        CType(Me.cboIndicadorListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboVehiListar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresVencido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoDocLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresPorVencer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.agrFechas.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControl.SuspendLayout()
        CType(Me.ogdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.odVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ficImgDocVeh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ficImgDocVeh.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion4)
        Me.UltraTabPageControl3.Controls.Add(Me.Agrupacion3)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(1037, 584)
        '
        'Agrupacion4
        '
        Appearance1.BackColor = System.Drawing.Color.White
        Appearance1.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion4.ContentAreaAppearance = Appearance1
        Me.Agrupacion4.Controls.Add(Me.upbDocVeh)
        Me.Agrupacion4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion4.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion4.Location = New System.Drawing.Point(445, 0)
        Me.Agrupacion4.Name = "Agrupacion4"
        Me.Agrupacion4.Size = New System.Drawing.Size(592, 584)
        Me.Agrupacion4.TabIndex = 5
        Me.Agrupacion4.Text = "Imagen"
        Me.Agrupacion4.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'upbDocVeh
        '
        Me.upbDocVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upbDocVeh.Dock = System.Windows.Forms.DockStyle.Left
        Me.upbDocVeh.Location = New System.Drawing.Point(3, 16)
        Me.upbDocVeh.Name = "upbDocVeh"
        Me.upbDocVeh.Size = New System.Drawing.Size(415, 565)
        Me.upbDocVeh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.upbDocVeh.TabIndex = 4
        Me.upbDocVeh.TabStop = False
        '
        'Agrupacion3
        '
        Appearance2.BackColor = System.Drawing.Color.White
        Appearance2.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion3.ContentAreaAppearance = Appearance2
        Me.Agrupacion3.Controls.Add(Me.Etiqueta24)
        Me.Agrupacion3.Controls.Add(Me.fecFechaVigencia)
        Me.Agrupacion3.Controls.Add(Me.griImagenesInd)
        Me.Agrupacion3.Controls.Add(Me.chkMotrizInd)
        Me.Agrupacion3.Controls.Add(Me.txtModeloInd)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta20)
        Me.Agrupacion3.Controls.Add(Me.txtMarcaINd)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta21)
        Me.Agrupacion3.Controls.Add(Me.txtTipoVehInd)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta22)
        Me.Agrupacion3.Controls.Add(Me.txtModeloFuncInd)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta23)
        Me.Agrupacion3.Controls.Add(Me.rbVehiculo)
        Me.Agrupacion3.Controls.Add(Me.cboTrabajador)
        Me.Agrupacion3.Controls.Add(Me.cboVehiculo)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta1)
        Me.Agrupacion3.Controls.Add(Me.etiTrabajador)
        Me.Agrupacion3.Controls.Add(Me.txtNroDocumento)
        Me.Agrupacion3.Controls.Add(Me.rbTrabajador)
        Me.Agrupacion3.Controls.Add(Me.cboTipoDocumento)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta4)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta8)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta2)
        Me.Agrupacion3.Controls.Add(Me.Etiqueta3)
        Me.Agrupacion3.Controls.Add(Me.btnExaminar)
        Me.Agrupacion3.Controls.Add(Me.fecFechaVencimiento)
        Me.Agrupacion3.Controls.Add(Me.txtDescripcion)
        Me.Agrupacion3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion3.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion3.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion3.Name = "Agrupacion3"
        Me.Agrupacion3.Size = New System.Drawing.Size(445, 584)
        Me.Agrupacion3.TabIndex = 3
        Me.Agrupacion3.Text = "Datos"
        Me.Agrupacion3.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta24
        '
        Appearance3.BackColor = System.Drawing.Color.Transparent
        Appearance3.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta24.Appearance = Appearance3
        Me.Etiqueta24.AutoSize = True
        Me.Etiqueta24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta24.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta24.Location = New System.Drawing.Point(233, 46)
        Me.Etiqueta24.Name = "Etiqueta24"
        Me.Etiqueta24.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta24.TabIndex = 405
        Me.Etiqueta24.Text = "F. Vigencia:"
        '
        'fecFechaVigencia
        '
        Me.fecFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaVigencia.Location = New System.Drawing.Point(298, 44)
        Me.fecFechaVigencia.Name = "fecFechaVigencia"
        Me.fecFechaVigencia.Size = New System.Drawing.Size(98, 20)
        Me.fecFechaVigencia.TabIndex = 3
        '
        'griImagenesInd
        '
        Me.griImagenesInd.DataSource = Me.odImgDocVeh
        UltraGridColumn9.Header.VisiblePosition = 0
        UltraGridColumn9.Hidden = True
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 2
        UltraGridColumn11.Hidden = True
        UltraGridColumn20.Header.VisiblePosition = 3
        UltraGridColumn20.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 18
        UltraGridColumn21.Header.VisiblePosition = 4
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 5
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 6
        UltraGridColumn23.Hidden = True
        UltraGridColumn24.Header.VisiblePosition = 7
        UltraGridColumn24.Hidden = True
        UltraGridColumn25.Header.VisiblePosition = 8
        UltraGridColumn25.Hidden = True
        UltraGridColumn25.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn26.Header.VisiblePosition = 9
        UltraGridColumn26.Hidden = True
        UltraGridColumn52.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn52.Header.Caption = "Ruta Imagen"
        UltraGridColumn52.Header.VisiblePosition = 10
        UltraGridColumn52.Width = 388
        UltraGridColumn59.Header.VisiblePosition = 11
        UltraGridColumn59.Hidden = True
        UltraGridColumn60.Header.VisiblePosition = 12
        UltraGridColumn60.Hidden = True
        UltraGridColumn60.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn61.Header.VisiblePosition = 13
        UltraGridColumn61.Hidden = True
        UltraGridColumn62.Header.VisiblePosition = 14
        UltraGridColumn62.Hidden = True
        UltraGridColumn13.Header.VisiblePosition = 15
        UltraGridColumn13.Hidden = True
        UltraGridColumn13.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn18.Header.VisiblePosition = 16
        UltraGridColumn18.Hidden = True
        UltraGridColumn19.Header.VisiblePosition = 17
        UltraGridColumn19.Hidden = True
        UltraGridColumn19.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn20, UltraGridColumn29, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn52, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn13, UltraGridColumn18, UltraGridColumn19})
        Me.griImagenesInd.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.griImagenesInd.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griImagenesInd.Location = New System.Drawing.Point(16, 242)
        Me.griImagenesInd.Name = "griImagenesInd"
        Me.griImagenesInd.Size = New System.Drawing.Size(412, 185)
        Me.griImagenesInd.TabIndex = 13
        Me.griImagenesInd.Text = "Lista Imagenes"
        '
        'odImgDocVeh
        '
        UltraDataColumn10.DataType = GetType(Date)
        UltraDataColumn14.DataType = GetType(Date)
        UltraDataColumn15.DataType = GetType(Short)
        UltraDataColumn16.DataType = GetType(Boolean)
        UltraDataColumn17.DataType = GetType(Date)
        UltraDataColumn19.DataType = GetType(Date)
        Me.odImgDocVeh.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19})
        '
        'Filtro1
        '
        Me.Filtro1.MenuSettings.RightAlignedMenus = True
        Me.Filtro1.ViewStyle = Infragistics.Win.SupportDialogs.FilterUIProvider.FilterUIProviderViewStyle.Office2003
        '
        'chkMotrizInd
        '
        Appearance4.ForeColor = System.Drawing.Color.Navy
        Me.chkMotrizInd.Appearance = Appearance4
        Me.chkMotrizInd.AutoSize = True
        Me.chkMotrizInd.BackColor = System.Drawing.Color.Transparent
        Me.chkMotrizInd.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkMotrizInd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Appearance5.TextHAlignAsString = "Right"
        Me.chkMotrizInd.CheckedAppearance = Appearance5
        Me.chkMotrizInd.Enabled = False
        Me.chkMotrizInd.Location = New System.Drawing.Point(260, 70)
        Me.chkMotrizInd.Name = "chkMotrizInd"
        Me.chkMotrizInd.Size = New System.Drawing.Size(52, 17)
        Me.chkMotrizInd.TabIndex = 5
        Me.chkMotrizInd.Text = "Motriz"
        '
        'txtModeloInd
        '
        Me.txtModeloInd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModeloInd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModeloInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloInd.Location = New System.Drawing.Point(298, 95)
        Me.txtModeloInd.Name = "txtModeloInd"
        Me.txtModeloInd.ReadOnly = True
        Me.txtModeloInd.Size = New System.Drawing.Size(120, 21)
        Me.txtModeloInd.TabIndex = 7
        '
        'Etiqueta20
        '
        Appearance6.BackColor = System.Drawing.Color.Transparent
        Appearance6.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta20.Appearance = Appearance6
        Me.Etiqueta20.AutoSize = True
        Me.Etiqueta20.Enabled = False
        Me.Etiqueta20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta20.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta20.Location = New System.Drawing.Point(256, 97)
        Me.Etiqueta20.Name = "Etiqueta20"
        Me.Etiqueta20.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta20.TabIndex = 400
        Me.Etiqueta20.Text = "Modelo"
        '
        'txtMarcaINd
        '
        Me.txtMarcaINd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaINd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarcaINd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaINd.Location = New System.Drawing.Point(298, 120)
        Me.txtMarcaINd.Name = "txtMarcaINd"
        Me.txtMarcaINd.ReadOnly = True
        Me.txtMarcaINd.Size = New System.Drawing.Size(121, 21)
        Me.txtMarcaINd.TabIndex = 9
        '
        'Etiqueta21
        '
        Appearance7.BackColor = System.Drawing.Color.Transparent
        Appearance7.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta21.Appearance = Appearance7
        Me.Etiqueta21.AutoSize = True
        Me.Etiqueta21.Enabled = False
        Me.Etiqueta21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta21.Location = New System.Drawing.Point(257, 123)
        Me.Etiqueta21.Name = "Etiqueta21"
        Me.Etiqueta21.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta21.TabIndex = 398
        Me.Etiqueta21.Text = "Marca"
        '
        'txtTipoVehInd
        '
        Me.txtTipoVehInd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoVehInd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoVehInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehInd.Location = New System.Drawing.Point(95, 120)
        Me.txtTipoVehInd.Name = "txtTipoVehInd"
        Me.txtTipoVehInd.ReadOnly = True
        Me.txtTipoVehInd.Size = New System.Drawing.Size(137, 21)
        Me.txtTipoVehInd.TabIndex = 8
        '
        'Etiqueta22
        '
        Appearance8.BackColor = System.Drawing.Color.Transparent
        Appearance8.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta22.Appearance = Appearance8
        Me.Etiqueta22.AutoSize = True
        Me.Etiqueta22.Enabled = False
        Me.Etiqueta22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta22.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta22.Location = New System.Drawing.Point(22, 124)
        Me.Etiqueta22.Name = "Etiqueta22"
        Me.Etiqueta22.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta22.TabIndex = 396
        Me.Etiqueta22.Text = "Tipo Vehiculo"
        '
        'txtModeloFuncInd
        '
        Me.txtModeloFuncInd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModeloFuncInd.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModeloFuncInd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloFuncInd.Location = New System.Drawing.Point(95, 95)
        Me.txtModeloFuncInd.Name = "txtModeloFuncInd"
        Me.txtModeloFuncInd.ReadOnly = True
        Me.txtModeloFuncInd.Size = New System.Drawing.Size(137, 21)
        Me.txtModeloFuncInd.TabIndex = 6
        '
        'Etiqueta23
        '
        Appearance9.BackColor = System.Drawing.Color.Transparent
        Appearance9.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta23.Appearance = Appearance9
        Me.Etiqueta23.AutoSize = True
        Me.Etiqueta23.Enabled = False
        Me.Etiqueta23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta23.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta23.Location = New System.Drawing.Point(2, 98)
        Me.Etiqueta23.Name = "Etiqueta23"
        Me.Etiqueta23.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta23.TabIndex = 394
        Me.Etiqueta23.Text = "Modelo Funcional"
        '
        'rbVehiculo
        '
        Me.rbVehiculo.AutoSize = True
        Me.rbVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.rbVehiculo.Checked = True
        Me.rbVehiculo.ForeColor = System.Drawing.Color.Navy
        Me.rbVehiculo.Location = New System.Drawing.Point(8, 507)
        Me.rbVehiculo.Name = "rbVehiculo"
        Me.rbVehiculo.Size = New System.Drawing.Size(66, 17)
        Me.rbVehiculo.TabIndex = 0
        Me.rbVehiculo.TabStop = True
        Me.rbVehiculo.Text = "Vehiculo"
        Me.rbVehiculo.UseVisualStyleBackColor = False
        Me.rbVehiculo.Visible = False
        '
        'cboTrabajador
        '
        Appearance10.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Appearance = Appearance10
        Me.cboTrabajador.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTrabajador.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrabajador.ForeColor = System.Drawing.Color.Black
        Me.cboTrabajador.Location = New System.Drawing.Point(74, 467)
        Me.cboTrabajador.Name = "cboTrabajador"
        Me.cboTrabajador.Size = New System.Drawing.Size(323, 21)
        Me.cboTrabajador.TabIndex = 3
        Me.cboTrabajador.ValueMember = "Id"
        Me.cboTrabajador.Visible = False
        '
        'cboVehiculo
        '
        Appearance11.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Appearance = Appearance11
        Me.cboVehiculo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVehiculo.DisplayMember = ""
        Me.cboVehiculo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculo.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculo.Location = New System.Drawing.Point(95, 69)
        Me.cboVehiculo.Name = "cboVehiculo"
        Me.cboVehiculo.Size = New System.Drawing.Size(137, 21)
        Me.cboVehiculo.TabIndex = 4
        Me.cboVehiculo.ValueMember = "Id"
        '
        'Etiqueta1
        '
        Appearance12.BackColor = System.Drawing.Color.Transparent
        Appearance12.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta1.Appearance = Appearance12
        Me.Etiqueta1.AutoSize = True
        Me.Etiqueta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta1.Location = New System.Drawing.Point(8, 23)
        Me.Etiqueta1.Name = "Etiqueta1"
        Me.Etiqueta1.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta1.TabIndex = 365
        Me.Etiqueta1.Text = "TipoDocumento:"
        '
        'etiTrabajador
        '
        Appearance13.BackColor = System.Drawing.Color.Transparent
        Appearance13.ForeColor = System.Drawing.Color.Navy
        Me.etiTrabajador.Appearance = Appearance13
        Me.etiTrabajador.AutoSize = True
        Me.etiTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTrabajador.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTrabajador.Location = New System.Drawing.Point(44, 73)
        Me.etiTrabajador.Name = "etiTrabajador"
        Me.etiTrabajador.Size = New System.Drawing.Size(49, 14)
        Me.etiTrabajador.TabIndex = 364
        Me.etiTrabajador.Text = "Vehiculo:"
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumento.Location = New System.Drawing.Point(95, 146)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.Size = New System.Drawing.Size(323, 21)
        Me.txtNroDocumento.TabIndex = 10
        '
        'rbTrabajador
        '
        Me.rbTrabajador.AutoSize = True
        Me.rbTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.rbTrabajador.ForeColor = System.Drawing.Color.Navy
        Me.rbTrabajador.Location = New System.Drawing.Point(128, 507)
        Me.rbTrabajador.Name = "rbTrabajador"
        Me.rbTrabajador.Size = New System.Drawing.Size(76, 17)
        Me.rbTrabajador.TabIndex = 1
        Me.rbTrabajador.Text = "Trabajador"
        Me.rbTrabajador.UseVisualStyleBackColor = False
        Me.rbTrabajador.Visible = False
        '
        'cboTipoDocumento
        '
        Appearance14.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Appearance = Appearance14
        Me.cboTipoDocumento.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumento.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumento.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumento.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumento.Location = New System.Drawing.Point(95, 19)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(323, 21)
        Me.cboTipoDocumento.TabIndex = 1
        Me.cboTipoDocumento.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta4
        '
        Appearance15.BackColor = System.Drawing.Color.Transparent
        Appearance15.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta4.Appearance = Appearance15
        Me.Etiqueta4.AutoSize = True
        Me.Etiqueta4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta4.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta4.Location = New System.Drawing.Point(8, 471)
        Me.Etiqueta4.Name = "Etiqueta4"
        Me.Etiqueta4.Size = New System.Drawing.Size(60, 14)
        Me.Etiqueta4.TabIndex = 374
        Me.Etiqueta4.Text = "Trabajador:"
        Me.Etiqueta4.Visible = False
        '
        'Etiqueta8
        '
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta8.Appearance = Appearance16
        Me.Etiqueta8.AutoSize = True
        Me.Etiqueta8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta8.Location = New System.Drawing.Point(13, 47)
        Me.Etiqueta8.Name = "Etiqueta8"
        Me.Etiqueta8.Size = New System.Drawing.Size(80, 14)
        Me.Etiqueta8.TabIndex = 376
        Me.Etiqueta8.Text = "F. Vencimiento:"
        '
        'Etiqueta2
        '
        Appearance17.BackColor = System.Drawing.Color.Transparent
        Appearance17.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta2.Appearance = Appearance17
        Me.Etiqueta2.AutoSize = True
        Me.Etiqueta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta2.Location = New System.Drawing.Point(28, 174)
        Me.Etiqueta2.Name = "Etiqueta2"
        Me.Etiqueta2.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta2.TabIndex = 366
        Me.Etiqueta2.Text = "Descripcion:"
        '
        'Etiqueta3
        '
        Appearance18.BackColor = System.Drawing.Color.Transparent
        Appearance18.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta3.Appearance = Appearance18
        Me.Etiqueta3.AutoSize = True
        Me.Etiqueta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta3.Location = New System.Drawing.Point(12, 150)
        Me.Etiqueta3.Name = "Etiqueta3"
        Me.Etiqueta3.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta3.TabIndex = 371
        Me.Etiqueta3.Text = "NroDocumento:"
        '
        'btnExaminar
        '
        Appearance19.ForeColor = System.Drawing.Color.Navy
        Me.btnExaminar.Appearance = Appearance19
        Me.btnExaminar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.Black
        Me.btnExaminar.Location = New System.Drawing.Point(95, 212)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(81, 22)
        Me.btnExaminar.TabIndex = 12
        Me.btnExaminar.Text = "Imagen"
        '
        'fecFechaVencimiento
        '
        Me.fecFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecFechaVencimiento.Location = New System.Drawing.Point(95, 44)
        Me.fecFechaVencimiento.Name = "fecFechaVencimiento"
        Me.fecFechaVencimiento.Size = New System.Drawing.Size(98, 20)
        Me.fecFechaVencimiento.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(95, 172)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(323, 36)
        Me.txtDescripcion.TabIndex = 11
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion6)
        Me.UltraTabPageControl4.Controls.Add(Me.Agrupacion5)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(1037, 584)
        '
        'Agrupacion6
        '
        Appearance20.BackColor = System.Drawing.Color.White
        Appearance20.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion6.ContentAreaAppearance = Appearance20
        Me.Agrupacion6.Controls.Add(Me.griVehiculos)
        Me.Agrupacion6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion6.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion6.Location = New System.Drawing.Point(445, 0)
        Me.Agrupacion6.Name = "Agrupacion6"
        Me.Agrupacion6.Size = New System.Drawing.Size(592, 584)
        Me.Agrupacion6.TabIndex = 5
        Me.Agrupacion6.Text = "Unidades Vehiculares"
        Me.Agrupacion6.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griVehiculos
        '
        Me.griVehiculos.DataSource = Me.odImgDocVeh
        Appearance21.BackColor = System.Drawing.Color.White
        Appearance21.BackColor2 = System.Drawing.Color.White
        Me.griVehiculos.DisplayLayout.Appearance = Appearance21
        UltraGridColumn95.Header.VisiblePosition = 0
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn96.Header.VisiblePosition = 2
        UltraGridColumn96.Width = 137
        UltraGridColumn97.Header.Caption = "Vehiculo"
        UltraGridColumn97.Header.VisiblePosition = 1
        UltraGridColumn98.Header.VisiblePosition = 10
        UltraGridColumn98.Hidden = True
        UltraGridColumn30.Header.VisiblePosition = 18
        UltraGridColumn99.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn99.Header.Caption = "Tipo Documento"
        UltraGridColumn99.Header.VisiblePosition = 3
        UltraGridColumn99.Width = 335
        UltraGridColumn100.Header.VisiblePosition = 9
        UltraGridColumn100.Hidden = True
        UltraGridColumn101.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn101.Header.VisiblePosition = 16
        UltraGridColumn101.Width = 259
        UltraGridColumn102.Header.VisiblePosition = 12
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.Header.VisiblePosition = 13
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.Header.VisiblePosition = 6
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 4
        UltraGridColumn105.Hidden = True
        UltraGridColumn106.Header.VisiblePosition = 7
        UltraGridColumn106.Hidden = True
        UltraGridColumn107.Header.VisiblePosition = 5
        UltraGridColumn108.Header.VisiblePosition = 8
        UltraGridColumn108.Hidden = True
        UltraGridColumn109.Header.VisiblePosition = 11
        UltraGridColumn109.Hidden = True
        UltraGridColumn110.Header.VisiblePosition = 17
        UltraGridColumn111.Header.VisiblePosition = 14
        UltraGridColumn111.Hidden = True
        UltraGridColumn112.Header.VisiblePosition = 15
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn30, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn106, UltraGridColumn107, UltraGridColumn108, UltraGridColumn109, UltraGridColumn110, UltraGridColumn111, UltraGridColumn112})
        Me.griVehiculos.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Appearance22.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance22.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance22.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance22.BorderColor = System.Drawing.SystemColors.Window
        Me.griVehiculos.DisplayLayout.GroupByBox.Appearance = Appearance22
        Appearance23.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVehiculos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance23
        Me.griVehiculos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVehiculos.DisplayLayout.GroupByBox.Hidden = True
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance24.BackColor2 = System.Drawing.SystemColors.Control
        Appearance24.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance24.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griVehiculos.DisplayLayout.GroupByBox.PromptAppearance = Appearance24
        Me.griVehiculos.DisplayLayout.MaxColScrollRegions = 1
        Me.griVehiculos.DisplayLayout.MaxRowScrollRegions = 1
        Me.griVehiculos.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griVehiculos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griVehiculos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griVehiculos.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griVehiculos.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griVehiculos.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.griVehiculos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.griVehiculos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.griVehiculos.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griVehiculos.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griVehiculos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.griVehiculos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griVehiculos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griVehiculos.Location = New System.Drawing.Point(3, 16)
        Me.griVehiculos.Name = "griVehiculos"
        Me.griVehiculos.Size = New System.Drawing.Size(586, 565)
        Me.griVehiculos.TabIndex = 20
        '
        'Agrupacion5
        '
        Appearance25.BackColor = System.Drawing.Color.White
        Appearance25.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion5.ContentAreaAppearance = Appearance25
        Me.Agrupacion5.Controls.Add(Me.dtpVigencia)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta14)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta25)
        Me.Agrupacion5.Controls.Add(Me.btnImportar)
        Me.Agrupacion5.Controls.Add(Me.btnImagenMasivo)
        Me.Agrupacion5.Controls.Add(Me.chkMotrizMasivo)
        Me.Agrupacion5.Controls.Add(Me.txtModelo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta19)
        Me.Agrupacion5.Controls.Add(Me.txtMarca)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta18)
        Me.Agrupacion5.Controls.Add(Me.txtTipoVehMasivo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta17)
        Me.Agrupacion5.Controls.Add(Me.txtModeloFuncional)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta13)
        Me.Agrupacion5.Controls.Add(Me.chkVigente)
        Me.Agrupacion5.Controls.Add(Me.btnVerGrande)
        Me.Agrupacion5.Controls.Add(Me.griImagenes)
        Me.Agrupacion5.Controls.Add(Me.btnAgregarMasivo)
        Me.Agrupacion5.Controls.Add(Me.upbImagenMasivo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta10)
        Me.Agrupacion5.Controls.Add(Me.cboVehiculoMasivo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta11)
        Me.Agrupacion5.Controls.Add(Me.txtVencimientoMasivo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta12)
        Me.Agrupacion5.Controls.Add(Me.txtNroDocumentoMasivo)
        Me.Agrupacion5.Controls.Add(Me.cboTipoDocMasivo)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta15)
        Me.Agrupacion5.Controls.Add(Me.Etiqueta16)
        Me.Agrupacion5.Controls.Add(Me.dtpVencimiento)
        Me.Agrupacion5.Controls.Add(Me.txtDescripcionMasivo)
        Me.Agrupacion5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion5.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion5.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion5.Name = "Agrupacion5"
        Me.Agrupacion5.Size = New System.Drawing.Size(445, 584)
        Me.Agrupacion5.TabIndex = 4
        Me.Agrupacion5.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'dtpVigencia
        '
        Me.dtpVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVigencia.Location = New System.Drawing.Point(278, 36)
        Me.dtpVigencia.Name = "dtpVigencia"
        Me.dtpVigencia.Size = New System.Drawing.Size(98, 20)
        Me.dtpVigencia.TabIndex = 3
        '
        'Etiqueta14
        '
        Appearance26.BackColor = System.Drawing.Color.Transparent
        Appearance26.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta14.Appearance = Appearance26
        Me.Etiqueta14.AutoSize = True
        Me.Etiqueta14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta14.Location = New System.Drawing.Point(211, 36)
        Me.Etiqueta14.Name = "Etiqueta14"
        Me.Etiqueta14.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta14.TabIndex = 407
        Me.Etiqueta14.Text = "F. Vigencia:"
        '
        'Etiqueta25
        '
        Appearance27.BackColor = System.Drawing.Color.Transparent
        Appearance27.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta25.Appearance = Appearance27
        Me.Etiqueta25.AutoSize = True
        Me.Etiqueta25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta25.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta25.Location = New System.Drawing.Point(9, 37)
        Me.Etiqueta25.Name = "Etiqueta25"
        Me.Etiqueta25.Size = New System.Drawing.Size(80, 14)
        Me.Etiqueta25.TabIndex = 406
        Me.Etiqueta25.Text = "F. Vencimiento:"
        '
        'btnImportar
        '
        Appearance28.ForeColor = System.Drawing.Color.Navy
        Me.btnImportar.Appearance = Appearance28
        Me.btnImportar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.Black
        Me.btnImportar.Location = New System.Drawing.Point(337, 232)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(81, 22)
        Me.btnImportar.TabIndex = 15
        Me.btnImportar.Text = "Importar"
        '
        'btnImagenMasivo
        '
        Appearance29.ForeColor = System.Drawing.Color.Navy
        Me.btnImagenMasivo.Appearance = Appearance29
        Me.btnImagenMasivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImagenMasivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImagenMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagenMasivo.ForeColor = System.Drawing.Color.Black
        Me.btnImagenMasivo.Location = New System.Drawing.Point(95, 234)
        Me.btnImagenMasivo.Name = "btnImagenMasivo"
        Me.btnImagenMasivo.Size = New System.Drawing.Size(81, 22)
        Me.btnImagenMasivo.TabIndex = 14
        Me.btnImagenMasivo.Text = "Imagen"
        '
        'chkMotrizMasivo
        '
        Appearance30.ForeColor = System.Drawing.Color.Navy
        Me.chkMotrizMasivo.Appearance = Appearance30
        Me.chkMotrizMasivo.AutoSize = True
        Me.chkMotrizMasivo.BackColor = System.Drawing.Color.Transparent
        Me.chkMotrizMasivo.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkMotrizMasivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMotrizMasivo.Enabled = False
        Me.chkMotrizMasivo.Location = New System.Drawing.Point(238, 63)
        Me.chkMotrizMasivo.Name = "chkMotrizMasivo"
        Me.chkMotrizMasivo.Size = New System.Drawing.Size(52, 17)
        Me.chkMotrizMasivo.TabIndex = 5
        Me.chkMotrizMasivo.Text = "Motriz"
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(278, 85)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(140, 21)
        Me.txtModelo.TabIndex = 7
        '
        'Etiqueta19
        '
        Appearance31.BackColor = System.Drawing.Color.Transparent
        Appearance31.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta19.Appearance = Appearance31
        Me.Etiqueta19.AutoSize = True
        Me.Etiqueta19.Enabled = False
        Me.Etiqueta19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta19.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta19.Location = New System.Drawing.Point(237, 89)
        Me.Etiqueta19.Name = "Etiqueta19"
        Me.Etiqueta19.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta19.TabIndex = 391
        Me.Etiqueta19.Text = "Modelo"
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(279, 114)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ReadOnly = True
        Me.txtMarca.Size = New System.Drawing.Size(140, 21)
        Me.txtMarca.TabIndex = 9
        '
        'Etiqueta18
        '
        Appearance32.BackColor = System.Drawing.Color.Transparent
        Appearance32.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta18.Appearance = Appearance32
        Me.Etiqueta18.AutoSize = True
        Me.Etiqueta18.Enabled = False
        Me.Etiqueta18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta18.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta18.Location = New System.Drawing.Point(238, 118)
        Me.Etiqueta18.Name = "Etiqueta18"
        Me.Etiqueta18.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta18.TabIndex = 389
        Me.Etiqueta18.Text = "Marca"
        '
        'txtTipoVehMasivo
        '
        Me.txtTipoVehMasivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoVehMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoVehMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehMasivo.Location = New System.Drawing.Point(95, 114)
        Me.txtTipoVehMasivo.Name = "txtTipoVehMasivo"
        Me.txtTipoVehMasivo.ReadOnly = True
        Me.txtTipoVehMasivo.Size = New System.Drawing.Size(137, 21)
        Me.txtTipoVehMasivo.TabIndex = 8
        '
        'Etiqueta17
        '
        Appearance33.BackColor = System.Drawing.Color.Transparent
        Appearance33.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta17.Appearance = Appearance33
        Me.Etiqueta17.AutoSize = True
        Me.Etiqueta17.Enabled = False
        Me.Etiqueta17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta17.Location = New System.Drawing.Point(18, 118)
        Me.Etiqueta17.Name = "Etiqueta17"
        Me.Etiqueta17.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta17.TabIndex = 387
        Me.Etiqueta17.Text = "Tipo Vehiculo"
        '
        'txtModeloFuncional
        '
        Me.txtModeloFuncional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModeloFuncional.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModeloFuncional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloFuncional.Location = New System.Drawing.Point(95, 89)
        Me.txtModeloFuncional.Name = "txtModeloFuncional"
        Me.txtModeloFuncional.ReadOnly = True
        Me.txtModeloFuncional.Size = New System.Drawing.Size(137, 21)
        Me.txtModeloFuncional.TabIndex = 6
        '
        'Etiqueta13
        '
        Appearance34.BackColor = System.Drawing.Color.Transparent
        Appearance34.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta13.Appearance = Appearance34
        Me.Etiqueta13.AutoSize = True
        Me.Etiqueta13.Enabled = False
        Me.Etiqueta13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta13.Location = New System.Drawing.Point(2, 92)
        Me.Etiqueta13.Name = "Etiqueta13"
        Me.Etiqueta13.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta13.TabIndex = 385
        Me.Etiqueta13.Text = "Modelo Funcional"
        '
        'chkVigente
        '
        Appearance35.ForeColor = System.Drawing.Color.Navy
        Me.chkVigente.Appearance = Appearance35
        Me.chkVigente.AutoSize = True
        Me.chkVigente.BackColor = System.Drawing.Color.Transparent
        Me.chkVigente.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkVigente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVigente.Location = New System.Drawing.Point(237, 208)
        Me.chkVigente.Name = "chkVigente"
        Me.chkVigente.Size = New System.Drawing.Size(65, 17)
        Me.chkVigente.TabIndex = 13
        Me.chkVigente.Text = "Vigencia"
        '
        'btnVerGrande
        '
        Appearance36.BackColor = System.Drawing.Color.White
        Appearance36.BackColor2 = System.Drawing.Color.White
        Appearance36.Image = Global.ISL.Win.My.Resources.Resources.ver_grande
        Appearance36.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnVerGrande.Appearance = Appearance36
        Me.btnVerGrande.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnVerGrande.Location = New System.Drawing.Point(363, 467)
        Me.btnVerGrande.Name = "btnVerGrande"
        Me.btnVerGrande.Size = New System.Drawing.Size(56, 50)
        Me.btnVerGrande.TabIndex = 17
        '
        'griImagenes
        '
        Me.griImagenes.DataSource = Me.odImgDocVeh
        UltraGridColumn113.Header.VisiblePosition = 0
        UltraGridColumn113.Hidden = True
        UltraGridColumn114.Header.VisiblePosition = 1
        UltraGridColumn114.Hidden = True
        UltraGridColumn115.Header.VisiblePosition = 2
        UltraGridColumn115.Hidden = True
        UltraGridColumn116.Header.VisiblePosition = 3
        UltraGridColumn116.Hidden = True
        UltraGridColumn31.Header.VisiblePosition = 18
        UltraGridColumn117.Header.VisiblePosition = 4
        UltraGridColumn117.Hidden = True
        UltraGridColumn118.Header.VisiblePosition = 5
        UltraGridColumn118.Hidden = True
        UltraGridColumn119.Header.VisiblePosition = 6
        UltraGridColumn119.Hidden = True
        UltraGridColumn120.Header.VisiblePosition = 7
        UltraGridColumn120.Hidden = True
        UltraGridColumn121.Header.VisiblePosition = 8
        UltraGridColumn121.Hidden = True
        UltraGridColumn121.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn122.Header.VisiblePosition = 9
        UltraGridColumn122.Hidden = True
        UltraGridColumn123.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn123.Header.Caption = "Ruta Imagen"
        UltraGridColumn123.Header.VisiblePosition = 10
        UltraGridColumn123.Width = 388
        UltraGridColumn124.Header.VisiblePosition = 11
        UltraGridColumn124.Hidden = True
        UltraGridColumn125.Header.VisiblePosition = 12
        UltraGridColumn125.Hidden = True
        UltraGridColumn125.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn126.Header.VisiblePosition = 13
        UltraGridColumn126.Hidden = True
        UltraGridColumn127.Header.VisiblePosition = 15
        UltraGridColumn127.Hidden = True
        UltraGridColumn128.Header.VisiblePosition = 14
        UltraGridColumn128.Hidden = True
        UltraGridColumn128.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn129.Header.VisiblePosition = 16
        UltraGridColumn129.Hidden = True
        UltraGridColumn130.Header.VisiblePosition = 17
        UltraGridColumn130.Hidden = True
        UltraGridColumn130.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116, UltraGridColumn31, UltraGridColumn117, UltraGridColumn118, UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124, UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130})
        Me.griImagenes.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.griImagenes.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griImagenes.Location = New System.Drawing.Point(10, 260)
        Me.griImagenes.Name = "griImagenes"
        Me.griImagenes.Size = New System.Drawing.Size(409, 120)
        Me.griImagenes.TabIndex = 19
        Me.griImagenes.Text = "Lista Imagenes"
        '
        'btnAgregarMasivo
        '
        Appearance37.BackColor = System.Drawing.Color.White
        Appearance37.BackColor2 = System.Drawing.Color.White
        Appearance37.Image = Global.ISL.Win.My.Resources.Resources.descarga
        Appearance37.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnAgregarMasivo.Appearance = Appearance37
        Me.btnAgregarMasivo.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAgregarMasivo.Location = New System.Drawing.Point(363, 402)
        Me.btnAgregarMasivo.Name = "btnAgregarMasivo"
        Me.btnAgregarMasivo.Size = New System.Drawing.Size(56, 50)
        Me.btnAgregarMasivo.TabIndex = 16
        '
        'upbImagenMasivo
        '
        Appearance38.BackColor = System.Drawing.Color.White
        Appearance38.BackColor2 = System.Drawing.Color.White
        Me.upbImagenMasivo.Appearance = Appearance38
        Me.upbImagenMasivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upbImagenMasivo.BorderShadowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.upbImagenMasivo.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.upbImagenMasivo.ImageTransparentColor = System.Drawing.Color.White
        Me.upbImagenMasivo.Location = New System.Drawing.Point(8, 386)
        Me.upbImagenMasivo.Name = "upbImagenMasivo"
        Me.upbImagenMasivo.Size = New System.Drawing.Size(346, 140)
        Me.upbImagenMasivo.TabIndex = 18
        '
        'Etiqueta10
        '
        Appearance39.BackColor = System.Drawing.Color.Transparent
        Appearance39.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta10.Appearance = Appearance39
        Me.Etiqueta10.AutoSize = True
        Me.Etiqueta10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta10.Location = New System.Drawing.Point(21, 209)
        Me.Etiqueta10.Name = "Etiqueta10"
        Me.Etiqueta10.Size = New System.Drawing.Size(68, 14)
        Me.Etiqueta10.TabIndex = 378
        Me.Etiqueta10.Text = "Vencimiento:"
        '
        'cboVehiculoMasivo
        '
        Appearance40.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoMasivo.Appearance = Appearance40
        Me.cboVehiculoMasivo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVehiculoMasivo.DisplayMember = ""
        Me.cboVehiculoMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculoMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculoMasivo.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoMasivo.Location = New System.Drawing.Point(95, 62)
        Me.cboVehiculoMasivo.Name = "cboVehiculoMasivo"
        Me.cboVehiculoMasivo.Size = New System.Drawing.Size(137, 21)
        Me.cboVehiculoMasivo.TabIndex = 4
        Me.cboVehiculoMasivo.ValueMember = "Id"
        '
        'Etiqueta11
        '
        Appearance41.BackColor = System.Drawing.Color.Transparent
        Appearance41.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta11.Appearance = Appearance41
        Me.Etiqueta11.AutoSize = True
        Me.Etiqueta11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta11.Location = New System.Drawing.Point(4, 12)
        Me.Etiqueta11.Name = "Etiqueta11"
        Me.Etiqueta11.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta11.TabIndex = 365
        Me.Etiqueta11.Text = "TipoDocumento:"
        '
        'txtVencimientoMasivo
        '
        Me.txtVencimientoMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtVencimientoMasivo.Location = New System.Drawing.Point(95, 207)
        Me.txtVencimientoMasivo.Name = "txtVencimientoMasivo"
        Me.txtVencimientoMasivo.ReadOnly = True
        Me.txtVencimientoMasivo.Size = New System.Drawing.Size(66, 21)
        Me.txtVencimientoMasivo.TabIndex = 12
        '
        'Etiqueta12
        '
        Appearance42.BackColor = System.Drawing.Color.Transparent
        Appearance42.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta12.Appearance = Appearance42
        Me.Etiqueta12.AutoSize = True
        Me.Etiqueta12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta12.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta12.Location = New System.Drawing.Point(40, 66)
        Me.Etiqueta12.Name = "Etiqueta12"
        Me.Etiqueta12.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta12.TabIndex = 364
        Me.Etiqueta12.Text = "Vehiculo:"
        '
        'txtNroDocumentoMasivo
        '
        Me.txtNroDocumentoMasivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumentoMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDocumentoMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoMasivo.Location = New System.Drawing.Point(95, 141)
        Me.txtNroDocumentoMasivo.Name = "txtNroDocumentoMasivo"
        Me.txtNroDocumentoMasivo.Size = New System.Drawing.Size(323, 21)
        Me.txtNroDocumentoMasivo.TabIndex = 10
        '
        'cboTipoDocMasivo
        '
        Appearance43.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocMasivo.Appearance = Appearance43
        Me.cboTipoDocMasivo.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocMasivo.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocMasivo.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocMasivo.Location = New System.Drawing.Point(95, 9)
        Me.cboTipoDocMasivo.Name = "cboTipoDocMasivo"
        Me.cboTipoDocMasivo.Size = New System.Drawing.Size(323, 21)
        Me.cboTipoDocMasivo.TabIndex = 1
        Me.cboTipoDocMasivo.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta15
        '
        Appearance44.BackColor = System.Drawing.Color.Transparent
        Appearance44.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta15.Appearance = Appearance44
        Me.Etiqueta15.AutoSize = True
        Me.Etiqueta15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta15.Location = New System.Drawing.Point(24, 169)
        Me.Etiqueta15.Name = "Etiqueta15"
        Me.Etiqueta15.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta15.TabIndex = 366
        Me.Etiqueta15.Text = "Descripcion:"
        '
        'Etiqueta16
        '
        Appearance45.BackColor = System.Drawing.Color.Transparent
        Appearance45.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta16.Appearance = Appearance45
        Me.Etiqueta16.AutoSize = True
        Me.Etiqueta16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta16.Location = New System.Drawing.Point(8, 143)
        Me.Etiqueta16.Name = "Etiqueta16"
        Me.Etiqueta16.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta16.TabIndex = 371
        Me.Etiqueta16.Text = "NroDocumento:"
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimiento.Location = New System.Drawing.Point(95, 36)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(98, 20)
        Me.dtpVencimiento.TabIndex = 2
        '
        'txtDescripcionMasivo
        '
        Me.txtDescripcionMasivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionMasivo.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcionMasivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionMasivo.Location = New System.Drawing.Point(95, 167)
        Me.txtDescripcionMasivo.Multiline = True
        Me.txtDescripcionMasivo.Name = "txtDescripcionMasivo"
        Me.txtDescripcionMasivo.Size = New System.Drawing.Size(323, 36)
        Me.txtDescripcionMasivo.TabIndex = 11
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion8)
        Me.UltraTabPageControl5.Controls.Add(Me.Agrupacion9)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(1037, 584)
        '
        'Agrupacion8
        '
        Appearance46.BackColor = System.Drawing.Color.White
        Appearance46.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion8.ContentAreaAppearance = Appearance46
        Me.Agrupacion8.Controls.Add(Me.gridDocumentoVehiculoIgual)
        Me.Agrupacion8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion8.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion8.Location = New System.Drawing.Point(445, 0)
        Me.Agrupacion8.Name = "Agrupacion8"
        Me.Agrupacion8.Size = New System.Drawing.Size(592, 584)
        Me.Agrupacion8.TabIndex = 7
        Me.Agrupacion8.Text = "Unidades Vehiculares"
        Me.Agrupacion8.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'gridDocumentoVehiculoIgual
        '
        Me.gridDocumentoVehiculoIgual.DataSource = Me.odImgDocVeh
        Appearance47.BackColor = System.Drawing.Color.White
        Appearance47.BackColor2 = System.Drawing.Color.White
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Appearance = Appearance47
        UltraGridColumn131.Header.VisiblePosition = 0
        UltraGridColumn131.Hidden = True
        UltraGridColumn132.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn132.Header.VisiblePosition = 2
        UltraGridColumn132.Width = 137
        UltraGridColumn133.Header.Caption = "Vehiculo"
        UltraGridColumn133.Header.VisiblePosition = 1
        UltraGridColumn134.Header.VisiblePosition = 10
        UltraGridColumn134.Hidden = True
        UltraGridColumn32.Header.VisiblePosition = 18
        UltraGridColumn135.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn135.Header.Caption = "Tipo Documento"
        UltraGridColumn135.Header.VisiblePosition = 3
        UltraGridColumn135.Width = 335
        UltraGridColumn136.Header.VisiblePosition = 9
        UltraGridColumn136.Hidden = True
        UltraGridColumn137.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        UltraGridColumn137.Header.VisiblePosition = 16
        UltraGridColumn137.Width = 259
        UltraGridColumn138.Header.VisiblePosition = 12
        UltraGridColumn138.Hidden = True
        UltraGridColumn139.Header.VisiblePosition = 13
        UltraGridColumn139.Hidden = True
        UltraGridColumn140.Header.VisiblePosition = 6
        UltraGridColumn140.Hidden = True
        UltraGridColumn141.Header.VisiblePosition = 4
        UltraGridColumn141.Hidden = True
        UltraGridColumn142.Header.VisiblePosition = 7
        UltraGridColumn142.Hidden = True
        UltraGridColumn143.Header.VisiblePosition = 5
        UltraGridColumn144.Header.VisiblePosition = 8
        UltraGridColumn144.Hidden = True
        UltraGridColumn145.Header.VisiblePosition = 11
        UltraGridColumn145.Hidden = True
        UltraGridColumn146.Header.VisiblePosition = 17
        UltraGridColumn147.Header.VisiblePosition = 14
        UltraGridColumn147.Hidden = True
        UltraGridColumn148.Header.VisiblePosition = 15
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134, UltraGridColumn32, UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144, UltraGridColumn145, UltraGridColumn146, UltraGridColumn147, UltraGridColumn148})
        Me.gridDocumentoVehiculoIgual.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Appearance48.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance48.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance48.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance48.BorderColor = System.Drawing.SystemColors.Window
        Me.gridDocumentoVehiculoIgual.DisplayLayout.GroupByBox.Appearance = Appearance48
        Appearance49.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDocumentoVehiculoIgual.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance49
        Me.gridDocumentoVehiculoIgual.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDocumentoVehiculoIgual.DisplayLayout.GroupByBox.Hidden = True
        Appearance50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance50.BackColor2 = System.Drawing.SystemColors.Control
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance50.ForeColor = System.Drawing.SystemColors.GrayText
        Me.gridDocumentoVehiculoIgual.DisplayLayout.GroupByBox.PromptAppearance = Appearance50
        Me.gridDocumentoVehiculoIgual.DisplayLayout.MaxColScrollRegions = 1
        Me.gridDocumentoVehiculoIgual.DisplayLayout.MaxRowScrollRegions = 1
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Solid
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.Standard
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.gridDocumentoVehiculoIgual.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.gridDocumentoVehiculoIgual.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.gridDocumentoVehiculoIgual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocumentoVehiculoIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridDocumentoVehiculoIgual.Location = New System.Drawing.Point(3, 16)
        Me.gridDocumentoVehiculoIgual.Name = "gridDocumentoVehiculoIgual"
        Me.gridDocumentoVehiculoIgual.Size = New System.Drawing.Size(586, 565)
        Me.gridDocumentoVehiculoIgual.TabIndex = 18
        '
        'Agrupacion9
        '
        Appearance51.BackColor = System.Drawing.Color.White
        Appearance51.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion9.ContentAreaAppearance = Appearance51
        Me.Agrupacion9.Controls.Add(Me.fecVigenciaIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta26)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta27)
        Me.Agrupacion9.Controls.Add(Me.btnImportarIgual)
        Me.Agrupacion9.Controls.Add(Me.btnImagenIgual)
        Me.Agrupacion9.Controls.Add(Me.chkMotrizIgual)
        Me.Agrupacion9.Controls.Add(Me.txtModeloIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta28)
        Me.Agrupacion9.Controls.Add(Me.txtMarcaIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta29)
        Me.Agrupacion9.Controls.Add(Me.txtTipoVehiculoIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta30)
        Me.Agrupacion9.Controls.Add(Me.txtModeloFuncionalIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta31)
        Me.Agrupacion9.Controls.Add(Me.btnMostrarIgual)
        Me.Agrupacion9.Controls.Add(Me.gridImagenesIgual)
        Me.Agrupacion9.Controls.Add(Me.btnAgregarIgual)
        Me.Agrupacion9.Controls.Add(Me.pixImagenIgual)
        Me.Agrupacion9.Controls.Add(Me.cboVehiculoIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta33)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta34)
        Me.Agrupacion9.Controls.Add(Me.txtNroDocumentoIgual)
        Me.Agrupacion9.Controls.Add(Me.cboTipoDocumentoIgual)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta35)
        Me.Agrupacion9.Controls.Add(Me.Etiqueta36)
        Me.Agrupacion9.Controls.Add(Me.fecVencimientoIgual)
        Me.Agrupacion9.Controls.Add(Me.txtDescripcionIgual)
        Me.Agrupacion9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Agrupacion9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion9.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion9.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion9.Name = "Agrupacion9"
        Me.Agrupacion9.Size = New System.Drawing.Size(445, 584)
        Me.Agrupacion9.TabIndex = 6
        Me.Agrupacion9.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'fecVigenciaIgual
        '
        Me.fecVigenciaIgual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecVigenciaIgual.Location = New System.Drawing.Point(278, 36)
        Me.fecVigenciaIgual.Name = "fecVigenciaIgual"
        Me.fecVigenciaIgual.Size = New System.Drawing.Size(98, 20)
        Me.fecVigenciaIgual.TabIndex = 3
        '
        'Etiqueta26
        '
        Appearance52.BackColor = System.Drawing.Color.Transparent
        Appearance52.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta26.Appearance = Appearance52
        Me.Etiqueta26.AutoSize = True
        Me.Etiqueta26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta26.Location = New System.Drawing.Point(211, 36)
        Me.Etiqueta26.Name = "Etiqueta26"
        Me.Etiqueta26.Size = New System.Drawing.Size(62, 14)
        Me.Etiqueta26.TabIndex = 407
        Me.Etiqueta26.Text = "F. Vigencia:"
        '
        'Etiqueta27
        '
        Appearance53.BackColor = System.Drawing.Color.Transparent
        Appearance53.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta27.Appearance = Appearance53
        Me.Etiqueta27.AutoSize = True
        Me.Etiqueta27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta27.Location = New System.Drawing.Point(9, 37)
        Me.Etiqueta27.Name = "Etiqueta27"
        Me.Etiqueta27.Size = New System.Drawing.Size(80, 14)
        Me.Etiqueta27.TabIndex = 406
        Me.Etiqueta27.Text = "F. Vencimiento:"
        '
        'btnImportarIgual
        '
        Appearance54.ForeColor = System.Drawing.Color.Navy
        Me.btnImportarIgual.Appearance = Appearance54
        Me.btnImportarIgual.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImportarIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImportarIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportarIgual.ForeColor = System.Drawing.Color.Black
        Me.btnImportarIgual.Location = New System.Drawing.Point(337, 207)
        Me.btnImportarIgual.Name = "btnImportarIgual"
        Me.btnImportarIgual.Size = New System.Drawing.Size(81, 22)
        Me.btnImportarIgual.TabIndex = 13
        Me.btnImportarIgual.Text = "Importar"
        '
        'btnImagenIgual
        '
        Appearance55.ForeColor = System.Drawing.Color.Navy
        Me.btnImagenIgual.Appearance = Appearance55
        Me.btnImagenIgual.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnImagenIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImagenIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagenIgual.ForeColor = System.Drawing.Color.Black
        Me.btnImagenIgual.Location = New System.Drawing.Point(95, 207)
        Me.btnImagenIgual.Name = "btnImagenIgual"
        Me.btnImagenIgual.Size = New System.Drawing.Size(81, 22)
        Me.btnImagenIgual.TabIndex = 12
        Me.btnImagenIgual.Text = "Imagen"
        '
        'chkMotrizIgual
        '
        Appearance56.ForeColor = System.Drawing.Color.Navy
        Me.chkMotrizIgual.Appearance = Appearance56
        Me.chkMotrizIgual.AutoSize = True
        Me.chkMotrizIgual.BackColor = System.Drawing.Color.Transparent
        Me.chkMotrizIgual.BackColorInternal = System.Drawing.Color.Transparent
        Me.chkMotrizIgual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMotrizIgual.Enabled = False
        Me.chkMotrizIgual.Location = New System.Drawing.Point(238, 63)
        Me.chkMotrizIgual.Name = "chkMotrizIgual"
        Me.chkMotrizIgual.Size = New System.Drawing.Size(52, 17)
        Me.chkMotrizIgual.TabIndex = 5
        Me.chkMotrizIgual.Text = "Motriz"
        '
        'txtModeloIgual
        '
        Me.txtModeloIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModeloIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModeloIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloIgual.Location = New System.Drawing.Point(278, 85)
        Me.txtModeloIgual.Name = "txtModeloIgual"
        Me.txtModeloIgual.ReadOnly = True
        Me.txtModeloIgual.Size = New System.Drawing.Size(140, 21)
        Me.txtModeloIgual.TabIndex = 7
        '
        'Etiqueta28
        '
        Appearance57.BackColor = System.Drawing.Color.Transparent
        Appearance57.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta28.Appearance = Appearance57
        Me.Etiqueta28.AutoSize = True
        Me.Etiqueta28.Enabled = False
        Me.Etiqueta28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta28.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta28.Location = New System.Drawing.Point(237, 89)
        Me.Etiqueta28.Name = "Etiqueta28"
        Me.Etiqueta28.Size = New System.Drawing.Size(40, 14)
        Me.Etiqueta28.TabIndex = 391
        Me.Etiqueta28.Text = "Modelo"
        '
        'txtMarcaIgual
        '
        Me.txtMarcaIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarcaIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtMarcaIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarcaIgual.Location = New System.Drawing.Point(279, 114)
        Me.txtMarcaIgual.Name = "txtMarcaIgual"
        Me.txtMarcaIgual.ReadOnly = True
        Me.txtMarcaIgual.Size = New System.Drawing.Size(140, 21)
        Me.txtMarcaIgual.TabIndex = 9
        '
        'Etiqueta29
        '
        Appearance58.BackColor = System.Drawing.Color.Transparent
        Appearance58.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta29.Appearance = Appearance58
        Me.Etiqueta29.AutoSize = True
        Me.Etiqueta29.Enabled = False
        Me.Etiqueta29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta29.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta29.Location = New System.Drawing.Point(238, 118)
        Me.Etiqueta29.Name = "Etiqueta29"
        Me.Etiqueta29.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta29.TabIndex = 389
        Me.Etiqueta29.Text = "Marca"
        '
        'txtTipoVehiculoIgual
        '
        Me.txtTipoVehiculoIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoVehiculoIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtTipoVehiculoIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoVehiculoIgual.Location = New System.Drawing.Point(95, 114)
        Me.txtTipoVehiculoIgual.Name = "txtTipoVehiculoIgual"
        Me.txtTipoVehiculoIgual.ReadOnly = True
        Me.txtTipoVehiculoIgual.Size = New System.Drawing.Size(137, 21)
        Me.txtTipoVehiculoIgual.TabIndex = 8
        '
        'Etiqueta30
        '
        Appearance59.BackColor = System.Drawing.Color.Transparent
        Appearance59.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta30.Appearance = Appearance59
        Me.Etiqueta30.AutoSize = True
        Me.Etiqueta30.Enabled = False
        Me.Etiqueta30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta30.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta30.Location = New System.Drawing.Point(18, 118)
        Me.Etiqueta30.Name = "Etiqueta30"
        Me.Etiqueta30.Size = New System.Drawing.Size(71, 14)
        Me.Etiqueta30.TabIndex = 387
        Me.Etiqueta30.Text = "Tipo Vehiculo"
        '
        'txtModeloFuncionalIgual
        '
        Me.txtModeloFuncionalIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModeloFuncionalIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtModeloFuncionalIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModeloFuncionalIgual.Location = New System.Drawing.Point(95, 89)
        Me.txtModeloFuncionalIgual.Name = "txtModeloFuncionalIgual"
        Me.txtModeloFuncionalIgual.ReadOnly = True
        Me.txtModeloFuncionalIgual.Size = New System.Drawing.Size(137, 21)
        Me.txtModeloFuncionalIgual.TabIndex = 6
        '
        'Etiqueta31
        '
        Appearance60.BackColor = System.Drawing.Color.Transparent
        Appearance60.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta31.Appearance = Appearance60
        Me.Etiqueta31.AutoSize = True
        Me.Etiqueta31.Enabled = False
        Me.Etiqueta31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta31.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta31.Location = New System.Drawing.Point(2, 92)
        Me.Etiqueta31.Name = "Etiqueta31"
        Me.Etiqueta31.Size = New System.Drawing.Size(91, 14)
        Me.Etiqueta31.TabIndex = 385
        Me.Etiqueta31.Text = "Modelo Funcional"
        '
        'btnMostrarIgual
        '
        Appearance61.BackColor = System.Drawing.Color.White
        Appearance61.BackColor2 = System.Drawing.Color.White
        Appearance61.Image = Global.ISL.Win.My.Resources.Resources.ver_grande
        Appearance61.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnMostrarIgual.Appearance = Appearance61
        Me.btnMostrarIgual.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnMostrarIgual.Location = New System.Drawing.Point(363, 467)
        Me.btnMostrarIgual.Name = "btnMostrarIgual"
        Me.btnMostrarIgual.Size = New System.Drawing.Size(56, 50)
        Me.btnMostrarIgual.TabIndex = 15
        '
        'gridImagenesIgual
        '
        Me.gridImagenesIgual.DataSource = Me.odImgDocVeh
        UltraGridColumn28.Header.VisiblePosition = 0
        UltraGridColumn28.Hidden = True
        UltraGridColumn78.Header.VisiblePosition = 1
        UltraGridColumn78.Hidden = True
        UltraGridColumn79.Header.VisiblePosition = 2
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.Header.VisiblePosition = 3
        UltraGridColumn80.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 18
        UltraGridColumn81.Header.VisiblePosition = 4
        UltraGridColumn81.Hidden = True
        UltraGridColumn82.Header.VisiblePosition = 5
        UltraGridColumn82.Hidden = True
        UltraGridColumn83.Header.VisiblePosition = 6
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.Header.VisiblePosition = 7
        UltraGridColumn84.Hidden = True
        UltraGridColumn85.Header.VisiblePosition = 8
        UltraGridColumn85.Hidden = True
        UltraGridColumn85.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn86.Header.VisiblePosition = 9
        UltraGridColumn86.Hidden = True
        UltraGridColumn87.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        UltraGridColumn87.Header.Caption = "Ruta Imagen"
        UltraGridColumn87.Header.VisiblePosition = 10
        UltraGridColumn87.Width = 388
        UltraGridColumn88.Header.VisiblePosition = 11
        UltraGridColumn88.Hidden = True
        UltraGridColumn89.Header.VisiblePosition = 12
        UltraGridColumn89.Hidden = True
        UltraGridColumn89.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn90.Header.VisiblePosition = 13
        UltraGridColumn90.Hidden = True
        UltraGridColumn91.Header.VisiblePosition = 15
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.Header.VisiblePosition = 14
        UltraGridColumn92.Hidden = True
        UltraGridColumn92.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn93.Header.VisiblePosition = 16
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.Header.VisiblePosition = 17
        UltraGridColumn94.Hidden = True
        UltraGridColumn94.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn28, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn33, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94})
        Me.gridImagenesIgual.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.gridImagenesIgual.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.gridImagenesIgual.Location = New System.Drawing.Point(10, 235)
        Me.gridImagenesIgual.Name = "gridImagenesIgual"
        Me.gridImagenesIgual.Size = New System.Drawing.Size(409, 145)
        Me.gridImagenesIgual.TabIndex = 17
        Me.gridImagenesIgual.Text = "Lista Imagenes"
        '
        'btnAgregarIgual
        '
        Appearance62.BackColor = System.Drawing.Color.White
        Appearance62.BackColor2 = System.Drawing.Color.White
        Appearance62.Image = Global.ISL.Win.My.Resources.Resources.descarga
        Appearance62.ImageHAlign = Infragistics.Win.HAlign.Center
        Me.btnAgregarIgual.Appearance = Appearance62
        Me.btnAgregarIgual.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnAgregarIgual.Location = New System.Drawing.Point(363, 402)
        Me.btnAgregarIgual.Name = "btnAgregarIgual"
        Me.btnAgregarIgual.Size = New System.Drawing.Size(56, 50)
        Me.btnAgregarIgual.TabIndex = 14
        '
        'pixImagenIgual
        '
        Appearance63.BackColor = System.Drawing.Color.White
        Appearance63.BackColor2 = System.Drawing.Color.White
        Me.pixImagenIgual.Appearance = Appearance63
        Me.pixImagenIgual.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pixImagenIgual.BorderShadowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pixImagenIgual.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded1
        Me.pixImagenIgual.ImageTransparentColor = System.Drawing.Color.White
        Me.pixImagenIgual.Location = New System.Drawing.Point(8, 386)
        Me.pixImagenIgual.Name = "pixImagenIgual"
        Me.pixImagenIgual.Size = New System.Drawing.Size(346, 140)
        Me.pixImagenIgual.TabIndex = 16
        '
        'cboVehiculoIgual
        '
        Appearance64.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoIgual.Appearance = Appearance64
        Me.cboVehiculoIgual.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVehiculoIgual.DisplayMember = ""
        Me.cboVehiculoIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiculoIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiculoIgual.ForeColor = System.Drawing.Color.Black
        Me.cboVehiculoIgual.Location = New System.Drawing.Point(95, 62)
        Me.cboVehiculoIgual.Name = "cboVehiculoIgual"
        Me.cboVehiculoIgual.Size = New System.Drawing.Size(137, 21)
        Me.cboVehiculoIgual.TabIndex = 4
        Me.cboVehiculoIgual.ValueMember = "Id"
        '
        'Etiqueta33
        '
        Appearance65.BackColor = System.Drawing.Color.Transparent
        Appearance65.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta33.Appearance = Appearance65
        Me.Etiqueta33.AutoSize = True
        Me.Etiqueta33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta33.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta33.Location = New System.Drawing.Point(4, 12)
        Me.Etiqueta33.Name = "Etiqueta33"
        Me.Etiqueta33.Size = New System.Drawing.Size(85, 14)
        Me.Etiqueta33.TabIndex = 365
        Me.Etiqueta33.Text = "TipoDocumento:"
        '
        'Etiqueta34
        '
        Appearance66.BackColor = System.Drawing.Color.Transparent
        Appearance66.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta34.Appearance = Appearance66
        Me.Etiqueta34.AutoSize = True
        Me.Etiqueta34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta34.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta34.Location = New System.Drawing.Point(40, 66)
        Me.Etiqueta34.Name = "Etiqueta34"
        Me.Etiqueta34.Size = New System.Drawing.Size(49, 14)
        Me.Etiqueta34.TabIndex = 364
        Me.Etiqueta34.Text = "Vehiculo:"
        '
        'txtNroDocumentoIgual
        '
        Me.txtNroDocumentoIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroDocumentoIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNroDocumentoIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocumentoIgual.Location = New System.Drawing.Point(95, 141)
        Me.txtNroDocumentoIgual.Name = "txtNroDocumentoIgual"
        Me.txtNroDocumentoIgual.Size = New System.Drawing.Size(323, 21)
        Me.txtNroDocumentoIgual.TabIndex = 10
        '
        'cboTipoDocumentoIgual
        '
        Appearance67.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumentoIgual.Appearance = Appearance67
        Me.cboTipoDocumentoIgual.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocumentoIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocumentoIgual.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        Me.cboTipoDocumentoIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocumentoIgual.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocumentoIgual.Location = New System.Drawing.Point(95, 9)
        Me.cboTipoDocumentoIgual.Name = "cboTipoDocumentoIgual"
        Me.cboTipoDocumentoIgual.Size = New System.Drawing.Size(323, 21)
        Me.cboTipoDocumentoIgual.TabIndex = 1
        Me.cboTipoDocumentoIgual.ValueMember = "IdTipoDocumento"
        '
        'Etiqueta35
        '
        Appearance68.BackColor = System.Drawing.Color.Transparent
        Appearance68.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta35.Appearance = Appearance68
        Me.Etiqueta35.AutoSize = True
        Me.Etiqueta35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta35.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta35.Location = New System.Drawing.Point(24, 169)
        Me.Etiqueta35.Name = "Etiqueta35"
        Me.Etiqueta35.Size = New System.Drawing.Size(65, 14)
        Me.Etiqueta35.TabIndex = 366
        Me.Etiqueta35.Text = "Descripcion:"
        '
        'Etiqueta36
        '
        Appearance69.BackColor = System.Drawing.Color.Transparent
        Appearance69.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta36.Appearance = Appearance69
        Me.Etiqueta36.AutoSize = True
        Me.Etiqueta36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta36.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Etiqueta36.Location = New System.Drawing.Point(8, 143)
        Me.Etiqueta36.Name = "Etiqueta36"
        Me.Etiqueta36.Size = New System.Drawing.Size(81, 14)
        Me.Etiqueta36.TabIndex = 371
        Me.Etiqueta36.Text = "NroDocumento:"
        '
        'fecVencimientoIgual
        '
        Me.fecVencimientoIgual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecVencimientoIgual.Location = New System.Drawing.Point(95, 36)
        Me.fecVencimientoIgual.Name = "fecVencimientoIgual"
        Me.fecVencimientoIgual.Size = New System.Drawing.Size(98, 20)
        Me.fecVencimientoIgual.TabIndex = 2
        '
        'txtDescripcionIgual
        '
        Me.txtDescripcionIgual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionIgual.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtDescripcionIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionIgual.Location = New System.Drawing.Point(95, 167)
        Me.txtDescripcionIgual.Multiline = True
        Me.txtDescripcionIgual.Name = "txtDescripcionIgual"
        Me.txtDescripcionIgual.Size = New System.Drawing.Size(323, 36)
        Me.txtDescripcionIgual.TabIndex = 11
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion2)
        Me.UltraTabPageControl1.Controls.Add(Me.Agrupacion1)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 22)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(1039, 607)
        '
        'Agrupacion2
        '
        Me.Agrupacion2.Controls.Add(Me.griLista)
        Me.Agrupacion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Agrupacion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion2.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion2.Location = New System.Drawing.Point(0, 113)
        Me.Agrupacion2.Name = "Agrupacion2"
        Me.Agrupacion2.Size = New System.Drawing.Size(1039, 494)
        Me.Agrupacion2.TabIndex = 1
        Me.Agrupacion2.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'griLista
        '
        Me.griLista.ContextMenuStrip = Me.ContextMenu1
        Me.griLista.DataSource = Me.odImgDocVeh
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 83
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        Appearance70.TextVAlignAsString = "Middle"
        UltraGridColumn4.CellAppearance = Appearance70
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Always
        UltraGridColumn4.Width = 70
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Width = 150
        UltraGridColumn5.Header.VisiblePosition = 5
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 6
        UltraGridColumn6.Width = 359
        UltraGridColumn7.Header.VisiblePosition = 16
        UltraGridColumn7.Width = 300
        UltraGridColumn8.Header.VisiblePosition = 9
        UltraGridColumn8.Hidden = True
        UltraGridColumn12.Header.VisiblePosition = 7
        UltraGridColumn12.Hidden = True
        UltraGridColumn12.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn15.Header.VisiblePosition = 8
        UltraGridColumn27.Header.VisiblePosition = 10
        UltraGridColumn27.Hidden = True
        UltraGridColumn37.Header.VisiblePosition = 11
        UltraGridColumn37.Hidden = True
        Appearance71.TextHAlignAsString = "Left"
        UltraGridColumn38.CellAppearance = Appearance71
        UltraGridColumn38.Header.VisiblePosition = 13
        UltraGridColumn38.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn38.Width = 80
        UltraGridColumn39.Header.VisiblePosition = 14
        UltraGridColumn40.Header.Caption = "Vigente"
        UltraGridColumn40.Header.VisiblePosition = 15
        UltraGridColumn40.Width = 40
        UltraGridColumn14.Header.VisiblePosition = 17
        UltraGridColumn14.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DateTime
        UltraGridColumn14.Width = 120
        UltraGridColumn16.Header.VisiblePosition = 18
        UltraGridColumn17.Header.VisiblePosition = 12
        UltraGridColumn17.Style = Infragistics.Win.UltraWinGrid.ColumnStyle.[Date]
        UltraGridColumn17.Width = 80
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn34, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn12, UltraGridColumn15, UltraGridColumn27, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn14, UltraGridColumn16, UltraGridColumn17})
        Appearance72.ImageHAlign = Infragistics.Win.HAlign.Center
        UltraGridBand6.Header.Appearance = Appearance72
        Me.griLista.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.griLista.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance73.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance73.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance73.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance73.BorderColor = System.Drawing.SystemColors.Window
        Me.griLista.DisplayLayout.GroupByBox.Appearance = Appearance73
        Appearance74.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance74
        Me.griLista.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.griLista.DisplayLayout.GroupByBox.Hidden = True
        Appearance75.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance75.BackColor2 = System.Drawing.SystemColors.Control
        Appearance75.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.griLista.DisplayLayout.GroupByBox.PromptAppearance = Appearance75
        Me.griLista.DisplayLayout.MaxColScrollRegions = 1
        Me.griLista.DisplayLayout.MaxRowScrollRegions = 1
        Me.griLista.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.griLista.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.griLista.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.griLista.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.griLista.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance76.BorderColor = System.Drawing.Color.Silver
        Me.griLista.DisplayLayout.Override.CellAppearance = Appearance76
        Me.griLista.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.griLista.DisplayLayout.Override.CellPadding = 0
        Me.griLista.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains
        Me.griLista.DisplayLayout.Override.FilterUIProvider = Me.Filtro1
        Me.griLista.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Appearance77.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Me.griLista.DisplayLayout.Override.GroupByRowAppearance = Appearance77
        Appearance78.TextHAlignAsString = "Center"
        Me.griLista.DisplayLayout.Override.HeaderAppearance = Appearance78
        Me.griLista.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Appearance79.BorderColor = System.Drawing.Color.Silver
        Me.griLista.DisplayLayout.Override.RowAppearance = Appearance79
        Me.griLista.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.griLista.DisplayLayout.Override.RowSelectorNumberStyle = Infragistics.Win.UltraWinGrid.RowSelectorNumberStyle.VisibleIndex
        Me.griLista.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.SingleAutoDrag
        Me.griLista.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.griLista.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.griLista.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.griLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.griLista.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.griLista.Location = New System.Drawing.Point(3, 3)
        Me.griLista.Name = "griLista"
        Me.griLista.Size = New System.Drawing.Size(1033, 488)
        Me.griLista.TabIndex = 11
        Me.griLista.TabStop = False
        Me.griLista.Text = "Grilla1"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuNuevo, Me.ToolStripMenuEditar, Me.ToolStripMenuEliminar, Me.ToolStripMenuVigencia, Me.ToolStripDescargarImg})
        Me.ContextMenu1.Name = "ContextMenuStrip1"
        Me.ContextMenu1.Size = New System.Drawing.Size(167, 114)
        '
        'ToolStripMenuNuevo
        '
        Me.ToolStripMenuNuevo.Image = Global.ISL.Win.My.Resources.Resources.Nuevo
        Me.ToolStripMenuNuevo.Name = "ToolStripMenuNuevo"
        Me.ToolStripMenuNuevo.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuNuevo.Text = "Nuevo"
        '
        'ToolStripMenuEditar
        '
        Me.ToolStripMenuEditar.Enabled = False
        Me.ToolStripMenuEditar.Image = Global.ISL.Win.My.Resources.Resources.Editar
        Me.ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        Me.ToolStripMenuEditar.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuEditar.Text = "Editar"
        '
        'ToolStripMenuEliminar
        '
        Me.ToolStripMenuEliminar.Enabled = False
        Me.ToolStripMenuEliminar.Image = Global.ISL.Win.My.Resources.Resources.Eliminar
        Me.ToolStripMenuEliminar.Name = "ToolStripMenuEliminar"
        Me.ToolStripMenuEliminar.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuEliminar.Text = "Eliminar"
        '
        'ToolStripMenuVigencia
        '
        Me.ToolStripMenuVigencia.Enabled = False
        Me.ToolStripMenuVigencia.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Me.ToolStripMenuVigencia.Name = "ToolStripMenuVigencia"
        Me.ToolStripMenuVigencia.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripMenuVigencia.Text = "CambiarVigencia"
        '
        'ToolStripDescargarImg
        '
        Me.ToolStripDescargarImg.Image = Global.ISL.Win.My.Resources.Resources.Rename
        Me.ToolStripDescargarImg.Name = "ToolStripDescargarImg"
        Me.ToolStripDescargarImg.Size = New System.Drawing.Size(166, 22)
        Me.ToolStripDescargarImg.Text = "DescargarImagen"
        '
        'Agrupacion1
        '
        Appearance80.BackColor = System.Drawing.Color.White
        Appearance80.BackColor2 = System.Drawing.Color.White
        Me.Agrupacion1.ContentAreaAppearance = Appearance80
        Me.Agrupacion1.Controls.Add(Me.rdbDatosAdicionales)
        Me.Agrupacion1.Controls.Add(Me.Agrupacion7)
        Me.Agrupacion1.Controls.Add(Me.agrFechas)
        Me.Agrupacion1.Controls.Add(Me.rdbFechas)
        Me.Agrupacion1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Agrupacion1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion1.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion1.Location = New System.Drawing.Point(0, 0)
        Me.Agrupacion1.Name = "Agrupacion1"
        Me.Agrupacion1.Size = New System.Drawing.Size(1039, 113)
        Me.Agrupacion1.TabIndex = 0
        Me.Agrupacion1.Text = "Listar"
        Me.Agrupacion1.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'rdbDatosAdicionales
        '
        Me.rdbDatosAdicionales.AutoSize = True
        Me.rdbDatosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.rdbDatosAdicionales.ForeColor = System.Drawing.Color.Navy
        Me.rdbDatosAdicionales.Location = New System.Drawing.Point(190, 19)
        Me.rdbDatosAdicionales.Name = "rdbDatosAdicionales"
        Me.rdbDatosAdicionales.Size = New System.Drawing.Size(110, 17)
        Me.rdbDatosAdicionales.TabIndex = 2
        Me.rdbDatosAdicionales.Text = "Datos Adicionales"
        Me.rdbDatosAdicionales.UseVisualStyleBackColor = False
        '
        'Agrupacion7
        '
        Me.Agrupacion7.Controls.Add(Me.btnSincronizar)
        Me.Agrupacion7.Controls.Add(Me.Vigente)
        Me.Agrupacion7.Controls.Add(Me.cboIndicadorListar)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta32)
        Me.Agrupacion7.Controls.Add(Me.Etiqueta7)
        Me.Agrupacion7.Controls.Add(Me.cboVehiListar)
        Me.Agrupacion7.Controls.Add(Me.etiGenerada)
        Me.Agrupacion7.Controls.Add(Me.ColoresVencido)
        Me.Agrupacion7.Controls.Add(Me.cboTipoDocLista)
        Me.Agrupacion7.Controls.Add(Me.etiTerminada)
        Me.Agrupacion7.Controls.Add(Me.etiEnProceso)
        Me.Agrupacion7.Controls.Add(Me.ColoresPorVencer)
        Me.Agrupacion7.Controls.Add(Me.ColoresGenerado)
        Me.Agrupacion7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agrupacion7.ForeColor = System.Drawing.Color.Black
        Me.Agrupacion7.Location = New System.Drawing.Point(190, 38)
        Me.Agrupacion7.Name = "Agrupacion7"
        Me.Agrupacion7.Size = New System.Drawing.Size(716, 63)
        Me.Agrupacion7.TabIndex = 382
        Me.Agrupacion7.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'btnSincronizar
        '
        Appearance81.ForeColor = System.Drawing.Color.Navy
        Appearance81.Image = Global.ISL.Win.My.Resources.Resources.Actualiza
        Appearance81.ImageHAlign = Infragistics.Win.HAlign.Right
        Me.btnSincronizar.Appearance = Appearance81
        Me.btnSincronizar.BackColorInternal = System.Drawing.Color.Transparent
        Me.btnSincronizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSincronizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizar.ForeColor = System.Drawing.Color.Black
        Me.btnSincronizar.Location = New System.Drawing.Point(572, 32)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.Size = New System.Drawing.Size(93, 25)
        Me.btnSincronizar.TabIndex = 384
        Me.btnSincronizar.TabStop = False
        Me.btnSincronizar.Text = "Sincronizar"
        '
        'Vigente
        '
        Appearance82.BackColor = System.Drawing.Color.Transparent
        Appearance82.ForeColor = System.Drawing.Color.Navy
        Me.Vigente.Appearance = Appearance82
        Me.Vigente.AutoSize = True
        Me.Vigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vigente.ForeColor = System.Drawing.Color.Black
        Me.Vigente.Location = New System.Drawing.Point(276, 39)
        Me.Vigente.Name = "Vigente"
        Me.Vigente.Size = New System.Drawing.Size(44, 14)
        Me.Vigente.TabIndex = 383
        Me.Vigente.Text = "Vigente:"
        '
        'cboIndicadorListar
        '
        Appearance83.ForeColor = System.Drawing.Color.Black
        Me.cboIndicadorListar.Appearance = Appearance83
        Me.cboIndicadorListar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboIndicadorListar.DisplayMember = ""
        Me.cboIndicadorListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboIndicadorListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndicadorListar.ForeColor = System.Drawing.Color.Black
        Me.cboIndicadorListar.Location = New System.Drawing.Point(330, 35)
        Me.cboIndicadorListar.Name = "cboIndicadorListar"
        Me.cboIndicadorListar.Size = New System.Drawing.Size(93, 21)
        Me.cboIndicadorListar.TabIndex = 7
        Me.cboIndicadorListar.ValueMember = "Id"
        '
        'Etiqueta32
        '
        Appearance84.BackColor = System.Drawing.Color.Transparent
        Appearance84.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta32.Appearance = Appearance84
        Me.Etiqueta32.AutoSize = True
        Me.Etiqueta32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta32.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta32.Location = New System.Drawing.Point(59, 40)
        Me.Etiqueta32.Name = "Etiqueta32"
        Me.Etiqueta32.Size = New System.Drawing.Size(35, 14)
        Me.Etiqueta32.TabIndex = 381
        Me.Etiqueta32.Text = "Placa:"
        '
        'Etiqueta7
        '
        Appearance85.BackColor = System.Drawing.Color.Transparent
        Appearance85.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta7.Appearance = Appearance85
        Me.Etiqueta7.AutoSize = True
        Me.Etiqueta7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta7.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta7.Location = New System.Drawing.Point(6, 11)
        Me.Etiqueta7.Name = "Etiqueta7"
        Me.Etiqueta7.Size = New System.Drawing.Size(88, 14)
        Me.Etiqueta7.TabIndex = 378
        Me.Etiqueta7.Text = "Tipo Documento:"
        '
        'cboVehiListar
        '
        Appearance86.ForeColor = System.Drawing.Color.Black
        Me.cboVehiListar.Appearance = Appearance86
        Me.cboVehiListar.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboVehiListar.DisplayMember = ""
        Me.cboVehiListar.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboVehiListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehiListar.ForeColor = System.Drawing.Color.Black
        Me.cboVehiListar.Location = New System.Drawing.Point(100, 36)
        Me.cboVehiListar.Name = "cboVehiListar"
        Me.cboVehiListar.Size = New System.Drawing.Size(93, 21)
        Me.cboVehiListar.TabIndex = 6
        Me.cboVehiListar.ValueMember = "Id"
        '
        'etiGenerada
        '
        Appearance87.BackColor = System.Drawing.Color.Transparent
        Appearance87.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiGenerada.Appearance = Appearance87
        Me.etiGenerada.AutoSize = True
        Me.etiGenerada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiGenerada.ForeColor = System.Drawing.Color.Black
        Me.etiGenerada.Location = New System.Drawing.Point(444, 10)
        Me.etiGenerada.Name = "etiGenerada"
        Me.etiGenerada.Size = New System.Drawing.Size(52, 15)
        Me.etiGenerada.TabIndex = 3
        Me.etiGenerada.Text = "> 20 Dias"
        '
        'ColoresVencido
        '
        Me.ColoresVencido.Color = System.Drawing.Color.Red
        Me.ColoresVencido.Location = New System.Drawing.Point(617, 6)
        Me.ColoresVencido.Name = "ColoresVencido"
        Me.ColoresVencido.Size = New System.Drawing.Size(46, 21)
        Me.ColoresVencido.TabIndex = 9
        Me.ColoresVencido.Text = "Red"
        '
        'cboTipoDocLista
        '
        Appearance88.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocLista.Appearance = Appearance88
        Me.cboTipoDocLista.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend
        Me.cboTipoDocLista.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.cboTipoDocLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDocLista.ForeColor = System.Drawing.Color.Black
        Me.cboTipoDocLista.Location = New System.Drawing.Point(100, 7)
        Me.cboTipoDocLista.Name = "cboTipoDocLista"
        Me.cboTipoDocLista.Size = New System.Drawing.Size(323, 21)
        Me.cboTipoDocLista.TabIndex = 5
        Me.cboTipoDocLista.ValueMember = "Id"
        '
        'etiTerminada
        '
        Appearance89.BackColor = System.Drawing.Color.Transparent
        Appearance89.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiTerminada.Appearance = Appearance89
        Me.etiTerminada.AutoSize = True
        Me.etiTerminada.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiTerminada.ForeColor = System.Drawing.Color.Black
        Me.etiTerminada.Location = New System.Drawing.Point(559, 9)
        Me.etiTerminada.Name = "etiTerminada"
        Me.etiTerminada.Size = New System.Drawing.Size(52, 15)
        Me.etiTerminada.TabIndex = 5
        Me.etiTerminada.Text = "< 10 Dias"
        '
        'etiEnProceso
        '
        Appearance90.BackColor = System.Drawing.Color.Transparent
        Appearance90.ForeColor = System.Drawing.Color.MidnightBlue
        Me.etiEnProceso.Appearance = Appearance90
        Me.etiEnProceso.AutoSize = True
        Me.etiEnProceso.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etiEnProceso.ForeColor = System.Drawing.Color.Black
        Me.etiEnProceso.Location = New System.Drawing.Point(434, 36)
        Me.etiEnProceso.Name = "etiEnProceso"
        Me.etiEnProceso.Size = New System.Drawing.Size(63, 15)
        Me.etiEnProceso.TabIndex = 4
        Me.etiEnProceso.Text = "20 - 10 Dias"
        '
        'ColoresPorVencer
        '
        Me.ColoresPorVencer.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColoresPorVencer.Location = New System.Drawing.Point(503, 33)
        Me.ColoresPorVencer.Name = "ColoresPorVencer"
        Me.ColoresPorVencer.Size = New System.Drawing.Size(43, 21)
        Me.ColoresPorVencer.TabIndex = 10
        Me.ColoresPorVencer.Text = "255, 128, 0"
        '
        'ColoresGenerado
        '
        Me.ColoresGenerado.Color = System.Drawing.Color.White
        Me.ColoresGenerado.Location = New System.Drawing.Point(502, 6)
        Me.ColoresGenerado.Name = "ColoresGenerado"
        Me.ColoresGenerado.Size = New System.Drawing.Size(46, 21)
        Me.ColoresGenerado.TabIndex = 8
        Me.ColoresGenerado.Text = "White"
        '
        'agrFechas
        '
        Me.agrFechas.Controls.Add(Me.Etiqueta5)
        Me.agrFechas.Controls.Add(Me.fecDesde)
        Me.agrFechas.Controls.Add(Me.fecHasta)
        Me.agrFechas.Controls.Add(Me.Etiqueta6)
        Me.agrFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agrFechas.ForeColor = System.Drawing.Color.Black
        Me.agrFechas.Location = New System.Drawing.Point(6, 38)
        Me.agrFechas.Name = "agrFechas"
        Me.agrFechas.Size = New System.Drawing.Size(166, 63)
        Me.agrFechas.TabIndex = 381
        Me.agrFechas.ViewStyle = Infragistics.Win.Misc.GroupBoxViewStyle.Office2007
        '
        'Etiqueta5
        '
        Appearance91.BackColor = System.Drawing.Color.Transparent
        Appearance91.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta5.Appearance = Appearance91
        Me.Etiqueta5.AutoSize = True
        Me.Etiqueta5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta5.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta5.Location = New System.Drawing.Point(6, 11)
        Me.Etiqueta5.Name = "Etiqueta5"
        Me.Etiqueta5.Size = New System.Drawing.Size(39, 14)
        Me.Etiqueta5.TabIndex = 2
        Me.Etiqueta5.Text = "Desde:"
        '
        'fecDesde
        '
        Me.fecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecDesde.Location = New System.Drawing.Point(51, 8)
        Me.fecDesde.Name = "fecDesde"
        Me.fecDesde.Size = New System.Drawing.Size(104, 20)
        Me.fecDesde.TabIndex = 3
        '
        'fecHasta
        '
        Me.fecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecHasta.Location = New System.Drawing.Point(51, 33)
        Me.fecHasta.Name = "fecHasta"
        Me.fecHasta.Size = New System.Drawing.Size(104, 20)
        Me.fecHasta.TabIndex = 4
        '
        'Etiqueta6
        '
        Appearance92.BackColor = System.Drawing.Color.Transparent
        Appearance92.ForeColor = System.Drawing.Color.Navy
        Me.Etiqueta6.Appearance = Appearance92
        Me.Etiqueta6.AutoSize = True
        Me.Etiqueta6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta6.ForeColor = System.Drawing.Color.Black
        Me.Etiqueta6.Location = New System.Drawing.Point(6, 36)
        Me.Etiqueta6.Name = "Etiqueta6"
        Me.Etiqueta6.Size = New System.Drawing.Size(36, 14)
        Me.Etiqueta6.TabIndex = 3
        Me.Etiqueta6.Text = "Hasta:"
        '
        'rdbFechas
        '
        Me.rdbFechas.AutoSize = True
        Me.rdbFechas.BackColor = System.Drawing.Color.Transparent
        Me.rdbFechas.Checked = True
        Me.rdbFechas.ForeColor = System.Drawing.Color.Navy
        Me.rdbFechas.Location = New System.Drawing.Point(6, 19)
        Me.rdbFechas.Name = "rdbFechas"
        Me.rdbFechas.Size = New System.Drawing.Size(116, 17)
        Me.rdbFechas.TabIndex = 1
        Me.rdbFechas.TabStop = True
        Me.rdbFechas.Text = "Fecha Vencimiento"
        Me.rdbFechas.UseVisualStyleBackColor = False
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.tabControl)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(1039, 607)
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.UltraTabSharedControlsPage2)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl3)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl4)
        Me.tabControl.Controls.Add(Me.UltraTabPageControl5)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SharedControlsPage = Me.UltraTabSharedControlsPage2
        Me.tabControl.Size = New System.Drawing.Size(1039, 607)
        Me.tabControl.TabIndex = 5
        UltraTab3.Key = "tabUnidad"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Por unidad"
        UltraTab4.Key = "tabMasivo"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Masivo"
        UltraTab5.Key = "TabIgual"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Igual Caracterisicas"
        Me.tabControl.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab4, UltraTab5})
        Me.tabControl.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage2
        '
        Me.UltraTabSharedControlsPage2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage2.Name = "UltraTabSharedControlsPage2"
        Me.UltraTabSharedControlsPage2.Size = New System.Drawing.Size(1037, 584)
        '
        'ogdCliente
        '
        Me.ogdCliente.Band.Columns.AddRange(New Object() {UltraDataColumn20, UltraDataColumn21, UltraDataColumn22})
        '
        'odImagen
        '
        UltraDataColumn23.DataType = GetType(System.Drawing.Bitmap)
        Me.odImagen.Band.Columns.AddRange(New Object() {UltraDataColumn23})
        '
        'UltraPrintPreviewDialog1
        '
        Me.UltraPrintPreviewDialog1.Name = "UltraPrintPreviewDialog1"
        '
        'odVehiculos
        '
        Me.odVehiculos.Band.Columns.AddRange(New Object() {UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ficImgDocVeh
        '
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl1)
        Me.ficImgDocVeh.Controls.Add(Me.UltraTabPageControl2)
        Me.ficImgDocVeh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ficImgDocVeh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ficImgDocVeh.Location = New System.Drawing.Point(0, 0)
        Me.ficImgDocVeh.Name = "ficImgDocVeh"
        Me.ficImgDocVeh.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.ficImgDocVeh.Size = New System.Drawing.Size(1041, 630)
        Me.ficImgDocVeh.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Lista"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Mantenimiento"
        Me.ficImgDocVeh.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        Me.ficImgDocVeh.TabStop = False
        Me.ficImgDocVeh.ViewStyle = Infragistics.Win.UltraWinTabControl.ViewStyle.Office2007
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(1039, 607)
        '
        'ugb_Espera
        '
        Me.ugb_Espera.Location = New System.Drawing.Point(323, 283)
        Me.ugb_Espera.Name = "ugb_Espera"
        Me.ugb_Espera.Size = New System.Drawing.Size(395, 65)
        Me.ugb_Espera.TabIndex = 17
        Me.ugb_Espera.Visible = False
        '
        'frm_DocumentosScanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 630)
        Me.Controls.Add(Me.ugb_Espera)
        Me.Controls.Add(Me.ficImgDocVeh)
        Me.Name = "frm_DocumentosScanner"
        Me.Text = "Documentos Vehiculos"
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.Agrupacion4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion4.ResumeLayout(False)
        CType(Me.upbDocVeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion3.ResumeLayout(False)
        Me.Agrupacion3.PerformLayout()
        CType(Me.griImagenesInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odImgDocVeh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMotrizInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeloInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcaINd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoVehInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeloFuncInd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        CType(Me.Agrupacion6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion6.ResumeLayout(False)
        CType(Me.griVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion5.ResumeLayout(False)
        Me.Agrupacion5.PerformLayout()
        CType(Me.chkMotrizMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoVehMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeloFuncional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVigente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griImagenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculoMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVencimientoMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumentoMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionMasivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.Agrupacion8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion8.ResumeLayout(False)
        CType(Me.gridDocumentoVehiculoIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agrupacion9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion9.ResumeLayout(False)
        Me.Agrupacion9.PerformLayout()
        CType(Me.chkMotrizIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeloIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarcaIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoVehiculoIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeloFuncionalIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridImagenesIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiculoIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNroDocumentoIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocumentoIgual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionIgual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.Agrupacion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion2.ResumeLayout(False)
        CType(Me.griLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu1.ResumeLayout(False)
        CType(Me.Agrupacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion1.ResumeLayout(False)
        Me.Agrupacion1.PerformLayout()
        CType(Me.Agrupacion7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Agrupacion7.ResumeLayout(False)
        Me.Agrupacion7.PerformLayout()
        CType(Me.cboIndicadorListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboVehiListar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresVencido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoDocLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresPorVencer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColoresGenerado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agrFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.agrFechas.ResumeLayout(False)
        Me.agrFechas.PerformLayout()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.tabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControl.ResumeLayout(False)
        CType(Me.ogdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.odVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ficImgDocVeh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ficImgDocVeh.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ficImgDocVeh As ISL.Controles.Ficha
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion2 As ISL.Controles.Agrupacion
    Friend WithEvents griLista As ISL.Controles.Grilla
    Friend WithEvents Agrupacion1 As ISL.Controles.Agrupacion
    Friend WithEvents rdbDatosAdicionales As System.Windows.Forms.RadioButton
    Friend WithEvents Agrupacion7 As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta7 As ISL.Controles.Etiqueta
    Friend WithEvents cboVehiListar As ISL.Controles.Combo
    Friend WithEvents etiGenerada As ISL.Controles.Etiqueta
    Friend WithEvents ColoresVencido As ISL.Controles.Colores
    Friend WithEvents cboTipoDocLista As ISL.Controles.Combo
    Friend WithEvents etiTerminada As ISL.Controles.Etiqueta
    Friend WithEvents etiEnProceso As ISL.Controles.Etiqueta
    Friend WithEvents ColoresPorVencer As ISL.Controles.Colores
    Friend WithEvents ColoresGenerado As ISL.Controles.Colores
    Friend WithEvents agrFechas As ISL.Controles.Agrupacion
    Friend WithEvents Etiqueta5 As ISL.Controles.Etiqueta
    Friend WithEvents fecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta6 As ISL.Controles.Etiqueta
    Friend WithEvents rdbFechas As System.Windows.Forms.RadioButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents tabControl As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage2 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion3 As ISL.Controles.Agrupacion
    Friend WithEvents chkMotrizInd As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtModeloInd As ISL.Controles.Texto
    Friend WithEvents Etiqueta20 As ISL.Controles.Etiqueta
    Friend WithEvents txtMarcaINd As ISL.Controles.Texto
    Friend WithEvents Etiqueta21 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoVehInd As ISL.Controles.Texto
    Friend WithEvents Etiqueta22 As ISL.Controles.Etiqueta
    Friend WithEvents txtModeloFuncInd As ISL.Controles.Texto
    Friend WithEvents Etiqueta23 As ISL.Controles.Etiqueta
    Friend WithEvents rbVehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents cboTrabajador As ISL.Controles.Combo
    Friend WithEvents cboVehiculo As ISL.Controles.Combo
    Friend WithEvents Etiqueta1 As ISL.Controles.Etiqueta
    Friend WithEvents etiTrabajador As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumento As ISL.Controles.Texto
    Friend WithEvents rbTrabajador As System.Windows.Forms.RadioButton
    Friend WithEvents cboTipoDocumento As ISL.Controles.Combo
    Friend WithEvents Etiqueta4 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta8 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta2 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta3 As ISL.Controles.Etiqueta
    Friend WithEvents btnExaminar As ISL.Controles.Boton
    Friend WithEvents fecFechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As ISL.Controles.Texto
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Agrupacion6 As ISL.Controles.Agrupacion
    Friend WithEvents Agrupacion5 As ISL.Controles.Agrupacion
    Friend WithEvents chkMotrizMasivo As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtModelo As ISL.Controles.Texto
    Friend WithEvents Etiqueta19 As ISL.Controles.Etiqueta
    Friend WithEvents txtMarca As ISL.Controles.Texto
    Friend WithEvents Etiqueta18 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoVehMasivo As ISL.Controles.Texto
    Friend WithEvents Etiqueta17 As ISL.Controles.Etiqueta
    Friend WithEvents txtModeloFuncional As ISL.Controles.Texto
    Friend WithEvents Etiqueta13 As ISL.Controles.Etiqueta
    Friend WithEvents chkVigente As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents btnVerGrande As Infragistics.Win.Misc.UltraButton
    Friend WithEvents griImagenes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAgregarMasivo As Infragistics.Win.Misc.UltraButton
    Friend WithEvents upbImagenMasivo As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents Etiqueta10 As ISL.Controles.Etiqueta
    Friend WithEvents cboVehiculoMasivo As ISL.Controles.Combo
    Friend WithEvents Etiqueta11 As ISL.Controles.Etiqueta
    Friend WithEvents txtVencimientoMasivo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Etiqueta12 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumentoMasivo As ISL.Controles.Texto
    Friend WithEvents cboTipoDocMasivo As ISL.Controles.Combo
    Friend WithEvents Etiqueta15 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta16 As ISL.Controles.Etiqueta
    Friend WithEvents dtpVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcionMasivo As ISL.Controles.Texto
    Friend WithEvents UltraPrintPreviewDialog1 As Infragistics.Win.Printing.UltraPrintPreviewDialog
    Friend WithEvents odImgDocVeh As ISL.Controles.OrigenDatos
    Friend WithEvents Filtro1 As ISL.Controles.Filtro
    Private WithEvents ContextMenu1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuVigencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents odVehiculos As ISL.Controles.OrigenDatos
    Friend WithEvents odImagen As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griImagenesInd As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnImagenMasivo As ISL.Controles.Boton
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents btnImportar As ISL.Controles.Boton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Etiqueta24 As ISL.Controles.Etiqueta
    Friend WithEvents fecFechaVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpVigencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta14 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta25 As ISL.Controles.Etiqueta
    Friend WithEvents Agrupacion8 As ISL.Controles.Agrupacion
    Friend WithEvents gridDocumentoVehiculoIgual As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Agrupacion9 As ISL.Controles.Agrupacion
    Friend WithEvents fecVigenciaIgual As System.Windows.Forms.DateTimePicker
    Friend WithEvents Etiqueta26 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta27 As ISL.Controles.Etiqueta
    Friend WithEvents btnImportarIgual As ISL.Controles.Boton
    Friend WithEvents btnImagenIgual As ISL.Controles.Boton
    Friend WithEvents chkMotrizIgual As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txtModeloIgual As ISL.Controles.Texto
    Friend WithEvents Etiqueta28 As ISL.Controles.Etiqueta
    Friend WithEvents txtMarcaIgual As ISL.Controles.Texto
    Friend WithEvents Etiqueta29 As ISL.Controles.Etiqueta
    Friend WithEvents txtTipoVehiculoIgual As ISL.Controles.Texto
    Friend WithEvents Etiqueta30 As ISL.Controles.Etiqueta
    Friend WithEvents txtModeloFuncionalIgual As ISL.Controles.Texto
    Friend WithEvents Etiqueta31 As ISL.Controles.Etiqueta
    Friend WithEvents btnMostrarIgual As Infragistics.Win.Misc.UltraButton
    Friend WithEvents gridImagenesIgual As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnAgregarIgual As Infragistics.Win.Misc.UltraButton
    Friend WithEvents pixImagenIgual As Infragistics.Win.UltraWinEditors.UltraPictureBox
    Friend WithEvents cboVehiculoIgual As ISL.Controles.Combo
    Friend WithEvents Etiqueta33 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta34 As ISL.Controles.Etiqueta
    Friend WithEvents txtNroDocumentoIgual As ISL.Controles.Texto
    Friend WithEvents cboTipoDocumentoIgual As ISL.Controles.Combo
    Friend WithEvents Etiqueta35 As ISL.Controles.Etiqueta
    Friend WithEvents Etiqueta36 As ISL.Controles.Etiqueta
    Friend WithEvents fecVencimientoIgual As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcionIgual As ISL.Controles.Texto
    Friend WithEvents Vigente As ISL.Controles.Etiqueta
    Friend WithEvents cboIndicadorListar As ISL.Controles.Combo
    Friend WithEvents Etiqueta32 As ISL.Controles.Etiqueta
    Friend WithEvents ugb_Espera As ISL.Win.Espere
    Friend WithEvents Agrupacion4 As ISL.Controles.Agrupacion
    Friend WithEvents upbDocVeh As System.Windows.Forms.PictureBox
    Friend WithEvents ogdCliente As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents griVehiculos As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ToolStripDescargarImg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSincronizar As ISL.Controles.Boton
End Class
